// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmAdditionalInterests
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Policies.AdditionalInterests;
using MGASystems.IMS.Policies.Rating.Locations;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[SecureResource("{9E42695B-0F68-4dd0-862D-A6F32244DDFA}", "Allow Update When Policy Issued", "Allows the user to update additional interests when policy is issued.", "Policy")]
[SecureResource("{76752242-B0DF-4316-959F-C171E26359A1}", "Control Access to Additional Interest Screen", "Allows for a user to view Additional Interest Screen", "Policies")]
[SecureResource("{7D2C4C5C-F51B-4B4A-AB4F-F537208BEDBF}", "Clear OFAC Date", "Controls whether or not a user can clear Add'l Interest OFAC Date", "Policies")]
public class frmAdditionalInterests : Form, ISupportPolicyTemplateDocs, IMessageListener
{
  private IContainer components;
  private MGATextBox txtInsuredName;
  private ErrorProvider err;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  protected UltraTabPageControl UltraTabPageControl2;
  private DbDataAdapter daInterests;
  private DbDataAdapter daQuoteInterestTypes;
  private DbCommand DbSelectCommand5;
  private DbCommand DbInsertCommand3;
  private DbCommand DbUpdateCommand3;
  private DbCommand DbDeleteCommand3;
  private DbCommand DbSelectCommand3;
  private DbCommand DbInsertCommand4;
  private DbCommand DbUpdateCommand4;
  private DbCommand DbDeleteCommand4;
  protected MGATextBox TextBox1;
  private ToolTip aiTip;
  private DbCommand DbSelectCommand4;
  private DbCommand DbInsertCommand2;
  private DbCommand DbUpdateCommand2;
  private DbCommand DbDeleteCommand2;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private DbCommand DbSelectCommand6;
  private DbCommand DbInsertCommand5;
  private DbCommand DbUpdateCommand5;
  private DbCommand DbDeleteCommand5;
  private DbCommand DbSelectCommand2;
  private MGAMaskedEdit txtFEIN;
  private ContextMenuStrip cntMenu;
  protected UltraTabPageControl UltraTabPageControl4;
  protected UltraTabPageControl UltraTabPageControl5;
  protected CheckedListBox lstVehicles;
  private DbCommand DbSelectCommand8;
  private DbCommand DbInsertCommand6;
  private DbCommand DbUpdateCommand6;
  private DbCommand DbDeleteCommand6;
  private DbDataAdapter daQuoteNetRateVehicles;
  public const string AllowUpdateWhenPolicyIssued = "{9E42695B-0F68-4dd0-862D-A6F32244DDFA}";
  public const string CanViewAdditionalInterestForm = "{76752242-B0DF-4316-959F-C171E26359A1}";
  public const string CanClearAdditionalInterestOFACDate = "{7D2C4C5C-F51B-4B4A-AB4F-F537208BEDBF}";
  private readonly Quote _quote;
  private bool? _usingNetRate;
  private int? _deleteInterestID;
  private bool _allowAddingAdditionalInterest;
  private readonly bool _isEndorsement;
  private bool _autoLineRatedWithNetRate;
  private readonly HashSet<int> _currentLocations;
  private readonly HashSet<int> _currentVehicles;
  private readonly Dictionary<Guid, OfacSystem.OfacStatus> _ofacData;
  private readonly HashSet<string> _ofacAITypes;
  private readonly Lazy<bool> _CheckNewVehiclesAndLocations;
  private readonly Lazy<bool> _filterVehicleByLocation;
  private readonly Lazy<bool> _runOfacOnAdditionalInterest;
  private readonly Lazy<bool> _skipOfacOnNewInterest;
  private readonly Lazy<bool> _skipOfacOnModifiedInterest;
  private readonly Lazy<bool> _runOfacViaCheckBox;
  private readonly Lazy<bool> _viewOfacTAB;
  private DbDataAdapter _daQuoteLocations;
  private DbDataAdapter _daQuoteNetRateLocations;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual UltraGrid ugInterests
  {
    get => this._ugInterests;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugInterests_AfterRowActivate);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ugInterests_InitializeRow);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ugInterests_MouseDown);
      UltraGrid ugInterests1 = this._ugInterests;
      if (ugInterests1 != null)
      {
        ugInterests1.AfterRowActivate -= eventHandler;
        ugInterests1.InitializeRow -= initializeRowEventHandler;
        ((Control) ugInterests1).MouseDown -= mouseEventHandler;
      }
      this._ugInterests = value;
      UltraGrid ugInterests2 = this._ugInterests;
      if (ugInterests2 == null)
        return;
      ugInterests2.AfterRowActivate += eventHandler;
      ugInterests2.InitializeRow += initializeRowEventHandler;
      ((Control) ugInterests2).MouseDown += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("dsAdditionalInterests")]
  protected virtual dsAdditionalInterests dsAdditionalInterests { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPhone")]
  protected virtual MGAMaskedEdit txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraMaskedEdit1")]
  protected virtual MGAMaskedEdit UltraMaskedEdit1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckedListBox lstInterestTypes
  {
    get => this._lstInterestTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstInterestTypes_ItemCheck);
      MGACheckedListBox lstInterestTypes1 = this._lstInterestTypes;
      if (lstInterestTypes1 != null)
        ((CheckedListBox) lstInterestTypes1).ItemCheck -= checkEventHandler;
      this._lstInterestTypes = value;
      MGACheckedListBox lstInterestTypes2 = this._lstInterestTypes;
      if (lstInterestTypes2 == null)
        return;
      ((CheckedListBox) lstInterestTypes2).ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("lstUnderwritingLocations")]
  protected virtual MGACheckedListBox lstUnderwritingLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkLocations
  {
    get => this._lnkLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLocations_LinkClicked);
      LinkLabel lnkLocations1 = this._lnkLocations;
      if (lnkLocations1 != null)
        lnkLocations1.LinkClicked -= clickedEventHandler;
      this._lnkLocations = value;
      LinkLabel lnkLocations2 = this._lnkLocations;
      if (lnkLocations2 == null)
        return;
      lnkLocations2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCof
  {
    get => this._lnkCof;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCof_LinkClicked);
      LinkLabel lnkCof1 = this._lnkCof;
      if (lnkCof1 != null)
        lnkCof1.LinkClicked -= clickedEventHandler;
      this._lnkCof = value;
      LinkLabel lnkCof2 = this._lnkCof;
      if (lnkCof2 == null)
        return;
      lnkCof2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDescription")]
  protected virtual MGATextBox txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker1")]
  protected virtual MGADateTimePicker MgaDateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkSelectAll
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

  protected virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.ClickingEdit -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.ClickingEdit += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("cboLines")]
  protected virtual MGASimpleComboBox cboLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ToolStripMenuItem cnMarkAsNew
  {
    get => this._cnMarkAsNew;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cnMarkAsNew_Click);
      ToolStripMenuItem cnMarkAsNew1 = this._cnMarkAsNew;
      if (cnMarkAsNew1 != null)
        cnMarkAsNew1.Click -= eventHandler;
      this._cnMarkAsNew = value;
      ToolStripMenuItem cnMarkAsNew2 = this._cnMarkAsNew;
      if (cnMarkAsNew2 == null)
        return;
      cnMarkAsNew2.Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkVehiclesDeSelectAll
  {
    get => this._lnkVehiclesDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkVehiclesDeSelectAll_LinkClicked);
      LinkLabel vehiclesDeSelectAll1 = this._lnkVehiclesDeSelectAll;
      if (vehiclesDeSelectAll1 != null)
        vehiclesDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkVehiclesDeSelectAll = value;
      LinkLabel vehiclesDeSelectAll2 = this._lnkVehiclesDeSelectAll;
      if (vehiclesDeSelectAll2 == null)
        return;
      vehiclesDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkVehiclesSelectAll
  {
    get => this._lnkVehiclesSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkVehiclesSelectAll_LinkClicked);
      LinkLabel vehiclesSelectAll1 = this._lnkVehiclesSelectAll;
      if (vehiclesSelectAll1 != null)
        vehiclesSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkVehiclesSelectAll = value;
      LinkLabel vehiclesSelectAll2 = this._lnkVehiclesSelectAll;
      if (vehiclesSelectAll2 == null)
        return;
      vehiclesSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkMailCertificate
  {
    get => this._lnkMailCertificate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkMailCertificate_LinkClicked);
      LinkLabel lnkMailCertificate1 = this._lnkMailCertificate;
      if (lnkMailCertificate1 != null)
        lnkMailCertificate1.LinkClicked -= clickedEventHandler;
      this._lnkMailCertificate = value;
      LinkLabel lnkMailCertificate2 = this._lnkMailCertificate;
      if (lnkMailCertificate2 == null)
        return;
      lnkMailCertificate2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ZipCodeResolver1")]
  protected virtual MGA_ZipCodeResolver ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numAmount")]
  protected virtual MGANumericEditor numAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel linkTemplateDocuments
  {
    get => this._linkTemplateDocuments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkTemplateDocuments_LinkClicked);
      LinkLabel templateDocuments1 = this._linkTemplateDocuments;
      if (templateDocuments1 != null)
        templateDocuments1.LinkClicked -= clickedEventHandler;
      this._linkTemplateDocuments = value;
      LinkLabel templateDocuments2 = this._linkTemplateDocuments;
      if (templateDocuments2 == null)
        return;
      templateDocuments2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGASimpleComboBox cboInterestType
  {
    get => this._cboInterestType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboInterestType_ValueChanged);
      MGASimpleComboBox cboInterestType1 = this._cboInterestType;
      if (cboInterestType1 != null)
        ((UltraCombo) cboInterestType1).ValueChanged -= eventHandler;
      this._cboInterestType = value;
      MGASimpleComboBox cboInterestType2 = this._cboInterestType;
      if (cboInterestType2 == null)
        return;
      ((UltraCombo) cboInterestType2).ValueChanged += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem cnCopy
  {
    get => this._cnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cnCopy_Click);
      ToolStripMenuItem cnCopy1 = this._cnCopy;
      if (cnCopy1 != null)
        cnCopy1.Click -= eventHandler;
      this._cnCopy = value;
      ToolStripMenuItem cnCopy2 = this._cnCopy;
      if (cnCopy2 == null)
        return;
      cnCopy2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboSalutations")]
  private virtual MGASimpleComboBox cboSalutations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLast")]
  private virtual MGATextBox txtLast { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMiddle")]
  private virtual MGATextBox txtMiddle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFirst")]
  private virtual MGATextBox txtFirst { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkUseName
  {
    get => this._lnkUseName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUseName_LinkClicked);
      LinkLabel lnkUseName1 = this._lnkUseName;
      if (lnkUseName1 != null)
        lnkUseName1.LinkClicked -= clickedEventHandler;
      this._lnkUseName = value;
      LinkLabel lnkUseName2 = this._lnkUseName;
      if (lnkUseName2 == null)
        return;
      lnkUseName2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dtDateOfBirth")]
  protected virtual MGADateTimePicker dtDateOfBirth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkSelectAllCopy
  {
    get => this._lnkSelectAllCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllCopy_LinkClicked);
      LinkLabel lnkSelectAllCopy1 = this._lnkSelectAllCopy;
      if (lnkSelectAllCopy1 != null)
        lnkSelectAllCopy1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllCopy = value;
      LinkLabel lnkSelectAllCopy2 = this._lnkSelectAllCopy;
      if (lnkSelectAllCopy2 == null)
        return;
      lnkSelectAllCopy2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkDeselectAllCopy
  {
    get => this._lnkDeselectAllCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectAllCopy_LinkClicked);
      LinkLabel lnkDeselectAllCopy1 = this._lnkDeselectAllCopy;
      if (lnkDeselectAllCopy1 != null)
        lnkDeselectAllCopy1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectAllCopy = value;
      LinkLabel lnkDeselectAllCopy2 = this._lnkDeselectAllCopy;
      if (lnkDeselectAllCopy2 == null)
        return;
      lnkDeselectAllCopy2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCopyAll
  {
    get => this._lnkCopyAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyAll_LinkClicked);
      LinkLabel lnkCopyAll1 = this._lnkCopyAll;
      if (lnkCopyAll1 != null)
        lnkCopyAll1.LinkClicked -= clickedEventHandler;
      this._lnkCopyAll = value;
      LinkLabel lnkCopyAll2 = this._lnkCopyAll;
      if (lnkCopyAll2 == null)
        return;
      lnkCopyAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("checkBillable")]
  protected virtual MGACheckBox checkBillable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTxtEmail")]
  private virtual MGATextBox MgaTxtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaMobile")]
  protected virtual MGAMaskedEdit MgaMobile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnComplianceCheck")]
  protected virtual Button btnComplianceCheck { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtVINSearch")]
  private virtual MGATextBox txtVINSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblSearchResult")]
  internal virtual Label lblSearchResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRunOFAC")]
  protected virtual MGACheckBox chkRunOFAC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("utpcOFACResults")]
  protected virtual UltraTabPageControl utpcOFACResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugOFACResults")]
  protected virtual UltraGrid ugOFACResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraDataSource1")]
  internal virtual UltraDataSource UltraDataSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraDataSource2")]
  internal virtual UltraDataSource UltraDataSource2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOFACNotice")]
  internal virtual Label lblOFACNotice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDescriptionLabel")]
  protected virtual Label lblDescriptionLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
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
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdditionalInterests));
    Appearance appearance34 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblQuoteAdditionalInterests", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AdditionalInterestGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InterestName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Region");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Interest");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("DescriptionText");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("IssuanceDate");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("FEIN");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LineID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Billable");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("BillableAmount");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("AdditionalInterestTypeID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Salutation");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("MiddleName");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("DateOfBirth");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("CopyInterest");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Mobile");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("OfacCleared");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("GenerateDoc");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes", 0);
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("AdditionalInterestID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("AdditionalInterestType");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations", 0);
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("AdditionalInterestID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("UnderwritingLocationID");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations", 0);
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("AdditionalInterestID");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("NetRateLocationID");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("NetRateBuildingNumber");
    UltraGridBand ultraGridBand5 = new UltraGridBand("FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles", 0);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("AdditionalInterestID");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("VehicleID");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance43 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance44 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance45 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance46 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance47 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance48 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    UltraDataBand ultraDataBand1 = new UltraDataBand("tblQuoteAdditionalIntereststblQuoteAdditionalInterestTypes");
    UltraDataColumn ultraDataColumn1 = new UltraDataColumn("AdditionalInterestID");
    UltraDataColumn ultraDataColumn2 = new UltraDataColumn("AdditionalInterestType");
    UltraDataBand ultraDataBand2 = new UltraDataBand("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsLocations");
    UltraDataColumn ultraDataColumn3 = new UltraDataColumn("AdditionalInterestID");
    UltraDataColumn ultraDataColumn4 = new UltraDataColumn("UnderwritingLocationID");
    UltraDataBand ultraDataBand3 = new UltraDataBand("tblQuoteAdditionalIntereststblQuoteAdditionalInterestsNetRateLocations");
    UltraDataColumn ultraDataColumn5 = new UltraDataColumn("AdditionalInterestID");
    UltraDataColumn ultraDataColumn6 = new UltraDataColumn("NetRateLocationID");
    UltraDataColumn ultraDataColumn7 = new UltraDataColumn("NetRateBuildingNumber");
    UltraDataBand ultraDataBand4 = new UltraDataBand("FK_tblQuoteAdditionalInterests_tblQuoteAdditionalInterestsNetRateVehicles");
    UltraDataColumn ultraDataColumn8 = new UltraDataColumn("AdditionalInterestID");
    UltraDataColumn ultraDataColumn9 = new UltraDataColumn("VehicleID");
    UltraDataColumn ultraDataColumn10 = new UltraDataColumn("ID");
    UltraDataColumn ultraDataColumn11 = new UltraDataColumn("AdditionalInterestGuid");
    UltraDataColumn ultraDataColumn12 = new UltraDataColumn("QuoteID");
    UltraDataColumn ultraDataColumn13 = new UltraDataColumn("InterestName");
    UltraDataColumn ultraDataColumn14 = new UltraDataColumn("Address1");
    UltraDataColumn ultraDataColumn15 = new UltraDataColumn("Address2");
    UltraDataColumn ultraDataColumn16 = new UltraDataColumn("City");
    UltraDataColumn ultraDataColumn17 = new UltraDataColumn("County");
    UltraDataColumn ultraDataColumn18 = new UltraDataColumn("StateID");
    UltraDataColumn ultraDataColumn19 = new UltraDataColumn("Region");
    UltraDataColumn ultraDataColumn20 = new UltraDataColumn("ISOCountryCode");
    UltraDataColumn ultraDataColumn21 = new UltraDataColumn("ZipCode");
    UltraDataColumn ultraDataColumn22 = new UltraDataColumn("ZipPlus");
    UltraDataColumn ultraDataColumn23 = new UltraDataColumn("Phone");
    UltraDataColumn ultraDataColumn24 = new UltraDataColumn("Fax");
    UltraDataColumn ultraDataColumn25 = new UltraDataColumn("ModificationCode");
    UltraDataColumn ultraDataColumn26 = new UltraDataColumn("Interest");
    UltraDataColumn ultraDataColumn27 = new UltraDataColumn("DescriptionText");
    UltraDataColumn ultraDataColumn28 = new UltraDataColumn("IssuanceDate");
    UltraDataColumn ultraDataColumn29 = new UltraDataColumn("FEIN");
    UltraDataColumn ultraDataColumn30 = new UltraDataColumn("LineID");
    UltraDataColumn ultraDataColumn31 = new UltraDataColumn("Billable");
    UltraDataColumn ultraDataColumn32 = new UltraDataColumn("BillableAmount");
    UltraDataColumn ultraDataColumn33 = new UltraDataColumn("AdditionalInterestTypeID");
    UltraDataColumn ultraDataColumn34 = new UltraDataColumn("Salutation");
    UltraDataColumn ultraDataColumn35 = new UltraDataColumn("FirstName");
    UltraDataColumn ultraDataColumn36 = new UltraDataColumn("MiddleName");
    UltraDataColumn ultraDataColumn37 = new UltraDataColumn("LastName");
    UltraDataColumn ultraDataColumn38 = new UltraDataColumn("DateOfBirth");
    UltraDataColumn ultraDataColumn39 = new UltraDataColumn("CopyInterest");
    UltraDataColumn ultraDataColumn40 = new UltraDataColumn("Mobile");
    UltraDataColumn ultraDataColumn41 = new UltraDataColumn("Email");
    UltraDataColumn ultraDataColumn42 = new UltraDataColumn("OfacCleared");
    UltraDataColumn ultraDataColumn43 = new UltraDataColumn("GenerateDoc");
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.chkRunOFAC = new MGACheckBox();
    this.btnComplianceCheck = new Button();
    this.lblOfacClear = new Label();
    this.dtOfacCleared = new MGADateTimePicker();
    this.lblSearchDate = new Label();
    this.dtOfacSearched = new MGADateTimePicker();
    this.MgaTxtEmail = new MGATextBox();
    this.dsAdditionalInterests = new dsAdditionalInterests();
    this.MgaMobile = new MGAMaskedEdit();
    this.lnkSelectAllCopy = new LinkLabel();
    this.lnkDeselectAllCopy = new LinkLabel();
    this.lnkCopyAll = new LinkLabel();
    this.dtDateOfBirth = new MGADateTimePicker();
    this.lnkUseName = new LinkLabel();
    this.cboSalutations = new MGASimpleComboBox();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.txtLast = new MGATextBox();
    this.txtMiddle = new MGATextBox();
    this.txtFirst = new MGATextBox();
    this.Label11 = new Label();
    this.cboInterestType = new MGASimpleComboBox();
    this.numAmount = new MGANumericEditor();
    this.checkBillable = new MGACheckBox();
    this.cboLines = new MGASimpleComboBox();
    this.txtFEIN = new MGAMaskedEdit();
    this.lstInterestTypes = new MGACheckedListBox();
    this.ZipCodeResolver1 = new MGA_ZipCodeResolver();
    this.txtInsuredName = new MGATextBox();
    this.txtPhone = new MGAMaskedEdit();
    this.UltraMaskedEdit1 = new MGAMaskedEdit();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.lnkDeSelectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.lnkLocations = new LinkLabel();
    this.lstUnderwritingLocations = new MGACheckedListBox();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.Panel1 = new Panel();
    this.lblSearchResult = new Label();
    this.btnSearch = new MGAButton();
    this.txtVINSearch = new MGATextBox();
    this.Label4 = new Label();
    this.lnkVehiclesDeSelectAll = new LinkLabel();
    this.lnkVehiclesSelectAll = new LinkLabel();
    this.lstVehicles = new CheckedListBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.linkTemplateDocuments = new LinkLabel();
    this.lnkMailCertificate = new LinkLabel();
    this.MgaDateTimePicker1 = new MGADateTimePicker();
    this.txtDescription = new MGATextBox();
    this.lblDescriptionLabel = new Label();
    this.lnkCof = new LinkLabel();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.TextBox1 = new MGATextBox();
    this.utpcOFACResults = new UltraTabPageControl();
    this.lblOFACNotice = new Label();
    this.ugOFACResults = new UltraGrid();
    this.cntMenu = new ContextMenuStrip(this.components);
    this.cnMarkAsNew = new ToolStripMenuItem();
    this.cnCopy = new ToolStripMenuItem();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ugInterests = new UltraGrid();
    this.daInterests = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this._cnDB = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.err = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this._daUnderwritingLocations = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand4 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand4 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand4 = DefaultDatabase.CreateCommand();
    this.daQuoteInterestTypes = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand2 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand2 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand4 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand2 = DefaultDatabase.CreateCommand();
    this._daQuoteLocations = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand3 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand3 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand5 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand3 = DefaultDatabase.CreateCommand();
    this.aiTip = new ToolTip(this.components);
    this._daNetRateLocations = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this._daQuoteNetRateLocations = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand5 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand5 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand6 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand5 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand8 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand6 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand6 = DefaultDatabase.CreateCommand();
    this.DbDeleteCommand6 = DefaultDatabase.CreateCommand();
    this.daQuoteNetRateVehicles = DefaultDatabase.CreateDataAdapter();
    this.UltraDataSource1 = new UltraDataSource(this.components);
    this.UltraDataSource2 = new UltraDataSource(this.components);
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    Label label8 = new Label();
    Label label9 = new Label();
    Label label10 = new Label();
    Label label11 = new Label();
    Label label12 = new Label();
    Label label13 = new Label();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.chkRunOFAC).BeginInit();
    ((ISupportInitialize) this.dtOfacCleared).BeginInit();
    ((ISupportInitialize) this.dtOfacSearched).BeginInit();
    ((ISupportInitialize) this.MgaTxtEmail).BeginInit();
    this.dsAdditionalInterests.BeginInit();
    ((ISupportInitialize) this.MgaMobile).BeginInit();
    ((ISupportInitialize) this.dtDateOfBirth).BeginInit();
    ((ISupportInitialize) this.cboSalutations).BeginInit();
    ((ISupportInitialize) this.txtLast).BeginInit();
    ((ISupportInitialize) this.txtMiddle).BeginInit();
    ((ISupportInitialize) this.txtFirst).BeginInit();
    ((ISupportInitialize) this.cboInterestType).BeginInit();
    ((ISupportInitialize) this.numAmount).BeginInit();
    ((ISupportInitialize) this.checkBillable).BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.lstInterestTypes).BeginInit();
    ((ISupportInitialize) this.txtInsuredName).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.UltraMaskedEdit1).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.lstUnderwritingLocations).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.txtVINSearch).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.MgaDateTimePicker1).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((Control) this.utpcOFACResults).SuspendLayout();
    ((ISupportInitialize) this.ugOFACResults).BeginInit();
    this.cntMenu.SuspendLayout();
    ((ISupportInitialize) this.ugInterests).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.UltraDataSource1).BeginInit();
    ((ISupportInitialize) this.UltraDataSource2).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.ForeColor = Color.Black;
    label1.Location = new Point(351, 166);
    label1.Name = "Label8";
    label1.Size = new Size(30, 13);
    label1.TabIndex = 14;
    label1.Text = "Line:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.ForeColor = Color.Black;
    label2.Location = new Point(52, 192 /*0xC0*/);
    label2.Name = "Label6";
    label2.Size = new Size(34, 13);
    label2.TabIndex = 11;
    label2.Text = "FEIN:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.ForeColor = Color.Black;
    label3.Location = new Point(6, 112 /*0x70*/);
    label3.Name = "Label1";
    label3.Size = new Size(80 /*0x50*/, 13);
    label3.TabIndex = 0;
    label3.Text = "Interest Name:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.ForeColor = Color.Black;
    label4.Location = new Point(341, 61);
    label4.Name = "lblPhone";
    label4.Size = new Size(41, 13);
    label4.TabIndex = 3;
    label4.Text = "Phone:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.ForeColor = Color.Black;
    label5.Location = new Point(353, 139);
    label5.Name = "Label3";
    label5.Size = new Size(29, 13);
    label5.TabIndex = 5;
    label5.Text = "Fax:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(79, 307);
    label6.Name = "Label7";
    label6.Size = new Size(11, 13);
    label6.TabIndex = 11;
    label6.Text = "/";
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(76, 319);
    label7.Name = "Label2";
    label7.Size = new Size(11, 13);
    label7.TabIndex = 14;
    label7.Text = "/";
    label8.AutoSize = true;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(306, 20);
    label8.Name = "Label5";
    label8.Size = new Size(65, 13);
    label8.TabIndex = 12;
    label8.Text = "Date Issued";
    label8.TextAlign = ContentAlignment.MiddleRight;
    label9.AutoSize = true;
    label9.BackColor = Color.Transparent;
    label9.ForeColor = Color.Black;
    label9.Location = new Point(334, 37);
    label9.Name = "Label9";
    label9.Size = new Size(48 /*0x30*/, 13);
    label9.TabIndex = 17;
    label9.Text = "Amount:";
    label9.TextAlign = ContentAlignment.MiddleRight;
    label10.AutoSize = true;
    label10.BackColor = Color.Transparent;
    label10.ForeColor = Color.Black;
    label10.Location = new Point(4, 11);
    label10.Name = "Label10";
    label10.Size = new Size(82, 13);
    label10.TabIndex = 19;
    label10.Text = "Select Interest:";
    label10.TextAlign = ContentAlignment.MiddleRight;
    label11.AutoSize = true;
    label11.BackColor = Color.Transparent;
    label11.ForeColor = Color.Black;
    label11.Location = new Point(4, 82);
    label11.Name = "Label14";
    label11.Size = new Size(72, 13);
    label11.TabIndex = 180;
    label11.Text = "Date of Birth:";
    label11.TextAlign = ContentAlignment.MiddleRight;
    label12.AutoSize = true;
    label12.BackColor = Color.Transparent;
    label12.ForeColor = Color.Black;
    label12.Location = new Point(346, 113);
    label12.Name = "lblEmail";
    label12.Size = new Size(35, 13);
    label12.TabIndex = 187;
    label12.Text = "Email:";
    label12.TextAlign = ContentAlignment.MiddleRight;
    label13.AutoSize = true;
    label13.BackColor = Color.Transparent;
    label13.ForeColor = Color.Black;
    label13.Location = new Point(341, 87);
    label13.Name = "lblmobile";
    label13.Size = new Size(41, 13);
    label13.TabIndex = 185;
    label13.Text = "Mobile:";
    label13.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkRunOFAC);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnComplianceCheck);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblOfacClear);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtOfacCleared);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblSearchDate);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtOfacSearched);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTxtEmail);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label12);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaMobile);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label13);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkSelectAllCopy);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkDeselectAllCopy);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkCopyAll);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtDateOfBirth);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkUseName);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboSalutations);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtLast);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtMiddle);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFirst);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboInterestType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.numAmount);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.checkBillable);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboLines);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFEIN);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lstInterestTypes);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ZipCodeResolver1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtInsuredName);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UltraMaskedEdit1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label5);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(756, 390);
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRunOFAC).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkRunOFAC).AutoSize = true;
    ((UltraToggleEditorBase) this.chkRunOFAC).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRunOFAC).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRunOFAC).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRunOFAC).Location = new Point(644, 7);
    ((Control) this.chkRunOFAC).Name = "chkRunOFAC";
    ((Control) this.chkRunOFAC).Size = new Size(112 /*0x70*/, 18);
    ((Control) this.chkRunOFAC).TabIndex = 192 /*0xC0*/;
    ((UltraToggleEditorBase) this.chkRunOFAC).Text = "Run OFAC Check";
    ((Control) this.chkRunOFAC).Visible = false;
    this.btnComplianceCheck.BackColor = Color.WhiteSmoke;
    this.btnComplianceCheck.Location = new Point(569, 4);
    this.btnComplianceCheck.Name = "btnComplianceCheck";
    this.btnComplianceCheck.Size = new Size(69, 21);
    this.btnComplianceCheck.TabIndex = 191;
    this.btnComplianceCheck.Text = "NOT USED";
    this.btnComplianceCheck.TextAlign = ContentAlignment.MiddleLeft;
    this.btnComplianceCheck.UseVisualStyleBackColor = false;
    this.btnComplianceCheck.Visible = false;
    this.lblOfacClear.AutoSize = true;
    this.lblOfacClear.BackColor = Color.Transparent;
    this.lblOfacClear.ForeColor = Color.Black;
    this.lblOfacClear.Location = new Point(590, 57);
    this.lblOfacClear.Name = "lblOfacClear";
    this.lblOfacClear.Size = new Size(62, 13);
    this.lblOfacClear.TabIndex = 196;
    this.lblOfacClear.Text = "Clear Date:";
    this.lblOfacClear.TextAlign = ContentAlignment.MiddleRight;
    this.lblOfacClear.Visible = false;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtOfacCleared).Appearance = (AppearanceBase) appearance2;
    appearance3.AlphaLevel = (short) 14;
    appearance3.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance3.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance3.BackColorAlpha = (Alpha) 2;
    appearance3.BackGradientAlignment = (GradientAlignment) 4;
    appearance3.BackGradientStyle = (GradientStyle) 5;
    appearance3.BorderAlpha = (Alpha) 1;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    appearance3.ForeColor = Color.FromArgb(49, 85, 153);
    appearance3.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtOfacCleared).ButtonAppearance = (AppearanceBase) appearance3;
    ((UltraDateTimeEditor) this.dtOfacCleared).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtOfacCleared).Location = new Point(658, 54);
    this.dtOfacCleared.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtOfacCleared).Name = "dtOfacCleared";
    ((Control) this.dtOfacCleared).Size = new Size(89, 20);
    ((Control) this.dtOfacCleared).TabIndex = 194;
    ((UltraControlBase) this.dtOfacCleared).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtOfacCleared).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtOfacCleared).Value = (object) null;
    ((Control) this.dtOfacCleared).Visible = false;
    this.lblSearchDate.AutoSize = true;
    this.lblSearchDate.BackColor = Color.Transparent;
    this.lblSearchDate.ForeColor = Color.Black;
    this.lblSearchDate.Location = new Point(587, 31 /*0x1F*/);
    this.lblSearchDate.Name = "lblSearchDate";
    this.lblSearchDate.Size = new Size(65, 13);
    this.lblSearchDate.TabIndex = 195;
    this.lblSearchDate.Text = "OFAC Date:";
    this.lblSearchDate.TextAlign = ContentAlignment.MiddleRight;
    this.lblSearchDate.Visible = false;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtOfacSearched).Appearance = (AppearanceBase) appearance4;
    appearance5.AlphaLevel = (short) 14;
    appearance5.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance5.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance5.BackColorAlpha = (Alpha) 2;
    appearance5.BackGradientAlignment = (GradientAlignment) 4;
    appearance5.BackGradientStyle = (GradientStyle) 5;
    appearance5.BorderAlpha = (Alpha) 1;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    appearance5.ForeColor = Color.FromArgb(49, 85, 153);
    appearance5.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtOfacSearched).ButtonAppearance = (AppearanceBase) appearance5;
    ((UltraDateTimeEditor) this.dtOfacSearched).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((UltraDateTimeEditor) this.dtOfacSearched).DropDownButtonDisplayStyle = (ButtonDisplayStyle) 0;
    ((Control) this.dtOfacSearched).Location = new Point(658, 28);
    this.dtOfacSearched.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtOfacSearched).Name = "dtOfacSearched";
    ((EditorButtonControlBase) this.dtOfacSearched).ReadOnly = true;
    ((Control) this.dtOfacSearched).Size = new Size(89, 20);
    ((Control) this.dtOfacSearched).TabIndex = 193;
    ((UltraControlBase) this.dtOfacSearched).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtOfacSearched).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtOfacSearched).Value = (object) null;
    ((Control) this.dtOfacSearched).Visible = false;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTxtEmail).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.MgaTxtEmail).BackColor = Color.White;
    ((Control) this.MgaTxtEmail).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Email", true));
    ((Control) this.MgaTxtEmail).Enabled = false;
    ((Control) this.MgaTxtEmail).Location = new Point(388, 106);
    ((TextEditorControlBase) this.MgaTxtEmail).MaxLength = 75;
    this.MgaTxtEmail.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTxtEmail).Name = "MgaTxtEmail";
    ((Control) this.MgaTxtEmail).Size = new Size(219, 20);
    ((Control) this.MgaTxtEmail).TabIndex = 188;
    ((UltraControlBase) this.MgaTxtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTxtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.dsAdditionalInterests.DataSetName = "dsAdditionalInterests";
    this.dsAdditionalInterests.Locale = new CultureInfo("en-US");
    this.dsAdditionalInterests.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraMaskedEdit) this.MgaMobile).Appearance = (AppearanceBase) appearance7;
    ((Control) this.MgaMobile).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Mobile", true));
    ((UltraMaskedEdit) this.MgaMobile).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.MgaMobile).InputMask = "###-###-####";
    ((Control) this.MgaMobile).Location = new Point(388, 80 /*0x50*/);
    this.MgaMobile.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaMobile).Name = "MgaMobile";
    ((UltraMaskedEdit) this.MgaMobile).NonAutoSizeHeight = 20;
    ((Control) this.MgaMobile).Size = new Size(88, 20);
    ((Control) this.MgaMobile).TabIndex = 186;
    ((UltraMaskedEdit) this.MgaMobile).Text = "() -";
    ((UltraControlBase) this.MgaMobile).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaMobile).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSelectAllCopy.AutoSize = true;
    this.lnkSelectAllCopy.BackColor = Color.Transparent;
    this.lnkSelectAllCopy.Location = new Point(611, 142);
    this.lnkSelectAllCopy.Name = "lnkSelectAllCopy";
    this.lnkSelectAllCopy.Size = new Size(90, 13);
    this.lnkSelectAllCopy.TabIndex = 184;
    this.lnkSelectAllCopy.TabStop = true;
    this.lnkSelectAllCopy.Text = "Select all to Copy";
    this.lnkSelectAllCopy.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkDeselectAllCopy.AutoSize = true;
    this.lnkDeselectAllCopy.BackColor = Color.Transparent;
    this.lnkDeselectAllCopy.Location = new Point(611, 170);
    this.lnkDeselectAllCopy.Name = "lnkDeselectAllCopy";
    this.lnkDeselectAllCopy.Size = new Size(67, 13);
    this.lnkDeselectAllCopy.TabIndex = 183;
    this.lnkDeselectAllCopy.TabStop = true;
    this.lnkDeselectAllCopy.Text = "De-Select All";
    this.lnkDeselectAllCopy.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkCopyAll.AutoSize = true;
    this.lnkCopyAll.BackColor = Color.Transparent;
    this.lnkCopyAll.Location = new Point(611, 196);
    this.lnkCopyAll.Name = "lnkCopyAll";
    this.lnkCopyAll.Size = new Size(79, 13);
    this.lnkCopyAll.TabIndex = 182;
    this.lnkCopyAll.TabStop = true;
    this.lnkCopyAll.Text = "Copy Interests";
    this.lnkCopyAll.TextAlign = ContentAlignment.MiddleLeft;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtDateOfBirth).Appearance = (AppearanceBase) appearance8;
    appearance9.AlphaLevel = (short) 14;
    appearance9.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance9.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance9.BackColorAlpha = (Alpha) 2;
    appearance9.BackGradientAlignment = (GradientAlignment) 4;
    appearance9.BackGradientStyle = (GradientStyle) 5;
    appearance9.BorderAlpha = (Alpha) 1;
    appearance9.BorderColor = Color.FromArgb(78, 122, 171);
    appearance9.ForeColor = Color.FromArgb(49, 85, 153);
    appearance9.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtDateOfBirth).ButtonAppearance = (AppearanceBase) appearance9;
    ((Control) this.dtDateOfBirth).DataBindings.Add(new Binding("Value", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.DateOfBirth", true));
    ((UltraDateTimeEditor) this.dtDateOfBirth).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((UltraDateTimeEditor) this.dtDateOfBirth).FormatString = "D";
    ((Control) this.dtDateOfBirth).Location = new Point(92, 78);
    this.dtDateOfBirth.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtDateOfBirth).Name = "dtDateOfBirth";
    ((Control) this.dtDateOfBirth).Size = new Size(222, 20);
    ((Control) this.dtDateOfBirth).TabIndex = 181;
    ((UltraControlBase) this.dtDateOfBirth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDateOfBirth).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtDateOfBirth).Value = (object) null;
    this.lnkUseName.AutoSize = true;
    this.lnkUseName.BackColor = Color.Transparent;
    this.lnkUseName.Location = new Point(92, 112 /*0x70*/);
    this.lnkUseName.Name = "lnkUseName";
    this.lnkUseName.Size = new Size(172, 13);
    this.lnkUseName.TabIndex = 179;
    this.lnkUseName.TabStop = true;
    this.lnkUseName.Text = "(Use First, Middle and Last names)";
    this.lnkUseName.TextAlign = ContentAlignment.MiddleLeft;
    ((UltraCombo) this.cboSalutations).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSalutations).DataBindings.Add(new Binding("Value", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Salutation", true));
    ((UltraGridBase) this.cboSalutations).DataMember = "lstSalutations";
    ((UltraGridBase) this.cboSalutations).DataSource = (object) this.dsAdditionalInterests;
    ((UltraDropDownBase) this.cboSalutations).DisplayMember = "Salutation";
    ((UltraCombo) this.cboSalutations).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboSalutations).Enabled = false;
    ((Control) this.cboSalutations).Location = new Point(52, 54);
    this.cboSalutations.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboSalutations).Name = "cboSalutations";
    ((Control) this.cboSalutations).Size = new Size(42, 21);
    ((Control) this.cboSalutations).TabIndex = 172;
    ((UltraControlBase) this.cboSalutations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSalutations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSalutations).ValueMember = "Salutation";
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(232, 32 /*0x20*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(42, 16 /*0x10*/);
    this.Label13.TabIndex = 178;
    this.Label13.Text = "Last";
    this.Label13.TextAlign = ContentAlignment.MiddleCenter;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(174, 32 /*0x20*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(42, 16 /*0x10*/);
    this.Label12.TabIndex = 177;
    this.Label12.Text = "Middle";
    this.Label12.TextAlign = ContentAlignment.MiddleCenter;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLast).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtLast).BackColor = Color.White;
    ((Control) this.txtLast).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.LastName", true));
    ((Control) this.txtLast).Enabled = false;
    ((Control) this.txtLast).Location = new Point(216, 54);
    this.txtLast.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLast).Name = "txtLast";
    ((Control) this.txtLast).Size = new Size(98, 20);
    ((Control) this.txtLast).TabIndex = 176 /*0xB0*/;
    ((UltraControlBase) this.txtLast).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLast).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMiddle).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtMiddle).BackColor = Color.White;
    ((Control) this.txtMiddle).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.MiddleName", true));
    ((Control) this.txtMiddle).Enabled = false;
    ((Control) this.txtMiddle).Location = new Point(168, 54);
    ((TextEditorControlBase) this.txtMiddle).MaxLength = 50;
    this.txtMiddle.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtMiddle).Name = "txtMiddle";
    ((Control) this.txtMiddle).Size = new Size(49, 20);
    ((Control) this.txtMiddle).TabIndex = 174;
    ((UltraControlBase) this.txtMiddle).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMiddle).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirst).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtFirst).BackColor = Color.White;
    ((Control) this.txtFirst).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.FirstName", true));
    ((Control) this.txtFirst).Enabled = false;
    ((Control) this.txtFirst).Location = new Point(94, 54);
    this.txtFirst.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFirst).Name = "txtFirst";
    ((Control) this.txtFirst).Size = new Size(76, 20);
    ((Control) this.txtFirst).TabIndex = 173;
    ((UltraControlBase) this.txtFirst).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirst).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(108, 32 /*0x20*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(42, 16 /*0x10*/);
    this.Label11.TabIndex = 175;
    this.Label11.Text = "First";
    this.Label11.TextAlign = ContentAlignment.MiddleLeft;
    ((UltraCombo) this.cboInterestType).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInterestType).DataBindings.Add(new Binding("Value", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.AdditionalInterestTypeID", true));
    ((UltraGridBase) this.cboInterestType).DataMember = "tblAdditionalInterests";
    ((UltraGridBase) this.cboInterestType).DataSource = (object) this.dsAdditionalInterests;
    ((UltraDropDownBase) this.cboInterestType).DisplayMember = "Interest";
    ((UltraCombo) this.cboInterestType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInterestType).Location = new Point(92, 7);
    this.cboInterestType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInterestType).Name = "cboInterestType";
    ((Control) this.cboInterestType).Size = new Size(222, 21);
    ((Control) this.cboInterestType).TabIndex = 0;
    ((UltraControlBase) this.cboInterestType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInterestType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInterestType).ValueMember = "InterestID";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numAmount).Appearance = (AppearanceBase) appearance13;
    ((Control) this.numAmount).DataBindings.Add(new Binding("Value", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.BillableAmount", true));
    ((UltraNumericEditorBase) this.numAmount).FormatString = "c";
    ((Control) this.numAmount).Location = new Point(388, 30);
    this.numAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.numAmount).Name = "numAmount";
    ((UltraNumericEditor) this.numAmount).Nullable = true;
    ((Control) this.numAmount).Size = new Size(161, 20);
    ((Control) this.numAmount).TabIndex = 5;
    ((UltraControlBase) this.numAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numAmount).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.Gray;
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkBillable).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.checkBillable).AutoSize = true;
    ((UltraToggleEditorBase) this.checkBillable).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkBillable).BackColorInternal = Color.Transparent;
    ((Control) this.checkBillable).DataBindings.Add(new Binding("Checked", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Billable", true));
    ((UltraToggleEditorBase) this.checkBillable).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkBillable).Location = new Point(388, 7);
    ((Control) this.checkBillable).Name = "checkBillable";
    ((Control) this.checkBillable).Size = new Size(58, 18);
    ((Control) this.checkBillable).TabIndex = 4;
    ((UltraToggleEditorBase) this.checkBillable).Text = "Billable";
    ((UltraCombo) this.cboLines).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLines).DataBindings.Add(new Binding("Value", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.LineID", true));
    ((UltraGridBase) this.cboLines).DataMember = "lstLines";
    ((UltraGridBase) this.cboLines).DataSource = (object) this.dsAdditionalInterests;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    ((UltraCombo) this.cboLines).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLines).Location = new Point(388, 158);
    this.cboLines.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLines).Name = "cboLines";
    ((Control) this.cboLines).Size = new Size(210, 21);
    ((Control) this.cboLines).TabIndex = 8;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineID";
    appearance15.BackColorDisabled = Color.Gainsboro;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraMaskedEdit) this.txtFEIN).Appearance = (AppearanceBase) appearance15;
    ((Control) this.txtFEIN).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.FEIN", true));
    ((UltraMaskedEdit) this.txtFEIN).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtFEIN).InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(92, 189);
    this.txtFEIN.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    ((UltraMaskedEdit) this.txtFEIN).NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(72, 20);
    ((Control) this.txtFEIN).TabIndex = 2;
    ((UltraMaskedEdit) this.txtFEIN).Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    ((ListBox) this.lstInterestTypes).BackColor = Color.White;
    ((CheckedListBox) this.lstInterestTypes).CheckOnClick = true;
    ((ListBox) this.lstInterestTypes).ForeColor = Color.Black;
    ((Control) this.lstInterestTypes).Location = new Point(388, 191);
    this.lstInterestTypes.MGAStyle = (MGAStyles) 2;
    ((Control) this.lstInterestTypes).Name = "lstInterestTypes";
    ((Control) this.lstInterestTypes).Size = new Size(210, 184);
    ((Control) this.lstInterestTypes).TabIndex = 9;
    this.ZipCodeResolver1.AddressServiceURL = "";
    this.ZipCodeResolver1.AutoScrollMargin = new Size(0, 0);
    this.ZipCodeResolver1.AutoScrollMinSize = new Size(0, 0);
    this.ZipCodeResolver1.BackColor = Color.Transparent;
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.County = "";
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("City", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.City", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("County", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.County", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("GeoRegion", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Region", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.ISOCountryCode", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("State", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.StateID", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Street1", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Address1", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("Street2", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Address2", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ZipCode", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.ZipCode", true));
    ((Control) this.ZipCodeResolver1).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.ZipPlus", true));
    this.ZipCodeResolver1.GeoRegion = "";
    this.ZipCodeResolver1.ISOCountryCode = "";
    this.ZipCodeResolver1.ISOCountryCodeMember = "";
    this.ZipCodeResolver1.ISOCountryList = (object) null;
    this.ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.ZipCodeResolver1).Location = new Point(29, 215);
    this.ZipCodeResolver1.MGAStyle = (MGAStyles) 2;
    ((Control) this.ZipCodeResolver1).Name = "ZipCodeResolver1";
    this.ZipCodeResolver1.Password = "";
    this.ZipCodeResolver1.ShowGlobal = true;
    ((Control) this.ZipCodeResolver1).Size = new Size(234, 171);
    this.ZipCodeResolver1.State = "";
    this.ZipCodeResolver1.Street1 = "";
    this.ZipCodeResolver1.Street2 = "";
    ((Control) this.ZipCodeResolver1).TabIndex = 3;
    this.ZipCodeResolver1.UserID = "";
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    ((UltraTextEditor) this.txtInsuredName).AcceptsReturn = true;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsuredName).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtInsuredName).BackColor = Color.White;
    ((Control) this.txtInsuredName).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.InterestName", true));
    ((Control) this.txtInsuredName).Location = new Point(92, 131);
    ((TextEditorControlBase) this.txtInsuredName).MaxLength = 2000;
    this.txtInsuredName.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtInsuredName).Multiline = true;
    ((Control) this.txtInsuredName).Name = "txtInsuredName";
    ((UltraTextEditor) this.txtInsuredName).Scrollbars = ScrollBars.Vertical;
    ((Control) this.txtInsuredName).Size = new Size(222, 52);
    ((Control) this.txtInsuredName).TabIndex = 1;
    ((UltraControlBase) this.txtInsuredName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsuredName).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraMaskedEdit) this.txtPhone).Appearance = (AppearanceBase) appearance17;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Phone", true));
    ((UltraMaskedEdit) this.txtPhone).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.txtPhone).InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(388, 54);
    this.txtPhone.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPhone).Name = "txtPhone";
    ((UltraMaskedEdit) this.txtPhone).NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(88, 20);
    ((Control) this.txtPhone).TabIndex = 6;
    ((UltraMaskedEdit) this.txtPhone).Text = "() -";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((UltraMaskedEdit) this.UltraMaskedEdit1).Appearance = (AppearanceBase) appearance18;
    ((Control) this.UltraMaskedEdit1).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Fax", true));
    ((UltraMaskedEdit) this.UltraMaskedEdit1).EditAs = (EditAsType) 1;
    ((UltraMaskedEdit) this.UltraMaskedEdit1).InputMask = "###-###-####";
    ((Control) this.UltraMaskedEdit1).Location = new Point(388, 132);
    this.UltraMaskedEdit1.MGAStyle = (MGAStyles) 2;
    ((Control) this.UltraMaskedEdit1).Name = "UltraMaskedEdit1";
    ((UltraMaskedEdit) this.UltraMaskedEdit1).NonAutoSizeHeight = 20;
    ((Control) this.UltraMaskedEdit1).Size = new Size(88, 20);
    ((Control) this.UltraMaskedEdit1).TabIndex = 7;
    ((UltraMaskedEdit) this.UltraMaskedEdit1).Text = "() -";
    ((UltraControlBase) this.UltraMaskedEdit1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraMaskedEdit1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) label6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkDeSelectAll);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkSelectAll);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkLocations);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lstUnderwritingLocations);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(756, 390);
    this.lnkDeSelectAll.BackColor = Color.Transparent;
    this.lnkDeSelectAll.Location = new Point(95, 307);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lnkDeSelectAll.TabIndex = 10;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(23, 307);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.lnkSelectAll.TabIndex = 9;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkLocations.AutoSize = true;
    this.lnkLocations.BackColor = Color.Transparent;
    this.lnkLocations.Location = new Point(23, 335);
    this.lnkLocations.Name = "lnkLocations";
    this.lnkLocations.Size = new Size(181, 13);
    this.lnkLocations.TabIndex = 1;
    this.lnkLocations.TabStop = true;
    this.lnkLocations.Text = "View Underwriting Locations";
    this.lnkLocations.TextAlign = ContentAlignment.MiddleLeft;
    ((ListBox) this.lstUnderwritingLocations).BackColor = Color.White;
    ((CheckedListBox) this.lstUnderwritingLocations).CheckOnClick = true;
    ((ListBox) this.lstUnderwritingLocations).ForeColor = Color.Black;
    ((Control) this.lstUnderwritingLocations).Location = new Point(19, 3);
    this.lstUnderwritingLocations.MGAStyle = (MGAStyles) 2;
    ((Control) this.lstUnderwritingLocations).Name = "lstUnderwritingLocations";
    ((Control) this.lstUnderwritingLocations).Size = new Size(466, 289);
    ((Control) this.lstUnderwritingLocations).TabIndex = 0;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Panel1);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) label7);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.lnkVehiclesDeSelectAll);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.lnkVehiclesSelectAll);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.lstVehicles);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(756, 390);
    this.Panel1.Controls.Add((Control) this.lblSearchResult);
    this.Panel1.Controls.Add((Control) this.btnSearch);
    this.Panel1.Controls.Add((Control) this.txtVINSearch);
    this.Panel1.Controls.Add((Control) this.Label4);
    this.Panel1.Location = new Point(467, 8);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(266, 95);
    this.Panel1.TabIndex = 15;
    this.lblSearchResult.AutoSize = true;
    this.lblSearchResult.Font = new Font("Tahoma", 8f, System.Drawing.FontStyle.Bold);
    this.lblSearchResult.Location = new Point(6, 71);
    this.lblSearchResult.Name = "lblSearchResult";
    this.lblSearchResult.Size = new Size(98, 13);
    this.lblSearchResult.TabIndex = 192 /*0xC0*/;
    this.lblSearchResult.Text = "0 vehicles found";
    this.lblSearchResult.Visible = false;
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance19.BackColor = Color.FromArgb(248, 248, 248);
    appearance19.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance19.BackGradientStyle = (GradientStyle) 2;
    appearance19.BorderColor = Color.DarkGray;
    appearance19.ImageHAlign = (HAlign) 2;
    appearance19.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance19;
    ((Control) this.btnSearch).Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSearch).ImageSize = new Size(20, 20);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(89, 3);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(26, 26);
    ((Control) this.btnSearch).TabIndex = 190;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtVINSearch).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtVINSearch).BackColor = Color.White;
    ((Control) this.txtVINSearch).Enabled = false;
    ((Control) this.txtVINSearch).Location = new Point(5, 9);
    ((TextEditorControlBase) this.txtVINSearch).MaxLength = 4;
    this.txtVINSearch.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtVINSearch).Name = "txtVINSearch";
    ((Control) this.txtVINSearch).Size = new Size(77, 20);
    ((Control) this.txtVINSearch).TabIndex = 189;
    ((UltraControlBase) this.txtVINSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtVINSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.Location = new Point(2, 32 /*0x20*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(261, 39);
    this.Label4.TabIndex = 0;
    this.Label4.Text = "Search by the last 4 digits of VIN only (vehicles ending in '**********' match VIN search)";
    this.lnkVehiclesDeSelectAll.BackColor = Color.Transparent;
    this.lnkVehiclesDeSelectAll.Location = new Point(92, 319);
    this.lnkVehiclesDeSelectAll.Name = "lnkVehiclesDeSelectAll";
    this.lnkVehiclesDeSelectAll.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lnkVehiclesDeSelectAll.TabIndex = 13;
    this.lnkVehiclesDeSelectAll.TabStop = true;
    this.lnkVehiclesDeSelectAll.Text = "De-Select All";
    this.lnkVehiclesSelectAll.BackColor = Color.Transparent;
    this.lnkVehiclesSelectAll.Location = new Point(20, 319);
    this.lnkVehiclesSelectAll.Name = "lnkVehiclesSelectAll";
    this.lnkVehiclesSelectAll.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.lnkVehiclesSelectAll.TabIndex = 12;
    this.lnkVehiclesSelectAll.TabStop = true;
    this.lnkVehiclesSelectAll.Text = "Select All";
    this.lstVehicles.CheckOnClick = true;
    this.lstVehicles.Enabled = true;
    this.lstVehicles.FormattingEnabled = true;
    this.lstVehicles.Location = new Point(8, 8);
    this.lstVehicles.Name = "lstVehicles";
    this.lstVehicles.Size = new Size(448, 259);
    this.lstVehicles.TabIndex = 9;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.linkTemplateDocuments);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lnkMailCertificate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label8);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtDescription);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblDescriptionLabel);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lnkCof);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(756, 390);
    this.linkTemplateDocuments.AutoSize = true;
    this.linkTemplateDocuments.BackColor = Color.Transparent;
    this.linkTemplateDocuments.Location = new Point(8, 311);
    this.linkTemplateDocuments.Name = "linkTemplateDocuments";
    this.linkTemplateDocuments.Size = new Size(107, 13);
    this.linkTemplateDocuments.TabIndex = 19;
    this.linkTemplateDocuments.TabStop = true;
    this.linkTemplateDocuments.Text = "Template Documents";
    this.lnkMailCertificate.AutoSize = true;
    this.lnkMailCertificate.BackColor = Color.Transparent;
    this.lnkMailCertificate.Location = new Point(155, 20);
    this.lnkMailCertificate.Name = "lnkMailCertificate";
    this.lnkMailCertificate.Size = new Size(78, 13);
    this.lnkMailCertificate.TabIndex = 13;
    this.lnkMailCertificate.TabStop = true;
    this.lnkMailCertificate.Text = "Mail Certificate";
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).Appearance = (AppearanceBase) appearance21;
    appearance22.AlphaLevel = (short) 14;
    appearance22.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance22.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance22.BackColorAlpha = (Alpha) 2;
    appearance22.BackGradientAlignment = (GradientAlignment) 4;
    appearance22.BackGradientStyle = (GradientStyle) 5;
    appearance22.BorderAlpha = (Alpha) 1;
    appearance22.BorderColor = Color.FromArgb(78, 122, 171);
    appearance22.ForeColor = Color.FromArgb(49, 85, 153);
    appearance22.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).ButtonAppearance = (AppearanceBase) appearance22;
    ((Control) this.MgaDateTimePicker1).DataBindings.Add(new Binding("Value", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.IssuanceDate", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).DateTime = new DateTime(2011, 10, 10, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker1).Location = new Point(376, 16 /*0x10*/);
    this.MgaDateTimePicker1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker1).Name = "MgaDateTimePicker1";
    ((Control) this.MgaDateTimePicker1).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.MgaDateTimePicker1).TabIndex = 11;
    ((UltraControlBase) this.MgaDateTimePicker1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).Value = (object) new DateTime(2011, 10, 10, 0, 0, 0, 0);
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.DescriptionText", true));
    ((Control) this.txtDescription).Location = new Point(11, 67);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 2500;
    this.txtDescription.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtDescription).Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(592, 231);
    ((Control) this.txtDescription).TabIndex = 10;
    this.aiTip.SetToolTip((Control) this.txtDescription, "This text will show up on the Description field in the certificate");
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDescriptionLabel.BackColor = Color.Transparent;
    this.lblDescriptionLabel.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDescriptionLabel.Location = new Point(8, 48 /*0x30*/);
    this.lblDescriptionLabel.Name = "lblDescriptionLabel";
    this.lblDescriptionLabel.Size = new Size(72, 16 /*0x10*/);
    this.lblDescriptionLabel.TabIndex = 9;
    this.lblDescriptionLabel.Text = "Description:";
    this.lnkCof.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkCof.AutoSize = true;
    this.lnkCof.BackColor = Color.Transparent;
    this.lnkCof.Location = new Point(8, 23);
    this.lnkCof.Name = "lnkCof";
    this.lnkCof.Size = new Size(121, 13);
    this.lnkCof.TabIndex = 1;
    this.lnkCof.TabStop = true;
    this.lnkCof.Text = "Certificate of Insurance";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.TextBox1);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(756, 390);
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox1).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.TextBox1).BackColor = Color.White;
    ((Control) this.TextBox1).DataBindings.Add(new Binding("Text", (object) this.dsAdditionalInterests, "tblQuoteAdditionalInterests.Interest", true));
    ((Control) this.TextBox1).Location = new Point(3, 3);
    ((TextEditorControlBase) this.TextBox1).MaxLength = 2000;
    this.TextBox1.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.TextBox1).Multiline = true;
    ((Control) this.TextBox1).Name = "TextBox1";
    ((Control) this.TextBox1).Size = new Size(736, 297);
    ((Control) this.TextBox1).TabIndex = 10;
    this.aiTip.SetToolTip((Control) this.TextBox1, "Loan #, Copier Lease #, etc");
    ((UltraControlBase) this.TextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.utpcOFACResults).Controls.Add((Control) this.lblOFACNotice);
    ((Control) this.utpcOFACResults).Controls.Add((Control) this.ugOFACResults);
    ((Control) this.utpcOFACResults).Location = new Point(-10000, -10000);
    ((Control) this.utpcOFACResults).Name = "utpcOFACResults";
    ((Control) this.utpcOFACResults).Size = new Size(756, 390);
    this.lblOFACNotice.AutoSize = true;
    this.lblOFACNotice.Location = new Point(29, 10);
    this.lblOFACNotice.Name = "lblOFACNotice";
    this.lblOFACNotice.Size = new Size(106, 13);
    this.lblOFACNotice.TabIndex = 2;
    this.lblOFACNotice.Text = "Show OFAC Results:";
    ((Control) this.ugOFACResults).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugOFACResults).ContextMenuStrip = this.cntMenu;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance26.BackColor = Color.LightSteelBlue;
    appearance26.FontData.SizeInPoints = 10f;
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = Color.White;
    appearance28.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.AddRowAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance29.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance31.BackColor = Color.FromArgb(246, 250, 253);
    appearance31.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance31;
    appearance32.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance33.BackColor = Color.Transparent;
    appearance33.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.Override.WrapHeaderText = (DefaultableBoolean) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugOFACResults).Font = new Font("Tahoma", 8f);
    ((Control) this.ugOFACResults).Location = new Point(32 /*0x20*/, 37);
    ((Control) this.ugOFACResults).Name = "ugOFACResults";
    ((Control) this.ugOFACResults).Size = new Size(691, 299);
    ((Control) this.ugOFACResults).TabIndex = 1;
    ((UltraControlBase) this.ugOFACResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOFACResults).UseOsThemes = (DefaultableBoolean) 2;
    this.cntMenu.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.cnMarkAsNew,
      (ToolStripItem) this.cnCopy
    });
    this.cntMenu.Name = "cntMenu";
    this.cntMenu.Size = new Size(143, 48 /*0x30*/);
    this.cnMarkAsNew.Image = (Image) componentResourceManager.GetObject("cnMarkAsNew.Image");
    this.cnMarkAsNew.Name = "cnMarkAsNew";
    this.cnMarkAsNew.Size = new Size(142, 22);
    this.cnMarkAsNew.Text = "Mark as New";
    this.cnCopy.Image = (Image) componentResourceManager.GetObject("cnCopy.Image");
    this.cnCopy.Name = "cnCopy";
    this.cnCopy.Size = new Size(142, 22);
    this.cnCopy.Text = "Copy";
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(644, 614);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 8;
    this.dbSave.UIState = (UIState) 2;
    ((Control) this.ugInterests).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugInterests).ContextMenuStrip = this.cntMenu;
    ((UltraGridBase) this.ugInterests).DataSource = (object) this.dsAdditionalInterests.tblQuoteAdditionalInterests;
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugInterests).DisplayLayout.Appearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.ugInterests).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 5;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 74;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 49;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 14;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Name";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 163;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 39;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 37;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 142;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 38;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 51;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 41;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 52;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Zip";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Width = 49;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 59;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 64 /*0x40*/;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 75;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 89;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Width = 230;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 117;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.Format = "d";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 109;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 100;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 53;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Width = 71;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 79;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 116;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 64 /*0x40*/;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 64 /*0x40*/;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 64 /*0x40*/;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 64 /*0x40*/;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 78;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 29;
    ultraGridColumn30.Width = 50;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 30;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 77;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 85;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 33;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 75;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 66;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 34;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 35;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 36;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 37;
    ultraGridBand1.Columns.AddRange(new object[38]
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
      (object) ultraGridColumn38
    });
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 0;
    ultraGridColumn39.Width = 199;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 1;
    ultraGridColumn40.Width = 225;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn39,
      (object) ultraGridColumn40
    });
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 0;
    ultraGridColumn41.Width = 197;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 1;
    ultraGridColumn42.Width = 227;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 0;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 1;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45
    });
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 0;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ((UltraGridBase) this.ugInterests).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugInterests).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugInterests).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugInterests).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugInterests).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugInterests).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance35.BackColor = Color.LightSteelBlue;
    appearance35.FontData.SizeInPoints = 10f;
    appearance35.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInterests).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance35;
    appearance36.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance36;
    appearance37.BackColor = Color.White;
    appearance37.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.AddRowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance38.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance38;
    appearance39.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance40.BackColor = Color.FromArgb(246, 250, 253);
    appearance40.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance40;
    appearance41.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance42.BackColor = Color.Transparent;
    appearance42.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.ugInterests).DisplayLayout.Override.WrapHeaderText = (DefaultableBoolean) 2;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugInterests).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugInterests).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugInterests).Font = new Font("Tahoma", 8f);
    ((Control) this.ugInterests).Location = new Point(8, 8);
    ((Control) this.ugInterests).Name = "ugInterests";
    ((Control) this.ugInterests).Size = new Size(758, 232);
    ((Control) this.ugInterests).TabIndex = 0;
    ((UltraControlBase) this.ugInterests).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugInterests).UseOsThemes = (DefaultableBoolean) 2;
    this.daInterests.DeleteCommand = this.DbDeleteCommand1;
    this.daInterests.InsertCommand = this.DbInsertCommand1;
    this.daInterests.SelectCommand = this.DbSelectCommand1;
    this.daInterests.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAdditionalInterests", new DataColumnMapping[32 /*0x20*/]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("AdditionalInterestGuid", "AdditionalInterestGuid"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("InterestName", "InterestName"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("ModificationCode", "ModificationCode"),
        new DataColumnMapping("Interest", "Interest"),
        new DataColumnMapping("DescriptionText", "DescriptionText"),
        new DataColumnMapping("IssuanceDate", "IssuanceDate"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("LineID", "LineID"),
        new DataColumnMapping("Billable", "Billable"),
        new DataColumnMapping("BillableAmount", "BillableAmount"),
        new DataColumnMapping("AdditionalInterestTypeID", "AdditionalInterestTypeID"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("MiddleName", "MiddleName"),
        new DataColumnMapping("LastName", "LastName"),
        new DataColumnMapping("DateOfBirth", "DateOfBirth"),
        new DataColumnMapping("mobile", "mobile"),
        new DataColumnMapping("email", "email"),
        new DataColumnMapping("OfacCleared", "OfacCleared")
      })
    });
    this.daInterests.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [tblQuoteAdditionalInterests] WHERE (([ID] = @Original_ID))";
    this.DbDeleteCommand1.Connection = this._cnDB;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this._cnDB = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this._cnDB;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[31 /*0x1F*/]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestGuid", SqlDbType.UniqueIdentifier, 0, "AdditionalInterestGuid"),
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      DefaultDatabase.CreateParameter("@InterestName", SqlDbType.VarChar, 0, "InterestName"),
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      DefaultDatabase.CreateParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      DefaultDatabase.CreateParameter("@City", SqlDbType.VarChar, 0, "City"),
      DefaultDatabase.CreateParameter("@County", SqlDbType.VarChar, 0, "County"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      DefaultDatabase.CreateParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      DefaultDatabase.CreateParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      DefaultDatabase.CreateParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      DefaultDatabase.CreateParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      DefaultDatabase.CreateParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      DefaultDatabase.CreateParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      DefaultDatabase.CreateParameter("@ModificationCode", SqlDbType.Char, 0, "ModificationCode"),
      DefaultDatabase.CreateParameter("@Interest", SqlDbType.VarChar, 0, "Interest"),
      DefaultDatabase.CreateParameter("@DescriptionText", SqlDbType.VarChar, 0, "DescriptionText"),
      DefaultDatabase.CreateParameter("@IssuanceDate", SqlDbType.DateTime, 0, "IssuanceDate"),
      DefaultDatabase.CreateParameter("@FEIN", SqlDbType.VarChar, 0, "FEIN"),
      DefaultDatabase.CreateParameter("@LineID", SqlDbType.Int, 0, "LineID"),
      DefaultDatabase.CreateParameter("@Billable", SqlDbType.Bit, 0, "Billable"),
      DefaultDatabase.CreateParameter("@BillableAmount", SqlDbType.Money, 0, "BillableAmount"),
      DefaultDatabase.CreateParameter("@AdditionalInterestTypeID", SqlDbType.Int, 0, "AdditionalInterestTypeID"),
      DefaultDatabase.CreateParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      DefaultDatabase.CreateParameter("@FirstName", SqlDbType.VarChar, 0, "FirstName"),
      DefaultDatabase.CreateParameter("@MiddleName", SqlDbType.VarChar, 0, "MiddleName"),
      DefaultDatabase.CreateParameter("@LastName", SqlDbType.VarChar, 0, "LastName"),
      DefaultDatabase.CreateParameter("@DateOfBirth", SqlDbType.DateTime, 0, "DateOfBirth"),
      DefaultDatabase.CreateParameter("@mobile", SqlDbType.VarChar, 0, "mobile"),
      DefaultDatabase.CreateParameter("@email", SqlDbType.VarChar, 0, "email"),
      DefaultDatabase.CreateParameter("@OfacCleared", SqlDbType.DateTime, 0, "OfacCleared")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this._cnDB;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this._cnDB;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[33]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestGuid", SqlDbType.UniqueIdentifier, 0, "AdditionalInterestGuid"),
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      DefaultDatabase.CreateParameter("@InterestName", SqlDbType.VarChar, 0, "InterestName"),
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      DefaultDatabase.CreateParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      DefaultDatabase.CreateParameter("@City", SqlDbType.VarChar, 0, "City"),
      DefaultDatabase.CreateParameter("@County", SqlDbType.VarChar, 0, "County"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      DefaultDatabase.CreateParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      DefaultDatabase.CreateParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      DefaultDatabase.CreateParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      DefaultDatabase.CreateParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      DefaultDatabase.CreateParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      DefaultDatabase.CreateParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      DefaultDatabase.CreateParameter("@ModificationCode", SqlDbType.Char, 0, "ModificationCode"),
      DefaultDatabase.CreateParameter("@Interest", SqlDbType.VarChar, 0, "Interest"),
      DefaultDatabase.CreateParameter("@DescriptionText", SqlDbType.VarChar, 0, "DescriptionText"),
      DefaultDatabase.CreateParameter("@IssuanceDate", SqlDbType.DateTime, 0, "IssuanceDate"),
      DefaultDatabase.CreateParameter("@FEIN", SqlDbType.VarChar, 0, "FEIN"),
      DefaultDatabase.CreateParameter("@LineID", SqlDbType.Int, 0, "LineID"),
      DefaultDatabase.CreateParameter("@Billable", SqlDbType.Bit, 0, "Billable"),
      DefaultDatabase.CreateParameter("@BillableAmount", SqlDbType.Money, 0, "BillableAmount"),
      DefaultDatabase.CreateParameter("@AdditionalInterestTypeID", SqlDbType.Int, 0, "AdditionalInterestTypeID"),
      DefaultDatabase.CreateParameter("@Salutation", SqlDbType.VarChar, 0, "Salutation"),
      DefaultDatabase.CreateParameter("@FirstName", SqlDbType.VarChar, 0, "FirstName"),
      DefaultDatabase.CreateParameter("@MiddleName", SqlDbType.VarChar, 0, "MiddleName"),
      DefaultDatabase.CreateParameter("@LastName", SqlDbType.VarChar, 0, "LastName"),
      DefaultDatabase.CreateParameter("@DateOfBirth", SqlDbType.DateTime, 0, "DateOfBirth"),
      DefaultDatabase.CreateParameter("@mobile", SqlDbType.VarChar, 0, "mobile"),
      DefaultDatabase.CreateParameter("@email", SqlDbType.VarChar, 0, "email"),
      DefaultDatabase.CreateParameter("@OfacCleared", SqlDbType.DateTime, 0, "OfacCleared"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.utpcOFACResults);
    ((Control) this.UltraTabControl1).Location = new Point(8, 246);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    appearance43.BackColor = Color.WhiteSmoke;
    ((UltraTabControlBase) this.UltraTabControl1).SelectedTabAppearance = (AppearanceBase) appearance43;
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(758, 417);
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 5);
    appearance44.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance44;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Interest Info";
    appearance45.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance45;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Locations";
    appearance46.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance46.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance46;
    ultraTab3.TabPage = this.UltraTabPageControl5;
    ultraTab3.Text = "Vehicles";
    ultraTab3.Visible = false;
    appearance47.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance47.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance47;
    ultraTab4.TabPage = this.UltraTabPageControl3;
    ultraTab4.Text = "Documents";
    appearance48.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance48.Image"));
    ultraTab5.Appearance = (AppearanceBase) appearance48;
    ultraTab5.TabPage = this.UltraTabPageControl4;
    ultraTab5.Text = "Interest";
    ultraTab6.Key = "tabViewOFACResults";
    ultraTab6.TabPage = this.utpcOFACResults;
    ultraTab6.Text = "View OFAC Results";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[6]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(120, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(756, 390);
    this._daUnderwritingLocations.DeleteCommand = this.DbDeleteCommand4;
    this._daUnderwritingLocations.InsertCommand = this.DbInsertCommand4;
    this._daUnderwritingLocations.SelectCommand = this.DbSelectCommand3;
    this._daUnderwritingLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[7]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("BuildingNo", "BuildingNo"),
        new DataColumnMapping("PhysicalBuildingNo", "PhysicalBuildingNo"),
        new DataColumnMapping("LocationNo", "LocationNo")
      })
    });
    this._daUnderwritingLocations.UpdateCommand = this.DbUpdateCommand4;
    this.DbDeleteCommand4.CommandText = componentResourceManager.GetString("DbDeleteCommand4.CommandText");
    this.DbDeleteCommand4.Connection = this._cnDB;
    this.DbDeleteCommand4.Parameters.AddRange((Array) new DbParameter[7]
    {
      DefaultDatabase.CreateParameter("@Original_LocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Address1", SqlDbType.VarChar, 200, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_BuildingNo", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BuildingNo", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_City", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_LocationNo", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationNo", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysicalBuildingNo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysicalBuildingNo", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_State", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand4.CommandText = componentResourceManager.GetString("DbInsertCommand4.CommandText");
    this.DbInsertCommand4.Connection = this._cnDB;
    this.DbInsertCommand4.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 200, "Address1"),
      DefaultDatabase.CreateParameter("@City", SqlDbType.VarChar, 50, "City"),
      DefaultDatabase.CreateParameter("@State", SqlDbType.VarChar, 2, "State"),
      DefaultDatabase.CreateParameter("@BuildingNo", SqlDbType.Int, 4, "BuildingNo"),
      DefaultDatabase.CreateParameter("@PhysicalBuildingNo", SqlDbType.VarChar, 50, "PhysicalBuildingNo"),
      DefaultDatabase.CreateParameter("@LocationNo", SqlDbType.Int, 4, "LocationNo")
    });
    this.DbSelectCommand3.CommandText = componentResourceManager.GetString("DbSelectCommand3.CommandText");
    this.DbSelectCommand3.Connection = this._cnDB;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.DbUpdateCommand4.CommandText = componentResourceManager.GetString("DbUpdateCommand4.CommandText");
    this.DbUpdateCommand4.Connection = this._cnDB;
    this.DbUpdateCommand4.Parameters.AddRange((Array) new DbParameter[14]
    {
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 200, "Address1"),
      DefaultDatabase.CreateParameter("@City", SqlDbType.VarChar, 50, "City"),
      DefaultDatabase.CreateParameter("@State", SqlDbType.VarChar, 2, "State"),
      DefaultDatabase.CreateParameter("@BuildingNo", SqlDbType.Int, 4, "BuildingNo"),
      DefaultDatabase.CreateParameter("@PhysicalBuildingNo", SqlDbType.VarChar, 50, "PhysicalBuildingNo"),
      DefaultDatabase.CreateParameter("@LocationNo", SqlDbType.Int, 4, "LocationNo"),
      DefaultDatabase.CreateParameter("@Original_LocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_Address1", SqlDbType.VarChar, 200, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_BuildingNo", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BuildingNo", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_City", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_LocationNo", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LocationNo", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PhysicalBuildingNo", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PhysicalBuildingNo", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_State", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@LocationID", SqlDbType.Int, 4, "LocationID")
    });
    this.daQuoteInterestTypes.DeleteCommand = this.DbDeleteCommand2;
    this.daQuoteInterestTypes.InsertCommand = this.DbInsertCommand2;
    this.daQuoteInterestTypes.SelectCommand = this.DbSelectCommand4;
    this.daQuoteInterestTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAdditionalInterestTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("AdditionalInterestID", "AdditionalInterestID"),
        new DataColumnMapping("AdditionalInterestType", "AdditionalInterestType")
      })
    });
    this.daQuoteInterestTypes.UpdateCommand = this.DbUpdateCommand2;
    this.DbDeleteCommand2.CommandText = "DELETE FROM tblQuoteAdditionalInterestTypes WHERE (AdditionalInterestID = @Original_AdditionalInterestID) AND (AdditionalInterestType = @Original_AdditionalInterestType)";
    this.DbDeleteCommand2.Connection = this._cnDB;
    this.DbDeleteCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestType", SqlDbType.VarChar, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestType", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand2.CommandText = componentResourceManager.GetString("DbInsertCommand2.CommandText");
    this.DbInsertCommand2.Connection = this._cnDB;
    this.DbInsertCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 4, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@AdditionalInterestType", SqlDbType.VarChar, 100, "AdditionalInterestType")
    });
    this.DbSelectCommand4.CommandText = "SELECT AdditionalInterestID, AdditionalInterestType FROM tblQuoteAdditionalInterestTypes WHERE (AdditionalInterestID IN (SELECT ID FROM tblQuoteAdditionalInterests WHERE QuoteID = @QuoteID))";
    this.DbSelectCommand4.Connection = this._cnDB;
    this.DbSelectCommand4.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4)
    });
    this.DbUpdateCommand2.CommandText = componentResourceManager.GetString("DbUpdateCommand2.CommandText");
    this.DbUpdateCommand2.Connection = this._cnDB;
    this.DbUpdateCommand2.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 4, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@AdditionalInterestType", SqlDbType.VarChar, 100, "AdditionalInterestType"),
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestType", SqlDbType.VarChar, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestType", DataRowVersion.Original, (object) null)
    });
    this._daQuoteLocations.DeleteCommand = this.DbDeleteCommand3;
    this._daQuoteLocations.InsertCommand = this.DbInsertCommand3;
    this._daQuoteLocations.SelectCommand = this.DbSelectCommand5;
    this._daQuoteLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAdditionalInterestsLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("AdditionalInterestID", "AdditionalInterestID"),
        new DataColumnMapping("UnderwritingLocationID", "UnderwritingLocationID")
      })
    });
    this._daQuoteLocations.UpdateCommand = this.DbUpdateCommand3;
    this.DbDeleteCommand3.CommandText = "DELETE FROM tblQuoteAdditionalInterestsLocations WHERE (AdditionalInterestID = @Original_AdditionalInterestID) AND (UnderwritingLocationID = @Original_UnderwritingLocationID)";
    this.DbDeleteCommand3.Connection = this._cnDB;
    this.DbDeleteCommand3.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnderwritingLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnderwritingLocationID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand3.CommandText = componentResourceManager.GetString("DbInsertCommand3.CommandText");
    this.DbInsertCommand3.Connection = this._cnDB;
    this.DbInsertCommand3.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 4, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@UnderwritingLocationID", SqlDbType.Int, 4, "UnderwritingLocationID")
    });
    this.DbSelectCommand5.CommandText = componentResourceManager.GetString("DbSelectCommand5.CommandText");
    this.DbSelectCommand5.Connection = this._cnDB;
    this.DbSelectCommand5.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4)
    });
    this.DbUpdateCommand3.CommandText = componentResourceManager.GetString("DbUpdateCommand3.CommandText");
    this.DbUpdateCommand3.Connection = this._cnDB;
    this.DbUpdateCommand3.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 4, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@UnderwritingLocationID", SqlDbType.Int, 4, "UnderwritingLocationID"),
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnderwritingLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnderwritingLocationID", DataRowVersion.Original, (object) null)
    });
    this._daNetRateLocations.SelectCommand = this.DbSelectCommand2;
    this._daNetRateLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "NetRate_Quote_Insur_Quote_Locat", new DataColumnMapping[9]
      {
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("LocationNumber", "LocationNumber"),
        new DataColumnMapping("BuildingNumber", "BuildingNumber"),
        new DataColumnMapping("Address", "Address"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("StreetSecondaryLocation", "StreetSecondaryLocation"),
        new DataColumnMapping("BuildingIdentifier", "BuildingIdentifier")
      })
    });
    this.DbSelectCommand2.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    this.DbSelectCommand2.Connection = this._cnDB;
    this.DbSelectCommand2.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    this._daQuoteNetRateLocations.DeleteCommand = this.DbDeleteCommand5;
    this._daQuoteNetRateLocations.InsertCommand = this.DbInsertCommand5;
    this._daQuoteNetRateLocations.SelectCommand = this.DbSelectCommand6;
    this._daQuoteNetRateLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAdditionalInterestsNetRateLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("AdditionalInterestID", "AdditionalInterestID"),
        new DataColumnMapping("NetRateLocationID", "NetRateLocationID")
      })
    });
    this._daQuoteNetRateLocations.UpdateCommand = this.DbUpdateCommand5;
    this.DbDeleteCommand5.CommandText = componentResourceManager.GetString("DbDeleteCommand5.CommandText");
    this.DbDeleteCommand5.Connection = this._cnDB;
    this.DbDeleteCommand5.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_NetRateLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NetRateLocationID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_NetRateBuildingNumber", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NetRateBuildingNumber", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand5.CommandText = "INSERT INTO dbo.tblQuoteAdditionalInterestsNetRateLocations (AdditionalInterestID, NetRateLocationID, NetRateBuildingNumber) VALUES (@AdditionalInterestID, @NetRateLocationID, @NetRateBuildingNumber)";
    this.DbInsertCommand5.Connection = this._cnDB;
    this.DbInsertCommand5.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 4, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@NetRateLocationID", SqlDbType.Int, 4, "NetRateLocationID"),
      DefaultDatabase.CreateParameter("@NetRateBuildingNumber", SqlDbType.Int, 4, "NetRateBuildingNumber")
    });
    this.DbSelectCommand6.CommandText = componentResourceManager.GetString("DbSelectCommand6.CommandText");
    this.DbSelectCommand6.Connection = this._cnDB;
    this.DbSelectCommand6.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4)
    });
    this.DbUpdateCommand5.CommandText = componentResourceManager.GetString("DbUpdateCommand5.CommandText");
    this.DbUpdateCommand5.Connection = this._cnDB;
    this.DbUpdateCommand5.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 4, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@NetRateLocationID", SqlDbType.Int, 4, "NetRateLocationID"),
      DefaultDatabase.CreateParameter("@NetRateBuildingNumber", SqlDbType.Int, 4, "NetRateBuildingNumber"),
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_NetRateLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NetRateLocationID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_NetRateBuildingNumber", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NetRateBuildingNumber", DataRowVersion.Original, (object) null)
    });
    this.DbSelectCommand8.CommandText = componentResourceManager.GetString("DbSelectCommand8.CommandText");
    this.DbSelectCommand8.Connection = this._cnDB;
    this.DbSelectCommand8.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4)
    });
    this.DbInsertCommand6.CommandText = "INSERT INTO [dbo].[tblQuoteAdditionalInterestsNetRateVehicles] ([AdditionalInterestID], [VehicleID]) VALUES (@AdditionalInterestID, @VehicleID)";
    this.DbInsertCommand6.Connection = this._cnDB;
    this.DbInsertCommand6.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 0, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@VehicleID", SqlDbType.Int, 0, "VehicleID")
    });
    this.DbUpdateCommand6.CommandText = componentResourceManager.GetString("DbUpdateCommand6.CommandText");
    this.DbUpdateCommand6.Connection = this._cnDB;
    this.DbUpdateCommand6.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@AdditionalInterestID", SqlDbType.Int, 0, "AdditionalInterestID"),
      DefaultDatabase.CreateParameter("@VehicleID", SqlDbType.Int, 0, "VehicleID"),
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_VehicleID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "VehicleID", DataRowVersion.Original, (object) null)
    });
    this.DbDeleteCommand6.CommandText = "DELETE FROM [dbo].[tblQuoteAdditionalInterestsNetRateVehicles] WHERE (([AdditionalInterestID] = @Original_AdditionalInterestID) AND ([VehicleID] = @Original_VehicleID))";
    this.DbDeleteCommand6.Connection = this._cnDB;
    this.DbDeleteCommand6.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_AdditionalInterestID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalInterestID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_VehicleID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "VehicleID", DataRowVersion.Original, (object) null)
    });
    this.daQuoteNetRateVehicles.DeleteCommand = this.DbDeleteCommand6;
    this.daQuoteNetRateVehicles.InsertCommand = this.DbInsertCommand6;
    this.daQuoteNetRateVehicles.SelectCommand = this.DbSelectCommand8;
    this.daQuoteNetRateVehicles.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAdditionalInterestsNetRateVehicles", new DataColumnMapping[2]
      {
        new DataColumnMapping("AdditionalInterestID", "AdditionalInterestID"),
        new DataColumnMapping("VehicleID", "VehicleID")
      })
    });
    this.daQuoteNetRateVehicles.UpdateCommand = this.DbUpdateCommand6;
    ultraDataColumn1.DataType = typeof (int);
    ultraDataBand1.Columns.AddRange(new object[2]
    {
      (object) ultraDataColumn1,
      (object) ultraDataColumn2
    });
    ultraDataColumn3.DataType = typeof (int);
    ultraDataColumn4.DataType = typeof (int);
    ultraDataBand2.Columns.AddRange(new object[2]
    {
      (object) ultraDataColumn3,
      (object) ultraDataColumn4
    });
    ultraDataColumn5.DataType = typeof (int);
    ultraDataColumn6.DataType = typeof (int);
    ultraDataColumn7.DataType = typeof (int);
    ultraDataBand3.Columns.AddRange(new object[3]
    {
      (object) ultraDataColumn5,
      (object) ultraDataColumn6,
      (object) ultraDataColumn7
    });
    ultraDataColumn8.DataType = typeof (int);
    ultraDataColumn9.DataType = typeof (int);
    ultraDataBand4.Columns.AddRange(new object[2]
    {
      (object) ultraDataColumn8,
      (object) ultraDataColumn9
    });
    this.UltraDataSource1.Band.ChildBands.AddRange(new object[4]
    {
      (object) ultraDataBand1,
      (object) ultraDataBand2,
      (object) ultraDataBand3,
      (object) ultraDataBand4
    });
    ultraDataColumn10.DataType = typeof (int);
    ultraDataColumn11.DataType = typeof (Guid);
    ultraDataColumn12.DataType = typeof (int);
    ultraDataColumn28.DataType = typeof (DateTime);
    ultraDataColumn30.DataType = typeof (int);
    ultraDataColumn31.DataType = typeof (bool);
    ultraDataColumn32.DataType = typeof (Decimal);
    ultraDataColumn33.DataType = typeof (int);
    ultraDataColumn38.DataType = typeof (DateTime);
    ultraDataColumn39.DataType = typeof (bool);
    ultraDataColumn42.DataType = typeof (DateTime);
    ultraDataColumn43.DataType = typeof (bool);
    this.UltraDataSource1.Band.Columns.AddRange(new object[34]
    {
      (object) ultraDataColumn10,
      (object) ultraDataColumn11,
      (object) ultraDataColumn12,
      (object) ultraDataColumn13,
      (object) ultraDataColumn14,
      (object) ultraDataColumn15,
      (object) ultraDataColumn16,
      (object) ultraDataColumn17,
      (object) ultraDataColumn18,
      (object) ultraDataColumn19,
      (object) ultraDataColumn20,
      (object) ultraDataColumn21,
      (object) ultraDataColumn22,
      (object) ultraDataColumn23,
      (object) ultraDataColumn24,
      (object) ultraDataColumn25,
      (object) ultraDataColumn26,
      (object) ultraDataColumn27,
      (object) ultraDataColumn28,
      (object) ultraDataColumn29,
      (object) ultraDataColumn30,
      (object) ultraDataColumn31,
      (object) ultraDataColumn32,
      (object) ultraDataColumn33,
      (object) ultraDataColumn34,
      (object) ultraDataColumn35,
      (object) ultraDataColumn36,
      (object) ultraDataColumn37,
      (object) ultraDataColumn38,
      (object) ultraDataColumn39,
      (object) ultraDataColumn40,
      (object) ultraDataColumn41,
      (object) ultraDataColumn42,
      (object) ultraDataColumn43
    });
    this.UltraDataSource1.Band.Key = "tblQuoteAdditionalInterests";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(774, 666);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ugInterests);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdditionalInterests);
    this.Text = "Additional Interests";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.chkRunOFAC).EndInit();
    ((ISupportInitialize) this.dtOfacCleared).EndInit();
    ((ISupportInitialize) this.dtOfacSearched).EndInit();
    ((ISupportInitialize) this.MgaTxtEmail).EndInit();
    this.dsAdditionalInterests.EndInit();
    ((ISupportInitialize) this.MgaMobile).EndInit();
    ((ISupportInitialize) this.dtDateOfBirth).EndInit();
    ((ISupportInitialize) this.cboSalutations).EndInit();
    ((ISupportInitialize) this.txtLast).EndInit();
    ((ISupportInitialize) this.txtMiddle).EndInit();
    ((ISupportInitialize) this.txtFirst).EndInit();
    ((ISupportInitialize) this.cboInterestType).EndInit();
    ((ISupportInitialize) this.numAmount).EndInit();
    ((ISupportInitialize) this.checkBillable).EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.lstInterestTypes).EndInit();
    ((ISupportInitialize) this.txtInsuredName).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.UltraMaskedEdit1).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.lstUnderwritingLocations).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).PerformLayout();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.txtVINSearch).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.MgaDateTimePicker1).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).PerformLayout();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((Control) this.utpcOFACResults).ResumeLayout(false);
    ((Control) this.utpcOFACResults).PerformLayout();
    ((ISupportInitialize) this.ugOFACResults).EndInit();
    this.cntMenu.ResumeLayout(false);
    ((ISupportInitialize) this.ugInterests).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraDataSource1).EndInit();
    ((ISupportInitialize) this.UltraDataSource2).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("lblSearchDate")]
  protected virtual Label lblSearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacClear")]
  protected virtual Label lblOfacClear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtOfacSearched")]
  protected virtual MGADateTimePicker dtOfacSearched { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGADateTimePicker dtOfacCleared
  {
    get => this._dtOfacCleared;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.DtOfacCleared_MouseClick);
      MGADateTimePicker dtOfacCleared1 = this._dtOfacCleared;
      if (dtOfacCleared1 != null)
        ((Control) dtOfacCleared1).MouseClick -= mouseEventHandler;
      this._dtOfacCleared = value;
      MGADateTimePicker dtOfacCleared2 = this._dtOfacCleared;
      if (dtOfacCleared2 == null)
        return;
      ((Control) dtOfacCleared2).MouseClick += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("_cnDB")]
  private virtual DbConnection _cnDB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_daUnderwritingLocations")]
  private virtual DbDataAdapter _daUnderwritingLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_daNetRateLocations")]
  private virtual DbDataAdapter _daNetRateLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected SqlDataAdapter daUnderwritingLocations
  {
    get => this._daUnderwritingLocations as SqlDataAdapter;
    set => this._daUnderwritingLocations = (DbDataAdapter) value;
  }

  protected SqlDataAdapter daQuoteLocations
  {
    get => this._daQuoteLocations as SqlDataAdapter;
    set => this._daQuoteLocations = (DbDataAdapter) value;
  }

  protected SqlDataAdapter daQuoteNetRateLocations
  {
    get => this._daQuoteNetRateLocations as SqlDataAdapter;
    set => this._daQuoteNetRateLocations = (DbDataAdapter) value;
  }

  protected SqlDataAdapter daNetRateLocations
  {
    get => this._daNetRateLocations as SqlDataAdapter;
    set => this._daNetRateLocations = (DbDataAdapter) value;
  }

  public frmAdditionalInterests()
  {
    this.Load += new EventHandler(this.frmAdditionalInterests_Load);
    this.FormClosing += new FormClosingEventHandler(this.frmAdditionalInterests_FormClosing);
    this._allowAddingAdditionalInterest = true;
    this._currentLocations = new HashSet<int>();
    this._currentVehicles = new HashSet<int>();
    this._ofacData = new Dictionary<Guid, OfacSystem.OfacStatus>();
    this._ofacAITypes = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    this._CheckNewVehiclesAndLocations = SystemSettings.GetLazySetting<bool>("SetModCodeOnNewVehicleAndLocations", false, true);
    this._filterVehicleByLocation = SystemSettings.GetLazySetting<bool>("AddlInterestVehicle.FilterByLocation", false, true);
    this._runOfacOnAdditionalInterest = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.RunCompliance", false, true);
    this._skipOfacOnNewInterest = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.SkipOnNew", false, true);
    this._skipOfacOnModifiedInterest = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.SkipOnModified", false, true);
    this._runOfacViaCheckBox = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.CheckBox.ShowAndRunIfChecked", false, true);
    this._viewOfacTAB = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.ShowTab", false, true);
    this.InitializeComponent();
  }

  public frmAdditionalInterests(int quoteID)
    : this()
  {
    this._quote = Quote.CreateNew(quoteID);
    this._isEndorsement = this.Quote.IsEndorsement;
    this.Text = $"{this.Text} - Control No. {this._quote.ControlNo}";
  }

  protected dsAdditionalInterests.tblQuoteAdditionalInterestsRow CurrentInterestRow
  {
    get
    {
      return this.bmb.Position == -1 ? (dsAdditionalInterests.tblQuoteAdditionalInterestsRow) null : this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position];
    }
  }

  protected dsAdditionalInterests ds => this.dsAdditionalInterests;

  protected SqlConnection cn => this._cnDB as SqlConnection;

  protected Quote Quote => this._quote;

  protected UltraGrid InterestsGrid => this.ugInterests;

  [EditorBrowsable(EditorBrowsableState.Never)]
  protected UltraGrid UgIntrsts => this.ugInterests;

  protected MGATextBox txtDesc => this.txtDescription;

  protected UltraTabPageControl DocumentTab => this.UltraTabPageControl3;

  protected BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.dsAdditionalInterests, this.dsAdditionalInterests.tblQuoteAdditionalInterests.TableName];
    }
  }

  protected virtual bool UsingNetRate
  {
    get
    {
      if (!this._usingNetRate.HasValue)
        this._usingNetRate = new bool?(this._quote.UsingNetRate);
      return this._usingNetRate.Value;
    }
  }

  protected bool AutoLineRatedWithNetRate => this._autoLineRatedWithNetRate;

  private string AdditionalInterestName
  {
    get
    {
      return $"{((TextEditorControlBase) this.txtFirst).Text}{(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtMiddle).Text, string.Empty, false) == 0 ? (object) " " : (object) $" {((TextEditorControlBase) this.txtMiddle).Text} ")}{((TextEditorControlBase) this.txtLast).Text}";
    }
  }

  private void frmAdditionalInterests_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    ((UltraCombo) this.cboInterestType).ValueChanged -= new EventHandler(this.cboInterestType_ValueChanged);
    try
    {
      this.Panel1.Visible = this._filterVehicleByLocation.Value;
      this.LoadForm(this._quote.QuoteID);
      this.FormLoadComplete();
      ((UltraCombo) this.cboInterestType).ValueChanged += new EventHandler(this.cboInterestType_ValueChanged);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ConstraintException constraintException = ex;
      if (constraintException.Message.Contains("Failed to enable constraints. One or more rows contain values violating non-null, unique, or foreign-key constraints."))
      {
        int num = (int) MessageBox.Show("Cannot load additional interest data because there is a discrepancy of locations and/or vehicle data in Netrate and IMS.  Please try re-rating in Netrate and save back into IMS and try loading additional interest screen again.", "Netrate location and / or vehicle data is different in IMS and Netrate.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ErrorHandler.ShowDataSetErrors((DataSet) this.ds, constraintException);
        this.DialogResult = DialogResult.Cancel;
        ((Control) this.dbSave).Enabled = false;
      }
      else
        ErrorHandler.HandleError((Exception) constraintException);
      ProjectData.ClearProjectError();
    }
  }

  private void frmAdditionalInterests_FormClosing(object sender, FormClosingEventArgs e)
  {
    DocumentHandling.AdditionalInterestID = -1;
  }

  protected void LoadForm(int quoteID)
  {
    if (this.UsingNetRate)
    {
      this.lnkLocations.Visible = false;
      this.lnkLocations.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.lnkLocations_LinkClicked);
      ((UltraTabControlBase) this.UltraTabControl1).Tabs[1].Text = "NetRate Locations";
    }
    ((UltraTabControlBase) this.UltraTabControl1).Tabs["tabViewOFACResults"].Visible = this._viewOfacTAB.Value;
    if (this._runOfacOnAdditionalInterest.Value || this._runOfacViaCheckBox.Value)
    {
      ((Control) this.chkRunOFAC).Visible = this._runOfacViaCheckBox.Value;
      this.lblOfacClear.Visible = true;
      this.lblSearchDate.Visible = true;
      ((Control) this.dtOfacCleared).Visible = true;
      ((Control) this.dtOfacSearched).Visible = true;
      this._ofacAITypes.UnionWith((IEnumerable<string>) AdditionalInterest.OfacSearchTypes);
      if (!SecurityManager.Instance.AssertPermission("{7D2C4C5C-F51B-4B4A-AB4F-F537208BEDBF}"))
      {
        this.aiTip.SetToolTip((Control) this.lblOfacClear, "User does not have permission to clear.");
        ((EditorButtonControlBase) this.dtOfacCleared).ReadOnly = true;
        ((UltraDateTimeEditor) this.dtOfacCleared).DropDownButtonDisplayStyle = (ButtonDisplayStyle) 0;
      }
    }
    this._autoLineRatedWithNetRate = DefaultDatabase.ExecuteScalar<bool?>("dbo.AutoLineRatedWithNetRate", new object[2]
    {
      (object) "@QuoteID",
      (object) this._quote.QuoteID
    }) ?? false;
    if (this.AutoLineRatedWithNetRate)
      ((UltraTabControlBase) this.UltraTabControl1).Tabs[2].Visible = true;
    dsAdditionalInterests.tblAdditionalInterestsRow row = this.ds.tblAdditionalInterests.NewtblAdditionalInterestsRow();
    row.Interest = string.Empty;
    this.ds.tblAdditionalInterests.AddtblAdditionalInterestsRow(row);
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblAdditionalInterests, CommandType.Text, "SELECT InterestID, Interest, Address1, Address2, City, County, StateID, Region, ISOCountryCode, ZipCode, ZipPlus FROM dbo.tblAdditionalInterests WITH(NOLOCK) ORDER BY Interest");
    DefaultDatabase.LoadDataTable((DataTable) this.ds.dtPreviousInterest, CommandType.Text, "SELECT ID, PreviousAdditionalInterestGuid FROM tblQuoteAdditionalInterests WITH (NOLOCK) WHERE  QuoteID = @QID AND PreviousAdditionalInterestGuid IS NOT NULL", new object[2]
    {
      (object) "@QID",
      (object) this._quote.QuoteID
    });
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstLines, "dbo.GetAdditionalInterestLines", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    this.daInterests.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    DefaultDatabase.DataAdapterFill(this.daInterests, (DataTable) this.ds.tblQuoteAdditionalInterests);
    this.FillInterestTypes();
    this.daQuoteInterestTypes.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    DefaultDatabase.DataAdapterFill(this.daQuoteInterestTypes, (DataTable) this.ds.tblQuoteAdditionalInterestTypes);
    this._daUnderwritingLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    this._daNetRateLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    this.FillUnderwritingLocations();
    this.FillNetRateVehicles();
    this._daQuoteLocations.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    this._daQuoteLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    this._daQuoteNetRateLocations.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    this.daQuoteNetRateVehicles.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    List<string> stringList = new List<string>();
    if (this.UsingNetRate)
    {
      this.dsAdditionalInterests.EnforceConstraints = false;
      DefaultDatabase.DataAdapterFill(this._daQuoteNetRateLocations, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations);
      this.dsAdditionalInterests.EnforceConstraints = true;
    }
    else
    {
      try
      {
        DefaultDatabase.DataAdapterFill(this._daQuoteLocations, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations);
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors(this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.DataSet, ex);
        ProjectData.ClearProjectError();
      }
    }
    if (this.AutoLineRatedWithNetRate)
    {
      this.dsAdditionalInterests.EnforceConstraints = false;
      stringList.AddRange((IEnumerable<string>) this.CheckDeletedNetRateVehicles());
      DefaultDatabase.DataAdapterFill(this.daQuoteNetRateVehicles, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles);
      this.dsAdditionalInterests.EnforceConstraints = true;
    }
    MGASystems.Tools.DBSaveUI.DBSaveUI dbSave = this.dbSave;
    dbSave.AutoQueryRowCountOnLoad = false;
    dbSave.EditStyle = (EditStyle) 1;
    dbSave.UIState = (UIState) 0;
    this._allowAddingAdditionalInterest = !frmAdditionalInterests.LockDownOnIssuance(this._quote);
    this.SetDocumentProcessSelection(false);
    this.EnableDisableControls();
  }

  private bool AddedLocationsAndVehicles()
  {
    bool flag;
    if (this.bmb.Position == -1)
      flag = false;
    else if (!this._CheckNewVehiclesAndLocations.Value)
    {
      flag = false;
    }
    else
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
      if (currentInterestRow.RowState == DataRowState.Deleted || currentInterestRow.RowState == DataRowState.Added)
      {
        flag = false;
      }
      else
      {
        int id = currentInterestRow.ID;
        if (((CheckedListBox) this.lstUnderwritingLocations).CheckedItems.Count == this._currentLocations.Count)
        {
          HashSet<int> currentLocations = this._currentLocations;
          IEnumerable<UnderwritingLocation> source1 = ((CheckedListBox) this.lstUnderwritingLocations).CheckedItems.OfType<UnderwritingLocation>();
          System.Func<UnderwritingLocation, int> selector1;
          // ISSUE: reference to a compiler-generated field
          if (frmAdditionalInterests._Closure\u0024__.\u0024I349\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector1 = frmAdditionalInterests._Closure\u0024__.\u0024I349\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            frmAdditionalInterests._Closure\u0024__.\u0024I349\u002D0 = selector1 = (System.Func<UnderwritingLocation, int>) ([SpecialName] (uwloc) => uwloc.LocationID);
          }
          IEnumerable<int> second1 = source1.Select<UnderwritingLocation, int>(selector1);
          if (!currentLocations.Except<int>(second1).Any<int>())
          {
            if (this.lstVehicles.CheckedItems.Count == this._currentVehicles.Count)
            {
              HashSet<int> currentVehicles = this._currentVehicles;
              IEnumerable<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle> source2 = this.lstVehicles.CheckedItems.OfType<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle>();
              System.Func<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle, int> selector2;
              // ISSUE: reference to a compiler-generated field
              if (frmAdditionalInterests._Closure\u0024__.\u0024I349\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                selector2 = frmAdditionalInterests._Closure\u0024__.\u0024I349\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                frmAdditionalInterests._Closure\u0024__.\u0024I349\u002D1 = selector2 = (System.Func<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle, int>) ([SpecialName] (vehicle) => vehicle.VehicleID);
              }
              IEnumerable<int> second2 = source2.Select<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle, int>(selector2);
              if (!currentVehicles.Except<int>(second2).Any<int>())
              {
                flag = false;
                goto label_19;
              }
            }
            flag = true;
            goto label_19;
          }
        }
        flag = true;
      }
    }
