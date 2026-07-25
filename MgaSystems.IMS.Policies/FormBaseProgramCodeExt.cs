// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormBaseProgramCodeExt
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
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
public class FormBaseProgramCodeExt : Form
{
  private readonly int _programID;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing) => base.Dispose(disposing);

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblCompanies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.ds = new dsProgCodeExt();
    this.label6 = new Label();
    this.cboRIBrokerGUID = new MGAComboBox();
    this.lblProgramCode = new Label();
    this.label5 = new Label();
    this.btnSave = new MGAButton();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.numIssuingCarrierFrontFee = new MGANumericEditor();
    this.numIssuingCarrierPart = new MGANumericEditor();
    this.numRIBroker = new MGANumericEditor();
    this.numCedingCommission = new MGANumericEditor();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboRIBrokerGUID).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.numIssuingCarrierFrontFee).BeginInit();
    ((ISupportInitialize) this.numIssuingCarrierPart).BeginInit();
    ((ISupportInitialize) this.numRIBroker).BeginInit();
    ((ISupportInitialize) this.numCedingCommission).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsProgCodeExt";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(16 /*0x10*/, 178);
    this.label6.Name = "label6";
    this.label6.Size = new Size(86, 13);
    this.label6.TabIndex = 46;
    this.label6.Text = "RI Broker Name:";
    ((UltraCombo) this.cboRIBrokerGUID).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRIBrokerGUID).DataMember = "tblCompanies";
    ((UltraGridBase) this.cboRIBrokerGUID).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboRIBrokerGUID.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboRIBrokerGUID.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 273;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 381;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboRIBrokerGUID.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboRIBrokerGUID.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboRIBrokerGUID.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboRIBrokerGUID.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance2.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboRIBrokerGUID.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance2;
    appearance3.BorderColor = Color.White;
    this.cboRIBrokerGUID.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance3;
    this.cboRIBrokerGUID.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance4.ForeColor = Color.Black;
    this.cboRIBrokerGUID.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboRIBrokerGUID.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboRIBrokerGUID).DisplayMember = "CompanyName";
    ((UltraCombo) this.cboRIBrokerGUID).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRIBrokerGUID).DropDownWidth = 400;
    ((Control) this.cboRIBrokerGUID).Location = new Point(19, 205);
    ((MGASimpleComboBox) this.cboRIBrokerGUID).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboRIBrokerGUID).Name = "cboRIBrokerGUID";
    ((Control) this.cboRIBrokerGUID).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.cboRIBrokerGUID).TabIndex = 38;
    ((UltraControlBase) this.cboRIBrokerGUID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRIBrokerGUID).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRIBrokerGUID).ValueMember = "CompanyGUID";
    this.lblProgramCode.AutoSize = true;
    this.lblProgramCode.Location = new Point(156, 16 /*0x10*/);
    this.lblProgramCode.Name = "lblProgramCode";
    this.lblProgramCode.Size = new Size(31 /*0x1F*/, 13);
    this.lblProgramCode.TabIndex = 45;
    this.lblProgramCode.Text = "<<>>";
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label5.Location = new Point(12, 16 /*0x10*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(143, 13);
    this.label5.TabIndex = 44;
    this.label5.Text = "Current Program Code - ";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnSave).Location = new Point(128 /*0x80*/, 247);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 40;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(16 /*0x10*/, 85);
    this.label4.Name = "label4";
    this.label4.Size = new Size(124, 13);
    this.label4.TabIndex = 43;
    this.label4.Text = "Issuing Carrier Front Fee:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(16 /*0x10*/, 116);
    this.label3.Name = "label3";
    this.label3.Size = new Size(98, 13);
    this.label3.TabIndex = 42;
    this.label3.Text = "Issuing Carrier Part:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(16 /*0x10*/, 147);
    this.label2.Name = "label2";
    this.label2.Size = new Size(55, 13);
    this.label2.TabIndex = 41;
    this.label2.Text = "RI Broker:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(16 /*0x10*/, 54);
    this.label1.Name = "label1";
    this.label1.Size = new Size(101, 13);
    this.label1.TabIndex = 39;
    this.label1.Text = "Ceding Commission:";
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numIssuingCarrierFrontFee).Appearance = (AppearanceBase) appearance6;
    ((UltraNumericEditorBase) this.numIssuingCarrierFrontFee).FormatString = "";
    ((Control) this.numIssuingCarrierFrontFee).Location = new Point(201, 82);
    ((UltraNumericEditor) this.numIssuingCarrierFrontFee).MaskInput = "nnn.nnn";
    this.numIssuingCarrierFrontFee.MGAStyle = (MGAStyles) 2;
    ((Control) this.numIssuingCarrierFrontFee).Name = "numIssuingCarrierFrontFee";
    ((UltraNumericEditor) this.numIssuingCarrierFrontFee).Nullable = true;
    ((UltraNumericEditor) this.numIssuingCarrierFrontFee).NumericType = (NumericType) 2;
    ((Control) this.numIssuingCarrierFrontFee).Size = new Size(58, 19);
    ((Control) this.numIssuingCarrierFrontFee).TabIndex = 35;
    ((UltraWinEditorMaskedControlBase) this.numIssuingCarrierFrontFee).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numIssuingCarrierFrontFee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numIssuingCarrierFrontFee).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numIssuingCarrierPart).Appearance = (AppearanceBase) appearance7;
    ((UltraNumericEditorBase) this.numIssuingCarrierPart).FormatString = "";
    ((Control) this.numIssuingCarrierPart).Location = new Point(201, 113);
    ((UltraNumericEditor) this.numIssuingCarrierPart).MaskInput = "nnn.nnn";
    this.numIssuingCarrierPart.MGAStyle = (MGAStyles) 2;
    ((Control) this.numIssuingCarrierPart).Name = "numIssuingCarrierPart";
    ((UltraNumericEditor) this.numIssuingCarrierPart).Nullable = true;
    ((UltraNumericEditor) this.numIssuingCarrierPart).NumericType = (NumericType) 2;
    ((Control) this.numIssuingCarrierPart).Size = new Size(58, 19);
    ((Control) this.numIssuingCarrierPart).TabIndex = 36;
    ((UltraWinEditorMaskedControlBase) this.numIssuingCarrierPart).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numIssuingCarrierPart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numIssuingCarrierPart).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numRIBroker).Appearance = (AppearanceBase) appearance8;
    ((UltraNumericEditorBase) this.numRIBroker).FormatString = "";
    ((Control) this.numRIBroker).Location = new Point(201, 144 /*0x90*/);
    ((UltraNumericEditor) this.numRIBroker).MaskInput = "nnn.nnn";
    this.numRIBroker.MGAStyle = (MGAStyles) 2;
    ((Control) this.numRIBroker).Name = "numRIBroker";
    ((UltraNumericEditor) this.numRIBroker).Nullable = true;
    ((UltraNumericEditor) this.numRIBroker).NumericType = (NumericType) 2;
    ((Control) this.numRIBroker).Size = new Size(58, 19);
    ((Control) this.numRIBroker).TabIndex = 37;
    ((UltraWinEditorMaskedControlBase) this.numRIBroker).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numRIBroker).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numRIBroker).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numCedingCommission).Appearance = (AppearanceBase) appearance9;
    ((UltraNumericEditorBase) this.numCedingCommission).FormatString = "";
    ((Control) this.numCedingCommission).Location = new Point(201, 51);
    ((UltraNumericEditor) this.numCedingCommission).MaskInput = "nnn.nnn";
    this.numCedingCommission.MGAStyle = (MGAStyles) 2;
    ((Control) this.numCedingCommission).Name = "numCedingCommission";
    ((UltraNumericEditor) this.numCedingCommission).Nullable = true;
    ((UltraNumericEditor) this.numCedingCommission).NumericType = (NumericType) 2;
    ((Control) this.numCedingCommission).Size = new Size(58, 19);
    ((Control) this.numCedingCommission).TabIndex = 34;
    ((UltraWinEditorMaskedControlBase) this.numCedingCommission).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numCedingCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numCedingCommission).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(271, 302);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.cboRIBrokerGUID);
    this.Controls.Add((Control) this.lblProgramCode);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.numIssuingCarrierFrontFee);
    this.Controls.Add((Control) this.numIssuingCarrierPart);
    this.Controls.Add((Control) this.numRIBroker);
    this.Controls.Add((Control) this.numCedingCommission);
    this.Name = nameof (FormBaseProgramCodeExt);
    this.Text = "Program Code Ext";
    this.ds.EndInit();
    ((ISupportInitialize) this.cboRIBrokerGUID).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.numIssuingCarrierFrontFee).EndInit();
    ((ISupportInitialize) this.numIssuingCarrierPart).EndInit();
    ((ISupportInitialize) this.numRIBroker).EndInit();
    ((ISupportInitialize) this.numCedingCommission).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProgCodeExt ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label6")]
  private virtual Label label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboRIBrokerGUID")]
  protected virtual MGAComboBox cboRIBrokerGUID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblProgramCode")]
  private virtual Label lblProgramCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label5")]
  private virtual Label label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("label4")]
  private virtual Label label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label3")]
  private virtual Label label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label2")]
  private virtual Label label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numIssuingCarrierFrontFee")]
  protected virtual MGANumericEditor numIssuingCarrierFrontFee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numIssuingCarrierPart")]
  protected virtual MGANumericEditor numIssuingCarrierPart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numRIBroker")]
  protected virtual MGANumericEditor numRIBroker { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numCedingCommission")]
  protected virtual MGANumericEditor numCedingCommission { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormBaseProgramCodeExt(int ProgramID, string ProgramCode)
  {
    this.Load += new EventHandler(this.FormProgramCodeExt_Load);
    this.InitializeComponent();
    this._programID = ProgramID;
    this.lblProgramCode.Text = ProgramCode;
  }

  private void FormProgramCodeExt_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnSave).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    this.ds.tblCompanies.AddtblCompaniesRow(Guid.Empty, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "tblCompanies",
      "tblCompanyProgramCodesExt_Base"
    }, "GetProgramCodeExtData_Base", new object[2]
    {
      (object) "@ProgramID",
      (object) this._programID
    });
    this.AssignValues();
  }

  private void AssignValues()
  {
    if (this.ds.tblCompanyProgramCodesExt_Base.Count == 0)
      return;
    ((UltraNumericEditor) this.numCedingCommission).Value = (object) this.ds.tblCompanyProgramCodesExt_Base[0].CedingCommission;
    ((UltraNumericEditor) this.numIssuingCarrierFrontFee).Value = (object) this.ds.tblCompanyProgramCodesExt_Base[0].IssuingCarrierFrontFee;
    ((UltraNumericEditor) this.numIssuingCarrierPart).Value = (object) this.ds.tblCompanyProgramCodesExt_Base[0].IssuingCarrierPart;
    ((UltraNumericEditor) this.numRIBroker).Value = (object) this.ds.tblCompanyProgramCodesExt_Base[0].RIBroker;
    if (this.ds.tblCompanyProgramCodesExt_Base[0].IsRIBrokerGUIDNull())
      return;
    ((UltraCombo) this.cboRIBrokerGUID).Value = (object) this.ds.tblCompanyProgramCodesExt_Base[0].RIBrokerGUID;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (((UltraNumericEditor) this.numCedingCommission).Value == DBNull.Value || ((UltraNumericEditor) this.numCedingCommission).Value == null)
      ((UltraNumericEditor) this.numCedingCommission).Value = (object) 0;
    if (((UltraNumericEditor) this.numIssuingCarrierFrontFee).Value == DBNull.Value || ((UltraNumericEditor) this.numIssuingCarrierFrontFee).Value == null)
      ((UltraNumericEditor) this.numIssuingCarrierFrontFee).Value = (object) 0;
    if (((UltraNumericEditor) this.numIssuingCarrierPart).Value == DBNull.Value || ((UltraNumericEditor) this.numIssuingCarrierPart).Value == null)
      ((UltraNumericEditor) this.numIssuingCarrierPart).Value = (object) 0;
    if (((UltraNumericEditor) this.numRIBroker).Value == DBNull.Value || ((UltraNumericEditor) this.numRIBroker).Value == null)
      ((UltraNumericEditor) this.numRIBroker).Value = (object) 0;
    object obj = (object) null;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboRIBrokerGUID).Value)) && !((UltraCombo) this.cboRIBrokerGUID).Value.Equals((object) Guid.Empty))
      obj = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboRIBrokerGUID).Value);
    DefaultDatabase.ExecuteNonQuery("SaveProgramCodesExt_Base", new object[12]
    {
      (object) "@ProgramID",
      (object) this._programID,
      (object) "@CedingCommission",
      ((UltraNumericEditor) this.numCedingCommission).Value,
      (object) "@IssuingCarrierFrontFee",
      ((UltraNumericEditor) this.numIssuingCarrierFrontFee).Value,
      (object) "@IssuingCarrierPart",
      ((UltraNumericEditor) this.numIssuingCarrierPart).Value,
      (object) "@RIBroker",
      ((UltraNumericEditor) this.numRIBroker).Value,
      (object) "@RIBrokerGUID",
      obj
    });
    this.Close();
  }
}
