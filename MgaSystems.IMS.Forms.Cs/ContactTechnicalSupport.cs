// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.ContactTechnicalSupport
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using MGASystems.Common;
using MGASystems.Common.Controls.Wpf;
using MGASystems.Common.Email;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace MgaSystems.IMS.Forms;

public class ContactTechnicalSupport
{
  public void SendMessage()
  {
    this.GetHashAndDisplayMailItem(ContactTechnicalSupport.GetImsInstallInfo().Union<KeyValuePair<string, object>>((IEnumerable<KeyValuePair<string, object>>) ContactTechnicalSupport.GetActiveFormInfo()).ToDictionary<KeyValuePair<string, object>, string, object>((Func<KeyValuePair<string, object>, string>) (pair => pair.Key), (Func<KeyValuePair<string, object>, object>) (pair => pair.Value)));
  }

  private void GetHashAndDisplayMailItem(Dictionary<string, object> values)
  {
    string path = Path.Combine(MGATempFolder.CreateTempSubdirectory(), "IMS Client Spec.xml");
    File.WriteAllText(path, ContactTechnicalSupport.GenerateClientXml(values));
    string str1 = "<br><br><table border = '1'>";
    foreach (KeyValuePair<string, object> keyValuePair in values)
      str1 += $"<tr><td>{keyValuePair.Key}</td><td>{keyValuePair.Value}</td></tr>";
    string str2 = str1 + "</table><br><br>";
    CurrentUser.Instance.Email.SendMail(new MessageObject()
    {
      Recipients = {
        "techsupport@mgasystems.com"
      },
      FileAttachments = {
        path
      },
      Subject = "Local IMS Installed Files",
      HTMLBody = str2,
      SendOutlook = OutlookSendType.Show
    });
  }

  internal static string GenerateClientXml(Dictionary<string, object> values)
  {
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.LoadXml("<IMSHashFiles></IMSHashFiles>");
    foreach (KeyValuePair<string, object> keyValuePair in values)
    {
      if (xmlDocument.DocumentElement.Attributes[keyValuePair.Key] == null)
      {
        XmlAttribute attribute = xmlDocument.CreateAttribute(keyValuePair.Key);
        attribute.Value = keyValuePair.Value.ToString();
        xmlDocument.DocumentElement.Attributes.Append(attribute);
      }
    }
    XmlNode documentElement = (XmlNode) xmlDocument.DocumentElement;
    foreach (FileInfo file in new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).GetFiles())
    {
      XmlElement element = xmlDocument.CreateElement("IMSHashFile");
      element.SetAttribute("Name", file.Name);
      element.SetAttribute("Hash", ContactTechnicalSupport.HashFile(file.Name));
      documentElement.AppendChild((XmlNode) element);
    }
    using (StringWriter w1 = new StringWriter())
    {
      using (XmlTextWriter w2 = new XmlTextWriter((TextWriter) w1))
      {
        w2.Formatting = Formatting.Indented;
        xmlDocument.WriteTo((XmlWriter) w2);
        w2.Flush();
        return w1.ToString();
      }
    }
  }

  internal static Dictionary<string, object> GetActiveFormInfo()
  {
    Dictionary<string, object> activeFormInfo = new Dictionary<string, object>();
    Form activeMdiChild = MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild != null)
    {
      activeFormInfo.Add("ActiveFormTitle", (object) activeMdiChild.Text);
      IRecreatableEntity recreatableEntity = ObjectFactory.QueryInterface<IRecreatableEntity>((object) activeMdiChild);
      if (recreatableEntity != null)
      {
        activeFormInfo.Add("RecreateTypeName", (object) recreatableEntity.RecreateTypeName);
        activeFormInfo.Add("EntityName", (object) recreatableEntity.EntityName);
        activeFormInfo.Add("EntityGuid", (object) recreatableEntity.EntityGuid);
        activeFormInfo.Add("CanReCreateEntity", (object) recreatableEntity.CanReCreateEntity);
        if (recreatableEntity.HasControlGUID)
          activeFormInfo.Add("ControlNumber", (object) DefaultDatabase.ExecuteScalar<int>("GetControlNumberFromControlGuid", new object[2]
          {
            (object) "@ControlGuid",
            (object) recreatableEntity.ControlGUID
          }));
      }
    }
    return activeFormInfo;
  }

  internal static Dictionary<string, object> GetImsInstallInfo()
  {
    Dictionary<string, object> imsInstallInfo = new Dictionary<string, object>();
    DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
    imsInstallInfo.Add("InstallPath", (object) directoryInfo);
    imsInstallInfo.Add("ClientUpdateKey", (object) XDocument.Load(Path.Combine(directoryInfo.FullName, "ims.exe.config")).XPathSelectElement("configuration/appSettings/add[@key = 'UpdatePackageKey']").Attribute((XName) "value").Value);
    imsInstallInfo.Add("OSVersion", (object) Environment.OSVersion.VersionString);
    imsInstallInfo.Add("Is64BitOS", (object) Environment.Is64BitOperatingSystem);
    imsInstallInfo.Add("IsTerminalServerSession", (object) SystemInformation.TerminalServerSession);
    imsInstallInfo.Add("DotNet45PlusVersion", (object) ContactTechnicalSupport.Get45PlusFromRegistry());
    imsInstallInfo.Add("WebViewVersion", (object) MGAWebView.AvailableBrowserVersionString);
    imsInstallInfo.Add("UpdateDate", (object) ((IEnumerable<FileInfo>) directoryInfo.GetFiles()).Where<FileInfo>((Func<FileInfo, bool>) (fi => !fi.Name.Equals("IMS_Update.exe", StringComparison.InvariantCultureIgnoreCase))).Max<FileInfo, DateTime>((Func<FileInfo, DateTime>) (fi => fi.CreationTime)).ToString("O"));
    return imsInstallInfo;
  }

  private static string Get45PlusFromRegistry()
  {
    try
    {
      using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
      {
        if (registryKey != null)
        {
          if (registryKey.GetValue("Release") != null)
            return ContactTechnicalSupport.CheckFor45PlusVersion((int) registryKey.GetValue("Release"));
        }
      }
    }
    catch (Exception ex)
    {
      ErrorHandler.SilentLogError(ex);
    }
    return ".NET Framework Version 4.5 or later is not detected.";
  }

  private static string CheckFor45PlusVersion(int releaseKey)
  {
    string str = "No 4.5 or later version detected";
    if (releaseKey >= 528040)
      str = "4.8 or later";
    else if (releaseKey >= 461808)
      str = "4.7.2";
    else if (releaseKey >= 461308)
      str = "4.7.1";
    else if (releaseKey >= 460798)
      str = "4.7";
    else if (releaseKey >= 394802)
      str = "4.6.2";
    else if (releaseKey >= 394254)
      str = "4.6.1";
    else if (releaseKey >= 393295)
      str = "4.6";
    else if (releaseKey >= 379893)
      str = "4.5.2";
    else if (releaseKey >= 378675)
      str = "4.5.1";
    else if (releaseKey >= 378389)
      str = "4.5";
    return str;
  }

  private static string HashFile(string filename)
  {
    using (MD5 md5 = MD5.Create())
    {
      using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
      {
        using (BufferedStream inputStream = new BufferedStream((Stream) fileStream, 524288 /*0x080000*/))
          return BitConverter.ToString(md5.ComputeHash((Stream) inputStream)).Replace("-", "");
      }
    }
  }
}
