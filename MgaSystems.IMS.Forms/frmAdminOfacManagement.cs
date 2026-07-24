// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmAdminOfacManagement
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
[SecureResource("{72659027-825A-4769-8AD2-F50D7BC5EBB1}", "Sanctions Administration", "Clear OFAC hits against IMS entities.", "OFAC")]
[SecureResource("{AC076D9E-74DF-4A72-AF95-3B33C7A30D89}", "Sanctions Dashboard", "Access dashboard to view OFAC hits against IMS entities.", "OFAC")]
[DocumentFolderFilter("Sanctions Dashboard")]
[TestForm]
public class frmAdminOfacManagement : FormBase, ISupportDocumentSystem, IMessageListener
{
  private IContainer components;
  public const string OfacViewResource = "{AC076D9E-74DF-4A72-AF95-3B33C7A30D89}";
  public const string OfacAdminResource = "{72659027-825A-4769-8AD2-F50D7BC5EBB1}";
  public const string FolderFilter = "Sanctions Dashboard";
  private readonly HashSet<(Guid, Guid?)> _historyCache;
  private readonly Dictionary<(Guid, Guid?), DataSet> _xmlCache;
  private readonly Lazy<bool> _canClearHit;
  private readonly Lazy<bool> _showHistoryInfo;
  private readonly Guid? _moveToGuid;
  private bool clickedClearBtn;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("OfacAdmin", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntityGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ParentEntityGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OfacTypeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EntityName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("EntityType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RecreateTypeName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LogDate");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("SearchCriteria");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OfacXml");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ReturnCode");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("HitDate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("HitScore");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ClearDate");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ClearByUserGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ClearReason");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("OFACCleared");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Notes");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ClearByUserName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("OfacAdmin_HitLog");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("OfacAdmin_SearchLog");
    UltraGridBand ultraGridBand2 = new UltraGridBand("OfacAdmin_HitLog", 0);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ClearLogID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("EntityGUID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ParentEntityGUID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("LogDate");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("OFACScore");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ClearDate");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ClearReason");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("Action");
    UltraGridBand ultraGridBand3 = new UltraGridBand("OfacAdmin_SearchLog", 0);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("OfacLogID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("EntityGUID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ParentEntityGUID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("LogDate");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("EntityName");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("ReturnScore");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("OfacAdmin_SearchLog", -1);
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("OfacLogID");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("EntityGUID");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ParentEntityGUID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("LogDate");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("EntityName");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("ReturnScore");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance34 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("OfacAdmin_HitLog", -1);
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ClearLogID");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("EntityGUID");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("ParentEntityGUID");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("LogDate");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("OFACScore");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("ClearDate");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("ClearReason");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Action");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance42 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminOfacManagement));
    this.ugOfacHits = new UltraGrid();
    this.bindingOfac = new BindingSource(this.components);
    this.dsOfac = new dsOfacManagement();
    this.tlpContent = new TableLayoutPanel();
    this.tcOfacData = new TabControl();
    this.pageOfac = new TabPage();
    this.btnSave = new MGAButton();
    this.grpClearData = new GroupBox();
    this.tlpClearInfo = new TableLayoutPanel();
    this.txtNotes = new TextBox();
    this.btnClearOfacHit = new Button();
    this.txtClearByUser = new Label();
    this.txtOfacClearDate = new Label();
    this.lnkPreFilledReasons = new LinkLabel();
    this.pnlClearReason = new Panel();
    this.txtClearReason = new TextBox();
    this.ucClearReason = new UltraComboEditor();
    this.lblClearDate = new Label();
    this.Label2 = new Label();
    this.chkSoftClear = new CheckBox();
    this.lblNotes = new Label();
    this.tlpEntityOfacInfo = new TableLayoutPanel();
    this.lblEntityName = new Label();
    this.lblEntityType = new Label();
    this.lblReturnCode = new Label();
    this.lblOfacScore = new Label();
    this.lblOfacDate = new Label();
    this.lnkEntityName = new LinkLabel();
    this.txtEntityType = new Label();
    this.txtOfacDate = new Label();
    this.txtOfacScore = new Label();
    this.txtReturnCode = new Label();
    this.pageOfacResults = new TabPage();
    this.splitOfacXml = new SplitContainer();
    this.ugCriteria = new UltraGrid();
    this.ugOfacResults = new UltraGrid();
    this.pageOfacHistory = new TabPage();
    this.splitHistory = new SplitContainer();
    this.lnkLoadHistory = new LinkLabel();
    this.splitHistoryGrids = new SplitContainer();
    this.ugEntityLog = new UltraGrid();
    this.bindingSearchLog = new BindingSource(this.components);
    this.ugEntityHitsLog = new UltraGrid();
    this.bindingHitLog = new BindingSource(this.components);
    this.ttOfac = new ToolTip(this.components);
    this.pnlPleaseWait = new UltraGroupBox();
    this.Label13 = new Label();
    this.PictureBox1 = new PictureBox();
    ((ISupportInitialize) this.ugOfacHits).BeginInit();
    ((ISupportInitialize) this.bindingOfac).BeginInit();
    this.dsOfac.BeginInit();
    this.tlpContent.SuspendLayout();
    this.tcOfacData.SuspendLayout();
    this.pageOfac.SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.grpClearData.SuspendLayout();
    this.tlpClearInfo.SuspendLayout();
    this.pnlClearReason.SuspendLayout();
    ((ISupportInitialize) this.ucClearReason).BeginInit();
    this.tlpEntityOfacInfo.SuspendLayout();
    this.pageOfacResults.SuspendLayout();
    this.splitOfacXml.BeginInit();
    this.splitOfacXml.Panel1.SuspendLayout();
    this.splitOfacXml.Panel2.SuspendLayout();
    this.splitOfacXml.SuspendLayout();
    ((ISupportInitialize) this.ugCriteria).BeginInit();
    ((ISupportInitialize) this.ugOfacResults).BeginInit();
    this.pageOfacHistory.SuspendLayout();
    this.splitHistory.BeginInit();
    this.splitHistory.Panel1.SuspendLayout();
    this.splitHistory.Panel2.SuspendLayout();
    this.splitHistory.SuspendLayout();
    this.splitHistoryGrids.BeginInit();
    this.splitHistoryGrids.Panel1.SuspendLayout();
    this.splitHistoryGrids.Panel2.SuspendLayout();
    this.splitHistoryGrids.SuspendLayout();
    ((ISupportInitialize) this.ugEntityLog).BeginInit();
    ((ISupportInitialize) this.bindingSearchLog).BeginInit();
    ((ISupportInitialize) this.ugEntityHitsLog).BeginInit();
    ((ISupportInitialize) this.bindingHitLog).BeginInit();
    ((ISupportInitialize) this.pnlPleaseWait).BeginInit();
    ((Control) this.pnlPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.ugOfacHits).DataSource = (object) this.bindingOfac;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 92;
    ultraGridColumn2.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 100;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Name";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 141;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 144 /*0x90*/;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 70;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "OFAC Date";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 123;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 118;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 115;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 97;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 53;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Score";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Width = 93;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 56;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 155;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 63 /*0x3F*/;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Cleared";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Width = 140;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridBand1.Columns.AddRange(new object[20]
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
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 8;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 5;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35
    });
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugOfacHits).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugOfacHits).Dock = DockStyle.Fill;
    ((Control) this.ugOfacHits).Location = new Point(6, 6);
    ((Control) this.ugOfacHits).Name = "ugOfacHits";
    ((Control) this.ugOfacHits).Size = new Size(819, 309);
    ((Control) this.ugOfacHits).TabIndex = 142;
    ((UltraControlBase) this.ugOfacHits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOfacHits).UseOsThemes = (DefaultableBoolean) 2;
    this.bindingOfac.DataMember = "OfacAdmin";
    this.bindingOfac.DataSource = (object) this.dsOfac;
    this.dsOfac.DataSetName = "dsOfacManagement";
    this.dsOfac.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tlpContent.ColumnCount = 1;
    this.tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.tlpContent.Controls.Add((Control) this.ugOfacHits, 0, 0);
    this.tlpContent.Controls.Add((Control) this.tcOfacData, 0, 1);
    this.tlpContent.Dock = DockStyle.Fill;
    this.tlpContent.Location = new Point(0, 0);
    this.tlpContent.Name = "tlpContent";
    this.tlpContent.Padding = new Padding(3);
    this.tlpContent.RowCount = 2;
    this.tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
    this.tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 215f));
    this.tlpContent.Size = new Size(831, 536);
    this.tlpContent.TabIndex = 143;
    this.tcOfacData.Controls.Add((Control) this.pageOfac);
    this.tcOfacData.Controls.Add((Control) this.pageOfacResults);
    this.tcOfacData.Controls.Add((Control) this.pageOfacHistory);
    this.tcOfacData.Dock = DockStyle.Fill;
    this.tcOfacData.Location = new Point(6, 321);
    this.tcOfacData.Name = "tcOfacData";
    this.tcOfacData.SelectedIndex = 0;
    this.tcOfacData.Size = new Size(819, 209);
    this.tcOfacData.TabIndex = 143;
    this.pageOfac.Controls.Add((Control) this.btnSave);
    this.pageOfac.Controls.Add((Control) this.grpClearData);
    this.pageOfac.Controls.Add((Control) this.tlpEntityOfacInfo);
    this.pageOfac.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "EntityType", true, DataSourceUpdateMode.OnPropertyChanged, (object) "[Not Selected]"));
    this.pageOfac.Location = new Point(4, 22);
    this.pageOfac.Name = "pageOfac";
    this.pageOfac.Padding = new Padding(3);
    this.pageOfac.Size = new Size(811, 183);
    this.pageOfac.TabIndex = 0;
    this.pageOfac.Text = "[EntityType]";
    this.pageOfac.UseVisualStyleBackColor = true;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(765, 137);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 144 /*0x90*/;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.grpClearData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.grpClearData.Controls.Add((Control) this.tlpClearInfo);
    this.grpClearData.Location = new Point(244, 6);
    this.grpClearData.Name = "grpClearData";
    this.grpClearData.Size = new Size(382, 139);
    this.grpClearData.TabIndex = 1;
    this.grpClearData.TabStop = false;
    this.grpClearData.Text = "Clear Data";
    this.tlpClearInfo.ColumnCount = 3;
    this.tlpClearInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.80952f));
    this.tlpClearInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.09524f));
    this.tlpClearInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.09524f));
    this.tlpClearInfo.Controls.Add((Control) this.txtNotes, 2, 2);
    this.tlpClearInfo.Controls.Add((Control) this.btnClearOfacHit, 0, 0);
    this.tlpClearInfo.Controls.Add((Control) this.txtClearByUser, 1, 2);
    this.tlpClearInfo.Controls.Add((Control) this.txtOfacClearDate, 1, 1);
    this.tlpClearInfo.Controls.Add((Control) this.lnkPreFilledReasons, 0, 3);
    this.tlpClearInfo.Controls.Add((Control) this.pnlClearReason, 1, 3);
    this.tlpClearInfo.Controls.Add((Control) this.lblClearDate, 0, 1);
    this.tlpClearInfo.Controls.Add((Control) this.Label2, 0, 2);
    this.tlpClearInfo.Controls.Add((Control) this.chkSoftClear, 2, 0);
    this.tlpClearInfo.Controls.Add((Control) this.lblNotes, 2, 1);
    this.tlpClearInfo.Dock = DockStyle.Fill;
    this.tlpClearInfo.Location = new Point(3, 16 /*0x10*/);
    this.tlpClearInfo.Name = "tlpClearInfo";
    this.tlpClearInfo.RowCount = 5;
    this.tlpClearInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpClearInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpClearInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpClearInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpClearInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpClearInfo.Size = new Size(376, 120);
    this.tlpClearInfo.TabIndex = 0;
    this.txtNotes.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "Notes", true, DataSourceUpdateMode.OnPropertyChanged));
    this.txtNotes.DataBindings.Add(new Binding("ReadOnly", (object) this.bindingOfac, "OFACCleared", true, DataSourceUpdateMode.OnPropertyChanged));
    this.txtNotes.Dock = DockStyle.Fill;
    this.txtNotes.Location = new Point(235, 51);
    this.txtNotes.Multiline = true;
    this.txtNotes.Name = "txtNotes";
    this.tlpClearInfo.SetRowSpan((Control) this.txtNotes, 3);
    this.txtNotes.Size = new Size(138, 66);
    this.txtNotes.TabIndex = 10;
    this.btnClearOfacHit.Anchor = AnchorStyles.None;
    this.tlpClearInfo.SetColumnSpan((Control) this.btnClearOfacHit, 2);
    this.btnClearOfacHit.Location = new Point(51, 1);
    this.btnClearOfacHit.Margin = new Padding(1);
    this.btnClearOfacHit.Name = "btnClearOfacHit";
    this.btnClearOfacHit.Size = new Size(130, 21);
    this.btnClearOfacHit.TabIndex = 3;
    this.btnClearOfacHit.Text = "Clear Hit";
    this.btnClearOfacHit.UseVisualStyleBackColor = true;
    this.txtClearByUser.Anchor = AnchorStyles.Left;
    this.txtClearByUser.AutoSize = true;
    this.txtClearByUser.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "ClearByUserName", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    this.txtClearByUser.Location = new Point(92, 53);
    this.txtClearByUser.Name = "txtClearByUser";
    this.txtClearByUser.Size = new Size(49, 13);
    this.txtClearByUser.TabIndex = 2;
    this.txtClearByUser.Text = "[ClearBy]";
    this.txtOfacClearDate.Anchor = AnchorStyles.Left;
    this.txtOfacClearDate.AutoSize = true;
    this.txtOfacClearDate.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "ClearDate", true, DataSourceUpdateMode.OnPropertyChanged, (object) "[Not Clear]", "G"));
    this.txtOfacClearDate.Location = new Point(92, 29);
    this.txtOfacClearDate.Name = "txtOfacClearDate";
    this.txtOfacClearDate.Size = new Size(60, 13);
    this.txtOfacClearDate.TabIndex = 2;
    this.txtOfacClearDate.Text = "[ClearDate]";
    this.lnkPreFilledReasons.Anchor = AnchorStyles.Right;
    this.lnkPreFilledReasons.AutoSize = true;
    this.lnkPreFilledReasons.Location = new Point(39, 77);
    this.lnkPreFilledReasons.Name = "lnkPreFilledReasons";
    this.lnkPreFilledReasons.Size = new Size(47, 13);
    this.lnkPreFilledReasons.TabIndex = 5;
    this.lnkPreFilledReasons.TabStop = true;
    this.lnkPreFilledReasons.Text = "Reason:";
    this.pnlClearReason.Controls.Add((Control) this.txtClearReason);
    this.pnlClearReason.Controls.Add((Control) this.ucClearReason);
    this.pnlClearReason.Dock = DockStyle.Fill;
    this.pnlClearReason.Location = new Point(92, 75);
    this.pnlClearReason.Name = "pnlClearReason";
    this.tlpClearInfo.SetRowSpan((Control) this.pnlClearReason, 2);
    this.pnlClearReason.Size = new Size(137, 42);
    this.pnlClearReason.TabIndex = 8;
    this.txtClearReason.Dock = DockStyle.Fill;
    this.txtClearReason.Location = new Point(0, 0);
    this.txtClearReason.Multiline = true;
    this.txtClearReason.Name = "txtClearReason";
    this.txtClearReason.Size = new Size(137, 42);
    this.txtClearReason.TabIndex = 7;
    this.ucClearReason.AutoCompleteMode = (AutoCompleteMode) 2;
    ((TextEditorControlBase) this.ucClearReason).AutoSize = false;
    this.ucClearReason.DataMember = "Reasons";
    this.ucClearReason.DataSource = (object) this.dsOfac;
    this.ucClearReason.DisplayMember = "ClearReason";
    this.ucClearReason.DropDownButtonDisplayStyle = (ButtonDisplayStyle) 2;
    this.ucClearReason.DropDownListWidth = -1;
    this.ucClearReason.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ucClearReason).Location = new Point(0, 0);
    ((Control) this.ucClearReason).Name = "ucClearReason";
    ((Control) this.ucClearReason).Size = new Size(229, 42);
    ((Control) this.ucClearReason).TabIndex = 6;
    this.ucClearReason.ValueMember = "ClearReasonID";
    this.lblClearDate.Anchor = AnchorStyles.Right;
    this.lblClearDate.AutoSize = true;
    this.lblClearDate.Location = new Point(26, 29);
    this.lblClearDate.Name = "lblClearDate";
    this.lblClearDate.Size = new Size(60, 13);
    this.lblClearDate.TabIndex = 0;
    this.lblClearDate.Text = "Clear Date:";
    this.Label2.Anchor = AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(25, 53);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(61, 13);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Cleared By:";
    this.chkSoftClear.Anchor = AnchorStyles.Left;
    this.chkSoftClear.AutoSize = true;
    this.chkSoftClear.Location = new Point(235, 3);
    this.chkSoftClear.Name = "chkSoftClear";
    this.chkSoftClear.Size = new Size(72, 17);
    this.chkSoftClear.TabIndex = 9;
    this.chkSoftClear.Text = "Soft Clear";
    this.chkSoftClear.UseVisualStyleBackColor = true;
    this.lblNotes.Anchor = AnchorStyles.Left;
    this.lblNotes.AutoSize = true;
    this.lblNotes.Location = new Point(235, 29);
    this.lblNotes.Name = "lblNotes";
    this.lblNotes.Size = new Size(38, 13);
    this.lblNotes.TabIndex = 0;
    this.lblNotes.Text = "Notes:";
    this.lblNotes.TextAlign = ContentAlignment.MiddleCenter;
    this.tlpEntityOfacInfo.ColumnCount = 2;
    this.tlpEntityOfacInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85f));
    this.tlpEntityOfacInfo.ColumnStyles.Add(new ColumnStyle());
    this.tlpEntityOfacInfo.Controls.Add((Control) this.lblEntityName, 0, 0);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.lblEntityType, 0, 1);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.lblReturnCode, 0, 4);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.lblOfacScore, 0, 3);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.lblOfacDate, 0, 2);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.lnkEntityName, 1, 0);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.txtEntityType, 1, 1);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.txtOfacDate, 1, 2);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.txtOfacScore, 1, 3);
    this.tlpEntityOfacInfo.Controls.Add((Control) this.txtReturnCode, 1, 4);
    this.tlpEntityOfacInfo.Dock = DockStyle.Left;
    this.tlpEntityOfacInfo.Location = new Point(3, 3);
    this.tlpEntityOfacInfo.Name = "tlpEntityOfacInfo";
    this.tlpEntityOfacInfo.RowCount = 5;
    this.tlpEntityOfacInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpEntityOfacInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpEntityOfacInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpEntityOfacInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpEntityOfacInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
    this.tlpEntityOfacInfo.Size = new Size(235, 177);
    this.tlpEntityOfacInfo.TabIndex = 0;
    this.lblEntityName.Anchor = AnchorStyles.Right;
    this.lblEntityName.AutoSize = true;
    this.lblEntityName.Location = new Point(15, 11);
    this.lblEntityName.Name = "lblEntityName";
    this.lblEntityName.Size = new Size(67, 13);
    this.lblEntityName.TabIndex = 0;
    this.lblEntityName.Text = "Entity Name:";
    this.lblEntityType.Anchor = AnchorStyles.Right;
    this.lblEntityType.AutoSize = true;
    this.lblEntityType.Location = new Point(19, 46);
    this.lblEntityType.Name = "lblEntityType";
    this.lblEntityType.Size = new Size(63 /*0x3F*/, 13);
    this.lblEntityType.TabIndex = 0;
    this.lblEntityType.Text = "Entity Type:";
    this.lblReturnCode.Anchor = AnchorStyles.Right;
    this.lblReturnCode.AutoSize = true;
    this.lblReturnCode.Location = new Point(12, 152);
    this.lblReturnCode.Name = "lblReturnCode";
    this.lblReturnCode.Size = new Size(70, 13);
    this.lblReturnCode.TabIndex = 0;
    this.lblReturnCode.Text = "Return Code:";
    this.lblOfacScore.Anchor = AnchorStyles.Right;
    this.lblOfacScore.AutoSize = true;
    this.lblOfacScore.Location = new Point(13, 116);
    this.lblOfacScore.Name = "lblOfacScore";
    this.lblOfacScore.Size = new Size(69, 13);
    this.lblOfacScore.TabIndex = 0;
    this.lblOfacScore.Text = "OFAC Score:";
    this.lblOfacDate.Anchor = AnchorStyles.Right;
    this.lblOfacDate.AutoSize = true;
    this.lblOfacDate.Location = new Point(18, 81);
    this.lblOfacDate.Name = "lblOfacDate";
    this.lblOfacDate.Size = new Size(64 /*0x40*/, 13);
    this.lblOfacDate.TabIndex = 0;
    this.lblOfacDate.Text = "OFAC Date:";
    this.lnkEntityName.Anchor = AnchorStyles.Left;
    this.lnkEntityName.AutoSize = true;
    this.lnkEntityName.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "EntityName", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    this.lnkEntityName.Location = new Point(88, 11);
    this.lnkEntityName.Name = "lnkEntityName";
    this.lnkEntityName.Size = new Size(67, 13);
    this.lnkEntityName.TabIndex = 1;
    this.lnkEntityName.TabStop = true;
    this.lnkEntityName.Text = "[EntityName]";
    this.txtEntityType.Anchor = AnchorStyles.Left;
    this.txtEntityType.AutoSize = true;
    this.txtEntityType.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "EntityType", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    this.txtEntityType.Location = new Point(88, 46);
    this.txtEntityType.Name = "txtEntityType";
    this.txtEntityType.Size = new Size(63 /*0x3F*/, 13);
    this.txtEntityType.TabIndex = 2;
    this.txtEntityType.Text = "[EntityType]";
    this.txtOfacDate.Anchor = AnchorStyles.Left;
    this.txtOfacDate.AutoSize = true;
    this.txtOfacDate.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "LogDate", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A", "G"));
    this.txtOfacDate.Location = new Point(88, 81);
    this.txtOfacDate.Name = "txtOfacDate";
    this.txtOfacDate.Size = new Size(64 /*0x40*/, 13);
    this.txtOfacDate.TabIndex = 2;
    this.txtOfacDate.Text = "[OFACDate]";
    this.txtOfacScore.Anchor = AnchorStyles.Left;
    this.txtOfacScore.AutoSize = true;
    this.txtOfacScore.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "HitScore", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    this.txtOfacScore.Location = new Point(88, 116);
    this.txtOfacScore.Name = "txtOfacScore";
    this.txtOfacScore.Size = new Size(69, 13);
    this.txtOfacScore.TabIndex = 2;
    this.txtOfacScore.Text = "[OFACScore]";
    this.txtReturnCode.Anchor = AnchorStyles.Left;
    this.txtReturnCode.AutoSize = true;
    this.txtReturnCode.DataBindings.Add(new Binding("Text", (object) this.bindingOfac, "ReturnCode", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    this.txtReturnCode.Location = new Point(88, 152);
    this.txtReturnCode.Name = "txtReturnCode";
    this.txtReturnCode.Size = new Size(70, 13);
    this.txtReturnCode.TabIndex = 2;
    this.txtReturnCode.Text = "[ReturnCode]";
    this.pageOfacResults.Controls.Add((Control) this.splitOfacXml);
    this.pageOfacResults.Location = new Point(4, 22);
    this.pageOfacResults.Name = "pageOfacResults";
    this.pageOfacResults.Padding = new Padding(3);
    this.pageOfacResults.Size = new Size(811, 183);
    this.pageOfacResults.TabIndex = 1;
    this.pageOfacResults.Text = "OFAC Results";
    this.pageOfacResults.UseVisualStyleBackColor = true;
    this.splitOfacXml.Dock = DockStyle.Fill;
    this.splitOfacXml.Location = new Point(3, 3);
    this.splitOfacXml.Name = "splitOfacXml";
    this.splitOfacXml.Panel1.Controls.Add((Control) this.ugCriteria);
    this.splitOfacXml.Panel2.Controls.Add((Control) this.ugOfacResults);
    this.splitOfacXml.Size = new Size(805, 177);
    this.splitOfacXml.SplitterDistance = 267;
    this.splitOfacXml.TabIndex = 146;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.LightSteelBlue;
    appearance11.FontData.SizeInPoints = 10f;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugCriteria).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugCriteria).Dock = DockStyle.Fill;
    ((Control) this.ugCriteria).Location = new Point(0, 0);
    ((Control) this.ugCriteria).Name = "ugCriteria";
    ((Control) this.ugCriteria).Size = new Size(267, 177);
    ((Control) this.ugCriteria).TabIndex = 144 /*0x90*/;
    ((UltraControlBase) this.ugCriteria).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCriteria).UseOsThemes = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Appearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = Color.LightSteelBlue;
    appearance19.FontData.SizeInPoints = 10f;
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.ColumnAutoSizeMode = (ColumnAutoSizeMode) 4;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance23.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.Transparent;
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugOfacResults).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.ugOfacResults).Dock = DockStyle.Fill;
    ((Control) this.ugOfacResults).Location = new Point(0, 0);
    ((Control) this.ugOfacResults).Name = "ugOfacResults";
    ((Control) this.ugOfacResults).Size = new Size(534, 177);
    ((Control) this.ugOfacResults).TabIndex = 145;
    ((UltraControlBase) this.ugOfacResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugOfacResults).UseOsThemes = (DefaultableBoolean) 2;
    this.pageOfacHistory.Controls.Add((Control) this.splitHistory);
    this.pageOfacHistory.Location = new Point(4, 22);
    this.pageOfacHistory.Name = "pageOfacHistory";
    this.pageOfacHistory.Size = new Size(811, 183);
    this.pageOfacHistory.TabIndex = 2;
    this.pageOfacHistory.Text = "History";
    this.pageOfacHistory.UseVisualStyleBackColor = true;
    this.splitHistory.Dock = DockStyle.Fill;
    this.splitHistory.Location = new Point(0, 0);
    this.splitHistory.Name = "splitHistory";
    this.splitHistory.Orientation = Orientation.Horizontal;
    this.splitHistory.Panel1.Controls.Add((Control) this.lnkLoadHistory);
    this.splitHistory.Panel2.Controls.Add((Control) this.splitHistoryGrids);
    this.splitHistory.Size = new Size(811, 183);
    this.splitHistory.SplitterDistance = 26;
    this.splitHistory.TabIndex = 148;
    this.lnkLoadHistory.AutoSize = true;
    this.lnkLoadHistory.Location = new Point(4, 5);
    this.lnkLoadHistory.Name = "lnkLoadHistory";
    this.lnkLoadHistory.Size = new Size(66, 13);
    this.lnkLoadHistory.TabIndex = 0;
    this.lnkLoadHistory.TabStop = true;
    this.lnkLoadHistory.Text = "Load History";
    this.splitHistoryGrids.Dock = DockStyle.Fill;
    this.splitHistoryGrids.Location = new Point(0, 0);
    this.splitHistoryGrids.Name = "splitHistoryGrids";
    this.splitHistoryGrids.Panel1.Controls.Add((Control) this.ugEntityLog);
    this.splitHistoryGrids.Panel2.Controls.Add((Control) this.ugEntityHitsLog);
    this.splitHistoryGrids.Size = new Size(811, 153);
    this.splitHistoryGrids.SplitterDistance = 270;
    this.splitHistoryGrids.TabIndex = 147;
    ((UltraGridBase) this.ugEntityLog).DataSource = (object) this.bindingSearchLog;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Appearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 0;
    ultraGridColumn36.Hidden = true;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 1;
    ultraGridColumn37.Hidden = true;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 2;
    ultraGridColumn38.Hidden = true;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Searched";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Name";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Score";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 5;
    ultraGridBand4.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41
    });
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance27.BackColor = Color.LightSteelBlue;
    appearance27.FontData.SizeInPoints = 10f;
    appearance27.ForeColor = Color.Black;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance29.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance31.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance31;
    appearance32.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance33.BackColor = Color.Transparent;
    appearance33.ForeColor = Color.Black;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance33;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((UltraGridBase) this.ugEntityLog).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugEntityLog).Dock = DockStyle.Fill;
    ((Control) this.ugEntityLog).Location = new Point(0, 0);
    ((Control) this.ugEntityLog).Name = "ugEntityLog";
    ((Control) this.ugEntityLog).Size = new Size(270, 153);
    ((Control) this.ugEntityLog).TabIndex = 145;
    ((UltraControlBase) this.ugEntityLog).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugEntityLog).UseOsThemes = (DefaultableBoolean) 2;
    this.bindingSearchLog.DataMember = "OfacAdmin_SearchLog";
    this.bindingSearchLog.DataSource = (object) this.bindingOfac;
    ((UltraGridBase) this.ugEntityHitsLog).DataSource = (object) this.bindingHitLog;
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Appearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 0;
    ultraGridColumn42.Hidden = true;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 1;
    ultraGridColumn43.Hidden = true;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 2;
    ultraGridColumn44.Hidden = true;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Searched";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 6;
    ultraGridColumn47.Hidden = true;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Cleared";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "Reason";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 8;
    ultraGridBand5.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50
    });
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance35.BackColor = Color.LightSteelBlue;
    appearance35.FontData.SizeInPoints = 10f;
    appearance35.ForeColor = Color.Black;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance35;
    appearance36.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance37.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance37;
    appearance38.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance39.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance39;
    appearance40.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance41.BackColor = Color.Transparent;
    appearance41.ForeColor = Color.Black;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance41;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((UltraGridBase) this.ugEntityHitsLog).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugEntityHitsLog).Dock = DockStyle.Fill;
    ((Control) this.ugEntityHitsLog).Location = new Point(0, 0);
    ((Control) this.ugEntityHitsLog).Name = "ugEntityHitsLog";
    ((Control) this.ugEntityHitsLog).Size = new Size(537, 153);
    ((Control) this.ugEntityHitsLog).TabIndex = 146;
    ((UltraControlBase) this.ugEntityHitsLog).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugEntityHitsLog).UseOsThemes = (DefaultableBoolean) 2;
    this.bindingHitLog.DataMember = "OfacAdmin_HitLog";
    this.bindingHitLog.DataSource = (object) this.bindingOfac;
    ((Control) this.pnlPleaseWait).Anchor = AnchorStyles.Top;
    appearance42.BackColor = Color.White;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance42;
    ((Control) this.pnlPleaseWait).Controls.Add((Control) this.Label13);
    ((Control) this.pnlPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.pnlPleaseWait).Location = new Point(247, 125);
    ((Control) this.pnlPleaseWait).Name = "pnlPleaseWait";
    ((Control) this.pnlPleaseWait).Size = new Size(337, 87);
    ((Control) this.pnlPleaseWait).TabIndex = 144 /*0x90*/;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.White;
    this.Label13.Font = new Font("Tahoma", 20f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.Location = new Point(102, 27);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(132, 33);
    this.Label13.TabIndex = 1;
    this.Label13.Text = "Loading...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(831, 536);
    this.Controls.Add((Control) this.pnlPleaseWait);
    this.Controls.Add((Control) this.tlpContent);
    this.Name = nameof (frmAdminOfacManagement);
    this.Text = "OFAC Management";
    ((ISupportInitialize) this.ugOfacHits).EndInit();
    ((ISupportInitialize) this.bindingOfac).EndInit();
    this.dsOfac.EndInit();
    this.tlpContent.ResumeLayout(false);
    this.tcOfacData.ResumeLayout(false);
    this.pageOfac.ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    this.grpClearData.ResumeLayout(false);
    this.tlpClearInfo.ResumeLayout(false);
    this.tlpClearInfo.PerformLayout();
    this.pnlClearReason.ResumeLayout(false);
    this.pnlClearReason.PerformLayout();
    ((ISupportInitialize) this.ucClearReason).EndInit();
    this.tlpEntityOfacInfo.ResumeLayout(false);
    this.tlpEntityOfacInfo.PerformLayout();
    this.pageOfacResults.ResumeLayout(false);
    this.splitOfacXml.Panel1.ResumeLayout(false);
    this.splitOfacXml.Panel2.ResumeLayout(false);
    this.splitOfacXml.EndInit();
    this.splitOfacXml.ResumeLayout(false);
    ((ISupportInitialize) this.ugCriteria).EndInit();
    ((ISupportInitialize) this.ugOfacResults).EndInit();
    this.pageOfacHistory.ResumeLayout(false);
    this.splitHistory.Panel1.ResumeLayout(false);
    this.splitHistory.Panel1.PerformLayout();
    this.splitHistory.Panel2.ResumeLayout(false);
    this.splitHistory.EndInit();
    this.splitHistory.ResumeLayout(false);
    this.splitHistoryGrids.Panel1.ResumeLayout(false);
    this.splitHistoryGrids.Panel2.ResumeLayout(false);
    this.splitHistoryGrids.EndInit();
    this.splitHistoryGrids.ResumeLayout(false);
    ((ISupportInitialize) this.ugEntityLog).EndInit();
    ((ISupportInitialize) this.bindingSearchLog).EndInit();
    ((ISupportInitialize) this.ugEntityHitsLog).EndInit();
    ((ISupportInitialize) this.bindingHitLog).EndInit();
    ((ISupportInitialize) this.pnlPleaseWait).EndInit();
    ((Control) this.pnlPleaseWait).ResumeLayout(false);
    ((Control) this.pnlPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugOfacHits")]
  private virtual UltraGrid ugOfacHits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsOfac")]
  internal virtual dsOfacManagement dsOfac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BindingSource bindingOfac
  {
    get => this._bindingOfac;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.bindingOfac_CurrentChanged);
      BindingSource bindingOfac1 = this._bindingOfac;
      if (bindingOfac1 != null)
        bindingOfac1.CurrentChanged -= eventHandler;
      this._bindingOfac = value;
      BindingSource bindingOfac2 = this._bindingOfac;
      if (bindingOfac2 == null)
        return;
      bindingOfac2.CurrentChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tlpContent")]
  internal virtual TableLayoutPanel tlpContent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tcOfacData")]
  internal virtual TabControl tcOfacData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pageOfac")]
  internal virtual TabPage pageOfac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pageOfacResults")]
  internal virtual TabPage pageOfacResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tlpEntityOfacInfo")]
  internal virtual TableLayoutPanel tlpEntityOfacInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEntityName")]
  internal virtual Label lblEntityName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEntityType")]
  internal virtual Label lblEntityType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblReturnCode")]
  internal virtual Label lblReturnCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacScore")]
  internal virtual Label lblOfacScore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfacDate")]
  internal virtual Label lblOfacDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkEntityName
  {
    get => this._lnkEntityName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEntityName_LinkClicked);
      LinkLabel lnkEntityName1 = this._lnkEntityName;
      if (lnkEntityName1 != null)
        lnkEntityName1.LinkClicked -= clickedEventHandler;
      this._lnkEntityName = value;
      LinkLabel lnkEntityName2 = this._lnkEntityName;
      if (lnkEntityName2 == null)
        return;
      lnkEntityName2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtEntityType")]
  internal virtual Label txtEntityType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtOfacDate")]
  internal virtual Label txtOfacDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtOfacScore")]
  internal virtual Label txtOfacScore { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtReturnCode")]
  internal virtual Label txtReturnCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugOfacResults")]
  private virtual UltraGrid ugOfacResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugCriteria")]
  private virtual UltraGrid ugCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tlpClearInfo")]
  internal virtual TableLayoutPanel tlpClearInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblClearDate")]
  internal virtual Label lblClearDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtOfacClearDate")]
  internal virtual Label txtOfacClearDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtClearByUser")]
  internal virtual Label txtClearByUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnClearOfacHit
  {
    get => this._btnClearOfacHit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClearOfacHit_Click);
      Button btnClearOfacHit1 = this._btnClearOfacHit;
      if (btnClearOfacHit1 != null)
        btnClearOfacHit1.Click -= eventHandler;
      this._btnClearOfacHit = value;
      Button btnClearOfacHit2 = this._btnClearOfacHit;
      if (btnClearOfacHit2 == null)
        return;
      btnClearOfacHit2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkPreFilledReasons
  {
    get => this._lnkPreFilledReasons;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPreFilledReasons_LinkClicked);
      LinkLabel preFilledReasons1 = this._lnkPreFilledReasons;
      if (preFilledReasons1 != null)
        preFilledReasons1.LinkClicked -= clickedEventHandler;
      this._lnkPreFilledReasons = value;
      LinkLabel preFilledReasons2 = this._lnkPreFilledReasons;
      if (preFilledReasons2 == null)
        return;
      preFilledReasons2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("splitOfacXml")]
  internal virtual SplitContainer splitOfacXml { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtClearReason")]
  internal virtual TextBox txtClearReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlClearReason")]
  internal virtual Panel pnlClearReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSoftClear")]
  internal virtual CheckBox chkSoftClear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNotes")]
  internal virtual TextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNotes")]
  internal virtual Label lblNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pageOfacHistory")]
  internal virtual TabPage pageOfacHistory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugEntityHitsLog")]
  private virtual UltraGrid ugEntityHitsLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugEntityLog")]
  private virtual UltraGrid ugEntityLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("bindingHitLog")]
  internal virtual BindingSource bindingHitLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("bindingSearchLog")]
  internal virtual BindingSource bindingSearchLog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("splitHistoryGrids")]
  internal virtual SplitContainer splitHistoryGrids { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("splitHistory")]
  internal virtual SplitContainer splitHistory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkLoadHistory
  {
    get => this._lnkLoadHistory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLoadHistory_LinkClicked);
      LinkLabel lnkLoadHistory1 = this._lnkLoadHistory;
      if (lnkLoadHistory1 != null)
        lnkLoadHistory1.LinkClicked -= clickedEventHandler;
      this._lnkLoadHistory = value;
      LinkLabel lnkLoadHistory2 = this._lnkLoadHistory;
      if (lnkLoadHistory2 == null)
        return;
      lnkLoadHistory2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual UltraComboEditor ucClearReason
  {
    get => this._ucClearReason;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeDataItemHandler initializeDataItemHandler = new InitializeDataItemHandler((object) this, __methodptr(ucClearReason_InitializeDataItemHandler));
      EventHandler eventHandler1 = new EventHandler(this.ucClearReason_Closed);
      EventHandler eventHandler2 = new EventHandler(this.ucClearReason_AfterCloseUp);
      UltraComboEditor ucClearReason1 = this._ucClearReason;
      if (ucClearReason1 != null)
      {
        ucClearReason1.InitializeDataItem -= initializeDataItemHandler;
        ((TextEditorControlBase) ucClearReason1).ValueChanged -= eventHandler1;
        ucClearReason1.AfterCloseUp -= eventHandler2;
      }
      this._ucClearReason = value;
      UltraComboEditor ucClearReason2 = this._ucClearReason;
      if (ucClearReason2 == null)
        return;
      ucClearReason2.InitializeDataItem += initializeDataItemHandler;
      ((TextEditorControlBase) ucClearReason2).ValueChanged += eventHandler1;
      ucClearReason2.AfterCloseUp += eventHandler2;
    }
  }

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

  [field: AccessedThroughProperty("grpClearData")]
  protected virtual GroupBox grpClearData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ttOfac")]
  protected virtual ToolTip ttOfac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlPleaseWait")]
  private virtual UltraGroupBox pnlPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  private virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected MGAButton SaveButton => this.btnSave;

  public frmAdminOfacManagement()
  {
    this.Load += new EventHandler(this.frmAdminOfacManagement_Load);
    this._historyCache = new HashSet<(Guid, Guid?)>();
    this._xmlCache = new Dictionary<(Guid, Guid?), DataSet>();
    Func<bool> valueFactory;
    // ISSUE: reference to a compiler-generated field
    if (frmAdminOfacManagement._Closure\u0024__.\u0024I206\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory = frmAdminOfacManagement._Closure\u0024__.\u0024I206\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmAdminOfacManagement._Closure\u0024__.\u0024I206\u002D0 = valueFactory = (Func<bool>) ([SpecialName] () => SecurityManager.Instance.AssertPermission("{72659027-825A-4769-8AD2-F50D7BC5EBB1}"));
    }
    this._canClearHit = new Lazy<bool>(valueFactory);
    this._showHistoryInfo = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("OFACManagement.ShowHistory", false, true);
    this.clickedClearBtn = false;
    this.InitializeComponent();
  }

  public frmAdminOfacManagement(Guid moveToEntityGuid)
    : this()
  {
    this._moveToGuid = new Guid?(moveToEntityGuid);
  }

  private void frmAdminOfacManagement_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((UltraControlBase) this.ugOfacHits).BeginUpdate();
    this.bindingOfac.SuspendBinding();
    this.dsOfac.EnforceConstraints = false;
    this.dsOfac.OfacAdmin.ParentEntityGUIDColumn.AllowDBNull = true;
    ((Control) this.ucClearReason).DataBindings.Add(new Binding("Text", (object) this.txtClearReason, "Text", false, DataSourceUpdateMode.OnPropertyChanged));
    if (!this._showHistoryInfo.Value)
    {
      this.tcOfacData.TabPages.Remove(this.pageOfacHistory);
      this.splitHistory.Orientation = Orientation.Horizontal;
      this.splitHistoryGrids.Orientation = Orientation.Vertical;
    }
    Utility.ExecuteThread((object) this._moveToGuid, new DoWorkEventHandler(this.LoadData), new RunWorkerCompletedEventHandler(this.LoadComplete), (ProgressChangedEventHandler) null);
  }

  private void LoadData(object obj, DoWorkEventArgs args)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsOfac, new string[2]
    {
      this.dsOfac.OfacAdmin.TableName,
      this.dsOfac.Reasons.TableName
    }, CommandType.StoredProcedure, "dbo.OFAC_AdminFormLoad", 90, (CommandArgumentType) 0, Array.Empty<object>());
    try
    {
      foreach (MGASystems.Common.User user in (List<MGASystems.Common.User>) CurrentUser.Instance.Users)
        this.dsOfac.Users.AddUsersRow(user.UserGuid, user.DisplayName);
    }
    finally
    {
      List<MGASystems.Common.User>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.dsOfac.EnforceConstraints = true;
    args.Result = RuntimeHelpers.GetObjectValue(this.ClientLoadData(this.dsOfac, args));
  }

  protected object ClientLoadData(dsOfacManagement ds, DoWorkEventArgs args) => (object) null;

  private void LoadComplete(object obj, RunWorkerCompletedEventArgs args)
  {
    if (args.Error != null)
    {
      ErrorHandler.HandleErrorOnThread((Control) this, args.Error);
      this.Close();
    }
    else
    {
      if (this.dsOfac.Reasons.Count == 0)
      {
        this.lnkPreFilledReasons.LinkBehavior = LinkBehavior.NeverUnderline;
        this.lnkPreFilledReasons.LinkColor = SystemColors.ControlText;
      }
      ((Control) this.pnlPleaseWait).Visible = false;
      this.bindingOfac.ResumeBinding();
      ((UltraControlBase) this.ugOfacHits).EndUpdate();
      if (this._moveToGuid.HasValue)
        this.MoveToGuid(this._moveToGuid.Value);
      this.ClientLoadComplete(args);
    }
  }

  private void ClientLoadComplete(RunWorkerCompletedEventArgs args)
  {
  }

  private void bindingOfac_CurrentChanged(object sender, EventArgs e)
  {
    if (this.CurrentRow != null)
    {
      if (this.CurrentRow.RowState.ValueIn<DataRowState>(DataRowState.Deleted, DataRowState.Detached))
        return;
    }
    this.UpdateFormControls(this.CurrentRow);
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent == null)
      return;
    infoChangedEvent((object) this, e);
  }

  protected void UpdateFormControls(dsOfacManagement.OfacAdminRow curRow)
  {
    this.lnkEntityName.LinkVisited = false;
    if (curRow != null)
    {
      this.lnkEntityName.Enabled = !string.IsNullOrEmpty(curRow.RecreateTypeName);
      this.grpClearData.Enabled = this._canClearHit.Value && !curRow.IsHitDateNull();
      DataSet dataSet = (DataSet) null;
      if (!string.IsNullOrEmpty(curRow.Field<string>("OfacXml")) && !this._xmlCache.TryGetValue((curRow.EntityGUID, curRow.NullableParentEntityGuid), out dataSet))
      {
        dataSet = ((OfacSetting) OfacSystem.Instance.GetSetting(curRow.OfacTypeID)).GetXmlDataset(curRow.OfacXml) ?? new DataSet();
        DataTable dataTable = dataSet.Tables.Add("Criteria");
        dataTable.Columns.AddRange(new DataColumn[2]
        {
          new DataColumn("Field"),
          new DataColumn("Value")
        });
        if (!string.IsNullOrEmpty(curRow.SearchCriteria))
        {
          XDocument xdocument = XDocument.Parse(curRow.SearchCriteria);
          try
          {
            IEnumerable<XElement> source = xdocument.Element((XName) "Criteria").Descendants();
            System.Func<XElement, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (frmAdminOfacManagement._Closure\u0024__.\u0024I214\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = frmAdminOfacManagement._Closure\u0024__.\u0024I214\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              frmAdminOfacManagement._Closure\u0024__.\u0024I214\u002D0 = predicate = (System.Func<XElement, bool>) ([SpecialName] (tx) => !string.IsNullOrEmpty(tx.Value));
            }
            foreach (XElement xelement in source.Where<XElement>(predicate))
              dataTable.Rows.Add((object) xelement.Name.LocalName, (object) xelement.Value);
          }
          finally
          {
            IEnumerator<XElement> enumerator;
            enumerator?.Dispose();
          }
        }
        this._xmlCache.Add((curRow.EntityGUID, curRow.NullableParentEntityGuid), dataSet);
      }
      if (dataSet != null && dataSet.Tables.Count > 0)
      {
        ((UltraGridBase) this.ugOfacResults).DataSource = (object) dataSet.Tables[0].DefaultView;
        ((UltraGridBase) this.ugOfacResults).DisplayLayout.Bands[0].HeaderVisible = true;
        ((HeaderBase) ((UltraGridBase) this.ugOfacResults).DisplayLayout.Bands[0].Header).Caption = "Results";
        ((UltraGridBase) this.ugOfacResults).DisplayLayout.Bands[0].PerformAutoResizeColumns(false, (PerformAutoSizeType) 1);
        ((UltraGridBase) this.ugCriteria).DataSource = (object) dataSet.Tables["Criteria"].DefaultView;
        ((UltraGridBase) this.ugCriteria).DisplayLayout.Bands[0].HeaderVisible = true;
        ((HeaderBase) ((UltraGridBase) this.ugCriteria).DisplayLayout.Bands[0].Header).Caption = "Criteria";
        ((UltraGridBase) this.ugCriteria).DisplayLayout.Bands[0].PerformAutoResizeColumns(false, (PerformAutoSizeType) 1);
      }
      else
      {
        ((UltraGridBase) this.ugOfacResults).DataSource = (object) null;
        ((UltraGridBase) this.ugCriteria).DataSource = (object) null;
      }
      this.btnClearOfacHit.Tag = (object) curRow.OFACCleared;
      this.lnkPreFilledReasons.Enabled = !curRow.OFACCleared;
      this.txtClearReason.Text = curRow.ClearReason;
      this.txtClearReason.ReadOnly = curRow.OFACCleared;
      this.chkSoftClear.Enabled = !curRow.OFACCleared;
      this.chkSoftClear.Checked = !curRow.OFACCleared && !curRow.IsClearByUserGuidNull();
      this.btnClearOfacHit.Text = curRow.OFACCleared ? "Reinstate Hit" : "Clear Hit";
      this.lnkLoadHistory.Enabled = !this._historyCache.Contains((curRow.EntityGUID, curRow.NullableParentEntityGuid));
      if (this.lnkLoadHistory.Enabled)
      {
        this.bindingSearchLog.SuspendBinding();
        this.bindingHitLog.SuspendBinding();
      }
      else
      {
        this.bindingSearchLog.ResumeBinding();
        this.bindingHitLog.ResumeBinding();
      }
      this.ClientCurrentChanged(curRow);
    }
    else
    {
      ((UltraGridBase) this.ugOfacResults).DataSource = (object) null;
      ((UltraGridBase) this.ugCriteria).DataSource = (object) null;
      this.bindingSearchLog.SuspendBinding();
      this.bindingHitLog.SuspendBinding();
      this.lnkEntityName.Enabled = false;
      this.grpClearData.Enabled = false;
      this.btnClearOfacHit.Text = "Clear Hit";
      this.lnkLoadHistory.Enabled = true;
      this.lnkPreFilledReasons.Enabled = false;
      this.chkSoftClear.Checked = false;
      this.clickedClearBtn = false;
    }
  }

  protected virtual void ClientCurrentChanged(dsOfacManagement.OfacAdminRow curRow)
  {
  }

  public void MoveToGuid(Guid entityGuid)
  {
    dsOfacManagement.OfacAdminRow ofacAdminRow = this.dsOfac.OfacAdmin.FirstOrDefault<dsOfacManagement.OfacAdminRow>((System.Func<dsOfacManagement.OfacAdminRow, bool>) ([SpecialName] (r) => r.EntityGUID == entityGuid));
    if (ofacAdminRow == null)
      return;
    this.bindingOfac.Position = ((UltraGridBase) this.ugOfacHits).Rows.GetRowWithListIndex(((UltraGridBase) this.ugOfacHits).Rows.IndexOf((object) ofacAdminRow)).Index;
  }

  protected void RefreshData(Guid entityGuid, Guid? parentEntity)
  {
    dsOfacManagement.OfacAdminRow row = this.dsOfac.OfacAdmin.FindByEntityGUIDNullableParentEntityGUID(entityGuid, parentEntity);
    dsOfacManagement dsOfacManagement = (dsOfacManagement) this.dsOfac.Clone();
    dsOfacManagement.EnforceConstraints = false;
    dsOfacManagement.OfacAdminDataTable ofacAdmin = dsOfacManagement.OfacAdmin;
    DefaultDatabase.LoadDataTable((DataTable) ofacAdmin, "dbo.OFAC_AdminGetHits", new object[6]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@parentEntity",
      (object) parentEntity,
      (object) "@hitsOnly",
      (object) false
    });
    int position = this.bindingOfac.Position;
    row?.Equals((object) this.CurrentRow);
    try
    {
      if (row == null ^ ofacAdmin.Count == 0)
      {
        if (row != null)
        {
          ((UltraGridBase) this.ugOfacHits).Rows.GetRowWithListIndex(this.dsOfac.OfacAdmin.Rows.IndexOf((DataRow) row)).Delete(false);
          row.AcceptChanges();
        }
      }
      else if (ofacAdmin.Count == 0)
        return;
      if (ofacAdmin.Count <= 0)
        return;
      if (row == null)
        row = this.dsOfac.OfacAdmin.NewOfacAdminRow();
      row.ItemArray = ofacAdmin.Rows[0].ItemArray;
      dsOfacManagement.SearchLogRow[] searchLogRows = row.GetSearchLogRows();
      int index1 = 0;
      while (index1 < searchLogRows.Length)
      {
        searchLogRows[index1].Delete();
        checked { ++index1; }
      }
      dsOfacManagement.HitLogRow[] hitLogRows = row.GetHitLogRows();
      int index2 = 0;
      while (index2 < hitLogRows.Length)
      {
        hitLogRows[index2].Delete();
        checked { ++index2; }
      }
      this.dsOfac.SearchLog.AcceptChanges();
      this.dsOfac.HitLog.AcceptChanges();
      this._historyCache.Remove((entityGuid, parentEntity));
      row.AcceptChanges();
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "EntityGUID", (object) entityGuid);
      ex2.Data.Add((object) "ParentEntityGUID", (object) parentEntity);
      ErrorHandler.SilentLogError(ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      ((UltraGridBase) this.ugOfacHits).UpdateData();
      this.bindingOfac.ResetBindings(false);
    }
  }

  private void lnkPreFilledReasons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.dsOfac.Reasons.Count <= 0)
      return;
    ((Control) this.ucClearReason).Dock = DockStyle.Left;
    ((TextEditorControlBase) this.ucClearReason).Appearance.TextVAlign = (VAlign) 1;
    this.ucClearReason.DropDown();
  }

  private void ucClearReason_InitializeDataItemHandler(object sender, InitializeDataItemEventArgs e)
  {
    if (!(e.ValueListItem.ListObject is DataRowView listObject) || !listObject.Row.Field<bool>("SoftClear"))
      return;
    e.ValueListItem.Appearance.FontData.Italic = (DefaultableBoolean) 1;
    e.ValueListItem.Appearance.ForeColor = Color.DarkCyan;
  }

  private void ucClearReason_Closed(object sender, EventArgs args)
  {
    int? nullable = (int?) this.ucClearReason.Value;
    if (!nullable.HasValue)
      return;
    CheckBox chkSoftClear = this.chkSoftClear;
    dsOfacManagement.ReasonsRow byClearReasonId = this.dsOfac.Reasons.FindByClearReasonID(nullable.Value);
    int num = byClearReasonId != null ? (byClearReasonId.SoftClear ? 1 : 0) : 0;
    chkSoftClear.Checked = num != 0;
  }

  private void ucClearReason_AfterCloseUp(object sender, EventArgs e)
  {
    ((Control) this.ucClearReason).Dock = DockStyle.None;
  }

  private void btnClearOfacHit_Click(object sender, EventArgs e)
  {
    if (this.btnClearOfacHit.Tag == null)
      return;
    dsOfacManagement.OfacAdminRow currentRow = this.CurrentRow;
    if (Conversions.ToBoolean(this.btnClearOfacHit.Tag))
    {
      currentRow.OFACCleared = false;
      currentRow.SetClearByUserGuidNull();
      currentRow.SetClearDateNull();
      currentRow.SetClearReasonNull();
      this.btnClearOfacHit.Text = "Clear Hit";
    }
    else
    {
      DateTime? nullable = this.chkSoftClear.Checked ? (DateTime?) null : new DateTime?(DateTime.Now);
      currentRow.OFACCleared = nullable.HasValue;
      currentRow.ClearByUserGuid = CurrentUser.Instance.UserGUID;
      if (nullable.HasValue)
        currentRow.ClearDate = nullable.Value;
      currentRow.ClearReason = this.txtClearReason.Text;
      currentRow.Notes = this.txtNotes.Text;
      this.btnClearOfacHit.Text = "Reinstate Hit";
    }
    if (this.chkSoftClear.Checked)
      this.btnClearOfacHit.Tag = (object) currentRow.OFACCleared;
    this.clickedClearBtn = true;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.btnClearOfacHit.Tag == null)
      return;
    if (!this.clickedClearBtn)
      this.btnClearOfacHit.PerformClick();
    dsOfacManagement.OfacAdminRow currentRow = this.CurrentRow;
    if (Conversions.ToBoolean(this.btnClearOfacHit.Tag))
    {
      try
      {
        OfacSystem.Instance.ReinstateOfacHit(currentRow.EntityGUID, currentRow.NullableParentEntityGuid);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Unable to reinstate OFAC hit! {ex.GetType().Name}: {ex.Message}", "Reinstate Ofac Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        return;
      }
    }
    else
    {
      try
      {
        DateTime? clearDate = this.chkSoftClear.Checked ? (DateTime?) null : new DateTime?(DateTime.Now);
        OfacSystem.Instance.ClearOfacHit(currentRow.EntityGUID, currentRow.NullableParentEntityGuid, new Guid?(CurrentUser.Instance.UserGUID), clearDate, this.txtClearReason.Text, this.ucClearReason.Value != null ? (int?) this.ucClearReason.Value : new int?(), this.txtNotes.Text);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"Unable to clear OFAC hit! {exception.GetType().Name}: {exception.Message}", "Clear Ofac Hit Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
        return;
      }
    }
    currentRow.AcceptChanges();
    ((UltraGridBase) this.ugOfacHits).Refresh();
    this.UpdateFormControls(currentRow);
    this.ClientClearOFAC(currentRow);
  }

  protected virtual void ClientClearOFAC(dsOfacManagement.OfacAdminRow curRow)
  {
  }

  private void lnkEntityName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.CurrentRow == null)
      return;
    dsOfacManagement.OfacAdminRow currentRow = this.CurrentRow;
    try
    {
      Type typeFromString = ObjectFactory.Instance.CreateTypeFromString(currentRow.RecreateTypeName);
      if ((object) typeFromString == null)
        return;
      Form formEx;
      if (typeof (IRecreatableEntity).IsAssignableFrom(typeFromString))
      {
        formEx = ObjectFactory.Instance.CreateFormEX(typeFromString);
        Guid? parentEntityGuid;
        (formEx as IRecreatableEntity).RecreateEntityInitialize((parentEntityGuid = currentRow.NullableParentEntityGuid).HasValue ? parentEntityGuid.GetValueOrDefault() : currentRow.EntityGUID);
      }
      else
      {
        Guid? parentEntityGuid;
        formEx = ObjectFactory.Instance.CreateFormEX(typeFromString, (object) ((parentEntityGuid = currentRow.NullableParentEntityGuid).HasValue ? parentEntityGuid.GetValueOrDefault() : currentRow.EntityGUID));
      }
      formEx.MdiParent = MDIControls.Instance.MDIParent;
      formEx.Show();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      MGASystems.Common.ThreadingFunctions.MessageBox.Show($"Unable to display associated UI for {currentRow.EntityName} ({currentRow.RecreateTypeName}). Error: {exception.Message}", "Unable to Create Entity UI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      currentRow.SetRecreateTypeNameNull();
      currentRow.AcceptChanges();
      this.lnkEntityName.Enabled = false;
      ProjectData.ClearProjectError();
    }
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    throw new InvalidOperationException($"{nameof (frmAdminOfacManagement)} does not implement RecreateEntityInitialize and should not be requested to do so.");
  }

  public bool AllowAddNewDocument => true;

  string IRecreatableEntity.EntityName => this.CurrentRow?.EntityName;

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      Guid? parentEntityGuid;
      return ((parentEntityGuid = (Guid?) this.CurrentRow?.NullableParentEntityGuid).HasValue ? parentEntityGuid : this.CurrentRow?.EntityGUID) ?? Guid.Empty;
    }
  }

  string IRecreatableEntity.FriendlyEntityName => "Sanctions Dashboard";

  string IRecreatableEntity.RecreateTypeName => this.CurrentRow?.RecreateTypeName ?? string.Empty;

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.HasControlGUID
  {
    get
    {
      if (!"Quote".Equals(this.CurrentRow?.EntityType))
        return false;
      dsOfacManagement.OfacAdminRow currentRow = this.CurrentRow;
      return currentRow != null && currentRow.NullableParentEntityGuid.HasValue;
    }
  }

  Guid IRecreatableEntity.ControlGUID
  {
    get => !this.HasControlGUID ? Guid.Empty : this.CurrentRow.ParentEntityGUID;
  }

  private dsOfacManagement.OfacAdminRow CurrentRow
  {
    get
    {
      return this.bindingOfac.Position <= -1 ? (dsOfacManagement.OfacAdminRow) null : (this.bindingOfac?.Current is DataRowView current ? current.Row : (DataRow) null) as dsOfacManagement.OfacAdminRow;
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  private void lnkLoadHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.CurrentRow == null || this._historyCache.Contains((this.CurrentRow.EntityGUID, this.CurrentRow.NullableParentEntityGuid)))
      return;
    this._historyCache.Add((this.CurrentRow.EntityGUID, this.CurrentRow.NullableParentEntityGuid));
    this.lnkLoadHistory.Enabled = false;
    DefaultDatabase.LoadDataSet((DataSet) this.dsOfac, new string[2]
    {
      this.dsOfac.SearchLog.TableName,
      this.dsOfac.HitLog.TableName
    }, "dbo.OFAC_GetHistory", new object[4]
    {
      (object) "@entityGuid",
      (object) this.CurrentRow.EntityGUID,
      (object) "@parentEntity",
      (object) this.CurrentRow.NullableParentEntityGuid
    });
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (this.Equals((object) Form.ActiveForm))
      return;
    if (!eventGuid.ValueIn<Guid>(BroadcastMessages.EntityOfacSearch, BroadcastMessages.EntityOfacReset, BroadcastMessages.EntityOfacReinstated, BroadcastMessages.EntityOfacClear))
      return;
    Guid guid = eventGuid;
    Guid entityGuid;
    Guid? nullable;
    if (guid == BroadcastMessages.EntityOfacSearch)
    {
      if (!(context is OfacSystem.OfacResult ofacResult))
        return;
      entityGuid = ofacResult.SearchCriteria.EntityGuid;
      nullable = ofacResult.SearchCriteria.ParentGuid;
    }
    else if (guid == BroadcastMessages.EntityOfacReinstated || guid == BroadcastMessages.EntityOfacClear)
    {
      if (!(context is OfacClearContext ofacClearContext))
        return;
      entityGuid = ofacClearContext.EntityGuid;
      nullable = ofacClearContext.ParentEntityGuid;
    }
    else if (guid == BroadcastMessages.EntityOfacReset)
    {
      if (!(context is OfacResetContext ofacResetContext))
        return;
      entityGuid = ofacResetContext.EntityGuid;
      nullable = ofacResetContext.ParentEntityGuid;
    }
    if (entityGuid.Equals(Guid.Empty))
      return;
    this.BetterInvoke((Delegate) new Action<Guid, Guid?>(this.RefreshData), (object) entityGuid, (object) nullable);
  }
}
