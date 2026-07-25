// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.QuoteStatusChangeMenu
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[SecureResource("{ED7821FB-7E6D-4da5-B376-DC5153142527}", "Bound to Cancelled", "Allows changing a policy from Cancelled status to Bound status, without having to do a reinstatement.", "Policy")]
public class QuoteStatusChangeMenu : IDisposable
{
  private readonly PopupMenuTool _menu;
  private readonly PopupMenuTool _parentMenu;
  public const int CHANGE_STATUS_INDEX = 5;
  public const string SUBMIT_TO_MARKET = "SBMT";
  public const string CLEAR_CARRIER = "CLCR";
  public const string CREATE_SUPPORTING_LINES = "CRSL";
  public const string AllowCancelToBoundStatusChange = "{ED7821FB-7E6D-4da5-B376-DC5153142527}";
  private static readonly Dictionary<int, bool> _quoteStatusCache = new Dictionary<int, bool>();
  private static readonly Dictionary<int, bool> _userSelectableCache = new Dictionary<int, bool>();
  private bool disposedValue;

  public QuoteStatusChangeMenu(PopupMenuTool parentMenu)
  {
    this._parentMenu = parentMenu != null ? parentMenu : throw new ArgumentNullException(nameof (parentMenu));
    this._menu = new PopupMenuTool("Change Status");
    ((ToolPropsBase) ((ToolBase) this._menu).SharedProps).Caption = "Change Status";
    ((ToolBase) parentMenu).ToolbarsManager.Tools.Add((ToolBase) this._menu);
    parentMenu.Tools.AddTool("Change Status");
    parentMenu.Tools.Remove((ToolBase) this._menu);
    parentMenu.Tools.InsertTool(5, "Change Status");
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetQuoteStatusChangeMenuQuoteStatus");
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.AddTool(row[1].ToString(), row[2].ToString(), Conversions.ToInteger(row[0]));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  static QuoteStatusChangeMenu()
  {
    try
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetQuoteStatuses_BoundUserSelectable");
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(row["QuoteStatusID"]));
          if (!QuoteStatusChangeMenu._quoteStatusCache.ContainsKey(int32))
            QuoteStatusChangeMenu._quoteStatusCache.Add(int32, row.Field<bool>("Bound"));
          if (!QuoteStatusChangeMenu._userSelectableCache.ContainsKey(int32))
            QuoteStatusChangeMenu._userSelectableCache.Add(int32, row.Field<bool>("UserSelectable"));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected PopupMenuTool StatusChangeMenu => this._menu;

  private static void ChangeQuoteStatus(QuoteStatus newQuoteStatus, Quote q)
  {
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM lstQuoteStatusReasons WHERE (QuoteStatusID = @quoteStatusID) AND ISNULL(Inactive, 0) = 0", new object[2]
    {
      (object) "@quoteStatusID",
      (object) (int) newQuoteStatus
    });
    bool flag = true;
    QuoteStatus quoteStatus = q.QuoteStatus;
    if (num > 0)
    {
      using (frmChangeQuoteStatus changeQuoteStatus = (frmChangeQuoteStatus) FormSettings.ShowFormDialog(typeof (frmChangeQuoteStatus), new object[2]
      {
        (object) q.QuoteGuid,
        (object) newQuoteStatus
      }))
        flag = changeQuoteStatus.StatusChanged;
    }
    else
    {
      q.QuoteStatus = newQuoteStatus;
      if (newQuoteStatus == 17)
      {
        using (FormSettings.ShowFormDialog(typeof (FormNonRenewedStatusInfo), new object[2]
        {
          (object) q.QuoteGuid,
          (object) newQuoteStatus
        }))
          ;
      }
    }
    if (newQuoteStatus == 3)
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdateBoundStatusReason", new object[2]
      {
        (object) "@QuoteGUID",
        (object) q.QuoteGuid
      });
    if (!flag)
      return;
    if (quoteStatus == 6 && newQuoteStatus == 3)
      Messaging.SendBroadcastMessage(BroadcastMessages.RescindNotice, (object) q.QuoteGuid);
    else if (quoteStatus == 17 && newQuoteStatus == 3)
      Messaging.SendBroadcastMessage(BroadcastMessages.NonRenewedRescindedNotice, (object) q.QuoteGuid);
    Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT EventGuid FROM dbo.lstQuoteStatus WITH(NOLOCK) WHERE QuoteStatusID = @QuoteStatusID", new object[2]
    {
      (object) "@QuoteStatusID",
      (object) (int) newQuoteStatus
    });
    if (nullable.HasValue)
    {
      object obj = (object) q.QuoteGuid;
      if (nullable.Equals((object) BroadcastMessages.InspectionRequested))
        obj = (object) new InspectionRequestedEventArgs(DefaultDatabase.ExecuteScalar<int>("dbo.GetInspectionCompanyID", new object[2]
        {
          (object) "@QuoteGUID",
          (object) q.QuoteGuid
        }), q.QuoteGuid);
      Messaging.SendBroadcastMessage(nullable.Value, RuntimeHelpers.GetObjectValue(obj));
    }
    try
    {
      foreach (frmClearance frmClearance in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmClearance>())
        frmClearance.UpdateQuote(q.QuoteGuid);
    }
    finally
    {
      IEnumerator<frmClearance> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (frmPolicyDetail frmPolicyDetail in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>())
      {
        if (frmPolicyDetail.Quote.QuoteGuid.Equals(q.QuoteGuid))
          frmPolicyDetail.RefreshPolicyData();
      }
    }
    finally
    {
      IEnumerator<frmPolicyDetail> enumerator;
      enumerator?.Dispose();
    }
  }

  private void AddTool(string caption, string imageResourceFileName, int quoteStatusID)
  {
    ButtonTool buttonTool = new ButtonTool(caption);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = caption;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(imageResourceFileName, string.Empty, false) != 0)
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) this.GetImageFromResource(imageResourceFileName);
    ((SubObjectBase) buttonTool).Tag = (object) quoteStatusID;
    ((ToolBase) this._parentMenu).ToolbarsManager.Tools.Add((ToolBase) buttonTool);
    this._menu.Tools.AddTool(caption);
  }

  protected virtual Bitmap GetImageFromResource(string resourceName)
  {
    Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
    return manifestResourceStream != null ? new Bitmap(manifestResourceStream) : (Bitmap) null;
  }

  public virtual void EnableDisableItems(Quote q)
  {
    bool flag1 = q != null ? q.IsBound : throw new ArgumentNullException(nameof (q));
    bool isCancelled = q.IsCancelled;
    PopupMenuTool menu = this._menu;
    ((ToolBase) menu).SharedProps.Visible = true;
    if (((ToolsCollectionBase) menu.Tools).Exists("Submitted"))
      ((ToolsCollectionBase) menu.Tools)["Submitted"].SharedProps.Enabled = !flag1 && q.IsOriginalQuoteRecord;
    if (((ToolsCollectionBase) menu.Tools).Exists("Declined"))
      ((ToolsCollectionBase) menu.Tools)["Declined"].SharedProps.Enabled = !flag1 && q.IsOriginalQuoteRecord;
    if (((ToolsCollectionBase) menu.Tools).Exists("Not Taken Up"))
      ((ToolsCollectionBase) menu.Tools)["Not Taken Up"].SharedProps.Enabled = !flag1 && q.IsOriginalQuoteRecord;
    if (((ToolsCollectionBase) menu.Tools).Exists("Lost on BOR"))
      ((ToolsCollectionBase) menu.Tools)["Lost on BOR"].SharedProps.Enabled = flag1 && !isCancelled;
    if (((ToolsCollectionBase) menu.Tools).Exists("Void"))
      ((ToolsCollectionBase) menu.Tools)["Void"].SharedProps.Enabled = this.ShowVoids(q);
    if (((ToolsCollectionBase) menu.Tools).Exists("Lost"))
      ((ToolsCollectionBase) menu.Tools)["Lost"].SharedProps.Enabled = !flag1 && q.IsOriginalQuoteRecord;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Bound"))
    {
      bool flag2 = SecurityManager.Instance.AssertPermission("{ED7821FB-7E6D-4da5-B376-DC5153142527}");
      ((ToolsCollectionBase) menu.Tools)["Bound"].SharedProps.Enabled = !isCancelled || flag2;
    }
    foreach (ToolBase tool in (ToolsCollectionBase) ((ToolBase) this._parentMenu).ToolbarsManager.Tools)
    {
      ButtonTool buttonTool = tool as ButtonTool;
      if (buttonTool != null && ((SubObjectBase) buttonTool).Tag != null && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((SubObjectBase) buttonTool).Tag)))
      {
        int tag = (int) ((SubObjectBase) buttonTool).Tag;
        bool flag3;
        bool flag4;
        if (QuoteStatusChangeMenu._quoteStatusCache.ContainsKey(tag))
        {
          flag3 = QuoteStatusChangeMenu._quoteStatusCache[tag];
          flag4 = QuoteStatusChangeMenu._userSelectableCache[tag];
          tool.SharedProps.Visible = !flag1 ? !flag3 : flag3 && flag4 && !isCancelled;
          tool.SharedProps.Visible = flag1 == flag3;
        }
        else
        {
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Bound, UserSelectable FROM lstQuoteStatus WHERE QuoteStatusID=@ID", new object[2]
          {
            (object) "@ID",
            (object) tag
          });
          if (dataRow != null)
          {
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[1])))
              flag4 = (bool) dataRow[1];
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow[0])))
              flag3 = (bool) dataRow[0];
            QuoteStatusChangeMenu._quoteStatusCache.Add(tag, flag3);
            QuoteStatusChangeMenu._userSelectableCache.Add(tag, flag4);
            tool.SharedProps.Visible = !flag1 ? !flag3 : flag3 && flag4 && !q.IsCancelled;
          }
          else
            tool.SharedProps.Visible = false;
        }
      }
    }
  }

  public virtual bool ShowVoids(Quote q)
  {
    if (q == null)
      throw new ArgumentNullException(nameof (q));
    return !q.IsBound && q.InvoiceCount > 0 && q.IsOriginalQuoteRecord;
  }

  public virtual void ToolClick(string key, Guid quoteGuid)
  {
    this.ToolClick(key, Quote.FromQuoteGuid(quoteGuid));
  }

  public virtual void ToolClick(string key, Quote policyQuote)
  {
    object objectValue1 = RuntimeHelpers.GetObjectValue(((SubObjectBase) ((ToolsCollectionBase) ((ToolBase) this._parentMenu).ToolbarsManager.Tools)[key]).Tag);
    if (!(objectValue1 is int) || objectValue1 == null)
      return;
    QuoteStatus quoteStatus = (QuoteStatus) Enum.Parse(typeof (QuoteStatus), objectValue1.ToString());
    if (policyQuote.QuoteStatus != 6 || quoteStatus != 3)
    {
      object objectValue2 = RuntimeHelpers.GetObjectValue(policyQuote.ChangeStatusRequirementsSoftStops((int) quoteStatus));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
        this.MessageBoxDisplay($"Please note the following company/line requirements are not met:{"\n"}{"\n"}{RuntimeHelpers.GetObjectValue(objectValue2)}", "Soft Stops - Company/line Requirements Not Met");
      object objectValue3 = RuntimeHelpers.GetObjectValue(policyQuote.ChangeStatusRequirementsHardStops((int) quoteStatus));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue3)))
      {
        this.MessageBoxDisplay($"Cannot update Quote Status because the following company/line requirements are not met:{"\n"}{"\n"}{RuntimeHelpers.GetObjectValue(objectValue3)}", "Company/line Requirements Not Met");
        return;
      }
    }
    if (quoteStatus != 30)
    {
      try
      {
        QuoteStatusChangeMenu.ChangeQuoteStatus(quoteStatus, policyQuote);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (ex.Message.Contains("Invalid quote status change"))
        {
          this.MessageBoxDisplay($"Invalid quote status change from '{DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description From dbo.lstQuoteStatus WHERE QuoteStatusID = @qsID", new object[2]
          {
            (object) "@qsID",
            (object) policyQuote.QuoteStatusID
          })}' to '{key}'", "Cannot Change Quote Status");
          ProjectData.ClearProjectError();
        }
        else
          throw;
      }
    }
    this.StatusClick(quoteStatus, policyQuote);
  }

  private void MessageBoxDisplay(string messagePrompt, string messageCaption)
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form owner = mdiChildren[index];
      switch (owner)
      {
        case frmPolicyDetail _:
        case frmClearance _:
          int num = (int) MessageBox.Show((IWin32Window) owner, messagePrompt, messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        default:
          checked { ++index; }
          continue;
      }
    }
  }

  private bool ValidToSubmitToMarket(Quote q)
  {
    bool submitToMarket;
    if (q.IsQuickQuote)
    {
      this.MessageBoxDisplay("Cannot Submit to Market on quick quotes", "Invalid Submit to Market");
      submitToMarket = false;
    }
    else
      submitToMarket = true;
    return submitToMarket;
  }

  private void StatusClick(QuoteStatus newQuoteStatus, Quote quote)
  {
    string Left = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT AutomationCode FROM lstQuoteStatus WHERE QuoteStatusID = @QuoteStatusID", new object[2]
    {
      (object) "@QuoteStatusID",
      (object) (int) newQuoteStatus
    });
    if (string.IsNullOrEmpty(Left))
      return;
    string formTypeName = (string) null;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CLCR", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "SBMT", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CRSL", false) == 0)
          formTypeName = "MGASystems.IMS.Underwriting.Create_Supporting_Lines.FormCreateSupportingLines";
      }
      else
        formTypeName = "frmClearCarriers";
    }
    else if (this.ValidToSubmitToMarket(quote))
      formTypeName = "frmClearCarriers";
    if (string.IsNullOrEmpty(formTypeName))
      return;
    this.ExecuteQuoteStatus(formTypeName, quote.QuoteGuid, newQuoteStatus);
  }

  private void ExecuteQuoteStatus(string formTypeName, Guid quoteGuid, QuoteStatus newQuoteStatus)
  {
    string empty = string.Empty;
    using (Form formEx = ObjectFactory.Instance.CreateFormEX(ObjectFactory.Instance.CreateTypeFromString(formTypeName), new object[2]
    {
      (object) quoteGuid,
      (object) (int) newQuoteStatus
    }))
    {
      if (formEx != null)
      {
        formEx.ShowInTaskbar = true;
        formEx.BringToFront();
        int num = (int) formEx.ShowDialog();
        if (formEx?.Tag != null)
          empty = formEx.Tag.ToString();
      }
    }
    string[] strArray = empty.Split('/');
    int index = 0;
    while (index < strArray.Length)
    {
      string g = strArray[index];
      if (g != null && g.Length > 0)
        this.RefreshClearance(new Guid(g));
      checked { ++index; }
    }
  }

  private void RefreshClearance(Guid quoteGuid)
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
        frmClearance.UpdateQuote(quoteGuid);
      checked { ++index; }
    }
  }

  protected virtual void Dispose(bool disposing)
  {
    if (!this.disposedValue && disposing)
    {
      if (this._menu != null)
        ((DisposableObject) this._menu).Dispose();
      if (this._parentMenu != null)
        ((DisposableObject) this._parentMenu).Dispose();
    }
    this.disposedValue = true;
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }
}
