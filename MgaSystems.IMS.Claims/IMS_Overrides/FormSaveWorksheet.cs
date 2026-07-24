// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.IMS_Overrides.FormSaveWorksheet
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.IMS_Overrides;

[Override(typeof (formSaveWorksheet))]
public class FormSaveWorksheet : formSaveWorksheet
{
  private IContainer components;

  public FormSaveWorksheet() => this.InitializeComponent();

  public FormSaveWorksheet(formSaveWorksheet.WorksheetType worksheetType, object worksheetObject)
    : base(worksheetType, worksheetObject)
  {
    this.InitializeComponent();
  }

  protected virtual void DoSaveWorkSheet(bool overWrite, int entryId)
  {
    base.DoSaveWorkSheet(overWrite, entryId);
    if (((Form) this).Owner == null || !(((Form) this).Owner is FormClaimsARAP owner))
      return;
    ((UltraGridBase) owner.gridClaimsAR).UpdateData();
    UltraGridBand band = ((UltraGridBase) owner.gridClaimsAR).DisplayLayout.Bands[0];
    band.ColumnFilters["ClaimARApplied"].FilterConditions.Add((FilterComparisionOperator) 1, (SpecialFilterOperand) null);
    band.ColumnFilters["ClaimARApplied"].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0M);
    band.ColumnFilters["ClaimARApplied"].LogicalOperator = (FilterLogicalOperator) 0;
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) owner.gridClaimsAR).Rows.GetFilteredInNonGroupByRows();
    if (inNonGroupByRows.Length == 0)
      return;
    ClaimAccountingWorksheet graph = new ClaimAccountingWorksheet();
    graph.claimARValues = new ClaimReceivableValueCollection();
    int claimId = -1;
    int uaExpenseId = -1;
    int resPayId = -1;
    Decimal amount = 0M;
    for (int index = 0; index < inNonGroupByRows.Length; ++index)
    {
      if (((KeyedSubObjectsCollectionBase) ((GridItemBase) inNonGroupByRows[index]).Band.Columns).Exists("ClaimId") && inNonGroupByRows[index].Cells["ClaimId"].Value != DBNull.Value)
        claimId = int.Parse(inNonGroupByRows[index].Cells["Claimid"].Value.ToString(), NumberStyles.Any);
      if (((KeyedSubObjectsCollectionBase) ((GridItemBase) inNonGroupByRows[index]).Band.Columns).Exists("UAExpenseId") && inNonGroupByRows[index].Cells["UAExpenseId"].Value != DBNull.Value)
        uaExpenseId = int.Parse(inNonGroupByRows[index].Cells["UAExpenseId"].Value.ToString(), NumberStyles.Any);
      if (((KeyedSubObjectsCollectionBase) ((GridItemBase) inNonGroupByRows[index]).Band.Columns).Exists("ResPayId") && inNonGroupByRows[index].Cells["ResPayId"].Value != DBNull.Value)
        resPayId = int.Parse(inNonGroupByRows[index].Cells["ResPayId"].Value.ToString(), NumberStyles.Any);
      if (((KeyedSubObjectsCollectionBase) ((GridItemBase) inNonGroupByRows[index]).Band.Columns).Exists("ClaimARApplied") && inNonGroupByRows[index].Cells["ClaimARApplied"].Value != DBNull.Value)
        amount = Decimal.Parse(inNonGroupByRows[index].Cells["ClaimARApplied"].Value.ToString(), NumberStyles.Any);
      graph.claimARValues.Add(new ClaimReceivableValue(claimId, uaExpenseId, resPayId, amount));
    }
    MemoryStream serializationStream = new MemoryStream();
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
    binaryFormatter.Context = new StreamingContext(StreamingContextStates.Persistence);
    binaryFormatter.Serialize((Stream) serializationStream, (object) graph);
    serializationStream.Position = 0L;
    binaryFormatter.Deserialize((Stream) serializationStream);
    serializationStream.Flush();
    serializationStream.Position = 0L;
    byte[] array = serializationStream.ToArray();
    serializationStream.Close();
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertClaimAccountingWorksheet", new object[4]
    {
      (object) "@entryId",
      (object) this._entryId,
      (object) "@info",
      (object) array
    });
    serializationStream.Dispose();
    ((UltraGridBase) owner.gridClaimsAR).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ((Control) this).SuspendLayout();
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).ClientSize = new Size(488, 316);
    ((Control) this).Name = nameof (FormSaveWorksheet);
    ((Control) this).Text = "Save Worksheet (Claims)";
    ((Control) this).ResumeLayout(false);
  }
}
