// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.UserControls.AccountingExplorerControl
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.UserControls;

public class AccountingExplorerControl : UserControl
{
  private Panel panelTotals;
  private Panel panelLoading;
  private Label label1;
  private PictureBox pictureBox1;
  private LinkLabel linkLabel1;
  private Panel panel1;
  private Label label2;
  private Panel panel2;
  private Label label5;
  private Label label6;
  private Label label4;
  private Label label3;
  private System.ComponentModel.Container components;

  public AccountingExplorerControl() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (AccountingExplorerControl));
    this.panelTotals = new Panel();
    this.panelLoading = new Panel();
    this.pictureBox1 = new PictureBox();
    this.label1 = new Label();
    this.linkLabel1 = new LinkLabel();
    this.panel1 = new Panel();
    this.panel2 = new Panel();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.panelLoading.SuspendLayout();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    this.SuspendLayout();
    this.panelTotals.AutoScroll = true;
    this.panelTotals.BackColor = Color.Transparent;
    this.panelTotals.Location = new Point(0, 0);
    this.panelTotals.Name = "panelTotals";
    this.panelTotals.Size = new Size(536, 280);
    this.panelTotals.TabIndex = 0;
    this.panelLoading.BackColor = Color.Transparent;
    this.panelLoading.Controls.Add((Control) this.pictureBox1);
    this.panelLoading.Controls.Add((Control) this.label1);
    this.panelLoading.Location = new Point(0, 0);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(536, 160 /*0xA0*/);
    this.panelLoading.TabIndex = 0;
    this.pictureBox1.Anchor = AnchorStyles.Top;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(240 /*0xF0*/, 128 /*0x80*/);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(45, 11);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    this.label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.label1.Location = new Point(8, 72);
    this.label1.Name = "label1";
    this.label1.Size = new Size(520, 23);
    this.label1.TabIndex = 0;
    this.label1.Text = "Loadng....";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    this.linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.BackColor = Color.Transparent;
    this.linkLabel1.Location = new Point(760, 272);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(41, 16 /*0x10*/);
    this.linkLabel1.TabIndex = 1;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "Refresh";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.panel1.AutoScroll = true;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Location = new Point(544, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(256 /*0x0100*/, 264);
    this.panel1.TabIndex = 5;
    this.panel2.AutoScroll = true;
    this.panel2.Controls.Add((Control) this.label5);
    this.panel2.Controls.Add((Control) this.label6);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Controls.Add((Control) this.label3);
    this.panel2.Dock = DockStyle.Fill;
    this.panel2.Location = new Point(0, 24);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(254, 238);
    this.panel2.TabIndex = 6;
    this.label5.BackColor = Color.Transparent;
    this.label5.Dock = DockStyle.Top;
    this.label5.Font = new Font("Tahoma", 8f);
    this.label5.ForeColor = Color.Black;
    this.label5.Location = new Point(0, 176 /*0xB0*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(237, 120);
    this.label5.TabIndex = 15;
    this.label5.Text = "Not just a new look, but new functinalfity has also been added. With the 'Close Fiscal Year Utility' and the new 'Year-End' processes, users can now move income statement financials to retained earnings with the click of a button. The enhanced GL Account management portal now shows users an extended view of GL Accounts within the system and allows users to navigate straight to the transaction details screen to view transactions for a specific account.";
    this.label5.TextAlign = ContentAlignment.TopCenter;
    this.label5.UseMnemonic = false;
    this.label6.BackColor = Color.Transparent;
    this.label6.Dock = DockStyle.Top;
    this.label6.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label6.ForeColor = Color.Black;
    this.label6.Location = new Point(0, 152);
    this.label6.Name = "label6";
    this.label6.Size = new Size(237, 24);
    this.label6.TabIndex = 14;
    this.label6.Text = "New Features";
    this.label6.TextAlign = ContentAlignment.TopCenter;
    this.label6.UseMnemonic = false;
    this.label4.BackColor = Color.Transparent;
    this.label4.Dock = DockStyle.Top;
    this.label4.Font = new Font("Tahoma", 8f);
    this.label4.ForeColor = Color.Black;
    this.label4.Location = new Point(0, 24);
    this.label4.Name = "label4";
    this.label4.Size = new Size(237, 128 /*0x80*/);
    this.label4.TabIndex = 13;
    this.label4.Text = "In case you did'nt notice, the IMS Integrated accounting system has gotten an overhaul. The new plug & play menu system will allow new functionality to be deployed more rapidly.";
    this.label4.TextAlign = ContentAlignment.TopCenter;
    this.label4.UseMnemonic = false;
    this.label3.BackColor = Color.Transparent;
    this.label3.Dock = DockStyle.Top;
    this.label3.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label3.ForeColor = Color.Black;
    this.label3.Location = new Point(0, 0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(237, 24);
    this.label3.TabIndex = 12;
    this.label3.Text = "New Look & Feel";
    this.label3.TextAlign = ContentAlignment.TopCenter;
    this.label3.UseMnemonic = false;
    this.label2.BackColor = Color.Transparent;
    this.label2.Dock = DockStyle.Top;
    this.label2.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label2.ForeColor = Color.SlateGray;
    this.label2.Location = new Point(0, 0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(254, 24);
    this.label2.TabIndex = 7;
    this.label2.Text = " What's New!";
    this.label2.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.linkLabel1);
    this.Controls.Add((Control) this.panelLoading);
    this.Controls.Add((Control) this.panelTotals);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (AccountingExplorerControl);
    this.Size = new Size(808, 288);
    this.panelLoading.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public void RefreshData() => this.GetAccountingTotals();

  private void GetAccountingTotals()
  {
    this.panelLoading.Visible = true;
    this.panelLoading.BringToFront();
    this.panelTotals.Controls.Clear();
    new Thread(new ThreadStart(this.DoGetAccountingTotals))
    {
      IsBackground = true,
      Name = nameof (GetAccountingTotals)
    }.Start();
  }

  private void DoGetAccountingTotals()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_GetAccountingLedgerTotals", connection))
      {
        sqlCommand.CommandTimeout = 600;
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
          if (!this.IsDisposed && !this.Disposing)
            this.Invoke((Delegate) new AccountingExplorerControl.GetAccountingTotalsAddControlHandler(this.GetAccountingAddControl), (object) int.Parse(sqlDataReader["glCompanyId"].ToString()), (object) sqlDataReader["OfficeLocation"].ToString(), (object) Decimal.Parse(sqlDataReader["ReceivablesToDate"].ToString()), (object) Decimal.Parse(sqlDataReader["PayablesToDate"].ToString()));
        }
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new AccountingExplorerControl.GetAccountingTotalsCompletedHandler(this.GetAccountingTotalsCompleted));
  }

  private void GetAccountingAddControl(
    int glCompanyId,
    string locationName,
    Decimal totalReceivables,
    Decimal totalPayables)
  {
    GLCompanyTotals glCompanyTotals = new GLCompanyTotals(glCompanyId, locationName, totalReceivables, totalPayables);
    glCompanyTotals.BackColor = Color.Transparent;
    this.panelTotals.Controls.Add((Control) glCompanyTotals);
    glCompanyTotals.Dock = DockStyle.Top;
  }

  private void GetAccountingTotalsCompleted()
  {
    this.panelLoading.Visible = false;
    this.panelLoading.SendToBack();
  }

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.RefreshData();
  }

  protected override void OnLoad(EventArgs e)
  {
    base.OnLoad(e);
    this.GetAccountingTotals();
  }

  private delegate void GetAccountingTotalsAddControlHandler(
    int glCompanyId,
    string locationName,
    Decimal totalReceivables,
    Decimal totalPayables);

  private delegate void GetAccountingTotalsCompletedHandler();
}
