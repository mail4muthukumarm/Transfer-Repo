// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CompanyLocationProgramCode
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

[DesignerGenerated]
public class CompanyLocationProgramCode : BaseReportControl
{
  private IContainer components;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyProgramCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("IsSelected");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Display");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Value");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLocationGuid");
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
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("IsSelected");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Display");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Value");
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
    this.label1 = new Label();
    this.ugProgramCodes = new UltraGrid();
    this.ugCarriers = new UltraGrid();
    this.ds = new dsCompanyLocProgCode();
    this.dvProgCodes = new DataView();
    ((ISupportInitialize) this.ugProgramCodes).BeginInit();
    ((ISupportInitialize) this.ugCarriers).BeginInit();
    this.ds.BeginInit();
    this.dvProgCodes.BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 38);
    this.label1.AutoSize = true;
    this.label1.Location = new Point(0, 171);
    this.label1.Name = "label1";
    this.label1.Size = new Size(77, 13);
    this.label1.TabIndex = 9;
    this.label1.Text = "Program Code:";
    ((UltraGridBase) this.ugProgramCodes).DataSource = (object) this.dvProgCodes;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "";
    ultraGridColumn1.Header.CheckBoxVisibility = (HeaderCheckBoxVisibility) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 274;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProgramCodes).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProgramCodes).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ugProgramCodes).DisplayLayout.ViewStyleBand = (ViewStyleBand) 1;
    ((Control) this.ugProgramCodes).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugProgramCodes).Location = new Point(102, 155);
    ((Control) this.ugProgramCodes).Name = "ugProgramCodes";
    ((Control) this.ugProgramCodes).Size = new Size(423, 148);
    ((Control) this.ugProgramCodes).TabIndex = 8;
    ((Control) this.ugProgramCodes).Text = "UltraGrid1";
    ((UltraGridBase) this.ugCarriers).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ugCarriers).DataSource = (object) this.ds;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "";
    ultraGridColumn5.Header.CheckBoxVisibility = (HeaderCheckBoxVisibility) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 270;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ugCarriers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugCarriers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ActiveBorder;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ugCarriers).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) this.ugCarriers).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = SystemColors.ControlLightLight;
    appearance16.BackColor2 = SystemColors.Control;
    appearance16.BackGradientStyle = (GradientStyle) 3;
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.MaxRowScrollRegions = 1;
    appearance17.BackColor = SystemColors.Window;
    appearance17.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Highlight;
    appearance18.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance19.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.Silver;
    appearance20.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.CellPadding = 0;
    appearance21.BackColor = SystemColors.Control;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientAlignment = (GradientAlignment) 1;
    appearance21.BackGradientStyle = (GradientStyle) 3;
    appearance21.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.ViewStyleBand = (ViewStyleBand) 1;
    ((Control) this.ugCarriers).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugCarriers).Location = new Point(102, 7);
    ((Control) this.ugCarriers).Name = "ugCarriers";
    ((Control) this.ugCarriers).Size = new Size(423, 125);
    ((Control) this.ugCarriers).TabIndex = 7;
    ((Control) this.ugCarriers).Text = "UltraGrid1";
    this.ds.DataSetName = "dsCompanyLocProgCode";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dvProgCodes.Table = (DataTable) this.ds.tblCompanyProgramCodes;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.ugProgramCodes);
    this.Controls.Add((Control) this.ugCarriers);
    this.Name = nameof (CompanyLocationProgramCode);
    this.Size = new Size(532, 327);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.ugCarriers, 0);
    this.Controls.SetChildIndex((Control) this.ugProgramCodes, 0);
    this.Controls.SetChildIndex((Control) this.label1, 0);
    ((ISupportInitialize) this.ugProgramCodes).EndInit();
    ((ISupportInitialize) this.ugCarriers).EndInit();
    this.ds.EndInit();
    this.dvProgCodes.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugProgramCodes")]
  internal virtual UltraGrid ugProgramCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugCarriers")]
  internal virtual UltraGrid ugCarriers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLocProgCode ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvProgCodes")]
  private virtual DataView dvProgCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public override object Value
  {
    get
    {
      dsCompanyLocProgCode.tblCompanyLocationsDataTable companyLocations = this.ds.tblCompanyLocations;
      System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool> predicate;
      if (CompanyLocationProgramCode._Closure\u0024__.\u0024I24\u002D0 != null)
        predicate = CompanyLocationProgramCode._Closure\u0024__.\u0024I24\u002D0;
      else
        CompanyLocationProgramCode._Closure\u0024__.\u0024I24\u002D0 = predicate = (System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool>) ([SpecialName] (s) => s.IsSelected);
      EnumerableRowCollection<dsCompanyLocProgCode.tblCompanyLocationsRow> source = companyLocations.Where<dsCompanyLocProgCode.tblCompanyLocationsRow>(predicate);
      System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, object> selector;
      if (CompanyLocationProgramCode._Closure\u0024__.\u0024I24\u002D1 != null)
        selector = CompanyLocationProgramCode._Closure\u0024__.\u0024I24\u002D1;
      else
        CompanyLocationProgramCode._Closure\u0024__.\u0024I24\u002D1 = selector = (System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, object>) ([SpecialName] (g) => g[nameof (Value)]);
      return (object) new object[2]
      {
        (object) string.Join<object>(",", (IEnumerable<object>) source.Select<dsCompanyLocProgCode.tblCompanyLocationsRow, object>(selector)),
        (object) string.Join(",", (IEnumerable<string>) this.ProgramCodeList())
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      if (objArray[0] != null)
      {
        string[] strArray = objArray[0].ToString().Split(',');
        int index = 0;
        while (index < strArray.Length)
        {
          CompanyLocationProgramCode._Closure\u0024__25\u002D0 closure250 = new CompanyLocationProgramCode._Closure\u0024__25\u002D0(closure250);
          closure250.\u0024VB\u0024Local_s = strArray[index];
          dsCompanyLocProgCode.tblCompanyLocationsRow companyLocationsRow = this.ds.tblCompanyLocations.Where<dsCompanyLocProgCode.tblCompanyLocationsRow>(new System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool>(closure250._Lambda\u0024__0)).FirstOrDefault<dsCompanyLocProgCode.tblCompanyLocationsRow>();
          if (companyLocationsRow != null)
            companyLocationsRow.IsSelected = true;
          checked { ++index; }
        }
      }
      if (objArray[1] == null)
        return;
      string[] strArray1 = objArray[1].ToString().Split(',');
      int index1 = 0;
      while (index1 < strArray1.Length)
      {
        CompanyLocationProgramCode._Closure\u0024__25\u002D1 closure251 = new CompanyLocationProgramCode._Closure\u0024__25\u002D1(closure251);
        closure251.\u0024VB\u0024Local_s = strArray1[index1];
        dsCompanyLocProgCode.tblCompanyProgramCodesRow companyProgramCodesRow = this.ds.tblCompanyProgramCodes.Where<dsCompanyLocProgCode.tblCompanyProgramCodesRow>(new System.Func<dsCompanyLocProgCode.tblCompanyProgramCodesRow, bool>(closure251._Lambda\u0024__1)).FirstOrDefault<dsCompanyLocProgCode.tblCompanyProgramCodesRow>();
        if (companyProgramCodesRow != null)
          companyProgramCodesRow.IsSelected = true;
        checked { ++index1; }
      }
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      dsCompanyLocProgCode.tblCompanyLocationsDataTable companyLocations = this.ds.tblCompanyLocations;
      System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool> predicate;
      if (CompanyLocationProgramCode._Closure\u0024__.\u0024I27\u002D0 != null)
        predicate = CompanyLocationProgramCode._Closure\u0024__.\u0024I27\u002D0;
      else
        CompanyLocationProgramCode._Closure\u0024__.\u0024I27\u002D0 = predicate = (System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool>) ([SpecialName] (s) => s.IsSelected);
      int num = companyLocations.Where<dsCompanyLocProgCode.tblCompanyLocationsRow>(predicate).Count<dsCompanyLocProgCode.tblCompanyLocationsRow>();
      int count = this.ProgramCodeList().Count;
      return num != 0 || count != 0 ? (num != 0 ? (count != 0 ? (string) null : "Please select program code(s) from the list.") : "Please select company location(s) from the list.") : "Please select company location(s) and program code(s) from the list.";
    }
  }

  public CompanyLocationProgramCode(string companyLocationLabelText, string storedProcedureName)
  {
    this.InitializeComponent();
    this.Description = companyLocationLabelText;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "tblCompanyLocations",
      "tblCompanyProgramCodes"
    }, storedProcedureName);
    this.ugCarriers.CellChange += new CellEventHandler(this.ugCarriers_CellChange);
    ((UltraGridBase) this.ugCarriers).AfterHeaderCheckStateChanged += new AfterHeaderCheckStateChangedEventHandler(this.ugCarriers_AfterHeaderCheckStateChanged);
  }

  private void ugCarriers_AfterHeaderCheckStateChanged(
    object sender,
    AfterHeaderCheckStateChangedEventArgs e)
  {
    this.SetProgramCodeFilter();
  }

  private void ugCarriers_CellChange(object sender, CellEventArgs e)
  {
    if (!e.Cell.Column.Key.Equals("IsSelected"))
      return;
    ((UltraGridBase) this.ugCarriers).UpdateData();
    this.SetProgramCodeFilter();
  }

  private void SetProgramCodeFilter()
  {
    dsCompanyLocProgCode.tblCompanyLocationsDataTable companyLocations1 = this.ds.tblCompanyLocations;
    System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool> predicate1;
    // ISSUE: reference to a compiler-generated field
    if (CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate1 = CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D0 = predicate1 = (System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool>) ([SpecialName] (s) => s.IsSelected);
    }
    if (companyLocations1.Where<dsCompanyLocProgCode.tblCompanyLocationsRow>(predicate1).Count<dsCompanyLocProgCode.tblCompanyLocationsRow>() == 0)
    {
      this.dvProgCodes.RowFilter = $"CompanyLocationGuid = '{Guid.Empty}'";
    }
    else
    {
      dsCompanyLocProgCode.tblCompanyLocationsDataTable companyLocations2 = this.ds.tblCompanyLocations;
      System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool> predicate2;
      // ISSUE: reference to a compiler-generated field
      if (CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate2 = CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D1 = predicate2 = (System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, bool>) ([SpecialName] (s) => s.IsSelected);
      }
      EnumerableRowCollection<dsCompanyLocProgCode.tblCompanyLocationsRow> source = companyLocations2.Where<dsCompanyLocProgCode.tblCompanyLocationsRow>(predicate2);
      System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        CompanyLocationProgramCode._Closure\u0024__.\u0024I31\u002D2 = selector = (System.Func<dsCompanyLocProgCode.tblCompanyLocationsRow, string>) ([SpecialName] (g) => $"'{RuntimeHelpers.GetObjectValue(g["Value"])}' OR ");
      }
      string str = $"CompanyLocationGuid = {string.Join("CompanyLocationGuid = ", (IEnumerable<string>) source.Select<dsCompanyLocProgCode.tblCompanyLocationsRow, string>(selector))}";
      this.dvProgCodes.RowFilter = str.Remove(str.Length - 4);
    }
  }

  private List<string> ProgramCodeList()
  {
    List<string> stringList = new List<string>();
    DataTable table = this.dvProgCodes.ToTable();
    try
    {
      foreach (DataRow row in table.Rows)
      {
        if (row.Field<bool>("IsSelected"))
          stringList.Add(row.Field<string>("Value"));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return stringList;
  }
}
