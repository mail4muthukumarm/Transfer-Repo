// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ModifyReserveFormShownEventArgs
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

#nullable disable
namespace MGASystems.IMS.Claims;

public class ModifyReserveFormShownEventArgs
{
  public ModifyReserveFormShownEventArgs(FormModifyReserve f, int claimId)
  {
    this.ModifyReserveForm = f;
  }

  public FormModifyReserve ModifyReserveForm { get; }

  public int ClaimId { get; }
}
