// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formReinstatementDatesOverRide
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class formReinstatementDatesOverRide : Form
{
  internal SqlConnection FormDataConnection;
  internal SqlCommand SqlSelectCommand1;
  internal Label Label5;
  internal Label Label4;
  internal SqlDataAdapter daGetQuoteStatusReasons;
  private dsQuoteStatusReasons dsQuoteStatusReasons1;
  private EllipsePanel ellipsePanel1;
  internal PictureBox pictureBox2;
  internal MGAButton mgaButton1;
  internal MGAButton mgaButton2;
  private MGADateTimePicker dateEffectiveDate;
  private MGADateTimePicker dateMailingDate;
  private System.ComponentModel.Container components;

  public formReinstatementDatesOverRide() => this.InitializeComponent();

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
    ResourceManager resourceManager = new ResourceManager(typeof (formReinstatementDatesOverRide));
    Appearance appearance6 = new Appearance();
    this.FormDataConnection = new SqlConnection();
    this.SqlSelectCommand1 = new SqlCommand();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.daGetQuoteStatusReasons = new SqlDataAdapter();
    this.dsQuoteStatusReasons1 = new dsQuoteStatusReasons();
    this.dateEffectiveDate = new MGADateTimePicker();
    this.dateMailingDate = new MGADateTimePicker();
    this.ellipsePanel1 = new EllipsePanel();
    this.mgaButton2 = new MGAButton();
    this.mgaButton1 = new MGAButton();
    this.pictureBox2 = new PictureBox();
    this.dsQuoteStatusReasons1.BeginInit();
    ((ISupportInitialize) this.dateEffectiveDate).BeginInit();
    ((ISupportInitialize) this.dateMailingDate).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.mgaButton2).BeginInit();
    ((ISupportInitialize) this.mgaButton1).BeginInit();
    this.SuspendLayout();
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.SqlSelectCommand1.CommandText = "[spFin_GetQuoteStatusReasons]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(8, 40);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(92, 17);
    this.Label5.TabIndex = 20;
    this.Label5.Text = "Date Of Mailing";
    this.Label5.TextAlign = ContentAlignment.TopCenter;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(8, 16 /*0x10*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(88, 17);
    this.Label4.TabIndex = 19;
    this.Label4.Text = "Effective Date:";
    this.Label4.TextAlign = ContentAlignment.TopCenter;
    this.daGetQuoteStatusReasons.SelectCommand = this.SqlSelectCommand1;
    this.daGetQuoteStatusReasons.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetQuoteStatusReasons", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Reason", "Reason")
      })
    });
    this.dsQuoteStatusReasons1.DataSetName = "dsQuoteStatusReasons";
    this.dsQuoteStatusReasons1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateEffectiveDate.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dateEffectiveDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateEffectiveDate).Location = new Point(136, 16 /*0x10*/);
    this.dateEffectiveDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateEffectiveDate).Name = "dateEffectiveDate";
    ((Control) this.dateEffectiveDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dateEffectiveDate).TabIndex = 21;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateMailingDate.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.dateMailingDate.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateMailingDate).Location = new Point(136, 40);
    this.dateMailingDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateMailingDate).Name = "dateMailingDate";
    ((Control) this.dateMailingDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dateMailingDate).TabIndex = 22;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.Controls.Add((Control) this.mgaButton2);
    this.ellipsePanel1.Controls.Add((Control) this.mgaButton1);
    this.ellipsePanel1.Controls.Add((Control) this.pictureBox2);
    this.ellipsePanel1.Controls.Add((Control) this.dateMailingDate);
    this.ellipsePanel1.Controls.Add((Control) this.Label4);
    this.ellipsePanel1.Controls.Add((Control) this.Label5);
    this.ellipsePanel1.Controls.Add((Control) this.dateEffectiveDate);
    this.ellipsePanel1.Location = new Point(4, 4);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(420, 108);
    this.ellipsePanel1.TabIndex = 23;
    ((AppearanceBase) appearance5).Image = resourceManager.GetObject("appearance5.Image");
    ((ControlBase) this.mgaButton2).Appearance = (AppearanceBase) appearance5;
    ((Control) this.mgaButton2).Location = new Point(320, 80 /*0x50*/);
    ((Control) this.mgaButton2).Name = "mgaButton2";
    ((Control) this.mgaButton2).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.mgaButton2).TabIndex = 25;
    ((Control) this.mgaButton2).Text = "&Cancel";
    ((Control) this.mgaButton2).Click += new EventHandler(this.btnCancel_Click);
    ((AppearanceBase) appearance6).Image = resourceManager.GetObject("appearance6.Image");
    ((ControlBase) this.mgaButton1).Appearance = (AppearanceBase) appearance6;
    ((Control) this.mgaButton1).Location = new Point(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.mgaButton1).Name = "mgaButton1";
    ((Control) this.mgaButton1).Size = new Size(104, 23);
    ((Control) this.mgaButton1).TabIndex = 24;
    ((Control) this.mgaButton1).Text = "&Ok";
    ((Control) this.mgaButton1).Click += new EventHandler(this.btnIssueNotice_Click);
    this.pictureBox2.Image = (Image) resourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(344, 8);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox2.TabIndex = 23;
    this.pictureBox2.TabStop = false;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(434, 120);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formReinstatementDatesOverRide);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Reinstatement Date Override";
    this.dsQuoteStatusReasons1.EndInit();
    ((ISupportInitialize) this.dateEffectiveDate).EndInit();
    ((ISupportInitialize) this.dateMailingDate).EndInit();
    this.ellipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.mgaButton2).EndInit();
    ((ISupportInitialize) this.mgaButton1).EndInit();
    this.ResumeLayout(false);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnIssueNotice_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  public DateTime PrintDate
  {
    get => this.dateMailingDate.DateTime;
    set
    {
      if (value < this.dateMailingDate.MinDate)
        value = DateTime.Now;
      this.dateMailingDate.DateTime = value;
    }
  }

  public DateTime EffectiveDate
  {
    get => this.dateEffectiveDate.DateTime;
    set
    {
      if (value < this.dateEffectiveDate.MinDate)
        value = DateTime.Now;
      this.dateEffectiveDate.DateTime = value;
    }
  }
}
