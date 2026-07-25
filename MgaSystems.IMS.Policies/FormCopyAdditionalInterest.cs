// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormCopyAdditionalInterest
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.BusinessObjects;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormCopyAdditionalInterest : Form
{
  private IContainer components;
  private Guid _QuoteGuid;
  private string _CopyStr;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance = new Appearance();
    this.numControlNo = new MGANumericEditor();
    this.Label1 = new Label();
    this.btnCopy = new UltraButton();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.numControlNo).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numControlNo).Appearance = (AppearanceBase) appearance;
    ((UltraNumericEditorBase) this.numControlNo).FormatString = "";
    ((Control) this.numControlNo).Location = new Point(71, 37);
    this.numControlNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.numControlNo).Name = "numControlNo";
    ((UltraNumericEditor) this.numControlNo).Nullable = true;
    ((Control) this.numControlNo).Size = new Size(80 /*0x50*/, 19);
    ((Control) this.numControlNo).TabIndex = 6;
    ((UltraWinEditorMaskedControlBase) this.numControlNo).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numControlNo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 40);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(53, 13);
    this.Label1.TabIndex = 7;
    this.Label1.Text = "Control #:";
    ((Control) this.btnCopy).Location = new Point(71, 89);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((Control) this.btnCopy).Size = new Size(75, 23);
    ((Control) this.btnCopy).TabIndex = 8;
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(201, 124);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.numControlNo);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormCopyAdditionalInterest);
    this.Text = "Copy Additional Interest";
    ((ISupportInitialize) this.numControlNo).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton btnCopy
  {
    get => this._btnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopy_Click);
      UltraButton btnCopy1 = this._btnCopy;
      if (btnCopy1 != null)
        ((Control) btnCopy1).Click -= eventHandler;
      this._btnCopy = value;
      UltraButton btnCopy2 = this._btnCopy;
      if (btnCopy2 == null)
        return;
      ((Control) btnCopy2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("numControlNo")]
  protected virtual MGANumericEditor numControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCopyAdditionalInterest(Guid QuoteGuid, string CopyStr)
  {
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
    this._CopyStr = CopyStr;
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    this.err.SetError((Control) this.numControlNo, string.Empty);
    if (((UltraNumericEditor) this.numControlNo).Value == null || ((UltraNumericEditor) this.numControlNo).Value == DBNull.Value)
    {
      this.err.SetError((Control) this.numControlNo, "Please enter a number");
    }
    else
    {
      int integer = Conversions.ToInteger(DefaultDatabase.ExecuteScalar("CopyAdditionalInterests", new object[6]
      {
        (object) "@QuoteGuid",
        (object) this._QuoteGuid,
        (object) "@ControlNo",
        ((UltraNumericEditor) this.numControlNo).Value,
        (object) "@InterestString",
        (object) this._CopyStr
      }));
      if (integer == -1)
      {
        this.err.SetError((Control) this.numControlNo, "Number does not exist");
      }
      else
      {
        CurrentUser.Instance.LogAction($"{integer.ToString()} interest(s) successfully copied to control #{((UltraNumericEditor) this.numControlNo).Value.ToString()}", this._QuoteGuid);
        Guid guid = (Guid) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @cn ORDER BY QuoteID DESC", new object[2]
        {
          (object) "@cn",
          ((UltraNumericEditor) this.numControlNo).Value
        });
        Quote quote = new Quote(this._QuoteGuid);
        CurrentUser.Instance.LogAction($"{integer.ToString()} interest(s) successfully copied from control #{quote.ControlNo.ToString()}", guid);
        int num = (int) MessageBox.Show($"{integer.ToString()} interest(s) successfully copied to control # {((UltraNumericEditor) this.numControlNo).Value.ToString()}", "Interest Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }
}
