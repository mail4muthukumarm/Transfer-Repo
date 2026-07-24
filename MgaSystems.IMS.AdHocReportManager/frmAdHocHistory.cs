// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmAdHocHistory
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

public class frmAdHocHistory : Form
{
  private string AdHocLogGUID = "BCD1C964-CF95-44CB-AB61-F37D10747222";
  private DataTable _dt = new DataTable();
  private string _reportName;
  private Guid _reportGuid;
  private bool _ShowAll;
  private IContainer components;
  private DataGridView dataGridView1;

  public frmAdHocHistory()
  {
    this.InitializeComponent();
    this._ShowAll = true;
  }

  public frmAdHocHistory(Guid reportGuid, string reportName)
  {
    this.InitializeComponent();
    this._ShowAll = false;
    this._reportGuid = reportGuid;
    this._reportName = reportName;
  }

  private void frmAdHocHistory_Load(object sender, EventArgs e)
  {
    string cmdText = " SELECT CONVERT(varchar(10), tblLog.ActionDate, 101) Date,  tblLog.Action, tblUsers.Name_FirstLast as [User], tblAdHocReports.ReportName as [Report Name] " + "FROM tblLog LEFT OUTER JOIN tblAdHocReports ON tblLog.Context = tblAdHocReports.ReportGUID " + "LEFT OUTER JOIN tblUsers ON tblLog.UserID = tblUsers.UserID " + $"WHERE (tblLog.IndentifierGuid = '{this.AdHocLogGUID}')";
    if (!this._ShowAll)
      cmdText += $" AND (tblLog.Context='{this._reportGuid.ToString()}')";
    using (SqlConnection connection = new SqlConnection(DefaultDatabase.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand(cmdText, connection))
      {
        connection.Open();
        this._dt.Load((IDataReader) sqlCommand.ExecuteReader());
      }
    }
    this.dataGridView1.DataSource = (object) this._dt;
    foreach (DataGridViewColumn column in (BaseCollection) this.dataGridView1.Columns)
    {
      if (column.Name == "Action")
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
    if (this._ShowAll)
      return;
    this.Text = "AdHoc History - " + this._reportName;
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
    this.dataGridView1.Dock = DockStyle.Fill;
    this.dataGridView1.Location = new Point(0, 0);
    this.dataGridView1.MultiSelect = false;
    this.dataGridView1.Name = "dataGridView1";
    this.dataGridView1.ReadOnly = true;
    this.dataGridView1.RowTemplate.ReadOnly = true;
    this.dataGridView1.ScrollBars = ScrollBars.Vertical;
    this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dataGridView1.Size = new Size(818, 266);
    this.dataGridView1.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(818, 266);
    this.Controls.Add((Control) this.dataGridView1);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmAdHocHistory);
    this.Text = "AdHoc History";
    this.Load += new EventHandler(this.frmAdHocHistory_Load);
    ((ISupportInitialize) this.dataGridView1).EndInit();
    this.ResumeLayout(false);
  }
}
