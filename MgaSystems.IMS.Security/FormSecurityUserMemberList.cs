// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormSecurityUserMemberList
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

[SecureResource("{EB46A04E-7C78-4cdf-BE99-87659ADCE06C}", "Modify Group Membership.", "Controls the ability to adjust group membership for a given user.", "Security Administration")]
public class FormSecurityUserMemberList : Form
{
  public const string SecurityIdAddDeleteGroupsFromUser = "{EB46A04E-7C78-4cdf-BE99-87659ADCE06C}";
  private IContainer components;
  private Label Label1;
  private UltraTabControl UltraTabControl1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private PictureBox PictureBox1;
  private Label Label2;
  private SqlDataAdapter daUsers;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cnSQL;
  private SqlDataAdapter daGroups;
  private SqlCommand SqlSelectCommand2;
  private SqlDataAdapter daUserGroups;
  private SqlCommand SqlSelectCommand3;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private dsSecurityUserProperties DsSecurityUserProperties;
  private Label lblUser;
  private ListView lvGroups;
  private ColumnHeader ColumnHeader1;
  private ColumnHeader ColumnHeader2;
  private ImageList ImageList1;
  private Guid _userGuid;
  private bool _userGroupsFilled;
  private bool _groupsFilled;
  private bool _changesApplied;
  private Guid _adminGroupGuid;

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

