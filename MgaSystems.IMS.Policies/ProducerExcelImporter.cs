// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ProducerExcelImporter
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.UltraWinListView;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies;

public class ProducerExcelImporter : ImportClaims
{
  private Guid _producerGuid;
  private Guid _producerLocationGUID;
  private int _currentRow;

  public ProducerExcelImporter(dsExcelImport dsImport, Worksheet worksheet)
    : this(dsImport, worksheet, Guid.NewGuid())
  {
  }

  public ProducerExcelImporter(dsExcelImport dsImport, Worksheet worksheet, Guid ProducerGuid)
    : base(dsImport, string.Empty, worksheet)
  {
    this._currentRow = 0;
    this.Import(worksheet);
  }

  protected void Import(Worksheet worksheet)
  {
    try
    {
      foreach (Row row in (IEnumerable<Row>) worksheet.Cells.Rows)
      {
        if (this._currentRow > 0)
        {
          this._producerGuid = Guid.NewGuid();
          this._producerLocationGUID = Guid.NewGuid();
          try
          {
            this.OnInsertProducerRecord(this._producerGuid, this._producerLocationGUID, row);
            UltraListViewItem ultraListViewItem = new UltraListViewItem();
            ((UltraListViewItemBase) ultraListViewItem).Value = (object) this.GetAddListItemSuccessString(this._currentRow, row, string.Empty);
            this.AddListItem(ultraListViewItem);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = ^(local = ref this._currentRow) + 1;
        local = num;
      }
    }
    finally
    {
      IEnumerator<Row> enumerator;
      enumerator?.Dispose();
    }
    this.spinner.Visible = false;
  }

  protected override void OnLoad(EventArgs e)
  {
    base.OnLoad(e);
    this.lblStatus.Text = "Importing Producer and Producer Location Data..";
    this.Text = "Importing..........";
  }

  protected override void AddListItem(UltraListViewItem item)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new ProducerExcelImporter.AddListItemHandler(this.AddListItem), (object) item);
    }
    else
    {
      this.listImportStatus.Items.Add(item);
      this.listImportStatus.PerformAction((UltraListViewAction) 23);
    }
  }

  protected override void ImportComplete(int importCount, int skipCount, int notFoundCount)
  {
  }

  protected override string GetAddListItemSuccessString(
    int _currentRow,
    Row worksheetRow,
    string policyNumber)
  {
    string mappedValue1 = (string) this.GetMappedValue("ProducerName", worksheetRow, true);
    string mappedValue2 = (string) this.GetMappedValue("Name", worksheetRow, true);
    string mappedValue3 = (string) this.GetMappedValue("City", worksheetRow, true);
    return !string.IsNullOrEmpty(mappedValue1) ? $"Successfully imported  {mappedValue1} {mappedValue3} " : $"Successfully imported  {mappedValue2} {mappedValue3} ";
  }

  protected override void OnImportThread(object state)
  {
  }

  protected virtual void OnInsertProducerRecord(
    Guid producerGuid,
    Guid producerLocationGuid,
    Row worksheetRow)
  {
    DefaultDatabase.ExecuteNonQuery("ProducerAndLocationImport", new object[34]
    {
      (object) "@ProducerName",
      this.GetMappedValue("ProducerName", worksheetRow, true),
      (object) "@LocationCode",
      this.GetMappedValue("LocationCode", worksheetRow, true),
      (object) "@ProducerTypeID",
      this.GetMappedValue("ProducerTypeID", worksheetRow, true),
      (object) "@Name",
      this.GetMappedValue("Name", worksheetRow, true),
      (object) "@Address1",
      this.GetMappedValue("Address1", worksheetRow, true),
      (object) "@Address2",
      this.GetMappedValue("Address2", worksheetRow, true),
      (object) "@City",
      this.GetMappedValue("City", worksheetRow, true),
      (object) "@County",
      this.GetMappedValue("County", worksheetRow, true),
      (object) "@State",
      this.GetMappedValue("State", worksheetRow, true),
      (object) "@Region",
      this.GetMappedValue("Region", worksheetRow, true),
      (object) "@ZipCode",
      this.GetMappedValue("ZipCode", worksheetRow, true),
      (object) "@ZipPlus",
      this.GetMappedValue("ZipPlus", worksheetRow, true),
      (object) "@Phone",
      this.GetMappedValue("Phone", worksheetRow, true),
      (object) "@Fax",
      this.GetMappedValue("Fax", worksheetRow, true),
      (object) "@FEIN",
      this.GetMappedValue("FEIN", worksheetRow, true),
      (object) "@WebSite",
      this.GetMappedValue("WebSite", worksheetRow, true),
      (object) "@Email",
      this.GetMappedValue("Email", worksheetRow, true)
    });
  }

  private new delegate void AddListItemHandler(UltraListViewItem item);
}
