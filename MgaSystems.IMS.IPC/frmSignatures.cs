// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmSignatures
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class frmSignatures : Form
{
  private IContainer components;
  private readonly Guid _companyLineGuid;
  private readonly SqlConnection _cn;

  internal virtual LinkLabel lnkChangeSignature
  {
    get => this._lnkChangeSignature;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChangeSignature_LinkClicked);
      LinkLabel lnkChangeSignature1 = this._lnkChangeSignature;
      if (lnkChangeSignature1 != null)
        lnkChangeSignature1.LinkClicked -= clickedEventHandler;
      this._lnkChangeSignature = value;
      LinkLabel lnkChangeSignature2 = this._lnkChangeSignature;
      if (lnkChangeSignature2 == null)
        return;
      lnkChangeSignature2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("pbSignature")]
  internal virtual PictureBox pbSignature { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLastName")]
  internal virtual MGATextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFirstName")]
  internal virtual MGATextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tt")]
  internal virtual ToolTip tt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      QueryRowCountHandler queryRowCountHandler = new QueryRowCountHandler(this.DbSaveUI1_QueryRowCount);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.DbSaveUI1_ClickingCancel);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.QueryRowCount -= queryRowCountHandler;
        dbSaveUi1_1.ClickingNew -= cancelEventHandler1;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler2;
        dbSaveUi1_1.ClickingEdit -= cancelEventHandler3;
        dbSaveUi1_1.ClickingCancel -= cancelEventHandler4;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler5;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.QueryRowCount += queryRowCountHandler;
      dbSaveUi1_2.ClickingNew += cancelEventHandler1;
      dbSaveUi1_2.ClickingSave += cancelEventHandler2;
      dbSaveUi1_2.ClickingEdit += cancelEventHandler3;
      dbSaveUi1_2.ClickingCancel += cancelEventHandler4;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("da")]
  internal virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLineSignatures ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daTypes")]
  internal virtual SqlDataAdapter daTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gb")]
  internal virtual UltraGroupBox gb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbTypes")]
  internal virtual MGASimpleComboBox cmbTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid grid
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

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraDropDown1")]
  internal virtual UltraDropDown UltraDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSignatures));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLineSignatures", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SignatureID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SignatureTypeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Signature");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstCompanyLineSignatureTypes", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SignatureTypeID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Description");
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
    this.gb = new UltraGroupBox();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.pbSignature = new PictureBox();
    this.cmbTypes = new MGASimpleComboBox();
    this.ds = new dsCompanyLineSignatures();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.lnkChangeSignature = new LinkLabel();
    this.txtLastName = new MGATextBox();
    this.txtFirstName = new MGATextBox();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.tt = new ToolTip(this.components);
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daTypes = new SqlDataAdapter();
    this.err = new ErrorProvider(this.components);
    this.grid = new UltraGrid();
    this.UltraDropDown1 = new UltraDropDown();
    ((ISupportInitialize) this.gb).BeginInit();
    ((Control) this.gb).SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.pbSignature).BeginInit();
    ((ISupportInitialize) this.cmbTypes).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtLastName).BeginInit();
    ((ISupportInitialize) this.txtFirstName).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.grid).BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    this.SuspendLayout();
    ((Control) this.gb).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.gb.BackColorInternal = Color.FromArgb(246, 250, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gb.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.gb).Controls.Add((Control) this.MgaGroupBox1);
    ((Control) this.gb).Controls.Add((Control) this.cmbTypes);
    ((Control) this.gb).Controls.Add((Control) this.Label2);
    ((Control) this.gb).Controls.Add((Control) this.Label1);
    ((Control) this.gb).Controls.Add((Control) this.lnkChangeSignature);
    ((Control) this.gb).Controls.Add((Control) this.txtLastName);
    ((Control) this.gb).Controls.Add((Control) this.txtFirstName);
    ((Control) this.gb).Controls.Add((Control) this.Label7);
    ((Control) this.gb).Controls.Add((Control) this.Label6);
    ((Control) this.gb).Enabled = false;
    appearance2.ForeColor = Color.Navy;
    this.gb.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.gb).Location = new Point(8, 200);
    ((Control) this.gb).Name = "gb";
    ((Control) this.gb).Size = new Size(336, 208 /*0xD0*/);
    ((Control) this.gb).TabIndex = 0;
    this.gb.Text = "Signature";
    appearance3.BackColor = Color.Transparent;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.pbSignature);
    appearance4.AlphaLevel = (short) 230;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.White;
    appearance4.ForegroundAlpha = (Alpha) 2;
    appearance4.ImageAlpha = (Alpha) 2;
    appearance4.ImageBackground = (Image) componentResourceManager.GetObject("Appearance3.ImageBackground");
    appearance4.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaGroupBox1).Location = new Point(75, 123);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size((int) byte.MaxValue, 79);
    ((Control) this.MgaGroupBox1).TabIndex = 25;
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.pbSignature.BackColor = Color.Transparent;
    this.pbSignature.Dock = DockStyle.Fill;
    this.pbSignature.Location = new Point(2, 2);
    this.pbSignature.Name = "pbSignature";
    this.pbSignature.Size = new Size(251, 75);
    this.pbSignature.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pbSignature.TabIndex = 19;
    this.pbSignature.TabStop = false;
    this.cmbTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cmbTypes).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineSignatures.SignatureTypeID", true));
    ((UltraGridBase) this.cmbTypes).DataSource = (object) this.ds.lstCompanyLineSignatureTypes;
    ((UltraDropDownBase) this.cmbTypes).DisplayMember = "Description";
    this.cmbTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbTypes).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.cmbTypes).Location = new Point(72, 72);
    this.cmbTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbTypes).Name = "cmbTypes";
    ((Control) this.cmbTypes).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cmbTypes).TabIndex = 2;
    ((UltraControlBase) this.cmbTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbTypes).ValueMember = "SignatureTypeID";
    this.ds.DataSetName = "dsCompanyLineSignatures";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 72);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 24);
    this.Label2.TabIndex = 24;
    this.Label2.Text = "Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 96 /*0x60*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 24);
    this.Label1.TabIndex = 21;
    this.Label1.Text = "Signature:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkChangeSignature.Location = new Point(72, 96 /*0x60*/);
    this.lnkChangeSignature.Name = "lnkChangeSignature";
    this.lnkChangeSignature.Size = new Size(88, 24);
    this.lnkChangeSignature.TabIndex = 4;
    this.lnkChangeSignature.TabStop = true;
    this.lnkChangeSignature.Text = "Select Image...";
    this.lnkChangeSignature.TextAlign = ContentAlignment.MiddleLeft;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLastName).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtLastName).BackColor = Color.White;
    ((Control) this.txtLastName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyLineSignatures.LastName", true));
    ((Control) this.txtLastName).Location = new Point(72, 48 /*0x30*/);
    this.txtLastName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLastName).Name = "txtLastName";
    ((Control) this.txtLastName).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.txtLastName).TabIndex = 1;
    ((UltraControlBase) this.txtLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLastName).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirstName).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtFirstName).BackColor = Color.White;
    ((Control) this.txtFirstName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyLineSignatures.FirstName", true));
    ((Control) this.txtFirstName).Location = new Point(72, 24);
    this.txtFirstName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFirstName).Name = "txtFirstName";
    ((Control) this.txtFirstName).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.txtFirstName).TabIndex = 0;
    ((UltraControlBase) this.txtFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirstName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(8, 48 /*0x30*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(64 /*0x40*/, 24);
    this.Label7.TabIndex = 16 /*0x10*/;
    this.Label7.Text = "Last Name:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(8, 24);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(64 /*0x40*/, 24);
    this.Label6.TabIndex = 15;
    this.Label6.Text = "First Name:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(352, 368);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(112 /*0x70*/, 40);
    this.DbSaveUI1.TabIndex = 5;
    this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineSignatures", new DataColumnMapping[6]
      {
        new DataColumnMapping("SignatureID", "SignatureID"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("LastName", "LastName"),
        new DataColumnMapping("SignatureTypeID", "SignatureTypeID"),
        new DataColumnMapping("Signature", "Signature")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@Original_SignatureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SignatureID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FirstName", SqlDbType.VarChar, (int) byte.MaxValue, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LastName", SqlDbType.VarChar, (int) byte.MaxValue, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LastName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SignatureTypeID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SignatureTypeID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, (int) byte.MaxValue, "FirstName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, (int) byte.MaxValue, "LastName"),
      new SqlParameter("@SignatureTypeID", SqlDbType.SmallInt, 2, "SignatureTypeID"),
      new SqlParameter("@Signature", SqlDbType.VarBinary, int.MaxValue, "Signature")
    });
    this.SqlSelectCommand1.CommandText = "SELECT SignatureID, CompanyLineGuid, FirstName, LastName, SignatureTypeID, Signature FROM tblCompanyLineSignatures WHERE CompanyLineGuid = @CompanyLineGuid";
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, (int) byte.MaxValue, "FirstName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, (int) byte.MaxValue, "LastName"),
      new SqlParameter("@SignatureTypeID", SqlDbType.SmallInt, 2, "SignatureTypeID"),
      new SqlParameter("@Signature", SqlDbType.VarBinary, int.MaxValue, "Signature"),
      new SqlParameter("@Original_SignatureID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SignatureID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_FirstName", SqlDbType.VarChar, (int) byte.MaxValue, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FirstName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LastName", SqlDbType.VarChar, (int) byte.MaxValue, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LastName", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SignatureTypeID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SignatureTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@SignatureID", SqlDbType.Int, 4, "SignatureID")
    });
    this.SqlSelectCommand2.CommandText = "SELECT SignatureTypeID, Description FROM lstCompanyLineSignatureTypes";
    this.daTypes.SelectCommand = this.SqlSelectCommand2;
    this.daTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstCompanyLineSignatureTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("SignatureTypeID", "SignatureTypeID"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.grid).DataSource = (object) this.ds.tblCompanyLineSignatures;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grid).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 50;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 221;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "First";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 231;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Last";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 231;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 69;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 113;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.SizeInPoints = 10f;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.grid).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grid).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grid).Location = new Point(8, 8);
    ((Control) this.grid).Name = "grid";
    ((Control) this.grid).Size = new Size(464, 184);
    ((Control) this.grid).TabIndex = 6;
    ((UltraControlBase) this.grid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grid).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.ds.lstCompanyLineSignatureTypes;
    appearance15.BackColor = SystemColors.Window;
    appearance15.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance16.BackColor = SystemColors.ActiveBorder;
    appearance16.BackColor2 = SystemColors.ControlDark;
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance16;
    appearance17.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance17;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance18.BackColor = SystemColors.ControlLightLight;
    appearance18.BackColor2 = SystemColors.Control;
    appearance18.BackGradientStyle = (GradientStyle) 3;
    appearance18.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.MaxRowScrollRegions = 1;
    appearance19.BackColor = SystemColors.Window;
    appearance19.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = SystemColors.Highlight;
    appearance20.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance21.BackColor = SystemColors.Window;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance21;
    appearance22.BorderColor = Color.Silver;
    appearance22.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellPadding = 0;
    appearance23.BackColor = SystemColors.Control;
    appearance23.BackColor2 = SystemColors.ControlDark;
    appearance23.BackGradientAlignment = (GradientAlignment) 1;
    appearance23.BackGradientStyle = (GradientStyle) 3;
    appearance23.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance25.BackColor = SystemColors.Window;
    appearance25.BorderColor = Color.Silver;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance26.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "Description";
    ((Control) this.UltraDropDown1).Location = new Point(0, 0);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(88, 16 /*0x10*/);
    ((Control) this.UltraDropDown1).TabIndex = 7;
    ((Control) this.UltraDropDown1).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "SignatureTypeID";
    ((Control) this.UltraDropDown1).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(474, 415);
    this.Controls.Add((Control) this.UltraDropDown1);
    this.Controls.Add((Control) this.grid);
    this.Controls.Add((Control) this.gb);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.MinimumSize = new Size(464, 368);
    this.Name = nameof (frmSignatures);
    this.Text = "Company Line Signatures";
    ((ISupportInitialize) this.gb).EndInit();
    ((Control) this.gb).ResumeLayout(false);
    ((Control) this.gb).PerformLayout();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.pbSignature).EndInit();
    ((ISupportInitialize) this.cmbTypes).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtLastName).EndInit();
    ((ISupportInitialize) this.txtFirstName).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.grid).EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    this.ResumeLayout(false);
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblCompanyLineSignatures.TableName];
  }

  public frmSignatures(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmSignatures_Load);
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
    this._cn = DefaultDatabase.CreateConnection();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }

  private void lnkChangeSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    try
    {
      openFileDialog.Multiselect = false;
      openFileDialog.CheckFileExists = true;
      openFileDialog.AddExtension = true;
      openFileDialog.Filter = "Bitmap (*.bmp)|*.bmp";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        Bitmap bitmap = new Bitmap(openFileDialog.FileName);
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = memoryStream1;
        ImageFormat bmp = ImageFormat.Bmp;
        bitmap.Save((Stream) memoryStream2, bmp);
        this.ds.tblCompanyLineSignatures[this.bmb.Position].Signature = memoryStream1.ToArray();
        this.ShowSignature();
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("This selected file is not a valid bitmap.", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      openFileDialog.Dispose();
    }
  }

  private void grid_AfterRowActivate(object sender, EventArgs e)
  {
    this.bmb.Position = ((UltraGridBase) this.grid).ActiveRow.Index;
  }

  private void frmSignatures_Load(object sender, EventArgs e)
  {
    SqlDataAdapter da = this.da;
    da.SelectCommand.Connection = this._cn;
    da.InsertCommand.Connection = this._cn;
    da.DeleteCommand.Connection = this._cn;
    da.UpdateCommand.Connection = this._cn;
    this.daTypes.SelectCommand.Connection = this._cn;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daTypes, (DataTable) this.ds.lstCompanyLineSignatureTypes);
    if (this.ds.lstCompanyLineSignatureTypes.Rows.Count == 0)
    {
      this.DbSaveUI1.Enabled = false;
      ((Control) this.grid).Enabled = false;
      ((Control) this.gb).Enabled = false;
    }
    else
    {
      this.da.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
      DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblCompanyLineSignatures);
      this.Text = $"{DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select companyline from tblCompanyLines where companylineguid = @CompanyLineGuid", new object[2]
      {
        (object) "@CompanyLineGuid",
        (object) this._companyLineGuid
      })} Signatures";
      this.bmb.PositionChanged += new EventHandler(this.BmbPositionChanged);
      if (this.ds.tblCompanyLineSignatures.Rows.Count <= 0)
        return;
      this.bmb.Position = 0;
      this.ShowSignature();
    }
  }

  private void BmbPositionChanged(object sender, EventArgs e) => this.ShowSignature();

  private void ShowSignature()
  {
    if (this.bmb.Position >= 0 && this.ds.tblCompanyLineSignatures.Rows.Count > 0 && !this.ds.tblCompanyLineSignatures[this.bmb.Position].IsSignatureNull())
      this.pbSignature.Image = Image.FromStream((Stream) new MemoryStream(this.ds.tblCompanyLineSignatures[this.bmb.Position].Signature));
    else
      this.pbSignature.Image = (Image) null;
  }

  private void ClearErrors()
  {
    this.err.SetError((Control) this.txtFirstName, string.Empty);
    this.err.SetError((Control) this.txtLastName, string.Empty);
  }

  private bool ValidateEntries()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtFirstName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtFirstName, "Please enter a first name.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtFirstName, string.Empty);
    if (((TextEditorControlBase) this.txtLastName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtLastName, "Please enter a last name.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtLastName, string.Empty);
    return flag;
  }

  private void DbSaveUI1_QueryRowCount(object sender, QueryRowCountEventArgs e)
  {
    e.RowCount = this.ds.tblCompanyLineSignatures.Rows.Count;
  }

  private void DbSaveUI1_ClickingNew(object sender, CancelEventArgs e)
  {
    ((Control) this.grid).Enabled = false;
    ((Control) this.gb).Enabled = true;
    dsCompanyLineSignatures.tblCompanyLineSignaturesRow row = this.ds.tblCompanyLineSignatures.NewtblCompanyLineSignaturesRow();
    row.CompanyLineGuid = this._companyLineGuid;
    row.SignatureTypeID = this.ds.lstCompanyLineSignatureTypes[0].SignatureTypeID;
    this.pbSignature.Image = (Image) null;
    this.ds.tblCompanyLineSignatures.AddtblCompanyLineSignaturesRow(row);
    this.bmb.Position = this.ds.tblCompanyLineSignatures.Rows.Count - 1;
  }

  private void DbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.ValidateEntries())
    {
      this.bmb.EndCurrentEdit();
      this.da.Update((DataTable) this.ds.tblCompanyLineSignatures);
      ((UltraGridBase) this.grid).Rows[this.bmb.Position].Activate();
      ((UltraGridBase) this.grid).Rows[this.bmb.Position].Selected = true;
      ((Control) this.grid).Enabled = true;
      ((Control) this.gb).Enabled = false;
    }
    else
      e.Cancel = true;
  }

  private void DbSaveUI1_ClickingEdit(object sender, CancelEventArgs e)
  {
    ((Control) this.grid).Enabled = false;
    ((Control) this.gb).Enabled = true;
  }

  private void DbSaveUI1_ClickingCancel(object sender, CancelEventArgs e)
  {
    ((Control) this.grid).Enabled = true;
    ((Control) this.gb).Enabled = false;
    this.ds.tblCompanyLineSignatures.RejectChanges();
    this.ShowSignature();
    this.ClearErrors();
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this signature?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.ds.tblCompanyLineSignatures.Rows[this.bmb.Position].Delete();
    this.da.Update((DataTable) this.ds.tblCompanyLineSignatures);
    if (this.ds.tblCompanyLineSignatures.Rows.Count <= 0)
      return;
    ((UltraGridBase) this.grid).Rows[this.bmb.Position].Activate();
    ((UltraGridBase) this.grid).Rows[this.bmb.Position].Selected = true;
    this.ShowSignature();
  }
}
