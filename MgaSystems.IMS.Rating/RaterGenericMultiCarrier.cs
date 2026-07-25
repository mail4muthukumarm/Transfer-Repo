// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterGenericMultiCarrier
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[RaterInformation(89, "Generic Multi-Carrier")]
public class RaterGenericMultiCarrier : RaterWithUIBase, IMultiCompanyRater
{
  protected override Form CreateUI()
  {
    return ObjectFactory.Instance.CreateForm(typeof (FormGenericMultiCarrierRater));
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction((DbTransaction) cmd.Transaction, new ExecuteHandler((object) new RaterGenericMultiCarrier._Closure\u0024__2\u002D0()
    {
      \u0024VB\u0024Local_e = e
    }, __methodptr(_Lambda\u0024__0)));
  }

  public override string GetOptionDescription(Guid quoteOptionGuid)
  {
    string optionDescription = "The premium for this option is " + Strings.FormatCurrency((object) new QuoteOption(quoteOptionGuid).Premium);
    string empty = string.Empty;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT AdditionalComments FROM tblQuoteOptions WHERE QuoteOptionGuid=@QOG", new object[2]
    {
      (object) "@QOG",
      (object) quoteOptionGuid
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      empty = objectValue.ToString();
    if (!empty.Equals(string.Empty))
      optionDescription = $"{optionDescription}\n\n{empty}";
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT * FROM tblGenericLimits WHERE QuoteID = @QuoteID", new object[2]
    {
      (object) "@QuoteID",
      (object) this.Quote.QuoteID
    });
    if (dataRow != null)
    {
      optionDescription += "\n\n";
      RichTextBox richTextBox = (RichTextBox) null;
      try
      {
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) dataRow.Table.Columns)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName, "QuoteID", false) != 0 && dataRow[column.ColumnName] != DBNull.Value)
            {
              if (richTextBox == null)
                richTextBox = new RichTextBox();
              richTextBox.Rtf = (string) dataRow[column.ColumnName];
              optionDescription = $"{optionDescription}{column.ColumnName}:\n\n{richTextBox.Text}\n\n";
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      finally
      {
        richTextBox?.Dispose();
      }
    }
    return optionDescription;
  }

  public override bool SupportsUnderwritingLocations => true;

  public void SetCompanyLocationId(int companyLocationId)
  {
  }
}
