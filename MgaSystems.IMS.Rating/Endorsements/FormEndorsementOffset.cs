// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Endorsements.FormEndorsementOffset
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
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
namespace MGASystems.IMS.Policies.Rating.Endorsements;

[DesignerGenerated]
public class FormEndorsementOffset : Form
{
  private IContainer components;
  private readonly Quote _quote;
  private bool _saved;
  private Guid _quoteOptionGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("Fees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyFeeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("FeeTypeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Payable");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PercentOfChargeCode");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("OriginalQuoteOptionGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("FeeAmount");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AppliesToPaymentID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Taxable");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("RoundToDollar");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ConvertedToManualUserGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("DateFilingDue");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DateAmountDue");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("FullyEarned");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("NewAmount");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ChargeName");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Premiums", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Premium");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("NewAmount");
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("ChargeName");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormEndorsementOffset));
    Appearance appearance26 = new Appearance();
    this.gridFees = new UltraGrid();
    this.ds = new DatasetEndorsementOffset();
    this.gridPremiums = new UltraGrid();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.gridFees).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.gridPremiums).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    ((Control) this.gridFees).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridFees).DataMember = "Fees";
    ((UltraGridBase) this.gridFees).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridFees).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn9.Format = "c";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Current Amount";
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn9.Width = 98;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 15;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn17.Format = "c";
    ((HeaderBase) ultraGridColumn17.Header).Caption = "New Amount";
    ultraGridColumn17.Header.VisiblePosition = 17;
    ultraGridColumn17.Width = 83;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Fee";
    ultraGridColumn18.Header.VisiblePosition = 8;
    ultraGridColumn18.Width = 498;
    ultraGridBand1.Columns.AddRange(new object[18]
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
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFees).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridFees).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridFees).Location = new Point(12, 157);
    ((Control) this.gridFees).Name = "gridFees";
    ((Control) this.gridFees).Size = new Size(681, 139);
    ((Control) this.gridFees).TabIndex = 1;
    ((Control) this.gridFees).Text = "Fees on This Policy";
    ((UltraControlBase) this.gridFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridFees).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "DatasetEndorsementOffset";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.gridPremiums).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridPremiums).DataMember = "Premiums";
    ((UltraGridBase) this.gridPremiums).DataSource = (object) this.ds;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn21.Format = "c";
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Current Amount";
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn21.Width = 98;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn23.Format = "C";
    ((HeaderBase) ultraGridColumn23.Header).Caption = "New Amount";
    ultraGridColumn23.Header.VisiblePosition = 5;
    ultraGridColumn23.Width = 83;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Type";
    ultraGridColumn24.Header.VisiblePosition = 2;
    ultraGridColumn24.Width = 498;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridPremiums).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = Color.LightSteelBlue;
    appearance16.FontData.SizeInPoints = 10f;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.Transparent;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = Color.WhiteSmoke;
    appearance23.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance23;
    appearance24.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridPremiums).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridPremiums).Location = new Point(12, 12);
    ((Control) this.gridPremiums).Name = "gridPremiums";
    ((Control) this.gridPremiums).Size = new Size(681, 139);
    ((Control) this.gridPremiums).TabIndex = 0;
    ((Control) this.gridPremiums).Text = "Premiums on This Policy";
    ((UltraControlBase) this.gridPremiums).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPremiums).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance25.BackColor = Color.FromArgb(248, 248, 248);
    appearance25.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance25.BackGradientStyle = (GradientStyle) 2;
    appearance25.BorderColor = Color.DarkGray;
    appearance25.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    appearance25.ImageHAlign = (HAlign) 1;
    appearance25.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance25;
    ((Control) this.buttonSave).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonSave).Location = new Point(521, 305);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((ControlBase) this.buttonSave).Padding = new Size(5, 0);
    ((Control) this.buttonSave).Size = new Size(83, 40);
    ((Control) this.buttonSave).TabIndex = 2;
    ((ControlBase) this.buttonSave).Text = "Save";
    this.buttonSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance26.BackColor = Color.FromArgb(248, 248, 248);
    appearance26.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance26.BackGradientStyle = (GradientStyle) 2;
    appearance26.BorderColor = Color.DarkGray;
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    appearance26.ImageHAlign = (HAlign) 1;
    appearance26.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance26;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonCancel).Location = new Point(610, 305);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((ControlBase) this.buttonCancel).Padding = new Size(5, 0);
    ((Control) this.buttonCancel).Size = new Size(83, 40);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(705, 357);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.gridFees);
    this.Controls.Add((Control) this.gridPremiums);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormEndorsementOffset);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Endorsement Offset";
    ((ISupportInitialize) this.gridFees).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.gridPremiums).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("gridPremiums")]
  internal virtual UltraGrid gridPremiums { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual DatasetEndorsementOffset ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridFees")]
  internal virtual UltraGrid gridFees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonSave
  {
    get => this._buttonSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSave_Click);
      MGAButton buttonSave1 = this._buttonSave;
      if (buttonSave1 != null)
        ((Control) buttonSave1).Click -= eventHandler;
      this._buttonSave = value;
      MGAButton buttonSave2 = this._buttonSave;
      if (buttonSave2 == null)
        return;
      ((Control) buttonSave2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  public bool Saved => this._saved;

  internal Guid QuoteOptionGuid => this._quoteOptionGuid;

  public FormEndorsementOffset(int controlNo)
  {
    this.InitializeComponent();
    this._quote = Quote.FromControlNo(controlNo);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      this.ds.Premiums.TableName,
      this.ds.Fees.TableName
    }, "dbo.EndorsementOffset", new object[2]
    {
      (object) "@controlNo",
      (object) this._quote.ControlNo
    });
    try
    {
      foreach (DatasetEndorsementOffset.PremiumsRow premium in this.ds.Premiums)
      {
        if (premium.IsNewAmountNull())
          premium.NewAmount = premium.Premium;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (DatasetEndorsementOffset.FeesRow fee in this.ds.Fees)
      {
        if (fee.IsNewAmountNull())
          fee.NewAmount = fee.FeeAmount;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private bool ValidData()
  {
    bool flag;
    try
    {
      foreach (DatasetEndorsementOffset.PremiumsRow premium in this.ds.Premiums)
      {
        if (!Versioned.IsNumeric((object) premium.NewAmount))
        {
          flag = false;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = true;
label_8:
    return flag;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidData())
    {
      int num = (int) MessageBox.Show("Please enter valid new amounts for all premiums and fees.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      try
      {
        Cursor.Current = MgaCursors.WaitCursor;
        Guid guid;
        try
        {
          foreach (DatasetEndorsementOffset.PremiumsRow premium in this.ds.Premiums)
            guid = DefaultDatabase.ExecuteScalar<Guid>("dbo.UpdateEndorsementPremiums", new object[6]
            {
              (object) "@quoteGuid",
              (object) this._quote.QuoteGuid,
              (object) "@chargeCode",
              (object) premium.ChargeCode,
              (object) "@premium",
              (object) Decimal.Subtract(premium.NewAmount, premium.Premium)
            });
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        try
        {
          foreach (DatasetEndorsementOffset.FeesRow fee in this.ds.Fees)
          {
            Decimal.Subtract(fee.NewAmount, fee.FeeAmount);
            guid = DefaultDatabase.ExecuteScalar<Guid>("dbo.UpdateEndorsementFees", new object[6]
            {
              (object) "@quoteGuid",
              (object) this._quote.QuoteGuid,
              (object) "@chargeCode",
              (object) fee.ChargeCode,
              (object) "@feeAmount",
              (object) Decimal.Subtract(fee.NewAmount, fee.FeeAmount)
            });
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (!guid.Equals(Guid.Empty))
        {
          this._saved = true;
          this._quoteOptionGuid = guid;
        }
        this.Close();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }
}
