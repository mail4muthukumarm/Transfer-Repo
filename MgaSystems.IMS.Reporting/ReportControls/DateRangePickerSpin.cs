// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.DateRangePickerSpin
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class DateRangePickerSpin : 
  BaseReportControl,
  IOfflineReportIncrementSupport,
  IOfflineReportControl
{
  private IContainer components;
  private bool _datesOptional;
  private string _CustomFormat;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual DateTimePicker dtpFromFake
  {
    get => this._dtpFromFake;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtpFromFake_ValueChanged);
      DateTimePicker dtpFromFake1 = this._dtpFromFake;
      if (dtpFromFake1 != null)
        dtpFromFake1.ValueChanged -= eventHandler;
      this._dtpFromFake = value;
      DateTimePicker dtpFromFake2 = this._dtpFromFake;
      if (dtpFromFake2 == null)
        return;
      dtpFromFake2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dtpFrom")]
  internal virtual DateTimePicker dtpFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual DateTimePicker dtpToFake
  {
    get => this._dtpToFake;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtpToFake_ValueChanged);
      DateTimePicker dtpToFake1 = this._dtpToFake;
      if (dtpToFake1 != null)
        dtpToFake1.ValueChanged -= eventHandler;
      this._dtpToFake = value;
      DateTimePicker dtpToFake2 = this._dtpToFake;
      if (dtpToFake2 == null)
        return;
      dtpToFake2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dtpTo")]
  internal virtual DateTimePicker dtpTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Label1 = new Label();
    this.Panel1 = new Panel();
    this.dtpFromFake = new DateTimePicker();
    this.dtpFrom = new DateTimePicker();
    this.Panel2 = new Panel();
    this.dtpToFake = new DateTimePicker();
    this.dtpTo = new DateTimePicker();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(-3, 0);
    this.Label1.Location = new Point(200, 2);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 30);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "to";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.Panel1.BackColor = SystemColors.Window;
    this.Panel1.Controls.Add((Control) this.dtpFromFake);
    this.Panel1.Controls.Add((Control) this.dtpFrom);
    this.Panel1.Location = new Point(88, 6);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(105, 20);
    this.Panel1.TabIndex = 4;
    this.dtpFromFake.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dtpFromFake.Checked = false;
    this.dtpFromFake.CustomFormat = "";
    this.dtpFromFake.Location = new Point(86, -1);
    this.dtpFromFake.Margin = new Padding(0);
    this.dtpFromFake.Name = "dtpFromFake";
    this.dtpFromFake.ShowUpDown = true;
    this.dtpFromFake.Size = new Size(20, 20);
    this.dtpFromFake.TabIndex = 3;
    this.dtpFromFake.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    this.dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.dtpFrom.CustomFormat = "";
    this.dtpFrom.Format = DateTimePickerFormat.Custom;
    this.dtpFrom.Location = new Point(0, -1);
    this.dtpFrom.Margin = new Padding(0);
    this.dtpFrom.Name = "dtpFrom";
    this.dtpFrom.ShowUpDown = true;
    this.dtpFrom.Size = new Size(106, 20);
    this.dtpFrom.TabIndex = 2;
    this.dtpFrom.Value = new DateTime(2017, 8, 2, 0, 0, 0, 0);
    this.Panel2.BackColor = SystemColors.Window;
    this.Panel2.Controls.Add((Control) this.dtpToFake);
    this.Panel2.Controls.Add((Control) this.dtpTo);
    this.Panel2.Location = new Point(224 /*0xE0*/, 6);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(105, 20);
    this.Panel2.TabIndex = 5;
    this.dtpToFake.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dtpToFake.Checked = false;
    this.dtpToFake.CustomFormat = "";
    this.dtpToFake.Location = new Point(86, -1);
    this.dtpToFake.Margin = new Padding(0);
    this.dtpToFake.Name = "dtpToFake";
    this.dtpToFake.ShowUpDown = true;
    this.dtpToFake.Size = new Size(20, 20);
    this.dtpToFake.TabIndex = 3;
    this.dtpToFake.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    this.dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.dtpTo.CustomFormat = "";
    this.dtpTo.Format = DateTimePickerFormat.Custom;
    this.dtpTo.Location = new Point(0, -1);
    this.dtpTo.Margin = new Padding(0);
    this.dtpTo.Name = "dtpTo";
    this.dtpTo.ShowUpDown = true;
    this.dtpTo.Size = new Size(106, 20);
    this.dtpTo.TabIndex = 2;
    this.dtpTo.Value = new DateTime(2017, 8, 2, 0, 0, 0, 0);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Label1);
    this.Name = nameof (DateRangePickerSpin);
    this.Size = new Size(336, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.Panel1, 0);
    this.Controls.SetChildIndex((Control) this.Panel2, 0);
    this.Panel1.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public DateRangePickerSpin(string labelText, bool datesOptional)
    : this(labelText, DateTime.MinValue, DateTime.MinValue, datesOptional, "MM/dd/yyyy")
  {
  }

  public DateRangePickerSpin(string labelText, DateTime dateFrom, DateTime dateTo)
    : this(labelText, dateFrom, dateTo, false, "MM/dd/yyyy")
  {
  }

  public DateRangePickerSpin(string labelText, bool datesOptional, string Format)
    : this(labelText, DateTime.MinValue, DateTime.MinValue, datesOptional, Format)
  {
  }

  public DateRangePickerSpin(string labelText, DateTime dateFrom, DateTime dateTo, string Format)
    : this(labelText, dateFrom, dateTo, false, Format)
  {
  }

  public DateRangePickerSpin(
    string labelText,
    DateTime dateFrom,
    DateTime dateTo,
    bool datesOptional,
    string Format)
  {
    this.Paint += new PaintEventHandler(this.DateRangePickerSpin_Paint);
    this._datesOptional = false;
    this._CustomFormat = "MM/dd/yyyy";
    this.InitializeComponent();
    this.Description = labelText;
    this.dtpFrom.Value = Conversions.ToDate(Interaction.IIf(dateFrom.Equals(DateTime.MinValue), (object) DateTime.Now, (object) dateFrom));
    this.dtpTo.Value = Conversions.ToDate(Interaction.IIf(dateTo.Equals(DateTime.MinValue), (object) DateTime.Now, (object) dateTo));
    if (datesOptional && dateFrom.Equals(DateTime.MinValue))
    {
      this.dtpFromFake.Visible = true;
      this.dtpFrom.Visible = false;
      this.dtpFrom.Checked = false;
    }
    else
    {
      this.dtpFromFake.Visible = false;
      this.dtpFrom.Visible = true;
      this.dtpFrom.Checked = true;
    }
    if (datesOptional && dateTo.Equals(DateTime.MinValue))
    {
      this.dtpToFake.Visible = true;
      this.dtpTo.Visible = false;
      this.dtpTo.Checked = false;
    }
    else
    {
      this.dtpToFake.Visible = false;
      this.dtpTo.Visible = true;
      this.dtpTo.Checked = true;
    }
    this._CustomFormat = Format;
    this.dtpFrom.CustomFormat = Format;
    this.dtpTo.CustomFormat = Format;
    this._datesOptional = datesOptional;
    this.InitialSize = this.Size;
  }

  private void dtpFromFake_ValueChanged(object sender, EventArgs e)
  {
    this.dtpFromFake.Visible = false;
    this.dtpFrom.Visible = true;
    this.dtpFrom.Checked = true;
  }

  private void dtpToFake_ValueChanged(object sender, EventArgs e)
  {
    this.dtpToFake.Visible = false;
    this.dtpTo.Visible = true;
    this.dtpTo.Checked = true;
  }

  private void DateRangePickerSpin_Paint(object sender, PaintEventArgs e)
  {
    Point location1 = this.Panel1.Location;
    Size size1 = this.Panel1.Size;
    --location1.X;
    --location1.Y;
    ++size1.Height;
    ++size1.Width;
    Rectangle rect = new Rectangle(location1, size1);
    e.Graphics.DrawRectangle(Pens.Gray, rect);
    Point location2 = this.Panel2.Location;
    Size size2 = this.Panel2.Size;
    --location2.X;
    --location2.Y;
    ++size2.Height;
    ++size2.Width;
    rect = new Rectangle(location2, size2);
    e.Graphics.DrawRectangle(Pens.Gray, rect);
  }

  public override string InputErrorMessage
  {
    get
    {
      string inputErrorMessage;
      if (this._datesOptional)
      {
        if (!this.dtpFrom.Checked || !this.dtpTo.Checked)
        {
          inputErrorMessage = string.Empty;
          goto label_10;
        }
        if (this.dtpFrom.Checked && this.dtpTo.Checked && DateTime.Compare(this.dtpFrom.Value.Date, this.dtpTo.Value.Date) > 0)
        {
          inputErrorMessage = "From Date Must Be Before To Date";
          goto label_10;
        }
      }
      else
      {
        if (!this.dtpFrom.Checked || !this.dtpTo.Checked)
        {
          inputErrorMessage = "Both dates are required";
          goto label_10;
        }
        if (DateTime.Compare(this.dtpFrom.Value.Date, this.dtpTo.Value.Date) > 0)
        {
          inputErrorMessage = "From Date Must Be Before To Date";
          goto label_10;
        }
      }
      inputErrorMessage = (string) null;
label_10:
      return inputErrorMessage;
    }
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        Interaction.IIf(!this.dtpFrom.Checked, (object) null, (object) this.dtpFrom.Value.Date),
        Interaction.IIf(!this.dtpTo.Checked, (object) null, (object) this.dtpTo.Value.Date)
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      if (objArray[0] == null)
      {
        this.dtpFromFake.Visible = true;
        this.dtpFrom.Visible = false;
        this.dtpFrom.Checked = false;
      }
      else
      {
        this.dtpFromFake.Visible = false;
        this.dtpFrom.Visible = true;
        this.dtpFrom.Checked = true;
        this.dtpFrom.Value = (DateTime) objArray[0];
      }
      if (objArray[1] == null)
      {
        this.dtpToFake.Visible = true;
        this.dtpTo.Visible = false;
        this.dtpTo.Checked = false;
      }
      else
      {
        this.dtpToFake.Visible = false;
        this.dtpTo.Visible = true;
        this.dtpTo.Checked = true;
        this.dtpTo.Value = (DateTime) objArray[1];
      }
    }
  }

  public override void Compress()
  {
    this.dtpFrom.Top = 0;
    this.dtpTo.Top = 0;
    this.lblDescription.Top = 0;
    this.Label1.Top = 0;
    this.lblDescription.Height = this.dtpTo.Height;
    this.Label1.Height = this.dtpTo.Height;
    this.Height = this.dtpTo.Height;
  }

  public bool SupportsDate => false;

  public bool SupportsDateRange => true;

  public void SetReportControlValue(object value)
  {
    if (!(value is object[] objArray))
      return;
    if (objArray[0] != null)
      this.dtpFrom.Value = Conversions.ToDate(objArray[0]);
    if (objArray[1] == null)
      return;
    this.dtpTo.Value = Conversions.ToDate(objArray[1]);
  }
}
