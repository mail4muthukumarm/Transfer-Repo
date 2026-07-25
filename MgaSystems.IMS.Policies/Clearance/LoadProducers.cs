// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.LoadProducers
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Common;
using MGASystems.Common.Settings;
using MGASystems.Data;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.Clearance;

internal class LoadProducers : ISupportBlackboxPreload
{
  string ISupportPreLoadCache.PreLoadKey => "ProducerList";

  void ISupportPreLoadCache.OnAsynchronousLoad(object sender, OnAsynchronousLoadEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    DataTable dataTable = new DataTable("ProducerLocations");
    dataTable.Columns.Add("ProducerLocationGuid", typeof (Guid));
    dataTable.Columns.Add("Name", typeof (string));
    dataTable.Rows.Add((object) Guid.Empty, (object) string.Empty);
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (discard, reader) => dataTable.Load(reader.Reader)), SystemSettings.GetSetting<string>("ClearanceProducerLocationsDropDownProc", "dbo.GetClearanceProducerLocations"), new object[2]
    {
      (object) "@CurrentUser",
      (object) CurrentUser.Instance.UserGUID
    });
    e.Cache.Add((object) "tblProducerLocations", (object) dataTable);
  }
}
