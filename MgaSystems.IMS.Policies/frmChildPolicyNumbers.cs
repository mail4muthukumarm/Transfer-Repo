// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmChildPolicyNumbers
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class frmChildPolicyNumbers : Form
{
  private IContainer components;
  private DataTable _dtQuoteDetails;
  private Guid _quoteGuid;
  private List<int> _quoteDetailIds;

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
    UltraGridBand ultraGridBand = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLine");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Clear");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("QuoteDetailID", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLineGuid", 1);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    this.Label1 = new Label();
    this.ugChildPolicyNumbers = new UltraGrid();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.ugChildPolicyNumbers).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(297, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select the child policy numbers you would like to clear:";
    ((Control) this.ugChildPolicyNumbers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugChildPolicyNumbers).Cursor = Cursors.Hand;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Line";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 156;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Number";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 167;
    ultraGridColumn3.CellClickAction = (CellClickAction) 1;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 67;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 51;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 55;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugChildPolicyNumbers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugChildPolicyNumbers).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugChildPolicyNumbers).Location = new Point(15, 36);
    ((Control) this.ugChildPolicyNumbers).Name = "ugChildPolicyNumbers";
    ((Control) this.ugChildPolicyNumbers).Size = new Size(392, 196);
    ((Control) this.ugChildPolicyNumbers).TabIndex = 6;
    ((UltraControlBase) this.ugChildPolicyNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugChildPolicyNumbers).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(367, 238);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 7;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(419, 290);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugChildPolicyNumbers);
    this.Controls.Add((Control) this.Label1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.MinimumSize = new Size(425, 315);
    this.Name = nameof (frmChildPolicyNumbers);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Child Policy Numbers";
    ((ISupportInitialize) this.ugChildPolicyNumbers).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugChildPolicyNumbers")]
  private virtual UltraGrid ugChildPolicyNumbers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSave
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

  public DataTable DtQuoteDetails => this._dtQuoteDetails;

  public int[] QuoteDetailIds => this._quoteDetailIds.ToArray();

  public frmChildPolicyNumbers(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmChildPolicyNumbers_Load);
    this._dtQuoteDetails = (DataTable) null;
    this._quoteGuid = Guid.Empty;
    this._quoteDetailIds = new List<int>();
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._dtQuoteDetails = DefaultDatabase.ExecuteDataTable("spGetQuoteDetailPolicyNumberInfo", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
  }

  private void frmChildPolicyNumbers_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((UltraGridBase) this.ugChildPolicyNumbers).DataSource = (object) this._dtQuoteDetails;
    ((UltraGridBase) this.ugChildPolicyNumbers).DataBind();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    DataRow[] dataRowArray = this._dtQuoteDetails.Select("Clear = 1");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      this._quoteDetailIds.Add((int) dataRowArray[index]["QuoteDetailId"]);
      checked { ++index; }
    }
    this.Close();
  }
}
