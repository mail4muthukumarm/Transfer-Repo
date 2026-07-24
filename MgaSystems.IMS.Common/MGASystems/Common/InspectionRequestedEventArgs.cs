// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.InspectionRequestedEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;

#nullable disable
namespace MGASystems.Common;

public class InspectionRequestedEventArgs : EventArgs
{
  private int _inspectionCompanyID;
  private Guid _quoteGuid;

  public InspectionRequestedEventArgs(int inspectionCompanyID, Guid quoteGuid)
  {
    this._inspectionCompanyID = inspectionCompanyID;
    this._quoteGuid = quoteGuid;
  }

  public int InspectionCompanyID => this._inspectionCompanyID;

  public Guid QuoteGuid => this._quoteGuid;
}
