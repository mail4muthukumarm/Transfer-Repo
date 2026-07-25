// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedSWIFTAdditionalInfoType
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public enum ParsedSWIFTAdditionalInfoType
{
  [EnumMember(Value = "None")] None,
  [EnumMember(Value = "Citizenship")] Citizenship,
  [EnumMember(Value = "Complexion")] Complexion,
  [EnumMember(Value = "DistinguishingMarks")] DistinguishingMarks,
  [EnumMember(Value = "DOB")] DOB,
  [EnumMember(Value = "EyeColor")] EyeColor,
  [EnumMember(Value = "HairColor")] HairColor,
  [EnumMember(Value = "Height")] Height,
  [EnumMember(Value = "MothersName")] MothersName,
  [EnumMember(Value = "Nationality")] Nationality,
  [EnumMember(Value = "Occupation")] Occupation,
  [EnumMember(Value = "PlaceOfBirth")] PlaceOfBirth,
  [EnumMember(Value = "Position")] Position,
  [EnumMember(Value = "Race")] Race,
  [EnumMember(Value = "VesselCallSign")] VesselCallSign,
  [EnumMember(Value = "VesselFlag")] VesselFlag,
  [EnumMember(Value = "VesselGRT")] VesselGRT,
  [EnumMember(Value = "VesselOwner")] VesselOwner,
  [EnumMember(Value = "VesselTonnage")] VesselTonnage,
  [EnumMember(Value = "VesselType")] VesselType,
  [EnumMember(Value = "Weight")] Weight,
  [EnumMember(Value = "Incident")] Incident,
  [EnumMember(Value = "Other")] Other,
  [EnumMember(Value = "IPAddress")] IPAddress,
}
