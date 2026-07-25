// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ImageCache
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

#nullable disable
namespace MGASystems.Tools;

public sealed class ImageCache : IDisposable
{
  private static ImageCache _imageCache;
  private List<ImageCache.KeyedImage> _images;

  private ImageCache() => this._images = new List<ImageCache.KeyedImage>();

  public static Image MakeTransparent(object image)
  {
    if (image == null)
      throw new ArgumentNullException(nameof (image));
    return image is byte[] image1 ? ImageCache.MakeTransparent(image1) : throw new ArgumentException("must be a byte array", nameof (image));
  }

  public static Image MakeTransparent(byte[] image)
  {
    if (image == null)
      throw new ArgumentNullException(nameof (image));
    using (MemoryStream image1 = new MemoryStream(image))
      return ImageCache.MakeTransparent(image1);
  }

  public static Image MakeTransparent(MemoryStream image)
  {
    Bitmap bitmap = image != null ? new Bitmap((Stream) image) : throw new ArgumentNullException(nameof (image));
    bitmap.MakeTransparent();
    return (Image) bitmap;
  }

  public Bitmap MakeTransparent(Bitmap bitmap, Color maskColor)
  {
    if (bitmap == null)
      throw new ArgumentNullException(nameof (bitmap));
    bitmap.MakeTransparent(maskColor);
    return bitmap;
  }

  public Image MakeTransparent(Image image)
  {
    return !(image is Bitmap bitmap) ? image : (Image) this.MakeTransparent(bitmap);
  }

  public Bitmap MakeTransparent(Bitmap bitmap)
  {
    return bitmap != null ? this.MakeTransparent(bitmap, bitmap.GetPixel(0, 0)) : throw new ArgumentNullException(nameof (bitmap));
  }

  public Image LoadImage(string resName) => this.LoadImage(resName, true);

  public static Image CreateLayeredImage(
    Image baseImage,
    Image overlayedImage,
    ContentAlignment overlayAlignment)
  {
    Bitmap original = new Bitmap(baseImage);
    Bitmap bitmap = new Bitmap(overlayedImage);
    Bitmap layeredImage = new Bitmap((Image) original);
    Graphics graphics = Graphics.FromImage((Image) layeredImage);
    graphics.DrawImage((Image) original, 0, 0);
    Point point;
    switch (overlayAlignment)
    {
      case ContentAlignment.TopLeft:
        point = new Point(0, 0);
        break;
      case ContentAlignment.TopCenter:
        point = new Point((int) Math.Round((double) (original.Size.Width - bitmap.Width) / 2.0), 0);
        break;
      case ContentAlignment.TopRight:
        point = new Point(original.Size.Width - bitmap.Width, 0);
        break;
      case ContentAlignment.MiddleLeft:
        ref Point local1 = ref point;
        Size size1 = original.Size;
        int height1 = size1.Height;
        size1 = bitmap.Size;
        int height2 = size1.Height;
        int y1 = (int) Math.Round((double) (height1 - height2) / 2.0);
        local1 = new Point(0, y1);
        break;
      case ContentAlignment.MiddleCenter:
        point = new Point((int) Math.Round((double) (original.Size.Width - bitmap.Width) / 2.0), (int) Math.Round((double) (original.Size.Height - bitmap.Size.Height) / 2.0));
        break;
      case ContentAlignment.MiddleRight:
        ref Point local2 = ref point;
        int x = original.Size.Width - bitmap.Width;
        Size size2 = original.Size;
        int height3 = size2.Height;
        size2 = bitmap.Size;
        int height4 = size2.Height;
        int y2 = (int) Math.Round((double) (height3 - height4) / 2.0);
        local2 = new Point(x, y2);
        break;
      case ContentAlignment.BottomLeft:
        point = new Point(0, original.Size.Height - bitmap.Height);
        break;
      case ContentAlignment.BottomCenter:
        point = new Point((int) Math.Round((double) (original.Size.Width - bitmap.Width) / 2.0), original.Size.Height - bitmap.Height);
        break;
      case ContentAlignment.BottomRight:
        point = new Point(original.Size.Width - bitmap.Width, original.Size.Height - bitmap.Height);
        break;
    }
    graphics.DrawImage((Image) bitmap, point);
    graphics.Dispose();
    original.Dispose();
    bitmap.Dispose();
    return (Image) layeredImage;
  }

  public Image FindImage(string key)
  {
    Image image1;
    try
    {
      foreach (ImageCache.KeyedImage image2 in this._images)
      {
        if (Operators.CompareString(key, image2._key, false) == 0)
        {
          image1 = image2._image;
          goto label_6;
        }
      }
    }
    finally
    {
      List<ImageCache.KeyedImage>.Enumerator enumerator;
      enumerator.Dispose();
    }
    image1 = (Image) null;
label_6:
    return image1;
  }

