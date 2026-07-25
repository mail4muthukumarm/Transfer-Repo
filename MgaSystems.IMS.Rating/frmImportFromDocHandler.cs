// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmImportFromDocHandler
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class frmImportFromDocHandler : Form
{
  private IContainer components;
  private readonly Quote _quote;
  private string _fileName;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportFromDocHandler));
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblDocumentStore", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DocumentStoreGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FileName");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance6 = new Appearance();
    this.ds = new dsImportFromDocHandler();
    this.cn = new SqlConnection();
    this.btnNext = new MGAButton();
    this.cboImportExcelFile = new MGAComboBox();
    this.err = new ErrorProvider(this.components);
    this.Label1 = new Label();
    this.chkPlacePremiumInStateOfIssuance = new MGACheckBox();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.cboImportExcelFile).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.chkPlacePremiumInStateOfIssuance).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsImportFromDocHandler";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    appearance1.ImageHAlign = (HAlign) 3;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnNext).ImageSize = new Size(15, 11);
    ((Control) this.btnNext).Location = new Point(347, 62);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnNext).TabIndex = 40;
    ((ControlBase) this.btnNext).Text = "Next";
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.cboImportExcelFile).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.cboImportExcelFile.BorderStyle = (UIElementBorderStyle) 4;
    this.cboImportExcelFile.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboImportExcelFile).DataMember = "tblDocumentStore";
    ((UltraGridBase) this.cboImportExcelFile).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboImportExcelFile.DisplayLayout.Appearance = (AppearanceBase) appearance2;
    this.cboImportExcelFile.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.MaxLength = 400;
    ultraGridColumn2.Width = 340;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.MaxLength = 400;
    ultraGridColumn3.Width = 242;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    this.cboImportExcelFile.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cboImportExcelFile.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboImportExcelFile.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboImportExcelFile.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance3.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboImportExcelFile.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance3;
    appearance4.BorderColor = Color.White;
    this.cboImportExcelFile.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    this.cboImportExcelFile.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance5.ForeColor = Color.Black;
    this.cboImportExcelFile.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboImportExcelFile.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboImportExcelFile).DisplayMember = "FileName";
    this.cboImportExcelFile.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboImportExcelFile).DropDownWidth = 600;
    ((Control) this.cboImportExcelFile).Location = new Point(99, 25);
    this.cboImportExcelFile.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboImportExcelFile).Name = "cboImportExcelFile";
    ((Control) this.cboImportExcelFile).Size = new Size(328, 21);
    ((Control) this.cboImportExcelFile).TabIndex = 41;
    ((UltraControlBase) this.cboImportExcelFile).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboImportExcelFile).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboImportExcelFile).ValueMember = "DocumentStoreGUID";
    this.err.ContainerControl = (ContainerControl) this;
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(3, 29);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(92, 13);
    this.Label1.TabIndex = 42;
    this.Label1.Text = "Excel Documents:";
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPlacePremiumInStateOfIssuance).Location = new Point(6, 62);
    ((Control) this.chkPlacePremiumInStateOfIssuance).Name = "chkPlacePremiumInStateOfIssuance";
    ((Control) this.chkPlacePremiumInStateOfIssuance).Size = new Size(259, 25);
    ((Control) this.chkPlacePremiumInStateOfIssuance).TabIndex = 43;
    ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).Text = "Place all Premium in Policy State of Issuance.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(439, 92);
    this.Controls.Add((Control) this.chkPlacePremiumInStateOfIssuance);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboImportExcelFile);
    this.Controls.Add((Control) this.btnNext);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmImportFromDocHandler);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Import Excel Files From Document Handler";
    this.ds.EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.cboImportExcelFile).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.chkPlacePremiumInStateOfIssuance).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsImportFromDocHandler ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboImportExcelFile")]
  private virtual MGAComboBox cboImportExcelFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPlacePremiumInStateOfIssuance")]
  private virtual MGACheckBox chkPlacePremiumInStateOfIssuance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmImportFromDocHandler(Quote quote)
  {
    this.Load += new EventHandler(this.frmImportFromDocHandler_Load);
    this._fileName = string.Empty;
    this.InitializeComponent();
    this._quote = quote;
  }

  internal string FileName => this._fileName;

  internal bool PlacePremInStateOfIssuance
  {
    get => ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).Checked;
  }

  private void frmImportFromDocHandler_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblDocumentStore"
    }, "dbo.GetDocumentsAssociatedToQuote", new object[2]
    {
      (object) "@controlNo",
      (object) this._quote.ControlNo
    });
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboImportExcelFile.Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.cboImportExcelFile, "Select a value");
    }
    else
    {
      this.err.SetError((Control) this.cboImportExcelFile, string.Empty);
      this._fileName = DocumentManager.SaveDocumentToFile((Guid) this.cboImportExcelFile.Value);
      this.Close();
    }
  }
}
