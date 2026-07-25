// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Messaging.GlobalMessageListener
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Excel.Data;
using MGASystems.IMS.Excel.Views;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace MGASystems.IMS.Excel.Messaging;

public sealed class GlobalMessageListener : ISupportPreLoadCache
{
  public void OnAsynchronousLoad(object sender, OnAsynchronousLoadEventArgs e)
  {
    MGASystems.Common.BroadcastMessaging.Messaging.MessageSent += new MGASystems.Common.BroadcastMessaging.Messaging.MessageSentEventHandler(this.Messaging_MessageSent);
  }

  public string PreLoadKey => (string) null;

  private void Messaging_MessageSent(object sender, MGASystems.Common.BroadcastMessaging.Messaging.MessageEventArgs e)
  {
    if (e.EventGuid == BroadcastMessages.QuoteDuplicated)
    {
      if (!(e.Context is QuoteDuplicatedContext context))
        return;
      DefaultDatabase.ExecuteNonQuery("ExcelRating_CopyExcelRatingBinary", new object[4]
      {
        (object) "@OriginalQuoteGuid",
        (object) context.OriginalQuoteGuid,
        (object) "@DuplicateQuoteGuid",
        (object) context.DuplicateQuoteGuid
      });
    }
    else
    {
      if (!(e.EventGuid == BroadcastMessages.NewQuote) || e.Context == null || !(e.Context.GetType() == typeof (Guid)))
        return;
      ExcelQuoteCollection excelQuotes = new ExcelQuoteCollection((Guid) e.Context);
      if (((Collection<ExcelQuote>) excelQuotes).Count <= 0)
        return;
      new RatingSheetChooser(excelQuotes, e.EventGuid == BroadcastMessages.NewRenewal).ShowDialog();
    }
  }
}
