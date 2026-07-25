// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.DocTag
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.AsposeFacade.Words.Tables;
using MGASystems.Common;
using System;
using System.Data;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public sealed class DocTag : IDocTag
{
  private string _tagName;
  private string _tagValue;
  private Table _tagTable;
  private Image _tagImage;
  private bool _requiresEntityId;
  private object _tagCheckbox;
  private DataSet _tagDataset;

  public DocTag()
  {
    this._requiresEntityId = false;
    this._tagDataset = (DataSet) null;
  }

  public bool RequiresEntityId
  {
    get => this._requiresEntityId;
    set => this._requiresEntityId = value;
  }

  public string TagName
  {
    get => this._tagName;
    set => this._tagName = value;
  }

  public string TagValue
  {
    get => this._tagValue;
    set => this._tagValue = value;
  }

  public Table TagTable
  {
    get => this._tagTable;
    set => this._tagTable = value;
  }

  public DataSet TagDataset
  {
    get => this._tagDataset;
    set => this._tagDataset = value;
  }

  public bool TagCheckbox
  {
    get
    {
      return this._tagCheckbox != null ? (bool) this._tagCheckbox : throw new ArgumentNullException("Checkbox value hasn't been set");
    }
    set => this._tagCheckbox = (object) value;
  }

  public bool IsCheckBoxTag => this._tagCheckbox != null;

  public bool IsTableTag => this.TagTable != null;

  public bool IsHtmlTag
  {
    get => this.HasFunction && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.FunctionName, "RENDERHTML", false) == 0;
  }

  public bool IsRepeatableTag => this.TagDataset != null;

  public Image TagImage
  {
    get => this._tagImage;
    set => this._tagImage = value;
  }

  public bool IsImageTag => this.TagImage != null;

  public string InnerTagName
  {
    get
    {
      string innerTagName = this._tagName.Replace("[!", string.Empty).Replace("]", string.Empty);
      if (innerTagName.IndexOf("(") != -1)
      {
        string str = innerTagName.Replace(")", string.Empty);
        innerTagName = str.Substring(str.IndexOf("(") + 1, str.Length - str.IndexOf("(") - 1);
      }
      return innerTagName;
    }
  }

  public string FunctionName
  {
    get
    {
      return this._tagName.IndexOf("(") == -1 ? string.Empty : this._tagName.Substring(0, this._tagName.IndexOf("(")).ToUpper();
    }
  }

  public bool HasFunction => this._tagName.IndexOf("(") != -1;

  public void PostProcessTag() => TagParserBase.PostProcess(this);
}
