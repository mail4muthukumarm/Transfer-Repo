// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyNumbering.frmPolicyNumberEntry
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyNumbering;

public sealed class frmPolicyNumberEntry : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  private ErrorProvider err;
  private Label lblCompanyLine;
  private bool _isMainPolicyNumberEntry;
  private Guid _companyLineGuid;
  private bool _clickedCancel;
  private bool _disallowPolicyNumberCharacters;
  private int _policyNumberID;
  private bool _hasMask;
  private string _mask;
  private bool _validMask;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGATextBox txtPolicyNum
  {
    get => this._txtPolicyNum;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPolicyNum_KeyDown);
      MGATextBox txtPolicyNum1 = this._txtPolicyNum;
      if (txtPolicyNum1 != null)
        ((Control) txtPolicyNum1).KeyDown -= keyEventHandler;
      this._txtPolicyNum = value;
      MGATextBox txtPolicyNum2 = this._txtPolicyNum;
      if (txtPolicyNum2 == null)
        return;
      ((Control) txtPolicyNum2).KeyDown += keyEventHandler;
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

  [field: AccessedThroughProperty("lblEntryText")]
  private virtual Label lblEntryText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblManualMask")]
  private virtual Label lblManualMask { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDirections")]
  private virtual Label lblDirections { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyNumberEntry));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.PictureBox1 = new PictureBox();
    this.txtPolicyNum = new MGATextBox();
    this.lblEntryText = new Label();
    this.err = new ErrorProvider(this.components);
    this.btnSave = new MGAButton();
    this.lblCompanyLine = new Label();
    this.btnCancel = new MGAButton();
    this.lblManualMask = new Label();
    this.lblDirections = new Label();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.txtPolicyNum).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(7, 14);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyNum).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtPolicyNum).BackColor = Color.White;
    ((Control) this.txtPolicyNum).Location = new Point(70, 70);
    this.txtPolicyNum.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolicyNum).Name = "txtPolicyNum";
    ((Control) this.txtPolicyNum).Size = new Size(205, 20);
    ((Control) this.txtPolicyNum).TabIndex = 2;
    ((UltraControlBase) this.txtPolicyNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyNum).UseOsThemes = (DefaultableBoolean) 2;
    this.lblEntryText.AutoSize = true;
    this.lblEntryText.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblEntryText.Location = new Point(70, 14);
    this.lblEntryText.Name = "lblEntryText";
    this.lblEntryText.Size = new Size(222, 17);
    this.lblEntryText.TabIndex = 4;
    this.lblEntryText.Text = "Please enter the policy number for:";
    this.err.ContainerControl = (ContainerControl) this;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(269, 144 /*0x90*/);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 5;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lblCompanyLine.AutoSize = true;
    this.lblCompanyLine.Font = new Font("Tahoma", 8f);
    this.lblCompanyLine.Location = new Point(70, 42);
    this.lblCompanyLine.Name = "lblCompanyLine";
    this.lblCompanyLine.Size = new Size(128 /*0x80*/, 13);
    this.lblCompanyLine.TabIndex = 6;
    this.lblCompanyLine.Text = "(company line goes here)";
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(318, 144 /*0x90*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(42, 42);
    ((Control) this.btnCancel).TabIndex = 7;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.lblManualMask.AutoSize = true;
    this.lblManualMask.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblManualMask.Location = new Point(67, 105);
    this.lblManualMask.Name = "lblManualMask";
    this.lblManualMask.Size = new Size(89, 17);
    this.lblManualMask.TabIndex = 8;
    this.lblManualMask.Text = "Manual Mask:";
    this.lblDirections.AutoSize = true;
    this.lblDirections.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDirections.Location = new Point(67, 131);
    this.lblDirections.Name = "lblDirections";
    this.lblDirections.Size = new Size(165, 17);
    this.lblDirections.TabIndex = 9;
    this.lblDirections.Text = "(X - Letters. 9 - Numbers)";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(372, 198);
    this.Controls.Add((Control) this.lblDirections);
    this.Controls.Add((Control) this.lblManualMask);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.lblCompanyLine);
    this.Controls.Add((Control) this.lblEntryText);
    this.Controls.Add((Control) this.txtPolicyNum);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPolicyNumberEntry);
    this.ShowInTaskbar = false;
    this.Text = "Manual Policy Number Entry";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.txtPolicyNum).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public bool ClickedCancel => this._clickedCancel;

  public string PolicyNumber
  {
    get => ((TextEditorControlBase) this.txtPolicyNum).Text.Trim();
    set => ((TextEditorControlBase) this.txtPolicyNum).Text = value;
  }

  public bool IsMainPolicyNumberEntry
  {
    get => this._isMainPolicyNumberEntry;
    set => this._isMainPolicyNumberEntry = value;
  }

  public int PolicyNumberID
  {
    get => this._policyNumberID;
    set => this._policyNumberID = value;
  }

  public bool ValidMask => this._validMask;

  public frmPolicyNumberEntry(Guid CompanyLineGuid)
  {
    this.Load += new EventHandler(this.frmPolicyNumberEntry_Load);
    this.Closing += new CancelEventHandler(this.frmPolicyNumberEntry_Closing);
    this._disallowPolicyNumberCharacters = false;
    this._validMask = true;
    this.InitializeComponent();
    this._companyLineGuid = CompanyLineGuid;
  }

  private void frmPolicyNumberEntry_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    if (this.lblCompanyLine.Right > this.Width)
      this.Width = this.lblCompanyLine.Bounds.Right;
    if (this.IsMainPolicyNumberEntry)
    {
      this.lblCompanyLine.Visible = false;
      this.lblEntryText.Text = "Please enter the main policy number:";
      this.lblEntryText.Top = this.PictureBox1.Top;
    }
    else
      this.lblCompanyLine.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetCompanyLineState(@CLG)", new object[2]
      {
        (object) "@CLG",
        (object) this._companyLineGuid
      });
    this._disallowPolicyNumberCharacters = SystemSettings.KeyExists("DisallowPolicyNumberCharacters") && SystemSettings.GetBoolSetting("DisallowPolicyNumberCharacters");
    if (this.PolicyNumberID != int.MinValue)
    {
      string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select ManualMask from tblPolicyNumberRules with (nolock) where RuleID= @RuleID", new object[2]
      {
        (object) "@RuleID",
        (object) this.PolicyNumberID
      });
      if (!Utility.IsNull((object) str) && str.Replace(" ", string.Empty).Length > 0)
      {
        this._hasMask = true;
        this.lblManualMask.Text = $"{this.lblManualMask.Text}{str}";
        this._mask = str;
      }
    }
    if (this.PolicyNumberID != int.MinValue && this._hasMask)
      return;
    this.lblManualMask.Visible = false;
    this.lblDirections.Visible = false;
  }

  private void txtPolicyNum_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._clickedCancel = true;
    this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    bool flag = true;
    this.err.SetError((Control) this.txtPolicyNum, string.Empty);
    this.err.SetError((Control) this.lblManualMask, string.Empty);
    this._validMask = this.ValidMaskEntry();
    if (!this._validMask)
    {
      flag = false;
      this.err.SetError((Control) this.txtPolicyNum, "Pol # does not follow mask entry.");
    }
    if (((TextEditorControlBase) this.txtPolicyNum).Text.Replace(" ", string.Empty).Length == 0)
    {
      flag = false;
      this.err.SetError((Control) this.txtPolicyNum, "Please enter a policy number, or close the form to cancel.");
    }
    if (flag)
    {
      string str = this.ValidPolicyNumber();
      if (!string.IsNullOrEmpty(str))
      {
        flag = false;
        this.err.SetError((Control) this.txtPolicyNum, str + " is not a valid character.");
      }
    }
    if (!flag)
      return;
    this.Close();
  }

  private void frmPolicyNumberEntry_Closing(object sender, CancelEventArgs e)
  {
    if (((TextEditorControlBase) this.txtPolicyNum).Text.Length != 0)
      return;
    this._clickedCancel = true;
  }

  private string ValidPolicyNumber()
  {
    string str1;
    if (!this._disallowPolicyNumberCharacters)
    {
      str1 = string.Empty;
    }
    else
    {
      string[] strArray = new string[3]{ "/", "\\", "%" };
      int index = 0;
      while (index < strArray.Length)
      {
        string str2 = strArray[index];
        if (((TextEditorControlBase) this.txtPolicyNum).Text.Contains(str2))
        {
          str1 = str2;
          goto label_8;
        }
        checked { ++index; }
      }
      str1 = string.Empty;
    }
label_8:
    return str1;
  }

  private bool ValidMaskEntry()
  {
    bool flag;
    if (!this._hasMask)
    {
      flag = true;
    }
    else
    {
      int length1 = this._mask.Length;
      int length2 = ((TextEditorControlBase) this.txtPolicyNum).Text.Length;
      if (length1 != length2)
      {
        int num = (int) MessageBox.Show($"Pol # length of {length2} does not match the recommended mask length of {length1}", "Length Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else
      {
        int num1 = length1 - 1;
        for (int index = 0; index <= num1; ++index)
        {
          char ch = this._mask[index];
          string upper1 = ch.ToString().ToUpper();
          ch = ((TextEditorControlBase) this.txtPolicyNum).Text[index];
          string upper2 = ch.ToString().ToUpper();
          if (!upper1.Equals(upper2))
          {
            ch = this._mask[index];
            if (ch.ToString().ToUpper().Equals("X") && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtPolicyNum).Text[index]))
            {
              int num2 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' expects non-numeric pol # value instead of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag = false;
              goto label_30;
            }
            ch = this._mask[index];
            if (ch.ToString().ToUpper().Equals("9") && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtPolicyNum).Text[index]))
            {
              int num3 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' expects numeric pol # value instead of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag = false;
              goto label_30;
            }
            if (!Versioned.IsNumeric((object) this._mask[index]) && Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtPolicyNum).Text[index]))
            {
              int num4 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' does not match pol # value of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag = false;
              goto label_30;
            }
            ch = this._mask[index];
            if (ch.Equals('-'))
            {
              ch = ((TextEditorControlBase) this.txtPolicyNum).Text[index];
              if (!ch.Equals('-'))
              {
                int num5 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' does not match pol # value of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
                goto label_30;
              }
            }
            ch = this._mask[index];
            if (ch.Equals('-'))
            {
              ch = ((TextEditorControlBase) this.txtPolicyNum).Text[index];
              if (!ch.Equals('-'))
              {
                int num6 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' does not match pol # value of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
                goto label_30;
              }
            }
            ch = this._mask[index];
            if (ch.Equals(' '))
            {
              ch = ((TextEditorControlBase) this.txtPolicyNum).Text[index];
              if (!ch.Equals(' '))
              {
                int num7 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}'  does not match pol # value of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
                goto label_30;
              }
            }
            ch = ((TextEditorControlBase) this.txtPolicyNum).Text[index];
            if (ch.Equals('-'))
            {
              ch = this._mask[index];
              if (!ch.Equals('-'))
              {
                int num8 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' does not match pol # value of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
                goto label_30;
              }
            }
            ch = ((TextEditorControlBase) this.txtPolicyNum).Text[index];
            if (ch.Equals(' '))
            {
              ch = this._mask[index];
              if (!ch.Equals(' '))
              {
                int num9 = (int) MessageBox.Show($"Mask value of '{this._mask[index]}' does not match pol # value of '{((TextEditorControlBase) this.txtPolicyNum).Text[index]}'", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = false;
                goto label_30;
              }
            }
          }
        }
        this._validMask = true;
        flag = true;
      }
    }
label_30:
    return flag;
  }
}
