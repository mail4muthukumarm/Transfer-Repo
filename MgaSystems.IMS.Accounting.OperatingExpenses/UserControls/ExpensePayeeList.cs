// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpensePayeeList
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpensePayeeList : UserControl
{
  private Panel panel1;
  private Panel panel2;
  private LinkLabel linkAddPayee;
  private System.ComponentModel.Container components;
  private ExpensePayeeListItem.PayeeListItemViewClickedHandler _itemClickedHandler;
  private ExpensePayeeListItem.ViewVendorInformationClickedHandler _vendorInformationClickedHandler;

  public ExpensePayeeList()
  {
    this.InitializeComponent();
    this._itemClickedHandler = new ExpensePayeeListItem.PayeeListItemViewClickedHandler(this.ListItemClicked);
    this._vendorInformationClickedHandler = new ExpensePayeeListItem.ViewVendorInformationClickedHandler(this.ViewVendorInformationClicked);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.linkAddPayee = new LinkLabel();
    this.panel1 = new Panel();
    this.panel2 = new Panel();
    this.panel2.SuspendLayout();
    this.SuspendLayout();
    this.linkAddPayee.BackColor = Color.White;
    this.linkAddPayee.Dock = DockStyle.Fill;
    this.linkAddPayee.Location = new Point(0, 0);
    this.linkAddPayee.Name = "linkAddPayee";
    this.linkAddPayee.Size = new Size(888, 24);
    this.linkAddPayee.TabIndex = 0;
    this.linkAddPayee.TabStop = true;
    this.linkAddPayee.Text = " Add New Payee ";
    this.linkAddPayee.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkAddPayee_LinkClicked);
    this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panel1.AutoScroll = true;
    this.panel1.BackColor = Color.White;
    this.panel1.Font = new Font("Tahoma", 8f);
    this.panel1.ForeColor = Color.Black;
    this.panel1.Location = new Point(2, 2);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(886, 576);
    this.panel1.TabIndex = 1;
    this.panel2.Controls.Add((Control) this.linkAddPayee);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 584);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(888, 24);
    this.panel2.TabIndex = 2;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (ExpensePayeeList);
    this.Size = new Size(888, 608);
    this.panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public void SetDataSource(dsOperatingExpensePayees ds)
  {
    this.panel1.Controls.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) ds.PayeesList.Rows)
    {
      ExpensePayeeListItem expensePayeeListItem = new ExpensePayeeListItem(new Guid(row["payeeGuid"].ToString()), row["payeeName"].ToString(), row["address1"].ToString(), row["address2"].ToString(), row["city"].ToString(), row["state"].ToString(), row["zip"].ToString(), row["zipPlus"].ToString(), row["phone1"].ToString(), row["phone2"].ToString(), row["fax"].ToString(), row["email"].ToString(), row["payeeAcctNum"].ToString());
      expensePayeeListItem.ViewClicked += this._itemClickedHandler;
      expensePayeeListItem.ViewVendorInfomationClicked += this._vendorInformationClickedHandler;
      this.panel1.Controls.Add((Control) expensePayeeListItem);
      expensePayeeListItem.Dock = DockStyle.Top;
      expensePayeeListItem.BringToFront();
    }
  }

  private void ListItemClicked(object sender, PayeeListItemViewClickedEventArgs e)
  {
    formExpensePayee formExpensePayee = new formExpensePayee(e.PayeeGuid);
    try
    {
      if (formExpensePayee.ShowDialog() != DialogResult.OK)
        return;
      this.OnExpensePayeesChanged();
    }
    finally
    {
      formExpensePayee.Dispose();
    }
  }

  private void ViewVendorInformationClicked(object sender, ViewVendorInformationClickedEventArgs e)
  {
    formVendorCard formVendorCard = new formVendorCard(e.VendorGuid, (this.ParentForm as formOperatingExpenses).GLCompanyId);
    formVendorCard.MdiParent = MDIControls.Instance.MDIParent;
    formVendorCard.Show();
  }

  private void linkAddPayee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    formExpensePayee formExpensePayee = new formExpensePayee();
    try
    {
      if (formExpensePayee.ShowDialog() != DialogResult.OK)
        return;
      this.OnExpensePayeesChanged();
    }
    finally
    {
      formExpensePayee.Dispose();
    }
  }

  public event ExpensePayeeList.ExpensePayeesChangedHandler ExpensePayeeChanged;

  protected void OnExpensePayeesChanged()
  {
    if (this.ExpensePayeeChanged == null)
      return;
    this.ExpensePayeeChanged((object) this, new EventArgs());
  }

  public delegate void ExpensePayeesChangedHandler(object sender, EventArgs e);
}