  public static Image ScaleImage(Image image, float percentage)
  {
    if ((double) percentage <= 0.0)
      throw new ArgumentException("percentage must be greater than 0", nameof (percentage));
    percentage /= 100f;
    if (image == null)
      throw new ArgumentNullException(nameof (image));
    using (Image image1 = (Image) image.Clone())
    {
      image1.RotateFlip(RotateFlipType.Rotate180FlipNone);
      image1.RotateFlip(RotateFlipType.Rotate180FlipNone);
      int TruePart1 = (int) Math.Round((double) percentage * (double) image1.Width);
      int TruePart2 = (int) Math.Round((double) percentage * (double) image1.Height);
      return image1.GetThumbnailImage((int) Interaction.IIf(TruePart1 > 0, (object) TruePart1, (object) 1), (int) Interaction.IIf(TruePart2 > 0, (object) TruePart2, (object) 1), (Image.GetThumbnailImageAbort) null, IntPtr.Zero);
    }
  }

  public Image LoadImagePadLocked(string resName) => this.LoadImagePadLocked(resName, true);

  public Image LoadImagePadLocked(string resName, bool addToCache)
  {
    string key = $"{resName}_LOCKED";
    Image image = this.FindImage(key);
    if (image == null)
    {
      image = ImageCache.CreateLayeredImage(this.LoadImage(resName, false), this.PadLock, ContentAlignment.BottomRight);
      if (addToCache)
        this._images.Add(new ImageCache.KeyedImage(image, key));
    }
    return image;
  }

  public Image LoadImageTimeConstrained(string resName, bool addToCache)
  {
    string key = $"{resName}_TIMECONSTRAINED";
    Image image = this.FindImage(key);
    if (image == null)
    {
      image = ImageCache.CreateLayeredImage(this.LoadImage(resName, false), this.TimeConstraintOverLay, ContentAlignment.TopLeft);
      if (addToCache)
        this._images.Add(new ImageCache.KeyedImage(image, key));
    }
    return image;
  }

  public Image LoadImageCancelled(string resName, bool addToCache)
  {
    string key = $"{resName}_CANCELLED";
    Image image = this.FindImage(key);
    if (image == null)
    {
      image = ImageCache.CreateLayeredImage(this.LoadImage(resName, false), this.Undo, ContentAlignment.TopLeft);
      if (addToCache)
        this._images.Add(new ImageCache.KeyedImage(image, key));
    }
    return image;
  }

  public Image LoadImage(string resName, bool addToCache)
  {
    Image image1 = this.FindImage(resName);
    Image image2;
    if (image1 == null)
    {
      Stream manifestResourceStream = this.GetType().Assembly.GetManifestResourceStream(resName);
      if (manifestResourceStream == null)
      {
        image2 = this.DiaryRed;
        goto label_6;
      }
      image1 = this.MakeTransparent(Image.FromStream(manifestResourceStream));
      manifestResourceStream.Close();
      if (addToCache)
        this._images.Add(new ImageCache.KeyedImage(image1, resName));
    }
    image2 = image1;
label_6:
    return image2;
  }

