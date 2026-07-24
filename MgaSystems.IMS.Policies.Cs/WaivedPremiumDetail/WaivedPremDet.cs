// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.WaivedPremiumDetail.WaivedPremDet
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.WaivedPremiumDetail;

public class WaivedPremDet : INotifyPropertyChanged
{
  private bool _waivePremium;

  public event PropertyChangedEventHandler PropertyChanged;

  public bool FinishedLoading { get; set; }

  private void OnPropertyChanged(string propertyName)
  {
    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    if (propertyChanged != null)
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    if (!propertyName.Equals("WaivePremium") || !this.FinishedLoading)
      return;
    if (!this.WaivePremium)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDetailWaivedPremium WHERE QuoteGuid = @QuoteGuid AND CompanyLineGuid = @CompanyLineGuid", new object[4]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@CompanyLineGuid",
        (object) this.CompanyLineGuid
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblDetailWaivedPremium(QuoteGuid,CompanyLineGuid) SELECT @QuoteGuid, @CompanyLineGuid", new object[4]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@CompanyLineGuid",
        (object) this.CompanyLineGuid
      });
  }

  public Guid QuoteGuid { get; set; }

  public Decimal Premium { get; set; }

  public Guid CompanyLineGuid { get; set; }

  public string CompanyLine { get; set; }

  public int MinWaivePremium { get; set; }

  public int MaxWaivePremium { get; set; }

  public bool WaivePremium
  {
    get => this._waivePremium;
    set
    {
      this._waivePremium = value;
      this.OnPropertyChanged(nameof (WaivePremium));
    }
  }
}
