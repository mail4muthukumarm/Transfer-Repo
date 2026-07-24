// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.Exterior
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[GeneratedCode("xsd", "4.6.1590.0")]
[XmlType(TypeName = "tEXTERIOR")]
[Serializable]
public enum Exterior
{
  [XmlEnum("Brick Veneer, Face Brick")] brickveneerfacebrick,
  [XmlEnum("brick veneer, glazed")] brickveneerglazed,
  [XmlEnum("brick veneer, jumbo")] brickveneerjumbo,
  [XmlEnum("brick veneer, large")] brickveneerlarge,
  [XmlEnum("brick veneer, norman")] brickveneernorman,
  [XmlEnum("brick veneer, roman")] brickveneerroman,
  [XmlEnum("brick veneer, standard")] brickveneerstandard,
  [XmlEnum("brick wall, cavity")] brickwallcavity,
  [XmlEnum("brick wall, reinforced")] brickwallreinforced,
  [XmlEnum("concrete block")] concreteblock,
  [XmlEnum("concrete block, glazed")] concreteblockglazed,
  [XmlEnum("concrete block, slumpstone")] concreteblockslumpstone,
  [XmlEnum("concrete block, split face")] concreteblocksplitface,
  [XmlEnum("concrete wall, cast in place")] concretewallcastinplace,
  [XmlEnum("log  (<11\"diameter)")] log11diameter,
  [XmlEnum("log  (>11\"diameter)")] log11diameter1,
  [XmlEnum("metal siding, aluminum, simulated wood")] metalsidingaluminumsimulatedwood,
  [XmlEnum("metal siding, baked enamel")] metalsidingbakedenamel,
  [XmlEnum("metal siding, corrugated aluminum")] metalsidingcorrugatedaluminum,
  [XmlEnum("metal siding, corrugated aluminum, painted")] metalsidingcorrugatedaluminumpainted,
  [XmlEnum("metal siding, corrugated composition")] metalsidingcorrugatedcomposition,
  [XmlEnum("metal siding, corrugated fiberglass")] metalsidingcorrugatedfiberglass,
  [XmlEnum("metal siding, corrugated galvanized iron")] metalsidingcorrugatedgalvanizediron,
  [XmlEnum("metal siding, porcelain")] metalsidingporcelain,
  None,
  [XmlEnum("panels, brick")] panelsbrick,
  [XmlEnum("panels, cement fiber")] panelscementfiber,
  [XmlEnum("panels, concrete block")] panelsconcreteblock,
  [XmlEnum("panels, fiberglass")] panelsfiberglass,
  [XmlEnum("panels, glass and aluminum")] panelsglassandaluminum,
  [XmlEnum("panels, glass and metal")] panelsglassandmetal,
  [XmlEnum("panels, polycarbonate")] panelspolycarbonate,
  [XmlEnum("panels, rubble")] panelsrubble,
  [XmlEnum("panels, sandwich")] panelssandwich,
  [XmlEnum("panels, stone")] panelsstone,
  [XmlEnum("panels, stucco")] panelsstucco,
  [XmlEnum("polyethylene film (greenhouse)")] polyethylenefilmgreenhouse,
  [XmlEnum("Precast Concrete Panel")] precastconcretepanel,
  [XmlEnum("precast concrete panel, granite finish")] precastconcretepanelgranitefinish,
  [XmlEnum("siding, barn board")] sidingbarnboard,
  [XmlEnum("siding, board and batten")] sidingboardandbatten,
  [XmlEnum("siding, cedar beveled")] sidingcedarbeveled,
  [XmlEnum("siding, cedar shingles")] sidingcedarshingles,
  [XmlEnum("siding, glasweld")] sidingglasweld,
  [XmlEnum("siding, hardboard")] sidinghardboard,
  [XmlEnum("siding, lap board")] sidinglapboard,
  [XmlEnum("siding, plywood")] sidingplywood,
  [XmlEnum("siding, redwood beveled")] sidingredwoodbeveled,
  [XmlEnum("siding, spaced board")] sidingspacedboard,
  [XmlEnum("siding, tongue and grove")] sidingtongueandgrove,
  [XmlEnum("siding, vinyl")] sidingvinyl,
  [XmlEnum("stone veneer, arizona stone")] stoneveneerarizonastone,
  [XmlEnum("stone veneer, granite")] stoneveneergranite,
  [XmlEnum("stone veneer, lava stone")] stoneveneerlavastone,
  [XmlEnum("stone veneer, limestone")] stoneveneerlimestone,
  [XmlEnum("stone veneer, rubble")] stoneveneerrubble,
  [XmlEnum("stone veneer, sandstone")] stoneveneersandstone,
  stucco,
  [XmlEnum("tilt-up, concrete wall")] tiltupconcretewall,
  [XmlEnum("tilt-up, concrete wall, with pilasters")] tiltupconcretewallwithpilasters,
}
