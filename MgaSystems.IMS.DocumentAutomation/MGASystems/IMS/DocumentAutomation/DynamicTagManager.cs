// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DynamicTagManager
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class DynamicTagManager
{
  private static Dictionary<string, DynamicTagData> dynamicTags;

  public static void ResetTags()
  {
    DynamicTagManager.dynamicTags = (Dictionary<string, DynamicTagData>) null;
  }

  public static List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID,
    Guid quoteGuid)
  {
    DynamicTagManager.InitializeDynamicTags();
    try
    {
      foreach (DocTag tag in tags)
      {
        if (DynamicTagManager.dynamicTags.ContainsKey(tag.InnerTagName))
        {
          DynamicTagData dynamicTag = DynamicTagManager.dynamicTags[tag.InnerTagName];
          tag.TagValue = DynamicTagManager.SelectDatabaseStringValue(dynamicTag.DataFieldName, dynamicTag.DataTableName, quoteGuid);
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return tags;
  }

  private static void InitializeDynamicTags()
  {
    if (DynamicTagManager.dynamicTags != null)
      return;
    DynamicTagManager.dynamicTags = new Dictionary<string, DynamicTagData>();
    try
    {
      DynamicTagListManager.InitializeTags(DynamicTagManager.dynamicTags);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private static string SelectDatabaseStringValue(
    string dataFieldName,
    string dataTableName,
    Guid quoteGuid)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, $"select {dataFieldName} from {dataTableName} where quoteGuid = @quoteGuid", new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (!(objectValue is Decimal) ? objectValue.ToString() : DynamicTagManager.AdjustDecimal(Conversions.ToDecimal(objectValue))) : "Null Dynamic Result";
  }

  private static string AdjustDecimal(Decimal value)
  {
    string str = value.ToString();
    return !str.Contains(".") ? str : value.ToString("F2");
  }

  public static void GetAvailableTagList(dsTemplateDocs.TagsDataTable dt)
  {
    DynamicTagManager.InitializeDynamicTags();
    try
    {
      foreach (KeyValuePair<string, DynamicTagData> dynamicTag in DynamicTagManager.dynamicTags)
        dt.AddTagsRow(dynamicTag.Value.TagName, dynamicTag.Value.TagDescription, dynamicTag.Value.GroupName);
    }
    finally
    {
      Dictionary<string, DynamicTagData>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }
}
