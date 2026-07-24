// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpenseAnalysisHome
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpenseAnalysisHome : UserControl
{
  private Panel panelMain;
  private Panel panelHeader;
  private MGAGroupBox groupReportsListing;
  private Label label1;
  private PictureBox pictureBox1;
  private Panel panelContent;
  private Panel panelRight;
  private Label label2;
  private ImageList imageList1;
  private Label label3;
  private LinkLabel linkExpensesOfficeLocation;
  private LinkLabel linkExpensesCostCenter;
  private LinkLabel linkExpensesEntity;
  private LinkLabel linkExpenseIncomeOfficeLocation;
  private LinkLabel linkExpenseIncomeCostCenter;
  private LinkLabel linkExpenseIncomeUnderwriter;
  private Label label4;
  private LinkLabel linkBreakoutByExpense;
  private LinkLabel linkBreakoutByExpenseCategory;
  private IContainer components;
  private int _glCompanyId;
  private ExpenseAnalysisHome.MiniViewConfiguration _viewConfiguration;
  private const int WIDTH_BUFFER_AGGREGATE = 19;
  private const int HEIGHT_BUFFER_AGGREGATE = 260;

  public ExpenseAnalysisHome(int glCompanyId)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this.Dock = DockStyle.Fill;
    this.LoadMiniCharts();
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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (ExpenseAnalysisHome));
    this.panelMain = new Panel();
    this.panelContent = new Panel();
    this.panelRight = new Panel();
    this.groupReportsListing = new MGAGroupBox();
    this.linkExpenseIncomeUnderwriter = new LinkLabel();
    this.linkExpenseIncomeCostCenter = new LinkLabel();
    this.linkExpenseIncomeOfficeLocation = new LinkLabel();
    this.label3 = new Label();
    this.linkExpensesEntity = new LinkLabel();
    this.linkExpensesCostCenter = new LinkLabel();
    this.linkExpensesOfficeLocation = new LinkLabel();
    this.label2 = new Label();
    this.pictureBox1 = new PictureBox();
    this.panelHeader = new Panel();
    this.label1 = new Label();
    this.imageList1 = new ImageList(this.components);
    this.label4 = new Label();
    this.linkBreakoutByExpense = new LinkLabel();
    this.linkBreakoutByExpenseCategory = new LinkLabel();
    this.panelMain.SuspendLayout();
    this.panelRight.SuspendLayout();
    ((ISupportInitialize) this.groupReportsListing).BeginInit();
    ((Control) this.groupReportsListing).SuspendLayout();
    this.panelHeader.SuspendLayout();
    this.SuspendLayout();
    this.panelMain.Controls.Add((Control) this.panelContent);
    this.panelMain.Controls.Add((Control) this.panelRight);
    this.panelMain.Controls.Add((Control) this.panelHeader);
    this.panelMain.Dock = DockStyle.Fill;
    this.panelMain.Location = new Point(0, 0);
    this.panelMain.Name = "panelMain";
    this.panelMain.Size = new Size(880, 528);
    this.panelMain.TabIndex = 0;
    this.panelContent.AutoScroll = true;
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(0, 40);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(656, 488);
    this.panelContent.TabIndex = 3;
    this.panelContent.SizeChanged += new EventHandler(this.panelContent_SizeChanged);
    this.panelRight.Controls.Add((Control) this.groupReportsListing);
    this.panelRight.Dock = DockStyle.Right;
    this.panelRight.Location = new Point(656, 40);
    this.panelRight.Name = "panelRight";
    this.panelRight.Size = new Size(224 /*0xE0*/, 488);
    this.panelRight.TabIndex = 2;
    ((Control) this.groupReportsListing).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupReportsListing.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkExpenseIncomeUnderwriter);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkExpenseIncomeCostCenter);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkExpenseIncomeOfficeLocation);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.label3);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkBreakoutByExpenseCategory);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkBreakoutByExpense);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.label4);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkExpensesEntity);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkExpensesCostCenter);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.linkExpensesOfficeLocation);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.label2);
    ((Control) this.groupReportsListing).Controls.Add((Control) this.pictureBox1);
    ((Control) this.groupReportsListing).Font = new Font("Tahoma", 9f, FontStyle.Bold);
    ((AppearanceBase) appearance2).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.White;
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageBackground = (Image) resourceManager.GetObject("appearance2.ImageBackground");
    ((AppearanceBase) appearance2).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.groupReportsListing.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupReportsListing).Location = new Point(8, 8);
    ((Control) this.groupReportsListing).Name = "groupReportsListing";
    ((Control) this.groupReportsListing).Size = new Size(208 /*0xD0*/, 472);
    this.groupReportsListing.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.groupReportsListing).TabIndex = 1;
    ((Control) this.groupReportsListing).Text = "Reports";
    this.groupReportsListing.ViewStyle = (GroupBoxViewStyle) 2;
    this.linkExpenseIncomeUnderwriter.BackColor = Color.Transparent;
    this.linkExpenseIncomeUnderwriter.Dock = DockStyle.Top;
    this.linkExpenseIncomeUnderwriter.Font = new Font("Tahoma", 9f);
    this.linkExpenseIncomeUnderwriter.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkExpenseIncomeUnderwriter.Location = new Point(2, 259);
    this.linkExpenseIncomeUnderwriter.Name = "linkExpenseIncomeUnderwriter";
    this.linkExpenseIncomeUnderwriter.Size = new Size(204, 24);
    this.linkExpenseIncomeUnderwriter.TabIndex = 8;
    this.linkExpenseIncomeUnderwriter.TabStop = true;
    this.linkExpenseIncomeUnderwriter.Text = "By Underwriter";
    this.linkExpenseIncomeUnderwriter.TextAlign = ContentAlignment.MiddleCenter;
    this.linkExpenseIncomeCostCenter.BackColor = Color.Transparent;
    this.linkExpenseIncomeCostCenter.Dock = DockStyle.Top;
    this.linkExpenseIncomeCostCenter.Font = new Font("Tahoma", 9f);
    this.linkExpenseIncomeCostCenter.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkExpenseIncomeCostCenter.Location = new Point(2, 235);
    this.linkExpenseIncomeCostCenter.Name = "linkExpenseIncomeCostCenter";
    this.linkExpenseIncomeCostCenter.Size = new Size(204, 24);
    this.linkExpenseIncomeCostCenter.TabIndex = 7;
    this.linkExpenseIncomeCostCenter.TabStop = true;
    this.linkExpenseIncomeCostCenter.Text = "By Cost Center";
    this.linkExpenseIncomeCostCenter.TextAlign = ContentAlignment.MiddleCenter;
    this.linkExpenseIncomeOfficeLocation.BackColor = Color.Transparent;
    this.linkExpenseIncomeOfficeLocation.Dock = DockStyle.Top;
    this.linkExpenseIncomeOfficeLocation.Font = new Font("Tahoma", 9f);
    this.linkExpenseIncomeOfficeLocation.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkExpenseIncomeOfficeLocation.Location = new Point(2, 211);
    this.linkExpenseIncomeOfficeLocation.Name = "linkExpenseIncomeOfficeLocation";
    this.linkExpenseIncomeOfficeLocation.Size = new Size(204, 24);
    this.linkExpenseIncomeOfficeLocation.TabIndex = 6;
    this.linkExpenseIncomeOfficeLocation.TabStop = true;
    this.linkExpenseIncomeOfficeLocation.Text = "By Office Location";
    this.linkExpenseIncomeOfficeLocation.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.BackColor = Color.Transparent;
    this.label3.Dock = DockStyle.Top;
    this.label3.Location = new Point(2, 188);
    this.label3.Name = "label3";
    this.label3.Size = new Size(204, 23);
    this.label3.TabIndex = 5;
    this.label3.Text = "Expenses Vs. Income";
    this.label3.TextAlign = ContentAlignment.BottomCenter;
    this.linkExpensesEntity.BackColor = Color.Transparent;
    this.linkExpensesEntity.Dock = DockStyle.Top;
    this.linkExpensesEntity.Font = new Font("Tahoma", 9f);
    this.linkExpensesEntity.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkExpensesEntity.Location = new Point(2, 93);
    this.linkExpensesEntity.Name = "linkExpensesEntity";
    this.linkExpensesEntity.Size = new Size(204, 24);
    this.linkExpensesEntity.TabIndex = 4;
    this.linkExpensesEntity.TabStop = true;
    this.linkExpensesEntity.Text = "By Entity";
    this.linkExpensesEntity.TextAlign = ContentAlignment.MiddleCenter;
    this.linkExpensesCostCenter.BackColor = Color.Transparent;
    this.linkExpensesCostCenter.Dock = DockStyle.Top;
    this.linkExpensesCostCenter.Font = new Font("Tahoma", 9f);
    this.linkExpensesCostCenter.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkExpensesCostCenter.Location = new Point(2, 69);
    this.linkExpensesCostCenter.Name = "linkExpensesCostCenter";
    this.linkExpensesCostCenter.Size = new Size(204, 24);
    this.linkExpensesCostCenter.TabIndex = 3;
    this.linkExpensesCostCenter.TabStop = true;
    this.linkExpensesCostCenter.Text = "By Cost Center";
    this.linkExpensesCostCenter.TextAlign = ContentAlignment.MiddleCenter;
    this.linkExpensesOfficeLocation.BackColor = Color.Transparent;
    this.linkExpensesOfficeLocation.Dock = DockStyle.Top;
    this.linkExpensesOfficeLocation.Font = new Font("Tahoma", 9f);
    this.linkExpensesOfficeLocation.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkExpensesOfficeLocation.Location = new Point(2, 45);
    this.linkExpensesOfficeLocation.Name = "linkExpensesOfficeLocation";
    this.linkExpensesOfficeLocation.Size = new Size(204, 24);
    this.linkExpensesOfficeLocation.TabIndex = 2;
    this.linkExpensesOfficeLocation.TabStop = true;
    this.linkExpensesOfficeLocation.Text = "By Office Location";
    this.linkExpensesOfficeLocation.TextAlign = ContentAlignment.MiddleCenter;
    this.label2.BackColor = Color.Transparent;
    this.label2.Dock = DockStyle.Top;
    this.label2.Location = new Point(2, 22);
    this.label2.Name = "label2";
    this.label2.Size = new Size(204, 23);
    this.label2.TabIndex = 1;
    this.label2.Text = "Expenses";
    this.label2.TextAlign = ContentAlignment.BottomCenter;
    this.pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(96 /*0x60*/, 360);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(112 /*0x70*/, 112 /*0x70*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.panelHeader.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelHeader.BackgroundImage = (Image) resourceManager.GetObject("panelHeader.BackgroundImage");
    this.panelHeader.Controls.Add((Control) this.label1);
    this.panelHeader.Dock = DockStyle.Top;
    this.panelHeader.Location = new Point(0, 0);
    this.panelHeader.Name = "panelHeader";
    this.panelHeader.Size = new Size(880, 40);
    this.panelHeader.TabIndex = 0;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 16f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb(239, 247, 253);
    this.label1.Location = new Point(640, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(228, 29);
    this.label1.TabIndex = 0;
    this.label1.Text = "EXPENSE ANALYSIS";
    this.imageList1.ColorDepth = ColorDepth.Depth32Bit;
    this.imageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.imageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.label4.BackColor = Color.Transparent;
    this.label4.Dock = DockStyle.Top;
    this.label4.Location = new Point(2, 117);
    this.label4.Name = "label4";
    this.label4.Size = new Size(204, 23);
    this.label4.TabIndex = 9;
    this.label4.Text = "Analysis Breakout";
    this.label4.TextAlign = ContentAlignment.BottomCenter;
    this.linkBreakoutByExpense.BackColor = Color.Transparent;
    this.linkBreakoutByExpense.Dock = DockStyle.Top;
    this.linkBreakoutByExpense.Font = new Font("Tahoma", 9f);
    this.linkBreakoutByExpense.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkBreakoutByExpense.Location = new Point(2, 140);
    this.linkBreakoutByExpense.Name = "linkBreakoutByExpense";
    this.linkBreakoutByExpense.Size = new Size(204, 24);
    this.linkBreakoutByExpense.TabIndex = 10;
    this.linkBreakoutByExpense.TabStop = true;
    this.linkBreakoutByExpense.Text = "By Expense";
    this.linkBreakoutByExpense.TextAlign = ContentAlignment.MiddleCenter;
    this.linkBreakoutByExpenseCategory.BackColor = Color.Transparent;
    this.linkBreakoutByExpenseCategory.Dock = DockStyle.Top;
    this.linkBreakoutByExpenseCategory.Font = new Font("Tahoma", 9f);
    this.linkBreakoutByExpenseCategory.ImageAlign = ContentAlignment.MiddleLeft;
    this.linkBreakoutByExpenseCategory.Location = new Point(2, 164);
    this.linkBreakoutByExpenseCategory.Name = "linkBreakoutByExpenseCategory";
    this.linkBreakoutByExpenseCategory.Size = new Size(204, 24);
    this.linkBreakoutByExpenseCategory.TabIndex = 11;
    this.linkBreakoutByExpenseCategory.TabStop = true;
    this.linkBreakoutByExpenseCategory.Text = "By Expense Category";
    this.linkBreakoutByExpenseCategory.TextAlign = ContentAlignment.MiddleCenter;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.panelMain);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (ExpenseAnalysisHome);
    this.Size = new Size(880, 528);
    this.panelMain.ResumeLayout(false);
    this.panelRight.ResumeLayout(false);
    ((ISupportInitialize) this.groupReportsListing).EndInit();
    ((Control) this.groupReportsListing).ResumeLayout(false);
    this.panelHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadMiniCharts()
  {
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.OfficeLocationExpense, Utilities.AnalysisChartType.PieChart));
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.CostCenterExpense, Utilities.AnalysisChartType.BarChart));
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.EntityExpenses, Utilities.AnalysisChartType.BarChart));
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.BreakoutByExpense, Utilities.AnalysisChartType.PieChart));
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.OfficeLocationExpenseIncome, Utilities.AnalysisChartType.BarChartWithSeries));
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.CostCenterExpenseIncome, Utilities.AnalysisChartType.BarChartWithSeries));
    this.panelContent.Controls.Add((Control) new AnalysisMiniView(this._glCompanyId, Utilities.AnalysisReportType.UnderwriterExpenseIncome, Utilities.AnalysisChartType.BarChartWithSeries));
  }

  private void DoLoadMiniCharts()
  {
  }

  private void LoadMiniChartsCompleted(AnalysisMiniView miniView)
  {
    this.panelContent.Controls.Add((Control) miniView);
    if (this.panelContent.Controls.Count != 0)
      return;
    miniView.Location = new Point(4, 4);
  }

  private void DetermineViewConfiguration()
  {
    this.SuspendLayout();
    this.panelContent.AutoScroll = false;
    if (this.panelContent.Width >= this.panelContent.Controls[0].Width * 2 + 19)
      this.SetBoxDisplay();
    else
      this.SetLinearCentered();
    this.panelContent.AutoScroll = true;
    this.ResumeLayout(true);
  }

  private void SetBoxDisplay()
  {
    if (this._viewConfiguration == ExpenseAnalysisHome.MiniViewConfiguration.BoxDisplay)
      return;
    this._viewConfiguration = ExpenseAnalysisHome.MiniViewConfiguration.BoxDisplay;
    Control[] controlArray = new Control[this.panelContent.Controls.Count];
    this.panelContent.Controls.CopyTo((Array) controlArray, 0);
    this.panelContent.Controls.Clear();
    int num = 0;
    for (int index = 0; index < controlArray.Length; ++index)
    {
      if (index != 0 && index % 2 == 0)
        ++num;
      this.panelContent.Controls.Add(controlArray[index]);
      this.panelContent.Controls[index].Location = new Point(index % 2 == 0 ? 4 : this.panelContent.Controls[index].Width + 19, num * 260 + 4);
    }
  }

  private void SetLinearCentered()
  {
    if (this._viewConfiguration == ExpenseAnalysisHome.MiniViewConfiguration.LinearCentered || this.panelContent.Controls.Count == 0)
      return;
    this._viewConfiguration = ExpenseAnalysisHome.MiniViewConfiguration.LinearCentered;
    Control[] controlArray = new Control[this.panelContent.Controls.Count];
    this.panelContent.Controls.CopyTo((Array) controlArray, 0);
    this.panelContent.Controls.Clear();
    for (int index = 0; index < controlArray.Length; ++index)
    {
      this.panelContent.Controls.Add(controlArray[index]);
      this.panelContent.Controls[index].Location = new Point((this.panelContent.Width - this.panelContent.Controls[index].Width) / 2, index == 0 ? 4 : index * 260 + 4);
    }
  }

  private void panelContent_SizeChanged(object sender, EventArgs e)
  {
    this.DetermineViewConfiguration();
  }

  private delegate void LoadMiniChartsCompletedHandler(AnalysisMiniView miniView);

  private enum MiniViewConfiguration
  {
    None,
    BoxDisplay,
    LinearCentered,
  }
}
