// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormGenerateChart
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Analysis.Properties;
using MGASystems.IMS.Accounting.GeneralLedger.Forms;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

[TestForm]
public class FormGenerateChart : FormBase
{
  private readonly FormMasterAccounts _f;
  private IContainer components;
  private Panel panel2;
  private MGAButton buttonFinish;
  private MGAButton buttonCancel;
  private Label label4;
  private Panel panel1;
  private Label label2;
  private Label label1;
  private PictureBox pictureBox1;
  private MGATextBox textARThreshold;
  private Label label3;
  private Label label5;
  private MGATextBox textAPThreshold;
  private RadioButton radioUseEffectiveDate;
  private RadioButton radioUseBillingdate;
  private Label label51;
  private Label label57;
  private Panel panel4;
  private RadioButton radioFully;
  private RadioButton radioProportionally;
  private Panel panel3;
  private RadioButton radioReconPayables;
  private RadioButton radioReconReceivables;
  private Label label48;
  private Label label52;
  private RadioButton radioAccrualBasis;
  private RadioButton radioCashBasis;
  private Label label62;
  private Label label63;
  private Label label53;
  private Label label54;
  private Label label58;
  private Label label50;
  private Label label6;
  private Label label7;
  private MGASimpleComboBox comboOfficeLocation;
  private EllipsePanel progressPanel;
  private Label lblProgress;
  private UltraProgressBar pBar;
  private Panel panel5;
  private Panel panel6;

  public FormGenerateChart(FormMasterAccounts f)
  {
    this.InitializeComponent();
    this.GetOfficeLocations();
    this._f = f;
  }

