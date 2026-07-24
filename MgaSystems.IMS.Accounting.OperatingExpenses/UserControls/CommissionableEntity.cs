// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.CommissionableEntity
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class CommissionableEntity : UserControl
{
  private Label labelPayeeName;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label labelTotalCommission;
  private Label labelFullARCommission;
  private Label labelProportionalCommission;
  private Label labelAmountPTD;
  private LinkLabel linkCreateCheck;
  private System.ComponentModel.Container components;
  private Guid _payeeGuid;
  private string _payeeName;
  private Decimal _commissionTotal;
  private Decimal _fullPaidCommission;
  private Decimal _proportionalCommission;
  private Decimal _amountPTD;

  private CommissionableEntity() => this.InitializeComponent();

  public CommissionableEntity(
    Guid payeeGuid,
    string payeeName,
    Decimal commissionTotal,
    Decimal fullPayCommission,
    Decimal proportionalCommission,
    Decimal amountPTD)
  {
    this.InitializeComponent();
    this._payeeGuid = payeeGuid;
    this._payeeName = payeeName;
    this._commissionTotal = commissionTotal;
    this._fullPaidCommission = fullPayCommission;
    this._proportionalCommission = proportionalCommission;
    this._amountPTD = amountPTD;
    this.SetFields();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.labelPayeeName = new Label();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.labelTotalCommission = new Label();
    this.labelFullARCommission = new Label();
    this.labelProportionalCommission = new Label();
    this.labelAmountPTD = new Label();
    this.linkCreateCheck = new LinkLabel();
    this.SuspendLayout();
    this.labelPayeeName.AutoSize = true;
    this.labelPayeeName.BackColor = Color.White;
    this.labelPayeeName.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelPayeeName.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelPayeeName.Location = new Point(8, 0);
    this.labelPayeeName.Name = "labelPayeeName";
    this.labelPayeeName.Size = new Size(92, 18);
    this.labelPayeeName.TabIndex = 0;
    this.labelPayeeName.Text = "[PAYEENAME]";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label1.Location = new Point(8, 24);
    this.label1.Name = "label1";
    this.label1.Size = new Size(108, 16 /*0x10*/);
    this.label1.TabIndex = 1;
    this.label1.Text = "Total Commissions";
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label2.Location = new Point(176 /*0xB0*/, 24);
    this.label2.Name = "label2";
    this.label2.Size = new Size(86, 16 /*0x10*/);
    this.label2.TabIndex = 2;
    this.label2.Text = "A/R Fully Rcvd";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label3.Location = new Point(336, 24);
    this.label3.Name = "label3";
    this.label3.Size = new Size(125, 16 /*0x10*/);
    this.label3.TabIndex = 3;
    this.label3.Text = "Proportional AMT Due";
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label4.Location = new Point(528, 24);
    this.label4.Name = "label4";
    this.label4.Size = new Size(73, 16 /*0x10*/);
    this.label4.TabIndex = 4;
    this.label4.Text = "Amount PTD";
    this.label5.BackColor = Color.WhiteSmoke;
    this.label5.Location = new Point(40, 64 /*0x40*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(525, 1);
    this.label5.TabIndex = 5;
    this.label5.Text = "label5";
    this.labelTotalCommission.Location = new Point(8, 40);
    this.labelTotalCommission.Name = "labelTotalCommission";
    this.labelTotalCommission.Size = new Size(104, 16 /*0x10*/);
    this.labelTotalCommission.TabIndex = 6;
    this.labelTotalCommission.Text = "$0.00";
    this.labelTotalCommission.TextAlign = ContentAlignment.TopRight;
    this.labelFullARCommission.Location = new Point(176 /*0xB0*/, 40);
    this.labelFullARCommission.Name = "labelFullARCommission";
    this.labelFullARCommission.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.labelFullARCommission.TabIndex = 7;
    this.labelFullARCommission.Text = "$0.00";
    this.labelFullARCommission.TextAlign = ContentAlignment.TopRight;
    this.labelProportionalCommission.Location = new Point(336, 40);
    this.labelProportionalCommission.Name = "labelProportionalCommission";
    this.labelProportionalCommission.Size = new Size(120, 16 /*0x10*/);
    this.labelProportionalCommission.TabIndex = 8;
    this.labelProportionalCommission.Text = "$0.00";
    this.labelProportionalCommission.TextAlign = ContentAlignment.TopRight;
    this.labelAmountPTD.BackColor = Color.White;
    this.labelAmountPTD.Font = new Font("Tahoma", 8f);
    this.labelAmountPTD.ForeColor = Color.Black;
    this.labelAmountPTD.Location = new Point(504, 40);
    this.labelAmountPTD.Name = "labelAmountPTD";
    this.labelAmountPTD.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.labelAmountPTD.TabIndex = 9;
    this.labelAmountPTD.Text = "$0.00";
    this.labelAmountPTD.TextAlign = ContentAlignment.TopRight;
    this.linkCreateCheck.AutoSize = true;
    this.linkCreateCheck.Location = new Point(456, 0);
    this.linkCreateCheck.Name = "linkCreateCheck";
    this.linkCreateCheck.Size = new Size(156, 16 /*0x10*/);
    this.linkCreateCheck.TabIndex = 10;
    this.linkCreateCheck.TabStop = true;
    this.linkCreateCheck.Text = "CREATE CHECK/VIEW DETAILS";
    this.linkCreateCheck.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateCheck_LinkClicked);
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.linkCreateCheck);
    this.Controls.Add((Control) this.labelAmountPTD);
    this.Controls.Add((Control) this.labelProportionalCommission);
    this.Controls.Add((Control) this.labelFullARCommission);
    this.Controls.Add((Control) this.labelTotalCommission);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.labelPayeeName);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (CommissionableEntity);
    this.Size = new Size(616, 72);
    this.ResumeLayout(false);
  }

  public Guid PayeeGuid => this._payeeGuid;

  public string PayeeName => this._payeeName;

  public Decimal CommissionTotal => this._commissionTotal;

  public Decimal FullPaidCommission => this._fullPaidCommission;

  public Decimal ProportionalCommission => this._proportionalCommission;

  public Decimal AmountPTD => this._amountPTD;

  private void SetFields()
  {
    this.labelPayeeName.Text = this.PayeeName;
    this.labelTotalCommission.Text = this.CommissionTotal.ToString("c");
    this.labelFullARCommission.Text = this.FullPaidCommission.ToString("c");
    this.labelProportionalCommission.Text = this.ProportionalCommission.ToString("c");
    this.labelAmountPTD.Text = this.AmountPTD.ToString("c");
  }

  private void linkCreateCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.PayeeGuid.Equals(Guid.Empty))
      return;
    this.OnCommissionableEntitySelected();
  }

  public event CommissionableEntity.CommissionableEntitySelectedHandler CommissionableEntitySelected;

  protected void OnCommissionableEntitySelected()
  {
    if (this.CommissionableEntitySelected == null)
      return;
    this.CommissionableEntitySelected((object) this, new CommissionableEntity.CommissionableEntitySelectedEventArgs(this.PayeeGuid, this.PayeeName, Decimal.Parse(this.labelTotalCommission.Text, NumberStyles.Currency), Decimal.Parse(this.labelFullARCommission.Text, NumberStyles.Currency), Decimal.Parse(this.labelProportionalCommission.Text, NumberStyles.Currency)));
  }

  public delegate void CommissionableEntitySelectedHandler(
    object sender,
    CommissionableEntity.CommissionableEntitySelectedEventArgs e);

  public class CommissionableEntitySelectedEventArgs : EventArgs
  {
    private Guid _payeeGuid;
    private string _payeeName;
    private Decimal _totalCommissions;
    private Decimal _commissionDueARFullyReceived;
    private Decimal _proportionalCommissionDue;

    public CommissionableEntitySelectedEventArgs(
      Guid payeeGuid,
      string payeeName,
      Decimal totalCommission,
      Decimal commissionDueFullAR,
      Decimal commissionDueProportional)
    {
      this._payeeGuid = payeeGuid;
      this._payeeName = payeeName;
      this._totalCommissions = totalCommission;
      this._commissionDueARFullyReceived = commissionDueFullAR;
      this._proportionalCommissionDue = commissionDueProportional;
    }

    public Guid PayeeGuid => this._payeeGuid;

    public string PayeeName => this._payeeName;

    public Decimal TotalCommission => this._totalCommissions;

    public Decimal CommissionDueARFullyReceived => this._commissionDueARFullyReceived;

    public Decimal ProportionalCommissionDue => this._proportionalCommissionDue;
  }
}
