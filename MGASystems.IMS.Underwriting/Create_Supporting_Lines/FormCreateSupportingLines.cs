// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Create_Supporting_Lines.FormCreateSupportingLines
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Create_Supporting_Lines;

public class FormCreateSupportingLines : Form
{
  private Guid _QuoteGuid;
  private Quote _Quote;
  private string _stateID = string.Empty;
  private int _newStatus;
  private Guid _CompanyLocationGuid;
  private Guid _lineGuid;
  private object _templateID;
  private List<Guid> _newlyCreatedQuoteGuids = new List<Guid>();
  protected string spCreateSupportingLines = nameof (spCreateSupportingLines);
  private IContainer components;
  private dsSupportingLines ds;
  private MGAButton btnCreate;
  private LinkLabel lnkSelectAll;
  protected UltraGrid ugLines;
  private LinkLabel lnkDeSelectAll;

  public Guid OldQuoteGuid => this._QuoteGuid;

  public Guid OldCompanyLocationGuid => this._CompanyLocationGuid;

  public string OldStateID => this._stateID;

  public Guid OldLineGuid => this._lineGuid;

  public Quote OldQuote => this._Quote;

  public object TemplateID
  {
    get => this._templateID;
    set => this._templateID = value;
  }

  public FormCreateSupportingLines(Guid QuoteGuid, int newStatus)
  {
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
    this._Quote = Quote.CreateNew(QuoteGuid);
    this._stateID = this._Quote.StateID;
    if (this._Quote.HasValidCompanyLineGuid)
      this._CompanyLocationGuid = this._Quote.CompanyLocationGuid;
    this._lineGuid = this._Quote.LineGuid;
    this._newStatus = newStatus;
  }

  protected virtual object GetTemplateID() => (object) null;

