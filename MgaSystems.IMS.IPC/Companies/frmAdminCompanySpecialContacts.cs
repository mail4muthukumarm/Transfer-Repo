// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmAdminCompanySpecialContacts
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

internal class frmAdminCompanySpecialContacts : frmSpecialContactsBase
{
  private IContainer components;
  private SqlDataAdapter daSpecialContacts;
  private SqlCommand SqlSelectCommand1;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminCompanySpecialContacts));
    this.daSpecialContacts = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SuspendLayout();
    this.daSpecialContacts.DeleteCommand = this.SqlDeleteCommand1;
    this.daSpecialContacts.InsertCommand = this.SqlInsertCommand1;
    this.daSpecialContacts.SelectCommand = this.SqlSelectCommand1;
    this.daSpecialContacts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstCompanySpecialContactTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("SpecialContactTypeID", "SpecialContactTypeID"),
        new DataColumnMapping("SpecialContactType", "SpecialContactType")
      })
    });
    this.daSpecialContacts.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.lstCompanySpecialContactTypes WHERE (SpecialContactTypeID = @Original_SpecialContactTypeID) AND (SpecialContactType = @Original_SpecialContactType)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactType", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactType", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@SpecialContactType", SqlDbType.VarChar, 50, "SpecialContactType")
    });
    this.SqlSelectCommand1.CommandText = "SELECT SpecialContactTypeID, SpecialContactType FROM dbo.lstCompanySpecialContactTypes WHERE (Hidden = 0)";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@SpecialContactType", SqlDbType.VarChar, 50, "SpecialContactType"),
      new SqlParameter("@Original_SpecialContactTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SpecialContactType", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SpecialContactType", DataRowVersion.Original, (object) null),
      new SqlParameter("@SpecialContactTypeID", SqlDbType.Int, 4, "SpecialContactTypeID")
    });
    this.Name = nameof (frmAdminCompanySpecialContacts);
    this.Text = "Company Special Contacts Administration";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdminCompanySpecialContacts(EventHandler closingHandler)
    : base(closingHandler)
  {
    this.InitializeComponent();
    this.ContactsDataAdapter = this.daSpecialContacts;
  }
}
