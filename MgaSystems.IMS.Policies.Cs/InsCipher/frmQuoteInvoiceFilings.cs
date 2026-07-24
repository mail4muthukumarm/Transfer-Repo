// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.InsCipher.frmQuoteInvoiceFilings
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Policies.InsCipher;

public class frmQuoteInvoiceFilings : FormBase
{
  private IContainer components;
  protected internal UltraGrid dgFilings;
  private dsQuoteFilings ds;

  public frmQuoteInvoiceFilings() => this.InitializeComponent();

  public frmQuoteInvoiceFilings(Quote quote)
    : this(quote.ControlNo)
  {
  }

  public frmQuoteInvoiceFilings(int controlNo)
    : this()
  {
    this.ControlNo = controlNo;
  }

  private int ControlNo { get; }

  private void frmQuoteFilings_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataTable((DataTable) this.ds.InvoiceFiling, "dbo.InsCipher_GetQuoteInvoiceFilings", new object[2]
    {
      (object) "@controlNo",
      (object) this.ControlNo
    });
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("InvoiceFiling", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FilingDate");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("BatchID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TransactionID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("FilingStatus");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("InvoiceDate");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.dgFilings = new UltraGrid();
    this.ds = new dsQuoteFilings();
    ((ISupportInitialize) this.dgFilings).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.dgFilings).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgFilings).DataMember = "InvoiceFiling";
    ((UltraGridBase) this.dgFilings).DataSource = (object) this.ds;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgFilings).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgFilings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.MaxWidth = 75;
    ultraGridColumn1.MinWidth = 75;
    ultraGridColumn1.Width = 75;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.MaxWidth = 75;
    ultraGridColumn2.MinWidth = 75;
    ultraGridColumn2.Width = 75;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.MaxWidth = 75;
    ultraGridColumn3.MinWidth = 75;
    ultraGridColumn3.Width = 75;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Batch";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.MinWidth = 150;
    ultraGridColumn4.NullText = "N/A";
    ultraGridColumn4.Width = 150;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.MinWidth = 150;
    ultraGridColumn5.NullText = "N/A";
    ultraGridColumn5.Width = 150;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Width = 242;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 2;
    ultraGridColumn7.MaxWidth = 75;
    ultraGridColumn7.MinWidth = 75;
    ultraGridColumn7.Width = 75;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgFilings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgFilings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgFilings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgFilings).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgFilings).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgFilings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgFilings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgFilings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgFilings).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgFilings).Location = new Point(12, 12);
    ((Control) this.dgFilings).Name = "dgFilings";
    ((Control) this.dgFilings).Size = new Size(769, 328);
    ((Control) this.dgFilings).TabIndex = 10;
    ((UltraControlBase) this.dgFilings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgFilings).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsQuoteFilings";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ClientSize = new Size(793, 352);
    this.Controls.Add((Control) this.dgFilings);
    this.Name = nameof (frmQuoteInvoiceFilings);
    this.Text = "InsCipher Invoice Filings";
    this.Load += new EventHandler(this.frmQuoteFilings_Load);
    ((ISupportInitialize) this.dgFilings).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }
}
