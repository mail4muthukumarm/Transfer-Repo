// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.WriteOffPayableClickedEventArgs
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win.UltraWinGrid;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class WriteOffPayableClickedEventArgs
{
  private int mGlCompanyId;
  private int mControlNumber;
  private UltraGridRow mRow;

  internal WriteOffPayableClickedEventArgs(int glCompanyId, int controlNumber, UltraGridRow Row)
  {
    this.mGlCompanyId = glCompanyId;
    this.mControlNumber = controlNumber;
    this.mRow = Row;
  }

  public int GlCompanyId => this.mGlCompanyId;

  public int ControlNumber => this.mControlNumber;

  public UltraGridRow Row => this.mRow;
}
