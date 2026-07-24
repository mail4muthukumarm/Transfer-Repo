// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormMultiCurrencyAdmin
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormMultiCurrencyAdmin : FormBase
{
  private IContainer components;

  public FormMultiCurrencyAdmin()
  {
    this.Load += new EventHandler(this.FormMultiCurrencyAdmin_Load);
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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Currencies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CurrencyCode");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Currency");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Save");
    ButtonTool buttonTool2 = new ButtonTool("Cancel");
    ButtonTool buttonTool3 = new ButtonTool("Edit Selected");
    ButtonTool buttonTool4 = new ButtonTool("Clear");
    ButtonTool buttonTool5 = new ButtonTool("Save");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("Cancel");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool7 = new ButtonTool("Edit Selected");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("Clear");
    Appearance appearance18 = new Appearance();
    this.textCurrencyCode = new MGATextBox();
    this.textDescription = new MGATextBox();
    this.FormMultiCurrencyAdmin_Fill_Panel = new UltraPanel();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.gridCurrencies = new UltraGrid();
    this.DsCurrencies1 = new dsCurrencies();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.textCurrencyCode).BeginInit();
    ((ISupportInitialize) this.textDescription).BeginInit();
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.gridCurrencies).BeginInit();
    this.DsCurrencies1.BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCurrencyCode).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.textCurrencyCode).BackColor = Color.White;
    ((Control) this.textCurrencyCode).Location = new Point(96 /*0x60*/, 7);
    this.textCurrencyCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCurrencyCode).Name = "textCurrencyCode";
    ((Control) this.textCurrencyCode).Size = new Size(76, 20);
    ((Control) this.textCurrencyCode).TabIndex = 0;
    ((UltraControlBase) this.textCurrencyCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCurrencyCode).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDescription).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.textDescription).BackColor = Color.White;
    ((Control) this.textDescription).Location = new Point(96 /*0x60*/, 33);
    this.textDescription.MGAStyle = MGAStyles.Blue;
    this.textDescription.Multiline = true;
    ((Control) this.textDescription).Name = "textDescription";
    ((Control) this.textDescription).Size = new Size(301, 69);
    ((Control) this.textDescription).TabIndex = 1;
    ((UltraControlBase) this.textDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDescription).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.Transparent;
    this.FormMultiCurrencyAdmin_Fill_Panel.Appearance = (AppearanceBase) appearance3;
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).Controls.Add((Control) this.textDescription);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).Controls.Add((Control) this.Label2);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).Controls.Add((Control) this.Label1);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).Controls.Add((Control) this.textCurrencyCode);
    ((UltraControlBase) this.FormMultiCurrencyAdmin_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).Location = new Point(0, 42);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).Name = "FormMultiCurrencyAdmin_Fill_Panel";
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).Size = new Size(412, 318);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).TabIndex = 0;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.gridCurrencies);
    ((Control) this.UltraGroupBox1).Location = new Point(3, 101);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(406, 213);
    ((Control) this.UltraGroupBox1).TabIndex = 4;
    this.UltraGroupBox1.Text = "Currencies";
    ((UltraGridBase) this.gridCurrencies).DataSource = (object) this.DsCurrencies1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Currency Code";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 91;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Description";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 300;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.WhiteSmoke;
    appearance13.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridCurrencies).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridCurrencies).Location = new Point(7, 21);
    ((Control) this.gridCurrencies).Name = "gridCurrencies";
    ((Control) this.gridCurrencies).Size = new Size(393, 186);
    ((Control) this.gridCurrencies).TabIndex = 0;
    ((UltraControlBase) this.gridCurrencies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCurrencies).UseOsThemes = (DefaultableBoolean) 2;
    this.DsCurrencies1.DataSetName = "dsCurrencies";
    this.DsCurrencies1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(9, 33);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Description:";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(9, 7);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(83, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Currency Code:";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).Location = new Point(0, 42);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).Size = new Size(0, 318);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 8;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(370, 171);
    ultraToolbar.FloatingSize = new Size(105, 104);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ultraToolbar.Text = "UltraToolbar1";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.UltraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.CaptionPlacement = (TextPlacement) 2;
    this.UltraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.UltraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    appearance15.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance16.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance17.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Edit Selected";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance18.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.arrow_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Clear";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).Location = new Point(412, 42);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).Size = new Size(0, 318);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).Size = new Size(412, 42);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).Location = new Point(0, 360);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).Size = new Size(412, 0);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(412, 360);
    this.ControlBox = false;
    this.Controls.Add((Control) this.FormMultiCurrencyAdmin_Fill_Panel);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormMultiCurrencyAdmin);
    this.Text = "Currency Administration";
    ((ISupportInitialize) this.textCurrencyCode).EndInit();
    ((ISupportInitialize) this.textDescription).EndInit();
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.FormMultiCurrencyAdmin_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.gridCurrencies).EndInit();
    this.DsCurrencies1.EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("textCurrencyCode")]
  internal virtual MGATextBox textCurrencyCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textDescription")]
  internal virtual MGATextBox textDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraToolbarsManager UltraToolbarsManager1
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

  [field: AccessedThroughProperty("FormMultiCurrencyAdmin_Fill_Panel")]
  internal virtual UltraPanel FormMultiCurrencyAdmin_Fill_Panel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  internal virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridCurrencies")]
  internal virtual UltraGrid gridCurrencies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsCurrencies1")]
  internal virtual dsCurrencies DsCurrencies1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void FormMultiCurrencyAdmin_Load(object sender, EventArgs e) => this.LoadCurrencies();

  private void LoadCurrencies()
  {
    this.DsCurrencies1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.DsCurrencies1, new string[1]
    {
      "Currencies"
    }, "spFin_GetCurrencies");
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Save", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Cancel", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Edit Selected", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Clear", false) != 0)
            return;
          this.Clear();
        }
        else
          this.EditSelected();
      }
      else
        this.DialogResult = DialogResult.Cancel;
    }
    else
      this.Save();
  }

  private void Clear()
  {
    ((TextEditorControlBase) this.textCurrencyCode).Text = string.Empty;
    ((TextEditorControlBase) this.textDescription).Text = string.Empty;
  }

  private void EditSelected()
  {
    if (this.gridCurrencies.Selected.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("You must select a currency row to edit.", "Invalid Selection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      ((TextEditorControlBase) this.textCurrencyCode).Text = this.gridCurrencies.Selected.Rows[0].Cells["CurrencyCode"].Value.ToString();
      ((TextEditorControlBase) this.textDescription).Text = this.gridCurrencies.Selected.Rows[0].Cells["Currency"].Value.ToString();
    }
  }

  public void Save()
  {
    if (!this.VerifyForm())
      return;
    DefaultDatabase.ExecuteNonQuery("spFin_InsertCurrency", new object[4]
    {
      (object) "@CurrencyCode",
      (object) ((TextEditorControlBase) this.textCurrencyCode).Text,
      (object) "Currency",
      (object) ((TextEditorControlBase) this.textDescription).Text
    });
    this.Clear();
    this.LoadCurrencies();
  }

  public bool VerifyForm()
  {
    bool flag;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.textCurrencyCode).Text))
    {
      int num = (int) MessageBox.Show("You must specify a currency code to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (string.IsNullOrEmpty(((TextEditorControlBase) this.textDescription).Text))
    {
      int num = (int) MessageBox.Show("You must specify a currency code description to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }
}
