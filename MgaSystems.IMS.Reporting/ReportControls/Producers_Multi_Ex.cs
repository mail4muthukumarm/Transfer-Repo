// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.Producers_Multi_Ex
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Data;
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

public class Producers_Multi_Ex : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private DataTable _dt;
  private bool SendSelected;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual LinkLabel LinkLabel1
  {
    get => this._LinkLabel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      LinkLabel linkLabel1_1 = this._LinkLabel1;
      if (linkLabel1_1 != null)
        linkLabel1_1.LinkClicked -= clickedEventHandler;
      this._LinkLabel1 = value;
      LinkLabel linkLabel1_2 = this._LinkLabel1;
      if (linkLabel1_2 == null)
        return;
      linkLabel1_2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("clbProducers")]
  internal virtual MGACheckedListBox clbProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbProducers = new MGACheckedListBox();
    this.LinkLabel1 = new LinkLabel();
    ((ISupportInitialize) this.clbProducers).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 102);
    this.clbProducers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbProducers.CheckOnClick = true;
    this.clbProducers.Location = new Point(88, 17);
    this.clbProducers.Name = "clbProducers";
    this.clbProducers.Size = new Size(300, 79);
    this.clbProducers.TabIndex = 1;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
    this.LinkLabel1.Location = new Point(86, 1);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(51, 13);
    this.LinkLabel1.TabIndex = 2;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Select All";
    this.LinkLabel1.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.clbProducers);
    this.Controls.Add((Control) this.LinkLabel1);
    this.Name = nameof (Producers_Multi_Ex);
    this.Size = new Size(392, 102);
    this.Controls.SetChildIndex((Control) this.LinkLabel1, 0);
    this.Controls.SetChildIndex((Control) this.clbProducers, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbProducers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public Producers_Multi_Ex(string LabelText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ProducerName, ProducerGUID from tblProducers WITH (NOLOCK) ORDER BY ProducerName");
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.clbProducers.Items.Add((object) Strings.Trim(row["ProducerName"].ToString()));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SendSelected = true;
    this.InitialSize = this.Size;
  }

  public override string InputErrorMessage
  {
    get
    {
      string inputErrorMessage;
      if (this.SendSelected)
      {
        if (this.clbProducers.CheckedItems.Count == 0)
        {
          inputErrorMessage = "Please select producer(s) from the list.";
          goto label_8;
        }
        if (this.clbProducers.CheckedItems.Count > 200)
        {
          inputErrorMessage = "Please select fewer then 200 producers.";
          goto label_8;
        }
      }
      else if (this.clbProducers.Items.Count - this.clbProducers.CheckedItems.Count > 200)
      {
        inputErrorMessage = "Please select more producers. Max number of unselected producers = 200.";
        goto label_8;
      }
      inputErrorMessage = string.Empty;
label_8:
      return inputErrorMessage;
    }
  }

  public override object Value
  {
    get
    {
      string empty = string.Empty;
      if (this.SendSelected)
      {
        int num = this.clbProducers.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select($"ControlIndex={this.clbProducers.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.clbProducers.CheckedItems[index]))}")[0]["ProducerGuid"].ToString();
        }
      }
      else
      {
        int num = this.clbProducers.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!this.clbProducers.GetItemChecked(index))
          {
            if (empty.Length > 0)
              empty += ",";
            empty += this._dt.Select($"ControlIndex={index}")[0]["ProducerGuid"].ToString();
          }
        }
      }
      return (object) new object[2]
      {
        (object) empty,
        (object) this.SendSelected
      };
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)))
        return;
      object[] objArray = (object[]) value;
      this.SendSelected = (bool) objArray[1];
      if (!this.SendSelected && Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) objArray[0], "", false) == 0)
      {
        int num = this.clbProducers.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
          this.clbProducers.SetItemChecked(index, true);
      }
      else
      {
        int count = this._dt.Rows.Count;
        string[] array = Strings.Split((string) objArray[0], ",");
        try
        {
          foreach (DataRow row in this._dt.Rows)
          {
            int integer = Conversions.ToInteger(row["ControlIndex"]);
            if (Array.IndexOf<string>(array, row["ProducerGUID"].ToString()) > -1)
              this.clbProducers.SetItemChecked(integer, this.SendSelected);
            else
              this.clbProducers.SetItemChecked(integer, !this.SendSelected);
          }
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
    this.LinkLabel1.Top = 0;
    this.clbProducers.Top = this.LinkLabel1.Height;
    this.lblDescription.Height = this.clbProducers.Height + this.clbProducers.Top;
    this.lblDescription.Top = 0;
    this.Height = this.lblDescription.Height;
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.SendSelected)
    {
      this.SendSelected = false;
      this.LinkLabel1.Text = "UnSelect All";
      int num = this.clbProducers.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.clbProducers.SetItemCheckState(index, CheckState.Checked);
    }
    else
    {
      this.SendSelected = true;
      this.LinkLabel1.Text = "Select All";
      int num = this.clbProducers.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.clbProducers.SetItemCheckState(index, CheckState.Unchecked);
    }
  }
}
