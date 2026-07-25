// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Fortegra_FormProgramCode
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MgaSystems.Ims.Fortegra.ProgramCodes;
using MGASystems.IMS.Policies;
using MGASystems.InfragisticsExtensions.Editors;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides;

[Override(typeof (FormProgramCode))]
public sealed class Fortegra_FormProgramCode : FormProgramCode
{
  private HyperlinkEditor _addData = new HyperlinkEditor();
  private HyperlinkEditor _partData = new HyperlinkEditor();
  private Button btnDelete;

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyProgramCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLocationGUID", -1, (object) "ddCompanyLocations");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("StateID", -1, (object) "ddState");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContractEffective");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ContractExpiration");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LineGUID", -1, (object) "ddLine");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("IssuingOfficeGUID", -1, (object) "ddClientOffice");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProgCode");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GroupCode", -1, (object) "ddLineGroup");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("RowNum");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProgramCodeGuid");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LineName");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("OfficeGUID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Location");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LocationName");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("State");
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstLineGroups", -1);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("GroupCode");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("GroupName");
    this.btnDelete = new Button();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.dgProgramCodes).BeginInit();
    ((ISupportInitialize) this.ddLine).BeginInit();
    ((ISupportInitialize) this.ddClientOffice).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddCompanyLocations).BeginInit();
    ((ISupportInitialize) this.ddState).BeginInit();
    ((ISupportInitialize) this.ddLineGroup).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Location = new Point(1082, 396);
    ((SpecialBoxBase) ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Add ... Program Code";
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 4;
    ultraGridColumn1.Style = (ColumnStyle) 6;
    ultraGridColumn1.Width = 174;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 8;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 85;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 125;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Expiration";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 126;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 6;
    ultraGridColumn5.Style = (ColumnStyle) 6;
    ultraGridColumn5.Width = 144 /*0x90*/;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Issuing Office";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 7;
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 128 /*0x80*/;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Program Code";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ultraGridColumn7.Width = 146;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 9;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 76;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Line Group";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 121;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Row #";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Width = 40;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 191;
    ultraGridBand1.Columns.AddRange(new object[11]
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
      (object) ultraGridColumn11
    });
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 1;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.RowSelectorImages.DataChangedImage = (Image) null;
    ((Control) this.dgProgramCodes).Size = new Size(1110, 340);
    ((UltraGridBase) this.ddLine).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 0;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ddLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((Control) this.ddLine).Location = new Point(514, 125);
    ((UltraGridBase) this.ddClientOffice).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 0;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 1;
    ultraGridColumn15.Width = 200;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ((UltraGridBase) this.ddClientOffice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((Control) this.ddClientOffice).Location = new Point(684, 125);
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 0;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 8;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Company Location Name";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 1;
    ultraGridColumn17.Width = 200;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((Control) this.ddCompanyLocations).Location = new Point(882, 135);
    ((UltraGridBase) this.ddState).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 8;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 1;
    ultraGridColumn19.Width = 150;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ((UltraGridBase) this.ddState).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((Control) this.ddState).Location = new Point(371, 104);
    ((UltraGridBase) this.ddLineGroup).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 0;
    ultraGridColumn20.Hidden = true;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 1;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ((UltraGridBase) this.ddLineGroup).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((Control) this.ddLineGroup).Location = new Point(578, 178);
    this.btnDelete.Location = new Point(361, 379);
    this.btnDelete.Name = "btnDelete";
    this.btnDelete.Size = new Size(168, 29);
    this.btnDelete.TabIndex = 221;
    this.btnDelete.Text = "Delete UnRelated Recs";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.ClientSize = new Size(1134, 448);
    this.Controls.Add((Control) this.btnDelete);
    this.Name = nameof (Fortegra_FormProgramCode);
    this.Controls.SetChildIndex((Control) this.btnSave, 0);
    this.Controls.SetChildIndex((Control) this.dgProgramCodes, 0);
    this.Controls.SetChildIndex((Control) this.ddLine, 0);
    this.Controls.SetChildIndex((Control) this.ddClientOffice, 0);
    this.Controls.SetChildIndex((Control) this.ddCompanyLocations, 0);
    this.Controls.SetChildIndex((Control) this.ddState, 0);
    this.Controls.SetChildIndex((Control) this.lnkAddProgramCode, 0);
    this.Controls.SetChildIndex((Control) this.lnkCancelProgramCode, 0);
    this.Controls.SetChildIndex((Control) this.ddLineGroup, 0);
    this.Controls.SetChildIndex((Control) this.btnDelete, 0);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.dgProgramCodes).EndInit();
    ((ISupportInitialize) this.ddLine).EndInit();
    ((ISupportInitialize) this.ddClientOffice).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddCompanyLocations).EndInit();
    ((ISupportInitialize) this.ddState).EndInit();
    ((ISupportInitialize) this.ddLineGroup).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public Fortegra_FormProgramCode()
  {
    this.InitializeComponent();
    this.ds.tblCompanyProgramCodes.Columns.Add("Participation", typeof (string));
    this.ds.tblCompanyProgramCodes.Columns["Participation"].DefaultValue = (object) "Participation";
    this.ds.tblCompanyProgramCodes.Columns.Add("Program Code Ext.", typeof (string));
    this.ds.tblCompanyProgramCodes.Columns["Program Code Ext."].DefaultValue = (object) "Add Ext.";
    Appearance appearance1 = new Appearance();
    ((AppearanceBase) appearance1).FontData.UnderlineAsString = "True";
    ((AppearanceBase) appearance1).ForeColor = Color.Blue;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Center";
    Appearance appearance2 = new Appearance();
    ((AppearanceBase) appearance2).FontData.UnderlineAsString = "True";
    ((AppearanceBase) appearance2).ForeColor = Color.Blue;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["Program Code Ext."].CellAppearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["Program Code Ext."].Editor = (EmbeddableEditorBase) this._addData;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["Participation"].CellAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["Participation"].Editor = (EmbeddableEditorBase) this._partData;
    this._addData.HyperLinkOpening += new CancelEventHandler(this._addData_HyperLinkOpening);
    this._partData.HyperLinkOpening += new CancelEventHandler(this._partData_HyperLinkOpening);
    ((UltraControlBase) this.dgProgramCodes).Update();
    ((UltraGridBase) this.dgProgramCodes).UpdateData();
  }

  private void _partData_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    int ProgramID = (int) ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgramID"].Value;
    if (this.ds.tblCompanyProgramCodes.Select("ProgramID=" + ProgramID.ToString())[0].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save the current row prior to adding extension data.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      FormProgramCodeParticipation codeParticipation = new FormProgramCodeParticipation(ProgramID, ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgCode"].Value.ToString());
      codeParticipation.ShowInTaskbar = true;
      codeParticipation.StartPosition = FormStartPosition.CenterScreen;
      codeParticipation.Show();
    }
  }

  private void _addData_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    int ProgramID = (int) ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgramID"].Value;
    if (this.ds.tblCompanyProgramCodes.Select("ProgramID=" + ProgramID.ToString())[0].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save the current row prior to adding extension data.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      FormProgramCodeExtension programCodeExtension = new FormProgramCodeExtension(ProgramID, ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgCode"].Value.ToString());
      programCodeExtension.ShowInTaskbar = true;
      programCodeExtension.StartPosition = FormStartPosition.CenterScreen;
      programCodeExtension.Show();
    }
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    int num1 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM Fortegra_tblCompanyProgramCodes WITH (NOLOCK) where ProgramID not in (select ProgramID from tblCompanyProgramCodes)");
    if (num1 == 0)
    {
      int num2 = (int) MessageBox.Show("0 unrelated record found to remove", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show($"You are about to remove {num1} record(s)\n\n Continue ?", $"{num1} record(s) Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteScalar(CommandType.Text, "DELETE FROM Fortegra_tblCompanyProgramCodes where ProgramID not in (select ProgramID from tblCompanyProgramCodes)");
    }
  }
}
