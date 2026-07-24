// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmClientLocations
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Common.LogonServer;
using MGASystems.Data;
using MGASystems.IMS.Forms.Users;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DocumentFolderFilter("Client Location Administration")]
public sealed class frmClientLocations : MGABaseForm, ISupportDocumentSystem
{
  private IContainer components;
  private SqlDataAdapter daClientLocs;
  private Label Label6;
  private Label lblPhone;
  private Label lblUserName;
  private Label Label3;
  private MGATextBox txtOfficeName;
  private dsClientLocs dsClientLocs;
  private UltraGroupBox GroupBox2;
  private UltraLabel lblRecords;
  private ToolTip Tip;
  private MGASimpleComboBox cboStatus;
  private Label Label1;
  private MGAMaskedEdit txtFax;
  private MGAMaskedEdit txtPhone;
  private ErrorProvider err;
  private UltraToolbarsDockArea _frmClientLocations_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmClientLocations_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmClientLocations_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmClientLocations_Toolbars_Dock_Area_Bottom;
  private MGANumericEditor numNextInvoiceNumber;
  private Label lblNextInvoice;
  private MGAMaskedEdit txtFEIN;
  public const string canOpenOfficeLocations = "{D2E7E2E3-0BD9-4387-A31F-197B01829CFD}";
  private Guid? _initializeToClientLocationGuid;
  private List<Guid> changedOfficeImages;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAListBox lstUser
  {
    get => this._lstUser;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectUser);
      MGAListBox lstUser1 = this._lstUser;
      if (lstUser1 != null)
        lstUser1.DoubleClick -= eventHandler;
      this._lstUser = value;
      MGAListBox lstUser2 = this._lstUser;
      if (lstUser2 == null)
        return;
      lstUser2.DoubleClick += eventHandler;
    }
  }

  private virtual MGAButton btnSelectUser
  {
    get => this._btnSelectUser;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectUser);
      MGAButton btnSelectUser1 = this._btnSelectUser;
      if (btnSelectUser1 != null)
        ((Control) btnSelectUser1).Click -= eventHandler;
      this._btnSelectUser = value;
      MGAButton btnSelectUser2 = this._btnSelectUser;
      if (btnSelectUser2 == null)
        return;
      ((Control) btnSelectUser2).Click += eventHandler;
    }
  }

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

  private virtual MGAButton btnNewUser
  {
    get => this._btnNewUser;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewUser_Click);
      MGAButton btnNewUser1 = this._btnNewUser;
      if (btnNewUser1 != null)
        ((Control) btnNewUser1).Click -= eventHandler;
      this._btnNewUser = value;
      MGAButton btnNewUser2 = this._btnNewUser;
      if (btnNewUser2 == null)
        return;
      ((Control) btnNewUser2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gbLocation")]
  private virtual UltraGroupBox gbLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraToolbarsManager UltraToolbarsManager1
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

  private virtual MGACheckBox chkAccountingOffice
  {
    get => this._chkAccountingOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkAccountingOffice_CheckStateChanged);
      MGACheckBox accountingOffice1 = this._chkAccountingOffice;
      if (accountingOffice1 != null)
        ((UltraToggleEditorBase) accountingOffice1).CheckStateChanged -= eventHandler;
      this._chkAccountingOffice = value;
      MGACheckBox accountingOffice2 = this._chkAccountingOffice;
      if (accountingOffice2 == null)
        return;
      ((UltraToggleEditorBase) accountingOffice2).CheckStateChanged += eventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickedNew -= eventHandler2;
        dbSave1.UIStateChanged -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickedNew += eventHandler2;
      dbSave2.UIStateChanged += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboParentOffices")]
  internal virtual MGASimpleComboBox cboParentOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDBA")]
  internal virtual MGATextBox txtDBA { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("pbLogo")]
  internal virtual PictureBox pbLogo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLoadingImage")]
  internal virtual Label lblLoadingImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("AddressChecker1")]
  internal virtual AddressChecker AddressChecker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("zipRes")]
  internal virtual AddressResolver_MULTI zipRes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEmail")]
  internal virtual MGATextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumSortOrder")]
  private virtual MGANumericEditor MgaNumSortOrder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSortOrderNum")]
  private virtual Label lblSortOrderNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("utLogos")]
  internal virtual UltraTabControl utLogos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  internal virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pbWatermark")]
  internal virtual PictureBox pbWatermark { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAltNumbers
  {
    get => this._lnkAltNumbers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAltNumbers_LinkClicked);
      LinkLabel lnkAltNumbers1 = this._lnkAltNumbers;
      if (lnkAltNumbers1 != null)
        lnkAltNumbers1.LinkClicked -= clickedEventHandler;
      this._lnkAltNumbers = value;
      LinkLabel lnkAltNumbers2 = this._lnkAltNumbers;
      if (lnkAltNumbers2 == null)
        return;
      lnkAltNumbers2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmClientLocations));
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
    UltraToolbar ultraToolbar = new UltraToolbar("Client Locations");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Client Locations");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Client Locations");
    ButtonTool buttonTool1 = new ButtonTool("Manage Company Lines");
    ButtonTool buttonTool2 = new ButtonTool("Licenses...");
    ButtonTool buttonTool3 = new ButtonTool("Manage Company Lines");
    ButtonTool buttonTool4 = new ButtonTool("Licenses...");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraTab ultraTab1 = new UltraTab(true);
    UltraTab ultraTab2 = new UltraTab();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lblLoadingImage = new Label();
    this.pbLogo = new PictureBox();
    this.btnNewImage = new MGAButton();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.pbWatermark = new PictureBox();
    this.daClientLocs = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.Label6 = new Label();
    this.lblPhone = new Label();
    this.txtOfficeName = new MGATextBox();
    this.dsClientLocs = new dsClientLocs();
    this.lblUserName = new Label();
    this.Label3 = new Label();
    this.gbLocation = new UltraGroupBox();
    this.MgaNumSortOrder = new MGANumericEditor();
    this.lblSortOrderNum = new Label();
    this.Label5 = new Label();
    this.txtEmail = new MGATextBox();
    this.zipRes = new AddressResolver_MULTI();
    this.lnkAltNumbers = new LinkLabel();
    this.Label4 = new Label();
    this.txtDBA = new MGATextBox();
    this.Label2 = new Label();
    this.cboParentOffices = new MGASimpleComboBox();
    this.txtFEIN = new MGAMaskedEdit();
    this.chkAccountingOffice = new MGACheckBox();
    this.numNextInvoiceNumber = new MGANumericEditor();
    this.txtFax = new MGAMaskedEdit();
    this.txtPhone = new MGAMaskedEdit();
    this.Label1 = new Label();
    this.cboStatus = new MGASimpleComboBox();
    this.lblNextInvoice = new Label();
    this.btnSelectUser = new MGAButton();
    this.GroupBox2 = new UltraGroupBox();
    this.btnNewUser = new MGAButton();
    this.lstUser = new MGAListBox();
    this.btnPrev = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnLast = new MGAButton();
    this.btnFirst = new MGAButton();
    this.lblRecords = new UltraLabel();
    this.Tip = new ToolTip(this.components);
    this.err = new ErrorProvider(this.components);
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmClientLocations_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmClientLocations_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmClientLocations_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmClientLocations_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.utLogos = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.pbLogo).BeginInit();
    ((ISupportInitialize) this.btnNewImage).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.pbWatermark).BeginInit();
    ((ISupportInitialize) this.txtOfficeName).BeginInit();
    this.dsClientLocs.BeginInit();
    ((ISupportInitialize) this.gbLocation).BeginInit();
    ((Control) this.gbLocation).SuspendLayout();
    ((ISupportInitialize) this.MgaNumSortOrder).BeginInit();
    ((ISupportInitialize) this.txtEmail).BeginInit();
    ((ISupportInitialize) this.txtDBA).BeginInit();
    ((ISupportInitialize) this.cboParentOffices).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.chkAccountingOffice).BeginInit();
    ((ISupportInitialize) this.numNextInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.txtFax).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.cboStatus).BeginInit();
    ((ISupportInitialize) this.btnSelectUser).BeginInit();
    ((ISupportInitialize) this.GroupBox2).BeginInit();
    ((Control) this.GroupBox2).SuspendLayout();
    ((ISupportInitialize) this.btnNewUser).BeginInit();
    ((ISupportInitialize) this.lstUser).BeginInit();
    ((ISupportInitialize) this.btnPrev).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnLast).BeginInit();
    ((ISupportInitialize) this.btnFirst).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.utLogos).BeginInit();
    ((Control) this.utLogos).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.pbLogo);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblLoadingImage);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnNewImage);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 22);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(185, 169);
    this.lblLoadingImage.AutoSize = true;
    this.lblLoadingImage.Location = new Point(64 /*0x40*/, 33);
    this.lblLoadingImage.Name = "lblLoadingImage";
    this.lblLoadingImage.Size = new Size(56, 13);
    this.lblLoadingImage.TabIndex = 4;
    this.lblLoadingImage.Text = "Loading...";
    this.lblLoadingImage.Visible = false;
    this.pbLogo.Location = new Point(6, 6);
    this.pbLogo.Name = "pbLogo";
    this.pbLogo.Size = new Size(173, 91);
    this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbLogo.TabIndex = 3;
    this.pbLogo.TabStop = false;
    ((Control) this.btnNewImage).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewImage).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnNewImage).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewImage).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewImage).Location = new Point(142, (int) sbyte.MaxValue);
    ((Control) this.btnNewImage).Name = "btnNewImage";
    ((Control) this.btnNewImage).Size = new Size(40, 40);
    ((Control) this.btnNewImage).TabIndex = 2;
    this.Tip.SetToolTip((Control) this.btnNewImage, "Update Office Logo");
    this.btnNewImage.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.pbWatermark);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(185, 169);
    this.pbWatermark.Location = new Point(6, 6);
    this.pbWatermark.Name = "pbWatermark";
    this.pbWatermark.Size = new Size(173, 91);
    this.pbWatermark.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbWatermark.TabIndex = 5;
    this.pbWatermark.TabStop = false;
    this.daClientLocs.DeleteCommand = this.SqlDeleteCommand1;
    this.daClientLocs.InsertCommand = this.SqlInsertCommand1;
    this.daClientLocs.SelectCommand = this.SqlSelectCommand1;
    this.daClientLocs.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblClientOffices", new DataColumnMapping[21]
      {
        new DataColumnMapping("OfficeGUID", "OfficeGUID"),
        new DataColumnMapping("Location", "Location"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("NextInvoiceNum", "NextInvoiceNum"),
        new DataColumnMapping("AccountingOffice", "AccountingOffice"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("ParentOfficeGuid", "ParentOfficeGuid"),
        new DataColumnMapping("DBA", "DBA"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("SortOrder", "SortOrder")
      })
    });
    this.daClientLocs.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[33]
    {
      new SqlParameter("@Original_OfficeGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Location", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Location", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_State", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FEIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_FEIN", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NextInvoiceNum", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NextInvoiceNum", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NextInvoiceNum", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NextInvoiceNum", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AccountingOffice", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AccountingOffice", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ParentOfficeGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ParentOfficeGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ParentOfficeGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ParentOfficeGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_DBA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DBA", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_DBA", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DBA", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_SortOrder", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SortOrder", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_SortOrder", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SortOrder", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[21]
    {
      new SqlParameter("@OfficeGUID", SqlDbType.UniqueIdentifier, 0, "OfficeGUID"),
      new SqlParameter("@Location", SqlDbType.VarChar, 0, "Location"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.Char, 0, "State"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@FEIN", SqlDbType.VarChar, 0, "FEIN"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@NextInvoiceNum", SqlDbType.Int, 0, "NextInvoiceNum"),
      new SqlParameter("@AccountingOffice", SqlDbType.Bit, 0, "AccountingOffice"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@ParentOfficeGuid", SqlDbType.UniqueIdentifier, 0, "ParentOfficeGuid"),
      new SqlParameter("@DBA", SqlDbType.VarChar, 0, "DBA"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@SortOrder", SqlDbType.TinyInt, 0, "SortOrder")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[54]
    {
      new SqlParameter("@OfficeGUID", SqlDbType.UniqueIdentifier, 0, "OfficeGUID"),
      new SqlParameter("@Location", SqlDbType.VarChar, 0, "Location"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@State", SqlDbType.Char, 0, "State"),
      new SqlParameter("@Phone", SqlDbType.VarChar, 0, "Phone"),
      new SqlParameter("@Fax", SqlDbType.VarChar, 0, "Fax"),
      new SqlParameter("@FEIN", SqlDbType.VarChar, 0, "FEIN"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@StatusID", SqlDbType.TinyInt, 0, "StatusID"),
      new SqlParameter("@NextInvoiceNum", SqlDbType.Int, 0, "NextInvoiceNum"),
      new SqlParameter("@AccountingOffice", SqlDbType.Bit, 0, "AccountingOffice"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@ParentOfficeGuid", SqlDbType.UniqueIdentifier, 0, "ParentOfficeGuid"),
      new SqlParameter("@DBA", SqlDbType.VarChar, 0, "DBA"),
      new SqlParameter("@Email", SqlDbType.VarChar, 0, "Email"),
      new SqlParameter("@SortOrder", SqlDbType.TinyInt, 0, "SortOrder"),
      new SqlParameter("@Original_OfficeGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Location", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Location", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_State", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "State", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Phone", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Phone", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Fax", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Fax", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Fax", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_FEIN", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_FEIN", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FEIN", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StatusID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StatusID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_NextInvoiceNum", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NextInvoiceNum", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_NextInvoiceNum", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NextInvoiceNum", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AccountingOffice", SqlDbType.Bit, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AccountingOffice", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ParentOfficeGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ParentOfficeGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ParentOfficeGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ParentOfficeGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_DBA", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DBA", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_DBA", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DBA", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Email", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_SortOrder", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "SortOrder", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_SortOrder", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SortOrder", DataRowVersion.Original, (object) null)
    });
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(43, 241);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(43, 16 /*0x10*/);
    this.Label6.TabIndex = 116;
    this.Label6.Text = "Fax:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.lblPhone.BackColor = Color.Transparent;
    this.lblPhone.Location = new Point(41, 213);
    this.lblPhone.Name = "lblPhone";
    this.lblPhone.Size = new Size(45, 16 /*0x10*/);
    this.lblPhone.TabIndex = 115;
    this.lblPhone.Text = "Phone:";
    this.lblPhone.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtOfficeName).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtOfficeName).BackColor = Color.White;
    ((Control) this.txtOfficeName).DataBindings.Add(new Binding("Text", (object) this.dsClientLocs, "tblClientOffices.Location", true));
    ((Control) this.txtOfficeName).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtOfficeName).Location = new Point(86, 20);
    ((Control) this.txtOfficeName).Name = "txtOfficeName";
    ((Control) this.txtOfficeName).Size = new Size(261, 20);
    ((Control) this.txtOfficeName).TabIndex = 0;
    ((UltraControlBase) this.txtOfficeName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtOfficeName).UseOsThemes = (DefaultableBoolean) 2;
    this.dsClientLocs.DataSetName = "dsClientLocs";
    this.dsClientLocs.Locale = new CultureInfo("en-US");
    this.dsClientLocs.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblUserName.BackColor = Color.Transparent;
    this.lblUserName.Location = new Point(11, 18);
    this.lblUserName.Name = "lblUserName";
    this.lblUserName.Size = new Size(72, 23);
    this.lblUserName.TabIndex = 119;
    this.lblUserName.Text = "Office Name:";
    this.lblUserName.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(48 /*0x30*/, 292);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(35, 16 /*0x10*/);
    this.Label3.TabIndex = 123;
    this.Label3.Text = "FEIN:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.Transparent;
    this.gbLocation.Appearance = (AppearanceBase) appearance3;
    ((Control) this.gbLocation).Controls.Add((Control) this.MgaNumSortOrder);
    ((Control) this.gbLocation).Controls.Add((Control) this.lblSortOrderNum);
    ((Control) this.gbLocation).Controls.Add((Control) this.Label5);
    ((Control) this.gbLocation).Controls.Add((Control) this.txtEmail);
    ((Control) this.gbLocation).Controls.Add((Control) this.zipRes);
    ((Control) this.gbLocation).Controls.Add((Control) this.lnkAltNumbers);
    ((Control) this.gbLocation).Controls.Add((Control) this.Label4);
    ((Control) this.gbLocation).Controls.Add((Control) this.txtDBA);
    ((Control) this.gbLocation).Controls.Add((Control) this.Label2);
    ((Control) this.gbLocation).Controls.Add((Control) this.cboParentOffices);
    ((Control) this.gbLocation).Controls.Add((Control) this.txtFEIN);
    ((Control) this.gbLocation).Controls.Add((Control) this.chkAccountingOffice);
    ((Control) this.gbLocation).Controls.Add((Control) this.numNextInvoiceNumber);
    ((Control) this.gbLocation).Controls.Add((Control) this.txtFax);
    ((Control) this.gbLocation).Controls.Add((Control) this.txtPhone);
    ((Control) this.gbLocation).Controls.Add((Control) this.Label1);
    ((Control) this.gbLocation).Controls.Add((Control) this.cboStatus);
    ((Control) this.gbLocation).Controls.Add((Control) this.txtOfficeName);
    ((Control) this.gbLocation).Controls.Add((Control) this.Label3);
    ((Control) this.gbLocation).Controls.Add((Control) this.lblPhone);
    ((Control) this.gbLocation).Controls.Add((Control) this.lblUserName);
    ((Control) this.gbLocation).Controls.Add((Control) this.Label6);
    ((Control) this.gbLocation).Controls.Add((Control) this.lblNextInvoice);
    ((Control) this.gbLocation).Enabled = false;
    ((Control) this.gbLocation).Location = new Point(8, 8);
    ((Control) this.gbLocation).Name = "gbLocation";
    ((Control) this.gbLocation).Size = new Size(353, 453);
    ((Control) this.gbLocation).TabIndex = 0;
    this.gbLocation.Text = "Office Locations";
    appearance4.BackColorDisabled = Color.Gainsboro;
    appearance4.BorderColor = Color.Gray;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraNumericEditorBase) this.MgaNumSortOrder).Appearance = (AppearanceBase) appearance4;
    ((Control) this.MgaNumSortOrder).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.SortOrder", true));
    ((Control) this.MgaNumSortOrder).Location = new Point(270, 293);
    ((UltraNumericEditorBase) this.MgaNumSortOrder).MaskDisplayMode = (MaskMode) 0;
    this.MgaNumSortOrder.MaxValue = (object) (int) byte.MaxValue;
    this.MgaNumSortOrder.MinValue = (object) 1;
    ((Control) this.MgaNumSortOrder).Name = "MgaNumSortOrder";
    this.MgaNumSortOrder.Nullable = true;
    ((Control) this.MgaNumSortOrder).Size = new Size(62, 20);
    ((Control) this.MgaNumSortOrder).TabIndex = 156;
    ((UltraControlBase) this.MgaNumSortOrder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumSortOrder).UseOsThemes = (DefaultableBoolean) 2;
    this.lblSortOrderNum.BackColor = Color.Transparent;
    this.lblSortOrderNum.Location = new Point(177, 295);
    this.lblSortOrderNum.Name = "lblSortOrderNum";
    this.lblSortOrderNum.Size = new Size(87, 16 /*0x10*/);
    this.lblSortOrderNum.TabIndex = 157;
    this.lblSortOrderNum.Text = "Sort Order #:";
    this.lblSortOrderNum.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(48 /*0x30*/, 432);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(35, 13);
    this.Label5.TabIndex = 155;
    this.Label5.Text = "Email:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEmail).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtEmail).BackColor = Color.White;
    ((Control) this.txtEmail).DataBindings.Add(new Binding("Text", (object) this.dsClientLocs, "tblClientOffices.Email", true));
    ((Control) this.txtEmail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtEmail).Location = new Point(89, 428);
    ((TextEditorControlBase) this.txtEmail).MaxLength = 50;
    ((Control) this.txtEmail).Name = "txtEmail";
    ((Control) this.txtEmail).Size = new Size(258, 20);
    ((Control) this.txtEmail).TabIndex = 11;
    ((UltraControlBase) this.txtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.zipRes.Address1 = "";
    this.zipRes.Address2 = "";
    this.zipRes.City = "";
    this.zipRes.County = "";
    ((Control) this.zipRes).Font = new Font("Tahoma", 8f);
    this.zipRes.ISOCountryCode = "";
    this.zipRes.ISOCountryCodeMember = "";
    this.zipRes.ISOCountryList = (object) null;
    this.zipRes.ISOCountryNameMember = "";
    ((Control) this.zipRes).Location = new Point(14, 50);
    this.zipRes.MGAStyle = MGAStyles.None;
    ((Control) this.zipRes).Name = "zipRes";
    this.zipRes.Password = (string) null;
    ((Control) this.zipRes).Size = new Size(250, 155);
    this.zipRes.State = "";
    ((Control) this.zipRes).TabIndex = 153;
    this.zipRes.UserID = (string) null;
    this.zipRes.WebserviceUrl = (string) null;
    this.zipRes.ZipCode = "";
    this.zipRes.ZipCodeExtension = "";
    this.lnkAltNumbers.BackColor = Color.Transparent;
    this.lnkAltNumbers.Location = new Point(88, 267);
    this.lnkAltNumbers.Name = "lnkAltNumbers";
    this.lnkAltNumbers.Size = new Size(176 /*0xB0*/, 16 /*0x10*/);
    this.lnkAltNumbers.TabIndex = 4;
    this.lnkAltNumbers.TabStop = true;
    this.lnkAltNumbers.Text = "Add Alternate Phone/Fax Numbers";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(52, 405);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(31 /*0x1F*/, 13);
    this.Label4.TabIndex = 152;
    this.Label4.Text = "DBA:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDBA).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtDBA).BackColor = Color.White;
    ((Control) this.txtDBA).DataBindings.Add(new Binding("Text", (object) this.dsClientLocs, "tblClientOffices.DBA", true));
    ((Control) this.txtDBA).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtDBA).Location = new Point(89, 401);
    ((Control) this.txtDBA).Name = "txtDBA";
    ((Control) this.txtDBA).Size = new Size(258, 20);
    ((Control) this.txtDBA).TabIndex = 10;
    ((UltraControlBase) this.txtDBA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDBA).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 377);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(75, 13);
    this.Label2.TabIndex = 150;
    this.Label2.Text = "Parent Office:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboParentOffices).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.ParentOfficeGuid", true));
    ((UltraGridBase) this.cboParentOffices).DataSource = (object) this.dsClientLocs.ParentOffices;
    ((UltraDropDownBase) this.cboParentOffices).DisplayMember = "Location";
    this.cboParentOffices.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboParentOffices).Location = new Point(89, 373);
    ((Control) this.cboParentOffices).Name = "cboParentOffices";
    ((Control) this.cboParentOffices).Size = new Size(258, 21);
    ((Control) this.cboParentOffices).TabIndex = 9;
    ((UltraControlBase) this.cboParentOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboParentOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboParentOffices).ValueMember = "OfficeGuid";
    appearance7.BorderColor = Color.Gray;
    this.txtFEIN.Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtFEIN).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.FEIN", true));
    this.txtFEIN.EditAs = (EditAsType) 1;
    this.txtFEIN.InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(89, 290);
    ((Control) this.txtFEIN).Name = "txtFEIN";
    this.txtFEIN.NonAutoSizeHeight = 21;
    ((Control) this.txtFEIN).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtFEIN).TabIndex = 5;
    this.txtFEIN.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtFEIN.Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAccountingOffice).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkAccountingOffice).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAccountingOffice).BackColorInternal = Color.Transparent;
    ((Control) this.chkAccountingOffice).DataBindings.Add(new Binding("Checked", (object) this.dsClientLocs, "tblClientOffices.AccountingOffice", true));
    ((UltraToggleEditorBase) this.chkAccountingOffice).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAccountingOffice).Location = new Point(180, 345);
    ((Control) this.chkAccountingOffice).Name = "chkAccountingOffice";
    ((Control) this.chkAccountingOffice).Size = new Size(112 /*0x70*/, 22);
    ((Control) this.chkAccountingOffice).TabIndex = 8;
    ((UltraToggleEditorBase) this.chkAccountingOffice).Text = "Accounting Office";
    appearance9.BackColorDisabled = Color.Gainsboro;
    appearance9.BorderColor = Color.Gray;
    ((UltraNumericEditorBase) this.numNextInvoiceNumber).Appearance = (AppearanceBase) appearance9;
    ((Control) this.numNextInvoiceNumber).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.NextInvoiceNum", true));
    ((Control) this.numNextInvoiceNumber).Location = new Point(87, 346);
    this.numNextInvoiceNumber.MaskInput = "nnnnnnnnnn";
    this.numNextInvoiceNumber.MaxValue = (object) 999999999;
    this.numNextInvoiceNumber.MinValue = (object) 1;
    ((Control) this.numNextInvoiceNumber).Name = "numNextInvoiceNumber";
    this.numNextInvoiceNumber.Nullable = true;
    ((Control) this.numNextInvoiceNumber).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.numNextInvoiceNumber).TabIndex = 7;
    ((UltraControlBase) this.numNextInvoiceNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numNextInvoiceNumber).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.Gray;
    this.txtFax.Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtFax).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.Fax", true));
    this.txtFax.EditAs = (EditAsType) 1;
    this.txtFax.InputMask = "###-###-####";
    ((Control) this.txtFax).Location = new Point(89, 239);
    ((Control) this.txtFax).Name = "txtFax";
    this.txtFax.NonAutoSizeHeight = 21;
    ((Control) this.txtFax).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtFax).TabIndex = 3;
    this.txtFax.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtFax.Text = "--";
    ((UltraControlBase) this.txtFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFax).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.Gray;
    this.txtPhone.Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.Phone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(89, 211);
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 21;
    ((Control) this.txtPhone).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtPhone).TabIndex = 2;
    this.txtPhone.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(35, 320);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label1.TabIndex = 129;
    this.Label1.Text = "Status:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboStatus).DataBindings.Add(new Binding("Value", (object) this.dsClientLocs, "tblClientOffices.StatusID", true));
    ((UltraGridBase) this.cboStatus).DataSource = (object) this.dsClientLocs.lstStatus;
    ((UltraDropDownBase) this.cboStatus).DisplayMember = "Status";
    this.cboStatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatus).Location = new Point(89, 318);
    ((Control) this.cboStatus).Name = "cboStatus";
    ((Control) this.cboStatus).Size = new Size(100, 21);
    ((Control) this.cboStatus).TabIndex = 6;
    ((UltraControlBase) this.cboStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStatus).ValueMember = "StatusID";
    this.lblNextInvoice.BackColor = Color.Transparent;
    this.lblNextInvoice.Location = new Point(-4, 348);
    this.lblNextInvoice.Name = "lblNextInvoice";
    this.lblNextInvoice.Size = new Size(87, 16 /*0x10*/);
    this.lblNextInvoice.TabIndex = 146;
    this.lblNextInvoice.Text = "Next Invoice #:";
    this.lblNextInvoice.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnSelectUser).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance12.BackColor = Color.FromArgb(248, 248, 248);
    appearance12.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnSelectUser).Appearance = (AppearanceBase) appearance12;
    ((ControlBase) this.btnSelectUser).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSelectUser).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSelectUser).Location = new Point(128 /*0x80*/, 215);
    ((Control) this.btnSelectUser).Name = "btnSelectUser";
    ((Control) this.btnSelectUser).Size = new Size(40, 40);
    ((Control) this.btnSelectUser).TabIndex = 2;
    this.Tip.SetToolTip((Control) this.btnSelectUser, "View Selected User Information");
    this.btnSelectUser.UseOSThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.Transparent;
    this.GroupBox2.Appearance = (AppearanceBase) appearance13;
    ((Control) this.GroupBox2).Controls.Add((Control) this.btnNewUser);
    ((Control) this.GroupBox2).Controls.Add((Control) this.lstUser);
    ((Control) this.GroupBox2).Controls.Add((Control) this.btnSelectUser);
    ((Control) this.GroupBox2).Enabled = false;
    ((Control) this.GroupBox2).Location = new Point(367, 8);
    ((Control) this.GroupBox2).Name = "GroupBox2";
    ((Control) this.GroupBox2).Size = new Size(187, 261);
    ((Control) this.GroupBox2).TabIndex = 1;
    this.GroupBox2.Text = "Users";
    ((Control) this.btnNewUser).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance14.BackColor = Color.FromArgb(248, 248, 248);
    appearance14.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNewUser).Appearance = (AppearanceBase) appearance14;
    ((Control) this.btnNewUser).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNewUser).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNewUser).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNewUser).Location = new Point(80 /*0x50*/, 215);
    ((Control) this.btnNewUser).Name = "btnNewUser";
    ((Control) this.btnNewUser).Size = new Size(40, 40);
    ((Control) this.btnNewUser).TabIndex = 1;
    this.Tip.SetToolTip((Control) this.btnNewUser, "Add a New User To This Office");
    this.btnNewUser.UseOSThemes = (DefaultableBoolean) 2;
    this.lstUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstUser.DataSource = (object) this.dsClientLocs.tblUsers;
    this.lstUser.DisplayMember = "Name";
    this.lstUser.Location = new Point(7, 16 /*0x10*/);
    this.lstUser.Name = "lstUser";
    this.lstUser.Size = new Size(173, 184);
    this.lstUser.TabIndex = 0;
    this.lstUser.ValueMember = "UserGuid";
    appearance15.BackColor = Color.FromArgb(248, 248, 248);
    appearance15.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnPrev).Appearance = (AppearanceBase) appearance15;
    ((ControlBase) this.btnPrev).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrev).Location = new Point(152, 470);
    ((Control) this.btnPrev).Name = "btnPrev";
    ((Control) this.btnPrev).Size = new Size(28, 28);
    ((Control) this.btnPrev).TabIndex = 3;
    this.Tip.SetToolTip((Control) this.btnPrev, "Previous Office");
    this.btnPrev.UseOSThemes = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.FromArgb(248, 248, 248);
    appearance16.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance16;
    ((ControlBase) this.btnNext).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNext).Location = new Point(272, 470);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(28, 28);
    ((Control) this.btnNext).TabIndex = 4;
    this.Tip.SetToolTip((Control) this.btnNext, "Next Office");
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.FromArgb(248, 248, 248);
    appearance17.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnLast).Appearance = (AppearanceBase) appearance17;
    ((ControlBase) this.btnLast).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnLast).Location = new Point(312, 470);
    ((Control) this.btnLast).Name = "btnLast";
    ((Control) this.btnLast).Size = new Size(28, 28);
    ((Control) this.btnLast).TabIndex = 5;
    this.Tip.SetToolTip((Control) this.btnLast, "Last Office");
    this.btnLast.UseOSThemes = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.FromArgb(248, 248, 248);
    appearance18.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnFirst).Appearance = (AppearanceBase) appearance18;
    ((ControlBase) this.btnFirst).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnFirst).Location = new Point(120, 470);
    ((Control) this.btnFirst).Name = "btnFirst";
    ((Control) this.btnFirst).Size = new Size(28, 28);
    ((Control) this.btnFirst).TabIndex = 2;
    this.Tip.SetToolTip((Control) this.btnFirst, "First Office");
    this.btnFirst.UseOSThemes = (DefaultableBoolean) 2;
    appearance19.BorderColor = Color.Gray;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance19).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblRecords).Appearance = (AppearanceBase) appearance19;
    ((ControlBase) this.lblRecords).BackColorInternal = Color.WhiteSmoke;
    this.lblRecords.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblRecords).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblRecords).Location = new Point(184, 470);
    ((Control) this.lblRecords).Name = "lblRecords";
    ((Control) this.lblRecords).Size = new Size(80 /*0x50*/, 19);
    ((Control) this.lblRecords).TabIndex = 141;
    ((ControlBase) this.lblRecords).Text = "Label10";
    this.err.ContainerControl = (ContainerControl) this;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(147, 205);
    ultraToolbar.FloatingSize = new Size(40, 46);
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Client Locations";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Manage Company Lines";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Licenses...";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._frmClientLocations_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Left).Location = new Point(0, 27);
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Left).Name = "_frmClientLocations_Toolbars_Dock_Area_Left";
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Left).Size = new Size(0, 487);
    this._frmClientLocations_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._frmClientLocations_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Right).Location = new Point(563, 27);
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Right).Name = "_frmClientLocations_Toolbars_Dock_Area_Right";
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Right).Size = new Size(0, 487);
    this._frmClientLocations_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._frmClientLocations_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Top).Name = "_frmClientLocations_Toolbars_Dock_Area_Top";
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Top).Size = new Size(563, 27);
    this._frmClientLocations_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._frmClientLocations_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom).Location = new Point(0, 514);
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom).Name = "_frmClientLocations_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom).Size = new Size(563, 0);
    this._frmClientLocations_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(442, 470);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 146;
    ((UltraTabControlBase) this.utLogos).AllowTabClosing = false;
    appearance20.BackColor = Color.Transparent;
    ((UltraTabControlBase) this.utLogos).Appearance = (AppearanceBase) appearance20;
    ((Control) this.utLogos).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.utLogos).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.utLogos).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.utLogos).Location = new Point(367, 272);
    ((Control) this.utLogos).Name = "utLogos";
    ((UltraTabControlBase) this.utLogos).SharedControls.AddRange(new Control[2]
    {
      (Control) this.lblLoadingImage,
      (Control) this.btnNewImage
    });
    ((UltraTabControlBase) this.utLogos).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.utLogos).Size = new Size(187, 192 /*0xC0*/);
    appearance21.BackColor = Color.Transparent;
    ((UltraTabControlBase) this.utLogos).TabHeaderAreaAppearance = (AppearanceBase) appearance21;
    ((Control) this.utLogos).TabIndex = 156;
    ultraTab1.Key = "Logo";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Logo";
    ultraTab2.Key = "Watermark";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Watermark";
    ((UltraTabControlBase) this.utLogos).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.utLogos).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblLoadingImage);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnNewImage);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(185, 169);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(563, 514);
    this.Controls.Add((Control) this.utLogos);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.btnPrev);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.btnLast);
    this.Controls.Add((Control) this.btnFirst);
    this.Controls.Add((Control) this.lblRecords);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.gbLocation);
    this.Controls.Add((Control) this._frmClientLocations_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmClientLocations_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmClientLocations_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmClientLocations_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmClientLocations);
    this.ShowInTaskbar = false;
    this.Text = "Client Locations";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.pbLogo).EndInit();
    ((ISupportInitialize) this.btnNewImage).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.pbWatermark).EndInit();
    ((ISupportInitialize) this.txtOfficeName).EndInit();
    this.dsClientLocs.EndInit();
    ((ISupportInitialize) this.gbLocation).EndInit();
    ((Control) this.gbLocation).ResumeLayout(false);
    ((Control) this.gbLocation).PerformLayout();
    ((ISupportInitialize) this.MgaNumSortOrder).EndInit();
    ((ISupportInitialize) this.txtEmail).EndInit();
    ((ISupportInitialize) this.txtDBA).EndInit();
    ((ISupportInitialize) this.cboParentOffices).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.chkAccountingOffice).EndInit();
    ((ISupportInitialize) this.numNextInvoiceNumber).EndInit();
    ((ISupportInitialize) this.txtFax).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.cboStatus).EndInit();
    ((ISupportInitialize) this.btnSelectUser).EndInit();
    ((ISupportInitialize) this.GroupBox2).EndInit();
    ((Control) this.GroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.btnNewUser).EndInit();
    ((ISupportInitialize) this.lstUser).EndInit();
    ((ISupportInitialize) this.btnPrev).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnLast).EndInit();
    ((ISupportInitialize) this.btnFirst).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.utLogos).EndInit();
    ((Control) this.utLogos).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).PerformLayout();
    this.ResumeLayout(false);
  }

  public frmClientLocations()
  {
    this.Load += new EventHandler(this.frmUsers_Load);
    this.changedOfficeImages = new List<Guid>();
    this.InitializeComponent();
  }

  public frmClientLocations(Guid clientLocationGuid)
    : this()
  {
    this._initializeToClientLocationGuid = new Guid?(clientLocationGuid);
  }

  private BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.dsClientLocs, this.dsClientLocs.tblClientOffices.TableName];
    }
  }

  private void frmUsers_Load(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    SqlDataAdapter daClientLocs = this.daClientLocs;
    if (daClientLocs.SelectCommand == null)
      daClientLocs.SelectCommand = new SqlCommand();
    if (daClientLocs.DeleteCommand == null)
      daClientLocs.DeleteCommand = new SqlCommand();
    if (daClientLocs.UpdateCommand == null)
      daClientLocs.UpdateCommand = new SqlCommand();
    if (daClientLocs.InsertCommand == null)
      daClientLocs.InsertCommand = new SqlCommand();
    MGASystems.Data.Utility.SetDataAdapterConnections((DbDataAdapter) this.daClientLocs, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnFirst).Appearance.Image = (object) instance.MoveFirst;
    ((ControlBase) this.btnLast).Appearance.Image = (object) instance.MoveLast;
    ((ControlBase) this.btnNewUser).Appearance.Image = (object) instance.NewImage;
    ((ControlBase) this.btnNext).Appearance.Image = (object) instance.MoveNext;
    ((ControlBase) this.btnPrev).Appearance.Image = (object) instance.MovePrev;
    ((ControlBase) this.btnSelectUser).Appearance.Image = (object) instance.Forward;
    ((ControlBase) this.btnNewImage).Appearance.Image = (object) instance.Open;
    if (this.DesignMode)
      return;
    this.zipRes.UserID = AddressResolverSettings.AddressResolveUserName;
    this.zipRes.Password = AddressResolverSettings.AddressResolverPassword;
    this.zipRes.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.PopulateDataSet();
    this.LoadUsers();
    this.LoadLogo();
    this.UpdateNavDisplay();
    this.SetupSecurity();
    this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
    Cursor.Current = Cursors.Default;
    if (!this._initializeToClientLocationGuid.HasValue)
      return;
    try
    {
      Database.MoveTo((object) this._initializeToClientLocationGuid, 0, (DataTable) this.dsClientLocs.tblClientOffices, this.bmb);
      this.UpdateNavDisplay();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message, "Error occurred trying to position to the current office");
      ProjectData.ClearProjectError();
    }
  }

  private void bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this.dsClientLocs.tblClientOffices != null)
      ((ControlBase) this.lblRecords).Text = $"{(this.bmb.Position + 1).ToString()} of {this.bmb.Count.ToString()}";
    this.LoadUsers();
    this.LoadLogo();
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent == null)
      return;
    infoChangedEvent((object) this, EventArgs.Empty);
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Manage Company Lines", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Licenses...", false) != 0)
        return;
      FormSettings.ShowForm(typeof (frmClientOfficeLicenses), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid);
    }
    else
      FormSettings.ShowForm(typeof (frmOfficeLines), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid);
  }

  private void LoadUsers()
  {
    if (this.bmb.Position == -1)
      return;
    Cursor.Current = Cursors.WaitCursor;
    MDIControls.Instance.StatusBarText = "Loading users at this location...";
    try
    {
      this.dsClientLocs.tblUsers.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.dsClientLocs, new string[1]
      {
        "tblUsers"
      }, CommandType.Text, "SELECT UserGuid, OfficeGuid, FirstName + @S + LastName AS Name FROM tblUsers WHERE OfficeGuid=@OfficeGuid ORDER BY FirstName", new object[4]
      {
        (object) "@OfficeGuid",
        (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid,
        (object) "@S",
        (object) " "
      });
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = Cursors.WaitCursor;
    }
  }

  private void LoadLogo()
  {
    if (this.bmb.Position == -1 || this.dsClientLocs.tblClientOffices.Rows.Count <= 0 || this.CurrentClientOfficeRow == null)
      return;
    if (this.CurrentClientOfficeRow.IsLogoNull())
    {
      try
      {
        this.CurrentClientOfficeRow.Logo = new byte[0];
        this.CurrentClientOfficeRow.PreviewWatermark = new byte[0];
        this.lblLoadingImage.Visible = true;
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.LogoWorkerRunWorkerCompleted);
        backgroundWorker.DoWork += new DoWorkEventHandler(this.LogoWorkerDoWork);
        backgroundWorker.RunWorkerAsync((object) this.CurrentClientOfficeRow.OfficeGuid);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      this.SetImage(this.pbLogo, this.CurrentClientOfficeRow.Logo);
      this.SetImage(this.pbWatermark, this.CurrentClientOfficeRow.PreviewWatermark);
    }
  }

  public void LogoWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    BackgroundWorker backgroundWorker = (BackgroundWorker) sender;
    backgroundWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.LogoWorkerRunWorkerCompleted);
    backgroundWorker.DoWork -= new DoWorkEventHandler(this.LogoWorkerDoWork);
    this.lblLoadingImage.Visible = false;
    object[] result = (object[]) e.Result;
    Guid guid = (Guid) result[0];
    byte[] bytes1 = result[1] as byte[];
    byte[] bytes2 = result[2] as byte[];
    backgroundWorker.Dispose();
    if (this.dsClientLocs.tblClientOffices.Rows.Count <= 0 || this.CurrentClientOfficeRow == null || !(guid == this.CurrentClientOfficeRow.OfficeGuid))
      return;
    this.CurrentClientOfficeRow.Logo = bytes1;
    this.CurrentClientOfficeRow.PreviewWatermark = bytes2;
    this.SetImage(this.pbLogo, bytes1);
    this.SetImage(this.pbWatermark, bytes2);
  }

  public void LogoWorkerDoWork(object sender, DoWorkEventArgs e)
  {
    Guid guid = (Guid) e.Argument;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "select Logo, PreviewWatermark from dbo.tblClientOffices where OfficeGuid = @OfficeGuid", new object[2]
    {
      (object) "@OfficeGuid",
      (object) guid
    });
    e.Result = (object) new object[3]
    {
      (object) guid,
      (object) row.Field<byte[]>(0),
      (object) row.Field<byte[]>(1)
    };
  }

  private void SelectUser(object sender, EventArgs e)
  {
    if (this.lstUser.SelectedIndex >= 0)
    {
      if (!SecurityManager.Instance.AssertPermission("{48AED463-E95A-468b-92C0-5ADFCDB3814D}"))
      {
        int num1 = (int) MessageBox.Show("You do not have the required security to open the user form.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (ServerXML.UseEncryptedPasswords)
        FormSettings.ShowForm(typeof (frmUserEncPwd), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid, (object) (Guid) this.lstUser.SelectedValue);
      else
        FormSettings.ShowForm(typeof (frmUsers), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid, (object) (Guid) this.lstUser.SelectedValue);
    }
    else
    {
      int num2 = (int) MessageBox.Show("Please select a user from the list before continuing.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void SetupSecurity()
  {
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Manage Company Lines"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{3BC16F12-B221-45cf-ABC2-D2C0016324D2}");
  }

  private void btnNewUser_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{48AED463-E95A-468b-92C0-5ADFCDB3814D}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to open the user form.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (ServerXML.UseEncryptedPasswords)
      FormSettings.ShowForm(typeof (frmUserEncPwd), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid, (object) true);
    else
      FormSettings.ShowForm(typeof (frmUsers), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid, (object) true);
  }

  private void PopulateDataSet()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsClientLocs, new string[1]
    {
      "lstStatus"
    }, CommandType.Text, "SELECT StatusID, Status FROM lstStatus ORDER BY Status");
    ((UltraTabControlBase) this.utLogos).Tabs["Watermark"].Visible = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentAutomation.Override.IssuingOfficeLogoWatermark", false);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daClientLocs, (DataTable) this.dsClientLocs.tblClientOffices);
    dsClientLocs.ParentOfficesRow row = this.dsClientLocs.ParentOffices.NewParentOfficesRow();
    row.OfficeGuid = Guid.Empty;
    row.Location = string.Empty;
    this.dsClientLocs.ParentOffices.AddParentOfficesRow(row);
    try
    {
      foreach (DataRow tblClientOffice in (TypedTableBase<dsClientLocs.tblClientOfficesRow>) this.dsClientLocs.tblClientOffices)
        this.dsClientLocs.ParentOffices.ImportRow(tblClientOffice);
    }
    finally
    {
      IEnumerator<dsClientLocs.tblClientOfficesRow> enumerator;
      enumerator?.Dispose();
    }
    if (this.dsClientLocs.tblClientOffices.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void Navigation(object sender, EventArgs e)
  {
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
    this.bmb.EndCurrentEdit();
    this.dsClientLocs.tblClientOffices.AcceptChanges();
    this.UpdateNavDisplay();
  }

  private void UpdateNavDisplay()
  {
    this.zipRes.ISOCountryCode = "USA";
    this.zipRes.ZipCode = string.Empty;
    this.zipRes.ZipCodeExtension = string.Empty;
    this.zipRes.Address1 = string.Empty;
    this.zipRes.Address2 = string.Empty;
    this.zipRes.City = string.Empty;
    this.zipRes.State = string.Empty;
    this.zipRes.County = string.Empty;
    if (this.bmb.Position < 0)
      return;
    ((ControlBase) this.lblRecords).Text = $"{(this.bmb.Position + 1).ToString()} of {this.bmb.Count.ToString()}";
    ((Control) this.btnFirst).Enabled = this.bmb.Position > 0;
    ((Control) this.btnPrev).Enabled = this.bmb.Position > 0;
    ((Control) this.btnLast).Enabled = this.bmb.Position < this.bmb.Count - 1;
    ((Control) this.btnNext).Enabled = this.bmb.Position < this.bmb.Count - 1;
    this.zipRes.ISOCountryCode = this.dsClientLocs.tblClientOffices[this.bmb.Position].ISOCountryCode;
    if (!this.dsClientLocs.tblClientOffices[this.bmb.Position].IsZipCodeNull())
      this.zipRes.ZipCode = this.dsClientLocs.tblClientOffices[this.bmb.Position].ZipCode;
    if (!this.dsClientLocs.tblClientOffices[this.bmb.Position].IsZipPlusNull())
      this.zipRes.ZipCodeExtension = this.dsClientLocs.tblClientOffices[this.bmb.Position].ZipPlus;
    if (!this.dsClientLocs.tblClientOffices[this.bmb.Position].IsAddress1Null())
      this.zipRes.Address1 = this.dsClientLocs.tblClientOffices[this.bmb.Position].Address1;
    if (!this.dsClientLocs.tblClientOffices[this.bmb.Position].IsAddress2Null())
      this.zipRes.Address2 = this.dsClientLocs.tblClientOffices[this.bmb.Position].Address2;
    if (!this.dsClientLocs.tblClientOffices[this.bmb.Position].IsCityNull())
      this.zipRes.City = this.dsClientLocs.tblClientOffices[this.bmb.Position].City;
    if (!this.dsClientLocs.tblClientOffices[this.bmb.Position].IsStateNull())
      this.zipRes.State = this.dsClientLocs.tblClientOffices[this.bmb.Position].State;
    if (this.dsClientLocs.tblClientOffices[this.bmb.Position].IsCountyNull())
      return;
    this.zipRes.County = this.dsClientLocs.tblClientOffices[this.bmb.Position].County;
  }

  private bool SaveChanges()
  {
    bool valid1 = true;
    this.err.SetError((Control) this.zipRes, string.Empty);
    this.err.SetError((Control) this.txtOfficeName, string.Empty);
    this.err.SetError((Control) this.txtPhone, string.Empty);
    this.err.SetError((Control) this.cboStatus, string.Empty);
    this.err.SetError((Control) this.txtFEIN, string.Empty);
    if (this.zipRes.Address1.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.zipRes, "Must enter street address 1");
      valid1 = false;
    }
    if (this.zipRes.City.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.zipRes, "Must enter city address");
      valid1 = false;
    }
    if (this.zipRes.ISOCountryCode.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.zipRes, "Must enter Country Code");
      valid1 = false;
    }
    if (valid1 && this.zipRes.ISOCountryCode.Equals("USA") && this.zipRes.State.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.zipRes, "Must enter state");
      valid1 = false;
    }
    if (valid1)
    {
      if (this.zipRes.ISOCountryCode.Equals("USA") && this.zipRes.ZipCode.Replace(" ", string.Empty).Length == 0)
      {
        this.err.SetError((Control) this.zipRes, "Must enter Zip Code");
        valid1 = false;
      }
      if (this.zipRes.ISOCountryCode.Equals("USA") && this.zipRes.County.Replace(" ", string.Empty).Length == 0)
      {
        this.err.SetError((Control) this.zipRes, "Must enter County");
        valid1 = false;
      }
      if (!this.zipRes.ISOCountryCode.Equals("USA") && this.zipRes.County.Replace(" ", string.Empty).Length == 0)
      {
        this.err.SetError((Control) this.zipRes, "Must enter Region");
        valid1 = false;
      }
    }
    if (((Control) this.numNextInvoiceNumber).Enabled)
    {
      if (this.numNextInvoiceNumber.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.numNextInvoiceNumber, "Must enter starting invoice number to continue");
        valid1 = false;
      }
      else if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.numNextInvoiceNumber.Value)))
      {
        this.err.SetError((Control) this.numNextInvoiceNumber, "Must be a number");
        valid1 = false;
      }
      else
      {
        try
        {
          int integer = Conversions.ToInteger(this.dsClientLocs.tblClientOffices[this.bmb.Position]["NextInvoiceNum", DataRowVersion.Proposed]);
          if (this.dsClientLocs.tblClientOffices[this.bmb.Position]["NextInvoiceNum", DataRowVersion.Original] != DBNull.Value)
          {
            if (Conversions.ToInteger(this.dsClientLocs.tblClientOffices[this.bmb.Position]["NextInvoiceNum", DataRowVersion.Original]) != integer)
            {
              if (MessageBox.Show("Changing the next invoice number can lead to gaps in your invoice numbers.  Are you sure you want to make this change?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) != DialogResult.Yes)
              {
                this.dsClientLocs.tblClientOffices[this.bmb.Position].NextInvoiceNum = Conversions.ToInteger(this.dsClientLocs.tblClientOffices[this.bmb.Position]["NextInvoiceNum", DataRowVersion.Original]);
                this.numNextInvoiceNumber.Value = (object) this.dsClientLocs.tblClientOffices[this.bmb.Position]["NextInvoiceNum", DataRowVersion.Original].ToString();
                valid1 = false;
              }
            }
          }
        }
        catch (VersionNotFoundException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        finally
        {
          this.err.SetError((Control) this.numNextInvoiceNumber, string.Empty);
        }
      }
    }
    else
      this.err.SetError((Control) this.numNextInvoiceNumber, string.Empty);
    if (((TextEditorControlBase) this.txtOfficeName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtOfficeName, "Must enter office name to continue");
      valid1 = false;
    }
    if (this.txtPhone.Value == DBNull.Value || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPhone.Value.ToString(), string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtPhone, "Must enter office phone number to continue");
      valid1 = false;
    }
    if (this.cboStatus.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboStatus, "Must enter office status to continue");
      valid1 = false;
    }
    if (((UltraToggleEditorBase) this.chkAccountingOffice).Checked && this.txtFEIN.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.txtFEIN, "FEIN required for all accounting offices.");
      valid1 = false;
    }
    bool valid2 = this.ValidateNextInvoiceNumber(valid1);
    if (valid2)
    {
      if (((TextEditorControlBase) this.txtDBA).Text.Replace(" ", string.Empty).Length == 0)
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetDBANull();
      this.err.SetError((Control) this.txtOfficeName, string.Empty);
      if (this.cboParentOffices.Value != null && ((Guid) this.cboParentOffices.Value).Equals(Guid.Empty))
      {
        this.cboParentOffices.Value = (object) DBNull.Value;
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetParentOfficeGuidNull();
      }
      this.dsClientLocs.tblClientOffices[this.bmb.Position].ISOCountryCode = this.zipRes.ISOCountryCode;
      if (this.zipRes.ZipCode.Replace(" ", string.Empty).Length > 0)
        this.dsClientLocs.tblClientOffices[this.bmb.Position].ZipCode = this.zipRes.ZipCode;
      else
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetZipCodeNull();
      this.dsClientLocs.tblClientOffices[this.bmb.Position].Address1 = this.zipRes.Address1;
      this.dsClientLocs.tblClientOffices[this.bmb.Position].City = this.zipRes.City;
      if (this.zipRes.Address2.Replace(" ", string.Empty).Length > 0)
        this.dsClientLocs.tblClientOffices[this.bmb.Position].Address2 = this.zipRes.Address2;
      else
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetAddress2Null();
      if (this.zipRes.ZipCodeExtension.Replace(" ", string.Empty).Length > 0)
        this.dsClientLocs.tblClientOffices[this.bmb.Position].ZipPlus = this.zipRes.ZipCodeExtension;
      else
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetZipPlusNull();
      if (this.zipRes.State.Replace(" ", string.Empty).Length > 0)
        this.dsClientLocs.tblClientOffices[this.bmb.Position].State = this.zipRes.State;
      else
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetStateNull();
      if (this.zipRes.County.Replace(" ", string.Empty).Length > 0)
        this.dsClientLocs.tblClientOffices[this.bmb.Position].County = this.zipRes.County;
      else
        this.dsClientLocs.tblClientOffices[this.bmb.Position].SetCountyNull();
      this.bmb.EndCurrentEdit();
      valid2 = this.SaveToDatabase(valid2);
    }
    return valid2;
  }

  private bool SaveToDatabase(bool valid)
  {
    if (this.dsClientLocs.HasChanges())
    {
      try
      {
        this.LogChanges(this.dsClientLocs.tblClientOffices.TableName, "Client Location Form was modified. ", "OfficeGuid", "OfficeGuid");
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daClientLocs, (DataTable) this.dsClientLocs.tblClientOffices);
        Dictionary<Guid, dsClientLocs.tblClientOfficesRow> dictionary = new Dictionary<Guid, dsClientLocs.tblClientOfficesRow>();
        try
        {
          foreach (dsClientLocs.tblClientOfficesRow row in this.dsClientLocs.tblClientOffices.Rows)
          {
            if (this.changedOfficeImages.Contains(row.OfficeGuid))
              dictionary.Add(row.OfficeGuid, row);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (dictionary.Count > 0)
        {
          BackgroundWorker backgroundWorker = new BackgroundWorker();
          backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.LogoUpdateWorkerRunWorkerCompleted);
          backgroundWorker.DoWork += new DoWorkEventHandler(this.LogoUpdateWorkerDoWork);
          backgroundWorker.RunWorkerAsync((object) dictionary);
        }
        MDIControls.Instance.StatusBarText = "Client location saved.";
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (ex2.Message.IndexOf("IX_tblClientOffices_UniqueNames") != -1)
        {
          this.err.SetError((Control) this.txtOfficeName, "Office names must be unique");
          valid = false;
        }
        else
          ErrorHandler.HandleError(ex2);
        ProjectData.ClearProjectError();
      }
    }
    return valid;
  }

  public void LogoUpdateWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    BackgroundWorker backgroundWorker = (BackgroundWorker) sender;
    backgroundWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.LogoWorkerRunWorkerCompleted);
    backgroundWorker.DoWork -= new DoWorkEventHandler(this.LogoWorkerDoWork);
    backgroundWorker.Dispose();
  }

  public void LogoUpdateWorkerDoWork(object sender, DoWorkEventArgs e)
  {
    Dictionary<Guid, dsClientLocs.tblClientOfficesRow> dictionary = (Dictionary<Guid, dsClientLocs.tblClientOfficesRow>) e.Argument;
    try
    {
      foreach (KeyValuePair<Guid, dsClientLocs.tblClientOfficesRow> keyValuePair in dictionary)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update dbo.tblClientOffices set Logo = @Logo, PreviewWatermark = @Watermark where OfficeGuid = @OfficeGuid", new object[6]
        {
          (object) "@Logo",
          (object) keyValuePair.Value.Logo,
          (object) "@Watermark",
          (object) keyValuePair.Value.PreviewWatermark,
          (object) "@OfficeGuid",
          (object) keyValuePair.Key
        });
    }
    finally
    {
      Dictionary<Guid, dsClientLocs.tblClientOfficesRow>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private bool ValidateNextInvoiceNumber(bool valid)
  {
    bool flag;
    if (MGASystems.Common.SystemSettings.KeyExists("SkipNextInvoiceNumCheck") && MGASystems.Common.SystemSettings.GetBoolSetting("SkipNextInvoiceNumCheck"))
    {
      flag = true;
    }
    else
    {
      if (this.numNextInvoiceNumber.Value != DBNull.Value && this.dsClientLocs.tblClientOffices[this.bmb.Position].RowState != DataRowState.Added)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT MAX(OfficeInvoiceNum) FROM tblFin_Invoices WHERE GLCompanyID = @glID", new object[2]
        {
          (object) "@glID",
          (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT OfficeID FROM tblClientOffices WHERE OfficeGUID = @offGuid", new object[2]
          {
            (object) "@offGuid",
            (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid
          })
        }));
        if (objectValue != DBNull.Value && (int) this.numNextInvoiceNumber.Value <= (int) objectValue)
        {
          this.err.SetError((Control) this.numNextInvoiceNumber, "This is not a valid invoice #. Next available is " + (Conversions.ToInteger(objectValue) + 1).ToString());
          valid = false;
        }
      }
      flag = valid;
    }
    return flag;
  }

  internal void UpdateUserList(Guid userGuid, Guid officeGuid, string userName)
  {
    dsClientLocs.tblUsersRow byUserGuid = this.dsClientLocs.tblUsers.FindByUserGuid(userGuid);
    if (byUserGuid == null)
      return;
    dsClientLocs.tblUsersRow tblUsersRow = byUserGuid;
    tblUsersRow.UserGuid = userGuid;
    tblUsersRow.OfficeGuid = officeGuid;
    tblUsersRow.Name = userName;
  }

  internal void AddToUserList(Guid userGuid, Guid officeGuid, string userName)
  {
    this.dsClientLocs.tblUsers.AddtblUsersRow(userGuid, officeGuid, userName);
  }

  internal void DeleteFromUserList(Guid userGuid)
  {
    this.dsClientLocs.tblUsers.RemovetblUsersRow((dsClientLocs.tblUsersRow) this.dsClientLocs.tblUsers.Select($"UserGuid = '{userGuid.ToString()}'")[0]);
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.dsClientLocs.tblClientOffices.RejectChanges();
    this.UpdateNavDisplay();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this office location?", "Delete Office?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int position = this.bmb.Position;
    this.dsClientLocs.tblClientOffices[this.bmb.Position].Delete();
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daClientLocs, (DataTable) this.dsClientLocs.tblClientOffices);
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      try
      {
        this.dsClientLocs.RejectChanges();
      }
      catch (NullReferenceException ex3)
      {
        ProjectData.SetProjectError((Exception) ex3);
        ProjectData.ClearProjectError();
      }
      this.bmb.Position = position;
      if (ex2.Message.Contains("FK_tblFin_CostCenters_tblClientOffices"))
      {
        int num1 = (int) MessageBox.Show("This office location can not be deleted because it has\ncost centers associated with it.", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.Contains("FK_tblUsers_tblClientOffices"))
      {
        int num2 = (int) MessageBox.Show("This office location can not be deleted because it has\nusers associated with it.", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.Contains("FK_QuoteQuotingLocation") || ex2.Message.Contains("FK_QuoteQuotingLocation"))
      {
        int num3 = (int) MessageBox.Show("This office location can not be deleted because it is\nassociated with existing policies.", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.Contains("FK_tblCompanyPolicyCharges_tblClientOffices"))
      {
        int num4 = (int) MessageBox.Show("This office location can not be deleted because it is\nassociated with existing Company Policy Charges.", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (ex2.Message.Contains("FK_tblQuoteOptionPremiums_tblClientOffices"))
      {
        int num5 = (int) MessageBox.Show("This office location can not be deleted because it has options associated with it.", "Unable to Delete Location", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError(ex2);
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.SaveChanges())
      return;
    e.Cancel = true;
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    dsClientLocs.tblClientOfficesRow row = this.dsClientLocs.tblClientOffices.NewtblClientOfficesRow();
    row.OfficeGuid = Guid.NewGuid();
    row.StatusID = 1;
    this.dsClientLocs.tblClientOffices.AddtblClientOfficesRow(row);
    this.bmb.Position = this.dsClientLocs.tblClientOffices.Count - 1;
    this.UpdateNavDisplay();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.dbSave.UIState == UIState.Editing;
    ((Control) this.gbLocation).Enabled = flag;
    ((Control) this.GroupBox2).Enabled = flag;
    ((Control) this.btnNewImage).Enabled = flag;
    if (!flag)
      return;
    ((Control) this.numNextInvoiceNumber).Enabled = ((UltraToggleEditorBase) this.chkAccountingOffice).Checked;
  }

  private void chkAccountingOffice_CheckStateChanged(object sender, EventArgs e)
  {
    ((Control) this.numNextInvoiceNumber).Enabled = this.dbSave.UIState == UIState.Editing && ((UltraToggleEditorBase) this.chkAccountingOffice).Checked;
    if (((Control) this.numNextInvoiceNumber).Enabled)
      return;
    this.numNextInvoiceNumber.Value = (object) DBNull.Value;
  }

  private void lnkAltNumbers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowForm(typeof (frmClientLocAltNum), (object) this.dsClientLocs.tblClientOffices[this.bmb.Position].OfficeGuid);
  }

  bool IRecreatableEntity.CanReCreateEntity => false;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      if (this.dsClientLocs.tblClientOffices.Rows.Count > 0 && this.CurrentClientOfficeRow != null)
        return this.CurrentClientOfficeRow.OfficeGuid;
      throw new InvalidOperationException();
    }
  }

  public dsClientLocs.tblClientOfficesRow CurrentClientOfficeRow
  {
    get => (dsClientLocs.tblClientOfficesRow) ((DataRowView) this.bmb.Current).Row;
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return this.dsClientLocs.tblClientOffices.Rows.Count <= 0 || !string.IsNullOrEmpty(this.CurrentClientOfficeRow.Location) ? "User" : this.CurrentClientOfficeRow.Location;
    }
  }

  string IRecreatableEntity.FriendlyEntityName => "Client Locations";

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    throw new NotImplementedException();
  }

  string IRecreatableEntity.RecreateTypeName => typeof (frmClientLocations).ToString();

  public bool AllowAddNewDocument => true;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  private void btnNewImage_Click(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Title = "Please select a logo";
      openFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK || !File.Exists(openFileDialog.FileName) || this.dsClientLocs.tblClientOffices.Rows.Count <= 0 || this.CurrentClientOfficeRow == null)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.utLogos).SelectedTab.Key, "Logo", false) == 0)
      {
        this.CurrentClientOfficeRow.Logo = File.ReadAllBytes(openFileDialog.FileName);
        this.SetImage(this.pbLogo, this.CurrentClientOfficeRow.Logo);
      }
      else
      {
        this.CurrentClientOfficeRow.PreviewWatermark = File.ReadAllBytes(openFileDialog.FileName);
        this.SetImage(this.pbWatermark, this.CurrentClientOfficeRow.PreviewWatermark);
      }
      if (this.changedOfficeImages.Contains(this.CurrentClientOfficeRow.OfficeGuid))
        return;
      this.changedOfficeImages.Add(this.CurrentClientOfficeRow.OfficeGuid);
    }
  }

  private void SetImage(PictureBox pb, byte[] bytes)
  {
    if (pb != null && pb.Image != null)
    {
      Image image = pb.Image;
      pb.Image = (Image) null;
      image.Dispose();
    }
    if (bytes == null || bytes.Length <= 0)
      return;
    using (MemoryStream memoryStream = new MemoryStream(bytes))
      pb.Image = Image.FromStream((Stream) memoryStream);
  }

  protected void LogChanges(
    string dtTableName,
    string strAction,
    string strGUIDtoLog,
    string strcontext)
  {
    DataSet dataSet = new DataSet();
    DataTable table = this.dsClientLocs.Tables[dtTableName];
    DataRow[] dataRowArray1 = table.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent);
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      DataRow dataRow = dataRowArray1[index1];
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          string Left = dataRow[column, DataRowVersion.Original].ToString();
          string Right = dataRow[column, DataRowVersion.Current].ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
            strAction = $"{strAction} Original {column.Caption}: {Left} was changed to: {Right}";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} for {strcontext}: {dataRow[strcontext].ToString()}", Guid.Parse(dataRow[strGUIDtoLog].ToString()), $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index1; }
    }
    DataRow[] dataRowArray2 = table.Select((string) null, (string) null, DataViewRowState.Added);
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      DataRow dataRow = dataRowArray2[index2];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str}  {column.Caption}: {dataRow[column, DataRowVersion.Current].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User inserted new record. {str}");
      checked { ++index2; }
    }
    DataRow[] dataRowArray3 = table.Select((string) null, (string) null, DataViewRowState.Deleted);
    int index3 = 0;
    while (index3 < dataRowArray3.Length)
    {
      DataRow dataRow = dataRowArray3[index3];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str} {column.Caption}: {dataRow[column, DataRowVersion.Original].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User deleted the record. {str}");
      checked { ++index3; }
    }
  }
}
