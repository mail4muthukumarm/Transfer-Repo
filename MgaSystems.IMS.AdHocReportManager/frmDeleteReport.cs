// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmDeleteReport
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using MGASystems.Common.DataAccess;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class frmDeleteReport : Form
{
  private DataTable _dt = new DataTable();
  private Guid _resultGUID;
  private ucPermissions prmissions;
  private IContainer components;
  private DataGridView dataGridView1;
  private Button btnCancel;
  private Button btnOk;
  private DataGridViewTextBoxColumn ReportGUID;
  private DataGridViewTextBoxColumn ReportName;
  private DataGridViewTextBoxColumn GroupName;
  private DataGridViewTextBoxColumn DocumentAutomationGroup;

  public frmDeleteReport(ucPermissions perm)
  {
    this.InitializeComponent();
    this.prmissions = perm;
  }

  private void frmDeleteReport_Load(object sender, EventArgs e)
  {
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT [ReportGUID], [ReportName], [GroupName], [DocumentAutomationGroup] FROM [dbo].[tblAdHocReports]  ORDER BY [ReportName]");
    this.dataGridView1.DataSource = (object) this._dt;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (this.dataGridView1.SelectedRows.Count < 1)
    {
      int num1 = (int) MessageBox.Show("Please select report to delete", "Nothing selected", MessageBoxButtons.OK);
    }
    else
    {
      if (this.dataGridView1.SelectedRows.Count == 1)
      {
        string str = this.dataGridView1.SelectedCells[0].Value.ToString();
        int result = 0;
        int.TryParse(this.dataGridView1.SelectedCells[3].Value.ToString(), out result);
        if (result > 0)
        {
          if (this.RUSureToDeleteAutomationDoc(str))
          {
            this.DeleteAutomationDoc(str);
            this.prmissions.WipeSecurityResource(new Guid(str));
            this.Close();
            return;
          }
        }
        else if (MessageBox.Show($"Are you sure you want to delete report '{this.dataGridView1.SelectedCells[1].Value.ToString()}'", $"Deleting '{this.dataGridView1.SelectedCells[1].Value.ToString()}'", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM [dbo].[tblAdHocReports] WHERE  [ReportGUID]=@reportGUID", new object[2]
          {
            (object) "@reportGUID",
            (object) str
          });
          this.prmissions.WipeSecurityResource(new Guid(str));
          this.Close();
          return;
        }
      }
      if (this.dataGridView1.SelectedRows.Count <= 1)
        return;
      int num2 = (int) MessageBox.Show("Cannot delete multiple reports!", "Error", MessageBoxButtons.OK);
    }
  }

  private void DeleteAutomationDoc(string repGuid)
  {
    Database.Instance.QueryText.PerformNonQuery("DELETE FROM tblCompanyAutomationDocuments WHERE AutomationReportGuid = @AutomationReportGuid", (object) "@AutomationReportGuid", (object) repGuid);
    Database.Instance.QueryText.PerformNonQuery("DELETE FROM tblCompanyAutomationDocuments WHERE AutomationReportGuid = @AutomationReportGuid", (object) "@AutomationReportGuid", (object) repGuid);
  }

  private bool RUSureToDeleteAutomationDoc(string repGuid)
  {
    string queryText1 = "SELECT IsNull(tblCompanyLocations.LocationName, 'Some Company') + IsNull(' - ' + lstLines.LineName,'') CompanyLine FROM lstLines      INNER JOIN tblCompanyLines ON lstLines.LineGUID = tblCompanyLines.LineGUID      INNER JOIN tblCompanyLocations ON tblCompanyLines.CompanyLocationGUID = tblCompanyLocations.CompanyLocationGUID      RIGHT OUTER JOIN tblCompanyAutomationDocuments ON tblCompanyLines.CompanyLineGUID = tblCompanyAutomationDocuments.CompanyLineGuid WHERE(tblCompanyAutomationDocuments.AutomationReportGuid = @AutomationReportGuid)";
    string queryText2 = "SELECT FormName FROM tblPolicyForms WHERE AutomationReportGuid = @AutomationReportGuid";
    DataTable dataTable1 = Database.Instance.QueryText.PerformTableQuery(queryText1, (object) "@AutomationReportGuid", (object) repGuid);
    DataTable dataTable2 = Database.Instance.QueryText.PerformTableQuery(queryText2, (object) "@AutomationReportGuid", (object) repGuid);
    string text = "";
    string str = "";
    foreach (DataRow row in (InternalDataCollectionBase) dataTable1.Rows)
      text = $"{text}\t{row["CompanyLine"].ToString()}\r\n";
    foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      str = $"{str}\t{row["FormName"].ToString()}\r\n";
    if (text != "")
      text = "Following Company Automation Documents  based on this report:\r\n" + text;
    if (str != "")
      text = $"{text}\r\nFollowing Policy forms based on this document:\r\n{str}";
    if (text != "")
      text += "\r\n\r\nAll these settings will be deleted! Do you want to continue?";
    if (text == "")
      text = $"Are you sure you want to delete report '{this.dataGridView1.SelectedCells[1].Value.ToString()}'?";
    return MessageBox.Show(text, "Deleting Automation Document", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
  }

  public Guid ResultGuid
  {
    get => this._resultGUID;
    private set => this._resultGUID = value;
  }

  private void dataGridView1_SelectionChanged(object sender, EventArgs e)
  {
    if (this.dataGridView1.SelectedRows.Count != 1)
      return;
    this.btnOk.Enabled = true;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.dataGridView1 = new DataGridView();
    this.btnCancel = new Button();
    this.btnOk = new Button();
    this.ReportGUID = new DataGridViewTextBoxColumn();
    this.ReportName = new DataGridViewTextBoxColumn();
    this.GroupName = new DataGridViewTextBoxColumn();
    this.DocumentAutomationGroup = new DataGridViewTextBoxColumn();
    ((ISupportInitialize) this.dataGridView1).BeginInit();
    this.SuspendLayout();
    this.dataGridView1.AllowUserToAddRows = false;
    this.dataGridView1.AllowUserToDeleteRows = false;
    this.dataGridView1.AllowUserToOrderColumns = true;
    this.dataGridView1.AllowUserToResizeColumns = false;
    this.dataGridView1.AllowUserToResizeRows = false;
    this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
    this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dataGridView1.ColumnHeadersVisible = false;
    this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.ReportGUID, (DataGridViewColumn) this.ReportName, (DataGridViewColumn) this.GroupName, (DataGridViewColumn) this.DocumentAutomationGroup);
    this.dataGridView1.Location = new Point(12, 12);
    this.dataGridView1.MultiSelect = false;
    this.dataGridView1.Name = "dataGridView1";
    this.dataGridView1.ReadOnly = true;
    this.dataGridView1.RowTemplate.ReadOnly = true;
    this.dataGridView1.ScrollBars = ScrollBars.Vertical;
    this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dataGridView1.Size = new Size(403, 211);
    this.dataGridView1.TabIndex = 0;
    this.dataGridView1.SelectionChanged += new EventHandler(this.dataGridView1_SelectionChanged);
    this.btnCancel.DialogResult = DialogResult.Cancel;
    this.btnCancel.Location = new Point(228, 238);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(75, 23);
    this.btnCancel.TabIndex = 1;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnOk.Enabled = false;
    this.btnOk.Location = new Point(124, 238);
    this.btnOk.Name = "btnOk";
    this.btnOk.Size = new Size(75, 23);
    this.btnOk.TabIndex = 2;
    this.btnOk.Text = "Delete";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnOk.Click += new EventHandler(this.btnOk_Click);
    this.ReportGUID.DataPropertyName = "ReportGUID";
    this.ReportGUID.HeaderText = "ReportGUID";
    this.ReportGUID.Name = "ReportGUID";
    this.ReportGUID.ReadOnly = true;
    this.ReportGUID.Visible = false;
    this.ReportGUID.Width = 5;
    this.ReportName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.ReportName.DataPropertyName = "ReportName";
    this.ReportName.HeaderText = "ReportName";
    this.ReportName.Name = "ReportName";
    this.ReportName.ReadOnly = true;
    this.GroupName.DataPropertyName = "GroupName";
    this.GroupName.HeaderText = "GroupName";
    this.GroupName.Name = "GroupName";
    this.GroupName.ReadOnly = true;
    this.DocumentAutomationGroup.DataPropertyName = "DocumentAutomationGroup";
    this.DocumentAutomationGroup.HeaderText = "DocumentAutomationGroup";
    this.DocumentAutomationGroup.Name = "DocumentAutomationGroup";
    this.DocumentAutomationGroup.ReadOnly = true;
    this.DocumentAutomationGroup.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(427, 273);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.dataGridView1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmDeleteReport);
    this.Text = "Delete Report";
    this.Load += new EventHandler(this.frmDeleteReport_Load);
    ((ISupportInitialize) this.dataGridView1).EndInit();
    this.ResumeLayout(false);
  }
}
