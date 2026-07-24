// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.RCTImport
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RCT;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
[Serializable]
public class RCTImport
{
  private Inspection[] inspectionsField;
  private Client[] clientsField;
  private Broker[] brokersField;
  private Inspector[] inspectorsField;
  private UnderWriter[] underWritersField;
  private Company[] companiesField;

  [XmlArrayItem("Inspection", IsNullable = false)]
  public Inspection[] Inspections
  {
    get => this.inspectionsField;
    set => this.inspectionsField = value;
  }

  [XmlArrayItem("Client", IsNullable = false)]
  public Client[] Clients
  {
    get => this.clientsField;
    set => this.clientsField = value;
  }

  [XmlArrayItem("Broker", IsNullable = false)]
  public Broker[] Brokers
  {
    get => this.brokersField;
    set => this.brokersField = value;
  }

  [XmlArrayItem("Inspector", IsNullable = false)]
  public Inspector[] Inspectors
  {
    get => this.inspectorsField;
    set => this.inspectorsField = value;
  }

  [XmlArrayItem("UnderWriter", IsNullable = false)]
  public UnderWriter[] UnderWriters
  {
    get => this.underWritersField;
    set => this.underWritersField = value;
  }

  [XmlArrayItem("Company", IsNullable = false)]
  public Company[] Companies
  {
    get => this.companiesField;
    set => this.companiesField = value;
  }
}
