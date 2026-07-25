// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.EquipmentBreakdown.EquipmentBreakdownRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.EquipmentBreakdown;

[RaterInformation(96 /*0x60*/, "Equipment Breakdown")]
public class EquipmentBreakdownRater : RaterWithUIBase
{
  protected override Form CreateUI()
  {
    return ObjectFactory.Instance.CreateFormEX(typeof (frmEquipmentBreakdownRater));
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.CopyEquipmentBreakdownInfo", new object[4]
    {
      (object) "@newQuoteGuid",
      (object) e.NewQuoteGuid,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }
}
