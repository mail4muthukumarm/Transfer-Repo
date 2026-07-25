// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.SprocData
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

internal class SprocData
{
  private string _sprocName;
  private Dictionary<int, string> _parameters;
  private bool? _policyStatus;
  private bool _alwaysRunSproc;
  private bool _checkReturn;
  private string _customReturnErrorMessage;
  private bool _checkValue;
  private string _checkValueEquals;

  public SprocData()
  {
  }

  public SprocData(string sprocName, Dictionary<int, string> parameters)
  {
    this._sprocName = sprocName;
    this._parameters = parameters;
  }

  public SprocData(
    string sprocName,
    Dictionary<int, string> parameters,
    bool? policyStatus,
    bool alwaysRunSproc,
    bool checkReturn,
    bool checkValue,
    string checkValueEquals,
    string customReturnErrorMessage)
  {
    this._sprocName = sprocName;
    this._parameters = parameters;
    this._policyStatus = policyStatus;
    this._alwaysRunSproc = alwaysRunSproc;
    this._checkReturn = checkReturn;
    this._checkValue = checkValue;
    this._checkValueEquals = checkValueEquals;
    this._customReturnErrorMessage = customReturnErrorMessage;
  }

  public bool? PolicyStatus { get; set; }

  public bool CheckReturn { get; set; }

  public bool AlwaysRunSproc { get; set; }

  public string CustomReturnErrorMessage { get; set; }

  public string SprocName { get; set; }

  public Dictionary<int, string> Parameters { get; set; }

  public bool CheckValue { get; set; }

  public string CheckValueEquals { get; set; }
}
