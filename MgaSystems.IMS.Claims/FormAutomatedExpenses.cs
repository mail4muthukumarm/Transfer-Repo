// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormAutomatedExpenses
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormAutomatedExpenses : FormBase
{
  private IContainer components;
  private MGACheckBox checkClaim;
  private MGATextBox textClaim_Hours;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel4;
  private MGATextBox textClaim_Rate;
  private MGACheckBox checkClaimant;
  private MGACheckBox checkReserve;
  private MGACheckBox checkPayment;
  private Panel panelClaimOptions;
  private MGATextBox textClaim_FlatAmount;
  private UltraLabel ultraLabel1;
  private RadioButton optionClaim_FlatAmount;
  private RadioButton optionClaim_Hourly;
  private Panel panelClaimantOptions;
  private MGATextBox textClaimant_FlatAmount;
  private UltraLabel ultraLabel2;
  private RadioButton optionClaimant_FlatAmount;
  private RadioButton optionClaimant_Hourly;
  private MGATextBox textClaimant_Hours;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel6;
  private MGATextBox textClaimant_Rate;
  private Panel panelReserveOptions;
  private MGATextBox textReserve_FlatAmount;
  private UltraLabel ultraLabel7;
  private RadioButton optionReserve_FlatAmount;
  private RadioButton optionReserve_Hourly;
  private MGATextBox textReserve_Hours;
  private UltraLabel ultraLabel8;
  private UltraLabel ultraLabel9;
  private MGATextBox textReserve_Rate;
  private Panel panelPaymentOptions;
  private MGATextBox textPayment_FlatAmount;
  private UltraLabel ultraLabel10;
  private RadioButton optionPayment_FlatAmount;
  private RadioButton optionPayment_Hourly;
  private MGATextBox textPayment_Hours;
  private UltraLabel ultraLabel11;
  private UltraLabel ultraLabel12;
  private MGATextBox textPayment_Rate;
  private UltraToolTipManager ultraToolTipManager1;
  private Panel panelCloseClaimOptions;
  private MGATextBox textCloseClaim_FlatAmount;
  private UltraLabel ultraLabel13;
  private RadioButton optionCloseClaim_FlatAmount;
  private RadioButton optionCloseClaim_Hourly;
  private MGATextBox textCloseClaim_Hours;
  private UltraLabel ultraLabel14;
  private UltraLabel ultraLabel15;
  private MGATextBox textCloseClaim_Rate;
  private MGACheckBox checkCloseClaim;
  protected MGAButton buttonSave;
  protected MGAButton buttonCancel;

  public FormAutomatedExpenses()
  {
    this.InitializeComponent();
    this.Cursor = MgaCursors.Default;
    this.InitializeForm();
  }

  private void InitializeForm()
  {
    if (this.DesignMode)
      return;
    this.SetPanelBindings();
    this.SetControlBindings();
    this.LoadCurrentSettings();
  }

  private void SetPanelBindings()
  {
    this.panelClaimOptions.DataBindings.Add("Enabled", (object) this.checkClaim, "Checked");
    this.panelClaimantOptions.DataBindings.Add("Enabled", (object) this.checkClaimant, "Checked");
    this.panelReserveOptions.DataBindings.Add("Enabled", (object) this.checkReserve, "Checked");
    this.panelPaymentOptions.DataBindings.Add("Enabled", (object) this.checkPayment, "Checked");
    this.panelCloseClaimOptions.DataBindings.Add("Enabled", (object) this.checkCloseClaim, "Checked");
  }

  private void SetControlBindings()
  {
    ((Control) this.textClaim_FlatAmount).DataBindings.Add("Enabled", (object) this.optionClaim_FlatAmount, "Checked");
    ((Control) this.textClaim_Hours).DataBindings.Add("Enabled", (object) this.optionClaim_Hourly, "Checked");
    ((Control) this.textClaim_Rate).DataBindings.Add("Enabled", (object) this.optionClaim_Hourly, "Checked");
    ((Control) this.textClaimant_FlatAmount).DataBindings.Add("Enabled", (object) this.optionClaimant_FlatAmount, "Checked");
    ((Control) this.textClaimant_Hours).DataBindings.Add("Enabled", (object) this.optionClaimant_Hourly, "Checked");
    ((Control) this.textClaimant_Rate).DataBindings.Add("Enabled", (object) this.optionClaimant_Hourly, "Checked");
    ((Control) this.textReserve_FlatAmount).DataBindings.Add("Enabled", (object) this.optionReserve_FlatAmount, "Checked");
    ((Control) this.textReserve_Hours).DataBindings.Add("Enabled", (object) this.optionReserve_Hourly, "Checked");
    ((Control) this.textReserve_Rate).DataBindings.Add("Enabled", (object) this.optionReserve_Hourly, "Checked");
    ((Control) this.textPayment_FlatAmount).DataBindings.Add("Enabled", (object) this.optionPayment_FlatAmount, "Checked");
    ((Control) this.textPayment_Hours).DataBindings.Add("Enabled", (object) this.optionPayment_Hourly, "Checked");
    ((Control) this.textPayment_Rate).DataBindings.Add("Enabled", (object) this.optionPayment_Hourly, "Checked");
    ((Control) this.textCloseClaim_FlatAmount).DataBindings.Add("Enabled", (object) this.optionCloseClaim_FlatAmount, "Checked");
    ((Control) this.textCloseClaim_Hours).DataBindings.Add("Enabled", (object) this.optionCloseClaim_Hourly, "Checked");
    ((Control) this.textCloseClaim_Rate).DataBindings.Add("Enabled", (object) this.optionCloseClaim_Hourly, "Checked");
  }

  protected virtual void LoadCurrentSettings()
  {
    this.Cursor = MgaCursors.WaitCursor;
    DataTable dataTable;
    try
    {
      dataTable = DefaultDatabase.ExecuteDataTable("spClaims_GetAutomationSettings");
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    if (dataTable == null || dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      switch (row["AutomationCode"].ToString().Trim())
      {
        case "CLM":
          ((UltraToggleEditorBase) this.checkClaim).Checked = (bool) row["Active"];
          if ((bool) row["Active"])
          {
            if ((Decimal) row["FlatAmount"] != 0M)
            {
              this.optionClaim_FlatAmount.Checked = true;
              ((Control) this.textClaim_FlatAmount).Text = ((Decimal) row["FlatAmount"]).ToString("c");
              continue;
            }
            this.optionClaim_Hourly.Checked = true;
            ((Control) this.textClaim_Hours).Text = row["Hours"].ToString();
            ((Control) this.textClaim_Rate).Text = ((Decimal) row["Rate"]).ToString("c");
            continue;
          }
          continue;
        case "CLMT":
          ((UltraToggleEditorBase) this.checkClaimant).Checked = (bool) row["Active"];
          if ((bool) row["Active"])
          {
            if ((Decimal) row["FlatAmount"] != 0M)
            {
              this.optionClaimant_FlatAmount.Checked = true;
              ((Control) this.textClaimant_FlatAmount).Text = ((Decimal) row["FlatAmount"]).ToString("c");
              continue;
            }
            this.optionClaimant_Hourly.Checked = true;
            ((Control) this.textClaimant_Hours).Text = row["Hours"].ToString();
            ((Control) this.textClaimant_Rate).Text = ((Decimal) row["Rate"]).ToString("c");
            continue;
          }
          continue;
        case "RESV":
          ((UltraToggleEditorBase) this.checkReserve).Checked = (bool) row["Active"];
          if ((bool) row["Active"])
          {
            if ((Decimal) row["FlatAmount"] != 0M)
            {
              this.optionReserve_FlatAmount.Checked = true;
              ((Control) this.textReserve_FlatAmount).Text = ((Decimal) row["FlatAmount"]).ToString("c");
              continue;
            }
            this.optionReserve_Hourly.Checked = true;
            ((Control) this.textReserve_Hours).Text = row["Hours"].ToString();
            ((Control) this.textReserve_Rate).Text = ((Decimal) row["Rate"]).ToString("c");
            continue;
          }
          continue;
        case "PYMT":
          ((UltraToggleEditorBase) this.checkPayment).Checked = (bool) row["Active"];
          if ((bool) row["Active"])
          {
            if ((Decimal) row["FlatAmount"] != 0M)
            {
              this.optionPayment_FlatAmount.Checked = true;
              ((Control) this.textPayment_FlatAmount).Text = ((Decimal) row["FlatAmount"]).ToString("c");
              continue;
            }
            this.optionPayment_Hourly.Checked = true;
            ((Control) this.textPayment_Hours).Text = row["Hours"].ToString();
            ((Control) this.textPayment_Rate).Text = ((Decimal) row["Rate"]).ToString("c");
            continue;
          }
          continue;
        case "CLCL":
          ((UltraToggleEditorBase) this.checkCloseClaim).Checked = (bool) row["Active"];
          if ((bool) row["Active"])
          {
            if ((Decimal) row["FlatAmount"] != 0M)
            {
              this.optionCloseClaim_FlatAmount.Checked = true;
              ((Control) this.textCloseClaim_FlatAmount).Text = ((Decimal) row["FlatAmount"]).ToString("c");
              continue;
            }
            this.optionCloseClaim_Hourly.Checked = true;
            ((Control) this.textCloseClaim_Hours).Text = row["Hours"].ToString();
            ((Control) this.textCloseClaim_Rate).Text = ((Decimal) row["Rate"]).ToString("c");
            continue;
          }
          continue;
        default:
          continue;
      }
    }
  }

  protected virtual void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void SaveAutomationSetting(
    string automationCode,
    bool active,
    Decimal flatAmount,
    Decimal hours,
    Decimal rate)
  {
    if (flatAmount == 0M)
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateAutomationSetting", new object[8]
      {
        (object) "@AutomationCode",
        (object) automationCode,
        (object) "@Active",
        (object) active,
        (object) "@Hours",
        (object) hours,
        (object) "@Rate",
        (object) rate
      });
    else
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateAutomationSetting", new object[6]
      {
        (object) "@AutomationCode",
        (object) automationCode,
        (object) "@Active",
        (object) active,
        (object) "@FlatAmount",
        (object) flatAmount
      });
  }

  protected virtual void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateSettings())
      return;
    this.SaveAutomationSetting("CLM", ((UltraToggleEditorBase) this.checkClaim).Checked, !((UltraToggleEditorBase) this.checkClaim).Checked || !this.optionClaim_FlatAmount.Checked ? 0M : Decimal.Parse(((Control) this.textClaim_FlatAmount).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkClaim).Checked || !this.optionClaim_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textClaim_Hours).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkClaim).Checked || !this.optionClaim_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textClaim_Rate).Text, NumberStyles.Any));
    this.SaveAutomationSetting("CLMT", ((UltraToggleEditorBase) this.checkClaimant).Checked, !((UltraToggleEditorBase) this.checkClaimant).Checked || !this.optionClaimant_FlatAmount.Checked ? 0M : Decimal.Parse(((Control) this.textClaimant_FlatAmount).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkClaimant).Checked || !this.optionClaimant_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textClaimant_Hours).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkClaimant).Checked || !this.optionClaimant_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textClaimant_Rate).Text, NumberStyles.Any));
    this.SaveAutomationSetting("RESV", ((UltraToggleEditorBase) this.checkReserve).Checked, !((UltraToggleEditorBase) this.checkReserve).Checked || !this.optionReserve_FlatAmount.Checked ? 0M : Decimal.Parse(((Control) this.textReserve_FlatAmount).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkReserve).Checked || !this.optionReserve_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textReserve_Hours).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkReserve).Checked || !this.optionReserve_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textReserve_Rate).Text, NumberStyles.Any));
    this.SaveAutomationSetting("PYMT", ((UltraToggleEditorBase) this.checkPayment).Checked, !((UltraToggleEditorBase) this.checkPayment).Checked || !this.optionPayment_FlatAmount.Checked ? 0M : Decimal.Parse(((Control) this.textPayment_FlatAmount).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkPayment).Checked || !this.optionPayment_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textPayment_Hours).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkPayment).Checked || !this.optionPayment_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textPayment_Rate).Text, NumberStyles.Any));
    this.SaveAutomationSetting("CLCL", ((UltraToggleEditorBase) this.checkCloseClaim).Checked, !((UltraToggleEditorBase) this.checkCloseClaim).Checked || !this.optionCloseClaim_FlatAmount.Checked ? 0M : Decimal.Parse(((Control) this.textCloseClaim_FlatAmount).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkCloseClaim).Checked || !this.optionCloseClaim_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textCloseClaim_Hours).Text, NumberStyles.Any), !((UltraToggleEditorBase) this.checkCloseClaim).Checked || !this.optionCloseClaim_Hourly.Checked ? 0M : Decimal.Parse(((Control) this.textCloseClaim_Rate).Text, NumberStyles.Any));
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected virtual bool ValidateSettings()
  {
    Decimal result;
    if (((UltraToggleEditorBase) this.checkClaim).Checked)
    {
      if (this.optionClaim_FlatAmount.Checked)
      {
        if (string.IsNullOrEmpty(((Control) this.textClaim_FlatAmount).Text) || !Decimal.TryParse(((Control) this.textClaim_FlatAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_FLATAMOUNTERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textClaim_FlatAmount).Focus();
          return false;
        }
      }
      else
      {
        if (string.IsNullOrEmpty(((Control) this.textClaim_Hours).Text) || !Decimal.TryParse(((Control) this.textClaim_Hours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_HOURERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textClaim_Hours).Focus();
          return false;
        }
        if (string.IsNullOrEmpty(((Control) this.textClaim_Rate).Text) || !Decimal.TryParse(((Control) this.textClaim_Rate).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_RATEERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textClaim_Rate).Focus();
          return false;
        }
      }
    }
    if (((UltraToggleEditorBase) this.checkClaimant).Checked)
    {
      if (this.optionClaimant_FlatAmount.Checked)
      {
        if (string.IsNullOrEmpty(((Control) this.textClaimant_FlatAmount).Text) || !Decimal.TryParse(((Control) this.textClaimant_FlatAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_FLATAMOUNTERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textClaimant_FlatAmount).Focus();
          return false;
        }
      }
      else
      {
        if (string.IsNullOrEmpty(((Control) this.textClaimant_Hours).Text) || !Decimal.TryParse(((Control) this.textClaimant_Hours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_HOURERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textClaimant_Hours).Focus();
          return false;
        }
        if (string.IsNullOrEmpty(((Control) this.textClaimant_Rate).Text) || !Decimal.TryParse(((Control) this.textClaimant_Rate).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_RATEERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textClaimant_Rate).Focus();
          return false;
        }
      }
    }
    if (((UltraToggleEditorBase) this.checkReserve).Checked)
    {
      if (this.optionReserve_FlatAmount.Checked)
      {
        if (string.IsNullOrEmpty(((Control) this.textReserve_FlatAmount).Text) || !Decimal.TryParse(((Control) this.textReserve_FlatAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_FLATAMOUNTERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textReserve_FlatAmount).Focus();
          return false;
        }
      }
      else
      {
        if (string.IsNullOrEmpty(((Control) this.textReserve_Hours).Text) || !Decimal.TryParse(((Control) this.textReserve_Hours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_HOURERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textReserve_Hours).Focus();
          return false;
        }
        if (string.IsNullOrEmpty(((Control) this.textReserve_Rate).Text) || !Decimal.TryParse(((Control) this.textReserve_Rate).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_RATEERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textReserve_Rate).Focus();
          return false;
        }
      }
    }
    if (((UltraToggleEditorBase) this.checkPayment).Checked)
    {
      if (this.optionPayment_FlatAmount.Checked)
      {
        if (string.IsNullOrEmpty(((Control) this.textPayment_FlatAmount).Text) || !Decimal.TryParse(((Control) this.textPayment_FlatAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_FLATAMOUNTERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textPayment_FlatAmount).Focus();
          return false;
        }
      }
      else
      {
        if (string.IsNullOrEmpty(((Control) this.textPayment_Hours).Text) || !Decimal.TryParse(((Control) this.textPayment_Hours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_HOURERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textPayment_Hours).Focus();
          return false;
        }
        if (string.IsNullOrEmpty(((Control) this.textPayment_Rate).Text) || !Decimal.TryParse(((Control) this.textPayment_Rate).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_RATEERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textPayment_Rate).Focus();
          return false;
        }
      }
    }
    if (((UltraToggleEditorBase) this.checkCloseClaim).Checked)
    {
      if (this.optionCloseClaim_FlatAmount.Checked)
      {
        if (string.IsNullOrEmpty(((Control) this.textCloseClaim_FlatAmount).Text) || !Decimal.TryParse(((Control) this.textCloseClaim_FlatAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_FLATAMOUNTERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textCloseClaim_FlatAmount).Focus();
          return false;
        }
      }
      else
      {
        if (string.IsNullOrEmpty(((Control) this.textCloseClaim_Hours).Text) || !Decimal.TryParse(((Control) this.textCloseClaim_Hours).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_HOURERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textCloseClaim_Hours).Focus();
          return false;
        }
        if (string.IsNullOrEmpty(((Control) this.textCloseClaim_Rate).Text) || !Decimal.TryParse(((Control) this.textCloseClaim_Rate).Text, NumberStyles.Any, (IFormatProvider) null, out result))
        {
          int num = (int) MessageBox.Show(Resources.EXPENSEAUTOMATION_RATEERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textCloseClaim_Rate).Focus();
          return false;
        }
      }
    }
    return true;
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
    UltraToolTipInfo ultraToolTipInfo1 = new UltraToolTipInfo("Check this box to enable this expense automation.", (ToolTipImage) 3, "Enable Expense Automation On Claim Creation", (DefaultableBoolean) 0);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo2 = new UltraToolTipInfo("Check this box to enable this expense automation.", (ToolTipImage) 3, "Enable Expense Automation On Claimant Creation", (DefaultableBoolean) 0);
    Appearance appearance5 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo3 = new UltraToolTipInfo("Check this box to enable this expense automation.", (ToolTipImage) 3, "Enable Expense Automation On Reserve Creation", (DefaultableBoolean) 0);
    Appearance appearance6 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo4 = new UltraToolTipInfo("Check this box to enable this expense automation.", (ToolTipImage) 3, "Enable Expense Automation On Payment Creation", (DefaultableBoolean) 0);
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo5 = new UltraToolTipInfo("Check this box to enable this expense automation.", (ToolTipImage) 3, "Enable Expense Automation On Claimant Creation", (DefaultableBoolean) 0);
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    this.checkClaim = new MGACheckBox();
    this.textClaim_Hours = new MGATextBox();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.textClaim_Rate = new MGATextBox();
    this.checkClaimant = new MGACheckBox();
    this.checkReserve = new MGACheckBox();
    this.checkPayment = new MGACheckBox();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.panelClaimOptions = new Panel();
    this.textClaim_FlatAmount = new MGATextBox();
    this.ultraLabel1 = new UltraLabel();
    this.optionClaim_FlatAmount = new RadioButton();
    this.optionClaim_Hourly = new RadioButton();
    this.panelClaimantOptions = new Panel();
    this.textClaimant_FlatAmount = new MGATextBox();
    this.ultraLabel2 = new UltraLabel();
    this.optionClaimant_FlatAmount = new RadioButton();
    this.optionClaimant_Hourly = new RadioButton();
    this.textClaimant_Hours = new MGATextBox();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.textClaimant_Rate = new MGATextBox();
    this.panelReserveOptions = new Panel();
    this.textReserve_FlatAmount = new MGATextBox();
    this.ultraLabel7 = new UltraLabel();
    this.optionReserve_FlatAmount = new RadioButton();
    this.optionReserve_Hourly = new RadioButton();
    this.textReserve_Hours = new MGATextBox();
    this.ultraLabel8 = new UltraLabel();
    this.ultraLabel9 = new UltraLabel();
    this.textReserve_Rate = new MGATextBox();
    this.panelPaymentOptions = new Panel();
    this.textPayment_FlatAmount = new MGATextBox();
    this.ultraLabel10 = new UltraLabel();
    this.optionPayment_FlatAmount = new RadioButton();
    this.optionPayment_Hourly = new RadioButton();
    this.textPayment_Hours = new MGATextBox();
    this.ultraLabel11 = new UltraLabel();
    this.ultraLabel12 = new UltraLabel();
    this.textPayment_Rate = new MGATextBox();
    this.ultraToolTipManager1 = new UltraToolTipManager(this.components);
    this.checkCloseClaim = new MGACheckBox();
    this.panelCloseClaimOptions = new Panel();
    this.textCloseClaim_FlatAmount = new MGATextBox();
    this.ultraLabel13 = new UltraLabel();
    this.optionCloseClaim_FlatAmount = new RadioButton();
    this.optionCloseClaim_Hourly = new RadioButton();
    this.textCloseClaim_Hours = new MGATextBox();
    this.ultraLabel14 = new UltraLabel();
    this.ultraLabel15 = new UltraLabel();
    this.textCloseClaim_Rate = new MGATextBox();
    ((ISupportInitialize) this.checkClaim).BeginInit();
    ((ISupportInitialize) this.textClaim_Hours).BeginInit();
    ((ISupportInitialize) this.textClaim_Rate).BeginInit();
    ((ISupportInitialize) this.checkClaimant).BeginInit();
    ((ISupportInitialize) this.checkReserve).BeginInit();
    ((ISupportInitialize) this.checkPayment).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panelClaimOptions.SuspendLayout();
    ((ISupportInitialize) this.textClaim_FlatAmount).BeginInit();
    this.panelClaimantOptions.SuspendLayout();
    ((ISupportInitialize) this.textClaimant_FlatAmount).BeginInit();
    ((ISupportInitialize) this.textClaimant_Hours).BeginInit();
    ((ISupportInitialize) this.textClaimant_Rate).BeginInit();
    this.panelReserveOptions.SuspendLayout();
    ((ISupportInitialize) this.textReserve_FlatAmount).BeginInit();
    ((ISupportInitialize) this.textReserve_Hours).BeginInit();
    ((ISupportInitialize) this.textReserve_Rate).BeginInit();
    this.panelPaymentOptions.SuspendLayout();
    ((ISupportInitialize) this.textPayment_FlatAmount).BeginInit();
    ((ISupportInitialize) this.textPayment_Hours).BeginInit();
    ((ISupportInitialize) this.textPayment_Rate).BeginInit();
    ((ISupportInitialize) this.checkCloseClaim).BeginInit();
    this.panelCloseClaimOptions.SuspendLayout();
    ((ISupportInitialize) this.textCloseClaim_FlatAmount).BeginInit();
    ((ISupportInitialize) this.textCloseClaim_Hours).BeginInit();
    ((ISupportInitialize) this.textCloseClaim_Rate).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaim).Appearance = (AppearanceBase) appearance1;
    ((Control) this.checkClaim).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaim).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaim).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkClaim).Location = new Point(17, 14);
    this.checkClaim.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkClaim).Name = "checkClaim";
    ((Control) this.checkClaim).Size = new Size(120, 19);
    ((Control) this.checkClaim).TabIndex = 0;
    ((Control) this.checkClaim).Text = "Create Claim";
    ultraToolTipInfo1.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo1.ToolTipText = "Check this box to enable this expense automation.";
    ultraToolTipInfo1.ToolTipTitle = "Enable Expense Automation On Claim Creation";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.checkClaim, ultraToolTipInfo1);
    ((UltraControlBase) this.checkClaim).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkClaim).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textClaim_Hours).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textClaim_Hours).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textClaim_Hours).BackColor = Color.White;
    ((Control) this.textClaim_Hours).Location = new Point(75, 75);
    this.textClaim_Hours.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaim_Hours).Name = "textClaim_Hours";
    ((Control) this.textClaim_Hours).Size = new Size(75, 20);
    ((Control) this.textClaim_Hours).TabIndex = 5;
    ((UltraControlBase) this.textClaim_Hours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaim_Hours).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(25, 100);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel3).TabIndex = 6;
    ((Control) this.ultraLabel3).Text = "Rate:";
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(25, 75);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(37, 15);
    ((Control) this.ultraLabel4).TabIndex = 4;
    ((Control) this.ultraLabel4).Text = "Hours:";
    ((Control) this.textClaim_Rate).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textClaim_Rate).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textClaim_Rate).BackColor = Color.White;
    ((Control) this.textClaim_Rate).Location = new Point(75, 100);
    this.textClaim_Rate.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaim_Rate).Name = "textClaim_Rate";
    ((Control) this.textClaim_Rate).Size = new Size(75, 20);
    ((Control) this.textClaim_Rate).TabIndex = 7;
    ((UltraControlBase) this.textClaim_Rate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaim_Rate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkClaimant).Appearance = (AppearanceBase) appearance4;
    ((Control) this.checkClaimant).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimant).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkClaimant).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkClaimant).Location = new Point(185, 14);
    this.checkClaimant.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkClaimant).Name = "checkClaimant";
    ((Control) this.checkClaimant).Size = new Size(120, 19);
    ((Control) this.checkClaimant).TabIndex = 2;
    ((Control) this.checkClaimant).Text = "Create Claimant";
    ultraToolTipInfo2.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo2.ToolTipText = "Check this box to enable this expense automation.";
    ultraToolTipInfo2.ToolTipTitle = "Enable Expense Automation On Claimant Creation";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.checkClaimant, ultraToolTipInfo2);
    ((UltraControlBase) this.checkClaimant).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkClaimant).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkReserve).Appearance = (AppearanceBase) appearance5;
    ((Control) this.checkReserve).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkReserve).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkReserve).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkReserve).Location = new Point(17, 177);
    this.checkReserve.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkReserve).Name = "checkReserve";
    ((Control) this.checkReserve).Size = new Size(120, 19);
    ((Control) this.checkReserve).TabIndex = 4;
    ((Control) this.checkReserve).Text = "Create Reserve";
    ultraToolTipInfo3.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo3.ToolTipText = "Check this box to enable this expense automation.";
    ultraToolTipInfo3.ToolTipTitle = "Enable Expense Automation On Reserve Creation";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.checkReserve, ultraToolTipInfo3);
    ((UltraControlBase) this.checkReserve).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkReserve).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkPayment).Appearance = (AppearanceBase) appearance6;
    ((Control) this.checkPayment).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkPayment).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkPayment).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkPayment).Location = new Point(185, 177);
    this.checkPayment.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkPayment).Name = "checkPayment";
    ((Control) this.checkPayment).Size = new Size(120, 19);
    ((Control) this.checkPayment).TabIndex = 6;
    ((Control) this.checkPayment).Text = "Create Payment";
    ultraToolTipInfo4.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo4.ToolTipText = "Check this box to enable this expense automation.";
    ultraToolTipInfo4.ToolTipTitle = "Enable Expense Automation On Payment Creation";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.checkPayment, ultraToolTipInfo4);
    ((UltraControlBase) this.checkPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkPayment).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance7).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonSave).Location = new Point(367, 358);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(76, 29);
    ((Control) this.buttonSave).TabIndex = 8;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((AppearanceBase) appearance8).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance8).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance8;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(449, 358);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(76, 29);
    ((Control) this.buttonCancel).TabIndex = 9;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.panelClaimOptions.BackColor = Color.Transparent;
    this.panelClaimOptions.Controls.Add((Control) this.textClaim_FlatAmount);
    this.panelClaimOptions.Controls.Add((Control) this.ultraLabel1);
    this.panelClaimOptions.Controls.Add((Control) this.optionClaim_FlatAmount);
    this.panelClaimOptions.Controls.Add((Control) this.optionClaim_Hourly);
    this.panelClaimOptions.Controls.Add((Control) this.textClaim_Hours);
    this.panelClaimOptions.Controls.Add((Control) this.ultraLabel3);
    this.panelClaimOptions.Controls.Add((Control) this.ultraLabel4);
    this.panelClaimOptions.Controls.Add((Control) this.textClaim_Rate);
    this.panelClaimOptions.Location = new Point(29, 39);
    this.panelClaimOptions.Name = "panelClaimOptions";
    this.panelClaimOptions.Size = new Size(153, 132);
    this.panelClaimOptions.TabIndex = 1;
    ((Control) this.textClaim_FlatAmount).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textClaim_FlatAmount).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textClaim_FlatAmount).BackColor = Color.White;
    ((Control) this.textClaim_FlatAmount).Location = new Point(75, 26);
    this.textClaim_FlatAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaim_FlatAmount).Name = "textClaim_FlatAmount";
    ((Control) this.textClaim_FlatAmount).Size = new Size(75, 20);
    ((Control) this.textClaim_FlatAmount).TabIndex = 2;
    ((UltraControlBase) this.textClaim_FlatAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaim_FlatAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(25, 26);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(47, 15);
    ((Control) this.ultraLabel1).TabIndex = 1;
    ((Control) this.ultraLabel1).Text = "Amount:";
    this.optionClaim_FlatAmount.AutoSize = true;
    this.optionClaim_FlatAmount.Checked = true;
    this.optionClaim_FlatAmount.Location = new Point(3, 3);
    this.optionClaim_FlatAmount.Name = "optionClaim_FlatAmount";
    this.optionClaim_FlatAmount.Size = new Size(83, 17);
    this.optionClaim_FlatAmount.TabIndex = 0;
    this.optionClaim_FlatAmount.TabStop = true;
    this.optionClaim_FlatAmount.Text = "Flat Amount";
    this.optionClaim_FlatAmount.UseVisualStyleBackColor = true;
    this.optionClaim_Hourly.AutoSize = true;
    this.optionClaim_Hourly.Location = new Point(3, 52);
    this.optionClaim_Hourly.Name = "optionClaim_Hourly";
    this.optionClaim_Hourly.Size = new Size(83, 17);
    this.optionClaim_Hourly.TabIndex = 3;
    this.optionClaim_Hourly.Text = "Hourly/Rate";
    this.optionClaim_Hourly.UseVisualStyleBackColor = true;
    this.panelClaimantOptions.BackColor = Color.Transparent;
    this.panelClaimantOptions.Controls.Add((Control) this.textClaimant_FlatAmount);
    this.panelClaimantOptions.Controls.Add((Control) this.ultraLabel2);
    this.panelClaimantOptions.Controls.Add((Control) this.optionClaimant_FlatAmount);
    this.panelClaimantOptions.Controls.Add((Control) this.optionClaimant_Hourly);
    this.panelClaimantOptions.Controls.Add((Control) this.textClaimant_Hours);
    this.panelClaimantOptions.Controls.Add((Control) this.ultraLabel5);
    this.panelClaimantOptions.Controls.Add((Control) this.ultraLabel6);
    this.panelClaimantOptions.Controls.Add((Control) this.textClaimant_Rate);
    this.panelClaimantOptions.Location = new Point(200, 39);
    this.panelClaimantOptions.Name = "panelClaimantOptions";
    this.panelClaimantOptions.Size = new Size(153, 132);
    this.panelClaimantOptions.TabIndex = 3;
    ((Control) this.textClaimant_FlatAmount).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textClaimant_FlatAmount).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textClaimant_FlatAmount).BackColor = Color.White;
    ((Control) this.textClaimant_FlatAmount).Location = new Point(75, 26);
    this.textClaimant_FlatAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimant_FlatAmount).Name = "textClaimant_FlatAmount";
    ((Control) this.textClaimant_FlatAmount).Size = new Size(75, 20);
    ((Control) this.textClaimant_FlatAmount).TabIndex = 2;
    ((UltraControlBase) this.textClaimant_FlatAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimant_FlatAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(25, 26);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(47, 15);
    ((Control) this.ultraLabel2).TabIndex = 1;
    ((Control) this.ultraLabel2).Text = "Amount:";
    this.optionClaimant_FlatAmount.AutoSize = true;
    this.optionClaimant_FlatAmount.Checked = true;
    this.optionClaimant_FlatAmount.Location = new Point(3, 3);
    this.optionClaimant_FlatAmount.Name = "optionClaimant_FlatAmount";
    this.optionClaimant_FlatAmount.Size = new Size(83, 17);
    this.optionClaimant_FlatAmount.TabIndex = 0;
    this.optionClaimant_FlatAmount.TabStop = true;
    this.optionClaimant_FlatAmount.Text = "Flat Amount";
    this.optionClaimant_FlatAmount.UseVisualStyleBackColor = true;
    this.optionClaimant_Hourly.AutoSize = true;
    this.optionClaimant_Hourly.Location = new Point(3, 52);
    this.optionClaimant_Hourly.Name = "optionClaimant_Hourly";
    this.optionClaimant_Hourly.Size = new Size(83, 17);
    this.optionClaimant_Hourly.TabIndex = 3;
    this.optionClaimant_Hourly.Text = "Hourly/Rate";
    this.optionClaimant_Hourly.UseVisualStyleBackColor = true;
    ((Control) this.textClaimant_Hours).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textClaimant_Hours).Appearance = (AppearanceBase) appearance11;
    ((Control) this.textClaimant_Hours).BackColor = Color.White;
    ((Control) this.textClaimant_Hours).Location = new Point(75, 75);
    this.textClaimant_Hours.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimant_Hours).Name = "textClaimant_Hours";
    ((Control) this.textClaimant_Hours).Size = new Size(75, 20);
    ((Control) this.textClaimant_Hours).TabIndex = 5;
    ((UltraControlBase) this.textClaimant_Hours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimant_Hours).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(25, 100);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel5).TabIndex = 6;
    ((Control) this.ultraLabel5).Text = "Rate:";
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(25, 75);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(37, 15);
    ((Control) this.ultraLabel6).TabIndex = 4;
    ((Control) this.ultraLabel6).Text = "Hours:";
    ((Control) this.textClaimant_Rate).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textClaimant_Rate).Appearance = (AppearanceBase) appearance12;
    ((Control) this.textClaimant_Rate).BackColor = Color.White;
    ((Control) this.textClaimant_Rate).Location = new Point(75, 100);
    this.textClaimant_Rate.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimant_Rate).Name = "textClaimant_Rate";
    ((Control) this.textClaimant_Rate).Size = new Size(75, 20);
    ((Control) this.textClaimant_Rate).TabIndex = 7;
    ((UltraControlBase) this.textClaimant_Rate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimant_Rate).UseOsThemes = (DefaultableBoolean) 2;
    this.panelReserveOptions.BackColor = Color.Transparent;
    this.panelReserveOptions.Controls.Add((Control) this.textReserve_FlatAmount);
    this.panelReserveOptions.Controls.Add((Control) this.ultraLabel7);
    this.panelReserveOptions.Controls.Add((Control) this.optionReserve_FlatAmount);
    this.panelReserveOptions.Controls.Add((Control) this.optionReserve_Hourly);
    this.panelReserveOptions.Controls.Add((Control) this.textReserve_Hours);
    this.panelReserveOptions.Controls.Add((Control) this.ultraLabel8);
    this.panelReserveOptions.Controls.Add((Control) this.ultraLabel9);
    this.panelReserveOptions.Controls.Add((Control) this.textReserve_Rate);
    this.panelReserveOptions.Location = new Point(30, 202);
    this.panelReserveOptions.Name = "panelReserveOptions";
    this.panelReserveOptions.Size = new Size(153, 132);
    this.panelReserveOptions.TabIndex = 5;
    ((Control) this.textReserve_FlatAmount).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textReserve_FlatAmount).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textReserve_FlatAmount).BackColor = Color.White;
    ((Control) this.textReserve_FlatAmount).Location = new Point(75, 26);
    this.textReserve_FlatAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.textReserve_FlatAmount).Name = "textReserve_FlatAmount";
    ((Control) this.textReserve_FlatAmount).Size = new Size(75, 20);
    ((Control) this.textReserve_FlatAmount).TabIndex = 2;
    ((UltraControlBase) this.textReserve_FlatAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReserve_FlatAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Location = new Point(25, 26);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(47, 15);
    ((Control) this.ultraLabel7).TabIndex = 1;
    ((Control) this.ultraLabel7).Text = "Amount:";
    this.optionReserve_FlatAmount.AutoSize = true;
    this.optionReserve_FlatAmount.Checked = true;
    this.optionReserve_FlatAmount.Location = new Point(3, 3);
    this.optionReserve_FlatAmount.Name = "optionReserve_FlatAmount";
    this.optionReserve_FlatAmount.Size = new Size(83, 17);
    this.optionReserve_FlatAmount.TabIndex = 0;
    this.optionReserve_FlatAmount.TabStop = true;
    this.optionReserve_FlatAmount.Text = "Flat Amount";
    this.optionReserve_FlatAmount.UseVisualStyleBackColor = true;
    this.optionReserve_Hourly.AutoSize = true;
    this.optionReserve_Hourly.Location = new Point(3, 52);
    this.optionReserve_Hourly.Name = "optionReserve_Hourly";
    this.optionReserve_Hourly.Size = new Size(83, 17);
    this.optionReserve_Hourly.TabIndex = 3;
    this.optionReserve_Hourly.Text = "Hourly/Rate";
    this.optionReserve_Hourly.UseVisualStyleBackColor = true;
    ((Control) this.textReserve_Hours).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textReserve_Hours).Appearance = (AppearanceBase) appearance14;
    ((Control) this.textReserve_Hours).BackColor = Color.White;
    ((Control) this.textReserve_Hours).Location = new Point(75, 75);
    this.textReserve_Hours.MGAStyle = (MGAStyles) 2;
    ((Control) this.textReserve_Hours).Name = "textReserve_Hours";
    ((Control) this.textReserve_Hours).Size = new Size(75, 20);
    ((Control) this.textReserve_Hours).TabIndex = 5;
    ((UltraControlBase) this.textReserve_Hours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReserve_Hours).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Location = new Point(25, 100);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel8).TabIndex = 6;
    ((Control) this.ultraLabel8).Text = "Rate:";
    ((Control) this.ultraLabel9).AutoSize = true;
    ((Control) this.ultraLabel9).Location = new Point(25, 75);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(37, 15);
    ((Control) this.ultraLabel9).TabIndex = 4;
    ((Control) this.ultraLabel9).Text = "Hours:";
    ((Control) this.textReserve_Rate).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textReserve_Rate).Appearance = (AppearanceBase) appearance15;
    ((Control) this.textReserve_Rate).BackColor = Color.White;
    ((Control) this.textReserve_Rate).Location = new Point(75, 100);
    this.textReserve_Rate.MGAStyle = (MGAStyles) 2;
    ((Control) this.textReserve_Rate).Name = "textReserve_Rate";
    ((Control) this.textReserve_Rate).Size = new Size(75, 20);
    ((Control) this.textReserve_Rate).TabIndex = 7;
    ((UltraControlBase) this.textReserve_Rate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReserve_Rate).UseOsThemes = (DefaultableBoolean) 2;
    this.panelPaymentOptions.BackColor = Color.Transparent;
    this.panelPaymentOptions.Controls.Add((Control) this.textPayment_FlatAmount);
    this.panelPaymentOptions.Controls.Add((Control) this.ultraLabel10);
    this.panelPaymentOptions.Controls.Add((Control) this.optionPayment_FlatAmount);
    this.panelPaymentOptions.Controls.Add((Control) this.optionPayment_Hourly);
    this.panelPaymentOptions.Controls.Add((Control) this.textPayment_Hours);
    this.panelPaymentOptions.Controls.Add((Control) this.ultraLabel11);
    this.panelPaymentOptions.Controls.Add((Control) this.ultraLabel12);
    this.panelPaymentOptions.Controls.Add((Control) this.textPayment_Rate);
    this.panelPaymentOptions.Location = new Point(200, 205);
    this.panelPaymentOptions.Name = "panelPaymentOptions";
    this.panelPaymentOptions.Size = new Size(153, 132);
    this.panelPaymentOptions.TabIndex = 7;
    ((Control) this.textPayment_FlatAmount).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textPayment_FlatAmount).Appearance = (AppearanceBase) appearance16;
    ((Control) this.textPayment_FlatAmount).BackColor = Color.White;
    ((Control) this.textPayment_FlatAmount).Location = new Point(75, 26);
    this.textPayment_FlatAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPayment_FlatAmount).Name = "textPayment_FlatAmount";
    ((Control) this.textPayment_FlatAmount).Size = new Size(75, 20);
    ((Control) this.textPayment_FlatAmount).TabIndex = 2;
    ((UltraControlBase) this.textPayment_FlatAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayment_FlatAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel10).AutoSize = true;
    ((Control) this.ultraLabel10).Location = new Point(25, 26);
    ((Control) this.ultraLabel10).Name = "ultraLabel10";
    ((Control) this.ultraLabel10).Size = new Size(47, 15);
    ((Control) this.ultraLabel10).TabIndex = 1;
    ((Control) this.ultraLabel10).Text = "Amount:";
    this.optionPayment_FlatAmount.AutoSize = true;
    this.optionPayment_FlatAmount.Checked = true;
    this.optionPayment_FlatAmount.Location = new Point(3, 3);
    this.optionPayment_FlatAmount.Name = "optionPayment_FlatAmount";
    this.optionPayment_FlatAmount.Size = new Size(83, 17);
    this.optionPayment_FlatAmount.TabIndex = 0;
    this.optionPayment_FlatAmount.TabStop = true;
    this.optionPayment_FlatAmount.Text = "Flat Amount";
    this.optionPayment_FlatAmount.UseVisualStyleBackColor = true;
    this.optionPayment_Hourly.AutoSize = true;
    this.optionPayment_Hourly.Location = new Point(3, 52);
    this.optionPayment_Hourly.Name = "optionPayment_Hourly";
    this.optionPayment_Hourly.Size = new Size(83, 17);
    this.optionPayment_Hourly.TabIndex = 3;
    this.optionPayment_Hourly.Text = "Hourly/Rate";
    this.optionPayment_Hourly.UseVisualStyleBackColor = true;
    ((Control) this.textPayment_Hours).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textPayment_Hours).Appearance = (AppearanceBase) appearance17;
    ((Control) this.textPayment_Hours).BackColor = Color.White;
    ((Control) this.textPayment_Hours).Location = new Point(75, 75);
    this.textPayment_Hours.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPayment_Hours).Name = "textPayment_Hours";
    ((Control) this.textPayment_Hours).Size = new Size(75, 20);
    ((Control) this.textPayment_Hours).TabIndex = 5;
    ((UltraControlBase) this.textPayment_Hours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayment_Hours).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel11).AutoSize = true;
    ((Control) this.ultraLabel11).Location = new Point(25, 100);
    ((Control) this.ultraLabel11).Name = "ultraLabel11";
    ((Control) this.ultraLabel11).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel11).TabIndex = 6;
    ((Control) this.ultraLabel11).Text = "Rate:";
    ((Control) this.ultraLabel12).AutoSize = true;
    ((Control) this.ultraLabel12).Location = new Point(25, 75);
    ((Control) this.ultraLabel12).Name = "ultraLabel12";
    ((Control) this.ultraLabel12).Size = new Size(37, 15);
    ((Control) this.ultraLabel12).TabIndex = 4;
    ((Control) this.ultraLabel12).Text = "Hours:";
    ((Control) this.textPayment_Rate).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance18).BackColor = Color.White;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textPayment_Rate).Appearance = (AppearanceBase) appearance18;
    ((Control) this.textPayment_Rate).BackColor = Color.White;
    ((Control) this.textPayment_Rate).Location = new Point(75, 100);
    this.textPayment_Rate.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPayment_Rate).Name = "textPayment_Rate";
    ((Control) this.textPayment_Rate).Size = new Size(75, 20);
    ((Control) this.textPayment_Rate).TabIndex = 7;
    ((UltraControlBase) this.textPayment_Rate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayment_Rate).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolTipManager1.ContainingControl = (Control) this;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkCloseClaim).Appearance = (AppearanceBase) appearance19;
    ((Control) this.checkCloseClaim).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkCloseClaim).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkCloseClaim).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkCloseClaim).Location = new Point(357, 14);
    this.checkCloseClaim.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkCloseClaim).Name = "checkCloseClaim";
    ((Control) this.checkCloseClaim).Size = new Size(120, 19);
    ((Control) this.checkCloseClaim).TabIndex = 10;
    ((Control) this.checkCloseClaim).Text = "Close Claim";
    ultraToolTipInfo5.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo5.ToolTipText = "Check this box to enable this expense automation.";
    ultraToolTipInfo5.ToolTipTitle = "Enable Expense Automation On Claimant Creation";
    this.ultraToolTipManager1.SetUltraToolTip((Control) this.checkCloseClaim, ultraToolTipInfo5);
    ((UltraControlBase) this.checkCloseClaim).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkCloseClaim).UseOsThemes = (DefaultableBoolean) 2;
    this.panelCloseClaimOptions.BackColor = Color.Transparent;
    this.panelCloseClaimOptions.Controls.Add((Control) this.textCloseClaim_FlatAmount);
    this.panelCloseClaimOptions.Controls.Add((Control) this.ultraLabel13);
    this.panelCloseClaimOptions.Controls.Add((Control) this.optionCloseClaim_FlatAmount);
    this.panelCloseClaimOptions.Controls.Add((Control) this.optionCloseClaim_Hourly);
    this.panelCloseClaimOptions.Controls.Add((Control) this.textCloseClaim_Hours);
    this.panelCloseClaimOptions.Controls.Add((Control) this.ultraLabel14);
    this.panelCloseClaimOptions.Controls.Add((Control) this.ultraLabel15);
    this.panelCloseClaimOptions.Controls.Add((Control) this.textCloseClaim_Rate);
    this.panelCloseClaimOptions.Location = new Point(372, 39);
    this.panelCloseClaimOptions.Name = "panelCloseClaimOptions";
    this.panelCloseClaimOptions.Size = new Size(153, 132);
    this.panelCloseClaimOptions.TabIndex = 11;
    ((Control) this.textCloseClaim_FlatAmount).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textCloseClaim_FlatAmount).Appearance = (AppearanceBase) appearance20;
    ((Control) this.textCloseClaim_FlatAmount).BackColor = Color.White;
    ((Control) this.textCloseClaim_FlatAmount).Location = new Point(75, 26);
    this.textCloseClaim_FlatAmount.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCloseClaim_FlatAmount).Name = "textCloseClaim_FlatAmount";
    ((Control) this.textCloseClaim_FlatAmount).Size = new Size(75, 20);
    ((Control) this.textCloseClaim_FlatAmount).TabIndex = 2;
    ((UltraControlBase) this.textCloseClaim_FlatAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCloseClaim_FlatAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel13).AutoSize = true;
    ((Control) this.ultraLabel13).Location = new Point(25, 26);
    ((Control) this.ultraLabel13).Name = "ultraLabel13";
    ((Control) this.ultraLabel13).Size = new Size(47, 15);
    ((Control) this.ultraLabel13).TabIndex = 1;
    ((Control) this.ultraLabel13).Text = "Amount:";
    this.optionCloseClaim_FlatAmount.AutoSize = true;
    this.optionCloseClaim_FlatAmount.Checked = true;
    this.optionCloseClaim_FlatAmount.Location = new Point(3, 3);
    this.optionCloseClaim_FlatAmount.Name = "optionCloseClaim_FlatAmount";
    this.optionCloseClaim_FlatAmount.Size = new Size(83, 17);
    this.optionCloseClaim_FlatAmount.TabIndex = 0;
    this.optionCloseClaim_FlatAmount.TabStop = true;
    this.optionCloseClaim_FlatAmount.Text = "Flat Amount";
    this.optionCloseClaim_FlatAmount.UseVisualStyleBackColor = true;
    this.optionCloseClaim_Hourly.AutoSize = true;
    this.optionCloseClaim_Hourly.Location = new Point(3, 52);
    this.optionCloseClaim_Hourly.Name = "optionCloseClaim_Hourly";
    this.optionCloseClaim_Hourly.Size = new Size(83, 17);
    this.optionCloseClaim_Hourly.TabIndex = 3;
    this.optionCloseClaim_Hourly.Text = "Hourly/Rate";
    this.optionCloseClaim_Hourly.UseVisualStyleBackColor = true;
    ((Control) this.textCloseClaim_Hours).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textCloseClaim_Hours).Appearance = (AppearanceBase) appearance21;
    ((Control) this.textCloseClaim_Hours).BackColor = Color.White;
    ((Control) this.textCloseClaim_Hours).Location = new Point(75, 75);
    this.textCloseClaim_Hours.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCloseClaim_Hours).Name = "textCloseClaim_Hours";
    ((Control) this.textCloseClaim_Hours).Size = new Size(75, 20);
    ((Control) this.textCloseClaim_Hours).TabIndex = 5;
    ((UltraControlBase) this.textCloseClaim_Hours).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCloseClaim_Hours).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel14).AutoSize = true;
    ((Control) this.ultraLabel14).Location = new Point(25, 100);
    ((Control) this.ultraLabel14).Name = "ultraLabel14";
    ((Control) this.ultraLabel14).Size = new Size(31 /*0x1F*/, 15);
    ((Control) this.ultraLabel14).TabIndex = 6;
    ((Control) this.ultraLabel14).Text = "Rate:";
    ((Control) this.ultraLabel15).AutoSize = true;
    ((Control) this.ultraLabel15).Location = new Point(25, 75);
    ((Control) this.ultraLabel15).Name = "ultraLabel15";
    ((Control) this.ultraLabel15).Size = new Size(37, 15);
    ((Control) this.ultraLabel15).TabIndex = 4;
    ((Control) this.ultraLabel15).Text = "Hours:";
    ((Control) this.textCloseClaim_Rate).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textCloseClaim_Rate).Appearance = (AppearanceBase) appearance22;
    ((Control) this.textCloseClaim_Rate).BackColor = Color.White;
    ((Control) this.textCloseClaim_Rate).Location = new Point(75, 100);
    this.textCloseClaim_Rate.MGAStyle = (MGAStyles) 2;
    ((Control) this.textCloseClaim_Rate).Name = "textCloseClaim_Rate";
    ((Control) this.textCloseClaim_Rate).Size = new Size(75, 20);
    ((Control) this.textCloseClaim_Rate).TabIndex = 7;
    ((UltraControlBase) this.textCloseClaim_Rate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCloseClaim_Rate).UseOsThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(537, 399);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelCloseClaimOptions);
    this.Controls.Add((Control) this.checkCloseClaim);
    this.Controls.Add((Control) this.panelPaymentOptions);
    this.Controls.Add((Control) this.panelReserveOptions);
    this.Controls.Add((Control) this.panelClaimantOptions);
    this.Controls.Add((Control) this.panelClaimOptions);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.checkPayment);
    this.Controls.Add((Control) this.checkReserve);
    this.Controls.Add((Control) this.checkClaimant);
    this.Controls.Add((Control) this.checkClaim);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAutomatedExpenses);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Automate Claim Expense Management";
    ((ISupportInitialize) this.checkClaim).EndInit();
    ((ISupportInitialize) this.textClaim_Hours).EndInit();
    ((ISupportInitialize) this.textClaim_Rate).EndInit();
    ((ISupportInitialize) this.checkClaimant).EndInit();
    ((ISupportInitialize) this.checkReserve).EndInit();
    ((ISupportInitialize) this.checkPayment).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panelClaimOptions.ResumeLayout(false);
    this.panelClaimOptions.PerformLayout();
    ((ISupportInitialize) this.textClaim_FlatAmount).EndInit();
    this.panelClaimantOptions.ResumeLayout(false);
    this.panelClaimantOptions.PerformLayout();
    ((ISupportInitialize) this.textClaimant_FlatAmount).EndInit();
    ((ISupportInitialize) this.textClaimant_Hours).EndInit();
    ((ISupportInitialize) this.textClaimant_Rate).EndInit();
    this.panelReserveOptions.ResumeLayout(false);
    this.panelReserveOptions.PerformLayout();
    ((ISupportInitialize) this.textReserve_FlatAmount).EndInit();
    ((ISupportInitialize) this.textReserve_Hours).EndInit();
    ((ISupportInitialize) this.textReserve_Rate).EndInit();
    this.panelPaymentOptions.ResumeLayout(false);
    this.panelPaymentOptions.PerformLayout();
    ((ISupportInitialize) this.textPayment_FlatAmount).EndInit();
    ((ISupportInitialize) this.textPayment_Hours).EndInit();
    ((ISupportInitialize) this.textPayment_Rate).EndInit();
    ((ISupportInitialize) this.checkCloseClaim).EndInit();
    this.panelCloseClaimOptions.ResumeLayout(false);
    this.panelCloseClaimOptions.PerformLayout();
    ((ISupportInitialize) this.textCloseClaim_FlatAmount).EndInit();
    ((ISupportInitialize) this.textCloseClaim_Hours).EndInit();
    ((ISupportInitialize) this.textCloseClaim_Rate).EndInit();
    this.ResumeLayout(false);
  }
}
