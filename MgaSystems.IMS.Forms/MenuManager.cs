// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.MenuManager
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Common.LogonServer;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Forms.Administration;
using MGASystems.IMS.Forms.EmailBlast;
using MGASystems.IMS.Forms.Entities;
using MGASystems.IMS.Forms.Users;
using MGASystems.IMS.InsuredsProducersCompanies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines.Blocking;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.ChangePassword;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Policies;
using MGASystems.IMS.Policies.Administration;
using MGASystems.IMS.Policies.AffidavitNumbering;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.Commissions;
using MGASystems.IMS.Policies.FormsConditionsWarranties;
using MGASystems.IMS.Policies.Invoices;
using MGASystems.IMS.Policies.PolicyNumbering;
using MGASystems.IMS.Policies.Rating;
using MGASystems.IMS.Policies.Rating.Classes;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[MenuManager]
[SecureResource("{48AED463-E95A-468b-92C0-5ADFCDB3814D}", "Access User Form", "Controls access to the user form that stores users' information.", "Tools")]
[SecureResource("{854B2ED6-647B-4f06-B5D3-EA1DE27707A7}", "Access Administration Menu", "Controls access to the Administration menu.", "Tools")]
[SecureResource("{D5A2E8B0-D9F9-44a4-AF36-750155971C43}", "Invoice Lookup", "Controls the ability to open the invoice lookup screen.", "Tools")]
[SecureResource("{93a12564-00b6-4485-ad57-6677ae982d4f}", "Documents Menu", "Controls the ability to view the documents menu under Administration menu.", "Administration")]
[SecureResource("{5F6E8DB8-1D58-4453-B1D9-77D0F70A1BE1}", "Controls access to Producer Blocking", "Allows users to access Producer Blocking menu  Under Administration menu", "Administration")]
[SecureResource("{9CEE7E6F-682C-4565-9BEB-23500957E937}", "Controls access to View Note System Menu", "Allows users to View Note System  Under Administration menu", "Administration")]
[SecureResource("{F692417B-B22C-4331-AF11-CEA82AF6C196}", "Controls access to View Process Unverified Insureds Menu", "Allows users to View Process Unverified Insureds Under Administration menu", "Administration")]
[SecureResource("{7DF23842-70D3-4C29-9379-C8352F9EEA9F}", "Controls access to View Process Unverified Producer Contacts Menu", "Allows users to View Process Unverified Producer Contacts Under Administration menu", "Administration")]
[SecureResource("{132EC678-9B93-4D2C-809B-58F89816448C}", "Controls access to View Inhouse Producer Assignment Menu", "Allows users to View Inhouse Producer Assignment Under Administration menu", "Administration")]
[SecureResource("{8C52FBE5-78E4-473A-97AE-144E09D29D81}", "Controls access to View Additional Interests Menu", "Allows users to View Additional Interests Under Administration menu", "Administration")]
[SecureResource("{6FFE5763-D88C-49C8-A621-4333239BAAC9}", "Controls access to View Taxable City Admin Menu", "Allows users to View Taxable City Admin Under Administration menu", "Administration")]
[SecureResource("{F320184A-1FB0-4404-87DC-5B1E27A3D20D}", "Controls access to View Excel Rating Management Menu", "Allows users to View Excel Rating Management Under Administration menu", "Administration")]
[SecureResource("{9B2FE990-A052-4AFB-938A-E780E8290359}", "Controls access to View User Tag Management Menu", "Allows users to View User Tag Management Under Administration menu", "Administration")]
[SecureResource("{14C52BE3-EB68-4380-A696-747FBDE979E9}", "Controls access to View AdHoc Reports Configuration Menu", "Allows users to View AdHoc Reports Configuration Under Administration menu", "Administration")]
[SecureResource("{EAC9FCD2-5E89-4A99-AB65-9AA8BEA9D9C0}", "Access Fee Automation", "Controls user's ability to view Fee Automation menu item", "Tools")]
[SecureResource("{B40B6162-865C-4CDC-BE0D-62694A4212C9}", "Access Commissions Menu", "Controls user's ability to view Commissions menu item", "Tools")]
public sealed class MenuManager : IMenuConsumer
{
  internal const string InvoiceLookup = "{D5A2E8B0-D9F9-44a4-AF36-750155971C43}";
  internal const string CanAccessDocumentsMenuAdmin = "{93a12564-00b6-4485-ad57-6677ae982d4f}";
  internal const string CanAccessUserForm = "{48AED463-E95A-468b-92C0-5ADFCDB3814D}";
  internal const string CanAccessAdminMenu = "{854B2ED6-647B-4f06-B5D3-EA1DE27707A7}";
  internal const string CanAccessFeeAutomation = "{EAC9FCD2-5E89-4A99-AB65-9AA8BEA9D9C0}";
  internal const string CanViewProducerBlocking = "{5F6E8DB8-1D58-4453-B1D9-77D0F70A1BE1}";
  internal const string CanViewNoteSystem = "{9CEE7E6F-682C-4565-9BEB-23500957E937}";
  internal const string CanViewProcessUnverifiedInsureds = "{F692417B-B22C-4331-AF11-CEA82AF6C196}";
  internal const string CanViewProcessUnverifiedProducers = "{7DF23842-70D3-4C29-9379-C8352F9EEA9F}";
  internal const string CanViewInhouseProducerroducerAssignment = "{132EC678-9B93-4D2C-809B-58F89816448C}";
  internal const string CanViewAdditionalInterests = "{8C52FBE5-78E4-473A-97AE-144E09D29D81}";
  internal const string CanViewTaxableCityAdmin = "{6FFE5763-D88C-49C8-A621-4333239BAAC9}";
  internal const string CanViewExcelRatingManagement = "{F320184A-1FB0-4404-87DC-5B1E27A3D20D}";
  internal const string CanViewUserTagManagement = "{9B2FE990-A052-4AFB-938A-E780E8290359}";
  internal const string CanViewAdHocReportsConfiguration = "{14C52BE3-EB68-4380-A696-747FBDE979E9}";
  internal const string ViewCommissions = "{B40B6162-865C-4CDC-BE0D-62694A4212C9}";
  private readonly Dictionary<string, bool> _existingResource;
  private MenuManager.SetupMenusArgs _menuArgs;
  private UltraToolbarsManager _menu;
  private static object _notesReminder = (object) null;
  private const string KEY_VIEW_OFACDASHBOARD = "View_OFACClearance";
  private const string KEY_TOOLS_EMAILSETTINGS = "Tools_EmailSettings";
  private const string KEY_ADMIN_SERVICEUSERSETTINGS = "Admin_ServiceEmailSettings";

