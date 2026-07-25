// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.GenericListBox
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

public class GenericListBox : BaseReportControl
{
  private IContainer components;
  private readonly bool _ShowAll;
  private readonly string _strGuid;
  private readonly Type _ReturnType;
  private readonly bool _CheckAllItem;
  private readonly bool _SelectAllItem;
  private readonly bool _ReturnAll;
  private readonly int _ControlHeight;
  private readonly string _ValueMember;
  private readonly string _DisplayMember;
  private readonly DataTable _dt;
  private readonly bool _ShowAllOption;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
      this.components?.Dispose();
    base.Dispose(disposing);
  }

  protected internal virtual MGACheckedListBox clbGeneric
  {
    get => this._clbGeneric;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbGeneric_ItemCheck);
      MGACheckedListBox clbGeneric1 = this._clbGeneric;
      if (clbGeneric1 != null)
        clbGeneric1.ItemCheck -= checkEventHandler;
      this._clbGeneric = value;
      MGACheckedListBox clbGeneric2 = this._clbGeneric;
      if (clbGeneric2 == null)
        return;
      clbGeneric2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbGeneric = new MGACheckedListBox();
    ((ISupportInitialize) this.clbGeneric).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 76);
    this.clbGeneric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbGeneric.CheckOnClick = true;
    this.clbGeneric.Location = new Point(88, 6);
    this.clbGeneric.Name = "clbGeneric";
    this.clbGeneric.Size = new Size(300, 64 /*0x40*/);
    this.clbGeneric.TabIndex = 2;
    this.Controls.Add((Control) this.clbGeneric);
    this.Name = nameof (GenericListBox);
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
      return (object) this._ReturnType != (object) typeof (int) ? ((object) this._ReturnType != (object) typeof (Guid) ? (object) string.Empty : (object) Guid.Empty) : (object) -1;
    }
  }

  public GenericListBox()
  {
    this.Load += new EventHandler(this.GenericListBox_Load);
    this._CheckAllItem = false;
    this._SelectAllItem = false;
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  private GenericListBox(
    string labelText,
    bool showAllOption,
    string valueMember,
    string displayMember,
    Type returnType)
    : this()
  {
    this.Description = labelText;
    this._ShowAllOption = showAllOption;
    this._ValueMember = valueMember;
    this._DisplayMember = displayMember;
    this._ReturnType = returnType;
  }

  private GenericListBox(
    string labelText,
    string SqlText,
    bool showAllOption,
    string valueMember,
    string displayMember,
    Type returnType)
    : this(labelText, showAllOption, valueMember, displayMember, returnType)
  {
    this._dt = Database.Instance.QueryText.PerformTableQuery(SqlText);
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    int width,
    bool ShowAllOption)
    : this(LabelText, SQLText, ShowAllOption, ValueMember, DisplayMember, typeof (string))
  {
    this.Width -= this.clbGeneric.Width - width;
    this.clbGeneric.Width = width;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    int width,
    int ControlHeight,
    bool ShowAllOption)
    : this(LabelText, SQLText, ValueMember, DisplayMember, width, ControlHeight, ShowAllOption, typeof (Guid))
  {
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption)
    : this(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, typeof (Guid))
  {
    this.Width -= this.clbGeneric.Width - this.Width;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType)
    : this(LabelText, SQLText, ShowAllOption, ValueMember, DisplayMember, ReturnType)
  {
    this.Width -= this.clbGeneric.Width - this.Width;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    int width,
    int ControlHeight,
    bool ShowAllOption,
    Type ReturnType)
    : this(LabelText, SQLText, ShowAllOption, ValueMember, DisplayMember, ReturnType)
  {
    this.clbGeneric.Height = ControlHeight;
    this.Height = ControlHeight + 2;
    this.Width -= this.clbGeneric.Width - width;
    this.clbGeneric.Width = width;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem)
    : this(LabelText, SQLText, ShowAllOption, ValueMember, DisplayMember, ReturnType)
  {
    CheckAllItem = true;
    this._CheckAllItem = CheckAllItem;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll)
    : this(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType, CheckAllItem)
  {
    this._ReturnAll = ReturnAll;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll,
    int ControlHeight)
    : this(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType, CheckAllItem, ReturnAll)
  {
    this.clbGeneric.Height = ControlHeight;
    this.Height = ControlHeight + 2;
  }

  public GenericListBox(
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
    : this(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType, CheckAllItem, ReturnAll, ControlHeight)
  {
    this.Width -= this.clbGeneric.Width - ControlWidth;
    this.clbGeneric.Width = ControlWidth;
  }

  public GenericListBox(
    string LabelText,
    string SQLText,
    string ValueMember,
    string DisplayMember,
    bool ShowAllOption,
    Type ReturnType,
    bool CheckAllItem,
    bool ReturnAll,
    int ControlWidth,
    int ControlHeight,
    bool SelectAllItem)
    : this(LabelText, SQLText, ValueMember, DisplayMember, ShowAllOption, ReturnType, CheckAllItem, ReturnAll, ControlWidth, ControlHeight)
  {
    this._SelectAllItem = SelectAllItem;
    if (!this._SelectAllItem)
      return;
    int num = this.clbGeneric.Items.Count - 1;
    for (int index = 1; index <= num; ++index)
      this.clbGeneric.SetItemCheckState(index, CheckState.Checked);
  }

  public GenericListBox(string LabelText, int Width, bool ShowAllOption, params object[] args)
    : this(LabelText, ShowAllOption, "valuemember", "displaymember", typeof (string))
  {
    this._dt.Columns.Add("displaymember", typeof (string));
    this._dt.Columns.Add("valuemember", typeof (string));
    int num = args.Length - 1;
    for (int index = 0; index <= num; index += 2)
      this._dt.Rows.Add((object) args[index].ToString(), args[index + 1]);
    this.Width -= this.clbGeneric.Width - Width;
    this.clbGeneric.Width = Width;
  }

  private void AddControlIndex()
  {
    if (this._ShowAllOption)
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
        row["Controlindex"] = (object) this.clbGeneric.Items.Add((object) Strings.Trim(row[this._DisplayMember].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!this._ShowAllOption || !this._CheckAllItem)
      return;
    this.clbGeneric.SetItemChecked(0, true);
  }

  private bool AllIsSelected()
  {
    bool flag;
    if (this.clbGeneric.CheckedItems.Count > 0 && this.clbGeneric.CheckedItems.Contains(RuntimeHelpers.GetObjectValue(this.clbGeneric.Items[0])))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this._dt.Select("ControlIndex=0")[0][this._ValueMember]);
      flag = (object) this._ReturnType != (object) typeof (int) ? objectValue.Equals(RuntimeHelpers.GetObjectValue(this.AllSelectedValue)) : objectValue.ToString().Equals(this.AllSelectedValue.ToString());
    }
    else
      flag = false;
    return flag;
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.clbGeneric.CheckedItems.Count != 0 ? string.Empty : "Please select at least one item from the list.";
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
            empty += this._dt.Select($"ControlIndex={integer}")[0][this._ValueMember].ToString();
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
          empty += this._dt.Select($"ControlIndex={index}")[0][this._ValueMember].ToString();
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
        try
        {
          foreach (DataRow row in this._dt.Rows)
            this.clbGeneric.SetItemChecked(Conversions.ToInteger(row["ControlIndex"]), Array.IndexOf<string>(array, row[this._ValueMember].ToString()) > -1);
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

  public override void Compress()
  {
    this.clbGeneric.Top = 0;
    this.lblDescription.Height = this.clbGeneric.Height;
    this.lblDescription.Top = 0;
    this.Height = this.clbGeneric.Height;
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

  private void GenericListBox_Load(object sender, EventArgs e) => this.AddControlIndex();
}