  private void Save()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        this.BetterInvoke((Delegate) new FormGenerateChart.IntParamMethodHandler(this.SetProgressBarMax), (object) 1);
        this.BetterInvoke((Delegate) new FormGenerateChart.StringParamMethodHandler(this.SetLabelProgress), (object) "Creating chart of accounts header....");
        this.CreateChartOfAccountHeader();
        this.BetterInvoke((Delegate) new FormGenerateChart.IntParamMethodHandler(this.SetProgressCurrentValue), (object) 1);
        this.BetterInvoke((Delegate) new FormGenerateChart.StringParamMethodHandler(this.SetLabelProgress), (object) "Building accounts....");
        this.CreateGLAccounts();
        this.BetterInvoke((Delegate) new FormGenerateChart.IntParamMethodHandler(this.SetProgressBarMax), (object) 1);
        this.BetterInvoke((Delegate) new FormGenerateChart.StringParamMethodHandler(this.SetLabelProgress), (object) "Saving extended settings......");
        this.SaveExtendedSettings();
        this.BetterInvoke((Delegate) new FormGenerateChart.IntParamMethodHandler(this.SetProgressCurrentValue), (object) 1);
        this.BetterInvoke((Delegate) new FormGenerateChart.StringParamMethodHandler(this.SetLabelProgress), (object) "Chart of accounts created successfully!");
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        int num = (int) MessageBox.Show(ex.Message);
        throw;
      }
      e.Transaction.Commit();
      this.DialogResult = DialogResult.OK;
    }));
  }

  private void SaveCashAccrualSettings()
  {
    int num;
    if (this.radioAccrualBasis.Checked)
      num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetGLCompanyCommissionsIncomeAccount(@GlCompanyid)", new object[2]
      {
        (object) "@GlCompanyId",
        (object) (int) this.comboOfficeLocation.Value
      });
    else
      num = (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetGLCompanyCommissionsIncomeAccount(@GlCompanyid)", new object[2]
      {
        (object) "@GlCompanyId",
        (object) (int) this.comboOfficeLocation.Value
      });
    DefaultDatabase.ExecuteNonQuery("spFin_InsertAutomationSetting", new object[4]
    {
      (object) "@AcctRoleId",
      (object) "CCr",
      (object) "@glAcctId",
      (object) num
    });
  }

  private void CreateChartOfAccountHeader()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_GLMasterCreateChartHeader", new object[2]
    {
      (object) "@GLCompanyId",
      (object) (int) this.comboOfficeLocation.Value
    });
  }

  private void CreateGLAccounts()
  {
    this.BetterInvoke((Delegate) new FormGenerateChart.IntParamMethodHandler(this.SetProgressBarMax), (object) ((UltraGridBase) this._f.gridMasterAccounts).Rows.GetFilteredInNonGroupByRows().Length);
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this._f.gridMasterAccounts).Rows.GetFilteredInNonGroupByRows())
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Creating GL Account ");
      stringBuilder.Append(filteredInNonGroupByRow.Cells["GLAccountName"].Value);
      stringBuilder.Append("....");
      this.BetterInvoke((Delegate) new FormGenerateChart.StringParamMethodHandler(this.SetLabelProgress), (object) stringBuilder.ToString());
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_GLMasterCreateGLAccount", new object[6]
      {
        (object) "@GLCompanyId",
        (object) (int) this.comboOfficeLocation.Value,
        (object) "@GLMasterAccountId",
        (object) (int) filteredInNonGroupByRow.Cells["GLMasterId"].Value,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      });
      this.BetterInvoke((Delegate) new MethodInvoker(this.IncrementCurrentProgessValue));
    }
  }

  private void SaveExtendedSettings()
  {
    this.SaveCashAccrualSettings();
    this.SaveCommissionRecognitionSettings();
    this.SaveCommissionReconciliationSettings();
    this.SavePayablesWriteOffSettings();
    this.SaveReceivablesWriteOffSettings();
    this.SavePostDateConfigurationSettings();
  }

  private void SaveCommissionReconciliationSettings()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertExtendedSettings", new object[6]
    {
      (object) "@glcompanyid",
      (object) (int) this.comboOfficeLocation.Value,
      (object) "@setting",
      (object) "CommReconciliation",
      (object) "@settingnumvalue",
      (object) (this.radioReconReceivables.Checked ? 1.00M : 2.00M)
    });
  }

  private void SaveCommissionRecognitionSettings()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertExtendedSettings", new object[6]
    {
      (object) "@glcompanyid",
      (object) (int) this.comboOfficeLocation.Value,
      (object) "@setting",
      (object) "CommRecognition",
      (object) "@settingstringvalue",
      this.radioFully.Checked ? (object) "F" : (object) "P"
    });
  }

  private void SaveReceivablesWriteOffSettings()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertExtendedSettings", new object[6]
    {
      (object) "@glcompanyid",
      (object) (int) this.comboOfficeLocation.Value,
      (object) "@setting",
      (object) "AssetWriteOff",
      (object) "@settingnumvalue",
      (object) Decimal.Parse(((Control) this.textARThreshold).Text, NumberStyles.Currency)
    });
  }

  private void SavePayablesWriteOffSettings()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertExtendedSettings", new object[6]
    {
      (object) "@glcompanyid",
      (object) (int) this.comboOfficeLocation.Value,
      (object) "@setting",
      (object) "LiabilityWriteOff",
      (object) "@settingnumvalue",
      (object) Decimal.Parse(((Control) this.textAPThreshold).Text, NumberStyles.Currency)
    });
  }

  private void SavePostDateConfigurationSettings()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertExtendedSettings", new object[6]
    {
      (object) "@glcompanyid",
      (object) (int) this.comboOfficeLocation.Value,
      (object) "@setting",
      (object) "PostDateConfiguration",
      (object) "@settingstringvalue",
      this.radioUseBillingdate.Checked ? (object) "B" : (object) "E"
    });
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void buttonFinish_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    ((UltraGridBase) this._f.gridMasterAccounts).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    this.ToggleProgressVisible(true);
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) => this.Save());
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        this.ToggleProgressVisible(false);
        using (formAutomationAccounts automationAccounts = new formAutomationAccounts())
        {
          int num = (int) automationAccounts.ShowDialog();
        }
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void GetOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) DefaultDatabase.ExecuteDataSet("dbo.spFin_GetOfficesWithNoChart");
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
  }

  private void ToggleProgressVisible(bool value) => this.progressPanel.Visible = value;

  private void SetLabelProgress(string value)
  {
    this.lblProgress.Text = value;
    this.lblProgress.Refresh();
  }

  private void SetProgressBarMax(int value)
  {
    this.pBar.Maximum = value;
    this.pBar.Value = 0;
  }

  private void SetProgressCurrentValue(int value)
  {
    this.pBar.Value = value <= this.pBar.Maximum ? value : this.pBar.Maximum;
    ((Control) this.pBar).Refresh();
  }

  private void IncrementCurrentProgessValue()
  {
    if (this.pBar.Maximum >= this.pBar.Value + 1)
      ++this.pBar.Value;
    else
      this.pBar.Value = this.pBar.Maximum;
    ((Control) this.pBar).Refresh();
  }

  private bool VerifyForm()
  {
    if (!this.radioAccrualBasis.Checked && !this.radioCashBasis.Checked)
    {
      int num = (int) MessageBox.Show(Resources.CREATEERROR_CASHORACCRUAL, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.radioCashBasis.Checked)
    {
      if (!this.radioFully.Checked && !this.radioProportionally.Checked)
      {
        int num = (int) MessageBox.Show(Resources.CREATERRROR_FULLYORPRORPTIONAL, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (!this.radioReconPayables.Checked && !this.radioReconReceivables.Checked)
      {
        int num = (int) MessageBox.Show(Resources.CREATEERROR_PAYABLEORRECEIVABLE, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    if (string.IsNullOrEmpty(((Control) this.textAPThreshold).Text) || string.IsNullOrEmpty(((Control) this.textARThreshold).Text))
    {
      int num = (int) MessageBox.Show(Resources.CREATERROR_THRESHOLDSMISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Information.IsNumeric((object) ((Control) this.textAPThreshold).Text) || !Information.IsNumeric((object) ((Control) this.textARThreshold).Text))
    {
      int num = (int) MessageBox.Show(Resources.CREATEERROR_WRITEOFFMUSBENUMERDIC, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show(Resources.CREATEERROR_GLCOMPANYMISSING, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormGenerateChart));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.panel2 = new Panel();
    this.buttonFinish = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.label4 = new Label();
    this.panel1 = new Panel();
    this.label2 = new Label();
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.textARThreshold = new MGATextBox();
    this.label3 = new Label();
    this.label5 = new Label();
    this.textAPThreshold = new MGATextBox();
    this.radioUseEffectiveDate = new RadioButton();
    this.radioUseBillingdate = new RadioButton();
    this.label51 = new Label();
    this.label57 = new Label();
    this.panel4 = new Panel();
    this.radioFully = new RadioButton();
    this.radioProportionally = new RadioButton();
    this.panel3 = new Panel();
    this.radioReconPayables = new RadioButton();
    this.radioReconReceivables = new RadioButton();
    this.label48 = new Label();
    this.label52 = new Label();
    this.radioAccrualBasis = new RadioButton();
    this.radioCashBasis = new RadioButton();
    this.label62 = new Label();
    this.label63 = new Label();
    this.label53 = new Label();
    this.label54 = new Label();
    this.label58 = new Label();
    this.label50 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.progressPanel = new EllipsePanel();
    this.pBar = new UltraProgressBar();
    this.lblProgress = new Label();
    this.panel5 = new Panel();
    this.panel6 = new Panel();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.textARThreshold).BeginInit();
    ((ISupportInitialize) this.textAPThreshold).BeginInit();
    this.panel4.SuspendLayout();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.progressPanel.SuspendLayout();
    this.panel5.SuspendLayout();
    this.panel6.SuspendLayout();
    this.SuspendLayout();
    this.panel2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel2.Controls.Add((Control) this.buttonFinish);
    this.panel2.Controls.Add((Control) this.buttonCancel);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 425);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(924, 56);
    this.panel2.TabIndex = 21;
    ((Control) this.buttonFinish).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonFinish).Location = new Point(728, 20);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(88, 24);
    ((Control) this.buttonFinish).TabIndex = 0;
    ((Control) this.buttonFinish).Text = "Finish";
    ((UltraControlBase) this.buttonFinish).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonFinish).Click += new EventHandler(this.buttonFinish_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(824, 20);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.BorderStyle = BorderStyle.Fixed3D;
    this.label4.Dock = DockStyle.Top;
    this.label4.ForeColor = Color.Gray;
    this.label4.Location = new Point(0, 0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(924, 1);
    this.label4.TabIndex = 3;
    this.panel1.BackColor = Color.White;
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.pictureBox1);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(924, 71);
    this.panel1.TabIndex = 1;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Dock = DockStyle.Bottom;
    this.label2.ForeColor = Color.Gray;
    this.label2.Location = new Point(0, 70);
    this.label2.Name = "label2";
    this.label2.Size = new Size(924, 1);
    this.label2.TabIndex = 1;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(613, 37);
    this.label1.Name = "label1";
    this.label1.Size = new Size(305, 22);
    this.label1.TabIndex = 0;
    this.label1.Text = "Create A New Chart Of Accounts";
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(-34, -32);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(160 /*0xA0*/, 136);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textARThreshold).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textARThreshold).BackColor = Color.White;
    ((Control) this.textARThreshold).Location = new Point(497, 148);
    this.textARThreshold.MGAStyle = MGAStyles.Blue;
    ((Control) this.textARThreshold).Name = "textARThreshold";
    ((Control) this.textARThreshold).Size = new Size(159, 19);
    ((Control) this.textARThreshold).TabIndex = 14;
    ((UltraControlBase) this.textARThreshold).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textARThreshold).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(497, 132);
    this.label3.Name = "label3";
    this.label3.Size = new Size(159, 13);
    this.label3.TabIndex = 13;
    this.label3.Text = "Receivable Write-Off Threshold:";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(726, 132);
    this.label5.Name = "label5";
    this.label5.Size = new Size(143, 13);
    this.label5.TabIndex = 15;
    this.label5.Text = "Payable Write-Off Threshold:";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAPThreshold).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textAPThreshold).BackColor = Color.White;
    ((Control) this.textAPThreshold).Location = new Point(729, 148);
    this.textAPThreshold.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAPThreshold).Name = "textAPThreshold";
    ((Control) this.textAPThreshold).Size = new Size(159, 19);
    ((Control) this.textAPThreshold).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textAPThreshold).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAPThreshold).UseOsThemes = (DefaultableBoolean) 2;
    this.radioUseEffectiveDate.BackColor = Color.Transparent;
    this.radioUseEffectiveDate.Checked = true;
    this.radioUseEffectiveDate.FlatStyle = FlatStyle.Flat;
    this.radioUseEffectiveDate.Location = new Point(3, 24);
    this.radioUseEffectiveDate.Name = "radioUseEffectiveDate";
    this.radioUseEffectiveDate.Size = new Size(332, 24);
    this.radioUseEffectiveDate.TabIndex = 1;
    this.radioUseEffectiveDate.TabStop = true;
    this.radioUseEffectiveDate.Text = "I prefer to use the EFFECTIVE date of coverage.";
    this.radioUseEffectiveDate.UseVisualStyleBackColor = false;
    this.radioUseBillingdate.BackColor = Color.Transparent;
    this.radioUseBillingdate.FlatStyle = FlatStyle.Flat;
    this.radioUseBillingdate.Location = new Point(3, 3);
    this.radioUseBillingdate.Name = "radioUseBillingdate";
    this.radioUseBillingdate.Size = new Size(208 /*0xD0*/, 24);
    this.radioUseBillingdate.TabIndex = 0;
    this.radioUseBillingdate.Text = "I prefer to use the BILLING date.";
    this.radioUseBillingdate.UseVisualStyleBackColor = false;
    this.label51.BackColor = Color.Transparent;
    this.label51.Location = new Point(12, 195);
    this.label51.Name = "label51";
    this.label51.Size = new Size(464, 32 /*0x20*/);
    this.label51.TabIndex = 6;
    this.label51.Text = "Specify whether this chart of accounts should recoginize commissions at the time of receivables or payables.";
    this.label57.AutoSize = true;
    this.label57.BackColor = Color.Transparent;
    this.label57.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label57.Location = new Point(12, 300);
    this.label57.Name = "label57";
    this.label57.Size = new Size(224 /*0xE0*/, 14);
    this.label57.TabIndex = 8;
    this.label57.Text = "Commission Reconciliation Settings";
    this.panel4.BackColor = Color.Transparent;
    this.panel4.Controls.Add((Control) this.radioFully);
    this.panel4.Controls.Add((Control) this.radioProportionally);
    this.panel4.Location = new Point(15, 351);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(264, 52);
    this.panel4.TabIndex = 10;
    this.radioFully.BackColor = Color.Transparent;
    this.radioFully.FlatStyle = FlatStyle.Flat;
    this.radioFully.Location = new Point(8, 26);
    this.radioFully.Name = "radioFully";
    this.radioFully.Size = new Size(168, 17);
    this.radioFully.TabIndex = 1;
    this.radioFully.Text = "Reconcile commission fully.";
    this.radioFully.UseVisualStyleBackColor = false;
    this.radioProportionally.BackColor = Color.Transparent;
    this.radioProportionally.Checked = true;
    this.radioProportionally.FlatStyle = FlatStyle.Flat;
    this.radioProportionally.Location = new Point(8, 7);
    this.radioProportionally.Name = "radioProportionally";
    this.radioProportionally.Size = new Size(224 /*0xE0*/, 18);
    this.radioProportionally.TabIndex = 0;
    this.radioProportionally.TabStop = true;
    this.radioProportionally.Text = "Reconcile commission proportionally.";
    this.radioProportionally.UseVisualStyleBackColor = false;
    this.panel3.BackColor = Color.Transparent;
    this.panel3.Controls.Add((Control) this.radioReconPayables);
    this.panel3.Controls.Add((Control) this.radioReconReceivables);
    this.panel3.Location = new Point(15, 230);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(366, 57);
    this.panel3.TabIndex = 7;
    this.radioReconPayables.BackColor = Color.Transparent;
    this.radioReconPayables.FlatStyle = FlatStyle.Flat;
    this.radioReconPayables.Location = new Point(8, 25);
    this.radioReconPayables.Name = "radioReconPayables";
    this.radioReconPayables.Size = new Size(355, 24);
    this.radioReconPayables.TabIndex = 1;
    this.radioReconPayables.Text = "Recognize commission at the time of payables.";
    this.radioReconPayables.UseVisualStyleBackColor = false;
    this.radioReconReceivables.BackColor = Color.Transparent;
    this.radioReconReceivables.Checked = true;
    this.radioReconReceivables.FlatStyle = FlatStyle.Flat;
    this.radioReconReceivables.Location = new Point(8, 5);
    this.radioReconReceivables.Name = "radioReconReceivables";
    this.radioReconReceivables.Size = new Size(329, 24);
    this.radioReconReceivables.TabIndex = 0;
    this.radioReconReceivables.TabStop = true;
    this.radioReconReceivables.Text = "Recognize commission at the time of receivables.";
    this.radioReconReceivables.UseVisualStyleBackColor = false;
    this.label48.AutoSize = true;
    this.label48.BackColor = Color.Transparent;
    this.label48.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label48.Location = new Point(12, 179);
    this.label48.Name = "label48";
    this.label48.Size = new Size(224 /*0xE0*/, 14);
    this.label48.TabIndex = 5;
    this.label48.Text = "Commission Reconciliation Settings";
    this.label52.BackColor = Color.Transparent;
    this.label52.Location = new Point(12, 316);
    this.label52.Name = "label52";
    this.label52.Size = new Size(450, 32 /*0x20*/);
    this.label52.TabIndex = 9;
    this.label52.Text = "Specify whether this chart of accounts should reconcile commissions proportionally based on the AR received or fully.";
    this.radioAccrualBasis.BackColor = Color.Transparent;
    this.radioAccrualBasis.FlatStyle = FlatStyle.Flat;
    this.radioAccrualBasis.Location = new Point(8, 24);
    this.radioAccrualBasis.Name = "radioAccrualBasis";
    this.radioAccrualBasis.Size = new Size(264, 24);
    this.radioAccrualBasis.TabIndex = 1;
    this.radioAccrualBasis.Text = "This chart of accounts is on a ACCRUAL basis.";
    this.radioAccrualBasis.UseVisualStyleBackColor = false;
    this.radioCashBasis.BackColor = Color.Transparent;
    this.radioCashBasis.Checked = true;
    this.radioCashBasis.FlatStyle = FlatStyle.Flat;
    this.radioCashBasis.Location = new Point(8, 3);
    this.radioCashBasis.Name = "radioCashBasis";
    this.radioCashBasis.Size = new Size(264, 24);
    this.radioCashBasis.TabIndex = 0;
    this.radioCashBasis.TabStop = true;
    this.radioCashBasis.Text = "This chart of accounts is on a CASH basis.";
    this.radioCashBasis.UseVisualStyleBackColor = false;
    this.label62.AutoSize = true;
    this.label62.BackColor = Color.Transparent;
    this.label62.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label62.Location = new Point(12, 74);
    this.label62.Name = "label62";
    this.label62.Size = new Size(109, 14);
    this.label62.TabIndex = 2;
    this.label62.Text = "Cash Or Accrual?";
    this.label63.BackColor = Color.Transparent;
    this.label63.Location = new Point(12, 93);
    this.label63.Name = "label63";
    this.label63.Size = new Size(485, 32 /*0x20*/);
    this.label63.TabIndex = 3;
    this.label63.Text = "Please specify your GL companies accounting methodology. This important setting will determine when the accounting system will recognize commissions for this chart of accounts. ";
    this.label53.AutoSize = true;
    this.label53.BackColor = Color.Transparent;
    this.label53.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label53.Location = new Point(498, 75);
    this.label53.Name = "label53";
    this.label53.Size = new Size(134, 14);
    this.label53.TabIndex = 11;
    this.label53.Text = "Write-Off Thresholds";
    this.label54.BackColor = Color.Transparent;
    this.label54.Location = new Point(497, 94);
    this.label54.Name = "label54";
    this.label54.Size = new Size(430, 32 /*0x20*/);
    this.label54.TabIndex = 12;
    this.label54.Text = "Specify the amount of a receivable and payable respectively, users with security rights can write-off without administrative override. ";
    this.label58.BackColor = Color.Transparent;
    this.label58.Location = new Point(498, 193);
    this.label58.Name = "label58";
    this.label58.Size = new Size(414, 40);
    this.label58.TabIndex = 18;
    this.label58.Text = "Specify whether you would prefer the system to use the billing date of the invoice or the effective date of coverage as the posting date of the invoice transactions in the ledger.";
    this.label50.AutoSize = true;
    this.label50.BackColor = Color.Transparent;
    this.label50.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label50.Location = new Point(498, 176 /*0xB0*/);
    this.label50.Name = "label50";
    this.label50.Size = new Size(210, 14);
    this.label50.TabIndex = 17;
    this.label50.Text = "Invoice Posting Date Preferences";
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(494, 316);
    this.label6.Name = "label6";
    this.label6.Size = new Size(429, 19);
    this.label6.TabIndex = 21;
    this.label6.Text = "Specify which office location to create the new chart of accounts for.";
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label7.Location = new Point(494, 300);
    this.label7.Name = "label7";
    this.label7.Size = new Size(140, 14);
    this.label7.TabIndex = 20;
    this.label7.Text = "Select Office Location";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(500, 337);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(316, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 22;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.progressPanel.BackColor = Color.WhiteSmoke;
    this.progressPanel.BorderColor = Color.DimGray;
    this.progressPanel.Controls.Add((Control) this.pBar);
    this.progressPanel.Controls.Add((Control) this.lblProgress);
    this.progressPanel.Location = new Point(497, 366);
    this.progressPanel.Name = "progressPanel";
    this.progressPanel.Size = new Size(415, 44);
    this.progressPanel.TabIndex = 23;
    this.progressPanel.Visible = false;
    ((AppearanceBase) appearance5).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance5).BackColor2 = Color.White;
    ((AppearanceBase) appearance5).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 20;
    this.pBar.FillAppearance = (AppearanceBase) appearance5;
    ((Control) this.pBar).Location = new Point(13, 22);
    ((Control) this.pBar).Name = "pBar";
    ((Control) this.pBar).Size = new Size(396, 14);
    ((Control) this.pBar).TabIndex = 1;
    ((Control) this.pBar).Text = "[Formatted]";
    this.lblProgress.AutoSize = true;
    this.lblProgress.ForeColor = Color.DarkSlateGray;
    this.lblProgress.Location = new Point(12, 5);
    this.lblProgress.Name = "lblProgress";
    this.lblProgress.Size = new Size(85, 13);
    this.lblProgress.TabIndex = 0;
    this.lblProgress.Text = "Creating chart....";
    this.panel5.BackColor = Color.Transparent;
    this.panel5.Controls.Add((Control) this.radioAccrualBasis);
    this.panel5.Controls.Add((Control) this.radioCashBasis);
    this.panel5.Location = new Point(15, 119);
    this.panel5.Name = "panel5";
    this.panel5.Size = new Size(366, 57);
    this.panel5.TabIndex = 4;
    this.panel6.BackColor = Color.Transparent;
    this.panel6.Controls.Add((Control) this.radioUseBillingdate);
    this.panel6.Controls.Add((Control) this.radioUseEffectiveDate);
    this.panel6.Location = new Point(501, 238);
    this.panel6.Name = "panel6";
    this.panel6.Size = new Size(368, 57);
    this.panel6.TabIndex = 19;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(924, 481);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label58);
    this.Controls.Add((Control) this.panel6);
    this.Controls.Add((Control) this.panel5);
    this.Controls.Add((Control) this.progressPanel);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.textAPThreshold);
    this.Controls.Add((Control) this.textARThreshold);
    this.Controls.Add((Control) this.label50);
    this.Controls.Add((Control) this.label53);
    this.Controls.Add((Control) this.label54);
    this.Controls.Add((Control) this.label62);
    this.Controls.Add((Control) this.label63);
    this.Controls.Add((Control) this.label51);
    this.Controls.Add((Control) this.label57);
    this.Controls.Add((Control) this.panel4);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.label48);
    this.Controls.Add((Control) this.label52);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panel2);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximumSize = new Size(930, 509);
    this.MinimumSize = new Size(930, 509);
    this.Name = nameof (FormGenerateChart);
    this.SizeGripStyle = SizeGripStyle.Hide;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Generate Chart Of Accounts";
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.textARThreshold).EndInit();
    ((ISupportInitialize) this.textAPThreshold).EndInit();
    this.panel4.ResumeLayout(false);
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.progressPanel.ResumeLayout(false);
    this.progressPanel.PerformLayout();
    this.panel5.ResumeLayout(false);
    this.panel6.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private delegate void StringParamMethodHandler(string value);

  private delegate void IntParamMethodHandler(int value);
}
