// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ClassObjects.AccountingProvider
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Services.Forms;
using MGASystems.IMS.Accounting.Services.Properties;
using System.Drawing;
using System.Reflection;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ClassObjects;

public class AccountingProvider : IAccountingExplorerProvider
{
  public UltraExplorerBarItem[] ProvideTools()
  {
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem("CHANGECOSTCENTER");
    ultraExplorerBarItem1.Text = "Edit Transaction Cost Centers";
    ((SubObjectBase) ultraExplorerBarItem1).Tag = (object) new object[3]
    {
      (object) typeof (formChangeCostCenter),
      (object) false,
      (object) "{FFF36592-F453-47D4-BA77-932263BC209F}"
    };
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance.Image = (object) Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.Services.Images.menuicon.png"));
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem("NOCBLACKOUTDATES");
    ultraExplorerBarItem2.Text = "Automated NOC Blackout Dates";
    ((SubObjectBase) ultraExplorerBarItem2).Tag = (object) new object[2]
    {
      (object) typeof (FormNOCDeactivation),
      (object) false
    };
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance.Image = (object) Resources.calendar_edit;
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem("OVERDUEINVOICEEMAIL");
    ultraExplorerBarItem3.Text = "Overdue Invoice Email Utility";
    ((SubObjectBase) ultraExplorerBarItem3).Tag = (object) new object[3]
    {
      (object) typeof (FormOverdueInvoices),
      (object) false,
      (object) "{5918B7F5-4210-4E17-87D9-D9EC0CBDDDA3}"
    };
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance.Image = (object) Resources.email;
    UltraExplorerBarItem ultraExplorerBarItem4 = new UltraExplorerBarItem("WEBSERVICEBANKSETTINGS");
    ultraExplorerBarItem4.Text = "Web Service Bank Settings";
    ((SubObjectBase) ultraExplorerBarItem4).Tag = (object) new object[3]
    {
      (object) typeof (formWSDefaultBankSettings),
      (object) true,
      (object) "{0DFDA4A7-5C59-476F-ABD8-E143F22A6A2C}"
    };
    ultraExplorerBarItem4.Settings.AppearancesSmall.Appearance.Image = (object) Resources.building;
    return new UltraExplorerBarItem[3]
    {
      ultraExplorerBarItem1,
      ultraExplorerBarItem3,
      ultraExplorerBarItem4
    };
  }

  public UltraExplorerBarItem[] ProvideAdministrativeOptions() => (UltraExplorerBarItem[]) null;

  public UltraExplorerBarGroup BuildExplorerMenu() => (UltraExplorerBarGroup) null;

  public int ExplorerMenuIndex => 0;
}
