// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.AccountingCore_frmInvoiceLookup
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.IMS.Policies.Invoices;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[Override(typeof (frmInvoiceLookup))]
public class AccountingCore_frmInvoiceLookup : frmInvoiceLookup
{
  protected MGACheckBox chkRemittance;
  private System.ComponentModel.Container components;

  public AccountingCore_frmInvoiceLookup() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.chkRemittance = new MGACheckBox();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnReset).BeginInit();
    ((ISupportInitialize) this.gbPrintOptions).BeginInit();
    ((Control) this.gbPrintOptions).SuspendLayout();
    ((ISupportInitialize) this.chkShowInstallments).BeginInit();
    ((ISupportInitialize) this.btnPrintSelectedInvoices).BeginInit();
    ((ISupportInitialize) this.btnPrintAllReturnedInvoices).BeginInit();
    ((ISupportInitialize) this.chkRemittance).BeginInit();
    this.SuspendLayout();
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.chkRemittance);
    ((Control) this.gbPrintOptions).Controls.SetChildIndex((Control) this.chkRemittance, 0);
    ((AppearanceBase) appearance).BorderColor = Color.Gray;
    ((AppearanceBase) appearance).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRemittance).Appearance = (AppearanceBase) appearance;
    ((Control) this.chkRemittance).BackColor = Color.Transparent;
    ((Control) this.chkRemittance).Location = new Point(14, 136);
    ((Control) this.chkRemittance).Name = "chkRemittance";
    ((Control) this.chkRemittance).Size = new Size(126, 16 /*0x10*/);
    ((Control) this.chkRemittance).TabIndex = 52;
    ((Control) this.chkRemittance).Text = "Show Remittance";
    this.Name = nameof (AccountingCore_frmInvoiceLookup);
    this.Text = "Invoice Lookup";
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnReset).EndInit();
    ((ISupportInitialize) this.gbPrintOptions).EndInit();
    ((Control) this.gbPrintOptions).ResumeLayout(false);
    ((ISupportInitialize) this.chkShowInstallments).EndInit();
    ((ISupportInitialize) this.btnPrintSelectedInvoices).EndInit();
    ((ISupportInitialize) this.btnPrintAllReturnedInvoices).EndInit();
    ((ISupportInitialize) this.chkRemittance).EndInit();
    this.ResumeLayout(false);
  }

  protected override void printSelectedInvoiceReport(int invoiceNumber)
  {
    if (((UltraToggleEditorBase) this.chkRemittance).Checked)
    {
      this.Cursor = Cursors.WaitCursor;
      ArrayList @params = new ArrayList();
      @params.AddRange((ICollection) new object[4]
      {
        (object) "ShowDepositReceived",
        (object) true,
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments
      });
      if (this.InvoiceOption_Both)
      {
        InvoiceItem[] invoices = new InvoiceItem[2]
        {
          null,
          new InvoiceItem(invoiceNumber, @params)
        };
        @params.AddRange((ICollection) new object[2]
        {
          (object) "MGACopy",
          (object) true
        });
        invoices[0] = new InvoiceItem(invoiceNumber, @params);
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      else if (this.InvoiceOption_MGACopy)
      {
        InvoiceItem[] invoices = new InvoiceItem[1];
        @params.AddRange((ICollection) new object[2]
        {
          (object) "MGACopy",
          (object) true
        });
        invoices[0] = new InvoiceItem(invoiceNumber, @params);
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      else
        ReportFactory.Instance.PrintInvoices(new InvoiceItem[1]
        {
          new InvoiceItem(invoiceNumber, @params)
        });
      this.Cursor = Cursors.Default;
    }
    else
      base.printSelectedInvoiceReport(invoiceNumber);
  }

  protected override void printAllInvoicesReport()
  {
    if (((UltraToggleEditorBase) this.chkRemittance).Checked)
    {
      this.Cursor = Cursors.WaitCursor;
      ArrayList params1 = new ArrayList();
      ArrayList params2 = new ArrayList();
      params2.AddRange((ICollection) new object[4]
      {
        (object) "ShowDepositReceived",
        (object) true,
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments
      });
      params1.AddRange((ICollection) new object[6]
      {
        (object) "ShowDepositReceived",
        (object) true,
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments,
        (object) "MGACopy",
        (object) true
      });
      if (this.InvoiceOption_Both)
      {
        InvoiceItem[] invoices = new InvoiceItem[this.dsInvoices.InvoiceLookup.Rows.Count * 2 - 1];
        for (int index = 0; index < this.dsInvoices.InvoiceLookup.Rows.Count; ++index)
        {
          invoices[index * 2] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, params2);
          invoices[index * 2 + 1] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, params1);
        }
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      else if (this.InvoiceOption_MGACopy)
      {
        InvoiceItem[] invoices = new InvoiceItem[this.dsInvoices.InvoiceLookup.Rows.Count * 2 - 1];
        for (int index = 0; index < this.dsInvoices.InvoiceLookup.Rows.Count; ++index)
          invoices[index] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, params1);
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      else
      {
        InvoiceItem[] invoices = new InvoiceItem[this.dsInvoices.InvoiceLookup.Rows.Count * 2 - 1];
        for (int index = 0; index < this.dsInvoices.InvoiceLookup.Rows.Count; ++index)
          invoices[index] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, params2);
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      this.Cursor = Cursors.Default;
    }
    else
      base.printAllInvoicesReport();
  }

  protected override void printSelectedInvoicesReport(ArrayList invoiceNumbers)
  {
    if (((UltraToggleEditorBase) this.chkRemittance).Checked)
    {
      this.Cursor = Cursors.WaitCursor;
      ArrayList params1 = new ArrayList();
      ArrayList params2 = new ArrayList();
      params2.AddRange((ICollection) new object[4]
      {
        (object) "ShowDepositReceived",
        (object) true,
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments
      });
      params1.AddRange((ICollection) new object[6]
      {
        (object) "ShowDepositReceived",
        (object) true,
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments,
        (object) "MGACopy",
        (object) true
      });
      if (this.InvoiceOption_Both)
      {
        InvoiceItem[] invoices = new InvoiceItem[invoiceNumbers.Count * 2 - 1];
        for (int index = 0; index < invoiceNumbers.Count; ++index)
        {
          invoices[index * 2] = new InvoiceItem((int) invoiceNumbers[index], params2);
          invoices[index * 2 + 1] = new InvoiceItem((int) invoiceNumbers[index], params1);
        }
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      else if (this.InvoiceOption_MGACopy)
      {
        InvoiceItem[] invoices = new InvoiceItem[invoiceNumbers.Count - 1];
        for (int index = 0; index < invoiceNumbers.Count; ++index)
          invoices[index] = new InvoiceItem((int) invoiceNumbers[index], params1);
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      else
      {
        InvoiceItem[] invoices = new InvoiceItem[invoiceNumbers.Count - 1];
        for (int index = 0; index < invoiceNumbers.Count; ++index)
          invoices[index] = new InvoiceItem((int) invoiceNumbers[index], params2);
        ReportFactory.Instance.PrintInvoices(invoices);
      }
      this.Cursor = Cursors.Default;
    }
    base.printSelectedInvoicesReport(invoiceNumbers);
  }

  protected override void showSelectedInvoiceReport(int invoiceNumber)
  {
    if (((UltraToggleEditorBase) this.chkRemittance).Checked)
    {
      this.Cursor = Cursors.WaitCursor;
      ArrayList @params = new ArrayList();
      @params.AddRange((ICollection) new object[4]
      {
        (object) "ShowDepositReceived",
        (object) true,
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments
      });
      if (this.InvoiceOption_Both)
      {
        InvoiceItem[] invoices = new InvoiceItem[2]
        {
          new InvoiceItem(invoiceNumber, @params),
          null
        };
        @params.AddRange((ICollection) new object[2]
        {
          (object) "MGACopy",
          (object) true
        });
        invoices[1] = new InvoiceItem(invoiceNumber, @params);
        ReportFactory.Instance.ShowInvoices(invoices);
      }
      else if (this.InvoiceOption_MGACopy)
      {
        InvoiceItem[] invoices = new InvoiceItem[1];
        @params.AddRange((ICollection) new object[2]
        {
          (object) "MGACopy",
          (object) true
        });
        invoices[0] = new InvoiceItem(invoiceNumber, @params);
        ReportFactory.Instance.ShowInvoices(invoices);
      }
      else
        ReportFactory.Instance.ShowInvoices(new InvoiceItem[1]
        {
          new InvoiceItem(invoiceNumber, @params)
        });
      this.Cursor = Cursors.Default;
    }
    else
      base.showSelectedInvoiceReport(invoiceNumber);
  }
}
