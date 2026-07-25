// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.SignatureCapturePanel
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (SignatureCapturePanel))]
public sealed class SignatureCapturePanel : UserControl
{
  private IContainer components;
  private Size _captureSize;
  private Color _captureBorderColor;
  private Pen _captureBorderPen;
  private string _signaturePromptText;
  private Bitmap _signatureBitmap;
  private Graphics _signatureGraphics;
  private Point _lastPoint;
  private Point _originalDownPoint;
  private bool _copyImageOnMouseUp;
  private Pen _signaturePen;
  private Color _signaturePenColor;
  private int _signaturePenWidth;

  internal virtual PictureBox pbTrash
  {
    get => this._pbTrash;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pbTrash_Click);
      EventHandler eventHandler2 = new EventHandler(this.pb_MouseEnter);
      EventHandler eventHandler3 = new EventHandler(this.pb_MouseLeave);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pb_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pb_MouseUp);
      PictureBox pbTrash1 = this._pbTrash;
      if (pbTrash1 != null)
      {
        pbTrash1.Click -= eventHandler1;
        pbTrash1.MouseEnter -= eventHandler2;
        pbTrash1.MouseLeave -= eventHandler3;
        pbTrash1.MouseDown -= mouseEventHandler1;
        pbTrash1.MouseUp -= mouseEventHandler2;
      }
      this._pbTrash = value;
      PictureBox pbTrash2 = this._pbTrash;
      if (pbTrash2 == null)
        return;
      pbTrash2.Click += eventHandler1;
      pbTrash2.MouseEnter += eventHandler2;
      pbTrash2.MouseLeave += eventHandler3;
      pbTrash2.MouseDown += mouseEventHandler1;
      pbTrash2.MouseUp += mouseEventHandler2;
    }
  }

  internal virtual PictureBox pbOpen
  {
    get => this._pbOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pb_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.pb_MouseLeave);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pb_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pb_MouseUp);
      EventHandler eventHandler3 = new EventHandler(this.pbOpen_Click);
      PictureBox pbOpen1 = this._pbOpen;
      if (pbOpen1 != null)
      {
        pbOpen1.MouseEnter -= eventHandler1;
        pbOpen1.MouseLeave -= eventHandler2;
        pbOpen1.MouseDown -= mouseEventHandler1;
        pbOpen1.MouseUp -= mouseEventHandler2;
        pbOpen1.Click -= eventHandler3;
      }
      this._pbOpen = value;
      PictureBox pbOpen2 = this._pbOpen;
      if (pbOpen2 == null)
        return;
      pbOpen2.MouseEnter += eventHandler1;
      pbOpen2.MouseLeave += eventHandler2;
      pbOpen2.MouseDown += mouseEventHandler1;
      pbOpen2.MouseUp += mouseEventHandler2;
      pbOpen2.Click += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("OpenFileDialog1")]
  internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColorDialog1")]
  internal virtual ColorDialog ColorDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual PictureBox pbColors
  {
    get => this._pbColors;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pb_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.pb_MouseLeave);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pb_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pb_MouseUp);
      EventHandler eventHandler3 = new EventHandler(this.pbColors_Click);
      PictureBox pbColors1 = this._pbColors;
      if (pbColors1 != null)
      {
        pbColors1.MouseEnter -= eventHandler1;
        pbColors1.MouseLeave -= eventHandler2;
        pbColors1.MouseDown -= mouseEventHandler1;
        pbColors1.MouseUp -= mouseEventHandler2;
        pbColors1.Click -= eventHandler3;
      }
      this._pbColors = value;
      PictureBox pbColors2 = this._pbColors;
      if (pbColors2 == null)
        return;
      pbColors2.MouseEnter += eventHandler1;
      pbColors2.MouseLeave += eventHandler2;
      pbColors2.MouseDown += mouseEventHandler1;
      pbColors2.MouseUp += mouseEventHandler2;
      pbColors2.Click += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (SignatureCapturePanel));
    this.pbTrash = new PictureBox();
    this.pbOpen = new PictureBox();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.ColorDialog1 = new ColorDialog();
    this.pbColors = new PictureBox();
    this.ToolTip1 = new ToolTip(this.components);
    this.SuspendLayout();
    this.pbTrash.Image = (Image) resourceManager.GetObject("pbTrash.Image");
    this.pbTrash.Location = new Point(8, 8);
    this.pbTrash.Name = "pbTrash";
    this.pbTrash.Size = new Size(21, 30);
    this.pbTrash.TabIndex = 0;
    this.pbTrash.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pbTrash, "Clear the current signature");
    this.pbOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.pbOpen.Image = (Image) resourceManager.GetObject("pbOpen.Image");
    this.pbOpen.Location = new Point(368, 16 /*0x10*/);
    this.pbOpen.Name = "pbOpen";
    this.pbOpen.Size = new Size(24, 24);
    this.pbOpen.TabIndex = 1;
    this.pbOpen.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pbOpen, "Open a signature image file");
    this.OpenFileDialog1.Filter = "Bitmap files|*.bmp|jpeg files|*.jpg|Portable network graphics files|*.png|Gif files|*.gif";
    this.OpenFileDialog1.Title = "Please choose a signature image file.";
    this.pbColors.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.pbColors.Image = (Image) resourceManager.GetObject("pbColors.Image");
    this.pbColors.Location = new Point(368, 48 /*0x30*/);
    this.pbColors.Name = "pbColors";
    this.pbColors.Size = new Size(24, 24);
    this.pbColors.TabIndex = 2;
    this.pbColors.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.pbColors, "Change the color of the pen.");
    this.Controls.Add((Control) this.pbColors);
    this.Controls.Add((Control) this.pbOpen);
    this.Controls.Add((Control) this.pbTrash);
    this.Name = nameof (SignatureCapturePanel);
    this.Size = new Size(400, 352);
    this.ResumeLayout(false);
  }

  public SignatureCapturePanel()
  {
    this.Load += new EventHandler(this.SignatureCapturePanel_Load);
    this.MouseMove += new MouseEventHandler(this.SignatureCapturePanel_MouseMove);
    this._captureSize = new Size(200, 100);
    this._captureBorderColor = Color.Black;
    this._signaturePromptText = "Sign here";
    this._lastPoint = Point.Empty;
    this._signaturePenColor = Color.Black;
    this._signaturePenWidth = 2;
    this.InitializeComponent();
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.Selectable, false);
  }

  protected override void Dispose(bool disposing)
  {
    this.DisposeCaptureBorderPen();
    this.DisposeSignatureBitmap();
    this.DisposeSignatureGraphics();
    this.DisposeSignaturePen();
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private Pen SignaturePen
  {
    get
    {
      if (this._signaturePen == null)
        this._signaturePen = new Pen(this._signaturePenColor, (float) this._signaturePenWidth);
      return this._signaturePen;
    }
  }

  private void DisposeSignaturePen()
  {
    if (this._signaturePen == null)
      return;
    this._signaturePen.Dispose();
    this._signaturePen = (Pen) null;
  }

  private void DisposeSignatureGraphics()
  {
    if (this._signatureGraphics == null)
      return;
    this._signatureGraphics.Dispose();
    this._signatureGraphics = (Graphics) null;
  }

  private void DisposeSignatureBitmap()
  {
    if (this._signatureBitmap == null)
      return;
    this._signatureBitmap.Dispose();
    this._signatureBitmap = (Bitmap) null;
  }

  private void DisposeCaptureBorderPen()
  {
    if (this._captureBorderPen == null)
      return;
    this._captureBorderPen.Dispose();
    this._captureBorderPen = (Pen) null;
  }

  [Category("Appearance")]
  [Description("Gets/Sets the size of the capture rectangle")]
  [DefaultValue(typeof (Size), "200,100")]
  public Size CaptureSize
  {
    get => this._captureSize;
    set
    {
      if (value.Equals((object) this._captureSize))
        return;
      int height = Math.Max(value.Height, this._captureSize.Height);
      this._captureSize = new Size(Math.Max(value.Width, this._captureSize.Width), height);
      this.Invalidate(this.CaptureRectToInvalidate);
      this._captureSize = value;
      this.Update();
    }
  }

  [Category("Appearance")]
  [Description("Gets/Sets the border color of the capture rectangle.")]
  [DefaultValue(typeof (Color), "Black")]
  public Color CaptureBorderColor
  {
    get => this._captureBorderColor;
    set
    {
      if (value.Equals((object) this._captureBorderColor))
        return;
      this._captureBorderColor = value;
      this.DisposeCaptureBorderPen();
      this.Invalidate(this.CaptureRectToInvalidate);
      this.Update();
    }
  }

  private Pen CaptureBorderPen
  {
    get
    {
      if (this._captureBorderPen == null)
        this._captureBorderPen = new Pen(this._captureBorderColor);
      return this._captureBorderPen;
    }
  }

  private Rectangle CaptureRect
  {
    get
    {
      Point location;
      ref Point local = ref location;
      Size clientSize = this.ClientSize;
      int x = (int) Math.Round((double) clientSize.Width / 2.0 - (double) this._captureSize.Width / 2.0);
      clientSize = this.ClientSize;
      int y = (int) Math.Round((double) clientSize.Height / 2.0 - (double) this._captureSize.Height / 2.0);
      local = new Point(x, y);
      return new Rectangle(location, this._captureSize);
    }
  }

  private Rectangle CaptureRectToInvalidate
  {
    get
    {
      Rectangle captureRect = this.CaptureRect;
      ++captureRect.Width;
      ++captureRect.Height;
      return captureRect;
    }
  }

  private void DrawCaptureRect(PaintEventArgs e)
  {
    e.Graphics.DrawRectangle(this.CaptureBorderPen, this.CaptureRect);
  }

  [Category("Appearance")]
  [Description("Gets/Sets the text to prompt the user signature")]
  [DefaultValue("Sign here")]
  public string SignaturePromptText
  {
    get => this._signaturePromptText;
    set
    {
      this.Invalidate(this.SignatureRect);
      this._signaturePromptText = value;
      this.Invalidate(this.SignatureRect);
      this.Update();
    }
  }

  private Rectangle SignatureRect
  {
    get
    {
      Graphics graphics = (Graphics) null;
      try
      {
        graphics = Graphics.FromHwnd(this.Handle);
        Size size = graphics.MeasureString(this.SignaturePromptText, this.Font).ToSize();
        return new Rectangle(new Point((int) Math.Round((double) this.ClientSize.Width / 2.0 - (double) size.Width / 2.0), this.CaptureRect.Bottom + 5), size);
      }
      finally
      {
        graphics.Dispose();
      }
    }
  }

  private void DrawSignaturePromptText(PaintEventArgs e)
  {
    Rectangle signatureRect = this.SignatureRect;
    e.Graphics.DrawString(this.SignaturePromptText, this.Font, Brushes.Black, (float) signatureRect.X, (float) signatureRect.Y);
  }

  private Bitmap SignatureBitmap
  {
    get
    {
      if (this._signatureBitmap == null)
        this._signatureBitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
      return this._signatureBitmap;
    }
  }

  private Graphics SignatureGraphics
  {
    get
    {
      if (this._signatureGraphics == null)
        this._signatureGraphics = Graphics.FromImage((Image) this.SignatureBitmap);
      return this._signatureGraphics;
    }
  }

  private void DrawSignature(PaintEventArgs e)
  {
    ImageAttributes imageAttributes = (ImageAttributes) null;
    try
    {
      imageAttributes = new ImageAttributes();
      if (Control.MouseButtons == MouseButtons.Right)
      {
        Point positioningOffset = this.GetPositioningOffset();
        Graphics graphics = e.Graphics;
        Bitmap signatureBitmap = this.SignatureBitmap;
        Rectangle clientRectangle = this.ClientRectangle;
        int x = positioningOffset.X;
        int y = positioningOffset.Y;
        Size clientSize = this.ClientSize;
        int width = clientSize.Width;
        clientSize = this.ClientSize;
        int height = clientSize.Height;
        ImageAttributes imageAttr = imageAttributes;
        graphics.DrawImage((Image) signatureBitmap, clientRectangle, x, y, width, height, GraphicsUnit.Pixel, imageAttr);
      }
      else
      {
        Graphics graphics = e.Graphics;
        Bitmap signatureBitmap = this.SignatureBitmap;
        Rectangle clientRectangle = this.ClientRectangle;
        Size clientSize = this.ClientSize;
        int width = clientSize.Width;
        clientSize = this.ClientSize;
        int height = clientSize.Height;
        ImageAttributes imageAttr = imageAttributes;
        graphics.DrawImage((Image) signatureBitmap, clientRectangle, 0, 0, width, height, GraphicsUnit.Pixel, imageAttr);
      }
    }
    finally
    {
      imageAttributes.Dispose();
    }
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);
    if (!this.DesignMode)
      this.DrawSignature(e);
    this.DrawSignaturePromptText(e);
    this.DrawCaptureRect(e);
  }

  protected override void OnSizeChanged(EventArgs e)
  {
    base.OnSizeChanged(e);
    if (this.ClientSize.Width == 0 || this.ClientSize.Height == 0)
      return;
    Bitmap signatureBitmap = this.SignatureBitmap;
    this._signatureBitmap = (Bitmap) null;
    this.DisposeSignatureGraphics();
    Size clientSize = this.ClientSize;
    int x = (int) Math.Round((double) clientSize.Width / 2.0) - (int) Math.Round((double) signatureBitmap.Width / 2.0);
    clientSize = this.ClientSize;
    int y = (int) Math.Round((double) clientSize.Height / 2.0) - (int) Math.Round((double) signatureBitmap.Height / 2.0);
    this.SignatureGraphics.DrawImage((Image) signatureBitmap, x, y);
    signatureBitmap.Dispose();
  }

  protected override void OnMouseMove(MouseEventArgs e)
  {
    base.OnMouseMove(e);
    switch (Control.MouseButtons)
    {
      case MouseButtons.Left:
        if (this._lastPoint.Equals((object) Point.Empty))
        {
          this.SignatureBitmap.SetPixel(e.X, e.Y, this._signaturePenColor);
          break;
        }
        Point pt2 = new Point(e.X, e.Y);
        this.SignatureGraphics.DrawLine(this.SignaturePen, this._lastPoint, pt2);
        int x = Math.Min(pt2.X, this._lastPoint.X);
        int y = Math.Min(pt2.Y, this._lastPoint.Y);
        int width = Math.Max(pt2.X, this._lastPoint.X) - x + 1;
        int height = Math.Max(pt2.Y, this._lastPoint.Y) - y + 1;
        this.Invalidate(new Rectangle(x, y, width, height));
        this.Update();
        this._lastPoint = pt2;
        break;
      case MouseButtons.Right:
        this.Refresh();
        break;
    }
  }

  protected override void OnMouseUp(MouseEventArgs e)
  {
    this._lastPoint = Point.Empty;
    this.Cursor = Cursors.Default;
    if (!this._copyImageOnMouseUp)
      return;
    Bitmap signatureBitmap = this.SignatureBitmap;
    this._signatureBitmap = (Bitmap) null;
    this.DisposeSignatureGraphics();
    Point positioningOffset = this.GetPositioningOffset();
    this.SignatureGraphics.DrawImage((Image) signatureBitmap, -positioningOffset.X, -positioningOffset.Y);
    signatureBitmap.Dispose();
    this.Refresh();
  }

  protected override void OnMouseDown(MouseEventArgs e)
  {
    if (Control.MouseButtons == MouseButtons.Right)
    {
      this.Cursor = Cursors.Hand;
      this._originalDownPoint = new Point(e.X, e.Y);
      this._copyImageOnMouseUp = true;
    }
    else
    {
      this.Cursor = Cursors.Cross;
      this._lastPoint = new Point(e.X, e.Y);
      this._copyImageOnMouseUp = false;
    }
  }

  private Point GetPositioningOffset()
  {
    Point client = this.PointToClient(Cursor.Position);
    return new Point(this._originalDownPoint.X - client.X, this._originalDownPoint.Y - client.Y);
  }

  private void SignatureCapturePanel_Load(object sender, EventArgs e)
  {
    ((Bitmap) this.pbTrash.Image).MakeTransparent(Color.White);
    ((Bitmap) this.pbOpen.Image).MakeTransparent(Color.White);
    ((Bitmap) this.pbColors.Image).MakeTransparent(Color.White);
  }

  private void pbTrash_Click(object sender, EventArgs e) => this.Clear();

  public void Clear()
  {
    this.DisposeSignatureBitmap();
    this.DisposeSignatureGraphics();
    this.Refresh();
  }

  private void pb_MouseEnter(object sender, EventArgs e)
  {
    ((PictureBox) sender).BorderStyle = BorderStyle.FixedSingle;
  }

  private void pb_MouseLeave(object sender, EventArgs e)
  {
    ((PictureBox) sender).BorderStyle = BorderStyle.None;
  }

  private void pb_MouseDown(object sender, MouseEventArgs e)
  {
    ((PictureBox) sender).BorderStyle = BorderStyle.Fixed3D;
  }

  private void pb_MouseUp(object sender, MouseEventArgs e)
  {
    ((PictureBox) sender).BorderStyle = BorderStyle.FixedSingle;
  }

  private void SignatureCapturePanel_MouseMove(object sender, MouseEventArgs e)
  {
    this.pbTrash.BorderStyle = BorderStyle.None;
    this.pbOpen.BorderStyle = BorderStyle.None;
    this.pbColors.BorderStyle = BorderStyle.None;
  }

  private void pbOpen_Click(object sender, EventArgs e)
  {
    if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    this.DisposeSignatureBitmap();
    this.DisposeSignatureGraphics();
    Bitmap originalBitmap = new Bitmap(this.OpenFileDialog1.FileName);
    this._signatureBitmap = !this.IsImageLargerThanTarget(originalBitmap) || MessageBox.Show("The signature file specified is too large, would you like the IMS to automatically resize it?", "Resize this signature?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes ? originalBitmap : this.FindSignature(originalBitmap);
    this._signatureBitmap.MakeTransparent(this._signatureBitmap.GetPixel(0, 0));
    int width = this._signatureBitmap.Width;
    int height = this._signatureBitmap.Height;
    int x = (int) Math.Round((double) this.ClientSize.Width / 2.0) - (int) Math.Round((double) width / 2.0);
    int y = (int) Math.Round((double) this.ClientSize.Height / 2.0) - (int) Math.Round((double) height / 2.0);
    this._signatureBitmap.MakeTransparent(this._signatureBitmap.GetPixel(width - 1, height - 1));
    Bitmap signatureBitmap = this.SignatureBitmap;
    this._signatureBitmap = (Bitmap) null;
    this.SignatureGraphics.DrawImage((Image) signatureBitmap, x, y);
    signatureBitmap.Dispose();
    this.Refresh();
  }

  private Bitmap FindSignature(Bitmap originalBitmap)
  {
    if (originalBitmap == null)
      throw new ArgumentNullException(nameof (originalBitmap));
    Rectangle captureRect = this.CaptureRect;
    Bitmap signature;
    if (!this.IsImageLargerThanTarget(originalBitmap))
    {
      signature = originalBitmap;
    }
    else
    {
      Rectangle srcRect = this.ScanForSignatureRect(originalBitmap);
      Bitmap bitmap = new Bitmap((Image) originalBitmap, captureRect.Width, captureRect.Height);
      using (new Bitmap((Image) originalBitmap, srcRect.Width, srcRect.Height))
      {
        using (Graphics graphics = Graphics.FromImage((Image) bitmap))
        {
          graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
          graphics.DrawImage((Image) originalBitmap, new Rectangle(5, 5, captureRect.Width - 10, captureRect.Height - 10), srcRect, GraphicsUnit.Pixel);
        }
      }
      signature = bitmap;
    }
    return signature;
  }

  private int ScanForFirstNonNeutralColor(
    Color neutralColor,
    Bitmap originalBitmap,
    ImageScanDirection scanDirection,
    int stepLength = 4)
  {
    int num1 = (int) Interaction.IIf(scanDirection == ImageScanDirection.LeftToRight, (object) 0, (object) (originalBitmap.Width - 1));
    int num2 = (int) Interaction.IIf(scanDirection == ImageScanDirection.TopToBottom, (object) 0, (object) (originalBitmap.Height - 1));
    int num3 = (int) Interaction.IIf(num1 == 0, (object) stepLength, (object) -stepLength);
    int num4 = (int) Interaction.IIf(num2 == 0, (object) stepLength, (object) -stepLength);
    int num5 = (int) Interaction.IIf(num1 == 0, (object) (originalBitmap.Width - 1), (object) 0);
    int num6 = (int) Interaction.IIf(num2 == 0, (object) (originalBitmap.Height - 1), (object) 0);
    int num7;
    if (scanDirection == ImageScanDirection.LeftToRight || scanDirection == ImageScanDirection.RightToLeft)
    {
      int num8 = num1;
      int num9 = num5;
      int num10 = num3;
      for (int x = num8; (num10 >> 31 /*0x1F*/ ^ x) <= (num10 >> 31 /*0x1F*/ ^ num9); x += num10)
      {
        int num11 = originalBitmap.Height - 1;
        int num12 = stepLength;
        for (int y = 0; (num12 >> 31 /*0x1F*/ ^ y) <= (num12 >> 31 /*0x1F*/ ^ num11); y += num12)
        {
          if (originalBitmap.GetPixel(x, y) != neutralColor)
          {
            num7 = x;
            goto label_17;
          }
        }
      }
    }
    else
    {
      int num13 = num2;
      int num14 = num6;
      int num15 = num4;
      for (int y = num13; (num15 >> 31 /*0x1F*/ ^ y) <= (num15 >> 31 /*0x1F*/ ^ num14); y += num15)
      {
        int num16 = originalBitmap.Width - 1;
        int num17 = stepLength;
        for (int x = 0; (num17 >> 31 /*0x1F*/ ^ x) <= (num17 >> 31 /*0x1F*/ ^ num16); x += num17)
        {
          if (originalBitmap.GetPixel(x, y) != neutralColor)
          {
            num7 = y;
            goto label_17;
          }
        }
      }
    }
label_17:
    return num7;
  }

  private Rectangle ScanForSignatureRect(Bitmap originalBitmap)
  {
    Color pixel = originalBitmap.GetPixel(0, 0);
    int x = this.ScanForFirstNonNeutralColor(pixel, originalBitmap, ImageScanDirection.LeftToRight);
    int num1 = this.ScanForFirstNonNeutralColor(pixel, originalBitmap, ImageScanDirection.RightToLeft);
    int y = this.ScanForFirstNonNeutralColor(pixel, originalBitmap, ImageScanDirection.TopToBottom);
    int num2 = this.ScanForFirstNonNeutralColor(pixel, originalBitmap, ImageScanDirection.BottomToTop);
    Rectangle rectangle;
    if (num1 > x && num2 > y)
    {
      rectangle = new Rectangle(x, y, num1 - x, num2 - y);
    }
    else
    {
      ref Rectangle local = ref rectangle;
      Size size = originalBitmap.Size;
      int width = size.Width;
      size = originalBitmap.Size;
      int height = size.Height;
      local = new Rectangle(0, 0, width, height);
    }
    return rectangle;
  }

  public bool IsImageLargerThanTarget(Bitmap originalBitmap)
  {
    if (originalBitmap == null)
      throw new ArgumentNullException(nameof (originalBitmap));
    Rectangle captureRect = this.CaptureRect;
    return originalBitmap.Width > captureRect.Width || originalBitmap.Height > captureRect.Height;
  }

  [DefaultValue(typeof (Color), "Black")]
  public Color SignaturePenColor
  {
    get => this._signaturePenColor;
    set
    {
      if (this._signaturePenColor.Equals((object) value))
        return;
      this._signaturePenColor = value;
      this.DisposeSignaturePen();
      this.Refresh();
    }
  }

  [DefaultValue(2)]
  public int SignaturePenWidth
  {
    get => this._signaturePenWidth;
    set
    {
      this._signaturePenWidth = value;
      this.DisposeSignaturePen();
    }
  }

  private void pbColors_Click(object sender, EventArgs e)
  {
    if (this.ColorDialog1.ShowDialog() != DialogResult.OK)
      return;
    this.SignaturePenColor = this.ColorDialog1.Color;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Image SignatureImage
  {
    get
    {
      Size captureSize = this.CaptureSize;
      int width = captureSize.Width;
      captureSize = this.CaptureSize;
      int height = captureSize.Height;
      Bitmap signatureImage = new Bitmap(width, height);
      Graphics graphics = (Graphics) null;
      SolidBrush solidBrush = (SolidBrush) null;
      try
      {
        graphics = Graphics.FromImage((Image) signatureImage);
        solidBrush = new SolidBrush(this.BackColor);
        graphics.FillRectangle((Brush) solidBrush, new Rectangle(0, 0, signatureImage.Width, signatureImage.Height));
        graphics.DrawImage((Image) this.SignatureBitmap, 0, 0, this.CaptureRect, GraphicsUnit.Pixel);
      }
      finally
      {
        solidBrush?.Dispose();
        graphics?.Dispose();
      }
      return (Image) signatureImage;
    }
    set
    {
      if (value == null)
        throw new ArgumentNullException(nameof (value));
      this.DisposeSignatureGraphics();
      this.DisposeSignatureBitmap();
      int width1 = value.Width;
      int height1 = value.Height;
      int num1 = width1;
      Size size = this.CaptureSize;
      int width2 = size.Width;
      if (num1 == width2)
      {
        int num2 = height1;
        size = this.CaptureSize;
        int height2 = size.Height;
        if (num2 == height2)
        {
          Rectangle captureRect = this.CaptureRect;
          this.SignatureGraphics.DrawImage(value, captureRect.X, captureRect.Y);
          goto label_6;
        }
      }
      size = this.ClientSize;
      int x = (int) Math.Round((double) size.Width / 2.0) - (int) Math.Round((double) width1 / 2.0);
      size = this.ClientSize;
      int y = (int) Math.Round((double) size.Height / 2.0) - (int) Math.Round((double) height1 / 2.0);
      this.SignatureGraphics.DrawImage(value, x, y);
label_6:
      this.Refresh();
    }
  }

  public byte[] GetSignatureImageBytes()
  {
    MemoryStream memoryStream = new MemoryStream();
    try
    {
      Image signatureImage = this.SignatureImage;
      Bitmap bitmap = (Bitmap) null;
      Graphics graphics = (Graphics) null;
      try
      {
        bitmap = new Bitmap(signatureImage.Width, signatureImage.Height, PixelFormat.Format24bppRgb);
        graphics = Graphics.FromImage((Image) bitmap);
        graphics.DrawImageUnscaled(signatureImage, new Point(0, 0));
        bitmap.Save((Stream) memoryStream, ImageFormat.Png);
      }
      finally
      {
        bitmap?.Dispose();
        graphics?.Dispose();
      }
      signatureImage.Dispose();
      return memoryStream.ToArray();
    }
    finally
    {
      memoryStream.Close();
    }
  }

  public void SetSignatureImageBytes(byte[] bytes)
  {
    if (bytes.Length <= 0)
      return;
    MemoryStream memoryStream = new MemoryStream(bytes);
    try
    {
      this.SignatureImage = Image.FromStream((Stream) memoryStream);
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.Clear();
      ProjectData.ClearProjectError();
    }
    finally
    {
      memoryStream.Close();
    }
  }
}
