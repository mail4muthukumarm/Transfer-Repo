// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Risk_Meter.FormRiskImage
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Controls.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Risk_Meter;

public class FormRiskImage : Form, IDisposable
{
  private Guid _quoteGuid;
  private string _url;
  private string _address;
  private int _quoteID;
  private IContainer components;
  private dsRiskMeter ds;
  private MGAButton btnSendDocHandler;
  private SqlConnection cn;
  private SqlDataAdapter da;
  private SqlCommand SqlDeleteCommand2;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlSelectCommand4;
  private SqlCommand SqlUpdateCommand2;
  private GroupBox groupBox1;
  private Label label1;
  private MGAWebView mgaWebView1;

  public FormRiskImage(Guid quoteGuid, string url, string address)
  {
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._url = url;
    this._address = address;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((Control) this.btnSendDocHandler).Enabled = !this._quoteGuid.Equals(Guid.Empty);
    if (this._quoteGuid.Equals(Guid.Empty))
      return;
    this._quoteID = new Quote(this._quoteGuid).QuoteID;
  }

  private void btnSendDocHandler_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (this._quoteGuid.Equals(Guid.Empty))
      {
        int num = (int) MessageBox.Show("No quote is available to associate this image file to.", "No Quote Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        Quote quote = new Quote(this._quoteGuid);
        string path = MGATempFolder.MGATempPath + "RiskMeter-ControlNo1111.pdf";
        if (!File.Exists(path))
          return;
        File.Delete(path);
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void FormRiskImage_Load(object sender, EventArgs e)
  {
    this.mgaWebView1.Navigate(this._url);
  }

  private void browser_DocumentCompleted(object sender, EventArgs e)
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRiskImage));
    this.ds = new dsRiskMeter();
    this.btnSendDocHandler = new MGAButton();
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.groupBox1 = new GroupBox();
    this.label1 = new Label();
    this.mgaWebView1 = new MGAWebView();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSendDocHandler).BeginInit();
    this.groupBox1.SuspendLayout();
    this.SuspendLayout();
    this.ds.DataSetName = "dsRiskMeter";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSendDocHandler).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance).Image = componentResourceManager.GetObject("appearance4.Image");
    ((AppearanceBase) appearance).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSendDocHandler).Appearance = (AppearanceBase) appearance;
    this.btnSendDocHandler.ButtonStyle = (UIElementButtonStyle) 10;
    ((Control) this.btnSendDocHandler).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSendDocHandler).Location = new Point(611, 642);
    ((Control) this.btnSendDocHandler).Name = "btnSendDocHandler";
    ((ControlBase) this.btnSendDocHandler).Padding = new Size(5, 0);
    ((Control) this.btnSendDocHandler).Size = new Size(162, 35);
    ((Control) this.btnSendDocHandler).TabIndex = 293;
    ((Control) this.btnSendDocHandler).Text = "Send to Doc Handler";
    ((UltraControlBase) this.btnSendDocHandler).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSendDocHandler).Visible = false;
    ((Control) this.btnSendDocHandler).Click += new EventHandler(this.btnSendDocHandler_Click);
    this.cn.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand2;
    this.da.InsertCommand = this.SqlInsertCommand2;
    this.da.SelectCommand = this.SqlSelectCommand4;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteRiskMeterResults", new DataColumnMapping[4]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("Item", "Item"),
        new DataColumnMapping("ItemResults", "ItemResults")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblQuoteRiskMeterResults] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand2.Connection = this.cn;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cn;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Item", SqlDbType.VarChar, 200, "Item"),
      new SqlParameter("@ItemResults", SqlDbType.VarChar, 8000, "ItemResults"),
      new SqlParameter("@ResultsDate", SqlDbType.DateTime, 8, "ResultsDate"),
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid")
    });
    this.SqlSelectCommand4.CommandText = "SELECT     ID, QuoteID, Item, ItemResults, ResultsDate, UserGuid\r\nFROM         dbo.tblQuoteRiskMeterResults";
    this.SqlSelectCommand4.Connection = this.cn;
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cn;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Item", SqlDbType.VarChar, 200, "Item"),
      new SqlParameter("@ItemResults", SqlDbType.VarChar, 8000, "ItemResults"),
      new SqlParameter("@ResultsDate", SqlDbType.DateTime, 8, "ResultsDate"),
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox1.Controls.Add((Control) this.mgaWebView1);
    this.groupBox1.Location = new Point(12, 6);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(761, 630);
    this.groupBox1.TabIndex = 294;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Risk Meter Application";
    this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(9, 653);
    this.label1.Name = "label1";
    this.label1.Size = new Size(405, 13);
    this.label1.TabIndex = 295;
    this.label1.Text = "Note: Scroll to include the area of the screen to display in your image.";
    this.mgaWebView1.Dock = DockStyle.Fill;
    this.mgaWebView1.Location = new Point(3, 16 /*0x10*/);
    this.mgaWebView1.MinimumSize = new Size(20, 20);
    this.mgaWebView1.Name = "mgaWebView1";
    this.mgaWebView1.Size = new Size(755, 611);
    this.mgaWebView1.TabIndex = 0;
    this.mgaWebView1.BrowserInitialized += new EventHandler(this.browser_DocumentCompleted);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(785, 689);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.groupBox1);
    this.Controls.Add((Control) this.btnSendDocHandler);
    this.Name = nameof (FormRiskImage);
    this.Text = "Risk Meter";
    this.Load += new EventHandler(this.FormRiskImage_Load);
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSendDocHandler).EndInit();
    this.groupBox1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
