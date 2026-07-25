// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.ProgramCodes.FormProgramCodeExtension
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.ProgramCodes;

public class FormProgramCodeExtension : Form
{
  private int _programID;
  private IContainer components;
  private Label label6;
  protected MGAComboBox cboRIBrokerGUID;
  private Label lblProgramCode;
  private Label label5;
  private MGAButton btnSave;
  private Label label4;
  private Label label3;
  private Label label2;
  private Label label1;
  protected MGANumericEditor numIssuingCarrierFrontFee;
  protected MGANumericEditor numIssuingCarrierPart;
  protected MGANumericEditor numRIBroker;
  protected MGANumericEditor numCedingCommission;
  private dsProgCodeExt ds;

  public FormProgramCodeExtension(int ProgramID, string ProgramCode)
  {
    this.InitializeComponent();
    this._programID = ProgramID;
    this.lblProgramCode.Text = ProgramCode;
  }

  private void FormProgramCodeExtension_Load(object sender, EventArgs e)
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
      "Fortegra_tblCompanyProgramCodes"
    }, "Fortegra_GetProgramCodeExtData", new object[2]
    {
      (object) "@ProgramID",
      (object) this._programID
    });
    this.AssignValues();
  }

  private void AssignValues()
  {
    if (this.ds.Fortegra_tblCompanyProgramCodes.Count == 0)
      return;
    this.numCedingCommission.Value = (object) this.ds.Fortegra_tblCompanyProgramCodes[0].CedingCommission;
    this.numIssuingCarrierFrontFee.Value = (object) this.ds.Fortegra_tblCompanyProgramCodes[0].IssuingCarrierFrontFee;
    this.numIssuingCarrierPart.Value = (object) this.ds.Fortegra_tblCompanyProgramCodes[0].IssuingCarrierPart;
    this.numRIBroker.Value = (object) this.ds.Fortegra_tblCompanyProgramCodes[0].RIBroker;
    if (this.ds.Fortegra_tblCompanyProgramCodes[0].IsRIBrokerGUIDNull())
      return;
    this.cboRIBrokerGUID.Value = (object) this.ds.Fortegra_tblCompanyProgramCodes[0].RIBrokerGUID;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.numCedingCommission.Value == DBNull.Value || this.numCedingCommission.Value == null)
      this.numCedingCommission.Value = (object) 0;
    if (this.numIssuingCarrierFrontFee.Value == DBNull.Value || this.numIssuingCarrierFrontFee.Value == null)
      this.numIssuingCarrierFrontFee.Value = (object) 0;
    if (this.numIssuingCarrierPart.Value == DBNull.Value || this.numIssuingCarrierPart.Value == null)
      this.numIssuingCarrierPart.Value = (object) 0;
    if (this.numRIBroker.Value == DBNull.Value || this.numRIBroker.Value == null)
      this.numRIBroker.Value = (object) 0;
    object obj = (object) null;
    if (this.cboRIBrokerGUID.Value != null && this.cboRIBrokerGUID.Value != DBNull.Value && !this.cboRIBrokerGUID.Value.Equals((object) Guid.Empty))
      obj = this.cboRIBrokerGUID.Value;
    DefaultDatabase.ExecuteNonQuery("Fortegra_SaveProgramCodesExt", new object[12]
    {
      (object) "@ProgramID",
      (object) this._programID,
      (object) "@CedingCommission",
      this.numCedingCommission.Value,
      (object) "@IssuingCarrierFrontFee",
      this.numIssuingCarrierFrontFee.Value,
      (object) "@IssuingCarrierPart",
      this.numIssuingCarrierPart.Value,
      (object) "@RIBroker",
      this.numRIBroker.Value,
      (object) "@RIBrokerGUID",
      obj
    });
    int num = (int) MessageBox.Show("Data saved successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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
    this.ds = new dsProgCodeExt();
    ((ISupportInitialize) this.cboRIBrokerGUID).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.numIssuingCarrierFrontFee).BeginInit();
    ((ISupportInitialize) this.numIssuingCarrierPart).BeginInit();
    ((ISupportInitialize) this.numRIBroker).BeginInit();
    ((ISupportInitialize) this.numCedingCommission).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.label6.AutoSize = true;
    this.label6.Location = new Point(61, 177);
    this.label6.Name = "label6";
    this.label6.Size = new Size(86, 13);
    this.label6.TabIndex = 59;
    this.label6.Text = "RI Broker Name:";
    this.cboRIBrokerGUID.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRIBrokerGUID).DataMember = "tblCompanies";
    ((UltraGridBase) this.cboRIBrokerGUID).DataSource = (object) this.ds;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboRIBrokerGUID.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboRIBrokerGUID.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 273;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
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
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboRIBrokerGUID.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BorderColor = Color.White;
    this.cboRIBrokerGUID.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance3;
    this.cboRIBrokerGUID.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    this.cboRIBrokerGUID.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboRIBrokerGUID.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboRIBrokerGUID).DisplayMember = "CompanyName";
    this.cboRIBrokerGUID.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRIBrokerGUID).DropDownWidth = 400;
    ((Control) this.cboRIBrokerGUID).Location = new Point(64 /*0x40*/, 204);
    this.cboRIBrokerGUID.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRIBrokerGUID).Name = "cboRIBrokerGUID";
    ((Control) this.cboRIBrokerGUID).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.cboRIBrokerGUID).TabIndex = 51;
    ((UltraControlBase) this.cboRIBrokerGUID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRIBrokerGUID).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRIBrokerGUID).ValueMember = "CompanyGUID";
    this.lblProgramCode.AutoSize = true;
    this.lblProgramCode.Location = new Point(172, 13);
    this.lblProgramCode.Name = "lblProgramCode";
    this.lblProgramCode.Size = new Size(31 /*0x1F*/, 13);
    this.lblProgramCode.TabIndex = 58;
    this.lblProgramCode.Text = "<<>>";
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label5.Location = new Point(23, 13);
    this.label5.Name = "label5";
    this.label5.Size = new Size(143, 13);
    this.label5.TabIndex = 57;
    this.label5.Text = "Current Program Code - ";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnSave).Location = new Point(264, 247);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 52;
    ((UltraControlBase) this.btnSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Click += new EventHandler(this.btnSave_Click);
    this.label4.AutoSize = true;
    this.label4.Location = new Point(61, 84);
    this.label4.Name = "label4";
    this.label4.Size = new Size(124, 13);
    this.label4.TabIndex = 56;
    this.label4.Text = "Issuing Carrier Front Fee:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(61, 115);
    this.label3.Name = "label3";
    this.label3.Size = new Size(98, 13);
    this.label3.TabIndex = 55;
    this.label3.Text = "Issuing Carrier Part:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(61, 146);
    this.label2.Name = "label2";
    this.label2.Size = new Size(55, 13);
    this.label2.TabIndex = 54;
    this.label2.Text = "RI Broker:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(61, 53);
    this.label1.Name = "label1";
    this.label1.Size = new Size(101, 13);
    this.label1.TabIndex = 53;
    this.label1.Text = "Ceding Commission:";
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numIssuingCarrierFrontFee).Appearance = (AppearanceBase) appearance6;
    ((UltraNumericEditorBase) this.numIssuingCarrierFrontFee).FormatString = "";
    ((Control) this.numIssuingCarrierFrontFee).Location = new Point(246, 81);
    ((UltraNumericEditorBase) this.numIssuingCarrierFrontFee).MaskInput = "nnn.nnn";
    this.numIssuingCarrierFrontFee.MGAStyle = MGAStyles.Blue;
    ((Control) this.numIssuingCarrierFrontFee).Name = "numIssuingCarrierFrontFee";
    this.numIssuingCarrierFrontFee.Nullable = true;
    this.numIssuingCarrierFrontFee.NumericType = (NumericType) 2;
    ((Control) this.numIssuingCarrierFrontFee).Size = new Size(58, 19);
    ((Control) this.numIssuingCarrierFrontFee).TabIndex = 48 /*0x30*/;
    ((UltraWinEditorMaskedControlBase) this.numIssuingCarrierFrontFee).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numIssuingCarrierFrontFee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numIssuingCarrierFrontFee).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numIssuingCarrierPart).Appearance = (AppearanceBase) appearance7;
    ((UltraNumericEditorBase) this.numIssuingCarrierPart).FormatString = "";
    ((Control) this.numIssuingCarrierPart).Location = new Point(246, 112 /*0x70*/);
    ((UltraNumericEditorBase) this.numIssuingCarrierPart).MaskInput = "nnn.nnn";
    this.numIssuingCarrierPart.MGAStyle = MGAStyles.Blue;
    ((Control) this.numIssuingCarrierPart).Name = "numIssuingCarrierPart";
    this.numIssuingCarrierPart.Nullable = true;
    this.numIssuingCarrierPart.NumericType = (NumericType) 2;
    ((Control) this.numIssuingCarrierPart).Size = new Size(58, 19);
    ((Control) this.numIssuingCarrierPart).TabIndex = 49;
    ((UltraWinEditorMaskedControlBase) this.numIssuingCarrierPart).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numIssuingCarrierPart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numIssuingCarrierPart).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numRIBroker).Appearance = (AppearanceBase) appearance8;
    ((UltraNumericEditorBase) this.numRIBroker).FormatString = "";
    ((Control) this.numRIBroker).Location = new Point(246, 143);
    ((UltraNumericEditorBase) this.numRIBroker).MaskInput = "nnn.nnn";
    this.numRIBroker.MGAStyle = MGAStyles.Blue;
    ((Control) this.numRIBroker).Name = "numRIBroker";
    this.numRIBroker.Nullable = true;
    this.numRIBroker.NumericType = (NumericType) 2;
    ((Control) this.numRIBroker).Size = new Size(58, 19);
    ((Control) this.numRIBroker).TabIndex = 50;
    ((UltraWinEditorMaskedControlBase) this.numRIBroker).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numRIBroker).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numRIBroker).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numCedingCommission).Appearance = (AppearanceBase) appearance9;
    ((UltraNumericEditorBase) this.numCedingCommission).FormatString = "";
    ((Control) this.numCedingCommission).Location = new Point(246, 50);
    ((UltraNumericEditorBase) this.numCedingCommission).MaskInput = "nnn.nnn";
    this.numCedingCommission.MGAStyle = MGAStyles.Blue;
    ((Control) this.numCedingCommission).Name = "numCedingCommission";
    this.numCedingCommission.Nullable = true;
    this.numCedingCommission.NumericType = (NumericType) 2;
    ((Control) this.numCedingCommission).Size = new Size(58, 19);
    ((Control) this.numCedingCommission).TabIndex = 47;
    ((UltraWinEditorMaskedControlBase) this.numCedingCommission).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numCedingCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numCedingCommission).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsProgCodeExt";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(361, 302);
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
    this.Name = nameof (FormProgramCodeExtension);
    this.Text = "Commission Details";
    this.Load += new EventHandler(this.FormProgramCodeExtension_Load);
    ((ISupportInitialize) this.cboRIBrokerGUID).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.numIssuingCarrierFrontFee).EndInit();
    ((ISupportInitialize) this.numIssuingCarrierPart).EndInit();
    ((ISupportInitialize) this.numRIBroker).EndInit();
    ((ISupportInitialize) this.numCedingCommission).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
