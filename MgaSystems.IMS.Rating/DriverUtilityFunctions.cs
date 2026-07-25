// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.DriverUtilityFunctions
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Mga.Wpf.Ims.ExtensionMethods;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[StandardModule]
public sealed class DriverUtilityFunctions
{
  public static bool UsesVolta() => MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DefaultToLXForDriverMVRs");

  public static bool IsVolta(string stateID)
  {
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ID FROM tblDriverProductStates WITH (NOLOCK) WHERE StateID = @ST", new object[2]
    {
      (object) "@ST",
      (object) stateID
    }))));
  }

  public static bool StateValidatesLicense(string stateID)
  {
    bool flag;
    if (!ADRConnectWrapper.ImplementsLicenseLookup)
      flag = false;
    else
      flag = !Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ID FROM tblDriverLicenseValidationStates WITH (NOLOCK) WHERE StateID = @ST", new object[2]
      {
        (object) "@ST",
        (object) stateID
      }))));
    return flag;
  }

  public static bool UsesPdfFileExtension()
  {
    return MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ADR.UsesPdfFileExtension");
  }

  public static void UploadDriverFile(string fn, Guid quoteGuid)
  {
    Quote docSupport = new Quote(quoteGuid);
    int? setting = MGASystems.Common.Settings.SystemSettings.GetSetting<int?>("ADRDocumentFolderID");
    if (!setting.HasValue)
      DocumentManager.BeginFileAddWithBind(fn, (ISupportDocumentSystem) docSupport, string.Empty);
    else
      DocumentManager.BeginFileAddWithBind(fn, setting.Value, (ISupportDocumentSystem) docSupport, string.Empty);
  }

  public static void DeleteFile(string fileName)
  {
    if (!File.Exists(fileName))
      return;
    File.Delete(fileName);
  }

  public static object GetDriverClassCode(string str, string clsType)
  {
    object driverClassCode = (object) DBNull.Value;
    if (!string.IsNullOrEmpty(str))
    {
      string str1 = string.Empty;
      if (str.Contains($"<{clsType}>") && str.Contains($"</{clsType}>"))
        str1 = FormDriversInfo.GetTagsValue(FormDriversInfo.GetTagsValue(str, $"<{clsType}>", $"</{clsType}>"), "<ClassCode>", "</ClassCode>");
      else if (StringExtensions.ContainsCaseInsensitive(FormDriversInfo.GetTagsValue(str, "<Type>", "</Type>"), clsType))
        str1 = FormDriversInfo.GetTagsValue(str, "<ClassCode>", "</ClassCode>");
      if (str1.Length > 0)
        driverClassCode = (object) str1;
    }
    return driverClassCode;
  }

  public static DataTable GetVehicleTypes(object vin, Guid quoteGuid, int driverID)
  {
    return DefaultDatabase.ExecuteDataTable("spGetVehicleType", new object[6]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@Vin",
      vin,
      (object) "@DriverID",
      (object) driverID
    });
  }

  public static DataTable GetVehicleWeightClass(object vin, Guid quoteGuid, int driverID)
  {
    return DefaultDatabase.ExecuteDataTable("spGetVehicleWeightClass", new object[6]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@Vin",
      vin,
      (object) "@DriverID",
      (object) driverID
    });
  }

  public static int GetDriverAge(Guid quoteGuid, int driverID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DOB FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) driverID
    }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (int) Math.Floor((DateTime.Today - new DateTime(Conversions.ToDate(objectValue).Year, Conversions.ToDate(objectValue).Month, Conversions.ToDate(objectValue).Day)).TotalDays / 365.2425) : 0;
  }

  public static object GetLicenseOriginalIssueDate(string xml)
  {
    string tagsValue = FormDriversInfo.GetTagsValue(xml, "<ExactOriginalIssueDate>", "</ExactOriginalIssueDate>");
    object originalIssueDate;
    if (string.IsNullOrEmpty(tagsValue))
    {
      originalIssueDate = (object) DBNull.Value;
    }
    else
    {
      int integer1 = Conversions.ToInteger(FormDriversInfo.GetTagsValue(tagsValue, "<Year>", "</Year>"));
      int integer2 = Conversions.ToInteger(FormDriversInfo.GetTagsValue(tagsValue, "<Month>", "</Month>"));
      int integer3 = Conversions.ToInteger(FormDriversInfo.GetTagsValue(tagsValue, "<Day>", "</Day>"));
      int month = integer2;
      int day = integer3;
      originalIssueDate = (object) new DateTime(integer1, month, day);
    }
    return originalIssueDate;
  }

  public static bool HasPersonalLicense(string xml)
  {
    string tagsValue = FormDriversInfo.GetTagsValue(xml, "<CurrentLicense>", "</CurrentLicense>");
    bool flag;
    if (!string.IsNullOrEmpty(tagsValue))
    {
      if (tagsValue.Contains("<Personal>") && tagsValue.Contains("</Personal>"))
      {
        flag = true;
        goto label_6;
      }
      if (FormDriversInfo.GetTagsValue(tagsValue, "<Type>", "</Type>").EqualsNoCase("Personal"))
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  public static bool DriverHasViolations(int driverID)
  {
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 ID FROM tblDriverInfoViolations WITH (NOLOCK) WHERE DriverID = @DriverID AND SubType = @SubType", new object[4]
    {
      (object) "@DriverID",
      (object) driverID,
      (object) "@SubType",
      (object) "VIOL"
    }))));
  }

  public static int DriverNumberAccidents(int driverID)
  {
    return DriverUtilityFunctions.DriverNumberAccidents(driverID, string.Empty);
  }

  public static int DriverNumberAccidents(int driverID, string type)
  {
    int num;
    if (string.IsNullOrEmpty(type))
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(DISTINCT ID) FROM tblDriverInfoViolations WITH (NOLOCK) WHERE DriverID = @DriverID AND SubType = @SubType", new object[4]
      {
        (object) "@DriverID",
        (object) driverID,
        (object) "@SubType",
        (object) "ACCD"
      });
    else
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(DISTINCT D.ID) FROM tblDriverInfoViolations D WITH (NOLOCK) INNER JOIN lstDriver_ACD_Codes L WITH (NOLOCK) ON L.Code = D. ViolationCode WHERE D.DriverID = @DriverID AND D.SubType = @SubType AND L.CodeType = @CodeType", new object[6]
      {
        (object) "@DriverID",
        (object) driverID,
        (object) "@SubType",
        (object) "ACCD",
        (object) "@CodeType",
        (object) type
      });
    return num;
  }

  public static int DriverNumberViolations(int driverID)
  {
    return DriverUtilityFunctions.DriverNumberViolations(driverID, string.Empty);
  }

  public static int DriverNumberViolations(int driverID, string type)
  {
    int num;
    if (string.IsNullOrEmpty(type))
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(DISTINCT ID) FROM tblDriverInfoViolations WITH (NOLOCK) WHERE DriverID = @DriverID AND SubType = @SubType", new object[4]
      {
        (object) "@DriverID",
        (object) driverID,
        (object) "@SubType",
        (object) "VIOL"
      });
    else
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(DISTINCT D.ID) FROM tblDriverInfoViolations D WITH (NOLOCK) INNER JOIN lstDriver_ACD_Codes L WITH (NOLOCK) ON L.Code = D. ViolationCode WHERE D.DriverID = @DriverID AND D.SubType = @SubType AND L.CodeType = @CodeType", new object[6]
      {
        (object) "@DriverID",
        (object) driverID,
        (object) "@SubType",
        (object) "VIOL",
        (object) "@CodeType",
        (object) type
      });
    return num;
  }

  public static void SaveViolations(int driverID)
  {
    DriverUtilityFunctions.SaveViolations(driverID, string.Empty);
  }

  public static void SaveViolations(int driverID, string xml)
  {
    DriverUtilityFunctions.SaveViolations(driverID, xml, false);
  }

  public static void SaveViolations(int driverID, string xml, bool removeCurrentViolations)
  {
    // ISSUE: variable of a compiler-generated type
    DriverUtilityFunctions._Closure\u0024__19\u002D0 closure190_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    DriverUtilityFunctions._Closure\u0024__19\u002D0 closure190_2 = new DriverUtilityFunctions._Closure\u0024__19\u002D0(closure190_1);
    // ISSUE: reference to a compiler-generated field
    closure190_2.\u0024VB\u0024Local_driverID = driverID;
    // ISSUE: reference to a compiler-generated field
    closure190_2.\u0024VB\u0024Local_xml = xml;
    // ISSUE: reference to a compiler-generated field
    closure190_2.\u0024VB\u0024Local_removeCurrentViolations = removeCurrentViolations;
    // ISSUE: reference to a compiler-generated field
    if (string.IsNullOrEmpty(closure190_2.\u0024VB\u0024Local_xml))
    {
      // ISSUE: reference to a compiler-generated field
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @DriverID", new object[2]
      {
        (object) "@DriverID",
        (object) closure190_2.\u0024VB\u0024Local_driverID
      }));
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        return;
      // ISSUE: reference to a compiler-generated field
      closure190_2.\u0024VB\u0024Local_xml = objectValue.ToString();
    }
    // ISSUE: reference to a compiler-generated method
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure190_2._Lambda\u0024__0));
  }

  public static string RemoveInvalidCharacters(string str)
  {
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    int index = 0;
    while (index < invalidFileNameChars.Length)
    {
      char ch = invalidFileNameChars[index];
      str = str.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    return str;
  }

  public static bool IsSexualOffender(int driverID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) driverID
    }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && !string.IsNullOrEmpty(objectValue.ToString()) && DriverUtilityFunctions.IsSexualOffender(objectValue.ToString());
  }

  public static bool IsSexualOffender(string orderXml)
  {
    XDocument xdocument = XDocument.Parse(orderXml);
    bool flag;
    if (!orderXml.Contains("<MessageList>") || !orderXml.Contains("<MessageItem>") || !orderXml.Contains("<Line>"))
    {
      flag = false;
    }
    else
    {
      IEnumerable<XElement> xelements = xdocument.Descendants((XName) "MessageList").Descendants<XElement>((XName) "MessageItem").Descendants<XElement>((XName) "Line");
      try
      {
        foreach (XElement xelement in xelements)
        {
          object obj = (object) xelement.Value;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)) && obj.ToString().EqualsNoCase("Sexual Offender"))
          {
            flag = true;
            goto label_11;
          }
        }
      }
      finally
      {
        IEnumerator<XElement> enumerator;
        enumerator?.Dispose();
      }
      flag = false;
    }
