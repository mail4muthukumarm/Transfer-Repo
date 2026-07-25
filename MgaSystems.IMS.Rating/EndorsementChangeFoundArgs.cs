// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.EndorsementChangeFoundArgs
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public sealed class EndorsementChangeFoundArgs
{
  private RaterBase.ModificationCode _modificationCode;
  private DataRow _currentRow;
  private DataRow _previousRow;

  public EndorsementChangeFoundArgs(
    string modificationCode,
    DataRow currentRow,
    DataRow previousRow)
  {
    string Left = modificationCode;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "M", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "D", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "N", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "U", false) != 0)
            return;
          this.Initialize(RaterBase.ModificationCode.Unchanged, currentRow, previousRow);
        }
        else
          this.Initialize(RaterBase.ModificationCode.New, currentRow, previousRow);
      }
      else
        this.Initialize(RaterBase.ModificationCode.Deleted, currentRow, previousRow);
    }
    else
      this.Initialize(RaterBase.ModificationCode.Modified, currentRow, previousRow);
  }

  public EndorsementChangeFoundArgs(
    RaterBase.ModificationCode modificationCode,
    DataRow currentRow,
    DataRow previousRow)
  {
    this.Initialize(modificationCode, currentRow, previousRow);
  }

  private void Initialize(
    RaterBase.ModificationCode modificationCode,
    DataRow currentRow,
    DataRow previousRow)
  {
    this._modificationCode = modificationCode;
    this._currentRow = currentRow;
    this._previousRow = previousRow;
  }

  public RaterBase.ModificationCode ModificationCode => this._modificationCode;

  public DataRow CurrentRow => this._currentRow;

  public DataRow PreviousRow => this._previousRow;
}
