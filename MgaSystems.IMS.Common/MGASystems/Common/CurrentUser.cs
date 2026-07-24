// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.CurrentUser
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.LogonServer;
using MGASystems.Common.My;
using MGASystems.Data;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class CurrentUser : ICurrentUser
{
  private const string GRID_LAYOUT_SUBFOLDER = "GridLayouts";
  private int _clientID;
  private Guid _userGuid;
  private int _userID;
  private string _userName;
  private string _password;
  private string _connectionString;
  private int _officeID;
  private string _firstName;
  private string _lastName;
  private string _webServicesInvoicingUrl;
  private string _webServicesLogonUrl;
  private string _webServicesDocumentsUrl;
  private string _azureTenant;
  private string _azureClient;
  private bool _isLoggedIn;
  private static CurrentUser s;
  private object _isAccountingPackageActive;
  private UserEmail _userEmail;
  private UserCollection _users;
  private static readonly TimeSpan _allowableTimeVariance = new TimeSpan(0, 10, 0);
  private Uri _baseWebServicesUri;
  private static bool? _isMgaDeveloper;
  private static bool? _usingModernAuthentication;
  private Func<DateTime> ResolvedServerTimeFunction;

  private CurrentUser()
  {
    this._clientID = 5;
    this.ResolvedServerTimeFunction = (Func<DateTime>) null;
  }

  public UserCollection Users
  {
    get
    {
      if (this._users == null)
        this._users = new UserCollection();
      return this._users;
    }
  }

  public static DateTime ServerTime
  {
    get => DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "SELECT GETDATE()");
  }

  public static bool IsMGADeveloper
  {
    get
    {
      if (!CurrentUser._isMgaDeveloper.HasValue)
      {
        try
        {
          WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
          CurrentUser._isMgaDeveloper = new bool?((windowsPrincipal.IsInRole("MGA") || windowsPrincipal.IsInRole("NY.MGASystems.com\\MGA")) && IPGlobalProperties.GetIPGlobalProperties().DomainName.EqualsNoCase("NY.MGASystems.com") || windowsPrincipal.IsInRole("VERTAFORE\\MGA") && IPGlobalProperties.GetIPGlobalProperties().DomainName.EqualsNoCase("vertafore.com"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          CurrentUser._isMgaDeveloper = new bool?(false);
          ProjectData.ClearProjectError();
        }
      }
      return CurrentUser._isMgaDeveloper.GetValueOrDefault();
    }
  }

  public static bool UsingModernAuthentication
  {
    get
    {
      if (!CurrentUser._usingModernAuthentication.HasValue)
      {
        try
        {
          CurrentUser._usingModernAuthentication = new bool?(ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Forms.frmLogIn").Name.Equals("GraphLogin"));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      return CurrentUser._usingModernAuthentication.GetValueOrDefault();
    }
  }

  public bool IsLoggedIn => this._isLoggedIn;

  public DateTime PasswordLastChanged
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "SELECT PasswordLastChanged FROM dbo.tblUsers WITH(NOLOCK) WHERE UserID=@UserID", new object[2]
      {
        (object) "@UserID",
        (object) this.UserID
      });
    }
  }

  public bool RequirePasswordResetOnNextLogin
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT RequirePasswordResetOnNextLogin FROM dbo.tblUsers WITH(NOLOCK) WHERE UserID=@UserID", new object[2]
      {
        (object) "@UserID",
        (object) this.UserID
      });
    }
  }

  public bool HasValidMailSettings
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT CASE WHEN EmailAddress IS NULL OR MailServerAddress IS NULL OR MailUserName IS NULL OR MailPassword IS NULL THEN 0 ELSE 1 END FROM dbo.tblUsers WITH(NOLOCK) WHERE UserID=@UserID", new object[2]
      {
        (object) "@UserID",
        (object) this.UserID
      }) == 1;
    }
  }

  public string WebServicesInvoicingUrl
  {
    get => this._webServicesInvoicingUrl;
    set => this._webServicesInvoicingUrl = value;
  }

  public string WebServicesLogonUrl
  {
    get => this._webServicesLogonUrl;
    set => this._webServicesLogonUrl = value;
  }

  public string WebServicesDocumentsUrl
  {
    get => this._webServicesDocumentsUrl;
    set => this._webServicesDocumentsUrl = value;
  }

  public Uri BaseWebServicesUri
  {
    get
    {
      if ((object) this._baseWebServicesUri == null)
        this._baseWebServicesUri = new Uri(this.WebServicesLogonUrl.Replace("logon.asmx", ""));
      return this._baseWebServicesUri;
    }
  }

  public string AzureTenant
  {
    get => this._azureTenant;
    set
    {
      if (!string.IsNullOrEmpty(this._azureTenant))
        return;
      this._azureTenant = value;
    }
  }

  public string AzureClient
  {
    get => this._azureClient;
    set
    {
      if (!string.IsNullOrEmpty(this._azureClient))
        return;
      this._azureClient = value;
    }
  }

  public bool IsConnectionStringInitialized
  {
    get => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ConnectionString, string.Empty, false) != 0;
  }

  public bool IsAccountingPackageActive
  {
    get
    {
      if (this._isAccountingPackageActive == null)
        this._isAccountingPackageActive = (object) DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsAccountingActive()");
      return (bool) this._isAccountingPackageActive;
    }
  }

  public static bool UsingVista => Environment.OSVersion.Version.Major == 6;

  public bool UsingXP
  {
    get => Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor == 1;
  }

  public string ConnectionString
  {
    get => this._connectionString;
    set => this._connectionString = value;
  }

  public int UserID
  {
    get => this._userID;
    set => this._userID = value;
  }

  public Guid UserGUID
  {
    get => this._userGuid;
    set => this._userGuid = value;
  }

  public UserEmail Email
  {
    get
    {
      if (this._userEmail == null)
        this._userEmail = this.GetUserEmail();
      else
        this._userEmail.Refresh();
      return this._userEmail;
    }
  }

  public int OfficeID
  {
    get => this._officeID;
    set => this._officeID = value;
  }

  public string UserName
  {
    get => this._userName;
    set => this._userName = value;
  }

  public string Password
  {
    get => this._password;
    set => this._password = value;
  }

  public int SupportCenterClientID
  {
    get => this._clientID;
    set => this._clientID = value;
  }

  public static CurrentUser Instance
  {
    get
    {
      if (CurrentUser.s == null)
        CurrentUser.s = new CurrentUser();
      return CurrentUser.s;
    }
  }

  public string FirstName
  {
    get => this._firstName;
    set => this._firstName = value;
  }

  public string LastName
  {
    get => this._lastName;
    set => this._lastName = value;
  }

  public string DisplayName => $"{this.FirstName} {this.LastName}";

  public string DisplayNameLastFirst => $"{this.LastName} {this.FirstName}";

  public void UpdatePassword(string newPassword)
  {
    string str = new Encryption().EncryptTripleDes(newPassword);
    if (ServerXML.UseEncryptedPasswords)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblUsers SET EncryptedPassword = @EncryptedPassword WHERE UserID = @userid", new object[4]
      {
        (object) "@userid",
        (object) this.UserID,
        (object) "@EncryptedPassword",
        (object) str
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblUsers SET Password = @password, EncryptedPassword = @EncryptedPassword WHERE UserID = @userid", new object[6]
      {
        (object) "@password",
        (object) newPassword,
        (object) "@userid",
        (object) this.UserID,
        (object) "@EncryptedPassword",
        (object) str
      });
    this._password = newPassword;
  }

  public static bool UsingOutlook
  {
    get
    {
      return !SystemInformation.TerminalServerSession ? Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\Mail", string.Empty, (object) string.Empty).ToString(), "Microsoft Outlook", false) == 0 : Type.GetTypeFromProgID("Outlook.Application") != null;
    }
  }

  public static bool IsOfficeAppAvailable(
    CurrentUser.OfficeApps application,
    CurrentUser.WordVersion minimumVersion)
  {
    RegistryKey registryKey1 = (RegistryKey) null;
    RegistryKey registryKey2 = (RegistryKey) null;
    RegistryKey registryKey3 = (RegistryKey) null;
    try
    {
      registryKey1 = Registry.LocalMachine.OpenSubKey("SOFTWARE", false);
      registryKey2 = registryKey1.OpenSubKey("Microsoft", false);
      registryKey3 = registryKey2.OpenSubKey("Office", false);
      string name1 = Enum.GetName(typeof (CurrentUser.OfficeApps), (object) application);
      string[] subKeyNames1 = registryKey3.GetSubKeyNames();
      List<string> stringList = new List<string>();
      string[] strArray = subKeyNames1;
      int index1 = 0;
      while (index1 < strArray.Length)
      {
        string Expression = strArray[index1];
        if (Versioned.IsNumeric((object) Expression) && (CurrentUser.WordVersion) Conversions.ToInteger(Expression) >= minimumVersion)
          stringList.Add(Expression);
        checked { ++index1; }
      }
      if (stringList.Count > 0)
      {
        try
        {
          foreach (string name2 in stringList)
          {
            RegistryKey registryKey4 = (RegistryKey) null;
            try
            {
              registryKey4 = registryKey3.OpenSubKey(name2, false);
              if (registryKey4 != null)
              {
                string[] subKeyNames2 = registryKey4.GetSubKeyNames();
                int index2 = 0;
                while (index2 < subKeyNames2.Length)
                {
                  if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(subKeyNames2[index2], name1, false) == 0)
                    return true;
                  checked { ++index2; }
                }
              }
            }
            finally
            {
              registryKey4?.Close();
            }
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      return false;
    }
    finally
    {
      registryKey3?.Close();
      registryKey2?.Close();
      registryKey1?.Close();
    }
  }

  public void Logout()
  {
    if (!this.IsConnectionStringInitialized)
      return;
    try
    {
      ConcurrencyManager.ClearUserObjectLocks();
      DefaultDatabase.ExecuteNonQuery("dbo.LogoutUser", new object[2]
      {
        (object) "@userID",
        (object) this.UserID
      });
      this._isLoggedIn = false;
      CurrentUser.Instance.LogAction("Logged Out", this._userGuid);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ex.Message, "SQL Server does not exist or access denied", false) == 0)
      {
        int num = (int) MessageBox.Show("The system was unable to log you out, because it was not able to contact the database.\n\nPlease contact technical support.", "Unable to Log Out", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
  }

  public void Login(string userName, string password)
  {
    try
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("UpdateLoggedInStatus", new object[4]
      {
        (object) "@userName",
        (object) userName,
        (object) "@machineName",
        (object) Environment.MachineName
      });
      CurrentUser instance = CurrentUser.Instance;
      instance.UserID = Conversions.ToInteger(dataRow[0]);
      instance.ConnectionString = this.ConnectionString;
      instance.UserGUID = (Guid) dataRow[1];
      instance.FirstName = dataRow[2].ToString();
      instance.LastName = dataRow[3].ToString();
      instance.OfficeID = Conversions.ToInteger(dataRow[4]);
      instance.UserName = userName;
      instance.Password = password;
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.State == (byte) 50)
        throw new UserAlreadyLoggedInException();
      throw;
    }
    this._isLoggedIn = true;
    ConcurrencyManager.ClearUserObjectLocks();
  }

  public bool Initialize(Guid userGuid, bool refreshListOfUsers)
  {
    if (refreshListOfUsers)
      this.Users.Refresh();
    bool flag;
    try
    {
      foreach (User user in (List<User>) this.Users)
      {
        if (user.UserGuid.Equals(userGuid))
        {
          CurrentUser instance = CurrentUser.Instance;
          instance.UserID = user.UserID;
          instance.UserGUID = user.UserGuid;
          instance.FirstName = user.FirstName;
          instance.LastName = user.LastName;
          instance.OfficeID = user.OfficeID;
          instance.UserName = this.UserName;
          flag = true;
          goto label_9;
        }
      }
    }
    finally
    {
      List<User>.Enumerator enumerator;
      enumerator.Dispose();
    }
    flag = false;
label_9:
    return flag;
  }

  public bool Initialize(Guid userGuid) => this.Initialize(userGuid, true);

  public bool PersistGridLayout(UltraGridBase Grid)
  {
    return this.PersistGridLayout(Grid, (PropertyCategories) -1);
  }

  public bool PersistGridLayout(UltraGridBase grid, PropertyCategories PropCat)
  {
    if (grid == null)
      throw new ArgumentNullException(nameof (grid));
    string path2 = $"{((Control) grid).FindForm().GetType().FullName}.{((Control) grid).Name}.xml";
    string str1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.CompanyName, Application.ProductName, "GridLayouts");
    bool flag;
    if (!Directory.Exists(str1))
    {
      try
      {
        Directory.CreateDirectory(str1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_8;
      }
    }
    string str2 = Path.Combine(str1, path2);
    try
    {
      grid.DisplayLayout.SaveAsXml(str2);
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
label_8:
    return flag;
  }

  public bool RestoreGridLayout(UltraGridBase grid)
  {
    if (grid == null)
      throw new ArgumentNullException(nameof (grid));
    string path2 = $"{((Control) grid).FindForm().GetType().FullName}.{((Control) grid).Name}.xml";
    string str = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.CompanyName, Application.ProductName, "GridLayouts"), path2);
    bool flag;
    try
    {
      grid.DisplayLayout.LoadFromXml(str);
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public void LogAction(string action, int identifier)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LogAction", new object[6]
    {
      (object) "@userID",
      (object) this.UserID,
      (object) "@action",
      (object) action,
      (object) "@identifierID",
      (object) identifier
    });
  }

  public DateTime GetServerTime()
  {
    DateTime serverTime1;
    if (this.ResolvedServerTimeFunction == null)
    {
      try
      {
        DateTime serverTime2 = CurrentUser.ServerTime;
        DateTime now = DateTime.Now;
        if (DateTime.Compare(now, serverTime2 - CurrentUser._allowableTimeVariance) >= 0 && DateTime.Compare(now, serverTime2 + CurrentUser._allowableTimeVariance) <= 0)
        {
          Func<DateTime> func;
          // ISSUE: reference to a compiler-generated field
          if (CurrentUser._Closure\u0024__.\u0024I118\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            func = CurrentUser._Closure\u0024__.\u0024I118\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            CurrentUser._Closure\u0024__.\u0024I118\u002D0 = func = (Func<DateTime>) ([SpecialName] () => DateTime.Now);
          }
          this.ResolvedServerTimeFunction = func;
          serverTime1 = now;
          goto label_15;
        }
        Func<DateTime> func1;
        // ISSUE: reference to a compiler-generated field
        if (CurrentUser._Closure\u0024__.\u0024I118\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          func1 = CurrentUser._Closure\u0024__.\u0024I118\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          CurrentUser._Closure\u0024__.\u0024I118\u002D1 = func1 = (Func<DateTime>) ([SpecialName] () => CurrentUser.ServerTime);
        }
        this.ResolvedServerTimeFunction = func1;
        serverTime1 = serverTime2;
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Func<DateTime> func;
        // ISSUE: reference to a compiler-generated field
        if (CurrentUser._Closure\u0024__.\u0024I118\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          func = CurrentUser._Closure\u0024__.\u0024I118\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          CurrentUser._Closure\u0024__.\u0024I118\u002D2 = func = (Func<DateTime>) ([SpecialName] () => CurrentUser.ServerTime);
        }
        this.ResolvedServerTimeFunction = func;
        ProjectData.ClearProjectError();
      }
    }
    serverTime1 = this.ResolvedServerTimeFunction();
label_15:
    return serverTime1;
  }

  public UserEmail GetUserEmail() => new UserEmail(this);

  public void LogDataset(DataSet ds)
  {
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) ds.Tables)
      {
        try
        {
          foreach (DataRow row in table.Rows)
          {
            if (row.RowState != DataRowState.Unchanged)
            {
              try
              {
                foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
                {
                  if (!object.Equals(RuntimeHelpers.GetObjectValue(row[column, DataRowVersion.Original]), (object) (column, DataRowVersion.Current)))
                    this.LogAction($"Changed {column.ColumnName} value from {RuntimeHelpers.GetObjectValue(row.IsNull(column, DataRowVersion.Original) ? row[column, DataRowVersion.Original] : (object) "NULL")} to {RuntimeHelpers.GetObjectValue(row.IsNull(column, DataRowVersion.Current) ? row[column, DataRowVersion.Current] : (object) "NULL")}.");
                }
              }
              finally
              {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public void LogAction(string action, Guid identifier)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LogAction", new object[6]
    {
      (object) "@userID",
      (object) this.UserID,
      (object) "@action",
      (object) action,
      (object) "@identifierGuid",
      (object) identifier
    });
  }

  public void LogAction(string action)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LogAction", new object[4]
    {
      (object) "@userID",
      (object) this.UserID,
      (object) "@action",
      (object) action
    });
  }

  public void LogAction(string action, int identifier, string context)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LogAction", new object[8]
    {
      (object) "@userID",
      (object) this.UserID,
      (object) "@action",
      (object) action,
      (object) "@identifierID",
      (object) identifier,
      (object) "@Context",
      (object) context
    });
  }

  public void LogAction(string action, Guid identifier, string context)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LogAction", new object[8]
    {
      (object) "@userID",
      (object) this.UserID,
      (object) "@action",
      (object) action,
      (object) "@identifierGuid",
      (object) identifier,
      (object) "@Context",
      (object) context
    });
  }

  public void LogAction(string action, string context)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.LogAction", new object[6]
    {
      (object) "@userID",
      (object) this.UserID,
      (object) "@action",
      (object) action,
      (object) "@Context",
      (object) context
    });
  }

  public void LogChangeDetails(IEnumerable<ChangeDetail> changeList)
  {
    Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
    ITransactionLogFilter transactionLogFilter = ObjectFactory.QueryInterface<ITransactionLogFilter>((object) activeMdiChild);
    Guid? logIdentifierGuid = new Guid?();
    if (activeMdiChild != null)
    {
      if (activeMdiChild.InvokeRequired)
      {
        Form form = activeMdiChild;
        System.Func<ITransactionLogFilter, Guid?> method;
        // ISSUE: reference to a compiler-generated field
        if (CurrentUser._Closure\u0024__.\u0024I126\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          method = CurrentUser._Closure\u0024__.\u0024I126\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          CurrentUser._Closure\u0024__.\u0024I126\u002D0 = method = (System.Func<ITransactionLogFilter, Guid?>) ([SpecialName] (t) => t?.LogIdentifier);
        }
        object[] objArray = new object[1]
        {
          (object) transactionLogFilter
        };
        logIdentifierGuid = (Guid?) form.Invoke((Delegate) method, objArray);
      }
      else
        logIdentifierGuid = (Guid?) transactionLogFilter?.LogIdentifier;
    }
    if (!logIdentifierGuid.HasValue)
    {
      string str = "unknown type";
      if (transactionLogFilter != null)
        str = transactionLogFilter.GetType().FullName;
      else if (activeMdiChild != null)
        str = activeMdiChild.GetType().FullName;
      throw new InvalidOperationException($"Active Window ({str}) must implement ITransactionLogFilter and return a non null LogIdentifier");
    }
    this.LogChangeDetails(changeList, logIdentifierGuid);
  }

  public void LogChangeDetails(IEnumerable<ChangeDetail> changeList, Guid? logIdentifierGuid)
  {
    CurrentUser currentUser = this;
    IEnumerable<ChangeDetail> changeList1 = changeList;
    Guid? logIdentifierGuid1 = logIdentifierGuid;
    if (changeList1 == null)
      throw new ArgumentNullException(nameof (changeList));
    try
    {
      if (Utility.CanExecuteThread())
        Utility.ExecuteThread((DoWorkEventHandler) ([SpecialName] (sender, e) => currentUser.LogChangeDetailsInternal(changeList1, logIdentifierGuid1)), (RunWorkerCompletedEventHandler) null, (ProgressChangedEventHandler) null);
      else
        this.LogChangeDetailsInternal(changeList1, logIdentifierGuid1);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void LogChangeDetailsInternal(
    IEnumerable<ChangeDetail> changeList,
    Guid? logIdentifierGuid)
  {
    try
    {
      foreach (ChangeDetail change in changeList)
      {
        string dataKeyInfo;
        string action;
        if (change.ObjectThatChanged is INotifyCollectionChanged)
        {
          dataKeyInfo = SqlAdapter.GetDataKeyInfo(RuntimeHelpers.GetObjectValue(change.Value), (DataKeyType) 0);
          action = $"{change.PriorValue} {change.Value.GetType().Name} PK: {dataKeyInfo} {(Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) change.PriorValue, "Added", false) == 0 ? (object) "to" : (object) "from")} {change.Property}";
        }
        else
        {
          dataKeyInfo = SqlAdapter.GetDataKeyInfo((object) change.ObjectThatChanged, (DataKeyType) 0);
          action = $"{CurrentUser.ResolveDescription(change.ObjectThatChanged.GetType())} PK: {dataKeyInfo}: Changed {change.Property}, From {change.PriorValue} to {change.Value}";
        }
        if (logIdentifierGuid.HasValue)
          this.LogAction(action, logIdentifierGuid.Value, dataKeyInfo);
        else
          this.LogAction(action, dataKeyInfo);
      }
    }
    finally
    {
      IEnumerator<ChangeDetail> enumerator;
      enumerator?.Dispose();
    }
  }

  private static string ResolveDescription(Type type, string propertyName = null)
  {
    DescriptionAttribute[] source = string.IsNullOrEmpty(propertyName) ? (DescriptionAttribute[]) type.GetCustomAttributes(typeof (DescriptionAttribute), true) : (DescriptionAttribute[]) type.GetProperty(propertyName).GetCustomAttributes(typeof (DescriptionAttribute), true);
    return source.Length != 1 ? propertyName ?? type.Name : ((IEnumerable<DescriptionAttribute>) source).First<DescriptionAttribute>().Description;
  }

  public enum WordVersion
  {
    None = 0,
    Office2000 = 9,
    OfficeXP = 10, // 0x0000000A
    Office2003 = 11, // 0x0000000B
  }

  public enum AccessPoints
  {
    None,
    Internal,
    External,
    Both,
  }

  public enum OfficeApps
  {
    Access,
    Excel,
    PowerPoint,
    Word,
    Outlook,
  }
}
