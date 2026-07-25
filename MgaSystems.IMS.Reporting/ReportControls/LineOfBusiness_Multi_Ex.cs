// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.LineOfBusiness_Multi_Ex
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

public class LineOfBusiness_Multi_Ex : BaseReportControl
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

  [field: AccessedThroughProperty("clbLOBs")]
  internal virtual MGACheckedListBox clbLOBs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.clbLOBs = new MGACheckedListBox();
    this.LinkLabel1 = new LinkLabel();
    ((ISupportInitialize) this.clbLOBs).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 102);
    this.clbLOBs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.clbLOBs.CheckOnClick = true;
    this.clbLOBs.Location = new Point(88, 17);
    this.clbLOBs.Name = "clbLOBs";
    this.clbLOBs.Size = new Size(300, 79);
    this.clbLOBs.TabIndex = 1;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
    this.LinkLabel1.Location = new Point(86, 1);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(51, 13);
    this.LinkLabel1.TabIndex = 2;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Select All";
    this.LinkLabel1.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.clbLOBs);
    this.Controls.Add((Control) this.LinkLabel1);
    this.Name = nameof (LineOfBusiness_Multi_Ex);
    this.Size = new Size(392, 102);
    this.Controls.SetChildIndex((Control) this.LinkLabel1, 0);
    this.Controls.SetChildIndex((Control) this.clbLOBs, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.clbLOBs).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public LineOfBusiness_Multi_Ex(string LabelText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LineName,LineGUID from lstLines ORDER BY LineName");
    this._dt.Columns.Add("ControlIndex", typeof (int));
    try
    {
      foreach (DataRow row in this._dt.Rows)
        row["ControlIndex"] = (object) this.clbLOBs.Items.Add((object) Strings.Trim(row["LineName"].ToString()));
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
        if (this.clbLOBs.CheckedItems.Count == 0)
        {
          inputErrorMessage = "Please select LOB(s) from the list.";
          goto label_8;
        }
        if (this.clbLOBs.CheckedItems.Count > 200)
        {
          inputErrorMessage = "Please select fewer then 200 LOBs.";
          goto label_8;
        }
      }
      else if (this.clbLOBs.Items.Count - this.clbLOBs.CheckedItems.Count > 200)
      {
        inputErrorMessage = "Please select more LOBs. Max number of unselected LOBs = 200.";
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
        int num = this.clbLOBs.CheckedItems.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (empty.Length > 0)
            empty += ",";
          empty += this._dt.Select($"ControlIndex={this.clbLOBs.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.clbLOBs.CheckedItems[index]))}")[0]["LineGuid"].ToString();
        }
      }
      else
      {
        int num = this.clbLOBs.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (!this.clbLOBs.GetItemChecked(index))
          {
            if (empty.Length > 0)
              empty += ",";
            empty += this._dt.Select($"ControlIndex={index}")[0]["LineGuid"].ToString();
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
        int num = this.clbLOBs.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
          this.clbLOBs.SetItemChecked(index, true);
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
            if (Array.IndexOf<string>(array, row["LineGUID"].ToString()) > -1)
              this.clbLOBs.SetItemChecked(integer, this.SendSelected);
            else
              this.clbLOBs.SetItemChecked(integer, !this.SendSelected);
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
    this.clbLOBs.Top = this.LinkLabel1.Height;
    this.lblDescription.Height = this.clbLOBs.Height + this.clbLOBs.Top;
    this.lblDescription.Top = 0;
    this.Height = this.lblDescription.Height;
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.SendSelected)
    {
      this.SendSelected = false;
      this.LinkLabel1.Text = "UnSelect All";
      int num = this.clbLOBs.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.clbLOBs.SetItemCheckState(index, CheckState.Checked);
    }
    else
    {
      this.SendSelected = true;
      this.LinkLabel1.Text = "Select All";
      int num = this.clbLOBs.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.clbLOBs.SetItemCheckState(index, CheckState.Unchecked);
    }
  }
}
