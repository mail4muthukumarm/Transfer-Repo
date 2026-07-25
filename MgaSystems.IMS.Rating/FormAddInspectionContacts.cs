// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormAddInspectionContacts
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common.Settings;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormAddInspectionContacts : Form
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private readonly Guid _currentInsuredGuid;
  private bool _clickOK;

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
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InsuredGUID");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.dgContacts = new UltraGrid();
    this.ds = new dsAddInspectionContact();
    this.chkShowPolicyContacts = new CheckBox();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.dgContacts).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnOk).DialogResult = DialogResult.OK;
    ((Control) this.btnOk).Location = new Point(417, 582);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(68, 23);
    ((Control) this.btnOk).TabIndex = 6;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(512 /*0x0200*/, 582);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(68, 23);
    ((Control) this.btnCancel).TabIndex = 7;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.dgContacts).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgContacts).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgContacts).DataMember = "dt";
    ((UltraGridBase) this.dgContacts).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "First";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 212;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Last";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 218;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 117;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 152;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dgContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgContacts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgContacts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgContacts).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgContacts).Location = new Point(12, 12);
    ((Control) this.dgContacts).Name = "dgContacts";
    ((Control) this.dgContacts).Size = new Size(568, 553);
    ((Control) this.dgContacts).TabIndex = 2;
    ((UltraControlBase) this.dgContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgContacts).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAddInspectionContact";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.chkShowPolicyContacts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.chkShowPolicyContacts.AutoSize = true;
    this.chkShowPolicyContacts.Location = new Point(12, 588);
    this.chkShowPolicyContacts.Name = "chkShowPolicyContacts";
    this.chkShowPolicyContacts.Size = new Size(159, 17);
    this.chkShowPolicyContacts.TabIndex = 8;
    this.chkShowPolicyContacts.Text = "Only show insured contacts ";
    this.chkShowPolicyContacts.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(592, 617);
    this.Controls.Add((Control) this.chkShowPolicyContacts);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.dgContacts);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAddInspectionContacts);
    this.Text = "Available Insured Contacts";
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.dgContacts).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("dgContacts")]
  protected virtual UltraGrid dgContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAddInspectionContact ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual CheckBox chkShowPolicyContacts
  {
    get => this._chkShowPolicyContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkShowPolicyContacts_CheckedChanged);
      CheckBox showPolicyContacts1 = this._chkShowPolicyContacts;
      if (showPolicyContacts1 != null)
        showPolicyContacts1.CheckedChanged -= eventHandler;
      this._chkShowPolicyContacts = value;
      CheckBox showPolicyContacts2 = this._chkShowPolicyContacts;
      if (showPolicyContacts2 == null)
        return;
      showPolicyContacts2.CheckedChanged += eventHandler;
    }
  }

  public FormAddInspectionContacts(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormAddInspectionContacts_Load);
    this._clickOK = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    Quote quote = new Quote(quoteGuid);
    this._currentInsuredGuid = quote.SubmissionGroup.InsuredGuid;
    string str = quote.InsuredPolicyName;
    if (str.Length > 100)
      str = str.Substring(0, 99);
    this.chkShowPolicyContacts.Text = $"{this.chkShowPolicyContacts.Text} for [{str}]";
  }

  private void FormAddInspectionContacts_Load(object sender, EventArgs e)
  {
    this.chkShowPolicyContacts.Visible = !SystemSettings.GetSetting<bool>("UnderwritingLocations.LimitInspectionContactsByInsured");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dt"
    }, "GetAdditionalInspectionContacts", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid,
      (object) "@InsuredGuid",
      (object) this._currentInsuredGuid
    });
  }

  public string SelectedFirstName
  {
    get
    {
      return ((UltraGridBase) this.dgContacts).ActiveRow != null ? ((UltraGridBase) this.dgContacts).ActiveRow.Cells["FName"].Value.ToString() : string.Empty;
    }
  }

  public string SelectedLastName
  {
    get
    {
      return ((UltraGridBase) this.dgContacts).ActiveRow != null ? ((UltraGridBase) this.dgContacts).ActiveRow.Cells["LName"].Value.ToString() : string.Empty;
    }
  }

  public string SelectedPhone
  {
    get
    {
      return ((UltraGridBase) this.dgContacts).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgContacts).ActiveRow.Cells["Phone"].Value)) ? string.Empty : ((UltraGridBase) this.dgContacts).ActiveRow.Cells["Phone"].Value.ToString();
    }
  }

  public string SelectedEmail
  {
    get
    {
      return ((UltraGridBase) this.dgContacts).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgContacts).ActiveRow.Cells["Email"].Value)) ? string.Empty : ((UltraGridBase) this.dgContacts).ActiveRow.Cells["Email"].Value.ToString();
    }
  }

  public bool ClickOK => this._clickOK;

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._clickOK = false;
    this.Close();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this._clickOK = true;
    this.Close();
  }

  private void chkShowPolicyContacts_CheckedChanged(object sender, EventArgs e)
  {
    if (this.chkShowPolicyContacts.Checked)
      this.ShowPolicyInsuredContacts(true);
    else
      this.ShowPolicyInsuredContacts(false);
  }

  private void ShowPolicyInsuredContacts(bool showPolContacts)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgContacts).Rows)
    {
      row.Hidden = false;
      if (showPolContacts && !((Guid) row.Cells["InsuredGUID"].Value).Equals(this._currentInsuredGuid))
        row.Hidden = true;
    }
  }
}
