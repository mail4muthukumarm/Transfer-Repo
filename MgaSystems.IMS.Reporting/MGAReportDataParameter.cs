// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.MGAReportDataParameter
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class MGAReportDataParameter
{
  public string SQLParameterName;
  public object SQLParameterValue;
  public int SQLParameterSize;
  public byte SQLParameterPrecision;
  public byte SQLParameterScale;
  public bool IsMandatory;
  private SqlDbType _sQLParameterType;

  public MGAReportDataParameter()
  {
    this.SQLParameterSize = -1;
    this.SQLParameterPrecision = (byte) 0;
    this.SQLParameterScale = (byte) 0;
    this.IsMandatory = false;
  }

  public MGAReportDataParameter(string sQLParameterName)
  {
    this.SQLParameterSize = -1;
    this.SQLParameterPrecision = (byte) 0;
    this.SQLParameterScale = (byte) 0;
    this.IsMandatory = false;
    this.SQLParameterName = sQLParameterName;
  }

  public MGAReportDataParameter(string sQLParameterName, object sQLParameterValue)
  {
    this.SQLParameterSize = -1;
    this.SQLParameterPrecision = (byte) 0;
    this.SQLParameterScale = (byte) 0;
    this.IsMandatory = false;
    this.SQLParameterName = sQLParameterName;
    this.SQLParameterValue = RuntimeHelpers.GetObjectValue(sQLParameterValue);
    this._sQLParameterType = SqlDbType.BigInt;
  }

  public SqlDbType SQLParameterType
  {
    get
    {
      if (Information.IsNothing((object) this._sQLParameterType) || this._sQLParameterType == SqlDbType.BigInt)
        this._sQLParameterType = this.ParameterType();
      return this._sQLParameterType;
    }
    set => this._sQLParameterType = value;
  }

  public bool IsWorthy
  {
    get
    {
      bool isWorthy;
      if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.SQLParameterValue)))
        isWorthy = false;
      else if (this.IsMandatory)
      {
        isWorthy = true;
      }
      else
      {
        Type type = this.SQLParameterValue.GetType();
        isWorthy = type == typeof (short) || type == typeof (int) || type == typeof (long) || type == typeof (byte) || type == typeof (Decimal) || type == typeof (double) || type == typeof (sbyte) || type == typeof (float) || type == typeof (ushort) || type == typeof (uint) || type == typeof (ulong) ? !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.SQLParameterValue)) && Convert.ToInt64(RuntimeHelpers.GetObjectValue(this.SQLParameterValue)) != 0L : (!(type == typeof (bool)) ? (!(type == typeof (byte[])) ? (!(type == typeof (char[])) ? (!(type == typeof (DateTime)) ? (!(type == typeof (Guid)) ? type == typeof (string) && !((string) this.SQLParameterValue).Equals(string.Empty) : !((Guid) this.SQLParameterValue).Equals(Guid.Empty)) : !((DateTime) this.SQLParameterValue).Equals(DateTime.MinValue)) : ((char[]) this.SQLParameterValue).Length > 0) : ((byte[]) this.SQLParameterValue).Length > 0) : !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.SQLParameterValue)));
      }
      return isWorthy;
    }
  }

  private SqlDbType ParameterType()
  {
    SqlDbType sqlDbType;
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(this.SQLParameterValue)))
    {
      sqlDbType = SqlDbType.BigInt;
    }
    else
    {
      Type type = this.SQLParameterValue.GetType();
      sqlDbType = !(type == typeof (long)) ? (!(type == typeof (bool)) ? (!(type == typeof (byte)) ? (!(type == typeof (byte[])) ? (!(type == typeof (char[])) ? (!(type == typeof (DateTime)) ? (!(type == typeof (Decimal)) ? (!(type == typeof (double)) ? (!(type == typeof (Guid)) ? (!(type == typeof (short)) ? (!(type == typeof (int)) ? (!(type == typeof (long)) ? (!(type == typeof (float)) ? (!(type == typeof (string)) ? SqlDbType.BigInt : SqlDbType.VarChar) : SqlDbType.Real) : SqlDbType.BigInt) : SqlDbType.Int) : SqlDbType.SmallInt) : SqlDbType.UniqueIdentifier) : SqlDbType.Float) : SqlDbType.Decimal) : SqlDbType.DateTime) : SqlDbType.VarChar) : SqlDbType.VarBinary) : SqlDbType.TinyInt) : SqlDbType.Bit) : SqlDbType.BigInt;
    }
    return sqlDbType;
  }
}
