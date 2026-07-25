// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.BusinessObjects.Insured
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.CustomExceptions;
using MGASystems.Data;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.BusinessObjects;

[SecureResource("{BAEC45B7-E626-442b-93E7-70CB2748FAE7}", "Delete Insured", "Determines whether or not the user will be allowed to delete existing insureds.", "Insureds")]
public class Insured(Guid insuredGuid) : MGASystems.BusinessObjects.Insured(insuredGuid)
{
  internal const string DeleteInsured = "{BAEC45B7-E626-442b-93E7-70CB2748FAE7}";

  public bool Delete()
  {
    bool flag;
    if (!SecurityManager.Instance.AssertPermission("{BAEC45B7-E626-442b-93E7-70CB2748FAE7}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to delete insureds.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
    {
      if (Conversions.ToInteger(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM tblSubmissionGroup WHERE InsuredGuid = @InsuredGuid", new object[2]
      {
        (object) "@InsuredGuid",
        (object) this.InsuredGuid
      })) > 0)
        throw new SubmissionsExistException();
      if (MessageBox.Show("Deleting this insured will delete all insured information and contacts.  Are you sure you want to do this?", "Delete Insured?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
        {
          this.DeleteInsuredTransactionHandler(RuntimeHelpers.GetObjectValue(obj), args);
          args.Transaction.Commit();
        }));
        Messaging.SendBroadcastMessage(BroadcastMessages.InsuredDeleted, (object) this.InsuredGuid);
        flag = true;
      }
      else
        flag = false;
    }
    return flag;
  }

  private object DeleteInsuredTransactionHandler(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.[spDeleteInsured]", new object[2]
    {
      (object) "@InsuredGuid",
      (object) this.InsuredGuid
    });
    return (object) null;
  }
}
