// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Rating.ExcelRater
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Excel.Data.StandardRating;
using MGASystems.IMS.Excel.Rating.ExcelFilePicker;
using MGASystems.IMS.Excel.Views;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Policies.Rating;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Threading;

#nullable disable
namespace MGASystems.IMS.Excel.Rating;

public class ExcelRater : RateWithFactorSetAndUIBase, IConcurrentObject
{
  private readonly bool uiConcurrencyLockingEnabled = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ExcelRating.EnableUIConcurrencyLocking");
  private readonly bool warnOnMultipleRaterInstanceAtPolicyLevel = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ExcelRating.WarnOnMultipleRaterInstanceAtPolicyLevel", true);
  private readonly string boundOptionCopyProcedureName = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ExcelRating.BoundOptionCopyProcedureName", "StandardExcelRater_CopyRaterInformation");
  private readonly ConcurrencyLockLevel uiConcurrencyLockLevel = ExcelRater.GetConcurrencyLockLevelSetting();
  private static readonly HashSet<string> localOpenedRaters = new HashSet<string>();
  private readonly int raterId;
  private readonly string raterName;

  public ExcelRater(int raterId, string raterName)
  {
    this.raterId = raterId;
    this.raterName = raterName;
  }

  public override bool DoesConditionApply(
    int conditionalID,
    ConditionalOperators conditions,
    object amount)
  {
    return false;
  }

  private static ConcurrencyLockLevel GetConcurrencyLockLevelSetting()
  {
    return (ConcurrencyLockLevel) Enum.Parse(typeof (ConcurrencyLockLevel), MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ExcelRating.UIConcurrencyLockLevel", "Quote"));
  }

  protected override bool ManualInitReflectionInfo(ref int raterTypeId, ref string raterTypeName)
  {
    raterTypeName = !string.IsNullOrEmpty(this.raterName) ? this.raterName : throw new InvalidOperationException("rater name not initialized");
    raterTypeId = this.raterId;
    return true;
  }

  protected override Form CreateUI() => (Form) null;

  public override string GetOptionDescription(Guid QuoteOptionGuid)
  {
    StringBuilder stringBuilder = new StringBuilder();
    try
    {
      List<DocTag> tags = new List<DocTag>();
      Dictionary<string, DocTag> dictionary = new Dictionary<string, DocTag>();
      TagParserBase objectAs = (TagParserBase) ObjectFactory.Instance.CreateObjectAs<PolicyTagParser>(typeof (TagParserBase), (object) this.QuoteGuid, (object) QuoteOptionGuid);
      foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable("dbo.tblExcelRating_LineDetails_TagsByOption", new object[2]
      {
        (object) "@quoteOptionGuid",
        (object) QuoteOptionGuid
      }).Rows)
      {
        if (row["Description"] is string key && row["TagName"] is string str)
        {
          DocTag docTag = new DocTag() { TagName = str };
          dictionary.Add(key, docTag);
          tags.Add(docTag);
        }
      }
      if (tags.Count > 0)
      {
        objectAs.ProcessTags(tags);
        foreach (KeyValuePair<string, DocTag> keyValuePair in dictionary)
          stringBuilder.AppendLine(keyValuePair.Key + keyValuePair.Value.TagValue);
      }
    }
    catch
    {
      return "an error occurred while processing tags";
    }
    return stringBuilder.ToString();
  }

