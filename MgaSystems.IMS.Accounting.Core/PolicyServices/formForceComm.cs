// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.PolicyServices.formForceComm
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.PolicyServices;

public class formForceComm : Form
{
  private IContainer components;
  protected UltraGrid gridInvoiceListing;

  public formForceComm() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("PolicyInvoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("invoiceNum");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("officeInvoiceNum");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("quoteId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GrossBilled");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Commission");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Premium");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Fees");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("APBalance");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ARBalance");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("underNotice");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    this.gridInvoiceListing = new UltraGrid();
    ((ISupportInitialize) this.gridInvoiceListing).BeginInit();
    this.SuspendLayout();
    ((Control) this.gridInvoiceListing).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.gridInvoiceListing).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridInvoiceListing).DataMember = "PolicyInvoices";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 65;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 122;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 55;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn4.Format = "c";
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 5;
    ultraGridColumn4.Width = 96 /*0x60*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn5.Format = "c";
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Net. Commission";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 6;
    ultraGridColumn5.Width = 97;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn6.Format = "c";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 3;
    ultraGridColumn6.Width = 93;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn7.Format = "c";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.Width = 89;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn8.Format = "c";
    ((HeaderBase) ultraGridColumn8.Header).Caption = "AP Balance";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Width = 92;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn9.Format = "c";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "AR Balance";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.Width = 92;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 102;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 78;
    ultraGridBand.Columns.AddRange(new object[11]
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
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.Transparent;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance16).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridInvoiceListing).Location = new Point(118, 12);
    ((Control) this.gridInvoiceListing).Name = "gridInvoiceListing";
    ((Control) this.gridInvoiceListing).Size = new Size(683, 166);
    ((Control) this.gridInvoiceListing).TabIndex = 20;
    ((UltraControlBase) this.gridInvoiceListing).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInvoiceListing).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(813, 455);
    this.Controls.Add((Control) this.gridInvoiceListing);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (formForceComm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Force Commission Recognition";
    ((ISupportInitialize) this.gridInvoiceListing).EndInit();
    this.ResumeLayout(false);
  }
}
