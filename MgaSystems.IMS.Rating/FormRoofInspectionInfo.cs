// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormRoofInspectionInfo
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinMaskedEdit;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormRoofInspectionInfo : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private Guid _locationGuid;

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
    Appearance appearance6 = new Appearance();
    this.chkRoofPhoto = new MGACheckBox();
    this.chkRoofInspect = new MGACheckBox();
    this.txtRoofComments = new MGATextBox();
    this.txtRoofInspectionContactPhone = new MGAMaskedEdit();
    this.Label26 = new Label();
    this.txtRoofInspectionContact = new MGATextBox();
    this.Label25 = new Label();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.chkRoofPhoto).BeginInit();
    ((ISupportInitialize) this.chkRoofInspect).BeginInit();
    ((ISupportInitialize) this.txtRoofComments).BeginInit();
    ((ISupportInitialize) this.txtRoofInspectionContactPhone).BeginInit();
    ((ISupportInitialize) this.txtRoofInspectionContact).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRoofPhoto).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkRoofPhoto).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoofPhoto).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoofPhoto).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRoofPhoto).Location = new Point(193, 14);
    this.chkRoofPhoto.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkRoofPhoto).Name = "chkRoofPhoto";
    ((Control) this.chkRoofPhoto).Size = new Size(99, 20);
    ((Control) this.chkRoofPhoto).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkRoofPhoto).Text = "Photo";
    ((UltraControlBase) this.chkRoofPhoto).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRoofPhoto).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRoofInspect).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkRoofInspect).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoofInspect).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoofInspect).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRoofInspect).Location = new Point(9, 12);
    this.chkRoofInspect.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkRoofInspect).Name = "chkRoofInspect";
    ((Control) this.chkRoofInspect).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.chkRoofInspect).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkRoofInspect).Text = "Inspection Required";
    ((UltraControlBase) this.chkRoofInspect).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRoofInspect).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRoofComments).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtRoofComments).BackColor = Color.White;
    ((Control) this.txtRoofComments).Location = new Point(9, 128 /*0x80*/);
    ((TextEditorControlBase) this.txtRoofComments).MaxLength = 2000;
    this.txtRoofComments.MGAStyle = MGAStyles.Blue;
    this.txtRoofComments.Multiline = true;
    ((Control) this.txtRoofComments).Name = "txtRoofComments";
    ((Control) this.txtRoofComments).Size = new Size(324, 140);
    ((Control) this.txtRoofComments).TabIndex = 4;
    ((UltraControlBase) this.txtRoofComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRoofComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtRoofInspectionContactPhone.Appearance = (AppearanceBase) appearance4;
    this.txtRoofInspectionContactPhone.EditAs = (EditAsType) 1;
    this.txtRoofInspectionContactPhone.InputMask = "###-###-####";
    ((Control) this.txtRoofInspectionContactPhone).Location = new Point(111, 89);
    this.txtRoofInspectionContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtRoofInspectionContactPhone).Name = "txtRoofInspectionContactPhone";
    ((Control) this.txtRoofInspectionContactPhone).Size = new Size(89, 20);
    ((Control) this.txtRoofInspectionContactPhone).TabIndex = 3;
    this.txtRoofInspectionContactPhone.Text = "--";
    ((UltraControlBase) this.txtRoofInspectionContactPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRoofInspectionContactPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(12, 93);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(81, 13);
    this.Label26.TabIndex = 15;
    this.Label26.Text = "Contact Phone:";
    this.Label26.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRoofInspectionContact).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtRoofInspectionContact).BackColor = Color.White;
    ((Control) this.txtRoofInspectionContact).Location = new Point(111, 55);
    ((TextEditorControlBase) this.txtRoofInspectionContact).MaxLength = 100;
    this.txtRoofInspectionContact.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtRoofInspectionContact).Name = "txtRoofInspectionContact";
    ((Control) this.txtRoofInspectionContact).Size = new Size(222, 19);
    ((Control) this.txtRoofInspectionContact).TabIndex = 2;
    ((UltraControlBase) this.txtRoofInspectionContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRoofInspectionContact).UseOsThemes = (DefaultableBoolean) 2;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(6, 58);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(99, 13);
    this.Label25.TabIndex = 14;
    this.Label25.Text = "Inspection Contact:";
    this.Label25.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnSave).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(293, 297);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 5;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.AliceBlue;
    this.ClientSize = new Size(345, 349);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtRoofInspectionContactPhone);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.txtRoofInspectionContact);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.txtRoofComments);
    this.Controls.Add((Control) this.chkRoofPhoto);
    this.Controls.Add((Control) this.chkRoofInspect);
    this.Name = nameof (FormRoofInspectionInfo);
    this.Text = "Roof Inspection Info";
    ((ISupportInitialize) this.chkRoofPhoto).EndInit();
    ((ISupportInitialize) this.chkRoofInspect).EndInit();
    ((ISupportInitialize) this.txtRoofComments).EndInit();
    ((ISupportInitialize) this.txtRoofInspectionContactPhone).EndInit();
    ((ISupportInitialize) this.txtRoofInspectionContact).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("chkRoofPhoto")]
  private virtual MGACheckBox chkRoofPhoto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRoofInspect")]
  private virtual MGACheckBox chkRoofInspect { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRoofComments")]
  private virtual MGATextBox txtRoofComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRoofInspectionContactPhone")]
  private virtual MGAMaskedEdit txtRoofInspectionContactPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRoofInspectionContact")]
  protected virtual MGATextBox txtRoofInspectionContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual MGAButton btnSave
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

  public FormRoofInspectionInfo(Guid quoteGuid, Guid locationGuid)
  {
    this.Load += new EventHandler(this.FormRoofInspectionInfo_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._locationGuid = locationGuid;
  }

  private void FormRoofInspectionInfo_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RoofInspectionContact, RoofInspectionContactPhone, RoofInspect, RoofPhoto, RoofComments  FROM tblUnderwritingLocations WHERE LocationGuid = @LG", new object[2]
    {
      (object) "@LG",
      (object) this._locationGuid
    });
    if (row == null)
      return;
    if (!row.IsNull("RoofInspectionContact"))
      ((TextEditorControlBase) this.txtRoofInspectionContact).Text = row.Field<string>("RoofInspectionContact");
    if (!row.IsNull("RoofInspectionContactPhone"))
      this.txtRoofInspectionContactPhone.Text = row.Field<string>("RoofInspectionContactPhone");
    if (!row.IsNull("RoofInspect"))
      ((UltraToggleEditorBase) this.chkRoofInspect).Checked = row.Field<bool>("RoofInspect");
    if (!row.IsNull("RoofPhoto"))
      ((UltraToggleEditorBase) this.chkRoofPhoto).Checked = row.Field<bool>("RoofPhoto");
    if (row.IsNull("RoofComments"))
      return;
    ((TextEditorControlBase) this.txtRoofComments).Text = row.Field<string>("RoofComments");
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteScalar(CommandType.Text, "UPDATE tblUnderwritingLocations SET RoofInspectionContact = @cContact, RoofInspectionContactPhone = @cPhone, RoofInspect = @cInspect,RoofPhoto = @cPhoto, RoofComments = @cComments WHERE LocationGuid = @LG", new object[12]
      {
        (object) "@cContact",
        (object) ((TextEditorControlBase) this.txtRoofInspectionContact).Text,
        (object) "@cPhone",
        (object) this.txtRoofInspectionContactPhone.Text,
        (object) "@cInspect",
        (object) ((UltraToggleEditorBase) this.chkRoofInspect).Checked,
        (object) "@cPhoto",
        (object) ((UltraToggleEditorBase) this.chkRoofPhoto).Checked,
        (object) "@cComments",
        (object) ((TextEditorControlBase) this.txtRoofComments).Text,
        (object) "@LG",
        (object) this._locationGuid
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }
}
