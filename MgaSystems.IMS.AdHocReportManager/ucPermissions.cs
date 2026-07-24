// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.ucPermissions
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using MGASystems.Data;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class ucPermissions : UserControl
{
  private DataTable _dtUserPerms;
  private DataTable _dtGroupPerms;
  private Guid _reportGuid;
  private AdHocReport _Report;
  private bool isLoaded;
  private IContainer components;
  private TabControl tabControl1;
  private TabPage tabPage1;
  private DataGridView dgvGroupPermissions;
  private TabPage tabPage2;
  private Label label1;
  private DataGridView dgvUserPermissions;
  private Label label2;
  private DataGridViewCheckBoxColumn Allow;
  private DataGridViewCheckBoxColumn Deny;
  private DataGridViewTextBoxColumn GroupName;
  private DataGridViewTextBoxColumn Description;
  private DataGridViewTextBoxColumn GroupGUID;
  private DataGridViewCheckBoxColumn AllowU;
  private DataGridViewCheckBoxColumn DenyU;
  private DataGridViewTextBoxColumn NameU;
  private DataGridViewTextBoxColumn DescriptionU;
  private DataGridViewTextBoxColumn UserGUIDU;

  public ucPermissions() => this.InitializeComponent();

  public void InitPermissions(AdHocReport Report)
  {
    this._Report = Report;
    this._reportGuid = Report.GUID;
    this.PopulateGroupsTable();
    this.PopulateUsersTable();
    this.isLoaded = true;
  }

  public void CreateSecurityResource() => this.CreateSecurityResource(this._Report);

  public void CreateSecurityResource(AdHocReport Rep)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM lstSecurityResources WHERE ResourceGUID=@resGUID", new object[2]
    {
      (object) "@resGUID",
      (object) Rep.GUID
    }) > 0)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE lstSecurityResources SET [Name]=@resName,[Description]=@resDesc WHERE ResourceGUID=@resGUID", new object[6]
      {
        (object) "@resName",
        (object) Rep.ReportName,
        (object) "@resDesc",
        (object) ("Control access to the " + Rep.ReportName),
        (object) "@resGUID",
        (object) Rep.GUID
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO lstSecurityResources([ResourceGUID],[Name],[Description],[IsDynamicResource]) VALUES (@resGUID,@resName,@resDesc,0)", new object[6]
      {
        (object) "@resName",
        (object) Rep.ReportName,
        (object) "@resDesc",
        (object) ("Control access to the " + Rep.ReportName),
        (object) "@resGUID",
        (object) Rep.GUID
      });
  }

  public void UpdateSecurityResourceName() => this.UpdateSecurityResourceName(this._Report);

  public void UpdateSecurityResourceName(AdHocReport Rep)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM lstSecurityResources WHERE ResourceGUID=@resGUID", new object[2]
    {
      (object) "@resGUID",
      (object) Rep.GUID
    }) <= 0)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE lstSecurityResources SET [Name]=@resName,[Description]=@resDesc WHERE ResourceGUID=@resGUID", new object[6]
    {
      (object) "@resName",
      (object) Rep.ReportName,
      (object) "@resDesc",
      (object) ("Control access to the " + Rep.Description),
      (object) "@resGUID",
      (object) Rep.GUID
    });
  }

  public bool isPermissionSet()
  {
    for (int index = 0; index < this.dgvGroupPermissions.Rows.Count; ++index)
    {
      if ((int) this.dgvGroupPermissions.Rows[index].Cells[0].Value == 1 || (int) this.dgvGroupPermissions.Rows[index].Cells[1].Value == 1)
        return true;
    }
    for (int index = 0; index < this.dgvUserPermissions.Rows.Count; ++index)
    {
      if ((int) this.dgvUserPermissions.Rows[index].Cells[0].Value == 1 || (int) this.dgvUserPermissions.Rows[index].Cells[1].Value == 1)
        return true;
    }
    return false;
  }

  public void WipeSecurityResource() => this.WipeSecurityResource(this._reportGuid);

  public void WipeSecurityResource(Guid repGuid)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblSecurityUsersGroupsPermissions WHERE ResourceGUID=@resGUID", new object[2]
    {
      (object) "@resGUID",
      (object) repGuid
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM lstSecurityResources WHERE ResourceGUID=@resGUID", new object[2]
    {
      (object) "@resGUID",
      (object) repGuid
    });
  }

  private void PopulateGroupsTable()
  {
    string str = "SELECT IsNull((SELECT TOP 1 CASE WHEN p.PermissionBits=1 THEN 1 ELSE 0 END FROM tblSecurityUsersGroupsPermissions p WHERE p.ResourceGUID=@reportguid and sg.GroupGUID = p.GroupGUID),0) as Allow, " + "IsNull((SELECT TOP 1 CASE WHEN p.PermissionBits=1 THEN 0 ELSE 1 END FROM tblSecurityUsersGroupsPermissions p WHERE p.ResourceGUID=@reportguid and sg.GroupGUID = p.GroupGUID),0) as [Deny], " + "sg.Name, sg.Description, sg.GroupGUID " + "FROM\t\ttblSecurityGroups sg ORDER BY sg.Name";
    this._dtGroupPerms = new DataTable("GroupPerms");
    this._dtGroupPerms.Columns.Add("Allow", Type.GetType("System.Boolean"));
    this._dtGroupPerms.Columns.Add("Deny", Type.GetType("System.Boolean"));
    this._dtGroupPerms.Columns.Add("Name", Type.GetType("System.String"));
    this._dtGroupPerms.Columns.Add("Description", Type.GetType("System.String"));
    this._dtGroupPerms.Columns.Add("GroupGUID", Type.GetType("System.Guid"));
    this._dtGroupPerms = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[2]
    {
      (object) "@reportguid",
      (object) this._reportGuid
    });
    this.dgvGroupPermissions.DataSource = (object) this._dtGroupPerms;
    this.label1.DataBindings.Clear();
    this.label1.DataBindings.Add("Text", (object) this._dtGroupPerms, "Description");
  }

  private void PopulateUsersTable()
  {
    string str = "SELECT IsNull((SELECT TOP 1 CASE WHEN p.PermissionBits=1 THEN 1 ELSE 0 END FROM tblSecurityUsersGroupsPermissions p WHERE p.ResourceGUID=@reportguid and tblUsers.UserGUID = p.UserGUID),0) as Allow, " + "IsNull((SELECT TOP 1 CASE WHEN p.PermissionBits=1 THEN 0 ELSE 1 END FROM tblSecurityUsersGroupsPermissions p WHERE p.ResourceGUID=@reportguid and tblUsers.UserGUID = p.UserGUID),0) as [Deny], " + "tblUsers.LastName + @comma + tblUsers.FirstName as Name, tblUsers.Title as Description, tblUsers.UserGUID " + "FROM tblUsers ORDER BY LastName, FirstName";
    this._dtUserPerms = new DataTable("UserPerms");
    this._dtUserPerms.Columns.Add("Allow", Type.GetType("System.Boolean"));
    this._dtUserPerms.Columns.Add("Deny", Type.GetType("System.Boolean"));
    this._dtUserPerms.Columns.Add("Name", Type.GetType("System.String"));
    this._dtUserPerms.Columns.Add("Description", Type.GetType("System.String"));
    this._dtUserPerms.Columns.Add("UserGUID", Type.GetType("System.Guid"));
    this._dtUserPerms = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[4]
    {
      (object) "@reportguid",
      (object) this._reportGuid,
      (object) "@comma",
      (object) ", "
    });
    this.dgvUserPermissions.DataSource = (object) this._dtUserPerms;
    this.label2.DataBindings.Clear();
    this.label2.DataBindings.Add("Text", (object) this._dtGroupPerms, "Description");
  }

  private void SetPermissions(string operation, string field, Guid entity)
  {
    this.CreateSecurityResource(this._Report);
    switch (operation)
    {
      case "clear":
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM tblSecurityUsersGroupsPermissions WHERE ResourceGUID=@resGUID and {field}= @entity", new object[4]
        {
          (object) "@resGUID",
          (object) this._reportGuid,
          (object) "@entity",
          (object) entity
        });
        break;
      case "allow":
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, (int) DefaultDatabase.ExecuteScalar(CommandType.Text, $"SELECT COUNT(*) FROM tblSecurityUsersGroupsPermissions WHERE ResourceGUID=@resGUID and {field}= @entity", new object[4]
        {
          (object) "@resGUID",
          (object) this._reportGuid,
          (object) "@entity",
          (object) entity
        }) <= 0 ? $"INSERT INTO tblSecurityUsersGroupsPermissions (ResourceGUID,PermissionBits,{field}) VALUES (@resGUID ,1, @entity)" : $"UPDATE tblSecurityUsersGroupsPermissions SET PermissionBits=1 WHERE ResourceGUID=@resGUID and {field}= @entity", new object[4]
        {
          (object) "@resGUID",
          (object) this._reportGuid,
          (object) "@entity",
          (object) entity
        });
        break;
      case "deny":
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, (int) DefaultDatabase.ExecuteScalar(CommandType.Text, $"SELECT COUNT(*) FROM tblSecurityUsersGroupsPermissions WHERE ResourceGUID=@resGUID and {field}= @entity", new object[4]
        {
          (object) "@resGUID",
          (object) this._reportGuid,
          (object) "@entity",
          (object) entity
        }) <= 0 ? $"INSERT INTO tblSecurityUsersGroupsPermissions (ResourceGUID,PermissionBits,{field}) VALUES (@resGUID ,0, @entity)" : $"UPDATE tblSecurityUsersGroupsPermissions SET PermissionBits=0 WHERE ResourceGUID=@resGUID and {field}= @entity", new object[4]
        {
          (object) "@resGUID",
          (object) this._reportGuid,
          (object) "@entity",
          (object) entity
        });
        break;
    }
  }

  private void GridPermissions_CurrentCellDirtyStateChanged(object sender, EventArgs e)
  {
    DataGridView dataGridView = (DataGridView) sender;
    if (!dataGridView.IsCurrentCellDirty)
      return;
    dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
  }

  private void GridPermissions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
  {
    if (!this.isLoaded || e.ColumnIndex > 1)
      return;
    DataGridView dataGridView = (DataGridView) sender;
    if (dataGridView.CurrentCell.ColumnIndex == 0 && (int) dataGridView.Rows[e.RowIndex].Cells[1].Value == 1 && (int) dataGridView.Rows[e.RowIndex].Cells[0].Value == 1)
      dataGridView.Rows[e.RowIndex].Cells[1].Value = (object) 0;
    if (dataGridView.CurrentCell.ColumnIndex == 1 && (int) dataGridView.Rows[e.RowIndex].Cells[1].Value == 1 && (int) dataGridView.Rows[e.RowIndex].Cells[0].Value == 1)
      dataGridView.Rows[e.RowIndex].Cells[0].Value = (object) 0;
    string operation = "clear";
    Guid entity = (Guid) dataGridView.Rows[e.RowIndex].Cells[4].Value;
    if ((int) dataGridView.Rows[e.RowIndex].Cells[0].Value == 1)
      operation = "allow";
    if ((int) dataGridView.Rows[e.RowIndex].Cells[1].Value == 1)
      operation = "deny";
    string field;
    if (dataGridView.Name == "dgvGroupPermissions")
      field = "GroupGUID";
    else if (dataGridView.Name == "dgvUserPermissions")
    {
      field = "UserGUID";
    }
    else
    {
      int num = (int) MessageBox.Show("Wrong data field name. Cannot continue saving permissions.");
      return;
    }
    this.SetPermissions(operation, field, entity);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.tabControl1 = new TabControl();
    this.tabPage1 = new TabPage();
    this.dgvGroupPermissions = new DataGridView();
    this.Allow = new DataGridViewCheckBoxColumn();
    this.Deny = new DataGridViewCheckBoxColumn();
    this.GroupName = new DataGridViewTextBoxColumn();
    this.Description = new DataGridViewTextBoxColumn();
    this.GroupGUID = new DataGridViewTextBoxColumn();
    this.label1 = new Label();
    this.tabPage2 = new TabPage();
    this.dgvUserPermissions = new DataGridView();
    this.AllowU = new DataGridViewCheckBoxColumn();
    this.DenyU = new DataGridViewCheckBoxColumn();
    this.NameU = new DataGridViewTextBoxColumn();
    this.DescriptionU = new DataGridViewTextBoxColumn();
    this.UserGUIDU = new DataGridViewTextBoxColumn();
    this.label2 = new Label();
    this.tabControl1.SuspendLayout();
    this.tabPage1.SuspendLayout();
    ((ISupportInitialize) this.dgvGroupPermissions).BeginInit();
    this.tabPage2.SuspendLayout();
    ((ISupportInitialize) this.dgvUserPermissions).BeginInit();
    this.SuspendLayout();
    this.tabControl1.Controls.Add((Control) this.tabPage1);
    this.tabControl1.Controls.Add((Control) this.tabPage2);
    this.tabControl1.Dock = DockStyle.Fill;
    this.tabControl1.Location = new Point(0, 0);
    this.tabControl1.Name = "tabControl1";
    this.tabControl1.SelectedIndex = 0;
    this.tabControl1.Size = new Size(310, 199);
    this.tabControl1.TabIndex = 0;
    this.tabPage1.Controls.Add((Control) this.dgvGroupPermissions);
    this.tabPage1.Controls.Add((Control) this.label1);
    this.tabPage1.Location = new Point(4, 22);
    this.tabPage1.Name = "tabPage1";
    this.tabPage1.Padding = new Padding(3);
    this.tabPage1.Size = new Size(302, 173);
    this.tabPage1.TabIndex = 0;
    this.tabPage1.Text = "Groups";
    this.tabPage1.UseVisualStyleBackColor = true;
    this.dgvGroupPermissions.AllowUserToAddRows = false;
    this.dgvGroupPermissions.AllowUserToDeleteRows = false;
    this.dgvGroupPermissions.AllowUserToResizeRows = false;
    this.dgvGroupPermissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvGroupPermissions.Columns.AddRange((DataGridViewColumn) this.Allow, (DataGridViewColumn) this.Deny, (DataGridViewColumn) this.GroupName, (DataGridViewColumn) this.Description, (DataGridViewColumn) this.GroupGUID);
    this.dgvGroupPermissions.Dock = DockStyle.Fill;
    this.dgvGroupPermissions.Location = new Point(3, 3);
    this.dgvGroupPermissions.Name = "dgvGroupPermissions";
    this.dgvGroupPermissions.RowHeadersVisible = false;
    this.dgvGroupPermissions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    this.dgvGroupPermissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dgvGroupPermissions.Size = new Size(296, 154);
    this.dgvGroupPermissions.TabIndex = 0;
    this.dgvGroupPermissions.CellValueChanged += new DataGridViewCellEventHandler(this.GridPermissions_CellValueChanged);
    this.dgvGroupPermissions.CurrentCellDirtyStateChanged += new EventHandler(this.GridPermissions_CurrentCellDirtyStateChanged);
    this.Allow.DataPropertyName = "Allow";
    this.Allow.FalseValue = (object) "0";
    this.Allow.HeaderText = "Allow";
    this.Allow.IndeterminateValue = (object) "2";
    this.Allow.Name = "Allow";
    this.Allow.TrueValue = (object) "1";
    this.Allow.Width = 40;
    this.Deny.DataPropertyName = "Deny";
    this.Deny.FalseValue = (object) "0";
    this.Deny.HeaderText = "Deny";
    this.Deny.IndeterminateValue = (object) "2";
    this.Deny.Name = "Deny";
    this.Deny.TrueValue = (object) "1";
    this.Deny.Width = 40;
    this.GroupName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.GroupName.DataPropertyName = "Name";
    this.GroupName.HeaderText = "Name";
    this.GroupName.Name = "GroupName";
    this.GroupName.ReadOnly = true;
    this.Description.DataPropertyName = "Description";
    this.Description.HeaderText = "Description";
    this.Description.Name = "Description";
    this.Description.ReadOnly = true;
    this.Description.Visible = false;
    this.GroupGUID.DataPropertyName = "GroupGUID";
    this.GroupGUID.HeaderText = "GroupGUID";
    this.GroupGUID.Name = "GroupGUID";
    this.GroupGUID.ReadOnly = true;
    this.GroupGUID.Visible = false;
    this.label1.AutoSize = true;
    this.label1.Dock = DockStyle.Bottom;
    this.label1.Location = new Point(3, 157);
    this.label1.Name = "label1";
    this.label1.Size = new Size(10, 13);
    this.label1.TabIndex = 1;
    this.label1.Text = " ";
    this.tabPage2.Controls.Add((Control) this.dgvUserPermissions);
    this.tabPage2.Controls.Add((Control) this.label2);
    this.tabPage2.Location = new Point(4, 22);
    this.tabPage2.Name = "tabPage2";
    this.tabPage2.Padding = new Padding(3);
    this.tabPage2.Size = new Size(302, 173);
    this.tabPage2.TabIndex = 1;
    this.tabPage2.Text = "Users";
    this.tabPage2.UseVisualStyleBackColor = true;
    this.dgvUserPermissions.AllowUserToAddRows = false;
    this.dgvUserPermissions.AllowUserToDeleteRows = false;
    this.dgvUserPermissions.AllowUserToResizeRows = false;
    this.dgvUserPermissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvUserPermissions.Columns.AddRange((DataGridViewColumn) this.AllowU, (DataGridViewColumn) this.DenyU, (DataGridViewColumn) this.NameU, (DataGridViewColumn) this.DescriptionU, (DataGridViewColumn) this.UserGUIDU);
    this.dgvUserPermissions.Dock = DockStyle.Fill;
    this.dgvUserPermissions.Location = new Point(3, 3);
    this.dgvUserPermissions.Name = "dgvUserPermissions";
    this.dgvUserPermissions.RowHeadersVisible = false;
    this.dgvUserPermissions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
    this.dgvUserPermissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dgvUserPermissions.Size = new Size(296, 154);
    this.dgvUserPermissions.TabIndex = 1;
    this.dgvUserPermissions.CellValueChanged += new DataGridViewCellEventHandler(this.GridPermissions_CellValueChanged);
    this.dgvUserPermissions.CurrentCellDirtyStateChanged += new EventHandler(this.GridPermissions_CurrentCellDirtyStateChanged);
    this.AllowU.DataPropertyName = "Allow";
    this.AllowU.FalseValue = (object) "0";
    this.AllowU.HeaderText = "Allow";
    this.AllowU.IndeterminateValue = (object) "2";
    this.AllowU.Name = "AllowU";
    this.AllowU.TrueValue = (object) "1";
    this.AllowU.Width = 40;
    this.DenyU.DataPropertyName = "Deny";
    this.DenyU.FalseValue = (object) "0";
    this.DenyU.HeaderText = "Deny";
    this.DenyU.IndeterminateValue = (object) "2";
    this.DenyU.Name = "DenyU";
    this.DenyU.TrueValue = (object) "1";
    this.DenyU.Width = 40;
    this.NameU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.NameU.DataPropertyName = "Name";
    this.NameU.HeaderText = "Name";
    this.NameU.Name = "NameU";
    this.NameU.ReadOnly = true;
    this.DescriptionU.DataPropertyName = "Description";
    this.DescriptionU.HeaderText = "Description";
    this.DescriptionU.Name = "DescriptionU";
    this.DescriptionU.ReadOnly = true;
    this.DescriptionU.Visible = false;
    this.UserGUIDU.DataPropertyName = "UserGUID";
    this.UserGUIDU.HeaderText = "UserGUID";
    this.UserGUIDU.Name = "UserGUIDU";
    this.UserGUIDU.ReadOnly = true;
    this.UserGUIDU.Visible = false;
    this.label2.AutoSize = true;
    this.label2.Dock = DockStyle.Bottom;
    this.label2.Location = new Point(3, 157);
    this.label2.Name = "label2";
    this.label2.Size = new Size(10, 13);
    this.label2.TabIndex = 2;
    this.label2.Text = " ";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.tabControl1);
    this.Name = nameof (ucPermissions);
    this.Size = new Size(310, 199);
    this.tabControl1.ResumeLayout(false);
    this.tabPage1.ResumeLayout(false);
    this.tabPage1.PerformLayout();
    ((ISupportInitialize) this.dgvGroupPermissions).EndInit();
    this.tabPage2.ResumeLayout(false);
    this.tabPage2.PerformLayout();
    ((ISupportInitialize) this.dgvUserPermissions).EndInit();
    this.ResumeLayout(false);
  }
}