  public void FlushCache()
  {
    try
    {
      foreach (ImageCache.KeyedImage image in this._images)
        image._image.Dispose();
    }
    finally
    {
      List<ImageCache.KeyedImage>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this._images.Clear();
  }

  public Image RemoveImage(Image imageToUnload)
  {
    Image image1;
    try
    {
      foreach (ImageCache.KeyedImage image2 in this._images)
      {
        if (image2._image == imageToUnload)
        {
          this._images.Remove(image2);
          image1 = image2._image;
          goto label_6;
        }
      }
    }
    finally
    {
      List<ImageCache.KeyedImage>.Enumerator enumerator;
      enumerator.Dispose();
    }
    image1 = (Image) null;
label_6:
    return image1;
  }

  public void UnloadAndDisposeImage(Image imageToUnload)
  {
    this.RemoveImage(imageToUnload).Dispose();
  }

  public void Dispose() => this.FlushCache();

  public Image Coins => this.LoadImage("MGASystems.Tools.coins.png");

  public Image Open => this.LoadImage("MGASystems.Tools.open.bmp");

  public Image NoteDiaryComplete => this.LoadImage("MGASystems.Tools.NoteDiaryComplete.png");

  public Image NoteDiaryNotComplete => this.LoadImage("MGASystems.Tools.NoteDiaryNotComplete.png");

  public Image NoteUser => this.LoadImage("MGASystems.Tools.NoteUser.png");

  public Image NoteRead => this.LoadImage("MGASystems.Tools.NoteRead.png");

  public Image NoteUnread => this.LoadImage("MGASystems.Tools.NoteUnread.png");

  public Image DiaryRed => this.LoadImage("MGASystems.Tools.diaryred.bmp");

  public Image DiaryClear => this.LoadImage("MGASystems.Tools.diaryclear.bmp");

  public Image DiaryYellow => this.LoadImage("MGASystems.Tools.diaryyellow.bmp");

  public Image DiaryGreen => this.LoadImage("MGASystems.Tools.diarygreen.bmp");

  public Image LargeSearchGlass => this.LoadImage("MGASystems.Tools.searchGlass.bmp");

  public Image FactorSet => this.LoadImage("MGASystems.Tools.FactorSet.bmp");

  public Image FactorSetPadLocked => this.LoadImagePadLocked("MGASystems.Tools.FactorSet.bmp");

  public Image MailDark => this.LoadImage("MGASystems.Tools.mail16_d.bmp");

  public Image SortAscending => this.LoadImage("MGASystems.Tools.SortAsc.bmp");

  public Image SortDescending => this.LoadImage("MGASystems.Tools.SortDesc.bmp");

  public Image SortUnspecified => this.LoadImage("MGASystems.Tools.SortUnspecified.bmp");

  public Image TimeConstraintOverLay => this.LoadImage("MGASystems.Tools.timeConstraint.bmp");

  public Image DiaryMark => this.LoadImageTimeConstrained("MGASystems.Tools.Diary.bmp", true);

  public Image DiaryUnMark => this.LoadImageCancelled("MGASystems.Tools.Diary.bmp", true);

  public Image NoteEntry => this.LoadImage("MGASystems.Tools.note.png");

  public Image MailOpen => this.LoadImage("MGASystems.Tools.mailOpen.bmp");

  public Image OutlookStop => this.LoadImage("MGASystems.Tools.outlookStop.bmp");

  public Image OutlookRefresh => this.LoadImage("MGASystems.Tools.outlookRefresh.bmp");

  public Image MGALogo => this.LoadImage("MGASystems.Tools.MgaLogo.bmp");

  public Image TodayDecorator => this.LoadImage("MGASystems.Tools.TodayDecorator.bmp");

  public Image NoteMain => this.LoadImage("MGASystems.Tools.NoteMain.bmp");

  public Image Check => this.LoadImage("MGASystems.Tools.check.gif");

  public Image NoteSystem => this.LoadImage("MGASystems.Tools.note.png");

  public Image DiaryOpen => this.LoadImage("MGASystems.Tools.openDiary.bmp");

  public Image NoteOpen => this.LoadImage("MGASystems.Tools.noteOpen.bmp");

  public Image PrintAllDocuments => this.LoadImage("MGASystems.Tools.printAllDocuments.gif");

  public Image PrintDocument => this.LoadImage("MGASystems.Tools.printDocument.gif");

  public Image Properties => this.LoadImage("MGASystems.Tools.properties.bmp");

  public Image Run => this.LoadImage("MGASystems.Tools.run.bmp");

  public Image Print_Small => this.LoadImage("MGASystems.Tools.smallPrinter.bmp");

  public Image Print => this.LoadImage("MGASystems.Tools.print.bmp");

  public Image Unbind => this.LoadImage("MGASystems.Tools.unbind.bmp");

  public Image PrintSelectedDocuments
  {
    get => this.LoadImage("MGASystems.Tools.printSelectedDocuments.gif");
  }

  public Image Help => this.LoadImage("MGASystems.Tools.Help.bmp");

  public Image Rate => this.LoadImage("MGASystems.Tools.rate.bmp");

  public Image Eraser => this.LoadImage("MGASystems.Tools.Eraser.bmp");

  public Image Folder => this.LoadImage("MGASystems.Tools.folder16.bmp");

  public Image DocAssociated => this.LoadImage("MGASystems.Tools.docAssociated.bmp");

  public Image DocMain => this.LoadImage("MGASystems.Tools.page.png");

  public Image DocDisAssociated => this.LoadImage("MGASystems.Tools.docDisAssociated.bmp");

  public Image MoveFirst => this.LoadImage("MGASystems.Tools.First.gif");

  public Image MoveLast => this.LoadImage("MGASystems.Tools.Last.gif");

  public Image ClearanceSearch => this.LoadImage("MGASystems.Tools.clearancesearch24.gif");

  public Image ClaimsSearch => this.LoadImage("MGASystems.Tools.claimsearch24.gif");

  public Image MovePrev => this.LoadImage("MGASystems.Tools.Previous.gif");

  public Image MoveNext => this.LoadImage("MGASystems.Tools.Next.gif");

  public Image Forward => this.LoadImage("MGASystems.Tools.forward.bmp");

  public Image User => this.LoadImage("MGASystems.Tools.user.bmp");

  public Image Group => this.LoadImage("MGASystems.Tools.group.bmp");

  public Image QuickLaunch => this.LoadImage("MGASystems.Tools.QuickLaunch.bmp");

  public Image Delete => this.LoadImage("MGASystems.Tools.delete24.bmp");

  public Image Save => this.LoadImage("MGASystems.Tools.save24.bmp");

  public Image Excel => this.LoadImage("MGASystems.Tools.excel.bmp");

  public Image ExportWordDocument => this.LoadImage("MGASystems.Tools.exportWordDocument.bmp");

  public Image ExportWordDocuments
  {
    get => this.LoadImage("MGASystems.Tools.exportMultipleWordDocuments.bmp");
  }

  public Image Undo => this.LoadImage("MGASystems.Tools.undo24.bmp");

  public Image RTFExport => this.LoadImage("MGASystems.Tools.rtfExport.bmp");

  public Image Info => this.LoadImage("MGASystems.Tools.info.bmp");

  public Image ArrowUp => this.LoadImage("MGASystems.Tools.up.gif");

  public Image ArrowDown => this.LoadImage("MGASystems.Tools.down.gif");

  public Image Pin => this.LoadImage("MGASystems.Tools.Pin.bmp");

  public Image ReportGeneration => this.LoadImage("MGASystems.Tools.reportGeneration.gif");

  public Image ReportDone => this.LoadImage("MGASystems.Tools.reportDone.gif");

  public Image Refresh => this.LoadImage("MGASystems.Tools.refresh24_h.bmp");

  public Image NewImage => this.LoadImage("MGASystems.Tools.new.bmp");

  public Image PadLock => this.LoadImage("MGASystems.Tools.PadLock.bmp");

  public Image Search => this.LoadImage("MGASystems.Tools.search24.bmp");

  public Image Envelope => this.LoadImage("MGASystems.Tools.envelope.bmp");

  public Image LabelSheet => this.LoadImage("MGASystems.Tools.labelsheet.bmp");

  public Image Envelope_FaceDown_1 => this.LoadImage("MGASystems.Tools.envelope_facedown_1.bmp");

  public Image Envelope_FaceDown_2 => this.LoadImage("MGASystems.Tools.envelope_facedown_2.bmp");

  public Image Envelope_FaceDown_3 => this.LoadImage("MGASystems.Tools.envelope_facedown_3.bmp");

  public Image Envelope_FaceDown_4 => this.LoadImage("MGASystems.Tools.envelope_facedown_4.bmp");

  public Image Envelope_FaceDown_5 => this.LoadImage("MGASystems.Tools.envelope_facedown_5.bmp");

  public Image Envelope_FaceDown_6 => this.LoadImage("MGASystems.Tools.envelope_facedown_6.bmp");

  public Image Envelope_FaceUp_1 => this.LoadImage("MGASystems.Tools.envelope_faceup_1.bmp");

  public Image Envelope_FaceUp_2 => this.LoadImage("MGASystems.Tools.envelope_faceup_2.bmp");

  public Image Envelope_FaceUp_3 => this.LoadImage("MGASystems.Tools.envelope_faceup_3.bmp");

  public Image Envelope_FaceUp_4 => this.LoadImage("MGASystems.Tools.envelope_faceup_4.bmp");

  public Image Envelope_FaceUp_5 => this.LoadImage("MGASystems.Tools.envelope_faceup_5.bmp");

  public Image Envelope_Selected => this.LoadImage("MGASystems.Tools.envelope_selected.bmp");

  public Image Envelope_FaceUp_6 => this.LoadImage("MGASystems.Tools.envelope_faceup_6.bmp");

  public Image Edit => this.LoadImage("MGASystems.Tools.edit.bmp");

  public Image Dollar => this.LoadImage("MGASystems.Tools.dollar.bmp");

  public Image BulkEmail => this.LoadImage("MGASystems.Tools.bulkmail.gif");

  public static ImageCache Instance
  {
    get
    {
      if (ImageCache._imageCache == null)
        ImageCache._imageCache = new ImageCache();
      return ImageCache._imageCache;
    }
  }

  private sealed class KeyedImage
  {
    public Image _image;
    public string _key;

    public KeyedImage(Image image, string key)
    {
      this._image = image;
      this._key = key;
    }
  }
}
