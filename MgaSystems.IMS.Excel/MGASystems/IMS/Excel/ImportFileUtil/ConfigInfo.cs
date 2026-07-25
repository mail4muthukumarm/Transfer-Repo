// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.ConfigInfo
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

internal class ConfigInfo
{
  private List<string> _supportFileTypes = new List<string>((IEnumerable<string>) new string[3]
  {
    ".xml",
    ".xls",
    ".xlsx"
  });
  private string _pathToFileDirectory = "Config/DefaultDirectory";
  private string _pathToErrorLog = "Config/DebugInfo/ErrorLogPath";
  private string _errorLogDirectory;
  private bool _allDebugInfo;
  private string _pathToDataSource = "Config/IMS/DataSource";
  private string _pathToCatalog = "Config/IMS/Catalog";
  private string _pathToUserName = "Config/IMS/UserName";
  private string _pathToPassword = "Config/IMS/Password";
  private string _pathToSprocs = "Config/Sprocs";
  private Dictionary<int, SprocData> _allSprocData = new Dictionary<int, SprocData>();
  private string _pathToAllDebugInfo = "Config/DebugInfo/AllDebugInfo";
  private string _pathToPolicy = "Config/ForXMLFile/PolicyPath";
  private string _pathToPolicyNumber = "Config/ForXMLFile/NodeNames/PolicyNumber";
  private string _pathToTransactionAmount = "Config/ForXMLFile/NodeNames/TransactionAmount";
  private string _pathToEffectiveDate = "Config/ForXMLFile/NodeNames/EffectiveDate";
  private string _pathToCompanyCompositeCommission = "Config/ForXMLFile/NodeNames/CompanyCompositeCommission";
  private string _pathToProducerCompositeCommission = "Config/ForXMLFile/NodeNames/ProducerCompositeCommission";
  private string _pathToAdditionalInterestAddress = "Config/ForXMLFile/NodeNames/AdditionalInsuredAddress";
  private string _pathToAdditionalInterestCity = "Config/ForXMLFile/NodeNames/AdditionalInsuredCity";
  private string _pathToAdditionalInterestState = "Config/ForXMLFile/NodeNames/AdditionalInsuredState";
  private string _pathToAdditionalInterestZip = "Config/ForXMLFile/NodeNames/AdditionalInsuredZip";
  private string _nodesPolicy;
  private string _nodenamePolicyNumber;
  private string _nodenameTransactionAmount;
  private string _nodenameEffectiveDate;
  private string _nodenameCompanyCompositeCommission;
  private string _nodenameProducerCompositeCommission;
  private string _nodenameAdditionalInterestName;
  private string _nodenameAdditionalInterestAddress;
  private string _nodenameAdditionalInterestCity;
  private string _nodenameAdditionalInterestState;
  private string _nodenameAdditionalInterestZip;
  private string _pathToColumnPolicyNumber = "Config/ForExcelFile/Columns/Column[Name = 'PolicyNumber']";
  private string _pathToColumnTransactionAmount = "Config/ForExcelFile/Columns/Column[Name = 'TransactionAmount']";
  private string _pathToColumnEffectiveDate = "Config/ForExcelFile/Columns/Column[Name = 'EffectiveDate']";
  private string _pathToColumnCompanyCompositeCommission = "Config/ForExcelFile/Columns/Column[Name = 'CompanyCompositeCommission']";
  private string _pathToColumnProducerCompositeCommission = "Config/ForExcelFile/Columns/Column[Name = 'ProducerCompositeCommission']";
  private string _pathToColumnAdditionalInterestName = "Config/ForExcelFile/Columns/Column[Name = 'AdditionalInterestName']";
  private string _pathToColumnAdditionalInterestAddress = "Config/ForExcelFile/Columns/Column[Name = 'AdditionalInterestAddress']";
  private string _pathToColumnAdditionalInterestCity = "Config/ForExcelFile/Columns/Column[Name = 'AdditionalInterestCity']";
  private string _pathToColumnAdditionalInterestState = "Config/ForExcelFile/Columns/Column[Name = 'AdditionalInterestState']";
  private string _pathToColumnAdditionalInterestZip = "Config/ForExcelFile/Columns/Column[Name = 'AdditionalInterestZip']";
  private string _pathToExcelHeaderColumn = "Config/ForExcelFile/Columns/HasHeaderColumn";
  private string _pathToStripPolicyNumber = "Config/ForExcelFile/Columns/StripPolicyNumber";
  private int _columnNumberPolicyNumber;
  private int _columnNumberTransactionAmount;
  private int _columnNumberEffectiveDate;
  private int _columnNumberCompanyCompositeCommission;
  private int _columnNumberProducerCompositeCommission;
  private int _columnNumberAdditionalInterestName;
  private int _columnNumberAdditionalInterestAddress;
  private int _columnNumberAdditionalInterestCity;
  private int _columnNumberAdditionalInterestState;
  private int _columnNumberAdditionalInterestZip;
  private bool _excelHeaderColumn;
  private bool _stripPolicyNumber;
  private string _pathToEncrypt = "Config/DebugInfo/Encrypt";

