// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.DebugHelper.ViewModels.DeveloperDebugHelperViewModel
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace MgaSystems.IMS.Forms.DebugHelper.ViewModels;

public class DeveloperDebugHelperViewModel
{
  public Dictionary<string, string> primaryException { get; } = new Dictionary<string, string>();

  public Dictionary<string, string> innerException { get; } = new Dictionary<string, string>();

  public string detailsText { get; set; }

  public string fusionText { get; set; }

  public DeveloperDebugHelperViewModel(Exception ex)
  {
    this.primaryException.Add("Message", ex.Message);
    this.primaryException.Add("Source", ex.Source);
    this.primaryException.Add("StackTrace", ex.StackTrace);
    this.primaryException.Add("TargetSite", ex.TargetSite.ToString());
    if (ex.InnerException != null)
    {
      this.innerException.Add("Message", ex.Message);
      this.innerException.Add("Source", ex.Source);
      this.innerException.Add("StackTrace", ex.StackTrace);
      this.innerException.Add("TargetSite", ex.TargetSite.ToString());
    }
    this.detailsText = ex.StackTrace;
    PropertyInfo property1 = ex.GetType().GetProperty("Fusion Log");
    if (property1 != (PropertyInfo) null && property1.GetValue((object) ex, (object[]) null) != null)
    {
      this.fusionText = property1.GetValue((object) ex, (object[]) null).ToString();
    }
    else
    {
      if (ex.InnerException == null)
        return;
      PropertyInfo property2 = ex.InnerException.GetType().GetProperty("FusionLog");
      if (!(property2 != (PropertyInfo) null) || property2.GetValue((object) ex.InnerException, (object[]) null) == null)
        return;
      this.fusionText = property2.GetValue((object) ex.InnerException, (object[]) null).ToString();
    }
  }
}
