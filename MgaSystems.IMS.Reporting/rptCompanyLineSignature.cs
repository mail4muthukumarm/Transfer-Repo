// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCompanyLineSignature
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptCompanyLineSignature : SectionReport
{
  private Picture Picture;
  private Label Label;
  private readonly Guid _quoteOptionGuid;
  private readonly int _signatureTypeID;

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptCompanyLineSignature(Guid quoteOptionGuid, int signatureTypeID)
  {
    this.ReportStart += new EventHandler(this.rptCompanyLineSignature_ReportStart);
    this.InitializeComponent();
    this._quoteOptionGuid = quoteOptionGuid;
    this._signatureTypeID = signatureTypeID;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptCompanyLineSignature));
    this.Detail = new Detail();
    this.Picture = new Picture();
    this.Label = new Label();
    ((ISupportInitialize) this.Picture).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Picture,
      (ARControl) this.Label
    });
    ((Section) this.Detail).Height = 0.6458333f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.Picture).Border.BottomColor = Color.Black;
    ((ARControl) this.Picture).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).Border.LeftColor = Color.Black;
    ((ARControl) this.Picture).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).Border.RightColor = Color.Black;
    ((ARControl) this.Picture).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).Border.TopColor = Color.Black;
    ((ARControl) this.Picture).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Picture).DataField = "Signature";
    ((ARControl) this.Picture).Height = 7f / 16f;
    this.Picture.Image = (Image) null;
    this.Picture.ImageData = (Stream) null;
    ((ARControl) this.Picture).Left = 0.0f;
    this.Picture.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    this.Picture.LineWeight = 0.0f;
    ((ARControl) this.Picture).Name = "Picture";
    this.Picture.SizeMode = (SizeModes) 1;
    ((ARControl) this.Picture).Top = 0.0f;
    ((ARControl) this.Picture).Width = 2.5f;
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).DataField = "Title";
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; font-size: 9pt; ";
    this.Label.Text = "";
    ((ARControl) this.Label).Top = 7f / 16f;
    ((ARControl) this.Label).Width = 2.5f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 2.520833f;
    this.Sections.Add((Section) this.Detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Picture).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptCompanyLineSignature_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) DefaultDatabase.ExecuteDataTable(nameof (rptCompanyLineSignature), new object[4]
    {
      (object) "@QuoteOptionGuid",
      (object) this._quoteOptionGuid,
      (object) "@SignatureTypeID",
      (object) this._signatureTypeID
    });
  }
}
