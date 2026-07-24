// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseSchedule
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class ExpenseSchedule
{
  private Utilities.SchedulingType schedulingType;
  private DateTime dueDate;
  private int numberOfOccurences;
  private int occursEvery;
  private Utilities.OccurenceDays occurenceDays;
  private bool isReOccurring;
  private ScheduleDetailCollection breakout;
  private PurchaseOrderExpense parent;
  private int biMonthlyFirstOccurence;
  private int biMonthlySecondOccurence;
  private DateTime startDate;
  private Utilities.ExpenseScheduleJournalType scheduleJournalType;

  public ExpenseSchedule(PurchaseOrderExpense Parent)
  {
    this.parent = Parent;
    this.numberOfOccurences = 0;
    this.dueDate = DateTime.Now;
    this.occurenceDays = Utilities.OccurenceDays.None;
    this.occursEvery = Convert.ToInt32(DateTime.Now.Day);
    this.schedulingType = Utilities.SchedulingType.None;
  }

  public ExpenseSchedule(
    Utilities.SchedulingType ScheduleType,
    DateTime dueDate,
    int OccurNumber,
    int OccursEvery,
    Utilities.OccurenceDays OccurDays,
    PurchaseOrderExpense Parent)
  {
    this.parent = Parent;
    this.schedulingType = ScheduleType;
    this.dueDate = dueDate;
    this.numberOfOccurences = OccurNumber;
    this.occursEvery = OccursEvery;
    this.occurenceDays = OccurDays;
  }

  public Utilities.SchedulingType ScheduleType
  {
    get => this.schedulingType;
    set => this.schedulingType = value;
  }

  public DateTime DueDate
  {
    get => this.dueDate;
    set => this.dueDate = value;
  }

  public int NumberOfOccurences
  {
    get => this.numberOfOccurences;
    set => this.numberOfOccurences = value;
  }

  public int OccursEvery
  {
    get => this.occursEvery;
    set => this.occursEvery = value;
  }

  public Utilities.OccurenceDays OccurenceDays
  {
    get => this.occurenceDays;
    set => this.occurenceDays = value;
  }

  public bool IsReOccurring
  {
    get => this.isReOccurring;
    set => this.isReOccurring = value;
  }

  public ScheduleDetailCollection ScheduleBreakout
  {
    get
    {
      this.BuildScheduleBreakout();
      return this.breakout;
    }
  }

  public PurchaseOrderExpense Parent => this.parent;

  public int BiMonthlyFirstOccurrence
  {
    get => this.biMonthlyFirstOccurence;
    set => this.biMonthlyFirstOccurence = value;
  }

  public int BiMonthlySecondOccurrence
  {
    get => this.biMonthlySecondOccurence;
    set => this.biMonthlySecondOccurence = value;
  }

  public DateTime StartDate
  {
    get => this.startDate;
    set => this.startDate = value;
  }

  public Utilities.ExpenseScheduleJournalType ScheduleJournalType
  {
    get => this.scheduleJournalType;
    set => this.scheduleJournalType = value;
  }

  private Utilities.OccurenceDays DayOfWeekToOccurrenceDay(DayOfWeek Day)
  {
    Utilities.OccurenceDays occurrenceDay;
    switch (Day)
    {
      case DayOfWeek.Sunday:
        occurrenceDay = Utilities.OccurenceDays.Sunday;
        break;
      case DayOfWeek.Monday:
        occurrenceDay = Utilities.OccurenceDays.Monday;
        break;
      case DayOfWeek.Tuesday:
        occurrenceDay = Utilities.OccurenceDays.Tuesday;
        break;
      case DayOfWeek.Wednesday:
        occurrenceDay = Utilities.OccurenceDays.Wednesday;
        break;
      case DayOfWeek.Thursday:
        occurrenceDay = Utilities.OccurenceDays.Thursday;
        break;
      case DayOfWeek.Friday:
        occurrenceDay = Utilities.OccurenceDays.Friday;
        break;
      case DayOfWeek.Saturday:
        occurrenceDay = Utilities.OccurenceDays.Saturday;
        break;
      default:
        occurrenceDay = Utilities.OccurenceDays.None;
        break;
    }
    return occurrenceDay;
  }

  private DateTime GetNextDate(DateTime PreviousDate)
  {
    DateTime nextDate = DateTime.Now;
    switch (this.schedulingType)
    {
      case Utilities.SchedulingType.Daily:
        nextDate = PreviousDate.AddDays(1.0);
        break;
      case Utilities.SchedulingType.Weekly:
        if (this.OccurenceDays != Utilities.OccurenceDays.None)
        {
          switch (this.DayOfWeekToOccurrenceDay(PreviousDate.DayOfWeek))
          {
            case Utilities.OccurenceDays.Sunday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
            case Utilities.OccurenceDays.Monday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
            case Utilities.OccurenceDays.Tuesday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
            case Utilities.OccurenceDays.Wednesday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
            case Utilities.OccurenceDays.Thursday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
            case Utilities.OccurenceDays.Friday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
            case Utilities.OccurenceDays.Saturday:
              if ((this.OccurenceDays & Utilities.OccurenceDays.Sunday) == Utilities.OccurenceDays.Sunday)
              {
                nextDate = PreviousDate.AddDays(1.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Monday) == Utilities.OccurenceDays.Monday)
              {
                nextDate = PreviousDate.AddDays(2.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Tuesday) == Utilities.OccurenceDays.Tuesday)
              {
                nextDate = PreviousDate.AddDays(3.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Wednesday) == Utilities.OccurenceDays.Wednesday)
              {
                nextDate = PreviousDate.AddDays(4.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Thursday) == Utilities.OccurenceDays.Thursday)
              {
                nextDate = PreviousDate.AddDays(5.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Friday) == Utilities.OccurenceDays.Friday)
              {
                nextDate = PreviousDate.AddDays(6.0);
                break;
              }
              if ((this.OccurenceDays & Utilities.OccurenceDays.Saturday) == Utilities.OccurenceDays.Saturday)
              {
                nextDate = PreviousDate.AddDays(7.0);
                break;
              }
              break;
          }
        }
        else
          break;
        break;
      case Utilities.SchedulingType.TwoWeeks:
        nextDate = PreviousDate.AddDays(14.0);
        break;
      case Utilities.SchedulingType.Monthly:
        if (PreviousDate.Day != this.OccursEvery)
        {
          string[] strArray = new string[5]
          {
            PreviousDate.Month.ToString(),
            "/",
            null,
            null,
            null
          };
          int num = this.OccursEvery;
          strArray[2] = num.ToString();
          strArray[3] = "/";
          num = PreviousDate.Year;
          strArray[4] = num.ToString();
          PreviousDate = Convert.ToDateTime(string.Concat(strArray));
        }
        nextDate = PreviousDate.AddMonths(1);
        break;
      case Utilities.SchedulingType.BiMonthly:
        if (this.BiMonthlySecondOccurrence < 28 && PreviousDate.Day >= this.BiMonthlySecondOccurrence || PreviousDate.Day < this.BiMonthlyFirstOccurrence || this.BiMonthlySecondOccurrence > 28 && PreviousDate.Day > this.BiMonthlyFirstOccurrence)
        {
          if (this.BiMonthlySecondOccurrence < 28 && PreviousDate.Day >= this.BiMonthlySecondOccurrence || this.BiMonthlySecondOccurrence > 28 && PreviousDate.Day >= this.BiMonthlyFirstOccurrence)
            PreviousDate = PreviousDate.AddMonths(1);
          if (this.BiMonthlyFirstOccurrence > 28)
          {
            string[] strArray1 = new string[5]
            {
              PreviousDate.Month.ToString(),
              "/",
              null,
              null,
              null
            };
            int num = this.BiMonthlyFirstOccurrence;
            strArray1[2] = num.ToString();
            strArray1[3] = "/";
            num = PreviousDate.Year;
            strArray1[4] = num.ToString();
            if (!Information.IsDate((object) string.Concat(strArray1)))
            {
              int monthlyFirstOccurrence = this.BiMonthlyFirstOccurrence;
              while (true)
              {
                string[] strArray2 = new string[5];
                num = PreviousDate.Month;
                strArray2[0] = num.ToString();
                strArray2[1] = "/";
                strArray2[2] = monthlyFirstOccurrence.ToString();
                strArray2[3] = "/";
                num = PreviousDate.Year;
                strArray2[4] = num.ToString();
                if (!Information.IsDate((object) string.Concat(strArray2)))
                  --monthlyFirstOccurrence;
                else
                  break;
              }
              string[] strArray3 = new string[5];
              num = PreviousDate.Month;
              strArray3[0] = num.ToString();
              strArray3[1] = "/";
              strArray3[2] = monthlyFirstOccurrence.ToString();
              strArray3[3] = "/";
              num = PreviousDate.Year;
              strArray3[4] = num.ToString();
              nextDate = Convert.ToDateTime(string.Concat(strArray3));
              break;
            }
            string[] strArray4 = new string[5];
            num = PreviousDate.Month;
            strArray4[0] = num.ToString();
            strArray4[1] = "/";
            num = this.BiMonthlyFirstOccurrence;
            strArray4[2] = num.ToString();
            strArray4[3] = "/";
            num = PreviousDate.Year;
            strArray4[4] = num.ToString();
            nextDate = Convert.ToDateTime(string.Concat(strArray4));
            break;
          }
          string[] strArray = new string[5]
          {
            PreviousDate.Month.ToString(),
            "/",
            null,
            null,
            null
          };
          int num1 = this.BiMonthlyFirstOccurrence;
          strArray[2] = num1.ToString();
          strArray[3] = "/";
          num1 = PreviousDate.Year;
          strArray[4] = num1.ToString();
          nextDate = Convert.ToDateTime(string.Concat(strArray));
          break;
        }
        if (PreviousDate.Day >= this.BiMonthlyFirstOccurrence || PreviousDate.Day < this.BiMonthlySecondOccurrence)
        {
          if (this.BiMonthlySecondOccurrence > 28)
          {
            string[] strArray5 = new string[5]
            {
              PreviousDate.Month.ToString(),
              "/",
              null,
              null,
              null
            };
            int num = this.BiMonthlySecondOccurrence;
            strArray5[2] = num.ToString();
            strArray5[3] = "/";
            num = PreviousDate.Year;
            strArray5[4] = num.ToString();
            if (!Information.IsDate((object) string.Concat(strArray5)))
            {
              int secondOccurrence = this.BiMonthlySecondOccurrence;
              while (true)
              {
                string[] strArray6 = new string[5];
                num = PreviousDate.Month;
                strArray6[0] = num.ToString();
                strArray6[1] = "/";
                strArray6[2] = secondOccurrence.ToString();
                strArray6[3] = "/";
                num = PreviousDate.Year;
                strArray6[4] = num.ToString();
                if (!Information.IsDate((object) string.Concat(strArray6)))
                  --secondOccurrence;
                else
                  break;
              }
              string[] strArray7 = new string[5];
              num = PreviousDate.Month;
              strArray7[0] = num.ToString();
              strArray7[1] = "/";
              strArray7[2] = secondOccurrence.ToString();
              strArray7[3] = "/";
              num = PreviousDate.Year;
              strArray7[4] = num.ToString();
              nextDate = Convert.ToDateTime(string.Concat(strArray7));
              break;
            }
            string[] strArray8 = new string[5];
            num = PreviousDate.Month;
            strArray8[0] = num.ToString();
            strArray8[1] = "/";
            num = this.BiMonthlySecondOccurrence;
            strArray8[2] = num.ToString();
            strArray8[3] = "/";
            num = PreviousDate.Year;
            strArray8[4] = num.ToString();
            nextDate = Convert.ToDateTime(string.Concat(strArray8));
            break;
          }
          string[] strArray = new string[5]
          {
            PreviousDate.Month.ToString(),
            "/",
            null,
            null,
            null
          };
          int num2 = this.BiMonthlySecondOccurrence;
          strArray[2] = num2.ToString();
          strArray[3] = "/";
          num2 = PreviousDate.Year;
          strArray[4] = num2.ToString();
          nextDate = Convert.ToDateTime(string.Concat(strArray));
          break;
        }
        break;
      case Utilities.SchedulingType.TwoMonths:
        if (PreviousDate.Day != this.OccursEvery)
        {
          string[] strArray = new string[5]
          {
            PreviousDate.Month.ToString(),
            "/",
            null,
            null,
            null
          };
          int num = this.OccursEvery;
          strArray[2] = num.ToString();
          strArray[3] = "/";
          num = PreviousDate.Year;
          strArray[4] = num.ToString();
          PreviousDate = Convert.ToDateTime(string.Concat(strArray));
        }
        nextDate = PreviousDate.AddMonths(2);
        break;
      case Utilities.SchedulingType.Quarterly:
        if (PreviousDate.Day != this.OccursEvery)
        {
          string[] strArray = new string[5]
          {
            PreviousDate.Month.ToString(),
            "/",
            null,
            null,
            null
          };
          int num = this.OccursEvery;
          strArray[2] = num.ToString();
          strArray[3] = "/";
          num = PreviousDate.Year;
          strArray[4] = num.ToString();
          PreviousDate = Convert.ToDateTime(string.Concat(strArray));
        }
        nextDate = PreviousDate.AddMonths(3);
        break;
      case Utilities.SchedulingType.SemiAnnually:
        if (PreviousDate.Day != this.OccursEvery)
        {
          string[] strArray = new string[5]
          {
            PreviousDate.Month.ToString(),
            "/",
            null,
            null,
            null
          };
          int num = this.OccursEvery;
          strArray[2] = num.ToString();
          strArray[3] = "/";
          num = PreviousDate.Year;
          strArray[4] = num.ToString();
          PreviousDate = Convert.ToDateTime(string.Concat(strArray));
        }
        nextDate = PreviousDate.AddMonths(6);
        break;
      case Utilities.SchedulingType.Annually:
        nextDate = PreviousDate.AddYears(1);
        break;
      default:
        nextDate = DateTime.Now;
        break;
    }
    return nextDate;
  }

  private void BuildScheduleBreakout()
  {
    this.breakout = new ScheduleDetailCollection();
    DateTime dateTime = this.StartDate;
    for (int index = 0; index < this.NumberOfOccurences; ++index)
    {
      if (index == 0)
      {
        this.breakout.Add(new ScheduleDetail(this.StartDate, this.parent.PayeeName, this.parent.GetExpenseTotal()));
      }
      else
      {
        dateTime = this.GetNextDate(dateTime);
        this.breakout.Add(new ScheduleDetail(dateTime, this.parent.PayeeName, this.parent.GetExpenseTotal()));
      }
    }
  }

  private void BuildAnnualBreakout()
  {
    for (int index = 0; index < this.NumberOfOccurences; ++index)
      this.breakout.Add(new ScheduleDetail(this.DueDate.AddYears(index), this.parent.PayeeName, this.parent.GetExpenseTotal()));
  }

  private void BuildMonthlyBreakout()
  {
    for (int index = 0; index < this.NumberOfOccurences; ++index)
      this.breakout.Add(new ScheduleDetail(this.DueDate.AddYears(index), this.parent.PayeeName, this.parent.GetExpenseTotal()));
  }

  private void BuildBiMonthly()
  {
    DateTime dateTime = this.StartDate;
    for (int index = 0; index < this.NumberOfOccurences; ++index)
    {
      if (index == 0)
      {
        this.breakout.Add(new ScheduleDetail(this.StartDate, this.parent.PayeeName, this.parent.GetExpenseTotal()));
      }
      else
      {
        dateTime = this.GetNextDate(dateTime);
        this.breakout.Add(new ScheduleDetail(dateTime, this.parent.PayeeName, this.parent.GetExpenseTotal()));
      }
    }
  }

  private void BuildDailyBreakout()
  {
    for (int index = 0; index < this.NumberOfOccurences; ++index)
      this.breakout.Add(new ScheduleDetail(this.DueDate.AddDays((double) index), this.parent.PayeeName, this.parent.GetExpenseTotal()));
  }

  private void BuildBiWeeklyBreakout()
  {
  }

  public void SaveSchedule(int poNum, SqlCommand cmd)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExpenseSchedule";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@poNum", (object) poNum);
    cmd.Parameters.AddWithValue("@beginDate", (object) this.DueDate);
    cmd.Parameters.AddWithValue("@dueDate", (object) this.DueDate);
    if (this.ScheduleType == Utilities.SchedulingType.None)
    {
      cmd.Parameters.AddWithValue("@reOccurs", (object) 0);
    }
    else
    {
      cmd.Parameters.AddWithValue("@reOccurs", (object) 1);
      cmd.Parameters.AddWithValue("@occurNum", (object) this.NumberOfOccurences);
      cmd.Parameters.AddWithValue("@occurFormat", (object) this.ScheduleType);
      cmd.Parameters.AddWithValue("@occurDays", (object) this.OccurenceDays);
      if (this.ScheduleType == Utilities.SchedulingType.Annually)
        cmd.Parameters.AddWithValue("@annuallyDate", (object) this.DueDate);
    }
    cmd.ExecuteNonQuery();
    this.SaveScheduleDetails(poNum, cmd);
  }

  private void SaveScheduleDetails(int poNum, SqlCommand cmd)
  {
    cmd.CommandText = "spFin_InsertScheduledExpense";
    cmd.CommandType = CommandType.StoredProcedure;
    foreach (ScheduleDetail scheduleDetail in (CollectionBase) this.breakout)
    {
      cmd.Parameters.Clear();
      cmd.Parameters.AddWithValue("@ponum", (object) poNum);
      cmd.Parameters.AddWithValue("@scheduledate", (object) scheduleDetail.ExpenseDate);
      cmd.ExecuteNonQuery();
    }
  }
}
