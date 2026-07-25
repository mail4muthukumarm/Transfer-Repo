// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.ScreenResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class ScreenResponse : BaseResult
{
  [JsonProperty("workflow_instance_identifier")]
  public string WorkflowInstanceIdentifier { get; set; }

  [JsonProperty("workflow_type")]
  public string WorkflowType { get; set; }

  [JsonProperty("steps")]
  public string[] Steps { get; set; }

  [JsonProperty("step_details")]
  public StepDetails StepDetails { get; set; }

  [JsonProperty("status")]
  public string Status { get; set; }

  [JsonProperty("title")]
  public string Title { get; set; }

  [JsonProperty("identifier")]
  public string Identifier { get; set; }

  [JsonProperty("timestamp")]
  public DateTime TimeStamp { get; set; }
}
