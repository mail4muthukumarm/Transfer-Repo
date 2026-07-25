// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormSymbolAutomation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormSymbolAutomation : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private dsSymbolAutomation ds;
  private DbCommand SqlDeleteCommand;
  private DbCommand SqlInsertCommand;
  private DbCommand SqlUpdateCommand;
  private ErrorProvider err;
  private Label Label9;
  private Label Label8;
  private MemoryStream _gridlayout;
  private static object _syncLock = RuntimeHelpers.GetObjectValue(new object());

  public FormSymbolAutomation()
  {
    this.Load += new EventHandler(this.FormSymbolAutomation_Load);
    this._gridlayout = new MemoryStream();
    this.InitializeComponent();
  }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSymbolAutomation));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstAutoSymbolClass", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClassName");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstBusinessTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BusinessTypeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("BusinessType");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstAutoSymbolType", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("TypeName");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LocationName");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LineName");
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblAutoSymbol", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CompanyLocationGuid", -1, (object) "ddCompany");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LOB", -1, (object) "ddLine");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("InsuredCorporationType", -1, (object) "ddInsuredType");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Symbol");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("SymbolType", -1, (object) "ddSymbolType");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Class", -1, (object) "ddClass");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Disabled");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.daGetSymbol = DefaultDatabase.CreateDataAdapter();
    this.SqlDeleteCommand = DefaultDatabase.CreateCommand();
    this.SqlInsertCommand = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.SqlUpdateCommand = DefaultDatabase.CreateCommand();
    this.daLoadData = DefaultDatabase.CreateDataAdapter();
    this.DbCommand1 = DefaultDatabase.CreateCommand();
    this.err = new ErrorProvider(this.components);
    this.grbAuto = new MGAGroupBox();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.dtDisabled = new MGADateTimePicker();
    this.ds = new dsSymbolAutomation();
    this.dtEffective = new MGADateTimePicker();
    this.txtSymbol = new MGATextBox();
    this.cboSymbolType = new MGASimpleComboBox();
    this.cboCompanyLocation = new MGASimpleComboBox();
    this.cboState = new MGASimpleComboBox();
    this.cboClass = new MGASimpleComboBox();
    this.cboLOB = new MGASimpleComboBox();
    this.cboInsuredType = new MGASimpleComboBox();
    this.ddClass = new UltraDropDown();
    this.ddInsuredType = new UltraDropDown();
    this.ddSymbolType = new UltraDropDown();
    this.ddCompany = new UltraDropDown();
    this.ddLine = new UltraDropDown();
    this.gridSymbolAutomation = new UltraGrid();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.grbAuto).BeginInit();
    ((Control) this.grbAuto).SuspendLayout();
    ((ISupportInitialize) this.dtDisabled).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.txtSymbol).BeginInit();
    ((ISupportInitialize) this.cboSymbolType).BeginInit();
    ((ISupportInitialize) this.cboCompanyLocation).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboClass).BeginInit();
    ((ISupportInitialize) this.cboLOB).BeginInit();
    ((ISupportInitialize) this.cboInsuredType).BeginInit();
    ((ISupportInitialize) this.ddClass).BeginInit();
    ((ISupportInitialize) this.ddInsuredType).BeginInit();
    ((ISupportInitialize) this.ddSymbolType).BeginInit();
    ((ISupportInitialize) this.ddCompany).BeginInit();
    ((ISupportInitialize) this.ddLine).BeginInit();
    ((ISupportInitialize) this.gridSymbolAutomation).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(17, 35);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(45, 13);
    this.Label1.TabIndex = 6;
    this.Label1.Text = "Symbol:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(17, 61);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(72, 13);
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Symbol Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(17, 88);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(99, 13);
    this.Label3.TabIndex = 9;
    this.Label3.Text = "Company Location:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(17, 115);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(89, 13);
    this.Label4.TabIndex = 10;
    this.Label4.Text = "Line Of Business:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(17, 142);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(37, 13);
    this.Label5.TabIndex = 11;
    this.Label5.Text = "State:";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(407, 35);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(75, 13);
    this.Label6.TabIndex = 12;
    this.Label6.Text = "Insured Type:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(407, 61);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(36, 13);
    this.Label7.TabIndex = 13;
    this.Label7.Text = "Class:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    ((UserControl) this.dbSave).AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(678, 423);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 0;
    this.cnDB = DefaultDatabase.CreateDbConnection();
    this.daGetSymbol.DeleteCommand = this.SqlDeleteCommand;
    this.daGetSymbol.InsertCommand = this.SqlInsertCommand;
    this.daGetSymbol.SelectCommand = this.DbSelectCommand1;
    this.daGetSymbol.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblAutoSymbol", new DataColumnMapping[10]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("LOB", "LOB"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("InsuredCorporationType", "InsuredCorporationType"),
        new DataColumnMapping("Symbol", "Symbol"),
        new DataColumnMapping("SymbolType", "SymbolType"),
        new DataColumnMapping("Class", "Class"),
        new DataColumnMapping("Effective", "Effective"),
        new DataColumnMapping("Disabled", "Disabled")
      })
    });
    this.daGetSymbol.UpdateCommand = this.SqlUpdateCommand;
    this.SqlDeleteCommand.CommandText = "DELETE FROM [dbo].[tblAutoSymbol] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand.Connection = this.cnDB;
    this.SqlDeleteCommand.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand.CommandText = componentResourceManager.GetString("SqlInsertCommand.CommandText");
    this.SqlInsertCommand.Connection = this.cnDB;
    this.SqlInsertCommand.Parameters.AddRange((Array) new DbParameter[9]
    {
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@LOB", SqlDbType.UniqueIdentifier, 0, "LOB"),
      DefaultDatabase.CreateParameter("@State", SqlDbType.Char, 0, "State"),
      DefaultDatabase.CreateParameter("@InsuredCorporationType", SqlDbType.TinyInt, 0, "InsuredCorporationType"),
      DefaultDatabase.CreateParameter("@Symbol", SqlDbType.VarChar, 0, "Symbol"),
      DefaultDatabase.CreateParameter("@SymbolType", SqlDbType.VarChar, 0, "SymbolType"),
      DefaultDatabase.CreateParameter("@Class", SqlDbType.Int, 0, "Class"),
      DefaultDatabase.CreateParameter("@Effective", SqlDbType.SmallDateTime, 0, "Effective"),
      DefaultDatabase.CreateParameter("@Disabled", SqlDbType.SmallDateTime, 0, "Disabled")
    });
    this.DbSelectCommand1.CommandText = "SELECT     ID, CompanyLocationGuid, LOB, State, InsuredCorporationType, Symbol, SymbolType, Class, Effective, Disabled\r\nFROM         dbo.tblAutoSymbol";
    this.DbSelectCommand1.Connection = this.cnDB;
    this.SqlUpdateCommand.CommandText = componentResourceManager.GetString("SqlUpdateCommand.CommandText");
    this.SqlUpdateCommand.Connection = this.cnDB;
    this.SqlUpdateCommand.Parameters.AddRange((Array) new DbParameter[11]
    {
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      DefaultDatabase.CreateParameter("@LOB", SqlDbType.UniqueIdentifier, 0, "LOB"),
      DefaultDatabase.CreateParameter("@State", SqlDbType.Char, 0, "State"),
      DefaultDatabase.CreateParameter("@InsuredCorporationType", SqlDbType.TinyInt, 0, "InsuredCorporationType"),
      DefaultDatabase.CreateParameter("@Symbol", SqlDbType.VarChar, 0, "Symbol"),
      DefaultDatabase.CreateParameter("@SymbolType", SqlDbType.VarChar, 0, "SymbolType"),
      DefaultDatabase.CreateParameter("@Class", SqlDbType.Int, 0, "Class"),
      DefaultDatabase.CreateParameter("@Effective", SqlDbType.SmallDateTime, 0, "Effective"),
      DefaultDatabase.CreateParameter("@Disabled", SqlDbType.SmallDateTime, 0, "Disabled"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.daLoadData.SelectCommand = this.DbCommand1;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "spBindPolicyData", new DataColumnMapping[4]
      {
        new DataColumnMapping("CompanyCommission", "CompanyCommission"),
        new DataColumnMapping("ProducerCommission", "ProducerCommission"),
        new DataColumnMapping("Company", "Company"),
        new DataColumnMapping("Producer", "Producer")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[6]
      {
        new DataColumnMapping("Entity", "Entity"),
        new DataColumnMapping("ChargeName", "ChargeName"),
        new DataColumnMapping("EntityType", "EntityType"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Percentage", "Percentage"),
        new DataColumnMapping("FlatAmount", "FlatAmount")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("OptionFeeID", "OptionFeeID")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[3]
      {
        new DataColumnMapping("ChargeName", "ChargeName"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("PayableEntity", "PayableEntity")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineName", "LineName"),
        new DataColumnMapping("Premium", "Premium")
      })
    });
    this.DbCommand1.CommandText = "[spGetSymbolAutoData]";
    this.DbCommand1.CommandType = CommandType.StoredProcedure;
    this.DbCommand1.Connection = this.cnDB;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.grbAuto).Anchor = AnchorStyles.Bottom;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.grbAuto).ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grbAuto).Controls.Add((Control) this.Label9);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label8);
    ((Control) this.grbAuto).Controls.Add((Control) this.dtDisabled);
    ((Control) this.grbAuto).Controls.Add((Control) this.dtEffective);
    ((Control) this.grbAuto).Controls.Add((Control) this.txtSymbol);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label6);
    ((Control) this.grbAuto).Controls.Add((Control) this.cboSymbolType);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label1);
    ((Control) this.grbAuto).Controls.Add((Control) this.cboCompanyLocation);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label2);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label3);
    ((Control) this.grbAuto).Controls.Add((Control) this.cboState);
    ((Control) this.grbAuto).Controls.Add((Control) this.cboClass);
    ((Control) this.grbAuto).Controls.Add((Control) this.cboLOB);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label5);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label7);
    ((Control) this.grbAuto).Controls.Add((Control) this.Label4);
    ((Control) this.grbAuto).Controls.Add((Control) this.cboInsuredType);
    ((Control) this.grbAuto).Location = new Point(5, 220);
    ((Control) this.grbAuto).Name = "grbAuto";
    ((Control) this.grbAuto).Size = new Size(785, 179);
    ((Control) this.grbAuto).TabIndex = 220;
    ((UltraGroupBox) this.grbAuto).Text = "Symbol Automation Information";
    ((UltraGroupBox) this.grbAuto).ViewStyle = (GroupBoxViewStyle) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(407, 115);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(51, 13);
    this.Label9.TabIndex = 17;
    this.Label9.Text = "Disabled:";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(407, 88);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(54, 13);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "Effective:";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtDisabled).Appearance = (AppearanceBase) appearance2;
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
    ((UltraDateTimeEditor) this.dtDisabled).ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.dtDisabled).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.Disabled", true));
    ((UltraDateTimeEditor) this.dtDisabled).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtDisabled).Location = new Point(495, 111);
    this.dtDisabled.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtDisabled).Name = "dtDisabled";
    ((Control) this.dtDisabled).Size = new Size(85, 20);
    ((Control) this.dtDisabled).TabIndex = 15;
    ((UltraControlBase) this.dtDisabled).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDisabled).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtDisabled).Value = (object) null;
    this.ds.DataSetName = "dsSymbolAutomation";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEffective).Appearance = (AppearanceBase) appearance4;
    appearance5.AlphaLevel = (short) 14;
    appearance5.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance5.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance5.BackColorAlpha = (Alpha) 2;
    appearance5.BackGradientAlignment = (GradientAlignment) 4;
    appearance5.BackGradientStyle = (GradientStyle) 5;
    appearance5.BorderAlpha = (Alpha) 1;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    appearance5.ForeColor = Color.FromArgb(49, 85, 153);
    appearance5.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEffective).ButtonAppearance = (AppearanceBase) appearance5;
    ((Control) this.dtEffective).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.Effective", true));
    ((UltraDateTimeEditor) this.dtEffective).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtEffective).Location = new Point(495, 84);
    this.dtEffective.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(85, 20);
    ((Control) this.dtEffective).TabIndex = 14;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtEffective).Value = (object) null;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSymbol).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtSymbol).BackColor = Color.White;
    ((Control) this.txtSymbol).DataBindings.Add(new Binding("Text", (object) this.ds, "tblAutoSymbol.Symbol", true));
    ((Control) this.txtSymbol).Location = new Point(121, 31 /*0x1F*/);
    ((TextEditorControlBase) this.txtSymbol).MaxLength = 50;
    this.txtSymbol.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSymbol).Name = "txtSymbol";
    ((Control) this.txtSymbol).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.txtSymbol).TabIndex = 0;
    ((UltraControlBase) this.txtSymbol).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSymbol).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboSymbolType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboSymbolType).CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboSymbolType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.SymbolType", true));
    ((UltraGridBase) this.cboSymbolType).DataMember = "lstAutoSymbolType";
    ((UltraGridBase) this.cboSymbolType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboSymbolType).DisplayMember = "TypeName";
    ((UltraCombo) this.cboSymbolType).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboSymbolType).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSymbolType).DropDownWidth = 150;
    ((Control) this.cboSymbolType).Location = new Point(121, 57);
    this.cboSymbolType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboSymbolType).Name = "cboSymbolType";
    ((Control) this.cboSymbolType).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cboSymbolType).TabIndex = 1;
    ((UltraControlBase) this.cboSymbolType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSymbolType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSymbolType).ValueMember = "ID";
    ((UltraCombo) this.cboCompanyLocation).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboCompanyLocation).CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboCompanyLocation).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.CompanyLocationGuid", true));
    ((UltraGridBase) this.cboCompanyLocation).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cboCompanyLocation).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCompanyLocation).DisplayMember = "LocationName";
    ((UltraCombo) this.cboCompanyLocation).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboCompanyLocation).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocation).DropDownWidth = 150;
    ((Control) this.cboCompanyLocation).Location = new Point(122, 84);
    this.cboCompanyLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCompanyLocation).Name = "cboCompanyLocation";
    ((Control) this.cboCompanyLocation).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cboCompanyLocation).TabIndex = 2;
    ((UltraControlBase) this.cboCompanyLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLocation).ValueMember = "CompanyLocationGUID";
    ((UltraCombo) this.cboState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboState).CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.State", true));
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    ((UltraCombo) this.cboState).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 150;
    ((Control) this.cboState).Location = new Point(122, 138);
    this.cboState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cboState).TabIndex = 4;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    ((UltraCombo) this.cboClass).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboClass).CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboClass).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.Class", true));
    ((UltraGridBase) this.cboClass).DataMember = "lstAutoSymbolClass";
    ((UltraGridBase) this.cboClass).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboClass).DisplayMember = "ClassName";
    ((UltraCombo) this.cboClass).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboClass).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboClass).DropDownWidth = 150;
    ((Control) this.cboClass).Location = new Point(495, 57);
    this.cboClass.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboClass).Name = "cboClass";
    ((Control) this.cboClass).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cboClass).TabIndex = 6;
    ((UltraControlBase) this.cboClass).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboClass).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboClass).ValueMember = "ID";
    ((UltraCombo) this.cboLOB).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboLOB).CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboLOB).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.LOB", true));
    ((UltraGridBase) this.cboLOB).DataMember = "lstLines";
    ((UltraGridBase) this.cboLOB).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLOB).DisplayMember = "LineName";
    ((UltraCombo) this.cboLOB).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboLOB).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLOB).DropDownWidth = 150;
    ((Control) this.cboLOB).Location = new Point(121, 111);
    this.cboLOB.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLOB).Name = "cboLOB";
    ((Control) this.cboLOB).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cboLOB).TabIndex = 3;
    ((UltraControlBase) this.cboLOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLOB).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLOB).ValueMember = "LineGUID";
    ((UltraCombo) this.cboInsuredType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboInsuredType).CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboInsuredType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblAutoSymbol.InsuredCorporationType", true));
    ((UltraGridBase) this.cboInsuredType).DataMember = "lstBusinessTypes";
    ((UltraGridBase) this.cboInsuredType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboInsuredType).DisplayMember = "BusinessType";
    ((UltraCombo) this.cboInsuredType).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboInsuredType).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInsuredType).DropDownWidth = 150;
    ((Control) this.cboInsuredType).Location = new Point(495, 31 /*0x1F*/);
    this.cboInsuredType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInsuredType).Name = "cboInsuredType";
    ((Control) this.cboInsuredType).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cboInsuredType).TabIndex = 5;
    ((UltraControlBase) this.cboInsuredType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInsuredType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInsuredType).ValueMember = "BusinessTypeID";
    ((Control) this.ddClass).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddClass).DataMember = "lstAutoSymbolClass";
    ((UltraGridBase) this.ddClass).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddClass).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddClass).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddClass).DisplayMember = "ClassName";
    ((UltraDropDownBase) this.ddClass).DropDownWidth = 400;
    ((Control) this.ddClass).Location = new Point(642, -96);
    ((Control) this.ddClass).Name = "ddClass";
    ((Control) this.ddClass).Size = new Size(140, 53);
    ((Control) this.ddClass).TabIndex = 219;
    ((Control) this.ddClass).Text = "ddLines";
    ((UltraDropDownBase) this.ddClass).ValueMember = "ID";
    ((Control) this.ddClass).Visible = false;
    ((Control) this.ddInsuredType).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddInsuredType).DataMember = "lstBusinessTypes";
    ((UltraGridBase) this.ddInsuredType).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddInsuredType).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddInsuredType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddInsuredType).DisplayMember = "BusinessType";
    ((UltraDropDownBase) this.ddInsuredType).DropDownWidth = 400;
    ((Control) this.ddInsuredType).Location = new Point(478, -96);
    ((Control) this.ddInsuredType).Name = "ddInsuredType";
    ((Control) this.ddInsuredType).Size = new Size(140, 53);
    ((Control) this.ddInsuredType).TabIndex = 218;
    ((Control) this.ddInsuredType).Text = "ddLines";
    ((UltraDropDownBase) this.ddInsuredType).ValueMember = "BusinessTypeID";
    ((Control) this.ddInsuredType).Visible = false;
    ((Control) this.ddSymbolType).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddSymbolType).DataMember = "lstAutoSymbolType";
    ((UltraGridBase) this.ddSymbolType).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddSymbolType).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddSymbolType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddSymbolType).DisplayMember = "TypeName";
    ((UltraDropDownBase) this.ddSymbolType).DropDownWidth = 400;
    ((Control) this.ddSymbolType).Location = new Point(311, -96);
    ((Control) this.ddSymbolType).Name = "ddSymbolType";
    ((Control) this.ddSymbolType).Size = new Size(140, 53);
    ((Control) this.ddSymbolType).TabIndex = 217;
    ((Control) this.ddSymbolType).Text = "ddLines";
    ((UltraDropDownBase) this.ddSymbolType).ValueMember = "ID";
    ((Control) this.ddSymbolType).Visible = false;
    ((Control) this.ddCompany).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddCompany).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddCompany).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddCompany).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddCompany).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddCompany).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.ddCompany).DropDownWidth = 400;
    ((Control) this.ddCompany).Location = new Point(165, -96);
    ((Control) this.ddCompany).Name = "ddCompany";
    ((Control) this.ddCompany).Size = new Size(140, 53);
    ((Control) this.ddCompany).TabIndex = 216;
    ((Control) this.ddCompany).Text = "ddLines";
    ((UltraDropDownBase) this.ddCompany).ValueMember = "CompanyLocationGUID";
    ((Control) this.ddCompany).Visible = false;
    ((Control) this.ddLine).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddLine).DataMember = "lstLines";
    ((UltraGridBase) this.ddLine).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddLine).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.ddLine).DropDownWidth = 400;
    ((Control) this.ddLine).Location = new Point(-2, -96);
    ((Control) this.ddLine).Name = "ddLine";
    ((Control) this.ddLine).Size = new Size(140, 53);
    ((Control) this.ddLine).TabIndex = 215;
    ((Control) this.ddLine).Text = "ddLines";
    ((UltraDropDownBase) this.ddLine).ValueMember = "LineGUID";
    ((Control) this.ddLine).Visible = false;
    ((Control) this.gridSymbolAutomation).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridSymbolAutomation).DataMember = "tblAutoSymbol";
    ((UltraGridBase) this.gridSymbolAutomation).DataSource = (object) this.ds;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.SlateGray;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 46;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Company Location";
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 168;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Line Of Business";
    ultraGridColumn13.Header.VisiblePosition = 4;
    ultraGridColumn13.Style = (ColumnStyle) 6;
    ultraGridColumn13.Width = 110;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ultraGridColumn14.Width = 47;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Insured Type";
    ultraGridColumn15.Header.VisiblePosition = 6;
    ultraGridColumn15.Style = (ColumnStyle) 6;
    ultraGridColumn15.Width = 92;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Width = 73;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Symbol Type";
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn17.Style = (ColumnStyle) 6;
    ultraGridColumn17.Width = 91;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ultraGridColumn18.Header.VisiblePosition = 7;
    ultraGridColumn18.Style = (ColumnStyle) 6;
    ultraGridColumn18.Width = 54;
    ultraGridColumn19.Header.VisiblePosition = 8;
    ultraGridColumn19.Width = 74;
    ultraGridColumn20.Header.VisiblePosition = 9;
    ultraGridColumn20.Width = 74;
    ultraGridBand6.Columns.AddRange(new object[10]
    {
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
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.SizeInPoints = 10f;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.RowSpacingAfter = 1;
    appearance14.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.SelectTypeRow = (SelectType) 2;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.SummaryDisplayArea = (SummaryDisplayAreas) 0;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.SummaryFooterCaptionAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridSymbolAutomation).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridSymbolAutomation).Location = new Point(5, 7);
    ((Control) this.gridSymbolAutomation).Name = "gridSymbolAutomation";
    ((Control) this.gridSymbolAutomation).Size = new Size(785, 207);
    ((Control) this.gridSymbolAutomation).TabIndex = 2;
    ((UltraControlBase) this.gridSymbolAutomation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSymbolAutomation).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(796, 475);
    this.Controls.Add((Control) this.grbAuto);
    this.Controls.Add((Control) this.ddClass);
    this.Controls.Add((Control) this.ddInsuredType);
    this.Controls.Add((Control) this.ddSymbolType);
    this.Controls.Add((Control) this.ddCompany);
    this.Controls.Add((Control) this.ddLine);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.gridSymbolAutomation);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormSymbolAutomation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Symbol Automation";
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.grbAuto).EndInit();
    ((Control) this.grbAuto).ResumeLayout(false);
    ((Control) this.grbAuto).PerformLayout();
    ((ISupportInitialize) this.dtDisabled).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.txtSymbol).EndInit();
    ((ISupportInitialize) this.cboSymbolType).EndInit();
    ((ISupportInitialize) this.cboCompanyLocation).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboClass).EndInit();
    ((ISupportInitialize) this.cboLOB).EndInit();
    ((ISupportInitialize) this.cboInsuredType).EndInit();
    ((ISupportInitialize) this.ddClass).EndInit();
    ((ISupportInitialize) this.ddInsuredType).EndInit();
    ((ISupportInitialize) this.ddSymbolType).EndInit();
    ((ISupportInitialize) this.ddCompany).EndInit();
    ((ISupportInitialize) this.ddLine).EndInit();
    ((ISupportInitialize) this.gridSymbolAutomation).EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraGrid gridSymbolAutomation
  {
    get => this._gridSymbolAutomation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridSymbolAutomation_AfterRowActivate);
      UltraGrid symbolAutomation1 = this._gridSymbolAutomation;
      if (symbolAutomation1 != null)
        symbolAutomation1.AfterRowActivate -= eventHandler;
      this._gridSymbolAutomation = value;
      UltraGrid symbolAutomation2 = this._gridSymbolAutomation;
      if (symbolAutomation2 == null)
        return;
      symbolAutomation2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboSymbolType")]
  private virtual MGASimpleComboBox cboSymbolType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompanyLocation")]
  private virtual MGASimpleComboBox cboCompanyLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLOB")]
  private virtual MGASimpleComboBox cboLOB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInsuredType")]
  private virtual MGASimpleComboBox cboInsuredType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboClass")]
  private virtual MGASimpleComboBox cboClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedDelete);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickedDelete -= eventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingEdit -= cancelEventHandler3;
        dbSave1.ClickingNew -= cancelEventHandler4;
        dbSave1.ClickingSave -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickedDelete += eventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingEdit += cancelEventHandler3;
      dbSave2.ClickingNew += cancelEventHandler4;
      dbSave2.ClickingSave += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("cnDB")]
  private virtual DbConnection cnDB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetSymbol")]
  private virtual DbDataAdapter daGetSymbol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  private virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daLoadData")]
  private virtual DbDataAdapter daLoadData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand1")]
  private virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLine")]
  private virtual UltraDropDown ddLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCompany")]
  private virtual UltraDropDown ddCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddSymbolType")]
  private virtual UltraDropDown ddSymbolType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddInsuredType")]
  private virtual UltraDropDown ddInsuredType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddClass")]
  private virtual UltraDropDown ddClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grbAuto")]
  private virtual MGAGroupBox grbAuto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSymbol")]
  private virtual MGATextBox txtSymbol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDisabled")]
  private virtual MGADateTimePicker dtDisabled { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffective")]
  private virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblAutoSymbol.TableName];
  }

  private void FormSymbolAutomation_Load(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((Control) this.dbSave).Enabled = false;
    this.EnableControls(false);
    dsSymbolAutomation.lstStatesRow row1 = this.ds.lstStates.NewlstStatesRow();
    row1.StateID = string.Empty;
    row1.State = string.Empty;
    this.ds.lstStates.AddlstStatesRow(row1);
    dsSymbolAutomation.tblCompanyLocationsRow row2 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row2.CompanyLocationGUID = Guid.Empty;
    row2.LocationName = string.Empty;
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row2);
    dsSymbolAutomation.lstLinesRow row3 = this.ds.lstLines.NewlstLinesRow();
    row3.LineGUID = Guid.Empty;
    row3.LineName = string.Empty;
    this.ds.lstLines.AddlstLinesRow(row3);
    DbDataAdapter daLoadData = this.daLoadData;
    daLoadData.TableMappings.Clear();
    daLoadData.TableMappings.Add("Table", this.ds.lstBusinessTypes.TableName);
    daLoadData.TableMappings.Add("Table1", this.ds.lstAutoSymbolClass.TableName);
    daLoadData.TableMappings.Add("Table2", this.ds.lstAutoSymbolType.TableName);
    daLoadData.TableMappings.Add("Table3", this.ds.lstStates.TableName);
    daLoadData.TableMappings.Add("Table4", this.ds.tblCompanyLocations.TableName);
    daLoadData.TableMappings.Add("Table5", this.ds.lstLines.TableName);
    DefaultDatabase.DataAdapterFill(this.daLoadData, (DataSet) this.ds);
    ((UltraGridBase) this.gridSymbolAutomation).DisplayLayout.Save((Stream) this._gridlayout);
    ((UltraGridBase) this.gridSymbolAutomation).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillThread));
  }

  private void FillThread(object state)
  {
    object syncLock = FormSymbolAutomation._syncLock;
    ObjectFlowControl.CheckForSyncLockOnValueType(syncLock);
    bool lockTaken = false;
    try
    {
      Monitor.Enter(syncLock, ref lockTaken);
      DefaultDatabase.DataAdapterFill(this.daGetSymbol, (DataTable) this.ds.tblAutoSymbol);
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(syncLock);
    }
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.FillThreadComplete), new object[0]);
  }

  private void FillThreadComplete()
  {
    this._gridlayout.Position = 0L;
    UltraGrid symbolAutomation = this.gridSymbolAutomation;
    ((UltraGridBase) symbolAutomation).DataSource = (object) this.ds;
    ((UltraGridBase) symbolAutomation).DataMember = "tblAutoSymbol";
    ((UltraGridBase) symbolAutomation).DisplayLayout.Load((Stream) this._gridlayout);
    ((UltraGridBase) symbolAutomation).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.Cursor = MgaCursors.Default;
    ((Control) this.dbSave).Enabled = true;
  }

  private void gridSymbolAutomation_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridSymbolAutomation).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.gridSymbolAutomation).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.tblAutoSymbol, this.bmb);
    if (this.dbSave.UIState == 2)
      return;
    this.dbSave.UIState = (UIState) 1;
  }

  private void SetDBState()
  {
    if (this.ds.tblAutoSymbol.Count > 0)
      this.dbSave.UIState = (UIState) 1;
    else
      this.dbSave.UIState = (UIState) 0;
  }

  private void EnableControls(bool enable) => ((Control) this.grbAuto).Enabled = enable;

  private bool ValidForm()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtSymbol).Text))
    {
      this.err.SetError((Control) this.txtSymbol, "Please enter a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtSymbol, string.Empty);
    if (string.IsNullOrEmpty(((UltraCombo) this.cboSymbolType).Text))
    {
      this.err.SetError((Control) this.cboSymbolType, "Please select a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboSymbolType, string.Empty);
    return flag;
  }

  private void SaveData()
  {
    DefaultDatabase.DataAdapterUpdate(this.daGetSymbol, (DataTable) this.ds.tblAutoSymbol);
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.SetDBState();
    this.EnableControls(false);
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e)
  {
    if (this.ds.tblAutoSymbol.Count != 0)
      return;
    this.SetDBState();
    this.EnableControls(false);
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblAutoSymbol.RejectChanges();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this symbol automation?", "Delete Symbol Automation?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.ds.tblAutoSymbol[this.bmb.Position].Delete();
      this.SaveData();
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.EnableControls(true);

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.EnableControls(true);
    this.ds.tblAutoSymbol.AddtblAutoSymbolRow(this.ds.tblAutoSymbol.NewtblAutoSymbolRow());
    this.bmb.Position = this.ds.tblAutoSymbol.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      this.bmb.EndCurrentEdit();
      this.SaveData();
      this.EnableControls(false);
    }
  }
}
