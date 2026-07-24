// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.PayeeMissingBankAccountSelector
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Controller;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount;

internal class PayeeMissingBankAccountSelector(PayeeMissingBankAccountGridModel model) : 
  GridForm<PayeeMissingBankAccountDto, PayeeMissingBankAccountGridController, PayeeMissingBankAccountGridModel>(model, new PayeeMissingBankAccountGridController())
{
}
