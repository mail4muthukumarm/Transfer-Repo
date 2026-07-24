// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Charting.FormBudgetCharting
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.Charting;

public class FormBudgetCharting : Form
{
  private IContainer components;
  private LedgerAccountBudgets ledgerAccountBudgets1;
  private QuarterlyByCostCenter quarterlyByCostCenter1;
  private BudgetTrends budgetTrends1;

  public FormBudgetCharting() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.ledgerAccountBudgets1 = new LedgerAccountBudgets();
    this.quarterlyByCostCenter1 = new QuarterlyByCostCenter();
    this.budgetTrends1 = new BudgetTrends();
    this.SuspendLayout();
    this.ledgerAccountBudgets1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.ledgerAccountBudgets1.Location = new Point(581, 0);
    this.ledgerAccountBudgets1.Name = "ledgerAccountBudgets1";
    this.ledgerAccountBudgets1.Size = new Size(449, 413);
    this.ledgerAccountBudgets1.TabIndex = 5;
    this.quarterlyByCostCenter1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.quarterlyByCostCenter1.BackColor = Color.Transparent;
    this.quarterlyByCostCenter1.Font = new Font("Tahoma", 8.25f);
    this.quarterlyByCostCenter1.Location = new Point(0, 0);
    this.quarterlyByCostCenter1.Name = "quarterlyByCostCenter1";
    this.quarterlyByCostCenter1.Size = new Size(575, 413);
    this.quarterlyByCostCenter1.TabIndex = 4;
    this.budgetTrends1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.budgetTrends1.BackColor = Color.Transparent;
    this.budgetTrends1.Location = new Point(-1, 419);
    this.budgetTrends1.Name = "budgetTrends1";
    this.budgetTrends1.Size = new Size(1031, 323);
    this.budgetTrends1.TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1031, 738);
    this.Controls.Add((Control) this.ledgerAccountBudgets1);
    this.Controls.Add((Control) this.quarterlyByCostCenter1);
    this.Controls.Add((Control) this.budgetTrends1);
    this.Name = nameof (FormBudgetCharting);
    this.Text = nameof (FormBudgetCharting);
    this.ResumeLayout(false);
  }
}
