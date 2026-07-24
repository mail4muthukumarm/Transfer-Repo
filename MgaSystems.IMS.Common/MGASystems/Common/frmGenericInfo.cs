// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.frmGenericInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class frmGenericInfo : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  [SpecialName]
  private int \u0024STATIC\u0024PrintDocument1_PrintPage\u002420211C128525\u0024intCurrentChar;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblTitle")]
  private virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkPrint
  {
    get => this._lnkPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrint_LinkClicked);
      LinkLabel lnkPrint1 = this._lnkPrint;
      if (lnkPrint1 != null)
        lnkPrint1.LinkClicked -= clickedEventHandler;
      this._lnkPrint = value;
      LinkLabel lnkPrint2 = this._lnkPrint;
      if (lnkPrint2 == null)
        return;
      lnkPrint2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual PrintDocument PrintDocument1
  {
    get => this._PrintDocument1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PrintPageEventHandler pageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
      PrintDocument printDocument1_1 = this._PrintDocument1;
      if (printDocument1_1 != null)
        printDocument1_1.PrintPage -= pageEventHandler;
      this._PrintDocument1 = value;
      PrintDocument printDocument1_2 = this._PrintDocument1;
      if (printDocument1_2 == null)
        return;
      printDocument1_2.PrintPage += pageEventHandler;
    }
  }

  [field: AccessedThroughProperty("PrintPreviewDialog1")]
  internal virtual PrintPreviewDialog PrintPreviewDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rtbBodyText")]
  internal virtual RichTextBox rtbBodyText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGenericInfo));
    this.PictureBox1 = new PictureBox();
    this.lblTitle = new Label();
    this.lnkPrint = new LinkLabel();
    this.PrintDocument1 = new PrintDocument();
    this.PrintPreviewDialog1 = new PrintPreviewDialog();
    this.rtbBodyText = new RichTextBox();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(344, 240 /*0xF0*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(120, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 8;
    this.PictureBox1.TabStop = false;
    this.lblTitle.AutoSize = true;
    this.lblTitle.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.Location = new Point(0, 8);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(70, 17);
    this.lblTitle.TabIndex = 9;
    this.lblTitle.Text = "(title here)";
    this.lnkPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPrint.Location = new Point(8, 288);
    this.lnkPrint.Name = "lnkPrint";
    this.lnkPrint.Size = new Size(100, 23);
    this.lnkPrint.TabIndex = 10;
    this.lnkPrint.TabStop = true;
    this.lnkPrint.Text = "Print";
    this.lnkPrint.TextAlign = ContentAlignment.BottomLeft;
    this.PrintPreviewDialog1.AutoScrollMargin = new Size(0, 0);
    this.PrintPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
    this.PrintPreviewDialog1.ClientSize = new Size(400, 300);
    this.PrintPreviewDialog1.Enabled = true;
    this.PrintPreviewDialog1.Icon = (Icon) componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
    this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
    this.PrintPreviewDialog1.Visible = false;
    this.rtbBodyText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.rtbBodyText.BackColor = Color.White;
    this.rtbBodyText.BorderStyle = BorderStyle.None;
    this.rtbBodyText.ForeColor = Color.Black;
    this.rtbBodyText.Location = new Point(16 /*0x10*/, 40);
    this.rtbBodyText.Name = "rtbBodyText";
    this.rtbBodyText.ReadOnly = true;
    this.rtbBodyText.ScrollBars = RichTextBoxScrollBars.Vertical;
    this.rtbBodyText.Size = new Size(448, 200);
    this.rtbBodyText.TabIndex = 11;
    this.rtbBodyText.Text = "";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(472, 318);
    this.Controls.Add((Control) this.rtbBodyText);
    this.Controls.Add((Control) this.lblTitle);
    this.Controls.Add((Control) this.lnkPrint);
    this.Controls.Add((Control) this.PictureBox1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
    this.Name = nameof (frmGenericInfo);
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmGenericInfo(string title, StringBuilder bodyText)
  {
    this.InitializeComponent();
    if (bodyText == null)
      throw new ArgumentNullException(nameof (bodyText));
    this.lblTitle.Text = title;
    this.rtbBodyText.Text = bodyText.ToString();
  }

  public frmGenericInfo(string title, string bodyText)
  {
    this.InitializeComponent();
    if (bodyText == null)
      throw new ArgumentNullException(nameof (bodyText));
    this.lblTitle.Text = title;
    this.rtbBodyText.Rtf = bodyText;
  }

  private void lnkPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (Operators.CompareString(this.rtbBodyText.Text, string.Empty, false) == 0 && this.rtbBodyText.Text.Replace(" ", string.Empty).Length == 0)
      return;
    this.PrintDocument1.DocumentName = "Quote Option Information";
    try
    {
      this.PrintPreviewDialog1.Document = this.PrintDocument1;
      this.PrintPreviewDialog1.WindowState = FormWindowState.Maximized;
      int num = (int) this.PrintPreviewDialog1.ShowDialog();
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Network Printer is not accessible.\r\nIt may be password protected.", "Error in Printing Document.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.PrintPreviewDialog1.Close();
    }
  }

  private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
  {
    Font font = new Font("Tahoma", 12f);
    PageSettings defaultPageSettings = this.PrintDocument1.DefaultPageSettings;
    int height = defaultPageSettings.PaperSize.Height - defaultPageSettings.Margins.Top - defaultPageSettings.Margins.Bottom;
    int width = defaultPageSettings.PaperSize.Width - defaultPageSettings.Margins.Left - defaultPageSettings.Margins.Right;
    int left = defaultPageSettings.Margins.Left;
    int top = defaultPageSettings.Margins.Top;
    if (this.PrintDocument1.DefaultPageSettings.Landscape)
    {
      int num = height;
      height = width;
      width = num;
    }
    RectangleF layoutRectangle = new RectangleF((float) left, (float) top, (float) width, (float) height);
    StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(this.lblTitle.Text + "\r\n\r\n");
    stringBuilder.Append(this.rtbBodyText.Text);
    int charactersFitted;
    e.Graphics.MeasureString(Strings.Mid(stringBuilder.ToString(), this.\u0024STATIC\u0024PrintDocument1_PrintPage\u002420211C128525\u0024intCurrentChar + 1), font, new SizeF((float) width, (float) height), stringFormat, out charactersFitted, out int _);
    e.Graphics.DrawString(Strings.Mid(stringBuilder.ToString(), this.\u0024STATIC\u0024PrintDocument1_PrintPage\u002420211C128525\u0024intCurrentChar + 1), font, Brushes.Black, layoutRectangle, stringFormat);
    this.\u0024STATIC\u0024PrintDocument1_PrintPage\u002420211C128525\u0024intCurrentChar += charactersFitted;
    if (this.\u0024STATIC\u0024PrintDocument1_PrintPage\u002420211C128525\u0024intCurrentChar < stringBuilder.ToString().Length)
    {
      e.HasMorePages = true;
    }
    else
    {
      e.HasMorePages = false;
      this.\u0024STATIC\u0024PrintDocument1_PrintPage\u002420211C128525\u0024intCurrentChar = 0;
    }
  }
}
