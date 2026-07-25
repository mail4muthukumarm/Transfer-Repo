// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmAdvancedCompanySearch
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

public class frmAdvancedCompanySearch : Form
{
  private Guid _companyguid;
  private Guid _companyLocationguid;

  public frmAdvancedCompanySearch()
  {
    this.Load += new EventHandler(this.FrmAdvancedCompanySearch_Load_1);
    this.InitializeComponent();
  }

  private void FrmAdvancedCompanySearch_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Forward;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdvancedCompanySearch));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblCompanies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("companyGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("companyName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FEIN");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Closed");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.lblFein = new Label();
    this.UltraPictureBox1 = new UltraPictureBox();
    this.ugCompanyAdvancedSearch = new UltraGrid();
    this.DsAdvancedCompanySearch1 = new dsAdvancedCompanySearch();
    this.btnGo = new MGAButton();
    this.btnSearch = new MGAButton();
    this.txtName = new MGATextBox();
    this.lblName = new Label();
    this.txtFEIN = new MGAMaskedEdit();
    ((ISupportInitialize) this.ugCompanyAdvancedSearch).BeginInit();
    this.DsAdvancedCompanySearch1.BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    this.SuspendLayout();
    this.lblFein.AutoSize = true;
    this.lblFein.BackColor = Color.Transparent;
    this.lblFein.Location = new Point(18, 40);
    this.lblFein.Name = "lblFein";
    this.lblFein.Size = new Size(34, 13);
    this.lblFein.TabIndex = 31 /*0x1F*/;
    this.lblFein.Text = "FEIN:";
    this.lblFein.TextAlign = ContentAlignment.MiddleRight;
    this.UltraPictureBox1.AutoSize = true;
    this.UltraPictureBox1.BorderShadowColor = Color.Empty;
    this.UltraPictureBox1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraPictureBox1.Image"));
    ((Control) this.UltraPictureBox1).Location = new Point(998, 8);
    ((Control) this.UltraPictureBox1).Name = "UltraPictureBox1";
    ((Control) this.UltraPictureBox1).Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    ((Control) this.UltraPictureBox1).TabIndex = 29;
    ((Control) this.ugCompanyAdvancedSearch).Anchor = AnchorStyles.None;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DataMember = "tblCompanies";
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DataSource = (object) this.DsAdvancedCompanySearch1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 416;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 516;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 249;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 344;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugCompanyAdvancedSearch).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugCompanyAdvancedSearch).Location = new Point(55, 72);
    ((Control) this.ugCompanyAdvancedSearch).Name = "ugCompanyAdvancedSearch";
    ((Control) this.ugCompanyAdvancedSearch).Size = new Size(767 /*0x02FF*/, 291);
    ((Control) this.ugCompanyAdvancedSearch).TabIndex = 32 /*0x20*/;
    ((Control) this.ugCompanyAdvancedSearch).Text = "Companies";
    ((UltraControlBase) this.ugCompanyAdvancedSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCompanyAdvancedSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.DsAdvancedCompanySearch1.DataSetName = "dsAdvancedCompanySearch";
    this.DsAdvancedCompanySearch1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnGo).Anchor = AnchorStyles.None;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnGo).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnGo).Enabled = false;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(782, 386);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 34;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Anchor = AnchorStyles.None;
    appearance10.ImageHAlign = (HAlign) 2;
    appearance10.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance10;
    ((ControlBase) this.btnSearch).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(726, 386);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 33;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).Location = new Point(60, 11);
    ((TextEditorControlBase) this.txtName).MaxLength = 250;
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(330, 19);
    ((Control) this.txtName).TabIndex = 36;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblName.Location = new Point(18, 18);
    this.lblName.Name = "lblName";
    this.lblName.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lblName.TabIndex = 35;
    this.lblName.Text = "Name";
    this.lblName.TextAlign = ContentAlignment.MiddleLeft;
    appearance12.BackColorDisabled = Color.Gainsboro;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFEIN.Appearance = (AppearanceBase) appearance12;
    this.txtFEIN.EditAs = (EditAsType) 1;
    this.txtFEIN.InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(60, 36);
    this.txtFEIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    this.txtFEIN.NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(70, 20);
    ((Control) this.txtFEIN).TabIndex = 37;
    this.txtFEIN.Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.ClientSize = new Size(1058, 438);
    this.Controls.Add((Control) this.txtFEIN);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.lblName);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.ugCompanyAdvancedSearch);
    this.Controls.Add((Control) this.lblFein);
    this.Controls.Add((Control) this.UltraPictureBox1);
    this.Name = nameof (frmAdvancedCompanySearch);
    this.Text = "Advanced Company Search";
    ((ISupportInitialize) this.ugCompanyAdvancedSearch).EndInit();
    this.DsAdvancedCompanySearch1.EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    ((ISupportInitialize) this.txtFEIN).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblFein")]
  private virtual Label lblFein { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraPictureBox1")]
  internal virtual UltraPictureBox UltraPictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual UltraGrid ugCompanyAdvancedSearch
  {
    get => this._ugCompanyAdvancedSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UgCompanyAdvancedSearch_DoubleClick);
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.UgCompanyAdvancedSearch_DoubleClickRow);
      UltraGrid companyAdvancedSearch1 = this._ugCompanyAdvancedSearch;
      if (companyAdvancedSearch1 != null)
      {
        ((Control) companyAdvancedSearch1).DoubleClick -= eventHandler;
        companyAdvancedSearch1.DoubleClickRow -= clickRowEventHandler;
      }
      this._ugCompanyAdvancedSearch = value;
      UltraGrid companyAdvancedSearch2 = this._ugCompanyAdvancedSearch;
      if (companyAdvancedSearch2 == null)
        return;
      ((Control) companyAdvancedSearch2).DoubleClick += eventHandler;
      companyAdvancedSearch2.DoubleClickRow += clickRowEventHandler;
    }
  }

  protected internal virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
    }
  }

  protected internal virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("DsAdvancedCompanySearch1")]
  internal virtual dsAdvancedCompanySearch DsAdvancedCompanySearch1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void BtnGo_Click(object sender, EventArgs e)
  {
    ((Control) this.btnGo).Enabled = false;
    if (((UltraGridBase) this.ugCompanyAdvancedSearch).Rows.Count < 1 || ((UltraGridBase) this.ugCompanyAdvancedSearch).ActiveRow.Cells == null || ((UltraGridBase) this.ugCompanyAdvancedSearch).ActiveRow.Cells.Count < 1)
      return;
    if (((UltraGridBase) this.ugCompanyAdvancedSearch).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an item from the list before continuing.", "Select An Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        if (((UltraGridBase) this.ugCompanyAdvancedSearch).ActiveRow.Cells["companyguid"].Value != DBNull.Value)
          this._companyguid = (Guid) ((UltraGridBase) this.ugCompanyAdvancedSearch).ActiveRow.Cells["companyguid"].Value;
        this.CompanySelected(this._companyguid);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
        ((Control) this.btnGo).Enabled = true;
      }
    }
  }

  public virtual void CompanySelected(Guid companyGuid)
  {
    Form formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmCompanies), typeof (frmCompanies), (object) companyGuid);
    if (formEx == null)
      return;
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
  }

  private void UgCompanyAdvancedSearch_DoubleClick(object sender, EventArgs e)
  {
  }

  private void FrmAdvancedCompanySearch_Load_1(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Forward;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
  }

  private void UgCompanyAdvancedSearch_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.BtnGo_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
  }

  private void BtnSearch_Click(object sender, EventArgs e)
  {
    ((Control) this.btnSearch).Enabled = false;
    this.DsAdvancedCompanySearch1.tblCompanies.Clear();
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) this.DsAdvancedCompanySearch1.tblCompanies, "dbo.[spAdvancedCompanySearch]", new object[4]
      {
        (object) "@Name",
        (object) ((TextEditorControlBase) this.txtName).Text,
        (object) "@FEIN",
        this.txtFEIN.Value
      });
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      ((Control) this.btnSearch).Enabled = true;
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugCompanyAdvancedSearch).Rows)
    {
      if (Conversions.ToBoolean(row.Cells["closed"].Value))
      {
        row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Appearance.ForeColor = Color.Red;
      }
    }
    ((Control) this.btnGo).Enabled = this.DsAdvancedCompanySearch1.tblCompanies.Rows.Count > 0;
  }

  [field: AccessedThroughProperty("txtName")]
  protected internal virtual MGATextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblName")]
  internal virtual Label lblName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFEIN")]
  protected virtual MGAMaskedEdit txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
