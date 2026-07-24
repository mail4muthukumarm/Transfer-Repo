// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.lstAdHocControls
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using System.Data;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

internal class lstAdHocControls
{
  private DataTable _dt;

  public lstAdHocControls() => this.PopulateDataTable();

  public DataTable GetAdHocControls() => this._dt;

  public DataTable GetAdHocControls(string SelectStatement, int top = 0, int documentAutomationGroup = 0)
  {
    string str = !(SelectStatement == "") ? $"{SelectStatement} AND ReportType={documentAutomationGroup.ToString()}" : "ReportType=" + documentAutomationGroup.ToString();
    DataTable adHocControls = this._dt.Clone();
    DataView dataView = new DataView(this._dt);
    dataView.RowFilter = str;
    top = dataView.ToTable().Rows.Count > top ? top : dataView.ToTable().Rows.Count;
    if (top > 0)
    {
      for (int index = 0; index < top; ++index)
        adHocControls.ImportRow(dataView.ToTable().Rows[index]);
    }
    else
      adHocControls = dataView.ToTable();
    return adHocControls;
  }

  public int NumberOfRetValues(int ControlId)
  {
    return int.Parse(this._dt.Select("ControlID=" + ControlId.ToString())[0][nameof (NumberOfRetValues)].ToString());
  }

  public DataTable GetAdHocControlGroups(int documentAutomationGroup = 0)
  {
    return this.GenAdHocControlGroups(documentAutomationGroup);
  }

  public DataTable GetAdHocControl(int ControlId)
  {
    DataTable dataTable = new DataTable();
    DataView defaultView = this._dt.DefaultView;
    defaultView.RowFilter = "ControlID=" + ControlId.ToString();
    return defaultView.ToTable(true, "FullControlName", "NumberOfArgs", "NumberOfRetValues");
  }

  private DataTable GenAdHocControlGroups(int documentAutomationGroup)
  {
    DataView defaultView = this._dt.DefaultView;
    defaultView.Sort = "FullControlName ASC";
    defaultView.RowFilter = "ReportType = " + documentAutomationGroup.ToString();
    DataTable table1 = this._dt.DefaultView.ToTable(true, "ControlID", "FullControlName");
    table1.Columns.Add(new DataColumn("ControlName", typeof (string)));
    foreach (DataRow row in (InternalDataCollectionBase) table1.Rows)
    {
      string str = row["FullControlName"].ToString();
      row["ControlName"] = (object) str.Substring(0, str.IndexOf('('));
    }
    DataTable table2 = table1.DefaultView.ToTable(true, "ControlName");
    table2.Columns.Add(new DataColumn("ControlID", typeof (int)));
    table2.Columns["ControlID"].SetOrdinal(0);
    table2.Columns.Add(new DataColumn("OverloadsCount", typeof (int)));
    foreach (DataRow row in (InternalDataCollectionBase) table2.Rows)
    {
      string str = row["ControlName"].ToString();
      row["ControlID"] = table1.Compute("MIN(ControlID)", $"ControlName= '{str}'");
      row["OverloadsCount"] = table1.Compute("COUNT(ControlID)", $"ControlName= '{str}'");
    }
    return table2;
  }

