// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess.IMultiACHBankRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess;

public interface IMultiACHBankRepository
{
  ACHBankDto[] GetApprovedForEntityGuid(Guid entityGuid);

  ACHBankDto[] GetByEntityGuid(Guid entityGuid);
}
