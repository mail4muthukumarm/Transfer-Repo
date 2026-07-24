// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.Data.RoofCovering
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value.Data;

[GeneratedCode("xsd", "4.6.1590.0")]
[XmlType("tROOFCOVERING")]
[Serializable]
public enum RoofCovering
{
  acrylic,
  [XmlEnum("bituthene, self-seal")] bitutheneselfseal,
  [XmlEnum("built-up composition, high rise, 3 ply")] builtupcompositionhighrise3ply,
  [XmlEnum("built-up composition, low rise, 3 ply")] builtupcompositionlowrise3ply,
  [XmlEnum("Built-up Tar And Gravel")] builtuptarandgravel,
  [XmlEnum("copper clad stainless steel")] coppercladstainlesssteel,
  [XmlEnum("copper, standing seam")] copperstandingseam,
  [XmlEnum("corrugated aluminum")] corrugatedaluminum,
  [XmlEnum("corrugated composition")] corrugatedcomposition,
  [XmlEnum("corrugated fiberglass")] corrugatedfiberglass,
  [XmlEnum("corrugated galvanized iron")] corrugatedgalvanizediron,
  Dibiten,
  [XmlEnum("earth covered")] earthcovered,
  [XmlEnum("glass panels")] glasspanels,
  [XmlEnum("metal other than standing seam")] metalotherthanstandingseam,
  [XmlEnum("metal, standing seam")] metalstandingseam,
  [XmlEnum("plastic, elastomeric membrane")] plasticelastomericmembrane,
  [XmlEnum("plastic, elastomeric membrane, loose, trocal")] plasticelastomericmembraneloosetrocal,
  [XmlEnum("plastic, elastomeric membrane, neoprene")] plasticelastomericmembraneneoprene,
  [XmlEnum("polycarbonate panels")] polycarbonatepanels,
  [XmlEnum("polyethylene film")] polyethylenefilm,
  rubber,
  [XmlEnum("shakes, cedar")] shakescedar,
  [XmlEnum("shakes, wood")] shakeswood,
  [XmlEnum("shingles, aluminum tab")] shinglesaluminumtab,
  [XmlEnum("shingles, architectural")] shinglesarchitectural,
  [XmlEnum("shingles, asbestos replacement")] shinglesasbestosreplacement,
  [XmlEnum("shingles, asphalt")] shinglesasphalt,
  [XmlEnum("shingles, cedar")] shinglescedar,
  [XmlEnum("shingles, composition")] shinglescomposition,
  [XmlEnum("shingles, composition asphalt")] shinglescompositionasphalt,
  [XmlEnum("shingles, dimensional asphalt")] shinglesdimensionalasphalt,
  [XmlEnum("shingles, fiberglass tabs")] shinglesfiberglasstabs,
  [XmlEnum("shingles, Minera")] shinglesMinera,
  [XmlEnum("shingles, porcelain enamel")] shinglesporcelainenamel,
  [XmlEnum("shingles, wood")] shingleswood,
  [XmlEnum("silicone, 3 ply, rolled")] silicone3plyrolled,
  steel,
  [XmlEnum("tile, barrel")] tilebarrel,
  [XmlEnum("tile, clay, flat bed")] tileclayflatbed,
  [XmlEnum("tile, clay, glazed, interlock")] tileclayglazedinterlock,
  [XmlEnum("tile, clay, Spanish")] tileclaySpanish,
  [XmlEnum("tile, concrete, flat")] tileconcreteflat,
  [XmlEnum("tile, concrete, interlock")] tileconcreteinterlock,
  [XmlEnum("tile, concrete, premium")] tileconcretepremium,
  [XmlEnum("tile, Ludowici")] tileLudowici,
  [XmlEnum("tile, slate")] tileslate,
  [XmlEnum("tile, slate, graduated")] tileslategraduated,
  [XmlEnum("tile, slate, patterned")] tileslatepatterned,
  [XmlEnum("tile, slate, red")] tileslatered,
  [XmlEnum("tile, slate, synthetic")] tileslatesynthetic,
  [XmlEnum("urethane foam, silicone cover")] urethanefoamsiliconecover,
}
