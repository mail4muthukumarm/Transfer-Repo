// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormChildPolicyNumbersUpdate
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MgaSystems.IMS.Policies.PolicyNumberHistory;
using MGASystems.IMS.Policies.PolicyNumbering;
using MgaSystems.IMS.Policies.PolicyNumberLog;
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
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormChildPolicyNumbersUpdate : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private readonly List<Guid> _compLine;
  private bool _hasSaved;
  private readonly List<PolicyDetailInfo> _childLinePolicyInfo;
  private readonly int _controlNo;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Line");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Rule");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("RuleID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RuleIndex");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Notes");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Go");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CurrentPolicyNumber");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Valid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("QuoteDetailID", 0);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.btnSave = new MGAButton();
    this.ugChildPolicyNumbers = new UltraGrid();
    this.ds = new dsChildPol();
    this.lstCurrentPolicyNumber = new Label();
    this.lblPolicyNumber = new Label();
    this.lnkParentPolicyNums = new LinkLabel();
    this.lnkDeSelect = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSel = new LinkLabel();
    this.lnkSel = new LinkLabel();
    this.btnGenerate = new Button();
    this.chkUpdateOtherTransactions = new CheckBox();
    this.lnkShowPrior = new LinkLabel();
    this.lnkChildPolicyNumberLog = new LinkLabel();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ugChildPolicyNumbers).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(1195, 419);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 8;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugChildPolicyNumbers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugChildPolicyNumbers).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugChildPolicyNumbers).DataMember = "dt";
    ((UltraGridBase) this.ugChildPolicyNumbers).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 4;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 55;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company / Line";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Width = 379;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 177;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 177;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 55;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 59;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Width = 191;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Save";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 10;
    ultraGridColumn8.Width = 77;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Assigned Policy #";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn9.Width = 158;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 62;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 39;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 51;
    ultraGridBand.Columns.AddRange(new object[12]
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
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugChildPolicyNumbers).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugChildPolicyNumbers).Location = new Point(12, 12);
    ((Control) this.ugChildPolicyNumbers).Name = "ugChildPolicyNumbers";
    ((Control) this.ugChildPolicyNumbers).Size = new Size(1223, 369);
    ((Control) this.ugChildPolicyNumbers).TabIndex = 7;
    ((UltraControlBase) this.ugChildPolicyNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugChildPolicyNumbers).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsChildPol";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lstCurrentPolicyNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstCurrentPolicyNumber.AutoSize = true;
    this.lstCurrentPolicyNumber.Location = new Point(13, 395);
    this.lstCurrentPolicyNumber.Name = "lstCurrentPolicyNumber";
    this.lstCurrentPolicyNumber.Size = new Size(94, 13);
    this.lstCurrentPolicyNumber.TabIndex = 9;
    this.lstCurrentPolicyNumber.Text = "Assigned Policy #:";
    this.lblPolicyNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblPolicyNumber.AutoSize = true;
    this.lblPolicyNumber.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblPolicyNumber.Location = new Point(122, 395);
    this.lblPolicyNumber.Name = "lblPolicyNumber";
    this.lblPolicyNumber.Size = new Size(102, 13);
    this.lblPolicyNumber.TabIndex = 10;
    this.lblPolicyNumber.Text = "Current Policy #:";
    this.lnkParentPolicyNums.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkParentPolicyNums.AutoSize = true;
    this.lnkParentPolicyNums.Location = new Point(659, 395);
    this.lnkParentPolicyNums.Name = "lnkParentPolicyNums";
    this.lnkParentPolicyNums.Size = new Size(114, 13);
    this.lnkParentPolicyNums.TabIndex = 12;
    this.lnkParentPolicyNums.TabStop = true;
    this.lnkParentPolicyNums.Text = "Show Parent Policy #s";
    this.lnkDeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelect.AutoSize = true;
    this.lnkDeSelect.Location = new Point(13, 449);
    this.lnkDeSelect.Name = "lnkDeSelect";
    this.lnkDeSelect.Size = new Size(96 /*0x60*/, 13);
    this.lnkDeSelect.TabIndex = 214;
    this.lnkDeSelect.TabStop = true;
    this.lnkDeSelect.Text = "De-Select All Save";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(13, 419);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(97, 13);
    this.lnkSelectAll.TabIndex = 213;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All For Save";
    this.lnkDeSel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSel.AutoSize = true;
    this.lnkDeSel.Location = new Point(156, 449);
    this.lnkDeSel.Name = "lnkDeSel";
    this.lnkDeSel.Size = new Size(131, 13);
    this.lnkDeSel.TabIndex = 216;
    this.lnkDeSel.TabStop = true;
    this.lnkDeSel.Text = "De-Select All To Generate";
    this.lnkSel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSel.AutoSize = true;
    this.lnkSel.Location = new Point(156, 419);
    this.lnkSel.Name = "lnkSel";
    this.lnkSel.Size = new Size(114, 13);
    this.lnkSel.TabIndex = 215;
    this.lnkSel.TabStop = true;
    this.lnkSel.Text = "Select All To Generate";
    this.btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnGenerate.Location = new Point(935, 436);
    this.btnGenerate.Name = "btnGenerate";
    this.btnGenerate.Size = new Size(169, 23);
    this.btnGenerate.TabIndex = 217;
    this.btnGenerate.Text = "Generate \"Select\" Policy #s";
    this.btnGenerate.UseVisualStyleBackColor = true;
    this.chkUpdateOtherTransactions.AutoSize = true;
    this.chkUpdateOtherTransactions.Location = new Point(322, 449);
    this.chkUpdateOtherTransactions.Name = "chkUpdateOtherTransactions";
    this.chkUpdateOtherTransactions.Size = new Size(249, 17);
    this.chkUpdateOtherTransactions.TabIndex = 218;
    this.chkUpdateOtherTransactions.Text = "Copy Generated Policy #s to Prior Transactions";
    this.chkUpdateOtherTransactions.UseVisualStyleBackColor = true;
    this.lnkShowPrior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkShowPrior.AutoSize = true;
    this.lnkShowPrior.Location = new Point(319, 419);
    this.lnkShowPrior.Name = "lnkShowPrior";
    this.lnkShowPrior.Size = new Size(232, 13);
    this.lnkShowPrior.TabIndex = 219;
    this.lnkShowPrior.TabStop = true;
    this.lnkShowPrior.Text = "View Other Policy #s For Current Company/Line";
    this.lnkChildPolicyNumberLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkChildPolicyNumberLog.AutoSize = true;
    this.lnkChildPolicyNumberLog.Location = new Point(659, 419);
    this.lnkChildPolicyNumberLog.Name = "lnkChildPolicyNumberLog";
    this.lnkChildPolicyNumberLog.Size = new Size(97, 13);
    this.lnkChildPolicyNumberLog.TabIndex = 220;
    this.lnkChildPolicyNumberLog.TabStop = true;
    this.lnkChildPolicyNumberLog.Text = "Child Policy #s Log";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1247, 471);
    this.Controls.Add((Control) this.lnkChildPolicyNumberLog);
    this.Controls.Add((Control) this.lnkShowPrior);
    this.Controls.Add((Control) this.chkUpdateOtherTransactions);
    this.Controls.Add((Control) this.btnGenerate);
    this.Controls.Add((Control) this.lnkDeSel);
    this.Controls.Add((Control) this.lnkSel);
    this.Controls.Add((Control) this.lnkDeSelect);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lnkParentPolicyNums);
    this.Controls.Add((Control) this.lblPolicyNumber);
    this.Controls.Add((Control) this.lstCurrentPolicyNumber);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugChildPolicyNumbers);
    this.Name = nameof (FormChildPolicyNumbersUpdate);
    this.Text = "Child Policy #s";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ugChildPolicyNumbers).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraGrid ugChildPolicyNumbers
  {
    get => this._ugChildPolicyNumbers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugChildPolicyNumbers_AfterRowActivate);
      UltraGrid childPolicyNumbers1 = this._ugChildPolicyNumbers;
      if (childPolicyNumbers1 != null)
        childPolicyNumbers1.AfterRowActivate -= eventHandler;
      this._ugChildPolicyNumbers = value;
      UltraGrid childPolicyNumbers2 = this._ugChildPolicyNumbers;
      if (childPolicyNumbers2 == null)
        return;
      childPolicyNumbers2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGAButton btnSave
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
  internal virtual dsChildPol ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstCurrentPolicyNumber")]
  internal virtual Label lstCurrentPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPolicyNumber")]
  internal virtual Label lblPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual LinkLabel lnkSelectAll
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

  internal virtual LinkLabel lnkDeSel
  {
    get => this._lnkDeSel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSel_LinkClicked);
      LinkLabel lnkDeSel1 = this._lnkDeSel;
      if (lnkDeSel1 != null)
        lnkDeSel1.LinkClicked -= clickedEventHandler;
      this._lnkDeSel = value;
      LinkLabel lnkDeSel2 = this._lnkDeSel;
      if (lnkDeSel2 == null)
        return;
      lnkDeSel2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkSel
  {
    get => this._lnkSel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSel_LinkClicked);
      LinkLabel lnkSel1 = this._lnkSel;
      if (lnkSel1 != null)
        lnkSel1.LinkClicked -= clickedEventHandler;
      this._lnkSel = value;
      LinkLabel lnkSel2 = this._lnkSel;
      if (lnkSel2 == null)
        return;
      lnkSel2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkParentPolicyNums
  {
    get => this._lnkParentPolicyNums;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkParentPolicyNums_LinkClicked);
      LinkLabel parentPolicyNums1 = this._lnkParentPolicyNums;
      if (parentPolicyNums1 != null)
        parentPolicyNums1.LinkClicked -= clickedEventHandler;
      this._lnkParentPolicyNums = value;
      LinkLabel parentPolicyNums2 = this._lnkParentPolicyNums;
      if (parentPolicyNums2 == null)
        return;
      parentPolicyNums2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual Button btnGenerate
  {
    get => this._btnGenerate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGenerate_Click);
      Button btnGenerate1 = this._btnGenerate;
      if (btnGenerate1 != null)
        btnGenerate1.Click -= eventHandler;
      this._btnGenerate = value;
      Button btnGenerate2 = this._btnGenerate;
      if (btnGenerate2 == null)
        return;
      btnGenerate2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkUpdateOtherTransactions")]
  private virtual CheckBox chkUpdateOtherTransactions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkShowPrior
  {
    get => this._lnkShowPrior;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowPrior_LinkClicked);
      LinkLabel lnkShowPrior1 = this._lnkShowPrior;
      if (lnkShowPrior1 != null)
        lnkShowPrior1.LinkClicked -= clickedEventHandler;
      this._lnkShowPrior = value;
      LinkLabel lnkShowPrior2 = this._lnkShowPrior;
      if (lnkShowPrior2 == null)
        return;
      lnkShowPrior2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkChildPolicyNumberLog
  {
    get => this._lnkChildPolicyNumberLog;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChildPolicyNumberLog_LinkClicked);
      LinkLabel childPolicyNumberLog1 = this._lnkChildPolicyNumberLog;
      if (childPolicyNumberLog1 != null)
        childPolicyNumberLog1.LinkClicked -= clickedEventHandler;
      this._lnkChildPolicyNumberLog = value;
      LinkLabel childPolicyNumberLog2 = this._lnkChildPolicyNumberLog;
      if (childPolicyNumberLog2 == null)
        return;
      childPolicyNumberLog2.LinkClicked += clickedEventHandler;
    }
  }

  public dsChildPol PolicyNumberDataset => this.ds;

  public bool HasSaved => this._hasSaved;

  public FormChildPolicyNumbersUpdate(Guid quoteGuid, List<Guid> compLine)
  {
    this.Load += new EventHandler(this.FormChildPolicyNumbersUpdate_Load);
    this._hasSaved = false;
    this._childLinePolicyInfo = new List<PolicyDetailInfo>();
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._compLine = compLine;
    this._controlNo = new Quote(quoteGuid).ControlNo;
  }

  private void FormChildPolicyNumbersUpdate_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    try
    {
      this.Cursor = MgaCursors.Working;
      try
      {
        foreach (Guid guid in this._compLine)
        {
          CompanyLine companyLine = new CompanyLine(guid);
          dsChildPol.dtRow row = this.ds.dt.NewdtRow();
          row.CompanyLineGuid = guid;
          row.Line = companyLine.CompanyLineState;
          row.Selected = false;
          row.Go = false;
          row.Valid = false;
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT PolicyNumber FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @quoteGuid AND CompanyLineGuid = @CompanyLineGuid", new object[4]
          {
            (object) "@quoteGuid",
            (object) this._quoteGuid,
            (object) "@CompanyLineGuid",
            (object) guid
          }));
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
            row.CurrentPolicyNumber = objectValue.ToString();
          else
            row.SetCurrentPolicyNumberNull();
          this.ds.dt.AdddtRow(row);
        }
      }
      finally
      {
        List<Guid>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.ds.AcceptChanges();
      int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(QuoteDetailID) FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
      {
        (object) "@QG",
        (object) this._quoteGuid
      });
      this.chkUpdateOtherTransactions.Checked = false;
      this.chkUpdateOtherTransactions.Enabled = num > 1;
      this.lnkShowPrior.Enabled = num > 1;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._hasSaved = false;
    StringBuilder stringBuilder = new StringBuilder();
    try
    {
      foreach (dsChildPol.dtRow row in this.ds.dt.Rows)
      {
        if (!row.IsGoNull() && row.Go && !row.IsValidNull() && row.Valid && !row.IsRuleIDNull())
        {
          string str = "<NULL>";
          if (!row.IsCurrentPolicyNumberNull())
            str = row.CurrentPolicyNumber;
          stringBuilder.AppendLine($"Change policy # from '{str}' to '{row.PolicyNumber}'.  Company/line '{row.Line}'" + Environment.NewLine);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (stringBuilder.Length == 0)
    {
      int num1 = (int) MessageBox.Show("There is no valid policy # update selected", "No Valid Child Policy # Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show($"Do you wish to continue and update the following child policy #s?{Environment.NewLine}{Environment.NewLine}{stringBuilder.ToString()}", "Update Child Policy #", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      object objectValue = RuntimeHelpers.GetObjectValue(new object());
      ObjectFlowControl.CheckForSyncLockOnValueType(objectValue);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(objectValue, ref lockTaken);
        try
        {
          foreach (dsChildPol.dtRow row in this.ds.dt.Rows)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FormChildPolicyNumbersUpdate._Closure\u0024__70\u002D0 closure700 = new FormChildPolicyNumbersUpdate._Closure\u0024__70\u002D0(closure700);
            // ISSUE: reference to a compiler-generated field
            closure700.\u0024VB\u0024Local_row = row;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (!closure700.\u0024VB\u0024Local_row.IsGoNull() && closure700.\u0024VB\u0024Local_row.Go && !closure700.\u0024VB\u0024Local_row.IsValidNull() && closure700.\u0024VB\u0024Local_row.Valid)
            {
              // ISSUE: reference to a compiler-generated field
              if (closure700.\u0024VB\u0024Local_row.IsRuleIDNull())
              {
                // ISSUE: reference to a compiler-generated field
                int num2 = (int) MessageBox.Show($"Cannot continue, policy # rule is not assigned for {closure700.\u0024VB\u0024Local_row.PolicyNumber}", "Rule ID Not Asssigned #", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // ISSUE: reference to a compiler-generated field
                throw new InvalidOperationException($"RuleID is not assigned for {closure700.\u0024VB\u0024Local_row.PolicyNumber}");
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              int num3 = DefaultDatabase.ExecuteScalar<int>("dbo.ChildPolicyNumberUpdate", new object[12]
              {
                (object) "@PolicyNumber",
                (object) closure700.\u0024VB\u0024Local_row.PolicyNumber,
                (object) "@PolicyNumberIndex",
                (object) closure700.\u0024VB\u0024Local_row.RuleIndex,
                (object) "@PolicyNumberRuleID",
                (object) closure700.\u0024VB\u0024Local_row.RuleID,
                (object) "@QuoteGuid",
                (object) this._quoteGuid,
                (object) "@CompanyLineGuid",
                (object) closure700.\u0024VB\u0024Local_row.CompanyLineGuid,
                (object) "@UpdateOtherTransactions",
                (object) this.chkUpdateOtherTransactions.Checked
              });
              if (this._childLinePolicyInfo.Count > 0)
              {
                // ISSUE: reference to a compiler-generated method
                PolicyDetailInfo policyDetailInfo = this._childLinePolicyInfo.Find(new Predicate<PolicyDetailInfo>(closure700._Lambda\u0024__0));
                if (!Utility.IsNull((object) policyDetailInfo) && !Utility.IsNull((object) policyDetailInfo.TableBasedPolicyNumber) && policyDetailInfo.TableBasedPolicyNumber.Length > 0)
                  DefaultDatabase.ExecuteNonQuery("dbo.spPolicyNumberingSetTablePolicyNumberToUsed", new object[8]
                  {
                    (object) "@QuoteGuid",
                    (object) this._quoteGuid,
                    (object) "@PolicyNumberRuleId",
                    (object) policyDetailInfo.PolicyNumberRuleID,
                    (object) "@ActualPolicyNumber",
                    (object) policyDetailInfo.PolicyNumber,
                    (object) "@TableBasedPolicyNumber",
                    (object) policyDetailInfo.TableBasedPolicyNumber
                  });
              }
              string str = "<NULL>";
              // ISSUE: reference to a compiler-generated field
              if (!closure700.\u0024VB\u0024Local_row.IsCurrentPolicyNumberNull())
              {
                // ISSUE: reference to a compiler-generated field
                str = closure700.\u0024VB\u0024Local_row.CurrentPolicyNumber;
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              CurrentUser.Instance.LogAction($"Assign child policy # from '{str}' to '{closure700.\u0024VB\u0024Local_row.PolicyNumber}', index = {closure700.\u0024VB\u0024Local_row.RuleIndex}, ruleID = {closure700.\u0024VB\u0024Local_row.RuleID}, [affected rows = {num3}] to company/line {closure700.\u0024VB\u0024Local_row.Line}", this._quoteGuid);
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        this._hasSaved = true;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(objectValue);
      }
      this.Close();
    }
  }

  private void ugChildPolicyNumbers_AfterRowActivate(object sender, EventArgs e)
  {
    this.lblPolicyNumber.Text = string.Empty;
    if (((UltraGridBase) this.ugChildPolicyNumbers).ActiveRow == null)
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.ugChildPolicyNumbers).ActiveRow;
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(activeRow.Cells["CurrentPolicyNumber"].Value)))
      return;
    this.lblPolicyNumber.Text = activeRow.Cells["CurrentPolicyNumber"].Value.ToString();
  }

  private void lnkParentPolicyNums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormTransSelection formEx = (FormTransSelection) ObjectFactory.Instance.CreateFormEX(typeof (FormTransSelection), new object[1]
    {
      (object) this._quoteGuid
    });
    try
    {
      int num = (int) formEx.ShowDialog();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
  }

  private void SetAll(bool boolValue, string columnName)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugChildPolicyNumbers).Rows)
      row.Cells[columnName].Value = (object) boolValue;
    ((UltraGridBase) this.ugChildPolicyNumbers).UpdateData();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAll(true, "Go");
  }

  private void lnkDeSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAll(false, "Go");
  }

  private void lnkSel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAll(true, "Selected");
  }

  private void lnkDeSel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAll(false, "Selected");
  }

  private void btnGenerate_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.Working;
      this._childLinePolicyInfo.Clear();
      List<string> stringList = new List<string>();
      try
      {
        foreach (dsChildPol.dtRow row in this.ds.dt.Rows)
        {
          row.SetRuleNull();
          row.SetNotesNull();
          row.SetPolicyNumberNull();
          row.SetRuleIDNull();
          row.SetRuleIndexNull();
          if (row.IsSelectedNull() || !row.Selected)
          {
            row.Valid = false;
          }
          else
          {
            CompanyLine companyLine = new CompanyLine(row.CompanyLineGuid);
            bool flag = true;
            row.Valid = true;
            QuoteDetail quoteDetail = new QuoteDetail(this._quoteGuid, row.CompanyLineGuid);
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WITH (NOLOCK) WHERE QuoteGuid = @quoteGuid AND LineGuid = @lineGuid AND CompanyLocationID = @CLID", new object[6]
            {
              (object) "@quoteGuid",
              (object) this._quoteGuid,
              (object) "@lineGuid",
              (object) quoteDetail.CompanyLine.LineGuid,
              (object) "@CLID",
              (object) quoteDetail.CompanyLine.CompanyLocation.CompanyLocationID
            }));
            if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) || Decimal.Compare(Conversions.ToDecimal(objectValue), 0M) == 0)
            {
              row.Valid = false;
              row.Notes = "No Premium on line";
              flag = false;
            }
            try
            {
              if (quoteDetail.IsManualPolicyNumberEntry())
              {
                flag = false;
                row.Valid = false;
                row.Notes = "Set for Manual Entry";
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              row.Valid = false;
              flag = false;
              string str = exception.Message.Length <= 100 ? exception.Message : exception.Message.Substring(0, 99);
              row.Notes = str;
              ProjectData.ClearProjectError();
            }
            PolicyInfo policyInfo = (PolicyInfo) null;
            if (flag)
            {
              try
              {
                policyInfo = Quote.GetNextPolicy(this._quoteGuid, row.CompanyLineGuid);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                row.Valid = false;
                flag = false;
                string str = exception.Message.Length <= 100 ? exception.Message : exception.Message.Substring(0, 99);
                row.Notes = str;
                ProjectData.ClearProjectError();
              }
            }
            if (policyInfo != null)
            {
              try
              {
                row.Rule = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RuleName FROM tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
                {
                  (object) "@ID",
                  (object) policyInfo.PolicyNumberRuleID
                });
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                row.Valid = false;
                flag = false;
                string str = exception.Message.Length <= 100 ? exception.Message : exception.Message.Substring(0, 99);
                row.Notes = str;
                ProjectData.ClearProjectError();
              }
            }
            if (flag)
            {
              if (policyInfo == null || string.IsNullOrEmpty(policyInfo.PolicyNumber))
              {
                row.Notes = "Empty Policy # Generated";
                row.Valid = false;
                flag = false;
              }
              else
              {
                row.PolicyNumber = policyInfo.PolicyNumber;
                row.RuleID = policyInfo.PolicyNumberRuleID;
                row.RuleIndex = policyInfo.PolicyIndex;
              }
            }
            if (flag && row.IsRuleIDNull() && string.IsNullOrWhiteSpace(policyInfo.TableBasedPolicyNumber))
            {
              row.Valid = false;
              flag = false;
              row.Notes = "Empty Policy # Rule Generated";
            }
            if (flag && row.IsRuleIndexNull() && string.IsNullOrWhiteSpace(policyInfo.TableBasedPolicyNumber))
            {
              row.Valid = false;
              flag = false;
              row.Notes = "Empty Policy # Index Generated";
            }
            if (flag && companyLine.EnforceUniquePolicyNumbers && policyInfo != null && !string.IsNullOrEmpty(policyInfo.PolicyNumber))
            {
              if (DefaultDatabase.ExecuteScalar<bool>("spIsPolicyNumberInUseOnQuoteDetail", new object[2]
              {
                (object) "@PolicyNumber",
                (object) policyInfo.PolicyNumber
              }) || stringList.Contains(policyInfo.PolicyNumber))
              {
                row.Notes = $"Policy # {policyInfo.PolicyNumber} is already in use";
                row.Valid = false;
                flag = false;
              }
            }
            if (flag)
            {
              stringList.Add(policyInfo.PolicyNumber);
              this._childLinePolicyInfo.Add(new PolicyDetailInfo()
              {
                CompanyLineguid = row.CompanyLineGuid,
                PolicyNumberRuleID = policyInfo.PolicyNumberRuleID,
                PolicyIndex = policyInfo.PolicyIndex,
                PolicyNumber = policyInfo.PolicyNumber,
                TableBasedPolicyNumber = policyInfo.TableBasedPolicyNumber
              });
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
      this.ds.AcceptChanges();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkShowPrior_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugChildPolicyNumbers).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid to continue.", "No Row Selected on Grid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Form form = ObjectFactory.Instance.CreateForm(typeof (ChildNumberInterface), new object[2]
      {
        (object) this._quoteGuid,
        ((UltraGridBase) this.ugChildPolicyNumbers).ActiveRow.Cells["CompanyLineGuid"].Value
      });
      form.FormBorderStyle = FormBorderStyle.Sizable;
      form.MaximizeBox = true;
      form.Show();
    }
  }

  private void lnkChildPolicyNumberLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Form form = ObjectFactory.Instance.CreateForm(typeof (ChildPolicyNumberLog), new object[1]
    {
      (object) this._controlNo
    });
    form.FormBorderStyle = FormBorderStyle.Sizable;
    form.MaximizeBox = true;
    form.Show();
  }
}
