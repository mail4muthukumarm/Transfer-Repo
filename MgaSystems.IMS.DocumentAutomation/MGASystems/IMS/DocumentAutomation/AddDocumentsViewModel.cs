// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AddDocumentsViewModel
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Data;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Data.Binding;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Input;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class AddDocumentsViewModel : BindingObject
{
  public Action<List<Guid>> CloseActionGuid;
  public List<Guid> responseObjectGuid;
  public Action<AdditionalDocumentInfo> CloseActionInfo;
  public AdditionalDocumentInfo responseObjectInfo;
  protected Quote _quote;
  private List<Guid> _newQuoteGuids;
  private List<Guid> _fileToAddDocumentStoreGuids;
  private IWin32DialogService _dialogSvc;
  private bool _saved;
  private StringCollection _documentFileNames;
  private bool canClose;
  private ICommand _requestCloseCommand;
  private ICommand _saveCommand;
  private ICommand _cancelCommand;
  private ICommand _addCommand;
  private ICommand _addAllCommand;
  private ICommand _removeCommand;
  private ICommand _browseCommand;

  [NotificationProperty]
  public virtual ObservableCollection<AdditionalDoc> AvailableDocuments { get; set; }

  [NotificationProperty]
  public virtual AdditionalDoc SelectedDocument { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<AdditionalDoc> SelectedDocuments { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource AvailableDocCVS { get; set; }

  [NotificationProperty]
  public virtual CollectionViewSource AddedDocCVS { get; set; }

  [NotificationProperty]
  public virtual AdditionalDoc SelectedAddedDoc { get; set; }

  [NotificationProperty]
  public virtual ObservableCollection<AdditionalDoc> SelectedAddedDocuments { get; set; }

  [NotificationProperty]
  public virtual string FilterAvailableDescription { get; set; }

  [NotificationProperty]
  public virtual string FilterAvailableFolderName { get; set; }

  [NotificationProperty]
  public virtual string FilterAddedDescription { get; set; }

  [NotificationProperty]
  public virtual string FilterAddedFileName { get; set; }

  [NotificationProperty]
  public virtual string FilterAddedFolderName { get; set; }

  [NotificationProperty]
  public virtual Cursor Cursor { get; set; }

  public List<Guid> FileToAddDocumentStoreGuids => this._fileToAddDocumentStoreGuids;

  public StringCollection DocumentFileNames => this._documentFileNames;

  public AddDocumentsViewModel(Quote quote, List<Guid> newQuoteGuids)
  {
    this.canClose = true;
    this._quote = quote;
    this._newQuoteGuids = newQuoteGuids;
    this._fileToAddDocumentStoreGuids = new List<Guid>();
    this.AvailableDocuments = new ObservableCollection<AdditionalDoc>();
    this.SelectedDocuments = new ObservableCollection<AdditionalDoc>();
    this.SelectedAddedDocuments = new ObservableCollection<AdditionalDoc>();
    this.SetAdditionalDocuments();
    this.SetCVS();
  }

  public static AddDocumentsViewModel Create(Quote quote, List<Guid> newQuoteGuids)
  {
    return NotifyProxyTypeManager.Allocate<AddDocumentsViewModel>(new object[2]
    {
      (object) quote,
      (object) newQuoteGuids
    });
  }

  public ICommand RequestCloseCommand
  {
    get
    {
      if (this._requestCloseCommand == null)
        this._requestCloseCommand = (ICommand) new RelayCommand<AddDocumentsViewModel>((Action<AddDocumentsViewModel>) ([SpecialName] (param) => this.ExecuteRequestCloseCommand((object) param)));
      return this._requestCloseCommand;
    }
  }

  private void ExecuteRequestCloseCommand(object obj)
  {
    if (!(obj is CloseObject))
      return;
    CloseObject closeObject = obj as CloseObject;
    if (!(closeObject.mgaObject is MgaMdiChild))
      return;
    if (Operators.CompareString(closeObject.calledFrom, "CancelCommand", false) == 0)
      this._fileToAddDocumentStoreGuids = new List<Guid>();
    ((MgaMdiChild) closeObject.mgaObject).Form.Close();
  }

  public ICommand SaveCommand
  {
    get
    {
      if (this._saveCommand == null)
        this._saveCommand = (ICommand) new RelayCommand<AddDocuments>((Action<AddDocuments>) ([SpecialName] (param) => this.Save((object) param)), (Predicate<AddDocuments>) ([SpecialName] (param) => this.CanExecuteSave()));
      return this._saveCommand;
    }
  }

  private void Save(object imsObject)
  {
    this._saved = true;
    ObservableCollection<AdditionalDoc> availableDocuments1 = this.AvailableDocuments;
    Func<AdditionalDoc, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (AddDocumentsViewModel._Closure\u0024__.\u0024I76\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = AddDocumentsViewModel._Closure\u0024__.\u0024I76\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      AddDocumentsViewModel._Closure\u0024__.\u0024I76\u002D0 = predicate1 = (Func<AdditionalDoc, bool>) ([SpecialName] (d) => d.Added);
    }
    if (availableDocuments1.Where<AdditionalDoc>(predicate1).Count<AdditionalDoc>() > 0)
      this._documentFileNames = new StringCollection();
    this.Cursor = Cursors.Wait;
    try
    {
      ObservableCollection<AdditionalDoc> availableDocuments2 = this.AvailableDocuments;
      Func<AdditionalDoc, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (AddDocumentsViewModel._Closure\u0024__.\u0024I76\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = AddDocumentsViewModel._Closure\u0024__.\u0024I76\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        AddDocumentsViewModel._Closure\u0024__.\u0024I76\u002D1 = predicate2 = (Func<AdditionalDoc, bool>) ([SpecialName] (x) => x.Added);
      }
      foreach (AdditionalDoc additionalDoc in availableDocuments2.Where<AdditionalDoc>(predicate2))
      {
        DocListItem docListItemTag = (DocListItem) additionalDoc.DocListItemTag;
        string attachmentFileName = additionalDoc.AttachmentFileName;
        if (!string.IsNullOrEmpty(docListItemTag.Document))
        {
          this._documentFileNames.Add(DocumentManager.SaveDocumentToFile(docListItemTag.DocumentStoreGuid));
          this.FileToAddDocumentStoreGuids.Add(docListItemTag.DocumentStoreGuid);
          if (!string.IsNullOrWhiteSpace(attachmentFileName) && string.Compare(attachmentFileName, docListItemTag.AttachmentFileName, true) != 0)
            DocumentManager.AddDocumentAlias(docListItemTag.DocumentStoreGuid, attachmentFileName);
        }
        else if (!string.IsNullOrEmpty(docListItemTag.Filename))
        {
          Guid guid = DocumentManager.FileAdd(docListItemTag.Filename);
          DocumentManager.BeginBindDocument(guid, (ISupportDocumentSystem) this._quote);
          this._fileToAddDocumentStoreGuids.Add(guid);
          if (this._newQuoteGuids != null)
          {
            try
            {
              foreach (Guid newQuoteGuid in this._newQuoteGuids)
              {
                Quote docSupport = new Quote(newQuoteGuid);
                DocumentManager.BeginBindDocument(guid, (ISupportDocumentSystem) docSupport);
              }
            }
            finally
            {
              List<Guid>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
          if (!string.IsNullOrWhiteSpace(attachmentFileName) && string.Compare(attachmentFileName, docListItemTag.AttachmentFileName, true) != 0)
            DocumentManager.AddDocumentAlias(guid, attachmentFileName);
          this.DocumentFileNames.Add(docListItemTag.Filename);
        }
        else
        {
          if (docListItemTag.FileNames.Length == 0)
            throw new InvalidOperationException("Expected multiple documents");
          string[] fileNames = docListItemTag.FileNames;
          int index = 0;
          while (index < fileNames.Length)
          {
            this.DocumentFileNames.Add(fileNames[index]);
            checked { ++index; }
          }
        }
      }
    }
    finally
    {
      IEnumerator<AdditionalDoc> enumerator;
      enumerator?.Dispose();
    }
    this.Cursor = Cursors.Arrow;
    this.responseObjectGuid = this._fileToAddDocumentStoreGuids;
    this.responseObjectInfo = new AdditionalDocumentInfo()
    {
      DocumentFileNames = this._documentFileNames,
      FileToAddDocumentStoreGuids = this._fileToAddDocumentStoreGuids
    };
    this.ExecuteRequestCloseCommand((object) new CloseObject()
    {
      mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
      calledFrom = "OKCommand"
    });
  }

  private bool CanExecuteSave() => true;

  public ICommand CancelCommand
  {
    get
    {
      if (this._cancelCommand == null)
        this._cancelCommand = (ICommand) new RelayCommand<AddDocuments>((Action<AddDocuments>) ([SpecialName] (param) => this.Cancel((object) param)));
      return this._cancelCommand;
    }
  }

  private void Cancel(object imsObject)
  {
    this.responseObjectGuid = new List<Guid>();
    this.responseObjectInfo = new AdditionalDocumentInfo()
    {
      DocumentFileNames = (StringCollection) null,
      FileToAddDocumentStoreGuids = new List<Guid>(),
      Saved = false
    };
    this.ExecuteRequestCloseCommand((object) new CloseObject()
    {
      mgaObject = RuntimeHelpers.GetObjectValue(imsObject),
      calledFrom = "CancelCommand"
    });
  }

  public ICommand AddCommand
  {
    get
    {
      if (this._addCommand == null)
        this._addCommand = (ICommand) new RelayCommand<AddDocuments>((Action<AddDocuments>) ([SpecialName] (param) => this.Add((object) param)), (Predicate<AddDocuments>) ([SpecialName] (param) => this.CanExecuteAdd()));
      return this._addCommand;
    }
  }

  private void Add(object imsObject)
  {
    try
    {
      foreach (AdditionalDoc selectedDocument in (Collection<AdditionalDoc>) this.SelectedDocuments)
        selectedDocument.Added = true;
    }
    finally
    {
      IEnumerator<AdditionalDoc> enumerator;
      enumerator?.Dispose();
    }
    ObservableCollection<AdditionalDoc> availableDocuments = this.AvailableDocuments;
    Func<AdditionalDoc, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (AddDocumentsViewModel._Closure\u0024__.\u0024I85\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = AddDocumentsViewModel._Closure\u0024__.\u0024I85\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      AddDocumentsViewModel._Closure\u0024__.\u0024I85\u002D0 = predicate = (Func<AdditionalDoc, bool>) ([SpecialName] (d) => !d.Added);
    }
    this.SelectedDocument = availableDocuments.Where<AdditionalDoc>(predicate).FirstOrDefault<AdditionalDoc>();
    this.AvailableDocCVS.View.Refresh();
    this.AddedDocCVS.View.Refresh();
  }

  private bool CanExecuteAdd()
  {
    return this.SelectedDocuments != null && this.SelectedDocuments.Count > 0;
  }

  public ICommand AddAllCommand
  {
    get
    {
      if (this._addAllCommand == null)
        this._addAllCommand = (ICommand) new RelayCommand<AddDocuments>((Action<AddDocuments>) ([SpecialName] (param) => this.AddAll((object) param)), (Predicate<AddDocuments>) ([SpecialName] (param) => this.CanExecuteAddAll()));
      return this._addAllCommand;
    }
  }

  private void AddAll(object imsObject)
  {
    try
    {
      foreach (AdditionalDoc availableDocument in (Collection<AdditionalDoc>) this.AvailableDocuments)
        availableDocument.Added = true;
    }
    finally
    {
      IEnumerator<AdditionalDoc> enumerator;
      enumerator?.Dispose();
    }
    this.AvailableDocCVS.View.Refresh();
    this.AddedDocCVS.View.Refresh();
  }

  private bool CanExecuteAddAll() => true;

  public ICommand RemoveCommand
  {
    get
    {
      if (this._removeCommand == null)
        this._removeCommand = (ICommand) new RelayCommand<AddDocuments>((Action<AddDocuments>) ([SpecialName] (param) => this.Remove((object) param)), (Predicate<AddDocuments>) ([SpecialName] (param) => this.CanExecuteRemove()));
      return this._removeCommand;
    }
  }

  private void Remove(object imsObject)
  {
    try
    {
      foreach (AdditionalDoc selectedAddedDocument in (Collection<AdditionalDoc>) this.SelectedAddedDocuments)
        selectedAddedDocument.Added = false;
    }
    finally
    {
      IEnumerator<AdditionalDoc> enumerator;
      enumerator?.Dispose();
    }
    ObservableCollection<AdditionalDoc> availableDocuments = this.AvailableDocuments;
    Func<AdditionalDoc, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (AddDocumentsViewModel._Closure\u0024__.\u0024I95\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = AddDocumentsViewModel._Closure\u0024__.\u0024I95\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      AddDocumentsViewModel._Closure\u0024__.\u0024I95\u002D0 = predicate = (Func<AdditionalDoc, bool>) ([SpecialName] (d) => d.Added);
    }
    this.SelectedAddedDoc = availableDocuments.Where<AdditionalDoc>(predicate).FirstOrDefault<AdditionalDoc>();
    this.AvailableDocCVS.View.Refresh();
    this.AddedDocCVS.View.Refresh();
  }

  private bool CanExecuteRemove()
  {
    return this.SelectedAddedDocuments != null && this.SelectedAddedDocuments.Count > 0;
  }

  public ICommand BrowseCommand
  {
    get
    {
      if (this._browseCommand == null)
        this._browseCommand = (ICommand) new RelayCommand<AddDocuments>((Action<AddDocuments>) ([SpecialName] (param) => this.Browse((object) param)), (Predicate<AddDocuments>) ([SpecialName] (param) => this.CanExecuteBrowse()));
      return this._browseCommand;
    }
  }

  private void Browse(object imsObject)
  {
    if (this._dialogSvc == null)
      this._dialogSvc = (IWin32DialogService) new Win32DialogService();
    List<string> stringList = this._dialogSvc.OpenMultiFileDialog("");
    try
    {
      foreach (string fileName in stringList)
      {
        DocListItem _docListItemTag = new DocListItem(fileName);
        this.AvailableDocuments.Add(AdditionalDoc.Create(_docListItemTag.DocumentStoreGuid, _docListItemTag.ToString(), _docListItemTag.Filename, _docListItemTag.Editable, false, _docListItemTag.AttachmentFileName, (object) _docListItemTag, string.Empty));
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private bool CanExecuteBrowse() => true;

  protected void SetAdditionalDocuments()
  {
    List<DocListItem> docListItemList1 = new List<DocListItem>();
    if (this._quote != null)
      docListItemList1 = AdditionalDoc.GetDocItemList(this._quote.ControlGuid);
    List<DocListItem> docListItemList2 = this.AddAdditionalDocuments();
    if (docListItemList2 != null)
    {
      try
      {
        foreach (DocListItem docListItem in docListItemList2)
          docListItemList1.Add(docListItem);
      }
      finally
      {
        List<DocListItem>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    try
    {
      foreach (DocListItem _docListItemTag in docListItemList1)
        this.AvailableDocuments.Add(AdditionalDoc.Create(_docListItemTag.DocumentStoreGuid, _docListItemTag.ToString(), _docListItemTag.Filename, _docListItemTag.Editable, false, _docListItemTag.AttachmentFileName, (object) _docListItemTag, _docListItemTag.FolderName));
    }
    finally
    {
      List<DocListItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
    ObservableCollection<AdditionalDoc> availableDocuments = this.AvailableDocuments;
    Func<AdditionalDoc, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (AddDocumentsViewModel._Closure\u0024__.\u0024I102\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = AddDocumentsViewModel._Closure\u0024__.\u0024I102\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      AddDocumentsViewModel._Closure\u0024__.\u0024I102\u002D0 = predicate = (Func<AdditionalDoc, bool>) ([SpecialName] (d) => !d.Added);
    }
    this.SelectedDocument = availableDocuments.Where<AdditionalDoc>(predicate).FirstOrDefault<AdditionalDoc>();
  }

  protected void SetCVS()
  {
    this.AvailableDocCVS = new CollectionViewSource();
    this.AddedDocCVS = new CollectionViewSource();
    this.AvailableDocCVS.Filter += (FilterEventHandler) ([SpecialName] (s, e) =>
    {
      AdditionalDoc additionalDoc = e.Item as AdditionalDoc;
      bool flag1 = string.IsNullOrEmpty(this.FilterAvailableDescription) || additionalDoc.Description.ToLower().Contains(this.FilterAvailableDescription.ToLower());
      bool flag2 = string.IsNullOrEmpty(this.FilterAvailableFolderName) || additionalDoc.FolderName != null && additionalDoc.FolderName.ToLower().Contains(this.FilterAvailableFolderName.ToLower());
      e.Accepted = !additionalDoc.Added && flag1 && flag2;
    });
    this.AddedDocCVS.Filter += (FilterEventHandler) ([SpecialName] (s, e) =>
    {
      AdditionalDoc additionalDoc = e.Item as AdditionalDoc;
      bool flag3 = string.IsNullOrEmpty(this.FilterAddedDescription) || additionalDoc.Description.ToLower().Contains(this.FilterAddedDescription.ToLower());
      bool flag4 = string.IsNullOrEmpty(this.FilterAddedFileName) || additionalDoc.AttachmentFileName.ToLower().Contains(this.FilterAddedFileName.ToLower());
      bool flag5 = string.IsNullOrEmpty(this.FilterAddedFolderName) || additionalDoc.FolderName != null && additionalDoc.FolderName.ToLower().Contains(this.FilterAddedFolderName.ToLower());
      e.Accepted = additionalDoc.Added && flag3 && flag4 && flag5;
    });
    this.AvailableDocCVS.Source = (object) this.AvailableDocuments;
    this.AddedDocCVS.Source = (object) this.AvailableDocuments;
  }

  protected virtual List<DocListItem> AddAdditionalDocuments() => (List<DocListItem>) null;

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    if (Operators.CompareString(propertyName, "FilterAvailableDescription", false) == 0 || Operators.CompareString(propertyName, "FilterAvailableFolderName", false) == 0)
    {
      this.AvailableDocCVS.View.Refresh();
    }
    else
    {
      if (Operators.CompareString(propertyName, "FilterAddedDescription", false) != 0 && Operators.CompareString(propertyName, "FilterAddedFileName", false) != 0 && Operators.CompareString(propertyName, "FilterAddedFolderName", false) != 0)
        return;
      this.AddedDocCVS.View.Refresh();
    }
  }
}
