// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.AuthorityLimit.UI.AuthorityLimitNotificationViewModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using MgaSystems.IMS.Policies.AuthorityLimit.Lib;
using System.Collections.ObjectModel;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.AuthorityLimit.UI;

public abstract class AuthorityLimitNotificationViewModel : BindingObject
{
  [NotificationProperty]
  public virtual CollectionViewSource LimitCSV { get; set; }

  [NotificationProperty]
  public virtual string UserMessage { get; set; }

  public static AuthorityLimitNotificationViewModel Create(
    AuthorityLimitCheckManager authorityLimitCheckManager)
  {
    return NotifyProxyTypeManager.Allocate<AuthorityLimitNotificationViewModel>(new object[1]
    {
      (object) authorityLimitCheckManager
    });
  }

  public AuthorityLimitNotificationViewModel(
    AuthorityLimitCheckManager authorityLimitCheckManager)
  {
    if (((Collection<AuthorityLimitCheck>) authorityLimitCheckManager.AuthorityLimitCheckList).Count > 0)
      this.UserMessage = ((Collection<AuthorityLimitCheck>) authorityLimitCheckManager.AuthorityLimitCheckList)[0].UnderwriterName + " has values outside the authority limit range:";
    this.LimitCSV = new CollectionViewSource()
    {
      Source = (object) authorityLimitCheckManager.AuthorityLimitCheckList
    };
    this.LimitCSV.Filter += (FilterEventHandler) ((s, e) =>
    {
      AuthorityLimitCheck authorityLimitCheck = e.Item as AuthorityLimitCheck;
      e.Accepted = (authorityLimitCheck.StopBind || authorityLimitCheck.StopQuote || authorityLimitCheck.StopBindSoft || authorityLimitCheck.StopQuoteSoft) && !authorityLimitCheck.ApproveDate.HasValue;
    });
  }
}
