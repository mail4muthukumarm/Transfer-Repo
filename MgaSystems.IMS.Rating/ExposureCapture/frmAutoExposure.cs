// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.frmAutoExposure
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.ExposureCapture;

[MGASystems.IMS.Policies.Rating.ExposureCapture.ExposureCapture("Auto")]
public class frmAutoExposure : Form, IExposureCapture
{
  private IContainer components;
  private SqlConnection cn;
  private SqlDataAdapter daExposure;
  private SqlCommand SqlSelectCommand2;
  private SqlDataAdapter daStates;
  private dsAutoExposure ds;
  private UltraDropDown ddStates;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private int _quoteID;
  private BindingManagerBase _bmb;
  private bool _isEndorsement;

  public frmAutoExposure()
  {
    this.Load += new EventHandler(this.frmAutoExposure_Load);
    this._quoteID = -1;
    this._isEndorsement = false;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid grid
  {
    get => this._grid;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.grid_AfterRowActivate);
      UltraGrid grid1 = this._grid;
      if (grid1 != null)
        grid1.AfterRowActivate -= eventHandler;
      this._grid = value;
      UltraGrid grid2 = this._grid;
      if (grid2 == null)
        return;
      grid2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
    }
  }

  [field: AccessedThroughProperty("gbAutoExposure")]
  protected virtual UltraGroupBox gbAutoExposure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMake")]
  private virtual MGATextBox txtMake { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numYear")]
  private virtual MGANumericEditor numYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtVIN")]
  private virtual MGATextBox txtVIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtModel")]
  private virtual MGATextBox txtModel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtClass")]
  private virtual MGATextBox txtClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtVehicleNumber")]
  private virtual MGATextBox txtVehicleNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  private virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtGVW")]
  private virtual MGATextBox txtGVW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  private virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox9")]
  private virtual MGATextBox MgaTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox8")]
  private virtual MGATextBox MgaTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox7")]
  private virtual MGATextBox MgaTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox5")]
  private virtual MGATextBox MgaTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  private virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox3")]
  private virtual MGATextBox MgaTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor1")]
  private virtual MGANumericEditor MgaNumericEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAutoExposure));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblGenericAutoExposures", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AutoID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Make");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Model");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("VIN");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AutoClassID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GVW");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("GarageTerr");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("StatedValue");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Usage");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Radius");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CostNew");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("VehicleNumber");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("VehicleSeatingCapacity");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AgeGroup");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("PrimaryRatingFactor");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("SecondaryRatingFactor");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Deleted");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("lstStatestblGenericAutoExposures");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstStatestblGenericAutoExposures", 0);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("AutoID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Make");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("Model");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("VIN");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("AutoClassID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("GVW");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("GarageTerr");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("StatedValue");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Usage");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Radius");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CostNew");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("VehicleNumber");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("VehicleSeatingCapacity");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("AgeGroup");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("PrimaryRatingFactor");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("SecondaryRatingFactor");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Deleted");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
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
    Appearance appearance38 = new Appearance();
    this.cn = new SqlConnection();
    this.daExposure = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daStates = new SqlDataAdapter();
    this.ds = new dsAutoExposure();
    this.grid = new UltraGrid();
    this.ddStates = new UltraDropDown();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.gbAutoExposure = new UltraGroupBox();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.Label8 = new Label();
    this.MgaTextBox9 = new MGATextBox();
    this.Label4 = new Label();
    this.txtVehicleNumber = new MGATextBox();
    this.Label7 = new Label();
    this.MgaTextBox8 = new MGATextBox();
    this.Label3 = new Label();
    this.MgaTextBox7 = new MGATextBox();
    this.Label18 = new Label();
    this.Label17 = new Label();
    this.MgaTextBox5 = new MGATextBox();
    this.Label16 = new Label();
    this.MgaTextBox4 = new MGATextBox();
    this.Label15 = new Label();
    this.MgaTextBox3 = new MGATextBox();
    this.Label14 = new Label();
    this.MgaTextBox2 = new MGATextBox();
    this.Label13 = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.Label12 = new Label();
    this.txtGVW = new MGATextBox();
    this.Label2 = new Label();
    this.txtClass = new MGATextBox();
    this.Label6 = new Label();
    this.txtVIN = new MGATextBox();
    this.Label5 = new Label();
    this.txtModel = new MGATextBox();
    this.Label1 = new Label();
    this.cboState = new MGASimpleComboBox();
    this.Label10 = new Label();
    this.txtMake = new MGATextBox();
    this.numYear = new MGANumericEditor();
    this.Label9 = new Label();
    this.err = new ErrorProvider(this.components);
    this.ds.BeginInit();
    ((ISupportInitialize) this.grid).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.gbAutoExposure).BeginInit();
    ((Control) this.gbAutoExposure).SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox9).BeginInit();
    ((ISupportInitialize) this.txtVehicleNumber).BeginInit();
    ((ISupportInitialize) this.MgaTextBox8).BeginInit();
    ((ISupportInitialize) this.MgaTextBox7).BeginInit();
    ((ISupportInitialize) this.MgaTextBox5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.txtGVW).BeginInit();
    ((ISupportInitialize) this.txtClass).BeginInit();
    ((ISupportInitialize) this.txtVIN).BeginInit();
    ((ISupportInitialize) this.txtModel).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.txtMake).BeginInit();
    ((ISupportInitialize) this.numYear).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.cn.ConnectionString = "Data Source=10.0.0.52;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.daExposure.DeleteCommand = this.SqlDeleteCommand1;
    this.daExposure.InsertCommand = this.SqlInsertCommand1;
    this.daExposure.SelectCommand = this.SqlSelectCommand1;
    this.daExposure.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericAutoExposures", new DataColumnMapping[20]
      {
        new DataColumnMapping("AutoID", "AutoID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("Year", "Year"),
        new DataColumnMapping("Make", "Make"),
        new DataColumnMapping("Model", "Model"),
        new DataColumnMapping("VIN", "VIN"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("AutoClassID", "AutoClassID"),
        new DataColumnMapping("GVW", "GVW"),
        new DataColumnMapping("GarageTerr", "GarageTerr"),
        new DataColumnMapping("StatedValue", "StatedValue"),
        new DataColumnMapping("Usage", "Usage"),
        new DataColumnMapping("Radius", "Radius"),
        new DataColumnMapping("CostNew", "CostNew"),
        new DataColumnMapping("VehicleNumber", "VehicleNumber"),
        new DataColumnMapping("VehicleSeatingCapacity", "VehicleSeatingCapacity"),
        new DataColumnMapping("AgeGroup", "AgeGroup"),
        new DataColumnMapping("PrimaryRatingFactor", "PrimaryRatingFactor"),
        new DataColumnMapping("SecondaryRatingFactor", "SecondaryRatingFactor"),
        new DataColumnMapping("Deleted", "Deleted")
      })
    });
    this.daExposure.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblGenericAutoExposures] WHERE (([AutoID] = @Original_AutoID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_AutoID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@Year", SqlDbType.SmallInt, 0, "Year"),
      new SqlParameter("@Make", SqlDbType.VarChar, 0, "Make"),
      new SqlParameter("@Model", SqlDbType.VarChar, 0, "Model"),
      new SqlParameter("@VIN", SqlDbType.VarChar, 0, "VIN"),
      new SqlParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      new SqlParameter("@AutoClassID", SqlDbType.VarChar, 0, "AutoClassID"),
      new SqlParameter("@GVW", SqlDbType.VarChar, 0, "GVW"),
      new SqlParameter("@GarageTerr", SqlDbType.VarChar, 0, "GarageTerr"),
      new SqlParameter("@StatedValue", SqlDbType.VarChar, 0, "StatedValue"),
      new SqlParameter("@Usage", SqlDbType.VarChar, 0, "Usage"),
      new SqlParameter("@Radius", SqlDbType.VarChar, 0, "Radius"),
      new SqlParameter("@CostNew", SqlDbType.VarChar, 0, "CostNew"),
      new SqlParameter("@VehicleNumber", SqlDbType.VarChar, 0, "VehicleNumber"),
      new SqlParameter("@VehicleSeatingCapacity", SqlDbType.TinyInt, 0, "VehicleSeatingCapacity"),
      new SqlParameter("@AgeGroup", SqlDbType.VarChar, 0, "AgeGroup"),
      new SqlParameter("@PrimaryRatingFactor", SqlDbType.VarChar, 0, "PrimaryRatingFactor"),
      new SqlParameter("@SecondaryRatingFactor", SqlDbType.VarChar, 0, "SecondaryRatingFactor"),
      new SqlParameter("@Deleted", SqlDbType.Bit, 0, "Deleted")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[21]
    {
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@Year", SqlDbType.SmallInt, 0, "Year"),
      new SqlParameter("@Make", SqlDbType.VarChar, 0, "Make"),
      new SqlParameter("@Model", SqlDbType.VarChar, 0, "Model"),
      new SqlParameter("@VIN", SqlDbType.VarChar, 0, "VIN"),
      new SqlParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      new SqlParameter("@AutoClassID", SqlDbType.VarChar, 0, "AutoClassID"),
      new SqlParameter("@GVW", SqlDbType.VarChar, 0, "GVW"),
      new SqlParameter("@GarageTerr", SqlDbType.VarChar, 0, "GarageTerr"),
      new SqlParameter("@StatedValue", SqlDbType.VarChar, 0, "StatedValue"),
      new SqlParameter("@Usage", SqlDbType.VarChar, 0, "Usage"),
      new SqlParameter("@Radius", SqlDbType.VarChar, 0, "Radius"),
      new SqlParameter("@CostNew", SqlDbType.VarChar, 0, "CostNew"),
      new SqlParameter("@VehicleNumber", SqlDbType.VarChar, 0, "VehicleNumber"),
      new SqlParameter("@VehicleSeatingCapacity", SqlDbType.TinyInt, 0, "VehicleSeatingCapacity"),
      new SqlParameter("@AgeGroup", SqlDbType.VarChar, 0, "AgeGroup"),
      new SqlParameter("@PrimaryRatingFactor", SqlDbType.VarChar, 0, "PrimaryRatingFactor"),
      new SqlParameter("@SecondaryRatingFactor", SqlDbType.VarChar, 0, "SecondaryRatingFactor"),
      new SqlParameter("@Deleted", SqlDbType.Bit, 0, "Deleted"),
      new SqlParameter("@Original_AutoID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutoID", DataRowVersion.Original, (object) null),
      new SqlParameter("@AutoID", SqlDbType.Int, 4, "AutoID")
    });
    this.SqlSelectCommand2.CommandText = "SELECT StateID, State FROM lstStates ORDER BY State";
    this.SqlSelectCommand2.Connection = this.cn;
    this.daStates.SelectCommand = this.SqlSelectCommand2;
    this.daStates.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      })
    });
    this.ds.DataSetName = "dsAutoExposure";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.grid).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.grid).DataSource = (object) this.ds.tblGenericAutoExposures;
    appearance1.BackColor = Color.WhiteSmoke;
    appearance1.BorderColor = Color.DarkGray;
    ((SpecialBoxBase) ((UltraGridBase) this.grid).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.grid).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.grid).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.grid).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grid).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 54;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 52;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 99;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 71;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 77;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 78;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Width = 109;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Class";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 89;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 105;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Garage Terr";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 207;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Stated Value";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Width = 93;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 13;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 104;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 14;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 96 /*0x60*/;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Cost New";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 12;
    ultraGridColumn14.Width = 118;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Vehicle #";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 4;
    ultraGridColumn15.Width = 65;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 126;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 96 /*0x60*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 82;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 84;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Width = 54;
    ultraGridBand1.Columns.AddRange(new object[20]
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
      (object) ultraGridColumn20
    });
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.grid).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grid).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.grid).Location = new Point(14, 12);
    ((Control) this.grid).Name = "grid";
    ((Control) this.grid).Size = new Size(855, 194);
    ((Control) this.grid).TabIndex = 2;
    ((Control) this.grid).Text = "Auto Exposure";
    ((UltraControlBase) this.grid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grid).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds.lstStates;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddStates).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 0;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 104;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ultraGridColumn22.Width = 169;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 1;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 2;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 3;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 4;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 5;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 6;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 7;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 8;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 9;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 10;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 11;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 12;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 13;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 14;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 15;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 17;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 19;
    ultraGridBand3.Columns.AddRange(new object[20]
    {
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
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.LightSteelBlue;
    appearance12.FontData.SizeInPoints = 10f;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ddStates).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.Transparent;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.WhiteSmoke;
    appearance19.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(423, 106);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(188, 61);
    ((Control) this.ddStates).TabIndex = 1;
    ((Control) this.ddStates).Text = "UltraDropDown1";
    ((UltraControlBase) this.ddStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(757, 462);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 1;
    ((Control) this.gbAutoExposure).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance21.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.gbAutoExposure.ContentAreaAppearance = (AppearanceBase) appearance21;
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label8);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox9);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label4);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.txtVehicleNumber);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label7);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox8);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label3);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox7);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label18);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label17);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox5);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label16);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox4);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label15);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox3);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label14);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label13);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label12);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.txtGVW);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label2);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.txtClass);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label6);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.txtVIN);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label5);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.txtModel);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label1);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.cboState);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label10);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.txtMake);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.numYear);
    ((Control) this.gbAutoExposure).Controls.Add((Control) this.Label9);
    appearance22.BackColor = Color.FromArgb(159, 188, 218);
    appearance22.BackColor2 = Color.FromArgb(183, 210, 239);
    appearance22.FontData.BoldAsString = "True";
    appearance22.ForeColor = Color.FromArgb(13, 40, 107);
    this.gbAutoExposure.HeaderAppearance = (AppearanceBase) appearance22;
    ((Control) this.gbAutoExposure).Location = new Point(14, 212);
    ((Control) this.gbAutoExposure).Name = "gbAutoExposure";
    ((Control) this.gbAutoExposure).Size = new Size(855, 244);
    ((Control) this.gbAutoExposure).TabIndex = 0;
    this.gbAutoExposure.Text = "Auto Exposure Details";
    this.gbAutoExposure.ViewStyle = (GroupBoxViewStyle) 2;
    appearance23.BackColorDisabled = Color.Gainsboro;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance23;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericAutoExposures.VehicleSeatingCapacity", true));
    ((Control) this.MgaNumericEditor1).Location = new Point(682, 68);
    this.MgaNumericEditor1.MaskInput = "nnnn";
    this.MgaNumericEditor1.MaxValue = (object) 9999;
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.MgaNumericEditor1.MinValue = (object) 0;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    this.MgaNumericEditor1.Nullable = true;
    ((Control) this.MgaNumericEditor1).Size = new Size(56, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 13;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(546, 172);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(92, 23);
    this.Label8.TabIndex = 48 /*0x30*/;
    this.Label8.Text = "Secondary Rating Factor:";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox9).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.MgaTextBox9).BackColor = Color.White;
    ((Control) this.MgaTextBox9).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.SecondaryRatingFactor", true));
    ((Control) this.MgaTextBox9).Location = new Point(682, 174);
    ((TextEditorControlBase) this.MgaTextBox9).MaxLength = 20;
    this.MgaTextBox9.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox9).Name = "MgaTextBox9";
    ((Control) this.MgaTextBox9).Size = new Size(100, 20);
    ((Control) this.MgaTextBox9).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaTextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox9).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(543, 137);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(129, 23);
    this.Label4.TabIndex = 46;
    this.Label4.Text = "Primary Rating Factor:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtVehicleNumber).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.txtVehicleNumber).BackColor = Color.White;
    ((Control) this.txtVehicleNumber).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.VehicleNumber", true));
    ((Control) this.txtVehicleNumber).Location = new Point(97, 33);
    ((TextEditorControlBase) this.txtVehicleNumber).MaxLength = 20;
    this.txtVehicleNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtVehicleNumber).Name = "txtVehicleNumber";
    ((Control) this.txtVehicleNumber).Size = new Size(100, 20);
    ((Control) this.txtVehicleNumber).TabIndex = 0;
    ((UltraControlBase) this.txtVehicleNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtVehicleNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(65, 23);
    this.Label7.TabIndex = 26;
    this.Label7.Text = "Vehicle #:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox8).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.MgaTextBox8).BackColor = Color.White;
    ((Control) this.MgaTextBox8).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.PrimaryRatingFactor", true));
    ((Control) this.MgaTextBox8).Location = new Point(682, 139);
    ((TextEditorControlBase) this.MgaTextBox8).MaxLength = 20;
    this.MgaTextBox8.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox8).Name = "MgaTextBox8";
    ((Control) this.MgaTextBox8).Size = new Size(100, 20);
    ((Control) this.MgaTextBox8).TabIndex = 15;
    ((UltraControlBase) this.MgaTextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox8).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(543, 102);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(115, 23);
    this.Label3.TabIndex = 44;
    this.Label3.Text = "Age Group:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox7).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.MgaTextBox7).BackColor = Color.White;
    ((Control) this.MgaTextBox7).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.AgeGroup", true));
    ((Control) this.MgaTextBox7).Location = new Point(682, 104);
    ((TextEditorControlBase) this.MgaTextBox7).MaxLength = 20;
    this.MgaTextBox7.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox7).Name = "MgaTextBox7";
    ((Control) this.MgaTextBox7).Size = new Size(100, 20);
    ((Control) this.MgaTextBox7).TabIndex = 14;
    ((UltraControlBase) this.MgaTextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox7).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(543, 66);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(129, 23);
    this.Label18.TabIndex = 42;
    this.Label18.Text = "Vehicle Seating Capacity:";
    this.Label18.TextAlign = ContentAlignment.MiddleLeft;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(546, 31 /*0x1F*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(92, 23);
    this.Label17.TabIndex = 40;
    this.Label17.Text = "Radius:";
    this.Label17.TextAlign = ContentAlignment.MiddleLeft;
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox5).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.MgaTextBox5).BackColor = Color.White;
    ((Control) this.MgaTextBox5).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.Radius", true));
    ((Control) this.MgaTextBox5).Location = new Point(682, 33);
    ((TextEditorControlBase) this.MgaTextBox5).MaxLength = 20;
    this.MgaTextBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox5).Name = "MgaTextBox5";
    ((Control) this.MgaTextBox5).Size = new Size(100, 20);
    ((Control) this.MgaTextBox5).TabIndex = 12;
    ((UltraControlBase) this.MgaTextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox5).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(307, 208 /*0xD0*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(70, 23);
    this.Label16.TabIndex = 38;
    this.Label16.Text = "Usage:";
    this.Label16.TextAlign = ContentAlignment.MiddleLeft;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.Usage", true));
    ((Control) this.MgaTextBox4).Location = new Point(396, 209);
    ((TextEditorControlBase) this.MgaTextBox4).MaxLength = 20;
    this.MgaTextBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(100, 20);
    ((Control) this.MgaTextBox4).TabIndex = 11;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(307, 173);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(70, 23);
    this.Label15.TabIndex = 36;
    this.Label15.Text = "Cost New:";
    this.Label15.TextAlign = ContentAlignment.MiddleLeft;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance30;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.CostNew", true));
    ((Control) this.MgaTextBox3).Location = new Point(396, 174);
    ((TextEditorControlBase) this.MgaTextBox3).MaxLength = 20;
    this.MgaTextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(100, 20);
    ((Control) this.MgaTextBox3).TabIndex = 10;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(307, 138);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(70, 23);
    this.Label14.TabIndex = 34;
    this.Label14.Text = "Stated Value:";
    this.Label14.TextAlign = ContentAlignment.MiddleLeft;
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance31;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.StatedValue", true));
    ((Control) this.MgaTextBox2).Location = new Point(396, 139);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 20;
    this.MgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(100, 20);
    ((Control) this.MgaTextBox2).TabIndex = 9;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(307, 103);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(80 /*0x50*/, 23);
    this.Label13.TabIndex = 32 /*0x20*/;
    this.Label13.Text = "Garage Terr:";
    this.Label13.TextAlign = ContentAlignment.MiddleLeft;
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance32;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.GarageTerr", true));
    ((Control) this.MgaTextBox1).Location = new Point(396, 104);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 20;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(100, 20);
    ((Control) this.MgaTextBox1).TabIndex = 8;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(307, 67);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(70, 23);
    this.Label12.TabIndex = 30;
    this.Label12.Text = "GVW:";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtGVW).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.txtGVW).BackColor = Color.White;
    ((Control) this.txtGVW).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.GVW", true));
    ((Control) this.txtGVW).Location = new Point(396, 68);
    ((TextEditorControlBase) this.txtGVW).MaxLength = 20;
    this.txtGVW.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtGVW).Name = "txtGVW";
    ((Control) this.txtGVW).Size = new Size(100, 20);
    ((Control) this.txtGVW).TabIndex = 7;
    ((UltraControlBase) this.txtGVW).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGVW).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(304, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(73, 23);
    this.Label2.TabIndex = 28;
    this.Label2.Text = "Class:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtClass).Appearance = (AppearanceBase) appearance34;
    ((TextEditorControlBase) this.txtClass).BackColor = Color.White;
    ((Control) this.txtClass).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.AutoClassID", true));
    ((Control) this.txtClass).Location = new Point(396, 33);
    ((TextEditorControlBase) this.txtClass).MaxLength = 20;
    this.txtClass.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtClass).Name = "txtClass";
    ((Control) this.txtClass).Size = new Size(100, 20);
    ((Control) this.txtClass).TabIndex = 6;
    ((UltraControlBase) this.txtClass).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClass).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(19, 208 /*0xD0*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(62, 23);
    this.Label6.TabIndex = 24;
    this.Label6.Text = "VIN:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtVIN).Appearance = (AppearanceBase) appearance35;
    ((TextEditorControlBase) this.txtVIN).BackColor = Color.White;
    ((Control) this.txtVIN).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.VIN", true));
    ((Control) this.txtVIN).Location = new Point(97, 209);
    ((TextEditorControlBase) this.txtVIN).MaxLength = 20;
    this.txtVIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtVIN).Name = "txtVIN";
    ((Control) this.txtVIN).Size = new Size(100, 20);
    ((Control) this.txtVIN).TabIndex = 5;
    ((UltraControlBase) this.txtVIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtVIN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(19, 173);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(62, 23);
    this.Label5.TabIndex = 22;
    this.Label5.Text = "Model:";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtModel).Appearance = (AppearanceBase) appearance36;
    ((TextEditorControlBase) this.txtModel).BackColor = Color.White;
    ((Control) this.txtModel).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.Model", true));
    ((Control) this.txtModel).Location = new Point(97, 174);
    ((TextEditorControlBase) this.txtModel).MaxLength = 20;
    this.txtModel.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtModel).Name = "txtModel";
    ((Control) this.txtModel).Size = new Size(100, 20);
    ((Control) this.txtModel).TabIndex = 4;
    ((UltraControlBase) this.txtModel).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtModel).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(19, 138);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(62, 23);
    this.Label1.TabIndex = 20;
    this.Label1.Text = "Make:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericAutoExposures.StateID", true));
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(97, 68);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(147, 21);
    ((Control) this.cboState).TabIndex = 1;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(19, 103);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(62, 23);
    this.Label10.TabIndex = 12;
    this.Label10.Text = "Year:";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    appearance37.BackColor = Color.White;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMake).Appearance = (AppearanceBase) appearance37;
    ((TextEditorControlBase) this.txtMake).BackColor = Color.White;
    ((Control) this.txtMake).DataBindings.Add(new Binding("Text", (object) this.ds, "tblGenericAutoExposures.Make", true));
    ((Control) this.txtMake).Location = new Point(97, 139);
    ((TextEditorControlBase) this.txtMake).MaxLength = 20;
    this.txtMake.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMake).Name = "txtMake";
    ((Control) this.txtMake).Size = new Size(100, 20);
    ((Control) this.txtMake).TabIndex = 3;
    ((UltraControlBase) this.txtMake).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMake).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BackColorDisabled = Color.Gainsboro;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numYear).Appearance = (AppearanceBase) appearance38;
    ((Control) this.numYear).DataBindings.Add(new Binding("Value", (object) this.ds, "tblGenericAutoExposures.Year", true));
    ((Control) this.numYear).Location = new Point(97, 104);
    this.numYear.MaskInput = "nnnn";
    this.numYear.MaxValue = (object) 9999;
    this.numYear.MGAStyle = MGAStyles.Blue;
    this.numYear.MinValue = (object) 0;
    ((Control) this.numYear).Name = "numYear";
    this.numYear.Nullable = true;
    ((Control) this.numYear).Size = new Size(56, 20);
    ((Control) this.numYear).TabIndex = 2;
    ((UltraControlBase) this.numYear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numYear).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(19, 71);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(62, 14);
    this.Label9.TabIndex = 0;
    this.Label9.Text = "State:";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(881, 514);
    this.Controls.Add((Control) this.gbAutoExposure);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.grid);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAutoExposure);
    this.Text = "Auto Exposure";
    this.ds.EndInit();
    ((ISupportInitialize) this.grid).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.gbAutoExposure).EndInit();
    ((Control) this.gbAutoExposure).ResumeLayout(false);
    ((Control) this.gbAutoExposure).PerformLayout();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.MgaTextBox9).EndInit();
    ((ISupportInitialize) this.txtVehicleNumber).EndInit();
    ((ISupportInitialize) this.MgaTextBox8).EndInit();
    ((ISupportInitialize) this.MgaTextBox7).EndInit();
    ((ISupportInitialize) this.MgaTextBox5).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.txtGVW).EndInit();
    ((ISupportInitialize) this.txtClass).EndInit();
    ((ISupportInitialize) this.txtVIN).EndInit();
    ((ISupportInitialize) this.txtModel).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.txtMake).EndInit();
    ((ISupportInitialize) this.numYear).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  protected virtual bool ValidState()
  {
    bool flag = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboState.Text, string.Empty, false) == 0)
    {
      flag = false;
      this.err.SetError((Control) this.cboState, "Please select a value");
    }
    else
      this.err.SetError((Control) this.cboState, string.Empty);
    if (this.numYear.Value != DBNull.Value && this.numYear.Value != null)
    {
      this.err.SetError((Control) this.numYear, string.Empty);
    }
    else
    {
      flag = false;
      this.err.SetError((Control) this.numYear, "Please enter a value");
    }
    if (((TextEditorControlBase) this.txtMake).Text.Replace(" ", string.Empty).Length == 0)
    {
      flag = false;
      this.err.SetError((Control) this.txtMake, "Please enter a value for make.");
    }
    else
      this.err.SetError((Control) this.txtMake, string.Empty);
    return flag;
  }

  public void SetQuoteId(int quoteId) => this._quoteID = quoteId;

  private void frmAutoExposure_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblGenericAutoExposures.TableName];
    this.daExposure.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daStates, (DataTable) this.ds.lstStates);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGenericAutoExposures);
    this._isEndorsement = new Quote(this._quoteID).IsEndorsement;
    this.EnableControl(false);
    this.SetSaveState();
    this.ShowDeletedRowAppearance();
  }

  private void SetSaveState()
  {
    if (this.ds.tblGenericAutoExposures.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void EnableControl(bool enableVal)
  {
    this.dbSave.Enabled = true;
    try
    {
      foreach (Control control in ((Control) this.gbAutoExposure).Controls)
        control.Enabled = enableVal;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.EnableControl(false);
    this.ds.tblGenericAutoExposures.RejectChanges();
    this.SetSaveState();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid to delete", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Do you wish to continue and delete?", "Continue Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      if (!this._isEndorsement)
        this.ds.tblGenericAutoExposures[this._bmb.Position].Delete();
      else
        this.ds.tblGenericAutoExposures[this._bmb.Position].Deleted = true;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daExposure, (DataTable) this.ds.tblGenericAutoExposures);
      this.SetSaveState();
      this.ShowDeletedRowAppearance();
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.EnableControl(true);

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsAutoExposure.tblGenericAutoExposuresRow row = this.ds.tblGenericAutoExposures.NewtblGenericAutoExposuresRow();
    row.QuoteID = this._quoteID;
    row.Deleted = false;
    this.ds.tblGenericAutoExposures.AddtblGenericAutoExposuresRow(row);
    this._bmb.Position = this.ds.tblGenericAutoExposures.Count - 1;
    this.EnableControl(true);
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidState())
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      MGASystems.Common.DataAccess.Database.SafeDataAdapterUpdate(this.daExposure, (DataTable) this.ds.tblGenericAutoExposures);
      this.EnableControl(false);
    }
  }

  private void grid_AfterRowActivate(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0 || ((UltraGridBase) this.grid).ActiveRow == null)
      return;
    MGASystems.Common.Functions.Database.MoveTo((object) (int) ((UltraGridBase) this.grid).ActiveRow.Cells["AutoID"].Value, this.ds.tblGenericAutoExposures.AutoIDColumn.ColumnName, (DataTable) this.ds.tblGenericAutoExposures, this._bmb);
  }

  private void ShowDeletedRowAppearance()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grid).Rows)
    {
      row.Appearance.ForeColor = SystemColors.ControlText;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
      if (row.Cells["Deleted"].Value != null && row.Cells["Deleted"].Value != DBNull.Value && (bool) row.Cells["Deleted"].Value)
      {
        row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Appearance.ForeColor = Color.Red;
      }
    }
  }
}
