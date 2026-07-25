// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormRaterGenericPremiumDist
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.Generic;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormRaterGenericPremiumDist : Form
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private readonly dsRaterGeneric _genericRaterDataset;
  private readonly bool _isBound;
  private readonly bool _isEndorsement;
  private readonly int _policyDays;
  private readonly DateTime _genericEffectiveDate;
  private readonly DateTime _expirateDate;
  private readonly Decimal _shortRate;
  private readonly Decimal _proRata;
  private bool _clickSaveUpdates;

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRaterGenericPremiumDist));
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstEndorsementCalculationTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EndorsementCalcType");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblFin_PolicyCharges", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ChargeID");
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblGenericPremiumDistribution", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ChargeCode", -1, (object) "ddChargeCodes");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AnnualAmount");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("BillAmount");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("EndorsementCalcType", -1, (object) "ddCalcType");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Factor");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("pdGuid");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("RoundToDollar");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.Label2 = new Label();
    this.cboChargeCodes = new MGASimpleComboBox();
    this.ds = new dsGenericPremDist();
    this.Label1 = new Label();
    this.cboState = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.cboEndorsementCalcType = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.grpBox = new GroupBox();
    this.checkRoundPremiums = new MGACheckBox();
    this.numFactor = new MGANumericEditor();
    this.Label3 = new Label();
    this.numBillAmount = new MGANumericEditor();
    this.numAnnualAmount = new MGANumericEditor();
    this.cnSQL = new SqlConnection();
    this.err = new ErrorProvider(this.components);
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ddCalcType = new UltraDropDown();
    this.ddChargeCodes = new UltraDropDown();
    this.dgOptions = new UltraGrid();
    ((ISupportInitialize) this.cboChargeCodes).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboEndorsementCalcType).BeginInit();
    this.grpBox.SuspendLayout();
    ((ISupportInitialize) this.checkRoundPremiums).BeginInit();
    ((ISupportInitialize) this.numFactor).BeginInit();
    ((ISupportInitialize) this.numBillAmount).BeginInit();
    ((ISupportInitialize) this.numAnnualAmount).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddCalcType).BeginInit();
    ((ISupportInitialize) this.ddChargeCodes).BeginInit();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    this.SuspendLayout();
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(18, 82);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(50, 13);
    this.Label2.TabIndex = 25;
    this.Label2.Text = "Premium:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.cboChargeCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboChargeCodes).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericPremiumDistribution.ChargeCode", true));
    this.cboChargeCodes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboChargeCodes).DropDownWidth = 250;
    ((Control) this.cboChargeCodes).Location = new Point(110, 75);
    this.cboChargeCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboChargeCodes).Name = "cboChargeCodes";
    ((Control) this.cboChargeCodes).Size = new Size(341, 20);
    ((Control) this.cboChargeCodes).TabIndex = 2;
    ((UltraControlBase) this.cboChargeCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChargeCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsGenericPremDist";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(18, 23);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(35, 13);
    this.Label1.TabIndex = 27;
    this.Label1.Text = "State:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericPremiumDistribution.StateID", true));
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 200;
    ((Control) this.cboState).Location = new Point(110, 19);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(201, 20);
    ((Control) this.cboState).TabIndex = 0;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(18, 53);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(58, 13);
    this.Label4.TabIndex = 29;
    this.Label4.Text = "Calc Type:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.cboEndorsementCalcType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboEndorsementCalcType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericPremiumDistribution.EndorsementCalcType", true));
    this.cboEndorsementCalcType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboEndorsementCalcType).DropDownWidth = 200;
    ((Control) this.cboEndorsementCalcType).Location = new Point(110, 49);
    this.cboEndorsementCalcType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboEndorsementCalcType).Name = "cboEndorsementCalcType";
    ((Control) this.cboEndorsementCalcType).Size = new Size(201, 20);
    ((Control) this.cboEndorsementCalcType).TabIndex = 1;
    ((UltraControlBase) this.cboEndorsementCalcType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEndorsementCalcType).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(18, 108);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(46, 13);
    this.Label6.TabIndex = 32 /*0x20*/;
    this.Label6.Text = "Amount:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(260, 108);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(74, 13);
    this.Label7.TabIndex = 34;
    this.Label7.Text = "Billed Amount:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(521, 379);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 3;
    this.dbSave.ToolTipNew = "New Premium";
    this.grpBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.grpBox.BackColor = Color.AliceBlue;
    this.grpBox.Controls.Add((Control) this.checkRoundPremiums);
    this.grpBox.Controls.Add((Control) this.numFactor);
    this.grpBox.Controls.Add((Control) this.Label3);
    this.grpBox.Controls.Add((Control) this.numBillAmount);
    this.grpBox.Controls.Add((Control) this.numAnnualAmount);
    this.grpBox.Controls.Add((Control) this.Label7);
    this.grpBox.Controls.Add((Control) this.Label6);
    this.grpBox.Controls.Add((Control) this.Label4);
    this.grpBox.Controls.Add((Control) this.cboChargeCodes);
    this.grpBox.Controls.Add((Control) this.cboEndorsementCalcType);
    this.grpBox.Controls.Add((Control) this.Label2);
    this.grpBox.Controls.Add((Control) this.Label1);
    this.grpBox.Controls.Add((Control) this.cboState);
    this.grpBox.Location = new Point(12, 225);
    this.grpBox.Name = "grpBox";
    this.grpBox.Size = new Size(621, 148);
    this.grpBox.TabIndex = 2;
    this.grpBox.TabStop = false;
    this.grpBox.Text = "Premium Distribution Info.";
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkRoundPremiums).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.checkRoundPremiums).Checked = true;
    ((UltraToggleEditorBase) this.checkRoundPremiums).CheckState = CheckState.Checked;
    ((Control) this.checkRoundPremiums).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblGenericPremiumDistribution.RoundToDollar", true));
    ((UltraToggleEditorBase) this.checkRoundPremiums).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkRoundPremiums).Location = new Point(336, 20);
    ((Control) this.checkRoundPremiums).Name = "checkRoundPremiums";
    ((Control) this.checkRoundPremiums).Size = new Size(120, 20);
    ((Control) this.checkRoundPremiums).TabIndex = 4;
    ((UltraToggleEditorBase) this.checkRoundPremiums).Text = "Round To Dollar";
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numFactor).Appearance = (AppearanceBase) appearance2;
    ((Control) this.numFactor).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericPremiumDistribution.Factor", true));
    ((Control) this.numFactor).Location = new Point(379, 50);
    this.numFactor.MaskInput = "n.nnnnnn";
    this.numFactor.MaxValue = (object) new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numFactor.MGAStyle = MGAStyles.Blue;
    this.numFactor.MinValue = (object) new Decimal(new int[4]);
    ((Control) this.numFactor).Name = "numFactor";
    this.numFactor.NumericType = (NumericType) 2;
    ((EditorButtonControlBase) this.numFactor).ReadOnly = true;
    ((Control) this.numFactor).Size = new Size(72, 19);
    ((Control) this.numFactor).TabIndex = 35;
    ((UltraControlBase) this.numFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numFactor).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(333, 53);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(40, 13);
    this.Label3.TabIndex = 36;
    this.Label3.Text = "Factor:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBillAmount).Appearance = (AppearanceBase) appearance3;
    ((Control) this.numBillAmount).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericPremiumDistribution.BillAmount", true));
    ((UltraNumericEditorBase) this.numBillAmount).FormatString = "c";
    ((Control) this.numBillAmount).Location = new Point(340, 105);
    this.numBillAmount.MaskInput = "nnnnnnnnnnnnnn.nn";
    this.numBillAmount.MaxValue = (object) new Decimal(new int[4]
    {
      1874919423,
      2328306,
      0,
      131072 /*0x020000*/
    });
    this.numBillAmount.MGAStyle = MGAStyles.Blue;
    this.numBillAmount.MinValue = (object) new Decimal(new int[4]
    {
      1874919423,
      2328306,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.numBillAmount).Name = "numBillAmount";
    this.numBillAmount.NumericType = (NumericType) 2;
    ((EditorButtonControlBase) this.numBillAmount).ReadOnly = true;
    ((Control) this.numBillAmount).Size = new Size(111, 19);
    ((Control) this.numBillAmount).TabIndex = 7;
    ((UltraControlBase) this.numBillAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBillAmount).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numAnnualAmount).Appearance = (AppearanceBase) appearance4;
    ((Control) this.numAnnualAmount).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericPremiumDistribution.AnnualAmount", true));
    ((UltraNumericEditorBase) this.numAnnualAmount).FormatString = "c";
    ((Control) this.numAnnualAmount).Location = new Point(110, 105);
    this.numAnnualAmount.MaskInput = "nnnnnnnnnnnnnn.nn";
    this.numAnnualAmount.MaxValue = (object) new Decimal(new int[4]
    {
      1874919423,
      2328306,
      0,
      131072 /*0x020000*/
    });
    this.numAnnualAmount.MGAStyle = MGAStyles.Blue;
    this.numAnnualAmount.MinValue = (object) new Decimal(new int[4]
    {
      1874919423,
      2328306,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.numAnnualAmount).Name = "numAnnualAmount";
    this.numAnnualAmount.NumericType = (NumericType) 2;
    ((Control) this.numAnnualAmount).Size = new Size(107, 19);
    ((Control) this.numAnnualAmount).TabIndex = 3;
    ((UltraControlBase) this.numAnnualAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numAnnualAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.cnSQL.ConnectionString = "Data Source=mgasystems;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericPremiumDistribution", new DataColumnMapping[11]
      {
        new DataColumnMapping("PremiumDistID", "PremiumDistID"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("AnnualAmount", "AnnualAmount"),
        new DataColumnMapping("BillAmount", "BillAmount"),
        new DataColumnMapping("Added", "Added"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("EndorsementCalcType", "EndorsementCalcType"),
        new DataColumnMapping("Factor", "Factor"),
        new DataColumnMapping("pdGuid", "pdGuid"),
        new DataColumnMapping("RoundToDollar", "RoundToDollar")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblGenericPremiumDistribution] WHERE (([PremiumDistID] = @Original_PremiumDistID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_PremiumDistID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PremiumDistID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 0, "ChargeCode"),
      new SqlParameter("@AnnualAmount", SqlDbType.Money, 0, "AnnualAmount"),
      new SqlParameter("@BillAmount", SqlDbType.Money, 0, "BillAmount"),
      new SqlParameter("@Added", SqlDbType.DateTime, 0, "Added"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.Char, 0, "EndorsementCalcType"),
      new SqlParameter("@Factor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 9, (byte) 8, "Factor", DataRowVersion.Current, (object) null),
      new SqlParameter("@pdGuid", SqlDbType.UniqueIdentifier, 0, "pdGuid"),
      new SqlParameter("@RoundToDollar", SqlDbType.Bit, 0, "RoundToDollar")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[12]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@ChargeCode", SqlDbType.Int, 0, "ChargeCode"),
      new SqlParameter("@AnnualAmount", SqlDbType.Money, 0, "AnnualAmount"),
      new SqlParameter("@BillAmount", SqlDbType.Money, 0, "BillAmount"),
      new SqlParameter("@Added", SqlDbType.DateTime, 0, "Added"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@EndorsementCalcType", SqlDbType.Char, 0, "EndorsementCalcType"),
      new SqlParameter("@Factor", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 9, (byte) 8, "Factor", DataRowVersion.Current, (object) null),
      new SqlParameter("@pdGuid", SqlDbType.UniqueIdentifier, 0, "pdGuid"),
      new SqlParameter("@RoundToDollar", SqlDbType.Bit, 0, "RoundToDollar"),
      new SqlParameter("@Original_PremiumDistID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PremiumDistID", DataRowVersion.Original, (object) null),
      new SqlParameter("@PremiumDistID", SqlDbType.Int, 4, "PremiumDistID")
    });
    ((UltraGridBase) this.ddCalcType).DataMember = "lstEndorsementCalculationTypes";
    ((UltraGridBase) this.ddCalcType).DataSource = (object) this.ds;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 223;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddCalcType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddCalcType).DisplayMember = "EndorsementCalcType";
    ((Control) this.ddCalcType).Location = new Point(143, 90);
    ((Control) this.ddCalcType).Name = "ddCalcType";
    ((Control) this.ddCalcType).Size = new Size(198, 65);
    ((Control) this.ddCalcType).TabIndex = 38;
    ((UltraDropDownBase) this.ddCalcType).ValueMember = "ID";
    ((Control) this.ddCalcType).Visible = false;
    ((UltraGridBase) this.ddChargeCodes).DataMember = "tblFin_PolicyCharges";
    ((UltraGridBase) this.ddChargeCodes).DataSource = (object) this.ds;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddChargeCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddChargeCodes).DisplayMember = "ChargeName";
    ((Control) this.ddChargeCodes).Location = new Point(367, 100);
    ((Control) this.ddChargeCodes).Name = "ddChargeCodes";
    ((Control) this.ddChargeCodes).Size = new Size(211, 65);
    ((Control) this.ddChargeCodes).TabIndex = 37;
    ((UltraDropDownBase) this.ddChargeCodes).ValueMember = "ChargeCode";
    ((Control) this.ddChargeCodes).Visible = false;
    ((Control) this.dgOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgOptions).DataMember = "tblGenericPremiumDistribution";
    ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 212;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Premium Type";
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 146;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn9.Format = "c";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Amount";
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn9.Width = 80 /*0x50*/;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn10.Format = "c";
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Billed Amt";
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn10.Width = 72;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 108;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "State";
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 74;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Calc Type";
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Style = (ColumnStyle) 6;
    ultraGridColumn13.Width = 115;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn14.Width = 75;
    ultraGridColumn15.Header.VisiblePosition = 8;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 87;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Round";
    ultraGridColumn16.Header.VisiblePosition = 9;
    ultraGridColumn16.Width = 57;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgOptions).DisplayLayout.RowConnectorColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.RowConnectorStyle = (RowConnectorStyle) 4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgOptions).Location = new Point(12, 12);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(621, 207);
    ((Control) this.dgOptions).TabIndex = 1;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(645, 431);
    this.Controls.Add((Control) this.ddCalcType);
    this.Controls.Add((Control) this.ddChargeCodes);
    this.Controls.Add((Control) this.grpBox);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.dgOptions);
    this.Name = nameof (FormRaterGenericPremiumDist);
    this.Text = "Generic Rater (Premium Distribution)";
    ((ISupportInitialize) this.cboChargeCodes).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboEndorsementCalcType).EndInit();
    this.grpBox.ResumeLayout(false);
    this.grpBox.PerformLayout();
    ((ISupportInitialize) this.checkRoundPremiums).EndInit();
    ((ISupportInitialize) this.numFactor).EndInit();
    ((ISupportInitialize) this.numBillAmount).EndInit();
    ((ISupportInitialize) this.numAnnualAmount).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddCalcType).EndInit();
    ((ISupportInitialize) this.ddChargeCodes).EndInit();
    ((ISupportInitialize) this.dgOptions).EndInit();
    this.ResumeLayout(false);
  }

  protected virtual UltraGrid dgOptions
  {
    get => this._dgOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgOptions_AfterRowActivate);
      UltraGrid dgOptions1 = this._dgOptions;
      if (dgOptions1 != null)
        dgOptions1.AfterRowActivate -= eventHandler;
      this._dgOptions = value;
      UltraGrid dgOptions2 = this._dgOptions;
      if (dgOptions2 == null)
        return;
      dgOptions2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsGenericPremDist ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboChargeCodes
  {
    get => this._cboChargeCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboChargeCodes_BeforeDropDown);
      MGASimpleComboBox cboChargeCodes1 = this._cboChargeCodes;
      if (cboChargeCodes1 != null)
        cboChargeCodes1.BeforeDropDown -= cancelEventHandler;
      this._cboChargeCodes = value;
      MGASimpleComboBox cboChargeCodes2 = this._cboChargeCodes;
      if (cboChargeCodes2 == null)
        return;
      cboChargeCodes2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboEndorsementCalcType
  {
    get => this._cboEndorsementCalcType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboEndorsementCalcType_ValueChanged);
      MGASimpleComboBox endorsementCalcType1 = this._cboEndorsementCalcType;
      if (endorsementCalcType1 != null)
        endorsementCalcType1.ValueChanged -= eventHandler;
      this._cboEndorsementCalcType = value;
      MGASimpleComboBox endorsementCalcType2 = this._cboEndorsementCalcType;
      if (endorsementCalcType2 == null)
        return;
      endorsementCalcType2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickedCancel -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingEdit -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickedCancel += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingEdit += cancelEventHandler4;
    }
  }

  [field: AccessedThroughProperty("grpBox")]
  internal virtual GroupBox grpBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddChargeCodes")]
  private virtual UltraDropDown ddChargeCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  private virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  private virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  private virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  private virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numBillAmount")]
  private virtual MGANumericEditor numBillAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGANumericEditor numAnnualAmount
  {
    get => this._numAnnualAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.numAnnualAmount_ValueChanged);
      MGANumericEditor numAnnualAmount1 = this._numAnnualAmount;
      if (numAnnualAmount1 != null)
        ((UltraNumericEditorBase) numAnnualAmount1).ValueChanged -= eventHandler;
      this._numAnnualAmount = value;
      MGANumericEditor numAnnualAmount2 = this._numAnnualAmount;
      if (numAnnualAmount2 == null)
        return;
      ((UltraNumericEditorBase) numAnnualAmount2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddCalcType")]
  private virtual UltraDropDown ddCalcType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numFactor")]
  private virtual MGANumericEditor numFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkRoundPremiums")]
  internal virtual MGACheckBox checkRoundPremiums { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblGenericPremiumDistribution.TableName];
  }

  public bool UserClickedUpdates => this._clickSaveUpdates;

  public FormRaterGenericPremiumDist(Guid quoteGuid, dsRaterGeneric genericDataset)
  {
    this.Load += new EventHandler(this.FormRaterGenericPremiumDist_Load);
    this._isBound = false;
    this._isEndorsement = false;
    this._policyDays = 365;
    this._shortRate = 1M;
    this._proRata = 1M;
    this._clickSaveUpdates = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._genericRaterDataset = genericDataset;
    Quote quote = new Quote(quoteGuid);
    this._isBound = quote.IsBound;
    this._isEndorsement = quote.IsEndorsement;
    this._expirateDate = quote.ExpirationDate;
    this._policyDays = quote.ExpirationDate.Subtract(quote.EffectiveDate).Days;
    if (this._genericRaterDataset.tblQuoteOptionGeneric.Count <= 0 || this._genericRaterDataset.tblQuoteOptionGeneric[0].IsEffectiveDateNull())
      return;
    this._genericEffectiveDate = this._genericRaterDataset.tblQuoteOptionGeneric[0].EffectiveDate;
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalculateShortRateFactor(@policyDays, @startDate, @endDate)", new object[6]
    {
      (object) "@policyDays",
      (object) this._policyDays,
      (object) "@startDate",
      (object) this._genericEffectiveDate,
      (object) "@endDate",
      (object) this._expirateDate
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      this._shortRate = Conversions.ToDecimal(objectValue1);
    object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.CalculateProRata(@policyDays, @startDate, @endDate)", new object[6]
    {
      (object) "@policyDays",
      (object) this._policyDays,
      (object) "@startDate",
      (object) this._genericEffectiveDate,
      (object) "@endDate",
      (object) this._expirateDate
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      this._proRata = Conversions.ToDecimal(objectValue2);
    this._shortRate = Math.Round(this._shortRate, 4);
    this._proRata = Math.Round(this._proRata, 4);
  }

  private void FormRaterGenericPremiumDist_Load(object sender, EventArgs e)
  {
    try
    {
      ((UltraNumericEditorBase) this.numAnnualAmount).ValueChanged -= new EventHandler(this.numAnnualAmount_ValueChanged);
      this.cboEndorsementCalcType.ValueChanged -= new EventHandler(this.cboEndorsementCalcType_ValueChanged);
      this.HookDataBindings();
      this.da.SelectCommand.Parameters["@QuoteGUID"].Value = (object) this._quoteGuid;
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblGenericPremiumDistribution"
      }, CommandType.Text, "SELECT QuoteGuid, ChargeCode, AnnualAmount, BillAmount, Added, StateID, EndorsementCalcType, Factor, pdGuid  FROM dbo.tblGenericPremiumDistribution WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "lstEndorsementCalculationTypes"
      }, CommandType.Text, "SELECT ID, EndorsementCalcType FROM lstEndorsementCalculationTypes WHERE ID <> @ME ORDER BY EndorsementCalcType", new object[2]
      {
        (object) "@ME",
        (object) "M"
      });
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblFin_PolicyCharges"
      }, CommandType.Text, "SELECT ChargeCode, StateID + @D + ChargeName AS ChargeName, StateID, ChargeID FROM tblFin_PolicyCharges WHERE (ChargeType = @P) ORDER BY StateID + @D + ChargeName", new object[4]
      {
        (object) "@D",
        (object) " - ",
        (object) "@P",
        (object) "P"
      });
      this.SetSaveState();
      this.SetFormEnablement(false);
      this.bmb.Position = this.ds.tblGenericPremiumDistribution.Count - 1;
    }
    finally
    {
      ((UltraNumericEditorBase) this.numAnnualAmount).ValueChanged += new EventHandler(this.numAnnualAmount_ValueChanged);
      this.cboEndorsementCalcType.ValueChanged += new EventHandler(this.cboEndorsementCalcType_ValueChanged);
    }
  }

  private void HookDataBindings()
  {
    try
    {
      MGASimpleComboBox cboState = this.cboState;
      ((UltraGridBase) cboState).DataSource = (object) this._genericRaterDataset.lstStates;
      ((UltraDropDownBase) cboState).DisplayMember = "State";
      ((UltraDropDownBase) cboState).ValueMember = "StateID";
      MGASimpleComboBox cboChargeCodes = this.cboChargeCodes;
      ((UltraGridBase) cboChargeCodes).DataSource = (object) this._genericRaterDataset.tblFin_PolicyCharges;
      ((UltraDropDownBase) cboChargeCodes).DisplayMember = "ChargeName";
      ((UltraDropDownBase) cboChargeCodes).ValueMember = "ChargeCode";
      MGASimpleComboBox endorsementCalcType = this.cboEndorsementCalcType;
      ((UltraGridBase) endorsementCalcType).DataSource = (object) this.ds.lstEndorsementCalculationTypes;
      ((UltraDropDownBase) endorsementCalcType).DisplayMember = "EndorsementCalcType";
      ((UltraDropDownBase) endorsementCalcType).ValueMember = "ID";
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void SetSaveState()
  {
    if (this.ds.tblGenericPremiumDistribution.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void SetFormEnablement(bool enable)
  {
    this.grpBox.Enabled = enable;
    ((Control) this.dgOptions).Enabled = !enable;
    if (!this._isBound)
      return;
    this.dbSave.Enabled = false;
  }

  private bool ValidFormData()
  {
    bool flag1;
    if (this.bmb.Position == -1)
      flag1 = false;
    else if (this._isBound)
    {
      int num = (int) MessageBox.Show("Updates are not allowed on bound policies", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag1 = false;
    }
    else
    {
      bool flag2 = true;
      this.err.SetError((Control) this.cboChargeCodes, string.Empty);
      this.err.SetError((Control) this.cboState, string.Empty);
      this.err.SetError((Control) this.cboEndorsementCalcType, string.Empty);
      this.err.SetError((Control) this.cboChargeCodes, string.Empty);
      this.err.SetError((Control) this.numAnnualAmount, string.Empty);
      if (this.cboChargeCodes.Text.Equals(string.Empty))
      {
        this.err.SetError((Control) this.cboChargeCodes, "Please select an item from the list.");
        flag2 = false;
      }
      if (this.cboState.Text.Equals(string.Empty))
      {
        this.err.SetError((Control) this.cboState, "Please select an item from the list.");
        flag2 = false;
      }
      if (this.cboEndorsementCalcType.Text.Equals(string.Empty))
      {
        this.err.SetError((Control) this.cboEndorsementCalcType, "Please select an item from the list.");
        flag2 = false;
      }
      if (this.cboChargeCodes.Text.Equals(string.Empty))
      {
        this.err.SetError((Control) this.cboChargeCodes, "Please select an item from the list.");
        flag2 = false;
      }
      if (this.numAnnualAmount.Value == null || this.numAnnualAmount.Value == DBNull.Value)
      {
        this.err.SetError((Control) this.numAnnualAmount, "Please enter a value.");
        flag2 = false;
      }
      if (flag2 && !this.ds.tblFin_PolicyCharges.FindByChargeCode(Conversions.ToInteger(this.cboChargeCodes.Value)).StateID.Equals(this.cboState.Value.ToString()))
      {
        int num = (int) MessageBox.Show($"The State of '{this.cboState.Text.ToString()}' does not match the premium state of '{this.cboChargeCodes.Text}'", "Invalid Premium State", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag1 = false;
      }
      else
        flag1 = flag2;
    }
    return flag1;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsGenericPremDist.tblGenericPremiumDistributionRow row = this.ds.tblGenericPremiumDistribution.NewtblGenericPremiumDistributionRow();
    dsGenericPremDist.tblGenericPremiumDistributionRow premiumDistributionRow = row;
    premiumDistributionRow.QuoteGuid = this._quoteGuid;
    premiumDistributionRow.Factor = 1M;
    premiumDistributionRow.pdGuid = Guid.NewGuid();
    if (this._genericRaterDataset.tblQuoteOptionGeneric.Count > 0)
    {
      if (!this._genericRaterDataset.tblQuoteOptionGeneric[0].IsStateIDNull())
        premiumDistributionRow.StateID = this._genericRaterDataset.tblQuoteOptionGeneric[0].StateID;
      if (!this._genericRaterDataset.tblQuoteOptionGeneric[0].IsChargeCodeNull())
        premiumDistributionRow.ChargeCode = this._genericRaterDataset.tblQuoteOptionGeneric[0].ChargeCode;
      if (!this._genericRaterDataset.tblQuoteOptionGeneric[0].IsEndorsementCalcTypeNull())
        premiumDistributionRow.EndorsementCalcType = this._genericRaterDataset.tblQuoteOptionGeneric[0].EndorsementCalcType;
    }
    this.ds.tblGenericPremiumDistribution.AddtblGenericPremiumDistributionRow(row);
    this.SetFormEnablement(true);
    this.bmb.Position = this.ds.tblGenericPremiumDistribution.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidFormData())
    {
      e.Cancel = true;
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        if (((UltraToggleEditorBase) this.checkRoundPremiums).Checked)
        {
          if (!this.ds.tblGenericPremiumDistribution[this.bmb.Position].IsAnnualAmountNull())
            this.ds.tblGenericPremiumDistribution[this.bmb.Position].AnnualAmount = Math.Round(this.ds.tblGenericPremiumDistribution[this.bmb.Position].AnnualAmount, MidpointRounding.AwayFromZero);
          if (!this.ds.tblGenericPremiumDistribution[this.bmb.Position].IsBillAmountNull())
            this.ds.tblGenericPremiumDistribution[this.bmb.Position].BillAmount = Math.Round(this.ds.tblGenericPremiumDistribution[this.bmb.Position].BillAmount, MidpointRounding.AwayFromZero);
        }
        this.bmb.EndCurrentEdit();
        dsGenericPremDist.tblGenericPremiumDistributionRow premiumDistributionRow = this.ds.tblGenericPremiumDistribution[this.bmb.Position];
        Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.SavePremiumDistribution");
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblGenericPremiumDistribution.Columns)
          {
            string str = "@" + column.ColumnName.ToString();
            try
            {
              foreach (KeyValuePair<string, DbParameter> keyValuePair in dictionary)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(keyValuePair.Key.ToLower(), str.ToLower(), false) == 0)
                  dictionary[keyValuePair.Key].Value = RuntimeHelpers.GetObjectValue(premiumDistributionRow[column.ColumnName]);
              }
            }
            finally
            {
              Dictionary<string, DbParameter>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, "SavePremiumDistribution", (CommandArgumentType) 2, new object[1]
        {
          (object) dictionary
        }));
        this.ds.tblGenericPremiumDistribution.AcceptChanges();
        this._clickSaveUpdates = true;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.SetFormEnablement(false);
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblGenericPremiumDistribution.RejectChanges();
    this.SetFormEnablement(false);
    this.SetSaveState();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      e.Cancel = true;
    else if (MessageBox.Show("Continue with the deletion of the current row?", "Continue Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      e.Cancel = true;
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblGenericPremiumDistribution WHERE pdGuid = @pdGuid", new object[2]
        {
          (object) "@pdGuid",
          (object) this.ds.tblGenericPremiumDistribution[this.bmb.Position].pdGuid
        });
        this.ds.tblGenericPremiumDistribution[this.bmb.Position].Delete();
        this.ds.tblGenericPremiumDistribution.AcceptChanges();
        this._clickSaveUpdates = true;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.SetSaveState();
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.SetFormEnablement(true);
  }

  private void dgOptions_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgOptions).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).ActiveRow.Cells["pdGuid"].Value), "pdGuid", (DataTable) this.ds.tblGenericPremiumDistribution, this.bmb);
  }

  private void cboChargeCodes_BeforeDropDown(object sender, CancelEventArgs e)
  {
    string empty = string.Empty;
    if (this.cboState.Value != null && this.cboState.Value != DBNull.Value)
      empty = this.cboState.Value.ToString();
    foreach (UltraGridRow row in ((UltraGridBase) this.cboChargeCodes).Rows)
    {
      row.Hidden = true;
      if (row.Cells["StateID"].Value != DBNull.Value && row.Cells["StateID"].Value != null)
        row.Hidden = !empty.Equals(row.Cells["StateID"].Value.ToString());
    }
  }

  private void numAnnualAmount_ValueChanged(object sender, EventArgs e)
  {
    this.CalculateBilledAmount();
  }

  private void CalculateBilledAmount()
  {
    this.numBillAmount.Value = (object) 0;
    this.numFactor.Value = (object) 1;
    Decimal num = 0M;
    if (this.numAnnualAmount.Value != null && this.numAnnualAmount.Value != DBNull.Value)
    {
      num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numAnnualAmount.Value));
      if (((UltraToggleEditorBase) this.checkRoundPremiums).Checked)
        num = Math.Round(num, MidpointRounding.AwayFromZero);
    }
    if (this.cboEndorsementCalcType.Value != null && this.cboEndorsementCalcType.Value != DBNull.Value)
    {
      if (this.cboEndorsementCalcType.Value.ToString().Equals("F"))
        this.numBillAmount.Value = (object) num;
      else if (this.cboEndorsementCalcType.Value.ToString().Equals("P"))
      {
        this.numBillAmount.Value = (object) Decimal.Multiply(num, this._proRata);
        this.numFactor.Value = (object) this._proRata;
      }
      else if (this.cboEndorsementCalcType.Value.ToString().Equals("R") || this.cboEndorsementCalcType.Value.ToString().Equals("S"))
      {
        this.numBillAmount.Value = (object) Decimal.Multiply(num, this._shortRate);
        this.numFactor.Value = (object) this._shortRate;
      }
      else
        this.numBillAmount.Value = RuntimeHelpers.GetObjectValue(this.numAnnualAmount.Value);
    }
    if (!((UltraToggleEditorBase) this.checkRoundPremiums).Checked)
      return;
    if (this.numBillAmount.Value != null && this.numBillAmount.Value != DBNull.Value)
      this.numBillAmount.Value = (object) Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numBillAmount.Value)));
    if (this.numBillAmount.Value == null || this.numBillAmount.Value == DBNull.Value)
      return;
    this.numBillAmount.Value = (object) Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.numBillAmount.Value)), MidpointRounding.AwayFromZero);
  }

  private void cboEndorsementCalcType_ValueChanged(object sender, EventArgs e)
  {
    this.CalculateBilledAmount();
  }
}
