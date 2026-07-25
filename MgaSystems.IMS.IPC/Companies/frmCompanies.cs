// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanies
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinStatusBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[DocumentFolderFilter("Company Admin")]
[SecureResource("{C266F1AF-4856-4647-BC41-CE2D40D5E294}", "Add Company", "Controls the ability to add a new company to the system.", "Companies")]
[SecureResource("{E9AFDA12-51D8-4eb8-8040-0E8DBB7DE16A}", "Add Location", "Controls the ability to add a new company location to the system.", "Companies")]
[SecureResource("{81A75321-B644-4c3e-AC6B-104F32A3CAF1}", "Edit Company", "Controls the ability to edit an existing company.", "Companies")]
[SecureResource("{C74F608B-6061-4436-B271-5404C7A74DE1}", "Delete Location", "Controls the ability to delete individual locations of a company.", "Companies")]
[SecureResource("{696C8A8B-4D78-4b68-96E0-B4C3EF44C406}", "Delete Company", "Controls the ability to delete a company and all associated locations.", "Companies")]
[LogCategory("IMS.Insured.Producers.Companies.frmCompanies", "IMS.Insured.Producers.Companies.frmCompanies")]
public class frmCompanies : Form, ISupportNoteSystem, ISupportDocumentSystem
{
  public const string AddNewCompany = "{C266F1AF-4856-4647-BC41-CE2D40D5E294}";
  internal const string AddNewCompanyLocation = "{E9AFDA12-51D8-4eb8-8040-0E8DBB7DE16A}";
  internal const string EditCompany = "{81A75321-B644-4c3e-AC6B-104F32A3CAF1}";
  internal const string DeleteLocation = "{C74F608B-6061-4436-B271-5404C7A74DE1}";
  internal const string DeleteCompany = "{696C8A8B-4D78-4b68-96E0-B4C3EF44C406}";
  private IContainer components;
  private ToolTip ToolTip;
  private DbConnection cnSQL;
  private DbDataAdapter daLocations;
  private DbDataAdapter daCompanies;
  private ErrorProvider ErrProvider;
  private MGASimpleComboBox cbStatus;
  private MGASimpleComboBox cbOfficeType;
  private MGAMaskedEdit txtFax;
  private UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmCompanies_Toolbars_Dock_Area_Bottom;
  private Label Label5;
  private MGAMaskedEdit txtClaimFax;
  private MGAMaskedEdit txtClaimPhone;
  private Label Label10;
  private MGASimpleComboBox cboIntermediary;
  private MGATextBox TextBox1;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private MGASimpleComboBox cboFSR;
  private MGASimpleComboBox cboFSC;
  protected UltraTabControl tabLocations;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  protected UltraTabPageControl UltraTabPageControl1;
  protected UltraTabPageControl UltraTabPageControl2;
  private MGATextBox TextBox2;
  private DbCommand DbSelectCommand2;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  internal const string LogKey = "IMS.Insured.Producers.Companies.frmCompanies";
  private Guid _companyGuid;
  private Guid _moveToCompanyLocationGuid;
  private bool _formLoading;
  private bool _newCompany;
  private readonly bool _addCompany;
  private Guid _quotingOfficeGuid;
  private string _quotingOfficeZip;
  private string _quotingOfficeCity;
  private string _quotingOfficeState;
  private bool _quoteOfficeInvocation;
  private string _quoteLocationGuids;
  private int _defaultOfficeType;

