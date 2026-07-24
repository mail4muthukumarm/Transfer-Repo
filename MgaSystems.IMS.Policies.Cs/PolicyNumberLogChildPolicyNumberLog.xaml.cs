// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberLog.ChildPolicyNumberLog
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
namespace MgaSystems.IMS.Policies.PolicyNumberLog;

public partial class ChildPolicyNumberLog : MgaMdiChild, IComponentConnector
{
  internal StackPanel MainPanel;
  internal DataGrid dgChildPolicyNumbers;
  private bool _contentLoaded;

  public ChildPolicyNumberLog(int controlNo)
  {
    this.InitializeComponent();
    ChildPolicyNumberLogModel policyNumberLogModel = new ChildPolicyNumberLogModel();
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable("dbo.GetChildPolicyNumbersLog", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNo
    }).Rows)
      policyNumberLogModel.ChildPolicyNumberList.Add(new ChildNumberLogEntry()
      {
        QuoteId = row.Field<int?>("QuoteID"),
        PolicyNumber = row.Field<string>("PolicyNumber"),
        RuleIndex = row.Field<int?>("PolicyNumberIndex"),
        RuleName = row.Field<string>("RuleName"),
        CompanyLine = row.Field<string>("CompanyLine"),
        ActionDate = row.Field<DateTime>("ActionDate"),
        HostName = row.Field<string>("HostName"),
        Action = row.Field<string>("Action")
      });
    ((FrameworkElement) this).DataContext = (object) policyNumberLogModel;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/policynumberlog/childpolicynumberlog.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId == 2)
        this.dgChildPolicyNumbers = (DataGrid) target;
      else
        this._contentLoaded = true;
    }
    else
      this.MainPanel = (StackPanel) target;
  }
}
