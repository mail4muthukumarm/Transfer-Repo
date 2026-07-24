// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ReportNode
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class ReportNode : ListViewItem
{
  private Type _type;
  private string _title;
  private string _description;
  private string _category;
  private Guid _reportID;

  public ReportNode(Guid reportID, Type type, string category, string title, string description)
    : base(title)
  {
    this._type = type;
    this._title = title;
    this._description = description;
    this._category = category;
    this._reportID = reportID;
  }

  public Type Type => this._type;

  public string Title => this._title;

  public string Description => this._description;

  public string Category => this._category;

  public Guid ReportID => this._reportID;
}
