// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmSelectState
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class frmSelectState : Form
{
  private IContainer components;
  private Label Label1;
  private MGASimpleComboBox cboStates;
  private ErrorProvider err;
  private bool _saved;

  public frmSelectState()
  {
    this.Load += new EventHandler(this.frmSelectState_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    this.cboStates = new MGASimpleComboBox();
    this.btnCancel = new MGAButton();
    this.err = new ErrorProvider();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboStates).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(294, 17);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select the state you are interested in working with:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(208 /*0xD0*/, 72);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 1;
    this.cboStates.BorderStyle = (UIElementBorderStyle) 4;
    this.cboStates.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.cboStates).DisplayMember = "";
    this.cboStates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStates).Location = new Point(8, 32 /*0x20*/);
    this.cboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStates).Name = "cboStates";
    ((Control) this.cboStates).Size = new Size(288, 20);
    ((Control) this.cboStates).TabIndex = 2;
    ((UltraDropDownBase) this.cboStates).ValueMember = "";
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(256 /*0x0100*/, 72);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).TabIndex = 3;
    this.err.ContainerControl = (ContainerControl) this;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(304, 120);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.cboStates);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectState);
    this.Text = "State Selection";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboStates).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  public bool Saved => this._saved;

  public string StateID => this.cboStates.Value.ToString();

  public string State => this.cboStates.Text;

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.cboStates.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboStates, "Please select a state.");
    }
    else
    {
      this._saved = true;
      this.Close();
    }
  }

  private void frmSelectState_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    DataTable dataTable1 = new DataTable()
    {
      Columns = {
        {
          "StateID",
          typeof (string)
        },
        {
          "State",
          typeof (string)
        }
      }
    };
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY StateID");
    MGASimpleComboBox cboStates = this.cboStates;
    ((UltraGridBase) cboStates).DataSource = (object) dataTable2;
    ((UltraDropDownBase) cboStates).DisplayMember = "State";
    ((UltraDropDownBase) cboStates).ValueMember = "StateID";
  }
}
