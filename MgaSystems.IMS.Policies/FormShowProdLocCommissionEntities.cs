// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormShowProdLocCommissionEntities
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.IMS.Policies.Commissions;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormShowProdLocCommissionEntities : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private string _entityTypeID;
  private dsPolicyCommissions _dsTemp;

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
    UltraGridBand ultraGridBand = new UltraGridBand("View", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Participant");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Percentage");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DollarAmount");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CommissionFrom");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CommissionTypeID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("EntityType");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Premium");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.dgComm = new UltraGrid();
    this.ds = new dsPolicyCommissions();
    ((ISupportInitialize) this.dgComm).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.dgComm).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgComm).DataMember = "View";
    ((UltraGridBase) this.dgComm).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgComm).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgComm).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 182;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 147;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 5;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 183;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 407;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn5.Format = "#,##0.00## %";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 108;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn6.Format = "c";
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Flat Amount";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Width = 106;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Commission Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 187;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 162;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 117;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 157;
    ultraGridBand.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.dgComm).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgComm).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgComm).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgComm).Location = new Point(12, 12);
    ((Control) this.dgComm).Name = "dgComm";
    ((Control) this.dgComm).Size = new Size(810, 314);
    ((Control) this.dgComm).TabIndex = 18;
    ((UltraControlBase) this.dgComm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgComm).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPolicyCommissions";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(834, 338);
    this.Controls.Add((Control) this.dgComm);
    this.Name = nameof (FormShowProdLocCommissionEntities);
    this.Text = "Producer Location Commission Entities";
    ((ISupportInitialize) this.dgComm).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dgComm")]
  private virtual UltraGrid dgComm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  private virtual dsPolicyCommissions ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormShowProdLocCommissionEntities(
    Guid quoteGuid,
    string entityTypeID,
    dsPolicyCommissions dsTemp)
  {
    this.Load += new EventHandler(this.FormShowProdLocCommissionEntities_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._entityTypeID = entityTypeID;
    this._dsTemp = dsTemp;
  }

  private void FormShowProdLocCommissionEntities_Load(object sender, EventArgs e)
  {
    if (this._entityTypeID.Equals("L"))
      this.Text = "Producer Location Commission Entities";
    else if (this._entityTypeID.Equals("C"))
      this.Text = "Company Commission Entities";
    else
      this.Text = "Commission Entities";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstEntityTypes"
    }, CommandType.Text, "SELECT * FROM lstEntityTypes");
    string description = this.ds.lstEntityTypes.FindByEntityTypeID(this._entityTypeID).Description;
    try
    {
      foreach (dsPolicyCommissions.ViewRow row1 in this._dsTemp.View.Rows)
      {
        if (row1.EntityType.Equals(description))
        {
          dsPolicyCommissions.ViewRow row2 = this.ds.View.NewViewRow();
          row2.Participant = row1.Participant;
          if (!row1.IsPercentageNull())
            row2.Percentage = row1.Percentage;
          if (!row1.IsDollarAmountNull())
            row2.DollarAmount = row1.DollarAmount;
          row2.CommissionFrom = row1.CommissionFrom;
          row2.CommissionTypeID = row1.CommissionTypeID;
          row2.EntityGuid = row1.EntityGuid;
          row2.EntityType = row1.EntityType;
          row2.Premium = row1.Premium;
          row2.ChargeCode = row1.ChargeCode;
          if (row1.IsWaivedByUserGuidNull())
            row2.SetWaivedByUserGuidNull();
          else
            row2.WaivedByUserGuid = row1.WaivedByUserGuid;
          this.ds.View.AddViewRow(row2);
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
