// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormITVCalculator
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormITVCalculator : Form
{
  private IContainer components;
  private Label lblCompanyName;
  private Label lblInsured;
  private Label lblDate;
  private UltraGrid gridFilingInformation;
  private dsITVCalculator ds;
  private Quote _q;
  private Guid _quoteGuid;
  private bool _isUsingNetrate;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("City", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClassCodeID", -1, (object) "ddOccupancy");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SqFootage");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Stories");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("YearBuilt");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ConstructionID", -1, (object) "ddConstClass");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("RepLCost");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ACV");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("SprinklerTypeID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Elevators");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LocationID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstConstructionTypes", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ConstructionTypeID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Type");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstClassCodes", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ClassCodeDescription");
    this.lblCompanyName = new Label();
    this.lblInsured = new Label();
    this.lblDate = new Label();
    this.gridFilingInformation = new UltraGrid();
    this.daGetBaseValuation = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.daGetBuildingStories = DefaultDatabase.CreateDataAdapter();
    this.DbCommand1 = DefaultDatabase.CreateCommand();
    this.daGetDepreciation = DefaultDatabase.CreateDataAdapter();
    this.DbCommand2 = DefaultDatabase.CreateCommand();
    this.daGetMiscFactors = DefaultDatabase.CreateDataAdapter();
    this.DbCommand3 = DefaultDatabase.CreateCommand();
    this.daGetTerritories = DefaultDatabase.CreateDataAdapter();
    this.DbCommand4 = DefaultDatabase.CreateCommand();
    this.daGetLocations = DefaultDatabase.CreateDataAdapter();
    this.DbCommand5 = DefaultDatabase.CreateCommand();
    this.daGetNetRateLocations = DefaultDatabase.CreateDataAdapter();
    this.DbCommand6 = DefaultDatabase.CreateCommand();
    this.ugITV = new UltraGrid();
    this.linkViewReport = new LinkLabel();
    this.lnkSendToDocHandler = new LinkLabel();
    this.ddConstClass = new UltraDropDown();
    this.ds = new dsITVCalculator();
    this.ddOccupancy = new UltraDropDown();
    this.lblTerrCostText = new Label();
    this.lblTerritoryCost = new Label();
    ((ISupportInitialize) this.gridFilingInformation).BeginInit();
    ((ISupportInitialize) this.ugITV).BeginInit();
    ((ISupportInitialize) this.ddConstClass).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddOccupancy).BeginInit();
    this.SuspendLayout();
    this.lblCompanyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblCompanyName.AutoSize = true;
    this.lblCompanyName.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.lblCompanyName.Location = new Point(210, 9);
    this.lblCompanyName.Name = "lblCompanyName";
    this.lblCompanyName.Size = new Size(335, 13);
    this.lblCompanyName.TabIndex = 0;
    this.lblCompanyName.Text = "CompanyName Goes Here - Insurance to Value Calculation";
    this.lblInsured.AutoSize = true;
    this.lblInsured.Location = new Point(9, 23);
    this.lblInsured.Name = "lblInsured";
    this.lblInsured.Size = new Size((int) sbyte.MaxValue, 13);
    this.lblInsured.TabIndex = 1;
    this.lblInsured.Text = "Insured Name Goes Here";
    this.lblDate.AutoSize = true;
    this.lblDate.Location = new Point(9, 46);
    this.lblDate.Name = "lblDate";
    this.lblDate.Size = new Size(123, 13);
    this.lblDate.TabIndex = 2;
    this.lblDate.Text = "Today's Date Goes Here";
    ((Control) this.gridFilingInformation).Location = new Point(0, 0);
    ((Control) this.gridFilingInformation).Name = "gridFilingInformation";
    ((Control) this.gridFilingInformation).Size = new Size(550, 80 /*0x50*/);
    ((Control) this.gridFilingInformation).TabIndex = 0;
    this.daGetBaseValuation.SelectCommand = this.DbSelectCommand1;
    this.daGetBaseValuation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblITVCalculatorBaseValuation", new DataColumnMapping[4]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("ClassCode", "ClassCode"),
        new DataColumnMapping("ConstCode", "ConstCode"),
        new DataColumnMapping("BaseValuation", "BaseValuation")
      })
    });
    this.DbSelectCommand1.CommandText = "SELECT     ID, ClassCode, ConstCode, BaseValuation\r\nFROM         dbo.tblITVCalculatorBaseValuation";
    this.daGetBuildingStories.SelectCommand = this.DbCommand1;
    this.daGetBuildingStories.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblITVCalculatorBuildingStories", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("NumberofStories", "NumberofStories")
      })
    });
    this.DbCommand1.CommandText = "SELECT     ID, NumberofStories, Factor\r\nFROM         dbo.tblITVCalculatorBuildingStories";
    this.daGetDepreciation.SelectCommand = this.DbCommand2;
    this.daGetDepreciation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblITVCalculatorDepreciation", new DataColumnMapping[3]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("YearBuilt", "YearBuilt"),
        new DataColumnMapping("Factor", "Factor")
      })
    });
    this.DbCommand2.CommandText = "SELECT     YearBuilt, Factor, ID\r\nFROM         dbo.tblITVCalculatorDepreciation";
    this.daGetMiscFactors.SelectCommand = this.DbCommand3;
    this.daGetMiscFactors.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblITVCalculatorMiscFactors", new DataColumnMapping[3]
      {
        new DataColumnMapping("FactorType", "FactorType"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Factor", "Factor")
      })
    });
    this.DbCommand3.CommandText = "SELECT     FactorType, ID, Factor\r\nFROM         dbo.tblITVCalculatorMiscFactors";
    this.daGetTerritories.SelectCommand = this.DbCommand4;
    this.daGetTerritories.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblITVCalculatorTerritories", new DataColumnMapping[3]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("Factor", "Factor")
      })
    });
    this.DbCommand4.CommandText = "SELECT     ZipCode, Factor, ID\r\nFROM         dbo.tblITVCalculatorTerritories";
    this.daGetLocations.SelectCommand = this.DbCommand5;
    this.daGetLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[8]
      {
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("Stories", "Stories"),
        new DataColumnMapping("SqFootage", "SqFootage"),
        new DataColumnMapping("YearBuilt", "YearBuilt"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID")
      })
    });
    this.DbCommand5.CommandText = "[getUnderwritingLocations]";
    this.DbCommand5.CommandType = CommandType.StoredProcedure;
    this.DbCommand5.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.daGetNetRateLocations.SelectCommand = this.DbCommand6;
    this.daGetNetRateLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUnderwritingLocations", new DataColumnMapping[8]
      {
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("Stories", "Stories"),
        new DataColumnMapping("SqFootage", "SqFootage"),
        new DataColumnMapping("YearBuilt", "YearBuilt"),
        new DataColumnMapping("ClassCodeID", "ClassCodeID")
      })
    });
    this.DbCommand6.CommandText = "[getNetrateITVData]";
    this.DbCommand6.CommandType = CommandType.StoredProcedure;
    this.DbCommand6.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGUID")
    });
    ((Control) this.ugITV).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((SpecialBoxBase) ((UltraGridBase) this.ugITV).DisplayLayout.AddNewBox).Prompt = " ";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugITV).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugITV).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Address";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 151;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 167;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 66;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "ZipCode";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 91;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 1;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Occupancy";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Style = (ColumnStyle) 6;
    ultraGridColumn5.Width = 67;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 68;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 83;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 61;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Const Class";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 76;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 71;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 71;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 52;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 65;
    ultraGridBand1.Columns.AddRange(new object[14]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 1;
    ((UltraGridBase) this.ugITV).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugITV).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugITV).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.MaxSelectedRows = 5;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.RowSelectorHeaderStyle = (RowSelectorHeaderStyle) 1;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugITV).DisplayLayout.Override.SummaryDisplayArea = (SummaryDisplayAreas) 16 /*0x10*/;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugITV).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugITV).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugITV).Location = new Point(12, 62);
    ((Control) this.ugITV).Name = "ugITV";
    ((Control) this.ugITV).Size = new Size(779, 266);
    ((Control) this.ugITV).TabIndex = 3;
    ((UltraControlBase) this.ugITV).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugITV).UseOsThemes = (DefaultableBoolean) 2;
    this.linkViewReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.linkViewReport.AutoSize = true;
    this.linkViewReport.BackColor = Color.Transparent;
    this.linkViewReport.Location = new Point(706, 343);
    this.linkViewReport.Name = "linkViewReport";
    this.linkViewReport.Size = new Size(84, 13);
    this.linkViewReport.TabIndex = 118;
    this.linkViewReport.TabStop = true;
    this.linkViewReport.Text = "View ITV Report";
    this.lnkSendToDocHandler.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkSendToDocHandler.AutoSize = true;
    this.lnkSendToDocHandler.BackColor = Color.Transparent;
    this.lnkSendToDocHandler.Location = new Point(446, 343);
    this.lnkSendToDocHandler.Name = "lnkSendToDocHandler";
    this.lnkSendToDocHandler.Size = new Size(190, 13);
    this.lnkSendToDocHandler.TabIndex = 119;
    this.lnkSendToDocHandler.TabStop = true;
    this.lnkSendToDocHandler.Text = "Save ITV Report to Document Handler";
    ((Control) this.ddConstClass).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddConstClass).DataMember = "lstConstructionTypes";
    ((UltraGridBase) this.ddConstClass).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.ddConstClass).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddConstClass).DisplayMember = "Type";
    ((Control) this.ddConstClass).Location = new Point(417, 149);
    ((Control) this.ddConstClass).Name = "ddConstClass";
    ((Control) this.ddConstClass).Size = new Size(201, 98);
    ((Control) this.ddConstClass).TabIndex = 22;
    ((UltraDropDownBase) this.ddConstClass).ValueMember = "ConstructionTypeID";
    ((Control) this.ddConstClass).Visible = false;
    this.ds.DataSetName = "dsITVCalculator";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ddOccupancy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddOccupancy).DataMember = "lstClassCodes";
    ((UltraGridBase) this.ddOccupancy).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.ddOccupancy).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddOccupancy).DisplayMember = "ClassCodeDescription";
    ((Control) this.ddOccupancy).Location = new Point(149, 131);
    ((Control) this.ddOccupancy).Name = "ddOccupancy";
    ((Control) this.ddOccupancy).Size = new Size(201, 98);
    ((Control) this.ddOccupancy).TabIndex = 21;
    ((UltraDropDownBase) this.ddOccupancy).ValueMember = "ClassCodeID";
    ((Control) this.ddOccupancy).Visible = false;
    this.lblTerrCostText.AutoSize = true;
    this.lblTerrCostText.Location = new Point(9, 343);
    this.lblTerrCostText.Name = "lblTerrCostText";
    this.lblTerrCostText.Size = new Size(112 /*0x70*/, 13);
    this.lblTerrCostText.TabIndex = 120;
    this.lblTerrCostText.Text = "Territory Cost Factor:";
    this.lblTerritoryCost.AutoSize = true;
    this.lblTerritoryCost.Location = new Point((int) sbyte.MaxValue, 343);
    this.lblTerritoryCost.Name = "lblTerritoryCost";
    this.lblTerritoryCost.Size = new Size(13, 13);
    this.lblTerritoryCost.TabIndex = 121;
    this.lblTerritoryCost.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(803, 367);
    this.Controls.Add((Control) this.lblTerritoryCost);
    this.Controls.Add((Control) this.lblTerrCostText);
    this.Controls.Add((Control) this.lnkSendToDocHandler);
    this.Controls.Add((Control) this.linkViewReport);
    this.Controls.Add((Control) this.ddConstClass);
    this.Controls.Add((Control) this.ddOccupancy);
    this.Controls.Add((Control) this.ugITV);
    this.Controls.Add((Control) this.lblDate);
    this.Controls.Add((Control) this.lblInsured);
    this.Controls.Add((Control) this.lblCompanyName);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormITVCalculator);
    this.Text = "ITV Calculator";
    ((ISupportInitialize) this.gridFilingInformation).EndInit();
    ((ISupportInitialize) this.ugITV).EndInit();
    ((ISupportInitialize) this.ddConstClass).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddOccupancy).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugITV")]
  private virtual UltraGrid ugITV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBaseValuation")]
  private virtual DbDataAdapter daGetBaseValuation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  private virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBuildingStories")]
  private virtual DbDataAdapter daGetBuildingStories { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand1")]
  private virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetDepreciation")]
  private virtual DbDataAdapter daGetDepreciation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand2")]
  private virtual DbCommand DbCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetMiscFactors")]
  private virtual DbDataAdapter daGetMiscFactors { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand3")]
  private virtual DbCommand DbCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetTerritories")]
  private virtual DbDataAdapter daGetTerritories { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand4")]
  private virtual DbCommand DbCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetLocations")]
  private virtual DbDataAdapter daGetLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand5")]
  private virtual DbCommand DbCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetNetRateLocations")]
  private virtual DbDataAdapter daGetNetRateLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand6")]
  private virtual DbCommand DbCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddOccupancy")]
  private virtual UltraDropDown ddOccupancy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddConstClass")]
  private virtual UltraDropDown ddConstClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel linkViewReport
  {
    get => this._linkViewReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkViewReport_LinkClicked);
      LinkLabel linkViewReport1 = this._linkViewReport;
      if (linkViewReport1 != null)
        linkViewReport1.LinkClicked -= clickedEventHandler;
      this._linkViewReport = value;
      LinkLabel linkViewReport2 = this._linkViewReport;
      if (linkViewReport2 == null)
        return;
      linkViewReport2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkSendToDocHandler
  {
    get => this._lnkSendToDocHandler;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSendToDocHandler_LinkClicked);
      LinkLabel sendToDocHandler1 = this._lnkSendToDocHandler;
      if (sendToDocHandler1 != null)
        sendToDocHandler1.LinkClicked -= clickedEventHandler;
      this._lnkSendToDocHandler = value;
      LinkLabel sendToDocHandler2 = this._lnkSendToDocHandler;
      if (sendToDocHandler2 == null)
        return;
      sendToDocHandler2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTerrCostText")]
  private virtual Label lblTerrCostText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTerritoryCost")]
  private virtual Label lblTerritoryCost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormITVCalculator(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormITVCalculator_Load);
    this._isUsingNetrate = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._q = new Quote(quoteGuid);
    this._isUsingNetrate = this._q.UsingNetRate;
    Utility.SetDataAdapterConnections(this.daGetBaseValuation, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daGetBuildingStories, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daGetDepreciation, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daGetLocations, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daGetMiscFactors, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daGetNetRateLocations, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daGetTerritories, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this.SetupLabels(this._q);
    this.PrefillData();
  }

  private void SetupLabels(Quote q)
  {
    this.lblDate.Text = "Date: " + DateTime.Today.ToShortDateString();
    this.lblInsured.Text = "Insured Name: " + q.InsuredPolicyName;
    this.lblCompanyName.Text = q.Company + " - Insurance to Value Calculation";
  }

  private void SetupGrid()
  {
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["LocationID"].Hidden = true;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["SprinklerTypeID"].Hidden = true;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["SqFootage"].Hidden = true;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["YearBuilt"].Hidden = true;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["Elevators"].Hidden = true;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["ACV"].Swap(((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["BaseRate"]);
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["RepLCost"].Swap(((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["BaseRate"]);
    if (this._isUsingNetrate)
    {
      ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["AgeOfBuilding"].Hidden = true;
      ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["ClassCode"].Hidden = true;
    }
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["ConstructionID"].ValueList = (IValueList) this.ddConstClass;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["ConstructionID"].Style = (ColumnStyle) 6;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["ClassCodeID"].ValueList = (IValueList) this.ddOccupancy;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["ClassCodeID"].Style = (ColumnStyle) 6;
    ((UltraGridBase) this.ugITV).DisplayLayout.Bands[0].Columns["Address1"].Width = 110;
  }

  private void BindGrid()
  {
    if (!this._isUsingNetrate)
      ((UltraGridBase) this.ugITV).DataSource = (object) this.ds.tblUnderwritingLocations;
    else
      ((UltraGridBase) this.ugITV).DataSource = (object) this.ds.NetRateUnderwritingLocations;
    this.SetupGrid();
  }

  private void FormITVCalculator_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (!this._isUsingNetrate)
      {
        try
        {
          this.daGetLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._q.QuoteGuid;
          DefaultDatabase.DataAdapterFill(this.daGetLocations, (DataTable) this.ds.tblUnderwritingLocations);
        }
        catch (ConstraintException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        this.daGetNetRateLocations.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._q.QuoteGuid;
        DefaultDatabase.DataAdapterFill(this.daGetNetRateLocations, (DataTable) this.ds.NetRateUnderwritingLocations);
      }
      this.BindGrid();
      this.CalculateITV();
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void PrefillData()
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[7]
      {
        "tblITVCalculatorBaseValuation",
        "tblITVCalculatorBuildingStories",
        "tblITVCalculatorDepreciation",
        "tblITVCalculatorMiscFactors",
        "tblITVCalculatorTerritories",
        "lstClassCodes",
        "lstConstructionTypes"
      }, "spLoadITV", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
  }

  private void LoadMisc(Dictionary<string, Decimal> dict)
  {
    try
    {
      foreach (dsITVCalculator.tblITVCalculatorMiscFactorsRow row in this.ds.tblITVCalculatorMiscFactors.Rows)
        dict.Add(row.FactorType, row.Factor);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual Decimal GetMiscCost(Dictionary<string, Decimal> dict, DataRow dr)
  {
    return dr["SprinklerTypeID"] == DBNull.Value || dr["Elevators"] == DBNull.Value ? (dr["SprinklerTypeID"] == DBNull.Value || dr["Elevators"] != DBNull.Value ? (dr["SprinklerTypeID"] != DBNull.Value || dr["Elevators"] == DBNull.Value ? dict["N/A"] : dict["Elevator"]) : dict["Sprinkler"]) : dict["Both"];
  }

  private Decimal GetBaseCost(DataRow dr)
  {
    Decimal baseCost = 0M;
    object obj = this._isUsingNetrate ? RuntimeHelpers.GetObjectValue(dr["ClassCode"]) : RuntimeHelpers.GetObjectValue(dr["ClassCodeID"]);
    if (obj != DBNull.Value && obj != null && dr["ConstructionID"] != DBNull.Value)
    {
      if (this.ds.tblITVCalculatorBaseValuation.Select($"ClassCode = '{obj.ToString()}' AND ConstCode = '{dr["ConstructionID"].ToString()}'").Length > 0)
      {
        dsITVCalculator.tblITVCalculatorBaseValuationRow baseValuationRow = (dsITVCalculator.tblITVCalculatorBaseValuationRow) this.ds.tblITVCalculatorBaseValuation.Select($"ClassCode = '{obj.ToString()}' AND ConstCode = '{dr["ConstructionID"].ToString()}'")[0];
        if (baseValuationRow != null)
          baseCost = baseValuationRow.BaseValuation;
      }
    }
    return baseCost;
  }

  private byte GetMaxStories(string[] strStories)
  {
    byte maxStories = 0;
    string[] strArray = strStories;
    int index = 0;
    while (index < strArray.Length)
    {
      string str = strArray[index];
      if ((uint) Conversions.ToByte(str) > (uint) maxStories)
        maxStories = Conversions.ToByte(str);
      checked { ++index; }
    }
    return maxStories;
  }

  private byte ParseStories(string stories)
  {
    byte stories1 = 0;
    string[] strStories1 = stories.Split('-');
    if (strStories1.Length == 2)
    {
      stories1 = this.GetMaxStories(strStories1);
    }
    else
    {
      string[] strStories2 = stories.Split('&');
      if (strStories2.Length > 1)
        stories1 = this.GetMaxStories(strStories2);
    }
    return stories1;
  }

  private Decimal GetStoriesFactorCost(Decimal baseCost, DataRow dr, ref Decimal baseRate)
  {
    Decimal storiesFactorCost = 0M;
    if (dr["Stories"] != DBNull.Value)
    {
      int num = Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dr["Stories"])) ? Conversions.ToInteger(dr["Stories"]) : (int) this.ParseStories(dr["Stories"].ToString());
      if (num > 3 && this.ds.tblITVCalculatorBuildingStories.Select("NumberofStories=" + Conversions.ToString(num)).Length > 0)
      {
        dsITVCalculator.tblITVCalculatorBuildingStoriesRow buildingStoriesRow = (dsITVCalculator.tblITVCalculatorBuildingStoriesRow) this.ds.tblITVCalculatorBuildingStories.Select("NumberofStories=" + Conversions.ToString(num))[0];
        if (buildingStoriesRow != null)
        {
          storiesFactorCost = Math.Round(Decimal.Multiply(baseCost, buildingStoriesRow.Factor), 2);
          baseRate = Decimal.Multiply(baseRate, buildingStoriesRow.Factor);
        }
      }
    }
    return storiesFactorCost;
  }

  private Decimal GetTerritoryCost(Decimal baseCost, DataRow dr, ref Decimal baseRate)
  {
    Decimal territoryCost = 0M;
    string str = dr["Zip"].ToString().Substring(0, 3);
    this.lblTerritoryCost.Text = territoryCost.ToString();
    if (this.ds.tblITVCalculatorTerritories.Select($"ZipCode = '{str}'").Length > 0)
    {
      dsITVCalculator.tblITVCalculatorTerritoriesRow calculatorTerritoriesRow = (dsITVCalculator.tblITVCalculatorTerritoriesRow) this.ds.tblITVCalculatorTerritories.Select($"ZipCode = '{str}'")[0];
      if (calculatorTerritoriesRow != null)
      {
        territoryCost = Math.Round(Decimal.Multiply(baseCost, calculatorTerritoriesRow.Factor), 2);
        baseRate = Decimal.Multiply(baseRate, calculatorTerritoriesRow.Factor);
      }
      this.lblTerritoryCost.Text = territoryCost.ToString();
      return territoryCost;
    }
    int num = (int) MessageBox.Show($"There is no cost factor associated with the territory on a location with zip code '{dr["Zip"].ToString()}'", "Missing Cost Factor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    throw new InvalidOperationException($"Missing entry on table tblITVCalculatorTerritories for '{str}'");
  }

  private Decimal GetSquareFootageCost(Decimal baseCost, DataRow dr)
  {
    Decimal num = 0M;
    Decimal squareFootageCost;
    if (dr["SqFootage"] == DBNull.Value)
    {
      squareFootageCost = num;
    }
    else
    {
      if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dr["SqFootage"])))
      {
        num = Math.Round(Decimal.Multiply(baseCost, new Decimal(Conversions.ToInteger(dr["SqFootage"]))), 2);
      }
      else
      {
        string Expression = dr["SqFootage"].ToString().Replace("<", string.Empty).Replace(">", string.Empty).Replace(",", string.Empty);
        if (Versioned.IsNumeric((object) Expression))
          num = Math.Round(Decimal.Multiply(baseCost, new Decimal(Conversions.ToInteger(Expression))), 2);
      }
      squareFootageCost = num;
    }
    return squareFootageCost;
  }

  private Decimal GetDepreciationCost(Decimal baseCost, DataRow dr)
  {
    object obj = (object) null;
    Decimal depreciationCost = 0M;
    if (!this._isUsingNetrate)
    {
      if (dr["YearBuilt"] != DBNull.Value)
        obj = RuntimeHelpers.GetObjectValue(dr["YearBuilt"]);
    }
    else if (dr["AgeOfBuilding"] != DBNull.Value)
      obj = RuntimeHelpers.GetObjectValue(dr["AgeOfBuilding"]);
    if (obj != null)
    {
      if (this.ds.tblITVCalculatorDepreciation.Select($"YearBuilt = '{obj.ToString()}'").Length > 0)
      {
        dsITVCalculator.tblITVCalculatorDepreciationRow calculatorDepreciationRow = (dsITVCalculator.tblITVCalculatorDepreciationRow) this.ds.tblITVCalculatorDepreciation.Select($"YearBuilt = '{obj.ToString()}'")[0];
        if (calculatorDepreciationRow != null && !calculatorDepreciationRow.IsFactorNull())
          depreciationCost = Decimal.Multiply(baseCost, calculatorDepreciationRow.Factor);
      }
    }
    return depreciationCost;
  }

  private void CalculateITV()
  {
    Dictionary<string, Decimal> dict = new Dictionary<string, Decimal>();
    this.LoadMisc(dict);
    foreach (UltraGridRow row in ((UltraGridBase) this.ugITV).Rows)
    {
      Decimal baseRate = 0M;
      DataRow dr = this._isUsingNetrate ? this.ds.NetRateUnderwritingLocations.Select("LocationID = " + Conversions.ToString(Conversions.ToInteger(row.Cells["LocationID"].Value)))[0] : (DataRow) this.ds.tblUnderwritingLocations.FindByLocationID(Conversions.ToInteger(row.Cells["LocationID"].Value));
      Decimal baseCost = Decimal.Add(this.GetBaseCost(dr), this.GetMiscCost(dict, dr));
      baseRate = baseCost;
      Decimal storiesFactorCost = this.GetStoriesFactorCost(baseCost, dr, ref baseRate);
      if (Decimal.Compare(storiesFactorCost, 0M) > 0)
        baseCost = storiesFactorCost;
      Decimal territoryCost = this.GetTerritoryCost(baseCost, dr, ref baseRate);
      if (Decimal.Compare(territoryCost, 0M) > 0)
        baseCost = territoryCost;
      Decimal squareFootageCost = this.GetSquareFootageCost(baseCost, dr);
      if (Decimal.Compare(squareFootageCost, 0M) > 0)
        baseCost = squareFootageCost;
      dr["BaseRate"] = (object) baseRate.ToString("c");
      dr["RepLCost"] = (object) baseCost.ToString("c");
      Decimal depreciationCost = this.GetDepreciationCost(baseCost, dr);
      dr["ACV"] = (object) depreciationCost.ToString("c");
    }
  }

  private Dictionary<int, string> GetConstruction(DataTable dt)
  {
    Dictionary<int, string> construction = new Dictionary<int, string>();
    try
    {
      foreach (DataRow row in dt.Rows)
      {
        if (!construction.ContainsKey(Conversions.ToInteger(row["LocationID"])) && row["ConstructionID"] != DBNull.Value)
        {
          dsITVCalculator.lstConstructionTypesRow constructionTypeId = this.ds.lstConstructionTypes.FindByConstructionTypeID(Conversions.ToByte(row["ConstructionID"]));
          if (constructionTypeId != null)
            construction.Add(Conversions.ToInteger(row["LocationID"]), constructionTypeId.Type);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return construction;
  }

  private Dictionary<int, string> GetClassCode(DataTable dt)
  {
    Dictionary<int, string> classCode = new Dictionary<int, string>();
    try
    {
      foreach (DataRow row in dt.Rows)
      {
        if (!classCode.ContainsKey(Conversions.ToInteger(row["LocationID"])) && row["ClassCodeID"] != DBNull.Value)
        {
          dsITVCalculator.lstClassCodesRow byClassCodeId = this.ds.lstClassCodes.FindByClassCodeID(Conversions.ToShort(row["ClassCodeID"]));
          if (byClassCodeId != null)
            classCode.Add(Conversions.ToInteger(row["LocationID"]), byClassCodeId.ClassCodeDescription);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return classCode;
  }

  private ITVReport GetReport()
  {
    Dictionary<int, string> construction;
    Dictionary<int, string> classCode;
    if (this._isUsingNetrate)
    {
      construction = this.GetConstruction((DataTable) this.ds.NetRateUnderwritingLocations);
      classCode = this.GetClassCode((DataTable) this.ds.NetRateUnderwritingLocations);
    }
    else
    {
      construction = this.GetConstruction((DataTable) this.ds.tblUnderwritingLocations);
      classCode = this.GetClassCode((DataTable) this.ds.tblUnderwritingLocations);
    }
    return new ITVReport(this.ds, this._isUsingNetrate, construction, classCode);
  }

  private void linkViewReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ITVReport report = this.GetReport();
      ((SectionReport) report).Run();
      ((Control) new frmPrint((SectionReport) report)).Show();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkSendToDocHandler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ITVReport report = this.GetReport();
      ((SectionReport) report).Run();
      this.SaveReport(report);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      IOException ioException = ex;
      if (ioException.Message.Contains("used by another process"))
      {
        int num = (int) MessageBox.Show("Cannot execute this request because the report is being used by another process", "Report Being Used By Another Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        ErrorHandler.HandleError((Exception) ioException);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void SaveReport(ITVReport report, int folderId = -1)
  {
    using (PdfExport pdfExport = new PdfExport())
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        pdfExport.Export(((SectionReport) report).Document, (Stream) memoryStream);
        string str = $"ITV-ControlNo{Conversions.ToString(this._q.ControlNo)}.pdf".Replace("/", string.Empty).Replace("\\", string.Empty).Replace(" ", string.Empty);
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          str = str.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        string path = MGATempFolder.MGATempPath + str;
        using (FileStream fileStream = new FileStream(path, FileMode.Create))
        {
          memoryStream.WriteTo((Stream) fileStream);
          fileStream.Write(memoryStream.ToArray(), 0, (int) memoryStream.Position);
        }
        DocumentManager.BeginFileAddWithBind(path, folderId, (ISupportDocumentSystem) this._q);
      }
    }
  }

  public static bool GetITVReport(Guid quoteGuid, int folderId = -1)
  {
    bool itvReport;
    try
    {
      FormITVCalculator formItvCalculator = new FormITVCalculator(quoteGuid);
      formItvCalculator.FormITVCalculator_Load((object) null, EventArgs.Empty);
      ITVReport report = formItvCalculator.GetReport();
      ((SectionReport) report).Run();
      formItvCalculator.SaveReport(report, folderId);
      itvReport = true;
      goto label_3;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
    itvReport = false;
label_3:
    return itvReport;
  }
}
