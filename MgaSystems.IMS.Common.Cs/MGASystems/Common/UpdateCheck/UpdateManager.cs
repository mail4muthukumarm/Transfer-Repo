// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.UpdateCheck.UpdateManager
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Common.UpdateServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows;

#nullable disable
namespace MGASystems.Common.UpdateCheck;

internal class UpdateManager
{
  private static string ComputeMD5Hash(string fileName)
  {
    using (MD5 md5 = MD5.Create())
    {
      using (FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        return string.Concat(Array.ConvertAll<byte, string>(md5.ComputeHash((Stream) inputStream), (Converter<byte, string>) (b => b.ToString("X2"))));
    }
  }

  public static void BeginUpdateCheck()
  {
    UpdaterSettings updaterSettings = new UpdaterSettings();
    if (!updaterSettings.Valid)
    {
      int num = (int) MessageBox.Show("An error occurred while reading your updater configuration. Please run the MGA Systems Updater manually to check for updates.", "MGA Systems", MessageBoxButton.OK, MessageBoxImage.Hand);
    }
    else
    {
      FileInformation[] array = Directory.EnumerateFiles(UpdaterSettings.ApplicationDirectory).AsParallel<string>().Select<string, FileInformation>((Func<string, FileInformation>) (fileName => new FileInformation()
      {
        FileName = Path.GetFileName(fileName),
        FileHash = UpdateManager.ComputeMD5Hash(fileName)
      })).Where<FileInformation>((Func<FileInformation, bool>) (item => !item.FileName.EqualsNoCase("IMS_Update.exe"))).ToArray<FileInformation>();
      MGASystems.Common.UpdateServices.UpdateServices updateServices = new MGASystems.Common.UpdateServices.UpdateServices();
      updateServices.Url = updaterSettings.UpdateServicesUrl;
      updateServices.GetAvailableUpdatesCompleted += new GetAvailableUpdatesCompletedEventHandler(UpdateManager.UpdateServices_GetAvailableUpdatesCompleted);
      updateServices.GetAvailableUpdatesAsync(updaterSettings.UpdatePackageKey, array);
    }
  }

  private static void UpdateServices_GetAvailableUpdatesCompleted(
    object sender,
    GetAvailableUpdatesCompletedEventArgs e)
  {
    MGASystems.Common.UpdateServices.UpdateServices updateServices = (MGASystems.Common.UpdateServices.UpdateServices) sender;
    updateServices.GetAvailableUpdatesCompleted -= new GetAvailableUpdatesCompletedEventHandler(UpdateManager.UpdateServices_GetAvailableUpdatesCompleted);
    updateServices.Dispose();
    if (e.Error != null)
    {
      int num = (int) MessageBox.Show("An error occurred contacting the MGA Systems update service. For more detailed information please run the MGA Systems Updater manually.", "MGA Systems", MessageBoxButton.OK, MessageBoxImage.Hand);
      ErrorHandler.SilentHandleError(e.Error);
    }
    else if (((IEnumerable<FileInformation>) e.Result).Any<FileInformation>())
    {
      if (MessageBox.Show("There are currently updates available.\nClick OK to restart and apply updates.", "MGA Systems", MessageBoxButton.OKCancel, MessageBoxImage.Asterisk) != MessageBoxResult.OK)
        return;
      MDIControls.Instance.MDIParent.Close();
      if (MDIControls.Instance.MDIParent.IsHandleCreated)
        return;
      AppDomain.CurrentDomain.ProcessExit += new EventHandler(UpdateManager.CurrentDomain_ProcessExit);
    }
    else
    {
      int num1 = (int) MessageBox.Show("There are currently no updates available.", "MGA Systems", MessageBoxButton.OK, MessageBoxImage.Asterisk);
    }
  }

  private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
  {
    UpdaterSettings updaterSettings = new UpdaterSettings();
    if (!updaterSettings.Valid)
      return;
    Process.Start(new ProcessStartInfo(updaterSettings.UpdaterPath)
    {
      WorkingDirectory = UpdaterSettings.ApplicationDirectory
    });
  }
}
