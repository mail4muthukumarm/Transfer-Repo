// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.SharedForms.formPayeeAddressSelection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.SharedForms;

[SecureResource("{DF7A724E-33F9-445B-901C-CF77C8251F3F}", "Payee Address Override Rights", "Determines if the user can enter/override a payee address when posting accounts payable.", "Accounting")]
public class formPayeeAddressSelection : AccountingNoteDocumentSupport
{
  internal SqlConnection FormDataConnection;
  internal SqlDataAdapter daAddressSelections;
  internal SqlCommand SqlSelectCommand1;
  internal Label lblDefaultAddress;
  internal RadioButton optDefault;
  internal UltraGrid gridAddresses;
  internal RadioButton optSelect;
  internal MGATextBox txtAddressName;
  internal Label Label2;
  internal RadioButton optNew;
  internal MGAButton btnCancel;
  internal MGAButton btnOK;
  internal Panel panelHidden;
  internal MGATextBox txtHiddenPayeeZipPlus;
  internal MGATextBox txtHiddenPayeeZipCode;
  internal MGATextBox txtHiddenPayeeAddress1;
  internal MGATextBox txtHiddenPayeeAddress2;
  internal MGATextBox txtHiddenPayeeCity;
  internal MGATextBox txtHiddenPayeeState;
  internal MGATextBox txtHiddenPayeeName;
  internal ErrorProvider ErrorProvider1;
  private dsPayeeAddressSelections dsPayeeAddressSelections1;
  private AddressResolver_MULTI ZipCodeResolver1;
  private MGAGroupBox groupDefaultAddress;
  private MGAGroupBox groupAlternateAddress;
  private MGAGroupBox groupNewAddress;
  private UltraLabel ultraLabel1;
  private Panel panel1;
  private Label label1;
  private Label labelHeader;
  private PictureBox pictureBox1;
  private UltraLabel ultraLabel8;
  private UltraLabel ultraLabel6;
  private Panel panel2;
  private Label label4;
  private UltraPictureBox ultraPictureBox1;
  private UltraGroupBox ultraGroupBox1;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel7;
  private MGATextBox textCheckMemo;
  private IContainer components;
  private Guid entityGUID;
  private string payeeName;
  private string address1;
  private string address2;
  private string city;
  private string state;
  private string zipCode;
  private string zipPlus;
  private string checkMemo;
  private Utility.EntityType payeeType;
  private string DefaultAddressString = string.Empty;
  private bool showWarning;

  public formPayeeAddressSelection(Guid payeeGuid)
  {
    this.InitializeComponent();
    this.entityGUID = payeeGuid;
    this.SetEntityType();
    this.LoadLocationChoices();
    this.SetAddressResolverConnectionProperties();
  }

