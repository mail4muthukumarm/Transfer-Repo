// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmLiveView
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
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
namespace MGASystems.IMS.Forms.Users;

[SecureResource("{DE866387-0A83-4d8f-819E-098176722732}", "View Everyone Live View Information", "Controls the ability for a user to see all others Live View information.", "Users")]
[SecureResource("{2CEBA04E-09F1-4be1-8947-1E4833F4D582}", "View own Live View Information", "Controls the ability for a user to view own his/her Live View information.", "Users")]
[SecureResource("{8a4a85df-d47c-4854-8c75-d33ec88099b9}\r\n", "View Live View Information for everyone in their office location", "Controls the ability for a user to view Live View information for users in their his/ her own office.", "Users")]
public class frmLiveView : Form
{
  private IContainer components;
  internal const string CanSeeAllLiveView = "{DE866387-0A83-4d8f-819E-098176722732}";
  internal const string CanViewOwnInformation = "{2CEBA04E-09F1-4be1-8947-1E4833F4D582}";
  internal const string CanViewAllWithinOfficeLoc = "{8a4a85df-d47c-4854-8c75-d33ec88099b9}\r\n";

  public frmLiveView()
  {
    this.Load += new EventHandler(this.frmClearView_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("daUsers")]
  private virtual SqlDataAdapter daUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgViewLog")]
  internal virtual UltraGrid dgViewLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsLiveView ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpStart")]
  internal virtual MGADateTimePicker dtpStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpEnd")]
  internal virtual MGADateTimePicker dtpEnd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton rbActive
  {
    get => this._rbActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbActive_CheckedChanged);
      RadioButton rbActive1 = this._rbActive;
      if (rbActive1 != null)
        rbActive1.CheckedChanged -= eventHandler;
      this._rbActive = value;
      RadioButton rbActive2 = this._rbActive;
      if (rbActive2 == null)
        return;
      rbActive2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("rbInactive")]
  internal virtual RadioButton rbInactive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvUsers")]
  internal virtual DataView dvUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUsers")]
  protected virtual MGAComboBox cboUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblLog", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ActionDate");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Name_LastFirst");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("StatusID");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.dvUsers = new DataView();
    this.ds = new dsLiveView();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.dgViewLog = new UltraGrid();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.btnSearch = new MGAButton();
    this.dtpStart = new MGADateTimePicker();
    this.dtpEnd = new MGADateTimePicker();
    this.rbActive = new RadioButton();
    this.rbInactive = new RadioButton();
    this.cboUsers = new MGAComboBox();
    this.Label4 = new Label();
    this.dvUsers.BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgViewLog).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.dtpStart).BeginInit();
    ((ISupportInitialize) this.dtpEnd).BeginInit();
    ((ISupportInitialize) this.cboUsers).BeginInit();
    this.SuspendLayout();
    this.dvUsers.Table = (DataTable) this.ds.tblUsers;
    this.ds.DataSetName = "dsLiveView";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daUsers.SelectCommand = this.SqlSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spGetLiveViewUsers", new DataColumnMapping[6]
      {
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("LastName", "LastName"),
        new DataColumnMapping("UserName", "UserName"),
        new DataColumnMapping("Password", "Password"),
        new DataColumnMapping("OfficeGUID", "OfficeGUID"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("Name_LastFirst", "Name_LastFirst"),
        new DataColumnMapping("UserID", "UserID"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("OfficeGUID", "OfficeGUID")
      })
    });
    this.SqlSelectCommand1.CommandText = "dbo.spGetLiveViewUsers";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@USERGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.cnSQL.ConnectionString = "Data Source=192.168.7.69\\MGA;Initial Catalog=MGATEST;User ID=brecken_ridge";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.dgViewLog).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgViewLog).DataSource = (object) this.ds.tblLog;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 309;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Format = "MM/dd/yyy hh:mm:ss";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Date";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.dgViewLog).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgViewLog).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgViewLog).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgViewLog).Location = new Point(8, 114);
    ((Control) this.dgViewLog).Name = "dgViewLog";
    ((Control) this.dgViewLog).Size = new Size(456, 391);
    ((Control) this.dgViewLog).TabIndex = 7;
    ((UltraControlBase) this.dgViewLog).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgViewLog).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(56, 10);
    this.Label1.Name = "Label1";
    this.Label1.RightToLeft = RightToLeft.No;
    this.Label1.Size = new Size(72, 16 /*0x10*/);
    this.Label1.TabIndex = 8;
    this.Label1.Text = "Select User:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.Location = new Point(32 /*0x20*/, 66);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 9;
    this.Label2.Text = "Start Date:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.Location = new Point(34, 90);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label3.TabIndex = 12;
    this.Label3.Text = "End Date:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(424, 68);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 28;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpStart.Appearance = (AppearanceBase) appearance10;
    appearance11.AlphaLevel = (short) 14;
    appearance11.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance11.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance11.BackColorAlpha = (Alpha) 2;
    appearance11.BackGradientAlignment = (GradientAlignment) 4;
    appearance11.BackGradientStyle = (GradientStyle) 5;
    appearance11.BorderAlpha = (Alpha) 1;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    appearance11.ForeColor = Color.FromArgb(49, 85, 153);
    appearance11.ForegroundAlpha = (Alpha) 2;
    this.dtpStart.ButtonAppearance = (AppearanceBase) appearance11;
    ((Control) this.dtpStart).Location = new Point(136, 64 /*0x40*/);
    this.dtpStart.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpStart).Name = "dtpStart";
    ((Control) this.dtpStart).Size = new Size(104, 20);
    ((Control) this.dtpStart).TabIndex = 29;
    ((UltraControlBase) this.dtpStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpStart).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpEnd.Appearance = (AppearanceBase) appearance12;
    appearance13.AlphaLevel = (short) 14;
    appearance13.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance13.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance13.BackColorAlpha = (Alpha) 2;
    appearance13.BackGradientAlignment = (GradientAlignment) 4;
    appearance13.BackGradientStyle = (GradientStyle) 5;
    appearance13.BorderAlpha = (Alpha) 1;
    appearance13.BorderColor = Color.FromArgb(78, 122, 171);
    appearance13.ForeColor = Color.FromArgb(49, 85, 153);
    appearance13.ForegroundAlpha = (Alpha) 2;
    this.dtpEnd.ButtonAppearance = (AppearanceBase) appearance13;
    ((Control) this.dtpEnd).Location = new Point(136, 88);
    this.dtpEnd.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpEnd).Name = "dtpEnd";
    ((Control) this.dtpEnd).Size = new Size(104, 20);
    ((Control) this.dtpEnd).TabIndex = 30;
    ((UltraControlBase) this.dtpEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpEnd).UseOsThemes = (DefaultableBoolean) 2;
    this.rbActive.BackColor = Color.Transparent;
    this.rbActive.Checked = true;
    this.rbActive.Location = new Point(136, 39);
    this.rbActive.Name = "rbActive";
    this.rbActive.Size = new Size(72, 16 /*0x10*/);
    this.rbActive.TabIndex = 4;
    this.rbActive.TabStop = true;
    this.rbActive.Text = "Active";
    this.rbActive.UseVisualStyleBackColor = false;
    this.rbInactive.BackColor = Color.Transparent;
    this.rbInactive.Location = new Point(214, 35);
    this.rbInactive.Name = "rbInactive";
    this.rbInactive.Size = new Size(64 /*0x40*/, 24);
    this.rbInactive.TabIndex = 3;
    this.rbInactive.Text = "Inactive";
    this.rbInactive.UseVisualStyleBackColor = false;
    ((Control) this.cboUsers).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboUsers.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUsers).DataSource = (object) this.dvUsers;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboUsers.DisplayLayout.Appearance = (AppearanceBase) appearance14;
    this.cboUsers.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 481;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboUsers.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboUsers.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboUsers.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboUsers.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance15.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance15.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboUsers.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.White;
    this.cboUsers.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    this.cboUsers.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance17.ForeColor = Color.Black;
    this.cboUsers.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboUsers.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboUsers).DisplayMember = "Name_LastFirst";
    this.cboUsers.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUsers).DropDownWidth = 500;
    ((Control) this.cboUsers).Location = new Point(136, 8);
    this.cboUsers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUsers).Name = "cboUsers";
    ((Control) this.cboUsers).Size = new Size(328, 21);
    ((Control) this.cboUsers).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.cboUsers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUsers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUsers).ValueMember = "UserGUID";
    this.Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(13, 512 /*0x0200*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(206, 13);
    this.Label4.TabIndex = 33;
    this.Label4.Text = "Note: Results limited to first 1000 results.";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(472, 534);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.rbActive);
    this.Controls.Add((Control) this.rbInactive);
    this.Controls.Add((Control) this.cboUsers);
    this.Controls.Add((Control) this.dtpEnd);
    this.Controls.Add((Control) this.dtpStart);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dgViewLog);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmLiveView);
    this.Text = "IMS Live View";
    this.dvUsers.EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgViewLog).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.dtpStart).EndInit();
    ((ISupportInitialize) this.dtpEnd).EndInit();
    ((ISupportInitialize) this.cboUsers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmClearView_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    bool canSeeAllView = SecurityManager.Instance.AssertPermission("{DE866387-0A83-4d8f-819E-098176722732}");
    bool CanViewAllWithinOfficeLoc = SecurityManager.Instance.AssertPermission("{8a4a85df-d47c-4854-8c75-d33ec88099b9}\r\n");
    bool canViewOwnInfo = SecurityManager.Instance.AssertPermission("{2CEBA04E-09F1-4be1-8947-1E4833F4D582}");
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    this.ds.tblUsers.Clear();
    this.ds.tblLog.Clear();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daUsers, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    Guid userGuid = CurrentUser.Instance.UserGUID;
    this.LoadUserData(canSeeAllView, CanViewAllWithinOfficeLoc, canViewOwnInfo, userGuid);
    ((Control) this.dgViewLog).AllowDrop = false;
  }

  protected virtual void LoadUserData(
    bool canSeeAllView,
    bool CanViewAllWithinOfficeLoc,
    bool canViewOwnInfo,
    Guid tmpUserGuid)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.tblUsers.TableName
    }, "spGetLiveViewUsers", new object[8]
    {
      (object) "@USERGUID",
      (object) tmpUserGuid,
      (object) "@canSeeAllView",
      (object) canSeeAllView,
      (object) "@CanViewAllWithinOfficeLoc",
      (object) CanViewAllWithinOfficeLoc,
      (object) "@canViewOwnInfo",
      (object) canViewOwnInfo
    });
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboUsers.Text, string.Empty, false) == 0)
      return;
    this.ds.tblLog.Clear();
    Cursor.Current = Cursors.WaitCursor;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblLog"
    }, CommandType.Text, "SELECT TOP 1000 Action, ActionDate FROM tblLog WITH (NOLOCK)  WHERE (DATEDIFF(d, ActionDate, @dateStart) <= 0 )  AND (DATEDIFF(d, ActionDate, @dateEnd) >= 0 )  AND (UserID = @userID)ORDER BY ActionDate DESC ", new object[6]
    {
      (object) "@dateEnd",
      this.dtpEnd.Value,
      (object) "@dateStart",
      this.dtpStart.Value,
      (object) "@userID",
      (object) this.ds.tblUsers.FindByUserGUID((Guid) this.cboUsers.Value).UserID
    });
    Cursor.Current = Cursors.Default;
  }

  private void rbActive_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbActive.Checked)
      this.dvUsers.RowFilter = "StatusID = 1";
    else
      this.dvUsers.RowFilter = "StatusID = 2";
  }
}