label_19:
    return flag;
  }

  protected virtual void ShowSelectedInterestTypes()
  {
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
    if (currentInterestRow.RowState == DataRowState.Deleted)
      return;
    ((Control) this.lstInterestTypes).Tag = (object) true;
    int id = currentInterestRow.ID;
    int num = ((CheckedListBox) this.lstInterestTypes).Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      InterestType interestType = (InterestType) ((CheckedListBox) this.lstInterestTypes).Items[index];
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow additionalInterestType = this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.FindByAdditionalInterestIDAdditionalInterestType(id, interestType.InterestType);
      if (interestType.IsDisabled && additionalInterestType == null)
        ((CheckedListBox) this.lstInterestTypes).SetItemCheckState(index, CheckState.Indeterminate);
      else
        ((CheckedListBox) this.lstInterestTypes).SetItemChecked(index, additionalInterestType != null);
    }
    ((Control) this.lstInterestTypes).Tag = (object) null;
  }

  protected virtual bool IsClientDisabledAi(
    dsAdditionalInterests.lstAdditionalInterestTypesRow dr)
  {
    return false;
  }

  private void ShowCurrentLocations()
  {
    this._currentLocations.Clear();
    this.ShowSelectedLocations();
    try
    {
      foreach (UnderwritingLocation underwritingLocation in ((CheckedListBox) this.lstUnderwritingLocations).CheckedItems.OfType<UnderwritingLocation>())
        this._currentLocations.Add(underwritingLocation.LocationID);
    }
    finally
    {
      IEnumerator<UnderwritingLocation> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual void ShowSelectedLocations()
  {
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
    Func<dsAdditionalInterests.tblQuoteAdditionalInterestsRow, UnderwritingLocation, DataRow> func = new Func<dsAdditionalInterests.tblQuoteAdditionalInterestsRow, UnderwritingLocation, DataRow>(this.FindAdditionalInterestLocation);
    if (this.UsingNetRate)
      func = new Func<dsAdditionalInterests.tblQuoteAdditionalInterestsRow, UnderwritingLocation, DataRow>(this.FindNetRateLocation);
    int num = ((CheckedListBox) this.lstUnderwritingLocations).Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      UnderwritingLocation underwritingLocation = (UnderwritingLocation) ((CheckedListBox) this.lstUnderwritingLocations).Items[index];
      DataRow dataRow = func(currentInterestRow, underwritingLocation);
      ((CheckedListBox) this.lstUnderwritingLocations).SetItemChecked(index, dataRow != null);
    }
  }

  private DataRow FindNetRateLocation(
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow interest,
    UnderwritingLocation location)
  {
    return interest == null || interest.RowState == DataRowState.Deleted ? (DataRow) null : (DataRow) this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.FindByAdditionalInterestIDNetRateLocationIDNetRateBuildingNumber(interest.ID, location.LocationID, location.BuildingNumber);
  }

  private DataRow FindAdditionalInterestLocation(
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow interest,
    UnderwritingLocation location)
  {
    return interest == null || interest.RowState == DataRowState.Deleted ? (DataRow) null : (DataRow) this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.FindByAdditionalInterestIDUnderwritingLocationID(interest.ID, location.LocationID);
  }

  private void ShowCurrentVehicles()
  {
    this._currentVehicles.Clear();
    this.ShowSelectedVehicles();
    try
    {
      foreach (MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle netRateVehicle in this.lstVehicles.CheckedItems.OfType<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle>())
        this._currentVehicles.Add(netRateVehicle.VehicleID);
    }
    finally
    {
      IEnumerator<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual void ShowSelectedVehicles()
  {
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
    bool flag = currentInterestRow != null && currentInterestRow.RowState != DataRowState.Deleted;
    int num = this.lstVehicles.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle netRateVehicle = (MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle) this.lstVehicles.Items[index];
      dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow interestIdVehicleId = flag ? this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.FindByAdditionalInterestIDVehicleID(currentInterestRow.ID, netRateVehicle.VehicleID) : (dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) null;
      this.lstVehicles.SetItemChecked(index, interestIdVehicleId != null);
    }
  }

  protected virtual void FillUnderwritingLocations()
  {
    Cursor.Current = MgaCursors.Default;
    MDIControls.Instance.StatusBarText = "Filling underwriting locations...";
    if (this.UsingNetRate)
    {
      try
      {
        this.dsAdditionalInterests.EnforceConstraints = false;
        this.dsAdditionalInterests.tblNetRateLocations.Clear();
        DefaultDatabase.DataAdapterFill(this._daNetRateLocations, (DataTable) this.dsAdditionalInterests.tblNetRateLocations);
        this.dsAdditionalInterests.EnforceConstraints = true;
        ((CheckedListBox) this.lstUnderwritingLocations).Items.Clear();
        try
        {
          foreach (dsAdditionalInterests.tblNetRateLocationsRow tblNetRateLocation in (TypedTableBase<dsAdditionalInterests.tblNetRateLocationsRow>) this.dsAdditionalInterests.tblNetRateLocations)
          {
            string locationDisplayAs = this.GetNetRateUnderwritingLocationDisplayAs(ref tblNetRateLocation);
            ((CheckedListBox) this.lstUnderwritingLocations).Items.Add((object) new UnderwritingLocation(tblNetRateLocation.LocationID, locationDisplayAs, tblNetRateLocation.BuildingNumber));
          }
        }
        finally
        {
          IEnumerator<dsAdditionalInterests.tblNetRateLocationsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      finally
      {
        MDIControls.Instance.StatusBarText = string.Empty;
        Cursor.Current = MgaCursors.Default;
      }
    }
    else
    {
      try
      {
        this.dsAdditionalInterests.EnforceConstraints = false;
        this.dsAdditionalInterests.tblUnderwritingLocations.Clear();
        DefaultDatabase.DataAdapterFill(this._daUnderwritingLocations, (DataTable) this.dsAdditionalInterests.tblUnderwritingLocations);
        this.dsAdditionalInterests.EnforceConstraints = true;
        ((CheckedListBox) this.lstUnderwritingLocations).Items.Clear();
        try
        {
          foreach (dsAdditionalInterests.tblUnderwritingLocationsRow underwritingLocation in (TypedTableBase<dsAdditionalInterests.tblUnderwritingLocationsRow>) this.dsAdditionalInterests.tblUnderwritingLocations)
            ((CheckedListBox) this.lstUnderwritingLocations).Items.Add((object) new UnderwritingLocation(underwritingLocation.LocationID, $"Loc #{underwritingLocation.LocationNo}, Bldg {underwritingLocation.BuildingNo} - {underwritingLocation.PhysicalBuildingNo} {underwritingLocation.Address1}, {underwritingLocation.City}, {underwritingLocation.State}"));
        }
        finally
        {
          IEnumerator<dsAdditionalInterests.tblUnderwritingLocationsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      finally
      {
        MDIControls.Instance.StatusBarText = string.Empty;
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  protected virtual string GetNetRateUnderwritingLocationDisplayAs(
    ref dsAdditionalInterests.tblNetRateLocationsRow dr)
  {
    string str1 = dr.IsAddressNull() ? string.Empty : dr.Address + ", ";
    string str2 = dr.IsCityNull() ? string.Empty : dr.City + ", ";
    string str3 = dr.IsStateNull() ? string.Empty : dr.State + ", ";
    return $"Loc #{dr.LocationNumber}, Bldg {dr.BuildingNumber} - {str1}{str2}{str3}";
  }

  protected virtual void FillNetRateVehicles()
  {
    if (!this.AutoLineRatedWithNetRate)
      return;
    this.dsAdditionalInterests.EnforceConstraints = false;
    this.dsAdditionalInterests.tblNetRateVehicles.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsAdditionalInterests.tblNetRateVehicles, "dbo.GetNetRateVehicles", new object[2]
    {
      (object) "@quoteID",
      (object) this.Quote.QuoteID
    });
    this.dsAdditionalInterests.EnforceConstraints = true;
    this.lstVehicles.Items.Clear();
    try
    {
      foreach (dsAdditionalInterests.tblNetRateVehiclesRow tblNetRateVehicle in (TypedTableBase<dsAdditionalInterests.tblNetRateVehiclesRow>) this.dsAdditionalInterests.tblNetRateVehicles)
        this.lstVehicles.Items.Add((object) new MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle(tblNetRateVehicle.VehicleID, tblNetRateVehicle.VehicleUnitNumber, this.GetNetRateVehicleDisplay(tblNetRateVehicle), tblNetRateVehicle.LocationID));
    }
    finally
    {
      IEnumerator<dsAdditionalInterests.tblNetRateVehiclesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual string GetNetRateVehicleDisplay(dsAdditionalInterests.tblNetRateVehiclesRow row)
  {
    return $"{row.VehicleNumber} - {row.Make}/{row.Model}/{row.Year}/{row.VIN}";
  }

  protected virtual void LoadDataset()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstAdditionalInterestTypes, CommandType.Text, "SELECT InterestType, AdditionalInterest, AddressRequired, LocationRequired, VehicleRequired, ISNULL(IsDisabled,0) AS IsDisabled FROM dbo.lstAdditionalInterestTypes WITH(NOLOCK) WHERE IsNetrate <> 1 ORDER BY IsDisabled, AdditionalInterest");
  }

  protected virtual void FillInterestTypes()
  {
    this.LoadDataset();
    try
    {
      foreach (dsAdditionalInterests.lstAdditionalInterestTypesRow additionalInterestType in (TypedTableBase<dsAdditionalInterests.lstAdditionalInterestTypesRow>) this.dsAdditionalInterests.lstAdditionalInterestTypes)
      {
        if (additionalInterestType.IsDisabled || this.IsClientDisabledAi(additionalInterestType))
        {
          additionalInterestType.AdditionalInterest = "DISABLED - " + additionalInterestType.AdditionalInterest;
          additionalInterestType.IsDisabled = true;
        }
        ((CheckedListBox) this.lstInterestTypes).Items.Add((object) new InterestType(additionalInterestType.InterestType, additionalInterestType.AdditionalInterest, additionalInterestType.AddressRequired, additionalInterestType.LocationRequired, additionalInterestType.VehicleRequired, additionalInterestType.IsDisabled));
      }
    }
    finally
    {
      IEnumerator<dsAdditionalInterests.lstAdditionalInterestTypesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void lnkLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this.OpenUnderwritingLocationForm(this.Quote))
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      this.FillUnderwritingLocations();
      this.ShowSelectedLocations();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual bool OpenUnderwritingLocationForm(Quote quote)
  {
    bool flag;
    if (!this.CanOpenUnderwritingLocationForm(quote))
    {
      flag = false;
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmUnderwritingLocations), new object[2]
      {
        (object) this._quote.QuoteGuid,
        (object) this.CanModifyUnderwritingLocations(quote)
      }))
        ;
      flag = true;
    }
    return flag;
  }

  protected virtual bool CanOpenUnderwritingLocationForm(Quote quote) => true;

  protected virtual bool CanModifyUnderwritingLocations(Quote quote)
  {
    bool flag;
    if (SystemSettings.GetSetting<bool>("AdditionalInterests.UnderwritingLocations.CheckSupport", false))
    {
      try
      {
        List<QuoteDetail> quoteDetails = quote.QuoteDetails;
        System.Func<QuoteDetail, bool> func1;
        // ISSUE: reference to a compiler-generated field
        if (frmAdditionalInterests._Closure\u0024__.\u0024I367\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          func1 = frmAdditionalInterests._Closure\u0024__.\u0024I367\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmAdditionalInterests._Closure\u0024__.\u0024I367\u002D0 = func1 = (System.Func<QuoteDetail, bool>) ([SpecialName] (qd) => qd.IsRaterAssigned());
        }
        System.Func<QuoteDetail, int?> func2;
        // ISSUE: reference to a compiler-generated field
        if (frmAdditionalInterests._Closure\u0024__.\u0024I367\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          func2 = frmAdditionalInterests._Closure\u0024__.\u0024I367\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmAdditionalInterests._Closure\u0024__.\u0024I367\u002D1 = func2 = (System.Func<QuoteDetail, int?>) ([SpecialName] (qd) => qd.RaterID);
        }
        foreach (int? nullable in CollectionExtensions.WhereSelect<QuoteDetail, int?>((IEnumerable<QuoteDetail>) quoteDetails, func1, func2).Distinct<int?>())
        {
          if (RaterFactory.GetRater(nullable.Value).SupportsUnderwritingLocations)
          {
            flag = false;
            goto label_15;
          }
        }
      }
      finally
      {
        IEnumerator<int?> enumerator;
        enumerator?.Dispose();
      }
    }
    flag = true;
label_15:
    return flag;
  }

  private bool ValidForm()
  {
    // ISSUE: variable of a compiler-generated type
    frmAdditionalInterests._Closure\u0024__368\u002D0 closure3680_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmAdditionalInterests._Closure\u0024__368\u002D0 closure3680_2 = new frmAdditionalInterests._Closure\u0024__368\u002D0(closure3680_1);
    // ISSUE: reference to a compiler-generated field
    closure3680_2.\u0024VB\u0024Me = this;
    bool flag = true;
    this.err.SetError((Control) this.txtInsuredName, string.Empty);
    this.err.SetError((Control) this.lstInterestTypes, string.Empty);
    this.err.SetError((Control) this.lstVehicles, string.Empty);
    this.err.SetError((Control) this.lstUnderwritingLocations, string.Empty);
    ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.UltraTabPageControl1.Tab;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtInsuredName).Text))
    {
      this.err.SetError((Control) this.txtInsuredName, "Please enter a name for this insured.");
      flag = false;
    }
    if (((CheckedListBox) this.lstInterestTypes).CheckedIndices.Count == 0)
    {
      this.err.SetError((Control) this.lstInterestTypes, "Please select an interest type.");
      flag = false;
      ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.UltraTabPageControl1.Tab;
    }
    if (flag)
    {
      if (this.lstVehicles.Items.Count > 0 && this.VehicleRequired() && this.lstVehicles.CheckedIndices.Count == 0)
      {
        this.err.SetError((Control) this.lstVehicles, "Please select a Vehicle.");
        flag = false;
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.UltraTabPageControl5.Tab;
      }
      if (((CheckedListBox) this.lstUnderwritingLocations).Items.Count > 0 && this.LocationRequired() && ((CheckedListBox) this.lstUnderwritingLocations).CheckedIndices.Count == 0)
      {
        this.err.SetError((Control) this.lstUnderwritingLocations, "Please select an Underwriting Location.");
        flag = false;
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.UltraTabPageControl2.Tab;
      }
    }
    IEnumerator<InterestType> enumerator;
    if (flag & this.ClientAddressRequired())
    {
      try
      {
        IEnumerable<InterestType> source = this.CheckedOnlyItems<InterestType>((CheckedListBox) this.lstInterestTypes);
        System.Func<InterestType, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (frmAdditionalInterests._Closure\u0024__.\u0024I368\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = frmAdditionalInterests._Closure\u0024__.\u0024I368\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmAdditionalInterests._Closure\u0024__.\u0024I368\u002D0 = predicate = (System.Func<InterestType, bool>) ([SpecialName] (aiType) => aiType.AddressRequired);
        }
        enumerator = source.Where<InterestType>(predicate).GetEnumerator();
        if (enumerator.MoveNext())
        {
          InterestType current = enumerator.Current;
          flag = this.ZipCodeResolver1.ValidateFields();
          if (!flag)
            ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = this.UltraTabPageControl1.Tab;
        }
      }
      finally
      {
        enumerator?.Dispose();
      }
    }
    if (flag)
      this.ZipCodeResolver1.ClearErrors();
    this.bmb.EndCurrentEdit();
    // ISSUE: reference to a compiler-generated field
    closure3680_2.\u0024VB\u0024Local_currentInterest = this.CurrentInterestRow;
    // ISSUE: reference to a compiler-generated method
    Lazy<dsAdditionalInterests.tblQuoteAdditionalInterestsRow[]> lazy = new Lazy<dsAdditionalInterests.tblQuoteAdditionalInterestsRow[]>(new Func<dsAdditionalInterests.tblQuoteAdditionalInterestsRow[]>(closure3680_2._Lambda\u0024__1));
    // ISSUE: reference to a compiler-generated field
    if (closure3680_2.\u0024VB\u0024Local_currentInterest.Billable && lazy.Value.Length > 0)
    {
      if (MessageBox.Show($"Only one interest can be marked as billable.{"\n"}{"\n"}Would you Like to switch the billable interest to the current selection?", "Multiple Billable Interests", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        dsAdditionalInterests.tblQuoteAdditionalInterestsRow[] additionalInterestsRowArray = lazy.Value;
        int index = 0;
        while (index < additionalInterestsRowArray.Length)
        {
          additionalInterestsRowArray[index].Billable = false;
          checked { ++index; }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        closure3680_2.\u0024VB\u0024Local_currentInterest.Billable = false;
      }
    }
    return flag;
  }

  protected virtual bool ClientAddressRequired() => true;

  protected virtual bool VehicleRequired()
  {
    IEnumerable<InterestType> source = this.CheckedOnlyItems<InterestType>((CheckedListBox) this.lstInterestTypes);
    System.Func<InterestType, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (frmAdditionalInterests._Closure\u0024__.\u0024I370\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = frmAdditionalInterests._Closure\u0024__.\u0024I370\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmAdditionalInterests._Closure\u0024__.\u0024I370\u002D0 = predicate = (System.Func<InterestType, bool>) ([SpecialName] (itype) => itype.VehicleRequired);
    }
    return source.Any<InterestType>(predicate);
  }

  private bool LocationRequired()
  {
    IEnumerable<InterestType> source = this.CheckedOnlyItems<InterestType>((CheckedListBox) this.lstInterestTypes);
    System.Func<InterestType, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (frmAdditionalInterests._Closure\u0024__.\u0024I371\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = frmAdditionalInterests._Closure\u0024__.\u0024I371\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmAdditionalInterests._Closure\u0024__.\u0024I371\u002D0 = predicate = (System.Func<InterestType, bool>) ([SpecialName] (itype) => itype.LocationRequired);
    }
    return source.Any<InterestType>(predicate);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.dbSave_ClickingNew_Method();
  }

  protected virtual void dbSave_ClickingNew_Method()
  {
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow row = this.dsAdditionalInterests.tblQuoteAdditionalInterests.NewtblQuoteAdditionalInterestsRow();
    row.AdditionalInterestGuid = Guid.NewGuid();
    row.QuoteID = this._quote.QuoteID;
    row.SetOfacClearedNull();
    this.dsAdditionalInterests.tblQuoteAdditionalInterests.AddtblQuoteAdditionalInterestsRow(row);
    this.bmb.Position = this.dsAdditionalInterests.tblQuoteAdditionalInterests.Count - 1;
    this.ShowSelectedInterestTypes();
    this.ShowCurrentLocations();
    this.ShowCurrentVehicles();
    this.OnClientNewInterest();
  }

  protected virtual bool ShouldCheckNewOfacEntity(
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow aiRow)
  {
    return !this._skipOfacOnNewInterest.Value;
  }

  protected virtual bool ShouldCheckModifiedOfacEntity(
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow aiRow)
  {
    return !this._skipOfacOnModifiedInterest.Value;
  }

  protected virtual bool HasAdditionalInterestDataChanged(
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow aiRow)
  {
    return this.AnyColumnsChanged(aiRow, "InterestName", "FirstName", "LastName", "Address1", "Address2", "City", "StateID", "ISOCountryCode");
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      e.Cancel = true;
    else if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow additionalInterest = this.ds.tblQuoteAdditionalInterests[this.bmb.Position];
      bool flag = ((UltraToggleEditorBase) this.chkRunOFAC).Checked || this._runOfacOnAdditionalInterest.Value && (additionalInterest.RowState == DataRowState.Added && this.ShouldCheckNewOfacEntity(additionalInterest) || additionalInterest.RowState == DataRowState.Modified && this.ShouldCheckModifiedOfacEntity(additionalInterest) && this.HasAdditionalInterestDataChanged(additionalInterest));
      string text = ((TextEditorControlBase) this.txtInsuredName).Text;
      Guid additionalInterestGuid = additionalInterest.AdditionalInterestGuid;
      if (!this.SaveData())
      {
        e.Cancel = true;
      }
      else
      {
        if (!flag)
          return;
        this.RunOfacCheckOnAdditionalInterest(additionalInterestGuid, text);
      }
    }
  }

  protected bool AnyColumnsChanged(
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow aiRow,
    params string[] columnNames)
  {
    dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable table = aiRow.Table as dsAdditionalInterests.tblQuoteAdditionalInterestsDataTable;
    return ((IEnumerable<string>) columnNames).Select<string, DataColumn>((System.Func<string, DataColumn>) ([SpecialName] (cn) => table.Columns[cn])).Any<DataColumn>((System.Func<DataColumn, bool>) ([SpecialName] (dc) => dc.DataType.Equals(typeof (string)) && !StringExtensions.EqualsNoCase(aiRow.Field<string>(dc, DataRowVersion.Original), aiRow.Field<string>(dc))));
  }

  protected virtual bool ShouldSearchAdditionalInterestOfac()
  {
    bool flag;
    if (((UltraToggleEditorBase) this.chkRunOFAC).Checked)
      flag = true;
    else if (this._ofacAITypes.Count == 0)
    {
      flag = false;
    }
    else
    {
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
      HashSet<string> ofacAiTypes = this._ofacAITypes;
      dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow[] source = currentInterestRow.GettblQuoteAdditionalInterestTypesRows();
      System.Func<dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmAdditionalInterests._Closure\u0024__.\u0024I379\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmAdditionalInterests._Closure\u0024__.\u0024I379\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmAdditionalInterests._Closure\u0024__.\u0024I379\u002D0 = selector = (System.Func<dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow, string>) ([SpecialName] (aitype) => aitype.AdditionalInterestType);
      }
      IEnumerable<string> second = ((IEnumerable<dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow>) source).Select<dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow, string>(selector);
      flag = ofacAiTypes.Intersect<string>(second).Any<string>();
    }
    return flag;
  }

  protected virtual void RunOfacCheckOnAdditionalInterest(
    Guid additionalInterestGuid,
    string additionalInterestName)
  {
    if (!this.ShouldSearchAdditionalInterestOfac())
      return;
    OfacSystem.OfacStatus ofacStatus = (OfacSystem.OfacStatus) null;
    if (!this._ofacData.TryGetValue(additionalInterestGuid, out ofacStatus) || ofacStatus == null)
    {
      ofacStatus = OfacSystem.Instance.GetEntityStatus(additionalInterestGuid, new Guid?(this.Quote.ControlGuid));
      this._ofacData[additionalInterestGuid] = ofacStatus;
    }
    AdditionalInterest additionalInterest = new AdditionalInterest(additionalInterestGuid);
    if (((UltraToggleEditorBase) this.chkRunOFAC).Checked || !((IEnumerable<string>) additionalInterest.AdditionalInterestTypes).Intersect<string>((IEnumerable<string>) this._ofacAITypes).Any<string>())
    {
      ((UltraToggleEditorBase) this.chkRunOFAC).Checked = false;
      string text = $"Contine and run a compliance check on \"{additionalInterestName}\"?";
      if (ofacStatus != null)
        text = $"Search Date - {ofacStatus.LogDate}{"\n"}{(!ofacStatus.OFACCleared ? (object) ofacStatus.HitMessage : (object) "In Compliance")}{"\n"}{text}";
      if (MessageBox.Show(text, "Run Compliance Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
    }
    Task.Run<OfacSystem.OfacResult>((Func<OfacSystem.OfacResult>) ([SpecialName] () => OfacSystem.Instance.CheckOfacResult<AdditionalInterest>(additionalInterest))).ContinueWith((Action<Task>) ([SpecialName] (tResult) => this.ShowOfacInterestsData()), TaskScheduler.FromCurrentSynchronizationContext());
  }

  protected virtual void EnableDisableControls()
  {
    if (this._quote == null)
      return;
    bool flag = this.dbSave.UIState == 2;
    try
    {
      IEnumerable<UltraTab> source = ((IEnumerable) ((UltraTabControlBase) this.UltraTabControl1).Tabs).OfType<UltraTab>();
      System.Func<UltraTab, IEnumerable<Control>> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmAdditionalInterests._Closure\u0024__.\u0024I381\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmAdditionalInterests._Closure\u0024__.\u0024I381\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmAdditionalInterests._Closure\u0024__.\u0024I381\u002D0 = selector = (System.Func<UltraTab, IEnumerable<Control>>) ([SpecialName] (t) => ((Control) t.TabPage).Controls.OfType<Control>());
      }
      foreach (Control control in source.SelectMany<UltraTab, Control>(selector))
      {
        if (!CollectionExtensions.ValueIn<Control>(control, new Control[8]
        {
          (Control) this.dbSave,
          (Control) this.lnkLocations,
          (Control) this.lnkCof,
          (Control) this.lnkMailCertificate,
          (Control) this.lstInterestTypes,
          (Control) this.lstUnderwritingLocations,
          (Control) this.lstVehicles,
          (Control) this.linkTemplateDocuments
        }))
          control.Enabled = flag;
      }
    }
    finally
    {
      IEnumerator<Control> enumerator;
      enumerator?.Dispose();
    }
    ((Control) this.ugInterests).Enabled = !flag;
    this.Panel1.Enabled = flag;
    ((Control) this.btnSearch).Enabled = flag;
    ((Control) this.txtVINSearch).Enabled = flag;
    ((Control) this.dbSave).Enabled = this._allowAddingAdditionalInterest;
    this.lnkDeselectAllCopy.Enabled = true;
    this.lnkSelectAllCopy.Enabled = true;
    this.lnkCopyAll.Enabled = true;
    ((Control) this.dtOfacCleared).Enabled = flag && ((UltraDateTimeEditor) this.dtOfacCleared).Value == null;
    this.EnableCheckListBoxes((flag ? 1 : 0) != 0, (CheckedListBox) this.lstUnderwritingLocations, (CheckedListBox) this.lstInterestTypes);
    this.EnableCheckListBoxes((!flag ? 0 : (!this._quote.IsBound ? 1 : (!this._quote.PolicyIsIssued ? 1 : 0))) != 0, this.lstVehicles);
  }

  private void EnableCheckListBoxes(bool isEditing, params CheckedListBox[] checkListBoxes)
  {
    CheckedListBox[] checkedListBoxArray = checkListBoxes;
    int index = 0;
    while (index < checkedListBoxArray.Length)
    {
      CheckedListBox checkedListBox = checkedListBoxArray[index];
      if (isEditing)
      {
        checkedListBox.SelectionMode = SelectionMode.One;
        checkedListBox.BackColor = Color.FromKnownColor(KnownColor.Window);
      }
      else
      {
        checkedListBox.SelectionMode = SelectionMode.None;
        checkedListBox.BackColor = Color.FromKnownColor(KnownColor.Control);
      }
      checked { ++index; }
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.EnableDisableControls();

  [Obsolete("Use System.Data.Common arguments instead of System.Data.SqlClient arguments", false)]
  protected virtual void SaveInterestTypes(SqlTransaction t, int additionalInterestID)
  {
  }

  protected virtual void SaveInterestTypes(DbTransaction t, int additionalInterestID)
  {
    if (t is SqlTransaction)
    {
      this.SaveInterestTypes(t as SqlTransaction, additionalInterestID);
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteAdditionalInterestTypes WHERE AdditionalInterestID=@ID", new object[2]
      {
        (object) "@ID",
        (object) additionalInterestID
      });
      DataRow[] dataRowArray = this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.Select("AdditionalInterestID=" + additionalInterestID.ToString());
      int index = 0;
      while (index < dataRowArray.Length)
      {
        this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.RemovetblQuoteAdditionalInterestTypesRow((dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) dataRowArray[index]);
        checked { ++index; }
      }
      try
      {
        foreach (InterestType checkedOnlyItem in this.CheckedOnlyItems<InterestType>((CheckedListBox) this.lstInterestTypes))
        {
          dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow row = this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.NewtblQuoteAdditionalInterestTypesRow();
          row.AdditionalInterestID = additionalInterestID;
          row.AdditionalInterestType = checkedOnlyItem.InterestType;
          this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.AddtblQuoteAdditionalInterestTypesRow(row);
        }
      }
      finally
      {
        IEnumerator<InterestType> enumerator;
        enumerator?.Dispose();
      }
      this.AssignTransaction(this.daQuoteInterestTypes, t);
      DefaultDatabase.DataAdapterUpdate(this.daQuoteInterestTypes, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes);
    }
  }

  [Obsolete("Use System.Data.Common arguments instead of System.Data.SqlClient arguments", false)]
  protected virtual void SaveInterestLocations(SqlTransaction t, int additionalInterestID)
  {
  }

  protected virtual void SaveInterestLocations(DbTransaction t, int additionalInterestID)
  {
    // ISSUE: variable of a compiler-generated type
    frmAdditionalInterests._Closure\u0024__387\u002D0 closure3870_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmAdditionalInterests._Closure\u0024__387\u002D0 closure3870_2 = new frmAdditionalInterests._Closure\u0024__387\u002D0(closure3870_1);
    // ISSUE: reference to a compiler-generated field
    closure3870_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure3870_2.\u0024VB\u0024Local_t = t;
    // ISSUE: reference to a compiler-generated field
    closure3870_2.\u0024VB\u0024Local_additionalInterestID = additionalInterestID;
    // ISSUE: reference to a compiler-generated field
    if (closure3870_2.\u0024VB\u0024Local_t is SqlTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.SaveInterestLocations(closure3870_2.\u0024VB\u0024Local_t as SqlTransaction, closure3870_2.\u0024VB\u0024Local_additionalInterestID);
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      if (closure3870_2.\u0024VB\u0024Local_t != null && !DefaultDatabase.HasTransaction)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: method pointer
        DefaultDatabase.EnlistTransaction(closure3870_2.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure3870_2, __methodptr(_Lambda\u0024__0)));
      }
      else if (this.UsingNetRate)
      {
        // ISSUE: reference to a compiler-generated field
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteAdditionalInterestsNetRateLocations WHERE AdditionalInterestID = @ID", new object[2]
        {
          (object) "@ID",
          (object) closure3870_2.\u0024VB\u0024Local_additionalInterestID
        });
        // ISSUE: reference to a compiler-generated field
        DataRow[] dataRowArray = this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.Select($"AdditionalInterestID={closure3870_2.\u0024VB\u0024Local_additionalInterestID}");
        int index = 0;
        while (index < dataRowArray.Length)
        {
          this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.RemovetblQuoteAdditionalInterestsNetRateLocationsRow((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) dataRowArray[index]);
          checked { ++index; }
        }
        try
        {
          foreach (UnderwritingLocation underwritingLocation in ((CheckedListBox) this.lstUnderwritingLocations).CheckedItems.OfType<UnderwritingLocation>())
          {
            dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow row = this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.NewtblQuoteAdditionalInterestsNetRateLocationsRow();
            // ISSUE: reference to a compiler-generated field
            row.AdditionalInterestID = closure3870_2.\u0024VB\u0024Local_additionalInterestID;
            row.NetRateLocationID = underwritingLocation.LocationID;
            row.NetRateBuildingNumber = underwritingLocation.BuildingNumber;
            this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.AddtblQuoteAdditionalInterestsNetRateLocationsRow(row);
          }
        }
        finally
        {
          IEnumerator<UnderwritingLocation> enumerator;
          enumerator?.Dispose();
        }
        // ISSUE: reference to a compiler-generated field
        this.AssignTransaction(this._daQuoteNetRateLocations, closure3870_2.\u0024VB\u0024Local_t);
        DefaultDatabase.DataAdapterUpdate(this._daQuoteNetRateLocations, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteAdditionalInterestsLocations WHERE AdditionalInterestID=@ID", new object[2]
        {
          (object) "@ID",
          (object) closure3870_2.\u0024VB\u0024Local_additionalInterestID
        });
        // ISSUE: reference to a compiler-generated field
        DataRow[] dataRowArray = this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.Select("AdditionalInterestID=" + closure3870_2.\u0024VB\u0024Local_additionalInterestID.ToString());
        int index = 0;
        while (index < dataRowArray.Length)
        {
          this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.RemovetblQuoteAdditionalInterestsLocationsRow((dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) dataRowArray[index]);
          checked { ++index; }
        }
        try
        {
          foreach (UnderwritingLocation underwritingLocation in ((CheckedListBox) this.lstUnderwritingLocations).CheckedItems.OfType<UnderwritingLocation>())
          {
            dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow row = this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.NewtblQuoteAdditionalInterestsLocationsRow();
            // ISSUE: reference to a compiler-generated field
            row.AdditionalInterestID = closure3870_2.\u0024VB\u0024Local_additionalInterestID;
            row.UnderwritingLocationID = underwritingLocation.LocationID;
            this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.AddtblQuoteAdditionalInterestsLocationsRow(row);
          }
        }
        finally
        {
          IEnumerator<UnderwritingLocation> enumerator;
          enumerator?.Dispose();
        }
        // ISSUE: reference to a compiler-generated field
        this.AssignTransaction(this._daQuoteLocations, closure3870_2.\u0024VB\u0024Local_t);
        DefaultDatabase.DataAdapterUpdate(this._daQuoteLocations, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations);
      }
    }
  }

  [Obsolete("Use System.Data.Common arguments instead of System.Data.SqlClient arguments", false)]
  protected virtual void SaveInterestVehicles(SqlTransaction t, int additionalInterestID)
  {
  }

  protected virtual void SaveInterestVehicles(DbTransaction t, int additionalInterestID)
  {
    // ISSUE: variable of a compiler-generated type
    frmAdditionalInterests._Closure\u0024__389\u002D0 closure3890_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmAdditionalInterests._Closure\u0024__389\u002D0 closure3890_2 = new frmAdditionalInterests._Closure\u0024__389\u002D0(closure3890_1);
    // ISSUE: reference to a compiler-generated field
    closure3890_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure3890_2.\u0024VB\u0024Local_t = t;
    // ISSUE: reference to a compiler-generated field
    closure3890_2.\u0024VB\u0024Local_additionalInterestID = additionalInterestID;
    // ISSUE: reference to a compiler-generated field
    if (closure3890_2.\u0024VB\u0024Local_t is SqlTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.SaveInterestVehicles(closure3890_2.\u0024VB\u0024Local_t as SqlTransaction, closure3890_2.\u0024VB\u0024Local_additionalInterestID);
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      if (closure3890_2.\u0024VB\u0024Local_t != null && !DefaultDatabase.HasTransaction)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: method pointer
        DefaultDatabase.EnlistTransaction(closure3890_2.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure3890_2, __methodptr(_Lambda\u0024__0)));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteAdditionalInterestsNetRateVehicles WHERE AdditionalInterestID=@ID", new object[2]
        {
          (object) "@ID",
          (object) closure3890_2.\u0024VB\u0024Local_additionalInterestID
        });
        // ISSUE: reference to a compiler-generated field
        DataRow[] dataRowArray = this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.Select("AdditionalInterestID=" + closure3890_2.\u0024VB\u0024Local_additionalInterestID.ToString());
        int index = 0;
        while (index < dataRowArray.Length)
        {
          this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.RemovetblQuoteAdditionalInterestsNetRateVehiclesRow((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) dataRowArray[index]);
          checked { ++index; }
        }
        try
        {
          foreach (MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle netRateVehicle in this.lstVehicles.CheckedItems.OfType<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle>())
          {
            dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow row = this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.NewtblQuoteAdditionalInterestsNetRateVehiclesRow();
            // ISSUE: reference to a compiler-generated field
            row.AdditionalInterestID = closure3890_2.\u0024VB\u0024Local_additionalInterestID;
            row.VehicleID = netRateVehicle.VehicleID;
            this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.AddtblQuoteAdditionalInterestsNetRateVehiclesRow(row);
          }
        }
        finally
        {
          IEnumerator<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle> enumerator;
          enumerator?.Dispose();
        }
        // ISSUE: reference to a compiler-generated field
        this.AssignTransaction(this.daQuoteNetRateVehicles, closure3890_2.\u0024VB\u0024Local_t);
        DefaultDatabase.DataAdapterUpdate(this.daQuoteNetRateVehicles, (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles);
      }
    }
  }

  protected virtual bool SaveData()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    bool flag;
    try
    {
      frmAdditionalInterests additionalInterests = this;
      dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
      if (!this._deleteInterestID.HasValue)
      {
        if (this._quote.IsEndorsement && this.dsAdditionalInterests.dtPreviousInterest.FindByID(currentInterestRow.ID) != null && !currentInterestRow.ModificationCode.Equals("D") && currentInterestRow.RowState == DataRowState.Modified)
          currentInterestRow.ModificationCode = "M";
        if (!this._deleteInterestID.HasValue && this.AddedLocationsAndVehicles())
          currentInterestRow.ModificationCode = "M";
        this.bmb.EndCurrentEdit();
      }
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (tmpObject, transArgs) =>
      {
        if (!additionalInterests._deleteInterestID.HasValue)
        {
          MDIControls.Instance.StatusBarText = "Saving additional interests...";
          DefaultDatabase.DataAdapterUpdate(additionalInterests.daInterests, (DataTable) additionalInterests.dsAdditionalInterests.tblQuoteAdditionalInterests);
          MDIControls.Instance.StatusBarText = "Saving additional interest types...";
          additionalInterests.SaveInterestTypes(transArgs.Transaction, currentInterestRow.ID);
          MDIControls.Instance.StatusBarText = "Saving additional interest locations...";
          additionalInterests.SaveInterestLocations(transArgs.Transaction, currentInterestRow.ID);
          MDIControls.Instance.StatusBarText = "Saving additional interest vehicles...";
          additionalInterests.SaveInterestVehicles(transArgs.Transaction, currentInterestRow.ID);
          additionalInterests.OnClientSave(currentInterestRow.ID);
        }
        else
        {
          MDIControls.Instance.StatusBarText = "Deleting interest...";
          additionalInterests.SaveInterestTypes(transArgs.Transaction, additionalInterests._deleteInterestID.Value);
          additionalInterests.SaveInterestLocations(transArgs.Transaction, additionalInterests._deleteInterestID.Value);
          additionalInterests.SaveInterestVehicles(transArgs.Transaction, additionalInterests._deleteInterestID.Value);
          DefaultDatabase.DataAdapterUpdate(additionalInterests.daInterests, (DataTable) additionalInterests.dsAdditionalInterests.tblQuoteAdditionalInterests);
        }
        transArgs.Transaction.Commit();
      }));
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = MgaCursors.Default;
    }
    return flag;
  }

  [Obsolete("Use System.Data.Common arguments instead of System.Data.SqlClient arguments", false)]
  protected void AssignTransaction(SqlDataAdapter da, SqlTransaction trans)
  {
    SqlDataAdapter sqlDataAdapter = da;
    sqlDataAdapter.UpdateCommand.Transaction = trans;
    sqlDataAdapter.InsertCommand.Transaction = trans;
    sqlDataAdapter.DeleteCommand.Transaction = trans;
    sqlDataAdapter.SelectCommand.Transaction = trans;
  }

  protected void AssignTransaction(DbDataAdapter da, DbTransaction trans)
  {
    if (trans is SqlTransaction)
    {
      this.AssignTransaction(da as SqlDataAdapter, trans as SqlTransaction);
    }
    else
    {
      DbDataAdapter dbDataAdapter = da;
      dbDataAdapter.UpdateCommand.Transaction = trans;
      dbDataAdapter.InsertCommand.Transaction = trans;
      dbDataAdapter.DeleteCommand.Transaction = trans;
      dbDataAdapter.SelectCommand.Transaction = trans;
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      e.Cancel = true;
    else
      this.dbSave_ClickingDelete_Method(e);
  }

  protected virtual void dbSave_ClickingDelete_Method(CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this additional interest?", "Delete Interest?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        this.Refresh();
        if (this._quote.IsEndorsement)
        {
          this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].ModificationCode = "D";
        }
        else
        {
          dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
          if (currentInterestRow == null || currentInterestRow.RowState == DataRowState.Deleted)
            return;
          this._deleteInterestID = new int?(currentInterestRow.ID);
          DataRow[] dataRowArray1 = this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.Select($"AdditionalInterestID={this._deleteInterestID}");
          int index1 = 0;
          while (index1 < dataRowArray1.Length)
          {
            this.dsAdditionalInterests.tblQuoteAdditionalInterestTypes.RemovetblQuoteAdditionalInterestTypesRow((dsAdditionalInterests.tblQuoteAdditionalInterestTypesRow) dataRowArray1[index1]);
            checked { ++index1; }
          }
          if (this.UsingNetRate)
          {
            DataRow[] dataRowArray2 = this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.Select($"AdditionalInterestID={this._deleteInterestID}");
            int index2 = 0;
            while (index2 < dataRowArray2.Length)
            {
              this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocations.RemovetblQuoteAdditionalInterestsNetRateLocationsRow((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateLocationsRow) dataRowArray2[index2]);
              checked { ++index2; }
            }
          }
          else
          {
            DataRow[] dataRowArray3 = this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.Select($"AdditionalInterestID={this._deleteInterestID}");
            int index3 = 0;
            while (index3 < dataRowArray3.Length)
            {
              this.dsAdditionalInterests.tblQuoteAdditionalInterestsLocations.RemovetblQuoteAdditionalInterestsLocationsRow((dsAdditionalInterests.tblQuoteAdditionalInterestsLocationsRow) dataRowArray3[index3]);
              checked { ++index3; }
            }
          }
          DataRow[] dataRowArray4 = this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.Select($"AdditionalInterestID={this._deleteInterestID}");
          int index4 = 0;
          while (index4 < dataRowArray4.Length)
          {
            this.dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehicles.RemovetblQuoteAdditionalInterestsNetRateVehiclesRow((dsAdditionalInterests.tblQuoteAdditionalInterestsNetRateVehiclesRow) dataRowArray4[index4]);
            checked { ++index4; }
          }
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteAdditionalInterests SET PreviousAdditionalInterestGuid = NULL WHERE PreviousAdditionalInterestGuid = @AddGuid", new object[2]
          {
            (object) "@AddGuid",
            (object) currentInterestRow.AdditionalInterestGuid
          });
          currentInterestRow.Delete();
          this.OnClientDelete(this._deleteInterestID.Value);
          int num1 = ((CheckedListBox) this.lstUnderwritingLocations).Items.Count - 1;
          for (int index5 = 0; index5 <= num1; ++index5)
            ((CheckedListBox) this.lstUnderwritingLocations).SetItemChecked(index5, false);
          int num2 = ((CheckedListBox) this.lstInterestTypes).Items.Count - 1;
          for (int index6 = 0; index6 <= num2; ++index6)
            ((CheckedListBox) this.lstInterestTypes).SetItemChecked(index6, false);
          int num3 = this.lstVehicles.Items.Count - 1;
          for (int index7 = 0; index7 <= num3; ++index7)
            this.lstVehicles.SetItemChecked(index7, false);
        }
        e.Cancel = !this.SaveData();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
        this._deleteInterestID = new int?();
      }
    }
    e.Cancel = true;
    if (this.dsAdditionalInterests.tblQuoteAdditionalInterests.Rows.Count == 0)
      this.dbSave.UIState = (UIState) 0;
    else
      this.dbSave.UIState = (UIState) 1;
  }

  protected virtual void OnClientDelete(int interestId)
  {
  }

  protected virtual void OnClientSave(int interestId)
  {
  }

  protected virtual void OnClientLoadInterest(int interestId)
  {
  }

  protected virtual void OnClientNewInterest()
  {
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.dbSave_ClickingCancel_Method();
    e.Cancel = true;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
          this.err.SetError(control, string.Empty);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.dbSave.UIState = this.dsAdditionalInterests.tblQuoteAdditionalInterests.Count != 0 ? (UIState) 1 : (UIState) 0;
    this.ugInterests_AfterRowActivate((object) null, (EventArgs) null);
  }

  protected virtual void dbSave_ClickingCancel_Method()
  {
    this.dsAdditionalInterests.tblQuoteAdditionalInterests.RejectChanges();
    this.err.SetError((Control) this.txtInsuredName, string.Empty);
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.dbSave_ClickingEdit_Method();
  }

  protected virtual void dbSave_ClickingEdit_Method()
  {
  }

  private void ugInterests_AfterRowActivate(object sender, EventArgs e)
  {
    try
    {
      ((UltraCombo) this.cboInterestType).ValueChanged -= new EventHandler(this.cboInterestType_ValueChanged);
      this.ugInterests_AfterRowActivate_Method();
    }
    finally
    {
      ((UltraCombo) this.cboInterestType).ValueChanged += new EventHandler(this.cboInterestType_ValueChanged);
    }
  }

  protected virtual void ugInterests_AfterRowActivate_Method()
  {
    if (((UltraGridBase) this.ugInterests).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugInterests).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.dsAdditionalInterests.tblQuoteAdditionalInterests, this.bmb);
    if (this.dbSave.UIState != 2)
      this.dbSave.UIState = (UIState) 1;
    DocumentHandling.AdditionalInterestID = this.CurrentInterestRow.ID;
    this.ShowSelectedInterestTypes();
    this.ShowCurrentLocations();
    this.ShowCurrentVehicles();
    this.ShowOfacInterestsData();
    this.OnClientLoadInterest(this.CurrentInterestRow.ID);
  }

  private void ShowOfacInterestsData()
  {
    if (!this._runOfacViaCheckBox.Value && !this._runOfacOnAdditionalInterest.Value)
      return;
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
    if ((currentInterestRow != null ? (int) currentInterestRow.RowState : 8) == 8)
      return;
    Guid additionalInterestGuid = this.CurrentInterestRow.AdditionalInterestGuid;
    OfacSystem.OfacStatus ofacStatus = (OfacSystem.OfacStatus) null;
    if (!this._ofacData.TryGetValue(additionalInterestGuid, out ofacStatus) || ofacStatus == null)
    {
      ofacStatus = OfacSystem.Instance.GetEntityStatus(additionalInterestGuid, new Guid?(this.Quote.ControlGuid));
      this._ofacData[additionalInterestGuid] = ofacStatus;
    }
    ((UltraDateTimeEditor) this.dtOfacSearched).Value = (object) ofacStatus?.LogDate;
    ((UltraDateTimeEditor) this.dtOfacCleared).Value = (object) ((ofacStatus != null ? (ofacStatus.IsHit ? 1 : 0) : 0) != 0 ? (DateTime?) ofacStatus?.ClearDate : ofacStatus?.LogDate);
    string hitMessage = (ofacStatus != null ? (!ofacStatus.OFACCleared ? 1 : 0) : 0) != 0 ? ofacStatus?.HitMessage : (string) null;
    this.aiTip.SetToolTip((Control) this.dtOfacCleared, hitMessage);
    ((Control) this.dtOfacCleared).Tag = (object) hitMessage;
    if (!this._viewOfacTAB.Value)
      return;
    DataSet dataSet = ofacStatus?.GetOfacDataset ?? new DataSet();
    ((UltraGridBase) this.ugOFACResults).DataSource = (object) dataSet;
    ((UltraGridBase) this.ugOFACResults).DataBind();
    if (dataSet.Tables.Count <= 0)
      return;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.ugOFACResults).DisplayLayout.Bands[0].Columns).Count > 13)
      ((UltraGridBase) this.ugOFACResults).DisplayLayout.Bands[0].Columns[12].PerformAutoResize();
    ((UltraGridBase) this.ugOFACResults).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugOFACResults).UpdateData();
  }

  private void DtOfacCleared_MouseClick(object sender, MouseEventArgs mouseArgs)
  {
    if (mouseArgs.Button != MouseButtons.Right || ((Control) this.dtOfacCleared).Tag == null)
      return;
    Clipboard.SetText(((Control) this.dtOfacCleared).Tag as string);
    this.aiTip.Show("Copied hit message", (IWin32Window) this, this.PointToClient(((Control) this.dtOfacCleared).PointToScreen(mouseArgs.Location)), (int) Math.Round(TimeSpan.FromSeconds(3.0).TotalMilliseconds));
  }

  private void ugInterests_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    this.ugInterests_InitializeRow_Method(e);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = ((CheckedListBox) this.lstUnderwritingLocations).Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      ((CheckedListBox) this.lstUnderwritingLocations).SetItemChecked(index, true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = ((CheckedListBox) this.lstUnderwritingLocations).Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      ((CheckedListBox) this.lstUnderwritingLocations).SetItemChecked(index, false);
  }

  private void lnkVehiclesSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = this.lstVehicles.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstVehicles.SetItemChecked(index, true);
  }

  private void lnkVehiclesDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = this.lstVehicles.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstVehicles.SetItemChecked(index, false);
  }

  private void cnMarkAsNew_Click(object sender, EventArgs e)
  {
    int ID = (int) ((UltraGridBase) this.ugInterests).ActiveRow.Cells["ID"].Value;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteAdditionalInterests SET ModificationCode = @MC WHERE ID=@ID", new object[4]
    {
      (object) "@MC",
      (object) "N",
      (object) "@ID",
      (object) ID
    });
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow byId = this.ds.tblQuoteAdditionalInterests.FindByID(ID);
    if (byId == null)
      return;
    byId.ModificationCode = "N";
    ((UltraGridBase) this.ugInterests).ActiveRow.Appearance.ForeColor = Color.Green;
    ((UltraGridBase) this.ugInterests).ActiveRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
  }

  private void ugInterests_MouseDown(object sender, MouseEventArgs e)
  {
    this.cnMarkAsNew.Enabled = false;
    this.cnCopy.Enabled = false;
    UIElement uiElement = ((UIElement) ((UltraGridBase) this.ugInterests).DisplayLayout.UIElement).ElementFromPoint(new Point(e.X, e.Y));
    if (uiElement == null)
      return;
    UltraGridCell context1 = (UltraGridCell) uiElement.GetContext(typeof (UltraGridCell), true);
    if (context1 != null && context1.Column.Key.Equals("CopyInterest") | context1.Column.Key.Equals("GenerateDoc"))
      return;
    UltraGridRow context2 = (UltraGridRow) uiElement.GetContext(typeof (UltraGridRow), true);
    if (context2 == null)
      return;
    context2.Selected = true;
    ((UltraGridBase) this.ugInterests).ActiveRow = context2;
    this.cnCopy.Enabled = true;
    if (e.Button != MouseButtons.Right)
      return;
    string str = (string) context2.Cells["ModificationCode"].Value;
    if (!string.IsNullOrEmpty(str) && str.Equals("N"))
      return;
    this.cnMarkAsNew.Enabled = true;
  }

  protected virtual void ugInterests_InitializeRow_Method(InitializeRowEventArgs e)
  {
    if (e.Row.Band.Index != 0)
      return;
    string Left = e.Row.Cells["ModificationCode"].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "M", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "D", false) != 0)
          return;
        e.Row.Appearance.ForeColor = Color.Red;
        e.Row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      else
      {
        if (!this._isEndorsement)
          return;
        e.Row.Appearance.ForeColor = Color.Green;
      }
    }
    else
      e.Row.Appearance.ForeColor = Color.Blue;
  }

  protected virtual void rptCof()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    SectionReport objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(typeof (rptCertificateOfInsurance), new object[3]
    {
      (object) this._quote.QuoteGuid,
      (object) ((TextEditorControlBase) this.txtDescription).Text,
      (object) this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].ID
    });
    int length = this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].InterestName.Length;
    if (length > 10)
      length = 10;
    string path = $"cert-{this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].InterestName.ToString().Substring(0, length)}{Conversions.ToString(this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].ID)}.pdf";
    string empty = string.Empty;
    try
    {
      empty = this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].Interest.ToString();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    string str1 = Interaction.IIf(Information.IsNothing((object) empty) | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty, "", false) == 0, (object) "", (object) ("-" + empty)).ToString();
    string str2 = $"Certificate-{this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].InterestName.ToString()}{str1}";
    try
    {
      objectTypeAs.Run();
      ReportFactory.Instance.ShowReport(objectTypeAs);
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (PdfExport pdfExport = new PdfExport())
          pdfExport.Export(objectTypeAs.Document, (Stream) memoryStream);
        path = path.Replace("/", string.Empty).Replace("\\", string.Empty).Replace(" ", string.Empty);
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          path = path.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        path = MGATempFolder.MGATempPath + path;
        FileStream fileStream = new FileStream(path, FileMode.Create);
        memoryStream.WriteTo((Stream) fileStream);
        fileStream.Write(memoryStream.ToArray(), 0, (int) memoryStream.Position);
      }
      DocumentManager.BeginFileAddWithBind(path, -1, str2, (ISupportDocumentSystem) this._quote, true, true);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      IOException ioException = ex;
      if (ioException.Message.Contains("used by another process"))
      {
        int num = (int) MessageBox.Show("Cannot execute this request at the momemt because it is being used by another process", "Report Being Used By Another Process", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) ioException);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual void rptMailCert()
  {
    ReportFactory.Instance.ShowReport(true, typeof (CertifiedMailReceiptReport), new object[1]
    {
      (object) this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].ID
    });
  }

  protected virtual void CheckDeletedNetRateLocationsAndVehicles(ref List<string> errorList)
  {
    errorList.AddRange((IEnumerable<string>) this.CheckDeletedNetRateVehicles());
  }

  protected virtual List<string> CheckDeletedNetRateLocations()
  {
    List<string> stringList = new List<string>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("NetRateDeleteDeletedInterestLocations", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        stringList.Add($"The Additional Interest {RuntimeHelpers.GetObjectValue(row["InterestName"])} has been associated with location #{RuntimeHelpers.GetObjectValue(row["LocationUnitNumber"])} building #{RuntimeHelpers.GetObjectValue(row["BuildingNumber"])}.");
        stringList.Add("\\tThis location has been deleted in NetRate in the previous policy and can no longer be associated with an Interest.");
        stringList.Add("\\tPlease note that this association has been removed");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return stringList;
  }

  protected virtual List<string> CheckDeletedNetRateVehicles()
  {
    List<string> stringList = new List<string>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("NetRateDeleteDeletedInterestVehicles", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid,
      (object) "@IsRenewal",
      (object) this._quote.IsRenewal
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        stringList.Add($"The Additional Interest {RuntimeHelpers.GetObjectValue(row["InterestName"])} has been associated with vehicle #{RuntimeHelpers.GetObjectValue(row["UnitNumber"])}.");
        stringList.Add("\\tThis vehicle has been deleted in NetRate in the previous policy and can no longer be associated with an Interest.");
        stringList.Add("\\tPlease note that this association has been removed.");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return stringList;
  }

  protected virtual void FormLoadComplete()
  {
  }

  private void lnkCof_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position > -1 && this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].RowState == DataRowState.Unchanged)
    {
      this.rptCof();
    }
    else
    {
      int num = (int) MessageBox.Show("Please create an additional interest and save it before trying to print a Certificate of Insurance", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void lnkMailCertificate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.bmb.Position > -1 && this.dsAdditionalInterests.tblQuoteAdditionalInterests[this.bmb.Position].RowState == DataRowState.Unchanged)
    {
      this.rptMailCert();
    }
    else
    {
      int num = (int) MessageBox.Show("Please create an additional interest and save it before trying to print a Mail Certificate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  public int ControlNum => this.Quote.ControlNo;

  public bool IsBound => this.Quote.IsBound;

  public string PolicyNum => this.Quote.PolicyNumber;

  List<int> ISupportTemplateDocs.SupportedTemplateGroupIDs
  {
    get => new List<int>(2) { 1, 13 };
  }

  object[] ISupportTemplateDocs.TagParserConstructorArgs(int automationDocGroupID)
  {
    Enums.AutomationDocGroups automationDocGroups = (Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), automationDocGroupID.ToString());
    object[] objArray;
    if (automationDocGroups != 1)
    {
      if (automationDocGroups == 13)
      {
        List<object> objectList = new List<object>();
        try
        {
          foreach (dsAdditionalInterests.tblQuoteAdditionalInterestsRow row in this.dsAdditionalInterests.tblQuoteAdditionalInterests.Rows)
          {
            if (!row.IsGenerateDocNull() && row.GenerateDoc)
              objectList.Add((object) row);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        objArray = objectList.ToArray();
      }
      else
        objArray = (object[]) null;
    }
    else
      objArray = new object[1]
      {
        (object) this._quote.QuoteGuid
      };
    return objArray;
  }

  private void linkTemplateDocuments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmDocumentTemplates), new object[1]
    {
      (object) this
    });
  }

  private void SetDocumentProcessSelection(bool selectionValue)
  {
    try
    {
      foreach (dsAdditionalInterests.tblQuoteAdditionalInterestsRow row in this.dsAdditionalInterests.tblQuoteAdditionalInterests.Rows)
      {
        row.GenerateDoc = selectionValue;
        row.AcceptChanges();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ugInterests).UpdateData();
  }

  private void cboInterestType_ValueChanged(object sender, EventArgs e)
  {
    dsAdditionalInterests.tblAdditionalInterestsRow byInterestId = this.ds.tblAdditionalInterests.FindByInterestID(Conversions.ToInteger(((UltraCombo) this.cboInterestType).Value));
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow currentInterestRow = this.CurrentInterestRow;
    if (byInterestId == null || string.IsNullOrEmpty(((UltraCombo) this.cboInterestType).Text) || currentInterestRow == null)
      return;
    if (currentInterestRow.RowState == DataRowState.Deleted)
      return;
    try
    {
      ((UltraCombo) this.cboInterestType).ValueChanged -= new EventHandler(this.cboInterestType_ValueChanged);
      dsAdditionalInterests.tblAdditionalInterestsRow additionalInterestsRow = byInterestId;
      this.bmb.EndCurrentEdit();
      ((TextEditorControlBase) this.txtInsuredName).Text = ((UltraCombo) this.cboInterestType).Text;
      currentInterestRow.InterestName = ((UltraCombo) this.cboInterestType).Text;
      if (!additionalInterestsRow.IsAddress1Null())
      {
        this.ZipCodeResolver1.Street1 = additionalInterestsRow.Address1;
        currentInterestRow.Address1 = additionalInterestsRow.Address1;
      }
      if (!additionalInterestsRow.IsAddress2Null())
        this.ZipCodeResolver1.Street2 = additionalInterestsRow.Address2;
      if (!additionalInterestsRow.IsCityNull())
      {
        this.ZipCodeResolver1.City = additionalInterestsRow.City;
        currentInterestRow.City = additionalInterestsRow.City;
      }
      if (!additionalInterestsRow.IsStateIDNull())
      {
        this.ZipCodeResolver1.State = additionalInterestsRow.StateID;
        currentInterestRow.StateID = additionalInterestsRow.StateID;
      }
      if (!additionalInterestsRow.IsZipCodeNull())
      {
        this.ZipCodeResolver1.ZipCode = additionalInterestsRow.ZipCode;
        currentInterestRow.ZipCode = additionalInterestsRow.ZipCode;
      }
      if (!additionalInterestsRow.IsZipPlusNull())
        this.ZipCodeResolver1.ZipCodeExtension = additionalInterestsRow.ZipPlus;
      if (!additionalInterestsRow.IsCountyNull())
        this.ZipCodeResolver1.County = additionalInterestsRow.County;
      if (!additionalInterestsRow.IsISOCountryCodeNull())
        this.ZipCodeResolver1.ISOCountryCode = additionalInterestsRow.ISOCountryCode;
    }
    finally
    {
      ((UltraCombo) this.cboInterestType).ValueChanged += new EventHandler(this.cboInterestType_ValueChanged);
    }
  }

  private void cnCopy_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugInterests).ActiveRow == null)
      return;
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow byId = this.ds.tblQuoteAdditionalInterests.FindByID((int) ((UltraGridBase) this.ugInterests).ActiveRow.Cells["ID"].Value);
    if (byId == null)
      return;
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow row = this.ds.tblQuoteAdditionalInterests.NewtblQuoteAdditionalInterestsRow();
    dsAdditionalInterests.tblQuoteAdditionalInterestsRow additionalInterestsRow = byId;
    row.AdditionalInterestGuid = Guid.NewGuid();
    row.QuoteID = additionalInterestsRow.QuoteID;
    row.ModificationCode = "N";
    row.Billable = false;
    if (!additionalInterestsRow.IsAdditionalInterestTypeIDNull())
      row.AdditionalInterestTypeID = additionalInterestsRow.AdditionalInterestTypeID;
    if (!additionalInterestsRow.IsAddress1Null())
      row.Address1 = additionalInterestsRow.Address1;
    if (!additionalInterestsRow.IsAddress2Null())
      row.Address2 = additionalInterestsRow.Address2;
    if (!additionalInterestsRow.IsBillableAmountNull())
      row.BillableAmount = additionalInterestsRow.BillableAmount;
    if (!additionalInterestsRow.IsCityNull())
      row.City = additionalInterestsRow.City;
    if (!additionalInterestsRow.IsCountyNull())
      row.County = additionalInterestsRow.County;
    if (!additionalInterestsRow.IsDescriptionTextNull())
      row.DescriptionText = additionalInterestsRow.DescriptionText;
    if (!additionalInterestsRow.IsFaxNull())
      row.Fax = additionalInterestsRow.Fax;
    if (!additionalInterestsRow.IsFEINNull())
      row.FEIN = additionalInterestsRow.FEIN;
    if (!additionalInterestsRow.IsInterestNull())
      row.Interest = additionalInterestsRow.Interest;
    if (!additionalInterestsRow.IsInterestNameNull())
      row.InterestName = additionalInterestsRow.InterestName;
    if (!additionalInterestsRow.IsLineIDNull())
      row.LineID = additionalInterestsRow.LineID;
    if (!additionalInterestsRow.IsPhoneNull())
      row.Phone = additionalInterestsRow.Phone;
    if (!additionalInterestsRow.IsStateIDNull())
      row.StateID = additionalInterestsRow.StateID;
    if (!additionalInterestsRow.IsZipCodeNull())
      row.ZipCode = additionalInterestsRow.ZipCode;
    if (!additionalInterestsRow.IsZipPlusNull())
      row.ZipPlus = additionalInterestsRow.ZipPlus;
    this.ds.tblQuoteAdditionalInterests.AddtblQuoteAdditionalInterestsRow(row);
    this.dbSave.UIState = (UIState) 2;
    this.bmb.Position = this.ds.tblQuoteAdditionalInterests.Count - 1;
  }

  private void lnkUseName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((TextEditorControlBase) this.txtInsuredName).Text = this.AdditionalInterestName;
  }

  private void lnkSelectAllCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyValue(true);
  }

  private void lnkDeselectAllCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyValue(false);
  }

  private void lnkCopyAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ugInterests.PerformAction((UltraGridAction) 44);
    List<int> values = new List<int>();
    try
    {
      RowsCollection rows = ((UltraGridBase) this.ugInterests).Rows;
      System.Func<UltraGridRow, dsAdditionalInterests.tblQuoteAdditionalInterestsRow> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmAdditionalInterests._Closure\u0024__.\u0024I439\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmAdditionalInterests._Closure\u0024__.\u0024I439\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmAdditionalInterests._Closure\u0024__.\u0024I439\u002D0 = selector = (System.Func<UltraGridRow, dsAdditionalInterests.tblQuoteAdditionalInterestsRow>) ([SpecialName] (gridRow) => (gridRow.ListObject is DataRowView listObject ? listObject.Row : (DataRow) null) as dsAdditionalInterests.tblQuoteAdditionalInterestsRow);
      }
      foreach (dsAdditionalInterests.tblQuoteAdditionalInterestsRow additionalInterestsRow in ((IEnumerable<UltraGridRow>) rows).Select<UltraGridRow, dsAdditionalInterests.tblQuoteAdditionalInterestsRow>(selector))
      {
        if (ExtensionsMethods.FieldOrDefault<bool>((DataRow) additionalInterestsRow, "CopyInterest", false))
          values.Add(additionalInterestsRow.ID);
      }
    }
    finally
    {
      IEnumerator<dsAdditionalInterests.tblQuoteAdditionalInterestsRow> enumerator;
      enumerator?.Dispose();
    }
    using (FormSettings.ShowFormDialog(typeof (FormCopyAdditionalInterest), new object[2]
    {
      (object) this._quote.QuoteGuid,
      (object) string.Join<int>(",", (IEnumerable<int>) values)
    }))
      ;
  }

  private void SetCopyValue(bool SetBooleanValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugInterests).Rows)
      row.Cells["CopyInterest"].Value = (object) SetBooleanValue;
  }

  private void Label8_Click(object sender, EventArgs e)
  {
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (!(eventGuid == BroadcastMessages.ClosefrmViewPrintEmail) || this.Quote == null || !this.Quote.ControlNo.Equals(RuntimeHelpers.GetObjectValue(context)))
      return;
    this.BringToFront();
  }

  private void lstInterestTypes_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (((Control) this.lstInterestTypes).Tag is bool || !((InterestType) ((CheckedListBox) this.lstInterestTypes).Items[e.Index]).IsDisabled || e.CurrentValue != CheckState.Indeterminate)
      return;
    e.NewValue = e.CurrentValue;
  }

  private void BtnSearch_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtVINSearch).Text) || ((TextEditorControlBase) this.txtVINSearch).Text.Length != 4)
    {
      int num1 = (int) MessageBox.Show("VIN search must be 4 digits", "Additional Interests", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (!this.AutoLineRatedWithNetRate)
        return;
      this.ResetVehicleDisplay();
      int num2 = 0;
      IEnumerable<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle> source = this.lstVehicles.Items.OfType<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle>();
      System.Func<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle, int> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (frmAdditionalInterests._Closure\u0024__.\u0024I444\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = frmAdditionalInterests._Closure\u0024__.\u0024I444\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmAdditionalInterests._Closure\u0024__.\u0024I444\u002D0 = keySelector = (System.Func<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle, int>) ([SpecialName] (veh) => veh.VehicleID);
      }
      Dictionary<int, MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle> dictionary = source.ToDictionary<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle, int>(keySelector);
      try
      {
        foreach (dsAdditionalInterests.tblNetRateVehiclesRow tblNetRateVehicle in (TypedTableBase<dsAdditionalInterests.tblNetRateVehiclesRow>) this.dsAdditionalInterests.tblNetRateVehicles)
        {
          if (!string.IsNullOrEmpty(tblNetRateVehicle.VIN) && tblNetRateVehicle.VIN.EndsWith(((TextEditorControlBase) this.txtVINSearch).Text, StringComparison.CurrentCultureIgnoreCase))
          {
            MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle netRateVehicle = (MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle) null;
            if (dictionary.TryGetValue(tblNetRateVehicle.VehicleID, out netRateVehicle))
            {
              ++num2;
              netRateVehicle.SetSearchFoundDisplay();
            }
          }
        }
      }
      finally
      {
        IEnumerator<dsAdditionalInterests.tblNetRateVehiclesRow> enumerator;
        enumerator?.Dispose();
      }
      this.lblSearchResult.Text = $"{num2} {(num2 == 1 ? (object) "vehicle" : (object) "vehicles")} found ending in {((TextEditorControlBase) this.txtVINSearch).Text}";
      this.lblSearchResult.Visible = true;
      this.lstVehicles.Refresh();
    }
  }

  private void ResetVehicleDisplay()
  {
    try
    {
      foreach (MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle netRateVehicle in this.lstVehicles.Items.OfType<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle>())
        netRateVehicle.ResetToDefaultDisplay();
    }
    finally
    {
      IEnumerator<MGASystems.IMS.Policies.AdditionalInterests.NetRateVehicle> enumerator;
      enumerator?.Dispose();
    }
  }

  private IEnumerable<TItem> CheckedOnlyItems<TItem>(CheckedListBox listBox)
  {
    return this.CheckedOnlyItems(listBox).Cast<TItem>();
  }

  private IEnumerable<object> CheckedOnlyItems(CheckedListBox listBox)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u0024State;
    switch (num)
    {
      case -3:
      case 1:
        IEnumerator enumerator;
        try
        {
          switch (num)
          {
            case -3:
              // ISSUE: reference to a compiler-generated field
              this.\u0024State = num = -1;
              return true;
            case 1:
              // ISSUE: reference to a compiler-generated field
              this.\u0024State = num = -1;
              break;
            default:
              enumerator = listBox.CheckedIndices.GetEnumerator();
              break;
          }
          while (enumerator.MoveNext())
          {
            int integer = Conversions.ToInteger(enumerator.Current);
            if (listBox.GetItemCheckState(integer) == CheckState.Checked)
            {
              // ISSUE: reference to a compiler-generated field
              this.\u0024Current = listBox.Items[integer];
              // ISSUE: reference to a compiler-generated field
              this.\u0024State = num = 1;
              return true;
            }
          }
        }
        finally
        {
          if (num < 0 && enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        return false;
      case 0:
        // ISSUE: reference to a compiler-generated field
        this.\u0024State = num = -1;
        goto case -3;
      default:
        return false;
    }
  }

  internal static bool LockDownOnIssuance(Quote quote)
  {
    return quote.PolicyIsIssued && quote.IsBound && !SecurityManager.Instance.AssertPermission("{9E42695B-0F68-4dd0-862D-A6F32244DDFA}");
  }

  internal static bool LockDownOnIssuance(Guid quoteGuid)
  {
    return frmAdditionalInterests.LockDownOnIssuance(Quote.CreateNew(quoteGuid));
  }
}