  public List<string> SupportedFileTypes => this._supportFileTypes;

  public string PathToFileDirectory => this._pathToFileDirectory;

  public string PathToErrorLog => this._pathToErrorLog;

  public string ErrorLogDirectory
  {
    set => this._errorLogDirectory = value;
    get => this._errorLogDirectory;
  }

  public bool AllDebugInfo
  {
    set => this._allDebugInfo = value;
    get => this._allDebugInfo;
  }

  public string PathToDataSource => this._pathToDataSource;

  public string PathToCatalog => this._pathToCatalog;

  public string PathToUserName => this._pathToUserName;

  public string PathToPassword => this._pathToPassword;

  public string PathToSprocs
  {
    set => this._pathToSprocs = value;
    get => this._pathToSprocs;
  }

  public Dictionary<int, SprocData> AllSprocData
  {
    set => this._allSprocData = value;
    get => this._allSprocData;
  }

  public string PathToAllDebugInfo => this._pathToAllDebugInfo;

  public string PathToPolicy => this._pathToPolicy;

  public string PathToPolicyNumber => this._pathToPolicyNumber;

  public string PathToTransactionAmount => this._pathToTransactionAmount;

  public string PathToEffectiveDate => this._pathToEffectiveDate;

  public string PathToCompanyCompositeCommission => this._pathToCompanyCompositeCommission;

  public string PathToProducerCompositeCommission => this._pathToProducerCompositeCommission;

  public string PathToAdditionalInterestAddress => this._pathToAdditionalInterestAddress;

  public string PathToAdditionalInterestCity => this._pathToAdditionalInterestCity;

  public string PathToAdditionalInterestState => this._pathToAdditionalInterestState;

  public string PathToAdditionalInterestZip => this._pathToAdditionalInterestZip;

  public string NodesPolicy
  {
    set => this._nodesPolicy = value;
    get => this._nodesPolicy;
  }

  public string NodeNamePolicyNumber
  {
    set => this._nodenamePolicyNumber = value;
    get => this._nodenamePolicyNumber;
  }

  public string NodeNameTransactionAmount
  {
    set => this._nodenameTransactionAmount = value;
    get => this._nodenameTransactionAmount;
  }

  public string NodeNameEffectiveDate
  {
    set => this._nodenameEffectiveDate = value;
    get => this._nodenameEffectiveDate;
  }

  public string NodeNameCompanyCompositeCommission
  {
    set => this._nodenameCompanyCompositeCommission = value;
    get => this._nodenameCompanyCompositeCommission;
  }

  public string NodeNameProducerCompositeCommission
  {
    set => this._nodenameProducerCompositeCommission = value;
    get => this._nodenameProducerCompositeCommission;
  }

  public string NodeNameAdditionalInsuredName
  {
    set => this._nodenameAdditionalInterestName = value;
    get => this._nodenameAdditionalInterestName;
  }

  public string NodeNameAdditionalInsuredAddress
  {
    set => this._nodenameAdditionalInterestAddress = value;
    get => this._nodenameAdditionalInterestAddress;
  }

  public string NodeNameAdditionalInsuredCity
  {
    set => this._nodenameAdditionalInterestCity = value;
    get => this._nodenameAdditionalInterestCity;
  }

  public string NodeNameAdditionalInsuredState
  {
    set => this._nodenameAdditionalInterestState = value;
    get => this._nodenameAdditionalInterestState;
  }

