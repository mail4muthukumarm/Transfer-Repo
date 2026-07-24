// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.CRMEMail_RecipientList
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class CRMEMail_RecipientList : UserControl
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
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CustomerName", 0);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EmailAddress", 1);
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerLocationGUID", 2);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerGuid", 3);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("State", 4);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Qualified", 5);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProducerContactGuid", 6);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Select", 7);
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CRMEMail_RecipientList));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.panelHeader = new Panel();
    this.lblProducerCount = new Label();
    this.PanelContent = new Panel();
    this.Panel1 = new Panel();
    this.Label1 = new Label();
    this.lnkUnselectProducers = new LinkLabel();
    this.lnkSelectProducers = new LinkLabel();
    this.grdEmailAddresses = new UltraGrid();
    this.panelHeader.SuspendLayout();
    this.PanelContent.SuspendLayout();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.grdEmailAddresses).BeginInit();
    this.SuspendLayout();
    this.panelHeader.BackColor = Color.Transparent;
    this.panelHeader.Controls.Add((Control) this.lblProducerCount);
    this.panelHeader.Dock = DockStyle.Top;
    this.panelHeader.Location = new Point(0, 0);
    this.panelHeader.Name = "panelHeader";
    this.panelHeader.Size = new Size(626, 27);
    this.panelHeader.TabIndex = 12;
    this.lblProducerCount.AutoSize = true;
    this.lblProducerCount.Dock = DockStyle.Top;
    this.lblProducerCount.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.lblProducerCount.Location = new Point(0, 0);
    this.lblProducerCount.Name = "lblProducerCount";
    this.lblProducerCount.Size = new Size(11, 14);
    this.lblProducerCount.TabIndex = 0;
    this.lblProducerCount.Text = ".";
    this.PanelContent.Controls.Add((Control) this.Panel1);
    this.PanelContent.Controls.Add((Control) this.grdEmailAddresses);
    this.PanelContent.Dock = DockStyle.Fill;
    this.PanelContent.Location = new Point(0, 27);
    this.PanelContent.Name = "PanelContent";
    this.PanelContent.Size = new Size(626, 590);
    this.PanelContent.TabIndex = 13;
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.lnkUnselectProducers);
    this.Panel1.Controls.Add((Control) this.lnkSelectProducers);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 551);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(626, 39);
    this.Panel1.TabIndex = 13;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(117, 13);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(12, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "/";
    this.lnkUnselectProducers.AutoSize = true;
    this.lnkUnselectProducers.Location = new Point(135, 13);
    this.lnkUnselectProducers.Name = "lnkUnselectProducers";
    this.lnkUnselectProducers.Size = new Size(114, 13);
    this.lnkUnselectProducers.TabIndex = 1;
    this.lnkUnselectProducers.TabStop = true;
    this.lnkUnselectProducers.Text = "Unselect All Producers";
    this.lnkSelectProducers.AutoSize = true;
    this.lnkSelectProducers.Location = new Point(9, 13);
    this.lnkSelectProducers.Name = "lnkSelectProducers";
    this.lnkSelectProducers.Size = new Size(102, 13);
    this.lnkSelectProducers.TabIndex = 0;
    this.lnkSelectProducers.TabStop = true;
    this.lnkSelectProducers.Text = "Select All Producers";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Producer ";
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 147;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Email Address";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 384;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 87;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 125;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 77;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 87;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 87;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellClickAction = (CellClickAction) 1;
    ultraGridColumn8.DataType = typeof (bool);
    ultraGridColumn8.DefaultCellValue = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraGridColumn8.DefaultCellValue"));
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Style = (ColumnStyle) 3;
    ultraGridColumn8.Width = 93;
    ultraGridBand.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.grdEmailAddresses).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grdEmailAddresses).Dock = DockStyle.Fill;
    ((Control) this.grdEmailAddresses).Location = new Point(0, 0);
    ((Control) this.grdEmailAddresses).Name = "grdEmailAddresses";
    ((Control) this.grdEmailAddresses).Size = new Size(626, 590);
    ((Control) this.grdEmailAddresses).TabIndex = 12;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.PanelContent);
    this.Controls.Add((Control) this.panelHeader);
    this.Name = nameof (CRMEMail_RecipientList);
    this.Size = new Size(626, 617);
    this.panelHeader.ResumeLayout(false);
    this.panelHeader.PerformLayout();
    this.PanelContent.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.grdEmailAddresses).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("panelHeader")]
  internal virtual Panel panelHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProducerCount")]
  internal virtual Label lblProducerCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PanelContent")]
  internal virtual Panel PanelContent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grdEmailAddresses")]
  internal virtual UltraGrid grdEmailAddresses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSelectProducers
  {
    get => this._lnkSelectProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectProducers_LinkClicked);
      LinkLabel lnkSelectProducers1 = this._lnkSelectProducers;
      if (lnkSelectProducers1 != null)
        lnkSelectProducers1.LinkClicked -= clickedEventHandler;
      this._lnkSelectProducers = value;
      LinkLabel lnkSelectProducers2 = this._lnkSelectProducers;
      if (lnkSelectProducers2 == null)
        return;
      lnkSelectProducers2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkUnselectProducers
  {
    get => this._lnkUnselectProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUnselectProducers_LinkClicked);
      LinkLabel unselectProducers1 = this._lnkUnselectProducers;
      if (unselectProducers1 != null)
        unselectProducers1.LinkClicked -= clickedEventHandler;
      this._lnkUnselectProducers = value;
      LinkLabel unselectProducers2 = this._lnkUnselectProducers;
      if (unselectProducers2 == null)
        return;
      unselectProducers2.LinkClicked += clickedEventHandler;
    }
  }

  public CRMEMail_RecipientList(DataTable dt)
  {
    this.InitializeComponent();
    ((UltraGridBase) this.grdEmailAddresses).DataSource = (object) dt;
  }

  private void grdEmailAddresses_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
  }

  private void lnkSelectProducers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grdEmailAddresses).Rows)
      row.Cells["Select"].SetValue((object) true, false);
  }

  private void lnkUnselectProducers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grdEmailAddresses).Rows)
      row.Cells["Select"].SetValue((object) false, false);
  }
}
