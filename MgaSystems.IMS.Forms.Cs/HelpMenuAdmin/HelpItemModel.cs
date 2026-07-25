// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.HelpMenuAdmin.HelpItemModel
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;

#nullable disable
namespace MgaSystems.IMS.Forms.HelpMenuAdmin;

[TableMapping("lstDynamicHelpMenuItems")]
public abstract class HelpItemModel : BindingObject
{
  [DataKey]
  [TableFieldMapping]
  public int ID { get; set; }

  [NotificationProperty]
  [TableFieldMapping]
  [TrackChanges]
  public virtual string HelpToolKey { get; set; }

  [NotificationProperty]
  [TableFieldMapping]
  [TrackChanges]
  public virtual string HelpToolCaption { get; set; }

  [NotificationProperty]
  [TableFieldMapping]
  [TrackChanges]
  public virtual string HelpToolUri { get; set; }

  [NotificationProperty]
  [TableFieldMapping]
  [TrackChanges]
  public virtual bool Active { get; set; }

  public static HelpItemModel Create() => NotifyProxyTypeManager.Allocate<HelpItemModel>();

  public HelpItemModel()
  {
  }

  public static HelpItemModel Create(
    int id,
    string helpToolKey,
    string helpToolCaption,
    string helpToolUri,
    bool active)
  {
    return NotifyProxyTypeManager.Allocate<HelpItemModel>(new object[5]
    {
      (object) id,
      (object) helpToolKey,
      (object) helpToolCaption,
      (object) helpToolUri,
      (object) active
    });
  }

  public HelpItemModel(
    int id,
    string helpToolKey,
    string helpToolCaption,
    string helpToolUri,
    bool active)
  {
    this.ID = id;
    this.HelpToolKey = helpToolKey;
    this.HelpToolCaption = helpToolCaption;
    this.HelpToolUri = helpToolUri;
    this.Active = active;
  }
}