  [field: AccessedThroughProperty("chkDisallowBinding")]
  internal virtual MGACheckBox chkDisallowBinding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  protected virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboRatingBureau")]
  private virtual MGASimpleComboBox cboRatingBureau { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  protected virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFEIN")]
  protected virtual MGAMaskedEdit txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBureauNum")]
  protected virtual MGATextBox txtBureauNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboAddedBy")]
  protected virtual MGASimpleComboBox cboAddedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  protected virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  protected virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNCCI")]
  protected virtual Label lblNCCI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNCCI")]
  protected virtual MGATextBox txtNCCI { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage3")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage2")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox1")]
  protected virtual MGASimpleComboBox MgaSimpleComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  internal virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  private virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox3")]
  private virtual MGATextBox MgaTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RadioButton1")]
  private virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RadioButton2")]
  private virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox2")]
  private virtual MGASimpleComboBox MgaSimpleComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  private virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox3")]
  private virtual MGASimpleComboBox MgaSimpleComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgA_ZipCodeResolver1")]
  private virtual MGA_ZipCodeResolver MgA_ZipCodeResolver1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  private virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  private virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaMaskedEdit1")]
  private virtual MGAMaskedEdit MgaMaskedEdit1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  private virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaMaskedEdit2")]
  private virtual MGAMaskedEdit MgaMaskedEdit2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox4")]
  private virtual MGASimpleComboBox MgaSimpleComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaSimpleComboBox5")]
  private virtual MGASimpleComboBox MgaSimpleComboBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  private virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox5")]
  private virtual MGATextBox MgaTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  private virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  private virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaMaskedEdit3")]
  private virtual MGAMaskedEdit MgaMaskedEdit3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaMaskedEdit4")]
  private virtual MGAMaskedEdit MgaMaskedEdit4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox6")]
  private virtual MGATextBox MgaTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  private virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton1")]
  private virtual MGAButton MgaButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton2")]
  private virtual MGAButton MgaButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton3")]
  private virtual MGAButton MgaButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton4")]
  private virtual MGAButton MgaButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton5")]
  private virtual MGAButton MgaButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton6")]
  private virtual MGAButton MgaButton6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  private virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  protected virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton7")]
  private virtual MGAButton MgaButton7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaListBox1")]
  private virtual MGAListBox MgaListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton8")]
  private virtual MGAButton MgaButton8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl5")]
  protected virtual UltraTabPageControl UltraTabPageControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl6")]
  protected virtual UltraTabPageControl UltraTabPageControl6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pbLogo")]
  internal virtual PictureBox pbLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnNewImage
  {
    get => this._btnNewImage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewImage_Click);
      MGAButton btnNewImage1 = this._btnNewImage;
      if (btnNewImage1 != null)
        ((Control) btnNewImage1).Click -= eventHandler;
      this._btnNewImage = value;
      MGAButton btnNewImage2 = this._btnNewImage;
      if (btnNewImage2 == null)
        return;
      ((Control) btnNewImage2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl7")]
  internal virtual UltraTabPageControl UltraTabPageControl7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNetRateID")]
  private virtual Label lblNetRateID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNetRateID")]
  private virtual MGATextBox txtNetRateID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNetRateName")]
  private virtual Label lblNetRateName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNetRateName")]
  private virtual MGATextBox txtNetRateName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblXMLDialogue")]
  private virtual Label lblXMLDialogue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnXMLDialogue
  {
    get => this._btnXMLDialogue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnXMLDialogue_Click);
      MGAButton btnXmlDialogue1 = this._btnXMLDialogue;
      if (btnXmlDialogue1 != null)
        ((Control) btnXmlDialogue1).Click -= eventHandler;
      this._btnXMLDialogue = value;
      MGAButton btnXmlDialogue2 = this._btnXMLDialogue;
      if (btnXmlDialogue2 == null)
        return;
      ((Control) btnXmlDialogue2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtXMLDialogue")]
  private virtual MGATextBox txtXMLDialogue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnNetRateImport
  {
    get => this._btnNetRateImport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNetRateImport_Click);
      MGAButton btnNetRateImport1 = this._btnNetRateImport;
      if (btnNetRateImport1 != null)
        ((Control) btnNetRateImport1).Click -= eventHandler;
      this._btnNetRateImport = value;
      MGAButton btnNetRateImport2 = this._btnNetRateImport;
      if (btnNetRateImport2 == null)
        return;
      ((Control) btnNetRateImport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkFatcaNonCompliant")]
  internal virtual MGACheckBox chkFatcaNonCompliant { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  private virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStatusChangeReason")]
  private virtual MGATextBox txtStatusChangeReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox TextBox3
  {
    get => this._TextBox3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.TextBox3_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.TextBox3_Leave);
      TextBox textBox3_1 = this._TextBox3;
      if (textBox3_1 != null)
      {
        textBox3_1.TextChanged -= eventHandler1;
        textBox3_1.Leave -= eventHandler2;
      }
      this._TextBox3 = value;
      TextBox textBox3_2 = this._TextBox3;
      if (textBox3_2 == null)
        return;
      textBox3_2.TextChanged += eventHandler1;
      textBox3_2.Leave += eventHandler2;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraToolbarsManager mnuCompanies
  {
    get => this._mnuCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.mnuCompanies_BeforeToolDropdown);
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.mnuCompanies_ToolClick);
      UltraToolbarsManager mnuCompanies1 = this._mnuCompanies;
      if (mnuCompanies1 != null)
      {
        mnuCompanies1.BeforeToolDropdown -= dropdownEventHandler;
        mnuCompanies1.ToolClick -= clickEventHandler;
      }
      this._mnuCompanies = value;
      UltraToolbarsManager mnuCompanies2 = this._mnuCompanies;
      if (mnuCompanies2 == null)
        return;
      mnuCompanies2.BeforeToolDropdown += dropdownEventHandler;
      mnuCompanies2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblRecords")]
  private virtual UltraLabel lblRecords { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      MGAButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      MGAButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboDeliveryMethod")]
  private virtual MGASimpleComboBox cboDeliveryMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnPrev
  {
    get => this._btnPrev;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnPrev1 = this._btnPrev;
      if (btnPrev1 != null)
        ((Control) btnPrev1).Click -= eventHandler;
      this._btnPrev = value;
      MGAButton btnPrev2 = this._btnPrev;
      if (btnPrev2 == null)
        return;
      ((Control) btnPrev2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnLast
  {
    get => this._btnLast;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnLast1 = this._btnLast;
      if (btnLast1 != null)
        ((Control) btnLast1).Click -= eventHandler;
      this._btnLast = value;
      MGAButton btnLast2 = this._btnLast;
      if (btnLast2 == null)
        return;
      ((Control) btnLast2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnFirst
  {
    get => this._btnFirst;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Navigation);
      MGAButton btnFirst1 = this._btnFirst;
      if (btnFirst1 != null)
        ((Control) btnFirst1).Click -= eventHandler;
      this._btnFirst = value;
      MGAButton btnFirst2 = this._btnFirst;
      if (btnFirst2 == null)
        return;
      ((Control) btnFirst2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNewCompanyLocation
  {
    get => this._btnNewCompanyLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewCompanyLocation_Click);
      MGAButton newCompanyLocation1 = this._btnNewCompanyLocation;
      if (newCompanyLocation1 != null)
        ((Control) newCompanyLocation1).Click -= eventHandler;
      this._btnNewCompanyLocation = value;
      MGAButton newCompanyLocation2 = this._btnNewCompanyLocation;
      if (newCompanyLocation2 == null)
        return;
      ((Control) newCompanyLocation2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnGroups
  {
    get => this._btnGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGroups_Click);
      MGAButton btnGroups1 = this._btnGroups;
      if (btnGroups1 != null)
        ((Control) btnGroups1).Click -= eventHandler;
      this._btnGroups = value;
      MGAButton btnGroups2 = this._btnGroups;
      if (btnGroups2 == null)
        return;
      ((Control) btnGroups2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboGroup")]
  protected virtual MGASimpleComboBox cboGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGATextBox txtCompanyName
  {
    get => this._txtCompanyName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtCompanyName_TextChanged);
      MGATextBox txtCompanyName1 = this._txtCompanyName;
      if (txtCompanyName1 != null)
        ((Control) txtCompanyName1).TextChanged -= eventHandler;
      this._txtCompanyName = value;
      MGATextBox txtCompanyName2 = this._txtCompanyName;
      if (txtCompanyName2 == null)
        return;
      ((Control) txtCompanyName2).TextChanged += eventHandler;
    }
  }

  private virtual MGAMaskedEdit txtPhone
  {
    get => this._txtPhone;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TxtPhone_TextChanged);
      MGAMaskedEdit txtPhone1 = this._txtPhone;
      if (txtPhone1 != null)
        ((Control) txtPhone1).TextChanged -= eventHandler;
      this._txtPhone = value;
      MGAMaskedEdit txtPhone2 = this._txtPhone;
      if (txtPhone2 == null)
        return;
      ((Control) txtPhone2).TextChanged += eventHandler;
    }
  }

  private virtual MGA_ZipCodeResolver ctlCompanyLocationZip
  {
    get => this._ctlCompanyLocationZip;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CtlCompanyLocationZip_ISOCountryCodeChanged);
      MGA_ZipCodeResolver companyLocationZip1 = this._ctlCompanyLocationZip;
      if (companyLocationZip1 != null)
        companyLocationZip1.ISOCountryCodeChanged -= eventHandler;
      this._ctlCompanyLocationZip = value;
      MGA_ZipCodeResolver companyLocationZip2 = this._ctlCompanyLocationZip;
      if (companyLocationZip2 == null)
        return;
      companyLocationZip2.ISOCountryCodeChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWebSite")]
  private virtual MGATextBox txtWebSite { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPhone")]
  private virtual Label lblPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtLocation
  {
    get => this._txtLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtLocation_Leave);
      MGATextBox txtLocation1 = this._txtLocation;
      if (txtLocation1 != null)
        ((Control) txtLocation1).Leave -= eventHandler;
      this._txtLocation = value;
      MGATextBox txtLocation2 = this._txtLocation;
      if (txtLocation2 == null)
        return;
      ((Control) txtLocation2).Leave += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnNewContact
  {
    get => this._btnNewContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewContact_Click);
      MGAButton btnNewContact1 = this._btnNewContact;
      if (btnNewContact1 != null)
        ((Control) btnNewContact1).Click -= eventHandler;
      this._btnNewContact = value;
      MGAButton btnNewContact2 = this._btnNewContact;
      if (btnNewContact2 == null)
        return;
      ((Control) btnNewContact2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnContacts
  {
    get => this._btnContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContacts_Click);
      MGAButton btnContacts1 = this._btnContacts;
      if (btnContacts1 != null)
        ((Control) btnContacts1).Click -= eventHandler;
      this._btnContacts = value;
      MGAButton btnContacts2 = this._btnContacts;
      if (btnContacts2 == null)
        return;
      ((Control) btnContacts2).Click += eventHandler;
    }
  }

  private virtual MGAListBox lstContacts
  {
    get => this._lstContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContacts_Click);
      MGAListBox lstContacts1 = this._lstContacts;
      if (lstContacts1 != null)
        lstContacts1.DoubleClick -= eventHandler;
      this._lstContacts = value;
      MGAListBox lstContacts2 = this._lstContacts;
      if (lstContacts2 == null)
        return;
      lstContacts2.DoubleClick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("mnuContacts")]
  private virtual ContextMenu mnuContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MenuItem mnuActive
  {
    get => this._mnuActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContactsMenuClick);
      MenuItem mnuActive1 = this._mnuActive;
      if (mnuActive1 != null)
        mnuActive1.Click -= eventHandler;
      this._mnuActive = value;
      MenuItem mnuActive2 = this._mnuActive;
      if (mnuActive2 == null)
        return;
      mnuActive2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuInactive
  {
    get => this._mnuInactive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContactsMenuClick);
      MenuItem mnuInactive1 = this._mnuInactive;
      if (mnuInactive1 != null)
        mnuInactive1.Click -= eventHandler;
      this._mnuInactive = value;
      MenuItem mnuInactive2 = this._mnuInactive;
      if (mnuInactive2 == null)
        return;
      mnuInactive2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuBothContacts
  {
    get => this._mnuBothContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContactsMenuClick);
      MenuItem mnuBothContacts1 = this._mnuBothContacts;
      if (mnuBothContacts1 != null)
        mnuBothContacts1.Click -= eventHandler;
      this._mnuBothContacts = value;
      MenuItem mnuBothContacts2 = this._mnuBothContacts;
      if (mnuBothContacts2 == null)
        return;
      mnuBothContacts2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCode")]
  protected virtual Label lblCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbLocation
  {
    get => this._rbLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioChanged);
      RadioButton rbLocation1 = this._rbLocation;
      if (rbLocation1 != null)
        rbLocation1.CheckedChanged -= eventHandler;
      this._rbLocation = value;
      RadioButton rbLocation2 = this._rbLocation;
      if (rbLocation2 == null)
        return;
      rbLocation2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbIntermediary
  {
    get => this._rbIntermediary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioChanged);
      RadioButton rbIntermediary1 = this._rbIntermediary;
      if (rbIntermediary1 != null)
        rbIntermediary1.CheckedChanged -= eventHandler;
      this._rbIntermediary = value;
      RadioButton rbIntermediary2 = this._rbIntermediary;
      if (rbIntermediary2 == null)
        return;
      rbIntermediary2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dsCompany")]
  protected virtual dsCompanies dsCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanies")]
  protected virtual UltraLabel lblCompanies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmail")]
  private virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gbCompany")]
  protected virtual UltraGroupBox gbCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.ClickingEdit -= cancelEventHandler5;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.ClickingEdit += cancelEventHandler5;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  internal virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbInsertCommand2")]
  internal virtual DbCommand DbInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbUpdateCommand2")]
  internal virtual DbCommand DbUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbDeleteCommand2")]
  internal virtual DbCommand DbDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNAIC")]
  protected virtual MGATextBox txtNAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanies));
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance49 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Company");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Company");
    ButtonTool buttonTool1 = new ButtonTool("Company_Lines");
    ButtonTool buttonTool2 = new ButtonTool("Producer Information");
    ButtonTool buttonTool3 = new ButtonTool("Company Strength");
    ButtonTool buttonTool4 = new ButtonTool("Company_Lines");
    ButtonTool buttonTool5 = new ButtonTool("Producer Information");
    ButtonTool buttonTool6 = new ButtonTool("Company Strength");
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.cboFSR = new MGASimpleComboBox();
    this.dsCompany = new dsCompanies();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.cboFSC = new MGASimpleComboBox();
    this.cboRatingBureau = new MGASimpleComboBox();
    this.Label18 = new Label();
    this.UltraTabPageControl6 = new UltraTabPageControl();
    this.pbLogo = new PictureBox();
    this.btnNewImage = new MGAButton();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.Label37 = new Label();
    this.txtStatusChangeReason = new MGATextBox();
    this.chkFatcaNonCompliant = new MGACheckBox();
    this.cboAddedBy = new MGASimpleComboBox();
    this.chkDisallowBinding = new MGACheckBox();
    this.TextBox2 = new MGATextBox();
    this.TextBox1 = new MGATextBox();
    this.Label8 = new Label();
    this.rbIntermediary = new RadioButton();
    this.rbLocation = new RadioButton();
    this.cboIntermediary = new MGASimpleComboBox();
    this.Label10 = new Label();
    this.Label7 = new Label();
    this.lblPhone = new Label();
    this.cbStatus = new MGASimpleComboBox();
    this.ctlCompanyLocationZip = new MGA_ZipCodeResolver();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtPhone = new MGAMaskedEdit();
    this.Label6 = new Label();
    this.txtFax = new MGAMaskedEdit();
    this.cbOfficeType = new MGASimpleComboBox();
    this.cboDeliveryMethod = new MGASimpleComboBox();
    this.txtWebSite = new MGATextBox();
    this.txtLocation = new MGATextBox();
    this.Label3 = new Label();
    this.Label9 = new Label();
    this.txtClaimFax = new MGAMaskedEdit();
    this.txtClaimPhone = new MGAMaskedEdit();
    this.txtEmail = new MGATextBox();
    this.Label15 = new Label();
    this.btnDelete = new MGAButton();
    this.btnNewCompanyLocation = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnLast = new MGAButton();
    this.btnFirst = new MGAButton();
    this.btnPrev = new MGAButton();
    this.lblRecords = new UltraLabel();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.btnNewContact = new MGAButton();
    this.lstContacts = new MGAListBox();
    this.mnuContacts = new ContextMenu();
    this.mnuActive = new MenuItem();
    this.mnuInactive = new MenuItem();
    this.mnuBothContacts = new MenuItem();
    this.btnContacts = new MGAButton();
    this.UltraTabPageControl7 = new UltraTabPageControl();
    this.btnNetRateImport = new MGAButton();
    this.txtXMLDialogue = new MGATextBox();
    this.lblXMLDialogue = new Label();
    this.btnXMLDialogue = new MGAButton();
    this.lblNetRateID = new Label();
    this.txtNetRateID = new MGATextBox();
    this.lblNetRateName = new Label();
    this.txtNetRateName = new MGATextBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ToolTip = new ToolTip(this.components);
    this.MgaCheckBox1 = new MGACheckBox();
    this.MgaTextBox5 = new MGATextBox();
    this.MgaButton1 = new MGAButton();
    this.MgaButton2 = new MGAButton();
    this.MgaButton3 = new MGAButton();
    this.MgaButton4 = new MGAButton();
    this.MgaButton5 = new MGAButton();
    this.MgaButton6 = new MGAButton();
    this.MgaButton7 = new MGAButton();
    this.MgaButton8 = new MGAButton();
    this.daCompanies = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand2 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand2 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand2 = DefaultDatabase.CreateCommand();
    this.daLocations = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.ErrProvider = new ErrorProvider(this.components);
    this.gbCompany = new UltraGroupBox();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage3 = new UltraTabSharedControlsPage();
    this.lblNCCI = new Label();
    this.txtNCCI = new MGATextBox();
    this.MgaTextBox1 = new MGATextBox();
    this.Label22 = new Label();
    this.txtBureauNum = new MGATextBox();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.txtNAIC = new MGATextBox();
    this.txtFEIN = new MGAMaskedEdit();
    this.Label13 = new Label();
    this.lblCompanies = new UltraLabel();
    this.lblCode = new Label();
    this.btnGroups = new MGAButton();
    this.Label2 = new Label();
    this.cboGroup = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.txtCompanyName = new MGATextBox();
    this.tabLocations = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this._frmCompanies_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.mnuCompanies = new UltraToolbarsManager(this.components);
    this._frmCompanies_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmCompanies_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmCompanies_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.UltraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    this.MgaTextBox2 = new MGATextBox();
    this.MgaTextBox3 = new MGATextBox();
    this.Label26 = new Label();
    this.RadioButton1 = new RadioButton();
    this.RadioButton2 = new RadioButton();
    this.MgaSimpleComboBox2 = new MGASimpleComboBox();
    this.Label27 = new Label();
    this.Label28 = new Label();
    this.Label29 = new Label();
    this.MgaSimpleComboBox3 = new MGASimpleComboBox();
    this.MgA_ZipCodeResolver1 = new MGA_ZipCodeResolver();
    this.Label30 = new Label();
    this.Label31 = new Label();
    this.MgaMaskedEdit1 = new MGAMaskedEdit();
    this.Label32 = new Label();
    this.MgaMaskedEdit2 = new MGAMaskedEdit();
    this.MgaSimpleComboBox4 = new MGASimpleComboBox();
    this.MgaSimpleComboBox5 = new MGASimpleComboBox();
    this.MgaTextBox4 = new MGATextBox();
    this.Label34 = new Label();
    this.Label35 = new Label();
    this.MgaMaskedEdit3 = new MGAMaskedEdit();
    this.MgaMaskedEdit4 = new MGAMaskedEdit();
    this.MgaTextBox6 = new MGATextBox();
    this.Label36 = new Label();
    this.UltraLabel1 = new UltraLabel();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.MgaListBox1 = new MGAListBox();
    this.TextBox3 = new TextBox();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    Label label8 = new Label();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.cboFSR).BeginInit();
    this.dsCompany.BeginInit();
    ((ISupportInitialize) this.cboFSC).BeginInit();
    ((ISupportInitialize) this.cboRatingBureau).BeginInit();
    ((Control) this.UltraTabPageControl6).SuspendLayout();
    ((ISupportInitialize) this.pbLogo).BeginInit();
    ((ISupportInitialize) this.btnNewImage).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtStatusChangeReason).BeginInit();
    ((ISupportInitialize) this.chkFatcaNonCompliant).BeginInit();
    ((ISupportInitialize) this.cboAddedBy).BeginInit();
    ((ISupportInitialize) this.chkDisallowBinding).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.cboIntermediary).BeginInit();
    ((ISupportInitialize) this.cbStatus).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.txtFax).BeginInit();
    ((ISupportInitialize) this.cbOfficeType).BeginInit();
    ((ISupportInitialize) this.cboDeliveryMethod).BeginInit();
    ((ISupportInitialize) this.txtWebSite).BeginInit();
    ((ISupportInitialize) this.txtLocation).BeginInit();
    ((ISupportInitialize) this.txtClaimFax).BeginInit();
    ((ISupportInitialize) this.txtClaimPhone).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    ((ISupportInitialize) this.btnNewCompanyLocation).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnLast).BeginInit();
    ((ISupportInitialize) this.btnFirst).BeginInit();
    ((ISupportInitialize) this.btnPrev).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.btnNewContact).BeginInit();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    ((ISupportInitialize) this.btnContacts).BeginInit();
    ((Control) this.UltraTabPageControl7).SuspendLayout();
    ((ISupportInitialize) this.btnNetRateImport).BeginInit();
    ((ISupportInitialize) this.txtXMLDialogue).BeginInit();
    ((ISupportInitialize) this.btnXMLDialogue).BeginInit();
    ((ISupportInitialize) this.txtNetRateID).BeginInit();
    ((ISupportInitialize) this.txtNetRateName).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox5).BeginInit();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    ((ISupportInitialize) this.MgaButton2).BeginInit();
    ((ISupportInitialize) this.MgaButton3).BeginInit();
    ((ISupportInitialize) this.MgaButton4).BeginInit();
    ((ISupportInitialize) this.MgaButton5).BeginInit();
    ((ISupportInitialize) this.MgaButton6).BeginInit();
    ((ISupportInitialize) this.MgaButton7).BeginInit();
    ((ISupportInitialize) this.MgaButton8).BeginInit();
    ((ISupportInitialize) this.ErrProvider).BeginInit();
    ((ISupportInitialize) this.gbCompany).BeginInit();
    ((Control) this.gbCompany).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.txtNCCI).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.txtBureauNum).BeginInit();
    ((ISupportInitialize) this.txtNAIC).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.btnGroups).BeginInit();
    ((ISupportInitialize) this.cboGroup).BeginInit();
    ((ISupportInitialize) this.txtCompanyName).BeginInit();
    ((ISupportInitialize) this.tabLocations).BeginInit();
    ((Control) this.tabLocations).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.mnuCompanies).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox2).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox3).BeginInit();
    ((ISupportInitialize) this.MgaMaskedEdit1).BeginInit();
    ((ISupportInitialize) this.MgaMaskedEdit2).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox4).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.MgaMaskedEdit3).BeginInit();
    ((ISupportInitialize) this.MgaMaskedEdit4).BeginInit();
    ((ISupportInitialize) this.MgaTextBox6).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.MgaListBox1).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(311, 233);
    label1.Name = "Label21";
    label1.Size = new Size(57, 13);
    label1.TabIndex = 39;
    label1.Text = "Added By:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(313, 256 /*0x0100*/);
    label2.Name = "Label14";
    label2.Size = new Size(55, 13);
    label2.TabIndex = 36;
    label2.Text = "Loc Code:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(301, 190);
    label3.Name = "Label12";
    label3.Size = new Size(67, 13);
    label3.TabIndex = 23;
    label3.Text = "Office Type:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(327, 168);
    label4.Name = "Label11";
    label4.Size = new Size(42, 13);
    label4.TabIndex = 21;
    label4.Text = "Status:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(311, 233);
    label5.Name = "Label23";
    label5.Size = new Size(56, 13);
    label5.TabIndex = 39;
    label5.Text = "Added By:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(313, 256 /*0x0100*/);
    label6.Name = "Label24";
    label6.Size = new Size(56, 13);
    label6.TabIndex = 36;
    label6.Text = "Loc Code:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(301, 190);
    label7.Name = "Label25";
    label7.Size = new Size(65, 13);
    label7.TabIndex = 23;
    label7.Text = "Office Type:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    label8.AutoSize = true;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(327, 168);
    label8.Name = "Label33";
    label8.Size = new Size(40, 13);
    label8.TabIndex = 21;
    label8.Text = "Status:";
    label8.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.cboFSR);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.cboFSC);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.cboRatingBureau);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl5).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(217, 97);
    this.cboFSR.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFSR).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanies.FSR", true));
    ((UltraGridBase) this.cboFSR).DataMember = "lstFSR";
    ((UltraGridBase) this.cboFSR).DataSource = (object) this.dsCompany;
    ((UltraDropDownBase) this.cboFSR).DisplayMember = "FSR";
    this.cboFSR.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboFSR).DropDownWidth = 250;
    ((Control) this.cboFSR).Location = new Point(93, 12);
    this.cboFSR.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFSR).Name = "cboFSR";
    ((Control) this.cboFSR).Size = new Size(121, 21);
    ((Control) this.cboFSR).TabIndex = 8;
    this.ToolTip.SetToolTip((Control) this.cboFSR, "Financial Strength Rating");
    ((UltraControlBase) this.cboFSR).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFSR).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFSR).ValueMember = "FSR";
    this.dsCompany.DataSetName = "dsCompanies";
    this.dsCompany.Locale = new CultureInfo("en-US");
    this.dsCompany.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(34, 16 /*0x10*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(53, 13);
    this.Label16.TabIndex = 7;
    this.Label16.Text = "Strength:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(57, 41);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(30, 13);
    this.Label17.TabIndex = 9;
    this.Label17.Text = "Size:";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip.SetToolTip((Control) this.Label17, "Financial Size Category");
    this.cboFSC.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFSC).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanies.FSC", true));
    ((UltraGridBase) this.cboFSC).DataMember = "lstFSC";
    ((UltraGridBase) this.cboFSC).DataSource = (object) this.dsCompany;
    ((UltraDropDownBase) this.cboFSC).DisplayMember = "FSC";
    this.cboFSC.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFSC).Location = new Point(93, 37);
    this.cboFSC.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFSC).Name = "cboFSC";
    ((Control) this.cboFSC).Size = new Size(121, 21);
    ((Control) this.cboFSC).TabIndex = 9;
    ((UltraControlBase) this.cboFSC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFSC).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFSC).ValueMember = "FSC";
    this.cboRatingBureau.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboRatingBureau).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanies.RatingBureauID", true));
    ((UltraGridBase) this.cboRatingBureau).DataMember = "lstRatingBureau";
    ((UltraGridBase) this.cboRatingBureau).DataSource = (object) this.dsCompany;
    ((UltraDropDownBase) this.cboRatingBureau).DisplayMember = "RatingBureau";
    this.cboRatingBureau.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRatingBureau).DropDownWidth = 250;
    ((Control) this.cboRatingBureau).Location = new Point(93, 64 /*0x40*/);
    this.cboRatingBureau.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRatingBureau).Name = "cboRatingBureau";
    ((Control) this.cboRatingBureau).Size = new Size(121, 21);
    ((Control) this.cboRatingBureau).TabIndex = 10;
    ((UltraControlBase) this.cboRatingBureau).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRatingBureau).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRatingBureau).ValueMember = "RatingBureauID";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(8, 68);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(79, 13);
    this.Label18.TabIndex = 40;
    this.Label18.Text = "Rating Bureau:";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    this.ToolTip.SetToolTip((Control) this.Label18, "Rating Bureau");
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.pbLogo);
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.btnNewImage);
    ((Control) this.UltraTabPageControl6).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl6).Name = "UltraTabPageControl6";
    ((Control) this.UltraTabPageControl6).Size = new Size(217, 97);
    this.pbLogo.DataBindings.Add(new Binding("Image", (object) this.dsCompany, "tblCompanies.Logo", true));
    this.pbLogo.Location = new Point(3, 4);
    this.pbLogo.Name = "pbLogo";
    this.pbLogo.Size = new Size(161, 91);
    this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbLogo.TabIndex = 5;
    this.pbLogo.TabStop = false;
    ((Control) this.btnNewImage).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewImage).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnNewImage).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewImage).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewImage).Location = new Point(170, 56);
    ((Control) this.btnNewImage).Name = "btnNewImage";
    ((Control) this.btnNewImage).Size = new Size(40, 40);
    ((Control) this.btnNewImage).TabIndex = 4;
    this.btnNewImage.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.TextBox3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label37);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtStatusChangeReason);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkFatcaNonCompliant);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboAddedBy);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkDisallowBinding);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.TextBox2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.TextBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbIntermediary);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.rbLocation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboIntermediary);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbStatus);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ctlCompanyLocationZip);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFax);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cbOfficeType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboDeliveryMethod);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtWebSite);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtLocation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtClaimFax);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtClaimPhone);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEmail);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnDelete);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnNewCompanyLocation);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnNext);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnLast);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnFirst);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnPrev);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblRecords);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(692, 321);
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(522, 106);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(121, 13);
    this.Label37.TabIndex = 43;
    this.Label37.Text = "Status Change Reason:";
    this.Label37.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStatusChangeReason).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtStatusChangeReason).BackColor = Color.White;
    ((Control) this.txtStatusChangeReason).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.StatusChangeReason", true));
    ((Control) this.txtStatusChangeReason).Location = new Point(522, 124);
    ((TextEditorControlBase) this.txtStatusChangeReason).MaxLength = 500;
    this.txtStatusChangeReason.MGAStyle = MGAStyles.Blue;
    this.txtStatusChangeReason.Multiline = true;
    ((Control) this.txtStatusChangeReason).Name = "txtStatusChangeReason";
    ((Control) this.txtStatusChangeReason).Size = new Size(158, 130);
    ((Control) this.txtStatusChangeReason).TabIndex = 42;
    ((UltraControlBase) this.txtStatusChangeReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStatusChangeReason).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFatcaNonCompliant).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkFatcaNonCompliant).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFatcaNonCompliant).BackColorInternal = Color.Transparent;
    ((Control) this.chkFatcaNonCompliant).DataBindings.Add(new Binding("Checked", (object) this.dsCompany, "tblCompanyLocations.FatcaNonCompliant", true));
    ((UltraToggleEditorBase) this.chkFatcaNonCompliant).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFatcaNonCompliant).Location = new Point(541, 30);
    ((Control) this.chkFatcaNonCompliant).Name = "chkFatcaNonCompliant";
    ((Control) this.chkFatcaNonCompliant).Size = new Size(139, 18);
    ((Control) this.chkFatcaNonCompliant).TabIndex = 18;
    ((UltraToggleEditorBase) this.chkFatcaNonCompliant).Text = "FATCA Non-Compliant";
    ((UltraControlBase) this.chkFatcaNonCompliant).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFatcaNonCompliant).UseOsThemes = (DefaultableBoolean) 2;
    this.cboAddedBy.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboAddedBy).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.AddedBy", true));
    ((UltraGridBase) this.cboAddedBy).DataMember = "tblUsers";
    ((UltraGridBase) this.cboAddedBy).DataSource = (object) this.dsCompany;
    ((UltraDropDownBase) this.cboAddedBy).DisplayMember = "Name_LastFirst";
    this.cboAddedBy.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAddedBy).Enabled = false;
    ((Control) this.cboAddedBy).Location = new Point(376, 231);
    this.cboAddedBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAddedBy).Name = "cboAddedBy";
    this.cboAddedBy.ReadOnly = true;
    ((Control) this.cboAddedBy).Size = new Size(140, 21);
    ((Control) this.cboAddedBy).TabIndex = 15;
    ((UltraControlBase) this.cboAddedBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAddedBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAddedBy).ValueMember = "UserGUID";
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisallowBinding).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkDisallowBinding).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisallowBinding).BackColorInternal = Color.Transparent;
    ((Control) this.chkDisallowBinding).DataBindings.Add(new Binding("Checked", (object) this.dsCompany, "tblCompanyLocations.DisallowBinding", true));
    ((UltraToggleEditorBase) this.chkDisallowBinding).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisallowBinding).Location = new Point(541, 7);
    ((Control) this.chkDisallowBinding).Name = "chkDisallowBinding";
    ((Control) this.chkDisallowBinding).Size = new Size(111, 18);
    ((Control) this.chkDisallowBinding).TabIndex = 17;
    ((UltraToggleEditorBase) this.chkDisallowBinding).Text = "Disallow Binding";
    this.ToolTip.SetToolTip((Control) this.chkDisallowBinding, "When checked, it prevents binding and printing of quotes.");
    ((UltraControlBase) this.chkDisallowBinding).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDisallowBinding).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox2).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.TextBox2).BackColor = Color.White;
    ((Control) this.TextBox2).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.LocationCode", true));
    ((Control) this.TextBox2).Location = new Point(376, 253);
    this.TextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox2).Name = "TextBox2";
    ((Control) this.TextBox2).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.TextBox2).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.TextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.TextBox1).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.TextBox1).BackColor = Color.White;
    ((Control) this.TextBox1).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.DateAdded", true));
    ((Control) this.TextBox1).Location = new Point(376, 210);
    this.TextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.TextBox1).Name = "TextBox1";
    ((EditorButtonControlBase) this.TextBox1).ReadOnly = true;
    ((Control) this.TextBox1).Size = new Size(140, 20);
    ((Control) this.TextBox1).TabIndex = 14;
    ((UltraControlBase) this.TextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.TextBox1.WordWrap = false;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(313, 102);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(54, 13);
    this.Label8.TabIndex = 15;
    this.Label8.Text = "Web Site:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.rbIntermediary.BackColor = Color.Transparent;
    this.rbIntermediary.Location = new Point(192 /*0xC0*/, 8);
    this.rbIntermediary.Name = "rbIntermediary";
    this.rbIntermediary.Size = new Size(119, 24);
    this.rbIntermediary.TabIndex = 1;
    this.rbIntermediary.Text = "Use Intermediary";
    this.rbIntermediary.UseVisualStyleBackColor = false;
    this.rbLocation.BackColor = Color.Transparent;
    this.rbLocation.Checked = true;
    this.rbLocation.Location = new Point(88, 8);
    this.rbLocation.Name = "rbLocation";
    this.rbLocation.Size = new Size(104, 24);
    this.rbLocation.TabIndex = 0;
    this.rbLocation.TabStop = true;
    this.rbLocation.Text = "Use Location";
    this.rbLocation.UseVisualStyleBackColor = false;
    this.cboIntermediary.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboIntermediary).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.IntermediaryGuid", true));
    ((UltraGridBase) this.cboIntermediary).DataSource = (object) this.dsCompany.tblIntermediaries;
    ((UltraDropDownBase) this.cboIntermediary).DisplayMember = "IntermediaryName";
    this.cboIntermediary.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboIntermediary).DropDownWidth = 310;
    ((Control) this.cboIntermediary).Location = new Point(88, 56);
    this.cboIntermediary.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboIntermediary).Name = "cboIntermediary";
    ((Control) this.cboIntermediary).Size = new Size(161, 21);
    ((Control) this.cboIntermediary).TabIndex = 3;
    ((UltraControlBase) this.cboIntermediary).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIntermediary).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboIntermediary).ValueMember = "IntermediaryGuid";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(12, 58);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(73, 13);
    this.Label10.TabIndex = 4;
    this.Label10.Text = "Intermediary:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(318, 146);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(50, 13);
    this.Label7.TabIndex = 19;
    this.Label7.Text = "Delivery:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.AutoSize = true;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(327, 10);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(41, 13);
    this.lblPhone.TabIndex = 7;
    this.lblPhone.Text = "Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    this.cbStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStatus).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.StatusID", true));
    ((UltraGridBase) this.cbStatus).DataSource = (object) this.dsCompany.lstStatus;
    ((UltraDropDownBase) this.cbStatus).DisplayMember = "Status";
    this.cbStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStatus).Location = new Point(376, 166);
    this.cbStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStatus).Name = "cbStatus";
    ((Control) this.cbStatus).Size = new Size(140, 21);
    ((Control) this.cbStatus).TabIndex = 12;
    ((UltraControlBase) this.cbStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStatus).ValueMember = "StatusID";
    this.ctlCompanyLocationZip.AddressServiceURL = "";
    this.ctlCompanyLocationZip.AudibleAlerts = false;
    this.ctlCompanyLocationZip.AutoScrollMargin = new Size(0, 0);
    this.ctlCompanyLocationZip.AutoScrollMinSize = new Size(0, 0);
    this.ctlCompanyLocationZip.BackColor = Color.Transparent;
    this.ctlCompanyLocationZip.City = "";
    this.ctlCompanyLocationZip.County = "";
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("City", (object) this.dsCompany, "tblCompanyLocations.City", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("County", (object) this.dsCompany, "tblCompanyLocations.County", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("State", (object) this.dsCompany, "tblCompanyLocations.State", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("Street1", (object) this.dsCompany, "tblCompanyLocations.Address1", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("Street2", (object) this.dsCompany, "tblCompanyLocations.Address2", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("ZipCode", (object) this.dsCompany, "tblCompanyLocations.ZipCode", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsCompany, "tblCompanyLocations.ZipPlus", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsCompany, "tblCompanyLocations.ISOCountryCode", true));
    ((Control) this.ctlCompanyLocationZip).DataBindings.Add(new Binding("GeoRegion", (object) this.dsCompany, "tblCompanyLocations.Region", true));
    this.ctlCompanyLocationZip.GeoRegion = "";
    this.ctlCompanyLocationZip.ISOCountryCode = "";
    this.ctlCompanyLocationZip.ISOCountryCodeMember = "";
    this.ctlCompanyLocationZip.ISOCountryList = (object) null;
    this.ctlCompanyLocationZip.ISOCountryNameMember = "";
    ((Control) this.ctlCompanyLocationZip).Location = new Point(25, 75);
    this.ctlCompanyLocationZip.MGAStyle = MGAStyles.Blue;
    ((Control) this.ctlCompanyLocationZip).Name = "ctlCompanyLocationZip";
    this.ctlCompanyLocationZip.Password = "";
    this.ctlCompanyLocationZip.ShowGlobal = true;
    ((Control) this.ctlCompanyLocationZip).Size = new Size(234, 171);
    this.ctlCompanyLocationZip.State = "";
    this.ctlCompanyLocationZip.Street1 = "";
    this.ctlCompanyLocationZip.Street2 = "";
    ((Control) this.ctlCompanyLocationZip).TabIndex = 3;
    this.ctlCompanyLocationZip.UserID = "";
    this.ctlCompanyLocationZip.ZipCode = "";
    this.ctlCompanyLocationZip.ZipCodeExtension = "";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(24, 35);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(61, 13);
    this.Label4.TabIndex = 2;
    this.Label4.Text = "Loc. Name:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(309, 79);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(57, 13);
    this.Label5.TabIndex = 13;
    this.Label5.Text = "Claim Fax:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BackColorDisabled = Color.Gainsboro;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtPhone.Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    ((Control) this.txtPhone).Location = new Point(376, 8);
    this.txtPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(140, 21);
    ((Control) this.txtPhone).TabIndex = 4;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(296, 56);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(69, 13);
    this.Label6.TabIndex = 11;
    this.Label6.Text = "Claim Phone:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    appearance8.BackColorDisabled = Color.Gainsboro;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFax.Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    ((Control) this.txtFax).Location = new Point(376, 31 /*0x1F*/);
    this.txtFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 20;
    ((Control) this.txtFax).Size = new Size(140, 21);
    ((Control) this.txtFax).TabIndex = 6;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    this.cbOfficeType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbOfficeType).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.LocationTypeID", true));
    ((UltraGridBase) this.cbOfficeType).DataSource = (object) this.dsCompany.lstLocationType;
    ((UltraDropDownBase) this.cbOfficeType).DisplayMember = "LocationType";
    this.cbOfficeType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbOfficeType).Location = new Point(376, 188);
    this.cbOfficeType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbOfficeType).Name = "cbOfficeType";
    ((Control) this.cbOfficeType).Size = new Size(140, 21);
    ((Control) this.cbOfficeType).TabIndex = 13;
    ((UltraControlBase) this.cbOfficeType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbOfficeType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbOfficeType).ValueMember = "LocationTypeID";
    this.cboDeliveryMethod.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboDeliveryMethod).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.DeliveryMethodID", true));
    ((UltraGridBase) this.cboDeliveryMethod).DataSource = (object) this.dsCompany.lstDeliveryMethod;
    ((UltraDropDownBase) this.cboDeliveryMethod).DisplayMember = "Description";
    this.cboDeliveryMethod.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDeliveryMethod).Location = new Point(376, 144 /*0x90*/);
    this.cboDeliveryMethod.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDeliveryMethod).Name = "cboDeliveryMethod";
    ((Control) this.cboDeliveryMethod).Size = new Size(140, 21);
    ((Control) this.cboDeliveryMethod).TabIndex = 11;
    ((UltraControlBase) this.cboDeliveryMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDeliveryMethod).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDeliveryMethod).ValueMember = "DeliveryMethodID";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtWebSite).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtWebSite).BackColor = Color.White;
    ((Control) this.txtWebSite).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.WebSite", true));
    ((Control) this.txtWebSite).Location = new Point(376, 100);
    this.txtWebSite.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtWebSite).Name = "txtWebSite";
    ((Control) this.txtWebSite).Size = new Size(140, 20);
    ((Control) this.txtWebSite).TabIndex = 9;
    ((UltraControlBase) this.txtWebSite).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtWebSite).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLocation).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.txtLocation).BackColor = Color.White;
    ((Control) this.txtLocation).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.LocationName", true));
    ((Control) this.txtLocation).Location = new Point(88, 33);
    this.txtLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLocation).Name = "txtLocation";
    ((Control) this.txtLocation).Size = new Size(161, 20);
    ((Control) this.txtLocation).TabIndex = 2;
    this.ToolTip.SetToolTip((Control) this.txtLocation, "The name of this location.");
    ((UltraControlBase) this.txtLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(340, 33);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(29, 13);
    this.Label3.TabIndex = 9;
    this.Label3.Text = "Fax:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(326, 212);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(42, 13);
    this.Label9.TabIndex = 25;
    this.Label9.Text = "Added:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    appearance11.BackColorDisabled = Color.Gainsboro;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtClaimFax.Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtClaimFax).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.ClaimFax", true));
    this.txtClaimFax.EditAs = (EditAsType) 1;
    ((Control) this.txtClaimFax).Location = new Point(376, 77);
    this.txtClaimFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtClaimFax).Name = "txtClaimFax";
    this.txtClaimFax.NonAutoSizeHeight = 20;
    ((Control) this.txtClaimFax).Size = new Size(140, 21);
    ((Control) this.txtClaimFax).TabIndex = 8;
    this.txtClaimFax.Text = "--";
    ((UltraControlBase) this.txtClaimFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClaimFax).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColorDisabled = Color.Gainsboro;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtClaimPhone.Appearance = (AppearanceBase) appearance12;
    ((Control) this.txtClaimPhone).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.ClaimPhone", true));
    this.txtClaimPhone.EditAs = (EditAsType) 1;
    ((Control) this.txtClaimPhone).Location = new Point(376, 54);
    this.txtClaimPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtClaimPhone).Name = "txtClaimPhone";
    this.txtClaimPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtClaimPhone).Size = new Size(140, 21);
    ((Control) this.txtClaimPhone).TabIndex = 7;
    this.txtClaimPhone.Text = "--";
    ((UltraControlBase) this.txtClaimPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClaimPhone).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.Email", true));
    ((Control) this.txtEmail).Location = new Point(376, 122);
    this.txtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(140, 20);
    ((Control) this.txtEmail).TabIndex = 10;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(331, 124);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(35, 13);
    this.Label15.TabIndex = 17;
    this.Label15.Text = "Email:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance14.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance14;
    ((Control) this.btnDelete).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.btnDelete).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnDelete).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnDelete).Location = new Point(640, 272);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(40, 40);
    ((Control) this.btnDelete).TabIndex = 35;
    this.ToolTip.SetToolTip((Control) this.btnDelete, "Click here to delete this location.");
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNewCompanyLocation).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnNewCompanyLocation).Appearance = (AppearanceBase) appearance15;
    ((Control) this.btnNewCompanyLocation).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNewCompanyLocation).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewCompanyLocation).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewCompanyLocation).Location = new Point(592, 272);
    ((Control) this.btnNewCompanyLocation).Name = "btnNewCompanyLocation";
    ((Control) this.btnNewCompanyLocation).Size = new Size(40, 40);
    ((Control) this.btnNewCompanyLocation).TabIndex = 34;
    this.ToolTip.SetToolTip((Control) this.btnNewCompanyLocation, "New Company Location");
    this.btnNewCompanyLocation.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance16.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance16;
    ((ControlBase) this.btnNext).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNext).Location = new Point(252, 284);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(28, 28);
    ((Control) this.btnNext).TabIndex = 30;
    ((Control) this.btnNext).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnNext, "Next Location");
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnLast).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance17.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnLast).Appearance = (AppearanceBase) appearance17;
    ((ControlBase) this.btnLast).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnLast).Location = new Point(284, 284);
    ((Control) this.btnLast).Name = "btnLast";
    ((Control) this.btnLast).Size = new Size(28, 28);
    ((Control) this.btnLast).TabIndex = 31 /*0x1F*/;
    ((Control) this.btnLast).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnLast, "Last Location");
    this.btnLast.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFirst).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance18.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnFirst).Appearance = (AppearanceBase) appearance18;
    ((ControlBase) this.btnFirst).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnFirst).Location = new Point(84, 284);
    ((Control) this.btnFirst).Name = "btnFirst";
    ((Control) this.btnFirst).Size = new Size(28, 28);
    ((Control) this.btnFirst).TabIndex = 27;
    ((Control) this.btnFirst).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnFirst, "First Location");
    this.btnFirst.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPrev).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance19.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrev).Appearance = (AppearanceBase) appearance19;
    ((ControlBase) this.btnPrev).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrev).Location = new Point(116, 284);
    ((Control) this.btnPrev).Name = "btnPrev";
    ((Control) this.btnPrev).Size = new Size(28, 28);
    ((Control) this.btnPrev).TabIndex = 28;
    ((Control) this.btnPrev).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnPrev, "Previous Location");
    this.btnPrev.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.lblRecords).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance20.BackColor = Color.Transparent;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance20).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblRecords).Appearance = (AppearanceBase) appearance20;
    ((ControlBase) this.lblRecords).BackColorInternal = Color.Gainsboro;
    this.lblRecords.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRecords).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblRecords).Location = new Point(156, 290);
    ((Control) this.lblRecords).Name = "lblRecords";
    ((Control) this.lblRecords).Size = new Size(88, 16 /*0x10*/);
    ((Control) this.lblRecords).TabIndex = 29;
    ((Control) this.lblRecords).Tag = (object) "KeepEnabled";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnNewContact);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lstContacts);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnContacts);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(692, 321);
    appearance21.BackColor = Color.Gainsboro;
    appearance21.BackColor2 = Color.White;
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.BorderColor = Color.Gray;
    appearance21.ImageHAlign = (HAlign) 2;
    appearance21.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNewContact).Appearance = (AppearanceBase) appearance21;
    ((Control) this.btnNewContact).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNewContact).ImageSize = new Size(24, 24);
    ((Control) this.btnNewContact).Location = new Point(336, 191);
    ((Control) this.btnNewContact).Name = "btnNewContact";
    ((Control) this.btnNewContact).Size = new Size(40, 40);
    ((Control) this.btnNewContact).TabIndex = 1;
    ((Control) this.btnNewContact).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnNewContact, "New Location Contact");
    this.btnNewContact.UseOSThemes = (DefaultableBoolean) 2;
    this.lstContacts.ContextMenu = this.mnuContacts;
    this.lstContacts.DataSource = (object) this.dsCompany.tblCompanyContacts;
    this.lstContacts.DisplayMember = "Name";
    this.lstContacts.Location = new Point(8, 8);
    this.lstContacts.MGAStyle = MGAStyles.Blue;
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(322, 223);
    this.lstContacts.TabIndex = 0;
    this.lstContacts.ValueMember = "CompanyContactGuid";
    this.mnuContacts.MenuItems.AddRange(new MenuItem[3]
    {
      this.mnuActive,
      this.mnuInactive,
      this.mnuBothContacts
    });
    this.mnuActive.Checked = true;
    this.mnuActive.Index = 0;
    this.mnuActive.RadioCheck = true;
    this.mnuActive.Text = "Active Contacts";
    this.mnuInactive.Index = 1;
    this.mnuInactive.RadioCheck = true;
    this.mnuInactive.Text = "Inactive Contacts";
    this.mnuBothContacts.Index = 2;
    this.mnuBothContacts.RadioCheck = true;
    this.mnuBothContacts.Text = "Both";
    appearance22.BackColor = Color.Gainsboro;
    appearance22.BackColor2 = Color.White;
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = Color.Gray;
    appearance22.ImageHAlign = (HAlign) 2;
    appearance22.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnContacts).Appearance = (AppearanceBase) appearance22;
    ((ControlBase) this.btnContacts).ImageSize = new Size(24, 24);
    ((Control) this.btnContacts).Location = new Point(384, 191);
    ((Control) this.btnContacts).Name = "btnContacts";
    ((Control) this.btnContacts).Size = new Size(40, 40);
    ((Control) this.btnContacts).TabIndex = 2;
    ((Control) this.btnContacts).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.btnContacts, "View This Contact");
    this.btnContacts.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.btnNetRateImport);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.txtXMLDialogue);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.lblXMLDialogue);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.btnXMLDialogue);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.lblNetRateID);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.txtNetRateID);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.lblNetRateName);
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.txtNetRateName);
    ((Control) this.UltraTabPageControl7).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl7).Name = "UltraTabPageControl7";
    ((Control) this.UltraTabPageControl7).Size = new Size(692, 321);
    appearance23.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnNetRateImport).Appearance = (AppearanceBase) appearance23;
    ((Control) this.btnNetRateImport).Enabled = false;
    ((Control) this.btnNetRateImport).Font = new Font("Tahoma", 8.25f);
    ((ControlBase) this.btnNetRateImport).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNetRateImport).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNetRateImport).Location = new Point(356, 90);
    ((Control) this.btnNetRateImport).Name = "btnNetRateImport";
    ((Control) this.btnNetRateImport).Size = new Size(63 /*0x3F*/, 25);
    ((Control) this.btnNetRateImport).TabIndex = 4;
    ((ControlBase) this.btnNetRateImport).Text = "Import!";
    this.ToolTip.SetToolTip((Control) this.btnNetRateImport, "New Company Location");
    this.btnNetRateImport.UseOSThemes = (DefaultableBoolean) 2;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtXMLDialogue).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.txtXMLDialogue).BackColor = Color.White;
    ((Control) this.txtXMLDialogue).Location = new Point(143, 64 /*0x40*/);
    this.txtXMLDialogue.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtXMLDialogue).Name = "txtXMLDialogue";
    ((Control) this.txtXMLDialogue).Size = new Size(276, 20);
    ((Control) this.txtXMLDialogue).TabIndex = 2;
    this.ToolTip.SetToolTip((Control) this.txtXMLDialogue, "The name of this location.");
    ((UltraControlBase) this.txtXMLDialogue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtXMLDialogue).UseOsThemes = (DefaultableBoolean) 2;
    this.lblXMLDialogue.AutoSize = true;
    this.lblXMLDialogue.BackColor = Color.Transparent;
    this.lblXMLDialogue.Location = new Point(7, 68);
    this.lblXMLDialogue.Name = "lblXMLDialogue";
    this.lblXMLDialogue.Size = new Size(92, 13);
    this.lblXMLDialogue.TabIndex = 41;
    this.lblXMLDialogue.Text = "Import From XML:";
    this.lblXMLDialogue.TextAlign = ContentAlignment.MiddleRight;
    appearance25.ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Center";
    ((ControlBase) this.btnXMLDialogue).Appearance = (AppearanceBase) appearance25;
    ((Control) this.btnXMLDialogue).Font = new Font("Tahoma", 8.25f);
    ((ControlBase) this.btnXMLDialogue).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnXMLDialogue).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnXMLDialogue).Location = new Point(143, 90);
    ((Control) this.btnXMLDialogue).Name = "btnXMLDialogue";
    ((Control) this.btnXMLDialogue).Size = new Size(107, 25);
    ((Control) this.btnXMLDialogue).TabIndex = 3;
    ((ControlBase) this.btnXMLDialogue).Text = "Browse for file...";
    this.ToolTip.SetToolTip((Control) this.btnXMLDialogue, "New Company Location");
    this.btnXMLDialogue.UseOSThemes = (DefaultableBoolean) 2;
    this.lblNetRateID.AutoSize = true;
    this.lblNetRateID.BackColor = Color.Transparent;
    this.lblNetRateID.Location = new Point(7, 42);
    this.lblNetRateID.Name = "lblNetRateID";
    this.lblNetRateID.Size = new Size(113, 13);
    this.lblNetRateID.TabIndex = 39;
    this.lblNetRateID.Text = "NetRate Company ID:";
    this.lblNetRateID.TextAlign = ContentAlignment.MiddleRight;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNetRateID).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.txtNetRateID).BackColor = Color.White;
    ((Control) this.txtNetRateID).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.NetRate_Code", true));
    ((Control) this.txtNetRateID).Location = new Point(143, 38);
    this.txtNetRateID.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNetRateID).Name = "txtNetRateID";
    ((Control) this.txtNetRateID).Size = new Size(122, 20);
    ((Control) this.txtNetRateID).TabIndex = 1;
    this.ToolTip.SetToolTip((Control) this.txtNetRateID, "The name of this location.");
    ((UltraControlBase) this.txtNetRateID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNetRateID).UseOsThemes = (DefaultableBoolean) 2;
    this.lblNetRateName.AutoSize = true;
    this.lblNetRateName.BackColor = Color.Transparent;
    this.lblNetRateName.Location = new Point(7, 16 /*0x10*/);
    this.lblNetRateName.Name = "lblNetRateName";
    this.lblNetRateName.Size = new Size(129, 13);
    this.lblNetRateName.TabIndex = 37;
    this.lblNetRateName.Text = "NetRate Company Name:";
    this.lblNetRateName.TextAlign = ContentAlignment.MiddleRight;
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNetRateName).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.txtNetRateName).BackColor = Color.White;
    ((Control) this.txtNetRateName).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.NetRateCompanyName", true));
    ((Control) this.txtNetRateName).Location = new Point(143, 12);
    this.txtNetRateName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNetRateName).Name = "txtNetRateName";
    ((Control) this.txtNetRateName).Size = new Size(276, 20);
    ((Control) this.txtNetRateName).TabIndex = 0;
    this.ToolTip.SetToolTip((Control) this.txtNetRateName, "The name of this location.");
    ((UltraControlBase) this.txtNetRateName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNetRateName).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(589, 104);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 1;
    appearance28.BorderColor = Color.Gray;
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.dsCompany, "tblCompanyLocations.DisallowBinding", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(468, 5);
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(111, 24);
    ((Control) this.MgaCheckBox1).TabIndex = 17;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Disallow Binding";
    this.ToolTip.SetToolTip((Control) this.MgaCheckBox1, "When checked, it prevents binding and printing of quotes.");
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox5).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.MgaTextBox5).BackColor = Color.White;
    ((Control) this.MgaTextBox5).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.LocationName", true));
    ((Control) this.MgaTextBox5).Location = new Point(88, 33);
    this.MgaTextBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox5).Name = "MgaTextBox5";
    ((Control) this.MgaTextBox5).Size = new Size(161, 19);
    ((Control) this.MgaTextBox5).TabIndex = 2;
    this.ToolTip.SetToolTip((Control) this.MgaTextBox5, "The name of this location.");
    ((UltraControlBase) this.MgaTextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox5).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance30.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance30;
    ((Control) this.MgaButton1).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.MgaButton1).ImageSize = new Size(24, 24);
    ((ControlBase) this.MgaButton1).ImageTransparentColor = Color.Magenta;
    ((Control) this.MgaButton1).Location = new Point(640, 272);
    ((Control) this.MgaButton1).Name = "MgaButton1";
    ((Control) this.MgaButton1).Size = new Size(40, 40);
    ((Control) this.MgaButton1).TabIndex = 35;
    this.ToolTip.SetToolTip((Control) this.MgaButton1, "Click here to delete this location.");
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance31.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.MgaButton2).Appearance = (AppearanceBase) appearance31;
    ((Control) this.MgaButton2).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.MgaButton2).ImageSize = new Size(24, 24);
    ((ControlBase) this.MgaButton2).ImageTransparentColor = Color.Magenta;
    ((Control) this.MgaButton2).Location = new Point(592, 272);
    ((Control) this.MgaButton2).Name = "MgaButton2";
    ((Control) this.MgaButton2).Size = new Size(40, 40);
    ((Control) this.MgaButton2).TabIndex = 34;
    this.ToolTip.SetToolTip((Control) this.MgaButton2, "New Company Location");
    this.MgaButton2.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton3).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance32.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.MgaButton3).Appearance = (AppearanceBase) appearance32;
    ((ControlBase) this.MgaButton3).ImageTransparentColor = Color.Magenta;
    ((Control) this.MgaButton3).Location = new Point(252, 284);
    ((Control) this.MgaButton3).Name = "MgaButton3";
    ((Control) this.MgaButton3).Size = new Size(28, 28);
    ((Control) this.MgaButton3).TabIndex = 30;
    ((Control) this.MgaButton3).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.MgaButton3, "Next Location");
    this.MgaButton3.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton4).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance33.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.MgaButton4).Appearance = (AppearanceBase) appearance33;
    ((ControlBase) this.MgaButton4).ImageTransparentColor = Color.Magenta;
    ((Control) this.MgaButton4).Location = new Point(284, 284);
    ((Control) this.MgaButton4).Name = "MgaButton4";
    ((Control) this.MgaButton4).Size = new Size(28, 28);
    ((Control) this.MgaButton4).TabIndex = 31 /*0x1F*/;
    ((Control) this.MgaButton4).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.MgaButton4, "Last Location");
    this.MgaButton4.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton5).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance34.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.MgaButton5).Appearance = (AppearanceBase) appearance34;
    ((ControlBase) this.MgaButton5).ImageTransparentColor = Color.Magenta;
    ((Control) this.MgaButton5).Location = new Point(84, 284);
    ((Control) this.MgaButton5).Name = "MgaButton5";
    ((Control) this.MgaButton5).Size = new Size(28, 28);
    ((Control) this.MgaButton5).TabIndex = 27;
    ((Control) this.MgaButton5).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.MgaButton5, "First Location");
    this.MgaButton5.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton6).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance35.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.MgaButton6).Appearance = (AppearanceBase) appearance35;
    ((ControlBase) this.MgaButton6).ImageTransparentColor = Color.Magenta;
    ((Control) this.MgaButton6).Location = new Point(116, 284);
    ((Control) this.MgaButton6).Name = "MgaButton6";
    ((Control) this.MgaButton6).Size = new Size(28, 28);
    ((Control) this.MgaButton6).TabIndex = 28;
    ((Control) this.MgaButton6).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.MgaButton6, "Previous Location");
    this.MgaButton6.UseOSThemes = (DefaultableBoolean) 2;
    appearance36.BackColor = Color.Gainsboro;
    appearance36.BackColor2 = Color.White;
    appearance36.BackGradientStyle = (GradientStyle) 2;
    appearance36.BorderColor = Color.Gray;
    appearance36.ImageHAlign = (HAlign) 2;
    appearance36.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButton7).Appearance = (AppearanceBase) appearance36;
    ((Control) this.MgaButton7).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.MgaButton7).ImageSize = new Size(24, 24);
    ((Control) this.MgaButton7).Location = new Point(336, 191);
    ((Control) this.MgaButton7).Name = "MgaButton7";
    ((Control) this.MgaButton7).Size = new Size(40, 40);
    ((Control) this.MgaButton7).TabIndex = 1;
    ((Control) this.MgaButton7).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.MgaButton7, "New Location Contact");
    this.MgaButton7.UseOSThemes = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.Gainsboro;
    appearance37.BackColor2 = Color.White;
    appearance37.BackGradientStyle = (GradientStyle) 2;
    appearance37.BorderColor = Color.Gray;
    appearance37.ImageHAlign = (HAlign) 2;
    appearance37.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButton8).Appearance = (AppearanceBase) appearance37;
    ((ControlBase) this.MgaButton8).ImageSize = new Size(24, 24);
    ((Control) this.MgaButton8).Location = new Point(384, 191);
    ((Control) this.MgaButton8).Name = "MgaButton8";
    ((Control) this.MgaButton8).Size = new Size(40, 40);
    ((Control) this.MgaButton8).TabIndex = 2;
    ((Control) this.MgaButton8).Tag = (object) "KeepEnabled";
    this.ToolTip.SetToolTip((Control) this.MgaButton8, "View This Contact");
    this.MgaButton8.UseOSThemes = (DefaultableBoolean) 2;
    this.daCompanies.DeleteCommand = this.DbDeleteCommand2;
    this.daCompanies.InsertCommand = this.DbInsertCommand2;
    this.daCompanies.SelectCommand = this.DbSelectCommand1;
    this.daCompanies.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanies", new DataColumnMapping[13]
      {
        new DataColumnMapping("CompanyGroupGUID", "CompanyGroupGUID"),
        new DataColumnMapping("CompanyName", "CompanyName"),
        new DataColumnMapping("CompanyGUID", "CompanyGUID"),
        new DataColumnMapping("CompanyID", "CompanyID"),
        new DataColumnMapping("FSR", "FSR"),
        new DataColumnMapping("FSC", "FSC"),
        new DataColumnMapping("NAIC", "NAIC"),
        new DataColumnMapping("RatingBureauID", "RatingBureauID"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("BureauNum", "BureauNum"),
        new DataColumnMapping("AMBestNum", "AMBestNum"),
        new DataColumnMapping("NCCI", "NCCI"),
        new DataColumnMapping("Logo", "Logo")
      })
    });
    this.daCompanies.UpdateCommand = this.DbUpdateCommand2;
    this.DbDeleteCommand2.CommandText = componentResourceManager.GetString("DbDeleteCommand2.CommandText");
    this.DbDeleteCommand2.Connection = this.cnSQL;
    this.DbDeleteCommand2.Parameters.AddRange((Array) new DbParameter[21]
    {
      DefaultDatabase.CreateParameter("@IsNull_CompanyGroupGUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyGroupGUID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyGroupGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGroupGUID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGUID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_FSR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FSR", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_FSR", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FSR", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_FSC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FSC", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_FSC", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FSC", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NAIC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NAIC", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_RatingBureauID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RatingBureauID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_RatingBureauID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RatingBureauID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_FEIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_FEIN", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BureauNum", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BureauNum", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BureauNum", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BureauNum", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AMBestNum", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBestNum", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AMBestNum", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AMBestNum", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NCCI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NCCI", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NCCI", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NCCI", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand2.CommandText = componentResourceManager.GetString("DbInsertCommand2.CommandText");
    this.DbInsertCommand2.Connection = this.cnSQL;
    this.DbInsertCommand2.Parameters.AddRange((Array) new DbParameter[12]
    {
      DefaultDatabase.CreateParameter("@CompanyGroupGUID", SqlDbType.UniqueIdentifier, 0, "CompanyGroupGUID"),
      DefaultDatabase.CreateParameter("@CompanyName", SqlDbType.VarChar, 0, "CompanyName"),
      DefaultDatabase.CreateParameter("@CompanyGUID", SqlDbType.UniqueIdentifier, 0, "CompanyGUID"),
      DefaultDatabase.CreateParameter("@FSR", SqlDbType.VarChar, 0, "FSR"),
      DefaultDatabase.CreateParameter("@FSC", SqlDbType.VarChar, 0, "FSC"),
      DefaultDatabase.CreateParameter("@NAIC", SqlDbType.VarChar, 0, "NAIC"),
      DefaultDatabase.CreateParameter("@RatingBureauID", SqlDbType.TinyInt, 0, "RatingBureauID"),
      DefaultDatabase.CreateParameter("@FEIN", SqlDbType.VarChar, 0, "FEIN"),
      DefaultDatabase.CreateParameter("@BureauNum", SqlDbType.VarChar, 0, "BureauNum"),
      DefaultDatabase.CreateParameter("@AMBestNum", SqlDbType.VarChar, 0, "AMBestNum"),
      DefaultDatabase.CreateParameter("@NCCI", SqlDbType.VarChar, 0, "NCCI"),
      DefaultDatabase.CreateParameter("@Logo", SqlDbType.Image, 0, "Logo")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGUID")
    });
    this.DbUpdateCommand2.CommandText = componentResourceManager.GetString("DbUpdateCommand2.CommandText");
    this.DbUpdateCommand2.Connection = this.cnSQL;
    this.DbUpdateCommand2.Parameters.AddRange((Array) new DbParameter[33]
    {
      DefaultDatabase.CreateParameter("@CompanyGroupGUID", SqlDbType.UniqueIdentifier, 0, "CompanyGroupGUID"),
      DefaultDatabase.CreateParameter("@CompanyName", SqlDbType.VarChar, 0, "CompanyName"),
      DefaultDatabase.CreateParameter("@CompanyGUID", SqlDbType.UniqueIdentifier, 0, "CompanyGUID"),
      DefaultDatabase.CreateParameter("@FSR", SqlDbType.VarChar, 0, "FSR"),
      DefaultDatabase.CreateParameter("@FSC", SqlDbType.VarChar, 0, "FSC"),
      DefaultDatabase.CreateParameter("@NAIC", SqlDbType.VarChar, 0, "NAIC"),
      DefaultDatabase.CreateParameter("@RatingBureauID", SqlDbType.TinyInt, 0, "RatingBureauID"),
      DefaultDatabase.CreateParameter("@FEIN", SqlDbType.VarChar, 0, "FEIN"),
      DefaultDatabase.CreateParameter("@BureauNum", SqlDbType.VarChar, 0, "BureauNum"),
      DefaultDatabase.CreateParameter("@AMBestNum", SqlDbType.VarChar, 0, "AMBestNum"),
      DefaultDatabase.CreateParameter("@NCCI", SqlDbType.VarChar, 0, "NCCI"),
      DefaultDatabase.CreateParameter("@Logo", SqlDbType.Image, 0, "Logo"),
      DefaultDatabase.CreateParameter("@IsNull_CompanyGroupGUID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyGroupGUID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyGroupGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGroupGUID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyName", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyName", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGUID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_FSR", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FSR", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_FSR", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FSR", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_FSC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FSC", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_FSC", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FSC", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NAIC", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NAIC", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NAIC", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_RatingBureauID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "RatingBureauID", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_RatingBureauID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RatingBureauID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_FEIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_FEIN", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_BureauNum", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "BureauNum", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_BureauNum", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BureauNum", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_AMBestNum", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "AMBestNum", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_AMBestNum", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AMBestNum", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@IsNull_NCCI", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NCCI", DataRowVersion.Original, true, (object) null),
      DefaultDatabase.CreateParameter("@Original_NCCI", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NCCI", DataRowVersion.Original, (object) null)
    });
    this.daLocations.DeleteCommand = this.DbDeleteCommand1;
    this.daLocations.InsertCommand = this.DbInsertCommand1;
    this.daLocations.SelectCommand = this.DbSelectCommand2;
    this.daLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLocations", new DataColumnMapping[31 /*0x1F*/]
      {
        new DataColumnMapping("CompanyLocationGUID", "CompanyLocationGUID"),
        new DataColumnMapping("CompanyGUID", "CompanyGUID"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID"),
        new DataColumnMapping("LocationName", "LocationName"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("WebSite", "WebSite"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("LocationTypeID", "LocationTypeID"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("Hidden", "Hidden"),
        new DataColumnMapping("ClaimPhone", "ClaimPhone"),
        new DataColumnMapping("ClaimFax", "ClaimFax"),
        new DataColumnMapping("IntermediaryGuid", "IntermediaryGuid"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("LocationCode", "LocationCode"),
        new DataColumnMapping("DisallowBinding", "DisallowBinding"),
        new DataColumnMapping("AddedBy", "AddedBy"),
        new DataColumnMapping("NetRateCompanyName", "NetRateCompanyName"),
        new DataColumnMapping("StatusChangeReason", "StatusChangeReason"),
        new DataColumnMapping("NetRate_Code", "NetRate_Code"),
        new DataColumnMapping("FatcaNonCompliant", "FatcaNonCompliant")
      })
    });
    this.daLocations.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblCompanyLocations] WHERE (([CompanyLocationGUID] = @Original_CompanyLocationGUID))";
    this.DbDeleteCommand1.Connection = this.cnSQL;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_CompanyLocationGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGUID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnSQL;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[31 /*0x1F*/]
    {
      DefaultDatabase.CreateParameter("@CompanyLocationGUID", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGUID"),
      DefaultDatabase.CreateParameter("@CompanyGUID", SqlDbType.UniqueIdentifier, 0, "CompanyGUID"),
      DefaultDatabase.CreateParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      DefaultDatabase.CreateParameter("@LocationName", SqlDbType.VarChar, 0, "LocationName"),
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      DefaultDatabase.CreateParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      DefaultDatabase.CreateParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      DefaultDatabase.CreateParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      DefaultDatabase.CreateParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      DefaultDatabase.CreateParameter("@WebSite", SqlDbType.VarChar, 0, "WebSite"),
      DefaultDatabase.CreateParameter("@DateAdded", SqlDbType.DateTime, 0, "DateAdded"),
      DefaultDatabase.CreateParameter("@LocationTypeID", SqlDbType.SmallInt, 0, "LocationTypeID"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      DefaultDatabase.CreateParameter("@City", SqlDbType.VarChar, 0, "City"),
      DefaultDatabase.CreateParameter("@County", SqlDbType.VarChar, 0, "County"),
      DefaultDatabase.CreateParameter("@State", SqlDbType.VarChar, 0, "State"),
      DefaultDatabase.CreateParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      DefaultDatabase.CreateParameter("@Hidden", SqlDbType.Bit, 0, "Hidden"),
      DefaultDatabase.CreateParameter("@ClaimPhone", SqlDbType.VarChar, 0, "ClaimPhone"),
      DefaultDatabase.CreateParameter("@ClaimFax", SqlDbType.VarChar, 0, "ClaimFax"),
      DefaultDatabase.CreateParameter("@IntermediaryGuid", SqlDbType.UniqueIdentifier, 0, "IntermediaryGuid"),
      DefaultDatabase.CreateParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      DefaultDatabase.CreateParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      DefaultDatabase.CreateParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      DefaultDatabase.CreateParameter("@LocationCode", SqlDbType.VarChar, 0, "LocationCode"),
      DefaultDatabase.CreateParameter("@DisallowBinding", SqlDbType.Bit, 0, "DisallowBinding"),
      DefaultDatabase.CreateParameter("@AddedBy", SqlDbType.UniqueIdentifier, 0, "AddedBy"),
      DefaultDatabase.CreateParameter("@NetRateCompanyName", SqlDbType.VarChar, 0, "NetRateCompanyName"),
      DefaultDatabase.CreateParameter("@StatusChangeReason", SqlDbType.VarChar, 0, "StatusChangeReason"),
      DefaultDatabase.CreateParameter("@NetRate_Code", SqlDbType.VarChar, 0, "NetRate_Code"),
      DefaultDatabase.CreateParameter("@FatcaNonCompliant", SqlDbType.Bit, 0, "FatcaNonCompliant")
    });
    this.DbSelectCommand2.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    this.DbSelectCommand2.Connection = this.cnSQL;
    this.DbSelectCommand2.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGUID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[32 /*0x20*/]
    {
      DefaultDatabase.CreateParameter("@CompanyLocationGUID", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGUID"),
      DefaultDatabase.CreateParameter("@CompanyGUID", SqlDbType.UniqueIdentifier, 0, "CompanyGUID"),
      DefaultDatabase.CreateParameter("@DeliveryMethodID", SqlDbType.TinyInt, 0, "DeliveryMethodID"),
      DefaultDatabase.CreateParameter("@LocationName", SqlDbType.VarChar, 0, "LocationName"),
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      DefaultDatabase.CreateParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      DefaultDatabase.CreateParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      DefaultDatabase.CreateParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      DefaultDatabase.CreateParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      DefaultDatabase.CreateParameter("@WebSite", SqlDbType.VarChar, 0, "WebSite"),
      DefaultDatabase.CreateParameter("@DateAdded", SqlDbType.DateTime, 0, "DateAdded"),
      DefaultDatabase.CreateParameter("@LocationTypeID", SqlDbType.SmallInt, 0, "LocationTypeID"),
      DefaultDatabase.CreateParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      DefaultDatabase.CreateParameter("@City", SqlDbType.VarChar, 0, "City"),
      DefaultDatabase.CreateParameter("@County", SqlDbType.VarChar, 0, "County"),
      DefaultDatabase.CreateParameter("@State", SqlDbType.VarChar, 0, "State"),
      DefaultDatabase.CreateParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      DefaultDatabase.CreateParameter("@Hidden", SqlDbType.Bit, 0, "Hidden"),
      DefaultDatabase.CreateParameter("@ClaimPhone", SqlDbType.VarChar, 0, "ClaimPhone"),
      DefaultDatabase.CreateParameter("@ClaimFax", SqlDbType.VarChar, 0, "ClaimFax"),
      DefaultDatabase.CreateParameter("@IntermediaryGuid", SqlDbType.UniqueIdentifier, 0, "IntermediaryGuid"),
      DefaultDatabase.CreateParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      DefaultDatabase.CreateParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      DefaultDatabase.CreateParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      DefaultDatabase.CreateParameter("@LocationCode", SqlDbType.VarChar, 0, "LocationCode"),
      DefaultDatabase.CreateParameter("@DisallowBinding", SqlDbType.Bit, 0, "DisallowBinding"),
      DefaultDatabase.CreateParameter("@AddedBy", SqlDbType.UniqueIdentifier, 0, "AddedBy"),
      DefaultDatabase.CreateParameter("@NetRateCompanyName", SqlDbType.VarChar, 0, "NetRateCompanyName"),
      DefaultDatabase.CreateParameter("@StatusChangeReason", SqlDbType.VarChar, 0, "StatusChangeReason"),
      DefaultDatabase.CreateParameter("@NetRate_Code", SqlDbType.VarChar, 0, "NetRate_Code"),
      DefaultDatabase.CreateParameter("@FatcaNonCompliant", SqlDbType.Bit, 0, "FatcaNonCompliant"),
      DefaultDatabase.CreateParameter("@Original_CompanyLocationGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGUID", DataRowVersion.Original, (object) null)
    });
    this.ErrProvider.ContainerControl = (ContainerControl) this;
    appearance38.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbCompany.ContentAreaAppearance = (AppearanceBase) appearance38;
    ((Control) this.gbCompany).Controls.Add((Control) this.UltraTabControl1);
    ((Control) this.gbCompany).Controls.Add((Control) this.lblNCCI);
    ((Control) this.gbCompany).Controls.Add((Control) this.txtNCCI);
    ((Control) this.gbCompany).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.gbCompany).Controls.Add((Control) this.Label22);
    ((Control) this.gbCompany).Controls.Add((Control) this.txtBureauNum);
    ((Control) this.gbCompany).Controls.Add((Control) this.Label20);
    ((Control) this.gbCompany).Controls.Add((Control) this.Label19);
    ((Control) this.gbCompany).Controls.Add((Control) this.txtNAIC);
    ((Control) this.gbCompany).Controls.Add((Control) this.txtFEIN);
    ((Control) this.gbCompany).Controls.Add((Control) this.Label13);
    ((Control) this.gbCompany).Controls.Add((Control) this.lblCompanies);
    ((Control) this.gbCompany).Controls.Add((Control) this.lblCode);
    ((Control) this.gbCompany).Controls.Add((Control) this.btnGroups);
    ((Control) this.gbCompany).Controls.Add((Control) this.Label2);
    ((Control) this.gbCompany).Controls.Add((Control) this.cboGroup);
    ((Control) this.gbCompany).Controls.Add((Control) this.Label1);
    ((Control) this.gbCompany).Controls.Add((Control) this.txtCompanyName);
    appearance39.ForeColor = Color.Black;
    this.gbCompany.HeaderAppearance = (AppearanceBase) appearance39;
    ((Control) this.gbCompany).Location = new Point(8, 0);
    ((Control) this.gbCompany).Name = "gbCompany";
    ((Control) this.gbCompany).Size = new Size(575, 144 /*0x90*/);
    ((Control) this.gbCompany).TabIndex = 0;
    this.gbCompany.Text = "Company Information";
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl6);
    ((Control) this.UltraTabControl1).Location = new Point(347, 14);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage3;
    ((Control) this.UltraTabControl1).Size = new Size(219, 124);
    ((Control) this.UltraTabControl1).TabIndex = 49;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    ultraTab1.Key = "tabInfo";
    ultraTab1.TabPage = this.UltraTabPageControl5;
    ultraTab1.Text = "Info";
    ultraTab2.Key = "tabImage";
    ultraTab2.TabPage = this.UltraTabPageControl6;
    ultraTab2.Text = "Logo";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(110, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage3).Name = "UltraTabSharedControlsPage3";
    ((Control) this.UltraTabSharedControlsPage3).Size = new Size(217, 97);
    this.lblNCCI.BackColor = Color.Transparent;
    this.lblNCCI.Location = new Point(199, 120);
    this.lblNCCI.Name = "lblNCCI";
    this.lblNCCI.Size = new Size(52, 16 /*0x10*/);
    this.lblNCCI.TabIndex = 48 /*0x30*/;
    this.lblNCCI.Text = "NCCI:";
    this.lblNCCI.TextAlign = ContentAlignment.MiddleRight;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance40.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNCCI).Appearance = (AppearanceBase) appearance40;
    ((TextEditorControlBase) this.txtNCCI).BackColor = Color.White;
    ((Control) this.txtNCCI).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanies.NCCI", true));
    ((Control) this.txtNCCI).Location = new Point(257, 118);
    ((TextEditorControlBase) this.txtNCCI).MaxLength = 30;
    this.txtNCCI.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNCCI).Name = "txtNCCI";
    ((Control) this.txtNCCI).Size = new Size(84, 20);
    ((Control) this.txtNCCI).TabIndex = 7;
    ((UltraControlBase) this.txtNCCI).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNCCI).UseOsThemes = (DefaultableBoolean) 2;
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance41.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance41;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanies.AMBestNum", true));
    ((Control) this.MgaTextBox1).Location = new Point(257, 93);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 30;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(84, 20);
    ((Control) this.MgaTextBox1).TabIndex = 6;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(170, 95);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(81, 16 /*0x10*/);
    this.Label22.TabIndex = 45;
    this.Label22.Text = "A.M. Best #:";
    this.Label22.TextAlign = ContentAlignment.MiddleRight;
    appearance42.BackColor = Color.White;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBureauNum).Appearance = (AppearanceBase) appearance42;
    ((TextEditorControlBase) this.txtBureauNum).BackColor = Color.White;
    ((Control) this.txtBureauNum).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanies.BureauNum", true));
    ((Control) this.txtBureauNum).Location = new Point(89, 93);
    ((TextEditorControlBase) this.txtBureauNum).MaxLength = 10;
    this.txtBureauNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtBureauNum).Name = "txtBureauNum";
    ((Control) this.txtBureauNum).Size = new Size(75, 20);
    ((Control) this.txtBureauNum).TabIndex = 3;
    ((UltraControlBase) this.txtBureauNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBureauNum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(17, 95);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.Label20.TabIndex = 43;
    this.Label20.Text = "Bureau #:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(196, 70);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(55, 13);
    this.Label19.TabIndex = 42;
    this.Label19.Text = "FEIN/TIN:";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNAIC).Appearance = (AppearanceBase) appearance43;
    ((TextEditorControlBase) this.txtNAIC).BackColor = Color.White;
    ((Control) this.txtNAIC).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanies.NAIC", true));
    ((Control) this.txtNAIC).Location = new Point(89, 118);
    ((TextEditorControlBase) this.txtNAIC).MaxLength = 30;
    this.txtNAIC.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNAIC).Name = "txtNAIC";
    ((Control) this.txtNAIC).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.txtNAIC).TabIndex = 4;
    ((UltraControlBase) this.txtNAIC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNAIC).UseOsThemes = (DefaultableBoolean) 2;
    appearance44.BackColorDisabled = Color.Gainsboro;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFEIN.Appearance = (AppearanceBase) appearance44;
    ((Control) this.txtFEIN).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanies.FEIN", true));
    this.txtFEIN.EditAs = (EditAsType) 1;
    this.txtFEIN.InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(271, 66);
    this.txtFEIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    this.txtFEIN.NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(70, 21);
    ((Control) this.txtFEIN).TabIndex = 5;
    this.txtFEIN.Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(47, 120);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(36, 16 /*0x10*/);
    this.Label13.TabIndex = 11;
    this.Label13.Text = "NAIC:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance45.BackColor = Color.Transparent;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.lblCompanies).Appearance = (AppearanceBase) appearance45;
    this.lblCompanies.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblCompanies).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanies.CompanyID", true));
    ((Control) this.lblCompanies).Location = new Point(89, 65);
    ((Control) this.lblCompanies).Name = "lblCompanies";
    ((Control) this.lblCompanies).Size = new Size(48 /*0x30*/, 23);
    ((Control) this.lblCompanies).TabIndex = 2;
    this.lblCode.BackColor = Color.Transparent;
    this.lblCode.Location = new Point(45, 68);
    this.lblCode.Name = "lblCode";
    this.lblCode.Size = new Size(36, 16 /*0x10*/);
    this.lblCode.TabIndex = 5;
    this.lblCode.Text = "Code:";
    this.lblCode.TextAlign = ContentAlignment.MiddleRight;
    appearance46.BackColor = Color.FromArgb(248, 248, 248);
    appearance46.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance46.BackGradientStyle = (GradientStyle) 2;
    appearance46.BorderColor = Color.DarkGray;
    appearance46.ImageHAlign = (HAlign) 2;
    appearance46.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGroups).Appearance = (AppearanceBase) appearance46;
    ((Control) this.btnGroups).Location = new Point(317, 37);
    ((Control) this.btnGroups).Name = "btnGroups";
    ((Control) this.btnGroups).Size = new Size(24, 24);
    ((Control) this.btnGroups).TabIndex = 2;
    ((ControlBase) this.btnGroups).Text = "...";
    this.btnGroups.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(43, 43);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(40, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Group:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboGroup.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboGroup).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanies.CompanyGroupGuid", true));
    ((UltraGridBase) this.cboGroup).DataSource = (object) this.dsCompany.tblCompanyGroups;
    ((UltraDropDownBase) this.cboGroup).DisplayMember = "CompanyGroupName";
    this.cboGroup.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboGroup).Location = new Point(89, 39);
    this.cboGroup.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboGroup).Name = "cboGroup";
    ((Control) this.cboGroup).Size = new Size(216, 21);
    ((Control) this.cboGroup).TabIndex = 1;
    ((UltraControlBase) this.cboGroup).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboGroup).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboGroup).ValueMember = "CompanyGroupGuid";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(45, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(38, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance47.BackColor = Color.White;
    appearance47.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance47.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCompanyName).Appearance = (AppearanceBase) appearance47;
    ((TextEditorControlBase) this.txtCompanyName).BackColor = Color.White;
    ((Control) this.txtCompanyName).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanies.CompanyName", true));
    ((Control) this.txtCompanyName).Location = new Point(89, 14);
    this.txtCompanyName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCompanyName).Name = "txtCompanyName";
    ((Control) this.txtCompanyName).Size = new Size(252, 20);
    ((Control) this.txtCompanyName).TabIndex = 0;
    ((UltraControlBase) this.txtCompanyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCompanyName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance48.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance38.Image"));
    ((UltraTabControlBase) this.tabLocations).Appearance = (AppearanceBase) appearance48;
    ((Control) this.tabLocations).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabLocations).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.tabLocations).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.tabLocations).Controls.Add((Control) this.UltraTabPageControl7);
    ((Control) this.tabLocations).Location = new Point(8, 150);
    ((Control) this.tabLocations).Name = "tabLocations";
    ((UltraTabControlBase) this.tabLocations).SharedControls.AddRange(new Control[7]
    {
      (Control) this.btnDelete,
      (Control) this.btnNewCompanyLocation,
      (Control) this.btnNext,
      (Control) this.btnLast,
      (Control) this.btnFirst,
      (Control) this.btnPrev,
      (Control) this.lblRecords
    });
    ((UltraTabControlBase) this.tabLocations).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabLocations).Size = new Size(694, 348);
    ((Control) this.tabLocations).TabIndex = 0;
    ((UltraTabControlBase) this.tabLocations).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabLocations).TabPadding = new Size(5, 3);
    ultraTab3.Key = "tabLocationInfo";
    ultraTab3.TabPage = this.UltraTabPageControl1;
    ultraTab3.Text = "Location Info";
    appearance49.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance49;
    ultraTab4.Key = "tabContacts";
    ultraTab4.TabPage = this.UltraTabPageControl2;
    ultraTab4.Text = "Contacts";
    ultraTab5.Key = "tabNetRate";
    ultraTab5.TabPage = this.UltraTabPageControl7;
    ultraTab5.Text = "NetRate";
    ((UltraTabControlBase) this.tabLocations).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraTabControlBase) this.tabLocations).TabSize = new Size(110, 0);
    ((UltraTabControlBase) this.tabLocations).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnDelete);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNewCompanyLocation);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNext);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnLast);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnFirst);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnPrev);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblRecords);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(692, 321);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).Name = "_frmCompanies_Toolbars_Dock_Area_Left";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Left).Size = new Size(0, 485);
    this._frmCompanies_Toolbars_Dock_Area_Left.ToolbarsManager = this.mnuCompanies;
    this.mnuCompanies.DesignerFlags = 1;
    this.mnuCompanies.DockWithinContainer = (Control) this;
    this.mnuCompanies.DockWithinContainerBaseType = typeof (Form);
    this.mnuCompanies.LockToolbars = true;
    this.mnuCompanies.MenuSettings.IsSideStripVisible = (DefaultableBoolean) 2;
    this.mnuCompanies.MenuSettings.PopupStyle = (PopupStyle) 1;
    this.mnuCompanies.ShowFullMenusDelay = 500;
    this.mnuCompanies.ShowQuickCustomizeButton = false;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Text = "MainMenu";
    this.mnuCompanies.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Company";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "Company";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Lines...";
    ((ToolBase) buttonTool4).SharedPropsInternal.Category = "Company";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Producer Information...";
    ((ToolBase) buttonTool5).SharedPropsInternal.Category = "Company";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Company Strength";
    this.mnuCompanies.Tools.AddRange(new ToolBase[4]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).Location = new Point(712, 21);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).Name = "_frmCompanies_Toolbars_Dock_Area_Right";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Right).Size = new Size(0, 485);
    this._frmCompanies_Toolbars_Dock_Area_Right.ToolbarsManager = this.mnuCompanies;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).Name = "_frmCompanies_Toolbars_Dock_Area_Top";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Top).Size = new Size(712, 21);
    this._frmCompanies_Toolbars_Dock_Area_Top.ToolbarsManager = this.mnuCompanies;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmCompanies_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).Location = new Point(0, 506);
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).Name = "_frmCompanies_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom).Size = new Size(712, 0);
    this._frmCompanies_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.mnuCompanies;
    ((Control) this.UltraTabSharedControlsPage2).Location = new Point(1, 26);
    ((Control) this.UltraTabSharedControlsPage2).Name = "UltraTabSharedControlsPage2";
    ((Control) this.UltraTabSharedControlsPage2).Size = new Size(692, 321);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaSimpleComboBox1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label6);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox3);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label7);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label26);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.RadioButton1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.RadioButton2);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaSimpleComboBox2);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label27);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label28);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label29);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaSimpleComboBox3);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgA_ZipCodeResolver1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label30);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label31);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaMaskedEdit1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label32);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaMaskedEdit2);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaSimpleComboBox4);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) label8);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaSimpleComboBox5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox4);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label34);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label35);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaMaskedEdit3);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaMaskedEdit4);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox6);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label36);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaButton1);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaButton2);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaButton3);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaButton4);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaButton5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaButton6);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.UltraLabel1);
    ((Control) this.UltraTabPageControl3).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(692, 321);
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox1).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.AddedBy", true));
    ((UltraGridBase) this.MgaSimpleComboBox1).DataMember = "tblUsers";
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.dsCompany;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "Name_LastFirst";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox1).Enabled = false;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(376, 231);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    this.MgaSimpleComboBox1.ReadOnly = true;
    ((Control) this.MgaSimpleComboBox1).Size = new Size(140, 20);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 15;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "UserGUID";
    appearance50.BackColor = Color.White;
    appearance50.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance50.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance50;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.LocationCode", true));
    ((Control) this.MgaTextBox2).Location = new Point(376, 253);
    this.MgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(64 /*0x40*/, 19);
    ((Control) this.MgaTextBox2).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    appearance51.BackColor = Color.White;
    appearance51.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance51.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance51;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.DateAdded", true));
    ((Control) this.MgaTextBox3).Location = new Point(376, 210);
    this.MgaTextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((EditorButtonControlBase) this.MgaTextBox3).ReadOnly = true;
    ((Control) this.MgaTextBox3).Size = new Size(140, 19);
    ((Control) this.MgaTextBox3).TabIndex = 14;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    this.MgaTextBox3.WordWrap = false;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(313, 102);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(54, 13);
    this.Label26.TabIndex = 15;
    this.Label26.Text = "Web Site:";
    this.Label26.TextAlign = ContentAlignment.MiddleRight;
    this.RadioButton1.BackColor = Color.Transparent;
    this.RadioButton1.Location = new Point(192 /*0xC0*/, 8);
    this.RadioButton1.Name = "RadioButton1";
    this.RadioButton1.Size = new Size(119, 24);
    this.RadioButton1.TabIndex = 1;
    this.RadioButton1.Text = "Use Intermediary";
    this.RadioButton1.UseVisualStyleBackColor = false;
    this.RadioButton2.BackColor = Color.Transparent;
    this.RadioButton2.Checked = true;
    this.RadioButton2.Location = new Point(88, 8);
    this.RadioButton2.Name = "RadioButton2";
    this.RadioButton2.Size = new Size(104, 24);
    this.RadioButton2.TabIndex = 0;
    this.RadioButton2.TabStop = true;
    this.RadioButton2.Text = "Use Location";
    this.RadioButton2.UseVisualStyleBackColor = false;
    this.MgaSimpleComboBox2.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox2).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.IntermediaryGuid", true));
    ((UltraGridBase) this.MgaSimpleComboBox2).DataSource = (object) this.dsCompany.tblIntermediaries;
    ((UltraDropDownBase) this.MgaSimpleComboBox2).DisplayMember = "IntermediaryName";
    this.MgaSimpleComboBox2.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaSimpleComboBox2).DropDownWidth = 310;
    ((Control) this.MgaSimpleComboBox2).Location = new Point(88, 56);
    this.MgaSimpleComboBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox2).Name = "MgaSimpleComboBox2";
    ((Control) this.MgaSimpleComboBox2).Size = new Size(161, 20);
    ((Control) this.MgaSimpleComboBox2).TabIndex = 3;
    ((UltraControlBase) this.MgaSimpleComboBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox2).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox2).ValueMember = "IntermediaryGuid";
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(12, 58);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(67, 13);
    this.Label27.TabIndex = 4;
    this.Label27.Text = "Intermediary:";
    this.Label27.TextAlign = ContentAlignment.MiddleRight;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(318, 146);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(48 /*0x30*/, 13);
    this.Label28.TabIndex = 19;
    this.Label28.Text = "Delivery:";
    this.Label28.TextAlign = ContentAlignment.MiddleRight;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(327, 10);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(41, 13);
    this.Label29.TabIndex = 7;
    this.Label29.Text = "Phone:";
    this.Label29.TextAlign = ContentAlignment.MiddleRight;
    this.MgaSimpleComboBox3.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox3).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.StatusID", true));
    ((UltraGridBase) this.MgaSimpleComboBox3).DataSource = (object) this.dsCompany.lstStatus;
    ((UltraDropDownBase) this.MgaSimpleComboBox3).DisplayMember = "Status";
    this.MgaSimpleComboBox3.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox3).Location = new Point(376, 166);
    this.MgaSimpleComboBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox3).Name = "MgaSimpleComboBox3";
    ((Control) this.MgaSimpleComboBox3).Size = new Size(140, 20);
    ((Control) this.MgaSimpleComboBox3).TabIndex = 12;
    ((UltraControlBase) this.MgaSimpleComboBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox3).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox3).ValueMember = "StatusID";
    this.MgA_ZipCodeResolver1.AddressServiceURL = "";
    this.MgA_ZipCodeResolver1.AudibleAlerts = false;
    this.MgA_ZipCodeResolver1.AutoScrollMargin = new Size(0, 0);
    this.MgA_ZipCodeResolver1.AutoScrollMinSize = new Size(0, 0);
    this.MgA_ZipCodeResolver1.BackColor = Color.Transparent;
    this.MgA_ZipCodeResolver1.City = "";
    this.MgA_ZipCodeResolver1.County = "";
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("City", (object) this.dsCompany, "tblCompanyLocations.City", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("County", (object) this.dsCompany, "tblCompanyLocations.County", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("State", (object) this.dsCompany, "tblCompanyLocations.State", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("Street1", (object) this.dsCompany, "tblCompanyLocations.Address1", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("Street2", (object) this.dsCompany, "tblCompanyLocations.Address2", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("ZipCode", (object) this.dsCompany, "tblCompanyLocations.ZipCode", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("ZipCodeExtension", (object) this.dsCompany, "tblCompanyLocations.ZipPlus", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("ISOCountryCode", (object) this.dsCompany, "tblCompanyLocations.ISOCountryCode", true));
    ((Control) this.MgA_ZipCodeResolver1).DataBindings.Add(new Binding("GeoRegion", (object) this.dsCompany, "tblCompanyLocations.Region", true));
    this.MgA_ZipCodeResolver1.GeoRegion = "";
    this.MgA_ZipCodeResolver1.ISOCountryCode = "";
    this.MgA_ZipCodeResolver1.ISOCountryCodeMember = "";
    this.MgA_ZipCodeResolver1.ISOCountryList = (object) null;
    this.MgA_ZipCodeResolver1.ISOCountryNameMember = "";
    ((Control) this.MgA_ZipCodeResolver1).Location = new Point(25, 75);
    this.MgA_ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgA_ZipCodeResolver1).Name = "MgA_ZipCodeResolver1";
    this.MgA_ZipCodeResolver1.Password = "";
    this.MgA_ZipCodeResolver1.ShowGlobal = true;
    ((Control) this.MgA_ZipCodeResolver1).Size = new Size(234, 171);
    this.MgA_ZipCodeResolver1.State = "";
    this.MgA_ZipCodeResolver1.Street1 = "";
    this.MgA_ZipCodeResolver1.Street2 = "";
    ((Control) this.MgA_ZipCodeResolver1).TabIndex = 4;
    this.MgA_ZipCodeResolver1.UserID = "";
    this.MgA_ZipCodeResolver1.ZipCode = "";
    this.MgA_ZipCodeResolver1.ZipCodeExtension = "";
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(24, 35);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(62, 13);
    this.Label30.TabIndex = 2;
    this.Label30.Text = "Loc. Name:";
    this.Label30.TextAlign = ContentAlignment.MiddleRight;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(309, 79);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(55, 13);
    this.Label31.TabIndex = 13;
    this.Label31.Text = "Claim Fax:";
    this.Label31.TextAlign = ContentAlignment.MiddleRight;
    appearance52.BackColorDisabled = Color.Gainsboro;
    appearance52.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaMaskedEdit1.Appearance = (AppearanceBase) appearance52;
    ((Control) this.MgaMaskedEdit1).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.Phone", true));
    this.MgaMaskedEdit1.EditAs = (EditAsType) 1;
    this.MgaMaskedEdit1.InputMask = "###-###-####";
    ((Control) this.MgaMaskedEdit1).Location = new Point(376, 8);
    this.MgaMaskedEdit1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaMaskedEdit1).Name = "MgaMaskedEdit1";
    this.MgaMaskedEdit1.NonAutoSizeHeight = 20;
    ((Control) this.MgaMaskedEdit1).Size = new Size(77, 20);
    ((Control) this.MgaMaskedEdit1).TabIndex = 5;
    this.MgaMaskedEdit1.Text = "--";
    ((UltraControlBase) this.MgaMaskedEdit1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaMaskedEdit1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(296, 56);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(69, 13);
    this.Label32.TabIndex = 11;
    this.Label32.Text = "Claim Phone:";
    this.Label32.TextAlign = ContentAlignment.MiddleRight;
    appearance53.BackColorDisabled = Color.Gainsboro;
    appearance53.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaMaskedEdit2.Appearance = (AppearanceBase) appearance53;
    ((Control) this.MgaMaskedEdit2).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.Fax", true));
    this.MgaMaskedEdit2.EditAs = (EditAsType) 1;
    this.MgaMaskedEdit2.InputMask = "###-###-####";
    ((Control) this.MgaMaskedEdit2).Location = new Point(376, 31 /*0x1F*/);
    this.MgaMaskedEdit2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaMaskedEdit2).Name = "MgaMaskedEdit2";
    this.MgaMaskedEdit2.NonAutoSizeHeight = 20;
    ((Control) this.MgaMaskedEdit2).Size = new Size(77, 20);
    ((Control) this.MgaMaskedEdit2).TabIndex = 6;
    this.MgaMaskedEdit2.Text = "--";
    ((UltraControlBase) this.MgaMaskedEdit2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaMaskedEdit2).UseOsThemes = (DefaultableBoolean) 2;
    this.MgaSimpleComboBox4.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox4).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.LocationTypeID", true));
    ((UltraGridBase) this.MgaSimpleComboBox4).DataSource = (object) this.dsCompany.lstLocationType;
    ((UltraDropDownBase) this.MgaSimpleComboBox4).DisplayMember = "LocationType";
    this.MgaSimpleComboBox4.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox4).Location = new Point(376, 188);
    this.MgaSimpleComboBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox4).Name = "MgaSimpleComboBox4";
    ((Control) this.MgaSimpleComboBox4).Size = new Size(140, 20);
    ((Control) this.MgaSimpleComboBox4).TabIndex = 13;
    ((UltraControlBase) this.MgaSimpleComboBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox4).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox4).ValueMember = "LocationTypeID";
    this.MgaSimpleComboBox5.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaSimpleComboBox5).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.DeliveryMethodID", true));
    ((UltraGridBase) this.MgaSimpleComboBox5).DataSource = (object) this.dsCompany.lstDeliveryMethod;
    ((UltraDropDownBase) this.MgaSimpleComboBox5).DisplayMember = "Description";
    this.MgaSimpleComboBox5.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox5).Location = new Point(376, 144 /*0x90*/);
    this.MgaSimpleComboBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox5).Name = "MgaSimpleComboBox5";
    ((Control) this.MgaSimpleComboBox5).Size = new Size(140, 20);
    ((Control) this.MgaSimpleComboBox5).TabIndex = 11;
    ((UltraControlBase) this.MgaSimpleComboBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaSimpleComboBox5).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaSimpleComboBox5).ValueMember = "DeliveryMethodID";
    appearance54.BackColor = Color.White;
    appearance54.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance54.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance54;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.WebSite", true));
    ((Control) this.MgaTextBox4).Location = new Point(376, 100);
    this.MgaTextBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(140, 19);
    ((Control) this.MgaTextBox4).TabIndex = 9;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(340, 33);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(27, 13);
    this.Label34.TabIndex = 9;
    this.Label34.Text = "Fax:";
    this.Label34.TextAlign = ContentAlignment.MiddleRight;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(326, 212);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(41, 13);
    this.Label35.TabIndex = 25;
    this.Label35.Text = "Added:";
    this.Label35.TextAlign = ContentAlignment.MiddleRight;
    appearance55.BackColorDisabled = Color.Gainsboro;
    appearance55.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaMaskedEdit3.Appearance = (AppearanceBase) appearance55;
    ((Control) this.MgaMaskedEdit3).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.ClaimFax", true));
    this.MgaMaskedEdit3.EditAs = (EditAsType) 1;
    this.MgaMaskedEdit3.InputMask = "###-###-####";
    ((Control) this.MgaMaskedEdit3).Location = new Point(376, 77);
    this.MgaMaskedEdit3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaMaskedEdit3).Name = "MgaMaskedEdit3";
    this.MgaMaskedEdit3.NonAutoSizeHeight = 20;
    ((Control) this.MgaMaskedEdit3).Size = new Size(77, 20);
    ((Control) this.MgaMaskedEdit3).TabIndex = 8;
    this.MgaMaskedEdit3.Text = "--";
    ((UltraControlBase) this.MgaMaskedEdit3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaMaskedEdit3).UseOsThemes = (DefaultableBoolean) 2;
    appearance56.BackColorDisabled = Color.Gainsboro;
    appearance56.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaMaskedEdit4.Appearance = (AppearanceBase) appearance56;
    ((Control) this.MgaMaskedEdit4).DataBindings.Add(new Binding("Value", (object) this.dsCompany, "tblCompanyLocations.ClaimPhone", true));
    this.MgaMaskedEdit4.EditAs = (EditAsType) 1;
    this.MgaMaskedEdit4.InputMask = "###-###-####";
    ((Control) this.MgaMaskedEdit4).Location = new Point(376, 54);
    this.MgaMaskedEdit4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaMaskedEdit4).Name = "MgaMaskedEdit4";
    this.MgaMaskedEdit4.NonAutoSizeHeight = 20;
    ((Control) this.MgaMaskedEdit4).Size = new Size(77, 20);
    ((Control) this.MgaMaskedEdit4).TabIndex = 7;
    this.MgaMaskedEdit4.Text = "--";
    ((UltraControlBase) this.MgaMaskedEdit4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaMaskedEdit4).UseOsThemes = (DefaultableBoolean) 2;
    appearance57.BackColor = Color.White;
    appearance57.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance57.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox6).Appearance = (AppearanceBase) appearance57;
    ((TextEditorControlBase) this.MgaTextBox6).BackColor = Color.White;
    ((Control) this.MgaTextBox6).DataBindings.Add(new Binding("Text", (object) this.dsCompany, "tblCompanyLocations.Email", true));
    ((Control) this.MgaTextBox6).Location = new Point(376, 122);
    this.MgaTextBox6.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox6).Name = "MgaTextBox6";
    ((Control) this.MgaTextBox6).Size = new Size(140, 19);
    ((Control) this.MgaTextBox6).TabIndex = 10;
    ((UltraControlBase) this.MgaTextBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox6).UseOsThemes = (DefaultableBoolean) 2;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(331, 124);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(35, 13);
    this.Label36.TabIndex = 17;
    this.Label36.Text = "Email:";
    this.Label36.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraLabel1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance58.BackColor = Color.Transparent;
    appearance58.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance58).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance58).TextVAlignAsString = "Middle";
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance58;
    ((ControlBase) this.UltraLabel1).BackColorInternal = Color.Gainsboro;
    this.UltraLabel1.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.UltraLabel1).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraLabel1).Location = new Point(156, 290);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(88, 16 /*0x10*/);
    ((Control) this.UltraLabel1).TabIndex = 29;
    ((Control) this.UltraLabel1).Tag = (object) "KeepEnabled";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.MgaButton7);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.MgaListBox1);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.MgaButton8);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(692, 321);
    this.MgaListBox1.ContextMenu = this.mnuContacts;
    this.MgaListBox1.DataSource = (object) this.dsCompany.tblCompanyContacts;
    this.MgaListBox1.DisplayMember = "Name";
    this.MgaListBox1.Location = new Point(8, 8);
    this.MgaListBox1.MGAStyle = MGAStyles.Blue;
    this.MgaListBox1.Name = "MgaListBox1";
    this.MgaListBox1.Size = new Size(322, 223);
    this.MgaListBox1.TabIndex = 0;
    this.MgaListBox1.ValueMember = "CompanyContactGuid";
    this.TextBox3.Location = new Point(525, 71);
    this.TextBox3.Name = "TextBox3";
    this.TextBox3.Size = new Size(155, 21);
    this.TextBox3.TabIndex = 44;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(712, 506);
    this.Controls.Add((Control) this.tabLocations);
    this.Controls.Add((Control) this.gbCompany);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmCompanies_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmCompanies);
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).PerformLayout();
    ((ISupportInitialize) this.cboFSR).EndInit();
    this.dsCompany.EndInit();
    ((ISupportInitialize) this.cboFSC).EndInit();
    ((ISupportInitialize) this.cboRatingBureau).EndInit();
    ((Control) this.UltraTabPageControl6).ResumeLayout(false);
    ((ISupportInitialize) this.pbLogo).EndInit();
    ((ISupportInitialize) this.btnNewImage).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtStatusChangeReason).EndInit();
    ((ISupportInitialize) this.chkFatcaNonCompliant).EndInit();
    ((ISupportInitialize) this.cboAddedBy).EndInit();
    ((ISupportInitialize) this.chkDisallowBinding).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.cboIntermediary).EndInit();
    ((ISupportInitialize) this.cbStatus).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.txtFax).EndInit();
    ((ISupportInitialize) this.cbOfficeType).EndInit();
    ((ISupportInitialize) this.cboDeliveryMethod).EndInit();
    ((ISupportInitialize) this.txtWebSite).EndInit();
    ((ISupportInitialize) this.txtLocation).EndInit();
    ((ISupportInitialize) this.txtClaimFax).EndInit();
    ((ISupportInitialize) this.txtClaimPhone).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    ((ISupportInitialize) this.btnNewCompanyLocation).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnLast).EndInit();
    ((ISupportInitialize) this.btnFirst).EndInit();
    ((ISupportInitialize) this.btnPrev).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.btnNewContact).EndInit();
    ((ISupportInitialize) this.lstContacts).EndInit();
    ((ISupportInitialize) this.btnContacts).EndInit();
    ((Control) this.UltraTabPageControl7).ResumeLayout(false);
    ((Control) this.UltraTabPageControl7).PerformLayout();
    ((ISupportInitialize) this.btnNetRateImport).EndInit();
    ((ISupportInitialize) this.txtXMLDialogue).EndInit();
    ((ISupportInitialize) this.btnXMLDialogue).EndInit();
    ((ISupportInitialize) this.txtNetRateID).EndInit();
    ((ISupportInitialize) this.txtNetRateName).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox5).EndInit();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    ((ISupportInitialize) this.MgaButton2).EndInit();
    ((ISupportInitialize) this.MgaButton3).EndInit();
    ((ISupportInitialize) this.MgaButton4).EndInit();
    ((ISupportInitialize) this.MgaButton5).EndInit();
    ((ISupportInitialize) this.MgaButton6).EndInit();
    ((ISupportInitialize) this.MgaButton7).EndInit();
    ((ISupportInitialize) this.MgaButton8).EndInit();
    ((ISupportInitialize) this.ErrProvider).EndInit();
    ((ISupportInitialize) this.gbCompany).EndInit();
    ((Control) this.gbCompany).ResumeLayout(false);
    ((Control) this.gbCompany).PerformLayout();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.txtNCCI).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.txtBureauNum).EndInit();
    ((ISupportInitialize) this.txtNAIC).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.btnGroups).EndInit();
    ((ISupportInitialize) this.cboGroup).EndInit();
    ((ISupportInitialize) this.txtCompanyName).EndInit();
    ((ISupportInitialize) this.tabLocations).EndInit();
    ((Control) this.tabLocations).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.mnuCompanies).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox2).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox3).EndInit();
    ((ISupportInitialize) this.MgaMaskedEdit1).EndInit();
    ((ISupportInitialize) this.MgaMaskedEdit2).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox4).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox5).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.MgaMaskedEdit3).EndInit();
    ((ISupportInitialize) this.MgaMaskedEdit4).EndInit();
    ((ISupportInitialize) this.MgaTextBox6).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.MgaListBox1).EndInit();
    this.ResumeLayout(false);
  }

  public BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.dsCompany, this.dsCompany.tblCompanyLocations.TableName];
    }
  }

  public Guid CompanyGuid => this._companyGuid;

  internal dsCompanies.tblCompanyLocationsRow CurrentLocationRow
  {
    get
    {
      return this.bmb.Position == -1 || this.dsCompany.tblCompanyLocations.Count < this.bmb.Position ? (dsCompanies.tblCompanyLocationsRow) null : this.dsCompany.tblCompanyLocations[this.bmb.Position];
    }
  }

  public bool IsNewCompany => this._newCompany;

  public bool AddingNewCompany => this._addCompany;

  public bool QuoteInformationInvocation
  {
    get => this._quoteOfficeInvocation;
    set => this._quoteOfficeInvocation = value;
  }

  public Guid QuotingOfficeGuid
  {
    get => this._quotingOfficeGuid;
    set => this._quotingOfficeGuid = value;
  }

  public string QuoteInvocationLocationGuids => this._quoteLocationGuids;

  public frmCompanies(Guid companyGuid)
  {
    this.Load += new EventHandler(this.frmCompanies_Load);
    this._formLoading = false;
    this._newCompany = false;
    this._addCompany = true;
    this._quotingOfficeGuid = Guid.Empty;
    this._quotingOfficeZip = string.Empty;
    this._quotingOfficeCity = string.Empty;
    this._quotingOfficeState = string.Empty;
    this._quoteOfficeInvocation = false;
    this._quoteLocationGuids = string.Empty;
    this._defaultOfficeType = 6;
    this.InitializeComponent();
    this._companyGuid = companyGuid;
    this._addCompany = false;
  }

  public frmCompanies(Guid companyGuid, Guid companyLocationGuid)
  {
    this.Load += new EventHandler(this.frmCompanies_Load);
    this._formLoading = false;
    this._newCompany = false;
    this._addCompany = true;
    this._quotingOfficeGuid = Guid.Empty;
    this._quotingOfficeZip = string.Empty;
    this._quotingOfficeCity = string.Empty;
    this._quotingOfficeState = string.Empty;
    this._quoteOfficeInvocation = false;
    this._quoteLocationGuids = string.Empty;
    this._defaultOfficeType = 6;
    this.InitializeComponent();
    this._companyGuid = companyGuid;
    this._moveToCompanyLocationGuid = companyLocationGuid;
    this._addCompany = false;
  }

  public frmCompanies()
  {
    this.Load += new EventHandler(this.frmCompanies_Load);
    this._formLoading = false;
    this._newCompany = false;
    this._addCompany = true;
    this._quotingOfficeGuid = Guid.Empty;
    this._quotingOfficeZip = string.Empty;
    this._quotingOfficeCity = string.Empty;
    this._quotingOfficeState = string.Empty;
    this._quoteOfficeInvocation = false;
    this._quoteLocationGuids = string.Empty;
    this._defaultOfficeType = 6;
    this.InitializeComponent();
    if (this.DesignMode)
      return;
    this.dsCompany.EnforceConstraints = false;
  }

  internal void LoadContacts()
  {
    if (this.bmb.Position < 0 || !((Control) this.tabLocations).Enabled)
      return;
    MDIControls.Instance.StatusBarText = "Getting company contacts...";
    object obj = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboIntermediary.Text, string.Empty, false) == 0 ? (object) null : (object) (Guid) this.cboIntermediary.Value;
    try
    {
      if (this.CurrentLocationRow.CompanyLocationGuid.Equals(Guid.Empty))
        return;
    }
    catch (RowNotInTableException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    this.dsCompany.tblCompanyContacts.Clear();
    if (this._formLoading && !this._moveToCompanyLocationGuid.Equals(Guid.Empty))
      DefaultDatabase.LoadDataSet((DataSet) this.dsCompany, new string[1]
      {
        "tblCompanyContacts"
      }, "[spGetCompanyContacts]", new object[4]
      {
        (object) "@IntermediaryGuid",
        obj,
        (object) "@CompanyLocationGuid",
        (object) this._moveToCompanyLocationGuid
      });
    else
      DefaultDatabase.LoadDataSet((DataSet) this.dsCompany, new string[1]
      {
        "tblCompanyContacts"
      }, "[spGetCompanyContacts]", new object[4]
      {
        (object) "@IntermediaryGuid",
        obj,
        (object) "@CompanyLocationGuid",
        (object) this.CurrentLocationRow.CompanyLocationGuid
      });
    this.lstContacts.Enabled = this.dsCompany.tblCompanyContacts.Rows.Count > 0;
    ((Control) this.btnContacts).Enabled = this.lstContacts.Enabled;
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  string IRecreatableEntity.FriendlyEntityName => "Company";

  string IRecreatableEntity.RecreateTypeName => typeof (frmCompanies).ToString();

  public bool CanCreateNewNote
  {
    get
    {
      return this.dsCompany.tblCompanyLocations.Rows.Count > 0 && this.CurrentLocationRow.RowState != DataRowState.Added;
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      string entityName;
      try
      {
        entityName = !this.CurrentLocationRow.IsLocationNameNull() ? this.CurrentLocationRow.LocationName : string.Empty;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      entityName = string.Empty;
label_3:
      return entityName;
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      Guid entityGuid;
      try
      {
        if (this.CurrentLocationRow.RowState == DataRowState.Unchanged || this.CurrentLocationRow.RowState == DataRowState.Modified)
        {
          string locationName = this.CurrentLocationRow.LocationName;
          entityGuid = this.CurrentLocationRow.CompanyLocationGuid;
        }
        else
          entityGuid = new Guid();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        entityGuid = new Guid();
        ProjectData.ClearProjectError();
      }
      return entityGuid;
    }
  }

  private void CheckNetRate()
  {
    try
    {
      Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MgaSystems.NetRate.dll"));
    }
    catch (FileNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ((UltraTabControlBase) this.tabLocations).Tabs["tabNetRate"].Visible = false;
      ProjectData.ClearProjectError();
    }
  }

  private void SetQuoteInformation()
  {
    if (this.QuotingOfficeGuid.Equals(Guid.Empty))
      return;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ZipCode, City, State FROM tblClientOffices WITH (NOLOCK) WHERE OfficeGUID = @OG", new object[2]
    {
      (object) "@OG",
      (object) this.QuotingOfficeGuid
    });
    if (dataRow != null)
    {
      if (dataRow[0] != DBNull.Value)
        this._quotingOfficeZip = dataRow[0].ToString();
      if (dataRow[1] != DBNull.Value)
        this._quotingOfficeCity = dataRow[1].ToString();
      if (dataRow[2] != DBNull.Value)
        this._quotingOfficeState = dataRow[2].ToString();
    }
    if (!MGASystems.Common.SystemSettings.KeyExists("PlaceHolderOfficeTypeID"))
      return;
    this._defaultOfficeType = Convert.ToInt32(MGASystems.Common.SystemSettings.GetNumericSetting("PlaceHolderOfficeTypeID"));
  }

  private void frmCompanies_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.CheckNetRate();
    MGA_ZipCodeResolver companyLocationZip = this.ctlCompanyLocationZip;
    companyLocationZip.ShowStreets = true;
    companyLocationZip.ShowGlobal = true;
    AppSettingsReader appSettingsReader = new AppSettingsReader();
    Cursor.Current = MgaCursors.WaitCursor;
    ImageCache instance1 = ImageCache.Instance;
    ((ControlBase) this.btnNewCompanyLocation).Appearance.Image = (object) instance1.NewImage;
    ((ControlBase) this.btnDelete).Appearance.Image = (object) instance1.Delete;
    ((ControlBase) this.btnNewContact).Appearance.Image = (object) instance1.NewImage;
    ((ControlBase) this.btnContacts).Appearance.Image = (object) instance1.Forward;
    ((ControlBase) this.btnFirst).Appearance.Image = (object) instance1.MoveFirst;
    ((ControlBase) this.btnPrev).Appearance.Image = (object) instance1.MovePrev;
    ((ControlBase) this.btnNext).Appearance.Image = (object) instance1.MoveNext;
    ((ControlBase) this.btnNewImage).Appearance.Image = (object) instance1.Open;
    ((ControlBase) this.btnLast).Appearance.Image = (object) instance1.MoveLast;
    this.SetupSecurity();
    this.SetQuoteInformation();
    this.dsCompany.tblCompanyContacts.DefaultView.RowFilter = "StatusID=1";
    MDIControls instance2 = MDIControls.Instance;
    instance2.ProgressBar.Maximum = 4;
    instance2.ProgressBar.Value = 0;
    instance2.ProgressPanel.Visible = true;
    this.FillListTables();
    this.PopulateDataSet();
    try
    {
      this.dsCompany.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.dsCompany, ex);
      ProjectData.ClearProjectError();
    }
    if (this.dsCompany.tblCompanyLocations.Rows.Count <= 0 || ((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      ((Control) this.btnNewContact).Enabled = false;
      ((Control) this.btnContacts).Enabled = false;
      this.SetMenuEnabled(frmCompanies.MenuState.Enabled);
    }
    this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
    this.UpdateLocationsNavDisplay();
    this.cboIntermediary.ValueChanged += new EventHandler(this.cboIntermediary_ValueChanged);
    this.rbLocation.CheckedChanged += new EventHandler(this.RadioChanged);
    this.rbIntermediary.CheckedChanged += new EventHandler(this.RadioChanged);
    if (this.dsCompany.tblCompanyLocations.Count > 0 && this.dsCompany.tblCompanyLocations[0].RowState == DataRowState.Added)
    {
      this.RadioChanged((object) null, EventArgs.Empty);
      this.dbSave.UIState = UIState.Editing;
    }
    else if (this.AddingNewCompany)
    {
      this.NewCompany();
      this.dbSave.UIState = UIState.Editing;
    }
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    MDIControls instance3 = MDIControls.Instance;
    instance3.StatusBarText = string.Empty;
    instance3.ProgressPanel.Visible = false;
    if (!this._moveToCompanyLocationGuid.Equals(Guid.Empty))
    {
      Database.MoveTo((object) this._moveToCompanyLocationGuid, "CompanyLocationGuid", (DataTable) this.dsCompany.tblCompanyLocations, this.bmb);
      this.dsCompany.AcceptChanges();
    }
    this._formLoading = true;
    this.LoadContacts();
    this._formLoading = false;
    this.SetFormControlsEnabledState();
    this.AfterLoadComplete();
    Cursor.Current = MgaCursors.Default;
  }

  protected virtual bool IntermediaryCheck(Guid companyLocationguid) => false;

  protected virtual void AfterLoadComplete()
  {
  }

  protected virtual void AddMenuItem(string key, string caption)
  {
    if (((ToolsCollectionBase) this.mnuCompanies.Tools).Exists(key))
      return;
    ButtonTool buttonTool = new ButtonTool(key);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = caption;
    this.mnuCompanies.Tools.Add((ToolBase) buttonTool);
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.mnuCompanies.Toolbars[0]).Tools)[0]).Tools).Add((ToolBase) buttonTool);
    this.mnuCompanies.RefreshMerge();
  }

  protected virtual void AfterSave()
  {
    CompanyContext context = new CompanyContext(this.CompanyGuid, this.CompanyName);
    if (!this.IsNewCompany)
      return;
    MGASystems.IMS.Logging.Log.Write("Sending BroadcastMessages.CarrierAdded", "IMS.Insured.Producers.Companies.frmCompanies");
    Messaging.SendBroadcastMessage(BroadcastMessages.CarrierAdded, (object) context);
  }

  protected virtual void NavigateOnClient()
  {
  }

  protected virtual void SetClientControlsState(bool isEditing)
  {
  }

  protected virtual bool DerivedFormValidation(ErrorProvider e) => true;

  private void mnuCompanies_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    ((ToolsCollectionBase) this.mnuCompanies.Tools)["Company_Lines"].SharedProps.Enabled = this.dsCompany.tblCompanyLocations.Count > 0;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{696C8A8B-4D78-4b68-96E0-B4C3EF44C406}"))
    {
      int num1 = (int) MessageBox.Show("You are not authorized to delete companies.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this company?", "Delete Company?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes || MessageBox.Show("Are you sure?  This will delete all information associated with this company, including but not limited to:\n\nProducer Marketing Setups\nCompany Forms/Conditions/Warranties\nCompany Fee Automation Setups\nCompany/Line/State Setups\nAutomated Commissions\nCompany Class Codes", "Warning: Delete Can Not Be Undone!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        return;
      List<Guid> guidList = new List<Guid>();
      try
      {
        foreach (dsCompanies.tblCompanyLocationsRow tblCompanyLocation in (TypedTableBase<dsCompanies.tblCompanyLocationsRow>) this.dsCompany.tblCompanyLocations)
          guidList.Add(tblCompanyLocation.CompanyLocationGuid);
      }
      finally
      {
        IEnumerator<dsCompanies.tblCompanyLocationsRow> enumerator;
        enumerator?.Dispose();
      }
      Form[] mdiChildren1 = MDIControls.Instance.MDIParent.MdiChildren;
      int index1 = 0;
      while (index1 < mdiChildren1.Length)
      {
        if (mdiChildren1[index1] is frmSelection frmSelection)
        {
          if (frmSelection.SelectionType == frmSelection.SelectionTypes.Company)
          {
            try
            {
              foreach (Guid valueGuid in guidList)
                frmSelection.RemoveItem(valueGuid);
            }
            finally
            {
              List<Guid>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
        checked { ++index1; }
      }
      try
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblCompanies WHERE CompanyGuid=@CG", new object[2]
        {
          (object) "@CG",
          (object) this._companyGuid
        });
        this.Close();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (ex2.Message.Contains("FK_tblQuoteOptionCharges_tblCompanyLines"))
        {
          int num2 = (int) MessageBox.Show("This company can not be removed, because it is associated with fees on existing policies.", "Unable to Delete Company", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
          return;
        }
        if (ex2.Message.Contains("FK_tblQuotes_tblCompanyLocations"))
        {
          int num3 = (int) MessageBox.Show("This company can not be removed, because it is associated with existing policies.", "Unable To Delete Company", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
          return;
        }
        if (ex2.Message.Contains("FK_tblPremiumAllocationCompanies_tblCompanyLocations"))
        {
          int num4 = (int) MessageBox.Show("This company can not be removed, because it has premium allocated to it.", "Unable To Delete Company", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
          return;
        }
        if (ex2.Message.Contains("FK_tblCompanyLines_tblCompanyLocations'"))
        {
          int num5 = (int) MessageBox.Show("This company location can not be removed, because it has one or more company/line configurations established", "Can Not Remove Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
          return;
        }
        ErrorHandler.HandleError(ex2);
        ProjectData.ClearProjectError();
        return;
      }
      CurrentUser.Instance.LogAction("Deleted Company: " + ((TextEditorControlBase) this.txtCompanyName).Text, this.CompanyGuid);
      Form[] mdiChildren2 = MDIControls.Instance.MDIParent.MdiChildren;
      int index2 = 0;
      while (index2 < mdiChildren2.Length)
      {
        Form form = mdiChildren2[index2];
        if (form is frmSelection && ((frmSelection) form).SelectionType == frmSelection.SelectionTypes.Company)
          ((frmSelection) form).RemoveItem(this.dsCompany.tblCompanies[0].CompanyGuid);
        checked { ++index2; }
      }
    }
  }

  private void FillListTables()
  {
    dsCompanies.lstFSRRow row1 = this.dsCompany.lstFSR.NewlstFSRRow();
    row1.FSR = string.Empty;
    this.dsCompany.lstFSR.AddlstFSRRow(row1);
    dsCompanies.lstFSCRow row2 = this.dsCompany.lstFSC.NewlstFSCRow();
    row2.FSC = string.Empty;
    this.dsCompany.lstFSC.AddlstFSCRow(row2);
    dsCompanies.lstRatingBureauRow row3 = this.dsCompany.lstRatingBureau.NewlstRatingBureauRow();
    row3.RatingBureau = string.Empty;
    this.dsCompany.lstRatingBureau.AddlstRatingBureauRow(row3);
    this.dsCompany.AcceptChanges();
  }

  private void SetupSecurity()
  {
    if (!SecurityManager.Instance.AssertPermission("{E9AFDA12-51D8-4eb8-8040-0E8DBB7DE16A}"))
      ((Control) this.btnNewCompanyLocation).Enabled = false;
    ((ToolsCollectionBase) this.mnuCompanies.Tools)["Company_Lines"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{A43461BA-305B-4911-8AE3-145BCBD9B9F8}");
  }

  private void RadioChanged(object sender, EventArgs e)
  {
    if (this.CurrentLocationRow != null)
    {
      if (!this.rbIntermediary.Checked)
      {
        try
        {
          this.CurrentLocationRow.SetIntermediaryGuidNull();
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          this.CurrentLocationRow.SetIntermediaryGuidNull();
          ProjectData.ClearProjectError();
        }
        ((UltraDropDownBase) this.cboIntermediary).SelectedRow = (UltraGridRow) null;
      }
    }
    ((Control) this.cboIntermediary).Enabled = this.rbIntermediary.Checked;
  }

  private void Navigation(object sender, EventArgs e)
  {
    this.bmb.EndCurrentEdit();
    if (this.dsCompany.HasChanges())
    {
      switch (MessageBox.Show("You have unsaved changes on this record.  Would you like to save?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
      {
        case DialogResult.Cancel:
          return;
        case DialogResult.Yes:
          if (!this.SaveChanges())
          {
            int num = (int) MessageBox.Show("Please complete current location.", "Incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          break;
        default:
          this.dsCompany.tblCompanyLocations.RejectChanges();
          break;
      }
    }
    this.cboIntermediary.ValueChanged -= new EventHandler(this.cboIntermediary_ValueChanged);
    if (sender == this.btnNext)
    {
      BindingManagerBase bmb;
      int num = (bmb = this.bmb).Position + 1;
      bmb.Position = num;
    }
    else if (sender == this.btnFirst)
      this.bmb.Position = 0;
    else if (sender == this.btnLast)
      this.bmb.Position = this.bmb.Count - 1;
    else if (sender == this.btnPrev)
    {
      BindingManagerBase bmb;
      int num = (bmb = this.bmb).Position - 1;
      bmb.Position = num;
    }
    this.LoadContacts();
    this.NavigateOnClient();
    this.bmb.EndCurrentEdit();
    this.dsCompany.tblCompanyLocations.AcceptChanges();
    this.cboIntermediary.ValueChanged += new EventHandler(this.cboIntermediary_ValueChanged);
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent == null)
      return;
    infoChangedEvent((object) this, EventArgs.Empty);
  }

  protected virtual void mnuCompanies_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (this.dsCompany.tblCompanies[0].RowState == DataRowState.Added || this.dsCompany.tblCompanyLocations[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save your changes before continuing.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      string key = ((ToolEventArgs) e).Tool.Key;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Company_Lines", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Producer Information", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Company Strength", false) != 0)
            return;
          using (FormSettings.ShowFormDialog(typeof (FormCompanyStrength)))
            ;
        }
        else
        {
          Cursor.Current = MgaCursors.WaitCursor;
          try
          {
            using (FormSettings.ShowFormDialog(typeof (frmCompanyProducerInfo), (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT CompanyID FROM tblCompanies WHERE CompanyGuid=@CG", new object[2]
            {
              (object) "@CG",
              (object) this._companyGuid
            })))
              ;
          }
          finally
          {
            Cursor.Current = MgaCursors.Default;
          }
        }
      }
      else
      {
        Cursor.Current = MgaCursors.WaitCursor;
        try
        {
          frmCompanyLines frmCompanyLines = (frmCompanyLines) ObjectFactory.Instance.CreateObject(typeof (frmCompanyLines));
          frmCompanyLines.CompanyLocationGuidFilter = this.dsCompany.tblCompanyLocations[this.bmb.Position].CompanyLocationGuid;
          frmCompanyLines.MdiParent = MDIControls.Instance.MDIParent;
          frmCompanyLines.Show();
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
      }
    }
  }

  private void SetMenuEnabled(frmCompanies.MenuState state)
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.mnuCompanies.Toolbars[0]).Tools)["Company"].SharedProps.Enabled = state == frmCompanies.MenuState.Enabled;
  }

  private void ContactsMenuClick(object sender, EventArgs e)
  {
    try
    {
      foreach (MenuItem menuItem in this.mnuContacts.MenuItems)
        menuItem.Checked = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((MenuItem) sender).Checked = true;
    if (this.mnuInactive.Checked)
      this.dsCompany.tblCompanyContacts.DefaultView.RowFilter = "StatusID=2";
    else if (this.mnuActive.Checked)
      this.dsCompany.tblCompanyContacts.DefaultView.RowFilter = "StatusID=1";
    else
      this.dsCompany.tblCompanyContacts.DefaultView.RowFilter = string.Empty;
  }

  private void NewCompany()
  {
    this.dsCompany.tblCompanyContacts.Clear();
    this.dsCompany.tblCompanyLocations.Clear();
    this.dsCompany.tblCompanies.Clear();
    dsCompanies.tblCompaniesRow row = this.dsCompany.tblCompanies.NewtblCompaniesRow();
    this._companyGuid = Guid.NewGuid();
    row.CompanyGuid = this._companyGuid;
    this.dsCompany.tblCompanies.AddtblCompaniesRow(row);
    this.NewLocation();
    this.UpdateLocationsNavDisplay();
  }

  private string GenerateCompanyLocationCode()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT MAX(CompanyLocationCode) FROM tblCompanyLocations"));
    return MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? "1" : (Conversions.ToInteger(objectValue) + 1).ToString();
  }

  protected virtual void NewLocation()
  {
    this.GenerateCompanyLocationCode();
    int num = this.dsCompany.tblCompanyLocations.Count == 0 ? 1 : 0;
    dsCompanies.tblCompanyLocationsRow row = this.dsCompany.tblCompanyLocations.NewtblCompanyLocationsRow();
    row.CompanyLocationGuid = Guid.NewGuid();
    row.CompanyGuid = this._companyGuid;
    row.DateAdded = DateAndTime.Now;
    row.AddedBy = CurrentUser.Instance.UserGUID;
    if (num != 0)
    {
      row.LocationTypeID = 1;
      ((Control) this.cbOfficeType).Enabled = false;
    }
    else
      ((Control) this.cbOfficeType).Enabled = true;
    if (!this.QuotingOfficeGuid.Equals(Guid.Empty))
    {
      row.ZipCode = this._quotingOfficeZip.Trim();
      row.City = this._quotingOfficeCity;
      row.State = this._quotingOfficeState;
      row.Address1 = "N/A";
      row.LocationTypeID = this._defaultOfficeType;
      row.DeliveryMethodID = 1;
      row.StatusID = 1;
      ((Control) this.cbOfficeType).Enabled = true;
    }
    this.dsCompany.tblCompanyLocations.BeginLoadData();
    this.dsCompany.tblCompanyLocations.AddtblCompanyLocationsRow(row);
    this.dsCompany.tblCompanyLocations.EndLoadData();
    this.bmb.EndCurrentEdit();
    this.bmb.Position = this.bmb.Count - 1;
    this.dsCompany.tblCompanyContacts.Clear();
    if (((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      ((Control) this.btnNewContact).Enabled = false;
      ((Control) this.btnContacts).Enabled = false;
      this.SetMenuEnabled(frmCompanies.MenuState.Disabled);
    }
    else
    {
      ((Control) this.btnNewContact).Enabled = true;
      ((Control) this.btnContacts).Enabled = true;
      this.SetMenuEnabled(frmCompanies.MenuState.Enabled);
    }
    ((Control) this.tabLocations).Enabled = true;
  }

  private void btnNewCompanyLocation_Click(object sender, EventArgs e)
  {
    if (this.validateForm())
    {
      ((Control) this.btnNewCompanyLocation).Enabled = false;
      this.SaveChanges();
      this.NewLocation();
      ((Control) this.btnNewCompanyLocation).Enabled = true;
    }
    else
    {
      int num = (int) MessageBox.Show("Please complete current location before adding additional locations.", "Incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private bool NoItemSelected(MGASimpleComboBox cbo)
  {
    return ((Control) cbo).Enabled && (((UltraDropDownBase) cbo).SelectedRow == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraDropDownBase) cbo).SelectedRow.Cells[((UltraDropDownBase) cbo).DisplayMember].Value.ToString(), string.Empty, false) == 0);
  }

  private bool validateForm()
  {
    bool flag = true;
    if (this.rbIntermediary.Checked && this.cboIntermediary.Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.cboIntermediary, "Please select an intermediary.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cboIntermediary, string.Empty);
    if (((TextEditorControlBase) this.txtCompanyName).Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtCompanyName, "Please enter a name for this company.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.txtCompanyName, string.Empty);
    if (this.NoItemSelected(this.cbStatus))
    {
      this.ErrProvider.SetError((Control) this.cbStatus, "Please select a status for this company.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cbStatus, string.Empty);
    if (this.NoItemSelected(this.cbOfficeType))
    {
      this.ErrProvider.SetError((Control) this.cbOfficeType, "Please select an office type for this company.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.cbOfficeType, string.Empty);
    if (((TextEditorControlBase) this.txtLocation).Text.Length == 0)
    {
      this.ErrProvider.SetError((Control) this.txtLocation, "Please enter a location name for this company.");
      flag = false;
    }
    else
      this.ErrProvider.SetError((Control) this.txtLocation, string.Empty);
    if (!this.ctlCompanyLocationZip.ValidateFields())
      flag = false;
    if (this.NoItemSelected(this.cboDeliveryMethod))
    {
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, "Please enter a delivery method.");
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 3 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) == 0)
    {
      this.ErrProvider.SetError((Control) this.txtEmail, "Email must be provided when selecting email delivery type.");
      this.ErrProvider.SetError((Control) this.txtFax, string.Empty);
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
      flag = false;
    }
    else if (Conversions.ToInteger(this.cboDeliveryMethod.Value) == 2 && this.txtFax.Value == DBNull.Value | this.txtFax.Value == (object) string.Empty)
    {
      this.ErrProvider.SetError((Control) this.txtFax, "Fax number must be provided when selecting fax delivery type.");
      this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
      flag = false;
    }
    else
    {
      this.ErrProvider.SetError((Control) this.txtEmail, string.Empty);
      this.ErrProvider.SetError((Control) this.txtFax, string.Empty);
      this.ErrProvider.SetError((Control) this.cboDeliveryMethod, string.Empty);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtEmail).Text, string.Empty, false) != 0 && !Parsing.IsValidEmailAddress(((TextEditorControlBase) this.txtEmail).Text))
    {
      this.ErrProvider.SetError((Control) this.txtEmail, "Please enter a valid email address.");
      flag = false;
    }
    try
    {
      try
      {
        foreach (dsCompanies.tblCompanyLocationsRow tblCompanyLocation in (TypedTableBase<dsCompanies.tblCompanyLocationsRow>) this.dsCompany.tblCompanyLocations)
        {
          if (tblCompanyLocation.RowState != DataRowState.Deleted && !tblCompanyLocation.IsLocationNameNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblCompanyLocation.LocationName, ((TextEditorControlBase) this.txtLocation).Text, false) == 0 && !tblCompanyLocation.CompanyLocationGuid.Equals(this.CurrentLocationRow.CompanyLocationGuid))
          {
            this.ErrProvider.SetError((Control) this.txtLocation, "Location names must be unique.");
            flag = false;
          }
        }
      }
      finally
      {
        IEnumerator<dsCompanies.tblCompanyLocationsRow> enumerator;
        enumerator?.Dispose();
      }
    }
    catch (RowNotInTableException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    if (flag)
      flag = this.DerivedFormValidation(this.ErrProvider);
    return flag;
  }

  private bool SaveChanges()
  {
    bool flag1 = this.validateForm();
    bool flag2;
    if (!flag1)
    {
      flag2 = false;
    }
    else
    {
      try
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboGroup.Text, string.Empty, false) == 0 && !this.dsCompany.tblCompanies[0].IsCompanyGroupGuidNull())
          this.dsCompany.tblCompanies[0].SetCompanyGroupGuidNull();
        if (string.IsNullOrEmpty(this.cboFSC.Text))
          this.dsCompany.tblCompanies[0].SetFSCNull();
        if (string.IsNullOrEmpty(this.cboFSR.Text))
          this.dsCompany.tblCompanies[0].SetFSRNull();
        if (string.IsNullOrEmpty(this.cboRatingBureau.Text))
          this.dsCompany.tblCompanies[0].SetRatingBureauIDNull();
        this.BindingContext[(object) this.dsCompany, this.dsCompany.tblCompanies.TableName].EndCurrentEdit();
        this.bmb.EndCurrentEdit();
        if (flag1 && this.CurrentLocationRow.RowState == DataRowState.Modified && Conversions.ToInteger(this.cbOfficeType.Value) == 2)
        {
          if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblCompanyLines WHERE CompanyLocationGuid=@CLG", new object[2]
          {
            (object) "@CLG",
            (object) this.CurrentLocationRow.CompanyLocationGuid
          }) > 0)
          {
            int num = (int) MessageBox.Show("This location already has company/lines assigned to it.\n\nThe type can not be an accounting office.", "Invalid Accounting Office", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag2 = false;
            goto label_41;
          }
        }
        bool flag3 = this.dsCompany.tblCompanies[0].RowState == DataRowState.Added;
        bool flag4 = this.dsCompany.tblCompanies[0].RowState == DataRowState.Modified;
        this._newCompany = flag3;
        bool flag5 = this.dsCompany.tblCompanyLocations[this.bmb.Position].RowState == DataRowState.Added;
        bool flag6 = this.dsCompany.tblCompanyLocations[this.bmb.Position].RowState == DataRowState.Modified;
        if (this.dsCompany.HasChanges())
        {
          DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
          {
            try
            {
              DbDataAdapter daCompanies = this.daCompanies;
              daCompanies.InsertCommand.Transaction = args.Transaction;
              daCompanies.UpdateCommand.Transaction = args.Transaction;
              daCompanies.DeleteCommand.Transaction = args.Transaction;
              daCompanies.SelectCommand.Transaction = args.Transaction;
              DefaultDatabase.DataAdapterUpdate(this.daCompanies, (DataTable) this.dsCompany.tblCompanies);
              DbDataAdapter daLocations = this.daLocations;
              daLocations.InsertCommand.Transaction = args.Transaction;
              daLocations.UpdateCommand.Transaction = args.Transaction;
              daLocations.DeleteCommand.Transaction = args.Transaction;
              daLocations.SelectCommand.Transaction = args.Transaction;
              DefaultDatabase.DataAdapterUpdate(this.daLocations, (DataTable) this.dsCompany.tblCompanyLocations);
              args.Transaction.Commit();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              args.Transaction.Rollback();
              throw;
            }
          }));
          if (flag3)
            CurrentUser.Instance.LogAction("Add Company: " + this.dsCompany.tblCompanies[0].CompanyName, this.dsCompany.tblCompanies[0].CompanyGuid, "CompanyID: " + this.dsCompany.tblCompanies[0].CompanyID.ToString());
          else if (flag4)
            CurrentUser.Instance.LogAction("Modify Company: " + this.dsCompany.tblCompanies[0].CompanyName, this.dsCompany.tblCompanies[0].CompanyGuid, "CompanyID: " + this.dsCompany.tblCompanies[0].CompanyID.ToString());
          if (flag5)
            CurrentUser.Instance.LogAction("Add Company Location: " + this.dsCompany.tblCompanyLocations[this.bmb.Position].LocationName, this.dsCompany.tblCompanyLocations[this.bmb.Position].CompanyLocationGuid);
          else if (flag6)
            CurrentUser.Instance.LogAction("Modify Company Location: " + this.dsCompany.tblCompanyLocations[this.bmb.Position].LocationName, this.dsCompany.tblCompanyLocations[this.bmb.Position].CompanyLocationGuid);
          MDIControls.Instance.StatusBarText = "Company information saved.";
          Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
          int index = 0;
          while (index < mdiChildren.Length)
          {
            if (mdiChildren[index] is frmSelection frmSelection && frmSelection.SelectionType == frmSelection.SelectionTypes.Company)
            {
              if (flag3)
                frmSelection.AddItem(this.dsCompany.tblCompanyLocations[this.bmb.Position].LocationName, this.dsCompany.tblCompanyLocations[this.bmb.Position].CompanyLocationGuid);
              else if (flag4)
                frmSelection.ModifyItem(this.dsCompany.tblCompanyLocations[this.bmb.Position].CompanyLocationGuid, this.dsCompany.tblCompanyLocations[this.bmb.Position].LocationName);
            }
            checked { ++index; }
          }
          this.Text = "Company Information - " + this.dsCompany.tblCompanies[0].CompanyName;
        }
        flag2 = true;
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.State == (byte) 123)
        {
          int num1 = (int) MessageBox.Show("Only one company location can be marked as the primary location.", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (ex2.Message.IndexOf("IX_tblCompanyLocations") != -1)
        {
          int num2 = (int) MessageBox.Show("A location with this name already exists.", "Location Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (ex2.Message.Contains("IX_tblCompanies_CompanyName"))
        {
          int num3 = (int) MessageBox.Show("A company with this name already exists.", "Company Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        flag2 = false;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
label_41:
    return flag2;
  }

  private void btnContacts_Click(object sender, EventArgs e)
  {
    if (this.lstContacts.SelectedIndex >= 0)
    {
      try
      {
        this.BindingContext[(object) this.dsCompany, this.dsCompany.tblCompanyLocations.TableName].EndCurrentEdit();
        if (this.dsCompany.HasChanges())
          DefaultDatabase.DataAdapterUpdate(this.daLocations, (DataTable) this.dsCompany.tblCompanyLocations);
        Guid selectedValue = (Guid) this.lstContacts.SelectedValue;
        if (this.dsCompany.tblCompanyContacts.FindByCompanyContactGuid(selectedValue).FromIntermediary)
          FormSettings.ShowForm(typeof (frmIntermediaryContacts), (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT IntermediaryID FROM tblIntermediaries WHERE IntermediaryGuid=@IG", new object[2]
          {
            (object) "@IG",
            (object) this.CurrentLocationRow.IntermediaryGuid
          }), (object) selectedValue);
        else
          FormSettings.ShowForm(typeof (frmCompanyContacts), (object) this._companyGuid, (object) this.CurrentLocationRow.CompanyLocationGuid, (object) selectedValue);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      int num = (int) MessageBox.Show("Please select a contact from the list.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void bmb_PositionChanged(object sender, EventArgs e) => this.UpdateLocationsNavDisplay();

  private void btnNewContact_Click(object sender, EventArgs e)
  {
    if (this.IntermediaryCheck(this.CurrentLocationRow.CompanyLocationGuid))
      return;
    if (this.dsCompany.tblCompanyLocations[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save this location before adding a contact.", "Save Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      FormSettings.ShowForm(typeof (frmCompanyContacts), (object) this._companyGuid, (object) this.CurrentLocationRow.CompanyLocationGuid);
  }

  private void btnGroups_Click(object sender, EventArgs e)
  {
    FormSettings.ShowForm(typeof (frmCompanyGroups));
  }

  public void FillCompanyGroups()
  {
    bool enforceConstraints = this.dsCompany.EnforceConstraints;
    this.dsCompany.EnforceConstraints = false;
    this.dsCompany.tblCompanyGroups.Clear();
    this.dsCompany.tblCompanyGroups.AddtblCompanyGroupsRow(Guid.Empty, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.dsCompany, new string[1]
    {
      "tblCompanyGroups"
    }, CommandType.Text, "SELECT CompanyGroupGuid, CompanyGroupName FROM tblCompanyGroups ORDER BY CompanyGroupName");
    if (!enforceConstraints)
      return;
    this.dsCompany.EnforceConstraints = true;
  }

  private void txtLocation_Leave(object sender, EventArgs e)
  {
    if (((TextEditorControlBase) this.txtLocation).Text.Length == 0)
      return;
    ((Control) this.btnNewContact).Enabled = true;
    ((Control) this.btnContacts).Enabled = true;
    this.SetMenuEnabled(frmCompanies.MenuState.Enabled);
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{C74F608B-6061-4436-B271-5404C7A74DE1}"))
    {
      int num1 = (int) MessageBox.Show("You are not authorized to delete company locations.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this location?", "Delete Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      if (((DataRowView) this.bmb.Current).Row.RowState == DataRowState.Added)
      {
        this.bmb.EndCurrentEdit();
        this.dsCompany.tblCompanyLocations.RemovetblCompanyLocationsRow(this.dsCompany.tblCompanyLocations[this.bmb.Position]);
        this.LoadContacts();
        this.bmb.EndCurrentEdit();
        this.dsCompany.tblCompanyLocations.AcceptChanges();
      }
      else
      {
        try
        {
          if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblCompanyLocations WHERE CompanyLocationGuid=@CLG", new object[2]
          {
            (object) "@CLG",
            (object) this.CurrentLocationRow.CompanyLocationGuid
          }) == 0)
            throw new IncorrectNumberOfRowsAffectedException();
          CurrentUser.Instance.LogAction("Deleted Company Location: " + ((TextEditorControlBase) this.txtLocation).Text, this.CurrentLocationRow.CompanyLocationGuid);
        }
        catch (IncorrectNumberOfRowsAffectedException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ErrorHandler.HandleError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        catch (Exception ex1)
        {
          ProjectData.SetProjectError(ex1);
          Exception ex2 = ex1;
          if (ex2.Message.IndexOf("FK_tblFin_InvoiceDetails_tblCompanyLines") != -1)
          {
            int num2 = (int) MessageBox.Show("This company can not be deleted, because it is associated with existing invoices.", "Cannot Delete Company", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
            return;
          }
          if (ex2.Message.IndexOf("FK_tblQuotes_tblCompanyLocations") != -1)
          {
            int num3 = (int) MessageBox.Show("This location can not be removed, because it is currently being used on one or more policies", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
            return;
          }
          if (ex2.Message.IndexOf("FK_tblCompanyLines_tblCompanyLocations") != -1)
          {
            int num4 = (int) MessageBox.Show("This company location can not be removed, because it has one or more company/line configurations established", "Can Not Remove Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
            return;
          }
          if (ex2.Message.IndexOf("FK_tblCompanyPolicyCharges_tblCompanyLocations") != -1)
          {
            int num5 = (int) MessageBox.Show("This company location can not be removed, because the carrier has been applied to Fees Setups", "Can Not Remove Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
            return;
          }
          if (ex2.Message.IndexOf("FK_tblQuotes2_tblCompanyLocations") != -1)
          {
            int num6 = (int) MessageBox.Show("This company location can not be removed, because one or more policies references this company as an expiring company. To delete this company the company must first be removed as an expiring company.", "Can Not Remove Company", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
            return;
          }
          ErrorHandler.HandleError(ex2);
          ProjectData.ClearProjectError();
        }
        BindingManagerBase bmb;
        int num7 = (bmb = this.bmb).Position - 1;
        bmb.Position = num7;
        try
        {
          this.dsCompany.tblCompanyLocations.RemovetblCompanyLocationsRow(this.CurrentLocationRow);
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      this.UpdateLocationsNavDisplay();
    }
  }

  private void UpdateLocationsNavDisplay()
  {
    BindingManagerBase bmb = this.bmb;
    ((Control) this.btnFirst).Enabled = bmb.Position > 0;
    ((Control) this.btnPrev).Enabled = bmb.Position > 0;
    ((Control) this.btnLast).Enabled = bmb.Position < bmb.Count - 1;
    ((Control) this.btnNext).Enabled = bmb.Position < bmb.Count - 1;
    ((Control) this.tabLocations).Enabled = bmb.Count > 0;
    ((Control) this.btnDelete).Enabled = bmb.Count > 1;
    UltraLabel lblRecords = this.lblRecords;
    int num = this.bmb.Position + 1;
    string str1 = num.ToString();
    num = this.bmb.Count;
    string str2 = num.ToString();
    string str3 = $"{str1} of {str2}";
    ((ControlBase) lblRecords).Text = str3;
    if (this.bmb.Position == -1)
      return;
    this.SetIntermediaryRadioButtons();
  }

  private void SetIntermediaryRadioButtons()
  {
    if (this.CurrentLocationRow == null)
      return;
    this.rbLocation.CheckedChanged -= new EventHandler(this.RadioChanged);
    this.rbIntermediary.CheckedChanged -= new EventHandler(this.RadioChanged);
    this.rbIntermediary.Checked = !this.CurrentLocationRow.IsIntermediaryGuidNull();
    this.rbLocation.Checked = this.CurrentLocationRow.IsIntermediaryGuidNull();
    ((Control) this.cboIntermediary).Enabled = this.rbIntermediary.Checked && this.dbSave.UIState == UIState.Editing;
    this.rbLocation.CheckedChanged += new EventHandler(this.RadioChanged);
    this.rbIntermediary.CheckedChanged += new EventHandler(this.RadioChanged);
  }

  private void PopulateDataSet()
  {
    this.FillCompanyGroups();
    ProgressBarInfo progressBar1;
    int num1 = (progressBar1 = MDIControls.Instance.ProgressBar).Value + 1;
    progressBar1.Value = num1;
    if (!this._companyGuid.Equals(Guid.Empty))
    {
      MDIControls.Instance.StatusBarText = "Getting company information...";
      this.daCompanies.SelectCommand.Parameters["@CompanyGuid"].Value = (object) this._companyGuid;
      DefaultDatabase.DataAdapterFill(this.daCompanies, (DataTable) this.dsCompany.tblCompanies);
    }
    if (this.dsCompany.tblCompanies.Count > 0 && !this.dsCompany.tblCompanies[0].IsCompanyNameNull())
      this.Text = "Company Information - " + this.dsCompany.tblCompanies[0].CompanyName;
    else
      this.Text = "New Company";
    ProgressBarInfo progressBar2;
    int num2 = (progressBar2 = MDIControls.Instance.ProgressBar).Value + 1;
    progressBar2.Value = num2;
    MDIControls.Instance.StatusBarText = "Getting delivery methods...";
    DefaultDatabase.LoadDataSet((DataSet) this.dsCompany, new string[8]
    {
      "lstDeliveryMethod",
      "lstLocationType",
      "lstStatus",
      "tblIntermediaries",
      "lstFSR",
      "lstFSC",
      "lstRatingBureau",
      "tblUsers"
    }, "dbo.spGetCompanyFormData");
    ProgressBarInfo progressBar3;
    int num3 = (progressBar3 = MDIControls.Instance.ProgressBar).Value + 1;
    progressBar3.Value = num3;
    if (this.bmb.Position != -1 && this.CurrentLocationRow.RowState == DataRowState.Added)
    {
      ((UltraDropDownBase) this.cbStatus).SelectedRow = (UltraGridRow) null;
      ((UltraDropDownBase) this.cbOfficeType).SelectedRow = (UltraGridRow) null;
      ((UltraDropDownBase) this.cboDeliveryMethod).SelectedRow = (UltraGridRow) null;
      ((UltraGridBase) this.cbStatus).Refresh();
      ((UltraGridBase) this.cbOfficeType).Refresh();
      ((UltraGridBase) this.cboDeliveryMethod).Refresh();
    }
    else
    {
      MDIControls.Instance.StatusBarText = "Getting company locations...";
      this.daLocations.SelectCommand.Parameters["@CompanyGuid"].Value = (object) this._companyGuid;
      DefaultDatabase.DataAdapterFill(this.daLocations, (DataTable) this.dsCompany.tblCompanyLocations);
    }
    ProgressBarInfo progressBar4;
    int num4 = (progressBar4 = MDIControls.Instance.ProgressBar).Value + 1;
    progressBar4.Value = num4;
    ((ControlBase) this.lblRecords).Text = $"{(this.bmb.Position + 1).ToString()} of {this.bmb.Count.ToString()}";
    ((Control) this.tabLocations).Enabled = this.dsCompany.tblCompanyLocations.Rows.Count > 0;
  }

  private void cboIntermediary_ValueChanged(object sender, EventArgs e)
  {
    if (this.cboIntermediary.Text.Length == 0)
      return;
    this.cboIntermediary.ValueChanged -= new EventHandler(this.cboIntermediary_ValueChanged);
    try
    {
      DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Address1, Address2, City, County, State, ZipCode, ZipPlus, Phone, Fax, Website FROM tblIntermediaries WHERE IntermediaryGuid=@IG", new object[2]
      {
        (object) "@IG",
        this.cboIntermediary.Value
      });
      dsCompanies.tblCompanyLocationsRow currentLocationRow = this.CurrentLocationRow;
      currentLocationRow.IntermediaryGuid = (Guid) this.cboIntermediary.Value;
      if (row.IsNull(0))
        currentLocationRow.SetAddress1Null();
      else
        currentLocationRow.Address1 = row.Field<string>(0);
      if (row.IsNull(1))
        currentLocationRow.SetAddress2Null();
      else
        currentLocationRow.Address2 = row.Field<string>(1);
      if (row.IsNull(2))
        currentLocationRow.SetCityNull();
      else
        currentLocationRow.City = row.Field<string>(2);
      if (row.IsNull(3))
        currentLocationRow.SetCountyNull();
      else
        currentLocationRow.County = row.Field<string>(3);
      if (row.IsNull(4))
        currentLocationRow.SetStateNull();
      else
        currentLocationRow.State = row.Field<string>(4);
      if (row.IsNull(5))
        currentLocationRow.SetZipCodeNull();
      else
        currentLocationRow.ZipCode = row.Field<string>(5);
      if (row.IsNull(6))
        currentLocationRow.SetZipPlusNull();
      else
        currentLocationRow.ZipPlus = row.Field<string>(6);
      if (row.IsNull(7))
        currentLocationRow.SetPhoneNull();
      else
        currentLocationRow.Phone = row.Field<string>(7);
      if (row.IsNull(8))
        currentLocationRow.SetFaxNull();
      else
        currentLocationRow.Fax = row.Field<string>(8);
      if (row.IsNull(9))
        currentLocationRow.SetWebSiteNull();
      else
        currentLocationRow.WebSite = row.Field<string>(9);
      this.bmb.EndCurrentEdit();
      this.LoadContacts();
    }
    finally
    {
      this.cboIntermediary.ValueChanged += new EventHandler(this.cboIntermediary_ValueChanged);
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{C266F1AF-4856-4647-BC41-CE2D40D5E294}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to add new companies.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
      this.NewCompany();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    bool flag = this.SaveChanges();
    e.Cancel = !flag;
    if (flag)
      this.AfterSave();
    this._quoteLocationGuids = string.Empty;
    if (!this.QuoteInformationInvocation)
      return;
    try
    {
      foreach (dsCompanies.tblCompanyLocationsRow row in this.dsCompany.tblCompanyLocations.Rows)
        this._quoteLocationGuids = $"{this._quoteLocationGuids}|{row.LocationName}^{row.CompanyLocationGuid.ToString()}";
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    if (this.dsCompany.tblCompanies[0].RowState == DataRowState.Added)
    {
      this.Close();
    }
    else
    {
      foreach (UltraTab tab in ((UltraTabControlBase) this.tabLocations).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
            this.ErrProvider.SetError(control, string.Empty);
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      this.ctlCompanyLocationZip.ClearErrors();
      try
      {
        this.dsCompany.RejectChanges();
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      this.SetIntermediaryRadioButtons();
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{81A75321-B644-4c3e-AC6B-104F32A3CAF1}"))
    {
      int num = (int) MessageBox.Show("You do not have permission to edit companies.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (this.dsCompany.tblCompanyLocations.Count != 0)
        return;
      this.NewLocation();
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.SetFormControlsEnabledState();
  }

  private void SetFormControlsEnabledState()
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control != this.dbSave && control != this.tabLocations && (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepEnabled", false) != 0))
          control.Enabled = this.dbSave.UIState == UIState.Editing;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    foreach (UltraTab tab in ((UltraTabControlBase) this.tabLocations).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control == this.cbOfficeType)
            control.Enabled = this.dbSave.UIState == UIState.Editing && (this.dsCompany.tblCompanyLocations.Count > 1 || this.dsCompany.tblCompanyLocations[this.bmb.Position].RowState != DataRowState.Added && this.dsCompany.tblCompanyLocations.Count == 1);
          else if (control.Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Tag.ToString(), "KeepEnabled", false) != 0)
            control.Enabled = this.dbSave.UIState == UIState.Editing;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ((Control) this.cboIntermediary).Enabled = this.dbSave.UIState == UIState.Editing && this.rbIntermediary.Checked;
    this.SetClientControlsState(this.dbSave.UIState == UIState.Editing);
  }

  private void btnNewImage_Click(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Title = "Please select a logo";
      openFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK || !File.Exists(openFileDialog.FileName) || this.dsCompany.tblCompanies.Rows.Count <= 0)
        return;
      ((dsCompanies.tblCompaniesRow) this.dsCompany.tblCompanies.Rows[0]).Logo = File.ReadAllBytes(openFileDialog.FileName);
    }
  }

  private void btnXMLDialogue_Click(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Title = "Open XML";
    openFileDialog.InitialDirectory = "C:\\";
    openFileDialog.Multiselect = false;
    openFileDialog.Filter = "XML Files(*.xml)|*.xml";
    openFileDialog.FilterIndex = 2;
    openFileDialog.RestoreDirectory = true;
    if (openFileDialog.ShowDialog() != DialogResult.OK)
      return;
    ((TextEditorControlBase) this.txtXMLDialogue).Text = openFileDialog.FileName;
  }

  private void btnNetRateImport_Click(object sender, EventArgs e)
  {
    try
    {
      XmlTextReader xmlTextReader = new XmlTextReader(((TextEditorControlBase) this.txtXMLDialogue).Text);
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(File.ReadAllText(((TextEditorControlBase) this.txtXMLDialogue).Text));
      try
      {
        ((TextEditorControlBase) this.txtNetRateName).Text = xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote/Company").InnerText;
        ((TextEditorControlBase) this.txtNetRateID).Text = xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote/CompanyCode").InnerText;
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show($"\"{((TextEditorControlBase) this.txtXMLDialogue).Text}\" is either not a valid NetRate .xml file or does not contain the appropriate information.");
        ProjectData.ClearProjectError();
      }
    }
    catch (FileNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show($"\"{((TextEditorControlBase) this.txtXMLDialogue).Text}\" either does not exist or is not a valid .xml file.");
      ProjectData.ClearProjectError();
    }
    catch (XmlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show($"\"{((TextEditorControlBase) this.txtXMLDialogue).Text}\" either does not exist or is not a valid .xml file.");
      ProjectData.ClearProjectError();
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show($"\"{((TextEditorControlBase) this.txtXMLDialogue).Text}\" is currently in use by another process.");
      ProjectData.ClearProjectError();
    }
  }

  private void txtCompanyName_TextChanged(object sender, EventArgs e)
  {
    if (!this.QuoteInformationInvocation)
      return;
    ((TextEditorControlBase) this.txtLocation).Text = ((TextEditorControlBase) this.txtCompanyName).Text;
  }

  private void TxtPhone_TextChanged(object sender, EventArgs e)
  {
  }

  private void TextBox3_TextChanged(object sender, EventArgs e)
  {
    string s = this.TextBox3.Text.Replace("-", "");
    if (s.Length == 7)
      this.TextBox3.Text = $"{double.Parse(s):###-####}".ToString();
    if (s.Length == 10)
      this.TextBox3.Text = $"{double.Parse(s):###-###-####}".ToString();
    if (s.Length == 13)
      this.TextBox3.Text = $"{double.Parse(s):-###-###-###-####}".ToString();
    if (this.TextBox3.Text.Length <= 1)
      return;
    this.TextBox3.SelectionStart = this.TextBox3.Text.Length;
    this.TextBox3.SelectionLength = 0;
  }

  private void TextBox3_Leave(object sender, EventArgs e)
  {
  }

  private void CtlCompanyLocationZip_ISOCountryCodeChanged(object sender, EventArgs e)
  {
    if (this.ctlCompanyLocationZip.ISOCountryCode.ToUpper().Contains("USA") | this.ctlCompanyLocationZip.ISOCountryCode.ToUpper().Contains("UNITED STATES") | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ctlCompanyLocationZip.ISOCountryCode.ToUpper(), "US", false) == 0 | this.ctlCompanyLocationZip.ISOCountryCode.ToUpper().Contains("CANADA") | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ctlCompanyLocationZip.ISOCountryCode.ToUpper(), "CA", false) == 0)
    {
      if (string.IsNullOrEmpty(this.txtPhone.Text.Replace("-", "").Replace("+", "")))
        this.txtPhone.InputMask = "###-###-####";
      if (string.IsNullOrEmpty(this.txtClaimPhone.Text.Replace("-", "").Replace("+", "")))
        this.txtClaimPhone.InputMask = "###-###-####";
      if (string.IsNullOrEmpty(this.txtFax.Text.Replace("-", "").Replace("+", "")))
        this.txtFax.InputMask = "###-###-####";
      if (!string.IsNullOrEmpty(this.txtClaimFax.Text.Replace("-", "").Replace("+", "")))
        return;
      this.txtClaimFax.InputMask = "###-###-####";
    }
    else
    {
      if (string.IsNullOrEmpty(this.txtPhone.Text.Replace("-", "").Replace("+", "")))
        this.txtPhone.InputMask = "+##-###-###-####";
      if (string.IsNullOrEmpty(this.txtClaimPhone.Text.Replace("-", "").Replace("+", "")))
        this.txtClaimPhone.InputMask = "+##-###-###-####";
      if (string.IsNullOrEmpty(this.txtFax.Text.Replace("-", "").Replace("+", "")))
        this.txtFax.InputMask = "+##-###-###-####";
      if (!string.IsNullOrEmpty(this.txtClaimFax.Text.Replace("-", "").Replace("+", "")))
        return;
      this.txtClaimFax.InputMask = "+##-###-###-####";
    }
  }

  private enum MenuState
  {
    Enabled,
    Disabled,
  }
}
