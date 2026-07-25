// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.FormBulkRenewalQueue
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

public class FormBulkRenewalQueue : FormBase
{
  private IContainer components;
  private UltraPanel pnlButtons;
  private BindingSource policyRenewalsBindingSource;
  private dsBulkRenewal dsBulkRenewal;
  private MGAButton btnRenew;
  private MGAButton btnRefresh;
  private MGAButton btnCancel;
  public UltraGrid grdRenewalQueue;
  private LinkLabel lnkDeselectAll;
  private LinkLabel lnkSelectAll;
  private UltraFormattedTextEditor lnkControlNo;
  private MGAButton btnRelease;
  private UltraDropDownButton btnExport;
  private UltraToolbarsManager exportToolbar;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Top;
  private UltraGridExcelExporter bulkRenewalExporter;

  private dsBulkRenewal.PolicyRenewalsDataTable RenewalQueue => this.dsBulkRenewal.PolicyRenewals;

  public FormBulkRenewalQueue() => this.InitializeComponent();

  public FormBulkRenewalQueue(dsBulkRenewal.PolicyRenewalsDataTable renewals)
    : this()
  {
    this.MergeRenewalQuotes(renewals);
  }

  private void btnClose_Click(object sender, EventArgs e) => this.Close();

  private void btnRenew_Click(object sender, EventArgs e)
  {
    foreach (dsBulkRenewal.PolicyRenewalsRow policyRenewalsRow in this.dsBulkRenewal.PolicyRenewals.Where<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.Selected)).ToList<dsBulkRenewal.PolicyRenewalsRow>())
    {
      if (policyRenewalsRow.IsRenewalControlNoNull())
      {
        try
        {
          Quote quote1 = Quote.FromControlNo(policyRenewalsRow.ControlNo);
          policyRenewalsRow.RenewalGuid = quote1.Renew();
          policyRenewalsRow.Status = "Renewed Successfully";
          DefaultDatabase.ExecuteNonQuery("spRenewals_ClearRenewAutomatically", new object[2]
          {
            (object) "@QuoteId",
            (object) quote1.QuoteID
          });
          Quote quote2 = new Quote(policyRenewalsRow.RenewalGuid);
          policyRenewalsRow.RenewalControlNo = quote2.ControlNo;
        }
        catch (Exception ex)
        {
          policyRenewalsRow.Status = "Error: " + ex.Message;
        }
      }
      policyRenewalsRow.Selected = false;
    }
    this.SetRowStatuses();
  }

  private void btnRelease_Click(object sender, EventArgs e)
  {
    foreach (dsBulkRenewal.PolicyRenewalsRow row in this.dsBulkRenewal.PolicyRenewals.Where<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.Selected)).ToList<dsBulkRenewal.PolicyRenewalsRow>())
    {
      if (row.IsRenewalControlNoNull())
      {
        try
        {
          DefaultDatabase.ExecuteNonQuery("spRenewals_ClearRenewAutomatically", new object[4]
          {
            (object) "@QuoteId",
            (object) Quote.FromControlNo(row.ControlNo).QuoteID,
            (object) "@SetValue",
            null
          });
          this.dsBulkRenewal.PolicyRenewals.RemovePolicyRenewalsRow(row);
        }
        catch
        {
          row.Status = "Unable to release automatic renewal";
        }
      }
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectRows(true);
  }

  private void lnkDeselectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectRows(false);
  }

  private void lnkControlNo_LinkClicked(object sender, LinkClickedEventArgs e)
  {
    int result = 0;
    if (string.IsNullOrEmpty(e.LinkText) || !int.TryParse(e.LinkText, out result))
      return;
    if (Quote.ControlNumberExists(result))
    {
      FormSettings.ShowForm(typeof (frmPolicyDetail), (object) result);
    }
    else
    {
      UltraGridCell context = (UltraGridCell) e.Context;
      if (((KeyedSubObjectBase) context.Column).Key.Equals("RenewalControlNo", StringComparison.OrdinalIgnoreCase))
      {
        context.SetValue((object) DBNull.Value, false);
        this.RenewalQueue[context.Row.ListIndex].Status = "Renewal Control not found";
      }
      else
      {
        context.IgnoreRowColActivation = true;
        context.Activation = (Activation) 2;
        this.RenewalQueue[context.Row.ListIndex].Status = "Original Control not found";
      }
    }
  }

  private void FormBulkRenewalQueue_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void exportToolbar_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ExportReport":
        DataTable dataTable = this.RenewalQueue.CopyToDataTable<dsBulkRenewal.PolicyRenewalsRow>();
        dataTable.Rows.Clear();
        foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.grdRenewalQueue).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (grow => !grow.IsFilteredOut)))
          dataTable.Rows.Add(((DataRowView) ultraGridRow.ListObject).Row.ItemArray);
        rptRenewalResults report = new rptRenewalResults(dataTable);
        report.Run();
        new frmPrint((SectionReport) report).Show();
        break;
      case "ExportSpreadsheet":
        try
        {
          string fileName = $"{MGATempFolder.MGATempPath}{DateTime.Now.ToString("\"BRQ\"yyyyMMddHHss")}.xls";
          this.bulkRenewalExporter.Export(this.grdRenewalQueue, fileName);
          Process.Start(fileName);
          break;
        }
        catch
        {
          break;
        }
    }
  }

  private void RefreshRenewalQuotes(object sender, EventArgs e)
  {
    this.MergeRenewalQuotes((dsBulkRenewal.PolicyRenewalsDataTable) null);
  }

  private void grdRenewalQueue_CellChange(object sender, CellEventArgs e)
  {
    this.grdRenewalQueue.PerformAction((UltraGridAction) 44);
    MGAButton btnRenew = this.btnRenew;
    MGAButton btnRelease = this.btnRelease;
    dsBulkRenewal.PolicyRenewalsDataTable renewalQueue = this.RenewalQueue;
    int num1;
    bool flag = (num1 = renewalQueue.Any<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.Selected && tr.IsRenewalControlNoNull())) ? 1 : 0) != 0;
    ((Control) btnRelease).Enabled = num1 != 0;
    int num2 = flag ? 1 : 0;
    ((Control) btnRenew).Enabled = num2 != 0;
    ((Control) this.btnExport).Enabled = ((Control) this.btnRenew).Enabled || this.RenewalQueue.Any<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.Selected));
  }

  private void bulkRenewalExporter_BeginExport(object sender, BeginExportEventArgs e)
  {
    e.Layout.Bands[0].Columns["Selected"].Hidden = true;
  }

  private void bulkRenewalExporter_RowExporting(object sender, RowExportingEventArgs e)
  {
    if ((bool) e.GridRow.GetCellValue("Selected") && !e.GridRow.IsFilteredOut)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  public void MergeRenewalQuotes(dsBulkRenewal.PolicyRenewalsDataTable renewals)
  {
    if (renewals == null)
    {
      string str = (string) null;
      if (this.RenewalQueue.Count > 0)
        str = string.Join(",", this.RenewalQueue.Select<dsBulkRenewal.PolicyRenewalsRow, string>((System.Func<dsBulkRenewal.PolicyRenewalsRow, string>) (tr => tr.ControlNo.ToString())).ToArray<string>());
      renewals = new dsBulkRenewal.PolicyRenewalsDataTable();
      DefaultDatabase.LoadDataTable((DataTable) renewals, "spRenewals_GetRenewalQueue", new object[4]
      {
        (object) "@controlnos",
        (object) str,
        (object) "@daysBeforeExpire",
        null
      });
      this.AddClientData();
    }
    this.RenewalQueue.Merge((DataTable) renewals);
  }

  private void SetRowStatuses()
  {
    for (int index = 0; index < this.RenewalQueue.Count; ++index)
    {
      UltraGridRow row = ((UltraGridBase) this.grdRenewalQueue).Rows[index];
      if (this.RenewalQueue[index].IsRenewalControlNoNull())
        ((AppearanceBase) row.Appearance).ResetForeColor();
      else
        ((AppearanceBase) row.Appearance).ForeColor = Color.Gray;
    }
  }

  private void SelectRows(bool selected)
  {
    foreach (UltraGridRow ultraGridRow in ((IEnumerable) ((UltraGridBase) this.grdRenewalQueue).Rows).OfType<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => !r.IsFilteredOut)))
      ultraGridRow.Cells["Selected"].Value = (object) selected;
    ((Control) this.btnRenew).Enabled = ((Control) this.btnRelease).Enabled = selected && this.RenewalQueue.Any<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.IsRenewalControlNoNull()));
    ((Control) this.btnExport).Enabled = selected || this.RenewalQueue.Any<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.Selected));
  }

  protected virtual void AddClientData()
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool1 = new ButtonTool("ExportReport");
    ButtonTool buttonTool2 = new ButtonTool("ExportSpreadsheet");
    PopupMenuTool popupMenuTool = new PopupMenuTool("N/A");
    ButtonTool buttonTool3 = new ButtonTool("ExportReport");
    ButtonTool buttonTool4 = new ButtonTool("ExportSpreadsheet");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("PolicyRenewals", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNo");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RenewalControlNo");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Status", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RenewalGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Selected");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormBulkRenewalQueue));
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("QuoteStatusBound", 0);
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.lnkControlNo = new UltraFormattedTextEditor();
    this.pnlButtons = new UltraPanel();
    this.btnExport = new UltraDropDownButton();
    this.exportToolbar = new UltraToolbarsManager(this.components);
    this.btnRelease = new MGAButton();
    this.lnkDeselectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnRenew = new MGAButton();
    this.btnRefresh = new MGAButton();
    this.btnCancel = new MGAButton();
    this.grdRenewalQueue = new UltraGrid();
    this.policyRenewalsBindingSource = new BindingSource(this.components);
    this.dsBulkRenewal = new dsBulkRenewal();
    this.bulkRenewalExporter = new UltraGridExcelExporter(this.components);
    this._FormBulkRenewal_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    ((Control) this.pnlButtons.ClientArea).SuspendLayout();
    ((Control) this.pnlButtons).SuspendLayout();
    ((ISupportInitialize) this.exportToolbar).BeginInit();
    ((ISupportInitialize) this.btnRelease).BeginInit();
    ((ISupportInitialize) this.btnRenew).BeginInit();
    ((ISupportInitialize) this.btnRefresh).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.grdRenewalQueue).BeginInit();
    ((ISupportInitialize) this.policyRenewalsBindingSource).BeginInit();
    this.dsBulkRenewal.BeginInit();
    this.SuspendLayout();
    ((Control) this.lnkControlNo).Location = new Point(45, 55);
    ((Control) this.lnkControlNo).Name = "lnkControlNo";
    ((Control) this.lnkControlNo).Size = new Size(72, 23);
    ((Control) this.lnkControlNo).TabIndex = 14;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).TreatValueAs = (TreatValueAs) 2;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).Value = (object) "controlno";
    ((Control) this.lnkControlNo).Visible = false;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).LinkClicked += new LinkClickedEventHandler(this.lnkControlNo_LinkClicked);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.btnExport);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.btnRelease);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.lnkDeselectAll);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.lnkSelectAll);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.btnRenew);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.btnRefresh);
    ((Control) this.pnlButtons.ClientArea).Controls.Add((Control) this.btnCancel);
    ((Control) this.pnlButtons).Dock = DockStyle.Bottom;
    ((Control) this.pnlButtons).Location = new Point(0, 258);
    ((Control) this.pnlButtons).Name = "pnlButtons";
    ((Control) this.pnlButtons).Size = new Size(583, 50);
    ((Control) this.pnlButtons).TabIndex = 1;
    ((Control) this.btnExport).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnExport).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnExport).ButtonStyle = (UIElementButtonStyle) 14;
    ((Control) this.btnExport).Location = new Point(223, 12);
    ((Control) this.btnExport).Name = "btnExport";
    this.btnExport.PopupItemKey = "N/A";
    this.btnExport.PopupItemProvider = (IPopupItemProvider) this.exportToolbar;
    ((Control) this.btnExport).Size = new Size(74, 26);
    this.btnExport.Style = (SplitButtonDisplayStyle) 1;
    ((Control) this.btnExport).TabIndex = 19;
    ((Control) this.btnExport).Text = "Export";
    ((UltraControlBase) this.btnExport).UseOsThemes = (DefaultableBoolean) 2;
    this.exportToolbar.DesignerFlags = 1;
    this.exportToolbar.DockWithinContainer = (Control) this;
    this.exportToolbar.DockWithinContainerBaseType = typeof (FormBase);
    this.exportToolbar.ImageSizeLarge = new Size(0, 0);
    this.exportToolbar.ImageSizeSmall = new Size(0, 0);
    this.exportToolbar.ShowFullMenusDelay = 500;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Report";
    ((ToolBase) buttonTool1).SharedPropsInternal.CustomizerCaption = "Report";
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Spreadsheet";
    ((ToolBase) buttonTool2).SharedPropsInternal.CustomizerCaption = "Spreadsheet";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "N/A";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((ToolsCollectionBase) this.exportToolbar.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) popupMenuTool
    });
    this.exportToolbar.ToolClick += new ToolClickEventHandler(this.exportToolbar_ToolClick);
    ((Control) this.btnRelease).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRelease).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnRelease).DialogResult = DialogResult.Cancel;
    ((Control) this.btnRelease).Enabled = false;
    ((Control) this.btnRelease).Location = new Point(405, 12);
    ((Control) this.btnRelease).Name = "btnRelease";
    ((Control) this.btnRelease).Size = new Size(74, 26);
    ((Control) this.btnRelease).TabIndex = 1;
    ((Control) this.btnRelease).Text = "Release";
    ((UltraControlBase) this.btnRelease).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRelease).Click += new EventHandler(this.btnRelease_Click);
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.BackColor = Color.Transparent;
    this.lnkDeselectAll.Location = new Point(8, 29);
    this.lnkDeselectAll.Margin = new Padding(4, 0, 4, 0);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(63 /*0x3F*/, 13);
    this.lnkDeselectAll.TabIndex = 14;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "Deselect All";
    this.lnkDeselectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkDeselectAll_LinkClicked);
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(8, 8);
    this.lnkSelectAll.Margin = new Padding(4, 0, 4, 0);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 13;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkSelectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
    ((Control) this.btnRenew).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRenew).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnRenew).Enabled = false;
    ((Control) this.btnRenew).Location = new Point(314, 12);
    ((Control) this.btnRenew).Name = "btnRenew";
    ((Control) this.btnRenew).Size = new Size(74, 26);
    ((Control) this.btnRenew).TabIndex = 1;
    ((Control) this.btnRenew).Text = "Renew";
    ((UltraControlBase) this.btnRenew).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRenew).Click += new EventHandler(this.btnRenew_Click);
    ((Control) this.btnRefresh).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRefresh).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnRefresh).Location = new Point(497, 12);
    ((Control) this.btnRefresh).Name = "btnRefresh";
    ((Control) this.btnRefresh).Size = new Size(74, 26);
    ((Control) this.btnRefresh).TabIndex = 1;
    ((Control) this.btnRefresh).Text = "Refresh";
    ((UltraControlBase) this.btnRefresh).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRefresh).Click += new EventHandler(this.RefreshRenewalQuotes);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance5;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(497, 12);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(74, 26);
    ((Control) this.btnCancel).TabIndex = 1;
    ((Control) this.btnCancel).Text = "Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Visible = false;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnClose_Click);
    ((UltraGridBase) this.grdRenewalQueue).DataSource = (object) this.policyRenewalsBindingSource;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ultraGridColumn1.EditorComponent = (Component) this.lnkControlNo;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn1.FilterCellAppearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.MinWidth = 75;
    ultraGridColumn1.RowLayoutColumnInfo.OriginX = 2;
    ultraGridColumn1.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn1.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn1.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn1.Width = 75;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 5;
    ultraGridColumn2.MaxWidth = 100;
    ultraGridColumn2.MinWidth = 100;
    ultraGridColumn2.RowLayoutColumnInfo.OriginX = 6;
    ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn2.Width = 100;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.MaxWidth = 200;
    ultraGridColumn3.MinWidth = 100;
    ultraGridColumn3.RowLayoutColumnInfo.OriginX = 4;
    ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn3.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn3.Width = 100;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.EditorComponent = (Component) this.lnkControlNo;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Renewal Control";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.NullText = "";
    ultraGridColumn4.RowLayoutColumnInfo.OriginX = 8;
    ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 6;
    ultraGridColumn5.MaxWidth = 100;
    ultraGridColumn5.MinWidth = 75;
    ultraGridColumn5.NullText = "Queued for Renewal";
    ultraGridColumn5.RowLayoutColumnInfo.OriginX = 10;
    ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn5.Width = 100;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 4;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellClickAction = (CellClickAction) 1;
    ultraGridColumn7.DefaultCellValue = componentResourceManager.GetObject("ultraGridColumn23.DefaultCellValue");
    ((HeaderBase) ultraGridColumn7.Header).Caption = "";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.MaxWidth = 50;
    ultraGridColumn7.MinWidth = 45;
    ultraGridColumn7.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new Size(45, 0);
    ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn7.Width = 45;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((HeaderBase) ultraGridBand.Header).Caption = "";
    ultraGridBand.Override.ColumnAutoSizeMode = (ColumnAutoSizeMode) 2;
    ultraGridBand.RowLayoutStyle = (RowLayoutStyle) 1;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.ColumnSizingArea = (ColumnSizingArea) 3;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.MaxSelectedRows = 50;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.grdRenewalQueue).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grdRenewalQueue).Dock = DockStyle.Fill;
    ((Control) this.grdRenewalQueue).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.grdRenewalQueue).Location = new Point(0, 0);
    ((Control) this.grdRenewalQueue).Margin = new Padding(4);
    ((Control) this.grdRenewalQueue).Name = "grdRenewalQueue";
    ((Control) this.grdRenewalQueue).Size = new Size(583, 258);
    ((Control) this.grdRenewalQueue).TabIndex = 8;
    this.grdRenewalQueue.UpdateMode = (UpdateMode) 3;
    ((UltraControlBase) this.grdRenewalQueue).UseOsThemes = (DefaultableBoolean) 2;
    this.grdRenewalQueue.CellChange += new CellEventHandler(this.grdRenewalQueue_CellChange);
    this.policyRenewalsBindingSource.DataMember = "PolicyRenewals";
    this.policyRenewalsBindingSource.DataSource = (object) this.dsBulkRenewal;
    this.dsBulkRenewal.DataSetName = "dsBulkRenewal";
    this.dsBulkRenewal.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.bulkRenewalExporter.BeginExport += new BeginExportEventHandler(this.bulkRenewalExporter_BeginExport);
    this.bulkRenewalExporter.RowExporting += new RowExportingEventHandler(this.bulkRenewalExporter_RowExporting);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Top";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Size = new Size(583, 0);
    this._FormBulkRenewal_Toolbars_Dock_Area_Top.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Location = new Point(0, 308);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Size = new Size(583, 0);
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Left";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Size = new Size(0, 308);
    this._FormBulkRenewal_Toolbars_Dock_Area_Left.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Location = new Point(583, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Right";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Size = new Size(0, 308);
    this._FormBulkRenewal_Toolbars_Dock_Area_Right.ToolbarsManager = this.exportToolbar;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(583, 308);
    this.Controls.Add((Control) this.lnkControlNo);
    this.Controls.Add((Control) this.grdRenewalQueue);
    this.Controls.Add((Control) this.pnlButtons);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top);
    this.Name = nameof (FormBulkRenewalQueue);
    this.Text = "Bulk Renewals Queue";
    this.FormClosing += new FormClosingEventHandler(this.FormBulkRenewalQueue_FormClosing);
    this.Load += new EventHandler(this.RefreshRenewalQuotes);
    ((Control) this.pnlButtons.ClientArea).ResumeLayout(false);
    ((Control) this.pnlButtons.ClientArea).PerformLayout();
    ((Control) this.pnlButtons).ResumeLayout(false);
    ((ISupportInitialize) this.exportToolbar).EndInit();
    ((ISupportInitialize) this.btnRelease).EndInit();
    ((ISupportInitialize) this.btnRenew).EndInit();
    ((ISupportInitialize) this.btnRefresh).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.grdRenewalQueue).EndInit();
    ((ISupportInitialize) this.policyRenewalsBindingSource).EndInit();
    this.dsBulkRenewal.EndInit();
    this.ResumeLayout(false);
  }
}
