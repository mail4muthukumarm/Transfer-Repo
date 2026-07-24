// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmPrintBulkEnvelopes
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.IMS.Forms.Envelopes;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class frmPrintBulkEnvelopes : Form
{
  private IContainer components;
  private Envelope currentEnvelope;
  private EnvelopeLayout EnvelopePreview;

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
    UltraGridBand ultraGridBand = new UltraGridBand("Contacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ContactGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ContactLocationGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LocationType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Disabled");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Extension");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Cell");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Contact Type");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Select", 0);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    this.dgContacts = new UltraGrid();
    this.btnBulkPrint = new Button();
    this.btnPrintOptions = new Button();
    this.btnCancel = new Button();
    this.rtbReturn = new RichTextBox();
    this.chkReturnAddress = new MGACheckBox();
    this.Label1 = new Label();
    this.Panel1 = new Panel();
    this.lnkUnSelectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    ((ISupportInitialize) this.dgContacts).BeginInit();
    ((ISupportInitialize) this.chkReturnAddress).BeginInit();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    ((SpecialBoxBase) ((UltraGridBase) this.dgContacts).DisplayLayout.AddNewBox).Prompt = " ";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Contact";
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 278;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Location";
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 296;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 103;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 65;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 24;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 31 /*0x1F*/;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 31 /*0x1F*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 55;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 55;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 13;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 62;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 62;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 15;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 62;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 62;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.Header.VisiblePosition = 17;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 62;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.DataType = typeof (bool);
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Width = 85;
    ultraGridBand.Columns.AddRange(new object[18]
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
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgContacts).Dock = DockStyle.Left;
    ((Control) this.dgContacts).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgContacts).Location = new Point(0, 0);
    ((Control) this.dgContacts).Name = "dgContacts";
    ((Control) this.dgContacts).Size = new Size(365, 407);
    ((Control) this.dgContacts).TabIndex = 1;
    ((UltraControlBase) this.dgContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.btnBulkPrint.Location = new Point(446, 46);
    this.btnBulkPrint.Name = "btnBulkPrint";
    this.btnBulkPrint.Size = new Size(122, 23);
    this.btnBulkPrint.TabIndex = 4;
    this.btnBulkPrint.Text = "Bulk Print Envelopes";
    this.btnBulkPrint.UseVisualStyleBackColor = true;
    this.btnPrintOptions.Location = new Point(446, 75);
    this.btnPrintOptions.Name = "btnPrintOptions";
    this.btnPrintOptions.Size = new Size(122, 23);
    this.btnPrintOptions.TabIndex = 5;
    this.btnPrintOptions.Text = " Print Options";
    this.btnPrintOptions.UseVisualStyleBackColor = true;
    this.btnCancel.Location = new Point(446, 104);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(122, 23);
    this.btnCancel.TabIndex = 6;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.rtbReturn.Location = new Point(371, 212);
    this.rtbReturn.Name = "rtbReturn";
    this.rtbReturn.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
    this.rtbReturn.Size = new Size(278, 104);
    this.rtbReturn.TabIndex = 8;
    this.rtbReturn.Text = "";
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkReturnAddress).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkReturnAddress).Checked = true;
    ((UltraToggleEditorBase) this.chkReturnAddress).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkReturnAddress).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkReturnAddress).Location = new Point(371, 184);
    ((Control) this.chkReturnAddress).Name = "chkReturnAddress";
    ((Control) this.chkReturnAddress).Size = new Size(149, 32 /*0x20*/);
    ((Control) this.chkReturnAddress).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkReturnAddress).Text = "Return address:";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(112 /*0x70*/, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(12, 13);
    this.Label1.TabIndex = 9;
    this.Label1.Text = "/";
    this.Panel1.Controls.Add((Control) this.lnkUnSelectAll);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.lnkSelectAll);
    this.Panel1.Location = new Point(0, 378);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(661, 30);
    this.Panel1.TabIndex = 10;
    this.lnkUnSelectAll.AutoSize = true;
    this.lnkUnSelectAll.Location = new Point(130, 9);
    this.lnkUnSelectAll.Name = "lnkUnSelectAll";
    this.lnkUnSelectAll.Size = new Size(108, 13);
    this.lnkUnSelectAll.TabIndex = 5;
    this.lnkUnSelectAll.TabStop = true;
    this.lnkUnSelectAll.Text = "Unselect All Contacts";
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 9);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(96 /*0x60*/, 13);
    this.lnkSelectAll.TabIndex = 4;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Contacts";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(661, 407);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.rtbReturn);
    this.Controls.Add((Control) this.chkReturnAddress);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnPrintOptions);
    this.Controls.Add((Control) this.btnBulkPrint);
    this.Controls.Add((Control) this.dgContacts);
    this.Name = nameof (frmPrintBulkEnvelopes);
    this.Text = nameof (frmPrintBulkEnvelopes);
    ((ISupportInitialize) this.dgContacts).EndInit();
    ((ISupportInitialize) this.chkReturnAddress).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dgContacts")]
  private virtual UltraGrid dgContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnBulkPrint
  {
    get => this._btnBulkPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBulkPrint_Click);
      Button btnBulkPrint1 = this._btnBulkPrint;
      if (btnBulkPrint1 != null)
        btnBulkPrint1.Click -= eventHandler;
      this._btnBulkPrint = value;
      Button btnBulkPrint2 = this._btnBulkPrint;
      if (btnBulkPrint2 == null)
        return;
      btnBulkPrint2.Click += eventHandler;
    }
  }

  internal virtual Button btnPrintOptions
  {
    get => this._btnPrintOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintOptions_Click);
      Button btnPrintOptions1 = this._btnPrintOptions;
      if (btnPrintOptions1 != null)
        btnPrintOptions1.Click -= eventHandler;
      this._btnPrintOptions = value;
      Button btnPrintOptions2 = this._btnPrintOptions;
      if (btnPrintOptions2 == null)
        return;
      btnPrintOptions2.Click += eventHandler;
    }
  }

  internal virtual Button btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      Button btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        btnCancel1.Click -= eventHandler;
      this._btnCancel = value;
      Button btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      btnCancel2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("rtbReturn")]
  private virtual RichTextBox rtbReturn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkReturnAddress
  {
    get => this._chkReturnAddress;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkReturnAddress_CheckedChanged);
      MGACheckBox chkReturnAddress1 = this._chkReturnAddress;
      if (chkReturnAddress1 != null)
        ((UltraToggleEditorBase) chkReturnAddress1).CheckedChanged -= eventHandler;
      this._chkReturnAddress = value;
      MGACheckBox chkReturnAddress2 = this._chkReturnAddress;
      if (chkReturnAddress2 == null)
        return;
      ((UltraToggleEditorBase) chkReturnAddress2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkUnSelectAll
  {
    get => this._lnkUnSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUnSelectAll_LinkClicked_1);
      LinkLabel lnkUnSelectAll1 = this._lnkUnSelectAll;
      if (lnkUnSelectAll1 != null)
        lnkUnSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkUnSelectAll = value;
      LinkLabel lnkUnSelectAll2 = this._lnkUnSelectAll;
      if (lnkUnSelectAll2 == null)
        return;
      lnkUnSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked_1);
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

  public frmPrintBulkEnvelopes(object dv)
  {
    this.Load += new EventHandler(this.frmPrintBulkEnvelopes_Load);
    this.currentEnvelope = new Envelope();
    this.InitializeComponent();
    ((UltraGridBase) this.dgContacts).DataSource = RuntimeHelpers.GetObjectValue(dv);
  }

  public frmPrintBulkEnvelopes(string ToAddress, string FromAddress)
  {
    this.Load += new EventHandler(this.frmPrintBulkEnvelopes_Load);
    this.currentEnvelope = new Envelope();
    this.InitializeComponent();
    this.currentEnvelope = new Envelope();
    this.currentEnvelope.DeliveryAddress.Address = ToAddress;
    this.currentEnvelope.ReturnAddress.Address = FromAddress;
  }

  public frmPrintBulkEnvelopes(Envelope env)
  {
    this.Load += new EventHandler(this.frmPrintBulkEnvelopes_Load);
    this.currentEnvelope = new Envelope();
    this.InitializeComponent();
    this.currentEnvelope = env;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void chkReturnAddress_CheckedChanged(object sender, EventArgs e)
  {
    this.rtbReturn.Enabled = ((UltraToggleEditorBase) this.chkReturnAddress).Checked;
  }

  private void btnPrintOptions_Click(object sender, EventArgs e)
  {
    frmPrintEnvelope_EnvelopesOptions envelopesOptions = new frmPrintEnvelope_EnvelopesOptions(this.currentEnvelope);
    if (envelopesOptions.ShowDialog() == DialogResult.OK)
    {
      this.currentEnvelope = envelopesOptions.NewEnvelope.Clone();
      this.UpdateDeliveryAndReturnAddressFont();
    }
    envelopesOptions.Dispose();
  }

  private void btnBulkPrint_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgContacts).Rows)
    {
      if (Conversions.ToBoolean(row.Cells["Select"].Value.ToString()))
      {
        object obj = row.Cells["ContactGuid"].Value;
        this.currentEnvelope.DeliveryAddress.Address = this.GetDeliveryAddress(obj != null ? (Guid) obj : new Guid(), row.Cells["LocationType"].Value.ToString());
        if (((UltraToggleEditorBase) this.chkReturnAddress).CheckState == CheckState.Checked)
          this.currentEnvelope.ReturnAddress.Address = this.rtbReturn.Text;
        this.currentEnvelope.Print();
      }
    }
  }

  private void UpdateDeliveryAndReturnAddressFont()
  {
    this.rtbReturn.Font = this.currentEnvelope.ReturnAddress.Font;
  }

  private string GetDeliveryAddress(Guid ContactGuid, string LocationType)
  {
    return DefaultDatabase.ExecuteScalar("spGetContactInfo", new object[6]
    {
      (object) "@ContactType",
      (object) LocationType,
      (object) "@ContactGuid",
      (object) ContactGuid,
      (object) "@Envelopes",
      (object) 1
    }) as string;
  }

  private void lnkSelectAll_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgContacts).Rows)
      row.Cells["Select"].SetValue((object) true, false);
  }

  private void lnkUnSelectAll_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgContacts).Rows)
      row.Cells["Select"].SetValue((object) false, false);
  }

  private void frmPrintBulkEnvelopes_Load(object sender, EventArgs e)
  {
    this.Text = "Bulk Envelope Printing";
  }
}
