// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormIxMvrTypes
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormIxMvrTypes : Form
{
  private IContainer components;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormIxMvrTypes));
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstIIXMVRTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.grpBox = new UltraGroupBox();
    this.Label3 = new Label();
    this.txtDescription = new MGATextBox();
    this.ds = new dsDriverInfo();
    this.Label2 = new Label();
    this.txtType = new MGATextBox();
    this.Label1 = new Label();
    this.cboState = new MGAComboBox();
    this.Label21 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.cn = new SqlConnection();
    this.err = new ErrorProvider(this.components);
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ugAvail = new UltraGrid();
    ((ISupportInitialize) this.grpBox).BeginInit();
    ((Control) this.grpBox).SuspendLayout();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtType).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.SuspendLayout();
    ((Control) this.grpBox).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpBox.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpBox).Controls.Add((Control) this.Label3);
    ((Control) this.grpBox).Controls.Add((Control) this.txtDescription);
    ((Control) this.grpBox).Controls.Add((Control) this.Label2);
    ((Control) this.grpBox).Controls.Add((Control) this.txtType);
    ((Control) this.grpBox).Controls.Add((Control) this.Label1);
    ((Control) this.grpBox).Controls.Add((Control) this.cboState);
    ((Control) this.grpBox).Controls.Add((Control) this.Label21);
    ((Control) this.grpBox).Enabled = false;
    appearance2.ForeColor = Color.Navy;
    this.grpBox.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpBox).Location = new Point(12, 438);
    ((Control) this.grpBox).Name = "grpBox";
    ((Control) this.grpBox).Size = new Size(613, (int) sbyte.MaxValue);
    ((Control) this.grpBox).TabIndex = 84;
    this.grpBox.Text = "MVR Options";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(126, 69);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(174, 13);
    this.Label3.TabIndex = 89;
    this.Label3.Text = "Use && (ampersand) for blank entries";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "lstIIXMVRTypes.Description", true));
    ((Control) this.txtDescription).Location = new Point(345, 38);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 300;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    this.txtDescription.Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(234, 83);
    ((Control) this.txtDescription).TabIndex = 87;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.txtDescription.WordWrap = false;
    this.ds.DataSetName = "dsDriverInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(342, 16 /*0x10*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(63 /*0x3F*/, 13);
    this.Label2.TabIndex = 88;
    this.Label2.Text = "Description:";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtType).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtType).BackColor = Color.White;
    ((Control) this.txtType).DataBindings.Add(new Binding("Text", (object) this.ds, "lstIIXMVRTypes.Type", true));
    ((Control) this.txtType).Location = new Point(73, 66);
    ((TextEditorControlBase) this.txtType).MaxLength = 1;
    this.txtType.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtType).Name = "txtType";
    ((Control) this.txtType).Size = new Size(31 /*0x1F*/, 19);
    ((Control) this.txtType).TabIndex = 1;
    ((UltraControlBase) this.txtType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtType).UseOsThemes = (DefaultableBoolean) 2;
    this.txtType.WordWrap = false;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(6, 69);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(61, 13);
    this.Label1.TabIndex = 86;
    this.Label1.Text = "MVR Type:";
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "lstIIXMVRTypes.StateID", true));
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboState.DisplayLayout.Appearance = (AppearanceBase) appearance5;
    this.cboState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 181;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance6.BackColor = SystemColors.ActiveBorder;
    appearance6.BackColor2 = SystemColors.ControlDark;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboState.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance6;
    appearance7.ForeColor = SystemColors.GrayText;
    this.cboState.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance7;
    ((SpecialBoxBase) this.cboState.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance8.BackColor = SystemColors.ControlLightLight;
    appearance8.BackColor2 = SystemColors.Control;
    appearance8.BackGradientStyle = (GradientStyle) 3;
    appearance8.ForeColor = SystemColors.GrayText;
    this.cboState.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance8;
    this.cboState.DisplayLayout.MaxColScrollRegions = 1;
    this.cboState.DisplayLayout.MaxRowScrollRegions = 1;
    appearance9.BackColor = SystemColors.Window;
    appearance9.ForeColor = SystemColors.ControlText;
    this.cboState.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = SystemColors.Highlight;
    appearance10.ForeColor = SystemColors.HighlightText;
    this.cboState.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    this.cboState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance11.BackColor = SystemColors.Window;
    this.cboState.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.Silver;
    appearance12.TextTrimming = (TextTrimming) 3;
    this.cboState.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    this.cboState.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboState.DisplayLayout.Override.CellPadding = 0;
    appearance13.BackColor = SystemColors.Control;
    appearance13.BackColor2 = SystemColors.ControlDark;
    appearance13.BackGradientAlignment = (GradientAlignment) 1;
    appearance13.BackGradientStyle = (GradientStyle) 3;
    appearance13.BorderColor = SystemColors.Window;
    this.cboState.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    this.cboState.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    this.cboState.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboState.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance15.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance15.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboState.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = SystemColors.Window;
    appearance16.BorderColor = Color.White;
    this.cboState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    this.cboState.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboState.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance17.ForeColor = Color.Black;
    this.cboState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.ControlLight;
    this.cboState.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance18;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboState.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.cboState.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboState.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboState.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 200;
    ((Control) this.cboState).Location = new Point(73, 16 /*0x10*/);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(227, 20);
    ((Control) this.cboState).TabIndex = 0;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(6, 26);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(35, 13);
    this.Label21.TabIndex = 80 /*0x50*/;
    this.Label21.Text = "State:";
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(700, 531);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(117, 34);
    this.dbSave.TabIndex = 83;
    this.cn.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDriverProductStates", new DataColumnMapping[7]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("SubType", "SubType"),
        new DataColumnMapping("FullOption", "FullOption"),
        new DataColumnMapping("CleanOption", "CleanOption"),
        new DataColumnMapping("ActivityOption", "ActivityOption"),
        new DataColumnMapping("VdetailOption", "VdetailOption")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblDriverProductStates] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@SubType", SqlDbType.VarChar, 0, "SubType"),
      new SqlParameter("@FullOption", SqlDbType.Bit, 0, "FullOption"),
      new SqlParameter("@CleanOption", SqlDbType.Bit, 0, "CleanOption"),
      new SqlParameter("@ActivityOption", SqlDbType.Bit, 0, "ActivityOption"),
      new SqlParameter("@VdetailOption", SqlDbType.Bit, 0, "VdetailOption")
    });
    this.SqlSelectCommand1.CommandText = "SELECT      ID, StateID, SubType, FullOption, CleanOption, ActivityOption, VdetailOption\r\nFROM         tblDriverProductStates";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@SubType", SqlDbType.VarChar, 0, "SubType"),
      new SqlParameter("@FullOption", SqlDbType.Bit, 0, "FullOption"),
      new SqlParameter("@CleanOption", SqlDbType.Bit, 0, "CleanOption"),
      new SqlParameter("@ActivityOption", SqlDbType.Bit, 0, "ActivityOption"),
      new SqlParameter("@VdetailOption", SqlDbType.Bit, 0, "VdetailOption"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataMember = "lstIIXMVRTypes";
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.ds;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 83;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 157;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 65;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 566;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ugAvail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugAvail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance20.BackColor = Color.LightSteelBlue;
    appearance20.FontData.SizeInPoints = 10f;
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance22.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellDisplayStyle = (CellDisplayStyle) 3;
    appearance23.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance24.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance24;
    appearance25.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance26.BackColor = Color.Transparent;
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugAvail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAvail).Location = new Point(10, 10);
    ((Control) this.ugAvail).Margin = new Padding(1);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(809, 424);
    ((Control) this.ugAvail).TabIndex = 14;
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(829, 577);
    this.Controls.Add((Control) this.grpBox);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ugAvail);
    this.Name = nameof (FormIxMvrTypes);
    this.Text = "IIX Ordering - MVR Types";
    ((ISupportInitialize) this.grpBox).EndInit();
    ((Control) this.grpBox).ResumeLayout(false);
    ((Control) this.grpBox).PerformLayout();
    ((ISupportInitialize) this.txtDescription).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtType).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraGrid ugAvail
  {
    get => this._ugAvail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugAvail_AfterRowActivate);
      UltraGrid ugAvail1 = this._ugAvail;
      if (ugAvail1 != null)
        ugAvail1.AfterRowActivate -= eventHandler;
      this._ugAvail = value;
      UltraGrid ugAvail2 = this._ugAvail;
      if (ugAvail2 == null)
        return;
      ugAvail2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpBox")]
  private virtual UltraGroupBox grpBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDescription")]
  private virtual MGATextBox txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtType")]
  private virtual MGATextBox txtType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  protected virtual MGAComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_bmb")]
  private virtual BindingManagerBase _bmb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormIxMvrTypes()
  {
    this.Load += new EventHandler(this.FormIxMvrTypes_Load);
    this.InitializeComponent();
  }

  private void FormIxMvrTypes_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._bmb = this.BindingContext[(object) this.ds, this.ds.lstIIXMVRTypes.TableName];
    string[] strArray = new string[2]
    {
      "lstStates",
      "lstIIXMVRTypes"
    };
    try
    {
      string str = "SELECT StateID, State FROM lstStates ORDER BY StateID;SELECT ID, StateID, Type, Description FROM lstIIXMVRTypes";
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, CommandType.Text, str);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    if (this.ds.lstIIXMVRTypes.Count == 0)
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
    else
    {
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
      this._bmb.Position = 0;
    }
  }

  private void ugAvail_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugAvail).ActiveRow == null)
      return;
    Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugAvail).ActiveRow.Cells["ID"].Value), "ID", (DataTable) this.ds.lstIIXMVRTypes, this._bmb);
  }

  private bool IsValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboState, string.Empty);
    this.err.SetError((Control) this.txtType, string.Empty);
    this.err.SetError((Control) this.txtDescription, string.Empty);
    if (string.IsNullOrEmpty(this.cboState.Text))
    {
      this.err.SetError((Control) this.cboState, "Select a value");
      flag = false;
    }
    if (((TextEditorControlBase) this.txtType).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtType, "Select a value");
      flag = false;
    }
    if (((TextEditorControlBase) this.txtDescription).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtDescription, "Select a value");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsDriverInfo.lstIIXMVRTypesRow row = this.ds.lstIIXMVRTypes.NewlstIIXMVRTypesRow();
    row.StateID = string.Empty;
    row.Type = string.Empty;
    row.Description = string.Empty;
    this.ds.lstIIXMVRTypes.AddlstIIXMVRTypesRow(row);
    this._bmb.Position = this.ds.lstIIXMVRTypes.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this._bmb.EndCurrentEdit();
    if (!this.IsValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      dsDriverInfo.lstIIXMVRTypesRow lstIixmvrType = this.ds.lstIIXMVRTypes[this._bmb.Position];
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.lstIIXMVRTypes);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1 || MessageBox.Show("Are you sure you want to delete this setup?", "Delete IIX MVR Type Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.ds.lstIIXMVRTypes[this._bmb.Position].Delete();
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.lstIIXMVRTypes);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      e.Cancel = true;
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.lstIIXMVRTypes.RejectChanges();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ugAvail).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.grpBox).Enabled = this.dbSave.UIState == UIState.Editing;
    if (this.dbSave.UIState == UIState.Editing)
      return;
    if (this.ds.lstIIXMVRTypes.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }
}
