// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmContactManagement
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Common.LogonServer;
using MGASystems.Data;
using MGASystems.IMS.Forms.Envelopes;
using MGASystems.IMS.Forms.Users;
using MGASystems.IMS.InsuredsProducersCompanies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[SecureHotkeyResource("{6D6025D2-5F20-4c84-9A90-096690D87A23}", "New Contact Hot Key", "Determines whether or not the user will be allowed to access contact management from the hot key bar", "Contact Management")]
[SecureResource("{CA65B83E-4D53-4a9b-8195-813D8BD09B0D}", "Can View Contact Management", "Controls whether or not a user can view 'Contact Management' menu item.", "Contact Management")]
[HotKeyInfo("ContactManagement", "Contact Management", "Contact Management", Keys.F4, "MGASystems.Tools.vcard_edit.png")]
public class frmContactManagement : Form
{
  private IContainer components;
  private MGATextBox txtContactInfo;
  private dsContactManagement ds;
  private DataView dvCompany;
  private DataView dvProducer;
  private DataView dvUsers;
  private Label Label2;
  private SqlCommand spContactManagement;
  private ContextMenu cm;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraTabPageControl UltraTabPageControl3;
  private UltraTabPageControl UltraTabPageControl4;
  private Guid _quoteGuid;
  private MemoryStream _allContactGridlayout;
  private MemoryStream _companyContactGridlayout;
  private MemoryStream _officeContactGridlayout;
  private MemoryStream _producerContactGridlayout;
  private MemoryStream _insuredContactGridlayout;
  internal const string SecurityIDContactManagementHotKey = "{6D6025D2-5F20-4c84-9A90-096690D87A23}";
  public const string CanViewContactManagement = "{CA65B83E-4D53-4a9b-8195-813D8BD09B0D}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid dgCompanyContacts
  {
    get => this._dgCompanyContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AfterRowActivate);
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.dgAllContacts_DoubleClickRow);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.GridMouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgCompanyContacts_InitializeRow);
      UltraGrid dgCompanyContacts1 = this._dgCompanyContacts;
      if (dgCompanyContacts1 != null)
      {
        dgCompanyContacts1.AfterRowActivate -= eventHandler;
        dgCompanyContacts1.DoubleClickRow -= clickRowEventHandler;
        ((Control) dgCompanyContacts1).MouseDown -= mouseEventHandler;
        dgCompanyContacts1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgCompanyContacts = value;
      UltraGrid dgCompanyContacts2 = this._dgCompanyContacts;
      if (dgCompanyContacts2 == null)
        return;
      dgCompanyContacts2.AfterRowActivate += eventHandler;
      dgCompanyContacts2.DoubleClickRow += clickRowEventHandler;
      ((Control) dgCompanyContacts2).MouseDown += mouseEventHandler;
      dgCompanyContacts2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual UltraGrid dgProducerContacts
  {
    get => this._dgProducerContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AfterRowActivate);
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.dgAllContacts_DoubleClickRow);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.GridMouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgProducerContacts_InitializeRow);
      UltraGrid producerContacts1 = this._dgProducerContacts;
      if (producerContacts1 != null)
      {
        producerContacts1.AfterRowActivate -= eventHandler;
        producerContacts1.DoubleClickRow -= clickRowEventHandler;
        ((Control) producerContacts1).MouseDown -= mouseEventHandler;
        producerContacts1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgProducerContacts = value;
      UltraGrid producerContacts2 = this._dgProducerContacts;
      if (producerContacts2 == null)
        return;
      producerContacts2.AfterRowActivate += eventHandler;
      producerContacts2.DoubleClickRow += clickRowEventHandler;
      ((Control) producerContacts2).MouseDown += mouseEventHandler;
      producerContacts2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual UltraGrid dgOfficeContacts
  {
    get => this._dgOfficeContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AfterRowActivate);
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.dgAllContacts_DoubleClickRow);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.GridMouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgOfficeContacts_InitializeRow);
      UltraGrid dgOfficeContacts1 = this._dgOfficeContacts;
      if (dgOfficeContacts1 != null)
      {
        dgOfficeContacts1.AfterRowActivate -= eventHandler;
        dgOfficeContacts1.DoubleClickRow -= clickRowEventHandler;
        ((Control) dgOfficeContacts1).MouseDown -= mouseEventHandler;
        dgOfficeContacts1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgOfficeContacts = value;
      UltraGrid dgOfficeContacts2 = this._dgOfficeContacts;
      if (dgOfficeContacts2 == null)
        return;
      dgOfficeContacts2.AfterRowActivate += eventHandler;
      dgOfficeContacts2.DoubleClickRow += clickRowEventHandler;
      ((Control) dgOfficeContacts2).MouseDown += mouseEventHandler;
      dgOfficeContacts2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual UltraGrid dgAllContacts
  {
    get => this._dgAllContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AfterRowActivate);
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.dgAllContacts_DoubleClickRow);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.GridMouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgAllContacts_InitializeRow);
      UltraGrid dgAllContacts1 = this._dgAllContacts;
      if (dgAllContacts1 != null)
      {
        dgAllContacts1.AfterRowActivate -= eventHandler;
        dgAllContacts1.DoubleClickRow -= clickRowEventHandler;
        ((Control) dgAllContacts1).MouseDown -= mouseEventHandler;
        dgAllContacts1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgAllContacts = value;
      UltraGrid dgAllContacts2 = this._dgAllContacts;
      if (dgAllContacts2 == null)
        return;
      dgAllContacts2.AfterRowActivate += eventHandler;
      dgAllContacts2.DoubleClickRow += clickRowEventHandler;
      ((Control) dgAllContacts2).MouseDown += mouseEventHandler;
      dgAllContacts2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual RadioButton rbContactName
  {
    get => this._rbContactName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeFilter);
      RadioButton rbContactName1 = this._rbContactName;
      if (rbContactName1 != null)
        rbContactName1.CheckedChanged -= eventHandler;
      this._rbContactName = value;
      RadioButton rbContactName2 = this._rbContactName;
      if (rbContactName2 == null)
        return;
      rbContactName2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbLocationName
  {
    get => this._rbLocationName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeFilter);
      RadioButton rbLocationName1 = this._rbLocationName;
      if (rbLocationName1 != null)
        rbLocationName1.CheckedChanged -= eventHandler;
      this._rbLocationName = value;
      RadioButton rbLocationName2 = this._rbLocationName;
      if (rbLocationName2 == null)
        return;
      rbLocationName2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("spGetContactInfo")]
  private virtual SqlCommand spGetContactInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MenuItem mnuEmail
  {
    get => this._mnuEmail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuEmail_Click);
      MenuItem mnuEmail1 = this._mnuEmail;
      if (mnuEmail1 != null)
        mnuEmail1.Click -= eventHandler;
      this._mnuEmail = value;
      MenuItem mnuEmail2 = this._mnuEmail;
      if (mnuEmail2 == null)
        return;
      mnuEmail2.Click += eventHandler;
    }
  }

  private virtual MGAButton btnPrintEnvelope
  {
    get => this._btnPrintEnvelope;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintEnvelope_Click);
      MGAButton btnPrintEnvelope1 = this._btnPrintEnvelope;
      if (btnPrintEnvelope1 != null)
        ((Control) btnPrintEnvelope1).Click -= eventHandler;
      this._btnPrintEnvelope = value;
      MGAButton btnPrintEnvelope2 = this._btnPrintEnvelope;
      if (btnPrintEnvelope2 == null)
        return;
      ((Control) btnPrintEnvelope2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnPrintLabelSheet
  {
    get => this._btnPrintLabelSheet;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintLabelSheet_Click);
      MGAButton btnPrintLabelSheet1 = this._btnPrintLabelSheet;
      if (btnPrintLabelSheet1 != null)
        ((Control) btnPrintLabelSheet1).Click -= eventHandler;
      this._btnPrintLabelSheet = value;
      MGAButton btnPrintLabelSheet2 = this._btnPrintLabelSheet;
      if (btnPrintLabelSheet2 == null)
        return;
      ((Control) btnPrintLabelSheet2).Click += eventHandler;
    }
  }

  private virtual UltraTabControl tabContacts
  {
    get => this._tabContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.tabContacts_SelectedTabChanged);
      UltraTabControl tabContacts1 = this._tabContacts;
      if (tabContacts1 != null)
        ((UltraTabControlBase) tabContacts1).SelectedTabChanged -= changedEventHandler;
      this._tabContacts = value;
      UltraTabControl tabContacts2 = this._tabContacts;
      if (tabContacts2 == null)
        return;
      ((UltraTabControlBase) tabContacts2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraToolTipManager1")]
  internal virtual UltraToolTipManager UltraToolTipManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGATextBox txtContactSearch
  {
    get => this._txtContactSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtContact_TextChanged);
      MGATextBox txtContactSearch1 = this._txtContactSearch;
      if (txtContactSearch1 != null)
        ((Control) txtContactSearch1).TextChanged -= eventHandler;
      this._txtContactSearch = value;
      MGATextBox txtContactSearch2 = this._txtContactSearch;
      if (txtContactSearch2 == null)
        return;
      ((Control) txtContactSearch2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl5")]
  internal virtual UltraTabPageControl UltraTabPageControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid dgInsuredContacts
  {
    get => this._dgInsuredContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.GridMouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgInsuredContacts_InitializeRow);
      EventHandler eventHandler1 = new EventHandler(this.dgInsuredContacts_Click);
      EventHandler eventHandler2 = new EventHandler(this.dgInsuredContacts_DoubleClick);
      UltraGrid dgInsuredContacts1 = this._dgInsuredContacts;
      if (dgInsuredContacts1 != null)
      {
        ((Control) dgInsuredContacts1).MouseDown -= mouseEventHandler;
        dgInsuredContacts1.InitializeRow -= initializeRowEventHandler;
        ((Control) dgInsuredContacts1).Click -= eventHandler1;
        ((Control) dgInsuredContacts1).DoubleClick -= eventHandler2;
      }
      this._dgInsuredContacts = value;
      UltraGrid dgInsuredContacts2 = this._dgInsuredContacts;
      if (dgInsuredContacts2 == null)
        return;
      ((Control) dgInsuredContacts2).MouseDown += mouseEventHandler;
      dgInsuredContacts2.InitializeRow += initializeRowEventHandler;
      ((Control) dgInsuredContacts2).Click += eventHandler1;
      ((Control) dgInsuredContacts2).DoubleClick += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("dvInsured")]
  private virtual DataView dvInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnBulkPrintEnvelopes
  {
    get => this._btnBulkPrintEnvelopes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBulkPrintEnvelopes_Click);
      MGAButton bulkPrintEnvelopes1 = this._btnBulkPrintEnvelopes;
      if (bulkPrintEnvelopes1 != null)
        ((Control) bulkPrintEnvelopes1).Click -= eventHandler;
      this._btnBulkPrintEnvelopes = value;
      MGAButton bulkPrintEnvelopes2 = this._btnBulkPrintEnvelopes;
      if (bulkPrintEnvelopes2 == null)
        return;
      ((Control) bulkPrintEnvelopes2).Click += eventHandler;
    }
  }

  internal virtual CheckBox chkOnlyActive
  {
    get => this._chkOnlyActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkOnlyActive_CheckedChanged);
      CheckBox chkOnlyActive1 = this._chkOnlyActive;
      if (chkOnlyActive1 != null)
        chkOnlyActive1.CheckedChanged -= eventHandler;
      this._chkOnlyActive = value;
      CheckBox chkOnlyActive2 = this._chkOnlyActive;
      if (chkOnlyActive2 == null)
        return;
      chkOnlyActive2.CheckedChanged += eventHandler;
    }
  }

  internal virtual MenuItem mnuCallReports
  {
    get => this._mnuCallReports;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuCallReports_Click);
      MenuItem mnuCallReports1 = this._mnuCallReports;
      if (mnuCallReports1 != null)
        mnuCallReports1.Click -= eventHandler;
      this._mnuCallReports = value;
      MenuItem mnuCallReports2 = this._mnuCallReports;
      if (mnuCallReports2 == null)
        return;
      mnuCallReports2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Contacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ContactLocationGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LocationType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Extension");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Cell");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Contact Type");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Contacts", -1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ContactLocationGuid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LocationType");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Extension");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Cell");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Contact Type");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("EmailAddress", 0);
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("Contacts", -1);
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("ContactLocationGuid");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("LocationType");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("Extension");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Cell");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("Contact Type");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance25 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("Contacts", -1);
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("ContactLocationGuid");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("LocationType");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("Extension");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("Cell");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("Contact Type");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("Contacts", -1);
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("ContactLocationGuid");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("LocationType");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("Extension");
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("Cell");
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("Contact Type");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmContactManagement));
    UltraToolTipInfo ultraToolTipInfo1 = new UltraToolTipInfo("Prints an envelope addressed to the selected contact", (ToolTipImage) 0, "Print Envelope", (DefaultableBoolean) 0);
    Appearance appearance45 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo2 = new UltraToolTipInfo("Prints a contact sheet of the current contacts", (ToolTipImage) 0, "Print Contact Sheet", (DefaultableBoolean) 0);
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance46 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance47 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance48 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance49 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance50 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo3 = new UltraToolTipInfo("Bulk prints envelopes addressed to selected contacts", (ToolTipImage) 0, "Bulk Print Envelopes", (DefaultableBoolean) 0);
    Appearance appearance51 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.dgCompanyContacts = new UltraGrid();
    this.dvCompany = new DataView();
    this.ds = new dsContactManagement();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.dgProducerContacts = new UltraGrid();
    this.dvProducer = new DataView();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.dgOfficeContacts = new UltraGrid();
    this.dvUsers = new DataView();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.dgAllContacts = new UltraGrid();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.dgInsuredContacts = new UltraGrid();
    this.txtContactInfo = new MGATextBox();
    this.Label2 = new Label();
    this.rbContactName = new RadioButton();
    this.rbLocationName = new RadioButton();
    this.spGetContactInfo = new SqlCommand();
    this.spContactManagement = new SqlCommand();
    this.cm = new ContextMenu();
    this.mnuEmail = new MenuItem();
    this.mnuCallReports = new MenuItem();
    this.btnPrintEnvelope = new MGAButton();
    this.btnPrintLabelSheet = new MGAButton();
    this.tabContacts = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.UltraToolTipManager1 = new UltraToolTipManager(this.components);
    this.btnBulkPrintEnvelopes = new MGAButton();
    this.txtContactSearch = new MGATextBox();
    this.dvInsured = new DataView();
    this.chkOnlyActive = new CheckBox();
    Label label1 = new Label();
    Label label2 = new Label();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.dgCompanyContacts).BeginInit();
    this.dvCompany.BeginInit();
    this.ds.BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.dgProducerContacts).BeginInit();
    this.dvProducer.BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.dgOfficeContacts).BeginInit();
    this.dvUsers.BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.dgAllContacts).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.dgInsuredContacts).BeginInit();
    ((ISupportInitialize) this.txtContactInfo).BeginInit();
    ((ISupportInitialize) this.btnPrintEnvelope).BeginInit();
    ((ISupportInitialize) this.btnPrintLabelSheet).BeginInit();
    ((ISupportInitialize) this.tabContacts).BeginInit();
    ((Control) this.tabContacts).SuspendLayout();
    ((ISupportInitialize) this.btnBulkPrintEnvelopes).BeginInit();
    ((ISupportInitialize) this.txtContactSearch).BeginInit();
    this.dvInsured.BeginInit();
    this.SuspendLayout();
    label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label1.Location = new Point(14, 421);
    label1.Name = "Label1";
    label1.Size = new Size(112 /*0x70*/, 23);
    label1.TabIndex = 2;
    label1.Text = "Contact Information:";
    label1.TextAlign = ContentAlignment.MiddleLeft;
    label2.Location = new Point(12, 9);
    label2.Name = "Label3";
    label2.Size = new Size(113, 21);
    label2.TabIndex = 10;
    label2.Text = "Search for Contact:";
    label2.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dgCompanyContacts);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(660, 340);
    ((UltraGridBase) this.dgCompanyContacts).DataSource = (object) this.dvCompany;
    ((SpecialBoxBase) ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.AddNewBox).Prompt = " ";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 48 /*0x30*/;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Location";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 455;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 155;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 65;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 24;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 31 /*0x1F*/;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 31 /*0x1F*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 55;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 55;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 62;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 62;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 62;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 62;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 62;
    ultraGridBand1.Columns.AddRange(new object[17]
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
      (object) ultraGridColumn17
    });
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgCompanyContacts).Dock = DockStyle.Fill;
    ((Control) this.dgCompanyContacts).Location = new Point(0, 0);
    ((Control) this.dgCompanyContacts).Name = "dgCompanyContacts";
    ((Control) this.dgCompanyContacts).Size = new Size(660, 340);
    ((Control) this.dgCompanyContacts).TabIndex = 0;
    ((UltraControlBase) this.dgCompanyContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgCompanyContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.dvCompany.RowFilter = "LocationType='C'";
    this.dvCompany.Table = (DataTable) this.ds.Contacts;
    this.ds.DataSetName = "dsContactManagement";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dgProducerContacts);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(660, 340);
    ((UltraGridBase) this.dgProducerContacts).DataSource = (object) this.dvProducer;
    ((SpecialBoxBase) ((UltraGridBase) this.dgProducerContacts).DisplayLayout.AddNewBox).Prompt = " ";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn20.Width = 175;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Location";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn21.Width = 175;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 5;
    ultraGridColumn23.Width = 175;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 6;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 7;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 8;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 10;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 11;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 12;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 13;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 14;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 15;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 17;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 9;
    ultraGridColumn35.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[18]
    {
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
      (object) ultraGridColumn35
    });
    ultraGridBand2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgProducerContacts).Dock = DockStyle.Fill;
    ((Control) this.dgProducerContacts).Location = new Point(0, 0);
    ((Control) this.dgProducerContacts).Name = "dgProducerContacts";
    ((Control) this.dgProducerContacts).Size = new Size(660, 340);
    ((Control) this.dgProducerContacts).TabIndex = 1;
    ((UltraControlBase) this.dgProducerContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgProducerContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.dvProducer.RowFilter = "LocationType='P'";
    this.dvProducer.Table = (DataTable) this.ds.Contacts;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.dgOfficeContacts);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(660, 340);
    ((UltraGridBase) this.dgOfficeContacts).DataSource = (object) this.dvUsers;
    ((SpecialBoxBase) ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.AddNewBox).Prompt = " ";
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 0;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 179;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 1;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 251;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 2;
    ultraGridColumn38.Width = 154;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 3;
    ultraGridColumn39.Width = 263;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 4;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 163;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 5;
    ultraGridColumn41.Width = 224 /*0xE0*/;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 6;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 50;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 7;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 24;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 8;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 31 /*0x1F*/;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 9;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 31 /*0x1F*/;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 10;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 55;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 11;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 55;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 12;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 62;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 13;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 62;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 14;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 62;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 15;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 62;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 62;
    ultraGridBand3.Columns.AddRange(new object[17]
    {
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52
    });
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance18.BackColor = Color.LightSteelBlue;
    appearance18.FontData.SizeInPoints = 10f;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance22.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance22;
    appearance23.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = Color.Transparent;
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance24;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.dgOfficeContacts).Dock = DockStyle.Fill;
    ((Control) this.dgOfficeContacts).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgOfficeContacts).Location = new Point(0, 0);
    ((Control) this.dgOfficeContacts).Name = "dgOfficeContacts";
    ((Control) this.dgOfficeContacts).Size = new Size(660, 340);
    ((Control) this.dgOfficeContacts).TabIndex = 1;
    ((UltraControlBase) this.dgOfficeContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOfficeContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.dvUsers.RowFilter = "LocationType='U'";
    this.dvUsers.Table = (DataTable) this.ds.Contacts;
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.dgAllContacts);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(660, 340);
    ((UltraGridBase) this.dgAllContacts).DataSource = (object) this.ds.Contacts;
    ((SpecialBoxBase) ((UltraGridBase) this.dgAllContacts).DisplayLayout.AddNewBox).Prompt = " ";
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 0;
    ultraGridColumn53.Hidden = true;
    ultraGridColumn53.Width = 113;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 1;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn54.Width = 200;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 2;
    ultraGridColumn55.Width = 204;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 3;
    ultraGridColumn56.Width = 223;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 4;
    ultraGridColumn57.Hidden = true;
    ultraGridColumn57.Width = 69;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 5;
    ultraGridColumn58.Width = 214;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 6;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 69;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 7;
    ultraGridColumn60.Hidden = true;
    ultraGridColumn60.Width = 24;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 8;
    ultraGridColumn61.Hidden = true;
    ultraGridColumn61.Width = 30;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 9;
    ultraGridColumn62.Hidden = true;
    ultraGridColumn62.Width = 30;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 10;
    ultraGridColumn63.Hidden = true;
    ultraGridColumn63.Width = 54;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 11;
    ultraGridColumn64.Hidden = true;
    ultraGridColumn64.Width = 54;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 12;
    ultraGridColumn65.Hidden = true;
    ultraGridColumn65.Width = 61;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 13;
    ultraGridColumn66.Hidden = true;
    ultraGridColumn66.Width = 61;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 14;
    ultraGridColumn67.Hidden = true;
    ultraGridColumn67.Width = 61;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 15;
    ultraGridColumn68.Hidden = true;
    ultraGridColumn68.Width = 61;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn69.Hidden = true;
    ultraGridColumn69.Width = 61;
    ultraGridBand4.Columns.AddRange(new object[17]
    {
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69
    });
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance26.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance27.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance28.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance29.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance29;
    appearance30.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance31.BackColor = Color.Transparent;
    appearance31.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance31;
    appearance32.BackColor = Color.WhiteSmoke;
    appearance32.BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance32;
    appearance33.BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.dgAllContacts).Dock = DockStyle.Fill;
    ((Control) this.dgAllContacts).Location = new Point(0, 0);
    ((Control) this.dgAllContacts).Name = "dgAllContacts";
    ((Control) this.dgAllContacts).Size = new Size(660, 340);
    ((Control) this.dgAllContacts).TabIndex = 1;
    ((UltraControlBase) this.dgAllContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAllContacts).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.dgInsuredContacts);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(660, 340);
    ((UltraGridBase) this.dgInsuredContacts).DataSource = (object) this.ds.Contacts;
    ((SpecialBoxBase) ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.AddNewBox).Prompt = " ";
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Appearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 0;
    ultraGridColumn70.Hidden = true;
    ultraGridColumn70.Width = 169;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 1;
    ultraGridColumn71.Hidden = true;
    ultraGridColumn71.Width = 169;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 2;
    ultraGridColumn72.Width = 123;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 3;
    ultraGridColumn73.Width = 295;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 4;
    ultraGridColumn74.Hidden = true;
    ultraGridColumn74.Width = 34;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 5;
    ultraGridColumn75.Width = 223;
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 6;
    ultraGridColumn76.Hidden = true;
    ultraGridColumn76.Width = 21;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 7;
    ultraGridColumn77.Hidden = true;
    ultraGridColumn77.Width = 24;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 8;
    ultraGridColumn78.Hidden = true;
    ultraGridColumn78.Width = 31 /*0x1F*/;
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 9;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn79.Width = 31 /*0x1F*/;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 10;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn80.Width = 55;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 11;
    ultraGridColumn81.Hidden = true;
    ultraGridColumn81.Width = 55;
    ultraGridColumn82.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 12;
    ultraGridColumn82.Hidden = true;
    ultraGridColumn82.Width = 62;
    ultraGridColumn83.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 13;
    ultraGridColumn83.Hidden = true;
    ultraGridColumn83.Width = 62;
    ultraGridColumn84.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Header.VisiblePosition = 14;
    ultraGridColumn84.Hidden = true;
    ultraGridColumn84.Width = 62;
    ultraGridColumn85.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn85.Header.VisiblePosition = 15;
    ultraGridColumn85.Hidden = true;
    ultraGridColumn85.Width = 62;
    ultraGridColumn86.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn86.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn86.Hidden = true;
    ultraGridColumn86.Width = 62;
    ultraGridBand5.Columns.AddRange(new object[17]
    {
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86
    });
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance35.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance36.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance37.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance38.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance38;
    appearance39.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance40.BackColor = Color.Transparent;
    appearance40.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance40;
    appearance41.BackColor = Color.WhiteSmoke;
    appearance41.BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((Control) this.dgInsuredContacts).Dock = DockStyle.Fill;
    ((Control) this.dgInsuredContacts).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgInsuredContacts).Location = new Point(0, 0);
    ((Control) this.dgInsuredContacts).Name = "dgInsuredContacts";
    ((Control) this.dgInsuredContacts).Size = new Size(660, 340);
    ((Control) this.dgInsuredContacts).TabIndex = 2;
    ((UltraControlBase) this.dgInsuredContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgInsuredContacts).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtContactInfo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtContactInfo).Appearance = (AppearanceBase) appearance43;
    ((TextEditorControlBase) this.txtContactInfo).BackColor = Color.White;
    ((Control) this.txtContactInfo).Location = new Point(15, 449);
    this.txtContactInfo.MGAStyle = MGAStyles.Blue;
    this.txtContactInfo.Multiline = true;
    ((Control) this.txtContactInfo).Name = "txtContactInfo";
    ((EditorButtonControlBase) this.txtContactInfo).ReadOnly = true;
    ((Control) this.txtContactInfo).Size = new Size(655, 91);
    ((Control) this.txtContactInfo).TabIndex = 1;
    ((UltraControlBase) this.txtContactInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtContactInfo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label2.Location = new Point(128 /*0x80*/, 421);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(56, 23);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Order By:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.rbContactName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbContactName.Checked = true;
    this.rbContactName.Location = new Point(186, 421);
    this.rbContactName.Name = "rbContactName";
    this.rbContactName.Size = new Size(93, 24);
    this.rbContactName.TabIndex = 4;
    this.rbContactName.TabStop = true;
    this.rbContactName.Text = "Contact Name";
    this.rbLocationName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbLocationName.Location = new Point(281, 421);
    this.rbLocationName.Name = "rbLocationName";
    this.rbLocationName.Size = new Size(69, 24);
    this.rbLocationName.TabIndex = 5;
    this.rbLocationName.Text = "Location";
    this.spGetContactInfo.CommandText = "dbo.[spGetContactInfo]";
    this.spGetContactInfo.CommandType = CommandType.StoredProcedure;
    this.spGetContactInfo.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@ContactType", SqlDbType.VarChar, 1),
      new SqlParameter("@ContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@Envelopes", SqlDbType.Bit)
    });
    this.spContactManagement.CommandText = "dbo.[spContactManagement]";
    this.spContactManagement.CommandType = CommandType.StoredProcedure;
    this.spContactManagement.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@ContactType", SqlDbType.VarChar, 1),
      new SqlParameter("@ReturnRowCount", SqlDbType.Int, 1),
      new SqlParameter("@QuoteGUID", SqlDbType.UniqueIdentifier)
    });
    this.cm.MenuItems.AddRange(new MenuItem[2]
    {
      this.mnuEmail,
      this.mnuCallReports
    });
    this.mnuEmail.Index = 0;
    this.mnuEmail.Text = "Send Email";
    this.mnuCallReports.Index = 1;
    this.mnuCallReports.Text = "Call Report";
    ((Control) this.btnPrintEnvelope).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance44.BackColor = Color.Gainsboro;
    appearance44.BackColor2 = Color.White;
    appearance44.BackGradientStyle = (GradientStyle) 2;
    appearance44.BorderColor = Color.Gray;
    appearance44.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image"));
    appearance44.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrintEnvelope).Appearance = (AppearanceBase) appearance44;
    ((ControlBase) this.btnPrintEnvelope).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrintEnvelope).Location = new Point(568, 411);
    ((Control) this.btnPrintEnvelope).Name = "btnPrintEnvelope";
    ((Control) this.btnPrintEnvelope).Size = new Size(28, 33);
    ((Control) this.btnPrintEnvelope).TabIndex = 6;
    ultraToolTipInfo1.ToolTipText = "Prints an envelope addressed to the selected contact";
    ultraToolTipInfo1.ToolTipTitle = "Print Envelope";
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.btnPrintEnvelope, ultraToolTipInfo1);
    this.btnPrintEnvelope.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPrintLabelSheet).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance45.BackColor = Color.Gainsboro;
    appearance45.BackColor2 = Color.White;
    appearance45.BackGradientStyle = (GradientStyle) 2;
    appearance45.BorderColor = Color.Gray;
    appearance45.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image"));
    appearance45.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrintLabelSheet).Appearance = (AppearanceBase) appearance45;
    ((ControlBase) this.btnPrintLabelSheet).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrintLabelSheet).Location = new Point(603, 411);
    ((Control) this.btnPrintLabelSheet).Name = "btnPrintLabelSheet";
    ((Control) this.btnPrintLabelSheet).Size = new Size(28, 33);
    ((Control) this.btnPrintLabelSheet).TabIndex = 7;
    ultraToolTipInfo2.ToolTipText = "Prints a contact sheet of the current contacts";
    ultraToolTipInfo2.ToolTipTitle = "Print Contact Sheet";
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.btnPrintLabelSheet, ultraToolTipInfo2);
    this.btnPrintLabelSheet.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.tabContacts).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabContacts).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabContacts).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.tabContacts).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.tabContacts).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.tabContacts).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.tabContacts).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.tabContacts).Location = new Point(7, 38);
    ((Control) this.tabContacts).Name = "tabContacts";
    ((UltraTabControlBase) this.tabContacts).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((UltraTabControlBase) this.tabContacts).ShowTabListButton = (DefaultableBoolean) 2;
    ((Control) this.tabContacts).Size = new Size(662, 367);
    ((Control) this.tabContacts).TabIndex = 8;
    ((UltraTabControlBase) this.tabContacts).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.tabContacts).TabPadding = new Size(5, 3);
    appearance46.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance47.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance46;
    ultraTab1.Key = "tabCompany";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Company";
    appearance47.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance48.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance47;
    ultraTab2.Key = "tabProducer";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Producer";
    appearance48.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance49.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance48;
    ultraTab3.Key = "tabUsers";
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "Users";
    appearance49.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance50.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance49;
    ultraTab4.Key = "tabAll";
    ultraTab4.TabPage = this.UltraTabPageControl4;
    ultraTab4.Text = "All Contacts";
    ultraTab5.Key = "tabInsured";
    ultraTab5.TabPage = this.UltraTabPageControl5;
    ultraTab5.Text = "Insured Contacts";
    ((UltraTabControlBase) this.tabContacts).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraControlBase) this.tabContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraTabControlBase) this.tabContacts).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(660, 340);
    this.UltraToolTipManager1.ContainingControl = (Control) this;
    this.UltraToolTipManager1.DisplayStyle = (ToolTipDisplayStyle) 3;
    ((Control) this.btnBulkPrintEnvelopes).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance50.BackColor = Color.Gainsboro;
    appearance50.BackColor2 = Color.White;
    appearance50.BackGradientStyle = (GradientStyle) 2;
    appearance50.BorderColor = Color.Gray;
    appearance50.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.email_link;
    appearance50.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnBulkPrintEnvelopes).Appearance = (AppearanceBase) appearance50;
    ((ControlBase) this.btnBulkPrintEnvelopes).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnBulkPrintEnvelopes).Location = new Point(637, 412);
    ((Control) this.btnBulkPrintEnvelopes).Name = "btnBulkPrintEnvelopes";
    ((Control) this.btnBulkPrintEnvelopes).Size = new Size(28, 33);
    ((Control) this.btnBulkPrintEnvelopes).TabIndex = 11;
    ultraToolTipInfo3.ToolTipText = "Bulk prints envelopes addressed to selected contacts";
    ultraToolTipInfo3.ToolTipTitle = "Bulk Print Envelopes";
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.btnBulkPrintEnvelopes, ultraToolTipInfo3);
    this.btnBulkPrintEnvelopes.UseOSThemes = (DefaultableBoolean) 2;
    appearance51.BackColor = Color.White;
    appearance51.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance51.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtContactSearch).Appearance = (AppearanceBase) appearance51;
    ((TextEditorControlBase) this.txtContactSearch).BackColor = Color.White;
    ((Control) this.txtContactSearch).Location = new Point(131, 9);
    ((TextEditorControlBase) this.txtContactSearch).MaxLength = 2000;
    this.txtContactSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtContactSearch).Name = "txtContactSearch";
    ((Control) this.txtContactSearch).Size = new Size(282, 20);
    ((Control) this.txtContactSearch).TabIndex = 9;
    ((UltraControlBase) this.txtContactSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtContactSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.dvInsured.RowFilter = "LocationType='I'";
    this.dvInsured.Table = (DataTable) this.ds.Contacts;
    this.chkOnlyActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.chkOnlyActive.AutoSize = true;
    this.chkOnlyActive.CheckAlign = ContentAlignment.MiddleRight;
    this.chkOnlyActive.Checked = true;
    this.chkOnlyActive.CheckState = CheckState.Checked;
    this.chkOnlyActive.ImageAlign = ContentAlignment.MiddleLeft;
    this.chkOnlyActive.Location = new Point(373, 424);
    this.chkOnlyActive.Name = "chkOnlyActive";
    this.chkOnlyActive.Size = new Size(108, 17);
    this.chkOnlyActive.TabIndex = 12;
    this.chkOnlyActive.Text = "Show only Active";
    this.chkOnlyActive.UseVisualStyleBackColor = true;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(677, 550);
    this.Controls.Add((Control) this.chkOnlyActive);
    this.Controls.Add((Control) this.btnBulkPrintEnvelopes);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.txtContactSearch);
    this.Controls.Add((Control) this.tabContacts);
    this.Controls.Add((Control) this.btnPrintLabelSheet);
    this.Controls.Add((Control) this.btnPrintEnvelope);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) this.txtContactInfo);
    this.Controls.Add((Control) this.rbContactName);
    this.Controls.Add((Control) this.rbLocationName);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.KeyPreview = true;
    this.Name = nameof (frmContactManagement);
    this.Text = "Contact Management";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.dgCompanyContacts).EndInit();
    this.dvCompany.EndInit();
    this.ds.EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.dgProducerContacts).EndInit();
    this.dvProducer.EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.dgOfficeContacts).EndInit();
    this.dvUsers.EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.dgAllContacts).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.dgInsuredContacts).EndInit();
    ((ISupportInitialize) this.txtContactInfo).EndInit();
    ((ISupportInitialize) this.btnPrintEnvelope).EndInit();
    ((ISupportInitialize) this.btnPrintLabelSheet).EndInit();
    ((ISupportInitialize) this.tabContacts).EndInit();
    ((Control) this.tabContacts).ResumeLayout(false);
    ((ISupportInitialize) this.btnBulkPrintEnvelopes).EndInit();
    ((ISupportInitialize) this.txtContactSearch).EndInit();
    this.dvInsured.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmContactManagement()
  {
    this.Load += new EventHandler(this.frmContactManagement_Load);
    this.KeyPress += new KeyPressEventHandler(this.frmContactManagement_KeyPress);
    this._quoteGuid = Guid.Empty;
    this._allContactGridlayout = new MemoryStream();
    this._companyContactGridlayout = new MemoryStream();
    this._officeContactGridlayout = new MemoryStream();
    this._producerContactGridlayout = new MemoryStream();
    this._insuredContactGridlayout = new MemoryStream();
    this.InitializeComponent();
    if (!(MDIControls.Instance.MDIParent.ActiveMdiChild is ISupportQuoteContacts activeMdiChild))
      return;
    try
    {
      this._quoteGuid = activeMdiChild.EntityQuoteGuid;
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (!ex.Message.Contains("No quote selected"))
        throw;
      ProjectData.ClearProjectError();
    }
  }

  private void frmContactManagement_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.dgAllContacts).DisplayLayout.Save((Stream) this._allContactGridlayout);
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Save((Stream) this._companyContactGridlayout);
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Save((Stream) this._officeContactGridlayout);
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Save((Stream) this._producerContactGridlayout);
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Save((Stream) this._insuredContactGridlayout);
    ((UltraGridBase) this.dgAllContacts).DataSource = (object) null;
    ((UltraGridBase) this.dgCompanyContacts).DataSource = (object) null;
    ((UltraGridBase) this.dgOfficeContacts).DataSource = (object) null;
    ((UltraGridBase) this.dgProducerContacts).DataSource = (object) null;
    ((UltraGridBase) this.dgInsuredContacts).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillDataThread));
  }

  private void FillDataThread(object state)
  {
    try
    {
      this.FillContactsWrapper("c");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmContactManagement.HandleErrorOnUIThread(this.HandleError), (object) ex);
      ProjectData.ClearProjectError();
    }
    if (((!this.IsHandleCreated ? 0 : (!this.IsDisposed ? 1 : 0)) & (!this.Disposing ? 1 : 0)) == 0)
      return;
    try
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.FillThreadComplete));
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void HandleError(Exception ex)
  {
  }

  private void FillThreadComplete()
  {
    try
    {
      this._allContactGridlayout.Position = 0L;
      this._companyContactGridlayout.Position = 0L;
      this._officeContactGridlayout.Position = 0L;
      this._producerContactGridlayout.Position = 0L;
      this._insuredContactGridlayout.Position = 0L;
      ((UltraGridBase) this.dgAllContacts).DataSource = (object) this.ds.Contacts;
      ((UltraGridBase) this.dgAllContacts).DisplayLayout.Load((Stream) this._allContactGridlayout);
      ((UltraGridBase) this.dgAllContacts).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
      ((UltraGridBase) this.dgCompanyContacts).DataSource = (object) this.dvCompany;
      ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Load((Stream) this._companyContactGridlayout);
      ((UltraGridBase) this.dgOfficeContacts).DataSource = (object) this.dvUsers;
      ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Load((Stream) this._officeContactGridlayout);
      ((UltraGridBase) this.dgProducerContacts).DataSource = (object) this.dvProducer;
      ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Load((Stream) this._producerContactGridlayout);
      ((UltraGridBase) this.dgInsuredContacts).DataSource = (object) this.dvInsured;
      ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Load((Stream) this._insuredContactGridlayout);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void FillContactsWrapper(string contactType)
  {
    List<object> objectList = new List<object>()
    {
      (object) "@ContactType",
      (object) contactType,
      (object) "@ReturnRowCount",
      (object) 0
    };
    if (!this._quoteGuid.Equals(Guid.Empty))
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (sender, args) => this.ds.Contacts.Load(args.Reader)), this.spContactManagement.CommandType, this.spContactManagement.CommandText, objectList.ToArray());
  }

  protected virtual bool ShowOnlyContacts() => true;

  protected virtual void ShowCompanyAndContactsForm(Guid contactGuid)
  {
  }

  private void AfterRowActivate(object sender, EventArgs e)
  {
    UltraGrid ultraGrid = (UltraGrid) sender;
    this.UpdateContactInformation((Guid) ((UltraGridBase) ultraGrid).ActiveRow.Cells["ContactGuid"].Value, ((UltraGridBase) ultraGrid).ActiveRow.Cells["LocationType"].Value.ToString(), false);
  }

  private void ChangeFilter(object sender, EventArgs e)
  {
    if (this.rbContactName.Checked)
    {
      this.dvCompany.Sort = "ContactName";
      this.dvProducer.Sort = "ContactName";
      this.dvUsers.Sort = "ContactName";
      this.dvInsured.Sort = "ContactName";
      this.ds.Contacts.DefaultView.Sort = "ContactName";
    }
    else
    {
      this.dvCompany.Sort = "LocationName";
      this.dvProducer.Sort = "LocationName";
      this.dvUsers.Sort = "LocationName";
      this.dvInsured.Sort = "LocationName";
      this.ds.Contacts.DefaultView.Sort = "LocationName";
    }
  }

  private void frmContactManagement_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (!char.IsLetter(e.KeyChar))
      return;
    UltraGrid visibleGrid = this.GetVisibleGrid();
    foreach (UltraGridRow row in ((UltraGridBase) visibleGrid).Rows)
    {
      if (this.rbContactName.Checked && (row.Cells["ContactName"].Value.ToString().StartsWith(Conversions.ToString(e.KeyChar)) || row.Cells["ContactName"].Value.ToString().StartsWith(Conversions.ToString(char.ToUpper(e.KeyChar)))) || this.rbLocationName.Checked && (row.Cells["LocationName"].Value.ToString().StartsWith(Conversions.ToString(e.KeyChar)) || row.Cells["LocationName"].Value.ToString().StartsWith(Conversions.ToString(char.ToUpper(e.KeyChar)))))
      {
        ((UltraGridBase) visibleGrid).DisplayLayout.RowScrollRegions[0].ScrollRowIntoView(row);
        if (visibleGrid.Selected.Rows.Count > 0)
          ((UltraGridBase) visibleGrid).ActiveRow.Selected = false;
        ((UltraGridBase) visibleGrid).ActiveRow = row;
        ((UltraGridBase) visibleGrid).ActiveRow.Selected = true;
        break;
      }
    }
  }

  private void SectionChanged()
  {
    UltraGrid visibleGrid = this.GetVisibleGrid();
    if (visibleGrid.Selected.Rows.Count == 0 && ((UltraGridBase) visibleGrid).Rows.Count > 0)
      ((UltraGridBase) visibleGrid).Rows[0].Selected = true;
    if (((UltraGridBase) visibleGrid).Rows.Count <= 0)
      return;
    this.UpdateContactInformation((Guid) visibleGrid.Selected.Rows[0].Cells["ContactGuid"].Value, visibleGrid.Selected.Rows[0].Cells["LocationType"].Value.ToString(), false);
  }

  private void UpdateContactInformation(Guid ContactGuid, string LocationType, bool Envelopes)
  {
    MDIControls.Instance.StatusBarText = "Getting contact information...";
    ((TextEditorControlBase) this.txtContactInfo).Text = DefaultDatabase.ExecuteScalar<string>(this.spGetContactInfo.CommandType, this.spGetContactInfo.CommandText, new object[6]
    {
      (object) "@ContactGuid",
      (object) ContactGuid,
      (object) "@ContactType",
      (object) LocationType,
      (object) "@Envelopes",
      (object) Envelopes
    });
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void FillContacts(string contactType)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.FillContactsWrapper(contactType);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void mnuEmail_Click(object sender, EventArgs e)
  {
    string Left = ((UltraGridBase) this.GetVisibleGrid()).ActiveRow.Cells["Email"].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) == 0)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      Process.Start("mailto:" + Left);
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private UltraGrid GetVisibleGrid()
  {
    return ((UltraTabControlBase) this.tabContacts).SelectedTab != ((UltraTabControlBase) this.tabContacts).Tabs["tabCompany"] ? (((UltraTabControlBase) this.tabContacts).SelectedTab != ((UltraTabControlBase) this.tabContacts).Tabs["tabProducer"] ? (((UltraTabControlBase) this.tabContacts).SelectedTab != ((UltraTabControlBase) this.tabContacts).Tabs["tabUsers"] ? (((UltraTabControlBase) this.tabContacts).SelectedTab != ((UltraTabControlBase) this.tabContacts).Tabs["tabInsured"] ? this.dgAllContacts : this.dgInsuredContacts) : this.dgOfficeContacts) : this.dgProducerContacts) : this.dgCompanyContacts;
  }

  private static void ShowCompanyContactForm(Guid contactGuid)
  {
    if (DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetCompanyContactType(@contactGuid)", new object[2]
    {
      (object) "@contactGuid",
      (object) contactGuid
    }).Equals("C"))
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, " SELECT CL.CompanyLocationGUID, CL.CompanyGUID  FROM  tblCompanyContacts CC WITH (NOLOCK)  INNER JOIN tblCompanyLocations CL WITH  (NOLOCK) ON CC.CompanyLocationGUID = CL.CompanyLocationGUID  WHERE (CC.CompanyContactGUID = @contactGuid)", new object[2]
      {
        (object) "@contactGuid",
        (object) contactGuid
      });
      using (FormSettings.ShowFormDialog(typeof (frmCompanyContacts), (object) (Guid) dataRow[1], (object) (Guid) dataRow[0], (object) contactGuid))
        ;
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmIntermediaryContacts), (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, " SELECT IntermediaryID FROM tblIntermediaryContacts WITH (NOLOCK) WHERE IntermediaryContactGUID = @IC ", new object[2]
      {
        (object) "@IC",
        (object) contactGuid
      }), (object) contactGuid))
        ;
    }
  }

  private static void ShowProducerContactForm(Guid contactGuid)
  {
    using (FormSettings.ShowFormDialog(typeof (frmProducerContacts), (object) DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, " SELECT ProducerLocationGUID FROM tblProducerContacts WITH (NOLOCK) WHERE ProducerContactGUID = @contactGuid", new object[2]
    {
      (object) "@contactGuid",
      (object) contactGuid
    }), (object) contactGuid))
      ;
  }

  private static void ShowUserForm(Guid contactGuid)
  {
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(contactGuid);
    if (ServerXML.UseEncryptedPasswords)
    {
      using (FormSettings.ShowFormDialog(typeof (frmUserEncPwd), (object) user))
        ;
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (frmUsers), (object) user))
        ;
    }
  }

  private static void ShowInsuredContactForm(Guid contactGuid, Guid contactLocationGuid)
  {
    using (FormSettings.ShowFormDialog(typeof (frmInsuredContacts), (object) contactLocationGuid, (object) contactGuid))
      ;
  }

  private void dgAllContacts_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    UltraGrid ultraGrid = (UltraGrid) sender;
    if (((UltraGridBase) ultraGrid).ActiveRow == null)
      return;
    Guid contactGuid = (Guid) ((UltraGridBase) ultraGrid).ActiveRow.Cells["ContactGuid"].Value;
    string str = (string) ((UltraGridBase) ultraGrid).ActiveRow.Cells["LocationType"].Value;
    Guid contactLocationGuid = (Guid) ((UltraGridBase) ultraGrid).ActiveRow.Cells["ContactLocationGuid"].Value;
    if (str.ToString().Equals("C"))
    {
      if (this.ShowOnlyContacts())
        frmContactManagement.ShowCompanyContactForm(contactGuid);
      else
        this.ShowCompanyAndContactsForm(contactGuid);
    }
    else if (str.ToString().Equals("P"))
      frmContactManagement.ShowProducerContactForm(contactGuid);
    else if (str.ToString().Equals("U"))
    {
      frmContactManagement.ShowUserForm(contactGuid);
    }
    else
    {
      if (!str.ToString().Equals("I"))
        return;
      frmContactManagement.ShowInsuredContactForm(contactGuid, contactLocationGuid);
    }
  }

  private void GridMouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    UltraGrid ultraGrid = (UltraGrid) sender;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) ultraGrid).DisplayLayout.UIElement).LastElementEntered;
    if (lastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) lastElementEntered.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    ((UltraGridBase) ultraGrid).ActiveRow = context;
    ultraGrid.Selected.Rows.Clear();
    context.Selected = true;
    string Left = ((UltraGridBase) ultraGrid).ActiveRow.Cells["Email"].Value.ToString();
    this.mnuEmail.Enabled = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) != 0;
    this.mnuEmail.Text = !this.mnuEmail.Enabled ? "Send an Email" : "Send an Email to " + Left;
    this.cm.Show((Control) ultraGrid, new Point(e.X, e.Y));
    this.mnuCallReports.Enabled = false;
    if (sender == this.dgProducerContacts)
      this.mnuCallReports.Enabled = true;
    if (sender != this.dgAllContacts || !context.Cells["LocationType"].Value.ToString().Equals("P"))
      return;
    this.mnuCallReports.Enabled = true;
  }

  private void btnPrintEnvelope_Click(object sender, EventArgs e)
  {
    if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabProducer"])
    {
      UltraGrid producerContacts = this.dgProducerContacts;
      this.UpdateContactInformation((Guid) ((UltraGridBase) producerContacts).ActiveRow.Cells["ContactGuid"].Value, ((UltraGridBase) producerContacts).ActiveRow.Cells["LocationType"].Value.ToString(), true);
    }
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabCompany"])
    {
      UltraGrid dgCompanyContacts = this.dgCompanyContacts;
      this.UpdateContactInformation((Guid) ((UltraGridBase) dgCompanyContacts).ActiveRow.Cells["ContactGuid"].Value, ((UltraGridBase) dgCompanyContacts).ActiveRow.Cells["LocationType"].Value.ToString(), true);
    }
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabAll"])
    {
      UltraGrid dgAllContacts = this.dgAllContacts;
      this.UpdateContactInformation((Guid) ((UltraGridBase) dgAllContacts).ActiveRow.Cells["ContactGuid"].Value, ((UltraGridBase) dgAllContacts).ActiveRow.Cells["LocationType"].Value.ToString(), true);
    }
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabUsers"])
    {
      UltraGrid dgOfficeContacts = this.dgOfficeContacts;
      this.UpdateContactInformation((Guid) ((UltraGridBase) dgOfficeContacts).ActiveRow.Cells["ContactGuid"].Value, ((UltraGridBase) dgOfficeContacts).ActiveRow.Cells["LocationType"].Value.ToString(), true);
    }
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabInsured"])
    {
      UltraGrid dgInsuredContacts = this.dgInsuredContacts;
      this.UpdateContactInformation((Guid) ((UltraGridBase) dgInsuredContacts).ActiveRow.Cells["ContactGuid"].Value, ((UltraGridBase) dgInsuredContacts).ActiveRow.Cells["LocationType"].Value.ToString(), true);
    }
    frmPrintEnvelope formEx = (frmPrintEnvelope) ObjectFactory.Instance.CreateFormEX(typeof (frmPrintEnvelope), (object) ((TextEditorControlBase) this.txtContactInfo).Text, (object) "");
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
  }

  private void btnPrintLabelSheet_Click(object sender, EventArgs e)
  {
    frmPrintLabels formEx = (frmPrintLabels) ObjectFactory.Instance.CreateFormEX(typeof (frmPrintLabels), (object) ((TextEditorControlBase) this.txtContactInfo).Text);
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
  }

  private void tabContacts_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    ((UltraGridBase) this.dgCompanyContacts).DisplayLayout.Bands["Contacts"].Columns["Contact Type"].Hidden = true;
    ((UltraGridBase) this.dgInsuredContacts).DisplayLayout.Bands["Contacts"].Columns["Contact Type"].Hidden = true;
    ((UltraGridBase) this.dgOfficeContacts).DisplayLayout.Bands["Contacts"].Columns["Contact Type"].Hidden = true;
    ((UltraGridBase) this.dgProducerContacts).DisplayLayout.Bands["Contacts"].Columns["Contact Type"].Hidden = false;
    try
    {
      if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabProducer"] && this.ds.Contacts.Select("LocationType='P'").Length == 0)
        this.FillContacts("P");
      else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabUsers"] && this.ds.Contacts.Select("LocationType='U'").Length == 0)
        this.FillContacts("U");
      else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabInsured"] && this.ds.Contacts.Select("LocationType='I'").Length == 0)
        this.FillContacts("I");
      this.SectionChanged();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void txtContact_TextChanged(object sender, EventArgs e)
  {
    this.dvCompany.RowFilter = "LocationType='C'";
    this.dvProducer.RowFilter = "LocationType='P'";
    this.dvUsers.RowFilter = "LocationType='U'";
    this.dvInsured.RowFilter = "LocationType='I'";
    this.ds.Contacts.DefaultView.RowFilter = string.Empty;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtContactSearch).Text))
      return;
    string str1 = $"ContactName LIKE '%{((TextEditorControlBase) this.txtContactSearch).Text.Replace("'", "''")}%'";
    DataView dvCompany;
    string str2 = $"{(dvCompany = this.dvCompany).RowFilter} AND {str1}";
    dvCompany.RowFilter = str2;
    DataView dvProducer;
    string str3 = $"{(dvProducer = this.dvProducer).RowFilter} AND {str1}";
    dvProducer.RowFilter = str3;
    DataView dvUsers;
    string str4 = $"{(dvUsers = this.dvUsers).RowFilter} AND {str1}";
    dvUsers.RowFilter = str4;
    DataView dvInsured;
    string str5 = $"{(dvInsured = this.dvInsured).RowFilter} AND {str1}";
    dvInsured.RowFilter = str5;
    this.ds.Contacts.DefaultView.RowFilter = str1;
  }

  private void dgCompanyContacts_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Disabled"].Value))
      return;
    e.Row.Hidden = this.chkOnlyActive.Checked;
    e.Row.Appearance.ForeColor = Color.Red;
  }

  private void dgProducerContacts_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Disabled"].Value))
      return;
    e.Row.Hidden = this.chkOnlyActive.Checked;
    e.Row.Appearance.ForeColor = Color.Red;
  }

  private void dgOfficeContacts_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Disabled"].Value))
      return;
    e.Row.Hidden = this.chkOnlyActive.Checked;
    e.Row.Appearance.ForeColor = Color.Red;
  }

  private void dgAllContacts_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Disabled"].Value))
      return;
    e.Row.Hidden = this.chkOnlyActive.Checked;
    e.Row.Appearance.ForeColor = Color.Red;
  }

  private void dgInsuredContacts_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Conversions.ToBoolean(e.Row.Cells["Disabled"].Value))
      return;
    e.Row.Hidden = this.chkOnlyActive.Checked;
    e.Row.Appearance.ForeColor = Color.Red;
  }

  private void dgInsuredContacts_Click(object sender, EventArgs e)
  {
    if (this.dgInsuredContacts.Selected.Rows.Count > 0)
    {
      object obj = ((UltraGridBase) this.dgInsuredContacts).ActiveRow.Cells["ContactGUID"].Value;
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TOP 1 * FROM tblInsuredContacts WHERE InsuredContactGUID =@SearchGuid", new object[2]
      {
        (object) "@SearchGuid",
        (object) (obj != null ? (Guid) obj : new Guid())
      });
      ((TextEditorControlBase) this.txtContactInfo).Text = $"{dataTable.Rows[0]["LName"].ToString()}, {dataTable.Rows[0]["FName"].ToString()}\r\nEmail:{dataTable.Rows[0]["Email"].ToString()}\r\nAddress:{dataTable.Rows[0]["Address1"].ToString()}{Strings.Space(1)}{dataTable.Rows[0]["Address2"].ToString()}{Strings.Space(1)}{dataTable.Rows[0]["City"].ToString()},{Strings.Space(1)}{dataTable.Rows[0]["State"].ToString()},{Strings.Space(1)}{dataTable.Rows[0]["Zipcode"].ToString()}\r\nPhone:{dataTable.Rows[0]["Phone"].ToString()}\r\nCell:{dataTable.Rows[0]["Cell"].ToString()}\r\nFax:{dataTable.Rows[0]["Fax"].ToString()}";
    }
  }

  private void dgInsuredContacts_DoubleClick(object sender, EventArgs e)
  {
    frmContactManagement.ShowInsuredContactForm((Guid) ((UltraGridBase) this.dgInsuredContacts).ActiveRow.Cells["ContactGuid"].Value, (Guid) ((UltraGridBase) this.dgInsuredContacts).ActiveRow.Cells["ContactLocationGuid"].Value);
  }

  private void btnBulkPrintEnvelopes_Click(object sender, EventArgs e)
  {
    UltraGrid ultraGrid = (UltraGrid) null;
    if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabProducer"])
      ultraGrid = this.dgProducerContacts;
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabCompany"])
      ultraGrid = this.dgCompanyContacts;
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabAll"])
      ultraGrid = this.dgAllContacts;
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabUsers"])
      ultraGrid = this.dgOfficeContacts;
    else if (((UltraTabControlBase) this.tabContacts).SelectedTab == ((UltraTabControlBase) this.tabContacts).Tabs["tabInsured"])
      ultraGrid = this.dgInsuredContacts;
    if (ultraGrid == null)
      throw new InvalidOperationException("btnBulkPrintEnvelopes_Click couldnt determine target grid");
    new frmPrintBulkEnvelopes(RuntimeHelpers.GetObjectValue(((UltraGridBase) ultraGrid).DataSource)).Show();
  }

  private void chkOnlyActive_CheckedChanged(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    UltraGrid dgCompanyContacts = this.dgCompanyContacts;
    this.ShowOrHideRows(ref dgCompanyContacts, this.chkOnlyActive.Checked);
    this.dgCompanyContacts = dgCompanyContacts;
    UltraGrid producerContacts = this.dgProducerContacts;
    this.ShowOrHideRows(ref producerContacts, this.chkOnlyActive.Checked);
    this.dgProducerContacts = producerContacts;
    UltraGrid dgOfficeContacts = this.dgOfficeContacts;
    this.ShowOrHideRows(ref dgOfficeContacts, this.chkOnlyActive.Checked);
    this.dgOfficeContacts = dgOfficeContacts;
    UltraGrid dgAllContacts = this.dgAllContacts;
    this.ShowOrHideRows(ref dgAllContacts, this.chkOnlyActive.Checked);
    this.dgAllContacts = dgAllContacts;
    UltraGrid dgInsuredContacts = this.dgInsuredContacts;
    this.ShowOrHideRows(ref dgInsuredContacts, this.chkOnlyActive.Checked);
    this.dgInsuredContacts = dgInsuredContacts;
    this.Cursor = Cursors.Default;
  }

  private void ShowOrHideRows(ref UltraGrid dGrid, bool SetHidden)
  {
    foreach (UltraGridRow row in ((UltraGridBase) dGrid).Rows)
    {
      if (Conversions.ToBoolean(row.Cells["Disabled"].Value))
      {
        row.Hidden = SetHidden;
        row.Appearance.ForeColor = Color.Red;
      }
    }
  }

  private void mnuCallReports_Click(object sender, EventArgs e)
  {
    UltraGrid visibleGrid = this.GetVisibleGrid();
    if (visibleGrid != this.dgProducerContacts && visibleGrid != this.dgAllContacts || visibleGrid == this.dgAllContacts && !((UltraGridBase) visibleGrid).ActiveRow.Cells["LocationType"].Value.Equals((object) "P"))
      return;
    using (FormSettings.ShowFormDialog(typeof (FormProducerCallReports), (object) (Guid) ((UltraGridBase) visibleGrid).ActiveRow.Cells["ContactLocationGuid"].Value, (object) false))
      ;
  }

  private delegate void HandleErrorOnUIThread(Exception ex);
}
