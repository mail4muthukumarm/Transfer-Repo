// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formAutomationAccounts
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Exceptions;
using MGASystems.IMS.Accounting.GeneralLedger.Controls;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{5FB0F07D-0F17-47e0-82F3-B65AEB20BB07}", "Add/Edit Automation Accounts", "Determines whether or not a user has the ability to add and edit automation account settings.", "Accounting")]
public class formAutomationAccounts : Form
{
  private Panel panel1;
  private Panel panel2;
  private UltraLabel ultraLabel1;
  private Label label1;
  private PictureBox pictureBox1;
  private UltraLabel ultraLabel8;
  private MGAButton buttonFinish;
  private MGAButton buttonCancel;
  private Panel panelOfficeLocations;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel3;
  private Label label2;
  private Panel panelContent;
  private MGASimpleComboBox comboOfficeLocations;
  private Label label3;
  private PictureBox pictureLoadAutomationSettings;
  private PictureBox pictureOfficeLocations;
  private System.ComponentModel.Container components;
  private DataTable _dataAutomationAccounts;

  public formAutomationAccounts()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
    this.LoadConfigurableAutomationAccounts();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formAutomationAccounts));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.panel1 = new Panel();
    this.label3 = new Label();
    this.pictureBox1 = new PictureBox();
    this.label1 = new Label();
    this.panel2 = new Panel();
    this.buttonFinish = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.panelOfficeLocations = new Panel();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.label2 = new Label();
    this.panelContent = new Panel();
    this.pictureLoadAutomationSettings = new PictureBox();
    this.pictureOfficeLocations = new PictureBox();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panelOfficeLocations.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    this.SuspendLayout();
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.pictureBox1);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(672, 80 /*0x50*/);
    this.panel1.TabIndex = 0;
    this.label3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label3.Dock = DockStyle.Bottom;
    this.label3.Location = new Point(0, 79);
    this.label3.Name = "label3";
    this.label3.Size = new Size(672, 1);
    this.label3.TabIndex = 3;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(24, 8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(84, 65);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 2;
    this.pictureBox1.TabStop = false;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(400, 48 /*0x30*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(265, 25);
    this.label1.TabIndex = 1;
    this.label1.Text = "Automation Accounts Setup";
    this.panel2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel2.Controls.Add((Control) this.buttonFinish);
    this.panel2.Controls.Add((Control) this.buttonCancel);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 462);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(672, 40);
    this.panel2.TabIndex = 1;
    ((Control) this.buttonFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonFinish).Enabled = false;
    ((Control) this.buttonFinish).Location = new Point(416, 8);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(120, 24);
    ((Control) this.buttonFinish).TabIndex = 4;
    ((Control) this.buttonFinish).Text = "Save Settings";
    ((Control) this.buttonFinish).Click += new EventHandler(this.buttonFinish_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(544, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(120, 24);
    ((Control) this.buttonCancel).TabIndex = 5;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel1).Dock = DockStyle.Left;
    ((Control) this.ultraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(160 /*0xA0*/, 382);
    ((Control) this.ultraLabel1).TabIndex = 2;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance4;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(140, 15);
    ((Control) this.ultraLabel8).TabIndex = 3;
    ((Control) this.ultraLabel8).Text = "AUTOMATION SETTINGS";
    this.panelOfficeLocations.Controls.Add((Control) this.comboOfficeLocations);
    this.panelOfficeLocations.Controls.Add((Control) this.label2);
    this.panelOfficeLocations.Dock = DockStyle.Top;
    this.panelOfficeLocations.Location = new Point(160 /*0xA0*/, 80 /*0x50*/);
    this.panelOfficeLocations.Name = "panelOfficeLocations";
    this.panelOfficeLocations.Size = new Size(512 /*0x0200*/, 40);
    this.panelOfficeLocations.TabIndex = 5;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "";
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(104, 8);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(392, 20);
    ((Control) this.comboOfficeLocations).TabIndex = 1;
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "";
    this.comboOfficeLocations.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocations_RowSelected);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(16 /*0x10*/, 8);
    this.label2.Name = "label2";
    this.label2.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.label2.TabIndex = 0;
    this.label2.Text = "Office Location:";
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(160 /*0xA0*/, 120);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(512 /*0x0200*/, 342);
    this.panelContent.TabIndex = 6;
    this.pictureLoadAutomationSettings.BackColor = Color.FromArgb(250, 247, 253);
    this.pictureLoadAutomationSettings.Image = (Image) resourceManager.GetObject("pictureLoadAutomationSettings.Image");
    this.pictureLoadAutomationSettings.Location = new Point(8, 144 /*0x90*/);
    this.pictureLoadAutomationSettings.Name = "pictureLoadAutomationSettings";
    this.pictureLoadAutomationSettings.Size = new Size(16 /*0x10*/, 15);
    this.pictureLoadAutomationSettings.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureLoadAutomationSettings.TabIndex = 31 /*0x1F*/;
    this.pictureLoadAutomationSettings.TabStop = false;
    this.pictureLoadAutomationSettings.Visible = false;
    this.pictureOfficeLocations.BackColor = Color.Transparent;
    this.pictureOfficeLocations.Image = (Image) resourceManager.GetObject("pictureOfficeLocations.Image");
    this.pictureOfficeLocations.Location = new Point(8, 112 /*0x70*/);
    this.pictureOfficeLocations.Name = "pictureOfficeLocations";
    this.pictureOfficeLocations.Size = new Size(16 /*0x10*/, 15);
    this.pictureOfficeLocations.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureOfficeLocations.TabIndex = 30;
    this.pictureOfficeLocations.TabStop = false;
    this.pictureOfficeLocations.Visible = false;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance5).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(24, 112 /*0x70*/);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(130, 14);
    ((Control) this.ultraLabel4).TabIndex = 28;
    ((Control) this.ultraLabel4).Text = "Select an Office Location";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(24, 144 /*0x90*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(134, 14);
    ((Control) this.ultraLabel3).TabIndex = 29;
    ((Control) this.ultraLabel3).Text = "Load Automation Settings";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(672, 502);
    this.Controls.Add((Control) this.pictureLoadAutomationSettings);
    this.Controls.Add((Control) this.pictureOfficeLocations);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelOfficeLocations);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formAutomationAccounts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Chart of Accounts - Automation";
    this.panel1.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panelOfficeLocations.ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
  }

  private void LoadConfigurableAutomationAccounts()
  {
    this._dataAutomationAccounts = Database.Instance.QuerySP.PerformTableQuery("spFin_GetEditableAutomationAccountRoles");
    if (this._dataAutomationAccounts == null || this._dataAutomationAccounts.Rows.Count == 0)
      throw new EditableAutomationAccountsNotFoundException("The system could not find any editable automation accounts.");
  }

  private void comboOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    this.pictureOfficeLocations.Visible = false;
    this.pictureLoadAutomationSettings.Visible = false;
    int glCompanyId = int.Parse(e.Row.Cells["ID"].Value.ToString());
    this.panelContent.Controls.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) this._dataAutomationAccounts.Rows)
    {
      AutomationAccountControl automationAccountControl = new AutomationAccountControl(row["AcctRoleId"].ToString(), glCompanyId);
      this.panelContent.Controls.Add((Control) automationAccountControl);
      automationAccountControl.Dock = DockStyle.Top;
    }
    this.pictureOfficeLocations.Visible = true;
    this.pictureLoadAutomationSettings.Visible = true;
    ((Control) this.buttonFinish).Enabled = true;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonFinish_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will change your automation settings, continue?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    foreach (Control control in (ArrangedElementCollection) this.panelContent.Controls)
    {
      if (control is AutomationAccountControl && (control as AutomationAccountControl).HasChanges)
        (control as AutomationAccountControl).SaveSetting();
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }
}
