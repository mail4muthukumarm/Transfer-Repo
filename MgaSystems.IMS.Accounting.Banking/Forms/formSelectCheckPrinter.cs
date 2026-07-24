// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.formSelectCheckPrinter
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[DesignerGenerated]
public class formSelectCheckPrinter : Form
{
  private IContainer components;
  private dsCheckPrinterSettings ds;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formSelectCheckPrinter));
    Appearance appearance3 = new Appearance();
    this.Label1 = new Label();
    this.comboPrinterSettings = new MGASimpleComboBox();
    this.checkSaveSettings = new MGACheckBox();
    this.buttonCancel = new MGAButton();
    this.buttonSelect = new MGAButton();
    ((ISupportInitialize) this.comboPrinterSettings).BeginInit();
    ((ISupportInitialize) this.checkSaveSettings).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSelect).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 12);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(75, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Check Printer:";
    this.comboPrinterSettings.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPrinterSettings.CharacterCasing = CharacterCasing.Normal;
    this.comboPrinterSettings.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboPrinterSettings.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPrinterSettings).Location = new Point(89, 12);
    this.comboPrinterSettings.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPrinterSettings).Name = "comboPrinterSettings";
    ((Control) this.comboPrinterSettings).Size = new Size(298, 21);
    ((Control) this.comboPrinterSettings).TabIndex = 1;
    ((UltraControlBase) this.comboPrinterSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPrinterSettings).UseOsThemes = (DefaultableBoolean) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkSaveSettings).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.checkSaveSettings).Checked = true;
    ((UltraToggleEditorBase) this.checkSaveSettings).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.checkSaveSettings).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkSaveSettings).Location = new Point(89, 39);
    ((Control) this.checkSaveSettings).Name = "checkSaveSettings";
    ((Control) this.checkSaveSettings).Size = new Size(157, 20);
    ((Control) this.checkSaveSettings).TabIndex = 2;
    ((UltraToggleEditorBase) this.checkSaveSettings).Text = "Save My Settings";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(300, 65);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(87, 26);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((ControlBase) this.buttonCancel).Text = "&Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 1;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSelect).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSelect).Location = new Point(207, 65);
    ((Control) this.buttonSelect).Name = "buttonSelect";
    ((Control) this.buttonSelect).Size = new Size(87, 26);
    ((Control) this.buttonSelect).TabIndex = 4;
    ((ControlBase) this.buttonSelect).Text = "&Select";
    this.buttonSelect.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(398, 103);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonSelect);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.checkSaveSettings);
    this.Controls.Add((Control) this.comboPrinterSettings);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (formSelectCheckPrinter);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Check Printer";
    ((ISupportInitialize) this.comboPrinterSettings).EndInit();
    ((ISupportInitialize) this.checkSaveSettings).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSelect).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboPrinterSettings")]
  internal virtual MGASimpleComboBox comboPrinterSettings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkSaveSettings")]
  internal virtual MGACheckBox checkSaveSettings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonSelect
  {
    get => this._buttonSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSelect_Click);
      MGAButton buttonSelect1 = this._buttonSelect;
      if (buttonSelect1 != null)
        ((Control) buttonSelect1).Click -= eventHandler;
      this._buttonSelect = value;
      MGAButton buttonSelect2 = this._buttonSelect;
      if (buttonSelect2 == null)
        return;
      ((Control) buttonSelect2).Click += eventHandler;
    }
  }

  public formSelectCheckPrinter(ref dsCheckPrinterSettings checkPrinterDataset)
  {
    this.InitializeComponent();
    this.ds = checkPrinterDataset;
    this.BindDropdown();
  }

  private void BindDropdown()
  {
    ((UltraGridBase) this.comboPrinterSettings).DataSource = (object) this.ds.PrinterSettings;
    ((UltraDropDownBase) this.comboPrinterSettings).DisplayMember = "PrinterFriendlyName";
    ((UltraDropDownBase) this.comboPrinterSettings).ValueMember = "PrinterId";
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  public string CheckPrinterName
  {
    get
    {
      return ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells[nameof (CheckPrinterName)].Value.ToString();
    }
  }

  public string CheckPrinterSettings
  {
    get
    {
      return ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells[nameof (CheckPrinterSettings)].Value.ToString();
    }
  }

  public string CheckDetailPrinterName
  {
    get
    {
      return Operators.CompareString(((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["CheckDetailName"].Value.ToString(), string.Empty, false) != 0 ? ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["CheckDetailName"].Value.ToString() : ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["CheckPrinterName"].Value.ToString();
    }
  }

  public string CheckDetailPrinterSettings
  {
    get
    {
      return Operators.CompareString(((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["CheckDetailName"].Value.ToString(), string.Empty, false) != 0 ? ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["CheckDetailSettings"].Value.ToString() : ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["CheckPrinterSettings"].Value.ToString();
    }
  }

  private bool VerifyForm()
  {
    bool flag;
    if (((UltraDropDownBase) this.comboPrinterSettings).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a printer to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void buttonSelect_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    if (((UltraToggleEditorBase) this.checkSaveSettings).Checked)
      Utility.SaveUserPreference("Accounting.CheckPrinter", ((UltraDropDownBase) this.comboPrinterSettings).SelectedRow.Cells["PrinterID"].Value.ToString(), "System.Int32");
    this.DialogResult = DialogResult.OK;
    this.Close();
  }
}
