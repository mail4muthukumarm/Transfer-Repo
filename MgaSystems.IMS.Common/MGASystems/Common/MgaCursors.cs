// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MgaCursors
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public class MgaCursors : IDisposable
{
  private static Dictionary<string, Cursor> _cursorCache = new Dictionary<string, Cursor>();
  private bool disposedValue;

  public MgaCursors() => this.disposedValue = false;

  public static Cursor WaitCursor
  {
    get
    {
      return CurrentUser.UsingVista || SystemInformation.TerminalServerSession ? Cursors.WaitCursor : MgaCursors.LoadCursor("aero_busy");
    }
  }

  public static Cursor Working
  {
    get
    {
      return CurrentUser.UsingVista || SystemInformation.TerminalServerSession ? Cursors.AppStarting : MgaCursors.LoadCursor("aero_working");
    }
  }

  public static Cursor Default
  {
    get
    {
      return CurrentUser.UsingVista || SystemInformation.TerminalServerSession ? Cursors.Default : MgaCursors.LoadCursor("aero_arrow");
    }
  }

  public static Cursor Hand
  {
    get
    {
      return CurrentUser.UsingVista || SystemInformation.TerminalServerSession ? Cursors.Hand : MgaCursors.LoadCursor("aero_link");
    }
  }

  [DllImport("user32.dll")]
  private static extern IntPtr LoadCursorFromFile(string lpFileName);

  private static Cursor LoadCursor(string embeddedResourceName)
  {
    if (!MgaCursors._cursorCache.ContainsKey(embeddedResourceName))
    {
      if (!File.Exists(MGATempFolder.MGATempPath + embeddedResourceName))
        File.WriteAllBytes(MGATempFolder.MGATempPath + embeddedResourceName, (byte[]) MGASystems.Common.My.Resources.Resources.ResourceManager.GetObject(embeddedResourceName));
      Cursor cursor = new Cursor(MgaCursors.LoadCursorFromFile(MGATempFolder.MGATempPath + embeddedResourceName));
      MgaCursors._cursorCache.Add(embeddedResourceName, cursor);
    }
    return MgaCursors._cursorCache[embeddedResourceName];
  }

  protected virtual void Dispose(bool disposing)
  {
    if (!this.disposedValue)
    {
      if (disposing)
      {
        try
        {
          foreach (KeyValuePair<string, Cursor> keyValuePair in MgaCursors._cursorCache)
            keyValuePair.Value.Dispose();
        }
        finally
        {
          Dictionary<string, Cursor>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
    this.disposedValue = true;
  }

  public void Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }
}
