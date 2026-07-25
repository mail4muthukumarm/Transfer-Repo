// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAComboBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win.UltraWinGrid;
using System.ComponentModel;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGAComboBox : MGASimpleComboBox
{
  public override void DropDown()
  {
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [Browsable(true)]
  public new UltraGridLayout DisplayLayout => base.DisplayLayout;

  public MGAComboBox() => ((Control) this).DoubleBuffered = true;
}
