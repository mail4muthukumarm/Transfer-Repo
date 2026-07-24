// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.SharedServices.formEntityAccountsBreakdown
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.SharedServices;

public class formEntityAccountsBreakdown : Form
{
  private System.ComponentModel.Container components;
  private EllipsePanel ellipsePanel1;
  private Label label2;
  private Label labelEntityName;
  private Label label1;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label label8;
  private Label labelARAccountNumber;
  private Label labelUAAccountNumber;
  private Label labelAPAccountNumber;
  private Label labelEXAccountNumber;
  private Label labelReceivablesAccountName;
  private Label labelExchangeAccountName;
  private Label labelUnAccountedAccountName;
  private Label labelPayablesAccountName;
  private Label labelARAccountBalance;
  private Label labelEXAccountBalance;
  private Label labelUAAccountBalance;
  private Label labelAPAccountBalance;
  private LinkLabel linkViewARAccountLog;
  private LinkLabel linkViewUAAccountLog;
  private LinkLabel linkViewEXAccountLog;
  private LinkLabel linkViewAPAccountLog;
  private Guid entityGuid;
  private string entityName;
  private int glCompanyId;

  public formEntityAccountsBreakdown(Guid entityGuid, string entityName, int glCompanyId)
  {
    this.InitializeComponent();
    this.entityGuid = entityGuid;
    this.entityName = entityName;
    this.glCompanyId = glCompanyId;
    this.DisplayAccounts();
  }

  public Guid EntityGuid => this.entityGuid;

  public string EntityName => this.entityName;