label_11:
    return flag;
  }

  public static int DriverNumberAdjudicationWithheld(int driverID)
  {
    return DriverUtilityFunctions.DriverNumberAdjudicationWithheld(driverID, string.Empty);
  }

  public static int DriverNumberAdjudicationWithheld(int driverID, string type)
  {
    int num;
    if (string.IsNullOrEmpty(type))
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(ID) FROM tblDriverInfoViolations WITH (NOLOCK) WHERE DriverID = @DriverID AND SubType = @SubType", new object[4]
      {
        (object) "@DriverID",
        (object) driverID,
        (object) "@SubType",
        (object) "ADJW"
      });
    else
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(D.ID) FROM tblDriverInfoViolations D WITH (NOLOCK) INNER JOIN lstDriver_ACD_Codes L WITH (NOLOCK) ON L.Code = D. ViolationCode WHERE D.DriverID = @DriverID AND D.SubType = @SubType AND L.CodeType = @CodeType", new object[6]
      {
        (object) "@DriverID",
        (object) driverID,
        (object) "@SubType",
        (object) "ADJW",
        (object) "@CodeType",
        (object) type
      });
    return num;
  }

  public static bool IsCareerOffender(int driverID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) driverID
    }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && !string.IsNullOrEmpty(objectValue.ToString()) && DriverUtilityFunctions.IsCareerOffender(objectValue.ToString());
  }

  public static bool IsCareerOffender(string orderXml)
  {
    XDocument xdocument = XDocument.Parse(orderXml);
    bool flag;
    if (!orderXml.Contains("<MessageList>") || !orderXml.Contains("<MessageItem>") || !orderXml.Contains("<Line>"))
    {
      flag = false;
    }
    else
    {
      IEnumerable<XElement> xelements = xdocument.Descendants((XName) "MessageList").Descendants<XElement>((XName) "MessageItem").Descendants<XElement>((XName) "Line");
      try
      {
        foreach (XElement xelement in xelements)
        {
          object obj = (object) xelement.Value;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)) && obj.ToString().EqualsNoCase("Career Offender"))
          {
            flag = true;
            goto label_11;
          }
        }
      }
      finally
      {
        IEnumerator<XElement> enumerator;
        enumerator?.Dispose();
      }
      flag = false;
    }
