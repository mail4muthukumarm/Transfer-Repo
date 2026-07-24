// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.ThresholdLimit.UI.ThresholdLimitNotificationViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using MgaSystems.IMS.Policies.ThresholdLimit.Lib;
using System.Collections.ObjectModel;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.ThresholdLimit.UI;

public abstract class ThresholdLimitNotificationViewModel : BindingObject
{
  [NotificationProperty]
  public virtual CollectionViewSource LimitCSV { get; set; }

  [NotificationProperty]
  public virtual string UserMessage { get; set; }

  public static ThresholdLimitNotificationViewModel Create(
    ThresholdLimitCheckManager authorityLimitCheckManager)
  {
    return NotifyProxyTypeManager.Allocate<ThresholdLimitNotificationViewModel>(new object[1]
    {
      (object) authorityLimitCheckManager
    });
  }

  public ThresholdLimitNotificationViewModel(
    ThresholdLimitCheckManager authorityLimitCheckManager)
  {
    if (((Collection<ThresholdLimitCheck>) authorityLimitCheckManager.ThresholdLimitCheckList).Count > 0)
      this.UserMessage = "There are values above the Threshold Limit.  Please contact your manager for approval.";
    this.LimitCSV = new CollectionViewSource()
    {
      Source = (object) authorityLimitCheckManager.ThresholdLimitCheckList
    };
    this.LimitCSV.Filter += (FilterEventHandler) ((s, e) =>
    {
      ThresholdLimitCheck thresholdLimitCheck = e.Item as ThresholdLimitCheck;
      e.Accepted = (thresholdLimitCheck.StopBind || thresholdLimitCheck.StopQuote || thresholdLimitCheck.StopBindSoft || thresholdLimitCheck.StopQuoteSoft) && !thresholdLimitCheck.ApproveDate.HasValue;
    });
  }
}
