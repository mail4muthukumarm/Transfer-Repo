// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Logging.CategoryTraceFilter
// Assembly: MGASystems.IMS.Logging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DEDE5ABB-2A35-47E4-BD3C-0B33B15168EB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Logging.dll

using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace MGASystems.IMS.Logging;

public class CategoryTraceFilter : TraceFilter
{
  private readonly HashSet<string> categories;

  public CategoryTraceFilter()
    : this(new HashSet<string>())
  {
  }

  public CategoryTraceFilter(HashSet<string> categories) => this.categories = categories;

  public override bool ShouldTrace(
    TraceEventCache cache,
    string source,
    TraceEventType eventType,
    int id,
    string formatOrMessage,
    object[] args,
    object data1,
    object[] data)
  {
    return this.categories.Contains(formatOrMessage);
  }

  public bool AddCategory(string category) => this.categories.Add(category);

  public bool RemoveCategory(string category) => this.categories.Remove(category);

  public void ClearCategories() => this.categories.Clear();
}
