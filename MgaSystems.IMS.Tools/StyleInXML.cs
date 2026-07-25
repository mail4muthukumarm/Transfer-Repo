// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StyleInXML
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class StyleInXML
{
  private int m_backgroundColor;
  private int m_foregroundColor;
  private StyleBordersCollection m_borders;
  private StyleFont m_font;
  private int m_number;
  private XmlNode XMLStyle;
  private double m_rowHeight;
  private double m_colWidth;
  private RangeType m_cellType;
  private string m_cellContent;
  private string m_sheetName;
  private CellRange m_mergedRange;
  private string m_cellName;
  private int _dataDefinitionTableIndex;
  private int _dataDefinitionRowIndex;
  private int _dataDefinitionColumnIndex;
  public bool ProvidedDataValid;

  public int BackgroundColor
  {
    get => this.m_backgroundColor;
    set => this.m_backgroundColor = value;
  }

  public int ForegroundColor
  {
    get => this.m_foregroundColor;
    set => this.m_foregroundColor = value;
  }

  public double RowHeight
  {
    get => this.m_rowHeight;
    set => this.m_rowHeight = value;
  }

  public double ColWidth
  {
    get => this.m_colWidth;
    set => this.m_colWidth = value;
  }

  public RangeType CellType
  {
    get => this.m_cellType;
    set => this.m_cellType = value;
  }

  public string CellContent
  {
    get => this.m_cellContent;
    set => this.m_cellContent = value;
  }

  public string SheetName
  {
    get => this.m_sheetName;
    set => this.m_sheetName = value;
  }

  public CellRange MergedRange
  {
    get => this.m_mergedRange;
    set => this.m_mergedRange = value;
  }

  public string CellName
  {
    get => this.m_cellName;
    set => this.m_cellName = value;
  }

  public XmlNode SerializedStyle
  {
    get => this.XMLStyle;
    set => this.XMLStyle = value;
  }

  public StyleBordersCollection Borders
  {
    get => this.m_borders;
    set => this.m_borders = value;
  }

  public StyleFont Font
  {
    get => this.m_font;
    set => this.m_font = value;
  }

  public int DataTableIndex
  {
    get => this._dataDefinitionTableIndex;
    set => this._dataDefinitionTableIndex = value;
  }

  public int DataRowIndex
  {
    get => this._dataDefinitionRowIndex;
    set => this._dataDefinitionRowIndex = value;
  }

  public int DataColumnIndex
  {
    get => this._dataDefinitionColumnIndex;
    set => this._dataDefinitionColumnIndex = value;
  }

  public int Number
  {
    get => this.m_number;
    set => this.m_number = value;
  }

  public StyleInXML()
  {
    this._dataDefinitionTableIndex = -1;
    this._dataDefinitionRowIndex = -1;
    this._dataDefinitionColumnIndex = -1;
    this.ProvidedDataValid = false;
  }

  public StyleInXML(Style stl)
  {
    this._dataDefinitionTableIndex = -1;
    this._dataDefinitionRowIndex = -1;
    this._dataDefinitionColumnIndex = -1;
    this.ProvidedDataValid = false;
    this.BackgroundColor = stl.BackgroundColor.ToArgb();
    this.ForegroundColor = stl.ForegroundColor.ToArgb();
    this.Borders = new StyleBordersCollection(stl);
    this.Font = new StyleFont(stl.Font);
    this.Number = stl.Number;
    string xml = Regex.Replace(StyleSerializationRoutines.SerializeObject((object) stl, typeof (Style), this.GetListToIgnore()), "[^\\u0000-\\u007F]+", string.Empty);
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.LoadXml(xml);
    this.XMLStyle = xmlDocument.GetElementsByTagName("Style").Item(0);
  }

  [DebuggerStepThrough]
  private XmlAttributeOverrides GetListToIgnore()
  {
    XmlAttributeOverrides listToIgnore = new XmlAttributeOverrides();
    XmlAttributes attributes = new XmlAttributes();
    attributes.XmlIgnore = true;
    attributes.XmlElements.Add(new XmlElementAttribute("BackgroundThemeColor"));
    listToIgnore.Add(typeof (Style), "BackgroundThemeColor", attributes);
    attributes.XmlElements.Add(new XmlElementAttribute("ForegroundThemeColor"));
    listToIgnore.Add(typeof (Style), "ForegroundThemeColor", attributes);
    attributes.XmlElements.Add(new XmlElementAttribute("CultureCustom"));
    listToIgnore.Add(typeof (Style), "CultureCustom", attributes);
    return listToIgnore;
  }

  public Style ACStyle()
  {
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.AppendChild((XmlNode) xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", ""));
    xmlDocument.AppendChild(xmlDocument.ImportNode(this.XMLStyle, true));
    Style style1 = new Workbook().CreateStyle();
    Style style2 = (Style) StyleSerializationRoutines.DeserializeObject(xmlDocument.OuterXml, typeof (Style), this.GetListToIgnore());
    style1.BackgroundArgbColor = this.BackgroundColor;
    style1.BackgroundColor = Color.FromArgb(this.BackgroundColor);
    StyleBordersCollection borders1 = this.Borders;
    BorderCollection borders2 = style1.Borders;
    ref BorderCollection local = ref borders2;
    this.CopyBorders(borders1, ref local);
    if (this.Number > 0)
      style1.Number = this.Number;
    if (Operators.CompareString(style2.Custom.Trim(), "", false) != 0)
      style1.Custom = style2.Custom;
    this.CopyFont(this.Font, ref style1);
    style1.ForegroundArgbColor = this.ForegroundColor;
    style1.ForegroundColor = Color.FromArgb(this.ForegroundColor);
    style1.HorizontalAlignment = style2.HorizontalAlignment;
    style1.IndentLevel = style2.IndentLevel;
    style1.IsFormulaHidden = style2.IsFormulaHidden;
    style1.IsGradient = style2.IsGradient;
    style1.IsJustifyDistributed = style2.IsJustifyDistributed;
    style1.IsLocked = style2.IsLocked;
    style1.IsTextWrapped = style2.IsTextWrapped;
    style1.Name = style2.Name;
    style1.Pattern = style2.Pattern;
    style1.RotationAngle = style2.RotationAngle;
    style1.ShrinkToFit = style2.ShrinkToFit;
    style1.TextDirection = style2.TextDirection;
    style1.VerticalAlignment = style2.VerticalAlignment;
    return style1;
  }

  private void CopyBorders(StyleBordersCollection fromBorder, ref BorderCollection toBorder)
  {
    try
    {
      foreach (object obj in Enum.GetValues(typeof (BorderType)))
      {
        BorderType integer = (BorderType) Conversions.ToInteger(obj);
        toBorder[integer].ArgbColor = fromBorder.GetStyleBorder(integer.ToString()).ArgbColor;
        toBorder[integer].Color = fromBorder.GetStyleBorder(integer.ToString()).Color;
        toBorder[integer].LineStyle = fromBorder.GetStyleBorder(integer.ToString()).LineStyle;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void CopyFont(StyleFont fromFont, ref Style toFont)
  {
    toFont.Font.ArgbColor = fromFont.ArgbColor;
    toFont.Font.CapsType = fromFont.CapsType;
    toFont.Font.Charset = fromFont.Charset;
    toFont.Font.Color = Color.FromArgb(fromFont.Color);
    toFont.Font.DoubleSize = fromFont.DoubleSize;
    toFont.Font.IsBold = fromFont.IsBold;
    toFont.Font.IsItalic = fromFont.IsItalic;
    toFont.Font.IsNormalizeHeights = fromFont.IsNormalizeHeights;
    toFont.Font.IsStrikeout = fromFont.IsStrikeout;
    toFont.Font.IsSubscript = fromFont.IsSubscript;
    toFont.Font.IsSuperscript = fromFont.IsSuperscript;
    toFont.Font.Name = fromFont.Name;
    toFont.Font.ScriptOffset = fromFont.ScriptOffset;
    toFont.Font.Size = fromFont.Size;
    toFont.Font.StrikeType = fromFont.StrikeType;
    toFont.Font.Underline = fromFont.Underline;
  }
}
