// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formReconcilePrePaidExpense
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formReconcilePrePaidExpense : AccountingNoteDocumentSupport
{
  private System.ComponentModel.Container components;
  private int poNumber;
  private string payee;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private Label label1;
  private Label label2;
  private Label label3;
  private MGADateTimePicker datePaymentDate;
  private Label labelScheduledDate;
  private Label labelPayeeName;
  private MGAButton buttonOk;
  private MGAButton buttonCancel;
  private DateTime scheduledPaymentDate;
  private int glCompanyId;

  public formReconcilePrePaidExpense(
    int PurchaseOrderNumber,
    DateTime ScheduledPaymentDate,
    string Payee,
    int GlCompanyId)
  {
    this.InitializeComponent();
    this.poNumber = PurchaseOrderNumber;
    this.scheduledPaymentDate = ScheduledPaymentDate;
    this.payee = Payee;
    this.glCompanyId = GlCompanyId;
    this.labelPayeeName.Text = Payee;
    this.labelScheduledDate.Text = ScheduledPaymentDate.ToString("d");
    this.datePaymentDate.DateTime = ScheduledPaymentDate;
  }

  public int PurchaseOrderNumber => this.PurchaseOrderNumber;

  public DateTime ScheduledPaymentDate => this.scheduledPaymentDate;

  public string PayeeName => this.payee;

  public int GlCompanyId => this.glCompanyId;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formReconcilePrePaidExpense));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.datePaymentDate = new MGADateTimePicker();
    this.labelScheduledDate = new Label();
    this.labelPayeeName = new Label();
    this.buttonOk = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.datePaymentDate).BeginInit();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup.Settings.ContainerHeight = 117;
    ((UltraExplorerBarSettingsBase) explorerBarGroup.Settings).MaxLines = 100;
    explorerBarGroup.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup.Settings.Style = (GroupStyle) 6;
    explorerBarGroup.Text = "Reconcile Pre-Paid Expense";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[1]
    {
      explorerBarGroup
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
    ((Control) this.ultraExplorerBar1).Size = new Size(410, 176 /*0xB0*/);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 0;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.buttonOk);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.labelPayeeName);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.labelScheduledDate);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.datePaymentDate);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label3);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label2);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label1);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(22, 43);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(373, 115);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(37, 16 /*0x10*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "Payee:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(8, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(129, 16 /*0x10*/);
    this.label2.TabIndex = 1;
    this.label2.Text = "Scheduled Payment Date:";
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(8, 56);
    this.label3.Name = "label3";
    this.label3.Size = new Size(76, 16 /*0x10*/);
    this.label3.TabIndex = 2;
    this.label3.Text = "Payment Date:";
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb(78, 122, 171);
    this.datePaymentDate.Appearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance6).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance6).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance6).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance6).ForegroundAlpha = (Alpha) 2;
    this.datePaymentDate.ButtonAppearance = (AppearanceBase) appearance6;
    this.datePaymentDate.FormatString = "D";
    ((Control) this.datePaymentDate).Location = new Point(144 /*0x90*/, 56);
    this.datePaymentDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.datePaymentDate).Name = "datePaymentDate";
    ((Control) this.datePaymentDate).Size = new Size(216, 20);
    ((Control) this.datePaymentDate).TabIndex = 3;
    this.labelScheduledDate.AutoSize = true;
    this.labelScheduledDate.BackColor = Color.Transparent;
    this.labelScheduledDate.Location = new Point(144 /*0x90*/, 32 /*0x20*/);
    this.labelScheduledDate.Name = "labelScheduledDate";
    this.labelScheduledDate.Size = new Size(0, 16 /*0x10*/);
    this.labelScheduledDate.TabIndex = 4;
    this.labelPayeeName.AutoSize = true;
    this.labelPayeeName.BackColor = Color.Transparent;
    this.labelPayeeName.Location = new Point(144 /*0x90*/, 8);
    this.labelPayeeName.Name = "labelPayeeName";
    this.labelPayeeName.Size = new Size(0, 16 /*0x10*/);
    this.labelPayeeName.TabIndex = 5;
    ((AppearanceBase) appearance7).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance7).BackColor2 = Color.White;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonOk).Location = new Point(160 /*0xA0*/, 88);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonOk).TabIndex = 6;
    ((Control) this.buttonOk).Text = "Reconcile";
    ((Control) this.buttonOk).Click += new EventHandler(this.buttonOk_Click);
    ((AppearanceBase) appearance8).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance8).BackColor2 = Color.White;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance8;
    ((Control) this.buttonCancel).Location = new Point(264, 88);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonCancel).TabIndex = 7;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(410, 176 /*0xB0*/);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formReconcilePrePaidExpense);
    this.Text = "Reconcile Pre-Paid Expense";
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.datePaymentDate).EndInit();
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonOk_Click(object sender, EventArgs e)
  {
    try
    {
      Database.Instance.QuerySP.PerformNonQuery(true, "spFin_RecognizePrePaidExpense", (object) "@ponum", (object) this.poNumber, (object) "@postdate", (object) this.datePaymentDate.DateTime, (object) "@userguid", (object) CurrentUser.Instance.UserGUID, (object) "@glcompanyid", (object) this.glCompanyId);
      this.RefreshOwnerData();
      this.Close();
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to reconcile the specified prepaid expense transaction. " + ex.Errors[0].Message);
    }
  }

  private void RefreshOwnerData()
  {
    foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild is formOperatingTasks)
      {
        ((formOperatingTasks) mdiChild).ReloadData();
        break;
      }
    }
  }
}
