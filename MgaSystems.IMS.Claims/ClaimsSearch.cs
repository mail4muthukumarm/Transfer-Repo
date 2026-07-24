// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimsSearch
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimsSearch : UserControlBase, IClaimsSearch
{
  private int _controlNumber;
  private IContainer components;
  private Label label1;
  private Label label2;
  private UltraToolbarsDockArea _ClaimsSearch_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _ClaimsSearch_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _ClaimsSearch_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _ClaimsSearch_Toolbars_Dock_Area_Bottom;
  protected dsClaimsSearch dsClaimsSearch1;
  protected MGATextBox textPolicyNumber;
  protected MGATextBox textInsuredName;
  protected MGATextBox textControlNumber;
  protected MGASimpleComboBox comboLines;
  protected MGASimpleComboBox comboCompanyLocations;
  protected MGASimpleComboBox comboAdjusterName;
  protected MGASimpleComboBox comboClaimStatus;
  protected MGATextBox textClaimantLastName;
  protected MGATextBox textClaimantFirstName;
  protected MGATextBox textClaimantSsnFein;
  protected MGATextBox textClaimNumber;
  protected MGADateTimePicker dateLossDateTo;
  protected MGADateTimePicker dateLossDateFrom;
  protected MGADateTimePicker dateTimeDateReportedTo;
  protected MGADateTimePicker dateTimeDateReportedFrom;
  protected MGATextBox textCheckNumber;
  protected MGATextBox textClaimantCorporationName;
  protected UltraToolbarsManager ultraToolbarsManager1;
  protected BindingSource linesBindingSource1;
  protected BindingSource dsLinesBindingSource;
  protected dsLines dsLines;
  protected BindingSource linesBindingSource;
  protected BindingSource companyLocationsBindingSource;
  protected dsCompanyLocations dsCompanyLocations;
  protected MGAGroupBox groupNewClaimSearch;
  protected internal MGAButton buttonSearch;
  protected internal MGAButton buttonCancel;
  protected internal Label label5;
  protected internal Label label6;
  protected internal Label label8;
  protected internal Label label15;
  protected internal Label label14;
  protected internal Label label13;
  protected internal Label label11;
  protected internal Label label12;
  protected internal Label label18;
  protected internal Label label19;
  protected internal Label label4;
  protected internal Label label7;
  protected internal Label label9;
  protected internal Label label10;
  protected internal Label label17;
  protected internal Label label16;
  protected internal Label label3;
  public PictureBox pictureCurtain;
  protected internal Label labelNoResults;
  protected UltraFormattedTextEditor lnkControlNo;
  protected UltraGrid gridSearchResults;
  protected MGADateTimePicker dateTimePolicyExpirationFrom;
  protected MGADateTimePicker dateTimePolicyEffectiveFrom;
  protected MGADateTimePicker dateTimePolicyExpirationTo;
  protected MGADateTimePicker dateTimePolicyEffectiveTo;
  protected Label labelPolicyEffective;
  protected Label labelPolicyExpiration;
  protected Label label22;
  protected Label label20;

  public ClaimsSearch()
  {
    this.InitializeComponent();
    ((UltraDateTimeEditor) this.dateLossDateFrom).Value = (object) DBNull.Value;
    ((UltraDateTimeEditor) this.dateLossDateTo).Value = (object) DBNull.Value;
    ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).Value = (object) DBNull.Value;
    ((UltraDateTimeEditor) this.dateTimeDateReportedTo).Value = (object) DBNull.Value;
  }

  public int ControlNumber => this._controlNumber;

  protected virtual void buttonSearch_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.labelNoResults.Visible = false;
      this.pictureCurtain.Image = (Image) Resources.Progress1;
      this.pictureCurtain.Visible = true;
      this.pictureCurtain.BringToFront();
      if (this.ValidateSearchCriteria())
      {
        if (Utility.IsAuditUser(CurrentUser.Instance.UserGUID))
          this.SearchClaims_AuditUser();
        else
          this.SearchClaims();
      }
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridSearchResults).Rows).Count == 0)
      {
        this.pictureCurtain.Image = (Image) Resources.NotFound;
        this.labelNoResults.Visible = true;
        this.labelNoResults.BringToFront();
      }
      else
        this.pictureCurtain.Visible = false;
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private bool ValidateSearchCriteria()
  {
    if (!string.IsNullOrEmpty(((Control) this.textControlNumber).Text))
    {
      int result;
      int.TryParse(((Control) this.textControlNumber).Text, NumberStyles.Any, (IFormatProvider) null, out result);
      if (result == 0)
      {
        int num = (int) MessageBox.Show(Resources.CLAIMSSEARCH_CONTROLNUMBER_ERROR1, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    if (!string.IsNullOrEmpty(((Control) this.textCheckNumber).Text))
    {
      int result;
      int.TryParse(((Control) this.textCheckNumber).Text, NumberStyles.Any, (IFormatProvider) null, out result);
      if (result == 0)
      {
        int num = (int) MessageBox.Show(Resources.CLAIMSSEARCH_CHECKNUMBER_ERROR1, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    if (((UltraDateTimeEditor) this.dateLossDateFrom).IsDateValid && !((UltraDateTimeEditor) this.dateLossDateTo).IsDateValid || !((UltraDateTimeEditor) this.dateLossDateFrom).IsDateValid && ((UltraDateTimeEditor) this.dateLossDateTo).IsDateValid)
    {
      int num = (int) MessageBox.Show(Resources.CLAIMSSEARCH_LOSSDATE_ERROR1, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDateTimeEditor) this.dateLossDateFrom).IsDateValid && ((UltraDateTimeEditor) this.dateLossDateTo).IsDateValid && !(((UltraDateTimeEditor) this.dateLossDateFrom).DateTime <= ((UltraDateTimeEditor) this.dateLossDateTo).DateTime))
    {
      int num = (int) MessageBox.Show(Resources.CLAIMSSEARCH_LOSSDATE_ERROR2, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    object obj1 = ((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).Value;
    object obj2 = ((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).Value;
    if ((obj1 != null || obj2 != null) && (obj1 == null || obj2 == null))
    {
      int num = (int) MessageBox.Show("You must specify both a starting policy effective date and an ending policy effective date to continue.", Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (obj2 != null && obj1 != null && ((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).DateTime > ((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).DateTime)
    {
      int num = (int) MessageBox.Show("The policy effective date to cannot be less than the policy date effective from.", Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    object obj3 = ((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).Value;
    object obj4 = ((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).Value;
    if ((obj3 != null || obj4 != null) && (obj3 == null || obj4 == null))
    {
      int num = (int) MessageBox.Show("You must specify both a starting policy expiration date and an ending policy expiration date to continue.", Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (obj4 == null || obj3 == null || !(((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).DateTime > ((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).DateTime))
      return true;
    int num1 = (int) MessageBox.Show("The policy expiration date to cannot be less than the policy date expiration from.", Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual void SearchClaims()
  {
    this.dsClaimsSearch1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsClaimsSearch1, new string[2]
    {
      "PolicyInformation",
      "ClaimsInformation"
    }, "spClaims_ClaimsSearch", new object[44]
    {
      (object) "@controlNo",
      (object) (string.IsNullOrEmpty(((Control) this.textControlNumber).Text) ? SqlInt32.Null : (SqlInt32) int.Parse(((Control) this.textControlNumber).Text)),
      (object) "@policyNumber",
      (object) (string.IsNullOrEmpty(((Control) this.textPolicyNumber).Text) ? SqlString.Null : (SqlString) ((Control) this.textPolicyNumber).Text),
      (object) "@insuredName",
      (object) (string.IsNullOrEmpty(((Control) this.textInsuredName).Text) ? SqlString.Null : (SqlString) ((Control) this.textInsuredName).Text),
      (object) "@companyLocationGuid",
      ((UltraDropDownBase) this.comboCompanyLocations).SelectedRow == null ? (object) SqlGuid.Null : ((UltraCombo) this.comboCompanyLocations).Value,
      (object) "@lineGuid",
      ((UltraDropDownBase) this.comboLines).SelectedRow == null ? (object) SqlGuid.Null : ((UltraCombo) this.comboLines).Value,
      (object) "@claimNumber",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimNumber).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimNumber).Text.Trim()),
      (object) "@claimantSsnFein",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantSsnFein).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantSsnFein).Text),
      (object) "@claimantLastName",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantLastName).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantLastName).Text),
      (object) "@claimantFirstName",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantFirstName).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantFirstName).Text),
      (object) "@lossDateFrom",
      (object) (((UltraDateTimeEditor) this.dateLossDateFrom).Value == null || !((UltraDateTimeEditor) this.dateLossDateFrom).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateLossDateFrom).DateTime),
      (object) "@lossDateTo",
      (object) (((UltraDateTimeEditor) this.dateLossDateTo).Value == null || !((UltraDateTimeEditor) this.dateLossDateTo).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateLossDateTo).DateTime),
      (object) "@datereportedfrom",
      (object) (((UltraDateTimeEditor) this.dateTimeDateReportedFrom).Value == null || !((UltraDateTimeEditor) this.dateTimeDateReportedFrom).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).DateTime),
      (object) "@datereportedto",
      (object) (((UltraDateTimeEditor) this.dateTimeDateReportedTo).Value == null || !((UltraDateTimeEditor) this.dateTimeDateReportedTo).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateTimeDateReportedTo).DateTime),
      (object) "@adjusterGuid",
      ((UltraDropDownBase) this.comboAdjusterName).SelectedRow == null ? (object) SqlGuid.Null : ((UltraCombo) this.comboAdjusterName).Value,
      (object) "@claimStatus",
      ((UltraDropDownBase) this.comboClaimStatus).SelectedRow == null ? (object) SqlInt32.Null : ((UltraCombo) this.comboClaimStatus).Value,
      (object) "@checkNumber",
      (object) (string.IsNullOrEmpty(((Control) this.textCheckNumber).Text) ? SqlInt32.Null : (SqlInt32) int.Parse(((Control) this.textCheckNumber).Text)),
      (object) "@UserId",
      (object) CurrentUser.Instance.UserID,
      (object) "@corporationName",
      (object) (string.IsNullOrEmpty(((Control) this.textClaimantCorporationName).Text) ? SqlString.Null : (SqlString) ((Control) this.textClaimantCorporationName).Text),
      (object) "@policyEffectiveFrom",
      (object) (((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).Value == null || !((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).DateTime),
      (object) "@policyEffectiveTo",
      (object) (((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).Value == null || !((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).DateTime),
      (object) "@policyExpirationFrom",
      (object) (((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).Value == null || !((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).DateTime),
      (object) "@policyExpirationTo",
      (object) (((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).Value == null || !((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).IsDateValid ? SqlDateTime.Null : (SqlDateTime) ((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).DateTime)
    });
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Load(((UltraGridBase) this.gridSearchResults).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    this.FormatGrid();
  }

  protected virtual void SearchClaims_AuditUser()
  {
    this.dsClaimsSearch1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsClaimsSearch1, new string[2]
    {
      "PolicyInformation",
      "ClaimsInformation"
    }, "spClaims_ClaimsSearch_Audit", new object[2]
    {
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Load(((UltraGridBase) this.gridSearchResults).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    this.FormatGrid();
  }

  private void gridSearchResults_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index == 0 || !((KeyedSubObjectsCollectionBase) e.Row.Cells).Exists("locked") || e.Row.Cells["locked"].Value == DBNull.Value)
      return;
    if ((bool) e.Row.Cells["locked"].Value)
      e.Row.Cells["lockImage"].Value = (object) Resources.CloseClaim;
    else
      e.Row.Cells["lockImage"].Value = (object) Resources.ReopenClaim;
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ADD":
        if (!SecurityManager.Instance.AssertPermission("{4FC4C027-7466-4499-AEE4-E9160E605315}"))
        {
          int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.AddNew();
        break;
      case "VIEW":
        this.ViewClaims();
        break;
      case "OPENCLAIM":
        this.OpenClaim();
        break;
      case "DELETECLAIM":
        if (!SecurityManager.Instance.AssertPermission("{E0F4F16E-5F28-48df-9DA9-ACC8212F2F9C}"))
        {
          int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.DeleteClaim();
        break;
      case "MOVE":
        if (!SecurityManager.Instance.AssertPermission("{DDD3A87E-425C-4f1f-BA8E-659AEE694792}"))
        {
          int num = (int) MessageBox.Show("You do not have rights to perform this task.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.MoveClaim();
        break;
    }
  }

  protected virtual void ultraToolbarsManager1_BeforeToolDropdownExtended(UltraGridRow row)
  {
  }

  public virtual void AddNew()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridSearchResults).Rows).Count == 0 || ((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0 || ((UltraGridBase) this.gridSearchResults).ActiveRow == null)
      return;
    FormClaims form;
    if (((GridItemBase) ((UltraGridBase) this.gridSearchResults).ActiveRow).Band.ParentBand == null)
    {
      this._controlNumber = (int) ((UltraGridBase) this.gridSearchResults).ActiveRow.Cells["ControlNumber"].Value;
      form = ObjectFactory.Instance.CreateForm(typeof (FormClaims), new object[1]
      {
        (object) this._controlNumber
      }) as FormClaims;
    }
    else
      form = ObjectFactory.Instance.CreateForm(typeof (FormClaims), new object[1]
      {
        (object) (int) ((UltraGridBase) this.gridSearchResults).ActiveRow.ParentRow.Cells["ControlNumber"].Value
      }) as FormClaims;
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  internal void ViewClaims()
  {
    if (((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridSearchResults.Selected.Rows[0];
    if (((GridItemBase) row).Band.Index != 0 || (int) row.Cells[this.dsClaimsSearch1.PolicyInformation.NumberOfClaimsColumn.ColumnName].Value == 0)
      return;
    row.ExpandAll();
  }

  private void MoveClaim()
  {
    if (((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridSearchResults.Selected.Rows[0];
    if (((GridItemBase) row).Band.Index != 1)
    {
      this.MoveClaim_Extended(row);
    }
    else
    {
      FormMoveClaim objectAs = ObjectFactory.Instance.CreateObjectAs<FormMoveClaim>((object) (int) row.Cells[this.dsClaimsSearch1.ClaimsInformation.ClaimIdColumn.ColumnName].Value, (object) (int) row.Cells[this.dsClaimsSearch1.ClaimsInformation.ControlNumberColumn.ColumnName].Value, (object) (string) row.Cells[this.dsClaimsSearch1.ClaimsInformation.ClaimNumberColumn.ColumnName].Value);
      using (objectAs)
      {
        if (objectAs.ShowDialog() != DialogResult.OK)
          return;
        this.ClearScreen();
      }
    }
  }

  public virtual void OpenClaim()
  {
    if (((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridSearchResults.Selected.Rows[0];
    this.Cursor = MgaCursors.Working;
    try
    {
      Claim claim = (Claim) ObjectFactory.Instance.CreateObject(typeof (Claim), new object[1]
      {
        (object) (int) row.Cells[this.dsClaimsSearch1.ClaimsInformation.ClaimIdColumn.ColumnName].Value
      });
      int? claimId = claim.ClaimId;
      if (Utility.IsClaimLocked(claimId.Value))
      {
        int num = (int) MessageBox.Show("The claim you are trying to open is in use by another user and cannot be opened at this time.", "Claim In Use!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        claimId = claim.ClaimId;
        if (claimId.HasValue)
        {
          claimId = claim.ClaimId;
          Utility.SetClaimLock(claimId.Value);
        }
        FormClaims form = ObjectFactory.Instance.CreateForm(typeof (FormClaims), new object[1]
        {
          (object) claim
        }) as FormClaims;
        form.MdiParent = MDIControls.Instance.MDIParent;
        form.Show();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  public virtual void DeleteClaim()
  {
    if (((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridSearchResults.Selected.Rows[0];
    if (((GridItemBase) row).Band.Index != 1)
      this.DeleteClaim_Extended(row);
    if (MessageBox.Show("This will permanently delete the claim record. This action cannot be undone. Are you sure you wish to continue?", "Permanently Delete Claims?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      Utility.DeleteClaim((int) row.Cells[this.dsClaimsSearch1.ClaimsInformation.ClaimIdColumn.ColumnName].Value);
      this.SearchClaims();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  protected virtual void DeleteClaim_Extended(UltraGridRow row)
  {
  }

  protected virtual void MoveClaim_Extended(UltraGridRow row)
  {
  }

  private void gridSearchResults_ClickCellButton(object sender, CellEventArgs e)
  {
    this.ViewClaims();
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (((SparseCollectionBase) this.gridSearchResults.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridSearchResults.Selected.Rows[0];
    ((ToolsCollectionBase) (((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["popupGridOptions"] as PopupMenuTool).Tools)["OPENCLAIM"].SharedProps.Visible = ((GridItemBase) row).Band.Index == 1;
    ((ToolsCollectionBase) (((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["popupGridOptions"] as PopupMenuTool).Tools)["DELETECLAIM"].SharedProps.Visible = ((GridItemBase) row).Band.Index == 1;
    ((ToolsCollectionBase) (((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["popupGridOptions"] as PopupMenuTool).Tools)["ADD"].SharedProps.Visible = ((GridItemBase) row).Band.Index == 0;
    ((ToolsCollectionBase) (((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["popupGridOptions"] as PopupMenuTool).Tools)["VIEW"].SharedProps.Visible = ((GridItemBase) row).Band.Index == 0 && (int) row.Cells["NumberOfClaims"].Value != 0;
    this.ultraToolbarsManager1_BeforeToolDropdownExtended(row);
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.ClearScreen();

  private void ClearScreen()
  {
    ((Control) this.textControlNumber).Text = string.Empty;
    ((Control) this.textPolicyNumber).Text = string.Empty;
    ((Control) this.textInsuredName).Text = string.Empty;
    ((Control) this.comboCompanyLocations).ResetText();
    ((Control) this.comboLines).ResetText();
    ((Control) this.textClaimNumber).Text = string.Empty;
    ((Control) this.textClaimantSsnFein).Text = string.Empty;
    ((Control) this.textClaimantFirstName).Text = string.Empty;
    ((Control) this.textClaimantLastName).Text = string.Empty;
    ((UltraDateTimeEditor) this.dateLossDateFrom).Value = (object) null;
    ((UltraDateTimeEditor) this.dateLossDateTo).Value = (object) null;
    this.dsClaimsSearch1.Clear();
    ((TextEditorControlBase) this.textControlNumber).Focus();
    ((Control) this.comboClaimStatus).ResetText();
    ((Control) this.comboAdjusterName).ResetText();
    ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).Value = (object) null;
    ((UltraDateTimeEditor) this.dateTimeDateReportedTo).Value = (object) null;
    ((Control) this.textClaimantCorporationName).Text = string.Empty;
    ((Control) this.textCheckNumber).Text = string.Empty;
    this.LoadLines();
    this.LoadCompanyLocations();
    this.LoadClaimStatuses();
    this.LoadUsers();
  }

  protected virtual void LoadLines()
  {
    this.dsLines.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsLines, new string[1]
    {
      "Lines"
    }, "spClaims_GetLines");
  }

  private void LoadCompanyLocations()
  {
    this.dsCompanyLocations.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsCompanyLocations, new string[1]
    {
      "CompanyLocations"
    }, "spClaims_GetCompanyLocations", new object[4]
    {
      (object) "@ShowAll",
      (object) 0,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  protected virtual void LoadUsers()
  {
    ((UltraGridBase) this.comboAdjusterName).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetInhouseAdjusters").Tables[0];
    ((UltraDropDownBase) this.comboAdjusterName).DisplayMember = "UserName";
    ((UltraDropDownBase) this.comboAdjusterName).ValueMember = "UserGuid";
  }

  private void LoadClaimStatuses()
  {
    ((UltraGridBase) this.comboClaimStatus).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetClaimStatuses").Tables[0];
    ((UltraDropDownBase) this.comboClaimStatus).DisplayMember = "Status";
    ((UltraDropDownBase) this.comboClaimStatus).ValueMember = "StatusId";
  }

  private void gridSearchResults_MouseDown(object sender, MouseEventArgs e)
  {
    object context = ((ControlUIElementBase) ((UltraGridBase) this.gridSearchResults).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow));
    if (context == null)
      return;
    ((Control) this.gridSearchResults).Focus();
    (context as UltraGridRow).Activate();
    ((GridItemBase) (context as UltraGridRow)).Selected = true;
  }

  private void gridSearchResults_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index != 1)
      return;
    this.OpenClaim();
  }

  private void ClaimsSearch_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Dock = DockStyle.Top;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["Move"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{DDD3A87E-425C-4f1f-BA8E-659AEE694792}");
    this.LoadLines();
    this.LoadCompanyLocations();
    this.LoadUsers();
    this.LoadClaimStatuses();
  }

  protected virtual void FormatGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridSearchResults).DisplayLayout.Bands[1];
    if (((KeyedSubObjectsCollectionBase) band.ColumnFilters).Exists("lockImage"))
    {
      ((HeaderBase) band.Columns["lockImage"].Header).Caption = string.Empty;
      band.Columns["lockImage"].Width = 20;
    }
    if (((KeyedSubObjectsCollectionBase) band.ColumnFilters).Exists("locked"))
      band.Columns["locked"].Hidden = true;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).Appearance.FontData.SizeInPoints = 8.5f;
    if (!SystemSettings.KeyExists("ClaimsShowPolicyLink") || !SystemSettings.GetBoolSetting("ClaimsShowPolicyLink"))
      return;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Bands[0].Columns[0].EditorComponent = (Component) this.lnkControlNo;
  }

  MGAButton IClaimsSearch.AcceptButton => this.buttonSearch;

  MGAButton IClaimsSearch.CancelButton => this.buttonCancel;

  UltraGrid IClaimsSearch.ResultsGrid => this.gridSearchResults;

  private void lnkControlNo_LinkClicked_1(object sender, LinkClickedEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{68F0B71D-DB74-4048-9D6C-86379996CFB2}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to perform this action.", "Insufficient Rights!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int result = 0;
      if (string.IsNullOrEmpty(e.LinkText) || !int.TryParse(e.LinkText, out result) || !Quote.ControlNumberExists(result))
        return;
      MGASystems.Common.FormSettings.ShowForm(typeof (frmPolicyDetail), (object) result);
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("PolicyInformation", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNumber");
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    Appearance appearance32 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Insured");
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Producer", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance34 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Company");
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Line");
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ViewClaims");
    Appearance appearance37 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ClaimsSearch));
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("NumberOfClaims");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("FK_PolicyInformation_ClaimsInformation");
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_PolicyInformation_ClaimsInformation", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ControlNumber");
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ClaimId");
    Appearance appearance40 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ClaimNumber");
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LossDate", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance42 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("EnteredBy");
    Appearance appearance43 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DateEntered");
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Claimants");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Adjuster");
    Appearance appearance45 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Locked");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LockImage");
    Appearance appearance46 = new Appearance();
    ColScrollRegion colScrollRegion1 = new ColScrollRegion(691);
    ColScrollRegion colScrollRegion2 = new ColScrollRegion(691);
    ColScrollRegion colScrollRegion3 = new ColScrollRegion(691);
    ColScrollRegion colScrollRegion4 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion5 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion6 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion7 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion8 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion9 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion10 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion11 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion12 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion13 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion14 = new ColScrollRegion(799);
    ColScrollRegion colScrollRegion15 = new ColScrollRegion(703);
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("BaseLayout");
    Appearance appearance55 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("PolicyInformation", -1);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ControlNumber");
    Appearance appearance56 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("PolicyNumber");
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Insured");
    Appearance appearance58 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Producer");
    Appearance appearance59 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Company");
    Appearance appearance60 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Line");
    Appearance appearance61 = new Appearance();
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ViewClaims");
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("NumberOfClaims");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("FK_PolicyInformation_ClaimsInformation");
    UltraGridBand ultraGridBand4 = new UltraGridBand("FK_PolicyInformation_ClaimsInformation", 0);
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ControlNumber");
    Appearance appearance64 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ClaimId");
    Appearance appearance65 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ClaimNumber");
    Appearance appearance66 = new Appearance();
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("LossDate");
    Appearance appearance67 = new Appearance();
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("EnteredBy");
    Appearance appearance68 = new Appearance();
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("DateEntered");
    Appearance appearance69 = new Appearance();
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Claimants");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Adjuster");
    Appearance appearance70 = new Appearance();
    ColScrollRegion colScrollRegion16 = new ColScrollRegion(691);
    ColScrollRegion colScrollRegion17 = new ColScrollRegion(703);
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("toolbarGridContext");
    ButtonTool buttonTool1 = new ButtonTool("ADD");
    ButtonTool buttonTool2 = new ButtonTool("ADD");
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    ButtonTool buttonTool3 = new ButtonTool("VIEW");
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("popupGridOptions");
    ButtonTool buttonTool4 = new ButtonTool("ADD");
    ButtonTool buttonTool5 = new ButtonTool("VIEW");
    ButtonTool buttonTool6 = new ButtonTool("OPENCLAIM");
    ButtonTool buttonTool7 = new ButtonTool("DELETECLAIM");
    ButtonTool buttonTool8 = new ButtonTool("MOVE");
    ButtonTool buttonTool9 = new ButtonTool("OPENCLAIM");
    Appearance appearance83 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("DELETECLAIM");
    Appearance appearance84 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("MOVE");
    Appearance appearance85 = new Appearance();
    this.lnkControlNo = new UltraFormattedTextEditor();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label15 = new Label();
    this.textClaimNumber = new MGATextBox();
    this.label14 = new Label();
    this.dateLossDateTo = new MGADateTimePicker();
    this.dateLossDateFrom = new MGADateTimePicker();
    this.label13 = new Label();
    this.label8 = new Label();
    this.textClaimantLastName = new MGATextBox();
    this.textClaimantSsnFein = new MGATextBox();
    this.textClaimantFirstName = new MGATextBox();
    this.label6 = new Label();
    this.label5 = new Label();
    this.groupNewClaimSearch = new MGAGroupBox();
    this.labelPolicyExpiration = new Label();
    this.label22 = new Label();
    this.dateTimePolicyExpirationTo = new MGADateTimePicker();
    this.label20 = new Label();
    this.dateTimePolicyEffectiveTo = new MGADateTimePicker();
    this.dateTimePolicyExpirationFrom = new MGADateTimePicker();
    this.dateTimePolicyEffectiveFrom = new MGADateTimePicker();
    this.labelPolicyEffective = new Label();
    this.textClaimantCorporationName = new MGATextBox();
    this.label19 = new Label();
    this.label18 = new Label();
    this.textCheckNumber = new MGATextBox();
    this.label11 = new Label();
    this.comboAdjusterName = new MGASimpleComboBox();
    this.dateTimeDateReportedTo = new MGADateTimePicker();
    this.dateTimeDateReportedFrom = new MGADateTimePicker();
    this.label17 = new Label();
    this.label12 = new Label();
    this.comboClaimStatus = new MGASimpleComboBox();
    this.label16 = new Label();
    this.buttonSearch = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.comboLines = new MGASimpleComboBox();
    this.linesBindingSource1 = new BindingSource(this.components);
    this.dsLinesBindingSource = new BindingSource(this.components);
    this.dsLines = new dsLines();
    this.comboCompanyLocations = new MGASimpleComboBox();
    this.companyLocationsBindingSource = new BindingSource(this.components);
    this.dsCompanyLocations = new dsCompanyLocations();
    this.textControlNumber = new MGATextBox();
    this.label10 = new Label();
    this.label3 = new Label();
    this.textInsuredName = new MGATextBox();
    this.label4 = new Label();
    this.textPolicyNumber = new MGATextBox();
    this.label9 = new Label();
    this.label7 = new Label();
    this.pictureCurtain = new PictureBox();
    this.labelNoResults = new Label();
    this.linesBindingSource = new BindingSource(this.components);
    this._ClaimsSearch_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.gridSearchResults = new UltraGrid();
    this.dsClaimsSearch1 = new dsClaimsSearch();
    this._ClaimsSearch_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._ClaimsSearch_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._ClaimsSearch_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    ((ISupportInitialize) this.textClaimNumber).BeginInit();
    ((ISupportInitialize) this.dateLossDateTo).BeginInit();
    ((ISupportInitialize) this.dateLossDateFrom).BeginInit();
    ((ISupportInitialize) this.textClaimantLastName).BeginInit();
    ((ISupportInitialize) this.textClaimantSsnFein).BeginInit();
    ((ISupportInitialize) this.textClaimantFirstName).BeginInit();
    ((ISupportInitialize) this.groupNewClaimSearch).BeginInit();
    ((Control) this.groupNewClaimSearch).SuspendLayout();
    ((ISupportInitialize) this.dateTimePolicyExpirationTo).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveTo).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyExpirationFrom).BeginInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveFrom).BeginInit();
    ((ISupportInitialize) this.textClaimantCorporationName).BeginInit();
    ((ISupportInitialize) this.textCheckNumber).BeginInit();
    ((ISupportInitialize) this.comboAdjusterName).BeginInit();
    ((ISupportInitialize) this.dateTimeDateReportedTo).BeginInit();
    ((ISupportInitialize) this.dateTimeDateReportedFrom).BeginInit();
    ((ISupportInitialize) this.comboClaimStatus).BeginInit();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.comboLines).BeginInit();
    ((ISupportInitialize) this.linesBindingSource1).BeginInit();
    ((ISupportInitialize) this.dsLinesBindingSource).BeginInit();
    this.dsLines.BeginInit();
    ((ISupportInitialize) this.comboCompanyLocations).BeginInit();
    ((ISupportInitialize) this.companyLocationsBindingSource).BeginInit();
    this.dsCompanyLocations.BeginInit();
    ((ISupportInitialize) this.textControlNumber).BeginInit();
    ((ISupportInitialize) this.textInsuredName).BeginInit();
    ((ISupportInitialize) this.textPolicyNumber).BeginInit();
    ((ISupportInitialize) this.pictureCurtain).BeginInit();
    ((ISupportInitialize) this.linesBindingSource).BeginInit();
    ((ISupportInitialize) this.gridSearchResults).BeginInit();
    this.dsClaimsSearch1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.lnkControlNo).Location = new Point(50, 350);
    ((Control) this.lnkControlNo).Name = "lnkControlNo";
    ((Control) this.lnkControlNo).Size = new Size(72, 23);
    ((Control) this.lnkControlNo).TabIndex = 4;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).TreatValueAs = (TreatValueAs) 2;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).Value = (object) "controlno";
    ((Control) this.lnkControlNo).Visible = false;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).LinkClicked += new LinkClickedEventHandler(this.lnkControlNo_LinkClicked_1);
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(25, 1);
    this.label1.Name = "label1";
    this.label1.Size = new Size(168, 33);
    this.label1.TabIndex = 0;
    this.label1.Text = "Claim Search";
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Location = new Point(32 /*0x20*/, 33);
    this.label2.Name = "label2";
    this.label2.Size = new Size(692, 1);
    this.label2.TabIndex = 1;
    this.label2.Text = "label2";
    this.label15.AutoSize = true;
    this.label15.BackColor = Color.Transparent;
    this.label15.Location = new Point(330, 29);
    this.label15.Name = "label15";
    this.label15.Size = new Size(76, 13);
    this.label15.TabIndex = 22;
    this.label15.Text = "Claim Number:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textClaimNumber).BackColor = Color.White;
    ((Control) this.textClaimNumber).Location = new Point(435, 29);
    this.textClaimNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimNumber).Name = "textClaimNumber";
    ((Control) this.textClaimNumber).Size = new Size(146, 20);
    ((Control) this.textClaimNumber).TabIndex = 23;
    ((UltraControlBase) this.textClaimNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.label14.AutoSize = true;
    this.label14.BackColor = Color.Transparent;
    this.label14.Location = new Point(533, 139);
    this.label14.Name = "label14";
    this.label14.Size = new Size(19, 13);
    this.label14.TabIndex = 34;
    this.label14.Text = "To";
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateLossDateTo).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance3).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance3).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateLossDateTo).ButtonAppearance = (AppearanceBase) appearance3;
    ((UltraDateTimeEditor) this.dateLossDateTo).DateTime = new DateTime(2011, 1, 24, 0, 0, 0, 0);
    ((Control) this.dateLossDateTo).Location = new Point(563, 135);
    this.dateLossDateTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateLossDateTo).Name = "dateLossDateTo";
    ((Control) this.dateLossDateTo).Size = new Size(86, 20);
    ((Control) this.dateLossDateTo).TabIndex = 35;
    ((UltraControlBase) this.dateLossDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateLossDateTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateLossDateTo).Value = (object) new DateTime(2011, 1, 24, 0, 0, 0, 0);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateLossDateFrom).Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance5).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance5).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance5).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance5).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateLossDateFrom).ButtonAppearance = (AppearanceBase) appearance5;
    ((UltraDateTimeEditor) this.dateLossDateFrom).DateTime = new DateTime(2011, 1, 24, 0, 0, 0, 0);
    ((Control) this.dateLossDateFrom).Location = new Point(435, 136);
    this.dateLossDateFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateLossDateFrom).Name = "dateLossDateFrom";
    ((Control) this.dateLossDateFrom).Size = new Size(86, 20);
    ((Control) this.dateLossDateFrom).TabIndex = 33;
    ((UltraControlBase) this.dateLossDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateLossDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateLossDateFrom).Value = (object) new DateTime(2011, 1, 24, 0, 0, 0, 0);
    this.label13.AutoSize = true;
    this.label13.BackColor = Color.Transparent;
    this.label13.Location = new Point(330, 136);
    this.label13.Name = "label13";
    this.label13.Size = new Size(58, 13);
    this.label13.TabIndex = 32 /*0x20*/;
    this.label13.Text = "Loss Date:";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Location = new Point(330, 50);
    this.label8.Name = "label8";
    this.label8.Size = new Size(101, 13);
    this.label8.TabIndex = 24;
    this.label8.Text = "Claimant SSN/FEIN:";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimantLastName).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textClaimantLastName).BackColor = Color.White;
    ((Control) this.textClaimantLastName).Location = new Point(435, 71);
    this.textClaimantLastName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimantLastName).Name = "textClaimantLastName";
    ((Control) this.textClaimantLastName).Size = new Size(214, 20);
    ((Control) this.textClaimantLastName).TabIndex = 27;
    ((UltraControlBase) this.textClaimantLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimantLastName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimantSsnFein).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textClaimantSsnFein).BackColor = Color.White;
    ((Control) this.textClaimantSsnFein).Location = new Point(435, 50);
    this.textClaimantSsnFein.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimantSsnFein).Name = "textClaimantSsnFein";
    ((Control) this.textClaimantSsnFein).Size = new Size(146, 20);
    ((Control) this.textClaimantSsnFein).TabIndex = 25;
    ((UltraControlBase) this.textClaimantSsnFein).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimantSsnFein).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimantFirstName).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textClaimantFirstName).BackColor = Color.White;
    ((Control) this.textClaimantFirstName).Location = new Point(435, 93);
    this.textClaimantFirstName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimantFirstName).Name = "textClaimantFirstName";
    ((Control) this.textClaimantFirstName).Size = new Size(214, 20);
    ((Control) this.textClaimantFirstName).TabIndex = 29;
    ((UltraControlBase) this.textClaimantFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimantFirstName).UseOsThemes = (DefaultableBoolean) 2;
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(330, 93);
    this.label6.Name = "label6";
    this.label6.Size = new Size(106, 13);
    this.label6.TabIndex = 28;
    this.label6.Text = "Claimant First Name:";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(330, 71);
    this.label5.Name = "label5";
    this.label5.Size = new Size(105, 13);
    this.label5.TabIndex = 26;
    this.label5.Text = "Claimant Last Name:";
    ((Control) this.groupNewClaimSearch).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupNewClaimSearch).ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.labelPolicyExpiration);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label22);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateTimePolicyExpirationTo);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label20);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateTimePolicyEffectiveTo);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateTimePolicyExpirationFrom);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateTimePolicyEffectiveFrom);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.labelPolicyEffective);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textClaimantCorporationName);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label19);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label18);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textCheckNumber);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label11);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.comboAdjusterName);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateTimeDateReportedTo);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateTimeDateReportedFrom);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label17);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label12);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.comboClaimStatus);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label16);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.buttonSearch);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.buttonCancel);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label15);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.comboLines);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textClaimNumber);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label14);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.comboCompanyLocations);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateLossDateTo);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.dateLossDateFrom);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textControlNumber);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label13);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label10);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label3);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label8);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textInsuredName);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textClaimantLastName);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label4);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textClaimantSsnFein);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textPolicyNumber);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.textClaimantFirstName);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label9);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label6);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label7);
    ((Control) this.groupNewClaimSearch).Controls.Add((Control) this.label5);
    ((AppearanceBase) appearance10).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGroupBox) this.groupNewClaimSearch).HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.groupNewClaimSearch).Location = new Point(31 /*0x1F*/, 44);
    ((Control) this.groupNewClaimSearch).Name = "groupNewClaimSearch";
    ((Control) this.groupNewClaimSearch).Size = new Size(693, 241);
    ((Control) this.groupNewClaimSearch).TabIndex = 2;
    ((Control) this.groupNewClaimSearch).Text = "Claim Search Options";
    ((UltraGroupBox) this.groupNewClaimSearch).ViewStyle = (GroupBoxViewStyle) 2;
    this.labelPolicyExpiration.Anchor = AnchorStyles.Left;
    this.labelPolicyExpiration.AutoSize = true;
    this.labelPolicyExpiration.BackColor = Color.Transparent;
    this.labelPolicyExpiration.Location = new Point(5, 98);
    this.labelPolicyExpiration.Name = "labelPolicyExpiration";
    this.labelPolicyExpiration.Size = new Size(89, 13);
    this.labelPolicyExpiration.TabIndex = 8;
    this.labelPolicyExpiration.Text = "Policy Expiration:";
    this.label22.Anchor = AnchorStyles.Left;
    this.label22.AutoSize = true;
    this.label22.BackColor = Color.Transparent;
    this.label22.Location = new Point(205, 102);
    this.label22.Name = "label22";
    this.label22.Size = new Size(19, 13);
    this.label22.TabIndex = 10;
    this.label22.Text = "To";
    ((Control) this.dateTimePolicyExpirationTo).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance12).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance12).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance12).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance12).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dateTimePolicyExpirationTo).Location = new Point(224 /*0xE0*/, 98);
    this.dateTimePolicyExpirationTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimePolicyExpirationTo).Name = "dateTimePolicyExpirationTo";
    ((Control) this.dateTimePolicyExpirationTo).Size = new Size(86, 20);
    ((Control) this.dateTimePolicyExpirationTo).TabIndex = 11;
    ((UltraControlBase) this.dateTimePolicyExpirationTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePolicyExpirationTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyExpirationTo).Value = (object) null;
    this.label20.Anchor = AnchorStyles.Left;
    this.label20.AutoSize = true;
    this.label20.BackColor = Color.Transparent;
    this.label20.Location = new Point(205, 79);
    this.label20.Name = "label20";
    this.label20.Size = new Size(19, 13);
    this.label20.TabIndex = 6;
    this.label20.Text = "To";
    ((Control) this.dateTimePolicyEffectiveTo).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).Appearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance14).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance14).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance14).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance14).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).ButtonAppearance = (AppearanceBase) appearance14;
    ((Control) this.dateTimePolicyEffectiveTo).Location = new Point(224 /*0xE0*/, 75);
    this.dateTimePolicyEffectiveTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimePolicyEffectiveTo).Name = "dateTimePolicyEffectiveTo";
    ((Control) this.dateTimePolicyEffectiveTo).Size = new Size(86, 20);
    ((Control) this.dateTimePolicyEffectiveTo).TabIndex = 7;
    ((UltraControlBase) this.dateTimePolicyEffectiveTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePolicyEffectiveTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyEffectiveTo).Value = (object) null;
    ((Control) this.dateTimePolicyExpirationFrom).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance16).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance16).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance16).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance16).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance16).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dateTimePolicyExpirationFrom).Location = new Point(116, 98);
    this.dateTimePolicyExpirationFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimePolicyExpirationFrom).Name = "dateTimePolicyExpirationFrom";
    ((Control) this.dateTimePolicyExpirationFrom).Size = new Size(86, 20);
    ((Control) this.dateTimePolicyExpirationFrom).TabIndex = 9;
    ((UltraControlBase) this.dateTimePolicyExpirationFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePolicyExpirationFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyExpirationFrom).Value = (object) null;
    ((Control) this.dateTimePolicyEffectiveFrom).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).Appearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance18).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance18).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance18).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance18).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance18).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).ButtonAppearance = (AppearanceBase) appearance18;
    ((Control) this.dateTimePolicyEffectiveFrom).Location = new Point(116, 75);
    this.dateTimePolicyEffectiveFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimePolicyEffectiveFrom).Name = "dateTimePolicyEffectiveFrom";
    ((Control) this.dateTimePolicyEffectiveFrom).Size = new Size(86, 20);
    ((Control) this.dateTimePolicyEffectiveFrom).TabIndex = 5;
    ((UltraControlBase) this.dateTimePolicyEffectiveFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePolicyEffectiveFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimePolicyEffectiveFrom).Value = (object) null;
    this.labelPolicyEffective.Anchor = AnchorStyles.Left;
    this.labelPolicyEffective.AutoSize = true;
    this.labelPolicyEffective.BackColor = Color.Transparent;
    this.labelPolicyEffective.Location = new Point(5, 75);
    this.labelPolicyEffective.Name = "labelPolicyEffective";
    this.labelPolicyEffective.Size = new Size(84, 13);
    this.labelPolicyEffective.TabIndex = 4;
    this.labelPolicyEffective.Text = "Policy Effective:";
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimantCorporationName).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textClaimantCorporationName).BackColor = Color.White;
    ((Control) this.textClaimantCorporationName).Location = new Point(435, 114);
    this.textClaimantCorporationName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimantCorporationName).Name = "textClaimantCorporationName";
    ((Control) this.textClaimantCorporationName).Size = new Size(214, 20);
    ((Control) this.textClaimantCorporationName).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.textClaimantCorporationName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimantCorporationName).UseOsThemes = (DefaultableBoolean) 2;
    this.label19.AutoSize = true;
    this.label19.BackColor = Color.Transparent;
    this.label19.Location = new Point(330, 114);
    this.label19.Name = "label19";
    this.label19.Size = new Size(98, 13);
    this.label19.TabIndex = 30;
    this.label19.Text = "Corporation Name:";
    this.label18.AutoSize = true;
    this.label18.BackColor = Color.Transparent;
    this.label18.Location = new Point(330, 181);
    this.label18.Name = "label18";
    this.label18.Size = new Size(80 /*0x50*/, 13);
    this.label18.TabIndex = 40;
    this.label18.Text = "Check Number:";
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckNumber).Appearance = (AppearanceBase) appearance20;
    ((Control) this.textCheckNumber).BackColor = Color.White;
    ((Control) this.textCheckNumber).Location = new Point(435, 181);
    this.textCheckNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCheckNumber).Name = "textCheckNumber";
    ((Control) this.textCheckNumber).Size = new Size(100, 20);
    ((Control) this.textCheckNumber).TabIndex = 41;
    ((UltraControlBase) this.textCheckNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Location = new Point(533, 162);
    this.label11.Name = "label11";
    this.label11.Size = new Size(19, 13);
    this.label11.TabIndex = 38;
    this.label11.Text = "To";
    ((Control) this.comboAdjusterName).Anchor = AnchorStyles.Left;
    ((UltraCombo) this.comboAdjusterName).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboAdjusterName).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAdjusterName).Location = new Point(116, 212);
    this.comboAdjusterName.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboAdjusterName).Name = "comboAdjusterName";
    ((Control) this.comboAdjusterName).Size = new Size(194, 21);
    ((Control) this.comboAdjusterName).TabIndex = 21;
    ((UltraControlBase) this.comboAdjusterName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAdjusterName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeDateReportedTo).Appearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance22).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance22).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance22).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance22).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance22).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeDateReportedTo).ButtonAppearance = (AppearanceBase) appearance22;
    ((UltraDateTimeEditor) this.dateTimeDateReportedTo).DateTime = new DateTime(2011, 1, 24, 0, 0, 0, 0);
    ((Control) this.dateTimeDateReportedTo).Location = new Point(563, 158);
    this.dateTimeDateReportedTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeDateReportedTo).Name = "dateTimeDateReportedTo";
    ((Control) this.dateTimeDateReportedTo).Size = new Size(86, 20);
    ((Control) this.dateTimeDateReportedTo).TabIndex = 39;
    ((UltraControlBase) this.dateTimeDateReportedTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeDateReportedTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeDateReportedTo).Value = (object) new DateTime(2011, 1, 24, 0, 0, 0, 0);
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).Appearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance24).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance24).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance24).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance24).ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).ButtonAppearance = (AppearanceBase) appearance24;
    ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).DateTime = new DateTime(2011, 1, 24, 0, 0, 0, 0);
    ((Control) this.dateTimeDateReportedFrom).Location = new Point(435, 159);
    this.dateTimeDateReportedFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeDateReportedFrom).Name = "dateTimeDateReportedFrom";
    ((Control) this.dateTimeDateReportedFrom).Size = new Size(86, 20);
    ((Control) this.dateTimeDateReportedFrom).TabIndex = 37;
    ((UltraControlBase) this.dateTimeDateReportedFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeDateReportedFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateTimeDateReportedFrom).Value = (object) new DateTime(2011, 1, 24, 0, 0, 0, 0);
    this.label17.Anchor = AnchorStyles.Left;
    this.label17.AutoSize = true;
    this.label17.BackColor = Color.Transparent;
    this.label17.Location = new Point(5, 210);
    this.label17.Name = "label17";
    this.label17.Size = new Size(82, 13);
    this.label17.TabIndex = 20;
    this.label17.Text = "Adjuster Name:";
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Location = new Point(330, 159);
    this.label12.Name = "label12";
    this.label12.Size = new Size(82, 13);
    this.label12.TabIndex = 36;
    this.label12.Text = "Date Reported:";
    ((Control) this.comboClaimStatus).Anchor = AnchorStyles.Left;
    ((UltraCombo) this.comboClaimStatus).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboClaimStatus).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimStatus).Location = new Point(116, 189);
    this.comboClaimStatus.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimStatus).Name = "comboClaimStatus";
    ((Control) this.comboClaimStatus).Size = new Size(194, 21);
    ((Control) this.comboClaimStatus).TabIndex = 19;
    ((UltraControlBase) this.comboClaimStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimStatus).UseOsThemes = (DefaultableBoolean) 2;
    this.label16.Anchor = AnchorStyles.Left;
    this.label16.AutoSize = true;
    this.label16.BackColor = Color.Transparent;
    this.label16.Location = new Point(5, 189);
    this.label16.Name = "label16";
    this.label16.Size = new Size(70, 13);
    this.label16.TabIndex = 18;
    this.label16.Text = "Claim Status:";
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance25).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance25).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance25).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance25;
    ((Control) this.buttonSearch).Location = new Point(478, 214);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(83, 22);
    ((Control) this.buttonSearch).TabIndex = 42;
    ((Control) this.buttonSearch).Text = "Search";
    ((UltraControlBase) this.buttonSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearch).Click += new EventHandler(this.buttonSearch_Click);
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance26).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance26).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance26).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance26;
    ((Control) this.buttonCancel).Location = new Point(566, 214);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(83, 22);
    ((Control) this.buttonCancel).TabIndex = 43;
    ((Control) this.buttonCancel).Text = "Cancel/Clear";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((Control) this.comboLines).Anchor = AnchorStyles.Left;
    ((UltraCombo) this.comboLines).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboLines).DataSource = (object) this.linesBindingSource1;
    ((UltraDropDownBase) this.comboLines).DisplayMember = "LineName";
    ((UltraCombo) this.comboLines).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboLines).Location = new Point(116, 166);
    this.comboLines.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboLines).Name = "comboLines";
    ((Control) this.comboLines).Size = new Size(194, 21);
    ((Control) this.comboLines).TabIndex = 17;
    ((UltraControlBase) this.comboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboLines).ValueMember = "LineGuid";
    this.linesBindingSource1.DataMember = "Lines";
    this.linesBindingSource1.DataSource = (object) this.dsLinesBindingSource;
    this.dsLinesBindingSource.DataSource = (object) this.dsLines;
    this.dsLinesBindingSource.Position = 0;
    this.dsLines.DataSetName = "dsLines";
    this.dsLines.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.comboCompanyLocations).Anchor = AnchorStyles.Left;
    ((UltraCombo) this.comboCompanyLocations).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCompanyLocations).DataSource = (object) this.companyLocationsBindingSource;
    ((UltraDropDownBase) this.comboCompanyLocations).DisplayMember = "CompanyLocationName";
    ((UltraCombo) this.comboCompanyLocations).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyLocations).Location = new Point(116, 143);
    this.comboCompanyLocations.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboCompanyLocations).Name = "comboCompanyLocations";
    ((Control) this.comboCompanyLocations).Size = new Size(194, 21);
    ((Control) this.comboCompanyLocations).TabIndex = 15;
    ((UltraControlBase) this.comboCompanyLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCompanyLocations).ValueMember = "CompanyLocationGuid";
    this.companyLocationsBindingSource.DataMember = "CompanyLocations";
    this.companyLocationsBindingSource.DataSource = (object) this.dsCompanyLocations;
    this.dsCompanyLocations.DataSetName = "dsCompanyLocations";
    this.dsCompanyLocations.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.textControlNumber).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textControlNumber).Appearance = (AppearanceBase) appearance27;
    ((Control) this.textControlNumber).BackColor = Color.White;
    ((Control) this.textControlNumber).Location = new Point(116, 30);
    this.textControlNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textControlNumber).Name = "textControlNumber";
    ((Control) this.textControlNumber).Size = new Size(194, 20);
    ((Control) this.textControlNumber).TabIndex = 1;
    ((UltraControlBase) this.textControlNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textControlNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.label10.Anchor = AnchorStyles.Left;
    this.label10.AutoSize = true;
    this.label10.BackColor = Color.Transparent;
    this.label10.Location = new Point(5, 29);
    this.label10.Name = "label10";
    this.label10.Size = new Size(86, 13);
    this.label10.TabIndex = 0;
    this.label10.Text = "Control Number:";
    this.label3.Anchor = AnchorStyles.Left;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(5, 143);
    this.label3.Name = "label3";
    this.label3.Size = new Size(99, 13);
    this.label3.TabIndex = 14;
    this.label3.Text = "Company Location:";
    ((Control) this.textInsuredName).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInsuredName).Appearance = (AppearanceBase) appearance28;
    ((Control) this.textInsuredName).BackColor = Color.White;
    ((Control) this.textInsuredName).Location = new Point(116, 121);
    this.textInsuredName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textInsuredName).Name = "textInsuredName";
    ((Control) this.textInsuredName).Size = new Size(194, 20);
    ((Control) this.textInsuredName).TabIndex = 13;
    ((UltraControlBase) this.textInsuredName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInsuredName).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.Anchor = AnchorStyles.Left;
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(5, 165);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 13);
    this.label4.TabIndex = 16 /*0x10*/;
    this.label4.Text = "Line:";
    ((Control) this.textPolicyNumber).Anchor = AnchorStyles.Left;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPolicyNumber).Appearance = (AppearanceBase) appearance29;
    ((Control) this.textPolicyNumber).BackColor = Color.White;
    ((Control) this.textPolicyNumber).Location = new Point(116, 52);
    this.textPolicyNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPolicyNumber).Name = "textPolicyNumber";
    ((Control) this.textPolicyNumber).Size = new Size(194, 20);
    ((Control) this.textPolicyNumber).TabIndex = 3;
    ((UltraControlBase) this.textPolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.label9.Anchor = AnchorStyles.Left;
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Location = new Point(5, 53);
    this.label9.Name = "label9";
    this.label9.Size = new Size(78, 13);
    this.label9.TabIndex = 2;
    this.label9.Text = "Policy Number:";
    this.label7.Anchor = AnchorStyles.Left;
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Location = new Point(5, 121);
    this.label7.Name = "label7";
    this.label7.Size = new Size(78, 13);
    this.label7.TabIndex = 12;
    this.label7.Text = "Insured Name:";
    this.pictureCurtain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureCurtain.Image = (Image) Resources.Progress1;
    this.pictureCurtain.Location = new Point(31 /*0x1F*/, 291);
    this.pictureCurtain.Name = "pictureCurtain";
    this.pictureCurtain.Size = new Size(693, 335);
    this.pictureCurtain.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureCurtain.TabIndex = 5;
    this.pictureCurtain.TabStop = false;
    this.pictureCurtain.Visible = false;
    this.labelNoResults.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelNoResults.ForeColor = Color.SteelBlue;
    this.labelNoResults.ImageAlign = ContentAlignment.TopCenter;
    this.labelNoResults.Location = new Point(47, 328);
    this.labelNoResults.Name = "labelNoResults";
    this.labelNoResults.Size = new Size(674, 19);
    this.labelNoResults.TabIndex = 5;
    this.labelNoResults.Text = "No results that matched your criteria were found. Please check your search and try again.";
    this.labelNoResults.TextAlign = ContentAlignment.BottomCenter;
    this.labelNoResults.Visible = false;
    this.linesBindingSource.DataMember = "Lines";
    this.linesBindingSource.DataSource = (object) this.dsLinesBindingSource;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._ClaimsSearch_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left).Name = "_ClaimsSearch_Toolbars_Dock_Area_Left";
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left).Size = new Size(0, 643);
    this._ClaimsSearch_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this.gridSearchResults).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridSearchResults, "popupGridOptions");
    ((UltraGridBase) this.gridSearchResults).DataSource = (object) this.dsClaimsSearch1;
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Appearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.EditorComponent = (Component) this.lnkControlNo;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 62;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance32;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 126;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 126;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance34;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 116;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 143;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 118;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BorderColor = Color.White;
    ((AppearanceBase) appearance37).Image = componentResourceManager.GetObject("appearance37.Image");
    ultraGridColumn7.CellButtonAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance38;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "# of Claims";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 89;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 80 /*0x50*/;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridBand1.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.RowLayoutStyle = (RowLayoutStyle) 1;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 135;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance40;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 73;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 148;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance42;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Width = 64 /*0x40*/;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 4;
    ultraGridColumn14.Width = 113;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance44;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 6;
    ultraGridColumn15.Width = 86;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "# of Claimants";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 7;
    ultraGridColumn16.Width = 84;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance45;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 5;
    ultraGridColumn17.Width = 137;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 8;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Style = (ColumnStyle) 27;
    ultraGridColumn18.Width = 27;
    ((AppearanceBase) appearance46).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance46).ImageVAlign = (VAlign) 2;
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 9;
    ultraGridColumn19.Style = (ColumnStyle) 27;
    ultraGridColumn19.Width = 21;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion1);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion2);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion3);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion4);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion5);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion6);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion7);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion8);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion9);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion10);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion11);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion12);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion13);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion14);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion15);
    ((AppearanceBase) appearance47).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance47).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance47;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance48).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance49).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance50).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance52).BackColor = Color.Transparent;
    ((AppearanceBase) appearance52).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    ((AppearanceBase) appearance53).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance53).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance54;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridSearchResults).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridSearchResults).Font = new Font("Tahoma", 8.25f);
    ((AppearanceBase) appearance55).BackColor = Color.White;
    ((AppearanceBase) appearance55).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance55;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance56;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 0;
    ultraGridColumn20.Width = 45;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 1;
    ultraGridColumn21.Width = 85;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance58;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 2;
    ultraGridColumn22.Width = 84;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance59).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 3;
    ultraGridColumn23.Width = 80 /*0x50*/;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance60;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 4;
    ultraGridColumn24.Width = 99;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn25.Header).Appearance = (AppearanceBase) appearance61;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 5;
    ultraGridColumn25.Width = 83;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((AppearanceBase) appearance62).BackColor = Color.White;
    ((AppearanceBase) appearance62).BorderColor = Color.White;
    ((AppearanceBase) appearance62).Image = (object) Resources.View;
    ultraGridColumn26.CellButtonAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn26.Header).Appearance = (AppearanceBase) appearance63;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "# of Claims";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 6;
    ultraGridColumn26.Width = 62;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 8;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 80 /*0x50*/;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 7;
    ultraGridColumn28.Width = 153;
    ultraGridBand3.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance64).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance64;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 0;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 135;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance65).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance65;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 1;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 73;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance66).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn31.Header).Appearance = (AppearanceBase) appearance66;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 2;
    ultraGridColumn31.Width = 177;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance67).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn32.Header).Appearance = (AppearanceBase) appearance67;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 3;
    ultraGridColumn32.Width = 66;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance68;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 4;
    ultraGridColumn33.Width = 124;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance69).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn34.Header).Appearance = (AppearanceBase) appearance69;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 6;
    ultraGridColumn34.Width = 94;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "# of Claimants";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 7;
    ultraGridColumn35.Width = 76;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance70).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn36.Header).Appearance = (AppearanceBase) appearance70;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 5;
    ultraGridColumn36.Width = 154;
    ultraGridBand4.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36
    });
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout.ColScrollRegions.Add((object) colScrollRegion16);
    ultraGridLayout.ColScrollRegions.Add((object) colScrollRegion17);
    ((KeyedSubObjectBase) ultraGridLayout).Key = "BaseLayout";
    ((AppearanceBase) appearance71).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance71).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance71).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance71;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance72).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance72;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance73).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance73;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance74).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance74;
    ((AppearanceBase) appearance75).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance75;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance76).BackColor = Color.Transparent;
    ((AppearanceBase) appearance76).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance76;
    ((AppearanceBase) appearance77).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance77).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance77;
    ((AppearanceBase) appearance78).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance78;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridSearchResults).Layouts.Add(ultraGridLayout);
    ((Control) this.gridSearchResults).Location = new Point(31 /*0x1F*/, 291);
    ((Control) this.gridSearchResults).Name = "gridSearchResults";
    ((Control) this.gridSearchResults).Size = new Size(693, 335);
    ((Control) this.gridSearchResults).TabIndex = 3;
    ((UltraControlBase) this.gridSearchResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSearchResults).UseOsThemes = (DefaultableBoolean) 2;
    this.gridSearchResults.InitializeRow += new InitializeRowEventHandler(this.gridSearchResults_InitializeRow);
    this.gridSearchResults.ClickCellButton += new CellEventHandler(this.gridSearchResults_ClickCellButton);
    this.gridSearchResults.DoubleClickRow += new DoubleClickRowEventHandler(this.gridSearchResults_DoubleClickRow);
    ((Control) this.gridSearchResults).MouseDown += new MouseEventHandler(this.gridSearchResults_MouseDown);
    this.dsClaimsSearch1.DataSetName = "dsClaimsSearch";
    this.dsClaimsSearch1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._ClaimsSearch_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right).Location = new Point(753, 0);
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right).Name = "_ClaimsSearch_Toolbars_Dock_Area_Right";
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right).Size = new Size(0, 643);
    this._ClaimsSearch_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._ClaimsSearch_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top).Name = "_ClaimsSearch_Toolbars_Dock_Area_Top";
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top).Size = new Size(753, 0);
    this._ClaimsSearch_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._ClaimsSearch_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom).Location = new Point(0, 643);
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom).Name = "_ClaimsSearch_Toolbars_Dock_Area_Bottom";
    ((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom).Size = new Size(753, 0);
    this._ClaimsSearch_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(603, 364);
    ultraToolbar.FloatingSize = new Size(119, 22);
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.ShowInToolbarList = false;
    ultraToolbar.Text = "toolbarGridContext";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance79).Image = (object) Resources.Add;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance79;
    ((AppearanceBase) appearance80).Image = (object) Resources.Add;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance80;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Add Claim";
    ((ToolBase) buttonTool2).SharedPropsInternal.Category = "ClaimOptions";
    ((AppearanceBase) appearance81).Image = (object) Resources.View;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance81;
    ((AppearanceBase) appearance82).Image = (object) Resources.View;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.AppearanceOnMenu = (AppearanceBase) appearance82;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "View Claims";
    ((ToolBase) buttonTool3).SharedPropsInternal.Category = "ClaimOptions";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "popupGridOptions";
    ((ToolBase) popupMenuTool).SharedPropsInternal.Category = "ClaimOptions";
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool8).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((AppearanceBase) appearance83).Image = (object) Resources.Edit;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance83;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Open Claim";
    ((ToolBase) buttonTool9).SharedPropsInternal.Category = "ClaimOptions";
    ((ToolBase) buttonTool9).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance84).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance84;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Delete Claim";
    ((ToolBase) buttonTool10).SharedPropsInternal.Category = "ClaimOptions";
    ((ToolBase) buttonTool10).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance85).Image = (object) Resources.Transfer;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance85;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Move Claim";
    ((ToolBase) buttonTool11).SharedPropsInternal.Category = "ClaimOptions";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoScroll = true;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.lnkControlNo);
    this.Controls.Add((Control) this.groupNewClaimSearch);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.labelNoResults);
    this.Controls.Add((Control) this.gridSearchResults);
    this.Controls.Add((Control) this.pictureCurtain);
    this.Controls.Add((Control) this._ClaimsSearch_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._ClaimsSearch_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._ClaimsSearch_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._ClaimsSearch_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (ClaimsSearch);
    this.Size = new Size(753, 643);
    this.Load += new EventHandler(this.ClaimsSearch_Load);
    ((ISupportInitialize) this.textClaimNumber).EndInit();
    ((ISupportInitialize) this.dateLossDateTo).EndInit();
    ((ISupportInitialize) this.dateLossDateFrom).EndInit();
    ((ISupportInitialize) this.textClaimantLastName).EndInit();
    ((ISupportInitialize) this.textClaimantSsnFein).EndInit();
    ((ISupportInitialize) this.textClaimantFirstName).EndInit();
    ((ISupportInitialize) this.groupNewClaimSearch).EndInit();
    ((Control) this.groupNewClaimSearch).ResumeLayout(false);
    ((Control) this.groupNewClaimSearch).PerformLayout();
    ((ISupportInitialize) this.dateTimePolicyExpirationTo).EndInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveTo).EndInit();
    ((ISupportInitialize) this.dateTimePolicyExpirationFrom).EndInit();
    ((ISupportInitialize) this.dateTimePolicyEffectiveFrom).EndInit();
    ((ISupportInitialize) this.textClaimantCorporationName).EndInit();
    ((ISupportInitialize) this.textCheckNumber).EndInit();
    ((ISupportInitialize) this.comboAdjusterName).EndInit();
    ((ISupportInitialize) this.dateTimeDateReportedTo).EndInit();
    ((ISupportInitialize) this.dateTimeDateReportedFrom).EndInit();
    ((ISupportInitialize) this.comboClaimStatus).EndInit();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.comboLines).EndInit();
    ((ISupportInitialize) this.linesBindingSource1).EndInit();
    ((ISupportInitialize) this.dsLinesBindingSource).EndInit();
    this.dsLines.EndInit();
    ((ISupportInitialize) this.comboCompanyLocations).EndInit();
    ((ISupportInitialize) this.companyLocationsBindingSource).EndInit();
    this.dsCompanyLocations.EndInit();
    ((ISupportInitialize) this.textControlNumber).EndInit();
    ((ISupportInitialize) this.textInsuredName).EndInit();
    ((ISupportInitialize) this.textPolicyNumber).EndInit();
    ((ISupportInitialize) this.pictureCurtain).EndInit();
    ((ISupportInitialize) this.linesBindingSource).EndInit();
    ((ISupportInitialize) this.gridSearchResults).EndInit();
    this.dsClaimsSearch1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
