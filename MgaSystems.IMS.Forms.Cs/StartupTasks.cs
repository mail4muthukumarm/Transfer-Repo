// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.StartupTasks
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Forms;

public class StartupTasks : ISupportPreLoadCache
{
  public string PreLoadKey => "IMS.Forms.StartupTasks";

  public void OnAsynchronousLoad(object sender, OnAsynchronousLoadEventArgs e)
  {
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "update tblUsers set ClientInfoXml = @ClientInfoXml where UserID = @UserID", new object[4]
      {
        (object) "@ClientInfoXml",
        (object) ContactTechnicalSupport.GenerateClientXml(ContactTechnicalSupport.GetImsInstallInfo()),
        (object) "@UserID",
        (object) CurrentUser.Instance.UserID
      });
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentLogError(ex);
    }
  }
}