  internal void PrepareAndRateOption(bool hasUpdateErrors)
  {
    if (string.IsNullOrWhiteSpace(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RatingProcedure FROM dbo.tblExcelRating_FactorSets WITH(NOLOCK) WHERE FactorSetGuid = @factorsetguid", new object[2]
    {
      (object) "@factorsetguid",
      (object) this.FactorSetGuid
    })))
      return;
    DefaultDatabase.ExecuteNonQuery("dbo.ExcelRating_tblQuoteOptionsSetup", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@lineGuid",
      (object) this.LineGuid
    });
    Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT QuoteOptionGuid FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteGuid = @quoteGuid AND LineGuid = @lineGuid", new object[4]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid,
      (object) "@lineGuid",
      (object) this.LineGuid
    });
    if (!nullable.HasValue || this.Quote.IsBound || hasUpdateErrors)
      return;
    this.RateOption(nullable.Value);
  }

  public virtual bool ValidateExcelSheet(string fileName) => true;

  public virtual bool ShouldRunLatestSheetCheckLogic(Quote quote) => quote.IsRenewal;

  public override void ShowUI()
  {
    if (this.ShouldRunLatestSheetCheckLogic(this.Quote) && !this.Quote.IsEndorsement && !this.Quote.IsBound && !this.Quote.HasBeenQuoted && !this.Quote.IsRated)
    {
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ExcelRating.AlwaysUseLatestSheetOnRenewal"))
      {
        Guid guid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP(1) FactorSetGUID FROM dbo.tblFactorSets WITH(NOLOCK) WHERE Hidden = 0 AND RaterID = @raterID ORDER BY EffectiveDate DESC", new object[2]
        {
          (object) "@raterID",
          (object) this.RaterID
        }) ?? Guid.Empty;
        if (guid != Guid.Empty && guid != this.FactorSetGuid)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblExcelRating_ExcelFileStore WHERE QuoteGuid = @QuoteGuid AND RaterID = @raterID", new object[4]
          {
            (object) "@quoteGuid",
            (object) this.QuoteGuid,
            (object) "@raterID",
            (object) this.raterId
          });
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteDetails SET FactorSetGUID = @FactorSetGUID WHERE QuoteGuid = @QuoteGuid", new object[4]
          {
            (object) "@quoteGuid",
            (object) this.QuoteGuid,
            (object) "@FactorSetGUID",
            (object) guid
          });
          this.FactorSetGuid = guid;
        }
      }
      else if (SecurityManager.Instance.AssertPermission("{83485E4E-FE40-43bd-B7AB-D9BF830AEED8}") && MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ExcelRating.CheckForUpdatedSheetOnRate", true))
      {
        Guid guid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP(1) FactorSetGUID FROM dbo.tblFactorSets WITH(NOLOCK) WHERE Hidden = 0 AND RaterID = @raterID ORDER BY EffectiveDate DESC", new object[2]
        {
          (object) "@raterID",
          (object) this.RaterID
        }) ?? Guid.Empty;
        if (guid != Guid.Empty && guid != this.FactorSetGuid && System.Windows.Forms.MessageBox.Show("Click Yes to use the newer sheet, click No to continue with the current sheet", "There is a newer version of this rating sheet available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblExcelRating_ExcelFileStore WHERE QuoteGuid = @QuoteGuid AND RaterID = @raterID", new object[4]
          {
            (object) "@quoteGuid",
            (object) this.QuoteGuid,
            (object) "@raterID",
            (object) this.raterId
          });
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteDetails SET FactorSetGUID = @FactorSetGUID WHERE QuoteGuid = @QuoteGuid", new object[4]
          {
            (object) "@quoteGuid",
            (object) this.QuoteGuid,
            (object) "@FactorSetGUID",
            (object) guid
          });
          this.FactorSetGuid = guid;
        }
      }
    }
    if (!this.Quote.IsBound && this.ShouldPromptForSpreadSheet())
    {
      ImportSheetWindow importSheetWindow = new ImportSheetWindow(this.Quote);
      bool? nullable1 = importSheetWindow.ShowDialog();
      bool flag1 = true;
      if (!(nullable1.GetValueOrDefault() == flag1 & nullable1.HasValue))
        return;
      switch (importSheetWindow.ButtonResult)
      {
        case ImportSheetWindowResult.CancelButton:
          return;
        case ImportSheetWindowResult.ImportFromWindowsButton:
          Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
          openFileDialog.FileName = "ExcelDocument.xls";
          openFileDialog.DefaultExt = ".xls";
          openFileDialog.Filter = "Excel document (*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb)|*.xls;*.xlsx;*.xltm;*.xlsm;*.xlsb";
          bool? nullable2 = openFileDialog.ShowDialog();
          bool flag2 = true;
          if (nullable2.GetValueOrDefault() == flag2 & nullable2.HasValue)
          {
            if (File.Exists(openFileDialog.FileName) && this.ValidateExcelSheet(openFileDialog.FileName))
            {
              ExcelStandardRatingData ratingData = ExcelStandardRatingData.Create(this.raterId, this.FactorSetGuid, this.QuoteGuid, openFileDialog.FileName);
              ExcelFileTracker.DisplaySaveOptions(openFileDialog.FileName, ratingData, this);
              return;
            }
            if (System.Windows.MessageBox.Show("Press 'Yes' if you'd like to continue and edit the sheet currently associated with this quote, or 'No' to exit rating.", "The file you've selected does not exist.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
              return;
            break;
          }
          if (System.Windows.MessageBox.Show("Press 'Yes' if you'd like to continue and edit the sheet currently associated with this quote, or 'No' to exit rating.", "You've cancelled your import.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            return;
          break;
        case ImportSheetWindowResult.ImportFromIMSButton:
          bool? nullable3 = new ExcelFileList(importSheetWindow.ExcelFileListManager).ShowDialog();
          bool flag3 = true;
          if (nullable3.GetValueOrDefault() == flag3 & nullable3.HasValue)
          {
            ICollectionView defaultView = CollectionViewSource.GetDefaultView((object) importSheetWindow.ExcelFileListManager.ExcelFiles);
            if (defaultView != null && defaultView.CurrentItem is ExcelFileInfo currentItem)
            {
              string str = DocumentManager.FetchDocumentByGuid(currentItem.DocumentStoreGuid, MGATempFolder.CreateTempSubdirectory());
              if (str != null && !string.IsNullOrEmpty(str) && File.Exists(str) && this.ValidateExcelSheet(str))
              {
                ExcelStandardRatingData ratingData = ExcelStandardRatingData.Create(this.raterId, this.FactorSetGuid, this.QuoteGuid, str);
                ExcelFileTracker.DisplaySaveOptions(str, ratingData, this);
                return;
              }
            }
            if (System.Windows.MessageBox.Show("Press 'Yes' if you'd like to continue and edit the sheet currently associated with this quote, or 'No' to exit rating.", "The file you've selected does not exist.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
              return;
            break;
          }
          if (System.Windows.MessageBox.Show("Press 'Yes' if you'd like to continue and edit the sheet currently associated with this quote, or 'No' to exit rating.", "You've cancelled your import.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            return;
          break;
        case ImportSheetWindowResult.ImportFromFileDrop:
          if (File.Exists(importSheetWindow.DroppedFileName) && this.ValidateExcelSheet(importSheetWindow.DroppedFileName))
          {
            ExcelStandardRatingData ratingData = ExcelStandardRatingData.Create(this.raterId, this.FactorSetGuid, this.QuoteGuid, importSheetWindow.DroppedFileName);
            ExcelFileTracker.DisplaySaveOptions(importSheetWindow.DroppedFileName, ratingData, this);
            return;
          }
          if (System.Windows.MessageBox.Show("Press 'Yes' if you'd like to continue and edit the sheet currently associated with this quote, or 'No' to exit rating.", "The file you've selected does not exist.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            return;
          break;
      }
    }
    if (this.uiConcurrencyLockingEnabled && !ConcurrencyManager.RegisterLock((IConcurrentObject) this, ConcurrencyLockManagementType.Manual))
    {
      ObjectLockInfo objectLockedInfo = ConcurrencyManager.GetObjectLockedInfo((IConcurrentObject) this);
      if (objectLockedInfo == null)
        return;
      int num = (int) System.Windows.Forms.MessageBox.Show($"Locked by {CurrentUser.Instance.Users[objectLockedInfo.UserGuid].DisplayName} on {objectLockedInfo.Created:d}.\n" + "Please ask the user to exit the rater if you need to work on it, or you can have the rater unlocked by your IMS Admin.\nDescription: {objectLockInfo.Description}", "This rater is currently locked, and in use by another IMS User.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (this.warnOnMultipleRaterInstanceAtPolicyLevel)
      {
        string str = this.ResolveConcurrencyDataKey(ConcurrencyLockLevel.Quote);
        if (ExcelRater.localOpenedRaters.Contains(str))
        {
          if (System.Windows.Forms.MessageBox.Show("An Excel rater may already be open for this policy. Are you sure you'd like to open another copy?", "Excel Rater may already be open", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;
        }
        else
          ExcelRater.localOpenedRaters.Add(str);
      }
      ExcelFileTracker excelFileTracker = new ExcelFileTracker(this, (object) Dispatcher.CurrentDispatcher);
      excelFileTracker.ShowExcelSheet();
      ObjectFactory.Instance.CreateFormEX(typeof (ExcelDownloadingWaitWindow), (object) excelFileTracker.ExcelFile)?.Show();
      excelFileTracker.ExcelFile.Retrieve();
      this.OnRaterOpened();
    }
  }

  protected virtual bool ShouldPromptForSpreadSheet()
  {
    return DefaultDatabase.ExecuteScalar<bool?>(CommandType.Text, "SELECT RaterDisplaysModally FROM dbo.tblExcelRating_Raters WITH(NOLOCK) WHERE RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) this.RaterID
    }).GetValueOrDefault();
  }

  protected virtual void OnRaterOpened()
  {
  }

  protected internal virtual void OnRaterClosed()
  {
    if (this.uiConcurrencyLockingEnabled)
      ConcurrencyManager.ReleaseLock((IConcurrentObject) this);
    string str = this.ResolveConcurrencyDataKey(ConcurrencyLockLevel.Quote);
    if (!ExcelRater.localOpenedRaters.Contains(str))
      return;
    ExcelRater.localOpenedRaters.Remove(str);
  }

  public override void OnRateOption(Guid quoteOptionGuid)
  {
    ExcelRater.Log($"Saving Excel rater {this.RaterID} data");
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RatingProcedure FROM dbo.tblExcelRating_FactorSets WITH(NOLOCK) WHERE FactorSetGUID = @FactorSetGUID", new object[2]
    {
      (object) "@FactorSetGUID",
      (object) this.FactorSetGuid
    }) ?? "Could not locate excel rating proc from factorset";
    if (!string.IsNullOrEmpty(str))
    {
      try
      {
        DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, str, TimeSpan.FromMinutes(2.0).Seconds, (CommandArgumentType) 0, new object[2]
        {
          (object) "@quoteOptionGuid",
          (object) quoteOptionGuid
        });
        DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT vq.QuoteGuid, vq.Premium FROM dbo.viewInsuredNavigationSearchQuotes vq WHERE vq.QuoteGUID = @quoteGuid", new object[2]
        {
          (object) "@quoteGuid",
          (object) this.QuoteGuid
        });
        if (dataRow != null)
        {
          Guid? nullable = ExtensionsMethods.FieldOrDefault<Guid?>(dataRow, "QuoteGuid", new Guid?());
          if (nullable.HasValue)
          {
            Guid valueOrDefault = nullable.GetValueOrDefault();
            Decimal num = ExtensionsMethods.FieldOrDefault<Decimal>(dataRow, "Premium", 0M);
            Messaging.SendBroadcastMessage(BroadcastMessages.PremiumChanged, (object) new object[2]
            {
              (object) valueOrDefault,
              (object) num
            });
          }
        }
      }
      catch (SqlException ex)
      {
        if (ex.Message == "@quoteOptionGuid is not a parameter")
          this.ShowMessage("The rating procedure defined for this sheet must only have one parameter, and that parameter must be named @quoteOptionGuid, please contact your system administrator with this message.", "Incorrectly defined rating procedure", icon: MessageBoxIcon.Hand);
        else if (ex.Message == "Could not find stored procedure")
          this.ShowMessage(ex.Message + ", please contact your system administrator with this message.", "Rating Procedure does not exist on your database", icon: MessageBoxIcon.Hand);
        else if (ex.Message.Contains("premium"))
          this.ShowMessage(ex.Message, "Invalid Spreadsheet Input", icon: MessageBoxIcon.Hand);
        else if (CurrentUser.IsMGADeveloper)
          this.ShowMessage($"Proc: {str}, Input {quoteOptionGuid}. Had the following error {ex.Message}. Press Ctrl+C to copy this message to your clipboard", "Admin1 only debug info", icon: MessageBoxIcon.Hand);
        else
          this.ShowMessage(ex.Message, "A problem occurred in the excel rating procedure associated with this Quote. Please contact technical support.", icon: MessageBoxIcon.Hand);
      }
    }
    ExcelRater.Log($"Saved Excel rater {this.RaterID} data");
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction((DbTransaction) cmd.Transaction, new ExecuteHandler((object) new ExcelRater.\u003C\u003Ec__DisplayClass21_0()
    {
      \u003C\u003E4__this = this,
      e = e
    }, __methodptr(\u003COnCopyBoundOption\u003Eb__0)));
  }

  public override void OnAfterRaterReset(AfterResetArgs e)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblExcelRating_ExcelFileStore WHERE QuoteGuid = @QuoteGuid AND RaterID = @raterID", new object[4]
    {
      (object) "@QuoteGuid",
      (object) e.Quote,
      (object) "@raterID",
      (object) this.raterId
    });
  }

  public override void OnAfterRaterSetupChange(AfterResetArgs e)
  {
  }

  public void ShowMessage(
    string message,
    string caption,
    MessageBoxButtons buttons = MessageBoxButtons.OK,
    MessageBoxIcon icon = MessageBoxIcon.Asterisk)
  {
    MDIControls instance = MDIControls.Instance;
    if ((instance != null ? (instance.BlackBoxMode ? 1 : 0) : 1) != 0)
    {
      if (icon.ValueIn<MessageBoxIcon>(MessageBoxIcon.Hand, MessageBoxIcon.Hand))
      {
        InvalidOperationException operationException = new InvalidOperationException(message);
        operationException.Data.Add((object) "RaterID", (object) this.raterId);
        operationException.Data.Add((object) "RaterName", (object) this.raterName);
        operationException.Data.Add((object) "QuoteGUID", (object) this.QuoteGuid);
        throw operationException;
      }
    }
    else
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(message, caption, buttons, icon);
  }

  private static void Log(string logString)
  {
    if (MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity activeMdiChild)
    {
      if (activeMdiChild.HasControlGUID)
        CurrentUser.Instance.LogAction(logString, activeMdiChild.ControlGUID, "Not Available");
      else if (activeMdiChild.CanReCreateEntity)
        CurrentUser.Instance.LogAction(logString, activeMdiChild.EntityGuid, "Not Available");
      else
        CurrentUser.Instance.LogAction(logString, "Not Available");
    }
    else
      CurrentUser.Instance.LogAction(logString, "Not Available");
  }

  public static void RefreshWorksheetData(int raterId, Guid quoteGuid)
  {
    ExcelRater.Log($"Invoking rater {raterId} for data refresh only");
    if (quoteGuid == Guid.Empty)
      throw new ArgumentException("Empty Guid is not valid", nameof (quoteGuid));
    string str = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Name FROM dbo.tblExcelRating_Raters WITH(NOLOCK) WHERE RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) raterId
    }) as string;
    if (string.IsNullOrEmpty(str))
      throw new ArgumentException($"The rater id: {raterId} passed in is not valid as an excel rater", nameof (raterId));
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TOP(1) d.FactorSetGUID FROM dbo.tblQuoteDetails d WITH(NOLOCK) JOIN dbo.tblFactorSets f WITH(NOLOCK) ON f.FactorSetGuid = d.FactorSetGUID WHERE f.RaterID = @RaterID AND d.QuoteGuid = @QuoteGuid", new object[4]
    {
      (object) "@RaterId",
      (object) raterId,
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    if (dataTable.Rows.Count == 0)
      throw new Exception("Unable to determine factorset used on this rater");
    ExcelRater objectAs = ObjectFactory.Instance.CreateObjectAs<ExcelRater>((object) raterId, (object) str);
    objectAs.FactorSetGuid = dataTable.Rows[0].Field<Guid>("FactorSetGuid");
    Quote quote = Quote.CreateNew(quoteGuid);
    objectAs.Initialize(quote.QuoteGuid, quote.CompanyLineGuid.Value);
    ExcelStandardRatingData standardRatingData = ExcelStandardRatingData.Create(raterId, objectAs.FactorSetGuid, quoteGuid);
    string[] fileNames;
    byte[][] fileStreams;
    new ZipUtility().ExtractFilesFromZipArchive(DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT CompressedExcelSheet FROM dbo.tblExcelRating_ExcelFileStore WITH(NOLOCK) WHERE RaterId = @RaterId AND QuoteGuid = @QuoteGuid", new object[4]
    {
      (object) "@RaterId",
      (object) raterId,
      (object) "@QuoteGuid",
      (object) quoteGuid
    }), out fileNames, out fileStreams);
    string fileName = ((IEnumerable<string>) fileNames).Single<string>();
    byte[] worksheetBytes = ((IEnumerable<byte[]>) fileStreams).Single<byte[]>();
    standardRatingData.ExcelFile.UpdateNonThreaded(standardRatingData.ExcelMappings, false, standardRatingData.DatabaseTableName, fileName, worksheetBytes);
    if (standardRatingData.ExcelFile.UpdateErrors.Count > 0)
    {
      ExcelRater.Log($"Invoked rater {raterId} for data refresh with errors");
      throw new InvalidOperationException($"Cell {standardRatingData.ExcelFile.UpdateErrors[0].Cell} had error {standardRatingData.ExcelFile.UpdateErrors[0].Error} during import");
    }
    ExcelRater.Log($"Invoked rater {raterId} for data refresh only");
  }

  public static void RefreshWorksheetData(int raterId, Guid factorsetGuid, Guid quoteGuid)
  {
    ExcelRater.Log($"Invoking rater {raterId} for data refresh only");
    if (quoteGuid == Guid.Empty)
      throw new ArgumentException("Empty Guid is not valid", nameof (quoteGuid));
    if (factorsetGuid == Guid.Empty)
      throw new ArgumentException("Empty Guid is not valid", nameof (factorsetGuid));
    string str = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Name FROM dbo.tblExcelRating_Raters WITH(NOLOCK) WHERE RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) raterId
    }) as string;
    if (string.IsNullOrEmpty(str))
      throw new ArgumentException($"The rater id: {raterId} passed in is not valid as an excel rater", nameof (raterId));
    ExcelRater objectAs = ObjectFactory.Instance.CreateObjectAs<ExcelRater>((object) raterId, (object) str);
    objectAs.FactorSetGuid = factorsetGuid;
    Quote quote = new Quote(quoteGuid);
    objectAs.Initialize(quote.QuoteGuid, quote.CompanyLineGuid.Value);
    ExcelStandardRatingData standardRatingData = ExcelStandardRatingData.Create(raterId, objectAs.FactorSetGuid, quoteGuid);
    string[] fileNames;
    byte[][] fileStreams;
    new ZipUtility().ExtractFilesFromZipArchive(DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT CompressedExcelSheet FROM dbo.tblExcelRating_ExcelFileStore WITH(NOLOCK) WHERE RaterId = @RaterId AND QuoteGuid = @QuoteGuid", new object[4]
    {
      (object) "@RaterId",
      (object) raterId,
      (object) "@QuoteGuid",
      (object) quoteGuid
    }), out fileNames, out fileStreams);
    string fileName = ((IEnumerable<string>) fileNames).Single<string>();
    byte[] worksheetBytes = ((IEnumerable<byte[]>) fileStreams).Single<byte[]>();
    standardRatingData.ExcelFile.UpdateNonThreaded(standardRatingData.ExcelMappings, false, standardRatingData.DatabaseTableName, fileName, worksheetBytes);
    if (standardRatingData.ExcelFile.UpdateErrors.Count > 0)
    {
      ExcelRater.Log($"Invoked rater {raterId} for data refresh with errors");
      throw new InvalidOperationException($"Cell {standardRatingData.ExcelFile.UpdateErrors[0].Cell} had error {standardRatingData.ExcelFile.UpdateErrors[0].Error} during import");
    }
    ExcelRater.Log($"Invoked rater {raterId} for data refresh only");
  }

  public static void ParseWorksheetFile(string fileName, int raterId, Guid quoteGuid)
  {
    byte[] worksheetBytes = FileReader.ReadAllBytes(fileName);
    ExcelRater.ParseWorksheetFile(fileName, worksheetBytes, raterId, quoteGuid);
  }

  public static void ParseWorksheetFile(string fileName, Guid factorSetGuid, Guid quoteGuid)
  {
    byte[] worksheetBytes = FileReader.ReadAllBytes(fileName);
    ExcelRater.ParseWorksheetFile(fileName, worksheetBytes, factorSetGuid, quoteGuid);
  }

  public static void ParseWorksheetFile(
    string fileName,
    byte[] worksheetBytes,
    int raterId,
    Guid quoteGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TOP(1) FactorSetGuid FROM dbo.tblFactorSets WITH(NOLOCK) WHERE RaterID = @RaterId AND Hidden = 0 ORDER BY EffectiveDate DESC", new object[2]
    {
      (object) "@RaterId",
      (object) raterId
    });
    if (dataTable.Rows.Count == 0)
      throw new Exception("No factorsets available for this rater");
    ExcelRater.ParseWorksheetFile(fileName, worksheetBytes, raterId, dataTable.Rows[0].Field<Guid>("FactorSetGuid"), quoteGuid);
  }

  public static void ParseWorksheetFile(
    string fileName,
    byte[] worksheetBytes,
    Guid factorSetGuid,
    Guid quoteGuid)
  {
    int raterId = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT TOP(1) RaterID FROM dbo.tblFactorSets WITH(NOLOCK) WHERE FactorSetGuid = @FactorSetGuid", new object[2]
    {
      (object) "@FactorSetGuid",
      (object) factorSetGuid
    });
    ExcelRater.ParseWorksheetFile(fileName, worksheetBytes, raterId, factorSetGuid, quoteGuid);
  }

  private static void ParseWorksheetFile(
    string fileName,
    byte[] worksheetBytes,
    int raterId,
    Guid factorSetGuid,
    Guid quoteGuid)
  {
    ExcelRater.Log($"Invoking rater {raterId} for data parse");
    Quote quote = !(quoteGuid == Guid.Empty) ? new Quote(quoteGuid) : throw new ArgumentException("Empty Guid is not valid", nameof (quoteGuid));
    string str = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Name FROM dbo.tblExcelRating_Raters WITH(NOLOCK) WHERE RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) raterId
    }) as string;
    if (string.IsNullOrEmpty(str))
      throw new ArgumentException($"The rater id: {raterId} passed in is not valid as an excel rater", nameof (raterId));
    if (quote.IsBound && !MGASystems.IMS.Excel.Data.Security.CanSaveSheetOnBoundQuote(raterId))
      throw new InvalidOperationException($"Quote Ctrl: {quote.ControlNo} is bound");
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteDetails SET RaterID = @rater, FactorSetGuid = @factorset WHERE QuoteGuid = @quoteGuid", new object[6]
    {
      (object) "@quoteGuid",
      (object) quoteGuid,
      (object) "@rater",
      (object) raterId,
      (object) "@factorset",
      (object) factorSetGuid
    });
    ExcelRater objectAs = ObjectFactory.Instance.CreateObjectAs<ExcelRater>((object) raterId, (object) str);
    objectAs.FactorSetGuid = factorSetGuid;
    Guid quoteGuid1 = quote.QuoteGuid;
    QuoteDetail quoteDetail = quote.QuoteDetails.FirstOrDefault<QuoteDetail>();
    Guid companyLineGuid = quoteDetail != null ? quoteDetail.CompanyLineGuid : quote.CompanyLineGuid.Value;
    objectAs.Initialize(quoteGuid1, companyLineGuid);
    ExcelStandardRatingData standardRatingData = ExcelStandardRatingData.Create(raterId, factorSetGuid, quoteGuid);
    standardRatingData.ExcelFile.UpdateNonThreaded(standardRatingData.ExcelMappings, true, standardRatingData.DatabaseTableName, fileName, worksheetBytes);
    objectAs.PrepareAndRateOption(standardRatingData.ExcelFile.HasUpdateErrors);
    if (standardRatingData.ExcelFile.UpdateErrors.Count > 0)
    {
      ExcelRater.Log($"Invoked rater {raterId} for data capture with errors");
      throw new InvalidOperationException($"Cell {standardRatingData.ExcelFile.UpdateErrors[0].Cell} had error {standardRatingData.ExcelFile.UpdateErrors[0].Error} during import");
    }
    ExcelRater.Log($"Invoked rater {raterId} for data parse");
  }

  public static void InvokeRaterForDataCaptureDirect(Guid factorSetGuid, Guid quoteGuid)
  {
    ExcelRater.InvokeRaterForDataCaptureDirect(DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT TOP(1) RaterID FROM dbo.tblFactorSets WITH(NOLOCK) WHERE FactorSetGuid = @FactorSetGuid", new object[2]
    {
      (object) "@FactorSetGuid",
      (object) factorSetGuid
    }), factorSetGuid, quoteGuid);
  }

  public static void InvokeRaterForDataCaptureDirect(int raterId, Guid quoteGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TOP(1) FactorSetGuid FROM dbo.tblFactorSets WITH(NOLOCK) WHERE RaterID = @RaterId AND Hidden = 0 ORDER BY EffectiveDate DESC", new object[2]
    {
      (object) "@RaterId",
      (object) raterId
    });
    if (dataTable.Rows.Count == 0)
    {
      MGASystems.Common.ThreadingFunctions.MessageBox.Show("Please refer this error to your system administrator for assistance.", "No factorsets available for this rater", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      if (dataTable.Rows.Count > 1)
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Please refer this error to your system administrator for assistance.", "Only one unhidden factorset is valid for data capture using excel by rater id", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ExcelRater.InvokeRaterForDataCaptureDirect(raterId, dataTable.Rows[0].Field<Guid>("FactorSetGuid"), quoteGuid);
    }
  }

  public static void InvokeRaterForDataCaptureDirect(
    int raterId,
    Guid factorSetGuid,
    Guid quoteGuid)
  {
    ExcelRater.Log($"Invoking rater {raterId} for data capture");
    Quote quote = !(quoteGuid == Guid.Empty) ? Quote.CreateNew(quoteGuid) : throw new ArgumentException("Empty Guid is not valid", nameof (quoteGuid));
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Name FROM dbo.tblExcelRating_Raters WITH(NOLOCK) WHERE RatingTypeId = @RatingTypeId", new object[2]
    {
      (object) "@RatingTypeId",
      (object) raterId
    });
    if (string.IsNullOrEmpty(str))
      throw new ArgumentException("The rater id passed in is not valid as an excel rater", nameof (raterId));
    ExcelRater objectAs = ObjectFactory.Instance.CreateObjectAs<ExcelRater>((object) raterId, (object) str);
    objectAs.FactorSetGuid = factorSetGuid;
    objectAs.Initialize(quote.QuoteGuid, quote.CompanyLineGuid.Value);
    objectAs.ShowUI();
    ExcelRater.Log($"Invoked rater {raterId} for data capture");
  }

  public string DataKey => this.ResolveConcurrencyDataKey(this.uiConcurrencyLockLevel);

  public string LockDescription
  {
    get => this.ResolveConcurrencyLockDescription(this.uiConcurrencyLockLevel);
  }

  protected virtual string ResolveConcurrencyDataKey(ConcurrencyLockLevel lockLevel)
  {
    switch (lockLevel)
    {
      case ConcurrencyLockLevel.Quote:
        return $"RaterID{this.RaterID},ControlNo{this.ControlNumber}";
      case ConcurrencyLockLevel.Submission:
        return $"RaterID{this.RaterID},SubmissionID{this.Quote.SubmissionGroup.SubmissionGroupID}";
      case ConcurrencyLockLevel.Insured:
        return $"RaterID{0},InsuredGUID{this.Quote.SubmissionGroup.InsuredGuid}";
      default:
        throw new InvalidOperationException("Invalid ConcurrencyLockLevel specified");
    }
  }

  protected virtual string ResolveConcurrencyLockDescription(ConcurrencyLockLevel lockLevel)
  {
    switch (lockLevel)
    {
      case ConcurrencyLockLevel.Quote:
        return $"Policy Level Lock on Rater: {this.RaterName} (Control: {this.ControlNumber}).";
      case ConcurrencyLockLevel.Submission:
        return $"Submission Level Lock on Rater: {this.RaterName} (Submission ID: {this.Quote.SubmissionGroup.SubmissionGroupID}, Opened from Control: {this.ControlNumber}).";
      case ConcurrencyLockLevel.Insured:
        return $"Insured Level Lock on Rater: {this.RaterName} (Insured {this.Quote.InsuredPolicyName}, Opened from Control: {this.ControlNumber}).";
      default:
        throw new InvalidOperationException("Invalid ConcurrencyLockLevel specified");
    }
  }
}
