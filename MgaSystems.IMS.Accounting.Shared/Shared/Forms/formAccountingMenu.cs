// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.Forms.formAccountingMenu
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared.Forms;

public class formAccountingMenu : Form
{
  internal UltraToolbarsManager utmAcctingMenu;
  internal UltraToolbarsDockArea _frmAccountingMenu_Toolbars_Dock_Area_Top;
  internal UltraToolbarsDockArea _frmAccountingMenu_Toolbars_Dock_Area_Bottom;
  internal UltraToolbarsDockArea _frmAccountingMenu_Toolbars_Dock_Area_Left;
  internal UltraToolbarsDockArea _frmAccountingMenu_Toolbars_Dock_Area_Right;
  private IContainer components;

  public formAccountingMenu() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolbar ultraToolbar = new UltraToolbar("AcctMainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Acct_Accounting");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Acct_Accounting");
    ButtonTool buttonTool1 = new ButtonTool("ACCT_POLICYINQUIRY");
    ButtonTool buttonTool2 = new ButtonTool("ACCT_ACCTLINKING");
    ButtonTool buttonTool3 = new ButtonTool("ACCT_BANKMANAGE");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("General Ledger");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("ACCT_AR");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("ACCT_AP");
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("ACCT_OPERATINGEXPENSES");
    PopupMenuTool popupMenuTool7 = new PopupMenuTool("ACCT_REPORTS");
    PopupMenuTool popupMenuTool8 = new PopupMenuTool("ACCT_TOOLS");
    PopupMenuTool popupMenuTool9 = new PopupMenuTool("AdministrativeOptions");
    ButtonTool buttonTool4 = new ButtonTool("ACCT_CHECKREGISTER");
    PopupMenuTool popupMenuTool10 = new PopupMenuTool("ACCT_BANKMANAGEMENT");
    PopupMenuTool popupMenuTool11 = new PopupMenuTool("ACCT_OPTION");
    ButtonTool buttonTool5 = new ButtonTool("ACCT_AUTOMATION");
    ButtonTool buttonTool6 = new ButtonTool("ExtSettings");
    ButtonTool buttonTool7 = new ButtonTool("ACCT_PRINTERS");
    ButtonTool buttonTool8 = new ButtonTool("AGING");
    ButtonTool buttonTool9 = new ButtonTool("ACCT_AUTOMATION");
    ButtonTool buttonTool10 = new ButtonTool("ACCT_ACCTLINKING");
    Appearance appearance1 = new Appearance();
    PopupMenuTool popupMenuTool12 = new PopupMenuTool("ACCT_AR");
    ButtonTool buttonTool11 = new ButtonTool("ACCT_REMITTANCE");
    ButtonTool buttonTool12 = new ButtonTool("ACCT_CREDITBALANCES");
    PopupMenuTool popupMenuTool13 = new PopupMenuTool("ACCT_AP");
    ButtonTool buttonTool13 = new ButtonTool("ACCT_INSPAY");
    PopupMenuTool popupMenuTool14 = new PopupMenuTool("PayablesRefundOptions");
    ButtonTool buttonTool14 = new ButtonTool("IssueCheck");
    ButtonTool buttonTool15 = new ButtonTool("ACCT_AUTOMATEPAYABLES");
    ButtonTool buttonTool16 = new ButtonTool("ACCT_DEBITBALANCES");
    PopupMenuTool popupMenuTool15 = new PopupMenuTool("ACCT_BANKMANAGEMENT");
    ButtonTool buttonTool17 = new ButtonTool("ACCT_CHECKREGISTER");
    ButtonTool buttonTool18 = new ButtonTool("ACCT_RECONCILE");
    ButtonTool buttonTool19 = new ButtonTool("ACCT_TRANSFER");
    PopupMenuTool popupMenuTool16 = new PopupMenuTool("ACCT_REPORTS");
    ButtonTool buttonTool20 = new ButtonTool("TrialBalance");
    ButtonTool buttonTool21 = new ButtonTool("ACCT_RPT_OPENAR");
    PopupMenuTool popupMenuTool17 = new PopupMenuTool("ACCT_USERDEFINEDREPORTS");
    PopupMenuTool popupMenuTool18 = new PopupMenuTool("ACCT_TOOLS");
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formAccountingMenu));
    PopupMenuTool popupMenuTool19 = new PopupMenuTool("ACCT_OPTION");
    ButtonTool buttonTool22 = new ButtonTool("ACCT_JOURNALVIEW");
    ButtonTool buttonTool23 = new ButtonTool("ACCT_3RDPARTYPAYEES");
    ButtonTool buttonTool24 = new ButtonTool("ACCT_CREDITBALANCES");
    ButtonTool buttonTool25 = new ButtonTool("ACCT_DEBITBALANCES");
    ButtonTool buttonTool26 = new ButtonTool("ACCT_RECONCILE");
    ButtonTool buttonTool27 = new ButtonTool("ACCT_RPT_BUILDNEW");
    ButtonTool buttonTool28 = new ButtonTool("ACCT_RPT_EDITUDR");
    ButtonTool buttonTool29 = new ButtonTool("ACCT_RPT_RUNUDR");
    ButtonTool buttonTool30 = new ButtonTool("ACCT_INSPAY");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ButtonTool buttonTool31 = new ButtonTool("ACCT_POLICYINQUIRY");
    Appearance appearance5 = new Appearance();
    ButtonTool buttonTool32 = new ButtonTool("ACCT_REMITTANCE");
    Appearance appearance6 = new Appearance();
    ButtonTool buttonTool33 = new ButtonTool("ACCT_EXPENSES");
    ButtonTool buttonTool34 = new ButtonTool("ACCT_TRANSFER");
    ButtonTool buttonTool35 = new ButtonTool("ACCT_JOURNALVIEW");
    ButtonTool buttonTool36 = new ButtonTool("ACCT_CHECKREGISTER");
    Appearance appearance7 = new Appearance();
    ButtonTool buttonTool37 = new ButtonTool("ACCT_3RDPARTYPAYEES");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ButtonTool buttonTool38 = new ButtonTool("ACCT_RPT_OPENAR");
    ButtonTool buttonTool39 = new ButtonTool("ACCT_GLACCOUNTS");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool40 = new ButtonTool("ACCT_COSTCENTER");
    PopupMenuTool popupMenuTool20 = new PopupMenuTool("ACCT_OPERATINGEXPENSES");
    ButtonTool buttonTool41 = new ButtonTool("ACCT_EXPENSES");
    ButtonTool buttonTool42 = new ButtonTool("ACCT_COSTCENTER");
    ButtonTool buttonTool43 = new ButtonTool("ACCT_EXPRPTNOTIFY");
    ButtonTool buttonTool44 = new ButtonTool("ACCT_AUTOMATEPAYABLES");
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool45 = new ButtonTool("ACCT_EXPRPTNOTIFY");
    ButtonTool buttonTool46 = new ButtonTool("ACCT_PRINTERS");
    Appearance appearance13 = new Appearance();
    ButtonTool buttonTool47 = new ButtonTool("ACCT_BANKMANAGE");
    Appearance appearance14 = new Appearance();
    ButtonTool buttonTool48 = new ButtonTool("ACCT_BALANCESHEET");
    PopupMenuTool popupMenuTool21 = new PopupMenuTool("ACCT_USERDEFINEDREPORTS");
    ButtonTool buttonTool49 = new ButtonTool("ACCT_RPT_BUILDNEW");
    ButtonTool buttonTool50 = new ButtonTool("ACCT_RPT_EDITUDR");
    ButtonTool buttonTool51 = new ButtonTool("ACCT_RPT_RUNUDR");
    ButtonTool buttonTool52 = new ButtonTool("ExtSettings");
    PopupMenuTool popupMenuTool22 = new PopupMenuTool("PayablesRefundOptions");
    ButtonTool buttonTool53 = new ButtonTool("PayablesRefund");
    ButtonTool buttonTool54 = new ButtonTool("PayablesRefundHistory");
    ButtonTool buttonTool55 = new ButtonTool("PayablesRefund");
    ButtonTool buttonTool56 = new ButtonTool("PayablesRefundHistory");
    PopupMenuTool popupMenuTool23 = new PopupMenuTool("Operating Expenses");
    PopupMenuTool popupMenuTool24 = new PopupMenuTool("AdministrativeOptions");
    ButtonTool buttonTool57 = new ButtonTool("CloseAccountingPeriod");
    ButtonTool buttonTool58 = new ButtonTool("CloseAccountingPeriod");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool59 = new ButtonTool("AGING");
    ButtonTool buttonTool60 = new ButtonTool("TrialBalance");
    ButtonTool buttonTool61 = new ButtonTool("Income Statement");
    ButtonTool buttonTool62 = new ButtonTool("6COLWorksheet");
    ButtonTool buttonTool63 = new ButtonTool("IssueCheck");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool64 = new ButtonTool("AcctClassifications");
    Appearance appearance19 = new Appearance();
    PopupMenuTool popupMenuTool25 = new PopupMenuTool("General Ledger");
    ButtonTool buttonTool65 = new ButtonTool("ACCT_GLACCOUNTS");
    ButtonTool buttonTool66 = new ButtonTool("AcctClassifications");
    this.utmAcctingMenu = new UltraToolbarsManager(this.components);
    this._frmAccountingMenu_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmAccountingMenu_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._frmAccountingMenu_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmAccountingMenu_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.utmAcctingMenu).BeginInit();
    this.SuspendLayout();
    this.utmAcctingMenu.DesignerFlags = 1;
    this.utmAcctingMenu.DockWithinContainer = (Control) this;
    this.utmAcctingMenu.MenuAnimationStyle = (MenuAnimationStyle) 1;
    this.utmAcctingMenu.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ultraToolbar.Text = "Accounting Menu";
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    this.utmAcctingMenu.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedProps).Caption = "Accountin&g";
    ((ToolBase) popupMenuTool2).SharedProps.Category = "Accounting";
    ((ToolBase) buttonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool4).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool8).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[12]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) popupMenuTool3,
      (ToolBase) popupMenuTool4,
      (ToolBase) popupMenuTool5,
      (ToolBase) popupMenuTool6,
      (ToolBase) popupMenuTool7,
      (ToolBase) popupMenuTool8,
      (ToolBase) popupMenuTool9,
      (ToolBase) buttonTool4,
      (ToolBase) popupMenuTool10
    });
    ((ToolBase) popupMenuTool11).InstanceProps.Visible = (DefaultableBoolean) 1;
    ((ToolPropsBase) ((ToolBase) popupMenuTool11).SharedProps).Caption = "&My Configuration";
    ((ToolBase) popupMenuTool11).SharedProps.Category = "Accounting Options";
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool8).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool11.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedProps).Caption = "Automation Accounts";
    ((ToolBase) buttonTool9).SharedProps.Category = "Accounting Options";
    ((AppearanceBase) appearance1).Image = (object) 12;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedProps).Caption = "&Account Linking";
    ((ToolBase) buttonTool10).SharedProps.Category = "Accounting Options";
    ((ToolPropsBase) ((ToolBase) popupMenuTool12).SharedProps).Caption = "Accounts &Receivable";
    ((ToolBase) popupMenuTool12).SharedProps.Category = "Accounts Receivable";
    ((ToolBase) buttonTool12).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool12.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool13).SharedProps).Caption = "Accounts &Payable";
    ((ToolBase) popupMenuTool13).SharedProps.Category = "Accounts Payable";
    ((ToolBase) buttonTool13).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool14).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool14).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool15).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool16).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool13.Tools).AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool13,
      (ToolBase) popupMenuTool14,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool15).SharedProps).Caption = "&Bank Management";
    ((ToolBase) popupMenuTool15).SharedProps.Category = "Bank Management";
    ((ToolBase) popupMenuTool15).SharedProps.Visible = false;
    ((ToolBase) buttonTool18).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool19).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool15.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool16).SharedProps).Caption = "R&eports";
    ((ToolBase) popupMenuTool16).SharedProps.Category = "Reports";
    ((ToolBase) popupMenuTool16).SharedProps.Visible = false;
    ((ToolBase) buttonTool21).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool17).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool16.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) popupMenuTool17
    });
    ((AppearanceBase) appearance2).Image = resourceManager.GetObject("appearance2.Image");
    ((ToolPropsBase) ((ToolBase) popupMenuTool18).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) popupMenuTool18).SharedProps).Caption = "&Tools";
    ((ToolBase) popupMenuTool18).SharedProps.Category = "Tools";
    ((ToolBase) buttonTool22).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool23).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool18.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool19,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23
    });
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedProps).Caption = "&Credit Balances";
    ((ToolBase) buttonTool24).SharedProps.Category = "Accounts Receivable";
    ((ToolBase) buttonTool24).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedProps).Caption = "&Debit Balances";
    ((ToolBase) buttonTool25).SharedProps.Category = "Accounts Payable";
    ((ToolBase) buttonTool25).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedProps).Caption = "&Reconcile Accounts";
    ((ToolBase) buttonTool26).SharedProps.Category = "Bank Management";
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedProps).Caption = "&Build New UDR";
    ((ToolBase) buttonTool27).SharedProps.Category = "Reports";
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedProps).Caption = "&Edit UDR";
    ((ToolBase) buttonTool28).SharedProps.Category = "Reports";
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedProps).Caption = "&Run UDR";
    ((ToolBase) buttonTool29).SharedProps.Category = "Reports";
    ((AppearanceBase) appearance3).Image = (object) 9;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).Image = (object) 9;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedProps).Caption = "&Insurance Payables";
    ((ToolBase) buttonTool30).SharedProps.Category = "Insurance Payables";
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance5).Image = (object) 14;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedProps).Caption = "Policy &Inquiry";
    ((ToolBase) buttonTool31).SharedProps.Category = "Policy";
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance6).Image = (object) 5;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance6;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedProps).Caption = "Accounts Receivable";
    ((ToolBase) buttonTool32).SharedProps.Category = "Remittance";
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedProps).Caption = "&Operating Expenses";
    ((ToolBase) buttonTool33).SharedProps.Category = "Operating Expenses";
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedProps).Caption = "&Transfer Funds";
    ((ToolBase) buttonTool34).SharedProps.Category = "Transfer";
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedProps).Caption = "&Journal Viewer";
    ((ToolBase) buttonTool35).SharedProps.Category = "Tools";
    ((AppearanceBase) appearance7).Image = resourceManager.GetObject("appearance7.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance7;
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedProps).Caption = "&Check Register";
    ((ToolBase) buttonTool36).SharedProps.Category = "Bank Management";
    ((ToolBase) buttonTool36).SharedProps.Visible = false;
    ((AppearanceBase) appearance8).Image = (object) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).Image = (object) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance9;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedProps).Caption = "3RD Party Payees";
    ((ToolBase) buttonTool37).SharedProps.Category = "Accounting Options";
    ((ToolBase) buttonTool37).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedProps).Caption = "&Open Receivable Policies Report";
    ((ToolBase) buttonTool38).SharedProps.Category = "Reports";
    ((ToolBase) buttonTool38).SharedProps.Visible = false;
    ((AppearanceBase) appearance10).Image = (object) 7;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).Image = (object) 7;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedProps).Caption = "&GL Account Management";
    ((ToolBase) buttonTool39).SharedProps.Category = "Accounts Payable";
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool40).SharedProps).Caption = "Cost Center &Management";
    ((ToolBase) buttonTool40).SharedProps.Category = "Operating Expenses";
    ((ToolBase) buttonTool40).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) popupMenuTool20).SharedProps).Caption = "Operating E&xpenses";
    ((ToolBase) popupMenuTool20).SharedProps.Category = "Operating Expenses";
    ((ToolBase) buttonTool41).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool20.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool41,
      (ToolBase) buttonTool42,
      (ToolBase) buttonTool43
    });
    ((AppearanceBase) appearance12).Image = resourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool44).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool44).SharedProps).Caption = "Automate Payables";
    ((ToolPropsBase) ((ToolBase) buttonTool45).SharedProps).Caption = "Expense Report Notification Setup";
    ((ToolBase) buttonTool45).SharedProps.Visible = false;
    ((AppearanceBase) appearance13).Image = (object) 15;
    ((ToolPropsBase) ((ToolBase) buttonTool46).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool46).SharedProps).Caption = "Accounting Printers";
    ((AppearanceBase) appearance14).Image = (object) 8;
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedProps).Caption = "Bank Management";
    ((ToolBase) buttonTool47).SharedProps.Category = "Bank Management";
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedProps).Caption = "Balance Sheet";
    ((ToolBase) buttonTool48).SharedProps.Category = "Reports";
    ((ToolPropsBase) ((ToolBase) popupMenuTool21).SharedProps).Caption = "User Defined Reports";
    ((ToolBase) popupMenuTool21).SharedProps.Category = "Reports";
    ((ToolBase) popupMenuTool21).SharedProps.Visible = false;
    ((ToolsCollectionBase) popupMenuTool21.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool49,
      (ToolBase) buttonTool50,
      (ToolBase) buttonTool51
    });
    ((ToolPropsBase) ((ToolBase) buttonTool52).SharedProps).Caption = "Extended Settings";
    ((ToolPropsBase) ((ToolBase) popupMenuTool22).SharedProps).Caption = "Refund Options";
    ((ToolBase) popupMenuTool22).SharedProps.Category = "Accounts Payable";
    ((ToolBase) popupMenuTool22).SharedProps.Visible = false;
    ((ToolBase) buttonTool54).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool22.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool53,
      (ToolBase) buttonTool54
    });
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedProps).Caption = "Payables Refund";
    ((ToolPropsBase) ((ToolBase) buttonTool56).SharedProps).Caption = "Refund History";
    ((ToolBase) buttonTool56).SharedProps.Category = "Accounts Payable";
    ((ToolPropsBase) ((ToolBase) popupMenuTool23).SharedProps).Caption = "Operating Expenses";
    ((ToolPropsBase) ((ToolBase) popupMenuTool24).SharedProps).Caption = "Administrative Options";
    ((ToolsCollectionBase) popupMenuTool24.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool57
    });
    ((AppearanceBase) appearance15).Image = (object) 16 /*0x10*/;
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).Image = (object) 16 /*0x10*/;
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedProps).Caption = "Close Accounting Period";
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool59).SharedProps).Caption = "Define Aging Periods";
    ((ToolPropsBase) ((ToolBase) buttonTool60).SharedProps).Caption = "Financial Reports";
    ((ToolPropsBase) ((ToolBase) buttonTool61).SharedProps).Caption = "Income Statement";
    ((ToolPropsBase) ((ToolBase) buttonTool62).SharedProps).Caption = "Six-Column Worksheet";
    ((AppearanceBase) appearance17).Image = resourceManager.GetObject("appearance17.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool63).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).Image = resourceManager.GetObject("appearance18.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool63).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool63).SharedProps).Caption = "Issue Check";
    ((ToolPropsBase) ((ToolBase) buttonTool63).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool63).SharedProps.Visible = false;
    ((AppearanceBase) appearance19).Image = resourceManager.GetObject("appearance19.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool64).SharedProps).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool64).SharedProps).Caption = "GL Account  Classifications";
    ((ToolPropsBase) ((ToolBase) popupMenuTool25).SharedProps).Caption = "General Ledger";
    ((ToolsCollectionBase) popupMenuTool25.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool65,
      (ToolBase) buttonTool66
    });
    ((ToolsCollectionBase) this.utmAcctingMenu.Tools).AddRange(new ToolBase[47]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) popupMenuTool11,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) popupMenuTool12,
      (ToolBase) popupMenuTool13,
      (ToolBase) popupMenuTool15,
      (ToolBase) popupMenuTool16,
      (ToolBase) popupMenuTool18,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37,
      (ToolBase) buttonTool38,
      (ToolBase) buttonTool39,
      (ToolBase) buttonTool40,
      (ToolBase) popupMenuTool20,
      (ToolBase) buttonTool44,
      (ToolBase) buttonTool45,
      (ToolBase) buttonTool46,
      (ToolBase) buttonTool47,
      (ToolBase) buttonTool48,
      (ToolBase) popupMenuTool21,
      (ToolBase) buttonTool52,
      (ToolBase) popupMenuTool22,
      (ToolBase) buttonTool55,
      (ToolBase) buttonTool56,
      (ToolBase) popupMenuTool23,
      (ToolBase) popupMenuTool24,
      (ToolBase) buttonTool58,
      (ToolBase) buttonTool59,
      (ToolBase) buttonTool60,
      (ToolBase) buttonTool61,
      (ToolBase) buttonTool62,
      (ToolBase) buttonTool63,
      (ToolBase) buttonTool64,
      (ToolBase) popupMenuTool25
    });
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._frmAccountingMenu_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top).Name = "_frmAccountingMenu_Toolbars_Dock_Area_Top";
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top).Size = new Size(992, 22);
    this._frmAccountingMenu_Toolbars_Dock_Area_Top.ToolbarsManager = this.utmAcctingMenu;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._frmAccountingMenu_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom).Location = new Point(0, 334);
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom).Name = "_frmAccountingMenu_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom).Size = new Size(992, 0);
    this._frmAccountingMenu_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.utmAcctingMenu;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._frmAccountingMenu_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left).Location = new Point(0, 22);
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left).Name = "_frmAccountingMenu_Toolbars_Dock_Area_Left";
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left).Size = new Size(0, 312);
    this._frmAccountingMenu_Toolbars_Dock_Area_Left.ToolbarsManager = this.utmAcctingMenu;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._frmAccountingMenu_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right).Location = new Point(992, 22);
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right).Name = "_frmAccountingMenu_Toolbars_Dock_Area_Right";
    ((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right).Size = new Size(0, 312);
    this._frmAccountingMenu_Toolbars_Dock_Area_Right.ToolbarsManager = this.utmAcctingMenu;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(992, 334);
    this.Controls.Add((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmAccountingMenu_Toolbars_Dock_Area_Bottom);
    this.Name = nameof (formAccountingMenu);
    this.Text = nameof (formAccountingMenu);
    ((ISupportInitialize) this.utmAcctingMenu).EndInit();
    this.ResumeLayout(false);
  }
}
