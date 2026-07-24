// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.CRMEmail_States
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
public class CRMEmail_States : UserControl
{
  private IContainer components;
  private dsCRMSelectionCriteria.StatesDataTable _data;
  private string[,] _selectedStates;
  private string[] _selectedStateIDs;
  private int _arrayCount;
  private FormCRMEmailer _formCRMEmailer;
  private CRMEmail_SelectionStatus _crmSelectionStatus;

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
    UltraGridBand ultraGridBand = new UltraGridBand("States", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("StateName");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SELECT", 0);
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CRMEmail_States));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.gridStates = new UltraGrid();
    this.DsCRMSelectionCriteria1 = new dsCRMSelectionCriteria();
    this.panelHeader = new Panel();
    this.Label1 = new Label();
    this.panelContent = new Panel();
    this.Panel1 = new Panel();
    this.llSelectNone = new LinkLabel();
    this.llSelectAll = new LinkLabel();
    ((ISupportInitialize) this.gridStates).BeginInit();
    this.DsCRMSelectionCriteria1.BeginInit();
    this.panelHeader.SuspendLayout();
    this.panelContent.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    ((Control) this.gridStates).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridStates).DataSource = (object) this.DsCRMSelectionCriteria1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridStates).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 349;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "State";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 430;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellClickAction = (CellClickAction) 1;
    ultraGridColumn3.DataType = typeof (bool);
    ultraGridColumn3.DefaultCellValue = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraGridColumn3.DefaultCellValue"));
    ((HeaderBase) ultraGridColumn3.Header).Caption = "";
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Style = (ColumnStyle) 3;
    ultraGridColumn3.Width = 60;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.gridStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.MaxSelectedRows = 50;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.gridStates).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridStates).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridStates).Location = new Point(0, 0);
    ((Control) this.gridStates).MaximumSize = new Size(492, 513);
    ((Control) this.gridStates).Name = "gridStates";
    ((Control) this.gridStates).Size = new Size(492, 513);
    ((Control) this.gridStates).TabIndex = 9;
    ((UltraControlBase) this.gridStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridStates).UseOsThemes = (DefaultableBoolean) 2;
    this.DsCRMSelectionCriteria1.DataSetName = "dsCRMSelectionCriteria";
    this.DsCRMSelectionCriteria1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelHeader.BackColor = Color.Transparent;
    this.panelHeader.Controls.Add((Control) this.Label1);
    this.panelHeader.Dock = DockStyle.Top;
    this.panelHeader.Location = new Point(0, 0);
    this.panelHeader.Name = "panelHeader";
    this.panelHeader.Size = new Size(700, 27);
    this.panelHeader.TabIndex = 10;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.Label1.Location = new Point(3, 4);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(426, 14);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select the state(s) in which the producer(s) writes business...";
    this.panelContent.BackColor = Color.Transparent;
    this.panelContent.Controls.Add((Control) this.Panel1);
    this.panelContent.Controls.Add((Control) this.gridStates);
    this.panelContent.Dock = DockStyle.Left;
    this.panelContent.Location = new Point(0, 27);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(500, 545);
    this.panelContent.TabIndex = 11;
    this.Panel1.Controls.Add((Control) this.llSelectNone);
    this.Panel1.Controls.Add((Control) this.llSelectAll);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 519);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(500, 26);
    this.Panel1.TabIndex = 11;
    this.llSelectNone.AutoSize = true;
    this.llSelectNone.Location = new Point(100, 9);
    this.llSelectNone.Name = "llSelectNone";
    this.llSelectNone.Size = new Size(96 /*0x60*/, 13);
    this.llSelectNone.TabIndex = 11;
    this.llSelectNone.TabStop = true;
    this.llSelectNone.Text = "Unselect All States";
    this.llSelectAll.AutoSize = true;
    this.llSelectAll.Location = new Point(3, 9);
    this.llSelectAll.Name = "llSelectAll";
    this.llSelectAll.Size = new Size(91, 13);
    this.llSelectAll.TabIndex = 10;
    this.llSelectAll.TabStop = true;
    this.llSelectAll.Text = "Select All States /";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelHeader);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (CRMEmail_States);
    this.Size = new Size(700, 572);
    ((ISupportInitialize) this.gridStates).EndInit();
    this.DsCRMSelectionCriteria1.EndInit();
    this.panelHeader.ResumeLayout(false);
    this.panelHeader.PerformLayout();
    this.panelContent.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual UltraGrid gridStates
  {
    get => this._gridStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ClickCellEventHandler cellEventHandler = new ClickCellEventHandler(this.gridStates_ClickCell);
      UltraGrid gridStates1 = this._gridStates;
      if (gridStates1 != null)
        gridStates1.ClickCell -= cellEventHandler;
      this._gridStates = value;
      UltraGrid gridStates2 = this._gridStates;
      if (gridStates2 == null)
        return;
      gridStates2.ClickCell += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsCRMSelectionCriteria1")]
  internal virtual dsCRMSelectionCriteria DsCRMSelectionCriteria1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelHeader")]
  internal virtual Panel panelHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelContent")]
  internal virtual Panel panelContent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel llSelectNone
  {
    get => this._llSelectNone;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.llSelectNone_LinkClicked);
      LinkLabel llSelectNone1 = this._llSelectNone;
      if (llSelectNone1 != null)
        llSelectNone1.LinkClicked -= clickedEventHandler;
      this._llSelectNone = value;
      LinkLabel llSelectNone2 = this._llSelectNone;
      if (llSelectNone2 == null)
        return;
      llSelectNone2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel llSelectAll
  {
    get => this._llSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.llSelectAll_LinkClicked);
      LinkLabel llSelectAll1 = this._llSelectAll;
      if (llSelectAll1 != null)
        llSelectAll1.LinkClicked -= clickedEventHandler;
      this._llSelectAll = value;
      LinkLabel llSelectAll2 = this._llSelectAll;
      if (llSelectAll2 == null)
        return;
      llSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  public CRMEmail_States()
  {
    this._selectedStates = new string[2, 50];
    this._selectedStateIDs = new string[50];
    this._arrayCount = 0;
    this.InitializeComponent();
  }

  public CRMEmail_States(dsCRMSelectionCriteria.StatesDataTable data)
  {
    this._selectedStates = new string[2, 50];
    this._selectedStateIDs = new string[50];
    this._arrayCount = 0;
    this.InitializeComponent();
    this._data = data;
    this.SetGridDataSource();
  }

  public UltraGrid SelectedStatesGrid => this.gridStates;

  private void SetGridDataSource()
  {
    ((UltraGridBase) this.gridStates).DataSource = (object) this._data;
    this._selectedStates = new string[2, this._data.Count + 1 + 1];
    this._selectedStateIDs = new string[this._data.Count + 1 + 1];
  }

  public string GetDynamicLocationSQL()
  {
    int num1 = 0;
    int num2 = 0;
    string dynamicLocationSql = string.Empty;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.gridStates).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (Conversions.ToBoolean(((UltraGridBase) this.gridStates).Rows[num1].Cells[2].Value))
        {
          if (num2 == 0)
          {
            dynamicLocationSql = ((UltraGridBase) this.gridStates).Rows[num1].Cells["StateID"].Value.ToString();
            ++num2;
          }
          else
          {
            dynamicLocationSql = $"{dynamicLocationSql},{((UltraGridBase) this.gridStates).Rows[num1].Cells["StateID"].Value.ToString()}";
            ++num2;
          }
        }
        ++num1;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return dynamicLocationSql;
  }

  private void gridStates_ClickCell(object sender, ClickCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.DataType.FullName.ToString(), "System.Boolean", false) != 0)
      return;
    string str = ((UltraGridBase) this.gridStates).ActiveRow.Cells["StateID"].Value.ToString();
    string StateNameText = ((UltraGridBase) this.gridStates).ActiveRow.Cells["StateName"].Value.ToString();
    if (!Conversions.ToBoolean(((UltraGridBase) this.gridStates).ActiveRow.Cells["Select"].Value))
    {
      if (Array.IndexOf<string>(this._selectedStateIDs, str) == -1)
        this.AddValueToArray(this._arrayCount, str, StateNameText);
      else
        this.RemoveValueFromArray(str);
    }
    else
      this.RemoveValueFromArray(str);
    this.WriteStateList(this._selectedStates);
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this._arrayCount) + 1;
    local = num;
  }

  private void AddValueToArray(int ArrayLocation, string StateIdText, string StateNameText)
  {
    this._selectedStates[0, this._arrayCount] = StateIdText;
    this._selectedStates[1, this._arrayCount] = StateNameText;
    this._selectedStateIDs[this._arrayCount] = StateIdText;
  }

  private void RemoveValueFromArray(string StateIDText)
  {
    int index = Array.IndexOf<string>(this._selectedStateIDs, StateIDText);
    if (index < 0)
      return;
    this._selectedStates[0, index] = string.Empty;
    this._selectedStates[1, index] = string.Empty;
    this._selectedStateIDs[index] = string.Empty;
  }

  private void WriteStateList(string[,] StateList)
  {
    bool flag = false;
    int num = this._data.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!string.IsNullOrEmpty(this._selectedStates[1, index]))
      {
        if (!flag)
        {
          FormCRMEmailer.displaySelectedStates = this._selectedStates[1, index];
          flag = true;
        }
        else
          FormCRMEmailer.displaySelectedStates = $"{FormCRMEmailer.displaySelectedStates},{Strings.Space(1)}{this._selectedStates[1, index]}";
      }
    }
  }

  private void llSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._arrayCount = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridStates).Rows)
    {
      row.Cells["Select"].SetValue((object) true, false);
      this.AddValueToArray(this._arrayCount, row.Cells["StateID"].Value.ToString(), row.Cells["StateName"].Value.ToString());
      this.WriteStateList(this._selectedStates);
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this._arrayCount) + 1;
      local = num;
    }
  }

  private void llSelectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._arrayCount = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridStates).Rows)
    {
      row.Cells["Select"].SetValue((object) false, false);
      string StateIDText = row.Cells["StateID"].Value.ToString();
      row.Cells["StateName"].Value.ToString();
      this.RemoveValueFromArray(StateIDText);
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this._arrayCount) + 1;
      local = num;
    }
    this._arrayCount = 0;
    this._selectedStates[0, 0] = "None";
    this._selectedStates[1, 0] = "None Selected";
    this.WriteStateList(this._selectedStates);
  }
}
