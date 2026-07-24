// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentFolderBulkTransfer
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmDocumentFolderBulkTransfer : Form
{
  private IContainer components;
  private const string COL_FOLDERIMAGE = "FOLDER_IMAGE";

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daFolderList")]
  internal virtual DbDataAdapter daFolderList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  internal virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  internal virtual DbConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsFolderList")]
  internal virtual DSFolderList DsFolderList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DVFolderList")]
  internal virtual DataView DVFolderList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAComboBox cboDocsFrom
  {
    get => this._cboDocsFrom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.cboDocsTo_InitializeRow);
      EventHandler eventHandler = new EventHandler(this.cboDocsFrom_ValueChanged);
      MGAComboBox cboDocsFrom1 = this._cboDocsFrom;
      if (cboDocsFrom1 != null)
      {
        cboDocsFrom1.InitializeRow -= initializeRowEventHandler;
        cboDocsFrom1.ValueChanged -= eventHandler;
      }
      this._cboDocsFrom = value;
      MGAComboBox cboDocsFrom2 = this._cboDocsFrom;
      if (cboDocsFrom2 == null)
        return;
      cboDocsFrom2.InitializeRow += initializeRowEventHandler;
      cboDocsFrom2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGAComboBox cboDocsTo
  {
    get => this._cboDocsTo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.cboDocsTo_InitializeRow);
      EventHandler eventHandler = new EventHandler(this.cboDocsTo_ValueChanged);
      MGAComboBox cboDocsTo1 = this._cboDocsTo;
      if (cboDocsTo1 != null)
      {
        cboDocsTo1.InitializeRow -= initializeRowEventHandler;
        cboDocsTo1.ValueChanged -= eventHandler;
      }
      this._cboDocsTo = value;
      MGAComboBox cboDocsTo2 = this._cboDocsTo;
      if (cboDocsTo2 == null)
        return;
      cboDocsTo2.InitializeRow += initializeRowEventHandler;
      cboDocsTo2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("grpDestination")]
  internal virtual MGAGroupBox grpDestination { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual MGAButton btnOk
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

  internal virtual CustomValidator CustomValidator1
  {
    get => this._CustomValidator1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CustomValidator.ValidateEventHandler validateEventHandler = new CustomValidator.ValidateEventHandler(this.CustomValidator1_CustomValidate);
      CustomValidator customValidator1_1 = this._CustomValidator1;
      if (customValidator1_1 != null)
        customValidator1_1.CustomValidate -= validateEventHandler;
      this._CustomValidator1 = value;
      CustomValidator customValidator1_2 = this._CustomValidator1;
      if (customValidator1_2 == null)
        return;
      customValidator1_2.CustomValidate += validateEventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmDocumentFolderBulkTransfer));
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblDocumentFolders", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FolderID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("FolderName");
    Appearance appearance5 = new Appearance();
    MGAScrollBarLook mgaScrollBarLook1 = new MGAScrollBarLook();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblDocumentFolders", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FolderID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("FolderName");
    Appearance appearance12 = new Appearance();
    MGAScrollBarLook mgaScrollBarLook2 = new MGAScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.cboDocsFrom = new MGAComboBox();
    this.DsFolderList = new DSFolderList();
    this.grpDestination = new MGAGroupBox();
    this.cboDocsTo = new MGAComboBox();
    this.DVFolderList = new DataView();
    this.daFolderList = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.btnCancel = new MGAButton();
    this.btnOk = new MGAButton();
    this.CustomValidator1 = new CustomValidator(this.components);
    this.ToolTip1 = new ToolTip(this.components);
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.cboDocsFrom).BeginInit();
    this.DsFolderList.BeginInit();
    ((ISupportInitialize) this.grpDestination).BeginInit();
    ((Control) this.grpDestination).SuspendLayout();
    ((ISupportInitialize) this.cboDocsTo).BeginInit();
    this.DVFolderList.BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.CustomValidator1).BeginInit();
    this.SuspendLayout();
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.Appearance = (AppearanceBase) appearance1;
    this.MgaGroupBox1.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboDocsFrom);
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ImageAlpha = (Alpha) 2;
    appearance3.ImageBackground = (Image) resourceManager.GetObject("Appearance3.ImageBackground");
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(224 /*0xE0*/, 64 /*0x40*/);
    this.MgaGroupBox1.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaGroupBox1).TabIndex = 0;
    this.MgaGroupBox1.Text = "Copy from...";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.cboDocsFrom).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboDocsFrom.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocsFrom.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboDocsFrom).DataSource = (object) this.DsFolderList.tblDocumentFolders;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboDocsFrom.DisplayLayout.Appearance = (AppearanceBase) appearance4;
    this.cboDocsFrom.DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 129;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 173;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboDocsFrom.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboDocsFrom.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocsFrom.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboDocsFrom.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.ForeColor = Color.Black;
    this.cboDocsFrom.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.WhiteSmoke;
    appearance6.BorderColor = Color.Silver;
    mgaScrollBarLook1.ButtonAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.WhiteSmoke;
    mgaScrollBarLook1.TrackAppearance = (AppearanceBase) appearance7;
    this.cboDocsFrom.DisplayLayout.ScrollBarLook = (ScrollBarLook) mgaScrollBarLook1;
    ((UltraDropDownBase) this.cboDocsFrom).DisplayMember = "FolderName";
    this.cboDocsFrom.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDocsFrom).Location = new Point(8, 37);
    ((UltraDropDownBase) this.cboDocsFrom).MaxDropDownItems = 4;
    this.cboDocsFrom.MGAStyle = MGAStyles.Blue;
    ((UltraDropDownBase) this.cboDocsFrom).MinDropDownItems = 2;
    ((Control) this.cboDocsFrom).Name = "cboDocsFrom";
    ((Control) this.cboDocsFrom).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.cboDocsFrom).TabIndex = 0;
    this.ToolTip1.SetToolTip((Control) this.cboDocsFrom, "Please choose a folder to copy from");
    ((UltraDropDownBase) this.cboDocsFrom).ValueMember = "FolderID";
    this.DsFolderList.DataSetName = "DSFolderList";
    this.DsFolderList.Locale = new CultureInfo("en-US");
    ((Control) this.grpDestination).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpDestination.Appearance = (AppearanceBase) appearance8;
    this.grpDestination.BackColor = Color.FromArgb(239, 247, 253);
    appearance9.BackColor = Color.FromArgb(239, 247, 253);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpDestination.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.grpDestination).Controls.Add((Control) this.cboDocsTo);
    ((Control) this.grpDestination).Enabled = false;
    appearance10.AlphaLevel = (short) 230;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.White;
    appearance10.ImageAlpha = (Alpha) 2;
    appearance10.ImageBackground = (Image) resourceManager.GetObject("Appearance10.ImageBackground");
    appearance10.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.grpDestination.HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.grpDestination).Location = new Point(8, 83);
    ((Control) this.grpDestination).Name = "grpDestination";
    ((Control) this.grpDestination).Size = new Size(224 /*0xE0*/, 64 /*0x40*/);
    this.grpDestination.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.grpDestination).TabIndex = 1;
    this.grpDestination.Text = "Destination folder...";
    this.grpDestination.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.cboDocsTo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboDocsTo.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocsTo.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboDocsTo).DataSource = (object) this.DVFolderList;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboDocsTo.DisplayLayout.Appearance = (AppearanceBase) appearance11;
    this.cboDocsTo.DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 129;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 173;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboDocsTo.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboDocsTo.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocsTo.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboDocsTo.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance12.BackColor = Color.Gainsboro;
    appearance12.ForeColor = Color.Black;
    this.cboDocsTo.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.WhiteSmoke;
    appearance13.BorderColor = Color.Silver;
    mgaScrollBarLook2.ButtonAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.WhiteSmoke;
    mgaScrollBarLook2.TrackAppearance = (AppearanceBase) appearance14;
    this.cboDocsTo.DisplayLayout.ScrollBarLook = (ScrollBarLook) mgaScrollBarLook2;
    ((UltraDropDownBase) this.cboDocsTo).DisplayMember = "FolderName";
    this.cboDocsTo.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDocsTo).Location = new Point(8, 37);
    ((UltraDropDownBase) this.cboDocsTo).MaxDropDownItems = 4;
    this.cboDocsTo.MGAStyle = MGAStyles.Blue;
    ((UltraDropDownBase) this.cboDocsTo).MinDropDownItems = 2;
    ((Control) this.cboDocsTo).Name = "cboDocsTo";
    ((Control) this.cboDocsTo).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.cboDocsTo).TabIndex = 1;
    this.ToolTip1.SetToolTip((Control) this.cboDocsTo, "Please choose a folder to copy to");
    ((UltraDropDownBase) this.cboDocsTo).ValueMember = "FolderID";
    this.DVFolderList.Table = (DataTable) this.DsFolderList.tblDocumentFolders;
    this.daFolderList.SelectCommand = this.DbSelectCommand1;
    this.daFolderList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentFolders", new DataColumnMapping[2]
      {
        new DataColumnMapping("FolderID", "FolderID"),
        new DataColumnMapping("FolderName", "FolderName")
      })
    });
    this.DbSelectCommand1.CommandText = "SELECT FolderID, FolderName FROM tblDocumentFolders (NOLOCK) ORDER BY FolderName";
    this.DbSelectCommand1.Connection = this.cnSQL;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.BackColor = Color.FromArgb(248, 248, 248);
    appearance15.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.DarkGray;
    appearance15.ImageHAlign = (HAlign) 2;
    appearance15.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance15;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(152, 152);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(75, 23);
    ((Control) this.btnCancel).TabIndex = 2;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance16.BackColor = Color.FromArgb(248, 248, 248);
    appearance16.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = Color.DarkGray;
    appearance16.ImageHAlign = (HAlign) 2;
    appearance16.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance16;
    ((Control) this.btnOk).Enabled = false;
    ((Control) this.btnOk).Location = new Point(72, 152);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(75, 23);
    ((Control) this.btnOk).TabIndex = 3;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.CustomValidator1.ControlToValidate = (Control) this.cboDocsTo;
    this.CustomValidator1.Enabled = true;
    this.CustomValidator1.FieldToValidate = "Value";
    this.AcceptButton = (IButtonControl) this.btnOk;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(240 /*0xF0*/, 182);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.grpDestination);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.MinimumSize = new Size(240 /*0xF0*/, 216);
    this.Name = nameof (frmDocumentFolderBulkTransfer);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Bulk document folder transfer";
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.cboDocsFrom).EndInit();
    this.DsFolderList.EndInit();
    ((ISupportInitialize) this.grpDestination).EndInit();
    ((Control) this.grpDestination).ResumeLayout(false);
    ((ISupportInitialize) this.cboDocsTo).EndInit();
    this.DVFolderList.EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.CustomValidator1).EndInit();
    this.ResumeLayout(false);
  }

  public frmDocumentFolderBulkTransfer()
  {
    this.Load += new EventHandler(this.frmDocumentFolderBulkTransfer_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    this.ToolTip1.Dispose();
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void frmDocumentFolderBulkTransfer_Load(object sender, EventArgs e)
  {
    DefaultDatabase.DataAdapterFill(this.daFolderList, (DataTable) this.DsFolderList.tblDocumentFolders);
    this.DsFolderList.tblDocumentFolders.Columns.Add("FOLDER_IMAGE", typeof (Image));
    this.cboDocsFrom.DisplayLayout.Bands[0].Columns["FOLDER_IMAGE"].Header.VisiblePosition = 0;
    this.cboDocsTo.DisplayLayout.Bands[0].Columns["FOLDER_IMAGE"].Header.VisiblePosition = 0;
    this.cboDocsFrom.DisplayLayout.Bands[0].Columns["FOLDER_IMAGE"].Width = 20;
    this.cboDocsTo.DisplayLayout.Bands[0].Columns["FOLDER_IMAGE"].Width = 20;
  }

  private void cboDocsTo_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    e.Row.Cells["FOLDER_IMAGE"].Value = (object) ImageCache.Instance.Folder;
  }

  private void cboDocsFrom_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.grpDestination).Enabled = this.cboDocsFrom.Value != null;
  }

  private void cboDocsTo_ValueChanged(object sender, EventArgs e)
  {
    this.CustomValidator1.Validate();
    ((Control) this.btnOk).Enabled = this.CustomValidator1.IsValid && (this.cboDocsTo.Value != null || this.cboDocsFrom.Value != null);
  }

  private void CustomValidator1_CustomValidate(object sender, ValidateEventArgs e)
  {
    e.IsValid = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboDocsTo.Text, this.cboDocsFrom.Text, false) != 0;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show($"This operation will copy all documents in the system from folder '{this.cboDocsFrom.Text}' to folder '{this.cboDocsTo.Text}'. Are you sure you want to do this?", "Confirm Bulk Copy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
      return;
    Database.Instance.QueryMultithreadedText.PerformNonQuery("UPDATE dbo.tblDocumentStore SET FolderID = @NewFolderID WHERE FolderID = @OldFolderID", (object) "@NewFolderID", (object) (int) this.cboDocsTo.Value, (object) "@OldFolderID", (object) (int) this.cboDocsFrom.Value);
    this.Close();
    DocumentManager.RefreshAllUI();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
