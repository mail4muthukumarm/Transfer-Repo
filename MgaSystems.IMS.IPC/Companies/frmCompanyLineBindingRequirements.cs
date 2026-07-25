// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyLineBindingRequirements
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

public sealed class frmCompanyLineBindingRequirements : Form
{
  private IContainer components;
  private DbDataAdapter daCompanyBindingRequirements;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private DbConnection cn;
  private dsCompanyLineBindingRequirements ds;
  private UltraDropDown ddRequirements;
  private int _companyLineID;
  private CompanyLine _companyLine;
  private const string _stopsSettingStr = "CompanyLineRequirements.ImplementSoftStops";
  private bool _showStop;
  private List<string> _lstDeletedRequirementID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ugRequirements
  {
    get => this._ugRequirements;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugRequirements_AfterRowInsert);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ugRequirements_BeforeRowUpdate);
      BeforeRowsDeletedEventHandler deletedEventHandler = new BeforeRowsDeletedEventHandler(this.ugRequirements_BeforeRowsDeleted);
      UltraGrid ugRequirements1 = this._ugRequirements;
      if (ugRequirements1 != null)
      {
        ugRequirements1.AfterRowInsert -= rowEventHandler;
        ugRequirements1.BeforeRowUpdate -= cancelableRowEventHandler;
        ugRequirements1.BeforeRowsDeleted -= deletedEventHandler;
      }
      this._ugRequirements = value;
      UltraGrid ugRequirements2 = this._ugRequirements;
      if (ugRequirements2 == null)
        return;
      ugRequirements2.AfterRowInsert += rowEventHandler;
      ugRequirements2.BeforeRowUpdate += cancelableRowEventHandler;
      ugRequirements2.BeforeRowsDeleted += deletedEventHandler;
    }
  }

  [field: AccessedThroughProperty("uddQuoteStatus")]
  private virtual UltraDropDown uddQuoteStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAddRequirement
  {
    get => this._lnkAddRequirement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddRequirement_LinkClicked);
      LinkLabel lnkAddRequirement1 = this._lnkAddRequirement;
      if (lnkAddRequirement1 != null)
        lnkAddRequirement1.LinkClicked -= clickedEventHandler;
      this._lnkAddRequirement = value;
      LinkLabel lnkAddRequirement2 = this._lnkAddRequirement;
      if (lnkAddRequirement2 == null)
        return;
      lnkAddRequirement2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkCancelRequirement
  {
    get => this._lnkCancelRequirement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancelRequirement_LinkClicked);
      LinkLabel cancelRequirement1 = this._lnkCancelRequirement;
      if (cancelRequirement1 != null)
        cancelRequirement1.LinkClicked -= clickedEventHandler;
      this._lnkCancelRequirement = value;
      LinkLabel cancelRequirement2 = this._lnkCancelRequirement;
      if (cancelRequirement2 == null)
        return;
      cancelRequirement2.LinkClicked += clickedEventHandler;
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

  internal virtual LinkLabel lnkCopy
  {
    get => this._lnkCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopy_LinkClicked);
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

  [field: AccessedThroughProperty("chkQuotingSoftStop")]
  internal virtual MGACheckBox chkQuotingSoftStop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkBindingSoftStop")]
  internal virtual MGACheckBox chkBindingSoftStop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLineBindingRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BindingRequirementID", -1, (object) "ddRequirements");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("QuoteStatusID", -1, (object) "uddQuoteStatus");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("HardStop");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SoftStop");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyLineBindingRequirements));
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstBindingRequirements", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("BindingRequirementID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("BindingRequirement");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("lstBindingRequirementstblCompanyLineBindingRequirements");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstBindingRequirementstblCompanyLineBindingRequirements", 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("BindingRequirementID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("HardStop");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("SoftStop");
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstQuoteStatus", -1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Description");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.ugRequirements = new UltraGrid();
    this.ds = new dsCompanyLineBindingRequirements();
    this.daCompanyBindingRequirements = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.ddRequirements = new UltraDropDown();
    this.uddQuoteStatus = new UltraDropDown();
    this.lnkAddRequirement = new LinkLabel();
    this.lnkCancelRequirement = new LinkLabel();
    this.btnSave = new MGAButton();
    this.lnkCopy = new LinkLabel();
    this.chkQuotingSoftStop = new MGACheckBox();
    this.chkBindingSoftStop = new MGACheckBox();
    ((ISupportInitialize) this.ugRequirements).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddRequirements).BeginInit();
    ((ISupportInitialize) this.uddQuoteStatus).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.chkQuotingSoftStop).BeginInit();
    ((ISupportInitialize) this.chkBindingSoftStop).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugRequirements).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugRequirements).DataSource = (object) this.ds.tblCompanyLineBindingRequirements;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ugRequirements).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.AddButtonCaption = "New Binding Requirement";
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Requirement";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 4;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 474;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Event";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 283;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Hard Stop";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Soft Stop";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ugRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.WhiteSmoke;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance5;
    ((Control) this.ugRequirements).Location = new Point(0, 0);
    ((Control) this.ugRequirements).Name = "ugRequirements";
    ((Control) this.ugRequirements).Size = new Size(901, 430);
    ((Control) this.ugRequirements).TabIndex = 0;
    ((UltraControlBase) this.ugRequirements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRequirements).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineBindingRequirements";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daCompanyBindingRequirements.DeleteCommand = this.DbDeleteCommand1;
    this.daCompanyBindingRequirements.InsertCommand = this.DbInsertCommand1;
    this.daCompanyBindingRequirements.SelectCommand = this.DbSelectCommand1;
    this.daCompanyBindingRequirements.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineBindingRequirements", new DataColumnMapping[5]
      {
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("BindingRequirementID", "BindingRequirementID"),
        new DataColumnMapping("QuoteStatusID", "QuoteStatusID"),
        new DataColumnMapping("HardStop", "HardStop"),
        new DataColumnMapping("SoftStop", "SoftStop")
      })
    });
    this.daCompanyBindingRequirements.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = componentResourceManager.GetString("DbDeleteCommand1.CommandText");
    this.DbDeleteCommand1.Connection = this.cn;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_BindingRequirementID", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BindingRequirementID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteStatusID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteStatusID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cn;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[5]
    {
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@BindingRequirementID", SqlDbType.SmallInt, 2, "BindingRequirementID"),
      DefaultDatabase.CreateParameter("@QuoteStatusID", SqlDbType.Int, 4, "QuoteStatusID"),
      DefaultDatabase.CreateParameter("@HardStop", SqlDbType.Bit, 1, "HardStop"),
      DefaultDatabase.CreateParameter("@SoftStop", SqlDbType.Bit, 1, "SoftStop")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cn;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@companyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cn;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[8]
    {
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 0, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@BindingRequirementID", SqlDbType.SmallInt, 0, "BindingRequirementID"),
      DefaultDatabase.CreateParameter("@QuoteStatusID", SqlDbType.Int, 0, "QuoteStatusID"),
      DefaultDatabase.CreateParameter("@HardStop", SqlDbType.Bit, 0, "HardStop"),
      DefaultDatabase.CreateParameter("@SoftStop", SqlDbType.Bit, 0, "SoftStop"),
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_BindingRequirementID", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BindingRequirementID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuoteStatusID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteStatusID", DataRowVersion.Original, (object) null)
    });
    ((UltraGridBase) this.ddRequirements).DataSource = (object) this.ds.lstBindingRequirements;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.Gray;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 550;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ddRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddRequirements).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddRequirements).DisplayMember = "BindingRequirement";
    ((UltraDropDownBase) this.ddRequirements).DropDownWidth = 499;
    ((Control) this.ddRequirements).Location = new Point(56, 83);
    ((Control) this.ddRequirements).Name = "ddRequirements";
    ((Control) this.ddRequirements).Size = new Size(274, 86);
    ((Control) this.ddRequirements).TabIndex = 1;
    ((UltraControlBase) this.ddRequirements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddRequirements).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddRequirements).ValueMember = "BindingRequirementID";
    ((Control) this.ddRequirements).Visible = false;
    ((UltraGridBase) this.uddQuoteStatus).DataSource = (object) this.ds.lstQuoteStatus;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.Gray;
    ((UltraGridBase) this.uddQuoteStatus).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.uddQuoteStatus).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn14.Hidden = true;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ((UltraGridBase) this.uddQuoteStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.uddQuoteStatus).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.uddQuoteStatus).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.uddQuoteStatus).DisplayMember = "Description";
    ((UltraDropDownBase) this.uddQuoteStatus).DropDownWidth = 499;
    ((Control) this.uddQuoteStatus).Location = new Point(365, 83);
    ((Control) this.uddQuoteStatus).Name = "uddQuoteStatus";
    ((Control) this.uddQuoteStatus).Size = new Size(363, 86);
    ((Control) this.uddQuoteStatus).TabIndex = 2;
    ((UltraControlBase) this.uddQuoteStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.uddQuoteStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.uddQuoteStatus).ValueMember = "QuoteStatusID";
    ((Control) this.uddQuoteStatus).Visible = false;
    this.lnkAddRequirement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAddRequirement.AutoSize = true;
    this.lnkAddRequirement.Location = new Point(12, 436);
    this.lnkAddRequirement.Name = "lnkAddRequirement";
    this.lnkAddRequirement.Size = new Size(90, 13);
    this.lnkAddRequirement.TabIndex = 3;
    this.lnkAddRequirement.TabStop = true;
    this.lnkAddRequirement.Text = "Add Requirement";
    this.lnkCancelRequirement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCancelRequirement.AutoSize = true;
    this.lnkCancelRequirement.Location = new Point(12, 469);
    this.lnkCancelRequirement.Name = "lnkCancelRequirement";
    this.lnkCancelRequirement.Size = new Size(103, 13);
    this.lnkCancelRequirement.TabIndex = 4;
    this.lnkCancelRequirement.TabStop = true;
    this.lnkCancelRequirement.Text = "Cancel Requirement";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    appearance8.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image"));
    appearance8.ImageHAlign = (HAlign) 1;
    appearance8.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(803, 443);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(85, 40);
    ((Control) this.btnSave).TabIndex = 326;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopy.AutoSize = true;
    this.lnkCopy.Location = new Point(158, 438);
    this.lnkCopy.Name = "lnkCopy";
    this.lnkCopy.Size = new Size(212, 13);
    this.lnkCopy.TabIndex = 327;
    this.lnkCopy.TabStop = true;
    this.lnkCopy.Text = "Copy Requirements Across Company/Lines";
    ((Control) this.chkQuotingSoftStop).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkQuotingSoftStop).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkQuotingSoftStop).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkQuotingSoftStop).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkQuotingSoftStop).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkQuotingSoftStop).Location = new Point(516, 436);
    ((Control) this.chkQuotingSoftStop).Name = "chkQuotingSoftStop";
    ((Control) this.chkQuotingSoftStop).Size = new Size(204, 15);
    ((Control) this.chkQuotingSoftStop).TabIndex = 328;
    ((UltraToggleEditorBase) this.chkQuotingSoftStop).Text = "Soft Stop - Quoting Requirements";
    ((UltraControlBase) this.chkQuotingSoftStop).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkQuotingSoftStop).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkBindingSoftStop).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BorderColor = Color.Gray;
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkBindingSoftStop).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkBindingSoftStop).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBindingSoftStop).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBindingSoftStop).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkBindingSoftStop).Location = new Point(516, 468);
    ((Control) this.chkBindingSoftStop).Name = "chkBindingSoftStop";
    ((Control) this.chkBindingSoftStop).Size = new Size(204, 15);
    ((Control) this.chkBindingSoftStop).TabIndex = 329;
    ((UltraToggleEditorBase) this.chkBindingSoftStop).Text = "Soft Stop - Binding Requirements";
    ((UltraControlBase) this.chkBindingSoftStop).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkBindingSoftStop).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(900, 491);
    this.Controls.Add((Control) this.chkBindingSoftStop);
    this.Controls.Add((Control) this.chkQuotingSoftStop);
    this.Controls.Add((Control) this.lnkCopy);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkCancelRequirement);
    this.Controls.Add((Control) this.lnkAddRequirement);
    this.Controls.Add((Control) this.uddQuoteStatus);
    this.Controls.Add((Control) this.ddRequirements);
    this.Controls.Add((Control) this.ugRequirements);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmCompanyLineBindingRequirements);
    this.Text = "Requirements";
    ((ISupportInitialize) this.ugRequirements).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddRequirements).EndInit();
    ((ISupportInitialize) this.uddQuoteStatus).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.chkQuotingSoftStop).EndInit();
    ((ISupportInitialize) this.chkBindingSoftStop).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmCompanyLineBindingRequirements(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyLineBindingRequirements_Load);
    this.Closed += new EventHandler(this.frmCompanyLineBindingRequirements_Closed);
    this._lstDeletedRequirementID = new List<string>();
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._companyLine = new CompanyLine(companyLineID);
  }

  private void frmCompanyLineBindingRequirements_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "lstBindingRequirements",
      "lstQuoteStatus",
      "tblCompanyLineBindingRequirements"
    }, "spGetCompanyLineRequirements", new object[2]
    {
      (object) "@CompanyLineID",
      (object) this._companyLineID
    });
    this._showStop = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("CompanyLineRequirements.ImplementSoftStops");
    ((Control) this.chkBindingSoftStop).Visible = this._showStop;
    ((Control) this.chkQuotingSoftStop).Visible = this._showStop;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Bands[0].Columns["HardStop"].Hidden = !this._showStop;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Bands[0].Columns["SoftStop"].Hidden = !this._showStop;
    this.SetStops();
  }

  private void ugRequirements_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyLineID"].Value = (object) this._companyLineID;
  }

  private void ugRequirements_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["BindingRequirementID"].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void frmCompanyLineBindingRequirements_Closed(object sender, EventArgs e)
  {
    this.ugRequirements.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ugRequirements).ActiveRow != null)
      ((UltraGridBase) this.ugRequirements).ActiveRow.Update();
    ((UltraGridBase) this.ugRequirements).UpdateData();
    if (!this.ds.HasChanges() || MessageBox.Show("Save changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.LogModification();
    this.SaveStops();
    DefaultDatabase.DataAdapterUpdate(this.daCompanyBindingRequirements, (DataTable) this.ds.tblCompanyLineBindingRequirements);
  }

  private void lnkAddRequirement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    UltraGridRow ultraGridRow = ((UltraGridBase) this.ugRequirements).DisplayLayout.Bands[0].AddNew();
    ultraGridRow.Cells["CompanyLineID"].Value = (object) this._companyLineID;
    ultraGridRow.Cells["HardStop"].Value = (object) true;
    ultraGridRow.Cells["SoftStop"].Value = (object) false;
  }

  private void lnkCancelRequirement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ugRequirements.DeleteSelectedRows();
    ((UltraGridBase) this.ugRequirements).UpdateData();
  }

  private bool IsValidForm()
  {
    bool flag1 = true;
    bool flag2;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRequirements).Rows)
    {
      if (row.Cells["BindingRequirementID"].Value == DBNull.Value || row.Cells["BindingRequirementID"].Value == null)
      {
        int num = (int) MessageBox.Show("Requirement is missing\n\nPlease enter a value.", "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag1 = false;
        break;
      }
      if (row.Cells["QuoteStatusID"].Value == DBNull.Value || row.Cells["QuoteStatusID"].Value == null)
      {
        int num = (int) MessageBox.Show("Event is missing.\n\nPlease enter a value.", "Missing Event", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag1 = false;
        break;
      }
      if (this._showStop)
      {
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["HardStop"].Value)) && Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["SoftStop"].Value)))
        {
          int num = (int) MessageBox.Show("Hard and soft stops are not supposed to be empty.\n\nPlease choose one.", "Empty Stops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag2 = false;
          goto label_15;
        }
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["HardStop"].Value)) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["SoftStop"].Value)))
        {
          if (Conversions.ToBoolean(row.Cells["HardStop"].Value) && Conversions.ToBoolean(row.Cells["SoftStop"].Value))
          {
            int num = (int) MessageBox.Show("Both hard and soft stops are not supposed to be true.\n\nPlease choose one.", "Both True Stops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag2 = false;
            goto label_15;
          }
          if (!Conversions.ToBoolean(row.Cells["HardStop"].Value) && !Conversions.ToBoolean(row.Cells["SoftStop"].Value))
          {
            int num = (int) MessageBox.Show("Both hard and soft stops are not supposed to be false.\n\nPlease choose one.", "Both False Stops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag2 = false;
            goto label_15;
          }
        }
      }
    }
    flag2 = flag1;
