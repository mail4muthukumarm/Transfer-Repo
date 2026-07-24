// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberAlert.PolicyNumberNotesUser
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
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
namespace MgaSystems.IMS.Policies.PolicyNumberAlert;

public partial class PolicyNumberNotesUser : MgaMdiChild, IComponentConnector
{
  internal StackPanel MainPanel;
  internal DataGrid dgTest;
  private bool _contentLoaded;

  public PolicyNumberNotesUser(int ruleID)
  {
    this.InitializeComponent();
    PolicyNumberNoteModel policyNumberNoteModel = new PolicyNumberNoteModel();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT UserGuid FROM tblPolicyNumberNotesUsers WITH (NOLOCK)  WHERE RuleID = @RuleID", new object[2]
    {
      (object) "@RuleID",
      (object) ruleID
    });
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT UserGuid, FirstName, LastName FROM tblUsers WITH (NOLOCK) ORDER BY FirstName ASC, LastName ASC").Rows)
    {
      PolUser polUser = new PolUser();
      polUser.RuleID = ruleID;
      polUser.UserGuid = row.Field<Guid>("UserGuid");
      polUser.FirstName = row.Field<string>("FirstName");
      polUser.LastName = row.Field<string>("LastName");
      polUser.SendNote = false;
      if (dataTable.Select($"UserGuid='{polUser.UserGuid.ToString()}'").Length != 0)
        polUser.SendNote = true;
      policyNumberNoteModel.UserNoteList.Add(polUser);
    }
    foreach (PolUser userNote in (Collection<PolUser>) policyNumberNoteModel.UserNoteList)
      userNote.FinishedLoading = true;
    ((FrameworkElement) this).DataContext = (object) policyNumberNoteModel;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/policynumberalert/policynumbernotesuser.xaml", UriKind.Relative));
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
