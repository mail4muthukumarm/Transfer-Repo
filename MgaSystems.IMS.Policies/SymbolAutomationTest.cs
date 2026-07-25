// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.SymbolAutomationTest
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class SymbolAutomationTest : SectionReport
{
  private DataTable _dt;
  private string _insuredName;

  protected virtual void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (SymbolAutomationTest));
    this.Detail1 = new Detail();
    this.ReportHeader1 = new ReportHeader();
    this.ReportFooter1 = new ReportFooter();
    this.txtInsured = new TextBox();
    this.TextBox1 = new TextBox();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox1
    });
    ((Section) this.Detail1).Height = 0.1770833f;
    ((Section) this.Detail1).Name = "Detail1";
    ((Section) this.ReportHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtInsured
    });
    this.ReportHeader1.Height = 0.3229167f;
    ((Section) this.ReportHeader1).Name = "ReportHeader1";
    this.ReportFooter1.Height = 0.0f;
    ((Section) this.ReportFooter1).Name = "ReportFooter1";
    ((ARControl) this.txtInsured).Border.BottomColor = Color.Black;
    ((ARControl) this.txtInsured).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.LeftColor = Color.Black;
    ((ARControl) this.txtInsured).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.RightColor = Color.Black;
    ((ARControl) this.txtInsured).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Border.TopColor = Color.Black;
    ((ARControl) this.txtInsured).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInsured).Height = 5f / 16f;
    ((ARControl) this.txtInsured).Left = 0.0f;
    ((ARControl) this.txtInsured).Name = "txtInsured";
    this.txtInsured.Style = "text-align: center; vertical-align: middle; ";
    ((ARControl) this.txtInsured).Top = 0.0f;
    ((ARControl) this.txtInsured).Width = 7.875f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Value";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "vertical-align: middle; ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 125f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader1);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader1")]
  internal virtual ReportHeader ReportHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter1")]
  internal virtual ReportFooter ReportFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsured")]
  internal virtual TextBox txtInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public SymbolAutomationTest(string insuredName, DataTable dt)
  {
    this.ReportStart += new EventHandler(this.SymbolAutomationTest_ReportStart);
    this.InitializeComponent();
    this._dt = dt;
    this._insuredName = insuredName;
  }

  private void SymbolAutomationTest_ReportStart(object sender, EventArgs e)
  {
    this.txtInsured.Value = (object) this._insuredName;
    this.DataSource = (object) this._dt;
  }
}
