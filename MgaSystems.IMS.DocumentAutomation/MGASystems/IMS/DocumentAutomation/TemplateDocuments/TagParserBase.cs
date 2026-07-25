// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.TagParserBase
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public abstract class TagParserBase : ITagParser
{
  public abstract bool SupportsQuoteOptionGuids();

  public virtual List<DocTag> ProcessPolicyFormTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID,
    int formTemplateID,
    int policyFormID)
  {
    return tags;
  }

  public abstract List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID);

  public abstract List<DocTag> ProcessTags(List<DocTag> tags, object entityId);

  public abstract List<DocTag> ProcessTags(List<DocTag> tags);

  public virtual Guid[] GetQuoteOptionGuids()
  {
    throw new InvalidOperationException("Must override GetQuoteOptionGuids when SupportsQuoteOptionGuids is True");
  }

  public void TagPostProcessing(List<DocTag> tags)
  {
    try
    {
      foreach (DocTag tag in tags)
      {
        if (tag.HasFunction)
          TagParserBase.PostProcess(tag);
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public static void PostProcess(DocTag tag)
  {
    string functionName = tag.FunctionName;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(functionName))
    {
      case 112513184:
        if (Operators.CompareString(functionName, "NUMNODEC", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatNumber((object) tag.TagValue, 0);
        break;
      case 317687193:
        if (Operators.CompareString(functionName, "PERNODEC", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatPercent((object) tag.TagValue, 0);
        break;
      case 345874802:
        if (Operators.CompareString(functionName, "R270", false) != 0 || tag.TagImage == DBNull.Value || tag.TagImage == null)
          break;
        tag.TagImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
        break;
      case 544339296:
        if (Operators.CompareString(functionName, "NUM3", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatNumber((object) tag.TagValue, 3);
        break;
      case 569132213:
        if (Operators.CompareString(functionName, "SHORT", false) != 0 || !Information.IsDate((object) tag.TagValue))
          break;
        tag.TagValue = Conversions.ToDate(tag.TagValue).ToShortDateString();
        break;
      case 661782629:
        if (Operators.CompareString(functionName, "NUM4", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatNumber((object) tag.TagValue, 4);
        break;
      case 688247133:
        if (Operators.CompareString(functionName, "DAY", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          tag.TagValue = Conversions.ToDate(tag.TagValue).ToString("dd");
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 893283200:
        if (Operators.CompareString(functionName, "PERONEDEC", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatPercent((object) tag.TagValue, 1);
        break;
      case 1353519379:
        if (Operators.CompareString(functionName, "NUM", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatNumber((object) tag.TagValue, 2);
        break;
      case 2133898005:
        if (Operators.CompareString(functionName, "CUR", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatCurrency((object) tag.TagValue);
        break;
      case 2165906170:
        if (Operators.CompareString(functionName, "CURNODEC", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatCurrency((object) tag.TagValue, 0);
        break;
      case 2585027932:
        if (Operators.CompareString(functionName, "YEAR", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          tag.TagValue = Conversions.ToDate(tag.TagValue).Year.ToString();
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 3047023174:
        if (Operators.CompareString(functionName, "MONTHNAME", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          tag.TagValue = DateAndTime.MonthName(Conversions.ToDate(tag.TagValue).Month);
          break;
        }
        if (Versioned.IsNumeric((object) tag.TagValue) && Conversions.ToInteger(tag.TagValue) > 0 && Conversions.ToInteger(tag.TagValue) < 12)
        {
          tag.TagValue = DateAndTime.MonthName(Conversions.ToInteger(tag.TagValue));
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 3235779411:
        if (Operators.CompareString(functionName, "LONG", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          tag.TagValue = Conversions.ToDate(tag.TagValue).ToLongDateString();
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 3243409493:
        if (Operators.CompareString(functionName, "WEEKDAY", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          tag.TagValue = DateAndTime.WeekdayName((int) (Conversions.ToDate(tag.TagValue).DayOfWeek + 1));
          break;
        }
        if (Versioned.IsNumeric((object) tag.TagValue) && Conversions.ToInteger(tag.TagValue) > 0 && Conversions.ToInteger(tag.TagValue) < 8)
        {
          tag.TagValue = DateAndTime.WeekdayName(Conversions.ToInteger(tag.TagValue));
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 3596936535:
        if (Operators.CompareString(functionName, "TELEPHONE", false) != 0)
          break;
        string input = tag.TagValue;
        if (input == null | (object) input == (object) DBNull.Value)
          input = "";
        string Expression = new Regex("\\D").Replace(input, string.Empty);
        if (Expression.Length > 10)
          Expression = Expression.TrimStart('1');
        if (!Versioned.IsNumeric((object) Expression))
          break;
        if (Expression.Length > 0 & Expression.Length < 4)
          Expression = $"{Expression.Substring(0, Expression.Length)}";
        else if (Expression.Length > 3 & Expression.Length < 7)
          Expression = $"{Expression.Substring(0, 3)}-{Expression.Substring(3, Expression.Length - 3)}";
        else if (Expression.Length > 6 & Expression.Length < 11)
          Expression = $"{Expression.Substring(0, 3)}-{Expression.Substring(3, 3)}-{Expression.Substring(6)}";
        else if (Expression.Length > 10)
        {
          string str = Expression.Remove(Expression.Length - 1, 1);
          Expression = $"{str.Substring(0, 3)}-{str.Substring(3, 3)}-{str.Substring(6)}";
        }
        tag.TagValue = Expression;
        break;
      case 3604417596:
        if (Operators.CompareString(functionName, "R90", false) != 0 || tag.TagImage == DBNull.Value || tag.TagImage == null)
          break;
        tag.TagImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
        break;
      case 3655174212:
        if (Operators.CompareString(functionName, "R180", false) != 0 || tag.TagImage == DBNull.Value || tag.TagImage == null)
          break;
        tag.TagImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
        break;
      case 3833971138:
        if (Operators.CompareString(functionName, "LONGNODAY", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          DateTime date = Conversions.ToDate(tag.TagValue);
          tag.TagValue = $"{DateAndTime.MonthName(date.Month)} {date.Day.ToString()}, {Conversions.ToString(date.Year)}";
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 3865452901:
        if (Operators.CompareString(functionName, "MONTH", false) != 0)
          break;
        if (Information.IsDate((object) tag.TagValue))
        {
          tag.TagValue = Conversions.ToDate(tag.TagValue).ToString("MM");
          break;
        }
        tag.TagValue = string.Empty;
        break;
      case 4026601156:
        if (Operators.CompareString(functionName, "PER", false) != 0 || !Versioned.IsNumeric((object) tag.TagValue))
          break;
        tag.TagValue = Strings.FormatPercent((object) tag.TagValue);
        break;
    }
  }

  IList<IDocTag> ITagParser.ProcessTagList(IList<IDocTag> tags)
  {
    List<DocTag> tags1 = new List<DocTag>();
    try
    {
      foreach (IDocTag tag in (IEnumerable<IDocTag>) tags)
        tags1.Add((DocTag) tag);
    }
    finally
    {
      IEnumerator<IDocTag> enumerator;
      enumerator?.Dispose();
    }
    List<DocTag> docTagList = this.ProcessTags(tags1);
    tags.Clear();
    try
    {
      foreach (IDocTag docTag in docTagList)
        tags.Add(docTag);
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return tags;
  }
}