  private virtual MGAButton btnAdd
  {
    get => this._btnAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      MGAButton btnAdd1 = this._btnAdd;
      if (btnAdd1 != null)
        ((Control) btnAdd1).Click -= eventHandler;
      this._btnAdd = value;
      MGAButton btnAdd2 = this._btnAdd;
      if (btnAdd2 == null)
        return;
      ((Control) btnAdd2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnRemove
  {
    get => this._btnRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemove_Click);
      MGAButton btnRemove1 = this._btnRemove;
      if (btnRemove1 != null)
        ((Control) btnRemove1).Click -= eventHandler;
      this._btnRemove = value;
      MGAButton btnRemove2 = this._btnRemove;
      if (btnRemove2 == null)
        return;
      ((Control) btnRemove2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (FormSecurityUserMemberList));
    UltraTab ultraTab = new UltraTab();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.btnAdd = new MGAButton();
    this.btnRemove = new MGAButton();
    this.lblUser = new Label();
    this.Label2 = new Label();
    this.lvGroups = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.ImageList1 = new ImageList(this.components);
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.daGroups = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daUserGroups = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.DsSecurityUserProperties = new dsSecurityUserProperties();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.btnRemove).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    this.DsSecurityUserProperties.BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnAdd);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnRemove);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblUser);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lvGroups);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.PictureBox1);
    ((Control) this.UltraTabPageControl1).Location = new Point(2, 24);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(372, 398);
    ((Control) this.btnAdd).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnAdd).Location = new Point(16 /*0x10*/, 360);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnAdd).TabIndex = 2;
    ((ControlBase) this.btnAdd).Text = "Add";
    ((Control) this.btnRemove).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnRemove).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnRemove).Location = new Point(88, 360);
    ((Control) this.btnRemove).Name = "btnRemove";
    ((Control) this.btnRemove).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnRemove).TabIndex = 3;
    ((ControlBase) this.btnRemove).Text = "Remove...";
    this.lblUser.AutoSize = true;
    this.lblUser.BackColor = Color.Transparent;
    this.lblUser.Location = new Point(64 /*0x40*/, 32 /*0x20*/);
    this.lblUser.Name = "lblUser";
    this.lblUser.Size = new Size(37, 17);
    this.lblUser.TabIndex = 5;
    this.lblUser.Text = "User X";
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.BorderStyle = BorderStyle.FixedSingle;
    this.Label2.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(336, 1);
    this.Label2.TabIndex = 4;
    this.lvGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lvGroups.Columns.AddRange(new ColumnHeader[2]
    {
      this.ColumnHeader1,
      this.ColumnHeader2
    });
    this.lvGroups.LargeImageList = this.ImageList1;
    this.lvGroups.Location = new Point(16 /*0x10*/, 96 /*0x60*/);
    this.lvGroups.Name = "lvGroups";
    this.lvGroups.Size = new Size(336, 256 /*0x0100*/);
    this.lvGroups.SmallImageList = this.ImageList1;
    this.lvGroups.TabIndex = 1;
    this.lvGroups.View = View.Details;
    this.ColumnHeader1.Text = "Name";
    this.ColumnHeader1.Width = 142;
    this.ColumnHeader2.Text = "Description";
    this.ColumnHeader2.Width = 186;
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(16 /*0x10*/, 80 /*0x50*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(60, 17);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Member Of";
    this.PictureBox1.BackColor = Color.Transparent;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 3;
    this.PictureBox1.TabStop = false;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraTabControlBase) this.UltraTabControl1).BackColor = Color.White;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(376, 424);
    ((Control) this.UltraTabControl1).TabIndex = 2;
    ultraTab.TabPage = this.UltraTabPageControl1;
    ultraTab.Text = "General";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab
    });
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(372, 398);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnCancel).Location = new Point(296, 432);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnOK).Location = new Point(224 /*0xE0*/, 432);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnOK).TabIndex = 0;
    ((ControlBase) this.btnOK).Text = "OK";
    this.daUsers.SelectCommand = this.SqlSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[1]
      {
        new DataColumnMapping("FullName", "FullName")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT LastName + ', ' + FirstName AS FullName FROM tblUsers WHERE (UserGuid = @UserGuid)";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"));
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.daGroups.SelectCommand = this.SqlSelectCommand2;
    this.daGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSecurityGroups", new DataColumnMapping[3]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("GroupGuid", "GroupGuid"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT Name, GroupGuid, Description FROM tblSecurityGroups";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.daUserGroups.DeleteCommand = this.SqlDeleteCommand1;
    this.daUserGroups.InsertCommand = this.SqlInsertCommand1;
    this.daUserGroups.SelectCommand = this.SqlSelectCommand3;
    this.daUserGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSecurityUserGroups", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("GroupGuid", "GroupGuid")
      })
    });
    this.daUserGroups.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblSecurityUserGroups WHERE (GroupGuid = @Original_GroupGuid) AND (UserGuid = @Original_UserGuid)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.Add(new SqlParameter("@Original_GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupGuid", DataRowVersion.Original, (object) null));
    this.SqlDeleteCommand1.Parameters.Add(new SqlParameter("@Original_UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGuid", DataRowVersion.Original, (object) null));
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblSecurityUserGroups(UserGuid, GroupGuid) VALUES (@UserGuid, @GroupGUID); SELECT UserGuid, GroupGuid FROM tblSecurityUserGroups WHERE (GroupGuid = @GroupGuid) AND (UserGuid = @UserGuid)";
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.Add(new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"));
    this.SqlInsertCommand1.Parameters.Add(new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"));
    this.SqlSelectCommand3.CommandText = "SELECT UserGuid, GroupGuid FROM tblSecurityUserGroups WHERE (UserGuid = @UserGuid)";
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.Add(new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"));
    this.SqlUpdateCommand1.CommandText = "UPDATE tblSecurityUserGroups SET UserGuid = @UserGuid, GroupGuid = @GroupGuid WHERE (GroupGuid = @Original_GroupGuid) AND (UserGuid = @Original_UserGuid); SELECT UserGuid, GroupGuid FROM tblSecurityUserGroups WHERE (GroupGuid = @GroupGuid) AND (UserGuid = @UserGuid)";
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@Original_GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupGuid", DataRowVersion.Original, (object) null));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@Original_UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGuid", DataRowVersion.Original, (object) null));
    this.DsSecurityUserProperties.DataSetName = "dsSecurityUserProperties";
    this.DsSecurityUserProperties.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(376, 462);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (FormSecurityUserMemberList);
    this.Text = "User Properties";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.btnRemove).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    this.DsSecurityUserProperties.EndInit();
    this.ResumeLayout(false);
  }

  public FormSecurityUserMemberList(Guid userGuid)
  {
    this.Load += new EventHandler(this.FormSecurityUserMemberList_Load);
    this.Closing += new CancelEventHandler(this.FormSecurityUserMemberList_Closing);
    this.InitializeComponent();
    this._userGuid = userGuid;
  }

  private void FormSecurityUserMemberList_Load(object sender, EventArgs e)
  {
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.cnSQL.ConnectionString = MGASystems.Common.DataAccess.Database.Instance.ConnectionString;
    this._adminGroupGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT GroupGuid FROM dbo.tblSecurityGroups WHERE Name = @GroupName", new object[2]
    {
      (object) "@GroupName",
      (object) "Administrators"
    });
    this.PictureBox1.Image = Imaging.MakeTransparent(this.PictureBox1.Image);
    this.daUserGroups.SelectCommand.Parameters["@UserGuid"].Value = (object) this._userGuid;
    this.daUsers.SelectCommand.Parameters["@UserGuid"].Value = (object) this._userGuid;
    DatabaseQueryMultithreadedDataAdapter multithreadedDataAdapter = MGASystems.Common.DataAccess.Database.Instance.QueryMultithreadedDataAdapter;
    multithreadedDataAdapter.PerformTableQuery((Control) this, "daUsers", this.daUsers, new TableQueryMultithreadEventHandler(this.Users_TableFilled), (DataTable) this.DsSecurityUserProperties.tblUsers);
    multithreadedDataAdapter.PerformTableQuery((Control) this, "daGroups", this.daGroups, new TableQueryMultithreadEventHandler(this.Groups_TableFilled), (DataTable) this.DsSecurityUserProperties.tblSecurityGroups);
    multithreadedDataAdapter.PerformTableQuery((Control) this, "daUserGroups", this.daUserGroups, new TableQueryMultithreadEventHandler(this.UserGroups_TableFilled), (DataTable) this.DsSecurityUserProperties.tblSecurityUserGroups);
    if (!SecurityManager.Instance.AssertPermission("{EB46A04E-7C78-4cdf-BE99-87659ADCE06C}", 0))
    {
      ((Control) this.btnRemove).Visible = false;
      ((Control) this.btnAdd).Visible = false;
    }
    else
    {
      ((Control) this.btnRemove).Visible = true;
      ((Control) this.btnAdd).Visible = true;
    }
  }

  private void Users_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.lblUser.Text = ((dsSecurityUserProperties.tblUsersRow) this.DsSecurityUserProperties.tblUsers.Rows[0]).FullName;
  }

  private void UserGroups_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this._userGroupsFilled = true;
    this.RefreshGroupsList();
  }

  private void Groups_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this._groupsFilled = true;
    this.RefreshGroupsList();
  }

  private void RefreshGroupsList()
  {
    if (!this._groupsFilled || !this._userGroupsFilled)
      return;
    this.lvGroups.Items.Clear();
    try
    {
      foreach (dsSecurityUserProperties.tblSecurityUserGroupsRow securityUserGroup in (TypedTableBase<dsSecurityUserProperties.tblSecurityUserGroupsRow>) this.DsSecurityUserProperties.tblSecurityUserGroups)
        this.lvGroups.Items.Add((ListViewItem) new FormSecurityUserMemberList.GroupListViewItem(this.DsSecurityUserProperties.tblSecurityGroups.FindByGroupGuid(securityUserGroup.GroupGuid)));
    }
    finally
    {
      IEnumerator<dsSecurityUserProperties.tblSecurityUserGroupsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private bool GroupListChanged
  {
    get
    {
      bool groupListChanged;
      if (this._changesApplied)
        groupListChanged = false;
      else if (this.DsSecurityUserProperties.tblSecurityUserGroups.Count != this.lvGroups.Items.Count)
      {
        groupListChanged = true;
      }
      else
      {
        try
        {
          foreach (FormSecurityUserMemberList.GroupListViewItem groupListViewItem in this.lvGroups.Items)
          {
            if (this.DsSecurityUserProperties.tblSecurityUserGroups.FindByUserGuidGroupGuid(this._userGuid, groupListViewItem.GroupGuid) == null)
            {
              groupListChanged = true;
              goto label_12;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        groupListChanged = false;
      }
label_12:
      return groupListChanged;
    }
  }

  private bool UserHasChanges => !this._changesApplied && this.GroupListChanged;

  private bool GroupIsValid(Guid groupGuid)
  {
    bool flag;
    try
    {
      foreach (FormSecurityUserMemberList.GroupListViewItem groupListViewItem in this.lvGroups.Items)
      {
        if (groupListViewItem.GroupGuid.Equals(groupGuid))
        {
          flag = true;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_8:
    return flag;
  }

  private void ApplyChanges()
  {
    if (this.GroupListChanged)
    {
      try
      {
        foreach (dsSecurityUserProperties.tblSecurityUserGroupsRow securityUserGroup in (TypedTableBase<dsSecurityUserProperties.tblSecurityUserGroupsRow>) this.DsSecurityUserProperties.tblSecurityUserGroups)
        {
          if (!this.GroupIsValid(securityUserGroup.GroupGuid))
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblSecurityUserGroups WHERE GroupGuid = @GroupGuid AND UserGuid = @UserGuid", new object[4]
            {
              (object) "@GroupGuid",
              (object) securityUserGroup.GroupGuid,
              (object) "@UserGuid",
              (object) this._userGuid
            });
        }
      }
      finally
      {
        IEnumerator<dsSecurityUserProperties.tblSecurityUserGroupsRow> enumerator;
        enumerator?.Dispose();
      }
      try
      {
        foreach (FormSecurityUserMemberList.GroupListViewItem groupListViewItem in this.lvGroups.Items)
        {
          if (this.DsSecurityUserProperties.tblSecurityUserGroups.FindByUserGuidGroupGuid(this._userGuid, groupListViewItem.GroupGuid) == null)
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblSecurityUserGroups (UserGuid, GroupGuid) VALUES (@UserGuid, @GroupGuid)", new object[4]
            {
              (object) "@UserGuid",
              (object) this._userGuid,
              (object) "@GroupGuid",
              (object) groupListViewItem.GroupGuid
            });
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this._changesApplied = true;
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this.UserHasChanges)
      this.ApplyChanges();
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void FormSecurityUserMemberList_Closing(object sender, CancelEventArgs e)
  {
    if (this.UserHasChanges)
    {
      switch (MessageBox.Show(SR.GetString("SECURITY_GROUP_PROPERTIES_SAVE_CHANGES"), SR.GetString("SECURITY_GROUP_PROPERTIES_SAVE_CHANGES_CAPTION"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          this.ApplyChanges();
          break;
      }
    }
    if (e.Cancel || this.UserHasChanges)
      return;
    this.DialogResult = DialogResult.OK;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (FormSecurityUserMemberList.GroupListViewItem groupListViewItem in this.lvGroups.Items)
        guidList.Add(groupListViewItem.GroupGuid);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    FormSecurityGroupChooser securityGroupChooser = new FormSecurityGroupChooser(guidList.ToArray());
    try
    {
      if (securityGroupChooser.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      try
      {
        foreach (Guid GroupGuid in securityGroupChooser.GroupsPicked)
          this.lvGroups.Items.Add((ListViewItem) new FormSecurityUserMemberList.GroupListViewItem(this.DsSecurityUserProperties.tblSecurityGroups.FindByGroupGuid(GroupGuid)));
      }
      finally
      {
        List<Guid>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      securityGroupChooser.Dispose();
    }
  }

  internal void ExternalAddGroup(Guid groupGuid)
  {
    this.lvGroups.Items.Add((ListViewItem) new FormSecurityUserMemberList.GroupListViewItem(this.DsSecurityUserProperties.tblSecurityGroups.FindByGroupGuid(groupGuid)));
  }

  private void btnRemove_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show(SR.GetString("SECURITY_ADMIN_SEC_USERS_REMOVE"), SR.GetString("SECURITY_ADMIN_SEC_USERS_REMOVE_CAPTION"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      foreach (FormSecurityUserMemberList.GroupListViewItem selectedItem in this.lvGroups.SelectedItems)
      {
        if (selectedItem.GroupGuid.Equals(this._adminGroupGuid) && this.CurrentAdminCount <= 1)
        {
          int num = (int) MessageBox.Show(SR.GetString("SECURITY_ADMIN_SEC_USERS_ONEADMIN"), SR.GetString("SECURITY_ADMIN_SEC_USERS_ONEADMIN_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          this.lvGroups.Items.Remove((ListViewItem) selectedItem);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private int CurrentAdminCount
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblSecurityUserGroups WHERE GroupGuid = @GroupGuid", new object[2]
      {
        (object) "@GroupGuid",
        (object) this._adminGroupGuid
      });
    }
  }

  private sealed class GroupListViewItem : ListViewItem
  {
    private Guid _groupGuid;

    public GroupListViewItem(dsSecurityUserProperties.tblSecurityGroupsRow row)
      : base(row.Name)
    {
      this._groupGuid = row.GroupGuid;
      this.SubItems.Add(row.Description);
      this.ImageIndex = 0;
    }

    public Guid GroupGuid => this._groupGuid;
  }
}