  public int GlCompanyId => this.glCompanyId;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.ellipsePanel1 = new EllipsePanel();
    this.linkViewEXAccountLog = new LinkLabel();
    this.linkViewAPAccountLog = new LinkLabel();
    this.linkViewUAAccountLog = new LinkLabel();
    this.labelAPAccountBalance = new Label();
    this.labelUAAccountBalance = new Label();
    this.labelEXAccountBalance = new Label();
    this.labelARAccountBalance = new Label();
    this.labelPayablesAccountName = new Label();
    this.labelUnAccountedAccountName = new Label();
    this.labelExchangeAccountName = new Label();
    this.labelReceivablesAccountName = new Label();
    this.labelEXAccountNumber = new Label();
    this.labelAPAccountNumber = new Label();
    this.labelUAAccountNumber = new Label();
    this.labelARAccountNumber = new Label();
    this.linkViewARAccountLog = new LinkLabel();
    this.label8 = new Label();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label1 = new Label();
    this.labelEntityName = new Label();
    this.label2 = new Label();
    this.ellipsePanel1.SuspendLayout();
    this.SuspendLayout();
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.linkViewEXAccountLog);
    this.ellipsePanel1.Controls.Add((Control) this.linkViewAPAccountLog);
    this.ellipsePanel1.Controls.Add((Control) this.linkViewUAAccountLog);
    this.ellipsePanel1.Controls.Add((Control) this.labelAPAccountBalance);
    this.ellipsePanel1.Controls.Add((Control) this.labelUAAccountBalance);
    this.ellipsePanel1.Controls.Add((Control) this.labelEXAccountBalance);
    this.ellipsePanel1.Controls.Add((Control) this.labelARAccountBalance);
    this.ellipsePanel1.Controls.Add((Control) this.labelPayablesAccountName);
    this.ellipsePanel1.Controls.Add((Control) this.labelUnAccountedAccountName);
    this.ellipsePanel1.Controls.Add((Control) this.labelExchangeAccountName);
    this.ellipsePanel1.Controls.Add((Control) this.labelReceivablesAccountName);
    this.ellipsePanel1.Controls.Add((Control) this.labelEXAccountNumber);
    this.ellipsePanel1.Controls.Add((Control) this.labelAPAccountNumber);
    this.ellipsePanel1.Controls.Add((Control) this.labelUAAccountNumber);
    this.ellipsePanel1.Controls.Add((Control) this.labelARAccountNumber);
    this.ellipsePanel1.Controls.Add((Control) this.linkViewARAccountLog);
    this.ellipsePanel1.Controls.Add((Control) this.label8);
    this.ellipsePanel1.Controls.Add((Control) this.label7);
    this.ellipsePanel1.Controls.Add((Control) this.label6);
    this.ellipsePanel1.Controls.Add((Control) this.label5);
    this.ellipsePanel1.Controls.Add((Control) this.label4);
    this.ellipsePanel1.Controls.Add((Control) this.label3);
    this.ellipsePanel1.Controls.Add((Control) this.label1);
    this.ellipsePanel1.Controls.Add((Control) this.labelEntityName);
    this.ellipsePanel1.Controls.Add((Control) this.label2);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(808, 176 /*0xB0*/);
    this.ellipsePanel1.TabIndex = 0;
    this.linkViewEXAccountLog.AutoSize = true;
    this.linkViewEXAccountLog.Location = new Point(816, 152);
    this.linkViewEXAccountLog.Name = "linkViewEXAccountLog";
    this.linkViewEXAccountLog.Size = new Size(108, 16 /*0x10*/);
    this.linkViewEXAccountLog.TabIndex = 24;
    this.linkViewEXAccountLog.TabStop = true;
    this.linkViewEXAccountLog.Text = "View Transaction Log";
    this.linkViewEXAccountLog.Visible = false;
    this.linkViewAPAccountLog.AutoSize = true;
    this.linkViewAPAccountLog.Location = new Point(816, 88);
    this.linkViewAPAccountLog.Name = "linkViewAPAccountLog";
    this.linkViewAPAccountLog.Size = new Size(108, 16 /*0x10*/);
    this.linkViewAPAccountLog.TabIndex = 23;
    this.linkViewAPAccountLog.TabStop = true;
    this.linkViewAPAccountLog.Text = "View Transaction Log";
    this.linkViewAPAccountLog.Visible = false;
    this.linkViewUAAccountLog.AutoSize = true;
    this.linkViewUAAccountLog.Location = new Point(816, 120);
    this.linkViewUAAccountLog.Name = "linkViewUAAccountLog";
    this.linkViewUAAccountLog.Size = new Size(108, 16 /*0x10*/);
    this.linkViewUAAccountLog.TabIndex = 22;
    this.linkViewUAAccountLog.TabStop = true;
    this.linkViewUAAccountLog.Text = "View Transaction Log";
    this.linkViewUAAccountLog.Visible = false;
    this.labelAPAccountBalance.Location = new Point(656, 88);
    this.labelAPAccountBalance.Name = "labelAPAccountBalance";
    this.labelAPAccountBalance.Size = new Size(143, 16 /*0x10*/);
    this.labelAPAccountBalance.TabIndex = 21;
    this.labelAPAccountBalance.Text = "[$0.00]";
    this.labelAPAccountBalance.TextAlign = ContentAlignment.TopRight;
    this.labelUAAccountBalance.Location = new Point(656, 120);
    this.labelUAAccountBalance.Name = "labelUAAccountBalance";
    this.labelUAAccountBalance.Size = new Size(143, 16 /*0x10*/);
    this.labelUAAccountBalance.TabIndex = 20;
    this.labelUAAccountBalance.Text = "[$0.00]";
    this.labelUAAccountBalance.TextAlign = ContentAlignment.TopRight;
    this.labelEXAccountBalance.Location = new Point(656, 152);
    this.labelEXAccountBalance.Name = "labelEXAccountBalance";
    this.labelEXAccountBalance.Size = new Size(143, 16 /*0x10*/);
    this.labelEXAccountBalance.TabIndex = 19;
    this.labelEXAccountBalance.Text = "[$0.00]";
    this.labelEXAccountBalance.TextAlign = ContentAlignment.TopRight;
    this.labelARAccountBalance.Location = new Point(656, 56);
    this.labelARAccountBalance.Name = "labelARAccountBalance";
    this.labelARAccountBalance.Size = new Size(143, 16 /*0x10*/);
    this.labelARAccountBalance.TabIndex = 18;
    this.labelARAccountBalance.Text = "[$0.00]";
    this.labelARAccountBalance.TextAlign = ContentAlignment.TopRight;
    this.labelPayablesAccountName.Location = new Point(256 /*0x0100*/, 88);
    this.labelPayablesAccountName.Name = "labelPayablesAccountName";
    this.labelPayablesAccountName.Size = new Size(416, 16 /*0x10*/);
    this.labelPayablesAccountName.TabIndex = 17;
    this.labelPayablesAccountName.Text = "[Payables Account Name]";
    this.labelUnAccountedAccountName.Location = new Point(256 /*0x0100*/, 120);
    this.labelUnAccountedAccountName.Name = "labelUnAccountedAccountName";
    this.labelUnAccountedAccountName.Size = new Size(416, 16 /*0x10*/);
    this.labelUnAccountedAccountName.TabIndex = 16 /*0x10*/;
    this.labelUnAccountedAccountName.Text = "[UnAccounted Account Name]";
    this.labelExchangeAccountName.Location = new Point(256 /*0x0100*/, 152);
    this.labelExchangeAccountName.Name = "labelExchangeAccountName";
    this.labelExchangeAccountName.Size = new Size(416, 16 /*0x10*/);
    this.labelExchangeAccountName.TabIndex = 15;
    this.labelExchangeAccountName.Text = "[Exchange Account Name]";
    this.labelReceivablesAccountName.Location = new Point(256 /*0x0100*/, 56);
    this.labelReceivablesAccountName.Name = "labelReceivablesAccountName";
    this.labelReceivablesAccountName.Size = new Size(416, 16 /*0x10*/);
    this.labelReceivablesAccountName.TabIndex = 14;
    this.labelReceivablesAccountName.Text = "[Receivables Account Name]";
    this.labelEXAccountNumber.AutoSize = true;
    this.labelEXAccountNumber.Location = new Point(152, 152);
    this.labelEXAccountNumber.Name = "labelEXAccountNumber";
    this.labelEXAccountNumber.Size = new Size(93, 16 /*0x10*/);
    this.labelEXAccountNumber.TabIndex = 13;
    this.labelEXAccountNumber.Text = "[Account Number]";
    this.labelAPAccountNumber.AutoSize = true;
    this.labelAPAccountNumber.Location = new Point(152, 88);
    this.labelAPAccountNumber.Name = "labelAPAccountNumber";
    this.labelAPAccountNumber.Size = new Size(93, 16 /*0x10*/);
    this.labelAPAccountNumber.TabIndex = 12;
    this.labelAPAccountNumber.Text = "[Account Number]";
    this.labelUAAccountNumber.AutoSize = true;
    this.labelUAAccountNumber.Location = new Point(152, 120);
    this.labelUAAccountNumber.Name = "labelUAAccountNumber";
    this.labelUAAccountNumber.Size = new Size(93, 16 /*0x10*/);
    this.labelUAAccountNumber.TabIndex = 11;
    this.labelUAAccountNumber.Text = "[Account Number]";
    this.labelARAccountNumber.AutoSize = true;
    this.labelARAccountNumber.Location = new Point(152, 56);
    this.labelARAccountNumber.Name = "labelARAccountNumber";
    this.labelARAccountNumber.Size = new Size(93, 16 /*0x10*/);
    this.labelARAccountNumber.TabIndex = 10;
    this.labelARAccountNumber.Text = "[Account Number]";
    this.linkViewARAccountLog.AutoSize = true;
    this.linkViewARAccountLog.Location = new Point(816, 56);
    this.linkViewARAccountLog.Name = "linkViewARAccountLog";
    this.linkViewARAccountLog.Size = new Size(108, 16 /*0x10*/);
    this.linkViewARAccountLog.TabIndex = 9;
    this.linkViewARAccountLog.TabStop = true;
    this.linkViewARAccountLog.Text = "View Transaction Log";
    this.linkViewARAccountLog.Visible = false;
    this.label8.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label8.Location = new Point(696, 32 /*0x20*/);
    this.label8.Name = "label8";
    this.label8.Size = new Size(104, 16 /*0x10*/);
    this.label8.TabIndex = 8;
    this.label8.Text = "Account Balance";
    this.label8.TextAlign = ContentAlignment.TopRight;
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label7.Location = new Point(256 /*0x0100*/, 32 /*0x20*/);
    this.label7.Name = "label7";
    this.label7.Size = new Size(84, 16 /*0x10*/);
    this.label7.TabIndex = 7;
    this.label7.Text = "Account Name";
    this.label6.AutoSize = true;
    this.label6.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label6.Location = new Point(152, 32 /*0x20*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.label6.TabIndex = 6;
    this.label6.Text = "Account Number";
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label5.Location = new Point(8, 88);
    this.label5.Name = "label5";
    this.label5.Size = new Size(105, 16 /*0x10*/);
    this.label5.TabIndex = 5;
    this.label5.Text = "Payables Account:";
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label4.Location = new Point(8, 120);
    this.label4.Name = "label4";
    this.label4.Size = new Size(134, 16 /*0x10*/);
    this.label4.TabIndex = 4;
    this.label4.Text = "Un-Accounted Account:";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label3.Location = new Point(8, 152);
    this.label3.Name = "label3";
    this.label3.Size = new Size(109, 16 /*0x10*/);
    this.label3.TabIndex = 3;
    this.label3.Text = "Exchange Account:";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label1.Location = new Point(8, 56);
    this.label1.Name = "label1";
    this.label1.Size = new Size(116, 16 /*0x10*/);
    this.label1.TabIndex = 2;
    this.label1.Text = "Receivable Account:";
    this.labelEntityName.AutoSize = true;
    this.labelEntityName.Font = new Font("Tahoma", 10f);
    this.labelEntityName.Location = new Point(88, 8);
    this.labelEntityName.Name = "labelEntityName";
    this.labelEntityName.Size = new Size(98, 20);
    this.labelEntityName.TabIndex = 1;
    this.labelEntityName.Text = "[ Entity Name ]";
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 10f);
    this.label2.Location = new Point(8, 8);
    this.label2.Name = "label2";
    this.label2.Size = new Size(84, 20);
    this.label2.TabIndex = 0;
    this.label2.Text = "Entity Name:";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(826, 190);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formEntityAccountsBreakdown);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Entity Accounts Information";
    this.TopMost = true;
    this.ellipsePanel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void DisplayAccounts()
  {
    this.labelEntityName.Text = this.EntityName;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetEntityGlAccountStatus", new object[2]
    {
      (object) "@entityGuid",
      (object) this.EntityGuid
    });
    if (dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      switch (row["acctrole"].ToString())
      {
        case "R":
          this.labelARAccountNumber.Text = row["accountNumber"].ToString();
          this.labelReceivablesAccountName.Text = row["fullname"].ToString();
          this.labelARAccountBalance.Text = Decimal.Parse(row["balance"].ToString()).ToString("c");
          this.linkViewARAccountLog.Tag = (object) int.Parse(row["glacctid"].ToString());
          continue;
        case "P":
          this.labelAPAccountNumber.Text = row["accountNumber"].ToString();
          this.labelPayablesAccountName.Text = row["fullname"].ToString();
          this.labelAPAccountBalance.Text = Decimal.Parse(row["balance"].ToString()).ToString("c");
          this.linkViewAPAccountLog.Tag = (object) int.Parse(row["glacctid"].ToString());
          continue;
        case "X":
          this.labelEXAccountNumber.Text = row["accountNumber"].ToString();
          this.labelExchangeAccountName.Text = row["fullname"].ToString();
          this.labelEXAccountBalance.Text = Decimal.Parse(row["balance"].ToString()).ToString("c");
          this.linkViewEXAccountLog.Tag = (object) int.Parse(row["glacctid"].ToString());
          continue;
        case "S":
          this.labelUAAccountNumber.Text = row["accountNumber"].ToString();
          this.labelUnAccountedAccountName.Text = row["fullname"].ToString();
          this.labelUAAccountBalance.Text = Decimal.Parse(row["balance"].ToString()).ToString("c");
          this.linkViewUAAccountLog.Tag = (object) int.Parse(row["glacctid"].ToString());
          continue;
        default:
          continue;
      }
    }
  }
}