  private void FormCreateSupportingLines_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnCreate).Appearance.Image = (object) ImageCache.Instance.Save;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstLines"
    }, this.spCreateSupportingLines, new object[2]
    {
      (object) "@QuoteGUID",
      (object) this._QuoteGuid
    });
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLines).Rows)
      row.Cells["SelectLine"].Value = (object) true;
  }

  private void btnSubmit_Click(object sender, EventArgs e)
  {
    this._newlyCreatedQuoteGuids.Clear();
    foreach (Guid newQuoteGuid in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.ugLines).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => row.Cells["SelectLine"].Value != DBNull.Value && (bool) row.Cells["SelectLine"].Value)).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => !row.Cells["LineGuid"].Value.ToString().Equals(this.OldLineGuid.ToString()))).Select<UltraGridRow, Guid>((System.Func<UltraGridRow, Guid>) (row => this.CreateSupportingQuote((Guid) row.Cells["LineGuid"].Value))))
    {
      this.OnNewQuoteCreation(this._QuoteGuid, newQuoteGuid);
      this._newlyCreatedQuoteGuids.Add(newQuoteGuid);
    }
    foreach (Guid createdQuoteGuid in this._newlyCreatedQuoteGuids)
    {
      Quote docSupport = new Quote(createdQuoteGuid);
      foreach (Guid documentGuid in DocumentManager.GetDocumentsAssociatedToEntity(this.OldQuote.ControlGuid))
        DocumentManager.BindDocument(documentGuid, (ISupportDocumentSystem) docSupport);
      object[] objArray = new object[4]
      {
        (object) "@DocumentStoreGuid",
        null,
        (object) "@ControlGuid",
        (object) this.OldQuote.ControlGuid
      };
      foreach (Guid documentGuid in DefaultDatabase.ExecuteDataTable("dbo.GetEntityAssociatedDocuments", objArray).Rows.OfType<DataRow>().Select<DataRow, Guid>((System.Func<DataRow, Guid>) (row => new Guid(row[0].ToString()))).ToList<Guid>())
        DocumentManager.BindDocument(documentGuid, (ISupportDocumentSystem) docSupport);
      if (this.OldQuote.HasControlGUID)
        Note_System.Instance.NonInteractive.DuplicateNotesByControlGuid(this.OldQuote.ControlGuid, docSupport.ControlGuid);
    }
    this.OnSupportingQuotesCreated(this._QuoteGuid);
    this.Close();
  }

  protected virtual void OnSupportingQuotesCreated(Guid originalQuoteGuid)
  {
  }

  protected virtual void OnNewQuoteCreation(Guid originalQuoteGuid, Guid newQuoteGuid)
  {
  }

  protected virtual Guid CreateSupportingQuote(Guid lineGuid)
  {
    return this.CreateSupportingQuote(lineGuid, string.Empty);
  }

  protected virtual Guid CreateSupportingQuote(Guid lineGuid, string templateFileName)
  {
    CompanyLine companyLine = new CompanyLine(this.OldCompanyLocationGuid, lineGuid, this.OldStateID);
    Guid quoteGuid = this.OldQuote.Copy();
    Guid producerLocationGuid = Quote.CreateNew(quoteGuid).ProducerLocationGuid;
    ProducerLocation producerLocation = new ProducerLocation(producerLocationGuid);
    bool isRenewal = this.OldQuote.IsRenewal;
    Guid companyLineGuid = companyLine.CompanyLineGuid;
    int num = isRenewal ? 1 : 0;
    DateTime effectiveDate = this.OldQuote.EffectiveDate;
    // ISSUE: variable of a boxed type
    __Boxed<int> policyTypeId = (System.ValueType) this.OldQuote.PolicyTypeID;
    Guid quotingLocationGuid = this.OldQuote.QuotingLocationGuid;
    Decimal commission1 = producerLocation.GetCommission(companyLineGuid, num != 0, effectiveDate, (SqlTransaction) null, (object) policyTypeId, (object) null, quotingLocationGuid);
    Decimal commission2 = companyLine.GetCommission(isRenewal, producerLocationGuid, commission1, this.OldQuote.EffectiveDate, this.OldQuote.PolicyTypeID, (SqlTransaction) null, Guid.Empty, (object) null, this.OldQuote.QuotingLocationGuid);
    DefaultDatabase.ExecuteNonQuery("spConfigureSupportingLinesQuotes", new object[16 /*0x10*/]
    {
      (object) "@NewQuoteGuid",
      (object) quoteGuid,
      (object) "@OldQuoteGuid",
      (object) this.OldQuoteGuid,
      (object) "@NewLineGuid",
      (object) lineGuid,
      (object) "@OldCompanyLineGUID",
      (object) this.OldQuote.CompanyLineGuid,
      (object) "@NewCompanyLineGUID",
      (object) companyLine.CompanyLineGuid,
      (object) "@CompanyCommission",
      (object) commission2,
      (object) "@ProducerCommission",
      (object) commission1,
      (object) "@IsParentLine",
      (object) this.OldQuote.CompanyLine.IsParentLine
    });
    this.Tag = (object) $"{this.Tag?.ToString()}/{quoteGuid.ToString()}";
    if (!string.IsNullOrEmpty(templateFileName))
    {
      string mergeDocument = new DocumentHandling((int) this.TemplateID).CreateMergeDocument(templateFileName, (object) this.OldLineGuid);
      string empty = string.Empty;
      FormCreateSupportingLines.SendToDocSystem(quoteGuid, mergeDocument);
    }
    return quoteGuid;
  }

  private static string SendToDocSystem(Guid quoteGuid, string fileName)
  {
    Quote docSupport = new Quote(quoteGuid);
    string docSystem = $"{fileName.Replace(Path.GetFileName(fileName), string.Empty)}SupportingLine{docSupport.ControlNo}.doc";
    File.Copy(fileName, docSystem, true);
    DocumentManager.FileAddWithBind(docSystem, -1, "SupportingLine_" + docSupport.LineName, (ISupportDocumentSystem) docSupport, false);
    return docSystem;
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLines).Rows)
      row.Cells["SelectLine"].Value = (object) false;
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
    UltraGridBand ultraGridBand = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SelectLine");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLine");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    this.ugLines = new UltraGrid();
    this.ds = new dsSupportingLines();
    this.btnCreate = new MGAButton();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    ((ISupportInitialize) this.ugLines).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnCreate).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugLines).DataMember = "lstLines";
    ((UltraGridBase) this.ugLines).DataSource = (object) this.ds;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLines).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 294;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line Name";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 523;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 46;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 165;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 132;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ugLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.ugLines).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((AppearanceBase) appearance4).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.ugLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLines).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugLines).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugLines).Location = new Point(12, 25);
    ((Control) this.ugLines).Name = "ugLines";
    ((Control) this.ugLines).Size = new Size(571, 388);
    ((Control) this.ugLines).TabIndex = 29;
    ((Control) this.ugLines).Text = "Available Lines";
    ((UltraControlBase) this.ugLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLines).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsSupportingLines";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnCreate).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance9).ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnCreate).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnCreate).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnCreate).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCreate).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCreate).Location = new Point(543, 440);
    ((Control) this.btnCreate).Name = "btnCreate";
    ((ControlBase) this.btnCreate).Padding = new Size(5, 0);
    ((Control) this.btnCreate).Size = new Size(40, 40);
    ((Control) this.btnCreate).TabIndex = 210;
    ((UltraControlBase) this.btnCreate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCreate).Click += new EventHandler(this.btnSubmit_Click);
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.Location = new Point(9, 431);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(63 /*0x3F*/, 18);
    this.lnkSelectAll.TabIndex = 215;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkSelectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.Location = new Point(9, 465);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(81, 18);
    this.lnkDeSelectAll.TabIndex = 216;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.lnkDeSelectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(595, 492);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.btnCreate);
    this.Controls.Add((Control) this.ugLines);
    this.Name = nameof (FormCreateSupportingLines);
    this.Text = "Create Supporting Lines";
    this.Load += new EventHandler(this.FormCreateSupportingLines_Load);
    ((ISupportInitialize) this.ugLines).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnCreate).EndInit();
    this.ResumeLayout(false);
  }
}
