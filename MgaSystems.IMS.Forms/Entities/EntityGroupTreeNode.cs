// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Entities.EntityGroupTreeNode
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinTree;

#nullable disable
namespace MGASystems.IMS.Forms.Entities;

public class EntityGroupTreeNode : UltraTreeNode
{
  private string _officeDisplayValue;

  public string OfficeDisplayValue
  {
    get => this._officeDisplayValue;
    set => this._officeDisplayValue = value;
  }
}
