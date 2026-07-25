// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.frmModifyTemplateDocs
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.FileSystemObserver;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.OfficeAuto;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class frmModifyTemplateDocs : Form
{
  private IContainer components;
  private Label Label1;
  private UltraGrid dgTemplateDocs;
  private dsModifyTemplateDocs ds;
  private Label Label2;
  private Label Label3;
  private SqlConnection cn;
  private SqlCommand spStoreCompletedTemplate;
  private Dictionary<int, CompanyDocumentAutomation.TemplateDoc> _tempWordDocs;
  private bool _saved;
  private int _quoteID;
  private Messaging.MessageEventArgs _event;
  private Dictionary<int, string> _templateNames;
  private List<AutomationDoc> _automationDocs;
  private Guid _quoteGuid;
  private ExcelFileTracker _excelTracker;
  private Dictionary<string, TemplateHash> _watchedFiles;

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraProgressBar1")]
  internal virtual UltraProgressBar UltraProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkRemoveAll
  {
    get => this._lnkRemoveAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRemoveAll_LinkClicked);
      LinkLabel lnkRemoveAll1 = this._lnkRemoveAll;
      if (lnkRemoveAll1 != null)
        lnkRemoveAll1.LinkClicked -= clickedEventHandler;
      this._lnkRemoveAll = value;
      LinkLabel lnkRemoveAll2 = this._lnkRemoveAll;
      if (lnkRemoveAll2 == null)
        return;
      lnkRemoveAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkRemoveAllButChecked
  {
    get => this._lnkRemoveAllButChecked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRemoveAllButChecked_LinkClicked);
      LinkLabel removeAllButChecked1 = this._lnkRemoveAllButChecked;
      if (removeAllButChecked1 != null)
        removeAllButChecked1.LinkClicked -= clickedEventHandler;
      this._lnkRemoveAllButChecked = value;
      LinkLabel removeAllButChecked2 = this._lnkRemoveAllButChecked;
      if (removeAllButChecked2 == null)
        return;
      removeAllButChecked2.LinkClicked += clickedEventHandler;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmModifyTemplateDocs));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("TemplateDoc", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("TemplateName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EditLink");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PreviewLink");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("TempFilename");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("RemoveLink");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Clear");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Checked");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("IsEditable");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("RequiresEdit");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("OriginalFileName");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.cn = new SqlConnection();
    this.spStoreCompletedTemplate = new SqlCommand();
    this.UltraProgressBar1 = new UltraProgressBar();
    this.lnkRemoveAll = new LinkLabel();
    this.LinkLabel1 = new LinkLabel();
    this.dgTemplateDocs = new UltraGrid();
    this.ds = new dsModifyTemplateDocs();
    this.lnkRemoveAllButChecked = new LinkLabel();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.dgTemplateDocs).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(720, 32 /*0x20*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = componentResourceManager.GetString("Label1.Text");
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(666, 363);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 2;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(714, 363);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 3;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 363);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(375, 13);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "When you are ready to create the document package, click the save button.";
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 379);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(282, 13);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "To abandon the creation process, click the cancel button.";
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.spStoreCompletedTemplate.CommandText = "dbo.[spStoreCompletedTemplate]";
    this.spStoreCompletedTemplate.CommandType = CommandType.StoredProcedure;
    this.spStoreCompletedTemplate.Connection = this.cn;
    this.spStoreCompletedTemplate.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@quoteID", SqlDbType.Int, 4),
      new SqlParameter("@templateID", SqlDbType.Int, 4),
      new SqlParameter("@template", SqlDbType.VarBinary, int.MaxValue)
    });
    ((Control) this.UltraProgressBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraProgressBar1).Location = new Point(8, 323);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(748, 16 /*0x10*/);
    ((Control) this.UltraProgressBar1).TabIndex = 6;
    this.UltraProgressBar1.Text = "[Formatted]";
    this.lnkRemoveAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkRemoveAll.Location = new Point(440, 364);
    this.lnkRemoveAll.Name = "lnkRemoveAll";
    this.lnkRemoveAll.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.lnkRemoveAll.TabIndex = 7;
    this.lnkRemoveAll.TabStop = true;
    this.lnkRemoveAll.Text = "Remove All Template Docs";
    this.LinkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.LinkLabel1.Location = new Point(440, 386);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(168, 16 /*0x10*/);
    this.LinkLabel1.TabIndex = 8;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Remove Checked Template Docs";
    ((Control) this.dgTemplateDocs).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgTemplateDocs).DataSource = (object) this.ds.TemplateDoc;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 58;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Template";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 189;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 218;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance4.FontData.UnderlineAsString = "True";
    appearance4.ForeColor = Color.Blue;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Edit";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 62;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance5.FontData.UnderlineAsString = "True";
    appearance5.ForeColor = Color.Blue;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Preview";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 62;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 105;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance6.FontData.UnderlineAsString = "True";
    appearance6.ForeColor = Color.Blue;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Center";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Remove";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 62;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance7.FontData.UnderlineAsString = "True";
    appearance7.ForeColor = Color.Blue;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 62;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 58;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 60;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 81;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 99;
    ultraGridBand.Columns.AddRange(new object[12]
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
      (object) ultraGridColumn12
    });
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.SizeInPoints = 10f;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Override.SupportDataErrorInfo = (SupportDataErrorInfo) 4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgTemplateDocs).Location = new Point(8, 48 /*0x30*/);
    ((Control) this.dgTemplateDocs).Name = "dgTemplateDocs";
    ((Control) this.dgTemplateDocs).Size = new Size(746, 269);
    ((Control) this.dgTemplateDocs).TabIndex = 1;
    ((UltraControlBase) this.dgTemplateDocs).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgTemplateDocs).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsModifyTemplateDocs";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkRemoveAllButChecked.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkRemoveAllButChecked.Location = new Point(440, 342);
    this.lnkRemoveAllButChecked.Name = "lnkRemoveAllButChecked";
    this.lnkRemoveAllButChecked.Size = new Size(168, 16 /*0x10*/);
    this.lnkRemoveAllButChecked.TabIndex = 9;
    this.lnkRemoveAllButChecked.TabStop = true;
    this.lnkRemoveAllButChecked.Text = "Remove All But Checked";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(762, 409);
    this.Controls.Add((Control) this.lnkRemoveAllButChecked);
    this.Controls.Add((Control) this.LinkLabel1);
    this.Controls.Add((Control) this.lnkRemoveAll);
    this.Controls.Add((Control) this.UltraProgressBar1);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.dgTemplateDocs);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.Name = nameof (frmModifyTemplateDocs);
    this.Text = "View / Edit Template Documents";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.dgTemplateDocs).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual HyperlinkEditor hyperlinkEdit
  {
    get => this._hyperlinkEdit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.hyperlinkEdit_HyperLinkOpening);
      HyperlinkEditor hyperlinkEdit1 = this._hyperlinkEdit;
      if (hyperlinkEdit1 != null)
        hyperlinkEdit1.HyperLinkOpening -= cancelEventHandler;
      this._hyperlinkEdit = value;
      HyperlinkEditor hyperlinkEdit2 = this._hyperlinkEdit;
      if (hyperlinkEdit2 == null)
        return;
      hyperlinkEdit2.HyperLinkOpening += cancelEventHandler;
    }
  }

  private virtual HyperlinkEditor hyperlinkRemove
  {
    get => this._hyperlinkRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.hyperlinkRemove_HyperLinkOpening);
      HyperlinkEditor hyperlinkRemove1 = this._hyperlinkRemove;
      if (hyperlinkRemove1 != null)
        hyperlinkRemove1.HyperLinkOpening -= cancelEventHandler;
      this._hyperlinkRemove = value;
      HyperlinkEditor hyperlinkRemove2 = this._hyperlinkRemove;
      if (hyperlinkRemove2 == null)
        return;
      hyperlinkRemove2.HyperLinkOpening += cancelEventHandler;
    }
  }

  private virtual HyperlinkEditor hyperlinkClear
  {
    get => this._hyperlinkClear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.hyperlinkClear_HyperLinkOpening);
      HyperlinkEditor hyperlinkClear1 = this._hyperlinkClear;
      if (hyperlinkClear1 != null)
        hyperlinkClear1.HyperLinkOpening -= cancelEventHandler;
      this._hyperlinkClear = value;
      HyperlinkEditor hyperlinkClear2 = this._hyperlinkClear;
      if (hyperlinkClear2 == null)
        return;
      hyperlinkClear2.HyperLinkOpening += cancelEventHandler;
    }
  }

  private virtual HyperlinkEditor hyperlinkPreview
  {
    get => this._hyperlinkPreview;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.hyperlinkPreview_HyperLinkOpening);
      HyperlinkEditor hyperlinkPreview1 = this._hyperlinkPreview;
      if (hyperlinkPreview1 != null)
        hyperlinkPreview1.HyperLinkOpening -= cancelEventHandler;
      this._hyperlinkPreview = value;
      HyperlinkEditor hyperlinkPreview2 = this._hyperlinkPreview;
      if (hyperlinkPreview2 == null)
        return;
      hyperlinkPreview2.HyperLinkOpening += cancelEventHandler;
    }
  }

  private virtual WordTemplate wordTmpl
  {
    get => this._wordTmpl;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.wordTmpl_WordAppClosed);
      WordTemplate wordTmpl1 = this._wordTmpl;
      if (wordTmpl1 != null)
        wordTmpl1.WordAppClosed -= eventHandler;
      this._wordTmpl = value;
      WordTemplate wordTmpl2 = this._wordTmpl;
      if (wordTmpl2 == null)
        return;
      wordTmpl2.WordAppClosed += eventHandler;
    }
  }

  public frmModifyTemplateDocs(
    int quoteID,
    Dictionary<int, CompanyDocumentAutomation.TemplateDoc> tempWordDocs,
    Dictionary<int, string> templateNames,
    List<AutomationDoc> automationDocs,
    Messaging.MessageEventArgs e)
  {
    this.Load += new EventHandler(this.frmModifyTemplateDocs_Load);
    this.hyperlinkEdit = new HyperlinkEditor();
    this.hyperlinkRemove = new HyperlinkEditor();
    this.hyperlinkClear = new HyperlinkEditor();
    this.hyperlinkPreview = new HyperlinkEditor();
    this.InitializeComponent();
    ((Control) this.btnCancel).Enabled = false;
    ((Control) this.btnSave).Enabled = false;
    this._tempWordDocs = tempWordDocs;
    this._quoteID = quoteID;
    this._templateNames = templateNames;
    this._automationDocs = automationDocs;
    this._event = e;
    this.UltraProgressBar1.Maximum = this._tempWordDocs.Count;
  }

  public bool Saved => this._saved;

  protected virtual bool RemoveAllNotCheckedOnSaving => false;

  private void frmModifyTemplateDocs_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = MGASystems.IMS.DocumentAutomation.Common.ConnectionString;
    this.SuspendLayout();
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    this.ds.TemplateDoc.DefaultView.Sort = "TemplateName";
    this._quoteGuid = new Quote(this._quoteID).QuoteGuid;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Bands[0].Columns["EditLink"].Editor = (EmbeddableEditorBase) this.hyperlinkEdit;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Bands[0].Columns["RemoveLink"].Editor = (EmbeddableEditorBase) this.hyperlinkRemove;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Bands[0].Columns["Clear"].Editor = (EmbeddableEditorBase) this.hyperlinkClear;
    ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Bands[0].Columns["PreviewLink"].Editor = (EmbeddableEditorBase) this.hyperlinkPreview;
    this.Height = (this._tempWordDocs.Count + 1) * ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Bands[0].Header.Height + ((UltraGridBase) this.dgTemplateDocs).DisplayLayout.Bands[0].Header.Height + 165;
    if (this.Height > 550)
      this.Height = 550;
    this.ResumeLayout();
    if (this._watchedFiles == null)
      this._watchedFiles = new Dictionary<string, TemplateHash>();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillDataThread));
  }

  private void FillDataThread(object state)
  {
    Thread.Sleep(250);
    this.ds.dtTemplate.Clear();
    string str1 = string.Empty;
    try
    {
      foreach (KeyValuePair<int, CompanyDocumentAutomation.TemplateDoc> tempWordDoc in this._tempWordDocs)
        str1 = $"{str1}{Conversions.ToString(tempWordDoc.Value.TemplateID)},";
    }
    finally
    {
      Dictionary<int, CompanyDocumentAutomation.TemplateDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (!str1.Equals(string.Empty))
      DefaultDatabase.LoadDataTable((DataTable) this.ds.dtTemplate, "GetAllDocumentTemplateData", new object[4]
      {
        (object) "@templateString",
        (object) str1,
        (object) "@QuoteID",
        (object) this._quoteID
      });
    try
    {
      foreach (KeyValuePair<int, CompanyDocumentAutomation.TemplateDoc> tempWordDoc in this._tempWordDocs)
      {
        CompanyDocumentAutomation.TemplateDoc templateDoc = tempWordDoc.Value;
        dsModifyTemplateDocs.dtTemplateRow byTemplateId = this.ds.dtTemplate.FindByTemplateID(templateDoc.TemplateID);
        bool isWordDocument = byTemplateId.IsWordDocument;
        string description = byTemplateId.Description;
        bool isEditable = byTemplateId.IsEditable;
        bool removable = byTemplateId.Removable;
        bool isEmail = byTemplateId.IsEmail;
        if (this.IsHandleCreated && (isEditable || removable))
        {
          string str2 = string.Empty;
          if (isWordDocument && byTemplateId.ClearCompleted || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(byTemplateId.TemplateType, "E", false) == 0 && byTemplateId.ClearCompleted)
            str2 = "Clear Completed";
          if (this.IsHandleCreated)
          {
            if (!this._templateNames.ContainsKey(templateDoc.TemplateID))
              CurrentUser.Instance.LogAction($"Template document ID {templateDoc.TemplateID} is not available for automation.", this._quoteGuid);
            this.BeginInvoke((Delegate) new frmModifyTemplateDocs.AddTemplateRowHandler(this.AddTemplateRow), (object) isWordDocument, (object) templateDoc.TemplateID, (object) templateDoc.Filename, (object) this._templateNames[templateDoc.TemplateID], (object) description, (object) str2, (object) isEditable, (object) removable, (object) isEmail, (object) byTemplateId.RequiresEdit, (object) byTemplateId.TemplateType);
          }
        }
        else if (!this.IsHandleCreated)
          Thread.CurrentThread.Abort();
        if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
          MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.MoveProgress));
      }
    }
    finally
    {
      Dictionary<int, CompanyDocumentAutomation.TemplateDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (!this.IsHandleCreated || this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.LoadComplete));
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void MoveProgress()
  {
    UltraProgressBar ultraProgressBar1;
    int num = (ultraProgressBar1 = this.UltraProgressBar1).Value + 1;
    ultraProgressBar1.Value = num;
  }

  private void AddTemplateRow(
    bool isWordDocument,
    int templateID,
    string fileName,
    string templateName,
    string description,
    string clearText,
    bool isEditable,
    bool isRemovable,
    bool isEmail,
    bool requiresEdit,
    string templateType)
  {
    dsModifyTemplateDocs.TemplateDocRow row = this.ds.TemplateDoc.NewTemplateDocRow();
    row.TemplateID = templateID;
    row.TempFilename = fileName;
    row.TemplateName = templateName;
    row.Description = description;
    row.Clear = clearText;
    row.RequiresEdit = requiresEdit;
    if (!isEditable && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(templateType, "E", false) != 0 || !isWordDocument))
      row.EditLink = string.Empty;
    if (!isRemovable)
      row.RemoveLink = string.Empty;
    if (isEmail)
      row.PreviewLink = string.Empty;
    this.ds.TemplateDoc.AddTemplateDocRow(row);
    if (this.dgTemplateDocs == null)
      return;
    ((UltraGridBase) this.dgTemplateDocs).ActiveRowScrollRegion.ScrollRowIntoView(((UltraGridBase) this.dgTemplateDocs).Rows[0]);
    ((UltraGridBase) this.dgTemplateDocs).Refresh();
  }

  private void LoadComplete()
  {
    if (this._event.EventGuid.Equals(BroadcastMessages.EndorsementBound))
    {
      ((Control) this.btnCancel).Enabled = false;
      this.ControlBox = false;
    }
    else
      ((Control) this.btnCancel).Enabled = true;
    ((Control) this.btnSave).Enabled = true;
    if (((UltraGridBase) this.dgTemplateDocs).Rows.Count > 0)
    {
      UltraGrid dgTemplateDocs = this.dgTemplateDocs;
      dgTemplateDocs.Selected.Rows.Clear();
      ((UltraGridBase) dgTemplateDocs).Rows[0].Activated = true;
      ((UltraGridBase) dgTemplateDocs).Rows[0].Selected = true;
    }
    ((Control) this.UltraProgressBar1).Visible = false;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgTemplateDocs).Rows)
    {
      if (string.IsNullOrEmpty(row.Cells["RemoveLink"].Value.ToString()))
        row.Cells["RemoveLink"].Activation = (Activation) 3;
      if (Conversions.ToBoolean(row.Cells["RequiresEdit"].Value))
      {
        row.Cells["TemplateName"].Appearance.FontData.Italic = (DefaultableBoolean) 1;
        row.Cells["TemplateName"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
        row.Cells["Description"].Appearance.FontData.Italic = (DefaultableBoolean) 1;
        row.Cells["TemplateName"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
      }
    }
    if (!this.AutoCheckTemplateDocs)
      return;
    try
    {
      foreach (dsModifyTemplateDocs.TemplateDocRow templateDocRow in (TypedTableBase<dsModifyTemplateDocs.TemplateDocRow>) this.ds.TemplateDoc)
        templateDocRow.Checked = true;
    }
    finally
    {
      IEnumerator<dsModifyTemplateDocs.TemplateDocRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual bool AutoCheckTemplateDocs => false;

  private void hyperlinkEdit_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HyperlinkEditor) sender).CurrentEditText, string.Empty, false) == 0)
      return;
    e.Cancel = true;
    if (!DocumentHandling.HasCompatibleOfficeVersion(true))
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    ((DataRowView) ((UltraGridBase) this.dgTemplateDocs).ActiveRow.ListObject).Row.ClearErrors();
    try
    {
      int num = (int) ((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["TemplateID"].Value;
      string str = this.ds.TemplateDoc.FindByTemplateID(num).TempFilename;
      byte[] origHash = (byte[]) null;
      if (!File.Exists(str))
      {
        str = Path.ChangeExtension(str, Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(str), "doc", false) == 0 ? "docx" : "doc");
        this.ds.TemplateDoc.FindByTemplateID(num).TempFilename = str;
      }
      using (FileStream inputStream = new FileStream(str, FileMode.Open, FileAccess.Read, FileShare.Read))
      {
        origHash = new MD5CryptoServiceProvider().ComputeHash((Stream) inputStream);
        inputStream.Close();
      }
      string strA = Path.GetExtension(str);
      if (string.Compare(strA, ".doc", true) == 0 || string.Compare(strA, ".docx", true) == 0)
      {
        if (WordTemplate.UseWordApp())
        {
          ((Control) this.btnSave).Enabled = false;
          this.wordTmpl = new WordTemplate(str, (Form) null, (object) new TemplateHash(num, origHash));
        }
        else
        {
          frmDocumentTemplatesWordHost formEx = (frmDocumentTemplatesWordHost) ObjectFactory.Instance.CreateFormEX(typeof (frmDocumentTemplatesWordHost), (object) str, (object) true);
          formEx.Tag = (object) new TemplateHash(num, origHash);
          MGASystems.IMS.DocumentAutomation.FormSettings.ShowFormOnSecondMonitorIfAvailable((Form) formEx, false);
          formEx.WordDocumentSaved += new frmDocumentTemplatesWordHost.WordDocumentSavedEventHandler(this.WordDocumentSaved);
        }
      }
      else
      {
        ((Control) this.btnSave).Enabled = false;
        this.AddFileWatch(str, new TemplateHash(num, origHash));
        this._excelTracker = new ExcelFileTracker(str);
        this._excelTracker.ClosedEvent += new FileSystemEvent(this.FileClosed);
        this._excelTracker.ShowExcelSheet();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void wordTmpl_WordAppClosed(object sender, EventArgs e)
  {
    MDIControls.Instance.MDIParent.Invoke((Delegate) ([SpecialName] () => ((Control) this.btnSave).Enabled = true));
    if (!this.wordTmpl.FileChanged)
      return;
    bool flag = true;
    if (!WordTemplate.UseWordWithEvents())
    {
      TemplateHash tag = (TemplateHash) ((WordTemplate) sender).Tag;
      string str = "";
      foreach (UltraGridRow row in ((UltraGridBase) this.dgTemplateDocs).Rows)
      {
        if (Conversions.ToInteger(row.Cells["TemplateID"].Value) == tag.TemplateID)
        {
          str = row.Cells["TemplateName"].Value.ToString();
          break;
        }
      }
      if (MessageBox.Show($"Save changes to '{str}'?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        flag = false;
        this.wordTmpl.RevertToOriginalFile();
      }
    }
    if (!flag)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new frmModifyTemplateDocs.SaveDocumentWordAppHandler(this.WordDocumentSaved), (object) this, (object) new WordDocumentSavedEventArgs(this.wordTmpl.FileName));
  }

  private void hyperlinkPreview_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (!DocumentHandling.HasCompatibleOfficeVersion(true))
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      int TemplateID = (int) ((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["TemplateID"].Value;
      Quote quote = new Quote(this._quoteID);
      CompanyDocumentAutomation objectEx = (CompanyDocumentAutomation) ObjectFactory.Instance.CreateObjectEX(typeof (CompanyDocumentAutomation), (object) TemplateID);
      objectEx.SetEventContext(RuntimeHelpers.GetObjectValue(this._event.Context));
      objectEx.QuoteGuid = quote.QuoteGuid;
      CompanyDocumentAutomation.TemplateDoc docTemplate = new CompanyDocumentAutomation.TemplateDoc();
      docTemplate.Filename = this.ds.TemplateDoc.FindByTemplateID(TemplateID).TempFilename;
      if (!File.Exists(docTemplate.Filename))
      {
        docTemplate.Filename = Path.ChangeExtension(docTemplate.Filename, Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(docTemplate.Filename), "doc", false) == 0 ? "docx" : "doc");
        this.ds.TemplateDoc.FindByTemplateID(TemplateID).TempFilename = docTemplate.Filename;
      }
      docTemplate.TemplateID = TemplateID;
      MemoryStream pdf = objectEx.ConvertTemplateDocToPDF(docTemplate);
      string str = Path.GetTempFileName() + ".pdf";
      FileStream fileStream = new FileStream(str, FileMode.Create);
      try
      {
        fileStream.Write(pdf.ToArray(), 0, (int) pdf.Length - 1);
      }
      finally
      {
        fileStream.Close();
        pdf.Close();
      }
      Process.Start(str);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void lnkRemoveAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.dgTemplateDocs).Rows.Count == 0 || MessageBox.Show("Are you sure you want to remove all template documents?", "Remove All Documents?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    List<int> intList = new List<int>();
    for (int index = this.ds.TemplateDoc.Rows.Count - 1; index >= 0; index += -1)
    {
      dsModifyTemplateDocs.TemplateDocRow row = this.ds.TemplateDoc[index];
      if (!row.RemoveLink.Equals(string.Empty))
      {
        intList.Add(row.TemplateID);
        this.ds.TemplateDoc.RemoveTemplateDocRow(row);
      }
    }
    int num = 0;
    do
    {
      try
      {
        foreach (KeyValuePair<int, CompanyDocumentAutomation.TemplateDoc> tempWordDoc in this._tempWordDocs)
        {
          CompanyDocumentAutomation.TemplateDoc templateDoc = tempWordDoc.Value;
          if (intList.Contains(templateDoc.TemplateID))
          {
            this._tempWordDocs.Remove(tempWordDoc.Key);
            break;
          }
        }
      }
      finally
      {
        Dictionary<int, CompanyDocumentAutomation.TemplateDoc>.Enumerator enumerator;
        enumerator.Dispose();
      }
      try
      {
        foreach (AutomationDoc automationDoc in this._automationDocs)
        {
          if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument && intList.Contains(automationDoc.TemplateID))
          {
            this._automationDocs.Remove(automationDoc);
            break;
          }
        }
      }
      finally
      {
        List<AutomationDoc>.Enumerator enumerator;
        enumerator.Dispose();
      }
      ++num;
    }
    while (num <= 100);
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ProcessTemplateRows(true);
  }

  private void hyperlinkRemove_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgTemplateDocs).ActiveRow == null)
      return;
    e.Cancel = true;
    if (MessageBox.Show($"Are you sure you want to remove \"{((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["TemplateName"].Value.ToString()}\"?", "Remove Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int integer = Conversions.ToInteger(((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["TemplateID"].Value);
    try
    {
      foreach (KeyValuePair<int, CompanyDocumentAutomation.TemplateDoc> tempWordDoc in this._tempWordDocs)
      {
        if (tempWordDoc.Value.TemplateID == integer)
        {
          this._tempWordDocs.Remove(tempWordDoc.Key);
          break;
        }
      }
    }
    finally
    {
      Dictionary<int, CompanyDocumentAutomation.TemplateDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      foreach (AutomationDoc automationDoc in this._automationDocs)
      {
        if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument && automationDoc.TemplateID == integer)
        {
          this._automationDocs.Remove(automationDoc);
          break;
        }
      }
    }
    finally
    {
      List<AutomationDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.ds.TemplateDoc.RemoveTemplateDocRow(this.ds.TemplateDoc.FindByTemplateID(integer));
  }

  private void hyperlinkClear_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgTemplateDocs).ActiveRow == null || string.IsNullOrEmpty(((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["Clear"].Text))
      return;
    e.Cancel = true;
    string str = ((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["TemplateName"].Value.ToString();
    if (MessageBox.Show($"Are you sure you want to clear \"{str}\"?", "Clear Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int TemplateID = (int) ((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["TemplateID"].Value;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDocumentTemplates_Completed WHERE QuoteID = @QuoteID AND TemplateID = @TemplateID", new object[4]
    {
      (object) "@QuoteID",
      (object) this._quoteID,
      (object) "@TemplateID",
      (object) TemplateID
    });
    ((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["Clear"].Value = (object) string.Empty;
    ((UltraGridBase) this.dgTemplateDocs).ActiveRow.Cells["EditLink"].Activation = (Activation) 3;
    CurrentUser.Instance.LogAction($"Cleared template document - '{str}'", this._quoteGuid);
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.RedownloadClearedDocument), (object) this.ds.TemplateDoc.FindByTemplateID(TemplateID));
  }

  private void RedownloadClearedDocument(object state)
  {
    dsModifyTemplateDocs.TemplateDocRow templateDocRow = (dsModifyTemplateDocs.TemplateDocRow) state;
    byte[] array = (byte[]) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Template FROM tblDocumentTemplates (NOLOCK) WHERE TemplateID=@TemplateID", new object[2]
    {
      (object) "@TemplateID",
      (object) templateDocRow.TemplateID
    });
    FileStream fileStream = new FileStream(templateDocRow.TempFilename, FileMode.Create);
    try
    {
      fileStream.Write(array, 0, array.Length);
    }
    finally
    {
      fileStream.Close();
    }
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new WaitCallback(this.MarkTemplateEditable), (object) templateDocRow.TemplateID);
  }

  private void SaveModifiedTemplateToDatabase(TemplateHash template, string fileName)
  {
    byte[] hash;
    byte[] array;
    using (FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
    {
      hash = new MD5CryptoServiceProvider().ComputeHash((Stream) inputStream);
      inputStream.Position = 0L;
      array = new byte[(int) inputStream.Length - 1 + 1];
      inputStream.Read(array, 0, (int) inputStream.Length);
    }
    if (!this.HashesDiffer(hash, template.FileHash))
      return;
    using (SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      sqlConnection.Open();
      SqlCommand completedTemplate = this.spStoreCompletedTemplate;
      completedTemplate.Parameters["@quoteID"].Value = (object) this._quoteID;
      completedTemplate.Parameters["@templateID"].Value = (object) template.TemplateID;
      completedTemplate.Parameters["@template"].Value = (object) array;
      completedTemplate.Connection = sqlConnection;
      Database.PerformNonQueryWithFailureRetry(this.spStoreCompletedTemplate);
    }
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new WaitCallback(this.MarkTemplateCompleted), (object) template.TemplateID);
  }

  private void WordDocumentSaved(object sender, WordDocumentSavedEventArgs e)
  {
    frmModifyTemplateDocs modifyTemplateDocs = this;
    Form form = (Form) sender;
    TemplateHash templateHash = form != this ? (TemplateHash) form.Tag : (TemplateHash) this.wordTmpl.Tag;
    string fileName = e.FileName;
    // ISSUE: reference to a compiler-generated method
    ThreadPool.QueueUserWorkItem((WaitCallback) ([SpecialName] (a0) => this._Lambda\u0024__0()));
  }

  private void MarkTemplateCompleted(object state)
  {
    int TemplateID = (int) state;
    this.ds.TemplateDoc.FindByTemplateID(TemplateID).Clear = "Clear Completed";
    CurrentUser.Instance.LogAction($"Mark 'Clear Completed'. Template - '{this.ds.TemplateDoc.FindByTemplateID(TemplateID).TemplateName}'", this._quoteGuid);
    ((UltraGridBase) this.dgTemplateDocs).Refresh();
  }

  private void MarkTemplateEditable(object state)
  {
    int num = (int) state;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgTemplateDocs).Rows)
    {
      if (row.Cells["TemplateID"].Value.Equals((object) num))
      {
        row.Cells["EditLink"].Activation = (Activation) 0;
        break;
      }
    }
  }

  public bool HashesDiffer(byte[] hash1, byte[] hash2)
  {
    bool flag;
    if (hash1.Length != hash2.Length)
    {
      flag = true;
    }
    else
    {
      int num = hash1.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        if ((int) hash1[index] != (int) hash2[index])
        {
          flag = true;
          goto label_8;
        }
      }
      flag = false;
    }
