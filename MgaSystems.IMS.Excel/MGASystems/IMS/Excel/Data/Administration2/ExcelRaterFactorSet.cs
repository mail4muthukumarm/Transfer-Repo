// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.ExcelRaterFactorSet
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using MgaSystems.IMS.Excel.Data;
using MGASystems.IMS.NoteDocuments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

[Description("Excel Sheet Version")]
[TableMapping("tblFactorSets")]
public abstract class ExcelRaterFactorSet : OnDemandViewModel, IDataErrorInfo, IDataTransferFilter
{
  private static Guid? companyLineGuid;
  private readonly BulkObservableCollection<ExcelMapping> excelMappings = new BulkObservableCollection<ExcelMapping>();
  private readonly BulkObservableCollection<ExcelLineQuoteDetail> excelLineQuoteDetails = new BulkObservableCollection<ExcelLineQuoteDetail>();
  private readonly BulkObservableCollection<RaterScheduleLink> scheduleLinks = new BulkObservableCollection<RaterScheduleLink>();

  internal Guid? FactorSetInitializedFrom { get; set; }

  public ExcelRater Parent { get; }

  public ExcelRaterFactorSet(
    ExcelRater parent,
    Guid? factorSetGuid,
    DateTime effectiveDate,
    bool hidden,
    string title,
    string memo,
    string ratingProcedure,
    bool showUpdateHistoricOptions,
    bool roundPremiums,
    bool includeLeapDayInProrataCalc,
    bool disableAllProrataCalculation,
    bool allowZeroPremium,
    bool useWebServiceParameters)
  {
    this.Parent = parent;
    this.FactorSetGuid = factorSetGuid;
    this.EffectiveDate = effectiveDate;
    this.Hidden = hidden;
    this.Title = title;
    this.Memo = memo;
    this.RatingProcedure = ratingProcedure;
    this.ShowUpdateHistoricOptions = showUpdateHistoricOptions;
    this.RoundPremiums = roundPremiums;
    this.IncludeLeapDayInProrataCalc = includeLeapDayInProrataCalc;
    this.DisableAllProrataCalculation = disableAllProrataCalculation;
    this.AllowZeroPremium = allowZeroPremium;
    this.UseWebServiceParameters = useWebServiceParameters;
  }

  public static ExcelRaterFactorSet Create(
    ExcelRater parent,
    Guid? factorSetGuid,
    DateTime effectiveDate,
    bool hidden,
    string title,
    string memo,
    string ratingProcedure,
    bool showUpdateHistoricOptions,
    bool roundPremiums,
    bool includeLeapDayInProrataCalc,
    bool disableAllProrataCalculation,
    bool allowZeroPremium,
    bool useWebServiceParameters)
  {
    return NotifyProxyTypeManager.Allocate<ExcelRaterFactorSet>(new object[13]
    {
      (object) parent,
      (object) factorSetGuid,
      (object) effectiveDate,
      (object) hidden,
      (object) title,
      (object) memo,
      (object) ratingProcedure,
      (object) showUpdateHistoricOptions,
      (object) roundPremiums,
      (object) includeLeapDayInProrataCalc,
      (object) disableAllProrataCalculation,
      (object) allowZeroPremium,
      (object) useWebServiceParameters
    });
  }

  [TrackChanges]
  [DataKey]
  [TableFieldMapping]
  public Guid? FactorSetGuid { get; set; }

