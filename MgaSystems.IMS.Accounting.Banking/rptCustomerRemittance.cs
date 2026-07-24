// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.rptCustomerRemittance
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Data;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class rptCustomerRemittance : SectionReport
{
  private int _intTransactNum;
  public SqlDBDataSource ds;
  private Label lblTitle;
  private Label lblDate;
  private TextBox txtBankAddress;
  private TextBox txtBankName;
  private TextBox txtDate;
  private Label Label1;
  private TextBox txtAmount;
  private Line Line1;
  private Label lblOaddress;
  private Label lblOname;
  private Label lblOacctnum;
  private Label lblOcontact;
  private Label lblOphone;
  private Label lblOcphone;
  private Label lblBaddress;
  private Label lblBname;
  private Label lblBcontact;
  private Label lblBphone;
  private Label lblBContactPhone;
  private Label lblBacct;
  private Label lblBbankname;
  private Label lblBabarouting;
  private Label lblBAddress2;
  private Label lblIbeneficiary;
  private Label lblIbankmemo;
  private TextBox txtIbeneficiary;
  private TextBox txtIbankmemo;
  private TextBox txtBBankName;
  private TextBox txtBAccountNum;
  private TextBox txtBAbaNum;
  private TextBox txtBPhone;
  private TextBox txtBContact;
  private TextBox txtBAddress2;
  private TextBox txtBContactPhone;
  private TextBox txtBAddress;
  private TextBox txtOphone;
  private TextBox txtOcontact;
  private TextBox txtOcontactphone;
  private TextBox txtOaccount;
  private TextBox txtOaddress;
  private Label Label2;
  private Line Line2;
  private Label Label3;
  private Line Line3;
  private Label Label4;
  private Line Line4;
  private Label lblSignature;
  private Label lblAddress;
  private Label lblPhone;
  private Label lblbtmDate;
  private TextBox txtPhone;
  private TextBox txtbtmDate;

  public rptCustomerRemittance(int intTransactNum)
  {
    this.InitializeComponent();
    this._intTransactNum = intTransactNum;
    this.Document.Name = "Customer Remittance Request";
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataTable dataTable1 = new DataTable();
    selectCommand.CommandText = "[spFin_ReportPayableFax]";
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Connection = sqlConnection;
    selectCommand.Parameters.AddWithValue("@TRANSACTNUM", (object) this._intTransactNum);
    DataTable dataTable2 = dataTable1;
    sqlDataAdapter.Fill(dataTable2);
    this.DataSource = (object) dataTable1;
    this.PageSettings.Margins.Left = 0.7f;
    this.PageSettings.Margins.Right = 0.7f;
    this.PageSettings.Margins.Top = 0.7f;
    this.PageSettings.Margins.Bottom = 0.7f;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptCustomerRemittance));
    SqlDBDataSource sqlDbDataSource = new SqlDBDataSource();
    this.Detail = new Detail();
    this.lblOaddress = new Label();
    this.lblOname = new Label();
    this.lblOacctnum = new Label();
    this.lblOcontact = new Label();
    this.lblOphone = new Label();
    this.lblOcphone = new Label();
    this.lblBaddress = new Label();
    this.lblBname = new Label();
    this.lblBcontact = new Label();
    this.lblBphone = new Label();
    this.lblBContactPhone = new Label();
    this.lblBacct = new Label();
    this.lblBbankname = new Label();
    this.lblBabarouting = new Label();
    this.lblBAddress2 = new Label();
    this.lblIbeneficiary = new Label();
    this.lblIbankmemo = new Label();
    this.txtIbeneficiary = new TextBox();
    this.txtIbankmemo = new TextBox();
    this.txtBBankName = new TextBox();
    this.txtBAccountNum = new TextBox();
    this.txtBAbaNum = new TextBox();
    this.txtBPhone = new TextBox();
    this.txtBContact = new TextBox();
    this.txtBAddress2 = new TextBox();
    this.txtBContactPhone = new TextBox();
    this.txtBAddress = new TextBox();
    this.txtOphone = new TextBox();
    this.txtOcontact = new TextBox();
    this.txtOcontactphone = new TextBox();
    this.txtOaccount = new TextBox();
    this.txtOaddress = new TextBox();
    this.Label2 = new Label();
    this.Line2 = new Line();
    this.Label3 = new Label();
    this.Line3 = new Line();
    this.Label4 = new Label();
    this.Line4 = new Line();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.lblDate = new Label();
    this.txtBankAddress = new TextBox();
    this.txtBankName = new TextBox();
    this.txtDate = new TextBox();
    this.Label1 = new Label();
    this.txtAmount = new TextBox();
    this.Line1 = new Line();
    this.ReportFooter = new ReportFooter();
    this.lblSignature = new Label();
    this.lblAddress = new Label();
    this.lblPhone = new Label();
    this.lblbtmDate = new Label();
    this.txtPhone = new TextBox();
    this.txtbtmDate = new TextBox();
    ((ISupportInitialize) this.lblOaddress).BeginInit();
    ((ISupportInitialize) this.lblOname).BeginInit();
    ((ISupportInitialize) this.lblOacctnum).BeginInit();
    ((ISupportInitialize) this.lblOcontact).BeginInit();
    ((ISupportInitialize) this.lblOphone).BeginInit();
    ((ISupportInitialize) this.lblOcphone).BeginInit();
    ((ISupportInitialize) this.lblBaddress).BeginInit();
    ((ISupportInitialize) this.lblBname).BeginInit();
    ((ISupportInitialize) this.lblBcontact).BeginInit();
    ((ISupportInitialize) this.lblBphone).BeginInit();
    ((ISupportInitialize) this.lblBContactPhone).BeginInit();
    ((ISupportInitialize) this.lblBacct).BeginInit();
    ((ISupportInitialize) this.lblBbankname).BeginInit();
    ((ISupportInitialize) this.lblBabarouting).BeginInit();
    ((ISupportInitialize) this.lblBAddress2).BeginInit();
    ((ISupportInitialize) this.lblIbeneficiary).BeginInit();
    ((ISupportInitialize) this.lblIbankmemo).BeginInit();
    ((ISupportInitialize) this.txtIbeneficiary).BeginInit();
    ((ISupportInitialize) this.txtIbankmemo).BeginInit();
    ((ISupportInitialize) this.txtBBankName).BeginInit();
    ((ISupportInitialize) this.txtBAccountNum).BeginInit();
    ((ISupportInitialize) this.txtBAbaNum).BeginInit();
    ((ISupportInitialize) this.txtBPhone).BeginInit();
    ((ISupportInitialize) this.txtBContact).BeginInit();
    ((ISupportInitialize) this.txtBAddress2).BeginInit();
    ((ISupportInitialize) this.txtBContactPhone).BeginInit();
    ((ISupportInitialize) this.txtBAddress).BeginInit();
    ((ISupportInitialize) this.txtOphone).BeginInit();
    ((ISupportInitialize) this.txtOcontact).BeginInit();
    ((ISupportInitialize) this.txtOcontactphone).BeginInit();
    ((ISupportInitialize) this.txtOaccount).BeginInit();
    ((ISupportInitialize) this.txtOaddress).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.txtBankAddress).BeginInit();
    ((ISupportInitialize) this.txtBankName).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.lblSignature).BeginInit();
    ((ISupportInitialize) this.lblAddress).BeginInit();
    ((ISupportInitialize) this.lblPhone).BeginInit();
    ((ISupportInitialize) this.lblbtmDate).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.txtbtmDate).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[38]
    {
      (ARControl) this.lblOaddress,
      (ARControl) this.lblOname,
      (ARControl) this.lblOacctnum,
      (ARControl) this.lblOcontact,
      (ARControl) this.lblOphone,
      (ARControl) this.lblOcphone,
      (ARControl) this.lblBaddress,
      (ARControl) this.lblBname,
      (ARControl) this.lblBcontact,
      (ARControl) this.lblBphone,
      (ARControl) this.lblBContactPhone,
      (ARControl) this.lblBacct,
      (ARControl) this.lblBbankname,
      (ARControl) this.lblBabarouting,
      (ARControl) this.lblBAddress2,
      (ARControl) this.lblIbeneficiary,
      (ARControl) this.lblIbankmemo,
      (ARControl) this.txtIbeneficiary,
      (ARControl) this.txtIbankmemo,
      (ARControl) this.txtBBankName,
      (ARControl) this.txtBAccountNum,
      (ARControl) this.txtBAbaNum,
      (ARControl) this.txtBPhone,
      (ARControl) this.txtBContact,
      (ARControl) this.txtBAddress2,
      (ARControl) this.txtBContactPhone,
      (ARControl) this.txtBAddress,
      (ARControl) this.txtOphone,
      (ARControl) this.txtOcontact,
      (ARControl) this.txtOcontactphone,
      (ARControl) this.txtOaccount,
      (ARControl) this.txtOaddress,
      (ARControl) this.Label2,
      (ARControl) this.Line2,
      (ARControl) this.Label3,
      (ARControl) this.Line3,
      (ARControl) this.Label4,
      (ARControl) this.Line4
    });
    ((Section) this.Detail).Height = 7.040972f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.lblOaddress).Height = 3f / 16f;
    this.lblOaddress.HyperLink = (string) null;
    ((ARControl) this.lblOaddress).Left = 0.0f;
    ((ARControl) this.lblOaddress).Name = "lblOaddress";
    this.lblOaddress.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblOaddress.Text = "Address:";
    ((ARControl) this.lblOaddress).Top = 0.75f;
    ((ARControl) this.lblOaddress).Width = 31f / 16f;
    ((ARControl) this.lblOname).Height = 3f / 16f;
    this.lblOname.HyperLink = (string) null;
    ((ARControl) this.lblOname).Left = 0.0f;
    ((ARControl) this.lblOname).Name = "lblOname";
    this.lblOname.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblOname.Text = "Name:";
    ((ARControl) this.lblOname).Top = 9f / 16f;
    ((ARControl) this.lblOname).Width = 31f / 16f;
    ((ARControl) this.lblOacctnum).Height = 3f / 16f;
    this.lblOacctnum.HyperLink = (string) null;
    ((ARControl) this.lblOacctnum).Left = 0.0f;
    ((ARControl) this.lblOacctnum).Name = "lblOacctnum";
    this.lblOacctnum.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblOacctnum.Text = "Account #:";
    ((ARControl) this.lblOacctnum).Top = 0.375f;
    ((ARControl) this.lblOacctnum).Width = 31f / 16f;
    ((ARControl) this.lblOcontact).Height = 3f / 16f;
    this.lblOcontact.HyperLink = (string) null;
    ((ARControl) this.lblOcontact).Left = 0.0f;
    ((ARControl) this.lblOcontact).Name = "lblOcontact";
    this.lblOcontact.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblOcontact.Text = "Contact:";
    ((ARControl) this.lblOcontact).Top = 27f / 16f;
    ((ARControl) this.lblOcontact).Width = 31f / 16f;
    ((ARControl) this.lblOphone).Height = 3f / 16f;
    this.lblOphone.HyperLink = (string) null;
    ((ARControl) this.lblOphone).Left = 0.0f;
    ((ARControl) this.lblOphone).Name = "lblOphone";
    this.lblOphone.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblOphone.Text = "Phone #:";
    ((ARControl) this.lblOphone).Top = 1.5f;
    ((ARControl) this.lblOphone).Width = 31f / 16f;
    ((ARControl) this.lblOcphone).Height = 3f / 16f;
    this.lblOcphone.HyperLink = (string) null;
    ((ARControl) this.lblOcphone).Left = 0.0f;
    ((ARControl) this.lblOcphone).Name = "lblOcphone";
    this.lblOcphone.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblOcphone.Text = "Contact Phone:";
    ((ARControl) this.lblOcphone).Top = 1.875f;
    ((ARControl) this.lblOcphone).Width = 31f / 16f;
    ((ARControl) this.lblBaddress).Height = 3f / 16f;
    this.lblBaddress.HyperLink = (string) null;
    ((ARControl) this.lblBaddress).Left = 0.0f;
    ((ARControl) this.lblBaddress).Name = "lblBaddress";
    this.lblBaddress.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBaddress.Text = "Address:";
    ((ARControl) this.lblBaddress).Top = 45f / 16f;
    ((ARControl) this.lblBaddress).Width = 31f / 16f;
    ((ARControl) this.lblBname).Height = 3f / 16f;
    this.lblBname.HyperLink = (string) null;
    ((ARControl) this.lblBname).Left = 0.0f;
    ((ARControl) this.lblBname).Name = "lblBname";
    this.lblBname.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBname.Text = "Name";
    ((ARControl) this.lblBname).Top = 2.625f;
    ((ARControl) this.lblBname).Width = 31f / 16f;
    ((ARControl) this.lblBcontact).Height = 3f / 16f;
    this.lblBcontact.HyperLink = (string) null;
    ((ARControl) this.lblBcontact).Left = 0.0f;
    ((ARControl) this.lblBcontact).Name = "lblBcontact";
    this.lblBcontact.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBcontact.Text = "Contact:";
    ((ARControl) this.lblBcontact).Top = 3.75f;
    ((ARControl) this.lblBcontact).Width = 31f / 16f;
    ((ARControl) this.lblBphone).Height = 3f / 16f;
    this.lblBphone.HyperLink = (string) null;
    ((ARControl) this.lblBphone).Left = 0.0f;
    ((ARControl) this.lblBphone).Name = "lblBphone";
    this.lblBphone.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBphone.Text = "Phone #:";
    ((ARControl) this.lblBphone).Top = 57f / 16f;
    ((ARControl) this.lblBphone).Width = 31f / 16f;
    ((ARControl) this.lblBContactPhone).Height = 3f / 16f;
    this.lblBContactPhone.HyperLink = (string) null;
    ((ARControl) this.lblBContactPhone).Left = 0.0f;
    ((ARControl) this.lblBContactPhone).Name = "lblBContactPhone";
    this.lblBContactPhone.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBContactPhone.Text = "Contact Phone:";
    ((ARControl) this.lblBContactPhone).Top = 63f / 16f;
    ((ARControl) this.lblBContactPhone).Width = 31f / 16f;
    ((ARControl) this.lblBacct).Height = 3f / 16f;
    this.lblBacct.HyperLink = (string) null;
    ((ARControl) this.lblBacct).Left = 0.0f;
    ((ARControl) this.lblBacct).Name = "lblBacct";
    this.lblBacct.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBacct.Text = "Account #:";
    ((ARControl) this.lblBacct).Top = 4.5f;
    ((ARControl) this.lblBacct).Width = 31f / 16f;
    ((ARControl) this.lblBbankname).Height = 3f / 16f;
    this.lblBbankname.HyperLink = (string) null;
    ((ARControl) this.lblBbankname).Left = 0.0f;
    ((ARControl) this.lblBbankname).Name = "lblBbankname";
    this.lblBbankname.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBbankname.Text = "Bank Name:";
    ((ARControl) this.lblBbankname).Top = 69f / 16f;
    ((ARControl) this.lblBbankname).Width = 31f / 16f;
    ((ARControl) this.lblBabarouting).Height = 3f / 16f;
    this.lblBabarouting.HyperLink = (string) null;
    ((ARControl) this.lblBabarouting).Left = 0.0f;
    ((ARControl) this.lblBabarouting).Name = "lblBabarouting";
    this.lblBabarouting.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBabarouting.Text = "ABA Routing #:";
    ((ARControl) this.lblBabarouting).Top = 75f / 16f;
    ((ARControl) this.lblBabarouting).Width = 31f / 16f;
    ((ARControl) this.lblBAddress2).Height = 3f / 16f;
    this.lblBAddress2.HyperLink = (string) null;
    ((ARControl) this.lblBAddress2).Left = 0.0f;
    ((ARControl) this.lblBAddress2).Name = "lblBAddress2";
    this.lblBAddress2.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblBAddress2.Text = "Address:";
    ((ARControl) this.lblBAddress2).Top = 4.875f;
    ((ARControl) this.lblBAddress2).Width = 31f / 16f;
    ((ARControl) this.lblIbeneficiary).Height = 3f / 16f;
    this.lblIbeneficiary.HyperLink = (string) null;
    ((ARControl) this.lblIbeneficiary).Left = 0.0f;
    ((ARControl) this.lblIbeneficiary).Name = "lblIbeneficiary";
    this.lblIbeneficiary.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblIbeneficiary.Text = "Beneficiary Memo:";
    ((ARControl) this.lblIbeneficiary).Top = 101f / 16f;
    ((ARControl) this.lblIbeneficiary).Width = 31f / 16f;
    ((ARControl) this.lblIbankmemo).Height = 3f / 16f;
    this.lblIbankmemo.HyperLink = (string) null;
    ((ARControl) this.lblIbankmemo).Left = 0.0f;
    ((ARControl) this.lblIbankmemo).Name = "lblIbankmemo";
    this.lblIbankmemo.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblIbankmemo.Text = "Bank Memo:";
    ((ARControl) this.lblIbankmemo).Top = 5.625f;
    ((ARControl) this.lblIbankmemo).Width = 31f / 16f;
    ((ARControl) this.txtIbeneficiary).DataField = "PayeeMemo";
    ((ARControl) this.txtIbeneficiary).Height = 0.7285004f;
    ((ARControl) this.txtIbeneficiary).Left = 31f / 16f;
    ((ARControl) this.txtIbeneficiary).Name = "txtIbeneficiary";
    this.txtIbeneficiary.Style = "ddo-char-set: 0";
    this.txtIbeneficiary.Text = (string) null;
    ((ARControl) this.txtIbeneficiary).Top = 101f / 16f;
    ((ARControl) this.txtIbeneficiary).Width = 81f / 16f;
    ((ARControl) this.txtIbankmemo).DataField = "ToBankMemo";
    ((ARControl) this.txtIbankmemo).Height = 0.6870003f;
    ((ARControl) this.txtIbankmemo).Left = 31f / 16f;
    ((ARControl) this.txtIbankmemo).Name = "txtIbankmemo";
    this.txtIbankmemo.Style = "ddo-char-set: 0";
    this.txtIbankmemo.Text = (string) null;
    ((ARControl) this.txtIbankmemo).Top = 5.625f;
    ((ARControl) this.txtIbankmemo).Width = 81f / 16f;
    ((ARControl) this.txtBBankName).DataField = "ToBankName";
    ((ARControl) this.txtBBankName).Height = 3f / 16f;
    ((ARControl) this.txtBBankName).Left = 31f / 16f;
    ((ARControl) this.txtBBankName).Name = "txtBBankName";
    this.txtBBankName.Style = "ddo-char-set: 0";
    this.txtBBankName.Text = (string) null;
    ((ARControl) this.txtBBankName).Top = 69f / 16f;
    ((ARControl) this.txtBBankName).Width = 81f / 16f;
    ((ARControl) this.txtBAccountNum).DataField = "PayeeBankAcctNum";
    ((ARControl) this.txtBAccountNum).Height = 3f / 16f;
    ((ARControl) this.txtBAccountNum).Left = 31f / 16f;
    ((ARControl) this.txtBAccountNum).Name = "txtBAccountNum";
    this.txtBAccountNum.Style = "ddo-char-set: 0";
    this.txtBAccountNum.Text = (string) null;
    ((ARControl) this.txtBAccountNum).Top = 4.5f;
    ((ARControl) this.txtBAccountNum).Width = 81f / 16f;
    ((ARControl) this.txtBAbaNum).DataField = "ToBankABARouteNum";
    ((ARControl) this.txtBAbaNum).Height = 3f / 16f;
    ((ARControl) this.txtBAbaNum).Left = 31f / 16f;
    ((ARControl) this.txtBAbaNum).Name = "txtBAbaNum";
    this.txtBAbaNum.Style = "ddo-char-set: 0";
    this.txtBAbaNum.Text = (string) null;
    ((ARControl) this.txtBAbaNum).Top = 75f / 16f;
    ((ARControl) this.txtBAbaNum).Width = 81f / 16f;
    ((ARControl) this.txtBPhone).Height = 3f / 16f;
    ((ARControl) this.txtBPhone).Left = 31f / 16f;
    ((ARControl) this.txtBPhone).Name = "txtBPhone";
    this.txtBPhone.Style = "ddo-char-set: 0";
    this.txtBPhone.Text = (string) null;
    ((ARControl) this.txtBPhone).Top = 57f / 16f;
    ((ARControl) this.txtBPhone).Width = 81f / 16f;
    ((ARControl) this.txtBContact).DataField = "PayeeContact";
    ((ARControl) this.txtBContact).Height = 3f / 16f;
    ((ARControl) this.txtBContact).Left = 31f / 16f;
    ((ARControl) this.txtBContact).Name = "txtBContact";
    this.txtBContact.Style = "ddo-char-set: 0";
    this.txtBContact.Text = (string) null;
    ((ARControl) this.txtBContact).Top = 3.75f;
    ((ARControl) this.txtBContact).Width = 81f / 16f;
    ((ARControl) this.txtBAddress2).DataField = "TOBANKADDRESS";
    ((ARControl) this.txtBAddress2).Height = 3f / 16f;
    ((ARControl) this.txtBAddress2).Left = 31f / 16f;
    ((ARControl) this.txtBAddress2).Name = "txtBAddress2";
    this.txtBAddress2.Style = "ddo-char-set: 0";
    this.txtBAddress2.Text = (string) null;
    ((ARControl) this.txtBAddress2).Top = 4.875f;
    ((ARControl) this.txtBAddress2).Width = 81f / 16f;
    ((ARControl) this.txtBContactPhone).DataField = "PayeeContactPhone";
    ((ARControl) this.txtBContactPhone).Height = 3f / 16f;
    ((ARControl) this.txtBContactPhone).Left = 31f / 16f;
    ((ARControl) this.txtBContactPhone).Name = "txtBContactPhone";
    this.txtBContactPhone.Style = "ddo-char-set: 0";
    this.txtBContactPhone.Text = (string) null;
    ((ARControl) this.txtBContactPhone).Top = 63f / 16f;
    ((ARControl) this.txtBContactPhone).Width = 81f / 16f;
    ((ARControl) this.txtBAddress).DataField = "PayeeAddress";
    ((ARControl) this.txtBAddress).Height = 15f / 16f;
    ((ARControl) this.txtBAddress).Left = 31f / 16f;
    ((ARControl) this.txtBAddress).Name = "txtBAddress";
    this.txtBAddress.Style = "ddo-char-set: 0";
    this.txtBAddress.Text = (string) null;
    ((ARControl) this.txtBAddress).Top = 2.625f;
    ((ARControl) this.txtBAddress).Width = 81f / 16f;
    ((ARControl) this.txtOphone).Height = 3f / 16f;
    ((ARControl) this.txtOphone).Left = 31f / 16f;
    ((ARControl) this.txtOphone).Name = "txtOphone";
    this.txtOphone.Style = "ddo-char-set: 0";
    this.txtOphone.Text = (string) null;
    ((ARControl) this.txtOphone).Top = 1.5f;
    ((ARControl) this.txtOphone).Width = 81f / 16f;
    ((ARControl) this.txtOcontact).Height = 3f / 16f;
    ((ARControl) this.txtOcontact).Left = 31f / 16f;
    ((ARControl) this.txtOcontact).Name = "txtOcontact";
    this.txtOcontact.Style = "ddo-char-set: 0";
    this.txtOcontact.Text = (string) null;
    ((ARControl) this.txtOcontact).Top = 27f / 16f;
    ((ARControl) this.txtOcontact).Width = 81f / 16f;
    ((ARControl) this.txtOcontactphone).Height = 3f / 16f;
    ((ARControl) this.txtOcontactphone).Left = 31f / 16f;
    ((ARControl) this.txtOcontactphone).Name = "txtOcontactphone";
    this.txtOcontactphone.Style = "ddo-char-set: 0";
    this.txtOcontactphone.Text = (string) null;
    ((ARControl) this.txtOcontactphone).Top = 1.875f;
    ((ARControl) this.txtOcontactphone).Width = 81f / 16f;
    ((ARControl) this.txtOaccount).DataField = "BANKACCTNUM";
    ((ARControl) this.txtOaccount).Height = 3f / 16f;
    ((ARControl) this.txtOaccount).Left = 31f / 16f;
    ((ARControl) this.txtOaccount).Name = "txtOaccount";
    this.txtOaccount.Style = "ddo-char-set: 0";
    this.txtOaccount.Text = (string) null;
    ((ARControl) this.txtOaccount).Top = 0.375f;
    ((ARControl) this.txtOaccount).Width = 81f / 16f;
    ((ARControl) this.txtOaddress).DataField = "ORIGINATOR";
    ((ARControl) this.txtOaddress).Height = 15f / 16f;
    ((ARControl) this.txtOaddress).Left = 31f / 16f;
    ((ARControl) this.txtOaddress).Name = "txtOaddress";
    this.txtOaddress.Style = "ddo-char-set: 0";
    this.txtOaddress.Text = (string) null;
    ((ARControl) this.txtOaddress).Top = 9f / 16f;
    ((ARControl) this.txtOaddress).Width = 81f / 16f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label2.Text = "Originator";
    ((ARControl) this.Label2).Top = 1f / 16f;
    ((ARControl) this.Label2).Width = 1.625f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 0.0f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.25f;
    ((ARControl) this.Line2).Width = 7f;
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 7f;
    this.Line2.Y1 = 0.25f;
    this.Line2.Y2 = 0.25f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.0f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label3.Text = "Beneficiary";
    ((ARControl) this.Label3).Top = 2.354167f;
    ((ARControl) this.Label3).Width = 1.625f;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 0.0f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 2.541667f;
    ((ARControl) this.Line3).Width = 7f;
    this.Line3.X1 = 0.0f;
    this.Line3.X2 = 7f;
    this.Line3.Y1 = 2.541667f;
    this.Line3.Y2 = 2.541667f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 0.0f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label4.Text = "Instructions";
    ((ARControl) this.Label4).Top = 5.375f;
    ((ARControl) this.Label4).Width = 1.625f;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 0.0f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 89f / 16f;
    ((ARControl) this.Line4).Width = 7f;
    this.Line4.X1 = 0.0f;
    this.Line4.X2 = 7f;
    this.Line4.Y1 = 89f / 16f;
    this.Line4.Y2 = 89f / 16f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.lblDate,
      (ARControl) this.txtBankAddress,
      (ARControl) this.txtBankName,
      (ARControl) this.txtDate,
      (ARControl) this.Label1,
      (ARControl) this.txtAmount,
      (ARControl) this.Line1
    });
    this.ReportHeader.Height = 0.7916667f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 15.75pt; ddo-char-set: 0";
    this.lblTitle.Text = "Customer Remittance Request";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 63f / 16f;
    ((ARControl) this.lblDate).Height = 3f / 16f;
    this.lblDate.HyperLink = (string) null;
    ((ARControl) this.lblDate).Left = 4.75f;
    ((ARControl) this.lblDate).Name = "lblDate";
    this.lblDate.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblDate.Text = "Date:";
    ((ARControl) this.lblDate).Top = 5f / 16f;
    ((ARControl) this.lblDate).Width = 15f / 16f;
    ((ARControl) this.txtBankAddress).DataField = "BANKADDRESS";
    ((ARControl) this.txtBankAddress).Height = 3f / 16f;
    ((ARControl) this.txtBankAddress).Left = 0.0f;
    ((ARControl) this.txtBankAddress).Name = "txtBankAddress";
    this.txtBankAddress.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.txtBankAddress.Text = "[bank address]";
    ((ARControl) this.txtBankAddress).Top = 0.4895833f;
    ((ARControl) this.txtBankAddress).Width = 75f / 16f;
    ((ARControl) this.txtBankName).DataField = "BankName";
    ((ARControl) this.txtBankName).Height = 3f / 16f;
    ((ARControl) this.txtBankName).Left = 0.0f;
    ((ARControl) this.txtBankName).Name = "txtBankName";
    this.txtBankName.Style = "font-size: 9.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.txtBankName.Text = "[bank name]";
    ((ARControl) this.txtBankName).Top = 5f / 16f;
    ((ARControl) this.txtBankName).Width = 75f / 16f;
    ((ARControl) this.txtDate).DataField = "CHECKDATE";
    ((ARControl) this.txtDate).Height = 3f / 16f;
    ((ARControl) this.txtDate).Left = 91f / 16f;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.OutputFormat = resourceManager.GetString("txtDate.OutputFormat");
    this.txtDate.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtDate.Text = (string) null;
    ((ARControl) this.txtDate).Top = 5f / 16f;
    ((ARControl) this.txtDate).Width = 13f / 16f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 4.75f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9.75pt; font-weight: bold";
    this.Label1.Text = "Amount:";
    ((ARControl) this.Label1).Top = 0.5f;
    ((ARControl) this.Label1).Width = 11f / 16f;
    ((ARControl) this.txtAmount).DataField = "CheckAmount";
    ((ARControl) this.txtAmount).Height = 3f / 16f;
    ((ARControl) this.txtAmount).Left = 5.375f;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = resourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "font-size: 9.75pt; font-weight: bold; text-align: right";
    this.txtAmount.Text = (string) null;
    ((ARControl) this.txtAmount).Top = 0.5f;
    ((ARControl) this.txtAmount).Width = 1.125f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.0f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.25f;
    ((ARControl) this.Line1).Width = 111f / 16f;
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 111f / 16f;
    this.Line1.Y1 = 0.25f;
    this.Line1.Y2 = 0.25f;
    ((Section) this.ReportFooter).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.lblSignature,
      (ARControl) this.lblAddress,
      (ARControl) this.lblPhone,
      (ARControl) this.lblbtmDate,
      (ARControl) this.txtPhone,
      (ARControl) this.txtbtmDate
    });
    this.ReportFooter.Height = 0.75f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.lblSignature).Height = 3f / 16f;
    this.lblSignature.HyperLink = (string) null;
    ((ARControl) this.lblSignature).Left = 0.0f;
    ((ARControl) this.lblSignature).Name = "lblSignature";
    this.lblSignature.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblSignature.Text = "Signature:";
    ((ARControl) this.lblSignature).Top = 0.375f;
    ((ARControl) this.lblSignature).Width = 31f / 16f;
    ((ARControl) this.lblAddress).Height = 3f / 16f;
    this.lblAddress.HyperLink = (string) null;
    ((ARControl) this.lblAddress).Left = 0.0f;
    ((ARControl) this.lblAddress).Name = "lblAddress";
    this.lblAddress.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblAddress.Text = "Address:";
    ((ARControl) this.lblAddress).Top = 9f / 16f;
    ((ARControl) this.lblAddress).Width = 31f / 16f;
    ((ARControl) this.lblPhone).Height = 3f / 16f;
    this.lblPhone.HyperLink = (string) null;
    ((ARControl) this.lblPhone).Left = 77f / 16f;
    ((ARControl) this.lblPhone).Name = "lblPhone";
    this.lblPhone.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblPhone.Text = "Phone:";
    ((ARControl) this.lblPhone).Top = 0.375f;
    ((ARControl) this.lblPhone).Width = 0.625f;
    ((ARControl) this.lblbtmDate).Height = 3f / 16f;
    this.lblbtmDate.HyperLink = (string) null;
    ((ARControl) this.lblbtmDate).Left = 77f / 16f;
    ((ARControl) this.lblbtmDate).Name = "lblbtmDate";
    this.lblbtmDate.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblbtmDate.Text = "Date:";
    ((ARControl) this.lblbtmDate).Top = 9f / 16f;
    ((ARControl) this.lblbtmDate).Width = 0.625f;
    ((ARControl) this.txtPhone).Height = 3f / 16f;
    ((ARControl) this.txtPhone).Left = 87f / 16f;
    ((ARControl) this.txtPhone).Name = "txtPhone";
    this.txtPhone.Style = "text-align: right; ddo-char-set: 0";
    this.txtPhone.Text = "(000) 000-0000";
    ((ARControl) this.txtPhone).Top = 0.375f;
    ((ARControl) this.txtPhone).Width = 25f / 16f;
    ((ARControl) this.txtbtmDate).Height = 3f / 16f;
    ((ARControl) this.txtbtmDate).Left = 87f / 16f;
    ((ARControl) this.txtbtmDate).Name = "txtbtmDate";
    this.txtbtmDate.OutputFormat = resourceManager.GetString("txtbtmDate.OutputFormat");
    this.txtbtmDate.Style = "text-align: right; ddo-char-set: 0";
    this.txtbtmDate.Text = (string) null;
    ((ARControl) this.txtbtmDate).Top = 9f / 16f;
    ((ARControl) this.txtbtmDate).Width = 25f / 16f;
    this.MasterReport = false;
    sqlDbDataSource.ConnectionString = "data source=MGASYSTEMS;initial catalog=IMS;persist security info=False;user id=mgasystems";
    sqlDbDataSource.SQL = "";
    this.DataSource = (object) sqlDbDataSource;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.lblOaddress).EndInit();
    ((ISupportInitialize) this.lblOname).EndInit();
    ((ISupportInitialize) this.lblOacctnum).EndInit();
    ((ISupportInitialize) this.lblOcontact).EndInit();
    ((ISupportInitialize) this.lblOphone).EndInit();
    ((ISupportInitialize) this.lblOcphone).EndInit();
    ((ISupportInitialize) this.lblBaddress).EndInit();
    ((ISupportInitialize) this.lblBname).EndInit();
    ((ISupportInitialize) this.lblBcontact).EndInit();
    ((ISupportInitialize) this.lblBphone).EndInit();
    ((ISupportInitialize) this.lblBContactPhone).EndInit();
    ((ISupportInitialize) this.lblBacct).EndInit();
    ((ISupportInitialize) this.lblBbankname).EndInit();
    ((ISupportInitialize) this.lblBabarouting).EndInit();
    ((ISupportInitialize) this.lblBAddress2).EndInit();
    ((ISupportInitialize) this.lblIbeneficiary).EndInit();
    ((ISupportInitialize) this.lblIbankmemo).EndInit();
    ((ISupportInitialize) this.txtIbeneficiary).EndInit();
    ((ISupportInitialize) this.txtIbankmemo).EndInit();
    ((ISupportInitialize) this.txtBBankName).EndInit();
    ((ISupportInitialize) this.txtBAccountNum).EndInit();
    ((ISupportInitialize) this.txtBAbaNum).EndInit();
    ((ISupportInitialize) this.txtBPhone).EndInit();
    ((ISupportInitialize) this.txtBContact).EndInit();
    ((ISupportInitialize) this.txtBAddress2).EndInit();
    ((ISupportInitialize) this.txtBContactPhone).EndInit();
    ((ISupportInitialize) this.txtBAddress).EndInit();
    ((ISupportInitialize) this.txtOphone).EndInit();
    ((ISupportInitialize) this.txtOcontact).EndInit();
    ((ISupportInitialize) this.txtOcontactphone).EndInit();
    ((ISupportInitialize) this.txtOaccount).EndInit();
    ((ISupportInitialize) this.txtOaddress).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.txtBankAddress).EndInit();
    ((ISupportInitialize) this.txtBankName).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.lblSignature).EndInit();
    ((ISupportInitialize) this.lblAddress).EndInit();
    ((ISupportInitialize) this.lblPhone).EndInit();
    ((ISupportInitialize) this.lblbtmDate).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.txtbtmDate).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
