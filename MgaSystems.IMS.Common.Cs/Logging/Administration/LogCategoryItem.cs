// Decompiled with JetBrains decompiler
// Type: Logging.Administration.LogCategoryItem
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;

#nullable disable
namespace Logging.Administration;

public class LogCategoryItem
{
  public LogCategoryAttribute LogCategory { get; }

  public LogDestination Destination { get; set; }

  public LogCategoryItem(LogCategoryAttribute logCategory, LogDestination destination)
  {
    this.LogCategory = logCategory;
    this.Destination = destination;
  }

  public override string ToString() => this.LogCategory.Category.ToString();
}
