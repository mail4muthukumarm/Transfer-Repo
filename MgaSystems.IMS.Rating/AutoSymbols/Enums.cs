// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.AutoSymbols.Enums
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

#nullable disable
namespace MGASystems.IMS.Policies.Rating.AutoSymbols;

public class Enums
{
  public enum SymbolCoverages
  {
    Liability = 1,
    MedicalPayments = 2,
    PIP = 3,
    AdditionalPIP = 4,
    PPI = 5,
    UM = 6,
    UIM = 7,
    Garagekeepers = 8,
    GKComp = 9,
    GKCauseOfLoss = 10, // 0x0000000A
    GKCollision = 11, // 0x0000000B
    PhysicalDamageComp = 12, // 0x0000000C
    PhysicalDamageCauseOfLoss = 13, // 0x0000000D
    PhysicalDamageCollision = 14, // 0x0000000E
    Towing = 15, // 0x0000000F
    TrailerInterchangeComp = 16, // 0x00000010
    TrailerInterchangeCauseOfLoss = 17, // 0x00000011
    TrailerInterchangeCollision = 18, // 0x00000012
    MedicalExpenseAndIncomeLoss = 19, // 0x00000013
    OptionalBasicEconomicLoss = 20, // 0x00000014
    AggregateNoFault = 21, // 0x00000015
    MaxMonthlyWorkLoss = 22, // 0x00000016
    DeathBenefits = 23, // 0x00000017
    OtherExpensesPerDay = 24, // 0x00000018
    SUM = 25, // 0x00000019
    SSL = 26, // 0x0000001A
  }

  public enum SymbolSets
  {
    BusinessAuto = 1,
    Garage = 2,
    MotorCarrier = 3,
  }
}
