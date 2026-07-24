// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View.AddressView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.AppStyling.Runtime;
using MGASystems.AddressResolver;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.Address.View;

public class AddressView : 
  MvcViewBase<IAddressModel, IAddressController>,
  IAddressView,
  IMvcView,
  IModelObserver
{
  private BlockingRunner _zipcodeUpdateRunner = new BlockingRunner();
  private const string DefaultISO = "USA";
  private IContainer components;
  private AppStylistRuntime appStylistRuntime1;
  private AddressResolver_MULTI addressResolverMulti;

  public AddressView() => this.InitializeComponent();

  public void UserSetAddress1(string address1)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetAddress1(address1 ?? throw new ArgumentNullException(nameof (address1)));
  }

  public void UserSetAddress2(string address2)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetAddress2(address2 ?? throw new ArgumentNullException(nameof (address2)));
  }

  public void UserSetCity(string city)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetCity(city ?? throw new ArgumentNullException(nameof (city)));
  }

  public void UserSetState(string state)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetState(state ?? throw new ArgumentNullException(nameof (state)));
  }

  public void UserSetZipCode(string zipCode)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetZipCode(zipCode ?? throw new ArgumentNullException(nameof (zipCode)));
  }

  public void UserSetZipCodeExtension(string zipCodeExtension)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetZipCodeExtension(zipCodeExtension ?? throw new ArgumentNullException(nameof (zipCodeExtension)));
  }

  public void UserSetISOCountryCode(string isoCountryCode)
  {
    IAddressController controller = this.Controller;
    controller.RequestSetISOCountryCode(isoCountryCode ?? throw new ArgumentNullException(nameof (isoCountryCode)));
  }

  protected override void ChildWireUp()
  {
    this.addressResolverMulti.ZipCodeChanged += new EventHandler(this.OnZipCodeChanged);
    this.addressResolverMulti.ZipCodeExtChanged += new EventHandler(this.OnZipCodeExtensionChanged);
    this.addressResolverMulti.CityChanged += new EventHandler(this.OnCityChanged);
    this.addressResolverMulti.StateChanged += new EventHandler(this.OnStateChanged);
    this.addressResolverMulti.Address1Changed += new EventHandler(this.OnAddress1Changed);
    this.addressResolverMulti.Address2Changed += new EventHandler(this.OnAddress2Changed);
    this.addressResolverMulti.ZipCodeLookupCompleted += new AddressResolver_MULTI.FocusOnZipEventHandler(this.AddressResolverMulti_ZipCodeLookupCompleted);
    this.addressResolverMulti.CountryChanged += new EventHandler(this.OnISOCountryCodeChanged);
  }

  protected override void ChildUpdateFromModel(IAddressModel model)
  {
    if (this._zipcodeUpdateRunner.IsRunning)
      return;
    this.addressResolverMulti.Address1 = model.Address1;
    this.addressResolverMulti.Address2 = model.Address2;
    this.addressResolverMulti.City = model.City;
    this.addressResolverMulti.State = model.State;
    this.addressResolverMulti.ZipCode = model.ZipCode;
    this.addressResolverMulti.ZipCodeExtension = model.ZipCodeExtension;
    this.addressResolverMulti.ISOCountryCode = model.CountryCode;
  }

  protected override void ChildUnWireUp()
  {
    this.addressResolverMulti.Address1 = string.Empty;
    this.addressResolverMulti.Address2 = string.Empty;
    this.addressResolverMulti.City = string.Empty;
    this.addressResolverMulti.State = string.Empty;
    this.addressResolverMulti.ISOCountryCode = "USA";
    this.addressResolverMulti.ZipCode = string.Empty;
    this.addressResolverMulti.ZipCodeExtension = string.Empty;
  }

  private void AddressResolverMulti_ZipCodeLookupCompleted(
    object sender,
    ZipLookupCompletedEventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this._zipcodeUpdateRunner.Run((Action) (() =>
    {
      this.UserSetState(this.addressResolverMulti.State);
      this.UserSetCity(this.addressResolverMulti.City);
    }))));
  }

  private void OnAddress1Changed(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetAddress1(this.addressResolverMulti.Address1)));
  }

  private void OnAddress2Changed(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetAddress2(this.addressResolverMulti.Address2)));
  }

  private void OnCityChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetCity(this.addressResolverMulti.City)));
  }

  private void OnStateChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetState(this.addressResolverMulti.State)));
  }

  private void OnZipCodeChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetZipCode(this.addressResolverMulti.ZipCode)));
  }

  private void OnZipCodeExtensionChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetZipCodeExtension(this.addressResolverMulti.ZipCodeExtension)));
  }

  private void OnISOCountryCodeChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetISOCountryCode(this.addressResolverMulti.ISOCountryCode)));
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.appStylistRuntime1 = new AppStylistRuntime(this.components);
    this.addressResolverMulti = new AddressResolver_MULTI();
    this.SuspendLayout();
    this.addressResolverMulti.Address1 = "";
    this.addressResolverMulti.Address2 = "";
    ((Control) this.addressResolverMulti).BackColor = Color.Transparent;
    this.addressResolverMulti.City = "";
    this.addressResolverMulti.County = "";
    ((Control) this.addressResolverMulti).Font = new Font("Tahoma", 8f);
    this.addressResolverMulti.ISOCountryCode = "";
    this.addressResolverMulti.ISOCountryCodeMember = "";
    this.addressResolverMulti.ISOCountryList = (object) null;
    this.addressResolverMulti.ISOCountryNameMember = "";
    ((Control) this.addressResolverMulti).Location = new Point(1, 0);
    ((Control) this.addressResolverMulti).Margin = new Padding(0);
    this.addressResolverMulti.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressResolverMulti).Name = "addressResolverMulti";
    this.addressResolverMulti.Password = (string) null;
    ((Control) this.addressResolverMulti).Size = new Size(270, 152);
    this.addressResolverMulti.State = "";
    ((Control) this.addressResolverMulti).TabIndex = 5;
    this.addressResolverMulti.TextAlign = ContentAlignment.TopLeft;
    this.addressResolverMulti.UserID = (string) null;
    this.addressResolverMulti.WebserviceUrl = (string) null;
    this.addressResolverMulti.ZipCode = "";
    this.addressResolverMulti.ZipCodeExtension = "";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.addressResolverMulti);
    this.Name = nameof (AddressView);
    this.Size = new Size(270, 154);
    this.ResumeLayout(false);
  }
}
