// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.TestReport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class TestReport : SectionReport
{
  private IContainer components;
  private Label Label1;

  public TestReport() => this.InitializeComponent();

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TestReport));
    this.PageHeader1 = new PageHeader();
    this.Detail1 = new Detail();
    this.PageFooter1 = new PageFooter();
    this.Label1 = new Label();
    ((ISupportInitialize) this.Label1).BeginInit();
    this.PageHeader1.Height = 0.25f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    ((Section) this.Detail1).Height = 2f;
    ((Section) this.Detail1).Name = "Detail1";
    this.PageFooter1.Height = 0.25f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj = componentResourceManager.GetObject("Label1.Location");
    PointF pointF = obj != null ? (PointF) obj : new PointF();
    ((ARControl) label1).Location = pointF;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.25f, 3f / 16f);
    this.Label1.Text = "TEST REPORT";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.PageFooter1);
    ((ISupportInitialize) this.Label1).EndInit();
  }
}
