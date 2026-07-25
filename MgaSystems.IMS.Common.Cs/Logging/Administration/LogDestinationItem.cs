// Decompiled with JetBrains decompiler
// Type: Logging.Administration.LogDestinationItem
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.IMS.Logging;
using System;

#nullable disable
namespace Logging.Administration;

public class LogDestinationItem
{
  private readonly string _description;

  public LogDestination Destination { get; set; }

  public LogDestinationItem(LogDestination logDestination)
  {
    this.Destination = logDestination;
    this._description = Enum.GetName(typeof (LogDestination), (object) logDestination);
  }

  public override string ToString() => this._description;
}
