// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.frmCheckOrder
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class frmCheckOrder : Form
{
  private IContainer components;
  private DataSet selectedChecks;

  private frmCheckOrder() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual UltraGrid gridPrintableChecks
  {
    get => this._gridPrintableChecks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BandEventHandler bandEventHandler = new BandEventHandler(this.gridPrintableChecks_AfterSortChange);
      UltraGrid gridPrintableChecks1 = this._gridPrintableChecks;
      if (gridPrintableChecks1 != null)
        ((UltraGridBase) gridPrintableChecks1).AfterSortChange -= bandEventHandler;
      this._gridPrintableChecks = value;
      UltraGrid gridPrintableChecks2 = this._gridPrintableChecks;
      if (gridPrintableChecks2 == null)
        return;
      ((UltraGridBase) gridPrintableChecks2).AfterSortChange += bandEventHandler;
    }
  }

  [field: AccessedThroughProperty("OpenFileDialog1")]
  internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  internal virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel4")]
  internal virtual UltraLabel ultraLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel8")]
  internal virtual UltraLabel ultraLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonUp
  {
    get => this._buttonUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUp_Click);
      MGAButton buttonUp1 = this._buttonUp;
      if (buttonUp1 != null)
        ((Control) buttonUp1).Click -= eventHandler;
      this._buttonUp = value;
      MGAButton buttonUp2 = this._buttonUp;
      if (buttonUp2 == null)
        return;
      ((Control) buttonUp2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonDown
  {
    get => this._buttonDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonDown_Click);
      MGAButton buttonDown1 = this._buttonDown;
      if (buttonDown1 != null)
        ((Control) buttonDown1).Click -= eventHandler;
      this._buttonDown = value;
      MGAButton buttonDown2 = this._buttonDown;
      if (buttonDown2 == null)
        return;
      ((Control) buttonDown2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonOk
  {
    get => this._buttonOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonOk_Click);
      MGAButton buttonOk1 = this._buttonOk;
      if (buttonOk1 != null)
        ((Control) buttonOk1).Click -= eventHandler;
      this._buttonOk = value;
      MGAButton buttonOk2 = this._buttonOk;
      if (buttonOk2 == null)
        return;
      ((Control) buttonOk2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonOk_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCheckOrder));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetPrintableChecks", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("checknum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("payeename");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("checkamt", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("IsOperating");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Select..", 0);
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("RowNum", 1);
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
    this.buttonUp = new MGAButton();
    this.buttonDown = new MGAButton();
    this.gridPrintableChecks = new UltraGrid();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.UltraLabel1 = new UltraLabel();
    this.Panel1 = new Panel();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.Label2 = new Label();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.buttonOk = new MGAButton();
    this.btnCancel = new MGAButton();
    ((ISupportInitialize) this.buttonUp).BeginInit();
    ((ISupportInitialize) this.buttonDown).BeginInit();
    ((ISupportInitialize) this.gridPrintableChecks).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.buttonUp).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonUp).Location = new Point(176 /*0xB0*/, 456);
    ((Control) this.buttonUp).Name = "buttonUp";
    ((Control) this.buttonUp).Size = new Size(88, 24);
    ((Control) this.buttonUp).TabIndex = 13;
    ((ControlBase) this.buttonUp).Text = "Up";
    this.buttonUp.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    ((ControlBase) this.buttonDown).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonDown).Location = new Point(272, 456);
    ((Control) this.buttonDown).Name = "buttonDown";
    ((Control) this.buttonDown).Size = new Size(88, 24);
    ((Control) this.buttonDown).TabIndex = 12;
    ((ControlBase) this.buttonDown).Text = "Down";
    this.buttonDown.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraControlBase) this.gridPrintableChecks).Cursor = Cursors.Hand;
    appearance3.BackColor = Color.Transparent;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Check #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 98;
    ultraGridColumn2.CellActivation = (Activation) 3;
    appearance4.FontData.BoldAsString = "False";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 320;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Check Amount";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 189;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 72;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 69;
    ultraGridColumn6.DataType = typeof (bool);
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 87;
    ultraGridColumn7.DataType = typeof (int);
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 93;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    appearance8.BackColor = Color.White;
    appearance8.FontData.BoldAsString = "True";
    appearance8.FontData.Name = "Tahoma";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance10.ForeColor = Color.Black;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((Control) this.gridPrintableChecks).Dock = DockStyle.Fill;
    ((Control) this.gridPrintableChecks).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridPrintableChecks).Location = new Point(168, 80 /*0x50*/);
    ((Control) this.gridPrintableChecks).Name = "gridPrintableChecks";
    ((Control) this.gridPrintableChecks).Size = new Size(626, 370);
    ((Control) this.gridPrintableChecks).TabIndex = 1;
    ((UltraControlBase) this.gridPrintableChecks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPrintableChecks).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.White;
    appearance13.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance13.BackGradientAlignment = (GradientAlignment) 2;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance13;
    ((Control) this.UltraLabel1).Dock = DockStyle.Left;
    ((Control) this.UltraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(168, 406);
    ((Control) this.UltraLabel1).TabIndex = 15;
    this.Panel1.BackColor = Color.White;
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.PictureBox1);
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Font = new Font("Tahoma", 8f);
    this.Panel1.ForeColor = Color.Black;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(794, 80 /*0x50*/);
    this.Panel1.TabIndex = 14;
    this.Label1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label1.Dock = DockStyle.Bottom;
    this.Label1.ForeColor = Color.FromArgb(239, 247, 253);
    this.Label1.Location = new Point(0, 79);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(794, 1);
    this.Label1.TabIndex = 5;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(24, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 4;
    this.PictureBox1.TabStop = false;
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label2.Location = new Point(594, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(192 /*0xC0*/, 19);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Check Print Order Utility";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance14.BackColor = Color.White;
    appearance14.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance14.BackGradientAlignment = (GradientAlignment) 3;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance14;
    ((Control) this.ultraLabel4).Location = new Point(8, 120);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(152, 152);
    ((Control) this.ultraLabel4).TabIndex = 17;
    ((ControlBase) this.ultraLabel4).Text = componentResourceManager.GetString("ultraLabel4.Text");
    appearance15.BackColor = Color.White;
    appearance15.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance15.BackGradientAlignment = (GradientAlignment) 2;
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance15;
    ((AutoSizeControlBase) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 96 /*0x60*/);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(155, 15);
    ((Control) this.ultraLabel8).TabIndex = 16 /*0x10*/;
    ((ControlBase) this.ultraLabel8).Text = "CHECK ORDERING UTILITY";
    this.Label3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label3.Dock = DockStyle.Left;
    this.Label3.ForeColor = Color.FromArgb(239, 247, 253);
    this.Label3.Location = new Point(168, 80 /*0x50*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(1, 370);
    this.Label3.TabIndex = 18;
    this.Label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label4.BorderStyle = BorderStyle.FixedSingle;
    this.Label4.Dock = DockStyle.Bottom;
    this.Label4.ForeColor = Color.FromArgb(239, 247, 253);
    this.Label4.Location = new Point(168, 450);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(626, 36);
    this.Label4.TabIndex = 19;
    appearance16.BackColor = Color.FromArgb(248, 248, 248);
    appearance16.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.DarkGray;
    appearance16.ImageHAlign = (HAlign) 2;
    appearance16.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonOk).Location = new Point(600, 456);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(88, 24);
    ((Control) this.buttonOk).TabIndex = 20;
    ((ControlBase) this.buttonOk).Text = "Ok";
    this.buttonOk.UseOSThemes = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.FromArgb(248, 248, 248);
    appearance17.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.DarkGray;
    appearance17.ImageHAlign = (HAlign) 2;
    appearance17.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance17;
    ((Control) this.btnCancel).Location = new Point(696, 456);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 21;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(794, 486);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.buttonOk);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.buttonUp);
    this.Controls.Add((Control) this.buttonDown);
    this.Controls.Add((Control) this.gridPrintableChecks);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.UltraLabel1);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCheckOrder);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Check Print Order";
    ((ISupportInitialize) this.buttonUp).EndInit();
    ((ISupportInitialize) this.buttonDown).EndInit();
    ((ISupportInitialize) this.gridPrintableChecks).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmCheckOrder(DataSet drRows)
  {
    this.InitializeComponent();
    this.selectedChecks = drRows;
    ((UltraGridBase) this.gridPrintableChecks).DataSource = (object) this.selectedChecks;
    this.addCustomSortColumnValues();
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Bands[0].SortedColumns.Add("RowNum", false);
  }

  private void buttonDown_Click(object sender, EventArgs e) => this.MoveRow(false);

  private void btnUp_Click(object sender, EventArgs e) => this.MoveRow(true);

  private void MoveRow(bool up)
  {
    if (this.gridPrintableChecks.Selected.Rows.Count == 0)
    {
      int num1 = (int) MessageBox.Show("You must select a check to move.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int index = this.gridPrintableChecks.Selected.Rows[0].Index;
      int num2 = index;
      if (up)
      {
        if (index - 1 >= 0)
          num2 = index - 1;
      }
      else if (index + 1 < this.selectedChecks.Tables[0].Rows.Count)
        num2 = index + 1;
      ((UltraGridBase) this.gridPrintableChecks).Rows[index].Cells["RowNum"].Value = (object) num2;
      ((UltraGridBase) this.gridPrintableChecks).Rows[num2].Cells["RowNum"].Value = (object) index;
      ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Bands[0].SortedColumns.Add("RowNum", false);
      ((UltraGridBase) this.gridPrintableChecks).Rows.EnsureSortedAndFiltered();
      this.ScrollActiveRowIntoView();
    }
  }

  private void ScrollActiveRowIntoView()
  {
    if (((UltraGridBase) this.gridPrintableChecks).ActiveRow == null)
      return;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Grid.ActiveRowScrollRegion.ScrollRowIntoView(((UltraGridBase) this.gridPrintableChecks).ActiveRow);
  }

  private void addCustomSortColumnValues()
  {
    int num = this.selectedChecks.Tables[0].Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
      ((UltraGridBase) this.gridPrintableChecks).Rows[index].Cells["RowNum"].Value = (object) index;
  }

  public UltraGrid OrderdCheckGrid => this.gridPrintableChecks;

  private void buttonOk_Click(object sender, EventArgs e)
  {
    if (sender == this.buttonOk)
      this.DialogResult = DialogResult.OK;
    else
      this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridPrintableChecks_AfterSortChange(object sender, BandEventArgs e)
  {
    this.addCustomSortColumnValues();
  }
}
