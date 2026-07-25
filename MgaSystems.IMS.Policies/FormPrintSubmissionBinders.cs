// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormPrintSubmissionBinders
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.PDF;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Reporting.GenericReport;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormPrintSubmissionBinders : Form
{
  private IContainer components;
  private Guid _submissionGroupGuid;
  private List<string> _pdfs;
  private readonly Dictionary<Guid, Type> ReportCache;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtBindSubmissionQuotes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SelectedQuoteRow");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Premium");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("QuoteGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Company");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LineName");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RatingType");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("QuoteStatus");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.buttonPrint = new MGAButton();
    this.lnkSelect = new LinkLabel();
    this.lnkDeSelect = new LinkLabel();
    this.comboAutomationReports = new MGASimpleComboBox();
    this.ds = new dsPrintSubBinders();
    this.ugQuotes = new UltraGrid();
    this.DsBindingSource = new BindingSource(this.components);
    Label label = new Label();
    ((ISupportInitialize) this.buttonPrint).BeginInit();
    ((ISupportInitialize) this.comboAutomationReports).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugQuotes).BeginInit();
    ((ISupportInitialize) this.DsBindingSource).BeginInit();
    this.SuspendLayout();
    label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label.AutoSize = true;
    label.Location = new Point(9, 413);
    label.Name = "Label2";
    label.Size = new Size(111, 13);
    label.TabIndex = 9;
    label.Text = "Additional documents:";
    label.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.buttonPrint).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = (object) strings.Print;
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonPrint).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonPrint).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonPrint).Location = new Point(622, 442);
    ((Control) this.buttonPrint).Name = "buttonPrint";
    ((ControlBase) this.buttonPrint).Padding = new Size(7, 0);
    ((Control) this.buttonPrint).Size = new Size(134, 40);
    ((Control) this.buttonPrint).TabIndex = 3;
    ((ControlBase) this.buttonPrint).Text = "Print Binders";
    this.buttonPrint.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelect.AutoSize = true;
    this.lnkSelect.BackColor = Color.Transparent;
    this.lnkSelect.Location = new Point(9, 444);
    this.lnkSelect.Name = "lnkSelect";
    this.lnkSelect.Size = new Size(81, 13);
    this.lnkSelect.TabIndex = 5;
    this.lnkSelect.TabStop = true;
    this.lnkSelect.Text = "Select All Rows";
    this.lnkDeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelect.AutoSize = true;
    this.lnkDeSelect.BackColor = Color.Transparent;
    this.lnkDeSelect.Location = new Point(9, 475);
    this.lnkDeSelect.Name = "lnkDeSelect";
    this.lnkDeSelect.Size = new Size(98, 13);
    this.lnkDeSelect.TabIndex = 6;
    this.lnkDeSelect.TabStop = true;
    this.lnkDeSelect.Text = "De-Select All Rows";
    ((Control) this.comboAutomationReports).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraCombo) this.comboAutomationReports).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboAutomationReports).DataMember = "Reports";
    ((UltraGridBase) this.comboAutomationReports).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboAutomationReports).DisplayMember = "Title";
    ((UltraCombo) this.comboAutomationReports).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAutomationReports).Location = new Point(126, 409);
    this.comboAutomationReports.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboAutomationReports).Name = "comboAutomationReports";
    ((Control) this.comboAutomationReports).Size = new Size(327, 20);
    ((Control) this.comboAutomationReports).TabIndex = 8;
    ((UltraControlBase) this.comboAutomationReports).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAutomationReports).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboAutomationReports).ValueMember = "AutomationReportGuid";
    this.ds.DataSetName = "dsPrintSubBinders";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugQuotes).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugQuotes).DataMember = "dtBindSubmissionQuotes";
    ((UltraGridBase) this.ugQuotes).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.ugQuotes).DisplayLayout.AddNewBox).Prompt = " ";
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Selected";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 70;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 108;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    appearance3.ForeColor = Color.DarkGreen;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ultraGridColumn3.Width = 99;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 313;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 244;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Line of Business";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 139;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 81;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 88;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Quote Status";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 82;
    ultraGridBand.Columns.AddRange(new object[9]
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
    ((UltraGridBase) this.ugQuotes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugQuotes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.LightSteelBlue;
    appearance7.FontData.SizeInPoints = 10f;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.Transparent;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugQuotes).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugQuotes).Location = new Point(12, 12);
    ((Control) this.ugQuotes).Name = "ugQuotes";
    ((Control) this.ugQuotes).Size = new Size(744, 379);
    ((Control) this.ugQuotes).TabIndex = 7;
    ((Control) this.ugQuotes).Text = "Bound in this Submission Group";
    ((UltraControlBase) this.ugQuotes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugQuotes).UseOsThemes = (DefaultableBoolean) 2;
    this.DsBindingSource.DataSource = (object) this.ds;
    this.DsBindingSource.Position = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(768 /*0x0300*/, 494);
    this.Controls.Add((Control) label);
    this.Controls.Add((Control) this.comboAutomationReports);
    this.Controls.Add((Control) this.ugQuotes);
    this.Controls.Add((Control) this.lnkDeSelect);
    this.Controls.Add((Control) this.lnkSelect);
    this.Controls.Add((Control) this.buttonPrint);
    this.Name = nameof (FormPrintSubmissionBinders);
    this.Text = "Bound Accounts";
    ((ISupportInitialize) this.buttonPrint).EndInit();
    ((ISupportInitialize) this.comboAutomationReports).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugQuotes).EndInit();
    ((ISupportInitialize) this.DsBindingSource).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAButton buttonPrint
  {
    get => this._buttonPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonBind_Click);
      MGAButton buttonPrint1 = this._buttonPrint;
      if (buttonPrint1 != null)
        ((Control) buttonPrint1).Click -= eventHandler;
      this._buttonPrint = value;
      MGAButton buttonPrint2 = this._buttonPrint;
      if (buttonPrint2 == null)
        return;
      ((Control) buttonPrint2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkSelect
  {
    get => this._lnkSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelect_LinkClicked);
      LinkLabel lnkSelect1 = this._lnkSelect;
      if (lnkSelect1 != null)
        lnkSelect1.LinkClicked -= clickedEventHandler;
      this._lnkSelect = value;
      LinkLabel lnkSelect2 = this._lnkSelect;
      if (lnkSelect2 == null)
        return;
      lnkSelect2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelect
  {
    get => this._lnkDeSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelect_LinkClicked);
      LinkLabel lnkDeSelect1 = this._lnkDeSelect;
      if (lnkDeSelect1 != null)
        lnkDeSelect1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelect = value;
      LinkLabel lnkDeSelect2 = this._lnkDeSelect;
      if (lnkDeSelect2 == null)
        return;
      lnkDeSelect2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsBindingSource")]
  internal virtual BindingSource DsBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugQuotes")]
  protected virtual UltraGrid ugQuotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox comboAutomationReports
  {
    get => this._comboAutomationReports;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboAutomationReports_RowSelected);
      MGASimpleComboBox automationReports1 = this._comboAutomationReports;
      if (automationReports1 != null)
        ((UltraCombo) automationReports1).RowSelected -= selectedEventHandler;
      this._comboAutomationReports = value;
      MGASimpleComboBox automationReports2 = this._comboAutomationReports;
      if (automationReports2 == null)
        return;
      ((UltraCombo) automationReports2).RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsPrintSubBinders ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormPrintSubmissionBinders()
  {
    this.Load += new EventHandler(this.FormPrintSubmissionBinders_Load);
    this._pdfs = new List<string>();
    this.ReportCache = new Dictionary<Guid, Type>();
    this.InitializeComponent();
  }

  public FormPrintSubmissionBinders(Guid submissionGroupGuid)
  {
    this.Load += new EventHandler(this.FormPrintSubmissionBinders_Load);
    this._pdfs = new List<string>();
    this.ReportCache = new Dictionary<Guid, Type>();
    this.InitializeComponent();
    this._submissionGroupGuid = submissionGroupGuid;
  }

  private void FormPrintSubmissionBinders_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    try
    {
      this.LoadAutomationReports();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "dtBindSubmissionQuotes"
      }, this.ProcedureName, new object[2]
      {
        (object) "@submissionGroupGuid",
        (object) this._submissionGroupGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.SetGridSelectState(false);
    this.ugQuotes.UpdateMode = (UpdateMode) 4;
    this.OnFormLoad();
  }

  protected virtual string ProcedureName => "dbo.PrintSubmissionBinders";

  protected List<Guid> SelectedQuotes
  {
    get
    {
      dsPrintSubBinders.dtBindSubmissionQuotesDataTable submissionQuotes = this.ds.dtBindSubmissionQuotes;
      System.Func<dsPrintSubBinders.dtBindSubmissionQuotesRow, bool> predicate;
      if (FormPrintSubmissionBinders._Closure\u0024__.\u0024I39\u002D0 != null)
        predicate = FormPrintSubmissionBinders._Closure\u0024__.\u0024I39\u002D0;
      else
        FormPrintSubmissionBinders._Closure\u0024__.\u0024I39\u002D0 = predicate = (System.Func<dsPrintSubBinders.dtBindSubmissionQuotesRow, bool>) ([SpecialName] (t) => t.SelectedQuoteRow);
      EnumerableRowCollection<dsPrintSubBinders.dtBindSubmissionQuotesRow> source = submissionQuotes.Where<dsPrintSubBinders.dtBindSubmissionQuotesRow>(predicate);
      System.Func<dsPrintSubBinders.dtBindSubmissionQuotesRow, Guid> selector;
      if (FormPrintSubmissionBinders._Closure\u0024__.\u0024I39\u002D1 != null)
        selector = FormPrintSubmissionBinders._Closure\u0024__.\u0024I39\u002D1;
      else
        FormPrintSubmissionBinders._Closure\u0024__.\u0024I39\u002D1 = selector = (System.Func<dsPrintSubBinders.dtBindSubmissionQuotesRow, Guid>) ([SpecialName] (t) => t.QuoteGUID);
      return source.Select<dsPrintSubBinders.dtBindSubmissionQuotesRow, Guid>(selector).ToList<Guid>();
    }
  }

  public Guid CurrentSelectedReport
  {
    get
    {
      return Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.comboAutomationReports).Value)) ? Guid.Empty : (Guid) ((UltraCombo) this.comboAutomationReports).Value;
    }
  }

  protected virtual void OnFormLoad()
  {
    int num = this.DesignMode ? 1 : 0;
  }

  private void lnkSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelectState(true);
  }

  private void lnkDeSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelectState(false);
  }

  private void SetGridSelectState(bool booleanValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugQuotes).Rows)
      row.Cells["SelectedQuoteRow"].Value = (object) booleanValue;
  }

  private void buttonBind_Click(object sender, EventArgs e)
  {
    this.ugQuotes.PerformAction((UltraGridAction) 44);
    ((UltraGridBase) this.ugQuotes).UpdateData();
    this.BindButtonClick(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void BindButtonClick(object sender, EventArgs e)
  {
    Quote quote1 = (Quote) null;
    PdfFileEditor pdfFileEditor = new PdfFileEditor();
    string sourceFileName = string.Empty;
    Messaging.MessageEventArgs messageEventArgs = new Messaging.MessageEventArgs();
    List<Quote> quoteList = new List<Quote>();
    this._pdfs.Clear();
    try
    {
      foreach (Guid selectedQuote in this.SelectedQuotes)
      {
        try
        {
          quote1 = (Quote) Quote.CreateNew(selectedQuote);
          quoteList.Add(quote1);
          CompanyDocumentAutomation.BlackBoxMode = true;
          CompanyDocumentAutomation.SendToDocumentSystem = false;
          if (!this.SubmissionSummaryReport)
            this.AddAutomationReport(selectedQuote);
          messageEventArgs.Context = (object) selectedQuote;
          messageEventArgs.EventGuid = BroadcastMessages.ReprintBinder;
          using (CompanyDocumentAutomation documentAutomation = new CompanyDocumentAutomation(quote1.CompanyLineGuid.Value, messageEventArgs))
          {
            documentAutomation.QuoteGuid = selectedQuote;
            documentAutomation.CreatePDFPackage();
            sourceFileName = documentAutomation.ResultingDocument;
          }
          if (!string.IsNullOrEmpty(sourceFileName))
          {
            string destFileName = $"{MGATempFolder.MGATempRandomFolderPath}\\bind_{DateTime.Now:yyyyMMddHHmmssffff}{selectedQuote}.pdf";
            File.Copy(sourceFileName, destFileName);
            this._pdfs.Add(destFileName);
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          string caption = exception.ToString();
          if (quote1 != null)
            caption = $"Control #{quote1.ControlNo} - {caption}";
          if (!this.SubmissionSummaryReport || !exception.Message.Contains("No Documents Created") && !exception.Message.Contains("No Report") && !exception.Message.Contains("Unable to create PDF"))
          {
            int num = (int) MessageBox.Show($"An error has occurred during printing binders.\n\n{exception.Message} for Control #{quote1.ControlNo.ToString()}", caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          ProjectData.ClearProjectError();
        }
        finally
        {
          MDIControls.Instance.StatusBarText = string.Empty;
          Cursor.Current = MgaCursors.Default;
        }
      }
    }
    finally
    {
      List<Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (this.SubmissionSummaryReport && this.UsesLegacyForm)
      this.AddAutomationReport(quote1.QuoteGuid, true);
    this.AddPDFs(this._pdfs);
    if (this._pdfs.Count == 0)
      return;
    string str = $"{MGATempFolder.MGATempRandomFolderPath}\\bind2_{DateTime.Now:yyyyMMddHHmmssffff}{quote1.QuoteGuid}.pdf";
    if (File.Exists(str))
      File.Delete(str);
    pdfFileEditor.Concatenate(this._pdfs.ToArray(), str);
    string tmpDocumentName = "Policy - Multi-Binder";
    this.DocumentName(ref tmpDocumentName);
    try
    {
      foreach (Quote quote2 in quoteList)
      {
        messageEventArgs.Context = (object) quote2;
        int num = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT dbo.GetDocumentFolder(@CompanyLineGuid,@AutomationEventGuid,@QuoteGuid)", new object[6]
        {
          (object) "@CompanyLineGuid",
          (object) quote2.CompanyLineGuid,
          (object) "@AutomationEventGuid",
          (object) messageEventArgs.EventGuid,
          (object) "@QuoteGuid",
          (object) quote2.QuoteGuid
        }) ?? -1;
        DocumentManager.FileAddWithBind(str, num, tmpDocumentName, (ISupportDocumentSystem) quote2, true);
      }
    }
    finally
    {
      List<Quote>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.PostProcessPDF(str);
    Process.Start(str);
  }

  protected virtual bool SubmissionSummaryReport => this.MultiBinder() == 1;

  protected virtual bool UsesLegacyForm => true;

  [Obsolete("Use SubmissionSummaryReport instead. This should have been a boolean to begin with, and if set to 1 does not print the summary report at all (unless the client override specifically handles printing the automation report).")]
  protected virtual int MultiBinder() => 0;

  protected virtual void AddPDFs(List<string> pdfs)
  {
  }

  protected virtual void DocumentName(ref string tmpDocumentName)
  {
  }

  protected virtual string PostProcessPDF(string FileName) => FileName;

  private string MassageFileName(string tmpFilename)
  {
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    int index1 = 0;
    while (index1 < invalidFileNameChars.Length)
    {
      char ch = invalidFileNameChars[index1];
      tmpFilename = tmpFilename.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index1; }
    }
    char[] invalidPathChars = Path.GetInvalidPathChars();
    int index2 = 0;
    while (index2 < invalidPathChars.Length)
    {
      char ch = invalidPathChars[index2];
      tmpFilename = tmpFilename.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index2; }
    }
    tmpFilename = tmpFilename.Replace(";", string.Empty);
    return tmpFilename;
  }

  private void AddAutomationReport(Guid tmpQuoteGuid, bool useAllQuotes = false)
  {
    if (((UltraCombo) this.comboAutomationReports).Value == null)
      return;
    Guid automationReportGuid = (Guid) ((UltraCombo) this.comboAutomationReports).Value;
    object objectValue1 = RuntimeHelpers.GetObjectValue(useAllQuotes ? (object) this.SelectedQuotes : (object) tmpQuoteGuid);
    Type reportType = this.GetReportType(automationReportGuid);
    object objectValue2;
    try
    {
      objectValue2 = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(reportType, new object[1]
      {
        objectValue1
      }));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      exception.Data.Add((object) "UI", (object) this.GetType().FullName);
      exception.Data.Add((object) "Type", (object) reportType.FullName);
      exception.Data.Add((object) "AutomationReportGUID", (object) automationReportGuid);
      ErrorHandler.SilentHandleError(exception);
      objectValue2 = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(reportType, new object[1]
      {
        (object) tmpQuoteGuid
      }));
      ProjectData.ClearProjectError();
    }
    string path = $"{MGATempFolder.CreateTempSubdirectory()}{RuntimeHelpers.GetObjectValue(((UltraCombo) this.comboAutomationReports).Value)}.pdf";
    SectionReport sectionReport = (SectionReport) null;
    if (objectValue2 is SectionReport)
    {
      sectionReport = objectValue2 as SectionReport;
      sectionReport.Run();
    }
    else if (objectValue2 is IGenericReport)
    {
      RunCompletedResult runCompletedResult = (objectValue2 as IGenericReport).Run(RuntimeHelpers.GetObjectValue(objectValue1));
      if (runCompletedResult.ResultType == 1)
      {
        sectionReport = runCompletedResult.Result as SectionReport;
      }
      else
      {
        File.WriteAllBytes(path, runCompletedResult.Result as byte[]);
        this._pdfs.Insert(0, path);
      }
    }
    if (sectionReport == null)
      return;
    using (PdfExport pdfExport = new PdfExport())
    {
      pdfExport.Export(sectionReport.Document, path);
      this._pdfs.Insert(0, path);
    }
  }

  private Type GetReportType(Guid automationReportGuid)
  {
    Type type1 = (Type) null;
    Type reportType;
    if (this.ReportCache.TryGetValue(automationReportGuid, out type1) && (object) type1 != null)
    {
      reportType = type1;
    }
    else
    {
      Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new MultiQuoteReportAttribute());
      int index1 = 0;
      while (index1 < typeArray.Length)
      {
        Type type2 = typeArray[index1];
        object[] customAttributes = type2.GetCustomAttributes(false);
        int index2 = 0;
        while (index2 < customAttributes.Length)
        {
          if (RuntimeHelpers.GetObjectValue(customAttributes[index2]) is MultiQuoteReportAttribute objectValue && ((AutomationReportAttribute) objectValue).AutomationReportGuid == automationReportGuid)
          {
            reportType = type2;
            goto label_11;
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      reportType = (Type) null;
    }
label_11:
    return reportType;
  }

  protected virtual bool CheckAutomationReport(string reportName) => true;

  private void LoadAutomationReports()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new MultiQuoteReportAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      Type type = typeArray[index1];
      object[] customAttributes = type.GetCustomAttributes(false);
      int index2 = 0;
      while (index2 < customAttributes.Length)
      {
        if (RuntimeHelpers.GetObjectValue(customAttributes[index2]) is MultiQuoteReportAttribute objectValue && this.CheckAutomationReport(((AutomationReportAttribute) objectValue).Title))
        {
          this.ds.Reports.AddReportsRow(((AutomationReportAttribute) objectValue).AutomationReportGuid, ((AutomationReportAttribute) objectValue).Title, ((AutomationReportAttribute) objectValue).Description);
          this.ReportCache[((AutomationReportAttribute) objectValue).AutomationReportGuid] = type;
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
  }

  private bool PreBindVerificationRaters(Quote tmpQuote)
  {
    bool flag;
    try
    {
      foreach (QuoteDetail quoteDetail in tmpQuote.QuoteDetails)
      {
        using (IRater rater = RaterFactory.GetRater(quoteDetail.RaterID ?? -1))
        {
          if (!tmpQuote.IsMultiCompanyPolicy)
          {
            if (!quoteDetail.IsRaterAssigned())
            {
              int num = (int) MessageBox.Show($"Control # {tmpQuote.ControlNo}. The system could not determine the rater used on this policy.", "Cannot Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              goto label_17;
            }
            if (rater == null)
            {
              CompanyLine companyLine = quoteDetail.CompanyLine;
              int num = (int) MessageBox.Show($"Control # {tmpQuote.ControlNo}. A rater was was not found for {companyLine.CompanyLineState}.", "Cannot Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              goto label_17;
            }
          }
          if (rater != null)
          {
            rater.InitializeState(tmpQuote.QuoteGuid, quoteDetail.CompanyLineGuid);
            List<string> readyToBindReason = rater.NotReadyToBindReason;
            if (!rater.IsReadyForBind)
            {
              if (readyToBindReason.Count > 0)
              {
                string str = string.Join("\n", (IEnumerable<string>) readyToBindReason);
                int num = (int) MessageBox.Show($"Control # {tmpQuote.ControlNo}. Cannnot bind for the following reason(s): {"\n"}{str}.", "Cannot Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
                goto label_17;
              }
            }
          }
        }
      }
    }
    finally
    {
      List<QuoteDetail>.Enumerator enumerator;
      enumerator.Dispose();
    }
    flag = true;
label_17:
    return flag;
  }

  private void comboAutomationReports_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.AutomationReportSelected((e.Row?.ListObject is DataRowView listObject ? listObject.Row : (DataRow) null) as dsPrintSubBinders.ReportsRow);
  }

  protected virtual void AutomationReportSelected(dsPrintSubBinders.ReportsRow report)
  {
  }
}
