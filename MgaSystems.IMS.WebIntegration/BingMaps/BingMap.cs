// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.BingMaps.BingMap
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using MGASystems.Common.Controls.Forms;
using MgaSystems.IMS.WebIntegration.GeocodeService;
using MgaSystems.IMS.WebIntegration.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.BingMaps;

public class BingMap : UserControl
{
  private string _mapNavigation = string.Empty;
  private string _address = string.Empty;
  private IContainer components;
  private PictureBox pictureBox1;
  private MGAWebView mgaWebView1;

  public BingMap() => this.InitializeComponent();

  public void RenderDocument(string document)
  {
    if (string.IsNullOrEmpty(document))
      return;
    this._mapNavigation = document;
    this.RenderMap();
  }

  public string GetDocument() => string.Empty;

  public void RenderAddress(string city, string state, string zip)
  {
    this.RenderAddress(string.Empty, city, state, zip);
  }

  public void RenderAddress(string address1, string city, string state, string zip)
  {
    this.pictureBox1.Visible = true;
    this.pictureBox1.Image = (Image) Resources.Loading;
    this.Refresh();
    this._address = $"{address1} {city}, {state} {zip}";
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += new DoWorkEventHandler(this.GeocodeAddress);
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        if (e.Error == null)
          this.pictureBox1.Visible = false;
        else
          ExceptionDispatchInfo.Capture(e.Error).Throw();
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  public void RenderAddress(float latitude, float longitude)
  {
    this._mapNavigation = Resources.maptext_latlong.ToString();
    this._mapNavigation = this._mapNavigation.Replace(this.ParseLatitudeLongitudeParams("/*lat*/", "/*endlat*/"), latitude.ToString());
    this._mapNavigation = this._mapNavigation.Replace(this.ParseLatitudeLongitudeParams("/*lng*/", "/*endlng*/"), longitude.ToString());
    this.RenderMap();
  }

  private void GeocodeAddress(object sender, DoWorkEventArgs e)
  {
    string str = "AjD1hkcv4zLanhnD5RutuK5-QlW-jJrHC2qg_kmpbJIHr67thK5Rm7l9UmLTt-Jm";
    GeocodeRequest request = new GeocodeRequest();
    request.Credentials = new Credentials();
    request.Credentials.ApplicationId = str;
    request.Query = this._address;
    ConfidenceFilter[] confidenceFilterArray = new ConfidenceFilter[1]
    {
      new ConfidenceFilter()
    };
    confidenceFilterArray[0].MinimumConfidence = Confidence.High;
    request.Options = new GeocodeOptions()
    {
      Filters = (FilterBase[]) confidenceFilterArray
    };
    try
    {
      GeocodeResponse geocodeResponse = new MgaSystems.IMS.WebIntegration.GeocodeService.GeocodeService().Geocode(request);
      if (geocodeResponse.Results.Length == 0)
        return;
      this._mapNavigation = this._mapNavigation.Replace(this.ParseLatitudeLongitudeParams("/*lat*/", "/*endlat*/"), geocodeResponse.Results[0].Locations[0].Latitude.ToString());
      this._mapNavigation = this._mapNavigation.Replace(this.ParseLatitudeLongitudeParams("/*lng*/", "/*endlng*/"), geocodeResponse.Results[0].Locations[0].Longitude.ToString());
      this.RenderMap();
    }
    catch (Exception ex)
    {
    }
  }

  private void RenderMap()
  {
  }

  private string ParseLatitudeLongitudeParams(string beginLocation, string endLocation)
  {
    int num1 = this._mapNavigation.IndexOf(beginLocation);
    int num2 = this._mapNavigation.IndexOf(endLocation);
    return this._mapNavigation.Substring(num1 + 7, num2 - (num1 + 7));
  }

  private void BingMap_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._mapNavigation = Resources.Maptext.ToString();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.pictureBox1 = new PictureBox();
    this.mgaWebView1 = new MGAWebView();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.SuspendLayout();
    this.pictureBox1.BackColor = Color.White;
    this.pictureBox1.Dock = DockStyle.Fill;
    this.pictureBox1.Location = new Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(375, 375);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 7;
    this.pictureBox1.TabStop = false;
    this.pictureBox1.Visible = false;
    this.pictureBox1.WaitOnLoad = true;
    this.mgaWebView1.Dock = DockStyle.Fill;
    this.mgaWebView1.Location = new Point(0, 0);
    this.mgaWebView1.MinimumSize = new Size(20, 20);
    this.mgaWebView1.Name = "mgaWebView1";
    this.mgaWebView1.Size = new Size(375, 375);
    this.mgaWebView1.TabIndex = 8;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.mgaWebView1);
    this.Controls.Add((Control) this.pictureBox1);
    this.MaximumSize = new Size(375, 375);
    this.MinimumSize = new Size(375, 375);
    this.Name = nameof (BingMap);
    this.Size = new Size(375, 375);
    this.Load += new EventHandler(this.BingMap_Load);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.ResumeLayout(false);
  }
}
