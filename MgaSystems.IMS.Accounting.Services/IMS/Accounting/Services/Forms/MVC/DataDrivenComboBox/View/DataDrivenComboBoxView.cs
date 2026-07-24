// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.View.DataDrivenComboBoxView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.ToDataTable;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.Model;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboBox.View;

[Obsolete("Use MvcComboBox")]
public class DataDrivenComboBoxView : 
  MvcViewBase<ISelectableValueModel<INamedValue<int>, int>, IDataDrivenComboBoxController>,
  IDataDrivenComboBoxView,
  IMvcView,
  IModelObserver
{
  private IContainer components;
  private MGASimpleComboBox cbWrappedComboBox;

  public DataDrivenComboBoxView() => this.InitializeComponent();

  protected override void ChildUpdateFromModel(ISelectableValueModel<INamedValue<int>, int> model)
  {
    this.cbWrappedComboBox.Value = (object) model.SelectedValue;
  }

  protected override void ChildWireUp()
  {
    ((UltraGridBase) this.cbWrappedComboBox).DataSource = (object) ObjectToDataTable.ToDataTable<INamedValue<int>>(this.Model.SelectableValues, (IEnumerable<IDataTableColumnMapping<INamedValue<int>>>) new List<IDataTableColumnMapping<INamedValue<int>>>()
    {
      (IDataTableColumnMapping<INamedValue<int>>) new DataTableColumnMapping<INamedValue<int>, int>("UniqueIdentifier", (Func<INamedValue<int>, int>) (x => ((IUniqueObject<int>) x).UniqueIdentifier)),
      (IDataTableColumnMapping<INamedValue<int>>) new DataTableColumnMapping<INamedValue<int>, string>("Name", (Func<INamedValue<int>, string>) (x => ((INamedValue) x).Name))
    });
    ((UltraDropDownBase) this.cbWrappedComboBox).ValueMember = "UniqueIdentifier";
    ((UltraDropDownBase) this.cbWrappedComboBox).DisplayMember = "Name";
    this.InvokeIfNotSuppressed((Action) (() => ((Control) this.cbWrappedComboBox).Enabled = true));
  }

  public void SetDropDownWidth(int width)
  {
    ((UltraDropDownBase) this.cbWrappedComboBox).DropDownWidth = width;
  }

  protected override void ChildUnWireUp()
  {
    ((Control) this.cbWrappedComboBox).Enabled = false;
    this.cbWrappedComboBox.Value = (object) -1;
  }

  public void UserChangeSelectedValue(int newSelection)
  {
    this.Controller.RequestSetSelectedValue((object) newSelection);
  }

  private void cbWrappedComboBox_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() =>
    {
      int result;
      if (!int.TryParse(this.cbWrappedComboBox.Value?.ToString(), out result))
        throw new InvalidCastException("Could not cast selected value to integer!");
      this.UserChangeSelectedValue(result);
    }));
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.cbWrappedComboBox = new MGASimpleComboBox();
    ((ISupportInitialize) this.cbWrappedComboBox).BeginInit();
    this.SuspendLayout();
    this.cbWrappedComboBox.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbWrappedComboBox).Dock = DockStyle.Fill;
    this.cbWrappedComboBox.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbWrappedComboBox).Location = new Point(0, 0);
    this.cbWrappedComboBox.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbWrappedComboBox).Name = "cbWrappedComboBox";
    ((Control) this.cbWrappedComboBox).Size = new Size(150, 20);
    ((Control) this.cbWrappedComboBox).TabIndex = 2;
    ((UltraControlBase) this.cbWrappedComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbWrappedComboBox).UseOsThemes = (DefaultableBoolean) 2;
    this.cbWrappedComboBox.ValueChanged += new EventHandler(this.cbWrappedComboBox_ValueChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.cbWrappedComboBox);
    this.ForeColor = SystemColors.ControlText;
    this.Name = nameof (DataDrivenComboBoxView);
    this.Size = new Size(150, 20);
    ((ISupportInitialize) this.cbWrappedComboBox).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
