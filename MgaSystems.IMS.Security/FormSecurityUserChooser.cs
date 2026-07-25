// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormSecurityUserChooser
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

public class FormSecurityUserChooser : Form
{
  private IContainer components;
  private SqlConnection cnSQL;
  private SqlDataAdapter daUsers;
  private SqlCommand SqlSelectCommand1;
  private ImageList ImageList1;
  private dsSecurityUserPicker DsSecurityUserPicker;
  private ColumnHeader ColumnHeader1;
  private List<Guid> _excludedGuids;
  private List<Guid> _userList;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  private virtual ListView lvUsers
  {
    get => this._lvUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lvUsers_DoubleClick);
      ListView lvUsers1 = this._lvUsers;
      if (lvUsers1 != null)
        lvUsers1.DoubleClick -= eventHandler;
      this._lvUsers = value;
      ListView lvUsers2 = this._lvUsers;
      if (lvUsers2 == null)
        return;
      lvUsers2.DoubleClick += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (FormSecurityUserChooser));
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.cnSQL = new SqlConnection();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.lvUsers = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ImageList1 = new ImageList(this.components);
    this.DsSecurityUserPicker = new dsSecurityUserPicker();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    this.DsSecurityUserPicker.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnCancel).Location = new Point(324, 332);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(75, 22);
    ((Control) this.btnCancel).TabIndex = 0;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOK).Location = new Point(244, 332);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(75, 22);
    ((Control) this.btnOK).TabIndex = 1;
    ((ControlBase) this.btnOK).Text = "OK";
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.daUsers.SelectCommand = this.SqlSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("FullName", "FullName")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT UserGuid, LastName + ', ' + FirstName AS FullName FROM tblUsers";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.lvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lvUsers.BackColor = Color.White;
    this.lvUsers.Columns.AddRange(new ColumnHeader[1]
    {
      this.ColumnHeader1
    });
    this.lvUsers.LargeImageList = this.ImageList1;
    this.lvUsers.Location = new Point(8, 8);
    this.lvUsers.Name = "lvUsers";
    this.lvUsers.Size = new Size(392, 312);
    this.lvUsers.SmallImageList = this.ImageList1;
    this.lvUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
    this.lvUsers.TabIndex = 2;
    this.lvUsers.View = View.Details;
    this.ColumnHeader1.Text = "User";
    this.ColumnHeader1.Width = 369;
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Magenta;
    this.DsSecurityUserPicker.DataSetName = "dsSecurityUserPicker";
    this.DsSecurityUserPicker.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(408, 366);
    this.Controls.Add((Control) this.lvUsers);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (FormSecurityUserChooser);
    this.Text = "Available Users";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    this.DsSecurityUserPicker.EndInit();
    this.ResumeLayout(false);
  }

  public FormSecurityUserChooser(Guid[] excludedUserGuids)
  {
    this.Load += new EventHandler(this.FormSecurityUserChooser_Load);
    this._excludedGuids = new List<Guid>();
    this._userList = new List<Guid>();
    this.InitializeComponent();
    if (excludedUserGuids == null)
      return;
    Guid[] guidArray = excludedUserGuids;
    int index = 0;
    while (index < guidArray.Length)
    {
      this._excludedGuids.Add(guidArray[index]);
      checked { ++index; }
    }
  }

  private void FormSecurityUserChooser_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = Database.Instance.ConnectionString;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.CancelButton = (IButtonControl) this.btnCancel;
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daUsers", this.daUsers, new TableQueryMultithreadEventHandler(this.users_tableFilled), (DataTable) this.DsSecurityUserPicker.tblUsers);
  }

  private void users_tableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    try
    {
      foreach (dsSecurityUserPicker.tblUsersRow row in e.Table.Rows)
      {
        if (!this._excludedGuids.Contains(row.UserGuid))
          this.lvUsers.Items.Add((ListViewItem) new FormSecurityUserChooser.UserListViewItem(row));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    try
    {
      foreach (FormSecurityUserChooser.UserListViewItem selectedItem in this.lvUsers.SelectedItems)
        this._userList.Add(selectedItem.UserGuid);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DialogResult = DialogResult.OK;
  }

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public List<Guid> UsersPicked => this._userList;

  private void lvUsers_DoubleClick(object sender, EventArgs e)
  {
    try
    {
      foreach (FormSecurityUserChooser.UserListViewItem selectedItem in this.lvUsers.SelectedItems)
      {
        this.lvUsers.Items.Remove((ListViewItem) selectedItem);
        this.UserPropertiesForm.ExternalAddUser(selectedItem.UserGuid);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private FormSecurityGroupProperties UserPropertiesForm
  {
    get => (FormSecurityGroupProperties) this.Owner;
  }

  private sealed class UserListViewItem : ListViewItem
  {
    private Guid _userGuid;

    public UserListViewItem(dsSecurityUserPicker.tblUsersRow row)
      : base(row.FullName)
    {
      this.ImageIndex = 0;
      this._userGuid = row.UserGuid;
    }

    public Guid UserGuid => this._userGuid;
  }
}
