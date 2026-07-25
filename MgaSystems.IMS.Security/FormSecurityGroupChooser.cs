// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormSecurityGroupChooser
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

public class FormSecurityGroupChooser : Form
{
  private IContainer components;
  private ColumnHeader ColumnHeader1;
  private ColumnHeader ColumnHeader2;
  private ImageList ImageList1;
  private SqlDataAdapter daGroups;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cnSQL;
  private dsSecurityGroupsChooser DsSecurityGroupsChooser;
  private List<Guid> _excludedGuids;
  private List<Guid> _groupList;

  public FormSecurityGroupChooser()
  {
    this.Load += new EventHandler(this.FormSecurityGroupChooser_Load);
    this._excludedGuids = new List<Guid>();
    this._groupList = new List<Guid>();
    this.InitializeComponent();
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

  private virtual ListView lvGroups
  {
    get => this._lvGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lvGroups_DoubleClick);
      ListView lvGroups1 = this._lvGroups;
      if (lvGroups1 != null)
        lvGroups1.DoubleClick -= eventHandler;
      this._lvGroups = value;
      ListView lvGroups2 = this._lvGroups;
      if (lvGroups2 == null)
        return;
      lvGroups2.DoubleClick += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (FormSecurityGroupChooser));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.lvGroups = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.ImageList1 = new ImageList(this.components);
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.daGroups = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.DsSecurityGroupsChooser = new dsSecurityGroupsChooser();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.DsSecurityGroupsChooser.BeginInit();
    this.SuspendLayout();
    this.lvGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lvGroups.BackColor = Color.White;
    this.lvGroups.BorderStyle = BorderStyle.FixedSingle;
    this.lvGroups.Columns.AddRange(new ColumnHeader[2]
    {
      this.ColumnHeader1,
      this.ColumnHeader2
    });
    this.lvGroups.ForeColor = Color.Black;
    this.lvGroups.LargeImageList = this.ImageList1;
    this.lvGroups.Location = new Point(8, 8);
    this.lvGroups.Name = "lvGroups";
    this.lvGroups.Size = new Size(456, 368);
    this.lvGroups.SmallImageList = this.ImageList1;
    this.lvGroups.TabIndex = 5;
    this.lvGroups.View = View.Details;
    this.ColumnHeader1.Text = "Group";
    this.ColumnHeader1.Width = 211;
    this.ColumnHeader2.Text = "Description";
    this.ColumnHeader2.Width = 233;
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOK).Location = new Point(312, 384);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(75, 22);
    ((Control) this.btnOK).TabIndex = 4;
    ((ControlBase) this.btnOK).Text = "OK";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnCancel).Location = new Point(392, 384);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(75, 22);
    ((Control) this.btnCancel).TabIndex = 3;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.daGroups.SelectCommand = this.SqlSelectCommand1;
    this.daGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSecurityGroups", new DataColumnMapping[3]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("GroupGuid", "GroupGuid"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT Name, GroupGuid, Description FROM tblSecurityGroups";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.DsSecurityGroupsChooser.DataSetName = "dsSecurityGroupsChooser";
    this.DsSecurityGroupsChooser.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(472, 414);
    this.Controls.Add((Control) this.lvGroups);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormSecurityGroupChooser);
    this.Text = "Group Chooser";
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.DsSecurityGroupsChooser.EndInit();
    this.ResumeLayout(false);
  }

  public FormSecurityGroupChooser(Guid[] excludedUserGuids)
  {
    this.Load += new EventHandler(this.FormSecurityGroupChooser_Load);
    this._excludedGuids = new List<Guid>();
    this._groupList = new List<Guid>();
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

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public List<Guid> GroupsPicked => this._groupList;

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void FormSecurityGroupChooser_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = Database.Instance.ConnectionString;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.CancelButton = (IButtonControl) this.btnCancel;
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daGroups", this.daGroups, new TableQueryMultithreadEventHandler(this.groups_tableFilled), (DataTable) this.DsSecurityGroupsChooser.tblSecurityGroups);
  }

  private void groups_tableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    try
    {
      foreach (dsSecurityGroupsChooser.tblSecurityGroupsRow row in e.Table.Rows)
      {
        if (!this._excludedGuids.Contains(row.GroupGuid))
          this.lvGroups.Items.Add((ListViewItem) new FormSecurityGroupChooser.GroupListViewItem(row));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    try
    {
      foreach (FormSecurityGroupChooser.GroupListViewItem selectedItem in this.lvGroups.SelectedItems)
        this._groupList.Add(selectedItem.GroupGuid);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DialogResult = DialogResult.OK;
  }

  private void lvGroups_DoubleClick(object sender, EventArgs e)
  {
    try
    {
      foreach (FormSecurityGroupChooser.GroupListViewItem selectedItem in this.lvGroups.SelectedItems)
      {
        this.lvGroups.Items.Remove((ListViewItem) selectedItem);
        this.SecurityUserMemberListForm.ExternalAddGroup(selectedItem.GroupGuid);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private FormSecurityUserMemberList SecurityUserMemberListForm
  {
    get => (FormSecurityUserMemberList) this.Owner;
  }

  private sealed class GroupListViewItem : ListViewItem
  {
    private Guid _groupGuid;

    public GroupListViewItem(dsSecurityGroupsChooser.tblSecurityGroupsRow row)
      : base(row.Name)
    {
      this.ImageIndex = 0;
      this._groupGuid = row.GroupGuid;
      this.SubItems.Add(row.Description);
    }

    public Guid GroupGuid => this._groupGuid;
  }
}
