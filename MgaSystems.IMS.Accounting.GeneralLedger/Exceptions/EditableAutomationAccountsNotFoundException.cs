// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Exceptions.EditableAutomationAccountsNotFoundException
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.Exceptions;

[Serializable]
public class EditableAutomationAccountsNotFoundException : Exception
{
  public EditableAutomationAccountsNotFoundException()
  {
  }

  public EditableAutomationAccountsNotFoundException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  public EditableAutomationAccountsNotFoundException(string message)
    : base(message)
  {
  }

  protected EditableAutomationAccountsNotFoundException(
    SerializationInfo info,
    StreamingContext context)
    : base(info, context)
  {
  }
}
