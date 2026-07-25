// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.GenericListBoxOrdered
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class GenericListBoxOrdered : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private string _strGuid;
  private Type _ReturnType;
  private bool _CheckAllItem;
  private bool _ReturnAll;
  private int _ControlHeight;
  private string _ValueMember;
  private string _DisplayMember;
  private DataTable _dt;
  private bool _ShowAllOption;
  private int oriIndex;
  private int newIndex;
  private int indexOfItemUnderMouseToDrag;
  private Rectangle dragBoxFromMouseDown;
  private Point screenOffset;
  private int indexOfItemUnderMouseToDrop;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected internal virtual MGACheckedListBox clbGeneric
  {
    get => this._clbGeneric;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbGeneric_ItemCheck);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.clbGeneric_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.clbGeneric_MouseUp);
      MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.clbGeneric_MouseMove);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.clbGeneric_DragOver);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.clbGeneric_DragDrop);
      QueryContinueDragEventHandler dragEventHandler3 = new QueryContinueDragEventHandler(this.clbGeneric_QueryContinueDrag);
      DragEventHandler dragEventHandler4 = new DragEventHandler(this.clbGeneric_DragEnter);
      EventHandler eventHandler = new EventHandler(this.clbGeneric_DragLeave);
      MouseEventHandler mouseEventHandler4 = new MouseEventHandler(this.clbGeneric_MouseClick);
      MGACheckedListBox clbGeneric1 = this._clbGeneric;
      if (clbGeneric1 != null)
      {
        clbGeneric1.ItemCheck -= checkEventHandler;
        clbGeneric1.MouseDown -= mouseEventHandler1;
        clbGeneric1.MouseUp -= mouseEventHandler2;
        clbGeneric1.MouseMove -= mouseEventHandler3;
        clbGeneric1.DragOver -= dragEventHandler1;
        clbGeneric1.DragDrop -= dragEventHandler2;
        clbGeneric1.QueryContinueDrag -= dragEventHandler3;
        clbGeneric1.DragEnter -= dragEventHandler4;
        clbGeneric1.DragLeave -= eventHandler;
        clbGeneric1.MouseClick -= mouseEventHandler4;
      }
      this._clbGeneric = value;
      MGACheckedListBox clbGeneric2 = this._clbGeneric;
      if (clbGeneric2 == null)
        return;
      clbGeneric2.ItemCheck += checkEventHandler;
      clbGeneric2.MouseDown += mouseEventHandler1;
      clbGeneric2.MouseUp += mouseEventHandler2;
      clbGeneric2.MouseMove += mouseEventHandler3;
      clbGeneric2.DragOver += dragEventHandler1;
      clbGeneric2.DragDrop += dragEventHandler2;
      clbGeneric2.QueryContinueDrag += dragEventHandler3;
      clbGeneric2.DragEnter += dragEventHandler4;
      clbGeneric2.DragLeave += eventHandler;
      clbGeneric2.MouseClick += mouseEventHandler4;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbGeneric = new MGACheckedListBox();
    ((ISupportInitialize) this.clbGeneric).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 76);
    this.clbGeneric.AllowDrop = true;
    this.clbGeneric.CheckOnClick = true;
    this.clbGeneric.Location = new Point(88, 6);
    this.clbGeneric.Name = "clbGeneric";
    this.clbGeneric.Size = new Size(300, 64 /*0x40*/);
    this.clbGeneric.TabIndex = 2;
    this.Controls.Add((Control) this.clbGeneric);
    this.Name = nameof (GenericListBoxOrdered);
    this.Size = new Size(392, 76);
    this.Controls.SetChildIndex((Control) this.clbGeneric, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbGeneric).EndInit();
    this.ResumeLayout(false);
  }

  private object AllSelectedValue
  {
    get
    {
      return !this._ReturnType.Equals(typeof (int)) ? (!this._ReturnType.Equals(typeof (Guid)) ? (object) string.Empty : (object) Guid.Empty) : (object) -1;
    }
  }

  public GenericListBoxOrdered()
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    int width,
    bool ShowAllOption)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    this.Width -= this.clbGeneric.Width - width;
    this.clbGeneric.Width = width;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    int width,
    int ControlHeight,
    bool ShowAllOption)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    this.clbGeneric.Height = ControlHeight;
    this.Height = ControlHeight + 2;
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    this.Width -= this.clbGeneric.Width - width;
    this.clbGeneric.Width = width;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Paint += new PaintEventHandler(this.GenericListBoxOrdered_Paint);
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = typeof (Guid);
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "Select All",
        this.AllSelectedValue
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this.Width -= this.clbGeneric.Width - this.Width;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._ShowAllOption = ShowAllOption;
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    MGACheckedListBox mgaCheckedListBox = new MGACheckedListBox();
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "Select All",
        this.AllSelectedValue
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._ShowAllOption = ShowAllOption;
    this.Width -= this.clbGeneric.Width - this.Width;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    int width,
    int ControlHeight,
    bool ShowAllOption,
    Type ReturnType)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    this.clbGeneric.Height = ControlHeight;
    this.Height = ControlHeight + 2;
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    this.Width -= this.clbGeneric.Width - width;
    this.clbGeneric.Width = width;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Paint += new PaintEventHandler(this.GenericListBoxOrdered_Paint);
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._CheckAllItem = CheckAllItem;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    MGACheckedListBox mgaCheckedListBox = new MGACheckedListBox();
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "Select All",
        this.AllSelectedValue
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Paint += new PaintEventHandler(this.GenericListBoxOrdered_Paint);
    this._ShowAllOption = ShowAllOption;
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._CheckAllItem = CheckAllItem;
    this._ReturnAll = ReturnAll;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    MGACheckedListBox mgaCheckedListBox = new MGACheckedListBox();
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "Select All",
        this.AllSelectedValue
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._ShowAllOption = ShowAllOption;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Paint += new PaintEventHandler(this.GenericListBoxOrdered_Paint);
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll,
    int ControlHeight)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._CheckAllItem = CheckAllItem;
    this._ReturnAll = ReturnAll;
    this.clbGeneric.Height = ControlHeight;
    this.Height = ControlHeight + 2;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    MGACheckedListBox mgaCheckedListBox = new MGACheckedListBox();
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "Select All",
        this.AllSelectedValue
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._ShowAllOption = ShowAllOption;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Paint += new PaintEventHandler(this.GenericListBoxOrdered_Paint);
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll,
    int ControlWidth,
    int ControlHeight)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._ReturnType = ReturnType;
    this._CheckAllItem = CheckAllItem;
    this._ReturnAll = ReturnAll;
    this.clbGeneric.Height = ControlHeight;
    this.Height = ControlHeight + 2;
    this._ValueMember = ValueMember;
    this._DisplayMember = DisplayMember;
    this.Width -= this.clbGeneric.Width - ControlWidth;
    this.clbGeneric.Width = ControlWidth;
    MGACheckedListBox mgaCheckedListBox = new MGACheckedListBox();
    this._dt = Database.Instance.QueryText.PerformTableQuery(SQLText);
    if (ShowAllOption)
    {
      DataRow row = this._dt.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "Select All",
        this.AllSelectedValue
      };
      this._dt.Rows.InsertAt(row, 0);
    }
    this._ShowAllOption = ShowAllOption;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Paint += new PaintEventHandler(this.GenericListBoxOrdered_Paint);
    this.InitialSize = this.Size;
  }

  public GenericListBoxOrdered(
    string LabelText,
    int Width,
    bool ShowAllOption,
    params object[] args)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.Description = LabelText;
    MGACheckedListBox mgaCheckedListBox = new MGACheckedListBox();
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add("displaymember", typeof (string));
    dataTable.Columns.Add("valuemember", typeof (string));
    this._ValueMember = "valuemember";
    this._DisplayMember = "displaymember";
    int num = args.Length - 1;
    for (int index = 0; index <= num; index += 2)
      dataTable.Rows.Add((object) args[index].ToString(), args[index + 1]);
    if (ShowAllOption)
    {
      DataRow row = dataTable.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Lines",
        (object) Guid.Empty.ToString()
      };
      dataTable.Rows.InsertAt(row, 0);
    }
    this._ShowAllOption = ShowAllOption;
    this.Width -= this.clbGeneric.Width - Width;
    this.clbGeneric.Width = Width;
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row["displaymember"].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.InitialSize = this.Size;
  }

  private bool AllIsSelected()
  {
    return this.clbGeneric.CheckedItems.Count > 0 && this.clbGeneric.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbGeneric.Items[0])) && (!this._ReturnType.Equals(typeof (int)) ? this._dt.Select("ControlIndex=0")[0][this._ValueMember].Equals(RuntimeHelpers.GetObjectValue(this.AllSelectedValue)) : this._dt.Select("ControlIndex=0")[0][this._ValueMember].ToString().Equals(this.AllSelectedValue.ToString()));
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbGeneric.CheckedItems.Count != 0 ? (this.clbGeneric.CheckedItems.Count <= 200 || this.AllIsSelected() ? string.Empty : "Please select fewer then 200 items.") : "Please select at least one item from the list.";
    }
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (!this.AllIsSelected())
      {
        try
        {
          foreach (object checkedIndex in this.clbGeneric.CheckedIndices)
          {
            int integer = Conversions.ToInteger(checkedIndex);
            if (empty.Length > 0)
              empty += ",";
            empty += this._dt.Select(string.Format(this._DisplayMember + "='{0}'", RuntimeHelpers.GetObjectValue(this.clbGeneric.Items[integer])))[0][this._ValueMember].ToString();
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else if (this._ReturnAll)
      {
        int num = this.clbGeneric.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select(string.Format(this._DisplayMember + "='{0}'", RuntimeHelpers.GetObjectValue(this.clbGeneric.Items[index])))[0][this._ValueMember].ToString();
        }
      }
      return (object) empty;
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0)
        return;
      int count = this._dt.Rows.Count;
      if (this._ShowAllOption)
        --count;
      string[] array = Strings.Split(value.ToString(), ",");
      if (array.Length == count)
      {
        this.clbGeneric.SetItemChecked(0, true);
        int num = this.clbGeneric.Items.Count - 1;
        for (int index = 1; index <= num; ++index)
          this.clbGeneric.SetItemChecked(index, false);
      }
      else
      {
        int integer = Conversions.ToInteger(Interaction.IIf(this._ShowAllOption, (object) 1, (object) 0));
        int num1 = array.Length - 1;
        for (int index = 0; index <= num1; ++index)
        {
          DataRow[] dataRowArray = this._dt.Select(string.Format(this._ValueMember + "='{0}'", (object) array[index]));
          if (dataRowArray.Length > 0)
          {
            string str = dataRowArray[0][this._DisplayMember].ToString();
            this.clbGeneric.Items.RemoveAt(this.clbGeneric.Items.IndexOf((object) str));
            this.clbGeneric.Items.Insert(index + integer, (object) str);
          }
        }
        int num2 = integer;
        int num3 = this.clbGeneric.Items.Count - 1;
        for (int index = num2; index <= num3; ++index)
        {
          string str = this._dt.Select(string.Format(this._DisplayMember + "='{0}'", (object) this.clbGeneric.Items[index].ToString()))[0][this._ValueMember].ToString();
          if (Array.IndexOf<string>(array, str) > -1)
            this.clbGeneric.SetItemChecked(index, true);
          else
            this.clbGeneric.SetItemChecked(index, false);
        }
      }
    }
  }

  public override void Compress()
  {
    this.clbGeneric.Top = 0;
    this.lblDescription.Height = this.clbGeneric.Height;
    this.lblDescription.Top = 0;
    this.Height = this.clbGeneric.Height;
  }

  private void GenericListBoxOrdered_Paint(object sender, PaintEventArgs e)
  {
    this.clbGeneric.SetItemChecked(0, this._CheckAllItem);
    this.Paint -= new PaintEventHandler(this.GenericListBoxOrdered_Paint);
  }

  private void clbGeneric_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    bool flag = Strings.InStr(Strings.UCase(this.clbGeneric.Items[0].ToString()), "ALL") > 0;
    if (flag && e.Index != 0 && e.CurrentValue == CheckState.Unchecked)
      this.clbGeneric.SetItemCheckState(0, CheckState.Unchecked);
    if (e.Index != 0 || e.NewValue != CheckState.Checked || !flag)
      return;
    int num = this.clbGeneric.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.clbGeneric.SetItemCheckState(index, CheckState.Unchecked);
  }

  private void clbGeneric_MouseDown(object sender, MouseEventArgs e)
  {
    MGACheckedListBox mgaCheckedListBox = (MGACheckedListBox) sender;
    if (mgaCheckedListBox.Items.Count == 0)
      return;
    this.oriIndex = mgaCheckedListBox.IndexFromPoint(e.X, e.Y);
    int num = (int) this.DoDragDrop((object) mgaCheckedListBox.Items[this.oriIndex].ToString(), DragDropEffects.Move);
    this.indexOfItemUnderMouseToDrag = this.clbGeneric.IndexFromPoint(e.X, e.Y);
    if (this.indexOfItemUnderMouseToDrag != -1)
    {
      Size dragSize = SystemInformation.DragSize;
      this.dragBoxFromMouseDown = new Rectangle(new Point((int) Math.Round(Math.Round((double) e.X - (double) dragSize.Width / 2.0, 0)), (int) Math.Round(Math.Round((double) e.Y - (double) dragSize.Height / 2.0, 0))), dragSize);
    }
    else
      this.dragBoxFromMouseDown = Rectangle.Empty;
  }

  private void clbGeneric_MouseUp(object sender, MouseEventArgs e)
  {
    this.dragBoxFromMouseDown = Rectangle.Empty;
  }

  private void clbGeneric_MouseMove(object sender, MouseEventArgs e)
  {
    if (!e.Button.Equals((object) MouseButtons.Right) || !(this.dragBoxFromMouseDown != Rectangle.Empty & !this.dragBoxFromMouseDown.Contains(e.X, e.Y)))
      return;
    this.screenOffset = SystemInformation.WorkingArea.Location;
    if (this.clbGeneric.DoDragDrop(RuntimeHelpers.GetObjectValue(this.clbGeneric.Items[this.indexOfItemUnderMouseToDrag]), DragDropEffects.All | DragDropEffects.Link) != DragDropEffects.Move)
      return;
    this.clbGeneric.Items.RemoveAt(this.indexOfItemUnderMouseToDrag);
    if (this.indexOfItemUnderMouseToDrag > 0)
    {
      this.clbGeneric.SelectedIndex = this.indexOfItemUnderMouseToDrag - 1;
    }
    else
    {
      if (this.clbGeneric.Items.Count <= 0)
        return;
      this.clbGeneric.SelectedIndex = 0;
    }
  }

  private void clbGeneric_DragOver(object sender, DragEventArgs e)
  {
    if (!e.Data.GetDataPresent(typeof (string)))
    {
      e.Effect = DragDropEffects.None;
    }
    else
    {
      e.Effect = (e.KeyState & 40) != 40 || (e.AllowedEffect & DragDropEffects.Link) != DragDropEffects.Link ? ((e.KeyState & 32 /*0x20*/) != 32 /*0x20*/ || (e.AllowedEffect & DragDropEffects.Link) != DragDropEffects.Link ? ((e.KeyState & 4) != 4 || (e.AllowedEffect & DragDropEffects.Move) != DragDropEffects.Move ? ((e.KeyState & 8) != 8 || (e.AllowedEffect & DragDropEffects.Copy) != DragDropEffects.Copy ? ((e.AllowedEffect & DragDropEffects.Move) != DragDropEffects.Move ? DragDropEffects.None : DragDropEffects.Move) : DragDropEffects.Copy) : DragDropEffects.Move) : DragDropEffects.Link) : DragDropEffects.Link;
      this.indexOfItemUnderMouseToDrop = this.clbGeneric.IndexFromPoint(this.clbGeneric.PointToClient(new Point(e.X, e.Y)));
    }
  }

  private void clbGeneric_DragDrop(object sender, DragEventArgs e)
  {
    if (!e.Data.GetDataPresent(typeof (string)) || !e.Data.GetDataPresent(DataFormats.StringFormat))
      return;
    string data = (string) e.Data.GetData(DataFormats.StringFormat);
    this.newIndex = ((ListBox) sender).IndexFromPoint(((Control) sender).PointToClient(new Point(e.X, e.Y)));
    if (this.newIndex != this.oriIndex)
    {
      if (this.newIndex > -1)
      {
        if (this.newIndex > this.oriIndex)
        {
          ((CheckedListBox) sender).Items.Insert(this.newIndex + 1, (object) data);
          if (((CheckedListBox) sender).GetItemChecked(this.oriIndex))
            ((CheckedListBox) sender).SetItemChecked(this.newIndex + 1, true);
          ((CheckedListBox) sender).Items.RemoveAt(this.oriIndex);
        }
        else
        {
          ((CheckedListBox) sender).Items.Insert(this.newIndex, (object) data);
          if (((CheckedListBox) sender).GetItemChecked(this.oriIndex + 1))
            ((CheckedListBox) sender).SetItemChecked(this.newIndex, true);
          ((CheckedListBox) sender).Items.RemoveAt(this.oriIndex + 1);
        }
      }
      else
      {
        ((CheckedListBox) sender).Items.Add((object) data);
        if (((CheckedListBox) sender).GetItemChecked(this.oriIndex))
          ((CheckedListBox) sender).SetItemChecked(((CheckedListBox) sender).Items.Count - 1, true);
        ((CheckedListBox) sender).Items.RemoveAt(this.oriIndex);
      }
    }
    else
      ((CheckedListBox) sender).SetItemChecked(this.newIndex, !((CheckedListBox) sender).GetItemChecked(this.newIndex));
  }

  private void clbGeneric_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
  {
    if (!(sender is CheckedListBox checkedListBox))
      return;
    Form form = checkedListBox.FindForm();
    if (Control.MousePosition.X - this.screenOffset.X >= form.DesktopBounds.Left)
    {
      Point mousePosition = Control.MousePosition;
      int num1 = mousePosition.X - this.screenOffset.X;
      Rectangle desktopBounds = form.DesktopBounds;
      int right = desktopBounds.Right;
      if (num1 <= right)
      {
        mousePosition = Control.MousePosition;
        int num2 = mousePosition.Y - this.screenOffset.Y;
        desktopBounds = form.DesktopBounds;
        int top = desktopBounds.Top;
        if (num2 >= top)
        {
          mousePosition = Control.MousePosition;
          int num3 = mousePosition.Y - this.screenOffset.Y;
          desktopBounds = form.DesktopBounds;
          int bottom = desktopBounds.Bottom;
          if (num3 <= bottom)
            return;
        }
      }
    }
    e.Action = DragAction.Cancel;
  }

  private void clbGeneric_DragEnter(object sender, DragEventArgs e)
  {
    if (e.Data.GetDataPresent(DataFormats.Text))
      e.Effect = DragDropEffects.Move;
    else
      e.Effect = DragDropEffects.None;
  }

  private void clbGeneric_DragLeave(object sender, EventArgs e)
  {
  }

  private void clbGeneric_MouseClick(object sender, MouseEventArgs e)
  {
  }
}
