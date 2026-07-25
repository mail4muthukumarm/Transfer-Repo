// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.CompanyInfoType
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RCT;

[GeneratedCode("xsd", "4.8.3928.0")]
[XmlType(AnonymousType = true)]
[Serializable]
public enum CompanyInfoType
{
  Agent,
  Survey,
  Insurance,
}