  public string NodeNameAdditionalInsuredZip
  {
    set => this._nodenameAdditionalInterestZip = value;
    get => this._nodenameAdditionalInterestZip;
  }

  public string PathToColumnPolicyNumber => this._pathToColumnPolicyNumber;

  public string PathToColumnTransactionAmount => this._pathToColumnTransactionAmount;

  public string PathToColumnEffectiveDate => this._pathToColumnEffectiveDate;

  public string PathToColumnCompanyCompositeCommission
  {
    get => this._pathToColumnCompanyCompositeCommission;
  }

  public string PathToColumnProducerCompositeCommission
  {
    get => this._pathToColumnProducerCompositeCommission;
  }

  public string PathToColumnAdditionalInterestName => this._pathToColumnAdditionalInterestName;

  public string PathToColumnAdditionalInterestAddress
  {
    get => this._pathToColumnAdditionalInterestAddress;
  }

  public string PathToColumnAdditionalInterestCity => this._pathToColumnAdditionalInterestCity;

  public string PathToColumnAdditionalInterestState => this._pathToColumnAdditionalInterestState;

  public string PathToColumnAdditionalInterestZip => this._pathToColumnAdditionalInterestZip;

  public string PathToHasHeaderColumn => this._pathToExcelHeaderColumn;

  public string PathToStripPolicyNumber => this._pathToStripPolicyNumber;

  public int ColumnNumberPolicyNumber
  {
    set => this._columnNumberPolicyNumber = value;
    get => this._columnNumberPolicyNumber;
  }

  public int ColumnNumberTransactionAmount
  {
    set => this._columnNumberTransactionAmount = value;
    get => this._columnNumberTransactionAmount;
  }

  public int ColumnNumberEffectiveDate
  {
    set => this._columnNumberEffectiveDate = value;
    get => this._columnNumberEffectiveDate;
  }

  public int ColumnNumberCompanyCompositeCommission
  {
    set => this._columnNumberCompanyCompositeCommission = value;
    get => this._columnNumberCompanyCompositeCommission;
  }

  public int ColumnNumberProducerCompositeCommission
  {
    set => this._columnNumberProducerCompositeCommission = value;
    get => this._columnNumberProducerCompositeCommission;
  }

  public int ColumnNumberAdditionalInterestName
  {
    set => this._columnNumberAdditionalInterestName = value;
    get => this._columnNumberAdditionalInterestName;
  }

  public int ColumnNumberAdditionalInterestAddress
  {
    set => this._columnNumberAdditionalInterestAddress = value;
    get => this._columnNumberAdditionalInterestAddress;
  }

  public int ColumnNumberAdditionalInterestCity
  {
    set => this._columnNumberAdditionalInterestCity = value;
    get => this._columnNumberAdditionalInterestCity;
  }

  public int ColumnNumberAdditionalInterestState
  {
    set => this._columnNumberAdditionalInterestState = value;
    get => this._columnNumberAdditionalInterestState;
  }

  public int ColumnNumberAdditionalInterestZip
  {
    set => this._columnNumberAdditionalInterestZip = value;
    get => this._columnNumberAdditionalInterestZip;
  }

  public bool ExcelHeaderColumn
  {
    set => this._excelHeaderColumn = value;
    get => this._excelHeaderColumn;
  }

  public bool StripPolicyNumber
  {
    set => this._stripPolicyNumber = value;
    get => this._stripPolicyNumber;
  }

  public string PathToEncrypt => this._pathToEncrypt;

  public bool TestDatabaseConnection()
  {
    try
    {
      using (SqlConnection connection = new SqlConnection(DefaultDatabase.ConnectionString))
      {
        connection.Open();
        SqlCommand sqlCommand = new SqlCommand("select top 1 * from tblQuotes", connection);
        sqlCommand.CommandTimeout = 100;
        sqlCommand.CommandType = CommandType.Text;
        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
        {
          if (sqlDataReader.Read())
            return true;
        }
      }
    }
    catch (Exception ex)
    {
      LogFile logFile1 = new LogFile(new Exception("Login Failed. Please check config file and enter correct db credentials."), nameof (TestDatabaseConnection), this.ErrorLogDirectory, this.AllDebugInfo);
      string errorLogDirectory = this.ErrorLogDirectory;
      int num = this.AllDebugInfo ? 1 : 0;
      LogFile logFile2 = new LogFile(ex, nameof (TestDatabaseConnection), errorLogDirectory, num != 0);
      return false;
    }
    return false;
  }

