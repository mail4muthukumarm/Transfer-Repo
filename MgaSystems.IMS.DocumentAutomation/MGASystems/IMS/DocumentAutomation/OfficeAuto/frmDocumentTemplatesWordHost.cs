// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.OfficeAuto.frmDocumentTemplatesWordHost
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Word;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.OfficeAuto;

public class frmDocumentTemplatesWordHost : FormBase, IFormSettingsIgnore
{
  private IContainer components;
  private UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl UltraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl UltraExplorerBarContainerControl3;
  private dsDocumentTemplatesWordHost ds;
  private string _localFileName;
  private Word.Application _wordApplication;
  private int _templateID;

  private virtual UltraExplorerBar UltraExplorerBar1
  {
    get => this._UltraExplorerBar1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      GroupCollapsingEventHandler collapsingEventHandler = new GroupCollapsingEventHandler(this.UltraExplorerBar1_GroupCollapsing);
      UltraExplorerBar ultraExplorerBar1_1 = this._UltraExplorerBar1;
      if (ultraExplorerBar1_1 != null)
        ultraExplorerBar1_1.GroupCollapsing -= collapsingEventHandler;
      this._UltraExplorerBar1 = value;
      UltraExplorerBar ultraExplorerBar1_2 = this._UltraExplorerBar1;
      if (ultraExplorerBar1_2 == null)
        return;
      ultraExplorerBar1_2.GroupCollapsing += collapsingEventHandler;
    }
  }

  protected virtual UltraGrid gridTags
  {
    get => this._gridTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridTags_DoubleClick);
      UltraGrid gridTags1 = this._gridTags;
      if (gridTags1 != null)
        ((Control) gridTags1).DoubleClick -= eventHandler;
      this._gridTags = value;
      UltraGrid gridTags2 = this._gridTags;
      if (gridTags2 == null)
        return;
      ((Control) gridTags2).DoubleClick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lnkSaveAs")]
  private virtual LinkLabel lnkSaveAs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtTagFilter
  {
    get => this._txtTagFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtTagFilter_TextChanged);
      MGATextBox txtTagFilter1 = this._txtTagFilter;
      if (txtTagFilter1 != null)
        ((Control) txtTagFilter1).TextChanged -= eventHandler;
      this._txtTagFilter = value;
      MGATextBox txtTagFilter2 = this._txtTagFilter;
      if (txtTagFilter2 == null)
        return;
      ((Control) txtTagFilter2).TextChanged += eventHandler;
    }
  }

  internal virtual MGATextBox txtGrpFilter
  {
    get => this._txtGrpFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtGrpFilter_TextChanged);
      MGATextBox txtGrpFilter1 = this._txtGrpFilter;
      if (txtGrpFilter1 != null)
        ((Control) txtGrpFilter1).TextChanged -= eventHandler;
      this._txtGrpFilter = value;
      MGATextBox txtGrpFilter2 = this._txtGrpFilter;
      if (txtGrpFilter2 == null)
        return;
      ((Control) txtGrpFilter2).TextChanged += eventHandler;
    }
  }

  internal virtual LinkLabel LinkLabel1
  {
    get => this._LinkLabel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      LinkLabel linkLabel1_1 = this._LinkLabel1;
      if (linkLabel1_1 != null)
        linkLabel1_1.LinkClicked -= clickedEventHandler;
      this._LinkLabel1 = value;
      LinkLabel linkLabel1_2 = this._LinkLabel1;
      if (linkLabel1_2 == null)
        return;
      linkLabel1_2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlFormattingOptions")]
  internal virtual Panel pnlFormattingOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tagFunctionData")]
  internal virtual UltraDataSource tagFunctionData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridFunctions")]
  protected virtual UltraGrid gridFunctions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtTagDescription
  {
    get => this._txtTagDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtTagFilter_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtTagDescription_TextChanged);
      MGATextBox txtTagDescription1 = this._txtTagDescription;
      if (txtTagDescription1 != null)
      {
        ((Control) txtTagDescription1).TextChanged -= eventHandler1;
        ((Control) txtTagDescription1).TextChanged -= eventHandler2;
      }
      this._txtTagDescription = value;
      MGATextBox txtTagDescription2 = this._txtTagDescription;
      if (txtTagDescription2 == null)
        return;
      ((Control) txtTagDescription2).TextChanged += eventHandler1;
      ((Control) txtTagDescription2).TextChanged += eventHandler2;
    }
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Groups", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Group");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Groups_Tags");
    UltraGridBand ultraGridBand2 = new UltraGridBand("Groups_Tags", 0);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Tag");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Group");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("IsCheckbox");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("Functions", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TagFunction");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Description");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    UltraDataColumn ultraDataColumn1 = new UltraDataColumn("TagFunction");
    UltraDataColumn ultraDataColumn2 = new UltraDataColumn("Description");
    Appearance appearance18 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.Panel1 = new Panel();
    this.LinkLabel1 = new LinkLabel();
    this.txtTagDescription = new MGATextBox();
    this.txtGrpFilter = new MGATextBox();
    this.txtTagFilter = new MGATextBox();
    this.gridTags = new UltraGrid();
    this.ds = new dsDocumentTemplatesWordHost();
    this.UltraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.pnlFormattingOptions = new Panel();
    this.gridFunctions = new UltraGrid();
    this.tagFunctionData = new UltraDataSource(this.components);
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.lnkSaveAs = new LinkLabel();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.txtTagDescription).BeginInit();
    ((ISupportInitialize) this.txtGrpFilter).BeginInit();
    ((ISupportInitialize) this.txtTagFilter).BeginInit();
    ((ISupportInitialize) this.gridTags).BeginInit();
    this.ds.BeginInit();
    ((Control) this.UltraExplorerBarContainerControl3).SuspendLayout();
    this.pnlFormattingOptions.SuspendLayout();
    ((ISupportInitialize) this.gridFunctions).BeginInit();
    ((ISupportInitialize) this.tagFunctionData).BeginInit();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Panel1);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(22, 41);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(307, 221);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.LinkLabel1);
    this.Panel1.Controls.Add((Control) this.txtTagDescription);
    this.Panel1.Controls.Add((Control) this.txtGrpFilter);
    this.Panel1.Controls.Add((Control) this.txtTagFilter);
    this.Panel1.Controls.Add((Control) this.gridTags);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(307, 221);
    this.Panel1.TabIndex = 8;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.BackColor = Color.Transparent;
    this.LinkLabel1.Location = new Point(6, 0);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(86, 13);
    this.LinkLabel1.TabIndex = 7;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Reposition Word";
    ((Control) this.txtTagDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTagDescription).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtTagDescription).BackColor = Color.White;
    ((Control) this.txtTagDescription).Location = new Point(10, 73);
    ((Control) this.txtTagDescription).Name = "txtTagDescription";
    ((TextEditorControlBase) this.txtTagDescription).NullText = "Filter Tag Description";
    ((Control) this.txtTagDescription).Size = new Size(291, 20);
    ((Control) this.txtTagDescription).TabIndex = 5;
    ((UltraControlBase) this.txtTagDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTagDescription).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtGrpFilter).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtGrpFilter).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtGrpFilter).BackColor = Color.White;
    ((Control) this.txtGrpFilter).Location = new Point(10, 21);
    ((Control) this.txtGrpFilter).Name = "txtGrpFilter";
    ((TextEditorControlBase) this.txtGrpFilter).NullText = "Filter Groups";
    ((Control) this.txtGrpFilter).Size = new Size(291, 20);
    ((Control) this.txtGrpFilter).TabIndex = 3;
    ((UltraControlBase) this.txtGrpFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGrpFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtTagFilter).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTagFilter).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtTagFilter).BackColor = Color.White;
    ((Control) this.txtTagFilter).Location = new Point(10, 47);
    ((Control) this.txtTagFilter).Name = "txtTagFilter";
    ((TextEditorControlBase) this.txtTagFilter).NullText = "Filter Tag Name";
    ((Control) this.txtTagFilter).Size = new Size(291, 20);
    ((Control) this.txtTagFilter).TabIndex = 4;
    ((UltraControlBase) this.txtTagFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTagFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridTags).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.gridTags).CausesValidation = false;
    ((UltraGridBase) this.gridTags).DataSource = (object) this.ds.Groups;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridTags).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridTags).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 271;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 114;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 138;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 76;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 45;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.gridTags).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridTags).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridTags).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.gridTags).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridTags).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridTags).Location = new Point(11, 99);
    ((Control) this.gridTags).Name = "gridTags";
    ((Control) this.gridTags).Size = new Size(292, 121);
    ((Control) this.gridTags).TabIndex = 0;
    ((UltraControlBase) this.gridTags).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridTags).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDocumentTemplatesWordHost";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraExplorerBarContainerControl3).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.pnlFormattingOptions);
    ((Control) this.UltraExplorerBarContainerControl3).Location = new Point(22, 311);
    ((Control) this.UltraExplorerBarContainerControl3).Name = "UltraExplorerBarContainerControl3";
    ((Control) this.UltraExplorerBarContainerControl3).Size = new Size(307, 345);
    ((Control) this.UltraExplorerBarContainerControl3).TabIndex = 2;
    this.pnlFormattingOptions.BackColor = Color.Transparent;
    this.pnlFormattingOptions.Controls.Add((Control) this.gridFunctions);
    this.pnlFormattingOptions.Dock = DockStyle.Fill;
    this.pnlFormattingOptions.Location = new Point(0, 0);
    this.pnlFormattingOptions.Name = "pnlFormattingOptions";
    this.pnlFormattingOptions.Size = new Size(307, 345);
    this.pnlFormattingOptions.TabIndex = 9;
    ((Control) this.gridFunctions).CausesValidation = false;
    ((UltraGridBase) this.gridFunctions).DataSource = (object) this.tagFunctionData;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 24;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 305;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridBand3.HeaderVisible = true;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridFunctions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridFunctions).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridFunctions).Dock = DockStyle.Fill;
    ((Control) this.gridFunctions).Location = new Point(0, 0);
    ((Control) this.gridFunctions).Name = "gridFunctions";
    ((Control) this.gridFunctions).Size = new Size(307, 345);
    ((Control) this.gridFunctions).TabIndex = 1;
    ((UltraControlBase) this.gridFunctions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridFunctions).UseOsThemes = (DefaultableBoolean) 2;
    ultraDataColumn2.ReadOnly = (DefaultableBoolean) 1;
    this.tagFunctionData.Band.Columns.AddRange(new object[2]
    {
      (object) ultraDataColumn1,
      (object) ultraDataColumn2
    });
    this.tagFunctionData.Band.Key = "Functions";
    this.tagFunctionData.ReadOnly = true;
    this.tagFunctionData.Rows.AddRange(new object[24]
    {
      (object) new UltraDataRow(new object[2]
      {
        (object) "Description",
        (object) "No Special Formatting."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Cur",
        (object) "Description",
        (object) "Format as currency."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "CurNoDec",
        (object) "Description",
        (object) "Format as currency (no decimals)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Day",
        (object) "Description",
        (object) "The day portion of a date."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Month",
        (object) "Description",
        (object) "The month portion of a date."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Year",
        (object) "Description",
        (object) "The year portion of a date."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Short",
        (object) "Description",
        (object) "Date - Short format"
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Long",
        (object) "Description",
        (object) "Date - Long format."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "LongNoDay",
        (object) "Description",
        (object) "Date - Long format without day of week name."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "MonthName",
        (object) "Description",
        (object) "The name of the month."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Weekday",
        (object) "Description",
        (object) "The day of the week."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Per",
        (object) "Description",
        (object) "Format as percent."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "PerNoDec",
        (object) "Description",
        (object) "Format as percent (no decimals)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "PerOneDec",
        (object) "Description",
        (object) "Format as percent (1 decimal)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "NumNoDec",
        (object) "Description",
        (object) "Format as number (no decimals)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Num",
        (object) "Description",
        (object) "Format as number (2 decimals)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Num3",
        (object) "Description",
        (object) "Format as number (3 decimals)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Num4",
        (object) "Description",
        (object) "Format as number (4 decimals)."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "Telephone",
        (object) "Description",
        (object) "Telephone xxx-xxx-xxxx."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "RenderHTML",
        (object) "Description",
        (object) "Render as HTML."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "IMG",
        (object) "Description",
        (object) "User Tag Image."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "R90",
        (object) "Description",
        (object) " (90) Rotate Image."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "R180",
        (object) "Description",
        (object) "(180) Rotate Image."
      }),
      (object) new UltraDataRow(new object[4]
      {
        (object) "TagFunction",
        (object) "R270",
        (object) "Description",
        (object) "(270) Rotate Image."
      })
    });
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.lnkSaveAs);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(21, 338);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(324, 0);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    ((Control) this.UltraExplorerBarContainerControl2).Visible = false;
    this.lnkSaveAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSaveAs.BackColor = Color.Transparent;
    this.lnkSaveAs.Location = new Point(-1, -14);
    this.lnkSaveAs.Name = "lnkSaveAs";
    this.lnkSaveAs.Size = new Size(100, 14);
    this.lnkSaveAs.TabIndex = 1;
    this.lnkSaveAs.TabStop = true;
    this.lnkSaveAs.Text = "Save As...";
    this.lnkSaveAs.TextAlign = ContentAlignment.BottomLeft;
    appearance18.BackColor = Color.White;
    appearance18.BackGradientStyle = (GradientStyle) 1;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance18;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl3);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Key = "DocumentTags";
    explorerBarGroup1.Settings.ContainerHeight = 223;
    explorerBarGroup1.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Document Tags";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl3;
    explorerBarGroup2.Key = "TagFormatting";
    explorerBarGroup2.Settings.ContainerHeight = 347;
    explorerBarGroup2.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Tag Formatting";
    explorerBarGroup3.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup3.Enabled = false;
    explorerBarGroup3.Expanded = false;
    explorerBarGroup3.Key = "Template";
    explorerBarGroup3.Settings.AllowItemUncheck = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.ContainerHeight = 376;
    explorerBarGroup3.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Template Document";
    explorerBarGroup3.Visible = false;
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    appearance19.BackColor = Color.FromArgb(239, 247, 253);
    appearance19.BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    appearance20.AlphaLevel = (short) 38;
    appearance20.BackColor = Color.FromArgb(166, 202, 238);
    appearance20.BackColor2 = Color.FromArgb(166, 202, 238);
    appearance20.BackColorAlpha = (Alpha) 2;
    appearance20.BorderColor = Color.White;
    appearance20.FontData.Name = "Tahoma";
    appearance20.FontData.SizeInPoints = 8f;
    appearance20.ForeColor = Color.DarkBlue;
    appearance20.ForegroundAlpha = (Alpha) 2;
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance21;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSpacing = 5;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    ((Control) this.UltraExplorerBar1).Size = new Size(361, 678);
    ((Control) this.UltraExplorerBar1).TabIndex = 4;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.CausesValidation = false;
    this.ClientSize = new Size(361, 678);
    this.ControlBox = false;
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmDocumentTemplatesWordHost);
    this.StartPosition = FormStartPosition.Manual;
    this.Text = "Template Word Document";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.txtTagDescription).EndInit();
    ((ISupportInitialize) this.txtGrpFilter).EndInit();
    ((ISupportInitialize) this.txtTagFilter).EndInit();
    ((ISupportInitialize) this.gridTags).EndInit();
    this.ds.EndInit();
    ((Control) this.UltraExplorerBarContainerControl3).ResumeLayout(false);
    this.pnlFormattingOptions.ResumeLayout(false);
    ((ISupportInitialize) this.gridFunctions).EndInit();
    ((ISupportInitialize) this.tagFunctionData).EndInit();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private virtual WordTemplate _wordTemplateHost
  {
    get => this.__wordTemplateHost;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.WordTemplateHost_WordAppClosed);
      WordTemplate wordTemplateHost1 = this.__wordTemplateHost;
      if (wordTemplateHost1 != null)
        wordTemplateHost1.WordAppClosed -= eventHandler;
      this.__wordTemplateHost = value;
      WordTemplate wordTemplateHost2 = this.__wordTemplateHost;
      if (wordTemplateHost2 == null)
        return;
      wordTemplateHost2.WordAppClosed += eventHandler;
    }
  }

  private frmDocumentTemplatesWordHost()
  {
    this.Load += new EventHandler(this.frmDocumentTemplatesWordHost_Load);
    this.SizeChanged += new EventHandler(this.frmDocumentTemplatesWordHost_SizeChanged);
    this.Closing += new CancelEventHandler(this.frmDocumentTemplatesWordHost_Closing);
    this.InitializeComponent();
  }

  public frmDocumentTemplatesWordHost(string fileName)
    : this(fileName, true)
  {
  }

  public frmDocumentTemplatesWordHost(string fileName, bool hideTagsPanel)
    : this()
  {
    this.LocalFileName = !string.IsNullOrWhiteSpace(fileName) ? fileName : throw new ArgumentNullException(nameof (fileName));
    UltraExplorerBar ultraExplorerBar1 = this.UltraExplorerBar1;
    ultraExplorerBar1.Groups["TagFormatting"].Visible = !hideTagsPanel;
    ultraExplorerBar1.Groups["DocumentTags"].Visible = !hideTagsPanel;
    ((Control) this.gridTags).Visible = !hideTagsPanel;
    this.Text = $"{this.Text} - {Path.GetFileName(this.LocalFileName)}";
  }

  public bool SaveAsRTF { get; set; }

  protected dsDocumentTemplatesWordHost.TagsDataTable TagsTable => this.ds.Tags;

  private string LocalFileName
  {
    get => this._localFileName;
    set
    {
      this._localFileName = value;
      if (string.IsNullOrEmpty(this._localFileName))
      {
        ErrorHandler.SilentHandleError(new Exception($"Local filename set to null; Me.SaveAsRTF={this.SaveAsRTF}; SystemInformation.TerminalServerSession={SystemInformation.TerminalServerSession}"));
      }
      else
      {
        if (File.Exists(this._localFileName))
          return;
        ErrorHandler.SilentHandleError(new Exception($"File does not exist after being set: {this._localFileName}; Me.SaveAsRTF={this.SaveAsRTF}; SystemInformation.TerminalServerSession={SystemInformation.TerminalServerSession}"));
      }
    }
  }

  public event frmDocumentTemplatesWordHost.WordDocumentSavedEventHandler WordDocumentSaved;

  public event frmDocumentTemplatesWordHost.WordDocumentClosedEventHandler WordDocumentClosed;

  public virtual void ShowAvailableTags(int templateID)
  {
    this._templateID = templateID;
    this.UltraExplorerBar1.Groups["TagFormatting"].Visible = true;
    this.UltraExplorerBar1.Groups["DocumentTags"].Visible = true;
    MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmDocumentTemplatesWordHost.ShowAvailableTagsThreadHandler(this.ShowAvailableTagsThread), (object) this._templateID);
  }

  private void frmDocumentTemplatesWordHost_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((UltraGridBase) this.gridFunctions).Rows[0].Activate();
    ((UltraGridBase) this.gridFunctions).Rows[0].Selected = true;
    try
    {
      byte[] origHash = (byte[]) null;
      using (FileStream inputStream = new FileStream(this.LocalFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
      {
        origHash = new MD5CryptoServiceProvider().ComputeHash((Stream) inputStream);
        inputStream.Close();
      }
      this._wordTemplateHost = new WordTemplate(this.LocalFileName, (Form) this, (object) new TemplateHash(this._templateID, origHash));
      this.UltraExplorerBar1.Groups["DocumentTags"].Expanded = true;
    }
    catch (COMException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to open this document in Microsoft Word.{"\n"}{"\n"}{ex.Message}", "Unable To Open Document", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.Close();
      ProjectData.ClearProjectError();
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      int num = (int) System.Windows.Forms.MessageBox.Show("An error has occured while loading this template document.{vbLf}{vbLf}If this problem persists, please contact technical support.", "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.Close();
      ProjectData.ClearProjectError();
    }
    this.ConfigureTemplatePanelSize();
  }

  private static bool InitializeSetting(string settingName, bool defaultValue)
  {
    return frmDocumentTemplatesWordHost.InitializeSetting(settingName, Convert.ToInt32(defaultValue)) > 0;
  }

  private static int InitializeSetting(string settingName, int defaultValue)
  {
    int num = Preferences.GetPreferenceInt($"DocumentAutomation.Override.{settingName}");
    if (num == -1)
      num = defaultValue;
    return num != -1 ? num : throw new InvalidOperationException($"DocumentAutomation setting cannot be null. Setting name: {settingName}");
  }

  private void ShowAvailableTagsThread(int templateID)
  {
    int templateGroupID = (int) DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT AutomationGroupID FROM tblDocumentTemplates WHERE TemplateID=@TemplateID", new object[2]
    {
      (object) "@TemplateID",
      (object) templateID
    });
    dsTemplateDocs.TagsDataTable availableTagList = ObjectFactory.Instance.CreateObjectAs<TagParserFactory>().GetAvailableTagList(templateGroupID);
    List<dsDocumentTemplatesWordHost.TagsRow> source1 = new List<dsDocumentTemplatesWordHost.TagsRow>();
    string empty = string.Empty;
    DataRow[] dataRowArray = availableTagList.Select(empty, "Tagname");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsTemplateDocs.TagsRow tagsRow1 = (dsTemplateDocs.TagsRow) dataRowArray[index];
      if (string.IsNullOrEmpty(tagsRow1.TagGroup))
        tagsRow1.TagGroup = "Ungrouped Tags";
      dsDocumentTemplatesWordHost.TagsRow tagsRow2 = this.ds.Tags.NewTagsRow();
      tagsRow2.Tag = tagsRow1.Tagname;
      tagsRow2.Description = tagsRow1.Description;
      tagsRow2.Group = tagsRow1.TagGroup;
      tagsRow2.IsCheckbox = tagsRow1.IsCheckbox;
      source1.Add(tagsRow2);
      checked { ++index; }
    }
    try
    {
      IOrderedEnumerable<dsDocumentTemplatesWordHost.TagsRow> source2 = source1.OrderBy<dsDocumentTemplatesWordHost.TagsRow, int>(new System.Func<dsDocumentTemplatesWordHost.TagsRow, int>(this.GetTagOrder));
      System.Func<dsDocumentTemplatesWordHost.TagsRow, string> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (frmDocumentTemplatesWordHost._Closure\u0024__.\u0024I84\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = frmDocumentTemplatesWordHost._Closure\u0024__.\u0024I84\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmDocumentTemplatesWordHost._Closure\u0024__.\u0024I84\u002D0 = keySelector = (System.Func<dsDocumentTemplatesWordHost.TagsRow, string>) ([SpecialName] (tg) => tg.Group);
      }
      foreach (dsDocumentTemplatesWordHost.TagsRow tagsRow in (IEnumerable<dsDocumentTemplatesWordHost.TagsRow>) source2.ThenBy<dsDocumentTemplatesWordHost.TagsRow, string>(keySelector))
        MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new frmDocumentTemplatesWordHost.AddGridRowHandler(this.AddGridRow), (object) tagsRow);
    }
    finally
    {
      IEnumerator<dsDocumentTemplatesWordHost.TagsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private int GetTagOrder(dsDocumentTemplatesWordHost.TagsRow tagRow)
  {
    string tag = tagRow.Tag;
    return !tag.StartsWith("RT_") ? (!tag.StartsWith("TableEnd:") ? (!tag.StartsWith("TableStart:") ? (!tag.StartsWith("UT_") ? (!tag.StartsWith("ER_") ? 1 : 2) : 3) : 4) : 5) : 6;
  }

  private void AddGridRow(dsDocumentTemplatesWordHost.TagsRow dr)
  {
    if (this.ds.Groups.FindByGroup(dr.Group) == null)
      this.ds.Groups.AddGroupsRow(dr.Group);
    this.ds.Tags.AddTagsRow(dr);
  }

  private void UltraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void frmDocumentTemplatesWordHost_SizeChanged(object sender, EventArgs e)
  {
    this.ConfigureTemplatePanelSize();
  }

  private void ConfigureTemplatePanelSize()
  {
    if (!this.UltraExplorerBar1.Groups["DocumentTags"].Visible)
      this.UltraExplorerBar1.Groups["Template"].ColumnsSpanned = 1;
    ((Control) this.UltraExplorerBar1.Groups["Template"].Container).Height = this.Height - 85;
  }

  private void lstAvailableTags_KeyUp(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
      return;
    this.AddSelectedTag();
  }

  private void gridTags_DoubleClick(object sender, EventArgs e)
  {
    if (!(((ControlUIElementBase) ((UltraGridBase) this.gridTags).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow)) is UltraGridRow context) || context.Band.Index != 1)
      return;
    this.AddSelectedTag();
  }

  private void AddSelectedTag()
  {
    string str1 = ((UltraGridBase) this.gridTags).ActiveRow.Cells["Tag"].Value.ToString();
    if (((UltraGridBase) this.gridFunctions).ActiveRow != null)
    {
      string str2 = ((UltraGridBase) this.gridFunctions).ActiveRow.Cells["TagFunction"].Value.ToString();
      if (!string.IsNullOrEmpty(str2))
        str1 = $"{str2}({str1})";
    }
    bool flag = (bool) ((UltraGridBase) this.gridTags).ActiveRow.Cells["IsCheckBox"].Value;
    this._wordTemplateHost.AddTag($"MERGEFIELD  {str1} ", str1, flag);
  }

  private void DoSave()
  {
    try
    {
      if (this._wordApplication != null)
      {
        try
        {
          // ISSUE: method pointer
          // ISSUE: object of a compiler-generated type is created
          new ComAwareEventInfo(typeof (ApplicationEvents2_Event), "DocumentBeforeSave").RemoveEventHandler((object) this._wordApplication, (Delegate) new ApplicationEvents2_DocumentBeforeSaveEventHandler((object) this, (UIntPtr) __methodptr(DocumentSaved)));
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    catch (Exception ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      if (exception is COMException || exception is InvalidComObjectException)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      int num = (int) System.Windows.Forms.MessageBox.Show($"Microsoft Word was unable to save this document.{"\n"}{"\n"}If this problem persists, please contact technical support.", "Could Not Save Document", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    this.Close();
    if (string.IsNullOrEmpty(this.LocalFileName))
      throw new InvalidOperationException($"fileName is null in DoSave; Me.SaveAsRTF={this.SaveAsRTF}; SystemInformation.TerminalServerSession={SystemInformation.TerminalServerSession}");
    if (!File.Exists(this.LocalFileName))
      throw new InvalidOperationException($"Do Save file name does not exist {this.LocalFileName}; Me.SaveAsRTF={this.SaveAsRTF}; SystemInformation.TerminalServerSession={SystemInformation.TerminalServerSession}");
    // ISSUE: reference to a compiler-generated field
    frmDocumentTemplatesWordHost.WordDocumentSavedEventHandler documentSavedEvent = this.WordDocumentSavedEvent;
    if (documentSavedEvent == null)
      return;
    documentSavedEvent((object) this, new WordDocumentSavedEventArgs(this.LocalFileName));
  }

  private void DocumentSaved(object doc, ref bool SaveAsUI, ref bool Cancel)
  {
    Cancel = true;
    if (File.Exists(this.LocalFileName))
    {
      // ISSUE: method pointer
      // ISSUE: object of a compiler-generated type is created
      new ComAwareEventInfo(typeof (ApplicationEvents2_Event), "DocumentBeforeSave").RemoveEventHandler((object) this._wordApplication, (Delegate) new ApplicationEvents2_DocumentBeforeSaveEventHandler((object) this, (UIntPtr) __methodptr(DocumentSaved)));
      try
      {
        // ISSUE: reference to a compiler-generated method
        this._wordApplication.ActiveDocument.Save();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    this.Invoke((Delegate) new MethodInvoker(this.SaveFile));
  }

  private void SaveFile()
  {
    Thread.Sleep(100);
    this.DoSave();
  }

  private void lnkSaveAs_Click(object sender, EventArgs e)
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      saveFileDialog.DefaultExt = ".doc";
      saveFileDialog.Filter = "Word Document (*.doc)|*.doc";
      do
      {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          this.LocalFileName = saveFileDialog.FileName;
          if (string.IsNullOrWhiteSpace(this.LocalFileName))
          {
            int num = (int) System.Windows.Forms.MessageBox.Show("Please pick a valid file name.", "Empty file name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
          goto label_5;
      }
      while (string.IsNullOrWhiteSpace(this.LocalFileName));
      goto label_10;
label_5:
      return;
    }
label_10:
    this.SaveFile();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this._wordApplication != null)
      {
        Marshal.FinalReleaseComObject((object) this._wordApplication);
        this._wordApplication = (Word.Application) null;
      }
      this._wordTemplateHost?.CloseWordApp();
      this.components?.Dispose();
    }
    base.Dispose(disposing);
  }

  private void txtGrpFilter_TextChanged(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridTags).DisplayLayout.Bands[0].ColumnFilters["Group"].FilterConditions).Count > 0)
      ((UltraGridBase) this.gridTags).DisplayLayout.Bands[0].ColumnFilters["Group"].ClearFilterConditions();
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtGrpFilter).Text))
      return;
    ((UltraGridBase) this.gridTags).DisplayLayout.Bands[0].ColumnFilters["Group"].FilterConditions.Add((FilterComparisionOperator) 14, (object) ((TextEditorControlBase) this.txtGrpFilter).Text);
  }

  private void txtTagFilter_TextChanged(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridTags).Rows)
    {
      if (((DisposableObjectCollectionBase) row.ChildBands[0].Rows.ColumnFilters["Tag"].FilterConditions).Count > 0)
        row.ChildBands[0].Rows.ColumnFilters["Tag"].ClearFilterConditions();
      if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtTagFilter).Text))
        row.ChildBands[0].Rows.ColumnFilters["Tag"].FilterConditions.Add((FilterComparisionOperator) 14, (object) ((TextEditorControlBase) this.txtTagFilter).Text);
      this.FilterGroup(row);
    }
  }

  private void txtTagDescription_TextChanged(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridTags).Rows)
    {
      if (((DisposableObjectCollectionBase) row.ChildBands[0].Rows.ColumnFilters["Description"].FilterConditions).Count > 0)
        row.ChildBands[0].Rows.ColumnFilters["Description"].ClearFilterConditions();
      if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtTagDescription).Text))
        row.ChildBands[0].Rows.ColumnFilters["Description"].FilterConditions.Add((FilterComparisionOperator) 14, (object) ((TextEditorControlBase) this.txtTagDescription).Text);
      this.FilterGroup(row);
    }
  }

  private void FilterGroup(UltraGridRow groupRow)
  {
    groupRow.Hidden = groupRow.ChildBands[0].Rows.FilteredInRowCount == 0;
  }

  private void WordTemplateHost_WordAppClosed(object sender, EventArgs e)
  {
    MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmDocumentTemplatesWordHost.CloseFormHandler(this.CloseForm));
  }

  private void CloseForm()
  {
    this.LinkLabel1.Enabled = false;
    if (this._wordTemplateHost.FileChanged)
      this.DoSave();
    // ISSUE: reference to a compiler-generated field
    frmDocumentTemplatesWordHost.WordDocumentClosedEventHandler documentClosedEvent = this.WordDocumentClosedEvent;
    if (documentClosedEvent != null)
      documentClosedEvent((object) this, new WordDocumentSavedEventArgs(this.LocalFileName));
    this.Close();
  }

  private void frmDocumentTemplatesWordHost_Closing(object sender, CancelEventArgs e)
  {
    this._wordTemplateHost.CloseWordApp();
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormOnSecondMonitorIfAvailableOA((Form) this, false);
      this._wordTemplateHost.RepositionWord();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentLogError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public delegate void WordDocumentSavedEventHandler(object sender, WordDocumentSavedEventArgs e);

  public delegate void WordDocumentClosedEventHandler(object sender, WordDocumentSavedEventArgs e);

  private delegate void ShowAvailableTagsThreadHandler(int templateID);

  private delegate void AddGridRowHandler(dsDocumentTemplatesWordHost.TagsRow dr);

  private delegate void CloseFormHandler();
}
