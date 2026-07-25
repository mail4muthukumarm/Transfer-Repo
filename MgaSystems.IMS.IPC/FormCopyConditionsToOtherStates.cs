// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyConditionsToOtherStates
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.BusinessObjects;
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

[DesignerGenerated]
public class FormCopyConditionsToOtherStates : Form
{
  private IContainer components;
  private readonly DataTable _dt;
  private readonly List<int> _lstCompanyFCW;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.lnkDeselectALL = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnSave = new MGAButton();
    this.lstStates = new MGACheckedListBox();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.lstStates).BeginInit();
    this.SuspendLayout();
    this.lnkDeselectALL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectALL.Location = new Point(12, 519);
    this.lnkDeselectALL.Name = "lnkDeselectALL";
    this.lnkDeselectALL.Size = new Size(87, 17);
    this.lnkDeselectALL.TabIndex = 12;
    this.lnkDeselectALL.TabStop = true;
    this.lnkDeselectALL.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.Location = new Point(12, 489);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(67, 18);
    this.lnkSelectAll.TabIndex = 11;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(498, 500);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 10;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lstStates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstStates.CheckOnClick = true;
    this.lstStates.Location = new Point(12, 12);
    this.lstStates.Name = "lstStates";
    this.lstStates.Size = new Size(526, 469);
    this.lstStates.TabIndex = 13;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(550, 552);
    this.Controls.Add((Control) this.lstStates);
    this.Controls.Add((Control) this.lnkDeselectALL);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (FormCopyConditionsToOtherStates);
    this.Text = "Copy Conditions To Other States";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.lstStates).EndInit();
    this.ResumeLayout(false);
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

  public FormCopyConditionsToOtherStates(
    CompanyLine cl,
    DataTable dt,
    int companyLineID,
    List<int> lstCompanyFCW)
  {
    this.Load += new EventHandler(this.FormCopyConditionsToOtherStates_Load);
    this._lstCompanyFCW = new List<int>();
    this.InitializeComponent();
    this._dt = dt;
    this._lstCompanyFCW = lstCompanyFCW;
  }

  private void FormCopyConditionsToOtherStates_Load(object sender, EventArgs e)
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
              DefaultDatabase.ExecuteNonQuery("dbo.CopyConditionsToOtherStates", new object[4]
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
