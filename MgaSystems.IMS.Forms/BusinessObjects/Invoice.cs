// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.BusinessObjects.Invoice
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.IMS.Policies.Invoices;
using MGASystems.IMS.Security;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.BusinessObjects;

[SecureResource("0F2FF00F-BA1C-491b-BF18-DC745A92C520", "Change Due Date", "Controls the ability to change an invoice due date on a bound policy.", "Invoices")]
public sealed class Invoice(int invoiceNum) : MGASystems.BusinessObjects.Invoice(invoiceNum)
{
  public const string ChangeDueDateSecurityID = "0F2FF00F-BA1C-491b-BF18-DC745A92C520";

  public void ChangeDueDate()
  {
    if (SecurityManager.Instance.AssertPermission("0F2FF00F-BA1C-491b-BF18-DC745A92C520"))
    {
      int num1 = (int) MessageBox.Show("You are not authorized to change invoice due dates.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      Form form = (Form) null;
      try
      {
        form = FormSettings.ShowFormDialog(typeof (frmChangeInvoiceDueDate), (object) this);
        if (!((frmChangeInvoiceDueDate) form).Saved)
          return;
        int num2 = (int) MessageBox.Show($"The due date of invoice #{this.InvoiceNum.ToString()} was succesfully changed to {this.DueDate.ToShortDateString()}.", "Due Date Changed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      finally
      {
        form.Dispose();
      }
    }
  }
}
