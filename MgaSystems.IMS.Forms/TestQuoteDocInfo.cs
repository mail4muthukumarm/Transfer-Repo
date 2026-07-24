// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.TestQuoteDocInfo
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class TestQuoteDocInfo : Form
{
  private IContainer components;
  private DataTable _dt;
  private string _DocumentType;
  private string _DocumentId;
  private Point _FormLocation;
  private string documentType;
  private string documentId;
  private Point formLocation;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.DataGridView1 = new DataGridView();
    this.lblNoInfo = new Label();
    this.Panel1 = new Panel();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.AllowUserToDeleteRows = false;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView1.ColumnHeadersVisible = false;
    this.DataGridView1.Dock = DockStyle.Fill;
    this.DataGridView1.Location = new Point(0, 0);
    this.DataGridView1.MultiSelect = false;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Size = new Size(306, 448);
    this.DataGridView1.TabIndex = 0;
    this.lblNoInfo.BackColor = Color.White;
    this.lblNoInfo.Dock = DockStyle.Top;
    this.lblNoInfo.Location = new Point(0, 0);
    this.lblNoInfo.Name = "lblNoInfo";
    this.lblNoInfo.Size = new Size(306, 30);
    this.lblNoInfo.TabIndex = 1;
    this.lblNoInfo.Text = "There is no additional info found for document";
    this.lblNoInfo.Visible = false;
    this.Panel1.BorderStyle = BorderStyle.FixedSingle;
    this.Panel1.Controls.Add((Control) this.lblNoInfo);
    this.Panel1.Controls.Add((Control) this.DataGridView1);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(308, 450);
    this.Panel1.TabIndex = 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(308, 450);
    this.ControlBox = false;
    this.Controls.Add((Control) this.Panel1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (TestQuoteDocInfo);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = "Info";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView1
  {
    get => this._DataGridView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewBindingCompleteEventHandler completeEventHandler = new DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
      DataGridView dataGridView1_1 = this._DataGridView1;
      if (dataGridView1_1 != null)
        dataGridView1_1.DataBindingComplete -= completeEventHandler;
      this._DataGridView1 = value;
      DataGridView dataGridView1_2 = this._DataGridView1;
      if (dataGridView1_2 == null)
        return;
      dataGridView1_2.DataBindingComplete += completeEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblNoInfo")]
  internal virtual Label lblNoInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public TestQuoteDocInfo(string documentType, string documentId, Point formLocation)
  {
    this.Load += new EventHandler(this.TestQuoteDocInfo_Load);
    this.Deactivate += new EventHandler(this.TestQuoteDocInfo_Deactivate);
    this.InitializeComponent();
    this._DocumentType = documentType;
    this._DocumentId = documentId;
    this._FormLocation = formLocation;
    this.DataGridView1.Visible = false;
    string Left = documentType;
    this.lblNoInfo.Text = $"There is no additional info found for {(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) == 0 ? "Automation Report" : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "W", false) == 0 ? "MS Word Template" : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) == 0 ? "PDF Template" : "UNKNOWN")))}. Document ID: {documentId}";
    this.lblNoInfo.Visible = true;
  }

  public TestQuoteDocInfo(
    DataTable dt,
    string DocumentType,
    string DocumentId,
    Point FormLocation)
  {
    this.Load += new EventHandler(this.TestQuoteDocInfo_Load);
    this.Deactivate += new EventHandler(this.TestQuoteDocInfo_Deactivate);
    this.InitializeComponent();
    this._dt = dt;
    this._DocumentType = DocumentType;
    this._DocumentId = DocumentId;
    this._FormLocation = FormLocation;
    this.DataGridView1.DataSource = (object) this._dt;
  }

  private void DataGridView1_DataBindingComplete(
    object sender,
    DataGridViewBindingCompleteEventArgs e)
  {
    this.DataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.DataGridView1.Columns[1].FillWeight = 100f;
    this.Height = this.DataGridView1.Rows.Count * this.DataGridView1.Rows[0].Height + (this.Height - this.ClientSize.Height) + 5;
  }

  private void TestQuoteDocInfo_Load(object sender, EventArgs e)
  {
    this.Location = this._FormLocation;
    if (!Information.IsNothing((object) this._dt))
      return;
    this.Height = 70;
  }

  private void TestQuoteDocInfo_Deactivate(object sender, EventArgs e)
  {
    this.Close();
    this.Dispose();
  }
}
