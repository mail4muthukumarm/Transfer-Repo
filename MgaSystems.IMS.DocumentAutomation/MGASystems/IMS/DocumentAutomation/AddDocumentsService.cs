// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AddDocumentsService
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class AddDocumentsService : IAddDocumentsService
{
  public void GetDocuments(Quote _quote, List<Guid> newQuoteGuids, Action<List<Guid>> response)
  {
    AddDocumentsViewModel documentsViewModel = AddDocumentsViewModel.Create(_quote, newQuoteGuids);
    documentsViewModel.CloseActionGuid = response;
    AddDocuments addDocuments = MgaMdiChild.Create<AddDocuments>(new object[2]
    {
      (object) _quote,
      (object) newQuoteGuids
    });
    ((FrameworkElement) addDocuments).DataContext = (object) documentsViewModel;
    addDocuments.Form.FormClosed += (FormClosedEventHandler) ([SpecialName] (o, e) =>
    {
      if (!(((FrameworkElement) addDocuments).DataContext is AddDocumentsViewModel dataContext2))
        return;
      dataContext2.CloseActionGuid(dataContext2.responseObjectGuid);
    });
    int num = (int) addDocuments.Form.ShowDialog();
  }

  public void GetAdditionalDocuments(
    Quote _quote,
    List<Guid> newQuoteGuids,
    Action<AdditionalDocumentInfo> response)
  {
    AddDocumentsViewModel documentsViewModel = AddDocumentsViewModel.Create(_quote, newQuoteGuids);
    documentsViewModel.CloseActionInfo = response;
    AddDocuments addDocuments = MgaMdiChild.Create<AddDocuments>(new object[2]
    {
      (object) _quote,
      (object) newQuoteGuids
    });
    ((FrameworkElement) addDocuments).DataContext = (object) documentsViewModel;
    addDocuments.Form.FormClosed += (FormClosedEventHandler) ([SpecialName] (o, e) =>
    {
      if (!(((FrameworkElement) addDocuments).DataContext is AddDocumentsViewModel dataContext2))
        return;
      dataContext2.CloseActionInfo(dataContext2.responseObjectInfo);
    });
    int num = (int) addDocuments.Form.ShowDialog();
  }
}
