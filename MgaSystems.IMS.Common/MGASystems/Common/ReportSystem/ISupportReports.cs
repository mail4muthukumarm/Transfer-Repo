// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ReportSystem.ISupportReports
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using GrapeCity.ActiveReports;
using System;
using System.Collections;

#nullable disable
namespace MGASystems.Common.ReportSystem;

public interface ISupportReports
{
  DictionaryEntry[] ReportItems { get; }

  SectionReport PrintReport(string key);

  void PrintErrorOccured(Exception ex, ref bool showDialog);
}
