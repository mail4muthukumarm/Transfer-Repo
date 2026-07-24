// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmLoadReport
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class frmLoadReport : Form
{
  private DataTable _dt = new DataTable();
  private Guid _resultGUID;
  private IContainer components;
  private DataGridView dataGridView1;
  private Button btnCancel;
  private Button btnOk;
  private DataGridViewTextBoxColumn ReportGUID;
  private DataGridViewTextBoxColumn ReportName;
  private DataGridViewTextBoxColumn GroupName;

  public frmLoadReport() => this.InitializeComponent();

  private void frmLoadReport_Load(object sender, EventArgs e)
  {
    using (SqlConnection connection = new SqlConnection(DefaultDatabase.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("SELECT [ReportGUID], [ReportName], [GroupName] FROM [dbo].[tblAdHocReports]  ORDER BY [ReportName]", connection))
      {
        connection.Open();
        this._dt.Load((IDataReader) sqlCommand.ExecuteReader());
      }
    }
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
      int num = (int) MessageBox.Show("Please select report to open", "Nothing selected", MessageBoxButtons.OK);
    }
    else
    {
      this.ResultGuid = new Guid(this.dataGridView1.SelectedCells[0].Value.ToString());
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  public Guid ResultGuid
  {
    get => this._resultGUID;
    private set => this._resultGUID = value;
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
    this.ReportGUID = new DataGridViewTextBoxColumn();
    this.ReportName = new DataGridViewTextBoxColumn();
    this.GroupName = new DataGridViewTextBoxColumn();
    this.btnCancel = new Button();
    this.btnOk = new Button();
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
    this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.ReportGUID, (DataGridViewColumn) this.ReportName, (DataGridViewColumn) this.GroupName);
    this.dataGridView1.Location = new Point(12, 12);
    this.dataGridView1.MultiSelect = false;
    this.dataGridView1.Name = "dataGridView1";
    this.dataGridView1.ReadOnly = true;
    this.dataGridView1.RowTemplate.ReadOnly = true;
    this.dataGridView1.ScrollBars = ScrollBars.Vertical;
    this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dataGridView1.Size = new Size(403, 211);
    this.dataGridView1.TabIndex = 0;
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
    this.btnCancel.DialogResult = DialogResult.Cancel;
    this.btnCancel.Location = new Point(228, 238);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(75, 23);
    this.btnCancel.TabIndex = 1;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnOk.Location = new Point(124, 238);
    this.btnOk.Name = "btnOk";
    this.btnOk.Size = new Size(75, 23);
    this.btnOk.TabIndex = 2;
    this.btnOk.Text = "Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnOk.Click += new EventHandler(this.btnOk_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(427, 273);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.dataGridView1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmLoadReport);
    this.Text = "Load Report";
    this.Load += new EventHandler(this.frmLoadReport_Load);
    ((ISupportInitialize) this.dataGridView1).EndInit();
    this.ResumeLayout(false);
  }
}
