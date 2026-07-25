// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.TelematicsListener
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.Common.Telematics;

public class TelematicsListener : ISupportPreLoadCache
{
  public string PreLoadKey => "MGASystems.Common.Telematics.TelematicsListener.PolicyBound";

  public void OnAsynchronousLoad(object sender, OnAsynchronousLoadEventArgs e)
  {
    Messaging.MessageSent += new Messaging.MessageSentEventHandler(this.Messaging_MessageSent);
  }

  private void Messaging_MessageSent(object sender, Messaging.MessageEventArgs e)
  {
    if (!SystemSettings.GetBoolSetting("TelemetricsSendVehicles") || !e.EventGuid.Equals(BroadcastMessages.EndorsementBound) && !e.EventGuid.Equals(BroadcastMessages.PolicyCancelled) || !MGASystems.Common.Telematics.Telematics.telematicsSingleton.isQuoteEnabledForAutoSend((Guid) e.Context))
      return;
    if (e.EventGuid.Equals(BroadcastMessages.EndorsementBound))
    {
      this.OnEndorsementBound((Guid) e.Context);
      CurrentUser.Instance.LogAction($"EndorsementBound {(Guid) e.Context}");
    }
    else
    {
      if (!e.EventGuid.Equals(BroadcastMessages.PolicyCancelled))
        return;
      this.OnPolicyCancelled((Guid) e.Context);
      CurrentUser.Instance.LogAction($"PolicyCancelled {(Guid) e.Context}");
    }
  }

  private void OnEndorsementBound(Guid quoteGuid)
  {
    DataSet dataSet = new DataSet();
    DefaultDatabase.LoadDataSet(dataSet, new string[1]
    {
      "policy"
    }, CommandType.StoredProcedure, "spSpeedGauge_QuoteVehicles", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    if (dataSet.Tables["policy"].Rows.Count <= 0)
      return;
    int carrierId = MGASystems.Common.Telematics.Telematics.telematicsSingleton.CarrierId();
    TelematicsSendVehicleRequest sendVehicleRequest = new TelematicsSendVehicleRequest(dataSet.Tables["policy"].Rows[0]["InsuredCorporationName"].ToString(), carrierId);
    sendVehicleRequest.controlNumber = dataSet.Tables["policy"].Rows[0].Field<int>("ControlNo");
    sendVehicleRequest.vehicleCount = dataSet.Tables["policy"].Rows.Count;
    foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables["policy"].Rows)
      sendVehicleRequest.AddVehicle(row["VIN"].ToString(), row["InsuredCorporationName"].ToString() + row["VehicleUnitNumber"].ToString(), row["VehicleTypeDesc"].ToString(), row["IsDeleted"].ToString() == "1");
    MGASystems.Common.Telematics.Telematics.telematicsSingleton.SendVehicle(sendVehicleRequest);
  }

  private void OnPolicyCancelled(Guid quoteGuid)
  {
    DataSet dataSet = new DataSet();
    DefaultDatabase.LoadDataSet(dataSet, new string[1]
    {
      "policy"
    }, CommandType.StoredProcedure, "spSpeedGauge_QuoteVehicles", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    if (dataSet.Tables["policy"].Rows.Count <= 0)
      return;
    int carrierId = MGASystems.Common.Telematics.Telematics.telematicsSingleton.CarrierId();
    TelematicsSendVehicleRequest sendVehicleRequest = new TelematicsSendVehicleRequest(dataSet.Tables["policy"].Rows[0]["InsuredCorporationName"].ToString(), carrierId);
    sendVehicleRequest.controlNumber = dataSet.Tables["policy"].Rows[0].Field<int>("ControlNo");
    sendVehicleRequest.vehicleCount = dataSet.Tables["policy"].Rows.Count;
    foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables["policy"].Rows)
      sendVehicleRequest.AddVehicle(row["VIN"].ToString(), row["InsuredCorporationName"].ToString() + row["VehicleUnitNumber"].ToString(), row["VehicleTypeDesc"].ToString(), true);
    MGASystems.Common.Telematics.Telematics.telematicsSingleton.SendVehicle(sendVehicleRequest);
  }
}
