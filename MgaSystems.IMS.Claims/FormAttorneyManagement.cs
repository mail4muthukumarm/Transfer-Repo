// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormAttorneyManagement
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

[SecureResource("{A7E673B7-B685-46DE-AFBA-3C24E660B2FE}", "Edit Attorney Management Rights", "Users with this permission are granted the ability to manage attorneys", "Claims")]
public class FormAttorneyManagement : FormBase
{
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormAttorneyManagement_Fill_Panel;
  private MGAMaskedEdit maskFax;
  private Label label1;
  private MGAMaskedEdit maskPhone;
  private Label label5;
  protected UltraOptionSet optEntityType;
  private MGAButton btnSave;
  protected MGAMaskedEdit txtFEIN;
  protected Label label53;
  protected UltraLabel lblAttorneyName;
  protected MGATextBox txtAttorneyName;
  protected UltraLabel lblLawFirm;
  private MGAButton btnCancel;
  private UltraGrid gridClaimAttorneys;
  protected UltraOptionSet optClaimantDefense;
  protected MGATextBox txtLawFirm;
  protected AddressResolver_MULTI addressResolver;
  private UltraToolbarsDockArea ultraToolbarsDockArea2;
  private UltraToolbarsDockArea ultraToolbarsDockArea3;
  private UltraToolbarsDockArea ultraToolbarsDockArea1;
  private UltraToolbarsDockArea _FormClaimAttorneys_Toolbars_Dock_Area_Top;

  private Guid AttorneyGuid { get; set; }

  public FormAttorneyManagement() => this.InitializeComponent();

