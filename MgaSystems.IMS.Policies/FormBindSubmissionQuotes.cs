// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormBindSubmissionQuotes
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
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class FormBindSubmissionQuotes : Form
{
  private IContainer components;
  private Guid _submissionGroupGuid;
  private List<string> _pdfs;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormBindSubmissionQuotes));
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
    this.buttonBind = new MGAButton();
    this.lnkSelect = new LinkLabel();
    this.lnkDeSelect = new LinkLabel();
    this.comboAutomationReports = new MGASimpleComboBox();
    this.ds = new dsBindSubQuotes();
    this.ugQuotes = new UltraGrid();
    this.DsBindingSource = new BindingSource(this.components);
    Label label = new Label();
    ((ISupportInitialize) this.buttonBind).BeginInit();
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
    ((Control) this.buttonBind).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonBind).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonBind).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonBind).Location = new Point(622, 442);
    ((Control) this.buttonBind).Name = "buttonBind";
    ((ControlBase) this.buttonBind).Padding = new Size(7, 0);
    ((Control) this.buttonBind).Size = new Size(134, 40);
    ((Control) this.buttonBind).TabIndex = 3;
    ((ControlBase) this.buttonBind).Text = "Bind Quotes";
    this.buttonBind.UseOSThemes = (DefaultableBoolean) 2;
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
    this.ds.DataSetName = "dsBindSubQuotes";
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
    ultraGridColumn1.Width = 73;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 105;
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
    ((Control) this.ugQuotes).Text = "Quotes in this Submission Group";
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
    this.Controls.Add((Control) this.buttonBind);
    this.Name = nameof (FormBindSubmissionQuotes);
    this.Text = "Bind Submission Quotes";
    ((ISupportInitialize) this.buttonBind).EndInit();
    ((ISupportInitialize) this.comboAutomationReports).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugQuotes).EndInit();
    ((ISupportInitialize) this.DsBindingSource).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAButton buttonBind
  {
    get => this._buttonBind;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonBind_Click);
      MGAButton buttonBind1 = this._buttonBind;
      if (buttonBind1 != null)
        ((Control) buttonBind1).Click -= eventHandler;
      this._buttonBind = value;
      MGAButton buttonBind2 = this._buttonBind;
      if (buttonBind2 == null)
        return;
      ((Control) buttonBind2).Click += eventHandler;
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

  [field: AccessedThroughProperty("comboAutomationReports")]
  protected virtual MGASimpleComboBox comboAutomationReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsBindSubQuotes ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual string ProcedureName => "dbo.BindSubmissionQuotes";

  protected List<Guid> SelectedQuotes
  {
    get
    {
      List<Guid> selectedQuotes = new List<Guid>();
      foreach (UltraGridRow row in ((UltraGridBase) this.ugQuotes).Rows)
      {
        if ((bool) row.Cells["SelectedQuoteRow"].Value)
        {
          Guid guid = (Guid) row.Cells["QuoteGuid"].Value;
          selectedQuotes.Add(guid);
        }
      }
      return selectedQuotes;
    }
  }

  public FormBindSubmissionQuotes()
  {
    this.Load += new EventHandler(this.FormBindSubmissionQuotes_Load);
    this._pdfs = new List<string>();
    this.InitializeComponent();
  }

  public FormBindSubmissionQuotes(Guid submissionGroupGuid)
  {
    this.Load += new EventHandler(this.FormBindSubmissionQuotes_Load);
    this._pdfs = new List<string>();
    this.InitializeComponent();
    this._submissionGroupGuid = submissionGroupGuid;
  }

  private void FormBindSubmissionQuotes_Load(object sender, EventArgs e)
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
      row.Cells["SelectedQuoteRow"].SetValue((object) booleanValue, false);
    this.ugQuotes.PerformAction((UltraGridAction) 44);
    ((UltraControlBase) this.ugQuotes).Update();
  }

  protected virtual void QuoteOptionsRowProcessForBind(DataRow row)
  {
    Quote quote = (Quote) null;
    PdfFileEditor pdfMerge = new PdfFileEditor();
    if (row["SelectedQuoteRow"] == DBNull.Value)
      return;
    if (!Conversions.ToBoolean(row["SelectedQuoteRow"]))
      return;
    try
    {
      Guid quoteGuid = (Guid) row["QuoteGUID"];
      quote = Quote.FromQuoteGuid(quoteGuid);
      if (!this.PreBindVerificationRaters(quote))
        return;
      MDIControls.Instance.StatusBarText = "Binding Control # " + quote.ControlNo.ToString();
      quote.Bind(Conversions.ToInteger(row["QuoteOptionID"]));
      MDIControls.Instance.StatusBarText = "Generating Automation Reports";
      this.GenerateAutomationDocuments(quote, pdfMerge);
      try
      {
        foreach (frmClearance frmClearance in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmClearance>())
        {
          if (frmClearance != null)
          {
            frmClearance.UpdateQuoteStatus(quoteGuid);
            break;
          }
        }
      }
      finally
      {
        IEnumerator<frmClearance> enumerator;
        enumerator?.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      string caption = "Error on Bind";
      if (quote != null)
        caption = $"Control #{quote.ControlNo.ToString()} - {caption}";
      int num = (int) MessageBox.Show("An error has occurred during the binding process.\n\n" + exception.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    finally
    {
      CompanyDocumentAutomation.BlackBoxMode = false;
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual Guid GenerateAutomationDocuments(Quote quote, PdfFileEditor pdfMerge)
  {
    try
    {
      CompanyDocumentAutomation.BlackBoxMode = true;
      Guid quoteGuid = quote.QuoteGuid;
      this.AddAutomationReport(quoteGuid);
      Messaging.MessageEventArgs messageEventArgs = new Messaging.MessageEventArgs();
      messageEventArgs.Context = (object) quoteGuid;
      messageEventArgs.EventGuid = quote.PolicyType == 2 ? BroadcastMessages.RenewalBound : BroadcastMessages.PolicyBound;
      string path1 = string.Empty;
      using (CompanyDocumentAutomation documentAutomation = new CompanyDocumentAutomation(quote.CompanyLineGuid.Value, messageEventArgs))
      {
        documentAutomation.QuoteGuid = quoteGuid;
        documentAutomation.CreatePDFPackage();
        path1 = documentAutomation.ResultingDocument;
      }
      string str = this.MassageFileName(Path.GetFileNameWithoutExtension(path1) + quoteGuid.ToString() + Path.GetExtension(path1));
      string path2 = $"{Path.GetDirectoryName(path1)}\\{str}";
      if (File.Exists(path2))
        File.Delete(path2);
      this._pdfs.Add(path1);
      pdfMerge.Concatenate(this._pdfs.ToArray(), path2);
      int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.GetDocumentFolder(@CompanyLineGuid,@AutomationEventGuid,@QuoteGuid)", new object[7]
      {
        (object) -1,
        (object) "@CompanyLineGuid",
        (object) quote.CompanyLineGuid,
        (object) "@AutomationEventGuid",
        (object) messageEventArgs.EventGuid,
        (object) "@QuoteGuid",
        (object) quoteGuid
      });
      return DocumentManager.FileAddWithBind(path2, num, "Policy - Multi-Bind", (ISupportDocumentSystem) quote, true);
    }
    finally
    {
      CompanyDocumentAutomation.BlackBoxMode = false;
    }
  }

  protected virtual void bindquoteOption(DataTable dtb)
  {
    Quote quote = (Quote) null;
    PdfFileEditor pdfFileEditor = new PdfFileEditor();
    try
    {
      try
      {
        foreach (DataRow row in dtb.Rows)
        {
          this._pdfs.Clear();
          this.QuoteOptionsRowProcessForBind(row);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      string caption = "Error on Bind";
      if (quote != null)
        caption = $"Control #{quote.ControlNo.ToString()} - {caption}";
      int num = (int) MessageBox.Show("An error has occurred during the binding process.\n\n" + exception.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void buttonBind_Click(object sender, EventArgs e)
  {
    this.bindquoteOption((DataTable) this.ds.dtBindSubmissionQuotes);
  }

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

  private void AddAutomationReport(Guid tmpQuoteGuid)
  {
    if (((UltraCombo) this.comboAutomationReports).Value == null)
      return;
    using (SectionReport objectEx = (SectionReport) ObjectFactory.Instance.CreateObjectEX(this.GetReportType((Guid) ((UltraCombo) this.comboAutomationReports).Value), new object[1]
    {
      (object) tmpQuoteGuid
    }))
    {
      objectEx.Run();
      using (PdfExport pdfExport = new PdfExport())
      {
        string str = $"{MGATempFolder.CreateTempSubdirectory()}{((UltraCombo) this.comboAutomationReports).Value.ToString()}.pdf";
        pdfExport.Export(objectEx.Document, str);
        this._pdfs.Add(str);
      }
    }
  }

  protected Type GetReportType(Guid automationReportGuid)
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new MultiQuoteReportAttribute());
    int index1 = 0;
    Type reportType;
    while (index1 < typeArray.Length)
    {
      Type type = typeArray[index1];
      object[] customAttributes = type.GetCustomAttributes(false);
      int index2 = 0;
      while (index2 < customAttributes.Length)
      {
        if (RuntimeHelpers.GetObjectValue(customAttributes[index2]) is MultiQuoteReportAttribute objectValue && ((AutomationReportAttribute) objectValue).AutomationReportGuid == automationReportGuid)
        {
          reportType = type;
          goto label_9;
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    reportType = (Type) null;
label_9:
    return reportType;
  }

  protected virtual bool CheckAutomationReport(MultiQuoteReportAttribute reportAttribute) => true;

  private void LoadAutomationReports()
  {
    DataTable dataTable = new DataTable();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new MultiQuoteReportAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      MultiQuoteReportAttribute[] array = typeArray[index1].GetCustomAttributes(typeof (MultiQuoteReportAttribute), false).OfType<MultiQuoteReportAttribute>().ToArray<MultiQuoteReportAttribute>();
      int index2 = 0;
      while (index2 < array.Length)
      {
        MultiQuoteReportAttribute reportAttribute = array[index2];
        if (reportAttribute != null && this.CheckAutomationReport(reportAttribute))
          this.ds.Reports.AddReportsRow(((AutomationReportAttribute) reportAttribute).AutomationReportGuid, ((AutomationReportAttribute) reportAttribute).Title, ((AutomationReportAttribute) reportAttribute).Description);
        checked { ++index2; }
      }
      checked { ++index1; }
    }
  }

  private bool PreBindVerificationRaters(Quote tmpQuote)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RaterID, CompanyLineGuid FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) tmpQuote.QuoteGuid
    });
    bool flag;
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (row[0] == DBNull.Value && !tmpQuote.IsMultiCompanyPolicy)
        {
          int num = (int) MessageBox.Show($"Control # {tmpQuote.ControlNo.ToString()}. The system could not determine the rater used on this policy.", "Cannot Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          goto label_20;
        }
        IRater rater = RaterFactory.GetRater(Conversions.ToInteger(row[0]));
        if (rater == null && !tmpQuote.IsMultiCompanyPolicy)
        {
          CompanyLine companyLine = new CompanyLine((Guid) row[1]);
          int num = (int) MessageBox.Show($"Control # {tmpQuote.ControlNo.ToString()}. A rater was was not found for {companyLine.CompanyLineState}.", "Cannot Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          goto label_20;
        }
        if (rater != null)
        {
          try
          {
            rater.InitializeState(tmpQuote.QuoteGuid, (Guid) row[1]);
            if (!rater.IsReadyForBind)
            {
              List<string> readyToBindReason = rater.NotReadyToBindReason;
              if (readyToBindReason.Count > 0)
              {
                string str = string.Join("\n", (IEnumerable<string>) readyToBindReason);
                int num = (int) MessageBox.Show($"Control # {tmpQuote.ControlNo.ToString()}. Cannnot bind for the following reason(s):\n{str}.", "Cannot Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
                goto label_20;
              }
            }
          }
          finally
          {
            ((IDisposable) rater)?.Dispose();
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    dataTable?.Dispose();
    flag = true;
label_20:
    return flag;
  }
}
