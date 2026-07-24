// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.VoidTransaction.VoidTransactionRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.VoidTransaction;

public class VoidTransactionRepository
{
  protected const int CommandTimeout = 300;

  public virtual void VoidTransaction(
    int transactionNumber,
    DateTime postDate,
    string journalComments,
    Action<int, int> beforeVoidCommitted)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, evt) =>
    {
      List<object> objectList = new List<object>()
      {
        (object) "@TRANSACTNUM_VOIDEE",
        (object) transactionNumber,
        (object) "@USERGUID",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@POSTDATE",
        (object) postDate,
        (object) "@JOURNALCOMMENTS",
        (object) journalComments
      };
      int num = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "dbo.spFin_VoidJournalTransaction", 300, (CommandArgumentType) 0, objectList.ToArray());
      objectList.RemoveRange(objectList.Count - 2, 2);
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedManualEntries", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidAppliedUnAccountedLinkedTransactions", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedCommissionTransactions", 300, (CommandArgumentType) 0, objectList.ToArray());
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedTransactionReference", 300, (CommandArgumentType) 0, objectList.ToArray());
      int result;
      if (!int.TryParse(num.ToString(), out result))
        throw new Exception("Cannot determine voiding transaction number.");
      beforeVoidCommitted(transactionNumber, result);
      CurrentUser.Instance.LogAction($"Voided transaction #{transactionNumber}.", "Accounting Logs");
      evt.Transaction.Commit();
    }));
  }
}
