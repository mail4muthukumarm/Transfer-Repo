// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Line
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.lstLines")]
public class Line : BaseDataObject
{
  private Guid _lineGuid;
  private static Dictionary<int, Guid> _lineIdToGuidCache = new Dictionary<int, Guid>();

  public Line(Guid lineGuid) => this._lineGuid = lineGuid;

  public Line(int lineId)
  {
    if (Line._lineIdToGuidCache.TryGetValue(lineId, out this._lineGuid))
      return;
    this._lineGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT LineGUID FROM dbo.lstLines WITH(NOLOCK) WHERE LineID = @LID", new object[2]
    {
      (object) "@LID",
      (object) lineId
    }) ?? Guid.Empty;
    Line._lineIdToGuidCache[lineId] = !this._lineGuid.Equals(Guid.Empty) ? this._lineGuid : throw new InvalidOperationException("Specified Line does not exist.");
  }

  [DataKey]
  public Guid LineGuid
  {
    get => this._lineGuid;
    protected set
    {
      this._lineGuid = this._lineGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified Line {this._lineGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int LineID => this.GetField<int>(nameof (LineID), nameof (LineID));

  [TableFieldMapping]
  public string LineName => this.GetField<string>(nameof (LineName), nameof (LineName));

  [TableFieldMapping]
  public string LineCode => this.GetField<string>(nameof (LineCode), nameof (LineCode));

  [TableFieldMapping]
  public bool Inactive => this.GetField<bool>(nameof (Inactive), nameof (Inactive));

  [TableFieldMapping]
  public string NetRate_LOB_Code
  {
    get
    {
      return !this.GetNetrateFields() ? (string) null : this.GetField<string>(nameof (NetRate_LOB_Code), nameof (NetRate_LOB_Code));
    }
  }

  [TableFieldMapping]
  public string NetRate_ProgramName
  {
    get
    {
      return !this.GetNetrateFields() ? (string) null : this.GetField<string>(nameof (NetRate_ProgramName), nameof (NetRate_ProgramName));
    }
  }

  [TableFieldMapping]
  public string NetRate_ProgramCode
  {
    get
    {
      return !this.GetNetrateFields() ? (string) null : this.GetField<string>(nameof (NetRate_ProgramCode), nameof (NetRate_ProgramCode));
    }
  }

  private bool GetNetrateFields()
  {
    return this.RetrieveFields("NetRate_LOB_Code", "NetRate_ProgramCode", "NetRate_ProgramName");
  }
}
