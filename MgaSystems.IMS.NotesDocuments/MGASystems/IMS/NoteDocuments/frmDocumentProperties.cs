// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentProperties
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmDocumentProperties : Form
{
  private IContainer components;
  private Label Label10;
  private Label Label9;
  private Label Label5;
  private Label lblSizeOnServer;
  private Label Label8;
  private Label lblSize;
  private Label Label6;
  private Label Label4;
  private Label lblFileType;
  private Label Label3;
  private Label Label2;
  private Label Label1;
  private PictureBox pcFileIcon;
  private Label Label11;
  private ErrorProvider ErrorProvider1;
  private Label lblDateAdded;
  private Label lblOpensWith;
  private PictureBox pcAppIcon;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private readonly Guid _documentGuid;
  public DataRow _documentRow;
  private string _originalFileExtension;
  private bool _appliedChanges;
  private Point _normalOpeningAppLabelLocation;
  private Point _unknownOpeningAppLabelLocation;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGATextBox txtFileName
  {
    get => this._txtFileName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFileName_TextChanged);
      MGATextBox txtFileName1 = this._txtFileName;
      if (txtFileName1 != null)
        ((Control) txtFileName1).TextChanged -= eventHandler;
      this._txtFileName = value;
      MGATextBox txtFileName2 = this._txtFileName;
      if (txtFileName2 == null)
        return;
      ((Control) txtFileName2).TextChanged += eventHandler;
    }
  }

  protected virtual MGAButton btnCancel
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

  protected virtual MGAButton btnApply
  {
    get => this._btnApply;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnApply_Click);
      MGAButton btnApply1 = this._btnApply;
      if (btnApply1 != null)
        ((Control) btnApply1).Click -= eventHandler;
      this._btnApply = value;
      MGAButton btnApply2 = this._btnApply;
      if (btnApply2 == null)
        return;
      ((Control) btnApply2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  protected virtual MGATextBox txtDescription
  {
    get => this._txtDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtDescription_TextChanged);
      MGATextBox txtDescription1 = this._txtDescription;
      if (txtDescription1 != null)
        ((Control) txtDescription1).TextChanged -= eventHandler;
      this._txtDescription = value;
      MGATextBox txtDescription2 = this._txtDescription;
      if (txtDescription2 == null)
        return;
      ((Control) txtDescription2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabControl1")]
  protected virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkCopyForward
  {
    get => this._chkCopyForward;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCopyForward_CheckedChanged);
      MGACheckBox chkCopyForward1 = this._chkCopyForward;
      if (chkCopyForward1 != null)
        ((UltraToggleEditorBase) chkCopyForward1).CheckedChanged -= eventHandler;
      this._chkCopyForward = value;
      MGACheckBox chkCopyForward2 = this._chkCopyForward;
      if (chkCopyForward2 == null)
        return;
      ((UltraToggleEditorBase) chkCopyForward2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblAddedBy")]
  private virtual Label lblAddedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  internal virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboDocumentType
  {
    get => this._cboDocumentType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboDocumentType_ValueChanged);
      MGASimpleComboBox cboDocumentType1 = this._cboDocumentType;
      if (cboDocumentType1 != null)
        cboDocumentType1.ValueChanged -= eventHandler;
      this._cboDocumentType = value;
      MGASimpleComboBox cboDocumentType2 = this._cboDocumentType;
      if (cboDocumentType2 == null)
        return;
      cboDocumentType2.ValueChanged += eventHandler;
    }
  }

  protected virtual MGACheckBox chkCopyAssociationForwardOnlyOnce
  {
    get => this._chkCopyAssociationForwardOnlyOnce;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCopyAssociationForwardOnlyOnce_CheckedChanged);
      MGACheckBox associationForwardOnlyOnce1 = this._chkCopyAssociationForwardOnlyOnce;
      if (associationForwardOnlyOnce1 != null)
        ((UltraToggleEditorBase) associationForwardOnlyOnce1).CheckedChanged -= eventHandler;
      this._chkCopyAssociationForwardOnlyOnce = value;
      MGACheckBox associationForwardOnlyOnce2 = this._chkCopyAssociationForwardOnlyOnce;
      if (associationForwardOnlyOnce2 == null)
        return;
      ((UltraToggleEditorBase) associationForwardOnlyOnce2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentProperties));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance10 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.chkCopyAssociationForwardOnlyOnce = new MGACheckBox();
    this.lblAddedBy = new Label();
    this.Label12 = new Label();
    this.chkCopyForward = new MGACheckBox();
    this.lblOpensWith = new Label();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.txtDescription = new MGATextBox();
    this.lblDateAdded = new Label();
    this.Label9 = new Label();
    this.Label5 = new Label();
    this.lblSizeOnServer = new Label();
    this.Label8 = new Label();
    this.lblSize = new Label();
    this.Label6 = new Label();
    this.Label4 = new Label();
    this.lblFileType = new Label();
    this.pcAppIcon = new PictureBox();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.txtFileName = new MGATextBox();
    this.pcFileIcon = new PictureBox();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.cboDocumentType = new MGASimpleComboBox();
    this.Label7 = new Label();
    this.btnCancel = new MGAButton();
    this.btnApply = new MGAButton();
    this.btnOK = new MGAButton();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.chkCopyAssociationForwardOnlyOnce).BeginInit();
    ((ISupportInitialize) this.chkCopyForward).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.pcAppIcon).BeginInit();
    ((ISupportInitialize) this.txtFileName).BeginInit();
    ((ISupportInitialize) this.pcFileIcon).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.cboDocumentType).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnApply).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkCopyAssociationForwardOnlyOnce);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblAddedBy);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkCopyForward);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblOpensWith);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtDescription);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblDateAdded);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblSizeOnServer);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblSize);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblFileType);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.pcAppIcon);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtFileName);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.pcFileIcon);
    ((Control) this.UltraTabPageControl2).Location = new Point(1, 20);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(368, 411);
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCopyAssociationForwardOnlyOnce).Location = new Point(11, 393);
    ((Control) this.chkCopyAssociationForwardOnlyOnce).Name = "chkCopyAssociationForwardOnlyOnce";
    ((Control) this.chkCopyAssociationForwardOnlyOnce).Size = new Size(341, 15);
    ((Control) this.chkCopyAssociationForwardOnlyOnce).TabIndex = 39;
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Text = "Copy Association Forward Only Once";
    this.lblAddedBy.AutoSize = true;
    this.lblAddedBy.BackColor = Color.Transparent;
    this.lblAddedBy.Location = new Point(96 /*0x60*/, 195);
    this.lblAddedBy.Name = "lblAddedBy";
    this.lblAddedBy.Size = new Size(54, 13);
    this.lblAddedBy.TabIndex = 38;
    this.lblAddedBy.Text = "username";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(16 /*0x10*/, 195);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(57, 13);
    this.Label12.TabIndex = 37;
    this.Label12.Text = "Added By:";
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCopyForward).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkCopyForward).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCopyForward).Location = new Point(11, 371);
    ((Control) this.chkCopyForward).Name = "chkCopyForward";
    ((Control) this.chkCopyForward).Size = new Size(217, 17);
    ((Control) this.chkCopyForward).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkCopyForward).Text = "Copy associations forward on renewal:";
    this.lblOpensWith.AutoSize = true;
    this.lblOpensWith.BackColor = Color.Transparent;
    this.lblOpensWith.Location = new Point(120, 88);
    this.lblOpensWith.Name = "lblOpensWith";
    this.lblOpensWith.Size = new Size(63 /*0x3F*/, 13);
    this.lblOpensWith.TabIndex = 35;
    this.lblOpensWith.Text = "Opens With";
    this.Label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label11.BorderStyle = BorderStyle.FixedSingle;
    this.Label11.FlatStyle = FlatStyle.System;
    this.Label11.Location = new Point(16 /*0x10*/, 216);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(336, 1);
    this.Label11.TabIndex = 34;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(16 /*0x10*/, 223);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(64 /*0x40*/, 13);
    this.Label10.TabIndex = 33;
    this.Label10.Text = "Description:";
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).Location = new Point(88, 223);
    this.txtDescription.Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(260, 142);
    ((Control) this.txtDescription).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDateAdded.AutoSize = true;
    this.lblDateAdded.BackColor = Color.Transparent;
    this.lblDateAdded.Location = new Point(96 /*0x60*/, 176 /*0xB0*/);
    this.lblDateAdded.Name = "lblDateAdded";
    this.lblDateAdded.Size = new Size(122, 13);
    this.lblDateAdded.TabIndex = 31 /*0x1F*/;
    this.lblDateAdded.Text = "Tuesday, June -1, 2004";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(16 /*0x10*/, 176 /*0xB0*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(68, 13);
    this.Label9.TabIndex = 30;
    this.Label9.Text = "Date Added:";
    this.Label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label5.BorderStyle = BorderStyle.FixedSingle;
    this.Label5.FlatStyle = FlatStyle.System;
    this.Label5.Location = new Point(16 /*0x10*/, 168);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(336, 1);
    this.Label5.TabIndex = 29;
    this.lblSizeOnServer.AutoSize = true;
    this.lblSizeOnServer.BackColor = Color.Transparent;
    this.lblSizeOnServer.Location = new Point(96 /*0x60*/, 144 /*0x90*/);
    this.lblSizeOnServer.Name = "lblSizeOnServer";
    this.lblSizeOnServer.Size = new Size(13, 13);
    this.lblSizeOnServer.TabIndex = 28;
    this.lblSizeOnServer.Text = "0";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(16 /*0x10*/, 144 /*0x90*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(79, 13);
    this.Label8.TabIndex = 27;
    this.Label8.Text = "Size on server:";
    this.lblSize.AutoSize = true;
    this.lblSize.BackColor = Color.Transparent;
    this.lblSize.Location = new Point(96 /*0x60*/, 120);
    this.lblSize.Name = "lblSize";
    this.lblSize.Size = new Size(13, 13);
    this.lblSize.TabIndex = 26;
    this.lblSize.Text = "0";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(16 /*0x10*/, 120);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(30, 13);
    this.Label6.TabIndex = 25;
    this.Label6.Text = "Size:";
    this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label4.BorderStyle = BorderStyle.FixedSingle;
    this.Label4.FlatStyle = FlatStyle.System;
    this.Label4.Location = new Point(16 /*0x10*/, 112 /*0x70*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(336, 1);
    this.Label4.TabIndex = 24;
    this.lblFileType.AutoSize = true;
    this.lblFileType.BackColor = Color.Transparent;
    this.lblFileType.Location = new Point(96 /*0x60*/, 64 /*0x40*/);
    this.lblFileType.Name = "lblFileType";
    this.lblFileType.Size = new Size(50, 13);
    this.lblFileType.TabIndex = 23;
    this.lblFileType.Text = "File Type";
    this.pcAppIcon.BackColor = Color.Transparent;
    this.pcAppIcon.Image = (Image) componentResourceManager.GetObject("pcAppIcon.Image");
    this.pcAppIcon.Location = new Point(96 /*0x60*/, 88);
    this.pcAppIcon.Name = "pcAppIcon";
    this.pcAppIcon.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pcAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pcAppIcon.TabIndex = 22;
    this.pcAppIcon.TabStop = false;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(16 /*0x10*/, 88);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(65, 13);
    this.Label3.TabIndex = 21;
    this.Label3.Text = "Opens with:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(65, 13);
    this.Label2.TabIndex = 20;
    this.Label2.Text = "Type of file:";
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.BorderStyle = BorderStyle.FixedSingle;
    this.Label1.FlatStyle = FlatStyle.System;
    this.Label1.Location = new Point(16 /*0x10*/, 56);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(336, 1);
    this.Label1.TabIndex = 19;
    ((Control) this.txtFileName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFileName).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtFileName).BackColor = Color.White;
    ((Control) this.txtFileName).Location = new Point(88, 24);
    ((Control) this.txtFileName).Name = "txtFileName";
    ((Control) this.txtFileName).Size = new Size(260, 20);
    ((Control) this.txtFileName).TabIndex = 18;
    ((UltraControlBase) this.txtFileName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFileName).UseOsThemes = (DefaultableBoolean) 2;
    this.pcFileIcon.BackColor = Color.Transparent;
    this.pcFileIcon.Image = (Image) componentResourceManager.GetObject("pcFileIcon.Image");
    this.pcFileIcon.Location = new Point(24, 16 /*0x10*/);
    this.pcFileIcon.Name = "pcFileIcon";
    this.pcFileIcon.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pcFileIcon.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pcFileIcon.TabIndex = 17;
    this.pcFileIcon.TabStop = false;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboDocumentType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(368, 411);
    ((Control) this.cboDocumentType).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboDocumentType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocumentType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDocumentType).Location = new Point(103, 16 /*0x10*/);
    this.cboDocumentType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDocumentType).Name = "cboDocumentType";
    ((Control) this.cboDocumentType).Size = new Size(254, 21);
    ((Control) this.cboDocumentType).TabIndex = 37;
    ((UltraControlBase) this.cboDocumentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDocumentType).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(11, 16 /*0x10*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(86, 13);
    this.Label7.TabIndex = 21;
    this.Label7.Text = "Document Type:";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnCancel).Location = new Point(236, 448);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(58, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnApply).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnApply).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnApply).Location = new Point(304, 448);
    ((Control) this.btnApply).Name = "btnApply";
    ((Control) this.btnApply).Size = new Size(58, 24);
    ((Control) this.btnApply).TabIndex = 2;
    ((ControlBase) this.btnApply).Text = "&Apply";
    this.btnApply.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    appearance7.ImageHAlign = (HAlign) 2;
    appearance7.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnOK).Location = new Point(168, 448);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(58, 24);
    ((Control) this.btnOK).TabIndex = 3;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    appearance8.BackColor = Color.Transparent;
    appearance8.BorderColor = Color.Gray;
    ((UltraTabControlBase) this.UltraTabControl1).Appearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    ((UltraTabControlBase) this.UltraTabControl1).ClientAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Dock = DockStyle.Top;
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(370, 432);
    ((UltraTabControlBase) this.UltraTabControl1).Style = (UltraTabControlStyle) 12;
    ((Control) this.UltraTabControl1).TabIndex = 4;
    ((UltraTabControlBase) this.UltraTabControl1).TabOrientation = (TabOrientation) 1;
    appearance10.BackColor = Color.White;
    ultraTab1.Appearance = (AppearanceBase) appearance10;
    ultraTab1.Key = "General";
    ultraTab1.TabPage = this.UltraTabPageControl2;
    ultraTab1.Text = "General";
    ultraTab2.Key = "Details";
    ultraTab2.TabPage = this.UltraTabPageControl1;
    ultraTab2.Text = "Details";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(368, 411);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(370, 480);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnApply);
    this.Controls.Add((Control) this.btnCancel);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDocumentProperties);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Document Properties";
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.chkCopyAssociationForwardOnlyOnce).EndInit();
    ((ISupportInitialize) this.chkCopyForward).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.pcAppIcon).EndInit();
    ((ISupportInitialize) this.txtFileName).EndInit();
    ((ISupportInitialize) this.pcFileIcon).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.cboDocumentType).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnApply).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmDocumentProperties(Guid documentGuid)
  {
    this.Load += new EventHandler(this.frmDocumentProperties_Load);
    this.Closing += new CancelEventHandler(this.frmDocumentProperties_Closing);
    this.InitializeComponent();
    this._documentGuid = documentGuid;
  }

  public frmDocumentProperties()
  {
    this.Load += new EventHandler(this.frmDocumentProperties_Load);
    this.Closing += new CancelEventHandler(this.frmDocumentProperties_Closing);
    this.InitializeComponent();
  }

  public static frmDocumentProperties Create(Guid documentGuid)
  {
    return (frmDocumentProperties) ObjectFactory.Instance.CreateForm(typeof (frmDocumentProperties), new object[1]
    {
      (object) documentGuid
    });
  }

  private void frmDocumentProperties_Load(object sender, EventArgs e)
  {
    if (string.IsNullOrWhiteSpace(DefaultDatabase.ConnectionString))
      return;
    this._normalOpeningAppLabelLocation = this.lblOpensWith.Location;
    this._unknownOpeningAppLabelLocation = this.pcAppIcon.Location;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this._documentRow = Database.Instance.QueryText.PerformRowQuery("SELECT FileName, FileAssociation, OriginalFileSize, DATALENGTH(Document) -1 AS FileSizeOnServer, DateAdded, Description, CopyAssociationsForwardOnRenewal , tu.LastName +', '+ tu.FirstName as UserName, TypeGuid, isnull(CopyAssociationForwardOnlyOnce,0) as CopyAssociationForwardOnlyOnce FROM tblDocumentStore tds inner join tblUsers tu on tds.UserGuidOriginator = tu.UserGuid WHERE DocumentStoreGuid = @DocumentStoreGuid", (object) "DocumentStoreGuid", (object) this._documentGuid);
    if (this._documentRow == null)
      return;
    this.InitializeFormControls();
  }

  private void InitializeFormControls()
  {
    DataRow documentRow = this._documentRow;
    ((TextEditorControlBase) this.txtFileName).Text = Conversions.ToString(documentRow["FileName"]);
    this._originalFileExtension = new FileInfo(((TextEditorControlBase) this.txtFileName).Text).Extension;
    this.Text = $"{((TextEditorControlBase) this.txtFileName).Text} Properties";
    this.lblFileType.Text = Conversions.ToString(documentRow["FileAssociation"]);
    Label lblDateAdded = this.lblDateAdded;
    DateTime date = Conversions.ToDate(documentRow["DateAdded"]);
    string longDateString = date.ToLongDateString();
    date = Conversions.ToDate(documentRow["DateAdded"]);
    string shortTimeString = date.ToShortTimeString();
    string str = $"{longDateString}, {shortTimeString}";
    lblDateAdded.Text = str;
    int num1 = (int) Math.Round((double) Conversions.ToInteger(documentRow["OriginalFileSize"]) / 1024.0);
    int integer = documentRow.IsNull("FileSizeOnServer") ? 0 : Conversions.ToInteger(documentRow["FileSizeOnServer"]);
    int num2 = (int) Math.Round((double) integer / 1024.0);
    this.lblSize.Text = $"{num1.ToString("#,##0.00")} KB ({Conversions.ToInteger(documentRow["OriginalFileSize"])} bytes)";
    this.lblSizeOnServer.Text = $"{num2.ToString("#,##0.00")} KB ({integer} bytes)";
    string empty = string.Empty;
    if (!this._documentRow.IsNull("Description"))
      empty = Conversions.ToString(documentRow["Description"]);
    ((TextEditorControlBase) this.txtDescription).Text = empty;
    ((UltraToggleEditorBase) this.chkCopyForward).Checked = Conversions.ToBoolean(documentRow["CopyAssociationsForwardOnRenewal"]);
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked = Conversions.ToBoolean(documentRow["CopyAssociationForwardOnlyOnce"]);
    this.lblAddedBy.Text = Conversions.ToString(documentRow["UserName"]);
    this.SetupFileIcon();
    this.SetupOpeningProgramLabelAndImage();
    bool setting = SystemSettings.GetSetting<bool>("DocumentSystem.ShowDocumentTypes", false);
    ((UltraTabControlBase) this.UltraTabControl1).Tabs["Details"].Visible = setting;
    if (setting)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TypeGUID, TypeName FROM tblDocumentTypes");
      DataRow row = dataTable.NewRow();
      row[0] = (object) Guid.Empty;
      row[1] = (object) "";
      dataTable.Rows.InsertAt(row, 0);
      ((UltraGridBase) this.cboDocumentType).DataSource = (object) dataTable;
      ((UltraDropDownBase) this.cboDocumentType).DisplayMember = "TypeName";
      ((UltraDropDownBase) this.cboDocumentType).ValueMember = "TypeGuid";
      this.cboDocumentType.Value = RuntimeHelpers.GetObjectValue(documentRow["TypeGuid"]);
    }
    this.OnInitializeForm(this._documentGuid);
  }

  protected virtual void OnInitializeForm(Guid documentStoreGuid)
  {
  }

  private void SetupFileIcon()
  {
    this.pcFileIcon.Image = (Image) FileInfoEx.GetLargeIcon(((TextEditorControlBase) this.txtFileName).Text).ToBitmap();
  }

  private void SetupOpeningProgramLabelAndImage()
  {
    this.lblOpensWith.Text = FileInfoEx.GetOpeningApplicationName(((TextEditorControlBase) this.txtFileName).Text);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblOpensWith.Text, "Unknown application", false) == 0)
      this.lblOpensWith.Location = this._unknownOpeningAppLabelLocation;
    else
      this.lblOpensWith.Location = this._normalOpeningAppLabelLocation;
    this.pcAppIcon.Image = (Image) FileInfoEx.GetOpeningApplicationIcon(((TextEditorControlBase) this.txtFileName).Text).ToBitmap();
  }

  private static string GetFileAssociation(string fileName) => FileInfoEx.GetTypeName(fileName);

  private bool DocumentPropertiesHasChanges
  {
    get
    {
      bool propertiesHasChanges = false;
      DataRow documentRow = this._documentRow;
      string empty = string.Empty;
      if (!this._documentRow.IsNull("Description"))
        empty = Conversions.ToString(documentRow["Description"]);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(documentRow["FileName"]), ((TextEditorControlBase) this.txtFileName).Text, false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty, ((TextEditorControlBase) this.txtDescription).Text, false) != 0 || Conversions.ToBoolean(documentRow["CopyAssociationsForwardOnRenewal"]) != ((UltraToggleEditorBase) this.chkCopyForward).Checked || Conversions.ToBoolean(documentRow["CopyAssociationForwardOnlyOnce"]) != ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(documentRow["FileAssociation"]), this.lblFileType.Text, false) != 0 || this.cboDocumentType.Value != null && !object.Equals(RuntimeHelpers.GetObjectValue(documentRow["TypeGuid"]), RuntimeHelpers.GetObjectValue(this.cboDocumentType.Value)))
        propertiesHasChanges = true;
      return propertiesHasChanges;
    }
  }

  private bool ValidateDocumentProperties()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtDescription).Text))
    {
      this.ErrorProvider1.SetError((Control) this.txtDescription, "You must enter a value for the description.");
      flag = false;
    }
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtFileName).Text))
    {
      this.ErrorProvider1.SetError((Control) this.txtFileName, "You must enter a value for the file name.");
      flag = false;
    }
    return flag;
  }

  private bool ApplyChanges()
  {
    if (this.DocumentPropertiesHasChanges && this.ValidateDocumentProperties())
      this.CheckForFileExtensionChange();
    if (this.ValidateDocumentProperties())
    {
      if (this.DocumentPropertiesHasChanges)
      {
        DataRow documentRow = this._documentRow;
        documentRow["FileName"] = (object) ((TextEditorControlBase) this.txtFileName).Text;
        documentRow["Description"] = (object) ((TextEditorControlBase) this.txtDescription).Text;
        documentRow["FileAssociation"] = (object) this.lblFileType.Text;
        documentRow["CopyAssociationsForwardOnRenewal"] = (object) ((UltraToggleEditorBase) this.chkCopyForward).Checked;
        documentRow["CopyAssociationForwardOnlyOnce"] = (object) ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked;
        documentRow["TypeGuid"] = this.cboDocumentType.Value != null ? RuntimeHelpers.GetObjectValue(this.cboDocumentType.Value) : (object) DBNull.Value;
        Guid documentGuid = this._documentGuid;
        string text1 = ((TextEditorControlBase) this.txtFileName).Text;
        string text2 = ((TextEditorControlBase) this.txtDescription).Text;
        string fileAssociation = frmDocumentProperties.GetFileAssociation(((TextEditorControlBase) this.txtFileName).Text);
        int num1 = ((UltraToggleEditorBase) this.chkCopyForward).Checked ? 1 : 0;
        object obj = this.cboDocumentType.Value;
        Guid typeGuid = obj != null ? (Guid) obj : new Guid();
        int num2 = ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked ? 1 : 0;
        DocumentManager.UpdateDocumentProperties(documentGuid, text1, text2, fileAssociation, num1 != 0, typeGuid, num2 != 0);
        this._appliedChanges = true;
      }
      this.OnChangesSaved(this._documentGuid);
    }
    this.UpdateApplyButtonEnabledStatus();
    bool flag;
    return flag;
  }

  protected virtual void OnChangesSaved(Guid documentStoreGuid)
  {
  }

  private void frmDocumentProperties_Closing(object sender, CancelEventArgs e)
  {
    if (this.DocumentPropertiesHasChanges)
    {
      switch (MessageBox.Show("Would you like to save your changes?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          if (!this.ApplyChanges())
          {
            e.Cancel = true;
            break;
          }
          break;
      }
    }
    if (e.Cancel || !this._appliedChanges)
      return;
    this._appliedChanges = false;
    this.DialogResult = DialogResult.OK;
  }

  private void txtFileName_TextChanged(object sender, EventArgs e)
  {
    this.UpdateApplyButtonEnabledStatus();
  }

  private void txtDescription_TextChanged(object sender, EventArgs e)
  {
    this.UpdateApplyButtonEnabledStatus();
  }

  private void UpdateApplyButtonEnabledStatus()
  {
    ((Control) this.btnApply).Enabled = this.DocumentPropertiesHasChanges;
  }

  private void btnApply_Click(object sender, EventArgs e) => this.ApplyChanges();

  private void btnOK_Click(object sender, EventArgs e)
  {
    this.ApplyChanges();
    this.DialogResult = DialogResult.OK;
  }

  private void CheckForFileExtensionChange()
  {
    FileInfo fileInfo = new FileInfo(((TextEditorControlBase) this.txtFileName).Text);
    if (this._originalFileExtension.Equals(fileInfo.Extension))
      return;
    switch (MessageBox.Show($"If you change a filename extension, the file maybe become unusable.{"\r\n"}Are you sure you want to change it?", "Rename", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
    {
      case DialogResult.Yes:
        this._originalFileExtension = fileInfo.Extension;
        this._documentRow["FileAssociation"] = (object) frmDocumentProperties.GetFileAssociation(((TextEditorControlBase) this.txtFileName).Text);
        this.SetupFileIcon();
        this.SetupOpeningProgramLabelAndImage();
        break;
      case DialogResult.No:
        ((TextEditorControlBase) this.txtFileName).Text = Conversions.ToString(this._documentRow["FileName"]);
        break;
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void chkCopyForward_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateApplyButtonEnabledStatus();
    if (!((UltraToggleEditorBase) this.chkCopyForward).Checked)
      return;
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked = false;
  }

  private void cboDocumentType_ValueChanged(object sender, EventArgs e)
  {
    this.UpdateApplyButtonEnabledStatus();
  }

  private void chkCopyAssociationForwardOnlyOnce_CheckedChanged(object sender, EventArgs e)
  {
    this.UpdateApplyButtonEnabledStatus();
    if (!((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked)
      return;
    ((UltraToggleEditorBase) this.chkCopyForward).Checked = false;
  }
}
