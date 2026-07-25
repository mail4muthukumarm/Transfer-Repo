// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.DocumentAutomation.DocumentPreview.ManagedIStream
// Assembly: MgaSystems.IMS.DocumentAutomation.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 40237120-7607-4A2A-83F2-11594214BFC1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.DocumentAutomation.Cs.dll

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

#nullable disable
namespace MgaSystems.IMS.DocumentAutomation.DocumentPreview;

internal class ManagedIStream : IStream
{
  private readonly Stream stream;

  internal ManagedIStream(Stream ioStream)
  {
    this.stream = ioStream != null ? ioStream : throw new ArgumentNullException(nameof (ioStream));
  }

  void IStream.Clone(out IStream streamCopy) => throw new NotSupportedException();

  void IStream.Commit(int flags) => throw new NotSupportedException();

  void IStream.CopyTo(
    IStream targetStream,
    long bufferSize,
    IntPtr buffer,
    IntPtr bytesWrittenPtr)
  {
    throw new NotSupportedException();
  }

  void IStream.LockRegion(long offset, long byteCount, int lockType)
  {
    throw new NotSupportedException();
  }

  void IStream.Revert() => throw new NotSupportedException();

  void IStream.SetSize(long libNewSize) => throw new NotSupportedException();

  void IStream.UnlockRegion(long offset, long byteCount, int lockType)
  {
    throw new NotSupportedException();
  }

  void IStream.Write(byte[] buffer, int bufferSize, IntPtr bytesWrittenPtr)
  {
    throw new NotSupportedException();
  }

  [SecurityCritical]
  void IStream.Read(byte[] buffer, int bufferSize, IntPtr bytesReadPtr)
  {
    int val = this.stream.Read(buffer, 0, bufferSize);
    if (!(bytesReadPtr != IntPtr.Zero))
      return;
    Marshal.WriteInt64(bytesReadPtr, (long) val);
  }

  [SecurityCritical]
  void IStream.Seek(long offset, int origin, IntPtr newPositionPtr)
  {
    long val = this.stream.Seek(offset, (SeekOrigin) origin);
    if (!(newPositionPtr != IntPtr.Zero))
      return;
    Marshal.WriteInt64(newPositionPtr, val);
  }

  void IStream.Stat(out System.Runtime.InteropServices.ComTypes.STATSTG streamStats, int grfStatFlag)
  {
    streamStats = new System.Runtime.InteropServices.ComTypes.STATSTG()
    {
      type = 2,
      cbSize = this.stream.Length,
      grfMode = 0
    };
    if (this.stream.CanRead && this.stream.CanWrite)
      streamStats.grfMode |= 2;
    else if (this.stream.CanRead)
    {
      streamStats.grfMode |= 0;
    }
    else
    {
      if (!this.stream.CanWrite)
        throw new IOException("Stream Object Disposed");
      streamStats.grfMode |= 1;
    }
  }
}
