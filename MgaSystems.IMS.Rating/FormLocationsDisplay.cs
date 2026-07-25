// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormLocationsDisplay
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class FormLocationsDisplay : Form
{
  private IContainer components;
  private Guid _currentLocationGuid;
  private Guid _quoteGuid;
  private List<Guid> _locationList;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LocationNo");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("BuildingNo");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PhysicalBuildingNo");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Limits");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnOk = new MGAButton();
    this.lnkDeSelect = new LinkLabel();
    this.lnkSelect = new LinkLabel();
    this.dgContacts = new UltraGrid();
    this.ds = new dsLocationsDisplay();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.dgContacts).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(880, 449);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(68, 23);
    ((Control) this.btnCancel).TabIndex = 9;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnOk).DialogResult = DialogResult.OK;
    ((Control) this.btnOk).Location = new Point(785, 449);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(68, 23);
    ((Control) this.btnOk).TabIndex = 8;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkDeSelect.AutoSize = true;
    this.lnkDeSelect.Location = new Point(9, 462);
    this.lnkDeSelect.Name = "lnkDeSelect";
    this.lnkDeSelect.Size = new Size(68, 13);
    this.lnkDeSelect.TabIndex = 10;
    this.lnkDeSelect.TabStop = true;
    this.lnkDeSelect.Text = "De-Select All";
    this.lnkSelect.AutoSize = true;
    this.lnkSelect.Location = new Point(12, 435);
    this.lnkSelect.Name = "lnkSelect";
    this.lnkSelect.Size = new Size(51, 13);
    this.lnkSelect.TabIndex = 11;
    this.lnkSelect.TabStop = true;
    this.lnkSelect.Text = "Select All";
    ((Control) this.dgContacts).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgContacts).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgContacts).DataMember = "dt";
    ((UltraGridBase) this.dgContacts).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 112 /*0x70*/;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Loc #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 101;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Bldg #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 96 /*0x60*/;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Phys Bldg #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 113;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 180;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 178;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 93;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 90;
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
    ((UltraGridBase) this.dgContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgContacts).Location = new Point(12, 12);
    ((Control) this.dgContacts).Name = "dgContacts";
    ((Control) this.dgContacts).Size = new Size(936, 420);
    ((Control) this.dgContacts).TabIndex = 3;
    ((UltraControlBase) this.dgContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsLocationsDisplay";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(960, 484);
    this.Controls.Add((Control) this.lnkSelect);
    this.Controls.Add((Control) this.lnkDeSelect);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.dgContacts);
    this.Name = nameof (FormLocationsDisplay);
    this.Text = "Available Locations Display";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.dgContacts).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("dgContacts")]
  protected virtual UltraGrid dgContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
  internal virtual dsLocationsDisplay ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelect
  {
    get => this._lnkDeSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelect_LinkClicked);
      LinkLabel lnkDeSelect1 = this._lnkDeSelect;
      if (lnkDeSelect1 != null)
        lnkDeSelect1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelect = value;
      LinkLabel lnkDeSelect2 = this._lnkDeSelect;
      if (lnkDeSelect2 == null)
        return;
      lnkDeSelect2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelect
  {
    get => this._lnkSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelect_LinkClicked);
      LinkLabel lnkSelect1 = this._lnkSelect;
      if (lnkSelect1 != null)
        lnkSelect1.LinkClicked -= clickedEventHandler;
      this._lnkSelect = value;
      LinkLabel lnkSelect2 = this._lnkSelect;
      if (lnkSelect2 == null)
        return;
      lnkSelect2.LinkClicked += clickedEventHandler;
    }
  }

  public List<Guid> LocationList => this._locationList;

  public FormLocationsDisplay(Guid currentLocationGuid, Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormLocationsDisplay_Load);
    this._locationList = new List<Guid>();
    this.InitializeComponent();
    this._currentLocationGuid = currentLocationGuid;
    this._quoteGuid = quoteGuid;
  }

  private void FormLocationsDisplay_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dt"
    }, CommandType.Text, "SELECT 1 AS Selected, LocationGuid, LocationNo, BuildingNo, PhysicalBuildingNo, Address1, City, State, ISNULL(Limits, 0) AS Limits FROM tblUnderwritingLocations WITH (NOLOCK) WHERE QuoteGuid = @QuoteGuid AND LocationGuid <> @LocationGuid ORDER BY LocationNo, CASE WHEN ISNUMERIC(BuildingNo) = 1 THEN CONVERT(INT, BuildingNo) ELSE 9000 END", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid,
      (object) "@LocationGuid",
      (object) this._currentLocationGuid
    });
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this._locationList.Clear();
    try
    {
      foreach (dsLocationsDisplay.dtRow row in this.ds.dt.Rows)
      {
        if (row.Selected)
          this._locationList.Add(row.LocationGuid);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._locationList.Clear();
    this.Close();
  }

  private void lnkSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetSelectionColumn(true);
  }

  private void lnkDeSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetSelectionColumn(false);
  }

  private void SetSelectionColumn(bool selectionValue)
  {
    try
    {
      foreach (dsLocationsDisplay.dtRow row in this.ds.dt.Rows)
        row.Selected = selectionValue;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
