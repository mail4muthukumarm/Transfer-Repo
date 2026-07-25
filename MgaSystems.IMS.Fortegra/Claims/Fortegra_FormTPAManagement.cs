// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Claims.Fortegra_FormTPAManagement
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

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
using MgaSystems.Ims.Fortegra.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Claims;

[SecureResource("{09E07D3A-9425-413E-A593-D63D0DAC426F}", "Claims TPA Management", "Determines whether or not a user can access the Claims TPA Management screen.", "Fortegra")]
public class Fortegra_FormTPAManagement : FormBase
{
  public const string CLAIM_TPAMANAGEMENT = "{09E07D3A-9425-413E-A593-D63D0DAC426F}";
  private int _currentTPAId = -1;
  private IContainer components;
  private UltraGrid gridClaimsTPA;
  private UltraGroupBox ultraGroupBox1;
  private Label label1;
  private MGATextBox textTPAName;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private MGASimpleComboBox comboGLAccount;
  private Label label2;
  private AddressResolver_MULTI addressResolver;
  private MGAMaskedEdit maskEmail;
  private Label label5;
  private MGAMaskedEdit maskFax;
  private Label label4;
  private MGAMaskedEdit maskPhone;
  private Label label3;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel Greyhawk_FormTPAManagement_Fill_Panel;
  private UltraToolbarsDockArea _Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top;

  public Fortegra_FormTPAManagement() => this.InitializeComponent();

  private void GetGLAccountList()
  {
    ((UltraGridBase) this.comboGLAccount).DataSource = (object) DefaultDatabase.ExecuteDataTable("Fortegra_spFin_GetGLAccountList");
    ((UltraDropDownBase) this.comboGLAccount).DisplayMember = "DisplayMember";
    ((UltraDropDownBase) this.comboGLAccount).ValueMember = "GLAcctId";
  }

  private void Greyhawk_FormTPAManagement_Load(object sender, EventArgs e)
  {
    this.GetTPAList();
    this.GetGLAccountList();
  }

