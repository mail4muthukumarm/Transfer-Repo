// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.ProducerContactChangedContext
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class ProducerContactChangedContext
{
  private Guid _oldContactGuid;
  private Guid _newContactGuid;
  private List<Guid> _quoteGuidList;

  public ProducerContactChangedContext(
    Guid oldContactGuid,
    Guid newContactGuid,
    List<Guid> quoteGuidList)
  {
    this._quoteGuidList = new List<Guid>();
    this._oldContactGuid = oldContactGuid;
    this._newContactGuid = newContactGuid;
    this._quoteGuidList = quoteGuidList;
  }

  public Guid OldContactGuid => this._oldContactGuid;

  public Guid NewContactGuid => this._newContactGuid;

  public List<Guid> QuoteGuidList => this._quoteGuidList;
}