label_8:
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    bool flag = true;
    foreach (UltraGridRow row1 in ((UltraGridBase) this.dgTemplateDocs).Rows)
    {
      dsModifyTemplateDocs.TemplateDocRow row2 = (dsModifyTemplateDocs.TemplateDocRow) ((DataRowView) row1.ListObject).Row;
      if (row2.RequiresEdit && string.IsNullOrEmpty(row2.Clear))
      {
        row2.SetColumnError("EditLink", "Template requires edit");
        flag = false;
      }
    }
    if (!flag)
    {
      int num = (int) MessageBox.Show("Please verify all templates requiring edits have been reviewed.", "Templates Require Edits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this._saved = true;
      if (this.RemoveAllNotCheckedOnSaving)
        this.lnkRemoveAllButChecked_LinkClicked((object) null, (LinkLabelLinkClickedEventArgs) null);
      this.Close();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._saved = false;
    this.Close();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this.hyperlinkEdit != null)
      {
        ((DisposableObject) this.hyperlinkEdit).Dispose();
        this.hyperlinkEdit = (HyperlinkEditor) null;
      }
      if (this.hyperlinkRemove != null)
      {
        ((DisposableObject) this.hyperlinkRemove).Dispose();
        this.hyperlinkRemove = (HyperlinkEditor) null;
      }
      if (this.hyperlinkPreview != null)
      {
        ((DisposableObject) this.hyperlinkPreview).Dispose();
        this.hyperlinkPreview = (HyperlinkEditor) null;
      }
    }
    base.Dispose(disposing);
  }

  private void ProcessTemplateRows(bool rowChecked)
  {
    for (int index = this.ds.TemplateDoc.Rows.Count - 1; index >= 0; index += -1)
    {
      dsModifyTemplateDocs.TemplateDocRow row = this.ds.TemplateDoc[index];
      if ((!rowChecked ? !row.Checked : row.Checked) && !row.RemoveLink.Equals(string.Empty))
      {
        int num = 0;
        do
        {
          try
          {
            foreach (KeyValuePair<int, CompanyDocumentAutomation.TemplateDoc> tempWordDoc in this._tempWordDocs)
            {
              if (tempWordDoc.Value.TemplateID == row.TemplateID)
              {
                this._tempWordDocs.Remove(tempWordDoc.Key);
                break;
              }
            }
          }
          finally
          {
            Dictionary<int, CompanyDocumentAutomation.TemplateDoc>.Enumerator enumerator;
            enumerator.Dispose();
          }
          try
          {
            foreach (AutomationDoc automationDoc in this._automationDocs)
            {
              if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument && automationDoc.TemplateID == row.TemplateID)
              {
                this._automationDocs.Remove(automationDoc);
                break;
              }
            }
          }
          finally
          {
            List<AutomationDoc>.Enumerator enumerator;
            enumerator.Dispose();
          }
          ++num;
        }
        while (num <= 100);
        this.ds.TemplateDoc.RemoveTemplateDocRow(row);
      }
    }
  }

  private void lnkRemoveAllButChecked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ProcessTemplateRows(false);
  }

  public void AddFileWatch(string fullPath, TemplateHash templateHash)
  {
    if (this._watchedFiles.ContainsKey(fullPath))
      return;
    this._watchedFiles.Add(fullPath, templateHash);
  }

  private void FileClosed(string fullPath)
  {
    // ISSUE: variable of a compiler-generated type
    frmModifyTemplateDocs._Closure\u0024__95\u002D1 closure951_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmModifyTemplateDocs._Closure\u0024__95\u002D1 closure951_2 = new frmModifyTemplateDocs._Closure\u0024__95\u002D1(closure951_1);
    // ISSUE: reference to a compiler-generated field
    closure951_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure951_2.\u0024VB\u0024Local_fullPath = fullPath;
    MDIControls.Instance.MDIParent.Invoke((Delegate) ([SpecialName] () => ((Control) this.btnSave).Enabled = true));
    // ISSUE: reference to a compiler-generated field
    if (!this._watchedFiles.ContainsKey(closure951_2.\u0024VB\u0024Local_fullPath))
      return;
    // ISSUE: variable of a compiler-generated type
    frmModifyTemplateDocs._Closure\u0024__95\u002D0 closure950_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmModifyTemplateDocs._Closure\u0024__95\u002D0 closure950_2 = new frmModifyTemplateDocs._Closure\u0024__95\u002D0(closure950_1);
    // ISSUE: reference to a compiler-generated field
    closure950_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure951_2;
    // ISSUE: reference to a compiler-generated field
    closure950_2.\u0024VB\u0024Local_template = new TemplateHash();
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    if (!this._watchedFiles.TryGetValue(closure950_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_fullPath, out closure950_2.\u0024VB\u0024Local_template))
      return;
    string str = "";
    foreach (UltraGridRow row in ((UltraGridBase) this.dgTemplateDocs).Rows)
    {
      // ISSUE: reference to a compiler-generated field
      if (Conversions.ToInteger(row.Cells["TemplateID"].Value) == closure950_2.\u0024VB\u0024Local_template.TemplateID)
      {
        str = row.Cells["TemplateName"].Value.ToString();
        break;
      }
    }
    if (MessageBox.Show($"Save changes to '{str}'?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      this._excelTracker.RevertToOriginalFile();
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      ThreadPool.QueueUserWorkItem(new WaitCallback(closure950_2._Lambda\u0024__R2));
    }
  }

  private delegate void AddTemplateRowHandler(
    bool isWordDocument,
    int templateID,
    string fileName,
    string templateName,
    string description,
    string clearText,
    bool isEditable,
    bool isRemovable,
    bool isEmail,
    bool doesRequireEdit,
    string templateType);

  private delegate void SaveDocumentWordAppHandler(object sender, WordDocumentSavedEventArgs e);
}