label_15:
    return flag2;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidForm())
      return;
    this.LogModification();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate(this.daCompanyBindingRequirements, (DataTable) this.ds.tblCompanyLineBindingRequirements);
      this.SaveStops();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  private void LogModification()
  {
    StringBuilder stringBuilder = new StringBuilder();
    try
    {
      foreach (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow row in this.ds.tblCompanyLineBindingRequirements.Rows)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmCompanyLineBindingRequirements._Closure\u0024__57\u002D0 closure570 = new frmCompanyLineBindingRequirements._Closure\u0024__57\u002D0(closure570);
        // ISSUE: reference to a compiler-generated field
        closure570.\u0024VB\u0024Local_row = row;
        // ISSUE: reference to a compiler-generated field
        if (closure570.\u0024VB\u0024Local_row.RowState == DataRowState.Deleted)
        {
          try
          {
            foreach (string str in this._lstDeletedRequirementID)
              stringBuilder.Append($"BindingRequirement: {str} Deleted\n");
          }
          finally
          {
            List<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          this._lstDeletedRequirementID.Clear();
        }
        // ISSUE: reference to a compiler-generated field
        if (closure570.\u0024VB\u0024Local_row.RowState == DataRowState.Added)
        {
          // ISSUE: reference to a compiler-generated method
          string bindingRequirement = this.ds.lstBindingRequirements.Where<dsCompanyLineBindingRequirements.lstBindingRequirementsRow>(new System.Func<dsCompanyLineBindingRequirements.lstBindingRequirementsRow, bool>(closure570._Lambda\u0024__0)).FirstOrDefault<dsCompanyLineBindingRequirements.lstBindingRequirementsRow>().BindingRequirement;
          stringBuilder.Append($"BindingRequirement: {bindingRequirement} Added\n");
        }
        // ISSUE: reference to a compiler-generated field
        if (closure570.\u0024VB\u0024Local_row.RowState == DataRowState.Modified)
        {
          // ISSUE: reference to a compiler-generated method
          string bindingRequirement = this.ds.lstBindingRequirements.Where<dsCompanyLineBindingRequirements.lstBindingRequirementsRow>(new System.Func<dsCompanyLineBindingRequirements.lstBindingRequirementsRow, bool>(closure570._Lambda\u0024__1)).FirstOrDefault<dsCompanyLineBindingRequirements.lstBindingRequirementsRow>().BindingRequirement;
          stringBuilder.Append($"BindingRequirement: {bindingRequirement} Modified\n");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    CurrentUser.Instance.LogAction(stringBuilder.ToString(), this._companyLine.CompanyLineGuid, "CompanyLineGuid");
  }

  private void lnkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this._companyLine.HasRequirements)
    {
      int num = (int) MessageBox.Show("The current company/line has no requirements", "No Requirements on Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this.Close();
      FormSettings.ShowForm(typeof (FormCopyCompanyLineRequirements), (object) this._companyLineID);
    }
  }

  private void SetStops()
  {
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "Select QuotingSoftStop, BindingSoftStop from tblCompanyLineBindingReqStops where CompanyLineID = @ID", new object[2]
    {
      (object) "@ID",
      (object) this._companyLineID
    });
    if (row == null)
      return;
    if (!row.IsNull("QuotingSoftStop"))
      ((UltraToggleEditorBase) this.chkQuotingSoftStop).Checked = row.Field<bool>("QuotingSoftStop");
    if (row.IsNull("BindingSoftStop"))
      return;
    ((UltraToggleEditorBase) this.chkBindingSoftStop).Checked = row.Field<bool>("BindingSoftStop");
  }

  private void SaveStops()
  {
    DefaultDatabase.ExecuteNonQuery("spSaveCompanyLineRequirementStops", new object[6]
    {
      (object) "@QuotingSoftStop",
      (object) ((UltraToggleEditorBase) this.chkQuotingSoftStop).Checked,
      (object) "@BindingSoftStop",
      (object) ((UltraToggleEditorBase) this.chkBindingSoftStop).Checked,
      (object) "@CompanyLineID",
      (object) this._companyLineID
    });
  }

  private void ugRequirements_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    this._lstDeletedRequirementID.Clear();
    UltraGridRow[] rows = e.Rows;
    int index = 0;
    while (index < rows.Length)
    {
      this._lstDeletedRequirementID.Add(rows[index].Cells["BindingRequirementID"].Text);
      checked { ++index; }
    }
  }
}
