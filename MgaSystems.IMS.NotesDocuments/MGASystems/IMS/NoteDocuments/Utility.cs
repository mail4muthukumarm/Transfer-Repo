// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.Utility
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors")]
public class Utility
{
  private static IReportManager _reporting;
  private static IBroadcastMessageSender _messaging;
  private static IErrorHandler _errorHandling;

  public static void Initialize(
    IReportManager reporting,
    IBroadcastMessageSender messaging,
    IErrorHandler errorHandling)
  {
    Utility._reporting = reporting;
    Utility._messaging = messaging;
    Utility._errorHandling = errorHandling;
  }

  public static IReportManager Reporting => Utility._reporting;

  public static IBroadcastMessageSender Messaging => Utility._messaging;

  public static IErrorHandler ErrorHandling => Utility._errorHandling;
}
