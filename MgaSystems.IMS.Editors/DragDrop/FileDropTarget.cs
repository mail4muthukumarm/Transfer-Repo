// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.DragDrop.FileDropTarget
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using MGASystems.ExtendedEditors.ComTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.ExtendedEditors.DragDrop;

internal class FileDropTarget : IOleDropTarget
{
  private IOleDropTarget owner;
  private DragDropEffects cachedEffect;
  private bool registeredDragDrop;
  private const int CF_HDROP = 15;

  public FileDropTarget(IOleDropTarget owner)
  {
    this.owner = owner;
    this.cachedEffect = DragDropEffects.None;
  }

  internal void SetAcceptsDrops(IntPtr dropControlHandle, bool accept)
  {
    try
    {
      if (Application.OleRequired() != ApartmentState.STA)
        throw new ThreadStateException("Thread Must Be STA");
      if (accept)
      {
        if (this.registeredDragDrop)
          throw new InvalidOperationException("Cannot double calls to RegisterForDragDrop, please call UnRegisterForDragDrop first");
        int error = UnsafeNativeMethods.RegisterDragDrop(dropControlHandle, (IOleDropTarget) this);
        switch (error)
        {
          case -2147221247:
          case 0:
            this.registeredDragDrop = true;
            break;
          default:
            throw new Win32Exception(error);
        }
      }
      else
      {
        if (!this.registeredDragDrop)
          throw new InvalidOperationException("Cannot double calls to UnregisterForDragDrop, please call RegisterForDragDrop first");
        int error = UnsafeNativeMethods.RevokeDragDrop(dropControlHandle);
        switch (error)
        {
          case -2147221247:
          case 0:
            this.registeredDragDrop = false;
            break;
          default:
            throw new Win32Exception(error);
        }
      }
    }
    catch (Exception ex)
    {
      throw new InvalidOperationException("DragDrop Registration Failed", ex);
    }
  }

  private static void ConvertToByteArray(string fileName, out byte[] bytes)
  {
    using (FileStream fileStream = File.OpenRead(fileName))
    {
      long length = fileStream.Length;
      bytes = new byte[length];
      fileStream.Read(bytes, 0, (int) length);
    }
  }

  private void ConvertToByteArray(MGASystems.ExtendedEditors.ComTypes.IStream stream, out byte[] bytes)
  {
    MGASystems.ExtendedEditors.ComTypes.STATSTG pStatstg = new MGASystems.ExtendedEditors.ComTypes.STATSTG();
    stream.Stat(pStatstg, 0);
    IntPtr num = Marshal.AllocHGlobal((int) pStatstg.cbSize);
    UnsafeNativeMethods.GlobalLock(new HandleRef((object) this, num));
    stream.Read(num, (int) pStatstg.cbSize);
    bytes = new byte[pStatstg.cbSize];
    Marshal.Copy(num, bytes, 0, (int) pStatstg.cbSize);
    UnsafeNativeMethods.GlobalUnlock(new HandleRef((object) this, num));
    Marshal.FreeHGlobal(num);
  }

  private void ConvertToByteArray(IStorage storage, out byte[] bytes)
  {
    uint grfMode = 4114;
    ILockBytes ilockBytesOnHglobal = UnsafeNativeMethods.CreateILockBytesOnHGlobal(IntPtr.Zero, true);
    IStorage docfileOnIlockBytes = UnsafeNativeMethods.StgCreateDocfileOnILockBytes(ilockBytesOnHglobal, grfMode, 0U);
    storage.CopyTo(0, (Guid[]) null, IntPtr.Zero, docfileOnIlockBytes);
    ilockBytesOnHglobal.Flush();
    docfileOnIlockBytes.Commit(0);
    MGASystems.ExtendedEditors.ComTypes.STATSTG pstatstg = new MGASystems.ExtendedEditors.ComTypes.STATSTG();
    ilockBytesOnHglobal.Stat(pstatstg, 1);
    HandleRef hGlobal = new HandleRef((object) this, UnsafeNativeMethods.GetHGlobalFromILockBytes(ilockBytesOnHglobal));
    IntPtr source = UnsafeNativeMethods.GlobalLock(hGlobal);
    bytes = new byte[pstatstg.cbSize];
    Marshal.Copy(source, bytes, 0, (int) pstatstg.cbSize);
    UnsafeNativeMethods.GlobalUnlock(hGlobal);
    Marshal.ReleaseComObject((object) docfileOnIlockBytes);
    Marshal.ReleaseComObject((object) ilockBytesOnHglobal);
  }

