// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterWithFactorSetBase
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class RaterWithFactorSetBase : RaterBase, IRaterWithFactorSet2
{
  private Guid _factorSetGuid;

  public RaterWithFactorSetBase() => this._factorSetGuid = Guid.Empty;

  public override string GetOptionDescription(Guid quoteOptionGuid) => string.Empty;

  Guid IRaterWithFactorSet.FactorSetGuid
  {
    get => this._factorSetGuid;
    set => this._factorSetGuid = value;
  }

  virtual Form IRaterWithFactorSet.CreateFactorSetConfigurationFormEdit(
    Guid factorSetGuid,
    Guid companyLineGuid)
  {
    return (Form) null;
  }

  virtual Form IRaterWithFactorSet.CreateFactorSetConfigurationFormNew(Guid companyLineGuid)
  {
    return (Form) null;
  }

  bool IRaterWithFactorSet.CopyFactorSet(
    Guid originalFactorSetGuid,
    Guid destinationcompanyLineGuid)
  {
    bool flag1;
    if (this.CopyFSStoredProcName.Length == 0)
    {
      this.OnCopyFactorSet(originalFactorSetGuid, destinationcompanyLineGuid);
    }
    else
    {
      SqlConnection cn = new SqlConnection(CurrentUser.Instance.ConnectionString);
      SqlCommand cmd = new SqlCommand();
      bool flag2 = true;
      SqlCommand sqlCommand = cmd;
      sqlCommand.Connection = cn;
      sqlCommand.CommandText = this.CopyFSStoredProcName;
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
      sqlCommand.Parameters.Add(new SqlParameter("@SourceFactorSetGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
      sqlCommand.Parameters.Add(new SqlParameter("@DestcompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
      try
      {
        Database.OpenConnection(cn);
        SqlParameterCollection parameters = cmd.Parameters;
        parameters["@SourceFactorSetGuid"].Value = (object) originalFactorSetGuid;
        parameters["@DestcompanyLineGuid"].Value = (object) destinationcompanyLineGuid;
        Database.PerformNonQueryWithFailureRetry(cmd);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        flag2 = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cn.Close();
        cmd.Dispose();
        cn.Dispose();
      }
      flag1 = flag2;
    }
    return flag1;
  }

  bool IRaterWithFactorSet.DeleteFactorSet(Guid factorSetToDelete)
  {
    bool flag1;
    if (this.DeleteFSStoredProcName.Length == 0)
    {
      this.OnDeleteFactorSet(factorSetToDelete);
    }
    else
    {
      SqlConnection cn = new SqlConnection(CurrentUser.Instance.ConnectionString);
      SqlCommand cmd = new SqlCommand();
      bool flag2 = true;
      cmd.Connection = cn;
      cmd.CommandText = this.DeleteFSStoredProcName;
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
      cmd.Parameters.Add(new SqlParameter("@FactorSetGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
      try
      {
        Database.OpenConnection(cn);
        cmd.Parameters["@FactorSetGuid"].Value = (object) factorSetToDelete;
        Database.PerformNonQueryWithFailureRetry(cmd);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        flag2 = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        cn.Close();
        cmd.Dispose();
        cn.Dispose();
      }
      flag1 = flag2;
    }
    return flag1;
  }

  public virtual bool OnDeleteFactorSet(Guid factorSetToDelete)
  {
    int num = (int) MessageBox.Show("Currently this rater does not allow deleting of factor sets. This should be enabled in a future update. Contact your system administrator for more details.", "Unable to copy factor set", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    bool flag;
    return flag;
  }

  public virtual bool OnCopyFactorSet(Guid originalFactorSetGuid, Guid destinationcompanyLineGuid)
  {
    int num = (int) MessageBox.Show("Currently this rater does not allow copying of factor sets. This should be enabled in a future update. Contact your system administrator for more details.", "Unable to copy factor set", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    bool flag;
    return flag;
  }

  public virtual string DeleteFSStoredProcName => string.Empty;

  public virtual string CopyFSStoredProcName => string.Empty;

  public void AfterRaterReset(AfterResetArgs e) => this.OnAfterRaterReset(e);

  public virtual void OnAfterRaterReset(AfterResetArgs e)
  {
  }

  public void AfterRaterSetupChange(AfterResetArgs e) => this.OnAfterRaterSetupChange(e);

  public virtual void OnAfterRaterSetupChange(AfterResetArgs e)
  {
  }
}
