// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.UserControls.GLCompanyTotals
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.UserControls;

public class GLCompanyTotals : UserControl
{
  private Label label2;
  private Label label3;
  private Label labelOfficeLocation;
  private Label labelTotalReceivables;
  private Label labelTotalPayables;
  private UltraGroupBox ultraGroupBox1;
  private Label label8;
  private Label label9;
  private Label label10;
  private Label label11;
  private Label label12;
  private Label labelBucket1AR;
  private Label labelBucket2AR;
  private Label labelBucket3AR;
  private Label labelBucket4AR;
  private UltraGroupBox ultraGroupBox2;
  private Label label18;
  private Label label19;
  private Label label20;
  private Label label21;
  private Label label22;
  private Label labelCurrentHeaderAR;
  private Label labelBucket4DatesAR;
  private Label labelBucket2DatesAR;
  private Label labelBucket1DatesAR;
  private Label labelBucket3DatesAR;
  private Label labelCurrentAR;
  private Label labelBucket4AP;
  private Label labelBucket3AP;
  private Label labelBucket2AP;
  private Label labelBucket1AP;
  private Label labelBucket3DatesAP;
  private Label labelBucket1DatesAP;
  private Label labelBucket2DatesAP;
  private Label labelBucket4DatesAP;
  private Label labelCurrentHeaderAP;
  private Label labelCurrentAP;
  private System.ComponentModel.Container components;
  private int _glCompanyId;
  private DataSet _dsReceivables;
  private DataSet _dsPayables;

