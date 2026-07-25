// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormExlAdditionalInfo
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerGenerated]
public class FormExlAdditionalInfo : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private bool _nextClicked;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtReports", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Report");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RowSelection");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtSupplements", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Supplement");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RowSelection");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.btnNext = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.ugReports = new UltraGrid();
    this.ds = new dsExlAddInfo();
    this.ugSupplements = new UltraGrid();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ugReports).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugSupplements).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnNext).Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNext).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNext).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNext).Location = new Point(375, 637);
    ((Control) this.btnNext).Name = "btnNext";
    ((ControlBase) this.btnNext).Padding = new Size(5, 0);
    ((Control) this.btnNext).Size = new Size(96 /*0x60*/, 36);
    ((Control) this.btnNext).TabIndex = 4;
    ((ControlBase) this.btnNext).Text = "Next";
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.ugReports).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugReports).DataMember = "dtReports";
    ((UltraGridBase) this.ugReports).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugReports).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugReports).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 374;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 83;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ugReports).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugReports).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugReports).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.White;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.AddRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugReports).DisplayLayout.Override.WrapHeaderText = (DefaultableBoolean) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugReports).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugReports).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugReports).Font = new Font("Tahoma", 8f);
    ((Control) this.ugReports).Location = new Point(12, 12);
    ((Control) this.ugReports).Name = "ugReports";
    ((Control) this.ugReports).Size = new Size(459, 240 /*0xF0*/);
    ((Control) this.ugReports).TabIndex = 5;
    ((UltraControlBase) this.ugReports).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugReports).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsExlAddInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugSupplements).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugSupplements).DataMember = "dtSupplements";
    ((UltraGridBase) this.ugSupplements).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Supplements";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 388;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 69;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugSupplements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugSupplements).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.LightSteelBlue;
    appearance12.FontData.SizeInPoints = 10f;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.White;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.AddRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance17.BackColor = Color.FromArgb(246, 250, 253);
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance17;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.Transparent;
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.Override.WrapHeaderText = (DefaultableBoolean) 2;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugSupplements).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugSupplements).Font = new Font("Tahoma", 8f);
    ((Control) this.ugSupplements).Location = new Point(12, 262);
    ((Control) this.ugSupplements).Name = "ugSupplements";
    ((Control) this.ugSupplements).Size = new Size(459, 356);
    ((Control) this.ugSupplements).TabIndex = 2;
    ((UltraControlBase) this.ugSupplements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSupplements).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(483, 685);
    this.Controls.Add((Control) this.ugReports);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.ugSupplements);
    this.Name = nameof (FormExlAdditionalInfo);
    this.Text = "EXL Inspections - Additional Info";
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ugReports).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugSupplements).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugSupplements")]
  protected virtual UltraGrid ugSupplements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnNext
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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsExlAddInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugReports")]
  protected virtual UltraGrid ugReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormExlAdditionalInfo(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormExlAdditionalInfo_Load);
    this._nextClicked = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  public string Report
  {
    get
    {
      string str = string.Empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugReports).Rows)
      {
        if (row.Cells["RowSelection"].Value != DBNull.Value && row.Cells[nameof (Report)].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["RowSelection"].Value))
          str = $"{str}{row.Cells[nameof (Report)].Value.ToString()}, ";
      }
      return string.IsNullOrEmpty(str) ? string.Empty : "Report:" + str;
    }
  }

  public string Supplements
  {
    get
    {
      string str = string.Empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugSupplements).Rows)
      {
        if (row.Cells["RowSelection"].Value != DBNull.Value && row.Cells["Supplement"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["RowSelection"].Value))
          str = $"{str}{row.Cells["Supplement"].Value.ToString()}, ";
      }
      return string.IsNullOrEmpty(str) ? string.Empty : "Supplements:" + str;
    }
  }

  public bool NextClicked => this._nextClicked;

  private void FormExlAdditionalInfo_Load(object sender, EventArgs e)
  {
    DataTable dataTable1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Description From lstInspectionExlReports with (nolock) ORDER BY Description ");
    try
    {
      foreach (DataRow row in dataTable1.Rows)
        this.ds.dtReports.AdddtReportsRow(row[0].ToString(), false);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Description From lstInspectionExlSupplements with (nolock) ORDER BY Description");
    try
    {
      foreach (DataRow row in dataTable2.Rows)
        this.ds.dtSupplements.AdddtSupplementsRow(row[0].ToString(), false);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._nextClicked = false;
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    this._nextClicked = false;
    if (this.Report.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("Please select a report in order to continue", "Missing Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._nextClicked = true;
      this.Close();
    }
  }
}