  private static bool QueryGetFileDescriptorArray(IOleDataObject dataObject)
  {
    MGASystems.ExtendedEditors.ComTypes.FORMATETC pFormatetc = new MGASystems.ExtendedEditors.ComTypes.FORMATETC();
    pFormatetc.cfFormat = (ushort) ShellClipboardFormats.CFSTR_FILEDESCRIPTORA.Id;
    pFormatetc.dwAspect = 1;
    pFormatetc.lindex = -1;
    pFormatetc.ptd = new IntPtr(0);
    pFormatetc.tymed = 1;
    if (MGASystems.ExtendedEditors.ComTypes.HResults.Succeeded(dataObject.OleQueryGetData(pFormatetc)))
      return true;
    pFormatetc.cfFormat = (ushort) ShellClipboardFormats.CFSTR_FILEDESCRIPTORW.Id;
    pFormatetc.dwAspect = 1;
    pFormatetc.lindex = -1;
    pFormatetc.ptd = new IntPtr(0);
    pFormatetc.tymed = 1;
    return MGASystems.ExtendedEditors.ComTypes.HResults.Succeeded(dataObject.OleQueryGetData(pFormatetc));
  }

  private int CopyFileContents(
    IOleDataObject dataObject,
    FILEDESCRIPTOR[] files,
    List<ByteData> byteDataList)
  {
    int hr = -2147467259 /*0x80004005*/;
    MGASystems.ExtendedEditors.ComTypes.STGMEDIUM pmedium = new MGASystems.ExtendedEditors.ComTypes.STGMEDIUM();
    if (files.Length != 0)
    {
      for (int index = 0; index < files.Length; ++index)
      {
        string cFileName = files[index].cFileName;
        if (((int) files[index].dwFileAttributes & 16 /*0x10*/) != 16 /*0x10*/)
        {
          ByteData byteData = (ByteData) null;
          hr = this.SaveToFile(dataObject, ShellClipboardFormats.CFSTR_FILECONTENTS, index, cFileName, out byteData);
          if (!MGASystems.ExtendedEditors.ComTypes.HResults.Failed(hr))
          {
            if (byteData != null)
              byteDataList.Add(byteData);
          }
          else
            break;
        }
      }
      UnsafeNativeMethods.ReleaseStgMedium(pmedium);
    }
    return hr;
  }

