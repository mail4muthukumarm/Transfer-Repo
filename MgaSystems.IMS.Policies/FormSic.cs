// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormSic
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormSic : Form
{
  private IContainer components;
  private DataView _dv;
  private bool _makeSelection;

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
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstSIC_Codes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SIC_Description");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SIC_Family_Description");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ds = new dsSIC();
    this.btnSelect = new MGAButton();
    this.txtFamilyFilter = new MGATextBox();
    this.txtDescriptionFilter = new MGATextBox();
    this.txtSICFilter = new MGATextBox();
    this.ugSIC = new FixedUltraGrid();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSelect).BeginInit();
    ((ISupportInitialize) this.txtFamilyFilter).BeginInit();
    ((ISupportInitialize) this.txtDescriptionFilter).BeginInit();
    ((ISupportInitialize) this.txtSICFilter).BeginInit();
    ((ISupportInitialize) this.ugSIC).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsSIC";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSelect).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelect).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSelect).Location = new Point(633, 402);
    ((Control) this.btnSelect).Name = "btnSelect";
    ((Control) this.btnSelect).Size = new Size(40, 40);
    ((Control) this.btnSelect).TabIndex = 3;
    this.btnSelect.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.txtFamilyFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFamilyFilter).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtFamilyFilter).BackColor = Color.White;
    ((Control) this.txtFamilyFilter).Location = new Point(409, 12);
    ((Control) this.txtFamilyFilter).Name = "txtFamilyFilter";
    ((TextEditorControlBase) this.txtFamilyFilter).NullText = "Filter Family Description";
    ((Control) this.txtFamilyFilter).Size = new Size(158, 19);
    ((Control) this.txtFamilyFilter).TabIndex = 40;
    ((UltraControlBase) this.txtFamilyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFamilyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtDescriptionFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescriptionFilter).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtDescriptionFilter).BackColor = Color.White;
    ((Control) this.txtDescriptionFilter).Location = new Point(218, 12);
    ((Control) this.txtDescriptionFilter).Name = "txtDescriptionFilter";
    ((TextEditorControlBase) this.txtDescriptionFilter).NullText = "Filter Description";
    ((Control) this.txtDescriptionFilter).Size = new Size(158, 19);
    ((Control) this.txtDescriptionFilter).TabIndex = 39;
    ((UltraControlBase) this.txtDescriptionFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescriptionFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtSICFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSICFilter).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtSICFilter).BackColor = Color.White;
    ((Control) this.txtSICFilter).Location = new Point(12, 12);
    ((Control) this.txtSICFilter).Name = "txtSICFilter";
    ((TextEditorControlBase) this.txtSICFilter).NullText = "Filter SIC";
    ((Control) this.txtSICFilter).Size = new Size(158, 19);
    ((Control) this.txtSICFilter).TabIndex = 38;
    ((UltraControlBase) this.txtSICFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSICFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugSIC).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugSIC).DataMember = "lstSIC_Codes";
    ((UltraGridBase) this.ugSIC).DataSource = (object) this.ds;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSIC).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugSIC).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "SIC Code";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 119;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 236;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Family Description";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 285;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugSIC).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugSIC).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSIC).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 1;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.SelectedCellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.Transparent;
    appearance13.ForeColor = Color.MistyRose;
    ((UltraGridBase) this.ugSIC).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugSIC).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugSIC).Location = new Point(12, 49);
    ((Control) this.ugSIC).Name = "ugSIC";
    ((Control) this.ugSIC).Size = new Size(661, 338);
    ((Control) this.ugSIC).TabIndex = 2;
    ((UltraControlBase) this.ugSIC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSIC).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(685, 454);
    this.Controls.Add((Control) this.txtFamilyFilter);
    this.Controls.Add((Control) this.txtDescriptionFilter);
    this.Controls.Add((Control) this.txtSICFilter);
    this.Controls.Add((Control) this.btnSelect);
    this.Controls.Add((Control) this.ugSIC);
    this.Name = nameof (FormSic);
    this.Text = "SIC Selection";
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSelect).EndInit();
    ((ISupportInitialize) this.txtFamilyFilter).EndInit();
    ((ISupportInitialize) this.txtDescriptionFilter).EndInit();
    ((ISupportInitialize) this.txtSICFilter).EndInit();
    ((ISupportInitialize) this.ugSIC).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugSIC")]
  protected virtual FixedUltraGrid ugSIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsSIC ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSelect
  {
    get => this._btnSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      MGAButton btnSelect1 = this._btnSelect;
      if (btnSelect1 != null)
        ((Control) btnSelect1).Click -= eventHandler;
      this._btnSelect = value;
      MGAButton btnSelect2 = this._btnSelect;
      if (btnSelect2 == null)
        return;
      ((Control) btnSelect2).Click += eventHandler;
    }
  }

  protected virtual MGATextBox txtFamilyFilter
  {
    get => this._txtFamilyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFamilyFilter_TextChanged);
      MGATextBox txtFamilyFilter1 = this._txtFamilyFilter;
      if (txtFamilyFilter1 != null)
        ((Control) txtFamilyFilter1).TextChanged -= eventHandler;
      this._txtFamilyFilter = value;
      MGATextBox txtFamilyFilter2 = this._txtFamilyFilter;
      if (txtFamilyFilter2 == null)
        return;
      ((Control) txtFamilyFilter2).TextChanged += eventHandler;
    }
  }

  protected virtual MGATextBox txtDescriptionFilter
  {
    get => this._txtDescriptionFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtDescriptionFilter_TextChanged);
      MGATextBox descriptionFilter1 = this._txtDescriptionFilter;
      if (descriptionFilter1 != null)
        ((Control) descriptionFilter1).TextChanged -= eventHandler;
      this._txtDescriptionFilter = value;
      MGATextBox descriptionFilter2 = this._txtDescriptionFilter;
      if (descriptionFilter2 == null)
        return;
      ((Control) descriptionFilter2).TextChanged += eventHandler;
    }
  }

  protected virtual MGATextBox txtSICFilter
  {
    get => this._txtSICFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSICFilter_TextChanged);
      MGATextBox txtSicFilter1 = this._txtSICFilter;
      if (txtSicFilter1 != null)
        ((Control) txtSicFilter1).TextChanged -= eventHandler;
      this._txtSICFilter = value;
      MGATextBox txtSicFilter2 = this._txtSICFilter;
      if (txtSicFilter2 == null)
        return;
      ((Control) txtSicFilter2).TextChanged += eventHandler;
    }
  }

  public string SelectedSIC
  {
    get
    {
      return this._makeSelection ? (((UltraGridBase) this.ugSIC).ActiveRow != null ? ((UltraGridBase) this.ugSIC).ActiveRow.Cells["SIC_Code"].Value.ToString() : string.Empty) : string.Empty;
    }
  }

  public FormSic(DataView dv)
  {
    this.Load += new EventHandler(this.FormSic_Load);
    this._makeSelection = false;
    this.InitializeComponent();
    this._dv = dv;
  }

  private void FormSic_Load(object sender, EventArgs e)
  {
    this._makeSelection = false;
    MGAButton btnSelect = this.btnSelect;
    ((ControlBase) btnSelect).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) btnSelect).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) btnSelect).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) btnSelect).ImageSize = new Size(24, 24);
    ((ControlBase) btnSelect).ImageTransparentColor = Color.Magenta;
    try
    {
      foreach (DataRow row in this._dv.Table.Rows)
        this.ds.lstSIC_Codes.AddlstSIC_CodesRow(row.Field<string>("SIC_Code"), row.Field<string>("SIC_Description"), row.Field<string>("SIC_Family_Description"));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ugSIC).UpdateData();
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    this._makeSelection = true;
    this.Close();
  }

  private void ApplyFilter(string containsString, string columnName)
  {
    string str1 = ((TextEditorControlBase) this.txtSICFilter).Text.Replace(" ", string.Empty).ToString();
    string str2 = ((TextEditorControlBase) this.txtDescriptionFilter).Text.Replace(" ", string.Empty).ToString();
    string str3 = ((TextEditorControlBase) this.txtFamilyFilter).Text.Replace(" ", string.Empty).ToString();
    foreach (UltraGridRow row in ((UltraGridBase) this.ugSIC).Rows)
    {
      bool flag1 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["SIC_Code"].Value));
      bool flag2 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["SIC_Description"].Value));
      bool flag3 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["SIC_Family_Description"].Value));
      bool flag4 = true;
      bool flag5 = true;
      bool flag6 = true;
      if (string.IsNullOrEmpty(str1) && string.IsNullOrEmpty(str2) && string.IsNullOrEmpty(str3))
        row.Hidden = false;
      else if (!flag1 && !flag2 && !flag3)
      {
        row.Hidden = false;
      }
      else
      {
        if (str1.Replace(" ", string.Empty).Length > 0)
          flag4 = flag1 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["SIC_Code"].Value.ToString(), str1);
        if (str2.Replace(" ", string.Empty).Length > 0)
          flag5 = flag2 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["SIC_Description"].Value.ToString(), str2);
        if (str3.Replace(" ", string.Empty).Length > 0)
          flag6 = flag3 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["SIC_Family_Description"].Value.ToString(), str3);
        row.Hidden = !flag4 || !flag5 || !flag6;
      }
    }
  }

  private void txtSICFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtSICFilter).Text, "SIC_Code");
  }

  private void txtDescriptionFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtDescriptionFilter).Text, "SIC_Description");
  }

  private void txtFamilyFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtFamilyFilter).Text, "SIC_Family_Description");
  }
}
