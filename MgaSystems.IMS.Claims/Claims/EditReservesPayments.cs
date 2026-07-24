// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims.EditReservesPayments
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Security;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims;

[SecureResource("6d04b1b5-9d11-4c19-84eb-c5b3604c92d3", "Allow Editing Single Coverage or Reserve Type", "Allows the user to edit the coverage or reserve type of an existing reserve or payment without changing all related reserves and payments.", "Claims")]
public class EditReservesPayments : Form
{
  public const string EditSingleRowSecurity = "6d04b1b5-9d11-4c19-84eb-c5b3604c92d3";
  private DataRow[] _coverageSubTypes;
  private DataRow[] _resPaySubTypes;
  private const string EntryTypePayment = "Payment";
  private const string EntryTypeReserve = "Reserve";
  private const string EntryTypeOffset = "Reserve-(PAYMENT OFFSET)";
  private IContainer components;
  protected UltraGrid gridClaimants_ReservePayments;
  protected UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _EditReservesPayments_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _EditReservesPayments_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _EditReservesPayments_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _EditReservesPayments_Toolbars_Dock_Area_Top;
  private UltraRadioButton EditSingleBtn;
  private UltraRadioButton EditAllBtn;
  private UltraRadioButtonGroupManager modeGroupManager;
  protected GroupBox ModeGroupBox;

  protected PaymentReserve CurrentResPay { get; }

  protected Claimant CurrentClaimant { get; }

  protected Claim CurrentClaim { get; }

  protected virtual string CoverageTypeProc => "dbo.spClaims_GetCoverageTypes";

  protected virtual string CoverageTypeDescProc => "dbo.spClaims_GetCoverageTypeDescriptions";

  protected virtual string ResPayTypeProc => "dbo.spClaims_GetReservePaymentTypes";

  protected virtual string ResPaySubtypeProc => "dbo.spClaims_GetReservePaymentSubTypes";

  protected virtual object[] CoverageTypeProcParams
  {
    get
    {
      return new object[2]
      {
        (object) "@ShowAll",
        (object) false
      };
    }
  }

  protected virtual object[] CoverageTypeDescProcParams => new object[0];

  protected virtual object[] ResPayTypeProcParams => new object[0];

  protected virtual object[] ResPaySubtypeProcParams => new object[0];

  public EditReservesPayments(PaymentReserve paymentReserve, Claimant claimant, Claim claim)
  {
    this.InitializeComponent();
    ((Control) this.EditSingleBtn).Enabled = SecurityManager.Instance.AssertPermission("6d04b1b5-9d11-4c19-84eb-c5b3604c92d3");
    this.CurrentResPay = paymentReserve;
    this.CurrentClaimant = claimant;
    this.CurrentClaim = claim;
  }

  private void EditReservesPayments_Load(object sender, EventArgs e)
  {
    this.CreateReservePaymentDataset();
    this.LoadCoverageTypes();
    this.LoadCoverageSubTypes();
    this.LoadResPayTypes();
    this.LoadResPaySubTypes();
    this.HookupEvents();
  }

  protected virtual void HookupEvents()
  {
    this.gridClaimants_ReservePayments.AfterCellUpdate += new CellEventHandler(this.gridClaimants_ReservePayments_AfterCellUpdate);
  }

  protected virtual void UnhookEvents()
  {
    this.gridClaimants_ReservePayments.AfterCellUpdate -= new CellEventHandler(this.gridClaimants_ReservePayments_AfterCellUpdate);
  }

  private void EditSingleRow(
    UltraGridCell changedCell,
    object newCoverageType,
    object newCoverageSubType,
    object newReserveType,
    object newReserveSubType)
  {
    if (!SecurityManager.Instance.AssertPermission("6d04b1b5-9d11-4c19-84eb-c5b3604c92d3"))
    {
      int num = (int) MessageBox.Show("You do not have the security necessary to edit a reserve or payment without editing related reserves and payments", "Not Authorized!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      changedCell.Value = changedCell.OriginalValue;
    }
    else
    {
      UltraGridRow row = changedCell.Row;
      this.LoadValidCoverageSubTypes(row);
      this.LoadValidResPaySubTypes(row);
      this.ChangeCorrespondingReductions(row, newCoverageType, newCoverageSubType, newReserveType, newReserveSubType);
      this.ChangeCorrespondingPayments(row, newCoverageType, newCoverageSubType, newReserveType, newReserveSubType);
    }
  }

