// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.frmWarranties
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[SecureResource("{A76DA255-606F-4d6a-86C3-1070D69678E4}", "Access Warranties Screen", "Controls access to Warranties Screen.", "Policies")]
public sealed class frmWarranties : Form
{
  private IContainer components;
  private Label Label1;
  private MGATextBox txtWarranty;
  private MGAGroupBox GroupBox1;
  private Label Label2;
  private MGATextBox TextBox1;
  private MGAListBox lstAssociatedForms;
  private Label Label3;
  private DbDataAdapter daWarranties;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private DbDataAdapter daWarrantyForms;
  private DbCommand DbSelectCommand2;
  private DbCommand DbInsertCommand2;
  private DbCommand DbUpdateCommand2;
  private DbCommand DbDeleteCommand2;
  private DbDataAdapter daForms;
  private DbCommand DbSelectCommand3;
  private dsWarranties ds;
  private ErrorProvider err;
  private DbConnection _cn;
  public const string canViewWarrantiesForm = "{A76DA255-606F-4d6a-86C3-1070D69678E4}";

  public frmWarranties()
  {
    this.Load += new EventHandler(this.frmWarranties_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ug_AfterRowActivate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ug1.AfterRowActivate -= eventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowActivate += eventHandler;
    }
  }

  private virtual LinkLabel lnkAddForm
  {
    get => this._lnkAddForm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddForm_LinkClicked);
      LinkLabel lnkAddForm1 = this._lnkAddForm;
      if (lnkAddForm1 != null)
        lnkAddForm1.LinkClicked -= clickedEventHandler;
      this._lnkAddForm = value;
      LinkLabel lnkAddForm2 = this._lnkAddForm;
      if (lnkAddForm2 == null)
        return;
      lnkAddForm2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.UIStateChanged -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.UIStateChanged += eventHandler3;
    }
  }

  private virtual LinkLabel lnkRemoveForm
  {
    get => this._lnkRemoveForm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRemoveForm_LinkClicked);
      LinkLabel lnkRemoveForm1 = this._lnkRemoveForm;
      if (lnkRemoveForm1 != null)
        lnkRemoveForm1.LinkClicked -= clickedEventHandler;
      this._lnkRemoveForm = value;
      LinkLabel lnkRemoveForm2 = this._lnkRemoveForm;
      if (lnkRemoveForm2 == null)
        return;
      lnkRemoveForm2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblWarranties", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("WarrantyName");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("tblWarrantiestblWarrantyForms");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblWarrantiestblWarrantyForms", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("FormName");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmWarranties));
    Appearance appearance16 = new Appearance();
    this.Label1 = new Label();
    this.ug = new UltraGrid();
    this.ds = new dsWarranties();
    this.txtWarranty = new MGATextBox();
    this.GroupBox1 = new MGAGroupBox();
    this.lnkRemoveForm = new LinkLabel();
    this.lnkAddForm = new LinkLabel();
    this.Label3 = new Label();
    this.lstAssociatedForms = new MGAListBox();
    this.Label2 = new Label();
    this.TextBox1 = new MGATextBox();
    this.daWarranties = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.daWarrantyForms = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand2 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand2 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand2 = DefaultDatabase.CreateCommand();
    this.daForms = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtWarranty).BeginInit();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.lstAssociatedForms).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(18, 34);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(87, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Warranty Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblWarranties;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 139;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Warranty";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 296;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 311;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 142;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 154;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Forms";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 588;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(8, 8);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(628, 187);
    ((Control) this.ug).TabIndex = 1;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsWarranties";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtWarranty).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtWarranty).BackColor = Color.White;
    ((Control) this.txtWarranty).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWarranties.WarrantyName", true));
    ((Control) this.txtWarranty).Location = new Point(112 /*0x70*/, 32 /*0x20*/);
    ((TextEditorControlBase) this.txtWarranty).MaxLength = 500;
    this.txtWarranty.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtWarranty).Name = "txtWarranty";
    ((Control) this.txtWarranty).Size = new Size(490, 20);
    ((Control) this.txtWarranty).TabIndex = 2;
    ((UltraControlBase) this.txtWarranty).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtWarranty).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.GroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.GroupBox1).Appearance = (AppearanceBase) appearance13;
    ((UltraGroupBox) this.GroupBox1).BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance14.BackColor = Color.FromArgb(239, 247, 253);
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.GroupBox1).ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.GroupBox1).Controls.Add((Control) this.lnkRemoveForm);
    ((Control) this.GroupBox1).Controls.Add((Control) this.lnkAddForm);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.GroupBox1).Controls.Add((Control) this.lstAssociatedForms);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.TextBox1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtWarranty);
    ((Control) this.GroupBox1).Enabled = false;
    appearance15.AlphaLevel = (short) 230;
    appearance15.FontData.SizeInPoints = 10f;
    appearance15.ForeColor = Color.White;
    appearance15.ForegroundAlpha = (Alpha) 2;
    appearance15.ImageAlpha = (Alpha) 2;
    appearance15.ImageBackground = (Image) componentResourceManager.GetObject("Appearance16.ImageBackground");
    appearance15.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    ((UltraGroupBox) this.GroupBox1).HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.GroupBox1).Location = new Point(12, 201);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(628, 256 /*0x0100*/);
    ((Control) this.GroupBox1).TabIndex = 3;
    ((UltraGroupBox) this.GroupBox1).Text = "Warranty Information";
    ((UltraGroupBox) this.GroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    this.lnkRemoveForm.BackColor = Color.Transparent;
    this.lnkRemoveForm.Location = new Point(436, 186);
    this.lnkRemoveForm.Name = "lnkRemoveForm";
    this.lnkRemoveForm.Size = new Size(136, 23);
    this.lnkRemoveForm.TabIndex = 8;
    this.lnkRemoveForm.TabStop = true;
    this.lnkRemoveForm.Text = "Remove Associated Form";
    this.lnkRemoveForm.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkAddForm.BackColor = Color.Transparent;
    this.lnkAddForm.Location = new Point(436, 162);
    this.lnkAddForm.Name = "lnkAddForm";
    this.lnkAddForm.Size = new Size(120, 23);
    this.lnkAddForm.TabIndex = 7;
    this.lnkAddForm.TabStop = true;
    this.lnkAddForm.Text = "Add Associated Form";
    this.lnkAddForm.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(10, 152);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(95, 13);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Associated Forms:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((ListControl) this.lstAssociatedForms).DataSource = (object) this.ds.tblWarrantyForms;
    ((ListControl) this.lstAssociatedForms).DisplayMember = "FormName";
    ((Control) this.lstAssociatedForms).Location = new Point(112 /*0x70*/, 152);
    this.lstAssociatedForms.MGAStyle = (MGAStyles) 2;
    ((Control) this.lstAssociatedForms).Name = "lstAssociatedForms";
    ((Control) this.lstAssociatedForms).Size = new Size(303, 93);
    ((Control) this.lstAssociatedForms).TabIndex = 5;
    ((ListControl) this.lstAssociatedForms).ValueMember = "PolicyFormID";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(40, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Description:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox1).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.TextBox1).BackColor = Color.White;
    ((Control) this.TextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblWarranties.Description", true));
    ((Control) this.TextBox1).Location = new Point(112 /*0x70*/, 56);
    this.TextBox1.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.TextBox1).Multiline = true;
    ((Control) this.TextBox1).Name = "TextBox1";
    ((Control) this.TextBox1).Size = new Size(490, 88);
    ((Control) this.TextBox1).TabIndex = 4;
    ((UltraControlBase) this.TextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.daWarranties.DeleteCommand = this.DbDeleteCommand1;
    this.daWarranties.InsertCommand = this.DbInsertCommand1;
    this.daWarranties.SelectCommand = this.DbSelectCommand1;
    this.daWarranties.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblWarranties", new DataColumnMapping[3]
      {
        new DataColumnMapping("WarrantyID", "WarrantyID"),
        new DataColumnMapping("WarrantyName", "WarrantyName"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.daWarranties.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = componentResourceManager.GetString("DbDeleteCommand1.CommandText");
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@Original_WarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Description", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Description", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_WarrantyName", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyName", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = "INSERT INTO tblWarranties(WarrantyName, Description) VALUES (@WarrantyName, @Description); SELECT WarrantyID, WarrantyName, Description FROM tblWarranties WHERE (WarrantyID = @@IDENTITY)";
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@WarrantyName", SqlDbType.VarChar, 500, "WarrantyName"),
      DefaultDatabase.CreateParameter("@Description", SqlDbType.VarChar, 2000, "Description")
    });
    this.DbSelectCommand1.CommandText = "SELECT WarrantyID, WarrantyName, Description FROM tblWarranties ORDER BY WarrantyName";
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@WarrantyName", SqlDbType.VarChar, 500, "WarrantyName"),
      DefaultDatabase.CreateParameter("@Description", SqlDbType.VarChar, 2000, "Description"),
      DefaultDatabase.CreateParameter("@Original_WarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Description", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Description", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_WarrantyName", SqlDbType.VarChar, 500, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyName", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@WarrantyID", SqlDbType.Int, 4, "WarrantyID")
    });
    this.daWarrantyForms.DeleteCommand = this.DbDeleteCommand2;
    this.daWarrantyForms.InsertCommand = this.DbInsertCommand2;
    this.daWarrantyForms.SelectCommand = this.DbSelectCommand2;
    this.daWarrantyForms.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblWarrantyForms", new DataColumnMapping[2]
      {
        new DataColumnMapping("WarrantyID", "WarrantyID"),
        new DataColumnMapping("PolicyFormID", "PolicyFormID")
      })
    });
    this.daWarrantyForms.UpdateCommand = this.DbUpdateCommand2;
    this.DbDeleteCommand2.CommandText = "DELETE FROM tblWarrantyForms WHERE (PolicyFormID = @Original_PolicyFormID) AND (WarrantyID = @Original_WarrantyID)";
    this.DbDeleteCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_PolicyFormID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyFormID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_WarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand2.CommandText = componentResourceManager.GetString("DbInsertCommand2.CommandText");
    this.DbInsertCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@WarrantyID", SqlDbType.Int, 4, "WarrantyID"),
      DefaultDatabase.CreateParameter("@PolicyFormID", SqlDbType.Int, 4, "PolicyFormID")
    });
    this.DbSelectCommand2.CommandText = "SELECT tblWarrantyForms.WarrantyID, tblWarrantyForms.PolicyFormID, tblPolicyForms.FormName FROM tblWarrantyForms INNER JOIN tblPolicyForms ON tblWarrantyForms.PolicyFormID = tblPolicyForms.FormID";
    this.DbUpdateCommand2.CommandText = componentResourceManager.GetString("DbUpdateCommand2.CommandText");
    this.DbUpdateCommand2.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@WarrantyID", SqlDbType.Int, 4, "WarrantyID"),
      DefaultDatabase.CreateParameter("@PolicyFormID", SqlDbType.Int, 4, "PolicyFormID"),
      DefaultDatabase.CreateParameter("@Original_PolicyFormID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyFormID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_WarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyID", DataRowVersion.Original, (object) null)
    });
    this.daForms.SelectCommand = this.DbSelectCommand3;
    this.daForms.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPolicyForms", new DataColumnMapping[2]
      {
        new DataColumnMapping("FormID", "FormID"),
        new DataColumnMapping("FormName", "FormName")
      })
    });
    this.DbSelectCommand3.CommandText = "SELECT FormID, FormName FROM tblPolicyForms";
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(524, 481);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 4;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(644, 527);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmWarranties);
    this.Text = "Warranties Administration";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtWarranty).EndInit();
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.lstAssociatedForms).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblWarranties.TableName];
  }

  private void frmWarranties_Load(object sender, EventArgs e)
  {
    this._cn = DefaultDatabase.CreateDbConnection();
    Utility.SetDataAdapterConnections(this.daForms, this._cn, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daWarranties, this._cn, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daWarrantyForms, this._cn, (DbTransaction) null);
    DefaultDatabase.DataAdapterFill(this.daWarranties, (DataTable) this.ds.tblWarranties);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblPolicyForms"
    }, CommandType.Text, "SELECT FormID, FormName FROM tblPolicyForms ORDER BY FormName");
    DefaultDatabase.DataAdapterFill(this.daWarrantyForms, (DataTable) this.ds.tblWarrantyForms);
    ((UltraGridBase) this.ug).Rows.ExpandAll(true);
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    dsWarranties.tblWarrantiesRow row = this.ds.tblWarranties.NewtblWarrantiesRow();
    this.ds.tblWarranties.AddtblWarrantiesRow(row);
    this.ds.tblWarrantyForms.DefaultView.RowFilter = "WarrantyID=" + row.WarrantyID.ToString();
    this.bmb.Position = this.ds.tblWarranties.Count - 1;
  }

  private bool IsValidForm()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtWarranty).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtWarranty, "Please enter the name of this warranty.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtWarranty, string.Empty);
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidForm())
      return;
    this.bmb.EndCurrentEdit();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (executeTransactionSender, executeTransactionArgs) =>
    {
      DefaultDatabase.DataAdapterUpdate(this.daWarranties, (DataTable) this.ds.tblWarranties);
      DefaultDatabase.DataAdapterUpdate(this.daWarrantyForms, (DataTable) this.ds.tblWarrantyForms);
      executeTransactionArgs.Transaction.Commit();
    }));
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblWarrantyForms.RejectChanges();
    this.ds.tblWarranties.RejectChanges();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a warranty in order to continue deletion.", "Cannot Delete Warranty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CompanyLineID FROM dbo.tblCompanyFormsConditionsWarranties WITH (NOLOCK) WHERE WarrantyID = @ID", new object[2]
      {
        (object) "@ID",
        (object) this.ds.tblWarranties[this.bmb.Position].WarrantyID
      }));
      if (objectValue != null && objectValue != DBNull.Value)
      {
        int num = (int) MessageBox.Show("Cannot delete this warranty because it is applied to a company/line", "Cannot Delete Warranty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        e.Cancel = true;
      }
      else
      {
        if (MessageBox.Show("Are you sure you want to delete this warranty?", "Delete Warranty?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          return;
        this.ds.tblWarranties[this.bmb.Position].Delete();
        try
        {
          Cursor.Current = MgaCursors.WaitCursor;
          DefaultDatabase.DataAdapterUpdate(this.daWarrantyForms, (DataTable) this.ds.tblWarrantyForms);
          DefaultDatabase.DataAdapterUpdate(this.daWarranties, (DataTable) this.ds.tblWarranties);
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          SqlException sqlException = ex;
          if (sqlException.Message.Contains("FK_tblCompanyFormsConditionsWarranties_tblWarranties"))
          {
            int num = (int) MessageBox.Show("Cannot delete this warranty because it is applied to a company/line", "Cannot Delete Warranty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            e.Cancel = true;
            ProjectData.ClearProjectError();
          }
          else
          {
            ErrorHandler.HandleError((Exception) sqlException);
            e.Cancel = true;
            ProjectData.ClearProjectError();
          }
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
      }
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ug).Enabled = this.dbSave.UIState != 2;
    ((Control) this.GroupBox1).Enabled = this.dbSave.UIState == 2;
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ug).ActiveRow.Cells["WarrantyID"].Value), "WarrantyID", (DataTable) this.ds.tblWarranties, this.bmb);
    this.ds.tblWarrantyForms.DefaultView.RowFilter = "WarrantyID=" + this.ds.tblWarranties[this.bmb.Position].WarrantyID.ToString();
    if (this.dbSave.UIState == 2)
      return;
    this.dbSave.UIState = (UIState) 1;
  }

  private void lnkAddForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmAddWarrantyForm frmAddWarrantyForm = (frmAddWarrantyForm) FormSettings.ShowFormDialog(typeof (frmAddWarrantyForm)))
    {
      if (!frmAddWarrantyForm.Saved)
        return;
      int warrantyId = this.ds.tblWarranties[this.bmb.Position].WarrantyID;
      if (this.ds.tblWarrantyForms.Select($"WarrantyID={warrantyId.ToString()} AND PolicyFormID={Conversions.ToString(frmAddWarrantyForm.FormID)}").Length == 0)
      {
        dsWarranties.tblWarrantyFormsRow row = this.ds.tblWarrantyForms.NewtblWarrantyFormsRow();
        row.PolicyFormID = frmAddWarrantyForm.FormID;
        row.FormName = frmAddWarrantyForm.FormName;
        row.WarrantyID = warrantyId;
        this.ds.tblWarrantyForms.AddtblWarrantyFormsRow(row);
      }
      else
      {
        int num = (int) MessageBox.Show("This form already exists for this warranty.", "Form Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
  }

  private void lnkRemoveForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to remove this associated form?", "Remove Form?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.ds.tblWarrantyForms.FindByWarrantyIDPolicyFormID(this.ds.tblWarranties[this.bmb.Position].WarrantyID, Conversions.ToInteger(((ListControl) this.lstAssociatedForms).SelectedValue)).Delete();
  }
}
