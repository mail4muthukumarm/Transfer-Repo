// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.EquipmentBreakdown.frmEquipmentBreakdownRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.EquipmentBreakdown;

public class frmEquipmentBreakdownRater : Form
{
  private IContainer components;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cn;
  private SqlDataAdapter daEquipment;
  private dsEquipmentBreakdown ds;
  private UltraGrid gridOptions;
  private MGAGroupBox MgaGroupBox1;
  private MGASystems.Tools.DBSaveUI.DBSaveUI dbSave;
  private Label Label1;
  private MGANumericEditor MgaNumericEditor1;
  private MGANumericEditor MgaNumericEditor2;
  private Label Label2;
  private MGATextBox MgaTextBox1;
  private Label Label3;
  private MGANumericEditor MgaNumericEditor3;
  private Label Label4;

  public frmEquipmentBreakdownRater() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEquipmentBreakdownRater));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblQuoteOptionEquipmentBreakdown", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PriorID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TerrorismDeclined");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PolicyLimitDescriptionID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TIV");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("NoofLocations");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Coverage");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PolicyLimitPerAccident");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("BusinessInterruption");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ExtraExpense");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("OffPremService");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ExpeditingExp");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AmmoniaCont");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("WaterDamage");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AOPDA");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("DeductiblePerID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("OtherDeduct");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Premium");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("TerrPremium");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AdditionalComments");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Rate");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("PriorRate");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.daEquipment = new SqlDataAdapter();
    this.ds = new dsEquipmentBreakdown();
    this.gridOptions = new UltraGrid();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.MgaNumericEditor3 = new MGANumericEditor();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.Label2 = new Label();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.Label1 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ds.BeginInit();
    ((ISupportInitialize) this.gridOptions).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor3).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    this.SuspendLayout();
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[23]
    {
      new SqlParameter("@PriorID", SqlDbType.Int, 4, "PriorID"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 1, "TerrorismDeclined"),
      new SqlParameter("@PolicyLimitDescriptionID", SqlDbType.TinyInt, 1, "PolicyLimitDescriptionID"),
      new SqlParameter("@PolicyFormID", SqlDbType.TinyInt, 1, "PolicyFormID"),
      new SqlParameter("@TIV", SqlDbType.Money, 8, "TIV"),
      new SqlParameter("@NoofLocations", SqlDbType.TinyInt, 1, "NoofLocations"),
      new SqlParameter("@Coverage", SqlDbType.VarChar, 500, "Coverage"),
      new SqlParameter("@PolicyLimitPerAccident", SqlDbType.Money, 8, "PolicyLimitPerAccident"),
      new SqlParameter("@BusinessInterruption", SqlDbType.VarChar, 50, "BusinessInterruption"),
      new SqlParameter("@ExtraExpense", SqlDbType.VarChar, 50, "ExtraExpense"),
      new SqlParameter("@OffPremService", SqlDbType.VarChar, 50, "OffPremService"),
      new SqlParameter("@ExpeditingExp", SqlDbType.Money, 8, "ExpeditingExp"),
      new SqlParameter("@AmmoniaCont", SqlDbType.Money, 8, "AmmoniaCont"),
      new SqlParameter("@WaterDamage", SqlDbType.Money, 8, "WaterDamage"),
      new SqlParameter("@AOPDA", SqlDbType.Int, 4, "AOPDA"),
      new SqlParameter("@DeductiblePerID", SqlDbType.VarChar, 1, "DeductiblePerID"),
      new SqlParameter("@OtherDeduct", SqlDbType.VarChar, 500, "OtherDeduct"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null)
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[48 /*0x30*/]
    {
      new SqlParameter("@PriorID", SqlDbType.Int, 4, "PriorID"),
      new SqlParameter("@QuoteOptionID", SqlDbType.Int, 4, "QuoteOptionID"),
      new SqlParameter("@TerrorismDeclined", SqlDbType.Bit, 1, "TerrorismDeclined"),
      new SqlParameter("@PolicyLimitDescriptionID", SqlDbType.TinyInt, 1, "PolicyLimitDescriptionID"),
      new SqlParameter("@PolicyFormID", SqlDbType.TinyInt, 1, "PolicyFormID"),
      new SqlParameter("@TIV", SqlDbType.Money, 8, "TIV"),
      new SqlParameter("@NoofLocations", SqlDbType.TinyInt, 1, "NoofLocations"),
      new SqlParameter("@Coverage", SqlDbType.VarChar, 500, "Coverage"),
      new SqlParameter("@PolicyLimitPerAccident", SqlDbType.Money, 8, "PolicyLimitPerAccident"),
      new SqlParameter("@BusinessInterruption", SqlDbType.VarChar, 50, "BusinessInterruption"),
      new SqlParameter("@ExtraExpense", SqlDbType.VarChar, 50, "ExtraExpense"),
      new SqlParameter("@OffPremService", SqlDbType.VarChar, 50, "OffPremService"),
      new SqlParameter("@ExpeditingExp", SqlDbType.Money, 8, "ExpeditingExp"),
      new SqlParameter("@AmmoniaCont", SqlDbType.Money, 8, "AmmoniaCont"),
      new SqlParameter("@WaterDamage", SqlDbType.Money, 8, "WaterDamage"),
      new SqlParameter("@AOPDA", SqlDbType.Int, 4, "AOPDA"),
      new SqlParameter("@DeductiblePerID", SqlDbType.VarChar, 1, "DeductiblePerID"),
      new SqlParameter("@OtherDeduct", SqlDbType.VarChar, 500, "OtherDeduct"),
      new SqlParameter("@Premium", SqlDbType.Money, 8, "Premium"),
      new SqlParameter("@TerrPremium", SqlDbType.Money, 8, "TerrPremium"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, 2000, "AdditionalComments"),
      new SqlParameter("@Rate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Current, (object) null),
      new SqlParameter("@PriorRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Current, (object) null),
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AOPDA", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AOPDA", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AdditionalComments", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalComments", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AmmoniaCont", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AmmoniaCont", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_BusinessInterruption", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BusinessInterruption", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Coverage", SqlDbType.VarChar, 500, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Coverage", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeductiblePerID", SqlDbType.VarChar, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DeductiblePerID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ExpeditingExp", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExpeditingExp", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ExtraExpense", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExtraExpense", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_NoofLocations", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NoofLocations", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OffPremService", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OffPremService", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OtherDeduct", SqlDbType.VarChar, 500, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OtherDeduct", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyFormID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyFormID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyLimitDescriptionID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyLimitDescriptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyLimitPerAccident", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyLimitPerAccident", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Premium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Premium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PriorID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PriorID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PriorRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Rate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TIV", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TIV", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TerrPremium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TerrPremium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TerrorismDeclined", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TerrorismDeclined", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_WaterDamage", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WaterDamage", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[24]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AOPDA", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AOPDA", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AdditionalComments", SqlDbType.VarChar, 2000, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalComments", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AmmoniaCont", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AmmoniaCont", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_BusinessInterruption", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BusinessInterruption", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Coverage", SqlDbType.VarChar, 500, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Coverage", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_DeductiblePerID", SqlDbType.VarChar, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DeductiblePerID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ExpeditingExp", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExpeditingExp", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ExtraExpense", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExtraExpense", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_NoofLocations", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NoofLocations", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OffPremService", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OffPremService", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OtherDeduct", SqlDbType.VarChar, 500, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OtherDeduct", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyFormID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyFormID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyLimitDescriptionID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyLimitDescriptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PolicyLimitPerAccident", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyLimitPerAccident", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Premium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Premium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PriorID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PriorID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_PriorRate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "PriorRate", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteOptionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteOptionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Rate", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 6, (byte) 4, "Rate", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TIV", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TIV", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TerrPremium", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TerrPremium", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_TerrorismDeclined", SqlDbType.Bit, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TerrorismDeclined", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_WaterDamage", SqlDbType.Money, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "WaterDamage", DataRowVersion.Original, (object) null)
    });
    this.daEquipment.DeleteCommand = this.SqlDeleteCommand1;
    this.daEquipment.InsertCommand = this.SqlInsertCommand1;
    this.daEquipment.SelectCommand = this.SqlSelectCommand1;
    this.daEquipment.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteOptionEquipmentBreakdown", new DataColumnMapping[24]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("PriorID", "PriorID"),
        new DataColumnMapping("QuoteOptionID", "QuoteOptionID"),
        new DataColumnMapping("TerrorismDeclined", "TerrorismDeclined"),
        new DataColumnMapping("PolicyLimitDescriptionID", "PolicyLimitDescriptionID"),
        new DataColumnMapping("PolicyFormID", "PolicyFormID"),
        new DataColumnMapping("TIV", "TIV"),
        new DataColumnMapping("NoofLocations", "NoofLocations"),
        new DataColumnMapping("Coverage", "Coverage"),
        new DataColumnMapping("PolicyLimitPerAccident", "PolicyLimitPerAccident"),
        new DataColumnMapping("BusinessInterruption", "BusinessInterruption"),
        new DataColumnMapping("ExtraExpense", "ExtraExpense"),
        new DataColumnMapping("OffPremService", "OffPremService"),
        new DataColumnMapping("ExpeditingExp", "ExpeditingExp"),
        new DataColumnMapping("AmmoniaCont", "AmmoniaCont"),
        new DataColumnMapping("WaterDamage", "WaterDamage"),
        new DataColumnMapping("AOPDA", "AOPDA"),
        new DataColumnMapping("DeductiblePerID", "DeductiblePerID"),
        new DataColumnMapping("OtherDeduct", "OtherDeduct"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("TerrPremium", "TerrPremium"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments"),
        new DataColumnMapping("Rate", "Rate"),
        new DataColumnMapping("PriorRate", "PriorRate")
      })
    });
    this.daEquipment.UpdateCommand = this.SqlUpdateCommand1;
    this.ds.DataSetName = "dsEquipmentBreakdown";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.gridOptions).DataSource = (object) this.ds.tblQuoteOptionEquipmentBreakdown;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOptions).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 19;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 32 /*0x20*/;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 129;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 47;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 29;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance3;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 131;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "# Locations";
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 128 /*0x80*/;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 53;
    ultraGridColumn10.Format = "c";
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Limit/Accident";
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 62;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 59;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 48 /*0x30*/;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 48 /*0x30*/;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 41;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 39;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 74;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance7;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Width = 74;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 89;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn19.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Other Deduct";
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Width = 126;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance10;
    ultraGridColumn20.Format = "c";
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance11;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Width = 103;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn21.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance13;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Width = 98;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 53;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance15;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Width = 98;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 34;
    ultraGridBand.Columns.AddRange(new object[24]
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
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.gridOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = Color.LightSteelBlue;
    appearance16.FontData.SizeInPoints = 10f;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOptions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.Transparent;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridOptions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOptions).Location = new Point(8, 8);
    ((Control) this.gridOptions).Name = "gridOptions";
    ((Control) this.gridOptions).Size = new Size(760, 160 /*0xA0*/);
    ((Control) this.gridOptions).TabIndex = 0;
    ((UltraControlBase) this.gridOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOptions).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.FromArgb(239, 247, 253);
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance23;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    appearance24.AlphaLevel = (short) 230;
    appearance24.FontData.SizeInPoints = 10f;
    appearance24.ForeColor = Color.White;
    appearance24.ForegroundAlpha = (Alpha) 2;
    appearance24.ImageAlpha = (Alpha) 2;
    appearance24.ImageBackground = (Image) componentResourceManager.GetObject("Appearance28.ImageBackground");
    appearance24.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance24;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 176 /*0xB0*/);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(376, 168);
    ((Control) this.MgaGroupBox1).TabIndex = 1;
    this.MgaGroupBox1.Text = "Risk Information";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor3).Appearance = (AppearanceBase) appearance25;
    ((Control) this.MgaNumericEditor3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionEquipmentBreakdown.PolicyLimitPerAccident", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor3).FormatString = "c";
    ((Control) this.MgaNumericEditor3).Location = new Point(120, 104);
    this.MgaNumericEditor3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor3).Name = "MgaNumericEditor3";
    this.MgaNumericEditor3.Nullable = true;
    ((Control) this.MgaNumericEditor3).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor3).TabIndex = 7;
    ((UltraControlBase) this.MgaNumericEditor3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(8, 104);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(100, 23);
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Limit/Accident:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(8, 80 /*0x50*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(100, 23);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "Coverage:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionEquipmentBreakdown.Coverage", true));
    ((Control) this.MgaTextBox1).Location = new Point(120, 80 /*0x50*/);
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(216, 20);
    ((Control) this.MgaTextBox1).TabIndex = 4;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance27;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionEquipmentBreakdown.BusinessInterruption", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor2).FormatString = "nnn";
    ((Control) this.MgaNumericEditor2).Location = new Point(120, 56);
    this.MgaNumericEditor2.MaxValue = (object) 999;
    this.MgaNumericEditor2.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor2.MinValue = (object) 0;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    this.MgaNumericEditor2.Nullable = true;
    ((Control) this.MgaNumericEditor2).Size = new Size(48 /*0x30*/, 20);
    ((Control) this.MgaNumericEditor2).TabIndex = 3;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(100, 23);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "# Locations:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance28;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteOptionEquipmentBreakdown.TIV", true));
    ((UltraNumericEditorBase) this.MgaNumericEditor1).FormatString = "c";
    ((Control) this.MgaNumericEditor1).Location = new Point(120, 32 /*0x20*/);
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    this.MgaNumericEditor1.Nullable = true;
    ((Control) this.MgaNumericEditor1).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(100, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "TIV:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(656, 304);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(776, 350);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.gridOptions);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmEquipmentBreakdownRater);
    this.Text = "Equipment Breakdown Rater";
    this.ds.EndInit();
    ((ISupportInitialize) this.gridOptions).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.MgaNumericEditor3).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    this.ResumeLayout(false);
  }
}
