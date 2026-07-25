// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.FormCopyDocumentAutomationSetup
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[DesignerGenerated]
public class FormCopyDocumentAutomationSetup : Form
{
  private IContainer components;
  protected Guid _companyLineGuid;
  protected Guid _systemEventGuid;
  private Guid _automationReportGuid;
  private int _templateID;
  private int _ID;
  protected int _QuoteStatusReasonID;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyDocumentAutomationSetup));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CopyOver");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.lnkApplyFilter = new LinkLabel();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.cnSQL = new SqlConnection();
    this.lnkDeselectCompanyLine = new LinkLabel();
    this.lnkSelectCompanyLines = new LinkLabel();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.lblEvent = new UltraLabel();
    this.dgView = new UltraGrid();
    this.ds = new dsCopyDocSetup();
    this.cbStateFilter = new MGASimpleComboBox();
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    this.SuspendLayout();
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Location = new Point(320, 108);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(58, 13);
    this.lnkApplyFilter.TabIndex = 24;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    this.Label26.AutoSize = true;
    this.Label26.Location = new Point(470, 55);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(60, 13);
    this.Label26.TabIndex = 23;
    this.Label26.Text = "State Filter:";
    this.Label25.AutoSize = true;
    this.Label25.Location = new Point(243, 55);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(55, 13);
    this.Label25.TabIndex = 22;
    this.Label25.Text = "Line Filter:";
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(15, 55);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(79, 13);
    this.Label24.TabIndex = 21;
    this.Label24.Text = "Company Filter:";
    this.cnSQL.ConnectionString = "Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.lnkDeselectCompanyLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectCompanyLine.AutoSize = true;
    this.lnkDeselectCompanyLine.Location = new Point(17, 438);
    this.lnkDeselectCompanyLine.Name = "lnkDeselectCompanyLine";
    this.lnkDeselectCompanyLine.Size = new Size(149, 13);
    this.lnkDeselectCompanyLine.TabIndex = 37;
    this.lnkDeselectCompanyLine.TabStop = true;
    this.lnkDeselectCompanyLine.Text = "De-select All Company / Lines";
    this.lnkSelectCompanyLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectCompanyLines.AutoSize = true;
    this.lnkSelectCompanyLines.Location = new Point(17, 411);
    this.lnkSelectCompanyLines.Name = "lnkSelectCompanyLines";
    this.lnkSelectCompanyLines.Size = new Size(134, 13);
    this.lnkSelectCompanyLines.TabIndex = 36;
    this.lnkSelectCompanyLines.TabStop = true;
    this.lnkSelectCompanyLines.Text = "Select All Company / Lines";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(588, 426);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((ControlBase) this.btnCancel).Padding = new Size(5, 0);
    ((Control) this.btnCancel).Size = new Size(109, 25);
    ((Control) this.btnCancel).TabIndex = 444;
    ((Control) this.btnCancel).Tag = (object) "";
    ((ControlBase) this.btnCancel).Text = "Cancel Setup";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(461, 426);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(109, 25);
    ((Control) this.btnSave).TabIndex = 443;
    ((Control) this.btnSave).Tag = (object) "";
    ((ControlBase) this.btnSave).Text = "Save Setup";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.lblEvent).Location = new Point(12, 20);
    ((Control) this.lblEvent).Name = "lblEvent";
    ((Control) this.lblEvent).Size = new Size(393, 20);
    ((Control) this.lblEvent).TabIndex = 446;
    ((ControlBase) this.lblEvent).Text = "System Event:";
    ((Control) this.dgView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgView).DataMember = "ViewCompanyLines";
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 210;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 195;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 203;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 205;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 210;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Copy";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 60;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgView).Location = new Point(12, 138);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(684, 267);
    ((Control) this.dgView).TabIndex = 25;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCopyDocSetup";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    this.cbStateFilter.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cbStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.cbStateFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbStateFilter).DisplayMember = "State";
    this.cbStateFilter.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStateFilter).Location = new Point(473, 76);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    ((Control) this.cbStateFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbStateFilter).TabIndex = 20;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStateFilter).ValueMember = "StateID";
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    this.cbCompanyFilter.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cbCompanyFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cbCompanyFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbCompanyFilter).DisplayMember = "Name";
    this.cbCompanyFilter.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 500;
    ((Control) this.cbCompanyFilter).Location = new Point(15, 76);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    ((Control) this.cbCompanyFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbCompanyFilter).TabIndex = 18;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanyFilter).ValueMember = "CompanyLocationGuid";
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    this.cbLineFilter.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cbLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.cbLineFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbLineFilter).DisplayMember = "LineName";
    this.cbLineFilter.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 300;
    ((Control) this.cbLineFilter).Location = new Point(246, 76);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    ((Control) this.cbLineFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbLineFilter).TabIndex = 19;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLineFilter).ValueMember = "LineGuid";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(708, 463);
    this.Controls.Add((Control) this.lblEvent);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkDeselectCompanyLine);
    this.Controls.Add((Control) this.lnkSelectCompanyLines);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.cbStateFilter);
    this.Controls.Add((Control) this.cbCompanyFilter);
    this.Controls.Add((Control) this.cbLineFilter);
    this.Name = nameof (FormCopyDocumentAutomationSetup);
    this.Text = "Copy Document Automation Setup";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual LinkLabel lnkApplyFilter
  {
    get => this._lnkApplyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkApplyFilter_LinkClicked);
      LinkLabel lnkApplyFilter1 = this._lnkApplyFilter;
      if (lnkApplyFilter1 != null)
        lnkApplyFilter1.LinkClicked -= clickedEventHandler;
      this._lnkApplyFilter = value;
      LinkLabel lnkApplyFilter2 = this._lnkApplyFilter;
      if (lnkApplyFilter2 == null)
        return;
      lnkApplyFilter2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbStateFilter")]
  private virtual MGASimpleComboBox cbStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbCompanyFilter")]
  private virtual MGASimpleComboBox cbCompanyFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbLineFilter")]
  private virtual MGASimpleComboBox cbLineFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgView")]
  protected virtual UltraGrid dgView { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyDocSetup ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeselectCompanyLine
  {
    get => this._lnkDeselectCompanyLine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectCompanyLine_LinkClicked);
      LinkLabel deselectCompanyLine1 = this._lnkDeselectCompanyLine;
      if (deselectCompanyLine1 != null)
        deselectCompanyLine1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectCompanyLine = value;
      LinkLabel deselectCompanyLine2 = this._lnkDeselectCompanyLine;
      if (deselectCompanyLine2 == null)
        return;
      deselectCompanyLine2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectCompanyLines
  {
    get => this._lnkSelectCompanyLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectCompanyLines_LinkClicked);
      LinkLabel selectCompanyLines1 = this._lnkSelectCompanyLines;
      if (selectCompanyLines1 != null)
        selectCompanyLines1.LinkClicked -= clickedEventHandler;
      this._lnkSelectCompanyLines = value;
      LinkLabel selectCompanyLines2 = this._lnkSelectCompanyLines;
      if (selectCompanyLines2 == null)
        return;
      selectCompanyLines2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("lblEvent")]
  internal virtual UltraLabel lblEvent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCopyDocumentAutomationSetup(
    int ID,
    Guid CompanyLineGuid,
    Guid EventGuid,
    Guid automationReportGuid,
    int QuoteStatusReasonID)
  {
    this.Load += new EventHandler(this.FormCopyDocumentAutomationSetup_Load);
    this._automationReportGuid = Guid.Empty;
    this._templateID = int.MinValue;
    this.InitializeComponent();
    this._companyLineGuid = CompanyLineGuid;
    this._systemEventGuid = EventGuid;
    this._automationReportGuid = automationReportGuid;
    this._ID = ID;
    this._QuoteStatusReasonID = QuoteStatusReasonID;
  }

  public FormCopyDocumentAutomationSetup(
    int ID,
    Guid CompanyLineGuid,
    Guid EventGuid,
    int templateID,
    int QuoteStatusReasonID)
  {
    this.Load += new EventHandler(this.FormCopyDocumentAutomationSetup_Load);
    this._automationReportGuid = Guid.Empty;
    this._templateID = int.MinValue;
    this.InitializeComponent();
    this._companyLineGuid = CompanyLineGuid;
    this._systemEventGuid = EventGuid;
    this._templateID = templateID;
    this._ID = ID;
    this._QuoteStatusReasonID = QuoteStatusReasonID;
  }

  private void FormCopyDocumentAutomationSetup_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = DefaultDatabase.ConnectionString;
    UltraLabel lblEvent;
    string str = $"{((ControlBase) (lblEvent = this.lblEvent)).Text} {DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT EventName FROM lstAutomationDocumentEvents WHERE EventGuid = @EG", new object[2]
    {
      (object) "@EG",
      (object) this._systemEventGuid
    })}";
    ((ControlBase) lblEvent).Text = str;
    dsCopyDocSetup.lstLinesRow row1 = this.ds.lstLines.NewlstLinesRow();
    row1.LineGuid = Guid.Empty;
    row1.LineName = "Any";
    this.ds.lstLines.AddlstLinesRow(row1);
    dsCopyDocSetup.tblCompanyLocationsRow row2 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row2.CompanyLocationGuid = Guid.Empty;
    row2.Name = "Any";
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row2);
    dsCopyDocSetup.lstStatesRow row3 = this.ds.lstStates.NewlstStatesRow();
    row3.StateID = string.Empty;
    row3.State = "Any";
    this.ds.lstStates.AddlstStatesRow(row3);
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblCompanyLocations, CommandType.Text, "SELECT CompanyLocationGUID, Name FROM tblCompanyLocations WITH (NOLOCK) ORDER BY Name");
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstStates, CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstLines, CommandType.Text, "SELECT LineGUID, LineName FROM lstLines ORDER BY LineName");
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    object obj4 = (object) null;
    object obj5 = (object) null;
    object obj6 = (object) null;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbCompanyFilter.Text, "Any", false) != 0)
      obj2 = RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbLineFilter.Text, "Any", false) != 0)
      obj3 = RuntimeHelpers.GetObjectValue(this.cbLineFilter.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbStateFilter.Text, "Any", false) != 0)
      obj4 = RuntimeHelpers.GetObjectValue(this.cbStateFilter.Value);
    if (this._templateID != int.MinValue)
      obj5 = (object) this._templateID;
    if (!this._automationReportGuid.Equals(Guid.Empty))
      obj1 = (object) this._automationReportGuid;
    if (this._QuoteStatusReasonID != int.MinValue)
      obj6 = (object) this._QuoteStatusReasonID;
    this.ds.ViewCompanyLines.Clear();
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) this.ds.ViewCompanyLines, CommandType.StoredProcedure, "spSearchCompanyLines", new object[16 /*0x10*/]
      {
        (object) "@currentCompanyLine",
        (object) this._companyLineGuid,
        (object) "@companyLocationGuid",
        obj2,
        (object) "@lineGuid",
        obj3,
        (object) "@stateID",
        obj4,
        (object) "@systemEventGuid",
        (object) this._systemEventGuid,
        (object) "@templateID",
        obj5,
        (object) "@automationReportGuid",
        obj1,
        (object) "@QuoteStatusReasonID",
        obj6
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkSelectCompanyLines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.dgView).Rows.ExpandAll(true);
    try
    {
      foreach (dsCopyDocSetup.ViewCompanyLinesRow row in this.ds.ViewCompanyLines.Rows)
        row.CopyOver = true;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkDeselectCompanyLine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsCopyDocSetup.ViewCompanyLinesRow row in this.ds.ViewCompanyLines.Rows)
        row.CopyOver = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    List<Guid> guidList = new List<Guid>();
    try
    {
      try
      {
        foreach (dsCopyDocSetup.ViewCompanyLinesRow row in this.ds.ViewCompanyLines.Rows)
        {
          if (row.CopyOver)
          {
            this.SaveData(row.CompanyLineGuid);
            guidList.Add(row.CompanyLineGuid);
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (Guid CompanyLineGuid in guidList)
          this.ds.ViewCompanyLines.Rows.Remove((DataRow) this.ds.ViewCompanyLines.FindByCompanyLineGuid(CompanyLineGuid));
      }
      finally
      {
        List<Guid>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  protected virtual void SaveData(Guid companyLineGuid)
  {
    object obj = (object) null;
    if (this._QuoteStatusReasonID != int.MinValue)
      obj = (object) this._QuoteStatusReasonID;
    string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("SaveCompanyLineDocSetupProc", "dbo.SaveCompanyLineDocSetup");
    if (!this._automationReportGuid.Equals(Guid.Empty))
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, setting, new object[10]
      {
        (object) "@oldCompanyLineGuid",
        (object) this._companyLineGuid,
        (object) "@compLineGUID",
        (object) companyLineGuid,
        (object) "@systemEventGuid",
        (object) this._systemEventGuid,
        (object) "@automationReportGuid",
        (object) this._automationReportGuid,
        (object) "@QuoteStatusReasonID",
        obj
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, setting, new object[10]
      {
        (object) "@oldCompanyLineGuid",
        (object) this._companyLineGuid,
        (object) "@compLineGUID",
        (object) companyLineGuid,
        (object) "@systemEventGuid",
        (object) this._systemEventGuid,
        (object) "@templateID",
        (object) this._templateID,
        (object) "@QuoteStatusReasonID",
        obj
      });
  }
}
