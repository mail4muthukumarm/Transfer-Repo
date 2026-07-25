// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.frmAddWarrantyForm
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

public sealed class frmAddWarrantyForm : Form
{
  private IContainer components;
  private Label Label1;
  private MGASimpleComboBox cboForms;
  private dsAddWarrantyForm ds;
  private bool _saved;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.cboForms = new MGASimpleComboBox();
    this.ds = new dsAddWarrantyForm();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboForms).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(328, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select a form you would like to associate with this warranty:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(272, 72);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 1;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(320, 72);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 2;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboForms).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboForms).CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboForms).DataSource = (object) this.ds.tblPolicyForms;
    ((UltraDropDownBase) this.cboForms).DisplayMember = "FormName";
    ((UltraCombo) this.cboForms).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboForms).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboForms).Location = new Point(16 /*0x10*/, 40);
    this.cboForms.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboForms).Name = "cboForms";
    ((Control) this.cboForms).Size = new Size(344, 21);
    ((Control) this.cboForms).TabIndex = 3;
    ((UltraControlBase) this.cboForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboForms).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboForms).ValueMember = "FormID";
    this.ds.DataSetName = "dsAddWarrantyForm";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(376, 128 /*0x80*/);
    this.Controls.Add((Control) this.cboForms);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAddWarrantyForm);
    this.Text = "Warranties - Add Associated Form";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboForms).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAddWarrantyForm()
  {
    this.Load += new EventHandler(this.frmAddWarrantyForm_Load);
    this.InitializeComponent();
  }

  public bool Saved => this._saved;

  public int FormID => Conversions.ToInteger(((UltraCombo) this.cboForms).Value);

  public string FormName => ((UltraCombo) this.cboForms).Text;

  private void frmAddWarrantyForm_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblPolicyForms"
    }, CommandType.Text, "SELECT FormID, FormName FROM tblPolicyForms ORDER BY FormName");
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._saved = true;
    this.Close();
  }
}
