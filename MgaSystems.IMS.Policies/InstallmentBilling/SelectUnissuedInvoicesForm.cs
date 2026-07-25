// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.SelectUnissuedInvoicesForm
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.InstallmentBilling;

[DesignerGenerated]
public class SelectUnissuedInvoicesForm : Form, ILoadAutomatically
{
  private IContainer components;
  private Label Label1;
  private readonly Quote _quote;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.invoicesList = new MGACheckedListBox();
    this.Label1 = new Label();
    this.btnContinue = new MGAButton();
    this.linkSelectAll = new LinkLabel();
    this.linkDeselectAll = new LinkLabel();
    ((ISupportInitialize) this.invoicesList).BeginInit();
    ((ISupportInitialize) this.btnContinue).BeginInit();
    this.SuspendLayout();
    ((ListBox) this.invoicesList).BackColor = Color.White;
    ((CheckedListBox) this.invoicesList).CheckOnClick = true;
    ((ListBox) this.invoicesList).ForeColor = Color.Black;
    ((ListControl) this.invoicesList).FormattingEnabled = true;
    ((Control) this.invoicesList).Location = new Point(10, 44);
    ((Control) this.invoicesList).Name = "invoicesList";
    ((Control) this.invoicesList).Size = new Size(527, 292);
    ((Control) this.invoicesList).TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(9, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(530, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please select the invoices you would like to split across, from the following list of currently un-issued invoices:";
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnContinue).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnContinue).Location = new Point(459, 342);
    ((Control) this.btnContinue).Name = "btnContinue";
    ((Control) this.btnContinue).Size = new Size(75, 23);
    ((Control) this.btnContinue).TabIndex = 2;
    ((ControlBase) this.btnContinue).Text = "Continue";
    this.btnContinue.UseOSThemes = (DefaultableBoolean) 2;
    this.linkSelectAll.AutoSize = true;
    this.linkSelectAll.Location = new Point(12, 347);
    this.linkSelectAll.Name = "linkSelectAll";
    this.linkSelectAll.Size = new Size(50, 13);
    this.linkSelectAll.TabIndex = 3;
    this.linkSelectAll.TabStop = true;
    this.linkSelectAll.Text = "Select All";
    this.linkDeselectAll.AutoSize = true;
    this.linkDeselectAll.Location = new Point(68, 347);
    this.linkDeselectAll.Name = "linkDeselectAll";
    this.linkDeselectAll.Size = new Size(66, 13);
    this.linkDeselectAll.TabIndex = 4;
    this.linkDeselectAll.TabStop = true;
    this.linkDeselectAll.Text = "De-select All";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(546, 374);
    this.Controls.Add((Control) this.linkDeselectAll);
    this.Controls.Add((Control) this.linkSelectAll);
    this.Controls.Add((Control) this.btnContinue);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.invoicesList);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (SelectUnissuedInvoicesForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Unissued Invoices";
    ((ISupportInitialize) this.invoicesList).EndInit();
    ((ISupportInitialize) this.btnContinue).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAButton btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      MGAButton btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        ((Control) btnContinue1).Click -= eventHandler;
      this._btnContinue = value;
      MGAButton btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      ((Control) btnContinue2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel linkSelectAll
  {
    get => this._linkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.SelectDeselect);
      LinkLabel linkSelectAll1 = this._linkSelectAll;
      if (linkSelectAll1 != null)
        linkSelectAll1.LinkClicked -= clickedEventHandler;
      this._linkSelectAll = value;
      LinkLabel linkSelectAll2 = this._linkSelectAll;
      if (linkSelectAll2 == null)
        return;
      linkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel linkDeselectAll
  {
    get => this._linkDeselectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.SelectDeselect);
      LinkLabel linkDeselectAll1 = this._linkDeselectAll;
      if (linkDeselectAll1 != null)
        linkDeselectAll1.LinkClicked -= clickedEventHandler;
      this._linkDeselectAll = value;
      LinkLabel linkDeselectAll2 = this._linkDeselectAll;
      if (linkDeselectAll2 == null)
        return;
      linkDeselectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("invoicesList")]
  protected virtual MGACheckedListBox invoicesList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual string UnissuedInvoicesProcedure => "dbo.spInstallmentBilling_UnissuedInvoices";

  public SelectUnissuedInvoicesForm()
  {
    this.Load += new EventHandler(this.SelectUnissuedInvoicesForm_Load);
    this.InitializeComponent();
  }

  public SelectUnissuedInvoicesForm(Quote quote)
    : this()
  {
    this._quote = quote;
  }

  public List<InstallmentInvoiceItem> SelectInvoiceNumbers
  {
    get
    {
      List<InstallmentInvoiceItem> selectInvoiceNumbers = new List<InstallmentInvoiceItem>();
      try
      {
        foreach (InstallmentInvoiceItem checkedItem in ((CheckedListBox) this.invoicesList).CheckedItems)
          selectInvoiceNumbers.Add(checkedItem);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return selectInvoiceNumbers;
    }
  }

  private void SelectUnissuedInvoicesForm_Load(object sender, EventArgs e)
  {
    int num = this.DesignMode ? 1 : 0;
  }

  public void PerformLoad()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(this.UnissuedInvoicesProcedure, new object[2]
    {
      (object) "@ControlNo",
      (object) this._quote.ControlNo
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        int num1 = row.Field<int>(0);
        int num2 = row.Field<int>(1);
        DateTime dueDate = row.Field<DateTime>(2);
        string description = $"Invoice #{num2} - Due {dueDate.ToShortDateString()} - {Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(row[3]))}";
        ((CheckedListBox) this.invoicesList).Items.Add((object) new InstallmentInvoiceItem(new int?(num1), description, dueDate));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnContinue_Click(object sender, EventArgs e) => this.Close();

  protected void SelectDeselect(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = ((CheckedListBox) this.invoicesList).Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      ((CheckedListBox) this.invoicesList).SetItemChecked(index, sender == this.linkSelectAll);
  }

  public void SelectAllItems()
  {
    this.SelectDeselect((object) this.linkSelectAll, (LinkLabelLinkClickedEventArgs) null);
  }
}
