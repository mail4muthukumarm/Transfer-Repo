// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankAccountsExplorerGroup
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class BankAccountsExplorerGroup : UltraExplorerBarGroup
{
  private int _glcompanyid;
  private string _loadBankAccountsProcedureName;
  private Image _image;

  internal int GLCompanyID => this._glcompanyid;

  protected string LoadBankAccountsProcedureName
  {
    get => this._loadBankAccountsProcedureName;
    set => this._loadBankAccountsProcedureName = value;
  }

  private BankAccountsExplorerGroup()
  {
  }

  public BankAccountsExplorerGroup(int GLCompanyID, Image ItemImage)
  {
    this.InitializeGroup();
    this._glcompanyid = GLCompanyID;
    this._image = ItemImage;
    this.LoadAccounts();
  }

  protected override void OnDispose() => ((DisposableObject) this).Dispose();

  protected void LoadAccounts()
  {
    if (string.IsNullOrEmpty(this._loadBankAccountsProcedureName))
      this._loadBankAccountsProcedureName = "spFin_GetBankAccounts";
    SqlCommand sqlCommand1 = new SqlCommand(this._loadBankAccountsProcedureName, new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@glcompanyid", (object) this.GLCompanyID);
      sqlCommand2.Connection.Open();
      sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        if (sqlDataReader["bankname"].ToString().Length != 0)
        {
          this.Items.Add("BANK" + sqlDataReader["glacctid"].ToString(), sqlDataReader["bankname"].ToString());
          this.ItemSettings.AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.Accounting.Banking.My.Resources.Resources.house;
          this.Items[((DisposableObjectCollectionBase) this.Items).Count - 1].Settings.AppearancesSmall.Appearance.BackColor = Color.FromArgb(239, 247, 253);
          this.Items[((DisposableObjectCollectionBase) this.Items).Count - 1].Settings.AppearancesSmall.Appearance.BackColor2 = Color.FromArgb(239, 247, 253);
        }
      }
    }
    finally
    {
      if (!sqlDataReader.IsClosed)
        sqlDataReader.Close();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  protected virtual void InitializeGroup() => this.Text = "Accounts";
}
