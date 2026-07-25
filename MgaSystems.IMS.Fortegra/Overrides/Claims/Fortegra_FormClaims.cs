// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormClaims
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormClaims))]
public class Fortegra_FormClaims : FormClaims
{
  private bool IsClosing;
  private HashSet<string> _fortegraPackageLinesSet;
  private IContainer components;
  protected MGATextBox txtExternalRef;
  protected Label label11;

  private Guid AdjusterChangedEvent { get; } = new Guid("19A51834-7B29-4BC1-9A3C-148E8A620F44");

  public Fortegra_FormClaims() => this.InitializeComponent();

  public Fortegra_FormClaims(Claim claim)
    : base(claim)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormClaims(int controlNumber)
    : base(controlNumber)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormClaims(Guid claimGuid)
    : base(claimGuid)
  {
    this.InitializeComponent();
  }

  private void Fortegra_FormClaims_Load(object sender, EventArgs e)
  {
    this.LoadFortegraData();
    this.HookupClaimEvents();
  }

  protected override void FormClaims_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.IsClosing = true;
    base.FormClaims_FormClosing(sender, e);
    if (!e.Cancel)
      return;
    this.IsClosing = false;
  }

  private void ClaimBeforeSaveHandler(object sender, CancelEventArgs e)
  {
    this.SaveCustomClaimData();
    e.Cancel = false;
  }

  protected override void SaveClaim(bool redisplayClaim)
  {
    if (this.CurrentClaim != null && !this.CurrentClaim.InhouseAdjuster.Equals(this.comboAdjusterAssigned.Value))
      Messaging.SendBroadcastMessage(this.AdjusterChangedEvent, (object) DefaultDatabase.ExecuteScalar<Guid>("dbo.Fortegra_GetQuoteGuidFromClaimGuid", new object[2]
      {
        (object) "@ClaimGUID",
        (object) this.CurrentClaim.ClaimGuid
      }));
    base.SaveClaim(redisplayClaim);
  }

  protected override void BindReservePaymentBreakout()
  {
    this.CurrentClaim._reservePaymentsBreakout = new dsReservePaymentBreakout();
    DefaultDatabase.LoadDataSet((DataSet) this.CurrentClaim._reservePaymentsBreakout, new string[2]
    {
      "ReservePaymentBreakout",
      "Claimants"
    }, "Fortegra_spClaims_GetReservePaymentBreakout", new object[2]
    {
      (object) "@claimid",
      (object) this.CurrentClaim.ClaimId
    });
    base.BindReservePaymentBreakout();
    UltraGridColumn column1 = ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Bands[1].Columns["ChildLineName"];
    UltraGridColumn column2 = ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Bands[1].Columns["ChildLineGuid"];
    ((HeaderBase) column1.Header).Caption = "Child Line";
    ((HeaderBase) column1.Header).VisiblePosition = 10;
    column2.Hidden = true;
  }

  protected override void ModifyReserve()
  {
    if (!SecurityManager.Instance.AssertPermission("{07F990AF-457C-49F1-9C65-75151047A1D1}"))
    {
      int num1 = (int) MessageBox.Show("You do not have rights to perform the requested action.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      if (((SparseCollectionBase) this.gridOverview_ReservePaymentBreakout.Selected.Rows).Count == 0)
        return;
      if (((GridItemBase) this.gridOverview_ReservePaymentBreakout.Selected.Rows[0]).Band.Index != 1)
      {
        int num2 = (int) MessageBox.Show("You must select a reserve type card to continue.", "Invalid Selection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        UltraGridRow row = this.gridOverview_ReservePaymentBreakout.Selected.Rows[0];
        Claimant claimant1 = (Claimant) null;
        int num3 = -1;
        string empty1 = string.Empty;
        string empty2 = string.Empty;
        int num4 = -1;
        int num5 = -1;
        int num6 = -1;
        string empty3 = string.Empty;
        string empty4 = string.Empty;
        string empty5 = string.Empty;
        Guid guid = new Guid();
        string empty6 = string.Empty;
        Decimal num7 = 0M;
        Decimal num8 = 0M;
        Decimal num9 = 0M;
        Guid g = new Guid(row.Cells["ClaimantGuid"].Value.ToString());
        foreach (Claimant claimant2 in (Collection<Claimant>) this.CurrentClaim.Claimants)
        {
          if (claimant2.ClaimantGuid.Equals(g))
          {
            claimant1 = claimant2;
            break;
          }
        }
        string str1 = row.ParentRow.Cells["ClaimantName"].Value.ToString();
        string str2 = row.Cells["ResPayTypeDescription"].Value.ToString();
        if (row.Cells["ResPaySubTypeDescription"].Value != DBNull.Value)
          empty3 = row.Cells["ResPaySubTypeDescription"].Value.ToString();
        if (row.Cells["CoverageType"].Value != DBNull.Value)
          empty4 = row.Cells["CoverageType"].Value.ToString();
        if (row.Cells["CoverageTypeDescription"].Value != DBNull.Value)
          empty5 = row.Cells["CoverageTypeDescription"].Value.ToString();
        if (row.Cells["ResPayTypeId"].Value != DBNull.Value)
          num3 = (int) row.Cells["ResPayTypeId"].Value;
        if (row.Cells["ResPaySubTypeId"].Value != DBNull.Value)
          num4 = (int) row.Cells["ResPaySubTypeId"].Value;
        if (row.Cells["CoverageTypeId"].Value != DBNull.Value)
          num5 = (int) row.Cells["CoverageTypeId"].Value;
        if (row.Cells["CoverageTypeDescriptionId"].Value != DBNull.Value)
          num6 = (int) row.Cells["CoverageTypeDescriptionId"].Value;
        if (row.Cells["ChildLineGuid"].Value != DBNull.Value)
          guid = new Guid(row.Cells["ChildLineGuid"].Value.ToString());
        if (row.Cells["ChildLineName"].Value != DBNull.Value)
          empty6 = row.Cells["ChildLineName"].Value.ToString();
        if (row.Cells["TotalReserve"].Value != DBNull.Value)
          num7 = (Decimal) row.Cells["TotalReserve"].Value;
        if (row.Cells["TotalPayments"].Value != DBNull.Value)
          num8 = (Decimal) row.Cells["TotalPayments"].Value;
        if (row.Cells["RemainingReserves"].Value != DBNull.Value)
          num9 = (Decimal) row.Cells["RemainingReserves"].Value;
        bool flag = this._fortegraPackageLinesSet.Contains(this.CurrentClaim.PolicyInformation.LineName);
        if (string.IsNullOrEmpty(empty6) & flag)
        {
          int num10 = (int) MessageBox.Show("You cannot modify reserve that does not have a child line and is on a package policy.", "Cannot modify reserve!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          using (Fortegra_FormModifyReserve form = (Fortegra_FormModifyReserve) ObjectFactory.Instance.CreateForm(typeof (Fortegra_FormModifyReserve), new object[17]
          {
            (object) g,
            (object) this.CurrentClaim.ClaimNumber,
            (object) str1,
            (object) str2,
            (object) empty3,
            (object) empty4,
            (object) empty5,
            (object) guid,
            (object) empty6,
            (object) num3,
            (object) num4,
            (object) num5,
            (object) num6,
            (object) num7,
            (object) num8,
            (object) num9,
            (object) claimant1
          }))
          {
            this.OnModifyReserveFormShown((FormModifyReserve) form);
            if (form.ShowDialog() != DialogResult.OK)
              return;
            this.CurrentClaim.ReloadClaim();
            this.DisplayClaim();
          }
        }
      }
    }
  }

  private void SaveCustomClaimData()
  {
    DefaultDatabase.ExecuteNonQuery("Fortegra_SaveCustomClaimData", new object[4]
    {
      (object) "@ClaimId",
      (object) this.CurrentClaim.ClaimId.Value,
      (object) "@ExternalReferenceNo",
      (object) ((Control) this.txtExternalRef).Text
    });
  }

  private void HookupClaimEvents()
  {
    if (this.CurrentClaim == null)
      return;
    this.CurrentClaim.BeforeSaveClaimCommitted += new EventHandler<CancelEventArgs>(this.ClaimBeforeSaveHandler);
  }

  private void UnHookupClaimEvents()
  {
    if (this.CurrentClaim == null)
      return;
    this.CurrentClaim.BeforeSaveClaimCommitted -= new EventHandler<CancelEventArgs>(this.ClaimBeforeSaveHandler);
  }

  private void LoadFortegraData()
  {
    int? claimId = this.CurrentClaim.ClaimId;
    int num = 0;
    if (!(claimId.GetValueOrDefault() > num & claimId.HasValue))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.Fortegra_GetCustomClaimData", new object[2]
    {
      (object) "@ClaimId",
      (object) this.CurrentClaim.ClaimId
    });
    if (dataTable.Rows.Count > 0)
    {
      DataRow row = dataTable.Rows[0];
      ((Control) this.txtExternalRef).Text = !Utility.IsNull(row["ExternalReferenceNo"]) ? row["ExternalReferenceNo"].ToString() : string.Empty;
    }
    DataTable source = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.Fortegra_GetPackageLineList");
    this._fortegraPackageLinesSet = new HashSet<string>();
    foreach (DataRow dataRow in source.AsEnumerable())
      this._fortegraPackageLinesSet.Add(dataRow["PackageLine"].ToString());
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("Claimants", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClaimantName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Claimants_ReservePaymentBreakout");
    UltraGridBand ultraGridBand2 = new UltraGridBand("Claimants_ReservePaymentBreakout", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClaimantName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ResPayTypeDescription");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPaySubTypeDescription");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CoverageTypeDescription");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("TotalReserve");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("TotalPayments");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("RemainingReserves");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("ExpenseList", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("UAExpenseId");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ClaimId");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ExpenseDescription");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AutomationCode");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Automated");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ExpenseId");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ARCreated");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("DateARCreated");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ARCreatedBy");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Waived");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("WaivedBy");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("DateWaived");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Hours");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("HourlyRate");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("HourlyAmount");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("EquipmentRate");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("EquipmentAmount");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("OtherCost");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("OtherCount");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("OtherAmount");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("TotalAmount");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Fortegra_FormClaims));
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("", -1);
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    this.txtExternalRef = new MGATextBox();
    this.label11 = new Label();
    ((ISupportInitialize) this.gridOverview_ReservePaymentBreakout).BeginInit();
    ((ISupportInitialize) this.gridUnallocatedExpenses).BeginInit();
    ((ISupportInitialize) this.gridIncurred).BeginInit();
    ((Control) this.tabPageClaimOverview).SuspendLayout();
    ((ISupportInitialize) this.dateTimeOverview_LossDate).BeginInit();
    this.groupBox3.SuspendLayout();
    ((ISupportInitialize) this.gridClaimStatusLog).BeginInit();
    ((ISupportInitialize) this.comboAdjusterAssigned).BeginInit();
    ((ISupportInitialize) this.tabControlClaim).BeginInit();
    ((Control) this.tabControlClaim).SuspendLayout();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.textOverview_Company).BeginInit();
    ((ISupportInitialize) this.textOverview_Producer).BeginInit();
    ((ISupportInitialize) this.textOverview_Insured).BeginInit();
    ((ISupportInitialize) this.textOverview_PolicyNumber).BeginInit();
    ((ISupportInitialize) this.textOverview_ControlNumber).BeginInit();
    ((ISupportInitialize) this.textOverview_Line).BeginInit();
    ((ISupportInitialize) this.textOverview_EffectiveExpiration).BeginInit();
    this.groupBox5.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.groupBox4.SuspendLayout();
    this.groupIncurred.SuspendLayout();
    ((ISupportInitialize) this.gridOverview_Claimants).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.textOverview_EnteredBy).BeginInit();
    ((ISupportInitialize) this.textOverview_ClaimNumber).BeginInit();
    ((ISupportInitialize) this.dateTimeOverview_DateEntered).BeginInit();
    ((ISupportInitialize) this.textOverview_Comments).BeginInit();
    ((ISupportInitialize) this.comboClaim_CatastropheCode).BeginInit();
    ((Control) this.ultraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.comboClaim_CatastropheCode2).BeginInit();
    this.groupBox7.SuspendLayout();
    ((ISupportInitialize) this.textDriverLastName).BeginInit();
    ((ISupportInitialize) this.textDriverFirstName).BeginInit();
    ((ISupportInitialize) this.gridDrivers).BeginInit();
    ((ISupportInitialize) this.comboAccidentType).BeginInit();
    ((ISupportInitialize) this.txtExternalRef).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridOverview_ReservePaymentBreakout, "ReservePaymentBreakoutContext");
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 77;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 561;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand1.GroupHeadersVisible = false;
    ultraGridBand2.CardSettings.AllowLabelSizing = false;
    ultraGridBand2.CardSettings.AllowSizing = false;
    ultraGridBand2.CardSettings.Width = 100;
    ultraGridBand2.CardView = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 71;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 33;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 29;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Reserve/Payment Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 87;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 4;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 35;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Reserve/Payment Sub Type";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Width = 97;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 6;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 33;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 7;
    ultraGridColumn11.Width = 64 /*0x40*/;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 8;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 51;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Coverage Type Description";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 9;
    ultraGridColumn13.Width = 91;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Format = "c";
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Total Reserve";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 10;
    ultraGridColumn14.Width = 52;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Format = "c";
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Total Payments";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 11;
    ultraGridColumn15.Width = 58;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Format = "c";
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Remaining Reserves";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 12;
    ultraGridColumn16.Width = 71;
    ultraGridBand2.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((AppearanceBase) appearance2).BackColor = Color.LightSteelBlue;
    ultraGridBand2.Override.CardCaptionAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.Transparent;
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowSelectorHeaderStyle = (RowSelectorHeaderStyle) 1;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance12;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraGridBase) this.gridOverview_ReservePaymentBreakout).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridOverview_ReservePaymentBreakout).Size = new Size(580, 427);
    ((Control) this.gridOverview_ReservePaymentBreakout).TabIndex = 10;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridUnallocatedExpenses, "ULAEGridContext");
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 47;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 22;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 35;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 21;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 1;
    ultraGridColumn20.Width = 63 /*0x3F*/;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 3;
    ultraGridColumn21.Width = 185;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 23;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 83;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 5;
    ultraGridColumn23.Width = 63 /*0x3F*/;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 24;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 41;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 25;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 143;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 2;
    ultraGridColumn26.Width = 110;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Rec. Created";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 6;
    ultraGridColumn27.Width = 72;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Rec. Date";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 7;
    ultraGridColumn28.Width = 72;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "AR Created By";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 9;
    ultraGridColumn29.Width = 149;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 11;
    ultraGridColumn30.Width = 72;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Waived By";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 15;
    ultraGridColumn31.Width = 90;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Date Waived";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 13;
    ultraGridColumn32.Width = 72;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 4;
    ultraGridColumn33.Width = 332;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 8;
    ultraGridColumn34.Width = 48 /*0x30*/;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn35.Format = "c";
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Hourly Rate";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 10;
    ultraGridColumn35.Width = 71;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn36.Format = "c";
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Hourly Total";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 12;
    ultraGridColumn36.Width = 71;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Equip. Rate";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 14;
    ultraGridColumn37.Width = 71;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn38.Format = "c";
    ((HeaderBase) ultraGridColumn38.Header).Caption = "Equip. Total";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn38.Width = 74;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Other Rate";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 17;
    ultraGridColumn39.Width = 71;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Other Amt.";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 18;
    ultraGridColumn40.Width = 71;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn41.Format = "c";
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Other Total";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 19;
    ultraGridColumn41.Width = 71;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn42.Format = "c";
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Total";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 20;
    ultraGridColumn42.Width = 110;
    ultraGridBand3.Columns.AddRange(new object[26]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ultraGridBand3.GroupHeadersVisible = false;
    ultraGridBand3.LevelCount = 2;
    ultraGridBand3.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance14).BackColor = Color.LightSteelBlue;
    ultraGridBand3.Override.SummaryFooterAppearance = (AppearanceBase) appearance14;
    ultraGridBand3.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.LightSteelBlue;
    ultraGridBand3.Override.SummaryValueAppearance = (AppearanceBase) appearance15;
    ultraGridBand3.Override.TipStyleCell = (TipStyle) 2;
    ultraGridBand3.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BackColor = Color.Transparent;
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    ((AppearanceBase) appearance22).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance22).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridUnallocatedExpenses).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridUnallocatedExpenses).Size = new Size(971, 1149);
    ((AppearanceBase) appearance24).BackColor = Color.Transparent;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Appearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance28).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.Transparent;
    ((AppearanceBase) appearance29).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance30).BackColor = Color.Transparent;
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance31).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridIncurred).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridIncurred).TabIndex = 11;
    ((Control) this.tabPageClaimOverview).Location = new Point(1, 22);
    ((Control) this.tabPageClaimOverview).Size = new Size(974, 747);
    ((Control) this.tabPageClaimLimitsLiabilities).Size = new Size(974, 747);
    ((Control) this.tabPageClaimReservePayments).Size = new Size(974, 747);
    ((Control) this.dateTimeOverview_LossDate).Location = new Point(120, 86);
    ((Control) this.dateTimeOverview_LossDate).TabIndex = 4;
    this.groupBox3.Controls.Add((Control) this.txtExternalRef);
    this.groupBox3.Controls.Add((Control) this.label11);
    this.groupBox3.Size = new Size(362, 264);
    this.groupBox3.Controls.SetChildIndex((Control) this.label2, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label3, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label4, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label5, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label6, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.textOverview_EnteredBy, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.dateTimeOverview_LossDate, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.dateTimeOverview_DateEntered, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.textOverview_Comments, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label55, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label56, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.comboAdjusterAssigned, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.comboClaim_CatastropheCode, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.textOverview_ClaimNumber, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.comboClaim_CatastropheCode2, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.label11, 0);
    this.groupBox3.Controls.SetChildIndex((Control) this.txtExternalRef, 0);
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Appearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance34).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance35).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance36).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance37).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance39).BackColor = Color.Transparent;
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance40).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridClaimStatusLog).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.gridClaimStatusLog).Size = new Size(952, 1173);
    ((Control) this.comboAdjusterAssigned).Location = new Point(120, 157);
    ((Control) this.comboAdjusterAssigned).TabIndex = 7;
    ((Control) this.tabControlClaim).Location = new Point(0, 46);
    ((Control) this.tabControlClaim).Size = new Size(976, 770);
    ((UltraTabControlBase) this.tabControlClaim).TabPageMargins.ForceSerialization = true;
    this.groupBox1.Location = new Point(10, 276);
    this.label1.Location = new Point(9, 46);
    this.label1.TabIndex = 0;
    this.label9.Location = new Point(9, 23);
    this.label8.TabIndex = 0;
    this.label7.TabIndex = 0;
    this.label10.TabIndex = 0;
    ((Control) this.textOverview_Company).TabIndex = 19;
    ((Control) this.textOverview_Producer).TabIndex = 17;
    ((Control) this.textOverview_Insured).TabIndex = 16 /*0x10*/;
    ((Control) this.textOverview_PolicyNumber).TabIndex = 15;
    ((Control) this.textOverview_ControlNumber).TabIndex = 14;
    ((Control) this.textOverview_Line).TabIndex = 21;
    this.label51.TabIndex = 0;
    ((Control) this.textOverview_EffectiveExpiration).TabIndex = 23;
    this.label63.TabIndex = 0;
    this.groupBox2.Location = new Point(10, 458);
    this.groupBox2.Size = new Size(362, 331);
    this.groupBox2.TabIndex = 9;
    this.groupBox4.Size = new Size(592, 453);
    this.groupBox4.TabIndex = 10;
    this.groupIncurred.Location = new Point(379, 473);
    this.groupIncurred.TabIndex = 11;
    ((AppearanceBase) appearance42).BackColor = Color.Transparent;
    ((AppearanceBase) appearance42).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Appearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance43).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance43).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance43).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance44).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance45).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance46;
    ((AppearanceBase) appearance47).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance47;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance48).BackColor = Color.Transparent;
    ((AppearanceBase) appearance48).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance49).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.gridOverview_Claimants).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((Control) this.gridOverview_Claimants).Location = new Point(12, 20);
    ((Control) this.gridOverview_Claimants).Size = new Size(344, 275);
    ((Control) this.gridOverview_Claimants).TabIndex = 9;
    ((SettingsBase) this.ultraToolbarsManager1.MenuSettings).ForceSerialization = true;
    ((AppearanceBase) appearance51).Image = componentResourceManager.GetObject("appearance3.Image");
    ((SettingsBase) this.ultraToolbarsManager1.Ribbon.QuickAccessToolbar.Settings).Appearance = (AppearanceBase) appearance51;
    this.ultraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance52).BackColor2 = Color.White;
    ((AppearanceBase) appearance52).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance52).BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance52;
    this.ultraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    this.label6.Location = new Point(8, 64 /*0x40*/);
    this.label6.TabIndex = 0;
    this.label5.Location = new Point(8, 110);
    this.label5.TabIndex = 0;
    this.label4.Location = new Point(8, 133);
    this.label4.TabIndex = 0;
    this.label3.Location = new Point(8, 86);
    this.label3.TabIndex = 0;
    this.label2.Location = new Point(8, 18);
    ((Control) this.textOverview_EnteredBy).Location = new Point(120, 133);
    ((Control) this.textOverview_EnteredBy).TabIndex = 6;
    ((Control) this.textOverview_ClaimNumber).TabStop = true;
    ((Control) this.dateTimeOverview_DateEntered).Location = new Point(120, 110);
    ((Control) this.dateTimeOverview_DateEntered).TabIndex = 5;
    ((Control) this.textOverview_Comments).Location = new Point(120, 181);
    ((Control) this.textOverview_Comments).TabIndex = 8;
    ((Control) this.textOverview_Comments).TabStop = true;
    this.label55.Location = new Point(8, 178);
    this.label55.TabIndex = 0;
    this.label56.Location = new Point(8, 156);
    this.label56.TabIndex = 0;
    ((Control) this.comboClaim_CatastropheCode).Location = new Point(120, 63 /*0x3F*/);
    ((Control) this.comboClaim_CatastropheCode).TabIndex = 3;
    ((Control) this.ultraTabPageControl5).Size = new Size(974, 747);
    ((AppearanceBase) appearance53).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance53).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Appearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand4.ColHeadersVisible = false;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance54).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance54).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance55).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance55;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance56).BackColor = SystemColors.Window;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance56;
    ((AppearanceBase) appearance57).BorderColor = Color.Silver;
    ((AppearanceBase) appearance57).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance58).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance58).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance58).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance58).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance58).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance58;
    ((AppearanceBase) appearance59).TextHAlignAsString = "Left";
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 3;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance61).BorderColor = Color.Silver;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance62).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.comboClaim_CatastropheCode2).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.comboClaim_CatastropheCode2).Location = new Point(120, 63 /*0x3F*/);
    ((Control) this.comboClaim_CatastropheCode2).TabIndex = 3;
    ((AppearanceBase) appearance63).BackColor = Color.White;
    ((AppearanceBase) appearance63).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance64).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance64).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance64).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance65).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance66).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance67).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance68;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance69).BackColor = Color.Transparent;
    ((AppearanceBase) appearance69).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance69;
    ((AppearanceBase) appearance70).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance70).BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance71;
    ((UltraGridBase) this.gridDrivers).DisplayLayout.ScrollBarLook = scrollBarLook6;
    ((AppearanceBase) appearance72).BackColor = Color.White;
    ((AppearanceBase) appearance72).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance72).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtExternalRef).Appearance = (AppearanceBase) appearance72;
    ((Control) this.txtExternalRef).BackColor = Color.White;
    ((Control) this.txtExternalRef).Location = new Point(120, 40);
    ((TextEditorControlBase) this.txtExternalRef).MaxLength = 100;
    this.txtExternalRef.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtExternalRef).Name = "txtExternalRef";
    ((Control) this.txtExternalRef).Size = new Size(217, 20);
    ((Control) this.txtExternalRef).TabIndex = 2;
    ((UltraControlBase) this.txtExternalRef).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtExternalRef).UseOsThemes = (DefaultableBoolean) 2;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(8, 40);
    this.label11.Name = "label11";
    this.label11.Size = new Size(86, 13);
    this.label11.TabIndex = 0;
    this.label11.Text = "External Ref. #:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(976, 816);
    this.Name = nameof (Fortegra_FormClaims);
    this.Text = "Claims Entry (Fortegra)";
    this.Load += new EventHandler(this.Fortegra_FormClaims_Load);
    ((ISupportInitialize) this.gridOverview_ReservePaymentBreakout).EndInit();
    ((ISupportInitialize) this.gridUnallocatedExpenses).EndInit();
    ((ISupportInitialize) this.gridIncurred).EndInit();
    ((Control) this.tabPageClaimOverview).ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeOverview_LossDate).EndInit();
    this.groupBox3.ResumeLayout(false);
    this.groupBox3.PerformLayout();
    ((ISupportInitialize) this.gridClaimStatusLog).EndInit();
    ((ISupportInitialize) this.comboAdjusterAssigned).EndInit();
    ((ISupportInitialize) this.tabControlClaim).EndInit();
    ((Control) this.tabControlClaim).ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    ((ISupportInitialize) this.textOverview_Company).EndInit();
    ((ISupportInitialize) this.textOverview_Producer).EndInit();
    ((ISupportInitialize) this.textOverview_Insured).EndInit();
    ((ISupportInitialize) this.textOverview_PolicyNumber).EndInit();
    ((ISupportInitialize) this.textOverview_ControlNumber).EndInit();
    ((ISupportInitialize) this.textOverview_Line).EndInit();
    ((ISupportInitialize) this.textOverview_EffectiveExpiration).EndInit();
    this.groupBox5.ResumeLayout(false);
    this.groupBox5.PerformLayout();
    this.groupBox2.ResumeLayout(false);
    this.groupBox4.ResumeLayout(false);
    this.groupIncurred.ResumeLayout(false);
    ((ISupportInitialize) this.gridOverview_Claimants).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.textOverview_EnteredBy).EndInit();
    ((ISupportInitialize) this.textOverview_ClaimNumber).EndInit();
    ((ISupportInitialize) this.dateTimeOverview_DateEntered).EndInit();
    ((ISupportInitialize) this.textOverview_Comments).EndInit();
    ((ISupportInitialize) this.comboClaim_CatastropheCode).EndInit();
    ((Control) this.ultraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.comboClaim_CatastropheCode2).EndInit();
    this.groupBox7.ResumeLayout(false);
    this.groupBox7.PerformLayout();
    ((ISupportInitialize) this.textDriverLastName).EndInit();
    ((ISupportInitialize) this.textDriverFirstName).EndInit();
    ((ISupportInitialize) this.gridDrivers).EndInit();
    ((ISupportInitialize) this.comboAccidentType).EndInit();
    ((ISupportInitialize) this.txtExternalRef).EndInit();
    this.ResumeLayout(false);
  }
}
