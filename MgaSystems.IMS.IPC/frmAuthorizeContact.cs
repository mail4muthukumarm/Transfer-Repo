// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmAuthorizeContact
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
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class frmAuthorizeContact : Form
{
  private IContainer components;
  private SqlDataAdapter da;
  private Label Label1;
  private Label Label2;
  private MGATextBox txtPassword;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cn;
  protected UltraGroupBox groupBox;
  private dsAuthorizeContact ds;
  private ErrorProvider err;
  private MGACheckBox chkAdmin;
  protected UltraDropDown ddPrograms;
  protected Guid _contactGuid;
  private readonly bool _hidePassword;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASimpleComboBox ComboBox1
  {
    get => this._ComboBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ComboBox1_ValueChanged);
      MGASimpleComboBox comboBox1_1 = this._ComboBox1;
      if (comboBox1_1 != null)
        comboBox1_1.ValueChanged -= eventHandler;
      this._ComboBox1 = value;
      MGASimpleComboBox comboBox1_2 = this._ComboBox1;
      if (comboBox1_2 == null)
        return;
      comboBox1_2.ValueChanged += eventHandler;
    }
  }

  protected virtual UltraGrid grid
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
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingCancel -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickedDelete -= eventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingCancel += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickedDelete += eventHandler2;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("grdSecurityGroups")]
  protected virtual UltraGrid grdSecurityGroups { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAuthorizeContact));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstExternalContactSecurityPermissions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SecurityCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Add");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstExternalContactPrograms", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProgramCode");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProgramName");
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblContactsExternalAuthorization", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProgramCode", -1, (object) "ddPrograms");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Password");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("IsAdmin");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.groupBox = new UltraGroupBox();
    this.chkAdmin = new MGACheckBox();
    this.txtPassword = new MGATextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    this.grdSecurityGroups = new UltraGrid();
    this.ds = new dsAuthorizeContact();
    this.ddPrograms = new UltraDropDown();
    this.ComboBox1 = new MGASimpleComboBox();
    this.grid = new UltraGrid();
    ((ISupportInitialize) this.groupBox).BeginInit();
    ((Control) this.groupBox).SuspendLayout();
    ((ISupportInitialize) this.chkAdmin).BeginInit();
    ((ISupportInitialize) this.txtPassword).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.grdSecurityGroups).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddPrograms).BeginInit();
    ((ISupportInitialize) this.ComboBox1).BeginInit();
    ((ISupportInitialize) this.grid).BeginInit();
    this.SuspendLayout();
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblContactsExternalAuthorization", new DataColumnMapping[4]
      {
        new DataColumnMapping("ProgramCode", "ProgramCode"),
        new DataColumnMapping("ContactGuid", "ContactGuid"),
        new DataColumnMapping("Password", "Password"),
        new DataColumnMapping("IsAdmin", "IsAdmin")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblContactsExternalAuthorization\r\nWHERE        (ContactGuid = @Original_ContactGuid) AND (ProgramCode = @Original_ProgramCode)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProgramCode", SqlDbType.Char, 5, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProgramCode", DataRowVersion.Original, (object) null)
    });
    this.cn.ConnectionString = "Data Source=mgasystems2012;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@ProgramCode", SqlDbType.VarChar, 5, "ProgramCode"),
      new SqlParameter("@ContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ContactGuid"),
      new SqlParameter("@Password", SqlDbType.VarChar, 20, "Password"),
      new SqlParameter("@IsAdmin", SqlDbType.Bit, 1, "IsAdmin")
    });
    this.SqlSelectCommand1.CommandText = "SELECT ProgramCode, ContactGuid, Password, IsAdmin FROM tblContactsExternalAuthorization WHERE (ContactGuid = @ContactGuid)";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ContactGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@ProgramCode", SqlDbType.Char, 5, "ProgramCode"),
      new SqlParameter("@ContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ContactGuid"),
      new SqlParameter("@Password", SqlDbType.VarChar, 50, "Password"),
      new SqlParameter("@IsAdmin", SqlDbType.Bit, 1, "IsAdmin"),
      new SqlParameter("@Original_ContactGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ContactGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProgramCode", SqlDbType.Char, 5, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProgramCode", DataRowVersion.Original, (object) null)
    });
    appearance1.BackColor = Color.FromArgb(246, 250, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupBox.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupBox).Controls.Add((Control) this.chkAdmin);
    ((Control) this.groupBox).Controls.Add((Control) this.txtPassword);
    ((Control) this.groupBox).Controls.Add((Control) this.Label2);
    ((Control) this.groupBox).Controls.Add((Control) this.ComboBox1);
    ((Control) this.groupBox).Controls.Add((Control) this.Label1);
    ((Control) this.groupBox).Enabled = false;
    ((Control) this.groupBox).Location = new Point(11, 280);
    ((Control) this.groupBox).Name = "groupBox";
    ((Control) this.groupBox).Size = new Size(627, 107);
    ((Control) this.groupBox).TabIndex = 1;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAdmin).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkAdmin).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAdmin).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAdmin).Checked = true;
    ((UltraToggleEditorBase) this.chkAdmin).CheckState = CheckState.Checked;
    ((Control) this.chkAdmin).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblContactsExternalAuthorization.IsAdmin", true));
    ((UltraToggleEditorBase) this.chkAdmin).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAdmin).Location = new Point(325, 58);
    ((Control) this.chkAdmin).Name = "chkAdmin";
    ((Control) this.chkAdmin).Size = new Size(168, 25);
    ((Control) this.chkAdmin).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkAdmin).Text = "Administrator";
    ((UltraControlBase) this.chkAdmin).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAdmin).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPassword).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtPassword).BackColor = Color.White;
    ((Control) this.txtPassword).DataBindings.Add(new Binding("Text", (object) this.ds, "tblContactsExternalAuthorization.Password", true));
    ((Control) this.txtPassword).Location = new Point(157, 58);
    this.txtPassword.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPassword).Name = "txtPassword";
    ((Control) this.txtPassword).Size = new Size(140, 24);
    ((Control) this.txtPassword).TabIndex = 3;
    ((UltraControlBase) this.txtPassword).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPassword).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(11, 57);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(140, 28);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Password:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(11, 28);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(140, 28);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "External Program:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(482, 396);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(156, 49);
    this.dbSave.TabIndex = 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.grdSecurityGroups).DataSource = (object) this.ds.lstExternalContactSecurityPermissions;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 178;
    ultraGridColumn2.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 477;
    ultraGridColumn3.CellClickAction = (CellClickAction) 1;
    ultraGridColumn3.CellDisplayStyle = (CellDisplayStyle) 3;
    ultraGridColumn3.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 148;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grdSecurityGroups).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.grdSecurityGroups).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.grdSecurityGroups).Location = new Point(12, 148);
    ((Control) this.grdSecurityGroups).Name = "grdSecurityGroups";
    ((Control) this.grdSecurityGroups).Size = new Size(627, 126);
    ((Control) this.grdSecurityGroups).TabIndex = 4;
    ((UltraControlBase) this.grdSecurityGroups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdSecurityGroups).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAuthorizeContact";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddPrograms).DataSource = (object) this.ds.lstExternalContactPrograms;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 119;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 119;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ddPrograms).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddPrograms).DisplayMember = "ProgramName";
    ((Control) this.ddPrograms).Location = new Point(78, 387);
    ((Control) this.ddPrograms).Name = "ddPrograms";
    ((Control) this.ddPrograms).Size = new Size(336, 58);
    ((Control) this.ddPrograms).TabIndex = 3;
    ((UltraDropDownBase) this.ddPrograms).ValueMember = "ProgramCode";
    ((Control) this.ddPrograms).Visible = false;
    this.ComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.ComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblContactsExternalAuthorization.ProgramCode", true));
    ((UltraGridBase) this.ComboBox1).DataSource = (object) this.ds.lstExternalContactPrograms;
    ((UltraDropDownBase) this.ComboBox1).DisplayMember = "ProgramName";
    this.ComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.ComboBox1).Location = new Point(157, 29);
    this.ComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.ComboBox1).Name = "ComboBox1";
    ((Control) this.ComboBox1).Size = new Size(414, 25);
    ((Control) this.ComboBox1).TabIndex = 1;
    ((UltraControlBase) this.ComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ComboBox1).ValueMember = "ProgramCode";
    ((UltraGridBase) this.grid).DataSource = (object) this.ds.tblContactsExternalAuthorization;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grid).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Program Code";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 239;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 216;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Width = 246;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Admin";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn9.Width = 140;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance13.BackColor = Color.LightSteelBlue;
    appearance13.FontData.SizeInPoints = 10f;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.grid).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance17.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance17;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.Transparent;
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grid).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.grid).Location = new Point(11, 10);
    ((Control) this.grid).Name = "grid";
    ((Control) this.grid).Size = new Size(627, 126);
    ((Control) this.grid).TabIndex = 0;
    ((UltraControlBase) this.grid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grid).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(7, 17);
    this.BackColor = Color.White;
    this.ClientSize = new Size(657, 453);
    this.Controls.Add((Control) this.grdSecurityGroups);
    this.Controls.Add((Control) this.ddPrograms);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.groupBox);
    this.Controls.Add((Control) this.grid);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAuthorizeContact);
    this.Text = "Authorize Contacts";
    ((ISupportInitialize) this.groupBox).EndInit();
    ((Control) this.groupBox).ResumeLayout(false);
    ((Control) this.groupBox).PerformLayout();
    ((ISupportInitialize) this.chkAdmin).EndInit();
    ((ISupportInitialize) this.txtPassword).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.grdSecurityGroups).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddPrograms).EndInit();
    ((ISupportInitialize) this.ComboBox1).EndInit();
    ((ISupportInitialize) this.grid).EndInit();
    this.ResumeLayout(false);
  }

  public frmAuthorizeContact()
  {
    this.Load += new EventHandler(this.frmAuthorizeContact_Load);
    this._hidePassword = false;
    this.InitializeComponent();
  }

  public frmAuthorizeContact(Guid contactGuid)
    : this()
  {
    this._contactGuid = contactGuid;
    this._hidePassword = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("frmAuthorizeContact_HidePassword");
    if (!this._hidePassword)
      return;
    UltraTextEditor ultraTextEditor = new UltraTextEditor();
    ultraTextEditor.PasswordChar = '*';
    this.txtPassword.PasswordChar = '*';
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Columns["Password"].EditorComponent = (Component) ultraTextEditor;
  }

  private BindingManagerBase bmb
  {
    get
    {
      return this.BindingContext[(object) this.ds, this.ds.tblContactsExternalAuthorization.TableName];
    }
  }

  private void frmAuthorizeContact_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "lstExternalContactPrograms",
      "lstExternalContactSecurityPermissions"
    }, CommandType.Text, "SELECT ProgramCode, ProgramName FROM lstExternalContactPrograms ORDER BY ProgramName; SELECT SecurityCode, Description FROM lstExternalContactSecurityPermissions ORDER BY Description");
    this.da.SelectCommand.Parameters["@ContactGuid"].Value = (object) this._contactGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblContactsExternalAuthorization);
    this.SetSaveState();
  }

  private void SetSaveState()
  {
    this.dbSave.UIState = this.ds.tblContactsExternalAuthorization.Count <= 0 ? UIState.NoRecordsNotEditing : UIState.HasRecordsNotEditing;
    ((Control) this.grdSecurityGroups).Enabled = false;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsAuthorizeContact.tblContactsExternalAuthorizationRow row = this.ds.tblContactsExternalAuthorization.NewtblContactsExternalAuthorizationRow();
    row.ContactGuid = this._contactGuid;
    this.ds.tblContactsExternalAuthorization.AddtblContactsExternalAuthorizationRow(row);
    this.bmb.Position = this.ds.tblContactsExternalAuthorization.Rows.Count - 1;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e) => this.SetSaveState();

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblContactsExternalAuthorization.RejectChanges();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this contact's authorization?", "Delete Authorization?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.ds.tblContactsExternalAuthorization[this.bmb.Position].Delete();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblContactsExternalAuthorization);
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e) => this.SetSaveState();

  private void InitSecurityGroupsTable(string programCode)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spGetContactSecurityRecords", new object[4]
    {
      (object) "@ContactGuid",
      (object) this._contactGuid,
      (object) "@ProgramCode",
      (object) programCode
    });
    this.ds.lstExternalContactSecurityPermissions.Clear();
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        dsAuthorizeContact.lstExternalContactSecurityPermissionsRow row2 = this.ds.lstExternalContactSecurityPermissions.NewlstExternalContactSecurityPermissionsRow();
        row2.SecurityCode = row1.Field<string>("SecurityCode");
        row2.Description = row1.Field<string>("Description");
        row2.Add = row1.Field<bool>("Add");
        this.ds.lstExternalContactSecurityPermissions.Rows.Add((DataRow) row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this.bmb.EndCurrentEdit();
    if (this.ValidForm())
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblContactsExternalAuthorization);
      foreach (UltraGridRow row in ((UltraGridBase) this.grdSecurityGroups).Rows)
      {
        bool boolean = Conversions.ToBoolean(row.GetCellValue("Add"));
        DefaultDatabase.ExecuteNonQuery("spUpdateContactSecurityRecord", new object[8]
        {
          (object) "@ContactGuid",
          (object) this._contactGuid,
          (object) "@ProgramCode",
          ((UltraGridBase) this.grid).Rows[this.bmb.Position].GetCellValue("ProgramCode"),
          (object) "@SecurityCode",
          row.GetCellValue("SecurityCode"),
          (object) "@Include",
          (object) boolean
        });
      }
    }
    else
      e.Cancel = true;
  }

  protected bool ValidForm()
  {
    bool flag = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPassword).Text, string.Empty, false) == 0 || ((TextEditorControlBase) this.txtPassword).Text.Replace(" ", "").Length == 0)
    {
      this.err.SetError((Control) this.txtPassword, "Please enter a value");
      flag = false;
    }
    return flag;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.grid).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.grdSecurityGroups).Enabled = this.dbSave.UIState.Equals((object) UIState.Editing);
    ((Control) this.groupBox).Enabled = this.dbSave.UIState == UIState.Editing;
  }

  private void grid_AfterRowActivate(object sender, EventArgs e)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.grid).ActiveRow.Cells["ProgramCode"].Value);
    Database.MoveTo(RuntimeHelpers.GetObjectValue(objectValue), "ProgramCode", (DataTable) this.ds.tblContactsExternalAuthorization, this.bmb);
    if (MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.grid).ActiveRow.Cells["ProgramCode"].Value)))
      return;
    this.InitSecurityGroupsTable(Conversions.ToString(objectValue));
  }

  private void ComboBox1_ValueChanged(object sender, EventArgs e)
  {
    if (MGASystems.Data.Utility.IsNull(RuntimeHelpers.GetObjectValue(this.ComboBox1.Value)))
      return;
    this.InitSecurityGroupsTable(this.ComboBox1.Value.ToString());
  }
}
