// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SearchSelect.DocumentTemplateMetaData.SearchSelectDocumentTemplateForm
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.UserInterface;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SearchSelect.DocumentTemplateMetaData;

public class SearchSelectDocumentTemplateForm : 
  SelectSearchForm<DocumentTemplateMetaDataDto, ISearchSelectDocumentTemplateController, ISearchSelectModel<DocumentTemplateMetaDataDto>>
{
  private readonly DocumentTemplateMetaDataDto _selectedItem;
  private readonly DocumentTemplateMetaDataDto[] _templates;

  public SearchSelectDocumentTemplateForm(
    DocumentTemplateMetaDataDto selectedItem,
    DocumentTemplateMetaDataDto[] templates)
  {
    this._selectedItem = selectedItem;
    this._templates = templates ?? throw new ArgumentNullException(nameof (templates));
  }

  protected override ISearchSelectDocumentTemplateController ChildCreateController()
  {
    return ObjectFactory.Instance.CreateObjectAs<ISearchSelectDocumentTemplateController>();
  }

  protected override ISearchSelectModel<DocumentTemplateMetaDataDto> ChildCreateModel()
  {
    return (ISearchSelectModel<DocumentTemplateMetaDataDto>) new SearchSelectModel<DocumentTemplateMetaDataDto>(this._templates, this._selectedItem, true);
  }

  public bool HasSelection => this.DialogResult == DialogResult.OK && this.Model.HasSelectedItem();

  public DocumentTemplateMetaDataDto Selection
  {
    get
    {
      if (this.DialogResult != DialogResult.OK)
        throw new InvalidOperationException("The form was cancelled!");
      return this.Model.SelectedItem;
    }
  }
}
