// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormDeleteBulkCompanyLine
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormDeleteBulkCompanyLine : Form
{
  private IContainer components;
  private Guid _companyLocationGuid;
  private Guid _lineGuid;
  private string _stateID;
  private bool _isParentLine;
  private int _numRows;
  private bool _rowsDeleted;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtDeletes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLine");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Parent");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DeleteLine");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormDeleteBulkCompanyLine));
    this.ugCompanyLine = new UltraGrid();
    this.ds = new dsCompanyLines();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.btnDelete = new MGAButton();
    ((ISupportInitialize) this.ugCompanyLine).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugCompanyLine).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugCompanyLine).DataMember = "dtDeletes";
    ((UltraGridBase) this.ugCompanyLine).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 353;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company/ Line";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 625;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 75;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Delete";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 70;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugCompanyLine).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugCompanyLine).Location = new Point(13, 10);
    ((Control) this.ugCompanyLine).Name = "ugCompanyLine";
    ((Control) this.ugCompanyLine).Size = new Size(772, 538);
    ((Control) this.ugCompanyLine).TabIndex = 217;
    ((Control) this.ugCompanyLine).Text = "Available Company/Lines";
    ((UltraControlBase) this.ugCompanyLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCompanyLine).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLines";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(10, 564);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 218;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(12, 591);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(68, 13);
    this.lnkDeSelectAll.TabIndex = 219;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.Transparent;
    appearance9.BackColor2 = SystemColors.ButtonShadow;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = SystemColors.MenuText;
    appearance9.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image"));
    appearance9.ImageHAlign = (HAlign) 1;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnDelete).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnDelete).Location = new Point(688, 564);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((ControlBase) this.btnDelete).Padding = new Size(5, 0);
    ((Control) this.btnDelete).Size = new Size(97, 40);
    ((Control) this.btnDelete).TabIndex = 220;
    ((ControlBase) this.btnDelete).Text = "Delete";
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(797, 616);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.ugCompanyLine);
    this.Name = nameof (FormDeleteBulkCompanyLine);
    this.Text = "Delete Company/Line";
    ((ISupportInitialize) this.ugCompanyLine).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugCompanyLine")]
  private virtual UltraGrid ugCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLines ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      MGAButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      MGAButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  public FormDeleteBulkCompanyLine(
    Guid companyLocationGuid,
    Guid lineGuid,
    string stateID,
    bool isParentLine)
  {
    this.Load += new EventHandler(this.FormDeleteBulkCompanyLine_Load);
    this._rowsDeleted = false;
    this.InitializeComponent();
    this._companyLocationGuid = companyLocationGuid;
    this._lineGuid = lineGuid;
    this._stateID = stateID;
  }

  public FormDeleteBulkCompanyLine()
  {
    this.Load += new EventHandler(this.FormDeleteBulkCompanyLine_Load);
    this._rowsDeleted = false;
    this.InitializeComponent();
  }

  private void FormDeleteBulkCompanyLine_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtDeletes"
    }, CommandType.StoredProcedure, "spBulkDeleteCompanyLineLoad", new object[6]
    {
      (object) "@CompanyLocationGuid",
      (object) this._companyLocationGuid,
      (object) "@LineGuid",
      (object) this._lineGuid,
      (object) "@StateID",
      (object) this._stateID
    });
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(false);
  }

  private void SetGridSelection(bool deleteValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugCompanyLine).Rows)
      row.Cells["DeleteLine"].Value = (object) deleteValue;
  }

  private int SelectedGridCount()
  {
    int num = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugCompanyLine).Rows)
    {
      if (row.Cells["DeleteLine"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["DeleteLine"].Value))
        ++num;
    }
    return num;
  }

  public bool DeletedCompanyLineRows => this._rowsDeleted;

  private void btnDelete_Click(object sender, EventArgs e)
  {
    this._rowsDeleted = false;
    if (this.SelectedGridCount() == 0)
    {
      int num1 = (int) MessageBox.Show("No row is selected for delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show($"You are about to delete {this.SelectedGridCount().ToString()} other company/line(s) with the same company and line.", "Continue Bulk Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this._rowsDeleted = true;
      string str = string.Empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugCompanyLine).Rows)
      {
        if (row.Cells["CompanyLineGuid"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["DeleteLine"].Value))
          str = $"{str}{row.Cells["CompanyLineGuid"].Value.ToString()},";
      }
      int num2 = (int) MessageBox.Show(Conversions.ToString(DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "spBulkDeleteCompanyLine", 300, (CommandArgumentType) 0, new object[10]
      {
        (object) "@CurrentState",
        (object) this._stateID,
        (object) "@CurrentLineGuid",
        (object) this._lineGuid,
        (object) "@CurrentCompanyLocationGuid",
        (object) this._companyLocationGuid,
        (object) "@IsParentLine",
        (object) this._isParentLine,
        (object) "@companyLineGuidStr",
        (object) str
      })) + " record(s) deleted.", "Bulk Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.Close();
    }
  }
}
