// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.frmDocumentTemplateInfo
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public sealed class frmDocumentTemplateInfo : MGABaseForm
{
  private IContainer components;
  private MGATextBox txtTemplateName;
  private MGATextBox txtDescription;
  private ErrorProvider err;
  private UltraToolbarsDockArea _frmDocumentTemplateInfo_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmDocumentTemplateInfo_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmDocumentTemplateInfo_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom;
  private UltraLabel lblFolderName;
  private bool _editWordDoc;
  private bool _cancel;
  private bool _updateTemplateGroupIDAfterTypeChange;
  private bool _showRefreshMsg;
  private dsDocumentTemplates.tblDocumentTemplatesRow _dr;
  private dsDocumentAutomation.tblDocumentFoldersDataTable _dtDocumentFolders;
  private int _originalAutomationGroupID;
  private int _templateGroupID;
  private string _originalTemplateName;
  private string _originalDescription;
  private DataTable _dtAutomationDocGroups;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASimpleComboBox cboTemplateTypes
  {
    get => this._cboTemplateTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboTemplateTypes_ValueChanged);
      MGASimpleComboBox cboTemplateTypes1 = this._cboTemplateTypes;
      if (cboTemplateTypes1 != null)
        cboTemplateTypes1.ValueChanged -= eventHandler;
      this._cboTemplateTypes = value;
      MGASimpleComboBox cboTemplateTypes2 = this._cboTemplateTypes;
      if (cboTemplateTypes2 == null)
        return;
      cboTemplateTypes2.ValueChanged += eventHandler;
    }
  }

  private virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  private virtual LinkLabel lnkChangeFolder
  {
    get => this._lnkChangeFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChangeFolder_LinkClicked);
      LinkLabel lnkChangeFolder1 = this._lnkChangeFolder;
      if (lnkChangeFolder1 != null)
        lnkChangeFolder1.LinkClicked -= clickedEventHandler;
      this._lnkChangeFolder = value;
      LinkLabel lnkChangeFolder2 = this._lnkChangeFolder;
      if (lnkChangeFolder2 == null)
        return;
      lnkChangeFolder2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("optionTemplateType")]
  internal virtual UltraOptionSet optionTemplateType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCheckEditor checkEditable
  {
    get => this._checkEditable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkEditable_CheckedChanged);
      UltraCheckEditor checkEditable1 = this._checkEditable;
      if (checkEditable1 != null)
        ((UltraToggleEditorBase) checkEditable1).CheckedChanged -= eventHandler;
      this._checkEditable = value;
      UltraCheckEditor checkEditable2 = this._checkEditable;
      if (checkEditable2 == null)
        return;
      ((UltraToggleEditorBase) checkEditable2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("optionSaveAs")]
  internal virtual UltraOptionSet optionSaveAs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkRemovable")]
  internal virtual UltraCheckEditor checkRemovable { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHideWatermark")]
  internal virtual UltraCheckEditor chkHideWatermark { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsTemplateDocs1")]
  internal virtual dsTemplateDocs DsTemplateDocs1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFileOnlyName")]
  private virtual MGATextBox txtFileOnlyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSeparateDocFileName")]
  private virtual MGATextBox txtSeparateDocFileName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCheckEditor chkSeparateDoc
  {
    get => this._chkSeparateDoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkSeperateDoc_CheckedChanged);
      UltraCheckEditor chkSeparateDoc1 = this._chkSeparateDoc;
      if (chkSeparateDoc1 != null)
        ((UltraToggleEditorBase) chkSeparateDoc1).CheckedChanged -= eventHandler;
      this._chkSeparateDoc = value;
      UltraCheckEditor chkSeparateDoc2 = this._chkSeparateDoc;
      if (chkSeparateDoc2 == null)
        return;
      ((UltraToggleEditorBase) chkSeparateDoc2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkRequiresEdit")]
  internal virtual UltraCheckEditor chkRequiresEdit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCopyForward")]
  internal virtual UltraCheckEditor chkCopyForward { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOnDemand")]
  internal virtual UltraCheckEditor chkOnDemand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCheckEditor checkFileOnly
  {
    get => this._checkFileOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkFileOnly_CheckedChanged);
      UltraCheckEditor checkFileOnly1 = this._checkFileOnly;
      if (checkFileOnly1 != null)
        ((UltraToggleEditorBase) checkFileOnly1).CheckedChanged -= eventHandler;
      this._checkFileOnly = value;
      UltraCheckEditor checkFileOnly2 = this._checkFileOnly;
      if (checkFileOnly2 == null)
        return;
      ((UltraToggleEditorBase) checkFileOnly2).CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolTipInfo ultraToolTipInfo1 = new UltraToolTipInfo("When checked, the \"Edit\" link will be available for this template document when it is created (for Microsoft Word documents only).", (ToolTipImage) 0, "Editable", (DefaultableBoolean) 0);
    UltraToolTipInfo ultraToolTipInfo2 = new UltraToolTipInfo("Documents marked \"File Only\" will be sent to the document handler in a separate PDF than the other documents assigned to the event.", (ToolTipImage) 0, "File Only", (DefaultableBoolean) 0);
    UltraToolTipInfo ultraToolTipInfo3 = new UltraToolTipInfo("When checked, the \"Remove\" link will be available for this template document when it is created.", (ToolTipImage) 0, "Removable", (DefaultableBoolean) 0);
    UltraToolTipInfo ultraToolTipInfo4 = new UltraToolTipInfo("Documents marked \"Separate Doc\" does not get combined into the PDF bundle, instead saving to the doc handler in word format.", (ToolTipImage) 0, "File Only", (DefaultableBoolean) 0);
    UltraToolTipInfo ultraToolTipInfo5 = new UltraToolTipInfo("Indicates whether to copy forward the completed template (edits) on renewal.", (ToolTipImage) 0, (string) null, (DefaultableBoolean) 0);
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("toolbar");
    ButtonTool buttonTool1 = new ButtonTool("Save and Close");
    ButtonTool buttonTool2 = new ButtonTool("Save and Edit Template");
    ButtonTool buttonTool3 = new ButtonTool("Exit Without Saving");
    ButtonTool buttonTool4 = new ButtonTool("Save and Close");
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentTemplateInfo));
    ButtonTool buttonTool5 = new ButtonTool("Save and Edit Template");
    Appearance appearance5 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("Exit Without Saving");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    ValueListItem valueListItem5 = new ValueListItem();
    ValueListItem valueListItem6 = new ValueListItem();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.checkEditable = new UltraCheckEditor();
    this.checkFileOnly = new UltraCheckEditor();
    this.checkRemovable = new UltraCheckEditor();
    this.chkSeparateDoc = new UltraCheckEditor();
    this.chkCopyForward = new UltraCheckEditor();
    this.cboTemplateTypes = new MGASimpleComboBox();
    this.txtTemplateName = new MGATextBox();
    this.txtDescription = new MGATextBox();
    this.err = new ErrorProvider(this.components);
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.lblFolderName = new UltraLabel();
    this.lnkChangeFolder = new LinkLabel();
    this.optionTemplateType = new UltraOptionSet();
    this.optionSaveAs = new UltraOptionSet();
    this.chkHideWatermark = new UltraCheckEditor();
    this.DsTemplateDocs1 = new dsTemplateDocs();
    this.txtFileOnlyName = new MGATextBox();
    this.txtSeparateDocFileName = new MGATextBox();
    this.chkRequiresEdit = new UltraCheckEditor();
    this.chkOnDemand = new UltraCheckEditor();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    UltraToolTipManager ultraToolTipManager = new UltraToolTipManager(this.components);
    ((ISupportInitialize) this.checkEditable).BeginInit();
    ((ISupportInitialize) this.checkFileOnly).BeginInit();
    ((ISupportInitialize) this.checkRemovable).BeginInit();
    ((ISupportInitialize) this.chkSeparateDoc).BeginInit();
    ((ISupportInitialize) this.chkCopyForward).BeginInit();
    ((ISupportInitialize) this.cboTemplateTypes).BeginInit();
    ((ISupportInitialize) this.txtTemplateName).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.optionTemplateType).BeginInit();
    ((ISupportInitialize) this.optionSaveAs).BeginInit();
    ((ISupportInitialize) this.chkHideWatermark).BeginInit();
    this.DsTemplateDocs1.BeginInit();
    ((ISupportInitialize) this.txtFileOnlyName).BeginInit();
    ((ISupportInitialize) this.txtSeparateDocFileName).BeginInit();
    ((ISupportInitialize) this.chkRequiresEdit).BeginInit();
    ((ISupportInitialize) this.chkOnDemand).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(11, 18);
    label1.Name = "Label1";
    label1.Size = new Size(82, 13);
    label1.TabIndex = 0;
    label1.Text = "Template Type:";
    label1.TextAlign = ContentAlignment.MiddleLeft;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(11, 78);
    label2.Name = "Label2";
    label2.Size = new Size(85, 13);
    label2.TabIndex = 2;
    label2.Text = "Template Name:";
    label2.TextAlign = ContentAlignment.MiddleLeft;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(11, 104);
    label3.Name = "Label3";
    label3.Size = new Size(64 /*0x40*/, 13);
    label3.TabIndex = 5;
    label3.Text = "Description:";
    label3.TextAlign = ContentAlignment.MiddleLeft;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(11, 48 /*0x30*/);
    label4.Name = "Label4";
    label4.Size = new Size(79, 13);
    label4.TabIndex = 10;
    label4.Text = "Default Folder:";
    label4.TextAlign = ContentAlignment.MiddleLeft;
    label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(11, 383);
    label5.Name = "Label5";
    label5.Size = new Size(50, 13);
    label5.TabIndex = 28;
    label5.Text = "Save As:";
    label5.TextAlign = ContentAlignment.MiddleLeft;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(11, 226);
    label6.Name = "Label6";
    label6.Size = new Size(31 /*0x1F*/, 13);
    label6.TabIndex = 29;
    label6.Text = "Type";
    label6.TextAlign = ContentAlignment.MiddleLeft;
    ultraToolTipManager.ContainingControl = (Control) this;
    ultraToolTipManager.DisplayStyle = (ToolTipDisplayStyle) 3;
    ultraToolTipManager.ToolTipImage = (ToolTipImage) 3;
    ((UltraToggleEditorBase) this.checkEditable).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkEditable).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkEditable).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkEditable).Location = new Point(98, 278);
    ((Control) this.checkEditable).Name = "checkEditable";
    ((Control) this.checkEditable).Size = new Size(74, 20);
    ((Control) this.checkEditable).TabIndex = 22;
    ((UltraToggleEditorBase) this.checkEditable).Text = "Editable";
    ultraToolTipInfo1.ToolTipText = "When checked, the \"Edit\" link will be available for this template document when it is created (for Microsoft Word documents only).";
    ultraToolTipInfo1.ToolTipTitle = "Editable";
    ultraToolTipManager.SetUltraToolTip((Control) this.checkEditable, ultraToolTipInfo1);
    ((Control) this.checkFileOnly).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraToggleEditorBase) this.checkFileOnly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkFileOnly).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkFileOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkFileOnly).Location = new Point(98, 330);
    ((Control) this.checkFileOnly).Name = "checkFileOnly";
    ((Control) this.checkFileOnly).Size = new Size(74, 20);
    ((Control) this.checkFileOnly).TabIndex = 34;
    ((UltraToggleEditorBase) this.checkFileOnly).Text = "File Only";
    ultraToolTipInfo2.ToolTipText = "Documents marked \"File Only\" will be sent to the document handler in a separate PDF than the other documents assigned to the event.";
    ultraToolTipInfo2.ToolTipTitle = "File Only";
    ultraToolTipManager.SetUltraToolTip((Control) this.checkFileOnly, ultraToolTipInfo2);
    ((UltraToggleEditorBase) this.checkRemovable).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkRemovable).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkRemovable).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkRemovable).Location = new Point(98, 252);
    ((Control) this.checkRemovable).Name = "checkRemovable";
    ((Control) this.checkRemovable).Size = new Size(78, 20);
    ((Control) this.checkRemovable).TabIndex = 39;
    ((UltraToggleEditorBase) this.checkRemovable).Text = "Removable";
    ultraToolTipInfo3.ToolTipText = "When checked, the \"Remove\" link will be available for this template document when it is created.";
    ultraToolTipInfo3.ToolTipTitle = "Removable";
    ultraToolTipManager.SetUltraToolTip((Control) this.checkRemovable, ultraToolTipInfo3);
    ((Control) this.chkSeparateDoc).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraToggleEditorBase) this.chkSeparateDoc).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSeparateDoc).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSeparateDoc).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSeparateDoc).Location = new Point(98, 356);
    ((Control) this.chkSeparateDoc).Name = "chkSeparateDoc";
    ((Control) this.chkSeparateDoc).Size = new Size(102, 20);
    ((Control) this.chkSeparateDoc).TabIndex = 54;
    ((UltraToggleEditorBase) this.chkSeparateDoc).Text = "Separate Doc";
    ultraToolTipInfo4.ToolTipText = "Documents marked \"Separate Doc\" does not get combined into the PDF bundle, instead saving to the doc handler in word format.";
    ultraToolTipInfo4.ToolTipTitle = "File Only";
    ultraToolTipManager.SetUltraToolTip((Control) this.chkSeparateDoc, ultraToolTipInfo4);
    ((UltraToggleEditorBase) this.chkCopyForward).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCopyForward).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCopyForward).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCopyForward).Location = new Point(205, 278);
    ((Control) this.chkCopyForward).Name = "chkCopyForward";
    ((Control) this.chkCopyForward).Size = new Size(106, 20);
    ((Control) this.chkCopyForward).TabIndex = 44;
    ((UltraToggleEditorBase) this.chkCopyForward).Text = "Copy Forward";
    ultraToolTipInfo5.ToolTipText = "Indicates whether to copy forward the completed template (edits) on renewal.";
    ultraToolTipManager.SetUltraToolTip((Control) this.chkCopyForward, ultraToolTipInfo5);
    this.cboTemplateTypes.BorderStyle = (UIElementBorderStyle) 4;
    this.cboTemplateTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboTemplateTypes).Location = new Point(98, 14);
    this.cboTemplateTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboTemplateTypes).Name = "cboTemplateTypes";
    ((Control) this.cboTemplateTypes).Size = new Size(344, 21);
    ((Control) this.cboTemplateTypes).TabIndex = 1;
    ((UltraControlBase) this.cboTemplateTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboTemplateTypes).UseOsThemes = (DefaultableBoolean) 2;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTemplateName).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtTemplateName).BackColor = Color.White;
    ((Control) this.txtTemplateName).Location = new Point(98, 74);
    ((TextEditorControlBase) this.txtTemplateName).MaxLength = 70;
    this.txtTemplateName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTemplateName).Name = "txtTemplateName";
    ((Control) this.txtTemplateName).Size = new Size(344, 20);
    ((Control) this.txtTemplateName).TabIndex = 3;
    ((UltraControlBase) this.txtTemplateName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTemplateName).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).Location = new Point(98, 104);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 500;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    this.txtDescription.Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(344, 112 /*0x70*/);
    ((Control) this.txtDescription).TabIndex = 4;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left).BackColor = Color.DarkGray;
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left).Name = "_frmDocumentTemplateInfo_Toolbars_Dock_Area_Left";
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left).Size = new Size(0, 416);
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    appearance3.BackColor = Color.DarkGray;
    this.UltraToolbarsManager1.DockAreaAppearance = (AppearanceBase) appearance3;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ImageTransparentColor = Color.Magenta;
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedPosition = (DockedPosition) 1;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ultraToolbar.Text = "toolbar";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.UltraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.UltraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((ToolbarSettingsBase) this.UltraToolbarsManager1.ToolbarSettings).PaddingLeft = 5;
    ((ToolbarSettingsBase) this.UltraToolbarsManager1.ToolbarSettings).PaddingRight = 5;
    ((SettingsBase) this.UltraToolbarsManager1.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((ToolbarSettingsBase) this.UltraToolbarsManager1.ToolbarSettings).ToolSpacing = 10;
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Save and Close";
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Save and Edit Template";
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Exit Without Saving";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right).BackColor = Color.DarkGray;
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right).Location = new Point(454, 0);
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right).Name = "_frmDocumentTemplateInfo_Toolbars_Dock_Area_Right";
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right).Size = new Size(0, 416);
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top).BackColor = Color.DarkGray;
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top).Name = "_frmDocumentTemplateInfo_Toolbars_Dock_Area_Top";
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top).Size = new Size(454, 0);
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom).BackColor = Color.DarkGray;
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom).Location = new Point(0, 416);
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom).Name = "_frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom).Size = new Size(454, 25);
    this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblFolderName).Appearance = (AppearanceBase) appearance7;
    this.lblFolderName.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblFolderName).Location = new Point(98, 44);
    ((Control) this.lblFolderName).Name = "lblFolderName";
    ((Control) this.lblFolderName).Size = new Size(238, 20);
    ((Control) this.lblFolderName).TabIndex = 11;
    this.lnkChangeFolder.BackColor = Color.Transparent;
    this.lnkChangeFolder.Location = new Point(358, 44);
    this.lnkChangeFolder.Name = "lnkChangeFolder";
    this.lnkChangeFolder.Size = new Size(84, 23);
    this.lnkChangeFolder.TabIndex = 12;
    this.lnkChangeFolder.TabStop = true;
    this.lnkChangeFolder.Text = "(change folder)";
    this.lnkChangeFolder.TextAlign = ContentAlignment.MiddleLeft;
    this.optionTemplateType.BackColor = Color.Transparent;
    this.optionTemplateType.BackColorInternal = Color.Transparent;
    this.optionTemplateType.BorderStyle = (UIElementBorderStyle) 1;
    valueListItem1.DataValue = (object) "F";
    valueListItem1.DisplayText = "Policy Form";
    valueListItem2.DataValue = (object) "L";
    valueListItem2.DisplayText = "Letter";
    valueListItem3.DataValue = (object) "E";
    valueListItem3.DisplayText = "Email";
    this.optionTemplateType.Items.AddRange(new ValueListItem[3]
    {
      valueListItem1,
      valueListItem2,
      valueListItem3
    });
    this.optionTemplateType.ItemSpacingHorizontal = 28;
    ((Control) this.optionTemplateType).Location = new Point(98, 226);
    ((Control) this.optionTemplateType).Margin = new Padding(3, 3, 6, 3);
    ((Control) this.optionTemplateType).Name = "optionTemplateType";
    ((Control) this.optionTemplateType).Size = new Size(307, 20);
    ((Control) this.optionTemplateType).TabIndex = 17;
    ((Control) this.optionSaveAs).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.optionSaveAs.BackColor = Color.Transparent;
    this.optionSaveAs.BackColorInternal = Color.Transparent;
    this.optionSaveAs.BorderStyle = (UIElementBorderStyle) 1;
    valueListItem4.DataValue = (object) "W";
    valueListItem4.DisplayText = "Microsoft Word";
    valueListItem5.DataValue = (object) "P";
    valueListItem5.DisplayText = "PDF";
    valueListItem6.DataValue = (object) "E";
    valueListItem6.DisplayText = "Microsoft Excel";
    this.optionSaveAs.Items.AddRange(new ValueListItem[3]
    {
      valueListItem4,
      valueListItem5,
      valueListItem6
    });
    this.optionSaveAs.ItemSpacingHorizontal = 10;
    ((Control) this.optionSaveAs).Location = new Point(98, 383);
    ((Control) this.optionSaveAs).Name = "optionSaveAs";
    ((Control) this.optionSaveAs).Size = new Size(279, 23);
    ((Control) this.optionSaveAs).TabIndex = 27;
    ((UltraToggleEditorBase) this.chkHideWatermark).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideWatermark).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideWatermark).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideWatermark).Location = new Point(205, 252);
    ((Control) this.chkHideWatermark).Name = "chkHideWatermark";
    ((Control) this.chkHideWatermark).Size = new Size(106, 20);
    ((Control) this.chkHideWatermark).TabIndex = 44;
    ((UltraToggleEditorBase) this.chkHideWatermark).Text = "Hide watermark";
    this.DsTemplateDocs1.DataSetName = "dsTemplateDocs";
    this.DsTemplateDocs1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.txtFileOnlyName).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFileOnlyName).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtFileOnlyName).BackColor = Color.White;
    ((Control) this.txtFileOnlyName).Location = new Point(205, 329);
    ((TextEditorControlBase) this.txtFileOnlyName).MaxLength = 100;
    this.txtFileOnlyName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFileOnlyName).Name = "txtFileOnlyName";
    ((Control) this.txtFileOnlyName).Size = new Size(241, 20);
    ((Control) this.txtFileOnlyName).TabIndex = 49;
    ((UltraControlBase) this.txtFileOnlyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFileOnlyName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtSeparateDocFileName).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSeparateDocFileName).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtSeparateDocFileName).BackColor = Color.White;
    ((Control) this.txtSeparateDocFileName).Location = new Point(205, 355);
    ((TextEditorControlBase) this.txtSeparateDocFileName).MaxLength = 100;
    this.txtSeparateDocFileName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSeparateDocFileName).Name = "txtSeparateDocFileName";
    ((Control) this.txtSeparateDocFileName).Size = new Size(241, 20);
    ((Control) this.txtSeparateDocFileName).TabIndex = 55;
    ((UltraControlBase) this.txtSeparateDocFileName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSeparateDocFileName).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.chkRequiresEdit).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRequiresEdit).BackColorInternal = Color.Transparent;
    ((Control) this.chkRequiresEdit).Enabled = false;
    ((UltraToggleEditorBase) this.chkRequiresEdit).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRequiresEdit).Location = new Point(98, 304);
    ((Control) this.chkRequiresEdit).Name = "chkRequiresEdit";
    ((Control) this.chkRequiresEdit).Size = new Size(106, 20);
    ((Control) this.chkRequiresEdit).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkRequiresEdit).Text = "Requires Edit";
    ((UltraToggleEditorBase) this.chkOnDemand).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnDemand).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnDemand).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOnDemand).Location = new Point(336, 252);
    ((Control) this.chkOnDemand).Name = "chkOnDemand";
    ((Control) this.chkOnDemand).Size = new Size(106, 20);
    ((Control) this.chkOnDemand).TabIndex = 60;
    ((UltraToggleEditorBase) this.chkOnDemand).Text = "On Demand";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(454, 441);
    this.Controls.Add((Control) this.chkOnDemand);
    this.Controls.Add((Control) this.txtSeparateDocFileName);
    this.Controls.Add((Control) this.chkSeparateDoc);
    this.Controls.Add((Control) this.txtFileOnlyName);
    this.Controls.Add((Control) this.chkCopyForward);
    this.Controls.Add((Control) this.chkHideWatermark);
    this.Controls.Add((Control) this.checkRemovable);
    this.Controls.Add((Control) this.checkFileOnly);
    this.Controls.Add((Control) label6);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) this.optionSaveAs);
    this.Controls.Add((Control) this.chkRequiresEdit);
    this.Controls.Add((Control) this.checkEditable);
    this.Controls.Add((Control) this.optionTemplateType);
    this.Controls.Add((Control) this.lnkChangeFolder);
    this.Controls.Add((Control) this.lblFolderName);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.txtDescription);
    this.Controls.Add((Control) this.txtTemplateName);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.cboTemplateTypes);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmDocumentTemplateInfo_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmDocumentTemplateInfo);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Template Info";
    ((ISupportInitialize) this.checkEditable).EndInit();
    ((ISupportInitialize) this.checkFileOnly).EndInit();
    ((ISupportInitialize) this.checkRemovable).EndInit();
    ((ISupportInitialize) this.chkSeparateDoc).EndInit();
    ((ISupportInitialize) this.chkCopyForward).EndInit();
    ((ISupportInitialize) this.cboTemplateTypes).EndInit();
    ((ISupportInitialize) this.txtTemplateName).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.optionTemplateType).EndInit();
    ((ISupportInitialize) this.optionSaveAs).EndInit();
    ((ISupportInitialize) this.chkHideWatermark).EndInit();
    this.DsTemplateDocs1.EndInit();
    ((ISupportInitialize) this.txtFileOnlyName).EndInit();
    ((ISupportInitialize) this.txtSeparateDocFileName).EndInit();
    ((ISupportInitialize) this.chkRequiresEdit).EndInit();
    ((ISupportInitialize) this.chkOnDemand).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmDocumentTemplateInfo()
  {
    this.Load += new EventHandler(this.frmDocumentTemplateInfo_Load);
    this._dtDocumentFolders = new dsDocumentAutomation.tblDocumentFoldersDataTable();
    this._originalAutomationGroupID = 0;
    this._templateGroupID = 0;
    this._originalTemplateName = string.Empty;
    this._originalDescription = string.Empty;
    this._dtAutomationDocGroups = new DataTable();
    this.InitializeComponent();
  }

  public frmDocumentTemplateInfo(dsDocumentTemplates.tblDocumentTemplatesRow dr)
    : this()
  {
    this._dr = dr;
  }

  public bool Removeable => ((UltraToggleEditorBase) this.checkRemovable).Checked;

  public bool Cancel => this._cancel;

  public bool FileOnly => ((UltraToggleEditorBase) this.checkFileOnly).Checked;

  public bool SeperateDoc => ((UltraToggleEditorBase) this.chkSeparateDoc).Checked;

  public bool EditWordDoc => this._editWordDoc;

  public int AutomationGroupID => Conversions.ToInteger(this.cboTemplateTypes.Value);

  public string TemplateName => ((TextEditorControlBase) this.txtTemplateName).Text;

  public string TemplateDescription => ((TextEditorControlBase) this.txtDescription).Text;

  public bool HasFolderID
  {
    get
    {
      return Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((Control) this.lblFolderName).Tag)) && this.lnkChangeFolder.Enabled;
    }
  }

  public int FolderID
  {
    get
    {
      int tag;
      if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(((Control) this.lblFolderName).Tag)))
        tag = (int) ((Control) this.lblFolderName).Tag;
      return tag;
    }
  }

  public bool IsEditable => ((UltraToggleEditorBase) this.checkEditable).Checked;

  public bool RequiresEdit => ((UltraToggleEditorBase) this.chkRequiresEdit).Checked;

  public bool IsPolicyForm
  {
    get => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.optionTemplateType.Value.ToString(), "F", false) == 0;
  }

  public bool IsEmail
  {
    get => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.optionTemplateType.Value.ToString(), "E", false) == 0;
  }

  public string SaveAsType => (string) this.optionSaveAs.Value;

  public bool HideWaterMark => ((UltraToggleEditorBase) this.chkHideWatermark).Checked;

  public bool OnDemand => ((UltraToggleEditorBase) this.chkOnDemand).Checked;

  public bool CopyForwardOnRenewals => ((UltraToggleEditorBase) this.chkCopyForward).Checked;

  public string FolderName => ((ControlBase) this.lblFolderName).Text;

  public bool UpdateTemplateGroupIDAfterTypeChange => this._updateTemplateGroupIDAfterTypeChange;

  public bool ShowRefreshMessage => this._showRefreshMsg;

  private void frmDocumentTemplateInfo_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataTable((DataTable) this._dtDocumentFolders, CommandType.Text, "SELECT FolderID, ParentFolderID, FolderName FROM dbo.tblDocumentFolders ORDER BY FolderName, ParentFolderID");
    this._dtAutomationDocGroups.TableName = "lstDocumentAutomationGroups";
    DefaultDatabase.LoadDataTable(this._dtAutomationDocGroups, CommandType.Text, "SELECT * FROM lstDocumentAutomationGroups");
    MGASimpleComboBox cboTemplateTypes = this.cboTemplateTypes;
    ((UltraGridBase) cboTemplateTypes).DataSource = (object) this._dtAutomationDocGroups;
    ((UltraDropDownBase) cboTemplateTypes).DisplayMember = "TemplateGroup";
    ((UltraDropDownBase) cboTemplateTypes).ValueMember = "ID";
    this.optionSaveAs.ValueChanged += new EventHandler(this.optionSaveAs_ValueChanged);
    if (this._dr != null)
    {
      this.lnkChangeFolder.Enabled = ((TemplateDocOptions) ObjectFactory.Instance.CreateObject(typeof (TemplateDocOptions))).GetCanChangeFolder(this._dr.AutomationGroupID);
      this.cboTemplateTypes.Value = (object) this._dr.AutomationGroupID;
      ((TextEditorControlBase) this.txtDescription).Text = this._dr.Description;
      ((TextEditorControlBase) this.txtTemplateName).Text = this._dr.TemplateName;
      this.optionTemplateType.Value = !this._dr.IsPolicyForm ? (object) "L" : (object) "F";
      if (this._dr.IsEmail)
        this.optionTemplateType.Value = (object) "E";
      ((UltraToggleEditorBase) this.checkEditable).Checked = this._dr.IsEditable;
      ((UltraToggleEditorBase) this.chkRequiresEdit).Checked = this._dr.RequiresEdit;
      ((UltraToggleEditorBase) this.checkFileOnly).Checked = this._dr.FileOnly;
      ((UltraToggleEditorBase) this.chkSeparateDoc).Checked = this._dr.SeparateDoc;
      if (this._dr.IsFileOnlyNameNull())
        ((TextEditorControlBase) this.txtFileOnlyName).Text = "";
      else
        ((TextEditorControlBase) this.txtFileOnlyName).Text = this._dr.FileOnlyName;
      if (this._dr.IsSeparateDocNameNull())
        ((TextEditorControlBase) this.txtSeparateDocFileName).Text = "";
      else
        ((TextEditorControlBase) this.txtSeparateDocFileName).Text = this._dr.SeparateDocName;
      ((Control) this.txtFileOnlyName).Enabled = ((UltraToggleEditorBase) this.checkFileOnly).Checked;
      ((Control) this.txtSeparateDocFileName).Enabled = ((UltraToggleEditorBase) this.chkSeparateDoc).Checked;
      ((UltraToggleEditorBase) this.checkRemovable).Checked = this._dr.Removable;
      if (!this._dr.IsFolderIDNull())
      {
        ((Control) this.lblFolderName).Tag = (object) this._dr.FolderID;
        ((ControlBase) this.lblFolderName).Text = this._dtDocumentFolders.FindByFolderID(this._dr.FolderID).FolderName;
      }
      if (this._dr.TemplateType.Equals("P"))
      {
        ((UltraToggleEditorBase) this.checkEditable).Checked = false;
        ((Control) this.checkEditable).Enabled = false;
        this.optionSaveAs.Value = (object) "P";
        ((Control) this.optionSaveAs).Enabled = false;
      }
      else
        this.optionSaveAs.Value = (object) this._dr.SaveAsType;
      ((UltraToggleEditorBase) this.chkHideWatermark).Checked = this._dr.HideWaterMark;
      ((UltraToggleEditorBase) this.chkOnDemand).Checked = this._dr.OnDemand;
      ((UltraToggleEditorBase) this.chkCopyForward).Checked = this._dr.CopyForwardOnRenewal;
      this._originalAutomationGroupID = this._dr.AutomationGroupID;
      if (this._dr.IsTemplateGroupIDNull())
        return;
      this._templateGroupID = this._dr.TemplateGroupID;
    }
    else
    {
      ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Save and Close"].SharedProps.Visible = false;
      this.optionTemplateType.Value = (object) "F";
      ((UltraToggleEditorBase) this.chkCopyForward).Checked = true;
      this.optionSaveAs.Value = (object) "P";
      this.lnkChangeFolder.Enabled = false;
    }
  }

  private void cboTemplateTypes_ValueChanged(object sender, EventArgs e)
  {
    int automationGroupID = 1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboTemplateTypes.Value.ToString(), "", false) != 0)
      automationGroupID = Conversions.ToInteger(this.cboTemplateTypes.Value);
    this.lnkChangeFolder.Enabled = ((TemplateDocOptions) ObjectFactory.Instance.CreateObject(typeof (TemplateDocOptions))).GetCanChangeFolder(automationGroupID);
    if (this.lnkChangeFolder.Enabled)
      return;
    ((ControlBase) this.lblFolderName).Text = string.Empty;
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Save and Close", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Save and Edit Template", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Exit Without Saving", false) != 0)
          return;
        this._cancel = true;
        this.Close();
      }
      else
      {
        if (!this.SaveData())
          return;
        this._editWordDoc = true;
        this.Close();
      }
    }
    else
    {
      if (!this.SaveData())
        return;
      this.Close();
    }
  }

  private bool IsValidForm()
  {
    bool flag = true;
    if (this.cboTemplateTypes.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboTemplateTypes, "Please select a template type.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboTemplateTypes, string.Empty);
    if (((TextEditorControlBase) this.txtTemplateName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtTemplateName, "Please enter a name for this template.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtTemplateName, string.Empty);
    return flag;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private bool SaveData()
  {
    bool flag;
    if (this.IsValidForm())
    {
      if (this._dr != null)
      {
        dsDocumentTemplates.tblDocumentTemplatesRow dr = this._dr;
        dr.TemplateName = ((TextEditorControlBase) this.txtTemplateName).Text;
        dr.Description = ((TextEditorControlBase) this.txtDescription).Text;
        dr.AutomationGroupID = Conversions.ToInteger(this.cboTemplateTypes.Value);
        if (this.HasFolderID && this.lnkChangeFolder.Enabled)
          dr.FolderID = Conversions.ToInteger(((Control) this.lblFolderName).Tag);
        else
          dr.SetFolderIDNull();
        dr.IsPolicyForm = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.optionTemplateType.Value.ToString(), "F", false) == 0;
        dr.IsEditable = ((UltraToggleEditorBase) this.checkEditable).Checked;
        dr.RequiresEdit = ((UltraToggleEditorBase) this.chkRequiresEdit).Checked;
        dr.IsEmail = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.optionTemplateType.Value.ToString(), "E", false) == 0;
        dr.FileOnly = ((UltraToggleEditorBase) this.checkFileOnly).Checked;
        dr.SaveAsType = (string) this.optionSaveAs.Value;
        dr.Removable = ((UltraToggleEditorBase) this.checkRemovable).Checked;
        dr.HideWaterMark = ((UltraToggleEditorBase) this.chkHideWatermark).Checked;
        dr.OnDemand = ((UltraToggleEditorBase) this.chkOnDemand).Checked;
        dr.CopyForwardOnRenewal = ((UltraToggleEditorBase) this.chkCopyForward).Checked;
        dr.FileOnlyName = ((TextEditorControlBase) this.txtFileOnlyName).Text;
        dr.SeparateDoc = ((UltraToggleEditorBase) this.chkSeparateDoc).Checked;
        dr.SeparateDocName = ((TextEditorControlBase) this.txtSeparateDocFileName).Text;
        this._updateTemplateGroupIDAfterTypeChange = Conversions.ToInteger(this.cboTemplateTypes.Value) != this._originalAutomationGroupID && this._templateGroupID > 0;
        this._showRefreshMsg = Conversions.ToInteger(this.cboTemplateTypes.Value) != this._originalAutomationGroupID;
      }
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  private void lnkChangeFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    frmSelectDocumentFolder selectDocumentFolder = (frmSelectDocumentFolder) MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormDialog(typeof (frmSelectDocumentFolder), (object) this._dtDocumentFolders);
    try
    {
      if (selectDocumentFolder.FolderSelected)
      {
        ((ControlBase) this.lblFolderName).Text = selectDocumentFolder.FolderName;
        ((Control) this.lblFolderName).Tag = (object) selectDocumentFolder.FolderID;
      }
      else
      {
        ((ControlBase) this.lblFolderName).Text = string.Empty;
        ((Control) this.lblFolderName).Tag = (object) null;
      }
    }
    finally
    {
      selectDocumentFolder.Dispose();
    }
  }

  private void checkFileOnly_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.txtFileOnlyName).Enabled = ((UltraToggleEditorBase) this.checkFileOnly).Checked;
    if (((UltraToggleEditorBase) this.checkFileOnly).Checked)
      return;
    ((TextEditorControlBase) this.txtFileOnlyName).Text = "";
  }

  private void chkSeperateDoc_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.txtSeparateDocFileName).Enabled = ((UltraToggleEditorBase) this.chkSeparateDoc).Checked;
    if (((UltraToggleEditorBase) this.chkSeparateDoc).Checked)
      return;
    ((TextEditorControlBase) this.txtSeparateDocFileName).Text = "";
  }

  private void checkEditable_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.chkRequiresEdit).Enabled = ((UltraToggleEditorBase) this.checkEditable).Checked;
    if (((UltraToggleEditorBase) this.checkEditable).Checked)
      return;
    ((UltraToggleEditorBase) this.chkRequiresEdit).Checked = false;
  }

  private void optionSaveAs_ValueChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.SaveAsType, "E", false) == 0)
    {
      ((UltraToggleEditorBase) this.chkSeparateDoc).Checked = true;
      ((Control) this.chkSeparateDoc).Enabled = false;
    }
    else
      ((Control) this.chkSeparateDoc).Enabled = true;
  }
}
