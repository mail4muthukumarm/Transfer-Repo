// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.WaivedPremiumDetail.PremiumDetail
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.WaivedPremiumDetail;

public partial class PremiumDetail : MgaMdiChild, IComponentConnector
{
  internal StackPanel MainPanel;
  internal DataGrid dgTest;
  private bool _contentLoaded;

  public PremiumDetail(Guid quoteGuid, DataTable dt)
  {
    this.InitializeComponent();
    WaivedPolicyDetailModel policyDetailModel = new WaivedPolicyDetailModel();
    foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
    {
      WaivedPremDet waivedPremDet = new WaivedPremDet();
      waivedPremDet.QuoteGuid = quoteGuid;
      waivedPremDet.Premium = row.Field<Decimal>("Premium");
      waivedPremDet.WaivePremium = false;
      waivedPremDet.MinWaivePremium = row.Field<int>("MinWaivePremium");
      waivedPremDet.MaxWaivePremium = row.Field<int>("MaxWaivePremium");
      waivedPremDet.CompanyLineGuid = row.Field<Guid>("CompanyLineGuid");
      CompanyLine companyLine = new CompanyLine(waivedPremDet.CompanyLineGuid);
      waivedPremDet.CompanyLine = companyLine.CompanyLineState;
      policyDetailModel.WaivedPremiumList.Add(waivedPremDet);
    }
    foreach (WaivedPremDet waivedPremium in (Collection<WaivedPremDet>) policyDetailModel.WaivedPremiumList)
      waivedPremium.FinishedLoading = true;
    ((FrameworkElement) this).DataContext = (object) policyDetailModel;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/waivedpremiumdetail/premiumdetail.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId == 2)
        this.dgTest = (DataGrid) target;
      else
        this._contentLoaded = true;
    }
    else
      this.MainPanel = (StackPanel) target;
  }
}
