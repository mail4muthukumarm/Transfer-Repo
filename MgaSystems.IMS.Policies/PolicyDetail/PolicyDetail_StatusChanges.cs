// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.PolicyDetail_StatusChanges
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[PolicyDetail_Plugin("Status Changes", "Status Changes")]
public sealed class PolicyDetail_StatusChanges : PolicyDetail_Plugin
{
  private IContainer components;
  private UltraGrid dgStatusChanges;
  private dsPolicyDetail_StatusChanges ds;
  private Guid _quoteGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblQuoteStatusChangeLog", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Original");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("NewDescription");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Timestamp");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Display");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Comment");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.dgStatusChanges = new UltraGrid();
    this.ds = new dsPolicyDetail_StatusChanges();
    ((ISupportInitialize) this.dgStatusChanges).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((UltraControlBase) this.dgStatusChanges).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgStatusChanges).DataSource = (object) this.ds.tblQuoteStatusChangeLog;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 134;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 85;
    ultraGridColumn3.CellMultiLine = (DefaultableBoolean) 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 191;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Occurred";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 5;
    ultraGridColumn4.Width = 103;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 169;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Width = 174;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.RowSizing = (RowSizing) 5;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgStatusChanges).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((Control) this.dgStatusChanges).Dock = DockStyle.Fill;
    ((Control) this.dgStatusChanges).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgStatusChanges).Location = new Point(0, 0);
    ((Control) this.dgStatusChanges).Name = "dgStatusChanges";
    ((Control) this.dgStatusChanges).Size = new Size(656, 88);
    ((Control) this.dgStatusChanges).TabIndex = 2;
    ((UltraControlBase) this.dgStatusChanges).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgStatusChanges).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPolicyDetail_StatusChanges";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Controls.Add((Control) this.dgStatusChanges);
    this.Name = nameof (PolicyDetail_StatusChanges);
    this.Size = new Size(656, 88);
    ((ISupportInitialize) this.dgStatusChanges).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public PolicyDetail_StatusChanges(Guid quoteGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
  }

  public PolicyDetail_StatusChanges() => this.InitializeComponent();

  public override void Fill() => ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));

  private void ThreadedFill(object state)
  {
    Thread.Sleep(100);
    dsPolicyDetail_StatusChanges detailStatusChanges = new dsPolicyDetail_StatusChanges();
    Quote quote = new Quote(this._quoteGuid);
    detailStatusChanges.EnforceConstraints = false;
    DefaultDatabase.LoadDataTable((DataTable) detailStatusChanges.tblQuoteStatusChangeLog, "dbo.spFillStatusChangeLog", new object[2]
    {
      (object) "@ControlNo",
      (object) quote.ControlNo
    });
    if (detailStatusChanges.tblQuoteStatusChangeLog.Count <= 0)
      return;
    try
    {
      detailStatusChanges.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ConstraintException constraintException = ex;
      ErrorHandler.ShowDataSetErrors((DataSet) detailStatusChanges, constraintException);
      ProjectData.ClearProjectError();
    }
    MDIControls.Instance.MDIParent.Invoke((Delegate) new PolicyDetail_StatusChanges.FillCompleteHandler(this.FillComplete), (object) detailStatusChanges.tblQuoteStatusChangeLog);
  }

  private void FillComplete(
    dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable dt)
  {
    UltraGrid dgStatusChanges = this.dgStatusChanges;
    ((UltraGridBase) dgStatusChanges).DataMember = string.Empty;
    ((UltraGridBase) dgStatusChanges).DataSource = (object) dt;
    ((UltraGridBase) dgStatusChanges).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
  }

  private delegate void FillCompleteHandler(
    dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable dt);
}
