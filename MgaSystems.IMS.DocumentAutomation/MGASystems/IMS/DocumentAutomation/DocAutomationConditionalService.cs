// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DocAutomationConditionalService
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class DocAutomationConditionalService : IDocAutomationConditionalService
{
  public void CopyConditional(
    int? templateID,
    Guid _companyLineGuid,
    Guid _systemEventGuid,
    DocumentConditional _conditionToCopy)
  {
    CopyConditionalViewModel conditionalViewModel = CopyConditionalViewModel.Create(templateID, _companyLineGuid, _systemEventGuid, _conditionToCopy);
    CopyDocumentAutomationConditional automationConditional = MgaMdiChild.Create<CopyDocumentAutomationConditional>(new object[0]);
    ((FrameworkElement) automationConditional).DataContext = (object) conditionalViewModel;
    automationConditional.Form.MdiParent = MDIControls.Instance.MDIParent;
    automationConditional.Form.Show();
  }

  public void GetTag(int? templateID, int? autoGroupID, Action<Tag> response)
  {
    AvailableTagsViewModel availableTagsViewModel = AvailableTagsViewModel.Create(templateID, autoGroupID);
    availableTagsViewModel.CloseAction = response;
    AvailableTags availableTags = MgaMdiChild.Create<AvailableTags>(new object[0]);
    ((FrameworkElement) availableTags).DataContext = (object) availableTagsViewModel;
    availableTags.Form.FormClosed += (FormClosedEventHandler) ([SpecialName] (o, e) =>
    {
      if (!(((FrameworkElement) availableTags).DataContext is AvailableTagsViewModel dataContext2))
        return;
      dataContext2.CloseAction(dataContext2.responseObject);
    });
    int num = (int) availableTags.Form.ShowDialog();
  }
}
