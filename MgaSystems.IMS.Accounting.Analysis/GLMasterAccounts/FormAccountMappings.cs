// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormAccountMappings
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Analysis.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormAccountMappings : FormBase
{
  private IContainer components;
  private MGASimpleComboBox comboGLCompany;
  private Label label1;
  private MGAGroupBox mgaGroupBox1;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private UltraDropDown dropDownAutomationSettingList;
  private UltraGrid gridCurrentExceptionSettings;
  private UltraDropDown dropDownCarrier;
  private UltraDropDown dropDownGLAccounts;

  public FormAccountMappings() => this.InitializeComponent();

  private void FormAccountMappings_Load(object sender, EventArgs e)
  {
    this.LoadOfficeLocations();
    this.LoadAutomationSettingList();
    this.LoadCarrierList();
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboGLCompany).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboGLCompany).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompany).ValueMember = "ID";
  }

  private void LoadAutomationSettingList()
  {
    ((UltraGridBase) this.dropDownAutomationSettingList).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetAccountMasterAutomationSettingsList");
    ((UltraDropDownBase) this.dropDownAutomationSettingList).DisplayMember = "AutomationSetting";
    ((UltraDropDownBase) this.dropDownAutomationSettingList).ValueMember = "AutomationSettingId";
    this.FormatDropDown(this.dropDownAutomationSettingList, 250, "AutomationSettingId");
    foreach (UltraGridRow row in ((UltraGridBase) this.dropDownAutomationSettingList).Rows)
    {
      if (row.Cells["AutomationSetting"].Value.ToString() != "Commission Income" && row.Cells["AutomationSetting"].Value.ToString() != "Fee Commission Income")
        row.Hidden = true;
    }
  }

  private void LoadCarrierList()
  {
    ((UltraGridBase) this.dropDownCarrier).DataSource = (object) DefaultDatabase.ExecuteDataSet("GetCompanyList");
    ((UltraDropDownBase) this.dropDownCarrier).DisplayMember = "CompanyName";
    ((UltraDropDownBase) this.dropDownCarrier).ValueMember = "CompanyGuid";
    this.FormatDropDown(this.dropDownCarrier, 300, "CompanyGuid");
  }

  private void LoadGLAccountList()
  {
    if (((UltraDropDownBase) this.comboGLCompany).SelectedRow == null)
      return;
    ((UltraGridBase) this.dropDownGLAccounts).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetGLAccountList", new object[2]
    {
      (object) "@glCompanyId",
      this.comboGLCompany.Value
    });
    ((UltraDropDownBase) this.dropDownGLAccounts).DisplayMember = "FullName";
    ((UltraDropDownBase) this.dropDownGLAccounts).ValueMember = "GLAcctId";
    this.FormatDropDown(this.dropDownGLAccounts, 300, "GLAcctId", "AcctClassName", "AcctNum");
  }

  private void FormatDropDown(
    UltraDropDown dropDown,
    int dropDownWidth,
    params string[] hideColumns)
  {
    ((UltraDropDownBase) dropDown).DropDownWidth = dropDownWidth;
    ((UltraGridBase) dropDown).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) dropDown).DisplayLayout.Override.CellAppearance.BorderColor = Color.White;
    UltraGridBand band = ((UltraGridBase) dropDown).DisplayLayout.Bands[0];
    band.ColHeadersVisible = false;
    if (hideColumns.Length == 0)
      return;
    foreach (string hideColumn in hideColumns)
      band.Columns[hideColumn].Hidden = true;
  }

  private void LoadCurrentSettings(int glCompanyId)
  {
    ((UltraGridBase) this.gridCurrentExceptionSettings).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetAutomationSettingExceptions", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    });
    this.FormatCurrentExceptionGrid();
  }

  private void FormatCurrentExceptionGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Bands[0];
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    band.Columns["AutomationCode"].Style = (ColumnStyle) 6;
    band.Columns["AutomationCode"].ValueList = (IValueList) this.dropDownAutomationSettingList;
    band.Columns["AutomationCode"].Width = 250;
    ((HeaderBase) band.Columns["CompanyGuid"].Header).Caption = "Company";
    band.Columns["CompanyGuid"].Style = (ColumnStyle) 6;
    band.Columns["CompanyGuid"].ValueList = (IValueList) this.dropDownCarrier;
    band.Columns["CompanyGuid"].Width = 300;
    ((HeaderBase) band.Columns["glAcctId"].Header).Caption = "GL Account";
    band.Columns["glAcctId"].Style = (ColumnStyle) 6;
    band.Columns["glAcctId"].ValueList = (IValueList) this.dropDownGLAccounts;
    band.Columns["glAcctId"].Width = 300;
    band.Columns["CompanyName"].Hidden = true;
  }

  private void comboGLCompany_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboGLCompany).SelectedRow == null || (int) this.comboGLCompany.Value == -1)
      return;
    this.LoadCurrentSettings((int) this.comboGLCompany.Value);
    this.LoadGLAccountList();
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboGLCompany).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select an offic elocation to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((execSender, execArgs) =>
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridCurrentExceptionSettings).Rows)
        {
          if (!this.ValidateGridRow(row))
          {
            int num2 = (int) MessageBox.Show("You must enter all the fields in the grid.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            execArgs.Transaction.Rollback();
            return;
          }
          this.SaveAutomationSetting((int) this.comboGLCompany.Value, row.Cells["AutomationCode"].Value.ToString(), (int) row.Cells["glacctid"].Value, new Guid(row.Cells["companyGuid"].Value.ToString()));
        }
        execArgs.Transaction.Commit();
        int num3 = (int) MessageBox.Show("Settings saved successfully.", "Save Complete!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }));
  }

  private void SaveAutomationSetting(
    int glCompanyId,
    string automationCode,
    int glAccountId,
    Guid companyGuid)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_InsertAutomationException", new object[10]
    {
      (object) "@glcompanyId",
      (object) glCompanyId,
      (object) "@automationCode",
      (object) automationCode,
      (object) "@glAcctId",
      (object) glAccountId,
      (object) "@companyGuid",
      (object) companyGuid,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  private bool ValidateGridRow(UltraGridRow ugr)
  {
    return ugr.Cells["automationCode"].Value != DBNull.Value && ugr.Cells["AutomationCode"].Value != null && ugr.Cells["companyGuid"].Value != DBNull.Value && ugr.Cells["companyGuid"].Value != null && ugr.Cells["glacctid"].Value != DBNull.Value && ugr.Cells["glacctid"].Value != null;
  }

  private void gridCurrentExceptionSettings_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["CompanyGuid"].Value == DBNull.Value)
    {
      int num = (int) MessageBox.Show("You must specify a carrier to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
    else if (e.Row.Cells["AutomationCode"].Value == DBNull.Value)
    {
      int num = (int) MessageBox.Show("You must specify an automation code to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (e.Row.Cells["GLAcctId"].Value != DBNull.Value)
        return;
      int num = (int) MessageBox.Show("You must specify a GL account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
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
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    this.comboGLCompany = new MGASimpleComboBox();
    this.label1 = new Label();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.gridCurrentExceptionSettings = new UltraGrid();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.dropDownAutomationSettingList = new UltraDropDown();
    this.dropDownCarrier = new UltraDropDown();
    this.dropDownGLAccounts = new UltraDropDown();
    ((ISupportInitialize) this.comboGLCompany).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.gridCurrentExceptionSettings).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.dropDownAutomationSettingList).BeginInit();
    ((ISupportInitialize) this.dropDownCarrier).BeginInit();
    ((ISupportInitialize) this.dropDownGLAccounts).BeginInit();
    this.SuspendLayout();
    this.comboGLCompany.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboGLCompany).DropDownWidth = 300;
    ((Control) this.comboGLCompany).Location = new Point(6, 25);
    this.comboGLCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompany).Name = "comboGLCompany";
    ((Control) this.comboGLCompany).Size = new Size(400, 21);
    ((Control) this.comboGLCompany).TabIndex = 6;
    ((UltraControlBase) this.comboGLCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.comboGLCompany.RowSelected += new RowSelectedEventHandler(this.comboGLCompany_RowSelected);
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(3, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(83, 13);
    this.label1.TabIndex = 7;
    this.label1.Text = "Office Location:";
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    this.mgaGroupBox1.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.gridCurrentExceptionSettings);
    ((Control) this.mgaGroupBox1).ForeColor = Color.Black;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    this.mgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.mgaGroupBox1).Location = new Point(6, 52);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(645, 289);
    ((Control) this.mgaGroupBox1).TabIndex = 8;
    ((Control) this.mgaGroupBox1).Text = "Current Mappings";
    this.mgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 1;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 5;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridCurrentExceptionSettings).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridCurrentExceptionSettings).Location = new Point(7, 20);
    ((Control) this.gridCurrentExceptionSettings).Name = "gridCurrentExceptionSettings";
    this.gridCurrentExceptionSettings.RowUpdateCancelAction = (RowUpdateCancelAction) 1;
    ((Control) this.gridCurrentExceptionSettings).Size = new Size(627, 263);
    ((Control) this.gridCurrentExceptionSettings).TabIndex = 0;
    this.gridCurrentExceptionSettings.UpdateMode = (UpdateMode) 3;
    ((UltraControlBase) this.gridCurrentExceptionSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCurrentExceptionSettings).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCurrentExceptionSettings.BeforeRowUpdate += new CancelableRowEventHandler(this.gridCurrentExceptionSettings_BeforeRowUpdate);
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance13).Image = (object) Resources.disk;
    ((AppearanceBase) appearance13).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance13;
    ((Control) this.buttonSave).Location = new Point(439, 347);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(108, 28);
    ((Control) this.buttonSave).TabIndex = 9;
    ((Control) this.buttonSave).Text = "&Save Changes";
    ((UltraControlBase) this.buttonSave).UseAppStyling = false;
    ((UltraControlBase) this.buttonSave).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance14).Image = (object) Resources.delete;
    ((AppearanceBase) appearance14).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance14).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonCancel).Location = new Point(553, 347);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(98, 28);
    ((Control) this.buttonCancel).TabIndex = 10;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseAppStyling = false;
    ((UltraControlBase) this.buttonCancel).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance15).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance15).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance16).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance16).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance17;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance18).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance18).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance18).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance19).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance19).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance20).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance21).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BorderColor = Color.Silver;
    ((AppearanceBase) appearance22).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance23).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance23).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance23).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance23).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance23).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance25).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance25).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownAutomationSettingList).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dropDownAutomationSettingList).Location = new Point(6, 341);
    ((Control) this.dropDownAutomationSettingList).Name = "dropDownAutomationSettingList";
    ((Control) this.dropDownAutomationSettingList).Size = new Size(172, 18);
    ((Control) this.dropDownAutomationSettingList).TabIndex = 11;
    ((Control) this.dropDownAutomationSettingList).Text = "ultraDropDown1";
    ((Control) this.dropDownAutomationSettingList).Visible = false;
    ((AppearanceBase) appearance27).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance27).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Appearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance28).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance28).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCarrier).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance29;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCarrier).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance30).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance30).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance30).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance30).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance31).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance31).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance32).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance33).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BorderColor = Color.Silver;
    ((AppearanceBase) appearance34).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance35).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance35).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance35).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance35).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance35).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance37).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance37).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance38).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownCarrier).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dropDownCarrier).Location = new Point(6, 360);
    ((Control) this.dropDownCarrier).Name = "dropDownCarrier";
    ((Control) this.dropDownCarrier).Size = new Size(172, 17);
    ((Control) this.dropDownCarrier).TabIndex = 12;
    ((Control) this.dropDownCarrier).Text = "ultraDropDown1";
    ((Control) this.dropDownCarrier).Visible = false;
    ((AppearanceBase) appearance39).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance39).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance40).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance40).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance40).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance40).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance41;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance42).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance42).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance42).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance42).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance43).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance43).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance44).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance45).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BorderColor = Color.Silver;
    ((AppearanceBase) appearance46).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance47).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance47).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance47).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance47).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance47).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance49).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance49).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance50).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownGLAccounts).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dropDownGLAccounts).Location = new Point(184, 341);
    ((Control) this.dropDownGLAccounts).Name = "dropDownGLAccounts";
    ((Control) this.dropDownGLAccounts).Size = new Size(172, 18);
    ((Control) this.dropDownGLAccounts).TabIndex = 13;
    ((Control) this.dropDownGLAccounts).Text = "ultraDropDown1";
    ((Control) this.dropDownGLAccounts).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(652, 378);
    this.ControlBox = false;
    this.Controls.Add((Control) this.dropDownGLAccounts);
    this.Controls.Add((Control) this.dropDownCarrier);
    this.Controls.Add((Control) this.comboGLCompany);
    this.Controls.Add((Control) this.dropDownAutomationSettingList);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormAccountMappings);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Automation Account Mapping Exceptions";
    this.Load += new EventHandler(this.FormAccountMappings_Load);
    ((ISupportInitialize) this.comboGLCompany).EndInit();
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.gridCurrentExceptionSettings).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.dropDownAutomationSettingList).EndInit();
    ((ISupportInitialize) this.dropDownCarrier).EndInit();
    ((ISupportInitialize) this.dropDownGLAccounts).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
