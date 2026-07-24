// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.IDocTag
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.AsposeFacade.Words.Tables;
using System.Data;
using System.Drawing;

#nullable disable
namespace MGASystems.Common;

public interface IDocTag
{
  bool RequiresEntityId { get; set; }

  string TagName { get; set; }

  string TagValue { get; set; }

  Table TagTable { get; set; }

  bool TagCheckbox { get; set; }

  DataSet TagDataset { get; set; }

  bool IsCheckBoxTag { get; }

  bool IsTableTag { get; }

  bool IsRepeatableTag { get; }

  bool IsHtmlTag { get; }

  Image TagImage { get; set; }

  bool IsImageTag { get; }

  string InnerTagName { get; }

  string FunctionName { get; }

  bool HasFunction { get; }

  void PostProcessTag();
}
