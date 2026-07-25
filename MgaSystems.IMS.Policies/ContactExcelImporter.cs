// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ContactExcelImporter
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.UltraWinListView;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies;

internal class ContactExcelImporter : ImportClaims
{
  private Guid _producerLocationGUID;
  private int _currentRow;
  private string _errorSummary;

  public string ErrorSummary
  {
    get => this._errorSummary;
    set => this._errorSummary = value;
  }

  public ContactExcelImporter(dsExcelImport dsImport, Worksheet worksheet)
    : this(dsImport, string.Empty, worksheet)
  {
  }

  public ContactExcelImporter(
    dsExcelImport dsImport,
    string ProducerLocationGuid,
    Worksheet worksheet)
    : base(dsImport, string.Empty, worksheet)
  {
    this._currentRow = 0;
    this._errorSummary = string.Empty;
    try
    {
      foreach (Row row in (IEnumerable<Row>) worksheet.Cells.Rows)
      {
        if (this._currentRow > 0)
        {
          if (string.IsNullOrEmpty(ProducerLocationGuid))
          {
            string str = Conversions.ToString(this.GetMappedValue("LocationCode", row, true));
            if (!string.IsNullOrEmpty(str))
            {
              object obj = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ProducerLocationGuid From tblProducerLocations WHERE tblProducerLocations.LocationCode = @SearchString", new object[2]
              {
                (object) "@SearchString",
                (object) str
              });
              this._producerLocationGUID = obj != null ? (Guid) obj : new Guid();
            }
            else
              this._errorSummary = !string.IsNullOrEmpty(this._errorSummary) ? $"{this._errorSummary},{Strings.Space(1)}{str}" : str;
          }
          else
            this._producerLocationGUID = new Guid(ProducerLocationGuid);
          try
          {
            this.InsertContactRecord(this._producerLocationGUID, row);
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

  private void InsertContactRecord(Guid ProducerLocationGuid, Row worksheetRow)
  {
    DefaultDatabase.ExecuteNonQuery("ProducerContactImport", new object[22]
    {
      (object) "@ProducerLocationGUID",
      (object) this._producerLocationGUID,
      (object) "@Salutation",
      this.GetMappedValue("Salutation", worksheetRow, true),
      (object) "@FName",
      this.GetMappedValue("FName", worksheetRow, true),
      (object) "@LName",
      this.GetMappedValue("LName", worksheetRow, true),
      (object) "@Title",
      this.GetMappedValue("Title", worksheetRow, true),
      (object) "@Phone",
      this.GetMappedValue("Phone", worksheetRow, true),
      (object) "@Extension",
      this.GetMappedValue("Extension", worksheetRow, true),
      (object) "@Fax",
      this.GetMappedValue("Fax", worksheetRow, true),
      (object) "@Cell",
      this.GetMappedValue("Cell", worksheetRow, true),
      (object) "@Email",
      this.GetMappedValue("Email", worksheetRow, true),
      (object) "@SSNo",
      this.GetMappedValue("SSNo", worksheetRow, true)
    });
  }

  protected override void OnLoad(EventArgs e)
  {
    base.OnLoad(e);
    this.lblStatus.Text = "Importing Producer Contact Data";
    this.Text = "Importing..........";
  }

  protected override void AddListItem(UltraListViewItem item)
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new ContactExcelImporter.AddListItemHandler(this.AddListItem), (object) item);
    }
    else
    {
      this.listImportStatus.Items.Add(item);
      this.listImportStatus.PerformAction((UltraListViewAction) 23);
    }
    if (string.IsNullOrEmpty(this._errorSummary))
      return;
    UltraListViewItem ultraListViewItem = new UltraListViewItem();
    ((UltraListViewItemBase) ultraListViewItem).Value = (object) ("The following location codes were not found " + this._errorSummary);
    this.listImportStatus.Items.Add(ultraListViewItem);
  }

  protected override void ImportComplete(int importCount, int skipCount, int notFoundCount)
  {
  }

  protected override string GetAddListItemSuccessString(
    int _currentRow,
    Row worksheetRow,
    string policyNumber)
  {
    return $"Successfully imported {(string) this.GetMappedValue("FName", worksheetRow, true)} {(string) this.GetMappedValue("LName", worksheetRow, true)} ";
  }

  protected override void OnImportThread(object state)
  {
  }

  private new delegate void AddListItemHandler(UltraListViewItem item);
}
