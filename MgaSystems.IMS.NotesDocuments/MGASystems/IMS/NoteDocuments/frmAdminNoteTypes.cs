// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmAdminNoteTypes
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureResource("{1BE36FB6-AEBC-47D7-AFC5-A3376B3CD40D}", "Edit Admin Note Types Form", "Allows user to Edit Admin Note Types Form.", "Note System")]
[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmAdminNoteTypes : Form
{
  private IContainer components;
  private const string LoadingText = " [Loading Please Wait...]";
  private DataView dvNoteType;
  internal const string _CanEditAutomationCode = "{1BE36FB6-AEBC-47D7-AFC5-A3376B3CD40D}";

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("", -1);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("", -1);
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
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
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.BackgroundWorker = new BackgroundWorker();
    this.txtCurrentNoteType = new MGATextBox();
    this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
    this.ResetMenuItem = new ToolStripMenuItem();
    this.daPrefillingOptions = DefaultDatabase.CreateDataAdapter();
    this.cboDiaryRecipients = new MGAComboBox();
    this.txtSubject = new MGATextBox();
    this.txtBody = new MGATextBox();
    this.lstNoteTypes = new MGAListBox();
    this.txtDueInDays = new MGATextBox();
    this.cboDiaryStart = new MGAComboBox();
    this.cbPopup = new MGACheckBox();
    this.grpNoteDefaults = new MGAGroupBox();
    this.chkDisabled = new MGACheckBox();
    this.cbCopyForward = new MGACheckBox();
    this.txtAutomationCode = new MGATextBox();
    this.Label4 = new Label();
    this.chkAllowUpdatesOnTagData = new MGACheckBox();
    this.rdoDate = new RadioButton();
    this.rdoField = new RadioButton();
    this.txtTagLabel = new MGATextBox();
    this.lblTagLabel = new Label();
    this.lblTagType = new Label();
    this.chkAllowTagData = new MGACheckBox();
    this.cbRequiredToBind = new MGACheckBox();
    this.cbRequiredToQuote = new MGACheckBox();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.RequiredFieldValidator1 = new RequiredFieldValidator(this.components);
    this.DsGlobalNotePrefillingOptions = new dsGlobalNotePrefillingOptions();
    this.chkHideTypes = new MGACheckBox();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    ((ISupportInitialize) this.txtCurrentNoteType).BeginInit();
    this.ContextMenuStrip1.SuspendLayout();
    ((ISupportInitialize) this.cboDiaryRecipients).BeginInit();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    ((ISupportInitialize) this.txtBody).BeginInit();
    ((ISupportInitialize) this.lstNoteTypes).BeginInit();
    ((ISupportInitialize) this.txtDueInDays).BeginInit();
    ((ISupportInitialize) this.cboDiaryStart).BeginInit();
    ((ISupportInitialize) this.cbPopup).BeginInit();
    ((ISupportInitialize) this.grpNoteDefaults).BeginInit();
    ((Control) this.grpNoteDefaults).SuspendLayout();
    ((ISupportInitialize) this.chkDisabled).BeginInit();
    ((ISupportInitialize) this.cbCopyForward).BeginInit();
    ((ISupportInitialize) this.txtAutomationCode).BeginInit();
    ((ISupportInitialize) this.chkAllowUpdatesOnTagData).BeginInit();
    ((ISupportInitialize) this.txtTagLabel).BeginInit();
    ((ISupportInitialize) this.chkAllowTagData).BeginInit();
    ((ISupportInitialize) this.cbRequiredToBind).BeginInit();
    ((ISupportInitialize) this.cbRequiredToQuote).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.RequiredFieldValidator1).BeginInit();
    this.DsGlobalNotePrefillingOptions.BeginInit();
    ((ISupportInitialize) this.chkHideTypes).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(38, 145);
    label1.Name = "Label6";
    label1.Size = new Size(70, 13);
    label1.TabIndex = 8;
    label1.Text = "Due In Days:";
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(20, 115);
    label2.Name = "Label5";
    label2.Size = new Size(88, 13);
    label2.TabIndex = 6;
    label2.Text = "Diary Recipients:";
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(61, 26);
    label3.Name = "Label3";
    label3.Size = new Size(47, 13);
    label3.TabIndex = 0;
    label3.Text = "Subject:";
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(73, 50);
    label4.Name = "Label2";
    label4.Size = new Size(35, 13);
    label4.TabIndex = 2;
    label4.Text = "Body:";
    label5.AutoSize = true;
    label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    label5.Location = new Point(11, 6);
    label5.Name = "Label1";
    label5.Size = new Size(494, 13);
    label5.TabIndex = 0;
    label5.Text = "Use this screen to administer the various note types available to notes within the IMS.";
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(252, 145);
    label6.Name = "Label7";
    label6.Size = new Size(63 /*0x3F*/, 13);
    label6.TabIndex = 11;
    label6.Text = "Diary Start:";
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.DbSaveUI1.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(585, 341);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(120, 40);
    this.DbSaveUI1.TabIndex = 4;
    this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
    this.DbSelectCommand1.CommandText = "dbo.NoteSystem_LoadNotePrefillingOptions";
    this.DbSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand1.Connection = this.cn;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    ((Control) this.txtCurrentNoteType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.LightYellow;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCurrentNoteType).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtCurrentNoteType).BackColor = Color.LightYellow;
    ((Control) this.txtCurrentNoteType).ContextMenuStrip = this.ContextMenuStrip1;
    ((Control) this.txtCurrentNoteType).Location = new Point(185, 25);
    ((Control) this.txtCurrentNoteType).Name = "txtCurrentNoteType";
    ((Control) this.txtCurrentNoteType).Size = new Size(508, 20);
    ((Control) this.txtCurrentNoteType).TabIndex = 2;
    ((UltraControlBase) this.txtCurrentNoteType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCurrentNoteType).UseOsThemes = (DefaultableBoolean) 2;
    this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ResetMenuItem
    });
    this.ContextMenuStrip1.Name = "ContextMenuStrip1";
    this.ContextMenuStrip1.Size = new Size(103, 26);
    this.ResetMenuItem.Name = "ResetMenuItem";
    this.ResetMenuItem.Size = new Size(102, 22);
    this.ResetMenuItem.Text = "Reset";
    this.daPrefillingOptions.SelectCommand = this.DbSelectCommand1;
    this.daPrefillingOptions.TableMappings.AddRange(new DataTableMapping[3]
    {
      new DataTableMapping("Table", "lstNoteTypes", new DataColumnMapping[10]
      {
        new DataColumnMapping("NoteTypeID", "NoteTypeID"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("DefaultNoteSubject", "DefaultNoteSubject"),
        new DataColumnMapping("DefaultNoteBody", "DefaultNoteBody"),
        new DataColumnMapping("DefaultNoteDiaryRecipientId", "DefaultNoteDiaryRecipientId"),
        new DataColumnMapping("DefaultNoteDueInDays", "DefaultNoteDueInDays"),
        new DataColumnMapping("DefaultNoteIsPopup", "DefaultNoteIsPopup"),
        new DataColumnMapping("DefaultNoteDiaryStartId", "DefaultNoteDiaryStartId"),
        new DataColumnMapping("RequiredToQuote", "RequiredToQuote"),
        new DataColumnMapping("RequiredToBind", "RequiredToBind")
      }),
      new DataTableMapping("Table1", "lstNoteAutomationRecipients", new DataColumnMapping[2]
      {
        new DataColumnMapping("NoteAutomationRecipientID", "NoteAutomationRecipientID"),
        new DataColumnMapping("RecipientName", "RecipientName")
      }),
      new DataTableMapping("Table2", "lstDiaryStartTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("DiaryStartTypeID", "DiaryStartTypeID"),
        new DataColumnMapping("Description", "Description")
      })
    });
    ((Control) this.cboDiaryRecipients).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.cboDiaryRecipients).ContextMenuStrip = this.ContextMenuStrip1;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.LightGray;
    this.cboDiaryRecipients.DisplayLayout.Appearance = (AppearanceBase) appearance2;
    this.cboDiaryRecipients.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    this.cboDiaryRecipients.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboDiaryRecipients.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDiaryRecipients.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance3.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboDiaryRecipients.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance3;
    appearance4.BorderColor = Color.White;
    this.cboDiaryRecipients.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    this.cboDiaryRecipients.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance5.ForeColor = Color.Black;
    this.cboDiaryRecipients.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboDiaryRecipients.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.cboDiaryRecipients.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDiaryRecipients).Location = new Point(114, 111);
    ((Control) this.cboDiaryRecipients).Name = "cboDiaryRecipients";
    ((Control) this.cboDiaryRecipients).Size = new Size(394, 21);
    ((Control) this.cboDiaryRecipients).TabIndex = 7;
    ((UltraControlBase) this.cboDiaryRecipients).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDiaryRecipients).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtSubject).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtSubject).BackColor = Color.White;
    ((Control) this.txtSubject).ContextMenuStrip = this.ContextMenuStrip1;
    ((Control) this.txtSubject).Location = new Point(114, 22);
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(394, 20);
    ((Control) this.txtSubject).TabIndex = 1;
    ((UltraControlBase) this.txtSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubject).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtBody).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBody).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtBody).BackColor = Color.White;
    ((Control) this.txtBody).ContextMenuStrip = this.ContextMenuStrip1;
    ((Control) this.txtBody).Location = new Point(114, 51);
    this.txtBody.Multiline = true;
    ((Control) this.txtBody).Name = "txtBody";
    ((Control) this.txtBody).Size = new Size(394, 51);
    ((Control) this.txtBody).TabIndex = 3;
    ((UltraControlBase) this.txtBody).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBody).UseOsThemes = (DefaultableBoolean) 2;
    this.lstNoteTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstNoteTypes.BackColor = SystemColors.Window;
    this.lstNoteTypes.FormattingEnabled = true;
    this.lstNoteTypes.IntegralHeight = false;
    this.lstNoteTypes.Location = new Point(14, 25);
    this.lstNoteTypes.Name = "lstNoteTypes";
    this.lstNoteTypes.Size = new Size(165, 341);
    this.lstNoteTypes.TabIndex = 1;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDueInDays).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtDueInDays).BackColor = Color.White;
    ((Control) this.txtDueInDays).ContextMenuStrip = this.ContextMenuStrip1;
    ((Control) this.txtDueInDays).Location = new Point(114, 141);
    ((Control) this.txtDueInDays).Name = "txtDueInDays";
    ((Control) this.txtDueInDays).Size = new Size(37, 20);
    ((Control) this.txtDueInDays).TabIndex = 9;
    ((UltraControlBase) this.txtDueInDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDueInDays).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboDiaryStart).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.cboDiaryStart).ContextMenuStrip = this.ContextMenuStrip1;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.LightGray;
    this.cboDiaryStart.DisplayLayout.Appearance = (AppearanceBase) appearance9;
    this.cboDiaryStart.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    this.cboDiaryStart.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboDiaryStart.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDiaryStart.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    appearance10.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance10.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboDiaryStart.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.White;
    this.cboDiaryStart.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    this.cboDiaryStart.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance12.ForeColor = Color.Black;
    this.cboDiaryStart.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboDiaryStart.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboDiaryStart.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDiaryStart).Location = new Point(324, 141);
    ((Control) this.cboDiaryStart).Name = "cboDiaryStart";
    ((Control) this.cboDiaryStart).Size = new Size(184, 21);
    ((Control) this.cboDiaryStart).TabIndex = 12;
    ((UltraControlBase) this.cboDiaryStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDiaryStart).UseOsThemes = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.cbPopup).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.cbPopup).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.cbPopup).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.cbPopup).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.cbPopup).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.cbPopup).Location = new Point(178, 141);
    ((Control) this.cbPopup).Name = "cbPopup";
    ((Control) this.cbPopup).Size = new Size(57, 20);
    ((Control) this.cbPopup).TabIndex = 10;
    ((UltraToggleEditorBase) this.cbPopup).Text = "Popup";
    ((Control) this.grpNoteDefaults).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance14.BackColor = Color.FromArgb(239, 247, 253);
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpNoteDefaults.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.chkDisabled);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.cbCopyForward);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.txtAutomationCode);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.Label4);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.chkAllowUpdatesOnTagData);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.rdoDate);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.rdoField);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.txtTagLabel);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.lblTagLabel);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.lblTagType);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.chkAllowTagData);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.cbRequiredToBind);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.cbRequiredToQuote);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) label3);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.cbPopup);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.cboDiaryStart);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.txtSubject);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.txtDueInDays);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) label4);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) label6);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.txtBody);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) label2);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) this.cboDiaryRecipients);
    ((Control) this.grpNoteDefaults).Controls.Add((Control) label1);
    ((Control) this.grpNoteDefaults).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    appearance15.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpNoteDefaults.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.grpNoteDefaults).Location = new Point(185, 51);
    ((Control) this.grpNoteDefaults).Name = "grpNoteDefaults";
    ((Control) this.grpNoteDefaults).Size = new Size(530, 284);
    ((Control) this.grpNoteDefaults).TabIndex = 3;
    this.grpNoteDefaults.Text = "You can also optionally set up defaults for notes of the selected type.";
    this.grpNoteDefaults.ViewStyle = (GroupBoxViewStyle) 2;
    appearance16.BorderColor = Color.Gray;
    appearance16.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisabled).Appearance = (AppearanceBase) appearance16;
    ((UltraToggleEditorBase) this.chkDisabled).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisabled).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisabled).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkDisabled).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisabled).Location = new Point(168, 257);
    ((Control) this.chkDisabled).Name = "chkDisabled";
    ((Control) this.chkDisabled).Size = new Size(67, 20);
    ((Control) this.chkDisabled).TabIndex = 26;
    ((UltraToggleEditorBase) this.chkDisabled).Text = "Disabled";
    appearance17.BorderColor = Color.Gray;
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.cbCopyForward).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.cbCopyForward).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.cbCopyForward).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.cbCopyForward).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.cbCopyForward).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.cbCopyForward).Location = new Point((int) byte.MaxValue, 257);
    ((Control) this.cbCopyForward).Name = "cbCopyForward";
    ((Control) this.cbCopyForward).Size = new Size(226, 20);
    ((Control) this.cbCopyForward).TabIndex = 25;
    ((UltraToggleEditorBase) this.cbCopyForward).Text = "Copy association forward on renewal";
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.Gray;
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAutomationCode).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.txtAutomationCode).BackColor = Color.White;
    ((Control) this.txtAutomationCode).ContextMenuStrip = this.ContextMenuStrip1;
    ((Control) this.txtAutomationCode).Location = new Point(114, 257);
    ((TextEditorControlBase) this.txtAutomationCode).MaxLength = 5;
    ((Control) this.txtAutomationCode).Name = "txtAutomationCode";
    ((Control) this.txtAutomationCode).Size = new Size(48 /*0x30*/, 20);
    ((Control) this.txtAutomationCode).TabIndex = 24;
    ((UltraControlBase) this.txtAutomationCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAutomationCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(14, 260);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(94, 13);
    this.Label4.TabIndex = 23;
    this.Label4.Text = "Automation Code:";
    appearance19.BorderColor = Color.Gray;
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAllowUpdatesOnTagData).Location = new Point(67, 225);
    ((Control) this.chkAllowUpdatesOnTagData).Name = "chkAllowUpdatesOnTagData";
    ((Control) this.chkAllowUpdatesOnTagData).Size = new Size(168, 20);
    ((Control) this.chkAllowUpdatesOnTagData).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).Text = "Allow Updates on Tag Data";
    this.rdoDate.AutoSize = true;
    this.rdoDate.BackColor = Color.Transparent;
    this.rdoDate.Location = new Point(391, 198);
    this.rdoDate.Name = "rdoDate";
    this.rdoDate.Size = new Size(48 /*0x30*/, 17);
    this.rdoDate.TabIndex = 21;
    this.rdoDate.Text = "Date";
    this.rdoDate.UseVisualStyleBackColor = false;
    this.rdoField.AutoSize = true;
    this.rdoField.BackColor = Color.Transparent;
    this.rdoField.Checked = true;
    this.rdoField.Location = new Point(324, 198);
    this.rdoField.Name = "rdoField";
    this.rdoField.Size = new Size(47, 17);
    this.rdoField.TabIndex = 20;
    this.rdoField.TabStop = true;
    this.rdoField.Text = "Field";
    this.rdoField.UseVisualStyleBackColor = false;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.Gray;
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTagLabel).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtTagLabel).BackColor = Color.White;
    ((Control) this.txtTagLabel).ContextMenuStrip = this.ContextMenuStrip1;
    ((Control) this.txtTagLabel).Location = new Point(324, 225);
    ((Control) this.txtTagLabel).Name = "txtTagLabel";
    ((Control) this.txtTagLabel).Size = new Size(157, 20);
    ((Control) this.txtTagLabel).TabIndex = 19;
    ((UltraControlBase) this.txtTagLabel).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTagLabel).UseOsThemes = (DefaultableBoolean) 2;
    this.lblTagLabel.AutoSize = true;
    this.lblTagLabel.BackColor = Color.Transparent;
    this.lblTagLabel.Location = new Point(252, 229);
    this.lblTagLabel.Name = "lblTagLabel";
    this.lblTagLabel.Size = new Size(57, 13);
    this.lblTagLabel.TabIndex = 18;
    this.lblTagLabel.Text = "Tag Label:";
    this.lblTagType.AutoSize = true;
    this.lblTagType.BackColor = Color.Transparent;
    this.lblTagType.Location = new Point(252, 198);
    this.lblTagType.Name = "lblTagType";
    this.lblTagType.Size = new Size(56, 13);
    this.lblTagType.TabIndex = 16 /*0x10*/;
    this.lblTagType.Text = "Tag Type:";
    appearance21.BorderColor = Color.Gray;
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAllowTagData).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkAllowTagData).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAllowTagData).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkAllowTagData).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkAllowTagData).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkAllowTagData).Location = new Point(114, 196);
    ((Control) this.chkAllowTagData).Name = "chkAllowTagData";
    ((Control) this.chkAllowTagData).Size = new Size(121, 20);
    ((Control) this.chkAllowTagData).TabIndex = 15;
    ((UltraToggleEditorBase) this.chkAllowTagData).Text = "Allow Tag Data";
    appearance22.BorderColor = Color.Gray;
    appearance22.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.cbRequiredToBind).Appearance = (AppearanceBase) appearance22;
    ((UltraToggleEditorBase) this.cbRequiredToBind).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.cbRequiredToBind).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.cbRequiredToBind).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.cbRequiredToBind).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.cbRequiredToBind).Location = new Point((int) byte.MaxValue, 170);
    ((Control) this.cbRequiredToBind).Name = "cbRequiredToBind";
    ((Control) this.cbRequiredToBind).Size = new Size(126, 20);
    ((Control) this.cbRequiredToBind).TabIndex = 14;
    ((UltraToggleEditorBase) this.cbRequiredToBind).Text = "Required To Bind";
    appearance23.BorderColor = Color.Gray;
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.cbRequiredToQuote).Location = new Point(111, 170);
    ((Control) this.cbRequiredToQuote).Name = "cbRequiredToQuote";
    ((Control) this.cbRequiredToQuote).Size = new Size(124, 20);
    ((Control) this.cbRequiredToQuote).TabIndex = 13;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).Text = "Required To Quote";
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    this.RequiredFieldValidator1.ControlToValidate = (Control) this.txtCurrentNoteType;
    this.RequiredFieldValidator1.Enabled = true;
    this.RequiredFieldValidator1.FieldToValidate = "Text";
    this.DsGlobalNotePrefillingOptions.DataSetName = "dsGlobalNotePrefillingOptions";
    this.DsGlobalNotePrefillingOptions.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.chkHideTypes).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance24.BorderColor = Color.Gray;
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideTypes).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkHideTypes).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideTypes).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideTypes).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkHideTypes).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideTypes).Location = new Point(14, 372);
    ((Control) this.chkHideTypes).Name = "chkHideTypes";
    ((Control) this.chkHideTypes).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.chkHideTypes).TabIndex = 27;
    ((UltraToggleEditorBase) this.chkHideTypes).Text = "Hide Disabled Types";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(721, 395);
    this.Controls.Add((Control) this.chkHideTypes);
    this.Controls.Add((Control) this.grpNoteDefaults);
    this.Controls.Add((Control) this.txtCurrentNoteType);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) this.lstNoteTypes);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmAdminNoteTypes);
    this.ShowIcon = false;
    this.Text = "Note Types Administration";
    ((ISupportInitialize) this.txtCurrentNoteType).EndInit();
    this.ContextMenuStrip1.ResumeLayout(false);
    ((ISupportInitialize) this.cboDiaryRecipients).EndInit();
    ((ISupportInitialize) this.txtSubject).EndInit();
    ((ISupportInitialize) this.txtBody).EndInit();
    ((ISupportInitialize) this.lstNoteTypes).EndInit();
    ((ISupportInitialize) this.txtDueInDays).EndInit();
    ((ISupportInitialize) this.cboDiaryStart).EndInit();
    ((ISupportInitialize) this.cbPopup).EndInit();
    ((ISupportInitialize) this.grpNoteDefaults).EndInit();
    ((Control) this.grpNoteDefaults).ResumeLayout(false);
    ((Control) this.grpNoteDefaults).PerformLayout();
    ((ISupportInitialize) this.chkDisabled).EndInit();
    ((ISupportInitialize) this.cbCopyForward).EndInit();
    ((ISupportInitialize) this.txtAutomationCode).EndInit();
    ((ISupportInitialize) this.chkAllowUpdatesOnTagData).EndInit();
    ((ISupportInitialize) this.txtTagLabel).EndInit();
    ((ISupportInitialize) this.chkAllowTagData).EndInit();
    ((ISupportInitialize) this.cbRequiredToBind).EndInit();
    ((ISupportInitialize) this.cbRequiredToQuote).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.RequiredFieldValidator1).EndInit();
    this.DsGlobalNotePrefillingOptions.EndInit();
    ((ISupportInitialize) this.chkHideTypes).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdminNoteTypes()
  {
    this.Load += new EventHandler(this.AdminNotePrefillForm_Load);
    this.InitializeComponent();
    Utility.SetDataAdapterConnections(this.daPrefillingOptions, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingEdit);
      QueryRowCountHandler queryRowCountHandler = new QueryRowCountHandler(this.DbSaveUI1_QueryRowCount);
      EventHandler eventHandler1 = new EventHandler(this.DbSaveUI1_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.DbSaveUI1_UIStateChanged);
      EventHandler eventHandler3 = new EventHandler(this.DbSaveUI1_ClickedNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      EventHandler eventHandler4 = new EventHandler(this.DbSaveUI1_ClickedDelete);
      EventHandler eventHandler5 = new EventHandler(this.DbSaveUI1_ClickedSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.ClickingEdit -= cancelEventHandler1;
        dbSaveUi1_1.QueryRowCount -= queryRowCountHandler;
        dbSaveUi1_1.ClickedCancel -= eventHandler1;
        dbSaveUi1_1.UIStateChanged -= eventHandler2;
        dbSaveUi1_1.ClickedNew -= eventHandler3;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler2;
        dbSaveUi1_1.ClickedDelete -= eventHandler4;
        dbSaveUi1_1.ClickedSave -= eventHandler5;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler3;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.ClickingEdit += cancelEventHandler1;
      dbSaveUi1_2.QueryRowCount += queryRowCountHandler;
      dbSaveUi1_2.ClickedCancel += eventHandler1;
      dbSaveUi1_2.UIStateChanged += eventHandler2;
      dbSaveUi1_2.ClickedNew += eventHandler3;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler2;
      dbSaveUi1_2.ClickedDelete += eventHandler4;
      dbSaveUi1_2.ClickedSave += eventHandler5;
      dbSaveUi1_2.ClickingSave += cancelEventHandler3;
    }
  }

  [field: AccessedThroughProperty("cn")]
  internal virtual DbConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  internal virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BackgroundWorker BackgroundWorker
  {
    get => this._BackgroundWorker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_DoWork);
      BackgroundWorker backgroundWorker1 = this._BackgroundWorker;
      if (backgroundWorker1 != null)
      {
        backgroundWorker1.RunWorkerCompleted -= completedEventHandler;
        backgroundWorker1.DoWork -= workEventHandler;
      }
      this._BackgroundWorker = value;
      BackgroundWorker backgroundWorker2 = this._BackgroundWorker;
      if (backgroundWorker2 == null)
        return;
      backgroundWorker2.RunWorkerCompleted += completedEventHandler;
      backgroundWorker2.DoWork += workEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCurrentNoteType")]
  internal virtual MGATextBox txtCurrentNoteType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ContextMenuStrip1")]
  internal virtual ContextMenuStrip ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem ResetMenuItem
  {
    get => this._ResetMenuItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ResetMenuItem_Click);
      ToolStripMenuItem resetMenuItem1 = this._ResetMenuItem;
      if (resetMenuItem1 != null)
        resetMenuItem1.Click -= eventHandler;
      this._ResetMenuItem = value;
      ToolStripMenuItem resetMenuItem2 = this._ResetMenuItem;
      if (resetMenuItem2 == null)
        return;
      resetMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("daPrefillingOptions")]
  internal virtual DbDataAdapter daPrefillingOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGlobalNotePrefillingOptions")]
  internal virtual dsGlobalNotePrefillingOptions DsGlobalNotePrefillingOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDiaryRecipients")]
  internal virtual MGAComboBox cboDiaryRecipients { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubject")]
  internal virtual MGATextBox txtSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBody")]
  internal virtual MGATextBox txtBody { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAListBox lstNoteTypes
  {
    get => this._lstNoteTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstNoteTypes_SelectedIndexChanged);
      MGAListBox lstNoteTypes1 = this._lstNoteTypes;
      if (lstNoteTypes1 != null)
        lstNoteTypes1.SelectedIndexChanged -= eventHandler;
      this._lstNoteTypes = value;
      MGAListBox lstNoteTypes2 = this._lstNoteTypes;
      if (lstNoteTypes2 == null)
        return;
      lstNoteTypes2.SelectedIndexChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtDueInDays")]
  internal virtual MGATextBox txtDueInDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDiaryStart")]
  internal virtual MGAComboBox cboDiaryStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbPopup")]
  internal virtual MGACheckBox cbPopup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpNoteDefaults")]
  internal virtual MGAGroupBox grpNoteDefaults { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ErrorProvider1")]
  internal virtual ErrorProvider ErrorProvider1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RequiredFieldValidator1")]
  internal virtual RequiredFieldValidator RequiredFieldValidator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbRequiredToBind")]
  internal virtual MGACheckBox cbRequiredToBind { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbRequiredToQuote")]
  internal virtual MGACheckBox cbRequiredToQuote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkAllowTagData
  {
    get => this._chkAllowTagData;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkAllowTagData_CheckedChanged);
      MGACheckBox chkAllowTagData1 = this._chkAllowTagData;
      if (chkAllowTagData1 != null)
        ((UltraToggleEditorBase) chkAllowTagData1).CheckedChanged -= eventHandler;
      this._chkAllowTagData = value;
      MGACheckBox chkAllowTagData2 = this._chkAllowTagData;
      if (chkAllowTagData2 == null)
        return;
      ((UltraToggleEditorBase) chkAllowTagData2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtTagLabel")]
  internal virtual MGATextBox txtTagLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rdoDate")]
  internal virtual RadioButton rdoDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rdoField")]
  internal virtual RadioButton rdoField { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTagLabel")]
  internal virtual Label lblTagLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTagType")]
  internal virtual Label lblTagType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkAllowUpdatesOnTagData")]
  internal virtual MGACheckBox chkAllowUpdatesOnTagData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtAutomationCode
  {
    get => this._txtAutomationCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtAutomationCode_Leave);
      MGATextBox txtAutomationCode1 = this._txtAutomationCode;
      if (txtAutomationCode1 != null)
        ((Control) txtAutomationCode1).Leave -= eventHandler;
      this._txtAutomationCode = value;
      MGATextBox txtAutomationCode2 = this._txtAutomationCode;
      if (txtAutomationCode2 == null)
        return;
      ((Control) txtAutomationCode2).Leave += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbCopyForward")]
  internal virtual MGACheckBox cbCopyForward { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkDisabled
  {
    get => this._chkDisabled;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkDisabled_CheckedValueChanged);
      MGACheckBox chkDisabled1 = this._chkDisabled;
      if (chkDisabled1 != null)
        ((UltraToggleEditorBase) chkDisabled1).CheckedValueChanged -= eventHandler;
      this._chkDisabled = value;
      MGACheckBox chkDisabled2 = this._chkDisabled;
      if (chkDisabled2 == null)
        return;
      ((UltraToggleEditorBase) chkDisabled2).CheckedValueChanged += eventHandler;
    }
  }

  internal virtual MGACheckBox chkHideTypes
  {
    get => this._chkHideTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideTypes_CheckedChanged);
      MGACheckBox chkHideTypes1 = this._chkHideTypes;
      if (chkHideTypes1 != null)
        ((UltraToggleEditorBase) chkHideTypes1).CheckedChanged -= eventHandler;
      this._chkHideTypes = value;
      MGACheckBox chkHideTypes2 = this._chkHideTypes;
      if (chkHideTypes2 == null)
        return;
      ((UltraToggleEditorBase) chkHideTypes2).CheckedChanged += eventHandler;
    }
  }

  private static void AttachComboListSource(
    MGASimpleComboBox combo,
    object dataSource,
    string valueMember,
    string displayMember)
  {
    ((UltraDropDownBase) combo).ValueMember = valueMember;
    ((UltraDropDownBase) combo).DisplayMember = displayMember;
    ((UltraGridBase) combo).DataSource = RuntimeHelpers.GetObjectValue(dataSource);
    foreach (UltraGridColumn column in combo.DisplayLayout.Bands[0].Columns)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) column.Header).Caption, displayMember, false) != 0)
        column.Hidden = true;
    }
  }

  private static void AttachTextBoxDataSource(
    MGATextBox textBox,
    DataView dataSource,
    string displayMember)
  {
    if (((Control) textBox).DataBindings.Count > 0)
      ((Control) textBox).DataBindings.Clear();
    ((Control) textBox).DataBindings.Add(new Binding("Text", (object) dataSource, displayMember, true));
  }

  private static void AttachComboDataSource(
    MGAComboBox combo,
    DataView dataSource,
    string valueMember)
  {
    if (((Control) combo).DataBindings.Count > 0)
      ((Control) combo).DataBindings.Clear();
    ((Control) combo).DataBindings.Add(new Binding("Value", (object) dataSource, valueMember, true));
  }

  private static void AttachListBoxDataSource(
    MGAListBox listBox,
    object dataSource,
    string valueMember,
    string displayMember)
  {
    listBox.ValueMember = valueMember;
    listBox.DisplayMember = displayMember;
    listBox.DataSource = RuntimeHelpers.GetObjectValue(dataSource);
  }

  private static void AttachCheckBoxDataSource(
    MGACheckBox cb,
    DataView dataSource,
    string valueMember)
  {
    if (((Control) cb).DataBindings.Count > 0)
      ((Control) cb).DataBindings.Clear();
    ((Control) cb).DataBindings.Add(new Binding("CheckedValue", (object) dataSource, valueMember, true));
  }

  private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    frmAdminNoteTypes.AttachComboListSource((MGASimpleComboBox) this.cboDiaryRecipients, (object) new DataView((DataTable) this.DsGlobalNotePrefillingOptions.lstNoteAutomationRecipients), "NoteAutomationRecipientID", "RecipientName");
    frmAdminNoteTypes.AttachComboListSource((MGASimpleComboBox) this.cboDiaryStart, (object) this.DsGlobalNotePrefillingOptions.lstDiaryStartTypes, "DiaryStartTypeID", "Description");
    frmAdminNoteTypes.AttachComboDataSource(this.cboDiaryRecipients, this.dvNoteType, "DefaultNoteDiaryRecipientId");
    frmAdminNoteTypes.AttachComboDataSource(this.cboDiaryStart, this.dvNoteType, "DefaultNoteDiaryStartId");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.cbPopup, this.dvNoteType, "DefaultNoteIsPopup");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.cbCopyForward, this.dvNoteType, "DefaultCopyForwardOnRenewal");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.cbRequiredToBind, this.dvNoteType, "RequiredToBind");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.cbRequiredToQuote, this.dvNoteType, "RequiredToQuote");
    frmAdminNoteTypes.AttachListBoxDataSource(this.lstNoteTypes, (object) this.dvNoteType, "NoteTypeID", "Description");
    frmAdminNoteTypes.AttachTextBoxDataSource(this.txtCurrentNoteType, this.dvNoteType, "Description");
    frmAdminNoteTypes.AttachTextBoxDataSource(this.txtSubject, this.dvNoteType, "DefaultNoteSubject");
    frmAdminNoteTypes.AttachTextBoxDataSource(this.txtBody, this.dvNoteType, "DefaultNoteBody");
    frmAdminNoteTypes.AttachTextBoxDataSource(this.txtDueInDays, this.dvNoteType, "DefaultNoteDueInDays");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.chkAllowTagData, this.dvNoteType, "AllowTagData");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.chkAllowUpdatesOnTagData, this.dvNoteType, "AllowTagDataUpdate");
    frmAdminNoteTypes.AttachTextBoxDataSource(this.txtTagLabel, this.dvNoteType, "TagDataLabel");
    frmAdminNoteTypes.AttachTextBoxDataSource(this.txtAutomationCode, this.dvNoteType, "AutomationCode");
    frmAdminNoteTypes.AttachCheckBoxDataSource(this.chkDisabled, this.dvNoteType, "Disabled");
    this.Cursor = Cursors.Default;
    this.SetLoadingText(false);
    this.DbSaveUI1.ResetUI();
  }

  private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
  {
    DefaultDatabase.DataAdapterFill(this.daPrefillingOptions, (DataSet) this.DsGlobalNotePrefillingOptions);
  }

  private void AdminNotePrefillForm_Load(object sender, EventArgs e)
  {
    this.SetLoadingText(true);
    this.EnableEdit(false);
    this.EnableTagControls();
    this.Cursor = MgaCursors.Working;
    this.dvNoteType = new DataView((DataTable) this.DsGlobalNotePrefillingOptions.lstNoteTypes);
    this.BackgroundWorker.RunWorkerAsync();
  }

  private void SetLoadingText(bool loading)
  {
    if (loading)
      this.Text += " [Loading Please Wait...]";
    else
      this.Text = this.Text.Replace(" [Loading Please Wait...]", string.Empty);
  }

  private void ResetMenuItem_Click(object sender, EventArgs e)
  {
    if (this.ActiveControl is MGASimpleComboBox activeControl1)
    {
      activeControl1.Value = (object) null;
    }
    else
    {
      if (!(this.ActiveControl is EmbeddableTextBoxWithUIPermissions activeControl))
        return;
      ((TextBox) activeControl).Text = string.Empty;
    }
  }

  private BindingManagerBase BindingManagerLstNoteTypes
  {
    get => this.BindingContext[(object) this.dvNoteType];
  }

  private void lstNoteTypes_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.BindingManagerLstNoteTypes.Position = this.lstNoteTypes.SelectedIndex;
    if (this.BindingManagerLstNoteTypes.Current == null)
      return;
    dsGlobalNotePrefillingOptions.lstNoteTypesRow row = (dsGlobalNotePrefillingOptions.lstNoteTypesRow) ((DataRowView) this.BindingManagerLstNoteTypes.Current).Row;
    if (row.IsTagDataTypeNull())
    {
      this.rdoDate.Checked = false;
      this.rdoField.Checked = true;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.TagDataType, "System.String", false) == 0)
    {
      this.rdoDate.Checked = false;
      this.rdoField.Checked = true;
    }
    else
    {
      this.rdoDate.Checked = true;
      this.rdoField.Checked = false;
    }
  }

  private void DbSaveUI1_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (((TextEditorControlBase) this.txtAutomationCode).Text.Replace(" ", string.Empty).Length > 0 && !SecurityManager.Instance.AssertPermission("{1BE36FB6-AEBC-47D7-AFC5-A3376B3CD40D}"))
    {
      int num = (int) MessageBox.Show("Cannot continue to edit a note with a valid Automation Code", "No Edit - Automation Code", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
      CurrentUser.Instance.LogAction("Edit Note Types: " + this.lstNoteTypes.Text);
  }

  private void DbSaveUI1_QueryRowCount(object sender, QueryRowCountEventArgs e)
  {
    e.RowCount = this.DsGlobalNotePrefillingOptions.lstNoteTypes.Rows.Count;
  }

  private void EnableEdit(bool enable)
  {
    this.lstNoteTypes.Enabled = !enable;
    ((Control) this.txtCurrentNoteType).Enabled = enable;
    ((Control) this.grpNoteDefaults).Enabled = enable;
  }

  private void DbSaveUI1_ClickedCancel(object sender, EventArgs e)
  {
    this.BindingManagerLstNoteTypes.CancelCurrentEdit();
  }

  private void DbSaveUI1_UIStateChanged(object sender, EventArgs e)
  {
    this.EnableEdit(this.DbSaveUI1.UIState == UIState.Editing);
  }

  private void DbSaveUI1_ClickedNew(object sender, EventArgs e)
  {
    this.BindingManagerLstNoteTypes.AddNew();
    ((TextEditorControlBase) this.txtCurrentNoteType).Text = "Please enter a description for this note type";
    ((UltraToggleEditorBase) this.cbPopup).Checked = false;
    ((UltraToggleEditorBase) this.cbRequiredToQuote).Checked = false;
    ((UltraToggleEditorBase) this.cbRequiredToBind).Checked = false;
    ((UltraToggleEditorBase) this.chkDisabled).Checked = false;
    dsGlobalNotePrefillingOptions.lstNoteTypesRow row = (dsGlobalNotePrefillingOptions.lstNoteTypesRow) ((DataRowView) this.BindingManagerLstNoteTypes.Current).Row;
    row.DefaultNoteIsPopup = false;
    row.RequiredToQuote = false;
    row.AllowTagData = true;
    row.AllowTagDataUpdate = true;
    row.Disabled = false;
    row.RequiredToBind = false;
    row.DefaultCopyForwardOnRenewal = true;
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.lstNoteTypes.SelectedValue != null && !this.lstNoteTypes.SelectedValue.Equals((object) -1))
    {
      if (Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("NoteSystem_GetNoteTypeInUse", new object[2]
      {
        (object) "@NoteTypeID",
        this.lstNoteTypes.SelectedValue
      })), 0) != 1)
      {
        if (((TextEditorControlBase) this.txtAutomationCode).Text.Replace(" ", string.Empty).Length <= 0)
          return;
        int num = (int) MessageBox.Show("Cannot continue to delete a note with a valid Automation Code", "No Delete - Automation Code", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        e.Cancel = true;
        return;
      }
    }
    e.Cancel = true;
    int num1 = (int) MessageBox.Show("This note type is being actively used in the system.", "Cannot delete this note type", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void DbSaveUI1_ClickedDelete(object sender, EventArgs e)
  {
    if (this.lstNoteTypes.SelectedValue == null || this.lstNoteTypes.SelectedValue.Equals((object) -1))
      return;
    if (DefaultDatabase.ExecuteNonQuery("NoteSystem_DeleteNoteType", new object[2]
    {
      (object) "@NoteTypeID",
      this.lstNoteTypes.SelectedValue
    }) <= 0)
      return;
    this.DsGlobalNotePrefillingOptions.lstNoteTypes.FindByNoteTypeID(Conversions.ToInteger(this.lstNoteTypes.SelectedValue))?.Delete();
  }

  private Dictionary<string, DbParameter> InitializeParameters(string procName)
  {
    Dictionary<string, DbParameter> parameterList = DefaultDatabase.DiscoverParameters(procName);
    this.SetParameter(parameterList, "@description", (object) ((TextEditorControlBase) this.txtCurrentNoteType).Text, true);
    this.SetParameter(parameterList, "@defaultNoteSubject", (object) ((TextEditorControlBase) this.txtSubject).Text);
    this.SetParameter(parameterList, "@defaultNoteBody", (object) ((TextEditorControlBase) this.txtBody).Text);
    this.SetParameter(parameterList, "@defaultNoteDiaryRecipientId", RuntimeHelpers.GetObjectValue(this.cboDiaryRecipients.Value));
    this.SetParameter(parameterList, "@defaultNoteDueInDays", (object) ((TextEditorControlBase) this.txtDueInDays).Text);
    this.SetParameter(parameterList, "@defaultNoteIsPopup", (object) ((UltraToggleEditorBase) this.cbPopup).Checked);
    this.SetParameter(parameterList, "@defaultNoteDiaryStartId", RuntimeHelpers.GetObjectValue(this.cboDiaryStart.Value));
    this.SetParameter(parameterList, "@requiredToQuote", (object) ((UltraToggleEditorBase) this.cbRequiredToQuote).Checked);
    this.SetParameter(parameterList, "@requiredToBind", (object) ((UltraToggleEditorBase) this.cbRequiredToBind).Checked);
    this.SetParameter(parameterList, "@AllowTagData", (object) ((UltraToggleEditorBase) this.chkAllowTagData).Checked);
    this.SetParameter(parameterList, "@AllowTagDataUpdate", (object) ((UltraToggleEditorBase) this.chkAllowUpdatesOnTagData).Checked);
    this.SetParameter(parameterList, "@AutomationCode", (object) ((TextEditorControlBase) this.txtAutomationCode).Text);
    this.SetParameter(parameterList, "@defaultCopyForwardOnRenewal", (object) ((UltraToggleEditorBase) this.cbCopyForward).Checked);
    if (this.rdoDate.Checked)
      this.SetParameter(parameterList, "@TagDataType", (object) "System.DateTime");
    else
      this.SetParameter(parameterList, "@TagDataType", (object) "System.String");
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtTagLabel).Text))
    {
      this.SetParameter(parameterList, "@TagDataLabel", (object) " ");
      parameterList["@TagDataLabel"].Value = (object) "";
    }
    else
      this.SetParameter(parameterList, "@TagDataLabel", (object) ((TextEditorControlBase) this.txtTagLabel).Text);
    this.SetParameter(parameterList, "@Disabled", (object) ((UltraToggleEditorBase) this.chkDisabled).Checked);
    return parameterList;
  }

  private void SetParameter(
    Dictionary<string, DbParameter> parameterList,
    string parameterName,
    object parameterValue,
    bool required = false)
  {
    if (required && parameterValue == null)
      throw new ArgumentNullException(nameof (parameterValue));
    if (!parameterList.ContainsKey(parameterName))
      throw new ArgumentNullException(nameof (parameterName));
    if (parameterValue == null)
      parameterList.Remove(parameterName);
    else if (parameterValue is string)
    {
      string str = parameterValue as string;
      if (string.IsNullOrEmpty(str))
        parameterList.Remove(parameterName);
      else
        parameterList[parameterName].Value = (object) str;
    }
    else
      parameterList[parameterName].Value = RuntimeHelpers.GetObjectValue(parameterValue);
  }

  private void DbSaveUI1_ClickedSave(object sender, EventArgs e)
  {
    try
    {
      if (this.BindingManagerLstNoteTypes.Current is DataRowView current)
      {
        if (this.cboDiaryStart.Value == null && this.cboDiaryRecipients.Value == null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDueInDays).Text, "0", false) == 0)
          ((dsGlobalNotePrefillingOptions.lstNoteTypesRow) current.Row).SetDefaultNoteDueInDaysNull();
        current.Row["TagDataType"] = !this.rdoDate.Checked ? (object) "System.String" : (object) "System.DateTime";
        if (current.Row.RowState == DataRowState.Added)
        {
          Dictionary<string, DbParameter> dictionary = this.InitializeParameters("NoteSystem_InsertNoteType");
          DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "NoteSystem_InsertNoteType", (CommandArgumentType) 2, new object[1]
          {
            (object) dictionary
          });
          int num = (int) dictionary["@newNoteTypeID"].Value;
          current.Row["NoteTypeID"] = (object) num;
          current.Row.AcceptChanges();
          current.Row.SetModified();
        }
        else
        {
          Dictionary<string, DbParameter> parameterList = this.InitializeParameters("NoteSystem_UpdateNoteType");
          this.SetParameter(parameterList, "@noteTypeId", RuntimeHelpers.GetObjectValue(current.Row["NoteTypeID"]), true);
          DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "NoteSystem_UpdateNoteType", (CommandArgumentType) 2, new object[1]
          {
            (object) parameterList
          });
        }
        this.BindingManagerLstNoteTypes.EndCurrentEdit();
      }
      else
        this.BindingManagerLstNoteTypes.CancelCurrentEdit();
    }
    catch (DbException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.BindingManagerLstNoteTypes.CancelCurrentEdit();
      ProjectData.ClearProjectError();
    }
  }

  private void DbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.RequiredFieldValidator1.IsValid)
    {
      e.Cancel = true;
    }
    else
    {
      this.ErrorProvider1.SetError((Control) this.txtDueInDays, "");
      this.ErrorProvider1.SetError((Control) this.cboDiaryStart, "");
      this.ErrorProvider1.SetError((Control) this.cboDiaryRecipients, "");
      if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtDueInDays).Text) && this.cboDiaryStart.Value != null && this.cboDiaryRecipients.Value != null)
      {
        if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtDueInDays).Text))
          return;
        ((TextEditorControlBase) this.txtDueInDays).Text = Conversions.ToInteger(((TextEditorControlBase) this.txtDueInDays).Text).ToString();
      }
      else
      {
        if ((string.IsNullOrEmpty(((TextEditorControlBase) this.txtDueInDays).Text) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDueInDays).Text, "0", false) == 0) && this.cboDiaryStart.Value == null && this.cboDiaryRecipients.Value == null)
          return;
        if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtDueInDays).Text))
        {
          if (Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtDueInDays).Text))
            this.ErrorProvider1.SetError((Control) this.txtDueInDays, "If you're specifying a diary you must set how many days it will take before the diary is due.");
          else
            this.ErrorProvider1.SetError((Control) this.txtDueInDays, "This field must be numeric");
        }
        if (this.cboDiaryStart.Value == null)
          this.ErrorProvider1.SetError((Control) this.cboDiaryStart, "If you're specifying a diary you must set when it starts");
        if (this.cboDiaryRecipients.Value == null)
          this.ErrorProvider1.SetError((Control) this.cboDiaryRecipients, "If you're specifying a diary you must set the recipients");
        e.Cancel = true;
      }
    }
  }

  private void chkAllowTagData_CheckedChanged(object sender, EventArgs e)
  {
    this.EnableTagControls();
  }

  private void EnableTagControls()
  {
    this.rdoDate.Enabled = ((UltraToggleEditorBase) this.chkAllowTagData).Checked;
    this.rdoField.Enabled = ((UltraToggleEditorBase) this.chkAllowTagData).Checked;
    ((Control) this.txtTagLabel).Enabled = ((UltraToggleEditorBase) this.chkAllowTagData).Checked;
    this.lblTagLabel.Enabled = ((UltraToggleEditorBase) this.chkAllowTagData).Checked;
    this.lblTagType.Enabled = ((UltraToggleEditorBase) this.chkAllowTagData).Checked;
    ((Control) this.chkAllowUpdatesOnTagData).Enabled = ((UltraToggleEditorBase) this.chkAllowTagData).Checked;
  }

  private void chkHideTypes_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkHideTypes).Checked)
      this.dvNoteType.RowFilter = "Disabled = " + false.ToString();
    else
      this.dvNoteType.RowFilter = "";
  }

  private void chkDisabled_CheckedValueChanged(object sender, EventArgs e)
  {
    CurrentUser.Instance.LogAction($"Edit Note Types: {this.lstNoteTypes.Text} || Disabled CheckBox Set To {Conversions.ToString(((UltraToggleEditorBase) this.chkDisabled).Checked)}");
  }

  private void txtAutomationCode_Leave(object sender, EventArgs e)
  {
    CurrentUser.Instance.LogAction($"Edit Note Types: {this.lstNoteTypes.Text} || Automation Code Was Changed To: {((TextEditorControlBase) this.txtAutomationCode).Text}");
  }
}
