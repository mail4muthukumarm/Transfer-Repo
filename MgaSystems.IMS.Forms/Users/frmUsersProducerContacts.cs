// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmUsersProducerContacts
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Users;

public sealed class frmUsersProducerContacts : Form
{
  private IContainer components;
  private Label Label1;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cn;
  private SqlDataAdapter daUsersContacts;
  private SqlCommand SqlSelectCommand2;
  private SqlDataAdapter daProducerContacts;
  private dsUsersProducerContacts ds;
  private UltraDropDown ddProducerContacts;
  private int _userID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ug_BeforeRowUpdate);
      RowEventHandler rowEventHandler1 = new RowEventHandler(this.ug_AfterRowInsert);
      RowEventHandler rowEventHandler2 = new RowEventHandler(this.ug_AfterRowUpdate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
      {
        ug1.BeforeRowUpdate -= cancelableRowEventHandler;
        ug1.AfterRowInsert -= rowEventHandler1;
        ug1.AfterRowUpdate -= rowEventHandler2;
      }
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.BeforeRowUpdate += cancelableRowEventHandler;
      ug2.AfterRowInsert += rowEventHandler1;
      ug2.AfterRowUpdate += rowEventHandler2;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUsersProducerContacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerContactID", -1, (object) "ddProducerContacts");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUsersProducerContacts));
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerLocation");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("tblProducerContactstblUsersProducerContacts");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerContactstblUsersProducerContacts", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerContactID");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    this.ug = new UltraGrid();
    this.ds = new dsUsersProducerContacts();
    this.Label1 = new Label();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.daUsersContacts = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daProducerContacts = new SqlDataAdapter();
    this.ddProducerContacts = new UltraDropDown();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddProducerContacts).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblUsersProducerContacts;
    appearance1.BackColor = Color.FromArgb(246, 250, 253);
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.FromArgb(246, 250, 253);
    appearance2.BorderColor = Color.FromArgb(246, 250, 253);
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.AddButtonCaption = "Add new producer contact...";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 152;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Producer Contact";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 475;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ug).Dock = DockStyle.Bottom;
    ((Control) this.ug).Location = new Point(0, 53);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(496, 312);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsUsersProducerContacts";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(472, 40);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "This form allows underwriters to be assigned to specific producer contacts.  This allows reports to be run for a specific underwriter's producers.";
    this.SqlSelectCommand1.CommandText = "SELECT UserID, ProducerContactID FROM dbo.tblUsersProducerContacts WHERE (UserID = @userID)";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@userID", SqlDbType.SmallInt, 2, "UserID")
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@UserID", SqlDbType.SmallInt, 2, "UserID"),
      new SqlParameter("@ProducerContactID", SqlDbType.Int, 4, "ProducerContactID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@UserID", SqlDbType.SmallInt, 2, "UserID"),
      new SqlParameter("@ProducerContactID", SqlDbType.Int, 4, "ProducerContactID"),
      new SqlParameter("@Original_ProducerContactID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_UserID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserID", DataRowVersion.Original, (object) null)
    });
    this.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.tblUsersProducerContacts WHERE (ProducerContactID = @Original_ProducerContactID) AND (UserID = @Original_UserID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ProducerContactID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_UserID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserID", DataRowVersion.Original, (object) null)
    });
    this.daUsersContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daUsersContacts.InsertCommand = this.SqlInsertCommand1;
    this.daUsersContacts.SelectCommand = this.SqlSelectCommand1;
    this.daUsersContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsersProducerContacts", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserID", "UserID"),
        new DataColumnMapping("ProducerContactID", "ProducerContactID")
      })
    });
    this.daUsersContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Connection = this.cn;
    this.daProducerContacts.SelectCommand = this.SqlSelectCommand2;
    this.daProducerContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerContacts", new DataColumnMapping[16 /*0x10*/]
      {
        new DataColumnMapping("ProducerContactID", "ProducerContactID"),
        new DataColumnMapping("ProducerContactGUID", "ProducerContactGUID"),
        new DataColumnMapping("ProducerLocationGUID", "ProducerLocationGUID"),
        new DataColumnMapping("Salutation", "Salutation"),
        new DataColumnMapping("FName", "FName"),
        new DataColumnMapping("LName", "LName"),
        new DataColumnMapping("Title", "Title"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Extension", "Extension"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("Cell", "Cell"),
        new DataColumnMapping("Email", "Email"),
        new DataColumnMapping("SSNo", "SSNo"),
        new DataColumnMapping("Req1099", "Req1099"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("DeliveryMethodID", "DeliveryMethodID")
      })
    });
    ((UltraGridBase) this.ddProducerContacts).DataSource = (object) this.ds.tblProducerContacts;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 118;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 164;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 170;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.WhiteSmoke;
    appearance17.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ddProducerContacts).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.ddProducerContacts).DisplayMember = "ProducerContact";
    ((Control) this.ddProducerContacts).Location = new Point(40, 144 /*0x90*/);
    ((Control) this.ddProducerContacts).Name = "ddProducerContacts";
    ((Control) this.ddProducerContacts).Size = new Size(336, 72);
    ((Control) this.ddProducerContacts).TabIndex = 2;
    ((UltraDropDownBase) this.ddProducerContacts).ValueMember = "ProducerContactID";
    ((Control) this.ddProducerContacts).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(496, 365);
    this.Controls.Add((Control) this.ddProducerContacts);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmUsersProducerContacts);
    this.Text = "Underwriter / Producer Contact Assignment";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddProducerContacts).EndInit();
    this.ResumeLayout(false);
  }

  public frmUsersProducerContacts(int userID)
  {
    this.Load += new EventHandler(this.frmUsersProducerContacts_Load);
    this.Closing += new CancelEventHandler(this.frmCompanyConstructionTypes_Closing);
    this.InitializeComponent();
    this._userID = userID;
    DbConnection connection = (DbConnection) DefaultDatabase.CreateConnection();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daUsersContacts, connection, (DbTransaction) null);
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daProducerContacts, connection, (DbTransaction) null);
    this.daUsersContacts.SelectCommand.Parameters["@UserID"].Value = (object) userID;
  }

  private void frmUsersProducerContacts_Load(object sender, EventArgs e)
  {
    new Thread(new ThreadStart(this.ThreadedFill))
    {
      Name = nameof (frmUsersProducerContacts_Load)
    }.Start();
  }

  private void ThreadedFill()
  {
    dsUsersProducerContacts producerContacts = new dsUsersProducerContacts();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daProducerContacts, (DataTable) producerContacts.tblProducerContacts);
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daUsersContacts, (DataTable) producerContacts.tblUsersProducerContacts);
    if (this.IsDisposed && (!this.Disposing || !this.IsHandleCreated))
      return;
    this.BetterInvoke((Delegate) new frmUsersProducerContacts.ThreadedFillCompleteHandler(this.ThreadedFillComplete), (object) producerContacts);
  }

  private void ThreadedFillComplete(dsUsersProducerContacts dsThread)
  {
    ((UltraGridBase) this.ddProducerContacts).DataSource = (object) dsThread.tblProducerContacts;
    ((UltraGridBase) this.ug).DataSource = (object) dsThread.tblUsersProducerContacts;
  }

  private void frmCompanyConstructionTypes_Closing(object sender, CancelEventArgs e)
  {
    this.ug.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ug).ActiveRow != null)
      ((UltraGridBase) this.ug).ActiveRow.Update();
    ((UltraGridBase) this.ug).UpdateData();
    CurrentUser.Instance.LogAction("Modified User access - Producer contacts information was modified", this._userID);
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daUsersContacts, (DataTable) ((UltraGridBase) this.ug).DataSource);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      if (MessageBox.Show("An error has occured.\n\nWould you like to close the form anyway?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
        e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void ug_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["ProducerContactID"].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ug_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["UserID"].Value = (object) this._userID;
    CurrentUser.Instance.LogAction("Users Menu - Added producer / underwriter contact assignment", this._userID);
  }

  private void ug_AfterRowUpdate(object sender, RowEventArgs e)
  {
    int num = (int) e.Row.Cells["ProducerContactID"].Value;
    CurrentUser.Instance.LogAction("Users Menu - Modified producer / underwriter contact assignment for producer contact id :" + Conversions.ToString(num), this._userID, Conversions.ToString(num));
  }

  private delegate void ThreadedFillCompleteHandler(dsUsersProducerContacts dsThread);
}
