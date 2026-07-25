// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormCoverageMappings
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormCoverageMappings : FormBase
{
  private IContainer components;
  private BindingSource _bs;
  private DataTable _dtSpreadsheet;
  private DataTable _dt;
  private DataTable _dtSpreadsheetCols;
  private bool _isMapping;

  [DebuggerNonUserCode]
  protected virtual void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(disposing));
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
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("IMSColumns", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("IMSColumn", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Type", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SpreadsheetColumn", 1, (object) "ddSpreadsheetCols");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    this.ddSpreadsheetCols = new UltraDropDown();
    this.btnClose = new Button();
    this.tbCoverageMappings = new UltraTabStripControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.grdExposure = new UltraGrid();
    ((ISupportInitialize) this.ddSpreadsheetCols).BeginInit();
    ((ISupportInitialize) this.tbCoverageMappings).BeginInit();
    ((Control) this.tbCoverageMappings).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.grdExposure).BeginInit();
    ((Control) this).SuspendLayout();
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddSpreadsheetCols).DisplayMember = "SpreadsheetColumn";
    ((UltraDropDownBase) this.ddSpreadsheetCols).DropDownWidth = 200;
    ((Control) this.ddSpreadsheetCols).Location = new Point(58, 355);
    ((Control) this.ddSpreadsheetCols).Name = "ddSpreadsheetCols";
    ((Control) this.ddSpreadsheetCols).Size = new Size(273, 72);
    ((Control) this.ddSpreadsheetCols).TabIndex = 2;
    ((Control) this.ddSpreadsheetCols).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddSpreadsheetCols).ValueMember = "SpreadsheetColumn";
    ((Control) this.ddSpreadsheetCols).Visible = false;
    this.btnClose.Location = new Point(454, 383);
    this.btnClose.Name = "btnClose";
    this.btnClose.Size = new Size(75, 32 /*0x20*/);
    this.btnClose.TabIndex = 5;
    this.btnClose.Text = "Close";
    this.btnClose.UseVisualStyleBackColor = true;
    ((Control) this.tbCoverageMappings).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tbCoverageMappings).Location = new Point(4, 25);
    ((Control) this.tbCoverageMappings).Name = "tbCoverageMappings";
    ((UltraTabControlBase) this.tbCoverageMappings).SharedControls.AddRange(new Control[1]
    {
      (Control) this.grdExposure
    });
    ((UltraTabControlBase) this.tbCoverageMappings).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tbCoverageMappings).Size = new Size(546, 343);
    ((Control) this.tbCoverageMappings).TabIndex = 6;
    ultraTab1.Text = "Contents";
    ultraTab2.Text = "BI";
    ultraTab3.Text = "Buildings Limit";
    ((UltraTabControlBase) this.tbCoverageMappings).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.grdExposure);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(1, 23);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(542, 317);
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.LockedWidth = true;
    ultraGridColumn2.Width = 234;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 288;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.grdExposure).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdExposure).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.grdExposure).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ActiveBorder;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.grdExposure).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.grdExposure).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) this.grdExposure).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.grdExposure).DisplayLayout.GroupByBox).Hidden = true;
    appearance16.BackColor = SystemColors.ControlLightLight;
    appearance16.BackColor2 = SystemColors.Control;
    appearance16.BackGradientStyle = (GradientStyle) 3;
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.grdExposure).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.grdExposure).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.grdExposure).DisplayLayout.MaxRowScrollRegions = 1;
    appearance17.BackColor = SystemColors.Window;
    appearance17.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Highlight;
    appearance18.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance19.BackColor = SystemColors.Window;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.Silver;
    appearance20.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.CellPadding = 0;
    appearance21.BackColor = SystemColors.Control;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientAlignment = (GradientAlignment) 1;
    appearance21.BackGradientStyle = (GradientStyle) 3;
    appearance21.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.grdExposure).DisplayLayout.Scrollbars = (Scrollbars) 2;
    ((UltraGridBase) this.grdExposure).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.grdExposure).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.grdExposure).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.grdExposure).Location = new Point(-1, 0);
    ((Control) this.grdExposure).Name = "grdExposure";
    ((Control) this.grdExposure).Size = new Size(539, 301);
    ((Control) this.grdExposure).TabIndex = 3;
    ((Control) this.grdExposure).Text = "ultraGrid1";
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).ClientSize = new Size(555, 458);
    ((Control) this).Controls.Add((Control) this.tbCoverageMappings);
    ((Control) this).Controls.Add((Control) this.ddSpreadsheetCols);
    ((Control) this).Controls.Add((Control) this.btnClose);
    ((Control) this).Name = nameof (FormCoverageMappings);
    ((Form) this).Text = nameof (FormCoverageMappings);
    ((ISupportInitialize) this.ddSpreadsheetCols).EndInit();
    ((ISupportInitialize) this.tbCoverageMappings).EndInit();
    ((Control) this.tbCoverageMappings).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.grdExposure).EndInit();
    ((Control) this).ResumeLayout(false);
  }

  protected virtual UltraDropDown ddSpreadsheetCols
  {
    get => this._ddSpreadsheetCols;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ddSpreadsheetCols_InitializeLayout);
      UltraDropDown ddSpreadsheetCols1 = this._ddSpreadsheetCols;
      if (ddSpreadsheetCols1 != null)
        ddSpreadsheetCols1.InitializeLayout -= layoutEventHandler;
      this._ddSpreadsheetCols = value;
      UltraDropDown ddSpreadsheetCols2 = this._ddSpreadsheetCols;
      if (ddSpreadsheetCols2 == null)
        return;
      ddSpreadsheetCols2.InitializeLayout += layoutEventHandler;
    }
  }

  internal virtual Button btnClose
  {
    get => this._btnClose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClose_Click);
      Button btnClose1 = this._btnClose;
      if (btnClose1 != null)
        btnClose1.Click -= eventHandler;
      this._btnClose = value;
      Button btnClose2 = this._btnClose;
      if (btnClose2 == null)
        return;
      btnClose2.Click += eventHandler;
    }
  }

  internal virtual UltraTabStripControl tbCoverageMappings
  {
    get => this._tbCoverageMappings;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.tbCoverageMappings_SelectedTabChanged);
      UltraTabStripControl coverageMappings1 = this._tbCoverageMappings;
      if (coverageMappings1 != null)
        ((UltraTabControlBase) coverageMappings1).SelectedTabChanged -= changedEventHandler;
      this._tbCoverageMappings = value;
      UltraTabStripControl coverageMappings2 = this._tbCoverageMappings;
      if (coverageMappings2 == null)
        return;
      ((UltraTabControlBase) coverageMappings2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid grdExposure
  {
    get => this._grdExposure;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler1 = new CellEventHandler(this.grdExposure_AfterCellUpdate);
      CancelableCellEventHandler cellEventHandler2 = new CancelableCellEventHandler(this.grdExposure_BeforeCellListDropDown);
      UltraGrid grdExposure1 = this._grdExposure;
      if (grdExposure1 != null)
      {
        grdExposure1.AfterCellUpdate -= cellEventHandler1;
        grdExposure1.BeforeCellListDropDown -= cellEventHandler2;
      }
      this._grdExposure = value;
      UltraGrid grdExposure2 = this._grdExposure;
      if (grdExposure2 == null)
        return;
      grdExposure2.AfterCellUpdate += cellEventHandler1;
      grdExposure2.BeforeCellListDropDown += cellEventHandler2;
    }
  }

  public bool IsMapping
  {
    get => this._isMapping;
    set => this._isMapping = value;
  }

  public FormCoverageMappings() => this.InitializeComponent();

  public FormCoverageMappings(DataTable dtSpreadsheetCols)
  {
    this.InitializeComponent();
    this._dtSpreadsheetCols = dtSpreadsheetCols;
  }

  private void tbCoverageMappings_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    string str;
    switch (((TabEventArgs) e).Tab.Index)
    {
      case 0:
        str = "PP";
        break;
      case 1:
        str = "BI";
        break;
      case 2:
        str = "RP";
        break;
    }
    try
    {
      ((UltraGridBase) this.grdExposure).DataSource = (object) DefaultDatabase.ExecuteDataTable("GetPropertyExposureList", new object[2]
      {
        (object) "@exposureType",
        (object) str
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message.ToString());
      ProjectData.ClearProjectError();
    }
    this.LoadSavedMapping(((TabEventArgs) e).Tab.Index);
  }

  private void LoadSavedMapping(int tbIndex)
  {
    if (CoverageExposure.CoverageMap.Count <= 0)
      return;
    try
    {
      foreach (CoverageExposure coverage in CoverageExposure.CoverageMap)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.grdExposure).Rows)
        {
          if (coverage.CoverageID == Conversions.ToInteger(row.Cells[0].Value))
          {
            this.IsMapping = true;
            row.Cells[3].Value = (object) coverage.SpreadsheetColumn;
          }
          this.IsMapping = false;
        }
      }
    }
    finally
    {
      List<CoverageExposure>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void grdExposure_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (this.IsMapping)
      return;
    e.Cell.Value.ToString();
    string mn = "TestCoverageMapping";
    string imt = "lstPropRater_CoverageTypes";
    int integer = Conversions.ToInteger(this.grdExposure.ActiveCell.Row.Cells[0].Value);
    string imc = this.grdExposure.ActiveCell.Row.Cells[1].Value.ToString();
    string ct = this.grdExposure.ActiveCell.Row.Cells[2].Value.ToString();
    string sc = this.grdExposure.ActiveCell.Row.Cells[3].Value.ToString();
    CoverageExposure coverageExposure = new CoverageExposure(mn, imt, imc, sc, ct, integer);
    int index = 0;
    try
    {
      foreach (CoverageExposure coverage in CoverageExposure.CoverageMap)
      {
        if (coverage.CoverageID == integer)
        {
          CoverageExposure.CoverageMap.RemoveAt(index);
          break;
        }
        ++index;
      }
    }
    finally
    {
      List<CoverageExposure>.Enumerator enumerator;
      enumerator.Dispose();
    }
    CoverageExposure.CoverageMap.Add(coverageExposure);
  }

  private void btnClose_Click(object sender, EventArgs e) => ((Form) this).Close();

  private void grdExposure_BeforeCellListDropDown(object sender, CancelableCellEventArgs e)
  {
    ((UltraGridBase) this.ddSpreadsheetCols).DataSource = (object) this._dtSpreadsheetCols;
    ((UltraDropDownBase) this.ddSpreadsheetCols).ValueMember = this._dtSpreadsheetCols.Columns[0].ToString();
    ((UltraDropDownBase) this.ddSpreadsheetCols).DisplayMember = this._dtSpreadsheetCols.Columns[1].ToString();
  }

  private void ddSpreadsheetCols_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Bands[0].Columns[0].Hidden = true;
  }
}
