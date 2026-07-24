// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpensedCommissions
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.OperatingExpenses.UserControls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[SecureResource("{B9A8254E-03C8-4226-B96F-4FE4B5D5C752}", "Process Expensed Commission Rights", "Determines whether or not a user has the process expensed commission payments.", "Accounting")]
[TestForm]
public class formExpensedCommissions : AccountingNoteDocumentSupport
{
  private UltraLabel ultraLabel8;
  private UltraLabel ultraLabel6;
  private Panel panel1;
  private Label label2;
  private Label label1;
  private PictureBox pictureBox1;
  private Panel panel2;
  private MGAButton buttonFinish;
  private MGAButton buttonCancel;
  private Label label4;
  private UltraLabel ultraLabel1;
  private Panel panel3;
  private Label label3;
  private MGASimpleComboBox comboOfficeLocation;
  private Panel panelContent;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel7;
  private UltraPictureBox ultraPictureBox1;
  private UltraGroupBox ultraGroupBox1;
  private System.ComponentModel.Container components;
  private CommissionableEntity.CommissionableEntitySelectedHandler entitySelectedHandler;
  public const string EXPENSEDCOMMISSIONRIGHTS = "{B9A8254E-03C8-4226-B96F-4FE4B5D5C752}";

  public formExpensedCommissions()
  {
    this.InitializeComponent();
    this.ShowNothingFound();
    this.LoadOfficeLocations();
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
    ResourceManager resourceManager = new ResourceManager(typeof (formExpensedCommissions));
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
    this.ultraLabel8 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.panel1 = new Panel();
    this.label2 = new Label();
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.panel2 = new Panel();
    this.buttonFinish = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.label4 = new Label();
    this.ultraLabel1 = new UltraLabel();
    this.panel3 = new Panel();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.label3 = new Label();
    this.panelContent = new Panel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel7 = new UltraLabel();
    this.ultraPictureBox1 = new UltraPictureBox();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(150, 15);
    ((Control) this.ultraLabel8).TabIndex = 18;
    ((Control) this.ultraLabel8).Text = "EXPENSED COMMISSIONS";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance2;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(32 /*0x20*/, 112 /*0x70*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(130, 14);
    ((Control) this.ultraLabel6).TabIndex = 22;
    ((Control) this.ultraLabel6).Text = "Select an Office Location";
    this.panel1.BackColor = Color.White;
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.pictureBox1);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(840, 80 /*0x50*/);
    this.panel1.TabIndex = 17;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Dock = DockStyle.Bottom;
    this.label2.ForeColor = Color.Gray;
    this.label2.Location = new Point(0, 79);
    this.label2.Name = "label2";
    this.label2.Size = new Size(840, 1);
    this.label2.TabIndex = 1;
    this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(592, 48 /*0x30*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(229, 25);
    this.label1.TabIndex = 0;
    this.label1.Text = "Expensed Commissions";
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(-24, -24);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(184, 136);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.panel2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel2.Controls.Add((Control) this.buttonFinish);
    this.panel2.Controls.Add((Control) this.buttonCancel);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 582);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(840, 56);
    this.panel2.TabIndex = 31 /*0x1F*/;
    ((Control) this.buttonFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonFinish).Enabled = false;
    ((Control) this.buttonFinish).Location = new Point(648, 16 /*0x10*/);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(88, 24);
    ((Control) this.buttonFinish).TabIndex = 2;
    ((Control) this.buttonFinish).Text = "Finish";
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCancel).Location = new Point(744, 16 /*0x10*/);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.BorderStyle = BorderStyle.Fixed3D;
    this.label4.Dock = DockStyle.Top;
    this.label4.ForeColor = Color.Gray;
    this.label4.Location = new Point(0, 0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(840, 1);
    this.label4.TabIndex = 3;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel1).Dock = DockStyle.Left;
    ((Control) this.ultraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(176 /*0xB0*/, 502);
    ((UltraControlBase) this.ultraLabel1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel1).TabIndex = 32 /*0x20*/;
    this.panel3.BackColor = Color.White;
    this.panel3.Controls.Add((Control) this.comboOfficeLocation);
    this.panel3.Controls.Add((Control) this.label3);
    this.panel3.Dock = DockStyle.Top;
    this.panel3.Location = new Point(176 /*0xB0*/, 80 /*0x50*/);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(664, 32 /*0x20*/);
    this.panel3.TabIndex = 33;
    this.comboOfficeLocation.AutoSelectOnOneItem = true;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(104, 8);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(352, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 1;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "";
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.White;
    this.label3.Location = new Point(8, 8);
    this.label3.Name = "label3";
    this.label3.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.label3.TabIndex = 0;
    this.label3.Text = "Office Location:";
    this.panelContent.AutoScroll = true;
    this.panelContent.BackColor = Color.White;
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(176 /*0xB0*/, 112 /*0x70*/);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(664, 470);
    this.panelContent.TabIndex = 34;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 252, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel2).Font = new Font("Tahoma", 8.5f, FontStyle.Bold);
    ((Control) this.ultraLabel2).Location = new Point(8, 24);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(144 /*0x90*/, 32 /*0x20*/);
    ((Control) this.ultraLabel2).TabIndex = 19;
    ((Control) this.ultraLabel2).Text = "Working with Expensed Commissions.";
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance7;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(142, 14);
    ((Control) this.ultraLabel3).TabIndex = 23;
    ((Control) this.ultraLabel3).Text = "1. Select an Office Location";
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(247, 251, 253);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance8).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance8;
    ((Control) this.ultraLabel4).Location = new Point(16 /*0x10*/, 88);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(136, 64 /*0x40*/);
    ((Control) this.ultraLabel4).TabIndex = 24;
    ((Control) this.ultraLabel4).Text = "This will load all of the expensed commissions for the commissionable entities in the system.";
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance9;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(16 /*0x10*/, 152);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(91, 14);
    ((Control) this.ultraLabel5).TabIndex = 25;
    ((Control) this.ultraLabel5).Text = "2. Choose Payee";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance10;
    ((Control) this.ultraLabel7).Location = new Point(16 /*0x10*/, 168);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(139, 72);
    ((Control) this.ultraLabel7).TabIndex = 26;
    ((Control) this.ultraLabel7).Text = "Select the payee your wish to create a check for. After selecting the payee, right-click and pay off the items you wish to pay.";
    ((Control) this.ultraPictureBox1).AutoSize = true;
    this.ultraPictureBox1.BorderShadowColor = Color.Empty;
    this.ultraPictureBox1.Image = resourceManager.GetObject("ultraPictureBox1.Image");
    ((Control) this.ultraPictureBox1).Location = new Point(16 /*0x10*/, 312);
    ((Control) this.ultraPictureBox1).Name = "ultraPictureBox1";
    ((Control) this.ultraPictureBox1).Size = new Size(16 /*0x10*/, 15);
    ((Control) this.ultraPictureBox1).TabIndex = 36;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 252, 254);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance11;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel3);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel5);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel2);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel7);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel4);
    ((AppearanceBase) appearance12).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance12).ForeColor = Color.DimGray;
    this.ultraGroupBox1.HeaderAppearance = (AppearanceBase) appearance12;
    ((Control) this.ultraGroupBox1).Location = new Point(8, 312);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(160 /*0xA0*/, 256 /*0x0100*/);
    this.ultraGroupBox1.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraGroupBox1).TabIndex = 37;
    ((Control) this.ultraGroupBox1).Text = "      HELP";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(840, 638);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraPictureBox1);
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.ultraLabel6);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panel2);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formExpensedCommissions);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Expensed Commissions";
    this.panel1.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    this.entitySelectedHandler = new CommissionableEntity.CommissionableEntitySelectedHandler(this.OnEntitySelected);
    this.LoadCommissions(int.Parse(this.comboOfficeLocation.Value.ToString()));
  }

  private void LoadCommissions(int glCompanyId)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetExpensedCommissions", (object) "@glcompanyid", (object) glCompanyId);
      if (dataTable.Rows.Count == 0)
      {
        this.ShowNothingFound();
      }
      else
      {
        this.panelContent.Controls.Clear();
        foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
        {
          CommissionableEntity commissionableEntity = new CommissionableEntity(new Guid(row["payeeGuid"].ToString()), row["payeeName"].ToString(), Decimal.Parse(row["Amount"].ToString()), Decimal.Parse(row["FullAr"].ToString()), Decimal.Parse(row["ProportionalAR"].ToString()), Decimal.Parse(row["PTD"].ToString()));
          commissionableEntity.CommissionableEntitySelected += this.entitySelectedHandler;
          this.panelContent.Controls.Add((Control) commissionableEntity);
          commissionableEntity.Dock = DockStyle.Top;
        }
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ShowNothingFound()
  {
    Label label = new Label();
    label.Text = "No Expensed Commissions Found For the Specified GL Company!";
    label.TextAlign = ContentAlignment.MiddleCenter;
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) label);
    label.Dock = DockStyle.Fill;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void OnEntitySelected(
    object sender,
    CommissionableEntity.CommissionableEntitySelectedEventArgs e)
  {
    formExpensedCommissionsDetails commissionsDetails = new formExpensedCommissionsDetails(int.Parse(this.comboOfficeLocation.Value.ToString()), e.PayeeName, e.PayeeGuid, e.TotalCommission, e.CommissionDueARFullyReceived, e.ProportionalCommissionDue);
    commissionsDetails.MdiParent = MDIControls.Instance.MDIParent;
    commissionsDetails.Show();
  }

  public void RefreshForm()
  {
    this.LoadCommissions(int.Parse(this.comboOfficeLocation.Value.ToString()));
  }
}