  public formPayeeAddressSelection(Guid payeeGuid, bool showWarning)
  {
    this.InitializeComponent();
    this.entityGUID = payeeGuid;
    this.showWarning = showWarning;
    this.SetEntityType();
    this.LoadLocationChoices();
    this.SetAddressResolverConnectionProperties();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetPayeeAddressSelections", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Alternate Address");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ADDRESS1");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ADDRESS2");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CITY");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("STATE");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ZIPCODE");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ZIPPLUS");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("NAME");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Select", 0);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formPayeeAddressSelection));
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    this.lblDefaultAddress = new Label();
    this.optDefault = new RadioButton();
    this.gridAddresses = new UltraGrid();
    this.dsPayeeAddressSelections1 = new dsPayeeAddressSelections();
    this.optSelect = new RadioButton();
    this.txtAddressName = new MGATextBox();
    this.ZipCodeResolver1 = new AddressResolver_MULTI();
    this.Label2 = new Label();
    this.optNew = new RadioButton();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.FormDataConnection = new SqlConnection();
    this.daAddressSelections = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.panelHidden = new Panel();
    this.txtHiddenPayeeZipPlus = new MGATextBox();
    this.txtHiddenPayeeZipCode = new MGATextBox();
    this.txtHiddenPayeeAddress1 = new MGATextBox();
    this.txtHiddenPayeeAddress2 = new MGATextBox();
    this.txtHiddenPayeeCity = new MGATextBox();
    this.txtHiddenPayeeState = new MGATextBox();
    this.txtHiddenPayeeName = new MGATextBox();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.groupDefaultAddress = new MGAGroupBox();
    this.groupAlternateAddress = new MGAGroupBox();
    this.groupNewAddress = new MGAGroupBox();
    this.ultraLabel1 = new UltraLabel();
    this.panel1 = new Panel();
    this.label1 = new Label();
    this.labelHeader = new Label();
    this.pictureBox1 = new PictureBox();
    this.ultraLabel8 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.panel2 = new Panel();
    this.label4 = new Label();
    this.ultraPictureBox1 = new UltraPictureBox();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel7 = new UltraLabel();
    this.textCheckMemo = new MGATextBox();
    ((ISupportInitialize) this.gridAddresses).BeginInit();
    this.dsPayeeAddressSelections1.BeginInit();
    ((ISupportInitialize) this.txtAddressName).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    this.panelHidden.SuspendLayout();
    ((ISupportInitialize) this.txtHiddenPayeeZipPlus).BeginInit();
    ((ISupportInitialize) this.txtHiddenPayeeZipCode).BeginInit();
    ((ISupportInitialize) this.txtHiddenPayeeAddress1).BeginInit();
    ((ISupportInitialize) this.txtHiddenPayeeAddress2).BeginInit();
    ((ISupportInitialize) this.txtHiddenPayeeCity).BeginInit();
    ((ISupportInitialize) this.txtHiddenPayeeState).BeginInit();
    ((ISupportInitialize) this.txtHiddenPayeeName).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.groupDefaultAddress).BeginInit();
    ((Control) this.groupDefaultAddress).SuspendLayout();
    ((ISupportInitialize) this.groupAlternateAddress).BeginInit();
    ((Control) this.groupAlternateAddress).SuspendLayout();
    ((ISupportInitialize) this.groupNewAddress).BeginInit();
    ((Control) this.groupNewAddress).SuspendLayout();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.textCheckMemo).BeginInit();
    this.SuspendLayout();
    this.lblDefaultAddress.BackColor = Color.Transparent;
    this.lblDefaultAddress.Location = new Point(8, 24);
    this.lblDefaultAddress.Name = "lblDefaultAddress";
    this.lblDefaultAddress.Size = new Size(464, 88);
    this.lblDefaultAddress.TabIndex = 1;
    this.lblDefaultAddress.UseMnemonic = false;
    this.optDefault.BackColor = Color.Transparent;
    this.optDefault.Checked = true;
    this.optDefault.FlatStyle = FlatStyle.Flat;
    this.optDefault.Location = new Point(200, 96 /*0x60*/);
    this.optDefault.Name = "optDefault";
    this.optDefault.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.optDefault.TabIndex = 0;
    this.optDefault.TabStop = true;
    this.optDefault.Text = "&Default Address";
    this.optDefault.UseVisualStyleBackColor = false;
    this.optDefault.Click += new EventHandler(this.OptionSelectionClicked);
    ((UltraGridBase) this.gridAddresses).DataMember = "spFin_GetPayeeAddressSelections";
    ((UltraGridBase) this.gridAddresses).DataSource = (object) this.dsPayeeAddressSelections1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAddresses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridAddresses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Width = 293;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Hidden = true;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 4;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Hidden = true;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 8;
    ultraGridColumn7.Hidden = true;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ((AppearanceBase) appearance2).BackColor = Color.LightSteelBlue;
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn9.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 0;
    ultraGridColumn9.Style = (ColumnStyle) 3;
    ultraGridColumn9.TabStop = false;
    ultraGridColumn9.Width = 53;
    ultraGridBand.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.Silver;
    ultraGridBand.Override.RowAppearance = (AppearanceBase) appearance3;
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridBand.Override.RowSizing = (RowSizing) 4;
    ((UltraGridBase) this.gridAddresses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridAddresses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridAddresses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridAddresses).DisplayLayout.Override.CellMultiLine = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAddresses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(246, 250, 253);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAddresses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((Control) this.gridAddresses).Dock = DockStyle.Fill;
    ((Control) this.gridAddresses).Location = new Point(2, 22);
    ((Control) this.gridAddresses).Name = "gridAddresses";
    ((Control) this.gridAddresses).Size = new Size(476, 136);
    ((Control) this.gridAddresses).TabIndex = 1;
    ((Control) this.gridAddresses).TabStop = false;
    this.gridAddresses.UpdateMode = (UpdateMode) 4;
    this.gridAddresses.InitializeRow += new InitializeRowEventHandler(this.gridAddresses_InitializeRow);
    ((Control) this.gridAddresses).Click += new EventHandler(this.gridAddresses_Click);
    this.dsPayeeAddressSelections1.DataSetName = "dsPayeeAddressSelections";
    this.dsPayeeAddressSelections1.Locale = new CultureInfo("en-US");
    this.optSelect.BackColor = Color.Transparent;
    this.optSelect.FlatStyle = FlatStyle.Flat;
    this.optSelect.Location = new Point(200, 248);
    this.optSelect.Name = "optSelect";
    this.optSelect.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.optSelect.TabIndex = 0;
    this.optSelect.Text = "&Select Address";
    this.optSelect.UseVisualStyleBackColor = false;
    this.optSelect.Click += new EventHandler(this.OptionSelectionClicked);
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAddressName).Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtAddressName).BackColor = Color.White;
    ((Control) this.txtAddressName).Location = new Point(80 /*0x50*/, 24);
    ((TextEditorControlBase) this.txtAddressName).MaxLength = 150;
    this.txtAddressName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAddressName).Name = "txtAddressName";
    ((Control) this.txtAddressName).Size = new Size(384, 20);
    ((Control) this.txtAddressName).TabIndex = 3;
    ((UltraControlBase) this.txtAddressName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAddressName).UseOsThemes = (DefaultableBoolean) 2;
    this.ZipCodeResolver1.Address1 = "";
    this.ZipCodeResolver1.Address2 = "";
    ((Control) this.ZipCodeResolver1).BackColor = Color.Transparent;
    this.ZipCodeResolver1.City = "";
    this.ZipCodeResolver1.County = "";
    ((Control) this.ZipCodeResolver1).Font = new Font("Tahoma", 8f);
    ((Control) this.ZipCodeResolver1).Location = new Point(8, 40);
    this.ZipCodeResolver1.MGAStyle = MGAStyles.Blue;
    ((Control) this.ZipCodeResolver1).Name = "ZipCodeResolver1";
    ((Control) this.ZipCodeResolver1).Size = new Size(248, 152);
    this.ZipCodeResolver1.State = "";
    ((Control) this.ZipCodeResolver1).TabIndex = 4;
    this.ZipCodeResolver1.TextAlign = ContentAlignment.TopLeft;
    this.ZipCodeResolver1.ZipCode = "";
    this.ZipCodeResolver1.ZipCodeExtension = "";
    this.Label2.BackColor = Color.FromArgb(239, 247, 253);
    this.Label2.Location = new Point(16 /*0x10*/, 24);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Name:";
    this.optNew.BackColor = Color.Transparent;
    this.optNew.FlatStyle = FlatStyle.Flat;
    this.optNew.Location = new Point(200, 432);
    this.optNew.Name = "optNew";
    this.optNew.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.optNew.TabIndex = 0;
    this.optNew.Text = "&New Address";
    this.optNew.UseVisualStyleBackColor = false;
    this.optNew.Click += new EventHandler(this.OptionSelectionClicked);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnCancel).Location = new Point(600, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((Control) this.btnCancel).Text = "&Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((Control) this.btnOK).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnOK).Location = new Point(512 /*0x0200*/, 8);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOK).TabIndex = 0;
    ((Control) this.btnOK).Text = "&OK";
    ((UltraControlBase) this.btnOK).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Click += new EventHandler(this.btnOK_Click);
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daAddressSelections.SelectCommand = this.SqlSelectCommand1;
    this.daAddressSelections.TableMappings.AddRange(new DataTableMapping[3]
    {
      new DataTableMapping("Table", "spFin_GetPayeeAddressSelections", new DataColumnMapping[6]
      {
        new DataColumnMapping("Alternate Address", "Alternate Address"),
        new DataColumnMapping("ADDRESS1", "ADDRESS1"),
        new DataColumnMapping("ADDRESS2", "ADDRESS2"),
        new DataColumnMapping("STATE", "STATE"),
        new DataColumnMapping("ZIPCODE", "ZIPCODE"),
        new DataColumnMapping("ZIPPLUS", "ZIPPLUS")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[6]
      {
        new DataColumnMapping("Alternate Address", "Alternate Address"),
        new DataColumnMapping("ADDRESS1", "ADDRESS1"),
        new DataColumnMapping("ADDRESS2", "ADDRESS2"),
        new DataColumnMapping("STATE", "STATE"),
        new DataColumnMapping("ZIPCODE", "ZIPCODE"),
        new DataColumnMapping("ZIPPLUS", "ZIPPLUS")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[6]
      {
        new DataColumnMapping("Alternate Address", "Alternate Address"),
        new DataColumnMapping("ADDRESS1", "ADDRESS1"),
        new DataColumnMapping("ADDRESS2", "ADDRESS2"),
        new DataColumnMapping("STATE", "STATE"),
        new DataColumnMapping("ZIPCODE", "ZIPCODE"),
        new DataColumnMapping("ZIPPLUS", "ZIPPLUS")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetPayeeAddressSelections]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@PAYEETYPE", SqlDbType.VarChar, 3),
      new SqlParameter("@ENTITYGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeZipPlus);
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeZipCode);
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeAddress1);
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeAddress2);
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeCity);
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeState);
    this.panelHidden.Controls.Add((Control) this.txtHiddenPayeeName);
    this.panelHidden.Location = new Point(200, 112 /*0x70*/);
    this.panelHidden.Name = "panelHidden";
    this.panelHidden.Size = new Size(96 /*0x60*/, 56);
    this.panelHidden.TabIndex = 21;
    this.panelHidden.Visible = false;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.Gray;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeZipPlus).Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtHiddenPayeeZipPlus).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeZipPlus).Location = new Point(48 /*0x30*/, 80 /*0x50*/);
    ((Control) this.txtHiddenPayeeZipPlus).Name = "txtHiddenPayeeZipPlus";
    ((Control) this.txtHiddenPayeeZipPlus).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeZipPlus).TabIndex = 26;
    ((UltraControlBase) this.txtHiddenPayeeZipPlus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeZipPlus).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.Gray;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeZipCode).Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtHiddenPayeeZipCode).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeZipCode).Location = new Point(48 /*0x30*/, 56);
    ((Control) this.txtHiddenPayeeZipCode).Name = "txtHiddenPayeeZipCode";
    ((Control) this.txtHiddenPayeeZipCode).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeZipCode).TabIndex = 4;
    ((UltraControlBase) this.txtHiddenPayeeZipCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeZipCode).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.Gray;
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeAddress1).Appearance = (AppearanceBase) appearance12;
    ((Control) this.txtHiddenPayeeAddress1).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeAddress1).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.txtHiddenPayeeAddress1).Name = "txtHiddenPayeeAddress1";
    ((Control) this.txtHiddenPayeeAddress1).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeAddress1).TabIndex = 1;
    ((UltraControlBase) this.txtHiddenPayeeAddress1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeAddress1).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.Gray;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeAddress2).Appearance = (AppearanceBase) appearance13;
    ((Control) this.txtHiddenPayeeAddress2).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeAddress2).Location = new Point(8, 56);
    ((Control) this.txtHiddenPayeeAddress2).Name = "txtHiddenPayeeAddress2";
    ((Control) this.txtHiddenPayeeAddress2).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeAddress2).TabIndex = 3;
    ((UltraControlBase) this.txtHiddenPayeeAddress2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeAddress2).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.Gray;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeCity).Appearance = (AppearanceBase) appearance14;
    ((Control) this.txtHiddenPayeeCity).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeCity).Location = new Point(48 /*0x30*/, 8);
    ((Control) this.txtHiddenPayeeCity).Name = "txtHiddenPayeeCity";
    ((Control) this.txtHiddenPayeeCity).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeCity).TabIndex = 5;
    ((UltraControlBase) this.txtHiddenPayeeCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeCity).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.Gray;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeState).Appearance = (AppearanceBase) appearance15;
    ((Control) this.txtHiddenPayeeState).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeState).Location = new Point(48 /*0x30*/, 32 /*0x20*/);
    ((Control) this.txtHiddenPayeeState).Name = "txtHiddenPayeeState";
    ((Control) this.txtHiddenPayeeState).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeState).TabIndex = 2;
    ((UltraControlBase) this.txtHiddenPayeeState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeState).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.Gray;
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtHiddenPayeeName).Appearance = (AppearanceBase) appearance16;
    ((Control) this.txtHiddenPayeeName).BackColor = Color.White;
    ((Control) this.txtHiddenPayeeName).Location = new Point(8, 8);
    ((Control) this.txtHiddenPayeeName).Name = "txtHiddenPayeeName";
    ((Control) this.txtHiddenPayeeName).Size = new Size(32 /*0x20*/, 20);
    ((Control) this.txtHiddenPayeeName).TabIndex = 20;
    ((UltraControlBase) this.txtHiddenPayeeName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtHiddenPayeeName).UseOsThemes = (DefaultableBoolean) 2;
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    ((AppearanceBase) appearance17).BackColor = Color.Transparent;
    this.groupDefaultAddress.Appearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupDefaultAddress.ContentAreaAppearance = (AppearanceBase) appearance18;
    ((Control) this.groupDefaultAddress).Controls.Add((Control) this.lblDefaultAddress);
    ((AppearanceBase) appearance19).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance19).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance19).ForeColor = Color.White;
    ((AppearanceBase) appearance19).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance19).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance19).ImageBackground = (Image) componentResourceManager.GetObject("appearance18.ImageBackground");
    ((AppearanceBase) appearance19).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupDefaultAddress.HeaderAppearance = (AppearanceBase) appearance19;
    ((Control) this.groupDefaultAddress).Location = new Point(200, 112 /*0x70*/);
    ((Control) this.groupDefaultAddress).Name = "groupDefaultAddress";
    ((Control) this.groupDefaultAddress).Size = new Size(480, 128 /*0x80*/);
    ((Control) this.groupDefaultAddress).TabIndex = 22;
    ((Control) this.groupDefaultAddress).Text = "Use Default Address";
    this.groupDefaultAddress.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupAlternateAddress.ContentAreaAppearance = (AppearanceBase) appearance20;
    ((Control) this.groupAlternateAddress).Controls.Add((Control) this.gridAddresses);
    ((AppearanceBase) appearance21).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance21).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance21).ForeColor = Color.White;
    ((AppearanceBase) appearance21).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance21).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance21).ImageBackground = (Image) componentResourceManager.GetObject("appearance20.ImageBackground");
    ((AppearanceBase) appearance21).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupAlternateAddress.HeaderAppearance = (AppearanceBase) appearance21;
    ((Control) this.groupAlternateAddress).Location = new Point(200, 264);
    ((Control) this.groupAlternateAddress).Name = "groupAlternateAddress";
    ((Control) this.groupAlternateAddress).Size = new Size(480, 160 /*0xA0*/);
    ((Control) this.groupAlternateAddress).TabIndex = 23;
    ((Control) this.groupAlternateAddress).Text = "Select An Alternate Address";
    this.groupAlternateAddress.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance22).BackColor = Color.Transparent;
    this.groupNewAddress.Appearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupNewAddress.ContentAreaAppearance = (AppearanceBase) appearance23;
    ((Control) this.groupNewAddress).Controls.Add((Control) this.txtAddressName);
    ((Control) this.groupNewAddress).Controls.Add((Control) this.Label2);
    ((Control) this.groupNewAddress).Controls.Add((Control) this.ZipCodeResolver1);
    ((AppearanceBase) appearance24).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance24).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance24).ForeColor = Color.White;
    ((AppearanceBase) appearance24).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance24).ImageBackground = (Image) componentResourceManager.GetObject("appearance22.ImageBackground");
    ((AppearanceBase) appearance24).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupNewAddress.HeaderAppearance = (AppearanceBase) appearance24;
    ((Control) this.groupNewAddress).Location = new Point(200, 448);
    ((Control) this.groupNewAddress).Name = "groupNewAddress";
    ((Control) this.groupNewAddress).Size = new Size(480, 200);
    ((Control) this.groupNewAddress).TabIndex = 24;
    ((Control) this.groupNewAddress).Text = "Create A New Address";
    this.groupNewAddress.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance25).BackColor = Color.Transparent;
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance25;
    ((Control) this.ultraLabel1).Dock = DockStyle.Left;
    ((Control) this.ultraLabel1).Location = new Point(0, 88);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(184, 568);
    ((Control) this.ultraLabel1).TabIndex = 42;
    ((UltraControlBase) this.ultraLabel1).UseOsThemes = (DefaultableBoolean) 2;
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.labelHeader);
    this.panel1.Controls.Add((Control) this.pictureBox1);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(690, 88);
    this.panel1.TabIndex = 41;
    this.label1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Dock = DockStyle.Bottom;
    this.label1.ForeColor = Color.Gray;
    this.label1.Location = new Point(0, 87);
    this.label1.Name = "label1";
    this.label1.Size = new Size(690, 1);
    this.label1.TabIndex = 1;
    this.labelHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.labelHeader.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.labelHeader.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelHeader.Location = new Point(224 /*0xE0*/, 56);
    this.labelHeader.Name = "labelHeader";
    this.labelHeader.Size = new Size(456, 25);
    this.labelHeader.TabIndex = 0;
    this.labelHeader.Text = "Check Memo / Payee Address Selection Utility";
    this.labelHeader.TextAlign = ContentAlignment.TopRight;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(24, 4);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(88, 80 /*0x50*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    ((AppearanceBase) appearance26).BackColor = Color.Transparent;
    ((AppearanceBase) appearance26).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance26).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance26).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance26;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 96 /*0x60*/);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(123, 15);
    ((Control) this.ultraLabel8).TabIndex = 43;
    ((Control) this.ultraLabel8).Text = "ADDRESS SELECTION";
    ((AppearanceBase) appearance27).BackColor = Color.Transparent;
    ((AppearanceBase) appearance27).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance27).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance27).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance27;
    ((Control) this.ultraLabel6).Location = new Point(8, 112 /*0x70*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(168, 32 /*0x20*/);
    ((Control) this.ultraLabel6).TabIndex = 44;
    ((Control) this.ultraLabel6).Text = "Select the address you wish to use, or create a new one.";
    this.panel2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Controls.Add((Control) this.btnCancel);
    this.panel2.Controls.Add((Control) this.btnOK);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 656);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(690, 40);
    this.panel2.TabIndex = 45;
    this.label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.BorderStyle = BorderStyle.Fixed3D;
    this.label4.Dock = DockStyle.Top;
    this.label4.ForeColor = Color.Gray;
    this.label4.Location = new Point(0, 0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(690, 1);
    this.label4.TabIndex = 3;
    ((Control) this.ultraPictureBox1).AutoSize = true;
    this.ultraPictureBox1.BorderShadowColor = Color.Empty;
    this.ultraPictureBox1.Image = componentResourceManager.GetObject("ultraPictureBox1.Image");
    ((Control) this.ultraPictureBox1).Location = new Point(8, 0);
    ((Control) this.ultraPictureBox1).Name = "ultraPictureBox1";
    ((Control) this.ultraPictureBox1).Size = new Size(16 /*0x10*/, 15);
    ((Control) this.ultraPictureBox1).TabIndex = 46;
    ((AppearanceBase) appearance28).BackColor = Color.Transparent;
    ((AppearanceBase) appearance28).BackGradientStyle = (GradientStyle) 2;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance28;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel5);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel3);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel2);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel4);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraPictureBox1);
    ((AppearanceBase) appearance29).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance29).ForeColor = Color.DimGray;
    this.ultraGroupBox1.HeaderAppearance = (AppearanceBase) appearance29;
    ((Control) this.ultraGroupBox1).Location = new Point(8, 320);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(168, 312);
    ((Control) this.ultraGroupBox1).TabIndex = 47;
    ((Control) this.ultraGroupBox1).Text = "      HELP";
    ((AppearanceBase) appearance30).BackColor = Color.Transparent;
    ((AppearanceBase) appearance30).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance30).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance30).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance30;
    ((Control) this.ultraLabel5).Location = new Point(8, 216);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(152, 88);
    ((Control) this.ultraLabel5).TabIndex = 48 /*0x30*/;
    ((Control) this.ultraLabel5).Text = "If the check must be cut to completely different address than the addresses loaded in the system. User can use the 'New Address' option, to specify the necessary address.";
    ((AppearanceBase) appearance31).BackColor = Color.Transparent;
    ((AppearanceBase) appearance31).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance31).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance31).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance31;
    ((Control) this.ultraLabel3).Location = new Point(8, 120);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(152, 72);
    ((Control) this.ultraLabel3).TabIndex = 47;
    ((Control) this.ultraLabel3).Text = "If the entity is a producer or a company, the entity will most likely have 'Alternate Locations' for you to choose from.";
    ((AppearanceBase) appearance32).BackColor = Color.Transparent;
    ((AppearanceBase) appearance32).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance32).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance32;
    ((Control) this.ultraLabel2).Font = new Font("Tahoma", 8.5f, FontStyle.Bold);
    ((Control) this.ultraLabel2).Location = new Point(8, 24);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(152, 16 /*0x10*/);
    ((Control) this.ultraLabel2).TabIndex = 19;
    ((Control) this.ultraLabel2).Text = "Payee Address Selection ";
    ((AppearanceBase) appearance33).BackColor = Color.Transparent;
    ((AppearanceBase) appearance33).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance33).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance33).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance33;
    ((Control) this.ultraLabel4).Location = new Point(8, 48 /*0x30*/);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(152, 48 /*0x30*/);
    ((Control) this.ultraLabel4).TabIndex = 24;
    ((Control) this.ultraLabel4).Text = "The system will find the 'Default Address' for the specified entity. ";
    ((AppearanceBase) appearance34).BackColor = Color.Transparent;
    ((AppearanceBase) appearance34).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance34).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance34).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance34;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel7).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(80 /*0x50*/, 15);
    ((Control) this.ultraLabel7).TabIndex = 48 /*0x30*/;
    ((Control) this.ultraLabel7).Text = "CHECK MEMO";
    ((AppearanceBase) appearance35).BackColor = Color.White;
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance35).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckMemo).Appearance = (AppearanceBase) appearance35;
    ((Control) this.textCheckMemo).BackColor = Color.White;
    ((Control) this.textCheckMemo).Location = new Point(8, 176 /*0xB0*/);
    ((TextEditorControlBase) this.textCheckMemo).MaxLength = 100;
    this.textCheckMemo.MGAStyle = MGAStyles.Blue;
    this.textCheckMemo.Multiline = true;
    ((Control) this.textCheckMemo).Name = "textCheckMemo";
    ((Control) this.textCheckMemo).Size = new Size(168, 48 /*0x30*/);
    ((Control) this.textCheckMemo).TabIndex = 49;
    ((UltraControlBase) this.textCheckMemo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckMemo).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(690, 696);
    this.ControlBox = false;
    this.Controls.Add((Control) this.textCheckMemo);
    this.Controls.Add((Control) this.ultraLabel7);
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.ultraLabel6);
    this.Controls.Add((Control) this.groupNewAddress);
    this.Controls.Add((Control) this.groupAlternateAddress);
    this.Controls.Add((Control) this.groupDefaultAddress);
    this.Controls.Add((Control) this.optDefault);
    this.Controls.Add((Control) this.panelHidden);
    this.Controls.Add((Control) this.optSelect);
    this.Controls.Add((Control) this.optNew);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panel2);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formPayeeAddressSelection);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Payee Address Selection";
    this.Load += new EventHandler(this.formPayeeAddressSelection_Load);
    ((ISupportInitialize) this.gridAddresses).EndInit();
    this.dsPayeeAddressSelections1.EndInit();
    ((ISupportInitialize) this.txtAddressName).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    this.panelHidden.ResumeLayout(false);
    this.panelHidden.PerformLayout();
    ((ISupportInitialize) this.txtHiddenPayeeZipPlus).EndInit();
    ((ISupportInitialize) this.txtHiddenPayeeZipCode).EndInit();
    ((ISupportInitialize) this.txtHiddenPayeeAddress1).EndInit();
    ((ISupportInitialize) this.txtHiddenPayeeAddress2).EndInit();
    ((ISupportInitialize) this.txtHiddenPayeeCity).EndInit();
    ((ISupportInitialize) this.txtHiddenPayeeState).EndInit();
    ((ISupportInitialize) this.txtHiddenPayeeName).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.groupDefaultAddress).EndInit();
    ((Control) this.groupDefaultAddress).ResumeLayout(false);
    ((ISupportInitialize) this.groupAlternateAddress).EndInit();
    ((Control) this.groupAlternateAddress).ResumeLayout(false);
    ((ISupportInitialize) this.groupNewAddress).EndInit();
    ((Control) this.groupNewAddress).ResumeLayout(false);
    ((Control) this.groupNewAddress).PerformLayout();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.textCheckMemo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private Guid EntityGUID => this.entityGUID;

  public string PayeeName => this.payeeName;

  public string Address1 => this.address1;

  public string Address2 => this.address2;

  public string City => this.city;

  public string State => this.state;

  public string ZipCode => this.zipCode;

  public string ZipPlus => this.zipPlus;

  public Utility.EntityType PayeeType => this.payeeType;

  public string CheckMemo => this.checkMemo;

  private void LoadLocationChoices()
  {
    this.Cursor = Cursors.WaitCursor;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.payeeType = Utility.GetEntityType(this.entityGUID);
    this.GetDefaultEntityAddress();
    this.DefaultAddressString = this.lblDefaultAddress.Text;
    if (this.lblDefaultAddress.Text == string.Empty || this.lblDefaultAddress.Text == "<ERROR>")
    {
      this.optDefault.Checked = false;
      this.optDefault.Enabled = false;
    }
    else
    {
      this.optDefault.Enabled = true;
      this.optDefault.Checked = true;
    }
    this.daAddressSelections.SelectCommand.Parameters["@ENTITYGUID"].Value = (object) this.EntityGUID;
    switch (this.payeeType)
    {
      case Utility.EntityType.Company:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "C";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.CompanyLocation:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "CLO";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.CompanyLine:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "CLI";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.ProducerLocation:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "PL";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.Insured:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "INS";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.Intermediary:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "IN";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.CompanyGroup:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "CG";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
      case Utility.EntityType.Producer:
        this.daAddressSelections.SelectCommand.Parameters["@PAYEETYPE"].Value = (object) "P";
        this.daAddressSelections.Fill((DataTable) this.dsPayeeAddressSelections1.spFin_GetPayeeAddressSelections);
        break;
    }
    this.SetFirstRowSelected();
    this.SetControlPropertyBindings();
    this.optDefault.Checked = true;
    this.Cursor = Cursors.Default;
  }

  private void SetFirstRowSelected()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridAddresses).Rows).Count == 0)
    {
      this.optSelect.Enabled = false;
      ((Control) this.gridAddresses).Enabled = false;
    }
    else
    {
      int num1 = 0;
      int num2 = 0;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridAddresses).Rows)
      {
        if (!row.Hidden)
        {
          ++num1;
          num2 = row.Index;
          if (num1 == 1)
            row.Cells["Select"].Value = (object) true;
        }
      }
      if (num1 != 1)
        return;
      ((UltraGridBase) this.gridAddresses).Rows[num2].Cells["Select"].Activation = (Activation) 3;
    }
  }

  private void SetControlPropertyBindings()
  {
    ((Control) this.groupDefaultAddress).DataBindings.Add("Enabled", (object) this.optDefault, "Checked");
    ((Control) this.groupNewAddress).DataBindings.Add("Enabled", (object) this.optNew, "Checked");
    ((Control) this.groupAlternateAddress).DataBindings.Add("Enabled", (object) this.optSelect, "Checked");
    ((Control) this.ZipCodeResolver1).DataBindings.Add("BackColor", (object) this.groupNewAddress.ContentAreaAppearance, "BackColor");
  }

  private void ClearNewAddressPanel()
  {
    foreach (Control control in (ArrangedElementCollection) ((Control) this.groupNewAddress).Controls)
    {
      if (control is TextBox)
        control.Text = "";
    }
  }

  private void gridAddresses_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    e.Row.Hidden = string.Compare(this.DefaultAddressString, e.Row.Cells["Alternate Address"].Text) == 0;
  }

  private void SetProperties()
  {
    this.checkMemo = ((Control) this.textCheckMemo).Text;
    if (this.optDefault.Checked)
    {
      this.payeeName = ((Control) this.txtHiddenPayeeName).Text;
      this.address1 = ((Control) this.txtHiddenPayeeAddress1).Text;
      this.address2 = ((Control) this.txtHiddenPayeeAddress2).Text;
      this.city = ((Control) this.txtHiddenPayeeCity).Text;
      this.state = ((Control) this.txtHiddenPayeeState).Text;
      this.zipCode = ((Control) this.txtHiddenPayeeZipCode).Text;
      this.zipPlus = ((Control) this.txtHiddenPayeeZipPlus).Text;
      this.checkMemo = ((Control) this.textCheckMemo).Text;
    }
    else if (this.optSelect.Checked)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridAddresses).Rows)
      {
        if ((bool) row.Cells["Select"].Value)
        {
          this.payeeName = row.Cells["Name"].Value.ToString();
          this.address1 = row.Cells["Address1"].Value.ToString();
          this.address2 = row.Cells["Address2"].Value.ToString();
          this.city = row.Cells["City"].Value.ToString();
          this.state = row.Cells["State"].Value.ToString();
          this.zipCode = row.Cells["ZipCode"].Value.ToString();
          this.zipPlus = row.Cells["ZipPlus"].Value.ToString();
          this.checkMemo = ((Control) this.textCheckMemo).Text.ToString();
        }
      }
    }
    else
    {
      if (!this.optNew.Checked)
        return;
      this.payeeName = ((Control) this.txtAddressName).Text;
      this.address1 = this.ZipCodeResolver1.Address1;
      this.address2 = this.ZipCodeResolver1.Address2;
      this.city = this.ZipCodeResolver1.City;
      this.state = this.ZipCodeResolver1.State;
      this.zipCode = this.ZipCodeResolver1.ZipCode;
      this.zipPlus = this.ZipCodeResolver1.ZipCodeExtension;
      this.checkMemo = ((Control) this.textCheckMemo).Text.ToString();
    }
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.SetProperties();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private bool ValidateForm()
  {
    if (this.optNew.Checked)
    {
      if (!(((Control) this.txtAddressName).Text == string.Empty))
        return ((ContainerControl) this.ZipCodeResolver1).Validate();
      int num = (int) MessageBox.Show("You must enter a payee name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.optDefault.Checked && this.lblDefaultAddress.Text == string.Empty)
    {
      int num = (int) MessageBox.Show("You must select a valid address to continue!", "No Address Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.optSelect.Checked)
    {
      bool flag = false;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridAddresses).Rows)
      {
        if (Convert.ToBoolean(row.Cells["select"].Value))
        {
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        int num = (int) MessageBox.Show("You must select a valid address to continue!", "No Address Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    if (!this.showWarning)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
    else
    {
      if (MessageBox.Show("This will stop the current action and clear any data saved to this point, are you sure you wish to cancel?", "Cancel Current Action?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }

  private void GetDefaultEntityAddress()
  {
    using (SqlCommand sqlCommand = new SqlCommand("spFin_GetPayeeDefaultAddress", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      try
      {
        sqlCommand.Connection.Open();
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@ENTITYGUID", (object) this.EntityGUID);
        SqlDataReader sqlDataReader1 = (SqlDataReader) null;
        SqlDataReader sqlDataReader2 = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        if (sqlDataReader2.Read())
        {
          this.lblDefaultAddress.Text = sqlDataReader2["FULLADDRESS"].ToString();
          ((Control) this.txtHiddenPayeeName).Text = sqlDataReader2["NAME"].ToString();
          ((Control) this.txtHiddenPayeeAddress1).Text = sqlDataReader2["ADDRESS1"].ToString();
          ((Control) this.txtHiddenPayeeAddress2).Text = sqlDataReader2["ADDRESS2"].ToString();
          ((Control) this.txtHiddenPayeeCity).Text = sqlDataReader2["CITY"].ToString();
          ((Control) this.txtHiddenPayeeState).Text = sqlDataReader2["STATE"].ToString();
          ((Control) this.txtHiddenPayeeZipCode).Text = sqlDataReader2["ZIPCODE"].ToString();
          ((Control) this.txtHiddenPayeeZipPlus).Text = sqlDataReader2["ZIPPLUS"].ToString();
          sqlDataReader2.Close();
        }
        else
          this.lblDefaultAddress.Text = string.Empty;
        sqlDataReader1 = (SqlDataReader) null;
      }
      catch (SqlException ex)
      {
        int num = (int) MessageBox.Show("An error has occurred while trying to retrieve the default address for the specified entity.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }
  }

  private void SetEntityType() => this.payeeType = Utility.GetEntityType(this.entityGUID);

  private void OptionSelectionClicked(object sender, EventArgs e)
  {
    this.optDefault.Checked = sender == this.optDefault;
    this.optSelect.Checked = sender == this.optSelect;
    this.optNew.Checked = sender == this.optNew;
    if (sender == this.optSelect)
    {
      this.ClearNewAddressPanel();
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridAddresses).Rows).Count != 1)
        return;
      ((UltraGridBase) this.gridAddresses).Rows[0].Cells["Select"].Value = (object) true;
    }
    else
    {
      if (sender != this.optNew)
        return;
      this.ClearNewAddressPanel();
    }
  }

  private void SetAddressResolverConnectionProperties()
  {
  }

  private void gridAddresses_Click(object sender, EventArgs e)
  {
    if (!(((ControlUIElementBase) ((UltraGridBase) this.gridAddresses).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell)) is UltraGridCell context) || ((KeyedSubObjectBase) context.Column).Key.ToLower() != "select")
      return;
    int index = context.Row.Index;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridAddresses).Rows)
    {
      if (row.Index != index)
        row.Cells["select"].Value = (object) false;
    }
  }

  private void formPayeeAddressSelection_Load(object sender, EventArgs e)
  {
    this.optNew.Enabled = SecurityManager.Instance.AssertPermission("{DF7A724E-33F9-445B-901C-CF77C8251F3F}");
  }
}
