// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormAssignBrokerBillingType
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormAssignBrokerBillingType : Form
{
  private IContainer components;
  private Guid _producerLocationGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BillingType");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("DownPaymentOnly");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AllowView");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("BillingType");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DownPaymentOnly");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AllowView");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.ugDP = new UltraGrid();
    this.ugAvail = new UltraGrid();
    this.dvDownpay = new DataView();
    this.ds = new dsBT();
    this.dvNon = new DataView();
    ((ISupportInitialize) this.ugDP).BeginInit();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.dvDownpay.BeginInit();
    this.ds.BeginInit();
    this.dvNon.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugDP).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugDP).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugDP).DataSource = (object) this.dvDownpay;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDP).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugDP).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 172;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Downpayment BillingType";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 279;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 85;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Assign";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 73;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugDP).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugDP).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDP).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDP).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugDP).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugDP).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugDP).Location = new Point(12, 252);
    ((Control) this.ugDP).Name = "ugDP";
    ((Control) this.ugDP).Size = new Size(354, 278);
    ((Control) this.ugDP).TabIndex = 14;
    ((Control) this.ugDP).Text = "DownPayment Billing Types";
    ((UltraControlBase) this.ugDP).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDP).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.dvNon;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 172;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 279;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 85;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Assign";
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Width = 73;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ugAvail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugAvail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugAvail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAvail).Location = new Point(12, 12);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(354, 232);
    ((Control) this.ugAvail).TabIndex = 13;
    ((Control) this.ugAvail).Text = "Policy Billing Types";
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.dvDownpay.RowFilter = "DownpaymentOnly = 1";
    this.dvDownpay.Sort = "BillingType";
    this.dvDownpay.Table = (DataTable) this.ds.dt;
    this.ds.DataSetName = "dsBT";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dvNon.RowFilter = "DownpaymentOnly = 0";
    this.dvNon.Table = (DataTable) this.ds.dt;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(378, 542);
    this.Controls.Add((Control) this.ugDP);
    this.Controls.Add((Control) this.ugAvail);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAssignBrokerBillingType);
    this.Text = "Assign Producer Billing Type";
    ((ISupportInitialize) this.ugDP).EndInit();
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.dvDownpay.EndInit();
    this.ds.EndInit();
    this.dvNon.EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraGrid ugAvail
  {
    get => this._ugAvail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.GridsCellChange);
      UltraGrid ugAvail1 = this._ugAvail;
      if (ugAvail1 != null)
        ugAvail1.CellChange -= cellEventHandler;
      this._ugAvail = value;
      UltraGrid ugAvail2 = this._ugAvail;
      if (ugAvail2 == null)
        return;
      ugAvail2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsBT ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugDP
  {
    get => this._ugDP;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.DPGridCellChange);
      UltraGrid ugDp1 = this._ugDP;
      if (ugDp1 != null)
        ugDp1.CellChange -= cellEventHandler;
      this._ugDP = value;
      UltraGrid ugDp2 = this._ugDP;
      if (ugDp2 == null)
        return;
      ugDp2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("dvDownpay")]
  private virtual DataView dvDownpay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvNon")]
  private virtual DataView dvNon { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormAssignBrokerBillingType(Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.FormAssignBrokerBillingType_Load);
    this.InitializeComponent();
    this._producerLocationGuid = producerLocationGuid;
  }

  private void FormAssignBrokerBillingType_Load(object sender, EventArgs e)
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
      {
        "dt",
        "tblProducerLocationBillingTypes"
      }, "spGetProducerLocationBillingTypesData", new object[2]
      {
        (object) "@producerLocationGuid",
        (object) this._producerLocationGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.ugAvail.CellChange -= new CellEventHandler(this.GridsCellChange);
    this.ugDP.CellChange -= new CellEventHandler(this.DPGridCellChange);
    try
    {
      try
      {
        foreach (dsBT.tblProducerLocationBillingTypesRow row in this.ds.tblProducerLocationBillingTypes.Rows)
        {
          dsBT.dtRow byBillingTypeId = this.ds.dt.FindByBillingTypeID(row.BillingTypeID);
          if (byBillingTypeId != null)
            byBillingTypeId.AllowView = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    finally
    {
      this.ugAvail.CellChange += new CellEventHandler(this.GridsCellChange);
      this.ugDP.CellChange += new CellEventHandler(this.DPGridCellChange);
    }
  }

  private void GridsCellChange(object sender, CellEventArgs e)
  {
    this.UpdateDownPayment(false, (object) this.ugAvail, e);
  }

  private void DPGridCellChange(object sender, CellEventArgs e)
  {
    this.UpdateDownPayment(false, (object) this.ugDP, e);
  }

  private void UpdateDownPayment(bool isDownPayment, object sender, CellEventArgs e)
  {
    if (e.Cell == null || e.Cell.Row == null || e.Cell.Value == null || !e.Cell.Column.Key.Equals("AllowView"))
      return;
    string name = ((Control) sender).Name;
    bool flag = sender == this.ugDP;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      string empty = string.Empty;
      short num = (short) e.Cell.Row.Cells["BillingTypeID"].Value;
      if ((bool) e.Cell.Value)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblProducerlocationBillingTypes WHERE ProducerLocationGuid=@LG AND BillingTypeID=@BT AND DownPayment=@DP", new object[6]
        {
          (object) "@LG",
          (object) this._producerLocationGuid,
          (object) "@BT",
          (object) num,
          (object) "@DP",
          (object) flag
        });
      else
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblProducerlocationBillingTypes( ProducerLocationGuid, BillingTypeID,DownPayment ) VALUES (@LG, @BT,@DP)", new object[6]
        {
          (object) "@LG",
          (object) this._producerLocationGuid,
          (object) "@BT",
          (object) num,
          (object) "@DP",
          (object) flag
        });
      ((UltraGridBase) this.ugAvail).UpdateData();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }
}
