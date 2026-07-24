// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpenseGLLinking
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[TestForm]
public class formExpenseGLLinking : AccountingNoteDocumentSupport
{
  internal UltraLabel ultraLabel4;
  internal UltraLabel ultraLabel8;
  internal UltraLabel UltraLabel1;
  internal Panel Panel2;
  internal Label label7;
  internal PictureBox PictureBox1;
  internal Label label8;
  internal Panel Panel1;
  private Label label1;
  private Label label2;
  private Label label3;
  private MGASimpleComboBox comboExpenses;
  private MGASimpleComboBox comboOfficeLocation;
  private ExtendedTreeViewDropDown dropTreeGLAccount;
  private Label labelLoadingOfficeLocationSettings;
  private dsExpenses dsExpenses1;
  private UltraGroupBox groupSettings;
  private MGAButton buttonUpdate;
  internal MGAButton buttonFinish;
  private System.ComponentModel.Container components;

  public formExpenseGLLinking()
  {
    this.InitializeComponent();
    this.InitForm();
  }

  public formExpenseGLLinking(int expenseCode)
  {
    this.InitializeComponent();
    this.InitForm(expenseCode);
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
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formExpenseGLLinking));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.UltraLabel1 = new UltraLabel();
    this.Panel2 = new Panel();
    this.label7 = new Label();
    this.PictureBox1 = new PictureBox();
    this.label8 = new Label();
    this.Panel1 = new Panel();
    this.buttonFinish = new MGAButton();
    this.comboExpenses = new MGASimpleComboBox();
    this.dsExpenses1 = new dsExpenses();
    this.groupSettings = new UltraGroupBox();
    this.labelLoadingOfficeLocationSettings = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.label1 = new Label();
    this.label2 = new Label();
    this.dropTreeGLAccount = new ExtendedTreeViewDropDown();
    this.label3 = new Label();
    this.buttonUpdate = new MGAButton();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.comboExpenses).BeginInit();
    this.dsExpenses1.BeginInit();
    ((ISupportInitialize) this.groupSettings).BeginInit();
    ((Control) this.groupSettings).SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.buttonUpdate).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(24, 104);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(162, 15);
    ((Control) this.ultraLabel4).TabIndex = 23;
    ((Control) this.ultraLabel4).Text = "Add Expense GL Account Linking";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance2;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(182, 15);
    ((Control) this.ultraLabel8).TabIndex = 22;
    ((Control) this.ultraLabel8).Text = "EXPENSE GL ACCOUNT LINKING";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance3;
    ((Control) this.UltraLabel1).Dock = DockStyle.Left;
    ((Control) this.UltraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(192 /*0xC0*/, 310);
    ((Control) this.UltraLabel1).TabIndex = 21;
    this.Panel2.Controls.Add((Control) this.label7);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Controls.Add((Control) this.label8);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(600, 80 /*0x50*/);
    this.Panel2.TabIndex = 20;
    this.label7.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label7.Dock = DockStyle.Bottom;
    this.label7.ForeColor = Color.FromArgb(239, 247, 253);
    this.label7.Location = new Point(0, 79);
    this.label7.Name = "label7";
    this.label7.Size = new Size(600, 1);
    this.label7.TabIndex = 1;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(80 /*0x50*/, 80 /*0x50*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.label8.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label8.Location = new Point(368, 56);
    this.label8.Name = "label8";
    this.label8.Size = new Size(231, 19);
    this.label8.TabIndex = 0;
    this.label8.Text = "Expense GL Account Linking";
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.buttonFinish);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 390);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(600, 40);
    this.Panel1.TabIndex = 39;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonFinish).Location = new Point(488, 8);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonFinish).TabIndex = 2;
    ((Control) this.buttonFinish).Text = "Done";
    ((UltraControlBase) this.buttonFinish).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonFinish).Click += new EventHandler(this.buttonCancel_Click);
    this.comboExpenses.BorderStyle = (UIElementBorderStyle) 4;
    this.comboExpenses.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboExpenses).DataSource = (object) this.dsExpenses1;
    ((UltraDropDownBase) this.comboExpenses).DisplayMember = "ExpenseName";
    this.comboExpenses.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboExpenses.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExpenses).Location = new Point(288, 88);
    this.comboExpenses.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboExpenses).Name = "comboExpenses";
    ((Control) this.comboExpenses).Size = new Size(304, 21);
    ((Control) this.comboExpenses).TabIndex = 40;
    ((UltraControlBase) this.comboExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboExpenses).ValueMember = "ExpenseCode";
    this.comboExpenses.RowSelected += new RowSelectedEventHandler(this.comboExpenses_RowSelected);
    this.dsExpenses1.DataSetName = "dsExpenses";
    this.dsExpenses1.Locale = new CultureInfo("en-US");
    this.groupSettings.BorderStyle = (GroupBoxBorderStyle) 13;
    ((Control) this.groupSettings).Controls.Add((Control) this.labelLoadingOfficeLocationSettings);
    ((AppearanceBase) appearance5).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance5).ForeColor = Color.DimGray;
    this.groupSettings.HeaderAppearance = (AppearanceBase) appearance5;
    ((Control) this.groupSettings).Location = new Point(200, 192 /*0xC0*/);
    ((Control) this.groupSettings).Name = "groupSettings";
    ((Control) this.groupSettings).Size = new Size(392, 192 /*0xC0*/);
    ((Control) this.groupSettings).TabIndex = 41;
    ((Control) this.groupSettings).Text = "Office Locations Settings";
    this.labelLoadingOfficeLocationSettings.BackColor = Color.Transparent;
    this.labelLoadingOfficeLocationSettings.Dock = DockStyle.Fill;
    this.labelLoadingOfficeLocationSettings.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelLoadingOfficeLocationSettings.ForeColor = Color.DarkGray;
    this.labelLoadingOfficeLocationSettings.Location = new Point(3, 17);
    this.labelLoadingOfficeLocationSettings.Name = "labelLoadingOfficeLocationSettings";
    this.labelLoadingOfficeLocationSettings.Size = new Size(386, 172);
    this.labelLoadingOfficeLocationSettings.TabIndex = 47;
    this.labelLoadingOfficeLocationSettings.Text = "Loading office location settings...";
    this.labelLoadingOfficeLocationSettings.TextAlign = ContentAlignment.MiddleCenter;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    this.comboOfficeLocation.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(288, 112 /*0x70*/);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(304, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 42;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(200, 88);
    this.label1.Name = "label1";
    this.label1.Size = new Size(52, 13);
    this.label1.TabIndex = 43;
    this.label1.Text = "Expense:";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(200, 112 /*0x70*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(83, 13);
    this.label2.TabIndex = 44;
    this.label2.Text = "Office Location:";
    this.label2.TextAlign = ContentAlignment.MiddleLeft;
    this.dropTreeGLAccount.DropDownHeight = 300;
    this.dropTreeGLAccount.DropDownWidth = 300;
    this.dropTreeGLAccount.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccount.Location = new Point(288, 136);
    this.dropTreeGLAccount.Name = "dropTreeGLAccount";
    this.dropTreeGLAccount.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGLAccount.ShowEquityAccounts = true;
    this.dropTreeGLAccount.ShowExpenseAccounts = true;
    this.dropTreeGLAccount.ShowIncomeAccounts = true;
    this.dropTreeGLAccount.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGLAccount.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccount.Size = new Size(304, 20);
    this.dropTreeGLAccount.TabIndex = 45;
    this.dropTreeGLAccount.UseCheckedStateSelectionOverride = false;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(200, 136);
    this.label3.Name = "label3";
    this.label3.Size = new Size(65, 13);
    this.label3.TabIndex = 46;
    this.label3.Text = "GL Account:";
    this.label3.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance6).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance6).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonUpdate).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonUpdate).Location = new Point(496, 160 /*0xA0*/);
    ((Control) this.buttonUpdate).Name = "buttonUpdate";
    ((Control) this.buttonUpdate).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.buttonUpdate).TabIndex = 47;
    ((Control) this.buttonUpdate).Text = "Update Setting";
    ((UltraControlBase) this.buttonUpdate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonUpdate).Click += new EventHandler(this.buttonUpdate_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(600, 430);
    this.Controls.Add((Control) this.buttonUpdate);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.dropTreeGLAccount);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.groupSettings);
    this.Controls.Add((Control) this.comboExpenses);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.UltraLabel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formExpenseGLLinking);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Expense GL Account Linking";
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.comboExpenses).EndInit();
    this.dsExpenses1.EndInit();
    ((ISupportInitialize) this.groupSettings).EndInit();
    ((Control) this.groupSettings).ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.buttonUpdate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void InitForm()
  {
    this.LoadExpenses();
    this.LoadOfficeLocations();
  }

  private void InitForm(int expenseCode)
  {
    this.LoadExpenses();
    this.LoadOfficeLocations();
    this.SetSelectedExpense(expenseCode);
  }

  private void LoadExpenses()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_GetExpenses", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          sqlDataAdapter.Fill((DataTable) this.dsExpenses1.Expenses);
      }
    }
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
  }

  private void SetSelectedExpense(int expenseCode)
  {
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    this.Cursor = Cursors.WaitCursor;
    this.dropTreeGLAccount.LoadGLAccounts(int.Parse(this.comboOfficeLocation.Value.ToString()));
    this.Cursor = Cursors.Default;
  }

  private void GetExpenseDefaultAccounts()
  {
    DataTable dt = Database.Instance.QuerySP.PerformTableQuery("spFin_GetExpenseDefaultGLAccounts", (object) "@expenseCode", (object) int.Parse(this.comboExpenses.Value.ToString()));
    if (dt.Rows.Count == 0)
      return;
    this.DisplayCurrentSettings(dt);
  }

  private void DisplayCurrentSettings(DataTable dt)
  {
    ((Control) this.groupSettings).Controls.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
    {
      Label label = new Label();
      label.Text = row[0].ToString();
      label.Tag = (object) new formExpenseGLLinking.ExpenseGLSetting(int.Parse(row["glcompanyid"].ToString()), int.Parse(row["expenseCode"].ToString()), int.Parse(row["glAcctId"].ToString()));
      label.UseMnemonic = false;
      label.TextAlign = ContentAlignment.MiddleCenter;
      label.Height = 32 /*0x20*/;
      label.Click += new EventHandler(this.ClickHandler);
      ((Control) this.groupSettings).Controls.Add((Control) label);
      label.Dock = DockStyle.Top;
    }
  }

  private void comboExpenses_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboExpenses).SelectedRow == null)
      return;
    this.GetExpenseDefaultAccounts();
  }

  private void ClickHandler(object sender, EventArgs e)
  {
    if (!(sender is Label))
      return;
    foreach (Control control in (ArrangedElementCollection) ((Control) this.groupSettings).Controls)
    {
      if (control is Label)
        (control as Label).BackColor = Color.White;
    }
    (sender as Label).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    if (!((sender as Label).Tag is formExpenseGLLinking.ExpenseGLSetting))
      return;
    this.comboOfficeLocation.Value = (object) ((sender as Label).Tag as formExpenseGLLinking.ExpenseGLSetting).GLCompanyId;
    this.dropTreeGLAccount.SetSelectedNodeByKey(((sender as Label).Tag as formExpenseGLLinking.ExpenseGLSetting).GlAccountID.ToString());
  }

  private void buttonUpdate_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboExpenses).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select an expense to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num2 = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.dropTreeGLAccount.GLAccountID == -1)
    {
      int num3 = (int) MessageBox.Show("You must select a GL Account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      this.SaveDefaultGLAccountSetting(int.Parse(this.comboExpenses.Value.ToString()), int.Parse(this.comboOfficeLocation.Value.ToString()), this.dropTreeGLAccount.GLAccountID);
  }

  private void SaveDefaultGLAccountSetting(int expenseCode, int glCompanyID, int glAccountID)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      Database.Instance.QuerySP.PerformNonQuery("spFin_InsertDefaultExpenseGLAccountAssignment", (object) "@expensecode", (object) expenseCode, (object) "@glCompanyId", (object) glCompanyID, (object) "@glacctid", (object) glAccountID);
    }
    finally
    {
      this.GetExpenseDefaultAccounts();
      this.Cursor = Cursors.Default;
    }
  }

  private class ExpenseGLSetting
  {
    private int _glCompanyId;
    private int _expenseCode;
    private int _glAccountId;

    public ExpenseGLSetting(int glCompanyId, int expenseCode, int glAccountId)
    {
      this._glCompanyId = glCompanyId;
      this._expenseCode = expenseCode;
      this._glAccountId = glAccountId;
    }

    public int GLCompanyId => this._glCompanyId;

    public int ExpenseCode => this._expenseCode;

    public int GlAccountID => this._glAccountId;
  }
}
