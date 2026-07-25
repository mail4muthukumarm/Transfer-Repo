// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ClarionDoorRaterBrowserHost
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Controls.Wpf;
using MGASystems.Common.Enums;
using MGASystems.Common.SelectSys;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DocumentFolderFilter("Policy Detail")]
[DesignerGenerated]
public class ClarionDoorRaterBrowserHost : MgaMdiChild, IComponentConnector
{
  private readonly ClarionDoorRater _clarionDoorRater;
  private bool _contentLoaded;

  public ClarionDoorRaterBrowserHost(ClarionDoorRater clarionDoorRater)
  {
    this.InitializeComponent();
    this._clarionDoorRater = clarionDoorRater;
  }

  private void MgaMdiChild_Loaded(object sender, RoutedEventArgs e)
  {
    this.Form.WindowState = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ClarionDoorRater.BrowserRatingWindow.StartMaximized", false) ? FormWindowState.Maximized : FormWindowState.Normal;
    this.Form.FormClosing += new FormClosingEventHandler(this.Form_FormClosing);
    this.tbStatusLabel.Text = "Sending Quote Info to Clarion Door, please wait...";
  }

  private void Form_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.webBrowser.ReleaseWebBrowserControl();
    this.Form.FormClosing -= new FormClosingEventHandler(this.Form_FormClosing);
  }

  private void WebBrowser_LoadCompleted(object sender, EventArgs e)
  {
    this.pbRater.Visibility = Visibility.Hidden;
    this.tbStatusLabel.Text = "Ready";
  }

  private async void WebBrowser_BrowserInitialized(object sender, EventArgs e)
  {
    if (!ClarionDoorApiSettings.IsValid())
    {
      int num = (int) System.Windows.MessageBox.Show("User credentials not found for Clarion Door Rater Access.", "Missing User Credentials", MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Form.Close();
    }
    else
      await this.InitializeClarionBrowser(this._clarionDoorRater.QuoteGuid);
  }

  private async Task InitializeClarionBrowser(Guid quoteGuid)
  {
    try
    {
      using (HttpClient httpClient = new HttpClient()
      {
        Timeout = TimeSpan.FromMinutes(10.0)
      })
      {
        Encryption encryption = new Encryption();
        DataCaptureClientApi captureClientApi = new DataCaptureClientApi(ClarionDoorApiSettings.Url, httpClient);
        AuthResponse authResponse = await captureClientApi.AuthenticateAsync(new AuthRequest()
        {
          Username = ClarionDoorApiSettings.UserName,
          Password = encryption.DecryptTripleDes(ClarionDoorApiSettings.EncryptedPassword)
        });
        if (!authResponse.Status)
        {
          int num1 = (int) System.Windows.MessageBox.Show(authResponse.Message);
        }
        else
        {
          httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResponse.Token);
          Quote quote = new Quote(quoteGuid);
          ClarionDoor_ServiceResponse doorServiceResponse;
          if (quote.IsEndorsement && quote.QuoteStatus == QuoteStatus.PendingCancellation)
          {
            object[] objArray = new object[4]
            {
              (object) "@quoteGuid",
              (object) quoteGuid,
              (object) "@userId",
              (object) CurrentUser.Instance.UserID
            };
            doorServiceResponse = await captureClientApi.CancellationAsync(DefaultDatabase.ExecuteScalar<string>("SelectSys_ClarionDoor_CancellationRequestInputJson", objArray));
          }
          else if (quote.IsEndorsement && quote.QuoteStatus == QuoteStatus.PendingReinstatement)
          {
            object[] objArray = new object[4]
            {
              (object) "@quoteGuid",
              (object) quoteGuid,
              (object) "@userId",
              (object) CurrentUser.Instance.UserID
            };
            doorServiceResponse = await captureClientApi.ReinstatementAsync(DefaultDatabase.ExecuteScalar<string>("SelectSys_ClarionDoor_ReinstatementRequestInputJson", objArray));
          }
          else if (quote.IsEndorsement)
          {
            object[] objArray = new object[4]
            {
              (object) "@quoteGuid",
              (object) quoteGuid,
              (object) "@userId",
              (object) CurrentUser.Instance.UserID
            };
            doorServiceResponse = await captureClientApi.EndorsementAsync(DefaultDatabase.ExecuteScalar<string>("SelectSys_ClarionDoor_EndorsementRequestInputJson", objArray));
          }
          else if (quote.IsRenewal)
          {
            EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("SelectSys_ClarionDoor_RenewalRequestInputJson", new object[4]
            {
              (object) "@quoteGuid",
              (object) quoteGuid,
              (object) "@userId",
              (object) CurrentUser.Instance.UserID
            }).AsEnumerable();
            System.Func<DataRow, string> selector;
            // ISSUE: reference to a compiler-generated field
            if (ClarionDoorRaterBrowserHost._Closure\u0024__.\u0024I6\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              selector = ClarionDoorRaterBrowserHost._Closure\u0024__.\u0024I6\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              ClarionDoorRaterBrowserHost._Closure\u0024__.\u0024I6\u002D0 = selector = (System.Func<DataRow, string>) ([SpecialName] (row) => row.Field<string>(0));
            }
            EnumerableRowCollection<string> values = source.Select<DataRow, string>(selector);
            doorServiceResponse = await captureClientApi.RenewalAsync(string.Join("", (IEnumerable<string>) values));
          }
          else
          {
            object[] objArray = new object[4]
            {
              (object) "@quoteGuid",
              (object) quoteGuid,
              (object) "@userId",
              (object) CurrentUser.Instance.UserID
            };
            doorServiceResponse = await captureClientApi.GetClarionDoorResponseAsync(DefaultDatabase.ExecuteScalar<string>("SelectSys_ClarionDoor_ClarionDoorRequestInputJSON", objArray));
          }
          if (doorServiceResponse != null && !doorServiceResponse.Status)
          {
            int num2 = (int) System.Windows.MessageBox.Show($"{doorServiceResponse.Message}{"\r\n"}{captureClientApi.BaseUrl}", "An error occurred while calling GetClarionDoorResponse.", MessageBoxButton.OK, MessageBoxImage.Hand);
            this.Form.Close();
          }
          else if (ClarionDoorApiSettings.UseClarionSSO)
          {
            string source = $"https://redstone.clariondoor.com/api/users?sso=true&quoteId={quote.QuoteID}";
            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClarionDoorApiSettings.UserNameSSO}:{encryption.DecryptTripleDes(ClarionDoorApiSettings.EncryptedPasswordSSO)}"));
            this.webBrowser.Navigate(source, Array.Empty<byte>(), $"Authorization: Basic {base64String}");
          }
          else
            this.webBrowser.Navigate(doorServiceResponse.Url);
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) System.Windows.MessageBox.Show($"Base URL: {ClarionDoorApiSettings.Url}{"\r\n"}{"\r\n"}{ex}", "An error occurred while calling GetClarionDoorResponse.", MessageBoxButton.OK, MessageBoxImage.Hand);
      ProjectData.ClearProjectError();
    }
  }

  [field: AccessedThroughProperty("webBrowser")]
  internal virtual MGAWebView webBrowser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tbStatusLabel")]
  internal virtual TextBlock tbStatusLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pbRater")]
  internal virtual System.Windows.Controls.ProgressBar pbRater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    System.Windows.Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Rating;component/raters/clarion%20door/clariondoorraterbrowserhost.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        ((FrameworkElement) target).Loaded += new RoutedEventHandler(this.MgaMdiChild_Loaded);
        break;
      case 2:
        this.webBrowser = (MGAWebView) target;
        this.webBrowser.LoadCompleted += new EventHandler(this.WebBrowser_LoadCompleted);
        this.webBrowser.BrowserInitialized += new EventHandler(this.WebBrowser_BrowserInitialized);
        break;
      case 3:
        this.tbStatusLabel = (TextBlock) target;
        break;
      case 4:
        this.pbRater = (System.Windows.Controls.ProgressBar) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}
