// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmDocumentAutomation
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class frmDocumentAutomation : Form, ITransactionLogFilter
{
  private IContainer components;
  private UltraLabel lblCompanyLine;
  private SqlConnection cnSQL;
  private SqlCommand cmdInsert;
  private SqlCommand SqlCommand1;
  protected UltraGrid dgAvailable;
  protected frmDocumentAutomation.FixedUltraGrid dgApplied;
  private Guid _companyLineGuid;
  private bool _changesMade;
  private int _tempAdd;

  protected virtual MGAButton btnMoveUp
  {
    get => this._btnMoveUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMoveUp_Click);
      MGAButton btnMoveUp1 = this._btnMoveUp;
      if (btnMoveUp1 != null)
        ((Control) btnMoveUp1).Click -= eventHandler;
      this._btnMoveUp = value;
      MGAButton btnMoveUp2 = this._btnMoveUp;
      if (btnMoveUp2 == null)
        return;
      ((Control) btnMoveUp2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnMoveDown
  {
    get => this._btnMoveDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMoveDown_Click);
      MGAButton btnMoveDown1 = this._btnMoveDown;
      if (btnMoveDown1 != null)
        ((Control) btnMoveDown1).Click -= eventHandler;
      this._btnMoveDown = value;
      MGAButton btnMoveDown2 = this._btnMoveDown;
      if (btnMoveDown2 == null)
        return;
      ((Control) btnMoveDown2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("ds")]
  protected virtual dsDocumentAutomation ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboSystemEvents")]
  protected virtual MGASimpleComboBox cboSystemEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daCompanyDocs")]
  protected virtual SqlDataAdapter daCompanyDocs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnDelete
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

  protected virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkEmailAutomation
  {
    get => this._lnkEmailAutomation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEmailAutomation_LinkClicked);
      LinkLabel lnkEmailAutomation1 = this._lnkEmailAutomation;
      if (lnkEmailAutomation1 != null)
        lnkEmailAutomation1.LinkClicked -= clickedEventHandler;
      this._lnkEmailAutomation = value;
      LinkLabel lnkEmailAutomation2 = this._lnkEmailAutomation;
      if (lnkEmailAutomation2 == null)
        return;
      lnkEmailAutomation2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCopy
  {
    get => this._lnkCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      LinkLabel lnkCopy1 = this._lnkCopy;
      if (lnkCopy1 != null)
        lnkCopy1.LinkClicked -= clickedEventHandler;
      this._lnkCopy = value;
      LinkLabel lnkCopy2 = this._lnkCopy;
      if (lnkCopy2 == null)
        return;
      lnkCopy2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboStatusReason
  {
    get => this._cboStatusReason;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboStatusReason_ValueChanged);
      MGASimpleComboBox cboStatusReason1 = this._cboStatusReason;
      if (cboStatusReason1 != null)
        cboStatusReason1.ValueChanged -= eventHandler;
      this._cboStatusReason = value;
      MGASimpleComboBox cboStatusReason2 = this._cboStatusReason;
      if (cboStatusReason2 == null)
        return;
      cboStatusReason2.ValueChanged += eventHandler;
    }
  }

  protected virtual LinkLabel lnkClearStatusReason
  {
    get => this._lnkClearStatusReason;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearStatusReason_LinkClicked);
      LinkLabel clearStatusReason1 = this._lnkClearStatusReason;
      if (clearStatusReason1 != null)
        clearStatusReason1.LinkClicked -= clickedEventHandler;
      this._lnkClearStatusReason = value;
      LinkLabel clearStatusReason2 = this._lnkClearStatusReason;
      if (clearStatusReason2 == null)
        return;
      clearStatusReason2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkBulkDelete
  {
    get => this._lnkBulkDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkBulkDelete_LinkClicked);
      LinkLabel lnkBulkDelete1 = this._lnkBulkDelete;
      if (lnkBulkDelete1 != null)
        lnkBulkDelete1.LinkClicked -= clickedEventHandler;
      this._lnkBulkDelete = value;
      LinkLabel lnkBulkDelete2 = this._lnkBulkDelete;
      if (lnkBulkDelete2 == null)
        return;
      lnkBulkDelete2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual UltraFormattedLinkLabel lnkConditional
  {
    get => this._lnkConditional;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkClickedEventHandler clickedEventHandler = new LinkClickedEventHandler(this.lnkConditional_LinkClicked);
      UltraFormattedLinkLabel lnkConditional1 = this._lnkConditional;
      if (lnkConditional1 != null)
        ((UltraFormattedTextEditorBase) lnkConditional1).LinkClicked -= clickedEventHandler;
      this._lnkConditional = value;
      UltraFormattedLinkLabel lnkConditional2 = this._lnkConditional;
      if (lnkConditional2 == null)
        return;
      ((UltraFormattedTextEditorBase) lnkConditional2).LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("SplitContainer1")]
  protected virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraDropDown1")]
  protected virtual UltraDropDown UltraDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraPictureBox1")]
  protected virtual UltraPictureBox UltraPictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentAutomation));
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblDocumentFolders", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FolderID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ParentFolderID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FolderName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("tblDocumentFolderstblCompanyAutomationDocuments");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblDocumentFolderstblCompanyAutomationDocuments", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DocumentOrder");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AutomationEventGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DocumentName");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("DocumentType");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("FolderID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ChangeFolder");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("QuoteStatusReasonID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Conditional");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("DocumentDescription");
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("AvailableDocuments", -1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DocumentName");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("DocumentDescription");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("DocumentType");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Add", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ID");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblCompanyAutomationDocuments", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("DocumentOrder");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AutomationEventGuid");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("DocumentName");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("DocumentType");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("FolderID", -1, (object) "UltraDropDown1");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("ChangeFolder");
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("QuoteStatusReasonID");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Conditional");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("DocumentDescription");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.lnkConditional = new UltraFormattedLinkLabel();
    this.lblCompanyLine = new UltraLabel();
    this.btnMoveUp = new MGAButton();
    this.btnMoveDown = new MGAButton();
    this.btnSave = new MGAButton();
    this.daCompanyDocs = new SqlDataAdapter();
    this.SqlCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.cmdInsert = new SqlCommand();
    this.Label5 = new Label();
    this.btnDelete = new MGAButton();
    this.btnCancel = new MGAButton();
    this.lnkEmailAutomation = new LinkLabel();
    this.UltraPictureBox1 = new UltraPictureBox();
    this.lnkCopy = new LinkLabel();
    this.Label1 = new Label();
    this.ds = new dsDocumentAutomation();
    this.cboSystemEvents = new MGASimpleComboBox();
    this.cboStatusReason = new MGASimpleComboBox();
    this.lnkClearStatusReason = new LinkLabel();
    this.lnkBulkDelete = new LinkLabel();
    this.SplitContainer1 = new SplitContainer();
    this.UltraDropDown1 = new UltraDropDown();
    this.dgAvailable = new UltraGrid();
    this.dgApplied = new frmDocumentAutomation.FixedUltraGrid();
    ((ISupportInitialize) this.btnMoveUp).BeginInit();
    ((ISupportInitialize) this.btnMoveDown).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboSystemEvents).BeginInit();
    ((ISupportInitialize) this.cboStatusReason).BeginInit();
    this.SplitContainer1.BeginInit();
    this.SplitContainer1.Panel1.SuspendLayout();
    this.SplitContainer1.Panel2.SuspendLayout();
    this.SplitContainer1.SuspendLayout();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    ((ISupportInitialize) this.dgAvailable).BeginInit();
    ((ISupportInitialize) this.dgApplied).BeginInit();
    this.SuspendLayout();
    ((Control) this.lnkConditional).Location = new System.Drawing.Point(704, 217);
    ((Control) this.lnkConditional).Name = "lnkConditional";
    ((Control) this.lnkConditional).Size = new System.Drawing.Size(108, 23);
    ((Control) this.lnkConditional).TabIndex = 27;
    this.lnkConditional.TabStop = true;
    ((UltraFormattedTextEditorBase) this.lnkConditional).Value = (object) "UltraFormattedLinkLabel1";
    ((Control) this.lnkConditional).Visible = false;
    appearance1.ForeColor = Color.Blue;
    ((UltraFormattedTextEditorBase) this.lnkConditional).VisitedLinkAppearance = (AppearanceBase) appearance1;
    ((Control) this.lblCompanyLine).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblCompanyLine).Appearance = (AppearanceBase) appearance2;
    ((Control) this.lblCompanyLine).Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblCompanyLine).Location = new System.Drawing.Point(8, 8);
    ((Control) this.lblCompanyLine).Name = "lblCompanyLine";
    ((Control) this.lblCompanyLine).Size = new System.Drawing.Size(810, 23);
    ((Control) this.lblCompanyLine).TabIndex = 0;
    ((ControlBase) this.lblCompanyLine).Text = "(company line here)";
    ((ControlBase) this.lblCompanyLine).UseMnemonic = false;
    ((Control) this.btnMoveUp).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnMoveUp).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnMoveUp).Location = new System.Drawing.Point(720, 266);
    ((Control) this.btnMoveUp).Name = "btnMoveUp";
    ((Control) this.btnMoveUp).Size = new System.Drawing.Size(88, 23);
    ((Control) this.btnMoveUp).TabIndex = 7;
    ((ControlBase) this.btnMoveUp).Text = "Move Up";
    this.btnMoveUp.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnMoveDown).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnMoveDown).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnMoveDown).Location = new System.Drawing.Point(720, 298);
    ((Control) this.btnMoveDown).Name = "btnMoveDown";
    ((Control) this.btnMoveDown).Size = new System.Drawing.Size(88, 23);
    ((Control) this.btnMoveDown).TabIndex = 8;
    ((ControlBase) this.btnMoveDown).Text = "Move Down";
    this.btnMoveDown.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnSave).ImageSize = new System.Drawing.Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new System.Drawing.Point(720, 378);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new System.Drawing.Size(40, 40);
    ((Control) this.btnSave).TabIndex = 9;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.daCompanyDocs.SelectCommand = this.SqlCommand1;
    this.daCompanyDocs.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spGetCompanyAutomationDocs", new DataColumnMapping[9]
      {
        new DataColumnMapping("FolderID", "FolderID"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("TemplateID", "TemplateID"),
        new DataColumnMapping("DocumentOrder", "DocumentOrder"),
        new DataColumnMapping("AutomationReportGuid", "AutomationReportGuid"),
        new DataColumnMapping("DocumentName", "DocumentName"),
        new DataColumnMapping("DocumentType", "DocumentType"),
        new DataColumnMapping("AutomationEventGuid", "AutomationEventGuid")
      })
    });
    this.SqlCommand1.CommandText = "dbo.spGetCompanyAutomationDocs";
    this.SqlCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlCommand1.Connection = this.cnSQL;
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@EventGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@QuoteStatusReasonID", SqlDbType.SmallInt, 1)
    });
    this.cnSQL.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;user id=psarnowski;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.cmdInsert.CommandText = componentResourceManager.GetString("cmdInsert.CommandText");
    this.cmdInsert.Connection = this.cnSQL;
    this.cmdInsert.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@TemplateID", SqlDbType.Int, 4, "TemplateID"),
      new SqlParameter("@DocumentOrder", SqlDbType.TinyInt, 1, "DocumentOrder"),
      new SqlParameter("@AutomationReportGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationReportGuid"),
      new SqlParameter("@EventGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationEventGuid"),
      new SqlParameter("@FolderID", SqlDbType.Int, 4, "FolderID"),
      new SqlParameter("@QuoteStatusReasonID", SqlDbType.SmallInt, 2, "QuoteStatusReasonID")
    });
    this.Label5.AutoSize = true;
    this.Label5.Location = new System.Drawing.Point(8, 44);
    this.Label5.Name = "Label5";
    this.Label5.Size = new System.Drawing.Size(77, 13);
    this.Label5.TabIndex = 12;
    this.Label5.Text = "System Event:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnDelete).ImageSize = new System.Drawing.Size(24, 24);
    ((ControlBase) this.btnDelete).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnDelete).Location = new System.Drawing.Point(768 /*0x0300*/, 378);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new System.Drawing.Size(40, 40);
    ((Control) this.btnDelete).TabIndex = 16 /*0x10*/;
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    appearance7.ImageHAlign = (HAlign) 2;
    appearance7.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance7;
    ((ControlBase) this.btnCancel).ImageSize = new System.Drawing.Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new System.Drawing.Point(768 /*0x0300*/, 330);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new System.Drawing.Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 17;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Visible = false;
    this.lnkEmailAutomation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkEmailAutomation.AutoSize = true;
    this.lnkEmailAutomation.Location = new System.Drawing.Point(32 /*0x20*/, 458);
    this.lnkEmailAutomation.Name = "lnkEmailAutomation";
    this.lnkEmailAutomation.Size = new System.Drawing.Size(215, 13);
    this.lnkEmailAutomation.TabIndex = 20;
    this.lnkEmailAutomation.TabStop = true;
    this.lnkEmailAutomation.Text = "Click here to automate emails for this event";
    ((Control) this.UltraPictureBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.UltraPictureBox1.AutoSize = true;
    this.UltraPictureBox1.BorderShadowColor = Color.Empty;
    this.UltraPictureBox1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraPictureBox1.Image"));
    ((Control) this.UltraPictureBox1).Location = new System.Drawing.Point(8, 458);
    ((Control) this.UltraPictureBox1).Name = "UltraPictureBox1";
    ((Control) this.UltraPictureBox1).Size = new System.Drawing.Size(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.UltraPictureBox1).TabIndex = 21;
    this.lnkCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopy.AutoSize = true;
    this.lnkCopy.Location = new System.Drawing.Point(265, 458);
    this.lnkCopy.Name = "lnkCopy";
    this.lnkCopy.Size = new System.Drawing.Size(293, 13);
    this.lnkCopy.TabIndex = 22;
    this.lnkCopy.TabStop = true;
    this.lnkCopy.Text = "Copy Document Automation Event to other Company / lines";
    this.Label1.AutoSize = true;
    this.Label1.Location = new System.Drawing.Point(345, 44);
    this.Label1.Name = "Label1";
    this.Label1.Size = new System.Drawing.Size(81, 13);
    this.Label1.TabIndex = 23;
    this.Label1.Text = "Status Reason:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.ds.DataSetName = "dsDocumentAutomation";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboSystemEvents.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboSystemEvents).DataSource = (object) this.ds.lstAutomationDocumentEvents;
    ((UltraDropDownBase) this.cboSystemEvents).DisplayMember = "EventName";
    this.cboSystemEvents.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboSystemEvents).Location = new System.Drawing.Point(96 /*0x60*/, 40);
    this.cboSystemEvents.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboSystemEvents).Name = "cboSystemEvents";
    ((Control) this.cboSystemEvents).Size = new System.Drawing.Size(243, 21);
    ((Control) this.cboSystemEvents).TabIndex = 13;
    ((UltraControlBase) this.cboSystemEvents).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSystemEvents).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSystemEvents).ValueMember = "EventGuid";
    this.cboStatusReason.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboStatusReason).DataSource = (object) this.ds.lstQuoteStatusReasons;
    ((UltraDropDownBase) this.cboStatusReason).DisplayMember = "QuoteStatusReason";
    this.cboStatusReason.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatusReason).Location = new System.Drawing.Point(432, 40);
    this.cboStatusReason.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStatusReason).Name = "cboStatusReason";
    ((Control) this.cboStatusReason).Size = new System.Drawing.Size(244, 21);
    ((Control) this.cboStatusReason).TabIndex = 24;
    ((UltraControlBase) this.cboStatusReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatusReason).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStatusReason).ValueMember = "QuoteStatusReasonID";
    this.lnkClearStatusReason.AutoSize = true;
    this.lnkClearStatusReason.Location = new System.Drawing.Point(682, 44);
    this.lnkClearStatusReason.Name = "lnkClearStatusReason";
    this.lnkClearStatusReason.Size = new System.Drawing.Size(32 /*0x20*/, 13);
    this.lnkClearStatusReason.TabIndex = 25;
    this.lnkClearStatusReason.TabStop = true;
    this.lnkClearStatusReason.Text = "Clear";
    this.lnkBulkDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkBulkDelete.AutoSize = true;
    this.lnkBulkDelete.Location = new System.Drawing.Point(589, 458);
    this.lnkBulkDelete.Name = "lnkBulkDelete";
    this.lnkBulkDelete.Size = new System.Drawing.Size(171, 13);
    this.lnkBulkDelete.TabIndex = 26;
    this.lnkBulkDelete.TabStop = true;
    this.lnkBulkDelete.Text = "Delete from other Company / lines";
    this.SplitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.SplitContainer1.Location = new System.Drawing.Point(11, 79);
    this.SplitContainer1.Name = "SplitContainer1";
    this.SplitContainer1.Orientation = Orientation.Horizontal;
    this.SplitContainer1.Panel1.Controls.Add((Control) this.dgAvailable);
    this.SplitContainer1.Panel1MinSize = 100;
    this.SplitContainer1.Panel2.Controls.Add((Control) this.UltraDropDown1);
    this.SplitContainer1.Panel2.Controls.Add((Control) this.dgApplied);
    this.SplitContainer1.Panel2MinSize = 100;
    this.SplitContainer1.Size = new System.Drawing.Size(687, 339);
    this.SplitContainer1.SplitterDistance = 100;
    this.SplitContainer1.TabIndex = 28;
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.ds.tblDocumentFolders;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 89;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 12;
    ultraGridBand2.Columns.AddRange(new object[13]
    {
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
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "FolderName";
    ((Control) this.UltraDropDown1).Location = new System.Drawing.Point(409, 3);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new System.Drawing.Size(256 /*0x0100*/, 72);
    ((Control) this.UltraDropDown1).TabIndex = 19;
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "FolderID";
    ((Control) this.UltraDropDown1).Visible = false;
    ((Control) this.dgAvailable).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgAvailable).DataSource = (object) this.ds.AvailableDocuments;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 183;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 54;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Document";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn20.Width = 153;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn21.Width = 189;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridColumn22.Width = 157;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance9.FontData.UnderlineAsString = "True";
    appearance9.ForeColor = Color.Blue;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Center";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 5;
    ultraGridColumn23.Width = 169;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 6;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 67;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.dgAvailable).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgAvailable).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Navy;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAvailable).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgAvailable).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgAvailable).Location = new System.Drawing.Point(0, 0);
    ((Control) this.dgAvailable).Name = "dgAvailable";
    ((Control) this.dgAvailable).Size = new System.Drawing.Size(687, 98);
    ((Control) this.dgAvailable).TabIndex = 14;
    ((Control) this.dgAvailable).Text = "Available Documents";
    ((UltraControlBase) this.dgAvailable).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAvailable).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgApplied).DataSource = (object) this.ds.tblCompanyAutomationDocuments;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgApplied).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgApplied).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 8;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 72;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 142;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 0;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 183;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 2;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 49;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 4;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 75;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 7;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 213;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn31.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Document";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 3;
    ultraGridColumn31.Width = 156;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn32.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 6;
    ultraGridColumn32.Width = 140;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn33.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Folder";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 9;
    ultraGridColumn33.Style = (ColumnStyle) 6;
    ultraGridColumn33.Width = 78;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance18.FontData.UnderlineAsString = "True";
    appearance18.ForeColor = Color.Blue;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Center";
    ultraGridColumn34.CellAppearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 10;
    ultraGridColumn34.Width = 76;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 11;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 108;
    ultraGridColumn36.EditorComponent = (Component) this.lnkConditional;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 12;
    ultraGridColumn36.Width = 69;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 5;
    ultraGridColumn37.Width = 166;
    ultraGridBand4.Columns.AddRange(new object[13]
    {
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
      (object) ultraGridColumn37
    });
    ((UltraGridBase) this.dgApplied).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dgApplied).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = Color.LightSteelBlue;
    appearance19.FontData.SizeInPoints = 10f;
    appearance19.ForeColor = Color.Navy;
    ((UltraGridBase) this.dgApplied).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance23.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.Transparent;
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgApplied).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgApplied).Dock = DockStyle.Fill;
    ((Control) this.dgApplied).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgApplied).Location = new System.Drawing.Point(0, 0);
    ((Control) this.dgApplied).Name = "dgApplied";
    ((Control) this.dgApplied).Size = new System.Drawing.Size(687, 235);
    ((Control) this.dgApplied).TabIndex = 15;
    ((Control) this.dgApplied).Text = "Applied Documents";
    ((UltraControlBase) this.dgApplied).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgApplied).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new System.Drawing.Size(826, 480);
    this.Controls.Add((Control) this.SplitContainer1);
    this.Controls.Add((Control) this.lnkConditional);
    this.Controls.Add((Control) this.lnkBulkDelete);
    this.Controls.Add((Control) this.lnkClearStatusReason);
    this.Controls.Add((Control) this.cboStatusReason);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkCopy);
    this.Controls.Add((Control) this.UltraPictureBox1);
    this.Controls.Add((Control) this.lnkEmailAutomation);
    this.Controls.Add((Control) this.cboSystemEvents);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnMoveDown);
    this.Controls.Add((Control) this.btnMoveUp);
    this.Controls.Add((Control) this.lblCompanyLine);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmDocumentAutomation);
    this.Text = "Company Document Automation";
    ((ISupportInitialize) this.btnMoveUp).EndInit();
    ((ISupportInitialize) this.btnMoveDown).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboSystemEvents).EndInit();
    ((ISupportInitialize) this.cboStatusReason).EndInit();
    this.SplitContainer1.Panel1.ResumeLayout(false);
    this.SplitContainer1.Panel2.ResumeLayout(false);
    this.SplitContainer1.EndInit();
    this.SplitContainer1.ResumeLayout(false);
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    ((ISupportInitialize) this.dgAvailable).EndInit();
    ((ISupportInitialize) this.dgApplied).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual HyperlinkEditor _hlkAdd
  {
    get => this.__hlkAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this._hlkAdd_HyperLinkOpening);
      HyperlinkEditor hlkAdd1 = this.__hlkAdd;
      if (hlkAdd1 != null)
        hlkAdd1.HyperLinkOpening -= cancelEventHandler;
      this.__hlkAdd = value;
      HyperlinkEditor hlkAdd2 = this.__hlkAdd;
      if (hlkAdd2 == null)
        return;
      hlkAdd2.HyperLinkOpening += cancelEventHandler;
    }
  }

  private virtual HyperlinkEditor _hlkChangeFolder
  {
    get => this.__hlkChangeFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this._hlkChangeFolder_HyperLinkOpening);
      HyperlinkEditor hlkChangeFolder1 = this.__hlkChangeFolder;
      if (hlkChangeFolder1 != null)
        hlkChangeFolder1.HyperLinkOpening -= cancelEventHandler;
      this.__hlkChangeFolder = value;
      HyperlinkEditor hlkChangeFolder2 = this.__hlkChangeFolder;
      if (hlkChangeFolder2 == null)
        return;
      hlkChangeFolder2.HyperLinkOpening += cancelEventHandler;
    }
  }

  public frmDocumentAutomation(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmDocumentAutomation_Load);
    this._hlkAdd = new HyperlinkEditor();
    this._hlkChangeFolder = new HyperlinkEditor();
    this._tempAdd = -99999;
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
    this.lnkEmailAutomation.Enabled = false;
    this.lnkCopy.Enabled = false;
    this.lnkBulkDelete.Enabled = false;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public frmDocumentAutomation()
  {
    this.Load += new EventHandler(this.frmDocumentAutomation_Load);
    this._hlkAdd = new HyperlinkEditor();
    this._hlkChangeFolder = new HyperlinkEditor();
    this._tempAdd = -99999;
    this.InitializeComponent();
  }

  private bool ChangesMade
  {
    get => this._changesMade;
    set
    {
      if (!this._changesMade && value)
      {
        ((Control) this.btnCancel).Visible = true;
        ((Control) this.cboSystemEvents).Enabled = false;
      }
      else if (!value)
      {
        ((Control) this.btnCancel).Visible = false;
        ((Control) this.cboSystemEvents).Enabled = true;
      }
      this._changesMade = value;
      ((Control) this.btnSave).Enabled = this._changesMade;
      ((Control) this.btnCancel).Enabled = this._changesMade;
    }
  }

  public dsDocumentAutomation.tblCompanyAutomationDocumentsRow SelectedAppliedRow
  {
    get
    {
      return this.ds.tblCompanyAutomationDocuments.FindByID((int) ((UltraGridBase) this.dgApplied).ActiveRow.Cells["ID"].Value);
    }
  }

  private dsDocumentAutomation.AvailableDocumentsRow SelectedAvailableRow
  {
    get
    {
      return this.ds.AvailableDocuments.FindByID((int) ((UltraGridBase) this.dgAvailable).ActiveRow.Cells["ID"].Value);
    }
  }

  public Guid SelectedAutomationEventGuid
  {
    get
    {
      return !string.IsNullOrEmpty(this.cboSystemEvents.Text) ? (Guid) this.cboSystemEvents.Value : Guid.Empty;
    }
  }

  public Guid? LogIdentifier => new Guid?(new Guid("C264F669-5FD6-454A-B014-ED5A9F43B9B8"));

  private void frmDocumentAutomation_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnDelete).Appearance.Image = (object) instance.Delete;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this.cnSQL.ConnectionString = MGASystems.IMS.DocumentAutomation.Common.ConnectionString;
    this.daCompanyDocs.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
    ((ControlBase) this.lblCompanyLine).Text = new CompanyLine(this._companyLineGuid).CompanyLineState;
    this.ds.EnforceConstraints = false;
    dsDocumentAutomation.lstAutomationDocumentEventsRow row = this.ds.lstAutomationDocumentEvents.NewlstAutomationDocumentEventsRow();
    row.EventName = string.Empty;
    row.EventGuid = Guid.Empty;
    this.ds.lstAutomationDocumentEvents.AddlstAutomationDocumentEventsRow(row);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      this.ds.lstDocumentAutomationGroups.TableName,
      this.ds.lstAutomationDocumentEvents.TableName,
      this.ds.tblDocumentFolders.TableName
    }, "dbo.spCompanyDocumentAutomation");
    this.GetAutomationReports();
    this.ds.lstAutomationDocumentEvents[0].DocumentAutomationGroupID = this.ds.lstDocumentAutomationGroups[0].ID;
    this.ds.EnforceConstraints = true;
    this.cboSystemEvents.ValueChanged += new EventHandler(this.cboSystemEvents_ValueChanged);
    ((UltraGridBase) this.dgAvailable).DisplayLayout.Bands[0].Columns["Add"].Editor = (EmbeddableEditorBase) this._hlkAdd;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Bands[0].Columns["ChangeFolder"].Editor = (EmbeddableEditorBase) this._hlkChangeFolder;
    ((Control) this.cboStatusReason).Enabled = false;
    this.FormLoadOnClient();
  }

  private void GetAutomationReports()
  {
    try
    {
      foreach (Type type in Cache.AutomationReportMap.Values)
      {
        try
        {
          foreach (AutomationReportAttribute automationReportAttribute in type.GetCustomAttributes(typeof (AutomationReportAttribute), false).Cast<AutomationReportAttribute>())
          {
            if (automationReportAttribute != null && this.ds.AutomationReports.FindByAutomationReportGuid(automationReportAttribute.AutomationReportGuid) == null)
            {
              dsDocumentAutomation.AutomationReportsRow row = this.ds.AutomationReports.NewAutomationReportsRow();
              dsDocumentAutomation.AutomationReportsRow automationReportsRow = row;
              automationReportsRow.AutomationReportGuid = automationReportAttribute.AutomationReportGuid;
              automationReportsRow.Description = automationReportAttribute.Description;
              automationReportsRow.Title = automationReportAttribute.Title;
              automationReportsRow.TemplateGroupID = (int) automationReportAttribute.Group;
              this.ds.AutomationReports.AddAutomationReportsRow(row);
            }
          }
        }
        finally
        {
          IEnumerator<AutomationReportAttribute> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      Dictionary<Guid, Type>.ValueCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetAdHocAutomationDocuments");
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        dsDocumentAutomation.AutomationReportsRow row2 = this.ds.AutomationReports.NewAutomationReportsRow();
        dsDocumentAutomation.AutomationReportsRow automationReportsRow = row2;
        automationReportsRow.AutomationReportGuid = new Guid(row1["AutomationReportGuid"].ToString());
        automationReportsRow.Description = row1["Description"].ToString();
        automationReportsRow.Title = row1["Title"].ToString();
        automationReportsRow.TemplateGroupID = 3;
        this.ds.AutomationReports.AddAutomationReportsRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AddAvailableTemplateDocs(int HierarchyNumber)
  {
    this.ds.tblDocumentTemplates.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblDocumentTemplates, "dbo.spGetAvailableQuoteDocumentTemplates", new object[6]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid,
      (object) "@AutomationEventGuid",
      (object) this.SelectedAutomationEventGuid,
      (object) "@HierarchyNumber",
      (object) HierarchyNumber
    });
    try
    {
      foreach (dsDocumentAutomation.tblDocumentTemplatesRow documentTemplate in (TypedTableBase<dsDocumentAutomation.tblDocumentTemplatesRow>) this.ds.tblDocumentTemplates)
      {
        dsDocumentAutomation.AvailableDocumentsRow row = this.ds.AvailableDocuments.NewAvailableDocumentsRow();
        dsDocumentAutomation.AvailableDocumentsRow availableDocumentsRow = row;
        availableDocumentsRow.SetAutomationReportGuidNull();
        availableDocumentsRow.DocumentDescription = documentTemplate.Description;
        availableDocumentsRow.DocumentType = "User-Defined Template";
        availableDocumentsRow.DocumentName = documentTemplate.TemplateName;
        availableDocumentsRow.TemplateID = documentTemplate.TemplateID;
        this.ds.AvailableDocuments.AddAvailableDocumentsRow(row);
      }
    }
    finally
    {
      IEnumerator<dsDocumentAutomation.tblDocumentTemplatesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void DoSave()
  {
    // ISSUE: variable of a compiler-generated type
    frmDocumentAutomation._Closure\u0024__111\u002D0 closure1110_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmDocumentAutomation._Closure\u0024__111\u002D0 closure1110_2 = new frmDocumentAutomation._Closure\u0024__111\u002D0(closure1110_1);
    // ISSUE: reference to a compiler-generated field
    closure1110_2.\u0024VB\u0024Me = this;
    Cursor.Current = MgaCursors.WaitCursor;
    // ISSUE: reference to a compiler-generated field
    closure1110_2.\u0024VB\u0024Local_quoteStatusReasonID = (object) DBNull.Value;
    if (this.cboStatusReason.Value != null && !string.IsNullOrEmpty(this.cboStatusReason.Value.ToString()))
    {
      // ISSUE: reference to a compiler-generated field
      closure1110_2.\u0024VB\u0024Local_quoteStatusReasonID = RuntimeHelpers.GetObjectValue(this.cboStatusReason.Value);
    }
    // ISSUE: reference to a compiler-generated method
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure1110_2._Lambda\u0024__0));
    Cursor.Current = MgaCursors.Default;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgApplied).Rows.VisibleRowCount == 0)
      return;
    try
    {
      foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow row in this.ds.tblCompanyAutomationDocuments.Rows)
      {
        if (row.RowState != DataRowState.Deleted && row.IsDocumentNameNull())
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("Document name is empty on applied document(s).", "Cannot Continue Save - Empty Document Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DoSave();
    this.lnkEmailAutomation.Enabled = true;
    this.lnkCopy.Enabled = true;
    ((Control) this.cboStatusReason).Enabled = true;
    ((Control) this.cboSystemEvents).Enabled = true;
    this.lnkBulkDelete.Enabled = true;
    this.ResetDataAdapter();
    this.GetDocumentNames();
  }

  private void btnMoveUp_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgApplied).ActiveRow == null || this.SelectedAppliedRow.DocumentOrder == 1)
      return;
    DataRow[] dataRowArray = this.ds.tblCompanyAutomationDocuments.Select("DocumentOrder=" + (this.SelectedAppliedRow.DocumentOrder - 1).ToString());
    if (dataRowArray.Length == 0)
      return;
    ((dsDocumentAutomation.tblCompanyAutomationDocumentsRow) dataRowArray[0]).DocumentOrder = this.SelectedAppliedRow.DocumentOrder;
    dsDocumentAutomation.tblCompanyAutomationDocumentsRow selectedAppliedRow;
    int num = (selectedAppliedRow = this.SelectedAppliedRow).DocumentOrder - 1;
    selectedAppliedRow.DocumentOrder = num;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Bands[0].Columns["DocumentOrder"].SortIndicator = (SortIndicator) 1;
    this.ChangesMade = true;
  }

  private void btnMoveDown_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgApplied).ActiveRow == null || this.SelectedAppliedRow.DocumentOrder == ((UltraGridBase) this.dgApplied).Rows.Count)
      return;
    ((dsDocumentAutomation.tblCompanyAutomationDocumentsRow) this.ds.tblCompanyAutomationDocuments.Select("DocumentOrder=" + (this.SelectedAppliedRow.DocumentOrder + 1).ToString())[0]).DocumentOrder = this.SelectedAppliedRow.DocumentOrder;
    dsDocumentAutomation.tblCompanyAutomationDocumentsRow selectedAppliedRow;
    int num = (selectedAppliedRow = this.SelectedAppliedRow).DocumentOrder + 1;
    selectedAppliedRow.DocumentOrder = num;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgApplied).DisplayLayout.Bands[0].Columns["DocumentOrder"].SortIndicator = (SortIndicator) 1;
    this.ChangesMade = true;
  }

  private void AddAvailableReports()
  {
    try
    {
      foreach (dsDocumentAutomation.AutomationReportsRow automationReport in (TypedTableBase<dsDocumentAutomation.AutomationReportsRow>) this.ds.AutomationReports)
      {
        dsDocumentAutomation.AvailableDocumentsRow row = this.ds.AvailableDocuments.NewAvailableDocumentsRow();
        dsDocumentAutomation.AvailableDocumentsRow availableDocumentsRow = row;
        availableDocumentsRow.AutomationReportGuid = automationReport.AutomationReportGuid;
        availableDocumentsRow.SetTemplateIDNull();
        availableDocumentsRow.DocumentDescription = automationReport.Description;
        availableDocumentsRow.DocumentName = automationReport.Title;
        availableDocumentsRow.DocumentType = "Built-In Report";
        this.ds.AvailableDocuments.AddAvailableDocumentsRow(row);
      }
    }
    finally
    {
      IEnumerator<dsDocumentAutomation.AutomationReportsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void RefreshAvailableDocs()
  {
    this.ds.AvailableDocuments.Clear();
    this.AddAvailableTemplateDocs(this.ds.lstAutomationDocumentEvents.FindByEventGuid(this.SelectedAutomationEventGuid).lstDocumentAutomationGroupsRow.HierarchyNumber);
    this.AddAvailableReports();
  }

  private void cboSystemEvents_ValueChanged(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(this.cboSystemEvents.Text))
      return;
    this.ds.lstQuoteStatusReasons.Clear();
    this.ResetDataAdapter();
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstQuoteStatusReasons, "GetQuoteStatusReasonsFromEventGuid", new object[4]
    {
      (object) "@AutomationEventGuidFromUI",
      this.cboSystemEvents.Value,
      (object) "@LineGuid",
      (object) new CompanyLine(this._companyLineGuid).LineGuid
    });
    if (this.ds.lstQuoteStatusReasons.Count == 0)
      ((Control) this.cboStatusReason).Enabled = false;
    else
      ((Control) this.cboStatusReason).Enabled = true;
    this.lnkEmailAutomation.Enabled = this.ds.tblCompanyAutomationDocuments.Count > 0;
    this.lnkCopy.Enabled = this.ds.tblCompanyAutomationDocuments.Count > 0;
    this.lnkBulkDelete.Enabled = this.ds.tblCompanyAutomationDocuments.Count > 0;
    if (frmDocumentAutomation.IsQuoteLevelMessage(this.SelectedAutomationEventGuid))
      ((UltraGridBase) this.dgApplied).DisplayLayout.Bands[0].Columns["ChangeFolder"].Editor = (EmbeddableEditorBase) this._hlkChangeFolder;
    else
      ((UltraGridBase) this.dgApplied).DisplayLayout.Bands[0].Columns["ChangeFolder"].Editor = (EmbeddableEditorBase) null;
    this.RefreshAvailableDocs();
    this.GetDocumentNames();
    this.SystemEventsValueChanged(RuntimeHelpers.GetObjectValue(sender), e);
    this.ds.tblCompanyAutomationDocuments.AcceptChanges();
  }

  private void AddAppliedReports()
  {
  }

  private void cboStatusReason_ValueChanged(object sender, EventArgs e)
  {
    this.ResetDataAdapter();
    this.GetDocumentNames();
  }

  private void ResetDataAdapter()
  {
    this.ds.tblCompanyAutomationDocuments.Clear();
    this.daCompanyDocs.SelectCommand.Parameters["@EventGuid"].Value = (object) this.SelectedAutomationEventGuid;
    this.daCompanyDocs.SelectCommand.Parameters["@QuoteStatusReasonID"].Value = string.IsNullOrEmpty(this.cboStatusReason.Text) ? (object) DBNull.Value : RuntimeHelpers.GetObjectValue(this.cboStatusReason.Value);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyDocs, (DataTable) this.ds.tblCompanyAutomationDocuments);
  }

  private void GetDocumentNames()
  {
    try
    {
      foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocument in (TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>) this.ds.tblCompanyAutomationDocuments)
      {
        if (!automationDocument.IsAutomationReportGuidNull())
        {
          if (this.ds.AutomationReports.FindByAutomationReportGuid(automationDocument.AutomationReportGuid) == null)
            throw new InvalidOperationException("Missing AutomationReport represented by the Guid " + automationDocument.AutomationReportGuid.ToString());
          automationDocument.DocumentName = this.ds.AutomationReports.FindByAutomationReportGuid(automationDocument.AutomationReportGuid).Title;
        }
      }
    }
    finally
    {
      IEnumerator<dsDocumentAutomation.tblCompanyAutomationDocumentsRow> enumerator;
      enumerator?.Dispose();
    }
    this.GetDocumentDescription();
  }

  private void GetDocumentDescription()
  {
    try
    {
      foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocument in (TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>) this.ds.tblCompanyAutomationDocuments)
      {
        if (!automationDocument.IsTemplateIDNull() && this.ds.tblDocumentTemplates.FindByTemplateID(automationDocument.TemplateID) != null)
          automationDocument.DocumentDescription = this.ds.tblDocumentTemplates.FindByTemplateID(automationDocument.TemplateID).Description;
      }
    }
    finally
    {
      IEnumerator<dsDocumentAutomation.tblCompanyAutomationDocumentsRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocument in (TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>) this.ds.tblCompanyAutomationDocuments)
      {
        if (!automationDocument.IsAutomationReportGuidNull())
        {
          if (this.ds.AutomationReports.FindByAutomationReportGuid(automationDocument.AutomationReportGuid) == null)
            throw new InvalidOperationException("Missing AutomationReport represented by the Guid " + automationDocument.AutomationReportGuid.ToString());
          automationDocument.DocumentName = this.ds.AutomationReports.FindByAutomationReportGuid(automationDocument.AutomationReportGuid).Title;
          automationDocument.DocumentDescription = this.ds.AutomationReports.FindByAutomationReportGuid(automationDocument.AutomationReportGuid).Description;
        }
      }
    }
    finally
    {
      IEnumerator<dsDocumentAutomation.tblCompanyAutomationDocumentsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void lnkClearStatusReason_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.cboStatusReason.Text = string.Empty;
  }

  private void lnkEmailAutomation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (frmEmailAutomation), (object) this._companyLineGuid, (object) this.SelectedAutomationEventGuid).Dispose();
  }

  private static bool IsQuoteLevelMessage(Guid broadcastMessage)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT AG.HierarchyNumber FROM lstDocumentAutomationGroups AG INNER JOIN lstAutomationDocumentEvents DE ON AG.ID = DE.DocumentAutomationGroupID WHERE DE.EventGuid=@EG", new object[2]
    {
      (object) "@EG",
      (object) broadcastMessage
    }));
    return Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) && Conversions.ToInteger(objectValue) == 3;
  }

  private void _hlkAdd_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgAvailable).ActiveRow == null)
      return;
    e.Cancel = true;
    if (this.ds.tblCompanyAutomationDocuments.Select($"{(this.SelectedAvailableRow.IsAutomationReportGuidNull() ? (object) "TemplateID" : (object) "AutomationReportGuid")} = {(this.SelectedAvailableRow.IsAutomationReportGuidNull() ? (object) this.SelectedAvailableRow.TemplateID.ToString() : (object) $"'{this.SelectedAvailableRow.AutomationReportGuid.ToString()}'")}").Length > 0)
      return;
    dsDocumentAutomation.tblCompanyAutomationDocumentsRow row = this.ds.tblCompanyAutomationDocuments.NewtblCompanyAutomationDocumentsRow();
    dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocumentsRow = row;
    automationDocumentsRow.AutomationEventGuid = this.SelectedAutomationEventGuid;
    if (this.SelectedAvailableRow.IsAutomationReportGuidNull())
    {
      automationDocumentsRow.SetAutomationReportGuidNull();
      automationDocumentsRow.TemplateID = this.SelectedAvailableRow.TemplateID;
      automationDocumentsRow.DocumentType = "User-Defined Template";
    }
    else
    {
      automationDocumentsRow.SetTemplateIDNull();
      automationDocumentsRow.AutomationReportGuid = this.SelectedAvailableRow.AutomationReportGuid;
      automationDocumentsRow.DocumentType = "Built-In Report";
    }
    automationDocumentsRow.CompanyLineGuid = this._companyLineGuid;
    automationDocumentsRow.DocumentName = this.SelectedAvailableRow.DocumentName;
    automationDocumentsRow.DocumentDescription = this.SelectedAvailableRow.DocumentDescription;
    automationDocumentsRow.DocumentOrder = Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(this.ds.tblCompanyAutomationDocuments.Compute("MAX(DocumentOrder)", string.Empty)), this.ds.tblCompanyAutomationDocuments.Count) + 1;
    if (this.cboStatusReason.Value != null)
      row.QuoteStatusReasonID = (short) this.cboStatusReason.Value;
    try
    {
      foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocument in (TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>) this.ds.tblCompanyAutomationDocuments)
      {
        if (!automationDocument.IsFolderIDNull())
        {
          row.FolderID = automationDocument.FolderID;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<dsDocumentAutomation.tblCompanyAutomationDocumentsRow> enumerator;
      enumerator?.Dispose();
    }
    row.ID = this._tempAdd;
    this.ds.tblCompanyAutomationDocuments.AddtblCompanyAutomationDocumentsRow(row);
    ((Control) this.cboStatusReason).Enabled = false;
    this.ChangesMade = true;
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this._tempAdd) + 1;
    local = num;
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgApplied).ActiveRow == null)
      return;
    DataTable changes = this.ds.tblCompanyAutomationDocuments.GetChanges(DataRowState.Added);
    if ((changes != null ? (changes.Rows.Count > 0 ? 1 : 0) : 0) != 0 && System.Windows.Forms.MessageBox.Show("Applied documents were added. \n\nContinue and save documents?", "Continue And Save Document(s)?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      this.DoSave();
    if (System.Windows.Forms.MessageBox.Show("Are you sure you want to remove the following automation document?\n\n" + this.SelectedAppliedRow.DocumentName, "Remove Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblCompanyAutomationDocuments WHERE ID=@ID", new object[2]
    {
      (object) "@ID",
      (object) this.SelectedAppliedRow.ID
    });
    this.DeleteOnClient();
    int documentOrder = this.SelectedAppliedRow.DocumentOrder;
    this.ds.tblCompanyAutomationDocuments.RemovetblCompanyAutomationDocumentsRow(this.SelectedAppliedRow);
    this.ds.tblCompanyAutomationDocuments.AcceptChanges();
    dsDocumentAutomation.tblCompanyAutomationDocumentsRow[] automationDocumentsRowArray1 = (dsDocumentAutomation.tblCompanyAutomationDocumentsRow[]) this.ds.tblCompanyAutomationDocuments.Select($"DocumentOrder > {documentOrder}");
    dsDocumentAutomation.tblCompanyAutomationDocumentsRow[] automationDocumentsRowArray2 = automationDocumentsRowArray1;
    int index = 0;
    while (index < automationDocumentsRowArray2.Length)
    {
      dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocumentsRow;
      int num = (automationDocumentsRow = automationDocumentsRowArray2[index]).DocumentOrder - 1;
      automationDocumentsRow.DocumentOrder = num;
      checked { ++index; }
    }
    this.ChangesMade = automationDocumentsRowArray1.Length > 0;
    this.lnkEmailAutomation.Enabled = this.ds.tblCompanyAutomationDocuments.Count > 0;
    this.lnkCopy.Enabled = this.ds.tblCompanyAutomationDocuments.Count > 0;
    this.lnkBulkDelete.Enabled = this.ds.tblCompanyAutomationDocuments.Count > 0;
    this.RefreshAvailableDocs();
    this.GetDocumentNames();
    Cursor.Current = MgaCursors.Default;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.ds.tblCompanyAutomationDocuments.RejectChanges();
    this.ChangesMade = false;
    this.ResetDataAdapter();
    this.GetDocumentNames();
    ((Control) this.cboStatusReason).Enabled = true;
    ((Control) this.cboSystemEvents).Enabled = true;
  }

  private void _hlkChangeFolder_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    frmSelectDocumentFolder selectDocumentFolder = (frmSelectDocumentFolder) FormSettings.ShowFormDialog(typeof (frmSelectDocumentFolder), (object) this.ds.tblDocumentFolders);
    try
    {
      if (selectDocumentFolder.FolderSelected)
      {
        try
        {
          foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocument in (TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>) this.ds.tblCompanyAutomationDocuments)
            automationDocument.FolderID = selectDocumentFolder.FolderID;
        }
        finally
        {
          IEnumerator<dsDocumentAutomation.tblCompanyAutomationDocumentsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      else
      {
        try
        {
          foreach (dsDocumentAutomation.tblCompanyAutomationDocumentsRow automationDocument in (TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>) this.ds.tblCompanyAutomationDocuments)
            automationDocument.SetFolderIDNull();
        }
        finally
        {
          IEnumerator<dsDocumentAutomation.tblCompanyAutomationDocumentsRow> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      selectDocumentFolder.Dispose();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._hlkAdd != null)
        ((DisposableObject) this._hlkAdd).Dispose();
      if (this._hlkChangeFolder != null)
        ((DisposableObject) this._hlkChangeFolder).Dispose();
    }
    base.Dispose(disposing);
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (string.IsNullOrEmpty(this.cboSystemEvents.Text))
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("Cannot copy document setup to other company / lines because no System Event is selected.", "No System Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((UltraGridBase) this.dgApplied).ActiveRow == null)
        return;
      int num2 = int.MinValue;
      if (this.cboStatusReason.Value != null && this.cboStatusReason.Value != DBNull.Value)
        num2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboStatusReason.Value));
      if (this.SelectedAppliedRow.IsAutomationReportGuidNull())
        FormSettings.ShowFormDialog(typeof (FormCopyDocumentAutomationSetup), (object) this.SelectedAppliedRow.ID, (object) this._companyLineGuid, (object) (Guid) this.cboSystemEvents.Value, (object) this.SelectedAppliedRow.TemplateID, (object) num2);
      else
        FormSettings.ShowFormDialog(typeof (FormCopyDocumentAutomationSetup), (object) this.SelectedAppliedRow.ID, (object) this._companyLineGuid, (object) (Guid) this.cboSystemEvents.Value, (object) this.SelectedAppliedRow.AutomationReportGuid, (object) num2);
    }
  }

  private void lnkBulkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (string.IsNullOrEmpty(this.cboSystemEvents.Text))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("No selected Company/Lines System Event.", "No Selected Event", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((UltraGridBase) this.dgApplied).ActiveRow == null)
        return;
      if (System.Windows.Forms.MessageBox.Show("Remove the following automation document having similar location/line with differing states?\n\n" + this.SelectedAppliedRow.DocumentName, "Remove Document from Other Company/Line?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        return;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        DefaultDatabase.ExecuteNonQuery("spBuildAutomationDocumentDelete", new object[2]
        {
          (object) "@CurrentID",
          (object) this.SelectedAppliedRow.ID
        });
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void lnkConditional_LinkClicked(object sender, LinkClickedEventArgs e)
  {
    DocAutomationConditionalViewModel conditionalViewModel = DocAutomationConditionalViewModel.Create(new int?(this.SelectedAppliedRow.IsTemplateIDNull() ? 0 : this.SelectedAppliedRow.TemplateID), this.SelectedAppliedRow.ID, new int?(this.ds.lstAutomationDocumentEvents[0].DocumentAutomationGroupID), this._companyLineGuid, (Guid) this.cboSystemEvents.Value);
    DocAutomationConditional automationConditional = MgaMdiChild.Create<DocAutomationConditional>(new object[0]);
    ((FrameworkElement) automationConditional).DataContext = (object) conditionalViewModel;
    int num = (int) automationConditional.Form.ShowDialog();
    this.ResetDataAdapter();
    this.GetDocumentNames();
  }

  protected virtual void FormLoadOnClient()
  {
  }

  protected virtual void DoSaveOnClient()
  {
  }

  protected virtual void DeleteOnClient()
  {
  }

  protected virtual void SystemEventsValueChanged(object sender, EventArgs e)
  {
  }

  public sealed class FixedUltraGrid : UltraGrid
  {
    protected override void OnPaint(PaintEventArgs pe)
    {
      try
      {
        base.OnPaint(pe);
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
