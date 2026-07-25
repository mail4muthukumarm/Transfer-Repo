// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Import_Inspection.ImportMessage
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using MGASystems.Data.Binding;

#nullable disable
namespace MGASystems.IMS.Underwriting.Import_Inspection;

public abstract class ImportMessage : BindingObject
{
  [NotificationProperty]
  public virtual string Message { get; set; }

  [NotificationProperty]
  public virtual bool IsError { get; set; }

  [NotificationProperty]
  public virtual bool HasInvalidData { get; set; }

  public static ImportMessage Create(string msg, bool isError, bool hasInvalidData)
  {
    return NotifyProxyTypeManager.Allocate<ImportMessage>(new object[3]
    {
      (object) msg,
      (object) isError,
      (object) hasInvalidData
    });
  }

  public ImportMessage(string msg, bool isError, bool hasInvalidData)
  {
    this.Message = msg;
    this.IsError = isError;
    this.HasInvalidData = hasInvalidData;
  }
}
