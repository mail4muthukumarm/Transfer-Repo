// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PoliciesMenu
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MgaSystems.IMS.Policies.InsCipher;
using MgaSystems.IMS.Policies.InsCipher.Administration.Windows;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Policies;

[SecureResource("{105F4797-966E-469A-B9BC-40765E2254E5}", "Manage InsCipher Configurations", "Allows user access to the configuration mapping UI.", "InsCipher")]
[MenuManager]
public class PoliciesMenu : IMenuConsumer
{
  public const string SecurityManageInsCipher = "{105F4797-966E-469A-B9BC-40765E2254E5}";
  private const string MainMenu = "mainMenu";
  private const string AdminMenu = "Administration";
  internal const string InsCipher_AdminMenu = "Administration_InsCipher";
  internal const string InsCipher_AdminMappings = "Administration_InsCipher_Mappings";
  internal const string InsCipher_Submenu = "Policy_InsCipher";
  internal const string InsCipher_FileQuote = "Policy_InsCipher_FileQuote";
  internal const string InsCipher_FilePending = "Policy_InsCipher_FilePending";
  internal const string InsCipher_QuoteInvoices = "Policy_InsCipher_QuoteInvoices";

  private bool InsCipherEnabled => MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Services.InsCipher.Enabled");

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (!this.InsCipherEnabled || !SecurityManager.Instance.AssertPermission("{105F4797-966E-469A-B9BC-40765E2254E5}"))
      return;
    PoliciesMenu.AddInsCipherAdminMenu((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)["Administration"]);
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity activeMdiChild && activeMdiChild.RecreateTypeName.ContainsNoCase("frmPolicyDetail"))
    {
      switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
      {
        case "Policy_InsCipher_QuoteInvoices":
          Quote quote = Quote.CreateNew(activeMdiChild.EntityGuid);
          if (!quote.RecordExists())
            break;
          FormSettings.ShowForm(typeof (frmQuoteInvoiceFilings), (object) quote);
          break;
        case "Policy_InsCipher_FilePending":
        case "Policy_InsCipher_FileQuote":
          Progress<string> actionLog = new Progress<string>(new Action<string>(FilingCommands.WriteLog));
          Progress<Exception> progress = new Progress<Exception>(new Action<Exception>(ErrorHandler.HandleError));
          Guid entityGuid = activeMdiChild.EntityGuid;
          Progress<Exception> errorLog = progress;
          FilingCommands filingCommands = new FilingCommands((IProgress<string>) actionLog, (IProgress<Exception>) errorLog);
          if (!(((SubObjectBase) ((ToolEventArgs) e).Tool.InstanceProps).Tag is Lazy<DataTable> tag))
          {
            filingCommands.FileQuoteInvoice(entityGuid);
            break;
          }
          filingCommands.FilePendingInvoices(tag.Value, entityGuid);
          break;
      }
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "Administration_InsCipher_Mappings"))
        return;
      int num = (int) ((Form) MgaMdiChild.CreateForm<MappingConfiguration>(Array.Empty<object>())).ShowDialog();
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
    if (!this.InsCipherEnabled)
      return;
    IRecreatableEntity recreate = MDIControls.Instance.MDIParent.ActiveMdiChild as IRecreatableEntity;
    if (recreate == null)
      return;
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail");
    if ((object) typeFromString == null || !typeFromString.IsAssignableFrom(recreate.GetType()) || !(recreate.EntityGuid != Guid.Empty))
      return;
    menu.FindMergedTool("Policy", (Action<ToolBase>) (policyMenu => PoliciesMenu.AddInsCipherPolicyMenu((PopupMenuTool) policyMenu, recreate.EntityGuid)));
  }

  private static PopupMenuTool AddSubMenu(
    PopupMenuTool menu,
    string addKey,
    string addCaption,
    Image toolIcon = null,
    bool groupWithFirstSubmenus = false)
  {
    PopupMenuTool popupMenu = ((ToolBase) menu).ToolbarsManager.FindPopupMenu(addKey);
    if (popupMenu == null)
    {
      PopupMenuTool popupMenuTool = new PopupMenuTool(addKey);
      ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = addCaption;
      if (toolIcon != null)
        ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).AppearancesSmall.Appearance.Image = (object) toolIcon;
      ((ToolsCollectionBase) ((ToolBase) menu).ToolbarsManager.Tools).Add((ToolBase) popupMenuTool);
      if (groupWithFirstSubmenus)
      {
        int? nullable = new int?();
        for (int index = 0; index < ((DisposableObjectCollectionBase) menu.Tools).Count; ++index)
        {
          if (((ToolsCollectionBase) menu.Tools)[index] is PopupMenuTool)
            nullable = new int?(index);
          else if (nullable.HasValue)
          {
            menu.Tools.InsertTool(index, addKey);
            break;
          }
        }
      }
      else
        menu.Tools.AddTool(addKey);
      popupMenu = ((ToolBase) menu).ToolbarsManager.FindPopupMenu(addKey);
    }
    return popupMenu;
  }

  private static void AddInsCipherAdminMenu(PopupMenuTool adminMenu)
  {
    PopupMenuTool popupMenuTool = PoliciesMenu.AddSubMenu(adminMenu, "Administration_InsCipher", "InsCipher Administration", ImageCache.Instance.Dollar, true);
    if (popupMenuTool == null)
      return;
    popupMenuTool.AddOrShowButtonTool("Administration_InsCipher_Mappings", "Mapping Configuration", true);
  }

  private static void AddInsCipherPolicyMenu(PopupMenuTool policyMenu, Guid quoteGuid)
  {
    PopupMenuTool popupMenuTool = PoliciesMenu.AddSubMenu(policyMenu, "Policy_InsCipher", "InsCipher Filing");
    if (popupMenuTool == null)
      return;
    popupMenuTool.AddOrShowButtonTool("Policy_InsCipher_QuoteInvoices", "Submitted Invoice Filings", true);
    Lazy<DataTable> pendingTransactions = new Lazy<DataTable>((Func<DataTable>) (() => DefaultDatabase.ExecuteDataTable("dbo.InsCipher_GetPendingTransactions", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    })), true);
    popupMenuTool.AddOrShowButtonTool("Policy_InsCipher_FileQuote", "File Current Transaction", (Func<bool>) (() => pendingTransactions.Value.AsEnumerable().Any<DataRow>((System.Func<DataRow, bool>) (dr => dr.Field<Guid>("QuoteGUID") == quoteGuid))));
    popupMenuTool.AddOrShowButtonTool("Policy_InsCipher_FilePending", "File Pending Transactions", new int?(), (Func<bool>) (() => pendingTransactions.Value.Rows.Count > 0), (Action<ButtonTool>) null, (Action<ButtonTool>) (pendingButton => ((SubObjectBase) ((ToolBase) pendingButton).InstanceProps).Tag = (object) pendingTransactions));
  }
}
