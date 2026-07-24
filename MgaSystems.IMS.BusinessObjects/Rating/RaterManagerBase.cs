// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Rating.RaterManagerBase
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.BusinessObjects.Rating;

[StandardModule]
public sealed class RaterManagerBase
{
  [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "quoteGuid")]
  [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
  public static void ReRateAllOptions(Guid quoteGuid)
  {
    throw new InvalidOperationException("ReRateAllOptions not implemented");
  }

  public static void RefreshAvailableRatersList()
  {
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      return;
    dsRateManager dsRateManager = new dsRateManager();
    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT RatingTypeID, RatingType, Hidden FROM dbo.lstRatingTypes", DefaultDatabase.ConnectionString))
    {
      DefaultDatabase.DataAdapterFill((DbDataAdapter) adapter, (DataTable) dsRateManager.lstRatingTypes);
      Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new RaterInformationAttribute());
      int index = 0;
      while (index < typeArray.Length)
      {
        Type type = typeArray[index];
        RaterInformationAttribute attribute = (RaterInformationAttribute) TypeDescriptor.GetAttributes(type)[typeof (RaterInformationAttribute)];
        if (attribute != null && dsRateManager.lstRatingTypes.FindByRatingTypeID(attribute.RaterID) == null && (IRater) ObjectFactory.Instance.CreateObject(type, typeof (IRater)) != null)
          dsRateManager.lstRatingTypes.AddlstRatingTypesRow(attribute.RaterID, attribute.RaterName, false);
        checked { ++index; }
      }
      if (!dsRateManager.HasChanges())
        return;
      using (new SqlCommandBuilder(adapter))
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) adapter, (DataTable) dsRateManager.lstRatingTypes);
    }
  }
}
