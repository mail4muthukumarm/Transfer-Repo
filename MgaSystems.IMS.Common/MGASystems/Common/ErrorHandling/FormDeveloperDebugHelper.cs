// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ErrorHandling.FormDeveloperDebugHelper
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.ErrorHandling;

public class FormDeveloperDebugHelper : Form
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader1")]
  internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader2")]
  internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ListView lstPrimary
  {
    get => this._lstPrimary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListView_SelectedIndexChanged);
      ListView lstPrimary1 = this._lstPrimary;
      if (lstPrimary1 != null)
        lstPrimary1.SelectedIndexChanged -= eventHandler;
      this._lstPrimary = value;
      ListView lstPrimary2 = this._lstPrimary;
      if (lstPrimary2 == null)
        return;
      lstPrimary2.SelectedIndexChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ColumnHeader3")]
  internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ColumnHeader4")]
  internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstInner")]
  internal virtual ListView lstInner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDetail")]
  internal virtual MGATextBox txtDetail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFusionLog")]
  internal virtual MGATextBox txtFusionLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.lstPrimary = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.ColumnHeader2 = new ColumnHeader();
    this.lstInner = new ListView();
    this.ColumnHeader3 = new ColumnHeader();
    this.ColumnHeader4 = new ColumnHeader();
    this.Label2 = new Label();
    this.txtDetail = new MGATextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.txtFusionLog = new MGATextBox();
    ((ISupportInitialize) this.txtDetail).BeginInit();
    ((ISupportInitialize) this.txtFusionLog).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 14f);
    this.Label1.Location = new Point(10, 15);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(160 /*0xA0*/, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Primary Exception";
    this.lstPrimary.BackColor = Color.White;
    this.lstPrimary.BorderStyle = BorderStyle.FixedSingle;
    this.lstPrimary.CausesValidation = false;
    this.lstPrimary.Columns.AddRange(new ColumnHeader[2]
    {
      this.ColumnHeader1,
      this.ColumnHeader2
    });
    this.lstPrimary.ForeColor = Color.Black;
    this.lstPrimary.FullRowSelect = true;
    this.lstPrimary.GridLines = true;
    this.lstPrimary.HeaderStyle = ColumnHeaderStyle.Nonclickable;
    this.lstPrimary.Location = new Point(10, 55);
    this.lstPrimary.Name = "lstPrimary";
    this.lstPrimary.Size = new Size(717, 80 /*0x50*/);
    this.lstPrimary.TabIndex = 2;
    this.lstPrimary.UseCompatibleStateImageBehavior = false;
    this.lstPrimary.View = View.Details;
    this.ColumnHeader1.Text = "Property";
    this.ColumnHeader1.Width = 89;
    this.ColumnHeader2.Text = "Value";
    this.ColumnHeader2.Width = 425;
    this.lstInner.BackColor = Color.White;
    this.lstInner.BorderStyle = BorderStyle.FixedSingle;
    this.lstInner.CausesValidation = false;
    this.lstInner.Columns.AddRange(new ColumnHeader[2]
    {
      this.ColumnHeader3,
      this.ColumnHeader4
    });
    this.lstInner.ForeColor = Color.Black;
    this.lstInner.FullRowSelect = true;
    this.lstInner.GridLines = true;
    this.lstInner.HeaderStyle = ColumnHeaderStyle.Nonclickable;
    this.lstInner.Location = new Point(10, 175);
    this.lstInner.Name = "lstInner";
    this.lstInner.Size = new Size(717, 80 /*0x50*/);
    this.lstInner.TabIndex = 4;
    this.lstInner.UseCompatibleStateImageBehavior = false;
    this.lstInner.View = View.Details;
    this.ColumnHeader3.Text = "Property";
    this.ColumnHeader3.Width = 89;
    this.ColumnHeader4.Text = "Value";
    this.ColumnHeader4.Width = 425;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Tahoma", 14f);
    this.Label2.Location = new Point(10, 145);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(143, 23);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Inner Exception";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDetail).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtDetail).BackColor = Color.White;
    ((Control) this.txtDetail).CausesValidation = false;
    ((Control) this.txtDetail).Location = new Point(10, 295);
    this.txtDetail.Multiline = true;
    ((Control) this.txtDetail).Name = "txtDetail";
    ((Control) this.txtDetail).Size = new Size(717, 115);
    ((Control) this.txtDetail).TabIndex = 5;
    ((UltraControlBase) this.txtDetail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDetail).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Tahoma", 14f);
    this.Label3.Location = new Point(10, 265);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(57, 23);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Detail";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 14f);
    this.Label4.Location = new Point(10, 420);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(100, 23);
    this.Label4.TabIndex = 8;
    this.Label4.Text = "Fusion Log";
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFusionLog).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtFusionLog).BackColor = Color.White;
    ((Control) this.txtFusionLog).CausesValidation = false;
    ((Control) this.txtFusionLog).Location = new Point(10, 450);
    this.txtFusionLog.Multiline = true;
    ((Control) this.txtFusionLog).Name = "txtFusionLog";
    ((Control) this.txtFusionLog).Size = new Size(717, 115);
    ((Control) this.txtFusionLog).TabIndex = 7;
    ((UltraControlBase) this.txtFusionLog).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFusionLog).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(739, 576);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtFusionLog);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtDetail);
    this.Controls.Add((Control) this.lstInner);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lstPrimary);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (FormDeveloperDebugHelper);
    this.Text = "MGA Systems Exception Explorer";
    ((ISupportInitialize) this.txtDetail).EndInit();
    ((ISupportInitialize) this.txtFusionLog).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public FormDeveloperDebugHelper(Exception ex)
  {
    this.InitializeComponent();
    FormDeveloperDebugHelper.ShowException(this.lstPrimary, ex);
    if (ex.InnerException != null)
      FormDeveloperDebugHelper.ShowException(this.lstInner, ex.InnerException);
    ((TextEditorControlBase) this.txtDetail).Text = ex.StackTrace;
    PropertyInfo property1 = ex.GetType().GetProperty("FusionLog");
    if ((object) property1 != null && property1.GetValue((object) ex, (object[]) null) != null)
    {
      ((TextEditorControlBase) this.txtFusionLog).Text = RuntimeHelpers.GetObjectValue(property1.GetValue((object) ex, (object[]) null)).ToString();
    }
    else
    {
      if (ex.InnerException == null)
        return;
      PropertyInfo property2 = ex.InnerException.GetType().GetProperty("FusionLog");
      if ((object) property2 == null || property2.GetValue((object) ex.InnerException, (object[]) null) == null)
        return;
      ((TextEditorControlBase) this.txtFusionLog).Text = RuntimeHelpers.GetObjectValue(property2.GetValue((object) ex.InnerException, (object[]) null)).ToString();
    }
  }

  private static void ShowException(ListView lst, Exception ex)
  {
    lst.Items.Add(new ListViewItem(new string[2]
    {
      "Message",
      ex.Message
    }));
    lst.Items.Add(new ListViewItem(new string[2]
    {
      "Source",
      ex.Source
    }));
    lst.Items.Add(new ListViewItem(new string[2]
    {
      "StackTrace",
      ex.StackTrace
    }));
    lst.Items.Add(new ListViewItem(new string[2]
    {
      "TargetSite",
      ex.TargetSite?.ToString()
    }));
  }

  private void ListView_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!(sender is ListView listView) || listView.SelectedItems.Count <= 0)
      return;
    ((TextEditorControlBase) this.txtDetail).Text = ((ListView) sender).SelectedItems[0].SubItems[1].Text;
  }
}
