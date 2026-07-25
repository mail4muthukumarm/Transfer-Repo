// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.ViewModels.TestViewModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Data.Binding;
using MgaSystems.IMS.TechTools.Models;
using MGASystems.MGATestHarness.MGATestHarnessLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

#nullable disable
namespace MgaSystems.IMS.TechTools.ViewModels;

public abstract class TestViewModel : BindingObject
{
  private readonly Dictionary<string, ICollection<string>> parameters = new Dictionary<string, ICollection<string>>();

  [NotificationProperty]
  public virtual List<TestModel> Tests { get; set; } = new List<TestModel>();

  [NotificationProperty]
  public virtual int SelectedIndex { get; set; }

  [NotificationProperty]
  public virtual string TestResult { get; set; }

  [NotificationProperty]
  [DependsOn("TestResult")]
  public virtual string TestOutput { get; set; }

  [NotificationProperty]
  public virtual bool IsBusy { get; set; }

  public static TestViewModel Create() => NotifyProxyTypeManager.Allocate<TestViewModel>();

  public TestViewModel()
  {
    List<string> stringList = new List<string>()
    {
      "google.com",
      "mgasystems.com"
    };
    this.parameters.Add("ims.exe.config", (ICollection<string>) new List<string>()
    {
      Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ims.exe.config")
    });
    string[] includedKeys = new string[4]
    {
      "LogOnServer",
      "WebServicesLogonUrl",
      "WebServicesInvoicingUrl",
      "AddressServiceURL"
    };
    foreach (string filename in this.parameters["ims.exe.config"].Where<string>(new Func<string, bool>(File.Exists)))
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(filename);
      XmlNodeList source = xmlDocument.SelectNodes("/configuration/appSettings/add/@value");
      if (source != null)
      {
        List<string> list1 = source.OfType<XmlAttribute>().Where<XmlAttribute>((Func<XmlAttribute, bool>) (a => ((IEnumerable<string>) includedKeys).Contains<string>(a.OwnerElement?.GetAttribute("key")))).GroupBy<XmlAttribute, string>((Func<XmlAttribute, string>) (a => a.Value)).Select<IGrouping<string, XmlAttribute>, string>((Func<IGrouping<string, XmlAttribute>, string>) (g => g.Key)).ToList<string>();
        List<string> list2 = list1.Where<string>((Func<string, bool>) (s => Uri.TryCreate(s, UriKind.Absolute, out Uri _))).ToList<string>();
        if (!this.parameters.ContainsKey("url"))
          this.parameters.Add("url", (ICollection<string>) new List<string>());
        this.parameters["url"] = (ICollection<string>) this.parameters["url"].Union<string>((IEnumerable<string>) list2).ToList<string>();
        IEnumerable<string> second = list1.Where<string>((Func<string, bool>) (s => Uri.CheckHostName(s) != 0)).Union<string>(list2.Select<string, string>((Func<string, string>) (url => new Uri(url).DnsSafeHost)));
        stringList = stringList.Union<string>(second).ToList<string>();
      }
    }
    if (stringList.Any<string>())
      this.parameters.Add("hostname", (ICollection<string>) stringList);
    List<TestModel> list = new TestRunner(this.parameters).GetAllTestables().Select<ITestable, TestModel>((Func<ITestable, TestModel>) (t => new TestModel(t.GetDisplayName(), t))).ToList<TestModel>();
    this.Tests.Add(new TestModel("Run All", (ITestable) new RunAll((ICollection<ITestable>) list.Select<TestModel, ITestable>((Func<TestModel, ITestable>) (t => t.Test)).ToList<ITestable>())));
    this.Tests.AddRange((IEnumerable<TestModel>) list);
    this.SelectedIndex = 0;
  }

  public RelayCommand<TestModel> RunTestCommand
  {
    get
    {
      return new RelayCommand<TestModel>((Action<TestModel>) (async testModel =>
      {
        this.IsBusy = true;
        await Task.Run((Action) (() =>
        {
          testModel.Test.RunTest();
          string displayName = testModel.Test.GetDisplayName();
          this.TestResult = testModel.Test.GetTestResult().ToString();
          List<string> list = testModel.Test.GetResultExplanation().ToList<string>();
          if (displayName == "Run All")
            this.TestOutput = $"{displayName} : {this.TestResult}\n{string.Join("\n", list.ToArray())}";
          else
            this.TestOutput = $"{displayName} : {this.TestResult}\n\t{string.Join("\n\t", list.ToArray())}";
          list.Clear();
        }));
        this.IsBusy = false;
      }), (Predicate<TestModel>) (testModel => testModel != null));
    }
  }
}
