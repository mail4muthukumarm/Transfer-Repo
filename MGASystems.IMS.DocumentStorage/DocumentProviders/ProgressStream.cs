// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.ProgressStream
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using System;
using System.IO;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

public class ProgressStream : Stream
{
  private readonly Stream _stream;
  private readonly CancellationToken _token;

  public event EventHandler<int> ProgressChanged;

  public ProgressStream(Stream stream, CancellationToken token = default (CancellationToken))
  {
    this._stream = stream;
    this._token = token;
  }

  public override bool CanRead => this._stream.CanRead;

  public override bool CanSeek => this._stream.CanSeek && !this._token.IsCancellationRequested;

  public override bool CanWrite => this._stream.CanWrite;

  public override long Length => this._stream.Length;

  public override long Position
  {
    get => this._stream.Position;
    set => this._stream.Position = value;
  }

  public override void Flush() => this._stream.Flush();

  public override int Read(byte[] buffer, int offset, int count)
  {
    if (this._token.IsCancellationRequested)
      throw new ArgumentException();
    int num = this._stream.Read(buffer, offset, count);
    EventHandler<int> progressChanged = this.ProgressChanged;
    if (progressChanged == null)
      return num;
    progressChanged((object) this, (int) this._stream.Position);
    return num;
  }

  public override long Seek(long offset, SeekOrigin origin) => this._stream.Seek(offset, origin);

  public override void SetLength(long value) => this._stream.SetLength(value);

  public override void Write(byte[] buffer, int offset, int count)
  {
    if (this._token.IsCancellationRequested)
      throw new ArgumentException();
    this._stream.Write(buffer, offset, count);
    EventHandler<int> progressChanged = this.ProgressChanged;
    if (progressChanged == null)
      return;
    progressChanged((object) this, (int) this._stream.Position);
  }
}
