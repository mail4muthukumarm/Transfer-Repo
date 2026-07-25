// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.ProducerContext
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class ProducerContext
{
  private readonly Guid _producerGuid;
  private readonly string _producerName;
  private readonly bool _closed;

  public ProducerContext(Guid producerGuid, string producerName, bool closed)
  {
    this._producerGuid = producerGuid;
    this._producerName = producerName;
    this._closed = closed;
  }

  public bool Closed => this._closed;

  public string ProducerName => this._producerName;

  public Guid ProducerGuid => this._producerGuid;
}
