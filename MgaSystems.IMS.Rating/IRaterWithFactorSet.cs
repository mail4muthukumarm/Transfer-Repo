// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.IRaterWithFactorSet
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects.Rating;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[Obsolete("IRaterWithFactorSet is deprecated, all new and existing implementations should derive from IRaterWithFactorSet2 instead")]
public interface IRaterWithFactorSet : IRater
{
  Guid FactorSetGuid { get; set; }

  Form CreateFactorSetConfigurationFormEdit(Guid factorSetGuid, Guid companyLineGuid);

  Form CreateFactorSetConfigurationFormNew(Guid companyLineGuid);

  bool CopyFactorSet(Guid originalFactorSetGuid, Guid destinationcompanyLineGuid);

  bool DeleteFactorSet(Guid factorSetToDelete);
}