  public bool InitializeConfigProperties(XmlDocument xdoc)
  {
    try
    {
      bool result = false;
      bool.TryParse(XmlHelper.retrieveXMLNodeInnerText(xdoc, this.PathToAllDebugInfo, this.ErrorLogDirectory), out result);
      this.AllDebugInfo = result;
    }
    catch (Exception ex)
    {
      string errorLogDirectory = this.ErrorLogDirectory;
      int num = this.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method InitializeConfigProperties", errorLogDirectory, num != 0);
      return false;
    }
    return true;
  }

  public bool setupSprocs(XmlDocument xdoc)
  {
    try
    {
      XmlNode xmlNode1 = XmlHelper.retrieveXMLNode(xdoc, this.PathToSprocs, this.ErrorLogDirectory);
      for (int key1 = 0; key1 < xmlNode1.SelectNodes("Sproc").Count; ++key1)
      {
        Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
        Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
        XmlNode xmlNode2 = xmlNode1.SelectSingleNode($"Sproc[@index='{key1.ToString()}']");
        SprocData sprocData = new SprocData();
        sprocData.SprocName = xmlNode2.SelectSingleNode("Name").InnerText;
        sprocData.PolicyStatus = xmlNode2.SelectSingleNode("Name").Attributes["policyStatus"] == null ? new bool?() : new bool?(bool.Parse(xmlNode2.SelectSingleNode("Name").Attributes["policyStatus"].Value.ToString()));
        sprocData.AlwaysRunSproc = xmlNode2.SelectSingleNode("Name").Attributes["alwaysRun"] != null && bool.Parse(xmlNode2.SelectSingleNode("Name").Attributes["alwaysRun"].Value.ToString());
        sprocData.CheckReturn = xmlNode2.SelectSingleNode("Name").Attributes["checkReturn"] != null && bool.Parse(xmlNode2.SelectSingleNode("Name").Attributes["checkReturn"].Value.ToString());
        sprocData.CheckValue = xmlNode2.SelectSingleNode("Name").Attributes["checkValue"] != null && bool.Parse(xmlNode2.SelectSingleNode("Name").Attributes["checkValue"].Value.ToString());
        if (xmlNode2.SelectSingleNode("Name").Attributes["checkValueEquals"] != null && !string.IsNullOrEmpty(xmlNode2.SelectSingleNode("Name").Attributes["checkValueEquals"].Value.ToString()))
          sprocData.CheckValueEquals = xmlNode2.SelectSingleNode("Name").Attributes["checkValueEquals"].Value.ToString();
        if (xmlNode2.SelectSingleNode("Name").Attributes["customReturnErrorMessage"] != null && !string.IsNullOrEmpty(xmlNode2.SelectSingleNode("Name").Attributes["customReturnErrorMessage"].Value.ToString()))
          sprocData.CustomReturnErrorMessage = xmlNode2.SelectSingleNode("Name").Attributes["customReturnErrorMessage"].Value.ToString();
        for (int key2 = 0; key2 < xmlNode2.SelectNodes("Parameters/Param").Count; ++key2)
        {
          string innerText = xmlNode2.SelectSingleNode($"Parameters/Param[@index='{key2.ToString()}']").InnerText;
          dictionary2.Add(key2, innerText);
        }
        sprocData.Parameters = dictionary2;
        this.AllSprocData.Add(key1, sprocData);
      }
    }
    catch (Exception ex)
    {
      string errorLogDirectory = this.ErrorLogDirectory;
      int num = this.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method setupSprocs", errorLogDirectory, num != 0);
      return false;
    }
    return true;
  }

