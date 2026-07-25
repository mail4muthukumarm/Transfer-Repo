// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterSettings
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class RaterSettings
{
  protected RaterBase Rater { get; }

  public RaterSettings(RaterBase rater) => this.Rater = rater;

  public virtual void ProcessFilingProducers(Quote quote)
  {
    if (quote.CompanyLine.IsAdmitted)
      return;
    bool flag = true;
    while (flag)
    {
      frmFilingProducers objectAs = ObjectFactory.Instance.CreateObjectAs<frmFilingProducers>((object) quote.QuoteID);
      objectAs.InvokedViaRater = true;
      objectAs.FillData();
      try
      {
        if (MDIControls.Instance.BlackBoxMode)
        {
          objectAs.SaveDefaultFilingProducers();
          break;
        }
        if (objectAs.HasUnaskedStates)
        {
          objectAs.ShowInTaskbar = false;
          int num = (int) objectAs.ShowDialog();
        }
        else
          flag = false;
      }
      finally
      {
        objectAs.Dispose();
      }
    }
  }
}
