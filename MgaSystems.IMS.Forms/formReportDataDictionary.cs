// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.formReportDataDictionary
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class formReportDataDictionary : Form
{
  private IContainer components;
  private ISupportReportDictionary _report;
  private Font _headerFont;
  private int _labelHeight;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formReportDataDictionary));
    this.Panel1 = new Panel();
    this.labelReportDescription = new Label();
    this.labelReportName = new Label();
    this.PictureBox1 = new PictureBox();
    this.panelContent = new Panel();
    this.Panel2 = new Panel();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel2.SuspendLayout();
    this.SuspendLayout();
    this.Panel1.BackColor = Color.White;
    this.Panel1.Controls.Add((Control) this.labelReportDescription);
    this.Panel1.Controls.Add((Control) this.labelReportName);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(130, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(735, 111);
    this.Panel1.TabIndex = 0;
    this.labelReportDescription.Location = new Point(8, 43);
    this.labelReportDescription.Name = "labelReportDescription";
    this.labelReportDescription.Size = new Size(715, 57);
    this.labelReportDescription.TabIndex = 2;
    this.labelReportDescription.UseMnemonic = false;
    this.labelReportName.AutoSize = true;
    this.labelReportName.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelReportName.ForeColor = Color.SteelBlue;
    this.labelReportName.Location = new Point(3, 4);
    this.labelReportName.Name = "labelReportName";
    this.labelReportName.Size = new Size(274, 29);
    this.labelReportName.TabIndex = 1;
    this.labelReportName.Text = "Report Name Goes Here";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(-16, -3);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(161, 144 /*0x90*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.panelContent.AutoScroll = true;
    this.panelContent.BackColor = Color.White;
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(130, 111);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(735, 501);
    this.panelContent.TabIndex = 3;
    this.Panel2.BackColor = Color.White;
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Dock = DockStyle.Left;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(130, 612);
    this.Panel2.TabIndex = 4;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(865, 612);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (formReportDataDictionary);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Data Dictionary Viewer";
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelReportDescription")]
  internal virtual Label labelReportDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelReportName")]
  internal virtual Label labelReportName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelContent")]
  internal virtual Panel panelContent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public formReportDataDictionary(ISupportReportDictionary report)
  {
    this._labelHeight = 40;
    this.InitializeComponent();
    this._report = report;
    this._headerFont = new Font("Tahoma", 12f, FontStyle.Underline);
    this.DisplayReportDictionary();
  }

  private void DisplayReportDictionary()
  {
    this.labelReportName.Text = this._report.ReportFriendlyName;
    this.labelReportDescription.Text = this._report.GeneralDescription;
    this.DisplaySortingTotals();
    this.DisplayFields();
    this.DisplaySearchCriteria();
  }

  private void DisplayFields()
  {
    if (this._report.FieldDescriptions.Length == 0)
      return;
    int num = this._report.FieldDescriptions.Length - 1;
    for (int index = 0; index <= num; index += 2)
    {
      Label label1 = new Label();
      label1.Text = this._report.FieldDescriptions[index];
      label1.ForeColor = Color.SteelBlue;
      label1.Height = this._labelHeight;
      label1.Padding = new Padding(4, 2, 0, 0);
      if (this._report.FieldDescriptions.Length >= index + 1)
      {
        Label label2;
        string str = $"{(label2 = label1).Text}-{this._report.FieldDescriptions[index + 1]}";
        label2.Text = str;
      }
      this.panelContent.Controls.Add((Control) label1);
      label1.Dock = DockStyle.Top;
    }
    Label label = new Label();
    label.Text = "Report Fields";
    label.ForeColor = Color.SteelBlue;
    label.Font = this._headerFont;
    label.Padding = new Padding(4, 2, 0, 0);
    this.panelContent.Controls.Add((Control) label);
    label.Dock = DockStyle.Top;
  }

  private void DisplaySearchCriteria()
  {
    if (this._report.SearchCriteriaDescription.Length == 0)
      return;
    int num = this._report.SearchCriteriaDescription.Length - 1;
    for (int index = 0; index <= num; index += 2)
    {
      Label label1 = new Label();
      label1.Text = this._report.SearchCriteriaDescription[index];
      label1.ForeColor = Color.SteelBlue;
      label1.Height = this._labelHeight;
      label1.Padding = new Padding(4, 2, 0, 0);
      if (this._report.SearchCriteriaDescription.Length >= index + 1)
      {
        Label label2;
        string str = $"{(label2 = label1).Text}-{this._report.SearchCriteriaDescription[index + 1]}";
        label2.Text = str;
      }
      this.panelContent.Controls.Add((Control) label1);
      label1.Dock = DockStyle.Top;
    }
    Label label = new Label();
    label.Text = "Selection Criteria";
    label.ForeColor = Color.SteelBlue;
    label.Font = this._headerFont;
    label.Padding = new Padding(4, 2, 0, 0);
    this.panelContent.Controls.Add((Control) label);
    label.Dock = DockStyle.Top;
  }

  private void DisplaySortingTotals()
  {
    if (this._report.SortingAndTotalsDescription.Length == 0)
      return;
    int num = this._report.SortingAndTotalsDescription.Length - 1;
    for (int index = 0; index <= num; index += 2)
    {
      Label label1 = new Label();
      label1.Text = this._report.SortingAndTotalsDescription[index];
      label1.ForeColor = Color.SteelBlue;
      label1.Height = this._labelHeight;
      label1.Padding = new Padding(4, 2, 0, 0);
      if (this._report.SortingAndTotalsDescription.Length >= index + 1)
      {
        Label label2;
        string str = $"{(label2 = label1).Text}-{this._report.SortingAndTotalsDescription[index + 1]}";
        label2.Text = str;
      }
      this.panelContent.Controls.Add((Control) label1);
      label1.Dock = DockStyle.Top;
    }
    Label label = new Label();
    label.Text = "Sorting & Sub-Totals";
    label.ForeColor = Color.SteelBlue;
    label.Font = this._headerFont;
    label.Padding = new Padding(4, 2, 0, 0);
    this.panelContent.Controls.Add((Control) label);
    label.Dock = DockStyle.Top;
  }
}
