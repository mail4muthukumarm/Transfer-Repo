// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Fortegra_frmProducers
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using System;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides;

[Override(typeof (frmProducers))]
public sealed class Fortegra_frmProducers : frmProducers
{
  public Fortegra_frmProducers()
  {
  }

  public Fortegra_frmProducers(Guid producerGuid)
    : base(producerGuid)
  {
  }

  public Fortegra_frmProducers(Guid producerGuid, Guid producerLocationGuid)
    : base(producerGuid, producerLocationGuid)
  {
  }

  protected override void DefaultLocationOverride(dsProducers.tblProducerLocationsRow dr)
  {
    dr.ProducerTypeID = 3;
    dr.DeliveryMethodID = 1;
    dr.LocationTypeID = 1;
    dr.StatusID = 1;
  }
}
