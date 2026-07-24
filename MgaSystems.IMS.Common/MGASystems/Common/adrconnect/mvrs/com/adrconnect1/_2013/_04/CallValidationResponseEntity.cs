// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04.CallValidationResponseEntity
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
[DataContract(Name = "CallValidationResponseEntity", Namespace = "http://adrconnect.mvrs.com/adrconnect/2013/04/")]
public class CallValidationResponseEntity : IExtensibleDataObject
{
  private ExtensionDataObject extensionDataField;
  private int DaysLeftField;
  private string ErrorDescriptionField;
  private int ErrorIdField;
  private string MessageField;

  public ExtensionDataObject ExtensionData
  {
    get => this.extensionDataField;
    set => this.extensionDataField = value;
  }

  [DataMember]
  public int DaysLeft
  {
    get => this.DaysLeftField;
    set => this.DaysLeftField = value;
  }

  [DataMember]
  public string ErrorDescription
  {
    get => this.ErrorDescriptionField;
    set => this.ErrorDescriptionField = value;
  }

  [DataMember]
  public int ErrorId
  {
    get => this.ErrorIdField;
    set => this.ErrorIdField = value;
  }

  [DataMember]
  public string Message
  {
    get => this.MessageField;
    set => this.MessageField = value;
  }
}