  private static FILEDESCRIPTOR[] GetFileDescriptorArray(IOleDataObject dataObject)
  {
    MGASystems.ExtendedEditors.ComTypes.FORMATETC pFormatetc = new MGASystems.ExtendedEditors.ComTypes.FORMATETC();
    MGASystems.ExtendedEditors.ComTypes.STGMEDIUM stgmedium = new MGASystems.ExtendedEditors.ComTypes.STGMEDIUM();
    pFormatetc.cfFormat = (ushort) ShellClipboardFormats.CFSTR_FILEDESCRIPTORW.Id;
    pFormatetc.dwAspect = 1;
    pFormatetc.lindex = -1;
    pFormatetc.ptd = new IntPtr(0);
    pFormatetc.tymed = 1;
    Type t;
    if (MGASystems.ExtendedEditors.ComTypes.HResults.Succeeded(dataObject.OleGetData(pFormatetc, stgmedium)))
    {
      t = typeof (FILEDESCRIPTORW);
    }
    else
    {
      if (!MGASystems.ExtendedEditors.ComTypes.HResults.Succeeded(dataObject.OleGetData(new MGASystems.ExtendedEditors.ComTypes.FORMATETC()
      {
        cfFormat = (ushort) ShellClipboardFormats.CFSTR_FILEDESCRIPTORA.Id,
        dwAspect = 1,
        lindex = -1,
        ptd = new IntPtr(0),
        tymed = 1
      }, stgmedium)))
        return new FILEDESCRIPTOR[0];
      t = typeof (FILEDESCRIPTORA);
    }
    HandleRef hGlobal = new HandleRef((object) null, stgmedium.unionmember);
    IntPtr ptr1 = UnsafeNativeMethods.GlobalLock(hGlobal);
    FILEDESCRIPTOR[] fileDescriptorArray;
    try
    {
      int length = Marshal.ReadInt32(ptr1);
      fileDescriptorArray = new FILEDESCRIPTOR[length];
      IntPtr ptr2 = ptr1 + Marshal.SizeOf(typeof (uint));
      for (int index = 0; index < length; ++index)
      {
        FILEDESCRIPTORA structure1 = (FILEDESCRIPTORA) Marshal.PtrToStructure(ptr2, typeof (FILEDESCRIPTORA));
        FILEDESCRIPTORW structure2 = (FILEDESCRIPTORW) Marshal.PtrToStructure(ptr2, typeof (FILEDESCRIPTORW));
        fileDescriptorArray[index] = new FILEDESCRIPTOR();
        if (t == typeof (FILEDESCRIPTORW))
        {
          fileDescriptorArray[index].dwFlags = structure2.dwFlags;
          fileDescriptorArray[index].clsid = structure2.clsid;
          fileDescriptorArray[index].sizel = structure2.sizel;
          fileDescriptorArray[index].pointl = structure2.pointl;
          fileDescriptorArray[index].dwFileAttributes = structure2.dwFileAttributes;
          fileDescriptorArray[index].ftCreationTime = structure2.ftCreationTime;
          fileDescriptorArray[index].ftLastAccessTime = structure2.ftLastAccessTime;
          fileDescriptorArray[index].ftLastWriteTime = structure2.ftLastWriteTime;
          fileDescriptorArray[index].nFileSizeHigh = structure2.nFileSizeHigh;
          fileDescriptorArray[index].nFileSizeLow = structure2.nFileSizeLow;
          fileDescriptorArray[index].cFileName = structure2.cFileName;
        }
        else
        {
          fileDescriptorArray[index].dwFlags = structure1.dwFlags;
          fileDescriptorArray[index].clsid = structure1.clsid;
          fileDescriptorArray[index].sizel = structure1.sizel;
          fileDescriptorArray[index].pointl = structure1.pointl;
          fileDescriptorArray[index].dwFileAttributes = structure1.dwFileAttributes;
          fileDescriptorArray[index].ftCreationTime = structure1.ftCreationTime;
          fileDescriptorArray[index].ftLastAccessTime = structure1.ftLastAccessTime;
          fileDescriptorArray[index].ftLastWriteTime = structure1.ftLastWriteTime;
          fileDescriptorArray[index].nFileSizeHigh = structure1.nFileSizeHigh;
          fileDescriptorArray[index].nFileSizeLow = structure1.nFileSizeLow;
          fileDescriptorArray[index].cFileName = structure1.cFileName;
        }
        ptr2 += Marshal.SizeOf(t);
      }
    }
    catch
    {
      fileDescriptorArray = new FILEDESCRIPTOR[0];
    }
    UnsafeNativeMethods.GlobalUnlock(hGlobal);
    UnsafeNativeMethods.ReleaseStgMedium(stgmedium);
    return fileDescriptorArray;
  }

  private string[] GetFilenames(IOleDataObject dataObject)
  {
    string[] filenames = (string[]) null;
    MGASystems.ExtendedEditors.ComTypes.STGMEDIUM pMedium = new MGASystems.ExtendedEditors.ComTypes.STGMEDIUM();
    if (MGASystems.ExtendedEditors.ComTypes.HResults.Succeeded(dataObject.OleGetData(new MGASystems.ExtendedEditors.ComTypes.FORMATETC()
    {
      cfFormat = (ushort) 15,
      dwAspect = 1,
      lindex = -1,
      ptd = new IntPtr(0),
      tymed = 15
    }, pMedium)))
    {
      uint length = UnsafeNativeMethods.DragQueryFile(pMedium.unionmember, uint.MaxValue, (StringBuilder) null, 0);
      filenames = new string[(int) length];
      for (uint iFile = 0; iFile < length; ++iFile)
      {
        StringBuilder buffer = new StringBuilder(256 /*0x0100*/);
        int num = (int) UnsafeNativeMethods.DragQueryFile(pMedium.unionmember, iFile, buffer, buffer.Capacity + 1);
        filenames[(int) iFile] = buffer.ToString();
      }
    }
    return filenames;
  }

