// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Utility.EmailBodyUtility
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.Settings;
using System;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Utility;

public static class EmailBodyUtility
{
  public static void AppendTabs(ref StringBuilder sb) => sb.Append('\t');

  public static void AppendCarriageReturn(ref StringBuilder sb, int numberOfCarriageReturns)
  {
    for (int index = 0; index < numberOfCarriageReturns; ++index)
      sb.Append(EmailBodyUtility.ReplaceCarriageReturnsIfHtml(Environment.NewLine));
  }

  public static string ReplaceCarriageReturnsIfHtml(string text)
  {
    return !string.IsNullOrEmpty(text) && SystemSettings.GetSetting<bool>("Email.SmtpOutlook.Default.ForceHtml") ? text.Replace("\r\n", "<br>").Replace("\r", "<br>").Replace("\n", "<br>") : text;
  }
}
