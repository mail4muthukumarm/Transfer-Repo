// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Property
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data.Binding;
using MgaSystems.IMS.Policies.E2Value.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value;

[Serializable]
public abstract class Property : DependentBindingObject
{
  [NotificationProperty]
  public virtual bool IsErrored { get; set; }

  [NotificationProperty]
  public virtual string ErrorMessage { get; set; }

  [XmlIgnore]
  public Guid LocationGuid { get; set; }

  [XmlIgnore]
  public string Source { get; set; }

  [XmlIgnore]
  [NotificationProperty]
  public virtual bool Include { get; set; }

  [NotificationProperty]
  public virtual string structure_cost_range_low { get; set; }

  [NotificationProperty]
  public virtual string structure_cost_range_med { get; set; }

  [NotificationProperty]
  public virtual string structure_cost_range_high { get; set; }

  [NotificationProperty]
  public virtual string acv_range_low { get; set; }

  [NotificationProperty]
  public virtual string acv_range_med { get; set; }

  [NotificationProperty]
  public virtual string acv_range_high { get; set; }

  [NotificationProperty]
  public virtual EstimateProperty InnerProperty { get; set; }

  [NotificationProperty]
  public virtual Response Response { get; set; }

  public static Property Create(EstimateProperty innerProperty)
  {
    Property property = NotifyProxyTypeManager.Allocate<Property>();
    property.InnerProperty = innerProperty;
    return property;
  }

  public void InnerPropertyChanged()
  {
    ((BindingObject) this).RaisePropertyChanged("InnerProperty");
  }

  public static MgaSystems.IMS.Policies.E2Value.Data.State[] States
  {
    get => (MgaSystems.IMS.Policies.E2Value.Data.State[]) Enum.GetValues(typeof (MgaSystems.IMS.Policies.E2Value.Data.State));
  }

  public static ConstructionQuality[] ConstructionQualities
  {
    get => (ConstructionQuality[]) Enum.GetValues(typeof (ConstructionQuality));
  }

  public static ConstructionType[] ConstructionTypes
  {
    get => (ConstructionType[]) Enum.GetValues(typeof (ConstructionType));
  }

  public static Exterior[] Exteriors => (Exterior[]) Enum.GetValues(typeof (Exterior));

  public static RoofCovering[] RoofCoverings
  {
    get => (RoofCovering[]) Enum.GetValues(typeof (RoofCovering));
  }

  public static MgaSystems.IMS.Policies.E2Value.Data.State? ParseState(string val)
  {
    List<MgaSystems.IMS.Policies.E2Value.Data.State> list = ((IEnumerable<MgaSystems.IMS.Policies.E2Value.Data.State>) Property.States).Where<MgaSystems.IMS.Policies.E2Value.Data.State>((Func<MgaSystems.IMS.Policies.E2Value.Data.State, bool>) (s => s.ToString().Equals(val.Replace(" ", ""), StringComparison.OrdinalIgnoreCase))).ToList<MgaSystems.IMS.Policies.E2Value.Data.State>();
    return !list.Any<MgaSystems.IMS.Policies.E2Value.Data.State>() ? new MgaSystems.IMS.Policies.E2Value.Data.State?() : new MgaSystems.IMS.Policies.E2Value.Data.State?(list.First<MgaSystems.IMS.Policies.E2Value.Data.State>());
  }

  public static ConstructionQuality ParseConstructionQuality(string val)
  {
    return ((IEnumerable<ConstructionQuality>) Property.ConstructionQualities).First<ConstructionQuality>((Func<ConstructionQuality, bool>) (s => s.ToString().Equals(val.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)));
  }

  public static ConstructionType ParseConstructionType(string val)
  {
    return ((IEnumerable<ConstructionType>) Property.ConstructionTypes).First<ConstructionType>((Func<ConstructionType, bool>) (s => s.ToString().Equals(val.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)));
  }

  public static Exterior ParseExterior(string val)
  {
    return ((IEnumerable<Exterior>) Property.Exteriors).First<Exterior>((Func<Exterior, bool>) (s => s.ToString().Equals(val.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)));
  }

  public static RoofCovering ParseRoofCovering(string val)
  {
    return ((IEnumerable<RoofCovering>) Property.RoofCoverings).First<RoofCovering>((Func<RoofCovering, bool>) (s => s.ToString().Equals(val.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)));
  }
}
