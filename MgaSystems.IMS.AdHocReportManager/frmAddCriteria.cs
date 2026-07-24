// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmAddCriteria
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class frmAddCriteria : Form
{
  private DataTable _dt = new DataTable();
  private string _resultCriteria;
  private int documentAutomationGroup;
  private IContainer components;
  private DataGridView dataGridView1;
  private Button btnCancel;
  private Button btnOk;

  public frmAddCriteria(int documentAutomationGroup)
  {
    this.InitializeComponent();
    this.documentAutomationGroup = documentAutomationGroup;
  }

  private void frmAddCriteria_Load(object sender, EventArgs e)
  {
    this._dt = new lstAdHocControls().GetAdHocControlGroups(this.documentAutomationGroup);
    this.dataGridView1.DataSource = (object) this._dt;
    foreach (DataGridViewColumn column in (BaseCollection) this.dataGridView1.Columns)
    {
      if (column.Name != "ControlName")
        column.Visible = false;
      else
        column.Width = 345;
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  public string ResultCriteria
  {
    get => this._resultCriteria;
    private set => this._resultCriteria = value;
  }

  private void btnOk_Click(object sender, EventArgs e) => this.SelectAndReturn();

  private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    this.SelectAndReturn();
  }

  private void SelectAndReturn()
  {
    if (this.dataGridView1.SelectedRows.Count < 1)
    {
      int num = (int) MessageBox.Show("Please select report to open", "Nothing selected", MessageBoxButtons.OK);
    }
    else
    {
      this._resultCriteria = "";
      this._dt = new lstAdHocControls().GetAdHocControls("ControlID = " + ((int) this.dataGridView1.SelectedCells[0].Value).ToString(), 1, this.documentAutomationGroup);
      for (int columnIndex = 0; columnIndex < this._dt.Columns.Count; ++columnIndex)
        this._resultCriteria = $"{this._resultCriteria}{this._dt.Rows[0][columnIndex].ToString()};";
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
  {
    this.SelectAndReturn();
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
    this.dataGridView1.Location = new Point(12, 12);
    this.dataGridView1.MultiSelect = false;
    this.dataGridView1.Name = "dataGridView1";
    this.dataGridView1.ReadOnly = true;
    this.dataGridView1.RowTemplate.ReadOnly = true;
    this.dataGridView1.ScrollBars = ScrollBars.Vertical;
    this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dataGridView1.Size = new Size(403, 211);
    this.dataGridView1.TabIndex = 0;
    this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
    this.dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
    this.dataGridView1.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
    this.dataGridView1.DoubleClick += new EventHandler(this.btnOk_Click);
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
    this.Name = nameof (frmAddCriteria);
    this.Text = "Add Criterion";
    this.Load += new EventHandler(this.frmAddCriteria_Load);
    ((ISupportInitialize) this.dataGridView1).EndInit();
    this.ResumeLayout(false);
  }
}
