// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.DatePickerSpin
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

public class DatePickerSpin : 
  BaseReportControl,
  IOfflineReportIncrementSupport,
  IOfflineReportControl
{
  private IContainer components;
  private bool _DateOptional;
  private string _CustomFormat;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("DateTimePick")]
  internal virtual DateTimePicker DateTimePick { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual DateTimePicker DateTimePickerFake
  {
    get => this._DateTimePickerFake;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DateTimePickerFake_ValueChanged);
      DateTimePicker dateTimePickerFake1 = this._DateTimePickerFake;
      if (dateTimePickerFake1 != null)
        dateTimePickerFake1.ValueChanged -= eventHandler;
      this._DateTimePickerFake = value;
      DateTimePicker dateTimePickerFake2 = this._DateTimePickerFake;
      if (dateTimePickerFake2 == null)
        return;
      dateTimePickerFake2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.DateTimePick = new DateTimePicker();
    this.Panel1 = new Panel();
    this.DateTimePickerFake = new DateTimePicker();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    this.lblDescription.BackColor = Color.Transparent;
    this.lblDescription.Size = new Size(88, 28);
    this.DateTimePick.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.DateTimePick.CustomFormat = "";
    this.DateTimePick.Format = DateTimePickerFormat.Custom;
    this.DateTimePick.Location = new Point(0, -1);
    this.DateTimePick.Margin = new Padding(0);
    this.DateTimePick.Name = "DateTimePick";
    this.DateTimePick.ShowUpDown = true;
    this.DateTimePick.Size = new Size(116, 20);
    this.DateTimePick.TabIndex = 2;
    this.DateTimePick.Value = new DateTime(2017, 8, 2, 0, 0, 0, 0);
    this.Panel1.BackColor = SystemColors.Window;
    this.Panel1.Controls.Add((Control) this.DateTimePickerFake);
    this.Panel1.Controls.Add((Control) this.DateTimePick);
    this.Panel1.Location = new Point(88, 5);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(115, 20);
    this.Panel1.TabIndex = 3;
    this.DateTimePickerFake.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.DateTimePickerFake.Checked = false;
    this.DateTimePickerFake.CustomFormat = "";
    this.DateTimePickerFake.Location = new Point(96 /*0x60*/, -1);
    this.DateTimePickerFake.Margin = new Padding(0);
    this.DateTimePickerFake.Name = "DateTimePickerFake";
    this.DateTimePickerFake.ShowUpDown = true;
    this.DateTimePickerFake.Size = new Size(20, 20);
    this.DateTimePickerFake.TabIndex = 3;
    this.DateTimePickerFake.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    this.Controls.Add((Control) this.Panel1);
    this.Name = nameof (DatePickerSpin);
    this.Size = new Size(211, 30);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.Panel1, 0);
    this.Panel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public DatePickerSpin(string labelText, DateTime InitialDate)
  {
    this.Paint += new PaintEventHandler(this.DatePickerSpin_Paint);
    this._CustomFormat = "MM/dd/yyyy";
    this.InitializeComponent();
    this.Description = labelText;
    this.DateTimePickerFake.Visible = false;
    this.DateTimePick.CustomFormat = this._CustomFormat;
    this.DateTimePick.Visible = true;
    this._DateOptional = false;
    this.DateTimePick.Value = InitialDate;
    this.DateTimePickerFake.Value = InitialDate;
    this.InitialSize = this.Size;
  }

  public DatePickerSpin(string labelText, DateTime InitialDate, string Format)
    : this(labelText, InitialDate)
  {
    this._CustomFormat = Format;
    this.DateTimePick.CustomFormat = this._CustomFormat;
  }

  public DatePickerSpin(string labelText, bool dateOptional)
  {
    this.Paint += new PaintEventHandler(this.DatePickerSpin_Paint);
    this._CustomFormat = "MM/dd/yyyy";
    this.InitializeComponent();
    this.Description = labelText;
    this._DateOptional = dateOptional;
    this.DateTimePick.CustomFormat = this._CustomFormat;
    this.DateTimePick.Value = DateTime.Now;
    this.DateTimePickerFake.Value = DateTime.Now;
    if (!this._DateOptional)
    {
      this.DateTimePickerFake.Visible = false;
      this.DateTimePick.Visible = true;
    }
    else
    {
      this.DateTimePickerFake.Visible = true;
      this.DateTimePick.Visible = false;
      this.DateTimePick.Checked = false;
    }
    this.InitialSize = this.Size;
  }

  public DatePickerSpin(string labelText, bool dateOptional, string Format)
    : this(labelText, dateOptional)
  {
    this._CustomFormat = Format;
    this.DateTimePick.CustomFormat = this._CustomFormat;
  }

  private void DateTimePickerFake_ValueChanged(object sender, EventArgs e)
  {
    this.DateTimePickerFake.Value = this.DateTimePickerFake.Value;
    this.DateTimePickerFake.Visible = false;
    this.DateTimePick.Visible = true;
    this.DateTimePick.Checked = true;
  }

  public override object Value
  {
    get
    {
      return Interaction.IIf(this.DateTimePick.Checked, (object) this.DateTimePick.Value, (object) null);
    }
    set
    {
      if (value == null)
      {
        this.DateTimePick.Value = DateTime.Now;
        this.DateTimePickerFake.Visible = true;
        this.DateTimePick.Visible = false;
        this.DateTimePick.Checked = false;
      }
      else
        this.DateTimePick.Value = (DateTime) value;
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      return this._DateOptional || this.DateTimePick.Checked ? string.Empty : "Please enter a valid date.";
    }
  }

  public override void Compress()
  {
    this.Panel1.Top = 0;
    this.lblDescription.Height = this.Panel1.Height;
    this.lblDescription.Top = 0;
    this.Height = this.Panel1.Height;
  }

  public bool SupportsDate => true;

  public bool SupportsDateRange => false;

  public void SetReportControlValue(object value)
  {
    if (value is object[] || value == null)
      return;
    this.DateTimePick.Value = Conversions.ToDate(value);
  }

  private void DatePickerSpin_Paint(object sender, PaintEventArgs e)
  {
    Point location = this.Panel1.Location;
    Size size = this.Panel1.Size;
    --location.X;
    --location.Y;
    ++size.Height;
    ++size.Width;
    Rectangle rect = new Rectangle(location, size);
    e.Graphics.DrawRectangle(Pens.Gray, rect);
  }
}
