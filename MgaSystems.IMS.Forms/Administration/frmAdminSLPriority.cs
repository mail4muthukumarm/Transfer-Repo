// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminSLPriority
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Administration;

[DesignerGenerated]
public class frmAdminSLPriority : FormBase
{
  private IContainer components;

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
    UltraGridBand ultraGridBand = new UltraGridBand("tblFin_PolicyCharges", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ChargeType");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Tax");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DaysTaxDue");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DaysTaxDueType");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DaysFilingDue");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DaysFilingDueType");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("TaxDueMonthAndDay");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("TaxDueSemiAnnual1");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("TaxDueSemiAnnual2");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("FilingDueSemiAnnual1");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("FilingDueSemiAnnual2");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("SurplusLinesTax");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("SLPriority", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.ds = new dsAdminPolicyCharges();
    this.dgSLPriority = new UltraGrid();
    this.dvCharges = new DataView();
    this.btnMoveDown = new MGAButton();
    this.btnMoveUp = new MGAButton();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgSLPriority).BeginInit();
    this.dvCharges.BeginInit();
    ((ISupportInitialize) this.btnMoveDown).BeginInit();
    ((ISupportInitialize) this.btnMoveUp).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(194, 220);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 7;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(242, 220);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 6;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminPolicyCharges";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgSLPriority).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgSLPriority).DataSource = (object) this.dvCharges;
    appearance3.BackColor = SystemColors.Window;
    appearance3.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Charge Code";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 83;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Name";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[17]
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
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance4.BackColor = SystemColors.ActiveBorder;
    appearance4.BackColor2 = SystemColors.ControlDark;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dgSLPriority).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance4;
    appearance5.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance5;
    ((SpecialBoxBase) ((UltraGridBase) this.dgSLPriority).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.dgSLPriority).DisplayLayout.GroupByBox).Hidden = true;
    appearance6.BackColor = SystemColors.ControlLightLight;
    appearance6.BackColor2 = SystemColors.Control;
    appearance6.BackGradientStyle = (GradientStyle) 3;
    appearance6.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.MaxRowScrollRegions = 1;
    appearance7.BackColor = SystemColors.Window;
    appearance7.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = SystemColors.Highlight;
    appearance8.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance9.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.Silver;
    appearance10.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.CellPadding = 0;
    appearance11.BackColor = SystemColors.Control;
    appearance11.BackColor2 = SystemColors.ControlDark;
    appearance11.BackGradientAlignment = (GradientAlignment) 1;
    appearance11.BackGradientStyle = (GradientStyle) 3;
    appearance11.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 1;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.SelectTypeCol = (SelectType) 1;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.SelectTypeRow = (SelectType) 2;
    appearance14.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dgSLPriority).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.dgSLPriority).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgSLPriority).Location = new Point(13, 13);
    ((Control) this.dgSLPriority).Name = "dgSLPriority";
    ((Control) this.dgSLPriority).Size = new Size(269, 201);
    ((Control) this.dgSLPriority).TabIndex = 8;
    ((Control) this.dgSLPriority).Text = "UltraGrid1";
    this.dvCharges.Sort = "SLPriority, ChargeCode";
    this.dvCharges.Table = (DataTable) this.ds.tblFin_PolicyCharges;
    ((Control) this.btnMoveDown).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance15.BackColor = Color.FromArgb(248, 248, 248);
    appearance15.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.DarkGray;
    appearance15.ImageHAlign = (HAlign) 2;
    appearance15.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnMoveDown).Appearance = (AppearanceBase) appearance15;
    ((Control) this.btnMoveDown).Location = new Point(12, 220);
    ((Control) this.btnMoveDown).Name = "btnMoveDown";
    ((Control) this.btnMoveDown).Size = new Size(40, 40);
    ((Control) this.btnMoveDown).TabIndex = 9;
    this.btnMoveDown.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnMoveUp).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance16.BackColor = Color.FromArgb(248, 248, 248);
    appearance16.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.DarkGray;
    appearance16.ImageHAlign = (HAlign) 2;
    appearance16.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnMoveUp).Appearance = (AppearanceBase) appearance16;
    ((Control) this.btnMoveUp).Location = new Point(58, 220);
    ((Control) this.btnMoveUp).Name = "btnMoveUp";
    ((Control) this.btnMoveUp).Size = new Size(40, 40);
    ((Control) this.btnMoveUp).TabIndex = 9;
    this.btnMoveUp.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(284, 262);
    this.Controls.Add((Control) this.btnMoveUp);
    this.Controls.Add((Control) this.btnMoveDown);
    this.Controls.Add((Control) this.dgSLPriority);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MaximumSize = new Size(500, 400);
    this.MinimumSize = new Size(300, 300);
    this.Name = nameof (frmAdminSLPriority);
    this.Text = " ";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgSLPriority).EndInit();
    this.dvCharges.EndInit();
    ((ISupportInitialize) this.btnMoveDown).EndInit();
    ((ISupportInitialize) this.btnMoveUp).EndInit();
    this.ResumeLayout(false);
  }

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

  private virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAdminPolicyCharges ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnMoveDown
  {
    get => this._btnMoveDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangePriority);
      MGAButton btnMoveDown1 = this._btnMoveDown;
      if (btnMoveDown1 != null)
        ((Control) btnMoveDown1).Click -= eventHandler;
      this._btnMoveDown = value;
      MGAButton btnMoveDown2 = this._btnMoveDown;
      if (btnMoveDown2 == null)
        return;
      ((Control) btnMoveDown2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnMoveUp
  {
    get => this._btnMoveUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangePriority);
      MGAButton btnMoveUp1 = this._btnMoveUp;
      if (btnMoveUp1 != null)
        ((Control) btnMoveUp1).Click -= eventHandler;
      this._btnMoveUp = value;
      MGAButton btnMoveUp2 = this._btnMoveUp;
      if (btnMoveUp2 == null)
        return;
      ((Control) btnMoveUp2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraGrid1")]
  internal virtual UltraGrid UltraGrid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgSLPriority")]
  internal virtual UltraGrid dgSLPriority { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvCharges")]
  internal virtual DataView dvCharges { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public dsAdminPolicyCharges.tblFin_PolicyChargesDataTable SavedCharges
  {
    get => this.ds.tblFin_PolicyCharges;
  }

  public frmAdminSLPriority()
  {
    this.Load += new EventHandler(this.Form_Load);
    this.InitializeComponent();
  }

  public frmAdminSLPriority(
    dsAdminPolicyCharges.tblFin_PolicyChargesDataTable dtFees)
    : this()
  {
    this.ds.tblFin_PolicyCharges.Merge((DataTable) dtFees);
  }

  private virtual BindingManagerBase _bmb
  {
    get => this.__bmb;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.bmb_PositionChanged);
      BindingManagerBase bmb1 = this.__bmb;
      if (bmb1 != null)
        bmb1.PositionChanged -= eventHandler;
      this.__bmb = value;
      BindingManagerBase bmb2 = this.__bmb;
      if (bmb2 == null)
        return;
      bmb2.PositionChanged += eventHandler;
    }
  }

  private void Form_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (this.ds.tblFin_PolicyCharges.Count < 2)
    {
      this.Close();
    }
    else
    {
      ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
      ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
      ((ControlBase) this.btnMoveUp).Appearance.Image = (object) ImageCache.Instance.ArrowUp;
      ((ControlBase) this.btnMoveDown).Appearance.Image = (object) ImageCache.Instance.ArrowDown;
      int num = 0;
      try
      {
        int? nullable;
        OrderedEnumerableRowCollection<dsAdminPolicyCharges.tblFin_PolicyChargesRow> source = this.ds.tblFin_PolicyCharges.OrderBy<dsAdminPolicyCharges.tblFin_PolicyChargesRow, int>((System.Func<dsAdminPolicyCharges.tblFin_PolicyChargesRow, int>) ([SpecialName] (x) => !(nullable = x.Field<int?>("SLPriority")).HasValue ? this.ds.tblFin_PolicyCharges.Count : nullable.GetValueOrDefault()));
        System.Func<dsAdminPolicyCharges.tblFin_PolicyChargesRow, int> keySelector;
        // ISSUE: reference to a compiler-generated field
        if (frmAdminSLPriority._Closure\u0024__.\u0024I43\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          keySelector = frmAdminSLPriority._Closure\u0024__.\u0024I43\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmAdminSLPriority._Closure\u0024__.\u0024I43\u002D1 = keySelector = (System.Func<dsAdminPolicyCharges.tblFin_PolicyChargesRow, int>) ([SpecialName] (x) => x.ChargeCode);
        }
        foreach (dsAdminPolicyCharges.tblFin_PolicyChargesRow policyChargesRow in source.ThenBy<dsAdminPolicyCharges.tblFin_PolicyChargesRow, int>(keySelector).ToList<dsAdminPolicyCharges.tblFin_PolicyChargesRow>())
        {
          policyChargesRow.SLPriority = num;
          ++num;
        }
      }
      finally
      {
        List<dsAdminPolicyCharges.tblFin_PolicyChargesRow>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this._bmb = this.BindingContext[(object) this.dvCharges];
      this._bmb.Position = 0;
    }
  }

  private void bmb_PositionChanged(object obj, EventArgs args)
  {
    ((Control) this.btnMoveUp).Enabled = ((dsAdminPolicyCharges.tblFin_PolicyChargesRow) this.dvCharges[this._bmb.Position].Row).SLPriority > 0;
    ((Control) this.btnMoveDown).Enabled = ((dsAdminPolicyCharges.tblFin_PolicyChargesRow) this.dvCharges[this._bmb.Position].Row).SLPriority < this.ds.tblFin_PolicyCharges.Count - 1;
  }

  private void ChangePriority(object sender, EventArgs e)
  {
    dsAdminPolicyCharges.tblFin_PolicyChargesRow row1 = (dsAdminPolicyCharges.tblFin_PolicyChargesRow) this.dvCharges[this._bmb.Position].Row;
    dsAdminPolicyCharges.tblFin_PolicyChargesRow row2 = (dsAdminPolicyCharges.tblFin_PolicyChargesRow) this.dvCharges[this._bmb.Position + (sender == this.btnMoveDown ? 1 : -1)].Row;
    int slPriority = row1.SLPriority;
    row1.SLPriority = row2.SLPriority;
    row2.SLPriority = slPriority;
    ((UltraGridBase) this.dgSLPriority).Rows.Move(((UltraGridBase) this.dgSLPriority).Rows[row1.SLPriority], row2.SLPriority);
    this.bmb_PositionChanged((object) null, (EventArgs) null);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter();
      DbCommand command = DefaultDatabase.CreateCommand("UPDATE dbo.tblFin_PolicyCharges SET SLPriority = @slPriority WHERE ChargeCode = @chargeCode", DefaultDatabase.CreateDbConnection());
      DbParameterCollectionExtensions.DerivedAdd(command.Parameters, DefaultDatabase.CreateParameter("@slPriority", SqlDbType.Int, 0, "SLPriority"));
      command.Parameters["@slPriority"].SourceVersion = DataRowVersion.Current;
      DbParameterCollectionExtensions.DerivedAdd(command.Parameters, DefaultDatabase.CreateParameter("@chargeCode", SqlDbType.Int, 0, "ChargeCode"));
      command.Parameters["@chargeCode"].SourceVersion = DataRowVersion.Current;
      dataAdapter.UpdateCommand = command;
      DefaultDatabase.DataAdapterUpdate(dataAdapter, (DataTable) this.ds.tblFin_PolicyCharges);
      this.DialogResult = DialogResult.OK;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (MessageBox.Show($"An error occurred while trying to save Surplus Line Tax priorities.\\r\\n{ex.Message}", "Error Saving Priorities", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
        this.btnSave_Click((object) null, (EventArgs) null);
      else
        this.Close();
      ProjectData.ClearProjectError();
    }
  }
}
