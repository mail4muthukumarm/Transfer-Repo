// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminExpensePayees
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Reporting.Attributes;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Administration;

[SecureResource("{8104A3D1-241C-4108-A819-A7B7C9AA825F}", "Access Third Party, Inspection or Finance Companies Screen", "Controls access to Third Party Payees, Inspection or Finance Companies Screen.", "Users")]
public class frmAdminExpensePayees : Form
{
  private IContainer components;
  private SqlDataAdapter da;
  private ErrorProvider err;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  public const string canViewFinanceCompaniesForm = "{8104A3D1-241C-4108-A819-A7B7C9AA825F}";
  private readonly frmAdminExpensePayees.ExpenseePayeeType _payeeType;
  private bool _duplicateSearch;
  private Dictionary<string, string> _dictColumnName;

  [field: AccessedThroughProperty("GroupBox1")]
  protected virtual UltraGroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickedNew -= eventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickedCancel -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickedNew += eventHandler2;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickedCancel += eventHandler3;
    }
  }

  protected virtual UltraGrid dg
  {
    get => this._dg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dg_AfterRowActivate);
      UltraGrid dg1 = this._dg;
      if (dg1 != null)
        dg1.AfterRowActivate -= eventHandler;
      this._dg = value;
      UltraGrid dg2 = this._dg;
      if (dg2 == null)
        return;
      dg2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  public virtual dsAdminExpensePayees ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtName
  {
    get => this._txtName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtName_ValueChanged);
      MGATextBox txtName1 = this._txtName;
      if (txtName1 != null)
        ((TextEditorControlBase) txtName1).ValueChanged -= eventHandler;
      this._txtName = value;
      MGATextBox txtName2 = this._txtName;
      if (txtName2 == null)
        return;
      ((TextEditorControlBase) txtName2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ZipCodeResolver1")]
  protected virtual AddressResolver_MULTI ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("is1099CheckBox")]
  protected virtual MGACheckBox is1099CheckBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboFinAgreement")]
  internal virtual ComboBox cboFinAgreement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRoofInspection")]
  internal virtual MGACheckBox chkRoofInspection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkMedicalProvider")]
  internal virtual MGACheckBox chkMedicalProvider { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtPayeeSearch
  {
    get => this._txtPayeeSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPayeeSearch_ValueChanged);
      MGATextBox txtPayeeSearch1 = this._txtPayeeSearch;
      if (txtPayeeSearch1 != null)
        ((TextEditorControlBase) txtPayeeSearch1).ValueChanged -= eventHandler;
      this._txtPayeeSearch = value;
      MGATextBox txtPayeeSearch2 = this._txtPayeeSearch;
      if (txtPayeeSearch2 == null)
        return;
      ((TextEditorControlBase) txtPayeeSearch2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CheckBox1")]
  protected virtual MGACheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CheckBox2")]
  protected virtual MGACheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkShowHidden
  {
    get => this._chkShowHidden;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkShowHidden_CheckedChanged);
      MGACheckBox chkShowHidden1 = this._chkShowHidden;
      if (chkShowHidden1 != null)
        ((UltraToggleEditorBase) chkShowHidden1).CheckedChanged -= eventHandler;
      this._chkShowHidden = value;
      MGACheckBox chkShowHidden2 = this._chkShowHidden;
      if (chkShowHidden2 == null)
        return;
      ((UltraToggleEditorBase) chkShowHidden2).CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminExpensePayees));
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblFin_ExpensePayees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Phone1");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Phone2");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("PayeeType");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PayFromOperating");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Hidden");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("SSN");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("TaxIdNumber");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("PayeeAcctNum");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Is1099");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("AutomationReport");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("RoofInspection");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("MedicalProvider");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance24 = new Appearance();
    this.ds = new dsAdminExpensePayees();
    this.CheckBox1 = new MGACheckBox();
    this.CheckBox2 = new MGACheckBox();
    this.chkRoofInspection = new MGACheckBox();
    this.Label9 = new Label();
    this.is1099CheckBox = new MGACheckBox();
    this.GroupBox1 = new UltraGroupBox();
    this.chkMedicalProvider = new MGACheckBox();
    this.txtName = new MGATextBox();
    this.ZipCodeResolver1 = new AddressResolver_MULTI();
    this.cboFinAgreement = new ComboBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.chkShowHidden = new MGACheckBox();
    this.dg = new UltraGrid();
    this.txtPayeeSearch = new MGATextBox();
    MGAMaskedEdit mgaMaskedEdit1 = new MGAMaskedEdit();
    MGAMaskedEdit mgaMaskedEdit2 = new MGAMaskedEdit();
    Label label1 = new Label();
    Label label2 = new Label();
    MGATextBox mgaTextBox1 = new MGATextBox();
    Label label3 = new Label();
    Label label4 = new Label();
    MGAMaskedEdit mgaMaskedEdit3 = new MGAMaskedEdit();
    Label label5 = new Label();
    Label label6 = new Label();
    MGAMaskedEdit mgaMaskedEdit4 = new MGAMaskedEdit();
    MGAMaskedEdit mgaMaskedEdit5 = new MGAMaskedEdit();
    Label label7 = new Label();
    MGATextBox mgaTextBox2 = new MGATextBox();
    Label label8 = new Label();
    Label label9 = new Label();
    ((ISupportInitialize) mgaMaskedEdit1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) mgaMaskedEdit2).BeginInit();
    ((ISupportInitialize) mgaTextBox1).BeginInit();
    ((ISupportInitialize) mgaMaskedEdit3).BeginInit();
    ((ISupportInitialize) mgaMaskedEdit4).BeginInit();
    ((ISupportInitialize) mgaMaskedEdit5).BeginInit();
    ((ISupportInitialize) mgaTextBox2).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.CheckBox2).BeginInit();
    ((ISupportInitialize) this.chkRoofInspection).BeginInit();
    ((ISupportInitialize) this.is1099CheckBox).BeginInit();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.chkMedicalProvider).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.chkShowHidden).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    ((ISupportInitialize) this.txtPayeeSearch).BeginInit();
    this.SuspendLayout();
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    mgaMaskedEdit1.Appearance = (AppearanceBase) appearance1;
    ((Control) mgaMaskedEdit1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_ExpensePayees.SSN", true));
    mgaMaskedEdit1.EditAs = (EditAsType) 1;
    mgaMaskedEdit1.InputMask = "###-##-####";
    ((Control) mgaMaskedEdit1).Location = new Point(320, 147);
    mgaMaskedEdit1.MGAStyle = MGAStyles.Blue;
    ((Control) mgaMaskedEdit1).Name = "txtSSN";
    mgaMaskedEdit1.NonAutoSizeHeight = 20;
    ((Control) mgaMaskedEdit1).Size = new Size(70, 21);
    ((Control) mgaMaskedEdit1).TabIndex = 16 /*0x10*/;
    mgaMaskedEdit1.Text = "--";
    ((UltraControlBase) mgaMaskedEdit1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaMaskedEdit1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminExpensePayees";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance2.BackColorDisabled = Color.Gainsboro;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    mgaMaskedEdit2.Appearance = (AppearanceBase) appearance2;
    ((Control) mgaMaskedEdit2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblFin_ExpensePayees.TaxIdNumber", true));
    mgaMaskedEdit2.EditAs = (EditAsType) 1;
    mgaMaskedEdit2.InputMask = "##-#######";
    ((Control) mgaMaskedEdit2).Location = new Point(320, 122);
    mgaMaskedEdit2.MGAStyle = MGAStyles.Blue;
    ((Control) mgaMaskedEdit2).Name = "txtFEIN";
    mgaMaskedEdit2.NonAutoSizeHeight = 20;
    ((Control) mgaMaskedEdit2).Size = new Size(70, 21);
    ((Control) mgaMaskedEdit2).TabIndex = 15;
    mgaMaskedEdit2.Text = "-";
    ((UltraControlBase) mgaMaskedEdit2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaMaskedEdit2).UseOsThemes = (DefaultableBoolean) 2;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(258, 121);
    label1.Name = "Label7";
    label1.Size = new Size(56, 23);
    label1.TabIndex = 14;
    label1.Text = "FEIN # :";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(258, 146);
    label2.Name = "Label6";
    label2.Size = new Size(56, 23);
    label2.TabIndex = 13;
    label2.Text = "SSN # :";
    label2.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) mgaTextBox1).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) mgaTextBox1).BackColor = Color.White;
    ((Control) mgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_ExpensePayees.Email", true));
    ((Control) mgaTextBox1).Location = new Point(320, 98);
    mgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) mgaTextBox1).Name = "txtEmail";
    ((Control) mgaTextBox1).Size = new Size(144 /*0x90*/, 20);
    ((Control) mgaTextBox1).TabIndex = 10;
    ((UltraControlBase) mgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(258, 97);
    label3.Name = "Label5";
    label3.Size = new Size(56, 23);
    label3.TabIndex = 9;
    label3.Text = "Email:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(258, 72);
    label4.Name = "Label4";
    label4.Size = new Size(56, 23);
    label4.TabIndex = 7;
    label4.Text = "Fax:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    mgaMaskedEdit3.Appearance = (AppearanceBase) appearance4;
    ((Control) mgaMaskedEdit3).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_ExpensePayees.Fax", true));
    mgaMaskedEdit3.EditAs = (EditAsType) 1;
    mgaMaskedEdit3.InputMask = "(###) ###-####";
    ((Control) mgaMaskedEdit3).Location = new Point(320, 73);
    mgaMaskedEdit3.MGAStyle = MGAStyles.Blue;
    ((Control) mgaMaskedEdit3).Name = "txtFax";
    mgaMaskedEdit3.NonAutoSizeHeight = 20;
    ((Control) mgaMaskedEdit3).Size = new Size(100, 21);
    ((Control) mgaMaskedEdit3).TabIndex = 8;
    mgaMaskedEdit3.Text = "() -";
    ((UltraControlBase) mgaMaskedEdit3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaMaskedEdit3).UseOsThemes = (DefaultableBoolean) 2;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(258, 47);
    label5.Name = "Label3";
    label5.Size = new Size(56, 23);
    label5.TabIndex = 5;
    label5.Text = "Phone 2:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(258, 22);
    label6.Name = "Label2";
    label6.Size = new Size(56, 23);
    label6.TabIndex = 3;
    label6.Text = "Phone:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    mgaMaskedEdit4.Appearance = (AppearanceBase) appearance5;
    ((Control) mgaMaskedEdit4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_ExpensePayees.Phone2", true));
    mgaMaskedEdit4.EditAs = (EditAsType) 1;
    mgaMaskedEdit4.InputMask = "(###) ###-####";
    ((Control) mgaMaskedEdit4).Location = new Point(320, 48 /*0x30*/);
    mgaMaskedEdit4.MGAStyle = MGAStyles.Blue;
    ((Control) mgaMaskedEdit4).Name = "txtPhone2";
    mgaMaskedEdit4.NonAutoSizeHeight = 20;
    ((Control) mgaMaskedEdit4).Size = new Size(100, 21);
    ((Control) mgaMaskedEdit4).TabIndex = 6;
    mgaMaskedEdit4.Text = "() -";
    ((UltraControlBase) mgaMaskedEdit4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaMaskedEdit4).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    mgaMaskedEdit5.Appearance = (AppearanceBase) appearance6;
    ((Control) mgaMaskedEdit5).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_ExpensePayees.Phone1", true));
    mgaMaskedEdit5.EditAs = (EditAsType) 1;
    mgaMaskedEdit5.InputMask = "(###) ###-####";
    ((Control) mgaMaskedEdit5).Location = new Point(320, 23);
    mgaMaskedEdit5.MGAStyle = MGAStyles.Blue;
    ((Control) mgaMaskedEdit5).Name = "txtPhone1";
    mgaMaskedEdit5.NonAutoSizeHeight = 20;
    ((Control) mgaMaskedEdit5).Size = new Size(100, 21);
    ((Control) mgaMaskedEdit5).TabIndex = 4;
    mgaMaskedEdit5.Text = "() -";
    ((UltraControlBase) mgaMaskedEdit5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaMaskedEdit5).UseOsThemes = (DefaultableBoolean) 2;
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(32 /*0x20*/, 25);
    label7.Name = "Label1";
    label7.Size = new Size(38, 13);
    label7.TabIndex = 0;
    label7.Text = "Name:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) mgaTextBox2).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) mgaTextBox2).BackColor = Color.White;
    ((Control) mgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_ExpensePayees.PayeeAcctNum", true));
    ((Control) mgaTextBox2).Location = new Point(320, 174);
    ((TextEditorControlBase) mgaTextBox2).MaxLength = 40;
    mgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) mgaTextBox2).Name = "textAccountNumber";
    ((Control) mgaTextBox2).Size = new Size(144 /*0x90*/, 20);
    ((Control) mgaTextBox2).TabIndex = 18;
    ((UltraControlBase) mgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(251, 173);
    label8.Name = "Label8";
    label8.Size = new Size(63 /*0x3F*/, 21);
    label8.TabIndex = 17;
    label8.Text = "Account #:";
    label8.TextAlign = ContentAlignment.MiddleRight;
    label9.AutoSize = true;
    label9.BackColor = Color.Transparent;
    label9.Location = new Point(5, 15);
    label9.Name = "Label10";
    label9.Size = new Size(77, 13);
    label9.TabIndex = 14;
    label9.Text = "Search Payee:";
    label9.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox1).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.CheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_ExpensePayees.PayFromOperating", true));
    ((UltraToggleEditorBase) this.CheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox1).Location = new Point(80 /*0x50*/, 195);
    this.CheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.CheckBox1).Name = "CheckBox1";
    ((Control) this.CheckBox1).Size = new Size(136, 18);
    ((Control) this.CheckBox1).TabIndex = 11;
    ((UltraToggleEditorBase) this.CheckBox1).Text = "Pay From Operating";
    ((UltraControlBase) this.CheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox2).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.CheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox2).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox2).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_ExpensePayees.Hidden", true));
    ((UltraToggleEditorBase) this.CheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox2).Location = new Point(80 /*0x50*/, 219);
    this.CheckBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.CheckBox2).Name = "CheckBox2";
    ((Control) this.CheckBox2).Size = new Size(64 /*0x40*/, 17);
    ((Control) this.CheckBox2).TabIndex = 12;
    ((UltraToggleEditorBase) this.CheckBox2).Text = "Hidden";
    ((UltraControlBase) this.CheckBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRoofInspection).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkRoofInspection).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoofInspection).BackColorInternal = Color.Transparent;
    ((Control) this.chkRoofInspection).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_ExpensePayees.RoofInspection", true));
    ((UltraToggleEditorBase) this.chkRoofInspection).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRoofInspection).Location = new Point(320, 219);
    this.chkRoofInspection.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkRoofInspection).Name = "chkRoofInspection";
    ((Control) this.chkRoofInspection).Size = new Size(122, 17);
    ((Control) this.chkRoofInspection).TabIndex = 21;
    ((UltraToggleEditorBase) this.chkRoofInspection).Text = "Roof Inspection";
    ((UltraControlBase) this.chkRoofInspection).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRoofInspection).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkRoofInspection).Visible = false;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(181, 239);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(110, 21);
    this.Label9.TabIndex = 17;
    this.Label9.Text = "Finance Agreement:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.Label9.Visible = false;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.is1099CheckBox).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.is1099CheckBox).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.is1099CheckBox).BackColorInternal = Color.Transparent;
    ((Control) this.is1099CheckBox).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_ExpensePayees.Is1099", true));
    ((UltraToggleEditorBase) this.is1099CheckBox).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.is1099CheckBox).Location = new Point(80 /*0x50*/, 244);
    this.is1099CheckBox.MGAStyle = MGAStyles.Blue;
    ((Control) this.is1099CheckBox).Name = "is1099CheckBox";
    ((Control) this.is1099CheckBox).Size = new Size(79, 16 /*0x10*/);
    ((Control) this.is1099CheckBox).TabIndex = 19;
    ((UltraToggleEditorBase) this.is1099CheckBox).Text = "Is 1099";
    ((UltraControlBase) this.is1099CheckBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.is1099CheckBox).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.is1099CheckBox).Visible = false;
    ((Control) this.GroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance12;
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkMedicalProvider);
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkRoofInspection);
    ((Control) this.GroupBox1).Controls.Add((Control) this.is1099CheckBox);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label9);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaTextBox2);
    ((Control) this.GroupBox1).Controls.Add((Control) label8);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CheckBox1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.CheckBox2);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaMaskedEdit1);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaMaskedEdit2);
    ((Control) this.GroupBox1).Controls.Add((Control) label1);
    ((Control) this.GroupBox1).Controls.Add((Control) label2);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaTextBox1);
    ((Control) this.GroupBox1).Controls.Add((Control) label3);
    ((Control) this.GroupBox1).Controls.Add((Control) label4);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaMaskedEdit3);
    ((Control) this.GroupBox1).Controls.Add((Control) label5);
    ((Control) this.GroupBox1).Controls.Add((Control) label6);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaMaskedEdit4);
    ((Control) this.GroupBox1).Controls.Add((Control) mgaMaskedEdit5);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtName);
    ((Control) this.GroupBox1).Controls.Add((Control) label7);
    ((Control) this.GroupBox1).Controls.Add((Control) this.ZipCodeResolver1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboFinAgreement);
    ((Control) this.GroupBox1).Enabled = false;
    ((Control) this.GroupBox1).Location = new Point(8, 297);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(527, 269);
    ((Control) this.GroupBox1).TabIndex = 1;
    this.GroupBox1.Text = "Entity Information";
    this.GroupBox1.ViewStyle = (GroupBoxViewStyle) 3;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkMedicalProvider).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkMedicalProvider).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkMedicalProvider).BackColorInternal = Color.Transparent;
    ((Control) this.chkMedicalProvider).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblFin_ExpensePayees.MedicalProvider", true));
    ((UltraToggleEditorBase) this.chkMedicalProvider).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkMedicalProvider).Location = new Point(320, 200);
    this.chkMedicalProvider.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkMedicalProvider).Name = "chkMedicalProvider";
    ((Control) this.chkMedicalProvider).Size = new Size(122, 17);
    ((Control) this.chkMedicalProvider).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkMedicalProvider).Text = "Medical Provider";
    ((UltraControlBase) this.chkMedicalProvider).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkMedicalProvider).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblFin_ExpensePayees.PayeeName", true));
    ((Control) this.txtName).Location = new Point(80 /*0x50*/, 23);
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(160 /*0xA0*/, 20);
    ((Control) this.txtName).TabIndex = 1;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    this.ZipCodeResolver1.Address1 = "";
    this.ZipCodeResolver1.Address2 = "";
    ((Control) this.ZipCodeResolver1).BackColor = Color.Transparent;
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.County = "";
    ((Control) this.ZipCodeResolver1).Font = new Font("Tahoma", 8f);
    this.ZipCodeResolver1.ISOCountryCode = "";
    this.ZipCodeResolver1.ISOCountryCodeMember = "";
    this.ZipCodeResolver1.ISOCountryList = (object) null;
    this.ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.ZipCodeResolver1).Location = new Point(16 /*0x10*/, 40);
    this.ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.ZipCodeResolver1).Name = "ZipCodeResolver1";
    this.ZipCodeResolver1.Password = "";
    ((Control) this.ZipCodeResolver1).Size = new Size(242, 154);
    this.ZipCodeResolver1.State = "";
    ((Control) this.ZipCodeResolver1).TabIndex = 2;
    this.ZipCodeResolver1.TextAlign = ContentAlignment.MiddleRight;
    this.ZipCodeResolver1.UserID = "";
    this.ZipCodeResolver1.WebserviceUrl = "";
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    this.cboFinAgreement.DataBindings.Add(new Binding("SelectedValue", (object) this.ds, "tblFin_ExpensePayees.AutomationReport", true));
    this.cboFinAgreement.DataSource = (object) this.ds;
    this.cboFinAgreement.DisplayMember = "FinanceAgreements.ReportName";
    this.cboFinAgreement.FormattingEnabled = true;
    this.cboFinAgreement.Location = new Point(297, 239);
    this.cboFinAgreement.Name = "cboFinAgreement";
    this.cboFinAgreement.Size = new Size(202, 21);
    this.cboFinAgreement.TabIndex = 20;
    this.cboFinAgreement.ValueMember = "FinanceAgreements.AutomationReportGuid";
    this.cboFinAgreement.Visible = false;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(543, 526);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.da.AcceptChangesDuringUpdate = false;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblFin_ExpensePayees", new DataColumnMapping[22]
      {
        new DataColumnMapping("PayeeGUID", "PayeeGUID"),
        new DataColumnMapping("PayeeName", "PayeeName"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone1", "Phone1"),
        new DataColumnMapping("Phone2", "Phone2"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("PayeeType", "PayeeType"),
        new DataColumnMapping("PayFromOperating", "PayFromOperating"),
        new DataColumnMapping("Hidden", "Hidden"),
        new DataColumnMapping("TaxIdNumber", "TaxIdNumber"),
        new DataColumnMapping("SSN", "SSN"),
        new DataColumnMapping("PayeeAcctNum", "PayeeAcctNum"),
        new DataColumnMapping("Is1099", "Is1099"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("AutomationReport", "AutomationReport"),
        new DataColumnMapping("RoofInspection", "RoofInspection")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblFin_ExpensePayees] WHERE (([PayeeGUID] = @Original_PayeeGUID))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_PayeeGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PayeeGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[23]
    {
      new SqlParameter("@PayeeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "PayeeGUID"),
      new SqlParameter("@PayeeName", SqlDbType.VarChar, 100, "PayeeName"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 55, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 55, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 60, "City"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@Zip", SqlDbType.VarChar, 25, "Zip"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Phone1", SqlDbType.VarChar, 20, "Phone1"),
      new SqlParameter("@Phone2", SqlDbType.VarChar, 20, "Phone2"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 20, "Fax"),
      new SqlParameter("@Email", SqlDbType.VarChar, 150, "Email"),
      new SqlParameter("@PayeeType", SqlDbType.Char, 3, "PayeeType"),
      new SqlParameter("@PayFromOperating", SqlDbType.Bit, 1, "PayFromOperating"),
      new SqlParameter("@Hidden", SqlDbType.Bit, 1, "Hidden"),
      new SqlParameter("@TaxIdNumber", SqlDbType.VarChar, 25, "TaxIdNumber"),
      new SqlParameter("@SSN", SqlDbType.VarChar, 25, "SSN"),
      new SqlParameter("@PayeeAcctNum", SqlDbType.VarChar, 40, "PayeeAcctNum"),
      new SqlParameter("@ISOCountryCode", SqlDbType.VarChar, 10, "ISOCountryCode"),
      new SqlParameter("@AutomationReport", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationReport"),
      new SqlParameter("@RoofInspection", SqlDbType.Bit, 1, "RoofInspection"),
      new SqlParameter("@Is1099", SqlDbType.Bit, 1, "Is1099"),
      new SqlParameter("@MedicalProvider", SqlDbType.Bit, 1, "MedicalProvider")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@PayeeType", SqlDbType.Char, 3, "PayeeType")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@PayeeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "PayeeGUID"),
      new SqlParameter("@PayeeName", SqlDbType.VarChar, 100, "PayeeName"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 55, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 55, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 60, "City"),
      new SqlParameter("@State", SqlDbType.VarChar, 2, "State"),
      new SqlParameter("@Zip", SqlDbType.VarChar, 25, "Zip"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 4, "ZipPlus"),
      new SqlParameter("@Phone1", SqlDbType.VarChar, 20, "Phone1"),
      new SqlParameter("@Phone2", SqlDbType.VarChar, 20, "Phone2"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 20, "Fax"),
      new SqlParameter("@Email", SqlDbType.VarChar, 150, "Email"),
      new SqlParameter("@PayeeType", SqlDbType.Char, 3, "PayeeType"),
      new SqlParameter("@PayFromOperating", SqlDbType.Bit, 1, "PayFromOperating"),
      new SqlParameter("@Hidden", SqlDbType.Bit, 1, "Hidden"),
      new SqlParameter("@TaxIdNumber", SqlDbType.VarChar, 25, "TaxIdNumber"),
      new SqlParameter("@SSN", SqlDbType.VarChar, 25, "SSN"),
      new SqlParameter("@PayeeAcctNum", SqlDbType.VarChar, 40, "PayeeAcctNum"),
      new SqlParameter("@ISOCountryCode", SqlDbType.VarChar, 10, "ISOCountryCode"),
      new SqlParameter("@AutomationReport", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationReport"),
      new SqlParameter("@RoofInspection", SqlDbType.Bit, 1, "RoofInspection"),
      new SqlParameter("@Is1099", SqlDbType.Bit, 1, "Is1099"),
      new SqlParameter("@MedicalProvider", SqlDbType.Bit, 1, "MedicalProvider"),
      new SqlParameter("@Original_PayeeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PayeeGUID", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.chkShowHidden).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.BorderColor = Color.Gray;
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowHidden).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkShowHidden).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowHidden).Location = new Point(551, 494);
    ((Control) this.chkShowHidden).Name = "chkShowHidden";
    ((Control) this.chkShowHidden).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.chkShowHidden).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkShowHidden).Text = "Show Hidden";
    ((UltraControlBase) this.chkShowHidden).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShowHidden).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dg).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dg).DataSource = (object) this.ds.tblFin_ExpensePayees;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 100;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 318;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 53;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 53;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 149;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 44;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 53;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 53;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 53;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 53;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 53;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 53;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = (int) sbyte.MaxValue;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 187;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 77;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 86;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Width = 42;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Width = 92;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 173;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 80 /*0x50*/;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 88;
    ultraGridBand.Columns.AddRange(new object[23]
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
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance17.BackColor = Color.LightSteelBlue;
    appearance17.FontData.SizeInPoints = 10f;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance21.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance21;
    appearance22.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.Transparent;
    appearance23.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance23;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dg).Location = new Point(8, 38);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(647, 253);
    ((Control) this.dg).TabIndex = 0;
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPayeeSearch).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.txtPayeeSearch).BackColor = Color.White;
    ((Control) this.txtPayeeSearch).Location = new Point(88, 12);
    this.txtPayeeSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPayeeSearch).Name = "txtPayeeSearch";
    ((Control) this.txtPayeeSearch).Size = new Size(196, 20);
    ((Control) this.txtPayeeSearch).TabIndex = 15;
    ((UltraControlBase) this.txtPayeeSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPayeeSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(663, 580);
    this.Controls.Add((Control) this.txtPayeeSearch);
    this.Controls.Add((Control) label9);
    this.Controls.Add((Control) this.chkShowHidden);
    this.Controls.Add((Control) this.dg);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.GroupBox1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminExpensePayees);
    this.Text = "Expense Payees Administration";
    ((ISupportInitialize) mgaMaskedEdit1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) mgaMaskedEdit2).EndInit();
    ((ISupportInitialize) mgaTextBox1).EndInit();
    ((ISupportInitialize) mgaMaskedEdit3).EndInit();
    ((ISupportInitialize) mgaMaskedEdit4).EndInit();
    ((ISupportInitialize) mgaMaskedEdit5).EndInit();
    ((ISupportInitialize) mgaTextBox2).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.CheckBox2).EndInit();
    ((ISupportInitialize) this.chkRoofInspection).EndInit();
    ((ISupportInitialize) this.is1099CheckBox).EndInit();
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.chkMedicalProvider).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.chkShowHidden).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    ((ISupportInitialize) this.txtPayeeSearch).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblFin_ExpensePayees.TableName];
  }

  private string PayeeCode
  {
    get
    {
      string payeeCode;
      switch (this._payeeType)
      {
        case frmAdminExpensePayees.ExpenseePayeeType.FinanceCompany:
          payeeCode = "FNC";
          break;
        case frmAdminExpensePayees.ExpenseePayeeType.ThirdParty:
          payeeCode = "3RD";
          break;
        case frmAdminExpensePayees.ExpenseePayeeType.InspectionCompany:
          payeeCode = "INS";
          break;
        case frmAdminExpensePayees.ExpenseePayeeType.ClaimPayees:
          payeeCode = "CLM";
          break;
        default:
          payeeCode = string.Empty;
          break;
      }
      return payeeCode;
    }
  }

  public frmAdminExpensePayees(frmAdminExpensePayees.ExpenseePayeeType payeeType)
  {
    this.Load += new EventHandler(this.frmAdminExpensePayees_Load);
    this._duplicateSearch = false;
    this._dictColumnName = new Dictionary<string, string>();
    this.InitializeComponent();
    this._payeeType = payeeType;
    this.SetupFormDefaults(payeeType);
  }

  public void SetupFormDefaults(frmAdminExpensePayees.ExpenseePayeeType payeeType)
  {
    switch (payeeType)
    {
      case frmAdminExpensePayees.ExpenseePayeeType.FinanceCompany:
        this.Text = "Finance Company Administration";
        break;
      case frmAdminExpensePayees.ExpenseePayeeType.ThirdParty:
        this.Text = "Third-Party Payees Administration";
        ((Control) this.is1099CheckBox).Visible = true;
        ((Control) this.chkMedicalProvider).Visible = true;
        break;
      case frmAdminExpensePayees.ExpenseePayeeType.InspectionCompany:
        this.Text = "Inspection Company Administration";
        ((Control) this.chkRoofInspection).Visible = true;
        break;
      case frmAdminExpensePayees.ExpenseePayeeType.ClaimPayees:
        this.Text = "Claim Payees Administration";
        ((Control) this.is1099CheckBox).Visible = true;
        break;
    }
  }

  public frmAdminExpensePayees()
  {
    this.Load += new EventHandler(this.frmAdminExpensePayees_Load);
    this._duplicateSearch = false;
    this._dictColumnName = new Dictionary<string, string>();
    this.InitializeComponent();
  }

  private void frmAdminExpensePayees_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections((DbDataAdapter) this.da, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.da.SelectCommand.Parameters["@PayeeType"].Value = (object) this.PayeeCode;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblFin_ExpensePayees);
    this.ds.tblFin_ExpensePayees.DefaultView.RowFilter = "Hidden=0";
    this.dbSave.UIState = this.ds.tblFin_ExpensePayees.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    if (this._payeeType == frmAdminExpensePayees.ExpenseePayeeType.FinanceCompany)
    {
      Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new FinanceAgreementAttribute());
      int index = 0;
      while (index < typeArray.Length)
      {
        AutomationReportAttribute automationReportAttribute = typeArray[index].GetCustomAttributes(typeof (AutomationReportAttribute), false).OfType<AutomationReportAttribute>().FirstOrDefault<AutomationReportAttribute>();
        if (automationReportAttribute != null && this.ds.FinanceAgreements.FindByAutomationReportGuid(automationReportAttribute.AutomationReportGuid) == null)
        {
          this.ds.FinanceAgreements.AddFinanceAgreementsRow(automationReportAttribute.AutomationReportGuid, automationReportAttribute.Title);
          this.cboFinAgreement.Visible = true;
          this.Label9.Visible = true;
        }
        checked { ++index; }
      }
    }
    this.LoadOnClient();
  }

  protected virtual void LoadOnClient()
  {
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int position = this.bmb.Position;
    this.ds.tblFin_ExpensePayees[this.bmb.Position].Delete();
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblFin_ExpensePayees);
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      this.ds.tblFin_ExpensePayees[position].RejectChanges();
      this.bmb.Position = position;
      if (ex2.Number == 547)
      {
        if (MessageBox.Show("This entity is currently in use.\n\nWould you like to hide them from future selection?", "Hide In-Use Entity?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          this.ds.tblFin_ExpensePayees[this.bmb.Position].Hidden = true;
          try
          {
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblFin_ExpensePayees);
          }
          catch (SqlException ex3)
          {
            ProjectData.SetProjectError((Exception) ex3);
            ErrorHandler.HandleError((Exception) ex3);
            ProjectData.ClearProjectError();
          }
        }
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex4)
    {
      ProjectData.SetProjectError(ex4);
      Exception ex5 = ex4;
      this.ds.tblFin_ExpensePayees[position].RejectChanges();
      this.bmb.Position = position;
      ErrorHandler.HandleError(ex5);
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dg).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.GroupBox1).Enabled = this.dbSave.UIState == UIState.Editing;
  }

  private void dg_AfterRowActivate(object sender, EventArgs e)
  {
    Database.MoveTo((object) (Guid) ((UltraGridBase) this.dg).ActiveRow.Cells["PayeeGuid"].Value, "PayeeGuid", (DataTable) this.ds.tblFin_ExpensePayees, this.bmb);
    this.UpdateZipCode();
  }

  public void UpdateZipCode()
  {
    this.ZipCodeResolver1.Address1 = "";
    this.ZipCodeResolver1.Address2 = "";
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.State = "";
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsISOCountryCodeNull())
      this.ZipCodeResolver1.ISOCountryCode = this.ds.tblFin_ExpensePayees[this.bmb.Position].ISOCountryCode;
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsZipNull())
      this.ZipCodeResolver1.ZipCode = this.ds.tblFin_ExpensePayees[this.bmb.Position].Zip;
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsAddress1Null())
      this.ZipCodeResolver1.Address1 = this.ds.tblFin_ExpensePayees[this.bmb.Position].Address1;
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsAddress2Null())
      this.ZipCodeResolver1.Address2 = this.ds.tblFin_ExpensePayees[this.bmb.Position].Address2;
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsCityNull())
      this.ZipCodeResolver1.City = this.ds.tblFin_ExpensePayees[this.bmb.Position].City;
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsStateNull())
      this.ZipCodeResolver1.State = this.ds.tblFin_ExpensePayees[this.bmb.Position].State;
    if (!this.ds.tblFin_ExpensePayees[this.bmb.Position].IsZipPlusNull())
      this.ZipCodeResolver1.ZipCodeExtension = this.ds.tblFin_ExpensePayees[this.bmb.Position].ZipPlus;
    this.ZipCodeResolver1.County = string.Empty;
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    dsAdminExpensePayees.tblFin_ExpensePayeesRow row = this.ds.tblFin_ExpensePayees.NewtblFin_ExpensePayeesRow();
    row.PayeeGuid = Guid.NewGuid();
    row.PayeeType = this.PayeeCode;
    this.ds.tblFin_ExpensePayees.AddtblFin_ExpensePayeesRow(row);
    Database.MoveTo((object) row.PayeeGuid, "PayeeGuid", (DataTable) this.ds.tblFin_ExpensePayees, this.bmb);
    ((TextEditorControlBase) this.txtName).Focus();
    this.ZipCodeResolver1.ISOCountryCode = "";
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.Address1 = "";
    this.ZipCodeResolver1.Address2 = "";
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.State = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    this._duplicateSearch = true;
    this.ClearControlsOnClient();
  }

  protected virtual void ClearControlsOnClient()
  {
  }

  private bool IsValid()
  {
    bool flag = true;
    this.err.SetError((Control) this.txtName, string.Empty);
    if (((TextEditorControlBase) this.txtName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtName, "Please enter the name of this payee.");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValid())
    {
      e.Cancel = true;
    }
    else
    {
      bool newRow = this.ds.tblFin_ExpensePayees[this.bmb.Position].RowState == DataRowState.Added;
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].ISOCountryCode = this.ZipCodeResolver1.ISOCountryCode;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].Zip = this.ZipCodeResolver1.ZipCode;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].Address1 = this.ZipCodeResolver1.Address1;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].Address2 = this.ZipCodeResolver1.Address2;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].City = this.ZipCodeResolver1.City;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].State = this.ZipCodeResolver1.State;
        this.ds.tblFin_ExpensePayees[this.bmb.Position].ZipPlus = this.ZipCodeResolver1.ZipCodeExtension;
        this.bmb.EndCurrentEdit();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblFin_ExpensePayees);
        this.ClientClickSave();
        this.GetFriendlyColumns();
        this.LogChanges(this.ds.tblFin_ExpensePayees[this.bmb.Position], newRow);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
  }

  protected virtual void ClientClickSave()
  {
  }

  private void chkShowHidden_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkShowHidden).Checked)
      this.ds.tblFin_ExpensePayees.DefaultView.RowFilter = string.Empty;
    else
      this.ds.tblFin_ExpensePayees.DefaultView.RowFilter = "Hidden=0";
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblFin_ExpensePayees.RejectChanges();
  }

  private void GetFriendlyColumns()
  {
    this._dictColumnName.Clear();
    this._dictColumnName.Add("PayeeName", this._payeeType.ToString() + " Name");
    this._dictColumnName.Add("PayeeAcctNum", this._payeeType.ToString() + " Account #");
    this._dictColumnName.Add("Address1", this._payeeType.ToString() + " Address");
    this._dictColumnName.Add("Address2", this._payeeType.ToString() + " Address 2");
    this._dictColumnName.Add("City", this._payeeType.ToString() + " City");
    this._dictColumnName.Add("State", this._payeeType.ToString() + " State");
    this._dictColumnName.Add("Zip", this._payeeType.ToString() + " Zip");
    this._dictColumnName.Add("ZipPlus", this._payeeType.ToString() + " Zip Ext.");
    this._dictColumnName.Add("Phone1", this._payeeType.ToString() + " Phone #1");
    this._dictColumnName.Add("Phone2", this._payeeType.ToString() + " Phone # 2");
    this._dictColumnName.Add("Fax", this._payeeType.ToString() + " Fax");
    this._dictColumnName.Add("Email", this._payeeType.ToString() + " Email");
    this._dictColumnName.Add("PayeeType", this._payeeType.ToString() + " Type");
    this._dictColumnName.Add("PayFromOperating", this._payeeType.ToString() + " Pay From Operating");
    this._dictColumnName.Add("TaxIdNumber", this._payeeType.ToString() + " Tax ID #");
    this._dictColumnName.Add("SSN", this._payeeType.ToString() + " SSN");
    this._dictColumnName.Add("Is1099", this._payeeType.ToString() + " 1099");
    this._dictColumnName.Add("AutomationReport", "Finance Agreement");
    this._dictColumnName.Add("MedicalProvider", this._payeeType.ToString() + " MedicalProvider");
  }

  private void LogChanges(dsAdminExpensePayees.tblFin_ExpensePayeesRow dr, bool newRow)
  {
    if (newRow)
    {
      CurrentUser.Instance.LogAction($"Add New {this._payeeType.ToString()}: {dr.PayeeName}");
    }
    else
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblFin_ExpensePayees.Columns)
        {
          string empty1 = string.Empty;
          string empty2 = string.Empty;
          string empty3 = string.Empty;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr[column.ColumnName, DataRowVersion.Original].ToString(), dr[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
          {
            if (dr[column.ColumnName] != DBNull.Value)
              empty1 = dr[column.ColumnName, DataRowVersion.Current].ToString();
            if (dr[column.ColumnName, DataRowVersion.Original] != DBNull.Value)
              empty2 = dr[column.ColumnName, DataRowVersion.Original].ToString();
            if (this._dictColumnName.ContainsKey(column.ColumnName))
              empty3 = this._dictColumnName[column.ColumnName];
            CurrentUser.Instance.LogAction($"Change {empty3} from '{empty2}' to '{empty1}'");
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
  }

  protected virtual void ScreenForDuplicatePayees(string SearchString)
  {
  }

  private void txtName_ValueChanged(object sender, EventArgs e)
  {
    if (!this._duplicateSearch)
      return;
    this.ScreenForDuplicatePayees(((TextEditorControlBase) this.txtName).Text);
  }

  private void txtPayeeSearch_ValueChanged(object sender, EventArgs e)
  {
    this.ds.tblFin_ExpensePayees.DefaultView.RowFilter = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPayeeSearch).Text, string.Empty, false) == 0 ? string.Empty : $"PayeeName Like '%{((TextEditorControlBase) this.txtPayeeSearch).Value.ToString()}%'";
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public enum ExpenseePayeeType
  {
    FinanceCompany,
    ThirdParty,
    InspectionCompany,
    ClaimPayees,
  }
}
