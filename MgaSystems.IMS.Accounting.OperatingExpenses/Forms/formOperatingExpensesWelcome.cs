// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formOperatingExpensesWelcome
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.OperatingExpenses.UserControls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[TestForm]
public class formOperatingExpensesWelcome : AccountingNoteDocumentSupport
{
  private PictureBox pictureBox1;
  private Label label1;
  internal Label label2;
  private Panel panelMain;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private System.ComponentModel.Container components;

  public formOperatingExpensesWelcome()
  {
    this.InitializeComponent();
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetOfficeLocations");
    if (dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      controlOperatingAutomationAccounts automationAccounts = new controlOperatingAutomationAccounts(int.Parse(row["id"].ToString()));
      this.panelMain.Controls.Add((Control) automationAccounts);
      automationAccounts.Dock = DockStyle.Top;
      automationAccounts.SendToBack();
    }
    Label label = new Label();
    label.Text = "";
    label.ForeColor = Color.White;
    label.Size = new Size(50, 50);
    label.Dock = DockStyle.Top;
    this.panelMain.Controls.Add((Control) label);
    label.BringToFront();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formOperatingExpensesWelcome));
    Appearance appearance1 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.label2 = new Label();
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.panelMain = new Panel();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl3).SuspendLayout();
    this.SuspendLayout();
    this.label2.BackColor = Color.Transparent;
    this.label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.ForeColor = Color.DimGray;
    this.label2.Location = new Point(96 /*0x60*/, 0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(420, 48 /*0x30*/);
    this.label2.TabIndex = 1;
    this.label2.Text = "elcome to the Operating Expenses module. Please take a moment to setup the accounts needed by the automation system. The type of account needed depends on the accounting method used by the specified GL Company.";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 26f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.DimGray;
    this.label1.Location = new Point(48 /*0x30*/, -8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(49, 45);
    this.label1.TabIndex = 0;
    this.label1.Text = "W";
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(1, 1);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.panelMain.AutoScroll = true;
    this.panelMain.BackColor = Color.Transparent;
    this.panelMain.Dock = DockStyle.Fill;
    this.panelMain.Location = new Point(0, 0);
    this.panelMain.Name = "panelMain";
    this.panelMain.Size = new Size(499, 243);
    this.panelMain.TabIndex = 1;
    ((Control) this.buttonSave).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.buttonSave.ButtonStyle = (UIElementButtonStyle) 14;
    ((Control) this.buttonSave).Location = new Point(256 /*0x0100*/, 0);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(104, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "&Save Changes";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.buttonCancel.ButtonStyle = (UIElementButtonStyle) 14;
    ((Control) this.buttonCancel).Location = new Point(368, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 50;
    explorerBarGroup1.Settings.ItemAreaInnerMargins.Bottom = 4;
    explorerBarGroup1.Settings.ItemAreaInnerMargins.Left = 4;
    explorerBarGroup1.Settings.ItemAreaInnerMargins.Right = 4;
    explorerBarGroup1.Settings.ItemAreaInnerMargins.Top = 4;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Welcome";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 245;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Office Locations";
    explorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 29;
    explorerBarGroup3.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.White;
    ((AppearanceBase) appearance3).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance3).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageBackground = (Image) resourceManager.GetObject("appearance3.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance4;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(536, 462);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 25;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.pictureBox1);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label2);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label1);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(14, 38);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(508, 48 /*0x30*/);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.panelMain);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(22, 137);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(499, 243);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(22, 411);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(499, 27);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(536, 462);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (formOperatingExpensesWelcome);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Welcome!";
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void buttonSave_Click(object sender, EventArgs e)
  {
    foreach (controlOperatingAutomationAccounts control in (ArrangedElementCollection) this.panelMain.Controls)
      control.Save();
    this.Close();
  }
}
