// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.AssignFinanceCompanyClickedEventArgs
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class AssignFinanceCompanyClickedEventArgs
{
  private int mGlCompanyId;
  private int mControlNumber;
  private int mInvoiceNumber;

  internal AssignFinanceCompanyClickedEventArgs(
    int glCompanyId,
    int controlNumber,
    int invoiceNumber)
  {
    this.mGlCompanyId = glCompanyId;
    this.mControlNumber = controlNumber;
    this.mInvoiceNumber = invoiceNumber;
  }

  public int GlCompanyId => this.mGlCompanyId;

  public int ControlNumber => this.mControlNumber;

  public int InvoiceNumber => this.mInvoiceNumber;
}
