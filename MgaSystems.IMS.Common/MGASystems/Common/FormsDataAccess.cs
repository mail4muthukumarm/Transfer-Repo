// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FormsDataAccess
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class FormsDataAccess
{
  private static frmUpdateProgress _frmUpdateProgress;

  private FormsDataAccess()
  {
  }

  private static void RowUpdated(object sender, Database.UpdateWithProgressEventArgs e)
  {
    FormsDataAccess._frmUpdateProgress.ProgressBar.Maximum = e.Maximum;
    FormsDataAccess._frmUpdateProgress.ProgressBar.Value = e.Progress;
    FormsDataAccess._frmUpdateProgress.Refresh();
  }

  public static void Update(SqlDataAdapter da, DataTable dt)
  {
    try
    {
      FormsDataAccess._frmUpdateProgress = new frmUpdateProgress();
      FormsDataAccess._frmUpdateProgress.MdiParent = MDIControls.Instance.MDIParent;
      FormsDataAccess._frmUpdateProgress.StartPosition = FormStartPosition.CenterScreen;
      FormsDataAccess._frmUpdateProgress.Show();
      Database.Instance.RowUpdated += new Database.RowUpdatedEventHandler(FormsDataAccess.RowUpdated);
      try
      {
        Database.Instance.UpdateWithProgress(da, dt);
      }
      finally
      {
        FormsDataAccess._frmUpdateProgress.Close();
        Database.Instance.RowUpdated -= new Database.RowUpdatedEventHandler(FormsDataAccess.RowUpdated);
      }
    }
    finally
    {
      FormsDataAccess._frmUpdateProgress = (frmUpdateProgress) null;
    }
  }
}
