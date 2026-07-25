// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormRenewAllResults
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormRenewAllResults : Form
{
  private IContainer components;
  private HyperlinkEditor _hlkOrigControlNo;
  private HyperlinkEditor _hlkRenewControlNo;
  private string _renewStr;
  private Guid _InsuredLocationGuid;
  private SubmissionGroup _sgRenewal;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OrigControlNo");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RenewControlNo");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ugRenewAllResults = new UltraGrid();
    this.ds = new dsResults();
    this.lnkShowSubmission = new LinkLabel();
    ((ISupportInitialize) this.ugRenewAllResults).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugRenewAllResults).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugRenewAllResults).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugRenewAllResults).DataMember = "dt";
    ((UltraGridBase) this.ugRenewAllResults).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Original Control #";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 178;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Renewal Control #";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 188;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugRenewAllResults).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugRenewAllResults).Location = new Point(12, 12);
    ((Control) this.ugRenewAllResults).Name = "ugRenewAllResults";
    ((Control) this.ugRenewAllResults).Size = new Size(368, 287);
    ((Control) this.ugRenewAllResults).TabIndex = 3;
    ((Control) this.ugRenewAllResults).Text = "Results";
    ((UltraControlBase) this.ugRenewAllResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRenewAllResults).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsResults";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkShowSubmission.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkShowSubmission.AutoSize = true;
    this.lnkShowSubmission.BackColor = Color.Transparent;
    this.lnkShowSubmission.Location = new Point(118, 313);
    this.lnkShowSubmission.Name = "lnkShowSubmission";
    this.lnkShowSubmission.Size = new Size(90, 13);
    this.lnkShowSubmission.TabIndex = 314;
    this.lnkShowSubmission.TabStop = true;
    this.lnkShowSubmission.Text = "Show Submission";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(392, 344);
    this.Controls.Add((Control) this.lnkShowSubmission);
    this.Controls.Add((Control) this.ugRenewAllResults);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormRenewAllResults);
    this.Text = "Renew All Results";
    ((ISupportInitialize) this.ugRenewAllResults).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugRenewAllResults")]
  private virtual UltraGrid ugRenewAllResults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsResults ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkShowSubmission
  {
    get => this._lnkShowSubmission;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowSubmission_LinkClicked);
      LinkLabel lnkShowSubmission1 = this._lnkShowSubmission;
      if (lnkShowSubmission1 != null)
        lnkShowSubmission1.LinkClicked -= clickedEventHandler;
      this._lnkShowSubmission = value;
      LinkLabel lnkShowSubmission2 = this._lnkShowSubmission;
      if (lnkShowSubmission2 == null)
        return;
      lnkShowSubmission2.LinkClicked += clickedEventHandler;
    }
  }

  public FormRenewAllResults(string renewStr)
  {
    this.Load += new EventHandler(this.FormRenewAllResults_Load);
    this._hlkOrigControlNo = new HyperlinkEditor();
    this._hlkRenewControlNo = new HyperlinkEditor();
    this._renewStr = string.Empty;
    this._sgRenewal = (SubmissionGroup) null;
    this.InitializeComponent();
    this._renewStr = renewStr;
  }

  private void MassageString()
  {
    string[] strArray = this._renewStr.Split('/');
    int index = 0;
    while (index < strArray.Length)
    {
      string s = strArray[index];
      int minValue = int.MinValue;
      ref int local = ref minValue;
      if (int.TryParse(s, out local))
      {
        int num = minValue;
        int integer = Conversions.ToInteger(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ControlNo FROM tblQuotes WITH (NOLOCK) WHERE RenewalOfControlNum = @CN", new object[2]
        {
          (object) "@CN",
          (object) num
        }));
        UltraGridRow ultraGridRow = ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Bands[0].AddNew();
        ultraGridRow.Cells["OrigControlNo"].Value = (object) num;
        ultraGridRow.Cells["RenewControlNo"].Value = (object) integer;
      }
      checked { ++index; }
    }
    ((UltraGridBase) this.ugRenewAllResults).UpdateData();
    if (((UltraGridBase) this.ugRenewAllResults).Rows.Count <= 0)
      return;
    this._sgRenewal = Quote.FromControlNo(Conversions.ToInteger(((UltraGridBase) this.ugRenewAllResults).Rows[0].Cells["RenewControlNo"].Value)).SubmissionGroup;
    this._InsuredLocationGuid = this._sgRenewal.InsuredLocationGuid;
  }

  private void FormRenewAllResults_Load(object sender, EventArgs e)
  {
    this.MassageString();
    this.Text = $"{this.Text} for Insured - [{new InsuredLocation(this._InsuredLocationGuid).Insured.Name}]";
    this._hlkOrigControlNo.HyperLinkOpening += new CancelEventHandler(this._hlkOrigControlNo_Opening);
    this._hlkRenewControlNo.HyperLinkOpening += new CancelEventHandler(this._hlkRenewControlNo_Opening);
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Bands[0].Columns["OrigControlNo"].Editor = (EmbeddableEditorBase) this._hlkOrigControlNo;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Bands[0].Columns["OrigControlNo"].CellAppearance.FontData.Underline = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Bands[0].Columns["RenewControlNo"].Editor = (EmbeddableEditorBase) this._hlkRenewControlNo;
    ((UltraGridBase) this.ugRenewAllResults).DisplayLayout.Bands[0].Columns["RenewControlNo"].CellAppearance.FontData.Underline = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugRenewAllResults).UpdateData();
  }

  private void _hlkOrigControlNo_Opening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugRenewAllResults).ActiveRow.Cells["OrigControlNo"].Value == DBNull.Value)
      return;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) Conversions.ToInteger(((UltraGridBase) this.ugRenewAllResults).ActiveRow.Cells["OrigControlNo"].Value)
    });
  }

  private void _hlkRenewControlNo_Opening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugRenewAllResults).ActiveRow.Cells["RenewControlNo"].Value == DBNull.Value)
      return;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) Conversions.ToInteger(((UltraGridBase) this.ugRenewAllResults).ActiveRow.Cells["RenewControlNo"].Value)
    });
  }

  private void lnkShowSubmission_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.ds.dt.Count == 0)
      return;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
      {
        frmClearance.TabClearanceSearch.ClearSearch();
        frmClearance.InitiateSearch(this.SetRenenwalQuotesClearanceParameters());
        break;
      }
      checked { ++index; }
    }
    this.Close();
  }

  private ClearanceSearchInfo SetRenenwalQuotesClearanceParameters()
  {
    return new ClearanceSearchInfo()
    {
      HideVoids = true,
      InForce = false,
      IsSinglePolicySearch = false,
      IssuingOffice = new Guid?(Guid.Empty),
      LimitToBoundStatusOnly = true,
      NumResults = 25,
      QuotingOffice = new Guid?(Guid.Empty),
      StartsWith = false,
      SubmissionID = new int?(this._sgRenewal.SubmissionGroupID)
    };
  }
}
