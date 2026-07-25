// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmControlNumberJump
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmControlNumberJump : Form
{
  private IContainer components;
  private Label Label1;
  private UltraPictureBox UltraPictureBox1;

  public frmControlNumberJump() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGATextBox txtControlNo
  {
    get => this._txtControlNo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtControlNo_KeyDown);
      MGATextBox txtControlNo1 = this._txtControlNo;
      if (txtControlNo1 != null)
        ((Control) txtControlNo1).KeyDown -= keyEventHandler;
      this._txtControlNo = value;
      MGATextBox txtControlNo2 = this._txtControlNo;
      if (txtControlNo2 == null)
        return;
      ((Control) txtControlNo2).KeyDown += keyEventHandler;
    }
  }

  private virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmControlNumberJump));
    this.Label1 = new Label();
    this.txtControlNo = new MGATextBox();
    this.btnGo = new MGAButton();
    this.UltraPictureBox1 = new UltraPictureBox();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(112 /*0x70*/, 14);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(164, 16 /*0x10*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please enter the control number:";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtControlNo).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtControlNo).Location = new Point(136, 40);
    ((Control) this.txtControlNo).Name = "txtControlNo";
    ((Control) this.txtControlNo).TabIndex = 2;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnGo).Location = new Point(248, 40);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(48 /*0x30*/, 20);
    ((Control) this.btnGo).TabIndex = 3;
    ((ControlBase) this.btnGo).Text = "Go";
    this.UltraPictureBox1.BorderShadowColor = Color.Empty;
    this.UltraPictureBox1.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("UltraPictureBox1.Image"));
    ((Control) this.UltraPictureBox1).Location = new Point(-16, -40);
    ((Control) this.UltraPictureBox1).Name = "UltraPictureBox1";
    ((Control) this.UltraPictureBox1).Size = new Size(150, 150);
    ((UltraControlBase) this.UltraPictureBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraPictureBox1).TabIndex = 4;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(314, 77);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.txtControlNo);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.UltraPictureBox1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmControlNumberJump);
    this.Text = "Control Number Jump";
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    this.ResumeLayout(false);
  }

  public static void LaunchAppropriateQuoteForm(int controlNum)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN EXISTS (SELECT * FROM tblQuotes WHERE ControlNo=@CN) THEN 1 ELSE 0 END", new object[2]
      {
        (object) "@CN",
        (object) controlNum
      }));
      bool boolean;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        boolean = Conversions.ToBoolean(Interaction.IIf(objectValue.ToString().Equals("1"), (object) true, (object) false));
      if (!boolean)
      {
        Cursor.Current = MgaCursors.Default;
        int num = (int) MessageBox.Show("This control number does not exist.", "Control # Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        Quote quote = Quote.FromControlNo(controlNum);
        if (!quote.IsQuickQuote)
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT UserGuid FROM tblUserCompanyViewingRights WHERE CompanyLocationGuid = @cLoc AND UserGuid = @uGuid", new object[4]
          {
            (object) "@cLoc",
            (object) quote.CompanyLocationGuid,
            (object) "@uGuid",
            (object) CurrentUser.Instance.UserGUID
          })))))
          {
            Cursor.Current = MgaCursors.Default;
            return;
          }
        }
        if (quote.IsQuickQuote)
          FormSettings.ShowForm(typeof (frmQuoteEdit), new object[2]
          {
            (object) quote.QuoteGuid,
            (object) quote.SubmissionGroupGuid
          });
        else
          FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
          {
            (object) controlNum
          });
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void btnGo_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtControlNo).Text))
      return;
    frmControlNumberJump.LaunchAppropriateQuoteForm(Conversions.ToInteger(((TextEditorControlBase) this.txtControlNo).Text));
    this.Close();
  }

  private void txtControlNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Return)
    {
      this.btnGo_Click(RuntimeHelpers.GetObjectValue(sender), EventArgs.Empty);
    }
    else
    {
      if (e.KeyCode != Keys.Escape)
        return;
      this.Close();
    }
  }
}
