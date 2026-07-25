// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.frmClearanceView
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.InfragisticsExtensions.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Clearance;

public class frmClearanceView : Form
{
  private IContainer components;
  private DbDataAdapter da;
  private HyperlinkEditor _lnk;
  private Guid _submissionGroupGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual LinkLabel lnkExport
  {
    get => this._lnkExport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkExport_Click);
      LinkLabel lnkExport1 = this._lnkExport;
      if (lnkExport1 != null)
        lnkExport1.Click -= eventHandler;
      this._lnkExport = value;
      LinkLabel lnkExport2 = this._lnkExport;
      if (lnkExport2 == null)
        return;
      lnkExport2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraGrid1")]
  protected virtual UltraGrid UltraGrid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsClearanceView ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ClearanceView", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteStatus");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLocation");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Limit");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Premium");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RiskDescription");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ControlNo");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("QuoteGuid");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this._spClearanceView = DefaultDatabase.CreateCommand();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.lnkExport = new LinkLabel();
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsClearanceView();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this._spClearanceView.CommandText = "dbo.[spClearanceView]";
    this._spClearanceView.CommandType = CommandType.StoredProcedure;
    this._spClearanceView.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@SubmissionGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@CurrentUserGuid", SqlDbType.UniqueIdentifier)
    });
    this.da.SelectCommand = this._spClearanceView;
    this.lnkExport.AutoSize = true;
    this.lnkExport.Location = new Point(12, 692);
    this.lnkExport.Name = "lnkExport";
    this.lnkExport.Size = new Size(179, 13);
    this.lnkExport.TabIndex = 1;
    this.lnkExport.TabStop = true;
    this.lnkExport.Text = "Click here to view this as a report...";
    this.lnkExport.TextAlign = ContentAlignment.MiddleLeft;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.ClearanceView;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Status";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 102;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 104;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 111;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 104;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance7;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Width = 84;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Risk Description";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 104;
    ultraGridColumn7.Format = "d";
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Width = 76;
    appearance9.FontData.UnderlineAsString = "True";
    appearance9.ForeColor = Color.Blue;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Center";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Control Number";
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 60;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 170;
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
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Dock = DockStyle.Top;
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(747, 689);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((Control) this.UltraGrid1).Text = "Submission Overview";
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsClearanceView";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(747, 714);
    this.Controls.Add((Control) this.lnkExport);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmClearanceView);
    this.Text = "Submission Overview";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmClearanceView()
  {
    this.Load += new EventHandler(this.frmClearanceView_Load);
    this._lnk = new HyperlinkEditor();
    this.InitializeComponent();
  }

  public frmClearanceView(Guid submissionGroupGuid)
  {
    this.Load += new EventHandler(this.frmClearanceView_Load);
    this._lnk = new HyperlinkEditor();
    this.InitializeComponent();
    this._submissionGroupGuid = submissionGroupGuid;
  }

  protected virtual void frmClearanceView_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this._spClearanceView.Parameters["@SubmissionGroupGuid"].Value = (object) this._submissionGroupGuid;
    this._spClearanceView.Parameters["@CurrentUserGuid"].Value = (object) CurrentUser.Instance.UserGUID;
    DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.ClearanceView);
    RichTextBox richTextBox = (RichTextBox) null;
    try
    {
      try
      {
        foreach (dsClearanceView.ClearanceViewRow clearanceViewRow in (TypedTableBase<dsClearanceView.ClearanceViewRow>) this.ds.ClearanceView)
        {
          if (!clearanceViewRow.IsLimitNull())
          {
            if (richTextBox == null)
              richTextBox = new RichTextBox();
            richTextBox.Rtf = clearanceViewRow.Limit;
            clearanceViewRow.Limit = richTextBox.Text;
          }
        }
      }
      finally
      {
        IEnumerator<dsClearanceView.ClearanceViewRow> enumerator;
        enumerator?.Dispose();
      }
    }
    finally
    {
      richTextBox?.Dispose();
    }
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["ControlNo"].Editor = (EmbeddableEditorBase) this._lnk;
    this._lnk.HyperLinkOpening += new CancelEventHandler(this.HyperLinkOpening);
  }

  [field: AccessedThroughProperty("_spClearanceView")]
  private virtual DbCommand _spClearanceView { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected SqlCommand spClearanceView
  {
    get => this._spClearanceView as SqlCommand;
    set => this._spClearanceView = (DbCommand) value;
  }

  private void HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (((UltraGridBase) this.UltraGrid1).ActiveRow == null)
      return;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) (Guid) ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["QuoteGuid"].Value
    });
  }

  private void lnkExport_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      dsClearanceView.ClearanceViewDataTable clearanceViewDataTable = (dsClearanceView.ClearanceViewDataTable) this.ds.ClearanceView.Copy();
      if (clearanceViewDataTable.Columns.Contains("quoteguid"))
        clearanceViewDataTable.Columns.Remove("quoteguid");
      SectionReport sectionReport = (SectionReport) new rptGridReport((DataTable) clearanceViewDataTable, 1, "Submission Overview Report");
      sectionReport.Run();
      ReportFactory.Instance.ShowReport(sectionReport);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }
}
