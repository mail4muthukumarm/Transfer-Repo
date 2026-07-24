// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberHistory.ChildNumberInterface
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.PolicyNumberHistory;

public partial class ChildNumberInterface : MgaMdiChild, IComponentConnector
{
  internal StackPanel MainPanel;
  internal DataGrid dgPolNumbers;
  private bool _contentLoaded;

  public ChildNumberInterface(Guid quoteGuid, Guid companylineGuid)
  {
    this.InitializeComponent();
    ChildNumModel childNumModel = new ChildNumModel();
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable("ChildPolicyNumberHistory", new object[4]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@CompanyLineGuid",
      (object) companylineGuid
    }).Rows)
    {
      ChildNumData childNumData = new ChildNumData();
      childNumData.QuoteID = row.Field<int>("QuoteID");
      childNumData.LocationName = row.Field<string>("LocationName");
      if (!row.IsNull("EndorsementNum"))
        childNumData.EndorsementNum = row.Field<int>("EndorsementNum");
      if (!row.IsNull("PolicyNumber"))
        childNumData.PolicyNumber = row.Field<string>("PolicyNumber");
      if (!row.IsNull("RuleName"))
        childNumData.RuleName = row.Field<string>("RuleName");
      childNumModel.DetailPolicyNumList.Add(childNumData);
    }
    ((FrameworkElement) this).DataContext = (object) childNumModel;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/policynumberhistory/childnumberinterface.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId == 2)
        this.dgPolNumbers = (DataGrid) target;
      else
        this._contentLoaded = true;
    }
    else
      this.MainPanel = (StackPanel) target;
  }
}
