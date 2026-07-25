// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormBrokerProductionGoals
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormBrokerProductionGoals : Form
{
  private IContainer components;
  private Guid _producerLocationGUID;
  private Guid _producerGUID;
  private bool _isNewRow;

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
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormBrokerProductionGoals));
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtYear", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("YearName");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstPolicyTypes", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    UltraGridBand ultraGridBand4 = new UltraGridBand("dtMonth", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Month");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("MonthName");
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerName");
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Name");
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblProductionGoal", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PremiumGoal");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ProducerLocationGUID", -1, (object) "ddProducerLocation");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ProducerGUID", -1, (object) "ddProducer");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("GoalMonth", -1, (object) "ddMonth");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("GoalYear", -1, (object) "ddYear");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ProducerLevel");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("PolicyTypeID", -1, (object) "ddPolicyType");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LineGUID", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("CompanyGroupGuid");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.numPremiumGoal = new MGANumericEditor();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.err = new ErrorProvider(this.components);
    this.cn = new SqlConnection();
    this.daProductionGoal = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.Label3 = new Label();
    this.rbLocationLevel = new RadioButton();
    this.rbProducerLevel = new RadioButton();
    this.panelProdGoals = new Panel();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lblCompanyGroup = new Label();
    this.ddLines = new UltraDropDown();
    this.ds = new dsProductionGoal();
    this.ddYear = new UltraDropDown();
    this.ddPolicyType = new UltraDropDown();
    this.ddMonth = new UltraDropDown();
    this.ddProducer = new UltraDropDown();
    this.ddProducerLocation = new UltraDropDown();
    this.cboGroup = new MGASimpleComboBox();
    this.cboLOB = new MGASimpleComboBox();
    this.cboPolicyType = new MGASimpleComboBox();
    this.cboMonth = new MGASimpleComboBox();
    this.cboYear = new MGASimpleComboBox();
    this.dg = new UltraGrid();
    ((ISupportInitialize) this.numPremiumGoal).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.panelProdGoals.SuspendLayout();
    ((ISupportInitialize) this.ddLines).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddYear).BeginInit();
    ((ISupportInitialize) this.ddPolicyType).BeginInit();
    ((ISupportInitialize) this.ddMonth).BeginInit();
    ((ISupportInitialize) this.ddProducer).BeginInit();
    ((ISupportInitialize) this.ddProducerLocation).BeginInit();
    ((ISupportInitialize) this.cboGroup).BeginInit();
    ((ISupportInitialize) this.cboLOB).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    ((ISupportInitialize) this.cboMonth).BeginInit();
    ((ISupportInitialize) this.cboYear).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    this.SuspendLayout();
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPremiumGoal).Appearance = (AppearanceBase) appearance1;
    ((UltraNumericEditorBase) this.numPremiumGoal).FormatString = "c";
    ((Control) this.numPremiumGoal).Location = new Point(620, 9);
    this.numPremiumGoal.MaskInput = "nnnnnnnnnnnnnnn.nn";
    this.numPremiumGoal.MaxValue = (object) 1E+15;
    this.numPremiumGoal.MGAStyle = MGAStyles.Blue;
    ((Control) this.numPremiumGoal).Name = "numPremiumGoal";
    this.numPremiumGoal.Nullable = true;
    this.numPremiumGoal.NumericType = (NumericType) 1;
    ((Control) this.numPremiumGoal).Size = new Size(141, 19);
    ((Control) this.numPremiumGoal).TabIndex = 5;
    ((UltraControlBase) this.numPremiumGoal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPremiumGoal).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(33, 12);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(40, 13);
    this.Label1.TabIndex = 14;
    this.Label1.Text = "Month:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(516, 12);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(98, 13);
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Expected Premium:";
    this.err.ContainerControl = (ContainerControl) this;
    this.cn.ConnectionString = "Data Source=mgasystems;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daProductionGoal.DeleteCommand = this.SqlDeleteCommand1;
    this.daProductionGoal.InsertCommand = this.SqlInsertCommand1;
    this.daProductionGoal.SelectCommand = this.SqlSelectCommand1;
    this.daProductionGoal.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProductionGoal", new DataColumnMapping[10]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("PremiumGoal", "PremiumGoal"),
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("ProducerGUID", "ProducerGUID"),
        new DataColumnMapping("GoalMonth", "GoalMonth"),
        new DataColumnMapping("GoalYear", "GoalYear"),
        new DataColumnMapping("ProducerLevel", "ProducerLevel"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("CompanyGroupGuid", "CompanyGroupGuid")
      })
    });
    this.daProductionGoal.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblProductionGoal] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@PremiumGoal", SqlDbType.Money, 0, "PremiumGoal"),
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 0, "ProducerGUID"),
      new SqlParameter("@GoalMonth", SqlDbType.TinyInt, 0, "GoalMonth"),
      new SqlParameter("@GoalYear", SqlDbType.Int, 0, "GoalYear"),
      new SqlParameter("@ProducerLevel", SqlDbType.Char, 0, "ProducerLevel"),
      new SqlParameter("@PolicyTypeID", SqlDbType.TinyInt, 0, "PolicyTypeID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 0, "LineGUID"),
      new SqlParameter("@CompanyGroupGuid", SqlDbType.UniqueIdentifier, 0, "CompanyGroupGuid")
    });
    this.SqlSelectCommand1.CommandText = "SELECT        ID, PremiumGoal, ProducerLocationGUID, ProducerGUID, GoalMonth, GoalYear, ProducerLevel, PolicyTypeID, LineGUID, CompanyGroupGuid\r\nFROM            dbo.tblProductionGoal";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@PremiumGoal", SqlDbType.Money, 0, "PremiumGoal"),
      new SqlParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGUID"),
      new SqlParameter("@ProducerGUID", SqlDbType.UniqueIdentifier, 0, "ProducerGUID"),
      new SqlParameter("@GoalMonth", SqlDbType.TinyInt, 0, "GoalMonth"),
      new SqlParameter("@GoalYear", SqlDbType.Int, 0, "GoalYear"),
      new SqlParameter("@ProducerLevel", SqlDbType.Char, 0, "ProducerLevel"),
      new SqlParameter("@PolicyTypeID", SqlDbType.TinyInt, 0, "PolicyTypeID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 0, "LineGUID"),
      new SqlParameter("@CompanyGroupGuid", SqlDbType.UniqueIdentifier, 0, "CompanyGroupGuid"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(41, 38);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(32 /*0x20*/, 13);
    this.Label3.TabIndex = 21;
    this.Label3.Text = "Year:";
    this.rbLocationLevel.BackColor = Color.Transparent;
    this.rbLocationLevel.Checked = true;
    this.rbLocationLevel.Location = new Point(336, 35);
    this.rbLocationLevel.Name = "rbLocationLevel";
    this.rbLocationLevel.Size = new Size(187, 19);
    this.rbLocationLevel.TabIndex = 9;
    this.rbLocationLevel.TabStop = true;
    this.rbLocationLevel.Text = "Save on Producer Location Level";
    this.rbLocationLevel.UseVisualStyleBackColor = false;
    this.rbProducerLevel.BackColor = Color.Transparent;
    this.rbProducerLevel.Location = new Point(336, 9);
    this.rbProducerLevel.Name = "rbProducerLevel";
    this.rbProducerLevel.Size = new Size(152, 18);
    this.rbProducerLevel.TabIndex = 4;
    this.rbProducerLevel.Text = "Save on Producer Level";
    this.rbProducerLevel.UseVisualStyleBackColor = false;
    this.panelProdGoals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.panelProdGoals.BackColor = Color.Transparent;
    this.panelProdGoals.BorderStyle = BorderStyle.Fixed3D;
    this.panelProdGoals.Controls.Add((Control) this.lblCompanyGroup);
    this.panelProdGoals.Controls.Add((Control) this.cboGroup);
    this.panelProdGoals.Controls.Add((Control) this.Label5);
    this.panelProdGoals.Controls.Add((Control) this.cboLOB);
    this.panelProdGoals.Controls.Add((Control) this.Label4);
    this.panelProdGoals.Controls.Add((Control) this.cboPolicyType);
    this.panelProdGoals.Controls.Add((Control) this.numPremiumGoal);
    this.panelProdGoals.Controls.Add((Control) this.Label2);
    this.panelProdGoals.Controls.Add((Control) this.rbLocationLevel);
    this.panelProdGoals.Controls.Add((Control) this.cboMonth);
    this.panelProdGoals.Controls.Add((Control) this.rbProducerLevel);
    this.panelProdGoals.Controls.Add((Control) this.Label1);
    this.panelProdGoals.Controls.Add((Control) this.Label3);
    this.panelProdGoals.Controls.Add((Control) this.cboYear);
    this.panelProdGoals.Location = new Point(12, 286);
    this.panelProdGoals.Name = "panelProdGoals";
    this.panelProdGoals.Size = new Size(813, 115);
    this.panelProdGoals.TabIndex = 0;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(42, 64 /*0x40*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(31 /*0x1F*/, 13);
    this.Label5.TabIndex = 27;
    this.Label5.Text = "LOB:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(549, 38);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(65, 13);
    this.Label4.TabIndex = 25;
    this.Label4.Text = "Policy Type:";
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(717, 407);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 27;
    this.lblCompanyGroup.AutoSize = true;
    this.lblCompanyGroup.BackColor = Color.Transparent;
    this.lblCompanyGroup.Location = new Point(6, 90);
    this.lblCompanyGroup.Name = "lblCompanyGroup";
    this.lblCompanyGroup.Size = new Size(86, 13);
    this.lblCompanyGroup.TabIndex = 29;
    this.lblCompanyGroup.Text = "Company Group:";
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 200;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(173, 166);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(140, 56);
    ((Control) this.ddLines).TabIndex = 218;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    this.ds.DataSetName = "dsProductionGoal";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddYear).DataMember = "dtYear";
    ((UltraGridBase) this.ddYear).DataSource = (object) this.ds;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddYear).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddYear).DisplayMember = "YearName";
    ((Control) this.ddYear).Location = new Point(362, 128 /*0x80*/);
    ((Control) this.ddYear).Name = "ddYear";
    ((Control) this.ddYear).Size = new Size(140, 56);
    ((Control) this.ddYear).TabIndex = 217;
    ((UltraDropDownBase) this.ddYear).ValueMember = "Year";
    ((Control) this.ddYear).Visible = false;
    ((UltraGridBase) this.ddPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.ddPolicyType).DataSource = (object) this.ds;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddPolicyType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddPolicyType).DisplayMember = "Description";
    ((Control) this.ddPolicyType).Location = new Point(483, 105);
    ((Control) this.ddPolicyType).Name = "ddPolicyType";
    ((Control) this.ddPolicyType).Size = new Size(140, 56);
    ((Control) this.ddPolicyType).TabIndex = 216;
    ((UltraDropDownBase) this.ddPolicyType).ValueMember = "PolicyTypeID";
    ((Control) this.ddPolicyType).Visible = false;
    ((UltraGridBase) this.ddMonth).DataMember = "dtMonth";
    ((UltraGridBase) this.ddMonth).DataSource = (object) this.ds;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddMonth).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddMonth).DisplayMember = "MonthName";
    ((Control) this.ddMonth).Location = new Point(23, 105);
    ((Control) this.ddMonth).Name = "ddMonth";
    ((Control) this.ddMonth).Size = new Size(140, 56);
    ((Control) this.ddMonth).TabIndex = 215;
    ((UltraDropDownBase) this.ddMonth).ValueMember = "Month";
    ((Control) this.ddMonth).Visible = false;
    ((UltraGridBase) this.ddProducer).DataMember = "tblProducers";
    ((UltraGridBase) this.ddProducer).DataSource = (object) this.ds;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddProducer).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddProducer).DisplayMember = "ProducerName";
    ((Control) this.ddProducer).Location = new Point(319, 94);
    ((Control) this.ddProducer).Name = "ddProducer";
    ((Control) this.ddProducer).Size = new Size(140, 56);
    ((Control) this.ddProducer).TabIndex = 214;
    ((UltraDropDownBase) this.ddProducer).ValueMember = "ProducerGUID";
    ((Control) this.ddProducer).Visible = false;
    ((UltraGridBase) this.ddProducerLocation).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.ddProducerLocation).DataSource = (object) this.ds;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.ddProducerLocation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraDropDownBase) this.ddProducerLocation).DisplayMember = "Name";
    ((Control) this.ddProducerLocation).Location = new Point(173, 94);
    ((Control) this.ddProducerLocation).Name = "ddProducerLocation";
    ((Control) this.ddProducerLocation).Size = new Size(140, 56);
    ((Control) this.ddProducerLocation).TabIndex = 213;
    ((UltraDropDownBase) this.ddProducerLocation).ValueMember = "ProducerLocationGUID";
    ((Control) this.ddProducerLocation).Visible = false;
    this.cboGroup.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboGroup).DataMember = "tblCompanyGroups";
    ((UltraGridBase) this.cboGroup).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboGroup).DisplayMember = "CompanyGroupName";
    this.cboGroup.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboGroup).Location = new Point(107, 86);
    this.cboGroup.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboGroup).Name = "cboGroup";
    ((Control) this.cboGroup).Size = new Size(216, 20);
    ((Control) this.cboGroup).TabIndex = 3;
    ((UltraControlBase) this.cboGroup).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboGroup).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboGroup).ValueMember = "CompanyGroupGuid";
    this.cboLOB.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboLOB).DataMember = "lstLines";
    ((UltraGridBase) this.cboLOB).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLOB).DisplayMember = "LineName";
    this.cboLOB.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLOB).DropDownWidth = 450;
    ((Control) this.cboLOB).Location = new Point(107, 60);
    this.cboLOB.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLOB).Name = "cboLOB";
    ((Control) this.cboLOB).Size = new Size(216, 20);
    ((Control) this.cboLOB).TabIndex = 2;
    ((UltraControlBase) this.cboLOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLOB).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLOB).ValueMember = "LineGUID";
    this.cboPolicyType.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    this.cboPolicyType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyType).Location = new Point(620, 34);
    this.cboPolicyType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(141, 20);
    ((Control) this.cboPolicyType).TabIndex = 6;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    this.cboMonth.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboMonth).DataMember = "dtMonth";
    ((UltraGridBase) this.cboMonth).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboMonth).DisplayMember = "MonthName";
    this.cboMonth.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboMonth).Location = new Point(107, 8);
    this.cboMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboMonth).Name = "cboMonth";
    ((Control) this.cboMonth).Size = new Size(141, 20);
    ((Control) this.cboMonth).TabIndex = 0;
    ((UltraControlBase) this.cboMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboMonth).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboMonth).ValueMember = "Month";
    this.cboYear.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboYear).DataMember = "dtYear";
    ((UltraGridBase) this.cboYear).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboYear).DisplayMember = "YearName";
    this.cboYear.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboYear).Location = new Point(107, 34);
    this.cboYear.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboYear).Name = "cboYear";
    ((Control) this.cboYear).Size = new Size(75, 20);
    ((Control) this.cboYear).TabIndex = 1;
    ((UltraControlBase) this.cboYear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboYear).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboYear).ValueMember = "Year";
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dg).DataMember = "tblProductionGoal";
    ((UltraGridBase) this.dg).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 40;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn14.Format = "c";
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Premium";
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 95;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Producer Location";
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridColumn15.Style = (ColumnStyle) 6;
    ultraGridColumn15.Width = 153;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Producer";
    ultraGridColumn16.Header.VisiblePosition = 3;
    ultraGridColumn16.Style = (ColumnStyle) 6;
    ultraGridColumn16.Width = 151;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Month";
    ultraGridColumn17.Header.VisiblePosition = 4;
    ultraGridColumn17.Style = (ColumnStyle) 6;
    ultraGridColumn17.Width = 95;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Year";
    ultraGridColumn18.Header.VisiblePosition = 5;
    ultraGridColumn18.Style = (ColumnStyle) 6;
    ultraGridColumn18.Width = 69;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.Header.VisiblePosition = 6;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 72;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Policy Type";
    ultraGridColumn20.Header.VisiblePosition = 7;
    ultraGridColumn20.Style = (ColumnStyle) 6;
    ultraGridColumn20.Width = 108;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Line";
    ultraGridColumn21.Header.VisiblePosition = 8;
    ultraGridColumn21.Width = 144 /*0x90*/;
    ultraGridColumn22.Header.VisiblePosition = 9;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 190;
    ultraGridBand7.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(12, 12);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(817, (int) byte.MaxValue);
    ((Control) this.dg).TabIndex = 210;
    ((Control) this.dg).Text = "Available Broker Production Goals";
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(837, 459);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ddYear);
    this.Controls.Add((Control) this.ddPolicyType);
    this.Controls.Add((Control) this.ddMonth);
    this.Controls.Add((Control) this.ddProducer);
    this.Controls.Add((Control) this.ddProducerLocation);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.panelProdGoals);
    this.Controls.Add((Control) this.dg);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormBrokerProductionGoals);
    this.Text = "Broker Production Goals";
    ((ISupportInitialize) this.numPremiumGoal).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.panelProdGoals.ResumeLayout(false);
    this.panelProdGoals.PerformLayout();
    ((ISupportInitialize) this.ddLines).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddYear).EndInit();
    ((ISupportInitialize) this.ddPolicyType).EndInit();
    ((ISupportInitialize) this.ddMonth).EndInit();
    ((ISupportInitialize) this.ddProducer).EndInit();
    ((ISupportInitialize) this.ddProducerLocation).EndInit();
    ((ISupportInitialize) this.cboGroup).EndInit();
    ((ISupportInitialize) this.cboLOB).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    ((ISupportInitialize) this.cboMonth).EndInit();
    ((ISupportInitialize) this.cboYear).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("numPremiumGoal")]
  private virtual MGANumericEditor numPremiumGoal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProductionGoal ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daProductionGoal")]
  private virtual SqlDataAdapter daProductionGoal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  private virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  private virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  private virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  private virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboMonth")]
  protected virtual MGASimpleComboBox cboMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboYear")]
  protected virtual MGASimpleComboBox cboYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbLocationLevel")]
  protected virtual RadioButton rbLocationLevel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbProducerLevel")]
  private virtual RadioButton rbProducerLevel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelProdGoals")]
  private virtual Panel panelProdGoals { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid dg
  {
    get => this._dg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dg_AfterRowActivate);
      UltraGrid dg1 = this._dg;
      if (dg1 != null)
        dg1.AfterRowActivate -= eventHandler;
      this._dg = value;
      UltraGrid dg2 = this._dg;
      if (dg2 == null)
        return;
      dg2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedDelete);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickedDelete -= eventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickedDelete += eventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
    }
  }

  [field: AccessedThroughProperty("ddProducerLocation")]
  private virtual UltraDropDown ddProducerLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddMonth")]
  private virtual UltraDropDown ddMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddProducer")]
  private virtual UltraDropDown ddProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddPolicyType")]
  private virtual UltraDropDown ddPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboPolicyType")]
  protected virtual MGASimpleComboBox cboPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddYear")]
  private virtual UltraDropDown ddYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLOB")]
  protected virtual MGASimpleComboBox cboLOB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  private virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanyGroup")]
  internal virtual Label lblCompanyGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboGroup")]
  protected virtual MGASimpleComboBox cboGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormBrokerProductionGoals(Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.FormBrokerProductionGoals_Load);
    this._producerLocationGUID = Guid.Empty;
    this._producerGUID = Guid.Empty;
    this._isNewRow = false;
    this.InitializeComponent();
    this._producerLocationGUID = producerLocationGuid;
  }

  private void FormBrokerProductionGoals_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dbSave.UIState = UIState.NoRecordsNotEditing;
    this._producerGUID = new ProducerLocation(this._producerLocationGUID).ProducerGuid;
    MGASystems.Tools.DBSaveUI.DBSaveUI dbSave = this.dbSave;
    dbSave.UIState = UIState.NoRecordsNotEditing;
    dbSave.EditStyle = EditStyle.ShowEditButton;
    this.FillDatasetTempTables();
    this.SetupParameters();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daProductionGoal, (DataTable) this.ds.tblProductionGoal);
    if (this.ds.tblProductionGoal.Count > 0)
    {
      dsProductionGoal.tblProductionGoalRow productionGoalRow = this.ds.tblProductionGoal[0];
      this.cboMonth.Value = (object) productionGoalRow.GoalMonth;
      this.cboYear.Value = (object) productionGoalRow.GoalYear;
      this.numPremiumGoal.Value = (object) productionGoalRow.PremiumGoal;
      if (productionGoalRow.ProducerLevel.Equals("P"))
        this.rbProducerLevel.Checked = true;
      else if (productionGoalRow.ProducerLevel.Equals("L"))
        this.rbLocationLevel.Checked = true;
      if (!productionGoalRow.IsLineGUIDNull())
        this.cboLOB.Value = (object) productionGoalRow.LineGUID;
      if (!productionGoalRow.IsCompanyGroupGuidNull())
        this.cboGroup.Value = (object) productionGoalRow.CompanyGroupGuid;
    }
    this.SetDBSave();
    this.panelProdGoals.Enabled = false;
  }

  private string GetMonth(Dictionary<byte, string> dict, byte monthID) => dict[monthID];

  private void FillDatasetTempTables()
  {
    Dictionary<byte, string> dict = new Dictionary<byte, string>();
    dict.Add((byte) 1, "January");
    dict.Add((byte) 2, "Febuary");
    dict.Add((byte) 3, "March");
    dict.Add((byte) 4, "April");
    dict.Add((byte) 5, "May");
    dict.Add((byte) 6, "June");
    dict.Add((byte) 7, "July");
    dict.Add((byte) 8, "August");
    dict.Add((byte) 9, "September");
    dict.Add((byte) 10, "October");
    dict.Add((byte) 11, "November");
    dict.Add((byte) 12, "December");
    dict.Add((byte) 13, "Annual");
    dict.Add((byte) 14, "Semi-Annual");
    dict.Add((byte) 15, "Quarterly");
    byte monthID = 1;
    do
    {
      dsProductionGoal.dtMonthRow row = this.ds.dtMonth.NewdtMonthRow();
      row.Month = monthID;
      row.MonthName = this.GetMonth(dict, monthID);
      this.ds.dtMonth.AdddtMonthRow(row);
      ++monthID;
    }
    while (monthID <= (byte) 15);
    dsProductionGoal.dtYearRow row1 = this.ds.dtYear.NewdtYearRow();
    row1.Year = 1901;
    row1.YearName = "Month";
    this.ds.dtYear.AdddtYearRow(row1);
    int num = 1980;
    do
    {
      dsProductionGoal.dtYearRow row2 = this.ds.dtYear.NewdtYearRow();
      row2.Year = num;
      row2.YearName = num.ToString();
      this.ds.dtYear.AdddtYearRow(row2);
      ++num;
    }
    while (num <= 1984);
    num = 2007;
    do
    {
      dsProductionGoal.dtYearRow row3 = this.ds.dtYear.NewdtYearRow();
      row3.Year = num;
      row3.YearName = num.ToString();
      this.ds.dtYear.AdddtYearRow(row3);
      ++num;
    }
    while (num <= 2025);
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblProducerLocations, CommandType.Text, "SELECT ProducerLocationGUID,Name FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGUID = @PL", new object[2]
    {
      (object) "@PL",
      (object) this._producerLocationGUID
    });
    if (!this._producerGUID.Equals(Guid.Empty))
      DefaultDatabase.LoadDataTable((DataTable) this.ds.tblProducers, CommandType.Text, "SELECT ProducerGUID,ProducerName FROM tblProducers WITH (NOLOCK) WHERE ProducerGUID = @PG", new object[2]
      {
        (object) "@PG",
        (object) this._producerGUID
      });
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstPolicyTypes, CommandType.Text, "SELECT PolicyTypeID,Description FROM lstPolicyTypes WITH (NOLOCK) ORDER BY Description");
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstLines, CommandType.Text, "SELECT LineGUID,LineName FROM lstLines WITH (NOLOCK) ORDER BY LineName");
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblCompanyGroups, CommandType.Text, "SELECT CompanyGroupGuid,CompanyGroupName FROM tblCompanyGroups WITH (NOLOCK) ORDER BY CompanyGroupName");
  }

  private void SetupParameters()
  {
    if (!this._producerGUID.Equals(Guid.Empty) && this._producerLocationGUID.Equals(Guid.Empty))
    {
      SqlCommand selectCommand;
      string str = (selectCommand = this.daProductionGoal.SelectCommand).CommandText + " WHERE ProducerGUID = @PG";
      selectCommand.CommandText = str;
      this.daProductionGoal.SelectCommand.Parameters.AddWithValue("@PG", (object) this._producerGUID);
    }
    else if (this._producerGUID.Equals(Guid.Empty) && !this._producerLocationGUID.Equals(Guid.Empty))
    {
      SqlCommand selectCommand;
      string str = (selectCommand = this.daProductionGoal.SelectCommand).CommandText + " WHERE ProducerLocationGUID = @PLG";
      selectCommand.CommandText = str;
      this.daProductionGoal.SelectCommand.Parameters.AddWithValue("@PLG", (object) this._producerLocationGUID);
    }
    else
    {
      if (this._producerGUID.Equals(Guid.Empty) || this._producerLocationGUID.Equals(Guid.Empty))
        return;
      SqlCommand selectCommand;
      string str = (selectCommand = this.daProductionGoal.SelectCommand).CommandText + " WHERE ProducerLocationGUID = @PLG OR ProducerGUID = @PG";
      selectCommand.CommandText = str;
      this.daProductionGoal.SelectCommand.Parameters.AddWithValue("@PG", (object) this._producerGUID);
      this.daProductionGoal.SelectCommand.Parameters.AddWithValue("@PLG", (object) this._producerLocationGUID);
    }
  }

  private bool ValidateForm()
  {
    bool flag = true;
    if (this.rbLocationLevel.Checked && this._producerLocationGUID.Equals(Guid.Empty))
    {
      int num = (int) MessageBox.Show("Record cannot be saved on a producer location level because the current producer location cannot be established.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    if (this.rbProducerLevel.Checked && this._producerGUID.Equals(Guid.Empty))
    {
      int num = (int) MessageBox.Show("Record cannot be saved on a producer level because the current producer cannot be established.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    if (string.IsNullOrEmpty(this.cboMonth.Text))
    {
      this.err.SetError((Control) this.cboMonth, "Please select a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboMonth, string.Empty);
    if (string.IsNullOrEmpty(this.cboYear.Text))
      this.err.SetError((Control) this.cboYear, "Please select a value");
    else
      this.err.SetError((Control) this.cboYear, string.Empty);
    if (this.numPremiumGoal.Value == null || this.numPremiumGoal.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.numPremiumGoal, "Please enter a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.numPremiumGoal, string.Empty);
    return flag;
  }

  private void dg_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dg).ActiveRow == null)
    {
      this.EmptyControls();
    }
    else
    {
      dsProductionGoal.tblProductionGoalRow byId = this.ds.tblProductionGoal.FindByID(Conversions.ToInteger(((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value));
      if (byId != null)
      {
        dsProductionGoal.tblProductionGoalRow productionGoalRow = byId;
        this.cboMonth.Value = (object) productionGoalRow.GoalMonth;
        this.cboYear.Value = (object) productionGoalRow.GoalYear;
        this.numPremiumGoal.Value = (object) productionGoalRow.PremiumGoal;
        if (productionGoalRow.ProducerLevel.Equals("P"))
          this.rbProducerLevel.Checked = true;
        else if (productionGoalRow.ProducerLevel.Equals("L"))
          this.rbLocationLevel.Checked = true;
        if (!productionGoalRow.IsPolicyTypeIDNull())
          this.cboPolicyType.Value = (object) productionGoalRow.PolicyTypeID;
        else
          this.cboPolicyType.Value = (object) null;
        if (!productionGoalRow.IsLineGUIDNull())
          this.cboLOB.Value = (object) productionGoalRow.LineGUID;
        else
          this.cboLOB.Value = (object) null;
        if (!productionGoalRow.IsCompanyGroupGuidNull())
          this.cboGroup.Value = (object) productionGoalRow.CompanyGroupGuid;
        else
          this.cboGroup.Value = (object) null;
      }
      else
        this.EmptyControls();
    }
  }

  private void SetDBSave()
  {
    if (this.ds.tblProductionGoal.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this._isNewRow = false;
    this.ds.tblProductionGoal.RejectChanges();
    this.SetDBSave();
    this.dg_AfterRowActivate((object) null, EventArgs.Empty);
    this.panelProdGoals.Enabled = false;
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e)
  {
    this.SetDBSave();
    this.panelProdGoals.Enabled = false;
    this.dg_AfterRowActivate((object) null, EventArgs.Empty);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dg).ActiveRow == null)
      e.Cancel = true;
    else if (MessageBox.Show("Are you sure you want to delete this production goal?", "Delete Production Goal?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      e.Cancel = true;
    }
    else
    {
      dsProductionGoal.tblProductionGoalRow byId = this.ds.tblProductionGoal.FindByID(Conversions.ToInteger(((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value));
      if (byId == null)
      {
        e.Cancel = true;
      }
      else
      {
        byId.Delete();
        this.Cursor = MgaCursors.WaitCursor;
        try
        {
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProductionGoal, (DataTable) this.ds.tblProductionGoal);
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
        this.SetDBSave();
        this.panelProdGoals.Enabled = false;
      }
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this._isNewRow = false;
    this.panelProdGoals.Enabled = true;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this._isNewRow = true;
    this.panelProdGoals.Enabled = true;
    this.EmptyControls();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidateForm())
    {
      e.Cancel = true;
    }
    else
    {
      dsProductionGoal.tblProductionGoalRow row;
      if (!this._isNewRow)
      {
        if (((UltraGridBase) this.dg).ActiveRow == null)
        {
          e.Cancel = true;
          return;
        }
        row = this.ds.tblProductionGoal.FindByID(Conversions.ToInteger(((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value));
      }
      else
        row = this.ds.tblProductionGoal.NewtblProductionGoalRow();
      dsProductionGoal.tblProductionGoalRow productionGoalRow = row;
      productionGoalRow.PremiumGoal = Conversions.ToDecimal(this.numPremiumGoal.Value);
      productionGoalRow.GoalYear = Conversions.ToInteger(this.cboYear.Value);
      productionGoalRow.GoalMonth = Conversions.ToByte(this.cboMonth.Value);
      if (this.rbLocationLevel.Checked)
        productionGoalRow.ProducerLevel = "L";
      else if (this.rbProducerLevel.Checked)
        productionGoalRow.ProducerLevel = "P";
      if (!this._producerGUID.Equals(Guid.Empty) && this.rbProducerLevel.Checked)
      {
        productionGoalRow.ProducerGUID = this._producerGUID;
        productionGoalRow.SetProducerLocationGUIDNull();
      }
      if (!this._producerLocationGUID.Equals(Guid.Empty) && this.rbLocationLevel.Checked)
      {
        productionGoalRow.ProducerLocationGUID = this._producerLocationGUID;
        productionGoalRow.SetProducerGUIDNull();
      }
      if (!string.IsNullOrEmpty(this.cboPolicyType.Text))
        productionGoalRow.PolicyTypeID = Conversions.ToByte(this.cboPolicyType.Value);
      else
        productionGoalRow.SetPolicyTypeIDNull();
      if (this.cboLOB.Value != null && this.cboLOB.Value != DBNull.Value)
        productionGoalRow.LineGUID = (Guid) this.cboLOB.Value;
      else
        productionGoalRow.SetLineGUIDNull();
      if (this.cboGroup.Value != null && this.cboGroup.Value != DBNull.Value)
        productionGoalRow.CompanyGroupGuid = (Guid) this.cboGroup.Value;
      else
        productionGoalRow.SetCompanyGroupGuidNull();
      if (this._isNewRow)
        this.ds.tblProductionGoal.AddtblProductionGoalRow(row);
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daProductionGoal, (DataTable) this.ds.tblProductionGoal);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.panelProdGoals.Enabled = false;
    }
  }

  private void EmptyControls()
  {
    try
    {
      foreach (Control control in this.panelProdGoals.Controls)
      {
        if (control is MGASimpleComboBox)
          ((UltraCombo) control).Value = (object) null;
        if (control is MGANumericEditor mgaNumericEditor)
          mgaNumericEditor.Value = (object) null;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
