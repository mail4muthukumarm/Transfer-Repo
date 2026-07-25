// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmAddFCWToOtherStates
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class frmAddFCWToOtherStates : Form
{
  private IContainer components;
  private readonly DataTable _dt;
  private readonly int _company_FCW_ID;
  private readonly List<int> _lstCompanyFCW;
  private readonly bool _listCopy;

  public frmAddFCWToOtherStates()
  {
    this.Load += new EventHandler(this.frmAddFCWToOtherStates_Load);
    this._company_FCW_ID = int.MinValue;
    this._lstCompanyFCW = new List<int>();
    this._listCopy = false;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lstStates")]
  internal virtual MGACheckedListBox lstStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeselectALL
  {
    get => this._lnkDeselectALL;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectALL_LinkClicked);
      LinkLabel lnkDeselectAll1 = this._lnkDeselectALL;
      if (lnkDeselectAll1 != null)
        lnkDeselectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectALL = value;
      LinkLabel lnkDeselectAll2 = this._lnkDeselectALL;
      if (lnkDeselectAll2 == null)
        return;
      lnkDeselectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.btnSave = new MGAButton();
    this.lstStates = new MGACheckedListBox();
    this.Label1 = new Label();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeselectALL = new LinkLabel();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.lstStates).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(446, 504);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 5;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lstStates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstStates.CheckOnClick = true;
    this.lstStates.Location = new Point(11, 66);
    this.lstStates.Name = "lstStates";
    this.lstStates.Size = new Size(475, 409);
    this.lstStates.TabIndex = 6;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(474, 36);
    this.Label1.TabIndex = 7;
    this.Label1.Text = "This company and line is currently available in the following states.   Please select all the states you would like to apply this form to:";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.Location = new Point(8, 488);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(67, 18);
    this.lnkSelectAll.TabIndex = 8;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkDeselectALL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectALL.Location = new Point(8, 518);
    this.lnkDeselectALL.Name = "lnkDeselectALL";
    this.lnkDeselectALL.Size = new Size(87, 26);
    this.lnkDeselectALL.TabIndex = 9;
    this.lnkDeselectALL.TabStop = true;
    this.lnkDeselectALL.Text = "De-Select All";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(498, 556);
    this.Controls.Add((Control) this.lnkDeselectALL);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lstStates);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (frmAddFCWToOtherStates);
    this.Text = "Add FCW To Other States";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.lstStates).EndInit();
    this.ResumeLayout(false);
  }

  public frmAddFCWToOtherStates(DataTable dt, int companyLineID, int company_FCW_ID)
  {
    this.Load += new EventHandler(this.frmAddFCWToOtherStates_Load);
    this._company_FCW_ID = int.MinValue;
    this._lstCompanyFCW = new List<int>();
    this._listCopy = false;
    this.InitializeComponent();
    this._dt = dt;
    this._company_FCW_ID = company_FCW_ID;
    this._listCopy = false;
  }

  public frmAddFCWToOtherStates(DataTable dt, int companyLineID, List<int> lstCompanyFCW)
  {
    this.Load += new EventHandler(this.frmAddFCWToOtherStates_Load);
    this._company_FCW_ID = int.MinValue;
    this._lstCompanyFCW = new List<int>();
    this._listCopy = false;
    this.InitializeComponent();
    this._dt = dt;
    this._lstCompanyFCW = lstCompanyFCW;
    this._listCopy = true;
  }

  private void frmAddFCWToOtherStates_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    this.lstStates.DataSource = (object) this._dt;
    this.lstStates.DisplayMember = "StateID";
    this.lstStates.ValueMember = "CompanyLineID";
  }

  private void SetAllItems(bool SetChecked)
  {
    int num = this.lstStates.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstStates.SetItemChecked(index, SetChecked);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAllItems(true);
  }

  private void lnkDeselectALL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAllItems(false);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this._listCopy)
      this.SingleCopy();
    else
      this.MultiCopy();
  }

  private void SingleCopy()
  {
    try
    {
      foreach (DataRowView checkedItem in this.lstStates.CheckedItems)
      {
        int num1 = (int) checkedItem["CompanyLineID"];
        try
        {
          DefaultDatabase.ExecuteNonQuery("dbo.CopyFormsConditionsWarranties", new object[4]
          {
            (object) "@companyLineID",
            (object) num1,
            (object) "@company_FCW_ID",
            (object) this._company_FCW_ID
          });
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (ex.Message.Contains("IX_tblCompanyFormsConditionsWarranties"))
          {
            int num2 = (int) MessageBox.Show("This item is already found on this Company / Line / State setup", "Item Already Found On Company / Line / State Setup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
          }
          else
            throw;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void MultiCopy()
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      int num1 = this._lstCompanyFCW.Count - 1;
      for (int index = 0; index <= num1; ++index)
      {
        try
        {
          foreach (DataRowView checkedItem in this.lstStates.CheckedItems)
          {
            int num2 = (int) checkedItem["CompanyLineID"];
            try
            {
              DefaultDatabase.ExecuteNonQuery("dbo.CopyFormsConditionsWarranties", new object[4]
              {
                (object) "@companyLineID",
                (object) num2,
                (object) "@company_FCW_ID",
                (object) this._lstCompanyFCW[index]
              });
            }
            catch (SqlException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              if (!ex.Message.Contains("IX_tblCompanyFormsConditionsWarranties"))
                throw;
              ProjectData.ClearProjectError();
            }
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
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }
}
