// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Envelopes.Envelope
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Data;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Forms.Envelopes;

public sealed class Envelope : IDisposable
{
  private Envelope.addressField _deliveryAddress;
  private Envelope.addressField _returnAddress;
  private float _width;
  private float _height;
  private int _typeID;
  private Envelope.EnvelopeFeedMethod _feedMethod;
  private Envelope.EnvelopeFace _face;
  private bool disposedValue;

  private virtual PrintDocument _document
  {
    get => this.__document;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PrintPageEventHandler pageEventHandler = new PrintPageEventHandler(this.PrintPage);
      PrintDocument document1 = this.__document;
      if (document1 != null)
        document1.PrintPage -= pageEventHandler;
      this.__document = value;
      PrintDocument document2 = this.__document;
      if (document2 == null)
        return;
      document2.PrintPage += pageEventHandler;
    }
  }

  public void Print() => this._document.Print();

  private void PrintPage(object sender, PrintPageEventArgs e)
  {
    e.Graphics.PageUnit = GraphicsUnit.Inch;
    float num = (float) e.PageSettings.PaperSize.Width / 100f;
    switch (this.FeedMethod)
    {
      case Envelope.EnvelopeFeedMethod.envelope_feed_2:
        e.Graphics.TranslateTransform((float) (((double) num - (double) this.Width) / 2.0), 0.0f);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_3:
        e.Graphics.TranslateTransform(num - this.Width, 0.0f);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_4:
        e.Graphics.TranslateTransform(0.0f, this.Width);
        e.Graphics.RotateTransform(-90f);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_5:
        e.Graphics.TranslateTransform((float) (((double) num - (double) this.Height) / 2.0), this.Width);
        e.Graphics.RotateTransform(-90f);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_6:
        e.Graphics.TranslateTransform(num - this.Height, this.Width);
        e.Graphics.RotateTransform(-90f);
        break;
    }
    e.Graphics.DrawString(this.ReturnAddress.Address, this.ReturnAddress.Font, Brushes.Black, this.ReturnAddress.fromLeft, this.ReturnAddress.fromTop);
    e.Graphics.DrawString(this.DeliveryAddress.Address, this.DeliveryAddress.Font, Brushes.Black, this.DeliveryAddress.fromLeft, this.DeliveryAddress.fromTop);
  }

  public Envelope Clone()
  {
    Envelope envelope = new Envelope()
    {
      Height = this.Height,
      Width = this.Width,
      EnvelopeTypeID = this.EnvelopeTypeID,
      DeliveryAddress = {
        Font = this.DeliveryAddress.Font,
        fromLeft = this.DeliveryAddress.fromLeft,
        fromTop = this.DeliveryAddress.fromTop
      },
      ReturnAddress = {
        Font = this.ReturnAddress.Font,
        fromLeft = this.ReturnAddress.fromLeft,
        fromTop = this.ReturnAddress.fromTop
      },
      Face = this.Face,
      FeedMethod = this.FeedMethod
    };
    envelope.EnvelopeTypeID = this.EnvelopeTypeID;
    return envelope;
  }

  public int EnvelopeTypeID
  {
    get => this._typeID;
    set => this._typeID = value;
  }

  public float Width
  {
    get => this._width;
    set => this._width = value;
  }

  public float Height
  {
    get => this._height;
    set => this._height = value;
  }

  public PrintDocument Document
  {
    get => this._document;
    set => this._document = value;
  }

  public Envelope.addressField DeliveryAddress
  {
    get => this._deliveryAddress;
    set => this._deliveryAddress = value;
  }

  public Envelope.addressField ReturnAddress
  {
    get => this._returnAddress;
    set => this._returnAddress = value;
  }

  public Envelope(Guid deliveryAddress, Guid returnAddress)
    : this()
  {
    this.DeliveryAddress.Address = string.Empty;
    this.ReturnAddress.Address = string.Empty;
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetEntityMailingAddress(@Add)", new object[2]
    {
      (object) "@Add",
      (object) deliveryAddress
    }));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      this.DeliveryAddress.Address = objectValue1.ToString();
    object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetEntityMailingAddress(@Add)", new object[2]
    {
      (object) "@Add",
      (object) returnAddress
    }));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      return;
    this.ReturnAddress.Address = objectValue2.ToString();
  }

  public Envelope()
  {
    this._feedMethod = new Envelope.EnvelopeFeedMethod();
    this._face = new Envelope.EnvelopeFace();
    this._document = new PrintDocument();
    this._deliveryAddress = new Envelope.addressField();
    this._returnAddress = new Envelope.addressField();
    dsEnvelopes.tblEnvelopeTypesDataTable envelopeTypesDataTable = new dsEnvelopes.tblEnvelopeTypesDataTable();
    DefaultDatabase.LoadDataTable((DataTable) envelopeTypesDataTable, CommandType.Text, "SELECT EnvelopeTypeID, Description, Height, Width, DeliveryAddressFromLeft, DeliveryAddressFromTop, DeliveryAddressFromLeftMAX, DeliveryAddressFromTopMAX, DeliveryAddressFromLeftMIN, DeliveryAddressFromTopMIN, ReturnAddressFromLeft, ReturnAddressFromTop, ReturnAddressFromLeftMAX, ReturnAddressFromTopMAX, ReturnAddressFromLeftMIN, ReturnAddressFromTopMIN, DefaultEnvelope FROM dbo.tblEnvelopeTypes WHERE DefaultEnvelope = 1");
    if (envelopeTypesDataTable.Count == 1)
    {
      dsEnvelopes.tblEnvelopeTypesRow envelopeTypesRow = envelopeTypesDataTable[0];
      this._typeID = envelopeTypesRow.EnvelopeTypeID;
      this.Height = Convert.ToSingle(envelopeTypesRow.Height);
      this.Width = Convert.ToSingle(envelopeTypesRow.Width);
      this.DeliveryAddress.fromLeft = Convert.ToSingle(envelopeTypesRow.DeliveryAddressFromLeft);
      this.DeliveryAddress.fromTop = Convert.ToSingle(envelopeTypesRow.DeliveryAddressFromTop);
      this.ReturnAddress.fromLeft = Convert.ToSingle(envelopeTypesRow.ReturnAddressFromLeft);
      this.ReturnAddress.fromTop = Convert.ToSingle(envelopeTypesRow.ReturnAddressFromTop);
    }
    this.ReturnAddress.Font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Regular, GraphicsUnit.Point);
    this._face = Envelope.EnvelopeFace.up;
    this._feedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_1;
  }

  public Envelope.EnvelopeFeedMethod FeedMethod
  {
    get => this._feedMethod;
    set => this._feedMethod = value;
  }

  public Envelope.EnvelopeFace Face
  {
    get => this._face;
    set => this._face = value;
  }

  private void Dispose(bool disposing)
  {
    if (!this.disposedValue && disposing)
    {
      if (this._deliveryAddress != null)
        this._deliveryAddress.Dispose();
      if (this._returnAddress != null)
        this._returnAddress.Dispose();
    }
    this.disposedValue = true;
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  public class addressField : IDisposable
  {
    private Font _Font;
    private float _fromLeft;
    private float _fromTop;
    private string _address;
    private bool disposedValue;

    public addressField()
    {
      this._Font = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Regular, GraphicsUnit.Point);
      this._address = string.Empty;
    }

    public Font Font
    {
      get => this._Font;
      set => this._Font = value;
    }

    public float fromLeft
    {
      get => this._fromLeft;
      set => this._fromLeft = value;
    }

    public float fromTop
    {
      get => this._fromTop;
      set => this._fromTop = value;
    }

    public string Address
    {
      get => this._address;
      set => this._address = value;
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!this.disposedValue && disposing && this._Font != null)
        this._Font.Dispose();
      this.disposedValue = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }
  }

  public enum EnvelopeFeedMethod
  {
    envelope_feed_1,
    envelope_feed_2,
    envelope_feed_3,
    envelope_feed_4,
    envelope_feed_5,
    envelope_feed_6,
  }

  public enum EnvelopeFace
  {
    up,
    down,
  }
}