  private void ChangeCorrespondingPayments(
    UltraGridRow changedRow,
    object newCoverageType,
    object newCoverageSubType,
    object newReserveType,
    object newReserveSubType)
  {
    int? resPayId = GridExtensions.Field<int?>(changedRow, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayId);
    if (!(GridExtensions.Field<string>(changedRow, EditReservesPayments.EditReservesPaymentsGridKeys.EntryType) == "Reserve-(PAYMENT OFFSET)"))
      return;
    int? nullable1 = resPayId;
    int num = 0;
    if (nullable1.GetValueOrDefault() == num & nullable1.HasValue)
      return;
    UltraGridRow row1 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridClaimants_ReservePayments).Rows).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (row =>
    {
      int valueOrDefault1 = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.CorrespondingReduction).GetValueOrDefault();
      int? nullable2 = resPayId;
      int valueOrDefault2 = nullable2.GetValueOrDefault();
      return valueOrDefault1 == valueOrDefault2 & nullable2.HasValue;
    }));
    if (row1 == null)
      return;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType].Value = newCoverageType;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription].Value = newCoverageSubType;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType].Value = newReserveType;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType].Value = newReserveSubType;
    this.LoadValidCoverageSubTypes(row1);
    this.LoadValidResPaySubTypes(row1);
  }

  private void ChangeCorrespondingReductions(
    UltraGridRow changedRow,
    object newCoverageType,
    object newCoverageSubType,
    object newReserveType,
    object newReserveSubType)
  {
    int correspondingReduction = GridExtensions.Field<int?>(changedRow, EditReservesPayments.EditReservesPaymentsGridKeys.CorrespondingReduction).GetValueOrDefault();
    if (correspondingReduction == 0)
      return;
    UltraGridRow row1 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridClaimants_ReservePayments).Rows).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayId).GetValueOrDefault() == correspondingReduction));
    if (row1 == null)
      return;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType].Value = newCoverageType;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription].Value = newCoverageSubType;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType].Value = newReserveType;
    row1.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType].Value = newReserveSubType;
    this.LoadValidCoverageSubTypes(row1);
    this.LoadValidResPaySubTypes(row1);
  }

  private void EditAllRows(
    object newCoverageType,
    object newCoverageSubType,
    object newReserveType,
    object newReserveSubType)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
    {
      row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType].Value = newCoverageType;
      row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription].Value = newCoverageSubType;
      row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType].Value = newReserveType;
      row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType].Value = newReserveSubType;
      this.LoadValidCoverageSubTypes(row);
      this.LoadValidResPaySubTypes(row);
    }
  }

  private void gridClaimants_ReservePayments_AfterCellUpdate(object sender, CellEventArgs e)
  {
    UltraGridRow row = e.Cell.Row;
    object newCoverageType = (object) GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType) ?? (object) DBNull.Value;
    object newCoverageSubType = (object) GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription) ?? (object) DBNull.Value;
    object newReserveType = (object) GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType) ?? (object) DBNull.Value;
    object newReserveSubType = (object) GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType) ?? (object) DBNull.Value;
    try
    {
      this.UnhookEvents();
      if (((UltraToggleEditorBase) this.EditSingleBtn).Checked)
      {
        this.EditSingleRow(e.Cell, newCoverageType, newCoverageSubType, newReserveType, newReserveSubType);
      }
      else
      {
        ((UltraToggleEditorBase) this.EditAllBtn).Checked = true;
        this.EditAllRows(newCoverageType, newCoverageSubType, newReserveType, newReserveSubType);
      }
    }
    finally
    {
      this.HookupEvents();
    }
  }

  private void Save()
  {
    ((UltraGridBase) this.gridClaimants_ReservePayments).ActiveRow = (UltraGridRow) null;
    if (!this.ValidateForm() || MessageBox.Show(Resources.EDITRESPAY_SAVECHANGES, "Save changes?", MessageBoxButtons.YesNo) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "TRUNCATE TABLE dbo.tblEditReservePayments_Bulk");
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.tblEditReservePayments_Bulk");
      foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.CurrentClaimant.ReservesAndPayments)
      {
        PaymentReserve resPay = reservesAndPayment;
        UltraGridRow row1 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridClaimants_ReservePayments).Rows).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (row =>
        {
          int? nullable = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayId);
          int valueOrDefault3 = nullable.GetValueOrDefault();
          nullable = resPay.ReservePaymentId;
          int valueOrDefault4 = nullable.GetValueOrDefault();
          return valueOrDefault3 == valueOrDefault4;
        }));
        int? nullable1 = resPay.ReservePaymentId;
        int valueOrDefault = nullable1.GetValueOrDefault();
        if (row1 != null && valueOrDefault != 0)
        {
          int? typeValue1 = this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType);
          int? typeValue2 = this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription);
          nullable1 = this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType);
          int newResPayTypeId = nullable1 ?? resPay.ReservePaymentTypeId;
          int? typeValue3 = this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType);
          DataRow row2 = dataTable.NewRow();
          row2["ResPayId"] = (object) valueOrDefault;
          row2["CoverageTypeId"] = (object) typeValue1 ?? (object) DBNull.Value;
          row2["CoverageTypeDescriptionId"] = (object) typeValue2 ?? (object) DBNull.Value;
          row2["ResPayTypeId"] = (object) newResPayTypeId;
          row2["ResPaySubTypeId"] = (object) typeValue3 ?? (object) DBNull.Value;
          row2["ResPayAmount"] = (object) resPay.ReservePaymentAmount;
          row2["DateCreated"] = (object) resPay.DateCreated;
          row2["CreatedByGuid"] = (object) resPay.CreatedByGuid;
          dataTable.Rows.Add(row2);
          this.LogAllChanges(resPay, valueOrDefault, typeValue1, typeValue2, newResPayTypeId, typeValue3);
        }
      }
      DefaultDatabase.ExecuteBulkInsert(dataTable, (SqlRowsCopiedEventHandler) null, SqlBulkCopyOptions.Default, "dbo.tblEditReservePayments_Bulk");
      DefaultDatabase.ExecuteNonQuery("dbo.spClaims_EditReservePayments");
      e.Transaction.Commit();
    }));
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void LogAllChanges(
    PaymentReserve resPay,
    int resPayId,
    int? newCoverageTypeId,
    int? newCoverageSubTypeId,
    int newResPayTypeId,
    int? newResPaySubTypeId)
  {
    int? nullable1 = newCoverageTypeId;
    int? coverageTypeId = resPay.CoverageTypeId;
    if (!(nullable1.GetValueOrDefault() == coverageTypeId.GetValueOrDefault() & nullable1.HasValue == coverageTypeId.HasValue))
      this.LogChange("coverage type ID", resPay.CoverageTypeId, newCoverageTypeId, resPayId);
    int? nullable2 = newCoverageSubTypeId;
    int? typeDescriptionId = resPay.CoverageTypeDescriptionId;
    if (!(nullable2.GetValueOrDefault() == typeDescriptionId.GetValueOrDefault() & nullable2.HasValue == typeDescriptionId.HasValue))
      this.LogChange("coverage sub-type ID", resPay.CoverageTypeDescriptionId, newCoverageSubTypeId, resPayId);
    if (newResPayTypeId != resPay.ReservePaymentTypeId)
      this.LogChange("reserve type ID", new int?(resPay.ReservePaymentTypeId), new int?(newResPayTypeId), resPayId);
    int? nullable3 = newResPaySubTypeId;
    int? paymentSubTypeId = resPay.ReservePaymentSubTypeId;
    if (nullable3.GetValueOrDefault() == paymentSubTypeId.GetValueOrDefault() & nullable3.HasValue == paymentSubTypeId.HasValue)
      return;
    this.LogChange("reserve sub-type ID", resPay.ReservePaymentSubTypeId, newResPaySubTypeId, resPayId);
  }

  private void LogChange(string modifiedField, int? oldValue, int? newValue, int resPayId)
  {
    string str1 = !oldValue.HasValue ? "{Null}" : oldValue.ToString();
    string str2 = !newValue.HasValue ? "{Null}" : newValue.ToString();
    string str3 = $"{CurrentUser.Instance.DisplayNameLastFirst} ({CurrentUser.Instance.UserGUID}) " + $"modified reserve/payment (ID: {resPayId}): {modifiedField} changed from \"{str1}\" to \"{str2}.";
    Claim currentClaim = this.CurrentClaim;
    int? claimId;
    int num;
    if (currentClaim == null)
    {
      num = 1;
    }
    else
    {
      claimId = currentClaim.ClaimId;
      num = !claimId.HasValue ? 1 : 0;
    }
    if (num != 0)
    {
      this.CurrentClaim?.LoggingList?.Add(str3);
    }
    else
    {
      string action = str3;
      claimId = this.CurrentClaim.ClaimId;
      int identifier = claimId.Value;
      Utility.LogAction(action, identifier);
    }
  }

  private Dictionary<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>> AssembleReservePaymentSets()
  {
    Dictionary<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>> dictionary = new Dictionary<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>>();
    foreach (PaymentReserve reservesAndPayment in (Collection<PaymentReserve>) this.CurrentClaimant.ReservesAndPayments)
    {
      PaymentReserve resPay = reservesAndPayment;
      EditReservesPayments.ResPayKey key = new EditReservesPayments.ResPayKey(resPay.CoverageTypeId, resPay.CoverageTypeDescriptionId, resPay.ReservePaymentTypeId, resPay.ReservePaymentSubTypeId);
      bool isUpdated = false;
      UltraGridRow row1 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridClaimants_ReservePayments).Rows).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (row =>
      {
        int? nullable = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayId);
        int valueOrDefault1 = nullable.GetValueOrDefault();
        nullable = resPay.ReservePaymentId;
        int valueOrDefault2 = nullable.GetValueOrDefault();
        return valueOrDefault1 == valueOrDefault2;
      }));
      if (row1 != null)
      {
        key = new EditReservesPayments.ResPayKey(this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType), this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription), this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType) ?? resPay.ReservePaymentTypeId, this.GetTypeValue(row1, EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType));
        isUpdated = true;
      }
      if (!dictionary.ContainsKey(key))
        dictionary[key] = new List<EditReservesPayments.ResPayState>();
      dictionary[key].Add(new EditReservesPayments.ResPayState(resPay.EntryType == PaymentReserveType.Reserve, resPay.IsPaymentReduction, isUpdated, resPay.ReservePaymentAmount));
    }
    return dictionary;
  }

  protected virtual bool ValidateForm()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
    {
      if (!this.ValidateRow(row))
        return false;
    }
    foreach (KeyValuePair<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>> reservePaymentSet in this.AssembleReservePaymentSets())
    {
      if (!this.CheckPaymentNotOrphaned(reservePaymentSet) || !this.CheckReserveIsSufficient(reservePaymentSet) || !this.CheckReservePermissions(reservePaymentSet))
        return false;
    }
    return true;
  }

  private bool CheckPaymentNotOrphaned(
    KeyValuePair<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>> resPaySet)
  {
    if (resPaySet.Value.Any<EditReservesPayments.ResPayState>((System.Func<EditReservesPayments.ResPayState, bool>) (state => state.IsReserve && !state.IsReduction)))
      return true;
    int num = (int) MessageBox.Show("This change would result in a payment without a matching reserve. Please first add the reserve, then move the payment to it.", "Cannot Save Edit!", MessageBoxButtons.OK);
    return false;
  }

  private bool CheckReserveIsSufficient(
    KeyValuePair<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>> resPaySet)
  {
    if (!(resPaySet.Value.Where<EditReservesPayments.ResPayState>((System.Func<EditReservesPayments.ResPayState, bool>) (state => state.IsReserve)).Sum<EditReservesPayments.ResPayState>((System.Func<EditReservesPayments.ResPayState, Decimal>) (state => state.Amount)) < 0M))
      return true;
    int num = (int) MessageBox.Show("This change would result in a net negative reserve. Please first increase the amount of the reserve.", "Cannot Save Edit!", MessageBoxButtons.OK);
    return false;
  }

  private bool CheckReservePermissions(
    KeyValuePair<EditReservesPayments.ResPayKey, List<EditReservesPayments.ResPayState>> resPaySet)
  {
    if (!resPaySet.Value.Any<EditReservesPayments.ResPayState>((System.Func<EditReservesPayments.ResPayState, bool>) (state => state.IsReserve && state.IsUpdated && !Utility.GetReserveLevelGuid(state.Amount))))
      return true;
    int num = (int) MessageBox.Show("One of the modified reserves exceeds the reserve amount you are authorized to modify.", "Cannot Save Edit!", MessageBoxButtons.OK);
    return false;
  }

  protected virtual bool ValidateRow(UltraGridRow row) => this.CheckAllHaveReserveType(row);

  private bool CheckAllHaveReserveType(UltraGridRow row)
  {
    if (this.GetTypeValue(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType).HasValue)
      return true;
    int num = (int) MessageBox.Show("You must select a reserve type for all displayed reserves/payments", "Cannot Save Edit!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected int? GetTypeValue(UltraGridRow row, string key)
  {
    int? nullable1 = GridExtensions.Field<int?>(row, key);
    int? nullable2 = nullable1;
    int num = 0;
    return !(nullable2.GetValueOrDefault() == num & nullable2.HasValue) ? nullable1 : new int?();
  }

  private DataTable CreateReservePaymentTable()
  {
    DataTable reservePaymentTable = new DataTable();
    reservePaymentTable.Columns.AddRange(new DataColumn[9]
    {
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.ResPayId, typeof (int)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.EntryType, typeof (string)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.Payee, typeof (string)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType, typeof (int)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType, typeof (int)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType, typeof (int)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription, typeof (int)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.ResPayAmount, typeof (Decimal)),
      new DataColumn(EditReservesPayments.EditReservesPaymentsGridKeys.CorrespondingReduction, typeof (int))
    });
    return reservePaymentTable;
  }

  private List<PaymentReserve> GetIncludedResPays()
  {
    return this.CurrentClaimant.ReservesAndPayments.Where<PaymentReserve>((System.Func<PaymentReserve, bool>) (resPay =>
    {
      int? coverageTypeId1 = resPay.CoverageTypeId;
      int? coverageTypeId2 = this.CurrentResPay.CoverageTypeId;
      if (coverageTypeId1.GetValueOrDefault() == coverageTypeId2.GetValueOrDefault() & coverageTypeId1.HasValue == coverageTypeId2.HasValue)
      {
        int? typeDescriptionId1 = resPay.CoverageTypeDescriptionId;
        int? typeDescriptionId2 = this.CurrentResPay.CoverageTypeDescriptionId;
        if (typeDescriptionId1.GetValueOrDefault() == typeDescriptionId2.GetValueOrDefault() & typeDescriptionId1.HasValue == typeDescriptionId2.HasValue && resPay.ReservePaymentTypeId == this.CurrentResPay.ReservePaymentTypeId)
        {
          int? paymentSubTypeId1 = resPay.ReservePaymentSubTypeId;
          int? paymentSubTypeId2 = this.CurrentResPay.ReservePaymentSubTypeId;
          if (paymentSubTypeId1.GetValueOrDefault() == paymentSubTypeId2.GetValueOrDefault() & paymentSubTypeId1.HasValue == paymentSubTypeId2.HasValue)
            return resPay.ReservePaymentId.HasValue;
        }
      }
      return false;
    })).ToList<PaymentReserve>();
  }

  private DataRow CreateResPayRow(
    DataTable resPayDt,
    PaymentReserve resPay,
    List<PaymentReserve> allResPays,
    List<int> allocatedReductions,
    ref List<int> reductions)
  {
    DataRow resPayRow = resPayDt.NewRow();
    resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayId] = (object) resPay.ReservePaymentId.GetValueOrDefault();
    resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.EntryType] = resPay.EntryType == PaymentReserveType.Reserve ? (resPay.IsPaymentReduction ? (object) "Reserve-(PAYMENT OFFSET)" : (object) "Reserve") : (object) "Payment";
    resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.Payee] = (object) resPay.PayeeName;
    resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType] = (object) resPay.ReservePaymentTypeId;
    DataRow dataRow1 = resPayRow;
    string resPaySubType = EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType;
    int? nullable1 = resPay.ReservePaymentSubTypeId;
    // ISSUE: variable of a boxed type
    __Boxed<int> valueOrDefault1 = (System.ValueType) nullable1.GetValueOrDefault();
    dataRow1[resPaySubType] = (object) valueOrDefault1;
    DataRow dataRow2 = resPayRow;
    string coverageType = EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType;
    nullable1 = resPay.CoverageTypeId;
    // ISSUE: variable of a boxed type
    __Boxed<int> valueOrDefault2 = (System.ValueType) nullable1.GetValueOrDefault();
    dataRow2[coverageType] = (object) valueOrDefault2;
    DataRow dataRow3 = resPayRow;
    string coverageTypeDescription = EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription;
    nullable1 = resPay.CoverageTypeId;
    // ISSUE: variable of a boxed type
    __Boxed<int> valueOrDefault3 = (System.ValueType) nullable1.GetValueOrDefault();
    dataRow3[coverageTypeDescription] = (object) valueOrDefault3;
    resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayAmount] = (object) resPay.ReservePaymentAmount;
    if ((string) resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.EntryType] == "Payment")
    {
      PaymentReserve paymentReserve = allResPays.FirstOrDefault<PaymentReserve>((System.Func<PaymentReserve, bool>) (offset => offset.IsPaymentReduction && -offset.ReservePaymentAmount == resPay.ReservePaymentAmount && !allocatedReductions.Contains(offset.ReservePaymentId.GetValueOrDefault())));
      int? nullable2;
      if (paymentReserve == null)
      {
        nullable1 = new int?();
        nullable2 = nullable1;
      }
      else
        nullable2 = paymentReserve.ReservePaymentId;
      nullable1 = nullable2;
      int valueOrDefault4 = nullable1.GetValueOrDefault();
      resPayRow[EditReservesPayments.EditReservesPaymentsGridKeys.CorrespondingReduction] = (object) valueOrDefault4;
      reductions.Add(valueOrDefault4);
    }
    return resPayRow;
  }

  protected virtual void CreateReservePaymentDataset()
  {
    DataTable reservePaymentTable = this.CreateReservePaymentTable();
    if (this.CurrentClaimant.ReservesAndPayments == null || this.CurrentClaimant.ReservesAndPayments.Count == 0)
      return;
    List<int> reductions = new List<int>();
    List<PaymentReserve> includedResPays = this.GetIncludedResPays();
    foreach (PaymentReserve resPay in includedResPays)
      reservePaymentTable.Rows.Add(this.CreateResPayRow(reservePaymentTable, resPay, includedResPays, reductions, ref reductions));
    ((UltraGridBase) this.gridClaimants_ReservePayments).DataSource = (object) reservePaymentTable;
    ((UltraGridBase) this.gridClaimants_ReservePayments).Rows[0].Activate();
  }

  protected UltraDropDown CreateTypeDropDown(
    DataTable data,
    string displayMember,
    string valueMember)
  {
    UltraDropDown typeDropDown = new UltraDropDown();
    ((UltraGridBase) typeDropDown).DataSource = (object) data;
    ((UltraDropDownBase) typeDropDown).DisplayMember = displayMember;
    ((UltraDropDownBase) typeDropDown).ValueMember = valueMember;
    ((UltraGridBase) typeDropDown).DisplayLayout.Bands[0].ColHeadersVisible = false;
    return typeDropDown;
  }

  protected void ValidateInitialDropdownValues(
    DataTable data,
    string dropdownColumn,
    string gridColumn)
  {
    data.PrimaryKey = new DataColumn[1]
    {
      data.Columns[dropdownColumn]
    };
    foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
    {
      UltraGridCell cell = row.Cells[gridColumn];
      if (!data.Rows.Contains(cell.Value))
        cell.Value = (object) DBNull.Value;
    }
  }

  protected virtual void LoadCoverageTypes()
  {
    DataTable data = DefaultDatabase.ExecuteDataTable(this.CoverageTypeProc, this.CoverageTypeProcParams);
    UltraDropDown typeDropDown = this.CreateTypeDropDown(data, EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageType, EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeId);
    UltraGridBand band = ((UltraGridBase) typeDropDown).DisplayLayout.Bands[0];
    band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeId].Hidden = true;
    band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeDescription].Hidden = true;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0].Columns[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType].ValueList = (IValueList) typeDropDown;
    this.ValidateInitialDropdownValues(data, EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeId, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType);
  }

  protected virtual void LoadCoverageSubTypes()
  {
    this._coverageSubTypes = DefaultDatabase.ExecuteDataTable(this.CoverageTypeDescProc, this.CoverageTypeDescProcParams).AsEnumerable().ToArray<DataRow>();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
      this.LoadValidCoverageSubTypes(row);
  }

  protected virtual void LoadValidCoverageSubTypes(UltraGridRow row)
  {
    row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription].ValueList = (IValueList) null;
    int? coverageType = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageType);
    List<DataRow> list = ((IEnumerable<DataRow>) this._coverageSubTypes).Where<DataRow>((System.Func<DataRow, bool>) (subType =>
    {
      int? nullable1 = subType.Field<int?>(EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeId);
      int? nullable2 = coverageType;
      return nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue;
    })).ToList<DataRow>();
    if (list.Count > 0)
    {
      UltraDropDown typeDropDown = this.CreateTypeDropDown(list.CopyToDataTable<DataRow>(), EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeDescription, EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeDescriptionId);
      UltraGridBand band = ((UltraGridBase) typeDropDown).DisplayLayout.Bands[0];
      band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeDescriptionId].Hidden = true;
      band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeId].Hidden = true;
      row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription].ValueList = (IValueList) typeDropDown;
    }
    if (!list.All<DataRow>((System.Func<DataRow, bool>) (type =>
    {
      int? nullable3 = ExtensionsMethods.FieldAs<int?>(type, EditReservesPayments.EditReservesPaymentsDropdownKeys.CoverageTypeDescriptionId, DataRowVersion.Current);
      int? nullable4 = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription);
      return !(nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() & nullable3.HasValue == nullable4.HasValue);
    })))
      return;
    row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.CoverageTypeDescription].Value = (object) DBNull.Value;
  }

  protected virtual void LoadResPayTypes()
  {
    DataTable data = DefaultDatabase.ExecuteDataTable(this.ResPayTypeProc, this.ResPayTypeProcParams);
    UltraDropDown typeDropDown = this.CreateTypeDropDown(data, EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPayTypeDescription, EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPayTypeId);
    UltraGridBand band = ((UltraGridBase) typeDropDown).DisplayLayout.Bands[0];
    band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPayTypeId].Hidden = true;
    band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.IsRecoveryType].Hidden = true;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Bands[0].Columns[EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType].ValueList = (IValueList) typeDropDown;
    this.ValidateInitialDropdownValues(data, EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPayTypeId, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType);
  }

  protected virtual void LoadResPaySubTypes()
  {
    this._resPaySubTypes = DefaultDatabase.ExecuteDataTable(this.ResPaySubtypeProc, this.ResPaySubtypeProcParams).AsEnumerable().ToArray<DataRow>();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridClaimants_ReservePayments).Rows)
      this.LoadValidResPaySubTypes(row);
  }

  protected virtual void LoadValidResPaySubTypes(UltraGridRow row)
  {
    row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType].ValueList = (IValueList) null;
    int? resPayType = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPayType);
    List<DataRow> list = ((IEnumerable<DataRow>) this._resPaySubTypes).Where<DataRow>((System.Func<DataRow, bool>) (subType =>
    {
      int? nullable1 = subType.Field<int?>(EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPayTypeId);
      int? nullable2 = resPayType;
      return nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue;
    })).ToList<DataRow>();
    if (list.Count > 0)
    {
      UltraDropDown typeDropDown = this.CreateTypeDropDown(list.CopyToDataTable<DataRow>(), EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPaySubTypeDescription, EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPaySubTypeId);
      UltraGridBand band = ((UltraGridBase) typeDropDown).DisplayLayout.Bands[0];
      band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPaySubTypeId].Hidden = true;
      band.Columns[EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPayTypeId].Hidden = true;
      row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType].ValueList = (IValueList) typeDropDown;
    }
    if (!list.All<DataRow>((System.Func<DataRow, bool>) (type =>
    {
      int? nullable3 = ExtensionsMethods.FieldAs<int?>(type, EditReservesPayments.EditReservesPaymentsDropdownKeys.ResPaySubTypeId, DataRowVersion.Current);
      int? nullable4 = GridExtensions.Field<int?>(row, EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType);
      return !(nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() & nullable3.HasValue == nullable4.HasValue);
    })))
      return;
    row.Cells[EditReservesPayments.EditReservesPaymentsGridKeys.ResPaySubType].Value = (object) DBNull.Value;
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "Cancel":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
      case "Save":
        this.Save();
        break;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ReservesPayments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPayId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntryTypeId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EntryType", -1, (object) null, 963782844, 0, 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CoverageTypeId");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CoverageType", -1, (object) null, 963782844, 4, 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CoverageTypeDescriptionId");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CoverageTypeDescription", -1, (object) null, 963782844, 5, 0, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ResPayTypeId");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPayType", -1, (object) null, 963782844, 2, 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ResPaySubTypeId");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ResPaySubType", -1, (object) null, 963782844, 3, 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ResPayAmount", -1, (object) null, 963782844, 6, 0);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DateCreated", -1, (object) null, 963782844, 7, 0);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CreatedByGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CreatedBy", -1, (object) null, 963782844, 8, 0);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Comments", -1, (object) null, 963782844, 9, 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Payee", -1, (object) null, 963782844, 1, 0);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("IsVoid");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("IsPaymentReduction");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("CorrespondingReduction", 0);
    UltraGridGroup ultraGridGroup = new UltraGridGroup("TopRow", 963782844);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Save");
    ButtonTool buttonTool2 = new ButtonTool("Cancel");
    ButtonTool buttonTool3 = new ButtonTool("Cancel");
    Appearance appearance14 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("Save");
    Appearance appearance15 = new Appearance();
    this.gridClaimants_ReservePayments = new UltraGrid();
    this._EditReservesPayments_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._EditReservesPayments_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._EditReservesPayments_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._EditReservesPayments_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ModeGroupBox = new GroupBox();
    this.EditSingleBtn = new UltraRadioButton();
    this.modeGroupManager = new UltraRadioButtonGroupManager(this.components);
    this.EditAllBtn = new UltraRadioButton();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    ((ISupportInitialize) this.gridClaimants_ReservePayments).BeginInit();
    this.ModeGroupBox.SuspendLayout();
    ((ISupportInitialize) this.EditSingleBtn).BeginInit();
    ((ISupportInitialize) this.modeGroupManager).BeginInit();
    ((ISupportInitialize) this.EditAllBtn).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 30;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 73;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Entry Type";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Width = 108;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 6;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 59;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Width = 145;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 10;
    ultraGridColumn6.Width = 111;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Sub-Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Width = (int) sbyte.MaxValue;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 14;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 52;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Reserve Type";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Width = 128 /*0x80*/;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 15;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 64 /*0x40*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Sub-Type";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Width = 128 /*0x80*/;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Width = 63 /*0x3F*/;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Date Created";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 8;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 142;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Created By";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 167;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.MaxLength = 5000;
    ultraGridColumn16.Width = 781;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 17;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ultraGridColumn18.Width = 116;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[21]
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
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "TopRow";
    ultraGridGroup.RowLayoutGroupInfo.LabelSpan = 1;
    ultraGridBand.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ultraGridBand.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridClaimants_ReservePayments).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridClaimants_ReservePayments).Dock = DockStyle.Fill;
    ((Control) this.gridClaimants_ReservePayments).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridClaimants_ReservePayments).Location = new Point(0, 46);
    ((Control) this.gridClaimants_ReservePayments).Name = "gridClaimants_ReservePayments";
    ((Control) this.gridClaimants_ReservePayments).Size = new Size(834, 415);
    ((Control) this.gridClaimants_ReservePayments).TabIndex = 2;
    ((UltraControlBase) this.gridClaimants_ReservePayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimants_ReservePayments).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._EditReservesPayments_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left).Location = new Point(0, 46);
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left).Name = "_EditReservesPayments_Toolbars_Dock_Area_Left";
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left).Size = new Size(0, 415);
    this._EditReservesPayments_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._EditReservesPayments_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right).Location = new Point(834, 46);
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right).Name = "_EditReservesPayments_Toolbars_Dock_Area_Right";
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right).Size = new Size(0, 415);
    this._EditReservesPayments_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._EditReservesPayments_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top).Name = "_EditReservesPayments_Toolbars_Dock_Area_Top";
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top).Size = new Size(834, 46);
    this._EditReservesPayments_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._EditReservesPayments_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom).Location = new Point(0, 461);
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom).Name = "_EditReservesPayments_Toolbars_Dock_Area_Bottom";
    ((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom).Size = new Size(834, 0);
    this._EditReservesPayments_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.ModeGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.ModeGroupBox.BackColor = SystemColors.Control;
    this.ModeGroupBox.Controls.Add((Control) this.EditSingleBtn);
    this.ModeGroupBox.Controls.Add((Control) this.EditAllBtn);
    this.ModeGroupBox.ForeColor = SystemColors.ControlText;
    this.ModeGroupBox.Location = new Point(94, 0);
    this.ModeGroupBox.Name = "ModeGroupBox";
    this.ModeGroupBox.Padding = new Padding(8);
    this.ModeGroupBox.Size = new Size(250, 46);
    this.ModeGroupBox.TabIndex = 8;
    this.ModeGroupBox.TabStop = false;
    this.ModeGroupBox.Text = "Edit Mode:";
    ((Control) this.EditSingleBtn).Dock = DockStyle.Fill;
    this.EditSingleBtn.GroupManager = this.modeGroupManager;
    ((Control) this.EditSingleBtn).Location = new Point(78, 21);
    ((Control) this.EditSingleBtn).Name = "EditSingleBtn";
    ((Control) this.EditSingleBtn).Size = new Size(164, 17);
    ((Control) this.EditSingleBtn).TabIndex = 9;
    ((Control) this.EditSingleBtn).TabStop = false;
    ((Control) this.EditSingleBtn).Text = "Edit single reserve/payment";
    ((UltraToggleEditorBase) this.EditAllBtn).Checked = true;
    ((Control) this.EditAllBtn).Dock = DockStyle.Left;
    this.EditAllBtn.GroupManager = this.modeGroupManager;
    ((Control) this.EditAllBtn).Location = new Point(8, 21);
    ((Control) this.EditAllBtn).Name = "EditAllBtn";
    ((Control) this.EditAllBtn).Size = new Size(70, 17);
    ((Control) this.EditAllBtn).TabIndex = 8;
    ((Control) this.EditAllBtn).Text = "Edit all";
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.LockToolbars = true;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(288, 232);
    ultraToolbar.FloatingSize = new Size(107, 90);
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((SettingsBase) ultraToolbar.Settings).UseLargeImages = (DefaultableBoolean) 2;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).Image = (object) Resources.cancel;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance15).Image = (object) Resources.Save;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(834, 461);
    this.Controls.Add((Control) this.ModeGroupBox);
    this.Controls.Add((Control) this.gridClaimants_ReservePayments);
    this.Controls.Add((Control) this._EditReservesPayments_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._EditReservesPayments_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._EditReservesPayments_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._EditReservesPayments_Toolbars_Dock_Area_Top);
    this.Name = nameof (EditReservesPayments);
    this.Text = "Edit Reserve or Coverage Type";
    this.Load += new EventHandler(this.EditReservesPayments_Load);
    ((ISupportInitialize) this.gridClaimants_ReservePayments).EndInit();
    this.ModeGroupBox.ResumeLayout(false);
    ((ISupportInitialize) this.EditSingleBtn).EndInit();
    ((ISupportInitialize) this.modeGroupManager).EndInit();
    ((ISupportInitialize) this.EditAllBtn).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  protected class ResPayKey : IEquatable<EditReservesPayments.ResPayKey>
  {
    public int? CoverageTypeId { get; }

    public int? CoverageTypeDescriptionId { get; }

    public int ReservePaymentTypeId { get; }

    public int? ReservePaymentSubTypeId { get; }

    public ResPayKey(
      int? coverageTypeId,
      int? coverageTypeDescriptionId,
      int reservePaymentTypeId,
      int? reservePaymentSubTypeId)
    {
      this.CoverageTypeId = coverageTypeId;
      this.CoverageTypeDescriptionId = coverageTypeDescriptionId;
      this.ReservePaymentTypeId = reservePaymentTypeId;
      this.ReservePaymentSubTypeId = reservePaymentSubTypeId;
    }

    public bool Equals(EditReservesPayments.ResPayKey key)
    {
      if (key != null)
      {
        int? coverageTypeId = key.CoverageTypeId;
        int? nullable1 = this.CoverageTypeId;
        if (coverageTypeId.GetValueOrDefault() == nullable1.GetValueOrDefault() & coverageTypeId.HasValue == nullable1.HasValue)
        {
          nullable1 = key.CoverageTypeDescriptionId;
          int? nullable2 = this.CoverageTypeDescriptionId;
          if (nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() & nullable1.HasValue == nullable2.HasValue && key.ReservePaymentTypeId == this.ReservePaymentTypeId)
          {
            nullable2 = key.ReservePaymentSubTypeId;
            nullable1 = this.ReservePaymentSubTypeId;
            return nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() & nullable2.HasValue == nullable1.HasValue;
          }
        }
      }
      return false;
    }

    public override bool Equals(object key) => this.Equals(key as EditReservesPayments.ResPayKey);

    public override int GetHashCode()
    {
      return (this.CoverageTypeId, this.CoverageTypeDescriptionId, this.ReservePaymentTypeId, this.ReservePaymentSubTypeId).GetHashCode();
    }
  }

  protected class ResPayState
  {
    public bool IsReserve { get; }

    public bool IsReduction { get; }

    public bool IsUpdated { get; }

    public Decimal Amount { get; }

    public ResPayState(bool isReserve, bool isReduction, bool isUpdated, Decimal amount)
    {
      this.IsReserve = isReserve;
      this.IsReduction = isReduction;
      this.IsUpdated = isUpdated;
      this.Amount = amount;
    }
  }

  protected static class EditReservesPaymentsDropdownKeys
  {
    public static readonly string CoverageType = nameof (CoverageType);
    public static readonly string CoverageTypeId = nameof (CoverageTypeId);
    public static readonly string CoverageTypeDescription = nameof (CoverageTypeDescription);
    public static readonly string CoverageTypeDescriptionId = nameof (CoverageTypeDescriptionId);
    public static readonly string ResPayType = nameof (ResPayType);
    public static readonly string ResPayTypeId = nameof (ResPayTypeId);
    public static readonly string ResPayTypeDescription = nameof (ResPayTypeDescription);
    public static readonly string ResPaySubTypeId = nameof (ResPaySubTypeId);
    public static readonly string ResPaySubTypeDescription = nameof (ResPaySubTypeDescription);
    public static readonly string IsRecoveryType = nameof (IsRecoveryType);
  }

  protected static class EditReservesPaymentsGridKeys
  {
    public static readonly string ResPayId = nameof (ResPayId);
    public static readonly string EntryType = nameof (EntryType);
    public static readonly string Payee = nameof (Payee);
    public static readonly string ResPayType = nameof (ResPayType);
    public static readonly string ResPaySubType = nameof (ResPaySubType);
    public static readonly string CoverageType = nameof (CoverageType);
    public static readonly string CoverageTypeDescription = nameof (CoverageTypeDescription);
    public static readonly string ResPayAmount = nameof (ResPayAmount);
    public static readonly string CorrespondingReduction = nameof (CorrespondingReduction);
  }
}
