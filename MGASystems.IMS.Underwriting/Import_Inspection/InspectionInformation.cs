// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.InspectionInformation
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public class InspectionInformation
{
  public List<string> InvalidData { get; set; }

  public int InspectionInfoID { get; set; }

  public int ControlNo { get; set; }

  [DefaultColumn("Case Number")]
  public string CaseNumber { get; set; }

  [DefaultColumn("Customer")]
  public string Customer { get; set; }

  [DefaultColumn("Case Type")]
  public string CaseType { get; set; }

  [DefaultColumn("Insured Name")]
  public string InsuredName { get; set; }

  [DefaultColumn("Address Line1")]
  public string Address1 { get; set; }

  [DefaultColumn("Address Line2")]
  public string Address2 { get; set; }

  [DefaultColumn("City")]
  public string City { get; set; }

  [DefaultColumn("State")]
  public string State { get; set; }

  [DefaultColumn("Zip")]
  public string Zip { get; set; }

  [DefaultColumn("Completion Date")]
  public DateTime? CompletionDate { get; set; }

  [DefaultColumn("Effective Date")]
  public DateTime? EffectiveDate { get; set; }

  [DefaultColumn("[AddlStr] Additional structures")]
  public string AddlStructures { get; set; }

  [DefaultColumn("[AgeEst] Estimated age")]
  public int? AgeEst { get; set; }

  [DefaultColumn("[AllThatApply] Hazards Present")]
  public string HazardsPresent { get; set; }

  [DefaultColumn("[AreaEcon] Area economy")]
  public string AreaEconomy { get; set; }

  [DefaultColumn("[AttrYN] Attractive nuisances present")]
  public string NuisancesPresent { get; set; }

  [DefaultColumn("[BldgComm] Building comments")]
  public string BldgComments { get; set; }

  [DefaultColumn("[BldgTypeOth] Building type other")]
  public string BldgTypeOther { get; set; }

  [DefaultColumn("[CancReqBy] Cancellation requested by")]
  public string CancellationReqBy { get; set; }

  [DefaultColumn("[cate] Contact")]
  public string Contact { get; set; }

  [DefaultColumn("[ConstClass] Construction class")]
  public string ConstructionClass { get; set; }

  [DefaultColumn("[contact1] Contact")]
  public string Contact1 { get; set; }

  [DefaultColumn("[Contact10] Contact")]
  public string Contact10 { get; set; }

  [DefaultColumn("[Contact11] Contact")]
  public string Contact11 { get; set; }

  [DefaultColumn("[Contact12] Contact")]
  public string Contact12 { get; set; }

  [DefaultColumn("[Contact13] Contact")]
  public string Contact13 { get; set; }

  [DefaultColumn("[Contact14] Contact")]
  public string Contact14 { get; set; }

  [DefaultColumn("[Contact15] Contact")]
  public string Contact15 { get; set; }

  [DefaultColumn("[Contact16] Contact")]
  public string Contact16 { get; set; }

  [DefaultColumn("[Contact17] Contact")]
  public string Contact17 { get; set; }

  [DefaultColumn("[Contact18] Contact")]
  public string Contact18 { get; set; }

  [DefaultColumn("[Contact19] Contact")]
  public string Contact19 { get; set; }

  [DefaultColumn("[Contact2] Contact")]
  public string Contact2 { get; set; }

  [DefaultColumn("[Contact20] Contact")]
  public string Contact20 { get; set; }

  [DefaultColumn("[Contact21] Contact")]
  public string Contact21 { get; set; }

  [DefaultColumn("[Contact22] Contact")]
  public string Contact22 { get; set; }

  [DefaultColumn("[Contact23] Contact")]
  public string Contact23 { get; set; }

  [DefaultColumn("[Contact24] Contact")]
  public string Contact24 { get; set; }

  [DefaultColumn("[Contact25] Contact")]
  public string Contact25 { get; set; }

  [DefaultColumn("[Contact26] Contact")]
  public string Contact26 { get; set; }

  [DefaultColumn("[Contact27] Contact")]
  public string Contact27 { get; set; }

  [DefaultColumn("[Contact28] Contact")]
  public string Contact28 { get; set; }

  [DefaultColumn("[Contact29] Contact")]
  public string Contact29 { get; set; }

  [DefaultColumn("[Contact3] Contact")]
  public string Contact3 { get; set; }

  [DefaultColumn("[Contact30] Contact")]
  public string Contact30 { get; set; }

  [DefaultColumn("[Contact311] Contact")]
  public string Contact311 { get; set; }

  [DefaultColumn("[Contact32] Contact")]
  public string Contact32 { get; set; }

  [DefaultColumn("[Contact33] Contact")]
  public string Contact33 { get; set; }

  [DefaultColumn("[Contact35] Contact")]
  public string Contact35 { get; set; }

  [DefaultColumn("[Contact36] Contact")]
  public string Contact36 { get; set; }

  [DefaultColumn("[Contact37] Contact")]
  public string Contact37 { get; set; }

  [DefaultColumn("[Contact38] Contact")]
  public string Contact38 { get; set; }

  [DefaultColumn("[Contact39] Contact")]
  public string Contact39 { get; set; }

  [DefaultColumn("[Contact4] Contact")]
  public string Contact4 { get; set; }

  [DefaultColumn("[Contact40] Contact")]
  public string Contact40 { get; set; }

  [DefaultColumn("[Contact41] Contact")]
  public string Contact41 { get; set; }

  [DefaultColumn("[Contact42] Contact")]
  public string Contact42 { get; set; }

  [DefaultColumn("[Contact43] Contact")]
  public string Contact43 { get; set; }

  [DefaultColumn("[Contact45] Contact")]
  public string Contact45 { get; set; }

  [DefaultColumn("[Contact46] Contact")]
  public string Contact46 { get; set; }

  [DefaultColumn("[Contact47] Contact")]
  public string Contact47 { get; set; }

  [DefaultColumn("[Contact48] Contact")]
  public string Contact48 { get; set; }

  [DefaultColumn("[Contact49] Contact")]
  public string Contact49 { get; set; }

  [DefaultColumn("[Contact5] Contact")]
  public string Contact5 { get; set; }

  [DefaultColumn("[Contact50] Contact")]
  public string Contact50 { get; set; }

  [DefaultColumn("[Contact51] Contact")]
  public string Contact51 { get; set; }

  [DefaultColumn("[Contact52] Contact")]
  public string Contact52 { get; set; }

  [DefaultColumn("[Contact53] Contact")]
  public string Contact53 { get; set; }

  [DefaultColumn("[Contact54] Contact")]
  public string Contact54 { get; set; }

  [DefaultColumn("[Contact55] Contact")]
  public string Contact55 { get; set; }

  [DefaultColumn("[Contact6] Contact")]
  public string Contact6 { get; set; }

  [DefaultColumn("[Contact7] Contact")]
  public string Contact7 { get; set; }

  [DefaultColumn("[Contact8] Contact")]
  public string Contact8 { get; set; }

  [DefaultColumn("[Contact9] Contact")]
  public string Contact9 { get; set; }

  [DefaultColumn("[dasfdad] Contact")]
  public string Contact56 { get; set; }

  [DefaultColumn("[date] Date")]
  public DateTime? Date { get; set; }

  [DefaultColumn("[date1] Date")]
  public DateTime? Date1 { get; set; }

  [DefaultColumn("[Date11] Date")]
  public DateTime? Date11 { get; set; }

  [DefaultColumn("[Date12] Date")]
  public DateTime? Date12 { get; set; }

  [DefaultColumn("[Date13] Date")]
  public DateTime? Date13 { get; set; }

  [DefaultColumn("[Date14] Date")]
  public DateTime? Date14 { get; set; }

  [DefaultColumn("[Date15] Date")]
  public DateTime? Date15 { get; set; }

  [DefaultColumn("[Date16] Date")]
  public DateTime? Date16 { get; set; }

  [DefaultColumn("[Date17] Date")]
  public DateTime? Date17 { get; set; }

  [DefaultColumn("[Date18] Date")]
  public DateTime? Date18 { get; set; }

  [DefaultColumn("[Date19] Date")]
  public DateTime? Date19 { get; set; }

  [DefaultColumn("[date2] Date")]
  public DateTime? Date2 { get; set; }

  [DefaultColumn("[Date20] Date")]
  public DateTime? Date20 { get; set; }

  [DefaultColumn("[Date21] Date")]
  public DateTime? Date21 { get; set; }

  [DefaultColumn("[Date23] Date")]
  public DateTime? Date23 { get; set; }

  [DefaultColumn("[Date24] Date")]
  public DateTime? Date24 { get; set; }

  [DefaultColumn("[Date25] Date")]
  public DateTime? Date25 { get; set; }

  [DefaultColumn("[date254] Date")]
  public DateTime? Date254 { get; set; }

  [DefaultColumn("[Date26] Date")]
  public DateTime? Date26 { get; set; }

  [DefaultColumn("[Date27] Date")]
  public DateTime? Date27 { get; set; }

  [DefaultColumn("[Date28] Date")]
  public DateTime? Date28 { get; set; }

  [DefaultColumn("[Date29] Date")]
  public DateTime? Date29 { get; set; }

  [DefaultColumn("[Date30] Date")]
  public DateTime? Date30 { get; set; }

  [DefaultColumn("[Date31] Date")]
  public DateTime? Date31 { get; set; }

  [DefaultColumn("[Date32] Date")]
  public DateTime? Date32 { get; set; }

  [DefaultColumn("[Date33] Date")]
  public DateTime? Date33 { get; set; }

  [DefaultColumn("[Date34] Date")]
  public DateTime? Date34 { get; set; }

  [DefaultColumn("[Date35] Date")]
  public DateTime? Date35 { get; set; }

  [DefaultColumn("[Date36] Date")]
  public DateTime? Date36 { get; set; }

  [DefaultColumn("[Date37] Date")]
  public DateTime? Date37 { get; set; }

  [DefaultColumn("[Date38] Date")]
  public DateTime? Date38 { get; set; }

  [DefaultColumn("[Date39] Date")]
  public DateTime? Date39 { get; set; }

  [DefaultColumn("[Date4] Date")]
  public DateTime? Date4 { get; set; }

  [DefaultColumn("[Date40] Date")]
  public DateTime? Date40 { get; set; }

  [DefaultColumn("[Date41] Date")]
  public DateTime? Date41 { get; set; }

  [DefaultColumn("[Date42] Date")]
  public DateTime? Date42 { get; set; }

  [DefaultColumn("[Date43] Date")]
  public DateTime? Date43 { get; set; }

  [DefaultColumn("[Date44] Date")]
  public DateTime? Date44 { get; set; }

  [DefaultColumn("[Date45] Date")]
  public DateTime? Date45 { get; set; }

  [DefaultColumn("[Date46] Date")]
  public DateTime? Date46 { get; set; }

  [DefaultColumn("[Date47] Date")]
  public DateTime? Date47 { get; set; }

  [DefaultColumn("[Date48] Date")]
  public DateTime? Date48 { get; set; }

  [DefaultColumn("[Date49] Date")]
  public DateTime? Date49 { get; set; }

  [DefaultColumn("[Date5] Date")]
  public DateTime? Date5 { get; set; }

  [DefaultColumn("[Date50] Date")]
  public DateTime? Date50 { get; set; }

  [DefaultColumn("[Date51] Date")]
  public DateTime? Date51 { get; set; }

  [DefaultColumn("[Date52] Date")]
  public DateTime? Date52 { get; set; }

  [DefaultColumn("[Date53] Date")]
  public DateTime? Date53 { get; set; }

  [DefaultColumn("[Date54] Date")]
  public DateTime? Date54 { get; set; }

  [DefaultColumn("[Date6] Date")]
  public DateTime? Date6 { get; set; }

  [DefaultColumn("[Date7] Date")]
  public DateTime? Date7 { get; set; }

  [DefaultColumn("[Date8] Date")]
  public DateTime? Date8 { get; set; }

  [DefaultColumn("[Date9] Date")]
  public DateTime? Date9 { get; set; }

  [DefaultColumn("[date99] Date")]
  public DateTime? Date99 { get; set; }

  [DefaultColumn("[DateReqCancl] Date cancellation requested")]
  public DateTime? DateReqCancl { get; set; }

  [DefaultColumn("[datte88] Date")]
  public DateTime? Datte88 { get; set; }

  [DefaultColumn("[DescAddlStr] Describe additional structures")]
  public string DescAddlStr { get; set; }

  [DefaultColumn("[Describetypeofprotectionobserved] Describe type of protection observed")]
  public string TypeofProtectionObserved { get; set; }

  [DefaultColumn("[DivBoardYN] Diving board or water slide present")]
  public string DivingBoard { get; set; }

  [DefaultColumn("[DmgBldg] Damage noted to exterior of building")]
  public string DmgBldg { get; set; }

  [DefaultColumn("[DogsAnimDesc] Describe dogs/animals present")]
  public string DogsAnimalDesc { get; set; }

  [DefaultColumn("[DogsYN] Dogs/animals present")]
  public string DogsAnimals { get; set; }

  [DefaultColumn("[EstAgeRf] Estimated age of roof")]
  public int? EstAgeRf { get; set; }

  [DefaultColumn("[EstArea] Estimated area of risk (in SF)")]
  public int? EstArea { get; set; }

  [DefaultColumn("[EstimatedRoofLife] Roof System estimated remaining life (Years)")]
  public string EstimatedRoofLife { get; set; }

  [DefaultColumn("[FoundType] Foundation")]
  public string FoundType { get; set; }

  [DefaultColumn("[GatedYN] Gated community")]
  public string Gated { get; set; }

  [DefaultColumn("[HasSketch] Has Sketch:")]
  public string HasSketch { get; set; }

  [DefaultColumn("[HazComm] Hazards and conditions comments and add applicable freeform recs")]
  public string HazardsComments { get; set; }

  [DefaultColumn("[HomeManu] Is risk a manufactured or mobile home?")]
  public string HomeManufacturedOrMobile { get; set; }

  [DefaultColumn("[HouseYN] Exterior housekeeping satisfactory")]
  public string ExteriorHouseSatisfactory { get; set; }

  [DefaultColumn("[HurrStr] Visible indication of hurricane straps")]
  public string HurricaneStraps { get; set; }

  [DefaultColumn("[inspectorname] Name of Inspector")]
  public string InspectorName { get; set; }

  [DefaultColumn("[NeighType] Neighborhood type")]
  public string NeighborhoodType { get; set; }

  [DefaultColumn("[Notes1] Notes")]
  public string Notes1 { get; set; }

  [DefaultColumn("[Notes10] Notes")]
  public string Notes10 { get; set; }

  [DefaultColumn("[Notes11] Notes")]
  public string Notes11 { get; set; }

  [DefaultColumn("[Notes12] Notes")]
  public string Notes12 { get; set; }

  [DefaultColumn("[Notes13] Notes")]
  public string Notes13 { get; set; }

  [DefaultColumn("[Notes14] Notes")]
  public string Notes14 { get; set; }

  [DefaultColumn("[Notes15] Notes")]
  public string Notes15 { get; set; }

  [DefaultColumn("[Notes16] Notes")]
  public string Notes16 { get; set; }

  [DefaultColumn("[Notes17] Notes")]
  public string Notes17 { get; set; }

  [DefaultColumn("[Notes18] Notes")]
  public string Notes18 { get; set; }

  [DefaultColumn("[Notes19] Notes")]
  public string Notes19 { get; set; }

  [DefaultColumn("[Notes2] Notes")]
  public string Notes2 { get; set; }

  [DefaultColumn("[Notes20] Notes")]
  public string Notes20 { get; set; }

  [DefaultColumn("[Notes21] Notes")]
  public string Notes21 { get; set; }

  [DefaultColumn("[Notes22] Notes")]
  public string Notes22 { get; set; }

  [DefaultColumn("[Notes23] Notes")]
  public string Notes23 { get; set; }

  [DefaultColumn("[Notes24] Notes")]
  public string Notes24 { get; set; }

  [DefaultColumn("[Notes25] Notes")]
  public string Notes25 { get; set; }

  [DefaultColumn("[Notes26] Notes")]
  public string Notes26 { get; set; }

  [DefaultColumn("[Notes27] Notes")]
  public string Notes27 { get; set; }

  [DefaultColumn("[Notes28] Notes")]
  public string Notes28 { get; set; }

  [DefaultColumn("[Notes29] Notes")]
  public string Notes29 { get; set; }

  [DefaultColumn("[Notes3] Notes")]
  public string Notes3 { get; set; }

  [DefaultColumn("[Notes30] Notes")]
  public string Notes30 { get; set; }

  [DefaultColumn("[Notes31] Notes")]
  public string Notes31 { get; set; }

  [DefaultColumn("[Notes32] Notes")]
  public string Notes32 { get; set; }

  [DefaultColumn("[Notes34] Notes")]
  public string Notes34 { get; set; }

  [DefaultColumn("[Notes35] Notes")]
  public string Notes35 { get; set; }

  [DefaultColumn("[Notes36] Notes")]
  public string Notes36 { get; set; }

  [DefaultColumn("[Notes37] Notes")]
  public string Notes37 { get; set; }

  [DefaultColumn("[Notes39] Notes")]
  public string Notes39 { get; set; }

  [DefaultColumn("[Notes4] Notes")]
  public string Notes4 { get; set; }

  [DefaultColumn("[Notes40] Notes")]
  public string Notes40 { get; set; }

  [DefaultColumn("[Notes41] Notes")]
  public string Notes41 { get; set; }

  [DefaultColumn("[Notes43] Notes")]
  public string Notes43 { get; set; }

  [DefaultColumn("[Notes44] Notes")]
  public string Notes44 { get; set; }

  [DefaultColumn("[Notes45] Notes")]
  public string Notes45 { get; set; }

  [DefaultColumn("[Notes46] Notes")]
  public string Notes46 { get; set; }

  [DefaultColumn("[Notes47] Notes")]
  public string Notes47 { get; set; }

  [DefaultColumn("[Notes48] Notes")]
  public string Notes48 { get; set; }

  [DefaultColumn("[Notes49] Notes")]
  public string Notes49 { get; set; }

  [DefaultColumn("[Notes5] Notes")]
  public string Notes5 { get; set; }

  [DefaultColumn("[Notes50] Notes")]
  public string Notes50 { get; set; }

  [DefaultColumn("[Notes51] Notes")]
  public string Notes51 { get; set; }

  [DefaultColumn("[Notes52] Notes")]
  public string Notes52 { get; set; }

  [DefaultColumn("[Notes53] Notes")]
  public string Notes53 { get; set; }

  [DefaultColumn("[Notes55] Notes")]
  public string Notes55 { get; set; }

  [DefaultColumn("[notes555] Notes")]
  public string Notes555 { get; set; }

  [DefaultColumn("[Notes58] Notes")]
  public string Notes58 { get; set; }

  [DefaultColumn("[notes5884] Notes")]
  public string Notes5884 { get; set; }

  [DefaultColumn("[Notes6] Notes")]
  public string Notes6 { get; set; }

  [DefaultColumn("[Notes7] Notes")]
  public string Notes7 { get; set; }

  [DefaultColumn("[Notes8] Notes")]
  public string Notes8 { get; set; }

  [DefaultColumn("[notes84848] Notes")]
  public string Notes84848 { get; set; }

  [DefaultColumn("[Notes9] Notes")]
  public string Notes9 { get; set; }

  [DefaultColumn("[num] Number of Contact Attempts")]
  public int? NumContactAttempts { get; set; }

  [DefaultColumn("[NumStor] Number of stories")]
  public int? NumStories { get; set; }

  [DefaultColumn("[ObsDmg] Describe observed damage and add freeform recommendation")]
  public string ObservedDamage { get; set; }

  [DefaultColumn("[OpnJust] Opinion justification")]
  public string OpinionJustification { get; set; }

  [DefaultColumn("[OthComm] Describe other")]
  public string Other { get; set; }

  [DefaultColumn("[OthExpl] Explain other")]
  public string OtherExplain { get; set; }

  [DefaultColumn("[OthRoof] Describe other roof")]
  public string OtherRoof { get; set; }

  [DefaultColumn("[OutDesc] Type of additional structures")]
  public string AdditionalStructures { get; set; }

  [DefaultColumn("[OveallAppr] Overall appearance")]
  public string OverallAppearance { get; set; }

  [DefaultColumn("[PercentArchitecturalShingles] Percent Architectural Shingles")]
  public int? PercentArchitecturalShingles { get; set; }

  [DefaultColumn("[PercentBuildupRoofNoGravel] Percent Build-up Roof (No Gravel)")]
  public int? PercentBuildupRoofNoGravel { get; set; }

  [DefaultColumn("[PercentClayConcreteTiles] Percent Clay-Concrete Tiles")]
  public int? PercentClayConcreteTiles { get; set; }

  [DefaultColumn("[PercentFlat] Percent Flat")]
  public int? PercentFlat { get; set; }

  [DefaultColumn("[PercentGable] Percent Gable")]
  public int? PercentGable { get; set; }

  [DefaultColumn("[PercentHip] Percent Hip")]
  public int? PercentHip { get; set; }

  [DefaultColumn("[PercentLightMetalPanels] Percent Light Metal Panels")]
  public int? PercentLightMetalPanels { get; set; }

  [DefaultColumn("[PercentSinglePlyMembrane] Percent Single Ply Membrane")]
  public int? PercentSinglePlyMembrane { get; set; }

  [DefaultColumn("[PercentSinglePlyMembraneBallasted] Percent Single Ply Membrane Ballasted")]
  public int? PercentSinglePlyMembraneBallasted { get; set; }

  [DefaultColumn("[PercentSlate] Percent Slate")]
  public int? PercentSlate { get; set; }

  [DefaultColumn("[PercentStandingSeamMetalRoof] Percent Standing Seam Metal Roof")]
  public int? PercentStandingSeamMetalRoof { get; set; }

  [DefaultColumn("[PercentThreeTab] Percent Three Tab")]
  public int? PercentThreeTab { get; set; }

  [DefaultColumn("[PercentWoodenShingles] Percent Wooden Shingles")]
  public int? PercentWoodenShingles { get; set; }

  [DefaultColumn("[Poolcage] Pool cage or screened enclosure present")]
  public string PoolCageScreened { get; set; }

  [DefaultColumn("[PoolFenced] Pool perimeter fully fenced or enclosed and self locking gate present")]
  public string PoolFenced { get; set; }

  [DefaultColumn("[PoolYN] Swimming pool present")]
  public string Pool { get; set; }

  [DefaultColumn("[reason] Explain reason for closeout")]
  public string CloseoutReason { get; set; }

  [DefaultColumn("[reasonforcancellation] Reason for Cancellation:")]
  public string CancellationReason { get; set; }

  [DefaultColumn("[ReqMeth] Method of request")]
  public string RequestMethod { get; set; }

  [DefaultColumn("[RiskComm] Brief description of risk")]
  public string RiskComments { get; set; }

  [DefaultColumn("[RoofAdeq] Roof system condition")]
  public string RoofSystemCondition { get; set; }

  [DefaultColumn("[RoofComm] Roof comments")]
  public string RoofComments { get; set; }

  [DefaultColumn("[Roofcover] Roof covering")]
  public string RoofCovering { get; set; }

  [DefaultColumn(true)]
  public string RoofGeometry { get; set; }

  [DefaultColumn("[RskOpn] Opinion of risk")]
  public string RiskOpinion { get; set; }

  [DefaultColumn("[ShuttYN] Functional window shutters present")]
  public string Shutters { get; set; }

  [DefaultColumn("[SpecInstComm] Special instructions and responses")]
  public string SpecialInstructionComments { get; set; }

  [DefaultColumn("[SpecInstYN] Special instructions")]
  public string SpecialInstructions { get; set; }

  [DefaultColumn("[surve] Survey Date")]
  public DateTime? SurveyDate { get; set; }

  [DefaultColumn("[tiem5] Time")]
  public string Time5 { get; set; }

  [DefaultColumn("[time] Time")]
  public string Time { get; set; }

  [DefaultColumn("[time1] Time")]
  public string Time1 { get; set; }

  [DefaultColumn("[time10] Time")]
  public string Time10 { get; set; }

  [DefaultColumn("[time11] Time")]
  public string Time11 { get; set; }

  [DefaultColumn("[time12] Time")]
  public string Time12 { get; set; }

  [DefaultColumn("[time13] Time")]
  public string Time13 { get; set; }

  [DefaultColumn("[time14] Time")]
  public string Time14 { get; set; }

  [DefaultColumn("[time15] Time")]
  public string Time15 { get; set; }

  [DefaultColumn("[time16] Time")]
  public string Time16 { get; set; }

  [DefaultColumn("[time17] Time")]
  public string Time17 { get; set; }

  [DefaultColumn("[time18] Time")]
  public string Time18 { get; set; }

  [DefaultColumn("[time19] Time")]
  public string Time19 { get; set; }

  [DefaultColumn("[time2] Time")]
  public string Time2 { get; set; }

  [DefaultColumn("[time20] Time")]
  public string Time20 { get; set; }

  [DefaultColumn("[time21] Time")]
  public string Time21 { get; set; }

  [DefaultColumn("[time22] Time")]
  public string Time22 { get; set; }

  [DefaultColumn("[Time23] Time")]
  public string Time23 { get; set; }

  [DefaultColumn("[Time24] Time")]
  public string Time24 { get; set; }

  [DefaultColumn("[Time25] Time")]
  public string Time25 { get; set; }

  [DefaultColumn("[Time26] Time")]
  public string Time26 { get; set; }

  [DefaultColumn("[Time27] Time")]
  public string Time27 { get; set; }

  [DefaultColumn("[Time28] Time")]
  public string Time28 { get; set; }

  [DefaultColumn("[Time29] Time")]
  public string Time29 { get; set; }

  [DefaultColumn("[time3] Time")]
  public string Time3 { get; set; }

  [DefaultColumn("[Time30] Time")]
  public string Time30 { get; set; }

  [DefaultColumn("[Time31] Time")]
  public string Time31 { get; set; }

  [DefaultColumn("[Time34] Time")]
  public string Time34 { get; set; }

  [DefaultColumn("[Time35] Time")]
  public string Time35 { get; set; }

  [DefaultColumn("[Time36] Time")]
  public string Time36 { get; set; }

  [DefaultColumn("[Time37] Time")]
  public string Time37 { get; set; }

  [DefaultColumn("[Time38] Time")]
  public string Time38 { get; set; }

  [DefaultColumn("[Time39] Time")]
  public string Time39 { get; set; }

  [DefaultColumn("[time4] Time")]
  public string Time4 { get; set; }

  [DefaultColumn("[Time40] Time")]
  public string Time40 { get; set; }

  [DefaultColumn("[Time41] Time")]
  public string Time41 { get; set; }

  [DefaultColumn("[Time42] Time")]
  public string Time42 { get; set; }

  [DefaultColumn("[Time43] Time")]
  public string Time43 { get; set; }

  [DefaultColumn("[Time44] Time")]
  public string Time44 { get; set; }

  [DefaultColumn("[Time45] Time")]
  public string Time45 { get; set; }

  [DefaultColumn("[Time46] Time")]
  public string Time46 { get; set; }

  [DefaultColumn("[Time47] Time")]
  public string Time47 { get; set; }

  [DefaultColumn("[Time49] Time")]
  public string Time49 { get; set; }

  [DefaultColumn("[Time5] Time")]
  public string Time80 { get; set; }

  [DefaultColumn("[Time50] Time")]
  public string Time50 { get; set; }

  [DefaultColumn("[Time51] Time")]
  public string Time51 { get; set; }

  [DefaultColumn("[Time52] Time")]
  public string Time52 { get; set; }

  [DefaultColumn("[Time53] Time")]
  public string Time53 { get; set; }

  [DefaultColumn("[Time54] Time")]
  public string Time54 { get; set; }

  [DefaultColumn("[time60] Time")]
  public string Time60 { get; set; }

  [DefaultColumn("[time7] Time")]
  public string Time7 { get; set; }

  [DefaultColumn("[time70] Time")]
  public string Time70 { get; set; }

  [DefaultColumn("[time8] Time")]
  public string Time8 { get; set; }

  [DefaultColumn("[time9] Time")]
  public string Time9 { get; set; }

  [DefaultColumn("[time90] Time")]
  public string Time90 { get; set; }

  [DefaultColumn("[TotalArea] Total Area:")]
  public Decimal? TotalArea { get; set; }

  [DefaultColumn("[Type] Building type")]
  public string BuildingType { get; set; }

  [DefaultColumn("[VisibleIndicationsofHurricane] Visible indications of hurricane/windstorm protection?")]
  public string VisibleIndicationsofHurricane { get; set; }

  [DefaultColumn("[histyn] Risk is a designated historic property/structure")]
  public string DesignatedHistoricProperty { get; set; }

  public static List<string> GetColumns()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TOP 1 * FROM tblInspectionInformation");
    return dataTable != null ? dataTable.Columns.Cast<DataColumn>().Where<DataColumn>((System.Func<DataColumn, bool>) (i => i.ColumnName != "InspectionInfoID" && i.ColumnName != "ControlNo")).Select<DataColumn, string>((System.Func<DataColumn, string>) (x => x.ColumnName)).ToList<string>() : (List<string>) null;
  }

  public void UpdateInspectionInformation(
    int controlNo,
    Worksheet worksheet,
    Row worksheetRow,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping,
    SpreadsheetInfo spreadsheetInfo)
  {
    this.InvalidData = new List<string>();
    this.ControlNo = controlNo;
    this.SetMappedValues(worksheet, worksheetRow, columnMapping, spreadsheetInfo);
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spInspectionInformationUpdate", new object[606]
    {
      (object) "@InspectionInfoID",
      (object) 0,
      (object) "@ControlNo",
      (object) this.ControlNo,
      (object) "@CaseNumber",
      (object) this.CaseNumber,
      (object) "@Customer",
      (object) this.Customer,
      (object) "@CaseType",
      (object) this.CaseType,
      (object) "@InsuredName",
      (object) this.InsuredName,
      (object) "@Address1",
      (object) this.Address1,
      (object) "@Address2",
      (object) this.Address2,
      (object) "@City",
      (object) this.City,
      (object) "@State",
      (object) this.State,
      (object) "@Zip",
      (object) this.Zip,
      (object) "@CompletionDate",
      (object) this.CompletionDate,
      (object) "@EffectiveDate",
      (object) this.EffectiveDate,
      (object) "@AddlStructures",
      (object) this.AddlStructures,
      (object) "@AgeEst",
      (object) this.AgeEst,
      (object) "@HazardsPresent",
      (object) this.HazardsPresent,
      (object) "@AreaEconomy",
      (object) this.AreaEconomy,
      (object) "@NuisancesPresent",
      (object) this.NuisancesPresent,
      (object) "@BldgComments",
      (object) this.BldgComments,
      (object) "@BldgTypeOther",
      (object) this.BldgTypeOther,
      (object) "@CancellationReqBy",
      (object) this.CancellationReqBy,
      (object) "@Contact",
      (object) this.Contact,
      (object) "@ConstructionClass",
      (object) this.ConstructionClass,
      (object) "@Contact1",
      (object) this.Contact1,
      (object) "@Contact10",
      (object) this.Contact10,
      (object) "@Contact11",
      (object) this.Contact11,
      (object) "@Contact12",
      (object) this.Contact12,
      (object) "@Contact13",
      (object) this.Contact13,
      (object) "@Contact14",
      (object) this.Contact14,
      (object) "@Contact15",
      (object) this.Contact15,
      (object) "@Contact16",
      (object) this.Contact16,
      (object) "@Contact17",
      (object) this.Contact17,
      (object) "@Contact18",
      (object) this.Contact18,
      (object) "@Contact19",
      (object) this.Contact19,
      (object) "@Contact2",
      (object) this.Contact2,
      (object) "@Contact20",
      (object) this.Contact20,
      (object) "@Contact21",
      (object) this.Contact21,
      (object) "@Contact22",
      (object) this.Contact22,
      (object) "@Contact23",
      (object) this.Contact23,
      (object) "@Contact24",
      (object) this.Contact24,
      (object) "@Contact25",
      (object) this.Contact25,
      (object) "@Contact26",
      (object) this.Contact26,
      (object) "@Contact27",
      (object) this.Contact27,
      (object) "@Contact28",
      (object) this.Contact28,
      (object) "@Contact29",
      (object) this.Contact29,
      (object) "@Contact3",
      (object) this.Contact3,
      (object) "@Contact30",
      (object) this.Contact30,
      (object) "@Contact311",
      (object) this.Contact311,
      (object) "@Contact32",
      (object) this.Contact32,
      (object) "@Contact33",
      (object) this.Contact33,
      (object) "@Contact35",
      (object) this.Contact35,
      (object) "@Contact36",
      (object) this.Contact36,
      (object) "@Contact37",
      (object) this.Contact37,
      (object) "@Contact38",
      (object) this.Contact38,
      (object) "@Contact39",
      (object) this.Contact39,
      (object) "@Contact4",
      (object) this.Contact4,
      (object) "@Contact40",
      (object) this.Contact40,
      (object) "@Contact41",
      (object) this.Contact41,
      (object) "@Contact42",
      (object) this.Contact42,
      (object) "@Contact43",
      (object) this.Contact43,
      (object) "@Contact45",
      (object) this.Contact45,
      (object) "@Contact46",
      (object) this.Contact46,
      (object) "@Contact47",
      (object) this.Contact47,
      (object) "@Contact48",
      (object) this.Contact48,
      (object) "@Contact49",
      (object) this.Contact49,
      (object) "@Contact5",
      (object) this.Contact5,
      (object) "@Contact50",
      (object) this.Contact50,
      (object) "@Contact51",
      (object) this.Contact51,
      (object) "@Contact52",
      (object) this.Contact52,
      (object) "@Contact53",
      (object) this.Contact53,
      (object) "@Contact54",
      (object) this.Contact54,
      (object) "@Contact55",
      (object) this.Contact55,
      (object) "@Contact6",
      (object) this.Contact6,
      (object) "@Contact7",
      (object) this.Contact7,
      (object) "@Contact8",
      (object) this.Contact8,
      (object) "@Contact9",
      (object) this.Contact9,
      (object) "@Contact56",
      (object) this.Contact56,
      (object) "@Date",
      (object) this.Date,
      (object) "@Date1",
      (object) this.Date1,
      (object) "@Date11",
      (object) this.Date11,
      (object) "@Date12",
      (object) this.Date12,
      (object) "@Date13",
      (object) this.Date13,
      (object) "@Date14",
      (object) this.Date14,
      (object) "@Date15",
      (object) this.Date15,
      (object) "@Date16",
      (object) this.Date16,
      (object) "@Date17",
      (object) this.Date17,
      (object) "@Date18",
      (object) this.Date18,
      (object) "@Date19",
      (object) this.Date19,
      (object) "@Date2",
      (object) this.Date2,
      (object) "@Date20",
      (object) this.Date20,
      (object) "@Date21",
      (object) this.Date21,
      (object) "@Date23",
      (object) this.Date23,
      (object) "@Date24",
      (object) this.Date24,
      (object) "@Date25",
      (object) this.Date25,
      (object) "@Date254",
      (object) this.Date254,
      (object) "@Date26",
      (object) this.Date26,
      (object) "@Date27",
      (object) this.Date27,
      (object) "@Date28",
      (object) this.Date28,
      (object) "@Date29",
      (object) this.Date29,
      (object) "@Date30",
      (object) this.Date30,
      (object) "@Date31",
      (object) this.Date31,
      (object) "@Date32",
      (object) this.Date32,
      (object) "@Date33",
      (object) this.Date33,
      (object) "@Date34",
      (object) this.Date34,
      (object) "@Date35",
      (object) this.Date35,
      (object) "@Date36",
      (object) this.Date36,
      (object) "@Date37",
      (object) this.Date37,
      (object) "@Date38",
      (object) this.Date38,
      (object) "@Date39",
      (object) this.Date39,
      (object) "@Date4",
      (object) this.Date4,
      (object) "@Date40",
      (object) this.Date40,
      (object) "@Date41",
      (object) this.Date41,
      (object) "@Date42",
      (object) this.Date42,
      (object) "@Date43",
      (object) this.Date43,
      (object) "@Date44",
      (object) this.Date44,
      (object) "@Date45",
      (object) this.Date45,
      (object) "@Date46",
      (object) this.Date46,
      (object) "@Date47",
      (object) this.Date47,
      (object) "@Date48",
      (object) this.Date48,
      (object) "@Date49",
      (object) this.Date49,
      (object) "@Date5",
      (object) this.Date5,
      (object) "@Date50",
      (object) this.Date50,
      (object) "@Date51",
      (object) this.Date51,
      (object) "@Date52",
      (object) this.Date52,
      (object) "@Date53",
      (object) this.Date53,
      (object) "@Date54",
      (object) this.Date54,
      (object) "@Date6",
      (object) this.Date6,
      (object) "@Date7",
      (object) this.Date7,
      (object) "@Date8",
      (object) this.Date8,
      (object) "@Date9",
      (object) this.Date9,
      (object) "@Date99",
      (object) this.Date99,
      (object) "@DateReqCancl",
      (object) this.DateReqCancl,
      (object) "@Datte88",
      (object) this.Datte88,
      (object) "@DescAddlStr",
      (object) this.DescAddlStr,
      (object) "@TypeofProtectionObserved",
      (object) this.TypeofProtectionObserved,
      (object) "@DivingBoard",
      (object) this.DivingBoard,
      (object) "@DmgBldg",
      (object) this.DmgBldg,
      (object) "@DogsAnimalDesc",
      (object) this.DogsAnimalDesc,
      (object) "@DogsAnimals",
      (object) this.DogsAnimals,
      (object) "@EstAgeRf",
      (object) this.EstAgeRf,
      (object) "@EstArea",
      (object) this.EstArea,
      (object) "@EstimatedRoofLife",
      (object) this.EstimatedRoofLife,
      (object) "@FoundType",
      (object) this.FoundType,
      (object) "@Gated",
      (object) this.Gated,
      (object) "@HasSketch",
      (object) this.HasSketch,
      (object) "@HazardsComments",
      (object) this.HazardsComments,
      (object) "@HomeManufacturedOrMobile",
      (object) this.HomeManufacturedOrMobile,
      (object) "@ExteriorHouseSatisfactory",
      (object) this.ExteriorHouseSatisfactory,
      (object) "@HurricaneStraps",
      (object) this.HurricaneStraps,
      (object) "@InspectorName",
      (object) this.InspectorName,
      (object) "@NeighborhoodType",
      (object) this.NeighborhoodType,
      (object) "@Notes1",
      (object) this.Notes1,
      (object) "@Notes10",
      (object) this.Notes10,
      (object) "@Notes11",
      (object) this.Notes11,
      (object) "@Notes12",
      (object) this.Notes12,
      (object) "@Notes13",
      (object) this.Notes13,
      (object) "@Notes14",
      (object) this.Notes14,
      (object) "@Notes15",
      (object) this.Notes15,
      (object) "@Notes16",
      (object) this.Notes16,
      (object) "@Notes17",
      (object) this.Notes17,
      (object) "@Notes18",
      (object) this.Notes18,
      (object) "@Notes19",
      (object) this.Notes19,
      (object) "@Notes2",
      (object) this.Notes2,
      (object) "@Notes20",
      (object) this.Notes20,
      (object) "@Notes21",
      (object) this.Notes21,
      (object) "@Notes22",
      (object) this.Notes22,
      (object) "@Notes23",
      (object) this.Notes23,
      (object) "@Notes24",
      (object) this.Notes24,
      (object) "@Notes25",
      (object) this.Notes25,
      (object) "@Notes26",
      (object) this.Notes26,
      (object) "@Notes27",
      (object) this.Notes27,
      (object) "@Notes28",
      (object) this.Notes28,
      (object) "@Notes29",
      (object) this.Notes29,
      (object) "@Notes3",
      (object) this.Notes3,
      (object) "@Notes30",
      (object) this.Notes30,
      (object) "@Notes31",
      (object) this.Notes31,
      (object) "@Notes32",
      (object) this.Notes32,
      (object) "@Notes34",
      (object) this.Notes34,
      (object) "@Notes35",
      (object) this.Notes35,
      (object) "@Notes36",
      (object) this.Notes36,
      (object) "@Notes37",
      (object) this.Notes37,
      (object) "@Notes39",
      (object) this.Notes39,
      (object) "@Notes4",
      (object) this.Notes4,
      (object) "@Notes40",
      (object) this.Notes40,
      (object) "@Notes41",
      (object) this.Notes41,
      (object) "@Notes43",
      (object) this.Notes43,
      (object) "@Notes44",
      (object) this.Notes44,
      (object) "@Notes45",
      (object) this.Notes45,
      (object) "@Notes46",
      (object) this.Notes46,
      (object) "@Notes47",
      (object) this.Notes47,
      (object) "@Notes48",
      (object) this.Notes48,
      (object) "@Notes49",
      (object) this.Notes49,
      (object) "@Notes5",
      (object) this.Notes5,
      (object) "@Notes50",
      (object) this.Notes50,
      (object) "@Notes51",
      (object) this.Notes51,
      (object) "@Notes52",
      (object) this.Notes52,
      (object) "@Notes53",
      (object) this.Notes53,
      (object) "@Notes55",
      (object) this.Notes55,
      (object) "@Notes555",
      (object) this.Notes555,
      (object) "@Notes58",
      (object) this.Notes58,
      (object) "@Notes5884",
      (object) this.Notes5884,
      (object) "@Notes6",
      (object) this.Notes6,
      (object) "@Notes7",
      (object) this.Notes7,
      (object) "@Notes8",
      (object) this.Notes8,
      (object) "@Notes84848",
      (object) this.Notes84848,
      (object) "@Notes9",
      (object) this.Notes9,
      (object) "@NumContactAttempts",
      (object) this.NumContactAttempts,
      (object) "@NumStories",
      (object) this.NumStories,
      (object) "@ObservedDamage",
      (object) this.ObservedDamage,
      (object) "@OpinionJustification",
      (object) this.OpinionJustification,
      (object) "@Other",
      (object) this.Other,
      (object) "@OtherExplain",
      (object) this.OtherExplain,
      (object) "@OtherRoof",
      (object) this.OtherRoof,
      (object) "@AdditionalStructures",
      (object) this.AdditionalStructures,
      (object) "@OverallAppearance",
      (object) this.OverallAppearance,
      (object) "@PercentArchitecturalShingles",
      (object) this.PercentArchitecturalShingles,
      (object) "@PercentBuildupRoofNoGravel",
      (object) this.PercentBuildupRoofNoGravel,
      (object) "@PercentClayConcreteTiles",
      (object) this.PercentClayConcreteTiles,
      (object) "@PercentFlat",
      (object) this.PercentFlat,
      (object) "@PercentGable",
      (object) this.PercentGable,
      (object) "@PercentHip",
      (object) this.PercentHip,
      (object) "@PercentLightMetalPanels",
      (object) this.PercentLightMetalPanels,
      (object) "@PercentSinglePlyMembrane",
      (object) this.PercentSinglePlyMembrane,
      (object) "@PercentSinglePlyMembraneBallasted",
      (object) this.PercentSinglePlyMembraneBallasted,
      (object) "@PercentSlate",
      (object) this.PercentSlate,
      (object) "@PercentStandingSeamMetalRoof",
      (object) this.PercentStandingSeamMetalRoof,
      (object) "@PercentThreeTab",
      (object) this.PercentThreeTab,
      (object) "@PercentWoodenShingles",
      (object) this.PercentWoodenShingles,
      (object) "@PoolCageScreened",
      (object) this.PoolCageScreened,
      (object) "@PoolFenced",
      (object) this.PoolFenced,
      (object) "@Pool",
      (object) this.Pool,
      (object) "@CloseoutReason",
      (object) this.CloseoutReason,
      (object) "@CancellationReason",
      (object) this.CancellationReason,
      (object) "@RequestMethod",
      (object) this.RequestMethod,
      (object) "@RiskComments",
      (object) this.RiskComments,
      (object) "@RoofSystemCondition",
      (object) this.RoofSystemCondition,
      (object) "@RoofComments",
      (object) this.RoofComments,
      (object) "@RoofCovering",
      (object) this.RoofCovering,
      (object) "@RoofGeometry",
      (object) this.RoofGeometry,
      (object) "@RiskOpinion",
      (object) this.RiskOpinion,
      (object) "@Shutters",
      (object) this.Shutters,
      (object) "@SpecialInstructionComments",
      (object) this.SpecialInstructionComments,
      (object) "@SpecialInstructions",
      (object) this.SpecialInstructions,
      (object) "@SurveyDate",
      (object) this.SurveyDate,
      (object) "@Time5",
      (object) this.Time5,
      (object) "@Time",
      (object) this.Time,
      (object) "@Time1",
      (object) this.Time1,
      (object) "@Time10",
      (object) this.Time10,
      (object) "@Time11",
      (object) this.Time11,
      (object) "@Time12",
      (object) this.Time12,
      (object) "@Time13",
      (object) this.Time13,
      (object) "@Time14",
      (object) this.Time14,
      (object) "@Time15",
      (object) this.Time15,
      (object) "@Time16",
      (object) this.Time16,
      (object) "@Time17",
      (object) this.Time17,
      (object) "@Time18",
      (object) this.Time18,
      (object) "@Time19",
      (object) this.Time19,
      (object) "@Time2",
      (object) this.Time2,
      (object) "@Time20",
      (object) this.Time20,
      (object) "@Time21",
      (object) this.Time21,
      (object) "@Time22",
      (object) this.Time22,
      (object) "@Time23",
      (object) this.Time23,
      (object) "@Time24",
      (object) this.Time24,
      (object) "@Time25",
      (object) this.Time25,
      (object) "@Time26",
      (object) this.Time26,
      (object) "@Time27",
      (object) this.Time27,
      (object) "@Time28",
      (object) this.Time28,
      (object) "@Time29",
      (object) this.Time29,
      (object) "@Time3",
      (object) this.Time3,
      (object) "@Time30",
      (object) this.Time30,
      (object) "@Time31",
      (object) this.Time31,
      (object) "@Time34",
      (object) this.Time34,
      (object) "@Time35",
      (object) this.Time35,
      (object) "@Time36",
      (object) this.Time36,
      (object) "@Time37",
      (object) this.Time37,
      (object) "@Time38",
      (object) this.Time38,
      (object) "@Time39",
      (object) this.Time39,
      (object) "@Time4",
      (object) this.Time4,
      (object) "@Time40",
      (object) this.Time40,
      (object) "@Time41",
      (object) this.Time41,
      (object) "@Time42",
      (object) this.Time42,
      (object) "@Time43",
      (object) this.Time43,
      (object) "@Time44",
      (object) this.Time44,
      (object) "@Time45",
      (object) this.Time45,
      (object) "@Time46",
      (object) this.Time46,
      (object) "@Time47",
      (object) this.Time47,
      (object) "@Time49",
      (object) this.Time49,
      (object) "@Time80",
      (object) this.Time80,
      (object) "@Time50",
      (object) this.Time50,
      (object) "@Time51",
      (object) this.Time51,
      (object) "@Time52",
      (object) this.Time52,
      (object) "@Time53",
      (object) this.Time53,
      (object) "@Time54",
      (object) this.Time54,
      (object) "@Time60",
      (object) this.Time60,
      (object) "@Time7",
      (object) this.Time7,
      (object) "@Time70",
      (object) this.Time70,
      (object) "@Time8",
      (object) this.Time8,
      (object) "@Time9",
      (object) this.Time9,
      (object) "@Time90",
      (object) this.Time90,
      (object) "@TotalArea",
      (object) this.TotalArea,
      (object) "@BuildingType",
      (object) this.BuildingType,
      (object) "@VisibleIndicationsofHurricane",
      (object) this.VisibleIndicationsofHurricane,
      (object) "@DesignatedHistoricProperty",
      (object) this.DesignatedHistoricProperty
    });
  }

  private void SetMappedValues(
    Worksheet worksheet,
    Row worksheetRow,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping,
    SpreadsheetInfo spreadsheetInfo)
  {
    this.CaseNumber = this.GetMappedValueString("CaseNumber", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Customer = this.GetMappedValueString("Customer", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.CaseType = this.GetMappedValueString("CaseType", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.InsuredName = this.GetMappedValueString("InsuredName", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Address1 = this.GetMappedValueString("Address1", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Address2 = this.GetMappedValueString("Address2", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.City = this.GetMappedValueString("City", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.State = this.GetMappedValueString("State", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Zip = this.GetMappedValueString("Zip", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.CompletionDate = this.GetMappedValueDateTime("CompletionDate", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.EffectiveDate = this.GetMappedValueDateTime("EffectiveDate", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.AddlStructures = this.GetMappedValueString("AddlStructures", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.AgeEst = this.GetMappedValueInt("AgeEst", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.HazardsPresent = this.GetMappedValueString("HazardsPresent", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.AreaEconomy = this.GetMappedValueString("AreaEconomy", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.NuisancesPresent = this.GetMappedValueString("NuisancesPresent", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.BldgComments = this.GetMappedValueString("BldgComments", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.BldgTypeOther = this.GetMappedValueString("BldgTypeOther", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.CancellationReqBy = this.GetMappedValueString("CancellationReqBy", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact = this.GetMappedValueString("Contact", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.ConstructionClass = this.GetMappedValueString("ConstructionClass", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact1 = this.GetMappedValueString("Contact1", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact10 = this.GetMappedValueString("Contact10", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact11 = this.GetMappedValueString("Contact11", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact12 = this.GetMappedValueString("Contact12", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact13 = this.GetMappedValueString("Contact13", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact14 = this.GetMappedValueString("Contact14", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact15 = this.GetMappedValueString("Contact15", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact16 = this.GetMappedValueString("Contact16", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact17 = this.GetMappedValueString("Contact17", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact18 = this.GetMappedValueString("Contact18", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact19 = this.GetMappedValueString("Contact19", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact2 = this.GetMappedValueString("Contact2", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact20 = this.GetMappedValueString("Contact20", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact21 = this.GetMappedValueString("Contact21", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact22 = this.GetMappedValueString("Contact22", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact23 = this.GetMappedValueString("Contact23", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact24 = this.GetMappedValueString("Contact24", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact25 = this.GetMappedValueString("Contact25", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact26 = this.GetMappedValueString("Contact26", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact27 = this.GetMappedValueString("Contact27", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact28 = this.GetMappedValueString("Contact28", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact29 = this.GetMappedValueString("Contact29", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact3 = this.GetMappedValueString("Contact3", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact30 = this.GetMappedValueString("Contact30", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact311 = this.GetMappedValueString("Contact311", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact32 = this.GetMappedValueString("Contact32", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact33 = this.GetMappedValueString("Contact33", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact35 = this.GetMappedValueString("Contact35", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact36 = this.GetMappedValueString("Contact36", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact37 = this.GetMappedValueString("Contact37", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact38 = this.GetMappedValueString("Contact38", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact39 = this.GetMappedValueString("Contact39", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact4 = this.GetMappedValueString("Contact4", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact40 = this.GetMappedValueString("Contact40", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact41 = this.GetMappedValueString("Contact41", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact42 = this.GetMappedValueString("Contact42", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact43 = this.GetMappedValueString("Contact43", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact45 = this.GetMappedValueString("Contact45", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact46 = this.GetMappedValueString("Contact46", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact47 = this.GetMappedValueString("Contact47", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact48 = this.GetMappedValueString("Contact48", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact49 = this.GetMappedValueString("Contact49", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact5 = this.GetMappedValueString("Contact5", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact50 = this.GetMappedValueString("Contact50", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact51 = this.GetMappedValueString("Contact51", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact52 = this.GetMappedValueString("Contact52", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact53 = this.GetMappedValueString("Contact53", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact54 = this.GetMappedValueString("Contact54", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact55 = this.GetMappedValueString("Contact55", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact6 = this.GetMappedValueString("Contact6", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact7 = this.GetMappedValueString("Contact7", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact8 = this.GetMappedValueString("Contact8", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact9 = this.GetMappedValueString("Contact9", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Contact56 = this.GetMappedValueString("Contact56", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Date = this.GetMappedValueDateTime("Date", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date1 = this.GetMappedValueDateTime("Date1", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date11 = this.GetMappedValueDateTime("Date11", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date12 = this.GetMappedValueDateTime("Date12", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date13 = this.GetMappedValueDateTime("Date13", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date14 = this.GetMappedValueDateTime("Date14", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date15 = this.GetMappedValueDateTime("Date15", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date16 = this.GetMappedValueDateTime("Date16", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date17 = this.GetMappedValueDateTime("Date17", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date18 = this.GetMappedValueDateTime("Date18", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date19 = this.GetMappedValueDateTime("Date19", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date2 = this.GetMappedValueDateTime("Date2", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date20 = this.GetMappedValueDateTime("Date20", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date21 = this.GetMappedValueDateTime("Date21", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date23 = this.GetMappedValueDateTime("Date23", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date24 = this.GetMappedValueDateTime("Date24", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date25 = this.GetMappedValueDateTime("Date25", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date254 = this.GetMappedValueDateTime("Date254", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date26 = this.GetMappedValueDateTime("Date26", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date27 = this.GetMappedValueDateTime("Date27", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date28 = this.GetMappedValueDateTime("Date28", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date29 = this.GetMappedValueDateTime("Date29", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date30 = this.GetMappedValueDateTime("Date30", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date31 = this.GetMappedValueDateTime("Date31", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date32 = this.GetMappedValueDateTime("Date32", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date33 = this.GetMappedValueDateTime("Date33", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date34 = this.GetMappedValueDateTime("Date34", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date35 = this.GetMappedValueDateTime("Date35", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date36 = this.GetMappedValueDateTime("Date36", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date37 = this.GetMappedValueDateTime("Date37", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date38 = this.GetMappedValueDateTime("Date38", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date39 = this.GetMappedValueDateTime("Date39", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date4 = this.GetMappedValueDateTime("Date4", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date40 = this.GetMappedValueDateTime("Date40", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date41 = this.GetMappedValueDateTime("Date41", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date42 = this.GetMappedValueDateTime("Date42", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date43 = this.GetMappedValueDateTime("Date43", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date44 = this.GetMappedValueDateTime("Date44", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date45 = this.GetMappedValueDateTime("Date45", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date46 = this.GetMappedValueDateTime("Date46", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date47 = this.GetMappedValueDateTime("Date47", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date48 = this.GetMappedValueDateTime("Date48", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date49 = this.GetMappedValueDateTime("Date49", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date5 = this.GetMappedValueDateTime("Date5", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date50 = this.GetMappedValueDateTime("Date50", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date51 = this.GetMappedValueDateTime("Date51", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date52 = this.GetMappedValueDateTime("Date52", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date53 = this.GetMappedValueDateTime("Date53", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date54 = this.GetMappedValueDateTime("Date54", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date6 = this.GetMappedValueDateTime("Date6", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date7 = this.GetMappedValueDateTime("Date7", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date8 = this.GetMappedValueDateTime("Date8", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date9 = this.GetMappedValueDateTime("Date9", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Date99 = this.GetMappedValueDateTime("Date99", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.DateReqCancl = this.GetMappedValueDateTime("DateReqCancl", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Datte88 = this.GetMappedValueDateTime("Datte88", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.DescAddlStr = this.GetMappedValueString("DescAddlStr", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.TypeofProtectionObserved = this.GetMappedValueString("TypeofProtectionObserved", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.DivingBoard = this.GetMappedValueString("DivingBoard", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.DmgBldg = this.GetMappedValueString("DmgBldg", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.DogsAnimalDesc = this.GetMappedValueString("DogsAnimalDesc", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.DogsAnimals = this.GetMappedValueString("DogsAnimals", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.EstAgeRf = this.GetMappedValueInt("EstAgeRf", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.EstArea = this.GetMappedValueInt("EstArea", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.EstimatedRoofLife = this.GetMappedValueString("EstimatedRoofLife", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.FoundType = this.GetMappedValueString("FoundType", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Gated = this.GetMappedValueString("Gated", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.HasSketch = this.GetMappedValueString("HasSketch", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.HazardsComments = this.GetMappedValueString("HazardsComments", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.HomeManufacturedOrMobile = this.GetMappedValueString("HomeManufacturedOrMobile", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.ExteriorHouseSatisfactory = this.GetMappedValueString("ExteriorHouseSatisfactory", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.HurricaneStraps = this.GetMappedValueString("HurricaneStraps", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.InspectorName = this.GetMappedValueString("InspectorName", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.NeighborhoodType = this.GetMappedValueString("NeighborhoodType", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes1 = this.GetMappedValueString("Notes1", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes10 = this.GetMappedValueString("Notes10", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes11 = this.GetMappedValueString("Notes11", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes12 = this.GetMappedValueString("Notes12", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes13 = this.GetMappedValueString("Notes13", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes14 = this.GetMappedValueString("Notes14", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes15 = this.GetMappedValueString("Notes15", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes16 = this.GetMappedValueString("Notes16", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes17 = this.GetMappedValueString("Notes17", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes18 = this.GetMappedValueString("Notes18", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes19 = this.GetMappedValueString("Notes19", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes2 = this.GetMappedValueString("Notes2", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes20 = this.GetMappedValueString("Notes20", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes21 = this.GetMappedValueString("Notes21", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes22 = this.GetMappedValueString("Notes22", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes23 = this.GetMappedValueString("Notes23", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes24 = this.GetMappedValueString("Notes24", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes25 = this.GetMappedValueString("Notes25", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes26 = this.GetMappedValueString("Notes26", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes27 = this.GetMappedValueString("Notes27", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes28 = this.GetMappedValueString("Notes28", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes29 = this.GetMappedValueString("Notes29", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes3 = this.GetMappedValueString("Notes3", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes30 = this.GetMappedValueString("Notes30", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes31 = this.GetMappedValueString("Notes31", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes32 = this.GetMappedValueString("Notes32", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes34 = this.GetMappedValueString("Notes34", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes35 = this.GetMappedValueString("Notes35", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes36 = this.GetMappedValueString("Notes36", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes37 = this.GetMappedValueString("Notes37", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes39 = this.GetMappedValueString("Notes39", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes4 = this.GetMappedValueString("Notes4", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes40 = this.GetMappedValueString("Notes40", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes41 = this.GetMappedValueString("Notes41", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes43 = this.GetMappedValueString("Notes43", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes44 = this.GetMappedValueString("Notes44", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes45 = this.GetMappedValueString("Notes45", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes46 = this.GetMappedValueString("Notes46", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes47 = this.GetMappedValueString("Notes47", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes48 = this.GetMappedValueString("Notes48", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes49 = this.GetMappedValueString("Notes49", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes5 = this.GetMappedValueString("Notes5", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes50 = this.GetMappedValueString("Notes50", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes51 = this.GetMappedValueString("Notes51", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes52 = this.GetMappedValueString("Notes52", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes53 = this.GetMappedValueString("Notes53", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes55 = this.GetMappedValueString("Notes55", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes555 = this.GetMappedValueString("Notes555", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes58 = this.GetMappedValueString("Notes58", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes5884 = this.GetMappedValueString("Notes5884", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes6 = this.GetMappedValueString("Notes6", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes7 = this.GetMappedValueString("Notes7", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes8 = this.GetMappedValueString("Notes8", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes84848 = this.GetMappedValueString("Notes84848", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Notes9 = this.GetMappedValueString("Notes9", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.NumContactAttempts = this.GetMappedValueInt("NumContactAttempts", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.NumStories = this.GetMappedValueInt("NumStories", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.ObservedDamage = this.GetMappedValueString("ObservedDamage", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.OpinionJustification = this.GetMappedValueString("OpinionJustification", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Other = this.GetMappedValueString("Other", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.OtherExplain = this.GetMappedValueString("OtherExplain", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.OtherRoof = this.GetMappedValueString("OtherRoof", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.AdditionalStructures = this.GetMappedValueString("AdditionalStructures", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.OverallAppearance = this.GetMappedValueString("OverallAppearance", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.PercentArchitecturalShingles = this.GetMappedValueInt("PercentArchitecturalShingles", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentBuildupRoofNoGravel = this.GetMappedValueInt("PercentBuildupRoofNoGravel", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentClayConcreteTiles = this.GetMappedValueInt("PercentClayConcreteTiles", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentFlat = this.GetMappedValueInt("PercentFlat", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentGable = this.GetMappedValueInt("PercentGable", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentHip = this.GetMappedValueInt("PercentHip", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentLightMetalPanels = this.GetMappedValueInt("PercentLightMetalPanels", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentSinglePlyMembrane = this.GetMappedValueInt("PercentSinglePlyMembrane", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentSinglePlyMembraneBallasted = this.GetMappedValueInt("PercentSinglePlyMembraneBallasted", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentSlate = this.GetMappedValueInt("PercentSlate", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentStandingSeamMetalRoof = this.GetMappedValueInt("PercentStandingSeamMetalRoof", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentThreeTab = this.GetMappedValueInt("PercentThreeTab", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PercentWoodenShingles = this.GetMappedValueInt("PercentWoodenShingles", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.PoolCageScreened = this.GetMappedValueString("PoolCageScreened", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.PoolFenced = this.GetMappedValueString("PoolFenced", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Pool = this.GetMappedValueString("Pool", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.CloseoutReason = this.GetMappedValueString("CloseoutReason", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.CancellationReason = this.GetMappedValueString("CancellationReason", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RequestMethod = this.GetMappedValueString("RequestMethod", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RiskComments = this.GetMappedValueString("RiskComments", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RoofSystemCondition = this.GetMappedValueString("RoofSystemCondition", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RoofComments = this.GetMappedValueString("RoofComments", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RoofCovering = this.GetMappedValueString("RoofCovering", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RoofGeometry = this.GetMappedValueString("RoofGeometry", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.RiskOpinion = this.GetMappedValueString("RiskOpinion", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Shutters = this.GetMappedValueString("Shutters", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.SpecialInstructionComments = this.GetMappedValueString("SpecialInstructionComments", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.SpecialInstructions = this.GetMappedValueString("SpecialInstructions", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.SurveyDate = this.GetMappedValueDateTime("SurveyDate", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.Time5 = this.GetMappedValueString("Time5", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time = this.GetMappedValueString("Time", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time1 = this.GetMappedValueString("Time1", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time10 = this.GetMappedValueString("Time10", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time11 = this.GetMappedValueString("Time11", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time12 = this.GetMappedValueString("Time12", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time13 = this.GetMappedValueString("Time13", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time14 = this.GetMappedValueString("Time14", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time15 = this.GetMappedValueString("Time15", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time16 = this.GetMappedValueString("Time16", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time17 = this.GetMappedValueString("Time17", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time18 = this.GetMappedValueString("Time18", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time19 = this.GetMappedValueString("Time19", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time2 = this.GetMappedValueString("Time2", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time20 = this.GetMappedValueString("Time20", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time21 = this.GetMappedValueString("Time21", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time22 = this.GetMappedValueString("Time22", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time23 = this.GetMappedValueString("Time23", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time24 = this.GetMappedValueString("Time24", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time25 = this.GetMappedValueString("Time25", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time26 = this.GetMappedValueString("Time26", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time27 = this.GetMappedValueString("Time27", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time28 = this.GetMappedValueString("Time28", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time29 = this.GetMappedValueString("Time29", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time3 = this.GetMappedValueString("Time3", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time30 = this.GetMappedValueString("Time30", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time31 = this.GetMappedValueString("Time31", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time34 = this.GetMappedValueString("Time34", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time35 = this.GetMappedValueString("Time35", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time36 = this.GetMappedValueString("Time36", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time37 = this.GetMappedValueString("Time37", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time38 = this.GetMappedValueString("Time38", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time39 = this.GetMappedValueString("Time39", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time4 = this.GetMappedValueString("Time4", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time40 = this.GetMappedValueString("Time40", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time41 = this.GetMappedValueString("Time41", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time42 = this.GetMappedValueString("Time42", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time43 = this.GetMappedValueString("Time43", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time44 = this.GetMappedValueString("Time44", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time45 = this.GetMappedValueString("Time45", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time46 = this.GetMappedValueString("Time46", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time47 = this.GetMappedValueString("Time47", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time49 = this.GetMappedValueString("Time49", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time80 = this.GetMappedValueString("Time80", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time50 = this.GetMappedValueString("Time50", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time51 = this.GetMappedValueString("Time51", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time52 = this.GetMappedValueString("Time52", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time53 = this.GetMappedValueString("Time53", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time54 = this.GetMappedValueString("Time54", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time60 = this.GetMappedValueString("Time60", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time7 = this.GetMappedValueString("Time7", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time70 = this.GetMappedValueString("Time70", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time8 = this.GetMappedValueString("Time8", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time9 = this.GetMappedValueString("Time9", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.Time90 = this.GetMappedValueString("Time90", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.TotalArea = this.GetMappedValueDecimal("TotalArea", worksheetRow, true, columnMapping, worksheet, spreadsheetInfo);
    this.BuildingType = this.GetMappedValueString("BuildingType", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.VisibleIndicationsofHurricane = this.GetMappedValueString("VisibleIndicationsofHurricane", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
    this.DesignatedHistoricProperty = this.GetMappedValueString("DesignatedHistoricProperty", worksheetRow, columnMapping, worksheet, spreadsheetInfo);
  }

  private string GetMappedValueString(
    string imsColumnName,
    Row worksheetRow,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping,
    Worksheet worksheet,
    SpreadsheetInfo spreadsheetInfo)
  {
    InspectionInfoColumnMapping columnMapping1 = this.GetColumnMapping(imsColumnName, columnMapping);
    if (columnMapping1 == null || string.IsNullOrEmpty(columnMapping1.Spreadsheet))
      return "";
    int columnIndex = this.GetColumnIndex(worksheet, columnMapping1, spreadsheetInfo);
    return columnIndex == -1 ? "" : worksheet.Cells[worksheetRow.Index, columnIndex].StringValue;
  }

  private DateTime? GetMappedValueDateTime(
    string imsColumnName,
    Row worksheetRow,
    bool isNullable,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping,
    Worksheet worksheet,
    SpreadsheetInfo spreadsheetInfo)
  {
    InspectionInfoColumnMapping columnMapping1 = this.GetColumnMapping(imsColumnName, columnMapping);
    if (columnMapping1 == null)
      return new DateTime?();
    if (!string.IsNullOrEmpty(columnMapping1.Spreadsheet))
    {
      int columnIndex = this.GetColumnIndex(worksheet, columnMapping1, spreadsheetInfo);
      if (columnIndex == -1)
      {
        if (!isNullable)
          throw new InvalidOperationException("Column not found");
        return new DateTime?();
      }
      string stringValue = worksheet.Cells[worksheetRow.Index, columnIndex].StringValue;
      DateTime result;
      if (DateTime.TryParse(stringValue, out result))
      {
        if (result >= (DateTime) SqlDateTime.MinValue)
          return new DateTime?(result);
        this.InvalidData.Add(columnMapping1.Spreadsheet);
        return new DateTime?();
      }
      if (!string.IsNullOrEmpty(stringValue))
        this.InvalidData.Add(columnMapping1.Spreadsheet);
      return new DateTime?();
    }
    return !isNullable ? new DateTime?(new DateTime()) : new DateTime?();
  }

  private int? GetMappedValueInt(
    string imsColumnName,
    Row worksheetRow,
    bool isNullable,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping,
    Worksheet worksheet,
    SpreadsheetInfo spreadsheetInfo)
  {
    InspectionInfoColumnMapping columnMapping1 = this.GetColumnMapping(imsColumnName, columnMapping);
    if (columnMapping1 == null)
      return new int?();
    if (!string.IsNullOrEmpty(columnMapping1.Spreadsheet))
    {
      int columnIndex = this.GetColumnIndex(worksheet, columnMapping1, spreadsheetInfo);
      if (columnIndex == -1)
      {
        if (!isNullable)
          throw new InvalidOperationException("Column not found");
        return new int?();
      }
      string stringValue = worksheet.Cells[worksheetRow.Index, columnIndex].StringValue;
      int result;
      if (int.TryParse(stringValue, out result))
        return new int?(result);
      if (!string.IsNullOrEmpty(stringValue))
        this.InvalidData.Add(columnMapping1.Spreadsheet);
      return new int?();
    }
    return !isNullable ? new int?(0) : new int?();
  }

  private Decimal? GetMappedValueDecimal(
    string imsColumnName,
    Row worksheetRow,
    bool isNullable,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping,
    Worksheet worksheet,
    SpreadsheetInfo spreadsheetInfo)
  {
    InspectionInfoColumnMapping columnMapping1 = this.GetColumnMapping(imsColumnName, columnMapping);
    if (columnMapping1 == null)
      return new Decimal?();
    if (!string.IsNullOrEmpty(columnMapping1.Spreadsheet))
    {
      int columnIndex = this.GetColumnIndex(worksheet, columnMapping1, spreadsheetInfo);
      if (columnIndex == -1)
      {
        if (!isNullable)
          throw new InvalidOperationException("Column not found");
        return new Decimal?();
      }
      string stringValue = worksheet.Cells[worksheetRow.Index, columnIndex].StringValue;
      Decimal result;
      if (Decimal.TryParse(stringValue, out result))
        return new Decimal?(result);
      if (!string.IsNullOrEmpty(stringValue))
        this.InvalidData.Add(columnMapping1.Spreadsheet);
      return new Decimal?();
    }
    return !isNullable ? new Decimal?(0M) : new Decimal?();
  }

  private int GetColumnIndex(
    Worksheet worksheet,
    InspectionInfoColumnMapping colMapping,
    SpreadsheetInfo spreadsheetInfo)
  {
    int columnIndex = -1;
    if (spreadsheetInfo.ColumnIndex.ContainsKey(colMapping.Spreadsheet))
    {
      spreadsheetInfo.ColumnIndex.TryGetValue(colMapping.Spreadsheet, out columnIndex);
    }
    else
    {
      for (int index = 0; index <= worksheet.Cells.MaxDataColumn; ++index)
      {
        if (Strings.Trim(worksheet.Cells[0, index].StringValue.Replace("\n", "")) == Strings.Trim(colMapping.Spreadsheet))
        {
          columnIndex = index;
          spreadsheetInfo.ColumnIndex.Add(colMapping.Spreadsheet, columnIndex);
          break;
        }
      }
    }
    return columnIndex;
  }

  private InspectionInfoColumnMapping GetColumnMapping(
    string imsColumnName,
    ObservableCollection<InspectionInfoColumnMapping> columnMapping)
  {
    return columnMapping.Where<InspectionInfoColumnMapping>((System.Func<InspectionInfoColumnMapping, bool>) (x => x.IMS == imsColumnName)).FirstOrDefault<InspectionInfoColumnMapping>();
  }
}
