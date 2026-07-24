// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.TransactionModification.FormModifyInvoice
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.TransactionModification;

public class FormModifyInvoice : FormBase
{
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private Panel FormModifyInvoice_Fill_Panel;
  private UltraToolbarsDockArea _FormModifyInvoice_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormModifyInvoice_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormModifyInvoice_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormModifyInvoice_Toolbars_Dock_Area_Bottom;
  private UltraGrid gridReplacementInvoice;
  private Splitter splitter1;
  private UltraGrid gridModifyInvoice;
  private dsModifyInvoice dsModifyInvoice1;

  public FormModifyInvoice(dsModifyInvoice ds)
  {
    this.InitializeComponent();
    this.dsModifyInvoice1 = ds;
    ((UltraGridBase) this.gridModifyInvoice).DataSource = (object) this.dsModifyInvoice1;
    ((UltraGridBase) this.gridReplacementInvoice).DataSource = (object) this.dsModifyInvoice1;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        break;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ReplacementInvoice", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InvoiceNum");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Invoice Number");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineName");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Description");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ChargeCode");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EntityName");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AmtRem");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("InvoiceToEdit", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PostingNum");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("InvoiceNum");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Invoice Number");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LineName");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Description");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ChargeCode");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyLineGuid");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("GL Account");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Amount");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("GLAcctId");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SAVE");
    Appearance appearance52 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormModifyInvoice));
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance53 = new Appearance();
    this.FormModifyInvoice_Fill_Panel = new Panel();
    this.gridReplacementInvoice = new UltraGrid();
    this.splitter1 = new Splitter();
    this.gridModifyInvoice = new UltraGrid();
    this._FormModifyInvoice_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormModifyInvoice_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormModifyInvoice_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormModifyInvoice_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dsModifyInvoice1 = new dsModifyInvoice();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormModifyInvoice_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.gridReplacementInvoice).BeginInit();
    ((ISupportInitialize) this.gridModifyInvoice).BeginInit();
    this.dsModifyInvoice1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.FormModifyInvoice_Fill_Panel.BackColor = Color.Transparent;
    this.FormModifyInvoice_Fill_Panel.Controls.Add((Control) this.gridReplacementInvoice);
    this.FormModifyInvoice_Fill_Panel.Controls.Add((Control) this.splitter1);
    this.FormModifyInvoice_Fill_Panel.Controls.Add((Control) this.gridModifyInvoice);
    this.FormModifyInvoice_Fill_Panel.Cursor = Cursors.Default;
    this.FormModifyInvoice_Fill_Panel.Dock = DockStyle.Fill;
    this.FormModifyInvoice_Fill_Panel.Location = new Point(0, 53);
    this.FormModifyInvoice_Fill_Panel.Name = "FormModifyInvoice_Fill_Panel";
    this.FormModifyInvoice_Fill_Panel.Size = new Size(883, 427);
    this.FormModifyInvoice_Fill_Panel.TabIndex = 0;
    ((UltraGridBase) this.gridReplacementInvoice).DataMember = "ReplacementInvoice";
    ((UltraGridBase) this.gridReplacementInvoice).DataSource = (object) this.dsModifyInvoice1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 86;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 139;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "LOB";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 196;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 192 /*0xC0*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 60;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 185;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 293;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Entity Name";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Width = 221;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Amt. Remaining";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.Width = 133;
    ultraGridBand1.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridReplacementInvoice).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridReplacementInvoice).Dock = DockStyle.Fill;
    ((Control) this.gridReplacementInvoice).Location = new Point(0, 181);
    ((Control) this.gridReplacementInvoice).Name = "gridReplacementInvoice";
    ((Control) this.gridReplacementInvoice).Size = new Size(883, 246);
    ((Control) this.gridReplacementInvoice).TabIndex = 10;
    ((UltraControlBase) this.gridReplacementInvoice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridReplacementInvoice).UseOsThemes = (DefaultableBoolean) 2;
    this.splitter1.BackColor = Color.SteelBlue;
    this.splitter1.Dock = DockStyle.Top;
    this.splitter1.Location = new Point(0, 178);
    this.splitter1.Name = "splitter1";
    this.splitter1.Size = new Size(883, 3);
    this.splitter1.TabIndex = 9;
    this.splitter1.TabStop = false;
    ((UltraGridBase) this.gridModifyInvoice).DataMember = "InvoiceToEdit";
    ((UltraGridBase) this.gridModifyInvoice).DataSource = (object) this.dsModifyInvoice1;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Appearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 61;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 86;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 143;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Left";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "LOB";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 4;
    ultraGridColumn13.Width = 164;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Left";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 5;
    ultraGridColumn14.Width = 258;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 6;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 78;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance37;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 7;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 238;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance38;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 3;
    ultraGridColumn17.Width = 198;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance40;
    ultraGridColumn18.Format = "c";
    ((AppearanceBase) appearance41).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 8;
    ultraGridColumn18.Width = 118;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Left";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 9;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 58;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance45).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance47).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance49).BackColor = Color.Transparent;
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance50).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.gridModifyInvoice).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridModifyInvoice).Dock = DockStyle.Top;
    ((Control) this.gridModifyInvoice).Location = new Point(0, 0);
    ((Control) this.gridModifyInvoice).Name = "gridModifyInvoice";
    ((Control) this.gridModifyInvoice).Size = new Size(883, 178);
    ((Control) this.gridModifyInvoice).TabIndex = 8;
    ((UltraControlBase) this.gridModifyInvoice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridModifyInvoice).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyInvoice_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left).Location = new Point(0, 53);
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left).Name = "_FormModifyInvoice_Toolbars_Dock_Area_Left";
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left).Size = new Size(0, 427);
    this._FormModifyInvoice_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyInvoice_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right).Location = new Point(883, 53);
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right).Name = "_FormModifyInvoice_Toolbars_Dock_Area_Right";
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right).Size = new Size(0, 427);
    this._FormModifyInvoice_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyInvoice_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top).Name = "_FormModifyInvoice_Toolbars_Dock_Area_Top";
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top).Size = new Size(883, 53);
    this._FormModifyInvoice_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyInvoice_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom).Location = new Point(0, 480);
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom).Name = "_FormModifyInvoice_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom).Size = new Size(883, 0);
    this._FormModifyInvoice_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.dsModifyInvoice1.DataSetName = "dsModifyInvoice";
    this.dsModifyInvoice1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance52).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance52;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance53).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance53;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(883, 480);
    this.Controls.Add((Control) this.FormModifyInvoice_Fill_Panel);
    this.Controls.Add((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._FormModifyInvoice_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormModifyInvoice);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Invoice Modification";
    this.FormModifyInvoice_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.gridReplacementInvoice).EndInit();
    ((ISupportInitialize) this.gridModifyInvoice).EndInit();
    this.dsModifyInvoice1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
