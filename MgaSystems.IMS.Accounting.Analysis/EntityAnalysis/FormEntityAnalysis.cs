// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.EntityAnalysis.FormEntityAnalysis
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.EntityAnalysis;

[TestForm]
public class FormEntityAnalysis : Form
{
  private DataSet p_ds;
  private IContainer components;
  private UltraTabControl analysisTabControl;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  private UltraTabPageControl ultraTabPageControl1;
  private UltraGroupBox ultraGroupBox2;
  private UltraGroupBox ultraGroupBox1;
  private Infragistics.Win.UltraWinChart.UltraChart chartBalances;
  private UltraTabPageControl ultraTabPageControl2;
  private UltraTabPageControl ultraTabPageControl3;
  private Infragistics.Win.UltraWinChart.UltraChart chartAREntityTypeBreakout;
  private UltraGroupBox ultraGroupBox3;
  private Infragistics.Win.UltraWinChart.UltraChart chartAPEntityTypeBreakout;
  private UltraGroupBox ultraGroupBox4;
  private Infragistics.Win.UltraWinChart.UltraChart chartBalanceBillingType;
  private PictureBox pictureBox1;
  private Label label1;
  private Label lblTakeAWhile;
  private UltraGrid gridProducerList;
  private MGAButton mgaButton1;
  private MGATextBox textLimitProducerList;
  private Label label3;
  private Timer timer1;
  private Panel panelProducerView;
  private Label labelProducerARAmount;
  private Label labelProducerAPAmount;
  private Label label6;
  private Label label5;
  private Label label4;
  private Label labelProducerName;
  private UltraTabPageControl ultraTabPageControl4;
  private Label label10;
  private GroupBox groupBox2;
  private GroupBox groupBox1;
  private Panel panelLoadingProducerPayments;
  private Label label12;
  private PictureBox pictureBox3;
  private Panel panelLoadingProducerPolicies;
  private Label label11;
  private PictureBox pictureBox2;
  private UltraGrid gridProducerPolicies;
  private Timer timer2;
  private Splitter vertSplitter;
  private Splitter horSplitter;
  private Panel panel1;
  private Splitter splitter1;
  private Label label2;
  private UltraGrid gridProducerPayments;
  private Panel panelCarrierView;
  private Label label7;
  private GroupBox groupBox3;
  private Panel panelLoadingCarrierPayments;
  private Label label8;
  private PictureBox pictureBox4;
  private UltraGrid gridCarrierPayments;
  private GroupBox groupBox4;
  private Panel panelLoadingCarrierPolicies;
  private Label label9;
  private PictureBox pictureBox5;
  private UltraGrid gridCarrierPolicies;
  private Label labelCarrierARAmount;
  private Label labelCarrierAPAmount;
  private Label label15;
  private Label label16;
  private Label label17;
  private Label labelCarrierName;
  private UltraGrid gridCarrierList;
  private MGATextBox textLimitCarrierList;
  private Label label19;
  private Label label13;
  private Panel panelInsuredView;
  private Label labelInsuredARAmount;
  private Label labelInsuredAPAmount;
  private Label label20;
  private GroupBox groupBox5;
  private Panel panelLoadingInsuredPayments;
  private Label label21;
  private PictureBox pictureBox6;
  private UltraGrid gridInsuredPayments;
  private GroupBox groupBox6;
  private Panel panelLoadingInsuredPolicies;
  private Label label22;
  private PictureBox pictureBox7;
  private UltraGrid gridInsuredPolicies;
  private Label label23;
  private Label label24;
  private Label label25;
  private Label labelInsuredName;
  private UltraGrid gridInsuredList;
  private MGATextBox textLimitInsuredList;
  private Label label27;
  private Label label14;
  private UltraTabPageControl ultraTabPageControl5;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel panelDateRange;
  private Label label18;
  private MGADateTimePicker dateTimeTo;
  private MGADateTimePicker dateTimeFrom;
  private MGASimpleComboBox comboGLCompany;
  private UltraToolbarsDockArea _FormEntityAnalysis_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormEntityAnalysis_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormEntityAnalysis_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormEntityAnalysis_Toolbars_Dock_Area_Top;
  private Panel panelOtherView;
  private Label labelOtherARAmount;
  private Label labelOtherAPAmount;
  private Label label29;
  private GroupBox groupBox7;
  private Panel panelLoadingOtherPayments;
  private Label label30;
  private PictureBox pictureBox8;
  private UltraGrid gridOtherPayments;
  private GroupBox groupBox8;
  private Panel panelLoadingOtherPolicies;
  private Label label31;
  private PictureBox pictureBox9;
  private UltraGrid gridOtherPolicies;
  private Label label32;
  private Label label33;
  private Label label34;
  private Label label3rdPartyExpensePayeeName;
  private UltraGrid gridOtherList;
  private MGATextBox textLimitOtherList;
  private Label label36;
  private Label label26;
  private CheckBox checkUseDateRange;
  private ToolTip toolTip1;

  public FormEntityAnalysis() => this.InitializeComponent();

  private void FormEntityAnalysis_Load(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.Default;
    this.SetInitialDateRange();
    this.LoadGLLocations();
    this.GetInitialData();
  }

