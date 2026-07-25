// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerList_Contacts
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptProducerList_Contacts : SectionReport
{
  private string _ContactsExcelField;
  private TextBox TextBox;

  public rptProducerList_Contacts(DataView dv)
  {
    this.InitializeComponent();
    this.DataSource = (object) dv;
    this._ContactsExcelField = "";
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptProducerList_Contacts));
    this.Detail = new Detail();
    this.TextBox = new TextBox();
    ((ISupportInitialize) this.TextBox).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox
    });
    ((Section) this.Detail).Height = 0.1354167f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "ProducerContact";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF = obj != null ? (PointF) obj : new PointF();
    ((ARControl) textBox).Location = pointF;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(1.313f, 0.15f);
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 1.729167f;
    this.Sections.Add((Section) this.Detail);
    ((ISupportInitialize) this.TextBox).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    this._ContactsExcelField = $"{this._ContactsExcelField}{this.TextBox.Text}\r\n";
  }

  public string Contacts
  {
    get => this._ContactsExcelField;
    set
    {
    }
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }
}
