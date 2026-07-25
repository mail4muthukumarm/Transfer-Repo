// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.EntityAKAType
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public enum EntityAKAType
{
  [EnumMember(Value = "None")] None,
  [EnumMember(Value = "AKA")] AKA,
  [EnumMember(Value = "FKA")] FKA,
  [EnumMember(Value = "NKA")] NKA,
  [EnumMember(Value = "DBA")] DBA,
  [EnumMember(Value = "CCC")] CCC,
  [EnumMember(Value = "Nickname")] Nickname,
  [EnumMember(Value = "CallSign")] CallSign,
  [EnumMember(Value = "Acronym")] Acronym,
}