  public bool InitializeExcelFileProperties(XmlDocument xdoc)
  {
    try
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = -1;
      int num4 = -1;
      int num5 = -1;
      int num6 = -1;
      int num7 = -1;
      int num8 = -1;
      int num9 = -1;
      int num10 = -1;
      XmlElement xmlElement1 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnPolicyNumber, this.ErrorLogDirectory);
      if (xmlElement1 != null)
        num1 = int.Parse(xmlElement1.GetAttribute("index").ToString());
      XmlElement xmlElement2 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnTransactionAmount, this.ErrorLogDirectory);
      if (xmlElement2 != null)
        num2 = int.Parse(xmlElement2.GetAttribute("index").ToString());
      XmlElement xmlElement3 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnEffectiveDate, this.ErrorLogDirectory);
      if (xmlElement3 != null && xmlElement3.GetAttribute("active").ToString() != "false")
        num3 = int.Parse(xmlElement3.GetAttribute("index").ToString());
      XmlElement xmlElement4 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnCompanyCompositeCommission, this.ErrorLogDirectory);
      if (xmlElement4 != null && xmlElement4.GetAttribute("active").ToString() != "false")
        num4 = int.Parse(xmlElement4.GetAttribute("index").ToString());
      XmlElement xmlElement5 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnProducerCompositeCommission, this.ErrorLogDirectory);
      if (xmlElement5 != null && xmlElement5.GetAttribute("active").ToString() != "false")
        num5 = int.Parse(xmlElement5.GetAttribute("index").ToString());
      XmlElement xmlElement6 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnAdditionalInterestName, this.ErrorLogDirectory);
      if (xmlElement6 != null && xmlElement6.GetAttribute("active").ToString() != "false")
        num6 = int.Parse(xmlElement6.GetAttribute("index").ToString());
      XmlElement xmlElement7 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnAdditionalInterestAddress, this.ErrorLogDirectory);
      if (xmlElement7 != null && xmlElement7.GetAttribute("active").ToString() != "false")
        num7 = int.Parse(xmlElement7.GetAttribute("index").ToString());
      XmlElement xmlElement8 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnAdditionalInterestCity, this.ErrorLogDirectory);
      if (xmlElement8 != null && xmlElement8.GetAttribute("active").ToString() != "false")
        num8 = int.Parse(xmlElement8.GetAttribute("index").ToString());
      XmlElement xmlElement9 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnAdditionalInterestState, this.ErrorLogDirectory);
      if (xmlElement9 != null && xmlElement9.GetAttribute("active").ToString() != "false")
        num9 = int.Parse(xmlElement9.GetAttribute("index").ToString());
      XmlElement xmlElement10 = (XmlElement) XmlHelper.retrieveXMLNode(xdoc, this.PathToColumnAdditionalInterestZip, this.ErrorLogDirectory);
      if (xmlElement10 != null && xmlElement10.GetAttribute("active").ToString() != "false")
        num10 = int.Parse(xmlElement10.GetAttribute("index").ToString());
      this.ColumnNumberPolicyNumber = num1 != -1 && num2 != -1 ? num1 : throw new Exception("Column nodes were not found or do not contain index attributes. Please review the config.xml file and correct.");
      this.ColumnNumberTransactionAmount = num2;
      this.ColumnNumberEffectiveDate = num3;
      this.ColumnNumberCompanyCompositeCommission = num4;
      this.ColumnNumberProducerCompositeCommission = num5;
      this.ColumnNumberAdditionalInterestName = num6;
      this.ColumnNumberAdditionalInterestAddress = num7;
      this.ColumnNumberAdditionalInterestCity = num8;
      this.ColumnNumberAdditionalInterestState = num9;
      this.ColumnNumberAdditionalInterestZip = num10;
      bool result1 = false;
      bool result2 = false;
      bool.TryParse(XmlHelper.retrieveXMLNodeInnerText(xdoc, this.PathToHasHeaderColumn, this.ErrorLogDirectory), out result1);
      bool.TryParse(XmlHelper.retrieveXMLNodeInnerText(xdoc, this.PathToStripPolicyNumber, this.ErrorLogDirectory), out result2);
      this.ExcelHeaderColumn = result1;
      this.StripPolicyNumber = result2;
    }
    catch (Exception ex)
    {
      string errorLogDirectory = this.ErrorLogDirectory;
      int num = this.AllDebugInfo ? 1 : 0;
      LogFile logFile = new LogFile(ex, "method InitializeExcelFileProperties", errorLogDirectory, num != 0);
      return false;
    }
    return true;
  }
}
