// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Producer
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblProducers")]
public class Producer : BaseDataObject
{
  private Guid _producerGuid;

  public Producer(Guid producerGuid) => this._producerGuid = producerGuid;

  [DataKey]
  public Guid ProducerGuid
  {
    get => this._producerGuid;
    protected set
    {
      this._producerGuid = this._producerGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified Producer {this._producerGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int ProducerCode => this.GetField<int>(nameof (ProducerCode), nameof (ProducerCode));

  [TableFieldMapping]
  public string ProducerName => this.GetField<string>(nameof (ProducerName), nameof (ProducerName));

  [TableFieldMapping]
  public bool Closed => this.GetField<bool>(nameof (Closed), nameof (Closed));

  [TableFieldMapping]
  public short ProducerBusinessTypeID
  {
    get => this.GetField<short>(nameof (ProducerBusinessTypeID), nameof (ProducerBusinessTypeID));
  }
}
