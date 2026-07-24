// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.frmReportsTest
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using GrapeCity.ActiveReports;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reporting.Reports.Documents;
using MGASystems.IMS.Forms;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting;

[TestForm]
public class frmReportsTest : Form
{
  private IContainer components;
  private Button button1;

  public frmReportsTest() => this.InitializeComponent();

  private bool GetQuoteGuids(
    string defaultControlNumber,
    ref Guid quoteGuid,
    ref Guid quoteOptionGuid)
  {
    string Expression = Interaction.InputBox("Enter the Control Number of the Page you want to Print.", "Control Number", defaultControlNumber);
    if (!Information.IsNumeric((object) Expression))
      return false;
    try
    {
      quoteGuid = (Guid) Database.Instance.QueryText.PerformScalarQuery("Select QuoteGUID FROM tblQuotes WHERE ControlNo = @ControlNo", (object) "@ControlNo", (object) Convert.ToInt32(Expression));
      quoteOptionGuid = (Guid) Database.Instance.QueryText.PerformScalarQuery("Select QuoteOptionGUID FROM tblQuoteOptions WHERE QuoteGUID = @QuoteOptionGUID", (object) "@QuoteOptionGUID", (object) quoteGuid.ToString());
      return true;
    }
    catch
    {
      return false;
    }
  }

  private void button1_Click(object sender, EventArgs e)
  {
    Guid empty1 = Guid.Empty;
    Guid empty2 = Guid.Empty;
    if (!this.GetQuoteGuids("9", ref empty1, ref empty2))
    {
      int num = (int) MessageBox.Show("Exiting - The Control Number is not Numeric");
    }
    else
    {
      rptPreBindInvoice report = new rptPreBindInvoice(empty1);
      report.SetQuoteOptionGuids(new Guid[1]{ empty2 });
      report.Run();
      new frmPrint((SectionReport) report).Show();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.button1 = new Button();
    this.SuspendLayout();
    this.button1.Location = new Point(45, 22);
    this.button1.Name = "button1";
    this.button1.Size = new Size(202, 23);
    this.button1.TabIndex = 0;
    this.button1.Text = "Pre-Bind Invoice";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(292, 273);
    this.Controls.Add((Control) this.button1);
    this.Name = nameof (frmReportsTest);
    this.Text = "Form1";
    this.ResumeLayout(false);
  }
}
