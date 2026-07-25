// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmAdminProducerSpecialContacts
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

internal class frmAdminProducerSpecialContacts : frmSpecialContactsBase
{
  private IContainer components;
  private SqlDataAdapter daProducerSpecialContacts;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.daProducerSpecialContacts = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.daProducerSpecialContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daProducerSpecialContacts.InsertCommand = this.SqlInsertCommand1;
    this.daProducerSpecialContacts.SelectCommand = this.SqlSelectCommand2;
    this.daProducerSpecialContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstProducerSpecialContactTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID"),
        new DataColumnMapping("SpecialContactType", "SpecialContactType")
      })
    });
    this.daProducerSpecialContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlSelectCommand1.CommandText = "SELECT ProducerSpecialContactListID, Description FROM lstProducerSpecialContact";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand2.CommandText = "SELECT SpecialContactTypeID, SpecialContactType FROM dbo.lstProducerSpecialContactTypes WHERE (Hidden = 0)";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand1.CommandText = "INSERT INTO dbo.lstProducerSpecialContactTypes(SpecialContactType) VALUES (@SpecialContactType); SELECT SpecialContactTypeID, SpecialContactType FROM dbo.lstProducerSpecialContactTypes WHERE (SpecialContactTypeID = @@IDENTITY)";
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.Add(new SqlParameter("@SpecialContactType", SqlDbType.VarChar, 50, "SpecialContactType"));
    this.SqlUpdateCommand1.CommandText = "UPDATE dbo.lstProducerSpecialContactTypes SET SpecialContactType = @SpecialContactType WHERE (SpecialContactTypeID = @Original_SpecialContactTypeID) AND (SpecialContactType = @Original_SpecialContactType); SELECT SpecialContactTypeID, SpecialContactType FROM dbo.lstProducerSpecialContactTypes WHERE (SpecialContactTypeID = @SpecialContactTypeID)";
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@SpecialContactType", SqlDbType.VarChar, 50, "SpecialContactType"));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@Original_SpecialContactType", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactType", DataRowVersion.Original, (object) null));
    this.SqlUpdateCommand1.Parameters.Add(new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID"));
    this.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.lstProducerSpecialContactTypes WHERE (SpecialContactTypeID = @Original_SpecialContactTypeID) AND (SpecialContactType = @Original_SpecialContactType)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.Add(new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null));
    this.SqlDeleteCommand1.Parameters.Add(new SqlParameter("@Original_SpecialContactType", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactType", DataRowVersion.Original, (object) null));
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(356, 212);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmAdminProducerSpecialContacts);
    this.Text = "Producer Special Contacts Administration";
  }

  public frmAdminProducerSpecialContacts(EventHandler closingHandler)
    : base(closingHandler)
  {
    this.InitializeComponent();
    this.ContactsDataAdapter = this.daProducerSpecialContacts;
  }
}
