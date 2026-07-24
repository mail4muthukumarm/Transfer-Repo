// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmReportsTemplates
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.Attributes;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class frmReportsTemplates : Form
{
  private IContainer components;
  internal const string SECURITYID_TEMPLATEASSOCIATIONS = "{86F498C8-4825-4798-955E-F3F41C13067B}";
  private dsDocumentTemplates ds;
  private List<int> _groupIDs;
  private Dictionary<string, UltraTreeNode> _templateGroupIDs;
  private Dictionary<int, ReportNode> _reportList;
  private int ReportKeyCounter;
  private DataTable dtAssociations;
  private int LoadingThreads;
  private UltraGridRow CurrentRow;
  private UltraGridRow AlteredRow;
  private Guid AlteredReportGuid;
  private int AlteredTemplateId;
  private string AlteredSubject;
  private string AlteredReportName;
  private string AlteredTemplateName;
  private int AlteredAssociationID;
  private bool AssociationsHasRecords;

  public frmReportsTemplates()
  {
    this.Load += new EventHandler(this.frmReportsTemplates_Load);
    this.Shown += new EventHandler(this.frmReportsTemplates_Shown);
    this.ds = new dsDocumentTemplates();
    this._templateGroupIDs = new Dictionary<string, UltraTreeNode>();
    this._reportList = new Dictionary<int, ReportNode>();
    this.ReportKeyCounter = 0;
    this.LoadingThreads = 0;
    this.AssociationsHasRecords = false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportsTemplates));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Associations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AssociationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ReportGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ReportName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TemplateName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SubjectLine");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    DropDownEditorButton downEditorButton1 = new DropDownEditorButton();
    Appearance appearance13 = new Appearance();
    DropDownEditorButton downEditorButton2 = new DropDownEditorButton();
    Override override1 = new Override();
    UltraTreeNode ultraTreeNode = new UltraTreeNode();
    Override override2 = new Override();
    this.ImageList1 = new ImageList(this.components);
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.dgAssociations = new UltraGrid();
    this.Panel3 = new Panel();
    this.GroupBox1 = new UltraGroupBox();
    this.txtSubject = new MGATextBox();
    this.txtTemplateName = new MGATextBox();
    this.txtReportName = new MGATextBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.pnlReports = new Panel();
    this.treeReports = new UltraTree();
    this.Panel4 = new Panel();
    this.PictureBox1 = new PictureBox();
    this.pnlTemplates = new Panel();
    this.treeTemplates = new UltraTree();
    this.Panel6 = new Panel();
    this.PictureBox2 = new PictureBox();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.dgAssociations).BeginInit();
    this.Panel3.SuspendLayout();
    ((ISupportInitialize) this.GroupBox1).BeginInit();
    ((Control) this.GroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    ((ISupportInitialize) this.txtTemplateName).BeginInit();
    ((ISupportInitialize) this.txtReportName).BeginInit();
    this.pnlReports.SuspendLayout();
    ((ISupportInitialize) this.treeReports).BeginInit();
    this.Panel4.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.pnlTemplates.SuspendLayout();
    ((ISupportInitialize) this.treeTemplates).BeginInit();
    this.Panel6.SuspendLayout();
    ((ISupportInitialize) this.PictureBox2).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(10, 29);
    label1.Name = "Label1";
    label1.Size = new Size(70, 13);
    label1.TabIndex = 0;
    label1.Text = "Report Name";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(10, 54);
    label2.Name = "Label2";
    label2.Size = new Size(82, 13);
    label2.TabIndex = 2;
    label2.Text = "Template Name";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(10, 79);
    label3.Name = "Label3";
    label3.Size = new Size(66, 13);
    label3.TabIndex = 4;
    label3.Text = "Subject Line";
    label3.TextAlign = ContentAlignment.MiddleRight;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Magenta;
    this.ImageList1.Images.SetKeyName(0, "Root");
    this.ImageList1.Images.SetKeyName(1, "Folder");
    this.ImageList1.Images.SetKeyName(2, "Word");
    this.ImageList1.Images.SetKeyName(3, "PDF");
    this.Panel1.Location = new Point(12, 168);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(683, 308);
    this.Panel1.TabIndex = 13;
    this.Panel2.Controls.Add((Control) this.dgAssociations);
    this.Panel2.Dock = DockStyle.Fill;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(649, 304);
    this.Panel2.TabIndex = 14;
    ((SpecialBoxBase) ((UltraGridBase) this.dgAssociations).DisplayLayout.AddNewBox).Prompt = " ";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.CardSettings.AutoFit = true;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 138;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 169;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 1;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Report Name";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 174;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Template Name";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 198;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 170;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Subject";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 275;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.dgAssociations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgAssociations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.WhiteSmoke;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgAssociations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgAssociations).Dock = DockStyle.Fill;
    ((Control) this.dgAssociations).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgAssociations).Location = new Point(0, 0);
    ((Control) this.dgAssociations).Name = "dgAssociations";
    ((Control) this.dgAssociations).Size = new Size(649, 304);
    ((Control) this.dgAssociations).TabIndex = 3;
    ((UltraControlBase) this.dgAssociations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAssociations).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel3.Controls.Add((Control) this.GroupBox1);
    this.Panel3.Controls.Add((Control) this.dbSave);
    this.Panel3.Dock = DockStyle.Bottom;
    this.Panel3.Location = new Point(0, 304);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(649, 130);
    this.Panel3.TabIndex = 15;
    this.GroupBox1.BorderStyle = (GroupBoxBorderStyle) 13;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.GroupBox1.ContentAreaAppearance = (AppearanceBase) appearance10;
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtSubject);
    ((Control) this.GroupBox1).Controls.Add((Control) label3);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtTemplateName);
    ((Control) this.GroupBox1).Controls.Add((Control) label2);
    ((Control) this.GroupBox1).Controls.Add((Control) this.txtReportName);
    ((Control) this.GroupBox1).Controls.Add((Control) label1);
    ((Control) this.GroupBox1).Enabled = false;
    ((Control) this.GroupBox1).Location = new Point(12, 5);
    ((Control) this.GroupBox1).Name = "GroupBox1";
    ((Control) this.GroupBox1).Size = new Size(505, 121);
    ((Control) this.GroupBox1).TabIndex = 9;
    this.GroupBox1.Text = "Email Template for Report Information";
    this.GroupBox1.ViewStyle = (GroupBoxViewStyle) 3;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtSubject).BackColor = Color.White;
    ((Control) this.txtSubject).Location = new Point(101, 73);
    ((TextEditorControlBase) this.txtSubject).MaxLength = (int) byte.MaxValue;
    this.txtSubject.MGAStyle = MGAStyles.Blue;
    this.txtSubject.Multiline = true;
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(360, 38);
    ((Control) this.txtSubject).TabIndex = 5;
    ((UltraControlBase) this.txtSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubject).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTemplateName).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtTemplateName).BackColor = Color.White;
    ((EditorButtonControlBase) this.txtTemplateName).ButtonsRight.Add((EditorButtonBase) downEditorButton1);
    ((Control) this.txtTemplateName).Location = new Point(101, 48 /*0x30*/);
    this.txtTemplateName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTemplateName).Name = "txtTemplateName";
    ((EditorButtonControlBase) this.txtTemplateName).ReadOnly = true;
    ((Control) this.txtTemplateName).Size = new Size(360, 19);
    ((Control) this.txtTemplateName).TabIndex = 3;
    ((UltraControlBase) this.txtTemplateName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTemplateName).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtReportName).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtReportName).BackColor = Color.White;
    ((EditorButtonControlBase) this.txtReportName).ButtonsRight.Add((EditorButtonBase) downEditorButton2);
    ((Control) this.txtReportName).Location = new Point(101, 23);
    this.txtReportName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtReportName).Name = "txtReportName";
    ((EditorButtonControlBase) this.txtReportName).ReadOnly = true;
    ((Control) this.txtReportName).Size = new Size(360, 19);
    ((Control) this.txtReportName).TabIndex = 1;
    ((UltraControlBase) this.txtReportName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtReportName).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(534, 84);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 8;
    this.pnlReports.BorderStyle = BorderStyle.Fixed3D;
    this.pnlReports.Controls.Add((Control) this.treeReports);
    this.pnlReports.Controls.Add((Control) this.Panel4);
    this.pnlReports.Location = new Point(22, 79);
    this.pnlReports.Name = "pnlReports";
    this.pnlReports.Size = new Size(196, 168);
    this.pnlReports.TabIndex = 4;
    this.pnlReports.Visible = false;
    ((Control) this.treeReports).AllowDrop = true;
    ((Control) this.treeReports).Dock = DockStyle.Fill;
    this.treeReports.ImageList = this.ImageList1;
    this.treeReports.ImageTransparentColor = Color.Magenta;
    ((Control) this.treeReports).Location = new Point(0, 21);
    ((Control) this.treeReports).Name = "treeReports";
    this.treeReports.NodeConnectorColor = SystemColors.ControlDark;
    override1.SelectionType = (SelectType) 2;
    this.treeReports.Override = override1;
    ((Control) this.treeReports).Size = new Size(192 /*0xC0*/, 143);
    ((Control) this.treeReports).TabIndex = 14;
    ((UltraControlBase) this.treeReports).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.treeReports).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel4.BackgroundImage = (Image) componentResourceManager.GetObject("Panel4.BackgroundImage");
    this.Panel4.Controls.Add((Control) this.PictureBox1);
    this.Panel4.Dock = DockStyle.Top;
    this.Panel4.Location = new Point(0, 0);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(192 /*0xC0*/, 21);
    this.Panel4.TabIndex = 15;
    this.PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(158, 2);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(31 /*0x1F*/, 17);
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.pnlTemplates.BorderStyle = BorderStyle.FixedSingle;
    this.pnlTemplates.Controls.Add((Control) this.treeTemplates);
    this.pnlTemplates.Controls.Add((Control) this.Panel6);
    this.pnlTemplates.Location = new Point(343, 79);
    this.pnlTemplates.Name = "pnlTemplates";
    this.pnlTemplates.Size = new Size(234, 168);
    this.pnlTemplates.TabIndex = 17;
    this.pnlTemplates.Visible = false;
    ((Control) this.treeTemplates).AllowDrop = true;
    ((Control) this.treeTemplates).Dock = DockStyle.Fill;
    this.treeTemplates.ImageList = this.ImageList1;
    this.treeTemplates.ImageTransparentColor = Color.Magenta;
    ((Control) this.treeTemplates).Location = new Point(0, 21);
    ((Control) this.treeTemplates).Name = "treeTemplates";
    this.treeTemplates.NodeConnectorColor = SystemColors.ControlDark;
    ultraTreeNode.Key = "root";
    ultraTreeNode.Text = "Templates";
    this.treeTemplates.Nodes.AddRange(new UltraTreeNode[1]
    {
      ultraTreeNode
    });
    override2.SelectionType = (SelectType) 2;
    this.treeTemplates.Override = override2;
    ((Control) this.treeTemplates).Size = new Size(232, 145);
    ((Control) this.treeTemplates).TabIndex = 12;
    ((UltraControlBase) this.treeTemplates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.treeTemplates).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel6.BackgroundImage = (Image) componentResourceManager.GetObject("Panel6.BackgroundImage");
    this.Panel6.Controls.Add((Control) this.PictureBox2);
    this.Panel6.Dock = DockStyle.Top;
    this.Panel6.Location = new Point(0, 0);
    this.Panel6.Name = "Panel6";
    this.Panel6.Size = new Size(232, 21);
    this.Panel6.TabIndex = 15;
    this.PictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.PictureBox2.Image = (Image) componentResourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(198, 2);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(31 /*0x1F*/, 17);
    this.PictureBox2.TabIndex = 0;
    this.PictureBox2.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(649, 434);
    this.Controls.Add((Control) this.pnlTemplates);
    this.Controls.Add((Control) this.pnlReports);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel3);
    this.Controls.Add((Control) this.Panel1);
    this.Name = nameof (frmReportsTemplates);
    this.Text = "Defalt email Templates for Reports";
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.dgAssociations).EndInit();
    this.Panel3.ResumeLayout(false);
    ((ISupportInitialize) this.GroupBox1).EndInit();
    ((Control) this.GroupBox1).ResumeLayout(false);
    ((Control) this.GroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtSubject).EndInit();
    ((ISupportInitialize) this.txtTemplateName).EndInit();
    ((ISupportInitialize) this.txtReportName).EndInit();
    this.pnlReports.ResumeLayout(false);
    ((ISupportInitialize) this.treeReports).EndInit();
    this.Panel4.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.pnlTemplates.ResumeLayout(false);
    ((ISupportInitialize) this.treeTemplates).EndInit();
    this.Panel6.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox2).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid dgAssociations
  {
    get => this._dgAssociations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgAssociations_AfterRowActivate);
      UltraGrid dgAssociations1 = this._dgAssociations;
      if (dgAssociations1 != null)
        dgAssociations1.AfterRowActivate -= eventHandler;
      this._dgAssociations = value;
      UltraGrid dgAssociations2 = this._dgAssociations;
      if (dgAssociations2 == null)
        return;
      dgAssociations2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  private virtual UltraGroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtReportName
  {
    get => this._txtReportName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EditorButtonEventHandler buttonEventHandler = new EditorButtonEventHandler(this.txtReportName_EditorButtonClick);
      MGATextBox txtReportName1 = this._txtReportName;
      if (txtReportName1 != null)
        ((EditorButtonControlBase) txtReportName1).EditorButtonClick -= buttonEventHandler;
      this._txtReportName = value;
      MGATextBox txtReportName2 = this._txtReportName;
      if (txtReportName2 == null)
        return;
      ((EditorButtonControlBase) txtReportName2).EditorButtonClick += buttonEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtSubject")]
  private virtual MGATextBox txtSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtTemplateName
  {
    get => this._txtTemplateName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EditorButtonEventHandler buttonEventHandler = new EditorButtonEventHandler(this.txtTemplateName_EditorButtonClick);
      MGATextBox txtTemplateName1 = this._txtTemplateName;
      if (txtTemplateName1 != null)
        ((EditorButtonControlBase) txtTemplateName1).EditorButtonClick -= buttonEventHandler;
      this._txtTemplateName = value;
      MGATextBox txtTemplateName2 = this._txtTemplateName;
      if (txtTemplateName2 == null)
        return;
      ((EditorButtonControlBase) txtTemplateName2).EditorButtonClick += buttonEventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlReports")]
  internal virtual Panel pnlReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraTree treeReports
  {
    get => this._treeReports;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.treeReports_AfterSelect);
      UltraTree treeReports1 = this._treeReports;
      if (treeReports1 != null)
        treeReports1.AfterSelect -= selectEventHandler;
      this._treeReports = value;
      UltraTree treeReports2 = this._treeReports;
      if (treeReports2 == null)
        return;
      treeReports2.AfterSelect += selectEventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlTemplates")]
  internal virtual Panel pnlTemplates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraTree treeTemplates
  {
    get => this._treeTemplates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.treeTemplates_AfterSelect);
      UltraTree treeTemplates1 = this._treeTemplates;
      if (treeTemplates1 != null)
        treeTemplates1.AfterSelect -= selectEventHandler;
      this._treeTemplates = value;
      UltraTree treeTemplates2 = this._treeTemplates;
      if (treeTemplates2 == null)
        return;
      treeTemplates2.AfterSelect += selectEventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel6")]
  internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual PictureBox PictureBox2
  {
    get => this._PictureBox2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PictureBox2_Click);
      PictureBox pictureBox2_1 = this._PictureBox2;
      if (pictureBox2_1 != null)
        pictureBox2_1.Click -= eventHandler;
      this._PictureBox2 = value;
      PictureBox pictureBox2_2 = this._PictureBox2;
      if (pictureBox2_2 == null)
        return;
      pictureBox2_2.Click += eventHandler;
    }
  }

  internal virtual PictureBox PictureBox1
  {
    get => this._PictureBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
      PictureBox pictureBox1_1 = this._PictureBox1;
      if (pictureBox1_1 != null)
        pictureBox1_1.Click -= eventHandler;
      this._PictureBox1 = value;
      PictureBox pictureBox1_2 = this._PictureBox1;
      if (pictureBox1_2 == null)
        return;
      pictureBox1_2.Click += eventHandler;
    }
  }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingNew);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.ClickingNew -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.ClickingNew += cancelEventHandler5;
    }
  }

  private void frmReportsTemplates_Load(object sender, EventArgs e)
  {
    this.AddReports();
    this.LoadData();
    ((UltraGridBase) this.dgAssociations).DataSource = (object) this.dtAssociations;
  }

  private void frmReportsTemplates_Shown(object sender, EventArgs e)
  {
    Application.DoEvents();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.AddTemplateGroups));
  }

  private void LoadData()
  {
    try
    {
      this.ds.tblDocumentTemplatesList.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
      {
        "lstDocumentAutomationGroups",
        "tblDocumentTemplatesList",
        "lstTemplateDocumentGroups"
      }, "dbo.LoadTemplateData", new object[4]
      {
        (object) "@showPolicyForms",
        (object) true,
        (object) "@ShowHidden",
        (object) false
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
    this.PopulateAssociations();
  }

  private void LoadComplete()
  {
    ++this.LoadingThreads;
    int loadingThreads = this.LoadingThreads;
  }

  private void PopulateAssociations()
  {
    this.dtAssociations = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT AssociationID,ReportGUID,TemplateID,SubjectLine FROM tblEmailTemplatesForReports");
    this.dtAssociations.Columns.Add("ReportName", Type.GetType("System.String"));
    this.dtAssociations.Columns.Add("TemplateName", Type.GetType("System.String"));
    try
    {
      foreach (DataRow row in this.dtAssociations.Rows)
      {
        row["ReportName"] = (object) this.GetReportName(new Guid(row["ReportGUID"].ToString()));
        row["TemplateName"] = (object) this.GetTemplateName(int.Parse(row["TemplateID"].ToString()));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private string GetTemplateName(int TemplateID)
  {
    string templateName = "";
    DataRow[] dataRowArray = this.ds.tblDocumentTemplatesList.Select("TemplateID=" + TemplateID.ToString());
    if (dataRowArray != null && dataRowArray.Length > 0)
      templateName = dataRowArray[0]["TemplateName"].ToString();
    return templateName;
  }

  private string GetReportName(Guid ReportGUID)
  {
    string reportName = "";
    try
    {
      foreach (int key in this._reportList.Keys)
      {
        if (this._reportList[key].ReportID.Equals(ReportGUID))
        {
          reportName = this._reportList[key].Title;
          break;
        }
      }
    }
    finally
    {
      Dictionary<int, ReportNode>.KeyCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    return reportName;
  }

  private void AddTemplateGroups(object state)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmReportsTemplates.AddTemplateGroupsHandler(this.AddTemplateGroups), state);
    }
    else
    {
      UltraTreeNode node1 = this.treeTemplates.Nodes[0];
      node1.LeftImages.Add((object) this.ImageList1.Images[0]);
      this._templateGroupIDs.Add(node1.Key, node1);
      try
      {
        foreach (dsDocumentTemplates.lstDocumentAutomationGroupsRow documentAutomationGroup in (TypedTableBase<dsDocumentTemplates.lstDocumentAutomationGroupsRow>) this.ds.lstDocumentAutomationGroups)
        {
          UltraTreeNode ultraTreeNode = new UltraTreeNode("ag" + Conversions.ToString(documentAutomationGroup.ID), documentAutomationGroup.TemplateGroup);
          ultraTreeNode.LeftImages.Add((object) this.ImageList1.Images[1]);
          ((SubObjectBase) ultraTreeNode).Tag = (object) documentAutomationGroup.ID;
          ultraTreeNode.Visible = true;
          node1.Nodes.Add(ultraTreeNode);
          this._templateGroupIDs.Add(ultraTreeNode.Key, ultraTreeNode);
          Application.DoEvents();
        }
      }
      finally
      {
        IEnumerator<dsDocumentTemplates.lstDocumentAutomationGroupsRow> enumerator;
        enumerator?.Dispose();
      }
      DataView defaultView = this.ds.lstTemplateDocumentGroups.DefaultView;
      defaultView.Sort = "ParentTemplateGroupID ASC";
      DataTable dataTable = defaultView.ToTable().Copy();
      DataRow[] dataRowArray1 = dataTable.Select("ParentTemplateGroupID is null");
      int index1 = 0;
      while (index1 < dataRowArray1.Length)
      {
        DataRow dataRow = dataRowArray1[index1];
        UltraTreeNode node2 = this.treeTemplates.Nodes[0].Nodes[((KeyedSubObjectsCollectionBase) this.treeTemplates.Nodes[0].Nodes).IndexOf("ag" + dataRow["AutomationGroupID"].ToString())];
        UltraTreeNode ultraTreeNode = new UltraTreeNode("tg" + dataRow["GroupID"].ToString(), dataRow["TemplateGroup"].ToString());
        ultraTreeNode.LeftImages.Add((object) this.ImageList1.Images[1]);
        ((SubObjectBase) ultraTreeNode).Tag = (object) dataRow["GroupID"].ToString();
        ultraTreeNode.Visible = true;
        node2.Nodes.Add(ultraTreeNode);
        this._templateGroupIDs.Add(ultraTreeNode.Key, ultraTreeNode);
        Application.DoEvents();
        checked { ++index1; }
      }
      ArrayList arrayList = new ArrayList();
      DataRow[] dataRowArray2 = dataTable.Select("ParentTemplateGroupID is not null");
      int index2 = 0;
      while (index2 < dataRowArray2.Length)
      {
        DataRow dataRow = dataRowArray2[index2];
        arrayList.Add((object) ("tg" + dataRow["GroupID"].ToString()));
        checked { ++index2; }
      }
      while (arrayList.Count > 0)
      {
        DataRow[] dataRowArray3 = dataTable.Select("ParentTemplateGroupID is not null");
        int index3 = 0;
        while (index3 < dataRowArray3.Length)
        {
          DataRow dataRow = dataRowArray3[index3];
          UltraTreeNode ultraTreeNode1 = this.FindUltraTreeNode("tg" + dataRow["ParentTemplateGroupID"].ToString());
          if (ultraTreeNode1 != null && arrayList.Contains((object) ("tg" + dataRow["GroupID"].ToString())))
          {
            UltraTreeNode ultraTreeNode2 = new UltraTreeNode("tg" + dataRow["GroupID"].ToString(), dataRow["TemplateGroup"].ToString());
            ultraTreeNode2.LeftImages.Add((object) this.ImageList1.Images[1]);
            ((SubObjectBase) ultraTreeNode2).Tag = (object) dataRow["GroupID"].ToString();
            ultraTreeNode2.Visible = true;
            ultraTreeNode1.Nodes.Add(ultraTreeNode2);
            this._templateGroupIDs.Add(ultraTreeNode2.Key, ultraTreeNode2);
            arrayList.Remove((object) ("tg" + dataRow["GroupID"].ToString()));
            Application.DoEvents();
          }
          checked { ++index3; }
        }
      }
      DataRow[] dataRowArray4 = this.ds.tblDocumentTemplatesList.Select("TemplateGroupID is null");
      int index4 = 0;
      while (index4 < dataRowArray4.Length)
      {
        dsDocumentTemplates.tblDocumentTemplatesListRow templatesListRow = (dsDocumentTemplates.tblDocumentTemplatesListRow) dataRowArray4[index4];
        UltraTreeNode ultraTreeNode3 = this.FindUltraTreeNode("ag" + templatesListRow["AutomationGroupID"].ToString());
        if (ultraTreeNode3 != null)
        {
          UltraTreeNode ultraTreeNode4 = new UltraTreeNode(templatesListRow["TemplateID"].ToString(), templatesListRow["TemplateName"].ToString());
          ultraTreeNode4.LeftImages.Add((object) this.ImageList1.Images[(int) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(templatesListRow["TemplateType"].ToString(), "W", false) == 0, (object) 2, (object) 3)]);
          ((SubObjectBase) ultraTreeNode4).Tag = (object) templatesListRow["TemplateID"].ToString();
          ultraTreeNode4.Visible = true;
          ultraTreeNode3.Nodes.Add(ultraTreeNode4);
          this._templateGroupIDs.Add(ultraTreeNode4.Key, ultraTreeNode4);
          Application.DoEvents();
        }
        checked { ++index4; }
      }
      DataRow[] dataRowArray5 = this.ds.tblDocumentTemplatesList.Select("TemplateGroupID is not null");
      int index5 = 0;
      while (index5 < dataRowArray5.Length)
      {
        dsDocumentTemplates.tblDocumentTemplatesListRow templatesListRow = (dsDocumentTemplates.tblDocumentTemplatesListRow) dataRowArray5[index5];
        UltraTreeNode ultraTreeNode5 = this.FindUltraTreeNode("tg" + templatesListRow["TemplateGroupID"].ToString());
        if (ultraTreeNode5 != null)
        {
          UltraTreeNode ultraTreeNode6 = new UltraTreeNode(templatesListRow["TemplateID"].ToString(), templatesListRow["TemplateName"].ToString());
          ultraTreeNode6.LeftImages.Add((object) this.ImageList1.Images[(int) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(templatesListRow["TemplateType"].ToString(), "W", false) == 0, (object) 2, (object) 3)]);
          ((SubObjectBase) ultraTreeNode6).Tag = (object) templatesListRow["TemplateID"].ToString();
          ultraTreeNode6.Visible = true;
          ultraTreeNode5.Nodes.Add(ultraTreeNode6);
          this._templateGroupIDs.Add(ultraTreeNode6.Key, ultraTreeNode6);
          Application.DoEvents();
        }
        checked { ++index5; }
      }
    }
  }

  public UltraTreeNode FindUltraTreeNode(string key)
  {
    return !this._templateGroupIDs.ContainsKey(key) ? (UltraTreeNode) null : this._templateGroupIDs[key];
  }

  private void AddReports()
  {
    this.CreateReportNodes();
    this.CreateFolderNodes();
    if (this.Disposing || this.IsDisposed || !this.IsHandleCreated)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.LoadComplete));
  }

  private void CreateFolderNodes()
  {
    try
    {
      foreach (int key in this._reportList.Keys)
        this.AddFolder(this.treeReports.Nodes, this._reportList[key], key);
    }
    finally
    {
      Dictionary<int, ReportNode>.KeyCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void AddFolder(TreeNodesCollection NodeCollection, ReportNode rNode, int Key)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmReportsTemplates.AddFolderHandler(this.AddFolder), (object) NodeCollection, (object) rNode, (object) Key);
    else if (((KeyedSubObjectsCollectionBase) this.treeReports.Nodes).Exists(rNode.Category))
      ((UltraTreeNode) ((DisposableObjectCollectionBase) this.treeReports.Nodes).GetItem(((KeyedSubObjectsCollectionBase) this.treeReports.Nodes).IndexOf(rNode.Category))).Nodes.Add(new UltraTreeNode(Key.ToString(), rNode.Title));
    else
      NodeCollection.Add(rNode.Category, rNode.Category).Nodes.Add(new UltraTreeNode(Key.ToString(), rNode.Title));
  }

  private void CreateReportNodes()
  {
    SecureReportResourceAttribute searchAttribute1 = new SecureReportResourceAttribute();
    Type[] typeArray1 = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IReport));
    int index1 = 0;
    while (index1 < typeArray1.Length)
    {
      Type type = typeArray1[index1];
      SecureReportResourceAttribute attributeFromType1 = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute1);
      SuppressReportVisibleAttribute attributeFromType2 = ObjectFactory.GetAttributeFromType(type, (Attribute) new SuppressReportVisibleAttribute()) as SuppressReportVisibleAttribute;
      if (attributeFromType1 != null && attributeFromType2 == null)
      {
        ReportNode reportNode = new ReportNode(attributeFromType1.UniqueIdentifier, type, attributeFromType1.ReportCategory, attributeFromType1.Name, attributeFromType1.ReportDescription);
        reportNode.ImageIndex = 1;
        this._reportList.Add(this.ReportKeyCounter, reportNode);
        ++this.ReportKeyCounter;
      }
      checked { ++index1; }
    }
    if (DefaultDatabase.ExecuteScalar<int>("AdhocReportCount") > 0)
    {
      Type type = typeof (AdHocReportDisplay);
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ReportGUID,ReportName,GroupName,Description FROM tblAdHocReports WHERE Published=1");
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          ReportNode reportNode = new ReportNode(new Guid(row["ReportGUID"].ToString()), type, row["GroupName"].ToString(), row["ReportName"].ToString(), row["Description"].ToString() + " (AdHoc)");
          reportNode.ImageIndex = 1;
          this._reportList.Add(this.ReportKeyCounter, reportNode);
          ++this.ReportKeyCounter;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ClearanceContextMenuAttribute searchAttribute2 = new ClearanceContextMenuAttribute();
    Type[] typeArray2 = ObjectFactory.Instance.QueryTypesWithInterface(typeof (IReport));
    int index2 = 0;
    while (index2 < typeArray2.Length)
    {
      Type type = typeArray2[index2];
      SecureReportResourceAttribute attributeFromType3 = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute1);
      ClearanceContextMenuAttribute attributeFromType4 = (ClearanceContextMenuAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute2);
      SuppressReportVisibleAttribute attributeFromType5 = ObjectFactory.GetAttributeFromType(type, (Attribute) new SuppressReportVisibleAttribute()) as SuppressReportVisibleAttribute;
      string str = "";
      if (attributeFromType4 != null && attributeFromType5 == null && attributeFromType3 != null)
      {
        switch (attributeFromType4.Level)
        {
          case ClearanceContextMenuLevelEnum.Insured:
            str = "Insured Context Menu";
            break;
          case ClearanceContextMenuLevelEnum.Submission:
            str = "Submission Context Menu";
            break;
          case ClearanceContextMenuLevelEnum.Quote:
            str = "Quote Context Menu";
            break;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) != 0)
        {
          ReportNode reportNode = new ReportNode(attributeFromType3.UniqueIdentifier, type, str, attributeFromType3.Name, attributeFromType3.ReportDescription);
          reportNode.ImageIndex = 1;
          this._reportList.Add(this.ReportKeyCounter, reportNode);
          ++this.ReportKeyCounter;
        }
      }
      checked { ++index2; }
    }
  }

  private void dgAssociations_AfterRowActivate(object sender, EventArgs e)
  {
    this.AssociationsHasRecords = this.dtAssociations.Rows.Count > 0;
    this.dbSave.UIState = (UIState) Conversions.ToInteger(Interaction.IIf(this.AssociationsHasRecords, (object) UIState.HasRecordsNotEditing, (object) UIState.NoRecordsNotEditing));
    this.CurrentRow = ((UltraGridBase) this.dgAssociations).ActiveRow;
    ((TextEditorControlBase) this.txtReportName).Text = this.CurrentRow.Cells["ReportName"].Text;
    ((TextEditorControlBase) this.txtTemplateName).Text = this.CurrentRow.Cells["TemplateName"].Text;
    ((TextEditorControlBase) this.txtSubject).Text = this.CurrentRow.Cells["SubjectLine"].Text;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (Information.IsNothing((object) ((UltraGridBase) this.dgAssociations).ActiveRow))
    {
      e.Cancel = true;
    }
    else
    {
      ((Control) this.dgAssociations).Enabled = false;
      ((Control) this.GroupBox1).Enabled = true;
      this.AlteredRow = this.CurrentRow;
      this.AlteredReportGuid = new Guid(this.CurrentRow.Cells["ReportGUID"].Text);
      this.AlteredTemplateId = int.Parse(this.CurrentRow.Cells["TemplateID"].Text);
      this.AlteredSubject = this.CurrentRow.Cells["SubjectLine"].Text;
      this.AlteredReportName = this.CurrentRow.Cells["ReportName"].Text;
      this.AlteredTemplateName = this.CurrentRow.Cells["TemplateName"].Text;
      this.AlteredAssociationID = int.Parse(this.CurrentRow.Cells["AssociationID"].Text);
    }
  }

  private void dbSave_ClickingSave(object sender, EventArgs e)
  {
    this.CurrentRow.Cells["ReportGUID"].Value = (object) this.AlteredReportGuid;
    this.CurrentRow.Cells["TemplateID"].Value = (object) this.AlteredTemplateId;
    this.CurrentRow.Cells["SubjectLine"].Value = (object) ((TextEditorControlBase) this.txtSubject).Text;
    this.CurrentRow.Cells["ReportName"].Value = (object) this.AlteredReportName;
    this.CurrentRow.Cells["TemplateName"].Value = (object) this.AlteredTemplateName;
    this.AssociationsHasRecords = this.dtAssociations.Rows.Count > 0;
    this.dbSave.UIState = (UIState) Conversions.ToInteger(Interaction.IIf(this.AssociationsHasRecords, (object) UIState.HasRecordsNotEditing, (object) UIState.NoRecordsNotEditing));
    ((Control) this.GroupBox1).Enabled = false;
    ((Control) this.dgAssociations).Enabled = true;
    this.CurrentRow.Cells["AssociationID"].Value = (object) this.SetEmailTemplatesForReports(RuntimeHelpers.GetObjectValue(this.CurrentRow.Cells["AssociationID"].Value), this.AlteredReportGuid, this.AlteredTemplateId, ((TextEditorControlBase) this.txtSubject).Text);
  }

  private void dbSave_ClickingCancel(object sender, EventArgs e)
  {
    if (this.AlteredAssociationID == 0)
    {
      this.AlteredRow.Delete(false);
      ((UltraGridBase) this.dgAssociations).UpdateData();
    }
    ((TextEditorControlBase) this.txtReportName).Text = this.CurrentRow.Cells["ReportName"].Text;
    ((TextEditorControlBase) this.txtTemplateName).Text = this.CurrentRow.Cells["TemplateName"].Text;
    ((TextEditorControlBase) this.txtSubject).Text = this.CurrentRow.Cells["SubjectLine"].Text;
    this.AssociationsHasRecords = this.dtAssociations.Rows.Count > 0;
    this.dbSave.UIState = (UIState) Conversions.ToInteger(Interaction.IIf(this.AssociationsHasRecords, (object) UIState.HasRecordsNotEditing, (object) UIState.NoRecordsNotEditing));
    ((Control) this.dgAssociations).Enabled = true;
    ((Control) this.GroupBox1).Enabled = false;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (Information.IsNothing((object) ((UltraGridBase) this.dgAssociations).ActiveRow))
    {
      e.Cancel = true;
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgAssociations).ActiveRow.Cells["AssociationID"].Value);
      if (!((UltraGridBase) this.dgAssociations).ActiveRow.Delete(true))
        return;
      this.DeleteEmailTemplatesForReports(RuntimeHelpers.GetObjectValue(objectValue));
      ((UltraGridBase) this.dgAssociations).UpdateData();
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.dbSave.UIState = UIState.Editing;
    this.AlteredRow = ((UltraGridBase) this.dgAssociations).Rows.Band.AddNew();
    this.AlteredRow.Activate();
    ((Control) this.dgAssociations).Enabled = false;
    ((Control) this.GroupBox1).Enabled = true;
    this.AlteredReportGuid = new Guid();
    this.AlteredTemplateId = 0;
    this.AlteredSubject = (string) null;
    this.AlteredReportName = (string) null;
    this.AlteredTemplateName = (string) null;
    this.AlteredAssociationID = 0;
  }

  private void txtReportName_EditorButtonClick(object sender, EditorButtonEventArgs e)
  {
    this.pnlTemplates.Visible = false;
    this.ShowTreeView(this.pnlReports);
  }

  private void treeReports_AfterSelect(object sender, SelectEventArgs e)
  {
    UltraTreeNode newSelection = e.NewSelections[0];
    if (newSelection.HasNodes)
      return;
    ReportNode report = this._reportList[int.Parse(newSelection.Key)];
    this.AlteredReportGuid = report.ReportID;
    this.AlteredReportName = report.Title;
    ((TextEditorControlBase) this.txtReportName).Text = this.AlteredReportName;
    this.pnlReports.Visible = false;
  }

  private void txtTemplateName_EditorButtonClick(object sender, EditorButtonEventArgs e)
  {
    this.pnlReports.Visible = false;
    this.ShowTreeView(this.pnlTemplates);
  }

  private void treeTemplates_AfterSelect(object sender, SelectEventArgs e)
  {
    UltraTreeNode newSelection = e.NewSelections[0];
    string key = newSelection.Key;
    if (newSelection.HasNodes || !Versioned.IsNumeric((object) key[0]))
      return;
    this.AlteredTemplateId = Conversions.ToInteger(key);
    this.AlteredTemplateName = newSelection.Text;
    ((TextEditorControlBase) this.txtTemplateName).Text = this.AlteredTemplateName;
    this.pnlTemplates.Visible = false;
  }

  private void PictureBox1_Click(object sender, EventArgs e) => this.pnlReports.Visible = false;

  private void PictureBox2_Click(object sender, EventArgs e) => this.pnlTemplates.Visible = false;

  private int SetEmailTemplatesForReports(
    object AssociationID,
    Guid alteredReportGuid,
    int alteredTemplateId,
    string text)
  {
    bool flag = false;
    int result;
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(AssociationID)))
      flag = int.TryParse(AssociationID.ToString(), out result);
    int num;
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(AssociationID)) || !flag)
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, nameof (SetEmailTemplatesForReports), new object[6]
      {
        (object) "@ReportGUID",
        (object) alteredReportGuid,
        (object) "@TemplateID",
        (object) alteredTemplateId,
        (object) "@SubjectLine",
        (object) text
      });
    else
      num = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, nameof (SetEmailTemplatesForReports), new object[8]
      {
        (object) "@ID",
        (object) result,
        (object) "@ReportGUID",
        (object) alteredReportGuid,
        (object) "@TemplateID",
        (object) alteredTemplateId,
        (object) "@SubjectLine",
        (object) text
      });
    return num;
  }

  private void DeleteEmailTemplatesForReports(object AssociationID)
  {
    bool flag = false;
    int result;
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(AssociationID)))
      flag = int.TryParse(AssociationID.ToString(), out result);
    if (!flag)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblEmailTemplatesForReports WHERE AssociationID = @ID", new object[2]
    {
      (object) "@ID",
      (object) result
    });
  }

  private void ShowTreeView(Panel pnl)
  {
    Rectangle clientRectangle = ((Control) this.dgAssociations).ClientRectangle;
    pnl.Top = 10;
    pnl.Left = 10;
    pnl.Width = clientRectangle.Width - 20;
    pnl.Height = clientRectangle.Height - 20;
    pnl.Visible = true;
  }

  private delegate void AddTemplateGroupsHandler(object state);

  private delegate void AddFolderHandler(
    TreeNodesCollection NodeCollection,
    ReportNode rNode,
    int Key);
}
