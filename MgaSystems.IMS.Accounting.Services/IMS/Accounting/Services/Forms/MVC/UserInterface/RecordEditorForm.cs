// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.UserInterface.RecordEditorForm
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.View;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.UserInterface;

public class RecordEditorForm : FormBase
{
  private IContainer components;
  private RecordEditorView cRecordEditor;

  protected virtual IDatabaseSaveModel[] AllRecords { get; }

  protected virtual Func<IDatabaseSaveModel> CreateNewFunc { get; }

  protected virtual IDataGridDisplaySettings ListDisplaySettings { get; }

  protected virtual IExcelExporter ExcelExporter { get; }

  public RecordEditorForm() => this.InitializeComponent();

  public void Setup(IMvcView entityEditControl, IMvcController entityEditController)
  {
    this.cRecordEditor.SetEditControl(entityEditControl, entityEditController);
  }

  protected void OnLoad()
  {
    this.cRecordEditor.WireUp((IRecordEditorController) new RecordEditorController((IDataGridController) new DataGridController()), (IRecordEditorModel) new RecordEditorModel((IDataGridModel) new DataGridModel((IEnumerable<IDatabaseSaveModel>) this.AllRecords, this.ListDisplaySettings, this.ExcelExporter), this.CreateNewFunc));
  }

  private void cRecordEditor_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.OnLoad();
  }

  protected override void OnClosing(CancelEventArgs e)
  {
    if (this.DialogResult == DialogResult.Cancel && this.cRecordEditor.EditControlView.IsWiredUp())
    {
      bool flag = this.cRecordEditor.DisplayYesNo("Closing the form will cause any unsaved data to be lost. Continue?", "Unsaved data may be lost");
      e.Cancel = !flag;
    }
    base.OnClosing(e);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.cRecordEditor = new RecordEditorView();
    this.SuspendLayout();
    this.cRecordEditor.BackColor = Color.Transparent;
    this.cRecordEditor.Dock = DockStyle.Fill;
    this.cRecordEditor.Font = new Font("Tahoma", 8.25f);
    this.cRecordEditor.Location = new Point(0, 0);
    this.cRecordEditor.Name = "cRecordEditor";
    this.cRecordEditor.Size = new Size(1063, 645);
    this.cRecordEditor.TabIndex = 0;
    this.cRecordEditor.Load += new EventHandler(this.cRecordEditor_Load);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.ActiveCaption;
    this.ClientSize = new Size(1063, 645);
    this.Controls.Add((Control) this.cRecordEditor);
    this.Name = nameof (RecordEditorForm);
    this.Text = "Base Record Edit Form";
    this.ResumeLayout(false);
  }
}
