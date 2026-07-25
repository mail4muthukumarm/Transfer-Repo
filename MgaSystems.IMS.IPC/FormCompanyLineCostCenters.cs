// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCompanyLineCostCenters
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCompanyLineCostCenters : Form
{
  private IContainer components;
  private Guid _companyLineGuid;
  private BindingManagerBase _bmb;
  private string _companyLineName;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCompanyLineCostCenters));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblEntityGroups", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GroupId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GroupDescription");
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLineCostCenters", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GroupID", -1, (object) "ddCostCenters");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("IsDefault");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Disabled");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.sqlCommand3 = DefaultDatabase.CreateCommand();
    this.sqlCommand6 = DefaultDatabase.CreateCommand();
    this.sqlCommand7 = DefaultDatabase.CreateCommand();
    this.sqlCommand8 = DefaultDatabase.CreateCommand();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.chkDefault = new MGACheckBox();
    this.dtEffectiveDate = new MGADateTimePicker();
    this.ds = new dsCompanyLineCostCenter();
    this.chkDisable = new MGACheckBox();
    this.err = new ErrorProvider(this.components);
    this.cboCostCenter = new MGASimpleComboBox();
    this.ddCostCenters = new UltraDropDown();
    this.ugCompanyLineCostCenters = new UltraGrid();
    UltraLabel ultraLabel1 = new UltraLabel();
    UltraLabel ultraLabel2 = new UltraLabel();
    ((ISupportInitialize) this.chkDefault).BeginInit();
    ((ISupportInitialize) this.dtEffectiveDate).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.chkDisable).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.cboCostCenter).BeginInit();
    ((ISupportInitialize) this.ddCostCenters).BeginInit();
    ((ISupportInitialize) this.ugCompanyLineCostCenters).BeginInit();
    this.SuspendLayout();
    ((Control) ultraLabel1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AutoSizeControlBase) ultraLabel1).AutoSize = true;
    ((ControlBase) ultraLabel1).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel1).Location = new Point(27, 184);
    ((Control) ultraLabel1).Name = "UltraLabel2";
    ((Control) ultraLabel1).Size = new Size(68, 14);
    ((Control) ultraLabel1).TabIndex = 376;
    ((ControlBase) ultraLabel1).Text = "Cost Center:";
    ((Control) ultraLabel2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AutoSizeControlBase) ultraLabel2).AutoSize = true;
    ((ControlBase) ultraLabel2).BackColorInternal = Color.Transparent;
    ((Control) ultraLabel2).Location = new Point(17, 220);
    ((Control) ultraLabel2).Name = "UltraLabel1";
    ((Control) ultraLabel2).Size = new Size(78, 14);
    ((Control) ultraLabel2).TabIndex = 377;
    ((ControlBase) ultraLabel2).Text = "Effective Date:";
    this.da.DeleteCommand = this.sqlCommand3;
    this.da.InsertCommand = this.sqlCommand6;
    this.da.SelectCommand = this.sqlCommand7;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineCostCenters", new DataColumnMapping[6]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("GroupID", "GroupID"),
        new DataColumnMapping("EffectiveDate", "EffectiveDate"),
        new DataColumnMapping("Disabled", "Disabled"),
        new DataColumnMapping("IsDefault", "IsDefault")
      })
    });
    this.da.UpdateCommand = this.sqlCommand8;
    this.sqlCommand3.CommandText = "DELETE FROM [dbo].[tblCompanyLineCostCenters] WHERE (([ID] = @Original_ID))";
    this.sqlCommand3.Connection = this.cn;
    this.sqlCommand3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.sqlCommand6.CommandText = componentResourceManager.GetString("sqlCommand6.CommandText");
    this.sqlCommand6.Connection = this.cn;
    this.sqlCommand6.Parameters.AddRange((Array) new DbParameter[5]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@GroupID", SqlDbType.Int, 4, "GroupID"),
      DefaultDatabase.CreateParameter("@EffectiveDate", SqlDbType.SmallDateTime, 4, "EffectiveDate"),
      DefaultDatabase.CreateParameter("@IsDefault", SqlDbType.Bit, 1, "IsDefault"),
      DefaultDatabase.CreateParameter("@Disabled", SqlDbType.Bit, 1, "Disabled")
    });
    this.sqlCommand7.CommandText = componentResourceManager.GetString("sqlCommand7.CommandText");
    this.sqlCommand7.Connection = this.cn;
    this.sqlCommand7.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    this.sqlCommand8.CommandText = componentResourceManager.GetString("sqlCommand8.CommandText");
    this.sqlCommand8.Connection = this.cn;
    this.sqlCommand8.Parameters.AddRange((Array) new DbParameter[7]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@GroupID", SqlDbType.Int, 4, "GroupID"),
      DefaultDatabase.CreateParameter("@EffectiveDate", SqlDbType.SmallDateTime, 4, "EffectiveDate"),
      DefaultDatabase.CreateParameter("@IsDefault", SqlDbType.Bit, 1, "IsDefault"),
      DefaultDatabase.CreateParameter("@Disabled", SqlDbType.Bit, 1, "Disabled"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(388, 259);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 4;
    ((Control) this.chkDefault).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDefault).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkDefault).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDefault).BackColorInternal = Color.Transparent;
    ((Control) this.chkDefault).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineCostCenters.IsDefault", true));
    ((UltraToggleEditorBase) this.chkDefault).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDefault).Location = new Point(252, 215);
    ((Control) this.chkDefault).Name = "chkDefault";
    ((Control) this.chkDefault).Size = new Size(71, 24);
    ((Control) this.chkDefault).TabIndex = 2;
    ((UltraToggleEditorBase) this.chkDefault).Text = "Default";
    ((UltraControlBase) this.chkDefault).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDefault).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dtEffectiveDate).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffectiveDate.Appearance = (AppearanceBase) appearance2;
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
    this.dtEffectiveDate.ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.dtEffectiveDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCostCenters.EffectiveDate", true));
    ((Control) this.dtEffectiveDate).Location = new Point(101, 218);
    this.dtEffectiveDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffectiveDate).Name = "dtEffectiveDate";
    ((Control) this.dtEffectiveDate).Size = new Size(98, 19);
    ((Control) this.dtEffectiveDate).TabIndex = 1;
    ((UltraControlBase) this.dtEffectiveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffectiveDate).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineCostCenter";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.chkDisable).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisable).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkDisable).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisable).BackColorInternal = Color.Transparent;
    ((Control) this.chkDisable).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblCompanyLineCostCenters.Disabled", true));
    ((UltraToggleEditorBase) this.chkDisable).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisable).Location = new Point(381, 215);
    ((Control) this.chkDisable).Name = "chkDisable";
    ((Control) this.chkDisable).Size = new Size(74, 24);
    ((Control) this.chkDisable).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkDisable).Text = "Disabled";
    ((UltraControlBase) this.chkDisable).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDisable).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.cboCostCenter).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboCostCenter).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineCostCenters.GroupID", true));
    ((UltraGridBase) this.cboCostCenter).DataMember = "tblEntityGroups";
    ((UltraGridBase) this.cboCostCenter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCostCenter).DisplayMember = "GroupDescription";
    this.cboCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCostCenter).DropDownWidth = 250;
    ((Control) this.cboCostCenter).Location = new Point(101, 181);
    this.cboCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCostCenter).Name = "cboCostCenter";
    ((Control) this.cboCostCenter).Size = new Size(354, 20);
    ((Control) this.cboCostCenter).TabIndex = 0;
    ((UltraControlBase) this.cboCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCostCenter).ValueMember = "GroupId";
    ((UltraGridBase) this.ddCostCenters).DataMember = "tblEntityGroups";
    ((UltraGridBase) this.ddCostCenters).DataSource = (object) this.ds;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 326;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddCostCenters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddCostCenters).DisplayMember = "GroupDescription";
    ((UltraDropDownBase) this.ddCostCenters).DropDownWidth = 326;
    ((Control) this.ddCostCenters).Location = new Point(134, 46);
    ((Control) this.ddCostCenters).Name = "ddCostCenters";
    ((Control) this.ddCostCenters).Size = new Size(140, 56);
    ((Control) this.ddCostCenters).TabIndex = 371;
    ((UltraDropDownBase) this.ddCostCenters).ValueMember = "GroupId";
    ((Control) this.ddCostCenters).Visible = false;
    ((Control) this.ugCompanyLineCostCenters).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DataMember = "tblCompanyLineCostCenters";
    ((UltraGridBase) this.ugCompanyLineCostCenters).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.AddNewBox).Prompt = " Add ...";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.AddButtonCaption = "Cost Center";
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Cost Center";
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Style = (ColumnStyle) 6;
    ultraGridColumn5.Width = 237;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Effective Date";
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 101;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Default";
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Width = 62;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 5;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.WhiteSmoke;
    appearance13.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugCompanyLineCostCenters).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugCompanyLineCostCenters).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugCompanyLineCostCenters).Location = new Point(4, 6);
    ((Control) this.ugCompanyLineCostCenters).Name = "ugCompanyLineCostCenters";
    ((Control) this.ugCompanyLineCostCenters).Size = new Size(496, 169);
    ((Control) this.ugCompanyLineCostCenters).TabIndex = 360;
    ((UltraControlBase) this.ugCompanyLineCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCompanyLineCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(505, 311);
    this.Controls.Add((Control) this.chkDisable);
    this.Controls.Add((Control) ultraLabel2);
    this.Controls.Add((Control) ultraLabel1);
    this.Controls.Add((Control) this.dtEffectiveDate);
    this.Controls.Add((Control) this.chkDefault);
    this.Controls.Add((Control) this.cboCostCenter);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddCostCenters);
    this.Controls.Add((Control) this.ugCompanyLineCostCenters);
    this.Name = nameof (FormCompanyLineCostCenters);
    this.Text = "Company / Line Cost Centers";
    ((ISupportInitialize) this.chkDefault).EndInit();
    ((ISupportInitialize) this.dtEffectiveDate).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.chkDisable).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.cboCostCenter).EndInit();
    ((ISupportInitialize) this.ddCostCenters).EndInit();
    ((ISupportInitialize) this.ugCompanyLineCostCenters).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraGrid ugCompanyLineCostCenters
  {
    get => this._ugCompanyLineCostCenters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugCompanyLineCostCenters_AfterRowActivate);
      UltraGrid companyLineCostCenters1 = this._ugCompanyLineCostCenters;
      if (companyLineCostCenters1 != null)
        companyLineCostCenters1.AfterRowActivate -= eventHandler;
      this._ugCompanyLineCostCenters = value;
      UltraGrid companyLineCostCenters2 = this._ugCompanyLineCostCenters;
      if (companyLineCostCenters2 == null)
        return;
      companyLineCostCenters2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cn")]
  private virtual DbConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual DbDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand3")]
  private virtual DbCommand sqlCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand6")]
  private virtual DbCommand sqlCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand7")]
  private virtual DbCommand sqlCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand8")]
  private virtual DbCommand sqlCommand8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCostCenters")]
  private virtual UltraDropDown ddCostCenters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLineCostCenter ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.UIStateChanged -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("cboCostCenter")]
  private virtual MGASimpleComboBox cboCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDefault")]
  private virtual MGACheckBox chkDefault { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffectiveDate")]
  internal virtual MGADateTimePicker dtEffectiveDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDisable")]
  private virtual MGACheckBox chkDisable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public string CompanyLineName
  {
    get
    {
      if (this._companyLineName.Equals(string.Empty))
        this._companyLineName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT CompanyLine FROM tblCompanylines WITH (NOLOCK) WHERE CompanyLineGuid = @CLG", new object[2]
        {
          (object) "@CLG",
          (object) this._companyLineGuid
        });
      return this._companyLineName;
    }
  }

  public FormCompanyLineCostCenters(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.FormCompanyLineCostCenters_Load);
    this._companyLineName = string.Empty;
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
  }

  private void FormCompanyLineCostCenters_Load(object sender, EventArgs e)
  {
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblCompanyLineCostCenters.TableName];
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblEntityGroups"
    }, "GetCompanyLineCostCenters");
    this.da.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
    DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.tblCompanyLineCostCenters);
    this.SetSaveState();
  }

  private void ugCompanyLineCostCenters_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugCompanyLineCostCenters).ActiveRow == null)
      return;
    Database.MoveTo((object) Conversions.ToInteger(((UltraGridBase) this.ugCompanyLineCostCenters).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.tblCompanyLineCostCenters, this._bmb);
    ((UltraGridBase) this.ugCompanyLineCostCenters).UpdateData();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblCompanyLineCostCenters.RejectChanges();
    ((UltraGridBase) this.ugCompanyLineCostCenters).UpdateData();
  }

  private void SetSaveState()
  {
    if (this.ds.tblCompanyLineCostCenters.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void EnableControls(bool enabled)
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control != this.dbSave && control != this.ugCompanyLineCostCenters)
          control.Enabled = enabled;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete the current cost center setup?", "Delete Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
      e.Cancel = true;
    else if (this._bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a setup in the grid to delete.", "No Setup Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      if (!this.ds.tblCompanyLineCostCenters[this._bmb.Position].IsGroupIDNull())
        str1 = this.ds.tblEntityGroups.FindByGroupId(this.ds.tblCompanyLineCostCenters[this._bmb.Position].GroupID).GroupDescription;
      if (!this.ds.tblCompanyLineCostCenters[this._bmb.Position].IsEffectiveDateNull())
        str2 = this.ds.tblCompanyLineCostCenters[this._bmb.Position].EffectiveDate.ToShortDateString();
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        this.ds.tblCompanyLineCostCenters[this._bmb.Position].Delete();
        DefaultDatabase.DataAdapterUpdate(this.da, (DataTable) this.ds.tblCompanyLineCostCenters);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      CurrentUser.Instance.LogAction($"Deleted Cost Center '{str1}' effective '{str2}' on Company/line - {this.CompanyLineName}", this._companyLineGuid, "Company/Line");
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsCompanyLineCostCenter.tblCompanyLineCostCentersRow row = this.ds.tblCompanyLineCostCenters.NewtblCompanyLineCostCentersRow();
    row.CompanyLineGuid = this._companyLineGuid;
    this.ds.tblCompanyLineCostCenters.AddtblCompanyLineCostCentersRow(row);
    this._bmb.Position = this.ds.tblCompanyLineCostCenters.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidSetup())
      e.Cancel = true;
    else if (this._bmb.Position == -1)
    {
      e.Cancel = true;
    }
    else
    {
      int num = this.ds.tblCompanyLineCostCenters[this._bmb.Position].RowState == DataRowState.Added ? 1 : 0;
      int position = this._bmb.Position;
      this._bmb.EndCurrentEdit();
      DefaultDatabase.DataAdapterUpdate(this.da, (DataTable) this.ds.tblCompanyLineCostCenters);
      ((UltraGridBase) this.ugCompanyLineCostCenters).UpdateData();
      if (num == 0)
        return;
      string str1 = string.Empty;
      string str2 = string.Empty;
      if (!this.ds.tblCompanyLineCostCenters[position].IsGroupIDNull())
        str1 = this.ds.tblEntityGroups.FindByGroupId(this.ds.tblCompanyLineCostCenters[position].GroupID).GroupDescription;
      if (!this.ds.tblCompanyLineCostCenters[position].IsEffectiveDateNull())
        str2 = this.ds.tblCompanyLineCostCenters[position].EffectiveDate.ToShortDateString();
      CurrentUser.Instance.LogAction($"Added Cost Center '{str1}' effective '{str2}' on Company/line - {this.CompanyLineName}", this._companyLineGuid, "Company/Line");
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.EnableControls(this.dbSave.UIState == UIState.Editing);
    if (this.dbSave.UIState == UIState.Editing)
      return;
    this.SetSaveState();
  }

  private bool ValidSetup()
  {
    bool flag = true;
    if (this.cboCostCenter.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboCostCenter, "Please select a value from the list");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboCostCenter, string.Empty);
    if (this.dtEffectiveDate.Value != DBNull.Value && this.dtEffectiveDate.Value != null)
    {
      this.err.SetError((Control) this.dtEffectiveDate, string.Empty);
    }
    else
    {
      this.err.SetError((Control) this.dtEffectiveDate, "Please enter a value");
      flag = false;
    }
    return flag;
  }
}
