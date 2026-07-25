// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties.frmCompanyFormsConditionsWarranties
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.DataVisualization;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;

public class frmCompanyFormsConditionsWarranties : Form
{
  private IContainer components;
  private MGAGroupBox MgaGroupBox1;
  private SqlDataAdapter daAppearsOn;
  private SqlDataAdapter daPrintTypes;
  private bool _formLoaded;
  private readonly int _companyLineID;
  private bool _showNetrateData;
  private Dictionary<int, int> _insertedAppearsOn;
  private Dictionary<int, int> _deletedAppearsOn;
  private readonly SqlConnection _cn;
  private Thread _fillThread;

  private virtual MGACheckedListBox lstAppearsOn
  {
    get => this._lstAppearsOn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstAppearsOn_ItemCheck);
      MGACheckedListBox lstAppearsOn1 = this._lstAppearsOn;
      if (lstAppearsOn1 != null)
        lstAppearsOn1.ItemCheck -= checkEventHandler;
      this._lstAppearsOn = value;
      MGACheckedListBox lstAppearsOn2 = this._lstAppearsOn;
      if (lstAppearsOn2 == null)
        return;
      lstAppearsOn2.ItemCheck += checkEventHandler;
    }
  }

  protected virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ug_AfterRowActivate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ug1.AfterRowActivate -= eventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowActivate += eventHandler;
    }
  }

  private virtual LinkLabel lnkWarranties
  {
    get => this._lnkWarranties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ClickLink);
      LinkLabel lnkWarranties1 = this._lnkWarranties;
      if (lnkWarranties1 != null)
        lnkWarranties1.LinkClicked -= clickedEventHandler;
      this._lnkWarranties = value;
      LinkLabel lnkWarranties2 = this._lnkWarranties;
      if (lnkWarranties2 == null)
        return;
      lnkWarranties2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkConditions
  {
    get => this._lnkConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ClickLink);
      LinkLabel lnkConditions1 = this._lnkConditions;
      if (lnkConditions1 != null)
        lnkConditions1.LinkClicked -= clickedEventHandler;
      this._lnkConditions = value;
      LinkLabel lnkConditions2 = this._lnkConditions;
      if (lnkConditions2 == null)
        return;
      lnkConditions2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkForms
  {
    get => this._lnkForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ClickLink);
      LinkLabel lnkForms1 = this._lnkForms;
      if (lnkForms1 != null)
        lnkForms1.LinkClicked -= clickedEventHandler;
      this._lnkForms = value;
      LinkLabel lnkForms2 = this._lnkForms;
      if (lnkForms2 == null)
        return;
      lnkForms2.LinkClicked += clickedEventHandler;
    }
  }

  public virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_Clicking);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickedCancel -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickedCancel += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler3;
    }
  }

  [field: AccessedThroughProperty("dtDisabled")]
  internal virtual MGADateTimePicker dtDisabled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsCompanyFormsConditionsWarranties ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupBoxGrid")]
  protected virtual MGAGroupBox groupBoxGrid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkOrdering
  {
    get => this._lnkOrdering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkOrdering_LinkClicked);
      LinkLabel lnkOrdering1 = this._lnkOrdering;
      if (lnkOrdering1 != null)
        lnkOrdering1.LinkClicked -= clickedEventHandler;
      this._lnkOrdering = value;
      LinkLabel lnkOrdering2 = this._lnkOrdering;
      if (lnkOrdering2 == null)
        return;
      lnkOrdering2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ctmCopyFCW")]
  internal virtual ContextMenu ctmCopyFCW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboAppearsPer")]
  internal virtual MGASimpleComboBox comboAppearsPer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabInformation")]
  protected internal virtual UltraTabControl tabInformation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabInfo")]
  protected internal virtual UltraTabPageControl tabInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand3")]
  internal virtual SqlCommand SqlInsertCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand3")]
  internal virtual SqlCommand SqlUpdateCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand3")]
  internal virtual SqlCommand SqlDeleteCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daInterestForms")]
  internal virtual SqlDataAdapter daInterestForms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daNoteTypes")]
  private virtual SqlDataAdapter daNoteTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox1")]
  internal virtual MGASimpleComboBox MgaSimpleComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkDeletePolicyForms
  {
    get => this._lnkDeletePolicyForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeletePolicyForms_LinkClicked);
      LinkLabel deletePolicyForms1 = this._lnkDeletePolicyForms;
      if (deletePolicyForms1 != null)
        deletePolicyForms1.LinkClicked -= clickedEventHandler;
      this._lnkDeletePolicyForms = value;
      LinkLabel deletePolicyForms2 = this._lnkDeletePolicyForms;
      if (deletePolicyForms2 == null)
        return;
      deletePolicyForms2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkDeselectForms
  {
    get => this._lnkDeselectForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectForms_LinkClicked);
      LinkLabel lnkDeselectForms1 = this._lnkDeselectForms;
      if (lnkDeselectForms1 != null)
        lnkDeselectForms1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectForms = value;
      LinkLabel lnkDeselectForms2 = this._lnkDeselectForms;
      if (lnkDeselectForms2 == null)
        return;
      lnkDeselectForms2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkCopyFormsToOtherStates
  {
    get => this._lnkCopyFormsToOtherStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyFormsToOtherStates_LinkClicked);
      LinkLabel formsToOtherStates1 = this._lnkCopyFormsToOtherStates;
      if (formsToOtherStates1 != null)
        formsToOtherStates1.LinkClicked -= clickedEventHandler;
      this._lnkCopyFormsToOtherStates = value;
      LinkLabel formsToOtherStates2 = this._lnkCopyFormsToOtherStates;
      if (formsToOtherStates2 == null)
        return;
      formsToOtherStates2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelectAllConditions
  {
    get => this._lnkDeSelectAllConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllConditions_LinkClicked);
      LinkLabel selectAllConditions1 = this._lnkDeSelectAllConditions;
      if (selectAllConditions1 != null)
        selectAllConditions1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllConditions = value;
      LinkLabel selectAllConditions2 = this._lnkDeSelectAllConditions;
      if (selectAllConditions2 == null)
        return;
      selectAllConditions2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAllConditions
  {
    get => this._lnkSelectAllConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllConditions_LinkClicked);
      LinkLabel selectAllConditions1 = this._lnkSelectAllConditions;
      if (selectAllConditions1 != null)
        selectAllConditions1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllConditions = value;
      LinkLabel selectAllConditions2 = this._lnkSelectAllConditions;
      if (selectAllConditions2 == null)
        return;
      selectAllConditions2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkCopyCondtions
  {
    get => this._lnkCopyCondtions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyCondtions_LinkClicked);
      LinkLabel lnkCopyCondtions1 = this._lnkCopyCondtions;
      if (lnkCopyCondtions1 != null)
        lnkCopyCondtions1.LinkClicked -= clickedEventHandler;
      this._lnkCopyCondtions = value;
      LinkLabel lnkCopyCondtions2 = this._lnkCopyCondtions;
      if (lnkCopyCondtions2 == null)
        return;
      lnkCopyCondtions2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGACheckBox checkDefault
  {
    get => this._checkDefault;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkDefault_CheckedChanged);
      MGACheckBox checkDefault1 = this._checkDefault;
      if (checkDefault1 != null)
        ((UltraToggleEditorBase) checkDefault1).CheckedChanged -= eventHandler;
      this._checkDefault = value;
      MGACheckBox checkDefault2 = this._checkDefault;
      if (checkDefault2 == null)
        return;
      ((UltraToggleEditorBase) checkDefault2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("checkMandatory")]
  public virtual MGACheckBox checkMandatory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAssociatedForms")]
  internal virtual UltraTabPageControl tabAssociatedForms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckedListBox chkAssociatedForms
  {
    get => this._chkAssociatedForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.chkAssociatedForms_ItemCheck);
      MGACheckedListBox chkAssociatedForms1 = this._chkAssociatedForms;
      if (chkAssociatedForms1 != null)
        chkAssociatedForms1.ItemCheck -= checkEventHandler;
      this._chkAssociatedForms = value;
      MGACheckedListBox chkAssociatedForms2 = this._chkAssociatedForms;
      if (chkAssociatedForms2 == null)
        return;
      chkAssociatedForms2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("daAssoc")]
  internal virtual SqlDataAdapter daAssoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand4")]
  internal virtual SqlCommand SqlCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand5")]
  internal virtual SqlCommand SqlCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand6")]
  internal virtual SqlCommand SqlCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand7")]
  internal virtual SqlCommand SqlCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkCopyWarrantiesToOtherStates
  {
    get => this._lnkCopyWarrantiesToOtherStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyWarrantiesToOtherStates_LinkClicked);
      LinkLabel warrantiesToOtherStates1 = this._lnkCopyWarrantiesToOtherStates;
      if (warrantiesToOtherStates1 != null)
        warrantiesToOtherStates1.LinkClicked -= clickedEventHandler;
      this._lnkCopyWarrantiesToOtherStates = value;
      LinkLabel warrantiesToOtherStates2 = this._lnkCopyWarrantiesToOtherStates;
      if (warrantiesToOtherStates2 == null)
        return;
      warrantiesToOtherStates2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelectAllWarranties
  {
    get => this._lnkDeSelectAllWarranties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllWarranties_LinkClicked);
      LinkLabel selectAllWarranties1 = this._lnkDeSelectAllWarranties;
      if (selectAllWarranties1 != null)
        selectAllWarranties1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllWarranties = value;
      LinkLabel selectAllWarranties2 = this._lnkDeSelectAllWarranties;
      if (selectAllWarranties2 == null)
        return;
      selectAllWarranties2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAllWarranties
  {
    get => this._lnkSelectAllWarranties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllWarranties_LinkClicked);
      LinkLabel selectAllWarranties1 = this._lnkSelectAllWarranties;
      if (selectAllWarranties1 != null)
        selectAllWarranties1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllWarranties = value;
      LinkLabel selectAllWarranties2 = this._lnkSelectAllWarranties;
      if (selectAllWarranties2 == null)
        return;
      selectAllWarranties2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dtAddedDate")]
  protected virtual MGADateTimePicker dtAddedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffective")]
  protected virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkCopyFormsToOtherCompanyLines
  {
    get => this._lnkCopyFormsToOtherCompanyLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyFormsToOtherCompanyLines_LinkClicked);
      LinkLabel otherCompanyLines1 = this._lnkCopyFormsToOtherCompanyLines;
      if (otherCompanyLines1 != null)
        otherCompanyLines1.LinkClicked -= clickedEventHandler;
      this._lnkCopyFormsToOtherCompanyLines = value;
      LinkLabel otherCompanyLines2 = this._lnkCopyFormsToOtherCompanyLines;
      if (otherCompanyLines2 == null)
        return;
      otherCompanyLines2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label10")]
  protected internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkCopyWarrantiesToOtherCompanyLines
  {
    get => this._lnkCopyWarrantiesToOtherCompanyLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyWarrantiesToOtherCompanyLines_LinkClicked);
      LinkLabel otherCompanyLines1 = this._lnkCopyWarrantiesToOtherCompanyLines;
      if (otherCompanyLines1 != null)
        otherCompanyLines1.LinkClicked -= clickedEventHandler;
      this._lnkCopyWarrantiesToOtherCompanyLines = value;
      LinkLabel otherCompanyLines2 = this._lnkCopyWarrantiesToOtherCompanyLines;
      if (otherCompanyLines2 == null)
        return;
      otherCompanyLines2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label9")]
  protected internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkCopyConditionsToOtherCompanyLines
  {
    get => this._lnkCopyConditionsToOtherCompanyLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyConditionsToOtherCompanyLines_LinkClicked);
      LinkLabel otherCompanyLines1 = this._lnkCopyConditionsToOtherCompanyLines;
      if (otherCompanyLines1 != null)
        otherCompanyLines1.LinkClicked -= clickedEventHandler;
      this._lnkCopyConditionsToOtherCompanyLines = value;
      LinkLabel otherCompanyLines2 = this._lnkCopyConditionsToOtherCompanyLines;
      if (otherCompanyLines2 == null)
        return;
      otherCompanyLines2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label8")]
  protected internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAddedBy")]
  internal virtual TextBox txtAddedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CmbFCWConditionType")]
  internal virtual MGASimpleComboBox CmbFCWConditionType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkNetrateAI
  {
    get => this._linkNetrateAI;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkNetrateAI_LinkClicked);
      LinkLabel linkNetrateAi1 = this._linkNetrateAI;
      if (linkNetrateAi1 != null)
        linkNetrateAi1.LinkClicked -= clickedEventHandler;
      this._linkNetrateAI = value;
      LinkLabel linkNetrateAi2 = this._linkNetrateAI;
      if (linkNetrateAi2 == null)
        return;
      linkNetrateAi2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraCode128Barcode1")]
  internal virtual UltraCode128Barcode UltraCode128Barcode1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvAI")]
  internal virtual DataView dvAI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugchkAdditionalInt")]
  internal virtual UltraGrid ugchkAdditionalInt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGridBagLayoutManager1")]
  internal virtual UltraGridBagLayoutManager UltraGridBagLayoutManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblConditionType")]
  internal virtual Label lblConditionType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkIncludeWithBinder
  {
    get => this._chkIncludeWithBinder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkIncludeWithBinder_CheckedChanged);
      MGACheckBox includeWithBinder1 = this._chkIncludeWithBinder;
      if (includeWithBinder1 != null)
        ((UltraToggleEditorBase) includeWithBinder1).CheckedChanged -= eventHandler;
      this._chkIncludeWithBinder = value;
      MGACheckBox includeWithBinder2 = this._chkIncludeWithBinder;
      if (includeWithBinder2 == null)
        return;
      ((UltraToggleEditorBase) includeWithBinder2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("checkBW")]
  internal virtual MGACheckBox checkBW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkIncludeIndication")]
  internal virtual MGACheckBox chkIncludeIndication { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkConditionsOrdering
  {
    get => this._lnkConditionsOrdering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkConditionsOrdering_LinkClicked);
      LinkLabel conditionsOrdering1 = this._lnkConditionsOrdering;
      if (conditionsOrdering1 != null)
        conditionsOrdering1.LinkClicked -= clickedEventHandler;
      this._lnkConditionsOrdering = value;
      LinkLabel conditionsOrdering2 = this._lnkConditionsOrdering;
      if (conditionsOrdering2 == null)
        return;
      conditionsOrdering2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual MenuItem menuCopyFCW
  {
    get => this._menuCopyFCW;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MenuItem1_Click);
      MenuItem menuCopyFcw1 = this._menuCopyFCW;
      if (menuCopyFcw1 != null)
        menuCopyFcw1.Click -= eventHandler;
      this._menuCopyFCW = value;
      MenuItem menuCopyFcw2 = this._menuCopyFCW;
      if (menuCopyFcw2 == null)
        return;
      menuCopyFcw2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyFormsConditionsWarranties));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo1 = new UltraToolTipInfo("", (ToolTipImage) 3, "Include With Quotation", (DefaultableBoolean) 0);
    Appearance appearance4 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo2 = new UltraToolTipInfo("", (ToolTipImage) 3, "Include With Quotation", (DefaultableBoolean) 0);
    Appearance appearance5 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo3 = new UltraToolTipInfo("", (ToolTipImage) 3, "Include With Quotation", (DefaultableBoolean) 0);
    Appearance appearance6 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo4 = new UltraToolTipInfo("", (ToolTipImage) 3, "Include With Quotation", (DefaultableBoolean) 0);
    Appearance appearance7 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo5 = new UltraToolTipInfo("", (ToolTipImage) 3, "Include With Quotation", (DefaultableBoolean) 0);
    Appearance appearance8 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo6 = new UltraToolTipInfo("", (ToolTipImage) 3, "Include With Quotation", (DefaultableBoolean) 0);
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstAdditionalInterestTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InterestType");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AdditionalInterest");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("isDisabled");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("IsNetrate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("isSelected");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("FK_lstAdditionalInterestTypes_tblCompanyInterestForms");
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_lstAdditionalInterestTypes_tblCompanyInterestForms", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InterestType");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
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
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyFormsConditionsWarranties", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CheckedByDefault");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ShowOnQuote");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Condition");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("WarrantyName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("FormNumber", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("GenerateDiary");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("OncePer");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("NoteTypeID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("IncludeWithQuotation");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("SelectPolicyForm");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("GenerateQuoteDiary");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("AddedDate");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("IncludeWithBinder");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("SelectCondition");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("CommonToPackage");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("SelectWarranty");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("EditionDate");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("HasRaterConditional");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ConditionTypeNameID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("BinderWatermark");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("IncludeWithIndication");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("AppliedToQuotes");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes", 0);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("PrintTypeID");
    UltraGridBand ultraGridBand5 = new UltraGridBand("FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms", 0);
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("InterestType");
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms", 0);
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Company_FCW_ID");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance41 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance42 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance43 = new Appearance();
    this.ds = new dsCompanyFormsConditionsWarranties();
    this.chkIncludeWithBinder = new MGACheckBox();
    this.checkMandatory = new MGACheckBox();
    this.checkBW = new MGACheckBox();
    this.chkIncludeIndication = new MGACheckBox();
    this.tabInfo = new UltraTabPageControl();
    this.linkNetrateAI = new LinkLabel();
    this.lblConditionType = new Label();
    this.CmbFCWConditionType = new MGASimpleComboBox();
    this.txtAddedBy = new TextBox();
    this.dtAddedDate = new MGADateTimePicker();
    this.dtEffective = new MGADateTimePicker();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    this.comboAppearsPer = new MGASimpleComboBox();
    this.dvAI = new DataView();
    this.checkDefault = new MGACheckBox();
    this.lstAppearsOn = new MGACheckedListBox();
    this.dtDisabled = new MGADateTimePicker();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.ugchkAdditionalInt = new UltraGrid();
    this.Label5 = new Label();
    this.tabAssociatedForms = new UltraTabPageControl();
    this.chkAssociatedForms = new MGACheckedListBox();
    this.ctmCopyFCW = new ContextMenu();
    this.menuCopyFCW = new MenuItem();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.lnkWarranties = new LinkLabel();
    this.lnkConditions = new LinkLabel();
    this.lnkForms = new LinkLabel();
    this.groupBoxGrid = new MGAGroupBox();
    this.ug = new UltraGrid();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.daAppearsOn = new SqlDataAdapter();
    this.daPrintTypes = new SqlDataAdapter();
    this.lnkOrdering = new LinkLabel();
    this.tabInformation = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlInsertCommand3 = new SqlCommand();
    this.SqlUpdateCommand3 = new SqlCommand();
    this.SqlDeleteCommand3 = new SqlCommand();
    this.daInterestForms = new SqlDataAdapter();
    this.daNoteTypes = new SqlDataAdapter();
    this.lnkDeletePolicyForms = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeselectForms = new LinkLabel();
    this.lnkCopyFormsToOtherStates = new LinkLabel();
    this.lnkSelectAllConditions = new LinkLabel();
    this.lnkDeSelectAllConditions = new LinkLabel();
    this.lnkCopyCondtions = new LinkLabel();
    this.daAssoc = new SqlDataAdapter();
    this.SqlCommand4 = new SqlCommand();
    this.SqlCommand5 = new SqlCommand();
    this.SqlCommand6 = new SqlCommand();
    this.SqlCommand7 = new SqlCommand();
    this.lnkCopyWarrantiesToOtherStates = new LinkLabel();
    this.lnkSelectAllWarranties = new LinkLabel();
    this.lnkDeSelectAllWarranties = new LinkLabel();
    this.lnkCopyFormsToOtherCompanyLines = new LinkLabel();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.lnkCopyConditionsToOtherCompanyLines = new LinkLabel();
    this.Label10 = new Label();
    this.lnkCopyWarrantiesToOtherCompanyLines = new LinkLabel();
    this.UltraCode128Barcode1 = new UltraCode128Barcode();
    this.UltraGridBagLayoutManager1 = new UltraGridBagLayoutManager(this.components);
    this.lnkConditionsOrdering = new LinkLabel();
    PictureBox pictureBox1 = new PictureBox();
    PictureBox pictureBox2 = new PictureBox();
    PictureBox pictureBox3 = new PictureBox();
    Label label1 = new Label();
    MGACheckBox mgaCheckBox1 = new MGACheckBox();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    MGACheckBox mgaCheckBox2 = new MGACheckBox();
    SqlCommand sqlCommand1 = new SqlCommand();
    SqlCommand sqlCommand2 = new SqlCommand();
    SqlCommand sqlCommand3 = new SqlCommand();
    SqlCommand sqlCommand4 = new SqlCommand();
    SqlCommand sqlCommand5 = new SqlCommand();
    SqlCommand sqlCommand6 = new SqlCommand();
    Label label5 = new Label();
    MGACheckBox mgaCheckBox3 = new MGACheckBox();
    UltraToolTipManager ultraToolTipManager = new UltraToolTipManager(this.components);
    MGACheckBox mgaCheckBox4 = new MGACheckBox();
    MGACheckBox mgaCheckBox5 = new MGACheckBox();
    Label label6 = new Label();
    Label label7 = new Label();
    ((ISupportInitialize) pictureBox1).BeginInit();
    ((ISupportInitialize) pictureBox2).BeginInit();
    ((ISupportInitialize) pictureBox3).BeginInit();
    ((ISupportInitialize) mgaCheckBox1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) mgaCheckBox2).BeginInit();
    ((ISupportInitialize) mgaCheckBox3).BeginInit();
    ((ISupportInitialize) this.chkIncludeWithBinder).BeginInit();
    ((ISupportInitialize) mgaCheckBox4).BeginInit();
    ((ISupportInitialize) this.checkMandatory).BeginInit();
    ((ISupportInitialize) this.checkBW).BeginInit();
    ((ISupportInitialize) this.chkIncludeIndication).BeginInit();
    ((ISupportInitialize) mgaCheckBox5).BeginInit();
    ((Control) this.tabInfo).SuspendLayout();
    ((ISupportInitialize) this.CmbFCWConditionType).BeginInit();
    ((ISupportInitialize) this.dtAddedDate).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    ((ISupportInitialize) this.comboAppearsPer).BeginInit();
    this.dvAI.BeginInit();
    ((ISupportInitialize) this.checkDefault).BeginInit();
    ((ISupportInitialize) this.lstAppearsOn).BeginInit();
    ((ISupportInitialize) this.dtDisabled).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.ugchkAdditionalInt).BeginInit();
    ((Control) this.tabAssociatedForms).SuspendLayout();
    ((ISupportInitialize) this.chkAssociatedForms).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.groupBoxGrid).BeginInit();
    ((Control) this.groupBoxGrid).SuspendLayout();
    ((ISupportInitialize) this.ug).BeginInit();
    ((ISupportInitialize) this.tabInformation).BeginInit();
    ((Control) this.tabInformation).SuspendLayout();
    ((ISupportInitialize) this.UltraGridBagLayoutManager1).BeginInit();
    this.SuspendLayout();
    pictureBox1.BackColor = Color.FromArgb(239, 247, 253);
    pictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox3.Image");
    pictureBox1.Location = new Point(8, 128 /*0x80*/);
    pictureBox1.Name = "PictureBox3";
    pictureBox1.Size = new Size(40, 40);
    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    pictureBox1.TabIndex = 2;
    pictureBox1.TabStop = false;
    pictureBox2.BackColor = Color.FromArgb(239, 247, 253);
    pictureBox2.Image = (Image) componentResourceManager.GetObject("PictureBox2.Image");
    pictureBox2.Location = new Point(8, 80 /*0x50*/);
    pictureBox2.Name = "PictureBox2";
    pictureBox2.Size = new Size(40, 40);
    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
    pictureBox2.TabIndex = 1;
    pictureBox2.TabStop = false;
    pictureBox3.BackColor = Color.FromArgb(239, 247, 253);
    pictureBox3.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    pictureBox3.Location = new Point(8, 32 /*0x20*/);
    pictureBox3.Name = "PictureBox1";
    pictureBox3.Size = new Size(40, 40);
    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
    pictureBox3.TabIndex = 0;
    pictureBox3.TabStop = false;
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(9, 97);
    label1.Name = "Label4";
    label1.Size = new Size(55, 13);
    label1.TabIndex = 8;
    label1.Text = "Once Per:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) mgaCheckBox1).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) mgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) mgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) mgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.GenerateDiary", true));
    ((UltraToggleEditorBase) mgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) mgaCheckBox1).Location = new Point(439, 46);
    mgaCheckBox1.MGAStyle = MGAStyles.Blue;
    ((Control) mgaCheckBox1).Name = "checkGenerateDiary";
    ((Control) mgaCheckBox1).Size = new Size(152, 20);
    ((Control) mgaCheckBox1).TabIndex = 8;
    ((UltraToggleEditorBase) mgaCheckBox1).Text = "Generate Binder Diary";
    ((UltraControlBase) mgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyFormsConditionsWarranties";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(9, 39);
    label2.Name = "Label3";
    label2.Size = new Size(56, 23);
    label2.TabIndex = 6;
    label2.Text = "Disabled:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(209, 11);
    label3.Name = "Label2";
    label3.Size = new Size(72, 23);
    label3.TabIndex = 5;
    label3.Text = "Appears On:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(9, 10);
    label4.Name = "Label1";
    label4.Size = new Size(56, 23);
    label4.TabIndex = 2;
    label4.Text = "Effective:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) mgaCheckBox2).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) mgaCheckBox2).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) mgaCheckBox2).BackColorInternal = Color.Transparent;
    ((Control) mgaCheckBox2).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.ShowOnQuote", true));
    ((UltraToggleEditorBase) mgaCheckBox2).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) mgaCheckBox2).Location = new Point(439, 25);
    mgaCheckBox2.MGAStyle = MGAStyles.Blue;
    ((Control) mgaCheckBox2).Name = "checkShowOnQuote";
    ((Control) mgaCheckBox2).Size = new Size(128 /*0x80*/, 20);
    ((Control) mgaCheckBox2).TabIndex = 7;
    ((UltraToggleEditorBase) mgaCheckBox2).Text = "Show On Quote";
    ((UltraControlBase) mgaCheckBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaCheckBox2).UseOsThemes = (DefaultableBoolean) 2;
    sqlCommand1.CommandText = "DELETE FROM tblCompanyFormsConditionsWarranties_PrintTypes WHERE (Company_FCW_ID = @Original_Company_FCW_ID) AND (PrintTypeID = @Original_PrintTypeID)";
    sqlCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_Company_FCW_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PrintTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PrintTypeID", DataRowVersion.Original, (object) null)
    });
    sqlCommand2.CommandText = "INSERT INTO tblCompanyFormsConditionsWarranties_PrintTypes(Company_FCW_ID, PrintTypeID) VALUES (@Company_FCW_ID, @PrintTypeID)";
    sqlCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Company_FCW_ID", SqlDbType.Int, 4, "Company_FCW_ID"),
      new SqlParameter("@PrintTypeID", SqlDbType.TinyInt, 1, "PrintTypeID")
    });
    sqlCommand3.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    sqlCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    sqlCommand4.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    sqlCommand4.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@Company_FCW_ID", SqlDbType.Int, 4, "Company_FCW_ID"),
      new SqlParameter("@PrintTypeID", SqlDbType.TinyInt, 1, "PrintTypeID"),
      new SqlParameter("@Original_Company_FCW_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PrintTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PrintTypeID", DataRowVersion.Original, (object) null)
    });
    sqlCommand5.CommandText = componentResourceManager.GetString("SqlCommand1.CommandText");
    sqlCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    sqlCommand6.CommandText = "select * from lstnotetypes";
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(4, 70);
    label5.Name = "Label6";
    label5.Size = new Size(61, 13);
    label5.TabIndex = 11;
    label5.Text = "Note Type:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) mgaCheckBox3).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) mgaCheckBox3).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) mgaCheckBox3).BackColorInternal = Color.Transparent;
    ((Control) mgaCheckBox3).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.IncludeWithQuotation", true));
    ((UltraToggleEditorBase) mgaCheckBox3).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) mgaCheckBox3).Location = new Point(439, 88);
    mgaCheckBox3.MGAStyle = MGAStyles.Blue;
    ((Control) mgaCheckBox3).Name = "checkIncludeWithQuotation";
    ((Control) mgaCheckBox3).Size = new Size(140, 20);
    ((Control) mgaCheckBox3).TabIndex = 10;
    ((UltraToggleEditorBase) mgaCheckBox3).Text = "Include with Quotation";
    ultraToolTipInfo1.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo1.ToolTipTextFormatted = "When checked, this policy form becomes available<br>for selection in the quote event document automation process.";
    ultraToolTipInfo1.ToolTipTextStyle = (ToolTipTextStyle) 2;
    ultraToolTipInfo1.ToolTipTitle = "Include With Quotation";
    ultraToolTipManager.SetUltraToolTip((Control) mgaCheckBox3, ultraToolTipInfo1);
    ((UltraControlBase) mgaCheckBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaCheckBox3).UseOsThemes = (DefaultableBoolean) 2;
    ultraToolTipManager.ContainingControl = (Control) this;
    ultraToolTipManager.DisplayStyle = (ToolTipDisplayStyle) 3;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkIncludeWithBinder).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkIncludeWithBinder).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncludeWithBinder).BackColorInternal = Color.Transparent;
    ((Control) this.chkIncludeWithBinder).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.IncludeWithBinder", true));
    ((UltraToggleEditorBase) this.chkIncludeWithBinder).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkIncludeWithBinder).Location = new Point(439, 109);
    this.chkIncludeWithBinder.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkIncludeWithBinder).Name = "chkIncludeWithBinder";
    ((Control) this.chkIncludeWithBinder).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.chkIncludeWithBinder).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkIncludeWithBinder).Text = "Include with Binder";
    ultraToolTipInfo2.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo2.ToolTipTextFormatted = "When checked, this policy form becomes available<br>for selection in the quote event document automation process.";
    ultraToolTipInfo2.ToolTipTextStyle = (ToolTipTextStyle) 2;
    ultraToolTipInfo2.ToolTipTitle = "Include With Quotation";
    ultraToolTipManager.SetUltraToolTip((Control) this.chkIncludeWithBinder, ultraToolTipInfo2);
    ((UltraControlBase) this.chkIncludeWithBinder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkIncludeWithBinder).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) mgaCheckBox4).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) mgaCheckBox4).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) mgaCheckBox4).BackColorInternal = Color.Transparent;
    ((Control) mgaCheckBox4).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.CommonToPackage", true));
    ((UltraToggleEditorBase) mgaCheckBox4).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) mgaCheckBox4).Location = new Point(439, 130);
    mgaCheckBox4.MGAStyle = MGAStyles.Blue;
    ((Control) mgaCheckBox4).Name = "checkCommontoPackage";
    ((Control) mgaCheckBox4).Size = new Size(140, 20);
    ((Control) mgaCheckBox4).TabIndex = 12;
    ((UltraToggleEditorBase) mgaCheckBox4).Text = "Limit to Primary State";
    ultraToolTipInfo3.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo3.ToolTipTextFormatted = "When checked, this policy form becomes available<br>for selection in the quote event document automation process.";
    ultraToolTipInfo3.ToolTipTextStyle = (ToolTipTextStyle) 2;
    ultraToolTipInfo3.ToolTipTitle = "Include With Quotation";
    ultraToolTipManager.SetUltraToolTip((Control) mgaCheckBox4, ultraToolTipInfo3);
    ((UltraControlBase) mgaCheckBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaCheckBox4).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkMandatory).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.checkMandatory).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkMandatory).BackColorInternal = Color.Transparent;
    ((Control) this.checkMandatory).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.Mandatory", true));
    ((UltraToggleEditorBase) this.checkMandatory).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkMandatory).Location = new Point(439, 151);
    this.checkMandatory.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkMandatory).Name = "checkMandatory";
    ((Control) this.checkMandatory).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.checkMandatory).TabIndex = 13;
    ((UltraToggleEditorBase) this.checkMandatory).Text = "Mandatory";
    ultraToolTipInfo4.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo4.ToolTipTextFormatted = "When checked, this policy form becomes available<br>for selection in the quote event document automation process.";
    ultraToolTipInfo4.ToolTipTextStyle = (ToolTipTextStyle) 2;
    ultraToolTipInfo4.ToolTipTitle = "Include With Quotation";
    ultraToolTipManager.SetUltraToolTip((Control) this.checkMandatory, ultraToolTipInfo4);
    ((UltraControlBase) this.checkMandatory).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkMandatory).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkBW).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.checkBW).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkBW).BackColorInternal = Color.Transparent;
    ((Control) this.checkBW).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.BinderWatermark", true));
    ((UltraToggleEditorBase) this.checkBW).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkBW).Location = new Point(439, 172);
    this.checkBW.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkBW).Name = "checkBW";
    ((Control) this.checkBW).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.checkBW).TabIndex = 21;
    ((UltraToggleEditorBase) this.checkBW).Text = "Binder Watermark";
    ultraToolTipInfo5.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo5.ToolTipTextFormatted = "When checked, this policy form becomes available<br>for selection in the quote event document automation process.";
    ultraToolTipInfo5.ToolTipTextStyle = (ToolTipTextStyle) 2;
    ultraToolTipInfo5.ToolTipTitle = "Include With Quotation";
    ultraToolTipManager.SetUltraToolTip((Control) this.checkBW, ultraToolTipInfo5);
    ((UltraControlBase) this.checkBW).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkBW).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkIncludeIndication).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkIncludeIndication).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncludeIndication).BackColorInternal = Color.Transparent;
    ((Control) this.chkIncludeIndication).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.IncludeWithIndication", true));
    ((UltraToggleEditorBase) this.chkIncludeIndication).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkIncludeIndication).Location = new Point(439, 193);
    this.chkIncludeIndication.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkIncludeIndication).Name = "chkIncludeIndication";
    ((Control) this.chkIncludeIndication).Size = new Size(140, 20);
    ((Control) this.chkIncludeIndication).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkIncludeIndication).Text = "Include with Indication";
    ultraToolTipInfo6.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo6.ToolTipTextFormatted = "When checked, this policy form becomes available<br>for selection in the quote event document automation process.";
    ultraToolTipInfo6.ToolTipTextStyle = (ToolTipTextStyle) 2;
    ultraToolTipInfo6.ToolTipTitle = "Include With Quotation";
    ultraToolTipManager.SetUltraToolTip((Control) this.chkIncludeIndication, ultraToolTipInfo6);
    ((UltraControlBase) this.chkIncludeIndication).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkIncludeIndication).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.AlphaLevel = (short) 14;
    appearance9.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance9.BackColorAlpha = (Alpha) 2;
    appearance9.BackGradientAlignment = (GradientAlignment) 4;
    appearance9.BackGradientStyle = (GradientStyle) 5;
    appearance9.BorderAlpha = (Alpha) 1;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    appearance9.ForegroundAlpha = (Alpha) 2;
    ((UltraToggleEditorBase) mgaCheckBox5).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) mgaCheckBox5).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) mgaCheckBox5).BackColorInternal = Color.Transparent;
    ((Control) mgaCheckBox5).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.GenerateQuoteDiary", true));
    ((UltraToggleEditorBase) mgaCheckBox5).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) mgaCheckBox5).Location = new Point(439, 67);
    mgaCheckBox5.MGAStyle = MGAStyles.Blue;
    ((Control) mgaCheckBox5).Name = "checkGenerateQuoteDiary";
    ((Control) mgaCheckBox5).Size = new Size(140, 20);
    ((Control) mgaCheckBox5).TabIndex = 9;
    ((UltraToggleEditorBase) mgaCheckBox5).Text = "Generate Quote Diary";
    ((UltraControlBase) mgaCheckBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaCheckBox5).UseOsThemes = (DefaultableBoolean) 2;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(9, 119);
    label6.Name = "Label7";
    label6.Size = new Size(56, 23);
    label6.TabIndex = 15;
    label6.Text = "Added:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(-4, 142);
    label7.Name = "Label11";
    label7.Size = new Size(69, 23);
    label7.TabIndex = 16 /*0x10*/;
    label7.Text = "Added By:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.tabInfo).Controls.Add((Control) this.chkIncludeIndication);
    ((Control) this.tabInfo).Controls.Add((Control) this.checkBW);
    ((Control) this.tabInfo).Controls.Add((Control) this.linkNetrateAI);
    ((Control) this.tabInfo).Controls.Add((Control) this.lblConditionType);
    ((Control) this.tabInfo).Controls.Add((Control) this.CmbFCWConditionType);
    ((Control) this.tabInfo).Controls.Add((Control) this.txtAddedBy);
    ((Control) this.tabInfo).Controls.Add((Control) label7);
    ((Control) this.tabInfo).Controls.Add((Control) this.dtAddedDate);
    ((Control) this.tabInfo).Controls.Add((Control) this.dtEffective);
    ((Control) this.tabInfo).Controls.Add((Control) this.checkMandatory);
    ((Control) this.tabInfo).Controls.Add((Control) mgaCheckBox4);
    ((Control) this.tabInfo).Controls.Add((Control) this.chkIncludeWithBinder);
    ((Control) this.tabInfo).Controls.Add((Control) label6);
    ((Control) this.tabInfo).Controls.Add((Control) mgaCheckBox5);
    ((Control) this.tabInfo).Controls.Add((Control) mgaCheckBox3);
    ((Control) this.tabInfo).Controls.Add((Control) mgaCheckBox1);
    ((Control) this.tabInfo).Controls.Add((Control) label5);
    ((Control) this.tabInfo).Controls.Add((Control) this.MgaSimpleComboBox1);
    ((Control) this.tabInfo).Controls.Add((Control) label4);
    ((Control) this.tabInfo).Controls.Add((Control) this.comboAppearsPer);
    ((Control) this.tabInfo).Controls.Add((Control) mgaCheckBox2);
    ((Control) this.tabInfo).Controls.Add((Control) label1);
    ((Control) this.tabInfo).Controls.Add((Control) this.checkDefault);
    ((Control) this.tabInfo).Controls.Add((Control) this.lstAppearsOn);
    ((Control) this.tabInfo).Controls.Add((Control) this.dtDisabled);
    ((Control) this.tabInfo).Controls.Add((Control) label3);
    ((Control) this.tabInfo).Controls.Add((Control) label2);
    ((Control) this.tabInfo).Location = new Point(1, 26);
    ((Control) this.tabInfo).Name = "tabInfo";
    ((Control) this.tabInfo).Size = new Size(594, 218);
    this.linkNetrateAI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkNetrateAI.AutoSize = true;
    this.linkNetrateAI.Location = new Point(197, (int) sbyte.MaxValue);
    this.linkNetrateAI.Name = "linkNetrateAI";
    this.linkNetrateAI.Size = new Size(87, 13);
    this.linkNetrateAI.TabIndex = 20;
    this.linkNetrateAI.TabStop = true;
    this.linkNetrateAI.Text = "Show Netrate AI";
    this.lblConditionType.BackColor = Color.Transparent;
    this.lblConditionType.Location = new Point(-3, 165);
    this.lblConditionType.Name = "lblConditionType";
    this.lblConditionType.Size = new Size(69, 38);
    this.lblConditionType.TabIndex = 19;
    this.lblConditionType.Text = "Condition Type:";
    this.lblConditionType.TextAlign = ContentAlignment.MiddleRight;
    this.CmbFCWConditionType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.CmbFCWConditionType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyFormsConditionsWarranties.ConditionTypeNameID", true));
    ((UltraGridBase) this.CmbFCWConditionType).DataMember = "lstFCWConditionType";
    ((UltraGridBase) this.CmbFCWConditionType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.CmbFCWConditionType).DisplayMember = "ConditionTypeName";
    this.CmbFCWConditionType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.CmbFCWConditionType).Location = new Point(75, 171);
    this.CmbFCWConditionType.MGAStyle = MGAStyles.Blue;
    ((Control) this.CmbFCWConditionType).Name = "CmbFCWConditionType";
    ((Control) this.CmbFCWConditionType).Size = new Size(208 /*0xD0*/, 21);
    ((Control) this.CmbFCWConditionType).TabIndex = 18;
    ((UltraControlBase) this.CmbFCWConditionType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CmbFCWConditionType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.CmbFCWConditionType).ValueMember = "ID";
    this.txtAddedBy.DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyFormsConditionsWarranties.UserName", true));
    this.txtAddedBy.Location = new Point(73, 144 /*0x90*/);
    this.txtAddedBy.Name = "txtAddedBy";
    this.txtAddedBy.ReadOnly = true;
    this.txtAddedBy.Size = new Size(208 /*0xD0*/, 21);
    this.txtAddedBy.TabIndex = 17;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtAddedDate.Appearance = (AppearanceBase) appearance10;
    appearance11.AlphaLevel = (short) 14;
    appearance11.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance11.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance11.BackColorAlpha = (Alpha) 2;
    appearance11.BackGradientAlignment = (GradientAlignment) 4;
    appearance11.BackGradientStyle = (GradientStyle) 5;
    appearance11.BorderAlpha = (Alpha) 1;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    appearance11.ForeColor = Color.FromArgb(49, 85, 153);
    appearance11.ForegroundAlpha = (Alpha) 2;
    this.dtAddedDate.ButtonAppearance = (AppearanceBase) appearance11;
    ((Control) this.dtAddedDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyFormsConditionsWarranties.AddedDate", true));
    this.dtAddedDate.DateTime = new DateTime(2020, 1, 12, 0, 0, 0, 0);
    ((Control) this.dtAddedDate).Location = new Point(73, 120);
    this.dtAddedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtAddedDate).Name = "dtAddedDate";
    this.dtAddedDate.Nullable = false;
    ((Control) this.dtAddedDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtAddedDate).TabIndex = 4;
    ((UltraControlBase) this.dtAddedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtAddedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtAddedDate.Value = (object) new DateTime(2020, 1, 12, 0, 0, 0, 0);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance12;
    appearance13.AlphaLevel = (short) 14;
    appearance13.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance13.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance13.BackColorAlpha = (Alpha) 2;
    appearance13.BackGradientAlignment = (GradientAlignment) 4;
    appearance13.BackGradientStyle = (GradientStyle) 5;
    appearance13.BorderAlpha = (Alpha) 1;
    appearance13.BorderColor = Color.FromArgb(78, 122, 171);
    appearance13.ForeColor = Color.FromArgb(49, 85, 153);
    appearance13.ForegroundAlpha = (Alpha) 2;
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance13;
    ((Control) this.dtEffective).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyFormsConditionsWarranties.Effective", true));
    this.dtEffective.DateTime = new DateTime(2020, 1, 12, 0, 0, 0, 0);
    ((Control) this.dtEffective).Location = new Point(73, 11);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    this.dtEffective.Nullable = false;
    ((Control) this.dtEffective).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtEffective).TabIndex = 0;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEffective.Value = (object) new DateTime(2020, 1, 12, 0, 0, 0, 0);
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyFormsConditionsWarranties.NoteTypeID", true));
    ((UltraGridBase) this.MgaSimpleComboBox1).DataMember = "lstNoteTypes";
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "Description";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(73, 66);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    ((Control) this.MgaSimpleComboBox1).Size = new Size(208 /*0xD0*/, 21);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 2;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "NoteTypeID";
    this.comboAppearsPer.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboAppearsPer).DataSource = (object) this.dvAI;
    ((UltraDropDownBase) this.comboAppearsPer).DisplayMember = "AdditionalInterest";
    this.comboAppearsPer.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAppearsPer).Location = new Point(73, 93);
    this.comboAppearsPer.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboAppearsPer).Name = "comboAppearsPer";
    ((Control) this.comboAppearsPer).Size = new Size(208 /*0xD0*/, 21);
    ((Control) this.comboAppearsPer).TabIndex = 3;
    ((UltraControlBase) this.comboAppearsPer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAppearsPer).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboAppearsPer).ValueMember = "InterestType";
    this.dvAI.Table = (DataTable) this.ds.lstAdditionalInterestTypes;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkDefault).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.checkDefault).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkDefault).BackColorInternal = Color.Transparent;
    ((Control) this.checkDefault).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyFormsConditionsWarranties.CheckedByDefault", true));
    ((UltraToggleEditorBase) this.checkDefault).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkDefault).Location = new Point(439, 4);
    this.checkDefault.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkDefault).Name = "checkDefault";
    ((Control) this.checkDefault).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.checkDefault).TabIndex = 6;
    ((UltraToggleEditorBase) this.checkDefault).Text = "Checked By Default";
    ((UltraControlBase) this.checkDefault).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkDefault).UseOsThemes = (DefaultableBoolean) 2;
    this.lstAppearsOn.CheckOnClick = true;
    this.lstAppearsOn.Location = new Point(289, 11);
    this.lstAppearsOn.MGAStyle = MGAStyles.Blue;
    this.lstAppearsOn.Name = "lstAppearsOn";
    this.lstAppearsOn.Size = new Size(144 /*0x90*/, 196);
    this.lstAppearsOn.TabIndex = 5;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDisabled.Appearance = (AppearanceBase) appearance15;
    appearance16.AlphaLevel = (short) 14;
    appearance16.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance16.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance16.BackColorAlpha = (Alpha) 2;
    appearance16.BackGradientAlignment = (GradientAlignment) 4;
    appearance16.BackGradientStyle = (GradientStyle) 5;
    appearance16.BorderAlpha = (Alpha) 1;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    appearance16.ForeColor = Color.FromArgb(49, 85, 153);
    appearance16.ForegroundAlpha = (Alpha) 2;
    this.dtDisabled.ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dtDisabled).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyFormsConditionsWarranties.Disabled", true));
    this.dtDisabled.DateTime = new DateTime(2020, 1, 12, 0, 0, 0, 0);
    ((Control) this.dtDisabled).Location = new Point(73, 40);
    this.dtDisabled.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDisabled).Name = "dtDisabled";
    ((Control) this.dtDisabled).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtDisabled).TabIndex = 1;
    ((UltraControlBase) this.dtDisabled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDisabled).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDisabled.Value = (object) new DateTime(2020, 1, 12, 0, 0, 0, 0);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ugchkAdditionalInt);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(594, 218);
    ((UltraGridBase) this.ugchkAdditionalInt).DataSource = (object) this.dvAI;
    appearance17.BackColor = SystemColors.Window;
    appearance17.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 3;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 529;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Width = 35;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Width = 17;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 211;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridBand2.Hidden = true;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance18.BackColor = SystemColors.ActiveBorder;
    appearance18.BackColor2 = SystemColors.ControlDark;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance18;
    appearance19.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance19;
    ((SpecialBoxBase) ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance20.BackColor = SystemColors.ControlLightLight;
    appearance20.BackColor2 = SystemColors.Control;
    appearance20.BackGradientStyle = (GradientStyle) 3;
    appearance20.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.MaxRowScrollRegions = 1;
    appearance21.BackColor = SystemColors.Window;
    appearance21.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = SystemColors.Highlight;
    appearance22.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.Silver;
    appearance24.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.CellPadding = 0;
    appearance25.BackColor = SystemColors.Control;
    appearance25.BackColor2 = SystemColors.ControlDark;
    appearance25.BackGradientAlignment = (GradientAlignment) 1;
    appearance25.BackGradientStyle = (GradientStyle) 3;
    appearance25.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance27.BackColor = Color.LightGray;
    appearance27.BorderColor = Color.Silver;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance28.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.ViewStyleBand = (ViewStyleBand) 1;
    ((Control) this.ugchkAdditionalInt).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugchkAdditionalInt).Location = new Point(6, 46);
    ((Control) this.ugchkAdditionalInt).Name = "ugchkAdditionalInt";
    ((Control) this.ugchkAdditionalInt).Size = new Size(583, 148);
    ((Control) this.ugchkAdditionalInt).TabIndex = 1;
    ((Control) this.ugchkAdditionalInt).Text = "UltraGrid1";
    this.Label5.Location = new Point(3, 9);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(524, 34);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Select the interest types that cause this form to be issued via endorsement when they are added or modified:";
    ((Control) this.tabAssociatedForms).Controls.Add((Control) this.chkAssociatedForms);
    ((Control) this.tabAssociatedForms).Location = new Point(-10000, -10000);
    ((Control) this.tabAssociatedForms).Name = "tabAssociatedForms";
    ((Control) this.tabAssociatedForms).Size = new Size(594, 218);
    this.chkAssociatedForms.CheckOnClick = true;
    this.chkAssociatedForms.Location = new Point(3, 3);
    this.chkAssociatedForms.MGAStyle = MGAStyles.Blue;
    this.chkAssociatedForms.Name = "chkAssociatedForms";
    this.chkAssociatedForms.Size = new Size(407, 196);
    this.chkAssociatedForms.TabIndex = 6;
    this.ctmCopyFCW.MenuItems.AddRange(new MenuItem[1]
    {
      this.menuCopyFCW
    });
    this.menuCopyFCW.Index = 0;
    this.menuCopyFCW.Text = "Copy FCW To Other States";
    appearance29.BackColor = Color.FromArgb(239, 247, 253);
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance29;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lnkWarranties);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lnkConditions);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lnkForms);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) pictureBox1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) pictureBox2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) pictureBox3);
    appearance30.FontData.SizeInPoints = 10f;
    appearance30.ForeColor = Color.FromArgb(21, 66, 139);
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance30;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(160 /*0xA0*/, 184);
    ((Control) this.MgaGroupBox1).TabIndex = 0;
    this.MgaGroupBox1.Text = "Policy Items";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.lnkWarranties.AutoSize = true;
    this.lnkWarranties.BackColor = Color.FromArgb(239, 247, 253);
    this.lnkWarranties.Font = new Font("Tahoma", 10f);
    this.lnkWarranties.Location = new Point(56, 138);
    this.lnkWarranties.Name = "lnkWarranties";
    this.lnkWarranties.Size = new Size(74, 17);
    this.lnkWarranties.TabIndex = 5;
    this.lnkWarranties.TabStop = true;
    this.lnkWarranties.Text = "Warranties";
    this.lnkWarranties.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkConditions.AutoSize = true;
    this.lnkConditions.BackColor = Color.FromArgb(239, 247, 253);
    this.lnkConditions.Font = new Font("Tahoma", 10f);
    this.lnkConditions.Location = new Point(56, 90);
    this.lnkConditions.Name = "lnkConditions";
    this.lnkConditions.Size = new Size(72, 17);
    this.lnkConditions.TabIndex = 4;
    this.lnkConditions.TabStop = true;
    this.lnkConditions.Text = "Conditions";
    this.lnkConditions.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkForms.AutoSize = true;
    this.lnkForms.BackColor = Color.FromArgb(239, 247, 253);
    this.lnkForms.Font = new Font("Tahoma", 10f);
    this.lnkForms.Location = new Point(56, 42);
    this.lnkForms.Name = "lnkForms";
    this.lnkForms.Size = new Size(46, 17);
    this.lnkForms.TabIndex = 3;
    this.lnkForms.TabStop = true;
    this.lnkForms.Text = "Forms";
    this.lnkForms.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.groupBoxGrid).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance31.BackColor = Color.FromArgb(239, 247, 253);
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupBoxGrid.ContentAreaAppearance = (AppearanceBase) appearance31;
    ((Control) this.groupBoxGrid).Controls.Add((Control) this.ug);
    appearance32.FontData.SizeInPoints = 10f;
    appearance32.ForeColor = Color.FromArgb(21, 66, 139);
    this.groupBoxGrid.HeaderAppearance = (AppearanceBase) appearance32;
    ((Control) this.groupBoxGrid).Location = new Point(177, 8);
    ((Control) this.groupBoxGrid).Name = "groupBoxGrid";
    ((Control) this.groupBoxGrid).Size = new Size(594, 206);
    ((Control) this.groupBoxGrid).TabIndex = 1;
    this.groupBoxGrid.Text = "Policy Forms";
    this.groupBoxGrid.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.ug).ContextMenu = this.ctmCopyFCW;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblCompanyFormsConditionsWarranties;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 115;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 126;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 106;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 75;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 81;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Checked By Default";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 93;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Show On Quote";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 87;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Form";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 7;
    ultraGridColumn16.Width = 87;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 8;
    ultraGridColumn17.Width = 131;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Warranty";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 9;
    ultraGridColumn18.Width = 101;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Form #";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 10;
    ultraGridColumn19.Width = 106;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 11;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 72;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 12;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 47;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Generate Diary";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 13;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 14;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 85;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 15;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 68;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 104;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Selected";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 18;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 35;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 19;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 99;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 20;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 79;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 21;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 92;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 22;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 45;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 23;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 97;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 24;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 62;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Selected";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 25;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 45;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Edition Date";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 17;
    ultraGridColumn34.Width = 78;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 26;
    ultraGridColumn35.Width = 87;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 27;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 28;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 170;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 29;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 98;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 30;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 106;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 88;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 104;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 33;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 87;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 34;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 35;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 36;
    ultraGridBand3.Columns.AddRange(new object[37]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45
    });
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand3.Override.CellClickAction = (CellClickAction) 1;
    ultraGridBand3.Override.SelectTypeCell = (SelectType) 2;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 0;
    ultraGridColumn46.Width = 404;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ultraGridColumn47.Width = 277;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 0;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 1;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn48,
      (object) ultraGridColumn49
    });
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 1;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn50,
      (object) ultraGridColumn51
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    appearance34.BackColor = Color.LightSteelBlue;
    appearance34.FontData.SizeInPoints = 10f;
    appearance34.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance34;
    appearance35.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance36.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance37.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance38.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance38;
    appearance39.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance40.BackColor = Color.Transparent;
    appearance40.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.ug).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ug).Dock = DockStyle.Fill;
    ((Control) this.ug).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ug).Location = new Point(2, 22);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(590, 182);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(660, 487);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 3;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.daAppearsOn.DeleteCommand = sqlCommand1;
    this.daAppearsOn.InsertCommand = sqlCommand2;
    this.daAppearsOn.SelectCommand = sqlCommand3;
    this.daAppearsOn.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyFormsConditionsWarranties_PrintTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("Company_FCW_ID", "Company_FCW_ID"),
        new DataColumnMapping("PrintTypeID", "PrintTypeID")
      })
    });
    this.daAppearsOn.UpdateCommand = sqlCommand4;
    this.daPrintTypes.SelectCommand = sqlCommand5;
    this.daPrintTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyFormsConditionsWarranties_PrintTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("Company_FCW_ID", "Company_FCW_ID"),
        new DataColumnMapping("PrintTypeID", "PrintTypeID")
      })
    });
    this.lnkOrdering.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkOrdering.AutoSize = true;
    this.lnkOrdering.Location = new Point(7, 514);
    this.lnkOrdering.Name = "lnkOrdering";
    this.lnkOrdering.Size = new Size(111, 13);
    this.lnkOrdering.TabIndex = 14;
    this.lnkOrdering.TabStop = true;
    this.lnkOrdering.Text = "Policy Forms Ordering";
    ((Control) this.tabInformation).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabInformation).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabInformation).Controls.Add((Control) this.tabInfo);
    ((Control) this.tabInformation).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.tabInformation).Controls.Add((Control) this.tabAssociatedForms);
    ((Control) this.tabInformation).Location = new Point(176 /*0xB0*/, 220);
    ((Control) this.tabInformation).Name = "tabInformation";
    ((UltraTabControlBase) this.tabInformation).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabInformation).Size = new Size(596, 245);
    ((Control) this.tabInformation).TabIndex = 2;
    ((UltraTabControlBase) this.tabInformation).TabLayoutStyle = (TabLayoutStyle) 1;
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance41;
    ultraTab1.TabPage = this.tabInfo;
    ultraTab1.Text = "Information";
    appearance42.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance42;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Additional Interests";
    appearance43.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance43;
    ultraTab3.Key = "tabAssociatedForms";
    ultraTab3.TabPage = this.tabAssociatedForms;
    ultraTab3.Text = "Associated Forms";
    ((UltraTabControlBase) this.tabInformation).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((UltraTabControlBase) this.tabInformation).TabSize = new Size(150, 25);
    ((UltraTabControlBase) this.tabInformation).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(594, 218);
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CLID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.SqlInsertCommand3.CommandText = "INSERT INTO [tblCompanyInterestForms] ([Company_FCW_ID], [InterestType]) VALUES (@Company_FCW_ID, @InterestType)";
    this.SqlInsertCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Company_FCW_ID", SqlDbType.Int, 0, "Company_FCW_ID"),
      new SqlParameter("@InterestType", SqlDbType.Char, 0, "InterestType")
    });
    this.SqlUpdateCommand3.CommandText = componentResourceManager.GetString("SqlUpdateCommand3.CommandText");
    this.SqlUpdateCommand3.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@Company_FCW_ID", SqlDbType.Int, 0, "Company_FCW_ID"),
      new SqlParameter("@InterestType", SqlDbType.Char, 0, "InterestType"),
      new SqlParameter("@Original_Company_FCW_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InterestType", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InterestType", DataRowVersion.Original, (object) null)
    });
    this.SqlDeleteCommand3.CommandText = "DELETE FROM [tblCompanyInterestForms] WHERE (([Company_FCW_ID] = @Original_Company_FCW_ID) AND ([InterestType] = @Original_InterestType))";
    this.SqlDeleteCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_Company_FCW_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_InterestType", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InterestType", DataRowVersion.Original, (object) null)
    });
    this.daInterestForms.DeleteCommand = this.SqlDeleteCommand3;
    this.daInterestForms.InsertCommand = this.SqlInsertCommand3;
    this.daInterestForms.SelectCommand = this.SqlSelectCommand1;
    this.daInterestForms.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyInterestForms", new DataColumnMapping[2]
      {
        new DataColumnMapping("Company_FCW_ID", "Company_FCW_ID"),
        new DataColumnMapping("InterestType", "InterestType")
      })
    });
    this.daInterestForms.UpdateCommand = this.SqlUpdateCommand3;
    this.daNoteTypes.SelectCommand = sqlCommand6;
    this.daNoteTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstNoteTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("NoteTypeID", "NoteTypeID"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.lnkDeletePolicyForms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeletePolicyForms.AutoSize = true;
    this.lnkDeletePolicyForms.Location = new Point(173, 516);
    this.lnkDeletePolicyForms.Name = "lnkDeletePolicyForms";
    this.lnkDeletePolicyForms.Size = new Size(114, 13);
    this.lnkDeletePolicyForms.TabIndex = 6;
    this.lnkDeletePolicyForms.TabStop = true;
    this.lnkDeletePolicyForms.Text = "Delete Selected Forms";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(173, 468);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(82, 13);
    this.lnkSelectAll.TabIndex = 4;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Forms";
    this.lnkDeselectForms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectForms.AutoSize = true;
    this.lnkDeselectForms.Location = new Point(174, 492);
    this.lnkDeselectForms.Name = "lnkDeselectForms";
    this.lnkDeselectForms.Size = new Size(99, 13);
    this.lnkDeselectForms.TabIndex = 5;
    this.lnkDeselectForms.TabStop = true;
    this.lnkDeselectForms.Text = "De-Select All Forms";
    this.lnkCopyFormsToOtherStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyFormsToOtherStates.AutoSize = true;
    this.lnkCopyFormsToOtherStates.Location = new Point(300, 468);
    this.lnkCopyFormsToOtherStates.Name = "lnkCopyFormsToOtherStates";
    this.lnkCopyFormsToOtherStates.Size = new Size(186, 13);
    this.lnkCopyFormsToOtherStates.TabIndex = 7;
    this.lnkCopyFormsToOtherStates.TabStop = true;
    this.lnkCopyFormsToOtherStates.Text = "Copy Selected Forms to Other States";
    this.lnkSelectAllConditions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllConditions.AutoSize = true;
    this.lnkSelectAllConditions.Location = new Point(7, 220);
    this.lnkSelectAllConditions.Name = "lnkSelectAllConditions";
    this.lnkSelectAllConditions.Size = new Size(103, 13);
    this.lnkSelectAllConditions.TabIndex = 10;
    this.lnkSelectAllConditions.TabStop = true;
    this.lnkSelectAllConditions.Text = "Select All Conditions";
    this.lnkDeSelectAllConditions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllConditions.AutoSize = true;
    this.lnkDeSelectAllConditions.Location = new Point(7, 250);
    this.lnkDeSelectAllConditions.Name = "lnkDeSelectAllConditions";
    this.lnkDeSelectAllConditions.Size = new Size(120, 13);
    this.lnkDeSelectAllConditions.TabIndex = 11;
    this.lnkDeSelectAllConditions.TabStop = true;
    this.lnkDeSelectAllConditions.Text = "De-Select All Conditions";
    this.lnkCopyCondtions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyCondtions.AutoSize = true;
    this.lnkCopyCondtions.Location = new Point(300, 492);
    this.lnkCopyCondtions.Name = "lnkCopyCondtions";
    this.lnkCopyCondtions.Size = new Size(207, 13);
    this.lnkCopyCondtions.TabIndex = 8;
    this.lnkCopyCondtions.TabStop = true;
    this.lnkCopyCondtions.Text = "Copy Selected Conditions to Other States";
    this.daAssoc.DeleteCommand = this.SqlCommand4;
    this.daAssoc.InsertCommand = this.SqlCommand5;
    this.daAssoc.SelectCommand = this.SqlCommand6;
    this.daAssoc.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblWarrantiesAssociatedForms", new DataColumnMapping[2]
      {
        new DataColumnMapping("WarrantyID", "WarrantyID"),
        new DataColumnMapping("Company_FCW_ID", "Company_FCW_ID")
      })
    });
    this.daAssoc.UpdateCommand = this.SqlCommand7;
    this.SqlCommand4.CommandText = "DELETE FROM [dbo].[tblWarrantiesAssociatedForms] WHERE (([WarrantyID] = @Original_WarrantyID) AND ([Company_FCW_ID] = @Original_Company_FCW_ID))";
    this.SqlCommand4.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_WarrantyID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Company_FCW_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand5.CommandText = componentResourceManager.GetString("SqlCommand5.CommandText");
    this.SqlCommand5.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@WarrantyID", SqlDbType.Int, 4, "WarrantyID"),
      new SqlParameter("@Company_FCW_ID", SqlDbType.Int, 4, "Company_FCW_ID")
    });
    this.SqlCommand6.CommandText = componentResourceManager.GetString("SqlCommand6.CommandText");
    this.SqlCommand6.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CLID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.SqlCommand7.CommandText = componentResourceManager.GetString("SqlCommand7.CommandText");
    this.SqlCommand7.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@WarrantyID", SqlDbType.Int, 0, "WarrantyID"),
      new SqlParameter("@Company_FCW_ID", SqlDbType.Int, 0, "Company_FCW_ID"),
      new SqlParameter("@Original_WarrantyID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WarrantyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Company_FCW_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null)
    });
    this.lnkCopyWarrantiesToOtherStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyWarrantiesToOtherStates.AutoSize = true;
    this.lnkCopyWarrantiesToOtherStates.Location = new Point(297, 516);
    this.lnkCopyWarrantiesToOtherStates.Name = "lnkCopyWarrantiesToOtherStates";
    this.lnkCopyWarrantiesToOtherStates.Size = new Size(210, 13);
    this.lnkCopyWarrantiesToOtherStates.TabIndex = 9;
    this.lnkCopyWarrantiesToOtherStates.TabStop = true;
    this.lnkCopyWarrantiesToOtherStates.Text = "Copy Selected Warranties to Other States";
    this.lnkSelectAllWarranties.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllWarranties.AutoSize = true;
    this.lnkSelectAllWarranties.Location = new Point(7, 280);
    this.lnkSelectAllWarranties.Name = "lnkSelectAllWarranties";
    this.lnkSelectAllWarranties.Size = new Size(106, 13);
    this.lnkSelectAllWarranties.TabIndex = 12;
    this.lnkSelectAllWarranties.TabStop = true;
    this.lnkSelectAllWarranties.Text = "Select All Warranties";
    this.lnkDeSelectAllWarranties.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllWarranties.AutoSize = true;
    this.lnkDeSelectAllWarranties.Location = new Point(7, 310);
    this.lnkDeSelectAllWarranties.Name = "lnkDeSelectAllWarranties";
    this.lnkDeSelectAllWarranties.Size = new Size(123, 13);
    this.lnkDeSelectAllWarranties.TabIndex = 13;
    this.lnkDeSelectAllWarranties.TabStop = true;
    this.lnkDeSelectAllWarranties.Text = "De-Select All Warranties";
    this.lnkCopyFormsToOtherCompanyLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyFormsToOtherCompanyLines.AutoSize = true;
    this.lnkCopyFormsToOtherCompanyLines.Location = new Point(536, 468);
    this.lnkCopyFormsToOtherCompanyLines.Name = "lnkCopyFormsToOtherCompanyLines";
    this.lnkCopyFormsToOtherCompanyLines.Size = new Size(86, 13);
    this.lnkCopyFormsToOtherCompanyLines.TabIndex = 15;
    this.lnkCopyFormsToOtherCompanyLines.TabStop = true;
    this.lnkCopyFormsToOtherCompanyLines.Text = "Company / Lines";
    this.Label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(510, 468);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(29, 13);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "-- > ";
    this.Label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(510, 492);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(29, 13);
    this.Label9.TabIndex = 18;
    this.Label9.Text = "-- > ";
    this.lnkCopyConditionsToOtherCompanyLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyConditionsToOtherCompanyLines.AutoSize = true;
    this.lnkCopyConditionsToOtherCompanyLines.Location = new Point(536, 492);
    this.lnkCopyConditionsToOtherCompanyLines.Name = "lnkCopyConditionsToOtherCompanyLines";
    this.lnkCopyConditionsToOtherCompanyLines.Size = new Size(86, 13);
    this.lnkCopyConditionsToOtherCompanyLines.TabIndex = 17;
    this.lnkCopyConditionsToOtherCompanyLines.TabStop = true;
    this.lnkCopyConditionsToOtherCompanyLines.Text = "Company / Lines";
    this.Label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(510, 517);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(29, 13);
    this.Label10.TabIndex = 20;
    this.Label10.Text = "-- > ";
    this.lnkCopyWarrantiesToOtherCompanyLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyWarrantiesToOtherCompanyLines.AutoSize = true;
    this.lnkCopyWarrantiesToOtherCompanyLines.Location = new Point(536, 517);
    this.lnkCopyWarrantiesToOtherCompanyLines.Name = "lnkCopyWarrantiesToOtherCompanyLines";
    this.lnkCopyWarrantiesToOtherCompanyLines.Size = new Size(86, 13);
    this.lnkCopyWarrantiesToOtherCompanyLines.TabIndex = 19;
    this.lnkCopyWarrantiesToOtherCompanyLines.TabStop = true;
    this.lnkCopyWarrantiesToOtherCompanyLines.Text = "Company / Lines";
    ((BarcodeBase) this.UltraCode128Barcode1).ErrorMessageText = "Invalid value! Reference the documentation for the valid barcode Data property value structure.";
    ((Control) this.UltraCode128Barcode1).Location = new Point(0, 0);
    ((Control) this.UltraCode128Barcode1).Name = "UltraCode128Barcode1";
    ((Control) this.UltraCode128Barcode1).Size = new Size(400, 300);
    ((Control) this.UltraCode128Barcode1).TabIndex = 0;
    ((GridBarcodeBase) this.UltraCode128Barcode1).WidthToHeightRatio = 30.0;
    ((GridBarcodeBase) this.UltraCode128Barcode1).XDimension = 1.016;
    this.lnkConditionsOrdering.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkConditionsOrdering.AutoSize = true;
    this.lnkConditionsOrdering.Location = new Point(7, 494);
    this.lnkConditionsOrdering.Name = "lnkConditionsOrdering";
    this.lnkConditionsOrdering.Size = new Size(102, 13);
    this.lnkConditionsOrdering.TabIndex = 21;
    this.lnkConditionsOrdering.TabStop = true;
    this.lnkConditionsOrdering.Text = "Conditions Ordering";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(778, 539);
    this.Controls.Add((Control) this.lnkConditionsOrdering);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.lnkCopyWarrantiesToOtherCompanyLines);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.lnkCopyConditionsToOtherCompanyLines);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.lnkCopyFormsToOtherCompanyLines);
    this.Controls.Add((Control) this.lnkDeSelectAllWarranties);
    this.Controls.Add((Control) this.lnkSelectAllWarranties);
    this.Controls.Add((Control) this.lnkCopyWarrantiesToOtherStates);
    this.Controls.Add((Control) this.lnkCopyCondtions);
    this.Controls.Add((Control) this.lnkDeSelectAllConditions);
    this.Controls.Add((Control) this.lnkSelectAllConditions);
    this.Controls.Add((Control) this.lnkCopyFormsToOtherStates);
    this.Controls.Add((Control) this.lnkDeselectForms);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lnkDeletePolicyForms);
    this.Controls.Add((Control) this.tabInformation);
    this.Controls.Add((Control) this.lnkOrdering);
    this.Controls.Add((Control) this.groupBoxGrid);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(768 /*0x0300*/, 512 /*0x0200*/);
    this.Name = nameof (frmCompanyFormsConditionsWarranties);
    this.Text = "Company Forms / Conditions / Warranties...";
    ((ISupportInitialize) pictureBox1).EndInit();
    ((ISupportInitialize) pictureBox2).EndInit();
    ((ISupportInitialize) pictureBox3).EndInit();
    ((ISupportInitialize) mgaCheckBox1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) mgaCheckBox2).EndInit();
    ((ISupportInitialize) mgaCheckBox3).EndInit();
    ((ISupportInitialize) this.chkIncludeWithBinder).EndInit();
    ((ISupportInitialize) mgaCheckBox4).EndInit();
    ((ISupportInitialize) this.checkMandatory).EndInit();
    ((ISupportInitialize) this.checkBW).EndInit();
    ((ISupportInitialize) this.chkIncludeIndication).EndInit();
    ((ISupportInitialize) mgaCheckBox5).EndInit();
    ((Control) this.tabInfo).ResumeLayout(false);
    ((Control) this.tabInfo).PerformLayout();
    ((ISupportInitialize) this.CmbFCWConditionType).EndInit();
    ((ISupportInitialize) this.dtAddedDate).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    ((ISupportInitialize) this.comboAppearsPer).EndInit();
    this.dvAI.EndInit();
    ((ISupportInitialize) this.checkDefault).EndInit();
    ((ISupportInitialize) this.lstAppearsOn).EndInit();
    ((ISupportInitialize) this.dtDisabled).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.ugchkAdditionalInt).EndInit();
    ((Control) this.tabAssociatedForms).ResumeLayout(false);
    ((ISupportInitialize) this.chkAssociatedForms).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.groupBoxGrid).EndInit();
    ((Control) this.groupBoxGrid).ResumeLayout(false);
    ((ISupportInitialize) this.ug).EndInit();
    ((ISupportInitialize) this.tabInformation).EndInit();
    ((Control) this.tabInformation).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGridBagLayoutManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmCompanyFormsConditionsWarranties(int companyLineID)
    : this()
  {
    this._companyLineID = companyLineID;
  }

  public frmCompanyFormsConditionsWarranties()
  {
    this.FormClosing += new FormClosingEventHandler(this.frmCompanyFormsConditionsWarranties_FormClosing);
    this.Load += new EventHandler(this.frmCompanyFCW_Load);
    this._formLoaded = false;
    this._showNetrateData = false;
    this._insertedAppearsOn = new Dictionary<int, int>();
    this._deletedAppearsOn = new Dictionary<int, int>();
    this.InitializeComponent();
    this._cn = DefaultDatabase.CreateConnection();
  }

  private BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.ds, this.ds.tblCompanyFormsConditionsWarranties.TableName];
    }
  }

  protected dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow CompanyFCWRow
  {
    get
    {
      return this.bmb.Position < 0 ? (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) null : this.ds.tblCompanyFormsConditionsWarranties[this.bmb.Position];
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }

  private void frmCompanyFormsConditionsWarranties_FormClosing(
    object sender,
    FormClosingEventArgs e)
  {
    if (this._fillThread == null || !this._fillThread.IsAlive)
      return;
    this._fillThread.Abort();
    this._fillThread = (Thread) null;
  }

  private void frmCompanyFCW_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    SqlDataAdapter daInterestForms = this.daInterestForms;
    daInterestForms.SelectCommand.Connection = this._cn;
    daInterestForms.InsertCommand.Connection = this._cn;
    daInterestForms.DeleteCommand.Connection = this._cn;
    daInterestForms.UpdateCommand.Connection = this._cn;
    SqlDataAdapter daAppearsOn = this.daAppearsOn;
    daAppearsOn.SelectCommand.Connection = this._cn;
    daAppearsOn.InsertCommand.Connection = this._cn;
    daAppearsOn.DeleteCommand.Connection = this._cn;
    daAppearsOn.UpdateCommand.Connection = this._cn;
    SqlDataAdapter daAssoc = this.daAssoc;
    daAssoc.SelectCommand.Connection = this._cn;
    daAssoc.InsertCommand.Connection = this._cn;
    daAssoc.DeleteCommand.Connection = this._cn;
    daAssoc.UpdateCommand.Connection = this._cn;
    this.daPrintTypes.SelectCommand.Connection = this._cn;
    this.daNoteTypes.SelectCommand.Connection = this._cn;
    this._showNetrateData = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CompanyLinesMgtShowNetrateData", false);
    this.ShowColumn(frmCompanyFormsConditionsWarranties.Columns.Forms);
    this.ds.tblCompanyFormsConditionsWarranties.DefaultView.RowFilter = "PolicyFormID IS NOT NULL";
    this.lblConditionType.Visible = false;
    ((Control) this.CmbFCWConditionType).Visible = false;
    this.lnkConditionsOrdering.Visible = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CompanyLines.ConditionOrdering", false);
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CompanyFormsShowConditionType", false))
    {
      ((Control) this.CmbFCWConditionType).Visible = true;
      this.lblConditionType.Visible = true;
    }
    this.linkNetrateAI.Visible = this._showNetrateData;
    this.dvAI.RowFilter = "IsNetrate = 0";
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void ThreadedFill(object state)
  {
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable warrantiesDataTable = new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable();
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) warrantiesDataTable, "dbo.GetCompanyFCWData", new object[2]
      {
        (object) "@companyLineID",
        (object) this._companyLineID
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.ds.EnforceConstraints = false;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[7]
    {
      this.ds.lstPolicyPrintTypes.TableName,
      this.ds.lstNoteTypes.TableName,
      this.ds.tblCompanyFormsConditionsWarranties_PrintTypes.TableName,
      this.ds.lstAdditionalInterestTypes.TableName,
      this.ds.tblCompanyInterestForms.TableName,
      this.ds.tblWarrantiesAssociatedForms.TableName,
      this.ds.lstFCWConditionType.TableName
    }, "dbo.GetCompanyFCWFormData", new object[2]
    {
      (object) "@companyLineID",
      (object) this._companyLineID
    });
    MDIControls.Instance.MDIParent.Invoke((Delegate) new frmCompanyFormsConditionsWarranties.ThreadedFillCompleteHandler(this.ThreadedFillComplete), (object) warrantiesDataTable);
  }

  private void ThreadedFillComplete(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt)
  {
    bool flag = false;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      ((UltraGridBase) this.ug).DisplayLayout.Save((Stream) memoryStream);
      this.ds.tblCompanyFormsConditionsWarranties.BeginLoadData();
      try
      {
        foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in (TypedTableBase<dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow>) dt)
        {
          this.ds.tblCompanyFormsConditionsWarranties.ImportRow((DataRow) row);
          if (row.CheckedByDefault && row.HasRaterConditional)
            flag = true;
        }
      }
      finally
      {
        IEnumerator<dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow> enumerator;
        enumerator?.Dispose();
      }
      this.ds.tblCompanyFormsConditionsWarranties.EndLoadData();
      try
      {
        this.ds.EnforceConstraints = true;
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
        ProjectData.ClearProjectError();
        return;
      }
      MGACheckedListBox lstAppearsOn = this.lstAppearsOn;
      lstAppearsOn.DataSource = (object) this.ds.lstPolicyPrintTypes;
      lstAppearsOn.DisplayMember = this.ds.lstPolicyPrintTypes.PrintTypeColumn.ColumnName;
      lstAppearsOn.ValueMember = this.ds.lstPolicyPrintTypes.PrintTypeIDColumn.ColumnName;
      memoryStream.Position = 0L;
      ((UltraGridBase) this.ug).DisplayLayout.Load((Stream) memoryStream);
    }
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugchkAdditionalInt).DataSource = (object) this.dvAI;
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
      {
        if (!row.IsPolicyFormIDNull())
        {
          int warrantyID = int.MinValue;
          if (this.ds.tblWarrantiesAssociatedForms.Select("Company_FCW_ID=" + Conversions.ToString(row.Company_FCW_ID)).Length > 0)
          {
            dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow associatedFormsRow = (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) this.ds.tblWarrantiesAssociatedForms.Select("Company_FCW_ID=" + row.Company_FCW_ID.ToString())[0];
            if (associatedFormsRow != null)
              warrantyID = associatedFormsRow.WarrantyID;
          }
          this.chkAssociatedForms.Items.Add((object) new AssociatedFormsWarranties(row.Company_FCW_ID, row.FormName, warrantyID));
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (flag && MessageBox.Show("Some Rater Conditional Forms are configured to be checked by default. Do you want to fix the configurations?", "Invalid Rater Form Setups", MessageBoxButtons.YesNo) == DialogResult.Yes)
    {
      DefaultDatabase.ExecuteNonQuery("spFCW_ClearDefaultRaterConditionalForms", new object[2]
      {
        (object) "@companyLineID",
        (object) this._companyLineID
      });
      try
      {
        foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow conditionsWarranty in (TypedTableBase<dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow>) this.ds.tblCompanyFormsConditionsWarranties)
        {
          if (conditionsWarranty.CheckedByDefault && conditionsWarranty.HasRaterConditional)
            conditionsWarranty.CheckedByDefault = false;
        }
      }
      finally
      {
        IEnumerator<dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow> enumerator;
        enumerator?.Dispose();
      }
    }
    this.ds.AcceptChanges();
    this.dbSave.UIStateChanged += new EventHandler(this.dbSave_UIStateChanged);
    this.SetEditingState(false);
    this.LoadClientData();
  }

  protected virtual void LoadClientData()
  {
  }

  private void lnkOrdering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.ds.tblCompanyFormsConditionsWarranties.Select("PolicyFormID IS NOT NULL").Length > 0)
    {
      using (FormSettings.ShowFormDialog(typeof (frmCompanyFormsOrdering), (object) this._companyLineID, (object) true))
        ;
    }
    else
    {
      int num = (int) MessageBox.Show("There are no forms attached to this policy to order.", "No Forms", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void lnkConditionsOrdering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.ds.tblCompanyFormsConditionsWarranties.Select("ConditionID IS NOT NULL").Length > 0)
    {
      using (FormSettings.ShowFormDialog(typeof (frmCompanyFormsOrdering), (object) this._companyLineID, (object) false))
        ;
    }
    else
    {
      int num = (int) MessageBox.Show("There are no conditions attached to this policy to order.", "No Conditions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void SetEditingState(bool editing)
  {
    ((Control) this.ug).Enabled = !editing;
    this.SetControlsEnabled(editing);
    if (editing)
      return;
    if (((UltraGridBase) this.ug).ActiveRow == null)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void SetControlsEnabled(bool enabled)
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabInformation).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          control.Enabled = enabled;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ((Control) this.dtAddedDate).Enabled = false;
    MGACheckBox checkDefault = this.checkDefault;
    int num;
    if (enabled)
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow companyFcwRow = this.CompanyFCWRow;
      num = (companyFcwRow != null ? (companyFcwRow.HasRaterConditional ? 1 : 0) : 1) == 0 ? 1 : 0;
    }
    else
      num = 0;
    ((Control) checkDefault).Enabled = num != 0;
    ((Control) this.ugchkAdditionalInt).Enabled = true;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Bands[0].Columns["isSelected"].CellActivation = enabled ? (Activation) 0 : (Activation) 1;
    ((UltraGridBase) this.ugchkAdditionalInt).DisplayLayout.Override.RowAppearance.BackColor = enabled ? SystemColors.Window : Color.LightGray;
    this.SetMandatory();
    this.SetBinderWatermark();
  }

  private void ShowColumn(frmCompanyFormsConditionsWarranties.Columns column)
  {
    UltraGridBand band = ((UltraGridBase) this.ug).DisplayLayout.Bands[0];
    band.Columns["FormName"].Hidden = column != 0;
    band.Columns["FormNumber"].Hidden = column != 0;
    band.Columns["EditionDate"].Hidden = column != 0;
    band.Columns["Condition"].Hidden = column != frmCompanyFormsConditionsWarranties.Columns.Conditions;
    band.Columns["WarrantyName"].Hidden = column != frmCompanyFormsConditionsWarranties.Columns.Warranties;
    band.Columns["SelectPolicyForm"].Hidden = column != 0;
    band.Columns["SelectCondition"].Hidden = column != frmCompanyFormsConditionsWarranties.Columns.Conditions;
    band.Columns["SelectWarranty"].Hidden = column != frmCompanyFormsConditionsWarranties.Columns.Warranties;
    DataView defaultView = ((DataTable) ((UltraGridBase) this.ug).DataSource).DefaultView;
    switch (column)
    {
      case frmCompanyFormsConditionsWarranties.Columns.Forms:
        defaultView.RowFilter = "PolicyFormID IS NOT NULL";
        break;
      case frmCompanyFormsConditionsWarranties.Columns.Conditions:
        defaultView.RowFilter = "ConditionID IS NOT NULL";
        break;
      case frmCompanyFormsConditionsWarranties.Columns.Warranties:
        defaultView.RowFilter = "WarrantyID IS NOT NULL";
        break;
      default:
        throw new InvalidOperationException();
    }
    ((UltraTabControlBase) this.tabInformation).Tabs["tabAssociatedForms"].Visible = column == frmCompanyFormsConditionsWarranties.Columns.Warranties;
    this.lnkSelectAllWarranties.Enabled = column == frmCompanyFormsConditionsWarranties.Columns.Warranties;
    this.lnkDeSelectAllWarranties.Enabled = column == frmCompanyFormsConditionsWarranties.Columns.Warranties;
    this.lnkSelectAll.Enabled = column == frmCompanyFormsConditionsWarranties.Columns.Forms;
    this.lnkDeselectForms.Enabled = column == frmCompanyFormsConditionsWarranties.Columns.Forms;
    this.lnkSelectAllConditions.Enabled = column == frmCompanyFormsConditionsWarranties.Columns.Conditions;
    this.lnkDeSelectAllConditions.Enabled = column == frmCompanyFormsConditionsWarranties.Columns.Conditions;
    this.ColumnsChanged(column);
  }

  protected virtual void ColumnsChanged(
    frmCompanyFormsConditionsWarranties.Columns showColumns)
  {
  }

  private void ClickLink(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (sender == this.lnkForms)
    {
      this.ShowColumn(frmCompanyFormsConditionsWarranties.Columns.Forms);
      this.groupBoxGrid.Text = "Policy Forms";
    }
    else if (sender == this.lnkConditions)
    {
      this.ShowColumn(frmCompanyFormsConditionsWarranties.Columns.Conditions);
      this.groupBoxGrid.Text = "Conditions";
    }
    else
    {
      this.ShowColumn(frmCompanyFormsConditionsWarranties.Columns.Warranties);
      this.groupBoxGrid.Text = "Warranties";
    }
  }

  private void MenuItem1_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ug).ActiveRow == null)
      return;
    int company_FCW_ID = (int) ((UltraGridBase) this.ug).ActiveRow.Cells["Company_FCW_ID"].Value;
    int companyLineID = (int) ((UltraGridBase) this.ug).ActiveRow.Cells["CompanyLineID"].Value;
    CompanyLine companyLine = new CompanyLine(companyLineID);
    DataTable dt = DefaultDatabase.ExecuteDataTable("GetCompanyLineData", new object[6]
    {
      (object) "@CompanyLocationGuid",
      (object) companyLine.CompanyLocationGuid,
      (object) "@LineGuid",
      (object) companyLine.LineGuid,
      (object) "@StateID",
      (object) companyLine.StateID
    });
    if (dt.Rows.Count > 0)
    {
      using (frmAddFCWToOtherStates fcwToOtherStates = new frmAddFCWToOtherStates(dt, companyLineID, company_FCW_ID))
      {
        fcwToOtherStates.TopMost = true;
        fcwToOtherStates.StartPosition = FormStartPosition.CenterScreen;
        int num = (int) fcwToOtherStates.ShowDialog();
      }
    }
    else
    {
      int num1 = (int) MessageBox.Show("There are no other states with this company / line setup.", "No Other State With Same Company / Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void ConfigureAppearsOn(int company_FCW_ID)
  {
    this.lstAppearsOn.ItemCheck -= new ItemCheckEventHandler(this.lstAppearsOn_ItemCheck);
    int num1 = this.lstAppearsOn.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstAppearsOn.SetItemChecked(index, false);
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[] warrantiesPrintTypesRowArray = this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(company_FCW_ID).GettblCompanyFormsConditionsWarranties_PrintTypesRows();
    int index1 = 0;
    while (index1 < warrantiesPrintTypesRowArray.Length)
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow warrantiesPrintTypesRow = warrantiesPrintTypesRowArray[index1];
      int num2 = this.lstAppearsOn.Items.Count - 1;
      for (int index2 = 0; index2 <= num2; ++index2)
      {
        if (((dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) ((DataRowView) this.lstAppearsOn.Items[index2]).Row).PrintTypeID == warrantiesPrintTypesRow.PrintTypeID)
          this.lstAppearsOn.SetItemChecked(index2, true);
      }
      checked { ++index1; }
    }
    this.lstAppearsOn.ItemCheck += new ItemCheckEventHandler(this.lstAppearsOn_ItemCheck);
  }

  private void ConfigureOncePer(int company_FCW_ID)
  {
    this.comboAppearsPer.Value = (object) this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(company_FCW_ID).Field<string>("OncePer");
  }

  private void ConfigureAdditionalInterests(int company_FCW_ID)
  {
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow additionalInterestType in (TypedTableBase<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>) this.ds.lstAdditionalInterestTypes)
        additionalInterestType.isSelected = this.ds.tblCompanyInterestForms.FindByCompany_FCW_IDInterestType(company_FCW_ID, additionalInterestType.InterestType) != null;
    }
    finally
    {
      IEnumerator<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow> enumerator;
      enumerator?.Dispose();
    }
    this.ds.lstAdditionalInterestTypes.AcceptChanges();
  }

  private void dbSave_Clicking(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    using ((frmFindFormConditionWarranty) FormSettings.ShowFormDialog(typeof (frmFindFormConditionWarranty), (object) this._companyLineID, (object) this.ds.tblCompanyFormsConditionsWarranties))
      ;
    this.bmb.Position = this.ds.tblCompanyFormsConditionsWarranties.Count - 1;
    DataRow[] dataRowArray = this.ds.tblCompanyFormsConditionsWarranties.Select(string.Empty, string.Empty, DataViewRowState.Added);
    int index1 = 0;
    while (index1 < dataRowArray.Length)
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow conditionsWarrantiesRow1 = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) dataRowArray[index1];
      int num = this.lstAppearsOn.Items.Count - 1;
      for (int index2 = 0; index2 <= num; ++index2)
      {
        dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow row1 = (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) ((DataRowView) this.lstAppearsOn.Items[index2]).Row;
        dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow row2 = this.ds.tblCompanyFormsConditionsWarranties_PrintTypes.NewtblCompanyFormsConditionsWarranties_PrintTypesRow();
        row2.Company_FCW_ID = conditionsWarrantiesRow1.Company_FCW_ID;
        row2.PrintTypeID = row1.PrintTypeID;
        this.ds.tblCompanyFormsConditionsWarranties_PrintTypes.AddtblCompanyFormsConditionsWarranties_PrintTypesRow(row2);
      }
      DateTime dateTime;
      if (!conditionsWarrantiesRow1.IsEffectiveNull())
      {
        dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow conditionsWarrantiesRow2 = conditionsWarrantiesRow1;
        dateTime = conditionsWarrantiesRow1.Effective;
        DateTime date = dateTime.Date;
        conditionsWarrantiesRow2.Effective = date;
      }
      if (!conditionsWarrantiesRow1.IsDisabledNull())
      {
        dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow conditionsWarrantiesRow3 = conditionsWarrantiesRow1;
        dateTime = conditionsWarrantiesRow1.Disabled;
        DateTime date = dateTime.Date;
        conditionsWarrantiesRow3.Disabled = date;
      }
      conditionsWarrantiesRow1.UserGUID = CurrentUser.Instance.UserGUID;
      conditionsWarrantiesRow1.UserName = CurrentUser.Instance.DisplayNameLastFirst;
      conditionsWarrantiesRow1.AppliedToQuotes = false;
      checked { ++index1; }
    }
    this.SaveData();
  }

  private void SaveData()
  {
    this.UpdateFormsCondtionsWarranties();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daAppearsOn, (DataTable) this.ds.tblCompanyFormsConditionsWarranties_PrintTypes);
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daInterestForms, (DataTable) this.ds.tblCompanyInterestForms);
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daAssoc, (DataTable) this.ds.tblWarrantiesAssociatedForms);
    this.SaveDataOnClient();
  }

  protected virtual void SaveDataOnClient()
  {
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    int position = this.bmb.Position;
    this.bmb.EndCurrentEdit();
    this.ugchkAdditionalInt.PerformAction((UltraGridAction) 44);
    ((UltraGridBase) this.ugchkAdditionalInt).UpdateData();
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable) this.ds.tblCompanyFormsConditionsWarranties.Clone();
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow companyFcwRow = this.CompanyFCWRow;
    companyFcwRow["OncePer"] = RuntimeHelpers.GetObjectValue(this.comboAppearsPer.Value);
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow additionalInterestType in (TypedTableBase<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>) this.ds.lstAdditionalInterestTypes)
      {
        DataRow fcwIdInterestType = (DataRow) this.ds.tblCompanyInterestForms.FindByCompany_FCW_IDInterestType(companyFcwRow.Company_FCW_ID, additionalInterestType.InterestType);
        if (!additionalInterestType.isSelected && fcwIdInterestType != null)
          fcwIdInterestType.Delete();
        else if (additionalInterestType.isSelected && fcwIdInterestType == null)
          this.ds.tblCompanyInterestForms.AddtblCompanyInterestFormsRow(companyFcwRow, additionalInterestType);
      }
    }
    finally
    {
      IEnumerator<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow> enumerator;
      enumerator?.Dispose();
    }
    dt.ImportRow((DataRow) companyFcwRow);
    if (!this.ds.HasChanges())
      return;
    bool rowHasChanges;
    try
    {
      rowHasChanges = true;
      this.SaveData();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.Message.Contains("IX_tblCompanyFormsConditionsWarranties"))
      {
        int num = (int) MessageBox.Show("The system has detected a duplicate forms, conditions and/or warranties", "Duplicate Record Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        ProjectData.ClearProjectError();
        return;
      }
      e.Cancel = true;
      throw;
    }
    if (rowHasChanges)
      this.LogChanges(dt);
    this.UpdateChangedRowElements(dt, rowHasChanges);
    this.CopyInterestToCompanyLines(position);
    this.CopyAppearsOnToCompanyLines(position);
    this.ds.tblCompanyFormsConditionsWarranties.AcceptChanges();
    this.ds.tblCompanyInterestForms.AcceptChanges();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.RejectChanges();
    this._deletedAppearsOn.Clear();
    this._insertedAppearsOn.Clear();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.SetEditingState(this.dbSave.UIState == UIState.Editing);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    string str = !this.CompanyFCWRow.IsPolicyFormIDNull() ? (!this.CompanyFCWRow.IsConditionIDNull() ? "warranty" : "condition") : "form";
    if (MessageBox.Show($"Are you sure you want to remove this {str} from this company/line/state setup?", "Remove Form?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    if (!this.DeleteFCWRow(this.CompanyFCWRow))
    {
      int num = (int) MessageBox.Show($"This {str} has been applied to policies and cannot be deleted.\n\nTo remove a form from future policies, set it to disabled.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daAppearsOn, (DataTable) this.ds.tblCompanyFormsConditionsWarranties_PrintTypes);
    this.UpdateFormsCondtionsWarranties();
    ((UltraGridBase) this.ug).UpdateData();
    this.ds.AcceptChanges();
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ug).ActiveRow == null)
      return;
    int num1 = (int) ((UltraGridBase) this.ug).ActiveRow.Cells["Company_FCW_ID"].Value;
    Database.MoveTo((object) num1, this.ds.tblCompanyFormsConditionsWarranties.Company_FCW_IDColumn.ColumnName, (DataTable) this.ds.tblCompanyFormsConditionsWarranties, this.bmb);
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow byCompanyFcwId = this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(num1);
    this.ConfigureAppearsOn(num1);
    this.ConfigureAssociatedFormsWarranties(num1);
    this.ConfigureOncePer(num1);
    this.ConfigureAdditionalInterests(num1);
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow byInterestType = this.ds.lstAdditionalInterestTypes.FindByInterestType(byCompanyFcwId.Field<string>("OncePer"));
    int num2;
    if ((byInterestType != null ? (byInterestType.IsNetrate ? 1 : 0) : 0) == 0)
    {
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable additionalInterestTypes = this.ds.lstAdditionalInterestTypes;
      System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I301\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I301\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I301\u002D0 = predicate = (System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool>) ([SpecialName] (ai) => ai.isSelected && ai.IsNetrate);
      }
      num2 = additionalInterestTypes.Any<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>(predicate) ? 1 : 0;
    }
    else
      num2 = 1;
    this.SwitchAINetRateData(num2 != 0);
    if (this.dbSave.UIState != UIState.Editing)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.ConfigureClientFCW(num1);
  }

  protected virtual void ConfigureClientFCW(int company_FCW_ID)
  {
  }

  private void lstAppearsOn_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow row = (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) ((DataRowView) this.lstAppearsOn.Items[e.Index]).Row;
    int companyFcwId = this.CompanyFCWRow.Company_FCW_ID;
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow fcwIdPrintTypeId = this.ds.tblCompanyFormsConditionsWarranties_PrintTypes.FindByCompany_FCW_IDPrintTypeID(companyFcwId, row.PrintTypeID);
    if (e.NewValue == CheckState.Checked)
    {
      if (fcwIdPrintTypeId == null)
        this.ds.tblCompanyFormsConditionsWarranties_PrintTypes.AddtblCompanyFormsConditionsWarranties_PrintTypesRow(this.CompanyFCWRow, this.ds.lstPolicyPrintTypes.FindByPrintTypeID(row.PrintTypeID));
      else
        fcwIdPrintTypeId.RejectChanges();
      if (!this._insertedAppearsOn.ContainsKey(row.PrintTypeID))
        this._insertedAppearsOn.Add(row.PrintTypeID, companyFcwId);
      if (!this._deletedAppearsOn.ContainsKey(row.PrintTypeID))
        return;
      this._deletedAppearsOn.Remove(row.PrintTypeID);
    }
    else
    {
      if (fcwIdPrintTypeId == null)
        return;
      if (fcwIdPrintTypeId.RowState == DataRowState.Added)
        this.ds.tblCompanyFormsConditionsWarranties_PrintTypes.RemovetblCompanyFormsConditionsWarranties_PrintTypesRow(fcwIdPrintTypeId);
      else
        fcwIdPrintTypeId.Delete();
      if (!this._deletedAppearsOn.ContainsKey(row.PrintTypeID))
        this._deletedAppearsOn.Add(row.PrintTypeID, companyFcwId);
      if (!this._insertedAppearsOn.ContainsKey(row.PrintTypeID))
        return;
      this._insertedAppearsOn.Remove(row.PrintTypeID);
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
      {
        if (!row.IsPolicyFormIDNull())
          row.SelectPolicyForm = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkDeletePolicyForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.ds.tblCompanyFormsConditionsWarranties.Count == 0 || MessageBox.Show("Continue to delete the selected policy forms?", "Continue Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      bool flag = false;
      string str = "";
      try
      {
        foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
        {
          if (!row.IsPolicyFormIDNull() && row.SelectPolicyForm && !this.DeleteFCWRow(row))
          {
            flag = true;
            str = $"{str}{row.FormName}\r\n";
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag)
      {
        int num = (int) MessageBox.Show($"The following forms/conditions/warranties have been applied to policies and cannot be deleted: \r\n{str}To remove a form from future policies, set it to disabled.");
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daAppearsOn, (DataTable) this.ds.tblCompanyFormsConditionsWarranties_PrintTypes);
      this.UpdateFormsCondtionsWarranties();
      ((UltraGridBase) this.ug).UpdateData();
      this.ds.tblCompanyFormsConditionsWarranties.AcceptChanges();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkDeselectForms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
      {
        if (!row.IsPolicyFormIDNull())
          row.SelectPolicyForm = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void CopyInterestToCompanyLines(int rowIndex)
  {
    if (rowIndex == -1 || this.ds.tblCompanyFormsConditionsWarranties[rowIndex].IsPolicyFormIDNull())
      return;
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable additionalInterestTypes = this.ds.lstAdditionalInterestTypes;
    System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D0 = predicate1 = (System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool>) ([SpecialName] (dr) => dr.isSelected ^ dr.Field<bool>("isSelected", DataRowVersion.Original));
    }
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow[] array = additionalInterestTypes.Where<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>(predicate1).ToArray<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>();
    if (array.Length == 0)
      return;
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow conditionsWarranty = this.ds.tblCompanyFormsConditionsWarranties[rowIndex];
    if (!this.OtherCompanyLinesExist(conditionsWarranty.CompanyLineID))
      return;
    string empty = string.Empty;
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow[] source1 = array;
    System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool> predicate2;
    // ISSUE: reference to a compiler-generated field
    if (frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate2 = frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D1 = predicate2 = (System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool>) ([SpecialName] (dr) => !dr.isSelected);
    }
    string str;
    if (((IEnumerable<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>) source1).Any<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>(predicate2))
    {
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow[] source2 = array;
      System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool> predicate3;
      // ISSUE: reference to a compiler-generated field
      if (frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate3 = frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D2 = predicate3 = (System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool>) ([SpecialName] (dr) => dr.isSelected);
      }
      if (((IEnumerable<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>) source2).Any<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>(predicate3))
      {
        str = "deleted and inserted interests";
        goto label_19;
      }
    }
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow[] source3 = array;
    System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool> predicate4;
    // ISSUE: reference to a compiler-generated field
    if (frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D3 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate4 = frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D3;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmCompanyFormsConditionsWarranties._Closure\u0024__.\u0024I307\u002D3 = predicate4 = (System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool>) ([SpecialName] (dr) => dr.isSelected);
    }
    str = !((IEnumerable<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>) source3).Any<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>(predicate4) ? "deleted interests" : "inserted interests";
label_19:
    if (MessageBox.Show($"You have {str}{"\n"}{"\n"}Do you wish to update other states with the same company / line with {str}?", $"Copy Over {str} to Other Company / Line?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    int policyFormId = this.ds.tblCompanyFormsConditionsWarranties[rowIndex].PolicyFormID;
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow[] interestTypesRowArray = array;
    int index = 0;
    while (index < interestTypesRowArray.Length)
    {
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow interestTypesRow = interestTypesRowArray[index];
      DefaultDatabase.ExecuteNonQuery("dbo.UpdateCompanyInterestForms", new object[8]
      {
        (object) "@Company_FCW_ID",
        (object) conditionsWarranty.Company_FCW_ID,
        (object) "@InterestType",
        (object) interestTypesRow.InterestType,
        (object) "@FormID",
        (object) policyFormId,
        (object) "@UpdateType",
        interestTypesRow.isSelected ? (object) "I" : (object) "D"
      });
      checked { ++index; }
    }
  }

  private Dictionary<string, string> GetTableColumns(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow dr)
  {
    Dictionary<string, string> tableColumns = new Dictionary<string, string>();
    string str1 = "<Empty>";
    string str2 = "<Empty>";
    string str3 = "<Empty>";
    string str4 = "<Empty>";
    string str5 = "<Empty>";
    if (!dr.IsEffectiveNull())
      str1 = dr.Effective.ToShortDateString();
    if (!dr.IsDisabledNull())
      str2 = dr.Disabled.ToShortDateString();
    if (!dr.IsGenerateDiaryNull())
      dr.GenerateDiary.ToString();
    if (!dr.IsNoteTypeIDNull())
      str3 = this.ds.lstNoteTypes.FindByNoteTypeID(dr.NoteTypeID).Description;
    if (!dr.IsConditionTypeNameIDNull())
      str5 = this.ds.lstFCWConditionType.FindByID(dr.ConditionTypeNameID).ConditionTypeName;
    if (!dr.IsOncePerNull())
      str4 = dr.OncePer;
    bool flag = dr.CheckedByDefault;
    tableColumns.Add("CheckedByDefault", $"Check By Default  [{flag.ToString()}]");
    flag = dr.ShowOnQuote;
    tableColumns.Add("ShowOnQuote", $"Show On Quote [{flag.ToString()}]");
    tableColumns.Add("Effective", $"Effective [{str1}]");
    tableColumns.Add("Disabled", $"Disabled [{str2}]");
    tableColumns.Add("GenerateDiary", $"Generate Diary [{str2}]");
    flag = dr.IncludeWithQuotation;
    tableColumns.Add("IncludeWithQuotation", $"Include With Quotation [{flag.ToString()}]");
    tableColumns.Add("NoteTypeID", $"Note Type [{str3}]");
    tableColumns.Add("ConditionTypeNameID", $"FCW Condition Type [{str5}]");
    tableColumns.Add("OncePer", $"Once Per [{str4}]");
    flag = dr.Mandatory;
    tableColumns.Add("Mandatory", $"Mandatory  [{flag.ToString()}]");
    flag = dr.GenerateQuoteDiary;
    tableColumns.Add("GenerateQuoteDiary", $"Generate Diary  [{flag.ToString()}]");
    tableColumns.Add("IncludeWithBinder", $"Include with Binder  [{dr.IncludeWithBinder.ToString()}]");
    flag = dr.CommonToPackage;
    tableColumns.Add("CommonToPackage", $"Limit to Primary State [{flag.ToString()}]");
    tableColumns.Add("IncludeWithIndication", $"Include with Indication [{Conversions.ToString(dr.IncludeWithIndication)}]");
    flag = dr.BinderWatermark;
    tableColumns.Add("BinderWatermark", $"Binder Watermark [{flag.ToString()}]");
    return tableColumns;
  }

  private string GetWhereClause(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row,
    frmCompanyFormsConditionsWarranties.Columns column)
  {
    string str1;
    int num;
    switch (column)
    {
      case frmCompanyFormsConditionsWarranties.Columns.Forms:
        str1 = "PolicyFormID";
        num = row.PolicyFormID;
        break;
      case frmCompanyFormsConditionsWarranties.Columns.Conditions:
        str1 = "ConditionID";
        num = row.ConditionID;
        break;
      case frmCompanyFormsConditionsWarranties.Columns.Warranties:
        str1 = "WarrantyID";
        num = row.WarrantyID;
        break;
      default:
        throw new InvalidOperationException();
    }
    CompanyLine companyLine = new CompanyLine(row.CompanyLineID);
    string str2 = $" WHERE {str1} = {Conversions.ToString(num)} AND CompanyLineID IN (SELECT CompanyLineID FROM tblCompanyLines WITH (NOLOCK) WHERE LineGUID = '{companyLine.LineGuid.ToString()}' AND CompanyLocationGUID = '{companyLine.CompanyLocationGuid.ToString()}' AND StateID <> '{companyLine.StateID}'";
    return companyLine.IsParentLine ? str2 + " AND ParentCompanyLineGUID IS NULL )" : str2 + " AND ParentCompanyLineGUID IS NOT NULL )";
  }

  private bool OtherCompanyLinesExist(int companyLineID)
  {
    CompanyLine companyLine = new CompanyLine(companyLineID);
    string str = "SELECT CASE WHEN EXISTS ( SELECT * FROM tblCompanyLines WITH (NOLOCK) WHERE LineGUID = @LG AND CompanyLocationGUID = @CLG AND StateID <> @ST ";
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, companyLine.IsParentLine ? str + " AND ParentCompanyLineGUID IS NULL ) THEN 1 ELSE 0 END" : str + " AND ParentCompanyLineGUID IS NOT NULL ) THEN 1 ELSE 0 END", new object[6]
    {
      (object) "@LG",
      (object) companyLine.LineGuid,
      (object) "@CLG",
      (object) companyLine.CompanyLocationGuid,
      (object) "@ST",
      (object) companyLine.StateID
    }) == 1;
  }

  private void UpdateChangedRowElements(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt,
    bool rowHasChanges)
  {
    if (!rowHasChanges || dt[0].RowState != DataRowState.Modified)
      return;
    frmCompanyFormsConditionsWarranties.Columns columns;
    string str;
    if (!dt[0].IsPolicyFormIDNull())
    {
      columns = frmCompanyFormsConditionsWarranties.Columns.Forms;
      str = "policy form";
    }
    else if (!dt[0].IsConditionIDNull())
    {
      columns = frmCompanyFormsConditionsWarranties.Columns.Conditions;
      str = "condition";
    }
    else
    {
      columns = frmCompanyFormsConditionsWarranties.Columns.Warranties;
      str = "warranty";
    }
    if (!this.OtherCompanyLinesExist(dt[0].CompanyLineID) || MessageBox.Show($"You have made changes to a {str}.\n\nDo you wish to copy over any changed data to other states with the same company / line?", "Copy Over Modified Data to Other Company / Line?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    string whereClause = this.GetWhereClause(dt[0], columns);
    string messageCaption = "Clicking the save button will update all states with the same company and line \nto the specificied new values";
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    sqlConnection.Open();
    SqlTransaction t = sqlConnection.BeginTransaction();
    FormDataUpdate formDataUpdate = (FormDataUpdate) null;
    try
    {
      formDataUpdate = new FormDataUpdate((DataRow) dt[0], this.GetTableColumns(dt[0]), t, whereClause, messageCaption);
      if (formDataUpdate.ListBoxItemsCount > 0)
      {
        formDataUpdate.ShowInTaskbar = false;
        int num = (int) formDataUpdate.ShowDialog();
      }
      this.ClientCopyOverChangedDatatoOtherStates(dt, t, messageCaption, columns);
      t.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      t.Rollback();
      sqlConnection.Close();
      throw;
    }
    finally
    {
      t?.Dispose();
      if (sqlConnection != null)
      {
        sqlConnection.Close();
        sqlConnection.Dispose();
      }
      formDataUpdate?.Dispose();
    }
  }

  protected virtual void ClientCopyOverChangedDatatoOtherStates(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt,
    SqlTransaction t,
    string messageCaption,
    frmCompanyFormsConditionsWarranties.Columns tmpColumnType)
  {
  }

  private void CopyAppearsOnToCompanyLines(int rowIndex)
  {
    if (rowIndex == -1 || this.ds.tblCompanyFormsConditionsWarranties[rowIndex].IsPolicyFormIDNull() || this._insertedAppearsOn.Count == 0 && this._deletedAppearsOn.Count == 0 || !this.OtherCompanyLinesExist(this.ds.tblCompanyFormsConditionsWarranties[rowIndex].CompanyLineID))
      return;
    string str1 = string.Empty;
    if (this._deletedAppearsOn.Count > 0)
      str1 = "deleted 'Appears On'";
    if (this._insertedAppearsOn.Count > 0)
      str1 = "inserted 'Appears On'";
    if (this._deletedAppearsOn.Count > 0 && this._insertedAppearsOn.Count > 0)
      str1 = "deleted and inserted 'Appears On'";
    if (MessageBox.Show($"You have {str1}\n\nDo you wish to update other states with the same company / line with {str1}?", $"Copy Over {str1} to Other Company / Line?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    int policyFormId = this.ds.tblCompanyFormsConditionsWarranties[rowIndex].PolicyFormID;
    string str2 = "I";
    try
    {
      foreach (KeyValuePair<int, int> keyValuePair in this._insertedAppearsOn)
        DefaultDatabase.ExecuteNonQuery("dbo.UpdateCompanyLineFormsAppearsOn", new object[8]
        {
          (object) "@Company_FCW_ID",
          (object) keyValuePair.Value,
          (object) "@PrintTypeID",
          (object) keyValuePair.Key,
          (object) "@FormID",
          (object) policyFormId,
          (object) "@UpdateType",
          (object) str2
        });
    }
    finally
    {
      Dictionary<int, int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    string str3 = "D";
    try
    {
      foreach (KeyValuePair<int, int> keyValuePair in this._deletedAppearsOn)
        DefaultDatabase.ExecuteNonQuery("dbo.UpdateCompanyLineFormsAppearsOn", new object[8]
        {
          (object) "@Company_FCW_ID",
          (object) keyValuePair.Value,
          (object) "@PrintTypeID",
          (object) keyValuePair.Key,
          (object) "@FormID",
          (object) policyFormId,
          (object) "@UpdateType",
          (object) str3
        });
    }
    finally
    {
      Dictionary<int, int>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void lnkSelectAllConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectDeselectConditions(true);
  }

  private void lnkDeSelectAllConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectDeselectConditions(false);
  }

  private void SelectDeselectConditions(bool isSlect)
  {
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
      {
        if (!row.IsConditionIDNull())
          row.SelectCondition = isSlect;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkCopyCondtions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.CopyFormsConditionsWarranties(frmCompanyFormsConditionsWarranties.Columns.Conditions, frmCompanyFormsConditionsWarranties.CopyDestination.States);
  }

  private void lnkCopyFormsToOtherStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.CopyFormsConditionsWarranties(frmCompanyFormsConditionsWarranties.Columns.Forms, frmCompanyFormsConditionsWarranties.CopyDestination.States);
  }

  private void lnkCopyWarrantiesToOtherStates_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    this.CopyFormsConditionsWarranties(frmCompanyFormsConditionsWarranties.Columns.Warranties, frmCompanyFormsConditionsWarranties.CopyDestination.States);
  }

  private void CopyFormsConditionsWarranties(
    frmCompanyFormsConditionsWarranties.Columns entityData,
    frmCompanyFormsConditionsWarranties.CopyDestination entityDestination)
  {
    if (this.ds.tblCompanyFormsConditionsWarranties.Count == 0)
    {
      string text;
      string caption;
      switch (entityData)
      {
        case frmCompanyFormsConditionsWarranties.Columns.Forms:
          text = "No Policy Forms are available.";
          caption = "No Policy Forms Available";
          break;
        case frmCompanyFormsConditionsWarranties.Columns.Conditions:
          text = "No Conditions are available.";
          caption = "No Conditions Available";
          break;
        case frmCompanyFormsConditionsWarranties.Columns.Warranties:
          text = "No Warranties are available.";
          caption = "No Warranties Available";
          break;
        default:
          throw new InvalidOperationException();
      }
      int num = (int) MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      DataTable dt = (DataTable) null;
      int companyLineId = this.ds.tblCompanyFormsConditionsWarranties[0].CompanyLineID;
      if (entityDestination == frmCompanyFormsConditionsWarranties.CopyDestination.States)
      {
        CompanyLine companyLine = new CompanyLine(companyLineId);
        dt = DefaultDatabase.ExecuteDataTable("GetCompanyLineData", new object[6]
        {
          (object) "@CompanyLocationGuid",
          (object) companyLine.CompanyLocationGuid,
          (object) "@LineGuid",
          (object) companyLine.LineGuid,
          (object) "@StateID",
          (object) companyLine.StateID
        });
        if (dt.Rows.Count == 0)
        {
          int num = (int) MessageBox.Show("There are no other states with this company / line setup.", "No Other State With Same Company / Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
      }
      List<int> lstCompanyFCW = new List<int>();
      switch (entityData)
      {
        case frmCompanyFormsConditionsWarranties.Columns.Forms:
          try
          {
            foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
            {
              if (!row.IsPolicyFormIDNull() && row.SelectPolicyForm)
                lstCompanyFCW.Add(row.Company_FCW_ID);
            }
            break;
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        case frmCompanyFormsConditionsWarranties.Columns.Conditions:
          try
          {
            foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
            {
              if (!row.IsConditionIDNull() && row.SelectCondition)
                lstCompanyFCW.Add(row.Company_FCW_ID);
            }
            break;
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        case frmCompanyFormsConditionsWarranties.Columns.Warranties:
          try
          {
            foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
            {
              if (!row.IsWarrantyIDNull() && row.SelectWarranty)
                lstCompanyFCW.Add(row.Company_FCW_ID);
            }
            break;
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        default:
          throw new InvalidOperationException();
      }
      if (lstCompanyFCW.Count == 0)
      {
        string text;
        string caption;
        switch (entityData)
        {
          case frmCompanyFormsConditionsWarranties.Columns.Forms:
            text = "No policy forms are selected to copy to other company / line setup.";
            caption = "No Policy Form Selected";
            break;
          case frmCompanyFormsConditionsWarranties.Columns.Conditions:
            text = "No condition is selected to copy to other company / line setup.";
            caption = "No Condition Selected";
            break;
          case frmCompanyFormsConditionsWarranties.Columns.Warranties:
            text = "No warranty is selected to copy to other company / line setup.";
            caption = "No Warranties Available";
            break;
          default:
            throw new InvalidOperationException();
        }
        int num = (int) MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (entityDestination == frmCompanyFormsConditionsWarranties.CopyDestination.States)
      {
        using (frmAddFCWToOtherStates fcwToOtherStates = new frmAddFCWToOtherStates(dt, companyLineId, lstCompanyFCW))
        {
          fcwToOtherStates.TopMost = true;
          fcwToOtherStates.StartPosition = FormStartPosition.CenterScreen;
          int num = (int) fcwToOtherStates.ShowDialog();
        }
      }
      else
      {
        using (FormCopyFcwToCompanyLines fcwToCompanyLines = new FormCopyFcwToCompanyLines(companyLineId, lstCompanyFCW))
        {
          fcwToCompanyLines.TopMost = true;
          fcwToCompanyLines.StartPosition = FormStartPosition.CenterScreen;
          int num = (int) fcwToCompanyLines.ShowDialog();
        }
      }
    }
  }

  public virtual void SetMandatory()
  {
    ((Control) this.checkMandatory).Enabled = this.dbSave.UIState == UIState.Editing && (!((Control) this.checkDefault).Enabled || ((UltraToggleEditorBase) this.checkDefault).Checked);
  }

  public virtual void SetBinderWatermark()
  {
    ((Control) this.checkBW).Enabled = this.dbSave.UIState == UIState.Editing && (!((Control) this.chkIncludeWithBinder).Enabled || ((UltraToggleEditorBase) this.chkIncludeWithBinder).Checked);
  }

  private void checkDefault_CheckedChanged(object sender, EventArgs e)
  {
    if (((Control) this.checkDefault).Enabled && !((UltraToggleEditorBase) this.checkDefault).Checked)
      ((UltraToggleEditorBase) this.checkMandatory).Checked = false;
    this.SetMandatory();
  }

  private bool DeleteFCWRow(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow dr)
  {
    if (dr.IsAppliedToQuotesNull())
      dr.AppliedToQuotes = (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsFormAppliedToQuotes(@Company_FCW_ID)", new object[2]
      {
        (object) "@Company_FCW_ID",
        (object) dr.Company_FCW_ID
      }) ? 1 : 0) != 0;
    bool flag;
    if (!dr.AppliedToQuotes)
    {
      dr.Delete();
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  private void ConfigureAssociatedFormsWarranties(int company_FCW_ID)
  {
    this.chkAssociatedForms.ItemCheck -= new ItemCheckEventHandler(this.chkAssociatedForms_ItemCheck);
    int num1 = this.chkAssociatedForms.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.chkAssociatedForms.SetItemChecked(index, false);
    if (this.CompanyFCWRow == null || this.CompanyFCWRow.IsWarrantyIDNull())
      return;
    int warrantyId = this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(company_FCW_ID).WarrantyID;
    int num2 = this.chkAssociatedForms.Items.Count - 1;
    for (int index = 0; index <= num2; ++index)
    {
      AssociatedFormsWarranties associatedFormsWarranties = (AssociatedFormsWarranties) this.chkAssociatedForms.Items[index];
      if (this.ds.tblWarrantiesAssociatedForms.FindByWarrantyIDCompany_FCW_ID(warrantyId, associatedFormsWarranties.Company_FCW_ID) != null)
        this.chkAssociatedForms.SetItemChecked(index, true);
    }
    this.chkAssociatedForms.ItemCheck += new ItemCheckEventHandler(this.chkAssociatedForms_ItemCheck);
  }

  private void chkAssociatedForms_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    AssociatedFormsWarranties associatedFormsWarranties = (AssociatedFormsWarranties) this.chkAssociatedForms.Items[e.Index];
    int companyFcwId = associatedFormsWarranties.Company_FCW_ID;
    int warrantyId = this.CompanyFCWRow.WarrantyID;
    dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow warrantyIdCompanyFcwId = this.ds.tblWarrantiesAssociatedForms.FindByWarrantyIDCompany_FCW_ID(warrantyId, companyFcwId);
    if (e.NewValue == CheckState.Checked)
    {
      if (warrantyIdCompanyFcwId == null)
      {
        associatedFormsWarranties.WarrantyID = warrantyId;
        dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow row = this.ds.tblWarrantiesAssociatedForms.NewtblWarrantiesAssociatedFormsRow();
        row.Company_FCW_ID = companyFcwId;
        row.WarrantyID = warrantyId;
        this.ds.tblWarrantiesAssociatedForms.AddtblWarrantiesAssociatedFormsRow(row);
      }
      else
        warrantyIdCompanyFcwId.RejectChanges();
    }
    else
    {
      if (warrantyIdCompanyFcwId == null)
        return;
      if (warrantyIdCompanyFcwId.RowState == DataRowState.Added)
        this.ds.tblWarrantiesAssociatedForms.RemovetblWarrantiesAssociatedFormsRow(warrantyIdCompanyFcwId);
      else
        warrantyIdCompanyFcwId.Delete();
    }
  }

  private void lnkSelectAllWarranties_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectDeselectWarranties(true);
  }

  private void lnkDeSelectAllWarranties_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectDeselectWarranties(false);
  }

  private void SelectDeselectWarranties(bool booleanValueSelected)
  {
    try
    {
      foreach (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row in this.ds.tblCompanyFormsConditionsWarranties.Rows)
      {
        if (!row.IsWarrantyIDNull())
          row.SelectWarranty = booleanValueSelected;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkCopyFormsToOtherCompanyLines_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    this.CopyFormsConditionsWarranties(frmCompanyFormsConditionsWarranties.Columns.Forms, frmCompanyFormsConditionsWarranties.CopyDestination.CompanyLine);
  }

  private void lnkCopyConditionsToOtherCompanyLines_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    this.CopyFormsConditionsWarranties(frmCompanyFormsConditionsWarranties.Columns.Conditions, frmCompanyFormsConditionsWarranties.CopyDestination.CompanyLine);
  }

  private void lnkCopyWarrantiesToOtherCompanyLines_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    this.CopyFormsConditionsWarranties(frmCompanyFormsConditionsWarranties.Columns.Warranties, frmCompanyFormsConditionsWarranties.CopyDestination.CompanyLine);
  }

  private void LogChanges(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt)
  {
    string str1 = "<null>";
    Guid companyLineGuid = new CompanyLine(this._companyLineID).CompanyLineGuid;
    string str2;
    string str3;
    if (!dt[0].IsPolicyFormIDNull())
    {
      str2 = "Form";
      str3 = dt[0].FormName;
    }
    else if (!dt[0].IsWarrantyIDNull())
    {
      str2 = "Warranty";
      str3 = dt[0].WarrantyName;
    }
    else
    {
      str2 = "Condition";
      str3 = dt[0].Condition;
    }
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) dt.Columns)
      {
        string str4 = column.ColumnName;
        if (str4.Equals("CommontoPackage"))
          str4 = "Limit to Primary State";
        string InterestType1 = str1;
        string InterestType2 = str1;
        if (dt[0][column.ColumnName, DataRowVersion.Original] != DBNull.Value)
          InterestType1 = dt[0][column.ColumnName, DataRowVersion.Original].ToString();
        if (dt[0][column.ColumnName, DataRowVersion.Current] != DBNull.Value)
          InterestType2 = dt[0][column.ColumnName, DataRowVersion.Current].ToString();
        if (!InterestType1.Equals(InterestType2))
        {
          if (column.ColumnName.Equals("OncePer"))
          {
            if (!InterestType1.Equals(str1))
              InterestType1 = this.ds.lstAdditionalInterestTypes.FindByInterestType(InterestType1).AdditionalInterest;
            if (!InterestType2.Equals(str1))
              InterestType2 = this.ds.lstAdditionalInterestTypes.FindByInterestType(InterestType2).AdditionalInterest;
          }
          else if (column.ColumnName.Equals("NoteTypeID"))
          {
            if (!InterestType1.Equals(str1))
              InterestType1 = this.ds.lstNoteTypes.FindByNoteTypeID(Conversions.ToInteger(InterestType1)).Description;
            if (!InterestType2.Equals(str1))
              InterestType2 = this.ds.lstNoteTypes.FindByNoteTypeID(Conversions.ToInteger(InterestType2)).Description;
          }
          else if (column.ColumnName.Equals("ConditonTypeNameID"))
          {
            if (!InterestType1.Equals(str1))
              InterestType1 = this.ds.lstFCWConditionType.FindByID(Conversions.ToInteger(InterestType1)).ConditionTypeName;
            if (!InterestType2.Equals(str1))
              InterestType2 = this.ds.lstFCWConditionType.FindByID(Conversions.ToInteger(InterestType2)).ConditionTypeName;
          }
          CurrentUser.Instance.LogAction($"Modified Company/Line {str2} '{str3}'. - Changed {str4} from  '{InterestType1}' to '{InterestType2}'", companyLineGuid);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void linkNetrateAI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    // ISSUE: variable of a compiler-generated type
    frmCompanyFormsConditionsWarranties._Closure\u0024__334\u002D0 closure3340_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmCompanyFormsConditionsWarranties._Closure\u0024__334\u002D0 closure3340_2 = new frmCompanyFormsConditionsWarranties._Closure\u0024__334\u002D0(closure3340_1);
    // ISSUE: reference to a compiler-generated field
    closure3340_2.\u0024VB\u0024Local_showNRData = !((bool?) this.linkNetrateAI.Tag).GetValueOrDefault();
    // ISSUE: reference to a compiler-generated method
    if (this.ds.lstAdditionalInterestTypes.Any<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>(new System.Func<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow, bool>(closure3340_2._Lambda\u0024__0)))
    {
      if (MessageBox.Show("You have interests selected. Switching will clear selected AI's. Continue?", "Clear Selected Interests?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      try
      {
        foreach (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow additionalInterestType in (TypedTableBase<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>) this.ds.lstAdditionalInterestTypes)
          additionalInterestType.isSelected = false;
      }
      finally
      {
        IEnumerator<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow> enumerator;
        enumerator?.Dispose();
      }
      ((UltraControlBase) this.ugchkAdditionalInt).Update();
    }
    // ISSUE: reference to a compiler-generated field
    this.SwitchAINetRateData(closure3340_2.\u0024VB\u0024Local_showNRData);
  }

  private void SwitchAINetRateData(bool show)
  {
    this.dvAI.RowFilter = $"IsNetrate = {show}";
    this.linkNetrateAI.Text = show ? "Show IMS AI" : "Show NetRate AI";
    this.linkNetrateAI.Tag = (object) show;
  }

  private void chkIncludeWithBinder_CheckedChanged(object sender, EventArgs e)
  {
    if (((Control) this.chkIncludeWithBinder).Enabled && !((UltraToggleEditorBase) this.chkIncludeWithBinder).Checked)
      ((UltraToggleEditorBase) this.checkBW).Checked = false;
    this.SetBinderWatermark();
  }

  protected virtual void UpdateFormsCondtionsWarranties()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblCompanyFormsConditionsWarranties, "dbo.InsertCompanyFormsConditionsWarranties", "dbo.UpdateCompanyFormsConditionsWarranties", "dbo.DeleteCompanyFormsConditionsWarranties", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblCompanyFormsConditionsWarranties);
  }

  protected enum Columns
  {
    Forms,
    Conditions,
    Warranties,
  }

  private enum CopyDestination
  {
    States,
    CompanyLine,
  }

  private delegate void ThreadedFillCompleteHandler(
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt);
}
