// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.formReconcilationHistory
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[DesignerGenerated]
[TestForm]
public class formReconcilationHistory : FormBase
{
  private IContainer components;
  private Image voidImg;

  public formReconcilationHistory()
  {
    this.Load += new EventHandler(this.formReconcilationHistory_Load);
    this.InitializeComponent();
  }

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.gridRecHistory = new UltraGrid();
    ((ISupportInitialize) this.gridRecHistory).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 2;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 2;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 2147483646;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.WhiteSmoke;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridRecHistory).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridRecHistory).Dock = DockStyle.Fill;
    ((Control) this.gridRecHistory).Location = new Point(0, 0);
    ((Control) this.gridRecHistory).Name = "gridRecHistory";
    ((Control) this.gridRecHistory).Size = new Size(958, 628);
    ((Control) this.gridRecHistory).TabIndex = 0;
    ((UltraControlBase) this.gridRecHistory).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridRecHistory).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(958, 628);
    this.Controls.Add((Control) this.gridRecHistory);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (formReconcilationHistory);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Reconciliation History";
    ((ISupportInitialize) this.gridRecHistory).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual UltraGrid gridRecHistory
  {
    get => this._gridRecHistory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.gridRecHistory_InitializeRow);
      UltraGrid gridRecHistory1 = this._gridRecHistory;
      if (gridRecHistory1 != null)
        gridRecHistory1.InitializeRow -= initializeRowEventHandler;
      this._gridRecHistory = value;
      UltraGrid gridRecHistory2 = this._gridRecHistory;
      if (gridRecHistory2 == null)
        return;
      gridRecHistory2.InitializeRow += initializeRowEventHandler;
    }
  }

  private void formReconcilationHistory_Load(object sender, EventArgs e)
  {
    this.LoadData();
    this.FormatGrid();
    this.voidImg = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.Banking.Voided.png"));
  }

  private void LoadData()
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet("spFin_GetReconciliationHistory");
    ((UltraGridBase) this.gridRecHistory).DataSource = (object) dataSet;
    dataSet.Relations.Add(new DataRelation("depositId", dataSet.Tables[0].Columns["DepositId"], dataSet.Tables[1].Columns["DepositId"]));
  }

  private void FormatGrid()
  {
    UltraGridLayout displayLayout = ((UltraGridBase) this.gridRecHistory).DisplayLayout;
    displayLayout.Bands[0].Columns["DepositId"].Hidden = true;
    displayLayout.Bands[0].Columns["void"].Hidden = true;
    foreach (UltraGridColumn column in displayLayout.Bands[0].Columns)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.Key, "Amount", false) == 0)
      {
        column.Format = "c";
        column.CellAppearance.TextHAlign = (HAlign) 3;
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
      }
      else
      {
        column.CellAppearance.TextHAlign = (HAlign) 1;
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
      }
    }
    displayLayout.Bands[1].Columns["DepositId"].Hidden = true;
    foreach (UltraGridColumn column in displayLayout.Bands[1].Columns)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.Key, "Amount", false) == 0)
      {
        column.Format = "c";
        column.CellAppearance.TextHAlign = (HAlign) 3;
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
      }
      else
      {
        column.CellAppearance.TextHAlign = (HAlign) 1;
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
      }
    }
    displayLayout.Bands[1].Override.RowAppearance.BackColor = Color.Beige;
    displayLayout.Bands[1].Override.RowAlternateAppearance.BackColor = Color.DarkSeaGreen;
  }

  private void gridRecHistory_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Band.Index == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells["Check Name"].Value.ToString(), "Deposit", false) == 0)
    {
      e.Row.Appearance.BackColor = Color.Beige;
      e.Row.Appearance.BorderColor = Color.DarkSeaGreen;
    }
    if (e.Row.Band.Index != 0 || !Conversions.ToBoolean(e.Row.Cells["void"].Value.ToString()))
      return;
    e.Row.Appearance.ImageBackgroundAlpha = (Alpha) 0;
    e.Row.Appearance.ImageBackgroundStyle = (ImageBackgroundStyle) 1;
    e.Row.Appearance.ImageBackgroundOrigin = (ImageBackgroundOrigin) 0;
    e.Row.Appearance.ForeColor = Color.Red;
    e.Row.Appearance.ImageBackground = this.voidImg;
  }
}
