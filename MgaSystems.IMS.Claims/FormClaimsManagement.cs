// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormClaimsManagement
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinStatusBar;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Claims.Attorney_Management;
using MGASystems.IMS.Claims.Claim_Location_Settings;
using MGASystems.IMS.Claims.ClaimLocks;
using MGASystems.IMS.Claims.My_Claims;
using MGASystems.IMS.Claims.NumberingAutomation;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Claims.ReserveSecurity;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

[SecureHotkeyResource("{EA38AB9C-FD28-4499-AE11-3E0F01AA9E79}", "Claims System Hot Key", "Determines if the user can access the claims system from the hot key bar.", "Claims")]
[HotKeyInfo("IMS Claims", "Claims", "Click here to launch the claims management system.", Keys.F10, "MGASystems.Tools.coins.png", "F10")]
public class FormClaimsManagement : 
  FormBase,
  IRecreatableEntity,
  ISupportDocumentSystem,
  ISupportNoteSystem
{
  private const string TRANSFERPAYMENT_SHOWMODAL = "TRANSFERPAYMENT_SHOWMODAL";
  private Control _claimsSearch;
  protected ClaimsAdministrationPortal _claimsAdminPortal;
  private ClaimNumberingAutomationUI _claimNumberingAutomationUI;
  private ClaimNumberAutomationLinkingUI _claimNumberAutomationLinking;
  private AfterSelectChangeEventHandler _gridChangeHandler;
  private bool showAlert = true;
  private DataTable dt;
  private IContainer components;
  private Panel panelTop;
  private Panel panelLeft;
  private UltraExplorerBar explorerNavigiation;
  private PictureBox pictureBox1;
  private Label labelFormHeader;
  private Label labelLine;
  private UltraToolTipManager paymentTransferToolTipMngr;
  private PictureBox pictureBox2;
  private PictureBox picAlert;
  private Timer timerAlert;
  private UltraToolTipManager ultraToolTipManager1;
  public Panel panelContent;
  public UltraStatusBar ultraStatusBar1;

  public FormClaimsManagement()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.ResizeRedraw, true);
  }

  protected virtual void LoadClaimsSearch()
  {
    this._claimsSearch = (Control) ObjectFactory.Instance.CreateObject(typeof (ClaimsSearch));
    this.DisplayControl(this._claimsSearch);
    this.AcceptButton = (IButtonControl) ((IClaimsSearch) this._claimsSearch).AcceptButton;
    this.CancelButton = (IButtonControl) ((IClaimsSearch) this._claimsSearch).CancelButton;
    this.HookUpSearchEvents();
  }

  private void LoadClaimAttorneys()
  {
    if (!MGASystems.Common.SystemSettings.KeyExists("CLAIMS_LEGACYATTORNEYS"))
      return;
    this.explorerNavigiation.Groups[3].Items["ATTORNEYMANAGEMENT"].Visible = !MGASystems.Common.SystemSettings.GetBoolSetting("CLAIMS_LEGACYATTORNEYS");
  }

  private void LoadClaimNumberingAutomationUI()
  {
    this._claimNumberingAutomationUI = ObjectFactory.Instance.CreateObjectAs<ClaimNumberingAutomationUI>();
    this.DisplayControl((Control) this._claimNumberingAutomationUI);
  }

  private void LoadClaimNumberingAutomationLinkingUI()
  {
    this._claimNumberAutomationLinking = new ClaimNumberAutomationLinkingUI();
    this.DisplayControl((Control) this._claimNumberAutomationLinking);
  }

  protected virtual void LoadClaimsAdministrationPortal(
    ClaimsAdministrationPortal.AdministrationPortalType portalType)
  {
    if (this._claimsAdminPortal == null)
      this._claimsAdminPortal = new ClaimsAdministrationPortal();
    this._claimsAdminPortal.LoadClaimsAdmistration();
    this._claimsAdminPortal.PortalType = portalType;
    this.DisplayControl((Control) this._claimsAdminPortal);
  }

  private void LoadExpenseTransfer()
  {
    using (FormExpenseTransfer form = (FormExpenseTransfer) ObjectFactory.Instance.CreateForm(typeof (FormExpenseTransfer)))
    {
      int num = (int) form.ShowDialog();
    }
  }

  protected virtual void LoadPaymentTransfer()
  {
    if (MGASystems.Common.SystemSettings.KeyExists("TRANSFERPAYMENT_SHOWMODAL") && MGASystems.Common.SystemSettings.GetBoolSetting("TRANSFERPAYMENT_SHOWMODAL"))
    {
      using (FormPaymentTransfer form = (FormPaymentTransfer) ObjectFactory.Instance.CreateForm(typeof (FormPaymentTransfer)))
      {
        int num = (int) form.ShowDialog();
      }
    }
    else
    {
      FormPaymentTransfer form = (FormPaymentTransfer) ObjectFactory.Instance.CreateForm(typeof (FormPaymentTransfer));
      form.MdiParent = MDIControls.Instance.MDIParent;
      form.Show();
    }
  }

  protected virtual void DisplayControl(Control control)
  {
    if (this.panelContent.Controls.Count > 0)
    {
      if (this.panelContent.Controls[0].Equals((object) control))
        return;
      if (this.panelContent.Controls[0] is IClaimsSearch)
        (this.panelContent.Controls[0] as IClaimsSearch).ResultsGrid.AfterSelectChange -= this._gridChangeHandler;
    }
    ((Control) this.ultraStatusBar1).SendToBack();
    this.panelLeft.SendToBack();
    this.panelTop.SendToBack();
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add(control);
    this.panelContent.Controls[0].BringToFront();
    this.panelContent.Controls[0].Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
    this.panelContent.Controls[0].Dock = DockStyle.Fill;
    this.panelContent.BringToFront();
  }

  private void LoadExpenseAutomationManager()
  {
    using (FormAutomatedExpenses form = (FormAutomatedExpenses) ObjectFactory.Instance.CreateForm(typeof (FormAutomatedExpenses)))
    {
      int num = (int) form.ShowDialog();
    }
  }

  private void LoadClaimExpenseManager()
  {
    using (FormUnallocatedExpenses form = (FormUnallocatedExpenses) ObjectFactory.Instance.CreateForm(typeof (FormUnallocatedExpenses)))
    {
      int num = (int) form.ShowDialog();
    }
  }

  private void LoadAccountSettings()
  {
    if (MGASystems.Common.SystemSettings.KeyExists("Claims.ShowLocationSettings") && MGASystems.Common.SystemSettings.GetBoolSetting("Claims.ShowLocationSettings"))
    {
      using (LocationSettingsForm form = (LocationSettingsForm) ObjectFactory.Instance.CreateForm(typeof (LocationSettingsForm)))
      {
        int num = (int) ((Form) form).ShowDialog();
      }
    }
    else
    {
      using (FormSettings form = (FormSettings) ObjectFactory.Instance.CreateForm(typeof (FormSettings)))
      {
        int num = (int) form.ShowDialog();
      }
    }
  }

  private void explorerNavigiation_ItemClick(object sender, ItemEventArgs e)
  {
    if (this.AcceptButton != null)
      this.AcceptButton = (IButtonControl) null;
    if (((SubObjectBase) e.Item).Tag is IClaimsExplorerProviderExtensions)
    {
      this.LoadClaimsExtension((((SubObjectBase) e.Item).Tag as IClaimsExplorerProviderExtensions).FormType, (((SubObjectBase) e.Item).Tag as IClaimsExplorerProviderExtensions).ShowFormModal, (((SubObjectBase) e.Item).Tag as IClaimsExplorerProviderExtensions).SecurityGuid);
    }
    else
    {
      string key = e.Item.Key;
      if (key == null)
        return;
      switch (key.Length)
      {
        case 8:
          switch (key[0])
          {
            case 'A':
              if (!(key == "ADDCLAIM"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{4FC4C027-7466-4499-AEE4-E9160E605315}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              if (!(this.panelContent.Controls[0] is ClaimsSearch))
                return;
              (this.panelContent.Controls[0] as ClaimsSearch).AddNew();
              return;
            case 'M':
              if (!(key == "MYCLAIMS"))
                return;
              this.LoadMyClaims();
              return;
            case 'S':
              if (!(key == "SETTINGS"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{5238598C-FDE6-4530-A9CC-8502FC0A4375}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadAccountSettings();
              return;
            default:
              return;
          }
        case 9:
          switch (key[0])
          {
            case 'A':
              if (!(key == "AUDITUSER"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{2BB9808F-C73F-4986-A85F-27F6C82E9C5A}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to manage audit user access.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              using (formClaimsAuditUserManagement auditUserManagement = new formClaimsAuditUserManagement())
              {
                int num = (int) auditUserManagement.ShowDialog();
                return;
              }
            case 'O':
              if (!(key == "OPENCLAIM") || !(this.panelContent.Controls[0] is ClaimsSearch))
                return;
              (this.panelContent.Controls[0] as ClaimsSearch).OpenClaim();
              return;
            case 'V':
              if (!(key == "VIEWCLAIM") || !(this.panelContent.Controls[0] is ClaimsSearch))
                return;
              (this.panelContent.Controls[0] as ClaimsSearch).ViewClaims();
              return;
            default:
              return;
          }
        case 10:
          if (!(key == "CLAIMLOCKS"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{B688A03F-0A33-4D90-9EBF-D0A4247F38FB}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to manage the claim locks.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          using (FormClaimLockManagement claimLockManagement = new FormClaimLockManagement())
          {
            int num = (int) claimLockManagement.ShowDialog();
            break;
          }
        case 11:
          switch (key[0])
          {
            case 'C':
              if (!(key == "CLAIMSEARCH"))
                return;
              this.LoadClaimsSearch();
              return;
            case 'D':
              if (!(key == "DELETECLAIM"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{E0F4F16E-5F28-48df-9DA9-ACC8212F2F9C}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              if (!(this.panelContent.Controls[0] is ClaimsSearch))
                return;
              (this.panelContent.Controls[0] as ClaimsSearch).DeleteClaim();
              return;
            default:
              return;
          }
        case 12:
          switch (key[0])
          {
            case 'M':
              if (!(key == "MANCAR_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{53E61D58-7820-4548-9272-7ED6EB68A181}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.ManagedCareFacilities);
              return;
            case 'O':
              if (!(key == "OUTADJ_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{42DB54B5-FCAB-4445-9E7C-A74872F81D9E}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.OutsideAdjusters);
              return;
            case 'R':
              if (!(key == "RESPAY_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{533D63A4-71F1-4ADA-878B-42887DCFE0BD}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentTypes);
              return;
            default:
              return;
          }
        case 13:
          switch (key[1])
          {
            case 'A':
              if (!(key == "CATCODE_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{FFB8BD7F-5A98-42CA-A3A5-60D224464949}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.CatastropheCodes);
              return;
            case 'B':
              return;
            case 'C':
              if (!(key == "ACCTYPE_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{8817DA10-2383-4F7F-9B69-C16F74524E75}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.AccidentTypes);
              return;
            case 'D':
              return;
            case 'E':
              if (!(key == "SETTYPE_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{9C7C462E-7DDD-4511-A553-A65C1A2CACDF}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.SettlementTypes);
              return;
            case 'O':
              if (!(key == "COVTYPE_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{F5A1950B-E3EF-471A-8D1E-B3E2A427E0F5}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypes);
              return;
            default:
              return;
          }
        case 14:
          if (!(key == "LOSSTYPE_ADMIN"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{E1192581-EB1A-4547-813F-4D4D8C35CE16}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.LossTypes);
          break;
        case 15:
          switch (key[0])
          {
            case 'R':
              if (!(key == "RESPAYSUB_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{C70635DA-E735-4C8F-ABD3-AC52F9968F17}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.ReservePaymentSubTypes);
              return;
            case 'T':
              if (!(key == "TRANSFEREXPENSE"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{DAD64904-6B99-4A8E-B959-23756D49B95F}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to transfer expenses.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadExpenseTransfer();
              return;
            default:
              return;
          }
        case 16 /*0x10*/:
          if (!(key == "TRANSFERPAYMENTS"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{FC4B17CD-2531-4F3C-95DD-B3C3C17EF5C1}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          this.LoadPaymentTransfer();
          break;
        case 17:
          switch (key[0])
          {
            case 'C':
              if (!(key == "COVTYPEDESC_ADMIN"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{C22023E1-432B-4A5E-9198-748A7FD11A96}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimsAdministrationPortal(ClaimsAdministrationPortal.AdministrationPortalType.CoverageTypeDescriptions);
              return;
            case 'E':
              if (!(key == "EXPENSEAUTOMATION"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{FF0DD32C-D68B-4F90-8828-0B5B78BD321E}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadExpenseAutomationManager();
              return;
            default:
              return;
          }
        case 18:
          if (!(key == "ATTORNEYMANAGEMENT"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{A7E673B7-B685-46DE-AFBA-3C24E660B2FE}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to manage attorneys.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Claims.MVC.ShowAttorneyManagement"))
          {
            using (AttorneyManagementForm form = (AttorneyManagementForm) ObjectFactory.Instance.CreateForm(typeof (AttorneyManagementForm)))
            {
              int num = (int) ((Form) form).ShowDialog();
              break;
            }
          }
          using (FormAttorneyManagement attorneyManagement = new FormAttorneyManagement())
          {
            int num = (int) attorneyManagement.ShowDialog();
            break;
          }
        case 19:
          switch (key[0])
          {
            case 'C':
              if (!(key == "COVERAGECODELINKING"))
                return;
              using (FormCoverageCodeLinking coverageCodeLinking = new FormCoverageCodeLinking())
              {
                int num = (int) coverageCodeLinking.ShowDialog();
                return;
              }
            case 'U':
              if (!(key == "UNALLOCATEDEXPENSES"))
                return;
              if (!SecurityManager.Instance.AssertPermission("{3311A9E3-78DC-4D13-96B4-D9B07B7F2C1D}"))
              {
                int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              this.LoadClaimExpenseManager();
              return;
            default:
              return;
          }
        case 21:
          if (!(key == "CLAIMNUMBERAUTOMATION"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{DF7D3FDD-6348-4412-AE40-8988E4F2B7A6}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          this.LoadClaimNumberingAutomationUI();
          break;
        case 22:
          if (!(key == "RESERVELEVELMANAGEMENT"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{EFFB6D77-905E-4542-9A8E-22087814FCE8}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          using (FormReserveSecurity objectAs = ObjectFactory.Instance.CreateObjectAs<FormReserveSecurity>())
          {
            int num = (int) objectAs.ShowDialog();
            break;
          }
        case 23:
          if (!(key == "NUMBERAUTOMATIONLINKING"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{5AE2F4B9-FC01-4132-B8C6-4D62592A4249}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          this.LoadClaimNumberingAutomationLinkingUI();
          break;
        case 27:
          if (!(key == "CLAIMRESERVELEVELMANAGEMENT"))
            break;
          if (!SecurityManager.Instance.AssertPermission("{90947E33-50EE-441D-9A13-42A3ADE5E203}"))
          {
            int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          }
          using (Form form = ObjectFactory.Instance.CreateForm(typeof (FormClaimReserveSecurity)))
          {
            int num = (int) form.ShowDialog();
            break;
          }
      }
    }
  }

  private void LoadClaimsExtension(Type formType, bool showAsDialog, string securityGuid)
  {
    if (!string.IsNullOrEmpty(securityGuid) && !SecurityManager.Instance.AssertPermission(securityGuid))
    {
      using (formAccessDenied formAccessDenied = new formAccessDenied())
      {
        int num = (int) ((Form) formAccessDenied).ShowDialog();
      }
    }
    else
    {
      Form form = ObjectFactory.Instance.CreateForm(formType);
      if (showAsDialog)
      {
        int num = (int) form.ShowDialog();
        form.Dispose();
      }
      else
      {
        form.MdiParent = MDIControls.Instance.MDIParent;
        form.Show();
      }
    }
  }

  protected virtual void HookUpSearchEvents()
  {
    this._gridChangeHandler = new AfterSelectChangeEventHandler(this.gridSearchResults_AfterSelectChange);
    (this.panelContent.Controls[0] as IClaimsSearch).ResultsGrid.AfterSelectChange += this._gridChangeHandler;
  }

  private void gridSearchResults_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (((SparseCollectionBase) (sender as UltraGrid).Selected.Rows).Count == 0)
      return;
    UltraGridRow row = (sender as UltraGrid).Selected.Rows[0];
    if (((GridItemBase) row).Band.Index == 1)
    {
      this.explorerNavigiation.Groups[0].Items["OPENCLAIM"].Settings.Enabled = (DefaultableBoolean) 1;
      this.explorerNavigiation.Groups[0].Items["DELETECLAIM"].Settings.Enabled = (DefaultableBoolean) 1;
      this.explorerNavigiation.Groups[0].Items["ADDCLAIM"].Settings.Enabled = (DefaultableBoolean) 2;
      this.explorerNavigiation.Groups[0].Items["VIEWCLAIM"].Settings.Enabled = (DefaultableBoolean) 2;
    }
    else
    {
      this.explorerNavigiation.Groups[0].Items["OPENCLAIM"].Settings.Enabled = (DefaultableBoolean) 2;
      this.explorerNavigiation.Groups[0].Items["DELETECLAIM"].Settings.Enabled = (DefaultableBoolean) 2;
      this.explorerNavigiation.Groups[0].Items["ADDCLAIM"].Settings.Enabled = (DefaultableBoolean) 1;
      if ((int) row.Cells["NumberOfClaims"].Value != 0)
        this.explorerNavigiation.Groups[0].Items["VIEWCLAIM"].Settings.Enabled = (DefaultableBoolean) 1;
      else
        this.explorerNavigiation.Groups[0].Items["VIEWCLAIM"].Settings.Enabled = (DefaultableBoolean) 2;
    }
  }

  private void LoadMenuExtensions()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IClaimsExplorerProvider));
    if (typeArray.Length == 0)
      return;
    foreach (Type baseType in typeArray)
    {
      if (baseType.GetInterface("IClaimsExplorerProvider", true) != (Type) null && ObjectFactory.Instance.CreateObject(baseType) is IClaimsExplorerProvider explorerProvider)
      {
        UltraExplorerBarGroup explorerBarGroup = explorerProvider.BuildExplorerMenu();
        if (explorerBarGroup != null)
          this.explorerNavigiation.Groups.Insert(((DisposableObjectCollectionBase) this.explorerNavigiation.Groups).Count, explorerBarGroup);
      }
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  bool ISupportDocumentSystem.AllowAddNewDocument => true;

  bool ISupportNoteSystem.CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler NoteEntityInfoChanged;

  event ISupportNoteSystem.EntityInfoChangedEventHandler ISupportNoteSystem.EntityInfoChanged
  {
    add => this.NoteEntityInfoChanged += value;
    remove => this.NoteEntityInfoChanged += value;
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  Guid IRecreatableEntity.EntityGuid => new Guid("{171D6129-B1BD-4F1A-9132-C128983FABA9}");

  string IRecreatableEntity.EntityName => "Claims System";

  string IRecreatableEntity.FriendlyEntityName => "Claims System";

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid) => false;

  string IRecreatableEntity.RecreateTypeName => typeof (FormClaims).ToString();

  private void SetPaymentTransferAlert(PaintEventArgs paintArgs)
  {
    GroupUIElement uiElement1 = this.explorerNavigiation.Groups["MNG"].UIElement;
    if (this.explorerNavigiation.Groups["MNG"].Selected)
      this.picAlert.BackgroundImage = (Image) Resources.alertSelectedBG;
    else
      this.picAlert.BackgroundImage = (Image) Resources.alertBG;
    if (uiElement1 != null)
    {
      this.picAlert.Left = ((UIElement) uiElement1).Rect.Left + (((UIElement) uiElement1).Rect.Width - this.picAlert.Width);
      this.picAlert.Top = ((UIElement) uiElement1).Rect.Top + 4;
    }
    UIElement uiElement2 = ((UIElement) this.explorerNavigiation.UIElement).ElementFromPoint(((ControlUIElementBase) this.explorerNavigiation.UIElement).CurrentMousePosition);
    if (uiElement2 == null || !uiElement2.GetType().Equals(typeof (UltraExplorerBarGroupHeaderUIElement)))
      return;
    if (this.explorerNavigiation.Groups["MNG"].Selected)
      this.picAlert.BackgroundImage = (Image) Resources.alertHoverAndSelected;
    else
      this.picAlert.BackgroundImage = (Image) Resources.alterHoverBG;
  }

  private void FormClaimsManagement_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.Initialize();
    this.LoadClaimsSearch();
    this.LoadClaimAttorneys();
    this.LoadMenuExtensions();
    this.CheckForPayments();
    this.ShowMyClaimsGroup();
    if (!MGASystems.Common.SystemSettings.KeyExists("CLAIM_SHOWMYCLAIMS") || !MGASystems.Common.SystemSettings.GetBoolSetting("CLAIM_SHOWMYCLAIMS"))
      return;
    this.LoadMyClaims();
  }

  private void CheckForPayments()
  {
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) => this.dt = DefaultDatabase.ExecuteDataTable("spClaims_GetPaymentTransfer"));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        if (this.dt.Rows.Count > 0)
        {
          this.picAlert.Visible = true;
          this.timerAlert.Enabled = true;
          this.ultraStatusBar1.Panels[0].Text = $"There are {this.dt.Rows.Count} payments waiting to be transferred to accounting!";
          this.ultraStatusBar1.Panels[0].Visible = true;
        }
        else
        {
          this.picAlert.Visible = false;
          this.timerAlert.Enabled = false;
          this.ultraStatusBar1.Panels[0].Visible = false;
        }
        this.Cursor = MgaCursors.Default;
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void explorerNavigiation_Paint(object sender, PaintEventArgs e)
  {
    this.SetPaymentTransferAlert(e);
  }

  private void timerAlert_Tick(object sender, EventArgs e)
  {
    this.picAlert.Image = !this.showAlert ? (Image) null : (Image) Resources.CatastropheCodeSmall;
    this.showAlert = !this.showAlert;
  }

  private void picAlert_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{FC4B17CD-2531-4F3C-95DD-B3C3C17EF5C1}"))
    {
      int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      this.LoadPaymentTransfer();
  }

  private void picAlert_MouseEnter(object sender, EventArgs e)
  {
  }

  private void explorerNavigiation_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    if (!e.Element.GetType().Equals(typeof (UltraExplorerBarGroupHeaderUIElement)))
      return;
    this.picAlert.BackgroundImage = (Image) Resources.alterHoverBG;
  }

  private void explorerNavigiation_MouseHover(object sender, EventArgs e)
  {
  }

  private void ShowMyClaimsGroup()
  {
    if (!MGASystems.Common.SystemSettings.KeyExists("CLAIM_SHOWMYCLAIMS"))
      return;
    this.explorerNavigiation.Groups["MYCLAIMSGROUP"].Visible = MGASystems.Common.SystemSettings.GetBoolSetting("CLAIM_SHOWMYCLAIMS");
  }

  private void LoadMyClaims() => MDIControls.Instance.ActivateForm(typeof (FormMyClaims), true);

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormClaimsManagement));
    UltraToolTipInfo ultraToolTipInfo = new UltraToolTipInfo("There are payments waiting to be transferred!", (ToolTipImage) 3, "PAYMENT TRANSFER ALERT!", (DefaultableBoolean) 1);
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem();
    Appearance appearance1 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem();
    Appearance appearance2 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem4 = new UltraExplorerBarItem();
    Appearance appearance3 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem5 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem6 = new UltraExplorerBarItem();
    Appearance appearance4 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem7 = new UltraExplorerBarItem();
    Appearance appearance5 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem8 = new UltraExplorerBarItem();
    Appearance appearance6 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem9 = new UltraExplorerBarItem();
    Appearance appearance7 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem10 = new UltraExplorerBarItem();
    Appearance appearance8 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup4 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem11 = new UltraExplorerBarItem();
    Appearance appearance9 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem12 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem13 = new UltraExplorerBarItem();
    Appearance appearance10 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem14 = new UltraExplorerBarItem();
    Appearance appearance11 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem15 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem16 = new UltraExplorerBarItem();
    Appearance appearance12 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem17 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem18 = new UltraExplorerBarItem();
    Appearance appearance13 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem19 = new UltraExplorerBarItem();
    Appearance appearance14 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem20 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem21 = new UltraExplorerBarItem();
    Appearance appearance15 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem22 = new UltraExplorerBarItem();
    Appearance appearance16 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem23 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem24 = new UltraExplorerBarItem();
    Appearance appearance17 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem25 = new UltraExplorerBarItem();
    Appearance appearance18 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem26 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem27 = new UltraExplorerBarItem();
    Appearance appearance19 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem28 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem29 = new UltraExplorerBarItem();
    Appearance appearance20 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem30 = new UltraExplorerBarItem();
    Appearance appearance21 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem31 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem32 = new UltraExplorerBarItem();
    Appearance appearance22 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem33 = new UltraExplorerBarItem();
    Appearance appearance23 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem34 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem35 = new UltraExplorerBarItem();
    Appearance appearance24 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem36 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem37 = new UltraExplorerBarItem();
    Appearance appearance25 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem38 = new UltraExplorerBarItem();
    Appearance appearance26 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem39 = new UltraExplorerBarItem();
    Appearance appearance27 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem40 = new UltraExplorerBarItem();
    UltraExplorerBarItem ultraExplorerBarItem41 = new UltraExplorerBarItem();
    Appearance appearance28 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem42 = new UltraExplorerBarItem();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraStatusPanel ultraStatusPanel = new UltraStatusPanel();
    Appearance appearance34 = new Appearance();
    this.panelTop = new Panel();
    this.labelLine = new Label();
    this.pictureBox1 = new PictureBox();
    this.labelFormHeader = new Label();
    this.panelLeft = new Panel();
    this.picAlert = new PictureBox();
    this.explorerNavigiation = new UltraExplorerBar();
    this.pictureBox2 = new PictureBox();
    this.panelContent = new Panel();
    this.paymentTransferToolTipMngr = new UltraToolTipManager(this.components);
    this.timerAlert = new Timer(this.components);
    this.ultraToolTipManager1 = new UltraToolTipManager(this.components);
    this.ultraStatusBar1 = new UltraStatusBar();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panelLeft.SuspendLayout();
    ((ISupportInitialize) this.picAlert).BeginInit();
    ((ISupportInitialize) this.explorerNavigiation).BeginInit();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    ((ISupportInitialize) this.ultraStatusBar1).BeginInit();
    this.SuspendLayout();
    this.panelTop.Controls.Add((Control) this.labelLine);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Controls.Add((Control) this.labelFormHeader);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(218, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(761, 77);
    this.panelTop.TabIndex = 0;
    this.labelLine.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelLine.Dock = DockStyle.Bottom;
    this.labelLine.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelLine.Location = new Point(0, 76);
    this.labelLine.Name = "labelLine";
    this.labelLine.Size = new Size(761, 1);
    this.labelLine.TabIndex = 2;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(21, 5);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(72, 72);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    this.labelFormHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.labelFormHeader.Font = new Font("Arial", 16f, FontStyle.Bold);
    this.labelFormHeader.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelFormHeader.Location = new Point(196, 44);
    this.labelFormHeader.Name = "labelFormHeader";
    this.labelFormHeader.Size = new Size(562, 28);
    this.labelFormHeader.TabIndex = 0;
    this.labelFormHeader.Text = "Claims Management";
    this.labelFormHeader.TextAlign = ContentAlignment.MiddleRight;
    this.panelLeft.BackColor = Color.Transparent;
    this.panelLeft.Controls.Add((Control) this.picAlert);
    this.panelLeft.Controls.Add((Control) this.explorerNavigiation);
    this.panelLeft.Controls.Add((Control) this.pictureBox2);
    this.panelLeft.Dock = DockStyle.Left;
    this.panelLeft.Location = new Point(0, 0);
    this.panelLeft.Name = "panelLeft";
    this.panelLeft.Size = new Size(218, 743);
    this.panelLeft.TabIndex = 1;
    this.picAlert.BackColor = Color.Transparent;
    this.picAlert.BackgroundImage = (Image) Resources.alertBG;
    this.picAlert.Cursor = Cursors.Hand;
    this.picAlert.Image = (Image) Resources.CatastropheCodeSmall;
    this.picAlert.Location = new Point(194, 587);
    this.picAlert.Name = "picAlert";
    this.picAlert.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.picAlert.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picAlert.TabIndex = 2;
    this.picAlert.TabStop = false;
    ultraToolTipInfo.Enabled = (DefaultableBoolean) 1;
    ultraToolTipInfo.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo.ToolTipText = "There are payments waiting to be transferred!";
    ultraToolTipInfo.ToolTipTitle = "PAYMENT TRANSFER ALERT!";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.picAlert, ultraToolTipInfo);
    this.picAlert.Visible = false;
    this.picAlert.Click += new EventHandler(this.picAlert_Click);
    this.picAlert.MouseEnter += new EventHandler(this.picAlert_MouseEnter);
    this.explorerNavigiation.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.explorerNavigiation).Dock = DockStyle.Fill;
    ultraExplorerBarItem1.Key = "CLAIMSEARCH";
    ((AppearanceBase) appearance1).Image = (object) Resources.SearchClaimSmall;
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ultraExplorerBarItem1.Text = "Search/New Claim";
    ultraExplorerBarItem2.Settings.SeparatorStyle = (SeparatorStyle) 1;
    ultraExplorerBarItem2.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem2.Text = "New Item";
    ultraExplorerBarItem3.Key = "ADDCLAIM";
    ((AppearanceBase) appearance2).Image = (object) Resources.Add;
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ultraExplorerBarItem3.Settings.Enabled = (DefaultableBoolean) 2;
    ultraExplorerBarItem3.Text = "Add Claim";
    ultraExplorerBarItem4.Key = "VIEWCLAIM";
    ((AppearanceBase) appearance3).Image = (object) Resources.View;
    ultraExplorerBarItem4.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ultraExplorerBarItem4.Settings.Enabled = (DefaultableBoolean) 2;
    ultraExplorerBarItem4.Text = "View Claim";
    ultraExplorerBarItem5.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem5.Text = "New Item";
    ultraExplorerBarItem6.Key = "OPENCLAIM";
    ((AppearanceBase) appearance4).Image = (object) Resources.Edit;
    ultraExplorerBarItem6.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ultraExplorerBarItem6.Settings.Enabled = (DefaultableBoolean) 2;
    ultraExplorerBarItem6.Text = "Open Claim";
    ultraExplorerBarItem7.Key = "DELETECLAIM";
    ((AppearanceBase) appearance5).Image = (object) Resources.DeleteClaimSmall;
    ultraExplorerBarItem7.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ultraExplorerBarItem7.Settings.Enabled = (DefaultableBoolean) 2;
    ultraExplorerBarItem7.Text = "Delete Claim";
    explorerBarGroup1.Items.AddRange(new UltraExplorerBarItem[7]
    {
      ultraExplorerBarItem1,
      ultraExplorerBarItem2,
      ultraExplorerBarItem3,
      ultraExplorerBarItem4,
      ultraExplorerBarItem5,
      ultraExplorerBarItem6,
      ultraExplorerBarItem7
    });
    explorerBarGroup1.Text = "Claim Options";
    explorerBarGroup2.Expanded = false;
    ultraExplorerBarItem8.Key = "MYCLAIMS";
    ((AppearanceBase) appearance6).Image = (object) Resources.information;
    ultraExplorerBarItem8.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ultraExplorerBarItem8.Text = "View My Claims";
    explorerBarGroup2.Items.AddRange(new UltraExplorerBarItem[1]
    {
      ultraExplorerBarItem8
    });
    explorerBarGroup2.Key = "MYCLAIMSGROUP";
    explorerBarGroup2.Text = "My Claims";
    explorerBarGroup2.Visible = false;
    ultraExplorerBarItem9.Key = "TRANSFEREXPENSE";
    ((AppearanceBase) appearance7).Image = (object) Resources.Transfer;
    ultraExplorerBarItem9.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance7;
    ultraExplorerBarItem9.Text = "Transfer Claims Expenses";
    ultraExplorerBarItem10.Key = "TRANSFERPAYMENTS";
    ((AppearanceBase) appearance8).Image = (object) Resources.Transfer;
    ultraExplorerBarItem10.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance8;
    ultraExplorerBarItem10.Text = "Transfer Claims Payments";
    explorerBarGroup3.Items.AddRange(new UltraExplorerBarItem[2]
    {
      ultraExplorerBarItem9,
      ultraExplorerBarItem10
    });
    explorerBarGroup3.Key = "MNG";
    explorerBarGroup3.Text = "Management Options";
    ultraExplorerBarItem11.Key = "ACCTYPE_ADMIN";
    ((AppearanceBase) appearance9).Image = (object) Resources.AccidentTypeSmall;
    ultraExplorerBarItem11.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ultraExplorerBarItem11.Text = "Accident Types";
    ultraExplorerBarItem12.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem12.Text = "-";
    ultraExplorerBarItem13.Key = "COVTYPE_ADMIN";
    ((AppearanceBase) appearance10).Image = (object) Resources.CoverageTypesSmall;
    ultraExplorerBarItem13.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ultraExplorerBarItem13.Text = "Coverage Types";
    ultraExplorerBarItem14.Key = "COVTYPEDESC_ADMIN";
    ((AppearanceBase) appearance11).Image = (object) Resources.CoverageTypeDescriptionsSmall;
    ultraExplorerBarItem14.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ultraExplorerBarItem14.Text = "Coverage Type Descriptions";
    ultraExplorerBarItem15.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem15.Text = "New Item";
    ultraExplorerBarItem15.Visible = false;
    ultraExplorerBarItem16.Key = "COVERAGECODELINKING";
    ((AppearanceBase) appearance12).Image = (object) Resources.CoverageTypeAssociations;
    ultraExplorerBarItem16.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ultraExplorerBarItem16.Text = "Coverage Type Associations";
    ultraExplorerBarItem16.Visible = false;
    ultraExplorerBarItem17.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem17.Text = "New Item";
    ultraExplorerBarItem18.Key = "CATCODE_ADMIN";
    ((AppearanceBase) appearance13).Image = (object) Resources.CatastropheCodeSmall;
    ultraExplorerBarItem18.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ultraExplorerBarItem18.Text = "Catastrophe Codes";
    ultraExplorerBarItem19.Key = "LOSSTYPE_ADMIN";
    ((AppearanceBase) appearance14).Image = (object) Resources.LossTypesSmall2;
    ultraExplorerBarItem19.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ultraExplorerBarItem19.Text = "Loss Types";
    ultraExplorerBarItem20.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem20.Text = "New Item";
    ultraExplorerBarItem21.Key = "MANCAR_ADMIN";
    ((AppearanceBase) appearance15).Image = (object) Resources.ManageCareSmall;
    ultraExplorerBarItem21.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ultraExplorerBarItem21.Text = "Manage Care Facilities";
    ultraExplorerBarItem22.Key = "OUTADJ_ADMIN";
    ((AppearanceBase) appearance16).Image = (object) Resources.OutsideAdjusterSmall;
    ultraExplorerBarItem22.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ultraExplorerBarItem22.Text = "Outside Adjusters";
    ultraExplorerBarItem23.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem23.Text = "New Item";
    ultraExplorerBarItem24.Key = "RESPAY_ADMIN";
    ((AppearanceBase) appearance17).Image = (object) Resources.ReservePaymentTypeSmall;
    ultraExplorerBarItem24.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ultraExplorerBarItem24.Text = "Reserve/Payment Type";
    ultraExplorerBarItem25.Key = "RESPAYSUB_ADMIN";
    ((AppearanceBase) appearance18).Image = (object) Resources.ReservePaymentSubTypeSmall;
    ultraExplorerBarItem25.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ultraExplorerBarItem25.Text = "Reserve/Payment Sub Types";
    ultraExplorerBarItem26.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem26.Text = "New Item";
    ultraExplorerBarItem27.Key = "SETTYPE_ADMIN";
    ((AppearanceBase) appearance19).Image = (object) Resources.SettlementTypesSmall;
    ultraExplorerBarItem27.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ultraExplorerBarItem27.Text = "Settlement Types";
    ultraExplorerBarItem28.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem28.Text = "New Item";
    ultraExplorerBarItem29.Key = "CLAIMNUMBERAUTOMATION";
    ((AppearanceBase) appearance20).Image = (object) Resources.Automation;
    ultraExplorerBarItem29.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ultraExplorerBarItem29.Text = "Claim Number Automation";
    ultraExplorerBarItem30.Key = "NUMBERAUTOMATIONLINKING";
    ((AppearanceBase) appearance21).Image = (object) Resources.NumberAutomationLinking;
    ultraExplorerBarItem30.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ultraExplorerBarItem30.Text = "Number Automation Linking";
    ultraExplorerBarItem31.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem31.Text = "New Item";
    ultraExplorerBarItem32.Key = "EXPENSEAUTOMATION";
    ((AppearanceBase) appearance22).Image = (object) Resources.ExpenseAutomation;
    ultraExplorerBarItem32.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance22;
    ultraExplorerBarItem32.Text = "Automation Management";
    ultraExplorerBarItem33.Key = "UNALLOCATEDEXPENSES";
    ((AppearanceBase) appearance23).Image = (object) Resources.ClaimExpenses;
    ultraExplorerBarItem33.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ultraExplorerBarItem33.Text = "Claim Expense Management";
    ultraExplorerBarItem34.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem34.Text = "New Item";
    ultraExplorerBarItem35.Key = "SETTINGS";
    ((AppearanceBase) appearance24).Image = (object) Resources.Settings;
    ultraExplorerBarItem35.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ultraExplorerBarItem35.Text = "Location/Account Settings";
    ultraExplorerBarItem36.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem36.Text = "New Item";
    ultraExplorerBarItem37.Key = "RESERVELEVELMANAGEMENT";
    ((AppearanceBase) appearance25).Image = (object) Resources.layers;
    ultraExplorerBarItem37.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ultraExplorerBarItem37.Text = "Reserve Level Management";
    ultraExplorerBarItem38.Key = "CLAIMRESERVELEVELMANAGEMENT";
    ((AppearanceBase) appearance26).Image = (object) Resources.Transfer;
    ultraExplorerBarItem38.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ultraExplorerBarItem38.Text = "Claim Reserve Level Mangement";
    ultraExplorerBarItem39.Key = "CLAIMLOCKS";
    ((AppearanceBase) appearance27).Image = componentResourceManager.GetObject("appearance29.Image");
    ultraExplorerBarItem39.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ultraExplorerBarItem39.Text = "Claim Locks";
    ultraExplorerBarItem40.Settings.Style = (ItemStyle) 4;
    ultraExplorerBarItem40.Text = "New Item";
    ultraExplorerBarItem41.Key = "AUDITUSER";
    ((AppearanceBase) appearance28).Image = (object) Resources.user_delete;
    ultraExplorerBarItem41.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ultraExplorerBarItem41.Text = "Audit User Management";
    ultraExplorerBarItem42.Key = "ATTORNEYMANAGEMENT";
    ((AppearanceBase) appearance29).Image = (object) Resources.user_gray;
    ultraExplorerBarItem42.Settings.AppearancesSmall.Appearance = (AppearanceBase) appearance29;
    ultraExplorerBarItem42.Text = "Attorney Management";
    explorerBarGroup4.Items.AddRange(new UltraExplorerBarItem[32 /*0x20*/]
    {
      ultraExplorerBarItem11,
      ultraExplorerBarItem12,
      ultraExplorerBarItem13,
      ultraExplorerBarItem14,
      ultraExplorerBarItem15,
      ultraExplorerBarItem16,
      ultraExplorerBarItem17,
      ultraExplorerBarItem18,
      ultraExplorerBarItem19,
      ultraExplorerBarItem20,
      ultraExplorerBarItem21,
      ultraExplorerBarItem22,
      ultraExplorerBarItem23,
      ultraExplorerBarItem24,
      ultraExplorerBarItem25,
      ultraExplorerBarItem26,
      ultraExplorerBarItem27,
      ultraExplorerBarItem28,
      ultraExplorerBarItem29,
      ultraExplorerBarItem30,
      ultraExplorerBarItem31,
      ultraExplorerBarItem32,
      ultraExplorerBarItem33,
      ultraExplorerBarItem34,
      ultraExplorerBarItem35,
      ultraExplorerBarItem36,
      ultraExplorerBarItem37,
      ultraExplorerBarItem38,
      ultraExplorerBarItem39,
      ultraExplorerBarItem40,
      ultraExplorerBarItem41,
      ultraExplorerBarItem42
    });
    explorerBarGroup4.Text = "Administrative Options";
    this.explorerNavigiation.Groups.AddRange(new UltraExplorerBarGroup[4]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3,
      explorerBarGroup4
    });
    ((AppearanceBase) appearance30).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance30).TextVAlignAsString = "Bottom";
    this.explorerNavigiation.GroupSettings.AppearancesLarge.Appearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.explorerNavigiation.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).ImageBackgroundAlpha = (Alpha) 2;
    this.explorerNavigiation.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance32;
    this.explorerNavigiation.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.explorerNavigiation.GroupSettings.HeaderButtonStyle = (UIElementButtonStyle) 11;
    this.explorerNavigiation.GroupSettings.ItemAreaInnerMargins.Bottom = 0;
    this.explorerNavigiation.GroupSettings.ItemAreaInnerMargins.Right = 0;
    this.explorerNavigiation.GroupSettings.ItemAreaInnerMargins.Top = 0;
    this.explorerNavigiation.GroupSettings.ItemAreaOuterMargins.Bottom = 1;
    this.explorerNavigiation.GroupSettings.ItemAreaOuterMargins.Left = 1;
    this.explorerNavigiation.GroupSettings.ItemAreaOuterMargins.Right = 1;
    this.explorerNavigiation.GroupSettings.ItemAreaOuterMargins.Top = 1;
    this.explorerNavigiation.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.explorerNavigiation.GroupSettings.NavigationPaneCollapsedGroupAreaText = "";
    this.explorerNavigiation.GroupSettings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    this.explorerNavigiation.GroupSettings.Style = (GroupStyle) 2;
    this.explorerNavigiation.GroupSpacing = 5;
    ((Control) this.explorerNavigiation).Location = new Point(0, 0);
    ((Control) this.explorerNavigiation).Name = "explorerNavigiation";
    this.explorerNavigiation.NavigationAllowGroupReorder = false;
    this.explorerNavigiation.NavigationCurrentGroupAreaMinHeight = 5;
    ((Control) this.explorerNavigiation).Size = new Size(218, 743);
    this.explorerNavigiation.Style = (UltraExplorerBarStyle) 3;
    ((Control) this.explorerNavigiation).TabIndex = 0;
    ((UltraControlBase) this.explorerNavigiation).UseOsThemes = (DefaultableBoolean) 2;
    this.explorerNavigiation.ViewStyle = (UltraExplorerBarViewStyle) 6;
    this.explorerNavigiation.ItemClick += new ItemClickEventHandler(this.explorerNavigiation_ItemClick);
    ((UltraControlBase) this.explorerNavigiation).MouseEnterElement += new UIElementEventHandler(this.explorerNavigiation_MouseEnterElement);
    ((Control) this.explorerNavigiation).Paint += new PaintEventHandler(this.explorerNavigiation_Paint);
    ((Control) this.explorerNavigiation).MouseHover += new EventHandler(this.explorerNavigiation_MouseHover);
    this.pictureBox2.Location = new Point(0, 0);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(100, 50);
    this.pictureBox2.TabIndex = 1;
    this.pictureBox2.TabStop = false;
    this.pictureBox2.Text = "pictureBox2";
    this.panelContent.BackColor = Color.Transparent;
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(218, 77);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(761, 645);
    this.panelContent.TabIndex = 2;
    this.paymentTransferToolTipMngr.ContainingControl = (Control) this;
    this.paymentTransferToolTipMngr.DisplayStyle = (ToolTipDisplayStyle) 2;
    this.timerAlert.Interval = 500;
    this.timerAlert.Tick += new EventHandler(this.timerAlert_Tick);
    this.ultraToolTipManager1.AutoPopDelay = 0;
    this.ultraToolTipManager1.ContainingControl = (Control) this;
    this.ultraToolTipManager1.DisplayStyle = (ToolTipDisplayStyle) 2;
    this.ultraToolTipManager1.InitialDelay = 0;
    ((AppearanceBase) appearance33).BackColor = Color.FromArgb(178, 212, (int) byte.MaxValue);
    this.ultraStatusBar1.Appearance = (AppearanceBase) appearance33;
    ((Control) this.ultraStatusBar1).Location = new Point(218, 722);
    ((Control) this.ultraStatusBar1).Name = "ultraStatusBar1";
    ((AppearanceBase) appearance34).Image = (object) Resources.CatastropheCodeSmall;
    ultraStatusPanel.Appearance = (AppearanceBase) appearance34;
    ultraStatusPanel.SizingMode = (PanelSizingMode) 3;
    this.ultraStatusBar1.Panels.AddRange(new UltraStatusPanel[1]
    {
      ultraStatusPanel
    });
    ((Control) this.ultraStatusBar1).Size = new Size(761, 21);
    ((Control) this.ultraStatusBar1).TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(979, 743);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.ultraStatusBar1);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panelLeft);
    this.Font = new Font("Tahoma", 8.25f);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormClaimsManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Claims Management";
    this.Load += new EventHandler(this.FormClaimsManagement_Load);
    this.panelTop.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panelLeft.ResumeLayout(false);
    ((ISupportInitialize) this.picAlert).EndInit();
    ((ISupportInitialize) this.explorerNavigiation).EndInit();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    ((ISupportInitialize) this.ultraStatusBar1).EndInit();
    this.ResumeLayout(false);
  }
}
