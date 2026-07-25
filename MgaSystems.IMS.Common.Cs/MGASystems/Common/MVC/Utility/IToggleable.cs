// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.Utility.IToggleable
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.MVC.Utility;

public interface IToggleable
{
  void Toggle();

  void Enable();

  void Disable();

  void EnableIfDisabled();

  void DisableIfEnabled();

  bool IsEnabled { get; }

  void SetState(bool enabled);

  void SetStateIfNotAlready(bool enabled);

  event Action<bool> EnabledChanged;
}
