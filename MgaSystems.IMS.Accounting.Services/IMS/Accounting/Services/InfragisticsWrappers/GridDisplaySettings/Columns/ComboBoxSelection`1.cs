// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.ComboBoxSelection`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class ComboBoxSelection<TDisplayItem> : IComboBoxSelection<TDisplayItem>, IComboBoxSelection where TDisplayItem : class
{
  object IComboBoxSelection.ValueMember => (object) this.ValueMember;

  public TDisplayItem ValueMember { get; }

  public string DisplayName { get; }

  public ComboBoxSelection(TDisplayItem valueMember, string displayName)
  {
    this.ValueMember = valueMember ?? throw new ArgumentNullException(nameof (valueMember));
    this.DisplayName = displayName ?? throw new ArgumentNullException(nameof (displayName));
    if (string.IsNullOrWhiteSpace(this.DisplayName))
      throw new ArgumentException("Display name cannot be all whitespace!");
  }

  public override bool Equals(object obj)
  {
    return obj is IComboBoxSelection<TDisplayItem> comboBoxSelection && this.Equals(comboBoxSelection);
  }

  public bool Equals(IComboBoxSelection<TDisplayItem> obj)
  {
    return obj != null && obj.ValueMember.Equals((object) this.ValueMember);
  }

  public override int GetHashCode()
  {
    return (801848015 * -1521134295 + EqualityComparer<TDisplayItem>.Default.GetHashCode(this.ValueMember)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.DisplayName);
  }
}
