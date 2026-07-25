// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.SelectRewritePolicyType
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class SelectRewritePolicyType : MGABaseForm
{
  private IContainer components;
  private Label Label1;
  private MGASimpleComboBox comboPolicyTypes;
  private ErrorProvider err;
  private bool _saved;
  private int _policyTypeID;

  public SelectRewritePolicyType()
  {
    ((Form) this).Load += new EventHandler(this.SelectRewritePolicyType_Load);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected virtual void Dispose(bool disposing)
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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SelectRewritePolicyType));
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.comboPolicyTypes = new MGASimpleComboBox();
    this.buttonOk = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.comboPolicyTypes).BeginInit();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((Control) this).SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(295, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select the policy type you would like for this re-write:";
    ((UltraCombo) this.comboPolicyTypes).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboPolicyTypes).CharacterCasing = CharacterCasing.Normal;
    ((UltraCombo) this.comboPolicyTypes).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPolicyTypes).Location = new Point(12, 35);
    this.comboPolicyTypes.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboPolicyTypes).Name = "comboPolicyTypes";
    ((Control) this.comboPolicyTypes).Size = new Size(305, 21);
    ((Control) this.comboPolicyTypes).TabIndex = 1;
    ((UltraControlBase) this.comboPolicyTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPolicyTypes).UseOsThemes = (DefaultableBoolean) 2;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 3;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonOk).Location = new Point(224 /*0xE0*/, 71);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((ControlBase) this.buttonOk).Padding = new Size(5, 0);
    ((Control) this.buttonOk).Size = new Size(93, 26);
    ((Control) this.buttonOk).TabIndex = 2;
    ((ControlBase) this.buttonOk).Text = "Continue";
    this.buttonOk.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    appearance2.ImageHAlign = (HAlign) 3;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(125, 71);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((ControlBase) this.buttonCancel).Padding = new Size(5, 0);
    ((Control) this.buttonCancel).Size = new Size(93, 26);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Form) this).AcceptButton = (IButtonControl) this.buttonOk;
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).CancelButton = (IButtonControl) this.buttonCancel;
    ((Form) this).ClientSize = new Size(348, 109);
    ((Control) this).Controls.Add((Control) this.buttonCancel);
    ((Control) this).Controls.Add((Control) this.buttonOk);
    ((Control) this).Controls.Add((Control) this.comboPolicyTypes);
    ((Control) this).Controls.Add((Control) this.Label1);
    ((Control) this).ForeColor = Color.Black;
    ((Form) this).FormBorderStyle = FormBorderStyle.FixedToolWindow;
    ((Form) this).MaximizeBox = false;
    ((Form) this).MinimizeBox = false;
    ((Control) this).Name = nameof (SelectRewritePolicyType);
    ((Form) this).StartPosition = FormStartPosition.CenterScreen;
    ((Form) this).Text = "Select Policy Type";
    ((ISupportInitialize) this.comboPolicyTypes).EndInit();
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((Control) this).ResumeLayout(false);
    ((Control) this).PerformLayout();
  }

  private virtual MGAButton buttonOk
  {
    get => this._buttonOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonOk_Click);
      MGAButton buttonOk1 = this._buttonOk;
      if (buttonOk1 != null)
        ((Control) buttonOk1).Click -= eventHandler;
      this._buttonOk = value;
      MGAButton buttonOk2 = this._buttonOk;
      if (buttonOk2 == null)
        return;
      ((Control) buttonOk2).Click += eventHandler;
    }
  }

  private virtual MGAButton buttonCancel
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

  public bool Saved => this._saved;

  public int PolicyTypeID => this._policyTypeID;

  public bool IsValid()
  {
    bool flag;
    if (((UltraCombo) this.comboPolicyTypes).Value == null)
    {
      this.err.SetError((Control) this.comboPolicyTypes, "Please select a valid value");
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void buttonOk_Click(object sender, EventArgs e)
  {
    if (!this.IsValid())
      return;
    this._saved = true;
    this._policyTypeID = Conversions.ToInteger(((UltraCombo) this.comboPolicyTypes).Value);
    ((Form) this).Close();
  }

  private void SelectRewritePolicyType_Load(object sender, EventArgs e)
  {
    DataTable dataTable = new DataTable("lstPolicyTypes");
    string str = "SELECT PolicyTypeID, Description FROM lstPolicyTypes ORDER BY Description";
    DefaultDatabase.LoadDataTable(dataTable, CommandType.Text, str);
    MGASimpleComboBox comboPolicyTypes = this.comboPolicyTypes;
    ((UltraGridBase) comboPolicyTypes).DataSource = (object) dataTable;
    ((UltraDropDownBase) comboPolicyTypes).DisplayMember = "Description";
    ((UltraDropDownBase) comboPolicyTypes).ValueMember = "PolicyTypeID";
  }

  private void buttonCancel_Click(object sender, EventArgs e) => ((Form) this).Close();
}
