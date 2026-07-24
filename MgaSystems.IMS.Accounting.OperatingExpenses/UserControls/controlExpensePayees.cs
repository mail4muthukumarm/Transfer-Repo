// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.controlExpensePayees
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class controlExpensePayees : UserControl
{
  private dsOperatingExpensePayees dsOperatingExpensePayees1;
  private SqlDataAdapter daExpensePayees;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection ControlDataConnection;
  private MGAGroupBox mgaGroupBox2;
  private Panel panel1;
  private ExpensePayeeList expensePayeeList2;
  private IContainer components;
  private ExpensePayeeList.ExpensePayeesChangedHandler _payeeChangedHandler;

  public controlExpensePayees()
  {
    this.InitializeComponent();
    this._payeeChangedHandler = new ExpensePayeeList.ExpensePayeesChangedHandler(this.PayeeList_ListChangedHandler);
    this.expensePayeeList2.ExpensePayeeChanged += this._payeeChangedHandler;
    this.Dock = DockStyle.Fill;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadExpensePayees();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (controlExpensePayees));
    this.dsOperatingExpensePayees1 = new dsOperatingExpensePayees();
    this.daExpensePayees = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.mgaGroupBox2 = new MGAGroupBox();
    this.expensePayeeList2 = new ExpensePayeeList();
    this.panel1 = new Panel();
    this.dsOperatingExpensePayees1.BeginInit();
    ((ISupportInitialize) this.mgaGroupBox2).BeginInit();
    ((Control) this.mgaGroupBox2).SuspendLayout();
    this.SuspendLayout();
    this.dsOperatingExpensePayees1.DataSetName = "dsOperatingExpensePayees";
    this.dsOperatingExpensePayees1.Locale = new CultureInfo("en-US");
    this.daExpensePayees.SelectCommand = this.sqlSelectCommand1;
    this.daExpensePayees.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_Operating_GetExpensePayees", new DataColumnMapping[13]
      {
        new DataColumnMapping("payeeGuid", "payeeGuid"),
        new DataColumnMapping("PayeeName", "PayeeName"),
        new DataColumnMapping("PayeeAcctNum", "PayeeAcctNum"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("Phone1", "Phone1"),
        new DataColumnMapping("Phone2", "Phone2"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("Email", "Email")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_Operating_GetExpensePayees]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.ControlDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.mgaGroupBox2).Controls.Add((Control) this.expensePayeeList2);
    ((Control) this.mgaGroupBox2).Dock = DockStyle.Fill;
    ((Control) this.mgaGroupBox2).Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((AppearanceBase) appearance2).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.White;
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageBackground = (Image) resourceManager.GetObject("appearance2.ImageBackground");
    ((AppearanceBase) appearance2).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.mgaGroupBox2).Location = new Point(0, 0);
    ((Control) this.mgaGroupBox2).Name = "mgaGroupBox2";
    ((Control) this.mgaGroupBox2).Size = new Size(888, 624);
    this.mgaGroupBox2.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaGroupBox2).TabIndex = 6;
    ((Control) this.mgaGroupBox2).Text = " Vendor List";
    this.mgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    this.expensePayeeList2.BackColor = Color.White;
    this.expensePayeeList2.Dock = DockStyle.Fill;
    this.expensePayeeList2.Font = new Font("Tahoma", 8f);
    this.expensePayeeList2.ForeColor = Color.Black;
    this.expensePayeeList2.Location = new Point(2, 22);
    this.expensePayeeList2.Name = "expensePayeeList2";
    this.expensePayeeList2.Size = new Size(884, 600);
    this.expensePayeeList2.TabIndex = 0;
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 624);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(888, 8);
    this.panel1.TabIndex = 7;
    this.BackColor = Color.WhiteSmoke;
    this.Controls.Add((Control) this.mgaGroupBox2);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (controlExpensePayees);
    this.Size = new Size(888, 632);
    this.dsOperatingExpensePayees1.EndInit();
    ((ISupportInitialize) this.mgaGroupBox2).EndInit();
    ((Control) this.mgaGroupBox2).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadExpensePayees()
  {
    this.Cursor = Cursors.WaitCursor;
    this.dsOperatingExpensePayees1.Clear();
    this.daExpensePayees.Fill((DataTable) this.dsOperatingExpensePayees1.PayeesList);
    this.expensePayeeList2.SetDataSource(this.dsOperatingExpensePayees1);
    this.Cursor = Cursors.Default;
  }

  private void PayeeList_ListChangedHandler(object sender, EventArgs e) => this.LoadExpensePayees();
}