  private void PopulateDataTable()
  {
    this._dt = new DataTable();
    this._dt.Columns.Add("ControlID", typeof (int));
    this._dt.Columns.Add("FullControlName", typeof (string));
    this._dt.Columns.Add("NumberOfArgs", typeof (int));
    this._dt.Columns.Add("Arg_0_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_1_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_2_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_3_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_4_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_5_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_6_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_7_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_8_Datatype", typeof (string));
    this._dt.Columns.Add("Arg_9_Datatype", typeof (string));
    this._dt.Columns.Add("NumberOfRetValues", typeof (int));
    this._dt.Columns.Add("ReturnType1", typeof (string));
    this._dt.Columns.Add("ReturnType2", typeof (string));
    this._dt.Columns.Add("Usable", typeof (bool));
    this._dt.Columns.Add("ReportType", typeof (int));
    this._dt.Rows.Add((object) 2, (object) "BillingTypesListBox(ByVal Label As String, ByVal ShowAll As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 3, (object) "BusinessTypes(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 4, (object) "Companies_Multi(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 5, (object) "CompanyGroups(ByVal labelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 6, (object) "CompanyGroups(ByVal labelText As String, ByVal ShowAllOption As Boolean, ByVal ShowIntermediaries As Boolean)", (object) 3, (object) "string", (object) "boolean", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 7, (object) "CompanyLines(ByVal labelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 8, (object) "CompanyLocations(ByVal labelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 10, (object) "CoverageLines(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 11, (object) "DatePicker(ByVal labelText As String, ByVal InitialDate As Date, ByVal dateOptional As Boolean)", (object) 3, (object) "string", (object) "string", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "DateTime", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 12, (object) "DatePicker(ByVal labelText As String, ByVal dateOptional As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "DateTime", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 13, (object) "DateRangePicker(ByVal labelText As String, ByVal datesOptional As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 14, (object) "DateRangePicker(ByVal labelText As String, ByVal dateFrom As Date, ByVal dateTo As Date)", (object) 3, (object) "string", (object) "string", (object) "string", null, null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 15, (object) "DateRangePicker(ByVal labelText As String, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal datesOptional As Boolean)", (object) 4, (object) "string", (object) "string", (object) "string", (object) "boolean", null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 16 /*0x10*/, (object) "EntitySelection(ByVal LabelText As String, ByVal Required As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 17, (object) "EntitySelection(ByVal LabelText As String, ByVal Required As Boolean, ByVal OnlyCompanyInfo As Boolean)", (object) 3, (object) "string", (object) "boolean", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 18, (object) "GenericCheckBox(ByVal LabelText As String, ByVal CheckboxText As String)", (object) 2, (object) "string", (object) "string", null, null, null, null, null, null, null, null, (object) 1, (object) "boolean", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 19, (object) "GenericCheckBox(ByVal LabelText As String, ByVal CheckboxText As String, ByVal StartAsChecked As Boolean)", (object) 3, (object) "string", (object) "string", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "boolean", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 20, (object) "GenericComboBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal returnType As Type, ByVal width As Integer, ByVal dropdownwidth As Integer)", (object) 7, (object) "string", (object) "string", (object) "string", (object) "string", (object) "string", (object) "int", (object) "int", null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 21, (object) "GenericComboBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal returnType As Type)", (object) 5, (object) "string", (object) "string", (object) "string", (object) "string", (object) "type", null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 22, (object) "GenericListBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal width As Integer, ByVal ShowAllOption As Boolean)", (object) 6, (object) "string", (object) "string", (object) "string", (object) "string", (object) "int", (object) "boolean", null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 23, (object) "GenericListBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal ShowAllOption As Boolean)", (object) 5, (object) "string", (object) "string", (object) "string", (object) "string", (object) "boolean", null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 24, (object) "GenericListBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal ShowAllOption As Boolean, ByVal ReturnType As System.Type)", (object) 6, (object) "string", (object) "string", (object) "string", (object) "string", (object) "boolean", (object) "string", null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 25, (object) "GenericListBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal ShowAllOption As Boolean, ByVal ReturnType As System.Type, ByVal CheckAllItem As Boolean)", (object) 7, (object) "string", (object) "string", (object) "string", (object) "string", (object) "boolean", (object) "string", (object) "boolean", null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 26, (object) "GenericListBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal ShowAllOption As Boolean, ByVal ReturnType As System.Type, ByVal CheckAllItem As Boolean, ByVal ReturnAll As Boolean)", (object) 8, (object) "string", (object) "string", (object) "string", (object) "string", (object) "boolean", (object) "type", (object) "boolean", (object) "boolean", null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 27, (object) "GenericListBox(ByVal LabelText As String, ByVal SQLText As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal ShowAllOption As Boolean, ByVal ReturnType As System.Type, ByVal CheckAllItem As Boolean, ByVal ReturnAll As Boolean, ByVal ControlHeight As Integer)", (object) 9, (object) "string", (object) "string", (object) "string", (object) "string", (object) "boolean", (object) "type", (object) "boolean", (object) "boolean", (object) "int", null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 28, (object) "Insureds(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 29, (object) "LicenseTypes(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    DataRowCollection rows1 = this._dt.Rows;
    object[] objArray1 = new object[18];
    objArray1[0] = (object) 30;
    objArray1[1] = (object) "MoneyRange(ByVal Description As String)";
    objArray1[2] = (object) 1;
    objArray1[3] = (object) "string";
    objArray1[13] = (object) 1;
    objArray1[14] = (object) "string";
    objArray1[16 /*0x10*/] = (object) true;
    objArray1[17] = (object) 0;
    rows1.Add(objArray1);
    this._dt.Rows.Add((object) 31 /*0x1F*/, (object) "MoneyRange(ByVal Description As String, ByVal InputOptional As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 32 /*0x20*/, (object) "NoteType(ByVal labelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 33, (object) "Occupancy(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 34, (object) "OfficeLocations(ByVal LabelText As String, ByVal ShowAllOption As Boolean, ByVal GetLocationIDAsInteger As Boolean)", (object) 3, (object) "string", (object) "boolean", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 35, (object) "OfficeLocations(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    DataRowCollection rows2 = this._dt.Rows;
    object[] objArray2 = new object[18];
    objArray2[0] = (object) 38;
    objArray2[1] = (object) "OfficesAndProducerSelection()";
    objArray2[2] = (object) 0;
    objArray2[13] = (object) 1;
    objArray2[14] = (object) "string";
    objArray2[16 /*0x10*/] = (object) true;
    objArray2[17] = (object) 0;
    rows2.Add(objArray2);
    this._dt.Rows.Add((object) 39, (object) "OptionalDateRange(ByVal labelText As String, ByVal dateFrom As Date, ByVal dateTo As Date)", (object) 3, (object) "string", (object) "boolean", (object) "boolean", null, null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 41, (object) "ProducerLocations(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 42, (object) "ProducerLocations_Multi(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 43, (object) "Producers(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 44, (object) "Producers_Multi(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 45, (object) "Producers_Multi_Ex(ByVal LabelText As String)", (object) 1, (object) "string", null, null, null, null, null, null, null, null, null, (object) 2, (object) "string", (object) "boolean", (object) true, (object) 0);
    this._dt.Rows.Add((object) 46, (object) "QuoteStatus(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 48 /*0x30*/, (object) "States(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    DataRowCollection rows3 = this._dt.Rows;
    object[] objArray3 = new object[18];
    objArray3[0] = (object) 49;
    objArray3[1] = (object) "StateThenCitySelection()";
    objArray3[2] = (object) 0;
    objArray3[13] = (object) 2;
    objArray3[14] = (object) "string";
    objArray3[15] = (object) "string";
    objArray3[16 /*0x10*/] = (object) true;
    objArray3[17] = (object) 0;
    rows3.Add(objArray3);
    this._dt.Rows.Add((object) 50, (object) "TextInput(ByVal labelText As String, ByVal Required As Boolean, ByVal NumericOnly As Boolean)", (object) 3, (object) "string", (object) "boolean", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 51, (object) "TextInput(ByVal LabelText As String, ByVal ReturnType As ReturnType, ByVal Required As Boolean)", (object) 3, (object) "string", (object) "type", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 52, (object) "Underwriters(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 54, (object) "CompanyTree(ByVal LabelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 2, (object) "string", (object) "string", (object) true, (object) 0);
    this._dt.Rows.Add((object) 55, (object) "CompanyTree(ByVal LabelText As String, ByVal ControlHeight As Integer, ByVal ShowAllOption As Boolean)", (object) 3, (object) "string", (object) "int", (object) "boolean", null, null, null, null, null, null, null, (object) 2, (object) "string", (object) "string", (object) true, (object) 0);
    this._dt.Rows.Add((object) 56, (object) "CompanyTree(ByVal LabelText As String, ByVal width As Integer, ByVal ControlHeight As Integer, ByVal ShowAllOption As Boolean)", (object) 4, (object) "string", (object) "int", (object) "int", (object) "boolean", null, null, null, null, null, null, (object) 2, (object) "string", (object) "string", (object) true, (object) 0);
    this._dt.Rows.Add((object) 57, (object) "CostCenter(ByVal Label As String, ByVal ShowAll As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "int", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 58, (object) "CostCenter(ByVal LabelText As String, ByVal ShowAll As Boolean, ByVal width As Integer, ByVal dropdownwidth As Integer)", (object) 4, (object) "string", (object) "boolean", (object) "int", (object) "int", null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 59, (object) "Users(ByVal labelText As String, ByVal ShowAllOption As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 60, (object) "Users(ByVal labelText As String, ByVal ShowAllOption As Boolean, ByVal ControlWidth As Integer)", (object) 3, (object) "string", (object) "boolean", (object) "int", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 61, (object) "DatePickerSpin(ByVal labelText As String, ByVal dateOptional As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "DateTime", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 62, (object) "DatePickerSpin(ByVal labelText As String, ByVal InitialDate As Date)", (object) 2, (object) "string", (object) "string", null, null, null, null, null, null, null, null, (object) 1, (object) "DateTime", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 63 /*0x3F*/, (object) "DatePickerSpin(ByVal labelText As String, ByVal dateOptional As Boolean, ByVal Format As String)", (object) 3, (object) "string", (object) "boolean", (object) "string", null, null, null, null, null, null, null, (object) 1, (object) "DateTime", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 64 /*0x40*/, (object) "DatePickerSpin(ByVal labelText As String, ByVal InitialDate As Date, ByVal Format As String)", (object) 3, (object) "string", (object) "string", (object) "string", null, null, null, null, null, null, null, (object) 1, (object) "DateTime", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 65, (object) "DateRangePickerSpin(ByVal labelText As String, ByVal datesOptional As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 66, (object) "DateRangePickerSpin(ByVal labelText As String, ByVal dateFrom As Date, ByVal dateTo As Date)", (object) 3, (object) "string", (object) "string", (object) "string", null, null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 67, (object) "DateRangePickerSpin(ByVal labelText As String, ByVal datesOptional As Boolean, ByVal Format As String)", (object) 3, (object) "string", (object) "boolean", (object) "string", null, null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 68, (object) "DateRangePickerSpin(ByVal labelText As String, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal Format As String)", (object) 4, (object) "string", (object) "string", (object) "string", (object) "string", null, null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    this._dt.Rows.Add((object) 69, (object) "DateRangePickerSpin(ByVal labelText As String, ByVal dateFrom As Date, ByVal dateTo As Date, ByVal datesOptional As Boolean, ByVal Format As String)", (object) 5, (object) "string", (object) "string", (object) "string", (object) "boolean", (object) "string", null, null, null, null, null, (object) 2, (object) "DateTime", (object) "DateTime", (object) true, (object) 0);
    DataRowCollection rows4 = this._dt.Rows;
    object[] objArray4 = new object[18];
    objArray4[0] = (object) 70;
    objArray4[1] = (object) "ProducersLocationsContacts()";
    objArray4[2] = (object) 0;
    objArray4[13] = (object) 1;
    objArray4[14] = (object) "string";
    objArray4[16 /*0x10*/] = (object) true;
    objArray4[17] = (object) 0;
    rows4.Add(objArray4);
    this._dt.Rows.Add((object) 71, (object) "ProducersLocationsContacts(ByVal LabelText As String, ByVal ShowAll As Boolean)", (object) 2, (object) "string", (object) "boolean", null, null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 72, (object) "ProducersLocationsContacts(ByVal LabelText As String, ByVal ShowAll As Boolean, ByVal ShowLocations As Boolean, ByVal ShowContacts As Boolean)", (object) 4, (object) "string", (object) "boolean", (object) "boolean", (object) "boolean", null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 73, (object) "ProducersLocationsContacts(ByVal labelText As String, ByVal ShowAll As Boolean, ByVal ShowLocations As Boolean, ByVal ShowContacts As Boolean, ByVal ReturnAll As Boolean)", (object) 5, (object) "string", (object) "boolean", (object) "boolean", (object) "boolean", (object) "boolean", null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 74, (object) "CostCenters_Multi(ByVal LabelText As String, ByVal ShowAllOption As Boolean, ByVal CheckAllItem As Boolean)", (object) 3, (object) "string", (object) "boolean", (object) "boolean", null, null, null, null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 75, (object) "CompanyGroupsCompaniesCompanyLocations(labelText As String, ShowAllOption As Boolean, CheckAllOption As Boolean, ShowEntityLocations As Boolean, ShowEntityContacts As Boolean, ReturnAll As Boolean, Optional ControlHeight As Integer = 144)", (object) 6, (object) "string", (object) "boolean", (object) "boolean", (object) "boolean", (object) "boolean", (object) "boolean", null, null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    this._dt.Rows.Add((object) 76, (object) "CompanyGroupsCompaniesCompanyLocations(labelText As String, ShowAllOption As Boolean, CheckAllOption As Boolean, ShowEntityLocations As Boolean, ShowEntityContacts As Boolean, ReturnAll As Boolean, Optional ControlHeight As Integer = 144)", (object) 7, (object) "string", (object) "boolean", (object) "boolean", (object) "boolean", (object) "boolean", (object) "boolean", (object) "int", null, null, null, (object) 1, (object) "string", null, (object) true, (object) 0);
    DataRowCollection rows5 = this._dt.Rows;
    object[] objArray5 = new object[18];
    objArray5[0] = (object) 77;
    objArray5[1] = (object) "CurrentUserGuid()";
    objArray5[2] = (object) 0;
    objArray5[13] = (object) 1;
    objArray5[14] = (object) "string";
    objArray5[16 /*0x10*/] = (object) true;
    objArray5[17] = (object) 0;
    rows5.Add(objArray5);
    DataRowCollection rows6 = this._dt.Rows;
    object[] objArray6 = new object[18];
    objArray6[0] = (object) 200;
    objArray6[1] = (object) "Quote Guid()";
    objArray6[2] = (object) 0;
    objArray6[13] = (object) 1;
    objArray6[14] = (object) "string";
    objArray6[16 /*0x10*/] = (object) true;
    objArray6[17] = (object) 1;
    rows6.Add(objArray6);
    DataRowCollection rows7 = this._dt.Rows;
    object[] objArray7 = new object[18];
    objArray7[0] = (object) 201;
    objArray7[1] = (object) "Quote Option Guids()";
    objArray7[2] = (object) 0;
    objArray7[13] = (object) 1;
    objArray7[14] = (object) "string";
    objArray7[16 /*0x10*/] = (object) true;
    objArray7[17] = (object) 1;
    rows7.Add(objArray7);
    DataRowCollection rows8 = this._dt.Rows;
    object[] objArray8 = new object[18];
    objArray8[0] = (object) 202;
    objArray8[1] = (object) "AutomationGuid()";
    objArray8[2] = (object) 0;
    objArray8[13] = (object) 1;
    objArray8[14] = (object) "string";
    objArray8[16 /*0x10*/] = (object) true;
    objArray8[17] = (object) 1;
    rows8.Add(objArray8);
    DataRowCollection rows9 = this._dt.Rows;
    object[] objArray9 = new object[18];
    objArray9[0] = (object) 203;
    objArray9[1] = (object) "Company Line ID()";
    objArray9[2] = (object) 0;
    objArray9[13] = (object) 1;
    objArray9[14] = (object) "string";
    objArray9[16 /*0x10*/] = (object) true;
    objArray9[17] = (object) 1;
    rows9.Add(objArray9);
  }
}
