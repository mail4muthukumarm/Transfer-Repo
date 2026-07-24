// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmReportLog
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.Attributes;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Forms;

[SecureResource("{92DE09B8-0E0E-471A-95F3-8CCB5A88410A}", "Allows Users to View Report Log", "Controls whether or not users can view the report log.", "Reports")]
[SecureResource("{0A0252DA-808D-42F5-B390-55EEF66BEF46}", "Allows Users to View Report Log for any other user", "Controls whether or not users can view the report log for for other users.", "Reports")]
public sealed class frmReportLog : Form
{
  private IContainer components;
  private SqlDataAdapter da;
  private SqlCommand SqlSelectCommand1;
  private dsReportLog ds;
  private int _userID;
  private Guid _ReportGuid;
  private readonly DbConnection _cn;
  public const string CanViewLog = "{92DE09B8-0E0E-471A-95F3-8CCB5A88410A}";
  public const string CanViewLogForAllUsers = "{0A0252DA-808D-42F5-B390-55EEF66BEF46}";
  private frmGenericReportLauncher frmGenericReportLauncher;

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbReports")]
  internal virtual ComboBox cbReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbUsers")]
  internal virtual ComboBox cbUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("errorImage")]
  internal virtual ImageList errorImage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.UltraGrid1_InitializeRow);
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.UltraGrid1_MouseDoubleClick);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
      {
        ultraGrid1_1.InitializeRow -= initializeRowEventHandler;
        ultraGrid1_1.DoubleClickRow -= clickRowEventHandler;
      }
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.InitializeRow += initializeRowEventHandler;
      ultraGrid1_2.DoubleClickRow += clickRowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Log", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ReportGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Desc");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CriteriaXML");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("isError");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ActionDate");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Context");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Name_LastFirst");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ErrorMsg");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("imageColumn", 0);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportLog));
    this.da = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.Panel1 = new Panel();
    this.Label2 = new Label();
    this.cbReports = new ComboBox();
    this.ds = new dsReportLog();
    this.Label1 = new Label();
    this.cbUsers = new ComboBox();
    this.UltraGrid1 = new UltraGrid();
    this.errorImage = new ImageList(this.components);
    this.Panel1.SuspendLayout();
    this.ds.BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.SuspendLayout();
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[3]
    {
      new DataTableMapping("Table", "Users", new DataColumnMapping[2]
      {
        new DataColumnMapping("Name_LastFirst", "Name_LastFirst"),
        new DataColumnMapping("UserID", "UserID")
      }),
      new DataTableMapping("Table1", "Reports", new DataColumnMapping[2]
      {
        new DataColumnMapping("ReportGUID", "ReportGUID"),
        new DataColumnMapping("Context", "Context")
      }),
      new DataTableMapping("Table2", "Log", new DataColumnMapping[9]
      {
        new DataColumnMapping("ReportGUID", "ReportGUID"),
        new DataColumnMapping("Desc", "Desc"),
        new DataColumnMapping("CriteriaXML", "CriteriaXML"),
        new DataColumnMapping("isError", "isError"),
        new DataColumnMapping("Action", "Action"),
        new DataColumnMapping("ActionDate", "ActionDate"),
        new DataColumnMapping("Context", "Context"),
        new DataColumnMapping("Name_LastFirst", "Name_LastFirst"),
        new DataColumnMapping("UserID", "UserID")
      })
    });
    this.SqlSelectCommand1.CommandText = "spViewReportLog";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@userID", SqlDbType.Int, 4),
      new SqlParameter("@ReportGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.Panel1.BackColor = SystemColors.GradientInactiveCaption;
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Controls.Add((Control) this.cbReports);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.cbUsers);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(777, 32 /*0x20*/);
    this.Panel1.TabIndex = 1;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(245, 9);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(40, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Report";
    this.cbReports.DataSource = (object) this.ds;
    this.cbReports.DisplayMember = "Reports.Context";
    this.cbReports.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbReports.FormattingEnabled = true;
    this.cbReports.Location = new Point(291, 6);
    this.cbReports.Name = "cbReports";
    this.cbReports.Size = new Size(171, 21);
    this.cbReports.TabIndex = 2;
    this.cbReports.ValueMember = "Reports.ReportGUID";
    this.ds.DataSetName = "dsReportLog";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(29, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "User";
    this.cbUsers.DataSource = (object) this.ds;
    this.cbUsers.DisplayMember = "Users.Name_LastFirst";
    this.cbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbUsers.FormattingEnabled = true;
    this.cbUsers.Location = new Point(47, 6);
    this.cbUsers.Name = "cbUsers";
    this.cbUsers.Size = new Size(171, 21);
    this.cbUsers.TabIndex = 0;
    this.cbUsers.ValueMember = "Users.UserID";
    ((UltraGridBase) this.UltraGrid1).DataMember = "Log";
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 4;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 119;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 5;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 59;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 7;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 82;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.MaxWidth = 32 /*0x20*/;
    ultraGridColumn4.MinWidth = 32 /*0x20*/;
    ultraGridColumn4.Width = 32 /*0x20*/;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ultraGridColumn5.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 527;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ultraGridColumn6.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.MaxWidth = 84;
    ultraGridColumn6.MinWidth = 84;
    ultraGridColumn6.Width = 84;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 91;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ultraGridColumn8.CellClickAction = (CellClickAction) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.MaxWidth = 140;
    ultraGridColumn8.MinWidth = 140;
    ultraGridColumn8.Width = 140;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 6;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 185;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 84;
    ultraGridColumn11.CellActivation = (Activation) 3;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn11.CellClickAction = (CellClickAction) 2;
    ultraGridColumn11.DataType = typeof (Bitmap);
    ((HeaderBase) ultraGridColumn11.Header).Caption = "";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.MaxWidth = 24;
    ultraGridColumn11.MinWidth = 24;
    ultraGridColumn11.Width = 24;
    ultraGridBand.Columns.AddRange(new object[11]
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
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectTypeCell = (SelectType) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectTypeCol = (SelectType) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectTypeRow = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGrid1).Location = new Point(0, 32 /*0x20*/);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(777, 302);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.errorImage.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("errorImage.ImageStream");
    this.errorImage.TransparentColor = Color.White;
    this.errorImage.Images.SetKeyName(0, "errorImage");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(777, 334);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmReportLog);
    this.Text = "Reporting Log";
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.ds.EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ResumeLayout(false);
  }

  public frmReportLog()
  {
    this.Load += new EventHandler(this.frmTransactionLog_Load);
    this._userID = CurrentUser.Instance.UserID;
    this.InitializeComponent();
    this._cn = (DbConnection) DefaultDatabase.CreateConnection();
  }

  public frmReportLog(Guid ReportGuid)
    : this()
  {
    this._ReportGuid = ReportGuid;
  }

  public frmReportLog(Guid ReportGuid, frmGenericReportLauncher frmGenericReportLauncher)
    : this(ReportGuid)
  {
    this.frmGenericReportLauncher = frmGenericReportLauncher;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    if (this._cn != null)
      this._cn.Dispose();
    if (this.da != null)
      this.da.Dispose();
    base.Dispose(disposing);
  }

  private void frmTransactionLog_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.da, this._cn, (DbTransaction) null);
    this.da.SelectCommand.Parameters["@ReportGuid"].Value = (object) this._ReportGuid;
    this.da.SelectCommand.Parameters["@userID"].Value = (object) this._userID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataSet) this.ds);
    this.cbReports.SelectedValue = (object) this._ReportGuid;
    this.cbUsers.SelectedValue = (object) this._userID;
    if (SecurityManager.Instance.AssertPermission("{0A0252DA-808D-42F5-B390-55EEF66BEF46}"))
      this.cbUsers.Enabled = true;
    else
      this.cbUsers.Enabled = false;
    if (CurrentUser.IsMGADeveloper)
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["imageColumn"].TipStyleCell = (TipStyle) 1;
    else
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["imageColumn"].TipStyleCell = (TipStyle) 2;
    this.cbUsers.SelectedValueChanged += new EventHandler(this.cbUsers_SelectedValueChanged);
    this.cbReports.SelectedValueChanged += new EventHandler(this.cbUsers_SelectedValueChanged);
  }

  private void UltraGrid1_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!(bool) e.Row.Cells["isError"].Value)
      return;
    e.Row.Cells["imageColumn"].Value = (object) this.errorImage.Images["errorImage"];
    e.Row.Cells["imageColumn"].ToolTipText = e.Row.Cells["ErrorMsg"].Text;
  }

  private void cbUsers_SelectedValueChanged(object sender, EventArgs e)
  {
    this.cbUsers.SelectedValueChanged -= new EventHandler(this.cbUsers_SelectedValueChanged);
    this.cbReports.SelectedValueChanged -= new EventHandler(this.cbUsers_SelectedValueChanged);
    this._userID = this.cbUsers.SelectedValue != null ? (int) (short) this.cbUsers.SelectedValue : CurrentUser.Instance.UserID;
    this._ReportGuid = (Guid) this.cbReports.SelectedValue;
    this.da.SelectCommand.Parameters["@ReportGuid"].Value = (object) this._ReportGuid;
    this.da.SelectCommand.Parameters["@userID"].Value = (object) this._userID;
    this.ds.Clear();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataSet) this.ds);
    this.cbReports.SelectedValue = (object) this._ReportGuid;
    this.cbUsers.SelectedValue = (object) this._userID;
    this.cbUsers.SelectedValueChanged += new EventHandler(this.cbUsers_SelectedValueChanged);
    this.cbReports.SelectedValueChanged += new EventHandler(this.cbUsers_SelectedValueChanged);
  }

  private ReportNode FindReport(Guid ReportGUID)
  {
    SecureReportResourceAttribute searchAttribute = new SecureReportResourceAttribute();
    ReportNode Expression = (ReportNode) null;
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IReport));
    int index = 0;
    Guid guid;
    while (index < typeArray.Length)
    {
      Type type = typeArray[index];
      SecureReportResourceAttribute attributeFromType1 = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute);
      SuppressReportVisibleAttribute attributeFromType2 = ObjectFactory.GetAttributeFromType(type, (Attribute) new SuppressReportVisibleAttribute()) as SuppressReportVisibleAttribute;
      if (attributeFromType1 != null && attributeFromType2 == null)
      {
        guid = attributeFromType1.UniqueIdentifier;
        if (guid.Equals(ReportGUID) && !SecurityManager.Instance.IsPermissionDenied(attributeFromType1.UniqueIdentifier))
        {
          Expression = new ReportNode(attributeFromType1.UniqueIdentifier, type, attributeFromType1.ReportCategory, attributeFromType1.Name, attributeFromType1.ReportDescription);
          break;
        }
      }
      checked { ++index; }
    }
    if (Information.IsNothing((object) Expression))
    {
      Type type = typeof (AdHocReportDisplay);
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ReportGUID,ReportName,GroupName,Description FROM tblAdHocReports WHERE Published=1");
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          guid = new Guid(row[nameof (ReportGUID)].ToString());
          if (guid.Equals(ReportGUID) && !SecurityManager.Instance.IsPermissionDenied(row[nameof (ReportGUID)].ToString()))
          {
            Expression = new ReportNode(new Guid(row[nameof (ReportGUID)].ToString()), type, row["GroupName"].ToString(), row["ReportName"].ToString(), row["Description"].ToString() + " (AdHoc)");
            break;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    return Expression;
  }

  private void UltraGrid1_MouseDoubleClick(object sender, DoubleClickRowEventArgs e)
  {
    Guid guid = (Guid) e.Row.Cells["ReportGUID"].Value;
    string serializedData = e.Row.Cells["CriteriaXML"].Value.ToString();
    ReportNode report = this.FindReport(guid);
    if (this.frmGenericReportLauncher != null && this.frmGenericReportLauncher.ReportGUID.Equals(guid))
      this.frmGenericReportLauncher.setFromTypedParamList(this.DeSerializeArrayList(serializedData));
    else
      frmReportLog.LaunchReport(report, this.DeSerializeArrayList(serializedData));
  }

  private static void LaunchReport(ReportNode nodeToLaunch, ArrayList Criteria)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (SecurityManager.Instance.AssertPermission(nodeToLaunch.ReportID))
    {
      IReport instance = (IReport) Activator.CreateInstance(nodeToLaunch.Type);
      ((MGAReport) instance).CurrentUserGuid = CurrentUser.Instance.UserGUID;
      Type getLaunchForm = instance.getLaunchForm;
      BaseReportControl[] getReportControls1 = instance.getReportControls;
      if ((object) getLaunchForm != null)
      {
        Form formEx = ObjectFactory.Instance.CreateFormEX(getLaunchForm);
        formEx.ShowInTaskbar = false;
        formEx.AutoScroll = true;
        formEx.MdiParent = MDIControls.Instance.MDIParent;
        formEx.Show();
      }
      else if (getReportControls1 != null)
      {
        frmGenericReportLauncher genericReportLauncher = new frmGenericReportLauncher(nodeToLaunch.Type, nodeToLaunch.Title, getReportControls1);
        genericReportLauncher.ShowInTaskbar = false;
        genericReportLauncher.AutoScroll = true;
        genericReportLauncher.MdiParent = MDIControls.Instance.MDIParent;
        genericReportLauncher.Show();
        Application.DoEvents();
        genericReportLauncher.setFromTypedParamList(Criteria);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(instance.GetType().Name, "AdHocReportDisplay", false) == 0)
      {
        BaseReportControl[] getReportControls2 = new AdHocReport(nodeToLaunch.ReportID).getReportControls;
        frmGenericReportLauncher genericReportLauncher = new frmGenericReportLauncher(nodeToLaunch.Type, nodeToLaunch.Title, getReportControls2, nodeToLaunch.ReportID);
        genericReportLauncher.ShowInTaskbar = false;
        genericReportLauncher.AutoScroll = true;
        genericReportLauncher.MdiParent = MDIControls.Instance.MDIParent;
        genericReportLauncher.Show();
        Application.DoEvents();
        genericReportLauncher.setFromTypedParamList(Criteria);
      }
      else
      {
        frmThreadedReportGeneration reportGeneration = new frmThreadedReportGeneration(nodeToLaunch.Type, nodeToLaunch.Title);
        reportGeneration.ShowBouncingProgress(true);
        reportGeneration.MdiParent = MDIControls.Instance.MDIParent;
        reportGeneration.Show();
      }
    }
    else
    {
      int num = (int) MessageBox.Show($"You do not have permission to run {nodeToLaunch.Title}.", "No Permission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    Cursor.Current = Cursors.Default;
  }

  private ArrayList DeSerializeArrayList(string serializedData)
  {
    ArrayList arrayList = new ArrayList();
    XmlSerializer xmlSerializer = new XmlSerializer(typeof (ArrayList), new Type[1]
    {
      typeof (DBNull)
    });
    XmlReader xmlReader = XmlReader.Create((TextReader) new StringReader(serializedData));
    try
    {
      return (ArrayList) RuntimeHelpers.GetObjectValue(xmlSerializer.Deserialize(xmlReader));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
    finally
    {
      xmlReader.Close();
    }
  }
}
