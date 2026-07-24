// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLClass
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class GLClass
{
  private int glCompanyId;
  private int classId;
  private string className;
  private GLAccountClassType classType;
  private int accountLowerLimit;
  private int accountUpperLimit;

  private GLClass()
  {
  }

  internal GLClass(GLAccountClassType classType, int glCompanyId)
  {
    this.classType = classType;
    this.glCompanyId = glCompanyId;
    int glCompanyId1 = glCompanyId;
    string className;
    switch (classType)
    {
      case GLAccountClassType.Assets:
        className = "Assets";
        break;
      case GLAccountClassType.Equity:
        className = "Equity";
        break;
      case GLAccountClassType.Expenses:
        className = "Expenses";
        break;
      case GLAccountClassType.Liability:
        className = "Liabilities";
        break;
      case GLAccountClassType.Income:
        className = "Income";
        break;
      default:
        className = "";
        break;
    }
    this.GetGLClass(glCompanyId1, className);
  }

  public int GLCompanyId => this.glCompanyId;

  public int ClassId => this.classId;

  public string ClassName => this.className;

  public GLAccountClassType ClassType => this.classType;

  public int AccountLowerLimit => this.accountLowerLimit;

  public int AccountUpperLimit => this.accountUpperLimit;

  private void GetGLClass(int glCompanyId, string className)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_GetGlClassObject", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
        sqlCommand.Parameters.AddWithValue("@className", (object) className);
        sqlCommand.Connection.Open();
        try
        {
          SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
          if (!sqlDataReader.Read())
            return;
          this.classId = int.Parse(sqlDataReader["GLCompanyClassId"].ToString());
          this.className = sqlDataReader["ClassFullName"].ToString();
          this.accountLowerLimit = int.Parse(sqlDataReader["ClassLLimit"].ToString());
          this.accountUpperLimit = int.Parse(sqlDataReader["ClassULimit"].ToString());
        }
        catch (SqlException ex)
        {
          throw ex;
        }
      }
    }
  }
}
