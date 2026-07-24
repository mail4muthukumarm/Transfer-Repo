// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmPrintLabels
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class frmPrintLabels : Form
{
  private IContainer components;
  private Label Label4;
  private NumericUpDown nudNumberOfLabelPagesToPrint;
  private Label Label3;
  private NumericUpDown nudLabelsDown;
  private Label Label2;
  private NumericUpDown nudLabelsAcross;
  private RichTextBox rtbAddress;
  private GroupBox GroupBox1;
  private Label Label7;
  private Label Label6;
  private Label Label5;
  private Label Label1;
  private GroupBox GroupBox2;
  private Label Label8;
  private SqlDataAdapter SqlDataAdapter1;
  private SqlCommand SqlSelectCommand1;
  private NumericUpDown nudLabelWidth;
  private NumericUpDown nudLabelHeight;
  private Label Label9;
  private Label Label10;
  private NumericUpDown nudSideMargin;
  private NumericUpDown nudTopMargin;
  private NumericUpDown nudHorizontalPitch;
  private NumericUpDown nudVerticalPitch;
  private dsLabels.tblLabelSheetsDataTable _labelTypes;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnPrint
  {
    get => this._btnPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      MGAButton btnPrint1 = this._btnPrint;
      if (btnPrint1 != null)
        ((Control) btnPrint1).Click -= eventHandler;
      this._btnPrint = value;
      MGAButton btnPrint2 = this._btnPrint;
      if (btnPrint2 == null)
        return;
      ((Control) btnPrint2).Click += eventHandler;
    }
  }

  private virtual PrintDocument labelDoc
  {
    get => this._labelDoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PrintPageEventHandler pageEventHandler = new PrintPageEventHandler(this.labelDoc_PrintPage);
      PrintDocument labelDoc1 = this._labelDoc;
      if (labelDoc1 != null)
        labelDoc1.PrintPage -= pageEventHandler;
      this._labelDoc = value;
      PrintDocument labelDoc2 = this._labelDoc;
      if (labelDoc2 == null)
        return;
      labelDoc2.PrintPage += pageEventHandler;
    }
  }

  private virtual MGAButton btnFont
  {
    get => this._btnFont;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFont_Click);
      MGAButton btnFont1 = this._btnFont;
      if (btnFont1 != null)
        ((Control) btnFont1).Click -= eventHandler;
      this._btnFont = value;
      MGAButton btnFont2 = this._btnFont;
      if (btnFont2 == null)
        return;
      ((Control) btnFont2).Click += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboLabelTypes
  {
    get => this._cboLabelTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboLabelTypes_ValueChanged);
      MGASimpleComboBox cboLabelTypes1 = this._cboLabelTypes;
      if (cboLabelTypes1 != null)
        cboLabelTypes1.ValueChanged -= eventHandler;
      this._cboLabelTypes = value;
      MGASimpleComboBox cboLabelTypes2 = this._cboLabelTypes;
      if (cboLabelTypes2 == null)
        return;
      cboLabelTypes2.ValueChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label4 = new Label();
    this.nudNumberOfLabelPagesToPrint = new NumericUpDown();
    this.Label3 = new Label();
    this.nudLabelsDown = new NumericUpDown();
    this.Label2 = new Label();
    this.nudLabelsAcross = new NumericUpDown();
    this.btnPrint = new MGAButton();
    this.labelDoc = new PrintDocument();
    this.rtbAddress = new RichTextBox();
    this.GroupBox1 = new GroupBox();
    this.nudHorizontalPitch = new NumericUpDown();
    this.nudVerticalPitch = new NumericUpDown();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.nudLabelWidth = new NumericUpDown();
    this.nudLabelHeight = new NumericUpDown();
    this.nudSideMargin = new NumericUpDown();
    this.nudTopMargin = new NumericUpDown();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label1 = new Label();
    this.GroupBox2 = new GroupBox();
    this.btnFont = new MGAButton();
    this.cboLabelTypes = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.SqlDataAdapter1 = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.nudNumberOfLabelPagesToPrint.BeginInit();
    this.nudLabelsDown.BeginInit();
    this.nudLabelsAcross.BeginInit();
    this.GroupBox1.SuspendLayout();
    this.nudHorizontalPitch.BeginInit();
    this.nudVerticalPitch.BeginInit();
    this.nudLabelWidth.BeginInit();
    this.nudLabelHeight.BeginInit();
    this.nudSideMargin.BeginInit();
    this.nudTopMargin.BeginInit();
    this.GroupBox2.SuspendLayout();
    this.SuspendLayout();
    this.Label4.Location = new Point(8, 72);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.Label4.TabIndex = 21;
    this.Label4.Text = "Number of Pages to Print:";
    this.nudNumberOfLabelPagesToPrint.Location = new Point(184, 64 /*0x40*/);
    this.nudNumberOfLabelPagesToPrint.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudNumberOfLabelPagesToPrint.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudNumberOfLabelPagesToPrint.Name = "nudNumberOfLabelPagesToPrint";
    this.nudNumberOfLabelPagesToPrint.Size = new Size(48 /*0x30*/, 21);
    this.nudNumberOfLabelPagesToPrint.TabIndex = 3;
    this.nudNumberOfLabelPagesToPrint.TextAlign = HorizontalAlignment.Right;
    this.nudNumberOfLabelPagesToPrint.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.Label3.Location = new Point(8, 48 /*0x30*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.Label3.TabIndex = 18;
    this.Label3.Text = "Number of Labels Down:";
    this.nudLabelsDown.Location = new Point(184, 40);
    this.nudLabelsDown.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudLabelsDown.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudLabelsDown.Name = "nudLabelsDown";
    this.nudLabelsDown.Size = new Size(48 /*0x30*/, 21);
    this.nudLabelsDown.TabIndex = 2;
    this.nudLabelsDown.TextAlign = HorizontalAlignment.Right;
    this.nudLabelsDown.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.Label2.Location = new Point(8, 24);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.Label2.TabIndex = 16 /*0x10*/;
    this.Label2.Text = "Number of Labels Across:";
    this.nudLabelsAcross.Location = new Point(184, 16 /*0x10*/);
    this.nudLabelsAcross.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudLabelsAcross.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudLabelsAcross.Name = "nudLabelsAcross";
    this.nudLabelsAcross.Size = new Size(48 /*0x30*/, 21);
    this.nudLabelsAcross.TabIndex = 1;
    this.nudLabelsAcross.TextAlign = HorizontalAlignment.Right;
    this.nudLabelsAcross.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrint).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnPrint).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnPrint).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrint).Location = new Point(264, 336);
    ((Control) this.btnPrint).Name = "btnPrint";
    ((Control) this.btnPrint).TabIndex = 6;
    this.rtbAddress.Location = new Point(8, 8);
    this.rtbAddress.Name = "rtbAddress";
    this.rtbAddress.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
    this.rtbAddress.Size = new Size(296, 104);
    this.rtbAddress.TabIndex = 0;
    this.rtbAddress.Text = "";
    this.GroupBox1.Controls.Add((Control) this.nudHorizontalPitch);
    this.GroupBox1.Controls.Add((Control) this.nudVerticalPitch);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.Label10);
    this.GroupBox1.Controls.Add((Control) this.nudLabelWidth);
    this.GroupBox1.Controls.Add((Control) this.nudLabelHeight);
    this.GroupBox1.Controls.Add((Control) this.nudSideMargin);
    this.GroupBox1.Controls.Add((Control) this.nudTopMargin);
    this.GroupBox1.Controls.Add((Control) this.Label7);
    this.GroupBox1.Controls.Add((Control) this.Label6);
    this.GroupBox1.Controls.Add((Control) this.Label5);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Location = new Point(8, 176 /*0xB0*/);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(296, 96 /*0x60*/);
    this.GroupBox1.TabIndex = 2;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Settings";
    this.nudHorizontalPitch.DecimalPlaces = 2;
    this.nudHorizontalPitch.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudHorizontalPitch.Location = new Point(240 /*0xF0*/, 64 /*0x40*/);
    this.nudHorizontalPitch.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudHorizontalPitch.Name = "nudHorizontalPitch";
    this.nudHorizontalPitch.Size = new Size(48 /*0x30*/, 21);
    this.nudHorizontalPitch.TabIndex = 32 /*0x20*/;
    this.nudHorizontalPitch.TextAlign = HorizontalAlignment.Right;
    this.nudHorizontalPitch.Value = new Decimal(new int[4]
    {
      25,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudVerticalPitch.DecimalPlaces = 2;
    this.nudVerticalPitch.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudVerticalPitch.Location = new Point(88, 64 /*0x40*/);
    this.nudVerticalPitch.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudVerticalPitch.Name = "nudVerticalPitch";
    this.nudVerticalPitch.Size = new Size(48 /*0x30*/, 21);
    this.nudVerticalPitch.TabIndex = 31 /*0x1F*/;
    this.nudVerticalPitch.TextAlign = HorizontalAlignment.Right;
    this.nudVerticalPitch.Value = new Decimal(new int[4]
    {
      25,
      0,
      0,
      131072 /*0x020000*/
    });
    this.Label9.Location = new Point(144 /*0x90*/, 72);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(88, 16 /*0x10*/);
    this.Label9.TabIndex = 34;
    this.Label9.Text = "Horizontal pitch:";
    this.Label10.Location = new Point(8, 72);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label10.TabIndex = 33;
    this.Label10.Text = "Vertical pitch:";
    this.nudLabelWidth.DecimalPlaces = 2;
    this.nudLabelWidth.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudLabelWidth.Location = new Point(240 /*0xF0*/, 40);
    this.nudLabelWidth.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudLabelWidth.Name = "nudLabelWidth";
    this.nudLabelWidth.Size = new Size(48 /*0x30*/, 21);
    this.nudLabelWidth.TabIndex = 4;
    this.nudLabelWidth.TextAlign = HorizontalAlignment.Right;
    this.nudLabelWidth.Value = new Decimal(new int[4]
    {
      25,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudLabelHeight.DecimalPlaces = 2;
    this.nudLabelHeight.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudLabelHeight.Location = new Point(240 /*0xF0*/, 16 /*0x10*/);
    this.nudLabelHeight.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudLabelHeight.Name = "nudLabelHeight";
    this.nudLabelHeight.Size = new Size(48 /*0x30*/, 21);
    this.nudLabelHeight.TabIndex = 2;
    this.nudLabelHeight.TextAlign = HorizontalAlignment.Right;
    this.nudLabelHeight.Value = new Decimal(new int[4]
    {
      25,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudSideMargin.DecimalPlaces = 2;
    this.nudSideMargin.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudSideMargin.Location = new Point(88, 40);
    this.nudSideMargin.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudSideMargin.Name = "nudSideMargin";
    this.nudSideMargin.Size = new Size(48 /*0x30*/, 21);
    this.nudSideMargin.TabIndex = 3;
    this.nudSideMargin.TextAlign = HorizontalAlignment.Right;
    this.nudSideMargin.Value = new Decimal(new int[4]
    {
      25,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudTopMargin.DecimalPlaces = 2;
    this.nudTopMargin.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072 /*0x020000*/
    });
    this.nudTopMargin.Location = new Point(88, 16 /*0x10*/);
    this.nudTopMargin.Maximum = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.nudTopMargin.Name = "nudTopMargin";
    this.nudTopMargin.Size = new Size(48 /*0x30*/, 21);
    this.nudTopMargin.TabIndex = 1;
    this.nudTopMargin.TextAlign = HorizontalAlignment.Right;
    this.nudTopMargin.Value = new Decimal(new int[4]
    {
      25,
      0,
      0,
      131072 /*0x020000*/
    });
    this.Label7.Location = new Point(144 /*0x90*/, 48 /*0x30*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(88, 16 /*0x10*/);
    this.Label7.TabIndex = 30;
    this.Label7.Text = "Label width:";
    this.Label6.Location = new Point(144 /*0x90*/, 24);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(88, 16 /*0x10*/);
    this.Label6.TabIndex = 29;
    this.Label6.Text = "Label height:";
    this.Label5.Location = new Point(8, 48 /*0x30*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(72, 16 /*0x10*/);
    this.Label5.TabIndex = 28;
    this.Label5.Text = "Side margin:";
    this.Label1.Location = new Point(8, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(72, 16 /*0x10*/);
    this.Label1.TabIndex = 27;
    this.Label1.Text = "Top margin:";
    this.GroupBox2.Controls.Add((Control) this.Label4);
    this.GroupBox2.Controls.Add((Control) this.nudNumberOfLabelPagesToPrint);
    this.GroupBox2.Controls.Add((Control) this.Label3);
    this.GroupBox2.Controls.Add((Control) this.nudLabelsDown);
    this.GroupBox2.Controls.Add((Control) this.Label2);
    this.GroupBox2.Controls.Add((Control) this.nudLabelsAcross);
    this.GroupBox2.Location = new Point(8, 280);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(240 /*0xF0*/, 96 /*0x60*/);
    this.GroupBox2.TabIndex = 3;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Label Page";
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnFont).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnFont).Location = new Point(232, 120);
    ((Control) this.btnFont).Name = "btnFont";
    ((Control) this.btnFont).Size = new Size(72, 23);
    ((Control) this.btnFont).TabIndex = 5;
    ((ControlBase) this.btnFont).Text = "Font...";
    ((Control) this.cboLabelTypes).Location = new Point(48 /*0x30*/, 152);
    ((Control) this.cboLabelTypes).Name = "cboLabelTypes";
    ((Control) this.cboLabelTypes).Size = new Size(256 /*0x0100*/, 21);
    ((Control) this.cboLabelTypes).TabIndex = 1;
    this.Label8.Location = new Point(8, 152);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(40, 16 /*0x10*/);
    this.Label8.TabIndex = 34;
    this.Label8.Text = "Type:";
    this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
    this.SqlDataAdapter1.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblEnvelopeTypes", new DataColumnMapping[17]
      {
        new DataColumnMapping("EnvelopeTypeID", "EnvelopeTypeID"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Height", "Height"),
        new DataColumnMapping("Width", "Width"),
        new DataColumnMapping("DeliveryAddressFromLeft", "DeliveryAddressFromLeft"),
        new DataColumnMapping("DeliveryAddressFromTop", "DeliveryAddressFromTop"),
        new DataColumnMapping("DeliveryAddressFromLeftMAX", "DeliveryAddressFromLeftMAX"),
        new DataColumnMapping("DeliveryAddressFromTopMAX", "DeliveryAddressFromTopMAX"),
        new DataColumnMapping("DeliveryAddressFromLeftMIN", "DeliveryAddressFromLeftMIN"),
        new DataColumnMapping("DeliveryAddressFromTopMIN", "DeliveryAddressFromTopMIN"),
        new DataColumnMapping("ReturnAddressFromLeft", "ReturnAddressFromLeft"),
        new DataColumnMapping("ReturnAddressFromTop", "ReturnAddressFromTop"),
        new DataColumnMapping("ReturnAddressFromLeftMAX", "ReturnAddressFromLeftMAX"),
        new DataColumnMapping("ReturnAddressFromTopMAX", "ReturnAddressFromTopMAX"),
        new DataColumnMapping("ReturnAddressFromLeftMIN", "ReturnAddressFromLeftMIN"),
        new DataColumnMapping("ReturnAddressFromTopMIN", "ReturnAddressFromTopMIN"),
        new DataColumnMapping("DefaultEnvelope", "DefaultEnvelope")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT EnvelopeTypeID, Description, Height, Width, DeliveryAddressFromLeft, DeliveryAddressFromTop, DeliveryAddressFromLeftMAX, DeliveryAddressFromTopMAX, DeliveryAddressFromLeftMIN, DeliveryAddressFromTopMIN, ReturnAddressFromLeft, ReturnAddressFromTop, ReturnAddressFromLeftMAX, ReturnAddressFromTopMAX, ReturnAddressFromLeftMIN, ReturnAddressFromTopMIN, DefaultEnvelope FROM tblEnvelopeTypes";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(314, 383);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.cboLabelTypes);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnFont);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.rtbAddress);
    this.Controls.Add((Control) this.btnPrint);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPrintLabels);
    this.Text = "Label Printing";
    this.nudNumberOfLabelPagesToPrint.EndInit();
    this.nudLabelsDown.EndInit();
    this.nudLabelsAcross.EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.nudHorizontalPitch.EndInit();
    this.nudVerticalPitch.EndInit();
    this.nudLabelWidth.EndInit();
    this.nudLabelHeight.EndInit();
    this.nudSideMargin.EndInit();
    this.nudTopMargin.EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmPrintLabels()
  {
    this.Load += new EventHandler(this.frmPrintLabels_Load);
    this._labelTypes = new dsLabels.tblLabelSheetsDataTable();
    this.InitializeComponent();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.SqlDataAdapter1, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
  }

  public frmPrintLabels(string address)
  {
    this.Load += new EventHandler(this.frmPrintLabels_Load);
    this._labelTypes = new dsLabels.tblLabelSheetsDataTable();
    this.InitializeComponent();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.SqlDataAdapter1, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.rtbAddress.Text = address;
  }

  public frmPrintLabels(Guid entityGuid)
  {
    this.Load += new EventHandler(this.frmPrintLabels_Load);
    this._labelTypes = new dsLabels.tblLabelSheetsDataTable();
    this.InitializeComponent();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.SqlDataAdapter1, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.rtbAddress.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityName(@EG)", new object[2]
    {
      (object) "@EG",
      (object) entityGuid
    });
  }

  private void FillLabelTypes()
  {
    DefaultDatabase.LoadDataTable((DataTable) this._labelTypes, CommandType.Text, "SELECT labelID, description, topMargin, sideMargin, labelHeight, labelWidth, verticalPitch, HorizontalPitch, labelsAcross, labelsDown FROM dbo.tblLabelSheets ORDER BY description");
    this.cboLabelTypes.ValueChanged -= new EventHandler(this.cboLabelTypes_ValueChanged);
    MGASimpleComboBox cboLabelTypes = this.cboLabelTypes;
    ((UltraDropDownBase) cboLabelTypes).DisplayMember = "description";
    ((UltraDropDownBase) cboLabelTypes).ValueMember = "labelID";
    ((UltraGridBase) cboLabelTypes).DataSource = (object) this._labelTypes;
    this.cboLabelTypes.ValueChanged += new EventHandler(this.cboLabelTypes_ValueChanged);
    if (((UltraGridBase) this.cboLabelTypes).Rows.Count <= 0)
      return;
    this.cboLabelTypes.SelectedIndex = 0;
  }

  private void labelDoc_PrintPage(object sender, PrintPageEventArgs e)
  {
    e.Graphics.PageUnit = GraphicsUnit.Inch;
    Pen pen = new Pen(Color.Black, 0.1f);
    int int32_1 = Convert.ToInt32(Decimal.Subtract(this.nudLabelsDown.Value, 1M));
    for (int index1 = 0; index1 <= int32_1; ++index1)
    {
      Decimal num1 = Decimal.Add(this.nudTopMargin.Value, Decimal.Multiply(this.nudVerticalPitch.Value, new Decimal(index1)));
      int int32_2 = Convert.ToInt32(Decimal.Subtract(this.nudLabelsAcross.Value, 1M));
      for (int index2 = 0; index2 <= int32_2; ++index2)
      {
        Decimal num2 = Decimal.Add(this.nudSideMargin.Value, Decimal.Multiply(this.nudHorizontalPitch.Value, new Decimal(index2)));
        bool flag;
        if (flag)
          e.Graphics.DrawRectangle(pen, Convert.ToSingle(num2), Convert.ToSingle(num1), Convert.ToSingle(this.nudLabelWidth.Value), Convert.ToSingle(this.nudLabelHeight.Value));
        else
          e.Graphics.DrawString(this.rtbAddress.Text, this.rtbAddress.Font, Brushes.Black, Convert.ToSingle(num2), Convert.ToSingle(num1));
      }
    }
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    PrintDialog printDialog = new PrintDialog();
    this.labelDoc.DefaultPageSettings.PrinterSettings.Copies = Convert.ToInt16(this.nudNumberOfLabelPagesToPrint.Value);
    printDialog.Document = this.labelDoc;
    if (printDialog.ShowDialog() != DialogResult.OK)
      return;
    this.labelDoc.PrinterSettings = printDialog.PrinterSettings;
    this.labelDoc.Print();
  }

  private void btnFont_Click(object sender, EventArgs e)
  {
    FontDialog fontDialog = new FontDialog();
    fontDialog.Font = this.rtbAddress.Font;
    if (fontDialog.ShowDialog() == DialogResult.OK)
      this.rtbAddress.Font = fontDialog.Font;
    fontDialog.Dispose();
  }

  private void cboLabelTypes_ValueChanged(object sender, EventArgs e)
  {
    dsLabels.tblLabelSheetsRow bylabelId = this._labelTypes.FindBylabelID(Conversions.ToInteger(this.cboLabelTypes.Value));
    this.nudTopMargin.Value = bylabelId.topMargin;
    this.nudSideMargin.Value = bylabelId.sideMargin;
    this.nudLabelHeight.Value = bylabelId.labelHeight;
    this.nudLabelWidth.Value = bylabelId.labelWidth;
    this.nudVerticalPitch.Value = bylabelId.verticalPitch;
    this.nudHorizontalPitch.Value = bylabelId.HorizontalPitch;
    this.nudLabelsAcross.Value = new Decimal(bylabelId.labelsAcross);
    this.nudLabelsDown.Value = new Decimal(bylabelId.labelsDown);
  }

  private void frmPrintLabels_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnPrint).Appearance.Image = (object) ImageCache.Instance.PrintDocument;
    this.FillLabelTypes();
  }
}
