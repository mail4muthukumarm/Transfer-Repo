// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.MultiQuotePrinting.FormMultiQuotePrinting
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.PDF;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Policies.BindPolicy;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Reporting.GenericReport;
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
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Clearance.MultiQuotePrinting;

[DesignerGenerated]
public class FormMultiQuotePrinting : Form, IMessageListener, IMultiQuotePrinting
{
  private IContainer components;
  private dsMultiQuotePrinting dsMultiQuote;
  protected MGAListBox listAdditionalDocuments;
  private Guid _submissionGroupGuid;
  private bool _skipSortingDocuments;
  private readonly Dictionary<Guid, Type> ReportCache;
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
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMultiQuotePrinting));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("MultiQuotePrinting", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Premium");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Company");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineName");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("HasAutomationSetup");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RatingType");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LineCode");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.buttonPrint = new MGAButton();
    this.listAdditionalDocuments = new MGAListBox();
    this.labelRedItems = new UltraFormattedLinkLabel();
    this.comboAutomationReports = new MGASimpleComboBox();
    this.dsMultiQuote = new dsMultiQuotePrinting();
    this.gridQuotes = new UltraGrid();
    Label label1 = new Label();
    Label label2 = new Label();
    ((ISupportInitialize) this.buttonPrint).BeginInit();
    ((ISupportInitialize) this.listAdditionalDocuments).BeginInit();
    ((ISupportInitialize) this.comboAutomationReports).BeginInit();
    this.dsMultiQuote.BeginInit();
    ((ISupportInitialize) this.gridQuotes).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.Location = new Point(12, 9);
    label1.Name = "Label1";
    label1.Size = new Size(236, 13);
    label1.TabIndex = 1;
    label1.Text = "Please select the quotes you would like to print:";
    label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label2.AutoSize = true;
    label2.Location = new Point(275, 378);
    label2.Name = "Label2";
    label2.Size = new Size(113, 13);
    label2.TabIndex = 4;
    label2.Text = "Additional documents:";
    label2.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.buttonPrint).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonPrint).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonPrint).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonPrint).Location = new Point(600, 441);
    ((Control) this.buttonPrint).Name = "buttonPrint";
    ((ControlBase) this.buttonPrint).Padding = new Size(7, 0);
    ((Control) this.buttonPrint).Size = new Size(134, 40);
    ((Control) this.buttonPrint).TabIndex = 2;
    ((ControlBase) this.buttonPrint).Text = "Print Quotes";
    this.buttonPrint.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.listAdditionalDocuments).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((ListControl) this.listAdditionalDocuments).FormattingEnabled = true;
    ((Control) this.listAdditionalDocuments).Location = new Point(12, 375);
    this.listAdditionalDocuments.MGAStyle = (MGAStyles) 2;
    ((Control) this.listAdditionalDocuments).Name = "listAdditionalDocuments";
    ((Control) this.listAdditionalDocuments).Size = new Size(254, 106);
    ((Control) this.listAdditionalDocuments).TabIndex = 5;
    ((Control) this.labelRedItems).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.FontData.BoldAsString = "False";
    appearance2.FontData.ItalicAsString = "False";
    appearance2.FontData.Name = "Tahoma";
    appearance2.FontData.SizeInPoints = 8.25f;
    appearance2.FontData.StrikeoutAsString = "False";
    appearance2.FontData.UnderlineAsString = "False";
    ((UltraFormattedTextEditorBase) this.labelRedItems).Appearance = (AppearanceBase) appearance2;
    ((UltraFormattedTextEditorBase) this.labelRedItems).AutoSize = true;
    ((Control) this.labelRedItems).Location = new Point(272, 415);
    ((Control) this.labelRedItems).Name = "labelRedItems";
    ((Control) this.labelRedItems).Size = new Size(439, 15);
    ((Control) this.labelRedItems).TabIndex = 6;
    this.labelRedItems.TabStop = true;
    ((UltraFormattedTextEditorBase) this.labelRedItems).Value = (object) componentResourceManager.GetString("labelRedItems.Value");
    ((Control) this.labelRedItems).Visible = false;
    ((Control) this.comboAutomationReports).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraCombo) this.comboAutomationReports).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboAutomationReports).DataMember = "Reports";
    ((UltraGridBase) this.comboAutomationReports).DataSource = (object) this.dsMultiQuote;
    ((UltraDropDownBase) this.comboAutomationReports).DisplayMember = "Title";
    ((UltraCombo) this.comboAutomationReports).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboAutomationReports).Location = new Point(407, 374);
    this.comboAutomationReports.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboAutomationReports).Name = "comboAutomationReports";
    ((Control) this.comboAutomationReports).Size = new Size(327, 21);
    ((Control) this.comboAutomationReports).TabIndex = 3;
    ((UltraControlBase) this.comboAutomationReports).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboAutomationReports).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboAutomationReports).ValueMember = "AutomationReportGuid";
    this.dsMultiQuote.DataSetName = "dsMultiQuotePrinting";
    this.dsMultiQuote.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.gridQuotes).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridQuotes).DataMember = "MultiQuotePrinting";
    ((UltraGridBase) this.gridQuotes).DataSource = (object) this.dsMultiQuote;
    ((SpecialBoxBase) ((UltraGridBase) this.gridQuotes).DisplayLayout.AddNewBox).Prompt = " ";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    appearance4.ForeColor = Color.DarkGreen;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn1.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 4;
    ultraGridColumn1.Width = 182;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 313;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 266;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Line of Business";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 234;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 38;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 177;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 104;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 88;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 88;
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
    ((UltraGridBase) this.gridQuotes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridQuotes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.SizeInPoints = 10f;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridQuotes).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridQuotes).Location = new Point(12, 40);
    ((Control) this.gridQuotes).Name = "gridQuotes";
    ((Control) this.gridQuotes).Size = new Size(722, 328);
    ((Control) this.gridQuotes).TabIndex = 0;
    ((Control) this.gridQuotes).Text = "Quotes in this Submission Group";
    ((UltraControlBase) this.gridQuotes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridQuotes).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(746, 494);
    this.Controls.Add((Control) this.labelRedItems);
    this.Controls.Add((Control) this.listAdditionalDocuments);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.comboAutomationReports);
    this.Controls.Add((Control) this.buttonPrint);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) this.gridQuotes);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormMultiQuotePrinting);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Multi-Quote Printing";
    ((ISupportInitialize) this.buttonPrint).EndInit();
    ((ISupportInitialize) this.listAdditionalDocuments).EndInit();
    ((ISupportInitialize) this.comboAutomationReports).EndInit();
    this.dsMultiQuote.EndInit();
    ((ISupportInitialize) this.gridQuotes).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAButton buttonPrint
  {
    get => this._buttonPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonPrint_Click);
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

  [field: AccessedThroughProperty("labelRedItems")]
  protected virtual UltraFormattedLinkLabel labelRedItems { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridQuotes")]
  protected virtual UltraGrid gridQuotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboAutomationReports")]
  protected virtual MGASimpleComboBox comboAutomationReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormMultiQuotePrinting(Guid submissionGroupGuid)
    : this()
  {
    this._submissionGroupGuid = submissionGroupGuid;
  }

  public FormMultiQuotePrinting()
  {
    this.FormClosing += new FormClosingEventHandler(this.FormMultiQuotePrinting_FormClosing);
    this.Load += new EventHandler(this.FormMultiQuotePrinting_Load);
    this._skipSortingDocuments = false;
    this.ReportCache = new Dictionary<Guid, Type>();
    this._pdfs = new List<string>();
    this.InitializeComponent();
  }

  protected virtual int GetFolderNumber => -1;

  protected virtual bool InvokeEmail => true;

  protected virtual bool InvokeDocument => false;

  protected virtual string ProcedureName
  {
    get
    {
      string tmpProcName = "dbo.MultiQuotePrinting";
      this.ProcName(ref tmpProcName);
      return tmpProcName;
    }
  }

  protected virtual bool CheckAutomationReport(string reportName) => true;

  private void LoadAutomationReports()
  {
    DataTable dataTable = new DataTable();
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
          this.dsMultiQuote.Reports.AddReportsRow(((AutomationReportAttribute) objectValue).AutomationReportGuid, ((AutomationReportAttribute) objectValue).Title, ((AutomationReportAttribute) objectValue).Description);
          this.ReportCache[((AutomationReportAttribute) objectValue).AutomationReportGuid] = type;
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
  }

  protected virtual void buttonPrint_Click(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    this.gridQuotes.PerformAction((UltraGridAction) 44);
    ((UltraGridBase) this.gridQuotes).UpdateData();
    CompanyDocumentAutomation.SendToDocumentSystem = false;
    this.DeleteExistingSetups();
    Queue<Guid> guidQueue = new Queue<Guid>();
    List<Guid> selectedQuotes = this.SelectedQuotes;
    DataRow row1 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT SettingValueBool, SettingValueString FROM dbo.tblSystemSettings WITH(NOLOCK) WHERE Setting = @setting", new object[2]
    {
      (object) "@setting",
      (object) "EnforceNetRateCompanyMatchOnQuote"
    });
    try
    {
      dsMultiQuotePrinting.MultiQuotePrintingDataTable multiQuotePrinting = this.dsMultiQuote.MultiQuotePrinting;
      System.Func<dsMultiQuotePrinting.MultiQuotePrintingRow, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (FormMultiQuotePrinting._Closure\u0024__.\u0024I36\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = FormMultiQuotePrinting._Closure\u0024__.\u0024I36\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        FormMultiQuotePrinting._Closure\u0024__.\u0024I36\u002D0 = predicate = (System.Func<dsMultiQuotePrinting.MultiQuotePrintingRow, bool>) ([SpecialName] (tr) => tr.Selected);
      }
      foreach (dsMultiQuotePrinting.MultiQuotePrintingRow row2 in multiQuotePrinting.Where<dsMultiQuotePrinting.MultiQuotePrintingRow>(predicate))
      {
        Guid quoteGuid = row2.QuoteGUID;
        if (StringExtensions.EqualsNoCase("NetRate", row2.Field<string>("RatingType")) && ExtensionsMethods.FieldOrDefault<bool>(row1, "SettingValueBool", false) && !row1.IsNull("SettingValueString") && (StringExtensions.EqualsNoCase(row1.Field<string>("SettingValueString"), "ALL") || StringExtensions.EqualsNoCase(row1.Field<string>("SettingValueString"), row2.Field<string>("LineCode"))))
        {
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.NetRateNotReadyToBindReasons(@quoteGuid)", new object[2]
          {
            (object) "@quoteGuid",
            (object) quoteGuid
          });
          if (dataTable.Rows.Count > 0)
          {
            List<string> stringList = new List<string>();
            try
            {
              foreach (DataRow row3 in dataTable.Rows)
              {
                string Left = row3.Field<string>("Reason");
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "The company selected in NetRate does not match", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "  the company for this account in the IMS.", false) == 0)
                {
                  stringList.Add(Left);
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "  the company for this account in the IMS.", false) == 0)
                  {
                    FormSettings.ShowFormDialog(typeof (frmBindingRequirements), new object[2]
                    {
                      (object) stringList,
                      (object) frmBindingRequirements.RequirementsType.Bind
                    });
                    this.Cursor = Cursors.Default;
                    return;
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
          }
        }
        if (row2.HasAutomationSetup)
          guidQueue.Enqueue(quoteGuid);
        this.MarkQuoteAsPrinted(quoteGuid);
      }
    }
    finally
    {
      IEnumerator<dsMultiQuotePrinting.MultiQuotePrintingRow> enumerator;
      enumerator?.Dispose();
    }
    this.ClickedPrint(selectedQuotes);
    if (guidQueue.Count == 0)
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblMultiQuotes WHERE SubmissionGroupGuid = @SG", new object[2]
      {
        (object) "@SG",
        (object) this._submissionGroupGuid
      }) > 0)
      {
        this.CreateQuotePackage(selectedQuotes);
      }
      else
      {
        this.Cursor = MgaCursors.Default;
        int num = (int) MessageBox.Show("No documents were created from the selected quotes.", "No Documents Created", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
    }
    else
    {
      CompanyDocumentAutomation.ViewPrintEmailFormEnabled = false;
      if (this._skipSortingDocuments)
        CompanyDocumentAutomation.SortDocuments = false;
      frmClearance.PrintQuote(guidQueue.Dequeue());
    }
    try
    {
      foreach (Guid guid in selectedQuotes)
      {
        Quote quote = new Quote(guid);
        if (quote.QuoteStatus == 1)
          quote.ChangeStatus(2, "Multi Quote Printing");
      }
    }
    finally
    {
      List<Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  protected virtual void ClickedPrint(List<Guid> selectedQuotes)
  {
  }

  [Obsolete("Do not use pass by reference to alter a value. Use an overridable property/function instead.")]
  protected virtual void ProcName(ref string tmpProcName)
  {
  }

  [Obsolete("Do not use pass by reference to alter a value. Use an overridable property/function instead.")]
  protected virtual void DocumentName(ref string tmpDocumentName)
  {
  }

  protected virtual string ClientDocumentName(string docName)
  {
    this.DocumentName(ref docName);
    return docName;
  }

  private void DeleteExistingSetups()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblMultiQuotes WHERE SubmissionGroupGuid = @SG", new object[2]
    {
      (object) "@SG",
      (object) this._submissionGroupGuid
    });
  }

  private void CreateQuotePackage(List<Guid> quoteGuids)
  {
    if (quoteGuids.Count == 0)
      return;
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      Guid guid1 = quoteGuids.First<Guid>();
      if (guid1.Equals(Guid.Empty))
        throw new InvalidOperationException("Could not find a selected quote");
      Guid currentSelectedReport = this.CurrentSelectedReport;
      if (!currentSelectedReport.Equals(Guid.Empty) && !this.IsReportAlreadyAutomated())
      {
        Type reportType = this.GetReportType(currentSelectedReport);
        object objectValue;
        try
        {
          objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(reportType, new object[1]
          {
            (object) quoteGuids
          }));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          exception.Data.Add((object) "UI", (object) this.GetType().FullName);
          exception.Data.Add((object) "Type", (object) reportType.FullName);
          exception.Data.Add((object) "AutomationReportGUID", (object) currentSelectedReport);
          ErrorHandler.SilentHandleError(exception);
          objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(reportType, new object[1]
          {
            (object) quoteGuids.First<Guid>()
          }));
          ProjectData.ClearProjectError();
        }
        string path = $"{MGATempFolder.CreateTempSubdirectory()}{RuntimeHelpers.GetObjectValue(((UltraCombo) this.comboAutomationReports).Value)}.pdf";
        SectionReport sectionReport = (SectionReport) null;
        if (objectValue is SectionReport)
        {
          sectionReport = objectValue as SectionReport;
          sectionReport.Run();
        }
        else if (objectValue is IGenericReport)
        {
          RunCompletedResult runCompletedResult = (objectValue as IGenericReport).Run((object) quoteGuids);
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
        if (sectionReport != null)
        {
          using (PdfExport pdfExport = new PdfExport())
          {
            pdfExport.Export(sectionReport.Document, path);
            this._pdfs.Insert(0, path);
          }
        }
      }
      PdfFileEditor pdfFileEditor = new PdfFileEditor();
      string str1;
      using (CompanyDocumentAutomation documentAutomation = new CompanyDocumentAutomation(Guid.Empty))
      {
        string str2 = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        documentAutomation.QuoteGuid = guid1;
        str1 = documentAutomation.GetFriendlyFilename();
        str1 = $"{Path.GetDirectoryName(str1)}\\quote_{str2}_{Path.GetFileName(str1)}";
      }
      this.AddPDFs(this._pdfs);
      if (this._pdfs.Count == 0)
        return;
      pdfFileEditor.Concatenate(this._pdfs.ToArray(), str1);
      Cursor.Current = MgaCursors.Default;
      List<Guid> tmpDocumentStoreGuids = new List<Guid>();
      string FileName = this.BeforeProcessPDF(str1);
      string tmpDocumentName = "Quote Bundle";
      this.DocumentName(ref tmpDocumentName);
      try
      {
        foreach (Guid quoteGuid in quoteGuids)
        {
          Quote quote = Quote.CreateNew(quoteGuid);
          Guid guid2 = DocumentManager.FileAddWithBind(FileName, this.GetFolderNumber, tmpDocumentName, (ISupportDocumentSystem) quote, true);
          if (tmpDocumentStoreGuids.Count == 0)
            tmpDocumentStoreGuids.Add(guid2);
        }
      }
      finally
      {
        List<Guid>.Enumerator enumerator;
        enumerator.Dispose();
      }
      string str3 = this.PostProcessPDF(FileName);
      List<string> stringList = new List<string>();
      stringList.Add(str3);
      Quote quoteViewPrintEmail = Quote.CreateNew(guid1);
      string str4 = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT tblProducerContacts.Email FROM tblSubmissionGroup INNER JOIN tblProducerContacts ON tblSubmissionGroup.ProducerContactID = tblProducerContacts.ProducerContactID WHERE tblSubmissionGroup.SubmissionGroupGUID=@SG", new object[2]
      {
        (object) "@SG",
        (object) quoteViewPrintEmail.SubmissionGroupGuid
      })), string.Empty);
      List<string> recipients = new List<string>();
      if (!string.IsNullOrEmpty(str4))
        recipients.Add(str4);
      if (this.InvokeEmail)
      {
        if (CurrentUser.UsingOutlook)
          SMTP_Email.SendUsingOutlook(stringList, recipients, "Quotes for " + quoteViewPrintEmail.SubmissionGroup.InsuredLocation.Insured.Name, string.Empty, (List<string>) null, (SMTP_Email.ShowOrSend) 1);
        else
          Process.Start(stringList[0]);
      }
      else if (this.InvokeDocument)
        Process.Start(stringList[0]);
      this.ClientPackageWork(quoteViewPrintEmail, tmpDocumentStoreGuids, recipients);
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadWait));
      this.Close();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual string BeforeProcessPDF(string FileName) => FileName;

  protected virtual string PostProcessPDF(string FileName) => FileName;

  protected virtual void AddPDFs(List<string> pdfs)
  {
  }

  protected virtual void ClientPackageWork(
    Quote quoteViewPrintEmail,
    List<Guid> tmpDocumentStoreGuids,
    List<string> recipients)
  {
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
      Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new AutomationReportAttribute());
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

  private void ThreadWait(object state)
  {
    Thread.Sleep(10000);
    CompanyDocumentAutomation.ViewPrintEmailFormEnabled = true;
    CompanyDocumentAutomation.SortDocuments = true;
  }

  private void MarkQuoteAsPrinted(Guid quoteGuid)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblMultiQuotes WHERE SubmissionGroupGuid = @SG AND QuoteGuid = @QG", new object[4]
    {
      (object) "@SG",
      (object) this._submissionGroupGuid,
      (object) "@QG",
      (object) quoteGuid
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblMultiQuotes(SubmissionGroupGuid, QuoteGuid, TimePrinted)VALUES(@SG, @QG, @T)", new object[6]
    {
      (object) "@SG",
      (object) this._submissionGroupGuid,
      (object) "@QG",
      (object) quoteGuid,
      (object) "@T",
      (object) DateTime.Now
    });
  }

  private void WaitCursorOnMessageReceived()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.WaitCursorOnMessageReceived), new object[0]);
    else
      this.Cursor = MgaCursors.WaitCursor;
  }

  private void NormalCursorAfterMessageReceived()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.NormalCursorAfterMessageReceived), new object[0]);
    else
      this.Cursor = MgaCursors.Default;
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    this.WaitCursorOnMessageReceived();
    if (eventGuid.Equals(BroadcastMessages.QuoteDocumentCreated))
    {
      ArrayList arrayList = (ArrayList) context;
      Guid guid = (Guid) arrayList[0];
      string str1 = (string) arrayList[1];
      string str2 = Path.GetFileNameWithoutExtension(str1) + guid.ToString() + Path.GetExtension(str1);
      char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
      int index1 = 0;
      while (index1 < invalidFileNameChars.Length)
      {
        char ch = invalidFileNameChars[index1];
        str2 = str2.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index1; }
      }
      char[] invalidPathChars = Path.GetInvalidPathChars();
      int index2 = 0;
      while (index2 < invalidPathChars.Length)
      {
        char ch = invalidPathChars[index2];
        str2 = str2.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index2; }
      }
      string str3 = str2.Replace(";", string.Empty);
      string str4 = $"{Path.GetDirectoryName(str1)}\\{str3}";
      if (File.Exists(str4))
        File.Delete(str4);
      File.Copy(str1, str4);
      this._pdfs.Add(str4);
      if (MDIControls.Instance.MDIParent.InvokeRequired)
        InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new Action<List<Guid>>(this.CreateQuotePackage), new object[1]
        {
          (object) this.SelectedQuotes
        });
      else
        this.CreateQuotePackage(this.SelectedQuotes);
    }
    else if (eventGuid.Equals(BroadcastMessages.NoEventDocumentsCreated))
    {
      if (MDIControls.Instance.MDIParent.InvokeRequired)
        InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new Action<List<Guid>>(this.CreateQuotePackage), new object[1]
        {
          (object) this.SelectedQuotes
        });
      else
        this.CreateQuotePackage(this.SelectedQuotes);
    }
    MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new MethodInvoker(this.NormalCursorAfterMessageReceived));
  }

  protected List<Guid> SelectedQuotes
  {
    get
    {
      dsMultiQuotePrinting.MultiQuotePrintingDataTable multiQuotePrinting = this.dsMultiQuote.MultiQuotePrinting;
      System.Func<dsMultiQuotePrinting.MultiQuotePrintingRow, bool> predicate;
      if (FormMultiQuotePrinting._Closure\u0024__.\u0024I55\u002D0 != null)
        predicate = FormMultiQuotePrinting._Closure\u0024__.\u0024I55\u002D0;
      else
        FormMultiQuotePrinting._Closure\u0024__.\u0024I55\u002D0 = predicate = (System.Func<dsMultiQuotePrinting.MultiQuotePrintingRow, bool>) ([SpecialName] (t) => t.Selected);
      EnumerableRowCollection<dsMultiQuotePrinting.MultiQuotePrintingRow> source = multiQuotePrinting.Where<dsMultiQuotePrinting.MultiQuotePrintingRow>(predicate);
      System.Func<dsMultiQuotePrinting.MultiQuotePrintingRow, Guid> selector;
      if (FormMultiQuotePrinting._Closure\u0024__.\u0024I55\u002D1 != null)
        selector = FormMultiQuotePrinting._Closure\u0024__.\u0024I55\u002D1;
      else
        FormMultiQuotePrinting._Closure\u0024__.\u0024I55\u002D1 = selector = (System.Func<dsMultiQuotePrinting.MultiQuotePrintingRow, Guid>) ([SpecialName] (t) => t.QuoteGUID);
      return source.Select<dsMultiQuotePrinting.MultiQuotePrintingRow, Guid>(selector).ToList<Guid>();
    }
  }

  private void FormMultiQuotePrinting_FormClosing(object sender, FormClosingEventArgs e)
  {
    CompanyDocumentAutomation.SendToDocumentSystem = true;
  }

  private void FormMultiQuotePrinting_Load(object sender, EventArgs e)
  {
    this._skipSortingDocuments = SystemSettings.GetSetting<bool>("MultiQuotePrintingSkipSortingDocuments", false);
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) this.dsMultiQuote.MultiQuotePrinting, this.ProcedureName, new object[2]
      {
        (object) "@submissionGroupGuid",
        (object) this._submissionGroupGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.dsMultiQuote, ex);
      ProjectData.ClearProjectError();
    }
    this.LoadAutomationReports();
    this.gridQuotes.Selected.Rows.Clear();
    ((UltraGridBase) this.gridQuotes).ActiveRow = (UltraGridRow) null;
  }

  public List<Guid> LoadedAutomatedReports()
  {
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (dsMultiQuotePrinting.ReportsRow row in this.dsMultiQuote.Reports.Rows)
      {
        if (!string.IsNullOrEmpty(row.Title) && !row.AutomationReportGuid.Equals(Guid.Empty))
          guidList.Add(row.AutomationReportGuid);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return guidList;
  }

  public List<Guid> OtherSelectedQuotes(Guid firstQuoteGuid)
  {
    return this.SelectedQuotes.Except<Guid>(Enumerable.Repeat<Guid>(firstQuoteGuid, 1)).ToList<Guid>();
  }

  public Guid CurrentSelectedReport
  {
    get
    {
      return Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.comboAutomationReports).Value)) ? Guid.Empty : (Guid) ((UltraCombo) this.comboAutomationReports).Value;
    }
  }

  protected virtual bool IsReportAlreadyAutomated()
  {
    bool flag;
    if (this.CurrentSelectedReport.Equals(Guid.Empty))
      flag = false;
    else
      flag = DefaultDatabase.ExecuteScalar<bool>("dbo.spMultiQuote_IsReportDuplicate", new object[4]
      {
        (object) "@QuoteGuidString",
        (object) string.Join<Guid>(",", (IEnumerable<Guid>) this.SelectedQuotes),
        (object) "@AutomationReportGuid",
        ((UltraCombo) this.comboAutomationReports).Value
      });
    return flag;
  }
}
