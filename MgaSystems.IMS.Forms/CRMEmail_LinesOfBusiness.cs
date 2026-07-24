// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.CRMEmail_LinesOfBusiness
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class CRMEmail_LinesOfBusiness : UserControl
{
  private IContainer components;
  private dsCRMSelectionCriteria.LinesOfBusinessDataTable _data;
  private string[,] _selectedLines;
  private string[] _selectedLineIDs;
  private int _arrayCount;
  private CRMEmail_States _crmStates;

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
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("LinesOfBusiness", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Select", 0);
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CRMEmail_LinesOfBusiness));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.pnlQueryParams = new Panel();
    this.PanelContent = new Panel();
    this.Panel1 = new Panel();
    this.llSelectNoneLOB = new LinkLabel();
    this.llSelectAllLOB = new LinkLabel();
    this.grdLineOfBusiness = new UltraGrid();
    this.LinesOfBusinessBindingSource = new BindingSource(this.components);
    this.DsCRMSelectionCriteria = new dsCRMSelectionCriteria();
    this.panelHeader = new Panel();
    this.Label1 = new Label();
    this.LinesOfBusinessBindingSource1 = new BindingSource(this.components);
    this.pnlQueryParams.SuspendLayout();
    this.PanelContent.SuspendLayout();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.grdLineOfBusiness).BeginInit();
    ((ISupportInitialize) this.LinesOfBusinessBindingSource).BeginInit();
    this.DsCRMSelectionCriteria.BeginInit();
    this.panelHeader.SuspendLayout();
    ((ISupportInitialize) this.LinesOfBusinessBindingSource1).BeginInit();
    this.SuspendLayout();
    this.pnlQueryParams.Controls.Add((Control) this.PanelContent);
    this.pnlQueryParams.Controls.Add((Control) this.panelHeader);
    this.pnlQueryParams.Dock = DockStyle.Fill;
    this.pnlQueryParams.Location = new Point(0, 0);
    this.pnlQueryParams.Name = "pnlQueryParams";
    this.pnlQueryParams.Size = new Size(737, 658);
    this.pnlQueryParams.TabIndex = 3;
    this.PanelContent.Controls.Add((Control) this.Panel1);
    this.PanelContent.Controls.Add((Control) this.grdLineOfBusiness);
    this.PanelContent.Dock = DockStyle.Left;
    this.PanelContent.Location = new Point(0, 27);
    this.PanelContent.Name = "PanelContent";
    this.PanelContent.Size = new Size(514, 631);
    this.PanelContent.TabIndex = 12;
    this.Panel1.Controls.Add((Control) this.llSelectNoneLOB);
    this.Panel1.Controls.Add((Control) this.llSelectAllLOB);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 605);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(514, 26);
    this.Panel1.TabIndex = 12;
    this.llSelectNoneLOB.AutoSize = true;
    this.llSelectNoneLOB.Location = new Point(158, 9);
    this.llSelectNoneLOB.Name = "llSelectNoneLOB";
    this.llSelectNoneLOB.Size = new Size(150, 13);
    this.llSelectNoneLOB.TabIndex = 11;
    this.llSelectNoneLOB.TabStop = true;
    this.llSelectNoneLOB.Text = "Unselect All Lines Of Business";
    this.llSelectAllLOB.AutoSize = true;
    this.llSelectAllLOB.Location = new Point(3, 9);
    this.llSelectAllLOB.Name = "llSelectAllLOB";
    this.llSelectAllLOB.Size = new Size(146, 13);
    this.llSelectAllLOB.TabIndex = 10;
    this.llSelectAllLOB.TabStop = true;
    this.llSelectAllLOB.Text = "Select All Lines Of Business /";
    ((Control) this.grdLineOfBusiness).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.grdLineOfBusiness).DataSource = (object) this.LinesOfBusinessBindingSource;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 59;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Lines Of Business";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.VertScrollBar = true;
    ultraGridColumn2.Width = 472;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 234;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellClickAction = (CellClickAction) 1;
    ultraGridColumn4.DataType = typeof (bool);
    ultraGridColumn4.DefaultCellValue = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraGridColumn4.DefaultCellValue"));
    ((HeaderBase) ultraGridColumn4.Header).Caption = "";
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.MaxWidth = 35;
    ultraGridColumn4.Width = 18;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((HeaderBase) ultraGridBand.Header).Caption = "Lines Of Business";
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.MaxSelectedRows = 50;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.grdLineOfBusiness).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grdLineOfBusiness).Location = new Point(0, 0);
    ((Control) this.grdLineOfBusiness).MaximumSize = new Size(492, 600);
    ((Control) this.grdLineOfBusiness).Name = "grdLineOfBusiness";
    ((Control) this.grdLineOfBusiness).Size = new Size(492, 600);
    ((Control) this.grdLineOfBusiness).TabIndex = 10;
    ((UltraControlBase) this.grdLineOfBusiness).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdLineOfBusiness).UseOsThemes = (DefaultableBoolean) 2;
    this.LinesOfBusinessBindingSource.DataMember = "LinesOfBusiness";
    this.LinesOfBusinessBindingSource.DataSource = (object) this.DsCRMSelectionCriteria;
    this.DsCRMSelectionCriteria.DataSetName = "dsCRMSelectionCriteria";
    this.DsCRMSelectionCriteria.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelHeader.BackColor = Color.White;
    this.panelHeader.Controls.Add((Control) this.Label1);
    this.panelHeader.Dock = DockStyle.Top;
    this.panelHeader.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.panelHeader.Location = new Point(0, 0);
    this.panelHeader.Name = "panelHeader";
    this.panelHeader.Size = new Size(737, 27);
    this.panelHeader.TabIndex = 11;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.Label1.Location = new Point(3, 4);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(347, 14);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select the line(s) of business you want to target";
    this.LinesOfBusinessBindingSource1.DataMember = "LinesOfBusiness";
    this.LinesOfBusinessBindingSource1.DataSource = (object) this.DsCRMSelectionCriteria;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.pnlQueryParams);
    this.Name = nameof (CRMEmail_LinesOfBusiness);
    this.Size = new Size(737, 658);
    this.pnlQueryParams.ResumeLayout(false);
    this.PanelContent.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.grdLineOfBusiness).EndInit();
    ((ISupportInitialize) this.LinesOfBusinessBindingSource).EndInit();
    this.DsCRMSelectionCriteria.EndInit();
    this.panelHeader.ResumeLayout(false);
    this.panelHeader.PerformLayout();
    ((ISupportInitialize) this.LinesOfBusinessBindingSource1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("pnlQueryParams")]
  internal virtual Panel pnlQueryParams { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LinesOfBusinessBindingSource")]
  internal virtual BindingSource LinesOfBusinessBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsCRMSelectionCriteria")]
  internal virtual dsCRMSelectionCriteria DsCRMSelectionCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LinesOfBusinessBindingSource1")]
  internal virtual BindingSource LinesOfBusinessBindingSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelHeader")]
  internal virtual Panel panelHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PanelContent")]
  internal virtual Panel PanelContent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid grdLineOfBusiness
  {
    get => this._grdLineOfBusiness;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ClickCellEventHandler cellEventHandler = new ClickCellEventHandler(this.grdLineOfBusiness_ClickCell);
      UltraGrid grdLineOfBusiness1 = this._grdLineOfBusiness;
      if (grdLineOfBusiness1 != null)
        grdLineOfBusiness1.ClickCell -= cellEventHandler;
      this._grdLineOfBusiness = value;
      UltraGrid grdLineOfBusiness2 = this._grdLineOfBusiness;
      if (grdLineOfBusiness2 == null)
        return;
      grdLineOfBusiness2.ClickCell += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel llSelectNoneLOB
  {
    get => this._llSelectNoneLOB;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.llSelectNoneLOB_LinkClicked);
      LinkLabel llSelectNoneLob1 = this._llSelectNoneLOB;
      if (llSelectNoneLob1 != null)
        llSelectNoneLob1.LinkClicked -= clickedEventHandler;
      this._llSelectNoneLOB = value;
      LinkLabel llSelectNoneLob2 = this._llSelectNoneLOB;
      if (llSelectNoneLob2 == null)
        return;
      llSelectNoneLob2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel llSelectAllLOB
  {
    get => this._llSelectAllLOB;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.llSelectAllLOB_LinkClicked);
      LinkLabel llSelectAllLob1 = this._llSelectAllLOB;
      if (llSelectAllLob1 != null)
        llSelectAllLob1.LinkClicked -= clickedEventHandler;
      this._llSelectAllLOB = value;
      LinkLabel llSelectAllLob2 = this._llSelectAllLOB;
      if (llSelectAllLob2 == null)
        return;
      llSelectAllLob2.LinkClicked += clickedEventHandler;
    }
  }

  public CRMEmail_LinesOfBusiness()
  {
    this._selectedLines = new string[2, 1001];
    this._selectedLineIDs = new string[1001];
    this.InitializeComponent();
  }

  public CRMEmail_LinesOfBusiness(
    dsCRMSelectionCriteria.LinesOfBusinessDataTable data)
  {
    this._selectedLines = new string[2, 1001];
    this._selectedLineIDs = new string[1001];
    this.InitializeComponent();
    this._data = data;
    this.SetGridDataSource();
  }

  public UltraGrid SelectedLinesOfBusinessGrid => this.grdLineOfBusiness;

  private void SetGridDataSource()
  {
    ((UltraGridBase) this.grdLineOfBusiness).DataSource = (object) this._data;
    this._selectedLines = new string[2, this._data.Count + 1];
    this._selectedLineIDs = new string[this._data.Count + 1];
  }

  public string GetDynamicLineOfBusinessList()
  {
    int index1 = 0;
    string lineOfBusinessList = string.Empty;
    string empty = string.Empty;
    string[] strArray = new string[((UltraGridBase) this.grdLineOfBusiness).Rows.Count + 1];
    int num = ((UltraGridBase) this.grdLineOfBusiness).Rows.Count - 1;
    for (int index2 = 0; index2 <= num; ++index2)
    {
      if (Conversions.ToBoolean(((UltraGridBase) this.grdLineOfBusiness).Rows[index2].Cells[3].Value))
      {
        if (index1 == 0)
        {
          lineOfBusinessList = ((UltraGridBase) this.grdLineOfBusiness).Rows[index2].Cells["LineGUID"].Value.ToString();
          ++index1;
        }
        else
        {
          strArray[index1] = ((UltraGridBase) this.grdLineOfBusiness).Rows[index2].Cells["LineGUID"].Value.ToString();
          lineOfBusinessList = $"{lineOfBusinessList},{((UltraGridBase) this.grdLineOfBusiness).Rows[index2].Cells["LineGUID"].Value.ToString()}";
          ++index1;
        }
      }
    }
    return lineOfBusinessList;
  }

  private void AddValueToArray(int ArrayLocation, string LineNameText, string LineGuidText)
  {
    this._selectedLines[0, this._arrayCount] = LineNameText;
    this._selectedLines[1, this._arrayCount] = LineGuidText;
    this._selectedLineIDs[this._arrayCount] = LineNameText;
  }

  private void RemoveValueFromArray(string LineNameText)
  {
    int index = Array.IndexOf<string>(this._selectedLineIDs, LineNameText);
    if (index < 0)
      return;
    this._selectedLines[0, index] = (string) null;
    this._selectedLines[1, index] = (string) null;
    this._selectedLineIDs[index] = (string) null;
  }

  private void grdLineOfBusiness_ClickCell(object sender, ClickCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.DataType.FullName.ToString(), "System.Boolean", false) != 0)
      return;
    string LineGuidText = ((UltraGridBase) this.grdLineOfBusiness).ActiveRow.Cells["LineGUID"].Value.ToString();
    string LineNameText = ((UltraGridBase) this.grdLineOfBusiness).ActiveRow.Cells["LineName"].Value.ToString();
    if (!Conversions.ToBoolean(((UltraGridBase) this.grdLineOfBusiness).ActiveRow.Cells["Select"].Value))
    {
      if (Array.IndexOf<string>(this._selectedLineIDs, LineNameText) == -1)
        this.AddValueToArray(this._arrayCount, LineNameText, LineGuidText);
      else
        this.RemoveValueFromArray(LineNameText);
    }
    else
      this.RemoveValueFromArray(LineNameText);
    this.WriteLOBList(this._selectedLines);
    ++this._arrayCount;
  }

  private void WriteLOBList(string[,] LineList)
  {
    bool flag = false;
    int num = this._data.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!string.IsNullOrEmpty(this._selectedLines[0, index]))
      {
        if (!flag)
        {
          FormCRMEmailer.displaySelectedLOB = this._selectedLines[0, index];
          flag = true;
        }
        else
          FormCRMEmailer.displaySelectedLOB = $"{FormCRMEmailer.displaySelectedLOB}, and{Strings.Space(1)}{this._selectedLines[0, index]}";
      }
    }
  }

  private void llSelectAllLOB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._arrayCount = 0;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.grdLineOfBusiness).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        ultraGridRow.Cells["Select"].SetValue((object) true, false);
        string LineGuidText = ultraGridRow.Cells["LineGUID"].Value.ToString();
        string LineNameText = ultraGridRow.Cells["LineName"].Value.ToString();
        Conversions.ToBoolean(ultraGridRow.Cells["Select"].Value);
        this.AddValueToArray(this._arrayCount, LineNameText, LineGuidText);
        this.WriteLOBList(this._selectedLines);
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = ^(local = ref this._arrayCount) + 1;
        local = num;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void llSelectNoneLOB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._arrayCount = 0;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.grdLineOfBusiness).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        ultraGridRow.Cells["Select"].SetValue((object) false, false);
        ultraGridRow.Cells["LineGUID"].Value.ToString();
        string LineNameText = ultraGridRow.Cells["LineName"].Value.ToString();
        Conversions.ToBoolean(ultraGridRow.Cells["Select"].Value);
        this.RemoveValueFromArray(LineNameText);
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = ^(local = ref this._arrayCount) + 1;
        local = num;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._arrayCount = 0;
    this._selectedLines[0, 0] = "None";
    this._selectedLines[1, 0] = "None Selected";
    this.WriteLOBList(this._selectedLines);
  }
}
