// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RegionalReportingRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using MGASystems.IMS.Policies.Inspections.RegionalReporting;
using Microsoft.VisualBasic.CompilerServices;
using System.Data;
using System.IO;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[StandardModule]
public sealed class RegionalReportingRequest
{
  public static bool TransmitRegionalRequest(RRIRequest ds, string userName, string password)
  {
    RRIRequest ds1 = ds;
    string userName1 = userName;
    string password1 = password;
    string empty = string.Empty;
    ref string local = ref empty;
    return RegionalReportingRequest.TransmitRegionalRequest(ds1, userName1, password1, ref local);
  }

  public static bool TransmitRegionalRequest(
    RRIRequest ds,
    string userName,
    string password,
    ref string resultCode)
  {
    ds.Reports.Columns["Location_Id"].ColumnMapping = MappingType.Hidden;
    ds.SIC_Codes.Columns["Location_Id"].ColumnMapping = MappingType.Hidden;
    ds.Location.Columns["Location_Id"].ColumnMapping = MappingType.Hidden;
    using (Requests requests = new Requests())
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        ds.WriteXml((Stream) memoryStream);
        memoryStream.Position = 0L;
        string end;
        using (StreamReader streamReader = new StreamReader((Stream) memoryStream))
          end = streamReader.ReadToEnd();
        resultCode = requests.SubmitRequest(userName, password, end);
        return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(resultCode, "0", false) != 0 && Versioned.IsNumeric((object) resultCode);
      }
    }
  }
}