  private void FormAttorneyManagement_Load(object sender, EventArgs e)
  {
    this.ClearScreen();
    this.LoadAttorneys();
    this.SetAddressResolverProperties();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.SaveAttorney();
    this.ClearScreen();
    this.LoadAttorneys();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will clear the current information, continue?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.ClearScreen();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.gridClaimAttorneys).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("You must select an attorney to continue.", "No Attorney Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
      {
        case "DELETE":
          if (MessageBox.Show("Are you sure you want to delete this attorney?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyGuid"].Value))
              this.AttorneyGuid = Guid.Parse(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyGuid"].Value.ToString());
            DefaultDatabase.ExecuteNonQuery("spClaims_DeleteAttorney", new object[2]
            {
              (object) "@AttorneyGuid",
              (object) this.AttorneyGuid
            });
            this.ClearScreen();
            break;
          }
          break;
        case "EDIT":
          this.DisplaySelectedAttorney();
          break;
      }
      this.LoadAttorneys();
    }
  }

  private void SetAddressResolverProperties()
  {
    this.addressResolver.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressResolver.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressResolver.Password = AddressResolverSettings.AddressResolverPassword;
  }

  private void SaveAttorney()
  {
    Regex regex = new Regex("[()\\s-]");
    if (!this.ValidateForm())
      return;
    if (this.AttorneyGuid.Equals(Guid.Empty))
      DefaultDatabase.ExecuteNonQuery("spClaims_InsertAttorney", new object[36]
      {
        (object) "@AttorneyGuid",
        (object) Guid.NewGuid(),
        (object) "@LawFirm",
        (object) ((Control) this.txtLawFirm).Text,
        (object) "@AttorneyName",
        (object) ((Control) this.txtAttorneyName).Text,
        (object) "@AttorneyType",
        (object) this.optClaimantDefense.Value.ToString()[0],
        (object) "@FEINSSN",
        (object) ((Control) this.txtFEIN).Text,
        (object) "@AttorneyEntityType",
        (object) this.optEntityType.Value.ToString(),
        (object) "@Address1",
        (object) this.addressResolver.Address1,
        (object) "@Address2",
        (object) this.addressResolver.Address2,
        (object) "@City",
        (object) this.addressResolver.City,
        (object) "@County",
        (object) this.addressResolver.County,
        (object) "@State",
        (object) this.addressResolver.State,
        (object) "@ZipCode",
        (object) this.addressResolver.ZipCode,
        (object) "@ZipPlus",
        (object) this.addressResolver.ZipCodeExtension,
        (object) "@ISOCountryCode",
        (object) this.addressResolver.ISOCountryCode,
        (object) "@PhoneNumber",
        (object) regex.Replace(((Control) this.maskPhone).Text, ""),
        (object) "@FaxNumber",
        (object) regex.Replace(((Control) this.maskFax).Text, ""),
        (object) "@DateCreated",
        (object) DateTime.Now,
        (object) "@CreatedBy",
        (object) CurrentUser.Instance.UserGUID
      });
    else
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateAttorney", new object[32 /*0x20*/]
      {
        (object) "@AttorneyGuid",
        (object) this.AttorneyGuid,
        (object) "@LawFirm",
        (object) ((Control) this.txtLawFirm).Text,
        (object) "@AttorneyName",
        (object) ((Control) this.txtAttorneyName).Text,
        (object) "@AttorneyType",
        (object) this.optClaimantDefense.Value.ToString()[0],
        (object) "@FEINSSN",
        (object) ((Control) this.txtFEIN).Text,
        (object) "@AttorneyEntityType",
        (object) ((Control) this.optEntityType).Text,
        (object) "@Address1",
        (object) this.addressResolver.Address1,
        (object) "@Address2",
        (object) this.addressResolver.Address2,
        (object) "@City",
        (object) this.addressResolver.City,
        (object) "@County",
        (object) this.addressResolver.County,
        (object) "@State",
        (object) this.addressResolver.State,
        (object) "@ZipCode",
        (object) this.addressResolver.ZipCode,
        (object) "@ZipPlus",
        (object) this.addressResolver.ZipCodeExtension,
        (object) "@ISOCountryCode",
        (object) this.addressResolver.ISOCountryCode,
        (object) "@PhoneNumber",
        (object) regex.Replace(((Control) this.maskPhone).Text, ""),
        (object) "@FaxNumber",
        (object) regex.Replace(((Control) this.maskFax).Text, "")
      });
  }

  private bool ValidateForm()
  {
    if (string.IsNullOrEmpty(((Control) this.txtLawFirm).Text))
    {
      int num = (int) MessageBox.Show("You must enter a law firm name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!string.IsNullOrEmpty(((Control) this.txtAttorneyName).Text))
      return true;
    int num1 = (int) MessageBox.Show("You must enter an attorney name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void ClearScreen()
  {
    this.AttorneyGuid = Guid.Empty;
    ((Control) this.optClaimantDefense).Text = "Defense";
    ((Control) this.txtLawFirm).Text = string.Empty;
    ((Control) this.txtAttorneyName).Text = string.Empty;
    ((Control) this.txtFEIN).Text = string.Empty;
    ((Control) this.optEntityType).Text = "I";
    this.addressResolver.Clear();
    ((Control) this.maskPhone).Text = string.Empty;
    ((Control) this.maskFax).Text = string.Empty;
  }

  private void LoadAttorneys()
  {
    ((UltraGridBase) this.gridClaimAttorneys).DataSource = (object) DefaultDatabase.ExecuteDataTable("spClaims_GetAttorneyList");
  }

  private void DisplaySelectedAttorney()
  {
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyGuid"].Value))
      this.AttorneyGuid = Guid.Parse(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyGuid"].Value.ToString());
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["LawFirm"].Value))
      ((Control) this.txtLawFirm).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["LawFirm"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyName"].Value))
      ((Control) this.txtAttorneyName).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyName"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyType"].Value))
      ((Control) this.optClaimantDefense).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyType"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["FEINSSN"].Value))
      ((Control) this.txtFEIN).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["FEINSSN"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyEntityType"].Value))
      ((Control) this.optEntityType).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["AttorneyEntityType"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["ISOCountryCode"].Value))
      this.addressResolver.ISOCountryCode = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["ISOCountryCode"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["Address1"].Value))
      this.addressResolver.Address1 = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["Address1"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["Address2"].Value))
      this.addressResolver.Address2 = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["Address2"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["City"].Value))
      this.addressResolver.City = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["City"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["County"].Value))
      this.addressResolver.County = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["County"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["State"].Value))
      this.addressResolver.State = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["State"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["ZipCode"].Value))
      this.addressResolver.ZipCode = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["ZipCode"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["ZipPlus"].Value))
      this.addressResolver.ZipCodeExtension = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["ZipPlus"].Value.ToString();
    if (!Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["PhoneNumber"].Value))
      ((Control) this.maskPhone).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["PhoneNumber"].Value.ToString();
    if (Utility.IsNull(((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["FaxNumber"].Value))
      return;
    ((Control) this.maskFax).Text = ((UltraGridBase) this.gridClaimAttorneys).ActiveRow.Cells["FaxNumber"].Value.ToString();
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
    UltraGridBand ultraGridBand = new UltraGridBand("ClaimAttorneys", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AttorneyGuid");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LawFirm");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AttorneyName");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Attorney Type");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("FEINSSN");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AttorneyEntityType");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Address1");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address2");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("City");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("State");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ZipCode");
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ISOCountryCode");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("PhoneNumber");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("FaxNumber");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CreatedBy");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridContext");
    ButtonTool buttonTool1 = new ButtonTool("EDIT");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    ButtonTool buttonTool3 = new ButtonTool("DELETE");
    ButtonTool buttonTool4 = new ButtonTool("EDIT");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    this.gridClaimAttorneys = new UltraGrid();
    this._FormClaimAttorneys_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.ultraToolbarsDockArea1 = new UltraToolbarsDockArea();
    this.ultraToolbarsDockArea2 = new UltraToolbarsDockArea();
    this.ultraToolbarsDockArea3 = new UltraToolbarsDockArea();
    this.maskFax = new MGAMaskedEdit();
    this.label1 = new Label();
    this.maskPhone = new MGAMaskedEdit();
    this.label5 = new Label();
    this.optEntityType = new UltraOptionSet();
    this.btnSave = new MGAButton();
    this.txtFEIN = new MGAMaskedEdit();
    this.label53 = new Label();
    this.lblAttorneyName = new UltraLabel();
    this.txtAttorneyName = new MGATextBox();
    this.lblLawFirm = new UltraLabel();
    this.btnCancel = new MGAButton();
    this.optClaimantDefense = new UltraOptionSet();
    this.txtLawFirm = new MGATextBox();
    this.addressResolver = new AddressResolver_MULTI();
    this.FormAttorneyManagement_Fill_Panel = new UltraPanel();
    ((ISupportInitialize) this.gridClaimAttorneys).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.maskFax).BeginInit();
    ((ISupportInitialize) this.maskPhone).BeginInit();
    ((ISupportInitialize) this.optEntityType).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.txtAttorneyName).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.optClaimantDefense).BeginInit();
    ((ISupportInitialize) this.txtLawFirm).BeginInit();
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormAttorneyManagement_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridClaimAttorneys, "gridContext");
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 13;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 107;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Law Firm";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 0;
    ultraGridColumn2.Width = 78;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Attorney Name";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 1;
    ultraGridColumn3.Width = 151;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 2;
    ultraGridColumn4.Width = 101;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 10;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 68;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 97;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.Width = 118;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 6;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 62;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 7;
    ultraGridColumn9.Width = 114;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 40;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 8;
    ultraGridColumn11.Width = 53;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 11;
    ultraGridColumn12.Width = 66;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 42;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 3;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 62;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 46;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 87;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 46;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 133;
    ultraGridBand.Columns.AddRange(new object[18]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance29).BackColor = Color.Transparent;
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance30).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridClaimAttorneys).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridClaimAttorneys).Location = new Point(372, 2);
    ((Control) this.gridClaimAttorneys).Name = "gridClaimAttorneys";
    ((Control) this.gridClaimAttorneys).Size = new Size(700, 326);
    ((Control) this.gridClaimAttorneys).TabIndex = 61;
    ((UltraControlBase) this.gridClaimAttorneys).UseAppStyling = false;
    ((UltraControlBase) this.gridClaimAttorneys).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimAttorneys).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormClaimAttorneys_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top).Name = "_FormClaimAttorneys_Toolbars_Dock_Area_Top";
    ((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top).Size = new Size(1080, 0);
    this._FormClaimAttorneys_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "gridContext";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Delete Attorney";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Edit Attorney";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this.ultraToolbarsDockArea1).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this.ultraToolbarsDockArea1).BackColor = SystemColors.Control;
    this.ultraToolbarsDockArea1.DockedPosition = (DockedPosition) 1;
    ((Control) this.ultraToolbarsDockArea1).ForeColor = SystemColors.ControlText;
    ((Control) this.ultraToolbarsDockArea1).Location = new Point(0, 337);
    ((Control) this.ultraToolbarsDockArea1).Name = "ultraToolbarsDockArea1";
    ((Control) this.ultraToolbarsDockArea1).Size = new Size(1080, 0);
    this.ultraToolbarsDockArea1.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this.ultraToolbarsDockArea2).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this.ultraToolbarsDockArea2).BackColor = SystemColors.Control;
    this.ultraToolbarsDockArea2.DockedPosition = (DockedPosition) 2;
    ((Control) this.ultraToolbarsDockArea2).ForeColor = SystemColors.ControlText;
    ((Control) this.ultraToolbarsDockArea2).Location = new Point(0, 0);
    ((Control) this.ultraToolbarsDockArea2).Name = "ultraToolbarsDockArea2";
    ((Control) this.ultraToolbarsDockArea2).Size = new Size(0, 337);
    this.ultraToolbarsDockArea2.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this.ultraToolbarsDockArea3).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this.ultraToolbarsDockArea3).BackColor = SystemColors.Control;
    this.ultraToolbarsDockArea3.DockedPosition = (DockedPosition) 3;
    ((Control) this.ultraToolbarsDockArea3).ForeColor = SystemColors.ControlText;
    ((Control) this.ultraToolbarsDockArea3).Location = new Point(1080, 0);
    ((Control) this.ultraToolbarsDockArea3).Name = "ultraToolbarsDockArea3";
    ((Control) this.ultraToolbarsDockArea3).Size = new Size(0, 337);
    this.ultraToolbarsDockArea3.ToolbarsManager = this.ultraToolbarsManager1;
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskFax).Appearance = (AppearanceBase) appearance32;
    ((UltraMaskedEdit) this.maskFax).DataMode = (MaskMode) 3;
    ((UltraMaskedEdit) this.maskFax).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskFax).InputMask = "(###) ###-####";
    ((Control) this.maskFax).Location = new Point(106, 268);
    this.maskFax.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskFax).Name = "maskFax";
    ((UltraMaskedEdit) this.maskFax).NonAutoSizeHeight = 20;
    ((Control) this.maskFax).Size = new Size(89, 20);
    ((Control) this.maskFax).TabIndex = 67;
    ((Control) this.maskFax).Text = "(___) ___-____";
    ((UltraControlBase) this.maskFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFax).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(7, 272);
    this.label1.Name = "label1";
    this.label1.Size = new Size(27, 13);
    this.label1.TabIndex = 66;
    this.label1.Text = "Fax:";
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.maskPhone).Appearance = (AppearanceBase) appearance33;
    ((UltraMaskedEdit) this.maskPhone).DataMode = (MaskMode) 3;
    ((UltraMaskedEdit) this.maskPhone).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.maskPhone).InputMask = "(###) ###-####";
    ((Control) this.maskPhone).Location = new Point(106, 243);
    this.maskPhone.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskPhone).Name = "maskPhone";
    ((UltraMaskedEdit) this.maskPhone).NonAutoSizeHeight = 20;
    ((Control) this.maskPhone).Size = new Size(89, 20);
    ((Control) this.maskPhone).TabIndex = 65;
    ((Control) this.maskPhone).Text = "(___) ___-____";
    ((UltraControlBase) this.maskPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(7, 247);
    this.label5.Name = "label5";
    this.label5.Size = new Size(41, 13);
    this.label5.TabIndex = 64 /*0x40*/;
    this.label5.Text = "Phone:";
    ((Control) this.optEntityType).BackColor = Color.Transparent;
    this.optEntityType.BackColorInternal = Color.Transparent;
    this.optEntityType.BorderStyle = (UIElementBorderStyle) 1;
    this.optEntityType.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) "I";
    valueListItem1.DisplayText = "Individual";
    valueListItem2.DataValue = (object) "C";
    valueListItem2.DisplayText = "Corporation";
    this.optEntityType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optEntityType).Location = new Point(193, 78);
    ((Control) this.optEntityType).Name = "optEntityType";
    ((Control) this.optEntityType).Size = new Size(166, 18);
    ((Control) this.optEntityType).TabIndex = 45;
    ((UltraControlBase) this.optEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance34).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance34).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance34).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance34).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance34).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance34;
    ((Control) this.btnSave).Location = new Point(179, 296);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(86, 31 /*0x1F*/);
    ((Control) this.btnSave).TabIndex = 62;
    ((Control) this.btnSave).Text = "&Save";
    ((UltraControlBase) this.btnSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Click += new EventHandler(this.btnSave_Click);
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.txtFEIN).Appearance = (AppearanceBase) appearance35;
    ((UltraMaskedEdit) this.txtFEIN).ClipMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.txtFEIN).DataMode = (MaskMode) 0;
    ((UltraMaskedEdit) this.txtFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtFEIN).InputMask = "99-9999999";
    ((Control) this.txtFEIN).Location = new Point(106, 74);
    this.txtFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    ((UltraMaskedEdit) this.txtFEIN).NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(76, 20);
    ((Control) this.txtFEIN).TabIndex = 56;
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.label53.AutoSize = true;
    this.label53.BackColor = Color.Transparent;
    this.label53.ForeColor = Color.Black;
    this.label53.Location = new Point(7, 77);
    this.label53.Name = "label53";
    this.label53.Size = new Size(61, 13);
    this.label53.TabIndex = 55;
    this.label53.Text = "FEIN/SSN:";
    ((AppearanceBase) appearance36).BackColor = Color.Transparent;
    ((ControlBase) this.lblAttorneyName).Appearance = (AppearanceBase) appearance36;
    ((Control) this.lblAttorneyName).AutoSize = true;
    ((Control) this.lblAttorneyName).Location = new Point(7, 53);
    ((Control) this.lblAttorneyName).Name = "lblAttorneyName";
    ((Control) this.lblAttorneyName).Size = new Size(83, 14);
    ((Control) this.lblAttorneyName).TabIndex = 53;
    ((Control) this.lblAttorneyName).Text = "Attorney Name:";
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAttorneyName).Appearance = (AppearanceBase) appearance37;
    ((Control) this.txtAttorneyName).BackColor = Color.White;
    ((Control) this.txtAttorneyName).Location = new Point(106, 50);
    this.txtAttorneyName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAttorneyName).Name = "txtAttorneyName";
    ((Control) this.txtAttorneyName).Size = new Size(252, 19);
    ((Control) this.txtAttorneyName).TabIndex = 54;
    ((UltraControlBase) this.txtAttorneyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAttorneyName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance38).BackColor = Color.Transparent;
    ((ControlBase) this.lblLawFirm).Appearance = (AppearanceBase) appearance38;
    ((Control) this.lblLawFirm).AutoSize = true;
    ((Control) this.lblLawFirm).Location = new Point(6, 29);
    ((Control) this.lblLawFirm).Name = "lblLawFirm";
    ((Control) this.lblLawFirm).Size = new Size(87, 14);
    ((Control) this.lblLawFirm).TabIndex = 51;
    ((Control) this.lblLawFirm).Text = "Law Firm Name:";
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance39).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance39).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance39).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance39).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance39).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance39;
    ((Control) this.btnCancel).Location = new Point(271, 296);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(86, 31 /*0x1F*/);
    ((Control) this.btnCancel).TabIndex = 63 /*0x3F*/;
    ((Control) this.btnCancel).Text = "&Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((Control) this.optClaimantDefense).BackColor = Color.Transparent;
    this.optClaimantDefense.BackColorInternal = Color.Transparent;
    this.optClaimantDefense.BorderStyle = (UIElementBorderStyle) 1;
    this.optClaimantDefense.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem3.DataValue = (object) "Defense";
    valueListItem3.DisplayText = "Defense Attorney";
    valueListItem4.DataValue = (object) "Claimant";
    valueListItem4.DisplayText = "Claimant Attorney";
    this.optClaimantDefense.Items.AddRange(new ValueListItem[2]
    {
      valueListItem3,
      valueListItem4
    });
    ((Control) this.optClaimantDefense).Location = new Point(106, 5);
    ((Control) this.optClaimantDefense).Name = "optClaimantDefense";
    ((Control) this.optClaimantDefense).Size = new Size(266, 19);
    ((Control) this.optClaimantDefense).TabIndex = 59;
    ((UltraControlBase) this.optClaimantDefense).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optClaimantDefense).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance40).BackColor = Color.White;
    ((AppearanceBase) appearance40).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance40).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLawFirm).Appearance = (AppearanceBase) appearance40;
    ((Control) this.txtLawFirm).BackColor = Color.White;
    ((Control) this.txtLawFirm).Location = new Point(106, 27);
    this.txtLawFirm.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLawFirm).Name = "txtLawFirm";
    ((Control) this.txtLawFirm).Size = new Size(252, 19);
    ((Control) this.txtLawFirm).TabIndex = 52;
    ((UltraControlBase) this.txtLawFirm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLawFirm).UseOsThemes = (DefaultableBoolean) 2;
    this.addressResolver.Address1 = "";
    this.addressResolver.Address2 = "";
    ((Control) this.addressResolver).BackColor = Color.Transparent;
    this.addressResolver.City = "";
    this.addressResolver.County = "";
    ((Control) this.addressResolver).Font = new Font("Tahoma", 8f);
    this.addressResolver.ISOCountryCode = "";
    this.addressResolver.ISOCountryCodeMember = "";
    this.addressResolver.ISOCountryList = (object) null;
    this.addressResolver.ISOCountryNameMember = "";
    ((Control) this.addressResolver).Location = new Point(-1, 91);
    this.addressResolver.MGAStyle = (MGAStyles) 2;
    ((Control) this.addressResolver).Name = "addressResolver";
    this.addressResolver.Password = (string) null;
    ((Control) this.addressResolver).Size = new Size(283, 159);
    this.addressResolver.State = "";
    ((Control) this.addressResolver).TabIndex = 57;
    ((Control) this.addressResolver).Tag = (object) "Defense Firm Address";
    this.addressResolver.TextAlign = ContentAlignment.TopLeft;
    this.addressResolver.UserID = (string) null;
    this.addressResolver.WebserviceUrl = (string) null;
    this.addressResolver.ZipCode = "";
    this.addressResolver.ZipCodeExtension = "";
    ((AppearanceBase) appearance41).BackColor = Color.Transparent;
    this.FormAttorneyManagement_Fill_Panel.Appearance = (AppearanceBase) appearance41;
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.maskFax);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.label1);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.maskPhone);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.label5);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.optEntityType);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.btnSave);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.txtFEIN);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.label53);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.lblAttorneyName);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.txtAttorneyName);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.lblLawFirm);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.btnCancel);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.gridClaimAttorneys);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.optClaimantDefense);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.txtLawFirm);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.addressResolver);
    ((Control) this.FormAttorneyManagement_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormAttorneyManagement_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormAttorneyManagement_Fill_Panel).Location = new Point(0, 0);
    ((Control) this.FormAttorneyManagement_Fill_Panel).Name = "FormAttorneyManagement_Fill_Panel";
    ((Control) this.FormAttorneyManagement_Fill_Panel).Size = new Size(1080, 337);
    ((Control) this.FormAttorneyManagement_Fill_Panel).TabIndex = 87;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    this.ClientSize = new Size(1080, 337);
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this, "gridContext");
    this.Controls.Add((Control) this.FormAttorneyManagement_Fill_Panel);
    this.Controls.Add((Control) this.ultraToolbarsDockArea2);
    this.Controls.Add((Control) this.ultraToolbarsDockArea3);
    this.Controls.Add((Control) this.ultraToolbarsDockArea1);
    this.Controls.Add((Control) this._FormClaimAttorneys_Toolbars_Dock_Area_Top);
    this.Name = nameof (FormAttorneyManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Attorney Management";
    this.Load += new EventHandler(this.FormAttorneyManagement_Load);
    ((ISupportInitialize) this.gridClaimAttorneys).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.maskFax).EndInit();
    ((ISupportInitialize) this.maskPhone).EndInit();
    ((ISupportInitialize) this.optEntityType).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.txtAttorneyName).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.optClaimantDefense).EndInit();
    ((ISupportInitialize) this.txtLawFirm).EndInit();
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormAttorneyManagement_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.FormAttorneyManagement_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
