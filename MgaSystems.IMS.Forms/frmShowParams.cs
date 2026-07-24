// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmShowParams
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class frmShowParams : Form
{
  private IContainer components;
  private ArrayList _typedParamList;

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
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.OK_Button = new Button();
    this.Cancel_Button = new Button();
    this.Panel1 = new Panel();
    this.Button1 = new Button();
    this.txtDisplayParams = new TextBox();
    this.TableLayoutPanel1.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    this.TableLayoutPanel1.Location = new Point(277, 7);
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 1;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Size = new Size(146, 29);
    this.TableLayoutPanel1.TabIndex = 0;
    this.OK_Button.Anchor = AnchorStyles.None;
    this.OK_Button.Location = new Point(3, 3);
    this.OK_Button.Name = "OK_Button";
    this.OK_Button.Size = new Size(67, 23);
    this.OK_Button.TabIndex = 0;
    this.OK_Button.Text = "OK";
    this.Cancel_Button.Anchor = AnchorStyles.None;
    this.Cancel_Button.DialogResult = DialogResult.Cancel;
    this.Cancel_Button.Location = new Point(76, 3);
    this.Cancel_Button.Name = "Cancel_Button";
    this.Cancel_Button.Size = new Size(67, 23);
    this.Cancel_Button.TabIndex = 1;
    this.Cancel_Button.Text = "Cancel";
    this.Panel1.Controls.Add((Control) this.Button1);
    this.Panel1.Controls.Add((Control) this.TableLayoutPanel1);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 276);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(435, 39);
    this.Panel1.TabIndex = 1;
    this.Button1.Location = new Point(12, 10);
    this.Button1.Name = "Button1";
    this.Button1.Size = new Size(75, 23);
    this.Button1.TabIndex = 1;
    this.Button1.Text = "Copy";
    this.Button1.UseVisualStyleBackColor = true;
    this.txtDisplayParams.Dock = DockStyle.Fill;
    this.txtDisplayParams.Location = new Point(0, 0);
    this.txtDisplayParams.Multiline = true;
    this.txtDisplayParams.Name = "txtDisplayParams";
    this.txtDisplayParams.Size = new Size(435, 276);
    this.txtDisplayParams.TabIndex = 2;
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    this.ClientSize = new Size(435, 315);
    this.Controls.Add((Control) this.txtDisplayParams);
    this.Controls.Add((Control) this.Panel1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmShowParams);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Constructor Parameters";
    this.TableLayoutPanel1.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("TableLayoutPanel1")]
  internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button OK_Button
  {
    get => this._OK_Button;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
      Button okButton1 = this._OK_Button;
      if (okButton1 != null)
        okButton1.Click -= eventHandler;
      this._OK_Button = value;
      Button okButton2 = this._OK_Button;
      if (okButton2 == null)
        return;
      okButton2.Click += eventHandler;
    }
  }

  internal virtual Button Cancel_Button
  {
    get => this._Cancel_Button;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
      Button cancelButton1 = this._Cancel_Button;
      if (cancelButton1 != null)
        cancelButton1.Click -= eventHandler;
      this._Cancel_Button = value;
      Button cancelButton2 = this._Cancel_Button;
      if (cancelButton2 == null)
        return;
      cancelButton2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button Button1
  {
    get => this._Button1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      Button button1_1 = this._Button1;
      if (button1_1 != null)
        button1_1.Click -= eventHandler;
      this._Button1 = value;
      Button button1_2 = this._Button1;
      if (button1_2 == null)
        return;
      button1_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtDisplayParams")]
  internal virtual TextBox txtDisplayParams { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmShowParams(ArrayList TypedParamList)
  {
    this.Load += new EventHandler(this.frmShowParams_Load);
    this.InitializeComponent();
    this._typedParamList = TypedParamList;
  }

  private void OK_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void Cancel_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void frmShowParams_Load(object sender, EventArgs e)
  {
    string str = "";
    int num = 0;
    try
    {
      foreach (object typedParam in this._typedParamList)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(typedParam);
        if (Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
          str = $"{str}Parameter[{num.ToString()}] = \r\n";
        else
          str = $"{str}Parameter[{num.ToString()}] = {objectValue.ToString()}\r\n";
        ++num;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.txtDisplayParams.Text = str;
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    this.txtDisplayParams.SelectAll();
    this.txtDisplayParams.Copy();
  }
}