  private void GetTPAList()
  {
    ((UltraGridBase) this.gridClaimsTPA).DataSource = (object) DefaultDatabase.ExecuteDataTable("Fortegra_GetClaimTPAList");
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Bands[0].Columns)
    {
      column.CellActivation = (Activation) 3;
      if (((KeyedSubObjectBase) column).Key.ToUpper() == "TPA_NAME")
        ((HeaderBase) column.Header).Caption = "TPA Name";
      else if (((KeyedSubObjectBase) column).Key.ToUpper() == "FULLNAME")
        ((HeaderBase) column.Header).Caption = "Loss Fund Account";
      else
        column.Hidden = true;
    }
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Bands[0].Override.CellClickAction = (CellClickAction) 2;
  }

  private void ClearScreen()
  {
    ((Control) this.textTPAName).Text = string.Empty;
    this.addressResolver.Clear();
    this.maskPhone.Value = (object) null;
    this.maskFax.Value = (object) null;
    this.maskEmail.Value = (object) null;
    this.comboGLAccount.Value = (object) null;
    ((Control) this.comboGLAccount).ResetText();
    ((UltraControlBase) this.gridClaimsTPA).BeginUpdate();
    ((UltraGridBase) this.gridClaimsTPA).DataSource = (object) null;
    this.GetTPAList();
    ((UltraControlBase) this.gridClaimsTPA).EndUpdate();
    this._currentTPAId = -1;
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.ClearScreen();

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((SparseCollectionBase) this.gridClaimsTPA.Selected.Rows).Count == 0)
    {
      int num = (int) MessageBox.Show("You must selected a claims TPA to continue.", "Selection Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
      {
        case "EDIT":
          this.EditTPA();
          break;
        case "DELETE":
          this.DeleteTPA();
          break;
      }
    }
  }

  private void EditTPA()
  {
    UltraGridRow row = this.gridClaimsTPA.Selected.Rows[0];
    this._currentTPAId = (int) row.Cells["tpaid"].Value;
    ((Control) this.textTPAName).Text = row.Cells["tpa_name"].Value.ToString();
    if (row.Cells["ISOCountryCode"].Value != DBNull.Value)
      this.addressResolver.ISOCountryCode = row.Cells["ISOCountryCode"].Value.ToString();
    if (row.Cells["address1"].Value != DBNull.Value)
      this.addressResolver.Address1 = row.Cells["address1"].Value.ToString();
    if (row.Cells["address2"].Value != DBNull.Value)
      this.addressResolver.Address2 = row.Cells["address2"].Value.ToString();
    if (row.Cells["city"].Value != DBNull.Value)
      this.addressResolver.City = row.Cells["city"].Value.ToString();
    if (row.Cells["state"].Value != DBNull.Value)
      this.addressResolver.State = row.Cells["state"].Value.ToString();
    if (row.Cells["zipCode"].Value != DBNull.Value)
      this.addressResolver.ZipCode = row.Cells["zipCode"].Value.ToString();
    if (row.Cells["county"].Value != DBNull.Value)
      this.addressResolver.County = row.Cells["county"].Value.ToString();
    if (row.Cells["phone"].Value != DBNull.Value)
      this.maskPhone.Value = row.Cells["phone"].Value;
    if (row.Cells["fax"].Value != DBNull.Value)
      this.maskFax.Value = row.Cells["fax"].Value;
    if (row.Cells["email"].Value != DBNull.Value)
      this.maskEmail.Value = row.Cells["email"].Value;
    if (row.Cells["glacctid"].Value == DBNull.Value)
      return;
    this.comboGLAccount.Value = row.Cells["glacctid"].Value;
  }

  private void DeleteTPA()
  {
    if (((SparseCollectionBase) this.gridClaimsTPA.Selected.Rows).Count == 0)
    {
      int num = (int) MessageBox.Show("You must select a TPA to perform this action.", "Selection Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._currentTPAId = (int) this.gridClaimsTPA.Selected.Rows[0].Cells["tpaid"].Value;
      DefaultDatabase.ExecuteNonQuery("dbo.Fortegra_DeleteClaimTPA", new object[2]
      {
        (object) "@TPAID",
        (object) this._currentTPAId
      });
      this.ClearScreen();
      this.GetTPAList();
    }
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    DefaultDatabase.ExecuteNonQuery("dbo.Fortegra_SaveClaimTPA", new object[26]
    {
      (object) "@TPAID",
      (object) (this._currentTPAId == -1 ? SqlInt32.Null : (SqlInt32) this._currentTPAId),
      (object) "@TPA_Name",
      (object) ((Control) this.textTPAName).Text,
      (object) "@ISOCountryCode",
      (object) this.addressResolver.ISOCountryCode,
      (object) "@Address1",
      (object) this.addressResolver.Address1,
      (object) "@Address2",
      (object) this.addressResolver.Address2,
      (object) "@City",
      (object) this.addressResolver.City,
      (object) "@State",
      (object) this.addressResolver.State,
      (object) "@ZipCode",
      (object) this.addressResolver.ZipCode,
      (object) "@County",
      (object) this.addressResolver.County,
      (object) "@Phone",
      (object) ((Control) this.maskPhone).Text,
      (object) "@Fax",
      (object) ((Control) this.maskFax).Text,
      (object) "@Email",
      (object) ((Control) this.maskEmail).Text,
      (object) "@GLAcctId",
      this.comboGLAccount.Value
    });
    this.ClearScreen();
  }

  private bool ValidateForm()
  {
    if (!string.IsNullOrEmpty(((Control) this.textTPAName).Text))
      return true;
    int num = (int) MessageBox.Show("You must specify a TPA name to continue", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
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
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("GRIDCONTEXT");
    ButtonTool buttonTool1 = new ButtonTool("EDIT");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    ButtonTool buttonTool3 = new ButtonTool("EDIT");
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("DELETE");
    Appearance appearance19 = new Appearance();
    this.gridClaimsTPA = new UltraGrid();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.maskEmail = new MGAMaskedEdit();
    this.label5 = new Label();
    this.maskFax = new MGAMaskedEdit();
    this.label4 = new Label();
    this.maskPhone = new MGAMaskedEdit();
    this.label3 = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.comboGLAccount = new MGASimpleComboBox();
    this.label2 = new Label();
    this.textTPAName = new MGATextBox();
    this.addressResolver = new AddressResolver_MULTI();
    this.label1 = new Label();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.Greyhawk_FormTPAManagement_Fill_Panel = new UltraPanel();
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridClaimsTPA).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.maskEmail).BeginInit();
    ((ISupportInitialize) this.maskFax).BeginInit();
    ((ISupportInitialize) this.maskPhone).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.comboGLAccount).BeginInit();
    ((ISupportInitialize) this.textTPAName).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridClaimsTPA, "GRIDCONTEXT");
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridClaimsTPA).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridClaimsTPA).Location = new Point(391, 12);
    ((Control) this.gridClaimsTPA).Name = "gridClaimsTPA";
    ((Control) this.gridClaimsTPA).Size = new Size(539, 426);
    ((Control) this.gridClaimsTPA).TabIndex = 1;
    ((UltraControlBase) this.gridClaimsTPA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimsTPA).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance10;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.maskEmail);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label5);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.maskFax);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label4);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.maskPhone);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label3);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.comboGLAccount);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label2);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textTPAName);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.addressResolver);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label1);
    ((AppearanceBase) appearance11).Image = (object) Resources.house_link;
    this.ultraGroupBox1.HeaderAppearance = (AppearanceBase) appearance11;
    ((Control) this.ultraGroupBox1).Location = new Point(7, 2);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(380, 435);
    ((Control) this.ultraGroupBox1).TabIndex = 0;
    ((Control) this.ultraGroupBox1).Text = "TPA Information";
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskEmail.Appearance = (AppearanceBase) appearance12;
    this.maskEmail.EditAs = (EditAsType) 1;
    this.maskEmail.InputMask = "<Aaaaaaaaaa@Aaaaaaaaaaaa.AAa";
    ((Control) this.maskEmail).Location = new Point(78, 250);
    this.maskEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskEmail).Name = "maskEmail";
    this.maskEmail.NonAutoSizeHeight = 21;
    ((Control) this.maskEmail).Size = new Size(176 /*0xB0*/, 21);
    ((Control) this.maskEmail).TabIndex = 9;
    ((Control) this.maskEmail).Text = "() -";
    ((UltraControlBase) this.maskEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(6, 253);
    this.label5.Name = "label5";
    this.label5.Size = new Size(35, 13);
    this.label5.TabIndex = 8;
    this.label5.Text = "Email:";
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskFax.Appearance = (AppearanceBase) appearance13;
    this.maskFax.DataMode = (MaskMode) 0;
    this.maskFax.EditAs = (EditAsType) 1;
    this.maskFax.InputMask = "(###) ###-####";
    ((Control) this.maskFax).Location = new Point(78, 225);
    this.maskFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskFax).Name = "maskFax";
    this.maskFax.NonAutoSizeHeight = 21;
    ((Control) this.maskFax).Size = new Size(100, 21);
    ((Control) this.maskFax).TabIndex = 7;
    ((Control) this.maskFax).Text = "() -";
    ((UltraControlBase) this.maskFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskFax).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(6, 228);
    this.label4.Name = "label4";
    this.label4.Size = new Size(29, 13);
    this.label4.TabIndex = 6;
    this.label4.Text = "Fax:";
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.maskPhone.Appearance = (AppearanceBase) appearance14;
    this.maskPhone.DataMode = (MaskMode) 0;
    this.maskPhone.EditAs = (EditAsType) 1;
    this.maskPhone.InputMask = "(###) ###-####";
    ((Control) this.maskPhone).Location = new Point(78, 202);
    this.maskPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.maskPhone).Name = "maskPhone";
    this.maskPhone.NonAutoSizeHeight = 21;
    ((Control) this.maskPhone).Size = new Size(100, 21);
    ((Control) this.maskPhone).TabIndex = 5;
    ((Control) this.maskPhone).Text = "() -";
    ((UltraControlBase) this.maskPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(6, 205);
    this.label3.Name = "label3";
    this.label3.Size = new Size(41, 13);
    this.label3.TabIndex = 4;
    this.label3.Text = "Phone:";
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance15).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance15).Image = (object) Resources.delete;
    ((AppearanceBase) appearance15).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance15).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance15;
    ((Control) this.buttonCancel).Location = new Point(264, 314);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(100, 24);
    ((Control) this.buttonCancel).TabIndex = 0;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance16).Image = (object) Resources.disk;
    ((AppearanceBase) appearance16).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance16).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonSave).Location = new Point(158, 314);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(100, 24);
    ((Control) this.buttonSave).TabIndex = 12;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.comboGLAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLAccount.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboGLAccount).DropDownWidth = 475;
    ((Control) this.comboGLAccount).Location = new Point(78, 275);
    this.comboGLAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLAccount).Name = "comboGLAccount";
    ((Control) this.comboGLAccount).Size = new Size(286, 21);
    ((Control) this.comboGLAccount).TabIndex = 11;
    ((UltraControlBase) this.comboGLAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(6, 275);
    this.label2.Name = "label2";
    this.label2.Size = new Size(59, 13);
    this.label2.TabIndex = 10;
    this.label2.Text = "Loss Fund:";
    ((AppearanceBase) appearance17).BackColor = Color.White;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTPAName).Appearance = (AppearanceBase) appearance17;
    ((Control) this.textTPAName).BackColor = Color.White;
    ((Control) this.textTPAName).Location = new Point(78, 34);
    this.textTPAName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textTPAName).Name = "textTPAName";
    ((Control) this.textTPAName).Size = new Size(286, 20);
    ((Control) this.textTPAName).TabIndex = 1;
    ((UltraControlBase) this.textTPAName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTPAName).UseOsThemes = (DefaultableBoolean) 2;
    this.addressResolver.Address1 = "";
    this.addressResolver.Address2 = "";
    ((Control) this.addressResolver).BackColor = Color.Transparent;
    this.addressResolver.City = "";
    this.addressResolver.County = "";
    ((Control) this.addressResolver).Font = new Font("Tahoma", 8f);
    ((Control) this.addressResolver).ForeColor = Color.Black;
    this.addressResolver.ISOCountryCode = "";
    this.addressResolver.ISOCountryCodeMember = "";
    this.addressResolver.ISOCountryList = (object) null;
    this.addressResolver.ISOCountryNameMember = "";
    ((Control) this.addressResolver).Location = new Point(-1, 50);
    this.addressResolver.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressResolver).Name = "addressResolver";
    this.addressResolver.Password = (string) null;
    ((Control) this.addressResolver).Size = new Size((int) byte.MaxValue, 152);
    this.addressResolver.State = "";
    ((Control) this.addressResolver).TabIndex = 2;
    this.addressResolver.TextAlign = ContentAlignment.TopLeft;
    this.addressResolver.UserID = (string) null;
    this.addressResolver.WebserviceUrl = (string) null;
    this.addressResolver.ZipCode = "";
    this.addressResolver.ZipCodeExtension = "";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(6, 34);
    this.label1.Name = "label1";
    this.label1.Size = new Size(60, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "TPA Name:";
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance18).Image = (object) Resources.tab_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Edit Claim TPA";
    ((AppearanceBase) appearance19).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Delete Claim TPA";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.ultraGroupBox1);
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.gridClaimsTPA);
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).Location = new Point(0, 0);
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).Name = "Greyhawk_FormTPAManagement_Fill_Panel";
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).Size = new Size(936, 443);
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).TabIndex = 0;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left).Name = "_Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left";
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 443);
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right).Location = new Point(936, 0);
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right).Name = "_Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right";
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 443);
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top).Name = "_Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top";
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top).Size = new Size(936, 0);
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 443);
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom).Name = "_Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom).Size = new Size(936, 0);
    this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(936, 443);
    this.Controls.Add((Control) this.Greyhawk_FormTPAManagement_Fill_Panel);
    this.Controls.Add((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._Greyhawk_FormTPAManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Fortegra_FormTPAManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims TPA Management";
    this.Load += new EventHandler(this.Greyhawk_FormTPAManagement_Load);
    ((ISupportInitialize) this.gridClaimsTPA).EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.maskEmail).EndInit();
    ((ISupportInitialize) this.maskFax).EndInit();
    ((ISupportInitialize) this.maskPhone).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.comboGLAccount).EndInit();
    ((ISupportInitialize) this.textTPAName).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.Greyhawk_FormTPAManagement_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