  private void GetInitialData()
  {
    ((Control) this.analysisTabControl).Visible = false;
    this.p_ds = new DataSet();
    this.Cursor = MgaCursors.WaitCursor;
    this.ToggleShowTab(false);
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((s, dwe) =>
      {
        if (this.checkUseDateRange.Checked)
          this.p_ds = DefaultDatabase.ExecuteDataSet("spFin_GetEntityAnalysis", new object[4]
          {
            (object) "@dateFrom",
            this.dateTimeFrom.Value,
            (object) "@dateTo",
            this.dateTimeTo.Value
          });
        else
          this.p_ds = DefaultDatabase.ExecuteDataSet("spFin_GetEntityAnalysis");
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((s, dwe) =>
      {
        this.DisplayBalances();
        this.DisplayAREntityTypeBreakout();
        this.DisplayAPEntityTypeBreakout();
        this.DisplayBalancesByBillingType();
        this.ToggleShowTab(true);
        this.LoadProducerList();
        this.LoadCarrierList();
        this.LoadInsuredList();
        this.LoadOtherList();
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void DisplayBalances()
  {
    if (this.p_ds.Tables.Count == 0 || this.p_ds.Tables[0].Rows.Count == 0)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(new DataColumn("BalanceType", typeof (string)));
    dataTable.Columns.Add(new DataColumn("Balance", typeof (Decimal)));
    ChartTextAppearance chartTextAppearance = new ChartTextAppearance();
    dataTable.Rows.Add((object) "AR", this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", ""));
    dataTable.Rows.Add((object) "AP", this.p_ds.Tables[0].Compute("SUM(APAMOUNT)", ""));
    this.chartBalances.BarChart.ChartText.Add(new ChartTextAppearance()
    {
      ItemFormatString = "<DATA_VALUE:c>",
      HorizontalAlign = StringAlignment.Near,
      Row = 0,
      Column = 1,
      Visible = true,
      ChartTextFont = new Font("Tahoma", 12f, FontStyle.Bold)
    });
    this.chartBalances.BarChart.ChartText.Add(new ChartTextAppearance()
    {
      HorizontalAlign = StringAlignment.Near,
      ItemFormatString = "<DATA_VALUE:c>",
      Row = 0,
      Column = 0,
      Visible = true,
      ChartTextFont = new Font("Tahoma", 12f, FontStyle.Bold)
    });
    this.chartBalances.DataSource = (object) dataTable;
    this.Cursor = MgaCursors.Default;
  }

  private void DisplayAREntityTypeBreakout()
  {
    if (this.p_ds.Tables.Count == 0 || this.p_ds.Tables[0].Rows.Count == 0)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    DataTable dataTable = new DataTable();
    ChartTextAppearance chartTextAppearance = new ChartTextAppearance();
    IEnumerable<string> strings = this.p_ds.Tables[0].AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (row => row.Field<string>("EntityType"))).Distinct<string>();
    int num = 0;
    foreach (string columnName in strings)
    {
      dataTable.Columns.Add(new DataColumn(columnName, typeof (Decimal)));
      if (dataTable.Rows.Count == 0)
        dataTable.Rows.Add(this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", $"EntityType = '{columnName}'"));
      else
        dataTable.Rows[0][columnName] = this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", $"EntityType = '{columnName}'");
      this.chartAREntityTypeBreakout.PieChart.ChartText.Add(new ChartTextAppearance()
      {
        ItemFormatString = $"{columnName}{Environment.NewLine}{((Decimal) dataTable.Rows[0][columnName]).ToString("c")}",
        Row = num,
        Column = num,
        Visible = true,
        ChartTextFont = new Font("Tahoma", 10f, FontStyle.Bold)
      });
      ++num;
    }
    this.chartAREntityTypeBreakout.DataSource = (object) dataTable;
    this.Cursor = MgaCursors.Default;
  }

  private void DisplayAPEntityTypeBreakout()
  {
    if (this.p_ds.Tables.Count == 0 || this.p_ds.Tables[0].Rows.Count == 0)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    DataTable dataTable = new DataTable();
    ChartTextAppearance chartTextAppearance = new ChartTextAppearance();
    IEnumerable<string> strings = this.p_ds.Tables[0].AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (row => row.Field<string>("EntityType"))).Distinct<string>();
    int num = 0;
    foreach (string columnName in strings)
    {
      dataTable.Columns.Add(new DataColumn(columnName, typeof (Decimal)));
      if (dataTable.Rows.Count == 0)
        dataTable.Rows.Add(this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", $"EntityType = '{columnName}'"));
      else
        dataTable.Rows[0][columnName] = this.p_ds.Tables[0].Compute("SUM(APAMOUNT)", $"EntityType = '{columnName}'");
      this.chartAPEntityTypeBreakout.PieChart.ChartText.Add(new ChartTextAppearance()
      {
        ItemFormatString = $"{columnName}{Environment.NewLine}{((Decimal) dataTable.Rows[0][columnName]).ToString("c")}",
        Row = num,
        Column = num,
        Visible = true,
        ChartTextFont = new Font("Tahoma", 10f, FontStyle.Bold)
      });
      ++num;
    }
    this.chartAPEntityTypeBreakout.DataSource = (object) dataTable;
    this.Cursor = MgaCursors.Default;
  }

  private void DisplayBalancesByBillingType()
  {
    if (this.p_ds.Tables.Count == 0 || this.p_ds.Tables[0].Rows.Count == 0)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(new DataColumn("SumType", typeof (string)));
    dataTable.Columns.Add(new DataColumn("Agency Bill", typeof (Decimal)));
    dataTable.Columns.Add(new DataColumn("Direct Bill-Company", typeof (Decimal)));
    dataTable.Columns.Add(new DataColumn("Direct Bill-Insured", typeof (Decimal)));
    dataTable.Rows.Add((object) "AR", this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", $"BillingType = '{"Agency Bill"}'"), this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", $"BillingType = '{"Direct Bill-Company"}'"), this.p_ds.Tables[0].Compute("SUM(ARAMOUNT)", $"BillingType = '{"Direct Bill-Insured"}'"));
    dataTable.Rows.Add((object) "AP", this.p_ds.Tables[0].Compute("SUM(APAMOUNT)", $"BillingType = '{"Agency Bill"}'"), this.p_ds.Tables[0].Compute("SUM(APAMOUNT)", $"BillingType = '{"Direct Bill-Company"}'"), this.p_ds.Tables[0].Compute("SUM(APAMOUNT)", $"BillingType = '{"Direct Bill-Insured"}'"));
    ChartTextAppearance chartTextAppearance = new ChartTextAppearance();
    this.chartBalanceBillingType.DataSource = (object) dataTable;
    this.Cursor = MgaCursors.Default;
  }

  private void ToggleShowTab(bool toggle) => ((Control) this.analysisTabControl).Visible = toggle;

  private void timer1_Tick(object sender, EventArgs e)
  {
    this.lblTakeAWhile.SendToBack();
    this.lblTakeAWhile.Visible = true;
    this.timer1.Enabled = false;
    this.timer2.Enabled = true;
  }

  private void timer2_Tick(object sender, EventArgs e)
  {
    this.lblTakeAWhile.Text = "Hmmm....you have quite a bit of data...still gathering the information..hang in there!";
  }

  private void LoadEntityPolicies(Guid entityGuid, UltraGrid grid, string doneMethod)
  {
    DataTable dt = new DataTable();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) => dt = DefaultDatabase.ExecuteDataTable("spFin_GetEntityAnalysis_PolicyData", new object[2]
      {
        (object) "@entityGuid",
        (object) entityGuid
      }));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        ((UltraGridBase) grid).DataSource = (object) dt;
        this.GetType().GetMethod(doneMethod).Invoke((object) this, (object[]) null);
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void LoadEntityPaymentData(Guid entityGuid, UltraGrid grid, string doneMethod)
  {
    DataTable dt = new DataTable();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) => dt = DefaultDatabase.ExecuteDataTable("spFin_GetEntityAnalysis_CheckData", new object[2]
      {
        (object) "@entityGuid",
        (object) entityGuid
      }));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        ((UltraGridBase) grid).DataSource = (object) dt;
        this.GetType().GetMethod(doneMethod).Invoke((object) this, (object[]) null);
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  public void FormatGridGeneric(UltraGrid grid, params string[] hideColumns)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) grid).DisplayLayout.Bands).Count == 0 || ((DisposableObjectCollectionBase) ((UltraGridBase) grid).Rows).Count == 0)
      return;
    ((UltraGridBase) grid).DisplayLayout.Bands[0].Summaries.Clear();
    foreach (UltraGridColumn column in ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns)
    {
      if (column.DataType == typeof (string) || column.DataType == typeof (DateTime) || column.DataType == typeof (int))
      {
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
        column.CellAppearance.TextHAlign = (HAlign) 1;
      }
      if (column.DataType == typeof (Decimal))
      {
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
        column.CellAppearance.TextHAlign = (HAlign) 3;
        column.Format = "c";
        string str = $"{((KeyedSubObjectBase) column).Key}_{"SUM"}";
        ((UltraGridBase) grid).DisplayLayout.Bands[0].Summaries.Add(str, (SummaryType) 1, column, (SummaryPosition) 3);
        ((UltraGridBase) grid).DisplayLayout.Bands[0].Summaries[str].DisplayFormat = "{0:c}";
        ((UltraGridBase) grid).DisplayLayout.Bands[0].Summaries[str].Appearance.TextHAlign = (HAlign) 3;
      }
      if (column.DataType == typeof (Guid))
        column.Hidden = true;
    }
    if (hideColumns.Length == 0)
      return;
    for (int index = 0; index < hideColumns.Length; ++index)
      ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns[index].Hidden = true;
  }

  private void LoadProducerList()
  {
    IOrderedEnumerable<\u003C\u003Ef__AnonymousType2<Guid, string, Decimal, Decimal>> orderedEnumerable = this.p_ds.Tables[0].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (row => row.Field<string>("EntityType") == "Producer")).Select(row => new
    {
      EntityGuid = row.Field<Guid>("EntityGuid"),
      EntityName = row.Field<string>("EntityName"),
      ARAmount = row.Field<Decimal>("ARAmount"),
      APAmount = row.Field<Decimal>("APAmount")
    }).Distinct().GroupBy(s => new
    {
      EntityGuid = s.EntityGuid,
      EntityName = s.EntityName
    }).Select(g => new
    {
      EntityGuid = g.Key.EntityGuid,
      EntityName = g.Key.EntityName,
      ARTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.ARAmount), 2)),
      APTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.APAmount), 2))
    }).OrderBy(z => z.EntityName);
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[4]
    {
      new DataColumn("EntityGuid", typeof (Guid)),
      new DataColumn("EntityName", typeof (string)),
      new DataColumn("ARTotal", typeof (Decimal)),
      new DataColumn("APTotal", typeof (Decimal))
    });
    foreach (var data in orderedEnumerable)
      dataTable.Rows.Add((object) data.EntityGuid, (object) data.EntityName, (object) data.ARTotal, (object) data.APTotal);
    ((UltraGridBase) this.gridProducerList).DataSource = (object) dataTable;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Bands[0].Columns["EntityGuid"].Hidden = true;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Bands[0].Columns["ARTotal"].Hidden = true;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Bands[0].Columns["APTotal"].Hidden = true;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Bands[0].ColHeadersVisible = false;
    this.SelectFirstProducer();
  }

  public void ShowProducerPayments()
  {
    this.FormatGridGeneric(this.gridProducerPayments);
    ((Control) this.gridProducerPayments).Visible = true;
    this.panelLoadingProducerPayments.Visible = false;
  }

  public void ShowProducerPolicies()
  {
    this.FormatGridGeneric(this.gridProducerPolicies);
    this.panelProducerView.Visible = true;
    ((Control) this.gridProducerPolicies).Visible = true;
    this.panelLoadingProducerPolicies.Visible = false;
  }

  private void gridProducerList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
  }

  private void ShowProducer(
    Guid entityGuid,
    string insuredName,
    Decimal recTotal,
    Decimal payTotal)
  {
    this.panelLoadingProducerPolicies.Visible = true;
    this.panelLoadingProducerPayments.Visible = true;
    this.labelProducerName.Text = insuredName;
    this.labelProducerARAmount.Text = recTotal.ToString("c");
    this.labelProducerAPAmount.Text = payTotal.ToString("c");
    this.LoadEntityPolicies(entityGuid, this.gridProducerPolicies, "ShowProducerPolicies");
    this.LoadEntityPaymentData(entityGuid, this.gridProducerPayments, "ShowProducerPayments");
  }

  private void SelectFirstProducer()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridProducerList).Rows).Count == 0)
      return;
    UltraGridRow row = ((UltraGridBase) this.gridProducerList).Rows[0];
    this.ShowProducer(new Guid(row.Cells["EntityGuid"].Value.ToString()), row.Cells["EntityName"].Value.ToString(), Decimal.Parse(row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(row.Cells["APTotal"].Value.ToString()));
    ((GridItemBase) row).Selected = true;
    row.Activate();
  }

  private void textLimitProducerList_ValueChanged(object sender, EventArgs e)
  {
    this.ApplyEntityNameFilter(this.gridProducerList, ((Control) this.textLimitProducerList).Text);
  }

  private void gridProducerList_ClickCell(object sender, ClickCellEventArgs e)
  {
    this.ShowProducer(new Guid(e.Cell.Row.Cells["EntityGuid"].Value.ToString()), e.Cell.Row.Cells["EntityName"].Value.ToString(), Decimal.Parse(e.Cell.Row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(e.Cell.Row.Cells["APTotal"].Value.ToString()));
  }

  private void LoadCarrierList()
  {
    string[] eligEntityTypes = new string[2]
    {
      "Company",
      "Intermediary"
    };
    IOrderedEnumerable<\u003C\u003Ef__AnonymousType2<Guid, string, Decimal, Decimal>> orderedEnumerable = this.p_ds.Tables[0].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (row => ((IEnumerable<string>) eligEntityTypes).Contains<string>(row.Field<string>("EntityType")))).Select(row => new
    {
      EntityGuid = row.Field<Guid>("EntityGuid"),
      EntityName = row.Field<string>("EntityName"),
      ARAmount = row.Field<Decimal>("ARAmount"),
      APAmount = row.Field<Decimal>("APAmount")
    }).Distinct().GroupBy(s => new
    {
      EntityGuid = s.EntityGuid,
      EntityName = s.EntityName
    }).Select(g => new
    {
      EntityGuid = g.Key.EntityGuid,
      EntityName = g.Key.EntityName,
      ARTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.ARAmount), 2)),
      APTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.APAmount), 2))
    }).OrderBy(z => z.EntityName);
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[4]
    {
      new DataColumn("EntityGuid", typeof (Guid)),
      new DataColumn("EntityName", typeof (string)),
      new DataColumn("ARTotal", typeof (Decimal)),
      new DataColumn("APTotal", typeof (Decimal))
    });
    foreach (var data in orderedEnumerable)
      dataTable.Rows.Add((object) data.EntityGuid, (object) data.EntityName, (object) data.ARTotal, (object) data.APTotal);
    ((UltraGridBase) this.gridCarrierList).DataSource = (object) dataTable;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Bands[0].Columns["EntityGuid"].Hidden = true;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Bands[0].Columns["ARTotal"].Hidden = true;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Bands[0].Columns["APTotal"].Hidden = true;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Bands[0].ColHeadersVisible = false;
    this.SelectFirstCarrier();
  }

  private void gridCarrierList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.ShowCarrier(new Guid(e.Row.Cells["EntityGuid"].Value.ToString()), e.Row.Cells["EntityName"].Value.ToString(), Decimal.Parse(e.Row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(e.Row.Cells["APTotal"].Value.ToString()));
  }

  private void ShowCarrier(
    Guid entityGuid,
    string carrierName,
    Decimal recTotal,
    Decimal payTotal)
  {
    this.panelLoadingCarrierPayments.Visible = true;
    this.panelLoadingCarrierPolicies.Visible = true;
    this.labelCarrierName.Text = carrierName;
    this.labelCarrierARAmount.Text = recTotal.ToString("c");
    this.labelCarrierAPAmount.Text = payTotal.ToString("c");
    this.LoadEntityPolicies(entityGuid, this.gridCarrierPolicies, "ShowCarrierPolicies");
    this.LoadEntityPaymentData(entityGuid, this.gridCarrierPayments, "ShowCarrierPayments");
  }

  public void ShowCarrierPayments()
  {
    this.FormatGridGeneric(this.gridCarrierPayments);
    ((Control) this.gridCarrierPayments).Visible = true;
    this.panelLoadingCarrierPayments.Visible = false;
  }

  public void ShowCarrierPolicies()
  {
    this.FormatGridGeneric(this.gridCarrierPolicies);
    this.panelCarrierView.Visible = true;
    ((Control) this.gridCarrierPolicies).Visible = true;
    this.panelLoadingCarrierPolicies.Visible = false;
  }

  private void SelectFirstCarrier()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCarrierList).Rows).Count == 0)
      return;
    UltraGridRow row = ((UltraGridBase) this.gridCarrierList).Rows[0];
    this.ShowCarrier(new Guid(row.Cells["EntityGuid"].Value.ToString()), row.Cells["EntityName"].Value.ToString(), Decimal.Parse(row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(row.Cells["APTotal"].Value.ToString()));
    ((GridItemBase) row).Selected = true;
    row.Activate();
  }

  private void textLimitCarrierList_ValueChanged(object sender, EventArgs e)
  {
    this.ApplyEntityNameFilter(this.gridCarrierList, ((Control) this.textLimitCarrierList).Text);
  }

  private void LoadInsuredList()
  {
    IOrderedEnumerable<\u003C\u003Ef__AnonymousType2<Guid, string, Decimal, Decimal>> orderedEnumerable = this.p_ds.Tables[0].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (row => row.Field<string>("EntityType") == "Insured")).Select(row => new
    {
      EntityGuid = row.Field<Guid>("EntityGuid"),
      EntityName = row.Field<string>("EntityName"),
      ARAmount = row.Field<Decimal>("ARAmount"),
      APAmount = row.Field<Decimal>("APAmount")
    }).Distinct().GroupBy(s => new
    {
      EntityGuid = s.EntityGuid,
      EntityName = s.EntityName
    }).Select(g => new
    {
      EntityGuid = g.Key.EntityGuid,
      EntityName = g.Key.EntityName,
      ARTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.ARAmount), 2)),
      APTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.APAmount), 2))
    }).OrderBy(z => z.EntityName);
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[4]
    {
      new DataColumn("EntityGuid", typeof (Guid)),
      new DataColumn("EntityName", typeof (string)),
      new DataColumn("ARTotal", typeof (Decimal)),
      new DataColumn("APTotal", typeof (Decimal))
    });
    foreach (var data in orderedEnumerable)
      dataTable.Rows.Add((object) data.EntityGuid, (object) data.EntityName, (object) data.ARTotal, (object) data.APTotal);
    ((UltraGridBase) this.gridInsuredList).DataSource = (object) dataTable;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Bands[0].Columns["EntityGuid"].Hidden = true;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Bands[0].Columns["ARTotal"].Hidden = true;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Bands[0].Columns["APTotal"].Hidden = true;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Bands[0].ColHeadersVisible = false;
    this.SelectFirstInsured();
  }

  public void ShowInsuredPayments()
  {
    this.FormatGridGeneric(this.gridInsuredPayments);
    ((Control) this.gridInsuredPayments).Visible = true;
    this.panelLoadingInsuredPayments.Visible = false;
  }

  public void ShowInsuredPolicies()
  {
    this.FormatGridGeneric(this.gridInsuredPolicies);
    this.panelInsuredView.Visible = true;
    ((Control) this.gridInsuredPolicies).Visible = true;
    this.panelLoadingInsuredPolicies.Visible = false;
  }

  private void gridInsuredList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.ShowInsured(new Guid(e.Row.Cells["EntityGuid"].Value.ToString()), e.Row.Cells["EntityName"].Value.ToString(), Decimal.Parse(e.Row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(e.Row.Cells["APTotal"].Value.ToString()));
  }

  private void ShowInsured(
    Guid entityGuid,
    string insuredName,
    Decimal recTotal,
    Decimal payTotal)
  {
    this.panelLoadingInsuredPolicies.Visible = true;
    this.panelLoadingInsuredPayments.Visible = true;
    this.labelInsuredName.Text = insuredName;
    this.labelInsuredARAmount.Text = recTotal.ToString("c");
    this.labelInsuredAPAmount.Text = payTotal.ToString("c");
    this.LoadEntityPolicies(entityGuid, this.gridInsuredPolicies, "ShowInsuredPolicies");
    this.LoadEntityPaymentData(entityGuid, this.gridInsuredPayments, "ShowInsuredPayments");
  }

  private void SelectFirstInsured()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridInsuredList).Rows).Count == 0)
      return;
    UltraGridRow row = ((UltraGridBase) this.gridInsuredList).Rows[0];
    this.ShowInsured(new Guid(row.Cells["EntityGuid"].Value.ToString()), row.Cells["EntityName"].Value.ToString(), Decimal.Parse(row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(row.Cells["APTotal"].Value.ToString()));
    ((GridItemBase) row).Selected = true;
    row.Activate();
  }

  private void textLimitInsuredList_ValueChanged(object sender, EventArgs e)
  {
    this.ApplyEntityNameFilter(this.gridInsuredList, ((Control) this.textLimitInsuredList).Text);
  }

  private void LoadOtherList()
  {
    string[] eligEntityTypes = new string[2]
    {
      "3rd Party Payee",
      "Expense Payee"
    };
    IOrderedEnumerable<\u003C\u003Ef__AnonymousType2<Guid, string, Decimal, Decimal>> orderedEnumerable = this.p_ds.Tables[0].AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (row => ((IEnumerable<string>) eligEntityTypes).Contains<string>(row.Field<string>("EntityType")))).Select(row => new
    {
      EntityGuid = row.Field<Guid>("EntityGuid"),
      EntityName = row.Field<string>("EntityName"),
      ARAmount = row.Field<Decimal>("ARAmount"),
      APAmount = row.Field<Decimal>("APAmount")
    }).Distinct().GroupBy(s => new
    {
      EntityGuid = s.EntityGuid,
      EntityName = s.EntityName
    }).Select(g => new
    {
      EntityGuid = g.Key.EntityGuid,
      EntityName = g.Key.EntityName,
      ARTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.ARAmount), 2)),
      APTotal = g.Sum(x => Math.Round(Convert.ToDecimal(x.APAmount), 2))
    }).OrderBy(z => z.EntityName);
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[4]
    {
      new DataColumn("EntityGuid", typeof (Guid)),
      new DataColumn("EntityName", typeof (string)),
      new DataColumn("ARTotal", typeof (Decimal)),
      new DataColumn("APTotal", typeof (Decimal))
    });
    foreach (var data in orderedEnumerable)
      dataTable.Rows.Add((object) data.EntityGuid, (object) data.EntityName, (object) data.ARTotal, (object) data.APTotal);
    ((UltraGridBase) this.gridOtherList).DataSource = (object) dataTable;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Bands[0].Columns["EntityGuid"].Hidden = true;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Bands[0].Columns["ARTotal"].Hidden = true;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Bands[0].Columns["APTotal"].Hidden = true;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Bands[0].ColHeadersVisible = false;
    this.SelectFirstOther();
  }

  private void gridOtherList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.ShowOther(new Guid(e.Row.Cells["EntityGuid"].Value.ToString()), e.Row.Cells["EntityName"].Value.ToString(), Decimal.Parse(e.Row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(e.Row.Cells["APTotal"].Value.ToString()));
  }

  private void ShowOther(Guid entityGuid, string carrierName, Decimal recTotal, Decimal payTotal)
  {
    this.panelLoadingOtherPayments.Visible = true;
    this.panelLoadingOtherPolicies.Visible = true;
    this.label3rdPartyExpensePayeeName.Text = carrierName;
    this.labelOtherARAmount.Text = recTotal.ToString("c");
    this.labelOtherAPAmount.Text = payTotal.ToString("c");
    this.LoadEntityPolicies(entityGuid, this.gridOtherPolicies, "ShowOtherPolicies");
    this.LoadEntityPaymentData(entityGuid, this.gridOtherPayments, "ShowOtherPayments");
  }

  public void ShowOtherPayments()
  {
    this.FormatGridGeneric(this.gridOtherPayments);
    ((Control) this.gridOtherPayments).Visible = true;
    this.panelLoadingOtherPayments.Visible = false;
  }

  public void ShowOtherPolicies()
  {
    this.FormatGridGeneric(this.gridOtherPolicies);
    this.panelOtherView.Visible = true;
    ((Control) this.gridOtherPolicies).Visible = true;
    this.panelLoadingOtherPolicies.Visible = false;
  }

  private void SelectFirstOther()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOtherList).Rows).Count == 0)
      return;
    UltraGridRow row = ((UltraGridBase) this.gridOtherList).Rows[0];
    this.ShowOther(new Guid(row.Cells["EntityGuid"].Value.ToString()), row.Cells["EntityName"].Value.ToString(), Decimal.Parse(row.Cells["ARTotal"].Value.ToString()), Decimal.Parse(row.Cells["APTotal"].Value.ToString()));
    ((GridItemBase) row).Selected = true;
    row.Activate();
  }

  private void textLimitOtherList_ValueChanged(object sender, EventArgs e)
  {
    this.ApplyEntityNameFilter(this.gridOtherList, ((Control) this.textLimitOtherList).Text);
  }

  private void ApplyEntityNameFilter(UltraGrid grid, string filterValue)
  {
    if (string.IsNullOrEmpty(filterValue))
    {
      ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters["EntityName"].ClearFilterConditions();
    }
    else
    {
      ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters["EntityName"].ClearFilterConditions();
      UltraGridColumn column = ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns["EntityName"];
      ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters["EntityName"].FilterConditions.Add(new FilterCondition(column, (FilterComparisionOperator) 14, (object) filterValue));
    }
  }

  private void LoadGLLocations()
  {
    DataTable dt = new DataTable();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((s, dwe) => dt = DefaultDatabase.ExecuteDataTable("spFin_GetOfficeLocations", new object[4]
      {
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@alloption",
        (object) true
      }));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((s, dwe) =>
      {
        ((UltraGridBase) this.comboGLCompany).DataSource = (object) dt;
        ((UltraDropDownBase) this.comboGLCompany).DisplayMember = "Office Location";
        ((UltraDropDownBase) this.comboGLCompany).ValueMember = "ID";
        ((UltraDropDownBase) this.comboGLCompany).SelectedRow = ((UltraGridBase) this.comboGLCompany).Rows[0];
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void SetInitialDateRange()
  {
    int year = DateTime.Now.Year;
    DateTime dateTime1 = new DateTime(year, 1, 1);
    DateTime dateTime2 = new DateTime(year, 12, 31 /*0x1F*/);
    this.dateTimeFrom.DateTime = dateTime1;
    this.dateTimeTo.DateTime = dateTime2;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (!(key == "REFRESH"))
    {
      int num = key == "PRINT" ? 1 : 0;
    }
    else
      this.GetInitialData();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    PaintElement paintElement1 = new PaintElement();
    ChartLayerAppearance chartLayerAppearance1 = new ChartLayerAppearance();
    GradientEffect gradientEffect1 = new GradientEffect();
    TextureEffect textureEffect1 = new TextureEffect();
    StrokeEffect strokeEffect1 = new StrokeEffect();
    ShadowEffect shadowEffect1 = new ShadowEffect();
    ThreeDEffect threeDeffect1 = new ThreeDEffect();
    Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
    PaintElement paintElement2 = new PaintElement();
    BarChartAppearance barChartAppearance = new BarChartAppearance();
    ChartLayerAppearance chartLayerAppearance2 = new ChartLayerAppearance();
    GradientEffect gradientEffect2 = new GradientEffect();
    TextureEffect textureEffect2 = new TextureEffect();
    StrokeEffect strokeEffect2 = new StrokeEffect();
    ShadowEffect shadowEffect2 = new ShadowEffect();
    ThreeDEffect threeDeffect2 = new ThreeDEffect();
    Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
    PaintElement paintElement3 = new PaintElement();
    ChartLayerAppearance chartLayerAppearance3 = new ChartLayerAppearance();
    GradientEffect gradientEffect3 = new GradientEffect();
    TextureEffect textureEffect3 = new TextureEffect();
    StrokeEffect strokeEffect3 = new StrokeEffect();
    ShadowEffect shadowEffect3 = new ShadowEffect();
    ThreeDEffect threeDeffect3 = new ThreeDEffect();
    PieChartAppearance pieChartAppearance1 = new PieChartAppearance();
    Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
    PaintElement paintElement4 = new PaintElement();
    ChartLayerAppearance chartLayerAppearance4 = new ChartLayerAppearance();
    GradientEffect gradientEffect4 = new GradientEffect();
    TextureEffect textureEffect4 = new TextureEffect();
    StrokeEffect strokeEffect4 = new StrokeEffect();
    ShadowEffect shadowEffect4 = new ShadowEffect();
    ThreeDEffect threeDeffect4 = new ThreeDEffect();
    ThreeDEffect threeDeffect5 = new ThreeDEffect();
    ShadowEffect shadowEffect5 = new ShadowEffect();
    PieChartAppearance pieChartAppearance2 = new PieChartAppearance();
    ChartTextAppearance chartTextAppearance = new ChartTextAppearance();
    Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormEntityAnalysis));
    Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook9 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook10 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook11 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
    ScrollBarLook scrollBarLook12 = new ScrollBarLook();
    Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("REFRESH");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("GLCOMPANY");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("DATERANGE");
    ButtonTool buttonTool2 = new ButtonTool("PRINT");
    ButtonTool buttonTool3 = new ButtonTool("REFRESH");
    Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("GLCOMPANY");
    Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("DATERANGE");
    Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
    ButtonTool buttonTool4 = new ButtonTool("PRINT");
    Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.vertSplitter = new Splitter();
    this.ultraGroupBox4 = new UltraGroupBox();
    this.chartBalanceBillingType = new Infragistics.Win.UltraWinChart.UltraChart();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.chartBalances = new Infragistics.Win.UltraWinChart.UltraChart();
    this.horSplitter = new Splitter();
    this.panel1 = new Panel();
    this.splitter1 = new Splitter();
    this.ultraGroupBox3 = new UltraGroupBox();
    this.chartAPEntityTypeBreakout = new Infragistics.Win.UltraWinChart.UltraChart();
    this.ultraGroupBox2 = new UltraGroupBox();
    this.chartAREntityTypeBreakout = new Infragistics.Win.UltraWinChart.UltraChart();
    this.ultraTabPageControl2 = new UltraTabPageControl();
    this.gridProducerList = new UltraGrid();
    this.mgaButton1 = new MGAButton();
    this.textLimitProducerList = new MGATextBox();
    this.label3 = new Label();
    this.panelProducerView = new Panel();
    this.labelProducerARAmount = new Label();
    this.labelProducerAPAmount = new Label();
    this.label2 = new Label();
    this.groupBox2 = new GroupBox();
    this.panelLoadingProducerPayments = new Panel();
    this.label12 = new Label();
    this.pictureBox3 = new PictureBox();
    this.gridProducerPayments = new UltraGrid();
    this.groupBox1 = new GroupBox();
    this.panelLoadingProducerPolicies = new Panel();
    this.label11 = new Label();
    this.pictureBox2 = new PictureBox();
    this.gridProducerPolicies = new UltraGrid();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.labelProducerName = new Label();
    this.label10 = new Label();
    this.ultraTabPageControl3 = new UltraTabPageControl();
    this.gridCarrierList = new UltraGrid();
    this.textLimitCarrierList = new MGATextBox();
    this.label19 = new Label();
    this.panelCarrierView = new Panel();
    this.labelCarrierARAmount = new Label();
    this.labelCarrierAPAmount = new Label();
    this.label7 = new Label();
    this.groupBox3 = new GroupBox();
    this.panelLoadingCarrierPayments = new Panel();
    this.label8 = new Label();
    this.pictureBox4 = new PictureBox();
    this.gridCarrierPayments = new UltraGrid();
    this.groupBox4 = new GroupBox();
    this.panelLoadingCarrierPolicies = new Panel();
    this.label9 = new Label();
    this.pictureBox5 = new PictureBox();
    this.gridCarrierPolicies = new UltraGrid();
    this.label15 = new Label();
    this.label16 = new Label();
    this.label17 = new Label();
    this.labelCarrierName = new Label();
    this.label13 = new Label();
    this.ultraTabPageControl4 = new UltraTabPageControl();
    this.panelInsuredView = new Panel();
    this.labelInsuredARAmount = new Label();
    this.labelInsuredAPAmount = new Label();
    this.label20 = new Label();
    this.groupBox5 = new GroupBox();
    this.panelLoadingInsuredPayments = new Panel();
    this.label21 = new Label();
    this.pictureBox6 = new PictureBox();
    this.gridInsuredPayments = new UltraGrid();
    this.groupBox6 = new GroupBox();
    this.panelLoadingInsuredPolicies = new Panel();
    this.label22 = new Label();
    this.pictureBox7 = new PictureBox();
    this.gridInsuredPolicies = new UltraGrid();
    this.label23 = new Label();
    this.label24 = new Label();
    this.label25 = new Label();
    this.labelInsuredName = new Label();
    this.gridInsuredList = new UltraGrid();
    this.textLimitInsuredList = new MGATextBox();
    this.label27 = new Label();
    this.label14 = new Label();
    this.ultraTabPageControl5 = new UltraTabPageControl();
    this.panelOtherView = new Panel();
    this.labelOtherARAmount = new Label();
    this.labelOtherAPAmount = new Label();
    this.label29 = new Label();
    this.groupBox7 = new GroupBox();
    this.panelLoadingOtherPayments = new Panel();
    this.label30 = new Label();
    this.pictureBox8 = new PictureBox();
    this.gridOtherPayments = new UltraGrid();
    this.groupBox8 = new GroupBox();
    this.panelLoadingOtherPolicies = new Panel();
    this.label31 = new Label();
    this.pictureBox9 = new PictureBox();
    this.gridOtherPolicies = new UltraGrid();
    this.label32 = new Label();
    this.label33 = new Label();
    this.label34 = new Label();
    this.label3rdPartyExpensePayeeName = new Label();
    this.gridOtherList = new UltraGrid();
    this.textLimitOtherList = new MGATextBox();
    this.label36 = new Label();
    this.label26 = new Label();
    this.analysisTabControl = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.pictureBox1 = new PictureBox();
    this.label1 = new Label();
    this.lblTakeAWhile = new Label();
    this.timer1 = new Timer(this.components);
    this.timer2 = new Timer(this.components);
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormEntityAnalysis_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormEntityAnalysis_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.comboGLCompany = new MGASimpleComboBox();
    this.panelDateRange = new UltraPanel();
    this.label18 = new Label();
    this.dateTimeTo = new MGADateTimePicker();
    this.dateTimeFrom = new MGADateTimePicker();
    this.toolTip1 = new ToolTip(this.components);
    this.checkUseDateRange = new CheckBox();
    ((Control) this.ultraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.ultraGroupBox4).BeginInit();
    ((Control) this.ultraGroupBox4).SuspendLayout();
    ((ISupportInitialize) this.chartBalanceBillingType).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.chartBalances).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.ultraGroupBox3).BeginInit();
    ((Control) this.ultraGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.chartAPEntityTypeBreakout).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox2).BeginInit();
    ((Control) this.ultraGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.chartAREntityTypeBreakout).BeginInit();
    ((Control) this.ultraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.gridProducerList).BeginInit();
    ((ISupportInitialize) this.mgaButton1).BeginInit();
    ((ISupportInitialize) this.textLimitProducerList).BeginInit();
    this.panelProducerView.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.panelLoadingProducerPayments.SuspendLayout();
    ((ISupportInitialize) this.pictureBox3).BeginInit();
    ((ISupportInitialize) this.gridProducerPayments).BeginInit();
    this.groupBox1.SuspendLayout();
    this.panelLoadingProducerPolicies.SuspendLayout();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    ((ISupportInitialize) this.gridProducerPolicies).BeginInit();
    ((Control) this.ultraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.gridCarrierList).BeginInit();
    ((ISupportInitialize) this.textLimitCarrierList).BeginInit();
    this.panelCarrierView.SuspendLayout();
    this.groupBox3.SuspendLayout();
    this.panelLoadingCarrierPayments.SuspendLayout();
    ((ISupportInitialize) this.pictureBox4).BeginInit();
    ((ISupportInitialize) this.gridCarrierPayments).BeginInit();
    this.groupBox4.SuspendLayout();
    this.panelLoadingCarrierPolicies.SuspendLayout();
    ((ISupportInitialize) this.pictureBox5).BeginInit();
    ((ISupportInitialize) this.gridCarrierPolicies).BeginInit();
    ((Control) this.ultraTabPageControl4).SuspendLayout();
    this.panelInsuredView.SuspendLayout();
    this.groupBox5.SuspendLayout();
    this.panelLoadingInsuredPayments.SuspendLayout();
    ((ISupportInitialize) this.pictureBox6).BeginInit();
    ((ISupportInitialize) this.gridInsuredPayments).BeginInit();
    this.groupBox6.SuspendLayout();
    this.panelLoadingInsuredPolicies.SuspendLayout();
    ((ISupportInitialize) this.pictureBox7).BeginInit();
    ((ISupportInitialize) this.gridInsuredPolicies).BeginInit();
    ((ISupportInitialize) this.gridInsuredList).BeginInit();
    ((ISupportInitialize) this.textLimitInsuredList).BeginInit();
    ((Control) this.ultraTabPageControl5).SuspendLayout();
    this.panelOtherView.SuspendLayout();
    this.groupBox7.SuspendLayout();
    this.panelLoadingOtherPayments.SuspendLayout();
    ((ISupportInitialize) this.pictureBox8).BeginInit();
    ((ISupportInitialize) this.gridOtherPayments).BeginInit();
    this.groupBox8.SuspendLayout();
    this.panelLoadingOtherPolicies.SuspendLayout();
    ((ISupportInitialize) this.pictureBox9).BeginInit();
    ((ISupportInitialize) this.gridOtherPolicies).BeginInit();
    ((ISupportInitialize) this.gridOtherList).BeginInit();
    ((ISupportInitialize) this.textLimitOtherList).BeginInit();
    ((ISupportInitialize) this.analysisTabControl).BeginInit();
    ((Control) this.analysisTabControl).SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.comboGLCompany).BeginInit();
    ((Control) this.panelDateRange.ClientArea).SuspendLayout();
    ((Control) this.panelDateRange).SuspendLayout();
    ((ISupportInitialize) this.dateTimeTo).BeginInit();
    ((ISupportInitialize) this.dateTimeFrom).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.vertSplitter);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.ultraGroupBox4);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.ultraGroupBox1);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.horSplitter);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.panel1);
    ((Control) this.ultraTabPageControl1).Location = new Point(1, 20);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(1078, 671);
    this.vertSplitter.BackColor = Color.LightSlateGray;
    this.vertSplitter.Location = new Point(516, 0);
    this.vertSplitter.Name = "vertSplitter";
    this.vertSplitter.Size = new Size(3, 375);
    this.vertSplitter.TabIndex = 3;
    this.vertSplitter.TabStop = false;
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    this.ultraGroupBox4.Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraGroupBox4).Controls.Add((Control) this.chartBalanceBillingType);
    ((Control) this.ultraGroupBox4).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance2).FontData.BoldAsString = "True";
    this.ultraGroupBox4.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.ultraGroupBox4).Location = new Point(516, 0);
    ((Control) this.ultraGroupBox4).Name = "ultraGroupBox4";
    ((Control) this.ultraGroupBox4).Size = new Size(562, 375);
    ((Control) this.ultraGroupBox4).TabIndex = 1;
    ((Control) this.ultraGroupBox4).Text = "Balances by Billing Type";
    chartLayerAppearance1.ChartType = (ChartType) 0;
    this.chartBalanceBillingType.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement1.ElementType = (PaintElementType) 0;
    paintElement1.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.chartBalanceBillingType.Axis.PE = paintElement1;
    this.chartBalanceBillingType.Axis.X.Extent = 50;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalanceBillingType.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels).Orientation = (TextOrientation) 1;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels).OrientationAngle = 45;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels.SeriesLabels).Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.chartBalanceBillingType.Axis.X.LineThickness = 1;
    this.chartBalanceBillingType.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalanceBillingType.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.X.MajorGridLines.Visible = true;
    this.chartBalanceBillingType.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.chartBalanceBillingType.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.X.MinorGridLines.Visible = false;
    this.chartBalanceBillingType.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalanceBillingType.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.chartBalanceBillingType.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.X2.Labels).Visible = false;
    this.chartBalanceBillingType.Axis.X2.LineThickness = 1;
    this.chartBalanceBillingType.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalanceBillingType.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.X2.MajorGridLines.Visible = true;
    this.chartBalanceBillingType.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.chartBalanceBillingType.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.X2.MinorGridLines.Visible = false;
    this.chartBalanceBillingType.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalanceBillingType.Axis.X2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels).Font = new Font("Tahoma", 10f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.chartBalanceBillingType.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:c>";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.chartBalanceBillingType.Axis.Y.LineThickness = 1;
    this.chartBalanceBillingType.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalanceBillingType.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Y.MajorGridLines.Visible = true;
    this.chartBalanceBillingType.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.chartBalanceBillingType.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Y.MinorGridLines.Visible = false;
    this.chartBalanceBillingType.Axis.Y.TickmarkInterval = 20.0;
    this.chartBalanceBillingType.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalanceBillingType.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalanceBillingType.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Y2.Labels).Visible = false;
    this.chartBalanceBillingType.Axis.Y2.LineThickness = 1;
    this.chartBalanceBillingType.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalanceBillingType.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Y2.MajorGridLines.Visible = true;
    this.chartBalanceBillingType.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.chartBalanceBillingType.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Y2.MinorGridLines.Visible = false;
    this.chartBalanceBillingType.Axis.Y2.TickmarkInterval = 20.0;
    this.chartBalanceBillingType.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalanceBillingType.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels).Font = new Font("Verdana", 10f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalanceBillingType.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.chartBalanceBillingType.Axis.Z.LineThickness = 1;
    this.chartBalanceBillingType.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalanceBillingType.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Z.MajorGridLines.Visible = true;
    this.chartBalanceBillingType.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.chartBalanceBillingType.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Z.MinorGridLines.Visible = false;
    this.chartBalanceBillingType.Axis.Z.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalanceBillingType.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalanceBillingType.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalanceBillingType.Axis.Z2.Labels).Visible = false;
    this.chartBalanceBillingType.Axis.Z2.LineThickness = 1;
    this.chartBalanceBillingType.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalanceBillingType.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Z2.MajorGridLines.Visible = true;
    this.chartBalanceBillingType.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalanceBillingType.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.chartBalanceBillingType.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalanceBillingType.Axis.Z2.MinorGridLines.Visible = false;
    this.chartBalanceBillingType.Axis.Z2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalanceBillingType.Axis.Z2.Visible = false;
    ((Control) this.chartBalanceBillingType).BackgroundImageLayout = ImageLayout.Center;
    this.chartBalanceBillingType.ColorModel.AlphaLevel = (byte) 150;
    this.chartBalanceBillingType.ColorModel.ColorBegin = Color.LavenderBlush;
    this.chartBalanceBillingType.ColorModel.ColorEnd = Color.MediumAquamarine;
    this.chartBalanceBillingType.ColorModel.ModelStyle = (ColorModels) 0;
    this.chartBalanceBillingType.ColorModel.Scaling = (ColorScaling) 4;
    chartLayerAppearance1.Key = "chartLayer1";
    this.chartBalanceBillingType.CompositeChart.ChartLayers.AddRange(new ChartLayerAppearance[1]
    {
      chartLayerAppearance1
    });
    this.chartBalanceBillingType.Data.SwapRowsAndColumns = true;
    this.chartBalanceBillingType.Data.ZeroAligned = true;
    ((Control) this.chartBalanceBillingType).Dock = DockStyle.Fill;
    textureEffect1.CustomImage = (Image) null;
    textureEffect1.CustomImagePath = (string) null;
    textureEffect1.Texture = (TexturePresets) 15;
    strokeEffect1.StrokeOpacity = byte.MaxValue;
    shadowEffect1.Angle = 45.0;
    this.chartBalanceBillingType.Effects.Effects.Add((IEffect) gradientEffect1);
    this.chartBalanceBillingType.Effects.Effects.Add((IEffect) textureEffect1);
    this.chartBalanceBillingType.Effects.Effects.Add((IEffect) strokeEffect1);
    this.chartBalanceBillingType.Effects.Effects.Add((IEffect) shadowEffect1);
    this.chartBalanceBillingType.Effects.Effects.Add((IEffect) threeDeffect1);
    this.chartBalanceBillingType.EmptyChartText = "Loading...";
    this.chartBalanceBillingType.Legend.BorderColor = Color.SlateGray;
    this.chartBalanceBillingType.Legend.Font = new Font("Tahoma", 20f);
    this.chartBalanceBillingType.Legend.FormatString = "";
    this.chartBalanceBillingType.Legend.Margins.Bottom = 0;
    this.chartBalanceBillingType.Legend.Margins.Left = 0;
    this.chartBalanceBillingType.Legend.Margins.Right = 0;
    this.chartBalanceBillingType.Legend.Margins.Top = 0;
    this.chartBalanceBillingType.Legend.SpanPercentage = 1;
    ((Control) this.chartBalanceBillingType).Location = new Point(3, 17);
    ((Control) this.chartBalanceBillingType).Name = "chartBalanceBillingType";
    ((Control) this.chartBalanceBillingType).Size = new Size(556, 355);
    this.chartBalanceBillingType.TabIndex = 0;
    this.chartBalanceBillingType.Tooltips.FormatString = "<DATA_VALUE:c>";
    this.chartBalanceBillingType.Tooltips.HighlightFillColor = Color.DimGray;
    this.chartBalanceBillingType.Tooltips.HighlightOutlineColor = Color.DarkGray;
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    this.ultraGroupBox1.Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.chartBalances);
    ((Control) this.ultraGroupBox1).Dock = DockStyle.Left;
    ((AppearanceBase) appearance4).FontData.BoldAsString = "True";
    this.ultraGroupBox1.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.ultraGroupBox1).Location = new Point(0, 0);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(516, 375);
    ((Control) this.ultraGroupBox1).TabIndex = 0;
    ((Control) this.ultraGroupBox1).Text = "Balances";
    this.chartBalances.ChartType = (ChartType) 1;
    this.chartBalances.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement2.ElementType = (PaintElementType) 0;
    paintElement2.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.chartBalances.Axis.PE = paintElement2;
    this.chartBalances.Axis.X.Extent = 5;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalances.Axis.X.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels).Orientation = (TextOrientation) 0;
    this.chartBalances.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.chartBalances.Axis.X.LineThickness = 1;
    this.chartBalances.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalances.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.X.MajorGridLines.Visible = true;
    this.chartBalances.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.chartBalances.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.X.MinorGridLines.Visible = false;
    this.chartBalances.Axis.X.TickmarkInterval = 50.0;
    this.chartBalances.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalances.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.chartBalances.Axis.X2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.chartBalances.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.X2.Labels).Visible = false;
    this.chartBalances.Axis.X2.LineThickness = 1;
    this.chartBalances.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalances.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.X2.MajorGridLines.Visible = true;
    this.chartBalances.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.chartBalances.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.X2.MinorGridLines.Visible = false;
    this.chartBalances.Axis.X2.TickmarkInterval = 50.0;
    this.chartBalances.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalances.Axis.X2.Visible = false;
    this.chartBalances.Axis.Y.Extent = 20;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels).Font = new Font("Tahoma", 10f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalances.Axis.Y.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.chartBalances.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.chartBalances.Axis.Y.LineThickness = 1;
    this.chartBalances.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalances.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Y.MajorGridLines.Visible = true;
    this.chartBalances.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.chartBalances.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Y.MinorGridLines.Visible = false;
    this.chartBalances.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalances.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalances.Axis.Y2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Y2.Labels).Visible = false;
    this.chartBalances.Axis.Y2.LineThickness = 1;
    this.chartBalances.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalances.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Y2.MajorGridLines.Visible = true;
    this.chartBalances.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.chartBalances.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Y2.MinorGridLines.Visible = false;
    this.chartBalances.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalances.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels).Font = new Font("Verdana", 10f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalances.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.chartBalances.Axis.Z.LineThickness = 1;
    this.chartBalances.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalances.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Z.MajorGridLines.Visible = true;
    this.chartBalances.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.chartBalances.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Z.MinorGridLines.Visible = false;
    this.chartBalances.Axis.Z.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalances.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartBalances.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartBalances.Axis.Z2.Labels).Visible = false;
    this.chartBalances.Axis.Z2.LineThickness = 1;
    this.chartBalances.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.chartBalances.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Z2.MajorGridLines.Visible = true;
    this.chartBalances.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartBalances.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.chartBalances.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartBalances.Axis.Z2.MinorGridLines.Visible = false;
    this.chartBalances.Axis.Z2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartBalances.Axis.Z2.Visible = false;
    ((Control) this.chartBalances).BackgroundImageLayout = ImageLayout.Center;
    barChartAppearance.SeriesSpacing = 0;
    this.chartBalances.BarChart = barChartAppearance;
    this.chartBalances.ColorModel.AlphaLevel = (byte) 50;
    this.chartBalances.ColorModel.ColorBegin = Color.LightSlateGray;
    this.chartBalances.ColorModel.ColorEnd = Color.Honeydew;
    this.chartBalances.ColorModel.Scaling = (ColorScaling) 4;
    chartLayerAppearance2.ChartType = (ChartType) 0;
    chartLayerAppearance2.Key = "chartLayer1";
    this.chartBalances.CompositeChart.ChartLayers.AddRange(new ChartLayerAppearance[1]
    {
      chartLayerAppearance2
    });
    this.chartBalances.Data.SwapRowsAndColumns = true;
    this.chartBalances.Data.ZeroAligned = true;
    ((Control) this.chartBalances).Dock = DockStyle.Fill;
    textureEffect2.CustomImage = (Image) null;
    textureEffect2.CustomImagePath = (string) null;
    textureEffect2.Texture = (TexturePresets) 15;
    strokeEffect2.StrokeOpacity = byte.MaxValue;
    shadowEffect2.Angle = 45.0;
    this.chartBalances.Effects.Effects.Add((IEffect) gradientEffect2);
    this.chartBalances.Effects.Effects.Add((IEffect) textureEffect2);
    this.chartBalances.Effects.Effects.Add((IEffect) strokeEffect2);
    this.chartBalances.Effects.Effects.Add((IEffect) shadowEffect2);
    this.chartBalances.Effects.Effects.Add((IEffect) threeDeffect2);
    this.chartBalances.EmptyChartText = "Loading...";
    this.chartBalances.Legend.BorderColor = Color.SlateGray;
    this.chartBalances.Legend.Font = new Font("Tahoma", 20f);
    this.chartBalances.Legend.FormatString = "";
    this.chartBalances.Legend.Margins.Bottom = 0;
    this.chartBalances.Legend.Margins.Left = 0;
    this.chartBalances.Legend.Margins.Right = 0;
    this.chartBalances.Legend.Margins.Top = 0;
    this.chartBalances.Legend.SpanPercentage = 1;
    ((Control) this.chartBalances).Location = new Point(3, 17);
    ((Control) this.chartBalances).Name = "chartBalances";
    ((Control) this.chartBalances).Size = new Size(510, 355);
    this.chartBalances.TabIndex = 0;
    this.chartBalances.Tooltips.FormatString = "<DATA_VALUE:c>";
    this.chartBalances.Tooltips.HighlightFillColor = Color.DimGray;
    this.chartBalances.Tooltips.HighlightOutlineColor = Color.DarkGray;
    this.horSplitter.BackColor = Color.LightSlateGray;
    this.horSplitter.Dock = DockStyle.Bottom;
    this.horSplitter.Location = new Point(0, 375);
    this.horSplitter.Name = "horSplitter";
    this.horSplitter.Size = new Size(1078, 3);
    this.horSplitter.TabIndex = 4;
    this.horSplitter.TabStop = false;
    this.panel1.Controls.Add((Control) this.splitter1);
    this.panel1.Controls.Add((Control) this.ultraGroupBox3);
    this.panel1.Controls.Add((Control) this.ultraGroupBox2);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 378);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1078, 293);
    this.panel1.TabIndex = 5;
    this.splitter1.BackColor = Color.LightSlateGray;
    this.splitter1.Location = new Point(516, 0);
    this.splitter1.Name = "splitter1";
    this.splitter1.Size = new Size(3, 293);
    this.splitter1.TabIndex = 4;
    this.splitter1.TabStop = false;
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    this.ultraGroupBox3.Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraGroupBox3).Controls.Add((Control) this.chartAPEntityTypeBreakout);
    ((Control) this.ultraGroupBox3).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance6).FontData.BoldAsString = "True";
    this.ultraGroupBox3.HeaderAppearance = (AppearanceBase) appearance6;
    ((Control) this.ultraGroupBox3).Location = new Point(516, 0);
    ((Control) this.ultraGroupBox3).Name = "ultraGroupBox3";
    ((Control) this.ultraGroupBox3).Size = new Size(562, 293);
    ((Control) this.ultraGroupBox3).TabIndex = 2;
    ((Control) this.ultraGroupBox3).Text = "Accounts Payable By Entity";
    this.chartAPEntityTypeBreakout.ChartType = (ChartType) 4;
    this.chartAPEntityTypeBreakout.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement3.ElementType = (PaintElementType) 0;
    paintElement3.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.chartAPEntityTypeBreakout.Axis.PE = paintElement3;
    this.chartAPEntityTypeBreakout.Axis.X.Extent = 20;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAPEntityTypeBreakout.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels).Orientation = (TextOrientation) 2;
    this.chartAPEntityTypeBreakout.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.chartAPEntityTypeBreakout.Axis.X.LineThickness = 1;
    this.chartAPEntityTypeBreakout.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.chartAPEntityTypeBreakout.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.X.MajorGridLines.Visible = true;
    this.chartAPEntityTypeBreakout.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.chartAPEntityTypeBreakout.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.X.MinorGridLines.Visible = false;
    this.chartAPEntityTypeBreakout.Axis.X.TickmarkInterval = 50.0;
    this.chartAPEntityTypeBreakout.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAPEntityTypeBreakout.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAPEntityTypeBreakout.Axis.X2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.X2.Labels).Visible = false;
    this.chartAPEntityTypeBreakout.Axis.X2.LineThickness = 1;
    this.chartAPEntityTypeBreakout.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.chartAPEntityTypeBreakout.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.X2.MajorGridLines.Visible = true;
    this.chartAPEntityTypeBreakout.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.chartAPEntityTypeBreakout.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.X2.MinorGridLines.Visible = false;
    this.chartAPEntityTypeBreakout.Axis.X2.TickmarkInterval = 50.0;
    this.chartAPEntityTypeBreakout.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAPEntityTypeBreakout.Axis.X2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels).Font = new Font("Tahoma", 10f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAPEntityTypeBreakout.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.chartAPEntityTypeBreakout.Axis.Y.LineThickness = 1;
    this.chartAPEntityTypeBreakout.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.chartAPEntityTypeBreakout.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Y.MajorGridLines.Visible = true;
    this.chartAPEntityTypeBreakout.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.chartAPEntityTypeBreakout.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Y.MinorGridLines.Visible = false;
    this.chartAPEntityTypeBreakout.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAPEntityTypeBreakout.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAPEntityTypeBreakout.Axis.Y2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Y2.Labels).Visible = false;
    this.chartAPEntityTypeBreakout.Axis.Y2.LineThickness = 1;
    this.chartAPEntityTypeBreakout.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.chartAPEntityTypeBreakout.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Y2.MajorGridLines.Visible = true;
    this.chartAPEntityTypeBreakout.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.chartAPEntityTypeBreakout.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Y2.MinorGridLines.Visible = false;
    this.chartAPEntityTypeBreakout.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAPEntityTypeBreakout.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels).Font = new Font("Verdana", 10f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAPEntityTypeBreakout.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.chartAPEntityTypeBreakout.Axis.Z.LineThickness = 1;
    this.chartAPEntityTypeBreakout.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.chartAPEntityTypeBreakout.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Z.MajorGridLines.Visible = true;
    this.chartAPEntityTypeBreakout.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.chartAPEntityTypeBreakout.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Z.MinorGridLines.Visible = false;
    this.chartAPEntityTypeBreakout.Axis.Z.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAPEntityTypeBreakout.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAPEntityTypeBreakout.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAPEntityTypeBreakout.Axis.Z2.Labels).Visible = false;
    this.chartAPEntityTypeBreakout.Axis.Z2.LineThickness = 1;
    this.chartAPEntityTypeBreakout.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.chartAPEntityTypeBreakout.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Z2.MajorGridLines.Visible = true;
    this.chartAPEntityTypeBreakout.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAPEntityTypeBreakout.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.chartAPEntityTypeBreakout.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAPEntityTypeBreakout.Axis.Z2.MinorGridLines.Visible = false;
    this.chartAPEntityTypeBreakout.Axis.Z2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAPEntityTypeBreakout.Axis.Z2.Visible = false;
    ((Control) this.chartAPEntityTypeBreakout).BackgroundImageLayout = ImageLayout.Center;
    this.chartAPEntityTypeBreakout.ColorModel.AlphaLevel = (byte) 150;
    this.chartAPEntityTypeBreakout.ColorModel.ColorBegin = Color.SteelBlue;
    this.chartAPEntityTypeBreakout.ColorModel.ColorEnd = Color.Azure;
    this.chartAPEntityTypeBreakout.ColorModel.ModelStyle = (ColorModels) 0;
    this.chartAPEntityTypeBreakout.ColorModel.Scaling = (ColorScaling) 4;
    chartLayerAppearance3.ChartType = (ChartType) 0;
    chartLayerAppearance3.Key = "chartLayer1";
    this.chartAPEntityTypeBreakout.CompositeChart.ChartLayers.AddRange(new ChartLayerAppearance[1]
    {
      chartLayerAppearance3
    });
    this.chartAPEntityTypeBreakout.Data.SwapRowsAndColumns = true;
    this.chartAPEntityTypeBreakout.Data.ZeroAligned = true;
    ((Control) this.chartAPEntityTypeBreakout).Dock = DockStyle.Fill;
    textureEffect3.CustomImage = (Image) null;
    textureEffect3.CustomImagePath = (string) null;
    textureEffect3.Texture = (TexturePresets) 15;
    strokeEffect3.StrokeOpacity = byte.MaxValue;
    shadowEffect3.Angle = 45.0;
    this.chartAPEntityTypeBreakout.Effects.Effects.Add((IEffect) gradientEffect3);
    this.chartAPEntityTypeBreakout.Effects.Effects.Add((IEffect) textureEffect3);
    this.chartAPEntityTypeBreakout.Effects.Effects.Add((IEffect) strokeEffect3);
    this.chartAPEntityTypeBreakout.Effects.Effects.Add((IEffect) shadowEffect3);
    this.chartAPEntityTypeBreakout.Effects.Effects.Add((IEffect) threeDeffect3);
    this.chartAPEntityTypeBreakout.EmptyChartText = "Loading...";
    this.chartAPEntityTypeBreakout.Legend.AlphaLevel = (byte) 0;
    this.chartAPEntityTypeBreakout.Legend.BorderColor = Color.SlateGray;
    this.chartAPEntityTypeBreakout.Legend.BorderThickness = 0;
    this.chartAPEntityTypeBreakout.Legend.Font = new Font("Tahoma", 10f);
    this.chartAPEntityTypeBreakout.Legend.FormatString = "<ITEM_LABEL> <DATA_VALUE:c>";
    this.chartAPEntityTypeBreakout.Legend.Location = (LegendLocation) 3;
    this.chartAPEntityTypeBreakout.Legend.Margins.Bottom = 0;
    this.chartAPEntityTypeBreakout.Legend.Margins.Left = 0;
    this.chartAPEntityTypeBreakout.Legend.Margins.Right = 0;
    this.chartAPEntityTypeBreakout.Legend.Margins.Top = 0;
    this.chartAPEntityTypeBreakout.Legend.Visible = true;
    ((Control) this.chartAPEntityTypeBreakout).Location = new Point(3, 17);
    ((Control) this.chartAPEntityTypeBreakout).Name = "chartAPEntityTypeBreakout";
    pieChartAppearance1.BreakAllSlices = true;
    pieChartAppearance1.BreakDistancePercentage = 2;
    this.chartAPEntityTypeBreakout.PieChart = pieChartAppearance1;
    ((Control) this.chartAPEntityTypeBreakout).Size = new Size(556, 273);
    this.chartAPEntityTypeBreakout.TabIndex = 1;
    this.chartAPEntityTypeBreakout.Tooltips.Display = (TooltipDisplay) 0;
    this.chartAPEntityTypeBreakout.Tooltips.HighlightFillColor = Color.DimGray;
    this.chartAPEntityTypeBreakout.Tooltips.HighlightOutlineColor = Color.DarkGray;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    this.ultraGroupBox2.Appearance = (AppearanceBase) appearance7;
    ((Control) this.ultraGroupBox2).Controls.Add((Control) this.chartAREntityTypeBreakout);
    ((Control) this.ultraGroupBox2).Dock = DockStyle.Left;
    ((AppearanceBase) appearance8).FontData.BoldAsString = "True";
    this.ultraGroupBox2.HeaderAppearance = (AppearanceBase) appearance8;
    ((Control) this.ultraGroupBox2).Location = new Point(0, 0);
    ((Control) this.ultraGroupBox2).Name = "ultraGroupBox2";
    ((Control) this.ultraGroupBox2).Size = new Size(516, 293);
    ((Control) this.ultraGroupBox2).TabIndex = 1;
    ((Control) this.ultraGroupBox2).Text = "Accounts Receivable By Entity";
    this.chartAREntityTypeBreakout.ChartType = (ChartType) 4;
    this.chartAREntityTypeBreakout.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    paintElement4.ElementType = (PaintElementType) 0;
    paintElement4.Fill = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.chartAREntityTypeBreakout.Axis.PE = paintElement4;
    this.chartAREntityTypeBreakout.Axis.X.Extent = 20;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAREntityTypeBreakout.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels).Orientation = (TextOrientation) 2;
    this.chartAREntityTypeBreakout.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.chartAREntityTypeBreakout.Axis.X.LineThickness = 1;
    this.chartAREntityTypeBreakout.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.chartAREntityTypeBreakout.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.X.MajorGridLines.Visible = true;
    this.chartAREntityTypeBreakout.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.chartAREntityTypeBreakout.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.X.MinorGridLines.Visible = false;
    this.chartAREntityTypeBreakout.Axis.X.TickmarkInterval = 50.0;
    this.chartAREntityTypeBreakout.Axis.X.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAREntityTypeBreakout.Axis.X.Visible = true;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAREntityTypeBreakout.Axis.X2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.X2.Labels).Visible = false;
    this.chartAREntityTypeBreakout.Axis.X2.LineThickness = 1;
    this.chartAREntityTypeBreakout.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.chartAREntityTypeBreakout.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.X2.MajorGridLines.Visible = true;
    this.chartAREntityTypeBreakout.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.chartAREntityTypeBreakout.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.X2.MinorGridLines.Visible = false;
    this.chartAREntityTypeBreakout.Axis.X2.TickmarkInterval = 50.0;
    this.chartAREntityTypeBreakout.Axis.X2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAREntityTypeBreakout.Axis.X2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels).Font = new Font("Tahoma", 10f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAREntityTypeBreakout.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels).FontColor = Color.DimGray;
    this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.chartAREntityTypeBreakout.Axis.Y.LineThickness = 1;
    this.chartAREntityTypeBreakout.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.chartAREntityTypeBreakout.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Y.MajorGridLines.Visible = true;
    this.chartAREntityTypeBreakout.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.chartAREntityTypeBreakout.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Y.MinorGridLines.Visible = false;
    this.chartAREntityTypeBreakout.Axis.Y.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAREntityTypeBreakout.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAREntityTypeBreakout.Axis.Y2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).FontColor = Color.Gray;
    this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Y2.Labels).Visible = false;
    this.chartAREntityTypeBreakout.Axis.Y2.LineThickness = 1;
    this.chartAREntityTypeBreakout.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.chartAREntityTypeBreakout.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Y2.MajorGridLines.Visible = true;
    this.chartAREntityTypeBreakout.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.chartAREntityTypeBreakout.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Y2.MinorGridLines.Visible = false;
    this.chartAREntityTypeBreakout.Axis.Y2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAREntityTypeBreakout.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels).Font = new Font("Verdana", 10f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAREntityTypeBreakout.Axis.Z.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels.SeriesLabels).FontColor = Color.DimGray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.chartAREntityTypeBreakout.Axis.Z.LineThickness = 1;
    this.chartAREntityTypeBreakout.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.chartAREntityTypeBreakout.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Z.MajorGridLines.Visible = true;
    this.chartAREntityTypeBreakout.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.chartAREntityTypeBreakout.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Z.MinorGridLines.Visible = false;
    this.chartAREntityTypeBreakout.Axis.Z.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAREntityTypeBreakout.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.chartAREntityTypeBreakout.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).Font = new Font("Verdana", 7f);
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).FontColor = Color.Gray;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).Layout.Behavior = (AxisLabelLayoutBehaviors) 0;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.chartAREntityTypeBreakout.Axis.Z2.Labels).Visible = false;
    this.chartAREntityTypeBreakout.Axis.Z2.LineThickness = 1;
    this.chartAREntityTypeBreakout.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.chartAREntityTypeBreakout.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Z2.MajorGridLines.Visible = true;
    this.chartAREntityTypeBreakout.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.chartAREntityTypeBreakout.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.chartAREntityTypeBreakout.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.chartAREntityTypeBreakout.Axis.Z2.MinorGridLines.Visible = false;
    this.chartAREntityTypeBreakout.Axis.Z2.TickmarkStyle = (AxisTickStyle) 2;
    this.chartAREntityTypeBreakout.Axis.Z2.Visible = false;
    ((Control) this.chartAREntityTypeBreakout).BackgroundImageLayout = ImageLayout.Center;
    this.chartAREntityTypeBreakout.ColorModel.AlphaLevel = (byte) 150;
    this.chartAREntityTypeBreakout.ColorModel.ColorBegin = Color.DarkSeaGreen;
    this.chartAREntityTypeBreakout.ColorModel.ColorEnd = Color.Azure;
    this.chartAREntityTypeBreakout.ColorModel.ModelStyle = (ColorModels) 0;
    this.chartAREntityTypeBreakout.ColorModel.Scaling = (ColorScaling) 4;
    chartLayerAppearance4.ChartType = (ChartType) 0;
    chartLayerAppearance4.Key = "chartLayer1";
    this.chartAREntityTypeBreakout.CompositeChart.ChartLayers.AddRange(new ChartLayerAppearance[1]
    {
      chartLayerAppearance4
    });
    this.chartAREntityTypeBreakout.Data.SwapRowsAndColumns = true;
    this.chartAREntityTypeBreakout.Data.UseRowLabelsColumn = true;
    this.chartAREntityTypeBreakout.Data.ZeroAligned = true;
    ((Control) this.chartAREntityTypeBreakout).Dock = DockStyle.Fill;
    textureEffect4.CustomImage = (Image) null;
    textureEffect4.CustomImagePath = (string) null;
    textureEffect4.Texture = (TexturePresets) 15;
    strokeEffect4.StrokeOpacity = byte.MaxValue;
    shadowEffect4.Angle = 35.0;
    shadowEffect4.Depth = 10;
    shadowEffect5.Angle = 45.0;
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) gradientEffect4);
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) textureEffect4);
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) strokeEffect4);
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) shadowEffect4);
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) threeDeffect4);
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) threeDeffect5);
    this.chartAREntityTypeBreakout.Effects.Effects.Add((IEffect) shadowEffect5);
    this.chartAREntityTypeBreakout.EmptyChartText = "Loading...";
    this.chartAREntityTypeBreakout.Legend.AlphaLevel = (byte) 0;
    this.chartAREntityTypeBreakout.Legend.BackgroundColor = Color.LightSteelBlue;
    this.chartAREntityTypeBreakout.Legend.BorderColor = Color.SlateGray;
    this.chartAREntityTypeBreakout.Legend.BorderThickness = 0;
    this.chartAREntityTypeBreakout.Legend.Font = new Font("Tahoma", 10f);
    this.chartAREntityTypeBreakout.Legend.FormatString = "<ITEM_LABEL> <DATA_VALUE:c>";
    this.chartAREntityTypeBreakout.Legend.Location = (LegendLocation) 3;
    this.chartAREntityTypeBreakout.Legend.Margins.Bottom = 0;
    this.chartAREntityTypeBreakout.Legend.Margins.Left = 0;
    this.chartAREntityTypeBreakout.Legend.Margins.Right = 0;
    this.chartAREntityTypeBreakout.Legend.Margins.Top = 0;
    this.chartAREntityTypeBreakout.Legend.Visible = true;
    ((Control) this.chartAREntityTypeBreakout).Location = new Point(3, 17);
    ((Control) this.chartAREntityTypeBreakout).Name = "chartAREntityTypeBreakout";
    pieChartAppearance2.BreakAllSlices = true;
    pieChartAppearance2.BreakDistancePercentage = 2;
    chartTextAppearance.ChartTextFont = new Font("Tahoma", 9f);
    chartTextAppearance.ClipText = false;
    chartTextAppearance.Column = 0;
    chartTextAppearance.Row = 0;
    pieChartAppearance2.ChartText.Add(chartTextAppearance);
    this.chartAREntityTypeBreakout.PieChart = pieChartAppearance2;
    ((Control) this.chartAREntityTypeBreakout).Size = new Size(510, 273);
    this.chartAREntityTypeBreakout.TabIndex = 1;
    this.chartAREntityTypeBreakout.Tooltips.Display = (TooltipDisplay) 0;
    this.chartAREntityTypeBreakout.Tooltips.HighlightFillColor = Color.DimGray;
    this.chartAREntityTypeBreakout.Tooltips.HighlightOutlineColor = Color.DarkGray;
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.gridProducerList);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.mgaButton1);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.textLimitProducerList);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.label3);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.panelProducerView);
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.label10);
    ((Control) this.ultraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl2).Name = "ultraTabPageControl2";
    ((Control) this.ultraTabPageControl2).Size = new Size(1078, 682);
    ((Control) this.gridProducerList).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.Transparent;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance16).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.gridProducerList).DisplayLayout.SelectionOverlayColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    ((Control) this.gridProducerList).Location = new Point(15, 29);
    ((Control) this.gridProducerList).Name = "gridProducerList";
    ((Control) this.gridProducerList).Size = new Size(334, 642);
    ((Control) this.gridProducerList).TabIndex = 3;
    this.gridProducerList.ClickCell += new ClickCellEventHandler(this.gridProducerList_ClickCell);
    this.gridProducerList.DoubleClickRow += new DoubleClickRowEventHandler(this.gridProducerList_DoubleClickRow);
    ((AppearanceBase) appearance18).BackColor = Color.Transparent;
    ((AppearanceBase) appearance18).BackColor2 = Color.Transparent;
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance18).Image = componentResourceManager.GetObject("appearance18.Image");
    ((AppearanceBase) appearance18).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance18).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.mgaButton1).Appearance = (AppearanceBase) appearance18;
    this.mgaButton1.ButtonStyle = (UIElementButtonStyle) 4;
    ((Control) this.mgaButton1).Location = new Point(329, 4);
    ((Control) this.mgaButton1).Name = "mgaButton1";
    ((Control) this.mgaButton1).Size = new Size(18, 18);
    ((Control) this.mgaButton1).TabIndex = 2;
    ((UltraControlBase) this.mgaButton1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaButton1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaButton1).Visible = false;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.Gray;
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLimitProducerList).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textLimitProducerList).BackColor = Color.White;
    ((Control) this.textLimitProducerList).Location = new Point(126, 4);
    ((Control) this.textLimitProducerList).Name = "textLimitProducerList";
    ((Control) this.textLimitProducerList).Size = new Size(222, 20);
    ((Control) this.textLimitProducerList).TabIndex = 1;
    ((UltraControlBase) this.textLimitProducerList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLimitProducerList).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.textLimitProducerList).ValueChanged += new EventHandler(this.textLimitProducerList_ValueChanged);
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label3.Location = new Point(11, 5);
    this.label3.Name = "label3";
    this.label3.Size = new Size(75, 13);
    this.label3.TabIndex = 0;
    this.label3.Text = "Entity Name";
    this.panelProducerView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelProducerView.BackColor = Color.GhostWhite;
    this.panelProducerView.Controls.Add((Control) this.labelProducerARAmount);
    this.panelProducerView.Controls.Add((Control) this.labelProducerAPAmount);
    this.panelProducerView.Controls.Add((Control) this.label2);
    this.panelProducerView.Controls.Add((Control) this.groupBox2);
    this.panelProducerView.Controls.Add((Control) this.groupBox1);
    this.panelProducerView.Controls.Add((Control) this.label6);
    this.panelProducerView.Controls.Add((Control) this.label5);
    this.panelProducerView.Controls.Add((Control) this.label4);
    this.panelProducerView.Controls.Add((Control) this.labelProducerName);
    this.panelProducerView.Location = new Point(355, 3);
    this.panelProducerView.Name = "panelProducerView";
    this.panelProducerView.Size = new Size(714, 677);
    this.panelProducerView.TabIndex = 4;
    this.panelProducerView.Visible = false;
    this.labelProducerARAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelProducerARAmount.Font = new Font("Tahoma", 9f);
    this.labelProducerARAmount.Location = new Point(600, 31 /*0x1F*/);
    this.labelProducerARAmount.Name = "labelProducerARAmount";
    this.labelProducerARAmount.Size = new Size(102, 14);
    this.labelProducerARAmount.TabIndex = 6;
    this.labelProducerARAmount.Text = "$0.00";
    this.labelProducerARAmount.TextAlign = ContentAlignment.MiddleRight;
    this.labelProducerAPAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelProducerAPAmount.Font = new Font("Tahoma", 9f);
    this.labelProducerAPAmount.Location = new Point(597, 54);
    this.labelProducerAPAmount.Name = "labelProducerAPAmount";
    this.labelProducerAPAmount.Size = new Size(105, 14);
    this.labelProducerAPAmount.TabIndex = 5;
    this.labelProducerAPAmount.Text = "$100,000,000.00";
    this.labelProducerAPAmount.TextAlign = ContentAlignment.MiddleRight;
    this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label2.Font = new Font("Tahoma", 9f);
    this.label2.Location = new Point(78, 54);
    this.label2.Name = "label2";
    this.label2.Size = new Size(566, 14);
    this.label2.TabIndex = 4;
    this.label2.Text = componentResourceManager.GetString("label2.Text");
    this.groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox2.Controls.Add((Control) this.panelLoadingProducerPayments);
    this.groupBox2.Controls.Add((Control) this.gridProducerPayments);
    this.groupBox2.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox2.Location = new Point(13, 356);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(689, 312);
    this.groupBox2.TabIndex = 8;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Payment/Receipt Information";
    this.panelLoadingProducerPayments.Controls.Add((Control) this.label12);
    this.panelLoadingProducerPayments.Controls.Add((Control) this.pictureBox3);
    this.panelLoadingProducerPayments.Dock = DockStyle.Fill;
    this.panelLoadingProducerPayments.Location = new Point(3, 18);
    this.panelLoadingProducerPayments.Name = "panelLoadingProducerPayments";
    this.panelLoadingProducerPayments.Size = new Size(683, 291);
    this.panelLoadingProducerPayments.TabIndex = 1;
    this.label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label12.Font = new Font("Tahoma", 9f);
    this.label12.Location = new Point(3, 253);
    this.label12.Name = "label12";
    this.label12.Size = new Size(680, 33);
    this.label12.TabIndex = 1;
    this.label12.Text = "Loading payment/receipt information...please be patient!";
    this.label12.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox3.BackColor = Color.White;
    this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
    this.pictureBox3.Location = new Point(0, 0);
    this.pictureBox3.Name = "pictureBox3";
    this.pictureBox3.Size = new Size(683, 211);
    this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox3.TabIndex = 0;
    this.pictureBox3.TabStop = false;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Appearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.Transparent;
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance27).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance27).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.gridProducerPayments).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridProducerPayments).Dock = DockStyle.Fill;
    ((Control) this.gridProducerPayments).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridProducerPayments).Location = new Point(3, 18);
    ((Control) this.gridProducerPayments).Name = "gridProducerPayments";
    ((Control) this.gridProducerPayments).Size = new Size(683, 291);
    ((Control) this.gridProducerPayments).TabIndex = 2;
    ((UltraControlBase) this.gridProducerPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridProducerPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridProducerPayments).Visible = false;
    this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox1.Controls.Add((Control) this.panelLoadingProducerPolicies);
    this.groupBox1.Controls.Add((Control) this.gridProducerPolicies);
    this.groupBox1.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox1.Location = new Point(13, 87);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(689, 263);
    this.groupBox1.TabIndex = 7;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Policy Information";
    this.panelLoadingProducerPolicies.Controls.Add((Control) this.label11);
    this.panelLoadingProducerPolicies.Controls.Add((Control) this.pictureBox2);
    this.panelLoadingProducerPolicies.Dock = DockStyle.Fill;
    this.panelLoadingProducerPolicies.Location = new Point(3, 18);
    this.panelLoadingProducerPolicies.Name = "panelLoadingProducerPolicies";
    this.panelLoadingProducerPolicies.Size = new Size(683, 242);
    this.panelLoadingProducerPolicies.TabIndex = 0;
    this.label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label11.Font = new Font("Tahoma", 9f);
    this.label11.Location = new Point(3, 204);
    this.label11.Name = "label11";
    this.label11.Size = new Size(680, 33);
    this.label11.TabIndex = 1;
    this.label11.Text = "Loading policy information...please be patient!";
    this.label11.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox2.BackColor = Color.White;
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(0, 0);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(683, 178);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox2.TabIndex = 0;
    this.pictureBox2.TabStop = false;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Appearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance30).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance31).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance32).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance33).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance35).BackColor = Color.Transparent;
    ((AppearanceBase) appearance35).ForeColor = Color.Black;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance36).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.gridProducerPolicies).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridProducerPolicies).Dock = DockStyle.Fill;
    ((Control) this.gridProducerPolicies).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridProducerPolicies).Location = new Point(3, 18);
    ((Control) this.gridProducerPolicies).Name = "gridProducerPolicies";
    ((Control) this.gridProducerPolicies).Size = new Size(683, 242);
    ((Control) this.gridProducerPolicies).TabIndex = 1;
    ((UltraControlBase) this.gridProducerPolicies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridProducerPolicies).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridProducerPolicies).Visible = false;
    this.label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label6.Font = new Font("Tahoma", 9f);
    this.label6.Location = new Point(78, 31 /*0x1F*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(566, 14);
    this.label6.TabIndex = 3;
    this.label6.Text = componentResourceManager.GetString("label6.Text");
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Tahoma", 9f);
    this.label5.Location = new Point(10, 31 /*0x1F*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(54, 14);
    this.label5.TabIndex = 2;
    this.label5.Text = "AR Total";
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 9f);
    this.label4.Location = new Point(10, 54);
    this.label4.Name = "label4";
    this.label4.Size = new Size(54, 14);
    this.label4.TabIndex = 1;
    this.label4.Text = "AP Total";
    this.labelProducerName.AutoSize = true;
    this.labelProducerName.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelProducerName.Location = new Point(10, 10);
    this.labelProducerName.Name = "labelProducerName";
    this.labelProducerName.Size = new Size(109, 14);
    this.labelProducerName.TabIndex = 0;
    this.labelProducerName.Text = "[Producer Name]";
    this.labelProducerName.UseMnemonic = false;
    this.label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label10.BackColor = Color.Transparent;
    this.label10.Font = new Font("Tahoma", 10f);
    this.label10.Location = new Point(359, 342);
    this.label10.Name = "label10";
    this.label10.Size = new Size(704, 23);
    this.label10.TabIndex = 5;
    this.label10.Text = "Double-click a broker/producer to view the entity detail.";
    this.label10.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.gridCarrierList);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.textLimitCarrierList);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.label19);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.panelCarrierView);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.label13);
    ((Control) this.ultraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl3).Name = "ultraTabPageControl3";
    ((Control) this.ultraTabPageControl3).Size = new Size(1078, 682);
    ((Control) this.gridCarrierList).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance38).BackColor = Color.Transparent;
    ((AppearanceBase) appearance38).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Appearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance40).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance42).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BackColor = Color.Transparent;
    ((AppearanceBase) appearance43).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance44).BackColor = Color.Transparent;
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance45).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((UltraGridBase) this.gridCarrierList).DisplayLayout.SelectionOverlayColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    ((Control) this.gridCarrierList).Location = new Point(14, 33);
    ((Control) this.gridCarrierList).Name = "gridCarrierList";
    ((Control) this.gridCarrierList).Size = new Size(334, 642);
    ((Control) this.gridCarrierList).TabIndex = 7;
    this.gridCarrierList.DoubleClickRow += new DoubleClickRowEventHandler(this.gridCarrierList_DoubleClickRow);
    ((AppearanceBase) appearance47).BackColor = Color.White;
    ((AppearanceBase) appearance47).BorderColor = Color.Gray;
    ((AppearanceBase) appearance47).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLimitCarrierList).Appearance = (AppearanceBase) appearance47;
    ((Control) this.textLimitCarrierList).BackColor = Color.White;
    ((Control) this.textLimitCarrierList).Location = new Point(126, 4);
    ((Control) this.textLimitCarrierList).Name = "textLimitCarrierList";
    ((Control) this.textLimitCarrierList).Size = new Size(222, 20);
    ((Control) this.textLimitCarrierList).TabIndex = 6;
    ((UltraControlBase) this.textLimitCarrierList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLimitCarrierList).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.textLimitCarrierList).ValueChanged += new EventHandler(this.textLimitCarrierList_ValueChanged);
    this.label19.AutoSize = true;
    this.label19.BackColor = Color.Transparent;
    this.label19.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label19.Location = new Point(11, 5);
    this.label19.Name = "label19";
    this.label19.Size = new Size(75, 13);
    this.label19.TabIndex = 5;
    this.label19.Text = "Entity Name";
    this.panelCarrierView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelCarrierView.BackColor = Color.GhostWhite;
    this.panelCarrierView.Controls.Add((Control) this.labelCarrierARAmount);
    this.panelCarrierView.Controls.Add((Control) this.labelCarrierAPAmount);
    this.panelCarrierView.Controls.Add((Control) this.label7);
    this.panelCarrierView.Controls.Add((Control) this.groupBox3);
    this.panelCarrierView.Controls.Add((Control) this.groupBox4);
    this.panelCarrierView.Controls.Add((Control) this.label15);
    this.panelCarrierView.Controls.Add((Control) this.label16);
    this.panelCarrierView.Controls.Add((Control) this.label17);
    this.panelCarrierView.Controls.Add((Control) this.labelCarrierName);
    this.panelCarrierView.Location = new Point(354, 3);
    this.panelCarrierView.Name = "panelCarrierView";
    this.panelCarrierView.Size = new Size(714, 676);
    this.panelCarrierView.TabIndex = 8;
    this.panelCarrierView.Visible = false;
    this.labelCarrierARAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelCarrierARAmount.Font = new Font("Tahoma", 9f);
    this.labelCarrierARAmount.Location = new Point(614, 30);
    this.labelCarrierARAmount.Name = "labelCarrierARAmount";
    this.labelCarrierARAmount.Size = new Size(96 /*0x60*/, 15);
    this.labelCarrierARAmount.TabIndex = 6;
    this.labelCarrierARAmount.Text = "$0.00";
    this.labelCarrierARAmount.TextAlign = ContentAlignment.MiddleRight;
    this.labelCarrierAPAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelCarrierAPAmount.Font = new Font("Tahoma", 9f);
    this.labelCarrierAPAmount.Location = new Point(614, 54);
    this.labelCarrierAPAmount.Name = "labelCarrierAPAmount";
    this.labelCarrierAPAmount.Size = new Size(97, 14);
    this.labelCarrierAPAmount.TabIndex = 5;
    this.labelCarrierAPAmount.Text = "$10,100,000.00";
    this.labelCarrierAPAmount.TextAlign = ContentAlignment.MiddleRight;
    this.label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label7.Font = new Font("Tahoma", 9f);
    this.label7.Location = new Point(78, 54);
    this.label7.Name = "label7";
    this.label7.Size = new Size(566, 14);
    this.label7.TabIndex = 4;
    this.label7.Text = componentResourceManager.GetString("label7.Text");
    this.groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox3.Controls.Add((Control) this.panelLoadingCarrierPayments);
    this.groupBox3.Controls.Add((Control) this.gridCarrierPayments);
    this.groupBox3.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox3.Location = new Point(13, 355);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new Size(694, 313);
    this.groupBox3.TabIndex = 8;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Payment/Receipt Information";
    this.panelLoadingCarrierPayments.Controls.Add((Control) this.label8);
    this.panelLoadingCarrierPayments.Controls.Add((Control) this.pictureBox4);
    this.panelLoadingCarrierPayments.Dock = DockStyle.Fill;
    this.panelLoadingCarrierPayments.Location = new Point(3, 18);
    this.panelLoadingCarrierPayments.Name = "panelLoadingCarrierPayments";
    this.panelLoadingCarrierPayments.Size = new Size(688, 292);
    this.panelLoadingCarrierPayments.TabIndex = 1;
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label8.Font = new Font("Tahoma", 9f);
    this.label8.Location = new Point(3, 254);
    this.label8.Name = "label8";
    this.label8.Size = new Size(685, 33);
    this.label8.TabIndex = 1;
    this.label8.Text = "Loading payment/receipt information...please be patient!";
    this.label8.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox4.BackColor = Color.White;
    this.pictureBox4.Image = (Image) componentResourceManager.GetObject("pictureBox4.Image");
    this.pictureBox4.Location = new Point(0, 0);
    this.pictureBox4.Name = "pictureBox4";
    this.pictureBox4.Size = new Size(688, 212);
    this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox4.TabIndex = 0;
    this.pictureBox4.TabStop = false;
    ((AppearanceBase) appearance48).BackColor = Color.White;
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Appearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance49).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance49).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance50).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance51).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance54).BackColor = Color.Transparent;
    ((AppearanceBase) appearance54).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance55).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance55).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.gridCarrierPayments).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((Control) this.gridCarrierPayments).Dock = DockStyle.Fill;
    ((Control) this.gridCarrierPayments).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridCarrierPayments).Location = new Point(3, 18);
    ((Control) this.gridCarrierPayments).Name = "gridCarrierPayments";
    ((Control) this.gridCarrierPayments).Size = new Size(688, 292);
    ((Control) this.gridCarrierPayments).TabIndex = 2;
    ((UltraControlBase) this.gridCarrierPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCarrierPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridCarrierPayments).Visible = false;
    this.groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox4.Controls.Add((Control) this.panelLoadingCarrierPolicies);
    this.groupBox4.Controls.Add((Control) this.gridCarrierPolicies);
    this.groupBox4.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox4.Location = new Point(13, 87);
    this.groupBox4.Name = "groupBox4";
    this.groupBox4.Size = new Size(694, 262);
    this.groupBox4.TabIndex = 7;
    this.groupBox4.TabStop = false;
    this.groupBox4.Text = "Policy Information";
    this.panelLoadingCarrierPolicies.Controls.Add((Control) this.label9);
    this.panelLoadingCarrierPolicies.Controls.Add((Control) this.pictureBox5);
    this.panelLoadingCarrierPolicies.Dock = DockStyle.Fill;
    this.panelLoadingCarrierPolicies.Location = new Point(3, 18);
    this.panelLoadingCarrierPolicies.Name = "panelLoadingCarrierPolicies";
    this.panelLoadingCarrierPolicies.Size = new Size(688, 241);
    this.panelLoadingCarrierPolicies.TabIndex = 0;
    this.label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label9.Font = new Font("Tahoma", 9f);
    this.label9.Location = new Point(3, 203);
    this.label9.Name = "label9";
    this.label9.Size = new Size(685, 33);
    this.label9.TabIndex = 1;
    this.label9.Text = "Loading policy information...please be patient!";
    this.label9.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox5.BackColor = Color.White;
    this.pictureBox5.Image = (Image) componentResourceManager.GetObject("pictureBox5.Image");
    this.pictureBox5.Location = new Point(0, 0);
    this.pictureBox5.Name = "pictureBox5";
    this.pictureBox5.Size = new Size(688, 177);
    this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox5.TabIndex = 0;
    this.pictureBox5.TabStop = false;
    ((AppearanceBase) appearance57).BackColor = Color.White;
    ((AppearanceBase) appearance57).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Appearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance58).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance58).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance58).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance59).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance63).BackColor = Color.Transparent;
    ((AppearanceBase) appearance63).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance64).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance64).BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.gridCarrierPolicies).DisplayLayout.ScrollBarLook = scrollBarLook6;
    ((Control) this.gridCarrierPolicies).Dock = DockStyle.Fill;
    ((Control) this.gridCarrierPolicies).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridCarrierPolicies).Location = new Point(3, 18);
    ((Control) this.gridCarrierPolicies).Name = "gridCarrierPolicies";
    ((Control) this.gridCarrierPolicies).Size = new Size(688, 241);
    ((Control) this.gridCarrierPolicies).TabIndex = 1;
    ((UltraControlBase) this.gridCarrierPolicies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCarrierPolicies).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridCarrierPolicies).Visible = false;
    this.label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label15.Font = new Font("Tahoma", 9f);
    this.label15.Location = new Point(78, 31 /*0x1F*/);
    this.label15.Name = "label15";
    this.label15.Size = new Size(566, 14);
    this.label15.TabIndex = 3;
    this.label15.Text = componentResourceManager.GetString("label15.Text");
    this.label16.AutoSize = true;
    this.label16.Font = new Font("Tahoma", 9f);
    this.label16.Location = new Point(10, 31 /*0x1F*/);
    this.label16.Name = "label16";
    this.label16.Size = new Size(54, 14);
    this.label16.TabIndex = 2;
    this.label16.Text = "AR Total";
    this.label17.AutoSize = true;
    this.label17.Font = new Font("Tahoma", 9f);
    this.label17.Location = new Point(10, 54);
    this.label17.Name = "label17";
    this.label17.Size = new Size(54, 14);
    this.label17.TabIndex = 1;
    this.label17.Text = "AP Total";
    this.labelCarrierName.AutoSize = true;
    this.labelCarrierName.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelCarrierName.Location = new Point(10, 10);
    this.labelCarrierName.Name = "labelCarrierName";
    this.labelCarrierName.Size = new Size(94, 14);
    this.labelCarrierName.TabIndex = 0;
    this.labelCarrierName.Text = "[Carrier Name]";
    this.labelCarrierName.UseMnemonic = false;
    this.label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label13.BackColor = Color.Transparent;
    this.label13.Font = new Font("Tahoma", 10f);
    this.label13.Location = new Point(358, 343);
    this.label13.Name = "label13";
    this.label13.Size = new Size(705, 23);
    this.label13.TabIndex = 9;
    this.label13.Text = "Double-click a carrier/company to view the entity detail.";
    this.label13.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.ultraTabPageControl4).Controls.Add((Control) this.panelInsuredView);
    ((Control) this.ultraTabPageControl4).Controls.Add((Control) this.gridInsuredList);
    ((Control) this.ultraTabPageControl4).Controls.Add((Control) this.textLimitInsuredList);
    ((Control) this.ultraTabPageControl4).Controls.Add((Control) this.label27);
    ((Control) this.ultraTabPageControl4).Controls.Add((Control) this.label14);
    ((Control) this.ultraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl4).Name = "ultraTabPageControl4";
    ((Control) this.ultraTabPageControl4).Size = new Size(1078, 682);
    this.panelInsuredView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelInsuredView.BackColor = Color.GhostWhite;
    this.panelInsuredView.Controls.Add((Control) this.labelInsuredARAmount);
    this.panelInsuredView.Controls.Add((Control) this.labelInsuredAPAmount);
    this.panelInsuredView.Controls.Add((Control) this.label20);
    this.panelInsuredView.Controls.Add((Control) this.groupBox5);
    this.panelInsuredView.Controls.Add((Control) this.groupBox6);
    this.panelInsuredView.Controls.Add((Control) this.label23);
    this.panelInsuredView.Controls.Add((Control) this.label24);
    this.panelInsuredView.Controls.Add((Control) this.label25);
    this.panelInsuredView.Controls.Add((Control) this.labelInsuredName);
    this.panelInsuredView.Location = new Point(354, 3);
    this.panelInsuredView.Name = "panelInsuredView";
    this.panelInsuredView.Size = new Size(714, 702);
    this.panelInsuredView.TabIndex = 8;
    this.panelInsuredView.Visible = false;
    this.labelInsuredARAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelInsuredARAmount.Font = new Font("Tahoma", 9f);
    this.labelInsuredARAmount.Location = new Point(600, 31 /*0x1F*/);
    this.labelInsuredARAmount.Name = "labelInsuredARAmount";
    this.labelInsuredARAmount.Size = new Size(102, 14);
    this.labelInsuredARAmount.TabIndex = 6;
    this.labelInsuredARAmount.Text = "$0.00";
    this.labelInsuredARAmount.TextAlign = ContentAlignment.MiddleRight;
    this.labelInsuredAPAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelInsuredAPAmount.Font = new Font("Tahoma", 9f);
    this.labelInsuredAPAmount.Location = new Point(597, 54);
    this.labelInsuredAPAmount.Name = "labelInsuredAPAmount";
    this.labelInsuredAPAmount.Size = new Size(105, 14);
    this.labelInsuredAPAmount.TabIndex = 5;
    this.labelInsuredAPAmount.Text = "$100,000,000.00";
    this.labelInsuredAPAmount.TextAlign = ContentAlignment.MiddleRight;
    this.label20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label20.Font = new Font("Tahoma", 9f);
    this.label20.Location = new Point(78, 54);
    this.label20.Name = "label20";
    this.label20.Size = new Size(566, 14);
    this.label20.TabIndex = 4;
    this.label20.Text = componentResourceManager.GetString("label20.Text");
    this.groupBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox5.Controls.Add((Control) this.panelLoadingInsuredPayments);
    this.groupBox5.Controls.Add((Control) this.gridInsuredPayments);
    this.groupBox5.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox5.Location = new Point(13, 381);
    this.groupBox5.Name = "groupBox5";
    this.groupBox5.Size = new Size(689, 316);
    this.groupBox5.TabIndex = 8;
    this.groupBox5.TabStop = false;
    this.groupBox5.Text = "Payment/Receipt Information";
    this.panelLoadingInsuredPayments.Controls.Add((Control) this.label21);
    this.panelLoadingInsuredPayments.Controls.Add((Control) this.pictureBox6);
    this.panelLoadingInsuredPayments.Dock = DockStyle.Fill;
    this.panelLoadingInsuredPayments.Location = new Point(3, 18);
    this.panelLoadingInsuredPayments.Name = "panelLoadingInsuredPayments";
    this.panelLoadingInsuredPayments.Size = new Size(683, 295);
    this.panelLoadingInsuredPayments.TabIndex = 1;
    this.label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label21.Font = new Font("Tahoma", 9f);
    this.label21.Location = new Point(3, 258);
    this.label21.Name = "label21";
    this.label21.Size = new Size(680, 33);
    this.label21.TabIndex = 1;
    this.label21.Text = "Loading payment/receipt information...please be patient!";
    this.label21.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox6.BackColor = Color.White;
    this.pictureBox6.Image = (Image) componentResourceManager.GetObject("pictureBox6.Image");
    this.pictureBox6.Location = new Point(0, 0);
    this.pictureBox6.Name = "pictureBox6";
    this.pictureBox6.Size = new Size(683, 215);
    this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox6.TabIndex = 0;
    this.pictureBox6.TabStop = false;
    ((AppearanceBase) appearance66).BackColor = Color.White;
    ((AppearanceBase) appearance66).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Appearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance67).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance67).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance67;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance68).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance68;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance69).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance69;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance70).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance71;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance72).BackColor = Color.Transparent;
    ((AppearanceBase) appearance72).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance72;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance73).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance73).BorderColor = Color.Silver;
    scrollBarLook7.ButtonAppearance = (AppearanceBase) appearance73;
    ((AppearanceBase) appearance74).BackColor = Color.White;
    scrollBarLook7.TrackAppearance = (AppearanceBase) appearance74;
    ((UltraGridBase) this.gridInsuredPayments).DisplayLayout.ScrollBarLook = scrollBarLook7;
    ((Control) this.gridInsuredPayments).Dock = DockStyle.Fill;
    ((Control) this.gridInsuredPayments).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridInsuredPayments).Location = new Point(3, 18);
    ((Control) this.gridInsuredPayments).Name = "gridInsuredPayments";
    ((Control) this.gridInsuredPayments).Size = new Size(683, 295);
    ((Control) this.gridInsuredPayments).TabIndex = 2;
    ((UltraControlBase) this.gridInsuredPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInsuredPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridInsuredPayments).Visible = false;
    this.groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox6.Controls.Add((Control) this.panelLoadingInsuredPolicies);
    this.groupBox6.Controls.Add((Control) this.gridInsuredPolicies);
    this.groupBox6.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox6.Location = new Point(13, 87);
    this.groupBox6.Name = "groupBox6";
    this.groupBox6.Size = new Size(689, 288);
    this.groupBox6.TabIndex = 7;
    this.groupBox6.TabStop = false;
    this.groupBox6.Text = "Policy Information";
    this.panelLoadingInsuredPolicies.Controls.Add((Control) this.label22);
    this.panelLoadingInsuredPolicies.Controls.Add((Control) this.pictureBox7);
    this.panelLoadingInsuredPolicies.Dock = DockStyle.Fill;
    this.panelLoadingInsuredPolicies.Location = new Point(3, 18);
    this.panelLoadingInsuredPolicies.Name = "panelLoadingInsuredPolicies";
    this.panelLoadingInsuredPolicies.Size = new Size(683, 267);
    this.panelLoadingInsuredPolicies.TabIndex = 0;
    this.label22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label22.Font = new Font("Tahoma", 9f);
    this.label22.Location = new Point(3, 229);
    this.label22.Name = "label22";
    this.label22.Size = new Size(680, 33);
    this.label22.TabIndex = 1;
    this.label22.Text = "Loading policy information...please be patient!";
    this.label22.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox7.BackColor = Color.White;
    this.pictureBox7.Image = (Image) componentResourceManager.GetObject("pictureBox7.Image");
    this.pictureBox7.Location = new Point(0, 0);
    this.pictureBox7.Name = "pictureBox7";
    this.pictureBox7.Size = new Size(683, 203);
    this.pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox7.TabIndex = 0;
    this.pictureBox7.TabStop = false;
    ((AppearanceBase) appearance75).BackColor = Color.White;
    ((AppearanceBase) appearance75).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Appearance = (AppearanceBase) appearance75;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance76).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance76).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance76).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance76;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance77).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance77;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance78).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance78;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance79).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance79;
    ((AppearanceBase) appearance80).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance80;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance81).BackColor = Color.Transparent;
    ((AppearanceBase) appearance81).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance81;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance82).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance82).BorderColor = Color.Silver;
    scrollBarLook8.ButtonAppearance = (AppearanceBase) appearance82;
    ((AppearanceBase) appearance83).BackColor = Color.White;
    scrollBarLook8.TrackAppearance = (AppearanceBase) appearance83;
    ((UltraGridBase) this.gridInsuredPolicies).DisplayLayout.ScrollBarLook = scrollBarLook8;
    ((Control) this.gridInsuredPolicies).Dock = DockStyle.Fill;
    ((Control) this.gridInsuredPolicies).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridInsuredPolicies).Location = new Point(3, 18);
    ((Control) this.gridInsuredPolicies).Name = "gridInsuredPolicies";
    ((Control) this.gridInsuredPolicies).Size = new Size(683, 267);
    ((Control) this.gridInsuredPolicies).TabIndex = 1;
    ((UltraControlBase) this.gridInsuredPolicies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInsuredPolicies).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridInsuredPolicies).Visible = false;
    this.label23.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label23.Font = new Font("Tahoma", 9f);
    this.label23.Location = new Point(78, 31 /*0x1F*/);
    this.label23.Name = "label23";
    this.label23.Size = new Size(566, 14);
    this.label23.TabIndex = 3;
    this.label23.Text = componentResourceManager.GetString("label23.Text");
    this.label24.AutoSize = true;
    this.label24.Font = new Font("Tahoma", 9f);
    this.label24.Location = new Point(10, 31 /*0x1F*/);
    this.label24.Name = "label24";
    this.label24.Size = new Size(54, 14);
    this.label24.TabIndex = 2;
    this.label24.Text = "AR Total";
    this.label25.AutoSize = true;
    this.label25.Font = new Font("Tahoma", 9f);
    this.label25.Location = new Point(10, 54);
    this.label25.Name = "label25";
    this.label25.Size = new Size(54, 14);
    this.label25.TabIndex = 1;
    this.label25.Text = "AP Total";
    this.labelInsuredName.AutoSize = true;
    this.labelInsuredName.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.labelInsuredName.Location = new Point(10, 10);
    this.labelInsuredName.Name = "labelInsuredName";
    this.labelInsuredName.Size = new Size(101, 14);
    this.labelInsuredName.TabIndex = 0;
    this.labelInsuredName.Text = "[Insured Name]";
    this.labelInsuredName.UseMnemonic = false;
    ((Control) this.gridInsuredList).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance84).BackColor = Color.Transparent;
    ((AppearanceBase) appearance84).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Appearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance85).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance85).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance85).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance85;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance86).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance86;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance87).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance87;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance88).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance88;
    ((AppearanceBase) appearance89).BackColor = Color.Transparent;
    ((AppearanceBase) appearance89).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance89;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance90).BackColor = Color.Transparent;
    ((AppearanceBase) appearance90).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance90;
    ((AppearanceBase) appearance91).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance91).BorderColor = Color.Silver;
    scrollBarLook9.ButtonAppearance = (AppearanceBase) appearance91;
    ((AppearanceBase) appearance92).BackColor = Color.White;
    scrollBarLook9.TrackAppearance = (AppearanceBase) appearance92;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.ScrollBarLook = scrollBarLook9;
    ((UltraGridBase) this.gridInsuredList).DisplayLayout.SelectionOverlayColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    ((Control) this.gridInsuredList).Location = new Point(14, 33);
    ((Control) this.gridInsuredList).Name = "gridInsuredList";
    ((Control) this.gridInsuredList).Size = new Size(334, 667);
    ((Control) this.gridInsuredList).TabIndex = 7;
    this.gridInsuredList.DoubleClickRow += new DoubleClickRowEventHandler(this.gridInsuredList_DoubleClickRow);
    ((AppearanceBase) appearance93).BackColor = Color.White;
    ((AppearanceBase) appearance93).BorderColor = Color.Gray;
    ((AppearanceBase) appearance93).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLimitInsuredList).Appearance = (AppearanceBase) appearance93;
    ((Control) this.textLimitInsuredList).BackColor = Color.White;
    ((Control) this.textLimitInsuredList).Location = new Point((int) sbyte.MaxValue, 4);
    ((Control) this.textLimitInsuredList).Name = "textLimitInsuredList";
    ((Control) this.textLimitInsuredList).Size = new Size(222, 20);
    ((Control) this.textLimitInsuredList).TabIndex = 6;
    ((UltraControlBase) this.textLimitInsuredList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLimitInsuredList).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.textLimitInsuredList).ValueChanged += new EventHandler(this.textLimitInsuredList_ValueChanged);
    this.label27.AutoSize = true;
    this.label27.BackColor = Color.Transparent;
    this.label27.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label27.Location = new Point(11, 5);
    this.label27.Name = "label27";
    this.label27.Size = new Size(75, 13);
    this.label27.TabIndex = 5;
    this.label27.Text = "Entity Name";
    this.label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label14.BackColor = Color.Transparent;
    this.label14.Font = new Font("Tahoma", 10f);
    this.label14.Location = new Point(358, 343);
    this.label14.Name = "label14";
    this.label14.Size = new Size(706, 23);
    this.label14.TabIndex = 10;
    this.label14.Text = "Double-click a insured to view the entity detail.";
    this.label14.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.ultraTabPageControl5).Controls.Add((Control) this.panelOtherView);
    ((Control) this.ultraTabPageControl5).Controls.Add((Control) this.gridOtherList);
    ((Control) this.ultraTabPageControl5).Controls.Add((Control) this.textLimitOtherList);
    ((Control) this.ultraTabPageControl5).Controls.Add((Control) this.label36);
    ((Control) this.ultraTabPageControl5).Controls.Add((Control) this.label26);
    ((Control) this.ultraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl5).Name = "ultraTabPageControl5";
    ((Control) this.ultraTabPageControl5).Size = new Size(1078, 682);
    this.panelOtherView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelOtherView.BackColor = Color.GhostWhite;
    this.panelOtherView.Controls.Add((Control) this.labelOtherARAmount);
    this.panelOtherView.Controls.Add((Control) this.labelOtherAPAmount);
    this.panelOtherView.Controls.Add((Control) this.label29);
    this.panelOtherView.Controls.Add((Control) this.groupBox7);
    this.panelOtherView.Controls.Add((Control) this.groupBox8);
    this.panelOtherView.Controls.Add((Control) this.label32);
    this.panelOtherView.Controls.Add((Control) this.label33);
    this.panelOtherView.Controls.Add((Control) this.label34);
    this.panelOtherView.Controls.Add((Control) this.label3rdPartyExpensePayeeName);
    this.panelOtherView.Location = new Point(354, 3);
    this.panelOtherView.Name = "panelOtherView";
    this.panelOtherView.Size = new Size(714, 677);
    this.panelOtherView.TabIndex = 12;
    this.panelOtherView.Visible = false;
    this.labelOtherARAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelOtherARAmount.Font = new Font("Tahoma", 9f);
    this.labelOtherARAmount.Location = new Point(600, 31 /*0x1F*/);
    this.labelOtherARAmount.Name = "labelOtherARAmount";
    this.labelOtherARAmount.Size = new Size(102, 14);
    this.labelOtherARAmount.TabIndex = 6;
    this.labelOtherARAmount.Text = "$0.00";
    this.labelOtherARAmount.TextAlign = ContentAlignment.MiddleRight;
    this.labelOtherAPAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelOtherAPAmount.Font = new Font("Tahoma", 9f);
    this.labelOtherAPAmount.Location = new Point(597, 54);
    this.labelOtherAPAmount.Name = "labelOtherAPAmount";
    this.labelOtherAPAmount.Size = new Size(105, 14);
    this.labelOtherAPAmount.TabIndex = 5;
    this.labelOtherAPAmount.Text = "$100,000,000.00";
    this.labelOtherAPAmount.TextAlign = ContentAlignment.MiddleRight;
    this.label29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label29.Font = new Font("Tahoma", 9f);
    this.label29.Location = new Point(78, 54);
    this.label29.Name = "label29";
    this.label29.Size = new Size(566, 14);
    this.label29.TabIndex = 4;
    this.label29.Text = componentResourceManager.GetString("label29.Text");
    this.groupBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox7.Controls.Add((Control) this.panelLoadingOtherPayments);
    this.groupBox7.Controls.Add((Control) this.gridOtherPayments);
    this.groupBox7.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox7.Location = new Point(13, 356);
    this.groupBox7.Name = "groupBox7";
    this.groupBox7.Size = new Size(689, 316);
    this.groupBox7.TabIndex = 8;
    this.groupBox7.TabStop = false;
    this.groupBox7.Text = "Payment/Receipt Information";
    this.panelLoadingOtherPayments.Controls.Add((Control) this.label30);
    this.panelLoadingOtherPayments.Controls.Add((Control) this.pictureBox8);
    this.panelLoadingOtherPayments.Dock = DockStyle.Fill;
    this.panelLoadingOtherPayments.Location = new Point(3, 18);
    this.panelLoadingOtherPayments.Name = "panelLoadingOtherPayments";
    this.panelLoadingOtherPayments.Size = new Size(683, 295);
    this.panelLoadingOtherPayments.TabIndex = 1;
    this.label30.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label30.Font = new Font("Tahoma", 9f);
    this.label30.Location = new Point(3, 259);
    this.label30.Name = "label30";
    this.label30.Size = new Size(680, 33);
    this.label30.TabIndex = 1;
    this.label30.Text = "Loading payment/receipt information...please be patient!";
    this.label30.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox8.BackColor = Color.White;
    this.pictureBox8.Image = (Image) componentResourceManager.GetObject("pictureBox8.Image");
    this.pictureBox8.Location = new Point(0, 0);
    this.pictureBox8.Name = "pictureBox8";
    this.pictureBox8.Size = new Size(683, 215);
    this.pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox8.TabIndex = 0;
    this.pictureBox8.TabStop = false;
    ((AppearanceBase) appearance94).BackColor = Color.White;
    ((AppearanceBase) appearance94).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Appearance = (AppearanceBase) appearance94;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance95).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance95).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance95).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance95;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance96).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance96;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance97).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance97;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance98).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance98;
    ((AppearanceBase) appearance99).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance99;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance100).BackColor = Color.Transparent;
    ((AppearanceBase) appearance100).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance100;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance101).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance101).BorderColor = Color.Silver;
    scrollBarLook10.ButtonAppearance = (AppearanceBase) appearance101;
    ((AppearanceBase) appearance102).BackColor = Color.White;
    scrollBarLook10.TrackAppearance = (AppearanceBase) appearance102;
    ((UltraGridBase) this.gridOtherPayments).DisplayLayout.ScrollBarLook = scrollBarLook10;
    ((Control) this.gridOtherPayments).Dock = DockStyle.Fill;
    ((Control) this.gridOtherPayments).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridOtherPayments).Location = new Point(3, 18);
    ((Control) this.gridOtherPayments).Name = "gridOtherPayments";
    ((Control) this.gridOtherPayments).Size = new Size(683, 295);
    ((Control) this.gridOtherPayments).TabIndex = 2;
    ((UltraControlBase) this.gridOtherPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOtherPayments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOtherPayments).Visible = false;
    this.groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox8.Controls.Add((Control) this.panelLoadingOtherPolicies);
    this.groupBox8.Controls.Add((Control) this.gridOtherPolicies);
    this.groupBox8.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.groupBox8.Location = new Point(13, 87);
    this.groupBox8.Name = "groupBox8";
    this.groupBox8.Size = new Size(689, 263);
    this.groupBox8.TabIndex = 7;
    this.groupBox8.TabStop = false;
    this.groupBox8.Text = "Policy Information";
    this.panelLoadingOtherPolicies.Controls.Add((Control) this.label31);
    this.panelLoadingOtherPolicies.Controls.Add((Control) this.pictureBox9);
    this.panelLoadingOtherPolicies.Dock = DockStyle.Fill;
    this.panelLoadingOtherPolicies.Location = new Point(3, 18);
    this.panelLoadingOtherPolicies.Name = "panelLoadingOtherPolicies";
    this.panelLoadingOtherPolicies.Size = new Size(683, 242);
    this.panelLoadingOtherPolicies.TabIndex = 0;
    this.label31.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label31.Font = new Font("Tahoma", 9f);
    this.label31.Location = new Point(3, 204);
    this.label31.Name = "label31";
    this.label31.Size = new Size(680, 33);
    this.label31.TabIndex = 1;
    this.label31.Text = "Loading policy information...please be patient!";
    this.label31.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox9.BackColor = Color.White;
    this.pictureBox9.Image = (Image) componentResourceManager.GetObject("pictureBox9.Image");
    this.pictureBox9.Location = new Point(0, 0);
    this.pictureBox9.Name = "pictureBox9";
    this.pictureBox9.Size = new Size(683, 178);
    this.pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox9.TabIndex = 0;
    this.pictureBox9.TabStop = false;
    ((AppearanceBase) appearance103).BackColor = Color.White;
    ((AppearanceBase) appearance103).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Appearance = (AppearanceBase) appearance103;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance104).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance104).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance104).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance104;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance105).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance105;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance106).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance106;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance107).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance107;
    ((AppearanceBase) appearance108).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance108;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance109).BackColor = Color.Transparent;
    ((AppearanceBase) appearance109).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance109;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance110).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance110).BorderColor = Color.Silver;
    scrollBarLook11.ButtonAppearance = (AppearanceBase) appearance110;
    ((AppearanceBase) appearance111).BackColor = Color.White;
    scrollBarLook11.TrackAppearance = (AppearanceBase) appearance111;
    ((UltraGridBase) this.gridOtherPolicies).DisplayLayout.ScrollBarLook = scrollBarLook11;
    ((Control) this.gridOtherPolicies).Dock = DockStyle.Fill;
    ((Control) this.gridOtherPolicies).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridOtherPolicies).Location = new Point(3, 18);
    ((Control) this.gridOtherPolicies).Name = "gridOtherPolicies";
    ((Control) this.gridOtherPolicies).Size = new Size(683, 242);
    ((Control) this.gridOtherPolicies).TabIndex = 1;
    ((UltraControlBase) this.gridOtherPolicies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOtherPolicies).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOtherPolicies).Visible = false;
    this.label32.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label32.Font = new Font("Tahoma", 9f);
    this.label32.Location = new Point(78, 31 /*0x1F*/);
    this.label32.Name = "label32";
    this.label32.Size = new Size(566, 14);
    this.label32.TabIndex = 3;
    this.label32.Text = componentResourceManager.GetString("label32.Text");
    this.label33.AutoSize = true;
    this.label33.Font = new Font("Tahoma", 9f);
    this.label33.Location = new Point(10, 31 /*0x1F*/);
    this.label33.Name = "label33";
    this.label33.Size = new Size(54, 14);
    this.label33.TabIndex = 2;
    this.label33.Text = "AR Total";
    this.label34.AutoSize = true;
    this.label34.Font = new Font("Tahoma", 9f);
    this.label34.Location = new Point(10, 54);
    this.label34.Name = "label34";
    this.label34.Size = new Size(54, 14);
    this.label34.TabIndex = 1;
    this.label34.Text = "AP Total";
    this.label3rdPartyExpensePayeeName.AutoSize = true;
    this.label3rdPartyExpensePayeeName.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label3rdPartyExpensePayeeName.Location = new Point(10, 10);
    this.label3rdPartyExpensePayeeName.Name = "label3rdPartyExpensePayeeName";
    this.label3rdPartyExpensePayeeName.Size = new Size(101, 14);
    this.label3rdPartyExpensePayeeName.TabIndex = 0;
    this.label3rdPartyExpensePayeeName.Text = "[Insured Name]";
    this.label3rdPartyExpensePayeeName.UseMnemonic = false;
    ((Control) this.gridOtherList).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance112).BackColor = Color.Transparent;
    ((AppearanceBase) appearance112).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Appearance = (AppearanceBase) appearance112;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance113).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance113).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance113).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance113;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance114).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance114;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance115).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance115;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance116).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance116;
    ((AppearanceBase) appearance117).BackColor = Color.Transparent;
    ((AppearanceBase) appearance117).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance117;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance118).BackColor = Color.Transparent;
    ((AppearanceBase) appearance118).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance118;
    ((AppearanceBase) appearance119).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance119).BorderColor = Color.Silver;
    scrollBarLook12.ButtonAppearance = (AppearanceBase) appearance119;
    ((AppearanceBase) appearance120).BackColor = Color.White;
    scrollBarLook12.TrackAppearance = (AppearanceBase) appearance120;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.ScrollBarLook = scrollBarLook12;
    ((UltraGridBase) this.gridOtherList).DisplayLayout.SelectionOverlayColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    ((Control) this.gridOtherList).Location = new Point(14, 33);
    ((Control) this.gridOtherList).Name = "gridOtherList";
    ((Control) this.gridOtherList).Size = new Size(334, 642);
    ((Control) this.gridOtherList).TabIndex = 11;
    this.gridOtherList.DoubleClickRow += new DoubleClickRowEventHandler(this.gridOtherList_DoubleClickRow);
    ((AppearanceBase) appearance121).BackColor = Color.White;
    ((AppearanceBase) appearance121).BorderColor = Color.Gray;
    ((AppearanceBase) appearance121).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textLimitOtherList).Appearance = (AppearanceBase) appearance121;
    ((Control) this.textLimitOtherList).BackColor = Color.White;
    ((Control) this.textLimitOtherList).Location = new Point(125, 4);
    ((Control) this.textLimitOtherList).Name = "textLimitOtherList";
    ((Control) this.textLimitOtherList).Size = new Size(222, 20);
    ((Control) this.textLimitOtherList).TabIndex = 10;
    ((UltraControlBase) this.textLimitOtherList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textLimitOtherList).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.textLimitOtherList).ValueChanged += new EventHandler(this.textLimitOtherList_ValueChanged);
    this.label36.AutoSize = true;
    this.label36.BackColor = Color.Transparent;
    this.label36.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.label36.Location = new Point(11, 5);
    this.label36.Name = "label36";
    this.label36.Size = new Size(75, 13);
    this.label36.TabIndex = 9;
    this.label36.Text = "Entity Name";
    this.label26.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label26.BackColor = Color.Transparent;
    this.label26.Font = new Font("Tahoma", 10f);
    this.label26.Location = new Point(355, 330);
    this.label26.Name = "label26";
    this.label26.Size = new Size(704, 23);
    this.label26.TabIndex = 13;
    this.label26.Text = "Double-click an entity to view the entity detail.";
    this.label26.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.analysisTabControl).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.analysisTabControl).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.analysisTabControl).Controls.Add((Control) this.ultraTabPageControl2);
    ((Control) this.analysisTabControl).Controls.Add((Control) this.ultraTabPageControl3);
    ((Control) this.analysisTabControl).Controls.Add((Control) this.ultraTabPageControl4);
    ((Control) this.analysisTabControl).Controls.Add((Control) this.ultraTabPageControl5);
    ((Control) this.analysisTabControl).Dock = DockStyle.Fill;
    ((Control) this.analysisTabControl).Location = new Point(0, 37);
    ((Control) this.analysisTabControl).Name = "analysisTabControl";
    ((UltraTabControlBase) this.analysisTabControl).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.analysisTabControl).Size = new Size(1080, 692);
    ((UltraTabControlBase) this.analysisTabControl).SpaceBeforeTabs = new DefaultableInteger(10);
    ((UltraTabControlBase) this.analysisTabControl).Style = (UltraTabControlStyle) 9;
    ((Control) this.analysisTabControl).TabIndex = 0;
    ((UltraTabControlBase) this.analysisTabControl).TabLayoutStyle = (TabLayoutStyle) 2;
    ((AppearanceBase) appearance122).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance122).BackColor2 = Color.White;
    ((AppearanceBase) appearance122).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance122).BackGradientStyle = (GradientStyle) 8;
    ultraTab1.Appearance = (AppearanceBase) appearance122;
    ultraTab1.TabPage = this.ultraTabPageControl1;
    ultraTab1.Text = "Analysis Overview";
    ((AppearanceBase) appearance123).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance123).BackColor2 = Color.White;
    ((AppearanceBase) appearance123).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance123).BackGradientStyle = (GradientStyle) 8;
    ultraTab2.Appearance = (AppearanceBase) appearance123;
    ultraTab2.TabPage = this.ultraTabPageControl2;
    ultraTab2.Text = "Broker/Producer";
    ((AppearanceBase) appearance124).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance124).BackColor2 = Color.White;
    ((AppearanceBase) appearance124).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance124).BackGradientStyle = (GradientStyle) 8;
    ultraTab3.Appearance = (AppearanceBase) appearance124;
    ultraTab3.TabPage = this.ultraTabPageControl3;
    ultraTab3.Text = "Company/Carriers/Intermediaries";
    ((AppearanceBase) appearance125).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance125).BackColor2 = Color.White;
    ((AppearanceBase) appearance125).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance125).BackGradientStyle = (GradientStyle) 8;
    ultraTab4.Appearance = (AppearanceBase) appearance125;
    ultraTab4.TabPage = this.ultraTabPageControl4;
    ultraTab4.Text = "Insured";
    ((AppearanceBase) appearance126).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance126).BackColor2 = Color.White;
    ((AppearanceBase) appearance126).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance126).BackGradientStyle = (GradientStyle) 8;
    ultraTab5.Appearance = (AppearanceBase) appearance126;
    ultraTab5.TabPage = this.ultraTabPageControl5;
    ultraTab5.Text = "3rd Party Payees/Expense Payees";
    ((UltraTabControlBase) this.analysisTabControl).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraTabControlBase) this.analysisTabControl).TabsPerRow = 4;
    ((UltraControlBase) this.analysisTabControl).UseFlatMode = (DefaultableBoolean) 2;
    ((UltraControlBase) this.analysisTabControl).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.analysisTabControl).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(1078, 671);
    this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(439, 236);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(200, 128 /*0x80*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 12f);
    this.label1.Location = new Point(5, 210);
    this.label1.Name = "label1";
    this.label1.Size = new Size(1071, 23);
    this.label1.TabIndex = 2;
    this.label1.Text = "Loading entity financial data....";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    this.lblTakeAWhile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblTakeAWhile.BackColor = Color.Transparent;
    this.lblTakeAWhile.Font = new Font("Tahoma", 12f);
    this.lblTakeAWhile.Location = new Point(5, 386);
    this.lblTakeAWhile.Name = "lblTakeAWhile";
    this.lblTakeAWhile.Size = new Size(1071, 23);
    this.lblTakeAWhile.TabIndex = 3;
    this.lblTakeAWhile.Text = "This may take a while...please be patient!";
    this.lblTakeAWhile.TextAlign = ContentAlignment.MiddleCenter;
    this.lblTakeAWhile.Visible = false;
    this.timer1.Enabled = true;
    this.timer1.Interval = 5000;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.timer2.Interval = 7000;
    this.timer2.Tick += new EventHandler(this.timer2_Tick);
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    controlContainerTool1.ControlName = "comboGLCompany";
    ((ToolBase) controlContainerTool1).InstanceProps.IsFirstInGroup = true;
    controlContainerTool2.ControlName = "panelDateRange";
    ((ToolBase) controlContainerTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 396;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) controlContainerTool1,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((ToolbarSettingsBase) ultraToolbar.Settings).PaddingBottom = 8;
    ((ToolbarSettingsBase) ultraToolbar.Settings).PaddingTop = 4;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance127).Image = (object) MGASystems.IMS.Accounting.Analysis.Properties.Resources.refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance127;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Refresh Data";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool3.ControlName = "comboGLCompany";
    ((AppearanceBase) appearance128).ForeColor = Color.Navy;
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance128;
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Caption = "GL Company";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool4.ControlName = "panelDateRange";
    ((AppearanceBase) appearance129).ForeColor = Color.Navy;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance129;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "Date Range";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Width = 396;
    ((AppearanceBase) appearance130).Image = (object) MGASystems.IMS.Accounting.Analysis.Properties.Resources.printer;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance130;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Print Data";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool3,
      (ToolBase) controlContainerTool3,
      (ToolBase) controlContainerTool4,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left).Location = new Point(0, 37);
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left).Name = "_FormEntityAnalysis_Toolbars_Dock_Area_Left";
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left).Size = new Size(0, 692);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right).Location = new Point(1080, 37);
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right).Name = "_FormEntityAnalysis_Toolbars_Dock_Area_Right";
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right).Size = new Size(0, 692);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top).Name = "_FormEntityAnalysis_Toolbars_Dock_Area_Top";
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top).Size = new Size(1080, 37);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom).Location = new Point(0, 729);
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom).Name = "_FormEntityAnalysis_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom).Size = new Size(1080, 0);
    this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.comboGLCompany.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboGLCompany).DropDownWidth = 250;
    ((Control) this.comboGLCompany).Location = new Point(56, 83);
    this.comboGLCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompany).Name = "comboGLCompany";
    ((Control) this.comboGLCompany).Size = new Size(235, 21);
    ((Control) this.comboGLCompany).TabIndex = 8;
    ((UltraControlBase) this.comboGLCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance131).BackColor = Color.FromArgb(193, 217, 254);
    this.panelDateRange.Appearance = (AppearanceBase) appearance131;
    ((Control) this.panelDateRange.ClientArea).Controls.Add((Control) this.checkUseDateRange);
    ((Control) this.panelDateRange.ClientArea).Controls.Add((Control) this.label18);
    ((Control) this.panelDateRange.ClientArea).Controls.Add((Control) this.dateTimeTo);
    ((Control) this.panelDateRange.ClientArea).Controls.Add((Control) this.dateTimeFrom);
    ((Control) this.panelDateRange).Location = new Point(364, 74);
    ((Control) this.panelDateRange).Name = "panelDateRange";
    ((Control) this.panelDateRange).Size = new Size(323, 21);
    ((Control) this.panelDateRange).TabIndex = 9;
    this.label18.AutoSize = true;
    this.label18.Location = new Point(100, 4);
    this.label18.Name = "label18";
    this.label18.Size = new Size(11, 13);
    this.label18.TabIndex = 2;
    this.label18.Text = "-";
    ((AppearanceBase) appearance132).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeTo.Appearance = (AppearanceBase) appearance132;
    ((AppearanceBase) appearance133).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance133).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance133).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance133).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance133).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance133).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance133).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance133).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance133).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance133).ForegroundAlpha = (Alpha) 2;
    this.dateTimeTo.ButtonAppearance = (AppearanceBase) appearance133;
    ((Control) this.dateTimeTo).Location = new Point(114, 0);
    this.dateTimeTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeTo).Name = "dateTimeTo";
    ((Control) this.dateTimeTo).Size = new Size(92, 20);
    ((Control) this.dateTimeTo).TabIndex = 1;
    ((UltraControlBase) this.dateTimeTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeTo).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance134).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeFrom.Appearance = (AppearanceBase) appearance134;
    ((AppearanceBase) appearance135).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance135).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance135).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance135).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance135).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance135).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance135).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance135).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance135).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance135).ForegroundAlpha = (Alpha) 2;
    this.dateTimeFrom.ButtonAppearance = (AppearanceBase) appearance135;
    ((Control) this.dateTimeFrom).Location = new Point(4, 0);
    this.dateTimeFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeFrom).Name = "dateTimeFrom";
    ((Control) this.dateTimeFrom).Size = new Size(92, 20);
    ((Control) this.dateTimeFrom).TabIndex = 0;
    ((UltraControlBase) this.dateTimeFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.checkUseDateRange.AutoSize = true;
    this.checkUseDateRange.Checked = true;
    this.checkUseDateRange.CheckState = CheckState.Checked;
    this.checkUseDateRange.Location = new Point(213, 3);
    this.checkUseDateRange.Name = "checkUseDateRange";
    this.checkUseDateRange.Size = new Size(104, 17);
    this.checkUseDateRange.TabIndex = 3;
    this.checkUseDateRange.Text = "Use Date Range";
    this.checkUseDateRange.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Window;
    this.ClientSize = new Size(1080, 729);
    this.Controls.Add((Control) this.analysisTabControl);
    this.Controls.Add((Control) this.panelDateRange);
    this.Controls.Add((Control) this.comboGLCompany);
    this.Controls.Add((Control) this.lblTakeAWhile);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormEntityAnalysis_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormEntityAnalysis);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Entity Analysis";
    this.Load += new EventHandler(this.FormEntityAnalysis_Load);
    ((Control) this.ultraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.ultraGroupBox4).EndInit();
    ((Control) this.ultraGroupBox4).ResumeLayout(false);
    ((ISupportInitialize) this.chartBalanceBillingType).EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.chartBalances).EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.ultraGroupBox3).EndInit();
    ((Control) this.ultraGroupBox3).ResumeLayout(false);
    ((ISupportInitialize) this.chartAPEntityTypeBreakout).EndInit();
    ((ISupportInitialize) this.ultraGroupBox2).EndInit();
    ((Control) this.ultraGroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.chartAREntityTypeBreakout).EndInit();
    ((Control) this.ultraTabPageControl2).ResumeLayout(false);
    ((Control) this.ultraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.gridProducerList).EndInit();
    ((ISupportInitialize) this.mgaButton1).EndInit();
    ((ISupportInitialize) this.textLimitProducerList).EndInit();
    this.panelProducerView.ResumeLayout(false);
    this.panelProducerView.PerformLayout();
    this.groupBox2.ResumeLayout(false);
    this.panelLoadingProducerPayments.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox3).EndInit();
    ((ISupportInitialize) this.gridProducerPayments).EndInit();
    this.groupBox1.ResumeLayout(false);
    this.panelLoadingProducerPolicies.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox2).EndInit();
    ((ISupportInitialize) this.gridProducerPolicies).EndInit();
    ((Control) this.ultraTabPageControl3).ResumeLayout(false);
    ((Control) this.ultraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.gridCarrierList).EndInit();
    ((ISupportInitialize) this.textLimitCarrierList).EndInit();
    this.panelCarrierView.ResumeLayout(false);
    this.panelCarrierView.PerformLayout();
    this.groupBox3.ResumeLayout(false);
    this.panelLoadingCarrierPayments.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox4).EndInit();
    ((ISupportInitialize) this.gridCarrierPayments).EndInit();
    this.groupBox4.ResumeLayout(false);
    this.panelLoadingCarrierPolicies.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox5).EndInit();
    ((ISupportInitialize) this.gridCarrierPolicies).EndInit();
    ((Control) this.ultraTabPageControl4).ResumeLayout(false);
    ((Control) this.ultraTabPageControl4).PerformLayout();
    this.panelInsuredView.ResumeLayout(false);
    this.panelInsuredView.PerformLayout();
    this.groupBox5.ResumeLayout(false);
    this.panelLoadingInsuredPayments.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox6).EndInit();
    ((ISupportInitialize) this.gridInsuredPayments).EndInit();
    this.groupBox6.ResumeLayout(false);
    this.panelLoadingInsuredPolicies.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox7).EndInit();
    ((ISupportInitialize) this.gridInsuredPolicies).EndInit();
    ((ISupportInitialize) this.gridInsuredList).EndInit();
    ((ISupportInitialize) this.textLimitInsuredList).EndInit();
    ((Control) this.ultraTabPageControl5).ResumeLayout(false);
    ((Control) this.ultraTabPageControl5).PerformLayout();
    this.panelOtherView.ResumeLayout(false);
    this.panelOtherView.PerformLayout();
    this.groupBox7.ResumeLayout(false);
    this.panelLoadingOtherPayments.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox8).EndInit();
    ((ISupportInitialize) this.gridOtherPayments).EndInit();
    this.groupBox8.ResumeLayout(false);
    this.panelLoadingOtherPolicies.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox9).EndInit();
    ((ISupportInitialize) this.gridOtherPolicies).EndInit();
    ((ISupportInitialize) this.gridOtherList).EndInit();
    ((ISupportInitialize) this.textLimitOtherList).EndInit();
    ((ISupportInitialize) this.analysisTabControl).EndInit();
    ((Control) this.analysisTabControl).ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.comboGLCompany).EndInit();
    ((Control) this.panelDateRange.ClientArea).ResumeLayout(false);
    ((Control) this.panelDateRange.ClientArea).PerformLayout();
    ((Control) this.panelDateRange).ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeTo).EndInit();
    ((ISupportInitialize) this.dateTimeFrom).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
