// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmControlNo
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class frmControlNo : Form
{
  private bool RequestQuoteOptions;
  public int cntrlno;
  public Guid QuoteGuid;
  public Guid[] QuoteOptionGuids;
  private IContainer components;
  private Button btnRefresh;
  private CheckedListBox lstOptions;
  private TextBox txtControlNo;
  private Label label1;
  private Panel panel1;
  private Button btnOk;
  private Button btnCancel;

  public frmControlNo(bool RequestQuoteOptions)
  {
    this.InitializeComponent();
    this.RequestQuoteOptions = RequestQuoteOptions;
    if (!RequestQuoteOptions)
      return;
    this.btnOk.Enabled = false;
  }

  private void frmControlNo_Load(object sender, EventArgs e)
  {
  }

  private void btnRefresh_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(this.txtControlNo.Text, out this.cntrlno))
    {
      int num = (int) MessageBox.Show("Control Number Should be Integer", "Input type error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      string str1 = "SELECT (SELECT DISTINCT QuoteGUID FROM tblQuotes WHERE QuoteID = IsNull(tblMaxQuoteIDs.MaxBoundQuoteID, tblMaxQuoteIDs.MaxQuoteID)) as QuoteGuid FROM  tblMaxQuoteIDs WHERE tblMaxQuoteIDs.ControlNo = @ControlNo";
      string str2 = "SELECT tblCompanyLocations.LocationName + ' ' + lstLines.LineCode + ' ' + CASE WHEN tblQuoteOptions.Bound = 1 THEN '(Bound)' ELSE '(Not Bound)' END AS Display, tblQuoteOptions.QuoteOptionGUID AS Value FROM tblQuoteOptions INNER JOIN lstLines ON tblQuoteOptions.LineGUID = lstLines.LineGUID INNER JOIN tblCompanyLocations ON tblQuoteOptions.CompanyLocationID = tblCompanyLocations.CompanyLocationCode WHERE tblQuoteOptions.QuoteGUID = @QuoteGUID";
      SqlConnection sqlConnection = new SqlConnection(DefaultDatabase.ConnectionString);
      if (sqlConnection.State != ConnectionState.Open)
        sqlConnection.Open();
      SqlCommand selectCommand = new SqlCommand();
      selectCommand.Connection = sqlConnection;
      selectCommand.CommandType = CommandType.Text;
      selectCommand.CommandText = str1;
      selectCommand.Parameters.AddWithValue("@ControlNo", (object) this.cntrlno);
      this.QuoteGuid = (Guid) selectCommand.ExecuteScalar();
      selectCommand.CommandText = str2;
      selectCommand.Parameters.Clear();
      selectCommand.Parameters.AddWithValue("@QuoteGUID", (object) this.QuoteGuid);
      DataTable dataTable = new DataTable();
      new SqlDataAdapter(selectCommand).Fill(dataTable);
      this.PopulateQuoteOptions(dataTable);
    }
  }

  private void PopulateQuoteOptions(DataTable dtOptions)
  {
    foreach (DataRow row in (InternalDataCollectionBase) dtOptions.Rows)
      this.lstOptions.Items.Add((object) new frmControlNo.QuoteOptionItem(new Guid(row["Value"].ToString()), row["Display"].ToString()));
  }

  private void txtControlNo_Validating(object sender, CancelEventArgs e)
  {
    if (int.TryParse(this.txtControlNo.Text, out int _))
      return;
    int num = (int) MessageBox.Show("Control Number Should be Integer", "Input type error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    e.Cancel = true;
  }

  private void lstOptions_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    int count = this.lstOptions.CheckedItems.Count;
    if ((e.NewValue != CheckState.Checked ? count - 1 : count + 1) > 0)
      this.btnOk.Enabled = true;
    else
      this.btnOk.Enabled = false;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    List<Guid> source = new List<Guid>();
    foreach (object checkedItem in this.lstOptions.CheckedItems)
      source.Add(((frmControlNo.QuoteOptionItem) checkedItem).Value);
    this.QuoteOptionGuids = source.ToArray<Guid>();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.btnRefresh = new Button();
    this.lstOptions = new CheckedListBox();
    this.txtControlNo = new TextBox();
    this.label1 = new Label();
    this.panel1 = new Panel();
    this.btnOk = new Button();
    this.btnCancel = new Button();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    this.btnRefresh.Dock = DockStyle.Top;
    this.btnRefresh.Location = new Point(0, 0);
    this.btnRefresh.Name = "btnRefresh";
    this.btnRefresh.Size = new Size(303, 23);
    this.btnRefresh.TabIndex = 0;
    this.btnRefresh.Text = "Refresh Quote Options";
    this.btnRefresh.UseVisualStyleBackColor = true;
    this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
    this.lstOptions.Dock = DockStyle.Fill;
    this.lstOptions.FormattingEnabled = true;
    this.lstOptions.Location = new Point(0, 23);
    this.lstOptions.Name = "lstOptions";
    this.lstOptions.Size = new Size(303, 111);
    this.lstOptions.TabIndex = 1;
    this.lstOptions.ItemCheck += new ItemCheckEventHandler(this.lstOptions_ItemCheck);
    this.txtControlNo.Location = new Point(98, 6);
    this.txtControlNo.Name = "txtControlNo";
    this.txtControlNo.Size = new Size(205, 20);
    this.txtControlNo.TabIndex = 2;
    this.txtControlNo.Text = "1787";
    this.txtControlNo.Validating += new CancelEventHandler(this.txtControlNo_Validating);
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(80 /*0x50*/, 13);
    this.label1.TabIndex = 3;
    this.label1.Text = "Control Number";
    this.panel1.Controls.Add((Control) this.lstOptions);
    this.panel1.Controls.Add((Control) this.btnRefresh);
    this.panel1.Location = new Point(0, 32 /*0x20*/);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(303, 134);
    this.panel1.TabIndex = 4;
    this.btnOk.Location = new Point(63 /*0x3F*/, 187);
    this.btnOk.Name = "btnOk";
    this.btnOk.Size = new Size(75, 23);
    this.btnOk.TabIndex = 8;
    this.btnOk.Text = "Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnOk.Click += new EventHandler(this.btnOk_Click);
    this.btnCancel.DialogResult = DialogResult.Cancel;
    this.btnCancel.Location = new Point(167, 187);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(75, 23);
    this.btnCancel.TabIndex = 7;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(304, 224 /*0xE0*/);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.txtControlNo);
    this.Name = nameof (frmControlNo);
    this.Text = "Control Number";
    this.Load += new EventHandler(this.frmControlNo_Load);
    this.panel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private class QuoteOptionItem
  {
    public Guid Value;
    public string Display;

    public QuoteOptionItem(Guid Value, string Display)
    {
      this.Value = Value;
      this.Display = Display;
    }

    public override string ToString() => this.Display;
  }
}
