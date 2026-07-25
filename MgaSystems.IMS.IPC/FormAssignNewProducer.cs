// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormAssignNewProducer
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormAssignNewProducer : Form
{
  private IContainer components;
  private Guid _currentProducerLocationGuid;
  private bool _implementCheckChanged;
  private string _currentProducerLocationName;

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAssignNewProducer));
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationGUID");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Location");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.lblProducers = new Label();
    this.txtSelectedProducer = new MGATextBox();
    this.chkSortBy = new MGACheckBox();
    this.lbl = new Label();
    this.btnSave = new MGAButton();
    this.cboProducers = new MGAComboBox();
    this.ds = new dsBor();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.txtSelectedProducer).BeginInit();
    ((ISupportInitialize) this.chkSortBy).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboProducers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.lblProducers.AutoSize = true;
    this.lblProducers.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblProducers.Location = new Point(21, 7);
    this.lblProducers.Name = "lblProducers";
    this.lblProducers.Size = new Size(161, 13);
    this.lblProducers.TabIndex = 16 /*0x10*/;
    this.lblProducers.Text = "[Current Producer On BOR]";
    this.txtSelectedProducer.AcceptsReturn = true;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSelectedProducer).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtSelectedProducer).BackColor = Color.White;
    ((Control) this.txtSelectedProducer).Location = new Point(22, 110);
    ((TextEditorControlBase) this.txtSelectedProducer).MaxLength = 2000;
    this.txtSelectedProducer.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSelectedProducer).Name = "txtSelectedProducer";
    ((EditorButtonControlBase) this.txtSelectedProducer).ReadOnly = true;
    ((Control) this.txtSelectedProducer).Size = new Size(511 /*0x01FF*/, 19);
    ((Control) this.txtSelectedProducer).TabIndex = 15;
    ((UltraControlBase) this.txtSelectedProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSelectedProducer).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkSortBy).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSortBy).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkSortBy).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSortBy).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSortBy).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSortBy).Location = new Point(22, 176 /*0xB0*/);
    ((Control) this.chkSortBy).Name = "chkSortBy";
    ((Control) this.chkSortBy).Size = new Size(168, 14);
    ((Control) this.chkSortBy).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkSortBy).Text = "Sort By Producer Locations?";
    ((UltraControlBase) this.chkSortBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSortBy).UseOsThemes = (DefaultableBoolean) 2;
    this.lbl.AutoSize = true;
    this.lbl.BackColor = Color.Transparent;
    this.lbl.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lbl.Location = new Point(21, 45);
    this.lbl.Name = "lbl";
    this.lbl.Size = new Size(232, 13);
    this.lbl.TabIndex = 13;
    this.lbl.Text = "Select New Producer Contact / Location:";
    this.lbl.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(499, 162);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 12;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cboProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProducers).DataMember = "tblProducerContacts";
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.ds;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducers.DisplayLayout.Appearance = (AppearanceBase) appearance4;
    this.cboProducers.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 3;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 44;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance5.TextTrimming = (TextTrimming) 1;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 185;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 115;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 280;
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
    appearance6.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance6.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducers.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.White;
    this.cboProducers.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    this.cboProducers.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance8.ForeColor = Color.Black;
    this.cboProducers.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducers.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboProducers).DisplayMember = "ContactName";
    this.cboProducers.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducers).DropDownWidth = 600;
    ((Control) this.cboProducers).Location = new Point(24, 70);
    this.cboProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducers).Name = "cboProducers";
    ((Control) this.cboProducers).Size = new Size(509, 20);
    ((Control) this.cboProducers).TabIndex = 11;
    ((UltraControlBase) this.cboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducers).ValueMember = "ProducerContactID";
    this.ds.DataSetName = "dsBor";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(552, 216);
    this.Controls.Add((Control) this.lblProducers);
    this.Controls.Add((Control) this.txtSelectedProducer);
    this.Controls.Add((Control) this.chkSortBy);
    this.Controls.Add((Control) this.lbl);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.cboProducers);
    this.Name = nameof (FormAssignNewProducer);
    this.Text = nameof (FormAssignNewProducer);
    ((ISupportInitialize) this.txtSelectedProducer).EndInit();
    ((ISupportInitialize) this.chkSortBy).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboProducers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblProducers")]
  internal virtual Label lblProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSelectedProducer")]
  private virtual MGATextBox txtSelectedProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("lbl")]
  private virtual Label lbl { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  protected virtual MGAComboBox cboProducers
  {
    get => this._cboProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboProducers_ValueChanged);
      MGAComboBox cboProducers1 = this._cboProducers;
      if (cboProducers1 != null)
        cboProducers1.ValueChanged -= eventHandler;
      this._cboProducers = value;
      MGAComboBox cboProducers2 = this._cboProducers;
      if (cboProducers2 == null)
        return;
      cboProducers2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsBor ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormAssignNewProducer()
  {
    this.Load += new EventHandler(this.FormAssignNewProducer_Load);
    this._implementCheckChanged = false;
    this._currentProducerLocationName = string.Empty;
    this.InitializeComponent();
  }

  public FormAssignNewProducer(Guid currentProducerLocationGuid)
  {
    this.Load += new EventHandler(this.FormAssignNewProducer_Load);
    this._implementCheckChanged = false;
    this._currentProducerLocationName = string.Empty;
    this.InitializeComponent();
    this._currentProducerLocationGuid = currentProducerLocationGuid;
  }

  private void FormAssignNewProducer_Load(object sender, EventArgs e)
  {
    this._currentProducerLocationName = new ProducerLocation(this._currentProducerLocationGuid).LocationName;
    this.lblProducers.Text = $"{this.lblProducers.Text} - {this._currentProducerLocationName}";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerContacts"
    }, "dbo.spGetBulkBORProducersData", new object[2]
    {
      (object) "@CurrentProducerLocationGuid",
      (object) this._currentProducerLocationGuid
    });
    this._implementCheckChanged = true;
    ((UltraGridBase) this.cboProducers).DataMember = string.Empty;
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.ds.tblProducerContacts;
  }

  private bool IsValidSave()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboProducers, string.Empty);
    if (string.IsNullOrEmpty(this.cboProducers.Text))
    {
      this.err.SetError((Control) this.cboProducers, "Please select a value");
      flag = false;
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidSave())
      return;
    string empty = string.Empty;
    Guid identifier = Guid.Empty;
    dsBor.tblProducerContactsRow producerContactId = this.ds.tblProducerContacts.FindByProducerContactID(Conversions.ToInteger(this.cboProducers.Value));
    if (producerContactId != null)
    {
      identifier = producerContactId.ProducerLocationGUID;
      string location = producerContactId.Location;
    }
    if (identifier.Equals(Guid.Empty))
    {
      this.err.SetError((Control) this.cboProducers, "Empty location data detected.");
    }
    else
    {
      if (MessageBox.Show($"Set renewal BOR on all in-force bound policies with producer \n\n{this._currentProducerLocationName}\n\n with contact \n\n{this.cboProducers.Text}\n\nContinue?", "Set Renewal BOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        DefaultDatabase.ExecuteNonQuery("spMoveProducerRenewalBor", new object[6]
        {
          (object) "@CurrentProducerLocationGuid",
          (object) this._currentProducerLocationGuid,
          (object) "@NewProducerLocationGuid",
          (object) identifier,
          (object) "@NewProducerContactID",
          this.cboProducers.Value
        });
        CurrentUser.Instance.LogAction($"Set BOR (Broker On Renewal). Closed Producer - {this._currentProducerLocationName}. Broker On Renewal - '{((TextEditorControlBase) this.txtSelectedProducer).Text}'");
        CurrentUser.Instance.LogAction($"Set BOR to '{((TextEditorControlBase) this.txtSelectedProducer).Text}'", this._currentProducerLocationGuid);
        CurrentUser.Instance.LogAction($"Current BOR. Closed Producer - '{this._currentProducerLocationName}'", identifier);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.Close();
    }
  }

  private void chkSortBy_CheckedChanged(object sender, EventArgs e)
  {
    if (!this._implementCheckChanged)
      return;
    if (((UltraToggleEditorBase) this.chkSortBy).Checked)
      this.ds.tblProducerContacts.DefaultView.Sort = "Location ASC";
    else
      this.ds.tblProducerContacts.DefaultView.Sort = "ContactName ASC";
    this.ds.AcceptChanges();
  }

  private void cboProducers_ValueChanged(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtSelectedProducer).Text = string.Empty;
    if (this.cboProducers.Value == null || this.cboProducers.Value == DBNull.Value)
      return;
    dsBor.tblProducerContactsRow producerContactId = this.ds.tblProducerContacts.FindByProducerContactID(Conversions.ToInteger(this.cboProducers.Value));
    if (producerContactId == null)
      return;
    ((TextEditorControlBase) this.txtSelectedProducer).Text = producerContactId.Location;
  }
}
