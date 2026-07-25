// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Fortegra_frmProducerContacts
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using System;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides;

[Override(typeof (frmProducerContacts))]
public sealed class Fortegra_frmProducerContacts : frmProducerContacts
{
  public Fortegra_frmProducerContacts()
  {
  }

  public Fortegra_frmProducerContacts(Guid producerLocationGuid)
    : base(producerLocationGuid)
  {
  }

  public Fortegra_frmProducerContacts(Guid producerLocationGuid, Guid producerContactGuid)
    : base(producerLocationGuid, producerContactGuid)
  {
  }

  protected override void ClientNewContactControls()
  {
    this.dsContacts.tblProducerContacts[this.bmb.Position].DeliveryMethodID = 3;
    this.dsContacts.tblProducerContacts[this.bmb.Position].StatusID = 1;
    this.cboDeliveryMethod.Value = (object) 3;
  }
}
