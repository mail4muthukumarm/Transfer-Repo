// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpensePayeeListItem
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpensePayeeListItem : UserControl
{
  private System.ComponentModel.Container components;
  private PictureBox pictureBox1;
  private Label label2;
  private Label labelPayeeName;
  private LinkLabel linkView;
  private Guid _payeeGuid;
  private string _payeeName;
  private string _address1;
  private string _address2;
  private string _city;
  private string _state;
  private string _zipCode;
  private string _zipExt;
  private string _phone1;
  private string _phone2;
  private string _fax;
  private string _email;
  private LinkLabel linkViewInformation;
  private string _payeeAccountNumber;

  private ExpensePayeeListItem() => this.InitializeComponent();

  public ExpensePayeeListItem(
    Guid payeeGuid,
    string payeeName,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipExt,
    string phone1,
    string phone2,
    string fax,
    string email,
    string payeeAccountNumber)
  {
    this.InitializeComponent();
    this._payeeGuid = payeeGuid;
    this._payeeName = payeeName;
    this._address1 = address1;
    this._address2 = address2;
    this._city = city;
    this._state = state;
    this._zipCode = zipCode;
    this._zipExt = zipExt;
    this._phone1 = phone1;
    this._phone2 = phone2;
    this._fax = fax;
    this._email = email;
    this._payeeAccountNumber = payeeAccountNumber;
    if (this.PayeeAccountNumber.Equals(string.Empty))
      this.labelPayeeName.Text = this.PayeeName;
    else
      this.labelPayeeName.Text = $"{this.PayeeName}    Account #: {this.PayeeAccountNumber}";
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (ExpensePayeeListItem));
    this.pictureBox1 = new PictureBox();
    this.label2 = new Label();
    this.labelPayeeName = new Label();
    this.linkView = new LinkLabel();
    this.linkViewInformation = new LinkLabel();
    this.SuspendLayout();
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.Dock = DockStyle.Left;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Dock = DockStyle.Bottom;
    this.label2.Location = new Point(0, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(520, 1);
    this.label2.TabIndex = 2;
    this.label2.TextAlign = ContentAlignment.MiddleLeft;
    this.labelPayeeName.BackColor = Color.White;
    this.labelPayeeName.Dock = DockStyle.Fill;
    this.labelPayeeName.Font = new Font("Tahoma", 8f);
    this.labelPayeeName.Location = new Point(32 /*0x20*/, 0);
    this.labelPayeeName.Name = "labelPayeeName";
    this.labelPayeeName.Size = new Size(488, 32 /*0x20*/);
    this.labelPayeeName.TabIndex = 1;
    this.labelPayeeName.Text = "[PayeeName]";
    this.labelPayeeName.TextAlign = ContentAlignment.MiddleLeft;
    this.labelPayeeName.UseMnemonic = false;
    this.linkView.Dock = DockStyle.Right;
    this.linkView.Location = new Point(488, 0);
    this.linkView.Name = "linkView";
    this.linkView.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.linkView.TabIndex = 3;
    this.linkView.TabStop = true;
    this.linkView.Text = "View";
    this.linkView.TextAlign = ContentAlignment.MiddleCenter;
    this.linkView.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkView_LinkClicked);
    this.linkViewInformation.Dock = DockStyle.Right;
    this.linkViewInformation.Location = new Point(344, 0);
    this.linkViewInformation.Name = "linkViewInformation";
    this.linkViewInformation.Size = new Size(144 /*0x90*/, 32 /*0x20*/);
    this.linkViewInformation.TabIndex = 4;
    this.linkViewInformation.TabStop = true;
    this.linkViewInformation.Text = "View Vendor Transactions";
    this.linkViewInformation.TextAlign = ContentAlignment.MiddleCenter;
    this.linkViewInformation.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkViewInformation_LinkClicked);
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.linkViewInformation);
    this.Controls.Add((Control) this.linkView);
    this.Controls.Add((Control) this.labelPayeeName);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this.label2);
    this.Font = new Font("Tahoma", 8f);
    this.Name = nameof (ExpensePayeeListItem);
    this.Size = new Size(520, 33);
    this.ResumeLayout(false);
  }

  public Guid PayeeGuid => this._payeeGuid;

  public string PayeeName
  {
    get => this._payeeName;
    set => this._payeeName = value;
  }

  public string Address1
  {
    get => this._address1;
    set => this._address1 = value;
  }

  public string Address2
  {
    get => this._address2;
    set => this._address2 = value;
  }

  public string City
  {
    get => this._city;
    set => this._city = value;
  }

  public string State
  {
    get => this._state;
    set => this._state = value;
  }

  public string ZipCode
  {
    get => this._zipCode;
    set => this._zipCode = value;
  }

  public string ZipExt
  {
    get => this._zipExt;
    set => this._zipExt = value;
  }

  public string Phone1
  {
    get => this._phone1;
    set => this._phone1 = value;
  }

  public string Phone2
  {
    get => this._phone2;
    set => this._phone2 = value;
  }

  public string Fax
  {
    get => this._fax;
    set => this._fax = value;
  }

  public string EmailAddress
  {
    get => this._email;
    set => this._email = value;
  }

  public string PayeeAccountNumber
  {
    get => this._payeeAccountNumber;
    set => this._payeeAccountNumber = value;
  }

  public event ExpensePayeeListItem.PayeeListItemViewClickedHandler ViewClicked;

  protected void OnViewClicked()
  {
    if (this.ViewClicked == null)
      return;
    this.ViewClicked((object) this, new PayeeListItemViewClickedEventArgs(this.PayeeGuid, this.PayeeName, this.Address1, this.Address2, this.City, this.State, this.ZipCode, this.ZipExt, this.Phone1, this.Phone2, this.Fax, this.EmailAddress));
  }

  public event ExpensePayeeListItem.ViewVendorInformationClickedHandler ViewVendorInfomationClicked;

  protected void OnVendorInformationClicked()
  {
    if (this.ViewVendorInfomationClicked == null)
      return;
    this.ViewVendorInfomationClicked((object) this, new ViewVendorInformationClickedEventArgs(this._payeeGuid));
  }

  private void linkView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.OnViewClicked();
  }

  private void linkViewInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.OnVendorInformationClicked();
  }

  public delegate void PayeeListItemViewClickedHandler(
    object sender,
    PayeeListItemViewClickedEventArgs e);

  public delegate void ViewVendorInformationClickedHandler(
    object sender,
    ViewVendorInformationClickedEventArgs e);
}
