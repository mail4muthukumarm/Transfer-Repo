// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormCopyLocations
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormCopyLocations : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private object _locsVisible;
  private bool _hasOptions;
  private int _optionID;

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
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblUnderwritingLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationNo");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BuildingNo");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PhysicalBuildingNo");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CopyLocation");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    this.Label1 = new Label();
    this.btnContinue = new MGAButton();
    this.txtControlNo = new MGATextBox();
    this.lnkDeleteSelectAll = new LinkLabel();
    this.lnkSelect = new LinkLabel();
    this.chkCopyExposures = new MGACheckBox();
    this.btnOptions = new MGAButton();
    this.ds = new copyLocatons();
    this.ug = new UltraGrid();
    this.txtOptionID = new MGATextBox();
    this.Label2 = new Label();
    ((ISupportInitialize) this.btnContinue).BeginInit();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.chkCopyExposures).BeginInit();
    ((ISupportInitialize) this.btnOptions).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    ((ISupportInitialize) this.txtOptionID).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(12, 23);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(53, 13);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Control #:";
    ((Control) this.btnContinue).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 3;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Left";
    ((ControlBase) this.btnContinue).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnContinue).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnContinue).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnContinue).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnContinue).Location = new Point(736, 574);
    ((Control) this.btnContinue).Name = "btnContinue";
    ((ControlBase) this.btnContinue).Padding = new Size(5, 0);
    ((Control) this.btnContinue).Size = new Size(104, 40);
    ((Control) this.btnContinue).TabIndex = 8;
    ((Control) this.btnContinue).Tag = (object) "";
    ((ControlBase) this.btnContinue).Text = "Copy";
    this.btnContinue.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtControlNo).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtControlNo).BackColor = Color.White;
    ((Control) this.txtControlNo).Location = new Point(71, 20);
    this.txtControlNo.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtControlNo).Name = "txtControlNo";
    ((Control) this.txtControlNo).Size = new Size(148, 19);
    ((Control) this.txtControlNo).TabIndex = 10;
    ((UltraControlBase) this.txtControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtControlNo).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkDeleteSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeleteSelectAll.AutoSize = true;
    this.lnkDeleteSelectAll.BackColor = Color.Transparent;
    this.lnkDeleteSelectAll.Location = new Point(9, 601);
    this.lnkDeleteSelectAll.Name = "lnkDeleteSelectAll";
    this.lnkDeleteSelectAll.Size = new Size(94, 13);
    this.lnkDeleteSelectAll.TabIndex = 21;
    this.lnkDeleteSelectAll.TabStop = true;
    this.lnkDeleteSelectAll.Text = "De-Select all Copy";
    this.lnkDeleteSelectAll.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelect.AutoSize = true;
    this.lnkSelect.BackColor = Color.Transparent;
    this.lnkSelect.Location = new Point(9, 565);
    this.lnkSelect.Name = "lnkSelect";
    this.lnkSelect.Size = new Size(92, 13);
    this.lnkSelect.TabIndex = 22;
    this.lnkSelect.TabStop = true;
    this.lnkSelect.Text = "Select all for Copy";
    this.lnkSelect.TextAlign = ContentAlignment.MiddleCenter;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCopyExposures).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkCopyExposures).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCopyExposures).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCopyExposures).Checked = true;
    ((UltraToggleEditorBase) this.chkCopyExposures).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkCopyExposures).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCopyExposures).Location = new Point(245, 19);
    this.chkCopyExposures.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCopyExposures).Name = "chkCopyExposures";
    ((Control) this.chkCopyExposures).Size = new Size(153, 20);
    ((Control) this.chkCopyExposures).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkCopyExposures).Text = "Copy Over Exposures";
    ((UltraControlBase) this.chkCopyExposures).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCopyExposures).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOptions).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.Gray;
    appearance4.ImageHAlign = (HAlign) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((ControlBase) this.btnOptions).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnOptions).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnOptions).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnOptions).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnOptions).Location = new Point(415, 16 /*0x10*/);
    ((Control) this.btnOptions).Name = "btnOptions";
    ((ControlBase) this.btnOptions).Padding = new Size(5, 0);
    ((Control) this.btnOptions).Size = new Size(152, 26);
    ((Control) this.btnOptions).TabIndex = 24;
    ((Control) this.btnOptions).Tag = (object) "";
    ((ControlBase) this.btnOptions).Text = "Select An Option ...";
    this.btnOptions.UseOSThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "copyLocatons";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "tblUnderwritingLocations";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 43;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Loc #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 76;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Bldg #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Phys #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 84;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Address";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 125;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 121;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Width = 82;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Width = 102;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn9.Width = 98;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Width = 43;
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
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.MidnightBlue;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ug).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ug).Location = new Point(12, 66);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(832, 476);
    ((Control) this.ug).TabIndex = 9;
    ((Control) this.ug).Text = "Available Locations(s)";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtOptionID).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtOptionID).BackColor = Color.White;
    ((Control) this.txtOptionID).Location = new Point(651, 19);
    ((TextEditorControlBase) this.txtOptionID).MaxLength = 4;
    this.txtOptionID.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtOptionID).Name = "txtOptionID";
    ((Control) this.txtOptionID).Size = new Size(165, 19);
    ((Control) this.txtOptionID).TabIndex = 25;
    ((UltraControlBase) this.txtOptionID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtOptionID).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(593, 25);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(52, 13);
    this.Label2.TabIndex = 26;
    this.Label2.Text = "OptionID:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(852, 626);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtOptionID);
    this.Controls.Add((Control) this.btnOptions);
    this.Controls.Add((Control) this.chkCopyExposures);
    this.Controls.Add((Control) this.lnkSelect);
    this.Controls.Add((Control) this.lnkDeleteSelectAll);
    this.Controls.Add((Control) this.txtControlNo);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.btnContinue);
    this.Controls.Add((Control) this.Label1);
    this.Name = nameof (FormCopyLocations);
    this.Text = "Copy Locations to Another Control #";
    ((ISupportInitialize) this.btnContinue).EndInit();
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.chkCopyExposures).EndInit();
    ((ISupportInitialize) this.btnOptions).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    ((ISupportInitialize) this.txtOptionID).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual copyLocatons ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      MGAButton btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        ((Control) btnContinue1).Click -= eventHandler;
      this._btnContinue = value;
      MGAButton btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      ((Control) btnContinue2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ug")]
  private virtual UltraGrid ug { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtControlNo")]
  private virtual MGATextBox txtControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkDeleteSelectAll
  {
    get => this._lnkDeleteSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeleteSelectAll_LinkClicked);
      LinkLabel lnkDeleteSelectAll1 = this._lnkDeleteSelectAll;
      if (lnkDeleteSelectAll1 != null)
        lnkDeleteSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeleteSelectAll = value;
      LinkLabel lnkDeleteSelectAll2 = this._lnkDeleteSelectAll;
      if (lnkDeleteSelectAll2 == null)
        return;
      lnkDeleteSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkSelect
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

  [field: AccessedThroughProperty("chkCopyExposures")]
  protected virtual MGACheckBox chkCopyExposures { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnOptions
  {
    get => this._btnOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaButton1_Click);
      MGAButton btnOptions1 = this._btnOptions;
      if (btnOptions1 != null)
        ((Control) btnOptions1).Click -= eventHandler;
      this._btnOptions = value;
      MGAButton btnOptions2 = this._btnOptions;
      if (btnOptions2 == null)
        return;
      ((Control) btnOptions2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtOptionID")]
  private virtual MGATextBox txtOptionID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCopyLocations(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormCopyLocations_Load);
    this._locsVisible = (object) null;
    this._hasOptions = false;
    this._optionID = int.MinValue;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  private void FormCopyLocations_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnContinue).Appearance.Image = (object) ImageCache.Instance.Forward;
    this._hasOptions = new Quote(this._quoteGuid).OptionCount > 0;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUnderwritingLocations"
    }, CommandType.Text, "SELECT \r\n\t\t\tLocationID,\r\n\t\t\tLocationNo,\r\n\t\t\tBuildingNo, \r\n\t\t\tPhysicalBuildingNo, \r\n\t\t\tAddress1,\t\t\r\n\t\t\tCity,\r\n\t\t\tState,\r\n\t\t\tCounty,\r\n\t\t\tZip\t\t\r\n\t        from tblUnderwritingLocations with (nolock)\r\n\t        where QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
  }

  private bool LocationsVisible
  {
    get
    {
      if (this._locsVisible == null)
      {
        if (SystemSettings.KeyExists("AlwaysViewUnderwritingLocations") & SystemSettings.GetBoolSetting("AlwaysViewUnderwritingLocations"))
          this._locsVisible = (object) true;
        if (this._locsVisible == null)
        {
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT RaterID FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
          {
            (object) "@QuoteGuid",
            (object) this._quoteGuid
          });
          try
          {
            foreach (DataRow row in dataTable.Rows)
            {
              if (row[0] != DBNull.Value)
              {
                IRater rater = RaterFactory.GetRater(Conversions.ToInteger(row[0]));
                if (rater != null && rater.SupportsUnderwritingLocations)
                {
                  this._locsVisible = (object) true;
                  break;
                }
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
        if (this._locsVisible == null)
          this._locsVisible = (object) false;
      }
      return (bool) this._locsVisible;
    }
  }

  private bool UnderwritingLocationsVisible()
  {
    bool flag;
    if (SystemSettings.KeyExists("AlwaysViewUnderwritingLocations") & SystemSettings.GetBoolSetting("AlwaysViewUnderwritingLocations"))
    {
      flag = true;
    }
    else
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT RaterID FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          if (row[0] != DBNull.Value)
          {
            IRater rater = RaterFactory.GetRater(Conversions.ToInteger(row[0]));
            if (rater != null && rater.SupportsUnderwritingLocations)
            {
              flag = true;
              goto label_12;
            }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      flag = false;
    }
label_12:
    return flag;
  }

  private void btnContinue_Click(object sender, EventArgs e)
  {
    if (((TextEditorControlBase) this.txtControlNo).Text.Replace(" ", string.Empty).Length == 0)
    {
      int num1 = (int) MessageBox.Show("Please enter a valid control # to continue", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!int.TryParse(((TextEditorControlBase) this.txtControlNo).Text, out int _))
    {
      int num2 = (int) MessageBox.Show($"Control # {((TextEditorControlBase) this.txtControlNo).Text} is not a valid #", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 QuoteGuid from tblquotes with (nolock) where controlNo = @CN order by QuoteID DESC", new object[2]
      {
        (object) "@CN",
        (object) ((TextEditorControlBase) this.txtControlNo).Text
      }));
      if (objectValue == null || objectValue == DBNull.Value)
      {
        int num3 = (int) MessageBox.Show($"Control # {((TextEditorControlBase) this.txtControlNo).Text} does not exist", "Control # Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (!this.LocationsVisible && DialogResult.Yes != MessageBox.Show("The rater(s) on this policy does not support viewing of underwriting locations.\n\nContinue copying process?", "Continue and Copy Locations?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
          return;
        if (((UltraToggleEditorBase) this.chkCopyExposures).Checked && !this._hasOptions)
        {
          int num4 = (int) MessageBox.Show("Cannot copy over exposures because there are no options on the policy to associate them to", "Cannot Copy Exposures - No Options Exist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (((UltraToggleEditorBase) this.chkCopyExposures).Checked && this._optionID == int.MinValue)
        {
          int num5 = (int) MessageBox.Show("In order to copy over exposures, you must select an option to continue.", "Cannot Copy Exposures - No Options Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          string str = string.Empty;
          foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
          {
            if (row.Cells["CopyLocation"].Value != null && row.Cells["CopyLocation"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["CopyLocation"].Value))
              str = $"{str}{row.Cells["LocationID"].Value.ToString()},";
          }
          if (str.Equals(string.Empty))
          {
            int num6 = (int) MessageBox.Show("Please select a location in the grid to continue.", "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
          {
            object optionId = (object) DBNull.Value;
            if (this._optionID != int.MinValue)
              optionId = (object) this._optionID;
            try
            {
              this.Cursor = MgaCursors.WaitCursor;
              DefaultDatabase.ExecuteNonQuery("spCopyUnderwritingLocations", new object[12]
              {
                (object) "@CurrentQuoteGuid",
                (object) this._quoteGuid,
                (object) "@DestControlNo",
                (object) ((TextEditorControlBase) this.txtControlNo).Text,
                (object) "@LocationIdString",
                (object) str,
                (object) "@UserGuid",
                (object) CurrentUser.Instance.UserGUID,
                (object) "@CopyExposures",
                (object) ((UltraToggleEditorBase) this.chkCopyExposures).Checked,
                (object) "@QuoteOptionID",
                optionId
              });
            }
            finally
            {
              this.Cursor = MgaCursors.Default;
            }
            Quote quote1 = new Quote(this._quoteGuid);
            CurrentUser.Instance.LogAction($"Copy underwriting Locations from control # {quote1.ControlNo} to {((TextEditorControlBase) this.txtControlNo).Text} ", this._quoteGuid);
            Quote quote2 = Quote.FromControlNo(Conversions.ToInteger(((TextEditorControlBase) this.txtControlNo).Text));
            CurrentUser.Instance.LogAction($"Copy underwriting Locations from control # {quote1.ControlNo} to {((TextEditorControlBase) this.txtControlNo).Text} ", quote2.QuoteGuid);
            int num7 = (int) MessageBox.Show("Locations copied over successfully.", "Locations Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
          }
        }
      }
    }
  }

  private void lnkSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopy(true);
  }

  private void lnkDeleteSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopy(false);
  }

  private void SetCopy(bool value)
  {
    try
    {
      foreach (copyLocatons.tblUnderwritingLocationsRow row in this.ds.tblUnderwritingLocations.Rows)
        row.CopyLocation = value;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ug).UpdateData();
  }

  private void MgaButton1_Click(object sender, EventArgs e)
  {
    if (((TextEditorControlBase) this.txtControlNo).Text.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("Please enter control # to continue.", "No Control # Entered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      ((TextEditorControlBase) this.txtOptionID).Text = string.Empty;
      this._optionID = int.MinValue;
      using (Form form = FormSettings.ShowFormDialog(typeof (FormOptionsDisplay), (object) Conversions.ToInteger(((TextEditorControlBase) this.txtControlNo).Text)))
      {
        this._optionID = ((FormOptionsDisplay) form).QuoteOption;
        if (this._optionID == int.MinValue)
          return;
        ((TextEditorControlBase) this.txtOptionID).Text = this._optionID.ToString();
      }
    }
  }
}
