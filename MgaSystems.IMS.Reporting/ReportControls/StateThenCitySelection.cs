// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.StateThenCitySelection
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class StateThenCitySelection : BaseReportControl
{
  private IContainer components;
  private DataTable _stateDataTable;
  private DataTable _cityDataTable;
  private const string _cityFieldName = "City";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.StateComboBox = new MGASimpleComboBox();
    this.CityComboBox = new MGASimpleComboBox();
    ((ISupportInitialize) this.StateComboBox).BeginInit();
    ((ISupportInitialize) this.CityComboBox).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, 6);
    this.lblDescription.Size = new Size(88, 20);
    this.lblDescription.Text = "State";
    this.Label1.Location = new Point(0, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(40, 16 /*0x10*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "State";
    this.Label1.TextAlign = ContentAlignment.BottomLeft;
    this.Label2.Location = new Point(0, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(88, 20);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "City";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.StateComboBox).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.StateComboBox.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.StateComboBox).Location = new Point(88, 6);
    ((Control) this.StateComboBox).Name = "StateComboBox";
    ((Control) this.StateComboBox).Size = new Size(300, 20);
    ((Control) this.StateComboBox).TabIndex = 2;
    ((UltraControlBase) this.StateComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.StateComboBox).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.CityComboBox).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.CityComboBox.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.CityComboBox).Enabled = false;
    ((Control) this.CityComboBox).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.CityComboBox).Name = "CityComboBox";
    ((Control) this.CityComboBox).Size = new Size(300, 20);
    ((Control) this.CityComboBox).TabIndex = 3;
    ((UltraControlBase) this.CityComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CityComboBox).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.CityComboBox);
    this.Controls.Add((Control) this.StateComboBox);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Description = "State";
    this.Name = nameof (StateThenCitySelection);
    this.Size = new Size(392, 58);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.StateComboBox, 0);
    this.Controls.SetChildIndex((Control) this.CityComboBox, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.StateComboBox).EndInit();
    ((ISupportInitialize) this.CityComboBox).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual MGASimpleComboBox StateComboBox
  {
    get => this._StateComboBox;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.StateComboBox_ValueChanged);
      MGASimpleComboBox stateComboBox1 = this._StateComboBox;
      if (stateComboBox1 != null)
        stateComboBox1.ValueChanged -= eventHandler;
      this._StateComboBox = value;
      MGASimpleComboBox stateComboBox2 = this._StateComboBox;
      if (stateComboBox2 == null)
        return;
      stateComboBox2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("CityComboBox")]
  internal virtual MGASimpleComboBox CityComboBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public StateThenCitySelection()
  {
    this.InitializeComponent();
    ((UltraGridBase) this.StateComboBox).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID,State FROM dbo.lstStates order by State");
    ((UltraDropDownBase) this.StateComboBox).DisplayMember = "State";
    ((UltraDropDownBase) this.StateComboBox).ValueMember = "StateID";
    this.StateComboBox.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  private void StateComboBox_ValueChanged(object sender, EventArgs e)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT count(*) FROM dbo.tblUnderwritingLocations WHERE State=@StateIDSelected", new object[2]
    {
      (object) "@StateIDSelected",
      this.StateComboBox.Value
    }) > 0)
    {
      ((Control) this.CityComboBox).Enabled = true;
      ((UltraGridBase) this.CityComboBox).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT City FROM dbo.tblUnderwritingLocations WHERE State=@StateIDSelected ORDER BY City", new object[2]
      {
        (object) "@StateIDSelected",
        this.StateComboBox.Value
      });
      ((UltraDropDownBase) this.CityComboBox).DisplayMember = "City";
      ((UltraDropDownBase) this.CityComboBox).ValueMember = "City";
      this.CityComboBox.SelectedIndex = 0;
    }
    else
      ((Control) this.CityComboBox).Enabled = false;
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        Interaction.IIf(this.CityComboBox.Value == null, (object) null, RuntimeHelpers.GetObjectValue(this.CityComboBox.Value)),
        Interaction.IIf(this.StateComboBox.Value == null, (object) null, RuntimeHelpers.GetObjectValue(this.StateComboBox.Value))
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      if (objArray[0] == null)
        this.CityComboBox.Value = (object) null;
      else
        this.CityComboBox.Value = (object) (string) objArray[0];
      if (objArray[1] == null)
        this.StateComboBox.Value = (object) null;
      else
        this.StateComboBox.Value = (object) (string) objArray[1];
    }
  }

  public override void Compress()
  {
    ((Control) this.StateComboBox).Top = 0;
    this.Label1.Top = 0;
    this.Label1.Height = ((Control) this.StateComboBox).Height;
    ((Control) this.CityComboBox).Top = ((Control) this.StateComboBox).Height;
    this.Label2.Top = ((Control) this.StateComboBox).Height;
    this.Label2.Height = ((Control) this.CityComboBox).Height;
    this.Height = ((Control) this.CityComboBox).Height + ((Control) this.CityComboBox).Top;
  }
}
