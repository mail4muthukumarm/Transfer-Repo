// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Administration.frmTransactionLog
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Administration;

[SecureResource("{12D7A665-2B74-4c5a-86ED-5F79DBCAFC44}", "Allows Users to View Transaction Log", "Controls whether or not users can view the transaction log.", "Policies")]
[SecureResource("{8503015C-2A01-46D3-B96B-695E2CAE9FCE}", "Allows a User to View Other Users Log Items", "Controls whether or not a user can view other users transaction log items.", "Policies")]
public sealed class frmTransactionLog : Form
{
  private IContainer components;
  private DbDataAdapter da;
  private DbCommand DbSelectCommand1;
  private dsTransactionLog ds;
  private UltraGrid UltraGrid1;
  private int _identifierID;
  private Guid _identifierGuid;
  public const string CanViewLog = "{12D7A665-2B74-4c5a-86ED-5F79DBCAFC44}";
  public const string CanViewOtherUsersLog = "{8503015C-2A01-46D3-B96B-695E2CAE9FCE}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  internal virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabTransactionLog")]
  internal virtual UltraTabPageControl tabTransactionLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabReportLog")]
  internal virtual UltraTabPageControl tabReportLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spViewTransactionLog", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ActionDate");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    this.tabTransactionLog = new UltraTabPageControl();
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsTransactionLog();
    this.tabReportLog = new UltraTabPageControl();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.tabTransactionLog).SuspendLayout();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.tabTransactionLog).Controls.Add((Control) this.UltraGrid1);
    ((Control) this.tabTransactionLog).Location = new Point(1, 23);
    ((Control) this.tabTransactionLog).Name = "tabTransactionLog";
    ((Control) this.tabTransactionLog).Size = new Size(773, 308);
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.spViewTransactionLog;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 141;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 438;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn3.Format = "f";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Action Date/Time";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 192 /*0xC0*/;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
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
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(773, 308);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsTransactionLog";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.tabReportLog).Location = new Point(-10000, -10000);
    ((Control) this.tabReportLog).Name = "tabReportLog";
    ((Control) this.tabReportLog).Size = new Size(773, 308);
    this.da.SelectCommand = this.DbSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spViewTransactionLog", new DataColumnMapping[3]
      {
        new DataColumnMapping("UserName", "UserName"),
        new DataColumnMapping("Action", "Action"),
        new DataColumnMapping("ActionDate", "ActionDate")
      })
    });
    this.DbSelectCommand1.CommandText = "[spViewTransactionLog]";
    this.DbSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@identifierID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@identifierGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@userID", SqlDbType.Int, 4)
    });
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabTransactionLog);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabReportLog);
    ((Control) this.UltraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(777, 334);
    ((Control) this.UltraTabControl1).TabIndex = 1;
    ultraTab1.Key = "TransactionLog";
    ultraTab1.TabPage = this.tabTransactionLog;
    ultraTab1.Text = "Transaction Log";
    ultraTab2.Key = "ReportLog";
    ultraTab2.TabPage = this.tabReportLog;
    ultraTab2.Text = "Report Log";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(773, 308);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(777, 334);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmTransactionLog);
    this.Text = "Transaction Log";
    ((Control) this.tabTransactionLog).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmTransactionLog()
  {
    this.Load += new EventHandler(this.frmTransactionLog_Load);
    this._identifierID = -1;
    this.InitializeComponent();
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
  }

  public frmTransactionLog(int identifierID)
    : this()
  {
    this._identifierID = identifierID;
  }

  public frmTransactionLog(Guid identifierGuid)
    : this()
  {
    this._identifierGuid = identifierGuid;
  }

  private void frmTransactionLog_Load(object sender, EventArgs e)
  {
    if (!this._identifierGuid.Equals(Guid.Empty))
      this.da.SelectCommand.Parameters["@IdentifierGuid"].Value = (object) this._identifierGuid;
    else if (this._identifierID != -1)
      this.da.SelectCommand.Parameters["@IdentifierID"].Value = (object) this._identifierID;
    if (!SecurityManager.Instance.AssertPermission("{8503015C-2A01-46D3-B96B-695E2CAE9FCE}"))
      this.da.SelectCommand.Parameters["@userID"].Value = (object) CurrentUser.Instance.UserID;
    DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.spViewTransactionLog);
    if (this.InitReportLog())
      return;
    ((UltraTabControlBase) this.UltraTabControl1).Tabs["ReportLog"].Visible = false;
  }

  private bool InitReportLog()
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Forms.frmReportLog");
    bool flag;
    if ((object) typeFromString == null)
      flag = false;
    else if (!SecurityManager.Instance.AssertPermission(typeFromString.GetCustomAttributesData()[0].ConstructorArguments[0].Value.ToString()))
    {
      flag = false;
    }
    else
    {
      Form form = ObjectFactory.Instance.CreateForm(typeFromString);
      if (form == null)
      {
        flag = false;
      }
      else
      {
        form.TopLevel = false;
        ((Control) this.tabReportLog).Controls.Add((Control) form);
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        form.Show();
        flag = true;
      }
    }
    return flag;
  }
}
