// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyFcwToCompanyLines
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyFcwToCompanyLines : Form
{
  private IContainer components;
  private MemoryStream _gridLayout;
  private Thread _filterThread;
  private readonly int _companyLineID;
  private readonly List<int> _lstCompanyFCW;
  private Guid _companyLineGuidFilter;
  private Guid _companyLocationGuidFilter;

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyFcwToCompanyLines));
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CopyOver");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ViewCompanyLines_ViewCompanyLinesChildren");
    UltraGridBand ultraGridBand2 = new UltraGridBand("ViewCompanyLines_ViewCompanyLinesChildren", 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ParentCompanyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CopyOver");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.lnkDeselectALL = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnSave = new MGAButton();
    this.panelLoading = new UltraGroupBox();
    this.Label6 = new Label();
    this.PictureBox1 = new PictureBox();
    this.lnkApplyFilter = new LinkLabel();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.cbStateFilter = new MGASimpleComboBox();
    this.ds = new dsCopyFcwToOtherCompanyLines();
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    this.dgView = new UltraGrid();
    this.daGetCompanyLine = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.lnkSelectAllChildren = new LinkLabel();
    this.lnkDeselectALL_Child = new LinkLabel();
    this.lblCurrentCompanyLine = new Label();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.panelLoading).BeginInit();
    ((Control) this.panelLoading).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    this.SuspendLayout();
    this.lnkDeselectALL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectALL.Location = new Point(12, 547);
    this.lnkDeselectALL.Name = "lnkDeselectALL";
    this.lnkDeselectALL.Size = new Size(82, 20);
    this.lnkDeselectALL.TabIndex = 11;
    this.lnkDeselectALL.TabStop = true;
    this.lnkDeselectALL.Text = "De-Select All";
    this.lnkDeselectALL.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.Location = new Point(12, 511 /*0x01FF*/);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(67, 18);
    this.lnkSelectAll.TabIndex = 10;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkSelectAll.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(652, 527);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 12;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelLoading.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.panelLoading).Controls.Add((Control) this.Label6);
    ((Control) this.panelLoading).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelLoading).Location = new Point(238, 155);
    ((Control) this.panelLoading).Name = "panelLoading";
    ((Control) this.panelLoading).Size = new Size(240 /*0xF0*/, 48 /*0x30*/);
    ((Control) this.panelLoading).TabIndex = 158;
    ((Control) this.panelLoading).Visible = false;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(47, 15);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(173, 18);
    this.Label6.TabIndex = 1;
    this.Label6.Text = "Loading ... please wait ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Location = new Point(317, 55);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(58, 13);
    this.lnkApplyFilter.TabIndex = 157;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    this.Label26.AutoSize = true;
    this.Label26.Location = new Point(470, 11);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(60, 13);
    this.Label26.TabIndex = 156;
    this.Label26.Text = "State Filter:";
    this.Label25.AutoSize = true;
    this.Label25.Location = new Point(246, 11);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(55, 13);
    this.Label25.TabIndex = 155;
    this.Label25.Text = "Line Filter:";
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(15, 11);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(79, 13);
    this.Label24.TabIndex = 154;
    this.Label24.Text = "Company Filter:";
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.cbStateFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbStateFilter).DisplayMember = "State";
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStateFilter).Location = new Point(469, 32 /*0x20*/);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    ((Control) this.cbStateFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbStateFilter).TabIndex = 153;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStateFilter).ValueMember = "StateID";
    this.ds.DataSetName = "dsCopyFcwToOtherCompanyLines";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbCompanyFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cbCompanyFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbCompanyFilter).DisplayMember = "Name";
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 500;
    ((Control) this.cbCompanyFilter).Location = new Point(15, 32 /*0x20*/);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    ((Control) this.cbCompanyFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbCompanyFilter).TabIndex = 150;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanyFilter).ValueMember = "CompanyLocationGuid";
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.cbLineFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbLineFilter).DisplayMember = "LineName";
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 300;
    ((Control) this.cbLineFilter).Location = new Point(242, 32 /*0x20*/);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    ((Control) this.cbLineFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbLineFilter).TabIndex = 152;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLineFilter).ValueMember = "LineGuid";
    ((Control) this.dgView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgView).DataMember = "ViewCompanyLines";
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 4;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 151;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 151;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 358;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 83;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 221;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 85;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Copy";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 64 /*0x40*/;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridBand1.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 150;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Line";
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Width = 176 /*0xB0*/;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Company";
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Width = 300;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Width = 95;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 348;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 198;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 84;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Copy";
    ultraGridColumn16.Header.VisiblePosition = 7;
    ultraGridColumn16.Width = 66;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgView).Location = new Point(15, 74);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(677, 417);
    ((Control) this.dgView).TabIndex = 151;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    this.daGetCompanyLine.SelectCommand = this.SqlSelectCommand3;
    this.daGetCompanyLine.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "Table", new DataColumnMapping[0])
    });
    this.SqlSelectCommand3.CommandText = "[spQueryForCompanyLines]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@companyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@lineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@stateID", SqlDbType.Char, 2)
    });
    this.cnSQL.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.lnkSelectAllChildren.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllChildren.Location = new Point(108, 511 /*0x01FF*/);
    this.lnkSelectAllChildren.Name = "lnkSelectAllChildren";
    this.lnkSelectAllChildren.Size = new Size(49, 18);
    this.lnkSelectAllChildren.TabIndex = 159;
    this.lnkSelectAllChildren.TabStop = true;
    this.lnkSelectAllChildren.Text = "All Child";
    this.lnkSelectAllChildren.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkDeselectALL_Child.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectALL_Child.Location = new Point(108, 548);
    this.lnkDeselectALL_Child.Name = "lnkDeselectALL_Child";
    this.lnkDeselectALL_Child.Size = new Size(49, 18);
    this.lnkDeselectALL_Child.TabIndex = 161;
    this.lnkDeselectALL_Child.TabStop = true;
    this.lnkDeselectALL_Child.Text = "All Child";
    this.lnkDeselectALL_Child.TextAlign = ContentAlignment.MiddleCenter;
    this.lblCurrentCompanyLine.AutoSize = true;
    this.lblCurrentCompanyLine.Location = new Point(200, 514);
    this.lblCurrentCompanyLine.Name = "lblCurrentCompanyLine";
    this.lblCurrentCompanyLine.Size = new Size(80 /*0x50*/, 13);
    this.lblCurrentCompanyLine.TabIndex = 162;
    this.lblCurrentCompanyLine.Text = "Copying from  - ";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(704, 579);
    this.Controls.Add((Control) this.lblCurrentCompanyLine);
    this.Controls.Add((Control) this.lnkDeselectALL_Child);
    this.Controls.Add((Control) this.lnkSelectAllChildren);
    this.Controls.Add((Control) this.panelLoading);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.cbStateFilter);
    this.Controls.Add((Control) this.cbCompanyFilter);
    this.Controls.Add((Control) this.cbLineFilter);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkDeselectALL);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Name = nameof (FormCopyFcwToCompanyLines);
    this.Text = "Copy Form / Conditions/ Warranties To CompanyLines";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.panelLoading).EndInit();
    ((Control) this.panelLoading).ResumeLayout(false);
    ((Control) this.panelLoading).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual LinkLabel lnkDeselectALL
  {
    get => this._lnkDeselectALL;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectALL_LinkClicked);
      LinkLabel lnkDeselectAll1 = this._lnkDeselectALL;
      if (lnkDeselectAll1 != null)
        lnkDeselectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectALL = value;
      LinkLabel lnkDeselectAll2 = this._lnkDeselectALL;
      if (lnkDeselectAll2 == null)
        return;
      lnkDeselectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("panelLoading")]
  internal virtual UltraGroupBox panelLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkApplyFilter
  {
    get => this._lnkApplyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkApplyFilter_LinkClicked);
      LinkLabel lnkApplyFilter1 = this._lnkApplyFilter;
      if (lnkApplyFilter1 != null)
        lnkApplyFilter1.LinkClicked -= clickedEventHandler;
      this._lnkApplyFilter = value;
      LinkLabel lnkApplyFilter2 = this._lnkApplyFilter;
      if (lnkApplyFilter2 == null)
        return;
      lnkApplyFilter2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbStateFilter")]
  private virtual MGASimpleComboBox cbStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbCompanyFilter")]
  private virtual MGASimpleComboBox cbCompanyFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbLineFilter")]
  private virtual MGASimpleComboBox cbLineFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgView")]
  protected virtual UltraGrid dgView { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyFcwToOtherCompanyLines ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetCompanyLine")]
  internal virtual SqlDataAdapter daGetCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSelectAllChildren
  {
    get => this._lnkSelectAllChildren;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllChildren_LinkClicked);
      LinkLabel selectAllChildren1 = this._lnkSelectAllChildren;
      if (selectAllChildren1 != null)
        selectAllChildren1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllChildren = value;
      LinkLabel selectAllChildren2 = this._lnkSelectAllChildren;
      if (selectAllChildren2 == null)
        return;
      selectAllChildren2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeselectALL_Child
  {
    get => this._lnkDeselectALL_Child;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectALL_Child_LinkClicked);
      LinkLabel deselectAllChild1 = this._lnkDeselectALL_Child;
      if (deselectAllChild1 != null)
        deselectAllChild1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectALL_Child = value;
      LinkLabel deselectAllChild2 = this._lnkDeselectALL_Child;
      if (deselectAllChild2 == null)
        return;
      deselectAllChild2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCurrentCompanyLine")]
  internal virtual Label lblCurrentCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCopyFcwToCompanyLines(int companyLineID, List<int> lstCompanyFCW)
  {
    this.Load += new EventHandler(this.FormCopyFcwToCompanyLines_Load);
    this._gridLayout = new MemoryStream();
    this._lstCompanyFCW = new List<int>();
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._lstCompanyFCW = lstCompanyFCW;
  }

  private void FormCopyFcwToCompanyLines_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    this.lblCurrentCompanyLine.Text = $"{this.lblCurrentCompanyLine.Text} {new CompanyLine(this._companyLineID).CompanyLineState}";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "lstStates",
      "lstLines",
      "tblCompanyLocations"
    }, "spGetStatesLinesLocations");
    dsCopyFcwToOtherCompanyLines.lstLinesDataTable lstLinesDataTable = (dsCopyFcwToOtherCompanyLines.lstLinesDataTable) this.ds.lstLines.Copy();
    dsCopyFcwToOtherCompanyLines.lstLinesRow row1 = lstLinesDataTable.NewlstLinesRow();
    row1.LineGuid = Guid.Empty;
    row1.LineName = "Any";
    lstLinesDataTable.Rows.InsertAt((DataRow) row1, 0);
    MGASimpleComboBox cbLineFilter = this.cbLineFilter;
    ((UltraGridBase) cbLineFilter).DataSource = (object) lstLinesDataTable;
    ((UltraDropDownBase) cbLineFilter).DisplayMember = lstLinesDataTable.LineNameColumn.ColumnName;
    ((UltraDropDownBase) cbLineFilter).ValueMember = lstLinesDataTable.LineGuidColumn.ColumnName;
    ((Control) cbLineFilter).Enabled = true;
    ((UltraDropDownBase) this.cbLineFilter).SelectedRow = ((UltraGridBase) this.cbLineFilter).Rows[0];
    dsCopyFcwToOtherCompanyLines.lstStatesDataTable lstStatesDataTable = (dsCopyFcwToOtherCompanyLines.lstStatesDataTable) this.ds.lstStates.Copy();
    dsCopyFcwToOtherCompanyLines.lstStatesRow row2 = lstStatesDataTable.NewlstStatesRow();
    row2.StateID = string.Empty;
    row2.State = "Any";
    lstStatesDataTable.Rows.InsertAt((DataRow) row2, 0);
    MGASimpleComboBox cbStateFilter = this.cbStateFilter;
    ((UltraGridBase) cbStateFilter).DataSource = (object) lstStatesDataTable;
    ((UltraDropDownBase) cbStateFilter).DisplayMember = lstStatesDataTable.StateColumn.ColumnName;
    ((UltraDropDownBase) cbStateFilter).ValueMember = lstStatesDataTable.StateIDColumn.ColumnName;
    ((Control) cbStateFilter).Enabled = true;
    ((UltraDropDownBase) this.cbStateFilter).SelectedRow = ((UltraGridBase) this.cbStateFilter).Rows[0];
    dsCopyFcwToOtherCompanyLines.tblCompanyLocationsDataTable locationsDataTable = (dsCopyFcwToOtherCompanyLines.tblCompanyLocationsDataTable) this.ds.tblCompanyLocations.Copy();
    dsCopyFcwToOtherCompanyLines.tblCompanyLocationsRow row3 = locationsDataTable.NewtblCompanyLocationsRow();
    row3.CompanyLocationGuid = Guid.Empty;
    row3.Name = "Any";
    locationsDataTable.Rows.InsertAt((DataRow) row3, 0);
    MGASimpleComboBox cbCompanyFilter = this.cbCompanyFilter;
    ((UltraGridBase) cbCompanyFilter).DataSource = (object) locationsDataTable;
    ((UltraDropDownBase) cbCompanyFilter).DisplayMember = locationsDataTable.NameColumn.ColumnName;
    ((UltraDropDownBase) cbCompanyFilter).ValueMember = locationsDataTable.CompanyLocationGuidColumn.ColumnName;
    ((Control) cbCompanyFilter).Enabled = true;
    ((UltraDropDownBase) this.cbCompanyFilter).SelectedRow = ((UltraGridBase) this.cbCompanyFilter).Rows[0];
    this.ds.AcceptChanges();
    this.cbStateFilter.Value = (object) null;
    this.cbCompanyFilter.Value = (object) null;
    this.cbLineFilter.Value = (object) null;
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.FilterGrid();
  }

  private void FilterGrid()
  {
    ((Control) this.panelLoading).Visible = true;
    this.lnkApplyFilter.Enabled = false;
    ((Control) this.btnSave).Enabled = false;
    ((Control) this.cbCompanyFilter).Enabled = false;
    ((Control) this.cbStateFilter).Enabled = false;
    ((Control) this.cbLineFilter).Enabled = false;
    ((UltraGridBase) this.dgView).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.dgView).DataSource = (object) null;
    if (this._filterThread != null && this._filterThread.IsAlive)
      this._filterThread.Abort();
    Cursor.Current = MgaCursors.Working;
    this._filterThread = new Thread(new ThreadStart(this.FilterGridThread));
    this._filterThread.Name = "FillCompanyLinesGrid";
    this._filterThread.IsBackground = true;
    this._filterThread.Start();
  }

  private void FilterGridThread()
  {
    try
    {
      this.ds.ViewCompanyLinesChildren.Clear();
      this.ds.ViewCompanyLines.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbCompanyFilter.Text, "Any", false) != 0)
      obj1 = RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbLineFilter.Text, "Any", false) != 0)
      obj2 = RuntimeHelpers.GetObjectValue(this.cbLineFilter.Value);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbStateFilter.Text, "Any", false) != 0)
      obj3 = RuntimeHelpers.GetObjectValue(this.cbStateFilter.Value);
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
      {
        "ViewCompanyLines",
        "ViewCompanyLinesChildren"
      }, "spQueryForCompanyLines", new object[6]
      {
        (object) "@CompanyLocationGuid",
        obj1,
        (object) "@lineGuid",
        obj2,
        (object) "@stateID",
        obj3
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ProjectData.ClearProjectError();
    }
    MDIControls.Instance.MDIParent.Invoke((Delegate) new FormCopyFcwToCompanyLines.FilterGridThreadCompleteHandler(this.FilterGridThreadComplete));
  }

  private void FilterGridThreadComplete()
  {
    ((Control) this.panelLoading).Visible = false;
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds.ViewCompanyLines;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.dgView).DisplayLayout.Load((Stream) this._gridLayout);
    this.lnkApplyFilter.Enabled = true;
    ((Control) this.btnSave).Enabled = true;
    ((Control) this.cbCompanyFilter).Enabled = true;
    ((Control) this.cbStateFilter).Enabled = true;
    ((Control) this.cbLineFilter).Enabled = true;
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds.ViewCompanyLines;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.dgView).DisplayLayout.Load((Stream) this._gridLayout);
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    Cursor.Current = Cursors.Default;
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyOver(FormCopyFcwToCompanyLines.GridSelection.All, true);
  }

  private void lnkSelectAllChildren_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyOver(FormCopyFcwToCompanyLines.GridSelection.Children, true);
  }

  private void SetCopyOver(FormCopyFcwToCompanyLines.GridSelection rowType, bool CopyTypeValue)
  {
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        switch (rowType)
        {
          case FormCopyFcwToCompanyLines.GridSelection.All:
            ultraGridRow.Cells["CopyOver"].Value = (object) CopyTypeValue;
            continue;
          case FormCopyFcwToCompanyLines.GridSelection.Children:
            if (ultraGridRow.HasParent())
            {
              ultraGridRow.Cells["CopyOver"].Value = (object) CopyTypeValue;
              continue;
            }
            continue;
          case FormCopyFcwToCompanyLines.GridSelection.Parents:
            if (ultraGridRow.HasChild())
            {
              ultraGridRow.Cells["CopyOver"].Value = (object) CopyTypeValue;
              continue;
            }
            continue;
          default:
            throw new InvalidOperationException("Invalid Grid Selection Type");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkDeselectALL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyOver(FormCopyFcwToCompanyLines.GridSelection.All, false);
  }

  private void lnkDeselectALL_Child_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCopyOver(FormCopyFcwToCompanyLines.GridSelection.Children, false);
  }

  private bool IsValidGridSelection()
  {
    bool flag;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (ultraGridRow.Cells["CopyOver"].Value != null && ultraGridRow.Cells["CopyOver"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
        {
          flag = true;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_8:
    return flag;
  }

  private bool IsValidFormData()
  {
    bool flag;
    if (!this.IsValidGridSelection())
    {
      int num = (int) MessageBox.Show("Please make a selection in the grid to continue", "Invalid Grid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidFormData())
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      int num1 = this._lstCompanyFCW.Count - 1;
      for (int index = 0; index <= num1; ++index)
      {
        try
        {
          foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
          {
            if (ultraGridRow.Cells["CopyOver"].Value != null && ultraGridRow.Cells["CopyOver"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
            {
              int num2 = (int) ultraGridRow.Cells["CompanyLineID"].Value;
              try
              {
                DefaultDatabase.ExecuteNonQuery("dbo.spCopyFCW_AcrossCompanyLines", new object[8]
                {
                  (object) "@SourceCompanyLineID",
                  (object) this._companyLineID,
                  (object) "@DestinationCompanyLineID",
                  (object) num2,
                  (object) "@company_FCW_ID",
                  (object) this._lstCompanyFCW[index],
                  (object) "@UserGuid",
                  (object) CurrentUser.Instance.UserGUID
                });
              }
              catch (SqlException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                if (!ex.Message.Contains("IX_tblCompanyFormsConditionsWarranties"))
                  throw;
                ProjectData.ClearProjectError();
              }
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private delegate void FilterGridThreadCompleteHandler();

  private enum GridSelection
  {
    All,
    Children,
    Parents,
  }
}
