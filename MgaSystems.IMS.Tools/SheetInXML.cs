// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.SheetInXML
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class SheetInXML : List<WorkSheetProperties>
{
  private string m_name;
  private int m_index;

  public int FreezedPanesRow => (int) this.GetProperty(nameof (FreezedPanesRow));

  public int FreezedPanesColumn => (int) this.GetProperty(nameof (FreezedPanesColumn));

  public int FreezedPanesRows => (int) this.GetProperty(nameof (FreezedPanesRows));

  public int FreezedPanesColumns => (int) this.GetProperty(nameof (FreezedPanesColumns));

  public int Index => (int) this.GetProperty(nameof (Index));

  public string Name => (string) this.GetProperty(nameof (Name));

  public SheetInXML()
  {
  }

  public SheetInXML(Worksheet ws)
  {
    int num1;
    int num2;
    int num3;
    int num4;
    ws.GetFreezedPanes(ref num1, ref num2, ref num3, ref num4);
    this.Add(new WorkSheetProperties(nameof (FreezedPanesRow), (object) num1, num1.GetType().FullName));
    this.Add(new WorkSheetProperties(nameof (FreezedPanesColumn), (object) num2, num2.GetType().FullName));
    this.Add(new WorkSheetProperties(nameof (FreezedPanesRows), (object) num3, num3.GetType().FullName));
    this.Add(new WorkSheetProperties(nameof (FreezedPanesColumns), (object) num4, num4.GetType().FullName));
    PropertyInfo[] properties = ws.GetType().GetProperties();
    int index = 0;
    while (index < properties.Length)
    {
      PropertyInfo propertyInfo = properties[index];
      if (!this.IgnoreProperty(propertyInfo.Name))
        this.Add(new WorkSheetProperties()
        {
          Name = propertyInfo.Name,
          Value = RuntimeHelpers.GetObjectValue(propertyInfo.GetValue((object) ws)),
          PropType = propertyInfo.PropertyType.FullName
        });
      checked { ++index; }
    }
  }

  private bool IgnoreProperty(string PropertyName)
  {
    string Left = PropertyName;
    return Operators.CompareString(Left, "Cells", false) == 0 || Operators.CompareString(Left, "Outline", false) == 0 || Operators.CompareString(Left, "PageSetup", false) == 0 || Operators.CompareString(Left, "ListObjects", false) == 0 || Operators.CompareString(Left, "ListObjectCollection", false) == 0 || Operators.CompareString(Left, "Workbook", false) == 0;
  }

  public Worksheet ACSheet()
  {
    Workbook workbook = new Workbook();
    workbook.Worksheets.Clear();
    workbook.Worksheets.Add();
    Worksheet worksheet = workbook.Worksheets[0];
    Type type = typeof (Worksheet);
    try
    {
      foreach (WorkSheetProperties workSheetProperties in (List<WorkSheetProperties>) this)
      {
        if (workSheetProperties.Name.Length <= 10 || Operators.CompareString(workSheetProperties.Name.Substring(0, 7), "Freezed", false) != 0)
        {
          PropertyInfo property = type.GetProperty(workSheetProperties.Name);
          if (property.CanWrite)
            property.SetValue((object) worksheet, RuntimeHelpers.GetObjectValue(workSheetProperties.Value));
        }
      }
    }
    finally
    {
      List<WorkSheetProperties>.Enumerator enumerator;
      enumerator.Dispose();
    }
    int freezedPanesRows = this.FreezedPanesRows;
    int freezedPanesColumns = this.FreezedPanesColumns;
    int freezedPanesRow = this.FreezedPanesRow;
    int freezedPanesColumn = this.FreezedPanesColumn;
    if (freezedPanesRows > 0 | freezedPanesColumns > 0)
      worksheet.FreezePanes(freezedPanesRow, freezedPanesColumn, freezedPanesRows, freezedPanesColumns);
    return worksheet;
  }

  public object GetProperty(string Name)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(new object());
    try
    {
      foreach (WorkSheetProperties workSheetProperties in (List<WorkSheetProperties>) this)
      {
        if (Operators.CompareString(workSheetProperties.Name, Name, false) == 0)
        {
          objectValue = RuntimeHelpers.GetObjectValue(workSheetProperties.Value);
          break;
        }
      }
    }
    finally
    {
      List<WorkSheetProperties>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return objectValue;
  }
}
