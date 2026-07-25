// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCombineInsureds
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCombineInsureds : Form
{
  private IContainer components;
  private readonly Guid _insuredGuid;
  private readonly string _insuredName;

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCombineInsureds));
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtCombineInsured", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InsuredGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("InsuredName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InsuredID");
    Appearance appearance5 = new Appearance();
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
    this.label3 = new Label();
    this.txtSearchInsured = new MGATextBox();
    this.btnSearch = new MGAButton();
    this.btnCombine = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.ds = new dsCombineInsured();
    this.dgInsureds = new UltraGrid();
    ((ISupportInitialize) this.txtSearchInsured).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnCombine).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgInsureds).BeginInit();
    this.SuspendLayout();
    this.label3.AutoSize = true;
    this.label3.Location = new Point(16 /*0x10*/, 23);
    this.label3.Name = "label3";
    this.label3.Size = new Size(76, 13);
    this.label3.TabIndex = 212;
    this.label3.Text = "Insured Name:";
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSearchInsured).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtSearchInsured).BackColor = Color.White;
    ((Control) this.txtSearchInsured).Location = new Point(98, 20);
    ((TextEditorControlBase) this.txtSearchInsured).MaxLength = 60;
    this.txtSearchInsured.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSearchInsured).Name = "txtSearchInsured";
    ((Control) this.txtSearchInsured).Size = new Size(231, 19);
    ((Control) this.txtSearchInsured).TabIndex = 211;
    ((UltraControlBase) this.txtSearchInsured).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSearchInsured).UseOsThemes = (DefaultableBoolean) 2;
    this.txtSearchInsured.WordWrap = false;
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(648, 12);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 35);
    ((Control) this.btnSearch).TabIndex = 213;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCombine).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnCombine).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnCombine).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnCombine).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCombine).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCombine).Location = new Point(576, 389);
    ((Control) this.btnCombine).Name = "btnCombine";
    ((ControlBase) this.btnCombine).Padding = new Size(5, 0);
    ((Control) this.btnCombine).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.btnCombine).TabIndex = 215;
    ((ControlBase) this.btnCombine).Text = "Combine";
    this.btnCombine.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.ds.DataSetName = "dsCombineInsured";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgInsureds).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgInsureds).DataSource = (object) this.ds;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.SlateGray;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Insured Name";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 250;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 341;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Insured ID";
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 80 /*0x50*/;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ultraGridBand.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 2;
    ultraGridBand.Override.GroupByColumnsHidden = (DefaultableBoolean) 2;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand.Override.MaxSelectedRows = 6;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgInsureds).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance7.BackColor = SystemColors.ActiveBorder;
    appearance7.BackColor2 = SystemColors.ControlDark;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dgInsureds).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance7;
    appearance8.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance8;
    ((SpecialBoxBase) ((UltraGridBase) this.dgInsureds).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.dgInsureds).DisplayLayout.GroupByBox).Hidden = true;
    appearance9.BackColor = SystemColors.ControlLightLight;
    appearance9.BackColor2 = SystemColors.Control;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.MaxRowScrollRegions = 1;
    appearance10.BackColor = SystemColors.Window;
    appearance10.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = SystemColors.Highlight;
    appearance11.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance12.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.Silver;
    appearance13.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.CellPadding = 0;
    appearance14.BackColor = SystemColors.Control;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientAlignment = (GradientAlignment) 1;
    appearance14.BackGradientStyle = (GradientStyle) 3;
    appearance14.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance16.BackColor = SystemColors.Window;
    appearance16.BorderColor = Color.Silver;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dgInsureds).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dgInsureds).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgInsureds).Location = new Point(14, 59);
    ((Control) this.dgInsureds).Name = "dgInsureds";
    ((Control) this.dgInsureds).Size = new Size(673, 314);
    ((Control) this.dgInsureds).TabIndex = 216;
    ((Control) this.dgInsureds).Text = "Insureds to Combine";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(700, 441);
    this.Controls.Add((Control) this.dgInsureds);
    this.Controls.Add((Control) this.btnCombine);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.txtSearchInsured);
    this.Name = nameof (FormCombineInsureds);
    this.Text = "Combine Insureds";
    ((ISupportInitialize) this.txtSearchInsured).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnCombine).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgInsureds).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("label3")]
  private virtual Label label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSearchInsured")]
  private virtual MGATextBox txtSearchInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
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

  private virtual MGAButton btnCombine
  {
    get => this._btnCombine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCombine_Click);
      MGAButton btnCombine1 = this._btnCombine;
      if (btnCombine1 != null)
        ((Control) btnCombine1).Click -= eventHandler;
      this._btnCombine = value;
      MGAButton btnCombine2 = this._btnCombine;
      if (btnCombine2 == null)
        return;
      ((Control) btnCombine2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCombineInsured ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgInsureds")]
  internal virtual UltraGrid dgInsureds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCombineInsureds(Guid insuredGuid)
  {
    this.Load += new EventHandler(this.FormCombineInsureds_Load);
    this.InitializeComponent();
    this._insuredGuid = insuredGuid;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    this._insuredName = new Insured(insuredGuid).Name;
    ((Control) this.dgInsureds).Text = $"Available Insureds to Combine with [{this._insuredName}]";
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    this.ds.dtCombineInsured.Rows.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtCombineInsured"
    }, "dbo.GetInsuredsToCombine", new object[4]
    {
      (object) "@insuredGuid",
      (object) this._insuredGuid,
      (object) "@InsuredName",
      (object) ((TextEditorControlBase) this.txtSearchInsured).Text
    });
  }

  private void btnCombine_Click(object sender, EventArgs e)
  {
    if (this.ds.dtCombineInsured.Rows.Count == 0)
    {
      int num1 = (int) MessageBox.Show("No Insured is available for selection to be combined.", "No Insured Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.dgInsureds.Selected.Rows.Count == 0)
    {
      int num2 = (int) MessageBox.Show("No Insured is selected to be combined.", "No Insured Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      string str1 = string.Empty;
      foreach (UltraGridRow row in this.dgInsureds.Selected.Rows)
        str1 = $"{str1}{row.Cells["InsuredName"].Value.ToString()}\n";
      if (MessageBox.Show($"Are you sure you want to combine the following insured(s):\n\n{str1}\n with \n\n{this._insuredName} ?", "Combine Insureds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      int num3 = 0;
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        RowEnumerator enumerator1 = this.dgInsureds.Selected.Rows.GetEnumerator();
        while (enumerator1.MoveNext())
        {
          UltraGridRow current = enumerator1.Current;
          Guid guid = (Guid) current.Cells["InsuredGUID"].Value;
          string str2 = "SELECT SubmissionGroupGUID FROM tblSubmissionGroup WHERE InsuredGuid = @IN";
          try
          {
            foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, str2, new object[2]
            {
              (object) "@IN",
              (object) guid
            }).Rows)
            {
              if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsDirectBillMGA(@submissionGroupGuid)", new object[2]
              {
                (object) "@submissionGroupGuid",
                row[0]
              }))
              {
                if (DefaultDatabase.ExecuteNonQuery("dbo.spCombineInsureds", new object[6]
                {
                  (object) "@InsuredGuidFrom",
                  (object) guid,
                  (object) "@InsuredGuidTo",
                  (object) this._insuredGuid,
                  (object) "@submissionGroupGuid",
                  row[0]
                }) != 0)
                  ++num3;
              }
            }
          }
          finally
          {
            IEnumerator enumerator2;
            if (enumerator2 is IDisposable)
              (enumerator2 as IDisposable).Dispose();
          }
          current.Hidden = true;
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      if (num3 > 0)
      {
        int num4 = (int) MessageBox.Show(Conversions.ToString(num3) + " submission group row(s) affected", "Insured Combined Completed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num5 = (int) MessageBox.Show("0 submission group row affected", "Insured Combined Completed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }

  private void FormCombineInsureds_Load(object sender, EventArgs e)
  {
    this.Text = $"Combine Insureds with [ {this._insuredName} ]";
  }
}
