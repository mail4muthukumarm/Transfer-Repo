// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.DocumentAutomation.DocumentPreview.PreviewHandlerHost
// Assembly: MgaSystems.IMS.DocumentAutomation.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 40237120-7607-4A2A-83F2-11594214BFC1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.DocumentAutomation.Cs.dll

using MGASystems.Common.ErrorHandling;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.DocumentAutomation.DocumentPreview;

public class PreviewHandlerHost : Control
{
  private IPreviewHandler currentPreviewHandler;
  private Stream currentPreviewHandlerStream;
  private string errorMessage;

  [DllImport("Shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern uint AssocQueryString(
    uint flags,
    int str,
    string pszAssoc,
    string pszExtra,
    [Out] StringBuilder pszOut,
    ref uint pcchOut);

  private string ErrorMessage
  {
    get => this.errorMessage;
    set
    {
      this.errorMessage = value;
      this.Invalidate();
    }
  }

  [Browsable(false)]
  [ReadOnly(true)]
  public Guid CurrentPreviewHandlerGuid { get; private set; } = Guid.Empty;

  public PreviewHandlerHost()
  {
    this.BackColor = Color.White;
    this.Size = new Size(320, 240 /*0xF0*/);
    this.ErrorMessage = "No file loaded.";
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    this.SetStyle(ControlStyles.UserPaint, true);
  }

  protected override void Dispose(bool disposing)
  {
    this.UnloadPreviewHandler();
    if (this.currentPreviewHandler != null)
    {
      Marshal.FinalReleaseComObject((object) this.currentPreviewHandler);
      this.currentPreviewHandler = (IPreviewHandler) null;
      GC.Collect();
    }
    base.Dispose(disposing);
  }

  private Guid GetPreviewHandlerGUID(string filename)
  {
    uint pcchOut = 60;
    StringBuilder pszOut = new StringBuilder((int) pcchOut);
    return PreviewHandlerHost.AssocQueryString(4U, 16 /*0x10*/, Path.GetExtension(filename), $"{{{typeof (IPreviewHandler).GUID}}}", pszOut, ref pcchOut) != 0U ? Guid.Empty : new Guid(pszOut.ToString());
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);
    if (this.ErrorMessage != string.Empty)
      TextRenderer.DrawText((IDeviceContext) e.Graphics, this.ErrorMessage, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.EndEllipsis | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    Rectangle clientRectangle = this.ClientRectangle;
    clientRectangle.Inflate(-1, -1);
    e.Graphics.DrawRectangle(SystemPens.ControlDark, clientRectangle);
  }

  protected override void OnResize(EventArgs e)
  {
    base.OnResize(e);
    if (this.currentPreviewHandler != null)
    {
      Rectangle clientRectangle = this.ClientRectangle;
      this.currentPreviewHandler.SetRect(ref clientRectangle);
    }
    else
      this.Invalidate();
  }

  public bool Open(string filename)
  {
    this.UnloadPreviewHandler();
    if (string.IsNullOrEmpty(filename))
    {
      this.ErrorMessage = "No file loaded.";
      return false;
    }
    Guid previewHandlerGuid = this.GetPreviewHandlerGUID(filename);
    this.ErrorMessage = "";
    if (previewHandlerGuid != Guid.Empty)
    {
      try
      {
        if (previewHandlerGuid != this.CurrentPreviewHandlerGuid)
        {
          this.CurrentPreviewHandlerGuid = previewHandlerGuid;
          if (this.currentPreviewHandler != null)
            Marshal.FinalReleaseComObject((object) this.currentPreviewHandler);
          this.currentPreviewHandler = Activator.CreateInstance(Type.GetTypeFromCLSID(this.CurrentPreviewHandlerGuid)) as IPreviewHandler;
        }
        if (this.currentPreviewHandler is IInitializeWithFile currentPreviewHandler1)
          currentPreviewHandler1.Initialize(filename, 0U);
        if (this.currentPreviewHandler is IInitializeWithStream currentPreviewHandler2)
        {
          this.currentPreviewHandlerStream = (Stream) File.Open(filename, FileMode.Open);
          ManagedIStream pstream = new ManagedIStream(this.currentPreviewHandlerStream);
          currentPreviewHandler2.Initialize((IStream) pstream, 0U);
        }
        if (this.currentPreviewHandler != null)
        {
          Rectangle clientRectangle = this.ClientRectangle;
          this.currentPreviewHandler.SetWindow(this.Handle, ref clientRectangle);
          this.currentPreviewHandler.DoPreview();
          return true;
        }
      }
      catch (Exception ex)
      {
        this.ErrorMessage = "Preview could not be generated.\n" + ex.Message;
      }
    }
    else
      this.ErrorMessage = "No preview available.";
    return false;
  }

  public void UnloadPreviewHandler()
  {
    try
    {
      this.currentPreviewHandler?.Unload();
      this.currentPreviewHandlerStream?.Close();
      this.currentPreviewHandlerStream?.Dispose();
      this.currentPreviewHandlerStream = (Stream) null;
    }
    catch (COMException ex)
    {
      ErrorHandler.SilentHandleError((Exception) ex);
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleError(ex);
    }
  }
}
