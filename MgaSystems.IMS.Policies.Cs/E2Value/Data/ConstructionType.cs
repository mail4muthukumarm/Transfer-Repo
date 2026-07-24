// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.ConstructionType
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[GeneratedCode("xsd", "4.6.1590.0")]
[XmlType(TypeName = "tCONSTRUCTIONTYPE")]
[Serializable]
public enum ConstructionType
{
  [XmlEnum("A - frame")] Aframe,
  [XmlEnum("fireproof structural steel frame")] fireproofstructuralsteelframe,
  [XmlEnum("foam form concrete")] foamformconcrete,
  [XmlEnum("Framing, Steel")] framingsteel,
  [XmlEnum("framing, wood")] framingwood,
  [XmlEnum("framing, wood with elevated slab")] framingwoodwithelevatedslab,
  [XmlEnum("hoop arch")] hooparch,
  [XmlEnum("masonry bearing walls")] masonrybearingwalls,
  [XmlEnum("masonry, block")] masonryblock,
  [XmlEnum("masonry, brick")] masonrybrick,
  [XmlEnum("masonry, stone")] masonrystone,
  [XmlEnum("metal frame")] metalframe,
  [XmlEnum("metal frame (slant)")] metalframeslant,
  [XmlEnum("milled timbers")] milledtimbers,
  [XmlEnum("pole frame")] poleframe,
  [XmlEnum("post and beam")] postandbeam,
  prefabricated,
  quonset,
  [XmlEnum("reinforced concrete frame")] reinforcedconcreteframe,
  [XmlEnum("stucco on masonry")] stuccoonmasonry,
  [XmlEnum("veneer, brick")] veneerbrick,
  [XmlEnum("veneer, brick with wood frame")] veneerbrickwithwoodframe,
  [XmlEnum("veneer, stone")] veneerstone,
  [XmlEnum("wood frame, modular")] woodframemodular,
}
