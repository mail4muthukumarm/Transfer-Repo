// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyCompanyLineInstallments
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyCompanyLineInstallments : Form
{
  private IContainer components;
  private CompanyLine _companyLine;
  private Thread _loadThread;

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
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtCopy", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("IsParentLine");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CopyOver");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    this.dg = new UltraGrid();
    this.ds = new dsCopyInstallments();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.lblCompany = new Label();
    this.lblLine = new Label();
    this.lblState = new Label();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.dg).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dg).DataMember = "dtCopy";
    ((UltraGridBase) this.dg).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 20;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 252;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 373;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Parent Line";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 87;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Copy";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 74;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(12, 87);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(536, 432);
    ((Control) this.dg).TabIndex = 1;
    ((Control) this.dg).Text = "Available States";
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCopyInstallments";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(9, 536);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 2;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(9, 579);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(68, 13);
    this.lnkDeSelectAll.TabIndex = 3;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(9, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(93, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Existing Company:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(9, 36);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 13);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Existing Line:";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(9, 63 /*0x3F*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(74, 13);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Existing State:";
    this.lblCompany.AutoSize = true;
    this.lblCompany.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCompany.Location = new Point(117, 9);
    this.lblCompany.Name = "lblCompany";
    this.lblCompany.Size = new Size(71, 13);
    this.lblCompany.TabIndex = 7;
    this.lblCompany.Text = "lblCompany";
    this.lblLine.AutoSize = true;
    this.lblLine.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLine.Location = new Point(117, 36);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(44, 13);
    this.lblLine.TabIndex = 8;
    this.lblLine.Text = "lblLine";
    this.lblState.AutoSize = true;
    this.lblState.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblState.Location = new Point(116, 63 /*0x3F*/);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(50, 13);
    this.lblState.TabIndex = 9;
    this.lblState.Text = "lblState";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(508, 549);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 10;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(560, 601);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lblState);
    this.Controls.Add((Control) this.lblLine);
    this.Controls.Add((Control) this.lblCompany);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.dg);
    this.Name = nameof (FormCopyCompanyLineInstallments);
    this.Text = "Copy Company/Line Installments";
    ((ISupportInitialize) this.dg).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("dg")]
  protected virtual UltraGrid dg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyInstallments ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompany")]
  internal virtual Label lblCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  internal virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblState")]
  internal virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [EditorBrowsable(EditorBrowsableState.Never)]
  public FormCopyCompanyLineInstallments()
  {
    this.Load += new EventHandler(this.FormCopyCompanyLineInstallments_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormCopyCompanyLineInstallments_FormClosing);
    this.InitializeComponent();
  }

  public FormCopyCompanyLineInstallments(int companyLineID)
  {
    this.Load += new EventHandler(this.FormCopyCompanyLineInstallments_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormCopyCompanyLineInstallments_FormClosing);
    this.InitializeComponent();
    this._companyLine = new CompanyLine(companyLineID);
  }

  private void FormCopyCompanyLineInstallments_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((Control) this.btnSave).Enabled = false;
    this.lblCompany.Text = this._companyLine.CompanyLocation.LocationName;
    this.lblLine.Text = this._companyLine.LineName;
    this.lblState.Text = this._companyLine.StateID;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadLoadForm));
  }

  private void ThreadLoadForm(object state)
  {
    dsCopyInstallments.dtCopyDataTable dtCopyDataTable = new dsCopyInstallments.dtCopyDataTable();
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) dtCopyDataTable, "dbo.spGetCopyInstallmentsInfo", new object[2]
      {
        (object) "@ExistingCompanyLineID",
        (object) this._companyLine.CompanyLineID
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    MDIControls.Instance.MDIParent.Invoke((Delegate) new FormCopyCompanyLineInstallments.LoadFormThreadedCompleteHandler(this.LoadFormThreadComplete), (object) dtCopyDataTable);
  }

  private void LoadFormThreadComplete(dsCopyInstallments.dtCopyDataTable dt)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      ((UltraGridBase) this.dg).DisplayLayout.Save((Stream) memoryStream);
      this.ds.dtCopy.BeginLoadData();
      try
      {
        foreach (DataRow row in (TypedTableBase<dsCopyInstallments.dtCopyRow>) dt)
          this.ds.dtCopy.ImportRow(row);
      }
      finally
      {
        IEnumerator<dsCopyInstallments.dtCopyRow> enumerator;
        enumerator?.Dispose();
      }
      this.ds.dtCopy.EndLoadData();
      memoryStream.Position = 0L;
      ((UltraGridBase) this.dg).DisplayLayout.Load((Stream) memoryStream);
    }
    this.SetCopyOnGrid(false);
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.ds.AcceptChanges();
    ((Control) this.btnSave).Enabled = true;
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyOnGrid(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyOnGrid(false);
  }

  private void SetCopyOnGrid(bool copyBooleanValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dg).Rows)
      row.Cells["CopyOver"].Value = (object) copyBooleanValue;
  }

  private void FormCopyCompanyLineInstallments_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this._loadThread == null || !this._loadThread.IsAlive)
      return;
    this._loadThread.Abort();
    this._loadThread = (Thread) null;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.ds.dtCopy.Count == 0)
    {
      int num1 = (int) MessageBox.Show("No record is available to copy over.", "No Record Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("Continue copy installments to other company / line?", "Continue Copy", MessageBoxButtons.YesNo) == DialogResult.No)
        return;
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        string str = string.Empty;
        RowEnumerator enumerator = ((UltraGridBase) this.dg).Rows.GetEnumerator();
        while (enumerator.MoveNext())
        {
          UltraGridRow current = enumerator.Current;
          if ((bool) current.Cells["CopyOver"].Value)
            str = $"{str}{current.Cells["CompanyLineID"].Value.ToString()},";
        }
        if (str.Equals(string.Empty))
        {
          int num2 = (int) MessageBox.Show("No record is selected to copy over.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
        DefaultDatabase.ExecuteNonQuery("spCopyCompanyLineInstallments", new object[4]
        {
          (object) "@ExistingCompanyLineID",
          (object) this._companyLine.CompanyLineID,
          (object) "@companyLineIDStr",
          (object) str
        });
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
      this.Close();
    }
  }

  private delegate void LoadFormThreadedCompleteHandler(dsCopyInstallments.dtCopyDataTable dt);
}