  private int SaveToFile(
    IOleDataObject pdata,
    System.Windows.Forms.DataFormats.Format cfFormat,
    int index,
    string filename,
    out ByteData byteData)
  {
    MGASystems.ExtendedEditors.ComTypes.FORMATETC pFormatetc = new MGASystems.ExtendedEditors.ComTypes.FORMATETC();
    MGASystems.ExtendedEditors.ComTypes.STGMEDIUM stgmedium = new MGASystems.ExtendedEditors.ComTypes.STGMEDIUM();
    byteData = (ByteData) null;
    pFormatetc.cfFormat = (ushort) cfFormat.Id;
    pFormatetc.dwAspect = 1;
    pFormatetc.lindex = index;
    pFormatetc.tymed = 13;
    try
    {
      pdata.OleGetData(pFormatetc, stgmedium);
      try
      {
        switch ((TYMED) stgmedium.tymed)
        {
          case TYMED.TYMED_ISTREAM:
            byte[] bytes1;
            this.ConvertToByteArray((MGASystems.ExtendedEditors.ComTypes.IStream) Marshal.GetTypedObjectForIUnknown(stgmedium.unionmember, typeof (MGASystems.ExtendedEditors.ComTypes.IStream)), out bytes1);
            byteData = new ByteData(filename, bytes1);
            break;
          case TYMED.TYMED_ISTORAGE:
            byte[] bytes2;
            this.ConvertToByteArray((IStorage) Marshal.GetTypedObjectForIUnknown(stgmedium.unionmember, typeof (IStorage)), out bytes2);
            byteData = new ByteData(filename, bytes2);
            break;
        }
      }
      catch
      {
        return -2147467259 /*0x80004005*/;
      }
      finally
      {
        UnsafeNativeMethods.ReleaseStgMedium(stgmedium);
      }
    }
    catch
    {
      return -2147467259 /*0x80004005*/;
    }
    return 0;
  }

  int IOleDropTarget.OleDragEnter(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
  {
    if (pDataObj is IOleDataObject dataObject)
    {
      this.cachedEffect = DragDropEffects.None;
      if (FileDropTarget.QueryGetFileDescriptorArray(dataObject))
      {
        FILEDESCRIPTOR[] fileDescriptorArray = FileDropTarget.GetFileDescriptorArray(dataObject);
        if (fileDescriptorArray != null)
        {
          List<ByteData> data = new List<ByteData>();
          foreach (FILEDESCRIPTOR filedescriptor in fileDescriptorArray)
            data.Add(new ByteData(filedescriptor.cFileName, (byte[]) null));
          if (data.Count > 0)
            pDataObj = (object) new DataObject("ByteData", (object) data);
        }
      }
      pdwEffect = (int) this.cachedEffect;
    }
    this.owner.OleDragEnter(pDataObj, grfKeyState, pt, ref pdwEffect);
    return 0;
  }

  int IOleDropTarget.OleDragOver(int grfKeyState, long pt, ref int pdwEffect)
  {
    pdwEffect = (int) this.cachedEffect;
    this.owner.OleDragOver(grfKeyState, pt, ref pdwEffect);
    return 0;
  }

  int IOleDropTarget.OleDragLeave()
  {
    this.cachedEffect = DragDropEffects.None;
    this.owner.OleDragLeave();
    return 0;
  }

  int IOleDropTarget.OleDrop(object pDataObj, int grfKeyState, long pt, ref int pdwEffect)
  {
    if (pDataObj is IOleDataObject dataObject)
    {
      this.cachedEffect = DragDropEffects.None;
      FILEDESCRIPTOR[] fileDescriptorArray = FileDropTarget.GetFileDescriptorArray(dataObject);
      if (fileDescriptorArray != null && fileDescriptorArray.Length != 0)
      {
        List<ByteData> byteDataList = new List<ByteData>();
        if (MGASystems.ExtendedEditors.ComTypes.HResults.Succeeded(this.CopyFileContents(dataObject, fileDescriptorArray, byteDataList)))
        {
          this.cachedEffect = DragDropEffects.Copy;
          if (byteDataList != null && byteDataList.Count > 0)
            pDataObj = (object) new DataObject("ByteData", (object) byteDataList);
        }
      }
      else
      {
        List<ByteData> data = new List<ByteData>();
        string[] filenames = this.GetFilenames(dataObject);
        if (filenames != null && filenames.Length != 0)
        {
          foreach (string str in filenames)
          {
            byte[] bytes = (byte[]) null;
            FileDropTarget.ConvertToByteArray(str, out bytes);
            string fileName = Path.GetFileName(str);
            data.Add(new ByteData(fileName, bytes));
          }
        }
        pDataObj = (object) new DataObject("ByteData", (object) data);
      }
      pdwEffect = (int) this.cachedEffect;
    }
    this.owner.OleDrop(pDataObj, grfKeyState, pt, ref pdwEffect);
    return 0;
  }
}
