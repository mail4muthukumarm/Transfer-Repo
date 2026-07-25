// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyNumbering.frmAdminPolicyNumbers
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MgaSystems.IMS.Policies.PolicyNumberAlert;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyNumbering;

[SecureResource("{68CF4A63-0C7E-40ed-8C27-7F7551E8985C}", "Access Policy Number Generation Menu", "Controls access to the policy number generation menu item.", "Policies")]
[SecureResource("{2ED4629F-1676-4C6E-A1D7-C3F0051336DB}", "Allow Run-Off Update Of Policy # Rules", "Allows the user to update run-off on policy # rules.", "Policies")]
public class frmAdminPolicyNumbers : Form
{
  private IContainer components;
  private Label Label6;
  private Label Label5;
  private Label Label1;
  private Label lblSample;
  protected UltraGroupBox gbEntry;
  private ErrorProvider err;
  private dsPolicyNumberAdmin ds;
  private DbDataAdapter daRule;
  private Label Label11;
  private MGASimpleComboBox cboUsers;
  private MGANumericEditor udNumbers;
  private MGANumericEditor numBlockTotalDigitsEnd;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private UltraGroupBox UltraGroupBox1;
  private bool _clickingNew;
  private int _currentRuleID;
  private List<int> _ruleLockDown;
  public const string CanUpdateRunOffOnPolicyNumberRule = "{2ED4629F-1676-4C6E-A1D7-C3F0051336DB}";
  private bool _canUpdateRunOff;
  private readonly Lazy<bool> _viewRunoffUpdate;
  public const string CanAccessPolicyNumberGeneration = "{68CF4A63-0C7E-40ed-8C27-7F7551E8985C}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel1")]
  protected virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtPrefix
  {
    get => this._txtPrefix;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGATextBox txtPrefix1 = this._txtPrefix;
      if (txtPrefix1 != null)
        ((Control) txtPrefix1).Leave -= eventHandler;
      this._txtPrefix = value;
      MGATextBox txtPrefix2 = this._txtPrefix;
      if (txtPrefix2 == null)
        return;
      ((Control) txtPrefix2).Leave += eventHandler;
    }
  }

  private virtual MGATextBox txtFixedValue
  {
    get => this._txtFixedValue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGATextBox txtFixedValue1 = this._txtFixedValue;
      if (txtFixedValue1 != null)
        ((Control) txtFixedValue1).TextChanged -= eventHandler;
      this._txtFixedValue = value;
      MGATextBox txtFixedValue2 = this._txtFixedValue;
      if (txtFixedValue2 == null)
        return;
      ((Control) txtFixedValue2).TextChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkNewOnRenewal
  {
    get => this._chkNewOnRenewal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ChangeBlock);
      EventHandler eventHandler2 = new EventHandler(this.MonitoredControl_Changed);
      MGACheckBox chkNewOnRenewal1 = this._chkNewOnRenewal;
      if (chkNewOnRenewal1 != null)
      {
        ((UltraToggleEditorBase) chkNewOnRenewal1).CheckedChanged -= eventHandler1;
        ((UltraToggleEditorBase) chkNewOnRenewal1).CheckedValueChanged -= eventHandler2;
      }
      this._chkNewOnRenewal = value;
      MGACheckBox chkNewOnRenewal2 = this._chkNewOnRenewal;
      if (chkNewOnRenewal2 == null)
        return;
      ((UltraToggleEditorBase) chkNewOnRenewal2).CheckedChanged += eventHandler1;
      ((UltraToggleEditorBase) chkNewOnRenewal2).CheckedValueChanged += eventHandler2;
    }
  }

  private virtual RadioButton rbSequential
  {
    get => this._rbSequential;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rbSequential1 = this._rbSequential;
      if (rbSequential1 != null)
        rbSequential1.CheckedChanged -= eventHandler;
      this._rbSequential = value;
      RadioButton rbSequential2 = this._rbSequential;
      if (rbSequential2 == null)
        return;
      rbSequential2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rb2DigitYear
  {
    get => this._rb2DigitYear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rb2DigitYear1 = this._rb2DigitYear;
      if (rb2DigitYear1 != null)
        rb2DigitYear1.CheckedChanged -= eventHandler;
      this._rb2DigitYear = value;
      RadioButton rb2DigitYear2 = this._rb2DigitYear;
      if (rb2DigitYear2 == null)
        return;
      rb2DigitYear2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFixedValue
  {
    get => this._rbFixedValue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rbFixedValue1 = this._rbFixedValue;
      if (rbFixedValue1 != null)
        rbFixedValue1.CheckedChanged -= eventHandler;
      this._rbFixedValue = value;
      RadioButton rbFixedValue2 = this._rbFixedValue;
      if (rbFixedValue2 == null)
        return;
      rbFixedValue2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor numBlockTotalDigitsStart
  {
    get => this._numBlockTotalDigitsStart;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ChangeBlock);
      EventHandler eventHandler2 = new EventHandler(this.ChangeBlock);
      MGANumericEditor totalDigitsStart1 = this._numBlockTotalDigitsStart;
      if (totalDigitsStart1 != null)
      {
        ((UltraNumericEditorBase) totalDigitsStart1).ValueChanged -= eventHandler1;
        ((Control) totalDigitsStart1).Leave -= eventHandler2;
      }
      this._numBlockTotalDigitsStart = value;
      MGANumericEditor totalDigitsStart2 = this._numBlockTotalDigitsStart;
      if (totalDigitsStart2 == null)
        return;
      ((UltraNumericEditorBase) totalDigitsStart2).ValueChanged += eventHandler1;
      ((Control) totalDigitsStart2).Leave += eventHandler2;
    }
  }

  private virtual MGANumericEditor numBlockTotalDigits
  {
    get => this._numBlockTotalDigits;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ChangeBlock);
      EventHandler eventHandler2 = new EventHandler(this.ChangeBlock);
      MGANumericEditor blockTotalDigits1 = this._numBlockTotalDigits;
      if (blockTotalDigits1 != null)
      {
        ((UltraNumericEditorBase) blockTotalDigits1).ValueChanged -= eventHandler1;
        ((Control) blockTotalDigits1).Leave -= eventHandler2;
      }
      this._numBlockTotalDigits = value;
      MGANumericEditor blockTotalDigits2 = this._numBlockTotalDigits;
      if (blockTotalDigits2 == null)
        return;
      ((UltraNumericEditorBase) blockTotalDigits2).ValueChanged += eventHandler1;
      ((Control) blockTotalDigits2).Leave += eventHandler2;
    }
  }

  private virtual MGACheckBox chkDash
  {
    get => this._chkDash;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGACheckBox chkDash1 = this._chkDash;
      if (chkDash1 != null)
        ((UltraToggleEditorBase) chkDash1).CheckedChanged -= eventHandler;
      this._chkDash = value;
      MGACheckBox chkDash2 = this._chkDash;
      if (chkDash2 == null)
        return;
      ((UltraToggleEditorBase) chkDash2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtRuleName")]
  protected virtual MGATextBox txtRuleName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI ctlSaveUI
  {
    get => this._ctlSaveUI;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ctlSaveUI_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.ctlSaveUI_ClickedButton);
      EventHandler eventHandler3 = new EventHandler(this.ctlSaveUI_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.ctlSaveUI_ClickingSave);
      EventHandler eventHandler4 = new EventHandler(this.ctlSaveUI_ClickedDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.ctlSaveUI_ClickingEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI ctlSaveUi1 = this._ctlSaveUI;
      if (ctlSaveUi1 != null)
      {
        ctlSaveUi1.ClickedNew -= eventHandler1;
        ctlSaveUi1.ClickedButton -= eventHandler2;
        ctlSaveUi1.ClickedCancel -= eventHandler3;
        ctlSaveUi1.ClickingSave -= cancelEventHandler1;
        ctlSaveUi1.ClickedDelete -= eventHandler4;
        ctlSaveUi1.ClickingEdit -= cancelEventHandler2;
      }
      this._ctlSaveUI = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI ctlSaveUi2 = this._ctlSaveUI;
      if (ctlSaveUi2 == null)
        return;
      ctlSaveUi2.ClickedNew += eventHandler1;
      ctlSaveUi2.ClickedButton += eventHandler2;
      ctlSaveUi2.ClickedCancel += eventHandler3;
      ctlSaveUi2.ClickingSave += cancelEventHandler1;
      ctlSaveUi2.ClickedDelete += eventHandler4;
      ctlSaveUi2.ClickingEdit += cancelEventHandler2;
    }
  }

  private virtual MGACheckBox chkManual
  {
    get => this._chkManual;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.chkManual_CheckedChanged);
      EventHandler eventHandler2 = new EventHandler(this.MonitoredControl_Changed);
      MGACheckBox chkManual1 = this._chkManual;
      if (chkManual1 != null)
      {
        ((UltraToggleEditorBase) chkManual1).CheckedChanged -= eventHandler1;
        ((UltraToggleEditorBase) chkManual1).CheckedValueChanged -= eventHandler2;
      }
      this._chkManual = value;
      MGACheckBox chkManual2 = this._chkManual;
      if (chkManual2 == null)
        return;
      ((UltraToggleEditorBase) chkManual2).CheckedChanged += eventHandler1;
      ((UltraToggleEditorBase) chkManual2).CheckedValueChanged += eventHandler2;
    }
  }

  protected virtual UltraGrid dgRules
  {
    get => this._dgRules;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgRules_AfterRowActivate);
      UltraGrid dgRules1 = this._dgRules;
      if (dgRules1 != null)
        dgRules1.AfterRowActivate -= eventHandler;
      this._dgRules = value;
      UltraGrid dgRules2 = this._dgRules;
      if (dgRules2 == null)
        return;
      dgRules2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGANumericEditor numSequential
  {
    get => this._numSequential;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGANumericEditor numSequential1 = this._numSequential;
      if (numSequential1 != null)
        ((UltraNumericEditorBase) numSequential1).ValueChanged -= eventHandler;
      this._numSequential = value;
      MGANumericEditor numSequential2 = this._numSequential;
      if (numSequential2 == null)
        return;
      ((UltraNumericEditorBase) numSequential2).ValueChanged += eventHandler;
    }
  }

  private virtual MGANumericEditor numTotalDigits
  {
    get => this._numTotalDigits;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGANumericEditor numTotalDigits1 = this._numTotalDigits;
      if (numTotalDigits1 != null)
        ((UltraNumericEditorBase) numTotalDigits1).ValueChanged -= eventHandler;
      this._numTotalDigits = value;
      MGANumericEditor numTotalDigits2 = this._numTotalDigits;
      if (numTotalDigits2 == null)
        return;
      ((UltraNumericEditorBase) numTotalDigits2).ValueChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkSpace
  {
    get => this._chkSpace;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGACheckBox chkSpace1 = this._chkSpace;
      if (chkSpace1 != null)
        ((UltraToggleEditorBase) chkSpace1).CheckedChanged -= eventHandler;
      this._chkSpace = value;
      MGACheckBox chkSpace2 = this._chkSpace;
      if (chkSpace2 == null)
        return;
      ((UltraToggleEditorBase) chkSpace2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtSunset1")]
  private virtual MGATextBox txtSunset1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSunset2")]
  private virtual MGATextBox txtSunset2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtClaimsMade")]
  private virtual MGATextBox txtClaimsMade { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSunset3")]
  private virtual MGATextBox txtSunset3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox checkRunoff
  {
    get => this._checkRunoff;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonitoredControl_Changed);
      MGACheckBox checkRunoff1 = this._checkRunoff;
      if (checkRunoff1 != null)
        ((UltraToggleEditorBase) checkRunoff1).CheckedValueChanged -= eventHandler;
      this._checkRunoff = value;
      MGACheckBox checkRunoff2 = this._checkRunoff;
      if (checkRunoff2 == null)
        return;
      ((UltraToggleEditorBase) checkRunoff2).CheckedValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("rbAlpha")]
  private virtual RadioButton rbAlpha { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox checkAlphaRenewalOnly
  {
    get => this._checkAlphaRenewalOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkAlphaRenewalOnly_CheckedChanged);
      MGACheckBox alphaRenewalOnly1 = this._checkAlphaRenewalOnly;
      if (alphaRenewalOnly1 != null)
        ((UltraToggleEditorBase) alphaRenewalOnly1).CheckedChanged -= eventHandler;
      this._checkAlphaRenewalOnly = value;
      MGACheckBox alphaRenewalOnly2 = this._checkAlphaRenewalOnly;
      if (alphaRenewalOnly2 == null)
        return;
      ((UltraToggleEditorBase) alphaRenewalOnly2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cn")]
  internal virtual DbConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkBasedOffEffDate")]
  private virtual MGACheckBox chkBasedOffEffDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkManualonPurchasedBook")]
  private virtual MGACheckBox checkManualonPurchasedBook { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkManualOnRenewal")]
  private virtual MGACheckBox checkManualOnRenewal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkUseTableBasedNumbering
  {
    get => this._chkUseTableBasedNumbering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonitoredControl_Changed);
      MGACheckBox tableBasedNumbering1 = this._chkUseTableBasedNumbering;
      if (tableBasedNumbering1 != null)
        ((UltraToggleEditorBase) tableBasedNumbering1).CheckedValueChanged -= eventHandler;
      this._chkUseTableBasedNumbering = value;
      MGACheckBox tableBasedNumbering2 = this._chkUseTableBasedNumbering;
      if (tableBasedNumbering2 == null)
        return;
      ((UltraToggleEditorBase) tableBasedNumbering2).CheckedValueChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkForceCheckNewPolicy
  {
    get => this._chkForceCheckNewPolicy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonitoredControl_Changed);
      MGACheckBox forceCheckNewPolicy1 = this._chkForceCheckNewPolicy;
      if (forceCheckNewPolicy1 != null)
        ((UltraToggleEditorBase) forceCheckNewPolicy1).CheckedValueChanged -= eventHandler;
      this._chkForceCheckNewPolicy = value;
      MGACheckBox forceCheckNewPolicy2 = this._chkForceCheckNewPolicy;
      if (forceCheckNewPolicy2 == null)
        return;
      ((UltraToggleEditorBase) forceCheckNewPolicy2).CheckedValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNextNumberToAssign")]
  private virtual MGATextBox txtNextNumberToAssign { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboNumbering
  {
    get => this._cboNumbering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonitoredControl_Changed);
      MGASimpleComboBox cboNumbering1 = this._cboNumbering;
      if (cboNumbering1 != null)
        ((UltraCombo) cboNumbering1).ValueChanged -= eventHandler;
      this._cboNumbering = value;
      MGASimpleComboBox cboNumbering2 = this._cboNumbering;
      if (cboNumbering2 == null)
        return;
      ((UltraCombo) cboNumbering2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkUseSubmissionGroupNumbering
  {
    get => this._chkUseSubmissionGroupNumbering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonitoredControl_Changed);
      MGACheckBox submissionGroupNumbering1 = this._chkUseSubmissionGroupNumbering;
      if (submissionGroupNumbering1 != null)
        ((UltraToggleEditorBase) submissionGroupNumbering1).CheckedValueChanged -= eventHandler;
      this._chkUseSubmissionGroupNumbering = value;
      MGACheckBox submissionGroupNumbering2 = this._chkUseSubmissionGroupNumbering;
      if (submissionGroupNumbering2 == null)
        return;
      ((UltraToggleEditorBase) submissionGroupNumbering2).CheckedValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkPromptForManualOverride")]
  private virtual MGACheckBox chkPromptForManualOverride { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rb4DigitYear
  {
    get => this._rb4DigitYear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rb4DigitYear1 = this._rb4DigitYear;
      if (rb4DigitYear1 != null)
        rb4DigitYear1.CheckedChanged -= eventHandler;
      this._rb4DigitYear = value;
      RadioButton rb4DigitYear2 = this._rb4DigitYear;
      if (rb4DigitYear2 == null)
        return;
      rb4DigitYear2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblLabel2")]
  internal virtual Label lblLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLabel1")]
  internal virtual Label lblLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyNumberSuffix")]
  private virtual MGATextBox txtPolicyNumberSuffix { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rb2YearAppend
  {
    get => this._rb2YearAppend;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rb2YearAppend1 = this._rb2YearAppend;
      if (rb2YearAppend1 != null)
        rb2YearAppend1.CheckedChanged -= eventHandler;
      this._rb2YearAppend = value;
      RadioButton rb2YearAppend2 = this._rb2YearAppend;
      if (rb2YearAppend2 == null)
        return;
      rb2YearAppend2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rb4YearAppend
  {
    get => this._rb4YearAppend;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rb4YearAppend1 = this._rb4YearAppend;
      if (rb4YearAppend1 != null)
        rb4YearAppend1.CheckedChanged -= eventHandler;
      this._rb4YearAppend = value;
      RadioButton rb4YearAppend2 = this._rb4YearAppend;
      if (rb4YearAppend2 == null)
        return;
      rb4YearAppend2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtAppendPrefix
  {
    get => this._txtAppendPrefix;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      MGATextBox txtAppendPrefix1 = this._txtAppendPrefix;
      if (txtAppendPrefix1 != null)
        ((Control) txtAppendPrefix1).TextChanged -= eventHandler;
      this._txtAppendPrefix = value;
      MGATextBox txtAppendPrefix2 = this._txtAppendPrefix;
      if (txtAppendPrefix2 == null)
        return;
      ((Control) txtAppendPrefix2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProgramCode")]
  internal virtual Label lblProgramCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProgramCode")]
  private virtual MGASimpleComboBox cboProgramCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbFourDigitYearSeq
  {
    get => this._rbFourDigitYearSeq;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton fourDigitYearSeq1 = this._rbFourDigitYearSeq;
      if (fourDigitYearSeq1 != null)
        fourDigitYearSeq1.CheckedChanged -= eventHandler;
      this._rbFourDigitYearSeq = value;
      RadioButton fourDigitYearSeq2 = this._rbFourDigitYearSeq;
      if (fourDigitYearSeq2 == null)
        return;
      fourDigitYearSeq2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbTwoDigitYearSeq
  {
    get => this._rbTwoDigitYearSeq;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rbTwoDigitYearSeq1 = this._rbTwoDigitYearSeq;
      if (rbTwoDigitYearSeq1 != null)
        rbTwoDigitYearSeq1.CheckedChanged -= eventHandler;
      this._rbTwoDigitYearSeq = value;
      RadioButton rbTwoDigitYearSeq2 = this._rbTwoDigitYearSeq;
      if (rbTwoDigitYearSeq2 == null)
        return;
      rbTwoDigitYearSeq2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("numYearSeqTotalDigits")]
  private virtual MGANumericEditor numYearSeqTotalDigits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numYearSeq")]
  private virtual MGANumericEditor numYearSeq { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  private virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseRenewalDigitYear")]
  private virtual MGACheckBox chkUseRenewalDigitYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkUseInsuredNumber
  {
    get => this._chkUseInsuredNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ChangeBlock);
      EventHandler eventHandler2 = new EventHandler(this.chkUseInsuredNumber_CheckedChanged);
      MGACheckBox useInsuredNumber1 = this._chkUseInsuredNumber;
      if (useInsuredNumber1 != null)
      {
        ((UltraToggleEditorBase) useInsuredNumber1).CheckedChanged -= eventHandler1;
        ((UltraToggleEditorBase) useInsuredNumber1).CheckedChanged -= eventHandler2;
      }
      this._chkUseInsuredNumber = value;
      MGACheckBox useInsuredNumber2 = this._chkUseInsuredNumber;
      if (useInsuredNumber2 == null)
        return;
      ((UltraToggleEditorBase) useInsuredNumber2).CheckedChanged += eventHandler1;
      ((UltraToggleEditorBase) useInsuredNumber2).CheckedChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("txtManualMask")]
  private virtual MGATextBox txtManualMask { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblManualMask")]
  private virtual Label lblManualMask { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMaskDescription")]
  internal virtual Label lblMaskDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkMoreNoteUsers
  {
    get => this._lnkMoreNoteUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkMoreNoteUsers_LinkClicked);
      LinkLabel lnkMoreNoteUsers1 = this._lnkMoreNoteUsers;
      if (lnkMoreNoteUsers1 != null)
        lnkMoreNoteUsers1.LinkClicked -= clickedEventHandler;
      this._lnkMoreNoteUsers = value;
      LinkLabel lnkMoreNoteUsers2 = this._lnkMoreNoteUsers;
      if (lnkMoreNoteUsers2 == null)
        return;
      lnkMoreNoteUsers2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkUseStoredProc")]
  private virtual MGACheckBox chkUseStoredProc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkNumericRenewalOnly
  {
    get => this._chkNumericRenewalOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkNumericRenewalOnly_CheckedChanged);
      MGACheckBox numericRenewalOnly1 = this._chkNumericRenewalOnly;
      if (numericRenewalOnly1 != null)
        ((UltraToggleEditorBase) numericRenewalOnly1).CheckedChanged -= eventHandler;
      this._chkNumericRenewalOnly = value;
      MGACheckBox numericRenewalOnly2 = this._chkNumericRenewalOnly;
      if (numericRenewalOnly2 == null)
        return;
      ((UltraToggleEditorBase) numericRenewalOnly2).CheckedChanged += eventHandler;
    }
  }

  internal virtual Button btnGenNumbers
  {
    get => this._btnGenNumbers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGenNumbers_Click);
      Button btnGenNumbers1 = this._btnGenNumbers;
      if (btnGenNumbers1 != null)
        btnGenNumbers1.Click -= eventHandler;
      this._btnGenNumbers = value;
      Button btnGenNumbers2 = this._btnGenNumbers;
      if (btnGenNumbers2 == null)
        return;
      btnGenNumbers2.Click += eventHandler;
    }
  }

  protected virtual MGAButton btnRunOff
  {
    get => this._btnRunOff;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRunOff_Click);
      MGAButton btnRunOff1 = this._btnRunOff;
      if (btnRunOff1 != null)
        ((Control) btnRunOff1).Click -= eventHandler;
      this._btnRunOff = value;
      MGAButton btnRunOff2 = this._btnRunOff;
      if (btnRunOff2 == null)
        return;
      ((Control) btnRunOff2).Click += eventHandler;
    }
  }

  private virtual RadioButton rbNoSuffix
  {
    get => this._rbNoSuffix;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeBlock);
      RadioButton rbNoSuffix1 = this._rbNoSuffix;
      if (rbNoSuffix1 != null)
        rbNoSuffix1.CheckedChanged -= eventHandler;
      this._rbNoSuffix = value;
      RadioButton rbNoSuffix2 = this._rbNoSuffix;
      if (rbNoSuffix2 == null)
        return;
      rbNoSuffix2.CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
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
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminPolicyNumbers));
    Appearance appearance40 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblPolicyNumberRules", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RuleID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RuleName");
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Prefix");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("BlockStart");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("BlockEnd");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("TotalBlockDigits");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("WarnLowBlockCount");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("WarnUser");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("NewNumberOnRenewal");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("SequentialStart");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("SequentialTotalDigits");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("YearSuffix");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Fixedvalue");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("SuffixDash");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Manual");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("SuffixSeparateSpace");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("NetrateSunset1Prefix");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("NetrateSunset2Prefix");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("NetrateSunset3Prefix");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("NetrateClaimsMadePrefix");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Runoff");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AlphaSuffix");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("AlphaSuffixRenewalOnly");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("BasedOnEffectiveDate");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ManualNumberOnPurchasedBook");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ManualNumberOnRenewal");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("UseTableBasedNumbering");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("UsePolicyNumberingFromRuleId");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ForceCheckOnRenewal");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("NextNumber");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("UseSubmissionGroupNumbering");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("PromptForManualOverride");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("FourYearSuffix");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("PolicyNumberSuffix");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("AppendTwoDigitYear");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("AppendFourDigitYear");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("AppendPrefix");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ProgCode");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("TwoYearSuffixSeq");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("FourYearSuffixSeq");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("YearSuffixSequentialStart");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("YearSuffixSequentialTotalDigits");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("UseRenewalDigitYear");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("UseInsuredNumber");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ManualMask");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("UseStoredProc");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("NumericalSuffixRenewalOnly");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance46 = new Appearance();
    this.txtPrefix = new MGATextBox();
    this.txtFixedValue = new MGATextBox();
    this.chkNewOnRenewal = new MGACheckBox();
    this.Panel1 = new Panel();
    this.chkNumericRenewalOnly = new MGACheckBox();
    this.Label20 = new Label();
    this.rbFourDigitYearSeq = new RadioButton();
    this.rbTwoDigitYearSeq = new RadioButton();
    this.numYearSeqTotalDigits = new MGANumericEditor();
    this.numYearSeq = new MGANumericEditor();
    this.Label15 = new Label();
    this.rb4DigitYear = new RadioButton();
    this.chkBasedOffEffDate = new MGACheckBox();
    this.checkAlphaRenewalOnly = new MGACheckBox();
    this.rbAlpha = new RadioButton();
    this.chkSpace = new MGACheckBox();
    this.numTotalDigits = new MGANumericEditor();
    this.numSequential = new MGANumericEditor();
    this.rbNoSuffix = new RadioButton();
    this.chkDash = new MGACheckBox();
    this.rbSequential = new RadioButton();
    this.rb2DigitYear = new RadioButton();
    this.rbFixedValue = new RadioButton();
    this.Label5 = new Label();
    this.lblLabel2 = new Label();
    this.lblLabel1 = new Label();
    this.txtPolicyNumberSuffix = new MGATextBox();
    this.Label6 = new Label();
    this.numBlockTotalDigitsStart = new MGANumericEditor();
    this.numBlockTotalDigits = new MGANumericEditor();
    this.txtRuleName = new MGATextBox();
    this.Label1 = new Label();
    this.lblSample = new Label();
    this.ctlSaveUI = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.gbEntry = new UltraGroupBox();
    this.chkUseStoredProc = new MGACheckBox();
    this.lnkMoreNoteUsers = new LinkLabel();
    this.lblMaskDescription = new Label();
    this.txtManualMask = new MGATextBox();
    this.lblManualMask = new Label();
    this.chkUseInsuredNumber = new MGACheckBox();
    this.ds = new dsPolicyNumberAdmin();
    this.lblProgramCode = new Label();
    this.cboProgramCode = new MGASimpleComboBox();
    this.Panel2 = new Panel();
    this.checkManualOnRenewal = new MGACheckBox();
    this.Label3 = new Label();
    this.checkManualonPurchasedBook = new MGACheckBox();
    this.GroupBox1 = new GroupBox();
    this.chkUseRenewalDigitYear = new MGACheckBox();
    this.txtAppendPrefix = new MGATextBox();
    this.rb2YearAppend = new RadioButton();
    this.rb4YearAppend = new RadioButton();
    this.Label10 = new Label();
    this.Label8 = new Label();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.txtNextNumberToAssign = new MGATextBox();
    this.Label9 = new Label();
    this.Label18 = new Label();
    this.chkPromptForManualOverride = new MGACheckBox();
    this.Label16 = new Label();
    this.chkUseSubmissionGroupNumbering = new MGACheckBox();
    this.cboNumbering = new MGASimpleComboBox();
    this.Label17 = new Label();
    this.chkForceCheckNewPolicy = new MGACheckBox();
    this.chkUseTableBasedNumbering = new MGACheckBox();
    this.checkRunoff = new MGACheckBox();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtSunset2 = new MGATextBox();
    this.txtClaimsMade = new MGATextBox();
    this.Label14 = new Label();
    this.txtSunset3 = new MGATextBox();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.txtSunset1 = new MGATextBox();
    this.Label7 = new Label();
    this.numBlockTotalDigitsEnd = new MGANumericEditor();
    this.cboUsers = new MGASimpleComboBox();
    this.Label11 = new Label();
    this.chkManual = new MGACheckBox();
    this.udNumbers = new MGANumericEditor();
    this.err = new ErrorProvider(this.components);
    this.daRule = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.dgRules = new UltraGrid();
    this.btnGenNumbers = new Button();
    this.btnRunOff = new MGAButton();
    ((ISupportInitialize) this.txtPrefix).BeginInit();
    ((ISupportInitialize) this.txtFixedValue).BeginInit();
    ((ISupportInitialize) this.chkNewOnRenewal).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.chkNumericRenewalOnly).BeginInit();
    ((ISupportInitialize) this.numYearSeqTotalDigits).BeginInit();
    ((ISupportInitialize) this.numYearSeq).BeginInit();
    ((ISupportInitialize) this.chkBasedOffEffDate).BeginInit();
    ((ISupportInitialize) this.checkAlphaRenewalOnly).BeginInit();
    ((ISupportInitialize) this.chkSpace).BeginInit();
    ((ISupportInitialize) this.numTotalDigits).BeginInit();
    ((ISupportInitialize) this.numSequential).BeginInit();
    ((ISupportInitialize) this.chkDash).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumberSuffix).BeginInit();
    ((ISupportInitialize) this.numBlockTotalDigitsStart).BeginInit();
    ((ISupportInitialize) this.numBlockTotalDigits).BeginInit();
    ((ISupportInitialize) this.txtRuleName).BeginInit();
    ((ISupportInitialize) this.gbEntry).BeginInit();
    ((Control) this.gbEntry).SuspendLayout();
    ((ISupportInitialize) this.chkUseStoredProc).BeginInit();
    ((ISupportInitialize) this.txtManualMask).BeginInit();
    ((ISupportInitialize) this.chkUseInsuredNumber).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboProgramCode).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.checkManualOnRenewal).BeginInit();
    ((ISupportInitialize) this.checkManualonPurchasedBook).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.chkUseRenewalDigitYear).BeginInit();
    ((ISupportInitialize) this.txtAppendPrefix).BeginInit();
    ((ISupportInitialize) this.txtNextNumberToAssign).BeginInit();
    ((ISupportInitialize) this.chkPromptForManualOverride).BeginInit();
    ((ISupportInitialize) this.chkUseSubmissionGroupNumbering).BeginInit();
    ((ISupportInitialize) this.cboNumbering).BeginInit();
    ((ISupportInitialize) this.chkForceCheckNewPolicy).BeginInit();
    ((ISupportInitialize) this.chkUseTableBasedNumbering).BeginInit();
    ((ISupportInitialize) this.checkRunoff).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtSunset2).BeginInit();
    ((ISupportInitialize) this.txtClaimsMade).BeginInit();
    ((ISupportInitialize) this.txtSunset3).BeginInit();
    ((ISupportInitialize) this.txtSunset1).BeginInit();
    ((ISupportInitialize) this.numBlockTotalDigitsEnd).BeginInit();
    ((ISupportInitialize) this.cboUsers).BeginInit();
    ((ISupportInitialize) this.chkManual).BeginInit();
    ((ISupportInitialize) this.udNumbers).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dgRules).BeginInit();
    ((ISupportInitialize) this.btnRunOff).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPrefix).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtPrefix).BackColor = Color.White;
    ((Control) this.txtPrefix).Location = new Point(89, 97);
    ((TextEditorControlBase) this.txtPrefix).MaxLength = 20;
    this.txtPrefix.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPrefix).Name = "txtPrefix";
    ((Control) this.txtPrefix).Size = new Size(106, 20);
    ((Control) this.txtPrefix).TabIndex = 10;
    ((UltraControlBase) this.txtPrefix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPrefix).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFixedValue).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtFixedValue).BackColor = Color.White;
    ((Control) this.txtFixedValue).Location = new Point(112 /*0x70*/, 90);
    this.txtFixedValue.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFixedValue).Name = "txtFixedValue";
    ((Control) this.txtFixedValue).Size = new Size(77, 20);
    ((Control) this.txtFixedValue).TabIndex = 8;
    ((UltraControlBase) this.txtFixedValue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFixedValue).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNewOnRenewal).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkNewOnRenewal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNewOnRenewal).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNewOnRenewal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNewOnRenewal).Location = new Point(91, 244);
    this.chkNewOnRenewal.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkNewOnRenewal).Name = "chkNewOnRenewal";
    ((Control) this.chkNewOnRenewal).Size = new Size(147, 24);
    ((Control) this.chkNewOnRenewal).TabIndex = 25;
    ((UltraToggleEditorBase) this.chkNewOnRenewal).Text = "New number on renewal";
    ((UltraControlBase) this.chkNewOnRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNewOnRenewal).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.BorderStyle = BorderStyle.FixedSingle;
    this.Panel1.Controls.Add((Control) this.chkNumericRenewalOnly);
    this.Panel1.Controls.Add((Control) this.Label20);
    this.Panel1.Controls.Add((Control) this.rbFourDigitYearSeq);
    this.Panel1.Controls.Add((Control) this.rbTwoDigitYearSeq);
    this.Panel1.Controls.Add((Control) this.numYearSeqTotalDigits);
    this.Panel1.Controls.Add((Control) this.numYearSeq);
    this.Panel1.Controls.Add((Control) this.Label15);
    this.Panel1.Controls.Add((Control) this.rb4DigitYear);
    this.Panel1.Controls.Add((Control) this.chkBasedOffEffDate);
    this.Panel1.Controls.Add((Control) this.checkAlphaRenewalOnly);
    this.Panel1.Controls.Add((Control) this.rbAlpha);
    this.Panel1.Controls.Add((Control) this.chkSpace);
    this.Panel1.Controls.Add((Control) this.numTotalDigits);
    this.Panel1.Controls.Add((Control) this.numSequential);
    this.Panel1.Controls.Add((Control) this.rbNoSuffix);
    this.Panel1.Controls.Add((Control) this.chkDash);
    this.Panel1.Controls.Add((Control) this.txtFixedValue);
    this.Panel1.Controls.Add((Control) this.rbSequential);
    this.Panel1.Controls.Add((Control) this.rb2DigitYear);
    this.Panel1.Controls.Add((Control) this.rbFixedValue);
    this.Panel1.Controls.Add((Control) this.Label5);
    this.Panel1.Location = new Point(89, 281);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(726, 167);
    this.Panel1.TabIndex = 29;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNumericRenewalOnly).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkNumericRenewalOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNumericRenewalOnly).Location = new Point(409, 112 /*0x70*/);
    this.chkNumericRenewalOnly.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkNumericRenewalOnly).Name = "chkNumericRenewalOnly";
    ((Control) this.chkNumericRenewalOnly).Size = new Size(279, 18);
    ((Control) this.chkNumericRenewalOnly).TabIndex = 20;
    ((UltraToggleEditorBase) this.chkNumericRenewalOnly).Text = "Numerical Suffix on Renewal Only";
    ((UltraControlBase) this.chkNumericRenewalOnly).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNumericRenewalOnly).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(243, 145);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(106, 13);
    this.Label20.TabIndex = 12;
    this.Label20.Text = "sequence starting at";
    this.Label20.TextAlign = ContentAlignment.MiddleLeft;
    this.rbFourDigitYearSeq.Location = new Point(125, 141);
    this.rbFourDigitYearSeq.Name = "rbFourDigitYearSeq";
    this.rbFourDigitYearSeq.Size = new Size(111, 21);
    this.rbFourDigitYearSeq.TabIndex = 11;
    this.rbFourDigitYearSeq.Text = "4 Digit Year Seq";
    this.rbTwoDigitYearSeq.Location = new Point(7, 141);
    this.rbTwoDigitYearSeq.Name = "rbTwoDigitYearSeq";
    this.rbTwoDigitYearSeq.Size = new Size(111, 21);
    this.rbTwoDigitYearSeq.TabIndex = 10;
    this.rbTwoDigitYearSeq.Text = "2 Digit Year Seq";
    appearance5.BackColorDisabled = Color.Gainsboro;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numYearSeqTotalDigits).Appearance = (AppearanceBase) appearance5;
    ((Control) this.numYearSeqTotalDigits).Location = new Point(514, 141);
    ((UltraNumericEditor) this.numYearSeqTotalDigits).MaskInput = "n";
    ((UltraNumericEditor) this.numYearSeqTotalDigits).MaxValue = (object) 6;
    this.numYearSeqTotalDigits.MGAStyle = (MGAStyles) 2;
    ((Control) this.numYearSeqTotalDigits).Name = "numYearSeqTotalDigits";
    ((UltraNumericEditor) this.numYearSeqTotalDigits).Nullable = true;
    ((Control) this.numYearSeqTotalDigits).Size = new Size(36, 20);
    ((Control) this.numYearSeqTotalDigits).TabIndex = 15;
    ((UltraControlBase) this.numYearSeqTotalDigits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numYearSeqTotalDigits).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BackColorDisabled = Color.Gainsboro;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numYearSeq).Appearance = (AppearanceBase) appearance6;
    ((Control) this.numYearSeq).Location = new Point(359, 141);
    ((UltraNumericEditor) this.numYearSeq).MaskInput = "nnnn";
    ((UltraNumericEditor) this.numYearSeq).MaxValue = (object) 9999;
    this.numYearSeq.MGAStyle = (MGAStyles) 2;
    ((Control) this.numYearSeq).Name = "numYearSeq";
    ((UltraNumericEditor) this.numYearSeq).Nullable = true;
    ((Control) this.numYearSeq).Size = new Size(68, 20);
    ((Control) this.numYearSeq).TabIndex = 13;
    ((UltraControlBase) this.numYearSeq).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numYearSeq).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.Location = new Point(437, 144 /*0x90*/);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(70, 14);
    this.Label15.TabIndex = 14;
    this.Label15.Text = "Total digits:";
    this.Label15.TextAlign = ContentAlignment.MiddleRight;
    this.rb4DigitYear.Location = new Point(112 /*0x70*/, 61);
    this.rb4DigitYear.Name = "rb4DigitYear";
    this.rb4DigitYear.Size = new Size(84, 21);
    this.rb4DigitYear.TabIndex = 6;
    this.rb4DigitYear.Text = "4 Digit Year";
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkBasedOffEffDate).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkBasedOffEffDate).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkBasedOffEffDate).Location = new Point(409, 7);
    this.chkBasedOffEffDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkBasedOffEffDate).Name = "chkBasedOffEffDate";
    ((Control) this.chkBasedOffEffDate).Size = new Size(237, 24);
    ((Control) this.chkBasedOffEffDate).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkBasedOffEffDate).Text = "Selects rule based on policy effective date";
    ((UltraControlBase) this.chkBasedOffEffDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkBasedOffEffDate).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkAlphaRenewalOnly).Location = new Point(409, 34);
    this.checkAlphaRenewalOnly.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkAlphaRenewalOnly).Name = "checkAlphaRenewalOnly";
    ((Control) this.checkAlphaRenewalOnly).Size = new Size(179, 24);
    ((Control) this.checkAlphaRenewalOnly).TabIndex = 17;
    ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Text = "Alpha suffix on renewals only";
    ((UltraControlBase) this.checkAlphaRenewalOnly).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkAlphaRenewalOnly).UseOsThemes = (DefaultableBoolean) 2;
    this.rbAlpha.Location = new Point(7, 115);
    this.rbAlpha.Name = "rbAlpha";
    this.rbAlpha.Size = new Size(98, 24);
    this.rbAlpha.TabIndex = 9;
    this.rbAlpha.Text = "Alphabetical";
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSpace).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkSpace).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSpace).Location = new Point(409, 61);
    this.chkSpace.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkSpace).Name = "chkSpace";
    ((Control) this.chkSpace).Size = new Size(178, 21);
    ((Control) this.chkSpace).TabIndex = 18;
    ((UltraToggleEditorBase) this.chkSpace).Text = "Suffix separated with a space";
    ((UltraControlBase) this.chkSpace).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSpace).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BackColorDisabled = Color.Gainsboro;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTotalDigits).Appearance = (AppearanceBase) appearance10;
    ((Control) this.numTotalDigits).Location = new Point(290, 36);
    ((UltraNumericEditor) this.numTotalDigits).MaskInput = "n";
    ((UltraNumericEditor) this.numTotalDigits).MaxValue = (object) 6;
    this.numTotalDigits.MGAStyle = (MGAStyles) 2;
    ((Control) this.numTotalDigits).Name = "numTotalDigits";
    ((UltraNumericEditor) this.numTotalDigits).Nullable = true;
    ((Control) this.numTotalDigits).Size = new Size(36, 20);
    ((Control) this.numTotalDigits).TabIndex = 4;
    ((UltraControlBase) this.numTotalDigits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTotalDigits).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColorDisabled = Color.Gainsboro;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numSequential).Appearance = (AppearanceBase) appearance11;
    ((Control) this.numSequential).Location = new Point(140, 36);
    ((UltraNumericEditor) this.numSequential).MaskInput = "nnnn";
    ((UltraNumericEditor) this.numSequential).MaxValue = (object) 9999;
    this.numSequential.MGAStyle = (MGAStyles) 2;
    ((Control) this.numSequential).Name = "numSequential";
    ((UltraNumericEditor) this.numSequential).Nullable = true;
    ((Control) this.numSequential).Size = new Size(68, 20);
    ((Control) this.numSequential).TabIndex = 2;
    ((UltraControlBase) this.numSequential).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numSequential).UseOsThemes = (DefaultableBoolean) 2;
    this.rbNoSuffix.Checked = true;
    this.rbNoSuffix.Location = new Point(7, 7);
    this.rbNoSuffix.Name = "rbNoSuffix";
    this.rbNoSuffix.Size = new Size(84, 21);
    this.rbNoSuffix.TabIndex = 0;
    this.rbNoSuffix.TabStop = true;
    this.rbNoSuffix.Text = "No Suffix";
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDash).Appearance = (AppearanceBase) appearance12;
    ((UltraToggleEditorBase) this.chkDash).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDash).Location = new Point(409, 88);
    this.chkDash.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkDash).Name = "chkDash";
    ((Control) this.chkDash).Size = new Size(166, 18);
    ((Control) this.chkDash).TabIndex = 19;
    ((UltraToggleEditorBase) this.chkDash).Text = "Suffix separated with a dash";
    ((UltraControlBase) this.chkDash).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDash).UseOsThemes = (DefaultableBoolean) 2;
    this.rbSequential.Location = new Point(7, 34);
    this.rbSequential.Name = "rbSequential";
    this.rbSequential.Size = new Size(133, 22);
    this.rbSequential.TabIndex = 1;
    this.rbSequential.Text = "Sequential starting at";
    this.rb2DigitYear.Location = new Point(7, 61);
    this.rb2DigitYear.Name = "rb2DigitYear";
    this.rb2DigitYear.Size = new Size(84, 21);
    this.rb2DigitYear.TabIndex = 5;
    this.rb2DigitYear.Text = "2 Digit Year";
    this.rbFixedValue.Location = new Point(7, 88);
    this.rbFixedValue.Name = "rbFixedValue";
    this.rbFixedValue.Size = new Size(98, 24);
    this.rbFixedValue.TabIndex = 7;
    this.rbFixedValue.Text = "Fixed value of";
    this.Label5.Location = new Point(214, 38);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(70, 14);
    this.Label5.TabIndex = 3;
    this.Label5.Text = "Total digits:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.lblLabel2.AutoSize = true;
    this.lblLabel2.BackColor = Color.Transparent;
    this.lblLabel2.Location = new Point(190, 458);
    this.lblLabel2.Name = "lblLabel2";
    this.lblLabel2.Size = new Size(96 /*0x60*/, 13);
    this.lblLabel2.TabIndex = 32 /*0x20*/;
    this.lblLabel2.Text = "at end of policy #.";
    this.lblLabel1.AutoSize = true;
    this.lblLabel1.BackColor = Color.Transparent;
    this.lblLabel1.Location = new Point(29, 458);
    this.lblLabel1.Name = "lblLabel1";
    this.lblLabel1.Size = new Size(48 /*0x30*/, 13);
    this.lblLabel1.TabIndex = 18;
    this.lblLabel1.Text = "Append:";
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyNumberSuffix).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtPolicyNumberSuffix).BackColor = Color.White;
    ((Control) this.txtPolicyNumberSuffix).Location = new Point(89, 454);
    ((TextEditorControlBase) this.txtPolicyNumberSuffix).MaxLength = 10;
    this.txtPolicyNumberSuffix.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolicyNumberSuffix).Name = "txtPolicyNumberSuffix";
    ((Control) this.txtPolicyNumberSuffix).Size = new Size(89, 20);
    ((Control) this.txtPolicyNumberSuffix).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.txtPolicyNumberSuffix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyNumberSuffix).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(35, 281);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(42, 14);
    this.Label6.TabIndex = 30;
    this.Label6.Text = "Suffix:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    appearance14.BackColorDisabled = Color.Gainsboro;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBlockTotalDigitsStart).Appearance = (AppearanceBase) appearance14;
    ((Control) this.numBlockTotalDigitsStart).Location = new Point(91, 210);
    ((UltraNumericEditor) this.numBlockTotalDigitsStart).MaskInput = "nnnnnnnn";
    ((UltraNumericEditor) this.numBlockTotalDigitsStart).MaxValue = (object) 99999999;
    this.numBlockTotalDigitsStart.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numBlockTotalDigitsStart).MinValue = (object) -1;
    ((Control) this.numBlockTotalDigitsStart).Name = "numBlockTotalDigitsStart";
    ((UltraNumericEditor) this.numBlockTotalDigitsStart).Nullable = true;
    ((Control) this.numBlockTotalDigitsStart).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.numBlockTotalDigitsStart).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.numBlockTotalDigitsStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBlockTotalDigitsStart).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BackColorDisabled = Color.Gainsboro;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBlockTotalDigits).Appearance = (AppearanceBase) appearance15;
    ((Control) this.numBlockTotalDigits).Location = new Point(365, 210);
    ((UltraNumericEditor) this.numBlockTotalDigits).MaskInput = "nnnn";
    ((UltraNumericEditor) this.numBlockTotalDigits).MaxValue = (object) 8;
    this.numBlockTotalDigits.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.numBlockTotalDigits).MinValue = (object) 1;
    ((Control) this.numBlockTotalDigits).Name = "numBlockTotalDigits";
    ((UltraNumericEditor) this.numBlockTotalDigits).Nullable = true;
    ((Control) this.numBlockTotalDigits).Size = new Size(46, 20);
    ((Control) this.numBlockTotalDigits).TabIndex = 20;
    ((UltraControlBase) this.numBlockTotalDigits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBlockTotalDigits).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numBlockTotalDigits).Value = (object) 3;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRuleName).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.txtRuleName).BackColor = Color.White;
    ((Control) this.txtRuleName).Enabled = false;
    ((Control) this.txtRuleName).Location = new Point(89, 21);
    ((TextEditorControlBase) this.txtRuleName).MaxLength = 50;
    this.txtRuleName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtRuleName).Name = "txtRuleName";
    ((Control) this.txtRuleName).Size = new Size(388, 20);
    ((Control) this.txtRuleName).TabIndex = 0;
    ((UltraControlBase) this.txtRuleName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRuleName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.Location = new Point(170, 147);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 17);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Sample:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.lblSample.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblSample.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSample.Location = new Point(233, 150);
    this.lblSample.Name = "lblSample";
    this.lblSample.Size = new Size(301, 14);
    this.lblSample.TabIndex = 2;
    ((Control) this.ctlSaveUI).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.ctlSaveUI.EditStyle = (EditStyle) 1;
    this.ctlSaveUI.FreezeEvents = false;
    ((Control) this.ctlSaveUI).Location = new Point(733, 660);
    ((Control) this.ctlSaveUI).Name = "ctlSaveUI";
    ((Control) this.ctlSaveUI).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.ctlSaveUI).TabIndex = 3;
    this.ctlSaveUI.UIState = (UIState) 1;
    ((Control) this.gbEntry).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance17.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.gbEntry.ContentAreaAppearance = (AppearanceBase) appearance17;
    ((Control) this.gbEntry).Controls.Add((Control) this.chkUseStoredProc);
    ((Control) this.gbEntry).Controls.Add((Control) this.lnkMoreNoteUsers);
    ((Control) this.gbEntry).Controls.Add((Control) this.lblMaskDescription);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtManualMask);
    ((Control) this.gbEntry).Controls.Add((Control) this.lblManualMask);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkUseInsuredNumber);
    ((Control) this.gbEntry).Controls.Add((Control) this.lblProgramCode);
    ((Control) this.gbEntry).Controls.Add((Control) this.cboProgramCode);
    ((Control) this.gbEntry).Controls.Add((Control) this.Panel2);
    ((Control) this.gbEntry).Controls.Add((Control) this.GroupBox1);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label10);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label8);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label4);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label2);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtNextNumberToAssign);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label9);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label18);
    ((Control) this.gbEntry).Controls.Add((Control) this.lblLabel2);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtPrefix);
    ((Control) this.gbEntry).Controls.Add((Control) this.lblLabel1);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkPromptForManualOverride);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label16);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkUseSubmissionGroupNumbering);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtPolicyNumberSuffix);
    ((Control) this.gbEntry).Controls.Add((Control) this.cboNumbering);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label17);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkForceCheckNewPolicy);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkUseTableBasedNumbering);
    ((Control) this.gbEntry).Controls.Add((Control) this.checkRunoff);
    ((Control) this.gbEntry).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.gbEntry).Controls.Add((Control) this.numBlockTotalDigitsEnd);
    ((Control) this.gbEntry).Controls.Add((Control) this.cboUsers);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label11);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkManual);
    ((Control) this.gbEntry).Controls.Add((Control) this.numBlockTotalDigitsStart);
    ((Control) this.gbEntry).Controls.Add((Control) this.chkNewOnRenewal);
    ((Control) this.gbEntry).Controls.Add((Control) this.numBlockTotalDigits);
    ((Control) this.gbEntry).Controls.Add((Control) this.Label6);
    ((Control) this.gbEntry).Controls.Add((Control) this.Panel1);
    ((Control) this.gbEntry).Controls.Add((Control) this.udNumbers);
    ((Control) this.gbEntry).Controls.Add((Control) this.txtRuleName);
    appearance18.BackColor = Color.FromArgb(159, 188, 218);
    appearance18.BackColor2 = Color.FromArgb(183, 210, 239);
    appearance18.FontData.BoldAsString = "True";
    appearance18.ForeColor = Color.FromArgb(13, 40, 107);
    this.gbEntry.HeaderAppearance = (AppearanceBase) appearance18;
    ((Control) this.gbEntry).Location = new Point(13, 167);
    ((Control) this.gbEntry).Name = "gbEntry";
    ((Control) this.gbEntry).Size = new Size(832, 487);
    ((Control) this.gbEntry).TabIndex = 0;
    this.gbEntry.Text = "Rule Information";
    this.gbEntry.ViewStyle = (GroupBoxViewStyle) 2;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseStoredProc).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkUseStoredProc).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseStoredProc).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseStoredProc).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseStoredProc).Location = new Point(497, 71);
    this.chkUseStoredProc.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkUseStoredProc).Name = "chkUseStoredProc";
    ((Control) this.chkUseStoredProc).Size = new Size(116, 14);
    ((Control) this.chkUseStoredProc).TabIndex = 44;
    ((UltraToggleEditorBase) this.chkUseStoredProc).Text = "Use Stored Proc";
    ((UltraControlBase) this.chkUseStoredProc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseStoredProc).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkMoreNoteUsers.AutoSize = true;
    this.lnkMoreNoteUsers.BackColor = Color.Transparent;
    this.lnkMoreNoteUsers.Location = new Point(680, 186);
    this.lnkMoreNoteUsers.Name = "lnkMoreNoteUsers";
    this.lnkMoreNoteUsers.Size = new Size(113, 13);
    this.lnkMoreNoteUsers.TabIndex = 43;
    this.lnkMoreNoteUsers.TabStop = true;
    this.lnkMoreNoteUsers.Text = "Notes - more users ...";
    this.lblMaskDescription.AutoSize = true;
    this.lblMaskDescription.BackColor = Color.Transparent;
    this.lblMaskDescription.Location = new Point(339, 75);
    this.lblMaskDescription.Name = "lblMaskDescription";
    this.lblMaskDescription.Size = new Size(130, 13);
    this.lblMaskDescription.TabIndex = 9;
    this.lblMaskDescription.Text = "(X - Letters. 9 - Numbers)";
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtManualMask).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtManualMask).BackColor = Color.White;
    ((Control) this.txtManualMask).Location = new Point(89, 71);
    ((TextEditorControlBase) this.txtManualMask).MaxLength = 50;
    this.txtManualMask.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtManualMask).Name = "txtManualMask";
    ((Control) this.txtManualMask).Size = new Size(244, 20);
    ((Control) this.txtManualMask).TabIndex = 8;
    ((UltraControlBase) this.txtManualMask).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtManualMask).UseOsThemes = (DefaultableBoolean) 2;
    this.lblManualMask.BackColor = Color.Transparent;
    this.lblManualMask.Location = new Point(5, 73);
    this.lblManualMask.Name = "lblManualMask";
    this.lblManualMask.Size = new Size(78, 14);
    this.lblManualMask.TabIndex = 42;
    this.lblManualMask.Text = "Manual Mask:";
    this.lblManualMask.TextAlign = ContentAlignment.MiddleRight;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseInsuredNumber).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkUseInsuredNumber).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseInsuredNumber).BackColorInternal = Color.Transparent;
    ((Control) this.chkUseInsuredNumber).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblPolicyNumberRules.UseInsuredNumber", true));
    ((UltraToggleEditorBase) this.chkUseInsuredNumber).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseInsuredNumber).Location = new Point(683, 51);
    this.chkUseInsuredNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkUseInsuredNumber).Name = "chkUseInsuredNumber";
    ((Control) this.chkUseInsuredNumber).Size = new Size(130, 15);
    ((Control) this.chkUseInsuredNumber).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkUseInsuredNumber).Text = "Use insured Number";
    ((UltraControlBase) this.chkUseInsuredNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseInsuredNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPolicyNumberAdmin";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblProgramCode.AutoSize = true;
    this.lblProgramCode.BackColor = Color.Transparent;
    this.lblProgramCode.Location = new Point(475, 98);
    this.lblProgramCode.Name = "lblProgramCode";
    this.lblProgramCode.Size = new Size(79, 13);
    this.lblProgramCode.TabIndex = 13;
    this.lblProgramCode.Text = "Program Code:";
    ((UltraCombo) this.cboProgramCode).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProgramCode).DataSource = (object) this.ds.tblCompanyProgramCodes;
    ((UltraDropDownBase) this.cboProgramCode).DisplayMember = "ProgCode";
    ((UltraCombo) this.cboProgramCode).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProgramCode).Location = new Point(569, 94);
    this.cboProgramCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProgramCode).Name = "cboProgramCode";
    ((Control) this.cboProgramCode).Size = new Size(246, 21);
    ((Control) this.cboProgramCode).TabIndex = 14;
    ((UltraControlBase) this.cboProgramCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProgramCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProgramCode).ValueMember = "ProgCode";
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.BorderStyle = BorderStyle.FixedSingle;
    this.Panel2.Controls.Add((Control) this.checkManualOnRenewal);
    this.Panel2.Controls.Add((Control) this.Label3);
    this.Panel2.Controls.Add((Control) this.checkManualonPurchasedBook);
    this.Panel2.Location = new Point(490, 242);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(325, 28);
    this.Panel2.TabIndex = 29;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkManualOnRenewal).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.checkManualOnRenewal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkManualOnRenewal).BackColorInternal = Color.Transparent;
    ((Control) this.checkManualOnRenewal).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblPolicyNumberRules.ManualNumberOnRenewal", true));
    ((UltraToggleEditorBase) this.checkManualOnRenewal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkManualOnRenewal).Location = new Point(253, 2);
    this.checkManualOnRenewal.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkManualOnRenewal).Name = "checkManualOnRenewal";
    ((Control) this.checkManualOnRenewal).Size = new Size(66, 19);
    ((Control) this.checkManualOnRenewal).TabIndex = 2;
    ((UltraToggleEditorBase) this.checkManualOnRenewal).Text = "Renewal";
    ((UltraControlBase) this.checkManualOnRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkManualOnRenewal).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(6, 5);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(116, 13);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Manual Numbering On:";
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkManualonPurchasedBook).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.checkManualonPurchasedBook).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkManualonPurchasedBook).BackColorInternal = Color.Transparent;
    ((Control) this.checkManualonPurchasedBook).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblPolicyNumberRules.ManualNumberOnPurchasedBook", true));
    ((UltraToggleEditorBase) this.checkManualonPurchasedBook).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkManualonPurchasedBook).Location = new Point(132, 2);
    this.checkManualonPurchasedBook.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkManualonPurchasedBook).Name = "checkManualonPurchasedBook";
    ((Control) this.checkManualonPurchasedBook).Size = new Size(111, 19);
    ((Control) this.checkManualonPurchasedBook).TabIndex = 1;
    ((UltraToggleEditorBase) this.checkManualonPurchasedBook).Text = "Purchased Book";
    ((UltraControlBase) this.checkManualonPurchasedBook).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkManualonPurchasedBook).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox1.BackColor = Color.Transparent;
    this.GroupBox1.Controls.Add((Control) this.chkUseRenewalDigitYear);
    this.GroupBox1.Controls.Add((Control) this.txtAppendPrefix);
    this.GroupBox1.Controls.Add((Control) this.rb2YearAppend);
    this.GroupBox1.Controls.Add((Control) this.rb4YearAppend);
    this.GroupBox1.Location = new Point(91, 168);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(551, 36);
    this.GroupBox1.TabIndex = 13;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "After Prefix, Append ";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseRenewalDigitYear).Location = new Point(367, 11);
    this.chkUseRenewalDigitYear.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkUseRenewalDigitYear).Name = "chkUseRenewalDigitYear";
    ((Control) this.chkUseRenewalDigitYear).Size = new Size(157, 24);
    ((Control) this.chkUseRenewalDigitYear).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Text = "Use Renewals Digit Year";
    ((UltraControlBase) this.chkUseRenewalDigitYear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseRenewalDigitYear).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAppendPrefix).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.txtAppendPrefix).BackColor = Color.White;
    ((Control) this.txtAppendPrefix).Location = new Point(247, 14);
    ((TextEditorControlBase) this.txtAppendPrefix).MaxLength = 10;
    this.txtAppendPrefix.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAppendPrefix).Name = "txtAppendPrefix";
    ((Control) this.txtAppendPrefix).Size = new Size(100, 20);
    ((Control) this.txtAppendPrefix).TabIndex = 3;
    ((UltraControlBase) this.txtAppendPrefix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAppendPrefix).UseOsThemes = (DefaultableBoolean) 2;
    this.rb2YearAppend.BackColor = Color.Transparent;
    this.rb2YearAppend.Location = new Point(22, 14);
    this.rb2YearAppend.Name = "rb2YearAppend";
    this.rb2YearAppend.Size = new Size(84, 21);
    this.rb2YearAppend.TabIndex = 1;
    this.rb2YearAppend.Text = "2 Digit Year";
    this.rb2YearAppend.UseVisualStyleBackColor = false;
    this.rb4YearAppend.BackColor = Color.Transparent;
    this.rb4YearAppend.Location = new Point(134, 13);
    this.rb4YearAppend.Name = "rb4YearAppend";
    this.rb4YearAppend.Size = new Size(84, 21);
    this.rb4YearAppend.TabIndex = 2;
    this.rb4YearAppend.Text = "4 Digit Year";
    this.rb4YearAppend.UseVisualStyleBackColor = false;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(15, 214);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(62, 13);
    this.Label10.TabIndex = 14;
    this.Label10.Text = "Block Start:";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(418, 214);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(35, 13);
    this.Label8.TabIndex = 21;
    this.Label8.Text = "When";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(295, 214);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(63 /*0x3F*/, 13);
    this.Label4.TabIndex = 19;
    this.Label4.Text = "Total digits:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(160 /*0xA0*/, 214);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(56, 13);
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Block End:";
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNextNumberToAssign).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.txtNextNumberToAssign).BackColor = Color.White;
    ((Control) this.txtNextNumberToAssign).Location = new Point(336, 94);
    ((TextEditorControlBase) this.txtNextNumberToAssign).MaxLength = 20;
    this.txtNextNumberToAssign.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtNextNumberToAssign).Name = "txtNextNumberToAssign";
    ((EditorButtonControlBase) this.txtNextNumberToAssign).ReadOnly = true;
    ((Control) this.txtNextNumberToAssign).Size = new Size(100, 20);
    ((Control) this.txtNextNumberToAssign).TabIndex = 12;
    ((UltraControlBase) this.txtNextNumberToAssign).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNextNumberToAssign).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(38, 101);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(39, 13);
    this.Label9.TabIndex = 11;
    this.Label9.Text = "Prefix:";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(15, 25);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(62, 13);
    this.Label18.TabIndex = 0;
    this.Label18.Text = "Rule Name:";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPromptForManualOverride).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkPromptForManualOverride).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPromptForManualOverride).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPromptForManualOverride).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPromptForManualOverride).Location = new Point(497, 51);
    this.chkPromptForManualOverride.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkPromptForManualOverride).Name = "chkPromptForManualOverride";
    ((Control) this.chkPromptForManualOverride).Size = new Size(177, 14);
    ((Control) this.chkPromptForManualOverride).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkPromptForManualOverride).Text = "Prompt for Manual Override";
    ((UltraControlBase) this.chkPromptForManualOverride).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPromptForManualOverride).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(231, 97);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(95, 14);
    this.Label16.TabIndex = 11;
    this.Label16.Text = "Next # to Assign:";
    this.Label16.TextAlign = ContentAlignment.MiddleRight;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseSubmissionGroupNumbering).Location = new Point(352, 48 /*0x30*/);
    this.chkUseSubmissionGroupNumbering.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkUseSubmissionGroupNumbering).Name = "chkUseSubmissionGroupNumbering";
    ((Control) this.chkUseSubmissionGroupNumbering).Size = new Size(136, 21);
    ((Control) this.chkUseSubmissionGroupNumbering).TabIndex = 5;
    ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Text = "Sub. Group Numbering";
    ((UltraControlBase) this.chkUseSubmissionGroupNumbering).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseSubmissionGroupNumbering).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboNumbering).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboNumbering).DataSource = (object) this.ds.tblUsers;
    ((UltraDropDownBase) this.cboNumbering).DisplayMember = "RuleName";
    ((UltraCombo) this.cboNumbering).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNumbering).Location = new Point(569, 21);
    this.cboNumbering.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboNumbering).Name = "cboNumbering";
    ((Control) this.cboNumbering).Size = new Size(246, 21);
    ((Control) this.cboNumbering).TabIndex = 2;
    ((UltraControlBase) this.cboNumbering).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNumbering).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboNumbering).ValueMember = "RuleID";
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(500, 24);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(63 /*0x3F*/, 14);
    this.Label17.TabIndex = 1;
    this.Label17.Text = "Use Seq.:";
    this.Label17.TextAlign = ContentAlignment.MiddleLeft;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Appearance = (AppearanceBase) appearance29;
    ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkForceCheckNewPolicy).Location = new Point(329, 244);
    this.chkForceCheckNewPolicy.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkForceCheckNewPolicy).Name = "chkForceCheckNewPolicy";
    ((Control) this.chkForceCheckNewPolicy).Size = new Size(155, 24);
    ((Control) this.chkForceCheckNewPolicy).TabIndex = 27;
    ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Text = "Force New Rule On Renew";
    ((UltraControlBase) this.chkForceCheckNewPolicy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkForceCheckNewPolicy).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Appearance = (AppearanceBase) appearance30;
    ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseTableBasedNumbering).Location = new Point(191, 48 /*0x30*/);
    this.chkUseTableBasedNumbering.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkUseTableBasedNumbering).Name = "chkUseTableBasedNumbering";
    ((Control) this.chkUseTableBasedNumbering).Size = new Size(152, 21);
    ((Control) this.chkUseTableBasedNumbering).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Text = "Table-Based Numbering";
    ((UltraControlBase) this.chkUseTableBasedNumbering).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseTableBasedNumbering).UseOsThemes = (DefaultableBoolean) 2;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkRunoff).Appearance = (AppearanceBase) appearance31;
    ((UltraToggleEditorBase) this.checkRunoff).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkRunoff).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkRunoff).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkRunoff).Location = new Point(251, 244);
    this.checkRunoff.MGAStyle = (MGAStyles) 2;
    ((Control) this.checkRunoff).Name = "checkRunoff";
    ((Control) this.checkRunoff).Size = new Size(65, 24);
    ((Control) this.checkRunoff).TabIndex = 26;
    ((UltraToggleEditorBase) this.checkRunoff).Text = "Run-off";
    ((UltraControlBase) this.checkRunoff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkRunoff).UseOsThemes = (DefaultableBoolean) 2;
    appearance32.BackColor = Color.Transparent;
    this.UltraGroupBox1.Appearance = (AppearanceBase) appearance32;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtSunset2);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtClaimsMade);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label14);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtSunset3);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtSunset1);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraGroupBox1).Location = new Point(89, 123);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(726, 44);
    ((Control) this.UltraGroupBox1).TabIndex = 15;
    this.UltraGroupBox1.Text = "NetRate Prefixes";
    this.UltraGroupBox1.ViewStyle = (GroupBoxViewStyle) 5;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSunset2).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.txtSunset2).BackColor = Color.White;
    ((Control) this.txtSunset2).Location = new Point(247, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtSunset2).MaxLength = 10;
    this.txtSunset2.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSunset2).Name = "txtSunset2";
    ((Control) this.txtSunset2).Size = new Size(100, 20);
    ((Control) this.txtSunset2).TabIndex = 3;
    ((UltraControlBase) this.txtSunset2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSunset2).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtClaimsMade).Appearance = (AppearanceBase) appearance34;
    ((TextEditorControlBase) this.txtClaimsMade).BackColor = Color.White;
    ((Control) this.txtClaimsMade).Location = new Point(610, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtClaimsMade).MaxLength = 10;
    this.txtClaimsMade.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtClaimsMade).Name = "txtClaimsMade";
    ((Control) this.txtClaimsMade).Size = new Size(100, 20);
    ((Control) this.txtClaimsMade).TabIndex = 7;
    ((UltraControlBase) this.txtClaimsMade).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClaimsMade).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(530, 20);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(70, 13);
    this.Label14.TabIndex = 6;
    this.Label14.Text = "Claims Made:";
    this.Label14.TextAlign = ContentAlignment.MiddleLeft;
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSunset3).Appearance = (AppearanceBase) appearance35;
    ((TextEditorControlBase) this.txtSunset3).BackColor = Color.White;
    ((Control) this.txtSunset3).Location = new Point(420, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtSunset3).MaxLength = 10;
    this.txtSunset3.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSunset3).Name = "txtSunset3";
    ((Control) this.txtSunset3).Size = new Size(100, 20);
    ((Control) this.txtSunset3).TabIndex = 5;
    ((UltraControlBase) this.txtSunset3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSunset3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(357, 20);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(53, 13);
    this.Label13.TabIndex = 4;
    this.Label13.Text = "Sunset 3:";
    this.Label13.TextAlign = ContentAlignment.MiddleLeft;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(184, 20);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(53, 13);
    this.Label12.TabIndex = 2;
    this.Label12.Text = "Sunset 2:";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSunset1).Appearance = (AppearanceBase) appearance36;
    ((TextEditorControlBase) this.txtSunset1).BackColor = Color.White;
    ((Control) this.txtSunset1).Location = new Point(74, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtSunset1).MaxLength = 10;
    this.txtSunset1.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSunset1).Name = "txtSunset1";
    ((Control) this.txtSunset1).Size = new Size(100, 20);
    ((Control) this.txtSunset1).TabIndex = 1;
    ((UltraControlBase) this.txtSunset1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSunset1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(11, 20);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(53, 13);
    this.Label7.TabIndex = 0;
    this.Label7.Text = "Sunset 1:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    appearance37.BackColorDisabled = Color.Gainsboro;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBlockTotalDigitsEnd).Appearance = (AppearanceBase) appearance37;
    ((Control) this.numBlockTotalDigitsEnd).Location = new Point(223, 210);
    ((UltraNumericEditor) this.numBlockTotalDigitsEnd).MaskInput = "nnnnnnnn";
    ((UltraNumericEditor) this.numBlockTotalDigitsEnd).MaxValue = (object) 99999999;
    this.numBlockTotalDigitsEnd.MGAStyle = (MGAStyles) 2;
    ((Control) this.numBlockTotalDigitsEnd).Name = "numBlockTotalDigitsEnd";
    ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Nullable = true;
    ((Control) this.numBlockTotalDigitsEnd).Size = new Size(65, 20);
    ((Control) this.numBlockTotalDigitsEnd).TabIndex = 18;
    ((UltraControlBase) this.numBlockTotalDigitsEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBlockTotalDigitsEnd).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboUsers).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUsers).DataSource = (object) this.ds.tblUsers;
    ((UltraDropDownBase) this.cboUsers).DisplayMember = "UserName";
    ((UltraCombo) this.cboUsers).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUsers).Location = new Point(678, 210);
    this.cboUsers.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUsers).Name = "cboUsers";
    ((Control) this.cboUsers).Size = new Size(137, 21);
    ((Control) this.cboUsers).TabIndex = 24;
    ((UltraControlBase) this.cboUsers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUsers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUsers).ValueMember = "UserGUID";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(511 /*0x01FF*/, 214);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(160 /*0xA0*/, 13);
    this.Label11.TabIndex = 23;
    this.Label11.Text = "numbers remain, send a note to";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkManual).Appearance = (AppearanceBase) appearance38;
    ((UltraToggleEditorBase) this.chkManual).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManual).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkManual).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkManual).Location = new Point(91, 46);
    this.chkManual.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkManual).Name = "chkManual";
    ((Control) this.chkManual).Size = new Size(91, 21);
    ((Control) this.chkManual).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkManual).Text = "Manual Entry";
    ((UltraControlBase) this.chkManual).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkManual).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BackColorDisabled = Color.Gainsboro;
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udNumbers).Appearance = (AppearanceBase) appearance39;
    ((Control) this.udNumbers).Location = new Point(460, 210);
    ((UltraNumericEditor) this.udNumbers).MaskInput = "nnn";
    ((UltraNumericEditor) this.udNumbers).MaxValue = (object) 999;
    this.udNumbers.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.udNumbers).MinValue = (object) 0;
    ((Control) this.udNumbers).Name = "udNumbers";
    ((UltraNumericEditor) this.udNumbers).Nullable = true;
    ((Control) this.udNumbers).Size = new Size(44, 20);
    ((Control) this.udNumbers).TabIndex = 22;
    ((UltraControlBase) this.udNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udNumbers).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.daRule.DeleteCommand = this.DbDeleteCommand1;
    this.daRule.InsertCommand = this.DbInsertCommand1;
    this.daRule.SelectCommand = this.DbSelectCommand1;
    this.daRule.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPolicyNumberRules", new DataColumnMapping[42]
      {
        new DataColumnMapping("RuleID", "RuleID"),
        new DataColumnMapping("RuleName", "RuleName"),
        new DataColumnMapping("Prefix", "Prefix"),
        new DataColumnMapping("BlockStart", "BlockStart"),
        new DataColumnMapping("BlockEnd", "BlockEnd"),
        new DataColumnMapping("TotalBlockDigits", "TotalBlockDigits"),
        new DataColumnMapping("NewNumberOnRenewal", "NewNumberOnRenewal"),
        new DataColumnMapping("SequentialStart", "SequentialStart"),
        new DataColumnMapping("SequentialTotalDigits", "SequentialTotalDigits"),
        new DataColumnMapping("YearSuffix", "YearSuffix"),
        new DataColumnMapping("FixedValue", "FixedValue"),
        new DataColumnMapping("SuffixDash", "SuffixDash"),
        new DataColumnMapping("Manual", "Manual"),
        new DataColumnMapping("WarnLowBlockCount", "WarnLowBlockCount"),
        new DataColumnMapping("WarnUser", "WarnUser"),
        new DataColumnMapping("SuffixSeparateSpace", "SuffixSeparateSpace"),
        new DataColumnMapping("NetrateSunset1Prefix", "NetrateSunset1Prefix"),
        new DataColumnMapping("NetrateSunset2Prefix", "NetrateSunset2Prefix"),
        new DataColumnMapping("NetrateSunset3Prefix", "NetrateSunset3Prefix"),
        new DataColumnMapping("NetrateClaimsMadePrefix", "NetrateClaimsMadePrefix"),
        new DataColumnMapping("Runoff", "Runoff"),
        new DataColumnMapping("AlphaSuffix", "AlphaSuffix"),
        new DataColumnMapping("AlphaSuffixRenewalOnly", "AlphaSuffixRenewalOnly"),
        new DataColumnMapping("BasedOnEffectiveDate", "BasedOnEffectiveDate"),
        new DataColumnMapping("ManualNumberOnPurchasedBook", "ManualNumberOnPurchasedBook"),
        new DataColumnMapping("ManualNumberOnRenewal", "ManualNumberOnRenewal"),
        new DataColumnMapping("UseTableBasedNumbering", "UseTableBasedNumbering"),
        new DataColumnMapping("ForceCheckOnRenewal", "ForceCheckOnRenewal"),
        new DataColumnMapping("UsePolicyNumberingFromRuleId", "UsePolicyNumberingFromRuleId"),
        new DataColumnMapping("UseSubmissionGroupNumbering", "UseSubmissionGroupNumbering"),
        new DataColumnMapping("PromptForManualOverride", "PromptForManualOverride"),
        new DataColumnMapping("FourYearSuffix", "FourYearSuffix"),
        new DataColumnMapping("PolicyNumberSuffix", "PolicyNumberSuffix"),
        new DataColumnMapping("AppendTwoDigitYear", "AppendTwoDigitYear"),
        new DataColumnMapping("AppendFourDigitYear", "AppendFourDigitYear"),
        new DataColumnMapping("AppendPrefix", "AppendPrefix"),
        new DataColumnMapping("ProgCode", "ProgCode"),
        new DataColumnMapping("TwoYearSuffixSeq", "TwoYearSuffixSeq"),
        new DataColumnMapping("FourYearSuffixSeq", "FourYearSuffixSeq"),
        new DataColumnMapping("YearSuffixSequentialStart", "YearSuffixSequentialStart"),
        new DataColumnMapping("YearSuffixSequentialTotalDigits", "YearSuffixSequentialTotalDigits"),
        new DataColumnMapping("UseRenewalDigitYear", "UseRenewalDigitYear")
      })
    });
    this.daRule.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [tblPolicyNumberRules] WHERE (([RuleID] = @Original_RuleID))";
    this.DbDeleteCommand1.Connection = this.cn;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_RuleID", SqlDbType.SmallInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RuleID", DataRowVersion.Original, (object) null)
    });
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cn;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[45]
    {
      DefaultDatabase.CreateParameter("@RuleName", SqlDbType.VarChar, 50, "RuleName"),
      DefaultDatabase.CreateParameter("@Prefix", SqlDbType.VarChar, 20, "Prefix"),
      DefaultDatabase.CreateParameter("@BlockStart", SqlDbType.Int, 4, "BlockStart"),
      DefaultDatabase.CreateParameter("@BlockEnd", SqlDbType.Int, 4, "BlockEnd"),
      DefaultDatabase.CreateParameter("@TotalBlockDigits", SqlDbType.TinyInt, 1, "TotalBlockDigits"),
      DefaultDatabase.CreateParameter("@NewNumberOnRenewal", SqlDbType.Bit, 1, "NewNumberOnRenewal"),
      DefaultDatabase.CreateParameter("@SequentialStart", SqlDbType.Int, 4, "SequentialStart"),
      DefaultDatabase.CreateParameter("@SequentialTotalDigits", SqlDbType.TinyInt, 1, "SequentialTotalDigits"),
      DefaultDatabase.CreateParameter("@YearSuffix", SqlDbType.Bit, 1, "YearSuffix"),
      DefaultDatabase.CreateParameter("@FixedValue", SqlDbType.VarChar, 10, "FixedValue"),
      DefaultDatabase.CreateParameter("@SuffixDash", SqlDbType.Bit, 1, "SuffixDash"),
      DefaultDatabase.CreateParameter("@Manual", SqlDbType.Bit, 1, "Manual"),
      DefaultDatabase.CreateParameter("@WarnLowBlockCount", SqlDbType.Int, 4, "WarnLowBlockCount"),
      DefaultDatabase.CreateParameter("@WarnUser", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "WarnUser"),
      DefaultDatabase.CreateParameter("@SuffixSeparateSpace", SqlDbType.Bit, 1, "SuffixSeparateSpace"),
      DefaultDatabase.CreateParameter("@NetrateSunset1Prefix", SqlDbType.VarChar, 10, "NetrateSunset1Prefix"),
      DefaultDatabase.CreateParameter("@NetrateSunset2Prefix", SqlDbType.VarChar, 10, "NetrateSunset2Prefix"),
      DefaultDatabase.CreateParameter("@NetrateSunset3Prefix", SqlDbType.VarChar, 10, "NetrateSunset3Prefix"),
      DefaultDatabase.CreateParameter("@NetrateClaimsMadePrefix", SqlDbType.VarChar, 10, "NetrateClaimsMadePrefix"),
      DefaultDatabase.CreateParameter("@Runoff", SqlDbType.Bit, 1, "Runoff"),
      DefaultDatabase.CreateParameter("@AlphaSuffix", SqlDbType.Bit, 1, "AlphaSuffix"),
      DefaultDatabase.CreateParameter("@AlphaSuffixRenewalOnly", SqlDbType.Bit, 1, "AlphaSuffixRenewalOnly"),
      DefaultDatabase.CreateParameter("@BasedOnEffectiveDate", SqlDbType.Bit, 1, "BasedOnEffectiveDate"),
      DefaultDatabase.CreateParameter("@ManualNumberOnPurchasedBook", SqlDbType.Bit, 1, "ManualNumberOnPurchasedBook"),
      DefaultDatabase.CreateParameter("@ManualNumberOnRenewal", SqlDbType.Bit, 1, "ManualNumberOnRenewal"),
      DefaultDatabase.CreateParameter("@UseTableBasedNumbering", SqlDbType.Bit, 1, "UseTableBasedNumbering"),
      DefaultDatabase.CreateParameter("@ForceCheckOnRenewal", SqlDbType.Bit, 1, "ForceCheckOnRenewal"),
      DefaultDatabase.CreateParameter("@UsePolicyNumberingFromRuleId", SqlDbType.Int, 4, "UsePolicyNumberingFromRuleId"),
      DefaultDatabase.CreateParameter("@UseSubmissionGroupNumbering", SqlDbType.Bit, 1, "UseSubmissionGroupNumbering"),
      DefaultDatabase.CreateParameter("@PromptForManualOverride", SqlDbType.Bit, 1, "PromptForManualOverride"),
      DefaultDatabase.CreateParameter("@FourYearSuffix", SqlDbType.Bit, 1, "FourYearSuffix"),
      DefaultDatabase.CreateParameter("@PolicyNumberSuffix", SqlDbType.VarChar, 10, "PolicyNumberSuffix"),
      DefaultDatabase.CreateParameter("@AppendTwoDigitYear", SqlDbType.Bit, 1, "AppendTwoDigitYear"),
      DefaultDatabase.CreateParameter("@AppendFourDigitYear", SqlDbType.Bit, 1, "AppendFourDigitYear"),
      DefaultDatabase.CreateParameter("@AppendPrefix", SqlDbType.VarChar, 10, "AppendPrefix"),
      DefaultDatabase.CreateParameter("@ProgCode", SqlDbType.VarChar, 50, "ProgCode"),
      DefaultDatabase.CreateParameter("@TwoYearSuffixSeq", SqlDbType.Bit, 1, "TwoYearSuffixSeq"),
      DefaultDatabase.CreateParameter("@FourYearSuffixSeq", SqlDbType.Bit, 1, "FourYearSuffixSeq"),
      DefaultDatabase.CreateParameter("@YearSuffixSequentialStart", SqlDbType.Int, 4, "YearSuffixSequentialStart"),
      DefaultDatabase.CreateParameter("@YearSuffixSequentialTotalDigits", SqlDbType.TinyInt, 1, "YearSuffixSequentialTotalDigits"),
      DefaultDatabase.CreateParameter("@UseRenewalDigitYear", SqlDbType.Bit, 1, "UseRenewalDigitYear"),
      DefaultDatabase.CreateParameter("@UseInsuredNumber", SqlDbType.Bit, 1, "UseInsuredNumber"),
      DefaultDatabase.CreateParameter("@ManualMask", SqlDbType.VarChar, 50, "ManualMask"),
      DefaultDatabase.CreateParameter("@UseStoredProc", SqlDbType.Bit, 1, "UseStoredProc"),
      DefaultDatabase.CreateParameter("@NumericalSuffixRenewalOnly", SqlDbType.Bit, 1, "NumericalSuffixRenewalOnly")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cn;
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cn;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[47]
    {
      DefaultDatabase.CreateParameter("@RuleName", SqlDbType.VarChar, 50, "RuleName"),
      DefaultDatabase.CreateParameter("@Prefix", SqlDbType.VarChar, 20, "Prefix"),
      DefaultDatabase.CreateParameter("@BlockStart", SqlDbType.Int, 4, "BlockStart"),
      DefaultDatabase.CreateParameter("@BlockEnd", SqlDbType.Int, 4, "BlockEnd"),
      DefaultDatabase.CreateParameter("@TotalBlockDigits", SqlDbType.TinyInt, 1, "TotalBlockDigits"),
      DefaultDatabase.CreateParameter("@NewNumberOnRenewal", SqlDbType.Bit, 1, "NewNumberOnRenewal"),
      DefaultDatabase.CreateParameter("@SequentialStart", SqlDbType.Int, 4, "SequentialStart"),
      DefaultDatabase.CreateParameter("@SequentialTotalDigits", SqlDbType.TinyInt, 1, "SequentialTotalDigits"),
      DefaultDatabase.CreateParameter("@YearSuffix", SqlDbType.Bit, 1, "YearSuffix"),
      DefaultDatabase.CreateParameter("@FixedValue", SqlDbType.VarChar, 10, "FixedValue"),
      DefaultDatabase.CreateParameter("@SuffixDash", SqlDbType.Bit, 1, "SuffixDash"),
      DefaultDatabase.CreateParameter("@Manual", SqlDbType.Bit, 1, "Manual"),
      DefaultDatabase.CreateParameter("@WarnLowBlockCount", SqlDbType.Int, 4, "WarnLowBlockCount"),
      DefaultDatabase.CreateParameter("@WarnUser", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "WarnUser"),
      DefaultDatabase.CreateParameter("@SuffixSeparateSpace", SqlDbType.Bit, 1, "SuffixSeparateSpace"),
      DefaultDatabase.CreateParameter("@NetrateSunset1Prefix", SqlDbType.VarChar, 10, "NetrateSunset1Prefix"),
      DefaultDatabase.CreateParameter("@NetrateSunset2Prefix", SqlDbType.VarChar, 10, "NetrateSunset2Prefix"),
      DefaultDatabase.CreateParameter("@NetrateSunset3Prefix", SqlDbType.VarChar, 10, "NetrateSunset3Prefix"),
      DefaultDatabase.CreateParameter("@NetrateClaimsMadePrefix", SqlDbType.VarChar, 10, "NetrateClaimsMadePrefix"),
      DefaultDatabase.CreateParameter("@Runoff", SqlDbType.Bit, 1, "Runoff"),
      DefaultDatabase.CreateParameter("@AlphaSuffix", SqlDbType.Bit, 1, "AlphaSuffix"),
      DefaultDatabase.CreateParameter("@AlphaSuffixRenewalOnly", SqlDbType.Bit, 1, "AlphaSuffixRenewalOnly"),
      DefaultDatabase.CreateParameter("@BasedOnEffectiveDate", SqlDbType.Bit, 1, "BasedOnEffectiveDate"),
      DefaultDatabase.CreateParameter("@ManualNumberOnPurchasedBook", SqlDbType.Bit, 1, "ManualNumberOnPurchasedBook"),
      DefaultDatabase.CreateParameter("@ManualNumberOnRenewal", SqlDbType.Bit, 1, "ManualNumberOnRenewal"),
      DefaultDatabase.CreateParameter("@UseTableBasedNumbering", SqlDbType.Bit, 1, "UseTableBasedNumbering"),
      DefaultDatabase.CreateParameter("@ForceCheckOnRenewal", SqlDbType.Bit, 1, "ForceCheckOnRenewal"),
      DefaultDatabase.CreateParameter("@UsePolicyNumberingFromRuleId", SqlDbType.Int, 4, "UsePolicyNumberingFromRuleId"),
      DefaultDatabase.CreateParameter("@UseSubmissionGroupNumbering", SqlDbType.Bit, 1, "UseSubmissionGroupNumbering"),
      DefaultDatabase.CreateParameter("@PromptForManualOverride", SqlDbType.Bit, 1, "PromptForManualOverride"),
      DefaultDatabase.CreateParameter("@FourYearSuffix", SqlDbType.Bit, 1, "FourYearSuffix"),
      DefaultDatabase.CreateParameter("@PolicyNumberSuffix", SqlDbType.VarChar, 10, "PolicyNumberSuffix"),
      DefaultDatabase.CreateParameter("@AppendTwoDigitYear", SqlDbType.Bit, 1, "AppendTwoDigitYear"),
      DefaultDatabase.CreateParameter("@AppendFourDigitYear", SqlDbType.Bit, 1, "AppendFourDigitYear"),
      DefaultDatabase.CreateParameter("@AppendPrefix", SqlDbType.VarChar, 10, "AppendPrefix"),
      DefaultDatabase.CreateParameter("@ProgCode", SqlDbType.VarChar, 50, "ProgCode"),
      DefaultDatabase.CreateParameter("@TwoYearSuffixSeq", SqlDbType.Bit, 1, "TwoYearSuffixSeq"),
      DefaultDatabase.CreateParameter("@FourYearSuffixSeq", SqlDbType.Bit, 1, "FourYearSuffixSeq"),
      DefaultDatabase.CreateParameter("@YearSuffixSequentialStart", SqlDbType.Int, 4, "YearSuffixSequentialStart"),
      DefaultDatabase.CreateParameter("@YearSuffixSequentialTotalDigits", SqlDbType.TinyInt, 1, "YearSuffixSequentialTotalDigits"),
      DefaultDatabase.CreateParameter("@UseRenewalDigitYear", SqlDbType.Bit, 1, "UseRenewalDigitYear"),
      DefaultDatabase.CreateParameter("@UseInsuredNumber", SqlDbType.Bit, 1, "UseInsuredNumber"),
      DefaultDatabase.CreateParameter("@ManualMask", SqlDbType.VarChar, 50, "ManualMask"),
      DefaultDatabase.CreateParameter("@UseStoredProc", SqlDbType.Bit, 1, "UseStoredProc"),
      DefaultDatabase.CreateParameter("@NumericalSuffixRenewalOnly", SqlDbType.Bit, 1, "NumericalSuffixRenewalOnly"),
      DefaultDatabase.CreateParameter("@Original_RuleID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RuleID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@RuleID", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RuleID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.dgRules).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgRules).DataSource = (object) this.ds.tblPolicyNumberRules;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgRules).DisplayLayout.Appearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.dgRules).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Rule Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 836;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 268;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 67;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 156;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 80 /*0x50*/;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 98;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 54;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 68;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 68;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 108;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 22;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 38;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 77;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 100;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 131;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 113;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 112 /*0x70*/;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 129;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 103;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 29;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 68;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 30;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 128 /*0x80*/;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 112 /*0x70*/;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 76;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 33;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 91;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 34;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 93;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 35;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 107;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 36;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 87;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 37;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 87;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 38;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 61;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 39;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 66;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 40;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 121;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 41;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 196;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 42;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 107;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 43;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 100;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 44;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 87;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 45;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 81;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 46;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 134;
    ultraGridBand.Columns.AddRange(new object[47]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ((UltraGridBase) this.dgRules).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgRules).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance42.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance43.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance44.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance45.BackColor = Color.White;
    appearance45.ForeColor = Color.Black;
    ((UltraGridBase) this.dgRules).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance45;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgRules).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgRules).Location = new Point(7, 7);
    ((Control) this.dgRules).Name = "dgRules";
    ((Control) this.dgRules).Size = new Size(838, 140);
    ((Control) this.dgRules).TabIndex = 0;
    ((UltraControlBase) this.dgRules).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgRules).UseOsThemes = (DefaultableBoolean) 2;
    this.btnGenNumbers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnGenNumbers.Location = new Point(236, 666);
    this.btnGenNumbers.Name = "btnGenNumbers";
    this.btnGenNumbers.Size = new Size(163, 23);
    this.btnGenNumbers.TabIndex = 4;
    this.btnGenNumbers.Text = "Generate Policy Numbers";
    this.btnGenNumbers.UseVisualStyleBackColor = true;
    this.btnGenNumbers.Visible = false;
    ((Control) this.btnRunOff).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance46.BackColor = Color.Gainsboro;
    appearance46.BackColor2 = Color.White;
    appearance46.BackGradientStyle = (GradientStyle) 2;
    appearance46.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnRunOff).Appearance = (AppearanceBase) appearance46;
    ((Control) this.btnRunOff).Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnRunOff).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnRunOff).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnRunOff).Location = new Point(503, 664);
    ((Control) this.btnRunOff).Name = "btnRunOff";
    ((ControlBase) this.btnRunOff).Padding = new Size(5, 0);
    ((Control) this.btnRunOff).Size = new Size(96 /*0x60*/, 29);
    ((Control) this.btnRunOff).TabIndex = 5;
    ((ControlBase) this.btnRunOff).Text = "Run-Off";
    this.btnRunOff.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRunOff).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(856, 701);
    this.Controls.Add((Control) this.btnRunOff);
    this.Controls.Add((Control) this.btnGenNumbers);
    this.Controls.Add((Control) this.ctlSaveUI);
    this.Controls.Add((Control) this.dgRules);
    this.Controls.Add((Control) this.gbEntry);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblSample);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminPolicyNumbers);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Policy Number Administration";
    ((ISupportInitialize) this.txtPrefix).EndInit();
    ((ISupportInitialize) this.txtFixedValue).EndInit();
    ((ISupportInitialize) this.chkNewOnRenewal).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.chkNumericRenewalOnly).EndInit();
    ((ISupportInitialize) this.numYearSeqTotalDigits).EndInit();
    ((ISupportInitialize) this.numYearSeq).EndInit();
    ((ISupportInitialize) this.chkBasedOffEffDate).EndInit();
    ((ISupportInitialize) this.checkAlphaRenewalOnly).EndInit();
    ((ISupportInitialize) this.chkSpace).EndInit();
    ((ISupportInitialize) this.numTotalDigits).EndInit();
    ((ISupportInitialize) this.numSequential).EndInit();
    ((ISupportInitialize) this.chkDash).EndInit();
    ((ISupportInitialize) this.txtPolicyNumberSuffix).EndInit();
    ((ISupportInitialize) this.numBlockTotalDigitsStart).EndInit();
    ((ISupportInitialize) this.numBlockTotalDigits).EndInit();
    ((ISupportInitialize) this.txtRuleName).EndInit();
    ((ISupportInitialize) this.gbEntry).EndInit();
    ((Control) this.gbEntry).ResumeLayout(false);
    ((Control) this.gbEntry).PerformLayout();
    ((ISupportInitialize) this.chkUseStoredProc).EndInit();
    ((ISupportInitialize) this.txtManualMask).EndInit();
    ((ISupportInitialize) this.chkUseInsuredNumber).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboProgramCode).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.checkManualOnRenewal).EndInit();
    ((ISupportInitialize) this.checkManualonPurchasedBook).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.chkUseRenewalDigitYear).EndInit();
    ((ISupportInitialize) this.txtAppendPrefix).EndInit();
    ((ISupportInitialize) this.txtNextNumberToAssign).EndInit();
    ((ISupportInitialize) this.chkPromptForManualOverride).EndInit();
    ((ISupportInitialize) this.chkUseSubmissionGroupNumbering).EndInit();
    ((ISupportInitialize) this.cboNumbering).EndInit();
    ((ISupportInitialize) this.chkForceCheckNewPolicy).EndInit();
    ((ISupportInitialize) this.chkUseTableBasedNumbering).EndInit();
    ((ISupportInitialize) this.checkRunoff).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtSunset2).EndInit();
    ((ISupportInitialize) this.txtClaimsMade).EndInit();
    ((ISupportInitialize) this.txtSunset3).EndInit();
    ((ISupportInitialize) this.txtSunset1).EndInit();
    ((ISupportInitialize) this.numBlockTotalDigitsEnd).EndInit();
    ((ISupportInitialize) this.cboUsers).EndInit();
    ((ISupportInitialize) this.chkManual).EndInit();
    ((ISupportInitialize) this.udNumbers).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dgRules).EndInit();
    ((ISupportInitialize) this.btnRunOff).EndInit();
    this.ResumeLayout(false);
  }

  public frmAdminPolicyNumbers()
  {
    this.Load += new EventHandler(this.frmAdminPolicyNumbers_Load);
    this._currentRuleID = int.MinValue;
    this._ruleLockDown = new List<int>();
    this._viewRunoffUpdate = SystemSettings.GetLazySetting<bool>("PolicyNumber.ViewRunOffUpdateButton", false, true);
    this.InitializeComponent();
    if (this.DesignMode)
      return;
    try
    {
      foreach (Control control in ((Control) this.gbEntry).Controls)
        control.Enabled = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void frmAdminPolicyNumbers_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    if (((UltraGridBase) this.dgRules).Rows.Count > 0)
      ((UltraGridBase) this.dgRules).ActiveRow = ((UltraGridBase) this.dgRules).GetRow((ChildRow) 0);
    this._canUpdateRunOff = SecurityManager.Instance.AssertPermission("{2ED4629F-1676-4C6E-A1D7-C3F0051336DB}");
    dsPolicyNumberAdmin.tblUsersRow row = this.ds.tblUsers.NewtblUsersRow();
    row.UserGUID = Guid.Empty;
    row.UserName = string.Empty;
    this.ds.tblUsers.AddtblUsersRow(row);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "tblPolicyNumberRules",
      "tblCompanyProgramCodes",
      "tblUsers"
    }, "dbo.GetPolicyNumberRulesData");
    this.ctlSaveUI.UIState = this.ds.tblPolicyNumberRules.Rows.Count != 0 ? (UIState) 1 : (UIState) 0;
    this.ds.tblPolicyNumberRules.DefaultView.AllowNew = false;
    if (this.ds.tblPolicyNumberRules.Rows.Count == 0)
      this.ctlSaveUI.UIState = (UIState) 0;
    ((Control) this.chkUseStoredProc).Visible = SystemSettings.GetSetting<bool>("CompanyLine.PolicyNumbers.ShowStoredProcColumn", false);
    this.btnGenNumbers.Visible = CurrentUser.IsMGADeveloper || SystemSettings.GetSetting<bool>("Admin.PolicyNumbers.GenerateTableNumberSQL", false);
    ((Control) this.btnRunOff).Visible = CurrentUser.IsMGADeveloper || SystemSettings.GetSetting<bool>("Admin.PolicyNumbers.ViewRunOffUpdateButton", false);
    this.CheckForRulesApplication();
    this.PopulatePolicyNumberingDropdown();
  }

  protected virtual void ctlSaveUI_ClickedNew(object sender, EventArgs e)
  {
    this._clickingNew = true;
    ((TextEditorControlBase) this.txtRuleName).Text = string.Empty;
    ((UltraToggleEditorBase) this.chkManual).Checked = false;
    ((TextEditorControlBase) this.txtPrefix).Text = string.Empty;
    ((UltraNumericEditor) this.numBlockTotalDigitsStart).Value = (object) null;
    ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value = (object) null;
    ((UltraNumericEditor) this.numBlockTotalDigits).Value = (object) null;
    ((UltraNumericEditor) this.udNumbers).Value = (object) null;
    ((UltraCombo) this.cboUsers).Value = (object) Guid.Empty;
    ((UltraToggleEditorBase) this.chkNewOnRenewal).Checked = false;
    ((UltraToggleEditorBase) this.chkDash).Checked = false;
    ((UltraToggleEditorBase) this.chkSpace).Checked = false;
    this.rbNoSuffix.Checked = true;
    this.rbFixedValue.Checked = false;
    this.rbSequential.Checked = false;
    this.rb2DigitYear.Checked = false;
    ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
    ((UltraToggleEditorBase) this.checkRunoff).Checked = false;
    ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Checked = false;
    this.rbAlpha.Checked = false;
    ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Checked = false;
    ((UltraToggleEditorBase) this.chkNumericRenewalOnly).Checked = false;
    ((UltraToggleEditorBase) this.chkBasedOffEffDate).Checked = false;
    ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked = false;
    ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked = false;
    ((TextEditorControlBase) this.txtNextNumberToAssign).Text = string.Empty;
    ((UltraCombo) this.cboNumbering).Value = (object) -1;
    ((UltraToggleEditorBase) this.chkPromptForManualOverride).Checked = false;
    this.rb4DigitYear.Checked = false;
    ((TextEditorControlBase) this.txtPolicyNumberSuffix).Text = string.Empty;
    ((TextEditorControlBase) this.txtAppendPrefix).Text = string.Empty;
    this.rb2YearAppend.Checked = false;
    this.rb4YearAppend.Checked = false;
    ((UltraCombo) this.cboProgramCode).Value = (object) null;
    this.rbTwoDigitYearSeq.Checked = false;
    this.rbFourDigitYearSeq.Checked = false;
    ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Checked = false;
    ((TextEditorControlBase) this.txtManualMask).Text = string.Empty;
    ((UltraToggleEditorBase) this.chkUseStoredProc).Checked = false;
  }

  protected virtual void ctlSaveUI_ClickedButton(object sender, EventArgs e)
  {
    this.SetFieldAccess(this.ctlSaveUI.UIState == 2);
  }

  protected virtual void ctlSaveUI_ClickedCancel(object sender, EventArgs e)
  {
    this._clickingNew = false;
    this.ds.tblPolicyNumberRules.RejectChanges();
    this.dgRules_AfterRowActivate((object) null, (EventArgs) null);
    this.err.Clear();
  }

  private bool ValidateSequential(bool valid)
  {
    this.err.SetError((Control) this.numYearSeq, string.Empty);
    this.err.SetError((Control) this.numSequential, string.Empty);
    bool flag;
    if (!((UltraToggleEditorBase) this.chkManual).Checked && this.rbSequential.Checked && ((UltraNumericEditor) this.numSequential).Value == null)
    {
      this.err.SetError((Control) this.numSequential, "Please enter a value");
      flag = false;
    }
    else if (!((UltraToggleEditorBase) this.chkManual).Checked && (this.rbTwoDigitYearSeq.Checked || this.rbFourDigitYearSeq.Checked) && ((UltraNumericEditor) this.numYearSeq).Value == null)
    {
      this.err.SetError((Control) this.numYearSeq, "Please enter a value");
      flag = false;
    }
    else
      flag = valid;
    return flag;
  }

  private bool ValidateForm()
  {
    bool valid1 = true;
    this.err.SetError((Control) this.txtRuleName, string.Empty);
    this.err.SetError((Control) this.udNumbers, string.Empty);
    this.err.SetError((Control) this.cboUsers, string.Empty);
    this.err.SetError((Control) this.txtFixedValue, string.Empty);
    this.err.SetError((Control) this.txtManualMask, string.Empty);
    if (((TextEditorControlBase) this.txtRuleName).Text.Replace(" ", string.Empty).Length == 0 || ((TextEditorControlBase) this.txtRuleName).Value == null || ((TextEditorControlBase) this.txtRuleName).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtRuleName, "Please enter a name for this rule.");
      valid1 = false;
    }
    bool flag;
    if (((UltraCombo) this.cboNumbering).Value != null && (int) ((UltraCombo) this.cboNumbering).Value != -1)
    {
      if (DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT UsePolicyNumberingFromRuleId FROM tblPolicyNumberRules WHERE RuleID = @RuleID", new object[2]
      {
        (object) "@RuleId",
        ((UltraCombo) this.cboNumbering).Value
      }) != DBNull.Value)
      {
        this.err.SetError((Control) this.cboNumbering, $"Policy numbering can not be used with that rule.  The rule {((UltraCombo) this.cboNumbering).Text} is using another rule for numbering.  Chaining rules is not supported.");
        valid1 = false;
      }
      flag = valid1;
    }
    else
    {
      bool valid2 = this.ValidateSequential(valid1);
      if (!((UltraToggleEditorBase) this.chkManual).Checked && (((UltraNumericEditor) this.udNumbers).Value == null || ((UltraNumericEditor) this.udNumbers).Value == DBNull.Value) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboUsers).Text, string.Empty, false) != 0)
      {
        this.err.SetError((Control) this.udNumbers, "Please enter a value...User to receive note filled in.");
        flag = false;
      }
      else if (!((UltraToggleEditorBase) this.chkManual).Checked && ((UltraNumericEditor) this.udNumbers).Value != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboUsers).Text, string.Empty, false) == 0)
      {
        this.err.SetError((Control) this.cboUsers, "Please select a value...low ceiling number filled in.");
        flag = false;
      }
      else if (!((UltraToggleEditorBase) this.chkManual).Checked && this.rbFixedValue.Checked && ((TextEditorControlBase) this.txtFixedValue).Text.Replace(" ", string.Empty).Length == 0)
      {
        this.err.SetError((Control) this.txtFixedValue, "Please enter a value...Fixed Value is checked");
        flag = false;
      }
      else if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtManualMask).Text) && !((UltraToggleEditorBase) this.chkManual).Checked)
      {
        this.err.SetError((Control) this.txtManualMask, "Cannot have a value.  Manual is NOT checked.");
        flag = false;
      }
      else
        flag = this.ValidateTotalDigits(valid2);
    }
    return flag;
  }

  private bool ValidateTotalDigits(bool valid)
  {
    this.err.SetError((Control) this.numBlockTotalDigitsStart, string.Empty);
    this.err.SetError((Control) this.numYearSeqTotalDigits, string.Empty);
    this.err.SetError((Control) this.numTotalDigits, string.Empty);
    this.err.SetError((Control) this.numBlockTotalDigitsEnd, string.Empty);
    if (!((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked && !((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked && !((UltraToggleEditorBase) this.chkManual).Checked && !((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked && (((UltraNumericEditor) this.numBlockTotalDigitsStart).Value == null || ((UltraNumericEditor) this.numBlockTotalDigitsStart).Value == DBNull.Value))
    {
      this.err.SetError((Control) this.numBlockTotalDigitsStart, "Please enter a value");
      valid = false;
    }
    if (!((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked && !((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked && !((UltraToggleEditorBase) this.chkManual).Checked && !((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked && (((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value == null || ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value == DBNull.Value))
    {
      this.err.SetError((Control) this.numBlockTotalDigitsEnd, "Please enter a value");
      valid = false;
    }
    if (valid && !((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked && !((UltraToggleEditorBase) this.chkManual).Checked && !((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked && (((UltraNumericEditor) this.numBlockTotalDigits).Value == DBNull.Value || ((UltraNumericEditor) this.numBlockTotalDigits).Value == null))
    {
      this.err.SetError((Control) this.numBlockTotalDigits, "Please enter a value");
      valid = false;
    }
    if (!((UltraToggleEditorBase) this.chkManual).Checked)
    {
      if (((UltraNumericEditor) this.numTotalDigits).Value == null && this.rbSequential.Checked)
      {
        this.err.SetError((Control) this.numTotalDigits, "Please enter a valid value");
        valid = false;
      }
      if (((UltraNumericEditor) this.numYearSeqTotalDigits).Value == null && (this.rbTwoDigitYearSeq.Checked || this.rbFourDigitYearSeq.Checked))
      {
        this.err.SetError((Control) this.numYearSeqTotalDigits, "Please enter a valid value");
        valid = false;
      }
    }
    return valid;
  }

  protected virtual void ctlSaveUI_ClickingSave(object sender, CancelEventArgs e)
  {
    this.err.Clear();
    if (!this.ValidateForm())
      e.Cancel = true;
    else if (this.VerifyDuplicateOnRenewalPotential())
    {
      e.Cancel = true;
    }
    else
    {
      dsPolicyNumberAdmin.tblPolicyNumberRulesRow policyNumberRulesRow = !this._clickingNew ? this.ds.tblPolicyNumberRules.FindByRuleID(this._currentRuleID) : this.ds.tblPolicyNumberRules.NewtblPolicyNumberRulesRow();
      this.AssignFormValues(policyNumberRulesRow);
      if (this._clickingNew)
        this.ds.tblPolicyNumberRules.AddtblPolicyNumberRulesRow(policyNumberRulesRow);
      try
      {
        if (this.ds.tblPolicyNumberRules.GetChanges() != null)
        {
          DefaultDatabase.DataAdapterUpdate(this.daRule, (DataTable) this.ds.tblPolicyNumberRules);
          if (this._clickingNew)
          {
            CurrentUser.Instance.LogAction($"Created New Policy RuleName: '{policyNumberRulesRow.RuleName}'");
          }
          else
          {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            List<frmAdminPolicyNumbers.PolicyStruct> policyStructList = new List<frmAdminPolicyNumbers.PolicyStruct>();
            this.LoadFriendlyName(dic);
            try
            {
              foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblPolicyNumberRules.Columns)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(policyNumberRulesRow[column.ColumnName, DataRowVersion.Original].ToString(), policyNumberRulesRow[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
                  this.GetRowChanges(policyNumberRulesRow, column.ColumnName, policyStructList);
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            this.LogChanges(policyNumberRulesRow, dic, policyStructList);
          }
        }
        this.SavingOnClient(policyNumberRulesRow);
      }
      finally
      {
        this._clickingNew = false;
      }
    }
  }

  protected virtual bool VerifyDuplicateOnRenewalPotential()
  {
    bool flag;
    if (((UltraToggleEditorBase) this.chkNewOnRenewal).Checked || ((UltraToggleEditorBase) this.checkManualOnRenewal).Checked || ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Checked || this.rbSequential.Checked || this.rbTwoDigitYearSeq.Checked || this.rbFourDigitYearSeq.Checked || ((UltraToggleEditorBase) this.chkManual).Checked || ((UltraToggleEditorBase) this.chkPromptForManualOverride).Checked || this.rbAlpha.Checked)
      flag = false;
    else if (this.rbNoSuffix.Checked || this.rbFixedValue.Checked)
      flag = MessageBox.Show("The current rule configuration may cause duplicate policy numbers on renewals.  Keep current configuration anyway?", "Potential Duplicate Numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
    else if (this.rb2DigitYear.Checked || this.rb4DigitYear.Checked || ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Checked)
      flag = MessageBox.Show("The current rule configuration may cause duplicate policy numbers on renewals that are effective in the same year as the original policy.  Keep current configuration anyway?", "Potential Duplicate Numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
    return flag;
  }

  private void LogChanges(
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow row,
    Dictionary<string, string> dic,
    List<frmAdminPolicyNumbers.PolicyStruct> columnChangesList)
  {
    int num = columnChangesList.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      frmAdminPolicyNumbers.PolicyStruct columnChanges = columnChangesList[index];
      if (columnChanges.EntityType == 'U')
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnChanges.OrigValue, string.Empty, false) != 0)
          columnChanges.OrigValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteEntityName(@Entity,@SqlType)", new object[4]
          {
            (object) "@Entity",
            (object) columnChanges.OrigValue,
            (object) "@SqlType",
            (object) columnChanges.EntityType.ToString()
          })), "");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnChanges.CurrValue, string.Empty, false) != 0)
          columnChanges.CurrValue = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteEntityName(@Entity,@SqlType)", new object[4]
          {
            (object) "@Entity",
            (object) columnChanges.CurrValue,
            (object) "@SqlType",
            (object) columnChanges.EntityType.ToString()
          })), "");
      }
      string columnName = columnChanges.ColumnName;
      if (dic.ContainsKey(columnChanges.ColumnName))
        columnName = dic[columnChanges.ColumnName];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnChanges.OrigValue, string.Empty, false) == 0)
        columnChanges.OrigValue = "<empty>";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnChanges.CurrValue, string.Empty, false) == 0)
        columnChanges.CurrValue = "<empty>";
      CurrentUser.Instance.LogAction($"Modify Policy Number Rule: '{columnChanges.RuleName}' Changed {columnName} from {columnChanges.OrigValue} to {columnChanges.CurrValue}");
    }
  }

  private void GetRowChanges(
    dsPolicyNumberAdmin.tblPolicyNumberRulesRow row,
    string colName,
    List<frmAdminPolicyNumbers.PolicyStruct> quoteColumnChangesList)
  {
    frmAdminPolicyNumbers.PolicyStruct policyStruct = new frmAdminPolicyNumbers.PolicyStruct();
    policyStruct.RuleName = row.RuleName;
    policyStruct.ColumnName = colName;
    policyStruct.CurrValue = row[colName] == DBNull.Value ? string.Empty : row[colName, DataRowVersion.Current].ToString();
    policyStruct.OrigValue = row[colName, DataRowVersion.Original] == DBNull.Value ? string.Empty : row[colName, DataRowVersion.Original].ToString();
    if (DatabaseTypeConvertor.ToSqlDbType(row.Table.Columns[colName].DataType) == SqlDbType.UniqueIdentifier)
      policyStruct.EntityType = 'U';
    quoteColumnChangesList.Add(policyStruct);
  }

  private void LoadFriendlyName(Dictionary<string, string> dic)
  {
    dic.Add("RuleName", "'Rule Name'");
    dic.Add("BlockStart", "'Block Start'");
    dic.Add("BlockEnd", "'Block End'");
    dic.Add("TotalBlockDigits", "'Total Block Digits'");
    dic.Add("WarnLowBlockCount", "'Warn Low Block Count'");
    dic.Add("WarnUser", "'Warn User'");
    dic.Add("NewNumberOnRenewal", "'New Number On Renewal'");
    dic.Add("SequentialStart", "'Sequential Start'");
    dic.Add("SequentialTotalDigits", "'Sequential Total Digits'");
    dic.Add("YearSuffix", "'Year Suffix'");
    dic.Add("Fixedvalue", "'Fixed Value'");
    dic.Add("SuffixDash", "'Suffix Separated with Dash'");
    dic.Add("Manual", "'Manual Entry'");
    dic.Add("SuffixSeparateSpace", "'Suffix Separated with Space'");
    dic.Add("BasedOnEffectiveDate ", "'Based on quote's effective date'");
  }

  private void CheckForRulesApplication()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetAllAppliedPolicyRules");
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this._ruleLockDown.Add(Conversions.ToInteger(row[0]));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SavePrefixes(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    if (((TextEditorControlBase) this.txtPrefix).Text.Replace(" ", string.Empty).Length > 0)
      dr.Prefix = ((TextEditorControlBase) this.txtPrefix).Text;
    else
      dr.SetPrefixNull();
    if (((TextEditorControlBase) this.txtSunset1).Text.Replace(" ", string.Empty).Length > 0)
      dr.NetrateSunset1Prefix = ((TextEditorControlBase) this.txtSunset1).Text;
    else
      dr.SetNetrateSunset1PrefixNull();
    if (((TextEditorControlBase) this.txtSunset2).Text.Replace(" ", string.Empty).Length > 0)
      dr.NetrateSunset2Prefix = ((TextEditorControlBase) this.txtSunset2).Text;
    else
      dr.SetNetrateSunset2PrefixNull();
    if (((TextEditorControlBase) this.txtSunset3).Text.Replace(" ", string.Empty).Length > 0)
      dr.NetrateSunset3Prefix = ((TextEditorControlBase) this.txtSunset3).Text;
    else
      dr.SetNetrateSunset3PrefixNull();
    if (((TextEditorControlBase) this.txtClaimsMade).Text.Replace(" ", string.Empty).Length > 0)
      dr.NetrateClaimsMadePrefix = ((TextEditorControlBase) this.txtClaimsMade).Text;
    else
      dr.SetNetrateClaimsMadePrefixNull();
  }

  private bool IsNullableValue(object value) => value == null || value == DBNull.Value;

  private void AssignFormValues(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    if (((TextEditorControlBase) this.txtRuleName).Text.Replace(" ", string.Empty).Length > 0)
      dr.RuleName = ((TextEditorControlBase) this.txtRuleName).Text;
    else
      dr.SetRuleNameNull();
    dr.Manual = ((UltraToggleEditorBase) this.chkManual).Checked;
    this.SavePrefixes(dr);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboUsers).Text, string.Empty, false) != 0)
      dr.WarnUser = (Guid) ((UltraCombo) this.cboUsers).Value;
    else
      dr.SetWarnUserNull();
    if (!this.IsNullableValue(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numBlockTotalDigitsStart).Value)))
      dr.BlockStart = Conversions.ToInteger(((UltraNumericEditor) this.numBlockTotalDigitsStart).Value);
    else
      dr.SetBlockStartNull();
    if (((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value != null && ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value != DBNull.Value)
      dr.BlockEnd = Conversions.ToInteger(((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value);
    else
      dr.SetBlockEndNull();
    if (!this.IsNullableValue(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numBlockTotalDigits).Value)))
      dr.TotalBlockDigits = Conversions.ToInteger(((UltraNumericEditor) this.numBlockTotalDigits).Value);
    else
      dr.SetTotalBlockDigitsNull();
    dr.UseInsuredNumber = ((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked;
    dr.Runoff = ((UltraToggleEditorBase) this.checkRunoff).Checked;
    dr.ForceCheckOnRenewal = ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Checked;
    if (!this.IsNullableValue(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.udNumbers).Value)))
      dr.WarnLowBlockCount = Conversions.ToInteger(((UltraNumericEditor) this.udNumbers).Value);
    else
      dr.SetWarnLowBlockCountNull();
    if (((UltraCombo) this.cboNumbering).Value != null && (int) ((UltraCombo) this.cboNumbering).Value > -1)
      dr.UsePolicyNumberingFromRuleId = (int) ((UltraCombo) this.cboNumbering).Value;
    else
      dr.SetUsePolicyNumberingFromRuleIdNull();
    this.EvaluateRadioButtons(dr);
    dr.NewNumberOnRenewal = ((UltraToggleEditorBase) this.chkNewOnRenewal).Checked;
    dr.SuffixDash = ((UltraToggleEditorBase) this.chkDash).Checked;
    dr.SuffixSeparateSpace = ((UltraToggleEditorBase) this.chkSpace).Checked;
    dr.BasedOnEffectiveDate = ((UltraToggleEditorBase) this.chkBasedOffEffDate).Checked;
    dr.ManualNumberOnPurchasedBook = ((UltraToggleEditorBase) this.checkManualonPurchasedBook).Checked;
    dr.ManualNumberOnRenewal = ((UltraToggleEditorBase) this.checkManualOnRenewal).Checked;
    dr.UseTableBasedNumbering = ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked;
    dr.UseSubmissionGroupNumbering = ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked;
    dr.PromptForManualOverride = ((UltraToggleEditorBase) this.chkPromptForManualOverride).Checked;
    if (dr.UseTableBasedNumbering)
    {
      dr.BlockStart = 0;
      dr.BlockEnd = 1000000;
    }
    if (dr.UseSubmissionGroupNumbering)
    {
      if (dr.IsBlockStartNull())
        dr.BlockStart = 0;
      if (dr.IsBlockEndNull())
        dr.BlockEnd = 1000000;
    }
    if (((TextEditorControlBase) this.txtPolicyNumberSuffix).Text.Replace(" ", string.Empty).Length > 0)
      dr.PolicyNumberSuffix = ((TextEditorControlBase) this.txtPolicyNumberSuffix).Text;
    else
      dr.SetPolicyNumberSuffixNull();
    if (((TextEditorControlBase) this.txtAppendPrefix).Text.Replace(" ", string.Empty).Length > 0)
      dr.AppendPrefix = ((TextEditorControlBase) this.txtAppendPrefix).Text;
    else
      dr.SetAppendPrefixNull();
    if (((UltraCombo) this.cboProgramCode).Text.Length > 0)
      dr.ProgCode = ((UltraCombo) this.cboProgramCode).Text;
    else
      dr.SetProgCodeNull();
    if (!this.IsNullableValue(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numYearSeq).Value)))
      dr.YearSuffixSequentialStart = Conversions.ToInteger(((UltraNumericEditor) this.numYearSeq).Value);
    else
      dr.SetYearSuffixSequentialStartNull();
    dr.UseRenewalDigitYear = ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Checked;
    if (((TextEditorControlBase) this.txtManualMask).Text.Replace(" ", string.Empty).Length > 0)
      dr.ManualMask = ((TextEditorControlBase) this.txtManualMask).Text;
    else
      dr.SetManualMaskNull();
    dr.UseStoredProc = ((UltraToggleEditorBase) this.chkUseStoredProc).Checked;
  }

  private void EvaluateRadioButtons(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    dr.AppendTwoDigitYear = this.rb2YearAppend.Checked;
    dr.AppendFourDigitYear = this.rb4YearAppend.Checked;
    dr.FourYearSuffix = this.rb4DigitYear.Checked;
    if (this.rb2DigitYear.Checked || this.rb4DigitYear.Checked)
    {
      dr.YearSuffix = true;
      dr.SetFixedvalueNull();
      dr.SetSequentialStartNull();
      dr.SetSequentialTotalDigitsNull();
      dr.SetSequentialStartNull();
      dr.SetYearSuffixSequentialStartNull();
      dr.SetYearSuffixSequentialTotalDigitsNull();
    }
    else
      dr.SetYearSuffixNull();
    if (this.rbFixedValue.Checked)
    {
      dr.SetYearSuffixNull();
      dr.SetSequentialStartNull();
      dr.SetSequentialTotalDigitsNull();
      dr.Fixedvalue = ((TextEditorControlBase) this.txtFixedValue).Text.ToUpper();
      dr.SetYearSuffixSequentialStartNull();
      dr.SetYearSuffixSequentialTotalDigitsNull();
    }
    else
      dr.SetFixedvalueNull();
    if (this.rbAlpha.Checked)
    {
      dr.SetYearSuffixNull();
      dr.SetSequentialStartNull();
      dr.SetSequentialTotalDigitsNull();
      dr.SetFixedvalueNull();
      dr.SetYearSuffixSequentialStartNull();
      dr.SetYearSuffixSequentialTotalDigitsNull();
      dr.AlphaSuffix = true;
      dr.AlphaSuffixRenewalOnly = ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Checked;
    }
    else
    {
      dr.SetAlphaSuffixNull();
      dr.SetAlphaSuffixRenewalOnlyNull();
    }
    if (((UltraToggleEditorBase) this.chkNumericRenewalOnly).Checked)
    {
      dr.NumericalSuffixRenewalOnly = ((UltraToggleEditorBase) this.chkNumericRenewalOnly).Checked;
      dr.AlphaSuffix = false;
    }
    if (this.rbNoSuffix.Checked)
    {
      dr.SetSequentialStartNull();
      dr.SetSequentialTotalDigitsNull();
      dr.SetFixedvalueNull();
      dr.SetYearSuffixNull();
      dr.SetYearSuffixSequentialStartNull();
      dr.SetYearSuffixSequentialTotalDigitsNull();
      dr.TwoYearSuffixSeq = false;
      dr.FourYearSuffixSeq = false;
      dr.FourYearSuffix = false;
    }
    if (this.rbSequential.Checked)
    {
      dr.SequentialStart = (int) ((UltraNumericEditor) this.numSequential).Value;
      dr.SequentialTotalDigits = (int) ((UltraNumericEditor) this.numTotalDigits).Value;
      dr.SetYearSuffixNull();
      dr.SetFixedvalueNull();
      dr.SetYearSuffixSequentialStartNull();
      dr.SetYearSuffixSequentialTotalDigitsNull();
      dr.FourYearSuffix = false;
    }
    else
    {
      dr.SetSequentialTotalDigitsNull();
      dr.SetSequentialStartNull();
    }
    dr.TwoYearSuffixSeq = this.rbTwoDigitYearSeq.Checked;
    dr.FourYearSuffixSeq = this.rbFourDigitYearSeq.Checked;
    if (this.rbTwoDigitYearSeq.Checked || this.rbFourDigitYearSeq.Checked)
    {
      dr.YearSuffixSequentialStart = (int) ((UltraNumericEditor) this.numYearSeq).Value;
      dr.YearSuffixSequentialTotalDigits = (int) ((UltraNumericEditor) this.numYearSeqTotalDigits).Value;
      dr.SetFixedvalueNull();
      dr.SetSequentialStartNull();
      dr.SetSequentialTotalDigitsNull();
      dr.SetSequentialStartNull();
      dr.SetYearSuffixNull();
      dr.FourYearSuffix = false;
    }
    else
    {
      dr.SetYearSuffixSequentialStartNull();
      dr.SetYearSuffixSequentialTotalDigitsNull();
    }
  }

  private void chkManual_CheckedChanged(object sender, EventArgs e)
  {
    if (this.ctlSaveUI.UIState != 2)
      return;
    try
    {
      foreach (Control control in ((Control) this.gbEntry).Controls)
      {
        if (control != this.chkManual && control != this.txtRuleName && control != this.txtManualMask)
        {
          control.Enabled = !((UltraToggleEditorBase) this.chkManual).Checked;
          MGANumericEditor mgaNumericEditor = control as MGANumericEditor;
          if (((UltraToggleEditorBase) this.chkManual).Checked && mgaNumericEditor != null)
            ((UltraNumericEditor) mgaNumericEditor).Value = (object) null;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.txtManualMask).Enabled = ((UltraToggleEditorBase) this.chkManual).Checked;
  }

  private void FillPrefixData(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    if (!dr.IsPrefixNull())
      ((TextEditorControlBase) this.txtPrefix).Text = dr.Prefix;
    else
      ((TextEditorControlBase) this.txtPrefix).Text = string.Empty;
    if (!dr.IsNetrateSunset1PrefixNull())
      ((TextEditorControlBase) this.txtSunset1).Text = dr.NetrateSunset1Prefix;
    else
      ((TextEditorControlBase) this.txtSunset1).Text = string.Empty;
    if (!dr.IsNetrateSunset2PrefixNull())
      ((TextEditorControlBase) this.txtSunset2).Text = dr.NetrateSunset2Prefix;
    else
      ((TextEditorControlBase) this.txtSunset2).Text = string.Empty;
    if (!dr.IsNetrateSunset3PrefixNull())
      ((TextEditorControlBase) this.txtSunset3).Text = dr.NetrateSunset3Prefix;
    else
      ((TextEditorControlBase) this.txtSunset3).Text = string.Empty;
    if (!dr.IsNetrateClaimsMadePrefixNull())
      ((TextEditorControlBase) this.txtClaimsMade).Text = dr.NetrateClaimsMadePrefix;
    else
      ((TextEditorControlBase) this.txtClaimsMade).Text = string.Empty;
  }

  private void dgRules_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgRules).ActiveRow != null)
    {
      dsPolicyNumberAdmin.tblPolicyNumberRulesRow byRuleId = this.ds.tblPolicyNumberRules.FindByRuleID(Conversions.ToInteger(((UltraGridBase) this.dgRules).ActiveRow.Cells["RuleID"].Value));
      if (byRuleId != null)
      {
        this._currentRuleID = byRuleId.RuleID;
        if (!byRuleId.IsRuleNameNull())
          ((TextEditorControlBase) this.txtRuleName).Text = byRuleId.RuleName;
        else
          ((TextEditorControlBase) this.txtRuleName).Text = string.Empty;
        ((UltraToggleEditorBase) this.chkManual).Checked = byRuleId.Manual;
        this.FillPrefixData(byRuleId);
        ((UltraToggleEditorBase) this.checkRunoff).Checked = byRuleId.Runoff;
        ((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Checked = byRuleId.ForceCheckOnRenewal;
        if (!byRuleId.IsBlockStartNull())
          ((UltraNumericEditor) this.numBlockTotalDigitsStart).Value = (object) byRuleId.BlockStart;
        else
          ((UltraNumericEditor) this.numBlockTotalDigitsStart).Value = (object) null;
        if (!byRuleId.IsBlockEndNull())
          ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value = (object) byRuleId.BlockEnd;
        else
          ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value = (object) null;
        if (!byRuleId.IsTotalBlockDigitsNull())
          ((UltraNumericEditor) this.numBlockTotalDigits).Value = (object) byRuleId.TotalBlockDigits;
        else
          ((UltraNumericEditor) this.numBlockTotalDigits).Value = (object) null;
        if (!byRuleId.IsWarnLowBlockCountNull())
          ((UltraNumericEditor) this.udNumbers).Value = (object) byRuleId.WarnLowBlockCount;
        else
          ((UltraNumericEditor) this.udNumbers).Value = (object) null;
        if (!byRuleId.IsWarnUserNull())
          ((UltraCombo) this.cboUsers).Value = (object) byRuleId.WarnUser;
        else
          ((UltraCombo) this.cboUsers).Value = (object) Guid.Empty;
        ((UltraToggleEditorBase) this.chkNewOnRenewal).Checked = byRuleId.NewNumberOnRenewal;
        ((UltraToggleEditorBase) this.chkDash).Checked = byRuleId.SuffixDash;
        if (!byRuleId.IsBasedOnEffectiveDateNull())
          ((UltraToggleEditorBase) this.chkBasedOffEffDate).Checked = byRuleId.BasedOnEffectiveDate;
        ((UltraToggleEditorBase) this.checkManualonPurchasedBook).Checked = byRuleId.ManualNumberOnPurchasedBook;
        ((UltraToggleEditorBase) this.checkManualOnRenewal).Checked = byRuleId.ManualNumberOnRenewal;
        if (!byRuleId.IsSuffixSeparateSpaceNull())
          ((UltraToggleEditorBase) this.chkSpace).Checked = byRuleId.SuffixSeparateSpace;
        else
          ((UltraToggleEditorBase) this.chkSpace).Checked = false;
        if (!byRuleId.IsUseInsuredNumberNull())
          ((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked = byRuleId.UseInsuredNumber;
        else
          ((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked = false;
        this.SetupRadioButtons(byRuleId);
        this.UpdateSampleGrid();
        ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked = byRuleId.UseTableBasedNumbering;
        ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked = byRuleId.UseSubmissionGroupNumbering;
        if (!byRuleId.IsNextNumberNull())
          ((TextEditorControlBase) this.txtNextNumberToAssign).Text = byRuleId.NextNumber;
        else
          ((TextEditorControlBase) this.txtNextNumberToAssign).Text = string.Empty;
        if (!byRuleId.IsUsePolicyNumberingFromRuleIdNull())
          ((UltraCombo) this.cboNumbering).Value = (object) byRuleId.UsePolicyNumberingFromRuleId;
        else
          ((UltraCombo) this.cboNumbering).Value = (object) -1;
        ((UltraToggleEditorBase) this.chkPromptForManualOverride).Checked = byRuleId.PromptForManualOverride;
        if (!byRuleId.IsPolicyNumberSuffixNull())
          ((TextEditorControlBase) this.txtPolicyNumberSuffix).Text = byRuleId.PolicyNumberSuffix;
        else
          ((TextEditorControlBase) this.txtPolicyNumberSuffix).Text = string.Empty;
        if (!byRuleId.IsAppendPrefixNull())
          ((TextEditorControlBase) this.txtAppendPrefix).Text = byRuleId.AppendPrefix;
        else
          ((TextEditorControlBase) this.txtAppendPrefix).Text = string.Empty;
        if (!byRuleId.IsProgCodeNull())
          ((UltraCombo) this.cboProgramCode).Value = (object) byRuleId.ProgCode;
        else
          ((UltraCombo) this.cboProgramCode).Value = (object) null;
        if (!byRuleId.IsUseRenewalDigitYearNull())
          ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Checked = byRuleId.UseRenewalDigitYear;
        else
          ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Checked = false;
        if (!byRuleId.IsManualMaskNull())
          ((TextEditorControlBase) this.txtManualMask).Text = byRuleId.ManualMask;
        else
          ((TextEditorControlBase) this.txtManualMask).Text = string.Empty;
        ((UltraToggleEditorBase) this.chkUseStoredProc).Checked = byRuleId.UseStoredProc;
      }
      else
        this._currentRuleID = int.MinValue;
    }
    else
    {
      this._currentRuleID = int.MinValue;
      ((TextEditorControlBase) this.txtRuleName).Text = string.Empty;
      ((UltraToggleEditorBase) this.chkManual).Checked = false;
      ((TextEditorControlBase) this.txtPrefix).Text = string.Empty;
      ((UltraCombo) this.cboUsers).Value = (object) Guid.Empty;
      ((UltraToggleEditorBase) this.chkBasedOffEffDate).Checked = false;
      ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked = false;
      ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked = false;
      ((TextEditorControlBase) this.txtNextNumberToAssign).Text = string.Empty;
      ((UltraCombo) this.cboNumbering).Value = (object) -1;
      ((UltraToggleEditorBase) this.chkPromptForManualOverride).Checked = false;
      ((TextEditorControlBase) this.txtPolicyNumberSuffix).Text = string.Empty;
      ((TextEditorControlBase) this.txtAppendPrefix).Text = string.Empty;
      ((UltraCombo) this.cboProgramCode).Value = (object) null;
      ((UltraToggleEditorBase) this.chkUseRenewalDigitYear).Checked = false;
      ((TextEditorControlBase) this.txtManualMask).Text = string.Empty;
      ((UltraToggleEditorBase) this.chkUseStoredProc).Checked = false;
    }
    this.GridAfterRowActivate(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void RemoveHandlers()
  {
    ((UltraNumericEditorBase) this.numBlockTotalDigitsStart).ValueChanged -= new EventHandler(this.ChangeBlock);
    ((Control) this.txtPrefix).Leave -= new EventHandler(this.ChangeBlock);
    ((Control) this.numBlockTotalDigitsStart).Leave -= new EventHandler(this.ChangeBlock);
    ((UltraToggleEditorBase) this.chkNewOnRenewal).CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rbSequential.CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rb2DigitYear.CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rbFixedValue.CheckedChanged -= new EventHandler(this.ChangeBlock);
    ((Control) this.txtFixedValue).TextChanged -= new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numBlockTotalDigits).ValueChanged -= new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numTotalDigits).ValueChanged -= new EventHandler(this.ChangeBlock);
    ((Control) this.numBlockTotalDigits).Leave -= new EventHandler(this.ChangeBlock);
    ((UltraToggleEditorBase) this.chkDash).CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rbNoSuffix.CheckedChanged -= new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numSequential).ValueChanged -= new EventHandler(this.ChangeBlock);
    ((UltraToggleEditorBase) this.chkSpace).CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rb4DigitYear.CheckedChanged -= new EventHandler(this.ChangeBlock);
    ((Control) this.txtPolicyNumberSuffix).TextChanged -= new EventHandler(this.ChangeBlock);
    ((Control) this.txtAppendPrefix).TextChanged -= new EventHandler(this.ChangeBlock);
    this.rb2YearAppend.CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rb4YearAppend.CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rbTwoDigitYearSeq.CheckedChanged -= new EventHandler(this.ChangeBlock);
    this.rbFourDigitYearSeq.CheckedChanged -= new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numYearSeq).ValueChanged -= new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numYearSeqTotalDigits).ValueChanged -= new EventHandler(this.ChangeBlock);
  }

  private void AddHandlers()
  {
    ((UltraNumericEditorBase) this.numBlockTotalDigitsStart).ValueChanged += new EventHandler(this.ChangeBlock);
    ((Control) this.txtPrefix).Leave += new EventHandler(this.ChangeBlock);
    ((Control) this.numBlockTotalDigitsStart).Leave += new EventHandler(this.ChangeBlock);
    ((UltraToggleEditorBase) this.chkNewOnRenewal).CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rbSequential.CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rb2DigitYear.CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rbFixedValue.CheckedChanged += new EventHandler(this.ChangeBlock);
    ((Control) this.txtFixedValue).TextChanged += new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numBlockTotalDigits).ValueChanged += new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numTotalDigits).ValueChanged += new EventHandler(this.ChangeBlock);
    ((Control) this.numBlockTotalDigits).Leave += new EventHandler(this.ChangeBlock);
    ((UltraToggleEditorBase) this.chkDash).CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rbNoSuffix.CheckedChanged += new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numSequential).ValueChanged += new EventHandler(this.ChangeBlock);
    ((UltraToggleEditorBase) this.chkSpace).CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rb4DigitYear.CheckedChanged += new EventHandler(this.ChangeBlock);
    ((Control) this.txtPolicyNumberSuffix).TextChanged += new EventHandler(this.ChangeBlock);
    ((Control) this.txtAppendPrefix).TextChanged += new EventHandler(this.ChangeBlock);
    this.rb2YearAppend.CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rb4YearAppend.CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rbTwoDigitYearSeq.CheckedChanged += new EventHandler(this.ChangeBlock);
    this.rbFourDigitYearSeq.CheckedChanged += new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numYearSeq).ValueChanged += new EventHandler(this.ChangeBlock);
    ((UltraNumericEditorBase) this.numYearSeqTotalDigits).ValueChanged += new EventHandler(this.ChangeBlock);
  }

  private void SetupRadioButtons(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
    try
    {
      this.RemoveHandlers();
      this.rb4YearAppend.Checked = !dr.IsAppendFourDigitYearNull() && dr.AppendFourDigitYear;
      this.rb2YearAppend.Checked = !dr.IsAppendTwoDigitYearNull() && dr.AppendTwoDigitYear;
      ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Checked = !dr.IsAlphaSuffixRenewalOnlyNull() && dr.AlphaSuffixRenewalOnly;
      ((UltraToggleEditorBase) this.chkNumericRenewalOnly).Checked = !dr.IsNumericalSuffixRenewalOnlyNull() && dr.NumericalSuffixRenewalOnly;
      if (!dr.IsSequentialStartNull())
      {
        this.rbSequential.Checked = true;
        ((Control) this.numSequential).Enabled = true;
        ((Control) this.numTotalDigits).Enabled = true;
        ((UltraNumericEditor) this.numSequential).Value = (object) dr.SequentialStart;
        ((UltraNumericEditor) this.numTotalDigits).Value = (object) dr.SequentialTotalDigits;
        ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
        ((Control) this.txtFixedValue).Enabled = false;
        ((Control) this.numYearSeq).Enabled = false;
        ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
        ((Control) this.numYearSeqTotalDigits).Enabled = false;
        ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
      }
      else
      {
        this.rbSequential.Checked = false;
        ((UltraNumericEditor) this.numSequential).Value = (object) null;
        ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
        ((Control) this.numSequential).Enabled = false;
        ((Control) this.numTotalDigits).Enabled = false;
      }
      if (!dr.IsFourYearSuffixNull() && dr.FourYearSuffix || !dr.IsYearSuffixNull() && dr.YearSuffix)
      {
        if (!dr.IsFourYearSuffixNull() && dr.FourYearSuffix)
          this.rb4DigitYear.Checked = true;
        else
          this.rb2DigitYear.Checked = true;
        ((UltraNumericEditor) this.numSequential).Value = (object) null;
        ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
        ((Control) this.numSequential).Enabled = false;
        ((Control) this.numTotalDigits).Enabled = false;
        ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
        ((Control) this.txtFixedValue).Enabled = false;
        ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
        ((Control) this.numYearSeq).Enabled = false;
        ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
        ((Control) this.numYearSeqTotalDigits).Enabled = false;
      }
      else
      {
        this.rb4DigitYear.Checked = false;
        this.rb2DigitYear.Checked = false;
      }
      if (!dr.IsFixedvalueNull())
      {
        ((TextEditorControlBase) this.txtFixedValue).Text = dr.Fixedvalue;
        this.rbFixedValue.Checked = true;
        ((Control) this.txtFixedValue).Enabled = true;
        ((UltraNumericEditor) this.numSequential).Value = (object) null;
        ((Control) this.numSequential).Enabled = false;
        ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
        ((Control) this.numTotalDigits).Enabled = false;
        ((Control) this.numYearSeq).Enabled = false;
        ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
        ((Control) this.numYearSeqTotalDigits).Enabled = false;
        ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
      }
      else
      {
        ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
        ((Control) this.txtFixedValue).Enabled = false;
        this.rbFixedValue.Checked = false;
      }
      if (!dr.IsAlphaSuffixNull() && dr.AlphaSuffix)
      {
        this.rbAlpha.Checked = true;
        ((UltraNumericEditor) this.numSequential).Value = (object) null;
        ((Control) this.numSequential).Enabled = false;
        ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
        ((Control) this.numTotalDigits).Enabled = false;
        ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
        ((Control) this.txtFixedValue).Enabled = false;
        ((Control) this.numYearSeq).Enabled = false;
        ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
        ((Control) this.numYearSeqTotalDigits).Enabled = false;
        ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
      }
      else
        this.rbAlpha.Checked = false;
      if (!dr.IsYearSuffixSequentialStartNull())
      {
        if (dr.TwoYearSuffixSeq)
          this.rbTwoDigitYearSeq.Checked = true;
        else
          this.rbFourDigitYearSeq.Checked = true;
        ((UltraNumericEditor) this.numYearSeq).Value = (object) dr.YearSuffixSequentialStart;
        ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) dr.YearSuffixSequentialTotalDigits;
        ((Control) this.numYearSeq).Enabled = true;
        ((Control) this.numYearSeqTotalDigits).Enabled = true;
        ((UltraNumericEditor) this.numSequential).Value = (object) null;
        ((Control) this.numSequential).Enabled = false;
        ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
        ((Control) this.numTotalDigits).Enabled = false;
        ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
        ((Control) this.txtFixedValue).Enabled = false;
      }
      else
      {
        ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
        ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
        ((Control) this.numYearSeq).Enabled = false;
        ((Control) this.numYearSeqTotalDigits).Enabled = false;
        this.rbTwoDigitYearSeq.Checked = false;
        this.rbFourDigitYearSeq.Checked = false;
      }
      if (this.rbSequential.Checked || this.rbFixedValue.Checked || this.rb2DigitYear.Checked || this.rbAlpha.Checked || this.rb4DigitYear.Checked || this.rbTwoDigitYearSeq.Checked || this.rbFourDigitYearSeq.Checked)
        return;
      this.rbNoSuffix.Checked = true;
    }
    finally
    {
      this.AddHandlers();
    }
  }

  private void UpdateSampleGrid()
  {
    this.lblSample.Text = ((TextEditorControlBase) this.txtPrefix).Text;
    if (((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked)
    {
      Label lblSample;
      string str = (lblSample = this.lblSample).Text + "5000";
      lblSample.Text = str;
    }
    int year;
    if (this.rb2YearAppend.Checked)
    {
      Label lblSample;
      string str = (lblSample = this.lblSample).Text + DateAndTime.Now.Year.ToString().Substring(2, 2);
      lblSample.Text = str;
    }
    else if (this.rb4YearAppend.Checked)
    {
      Label lblSample;
      string text = (lblSample = this.lblSample).Text;
      year = DateAndTime.Now.Year;
      string str1 = year.ToString();
      string str2 = text + str1;
      lblSample.Text = str2;
    }
    if (((TextEditorControlBase) this.txtAppendPrefix).Text.Replace(" ", string.Empty).Length > 0)
    {
      Label lblSample;
      string str = (lblSample = this.lblSample).Text + ((TextEditorControlBase) this.txtAppendPrefix).Text;
      lblSample.Text = str;
    }
    string empty = string.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numBlockTotalDigitsStart).Value)))
      empty = ((UltraNumericEditor) this.numBlockTotalDigitsStart).Value.ToString();
    int totalWidth1 = 0;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numBlockTotalDigits).Value)))
      totalWidth1 = Conversions.ToInteger(((UltraNumericEditor) this.numBlockTotalDigits).Value);
    Label lblSample1;
    string str3 = (lblSample1 = this.lblSample).Text + empty.PadLeft(totalWidth1, '0');
    lblSample1.Text = str3;
    if (((UltraToggleEditorBase) this.chkDash).Checked)
    {
      Label lblSample2;
      string str4 = (lblSample2 = this.lblSample).Text + "-";
      lblSample2.Text = str4;
    }
    else if (((UltraToggleEditorBase) this.chkSpace).Checked)
    {
      Label lblSample3;
      string str5 = (lblSample3 = this.lblSample).Text + " ";
      lblSample3.Text = str5;
    }
    if (this.rb2DigitYear.Checked)
    {
      Label lblSample4;
      string text = (lblSample4 = this.lblSample).Text;
      year = DateAndTime.Now.Year;
      string str6 = year.ToString().Substring(2, 2);
      string str7 = text + str6;
      lblSample4.Text = str7;
    }
    else if (this.rb4DigitYear.Checked)
    {
      Label lblSample5;
      string text = (lblSample5 = this.lblSample).Text;
      year = DateAndTime.Now.Year;
      string str8 = year.ToString();
      string str9 = text + str8;
      lblSample5.Text = str9;
    }
    else if (this.rbFixedValue.Checked)
    {
      Label lblSample6;
      string str10 = (lblSample6 = this.lblSample).Text + ((TextEditorControlBase) this.txtFixedValue).Text.ToUpper();
      lblSample6.Text = str10;
    }
    else if (this.rbSequential.Checked)
    {
      int totalWidth2 = 0;
      int num = 0;
      if (((UltraNumericEditor) this.numSequential).Value != null && ((UltraNumericEditor) this.numSequential).Value != DBNull.Value)
        num = (int) ((UltraNumericEditor) this.numSequential).Value;
      if (((UltraNumericEditor) this.numTotalDigits).Value != null && ((UltraNumericEditor) this.numTotalDigits).Value != DBNull.Value)
        totalWidth2 = (int) ((UltraNumericEditor) this.numTotalDigits).Value;
      Label lblSample7;
      string str11 = (lblSample7 = this.lblSample).Text + num.ToString().PadLeft(totalWidth2, '0');
      lblSample7.Text = str11;
    }
    else if (this.rbAlpha.Checked)
    {
      Label lblSample8;
      string str12 = (lblSample8 = this.lblSample).Text + "A";
      lblSample8.Text = str12;
    }
    else if (this.rbTwoDigitYearSeq.Checked || this.rbFourDigitYearSeq.Checked)
    {
      int totalWidth3 = 0;
      int num = 0;
      if (((UltraNumericEditor) this.numYearSeq).Value != null && ((UltraNumericEditor) this.numYearSeq).Value != DBNull.Value)
        num = (int) ((UltraNumericEditor) this.numYearSeq).Value;
      if (((UltraNumericEditor) this.numYearSeqTotalDigits).Value != null && ((UltraNumericEditor) this.numYearSeqTotalDigits).Value != DBNull.Value)
        totalWidth3 = (int) ((UltraNumericEditor) this.numYearSeqTotalDigits).Value;
      string str13;
      if (this.rbTwoDigitYearSeq.Checked)
      {
        year = DateAndTime.Now.Year;
        str13 = year.ToString().Substring(2, 2);
      }
      else
      {
        year = DateAndTime.Now.Year;
        str13 = year.ToString();
      }
      Label lblSample9;
      string str14 = (lblSample9 = this.lblSample).Text + str13 + num.ToString().PadLeft(totalWidth3, '0');
      lblSample9.Text = str14;
    }
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtPolicyNumberSuffix).Text))
      return;
    this.lblSample.Text += ((TextEditorControlBase) this.txtPolicyNumberSuffix).Text;
  }

  private void DisableEnableOnCheckChange()
  {
    if (this.rbNoSuffix.Checked)
    {
      ((UltraNumericEditor) this.numSequential).Value = (object) null;
      ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
      ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
      ((Control) this.txtFixedValue).Enabled = false;
      ((Control) this.numSequential).Enabled = false;
      ((Control) this.numTotalDigits).Enabled = false;
      ((Control) this.numYearSeq).Enabled = false;
      ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
      ((Control) this.numYearSeqTotalDigits).Enabled = false;
      ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
    }
    else if (this.rbSequential.Checked)
    {
      ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
      ((Control) this.txtFixedValue).Enabled = false;
      ((Control) this.numYearSeq).Enabled = false;
      ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
      ((Control) this.numYearSeqTotalDigits).Enabled = false;
      ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
      ((Control) this.numSequential).Enabled = true;
      ((Control) this.numTotalDigits).Enabled = true;
    }
    else if (this.rb2DigitYear.Checked || this.rb4DigitYear.Checked)
    {
      ((UltraNumericEditor) this.numSequential).Value = (object) null;
      ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
      ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
      ((Control) this.txtFixedValue).Enabled = false;
      ((Control) this.numSequential).Enabled = false;
      ((Control) this.numTotalDigits).Enabled = false;
      ((Control) this.numYearSeq).Enabled = false;
      ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
      ((Control) this.numYearSeqTotalDigits).Enabled = false;
      ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
    }
    else if (this.rbFixedValue.Checked)
    {
      ((Control) this.txtFixedValue).Enabled = true;
      ((Control) this.numSequential).Enabled = false;
      ((Control) this.numTotalDigits).Enabled = false;
      ((UltraNumericEditor) this.numSequential).Value = (object) null;
      ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
      ((Control) this.numYearSeq).Enabled = false;
      ((UltraNumericEditor) this.numYearSeq).Value = (object) null;
      ((Control) this.numYearSeqTotalDigits).Enabled = false;
      ((UltraNumericEditor) this.numYearSeqTotalDigits).Value = (object) null;
    }
    else
    {
      if (!this.rbTwoDigitYearSeq.Checked && !this.rbFourDigitYearSeq.Checked)
        return;
      ((Control) this.txtFixedValue).Enabled = false;
      ((TextEditorControlBase) this.txtFixedValue).Text = string.Empty;
      ((Control) this.numSequential).Enabled = false;
      ((Control) this.numTotalDigits).Enabled = false;
      ((UltraNumericEditor) this.numSequential).Value = (object) null;
      ((UltraNumericEditor) this.numTotalDigits).Value = (object) null;
      ((Control) this.numYearSeq).Enabled = true;
      ((Control) this.numYearSeqTotalDigits).Enabled = true;
    }
  }

  private void ChangeBlock(object sender, EventArgs e)
  {
    if ((sender == this.numBlockTotalDigitsEnd || sender == this.numBlockTotalDigitsStart) && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numBlockTotalDigitsStart).Value)) && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value)))
    {
      int num1 = (int) ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value;
      int num2 = (int) ((UltraNumericEditor) this.numBlockTotalDigitsStart).Value;
      int num3 = num2;
      if (num1 <= num3 && num2 + 1 <= (int) ((UltraNumericEditor) this.numBlockTotalDigitsEnd).MaxValue)
        ((UltraNumericEditor) this.numBlockTotalDigitsEnd).Value = (object) (num2 + 1);
    }
    this.DisableEnableOnCheckChange();
    this.UpdateSampleGrid();
  }

  private void ctlSaveUI_ClickedDelete(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgRules).ActiveRow == null || this._currentRuleID == int.MinValue)
      return;
    if (this._ruleLockDown.Contains(this._currentRuleID))
    {
      int num1 = (int) MessageBox.Show("This rule cannot be deleted as it has been already applied.", "Cannot Delete. Rule Applied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this policy numbering rule?", "Delete Rule?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        this.ds.tblPolicyNumberRules.FindByRuleID(this._currentRuleID).Delete();
        DefaultDatabase.DataAdapterUpdate(this.daRule, (DataTable) this.ds.tblPolicyNumberRules);
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception exception = ex1;
        try
        {
          this.ds.tblPolicyNumberRules.RejectChanges();
        }
        catch (NullReferenceException ex2)
        {
          ProjectData.SetProjectError((Exception) ex2);
          ProjectData.ClearProjectError();
        }
        if (exception.Message.Contains("FK_tblCompanyLines_tblPolicyNumberRules"))
        {
          int num2 = (int) MessageBox.Show("This rule can not be deleted, it is currently in use.", "Rule In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError(exception);
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
      if (this.ds.tblPolicyNumberRules.Rows.Count != 0)
        return;
      this.ctlSaveUI.UIState = (UIState) 0;
      this.dgRules_AfterRowActivate((object) null, (EventArgs) null);
    }
  }

  private void ctlSaveUI_ClickingEdit(object sender, CancelEventArgs e)
  {
    this._clickingNew = false;
    if (((UltraGridBase) this.dgRules).ActiveRow == null)
    {
      if (this.ds.tblPolicyNumberRules.Rows.Count == 0)
        this.ctlSaveUI.UIState = (UIState) 0;
      e.Cancel = true;
    }
    else
    {
      if (this._currentRuleID == int.MinValue || !this._ruleLockDown.Contains(this._currentRuleID))
        return;
      int num = (int) MessageBox.Show("This rule cannot be edited as it has already been applied.", "Cannot Edit. Rule Applied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
  }

  private void PopulatePolicyNumberingDropdown()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("RuleName", typeof (string));
    dataTable.Columns.Add("RuleID", typeof (int));
    try
    {
      foreach (dsPolicyNumberAdmin.tblPolicyNumberRulesRow policyNumberRule in (TypedTableBase<dsPolicyNumberAdmin.tblPolicyNumberRulesRow>) this.ds.tblPolicyNumberRules)
      {
        if (policyNumberRule.RowState != DataRowState.Deleted)
          dataTable.Rows.Add((object) policyNumberRule.RuleName, (object) policyNumberRule.RuleID);
      }
    }
    finally
    {
      IEnumerator<dsPolicyNumberAdmin.tblPolicyNumberRulesRow> enumerator;
      enumerator?.Dispose();
    }
    DataRow row = dataTable.NewRow();
    row["RuleName"] = (object) "";
    row["RuleID"] = (object) -1;
    dataTable.Rows.InsertAt(row, 0);
    ((UltraGridBase) this.cboNumbering).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.cboNumbering).DisplayMember = "RuleName";
    ((UltraCombo) this.cboNumbering).Value = (object) "RuleID";
    ((UltraGridBase) this.cboNumbering).DataBind();
  }

  private void SetFieldAccess(bool Editing)
  {
    if (((UltraToggleEditorBase) this.chkManual).Checked)
    {
      if (Editing)
      {
        try
        {
          foreach (Control control in ((Control) this.gbEntry).Controls)
            control.Enabled = control == this.chkManual || control == this.txtRuleName || control == this.chkManual;
          goto label_40;
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    if (Editing && ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked)
    {
      bool flag = this.ctlSaveUI.UIState == 2 && ((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked;
      try
      {
        foreach (Control control in ((Control) this.gbEntry).Controls)
          control.Enabled = flag && control != this.cboNumbering && control != this.chkManual && control != this.chkUseTableBasedNumbering && control != this.txtNextNumberToAssign && control != this.UltraGroupBox1;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else if (Editing && ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked)
    {
      bool flag = this.ctlSaveUI.UIState == 2 && ((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked;
      try
      {
        foreach (Control control in ((Control) this.gbEntry).Controls)
          control.Enabled = flag && control != this.cboNumbering && control != this.numBlockTotalDigitsStart && control != this.numBlockTotalDigitsEnd && control != this.udNumbers && control != this.cboUsers && control != this.chkManual && control != this.chkUseSubmissionGroupNumbering && control != this.txtNextNumberToAssign && control != this.UltraGroupBox1 && control != this.numBlockTotalDigits;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else if (Editing && ((UltraCombo) this.cboNumbering).Value != null && (int) ((UltraCombo) this.cboNumbering).Value != -1)
    {
      bool flag = this.ctlSaveUI.UIState == 2 && ((UltraCombo) this.cboNumbering).Value != null && (int) ((UltraCombo) this.cboNumbering).Value != -1;
      try
      {
        foreach (Control control in ((Control) this.gbEntry).Controls)
          control.Enabled = flag && control != this.numBlockTotalDigitsStart && control != this.numBlockTotalDigitsEnd && control != this.numBlockTotalDigits && control != this.udNumbers && control != this.cboUsers && control != this.chkNewOnRenewal && control != this.checkRunoff && control != this.chkForceCheckNewPolicy && control != this.checkManualonPurchasedBook && control != this.checkManualOnRenewal && control != this.chkManual && control != this.chkUseTableBasedNumbering && control != this.chkUseSubmissionGroupNumbering && control != this.Panel1 && control != this.UltraGroupBox1;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      try
      {
        foreach (Control control in ((Control) this.gbEntry).Controls)
        {
          if (!this.IsMonitoredControl(control))
            control.Enabled = Editing;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ((Control) this.chkManual).Enabled = this.ctlSaveUI.UIState == 2 && !((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked && !((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked;
      ((Control) this.chkUseTableBasedNumbering).Enabled = this.ctlSaveUI.UIState == 2 && !((UltraToggleEditorBase) this.chkManual).Checked && !((UltraToggleEditorBase) this.chkUseSubmissionGroupNumbering).Checked;
      ((Control) this.chkUseSubmissionGroupNumbering).Enabled = this.ctlSaveUI.UIState == 2 && !((UltraToggleEditorBase) this.chkManual).Checked && !((UltraToggleEditorBase) this.chkUseTableBasedNumbering).Checked;
      ((Control) this.chkNewOnRenewal).Enabled = this.ctlSaveUI.UIState == 2 && !((UltraToggleEditorBase) this.checkRunoff).Checked && !((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Checked;
      ((Control) this.checkRunoff).Enabled = this.ctlSaveUI.UIState == 2 && !((UltraToggleEditorBase) this.chkNewOnRenewal).Checked && !((UltraToggleEditorBase) this.chkForceCheckNewPolicy).Checked;
      ((Control) this.chkForceCheckNewPolicy).Enabled = this.ctlSaveUI.UIState == 2 && !((UltraToggleEditorBase) this.chkNewOnRenewal).Checked && !((UltraToggleEditorBase) this.checkRunoff).Checked;
    }
label_40:
    ((Control) this.dgRules).Enabled = !Editing;
    this.lnkMoreNoteUsers.Enabled = !Editing;
    ((Control) this.txtManualMask).Enabled = ((UltraToggleEditorBase) this.chkManual).Checked && Editing;
  }

  private bool IsMonitoredControl(Control ctrl)
  {
    return ctrl == this.chkUseSubmissionGroupNumbering || ctrl == this.chkUseTableBasedNumbering || ctrl == this.chkForceCheckNewPolicy || ctrl == this.checkRunoff || ctrl == this.chkNewOnRenewal;
  }

  private void MonitoredControl_Changed(object sender, EventArgs e)
  {
    this.SetFieldAccess(this.ctlSaveUI.UIState == 2);
  }

  private void chkUseInsuredNumber_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkUseInsuredNumber).Checked)
    {
      ((Control) this.txtNextNumberToAssign).Enabled = false;
      ((Control) this.numBlockTotalDigitsStart).Enabled = false;
      ((Control) this.numBlockTotalDigitsEnd).Enabled = false;
    }
    else
    {
      ((Control) this.txtNextNumberToAssign).Enabled = true;
      ((Control) this.numBlockTotalDigitsStart).Enabled = true;
      ((Control) this.numBlockTotalDigitsEnd).Enabled = true;
    }
  }

  private void lnkMoreNoteUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.dgRules).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid to continue.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Form form = ObjectFactory.Instance.CreateForm(typeof (PolicyNumberNotesUser), new object[1]
      {
        ((UltraGridBase) this.dgRules).ActiveRow.Cells["RuleID"].Value
      });
      form.MdiParent = MDIControls.Instance.MDIParent;
      form.FormBorderStyle = FormBorderStyle.Sizable;
      form.MaximizeBox = true;
      form.Show();
    }
  }

  private void checkAlphaRenewalOnly_CheckedChanged(object sender, EventArgs e)
  {
    if (!((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Checked)
      return;
    ((UltraToggleEditorBase) this.chkNumericRenewalOnly).Checked = false;
  }

  private void chkNumericRenewalOnly_CheckedChanged(object sender, EventArgs e)
  {
    if (!((UltraToggleEditorBase) this.chkNumericRenewalOnly).Checked)
      return;
    ((UltraToggleEditorBase) this.checkAlphaRenewalOnly).Checked = false;
  }

  private void btnGenNumbers_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgRules).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid to continue.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      FormSettings.ShowFormDialog(typeof (FormTablePolicyNumberEntry), new object[1]
      {
        ((UltraGridBase) this.dgRules).ActiveRow.Cells["RuleID"].Value
      });
  }

  protected virtual bool ContinueRunOffUpdate()
  {
    bool flag;
    if (!this._canUpdateRunOff)
    {
      int num = (int) MessageBox.Show("You do not have the required security to update run-off rules.", "Run-off Rules Security Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (((UltraGridBase) this.dgRules).ActiveRow == null)
    {
      int num = (int) MessageBox.Show($"An active row is not selected.{Environment.NewLine}{Environment.NewLine}Please select a row in the grid to continue.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = 6 == (int) MessageBox.Show($"Do you wish to continue and change run-Off from {((UltraToggleEditorBase) this.checkRunoff).Checked} to {!((UltraToggleEditorBase) this.checkRunoff).Checked} for rule {Environment.NewLine}{Environment.NewLine}'{((TextEditorControlBase) this.txtRuleName).Text}'{Environment.NewLine}{Environment.NewLine}?", "Continue And Modify Run-off?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    return flag;
  }

  protected virtual void SaveAndLogRunOffUpdate()
  {
    bool flag = ((UltraToggleEditorBase) this.checkRunoff).Checked;
    int num = DefaultDatabase.ExecuteNonQuery("dbo.PolicyNumberRunoffUpdate", new object[4]
    {
      (object) "@RuleID",
      ((UltraGridBase) this.dgRules).ActiveRow.Cells["RuleID"].Value,
      (object) "@Runoff",
      (object) !flag
    });
    this.ds.tblPolicyNumberRules.FindByRuleID(Conversions.ToInteger(((UltraGridBase) this.dgRules).ActiveRow.Cells["RuleID"].Value)).Runoff = !flag;
    ((UltraToggleEditorBase) this.checkRunoff).Checked = !flag;
    this.ds.tblPolicyNumberRules.AcceptChanges();
    CurrentUser.Instance.LogAction($"Modified policy number rule '{((TextEditorControlBase) this.txtRuleName).Text}'. Set run-off from {flag} to {!flag}. # rows affected = {num}");
  }

  private void btnRunOff_Click(object sender, EventArgs e)
  {
    if (!this.ContinueRunOffUpdate())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.SaveAndLogRunOffUpdate();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void GridAfterRowActivate(object sender, EventArgs e)
  {
  }

  protected virtual void SavingOnClient(dsPolicyNumberAdmin.tblPolicyNumberRulesRow dr)
  {
  }

  private struct PolicyStruct
  {
    public string ColumnName;
    public string OrigValue;
    public string CurrValue;
    public char EntityType;
    public string RuleName;
  }
}