label_11:
    return flag;
  }

  public static void SaveRestrictions(int driverID)
  {
    DriverUtilityFunctions.SaveRestrictions(driverID, string.Empty);
  }

  public static void SaveRestrictions(int driverID, string xml)
  {
    DriverUtilityFunctions.SaveRestrictions(driverID, xml, false);
  }

  public static void SaveRestrictions(int driverID, string xml, bool removeCurrentRestrictions)
  {
    // ISSUE: variable of a compiler-generated type
    DriverUtilityFunctions._Closure\u0024__29\u002D0 closure290_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    DriverUtilityFunctions._Closure\u0024__29\u002D0 closure290_2 = new DriverUtilityFunctions._Closure\u0024__29\u002D0(closure290_1);
    // ISSUE: reference to a compiler-generated field
    closure290_2.\u0024VB\u0024Local_driverID = driverID;
    // ISSUE: reference to a compiler-generated field
    closure290_2.\u0024VB\u0024Local_xml = xml;
    // ISSUE: reference to a compiler-generated field
    closure290_2.\u0024VB\u0024Local_removeCurrentRestrictions = removeCurrentRestrictions;
    // ISSUE: reference to a compiler-generated field
    if (string.IsNullOrEmpty(closure290_2.\u0024VB\u0024Local_xml))
    {
      // ISSUE: reference to a compiler-generated field
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @DriverID", new object[2]
      {
        (object) "@DriverID",
        (object) closure290_2.\u0024VB\u0024Local_driverID
      }));
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        return;
      // ISSUE: reference to a compiler-generated field
      closure290_2.\u0024VB\u0024Local_xml = objectValue.ToString();
    }
    // ISSUE: reference to a compiler-generated method
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure290_2._Lambda\u0024__0));
  }

  public static List<string> RestrictionsList(int driverID, string xml)
  {
    List<string> stringList1 = new List<string>();
    List<string> stringList2;
    if (string.IsNullOrEmpty(xml))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @DriverID", new object[2]
      {
        (object) "@DriverID",
        (object) driverID
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        xml = objectValue.ToString();
      }
      else
      {
        stringList2 = stringList1;
        goto label_34;
      }
    }
    XDocument xdocument = XDocument.Parse(xml);
    string str;
    object obj;
    try
    {
      foreach (XElement element in xdocument.Descendants().Elements<XElement>((XName) "CurrentLicense").Elements<XElement>((XName) "RestrictionList"))
      {
        str = element.Value;
        obj = (object) DBNull.Value;
        try
        {
          foreach (XNode node in element.Nodes())
          {
            string xmlString = node.ToString();
            if (xmlString.Contains("RestrictionItem"))
            {
              object objectValue = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString, "<Name>", "</Name>"));
              if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && !stringList1.Contains(objectValue.ToString()))
                stringList1.Add(objectValue.ToString());
            }
          }
        }
        finally
        {
          IEnumerator<XNode> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<XElement> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (XElement element in xdocument.Descendants().Elements<XElement>((XName) "MedicalCertificateList").Elements<XElement>((XName) "MedicalCertificateItem").Elements<XElement>((XName) "RestrictionList"))
      {
        str = element.Value;
        obj = (object) DBNull.Value;
        try
        {
          foreach (XNode node in element.Nodes())
          {
            string xmlString = node.ToString();
            if (xmlString.Contains("RestrictionItem"))
            {
              object objectValue = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString, "<Description>", "</Description>"));
              if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && !stringList1.Contains(objectValue.ToString()))
                stringList1.Add(objectValue.ToString());
            }
          }
        }
        finally
        {
          IEnumerator<XNode> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<XElement> enumerator;
      enumerator?.Dispose();
    }
    stringList2 = stringList1;
