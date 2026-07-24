// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.formSweepAutomationWizard
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Services;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{D269A4DA-B77B-4021-9AE6-43FAC3C2C5BE}", "Sweep Automation Wizard", "Determines whether or not a user can run the Sweep Automation Wizard.", "Accounting")]
public class formSweepAutomationWizard : Form
{
  private IContainer components;

  public formSweepAutomationWizard()
  {
    this.InitializeComponent();
    this.panelStart.Visible = true;
    this.panelStep1.Visible = false;
    this.panelStep2.Visible = false;
    if (!SecurityManager.Instance.AssertPermission("{D269A4DA-B77B-4021-9AE6-43FAC3C2C5BE}"))
    {
      MGASystems.IMS.Accounting.Banking.Utility.DenyAccess();
      this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
    }
    else
      this.LoadOfficeLocations();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("panelStart")]
  internal virtual Panel panelStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel9")]
  internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox5")]
  internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel8")]
  internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnStartNext
  {
    get => this._btnStartNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ClickHandler);
      MGAButton btnStartNext1 = this._btnStartNext;
      if (btnStartNext1 != null)
        ((Control) btnStartNext1).Click -= eventHandler;
      this._btnStartNext = value;
      MGAButton btnStartNext2 = this._btnStartNext;
      if (btnStartNext2 == null)
        return;
      ((Control) btnStartNext2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnStartCancel
  {
    get => this._btnStartCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelHandler);
      MGAButton btnStartCancel1 = this._btnStartCancel;
      if (btnStartCancel1 != null)
        ((Control) btnStartCancel1).Click -= eventHandler;
      this._btnStartCancel = value;
      MGAButton btnStartCancel2 = this._btnStartCancel;
      if (btnStartCancel2 == null)
        return;
      ((Control) btnStartCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelStep1")]
  internal virtual Panel panelStep1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSourceAccountFooter")]
  internal virtual Panel panelSourceAccountFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonStep1Back
  {
    get => this._buttonStep1Back;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ClickHandler);
      MGAButton buttonStep1Back1 = this._buttonStep1Back;
      if (buttonStep1Back1 != null)
        ((Control) buttonStep1Back1).Click -= eventHandler;
      this._buttonStep1Back = value;
      MGAButton buttonStep1Back2 = this._buttonStep1Back;
      if (buttonStep1Back2 == null)
        return;
      ((Control) buttonStep1Back2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonStep1Next
  {
    get => this._buttonStep1Next;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ClickHandler);
      MGAButton buttonStep1Next1 = this._buttonStep1Next;
      if (buttonStep1Next1 != null)
        ((Control) buttonStep1Next1).Click -= eventHandler;
      this._buttonStep1Next = value;
      MGAButton buttonStep1Next2 = this._buttonStep1Next;
      if (buttonStep1Next2 == null)
        return;
      ((Control) buttonStep1Next2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonStep1Cancel
  {
    get => this._buttonStep1Cancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelHandler);
      MGAButton buttonStep1Cancel1 = this._buttonStep1Cancel;
      if (buttonStep1Cancel1 != null)
        ((Control) buttonStep1Cancel1).Click -= eventHandler;
      this._buttonStep1Cancel = value;
      MGAButton buttonStep1Cancel2 = this._buttonStep1Cancel;
      if (buttonStep1Cancel2 == null)
        return;
      ((Control) buttonStep1Cancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSourceAccountHeader")]
  internal virtual Panel panelSourceAccountHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox4")]
  internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox2")]
  internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox3")]
  internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboOfficeLocation
  {
    get => this._comboOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
      MGASimpleComboBox comboOfficeLocation1 = this._comboOfficeLocation;
      if (comboOfficeLocation1 != null)
        comboOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboOfficeLocation = value;
      MGASimpleComboBox comboOfficeLocation2 = this._comboOfficeLocation;
      if (comboOfficeLocation2 == null)
        return;
      comboOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelStep2")]
  internal virtual Panel panelStep2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonStep2Back
  {
    get => this._buttonStep2Back;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ClickHandler);
      MGAButton buttonStep2Back1 = this._buttonStep2Back;
      if (buttonStep2Back1 != null)
        ((Control) buttonStep2Back1).Click -= eventHandler;
      this._buttonStep2Back = value;
      MGAButton buttonStep2Back2 = this._buttonStep2Back;
      if (buttonStep2Back2 == null)
        return;
      ((Control) buttonStep2Back2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonStep2Next
  {
    get => this._buttonStep2Next;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ClickHandler);
      EventHandler eventHandler2 = new EventHandler(this.ClickHandler);
      MGAButton buttonStep2Next1 = this._buttonStep2Next;
      if (buttonStep2Next1 != null)
      {
        ((Control) buttonStep2Next1).Click -= eventHandler1;
        ((Control) buttonStep2Next1).Click -= eventHandler2;
      }
      this._buttonStep2Next = value;
      MGAButton buttonStep2Next2 = this._buttonStep2Next;
      if (buttonStep2Next2 == null)
        return;
      ((Control) buttonStep2Next2).Click += eventHandler1;
      ((Control) buttonStep2Next2).Click += eventHandler2;
    }
  }

  internal virtual MGAButton buttonStep2Cancel
  {
    get => this._buttonStep2Cancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelHandler);
      MGAButton buttonStep2Cancel1 = this._buttonStep2Cancel;
      if (buttonStep2Cancel1 != null)
        ((Control) buttonStep2Cancel1).Click -= eventHandler;
      this._buttonStep2Cancel = value;
      MGAButton buttonStep2Cancel2 = this._buttonStep2Cancel;
      if (buttonStep2Cancel2 == null)
        return;
      ((Control) buttonStep2Cancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonGetInvoices
  {
    get => this._buttonGetInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonGetInvoices_Click);
      MGAButton buttonGetInvoices1 = this._buttonGetInvoices;
      if (buttonGetInvoices1 != null)
        ((Control) buttonGetInvoices1).Click -= eventHandler;
      this._buttonGetInvoices = value;
      MGAButton buttonGetInvoices2 = this._buttonGetInvoices;
      if (buttonGetInvoices2 == null)
        return;
      ((Control) buttonGetInvoices2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textARReceivedPercentage")]
  internal virtual MGATextBox textARReceivedPercentage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsSweepAutomation1")]
  internal virtual dsSweepAutomation DsSweepAutomation1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonSearchCompany
  {
    get => this._buttonSearchCompany;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSearchCompany_Click);
      MGAButton buttonSearchCompany1 = this._buttonSearchCompany;
      if (buttonSearchCompany1 != null)
        ((Control) buttonSearchCompany1).Click -= eventHandler;
      this._buttonSearchCompany = value;
      MGAButton buttonSearchCompany2 = this._buttonSearchCompany;
      if (buttonSearchCompany2 == null)
        return;
      ((Control) buttonSearchCompany2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textCompanyName")]
  internal virtual MGATextBox textCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonClearCompanySelection
  {
    get => this._buttonClearCompanySelection;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonClearCompanySelection_Click);
      MGAButton companySelection1 = this._buttonClearCompanySelection;
      if (companySelection1 != null)
        ((Control) companySelection1).Click -= eventHandler;
      this._buttonClearCompanySelection = value;
      MGAButton companySelection2 = this._buttonClearCompanySelection;
      if (companySelection2 == null)
        return;
      ((Control) companySelection2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridSweepList")]
  internal virtual UltraGrid gridSweepList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonPrint
  {
    get => this._buttonPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonPrint_Click);
      MGAButton buttonPrint1 = this._buttonPrint;
      if (buttonPrint1 != null)
        ((Control) buttonPrint1).Click -= eventHandler;
      this._buttonPrint = value;
      MGAButton buttonPrint2 = this._buttonPrint;
      if (buttonPrint2 == null)
        return;
      ((Control) buttonPrint2).Click += eventHandler;
    }
  }

  internal virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("_formSweepAutomationWizard_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _formSweepAutomationWizard_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_formSweepAutomationWizard_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _formSweepAutomationWizard_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_formSweepAutomationWizard_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _formSweepAutomationWizard_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_formSweepAutomationWizard_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _formSweepAutomationWizard_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateRangeFrom")]
  internal virtual MGADateTimePicker dateRangeFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateRangeTo")]
  internal virtual MGADateTimePicker dateRangeTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboSourceBankAccounts")]
  internal virtual MGASimpleComboBox comboSourceBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboDestinationBankAccount")]
  internal virtual MGASimpleComboBox comboDestinationBankAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts2")]
  internal virtual dsBankAccounts DsBankAccounts2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelConfirmation")]
  internal virtual Panel panelConfirmation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonConfirmBack
  {
    get => this._buttonConfirmBack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ClickHandler);
      MGAButton buttonConfirmBack1 = this._buttonConfirmBack;
      if (buttonConfirmBack1 != null)
        ((Control) buttonConfirmBack1).Click -= eventHandler;
      this._buttonConfirmBack = value;
      MGAButton buttonConfirmBack2 = this._buttonConfirmBack;
      if (buttonConfirmBack2 == null)
        return;
      ((Control) buttonConfirmBack2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonConfirmFinish
  {
    get => this._buttonConfirmFinish;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonConfirmFinish_Click);
      MGAButton buttonConfirmFinish1 = this._buttonConfirmFinish;
      if (buttonConfirmFinish1 != null)
        ((Control) buttonConfirmFinish1).Click -= eventHandler;
      this._buttonConfirmFinish = value;
      MGAButton buttonConfirmFinish2 = this._buttonConfirmFinish;
      if (buttonConfirmFinish2 == null)
        return;
      ((Control) buttonConfirmFinish2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonConfirmCancel
  {
    get => this._buttonConfirmCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CancelHandler);
      MGAButton buttonConfirmCancel1 = this._buttonConfirmCancel;
      if (buttonConfirmCancel1 != null)
        ((Control) buttonConfirmCancel1).Click -= eventHandler;
      this._buttonConfirmCancel = value;
      MGAButton buttonConfirmCancel2 = this._buttonConfirmCancel;
      if (buttonConfirmCancel2 == null)
        return;
      ((Control) buttonConfirmCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PictureBox6")]
  internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel5")]
  internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox7")]
  internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelDestinationBankAccount")]
  internal virtual Label labelDestinationBankAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelTotalSweepAmount")]
  internal virtual Label labelTotalSweepAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textComments")]
  internal virtual MGATextBox textComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("datePostDate")]
  internal virtual MGADateTimePicker datePostDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSourceBankAccount")]
  internal virtual Label labelSourceBankAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pictureLoading")]
  internal virtual PictureBox pictureLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (formSweepAutomationWizard));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("InvoiceList", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PostDate");
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("OfficeInvoiceNumber");
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Company");
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PolicyNumber");
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("InsuredName");
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("QuoteDescription");
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("InvoiceTotal");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AmtRcvd");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GrossCommission");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CompanyGross");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PaidToDate");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PercentReceived");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("InvoiceNumber");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Select", 0);
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("GridContext");
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridContext");
    ButtonTool buttonTool1 = new ButtonTool("SelectAll");
    ButtonTool buttonTool2 = new ButtonTool("UnSelectAll");
    ButtonTool buttonTool3 = new ButtonTool("SelectAll");
    Appearance appearance44 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("UnSelectAll");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    this.panelStart = new Panel();
    this.Panel9 = new Panel();
    this.PictureBox5 = new PictureBox();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.Panel8 = new Panel();
    this.btnStartNext = new MGAButton();
    this.btnStartCancel = new MGAButton();
    this.Label24 = new Label();
    this.Label23 = new Label();
    this.panelStep1 = new Panel();
    this.comboDestinationBankAccount = new MGASimpleComboBox();
    this.DsBankAccounts2 = new dsBankAccounts();
    this.Label11 = new Label();
    this.dateRangeFrom = new MGADateTimePicker();
    this.Label8 = new Label();
    this.dateRangeTo = new MGADateTimePicker();
    this.Label9 = new Label();
    this.textARReceivedPercentage = new MGATextBox();
    this.Label7 = new Label();
    this.comboSourceBankAccounts = new MGASimpleComboBox();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.Label6 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.panelSourceAccountFooter = new Panel();
    this.buttonStep1Back = new MGAButton();
    this.buttonStep1Next = new MGAButton();
    this.buttonStep1Cancel = new MGAButton();
    this.PictureBox1 = new PictureBox();
    this.panelSourceAccountHeader = new Panel();
    this.PictureBox4 = new PictureBox();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.panelStep2 = new Panel();
    this.buttonClearCompanySelection = new MGAButton();
    this.buttonSearchCompany = new MGAButton();
    this.textCompanyName = new MGATextBox();
    this.Label10 = new Label();
    this.buttonGetInvoices = new MGAButton();
    this.Panel2 = new Panel();
    this.buttonPrint = new MGAButton();
    this.buttonStep2Back = new MGAButton();
    this.buttonStep2Next = new MGAButton();
    this.buttonStep2Cancel = new MGAButton();
    this.PictureBox2 = new PictureBox();
    this.Panel3 = new Panel();
    this.PictureBox3 = new PictureBox();
    this.Label1 = new Label();
    this.Label4 = new Label();
    this.gridSweepList = new UltraGrid();
    this.DsSweepAutomation1 = new dsSweepAutomation();
    this.pictureLoading = new PictureBox();
    this.ToolTip1 = new ToolTip(this.components);
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.panelConfirmation = new Panel();
    this.datePostDate = new MGADateTimePicker();
    this.textComments = new MGATextBox();
    this.labelTotalSweepAmount = new Label();
    this.labelDestinationBankAccount = new Label();
    this.labelSourceBankAccount = new Label();
    this.Label18 = new Label();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.Label15 = new Label();
    this.Label12 = new Label();
    this.Panel4 = new Panel();
    this.buttonConfirmBack = new MGAButton();
    this.buttonConfirmFinish = new MGAButton();
    this.buttonConfirmCancel = new MGAButton();
    this.PictureBox6 = new PictureBox();
    this.Panel5 = new Panel();
    this.PictureBox7 = new PictureBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.panelStart.SuspendLayout();
    this.Panel9.SuspendLayout();
    this.Panel8.SuspendLayout();
    ((ISupportInitialize) this.btnStartNext).BeginInit();
    ((ISupportInitialize) this.btnStartCancel).BeginInit();
    this.panelStep1.SuspendLayout();
    ((ISupportInitialize) this.comboDestinationBankAccount).BeginInit();
    this.DsBankAccounts2.BeginInit();
    ((ISupportInitialize) this.dateRangeFrom).BeginInit();
    ((ISupportInitialize) this.dateRangeTo).BeginInit();
    ((ISupportInitialize) this.textARReceivedPercentage).BeginInit();
    ((ISupportInitialize) this.comboSourceBankAccounts).BeginInit();
    this.DsBankAccounts1.BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.panelSourceAccountFooter.SuspendLayout();
    ((ISupportInitialize) this.buttonStep1Back).BeginInit();
    ((ISupportInitialize) this.buttonStep1Next).BeginInit();
    ((ISupportInitialize) this.buttonStep1Cancel).BeginInit();
    this.panelSourceAccountHeader.SuspendLayout();
    this.panelStep2.SuspendLayout();
    ((ISupportInitialize) this.buttonClearCompanySelection).BeginInit();
    ((ISupportInitialize) this.buttonSearchCompany).BeginInit();
    ((ISupportInitialize) this.textCompanyName).BeginInit();
    ((ISupportInitialize) this.buttonGetInvoices).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.buttonPrint).BeginInit();
    ((ISupportInitialize) this.buttonStep2Back).BeginInit();
    ((ISupportInitialize) this.buttonStep2Next).BeginInit();
    ((ISupportInitialize) this.buttonStep2Cancel).BeginInit();
    this.Panel3.SuspendLayout();
    ((ISupportInitialize) this.gridSweepList).BeginInit();
    this.DsSweepAutomation1.BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.panelConfirmation.SuspendLayout();
    ((ISupportInitialize) this.datePostDate).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    this.Panel4.SuspendLayout();
    ((ISupportInitialize) this.buttonConfirmBack).BeginInit();
    ((ISupportInitialize) this.buttonConfirmFinish).BeginInit();
    ((ISupportInitialize) this.buttonConfirmCancel).BeginInit();
    this.Panel5.SuspendLayout();
    this.SuspendLayout();
    this.panelStart.BackColor = Color.White;
    this.panelStart.Controls.Add((Control) this.Panel9);
    this.panelStart.Controls.Add((Control) this.Label20);
    this.panelStart.Controls.Add((Control) this.Label19);
    this.panelStart.Controls.Add((Control) this.Panel8);
    this.panelStart.Controls.Add((Control) this.Label24);
    this.panelStart.Controls.Add((Control) this.Label23);
    this.panelStart.Dock = DockStyle.Fill;
    this.panelStart.Location = new Point(0, 0);
    this.panelStart.Name = "panelStart";
    this.panelStart.Size = new Size(967, 470);
    this.panelStart.TabIndex = 1;
    this.Panel9.BackColor = Color.LightSlateGray;
    this.Panel9.Controls.Add((Control) this.PictureBox5);
    this.Panel9.Dock = DockStyle.Left;
    this.Panel9.Location = new Point(0, 0);
    this.Panel9.Name = "Panel9";
    this.Panel9.Size = new Size(152, 430);
    this.Panel9.TabIndex = 0;
    this.PictureBox5.Dock = DockStyle.Fill;
    this.PictureBox5.Image = (Image) resourceManager.GetObject("PictureBox5.Image");
    this.PictureBox5.Location = new Point(0, 0);
    this.PictureBox5.Name = "PictureBox5";
    this.PictureBox5.Size = new Size(152, 430);
    this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox5.TabIndex = 0;
    this.PictureBox5.TabStop = false;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(160 /*0xA0*/, 352);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(800, 32 /*0x20*/);
    this.Label20.TabIndex = 3;
    this.Label20.Text = "If at any time you make a mistake or you want to change a value, you can click the 'Back' button to go back to a previous step. If at any time you wish to cancel this transaction, simply click the 'Cancel' button.";
    this.Label19.Location = new Point(160 /*0xA0*/, 184);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(792, 96 /*0x60*/);
    this.Label19.TabIndex = 2;
    this.Label19.Text = "You will be asked to specify the Office Location, the source and destination accounts, a receivable date range and the receivable percentage collected to filter the data returned. You can run this wizard for all companies or a specific company. After the selection criteria has been specified click the 'Calculate Sweep Amount' button, the wizard will then present you with a list of invoice that meet you selection criteria. You can choose to sweep all monies related to those invoices or you may pick and choose which invoice payables will be swept on an invoice by invoice basis. ";
    this.Panel8.BackgroundImage = (Image) resourceManager.GetObject("Panel8.BackgroundImage");
    this.Panel8.Controls.Add((Control) this.btnStartNext);
    this.Panel8.Controls.Add((Control) this.btnStartCancel);
    this.Panel8.Dock = DockStyle.Bottom;
    this.Panel8.Location = new Point(0, 430);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(967, 40);
    this.Panel8.TabIndex = 4;
    ((Control) this.btnStartNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BackColor2 = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DimGray;
    ((ControlBase) this.btnStartNext).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnStartNext).Location = new Point(765, 8);
    ((Control) this.btnStartNext).Name = "btnStartNext";
    ((Control) this.btnStartNext).Size = new Size(100, 24);
    ((Control) this.btnStartNext).TabIndex = 0;
    ((ControlBase) this.btnStartNext).Text = "&Next >";
    ((Control) this.btnStartCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnStartCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnStartCancel).Location = new Point(877, 8);
    ((Control) this.btnStartCancel).Name = "btnStartCancel";
    ((Control) this.btnStartCancel).Size = new Size(75, 24);
    ((Control) this.btnStartCancel).TabIndex = 1;
    ((ControlBase) this.btnStartCancel).Text = "&Cancel";
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(160 /*0xA0*/, 8);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(263, 26);
    this.Label24.TabIndex = 0;
    this.Label24.Text = "Sweep Automation Wizard";
    this.Label23.Location = new Point(160 /*0xA0*/, 72);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(792, 48 /*0x30*/);
    this.Label23.TabIndex = 1;
    this.Label23.Text = "Welcome to the Sweep Automation Wizard. For those companies with which you have a fiduciary relationship, this wizard will help you stay in trust by calculating the money due in trust based on the criteria you specify.";
    this.panelStep1.BackColor = Color.White;
    this.panelStep1.Controls.Add((Control) this.comboDestinationBankAccount);
    this.panelStep1.Controls.Add((Control) this.Label11);
    this.panelStep1.Controls.Add((Control) this.dateRangeFrom);
    this.panelStep1.Controls.Add((Control) this.Label8);
    this.panelStep1.Controls.Add((Control) this.dateRangeTo);
    this.panelStep1.Controls.Add((Control) this.Label9);
    this.panelStep1.Controls.Add((Control) this.textARReceivedPercentage);
    this.panelStep1.Controls.Add((Control) this.Label7);
    this.panelStep1.Controls.Add((Control) this.comboSourceBankAccounts);
    this.panelStep1.Controls.Add((Control) this.Label6);
    this.panelStep1.Controls.Add((Control) this.comboOfficeLocation);
    this.panelStep1.Controls.Add((Control) this.Label5);
    this.panelStep1.Controls.Add((Control) this.panelSourceAccountFooter);
    this.panelStep1.Controls.Add((Control) this.panelSourceAccountHeader);
    this.panelStep1.Dock = DockStyle.Fill;
    this.panelStep1.Location = new Point(0, 0);
    this.panelStep1.Name = "panelStep1";
    this.panelStep1.Size = new Size(967, 470);
    this.panelStep1.TabIndex = 2;
    this.panelStep1.Visible = false;
    this.comboDestinationBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDestinationBankAccount.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboDestinationBankAccount).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.comboDestinationBankAccount).DataSource = (object) this.DsBankAccounts2;
    ((UltraDropDownBase) this.comboDestinationBankAccount).DisplayMember = "BANKNAME";
    this.comboDestinationBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDestinationBankAccount).Font = new Font("Tahoma", 8f);
    ((Control) this.comboDestinationBankAccount).Location = new Point(335, 248);
    this.comboDestinationBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDestinationBankAccount).Name = "comboDestinationBankAccount";
    ((Control) this.comboDestinationBankAccount).Size = new Size(296, 20);
    ((Control) this.comboDestinationBankAccount).TabIndex = 16 /*0x10*/;
    ((UltraDropDownBase) this.comboDestinationBankAccount).ValueMember = "GLACCTID";
    this.DsBankAccounts2.DataSetName = "dsBankAccounts";
    this.DsBankAccounts2.Locale = new CultureInfo("en-US");
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.White;
    this.Label11.Font = new Font("Tahoma", 8f);
    this.Label11.ForeColor = Color.Black;
    this.Label11.Location = new Point(335, 232);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.Label11.TabIndex = 15;
    this.Label11.Text = "Destination Bank Account";
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateRangeFrom.Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    this.dateRangeFrom.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateRangeFrom).Location = new Point(336, 360);
    this.dateRangeFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateRangeFrom).Name = "dateRangeFrom";
    ((Control) this.dateRangeFrom).Size = new Size(88, 20);
    ((Control) this.dateRangeFrom).TabIndex = 11;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(336, 344);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(61, 16 /*0x10*/);
    this.Label8.TabIndex = 13;
    this.Label8.Text = "Date Range";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateRangeTo.Appearance = (AppearanceBase) appearance5;
    appearance6.AlphaLevel = (short) 14;
    appearance6.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance6.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance6.BackColorAlpha = (Alpha) 2;
    appearance6.BackGradientAlignment = (GradientAlignment) 4;
    appearance6.BackGradientStyle = (GradientStyle) 5;
    appearance6.BorderAlpha = (Alpha) 1;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    appearance6.ForeColor = Color.FromArgb(49, 85, 153);
    appearance6.ForegroundAlpha = (Alpha) 2;
    this.dateRangeTo.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dateRangeTo).Location = new Point(464, 360);
    this.dateRangeTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateRangeTo).Name = "dateRangeTo";
    ((Control) this.dateRangeTo).Size = new Size(88, 20);
    ((Control) this.dateRangeTo).TabIndex = 12;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Tahoma", 16f);
    this.Label9.Location = new Point(440, 352);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(16 /*0x10*/, 29);
    this.Label9.TabIndex = 14;
    this.Label9.Text = "-";
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textARReceivedPercentage).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textARReceivedPercentage).Location = new Point(336, 304);
    this.textARReceivedPercentage.MGAStyle = MGAStyles.Blue;
    ((Control) this.textARReceivedPercentage).Name = "textARReceivedPercentage";
    ((Control) this.textARReceivedPercentage).Size = new Size(296, 20);
    ((Control) this.textARReceivedPercentage).TabIndex = 10;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(336, 288);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(122, 16 /*0x10*/);
    this.Label7.TabIndex = 9;
    this.Label7.Text = "AR Received Percentage";
    this.comboSourceBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSourceBankAccounts.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboSourceBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.comboSourceBankAccounts).DataSource = (object) this.DsBankAccounts1;
    ((UltraDropDownBase) this.comboSourceBankAccounts).DisplayMember = "BANKNAME";
    this.comboSourceBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSourceBankAccounts).Font = new Font("Tahoma", 8f);
    ((Control) this.comboSourceBankAccounts).Location = new Point(336, 192 /*0xC0*/);
    this.comboSourceBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSourceBankAccounts).Name = "comboSourceBankAccounts";
    ((Control) this.comboSourceBankAccounts).Size = new Size(296, 20);
    ((Control) this.comboSourceBankAccounts).TabIndex = 8;
    ((UltraDropDownBase) this.comboSourceBankAccounts).ValueMember = "GLACCTID";
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.White;
    this.Label6.Font = new Font("Tahoma", 8f);
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(336, 176 /*0xB0*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(106, 16 /*0x10*/);
    this.Label6.TabIndex = 7;
    this.Label6.Text = "Source Bank Account";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(336, 136);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(296, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 5;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "";
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(336, 120);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(76, 16 /*0x10*/);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Office Location";
    this.panelSourceAccountFooter.Controls.Add((Control) this.buttonStep1Back);
    this.panelSourceAccountFooter.Controls.Add((Control) this.buttonStep1Next);
    this.panelSourceAccountFooter.Controls.Add((Control) this.buttonStep1Cancel);
    this.panelSourceAccountFooter.Controls.Add((Control) this.PictureBox1);
    this.panelSourceAccountFooter.Dock = DockStyle.Bottom;
    this.panelSourceAccountFooter.Location = new Point(0, 430);
    this.panelSourceAccountFooter.Name = "panelSourceAccountFooter";
    this.panelSourceAccountFooter.Size = new Size(967, 40);
    this.panelSourceAccountFooter.TabIndex = 3;
    ((Control) this.buttonStep1Back).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance8.BackColor = Color.Gainsboro;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep1Back).Appearance = (AppearanceBase) appearance8;
    ((Control) this.buttonStep1Back).Location = new Point(669, 8);
    ((Control) this.buttonStep1Back).Name = "buttonStep1Back";
    ((Control) this.buttonStep1Back).Size = new Size(100, 24);
    ((Control) this.buttonStep1Back).TabIndex = 0;
    ((ControlBase) this.buttonStep1Back).Text = "< &Back";
    ((Control) this.buttonStep1Next).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep1Next).Appearance = (AppearanceBase) appearance9;
    ((Control) this.buttonStep1Next).Location = new Point(773, 8);
    ((Control) this.buttonStep1Next).Name = "buttonStep1Next";
    ((Control) this.buttonStep1Next).Size = new Size(100, 24);
    ((Control) this.buttonStep1Next).TabIndex = 1;
    ((ControlBase) this.buttonStep1Next).Text = "&Next >";
    ((Control) this.buttonStep1Cancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance10.BackColor = Color.Gainsboro;
    appearance10.BackColor2 = Color.White;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep1Cancel).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonStep1Cancel).Location = new Point(885, 8);
    ((Control) this.buttonStep1Cancel).Name = "buttonStep1Cancel";
    ((Control) this.buttonStep1Cancel).Size = new Size(75, 24);
    ((Control) this.buttonStep1Cancel).TabIndex = 2;
    ((ControlBase) this.buttonStep1Cancel).Text = "&Cancel";
    this.PictureBox1.Dock = DockStyle.Fill;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(0, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(967, 40);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 3;
    this.PictureBox1.TabStop = false;
    this.panelSourceAccountHeader.BackColor = Color.Transparent;
    this.panelSourceAccountHeader.BackgroundImage = (Image) resourceManager.GetObject("panelSourceAccountHeader.BackgroundImage");
    this.panelSourceAccountHeader.Controls.Add((Control) this.PictureBox4);
    this.panelSourceAccountHeader.Controls.Add((Control) this.Label3);
    this.panelSourceAccountHeader.Controls.Add((Control) this.Label2);
    this.panelSourceAccountHeader.Dock = DockStyle.Top;
    this.panelSourceAccountHeader.Location = new Point(0, 0);
    this.panelSourceAccountHeader.Name = "panelSourceAccountHeader";
    this.panelSourceAccountHeader.Size = new Size(967, 80 /*0x50*/);
    this.panelSourceAccountHeader.TabIndex = 0;
    this.PictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.PictureBox4.Image = (Image) resourceManager.GetObject("PictureBox4.Image");
    this.PictureBox4.Location = new Point(895, 8);
    this.PictureBox4.Name = "PictureBox4";
    this.PictureBox4.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox4.TabIndex = 2;
    this.PictureBox4.TabStop = false;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.ForeColor = Color.White;
    this.Label3.Location = new Point(16 /*0x10*/, 40);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(864, 32 /*0x20*/);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Please specify the office location, the source bank account, the destination bank account and the date range for the items you wish to search for. The wizard will use the office location specified to pull the invoices to be swept.";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.White;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(427, 26);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Office Location And Bank Account Selection";
    this.panelStep2.BackColor = Color.White;
    this.panelStep2.Controls.Add((Control) this.buttonClearCompanySelection);
    this.panelStep2.Controls.Add((Control) this.buttonSearchCompany);
    this.panelStep2.Controls.Add((Control) this.textCompanyName);
    this.panelStep2.Controls.Add((Control) this.Label10);
    this.panelStep2.Controls.Add((Control) this.buttonGetInvoices);
    this.panelStep2.Controls.Add((Control) this.Panel2);
    this.panelStep2.Controls.Add((Control) this.Panel3);
    this.panelStep2.Controls.Add((Control) this.gridSweepList);
    this.panelStep2.Controls.Add((Control) this.pictureLoading);
    this.panelStep2.Dock = DockStyle.Fill;
    this.panelStep2.Location = new Point(0, 0);
    this.panelStep2.Name = "panelStep2";
    this.panelStep2.Size = new Size(967, 470);
    this.panelStep2.TabIndex = 3;
    this.panelStep2.Visible = false;
    ((Control) this.buttonClearCompanySelection).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance11.BackColor = Color.Gainsboro;
    appearance11.BackColor2 = Color.White;
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.Gray;
    appearance11.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance11.Image"));
    appearance11.ImageHAlign = (HAlign) 2;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClearCompanySelection).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonClearCompanySelection).Enabled = false;
    ((Control) this.buttonClearCompanySelection).Location = new Point(336, 88);
    ((Control) this.buttonClearCompanySelection).Name = "buttonClearCompanySelection";
    ((Control) this.buttonClearCompanySelection).Size = new Size(20, 20);
    ((Control) this.buttonClearCompanySelection).TabIndex = 9;
    this.ToolTip1.SetToolTip((Control) this.buttonClearCompanySelection, "Click here to clear the selected company.");
    ((Control) this.buttonSearchCompany).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance12.BackColor = Color.Gainsboro;
    appearance12.BackColor2 = Color.White;
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.BorderColor = Color.Gray;
    appearance12.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance12.Image"));
    appearance12.ImageHAlign = (HAlign) 2;
    appearance12.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchCompany).Appearance = (AppearanceBase) appearance12;
    ((Control) this.buttonSearchCompany).Location = new Point(320, 88);
    ((Control) this.buttonSearchCompany).Name = "buttonSearchCompany";
    ((Control) this.buttonSearchCompany).Size = new Size(20, 20);
    ((Control) this.buttonSearchCompany).TabIndex = 8;
    this.ToolTip1.SetToolTip((Control) this.buttonSearchCompany, "click here to search for a company.");
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCompanyName).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textCompanyName).Location = new Point(64 /*0x40*/, 88);
    ((Control) this.textCompanyName).Name = "textCompanyName";
    ((Control) this.textCompanyName).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.textCompanyName).TabIndex = 7;
    ((TextEditorControlBase) this.textCompanyName).Text = "(All Companies)";
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(8, 88);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(53, 16 /*0x10*/);
    this.Label10.TabIndex = 6;
    this.Label10.Text = "Company:";
    ((Control) this.buttonGetInvoices).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance14.BackColor = Color.Gainsboro;
    appearance14.BackColor2 = Color.White;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.Gray;
    appearance14.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance14.Image"));
    ((ControlBase) this.buttonGetInvoices).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonGetInvoices).Location = new Point(809, 88);
    ((Control) this.buttonGetInvoices).Name = "buttonGetInvoices";
    ((Control) this.buttonGetInvoices).Size = new Size(152, 24);
    ((Control) this.buttonGetInvoices).TabIndex = 5;
    ((ControlBase) this.buttonGetInvoices).Text = "Calculate Sweep Amount";
    this.Panel2.Controls.Add((Control) this.buttonPrint);
    this.Panel2.Controls.Add((Control) this.buttonStep2Back);
    this.Panel2.Controls.Add((Control) this.buttonStep2Next);
    this.Panel2.Controls.Add((Control) this.buttonStep2Cancel);
    this.Panel2.Controls.Add((Control) this.PictureBox2);
    this.Panel2.Dock = DockStyle.Bottom;
    this.Panel2.Location = new Point(0, 430);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(967, 40);
    this.Panel2.TabIndex = 3;
    ((Control) this.buttonPrint).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance15.BackColor = Color.Gainsboro;
    appearance15.BackColor2 = Color.White;
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.Gray;
    appearance15.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance15.Image"));
    ((ControlBase) this.buttonPrint).Appearance = (AppearanceBase) appearance15;
    ((Control) this.buttonPrint).Location = new Point(8, 8);
    ((Control) this.buttonPrint).Name = "buttonPrint";
    ((Control) this.buttonPrint).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonPrint).TabIndex = 6;
    ((ControlBase) this.buttonPrint).Text = "Print Results";
    ((Control) this.buttonPrint).Visible = false;
    ((Control) this.buttonStep2Back).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance16.BackColor = Color.Gainsboro;
    appearance16.BackColor2 = Color.White;
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep2Back).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonStep2Back).Location = new Point(669, 8);
    ((Control) this.buttonStep2Back).Name = "buttonStep2Back";
    ((Control) this.buttonStep2Back).Size = new Size(100, 24);
    ((Control) this.buttonStep2Back).TabIndex = 0;
    ((ControlBase) this.buttonStep2Back).Text = "< &Back";
    ((Control) this.buttonStep2Next).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance17.BackColor = Color.Gainsboro;
    appearance17.BackColor2 = Color.White;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep2Next).Appearance = (AppearanceBase) appearance17;
    ((Control) this.buttonStep2Next).Location = new Point(773, 8);
    ((Control) this.buttonStep2Next).Name = "buttonStep2Next";
    ((Control) this.buttonStep2Next).Size = new Size(100, 24);
    ((Control) this.buttonStep2Next).TabIndex = 1;
    ((ControlBase) this.buttonStep2Next).Text = "&Next >";
    ((Control) this.buttonStep2Cancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance18.BackColor = Color.Gainsboro;
    appearance18.BackColor2 = Color.White;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep2Cancel).Appearance = (AppearanceBase) appearance18;
    ((Control) this.buttonStep2Cancel).Location = new Point(885, 8);
    ((Control) this.buttonStep2Cancel).Name = "buttonStep2Cancel";
    ((Control) this.buttonStep2Cancel).Size = new Size(75, 24);
    ((Control) this.buttonStep2Cancel).TabIndex = 2;
    ((ControlBase) this.buttonStep2Cancel).Text = "&Cancel";
    this.PictureBox2.Dock = DockStyle.Fill;
    this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(0, 0);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(967, 40);
    this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox2.TabIndex = 3;
    this.PictureBox2.TabStop = false;
    this.Panel3.BackColor = Color.Transparent;
    this.Panel3.BackgroundImage = (Image) resourceManager.GetObject("Panel3.BackgroundImage");
    this.Panel3.Controls.Add((Control) this.PictureBox3);
    this.Panel3.Controls.Add((Control) this.Label1);
    this.Panel3.Controls.Add((Control) this.Label4);
    this.Panel3.Dock = DockStyle.Top;
    this.Panel3.Location = new Point(0, 0);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(967, 80 /*0x50*/);
    this.Panel3.TabIndex = 0;
    this.PictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
    this.PictureBox3.Location = new Point(895, 8);
    this.PictureBox3.Name = "PictureBox3";
    this.PictureBox3.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox3.TabIndex = 2;
    this.PictureBox3.TabStop = false;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.ForeColor = Color.White;
    this.Label1.Location = new Point(16 /*0x10*/, 40);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(872, 32 /*0x20*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Here you can also choose to search for items  for a specific company. When you have finished specifying the search criteria, click the 'Calculate Sweep Amount' button to retreive your results.";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.White;
    this.Label4.Location = new Point(8, 8);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(416, 26);
    this.Label4.TabIndex = 0;
    this.Label4.Text = "Company Selection and Sweep Calculation";
    ((Control) this.gridSweepList).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridSweepList, "gridContext");
    ((UltraGridBase) this.gridSweepList).DataMember = "InvoiceList";
    ((UltraGridBase) this.gridSweepList).DataSource = (object) this.DsSweepAutomation1;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    appearance20.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Post Date";
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 73;
    ultraGridColumn2.CellActivation = (Activation) 3;
    appearance21.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 61;
    ultraGridColumn3.CellActivation = (Activation) 3;
    appearance22.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance22;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 109;
    ultraGridColumn4.CellActivation = (Activation) 3;
    appearance23.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Policy #";
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 79;
    ultraGridColumn5.CellActivation = (Activation) 3;
    appearance24.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Insured";
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 116;
    ultraGridColumn6.CellActivation = (Activation) 3;
    appearance25.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Description";
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 102;
    ultraGridColumn7.CellActivation = (Activation) 3;
    appearance26.TextHAlign = (HAlign) 3;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance26;
    ultraGridColumn7.Format = "c";
    appearance27.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Net Billed";
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Width = 74;
    ultraGridColumn8.CellActivation = (Activation) 3;
    appearance28.TextHAlign = (HAlign) 3;
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance28;
    ultraGridColumn8.Format = "c";
    appearance29.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Amt Rcvd";
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Width = 66;
    ultraGridColumn9.CellActivation = (Activation) 3;
    appearance30.TextHAlign = (HAlign) 3;
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn9.Format = "c";
    appearance31.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Gross Comm.";
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn9.Width = 82;
    ultraGridColumn10.CellActivation = (Activation) 3;
    appearance32.TextHAlign = (HAlign) 3;
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance32;
    ultraGridColumn10.Format = "c";
    appearance33.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Company Gross";
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Width = 97;
    ultraGridColumn11.CellActivation = (Activation) 3;
    appearance34.TextHAlign = (HAlign) 3;
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance34;
    ultraGridColumn11.Format = "c";
    appearance35.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "AP Balance";
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Width = 73;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 72;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 95;
    ultraGridColumn14.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn14.Header).Caption = "";
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn14.Width = 27;
    ultraGridBand.Columns.AddRange(new object[14]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((UltraGridBase) this.gridSweepList).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridSweepList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance36.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance37.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance37;
    appearance38.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance39.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance39;
    appearance40.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance41.BackColor = Color.Transparent;
    appearance41.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = Color.WhiteSmoke;
    appearance42.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance42;
    appearance43.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraControlBase) this.gridSweepList).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridSweepList).Location = new Point(2, 120);
    ((Control) this.gridSweepList).Name = "gridSweepList";
    ((Control) this.gridSweepList).Size = new Size(961, 302);
    ((UltraControlBase) this.gridSweepList).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridSweepList).TabIndex = 4;
    this.DsSweepAutomation1.DataSetName = "dsSweepAutomation";
    this.DsSweepAutomation1.Locale = new CultureInfo("en-US");
    this.pictureLoading.BackColor = Color.White;
    this.pictureLoading.Font = new Font("Tahoma", 8f);
    this.pictureLoading.ForeColor = Color.Black;
    this.pictureLoading.Image = (Image) resourceManager.GetObject("pictureLoading.Image");
    this.pictureLoading.Location = new Point(0, 120);
    this.pictureLoading.Name = "pictureLoading";
    this.pictureLoading.Size = new Size(968, 304);
    this.pictureLoading.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureLoading.TabIndex = 0;
    this.pictureLoading.TabStop = false;
    this.pictureLoading.Visible = false;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "GridContext";
    ultraToolbar.Visible = false;
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "gridContext";
    ((ToolBase) popupMenuTool).SharedProps.Category = "GridContext";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    appearance44.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance44.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance44;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Select All";
    ((ToolBase) buttonTool3).SharedProps.Category = "GridContext";
    appearance45.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance45.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance45;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Un-Select All";
    ((ToolBase) buttonTool4).SharedProps.Category = "GridContext";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left).Name = "_formSweepAutomationWizard_Toolbars_Dock_Area_Left";
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left).Size = new Size(0, 470);
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right).Location = new Point(967, 0);
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right).Name = "_formSweepAutomationWizard_Toolbars_Dock_Area_Right";
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right).Size = new Size(0, 470);
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top).Name = "_formSweepAutomationWizard_Toolbars_Dock_Area_Top";
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top).Size = new Size(967, 0);
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom).Location = new Point(0, 470);
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom).Name = "_formSweepAutomationWizard_Toolbars_Dock_Area_Bottom";
    ((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom).Size = new Size(967, 0);
    this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.panelConfirmation.BackColor = Color.White;
    this.panelConfirmation.Controls.Add((Control) this.datePostDate);
    this.panelConfirmation.Controls.Add((Control) this.textComments);
    this.panelConfirmation.Controls.Add((Control) this.labelTotalSweepAmount);
    this.panelConfirmation.Controls.Add((Control) this.labelDestinationBankAccount);
    this.panelConfirmation.Controls.Add((Control) this.labelSourceBankAccount);
    this.panelConfirmation.Controls.Add((Control) this.Label18);
    this.panelConfirmation.Controls.Add((Control) this.Label17);
    this.panelConfirmation.Controls.Add((Control) this.Label16);
    this.panelConfirmation.Controls.Add((Control) this.Label15);
    this.panelConfirmation.Controls.Add((Control) this.Label12);
    this.panelConfirmation.Controls.Add((Control) this.Panel4);
    this.panelConfirmation.Controls.Add((Control) this.Panel5);
    this.panelConfirmation.Dock = DockStyle.Fill;
    this.panelConfirmation.Location = new Point(0, 0);
    this.panelConfirmation.Name = "panelConfirmation";
    this.panelConfirmation.Size = new Size(967, 470);
    this.panelConfirmation.TabIndex = 8;
    this.panelConfirmation.Visible = false;
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.datePostDate.Appearance = (AppearanceBase) appearance46;
    appearance47.AlphaLevel = (short) 14;
    appearance47.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance47.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance47.BackColorAlpha = (Alpha) 2;
    appearance47.BackGradientAlignment = (GradientAlignment) 4;
    appearance47.BackGradientStyle = (GradientStyle) 5;
    appearance47.BorderAlpha = (Alpha) 1;
    appearance47.BorderColor = Color.FromArgb(78, 122, 171);
    appearance47.ForeColor = Color.FromArgb(49, 85, 153);
    appearance47.ForegroundAlpha = (Alpha) 2;
    this.datePostDate.ButtonAppearance = (AppearanceBase) appearance47;
    ((Control) this.datePostDate).Location = new Point(352, 256 /*0x0100*/);
    this.datePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.datePostDate).Name = "datePostDate";
    ((Control) this.datePostDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.datePostDate).TabIndex = 13;
    appearance48.BackColor = Color.White;
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance48.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance48;
    ((Control) this.textComments).Location = new Point(352, 312);
    ((TextEditorControlBase) this.textComments).MaxLength = 500;
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(336, 72);
    ((Control) this.textComments).TabIndex = 12;
    this.labelTotalSweepAmount.AutoSize = true;
    this.labelTotalSweepAmount.Location = new Point(352, 208 /*0xD0*/);
    this.labelTotalSweepAmount.Name = "labelTotalSweepAmount";
    this.labelTotalSweepAmount.Size = new Size(130, 16 /*0x10*/);
    this.labelTotalSweepAmount.TabIndex = 11;
    this.labelTotalSweepAmount.Text = "[TOTAL SWEEP AMOUNT]";
    this.labelDestinationBankAccount.AutoSize = true;
    this.labelDestinationBankAccount.Location = new Point(352, 160 /*0xA0*/);
    this.labelDestinationBankAccount.Name = "labelDestinationBankAccount";
    this.labelDestinationBankAccount.Size = new Size(164, 16 /*0x10*/);
    this.labelDestinationBankAccount.TabIndex = 10;
    this.labelDestinationBankAccount.Text = "[DESTINATION BANK ACCOUNT]";
    this.labelSourceBankAccount.AutoSize = true;
    this.labelSourceBankAccount.Location = new Point(352, 112 /*0x70*/);
    this.labelSourceBankAccount.Name = "labelSourceBankAccount";
    this.labelSourceBankAccount.Size = new Size(135, 16 /*0x10*/);
    this.labelSourceBankAccount.TabIndex = 9;
    this.labelSourceBankAccount.Text = "[SOURCE BANK ACCOUNT]";
    this.Label18.AutoSize = true;
    this.Label18.Location = new Point(352, 240 /*0xF0*/);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(55, 16 /*0x10*/);
    this.Label18.TabIndex = 8;
    this.Label18.Text = "Post Date:";
    this.Label17.AutoSize = true;
    this.Label17.Location = new Point(352, 296);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(94, 16 /*0x10*/);
    this.Label17.TabIndex = 7;
    this.Label17.Text = "Posting Comments";
    this.Label16.AutoSize = true;
    this.Label16.Location = new Point(352, 192 /*0xC0*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(105, 16 /*0x10*/);
    this.Label16.TabIndex = 6;
    this.Label16.Text = "Total Sweep Amount";
    this.Label15.AutoSize = true;
    this.Label15.Location = new Point(352, 144 /*0x90*/);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(101, 16 /*0x10*/);
    this.Label15.TabIndex = 5;
    this.Label15.Text = "Destination Account";
    this.Label12.AutoSize = true;
    this.Label12.Location = new Point(352, 96 /*0x60*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(79, 16 /*0x10*/);
    this.Label12.TabIndex = 4;
    this.Label12.Text = "Source Account";
    this.Panel4.Controls.Add((Control) this.buttonConfirmBack);
    this.Panel4.Controls.Add((Control) this.buttonConfirmFinish);
    this.Panel4.Controls.Add((Control) this.buttonConfirmCancel);
    this.Panel4.Controls.Add((Control) this.PictureBox6);
    this.Panel4.Dock = DockStyle.Bottom;
    this.Panel4.Location = new Point(0, 430);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(967, 40);
    this.Panel4.TabIndex = 3;
    ((Control) this.buttonConfirmBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance49.BackColor = Color.Gainsboro;
    appearance49.BackColor2 = Color.White;
    appearance49.BackGradientStyle = (GradientStyle) 2;
    appearance49.BorderColor = Color.Gray;
    ((ControlBase) this.buttonConfirmBack).Appearance = (AppearanceBase) appearance49;
    ((Control) this.buttonConfirmBack).Location = new Point(669, 8);
    ((Control) this.buttonConfirmBack).Name = "buttonConfirmBack";
    ((Control) this.buttonConfirmBack).Size = new Size(100, 24);
    ((Control) this.buttonConfirmBack).TabIndex = 0;
    ((ControlBase) this.buttonConfirmBack).Text = "< &Back";
    ((Control) this.buttonConfirmFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance50.BackColor = Color.Gainsboro;
    appearance50.BackColor2 = Color.White;
    appearance50.BackGradientStyle = (GradientStyle) 2;
    appearance50.BorderColor = Color.Gray;
    ((ControlBase) this.buttonConfirmFinish).Appearance = (AppearanceBase) appearance50;
    ((Control) this.buttonConfirmFinish).Location = new Point(773, 8);
    ((Control) this.buttonConfirmFinish).Name = "buttonConfirmFinish";
    ((Control) this.buttonConfirmFinish).Size = new Size(100, 24);
    ((Control) this.buttonConfirmFinish).TabIndex = 1;
    ((ControlBase) this.buttonConfirmFinish).Text = "Finish";
    ((Control) this.buttonConfirmCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance51.BackColor = Color.Gainsboro;
    appearance51.BackColor2 = Color.White;
    appearance51.BackGradientStyle = (GradientStyle) 2;
    appearance51.BorderColor = Color.Gray;
    ((ControlBase) this.buttonConfirmCancel).Appearance = (AppearanceBase) appearance51;
    ((Control) this.buttonConfirmCancel).Location = new Point(885, 8);
    ((Control) this.buttonConfirmCancel).Name = "buttonConfirmCancel";
    ((Control) this.buttonConfirmCancel).Size = new Size(75, 24);
    ((Control) this.buttonConfirmCancel).TabIndex = 2;
    ((ControlBase) this.buttonConfirmCancel).Text = "&Cancel";
    this.PictureBox6.Dock = DockStyle.Fill;
    this.PictureBox6.Image = (Image) resourceManager.GetObject("PictureBox6.Image");
    this.PictureBox6.Location = new Point(0, 0);
    this.PictureBox6.Name = "PictureBox6";
    this.PictureBox6.Size = new Size(967, 40);
    this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox6.TabIndex = 3;
    this.PictureBox6.TabStop = false;
    this.Panel5.BackColor = Color.Transparent;
    this.Panel5.BackgroundImage = (Image) resourceManager.GetObject("Panel5.BackgroundImage");
    this.Panel5.Controls.Add((Control) this.PictureBox7);
    this.Panel5.Controls.Add((Control) this.Label13);
    this.Panel5.Controls.Add((Control) this.Label14);
    this.Panel5.Dock = DockStyle.Top;
    this.Panel5.Location = new Point(0, 0);
    this.Panel5.Name = "Panel5";
    this.Panel5.Size = new Size(967, 80 /*0x50*/);
    this.Panel5.TabIndex = 0;
    this.PictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.PictureBox7.Image = (Image) resourceManager.GetObject("PictureBox7.Image");
    this.PictureBox7.Location = new Point(895, 8);
    this.PictureBox7.Name = "PictureBox7";
    this.PictureBox7.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox7.TabIndex = 2;
    this.PictureBox7.TabStop = false;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.ForeColor = Color.White;
    this.Label13.Location = new Point(16 /*0x10*/, 40);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(888, 32 /*0x20*/);
    this.Label13.TabIndex = 1;
    this.Label13.Text = "Please review the following information and verify the information is correct. You can also specify a posting date and posting comment. If the information is correct and you wish to post this transaction, click the 'Finish' button.";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.White;
    this.Label14.Location = new Point(8, 8);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(133, 26);
    this.Label14.TabIndex = 0;
    this.Label14.Text = "Confirmation";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(967, 470);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelStep2);
    this.Controls.Add((Control) this.panelStart);
    this.Controls.Add((Control) this.panelStep1);
    this.Controls.Add((Control) this.panelConfirmation);
    this.Controls.Add((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formSweepAutomationWizard_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formSweepAutomationWizard);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Sweep Automation Wizard";
    this.panelStart.ResumeLayout(false);
    this.Panel9.ResumeLayout(false);
    this.Panel8.ResumeLayout(false);
    ((ISupportInitialize) this.btnStartNext).EndInit();
    ((ISupportInitialize) this.btnStartCancel).EndInit();
    this.panelStep1.ResumeLayout(false);
    ((ISupportInitialize) this.comboDestinationBankAccount).EndInit();
    this.DsBankAccounts2.EndInit();
    ((ISupportInitialize) this.dateRangeFrom).EndInit();
    ((ISupportInitialize) this.dateRangeTo).EndInit();
    ((ISupportInitialize) this.textARReceivedPercentage).EndInit();
    ((ISupportInitialize) this.comboSourceBankAccounts).EndInit();
    this.DsBankAccounts1.EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.panelSourceAccountFooter.ResumeLayout(false);
    ((ISupportInitialize) this.buttonStep1Back).EndInit();
    ((ISupportInitialize) this.buttonStep1Next).EndInit();
    ((ISupportInitialize) this.buttonStep1Cancel).EndInit();
    this.panelSourceAccountHeader.ResumeLayout(false);
    this.panelStep2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonClearCompanySelection).EndInit();
    ((ISupportInitialize) this.buttonSearchCompany).EndInit();
    ((ISupportInitialize) this.textCompanyName).EndInit();
    ((ISupportInitialize) this.buttonGetInvoices).EndInit();
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonPrint).EndInit();
    ((ISupportInitialize) this.buttonStep2Back).EndInit();
    ((ISupportInitialize) this.buttonStep2Next).EndInit();
    ((ISupportInitialize) this.buttonStep2Cancel).EndInit();
    this.Panel3.ResumeLayout(false);
    ((ISupportInitialize) this.gridSweepList).EndInit();
    this.DsSweepAutomation1.EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.panelConfirmation.ResumeLayout(false);
    ((ISupportInitialize) this.datePostDate).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    this.Panel4.ResumeLayout(false);
    ((ISupportInitialize) this.buttonConfirmBack).EndInit();
    ((ISupportInitialize) this.buttonConfirmFinish).EndInit();
    ((ISupportInitialize) this.buttonConfirmCancel).EndInit();
    this.Panel5.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset().spFin_GetOfficeLocations;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
  }

  private void CancelHandler(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will cancel the Sweep Automation wizard, continue?", "Cancel Sweep Automation Wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void ClickHandler(object sender, EventArgs e)
  {
    if (sender == this.buttonStep1Next && (!this.IsOfficeLocationSelected() || !this.IsBankAccountSelected() || !this.IsPercentValid()))
      return;
    if (sender == this.buttonStep2Next)
      this.BuildConfirmationScreen();
    if (sender == this.buttonConfirmBack)
      ((UltraGridBase) this.gridSweepList).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    this.panelStart.Visible = sender == this.buttonStep1Back;
    this.panelStep1.Visible = sender == this.buttonStep2Back | sender == this.btnStartNext;
    this.panelStep2.Visible = sender == this.buttonStep1Next | sender == this.buttonConfirmBack;
    this.panelConfirmation.Visible = sender == this.buttonStep2Next;
  }

  private void LoadBankAccounts(int glCompanyId)
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spfin_GetBankAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      this.DsSweepAutomation1.Clear();
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
      sqlDataAdapter.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
      sqlDataAdapter.Fill((DataTable) this.DsBankAccounts2.spFin_GetBankAccounts);
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    this.LoadBankAccounts(int.Parse(this.comboOfficeLocation.Value.ToString()));
  }

  private bool IsPercentValid()
  {
    bool flag;
    if (!((TextEditorControlBase) this.textARReceivedPercentage).Text.Equals(string.Empty))
    {
      if (Versioned.IsNumeric((object) ((TextEditorControlBase) this.textARReceivedPercentage).Text))
      {
        try
        {
          if (!(int.Parse(((TextEditorControlBase) this.textARReceivedPercentage).Text, NumberStyles.Integer) > 0 & int.Parse(((TextEditorControlBase) this.textARReceivedPercentage).Text, NumberStyles.Integer) <= 100))
          {
            int num = (int) MessageBox.Show("AR Percentage must be a valid number between 1 and 100.", "Invalid AR Received Percentage!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_7;
          }
        }
        catch (FormatException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("AR Percentage must be a valid number between 1 and 100.", "Invalid AR Received Percentage!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          ProjectData.ClearProjectError();
          goto label_7;
        }
        flag = true;
        goto label_7;
      }
    }
    int num1 = (int) MessageBox.Show("AR Percentage must be a valid number between 1 and 100.", "Invalid AR Received Percentage!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    flag = false;
label_7:
    return flag;
  }

  private bool IsOfficeLocationSelected()
  {
    bool flag;
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool IsBankAccountSelected()
  {
    bool flag;
    if (((UltraDropDownBase) this.comboSourceBankAccounts).SelectedRow == null || ((UltraDropDownBase) this.comboDestinationBankAccount).SelectedRow == null || this.comboDestinationBankAccount.Text.Equals(string.Empty) || this.comboSourceBankAccounts.Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must select a source and destination bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void CalculateSweepAutomation()
  {
    this.pictureLoading.Visible = true;
    this.pictureLoading.BringToFront();
    this.Cursor = Cursors.WaitCursor;
    this.Refresh();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spfin_SweepAutomation", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.CommandTimeout = 300;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) int.Parse(this.comboOfficeLocation.Value.ToString()));
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@fromdate", (object) this.dateRangeFrom.DateTime.Date);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@todate", (object) this.dateRangeTo.DateTime.Date);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@percentageAggregate", (object) int.Parse(((TextEditorControlBase) this.textARReceivedPercentage).Text));
      if (((Control) this.textCompanyName).Tag != null)
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@companyGuid", (object) ((Control) this.textCompanyName).Tag.ToString());
      this.DsSweepAutomation1.Clear();
      sqlDataAdapter.Fill((DataTable) this.DsSweepAutomation1.InvoiceList);
      ((Control) this.buttonPrint).Visible = this.DsSweepAutomation1.InvoiceList.Rows.Count > 0;
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
      this.pictureLoading.Visible = false;
      this.pictureLoading.SendToBack();
      this.Cursor = Cursors.Default;
    }
  }

  private bool ValidateForm()
  {
    bool flag;
    if (this.dateRangeFrom.DateTime.Equals((object) DBNull.Value) || this.dateRangeTo.DateTime.Equals((object) DBNull.Value))
    {
      int num = (int) MessageBox.Show("You must specify a date range to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void buttonGetInvoices_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.CalculateSweepAutomation();
    this.BuildGridSummaries();
  }

  private void buttonSearchCompany_Click(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.ShowCompanyGroup | MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.ShowCompany | MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.ShowCompanyLocations | MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.ShowCompanyLines);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((TextEditorControlBase) this.textCompanyName).Text = formSearchEntity.EntityName;
      ((Control) this.textCompanyName).Tag = (object) formSearchEntity.EntityGuid.ToString();
      ((Control) this.buttonClearCompanySelection).Enabled = true;
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void buttonClearCompanySelection_Click(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.textCompanyName).Text = "All Companies";
    ((Control) this.textCompanyName).Tag = (object) null;
    ((Control) sender).Enabled = false;
  }

  private void BuildGridSummaries()
  {
    UltraGridBand band = ((UltraGridBase) this.gridSweepList).DisplayLayout.Bands[0];
    band.Summaries.Clear();
    band.Summaries.Add("InvoiceTotalSum", (SummaryType) 1, band.Columns["InvoiceTotal"], (SummaryPosition) 3);
    band.Summaries.Add("AmtRcvdSum", (SummaryType) 1, band.Columns["AmtRcvd"], (SummaryPosition) 3);
    band.Summaries.Add("GrossCommissionSum", (SummaryType) 1, band.Columns["GrossCommission"], (SummaryPosition) 3);
    band.Summaries.Add("CompanyGrossSum", (SummaryType) 1, band.Columns["CompanyGross"], (SummaryPosition) 3);
    band.Summaries.Add("PaidToDateSum", (SummaryType) 1, band.Columns["PaidTodate"], (SummaryPosition) 3);
    try
    {
      foreach (SummarySettings summary in (IEnumerable) band.Summaries)
      {
        summary.DisplayFormat = "{0:c}";
        summary.Appearance.TextHAlign = (HAlign) 3;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      string key = ((ToolEventArgs) e).Tool.Key;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "SelectAll", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "UnSelectAll", false) != 0)
          return;
        UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridSweepList).Rows.GetFilteredInNonGroupByRows();
        int index = 0;
        while (index < inNonGroupByRows.Length)
        {
          inNonGroupByRows[index].Cells["Select"].Value = (object) false;
          checked { ++index; }
        }
      }
      else
      {
        UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridSweepList).Rows.GetFilteredInNonGroupByRows();
        int index = 0;
        while (index < inNonGroupByRows.Length)
        {
          inNonGroupByRows[index].Cells["Select"].Value = (object) true;
          checked { ++index; }
        }
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void buttonConfirmFinish_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.PostTransaction();
  }

  private void BuildConfirmationScreen()
  {
    this.labelSourceBankAccount.Text = this.comboSourceBankAccounts.Text;
    this.labelDestinationBankAccount.Text = this.comboDestinationBankAccount.Text;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    Decimal d1 = 0M;
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridSweepList).Rows.GetFilteredInNonGroupByRows();
    int index = 0;
    while (index < inNonGroupByRows.Length)
    {
      UltraGridRow ultraGridRow = inNonGroupByRows[index];
      d1 = Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["CompanyGross"].Value.ToString(), NumberStyles.Currency));
      checked { ++index; }
    }
    this.labelTotalSweepAmount.Text = d1.ToString("c");
  }

  private void PostTransaction()
  {
    this.LogSweepAutomation(BankingServices.TransferFunds(int.Parse(this.comboSourceBankAccounts.Value.ToString()), int.Parse(this.comboDestinationBankAccount.Value.ToString()), this.datePostDate.DateTime.Date, Decimal.Parse(this.labelTotalSweepAmount.Text, NumberStyles.Currency), ((TextEditorControlBase) this.textComments).Text, CurrentUser.Instance.UserGUID));
    int num = (int) MessageBox.Show("Sweep done successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void LogSweepAutomation(int transactionNumber)
  {
    SqlCommand sqlCommand = new SqlCommand("spFin_LogInvoiceSweepAutomation", new SqlConnection(CurrentUser.Instance.ConnectionString));
    sqlCommand.CommandType = CommandType.StoredProcedure;
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    ((UltraGridBase) this.gridSweepList).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    try
    {
      sqlCommand.Connection.Open();
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridSweepList).Rows.GetFilteredInNonGroupByRows();
      int index = 0;
      while (index < inNonGroupByRows.Length)
      {
        UltraGridRow ultraGridRow = inNonGroupByRows[index];
        sqlCommand.Parameters.Clear();
        sqlCommand.Parameters.AddWithValue("@transactNum", (object) transactionNumber);
        sqlCommand.Parameters.AddWithValue("@invoiceNum", (object) int.Parse(ultraGridRow.Cells["invoiceNumber"].Value.ToString()));
        sqlCommand.ExecuteNonQuery();
        checked { ++index; }
      }
    }
    finally
    {
      if (sqlCommand.Connection.State != ConnectionState.Closed)
        sqlCommand.Connection.Close();
      sqlCommand.Connection.Dispose();
      sqlCommand.Dispose();
    }
  }

  private bool VerifyForm()
  {
    bool flag;
    if (int.Parse(this.comboSourceBankAccounts.Value.ToString()) == int.Parse(this.comboDestinationBankAccount.Value.ToString()))
    {
      int num = (int) MessageBox.Show("You can not transfer money to and from the same bank account.", "Invalid Bank Configuration!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (Decimal.Compare(Decimal.Parse(this.labelTotalSweepAmount.Text, NumberStyles.Currency), 0M) == 0)
    {
      int num = (int) MessageBox.Show("You have not selected any items to sweep. The resulting transaction would be a zero dollar transfer. This function can not continue. Please specify at least one item to sweep to continue.", "No Sweep Amount Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (DateTime.Compare(this.datePostDate.DateTime.Date, AccountingCache.Instance.GlCompany(int.Parse(this.comboOfficeLocation.Value.ToString())).CloseDate) <= 0)
    {
      int num = (int) MessageBox.Show("The post date specified would violate the accounting period for the selected office location because the accounting period is closed.", "Invalid Post Date!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void PrintReport()
  {
    dsSweepAutomation dsSweepAutomation = new dsSweepAutomation();
    foreach (UltraGridRow row1 in ((UltraGridBase) this.gridSweepList).Rows)
    {
      dsSweepAutomation.InvoiceListRow row2 = (dsSweepAutomation.InvoiceListRow) dsSweepAutomation.InvoiceList.NewRow();
      if (bool.Parse(row1.Cells["Select"].Value.ToString()))
      {
        row2.AmtRcvd = Decimal.Parse(row1.Cells["AmtRcvd"].Value.ToString(), NumberStyles.Currency);
        row2.Company = row1.Cells["Company"].Value.ToString();
        row2.CompanyGross = Decimal.Parse(row1.Cells["CompanyGross"].Value.ToString(), NumberStyles.Currency);
        row2.GrossCommission = Decimal.Parse(row1.Cells["GrossCommission"].Value.ToString(), NumberStyles.Currency);
        row2.InsuredName = row1.Cells["InsuredName"].Value.ToString();
        row2.InvoiceNumber = int.Parse(row1.Cells["InvoiceNumber"].Value.ToString(), NumberStyles.Any);
        row2.InvoiceTotal = Decimal.Parse(row1.Cells["InvoiceTotal"].Value.ToString(), NumberStyles.Currency);
        row2.OfficeInvoiceNumber = int.Parse(row1.Cells["OfficeInvoiceNumber"].Value.ToString(), NumberStyles.Currency);
        row2.PaidToDate = Decimal.Parse(row1.Cells["PaidToDate"].Value.ToString(), NumberStyles.Currency);
        row2.PercentReceived = Decimal.Parse(row1.Cells["PercentReceived"].Value.ToString(), NumberStyles.Currency);
        row2.PolicyNumber = row1.Cells["PolicyNumber"].Value.ToString();
        row2.PostDate = DateTime.Parse(row1.Cells["PostDate"].Value.ToString());
        row2.QuoteDescription = row1.Cells["QuoteDescription"].Value.ToString();
      }
      dsSweepAutomation.InvoiceList.Rows.Add((DataRow) row2);
    }
  }

  private void buttonPrint_Click(object sender, EventArgs e) => this.PrintReport();
}
