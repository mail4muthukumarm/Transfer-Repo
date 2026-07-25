// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyCompanyLineRequirements
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Tools;
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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyCompanyLineRequirements : Form
{
  private IContainer components;
  private int _currentCompanyLineID;

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyCompanyLineRequirements));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("BindingRequirementID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Requirement");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CopyRequirement");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Status");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CopyOver");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ViewCompanyLines_ViewCompanyLinesChildren");
    UltraGridBand ultraGridBand3 = new UltraGridBand("ViewCompanyLines_ViewCompanyLinesChildren", 0);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ParentCompanyLineGuid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("CopyOver");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    this.lnkApplyFilter = new LinkLabel();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.lnkDeSelectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.lblCompanyLine = new Label();
    this.txtCompanyLine = new Label();
    this.btnCopy = new MGAButton();
    this.panelPleaseWait = new UltraGroupBox();
    this.Label27 = new Label();
    this.PictureBox1 = new PictureBox();
    this.dgRequirement = new UltraGrid();
    this.ds = new dsCopyRequirements();
    this.dgView = new UltraGrid();
    this.cbStateFilter = new MGASimpleComboBox();
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    this.lnkChildLinesSelection = new LinkLabel();
    ((ISupportInitialize) this.btnCopy).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.dgRequirement).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    this.SuspendLayout();
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lnkApplyFilter.Location = new Point(322, 109);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(78, 15);
    this.lnkApplyFilter.TabIndex = 463;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    this.Label26.AutoSize = true;
    this.Label26.Location = new Point(542, 54);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(60, 13);
    this.Label26.TabIndex = 461;
    this.Label26.Text = "State Filter:";
    this.Label25.AutoSize = true;
    this.Label25.Location = new Point(322, 54);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(55, 13);
    this.Label25.TabIndex = 460;
    this.Label25.Text = "Line Filter:";
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(10, 54);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(79, 13);
    this.Label24.TabIndex = 459;
    this.Label24.Text = "Company Filter:";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(720, 491);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(145, 13);
    this.lnkDeSelectAll.TabIndex = 465;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All Company/Lines";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(720, 464);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(128 /*0x80*/, 13);
    this.lnkSelectAll.TabIndex = 464;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Company/Lines";
    this.lblCompanyLine.AutoSize = true;
    this.lblCompanyLine.Location = new Point(11, 23);
    this.lblCompanyLine.Name = "lblCompanyLine";
    this.lblCompanyLine.Size = new Size(122, 13);
    this.lblCompanyLine.TabIndex = 467;
    this.lblCompanyLine.Text = "Current Company / Line:";
    this.txtCompanyLine.AutoSize = true;
    this.txtCompanyLine.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCompanyLine.Location = new Point(139, 23);
    this.txtCompanyLine.Name = "txtCompanyLine";
    this.txtCompanyLine.Size = new Size(145, 13);
    this.txtCompanyLine.TabIndex = 468;
    this.txtCompanyLine.Text = "Current Company / Line:";
    ((Control) this.btnCopy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.FontData.BoldAsString = "True";
    appearance1.ForeColor = Color.Blue;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance23.Image"));
    ((ControlBase) this.btnCopy).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnCopy).Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnCopy).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCopy).Location = new Point(946, 464);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((ControlBase) this.btnCopy).Padding = new Size(5, 0);
    ((Control) this.btnCopy).Size = new Size(76, 40);
    ((Control) this.btnCopy).TabIndex = 469;
    ((Control) this.btnCopy).Tag = (object) "";
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.btnCopy.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label27);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Location = new Point(216, 151);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(345, 84);
    ((Control) this.panelPleaseWait).TabIndex = 470;
    ((Control) this.panelPleaseWait).Visible = false;
    this.Label27.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label27.Location = new Point(55, 32 /*0x20*/);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(280, 21);
    this.Label27.TabIndex = 1;
    this.Label27.Text = "Please wait.  Copying Requirements ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    ((Control) this.dgRequirement).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgRequirement).DataMember = "dtRequirements";
    ((UltraGridBase) this.dgRequirement).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 156;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 169;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 34;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 54;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 77;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.dgRequirement).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgRequirement).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgRequirement).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgRequirement).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgRequirement).Location = new Point(721, 54);
    ((Control) this.dgRequirement).Name = "dgRequirement";
    ((Control) this.dgRequirement).Size = new Size(301, 358);
    ((Control) this.dgRequirement).TabIndex = 466;
    ((Control) this.dgRequirement).Text = "Available Requirements";
    ((UltraControlBase) this.dgRequirement).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgRequirement).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCopyRequirements";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraGridBase) this.dgView).DataMember = "ViewCompanyLines";
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 264;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 216;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 301;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn9.Width = 113;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 193;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 5;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 85;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 6;
    ultraGridColumn12.Width = 51;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 7;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 254;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridColumn15.Width = 203;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Width = 290;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 3;
    ultraGridColumn17.Width = 116;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 4;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 187;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 5;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 146;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 6;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 85;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 7;
    ultraGridColumn21.Width = 53;
    ultraGridBand3.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance15.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.Transparent;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.WhiteSmoke;
    appearance19.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgView).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgView).Location = new Point(12, 141);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(702, 363);
    ((Control) this.dgView).TabIndex = 462;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.cbStateFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbStateFilter).DisplayMember = "State";
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbStateFilter).DropDownWidth = 350;
    ((Control) this.cbStateFilter).Location = new Point(542, 75);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    ((Control) this.cbStateFilter).Size = new Size(164, 20);
    ((Control) this.cbStateFilter).TabIndex = 458;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStateFilter).ValueMember = "StateID";
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbCompanyFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cbCompanyFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbCompanyFilter).DisplayMember = "Name";
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 600;
    ((Control) this.cbCompanyFilter).Location = new Point(13, 75);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    ((Control) this.cbCompanyFilter).Size = new Size(298, 20);
    ((Control) this.cbCompanyFilter).TabIndex = 456;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanyFilter).ValueMember = "CompanyLocationGuid";
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.cbLineFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbLineFilter).DisplayMember = "LineName";
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 400;
    ((Control) this.cbLineFilter).Location = new Point(325, 75);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    ((Control) this.cbLineFilter).Size = new Size(198, 20);
    ((Control) this.cbLineFilter).TabIndex = 457;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLineFilter).ValueMember = "LineGuid";
    this.lnkChildLinesSelection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkChildLinesSelection.AutoSize = true;
    this.lnkChildLinesSelection.Location = new Point(720, 424);
    this.lnkChildLinesSelection.Name = "lnkChildLinesSelection";
    this.lnkChildLinesSelection.Size = new Size(206, 13);
    this.lnkChildLinesSelection.TabIndex = 473;
    this.lnkChildLinesSelection.TabStop = true;
    this.lnkChildLinesSelection.Text = "Select all \"selected\" Child Company/Lines";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1034, 516);
    this.Controls.Add((Control) this.lnkChildLinesSelection);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) this.txtCompanyLine);
    this.Controls.Add((Control) this.lblCompanyLine);
    this.Controls.Add((Control) this.dgRequirement);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.cbStateFilter);
    this.Controls.Add((Control) this.cbCompanyFilter);
    this.Controls.Add((Control) this.cbLineFilter);
    this.Name = nameof (FormCopyCompanyLineRequirements);
    this.Text = "Copy Company/Line Requirements";
    ((ISupportInitialize) this.btnCopy).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.dgRequirement).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual LinkLabel lnkApplyFilter
  {
    get => this._lnkApplyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkApplyFilter_LinkClicked);
      LinkLabel lnkApplyFilter1 = this._lnkApplyFilter;
      if (lnkApplyFilter1 != null)
        lnkApplyFilter1.LinkClicked -= clickedEventHandler;
      this._lnkApplyFilter = value;
      LinkLabel lnkApplyFilter2 = this._lnkApplyFilter;
      if (lnkApplyFilter2 == null)
        return;
      lnkApplyFilter2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dgView")]
  private virtual UltraGrid dgView { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbStateFilter")]
  private virtual MGASimpleComboBox cbStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbCompanyFilter")]
  private virtual MGASimpleComboBox cbCompanyFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbLineFilter")]
  private virtual MGASimpleComboBox cbLineFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dgRequirement")]
  private virtual UltraGrid dgRequirement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyRequirements ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanyLine")]
  internal virtual Label lblCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompanyLine")]
  internal virtual Label txtCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCopy
  {
    get => this._btnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopy_Click);
      MGAButton btnCopy1 = this._btnCopy;
      if (btnCopy1 != null)
        ((Control) btnCopy1).Click -= eventHandler;
      this._btnCopy = value;
      MGAButton btnCopy2 = this._btnCopy;
      if (btnCopy2 == null)
        return;
      ((Control) btnCopy2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelPleaseWait")]
  protected virtual UltraGroupBox panelPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  protected virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  protected virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkChildLinesSelection
  {
    get => this._lnkChildLinesSelection;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChildLinesSelection_LinkClicked);
      LinkLabel childLinesSelection1 = this._lnkChildLinesSelection;
      if (childLinesSelection1 != null)
        childLinesSelection1.LinkClicked -= clickedEventHandler;
      this._lnkChildLinesSelection = value;
      LinkLabel childLinesSelection2 = this._lnkChildLinesSelection;
      if (childLinesSelection2 == null)
        return;
      childLinesSelection2.LinkClicked += clickedEventHandler;
    }
  }

  public FormCopyCompanyLineRequirements(int currentCompanyLineID)
  {
    this.Load += new EventHandler(this.FormCopyCompanyLineRequirements_Load);
    this.InitializeComponent();
    this._currentCompanyLineID = currentCompanyLineID;
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      if (this.panelPleaseWait != null)
        ((Component) this.panelPleaseWait).Dispose();
      if (this.lnkApplyFilter != null)
      {
        this.lnkApplyFilter.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.lnkApplyFilter_LinkClicked);
        this.lnkApplyFilter.Dispose();
      }
      if (this.lnkSelectAll != null)
      {
        this.lnkSelectAll.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
        this.lnkSelectAll.Dispose();
      }
      if (this.lnkDeSelectAll == null)
        return;
      this.lnkDeSelectAll.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      this.lnkDeSelectAll.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  private void FormCopyCompanyLineRequirements_Load(object sender, EventArgs e)
  {
    this.txtCompanyLine.Text = new CompanyLine(this._currentCompanyLineID).CompanyLineState;
    dsCopyRequirements.lstStatesRow row1 = this.ds.lstStates.NewlstStatesRow();
    row1.StateID = string.Empty;
    row1.State = "ANY";
    this.ds.lstStates.AddlstStatesRow(row1);
    dsCopyRequirements.lstLinesRow row2 = this.ds.lstLines.NewlstLinesRow();
    row2.LineGuid = Guid.Empty;
    row2.LineName = "ANY";
    this.ds.lstLines.AddlstLinesRow(row2);
    dsCopyRequirements.tblCompanyLocationsRow row3 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row3.CompanyLocationGuid = Guid.Empty;
    row3.Name = "ANY";
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row3);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
    {
      "lstLines",
      "lstStates",
      "tblCompanyLocations",
      "dtRequirements"
    }, "spGetCopyCompanyLineRequirementsData", new object[2]
    {
      (object) "@CurrentCompanyLineID",
      (object) this._currentCompanyLineID
    });
  }

  private void SetComboBoxesEnabledProperty(bool enableValue)
  {
    ((Control) this.cbCompanyFilter).Enabled = enableValue;
    ((Control) this.cbStateFilter).Enabled = enableValue;
    ((Control) this.cbLineFilter).Enabled = enableValue;
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetComboBoxesEnabledProperty(false);
    this.ds.ViewCompanyLines.Clear();
    this.ds.ViewCompanyLinesChildren.Clear();
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbCompanyFilter.Text, "ANY", false) != 0)
      obj1 = RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbLineFilter.Text, "ANY", false) != 0)
      obj2 = RuntimeHelpers.GetObjectValue(this.cbLineFilter.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbStateFilter.Text, "ANY", false) != 0)
      obj3 = RuntimeHelpers.GetObjectValue(this.cbStateFilter.Value);
    string[] strArray = new string[2]
    {
      "ViewCompanyLines",
      "ViewCompanyLinesChildren"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "spSearchRequirementsCompanyLines", new object[8]
      {
        (object) "@companyLocationGuid",
        obj1,
        (object) "@lineGuid",
        obj2,
        (object) "@stateID",
        obj3,
        (object) "@CurrentCompanyLineID",
        (object) this._currentCompanyLineID
      });
    }
    finally
    {
      this.SetComboBoxesEnabledProperty(true);
    }
  }

  private bool IsvalidCopy()
  {
    bool flag1;
    if (((UltraGridBase) this.dgView).Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("No row(s) available in the grid.", "No Row(s) Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag1 = false;
    }
    else
    {
      bool flag2 = false;
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          if (ultraGridRow.Cells["CopyOver"].Value != null && ultraGridRow.Cells["CopyOver"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
          {
            flag2 = true;
            break;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (!flag2)
      {
        int num = (int) MessageBox.Show("In order to continue, at least one company/line row must be selected to 'Copy' over.", "No Company/Line Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag1 = false;
      }
      else
      {
        bool flag3 = false;
        foreach (UltraGridRow row in ((UltraGridBase) this.dgRequirement).Rows)
        {
          if (row.Cells["CopyRequirement"].Value != null && row.Cells["CopyRequirement"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["CopyRequirement"].Value))
          {
            flag3 = true;
            break;
          }
        }
        if (!flag3)
        {
          int num = (int) MessageBox.Show("In order to continue, at least one requirement must be selected to 'Copy' over.", "No Requirement Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag1 = false;
        }
        else
          flag1 = true;
      }
    }
    return flag1;
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    if (!this.IsvalidCopy())
      return;
    if (DialogResult.Yes != MessageBox.Show("Continue and copy over the selected requirement(s)?", "Copy Requirements", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      ((Control) this.panelPleaseWait).Visible = true;
      ((UltraControlBase) this.panelPleaseWait).Refresh();
      string str1 = string.Empty;
      string str2 = string.Empty;
      RowEnumerator enumerator1 = ((UltraGridBase) this.dgRequirement).Rows.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        UltraGridRow current = enumerator1.Current;
        if (current.Cells["CopyRequirement"].Value != null && current.Cells["CopyRequirement"].Value != DBNull.Value && Conversions.ToBoolean(current.Cells["CopyRequirement"].Value))
        {
          str1 = $"{str1}{current.Cells["BindingRequirementID"].Value.ToString()},";
          str2 = $"{str2}{current.Cells["QuoteStatusID"].Value.ToString()},";
        }
      }
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          ((UltraControlBase) this.panelPleaseWait).Refresh();
          if (ultraGridRow.Cells["CopyOver"].Value != null && ultraGridRow.Cells["CopyOver"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
            DefaultDatabase.ExecuteNonQuery("spCopyCompanyLineRequirements", new object[8]
            {
              (object) "@CurrentCompanyLineID",
              (object) this._currentCompanyLineID,
              (object) "@DestinationCompanyLineID",
              ultraGridRow.Cells["CompanyLineID"].Value,
              (object) "@RequirementIDs",
              (object) str1,
              (object) "@QuoteStatusIDs",
              (object) str2
            });
        }
      }
      finally
      {
        IEnumerator enumerator2;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
      }
    }
    finally
    {
      ((Control) this.panelPleaseWait).Visible = false;
    }
    int num = (int) MessageBox.Show("Requirement(s) copied over sucessfully.", "Copied Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(false);
  }

  private void SetGridSelection(bool selectionValue)
  {
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        ultraGridRow.Cells["CopyOver"].Value = (object) selectionValue;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.dgView).UpdateData();
  }

  private void lnkChildLinesSelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num1 = 0;
    Guid empty = Guid.Empty;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["CopyOver"].Value)) && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
        {
          if (ultraGridRow.Band.Index == 0)
          {
            int num2 = (int) MessageBox.Show("Cannot continue - Parent row is selected.", "Only Child Rows Expected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          empty = (Guid) ultraGridRow.Cells["CompanyLocationGuid"].Value;
          ++num1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (num1 != 1)
    {
      int num3 = (int) MessageBox.Show("Cannot continue - Only 1 row can be selected.", "Only One Child Row Selection Expected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (empty.Equals(Guid.Empty))
    {
      int num4 = (int) MessageBox.Show("Cannot continue - Must select a child row.", "No Child Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          if (ultraGridRow.Band.Index == 1 && ((Guid) ultraGridRow.Cells["CompanyLocationGuid"].Value).Equals(empty))
            ultraGridRow.Cells["CopyOver"].Value = (object) 1;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ((UltraGridBase) this.dgView).UpdateData();
    }
  }
}