  public MenuManager() => this._existingResource = new Dictionary<string, bool>();

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    try
    {
      if (!this._existingResource.ContainsKey(CurrentUser.Instance.UserGUID.ToString()))
      {
        this._existingResource.Clear();
        this.OnSetupIGMenu(((CancelableToolEventArgs) e).Tool.ToolbarsManager);
      }
      string key = ((CancelableToolEventArgs) e).Tool.Key;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
      {
        case 195200358:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Live View...", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Live View..."].SharedProps.Visible = this._existingResource["Live View..."];
          break;
        case 418356007:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "DocumentTransfer", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["DocumentTransfer"].SharedProps.Visible = this._existingResource["DocumentTransfer"];
          break;
        case 686840594:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Transaction Log", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["View Transaction Log"].SharedProps.Visible = this._existingResource["View Transaction Log"];
          break;
        case 880241382:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Underwriter Locations Assignment", false) != 0)
            break;
          MGASystems.Common.FormSettings.ShowForm(typeof (frmProducersUnderwriters));
          break;
        case 2253925574:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Invoice Lookup", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Invoice Lookup"].SharedProps.Visible = this._existingResource["Invoice Lookup"];
          break;
        case 2499909372:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Tools", false) != 0)
            break;
          if (this.ActiveMDIChild != null)
          {
            ISupportTemplateDocs supportTemplateDocs = ObjectFactory.QueryInterface<ISupportTemplateDocs>((object) this.ActiveMDIChild);
            if (supportTemplateDocs != null)
            {
              if (supportTemplateDocs.SupportedTemplateGroupIDs == null || supportTemplateDocs.SupportedTemplateGroupIDs.Count <= 0)
                break;
              ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Template Documents"].SharedProps.Visible = true;
              break;
            }
            ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Template Documents"].SharedProps.Visible = false;
            break;
          }
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Template Documents"].SharedProps.Visible = false;
          break;
        case 3068516317:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Preferences", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Preferences"].SharedProps.Visible = this._existingResource["Preferences"];
          break;
        case 3097358362:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Help", false) != 0)
            break;
          if (this.ActiveMDIChild != null && this.ActiveMDIChild is ISupportHelpSystem)
          {
            ISupportHelpSystem activeMdiChild = (ISupportHelpSystem) this.ActiveMDIChild;
            ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Help_CustomHelp"].SharedProps.Visible = activeMdiChild.HelpAvailableOnSelection;
            ((ToolPropsBase) ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Help_CustomHelp"].SharedProps).Caption = activeMdiChild.HelpMenuText;
            break;
          }
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Help_CustomHelp"].SharedProps.Visible = false;
          break;
        case 3271434715:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Security", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["Security"].SharedProps.Visible = this._existingResource["Security"];
          break;
        case 3637118314:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "IMS Tasks", false) != 0)
            break;
          ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["IMS Tasks"].SharedProps.Visible = this._existingResource["IMS Tasks"];
          break;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    string key = ((ToolEventArgs) e).Tool.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 77236764:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Third-Party Payees", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminExpensePayees), (object) frmAdminExpensePayees.ExpenseePayeeType.ThirdParty).Dispose();
        break;
      case 101555834:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Pro-Rata Wheel", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormProRataWheel));
        break;
      case 124575580:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View_Company", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmSelection), (object) frmSelection.SelectionTypes.Company);
        break;
      case 164903650:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "System Information", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmSysInfo)).Dispose();
        break;
      case 195200358:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Live View...", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmLiveView));
        break;
      case 202042405:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "In-house Producer / Producer Assignment", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormProducersInhouseProducers));
        break;
      case 204202610:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Intermediaries", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmIntermediaries));
        break;
      case 312113039:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Location Source", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerLocationSource));
        break;
      case 338022566:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Status Reasons", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminQuoteStatusReasons));
        break;
      case 343475695:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy Filing Management", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{E7F7140D-24A2-40d9-868A-2E96EDA83E7E}"))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (FormFilingInformation));
          break;
        }
        int num1 = (int) MessageBox.Show("You do not have sufficient security permission to view Policy Filing Management Information.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 363011634:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Region Source", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerRegionSource));
        break;
      case 418356007:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "DocumentTransfer", false) != 0)
          break;
        MDIControls.Instance.ActivateForm(typeof (frmDocumentOwnershipTransfer), true);
        break;
      case 513730793:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Import Claims", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{A52DCD4B-35C1-4605-A2F5-8EE9A4EAE6B0}"))
        {
          MGASystems.Common.FormSettings.ShowFormDialog(typeof (ClaimsExcelImport)).Dispose();
          break;
        }
        int num2 = (int) MessageBox.Show("You do not have the required permission(s) to access 'Import Claims' menu item.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 598030799:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Import Producers", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{6DEC057B-B2D4-4c57-826E-46655E069973}"))
        {
          MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormProducerExcelImport)).Dispose();
          break;
        }
        int num3 = (int) MessageBox.Show("You do not have the required permission(s) to access 'Import Producers' menu item.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 642720559:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BulkEmail", false) != 0)
          break;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select EmailAddress from tblusers where userguid =@UG", new object[2]
        {
          (object) "@UG",
          (object) CurrentUser.Instance.UserGUID
        })))))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (frmEmailBlast));
          break;
        }
        int num4 = (int) MessageBox.Show(SR.GetString("BULKEMAIL_NOEMAILSPECIFIED"), SR.GetString("BULKEMAIL_NOEMAILSPECIFIED_CAP"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        break;
      case 686840594:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Transaction Log", false) != 0)
          break;
        ITransactionLogFilter transactionLogFilter = ObjectFactory.QueryInterface<ITransactionLogFilter>((object) MDIControls.Instance.MDIParent.ActiveMdiChild);
        if (transactionLogFilter != null && transactionLogFilter.LogIdentifier.HasValue)
        {
          using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmTransactionLog), (object) transactionLogFilter.LogIdentifier))
            break;
        }
        using (MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmTransactionLog)))
          break;
      case 716961717:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Licenses", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{130F49D1-6485-42a4-BFDB-9A2B59FE33D3}"))
        {
          MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminLookups), (object) "lstLicenseTypes", (object) "LicenseType", (object) "LicenseTypeID", (object) "Licenses", (object) "License").Dispose();
          break;
        }
        int num5 = (int) MessageBox.Show("You do not have the authorization to access this form.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 794211233:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Template Documents", false) != 0 || MDIControls.Instance.MDIParent.ActiveMdiChild == null)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmDocumentTemplates), (object) ObjectFactory.QueryInterface<ISupportTemplateDocs>((object) this.ActiveMDIChild));
        break;
      case 939044132:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Note Types", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminNoteTypes));
        break;
      case 1027868899:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NewProducer", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{91B371AA-3B53-47ff-8797-A9676C7DEDF5}"))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (frmProducers));
          break;
        }
        int num6 = (int) MessageBox.Show("You do not have sufficient security to add producer  / locations.", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        break;
      case 1043809076:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Admin Inspection Requests", false) != 0)
          break;
        if (!SecurityManager.Instance.AssertPermission("{691E15C5-F8DE-4F77-94E1-F332F76A4B61}"))
        {
          int num7 = (int) MessageBox.Show("You do not have sufficient security permission to view Admin Inspection Requests.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        MGASystems.Common.FormSettings.ShowForm(typeof (FormAdminInspectionRequests));
        break;
      case 1082372440:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "DocumentNaming", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmDocumentNaming));
        break;
      case 1179742533:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Affidavit Numbers", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{3FEEBEF1-FC30-4554-8A23-6E9EB84B20D5}"))
        {
          frmSelectState frmSelectState = (frmSelectState) MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmSelectState));
          if (frmSelectState.Saved)
            MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminAffidavitNumbers), (object) frmSelectState.StateID).Dispose();
          frmSelectState.Dispose();
          break;
        }
        int num8 = (int) MessageBox.Show("You do not have sufficient security to access this form.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 1249278959:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Document Templates", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{278314E6-FFF6-4ef2-A5FD-4BE878B5C772}"))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (frmDocumentTemplates));
          break;
        }
        int num9 = (int) MessageBox.Show("You do not have the authorization to access this form.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 1251339553:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NewInsured", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmInsureds));
        break;
      case 1275771816:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NewCompany", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{C266F1AF-4856-4647-BC41-CE2D40D5E294}"))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanies));
          break;
        }
        int num10 = (int) MessageBox.Show("You do not have sufficient security to add new companies.", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        break;
      case 1296235819:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Import Producer Contacts", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{1F593A43-82D9-4c73-B14B-5BBD8ACD1A18}"))
        {
          MGASystems.Common.FormSettings.ShowFormDialog(typeof (formContactExcelImport)).Dispose();
          break;
        }
        int num11 = (int) MessageBox.Show("You do not have the required permission(s) to access 'Import Producer Contacts' menu item.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 1311177825:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Requirements", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminProducerRequirements)).Dispose();
        break;
      case 1311704911:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy Classes", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminRatingClasses)).Dispose();
        break;
      case 1372301015:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Conditions", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmConditions));
        break;
      case 1397576362:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "File_Logout", false) != 0)
          break;
        DockingManager.Close();
        CurrentUser.Instance.Logout();
        MenuManager.CloseAllWindows();
        Form form1 = ObjectFactory.Instance.CreateForm(typeof (frmLogIn));
        ILogInForm logInForm = ObjectFactory.QueryInterface<ILogInForm>((object) form1);
        try
        {
          if (form1.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) != DialogResult.OK | !logInForm.LoginSuccess)
          {
            MDIControls.Instance.MDIParent.Close();
            break;
          }
          DockingManager.Open((ISecurityManager) SecurityManager.Instance, (IRemoteObjectManager) new RemoteObjects());
          if (!Preferences.GetPreferenceBool("Toolbars.HotKeys.Visible"))
            break;
          HotKeyManager.GetInstance(MDIControls.Instance.MDIParent, (ISecurityManager) SecurityManager.Instance).ResetHotKeys();
          break;
        }
        finally
        {
          form1.Dispose();
        }
      case 1461820269:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Calculator", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormCalculator));
        break;
      case 1580824180:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Symbol Automation", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormSymbolAutomation));
        break;
      case 1606827116:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Help_Custom", false) != 0 || this.ActiveMDIChild == null || !(this.ActiveMDIChild is ISupportHelpSystem))
          break;
        ((ISupportHelpSystem) this.ActiveMDIChild).OnHelpClicked();
        break;
      case 1615032582:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Administration_Policy_PolNum", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminPolicyNumbers));
        break;
      case 1678542250:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Contact Management", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmContactManagement));
        break;
      case 1696534573:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy_Charges", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminPolicyCharges));
        break;
      case 1794498559:
        Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Misc_Refresh_Raters", false);
        break;
      case 1827142733:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Reporting", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmReportsAndExports));
        break;
      case 1916418324:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Process Unverified Insureds", false) != 0)
          break;
        this.ProcessUnverifiedInsureds();
        break;
      case 1987104150:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Tools_EmailSettings", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmEmailInfo), (object) CurrentUser.Instance.UserGUID);
        break;
      case 2031024326:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Finance Companies", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminExpensePayees), (object) frmAdminExpensePayees.ExpenseePayeeType.FinanceCompany).Dispose();
        break;
      case 2066373063:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Company Hierarchy", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmViewCompanyHierarchy));
        break;
      case 2080326478:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Administration_Insured_InsuredContacts", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminInsuredSpecialContacts));
        break;
      case 2089531359:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Administration_Locations_OfficeLocations", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmClientLocations));
        break;
      case 2172882084:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Inspection Companies", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminExpensePayees), (object) frmAdminExpensePayees.ExpenseePayeeType.InspectionCompany).Dispose();
        break;
      case 2194055415:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Business_Lines", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminLinesOfBusiness));
        break;
      case 2215022564:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Tools_ChangePassword", false) != 0)
          break;
        ObjectFactory.Instance.CreateObjectAs<ChangePasswordController>(typeof (ChangePasswordController)).DisplayUI();
        break;
      case 2231035415:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CRM Email", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormCRMEmailer));
        break;
      case 2253925574:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Invoice Lookup", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmInvoiceLookup));
        break;
      case 2293241532:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Administration_User_UserManagement", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{48AED463-E95A-468b-92C0-5ADFCDB3814D}"))
        {
          if (ServerXML.UseEncryptedPasswords)
          {
            MGASystems.Common.FormSettings.ShowForm(typeof (frmUserEncPwd));
            break;
          }
          MGASystems.Common.FormSettings.ShowForm(typeof (frmUsers));
          break;
        }
        int num12 = (int) MessageBox.Show("You do not have the permission to access the user form.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 2580465873:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Vin Verification", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmVinVerification));
        break;
      case 2614115285:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Admin_ServiceEmailSettings", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmEmailInfo), (object) 0);
        break;
      case 2702067390:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer Blocking", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormProducerLineBlocking));
        break;
      case 2745424209:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Program Codes", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormProgramCode));
        break;
      case 3003459724:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Help_About", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (FormAbout)).Dispose();
        break;
      case 3037367420:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Company Groups", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyGroups)).Dispose();
        break;
      case 3068516317:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Preferences", false) != 0)
          break;
        MDIControls.Instance.ActivateForm(typeof (frmAllPreferences), true);
        break;
      case 3151526038:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Fee Automation", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmAdminCompanyPolicyFees));
        break;
      case 3178427896:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Update CD Key", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmUpdateCDKey)).Dispose();
        break;
      case 3239575444:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Policy Forms", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmPolicyForms)).Dispose();
        break;
      case 3271434715:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Security", false) != 0)
          break;
        SecurityManager.Initialize(CurrentUser.Instance.UserGUID);
        Form form2 = ObjectFactory.Instance.CreateForm(typeof (FormAdminSecurityUsers));
        form2.MdiParent = MDIControls.Instance.MDIParent;
        form2.Show();
        break;
      case 3335586809:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Commissions", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{B40B6162-865C-4CDC-BE0D-62694A4212C9}"))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminCommissions));
          break;
        }
        int num13 = (int) MessageBox.Show("You do not have the required security to access Commissions menu item.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 3364644014:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "User Groups", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmEntityGroups));
        break;
      case 3410857649:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Users' Status", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmViewUserStatus));
        break;
      case 3467351170:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Status Change Reason List Source", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerStatusChangeReason));
        break;
      case 3480642605:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View_Insured", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmSelection), (object) frmSelection.SelectionTypes.Insured);
        break;
      case 3529351073:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Warranties", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmWarranties)).Dispose();
        break;
      case 3594422437:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View_Clearance", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmClearance));
        break;
      case 3637118314:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "IMS Tasks", false) != 0)
          break;
        Note_System.Instance.UIInteractive.ViewTodayScreen();
        break;
      case 3721247566:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View_OFACClearance", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminOfacManagement));
        break;
      case 3721984147:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Filing Automation", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormSLStateRules));
        break;
      case 3841820170:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CompanyLine Requirements", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormCompanyLineRequirements));
        break;
      case 3910216946:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Process Unverified Producer Contacts", false) != 0)
          break;
        this.ProcessUnverifiedProducers();
        break;
      case 3936984796:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View_Producers", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmSelection), (object) frmSelection.SelectionTypes.Producer);
        break;
      case 4051141676:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Configure Rater Conditionals", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (FormRaterConditionalsAdmin));
        break;
      case 4084111409:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Administration_Company_CompanyLinesManagement", false) != 0)
          break;
        if (!SecurityManager.Instance.AssertPermission("{A43461BA-305B-4911-8AE3-145BCBD9B9F8}"))
        {
          int num14 = (int) MessageBox.Show("You do not have permission to access the Company Lines screen.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        MGASystems.Common.FormSettings.ShowForm(typeof (frmCompanyLines));
        break;
      case 4165209188:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "File_Exit", false) != 0)
          break;
        MDIControls.Instance.MDIParent.Close();
        break;
      case 4183262906:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer/Underwriter Assignment", false) != 0)
          break;
        if (SecurityManager.Instance.AssertPermission("{ed79bbf4-0246-4d3a-9128-398f9884c27d}"))
        {
          MGASystems.Common.FormSettings.ShowForm(typeof (frmProducersUnderwriters));
          break;
        }
        int num15 = (int) MessageBox.Show("You do not have the authorization to access this form.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 4290230494:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Business Types", false) != 0)
          break;
        MGASystems.Common.FormSettings.ShowForm(typeof (frmAdminBusinessTypes), (object) "lstBusinessTypes", (object) "BusinessType", (object) "BusinessTypeID", (object) "Business Types", (object) "Type");
        break;
    }
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    this._menu = menu != null ? menu : throw new ArgumentNullException(nameof (menu));
    MenuManager.AddTool(this._menu, "View", "View_OFACClearance", "Sanctions Dashboard...", (Image) null);
    MenuManager.AddTool(this._menu, "Tools", "Tools_EmailSettings", "View Email Settings...", (Image) null, new int?(1));
    MenuManager.AddTool(this._menu, "Administration", "Process Unverified Producer Contacts", "Process Unverified Producer Contacts", (Image) null);
    MenuManager.AddTool(this._menu, "Administration_User", "Admin_ServiceEmailSettings", "Service User Mail Settings", (Image) null);
    this.SetupMenusThread();
    if (MenuManager._notesReminder != null)
      return;
    this.CreateNotesReminder();
    MenuManager._notesReminder = RuntimeHelpers.GetObjectValue(new object());
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  private void ProcessUnverifiedInsureds()
  {
    if (!OfacSystem.Instance.HasValidSetting || MessageBox.Show($"You are about to process unverified insureds via OFAC.{"\n"}{"\n"}Do you wish to continue?", "Process Unverified Insureds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DataTable source1 = DefaultDatabase.ExecuteDataTable(MenuManager.ResolveSetting<string>("Menu.OFAC.Insureds.UnverifiedProcedure", "dbo.GetOFACInsuredsNew"));
    if (source1.Rows.Count == 0)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable();
      System.Func<DataRow, InsuredLocation> selector;
      // ISSUE: reference to a compiler-generated field
      if (MenuManager._Closure\u0024__.\u0024I29\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = MenuManager._Closure\u0024__.\u0024I29\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        MenuManager._Closure\u0024__.\u0024I29\u002D0 = selector = (System.Func<DataRow, InsuredLocation>) ([SpecialName] (dr) => new InsuredLocation(dr.Field<Guid>("InsuredLocationGUID")));
      }
      List<InsuredLocation> list = source2.Select<DataRow, InsuredLocation>(selector).ToList<InsuredLocation>();
      int num = 1;
      try
      {
        foreach (InsuredLocation entity in list)
        {
          try
          {
            MDIControls.Instance.StatusBarText = $"Checking {num} of {list.Count}";
            ++num;
            OfacSystem.Instance.CheckOfac<InsuredLocation>(entity);
          }
          catch (Exception ex1)
          {
            ProjectData.SetProjectError(ex1);
            Exception ex2 = ex1;
            ex2.Data.Add((object) "InsuredLocationGUID", (object) entity.InsuredLocationGuid);
            ErrorHandler.SilentHandleError(ex2);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        List<InsuredLocation>.Enumerator enumerator;
        enumerator.Dispose();
      }
      MDIControls.Instance.StatusBarText = "";
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void ProcessUnverifiedProducers()
  {
    if (!OfacSystem.Instance.HasValidSetting || MessageBox.Show($"You are about to process unverified producer contacts via OFAC.{"\n"}{"\n"}Do you wish to continue?", "Process Unverified Producer Contacts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DataTable source1 = DefaultDatabase.ExecuteDataTable(MenuManager.ResolveSetting<string>("Menu.OFAC.ProducerContacts.UnverifiedProcedure", "dbo.GetOFACProducerContacts"));
    if (source1.Rows.Count == 0)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      List<ProducerContact> producerContactList;
      if (source1.Columns.Contains("ProducerContactID"))
      {
        EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable();
        System.Func<DataRow, int> selector;
        // ISSUE: reference to a compiler-generated field
        if (MenuManager._Closure\u0024__.\u0024I30\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = MenuManager._Closure\u0024__.\u0024I30\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          MenuManager._Closure\u0024__.\u0024I30\u002D0 = selector = (System.Func<DataRow, int>) ([SpecialName] (dr) => dr.Field<int>("ProducerContactID"));
        }
        producerContactList = BaseDataObject.SelectMany<ProducerContact>($"ProducerContactID IN ({string.Join<int>(",", (IEnumerable<int>) source2.Select<DataRow, int>(selector))})");
      }
      else
      {
        EnumerableRowCollection<DataRow> source3 = source1.AsEnumerable();
        System.Func<DataRow, ProducerContact> selector;
        // ISSUE: reference to a compiler-generated field
        if (MenuManager._Closure\u0024__.\u0024I30\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = MenuManager._Closure\u0024__.\u0024I30\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          MenuManager._Closure\u0024__.\u0024I30\u002D1 = selector = (System.Func<DataRow, ProducerContact>) ([SpecialName] (dr) => new ProducerContact(dr.Field<Guid>("ProducerContactGuid")));
        }
        producerContactList = source3.Select<DataRow, ProducerContact>(selector).ToList<ProducerContact>();
      }
      try
      {
        foreach (ProducerContact entity in producerContactList)
        {
          try
          {
            OfacSystem.Instance.CheckOfac<ProducerContact>(entity);
          }
          catch (Exception ex1)
          {
            ProjectData.SetProjectError(ex1);
            Exception ex2 = ex1;
            ex2.Data.Add((object) "ProducerContactGUID", (object) entity.ProducerContactGuid);
            ErrorHandler.SilentHandleError(ex2);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        List<ProducerContact>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  internal static T ResolveSetting<T>(string settingName, T defaultValue)
  {
    if (string.IsNullOrWhiteSpace(settingName))
      throw new ArgumentException(nameof (settingName));
    string name = $"{settingName}.Override";
    Preferences.AddRuntimeDefinedPreferenceDefault(name, (object) defaultValue);
    T preference = (T) Preferences.GetPreference(name);
    return !NotifyProxyTypeManager.Compare<T>(preference, defaultValue) ? MGASystems.Common.Settings.SystemSettings.GetSetting<T>(settingName, defaultValue) : preference;
  }

  private static void CloseAllWindows()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      mdiChildren[index].Close();
      checked { ++index; }
    }
  }

  private void CreateNotesReminder()
  {
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string empty = string.Empty;
    DateTime serverTime = CurrentUser.ServerTime;
    List<Guid> guidList = new List<Guid>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spGetUsersNoteNotification", new object[2]
    {
      (object) "@userGUID",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataTable.Rows.Count <= 0)
      return;
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        guidList.Clear();
        if (row["UserReceivingNote"] != null && row["UserReceivingNote"] != DBNull.Value)
        {
          guidList.Add((Guid) row["UserReceivingNote"]);
          Note_System.Instance.NonInteractive.CreateNote(-1, "Client License Expiration", CurrentUser.Instance.UserGUID, $"License # {row["LicenseNumber"].ToString()} with state ID '{row["StateID"].ToString()}' expires on {row["Expires"].ToString()}", false, guidList.ToArray());
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private static ButtonTool AddTool(
    UltraToolbarsManager menu,
    string topLevelMenuKey,
    string toolKey,
    string toolCaption,
    Image toolImage,
    int? toolIndex = null)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    if (string.IsNullOrEmpty(topLevelMenuKey))
      throw new ArgumentNullException(nameof (topLevelMenuKey));
    if (string.IsNullOrEmpty(toolKey))
      throw new ArgumentNullException(nameof (toolKey));
    if (string.IsNullOrEmpty(toolCaption))
      throw new ArgumentNullException(nameof (toolCaption));
    PopupMenuTool tool = ((ToolsCollectionBase) menu.Tools).Exists(topLevelMenuKey) ? ((ToolsCollectionBase) menu.Tools)[topLevelMenuKey] as PopupMenuTool : (PopupMenuTool) null;
    if (tool != null)
    {
      if (!((ToolsCollectionBase) menu.Tools).Exists(toolKey))
      {
        ButtonTool buttonTool = new ButtonTool(toolKey);
        ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = toolCaption;
        if (toolImage != null)
        {
          ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) toolImage;
          ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) toolImage;
        }
        menu.Tools.Add((ToolBase) buttonTool);
      }
      if (!((ToolsCollectionBase) tool.Tools).Exists(toolKey))
      {
        if (!toolIndex.HasValue)
          tool.Tools.AddTool(toolKey);
        else
          tool.Tools.InsertTool(toolIndex.Value, toolKey);
      }
    }
    return !((ToolsCollectionBase) menu.Tools).Exists(toolKey) ? (ButtonTool) null : ((ToolsCollectionBase) menu.Tools)[toolKey] as ButtonTool;
  }

  private Form ActiveMDIChild => MDIControls.Instance.MDIParent.ActiveMdiChild;

  private void SetupMenus(MenuManager.SetupMenusArgs e)
  {
    if (this._menu == null)
      return;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Invoice Lookup"))
      ((ToolsCollectionBase) this._menu.Tools)["Invoice Lookup"].SharedProps.Visible = e.CanViewInvoiceLookup;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Documents"))
      ((ToolsCollectionBase) this._menu.Tools)["Documents"].SharedProps.Visible = e.canViewDocumentsMenuAdmin;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("IMS Tasks"))
      ((ToolsCollectionBase) this._menu.Tools)["IMS Tasks"].SharedProps.Visible = e.CanViewImsTasks;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Security"))
      ((ToolsCollectionBase) this._menu.Tools)["Security"].SharedProps.Visible = e.CanViewSecurity;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("DocumentTransfer"))
      ((ToolsCollectionBase) this._menu.Tools)["DocumentTransfer"].SharedProps.Visible = e.CanViewDocumentTransfer;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Preferences"))
      ((ToolsCollectionBase) this._menu.Tools)["Preferences"].SharedProps.Visible = e.CanViewPreferences;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("View Transaction Log"))
      ((ToolsCollectionBase) this._menu.Tools)["View Transaction Log"].SharedProps.Visible = e.CanViewTransactionLog;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Live View..."))
      ((ToolsCollectionBase) this._menu.Tools)["Live View..."].SharedProps.Visible = e.CanViewLiveView;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("NewCompany"))
      ((ToolsCollectionBase) this._menu.Tools)["NewCompany"].SharedProps.Visible = e.CanViewNewCompany;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("NewInsured"))
      ((ToolsCollectionBase) this._menu.Tools)["NewInsured"].SharedProps.Visible = e.CanViewNewInsured;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Update CD Key"))
      ((ToolsCollectionBase) this._menu.Tools)["Update CD Key"].SharedProps.Visible = e.CanViewUpdateCDKey;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Requirements"))
      ((ToolsCollectionBase) this._menu.Tools)["Requirements"].SharedProps.Enabled = e.CanViewProducerRequirements;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Producer Blocking"))
      ((ToolsCollectionBase) this._menu.Tools)["Producer Blocking"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{5F6E8DB8-1D58-4453-B1D9-77D0F70A1BE1}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Process Unverified Insureds"))
      ((ToolsCollectionBase) this._menu.Tools)["Process Unverified Insureds"].SharedProps.Visible = CurrentUser.IsMGADeveloper || SecurityManager.Instance.AssertPermission("{F692417B-B22C-4331-AF11-CEA82AF6C196}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Process Unverified Producer Contacts"))
      ((ToolsCollectionBase) this._menu.Tools)["Process Unverified Producer Contacts"].SharedProps.Visible = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.ProducerContact.AllowSearch") && CurrentUser.IsMGADeveloper || SecurityManager.Instance.AssertPermission("{7DF23842-70D3-4C29-9379-C8352F9EEA9F}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("In-house Producer / Producer Assignment"))
      ((ToolsCollectionBase) this._menu.Tools)["In-house Producer / Producer Assignment"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{132EC678-9B93-4D2C-809B-58F89816448C}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Additional Interest"))
      ((ToolsCollectionBase) this._menu.Tools)["Additional Interest"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{8C52FBE5-78E4-473A-97AE-144E09D29D81}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Admin_TaxableCity"))
      ((ToolsCollectionBase) this._menu.Tools)["Admin_TaxableCity"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{6FFE5763-D88C-49C8-A621-4333239BAAC9}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Admin_ExcelRatingManagement"))
      ((ToolsCollectionBase) this._menu.Tools)["Admin_ExcelRatingManagement"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{F320184A-1FB0-4404-87DC-5B1E27A3D20D}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Admin_UserTagRatingManagement"))
      ((ToolsCollectionBase) this._menu.Tools)["Admin_UserTagRatingManagement"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{9B2FE990-A052-4AFB-938A-E780E8290359}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("show_adhoc_manager"))
      ((ToolsCollectionBase) this._menu.Tools)["show_adhoc_manager"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{14C52BE3-EB68-4380-A696-747FBDE979E9}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Note System"))
      ((ToolsCollectionBase) this._menu.Tools)["Note System"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{9CEE7E6F-682C-4565-9BEB-23500957E937}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Location Source"))
      ((ToolsCollectionBase) this._menu.Tools)["Location Source"].SharedProps.Enabled = e.CanViewProducerRequirements;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Status Change Reason List Source"))
      ((ToolsCollectionBase) this._menu.Tools)["Status Change Reason List Source"].SharedProps.Enabled = e.CanViewProducerRequirements;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Intermediaries"))
      ((ToolsCollectionBase) this._menu.Tools)["Intermediaries"].SharedProps.Visible = e.CanViewIntermediariesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Program Codes"))
      ((ToolsCollectionBase) this._menu.Tools)["Program Codes"].SharedProps.Visible = e.CanViewProgramCodesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Filing Automation"))
      ((ToolsCollectionBase) this._menu.Tools)["Filing Automation"].SharedProps.Visible = e.CanViewFilingAutomationForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("User Groups"))
      ((ToolsCollectionBase) this._menu.Tools)["User Groups"].SharedProps.Visible = e.CanViewUserGroupsForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Company Hierarchy"))
      ((ToolsCollectionBase) this._menu.Tools)["Company Hierarchy"].SharedProps.Visible = e.CanViewCompanyHierarchyForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Company Groups"))
      ((ToolsCollectionBase) this._menu.Tools)["Company Groups"].SharedProps.Visible = e.CanViewCompanyGroupForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Administration_Locations_OfficeLocations"))
      ((ToolsCollectionBase) this._menu.Tools)["Administration_Locations_OfficeLocations"].SharedProps.Visible = e.CanViewOfficeLocationsForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Conditions"))
      ((ToolsCollectionBase) this._menu.Tools)["Conditions"].SharedProps.Visible = e.CanViewConditionsForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Policy Forms"))
      ((ToolsCollectionBase) this._menu.Tools)["Policy Forms"].SharedProps.Visible = e.CanViewPolicyForms;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Warranties"))
      ((ToolsCollectionBase) this._menu.Tools)["Warranties"].SharedProps.Visible = e.CanViewWarrantiesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("BulkEmail"))
      ((ToolsCollectionBase) this._menu.Tools)["BulkEmail"].SharedProps.Visible = e.CanViewBulkEmailForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Business_Lines"))
      ((ToolsCollectionBase) this._menu.Tools)["Business_Lines"].SharedProps.Visible = e.CanViewLinesOfBusinessForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Third-Party Payees"))
      ((ToolsCollectionBase) this._menu.Tools)["Third-Party Payees"].SharedProps.Visible = e.CanViewFinanceCompaniesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Inspection Companies"))
      ((ToolsCollectionBase) this._menu.Tools)["Inspection Companies"].SharedProps.Visible = e.CanViewFinanceCompaniesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Finance Companies"))
      ((ToolsCollectionBase) this._menu.Tools)["Finance Companies"].SharedProps.Visible = e.CanViewFinanceCompaniesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Policy Classes"))
      ((ToolsCollectionBase) this._menu.Tools)["Policy Classes"].SharedProps.Visible = e.CanViewPolicyClassesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Policy_Charges"))
      ((ToolsCollectionBase) this._menu.Tools)["Policy_Charges"].SharedProps.Visible = e.CanViewPolicyChargesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Fee Automation"))
      ((ToolsCollectionBase) this._menu.Tools)["Fee Automation"].SharedProps.Visible = e.CanViewFeeAutomationForm && SecurityManager.Instance.AssertPermission("{EAC9FCD2-5E89-4A99-AB65-9AA8BEA9D9C0}");
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Business Types"))
      ((ToolsCollectionBase) this._menu.Tools)["Business Types"].SharedProps.Visible = e.CanViewBusinessTypesForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Administration_Policy_PolNum"))
      ((ToolsCollectionBase) this._menu.Tools)["Administration_Policy_PolNum"].SharedProps.Visible = e.CanViewPolicyNumberAdministration;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Contact Management"))
      ((ToolsCollectionBase) this._menu.Tools)["Contact Management"].SharedProps.Visible = e.CanViewContactManagementForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("View Users' Status"))
      ((ToolsCollectionBase) this._menu.Tools)["View Users' Status"].SharedProps.Visible = e.CanViewUserStatusForm;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("globalNotesAdmin"))
      ((ToolsCollectionBase) this._menu.Tools)["globalNotesAdmin"].SharedProps.Visible = e.CanAccessGlobalNotesAdmin;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Administration"))
      ((ToolsCollectionBase) this._menu.Tools)["Administration"].SharedProps.Visible = e.CanAccessAdministrationMenu;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("View_Company"))
      ((ToolsCollectionBase) this._menu.Tools)["View_Company"].SharedProps.Visible = e.CanViewCompaniesMenu;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("View_Insured"))
      ((ToolsCollectionBase) this._menu.Tools)["View_Insured"].SharedProps.Visible = e.CanViewInsuredsMenu;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("View_Producers"))
      ((ToolsCollectionBase) this._menu.Tools)["View_Producers"].SharedProps.Visible = e.CanViewProducersMenu;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("DocumentNaming"))
      ((ToolsCollectionBase) this._menu.Tools)["DocumentNaming"].SharedProps.Visible = e.CanViewDocumentNaming;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Region Source"))
      ((ToolsCollectionBase) this._menu.Tools)["Region Source"].SharedProps.Enabled = e.CanViewProducerRequirements;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("Import/Export Forms"))
      ((ToolsCollectionBase) this._menu.Tools)["Import/Export Forms"].SharedProps.Visible = false;
    if (((ToolsCollectionBase) this._menu.Tools).Exists("View_OFACClearance"))
      ((ToolsCollectionBase) this._menu.Tools)["View_OFACClearance"].SharedProps.Visible = e.CanViewOfacClearanceDashboard;
    if (!((ToolsCollectionBase) this._menu.Tools).Exists("Admin_ServiceEmailSettings"))
      return;
    ((ToolsCollectionBase) this._menu.Tools)["Admin_ServiceEmailSettings"].SharedProps.Visible = e.CanViewServiceEmailSettings;
  }

  private void SetupMenusThread()
  {
    try
    {
      bool viewLiveView = true;
      int num = SecurityManager.Instance.AssertPermission("{2CEBA04E-09F1-4be1-8947-1E4833F4D582}") ? 1 : 0;
      bool flag1 = SecurityManager.Instance.AssertPermission("{DE866387-0A83-4d8f-819E-098176722732}");
      bool flag2 = SecurityManager.Instance.AssertPermission("{8a4a85df-d47c-4854-8c75-d33ec88099b9}\r\n");
      bool viewAdministrationMenu = SecurityManager.Instance.AssertPermission("{854B2ED6-647B-4f06-B5D3-EA1DE27707A7}");
      bool viewDocumentsMenuAdmin = SecurityManager.Instance.AssertPermission("{93a12564-00b6-4485-ad57-6677ae982d4f}");
      if (num == 0 && !flag1 && !flag2)
        viewLiveView = false;
      this._menuArgs = new MenuManager.SetupMenusArgs(SecurityManager.Instance.AssertPermission("{D5A2E8B0-D9F9-44a4-AF36-750155971C43}"), viewDocumentsMenuAdmin, SecurityManager.Instance.AssertPermission("{AE6E189D-AE09-4a2d-8107-E900EF75FB28}"), SecurityManager.Instance.AssertPermission("{FB48ED71-E202-4bfc-9111-8DAC4DDCAEB2}"), SecurityManager.Instance.AssertPermission("{70010C9D-E3EB-4541-8D49-91D96DC07A5D}"), SecurityManager.Instance.AssertPermission("{4CFAA8DA-73F9-41b9-BA6E-E03972211D63}"), SecurityManager.Instance.AssertPermission("{12D7A665-2B74-4c5a-86ED-5F79DBCAFC44}"), SecurityManager.Instance.AssertPermission("{C266F1AF-4856-4647-BC41-CE2D40D5E294}"), SecurityManager.Instance.AssertPermission("{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}"), viewLiveView, SecurityManager.Instance.AssertPermission("{1BEAB417-AD16-41c0-984F-0A6660131697}"), SecurityManager.Instance.AssertPermission("{31986E19-AE7B-448f-A898-EE86A9CB71AA}"), SecurityManager.Instance.AssertPermission("{167C34C4-5E8F-4ce2-860B-76B8AAC20435}"), SecurityManager.Instance.AssertPermission("{7D1478EF-0434-4cae-B267-C2B171302048}"), SecurityManager.Instance.AssertPermission("{28A8E319-226F-458d-A843-418A814E6761}"), SecurityManager.Instance.AssertPermission("{D3284C4B-FEA4-4312-8FC9-5A630BC40676}"), SecurityManager.Instance.AssertPermission("{6CE1A8D9-1130-4ed9-B01A-E9D9057A8110}"), SecurityManager.Instance.AssertPermission("{2511FCC6-2140-47a5-856E-C282891DAB4E}"), SecurityManager.Instance.AssertPermission("{E3666975-017A-4922-9065-B0AE45835E15}"), SecurityManager.Instance.AssertPermission("{B731F4DD-F449-4831-AFD4-7ADFCE099BE8}"), SecurityManager.Instance.AssertPermission("{0375E906-0641-4505-995E-02C400E706B5}"), SecurityManager.Instance.AssertPermission("{A76DA255-606F-4d6a-86C3-1070D69678E4}"), SecurityManager.Instance.AssertPermission("{4AF0ECFA-C082-486e-B9DC-71934BFA4F07}"), SecurityManager.Instance.AssertPermission("{CE762F49-74E0-49f5-BBB7-E71665330C05}"), SecurityManager.Instance.AssertPermission("{8104A3D1-241C-4108-A819-A7B7C9AA825F}"), SecurityManager.Instance.AssertPermission("{97BC8D33-FF47-44f8-83ED-A69F0A2D0B7F}"), SecurityManager.Instance.AssertPermission("{9AB9CC0E-9359-4005-9F6D-E11CAB9503D2}"), SecurityManager.Instance.AssertPermission("{667030DC-114D-41e5-882A-0C7BB7C46A0D}"), SecurityManager.Instance.AssertPermission("{B2D03DD8-3123-46e8-9A8F-0A750F2AFED0}"), SecurityManager.Instance.AssertPermission("{68CF4A63-0C7E-40ed-8C27-7F7551E8985C}"), SecurityManager.Instance.AssertPermission("{CA65B83E-4D53-4a9b-8195-813D8BD09B0D}"), SecurityManager.Instance.AssertPermission("{696B0409-970F-4993-8EB3-F5AD051BD0F4}"), SecurityManager.Instance.AssertPermission("{20FD3E39-4F89-435c-8A34-DDA629B0E35E}"), viewAdministrationMenu, SecurityManager.Instance.AssertPermission("{0686459C-80DE-4404-A113-387DEAF7EDAF}"), SecurityManager.Instance.AssertPermission("{D5F7957A-AAA8-49fa-9FC8-8B33032D6DA8}"), SecurityManager.Instance.AssertPermission("{F84D8084-A0FB-4d3c-9F9F-545CB3CC5374}"), SecurityManager.Instance.AssertPermission("{C3330283-1241-4905-B18E-E29C85BF49F8}") && MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableCustomDocumentNaming"), SecurityManager.Instance.AssertPermission("{AC076D9E-74DF-4A72-AF95-3B33C7A30D89}"), viewAdministrationMenu && SecurityManager.Instance.AssertPermission("{9464E4F2-EA4B-4B37-8FE9-9247F1C0B86B}") && MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("UserEmail.UseSystemEmail"));
      this.SetupMenus(this._menuArgs);
    }
    catch (DatabaseException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  [Serializable]
  public sealed class myPS : PrinterSettings
  {
  }

  private class SetupMenusArgs : EventArgs
  {
    public SetupMenusArgs(
      bool viewInvoiceLookup,
      bool viewDocumentsMenuAdmin,
      bool viewImsTasks,
      bool viewSecurity,
      bool viewDocTransfer,
      bool viewPreferences,
      bool viewTransLog,
      bool viewNewCompany,
      bool viewNewInsured,
      bool viewLiveView,
      bool viewUpdateCDKey,
      bool viewProducerRequirements,
      bool viewIntermediaries,
      bool viewProgramCodes,
      bool viewFilingAutomation,
      bool viewUserGroups,
      bool viewCompanyHierarchy,
      bool viewCompanygroup,
      bool viewOfficeLocations,
      bool viewConditions,
      bool viewPolicyForms,
      bool viewWarranties,
      bool viewBulkEmail,
      bool viewBusinessLines,
      bool viewFinanceCompanies,
      bool viewPolicyClasses,
      bool viewPolicyCharges,
      bool viewFeeAutomation,
      bool viewBusinessTypes,
      bool viewPolicyNumberAdmin,
      bool viewContactManagement,
      bool viewUserStatus,
      bool accessGlobalNotesAdmin,
      bool viewAdministrationMenu,
      bool viewCompanies,
      bool viewInsureds,
      bool viewProducers,
      bool viewDocumentNaming,
      bool viewOfacDashboard,
      bool viewServiceEmailSettings)
    {
      this.CanViewInvoiceLookup = viewInvoiceLookup;
      this.canViewDocumentsMenuAdmin = viewDocumentsMenuAdmin;
      this.CanViewImsTasks = viewImsTasks;
      this.CanViewSecurity = viewSecurity;
      this.CanViewDocumentTransfer = viewDocTransfer;
      this.CanViewPreferences = viewPreferences;
      this.CanViewTransactionLog = viewTransLog;
      this.CanViewNewCompany = viewNewCompany;
      this.CanViewNewInsured = viewNewInsured;
      this.CanViewLiveView = viewLiveView;
      this.CanViewUpdateCDKey = viewUpdateCDKey;
      this.CanViewProducerRequirements = viewProducerRequirements;
      this.CanViewIntermediariesForm = viewIntermediaries;
      this.CanViewProgramCodesForm = viewProgramCodes;
      this.CanViewFilingAutomationForm = viewFilingAutomation;
      this.CanViewUserGroupsForm = viewUserGroups;
      this.CanViewCompanyHierarchyForm = viewCompanyHierarchy;
      this.CanViewCompanyGroupForm = viewCompanygroup;
      this.CanViewOfficeLocationsForm = viewOfficeLocations;
      this.CanViewConditionsForm = viewConditions;
      this.CanViewPolicyForms = viewPolicyForms;
      this.CanViewWarrantiesForm = viewWarranties;
      this.CanViewBulkEmailForm = viewBulkEmail;
      this.CanViewLinesOfBusinessForm = viewBusinessLines;
      this.CanViewFinanceCompaniesForm = viewFinanceCompanies;
      this.CanViewPolicyClassesForm = viewPolicyClasses;
      this.CanViewPolicyChargesForm = viewPolicyCharges;
      this.CanViewFeeAutomationForm = viewFeeAutomation;
      this.CanViewBusinessTypesForm = viewBusinessTypes;
      this.CanViewPolicyNumberAdministration = viewPolicyNumberAdmin;
      this.CanViewContactManagementForm = viewContactManagement;
      this.CanViewUserStatusForm = viewUserStatus;
      this.CanAccessGlobalNotesAdmin = accessGlobalNotesAdmin;
      this.CanAccessAdministrationMenu = viewAdministrationMenu;
      this.CanViewCompaniesMenu = viewCompanies;
      this.CanViewInsuredsMenu = viewInsureds;
      this.CanViewProducersMenu = viewProducers;
      this.CanViewDocumentNaming = viewDocumentNaming;
      this.CanViewOfacClearanceDashboard = viewOfacDashboard;
      this.CanViewServiceEmailSettings = viewServiceEmailSettings;
    }

    public bool CanViewInvoiceLookup { get; }

    public bool canViewDocumentsMenuAdmin { get; }

    public bool CanViewImsTasks { get; }

    public bool CanViewSecurity { get; }

    public bool CanViewDocumentTransfer { get; }

    public bool CanViewPreferences { get; }

    public bool CanViewTransactionLog { get; }

    public bool CanViewNewCompany { get; }

    public bool CanViewNewInsured { get; }

    public bool CanViewLiveView { get; }

    public bool CanViewUpdateCDKey { get; }

    public bool CanViewProducerRequirements { get; }

    public bool CanViewIntermediariesForm { get; }

    public bool CanViewProgramCodesForm { get; }

    public bool CanViewFilingAutomationForm { get; }

    public bool CanViewUserGroupsForm { get; }

    public bool CanViewCompanyHierarchyForm { get; }

    public bool CanViewCompanyGroupForm { get; }

    public bool CanViewOfficeLocationsForm { get; }

    public bool CanViewConditionsForm { get; }

    public bool CanViewPolicyForms { get; }

    public bool CanViewWarrantiesForm { get; }

    public bool CanViewBulkEmailForm { get; }

    public bool CanViewLinesOfBusinessForm { get; }

    public bool CanViewFinanceCompaniesForm { get; }

    public bool CanViewPolicyClassesForm { get; }

    public bool CanViewPolicyChargesForm { get; }

    public bool CanViewFeeAutomationForm { get; }

    public bool CanViewBusinessTypesForm { get; }

    public bool CanViewPolicyNumberAdministration { get; }

    public bool CanViewContactManagementForm { get; }

    public bool CanViewUserStatusForm { get; }

    public bool CanAccessGlobalNotesAdmin { get; }

    public bool CanAccessAdministrationMenu { get; }

    public bool CanViewCompaniesMenu { get; }

    public bool CanViewInsuredsMenu { get; }

    public bool CanViewProducersMenu { get; }

    public bool CanViewDocumentNaming { get; }

    public bool CanViewOfacClearanceDashboard { get; }

    public bool CanViewServiceEmailSettings { get; }
  }
}
