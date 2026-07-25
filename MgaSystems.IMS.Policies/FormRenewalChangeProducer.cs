// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormRenewalChangeProducer
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormRenewalChangeProducer : Form
{
  private IContainer components;
  private readonly int _quoteID;
  private bool _implementCheckChanged;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationGUID");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Location");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance6 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRenewalChangeProducer));
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.cboProducers = new MGAComboBox();
    this.ds = new dsBOROnRenewal();
    this.btnSave = new MGAButton();
    this.lbl = new Label();
    this.err = new ErrorProvider(this.components);
    this.chkSortBy = new MGACheckBox();
    this.txtSelectedProducer = new MGATextBox();
    this.lblProducers = new Label();
    ((ISupportInitialize) this.cboProducers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.chkSortBy).BeginInit();
    ((ISupportInitialize) this.txtSelectedProducer).BeginInit();
    this.SuspendLayout();
    ((UltraCombo) this.cboProducers).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboProducers).CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.ds.tblProducerContacts;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducers.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboProducers.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 3;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 44;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance2.TextTrimming = (TextTrimming) 1;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 185;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 298;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 283;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboProducers.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboProducers.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducers.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance3.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducers.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance3;
    appearance4.BorderColor = Color.White;
    this.cboProducers.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    this.cboProducers.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance5.ForeColor = Color.Black;
    this.cboProducers.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducers.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboProducers).DisplayMember = "ContactName";
    ((UltraCombo) this.cboProducers).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducers).DropDownWidth = 600;
    ((Control) this.cboProducers).Location = new Point(15, 78);
    ((MGASimpleComboBox) this.cboProducers).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducers).Name = "cboProducers";
    ((Control) this.cboProducers).Size = new Size(458, 20);
    ((Control) this.cboProducers).TabIndex = 1;
    ((UltraControlBase) this.cboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducers).ValueMember = "ProducerContactID";
    this.ds.DataSetName = "dsBOROnRenewal";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    appearance6.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(433, 136);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 3;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lbl.AutoSize = true;
    this.lbl.BackColor = Color.Transparent;
    this.lbl.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lbl.Location = new Point(12, 53);
    this.lbl.Name = "lbl";
    this.lbl.Size = new Size(232, 13);
    this.lbl.TabIndex = 5;
    this.lbl.Text = "Select New Producer Contact / Location:";
    this.lbl.TextAlign = ContentAlignment.MiddleRight;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.chkSortBy).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSortBy).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkSortBy).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSortBy).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSortBy).Checked = true;
    ((UltraToggleEditorBase) this.chkSortBy).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkSortBy).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSortBy).Location = new Point(15, 150);
    ((Control) this.chkSortBy).Name = "chkSortBy";
    ((Control) this.chkSortBy).Size = new Size(168, 14);
    ((Control) this.chkSortBy).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkSortBy).Text = "Sort By Producer Locations?";
    ((UltraControlBase) this.chkSortBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSortBy).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTextEditor) this.txtSelectedProducer).AcceptsReturn = true;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSelectedProducer).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtSelectedProducer).BackColor = Color.White;
    ((Control) this.txtSelectedProducer).Location = new Point(15, 108);
    ((TextEditorControlBase) this.txtSelectedProducer).MaxLength = 2000;
    this.txtSelectedProducer.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSelectedProducer).Name = "txtSelectedProducer";
    ((EditorButtonControlBase) this.txtSelectedProducer).ReadOnly = true;
    ((Control) this.txtSelectedProducer).Size = new Size(458, 19);
    ((Control) this.txtSelectedProducer).TabIndex = 9;
    ((UltraControlBase) this.txtSelectedProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSelectedProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.lblProducers.AutoSize = true;
    this.lblProducers.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblProducers.Location = new Point(12, 15);
    this.lblProducers.Name = "lblProducers";
    this.lblProducers.Size = new Size(161, 13);
    this.lblProducers.TabIndex = 10;
    this.lblProducers.Text = "[Current Producer On BOR]";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(488, 190);
    this.Controls.Add((Control) this.lblProducers);
    this.Controls.Add((Control) this.txtSelectedProducer);
    this.Controls.Add((Control) this.chkSortBy);
    this.Controls.Add((Control) this.lbl);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.cboProducers);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormRenewalChangeProducer);
    this.Text = "Change Producer On Renewal";
    ((ISupportInitialize) this.cboProducers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.chkSortBy).EndInit();
    ((ISupportInitialize) this.txtSelectedProducer).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAComboBox cboProducers
  {
    get => this._cboProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboProducers_ValueChanged);
      MGAComboBox cboProducers1 = this._cboProducers;
      if (cboProducers1 != null)
        ((UltraCombo) cboProducers1).ValueChanged -= eventHandler;
      this._cboProducers = value;
      MGAComboBox cboProducers2 = this._cboProducers;
      if (cboProducers2 == null)
        return;
      ((UltraCombo) cboProducers2).ValueChanged += eventHandler;
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

  [field: AccessedThroughProperty("lbl")]
  private virtual Label lbl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsBOROnRenewal ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkSortBy
  {
    get => this._chkSortBy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkSortBy_CheckedChanged);
      MGACheckBox chkSortBy1 = this._chkSortBy;
      if (chkSortBy1 != null)
        ((UltraToggleEditorBase) chkSortBy1).CheckedChanged -= eventHandler;
      this._chkSortBy = value;
      MGACheckBox chkSortBy2 = this._chkSortBy;
      if (chkSortBy2 == null)
        return;
      ((UltraToggleEditorBase) chkSortBy2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtSelectedProducer")]
  private virtual MGATextBox txtSelectedProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProducers")]
  internal virtual Label lblProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormRenewalChangeProducer(int quoteID)
  {
    this.Load += new EventHandler(this.FormRenewalChangeProducer_Load);
    this._implementCheckChanged = false;
    this.InitializeComponent();
    this._quoteID = quoteID;
  }

  private void FormRenewalChangeProducer_Load(object sender, EventArgs e)
  {
    object obj = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT NewProducerContactOnBOR FROM tblQuotes2 WHERE QuoteID = @QD", new object[2]
    {
      (object) "@QD",
      (object) this._quoteID
    }));
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerContacts"
    }, "dbo.spGetBORProducers", new object[4]
    {
      (object) "@quoteID",
      (object) this._quoteID,
      (object) "@currentContactID",
      obj
    });
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)))
      obj = (object) -100;
    this.AssignCurrentProducer(Conversions.ToInteger(obj));
    this._implementCheckChanged = true;
  }

  private void AssignCurrentProducer(int currentContactID)
  {
    this.lblProducers.Text = string.Empty;
    if (currentContactID <= 0)
      return;
    dsBOROnRenewal.tblProducerContactsRow producerContactId = this.ds.tblProducerContacts.FindByProducerContactID(currentContactID);
    if (producerContactId == null)
      return;
    this.lblProducers.Text = $"Current BOR Renewal Producer:  [ {producerContactId.Location} ]";
  }

  private bool IsValidSave()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((UltraCombo) this.cboProducers).Text))
    {
      this.err.SetError((Control) this.cboProducers, "Please select a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboProducers, string.Empty);
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidSave())
      return;
    DefaultDatabase.ExecuteNonQuery("dbo.spUpdateBOROnRenewal", new object[4]
    {
      (object) "@quoteID",
      (object) this._quoteID,
      (object) "@producerContactID",
      (object) Conversions.ToInteger(((UltraCombo) this.cboProducers).Value)
    });
    this.AssignCurrentProducer(Conversions.ToInteger(((UltraCombo) this.cboProducers).Value));
    this.LogProducerChange(Conversions.ToInteger(((UltraCombo) this.cboProducers).Value));
    Messaging.SendBroadcastMessage(BroadcastMessages.BORonRenewal, (object) DefaultDatabase.ExecuteFunction<Guid>("dbo.GetQuoteGuidFromQuoteId", new object[2]
    {
      (object) "@quoteID",
      (object) this._quoteID
    }));
    int num = (int) MessageBox.Show("BOR on renewal. Producer updated successfully", "Producer Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void chkSortBy_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._implementCheckChanged)
      return;
    if (((UltraToggleEditorBase) this.chkSortBy).Checked)
      this.ds.tblProducerContacts.DefaultView.Sort = "Location ASC";
    else
      this.ds.tblProducerContacts.DefaultView.Sort = "ContactName ASC";
  }

  private void cboProducers_ValueChanged(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtSelectedProducer).Text = string.Empty;
    if (((UltraCombo) this.cboProducers).Value == null || ((UltraCombo) this.cboProducers).Value == DBNull.Value)
      return;
    dsBOROnRenewal.tblProducerContactsRow producerContactId = this.ds.tblProducerContacts.FindByProducerContactID(Conversions.ToInteger(((UltraCombo) this.cboProducers).Value));
    if (producerContactId == null)
      return;
    ((TextEditorControlBase) this.txtSelectedProducer).Text = producerContactId.Location;
  }

  private void LogProducerChange(int currentContactID)
  {
    if (currentContactID <= 0)
      return;
    dsBOROnRenewal.tblProducerContactsRow producerContactId = this.ds.tblProducerContacts.FindByProducerContactID(currentContactID);
    if (producerContactId == null)
      return;
    Quote quote = new Quote(this._quoteID);
    CurrentUser.Instance.LogAction("BOR Renewal Producer - " + producerContactId.Location, quote.QuoteGuid);
  }
}
