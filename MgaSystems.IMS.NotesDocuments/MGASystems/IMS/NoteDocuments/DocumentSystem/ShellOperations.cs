// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.ShellOperations
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

public class ShellOperations
{
  [CLSCompliant(false)]
  public const uint SW_NORMAL = 1;

  [CLSCompliant(false)]
  [DllImport("shell32.dll", SetLastError = true)]
  public static extern bool ShellExecuteEx(ref ShellOperations.ShellExecuteInfo lpExecInfo);

  internal static void OpenWith(string file)
  {
    ShellOperations.ShellExecuteInfo lpExecInfo = new ShellOperations.ShellExecuteInfo();
    lpExecInfo.Size = Marshal.SizeOf<ShellOperations.ShellExecuteInfo>(lpExecInfo);
    lpExecInfo.Verb = "openas";
    lpExecInfo.File = file;
    lpExecInfo.Show = 1U;
    if (Environment.OSVersion.Version.Major >= 6)
      lpExecInfo.Mask = 12U;
    if (!ShellOperations.ShellExecuteEx(ref lpExecInfo))
      throw new Win32Exception(Marshal.GetLastWin32Error());
  }

  [CLSCompliant(false)]
  [Serializable]
  public struct ShellExecuteInfo
  {
    public int Size;
    public uint Mask;
    public IntPtr hwnd;
    public string Verb;
    public string File;
    public string Parameters;
    public string Directory;
    public uint Show;
    public IntPtr InstApp;
    public IntPtr IDList;
    public string Class;
    public IntPtr hkeyClass;
    public uint HotKey;
    public IntPtr Icon;
    public IntPtr Monitor;
  }
}