  private GLCompanyTotals()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
  }

  public GLCompanyTotals(
    int glCompanyId,
    string officeLocation,
    Decimal totalReceivable,
    Decimal totalPayable)
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    this._glCompanyId = glCompanyId;
    this.labelOfficeLocation.Text = officeLocation;
    this.labelTotalReceivables.Text = totalReceivable.ToString("c");
    this.labelTotalPayables.Text = totalPayable.ToString("c");
    this.LoadPayablesAging();
    this.LoadReceivablesAging();
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
    this.labelOfficeLocation = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.labelTotalReceivables = new Label();
    this.labelTotalPayables = new Label();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.labelCurrentHeaderAR = new Label();
    this.labelBucket4DatesAR = new Label();
    this.labelBucket2DatesAR = new Label();
    this.labelBucket1DatesAR = new Label();
    this.labelBucket3DatesAR = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.labelCurrentAR = new Label();
    this.labelBucket1AR = new Label();
    this.labelBucket2AR = new Label();
    this.labelBucket3AR = new Label();
    this.labelBucket4AR = new Label();
    this.ultraGroupBox2 = new UltraGroupBox();
    this.labelBucket4AP = new Label();
    this.labelBucket3AP = new Label();
    this.labelBucket2AP = new Label();
    this.labelBucket1AP = new Label();
    this.label18 = new Label();
    this.label19 = new Label();
    this.label20 = new Label();
    this.label21 = new Label();
    this.label22 = new Label();
    this.labelBucket3DatesAP = new Label();
    this.labelBucket1DatesAP = new Label();
    this.labelBucket2DatesAP = new Label();
    this.labelBucket4DatesAP = new Label();
    this.labelCurrentHeaderAP = new Label();
    this.labelCurrentAP = new Label();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.ultraGroupBox2).BeginInit();
    ((Control) this.ultraGroupBox2).SuspendLayout();
    this.SuspendLayout();
    this.labelOfficeLocation.AutoSize = true;
    this.labelOfficeLocation.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelOfficeLocation.ForeColor = Color.LightSlateGray;
    this.labelOfficeLocation.Location = new Point(8, 8);
    this.labelOfficeLocation.Name = "labelOfficeLocation";
    this.labelOfficeLocation.Size = new Size(131, 18);
    this.labelOfficeLocation.TabIndex = 0;
    this.labelOfficeLocation.Text = "[OFFICE LOCATION]";
    this.labelOfficeLocation.UseMnemonic = false;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label2.Location = new Point(8, 24);
    this.label2.Name = "label2";
    this.label2.Size = new Size(115, 16 /*0x10*/);
    this.label2.TabIndex = 1;
    this.label2.Text = "Receivables To Date";
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label3.Location = new Point(8, 24);
    this.label3.Name = "label3";
    this.label3.Size = new Size(99, 16 /*0x10*/);
    this.label3.TabIndex = 2;
    this.label3.Text = "Payables To Date";
    this.labelTotalReceivables.AutoSize = true;
    this.labelTotalReceivables.BackColor = Color.Transparent;
    this.labelTotalReceivables.Location = new Point(152, 24);
    this.labelTotalReceivables.Name = "labelTotalReceivables";
    this.labelTotalReceivables.Size = new Size(97, 16 /*0x10*/);
    this.labelTotalReceivables.TabIndex = 3;
    this.labelTotalReceivables.Text = "[Total Receivables]";
    this.labelTotalReceivables.TextAlign = ContentAlignment.TopRight;
    this.labelTotalReceivables.UseMnemonic = false;
    this.labelTotalPayables.AutoSize = true;
    this.labelTotalPayables.BackColor = Color.Transparent;
    this.labelTotalPayables.Location = new Point(160 /*0xA0*/, 24);
    this.labelTotalPayables.Name = "labelTotalPayables";
    this.labelTotalPayables.Size = new Size(83, 16 /*0x10*/);
    this.labelTotalPayables.TabIndex = 4;
    this.labelTotalPayables.Text = "[Total Payables]";
    this.labelTotalPayables.UseMnemonic = false;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraGroupBox1).BackColor = Color.White;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    this.ultraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket4AR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket3AR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket2AR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket1AR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label12);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label11);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label10);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label9);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label8);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket3DatesAR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket1DatesAR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket2DatesAR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelBucket4DatesAR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelCurrentHeaderAR);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelTotalReceivables);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label2);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.labelCurrentAR);
    ((Control) this.ultraGroupBox1).Location = new Point(8, 24);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(504, 112 /*0x70*/);
    this.ultraGroupBox1.SupportThemes = false;
    ((Control) this.ultraGroupBox1).TabIndex = 5;
    ((Control) this.ultraGroupBox1).Text = "Receivables";
    this.ultraGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.ultraGroupBox1).Click += new EventHandler(this.ultraGroupBox1_Click);
    this.labelCurrentHeaderAR.AutoSize = true;
    this.labelCurrentHeaderAR.BackColor = Color.Transparent;
    this.labelCurrentHeaderAR.Location = new Point(8, 64 /*0x40*/);
    this.labelCurrentHeaderAR.Name = "labelCurrentHeaderAR";
    this.labelCurrentHeaderAR.Size = new Size(40, 16 /*0x10*/);
    this.labelCurrentHeaderAR.TabIndex = 4;
    this.labelCurrentHeaderAR.Text = "Current";
    this.labelBucket4DatesAR.BackColor = Color.Transparent;
    this.labelBucket4DatesAR.Location = new Point(432, 64 /*0x40*/);
    this.labelBucket4DatesAR.Name = "labelBucket4DatesAR";
    this.labelBucket4DatesAR.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket4DatesAR.TabIndex = 8;
    this.labelBucket4DatesAR.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket4DatesAR.TextAlign = ContentAlignment.MiddleCenter;
    this.labelBucket2DatesAR.BackColor = Color.Transparent;
    this.labelBucket2DatesAR.Location = new Point(224 /*0xE0*/, 64 /*0x40*/);
    this.labelBucket2DatesAR.Name = "labelBucket2DatesAR";
    this.labelBucket2DatesAR.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket2DatesAR.TabIndex = 9;
    this.labelBucket2DatesAR.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket2DatesAR.TextAlign = ContentAlignment.MiddleCenter;
    this.labelBucket1DatesAR.BackColor = Color.Transparent;
    this.labelBucket1DatesAR.Location = new Point(120, 64 /*0x40*/);
    this.labelBucket1DatesAR.Name = "labelBucket1DatesAR";
    this.labelBucket1DatesAR.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket1DatesAR.TabIndex = 10;
    this.labelBucket1DatesAR.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket1DatesAR.TextAlign = ContentAlignment.MiddleCenter;
    this.labelBucket3DatesAR.BackColor = Color.Transparent;
    this.labelBucket3DatesAR.Location = new Point(328, 64 /*0x40*/);
    this.labelBucket3DatesAR.Name = "labelBucket3DatesAR";
    this.labelBucket3DatesAR.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket3DatesAR.TabIndex = 11;
    this.labelBucket3DatesAR.Text = "12 - 31";
    this.labelBucket3DatesAR.TextAlign = ContentAlignment.MiddleCenter;
    this.label8.BackColor = Color.Black;
    this.label8.Location = new Point(432, 80 /*0x50*/);
    this.label8.Name = "label8";
    this.label8.Size = new Size(65, 1);
    this.label8.TabIndex = 12;
    this.label9.BackColor = Color.Black;
    this.label9.Location = new Point(328, 80 /*0x50*/);
    this.label9.Name = "label9";
    this.label9.Size = new Size(65, 1);
    this.label9.TabIndex = 13;
    this.label10.BackColor = Color.Black;
    this.label10.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.label10.Name = "label10";
    this.label10.Size = new Size(65, 1);
    this.label10.TabIndex = 14;
    this.label11.BackColor = Color.Black;
    this.label11.Location = new Point(120, 80 /*0x50*/);
    this.label11.Name = "label11";
    this.label11.Size = new Size(65, 1);
    this.label11.TabIndex = 15;
    this.label12.BackColor = Color.Black;
    this.label12.Location = new Point(8, 80 /*0x50*/);
    this.label12.Name = "label12";
    this.label12.Size = new Size(40, 1);
    this.label12.TabIndex = 16 /*0x10*/;
    this.labelCurrentAR.BackColor = Color.Transparent;
    this.labelCurrentAR.Location = new Point(8, 88);
    this.labelCurrentAR.Name = "labelCurrentAR";
    this.labelCurrentAR.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.labelCurrentAR.TabIndex = 17;
    this.labelCurrentAR.Text = "[Current]";
    this.labelCurrentAR.UseMnemonic = false;
    this.labelBucket1AR.BackColor = Color.Transparent;
    this.labelBucket1AR.Location = new Point(96 /*0x60*/, 88);
    this.labelBucket1AR.Name = "labelBucket1AR";
    this.labelBucket1AR.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket1AR.TabIndex = 18;
    this.labelBucket1AR.Text = "[Bucket 1]";
    this.labelBucket1AR.TextAlign = ContentAlignment.TopRight;
    this.labelBucket1AR.UseMnemonic = false;
    this.labelBucket2AR.BackColor = Color.Transparent;
    this.labelBucket2AR.Location = new Point(200, 88);
    this.labelBucket2AR.Name = "labelBucket2AR";
    this.labelBucket2AR.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket2AR.TabIndex = 19;
    this.labelBucket2AR.Text = "[Bucket 2]";
    this.labelBucket2AR.TextAlign = ContentAlignment.TopRight;
    this.labelBucket2AR.UseMnemonic = false;
    this.labelBucket3AR.BackColor = Color.Transparent;
    this.labelBucket3AR.Location = new Point(304, 88);
    this.labelBucket3AR.Name = "labelBucket3AR";
    this.labelBucket3AR.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket3AR.TabIndex = 20;
    this.labelBucket3AR.Text = "[Bucket 3]";
    this.labelBucket3AR.TextAlign = ContentAlignment.TopRight;
    this.labelBucket3AR.UseMnemonic = false;
    this.labelBucket4AR.BackColor = Color.Transparent;
    this.labelBucket4AR.Location = new Point(408, 88);
    this.labelBucket4AR.Name = "labelBucket4AR";
    this.labelBucket4AR.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket4AR.TabIndex = 21;
    this.labelBucket4AR.Text = "[Bucket 4]";
    this.labelBucket4AR.TextAlign = ContentAlignment.TopRight;
    this.labelBucket4AR.UseMnemonic = false;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    this.ultraGroupBox2.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    this.ultraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance4;
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket4AP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket3AP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket2AP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket1AP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.label18);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.label19);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.label20);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.label21);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.label22);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket3DatesAP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket1DatesAP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket2DatesAP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelBucket4DatesAP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelCurrentHeaderAP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelCurrentAP);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.label3);
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.labelTotalPayables);
    ((Control) this.ultraGroupBox2).Location = new Point(8, 144 /*0x90*/);
    ((Control) this.ultraGroupBox2).Name = "ultraGroupBox2";
    ((Control) this.ultraGroupBox2).Size = new Size(504, 112 /*0x70*/);
    this.ultraGroupBox2.SupportThemes = false;
    ((Control) this.ultraGroupBox2).TabIndex = 6;
    ((Control) this.ultraGroupBox2).Text = "Payables";
    this.ultraGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    this.labelBucket4AP.BackColor = Color.Transparent;
    this.labelBucket4AP.Location = new Point(408, 88);
    this.labelBucket4AP.Name = "labelBucket4AP";
    this.labelBucket4AP.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket4AP.TabIndex = 21;
    this.labelBucket4AP.Text = "[Bucket 4]";
    this.labelBucket4AP.TextAlign = ContentAlignment.TopRight;
    this.labelBucket4AP.UseMnemonic = false;
    this.labelBucket3AP.BackColor = Color.Transparent;
    this.labelBucket3AP.Location = new Point(304, 88);
    this.labelBucket3AP.Name = "labelBucket3AP";
    this.labelBucket3AP.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket3AP.TabIndex = 20;
    this.labelBucket3AP.Text = "[Bucket 3]";
    this.labelBucket3AP.TextAlign = ContentAlignment.TopRight;
    this.labelBucket3AP.UseMnemonic = false;
    this.labelBucket2AP.BackColor = Color.Transparent;
    this.labelBucket2AP.Location = new Point(200, 88);
    this.labelBucket2AP.Name = "labelBucket2AP";
    this.labelBucket2AP.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket2AP.TabIndex = 19;
    this.labelBucket2AP.Text = "[Bucket 2]";
    this.labelBucket2AP.TextAlign = ContentAlignment.TopRight;
    this.labelBucket2AP.UseMnemonic = false;
    this.labelBucket1AP.BackColor = Color.Transparent;
    this.labelBucket1AP.Location = new Point(96 /*0x60*/, 88);
    this.labelBucket1AP.Name = "labelBucket1AP";
    this.labelBucket1AP.Size = new Size(88, 16 /*0x10*/);
    this.labelBucket1AP.TabIndex = 18;
    this.labelBucket1AP.Text = "[Bucket 1]";
    this.labelBucket1AP.TextAlign = ContentAlignment.TopRight;
    this.labelBucket1AP.UseMnemonic = false;
    this.label18.BackColor = Color.Black;
    this.label18.Location = new Point(8, 80 /*0x50*/);
    this.label18.Name = "label18";
    this.label18.Size = new Size(40, 1);
    this.label18.TabIndex = 16 /*0x10*/;
    this.label19.BackColor = Color.Black;
    this.label19.Location = new Point(120, 80 /*0x50*/);
    this.label19.Name = "label19";
    this.label19.Size = new Size(65, 1);
    this.label19.TabIndex = 15;
    this.label20.BackColor = Color.Black;
    this.label20.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.label20.Name = "label20";
    this.label20.Size = new Size(65, 1);
    this.label20.TabIndex = 14;
    this.label21.BackColor = Color.Black;
    this.label21.Location = new Point(328, 80 /*0x50*/);
    this.label21.Name = "label21";
    this.label21.Size = new Size(65, 1);
    this.label21.TabIndex = 13;
    this.label22.BackColor = Color.Black;
    this.label22.Location = new Point(432, 80 /*0x50*/);
    this.label22.Name = "label22";
    this.label22.Size = new Size(65, 1);
    this.label22.TabIndex = 12;
    this.labelBucket3DatesAP.BackColor = Color.Transparent;
    this.labelBucket3DatesAP.Location = new Point(328, 64 /*0x40*/);
    this.labelBucket3DatesAP.Name = "labelBucket3DatesAP";
    this.labelBucket3DatesAP.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket3DatesAP.TabIndex = 11;
    this.labelBucket3DatesAP.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket3DatesAP.TextAlign = ContentAlignment.MiddleCenter;
    this.labelBucket1DatesAP.BackColor = Color.Transparent;
    this.labelBucket1DatesAP.Location = new Point(120, 64 /*0x40*/);
    this.labelBucket1DatesAP.Name = "labelBucket1DatesAP";
    this.labelBucket1DatesAP.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket1DatesAP.TabIndex = 10;
    this.labelBucket1DatesAP.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket1DatesAP.TextAlign = ContentAlignment.MiddleCenter;
    this.labelBucket2DatesAP.BackColor = Color.Transparent;
    this.labelBucket2DatesAP.Location = new Point(224 /*0xE0*/, 64 /*0x40*/);
    this.labelBucket2DatesAP.Name = "labelBucket2DatesAP";
    this.labelBucket2DatesAP.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket2DatesAP.TabIndex = 9;
    this.labelBucket2DatesAP.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket2DatesAP.TextAlign = ContentAlignment.MiddleCenter;
    this.labelBucket4DatesAP.BackColor = Color.Transparent;
    this.labelBucket4DatesAP.Location = new Point(432, 64 /*0x40*/);
    this.labelBucket4DatesAP.Name = "labelBucket4DatesAP";
    this.labelBucket4DatesAP.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.labelBucket4DatesAP.TabIndex = 8;
    this.labelBucket4DatesAP.Text = "12/31/2005 - 12/31/2005";
    this.labelBucket4DatesAP.TextAlign = ContentAlignment.MiddleCenter;
    this.labelCurrentHeaderAP.AutoSize = true;
    this.labelCurrentHeaderAP.BackColor = Color.Transparent;
    this.labelCurrentHeaderAP.Location = new Point(8, 64 /*0x40*/);
    this.labelCurrentHeaderAP.Name = "labelCurrentHeaderAP";
    this.labelCurrentHeaderAP.Size = new Size(40, 16 /*0x10*/);
    this.labelCurrentHeaderAP.TabIndex = 4;
    this.labelCurrentHeaderAP.Text = "Current";
    this.labelCurrentAP.BackColor = Color.Transparent;
    this.labelCurrentAP.Location = new Point(8, 88);
    this.labelCurrentAP.Name = "labelCurrentAP";
    this.labelCurrentAP.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.labelCurrentAP.TabIndex = 17;
    this.labelCurrentAP.Text = "[Current]";
    this.labelCurrentAP.UseMnemonic = false;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.ultraGroupBox2);
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Controls.Add((Control) this.labelOfficeLocation);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (GLCompanyTotals);
    this.Size = new Size(520, 256 /*0x0100*/);
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.ultraGroupBox2).EndInit();
    ((Control) this.ultraGroupBox2).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void ultraGroupBox1_Click(object sender, EventArgs e)
  {
  }

  public void LoadReceivablesAging()
  {
    new Thread(new ThreadStart(this.DoLoadReceivablesAging))
    {
      Name = "GetReceivablesAging",
      IsBackground = true
    }.Start();
  }

  private void DoLoadReceivablesAging()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_GetAgingToDate", connection))
      {
        selectCommand.CommandTimeout = 0;
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Parameters.AddWithValue("@glcompanyId", (object) this._glCompanyId);
        selectCommand.Parameters.AddWithValue("@asof_date", (object) DateTime.Now);
        selectCommand.Parameters.AddWithValue("@type", (object) "R");
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
        {
          this._dsReceivables = new DataSet();
          sqlDataAdapter.Fill(this._dsReceivables);
        }
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new GLCompanyTotals.DoLoadReceivablesAgingCompletedHandler(this.DoLoadReceivablesAgingComplete));
  }

  private void DoLoadReceivablesAgingComplete()
  {
    if (this._dsReceivables.Tables.Count == 0)
      return;
    if (this._dsReceivables.Tables[0].Rows.Count != 0)
    {
      this.labelBucket1DatesAR.Text = this._dsReceivables.Tables[0].Rows[0]["Bucket 1"].ToString();
      this.labelBucket2DatesAR.Text = this._dsReceivables.Tables[0].Rows[0]["Bucket 2"].ToString();
      this.labelBucket3DatesAR.Text = this._dsReceivables.Tables[0].Rows[0]["Bucket 3"].ToString();
      this.labelBucket4DatesAR.Text = this._dsReceivables.Tables[0].Rows[0]["Bucket 4"].ToString();
    }
    if (this._dsReceivables.Tables[1].Rows.Count == 0)
      return;
    this.labelCurrentAR.Text = Decimal.Parse(this._dsReceivables.Tables[1].Rows[0]["Current"].ToString()).ToString("c");
    this.labelBucket1AR.Text = Decimal.Parse(this._dsReceivables.Tables[1].Rows[0]["Bucket1"].ToString()).ToString("c");
    this.labelBucket2AR.Text = Decimal.Parse(this._dsReceivables.Tables[1].Rows[0]["Bucket2"].ToString()).ToString("c");
    this.labelBucket3AR.Text = Decimal.Parse(this._dsReceivables.Tables[1].Rows[0]["Bucket3"].ToString()).ToString("c");
    this.labelBucket4AR.Text = Decimal.Parse(this._dsReceivables.Tables[1].Rows[0]["Bucket4"].ToString()).ToString("c");
  }

  public void LoadPayablesAging()
  {
    new Thread(new ThreadStart(this.DoLoadPayablesAging))
    {
      Name = "GetPayablesAging",
      IsBackground = true
    }.Start();
  }

  private void DoLoadPayablesAging()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_GetAgingToDate", connection))
      {
        selectCommand.CommandTimeout = 0;
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Parameters.AddWithValue("@glcompanyId", (object) this._glCompanyId);
        selectCommand.Parameters.AddWithValue("@asof_date", (object) DateTime.Now);
        selectCommand.Parameters.AddWithValue("@type", (object) "P");
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
        {
          this._dsPayables = new DataSet();
          sqlDataAdapter.Fill(this._dsPayables);
        }
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new GLCompanyTotals.DoLoadPayablesAgingCompletedHandler(this.DoLoadPayablesAgingComplete));
  }

  private void DoLoadPayablesAgingComplete()
  {
    if (this._dsPayables.Tables.Count == 0)
      return;
    if (this._dsPayables.Tables[0].Rows.Count != 0)
    {
      this.labelBucket1DatesAP.Text = this._dsPayables.Tables[0].Rows[0]["Bucket 1"].ToString();
      this.labelBucket2DatesAP.Text = this._dsPayables.Tables[0].Rows[0]["Bucket 2"].ToString();
      this.labelBucket3DatesAP.Text = this._dsPayables.Tables[0].Rows[0]["Bucket 3"].ToString();
      this.labelBucket4DatesAP.Text = this._dsPayables.Tables[0].Rows[0]["Bucket 4"].ToString();
    }
    if (this._dsPayables.Tables[1].Rows.Count == 0)
      return;
    this.labelCurrentAP.Text = Decimal.Parse(this._dsPayables.Tables[1].Rows[0]["Current"].ToString()).ToString("c");
    this.labelBucket1AP.Text = Decimal.Parse(this._dsPayables.Tables[1].Rows[0]["Bucket1"].ToString()).ToString("c");
    this.labelBucket2AP.Text = Decimal.Parse(this._dsPayables.Tables[1].Rows[0]["Bucket2"].ToString()).ToString("c");
    this.labelBucket3AP.Text = Decimal.Parse(this._dsPayables.Tables[1].Rows[0]["Bucket3"].ToString()).ToString("c");
    this.labelBucket4AP.Text = Decimal.Parse(this._dsPayables.Tables[1].Rows[0]["Bucket4"].ToString()).ToString("c");
  }

  private delegate void DoLoadReceivablesAgingCompletedHandler();

  private delegate void DoLoadPayablesAgingCompletedHandler();
}
