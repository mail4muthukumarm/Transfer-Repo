// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormGeoAddress
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormGeoAddress : Form
{
  private IContainer components;
  private dsGeoAddress.dtAddressRow _dtAddressRow;

  public FormGeoAddress() => this.InitializeComponent();

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtAddress", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Index");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Longitude");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Latitude");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GeoStatus");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("MapURL");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnOk = new MGAButton();
    this.dgAddress = new UltraGrid();
    this.ds = new dsGeoAddress();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.dgAddress).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(12, 248);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(68, 23);
    ((Control) this.btnCancel).TabIndex = 6;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Visible = false;
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnOk).DialogResult = DialogResult.OK;
    ((Control) this.btnOk).Location = new Point(603, 248);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(68, 23);
    ((Control) this.btnOk).TabIndex = 5;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.dgAddress).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgAddress).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgAddress).DataMember = "dtAddress";
    ((UltraGridBase) this.dgAddress).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAddress).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgAddress).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Width = 75;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 113;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ultraGridColumn3.Width = 78;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 68;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 93;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 112 /*0x70*/;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 5;
    ultraGridColumn7.Width = 111;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Geo Status";
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 81;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 85;
    ultraGridBand.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.dgAddress).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgAddress).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAddress).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAddress).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAddress).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgAddress).Location = new Point(12, 12);
    ((Control) this.dgAddress).Name = "dgAddress";
    ((Control) this.dgAddress).Size = new Size(659, 208 /*0xD0*/);
    ((Control) this.dgAddress).TabIndex = 1;
    ((UltraControlBase) this.dgAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAddress).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsGeoAddr";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(683, 283);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.dgAddress);
    this.Name = nameof (FormGeoAddress);
    this.Text = "Available Geo Addresses";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.dgAddress).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dgAddress")]
  protected virtual UltraGrid dgAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      MGAButton btnOk1 = this._btnOk;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOk = value;
      MGAButton btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsGeoAddress ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public dsGeoAddress.dtAddressRow SelectedAddress => this._dtAddressRow;

  public dsGeoAddress.dtAddressDataTable Addresses
  {
    get => this.ds.dtAddress;
    set
    {
      this.ds.dtAddress.Clear();
      int Index = 0;
      try
      {
        foreach (dsGeoAddress.dtAddressRow dtAddressRow in (TypedTableBase<dsGeoAddress.dtAddressRow>) value)
        {
          ++Index;
          this.ds.dtAddress.AdddtAddressRow(dtAddressRow.State, dtAddressRow.City, dtAddressRow.County, dtAddressRow.ZipCode, Index, dtAddressRow.Longitude, dtAddressRow.Latitude, dtAddressRow.GeoStatus, dtAddressRow.MapURL);
        }
      }
      finally
      {
        IEnumerator<dsGeoAddress.dtAddressRow> enumerator;
        enumerator?.Dispose();
      }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._dtAddressRow = (dsGeoAddress.dtAddressRow) null;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgAddress).ActiveRow == null)
      this._dtAddressRow = (dsGeoAddress.dtAddressRow) null;
    this._dtAddressRow = this.ds.dtAddress.FindByIndex(Conversions.ToInteger(((UltraGridBase) this.dgAddress).ActiveRow.Cells["Index"].Value));
  }
}
