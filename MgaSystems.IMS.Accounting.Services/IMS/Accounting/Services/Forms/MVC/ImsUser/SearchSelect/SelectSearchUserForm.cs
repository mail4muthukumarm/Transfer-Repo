// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.SearchSelect.SelectSearchUserForm
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.UserInterface;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.SearchSelect;

public class SelectSearchUserForm : 
  SelectSearchForm<ImsUserDto, ISearchSelectImsUserController, ISearchSelectModel<ImsUserDto>>
{
  private readonly ImsUserDto _selectedItem;
  private readonly ImsUserDto[] _users;

  public SelectSearchUserForm(ImsUserDto selectedItem, ImsUserDto[] users)
  {
    this._selectedItem = selectedItem;
    this._users = users ?? throw new ArgumentNullException(nameof (users));
  }

  protected override ISearchSelectImsUserController ChildCreateController()
  {
    return ObjectFactory.Instance.CreateObjectAs<ISearchSelectImsUserController>();
  }

  protected override ISearchSelectModel<ImsUserDto> ChildCreateModel()
  {
    return (ISearchSelectModel<ImsUserDto>) new SearchSelectModel<ImsUserDto>(this._users, this._selectedItem, true);
  }

  public bool HasSelection => this.DialogResult == DialogResult.OK && this.Model.HasSelectedItem();

  public ImsUserDto Selection
  {
    get
    {
      if (this.DialogResult != DialogResult.OK)
        throw new InvalidOperationException("The form was cancelled!");
      return this.Model.SelectedItem;
    }
  }
}
