// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmSirconIndividual
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.InsuredsProducersCompanies.Sircon;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class frmSirconIndividual : Form
{
  private IContainer components;
  private dsSirconDataSet dsSirconDataSet;
  internal Label lblIndNPN;
  internal Label lblIndName;
  internal TextBox tbIndNPN;
  internal TextBox tbIndName;
  internal TextBox tbSirconStatus;
  internal TextBox tbSirconMsg;
  internal Label lblLicenses;
  internal Label lblLOAs;
  private UltraGrid SirconLOAGrid;
  private UltraGrid SirconLicenseGrid;
  internal Label lblSirconStatus;

  public frmSirconIndividual(string individualLastName, string individualNPN)
  {
    this.InitializeComponent();
    this.getSirconData(individualLastName, individualNPN);
  }

  private void getSirconData(string individualLastName, string individualNPN)
  {
    if (!Utilities.SirconEnabled)
      return;
    if (!string.IsNullOrEmpty(individualLastName))
    {
      if (!string.IsNullOrEmpty(individualNPN))
      {
        try
        {
          this.DisplaySirconResults(this.MakeSirconRequest(individualLastName, individualNPN, ProducerDataRetriever.ProducerIdentifiers.NPN, ProducerDataRetriever.ProducerType.Individual));
          return;
        }
        catch (Exception ex)
        {
          this.tbSirconMsg.Text = ex.Message;
          this.tbSirconStatus.Text = "Exception Thrown";
          return;
        }
      }
    }
    this.tbIndName.Text = individualLastName;
    this.tbIndNPN.Text = individualNPN;
    this.tbSirconMsg.Text = "Name or NPN Missing";
    this.tbSirconStatus.Text = "No Data";
  }

  private ProducerData MakeSirconRequest(
    string producerName,
    string producerDataValue,
    ProducerDataRetriever.ProducerIdentifiers producerDataType,
    ProducerDataRetriever.ProducerType producerType)
  {
    ProducerDataRetriever producerDataRetriever = new ProducerDataRetriever();
    producerDataRetriever.SetSearchCriteria(producerName, producerDataType, producerDataValue, producerType);
    producerDataRetriever.AddSectionTypes(ProducerDataRetriever.SectionType.Licenses);
    producerDataRetriever.AddSectionTypes(ProducerDataRetriever.SectionType.Loas);
    return producerDataRetriever.RetrieveData();
  }

  private void DisplaySirconResults(ProducerData result)
  {
    this.dsSirconDataSet.Clear();
    this.tbIndName.Text = string.Empty;
    this.tbIndNPN.Text = string.Empty;
    if (result.isValid)
    {
      foreach (LicenseData licenseData in result.lstLicenseData)
      {
        dsSirconDataSet.tblSirconLicensesRow row = this.dsSirconDataSet.tblSirconLicenses.NewtblSirconLicensesRow();
        row.Type = licenseData.Type;
        row.State = licenseData.State;
        row.Status = licenseData.Status;
        row.ExpirationDate = licenseData.ExpirationDate;
        row.Number = licenseData.Number;
        this.dsSirconDataSet.tblSirconLicenses.Rows.Add((DataRow) row);
      }
      foreach (LOAData loaData in result.lstLOAData)
      {
        dsSirconDataSet.tblSirconLOAsRow row = this.dsSirconDataSet.tblSirconLOAs.NewtblSirconLOAsRow();
        row.Type = loaData.Type;
        row.State = loaData.State;
        row.Status = loaData.Status;
        row.StatusDate = loaData.StatusDate;
        row.ExpirationDate = loaData.ExpirationDate;
        this.dsSirconDataSet.tblSirconLOAs.Rows.Add((DataRow) row);
      }
      this.tbIndName.Text = result.indFullName;
      this.tbIndNPN.Text = result.indNPN;
    }
    this.tbSirconMsg.Text = result.statusMessage;
    this.tbSirconStatus.Text = result.SirconStatus;
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblSirconLOAs", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StatusDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ExpirationDate");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblSirconLicenses", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Number");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    this.dsSirconDataSet = new dsSirconDataSet();
    this.lblIndNPN = new Label();
    this.lblIndName = new Label();
    this.tbIndNPN = new TextBox();
    this.tbIndName = new TextBox();
    this.tbSirconStatus = new TextBox();
    this.tbSirconMsg = new TextBox();
    this.lblLicenses = new Label();
    this.lblLOAs = new Label();
    this.SirconLOAGrid = new UltraGrid();
    this.SirconLicenseGrid = new UltraGrid();
    this.lblSirconStatus = new Label();
    this.dsSirconDataSet.BeginInit();
    ((ISupportInitialize) this.SirconLOAGrid).BeginInit();
    ((ISupportInitialize) this.SirconLicenseGrid).BeginInit();
    this.SuspendLayout();
    this.dsSirconDataSet.DataSetName = "dsSirconDataSet";
    this.dsSirconDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblIndNPN.AutoSize = true;
    this.lblIndNPN.Location = new Point(570, 67);
    this.lblIndNPN.Name = "lblIndNPN";
    this.lblIndNPN.Size = new Size(85, 13);
    this.lblIndNPN.TabIndex = 52;
    this.lblIndNPN.Text = "Individual's NPN";
    this.lblIndName.AutoSize = true;
    this.lblIndName.Location = new Point(565, 43);
    this.lblIndName.Name = "lblIndName";
    this.lblIndName.Size = new Size(90, 13);
    this.lblIndName.TabIndex = 51;
    this.lblIndName.Text = "Individual's Name";
    this.tbIndNPN.Location = new Point(660, 63 /*0x3F*/);
    this.tbIndNPN.Name = "tbIndNPN";
    this.tbIndNPN.ReadOnly = true;
    this.tbIndNPN.Size = new Size(169, 20);
    this.tbIndNPN.TabIndex = 50;
    this.tbIndName.Location = new Point(660, 39);
    this.tbIndName.Name = "tbIndName";
    this.tbIndName.ReadOnly = true;
    this.tbIndName.Size = new Size(169, 20);
    this.tbIndName.TabIndex = 49;
    this.tbSirconStatus.Location = new Point(660, 258);
    this.tbSirconStatus.Name = "tbSirconStatus";
    this.tbSirconStatus.ReadOnly = true;
    this.tbSirconStatus.Size = new Size(169, 20);
    this.tbSirconStatus.TabIndex = 55;
    this.tbSirconMsg.Location = new Point(660, 286);
    this.tbSirconMsg.Name = "tbSirconMsg";
    this.tbSirconMsg.ReadOnly = true;
    this.tbSirconMsg.Size = new Size(169, 20);
    this.tbSirconMsg.TabIndex = 54;
    this.lblLicenses.AutoSize = true;
    this.lblLicenses.Location = new Point(13, 231);
    this.lblLicenses.Name = "lblLicenses";
    this.lblLicenses.Size = new Size(49, 13);
    this.lblLicenses.TabIndex = 57;
    this.lblLicenses.Text = "Licenses";
    this.lblLOAs.AutoSize = true;
    this.lblLOAs.Location = new Point(13, 28);
    this.lblLOAs.Name = "lblLOAs";
    this.lblLOAs.Size = new Size(33, 13);
    this.lblLOAs.TabIndex = 56;
    this.lblLOAs.Text = "LOAs";
    ((UltraGridBase) this.SirconLOAGrid).DataMember = "tblSirconLOAs";
    ((UltraGridBase) this.SirconLOAGrid).DataSource = (object) this.dsSirconDataSet;
    ((AppearanceBase) appearance1).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance1).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance2).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance4).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance4).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance5).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance5).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance6).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance7).BackColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    ((AppearanceBase) appearance8).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance9).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance9).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance11).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.SirconLOAGrid).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.SirconLOAGrid).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.SirconLOAGrid).Location = new Point(13, 44);
    ((Control) this.SirconLOAGrid).Name = "SirconLOAGrid";
    ((Control) this.SirconLOAGrid).Size = new Size(510, 130);
    ((Control) this.SirconLOAGrid).TabIndex = 58;
    ((Control) this.SirconLOAGrid).Text = "SirconLOAGrid";
    ((UltraControlBase) this.SirconLOAGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.SirconLOAGrid).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.SirconLicenseGrid).DataMember = "tblSirconLicenses";
    ((UltraGridBase) this.SirconLicenseGrid).DataSource = (object) this.dsSirconDataSet;
    ((AppearanceBase) appearance13).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance13).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 4;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance14).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance16).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance16).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance16).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance17).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance17).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance18).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance19).BackColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BorderColor = Color.Silver;
    ((AppearanceBase) appearance20).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance21).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance21).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance21).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance21).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance21).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance23).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance23).BorderColor = Color.Silver;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance24).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.SirconLicenseGrid).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.SirconLicenseGrid).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.SirconLicenseGrid).Location = new Point(13, 247);
    ((Control) this.SirconLicenseGrid).Name = "SirconLicenseGrid";
    ((Control) this.SirconLicenseGrid).Size = new Size(510, 130);
    ((Control) this.SirconLicenseGrid).TabIndex = 59;
    ((Control) this.SirconLicenseGrid).Text = "SirconLicenseGrid";
    ((UltraControlBase) this.SirconLicenseGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.SirconLicenseGrid).UseOsThemes = (DefaultableBoolean) 2;
    this.lblSirconStatus.AutoSize = true;
    this.lblSirconStatus.Location = new Point(660, 242);
    this.lblSirconStatus.Name = "lblSirconStatus";
    this.lblSirconStatus.Size = new Size(70, 13);
    this.lblSirconStatus.TabIndex = 60;
    this.lblSirconStatus.Text = "Sircon Status";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(867, 450);
    this.Controls.Add((Control) this.lblSirconStatus);
    this.Controls.Add((Control) this.SirconLicenseGrid);
    this.Controls.Add((Control) this.SirconLOAGrid);
    this.Controls.Add((Control) this.lblLicenses);
    this.Controls.Add((Control) this.lblLOAs);
    this.Controls.Add((Control) this.tbSirconStatus);
    this.Controls.Add((Control) this.tbSirconMsg);
    this.Controls.Add((Control) this.lblIndNPN);
    this.Controls.Add((Control) this.lblIndName);
    this.Controls.Add((Control) this.tbIndNPN);
    this.Controls.Add((Control) this.tbIndName);
    this.Name = nameof (frmSirconIndividual);
    this.Text = "Individual Producer";
    this.dsSirconDataSet.EndInit();
    ((ISupportInitialize) this.SirconLOAGrid).EndInit();
    ((ISupportInitialize) this.SirconLicenseGrid).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
