// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmNoteUserSelect
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmNoteUserSelect : MGABaseForm
{
  private EventHandler _usersSelectedHandler;
  private bool _suppressSaveDlg;
  private Guid _omittedUserGUID;
  private IContainer components;
  private SqlConnection cnSql;
  private SqlCommand SqlSelectCommand1;
  private SqlDataAdapter daUsers;
  private SqlDataAdapter daGroups;
  private SqlCommand SqlSelectCommand2;
  private dsUserSelection dsUserSelection;

  public frmNoteUserSelect(EventHandler usersSelectedHandler, Guid omittedUser)
  {
    this.Closing += new CancelEventHandler(this.frmNoteUserSelect_Closing);
    this.Load += new EventHandler(this.frmNoteUserSelect_Load);
    this.InitializeComponent();
    this._usersSelectedHandler = usersSelectedHandler;
    this._omittedUserGUID = omittedUser;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual UserPicker imsUserPicker
  {
    get => this._imsUserPicker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      UserPicker.UserPickerGUIDAddingEventHandler addingEventHandler = new UserPicker.UserPickerGUIDAddingEventHandler(this.imsUserPicker_UserGUIDAdding);
      UserPicker imsUserPicker1 = this._imsUserPicker;
      if (imsUserPicker1 != null)
        imsUserPicker1.UserGUIDAdding -= addingEventHandler;
      this._imsUserPicker = value;
      UserPicker imsUserPicker2 = this._imsUserPicker;
      if (imsUserPicker2 == null)
        return;
      imsUserPicker2.UserGUIDAdding += addingEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.imsUserPicker = new UserPicker();
    this.dsUserSelection = new dsUserSelection();
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.cnSql = new SqlConnection();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.daGroups = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.dsUserSelection.BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.imsUserPicker.BackColor = Color.White;
    this.imsUserPicker.Font = new Font("Tahoma", 8.25f);
    this.imsUserPicker.ForeColor = Color.Black;
    this.imsUserPicker.GroupDisplayMember = "GroupName";
    this.imsUserPicker.GroupGUIDMember = "GroupGUID";
    this.imsUserPicker.GroupImage = (Image) null;
    this.imsUserPicker.GroupTable = (DataTable) this.dsUserSelection.lstSecurityGroups;
    this.imsUserPicker.Location = new Point(0, 0);
    this.imsUserPicker.Name = "imsUserPicker";
    this.imsUserPicker.Size = new Size(480, 296);
    this.imsUserPicker.TabIndex = 0;
    this.imsUserPicker.UserDisplayMember = "FullName";
    this.imsUserPicker.UserGUIDMember = "UserGUID";
    this.imsUserPicker.UserTable = (DataTable) this.dsUserSelection.tblUsers;
    this.dsUserSelection.DataSetName = "dsUserSelection";
    this.dsUserSelection.Locale = new CultureInfo("en-US");
    ((Control) this.btnOK).Location = new Point(168, 312);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnOK).TabIndex = 1;
    ((ControlBase) this.btnOK).Text = "OK";
    ((Control) this.btnCancel).Location = new Point(248, 312);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnCancel).TabIndex = 2;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.cnSql.ConnectionString = "data source=MGASYSTEMS;initial catalog=IMS;password=20mgaims07;persist security info=True;user id=mgasystems;workstation id=DOMENIC;packet size=4096";
    this.daUsers.SelectCommand = this.SqlSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[3]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("LastName", "LastName")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT UserGUID, LastName + ', ' + FirstName AS FullName FROM tblUsers  WHERE StatusID = 1 ORDER BY FullName";
    this.SqlSelectCommand1.Connection = this.cnSql;
    this.daGroups.SelectCommand = this.SqlSelectCommand2;
    this.daGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstSecurityGroups", new DataColumnMapping[2]
      {
        new DataColumnMapping("GroupName", "GroupName"),
        new DataColumnMapping("GroupGUID", "GroupGUID")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT GroupName, GroupGUID FROM lstSecurityGroups ORDER BY GroupName";
    this.SqlSelectCommand2.Connection = this.cnSql;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(480, 352);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.imsUserPicker);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNoteUserSelect);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Names";
    this.dsUserSelection.EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this._usersSelectedHandler != null)
      this._usersSelectedHandler((object) this, e);
    this._suppressSaveDlg = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._suppressSaveDlg = true;
    this.Close();
  }

  private void frmNoteUserSelect_Closing(object sender, CancelEventArgs e)
  {
    if (this._suppressSaveDlg)
      return;
    switch (MessageBox.Show("Would you like to save the selected users?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
    {
      case DialogResult.Cancel:
        e.Cancel = true;
        break;
      case DialogResult.Yes:
        if (this._usersSelectedHandler == null)
          break;
        this._usersSelectedHandler((object) this, (EventArgs) e);
        break;
    }
  }

  [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
  public MustCompleteContextGUID[] SelectedUsers => this.imsUserPicker.SelectedUsers;

  private void frmNoteUserSelect_Load(object sender, EventArgs e)
  {
    this.cnSql.ConnectionString = CurrentUser.Instance.ConnectionString;
    Database.SafeDataAdapterFill(this.daUsers, (DataTable) this.dsUserSelection.tblUsers);
  }

  private void imsUserPicker_UserGUIDAdding(object sender, UserPickerGUIDAddingEventArgs e)
  {
    if (e.UserGUID.Guid.Equals(this._omittedUserGUID))
      e.Cancel = true;
    else
      e.Cancel = false;
  }
}
