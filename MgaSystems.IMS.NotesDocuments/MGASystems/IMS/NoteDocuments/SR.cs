// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.SR
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

internal class SR
{
  private static ResourceManager _rm;
  private const string RESNAME = "MGASystems.IMS.NoteDocuments";

  private SR()
  {
  }

  private static ResourceManager ResMan
  {
    get
    {
      if (SR._rm == null)
        SR._rm = new ResourceManager("MGASystems.IMS.NoteDocuments", Assembly.GetExecutingAssembly());
      return SR._rm;
    }
  }

  public static string GetString(string id)
  {
    return SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture);
  }

  public static string GetString(string id, object arg0)
  {
    return string.Format((IFormatProvider) Thread.CurrentThread.CurrentCulture, SR.ResMan.GetString(id, Thread.CurrentThread.CurrentCulture), RuntimeHelpers.GetObjectValue(arg0));
  }
}
