// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Classes.frmAdminRatingClasses
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
using System.Collections;
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
namespace MGASystems.IMS.Policies.Rating.Classes;

[SecureResource("{97BC8D33-FF47-44f8-83ED-A69F0A2D0B7F}", "Ability to access Policy Classes", "Controls whether or not users have the security to access Policy Classes screen.", "Rating")]
public sealed class frmAdminRatingClasses : Form
{
  private IContainer components;
  private UltraGroupBox GroupBox1;
  private dsAdminRatingClasses ds;
  private Label Label1;
  private MGATextBox txtClassCode;
  private MGATextBox txtDescription;
  private Label Label2;
  private ErrorProvider err;
  private Label Label5;
  private ToolTip ToolTip1;
  private MGAComboBox cboSIC_Codes;
  public const string CanViewRatingClassForm = "{97BC8D33-FF47-44f8-83ED-A69F0A2D0B7F}";

  public frmAdminRatingClasses()
  {
    this.Load += new EventHandler(this.frmAdminRatingClasses_Load);
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

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.UIStateChanged -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.UIStateChanged += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("chkWorkersComp")]
  internal virtual CheckBox chkWorkersComp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("WCClassCode");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstSIC_Codes", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SIC_Description");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("SIC_Family_Description");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("lstSIC_CodeslstClassCodes");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstSIC_CodeslstClassCodes", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("WCClassCode");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    this.ug = new UltraGrid();
    this.ds = new dsAdminRatingClasses();
    this.GroupBox1 = new UltraGroupBox();
    this.chkWorkersComp = new CheckBox();
    this.cboSIC_Codes = new MGAComboBox();
    this.Label5 = new Label();
    this.txtDescription = new MGATextBox();
    this.Label2 = new Label();
    this.txtClassCode = new MGATextBox();
    this.Label1 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    this.ToolTip1 = new ToolTip(this.components);
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.cboSIC_Codes).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.txtClassCode).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.lstClassCodes;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 88;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Class Code";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 131;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 169;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "SIC Code";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 135;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Worker's Comp";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ug).Location = new Point(8, 8);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(558, 353);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminRatingClasses";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.GroupBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.GroupBox1).Controls.Add((Control) this.chkWorkersComp);
    ((Control) this.GroupBox1).Controls.Add((Control) this.cboSIC_Codes);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label5);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtDescription);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtClassCode);
    ((Control) this.GroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.GroupBox1).Enabled = false;
    ((Control) this.GroupBox1).Location = new Point(8, 367);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(425, 121);
    ((Control) this.GroupBox1).TabIndex = 2;
    this.chkWorkersComp.AutoSize = true;
    this.chkWorkersComp.Checked = true;
    this.chkWorkersComp.CheckState = CheckState.Checked;
    this.chkWorkersComp.DataBindings.Add(new Binding("Checked", (object) this.ds, "lstClassCodes.WCClassCode", true));
    this.chkWorkersComp.Location = new Point(80 /*0x50*/, 91);
    this.chkWorkersComp.Name = "chkWorkersComp";
    this.chkWorkersComp.Size = new Size(98, 17);
    this.chkWorkersComp.TabIndex = 50;
    this.chkWorkersComp.Text = "Worker's Comp";
    this.chkWorkersComp.UseVisualStyleBackColor = true;
    this.cboSIC_Codes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSIC_Codes).DataBindings.Add(new Binding("Value", (object) this.ds, "lstClassCodes.SIC_Code", true));
    ((UltraGridBase) this.cboSIC_Codes).DataSource = (object) this.ds.lstSIC_Codes;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboSIC_Codes.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.cboSIC_Codes.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Width = 130;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 123;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Width = 178;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    this.cboSIC_Codes.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboSIC_Codes.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboSIC_Codes.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboSIC_Codes.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboSIC_Codes.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance11.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance11.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboSIC_Codes.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.White;
    this.cboSIC_Codes.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.cboSIC_Codes.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance13.ForeColor = Color.Black;
    this.cboSIC_Codes.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboSIC_Codes.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboSIC_Codes).DisplayMember = "SIC_Description";
    this.cboSIC_Codes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSIC_Codes).DropDownWidth = 450;
    ((Control) this.cboSIC_Codes).Location = new Point(80 /*0x50*/, 64 /*0x40*/);
    this.cboSIC_Codes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSIC_Codes).Name = "cboSIC_Codes";
    ((Control) this.cboSIC_Codes).Size = new Size(232, 21);
    ((Control) this.cboSIC_Codes).TabIndex = 9;
    this.ToolTip1.SetToolTip((Control) this.cboSIC_Codes, "The Standard Industrial Classification (SIC) code associated with this class.");
    ((UltraControlBase) this.cboSIC_Codes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSIC_Codes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSIC_Codes).ValueMember = "SIC_Code";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(16 /*0x10*/, 66);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(56, 13);
    this.Label5.TabIndex = 8;
    this.Label5.Text = "SIC Code:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "lstClassCodes.ClassCodeDescription", true));
    ((Control) this.txtDescription).Location = new Point(80 /*0x50*/, 40);
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(232, 20);
    ((Control) this.txtDescription).TabIndex = 3;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(6, 42);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Description:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtClassCode).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.txtClassCode).BackColor = Color.White;
    ((Control) this.txtClassCode).DataBindings.Add(new Binding("Text", (object) this.ds, "lstClassCodes.ClassCode", true));
    ((Control) this.txtClassCode).Location = new Point(80 /*0x50*/, 16 /*0x10*/);
    this.txtClassCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtClassCode).Name = "txtClassCode";
    ((Control) this.txtClassCode).Size = new Size(100, 20);
    ((Control) this.txtClassCode).TabIndex = 1;
    ((UltraControlBase) this.txtClassCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClassCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Class Code:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(447, 447);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 5;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(574, 492);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminRatingClasses);
    this.Text = "Rating Class Administration";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.cboSIC_Codes).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.txtClassCode).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.lstClassCodes.TableName];
  }

  private void frmAdminRatingClasses_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstSIC_Codes"
    }, CommandType.Text, "SELECT lstSIC_Codes.SIC_Code, lstSIC_Codes.SIC_Description, lstSIC_Families.SIC_Family_Description FROM lstSIC_Codes INNER JOIN lstSIC_Families ON lstSIC_Codes.SIC_Familiy_Code = lstSIC_Families.SIC_Family_Code ORDER BY lstSIC_Codes.SIC_Code, lstSIC_Codes.SIC_Description");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstClassCodes"
    }, CommandType.Text, "SELECT ClassCodeID, ClassCode, ClassCodeDescription, SIC_Code, WCClassCode FROM lstClassCodes ORDER BY ClassCodeDescription");
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.ds.lstClassCodes.AddlstClassCodesRow(this.ds.lstClassCodes.NewlstClassCodesRow());
    this.bmb.Position = this.ds.lstClassCodes.Count - 1;
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
      {
        if (control is MGAComboBox)
          ((UltraDropDownBase) control).SelectedRow = (UltraGridRow) null;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.lstClassCodes.RejectChanges();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.IsValidForm())
    {
      this.bmb.EndCurrentEdit();
      this.SaveData(e);
    }
    else
      e.Cancel = true;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this class code?", "Delete Class Code?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.ds.lstClassCodes[this.bmb.Position].Delete();
    this.SaveData(e);
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ug).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.GroupBox1).Enabled = this.dbSave.UIState == UIState.Editing;
  }

  private bool IsValidForm()
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) this.GroupBox1).Controls)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, string.Empty, false) == 0)
        {
          this.err.SetError(control, "Required");
          flag = false;
        }
        else
          this.err.SetError(control, string.Empty);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.err.GetError((Control) this.txtClassCode).Length == 0)
    {
      if (((TextEditorControlBase) this.txtClassCode).Text.Length != 5)
      {
        this.err.SetError((Control) this.txtClassCode, "Must be 5 characters");
        flag = false;
      }
      else
        this.err.SetError((Control) this.txtClassCode, string.Empty);
    }
    return flag;
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    try
    {
      Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ug).ActiveRow.Cells["ClassCodeID"].Value), "ClassCodeID", (DataTable) this.ds.lstClassCodes, this.bmb);
    }
    catch (DeletedRowInaccessibleException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    if (this.dbSave.UIState == UIState.Editing)
      return;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void SaveData(CancelEventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.SaveData();
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("FK_tblUnderwritingLocations_lstClassCodes"))
      {
        int num = (int) MessageBox.Show("There are underlying location(s) tied to this class code.", "Cannot Update Record", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      else
      {
        ErrorHandler.HandleError((Exception) ex2);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void SaveData()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.lstClassCodes, "dbo.InsertClassCodes", "dbo.UpdateClassCodes", "dbo.DeleteClassCodes", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.lstClassCodes);
  }
}
