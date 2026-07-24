// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.NumberingAutomation.ClaimNumberingAutomationUI
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.NumberingAutomation;

public class ClaimNumberingAutomationUI : UserControlBase
{
  private int _currentRuleId = -1;
  private int _ruleLength;
  private IContainer components;
  protected Label label2;
  protected Label label1;
  protected MGAGroupBox groupDefinedRules;
  protected Label label3;
  protected MGATextBox textRuleName;
  protected MGACheckBox checkManual;
  protected MGATextBox textPrefix;
  protected Label labelPrefix;
  protected MGAMaskedEdit maskedEditRangeFrom;
  protected Label label4;
  protected MGAMaskedEdit maskedEditRangeTo;
  protected Label label6;
  protected Label label7;
  protected MGAMaskedEdit maskedEditTotalLength;
  protected UltraGrid gridCurrentRules;
  protected Label label5;
  protected MGATextBox textSample;
  protected MGAGroupBox mgaGroupBox1;
  protected MGAButton buttonCancel;
  protected MGAButton buttonSave;
  protected dsNumberingRules dsNumberingRules1;
  protected Label labelSuffix;
  protected MGATextBox textSuffix;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top;

  public ClaimNumberingAutomationUI()
  {
    this.InitializeComponent();
    this.LoadRules();
  }

  protected virtual string GetSamplePrefix() => ((Control) this.textPrefix).Text;

  protected virtual string GetSampleSuffix() => ((Control) this.textSuffix).Text;

  private void GenerateSample()
  {
    string samplePrefix = this.GetSamplePrefix();
    string sampleSuffix = this.GetSampleSuffix();
    int length1 = samplePrefix.Length;
    int length2 = sampleSuffix.Length;
    if (string.IsNullOrEmpty(((Control) this.maskedEditTotalLength).Text))
    {
      ((TextEditorControlBase) this.textSample).Appearance.ForeColor = Color.Red;
      ((Control) this.textSample).Text = "Error - Total Length Required";
    }
    else
    {
      this._ruleLength = int.Parse(((Control) this.maskedEditTotalLength).Text);
      ((TextEditorControlBase) this.textSample).Appearance.ForeColor = Color.Black;
      int ruleLength = this._ruleLength;
      if (ruleLength < length1)
      {
        ((Control) this.textSample).Text = samplePrefix.Substring(0, ruleLength);
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Capacity = ruleLength;
        if (!string.IsNullOrEmpty(samplePrefix))
        {
          ruleLength -= length1;
          stringBuilder.Append(samplePrefix);
        }
        if (!string.IsNullOrEmpty(sampleSuffix))
          ruleLength -= length2;
        if (!string.IsNullOrEmpty(((Control) this.maskedEditRangeFrom).Text))
        {
          int num1 = this._ruleLength - (length1 + length2);
          int num2 = ruleLength - ((Control) this.maskedEditRangeFrom).Text.Length;
          if (num1 > 0)
          {
            if (num2 <= 0)
              stringBuilder.Append(((Control) this.maskedEditRangeFrom).Text.Substring(0, this._ruleLength - (length1 + length2)));
            else
              stringBuilder.Append(((Control) this.maskedEditRangeFrom).Text.PadLeft(((Control) this.maskedEditTotalLength).Text.Length + num2 - 1, "0".ToCharArray()[0]));
          }
        }
        else if (ruleLength >= 0)
          stringBuilder.Append("1".PadLeft(ruleLength - 1, "0".ToCharArray()[0]));
        if (!string.IsNullOrEmpty(sampleSuffix))
          stringBuilder.Append(sampleSuffix);
        ((Control) this.textSample).Text = stringBuilder.ToString();
      }
    }
  }

  private void TextChangedHandler(object sender, EventArgs e) => this.GenerateSample();

