// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.ReceiveRecordsResponseEntity
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04;

[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "ReceiveRecordsResponseEntity", Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/")]
public class ReceiveRecordsResponseEntity : IExtensibleDataObject
{
  private ExtensionDataObject extensionDataField;
  private CallValidationResponseEntity CallValidationField;
  private RecordEntity[] ReportsField;

  public ExtensionDataObject ExtensionData
  {
    get => this.extensionDataField;
    set => this.extensionDataField = value;
  }

  [DataMember]
  public CallValidationResponseEntity CallValidation
  {
    get => this.CallValidationField;
    set => this.CallValidationField = value;
  }

  [DataMember]
  public RecordEntity[] Reports
  {
    get => this.ReportsField;
    set => this.ReportsField = value;
  }
}
