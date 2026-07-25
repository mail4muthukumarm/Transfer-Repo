// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmVinVerification
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MgaSystems.IMS.WebIntegration.VinService;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
[SecureResource("{7B832196-5DA2-448e-ADE2-5D799DF06891}", "Control Access to Vin Verification Screen", "Allows for a user to view Vin Verification Screen", "Policy")]
public class frmVinVerification : FormBase
{
  private IContainer components;
  public const string canViewVinVerificationForm = "{7B832196-5DA2-448e-ADE2-5D799DF06891}";
  private Quote _quote;
  private DataTable _dtNetRateVinVerify;
  private VinVehicle _myCar;
  private string _selectedVin;
  private int _vehicleSource;

  [DebuggerNonUserCode]
  protected virtual void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(disposing));
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmVinVerification));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblNetRateVehicles", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("VehicleID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("VehicleNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Make");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Model");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("VIN");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Select", 0, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Last Scan", 1);
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("OriginalQuoteGuid", 2);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ControlNo", 3);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber", 4);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("InsuredPolicyName", 5);
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_tblQuoteAdditionalInterestsNetRateVehicles_tblNetRateVehicles", 0);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("AdditionalInterestID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("VehicleID");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    this.dsAdditionalInterests = new dsAdditionalInterests();
    this.daNetRateVehicles = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand7 = DefaultDatabase.CreateCommand();
    this.cnDB = DefaultDatabase.CreateDbConnection();
    this.DsAdditionalInterestsBindingSource = new BindingSource(this.components);
    this.TblNetRateVehiclesBindingSource = new BindingSource(this.components);
    this.Panel1 = new Panel();
    this.btnCancel = new MGAButton();
    this.btnVerify = new MGAButton();
    this.panelTop = new Panel();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.Panel2 = new Panel();
    this.lnkReportException = new LinkLabel();
    this.grdVehicles = new UltraGrid();
    this.llUnSelectVehicles = new LinkLabel();
    this.Label2 = new Label();
    this.llSelectVehicles = new LinkLabel();
    this.tbVehicles = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.BackgroundWorker1 = new BackgroundWorker();
    this.dsAdditionalInterests.BeginInit();
    ((ISupportInitialize) this.DsAdditionalInterestsBindingSource).BeginInit();
    ((ISupportInitialize) this.TblNetRateVehiclesBindingSource).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnVerify).BeginInit();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.grdVehicles).BeginInit();
    ((ISupportInitialize) this.tbVehicles).BeginInit();
    ((Control) this.tbVehicles).SuspendLayout();
    ((Control) this).SuspendLayout();
    this.dsAdditionalInterests.DataSetName = "dsAdditionalInterests";
    this.dsAdditionalInterests.Locale = new CultureInfo("en-US");
    this.dsAdditionalInterests.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daNetRateVehicles.SelectCommand = this.DbSelectCommand7;
    this.daNetRateVehicles.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "NetRate_Quote_Insur_Quote_Locat_Busin_Vehic", new DataColumnMapping[6]
      {
        new DataColumnMapping("VehicleID", "VehicleID"),
        new DataColumnMapping("VehicleNumber", "VehicleNumber"),
        new DataColumnMapping("Make", "Make"),
        new DataColumnMapping("Model", "Model"),
        new DataColumnMapping("Year", "Year"),
        new DataColumnMapping("VIN", "VIN")
      })
    });
    this.DbSelectCommand7.CommandText = componentResourceManager.GetString("DbSelectCommand7.CommandText");
    this.DbSelectCommand7.Connection = this.cnDB;
    this.DbSelectCommand7.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.cnDB = DefaultDatabase.CreateDbConnection();
    this.DsAdditionalInterestsBindingSource.DataSource = (object) this.dsAdditionalInterests;
    this.DsAdditionalInterestsBindingSource.Position = 0;
    this.TblNetRateVehiclesBindingSource.DataMember = "tblNetRateVehicles";
    this.TblNetRateVehiclesBindingSource.DataSource = (object) this.DsAdditionalInterestsBindingSource;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.btnCancel);
    this.Panel1.Controls.Add((Control) this.btnVerify);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 538);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(628, 49);
    this.Panel1.TabIndex = 5;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnCancel).Location = new Point(534, 6);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(82, 34);
    ((Control) this.btnCancel).TabIndex = 1;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnVerify).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnVerify).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnVerify).Location = new Point(445, 6);
    ((Control) this.btnVerify).Name = "btnVerify";
    ((Control) this.btnVerify).Size = new Size(82, 34);
    ((Control) this.btnVerify).TabIndex = 0;
    ((ControlBase) this.btnVerify).Text = "Verify";
    this.btnVerify.UseOSThemes = (DefaultableBoolean) 2;
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.Label1);
    this.panelTop.Controls.Add((Control) this.PictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(628, 77);
    this.panelTop.TabIndex = 7;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 18f);
    this.Label1.ForeColor = Color.SteelBlue;
    this.Label1.Location = new Point(448, 35);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(177, 29);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "VIN Verification";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.InitialImage = (Image) componentResourceManager.GetObject("PictureBox1.InitialImage");
    this.PictureBox1.Location = new Point(1, 6);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.lnkReportException);
    this.Panel2.Controls.Add((Control) this.grdVehicles);
    this.Panel2.Controls.Add((Control) this.llUnSelectVehicles);
    this.Panel2.Controls.Add((Control) this.Label2);
    this.Panel2.Controls.Add((Control) this.llSelectVehicles);
    this.Panel2.Controls.Add((Control) this.tbVehicles);
    this.Panel2.Dock = DockStyle.Fill;
    this.Panel2.Location = new Point(0, 77);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(628, 461);
    this.Panel2.TabIndex = 8;
    this.lnkReportException.AutoSize = true;
    this.lnkReportException.Location = new Point(361, 152);
    this.lnkReportException.Name = "lnkReportException";
    this.lnkReportException.Size = new Size(236, 13);
    this.lnkReportException.TabIndex = 11;
    this.lnkReportException.TabStop = true;
    this.lnkReportException.Text = "View  Exception Report  for this Control Number";
    ((UltraGridBase) this.grdVehicles).DataSource = (object) this.TblNetRateVehiclesBindingSource;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.FilterClearButtonVisible = (DefaultableBoolean) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 57;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.FilterClearButtonVisible = (DefaultableBoolean) 1;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Vehicle #";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 62;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.FilterClearButtonVisible = (DefaultableBoolean) 1;
    ultraGridColumn3.FilterComparisonType = (FilterComparisonType) 1;
    ultraGridColumn3.FilterEvaluationTrigger = (FilterEvaluationTrigger) 5;
    ultraGridColumn3.FilterOperandStyle = (FilterOperandStyle) 4;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ultraGridColumn3.Width = 80 /*0x50*/;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.FilterClearButtonVisible = (DefaultableBoolean) 1;
    ultraGridColumn4.FilterComparisonType = (FilterComparisonType) 1;
    ultraGridColumn4.FilterEvaluationTrigger = (FilterEvaluationTrigger) 5;
    ultraGridColumn4.FilterOperandStyle = (FilterOperandStyle) 4;
    ultraGridColumn4.Header.VisiblePosition = 5;
    ultraGridColumn4.Width = 97;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 56;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 151;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 12;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellClickAction = (CellClickAction) 1;
    ultraGridColumn8.DataType = typeof (bool);
    ultraGridColumn8.DefaultCellValue = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraGridColumn8.DefaultCellValue"));
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.MaxWidth = 50;
    ultraGridColumn8.MinWidth = 50;
    ultraGridColumn8.Width = 50;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    ultraGridColumn9.CellActivation = (Activation) 1;
    ultraGridColumn9.CellClickAction = (CellClickAction) 2;
    ultraGridColumn9.DefaultCellValue = (object) "";
    ultraGridColumn9.Header.VisiblePosition = 7;
    appearance4.FontData.UnderlineAsString = "True";
    appearance4.ForeColor = Color.Blue;
    ultraGridColumn9.MaskLiteralsAppearance = (AppearanceBase) appearance4;
    ultraGridColumn9.Style = (ColumnStyle) 38;
    ultraGridColumn9.Width = 130;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 8;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 9;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 10;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 11;
    ultraGridColumn13.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[13]
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
      (object) ultraGridColumn13
    });
    ((HeaderBase) ultraGridBand1.Header).Caption = "Lines Of Business";
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn14.Width = 329;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn15.Width = 187;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ultraGridBand2.Hidden = true;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.grdVehicles).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.grdVehicles).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.grdVehicles).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.MaxSelectedRows = 50;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.WhiteSmoke;
    appearance12.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.grdVehicles).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grdVehicles).Dock = DockStyle.Top;
    ((Control) this.grdVehicles).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.grdVehicles).Location = new Point(0, 0);
    ((Control) this.grdVehicles).Name = "grdVehicles";
    ((Control) this.grdVehicles).Size = new Size(628, 145);
    ((Control) this.grdVehicles).TabIndex = 3;
    ((UltraControlBase) this.grdVehicles).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdVehicles).UseOsThemes = (DefaultableBoolean) 2;
    this.llUnSelectVehicles.AutoSize = true;
    this.llUnSelectVehicles.Location = new Point(132, 152);
    this.llUnSelectVehicles.Name = "llUnSelectVehicles";
    this.llUnSelectVehicles.Size = new Size(103, 13);
    this.llUnSelectVehicles.TabIndex = 10;
    this.llUnSelectVehicles.TabStop = true;
    this.llUnSelectVehicles.Text = "Unselect All Vehicles";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(114, 152);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(11, 13);
    this.Label2.TabIndex = 9;
    this.Label2.Text = "/";
    this.llSelectVehicles.AutoSize = true;
    this.llSelectVehicles.Location = new Point(16 /*0x10*/, 152);
    this.llSelectVehicles.Name = "llSelectVehicles";
    this.llSelectVehicles.Size = new Size(91, 13);
    this.llSelectVehicles.TabIndex = 8;
    this.llSelectVehicles.TabStop = true;
    this.llSelectVehicles.Text = "Select All Vehicles";
    ((Control) this.tbVehicles).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance14.BackColor = Color.Transparent;
    ((UltraTabControlBase) this.tbVehicles).Appearance = (AppearanceBase) appearance14;
    ((Control) this.tbVehicles).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tbVehicles).Location = new Point(3, 173);
    ((Control) this.tbVehicles).Name = "tbVehicles";
    appearance15.BackColor = Color.Transparent;
    ((UltraTabControlBase) this.tbVehicles).SelectedTabAppearance = (AppearanceBase) appearance15;
    ((UltraTabControlBase) this.tbVehicles).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tbVehicles).Size = new Size(621, 282);
    ((Control) this.tbVehicles).TabIndex = 7;
    ((UltraTabControlBase) this.tbVehicles).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(1, 20);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(619, 261);
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).BackColor = Color.White;
    ((Form) this).ClientSize = new Size(628, 587);
    ((Form) this).ControlBox = false;
    ((Control) this).Controls.Add((Control) this.Panel2);
    ((Control) this).Controls.Add((Control) this.panelTop);
    ((Control) this).Controls.Add((Control) this.Panel1);
    ((Control) this).Font = new Font("Tahoma", 8.25f);
    ((Form) this).FormBorderStyle = FormBorderStyle.FixedDialog;
    ((Form) this).MaximumSize = new Size(689, 626);
    ((Control) this).Name = nameof (frmVinVerification);
    ((Form) this).Text = "VIN Verification";
    this.dsAdditionalInterests.EndInit();
    ((ISupportInitialize) this.DsAdditionalInterestsBindingSource).EndInit();
    ((ISupportInitialize) this.TblNetRateVehiclesBindingSource).EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnVerify).EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.grdVehicles).EndInit();
    ((ISupportInitialize) this.tbVehicles).EndInit();
    ((Control) this.tbVehicles).ResumeLayout(false);
    ((Control) this).ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dsAdditionalInterests")]
  protected virtual dsAdditionalInterests dsAdditionalInterests { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daNetRateVehicles")]
  private virtual DbDataAdapter daNetRateVehicles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand7")]
  private virtual DbCommand DbSelectCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnDB")]
  private virtual DbConnection cnDB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TblNetRateVehiclesBindingSource")]
  internal virtual BindingSource TblNetRateVehiclesBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsAdditionalInterestsBindingSource")]
  internal virtual BindingSource DsAdditionalInterestsBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnVerify
  {
    get => this._btnVerify;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnVerify_Click);
      MGAButton btnVerify1 = this._btnVerify;
      if (btnVerify1 != null)
        ((Control) btnVerify1).Click -= eventHandler;
      this._btnVerify = value;
      MGAButton btnVerify2 = this._btnVerify;
      if (btnVerify2 == null)
        return;
      ((Control) btnVerify2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("panelTop")]
  internal virtual Panel panelTop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid grdVehicles
  {
    get => this._grdVehicles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.grdVehicles_MouseDown);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.grdVehicles_InitializeRow);
      UltraGrid grdVehicles1 = this._grdVehicles;
      if (grdVehicles1 != null)
      {
        ((Control) grdVehicles1).MouseDown -= mouseEventHandler;
        grdVehicles1.InitializeRow -= initializeRowEventHandler;
      }
      this._grdVehicles = value;
      UltraGrid grdVehicles2 = this._grdVehicles;
      if (grdVehicles2 == null)
        return;
      ((Control) grdVehicles2).MouseDown += mouseEventHandler;
      grdVehicles2.InitializeRow += initializeRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("tbVehicles")]
  internal virtual UltraTabControl tbVehicles { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel llSelectVehicles
  {
    get => this._llSelectVehicles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.llSelectVehicles_LinkClicked);
      LinkLabel llSelectVehicles1 = this._llSelectVehicles;
      if (llSelectVehicles1 != null)
        llSelectVehicles1.LinkClicked -= clickedEventHandler;
      this._llSelectVehicles = value;
      LinkLabel llSelectVehicles2 = this._llSelectVehicles;
      if (llSelectVehicles2 == null)
        return;
      llSelectVehicles2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel llUnSelectVehicles
  {
    get => this._llUnSelectVehicles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.llUnSelectVehicles_LinkClicked);
      LinkLabel unSelectVehicles1 = this._llUnSelectVehicles;
      if (unSelectVehicles1 != null)
        unSelectVehicles1.LinkClicked -= clickedEventHandler;
      this._llUnSelectVehicles = value;
      LinkLabel unSelectVehicles2 = this._llUnSelectVehicles;
      if (unSelectVehicles2 == null)
        return;
      unSelectVehicles2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual BackgroundWorker BackgroundWorker1
  {
    get => this._BackgroundWorker1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
      BackgroundWorker backgroundWorker1_1 = this._BackgroundWorker1;
      if (backgroundWorker1_1 != null)
      {
        backgroundWorker1_1.RunWorkerCompleted -= completedEventHandler;
        backgroundWorker1_1.DoWork -= workEventHandler;
      }
      this._BackgroundWorker1 = value;
      BackgroundWorker backgroundWorker1_2 = this._BackgroundWorker1;
      if (backgroundWorker1_2 == null)
        return;
      backgroundWorker1_2.RunWorkerCompleted += completedEventHandler;
      backgroundWorker1_2.DoWork += workEventHandler;
    }
  }

  internal virtual LinkLabel lnkReportException
  {
    get => this._lnkReportException;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkReportException_LinkClicked);
      LinkLabel lnkReportException1 = this._lnkReportException;
      if (lnkReportException1 != null)
        lnkReportException1.LinkClicked -= clickedEventHandler;
      this._lnkReportException = value;
      LinkLabel lnkReportException2 = this._lnkReportException;
      if (lnkReportException2 == null)
        return;
      lnkReportException2.LinkClicked += clickedEventHandler;
    }
  }

  public frmVinVerification(int quoteID)
  {
    ((Form) this).Load += new EventHandler(this.frmVinVerification_Load);
    this.InitializeComponent();
    this._quote = new Quote(quoteID);
  }

  protected dsAdditionalInterests ds => this.dsAdditionalInterests;

  protected SqlConnection cn => this.cnDB as SqlConnection;

  protected Quote Quote => this._quote;

  protected BindingManagerBase bmb
  {
    get
    {
      return ((ContainerControl) this).BindingContext[(object) this.dsAdditionalInterests, this.dsAdditionalInterests.tblQuoteAdditionalInterests.TableName];
    }
  }

  public DataTable dtNetRateVinVerify
  {
    get => this._dtNetRateVinVerify;
    set => this._dtNetRateVinVerify = value;
  }

  public VinVehicle myCar
  {
    get => this._myCar;
    set => this._myCar = value;
  }

  public string SelectedVin
  {
    get => this._selectedVin;
    set => this._selectedVin = value;
  }

  public int vehicleSource
  {
    get => this._vehicleSource;
    set => this._vehicleSource = value;
  }

  private void btnVerify_Click(object sender, EventArgs e)
  {
    try
    {
      ((Control) this).Cursor = MgaCursors.WaitCursor;
      ((Control) this.btnVerify).Enabled = false;
      ((UltraTabControlBase) this.tbVehicles).Tabs.Clear();
      this.BackgroundWorker1.RunWorkerAsync();
    }
    finally
    {
      ((Control) this).Cursor = MgaCursors.Default;
    }
  }

  private void grdVehicles_MouseDown(object sender, MouseEventArgs e)
  {
    try
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.grdVehicles.ActiveCell.Column.Key, "Last Scan", false) != 0)
        return;
      this.SelectedVin = this.grdVehicles.ActiveCell.Row.Cells["Vin"].Value.ToString();
      this.GetAvailableDataFromIMS(Conversions.ToDate(this.grdVehicles.ActiveCell.Row.Cells["Last Scan"].Value.ToString()));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => ((Form) this).Close();

  private void llSelectVehicles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grdVehicles).Rows)
      row.Cells["Select"].SetValue((object) true, false);
  }

  private void llUnSelectVehicles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grdVehicles).Rows)
      row.Cells["Select"].SetValue((object) false, false);
  }

  private void lnkReportException_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.grdVehicles).Rows.Count <= 0)
      return;
    DataTable dt = DefaultDatabase.ExecuteDataTable("rptVinException", new object[2]
    {
      (object) "@controlno",
      (object) Conversions.ToInteger(((UltraGridBase) this.grdVehicles).Rows[0].Cells["ControlNo"].Value)
    });
    if (dt.Rows.Count < 1)
    {
      int num = (int) MessageBox.Show("There were no exceptions for this control number");
    }
    else
      ReportFactory.Instance.ShowReport((SectionReport) new rptVinException(dt));
  }

  private void frmVinVerification_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.FillNetRateVehicles();
  }

  private void grdVehicles_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (string.IsNullOrEmpty(e.Row.Cells["OriginalQuoteGuid"].Value.ToString()))
      return;
    e.Row.CellAppearance.ForeColor = Color.Blue;
  }

  private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    ((Control) this.btnVerify).Enabled = true;
  }

  protected virtual void FillNetRateVehicles()
  {
    this.daNetRateVehicles.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quote.QuoteID;
    this.dsAdditionalInterests.EnforceConstraints = false;
    this.dsAdditionalInterests.tblNetRateVehicles.Clear();
    this.FillVehicles();
  }

  protected virtual void FillVehicles()
  {
    DefaultDatabase.DataAdapterFill(this.daNetRateVehicles, (DataTable) this.dsAdditionalInterests.tblNetRateVehicles);
    this.dsAdditionalInterests.EnforceConstraints = true;
  }

  protected virtual string VerifyVinStoredProcedure() => "NetRateVinVerify";

  private void GetAvailableData()
  {
    if (string.IsNullOrEmpty(this.SelectedVin))
      return;
    this.dtNetRateVinVerify = DefaultDatabase.ExecuteDataTable(this.VerifyVinStoredProcedure(), new object[2]
    {
      (object) "@VinNumber",
      (object) this.SelectedVin
    });
    this.myCar = this.GetVehicleInfoFromVault(this.SelectedVin);
    this.vehicleSource = 0;
    this.PrepareVehicleTab();
  }

  private void GetAvailableDataFromIMS(DateTime selectedDate)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "Select VerifiedData, VehicleType FROM tblVinLog WHERE VinNumber = @Vin", new object[2]
    {
      (object) "@Vin",
      (object) this.SelectedVin
    });
    string VehicleXMLString = Conversions.ToString(dataTable.Rows[0]["VerifiedData"]);
    string Left = dataTable.Rows[0]["VehicleType"].ToString();
    this.myCar = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "T", false) == 0 ? this.GetLocalTruckVehicleXML(VehicleXMLString) : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "C", false) == 0 ? this.GetLocalVehicleXML(VehicleXMLString) : (VinVehicle) null);
    this.vehicleSource = 1;
    this.dtNetRateVinVerify = DefaultDatabase.ExecuteDataTable(this.VerifyVinStoredProcedure(), new object[2]
    {
      (object) "@VinNumber",
      (object) this.SelectedVin
    });
    this.PrepareVehicleTab();
  }

  private VinVehicle GetVehicleInfoFromVault(string vinNumber)
  {
    VehicleVinVerification vehicleVinVerification = new VehicleVinVerification();
    this.myCar = vehicleVinVerification.GetVehicleXML(vinNumber);
    if (Information.IsNothing((object) this.myCar.year))
      this.myCar = vehicleVinVerification.GetTruckVehicleXML(vinNumber);
    return this.myCar;
  }

  private VinVehicle GetLocalVehicleXML(string VehicleXMLString)
  {
    VehicleVinVerification vehicleVinVerification = new VehicleVinVerification();
    vehicleVinVerification.ParseVehicleInfo(VehicleXMLString);
    return vehicleVinVerification.vv;
  }

  private VinVehicle GetLocalTruckVehicleXML(string VehicleXMLString)
  {
    VehicleVinVerification vehicleVinVerification = new VehicleVinVerification();
    vehicleVinVerification.ParseTruckVehicleInfo(VehicleXMLString);
    return vehicleVinVerification.vv;
  }

  private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grdVehicles).Rows)
    {
      this.SelectedVin = string.Empty;
      if (Conversions.ToBoolean(row.Cells["Select"].Value))
      {
        this.SelectedVin = row.Cells["VIN"].Value.ToString();
        this.GetAvailableData();
      }
    }
  }

  private void PrepareVehicleTab()
  {
    // ISSUE: explicit non-virtual call
    if (__nonvirtual (((Control) this).InvokeRequired))
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new MethodInvoker(this.PrepareVehicleTab), new object[0]);
    }
    else
    {
      UltraTab ultraTab = ((UltraTabControlBase) this.tbVehicles).Tabs.Add();
      ucVinCar ucVinCar = new ucVinCar();
      int integer = Conversions.ToInteger(this.dtNetRateVinVerify.Rows[0]["ControlNo"].ToString());
      string str = this.dtNetRateVinVerify.Rows[0]["PolicyNumber"].ToString();
      ucVinCar.lblYear.Text = this.dtNetRateVinVerify.Rows[0]["ModelYear"].ToString();
      ucVinCar.lblMake.Text = this.dtNetRateVinVerify.Rows[0]["Make"].ToString();
      ucVinCar.lblModel.Text = this.dtNetRateVinVerify.Rows[0]["Model"].ToString();
      ucVinCar.lblVin.Text = this.dtNetRateVinVerify.Rows[0]["Vin"].ToString();
      if (Information.IsNothing((object) this.myCar))
      {
        ucVinCar.lblYearVV.Text = string.Empty;
        ucVinCar.lblMakevv.Text = string.Empty;
        ucVinCar.lblModelvv.Text = string.Empty;
        ucVinCar.lblVinvv.Text = "Possible Invalid Vin ";
        ucVinCar.lblMSRP.Text = string.Empty;
        ucVinCar.lbEquipment.DataSource = (object) null;
        ucVinCar.lblEnginevv.Text = string.Empty;
        ucVinCar.lblCapacityvv.Text = string.Empty;
        ucVinCar.lblCurbWtvv.Text = string.Empty;
        ucVinCar.lblABSvv.Text = string.Empty;
        ucVinCar.lblBrakeTypevv.Text = string.Empty;
        ucVinCar.lblFuelTypevv.Text = string.Empty;
        ucVinCar.lblGrossWtvv.Text = string.Empty;
        ucVinCar.txtTransmissionType.Text = string.Empty;
        ultraTab.Text = this.dtNetRateVinVerify.Rows[0]["ModelYear"].ToString() + Strings.Space(1) + this.dtNetRateVinVerify.Rows[0]["Make"].ToString();
        ultraTab.Appearance.ForeColor = Color.Red;
      }
      if (!Information.IsNothing((object) this.myCar.year))
      {
        CurrentUser.Instance.LogAction("Vin Verification " + this.SelectedVin.ToString(), string.Empty);
        if (this.vehicleSource == 0)
          DefaultDatabase.ExecuteNonQuery("LogVinActivity", new object[12]
          {
            (object) "@VinNumber",
            (object) this.SelectedVin.ToString(),
            (object) "@Success",
            (object) 1,
            (object) "@VinData",
            (object) this.myCar.returnedVehicleXML,
            (object) "@vehicleType",
            (object) this.myCar.vehicleType,
            (object) "@controlNo",
            (object) integer,
            (object) "@policyNumber",
            (object) str
          });
        ucVinCar.lblYearVV.Text = this.myCar.year;
        ucVinCar.lblMakevv.Text = this.myCar.make;
        ucVinCar.lblModelvv.Text = this.myCar.model;
        ucVinCar.lblVinvv.Text = "Yes";
        ucVinCar.lblMSRP.Text = this.myCar.msrp;
        ucVinCar.lbEquipment.DataSource = (object) this.myCar.installedEquipment;
        ucVinCar.lblEnginevv.Text = this.myCar.engineType;
        ucVinCar.lblCapacityvv.Text = this.myCar.capacity;
        ucVinCar.lblCurbWtvv.Text = this.myCar.baseCurbWeight;
        ucVinCar.lblABSvv.Text = this.myCar.absSystem;
        ucVinCar.lblBrakeTypevv.Text = this.myCar.brakeType;
        ucVinCar.lblFuelTypevv.Text = this.myCar.fuelType;
        ucVinCar.lblGrossWtvv.Text = this.myCar.grossVehicleWeight;
        ucVinCar.txtTransmissionType.Text = this.myCar.transType;
        ultraTab.Text = this.dtNetRateVinVerify.Rows[0]["ModelYear"].ToString() + Strings.Space(1) + this.dtNetRateVinVerify.Rows[0]["Make"].ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(ucVinCar.lblVinvv.Text), "false", false) == 0)
          ultraTab.Appearance.ForeColor = Color.Red;
      }
      else
      {
        if (this.vehicleSource == 0)
          DefaultDatabase.ExecuteNonQuery("LogVinActivity", new object[12]
          {
            (object) "@VinNumber",
            (object) this.SelectedVin.ToString(),
            (object) "@Success",
            (object) 0,
            (object) "@VinData",
            (object) string.Empty,
            (object) "@vehicleType",
            (object) string.Empty,
            (object) "@controlNo",
            (object) integer,
            (object) "@policyNumber",
            (object) str
          });
        ucVinCar.lblYearVV.Text = string.Empty;
        ucVinCar.lblMakevv.Text = string.Empty;
        ucVinCar.lblModelvv.Text = string.Empty;
        ucVinCar.lblVinvv.Text = string.Empty;
        ucVinCar.lblMSRP.Text = string.Empty;
        ucVinCar.lbEquipment.DataSource = (object) null;
        ucVinCar.lblEnginevv.Text = string.Empty;
        ucVinCar.lblCapacityvv.Text = string.Empty;
        ucVinCar.lblCurbWtvv.Text = string.Empty;
        ucVinCar.lblABSvv.Text = string.Empty;
        ucVinCar.lblBrakeTypevv.Text = string.Empty;
        ucVinCar.lblFuelTypevv.Text = string.Empty;
        ucVinCar.lblGrossWtvv.Text = string.Empty;
        ucVinCar.txtTransmissionType.Text = string.Empty;
        ultraTab.Text = this.dtNetRateVinVerify.Rows[0]["ModelYear"].ToString() + Strings.Space(1) + this.dtNetRateVinVerify.Rows[0]["Make"].ToString();
        ultraTab.Appearance.ForeColor = Color.Red;
      }
      ((Control) ultraTab.TabPage).Controls.Add((Control) ucVinCar);
    }
  }

  private class NetRateVehicle
  {
    private int _vehicleID;
    private string _display;

    public NetRateVehicle(int vehicleID, string display)
    {
      this._vehicleID = vehicleID;
      this._display = display;
    }

    public int VehicleID => this._vehicleID;

    public override string ToString() => this._display;
  }
}