  [Required]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual DateTime EffectiveDate { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual bool Hidden { get; set; }

  [NotificationProperty]
  public virtual int SelectedTabIndex { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual byte[] ExcelTemplate { get; set; }

  [Required]
  [StringLength(50)]
  [RegularExpression("^[a-zA-Z0-9_/\\\\\\-' '().,]*$")]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Title { get; set; }

  [StringLength(200)]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Memo { get; set; }

  [TrackChanges]
  [NotificationProperty]
  [StringLength(100)]
  public virtual string RatingProcedure { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool ShowUpdateHistoricOptions { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool RoundPremiums { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool IncludeLeapDayInProrataCalc { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool DisableAllProrataCalculation { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool AllowZeroPremium { get; set; }

  [TrackChanges]
  [NotificationProperty]
  public virtual bool UseWebServiceParameters { get; set; }

  [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Used in XAML so there is no direct reference, but must be a public instance property.")]
  public bool IsAdminUser => CurrentUser.IsMGADeveloper;

  public bool IsNewFactorSet => !this.FactorSetGuid.HasValue;

  [DisallowDuplicateValues("DatabaseField")]
  [CustomValidation(typeof (ExcelRaterFactorSet), "ValidateMappingCount")]
  public BulkObservableCollection<ExcelMapping> ExcelMappings
  {
    get
    {
      this.InitializeChildNodes();
      return this.excelMappings;
    }
  }

  public BulkObservableCollection<ExcelLineQuoteDetail> ExcelLineQuoteDetails
  {
    get
    {
      this.InitializeChildNodes();
      return this.excelLineQuoteDetails;
    }
  }

  public BulkObservableCollection<RaterScheduleLink> ScheduleLinks
  {
    get
    {
      this.InitializeChildNodes();
      return this.scheduleLinks;
    }
  }

  protected override void ProcessChildNodes(object childNodes)
  {
    DataTable[] dataTableArray = (DataTable[]) childNodes;
    this.ExcelMappings.AddRange((IEnumerable<ExcelMapping>) dataTableArray[0].AsEnumerable().Select<DataRow, ExcelMapping>((System.Func<DataRow, ExcelMapping>) (row => ExcelMapping.Create(this, row.Field<int>("ID"), row.Field<string>("Cell"), row.Field<string>("DatabaseField"), row.Field<string>("DatabaseFieldType"), row.Field<string>("PremiumOption"), row.Field<string>("TagParserTagName"), row.Field<bool?>("DatabaseFieldAllowNull")))));
    this.ExcelLineQuoteDetails.AddRange(dataTableArray[1].Rows.Cast<DataRow>().Select<DataRow, ExcelLineQuoteDetail>((System.Func<DataRow, ExcelLineQuoteDetail>) (row => ExcelLineQuoteDetail.Create(this, new int?(row.Field<int>("ID")), row.Field<Guid?>("LineGuid"), row.Field<string>("Description"), row.Field<string>("TagName")))));
    this.ScheduleLinks.AddRange(dataTableArray[2].Rows.Cast<DataRow>().Select<DataRow, RaterScheduleLink>((System.Func<DataRow, RaterScheduleLink>) (row => new RaterScheduleLink(this, row.Field<int>("ScheduleRaterID"), row.Field<Guid>("ScheduleFactorSetGuid"), row.Field<string>("ScheduleName"), row.Field<string>("ScheduleVersionTitle"), row.Field<DateTime>("ScheduleEffectiveDate"), row.Field<int?>("RowStart"), row.Field<int?>("RowEnd"), row.Field<int?>("SetinelColumn"), row.Field<string>("NullSetinelRetVal")))));
    this.Parent.Parent.ChangeManager?.StartMonitor((INotifyPropertyChanged) this.ExcelMappings, "ExcelMappings");
    this.Parent.Parent.ChangeManager?.StartMonitor((INotifyPropertyChanged) this.ExcelLineQuoteDetails, "ExcelLineQuoteDetails");
  }

  protected override object FetchChildNodes()
  {
    return (object) new DataTable[3]
    {
      DefaultDatabase.ExecuteDataTable("tblExcelRating_Mappings_SelectByFactorSet", new object[2]
      {
        (object) "@factorSetId",
        (object) this.FactorSetGuid
      }),
      DefaultDatabase.ExecuteDataTable("tblExcelRating_LineDetails_SelectByFactorSet", new object[2]
      {
        (object) "@factorSetId",
        (object) this.FactorSetGuid
      }),
      DefaultDatabase.ExecuteDataTable("ExcelRating_FetchAssociatedSchedules", new object[2]
      {
        (object) "@raterFactorSetGuid",
        (object) this.FactorSetGuid
      })
    };
  }

  public static List<ExcelMapping> GetMappings(Guid quoteGuid, Guid factorsetGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("tblExcelRating_Mappings_SelectByFactorSet", new object[2]
    {
      (object) "@factorSetId",
      (object) factorsetGuid
    });
    string parentRaterName = (string) DefaultDatabase.ExecuteScalar(CommandType.Text, "select r.RatingType from lstRatingTypes r inner join tblFactorSets f on r.RatingTypeID = f.RaterID where f.FactorSetGUID = @FactorSetGUID", new object[2]
    {
      (object) "@FactorSetGUID",
      (object) factorsetGuid
    });
    IEnumerable<ExcelMapping> source = dataTable.Rows.Cast<DataRow>().Select<DataRow, ExcelMapping>((System.Func<DataRow, ExcelMapping>) (row => ExcelMapping.Create(parentRaterName, row.Field<int>("ID"), row.Field<string>("Cell"), row.Field<string>("DatabaseField"), row.Field<string>("DatabaseFieldType"), row.Field<string>("PremiumOption"), row.Field<string>("TagParserTagName"), row.Field<bool?>("DatabaseFieldAllowNull"))));
    if (!new Quote(quoteGuid).IsBound)
      return source.ToList<ExcelMapping>();
    if (MDIControls.Instance.BlackBoxMode || !CurrentUser.IsMGADeveloper)
      return source.Where<ExcelMapping>((System.Func<ExcelMapping, bool>) (mapping => string.IsNullOrEmpty(mapping.PremiumOption))).ToList<ExcelMapping>();
    Form mdiParent = MDIControls.Instance.MDIParent;
    bool flag = false;
    if (Thread.CurrentThread.GetApartmentState() == ApartmentState.STA)
      flag = mdiParent.InvokeRequired ? (bool) mdiParent.Invoke((Delegate) (() => Keyboard.IsKeyDown(Key.LeftCtrl))) : Keyboard.IsKeyDown(Key.LeftCtrl);
    return !flag ? source.Where<ExcelMapping>((System.Func<ExcelMapping, bool>) (mapping => string.IsNullOrEmpty(mapping.PremiumOption))).ToList<ExcelMapping>() : source.ToList<ExcelMapping>();
  }

  public override bool LoadChildNodesOnThread
  {
    get => this.FactorSetGuid.HasValue && this.Parent.Parent.LoadChildNodesOnThread;
  }

  public override bool FreezeChildNodeLoad => this.Parent.Parent.FreezeChildNodeLoad;

  [TableFieldMapping]
  public int RaterId => this.Parent.RatingTypeID;

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  public void OnWriteAdditionalValuesToSource(Dictionary<string, object> values)
  {
    if (!ExcelRaterFactorSet.companyLineGuid.HasValue)
      ExcelRaterFactorSet.companyLineGuid = new Guid?((Guid) DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 CompanyLineGuid from tblCompanyLines (nolock)"));
    values.Add("CompanyLineGuid", (object) ExcelRaterFactorSet.companyLineGuid.Value);
    Guid? factorSetGuid = this.FactorSetGuid;
    if (!factorSetGuid.HasValue)
    {
      this.FactorSetGuid = new Guid?(Guid.NewGuid());
      values.Add("FactorSetGuid", (object) this.FactorSetGuid);
      this.Parent.Parent.StatusText = "Uploading Worksheet Information, Please Wait (this may take a minute).";
      this.Parent.Parent.SheetUploadPercentage = 1;
      object[] objArray1 = new object[18];
      objArray1[0] = (object) "@FactorSetGuid";
      factorSetGuid = this.FactorSetGuid;
      objArray1[1] = (object) factorSetGuid.Value;
      objArray1[2] = (object) "@CompressedExcelSheet";
      objArray1[3] = (object) Array.Empty<byte>();
      objArray1[4] = (object) "@RatingProcedure";
      objArray1[5] = (object) this.RatingProcedure;
      objArray1[6] = (object) "@ShowUpdateHistoricOptions";
      objArray1[7] = (object) this.ShowUpdateHistoricOptions;
      objArray1[8] = (object) "@RoundPremiums";
      objArray1[9] = (object) this.RoundPremiums;
      objArray1[10] = (object) "@IncludeLeapDayInProrataCalc";
      objArray1[11] = (object) this.IncludeLeapDayInProrataCalc;
      objArray1[12] = (object) "@DisableAllProrataCalculation";
      objArray1[13] = (object) this.DisableAllProrataCalculation;
      objArray1[14] = (object) "@AllowZeroPremium";
      objArray1[15] = (object) this.AllowZeroPremium;
      objArray1[16 /*0x10*/] = (object) "@UseWebServiceParameters";
      objArray1[17] = (object) this.UseWebServiceParameters;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "insert into tblExcelRating_FactorSets (FactorSetGuid, CompressedExcelSheet, RatingProcedure, ShowUpdateHistoricOptions, RoundPremiums, IncludeLeapDayInProrataCalc, DisableAllProrataCalculation, AllowZeroPremium, UseWebServiceParameters) values (@FactorSetGuid, @CompressedExcelSheet, @RatingProcedure, @ShowUpdateHistoricOptions, @RoundPremiums, @IncludeLeapDayInProrataCalc, @DisableAllProrataCalculation, @AllowZeroPremium, @UseWebServiceParameters)", objArray1);
      this.Parent.Parent.StatusText = "Uploading Worksheet Information, Please Wait (this may take a minute)..";
      this.Parent.Parent.SheetUploadPercentage = 2;
      this.EnsureChildNodesCreated();
      this.Parent.Parent.StatusText = "Uploading Worksheet Schedules, Please Wait (this may take a minute).";
      this.Parent.Parent.SheetUploadPercentage = 3;
      foreach (RaterScheduleLink scheduleLink in (Collection<RaterScheduleLink>) this.ScheduleLinks)
      {
        object[] objArray2 = new object[12];
        objArray2[0] = (object) "@raterFactorSetGuid";
        factorSetGuid = this.FactorSetGuid;
        objArray2[1] = (object) factorSetGuid.Value;
        objArray2[2] = (object) "@scheduleFactorSetGuid";
        objArray2[3] = (object) scheduleLink.ScheduleFactorSetGuid;
        objArray2[4] = (object) "@RowStart";
        objArray2[5] = (object) scheduleLink.RowStart;
        objArray2[6] = (object) "@RowEnd";
        objArray2[7] = (object) scheduleLink.RowEnd;
        objArray2[8] = (object) "@SetinelColumn";
        objArray2[9] = (object) scheduleLink.SetinelColumn;
        objArray2[10] = (object) "@NullSetinelRetVal";
        objArray2[11] = (object) scheduleLink.NullSetinelRetVal;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "insert into tblExcelRating_RaterSchedules select @raterFactorSetGuid, @scheduleFactorSetGuid, @RowStart, @RowEnd, @SetinelColumn, @NullSetinelRetVal", objArray2);
      }
      this.Parent.Parent.StatusText = "Uploading Worksheet Schedules, Please Wait (this may take a minute)..";
      this.Parent.Parent.SheetUploadPercentage = 4;
      if (this.FactorSetInitializedFrom.HasValue)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "insert into tblCompanyLineFactorSets select @newFactorSetGuid, CompanyLineGuid from tblCompanyLineFactorSets (nolock) where FactorSetGuid = @oldFactorSetGuid", TimeSpan.FromMinutes(2.0).Seconds, (CommandArgumentType) 0, new object[4]
        {
          (object) "@newFactorSetGuid",
          (object) this.FactorSetGuid.Value,
          (object) "@oldFactorSetGuid",
          (object) this.FactorSetInitializedFrom.Value
        });
      else
        DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.ExcelRating_EnableFactorsetForAllCompanyLines", TimeSpan.FromMinutes(2.0).Seconds, (CommandArgumentType) 0, new object[2]
        {
          (object) "@FactorSetGUID",
          (object) this.FactorSetGuid.Value
        });
      int num1 = 1;
      bool flag1 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("VerifyFileUpload");
      if ((1 & (flag1 ? 1 : 0)) != 0)
      {
        if (this.ExcelTemplate.Length > 10119)
          num1 = 1;
        else
          flag1 = false;
      }
      this.Parent.Parent.StatusText = "Uploading Workbook file, Please Wait (this may take a minute).";
      this.Parent.Parent.SheetUploadPercentage = 5;
      int num2 = 0;
      bool flag2 = false;
      do
      {
        ++num2;
        if (!DefaultDatabase.HasTransaction)
          DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
          {
            this.UploadExcelFile(this.FactorSetGuid.Value, this.ExcelTemplate);
            e.Transaction.Commit();
          }));
        else
          this.UploadExcelFile(this.FactorSetGuid.Value, this.ExcelTemplate);
        if (flag1)
        {
          object dbFile = DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, "spVerifyFileUpload", new object[2]
          {
            (object) "@FactorSetGuid",
            (object) this.FactorSetGuid.Value
          });
          if (dbFile is DBNull)
          {
            flag2 = true;
            break;
          }
          if (VerifyFile.ValidUploadHash(this.ExcelTemplate, (byte[]) dbFile))
          {
            flag2 = true;
            break;
          }
        }
      }
      while (num2 != num1);
      if (flag1 && !flag2)
        throw new IOException("File upload verification failed");
      this.Parent.Parent.StatusText = "";
      this.Parent.Parent.SheetUploadPercentage = 0;
    }
    else
    {
      object[] objArray = new object[14];
      objArray[0] = (object) "@FactorSetGuid";
      factorSetGuid = this.FactorSetGuid;
      objArray[1] = (object) factorSetGuid.Value;
      objArray[2] = (object) "@ShowUpdateHistoricOptions";
      objArray[3] = (object) this.ShowUpdateHistoricOptions;
      objArray[4] = (object) "@RoundPremiums";
      objArray[5] = (object) this.RoundPremiums;
      objArray[6] = (object) "@IncludeLeapDayInProrataCalc";
      objArray[7] = (object) this.IncludeLeapDayInProrataCalc;
      objArray[8] = (object) "@DisableAllProrataCalculation";
      objArray[9] = (object) this.DisableAllProrataCalculation;
      objArray[10] = (object) "@AllowZeroPremium";
      objArray[11] = (object) this.AllowZeroPremium;
      objArray[12] = (object) "@UseWebServiceParameters";
      objArray[13] = (object) this.UseWebServiceParameters;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblExcelRating_FactorSets SET ShowUpdateHistoricOptions = @ShowUpdateHistoricOptions, RoundPremiums = @RoundPremiums, IncludeLeapDayInProrataCalc = @IncludeLeapDayInProrataCalc, DisableAllProrataCalculation = @DisableAllProrataCalculation, AllowZeroPremium = @AllowZeroPremium, UseWebServiceParameters = @UseWebServiceParameters WHERE FactorSetGuid = @FactorSetGuid", objArray);
    }
  }

  private void ReportProgress(int progressPercentage, string text)
  {
    this.Parent.Parent.StatusText = text;
    this.Parent.Parent.SheetUploadPercentage = progressPercentage;
  }

  public void OnWriteToDestination(DataTransferFilterEventArgs e)
  {
  }

  public void OnWriteToSource(DataTransferFilterEventArgs e)
  {
  }

  private void UploadExcelFile(Guid factorSetGuid, byte[] bytes)
  {
    if (bytes == null || bytes.Length == 0)
      throw new ArgumentNullException(nameof (bytes));
    if (!DefaultDatabase.HasTransaction)
      throw new Exception("UploadExcelFile must be called from a transaction");
    switch (DatabaseInformation.ExcelFileStoreBinarySerializationType)
    {
      case "image":
        this.UploadExcelFileImage(factorSetGuid, bytes);
        break;
      case "varbinary":
        this.UploadExcelFileVarbinary(factorSetGuid, bytes);
        break;
      default:
        throw new NotImplementedException();
    }
  }

  private void UploadExcelFileVarbinary(Guid factorSetGuid, byte[] bytes)
  {
    if (bytes == null || bytes.Length == 0)
      throw new ArgumentNullException(nameof (bytes));
    int num1 = 0;
    int progressPercentage1 = 0;
    float num2 = 100f / (float) bytes.Length;
    SqlCommand sqlCommand1 = new SqlCommand("UPDATE tblExcelRating_FactorSets SET [CompressedExcelSheet].WRITE(@data, @offset, @len) WHERE FactorSetGuid = @FactorSetGuid", (SqlConnection) DefaultDatabase.Transaction.Connection, (SqlTransaction) DefaultDatabase.Transaction);
    sqlCommand1.CommandTimeout = 250;
    using (SqlCommand sqlCommand2 = sqlCommand1)
    {
      this.ReportProgress(progressPercentage1, "Please wait while the file is uploaded to the server.");
      sqlCommand2.Parameters.AddWithValue("@FactorSetGuid", (object) factorSetGuid);
      SqlParameter sqlParameter1 = sqlCommand2.Parameters.Add("@data", SqlDbType.VarBinary);
      SqlParameter sqlParameter2 = sqlCommand2.Parameters.Add("@offset", SqlDbType.BigInt);
      SqlParameter sqlParameter3 = sqlCommand2.Parameters.Add("@len", SqlDbType.BigInt);
      using (MemoryStream memoryStream = new MemoryStream(bytes))
      {
        byte[] buffer = new byte[UploadPacketSize.GetBufferLength(bytes.Length)];
        int num3 = 0;
        int num4 = memoryStream.Read(buffer, 0, buffer.Length);
        while (num4 > 0)
        {
          sqlParameter1.Value = (object) buffer;
          sqlParameter2.Value = (object) num3;
          sqlParameter3.Value = (object) num4;
          sqlCommand2.ExecuteNonQuery();
          num3 += num4;
          num4 = memoryStream.Read(buffer, 0, buffer.Length);
          int progressPercentage2 = (int) ((double) num3 * (double) num2);
          if (progressPercentage2 != num1)
          {
            num1 = progressPercentage2;
            this.ReportProgress(progressPercentage2, "Please wait while the file is uploaded to the server.");
          }
        }
        this.ReportProgress(90, "File upload complete");
      }
    }
  }

  private void UploadExcelFileImage(Guid factorSetGuid, byte[] bytes)
  {
    if (bytes == null || bytes.Length == 0)
      throw new ArgumentNullException(nameof (bytes));
    int num1 = 0;
    int progressPercentage1 = 0;
    float num2 = 100f / (float) bytes.Length;
    SqlCommand sqlCommand1 = new SqlCommand("SELECT TEXTPTR(CompressedExcelSheet) FROM tblExcelRating_FactorSets WHERE FactorSetGuid = @FactorSetGuid", (SqlConnection) DefaultDatabase.Transaction.Connection, (SqlTransaction) DefaultDatabase.Transaction);
    sqlCommand1.CommandTimeout = 250;
    using (SqlCommand sqlCommand2 = sqlCommand1)
    {
      this.ReportProgress(progressPercentage1, "Please wait while the file is uploaded to the server.");
      int bufferLength = UploadPacketSize.GetBufferLength(bytes.Length);
      sqlCommand2.Parameters.AddWithValue("@FactorSetGuid", (object) factorSetGuid);
      byte[] numArray1 = (byte[]) sqlCommand2.ExecuteScalar();
      sqlCommand2.Parameters.Clear();
      sqlCommand2.CommandText = "UPDATETEXT tblExcelRating_FactorSets.CompressedExcelSheet @Pointer @Offset 0 @Bytes";
      sqlCommand2.Parameters.Add("@Pointer", SqlDbType.Binary, 16 /*0x10*/);
      sqlCommand2.Parameters["@Pointer"].Value = (object) numArray1;
      sqlCommand2.Parameters.Add("@Bytes", SqlDbType.Binary, bufferLength);
      sqlCommand2.Parameters.Add("@Offset", SqlDbType.Int);
      sqlCommand2.Parameters["@Offset"].Value = (object) 0;
      using (MemoryStream input = new MemoryStream(bytes))
      {
        using (BinaryReader binaryReader = new BinaryReader((Stream) input))
        {
          byte[] numArray2 = binaryReader.ReadBytes(bufferLength);
          int num3 = 0;
          while (numArray2.Length != 0)
          {
            sqlCommand2.Parameters["@Bytes"].Value = (object) numArray2;
            sqlCommand2.Parameters["@Bytes"].Size = numArray2.Length;
            sqlCommand2.ExecuteNonQuery();
            num3 += bufferLength;
            sqlCommand2.Parameters["@Offset"].Value = (object) num3;
            numArray2 = binaryReader.ReadBytes(bufferLength);
            int progressPercentage2 = (int) ((double) num3 * (double) num2);
            if (progressPercentage2 != num1)
            {
              num1 = progressPercentage2;
              this.ReportProgress(progressPercentage2, "Please wait while the file is uploaded to the server.");
            }
          }
          this.ReportProgress(90, "File upload complete");
        }
      }
    }
  }

  public static ValidationResult ValidateMappingCount(
    BulkObservableCollection<ExcelMapping> mappings,
    ValidationContext validationContext)
  {
    ExcelRaterFactorSet objectInstance = (ExcelRaterFactorSet) validationContext.ObjectInstance;
    string memberName = validationContext.MemberName;
    if (((Collection<ExcelMapping>) objectInstance.excelMappings).Count <= 1024 /*0x0400*/)
      return ValidationResult.Success;
    return new ValidationResult("Cannot enter more than 1024 mappings", (IEnumerable<string>) new List<string>()
    {
      validationContext.MemberName
    });
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    if (!(propertyName == "RatingProcedure"))
      return;
    this.ShowUpdateHistoricOptions = this.RatingProcedure.ValueInNoCase("ExcelRating_RateOption3", "ExcelRating_RateOption4");
  }
}
