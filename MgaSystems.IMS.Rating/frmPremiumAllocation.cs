// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmPremiumAllocation
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.Generic;
using MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class frmPremiumAllocation : Form
{
  private IContainer components;
  private UltraDropDown ddCompanies;
  private UltraDropDown ddStates;
  private UltraDropDown ddOffices;
  private SqlConnection cn;
  private dsPremiumAllocation ds;
  private SqlDataAdapter daCompanyPremiums;
  private SqlDataAdapter daStatePremiums;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlUpdateCommand2;
  private SqlCommand SqlDeleteCommand2;
  private SqlDataAdapter daQuoteOption;
  private SqlDataAdapter daOptionsGeneric;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand3;
  private SqlCommand SqlUpdateCommand3;
  private SqlCommand SqlDeleteCommand3;
  private SqlCommand SqlSelectCommand4;
  private SqlCommand SqlInsertCommand4;
  private SqlCommand SqlUpdateCommand4;
  private SqlCommand SqlDeleteCommand4;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private readonly Quote _quote;
  private readonly RaterGeneric _genericRater;
  private bool _exported;
  private Thread _exportThread;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid gridCompanyPremiums
  {
    get => this._gridCompanyPremiums;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.gridCompanyPremiums_AfterRowInsert);
      CellEventHandler cellEventHandler = new CellEventHandler(this.gridCompanyPremiums_CellChange);
      UltraGrid gridCompanyPremiums1 = this._gridCompanyPremiums;
      if (gridCompanyPremiums1 != null)
      {
        gridCompanyPremiums1.AfterRowInsert -= rowEventHandler;
        gridCompanyPremiums1.CellChange -= cellEventHandler;
      }
      this._gridCompanyPremiums = value;
      UltraGrid gridCompanyPremiums2 = this._gridCompanyPremiums;
      if (gridCompanyPremiums2 == null)
        return;
      gridCompanyPremiums2.AfterRowInsert += rowEventHandler;
      gridCompanyPremiums2.CellChange += cellEventHandler;
    }
  }

  private virtual UltraGrid gridStateTIV
  {
    get => this._gridStateTIV;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.gridStateTIV_AfterRowInsert);
      CellEventHandler cellEventHandler = new CellEventHandler(this.gridStateTIV_CellChange);
      EventHandler eventHandler = new EventHandler(this.gridStateTIV_AfterExitEditMode);
      UltraGrid gridStateTiv1 = this._gridStateTIV;
      if (gridStateTiv1 != null)
      {
        gridStateTiv1.AfterRowInsert -= rowEventHandler;
        gridStateTiv1.CellChange -= cellEventHandler;
        gridStateTiv1.AfterExitEditMode -= eventHandler;
      }
      this._gridStateTIV = value;
      UltraGrid gridStateTiv2 = this._gridStateTIV;
      if (gridStateTiv2 == null)
        return;
      gridStateTiv2.AfterRowInsert += rowEventHandler;
      gridStateTiv2.CellChange += cellEventHandler;
      gridStateTiv2.AfterExitEditMode += eventHandler;
    }
  }

  private virtual MGAButton btnExport
  {
    get => this._btnExport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExport_Click);
      MGAButton btnExport1 = this._btnExport;
      if (btnExport1 != null)
        ((Control) btnExport1).Click -= eventHandler;
      this._btnExport = value;
      MGAButton btnExport2 = this._btnExport;
      if (btnExport2 == null)
        return;
      ((Control) btnExport2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkAllocationReport
  {
    get => this._lnkAllocationReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAllocationReport_LinkClicked);
      LinkLabel allocationReport1 = this._lnkAllocationReport;
      if (allocationReport1 != null)
        allocationReport1.LinkClicked -= clickedEventHandler;
      this._lnkAllocationReport = value;
      LinkLabel allocationReport2 = this._lnkAllocationReport;
      if (allocationReport2 == null)
        return;
      allocationReport2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkImportAllocationData
  {
    get => this._lnkImportAllocationData;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkImportAllocationData_LinkClicked);
      LinkLabel importAllocationData1 = this._lnkImportAllocationData;
      if (importAllocationData1 != null)
        importAllocationData1.LinkClicked -= clickedEventHandler;
      this._lnkImportAllocationData = value;
      LinkLabel importAllocationData2 = this._lnkImportAllocationData;
      if (importAllocationData2 == null)
        return;
      importAllocationData2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkImportExcelFromDocSystem
  {
    get => this._lnkImportExcelFromDocSystem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkImportExcelFromDocSystem_LinkClicked);
      LinkLabel excelFromDocSystem1 = this._lnkImportExcelFromDocSystem;
      if (excelFromDocSystem1 != null)
        excelFromDocSystem1.LinkClicked -= clickedEventHandler;
      this._lnkImportExcelFromDocSystem = value;
      LinkLabel excelFromDocSystem2 = this._lnkImportExcelFromDocSystem;
      if (excelFromDocSystem2 == null)
        return;
      excelFromDocSystem2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkClearAllocation
  {
    get => this._lnkClearAllocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearAllocation_LinkClicked);
      LinkLabel lnkClearAllocation1 = this._lnkClearAllocation;
      if (lnkClearAllocation1 != null)
        lnkClearAllocation1.LinkClicked -= clickedEventHandler;
      this._lnkClearAllocation = value;
      LinkLabel lnkClearAllocation2 = this._lnkClearAllocation;
      if (lnkClearAllocation2 == null)
        return;
      lnkClearAllocation2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelPleaseWait")]
  internal virtual UltraGroupBox panelPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  internal virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkExcelImport
  {
    get => this._lnkExcelImport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExcelImport_LinkClicked);
      LinkLabel lnkExcelImport1 = this._lnkExcelImport;
      if (lnkExcelImport1 != null)
        lnkExcelImport1.LinkClicked -= clickedEventHandler;
      this._lnkExcelImport = value;
      LinkLabel lnkExcelImport2 = this._lnkExcelImport;
      if (lnkExcelImport2 == null)
        return;
      lnkExcelImport2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPremiumAllocationCompanies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PremiumID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLocationGUID", -1, (object) "ddCompanies");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Premium");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TerrorismPremium");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Rate");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TerrorismRate");
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
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("tblCompanyLocationstblPremiumAllocationCompanies");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyLocationstblPremiumAllocationCompanies", 0);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PremiumID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("TerrorismPremium");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Rate");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("TerrorismRate");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblPremiumAllocationStates", -1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("AllocationID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("TIV");
    Appearance appearance34 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("QuotingLocationID", -1, (object) "ddOffices");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("State", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("lstStatestblPremiumAllocationStates");
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstStatestblPremiumAllocationStates", 0);
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("AllocationID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("TIV");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("QuotingLocationID");
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Location", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("tblClientOfficestblPremiumAllocationStates");
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblClientOfficestblPremiumAllocationStates", 0);
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("AllocationID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("TIV");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("QuotingLocationID");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPremiumAllocation));
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    this.gridCompanyPremiums = new UltraGrid();
    this.ds = new dsPremiumAllocation();
    this.ddCompanies = new UltraDropDown();
    this.gridStateTIV = new UltraGrid();
    this.btnExport = new MGAButton();
    this.ddStates = new UltraDropDown();
    this.ddOffices = new UltraDropDown();
    this.cn = new SqlConnection();
    this.daCompanyPremiums = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daStatePremiums = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.daQuoteOption = new SqlDataAdapter();
    this.SqlDeleteCommand3 = new SqlCommand();
    this.SqlInsertCommand3 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand3 = new SqlCommand();
    this.daOptionsGeneric = new SqlDataAdapter();
    this.SqlDeleteCommand4 = new SqlCommand();
    this.SqlInsertCommand4 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand4 = new SqlCommand();
    this.lnkAllocationReport = new LinkLabel();
    this.btnSave = new MGAButton();
    this.lnkImportAllocationData = new LinkLabel();
    this.lnkExcelImport = new LinkLabel();
    this.lnkImportExcelFromDocSystem = new LinkLabel();
    this.lnkClearAllocation = new LinkLabel();
    this.panelPleaseWait = new UltraGroupBox();
    this.PictureBox1 = new PictureBox();
    this.UltraLabel1 = new UltraLabel();
    ((ISupportInitialize) this.gridCompanyPremiums).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddCompanies).BeginInit();
    ((ISupportInitialize) this.gridStateTIV).BeginInit();
    ((ISupportInitialize) this.btnExport).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.ddOffices).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    ((Control) this.gridCompanyPremiums).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridCompanyPremiums).DataSource = (object) this.ds.tblPremiumAllocationCompanies;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Click here to add another company...";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 44;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 169;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 145;
    appearance4.ForeColor = Color.Green;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 100;
    appearance6.ForeColor = Color.Green;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Terrorism Premium";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 140;
    ultraGridColumn6.CellActivation = (Activation) 1;
    appearance8.BackColor = Color.FromArgb(240 /*0xF0*/, 240 /*0xF0*/, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance9;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 106;
    ultraGridColumn7.CellActivation = (Activation) 1;
    appearance10.BackColor = Color.FromArgb(240 /*0xF0*/, 240 /*0xF0*/, 240 /*0xF0*/);
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Terrorism Rate";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 104;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.LightSteelBlue;
    appearance12.FontData.SizeInPoints = 10f;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance14.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance18.BackColor = Color.Transparent;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCompanyPremiums).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    ((Control) this.gridCompanyPremiums).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridCompanyPremiums).Location = new Point(8, 8);
    ((Control) this.gridCompanyPremiums).Name = "gridCompanyPremiums";
    ((Control) this.gridCompanyPremiums).Size = new Size(616, 168);
    ((Control) this.gridCompanyPremiums).TabIndex = 0;
    ((Control) this.gridCompanyPremiums).Text = "Premium by Company";
    ((UltraControlBase) this.gridCompanyPremiums).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCompanyPremiums).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPremiumAllocation";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddCompanies).DataSource = (object) this.ds.tblCompanyLocations;
    appearance19.BackColor = SystemColors.Window;
    appearance19.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Company";
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 281;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn14.Header.VisiblePosition = 3;
    ultraGridColumn15.Header.VisiblePosition = 4;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ultraGridColumn17.Header.VisiblePosition = 6;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance20.BackColor = SystemColors.ActiveBorder;
    appearance20.BackColor2 = SystemColors.ControlDark;
    appearance20.BackGradientStyle = (GradientStyle) 2;
    appearance20.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance20;
    appearance21.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance21;
    ((SpecialBoxBase) ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance22.BackColor = SystemColors.ControlLightLight;
    appearance22.BackColor2 = SystemColors.Control;
    appearance22.BackGradientStyle = (GradientStyle) 3;
    appearance22.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.MaxRowScrollRegions = 1;
    appearance23.BackColor = SystemColors.Window;
    appearance23.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance23;
    appearance24.BackColor = SystemColors.Highlight;
    appearance24.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance25.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance25;
    appearance26.BorderColor = Color.Silver;
    appearance26.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellPadding = 0;
    appearance27.BackColor = SystemColors.Control;
    appearance27.BackColor2 = SystemColors.ControlDark;
    appearance27.BackGradientAlignment = (GradientAlignment) 1;
    appearance27.BackGradientStyle = (GradientStyle) 3;
    appearance27.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance29.BackColor = SystemColors.Window;
    appearance29.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance30.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddCompanies).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.ddCompanies).DropDownWidth = 300;
    ((Control) this.ddCompanies).Location = new Point(104, 64 /*0x40*/);
    ((Control) this.ddCompanies).Name = "ddCompanies";
    ((Control) this.ddCompanies).Size = new Size(160 /*0xA0*/, 64 /*0x40*/);
    ((Control) this.ddCompanies).TabIndex = 1;
    ((UltraDropDownBase) this.ddCompanies).ValueMember = "CompanyLocationGUID";
    ((Control) this.ddCompanies).Visible = false;
    ((Control) this.gridStateTIV).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridStateTIV).DataSource = (object) this.ds.tblPremiumAllocationStates;
    appearance31.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.gridStateTIV).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance31;
    appearance32.BackColor = Color.WhiteSmoke;
    appearance32.BorderColor = Color.WhiteSmoke;
    appearance32.FontData.UnderlineAsString = "True";
    appearance32.ForeColor = Color.Blue;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance32;
    ((SpecialBoxBase) ((UltraGridBase) this.gridStateTIV).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.gridStateTIV).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Appearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.AddButtonCaption = "Click here to add another state...";
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 52;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 186;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "State";
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn20.Style = (ColumnStyle) 6;
    ultraGridColumn20.Width = 113;
    appearance34.ForeColor = Color.Green;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance34;
    ultraGridColumn21.Format = "c";
    ultraGridColumn21.Header.VisiblePosition = 4;
    ultraGridColumn21.MaskDisplayMode = (MaskMode) 1;
    ultraGridColumn21.MaskInput = "{LOC}nnnn,nnn,nnn,nnn";
    ultraGridColumn21.MinWidth = 11;
    ultraGridColumn21.Width = 211;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Quoting Office";
    ultraGridColumn22.Header.VisiblePosition = 3;
    ultraGridColumn22.Style = (ColumnStyle) 6;
    ultraGridColumn22.Width = 271;
    ultraGridBand4.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance35.BackColor = Color.LightSteelBlue;
    appearance35.FontData.SizeInPoints = 10f;
    appearance35.ForeColor = Color.Black;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance35;
    appearance36.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance37.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance37;
    appearance38.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance39.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance39;
    appearance40.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance41.BackColor = Color.Transparent;
    appearance41.ForeColor = Color.Black;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance41;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridStateTIV).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridStateTIV).Location = new Point(8, 184);
    ((Control) this.gridStateTIV).Name = "gridStateTIV";
    ((Control) this.gridStateTIV).Size = new Size(616, 197);
    ((Control) this.gridStateTIV).TabIndex = 2;
    ((Control) this.gridStateTIV).Text = "TIV by State";
    ((UltraControlBase) this.gridStateTIV).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridStateTIV).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnExport).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance42.BackColor = Color.FromArgb(248, 248, 248);
    appearance42.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance42.BackGradientStyle = (GradientStyle) 2;
    appearance42.BorderColor = Color.DarkGray;
    appearance42.ImageHAlign = (HAlign) 2;
    appearance42.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnExport).Appearance = (AppearanceBase) appearance42;
    ((ControlBase) this.btnExport).ImageSize = new Size(24, 24);
    ((Control) this.btnExport).Location = new Point(440, 447);
    ((Control) this.btnExport).Name = "btnExport";
    ((Control) this.btnExport).Size = new Size(136, 40);
    ((Control) this.btnExport).TabIndex = 3;
    ((ControlBase) this.btnExport).Text = "Export Premium Data";
    this.btnExport.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds.lstStates;
    appearance43.BackColor = SystemColors.Window;
    appearance43.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddStates).DisplayLayout.Appearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.ddStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn23.Header.VisiblePosition = 0;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn24.Header.VisiblePosition = 1;
    ultraGridColumn24.Width = 182;
    ultraGridColumn25.Header.VisiblePosition = 2;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25
    });
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn27.Header.VisiblePosition = 1;
    ultraGridColumn28.Header.VisiblePosition = 2;
    ultraGridColumn29.Header.VisiblePosition = 3;
    ultraGridColumn30.Header.VisiblePosition = 4;
    ultraGridBand6.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddStates).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance44.BackColor = SystemColors.ActiveBorder;
    appearance44.BackColor2 = SystemColors.ControlDark;
    appearance44.BackGradientStyle = (GradientStyle) 2;
    appearance44.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance44;
    appearance45.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance45;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance46.BackColor = SystemColors.ControlLightLight;
    appearance46.BackColor2 = SystemColors.Control;
    appearance46.BackGradientStyle = (GradientStyle) 3;
    appearance46.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.ddStates).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.MaxRowScrollRegions = 1;
    appearance47.BackColor = SystemColors.Window;
    appearance47.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance47;
    appearance48.BackColor = SystemColors.Highlight;
    appearance48.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance49.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance49;
    appearance50.BorderColor = Color.Silver;
    appearance50.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellPadding = 0;
    appearance51.BackColor = SystemColors.Control;
    appearance51.BackColor2 = SystemColors.ControlDark;
    appearance51.BackGradientAlignment = (GradientAlignment) 1;
    appearance51.BackGradientStyle = (GradientStyle) 3;
    appearance51.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance51;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance53.BackColor = SystemColors.Window;
    appearance53.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance54.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(32 /*0x20*/, 280);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(184, 72);
    ((Control) this.ddStates).TabIndex = 4;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((UltraGridBase) this.ddOffices).DataSource = (object) this.ds.tblClientOffices;
    appearance55.BackColor = SystemColors.Window;
    appearance55.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Appearance = (AppearanceBase) appearance55;
    ((UltraGridBase) this.ddOffices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn31.Header.VisiblePosition = 0;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 104;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Quoting Office";
    ultraGridColumn32.Header.VisiblePosition = 1;
    ultraGridColumn32.Width = 281;
    ultraGridColumn33.Header.VisiblePosition = 2;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33
    });
    ultraGridColumn34.Header.VisiblePosition = 0;
    ultraGridColumn35.Header.VisiblePosition = 1;
    ultraGridColumn36.Header.VisiblePosition = 2;
    ultraGridColumn37.Header.VisiblePosition = 3;
    ultraGridColumn38.Header.VisiblePosition = 4;
    ultraGridBand8.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38
    });
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ddOffices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddOffices).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance56.BackColor = SystemColors.ActiveBorder;
    appearance56.BackColor2 = SystemColors.ControlDark;
    appearance56.BackGradientStyle = (GradientStyle) 2;
    appearance56.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddOffices).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance56;
    appearance57.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddOffices).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance57;
    ((SpecialBoxBase) ((UltraGridBase) this.ddOffices).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance58.BackColor = SystemColors.ControlLightLight;
    appearance58.BackColor2 = SystemColors.Control;
    appearance58.BackGradientStyle = (GradientStyle) 3;
    appearance58.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddOffices).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.ddOffices).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddOffices).DisplayLayout.MaxRowScrollRegions = 1;
    appearance59.BackColor = SystemColors.Window;
    appearance59.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance59;
    appearance60.BackColor = SystemColors.Highlight;
    appearance60.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance61.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance61;
    appearance62.BorderColor = Color.Silver;
    appearance62.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.CellPadding = 0;
    appearance63.BackColor = SystemColors.Control;
    appearance63.BackColor2 = SystemColors.ControlDark;
    appearance63.BackGradientAlignment = (GradientAlignment) 1;
    appearance63.BackGradientStyle = (GradientStyle) 3;
    appearance63.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance63;
    ((AppearanceBase) appearance64).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance65.BackColor = SystemColors.Window;
    appearance65.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance66.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddOffices).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.ddOffices).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddOffices).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddOffices).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddOffices).DisplayMember = "Location";
    ((UltraDropDownBase) this.ddOffices).DropDownWidth = 300;
    ((Control) this.ddOffices).Location = new Point(224 /*0xE0*/, 280);
    ((Control) this.ddOffices).Name = "ddOffices";
    ((Control) this.ddOffices).Size = new Size(184, 72);
    ((Control) this.ddOffices).TabIndex = 5;
    ((UltraDropDownBase) this.ddOffices).ValueMember = "OfficeID";
    ((Control) this.ddOffices).Visible = false;
    this.cn.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True;Persist Security Info=False;Packet Size=4096;Workstation ID=PSARNOWSKI";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daCompanyPremiums.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanyPremiums.InsertCommand = this.SqlInsertCommand1;
    this.daCompanyPremiums.SelectCommand = this.SqlSelectCommand1;
    this.daCompanyPremiums.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPremiumAllocationCompanies", new DataColumnMapping[7]
      {
        new DataColumnMapping("PremiumID", "PremiumID"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("CompanyLocationGUID", "CompanyLocationGUID"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("TerrorismPremium", "TerrorismPremium"),
        new DataColumnMapping("Rate", "Rate"),
        new DataColumnMapping("TerrorismRate", "TerrorismRate")
      })
    });
    this.daCompanyPremiums.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblPremiumAllocationCompanies] WHERE (([PremiumID] = @Original_PremiumID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_PremiumID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PremiumID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@CompanyLocationGUID", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGUID"),
      new SqlParameter("@Premium", SqlDbType.BigInt, 0, "Premium"),
      new SqlParameter("@TerrorismPremium", SqlDbType.BigInt, 0, "TerrorismPremium"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 20, (byte) 17, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@TerrorismRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 20, (byte) 17, "TerrorismRate", DataRowVersion.Current, (object) null)
    });
    this.SqlSelectCommand1.CommandText = "SELECT     PremiumID, QuoteGuid, CompanyLocationGUID, Premium, TerrorismPremium, Rate, TerrorismRate\r\nFROM         dbo.tblPremiumAllocationCompanies\r\nWHERE     (QuoteGuid = @QuoteGuid)";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@CompanyLocationGUID", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGUID"),
      new SqlParameter("@Premium", SqlDbType.BigInt, 0, "Premium"),
      new SqlParameter("@TerrorismPremium", SqlDbType.BigInt, 0, "TerrorismPremium"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 20, (byte) 17, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@TerrorismRate", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 20, (byte) 17, "TerrorismRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Original_PremiumID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PremiumID", DataRowVersion.Original, (object) null),
      new SqlParameter("@PremiumID", SqlDbType.Int, 4, "PremiumID")
    });
    this.daStatePremiums.DeleteCommand = this.SqlDeleteCommand2;
    this.daStatePremiums.InsertCommand = this.SqlInsertCommand2;
    this.daStatePremiums.SelectCommand = this.SqlSelectCommand2;
    this.daStatePremiums.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPremiumAllocationStates", new DataColumnMapping[5]
      {
        new DataColumnMapping("AllocationID", "AllocationID"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("TIV", "TIV"),
        new DataColumnMapping("QuotingLocationID", "QuotingLocationID")
      })
    });
    this.daStatePremiums.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblPremiumAllocationStates] WHERE (([AllocationID] = @Original_AllocationID))";
    this.SqlDeleteCommand2.Connection = this.cn;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_AllocationID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AllocationID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cn;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@TIV", SqlDbType.BigInt, 0, "TIV"),
      new SqlParameter("@QuotingLocationID", SqlDbType.Int, 0, "QuotingLocationID")
    });
    this.SqlSelectCommand2.CommandText = "SELECT     AllocationID, QuoteGuid, StateID, TIV, QuotingLocationID\r\nFROM         dbo.tblPremiumAllocationStates\r\nWHERE     (QuoteGuid = @QuoteGuid)";
    this.SqlSelectCommand2.Connection = this.cn;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cn;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@TIV", SqlDbType.BigInt, 0, "TIV"),
      new SqlParameter("@QuotingLocationID", SqlDbType.Int, 0, "QuotingLocationID"),
      new SqlParameter("@Original_AllocationID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AllocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@AllocationID", SqlDbType.Int, 4, "AllocationID")
    });
    this.daQuoteOption.DeleteCommand = this.SqlDeleteCommand3;
    this.daQuoteOption.InsertCommand = this.SqlInsertCommand3;
    this.daQuoteOption.SelectCommand = this.SqlSelectCommand3;
    this.daQuoteOption.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptions", new DataColumnMapping[4]
      {
        new DataColumnMapping("QuoteGUID", "QuoteGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("CompanyLocationID", "CompanyLocationID"),
        new DataColumnMapping("QuoteOptionGUID", "QuoteOptionGUID")
      })
    });
    this.daQuoteOption.UpdateCommand = this.SqlUpdateCommand3;
    this.SqlDeleteCommand3.CommandText = "DELETE FROM tblQuoteOptions WHERE (QuoteOptionGUID = @Original_QuoteOptionGUID)";
    this.SqlDeleteCommand3.Connection = this.cn;
    this.SqlDeleteCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand3.CommandText = "INSERT INTO tblQuoteOptions(QuoteGUID, LineGUID, CompanyLocationID, QuoteOptionGUID) VALUES (@QuoteGUID, @LineGUID, @CompanyLocationID, @QuoteOptionGUID)";
    this.SqlInsertCommand3.Connection = this.cn;
    this.SqlInsertCommand3.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@CompanyLocationID", SqlDbType.Int, 4, "CompanyLocationID"),
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID")
    });
    this.SqlSelectCommand3.CommandText = "SELECT QuoteGUID, LineGUID, CompanyLocationID, QuoteOptionGUID FROM tblQuoteOptions";
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlUpdateCommand3.CommandText = "UPDATE tblQuoteOptions SET QuoteGUID = @QuoteGUID, LineGUID = @LineGUID, CompanyLocationID = @CompanyLocationID, QuoteOptionGUID = @QuoteOptionGUID WHERE (QuoteOptionGUID = @Original_QuoteOptionGUID)";
    this.SqlUpdateCommand3.Connection = this.cn;
    this.SqlUpdateCommand3.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@CompanyLocationID", SqlDbType.Int, 4, "CompanyLocationID"),
      new SqlParameter("@QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGUID"),
      new SqlParameter("@Original_QuoteOptionGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionGUID", DataRowVersion.Original, (object) null)
    });
    this.daOptionsGeneric.DeleteCommand = this.SqlDeleteCommand4;
    this.daOptionsGeneric.InsertCommand = this.SqlInsertCommand4;
    this.daOptionsGeneric.SelectCommand = this.SqlSelectCommand4;
    this.daOptionsGeneric.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionGeneric", new DataColumnMapping[6]
      {
        new DataColumnMapping("GenericID", "GenericID"),
        new DataColumnMapping("QuoteOptionGuid", "QuoteOptionGuid"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate")
      })
    });
    this.daOptionsGeneric.UpdateCommand = this.SqlUpdateCommand4;
    this.SqlDeleteCommand4.CommandText = "DELETE FROM tblQuoteOptionGeneric WHERE (GenericID = @Original_GenericID)";
    this.SqlDeleteCommand4.Connection = this.cn;
    this.SqlDeleteCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_GenericID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GenericID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand4.CommandText = "INSERT INTO tblQuoteOptionGeneric(QuoteOptionGuid, ChargeCode, OfficeID, Premium, EffectiveDate) VALUES (@QuoteOptionGuid, @ChargeCode, @OfficeID, @Premium, @EffectiveDate)";
    this.SqlInsertCommand4.Connection = this.cn;
    this.SqlInsertCommand4.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate")
    });
    this.SqlSelectCommand4.CommandText = "SELECT GenericID, QuoteOptionGuid, ChargeCode, OfficeID, Premium, EffectiveDate FROM tblQuoteOptionGeneric";
    this.SqlSelectCommand4.Connection = this.cn;
    this.SqlUpdateCommand4.CommandText = componentResourceManager.GetString("SqlUpdateCommand4.CommandText");
    this.SqlUpdateCommand4.Connection = this.cn;
    this.SqlUpdateCommand4.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteOptionGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteOptionGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      new SqlParameter("@OfficeID", SqlDbType.Int, 4, "OfficeID"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@EffectiveDate", SqlDbType.DateTime, 8, "EffectiveDate"),
      new SqlParameter("@Original_GenericID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GenericID", DataRowVersion.Original, (object) null)
    });
    this.lnkAllocationReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAllocationReport.Location = new Point(5, 393);
    this.lnkAllocationReport.Name = "lnkAllocationReport";
    this.lnkAllocationReport.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lnkAllocationReport.TabIndex = 6;
    this.lnkAllocationReport.TabStop = true;
    this.lnkAllocationReport.Text = "Allocation Report";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance67.BackColor = Color.Gainsboro;
    appearance67.BackColor2 = Color.White;
    appearance67.BackGradientStyle = (GradientStyle) 2;
    appearance67.BorderColor = Color.Gray;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance67;
    ((Control) this.btnSave).Location = new Point(584, 447);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 7;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkImportAllocationData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkImportAllocationData.Location = new Point(5, 419);
    this.lnkImportAllocationData.Name = "lnkImportAllocationData";
    this.lnkImportAllocationData.Size = new Size(256 /*0x0100*/, 16 /*0x10*/);
    this.lnkImportAllocationData.TabIndex = 8;
    this.lnkImportAllocationData.TabStop = true;
    this.lnkImportAllocationData.Text = "Import Allocation Data From Another IMS Quote";
    this.lnkExcelImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkExcelImport.Location = new Point(5, 445);
    this.lnkExcelImport.Name = "lnkExcelImport";
    this.lnkExcelImport.Size = new Size(341, 16 /*0x10*/);
    this.lnkExcelImport.TabIndex = 9;
    this.lnkExcelImport.TabStop = true;
    this.lnkExcelImport.Text = "Import Allocation Data From a Microsoft Excel Spreadsheet On Disk";
    this.lnkImportExcelFromDocSystem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkImportExcelFromDocSystem.Location = new Point(5, 471);
    this.lnkImportExcelFromDocSystem.Name = "lnkImportExcelFromDocSystem";
    this.lnkImportExcelFromDocSystem.Size = new Size(322, 16 /*0x10*/);
    this.lnkImportExcelFromDocSystem.TabIndex = 10;
    this.lnkImportExcelFromDocSystem.TabStop = true;
    this.lnkImportExcelFromDocSystem.Text = "Import From Microsoft Excel Spreadsheet In Document System";
    this.lnkClearAllocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearAllocation.Location = new Point(514, 393);
    this.lnkClearAllocation.Name = "lnkClearAllocation";
    this.lnkClearAllocation.Size = new Size(110, 16 /*0x10*/);
    this.lnkClearAllocation.TabIndex = 11;
    this.lnkClearAllocation.TabStop = true;
    this.lnkClearAllocation.Text = "Clear Allocation";
    this.lnkClearAllocation.TextAlign = ContentAlignment.TopRight;
    appearance68.BackColor = Color.Transparent;
    this.panelPleaseWait.Appearance = (AppearanceBase) appearance68;
    appearance69.BackColor = Color.White;
    appearance69.BorderColor = Color.DimGray;
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance69;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.UltraLabel1);
    ((Control) this.panelPleaseWait).Location = new Point(105, 200);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(422, 74);
    ((Control) this.panelPleaseWait).TabIndex = 12;
    ((Control) this.panelPleaseWait).Visible = false;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(21, 19);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(36, 36);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    appearance70.FontData.SizeInPoints = 12f;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance70;
    ((AutoSizeControlBase) this.UltraLabel1).AutoSize = true;
    ((Control) this.UltraLabel1).Location = new Point(72, 26);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(343, 22);
    ((Control) this.UltraLabel1).TabIndex = 1;
    ((ControlBase) this.UltraLabel1).Text = "Please wait while your premium is exported ...";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(632, 501);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.lnkClearAllocation);
    this.Controls.Add((Control) this.lnkImportExcelFromDocSystem);
    this.Controls.Add((Control) this.lnkExcelImport);
    this.Controls.Add((Control) this.lnkImportAllocationData);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkAllocationReport);
    this.Controls.Add((Control) this.ddOffices);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.btnExport);
    this.Controls.Add((Control) this.gridStateTIV);
    this.Controls.Add((Control) this.ddCompanies);
    this.Controls.Add((Control) this.gridCompanyPremiums);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmPremiumAllocation);
    this.Text = "Premium Allocation";
    ((ISupportInitialize) this.gridCompanyPremiums).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddCompanies).EndInit();
    ((ISupportInitialize) this.gridStateTIV).EndInit();
    ((ISupportInitialize) this.btnExport).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.ddOffices).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
  }

  public frmPremiumAllocation(Guid quoteGuid, RaterGeneric genericRater)
  {
    this.FormClosing += new FormClosingEventHandler(this.frmPremiumAllocation_FormClosing);
    this.Load += new EventHandler(this.frmPremiumAllocation_Load);
    this.Closing += new CancelEventHandler(this.frmPremiumAllocation_Closing);
    this.InitializeComponent();
    this._quote = new Quote(quoteGuid);
    this._genericRater = genericRater;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  public bool Exported => this._exported;

  private void frmPremiumAllocation_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this._exportThread == null || !this._exportThread.IsAlive)
      return;
    this._exportThread.Abort();
  }

  private void frmPremiumAllocation_Load(object sender, EventArgs e)
  {
    MGAButton btnSave = this.btnSave;
    ((ControlBase) btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) btnSave).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) btnSave).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) btnSave).ImageTransparentColor = Color.Magenta;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "tblCompanyLocations",
      "lstStates",
      "tblClientOffices"
    }, "dbo.GetPremiumAllocationData", new object[2]
    {
      (object) "@quoteGuid",
      (object) this._quote.QuoteGuid
    });
    try
    {
      this.daCompanyPremiums.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyPremiums, (DataTable) this.ds.tblPremiumAllocationCompanies);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) System.Windows.Forms.MessageBox.Show("The carrier(s) on the allocation does not match that on the quote. It is likely that the carrier was changed.\n\nPlease reconcile the carrier(s) on the allocation with that on the quote.", "Carriers Do Not Match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    this.daStatePremiums.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    this.daStatePremiums.Fill((DataTable) this.ds.tblPremiumAllocationStates);
    this.EnableControls();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateData(true))
      return;
    this.Close();
  }

  private void EnableControls()
  {
    if (!this._quote.IsBound)
      return;
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is UltraGrid || control is MGAButton)
          control.Enabled = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnExport_Click(object sender, EventArgs e)
  {
    if (!this.ValidateData(false))
      return;
    this.SaveData();
    if (this._quote.OptionCount > 0)
    {
      if (System.Windows.Forms.MessageBox.Show("This quote currently has premium assigned to it.\n\nExporting data from this screen will remove any current premium on the policy.\n\nDo you want to continue with the export?", "Remove Existing Premium?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        return;
      MDIControls.Instance.MDIParent.Refresh();
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET InstallmentBillingQuoteOptionID=NULL WHERE InstallmentBillingQuoteOptionID IN (SELECT QuoteOptionID FROM tblQuoteOptions WHERE QuoteGuid=@QuoteGuid)", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptions WHERE QuoteGuid=@QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
    }
    this.SendPremiums();
  }

  private bool ValidateData(bool allowZeroPremium)
  {
    bool flag;
    if (((UltraGridBase) this.gridCompanyPremiums).Rows.Count == 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("A company must be selected in order to proceed", "No Company Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraGridBase) this.gridStateTIV).Rows.Count == 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("A state must be selected in order to proceed", "No State Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.ds.tblPremiumAllocationStates.Select($"StateID = '{this._quote.StateID}'").Length == 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("TIV allocation is required in the state of issuance.", "No TIV In State of Issuance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.ds.tblPremiumAllocationStates.Select("TIV = 0").Length > 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("TIV must be greater than 0.", "TIV Equals Zero.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!allowZeroPremium && this.ds.tblPremiumAllocationCompanies.Select("Premium + TerrorismPremium = 0").Length > 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("Premium must be greater than 0.", "Premium Equals Zero.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCompanyPremiums).Rows)
      {
        dsPremiumAllocation.tblPremiumAllocationCompaniesRow byPremiumId = this.ds.tblPremiumAllocationCompanies.FindByPremiumID(Conversions.ToInteger(row.Cells["PremiumID"].Value));
        if (Decimal.Compare(Decimal.Truncate(byPremiumId.Rate), 99M) > 0)
        {
          int num = (int) System.Windows.Forms.MessageBox.Show($"The calcualated rate of {byPremiumId.Rate.ToString()} is too large.\n\nPlease adjust the TIV and premium.", "Rate Too Large", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          goto label_19;
        }
        if (Decimal.Compare(Decimal.Truncate(byPremiumId.TerrorismRate), 99M) > 0)
        {
          int num = (int) System.Windows.Forms.MessageBox.Show($"The calculated terrorism rate of {byPremiumId.TerrorismRate.ToString()} is too large.\n\nPlease adjust the TIV and terrorism premium.", "Terrorism Rate Too Large", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          goto label_19;
        }
        if (row.Cells["Premium"].Value == DBNull.Value || row.Cells["Premium"].Value == null)
          row.Cells["Premium"].Value = (object) 0;
      }
      flag = true;
    }
label_19:
    return flag;
  }

  private bool SendPremiums()
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((Control) this.panelPleaseWait).Visible = true;
    ((UltraGridBase) this.gridCompanyPremiums).UpdateData();
    ((UltraGridBase) this.gridStateTIV).UpdateData();
    this._exportThread = new Thread(new ThreadStart(this.SendPremiumsThread));
    this._exportThread.Name = "Export Allocated Premiums";
    this._exportThread.Start();
    bool flag;
    return flag;
  }

  private void AdjustPremiumRounding()
  {
    int integer1 = Conversions.ToInteger(this.ds.tblQuoteOptionGeneric.Compute("SUM(Premium) - SUM(TerrorismPremium)", string.Empty));
    int integer2 = Conversions.ToInteger(this.ds.tblPremiumAllocationCompanies.Compute("SUM(Premium)", string.Empty));
    if (integer1 != integer2)
    {
      dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow1 = (dsPremiumAllocation.tblQuoteOptionGenericRow) this.ds.tblQuoteOptionGeneric.Select("ChargeCode=" + RatingFunctions.GetPremiumChargeCode(this._quote.StateID, "PREM").ToString())[0];
      if (integer1 < integer2)
      {
        dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow2;
        Decimal num = Decimal.Add((optionGenericRow2 = optionGenericRow1).Premium, new Decimal(integer2 - integer1));
        optionGenericRow2.Premium = num;
      }
      else if (Decimal.Compare(Decimal.Subtract(optionGenericRow1.Premium, new Decimal(integer1 - integer2)), 0M) > 0)
      {
        dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow3;
        Decimal num = Decimal.Subtract((optionGenericRow3 = optionGenericRow1).Premium, new Decimal(integer1 - integer2));
        optionGenericRow3.Premium = num;
      }
    }
    int integer3 = Conversions.ToInteger(this.ds.tblQuoteOptionGeneric.Compute("SUM(TerrorismPremium)", string.Empty));
    int integer4 = Conversions.ToInteger(this.ds.tblPremiumAllocationCompanies.Compute("SUM(TerrorismPremium)", string.Empty));
    if (integer3 == integer4)
      return;
    dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow4 = (dsPremiumAllocation.tblQuoteOptionGenericRow) this.ds.tblQuoteOptionGeneric.Select("ChargeCode=" + RatingFunctions.GetPremiumChargeCode(this._quote.StateID, "TERR").ToString())[0];
    if (integer3 < integer4)
    {
      dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow5;
      Decimal num = Decimal.Add((optionGenericRow5 = optionGenericRow4).Premium, new Decimal(integer4 - integer3));
      optionGenericRow5.Premium = num;
    }
    else
    {
      if (Decimal.Compare(Decimal.Subtract(optionGenericRow4.Premium, new Decimal(integer3 - integer4)), 0M) <= 0)
        return;
      dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow6;
      Decimal num = Decimal.Subtract((optionGenericRow6 = optionGenericRow4).Premium, new Decimal(integer3 - integer4));
      optionGenericRow6.Premium = num;
    }
  }

  private void SendPremiumsThread()
  {
    try
    {
      foreach (dsPremiumAllocation.tblPremiumAllocationCompaniesRow allocationCompany in (TypedTableBase<dsPremiumAllocation.tblPremiumAllocationCompaniesRow>) this.ds.tblPremiumAllocationCompanies)
      {
        dsPremiumAllocation.tblQuoteOptionsRow row = this.ds.tblQuoteOptions.NewtblQuoteOptionsRow();
        dsPremiumAllocation.tblQuoteOptionsRow tblQuoteOptionsRow = row;
        tblQuoteOptionsRow.CompanyLocationID = new CompanyLocation(allocationCompany.CompanyLocationGUID).CompanyLocationID;
        tblQuoteOptionsRow.LineGUID = this._genericRater.LineGuid;
        tblQuoteOptionsRow.QuoteGUID = this._quote.QuoteGuid;
        tblQuoteOptionsRow.QuoteOptionGUID = Guid.NewGuid();
        this.ds.tblQuoteOptions.AddtblQuoteOptionsRow(row);
        if (allocationCompany.Premium != 0L)
          this.SendPremium(row.QuoteOptionGUID, allocationCompany, "PREM");
        if (allocationCompany.TerrorismPremium != 0L)
          this.SendPremium(row.QuoteOptionGUID, allocationCompany, "TERR");
      }
    }
    finally
    {
      IEnumerator<dsPremiumAllocation.tblPremiumAllocationCompaniesRow> enumerator;
      enumerator?.Dispose();
    }
    this.AdjustPremiumRounding();
    this.DoCustomPremiumWork(this._quote.StateID, this.ds.tblQuoteOptionGeneric);
    if (this.SendPremiumToDatabase())
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.CloseForm));
    }
    else
    {
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new MethodInvoker(this.CloseForm));
    }
  }

  private void ExportFailed()
  {
    ((Control) this.panelPleaseWait).Visible = false;
    this.Cursor = MgaCursors.Default;
  }

  private void CloseForm()
  {
    this._exported = true;
    this.Close();
  }

  protected virtual void DoCustomPremiumWork(
    string stateOfIssuance,
    dsPremiumAllocation.tblQuoteOptionGenericDataTable dtGeneric)
  {
  }

  private void SendPremium(
    Guid quoteOptionGuid,
    dsPremiumAllocation.tblPremiumAllocationCompaniesRow drCompany,
    string chargeID)
  {
    try
    {
      foreach (dsPremiumAllocation.tblPremiumAllocationStatesRow premiumAllocationState in (TypedTableBase<dsPremiumAllocation.tblPremiumAllocationStatesRow>) this.ds.tblPremiumAllocationStates)
      {
        int premiumChargeCode = RatingFunctions.GetPremiumChargeCode(premiumAllocationState.StateID, chargeID);
        DataRow[] dataRowArray = this.ds.tblQuoteOptionGeneric.Select("ChargeCode=" + premiumChargeCode.ToString());
        dsPremiumAllocation.tblQuoteOptionGenericRow row;
        if (dataRowArray.Length > 0)
        {
          row = (dsPremiumAllocation.tblQuoteOptionGenericRow) dataRowArray[0];
        }
        else
        {
          row = this.ds.tblQuoteOptionGeneric.NewtblQuoteOptionGenericRow();
          dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow = row;
          optionGenericRow.ChargeCode = premiumChargeCode;
          optionGenericRow.OfficeID = premiumAllocationState.QuotingLocationID;
          optionGenericRow.QuoteOptionGuid = quoteOptionGuid;
          optionGenericRow.EffectiveDate = DateTime.Now;
          optionGenericRow.Premium = 0M;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(chargeID, "PREM", false) == 0)
        {
          dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow;
          Decimal num = Decimal.Add((optionGenericRow = row).Premium, new Decimal((int) Math.Round((double) premiumAllocationState.TIV / 100.0 * Convert.ToDouble(drCompany.Rate))));
          optionGenericRow.Premium = num;
        }
        else
        {
          dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow1;
          Decimal num1 = Decimal.Add((optionGenericRow1 = row).Premium, new Decimal((int) Math.Round((double) premiumAllocationState.TIV / 100.0 * Convert.ToDouble(drCompany.TerrorismRate))));
          optionGenericRow1.Premium = num1;
          dsPremiumAllocation.tblQuoteOptionGenericRow optionGenericRow2;
          int num2 = (optionGenericRow2 = row).TerrorismPremium + (int) Math.Round((double) premiumAllocationState.TIV / 100.0 * Convert.ToDouble(drCompany.TerrorismRate));
          optionGenericRow2.TerrorismPremium = num2;
        }
        if (row.RowState == DataRowState.Detached)
          this.ds.tblQuoteOptionGeneric.AddtblQuoteOptionGenericRow(row);
      }
    }
    finally
    {
      IEnumerator<dsPremiumAllocation.tblPremiumAllocationStatesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private bool SendPremiumToDatabase()
  {
    string empty = string.Empty;
    bool database;
    if (this.HasInvalidCompanyLines(ref empty))
    {
      MGASystems.Common.ThreadingFunctions.MessageBox.Show($"One or more companies selected is not authorized to write {this._genericRater.LineName} in the states selected.\n\nPlease verify a valid company/line setup exists for all premium combinations selected.\n\n{empty}", "Invalid Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      database = false;
    }
    else
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        try
        {
          frmPremiumAllocation.AssignTransactions(this.daQuoteOption, (SqlTransaction) args.Transaction);
          frmPremiumAllocation.AssignTransactions(this.daOptionsGeneric, (SqlTransaction) args.Transaction);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daQuoteOption, (DataTable) this.ds.tblQuoteOptions);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daOptionsGeneric, (DataTable) this.ds.tblQuoteOptionGeneric);
          args.Transaction.Commit();
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (args.Transaction != null)
            args.Transaction.Rollback();
          throw;
        }
      }));
      database = true;
    }
    return database;
  }

  private bool HasInvalidCompanyLines(ref string messStr)
  {
    bool flag1 = false;
    StringBuilder stringBuilder = new StringBuilder();
    string lineName = this._quote.LineName;
    Guid lineGuid = this._quote.LineGuid;
    stringBuilder.AppendLine("The following company/lines were setup for allocation but are not valid:");
    messStr = string.Empty;
    try
    {
      foreach (dsPremiumAllocation.tblPremiumAllocationCompaniesRow allocationCompany in (TypedTableBase<dsPremiumAllocation.tblPremiumAllocationCompaniesRow>) this.ds.tblPremiumAllocationCompanies)
      {
        try
        {
          foreach (dsPremiumAllocation.tblPremiumAllocationStatesRow premiumAllocationState in (TypedTableBase<dsPremiumAllocation.tblPremiumAllocationStatesRow>) this.ds.tblPremiumAllocationStates)
          {
            bool flag2 = true;
            bool flag3 = false;
            CompanyLocation companyLocation = new CompanyLocation(allocationCompany.CompanyLocationGUID);
            try
            {
              if (!CompanyLine.IsValidCompanyLine(allocationCompany.CompanyLocationGUID, lineGuid, premiumAllocationState.StateID))
              {
                flag3 = true;
                flag1 = true;
              }
            }
            catch (Exception ex1)
            {
              ProjectData.SetProjectError(ex1);
              Exception ex2 = ex1;
              flag2 = false;
              flag1 = true;
              if (ex2.Message.Contains("CompanyLineGuidNotFoundException"))
              {
                flag3 = true;
                stringBuilder.AppendLine($"Company:{companyLocation.LocationName}  Line:{lineName}  State: {premiumAllocationState.StateID}");
              }
              else
                ErrorHandler.HandleError(ex2);
              ProjectData.ClearProjectError();
            }
            if (flag3 & flag2)
              stringBuilder.AppendLine($"Company:{companyLocation.LocationName}  Line:{lineName}  State: {premiumAllocationState.StateID}");
          }
        }
        finally
        {
          IEnumerator<dsPremiumAllocation.tblPremiumAllocationStatesRow> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<dsPremiumAllocation.tblPremiumAllocationCompaniesRow> enumerator;
      enumerator?.Dispose();
    }
    messStr = stringBuilder.ToString();
    return flag1;
  }

  private static void AssignTransactions(SqlDataAdapter adapter, SqlTransaction trans)
  {
    SqlDataAdapter sqlDataAdapter = adapter;
    sqlDataAdapter.SelectCommand.Transaction = trans;
    sqlDataAdapter.UpdateCommand.Transaction = trans;
    sqlDataAdapter.DeleteCommand.Transaction = trans;
    sqlDataAdapter.InsertCommand.Transaction = trans;
  }

  private void SaveData()
  {
    if (((UltraGridBase) this.gridCompanyPremiums).ActiveRow != null)
      ((UltraGridBase) this.gridCompanyPremiums).ActiveRow.Update();
    if (((UltraGridBase) this.gridStateTIV).ActiveRow != null)
      ((UltraGridBase) this.gridStateTIV).ActiveRow.Update();
    ((UltraControlBase) this.gridCompanyPremiums).EndUpdate();
    ((UltraControlBase) this.gridStateTIV).EndUpdate();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        frmPremiumAllocation.AssignTransactions(this.daStatePremiums, (SqlTransaction) args.Transaction);
        frmPremiumAllocation.AssignTransactions(this.daCompanyPremiums, (SqlTransaction) args.Transaction);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daStatePremiums, (DataTable) this.ds.tblPremiumAllocationStates);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanyPremiums, (DataTable) this.ds.tblPremiumAllocationCompanies);
        args.Transaction.Commit();
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (args.Transaction != null)
          args.Transaction.Rollback();
        throw;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }));
  }

  private void gridStateTIV_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    e.Row.Cells["TIV"].Value = (object) 0;
    int officeId = OfficeLocation.FromOfficeGuid(this._quote.QuotingLocationGuid).OfficeID;
    e.Row.Cells["QuotingLocationID"].Value = (object) officeId;
  }

  private void frmPremiumAllocation_Closing(object sender, CancelEventArgs e) => this.SaveData();

  private void gridCompanyPremiums_AfterRowInsert(object sender, RowEventArgs e)
  {
    UltraGridRow row = e.Row;
    row.Cells["QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    row.Cells["Premium"].Value = (object) 0;
    row.Cells["TerrorismPremium"].Value = (object) 0;
    row.Cells["Rate"].Value = (object) 0;
    row.Cells["TerrorismRate"].Value = (object) 0;
    this.RecalculateRate(e.Row);
    if (this.ds.tblCompanyLocations.Count != 1)
      return;
    e.Row.Cells["CompanyLocationGuid"].Value = (object) this.ds.tblCompanyLocations[0].CompanyLocationGUID;
  }

  private void gridStateTIV_CellChange(object sender, CellEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCompanyPremiums).Rows)
      this.RecalculateRate(row);
  }

  private void gridCompanyPremiums_CellChange(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) e.Cell.Column.Header).Caption, "Premium", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) e.Cell.Column.Header).Caption, "Terrorism Premium", false) != 0)
      return;
    this.RecalculateRate(e.Cell.Row);
  }

  private void RecalculateRate(UltraGridRow row)
  {
    Decimal d1 = 0M;
    Decimal num1 = 0M;
    if (Versioned.IsNumeric((object) row.Cells["Premium"].Text))
    {
      d1 = Conversions.ToDecimal(row.Cells["Premium"].Text);
      if (Decimal.Compare(d1, 2147483647M) > 0)
      {
        d1 = 2147483646M;
        row.Cells["Premium"].Value = (object) d1;
        int num2 = (int) System.Windows.Forms.MessageBox.Show($"Premium cannot exceed {2147483646.ToString("c")}\n\nPlease adjust the premium amount.", "Premium Exceeded Maximum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    if (Versioned.IsNumeric((object) row.Cells["TerrorismPremium"].Text))
    {
      num1 = Conversions.ToDecimal(row.Cells["TerrorismPremium"].Text);
      if (Decimal.Compare(num1, 2147483647M) > 0)
      {
        num1 = 2147483646M;
        row.Cells["TerrorismPremium"].Value = (object) num1;
        int num3 = (int) System.Windows.Forms.MessageBox.Show($"Terrorism premium cannot exceed {2147483646.ToString("c")}\n\nPlease adjust the terrorism premium amount.", "Terrorism Premium Exceeded Maximum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    if (Decimal.Compare(Decimal.Add(d1, num1), 2147483647M) > 0)
    {
      int num4 = (int) System.Windows.Forms.MessageBox.Show($"The premium + terrorism premium cannot exceed {2147483646.ToString("c")}\n\nPlease adjust the premium\\terrorism premium amounts.", "Terrorism\\Premium Exceeded Maximum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    long num5 = 0;
    foreach (UltraGridRow row1 in ((UltraGridBase) this.gridStateTIV).Rows)
    {
      if (Versioned.IsNumeric((object) row1.Cells["TIV"].Text.Replace("_", string.Empty)))
        num5 += Conversions.ToLong(row1.Cells["TIV"].Text.Replace("_", string.Empty));
    }
    dsPremiumAllocation.tblPremiumAllocationCompaniesRow byPremiumId = this.ds.tblPremiumAllocationCompanies.FindByPremiumID(Conversions.ToInteger(row.Cells["PremiumID"].Value));
    if (byPremiumId == null)
    {
      if (num5 == 0L)
      {
        row.Cells["Rate"].Value = (object) 0M;
        row.Cells["TerrorismRate"].Value = (object) 0M;
      }
      else
      {
        row.Cells["Rate"].Value = (object) Decimal.Multiply(Decimal.Divide(d1, new Decimal(num5)), 100M);
        row.Cells["TerrorismRate"].Value = (object) Decimal.Multiply(Decimal.Divide(num1, new Decimal(num5)), 100M);
      }
    }
    else if (num5 == 0L)
    {
      byPremiumId.Rate = 0M;
      byPremiumId.TerrorismRate = 0M;
    }
    else
    {
      byPremiumId.Rate = Decimal.Multiply(Decimal.Divide(d1, new Decimal(num5)), 100M);
      byPremiumId.TerrorismRate = Decimal.Multiply(Decimal.Divide(num1, new Decimal(num5)), 100M);
    }
  }

  private void gridStateTIV_AfterExitEditMode(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCompanyPremiums).Rows)
      this.RecalculateRate(row);
  }

  private void lnkClearAllocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (DataRow row in this.ds.tblPremiumAllocationStates.Rows)
        row.Delete();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.daStatePremiums.Update((DataTable) this.ds.tblPremiumAllocationStates);
  }

  private void RefreshData()
  {
    this.ds.tblPremiumAllocationStates.Clear();
    this.ds.EnforceConstraints = false;
    this.daStatePremiums.Fill((DataTable) this.ds.tblPremiumAllocationStates);
    string str = string.Empty;
    List<string> stringList = (List<string>) null;
    for (int index = this.ds.tblPremiumAllocationStates.Count - 1; index >= 0; index += -1)
    {
      dsPremiumAllocation.tblPremiumAllocationStatesRow premiumAllocationState = this.ds.tblPremiumAllocationStates[index];
      if (this.ds.lstStates.FindByStateID(premiumAllocationState.StateID) == null)
      {
        if (stringList == null)
          stringList = new List<string>();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, string.Empty, false) == 0)
          str = "The following states could not be imported from the spreadsheet because they are\navailble to this company to write in:\n\n";
        if (!stringList.Contains(premiumAllocationState.StateID))
        {
          str = $"{str}{premiumAllocationState.StateID}, ";
          stringList.Add(premiumAllocationState.StateID);
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPremiumAllocationStates WHERE QuoteGuid = @QuoteGuid AND StateID = @StateID", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this._quote.QuoteGuid,
            (object) "@StateID",
            (object) premiumAllocationState.StateID
          });
          this.ds.tblPremiumAllocationStates.RemovetblPremiumAllocationStatesRow(premiumAllocationState);
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, string.Empty, false) != 0)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show(Strings.Left(str, str.Length - 2), "Invalid States Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.ds.tblPremiumAllocationStates.Clear();
      this.daStatePremiums.Fill((DataTable) this.ds.tblPremiumAllocationStates);
    }
    this.ds.EnforceConstraints = true;
  }

  private void lnkAllocationReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    SectionReport rpt = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptAllocationReport), new object[2]
    {
      (object) this.ds,
      (object) this._quote
    });
    try
    {
      rpt.Run();
      ReportFactory.Instance.ShowReport(rpt);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.Message.Contains("used by another process"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("Cannot execute this request at the momemt because it is being used by another process", "Report Being Used By Another Process", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkImportAllocationData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ObjectFactory.Instance.CreateFormEX(typeof (frmImportAllocationData), (object) this._quote.QuoteGuid, (object) this._quote.SubmissionGroupGuid).Show();
  }

  private void lnkExcelImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    frmSelectSpreadsheet selectSpreadsheet = new frmSelectSpreadsheet(this._quote);
    try
    {
      selectSpreadsheet.ShowInTaskbar = false;
      int num = (int) selectSpreadsheet.ShowDialog();
    }
    finally
    {
      selectSpreadsheet.Dispose();
    }
    this.RefreshData();
  }

  private void lnkImportExcelFromDocSystem_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    frmImportFromDocHandler importFromDocHandler = new frmImportFromDocHandler(this._quote);
    string fileName;
    bool inStateOfIssuance;
    try
    {
      importFromDocHandler.ShowInTaskbar = false;
      int num = (int) importFromDocHandler.ShowDialog();
      fileName = importFromDocHandler.FileName;
      inStateOfIssuance = importFromDocHandler.PlacePremInStateOfIssuance;
    }
    finally
    {
      importFromDocHandler.Dispose();
    }
    if (fileName.Length > 0)
      frmSelectSpreadsheet.ProcessExcelSpreadSheet(fileName, this._quote, inStateOfIssuance);
    this.RefreshData();
  }
}