label_34:
    return stringList2;
  }

  public static int NumberAssignedPoints(int driverID, string xmlString)
  {
    if (string.IsNullOrEmpty(xmlString))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
      {
        (object) "@ID",
        (object) driverID
      }));
      xmlString = !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? objectValue.ToString() : throw new InvalidOperationException($"See DriverUtilityFunctions.NumberAssignedPoints. No XML present for driver with ID {driverID}");
    }
    XDocument xdocument = XDocument.Parse(xmlString);
    int num = 0;
    try
    {
      foreach (XElement element in xdocument.Descendants().Elements<XElement>((XName) "EventList").Elements<XElement>((XName) "EventItem"))
      {
        try
        {
          foreach (XNode node in element.Nodes())
          {
            string xmlString1 = node.ToString();
            if (xmlString1.Contains("DescriptionList"))
            {
              object objectValue = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString1, "<StateAssignedPoints>", "</StateAssignedPoints>"));
              int result;
              if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && int.TryParse(objectValue.ToString(), out result))
                num += result;
            }
          }
        }
        finally
        {
          IEnumerator<XNode> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<XElement> enumerator;
      enumerator?.Dispose();
    }
    return num;
  }

  public static int NumberAssignedPointsLookup(
    int driverID,
    string xmlString,
    bool useClientPoints)
  {
    if (string.IsNullOrEmpty(xmlString))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverXML FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
      {
        (object) "@ID",
        (object) driverID
      }));
      xmlString = !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? objectValue.ToString() : throw new InvalidOperationException($"See DriverUtilityFunctions.NumberClientAssignedPointsLookup. No XML present for driver with ID {driverID}");
    }
    XDocument xdocument = XDocument.Parse(xmlString);
    int num = 0;
    string str = $"SELECT TOP 1 {(useClientPoints ? (object) "ClientPoints" : (object) "SambaPoints")} FROM lstDriverPoints WITH (NOLOCK) WHERE ActivityCode = @AC ORDER BY ID DESC";
    try
    {
      foreach (XElement element in xdocument.Descendants().Elements<XElement>((XName) "EventList").Elements<XElement>((XName) "EventItem"))
      {
        try
        {
          foreach (XNode node in element.Nodes())
          {
            string xmlString1 = node.ToString();
            if (xmlString1.Contains("DescriptionList"))
            {
              object objectValue1 = RuntimeHelpers.GetObjectValue(XMLFunctions.GetTagsValueObject(xmlString1, "<Avd1>", "</Avd1>"));
              if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
              {
                object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str, new object[2]
                {
                  (object) "@AC",
                  objectValue1
                }));
                int result;
                if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)) && int.TryParse(objectValue2.ToString(), out result))
                  num += result;
              }
            }
          }
        }
        finally
        {
          IEnumerator<XNode> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<XElement> enumerator;
      enumerator?.Dispose();
    }
    return num;
  }

  public static bool SambaIssuingOfficeAccess(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteFunction<bool>("dbo.HasSambaSafetyIssuingOfficeAccess", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
  }

  public static string SampleHtmlString()
  {
    return "<html><head><title>DRIVER'S LICENSE REPORT</title></head><body bgcolor=\"white\" leftmargin=\"10\" topmargin=\"2\"><hr width=\"764px\" align=\"left\" style=\"BACKGROUND-COLOR: #1C75BC; HEIGHT: 4px\"/><table width=\"740px\"><tr><td height=\"17px\"><font size=\"3\" face=\"Times New Roman\"><strong>SambaSafety</strong></font></td><td height=\"17px\"><font size=\"3\" face=\"Times New Roman\">PO Box 1970</font></td><td height=\"17px\"><font size=\"3\" face=\"Times New Roman\">Rancho Cordova, CA 95741-1970</font></td></tr></table><table width=\"700px\"><tr><td height=\"17px\"><font size=\"2\" face=\"Times New Roman\"><strong>NEW YORK&nbsp;Driver Record&nbsp; - V4640</strong></font></td><td height=\"17px\"><font size=\"2\" face=\"Times New Roman\"><strong>Order Date: 02/18/2022 </strong></font></td><td height=\"17px\"><font size=\"2\" face=\"Times New Roman\"><strong>Seq #: 0</strong></font></td></tr></table><hr width=\"740px\" align=\"left\" style=\"BACKGROUND-COLOR: gray; HEIGHT: 2px\"/><table width=\"740px\"><tr><td width=\"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Host Used:</font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Online</font></td><td width=\"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Bill Code:</font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">148744</font></td></tr><tr><td width=\"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Rec Type:</font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">STANDARD</font></td><td width= \"14% \" height=\"17px \"><font size=\"2\" face=\"Times New Roman\">Reference:</font></td><td width= \"27%\" height=\"17px\"><font size= \"2\" face=\"Times New Roman\">WATERPLUS</font></td></tr><tr><td width=\"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">License:</font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">363012152</font></td></tr><tr><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Name:</font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">RICHARDS, ESLON M</font></td></tr><tr><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Address:</font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">535 E 42ND ST</font></td></tr><tr><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width = \"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">City, St:</font></td><td width = \"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">BROOKLYN, NY 11203</font></td></tr><tr><td width=\"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width = \"27%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td></tr></table><hr width=\"740px\" align=\"left\" style=\"BACKGROUND-COLOR gray; HEIGHT: 2px\"/><table width=\"740px\"><tr><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Sex:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">MALE  </font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Weight:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">DOB:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">07/11/1971</font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Age:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">50 </font></td></tr><tr><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Eyes:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">BROWN</font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Height:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">6 01</font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Iss Date:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td></tr><tr><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Hair:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Exp Date:</font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">07/11/2022</font></td><td width=\"7%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"14%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td></tr></table><hr width=\"740px\" align=\"left\" style=\"BACKGROUND-COLOR gray; HEIGHT: 2px\"/><table width=\"740px\"><tr><td width=\"60%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"40%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">STATUS:&nbsp;VALID</font></td></tr></table><hr width = \"740px\" align=\"left\" style=\"BACKGROUND-COLOR: gray; HEIGHT: 2px\"/><table cellspacing=\" 0\" cellpadding=\" 0\"><tr><td><font size=\" 3\" face=\" Times New Roman\" color=\" darkblue\"><strong>Violations/Convictions&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Failures To Appear&nbsp;&nbsp;&nbsp;&nbsp;   Accidents</strong></font></td></tr></table><table width=\"740px\"><tr><td height = \"12px\"><font size=\"2\" face=\"Times New Roman\">*** NONE To REPORT ***</font></td></tr></table><hr width=\"740px\" align=\"left\" style=\"BACKGROUND-COLOR: gray; HEIGHT: 2px\"/><table cellspacing = \"0\" cellpadding=\"0\"><tr><td><font size=\"3\" face=\"Times New Roman\" color=\"darkblue\" ><strong>Suspensions/Revocations</strong></font></td></tr></table><table width=\"740px\"><tr><td height=\"12px\"><font size=\"2\" face=\"Times New Roman\">*** NO ACTIVITY ***</font></td></tr></table><hr width=\"740px\" align=\"left\" style=\"BACKGROUND-COLOR: gray; HEIGHT: 2px\"/><table cellspacing=\"0\" cellpadding=\"0\"><tr><td><font size=\"3\" face=\"Times New Roman\" color=\"darkblue\" ><strong>License and Permit Information</strong></font></td></tr></table><table width=\"740px\"><tr><td width=\"22%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">License: PERSONAL</font></td><td width = \"16%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Issue: </font></td><td width=\"16%\" height=\" 17px\"><font size=\" 2\" face=\" Times New Roman\">Expire: 07/11/2022</font></td><td width=\"16%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Status: VALID</font></td><td width=\"16%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"14%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td></tr><tr><td width=\"22%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width = \"16%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">Class: D</font></td><td width= \"16%\" height=\" 17px\" colspan=\" 3\"><font size=\" 2\" face=\" Times New Roman\">GVWR <26, 1 LBS. TOWING VEHICLES(S) > 10,000 LBS. WHEN TOTAL <26,001 LBS.</font></td></tr></table><hr width=\"740px\" align=\"left\" style=\"BACKGROUND-COLOR: gray; HEIGHT: 2px\"/><table cellspacing = \"0\" cellpadding=\"0\"><tr><td><font size = \"3\" face=\"Times New Roman\" color=\"darkblue\" ><strong>Miscellaneous State Data</strong></font></td></tr></table><table width=\"740 px\" class=\"brdTable\"> <tr><td width=\"5%\" height=\"12px\" colspan=\"2\"><font size=\"2\" face=\"Times New Roman\">MI #: R09099 94706 064637-71</font></td></tr></table><table width = \"740 px\" Class=\"brdTable\"><tr><td width=\"5%\" height=\"12px\" colspan=\"2\"><font size=\"2\" face=\"Times New Roman\">CLASS CHANGE: 08/24/2001       NEW: *D*        OLD: *ID*</font></td></tr></table><table width=\"740 px\" class=\"brdTable\"><tr><td width=\"5%\" height=\"12px\" colspan=\"2\"><font size=\"2\" face=\"Times New Roman\">ACCIDENT PREVENTION COURSE COMPLETED ON: 08/21/2021</font></td></tr></table><table width=\"740 px\" Class=\"brdTable\"><tr><td width=\"5%\" height=\"12px\" colspan=\"2\"><font size=\"2\" face=\"Times New Roman\">POINT REDUCTION ELIGIBLE For VIOLATIONS OCCURRING FROM  02/21/2020 - 08/21/2021</font></td></tr></table><table width=\"740 px\" class=\"brdTable\"><tr><td width=\"5%\" height=\"12px\" colspan=\"2\"><font size=\"2\" face=\"Times New Roman\">N/A - NON 19-A DRIVER OR COURSE PRIOR TO 01/01/94</font></td></tr></table><table width=\"740 px\" Class=\"brdTable\"><tr><td width=\"5%\" height=\"12px\" colspan=\"2\"><font size=\"2\" face=\"Times New Roman\">EXPIRATION DATES In THIS DOCUMENT MAY HAVE BEEN EXTENDED PURSUANT To EXECUTIVE</font></td></tr><tr><td width=\"5%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"95%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">Or LEGISLATIVE ACTION Of THE ISSUING JURISDICTION RELATED To COVID-19.</font></td></tr><tr><td width=\"5%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td width=\"95%\" height=\"12px\"><font size=\"2\" face=\"Times New Roman\">PLEASE CONSULT With THE JURISDICTION For FURTHER DETAILS.</font></td></tr></table><table width=\"740px\" Class=\"brdTable\"><tr><td height = \"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td height= \"17px\"><font size=\" 2\" face=\" Times New Roman\"></font></td></tr><tr><td height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td><td height=\"17px\"><font size=\"2\" face=\"Times New Roman\"></font></td></tr><tr><td height = \"17px\"><font size=\"2\" face=\"Times New Roman\">CONFIDENTIAL INFORMATION - To BE USED As PER STATE And FEDERAL LAWS.</font></td></tr><tr><td height=\"17px\"><Font size=\"2\" face=\"Times New Roman\">MISUSE MAY RESULT In A CRIMINAL PROSECUTION</font></td></tr></table><hr width=\"764px\" align=\"left\" style=\"BACKGROUND-COLOR: #1C75BC; HEIGHT: 4px\"/>table width=\"740px\" Class=\"brdTable\"><tr><td width=\"50%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">End Of REPORT For RICHARDS, ESLON M</font></td><td width=\"50%\" height=\"17px\"><font size=\"2\" face=\"Times New Roman\">(CONTROL NUMBER: BUEXNP)</font></td></tr>    </table>    </body>    </html>";
  }
}
