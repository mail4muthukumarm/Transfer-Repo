// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DynamicTagListManager
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DynamicWindows.Data;
using Mga.Wpf.Ims.ExtensionMethods;
using MGASystems.Common;
using MGASystems.Common.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class DynamicTagListManager
{
  private DynamicTagListManager()
  {
  }

  public static Dictionary<string, DynamicTagData> InitializeTags(
    Dictionary<string, DynamicTagData> dynamicTags)
  {
    Dictionary<string, DynamicTagData> dictionary;
    if (MDIControls.Instance.MDIParent != null && MDIControls.Instance.MDIParent.InvokeRequired)
      dictionary = (Dictionary<string, DynamicTagData>) RuntimeHelpers.GetObjectValue(MDIControls.Instance.MDIParent.Invoke((Delegate) new DynamicTagListManager.InitDelegate(DynamicTagListManager.InitTagsProc), (object) dynamicTags));
    else
      dictionary = DynamicTagListManager.InitTagsProc(dynamicTags);
    return dictionary;
  }

  public static Dictionary<string, DynamicTagData> InitTagsProc(
    Dictionary<string, DynamicTagData> dynamicTags)
  {
    DynamicWindowCollection windowCollection = new DynamicWindowCollection();
    try
    {
      foreach (DynamicWindow dynamicWindow1 in (Collection<DynamicWindow>) windowCollection)
      {
        if (XamlReader.Parse(StringExtensions.Decompress(dynamicWindow1.GetXaml())) is IDynamicWindow dynamicWindow2)
          DynamicTagListManager.InitializeDynamicWindowTags(dynamicWindow2, dynamicWindow1.Name, dynamicWindow1.Name, dynamicTags);
      }
    }
    finally
    {
      IEnumerator<DynamicWindow> enumerator;
      enumerator?.Dispose();
    }
    return dynamicTags;
  }

  public static void InitializeDynamicWindowTags(
    IDynamicWindow dynamicWindow,
    string groupName,
    string tableName,
    Dictionary<string, DynamicTagData> dynamicTags)
  {
    if (!(dynamicWindow is DependencyObject dependencyObject))
      return;
    string str1 = tableName;
    string str2 = dependencyObject.GetValue(DataSelector.TagParserGroupProperty) as string;
    if (!string.IsNullOrEmpty(str2))
      groupName = str2;
    string str3 = dependencyObject.GetValue(DataSelector.TagParserTagPrefixProperty) as string;
    if (!string.IsNullOrEmpty(str3))
      str1 = str3;
    Dictionary<string, ControlData> dictionary = new Dictionary<string, ControlData>();
    DataSelector.FetchData(dependencyObject, dictionary, false);
    try
    {
      foreach (KeyValuePair<string, ControlData> keyValuePair in dictionary)
      {
        if (keyValuePair.Value.Control.GetValue(DataSelector.TagParserDescriptionProperty) is string tagDescription)
          DynamicTagListManager.AddTag(dynamicTags, string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}_{1}", (object) str1, (object) keyValuePair.Value.Control.Name), tagDescription, keyValuePair.Value.Control.Name, string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Dynamic_Data_{0}", (object) tableName), groupName);
      }
    }
    finally
    {
      Dictionary<string, ControlData>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private static void AddTag(
    Dictionary<string, DynamicTagData> dynamicTags,
    string tagName,
    string tagDescription,
    string dataFieldName,
    string dataTableName,
    string groupName)
  {
    dynamicTags.Add(tagName, new DynamicTagData(dataTableName, tagName, tagDescription, dataFieldName, groupName));
  }

  private delegate Dictionary<string, DynamicTagData> InitDelegate(
    Dictionary<string, DynamicTagData> dynamicTags);
}
