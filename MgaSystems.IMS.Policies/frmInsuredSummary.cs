// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmInsuredSummary
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmInsuredSummary : Form
{
  private IContainer components;
  private dsInsuredSummary ds;
  private Label lblInsuredName;
  private Label lblInsuredAddress;
  private Label Label1;
  private Label Label2;
  private HyperlinkEditor _lnkView;
  private readonly Guid _insuredGuid;
  private readonly Guid _insuredLocationGuid;

  public frmInsuredSummary()
  {
    this.Load += new EventHandler(this.frmInsuredSummary_Load);
    this._lnkView = new HyperlinkEditor();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ugInsuredSummary")]
  protected virtual UltraGrid ugInsuredSummary { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkExport
  {
    get => this._lnkExport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExport_LinkClicked);
      LinkLabel lnkExport1 = this._lnkExport;
      if (lnkExport1 != null)
        lnkExport1.LinkClicked -= clickedEventHandler;
      this._lnkExport = value;
      LinkLabel lnkExport2 = this._lnkExport;
      if (lnkExport2 == null)
        return;
      lnkExport2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("InsuredSummary", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InsuredName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("InsuredAddress");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Producer");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Underwriter");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ControlNo");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("QuoteStatusReason");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Carrier");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Line");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PolicyNumber");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.lnkExport = new LinkLabel();
    this.lblInsuredName = new Label();
    this.lblInsuredAddress = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.ugInsuredSummary = new UltraGrid();
    this.ds = new dsInsuredSummary();
    ((ISupportInitialize) this.ugInsuredSummary).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lnkExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkExport.AutoSize = true;
    this.lnkExport.Location = new Point(0, 259);
    this.lnkExport.Name = "lnkExport";
    this.lnkExport.Size = new Size(179, 13);
    this.lnkExport.TabIndex = 2;
    this.lnkExport.TabStop = true;
    this.lnkExport.Text = "Click here to view this as a report...";
    this.lnkExport.TextAlign = ContentAlignment.MiddleLeft;
    this.lblInsuredName.Location = new Point(112 /*0x70*/, 8);
    this.lblInsuredName.Name = "lblInsuredName";
    this.lblInsuredName.Size = new Size(256 /*0x0100*/, 16 /*0x10*/);
    this.lblInsuredName.TabIndex = 3;
    this.lblInsuredName.Text = "lblInsuredName";
    this.lblInsuredAddress.Location = new Point(112 /*0x70*/, 32 /*0x20*/);
    this.lblInsuredAddress.Name = "lblInsuredAddress";
    this.lblInsuredAddress.Size = new Size(408, 16 /*0x10*/);
    this.lblInsuredAddress.TabIndex = 4;
    this.lblInsuredAddress.Text = "lblInsuredAddress";
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Insured Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.Location = new Point(8, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label2.TabIndex = 6;
    this.Label2.Text = "Insured Address:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.ugInsuredSummary).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugInsuredSummary).DataSource = (object) this.ds.InsuredSummary;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 191;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Insured Address";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 292;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 186;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 85;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Effective Date";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 72;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.FromArgb(0, 0, 192 /*0xC0*/);
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 69;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Quote Status";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Quote Status Reason";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 105;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 132;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 87;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 90;
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
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugInsuredSummary).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugInsuredSummary).Location = new Point(0, 56);
    ((Control) this.ugInsuredSummary).Name = "ugInsuredSummary";
    ((Control) this.ugInsuredSummary).Size = new Size(908, 195);
    ((Control) this.ugInsuredSummary).TabIndex = 1;
    ((Control) this.ugInsuredSummary).Text = "Insured Summary";
    ((UltraControlBase) this.ugInsuredSummary).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugInsuredSummary).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsInsuredSummary";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(908, 281);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblInsuredAddress);
    this.Controls.Add((Control) this.lblInsuredName);
    this.Controls.Add((Control) this.lnkExport);
    this.Controls.Add((Control) this.ugInsuredSummary);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmInsuredSummary);
    this.Text = "Insured Summary";
    ((ISupportInitialize) this.ugInsuredSummary).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmInsuredSummary(Guid insuredGuid, Guid insuredLocationGuid)
  {
    this.Load += new EventHandler(this.frmInsuredSummary_Load);
    this._lnkView = new HyperlinkEditor();
    this.InitializeComponent();
    this._insuredGuid = insuredGuid;
    this._insuredLocationGuid = insuredLocationGuid;
  }

  private void lnkExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.ds.InsuredSummary.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("Report cannot be generated because no data is available.", "No Data Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        SectionReport sectionReport = (SectionReport) new rptGridReport((DataTable) this.ds.InsuredSummary, 1, "Insured Summary Report");
        sectionReport.Run();
        ReportFactory.Instance.ShowReport(sectionReport);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void ViewPolicyInfo(object sender, CancelEventArgs e)
  {
    try
    {
      e.Cancel = true;
      if (((UltraGridBase) this.ugInsuredSummary).ActiveRow == null)
        return;
      int integer = Conversions.ToInteger(((UltraGridBase) this.ugInsuredSummary).ActiveRow.Cells["ControlNo"].Value);
      Quote quote = Quote.FromControlNo(integer);
      if (!quote.IsQuickQuote)
      {
        frmPolicyDetail formEx = (frmPolicyDetail) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyDetail), new object[1]
        {
          (object) integer
        });
        ((Form) formEx).StartPosition = FormStartPosition.CenterScreen;
        ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) formEx).Show();
      }
      else
      {
        frmQuoteEdit formEx = (frmQuoteEdit) ObjectFactory.Instance.CreateFormEX(typeof (frmQuoteEdit), new object[2]
        {
          (object) quote.QuoteGuid,
          (object) quote.SubmissionGroupGuid
        });
        ((Form) formEx).StartPosition = FormStartPosition.CenterScreen;
        ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) formEx).Show();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void frmInsuredSummary_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "InsuredSummary"
    }, "dbo.spGetInsuredSummary", new object[6]
    {
      (object) "@insuredGuid",
      (object) this._insuredGuid,
      (object) "@insuredLocationGuid",
      (object) this._insuredLocationGuid,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (this.ds.InsuredSummary.Rows.Count > 0)
    {
      dsInsuredSummary.InsuredSummaryRow row = (dsInsuredSummary.InsuredSummaryRow) this.ds.InsuredSummary.Rows[0];
      this.lblInsuredName.Text = row.InsuredName;
      this.lblInsuredAddress.Text = row.InsuredAddress;
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Name, Address1 + @C + City + @C + State + @S + ZipCode AS Address FROM tblInsuredLocations WHERE InsuredGUID = @insGuid", new object[6]
      {
        (object) "@insGuid",
        (object) this._insuredGuid,
        (object) "@C",
        (object) ", ",
        (object) "@S",
        (object) " "
      });
      if (dataRow != null)
      {
        this.lblInsuredName.Text = Conversions.ToString(dataRow[0]);
        this.lblInsuredAddress.Text = Conversions.ToString(dataRow[1]);
      }
    }
    this._lnkView.HyperLinkOpening += new CancelEventHandler(this.ViewPolicyInfo);
    ((UltraGridBase) this.ugInsuredSummary).DisplayLayout.Bands[0].Columns["ControlNo"].Editor = (EmbeddableEditorBase) this._lnkView;
    this.LoadOnClient();
    this.LoadOnClient(this.ds.InsuredSummary);
  }

  protected virtual void LoadOnClient(
    dsInsuredSummary.InsuredSummaryDataTable insuredSummary)
  {
  }

  protected virtual void LoadOnClient()
  {
  }
}
