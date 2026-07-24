// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formSearchTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Accounting.SharedForms;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formSearchTransaction : AccountingNoteDocumentSupport
{
  private Label label1;
  private Label label2;
  private EllipsePanel ellipsePanel1;
  private MGASimpleComboBox comboTransactionType;
  private MGASimpleComboBox comboOfficeLocation;
  private RadioButton radioItemSearch;
  private RadioButton radioDateSearch;
  private RadioButton radioEntitySearch;
  private Label label3;
  private Label label4;
  private MGASimpleComboBox comboSearchBy;
  private MGATextBox textSearchFor;
  private Label label5;
  private MGASimpleComboBox comboDateType;
  private Label label6;
  private MGATextBox textEntityName;
  private Label label7;
  private MGAButton buttonSearchEntity;
  private MGACheckBox checkEntitySearchUseDates;
  private RadioButton radioUserSearch;
  private MGACheckBox checkUserSearchUseDates;
  private MGAButton buttonSearchUser;
  private MGATextBox textUserName;
  private Label label8;
  private MGADateTimePicker dateUserSearchFrom;
  private MGADateTimePicker dateUserSearchTo;
  private Label label9;
  private Label label10;
  private MGADateTimePicker dateEntitySearchTo;
  private Label label11;
  private Label label12;
  private MGADateTimePicker dateEntitySearchFrom;
  private MGADateTimePicker dateTo;
  private Label label13;
  private MGADateTimePicker dateFrom;
  private dsOfficeLocations dsOfficeLocations1;
  private SqlDataAdapter daGetOfficeLocations;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection formDataConnection;
  protected dsSeachTransaction dsSeachTransaction1;
  private EllipsePanel panelUserSearch;
  private EllipsePanel panelEntitySearch;
  private EllipsePanel panelDateSearch;
  private EllipsePanel panelItemSearch;
  private MGAButton buttonExecuteSearch;
  private SqlDataAdapter daSearchTransaction;
  private SqlCommand sqlSelectCommand2;
  protected RadioButton radioAmountSearch;
  private EllipsePanel panelAmountSearchOptions;
  private MGATextBox txtAmountSearch;
  private MGASimpleComboBox comboAmountSearchFor;
  private Label label14;
  private Label label15;
  private MGASimpleComboBox comboAmountSearchType;
  private Label label18;
  private MGADateTimePicker dateAmountSearchTo;
  private Label label17;
  private MGADateTimePicker dateAmountSearchFrom;
  private Label label16;
  protected StatusStrip statusStrip;
  protected ToolStripStatusLabel labelStatusStrip;
  protected ToolStripStatusLabel toolStripStatusLabel1;
  private MGADateTimePicker dateItemSearchTo;
  private Label label20;
  private Label label19;
  private MGADateTimePicker dateItemSearchFrom;
  protected MGANumericEditor mgaNumericEditor1;
  private Label label22;
  protected UltraGrid gridResults;
  private MGACheckBox checkItemSearchUseDates;
  private System.ComponentModel.Container components;

  public formSearchTransaction()
  {
    this.InitializeComponent();
    this.SetFromDefaultDate(this.dateItemSearchFrom);
    this.SetToDefaultDate(this.dateItemSearchTo);
    this.SetFromDefaultDate(this.dateAmountSearchFrom);
    this.SetToDefaultDate(this.dateAmountSearchTo);
    this.SetFromDefaultDate(this.dateUserSearchFrom);
    this.SetToDefaultDate(this.dateUserSearchTo);
    this.SetFromDefaultDate(this.dateEntitySearchFrom);
    this.SetToDefaultDate(this.dateEntitySearchTo);
    this.SetFromDefaultDate(this.dateFrom);
    this.SetToDefaultDate(this.dateTo);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formSearchTransaction));
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
    UltraGridBand ultraGridBand = new UltraGridBand("Transactions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("transactNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("postDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("User");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CheckNumber", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TransactionType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Amount");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.formDataConnection = new SqlConnection();
    this.daSearchTransaction = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.buttonExecuteSearch = new MGAButton();
    this.ellipsePanel1 = new EllipsePanel();
    this.mgaNumericEditor1 = new MGANumericEditor();
    this.label22 = new Label();
    this.radioAmountSearch = new RadioButton();
    this.panelAmountSearchOptions = new EllipsePanel();
    this.comboAmountSearchType = new MGASimpleComboBox();
    this.label18 = new Label();
    this.dateAmountSearchTo = new MGADateTimePicker();
    this.label17 = new Label();
    this.dateAmountSearchFrom = new MGADateTimePicker();
    this.label16 = new Label();
    this.txtAmountSearch = new MGATextBox();
    this.comboAmountSearchFor = new MGASimpleComboBox();
    this.label14 = new Label();
    this.label15 = new Label();
    this.radioUserSearch = new RadioButton();
    this.panelUserSearch = new EllipsePanel();
    this.dateUserSearchTo = new MGADateTimePicker();
    this.label10 = new Label();
    this.label9 = new Label();
    this.dateUserSearchFrom = new MGADateTimePicker();
    this.checkUserSearchUseDates = new MGACheckBox();
    this.buttonSearchUser = new MGAButton();
    this.textUserName = new MGATextBox();
    this.label8 = new Label();
    this.radioEntitySearch = new RadioButton();
    this.panelEntitySearch = new EllipsePanel();
    this.dateEntitySearchTo = new MGADateTimePicker();
    this.label11 = new Label();
    this.label12 = new Label();
    this.dateEntitySearchFrom = new MGADateTimePicker();
    this.checkEntitySearchUseDates = new MGACheckBox();
    this.buttonSearchEntity = new MGAButton();
    this.textEntityName = new MGATextBox();
    this.label7 = new Label();
    this.radioDateSearch = new RadioButton();
    this.panelDateSearch = new EllipsePanel();
    this.dateFrom = new MGADateTimePicker();
    this.dateTo = new MGADateTimePicker();
    this.label13 = new Label();
    this.label6 = new Label();
    this.comboDateType = new MGASimpleComboBox();
    this.label5 = new Label();
    this.radioItemSearch = new RadioButton();
    this.panelItemSearch = new EllipsePanel();
    this.checkItemSearchUseDates = new MGACheckBox();
    this.dateItemSearchTo = new MGADateTimePicker();
    this.label20 = new Label();
    this.label19 = new Label();
    this.dateItemSearchFrom = new MGADateTimePicker();
    this.textSearchFor = new MGATextBox();
    this.comboSearchBy = new MGASimpleComboBox();
    this.label4 = new Label();
    this.label3 = new Label();
    this.comboTransactionType = new MGASimpleComboBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.dsSeachTransaction1 = new dsSeachTransaction();
    this.statusStrip = new StatusStrip();
    this.labelStatusStrip = new ToolStripStatusLabel();
    this.toolStripStatusLabel1 = new ToolStripStatusLabel();
    this.gridResults = new UltraGrid();
    ((ISupportInitialize) this.buttonExecuteSearch).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.mgaNumericEditor1).BeginInit();
    this.panelAmountSearchOptions.SuspendLayout();
    ((ISupportInitialize) this.comboAmountSearchType).BeginInit();
    ((ISupportInitialize) this.dateAmountSearchTo).BeginInit();
    ((ISupportInitialize) this.dateAmountSearchFrom).BeginInit();
    ((ISupportInitialize) this.txtAmountSearch).BeginInit();
    ((ISupportInitialize) this.comboAmountSearchFor).BeginInit();
    this.panelUserSearch.SuspendLayout();
    ((ISupportInitialize) this.dateUserSearchTo).BeginInit();
    ((ISupportInitialize) this.dateUserSearchFrom).BeginInit();
    ((ISupportInitialize) this.checkUserSearchUseDates).BeginInit();
    ((ISupportInitialize) this.buttonSearchUser).BeginInit();
    ((ISupportInitialize) this.textUserName).BeginInit();
    this.panelEntitySearch.SuspendLayout();
    ((ISupportInitialize) this.dateEntitySearchTo).BeginInit();
    ((ISupportInitialize) this.dateEntitySearchFrom).BeginInit();
    ((ISupportInitialize) this.checkEntitySearchUseDates).BeginInit();
    ((ISupportInitialize) this.buttonSearchEntity).BeginInit();
    ((ISupportInitialize) this.textEntityName).BeginInit();
    this.panelDateSearch.SuspendLayout();
    ((ISupportInitialize) this.dateFrom).BeginInit();
    ((ISupportInitialize) this.dateTo).BeginInit();
    ((ISupportInitialize) this.comboDateType).BeginInit();
    this.panelItemSearch.SuspendLayout();
    ((ISupportInitialize) this.checkItemSearchUseDates).BeginInit();
    ((ISupportInitialize) this.dateItemSearchTo).BeginInit();
    ((ISupportInitialize) this.dateItemSearchFrom).BeginInit();
    ((ISupportInitialize) this.textSearchFor).BeginInit();
    ((ISupportInitialize) this.comboSearchBy).BeginInit();
    ((ISupportInitialize) this.comboTransactionType).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    this.dsSeachTransaction1.BeginInit();
    this.statusStrip.SuspendLayout();
    ((ISupportInitialize) this.gridResults).BeginInit();
    this.SuspendLayout();
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.formDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@userguid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.formDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.formDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daSearchTransaction.MissingSchemaAction = MissingSchemaAction.Ignore;
    this.daSearchTransaction.SelectCommand = this.sqlSelectCommand2;
    this.daSearchTransaction.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_SearchTransaction", new DataColumnMapping[6]
      {
        new DataColumnMapping("Transaction Number", "Transaction Number"),
        new DataColumnMapping("Post Date", "Post Date"),
        new DataColumnMapping("User", "User"),
        new DataColumnMapping("Check Number", "Check Number"),
        new DataColumnMapping("Transaction Type", "Transaction Type"),
        new DataColumnMapping("Comments", "Comments")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_SearchTransaction]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.formDataConnection;
    this.sqlSelectCommand2.Parameters.AddRange(new SqlParameter[14]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4),
      new SqlParameter("@transactiontype", SqlDbType.VarChar, 1),
      new SqlParameter("@transactionNumber", SqlDbType.Int, 4),
      new SqlParameter("@checkNumber", SqlDbType.VarChar, 50),
      new SqlParameter("@invoiceNumber", SqlDbType.Int, 4),
      new SqlParameter("@entityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@dateType", SqlDbType.VarChar, 1),
      new SqlParameter("@dateFrom", SqlDbType.DateTime, 8),
      new SqlParameter("@dateTo", SqlDbType.DateTime, 8),
      new SqlParameter("@userGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@amountSearchType", SqlDbType.VarChar, 1),
      new SqlParameter("@amountSearchFor", SqlDbType.VarChar, 1),
      new SqlParameter("@amount", SqlDbType.Money)
    });
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance1.Image");
    ((ControlBase) this.buttonExecuteSearch).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonExecuteSearch).Location = new Point(210, 63 /*0x3F*/);
    ((Control) this.buttonExecuteSearch).Name = "buttonExecuteSearch";
    ((Control) this.buttonExecuteSearch).Size = new Size(78, 18);
    ((Control) this.buttonExecuteSearch).TabIndex = 12;
    ((Control) this.buttonExecuteSearch).Text = "Search";
    ((UltraControlBase) this.buttonExecuteSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonExecuteSearch).Click += new EventHandler(this.buttonExecuteSearch_Click);
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.mgaNumericEditor1);
    this.ellipsePanel1.Controls.Add((Control) this.label22);
    this.ellipsePanel1.Controls.Add((Control) this.radioAmountSearch);
    this.ellipsePanel1.Controls.Add((Control) this.panelAmountSearchOptions);
    this.ellipsePanel1.Controls.Add((Control) this.radioUserSearch);
    this.ellipsePanel1.Controls.Add((Control) this.buttonExecuteSearch);
    this.ellipsePanel1.Controls.Add((Control) this.panelUserSearch);
    this.ellipsePanel1.Controls.Add((Control) this.radioEntitySearch);
    this.ellipsePanel1.Controls.Add((Control) this.panelEntitySearch);
    this.ellipsePanel1.Controls.Add((Control) this.radioDateSearch);
    this.ellipsePanel1.Controls.Add((Control) this.panelDateSearch);
    this.ellipsePanel1.Controls.Add((Control) this.radioItemSearch);
    this.ellipsePanel1.Controls.Add((Control) this.panelItemSearch);
    this.ellipsePanel1.Controls.Add((Control) this.comboTransactionType);
    this.ellipsePanel1.Controls.Add((Control) this.label2);
    this.ellipsePanel1.Controls.Add((Control) this.label1);
    this.ellipsePanel1.Controls.Add((Control) this.comboOfficeLocation);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Dock = DockStyle.Left;
    this.ellipsePanel1.Location = new Point(0, 0);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(296, 729);
    this.ellipsePanel1.TabIndex = 0;
    this.ellipsePanel1.Paint += new PaintEventHandler(this.EllipsePanel1_Paint);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.mgaNumericEditor1).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    ((UltraNumericEditorBase) this.mgaNumericEditor1).ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.mgaNumericEditor1).Location = new Point(104, 61);
    this.mgaNumericEditor1.MaxValue = (object) 500;
    this.mgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    this.mgaNumericEditor1.MinValue = (object) 1;
    ((Control) this.mgaNumericEditor1).Name = "mgaNumericEditor1";
    ((UltraNumericEditorBase) this.mgaNumericEditor1).PromptChar = ' ';
    ((Control) this.mgaNumericEditor1).Size = new Size(72, 20);
    ((UltraNumericEditorBase) this.mgaNumericEditor1).SpinButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ((Control) this.mgaNumericEditor1).TabIndex = 17;
    ((UltraControlBase) this.mgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.mgaNumericEditor1.Value = (object) 100;
    ((UltraNumericEditorBase) this.mgaNumericEditor1).ValueChanged += new EventHandler(this.MgaNumericEditor1_ValueChanged);
    this.label22.AutoSize = true;
    this.label22.BackColor = Color.Transparent;
    this.label22.Location = new Point(8, 61);
    this.label22.Name = "label22";
    this.label22.Size = new Size(46, 13);
    this.label22.TabIndex = 18;
    this.label22.Text = "Results:";
    this.label22.TextAlign = ContentAlignment.MiddleRight;
    this.label22.Click += new EventHandler(this.Label22_Click);
    this.radioAmountSearch.Checked = true;
    this.radioAmountSearch.FlatStyle = FlatStyle.Flat;
    this.radioAmountSearch.Location = new Point(11, 564);
    this.radioAmountSearch.Name = "radioAmountSearch";
    this.radioAmountSearch.Size = new Size(160 /*0xA0*/, 22);
    this.radioAmountSearch.TabIndex = 13;
    this.radioAmountSearch.TabStop = true;
    this.radioAmountSearch.Text = "Amount Search Options";
    this.panelAmountSearchOptions.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelAmountSearchOptions.Controls.Add((Control) this.comboAmountSearchType);
    this.panelAmountSearchOptions.Controls.Add((Control) this.label18);
    this.panelAmountSearchOptions.Controls.Add((Control) this.dateAmountSearchTo);
    this.panelAmountSearchOptions.Controls.Add((Control) this.label17);
    this.panelAmountSearchOptions.Controls.Add((Control) this.dateAmountSearchFrom);
    this.panelAmountSearchOptions.Controls.Add((Control) this.label16);
    this.panelAmountSearchOptions.Controls.Add((Control) this.txtAmountSearch);
    this.panelAmountSearchOptions.Controls.Add((Control) this.comboAmountSearchFor);
    this.panelAmountSearchOptions.Controls.Add((Control) this.label14);
    this.panelAmountSearchOptions.Controls.Add((Control) this.label15);
    this.panelAmountSearchOptions.CornerOffset = 1;
    this.panelAmountSearchOptions.Location = new Point(11, 589);
    this.panelAmountSearchOptions.Name = "panelAmountSearchOptions";
    this.panelAmountSearchOptions.Size = new Size(280, 138);
    this.panelAmountSearchOptions.TabIndex = 14;
    this.comboAmountSearchType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboAmountSearchType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAmountSearchType).Location = new Point(85, 10);
    this.comboAmountSearchType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboAmountSearchType).Name = "comboAmountSearchType";
    ((Control) this.comboAmountSearchType).Size = new Size(187, 21);
    ((Control) this.comboAmountSearchType).TabIndex = 10;
    ((UltraControlBase) this.comboAmountSearchType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAmountSearchType).UseOsThemes = (DefaultableBoolean) 2;
    this.label18.AutoSize = true;
    this.label18.Location = new Point(8, 14);
    this.label18.Name = "label18";
    this.label18.Size = new Size(71, 13);
    this.label18.TabIndex = 9;
    this.label18.Text = "Search Type:";
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateAmountSearchTo.Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance5).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance5).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance5).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance5).ForegroundAlpha = (Alpha) 2;
    this.dateAmountSearchTo.ButtonAppearance = (AppearanceBase) appearance5;
    this.dateAmountSearchTo.DateTime = new DateTime(2019, 5, 29, 11, 6, 45, 0);
    ((Control) this.dateAmountSearchTo).Location = new Point(184, 100);
    this.dateAmountSearchTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateAmountSearchTo).Name = "dateAmountSearchTo";
    ((Control) this.dateAmountSearchTo).Size = new Size(88, 20);
    ((Control) this.dateAmountSearchTo).TabIndex = 8;
    ((UltraControlBase) this.dateAmountSearchTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateAmountSearchTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateAmountSearchTo.Value = (object) new DateTime(2019, 5, 29, 11, 6, 45, 0);
    this.label17.AutoSize = true;
    this.label17.Location = new Point(158, 103);
    this.label17.Name = "label17";
    this.label17.Size = new Size(23, 13);
    this.label17.TabIndex = 7;
    this.label17.Text = "To:";
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateAmountSearchFrom.Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance7).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance7).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance7).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance7).ForegroundAlpha = (Alpha) 2;
    this.dateAmountSearchFrom.ButtonAppearance = (AppearanceBase) appearance7;
    this.dateAmountSearchFrom.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateAmountSearchFrom).Location = new Point(64 /*0x40*/, 100);
    this.dateAmountSearchFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateAmountSearchFrom).Name = "dateAmountSearchFrom";
    ((Control) this.dateAmountSearchFrom).Size = new Size(88, 20);
    ((Control) this.dateAmountSearchFrom).TabIndex = 6;
    ((UltraControlBase) this.dateAmountSearchFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateAmountSearchFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateAmountSearchFrom.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    this.label16.AutoSize = true;
    this.label16.Location = new Point(12, 101);
    this.label16.Name = "label16";
    this.label16.Size = new Size(39, 13);
    this.label16.TabIndex = 5;
    this.label16.Text = "Dates:";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAmountSearch).Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtAmountSearch).BackColor = Color.White;
    ((Control) this.txtAmountSearch).Location = new Point(85, 63 /*0x3F*/);
    this.txtAmountSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAmountSearch).Name = "txtAmountSearch";
    ((Control) this.txtAmountSearch).Size = new Size(187, 20);
    ((Control) this.txtAmountSearch).TabIndex = 3;
    ((UltraControlBase) this.txtAmountSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmountSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.comboAmountSearchFor.BorderStyle = (UIElementBorderStyle) 4;
    this.comboAmountSearchFor.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAmountSearchFor).Location = new Point(85, 37);
    this.comboAmountSearchFor.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboAmountSearchFor).Name = "comboAmountSearchFor";
    ((Control) this.comboAmountSearchFor).Size = new Size(187, 21);
    ((Control) this.comboAmountSearchFor).TabIndex = 1;
    ((UltraControlBase) this.comboAmountSearchFor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAmountSearchFor).UseOsThemes = (DefaultableBoolean) 2;
    this.label14.AutoSize = true;
    this.label14.Location = new Point(10, 64 /*0x40*/);
    this.label14.Name = "label14";
    this.label14.Size = new Size(48 /*0x30*/, 13);
    this.label14.TabIndex = 2;
    this.label14.Text = "Amount:";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(9, 40);
    this.label15.Name = "label15";
    this.label15.Size = new Size(63 /*0x3F*/, 13);
    this.label15.TabIndex = 0;
    this.label15.Text = "Search For:";
    this.radioUserSearch.Enabled = false;
    this.radioUserSearch.FlatStyle = FlatStyle.Flat;
    this.radioUserSearch.Location = new Point(11, 445);
    this.radioUserSearch.Name = "radioUserSearch";
    this.radioUserSearch.Size = new Size(136, 19);
    this.radioUserSearch.TabIndex = 10;
    this.radioUserSearch.Text = "User Search Options";
    this.panelUserSearch.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelUserSearch.Controls.Add((Control) this.dateUserSearchTo);
    this.panelUserSearch.Controls.Add((Control) this.label10);
    this.panelUserSearch.Controls.Add((Control) this.label9);
    this.panelUserSearch.Controls.Add((Control) this.dateUserSearchFrom);
    this.panelUserSearch.Controls.Add((Control) this.checkUserSearchUseDates);
    this.panelUserSearch.Controls.Add((Control) this.buttonSearchUser);
    this.panelUserSearch.Controls.Add((Control) this.textUserName);
    this.panelUserSearch.Controls.Add((Control) this.label8);
    this.panelUserSearch.CornerOffset = 1;
    this.panelUserSearch.Enabled = false;
    this.panelUserSearch.Location = new Point(11, 469);
    this.panelUserSearch.Name = "panelUserSearch";
    this.panelUserSearch.Size = new Size(280, 91);
    this.panelUserSearch.TabIndex = 11;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateUserSearchTo.Appearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance10).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance10).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance10).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance10).ForegroundAlpha = (Alpha) 2;
    this.dateUserSearchTo.ButtonAppearance = (AppearanceBase) appearance10;
    this.dateUserSearchTo.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateUserSearchTo).Location = new Point(184, 56);
    this.dateUserSearchTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateUserSearchTo).Name = "dateUserSearchTo";
    ((Control) this.dateUserSearchTo).Size = new Size(88, 20);
    ((Control) this.dateUserSearchTo).TabIndex = 7;
    ((UltraControlBase) this.dateUserSearchTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateUserSearchTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateUserSearchTo.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(160 /*0xA0*/, 56);
    this.label10.Name = "label10";
    this.label10.Size = new Size(23, 13);
    this.label10.TabIndex = 6;
    this.label10.Text = "To:";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(24, 56);
    this.label9.Name = "label9";
    this.label9.Size = new Size(35, 13);
    this.label9.TabIndex = 4;
    this.label9.Text = "From:";
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateUserSearchFrom.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance12).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance12).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance12).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance12).ForegroundAlpha = (Alpha) 2;
    this.dateUserSearchFrom.ButtonAppearance = (AppearanceBase) appearance12;
    this.dateUserSearchFrom.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateUserSearchFrom).Location = new Point(64 /*0x40*/, 56);
    this.dateUserSearchFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateUserSearchFrom).Name = "dateUserSearchFrom";
    ((Control) this.dateUserSearchFrom).Size = new Size(88, 20);
    ((Control) this.dateUserSearchFrom).TabIndex = 5;
    ((UltraControlBase) this.dateUserSearchFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateUserSearchFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateUserSearchFrom.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkUserSearchUseDates).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.checkUserSearchUseDates).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkUserSearchUseDates).Location = new Point(8, 32 /*0x20*/);
    this.checkUserSearchUseDates.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkUserSearchUseDates).Name = "checkUserSearchUseDates";
    ((Control) this.checkUserSearchUseDates).Size = new Size(120, 20);
    ((Control) this.checkUserSearchUseDates).TabIndex = 3;
    ((Control) this.checkUserSearchUseDates).Text = "Use Date Range:";
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance14).Image = componentResourceManager.GetObject("appearance14.Image");
    ((AppearanceBase) appearance14).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance14).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchUser).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonSearchUser).Location = new Point(256 /*0x0100*/, 8);
    ((Control) this.buttonSearchUser).Name = "buttonSearchUser";
    ((Control) this.buttonSearchUser).Size = new Size(20, 20);
    ((Control) this.buttonSearchUser).TabIndex = 2;
    ((UltraControlBase) this.buttonSearchUser).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchUser).Click += new EventHandler(this.buttonSearchUser_Click);
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textUserName).Appearance = (AppearanceBase) appearance15;
    ((Control) this.textUserName).BackColor = Color.White;
    ((Control) this.textUserName).Location = new Point(72, 8);
    this.textUserName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textUserName).Name = "textUserName";
    ((EditorButtonControlBase) this.textUserName).ReadOnly = true;
    ((Control) this.textUserName).Size = new Size(182, 20);
    ((Control) this.textUserName).TabIndex = 1;
    ((UltraControlBase) this.textUserName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textUserName).UseOsThemes = (DefaultableBoolean) 2;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(8, 8);
    this.label8.Name = "label8";
    this.label8.Size = new Size(63 /*0x3F*/, 13);
    this.label8.TabIndex = 0;
    this.label8.Text = "User Name:";
    this.radioEntitySearch.Enabled = false;
    this.radioEntitySearch.FlatStyle = FlatStyle.Flat;
    this.radioEntitySearch.Location = new Point(11, 325);
    this.radioEntitySearch.Name = "radioEntitySearch";
    this.radioEntitySearch.Size = new Size(136, 19);
    this.radioEntitySearch.TabIndex = 8;
    this.radioEntitySearch.Text = "Entity Search Options";
    this.panelEntitySearch.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelEntitySearch.Controls.Add((Control) this.dateEntitySearchTo);
    this.panelEntitySearch.Controls.Add((Control) this.label11);
    this.panelEntitySearch.Controls.Add((Control) this.label12);
    this.panelEntitySearch.Controls.Add((Control) this.dateEntitySearchFrom);
    this.panelEntitySearch.Controls.Add((Control) this.checkEntitySearchUseDates);
    this.panelEntitySearch.Controls.Add((Control) this.buttonSearchEntity);
    this.panelEntitySearch.Controls.Add((Control) this.textEntityName);
    this.panelEntitySearch.Controls.Add((Control) this.label7);
    this.panelEntitySearch.CornerOffset = 1;
    this.panelEntitySearch.Enabled = false;
    this.panelEntitySearch.Location = new Point(11, 349);
    this.panelEntitySearch.Name = "panelEntitySearch";
    this.panelEntitySearch.Size = new Size(280, 91);
    this.panelEntitySearch.TabIndex = 9;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateEntitySearchTo.Appearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance17).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance17).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance17).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance17).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance17).ForegroundAlpha = (Alpha) 2;
    this.dateEntitySearchTo.ButtonAppearance = (AppearanceBase) appearance17;
    this.dateEntitySearchTo.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateEntitySearchTo).Location = new Point(176 /*0xB0*/, 56);
    this.dateEntitySearchTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateEntitySearchTo).Name = "dateEntitySearchTo";
    ((Control) this.dateEntitySearchTo).Size = new Size(88, 20);
    ((Control) this.dateEntitySearchTo).TabIndex = 7;
    ((UltraControlBase) this.dateEntitySearchTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateEntitySearchTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateEntitySearchTo.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(152, 56);
    this.label11.Name = "label11";
    this.label11.Size = new Size(23, 13);
    this.label11.TabIndex = 6;
    this.label11.Text = "To:";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(16 /*0x10*/, 56);
    this.label12.Name = "label12";
    this.label12.Size = new Size(35, 13);
    this.label12.TabIndex = 4;
    this.label12.Text = "From:";
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateEntitySearchFrom.Appearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance19).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance19).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance19).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance19).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance19).ForegroundAlpha = (Alpha) 2;
    this.dateEntitySearchFrom.ButtonAppearance = (AppearanceBase) appearance19;
    this.dateEntitySearchFrom.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateEntitySearchFrom).Location = new Point(56, 56);
    this.dateEntitySearchFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateEntitySearchFrom).Name = "dateEntitySearchFrom";
    ((Control) this.dateEntitySearchFrom).Size = new Size(88, 20);
    ((Control) this.dateEntitySearchFrom).TabIndex = 5;
    ((UltraControlBase) this.dateEntitySearchFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateEntitySearchFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateEntitySearchFrom.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkEntitySearchUseDates).Appearance = (AppearanceBase) appearance20;
    ((UltraToggleEditorBase) this.checkEntitySearchUseDates).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkEntitySearchUseDates).Location = new Point(8, 30);
    this.checkEntitySearchUseDates.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkEntitySearchUseDates).Name = "checkEntitySearchUseDates";
    ((Control) this.checkEntitySearchUseDates).Size = new Size(120, 24);
    ((Control) this.checkEntitySearchUseDates).TabIndex = 3;
    ((Control) this.checkEntitySearchUseDates).Text = "Use Date Range:";
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance21).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance21).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance21).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance21).Image = componentResourceManager.GetObject("appearance21.Image");
    ((AppearanceBase) appearance21).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance21).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchEntity).Appearance = (AppearanceBase) appearance21;
    ((Control) this.buttonSearchEntity).Location = new Point(256 /*0x0100*/, 8);
    ((Control) this.buttonSearchEntity).Name = "buttonSearchEntity";
    ((Control) this.buttonSearchEntity).Size = new Size(20, 20);
    ((Control) this.buttonSearchEntity).TabIndex = 2;
    ((UltraControlBase) this.buttonSearchEntity).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchEntity).Click += new EventHandler(this.buttonSearchEntity_Click);
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEntityName).Appearance = (AppearanceBase) appearance22;
    ((Control) this.textEntityName).BackColor = Color.White;
    ((Control) this.textEntityName).Location = new Point(76, 8);
    this.textEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEntityName).Name = "textEntityName";
    ((EditorButtonControlBase) this.textEntityName).ReadOnly = true;
    ((Control) this.textEntityName).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.textEntityName).TabIndex = 1;
    ((UltraControlBase) this.textEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(8, 8);
    this.label7.Name = "label7";
    this.label7.Size = new Size(69, 13);
    this.label7.TabIndex = 0;
    this.label7.Text = "Entity Name:";
    this.radioDateSearch.Enabled = false;
    this.radioDateSearch.FlatStyle = FlatStyle.Flat;
    this.radioDateSearch.Location = new Point(11, 229);
    this.radioDateSearch.Name = "radioDateSearch";
    this.radioDateSearch.Size = new Size(136, 19);
    this.radioDateSearch.TabIndex = 6;
    this.radioDateSearch.Text = "Date Search Options";
    this.panelDateSearch.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelDateSearch.Controls.Add((Control) this.dateFrom);
    this.panelDateSearch.Controls.Add((Control) this.dateTo);
    this.panelDateSearch.Controls.Add((Control) this.label13);
    this.panelDateSearch.Controls.Add((Control) this.label6);
    this.panelDateSearch.Controls.Add((Control) this.comboDateType);
    this.panelDateSearch.Controls.Add((Control) this.label5);
    this.panelDateSearch.CornerOffset = 1;
    this.panelDateSearch.Enabled = false;
    this.panelDateSearch.Location = new Point(11, 249);
    this.panelDateSearch.Name = "panelDateSearch";
    this.panelDateSearch.Size = new Size(280, 63 /*0x3F*/);
    this.panelDateSearch.TabIndex = 7;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateFrom.Appearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance24).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance24).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance24).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance24).ForegroundAlpha = (Alpha) 2;
    this.dateFrom.ButtonAppearance = (AppearanceBase) appearance24;
    this.dateFrom.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateFrom).Location = new Point(72, 32 /*0x20*/);
    this.dateFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateFrom).Name = "dateFrom";
    ((Control) this.dateFrom).Size = new Size(88, 20);
    ((Control) this.dateFrom).TabIndex = 3;
    ((UltraControlBase) this.dateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateFrom.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTo.Appearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance26).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance26).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance26).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance26).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance26).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance26).ForegroundAlpha = (Alpha) 2;
    this.dateTo.ButtonAppearance = (AppearanceBase) appearance26;
    this.dateTo.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateTo).Location = new Point(184, 32 /*0x20*/);
    this.dateTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTo).Name = "dateTo";
    ((Control) this.dateTo).Size = new Size(88, 20);
    ((Control) this.dateTo).TabIndex = 5;
    ((UltraControlBase) this.dateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTo.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    this.label13.AutoSize = true;
    this.label13.Location = new Point(164, 32 /*0x20*/);
    this.label13.Name = "label13";
    this.label13.Size = new Size(23, 13);
    this.label13.TabIndex = 4;
    this.label13.Text = "To:";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(8, 36);
    this.label6.Name = "label6";
    this.label6.Size = new Size(39, 13);
    this.label6.TabIndex = 2;
    this.label6.Text = "Dates:";
    this.comboDateType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDateType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDateType).Location = new Point(72, 8);
    this.comboDateType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDateType).Name = "comboDateType";
    ((Control) this.comboDateType).Size = new Size(200, 21);
    ((Control) this.comboDateType).TabIndex = 1;
    ((UltraControlBase) this.comboDateType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDateType).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(8, 8);
    this.label5.Name = "label5";
    this.label5.Size = new Size(59, 13);
    this.label5.TabIndex = 0;
    this.label5.Text = "Search By:";
    this.radioItemSearch.Checked = true;
    this.radioItemSearch.Enabled = false;
    this.radioItemSearch.FlatStyle = FlatStyle.Flat;
    this.radioItemSearch.Location = new Point(11, 87);
    this.radioItemSearch.Name = "radioItemSearch";
    this.radioItemSearch.Size = new Size(128 /*0x80*/, 27);
    this.radioItemSearch.TabIndex = 4;
    this.radioItemSearch.TabStop = true;
    this.radioItemSearch.Text = "Item Search Options";
    this.panelItemSearch.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelItemSearch.Controls.Add((Control) this.checkItemSearchUseDates);
    this.panelItemSearch.Controls.Add((Control) this.dateItemSearchTo);
    this.panelItemSearch.Controls.Add((Control) this.label20);
    this.panelItemSearch.Controls.Add((Control) this.label19);
    this.panelItemSearch.Controls.Add((Control) this.dateItemSearchFrom);
    this.panelItemSearch.Controls.Add((Control) this.textSearchFor);
    this.panelItemSearch.Controls.Add((Control) this.comboSearchBy);
    this.panelItemSearch.Controls.Add((Control) this.label4);
    this.panelItemSearch.Controls.Add((Control) this.label3);
    this.panelItemSearch.CornerOffset = 1;
    this.panelItemSearch.Location = new Point(11, 115);
    this.panelItemSearch.Name = "panelItemSearch";
    this.panelItemSearch.Size = new Size(280, 109);
    this.panelItemSearch.TabIndex = 5;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkItemSearchUseDates).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.checkItemSearchUseDates).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkItemSearchUseDates).Location = new Point(12, 55);
    this.checkItemSearchUseDates.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkItemSearchUseDates).Name = "checkItemSearchUseDates";
    ((Control) this.checkItemSearchUseDates).Size = new Size(120, 24);
    ((Control) this.checkItemSearchUseDates).TabIndex = 12;
    ((Control) this.checkItemSearchUseDates).Text = "Use Date Range:";
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateItemSearchTo.Appearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance29).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance29).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance29).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance29).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance29).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance29).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance29).ForegroundAlpha = (Alpha) 2;
    this.dateItemSearchTo.ButtonAppearance = (AppearanceBase) appearance29;
    this.dateItemSearchTo.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateItemSearchTo).Location = new Point(188, 82);
    this.dateItemSearchTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateItemSearchTo).Name = "dateItemSearchTo";
    ((Control) this.dateItemSearchTo).Size = new Size(88, 20);
    ((Control) this.dateItemSearchTo).TabIndex = 11;
    ((UltraControlBase) this.dateItemSearchTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateItemSearchTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateItemSearchTo.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    this.label20.AutoSize = true;
    this.label20.Location = new Point(164, 82);
    this.label20.Name = "label20";
    this.label20.Size = new Size(23, 13);
    this.label20.TabIndex = 10;
    this.label20.Text = "To:";
    this.label19.AutoSize = true;
    this.label19.Location = new Point(28, 82);
    this.label19.Name = "label19";
    this.label19.Size = new Size(35, 13);
    this.label19.TabIndex = 8;
    this.label19.Text = "From:";
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateItemSearchFrom.Appearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance31).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance31).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance31).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance31).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance31).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance31).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance31).ForegroundAlpha = (Alpha) 2;
    this.dateItemSearchFrom.ButtonAppearance = (AppearanceBase) appearance31;
    this.dateItemSearchFrom.DateTime = new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((Control) this.dateItemSearchFrom).Location = new Point(68, 82);
    this.dateItemSearchFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateItemSearchFrom).Name = "dateItemSearchFrom";
    ((Control) this.dateItemSearchFrom).Size = new Size(88, 20);
    ((Control) this.dateItemSearchFrom).TabIndex = 9;
    ((UltraControlBase) this.dateItemSearchFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateItemSearchFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateItemSearchFrom.Value = (object) new DateTime(2019, 5, 28, 0, 0, 0, 0);
    ((AppearanceBase) appearance32).BackColor = Color.White;
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textSearchFor).Appearance = (AppearanceBase) appearance32;
    ((Control) this.textSearchFor).BackColor = Color.White;
    ((Control) this.textSearchFor).Location = new Point(72, 32 /*0x20*/);
    this.textSearchFor.MGAStyle = MGAStyles.Blue;
    ((Control) this.textSearchFor).Name = "textSearchFor";
    ((Control) this.textSearchFor).Size = new Size(200, 20);
    ((Control) this.textSearchFor).TabIndex = 3;
    ((UltraControlBase) this.textSearchFor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textSearchFor).UseOsThemes = (DefaultableBoolean) 2;
    this.comboSearchBy.BorderStyle = (UIElementBorderStyle) 4;
    this.comboSearchBy.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboSearchBy).Location = new Point(72, 8);
    this.comboSearchBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboSearchBy).Name = "comboSearchBy";
    ((Control) this.comboSearchBy).Size = new Size(200, 21);
    ((Control) this.comboSearchBy).TabIndex = 1;
    ((UltraControlBase) this.comboSearchBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboSearchBy).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(8, 32 /*0x20*/);
    this.label4.Name = "label4";
    this.label4.Size = new Size(63 /*0x3F*/, 13);
    this.label4.TabIndex = 2;
    this.label4.Text = "Search For:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(8, 8);
    this.label3.Name = "label3";
    this.label3.Size = new Size(59, 13);
    this.label3.TabIndex = 0;
    this.label3.Text = "Search By:";
    this.comboTransactionType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboTransactionType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboTransactionType).Location = new Point(104, 36);
    this.comboTransactionType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboTransactionType).Name = "comboTransactionType";
    ((Control) this.comboTransactionType).Size = new Size(184, 21);
    ((Control) this.comboTransactionType).TabIndex = 3;
    ((UltraControlBase) this.comboTransactionType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboTransactionType).UseOsThemes = (DefaultableBoolean) 2;
    this.comboTransactionType.RowSelected += new RowSelectedEventHandler(this.comboTransactionType_RowSelected);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 12);
    this.label2.Name = "label2";
    this.label2.Size = new Size(83, 13);
    this.label2.TabIndex = 0;
    this.label2.Text = "Office Location:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(8, 38);
    this.label1.Name = "label1";
    this.label1.Size = new Size(94, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Transaction Type:";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(104, 12);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(184, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.dsSeachTransaction1.DataSetName = "dsSeachTransaction";
    this.dsSeachTransaction1.Locale = new CultureInfo("en-US");
    this.statusStrip.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.labelStatusStrip,
      (ToolStripItem) this.toolStripStatusLabel1
    });
    this.statusStrip.Location = new Point(296, 707);
    this.statusStrip.Name = "statusStrip";
    this.statusStrip.Size = new Size(712, 22);
    this.statusStrip.TabIndex = 3;
    this.statusStrip.Text = "statusStrip";
    this.labelStatusStrip.Name = "labelStatusStrip";
    this.labelStatusStrip.Size = new Size(0, 17);
    this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
    this.toolStripStatusLabel1.Size = new Size(0, 17);
    ((UltraControlBase) this.gridResults).AlphaBlendMode = (AlphaBlendMode) 0;
    ((UltraGridBase) this.gridResults).DataMember = "Transactions";
    ((UltraGridBase) this.gridResults).DataSource = (object) this.dsSeachTransaction1;
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridResults).DisplayLayout.Appearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Transaction Number";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 100;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 95;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 104;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Check Number";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 105;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Transaction Type";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 118;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 104;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 84;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.gridResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridResults).DisplayLayout.CaptionVisible = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance34).ForeColor = Color.Black;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance35).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance36).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance37).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance39).BackColor = Color.Transparent;
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance40).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridResults).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.gridResults).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridResults).Dock = DockStyle.Fill;
    ((Control) this.gridResults).Location = new Point(296, 0);
    ((Control) this.gridResults).Name = "gridResults";
    ((Control) this.gridResults).Size = new Size(712, 729);
    ((Control) this.gridResults).TabIndex = 1;
    ((UltraControlBase) this.gridResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridResults).UseOsThemes = (DefaultableBoolean) 2;
    this.gridResults.DoubleClickRow += new DoubleClickRowEventHandler(this.gridResults_DoubleClickRow);
    this.AcceptButton = (IButtonControl) this.buttonExecuteSearch;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1008, 729);
    this.Controls.Add((Control) this.statusStrip);
    this.Controls.Add((Control) this.gridResults);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(900, 552);
    this.Name = nameof (formSearchTransaction);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Search Transaction";
    this.Closing += new CancelEventHandler(this.formSearchTransaction_Closing);
    this.Load += new EventHandler(this.formSearchTransaction_Load);
    ((ISupportInitialize) this.buttonExecuteSearch).EndInit();
    this.ellipsePanel1.ResumeLayout(false);
    this.ellipsePanel1.PerformLayout();
    ((ISupportInitialize) this.mgaNumericEditor1).EndInit();
    this.panelAmountSearchOptions.ResumeLayout(false);
    this.panelAmountSearchOptions.PerformLayout();
    ((ISupportInitialize) this.comboAmountSearchType).EndInit();
    ((ISupportInitialize) this.dateAmountSearchTo).EndInit();
    ((ISupportInitialize) this.dateAmountSearchFrom).EndInit();
    ((ISupportInitialize) this.txtAmountSearch).EndInit();
    ((ISupportInitialize) this.comboAmountSearchFor).EndInit();
    this.panelUserSearch.ResumeLayout(false);
    this.panelUserSearch.PerformLayout();
    ((ISupportInitialize) this.dateUserSearchTo).EndInit();
    ((ISupportInitialize) this.dateUserSearchFrom).EndInit();
    ((ISupportInitialize) this.checkUserSearchUseDates).EndInit();
    ((ISupportInitialize) this.buttonSearchUser).EndInit();
    ((ISupportInitialize) this.textUserName).EndInit();
    this.panelEntitySearch.ResumeLayout(false);
    this.panelEntitySearch.PerformLayout();
    ((ISupportInitialize) this.dateEntitySearchTo).EndInit();
    ((ISupportInitialize) this.dateEntitySearchFrom).EndInit();
    ((ISupportInitialize) this.checkEntitySearchUseDates).EndInit();
    ((ISupportInitialize) this.buttonSearchEntity).EndInit();
    ((ISupportInitialize) this.textEntityName).EndInit();
    this.panelDateSearch.ResumeLayout(false);
    this.panelDateSearch.PerformLayout();
    ((ISupportInitialize) this.dateFrom).EndInit();
    ((ISupportInitialize) this.dateTo).EndInit();
    ((ISupportInitialize) this.comboDateType).EndInit();
    this.panelItemSearch.ResumeLayout(false);
    this.panelItemSearch.PerformLayout();
    ((ISupportInitialize) this.checkItemSearchUseDates).EndInit();
    ((ISupportInitialize) this.dateItemSearchTo).EndInit();
    ((ISupportInitialize) this.dateItemSearchFrom).EndInit();
    ((ISupportInitialize) this.textSearchFor).EndInit();
    ((ISupportInitialize) this.comboSearchBy).EndInit();
    ((ISupportInitialize) this.comboTransactionType).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.dsOfficeLocations1.EndInit();
    this.dsSeachTransaction1.EndInit();
    this.statusStrip.ResumeLayout(false);
    this.statusStrip.PerformLayout();
    ((ISupportInitialize) this.gridResults).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void CreateTransactionTypesDataset()
  {
    DataSet dataSet = new DataSet();
    DataTable table = DefaultDatabase.ExecuteDataTable("dbo.spFin_getTransactionTypes", new object[2]
    {
      (object) "@ShowAll",
      (object) 1
    }).Copy();
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.comboTransactionType).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboTransactionType).DisplayMember = "TransactionType";
    ((UltraDropDownBase) this.comboTransactionType).ValueMember = "TransactionTypeId";
  }

  private void SetControlBindings()
  {
    this.panelItemSearch.DataBindings.Add("Enabled", (object) this.radioItemSearch, "Checked");
    this.panelDateSearch.DataBindings.Add("Enabled", (object) this.radioDateSearch, "Checked");
    this.panelEntitySearch.DataBindings.Add("Enabled", (object) this.radioEntitySearch, "Checked");
    this.panelUserSearch.DataBindings.Add("Enabled", (object) this.radioUserSearch, "Checked");
    this.panelAmountSearchOptions.DataBindings.Add("Enabled", (object) this.radioAmountSearch, "Checked");
    ((Control) this.dateEntitySearchFrom).DataBindings.Add("Enabled", (object) this.checkEntitySearchUseDates, "Checked");
    ((Control) this.dateEntitySearchTo).DataBindings.Add("Enabled", (object) this.checkEntitySearchUseDates, "Checked");
    ((Control) this.dateUserSearchFrom).DataBindings.Add("Enabled", (object) this.checkUserSearchUseDates, "Checked");
    ((Control) this.dateUserSearchTo).DataBindings.Add("Enabled", (object) this.checkUserSearchUseDates, "Checked");
    ((Control) this.dateItemSearchFrom).DataBindings.Add("Enabled", (object) this.checkItemSearchUseDates, "Checked");
    ((Control) this.dateItemSearchTo).DataBindings.Add("Enabled", (object) this.checkItemSearchUseDates, "Checked");
  }

  private void CreateItemSearchTypesDataset()
  {
    this.comboSearchBy.ComboboxDatasetCreator(new List<string>()
    {
      "Transaction Number",
      "Check Number",
      "Invoice Number",
      "Policy Number",
      "PO Number"
    }, "ItemSearchType");
  }

  private void CreateAmountSearchTypesDataset()
  {
    this.comboAmountSearchType.ComboboxDatasetCreator(new List<string>()
    {
      "Cash",
      "Receivable",
      "Payable",
      "Income",
      "Expense",
      "Exchange",
      "Unaccounted"
    });
  }

  private void CreateAmountSearchForDataset()
  {
    this.comboAmountSearchFor.ComboboxDatasetCreator(new List<string>()
    {
      "Greater Than",
      "Equals",
      "Less Than"
    });
  }

  private void CreateDateSearchTypesDataset()
  {
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable("DateTypes");
    table.Columns.Add(new DataColumn("DateTypeId", typeof (string)));
    table.Columns.Add(new DataColumn("DateType", typeof (string)));
    table.Rows.Add((object) "P", (object) "Post Date");
    table.Rows.Add((object) "C", (object) "Check Date");
    if (((UltraDropDownBase) this.comboTransactionType).SelectedRow != null && ((UltraDropDownBase) this.comboTransactionType).SelectedRow.Cells["TransactionTypeId"].Value.ToString() == "R")
      table.Rows.Add((object) "D", (object) "Deposit Date");
    dataSet.Tables.Add(table);
    ((UltraDropDownBase) this.comboDateType).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboDateType).ValueMember = string.Empty;
    ((UltraGridBase) this.comboDateType).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboDateType).DisplayMember = "DateType";
    ((UltraDropDownBase) this.comboDateType).ValueMember = "DateTypeId";
  }

  private void comboTransactionType_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboTransactionType).SelectedRow == null)
      return;
    this.radioEntitySearch.Enabled = true;
    this.radioDateSearch.Enabled = true;
    this.radioItemSearch.Enabled = true;
    this.radioUserSearch.Enabled = true;
    this.CreateDateSearchTypesDataset();
  }

  private void buttonSearchEntity_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((Control) this.textEntityName).Text = formSearchEntity.EntityName;
      ((Control) this.textEntityName).Tag = (object) formSearchEntity.EntityGuid;
    }
  }

  private void buttonSearchUser_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.ShowUsers))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((Control) this.textUserName).Text = formSearchEntity.EntityName;
      ((Control) this.textUserName).Tag = (object) formSearchEntity.EntityGuid;
    }
  }

  private void SetFromDefaultDate(MGADateTimePicker datePicker)
  {
    datePicker.DateTime = DateTime.Now;
  }

  private void SetToDefaultDate(MGADateTimePicker datePicker) => datePicker.DateTime = DateTime.Now;

  private void buttonExecuteSearch_Click(object sender, EventArgs e) => this.ExecuteSearch();

  protected virtual void ExecuteSearch()
  {
    if (!this.ValidateForm())
      return;
    short int16 = Convert.ToInt16(this.mgaNumericEditor1.Value);
    object[] objArray = this.SetSearchCommandProperties((int) int16);
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.dsSeachTransaction1.Clear();
      DataTable transactions = DefaultDatabase.ExecuteDataTable("spFin_SearchTransaction", objArray);
      ((UltraGridBase) this.gridResults).DataSource = (object) transactions;
      if (this.radioAmountSearch.Checked)
        ((UltraGridBase) this.gridResults).DataSource = (object) this.FilterByAmount(transactions, (int) int16);
      int count = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridResults).Rows).Count;
      if (count == (int) int16)
        this.toolStripStatusLabel1.Text = $"The query limited the results to {int16} items. Please narrow your search if you do not see what you were searching for.";
      else
        this.toolStripStatusLabel1.Text = $"{count} Records found that match the specified criteria.";
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  protected DataTable FilterByAmount(DataTable transactions, int numRecordsLimit)
  {
    List<\u003C\u003Ef__AnonymousType1<object, List<double>>> enumerable = transactions.AsEnumerable().GroupBy((System.Func<DataRow, object>) (t => t["TransactNum"]), (System.Func<DataRow, double>) (t => Convert.ToDouble(t["Amount"])), (key, a) => new
    {
      transactNum = key,
      amounts = a.ToList<double>()
    }).ToList();
    switch (this.comboAmountSearchFor.GetSelectedValueId())
    {
      case "E":
        enumerable = enumerable.Where(e => Math.Abs(Math.Round(e.amounts.Sum(), 2)) == Math.Abs(Convert.ToDouble(((TextEditorControlBase) this.txtAmountSearch).Value))).ToList();
        break;
      case "G":
        enumerable = enumerable.Where(e => Math.Abs(Math.Round(e.amounts.Sum(), 2)) > Math.Abs(Convert.ToDouble(((TextEditorControlBase) this.txtAmountSearch).Value))).ToList();
        break;
      case "L":
        enumerable = enumerable.Where(e => Math.Abs(Math.Round(e.amounts.Sum(), 2)) < Math.Abs(Convert.ToDouble(((TextEditorControlBase) this.txtAmountSearch).Value))).ToList();
        break;
    }
    List<DataRow> list = transactions.AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (tr => enumerable.Select(e => e.transactNum).ToList<object>().Contains(tr["TransactNum"]))).GroupBy<DataRow, object>((System.Func<DataRow, object>) (x => x["TransactNum"])).Select<IGrouping<object, DataRow>, DataRow>((System.Func<IGrouping<object, DataRow>, DataRow>) (y => y.First<DataRow>())).Distinct<DataRow>().ToList<DataRow>().Take<DataRow>(numRecordsLimit).ToList<DataRow>();
    if (list.Any<DataRow>())
    {
      list.ForEach((Action<DataRow>) (t => t["Amount"] = (object) 0));
      return list.CopyToDataTable<DataRow>();
    }
    transactions.Clear();
    return transactions;
  }

  protected bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboTransactionType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an transaction type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return (!this.radioItemSearch.Checked || this.IsItemSearchValid()) && (!this.radioDateSearch.Checked || this.IsDateSearchValid()) && (!this.radioEntitySearch.Checked || this.IsEntitySearchValid()) && (!this.radioUserSearch.Checked || this.IsUserSearchValid()) && (!this.radioAmountSearch.Checked || this.IsAmountSearchValid());
  }

  private bool IsAmountSearchValid()
  {
    if (((UltraDropDownBase) this.comboAmountSearchType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a search type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboAmountSearchFor).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a 'Search For' value to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((TextEditorControlBase) this.txtAmountSearch).Value == null)
    {
      int num = (int) MessageBox.Show("Please enter an amount.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Information.IsNumeric(((TextEditorControlBase) this.txtAmountSearch).Value))
    {
      int num = (int) MessageBox.Show("Amount field must be a number.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    MessageBoxProperties msgBoxProperties;
    if (this.dateAmountSearchFrom.IsMgaDateTimePickerValid(this.dateAmountSearchTo, out msgBoxProperties))
      return true;
    int num1 = (int) MessageBox.Show(msgBoxProperties.Message, msgBoxProperties.Caption, msgBoxProperties.Button, msgBoxProperties.Icon);
    return false;
  }

  private bool IsItemSearchValid()
  {
    if (((UltraDropDownBase) this.comboSearchBy).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a search type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textSearchFor).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a value to search for to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    string str = ((UltraDropDownBase) this.comboSearchBy).SelectedRow.Cells["ItemSearchTypeId"].Value.ToString();
    if (str != "P" && str != "C" && !Information.IsNumeric((object) ((Control) this.textSearchFor).Text))
    {
      int num = (int) MessageBox.Show("The search type you selected requires that the search value is numeric.", "Invalid Search Value!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (str != "P" && str != "C")
    {
      if (Information.IsNumeric((object) ((Control) this.textSearchFor).Text))
      {
        try
        {
          int.Parse(((Control) this.textSearchFor).Text);
        }
        catch (FormatException ex)
        {
          int num = (int) MessageBox.Show("Invalid Search for value, please make sure search for value is an integer.", "Invalid Search For Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
      }
    }
    return true;
  }

  private bool IsDateSearchValid()
  {
    if (((UltraDropDownBase) this.comboDateType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an date search type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    MessageBoxProperties msgBoxProperties;
    if (this.dateFrom.IsMgaDateTimePickerValid(this.dateTo, out msgBoxProperties))
      return true;
    int num1 = (int) MessageBox.Show(msgBoxProperties.Message, msgBoxProperties.Caption, msgBoxProperties.Button, msgBoxProperties.Icon);
    return false;
  }

  private bool IsEntitySearchValid()
  {
    if (((Control) this.textEntityName).Text.Equals(string.Empty) || ((Control) this.textEntityName).Tag == null)
    {
      int num = (int) MessageBox.Show("You must select an entity to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraToggleEditorBase) this.checkEntitySearchUseDates).Checked)
    {
      if (this.dateEntitySearchFrom.Value.Equals((object) DBNull.Value) || this.dateEntitySearchTo.Value.Equals((object) DBNull.Value))
      {
        int num = (int) MessageBox.Show("Both a starting date and an ending date must be supplied to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (this.dateEntitySearchFrom.DateTime > this.dateEntitySearchTo.DateTime)
      {
        int num = (int) MessageBox.Show("Starting date can not be greater than ending date.", "Invalid Search Criteria!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
  }

  private bool IsUserSearchValid()
  {
    if (((Control) this.textUserName).Text.Equals(string.Empty) || ((Control) this.textUserName).Tag == null)
    {
      int num = (int) MessageBox.Show("You must select an user to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraToggleEditorBase) this.checkUserSearchUseDates).Checked)
    {
      if (this.dateUserSearchFrom.Value.Equals((object) DBNull.Value) || this.dateUserSearchTo.Value.Equals((object) DBNull.Value))
      {
        int num = (int) MessageBox.Show("Both a starting date and an ending date must be supplied to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (this.dateUserSearchFrom.DateTime > this.dateUserSearchTo.DateTime)
      {
        int num = (int) MessageBox.Show("Starting date can not be greater than ending date.", "Invalid Search Criteria!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
  }

  protected object[] SetSearchCommandProperties(int numRecordsLimit)
  {
    Dictionary<string, object> parameters = new Dictionary<string, object>()
    {
      {
        "@glcompanyid",
        (object) int.Parse(this.comboOfficeLocation.GetSelectedValueId())
      },
      {
        "@transactiontype",
        (object) this.comboTransactionType.GetSelectedValueId()
      }
    };
    if (this.radioItemSearch.Checked)
    {
      switch (this.comboSearchBy.GetSelectedValueId())
      {
        case "T":
          parameters.Add("@transactionNumber", (object) int.Parse(((Control) this.textSearchFor).Text));
          break;
        case "C":
          parameters.Add("@checkNumber", (object) ((Control) this.textSearchFor).Text);
          parameters.Add("@dateType", (object) 'C');
          break;
        case "I":
          parameters.Add("@invoiceNumber", (object) int.Parse(((Control) this.textSearchFor).Text));
          break;
        case "P":
          parameters.Add("@policyNumber", (object) ((Control) this.textSearchFor).Text);
          break;
        case "O":
          parameters.Add("@poNumber", (object) ((Control) this.textSearchFor).Text);
          break;
      }
      if (((UltraToggleEditorBase) this.checkItemSearchUseDates).Checked)
      {
        parameters.Add("@dateFrom", (object) this.dateItemSearchFrom.DateTime);
        parameters.Add("@dateTo", (object) this.dateItemSearchTo.DateTime);
      }
    }
    else if (this.radioDateSearch.Checked)
    {
      parameters.Add("@dateType", (object) this.comboDateType.GetSelectedValueId());
      parameters.Add("@dateFrom", (object) this.dateFrom.DateTime);
      parameters.Add("@dateTo", (object) this.dateTo.DateTime);
    }
    else if (this.radioEntitySearch.Checked)
    {
      parameters.Add("@entityGuid", (object) new Guid(((Control) this.textEntityName).Tag.ToString()));
      if (((UltraToggleEditorBase) this.checkEntitySearchUseDates).Checked)
      {
        parameters.Add("@dateType", (object) "P");
        parameters.Add("@dateFrom", (object) this.dateEntitySearchFrom.DateTime);
        parameters.Add("@dateTo", (object) this.dateEntitySearchTo.DateTime);
      }
    }
    else if (this.radioUserSearch.Checked)
    {
      parameters.Add("@userGuid", (object) new Guid(((Control) this.textUserName).Tag.ToString()));
      if (((UltraToggleEditorBase) this.checkUserSearchUseDates).Checked)
      {
        parameters.Add("@dateType", (object) "P");
        parameters.Add("@dateFrom", (object) this.dateUserSearchFrom.DateTime);
        parameters.Add("@dateTo", (object) this.dateUserSearchTo.DateTime);
      }
    }
    else if (this.radioAmountSearch.Checked)
    {
      parameters.Add("@amountSearchType", (object) this.comboAmountSearchType.GetSelectedValueId());
      parameters.Add("@dateFrom", (object) this.dateAmountSearchFrom.DateTime);
      parameters.Add("@dateTo", (object) this.dateAmountSearchTo.DateTime);
    }
    parameters.Add("@numRecordsLimit", (object) numRecordsLimit);
    this.daSearchTransaction.ClearParameters();
    this.daSearchTransaction.AddSelectParameters(parameters);
    object[] objArray = new object[parameters.Count * 2];
    int index1 = 0;
    foreach (KeyValuePair<string, object> keyValuePair in parameters)
    {
      objArray[index1] = (object) keyValuePair.Key;
      int index2 = index1 + 1;
      objArray[index2] = keyValuePair.Value;
      index1 = index2 + 1;
    }
    return objArray;
  }

  private void UserVoidedTransaction(object sender, EventArgs e)
  {
    if (this.IsDisposed || this.Disposing)
      return;
    this.ExecuteSearch();
  }

  private void TransactionViewerClosing(object sender, CancelEventArgs e)
  {
    if (!(sender is formTransactionViewer))
      return;
    ((formTransactionViewer) sender).TransactionChanged -= new formTransactionViewer.OnTransactionChangedHandler(this.UserVoidedTransaction);
    ((Form) sender).Closing -= new CancelEventHandler(this.TransactionViewerClosing);
  }

  private void formSearchTransaction_Closing(object sender, CancelEventArgs e)
  {
  }

  private void gridResults_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridResults).Rows).Count == 0 || this.gridResults.Selected.Rows[0] == null)
      return;
    UltraGridRow row = this.gridResults.Selected.Rows[0];
    if (row == null)
      return;
    formTransactionViewer form = (formTransactionViewer) ObjectFactory.Instance.CreateForm(typeof (formTransactionViewer), new object[2]
    {
      (object) int.Parse(row.Cells["transactNum"].Value.ToString()),
      (object) int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["id"].Value.ToString())
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Closing += new CancelEventHandler(this.TransactionViewerClosing);
    form.TransactionChanged += new formTransactionViewer.OnTransactionChangedHandler(this.UserVoidedTransaction);
    form.Show();
  }

  private void formSearchTransaction_Load(object sender, EventArgs e)
  {
    this.SetControlBindings();
    this.formDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dsOfficeLocations1 = Methods.GetOfficeLocationDataset(true);
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    try
    {
      this.comboOfficeLocation.Value = (object) -1;
    }
    catch
    {
    }
    this.CreateTransactionTypesDataset();
    this.CreateItemSearchTypesDataset();
    this.CreateItemSearchTypesDataset();
    this.CreateAmountSearchTypesDataset();
    this.CreateAmountSearchForDataset();
    this.comboTransactionType.Value = (object) "ALL";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count != 1)
      return;
    this.comboOfficeLocation.Value = ((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["id"].Value;
  }

  private void EllipsePanel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void Label22_Click(object sender, EventArgs e)
  {
  }

  private void MgaNumericEditor1_ValueChanged(object sender, EventArgs e)
  {
  }
}
