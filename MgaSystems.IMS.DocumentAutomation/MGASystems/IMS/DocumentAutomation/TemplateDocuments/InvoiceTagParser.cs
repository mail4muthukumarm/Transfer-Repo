// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.InvoiceTagParser
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class InvoiceTagParser : PolicyTagParser
{
  private int _InvoiceNum;

  public InvoiceTagParser(int InvoiceNum)
    : base(InvoiceTagParser.GetQuoteGuid(InvoiceNum))
  {
    this._InvoiceNum = InvoiceNum;
  }

  public override List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID)
  {
    Invoice invoice = new Invoice(this._InvoiceNum);
    try
    {
      foreach (DocTag tag in tags)
      {
        string lower = tag.InnerTagName.ToLower();
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(lower))
        {
          case 366225288:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "totalfees", false) == 0)
            {
              tag.TagValue = invoice.TotalFees.ToString();
              continue;
            }
            continue;
          case 976133768:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "invnum", false) == 0)
            {
              tag.TagValue = this._InvoiceNum.ToString();
              continue;
            }
            continue;
          case 1856971319:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "offinvnum", false) == 0)
            {
              tag.TagValue = invoice.OfficeInvoiceNum.ToString();
              continue;
            }
            continue;
          case 2717620719:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "invnetdue", false) == 0)
            {
              tag.TagValue = invoice.InvNetDue.ToString();
              continue;
            }
            continue;
          case 2762632228:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "invprem", false) == 0)
            {
              tag.TagValue = invoice.TotalPremium.ToString();
              continue;
            }
            continue;
          case 3895530293:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "due", false) == 0)
            {
              tag.TagValue = invoice.DueDate.ToString();
              continue;
            }
            continue;
          case 4152741449:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "amount", false) == 0)
            {
              tag.TagValue = invoice.Amount.ToString();
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    tags = base.ProcessTags(tags, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineID);
    return tags;
  }

  private static Guid GetQuoteGuid(int invoiceNum)
  {
    return DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT QuoteGuid FROM tblQuotes Q INNER JOIN tblFin_Invoices I ON Q.QuoteID=I.QuoteID WHERE InvoiceNum=@IN", new object[2]
    {
      (object) "@IN",
      (object) invoiceNum
    });
  }
}