  private void checkManual_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.textPrefix).Enabled = !((UltraToggleEditorBase) this.checkManual).Checked;
    ((Control) this.maskedEditRangeFrom).Enabled = !((UltraToggleEditorBase) this.checkManual).Checked;
    ((Control) this.maskedEditRangeTo).Enabled = !((UltraToggleEditorBase) this.checkManual).Checked;
    ((Control) this.maskedEditTotalLength).Enabled = !((UltraToggleEditorBase) this.checkManual).Checked;
    if (((UltraToggleEditorBase) this.checkManual).Checked)
      return;
    ((Control) this.textPrefix).Text = string.Empty;
    ((Control) this.maskedEditRangeFrom).Text = string.Empty;
    ((Control) this.maskedEditRangeTo).Text = string.Empty;
    this.GenerateSample();
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Clear();

  private void Clear()
  {
    this._currentRuleId = -1;
    ((Control) this.textRuleName).Text = string.Empty;
    ((Control) this.textPrefix).Text = string.Empty;
    ((Control) this.maskedEditRangeFrom).Text = string.Empty;
    ((Control) this.maskedEditRangeTo).Text = string.Empty;
    ((Control) this.maskedEditTotalLength).Text = "25";
    ((UltraToggleEditorBase) this.checkManual).Checked = false;
  }

  protected virtual bool Verify()
  {
    if (string.IsNullOrEmpty(((Control) this.textRuleName).Text))
    {
      int num = (int) MessageBox.Show(Resources.NUMAUTOMATION_ERROR_RULENAME, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraToggleEditorBase) this.checkManual).Checked)
      return true;
    if (string.IsNullOrEmpty(((Control) this.maskedEditRangeFrom).Text) && !string.IsNullOrEmpty(((Control) this.maskedEditRangeTo).Text) || !string.IsNullOrEmpty(((Control) this.maskedEditRangeFrom).Text) && string.IsNullOrEmpty(((Control) this.maskedEditRangeTo).Text))
    {
      int num = (int) MessageBox.Show(Resources.NUMAUTOMATION_ERROR_RANGEERROR, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!string.IsNullOrEmpty(((Control) this.maskedEditRangeFrom).Text) && !string.IsNullOrEmpty(((Control) this.maskedEditRangeTo).Text) && int.Parse(((Control) this.maskedEditRangeFrom).Text) > int.Parse(((Control) this.maskedEditRangeTo).Text))
    {
      int num = (int) MessageBox.Show(Resources.NUMAUTOMATION_ERROR_RANGEMISMATCH, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!((UltraToggleEditorBase) this.checkManual).Checked)
    {
      if (((Control) this.maskedEditTotalLength).Text.Length == 0)
      {
        int num = (int) MessageBox.Show(Resources.NUMAUTOMATION_ERROR_RULELENGTH, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (((Control) this.textPrefix).Text.Length + ((Control) this.maskedEditRangeTo).Text.Length + ((Control) this.textSuffix).Text.Length > this._ruleLength)
      {
        int num = (int) MessageBox.Show($"The length is not long enough to fit the{$" prefix ({((Control) this.textPrefix).Text.Length}), maximum range ({((Control) this.maskedEditRangeTo).Text.Length}) and suffix ({((Control) this.textSuffix).Text.Length}). "}{$"Please change it to at least {((Control) this.textPrefix).Text.Length + ((Control) this.maskedEditRangeTo).Text.Length + ((Control) this.textSuffix).Text.Length}."}", "Error saving Claim Number Rule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
  }

  private void Save()
  {
    if (this._currentRuleId == -1)
    {
      if (((UltraToggleEditorBase) this.checkManual).Checked)
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertNumberingRule", new object[4]
        {
          (object) "@RuleName",
          (object) ((Control) this.textRuleName).Text,
          (object) "@IsManual",
          (object) 1
        });
      else
        DefaultDatabase.ExecuteNonQuery("spClaims_InsertNumberingRule", new object[14]
        {
          (object) "@RuleName",
          (object) ((Control) this.textRuleName).Text,
          (object) "@IsManual",
          (object) 0,
          (object) "@Prefix",
          (object) ((Control) this.textPrefix).Text,
          (object) "@RangeFrom",
          (object) ((Control) this.maskedEditRangeFrom).Text,
          (object) "@RangeTo",
          (object) ((Control) this.maskedEditRangeTo).Text,
          (object) "@TotalLength",
          (object) ((Control) this.maskedEditTotalLength).Text,
          (object) "@Suffix",
          (object) ((Control) this.textSuffix).Text
        });
    }
    else if (((UltraToggleEditorBase) this.checkManual).Checked)
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateNumberingRule", new object[6]
      {
        (object) "@RuleId",
        (object) this._currentRuleId,
        (object) "@RuleName",
        (object) ((Control) this.textRuleName).Text,
        (object) "@IsManual",
        (object) 1
      });
    else
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateNumberingRule", new object[16 /*0x10*/]
      {
        (object) "@RuleId",
        (object) this._currentRuleId,
        (object) "@RuleName",
        (object) ((Control) this.textRuleName).Text,
        (object) "@IsManual",
        (object) 0,
        (object) "@Prefix",
        (object) ((Control) this.textPrefix).Text,
        (object) "@RangeFrom",
        (object) ((Control) this.maskedEditRangeFrom).Text,
        (object) "@RangeTo",
        (object) ((Control) this.maskedEditRangeTo).Text,
        (object) "@TotalLength",
        (object) ((Control) this.maskedEditTotalLength).Text,
        (object) "@Suffix",
        (object) ((Control) this.textSuffix).Text
      });
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.Verify())
      return;
    this.Save();
    this.Clear();
    this.LoadRules();
  }

  private void maskedEditTotalLength_ValueChanged(object sender, EventArgs e)
  {
    this.GenerateSample();
  }

  private void LoadRules()
  {
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      ((UltraGridBase) this.gridCurrentRules).DataSource = (object) null;
      this.dsNumberingRules1.Rules.Clear();
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) => DefaultDatabase.LoadDataSet((DataSet) this.dsNumberingRules1, new string[1]
      {
        "Rules"
      }, "spClaims_GetNumberingRules"));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        ((UltraGridBase) this.gridCurrentRules).DataSource = (object) this.dsNumberingRules1.Rules;
        ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Load(((UltraGridBase) this.gridCurrentRules).Layouts[0], (PropertyCategories) -1);
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "EDIT":
        this.DisplayRuleForEdit();
        break;
      case "DELETE":
        this.DeleteRule();
        break;
    }
  }

  private void DisplayRuleForEdit()
  {
    if (((SparseCollectionBase) this.gridCurrentRules.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridCurrentRules.Selected.Rows[0];
    this._currentRuleId = int.Parse(row.Cells["RuleId"].Value.ToString());
    ((Control) this.textRuleName).Text = row.Cells["ruleName"].Value.ToString();
    ((Control) this.textPrefix).Text = row.Cells["Prefix"].Value.ToString();
    ((UltraMaskedEdit) this.maskedEditRangeFrom).Value = row.Cells["RangeFrom"].Value;
    ((UltraMaskedEdit) this.maskedEditRangeTo).Value = row.Cells["RangeTo"].Value;
    ((UltraMaskedEdit) this.maskedEditTotalLength).Value = row.Cells["TotalLength"].Value;
    ((Control) this.textSuffix).Text = row.Cells["Suffix"].Value.ToString();
    ((UltraToggleEditorBase) this.checkManual).Checked = bool.Parse(row.Cells["IsManual"].Value.ToString());
  }

  private void DeleteRule()
  {
    if (((SparseCollectionBase) this.gridCurrentRules.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridCurrentRules.Selected.Rows[0];
    if (MessageBox.Show("This action cannot be undone. Continue?", $"Permanently Delete {row.Cells["RuleName"].Value} Rule?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    DefaultDatabase.ExecuteNonQuery("spClaims_DeleteNumberingRule", new object[2]
    {
      (object) "@RuleId",
      row.Cells["RuleId"].Value
    });
    this.LoadRules();
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
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Rules", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RuleId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RuleName");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Prefix");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RangeFrom");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("RangeTo");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("TotalLength");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("IsManual");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Rules", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RuleId");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("RuleName");
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Prefix");
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("RangeFrom");
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("RangeTo");
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("TotalLength");
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("IsManual");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("ContextTB");
    ButtonTool buttonTool1 = new ButtonTool("EDIT");
    Appearance appearance47 = new Appearance();
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    Appearance appearance48 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("CONTEXTMENU");
    ButtonTool buttonTool3 = new ButtonTool("EDIT");
    ButtonTool buttonTool4 = new ButtonTool("DELETE");
    this.label2 = new Label();
    this.label1 = new Label();
    this.groupDefinedRules = new MGAGroupBox();
    this.gridCurrentRules = new UltraGrid();
    this.dsNumberingRules1 = new dsNumberingRules();
    this.label3 = new Label();
    this.textRuleName = new MGATextBox();
    this.checkManual = new MGACheckBox();
    this.textPrefix = new MGATextBox();
    this.labelPrefix = new Label();
    this.maskedEditRangeFrom = new MGAMaskedEdit();
    this.label4 = new Label();
    this.maskedEditRangeTo = new MGAMaskedEdit();
    this.label6 = new Label();
    this.label7 = new Label();
    this.maskedEditTotalLength = new MGAMaskedEdit();
    this.label5 = new Label();
    this.textSample = new MGATextBox();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.labelSuffix = new Label();
    this.textSuffix = new MGATextBox();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.groupDefinedRules).BeginInit();
    ((Control) this.groupDefinedRules).SuspendLayout();
    ((ISupportInitialize) this.gridCurrentRules).BeginInit();
    this.dsNumberingRules1.BeginInit();
    ((ISupportInitialize) this.textRuleName).BeginInit();
    ((ISupportInitialize) this.checkManual).BeginInit();
    ((ISupportInitialize) this.textPrefix).BeginInit();
    ((ISupportInitialize) this.maskedEditRangeFrom).BeginInit();
    ((ISupportInitialize) this.maskedEditRangeTo).BeginInit();
    ((ISupportInitialize) this.maskedEditTotalLength).BeginInit();
    ((ISupportInitialize) this.textSample).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.textSuffix).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Location = new Point(20, 42);
    this.label2.Name = "label2";
    this.label2.Size = new Size(620, 1);
    this.label2.TabIndex = 1;
    this.label2.Text = "label2";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(13, 10);
    this.label1.Name = "label1";
    this.label1.Size = new Size(328, 33);
    this.label1.TabIndex = 0;
    this.label1.Text = "Claim Number Automation";
    ((Control) this.groupDefinedRules).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.groupDefinedRules).ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.groupDefinedRules).Controls.Add((Control) this.gridCurrentRules);
    ((Control) this.groupDefinedRules).ForeColor = Color.Black;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGroupBox) this.groupDefinedRules).HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.groupDefinedRules).Location = new Point(19, 217);
    ((Control) this.groupDefinedRules).Name = "groupDefinedRules";
    ((Control) this.groupDefinedRules).Size = new Size(621, 332);
    ((Control) this.groupDefinedRules).TabIndex = 3;
    ((Control) this.groupDefinedRules).Text = "Current Numbering Rules";
    ((UltraGroupBox) this.groupDefinedRules).ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.gridCurrentRules).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridCurrentRules, "CONTEXTMENU");
    ((UltraGridBase) this.gridCurrentRules).DataSource = (object) this.dsNumberingRules1;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 86;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Rule";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 103;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 101;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Range From";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 101;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Range To";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 101;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Total Length";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 101;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Manual";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 101;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand1.Header).Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = Color.Transparent;
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance17).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridCurrentRules).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance19;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 86;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Rule";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 1;
    ultraGridColumn9.Width = 103;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 2;
    ultraGridColumn10.Width = 101;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Range From";
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 3;
    ultraGridColumn11.Width = 101;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Range To";
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 4;
    ultraGridColumn12.Width = 101;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Total Length";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 5;
    ultraGridColumn13.Width = 101;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Manual";
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 6;
    ultraGridColumn14.Width = 101;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand2.Header).Appearance = (AppearanceBase) appearance26;
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance28;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance30).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance31;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance32).BackColor = Color.Transparent;
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance33).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance34;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridCurrentRules).Layouts.Add(ultraGridLayout);
    ((Control) this.gridCurrentRules).Location = new Point(6, 23);
    ((Control) this.gridCurrentRules).Name = "gridCurrentRules";
    ((Control) this.gridCurrentRules).Size = new Size(610, 304);
    ((Control) this.gridCurrentRules).TabIndex = 0;
    ((UltraControlBase) this.gridCurrentRules).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCurrentRules).UseOsThemes = (DefaultableBoolean) 2;
    this.dsNumberingRules1.DataSetName = "dsNumberingRules";
    this.dsNumberingRules1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.FromArgb(239, 247, 253);
    this.label3.Location = new Point(8, 30);
    this.label3.Name = "label3";
    this.label3.Size = new Size(62, 13);
    this.label3.TabIndex = 0;
    this.label3.Text = "Rule Name:";
    ((AppearanceBase) appearance35).BackColor = Color.White;
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance35).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textRuleName).Appearance = (AppearanceBase) appearance35;
    ((Control) this.textRuleName).BackColor = Color.White;
    ((Control) this.textRuleName).Location = new Point(81, 30);
    this.textRuleName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textRuleName).Name = "textRuleName";
    ((Control) this.textRuleName).Size = new Size(252, 20);
    ((Control) this.textRuleName).TabIndex = 1;
    ((UltraControlBase) this.textRuleName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textRuleName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.checkManual).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance36).BorderColor = Color.Gray;
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkManual).Appearance = (AppearanceBase) appearance36;
    ((Control) this.checkManual).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraToggleEditorBase) this.checkManual).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((UltraToggleEditorBase) this.checkManual).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.checkManual).Location = new Point(350, 28);
    ((Control) this.checkManual).Name = "checkManual";
    ((Control) this.checkManual).Size = new Size(254, 20);
    ((Control) this.checkManual).TabIndex = 12;
    ((Control) this.checkManual).Text = "Manual Entry - User will specify claim number.";
    ((UltraControlBase) this.checkManual).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkManual).CheckedChanged += new EventHandler(this.checkManual_CheckedChanged);
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrefix).Appearance = (AppearanceBase) appearance37;
    ((Control) this.textPrefix).BackColor = Color.White;
    ((Control) this.textPrefix).Location = new Point(81, 53);
    ((TextEditorControlBase) this.textPrefix).MaxLength = 15;
    this.textPrefix.MGAStyle = (MGAStyles) 2;
    ((Control) this.textPrefix).Name = "textPrefix";
    ((Control) this.textPrefix).Size = new Size(131, 20);
    ((Control) this.textPrefix).TabIndex = 3;
    ((UltraControlBase) this.textPrefix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPrefix).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textPrefix).TextChanged += new EventHandler(this.TextChangedHandler);
    this.labelPrefix.AutoSize = true;
    this.labelPrefix.BackColor = Color.FromArgb(239, 247, 253);
    this.labelPrefix.Location = new Point(8, 53);
    this.labelPrefix.Name = "labelPrefix";
    this.labelPrefix.Size = new Size(39, 13);
    this.labelPrefix.TabIndex = 2;
    this.labelPrefix.Text = "Prefix:";
    ((AppearanceBase) appearance38).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.maskedEditRangeFrom).Appearance = (AppearanceBase) appearance38;
    ((UltraMaskedEdit) this.maskedEditRangeFrom).EditAs = (EditAsType) 5;
    ((UltraMaskedEdit) this.maskedEditRangeFrom).InputMask = "999999";
    ((Control) this.maskedEditRangeFrom).Location = new Point(81, 76);
    this.maskedEditRangeFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskedEditRangeFrom).Name = "maskedEditRangeFrom";
    ((Control) this.maskedEditRangeFrom).Size = new Size(51, 21);
    ((Control) this.maskedEditRangeFrom).TabIndex = 5;
    ((UltraControlBase) this.maskedEditRangeFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskedEditRangeFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.maskedEditRangeFrom).TextChanged += new EventHandler(this.TextChangedHandler);
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.FromArgb(239, 247, 253);
    this.label4.Location = new Point(8, 76);
    this.label4.Name = "label4";
    this.label4.Size = new Size(42, 13);
    this.label4.TabIndex = 4;
    this.label4.Text = "Range:";
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.maskedEditRangeTo).Appearance = (AppearanceBase) appearance39;
    ((UltraMaskedEdit) this.maskedEditRangeTo).EditAs = (EditAsType) 5;
    ((UltraMaskedEdit) this.maskedEditRangeTo).InputMask = "999999";
    ((Control) this.maskedEditRangeTo).Location = new Point(155, 76);
    this.maskedEditRangeTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.maskedEditRangeTo).Name = "maskedEditRangeTo";
    ((Control) this.maskedEditRangeTo).Size = new Size(57, 21);
    ((Control) this.maskedEditRangeTo).TabIndex = 7;
    ((UltraControlBase) this.maskedEditRangeTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskedEditRangeTo).UseOsThemes = (DefaultableBoolean) 2;
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.FromArgb(239, 247, 253);
    this.label6.Font = new Font("Tahoma", 12f);
    this.label6.Location = new Point(136, 77);
    this.label6.Name = "label6";
    this.label6.Size = new Size(15, 19);
    this.label6.TabIndex = 6;
    this.label6.Text = "-";
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.FromArgb(239, 247, 253);
    this.label7.Location = new Point(8, 100);
    this.label7.Name = "label7";
    this.label7.Size = new Size(44, 13);
    this.label7.TabIndex = 8;
    this.label7.Text = "Length:";
    ((AppearanceBase) appearance40).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ((UltraMaskedEdit) this.maskedEditTotalLength).Appearance = (AppearanceBase) appearance40;
    ((UltraMaskedEdit) this.maskedEditTotalLength).DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    ((UltraMaskedEdit) this.maskedEditTotalLength).EditAs = (EditAsType) 5;
    ((UltraMaskedEdit) this.maskedEditTotalLength).InputMask = "99";
    ((Control) this.maskedEditTotalLength).Location = new Point(81, 100);
    ((UltraMaskedEdit) this.maskedEditTotalLength).MaxValue = (object) 25;
    this.maskedEditTotalLength.MGAStyle = (MGAStyles) 2;
    ((UltraMaskedEdit) this.maskedEditTotalLength).MinValue = (object) 1;
    ((Control) this.maskedEditTotalLength).Name = "maskedEditTotalLength";
    ((Control) this.maskedEditTotalLength).Size = new Size(33, 21);
    ((Control) this.maskedEditTotalLength).TabIndex = 9;
    ((Control) this.maskedEditTotalLength).Text = "25";
    ((UltraControlBase) this.maskedEditTotalLength).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.maskedEditTotalLength).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraMaskedEdit) this.maskedEditTotalLength).ValueChanged += new EventHandler(this.maskedEditTotalLength_ValueChanged);
    this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.FromArgb(239, 247, 253);
    this.label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.label5.Location = new Point(347, 50);
    this.label5.Name = "label5";
    this.label5.Size = new Size(52, 13);
    this.label5.TabIndex = 13;
    this.label5.Text = "Sample:";
    ((Control) this.textSample).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BackColor2 = Color.White;
    ((AppearanceBase) appearance41).BackGradientStyle = (GradientStyle) 14;
    ((AppearanceBase) appearance41).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance41).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance41).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textSample).Appearance = (AppearanceBase) appearance41;
    ((Control) this.textSample).BackColor = Color.White;
    ((Control) this.textSample).Location = new Point(350, 66);
    this.textSample.MGAStyle = (MGAStyles) 2;
    ((Control) this.textSample).Name = "textSample";
    ((EditorButtonControlBase) this.textSample).ReadOnly = true;
    ((Control) this.textSample).Size = new Size(252, 20);
    ((Control) this.textSample).TabIndex = 14;
    ((UltraControlBase) this.textSample).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textSample).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance42).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance42).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.mgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance42;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.labelSuffix);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textSuffix);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.maskedEditRangeFrom);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.maskedEditRangeTo);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.buttonCancel);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.buttonSave);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.checkManual);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textSample);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label3);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label5);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textRuleName);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label7);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.labelPrefix);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.maskedEditTotalLength);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textPrefix);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label6);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label4);
    ((AppearanceBase) appearance43).ForeColor = Color.Black;
    ((UltraGroupBox) this.mgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance43;
    ((Control) this.mgaGroupBox1).Location = new Point(19, 60);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(621, 151);
    ((Control) this.mgaGroupBox1).TabIndex = 2;
    ((Control) this.mgaGroupBox1).Text = "Claim Numbering Options";
    ((UltraGroupBox) this.mgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    this.labelSuffix.AutoSize = true;
    this.labelSuffix.BackColor = Color.FromArgb(239, 247, 253);
    this.labelSuffix.Location = new Point(8, 124);
    this.labelSuffix.Name = "labelSuffix";
    this.labelSuffix.Size = new Size(39, 13);
    this.labelSuffix.TabIndex = 10;
    this.labelSuffix.Text = "Suffix:";
    ((AppearanceBase) appearance44).BackColor = Color.White;
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textSuffix).Appearance = (AppearanceBase) appearance44;
    ((Control) this.textSuffix).BackColor = Color.White;
    ((Control) this.textSuffix).Location = new Point(81, 124);
    ((TextEditorControlBase) this.textSuffix).MaxLength = 15;
    this.textSuffix.MGAStyle = (MGAStyles) 2;
    ((Control) this.textSuffix).Name = "textSuffix";
    ((Control) this.textSuffix).Size = new Size(131, 20);
    ((Control) this.textSuffix).TabIndex = 11;
    ((UltraControlBase) this.textSuffix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textSuffix).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textSuffix).TextChanged += new EventHandler(this.TextChangedHandler);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance45).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance45).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance45).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance45).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance45).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance45).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance45;
    ((Control) this.buttonCancel).Location = new Point(519, 119);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(83, 25);
    ((Control) this.buttonCancel).TabIndex = 16 /*0x10*/;
    ((Control) this.buttonCancel).Text = "&Clear";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((Control) this.buttonSave).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance46).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance46).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance46).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance46).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance46).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance46;
    ((Control) this.buttonSave).Location = new Point(429, 119);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(84, 25);
    ((Control) this.buttonSave).TabIndex = 15;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "ContextTB";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance47).Image = (object) Resources.Edit;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance47;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Edit Claim Number Rule";
    ((AppearanceBase) appearance48).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance48;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Delete Claim Number Rule";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "CONTEXTMENU";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) popupMenuTool
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left).Location = new Point(0, 23);
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left).Name = "_ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left";
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left).Size = new Size(0, 536);
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right).Location = new Point(658, 23);
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right).Name = "_ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right";
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right).Size = new Size(0, 536);
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top).Name = "_ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top";
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top).Size = new Size(658, 23);
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom).Location = new Point(0, 559);
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom).Name = "_ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom";
    ((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom).Size = new Size(658, 0);
    this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Controls.Add((Control) this.groupDefinedRules);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._ClaimNumberingAutomationUI_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ClaimNumberingAutomationUI);
    this.Size = new Size(658, 559);
    ((ISupportInitialize) this.groupDefinedRules).EndInit();
    ((Control) this.groupDefinedRules).ResumeLayout(false);
    ((ISupportInitialize) this.gridCurrentRules).EndInit();
    this.dsNumberingRules1.EndInit();
    ((ISupportInitialize) this.textRuleName).EndInit();
    ((ISupportInitialize) this.checkManual).EndInit();
    ((ISupportInitialize) this.textPrefix).EndInit();
    ((ISupportInitialize) this.maskedEditRangeFrom).EndInit();
    ((ISupportInitialize) this.maskedEditRangeTo).EndInit();
    ((ISupportInitialize) this.maskedEditTotalLength).EndInit();
    ((ISupportInitialize) this.textSample).EndInit();
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    ((Control) this.mgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.textSuffix).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
