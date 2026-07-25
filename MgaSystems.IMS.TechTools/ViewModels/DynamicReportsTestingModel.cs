// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.ViewModels.DynamicReportsTestingModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using GrapeCity.ActiveReports;
using Mga.Wpf.Ims.Commands;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using MgaSystems.IMS.TechTools.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.TechTools.ViewModels;

public abstract class DynamicReportsTestingModel : BindingObject
{
  [NotificationProperty]
  public virtual ObservableCollection<ReportModel> Reports { get; set; } = new ObservableCollection<ReportModel>();

  public virtual ObservableCollection<QuoteModel> QuoteIDs { get; set; } = new ObservableCollection<QuoteModel>();

  public virtual string ControlID { get; set; }

  public virtual string QuoteID { get; set; }

  [NotificationProperty]
  public virtual bool IsBusy { get; set; }

  public static DynamicReportsTestingModel Create()
  {
    return NotifyProxyTypeManager.Allocate<DynamicReportsTestingModel>();
  }

  public DynamicReportsTestingModel()
  {
    this.QuoteIDs.Add(new QuoteModel(0, Guid.Empty));
    List<Type> list = ((IEnumerable<Type>) ObjectFactory.Instance.QueryTypesWithInterface(typeof (IQuoteDocument))).OrderBy<Type, string>((System.Func<Type, string>) (t => t.FullName)).ToList<Type>();
    Type[] types = new Type[1]{ typeof (Guid) };
    foreach (Type test in list)
    {
      try
      {
        if (!test.IsAbstract)
        {
          if (test.IsSubclassOf(typeof (SectionReport)))
          {
            if (test.GetConstructor(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public, (Binder) null, CallingConventions.HasThis, types, (ParameterModifier[]) null) != (ConstructorInfo) null)
              this.Reports.Add(new ReportModel(test.FullName, test));
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString(), "Error loading reports");
      }
    }
  }

  public RelayCommand RunGetQuoteIDsCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        this.IsBusy = true;
        if (!int.TryParse(this.ControlID, out int _))
        {
          int num = (int) MessageBox.Show("Error with values entered.", "Control ID must be an integer.");
          this.IsBusy = false;
        }
        else
        {
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT q.QuoteID, q.QuoteGuid FROM dbo.tblQuotes q INNER JOIN dbo.tblQuoteOptions qo ON qo.QuoteGUID = q.QuoteGUID WHERE q.ControlNo = @ControlNo", new object[2]
          {
            (object) "@ControlNo",
            (object) this.ControlID
          });
          this.QuoteIDs.Clear();
          if (dataTable.Rows.Count == 0)
          {
            int num = (int) MessageBox.Show("Control Number does not have a Quote ID that contains a non null Quote Option, please try another.", "Invalid Control Number");
            this.IsBusy = false;
          }
          else
          {
            foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
              this.QuoteIDs.Add(new QuoteModel(row.Field<int>("QuoteID"), row.Field<Guid>("QuoteGuid")));
            this.IsBusy = false;
          }
        }
      }));
    }
  }

  public RelayCommand<ReportModel> RunReportCommand
  {
    get
    {
      return new RelayCommand<ReportModel>((Action<ReportModel>) (reportModel =>
      {
        this.IsBusy = true;
        try
        {
          if (string.IsNullOrEmpty(this.ControlID) || string.IsNullOrEmpty(this.QuoteID))
          {
            int num = (int) MessageBox.Show("Error with values entered.", "QuoteID must be selected.");
            this.IsBusy = false;
          }
          else
          {
            Guid guid1 = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "Select TOP 1 QuoteGUID from tblQuotes q WHERE q.QuoteID = @QuoteID", new object[2]
            {
              (object) "@QuoteID",
              (object) this.QuoteID
            });
            Guid guid2 = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "Select TOP 1 QuoteOptionGUID FROM tblQuoteOptions WHERE QuoteGUID = @QuoteGUID", new object[2]
            {
              (object) "@QuoteGUID",
              (object) guid1
            });
            SectionReport objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<SectionReport>(reportModel.TypeOfReport, (object) guid1);
            if (objectTypeAs is IQuoteDocument quoteDocument2 && quoteDocument2.RequiresQuoteOptionGuids())
              quoteDocument2.SetQuoteOptionGuids(new Guid[1]
              {
                guid2
              });
            objectTypeAs.Run();
            new frmPrint(objectTypeAs)
            {
              MdiParent = MDIControls.Instance.MDIParent
            }.Show();
          }
        }
        catch (NullReferenceException ex)
        {
          int num = (int) MessageBox.Show("There is no Quote Option for the current Quote ID, please try another.", "Quote Option is NULL");
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.ToString(), "Error running report");
        }
        finally
        {
          this.IsBusy = false;
        }
      }), (Predicate<ReportModel>) (reportModel => reportModel != null));
    }
  }
}
