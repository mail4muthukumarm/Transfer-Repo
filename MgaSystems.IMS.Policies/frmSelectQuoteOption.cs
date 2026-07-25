// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmSelectQuoteOption
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmSelectQuoteOption : Form
{
  private Label Label1;
  private dsSelectQuoteOption ds;
  private readonly Guid _quoteGuid;
  private bool _itemSelected;

  private virtual MGAButton btnSelect
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

  private virtual UltraGrid dgOptions
  {
    get => this._dgOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      UltraGrid dgOptions1 = this._dgOptions;
      if (dgOptions1 != null)
        ((Control) dgOptions1).DoubleClick -= eventHandler;
      this._dgOptions = value;
      UltraGrid dgOptions2 = this._dgOptions;
      if (dgOptions2 == null)
        return;
      ((Control) dgOptions2).DoubleClick += eventHandler;
    }
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Options", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Line");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Premium");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Created");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Fees");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteOptionGUID");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectQuoteOption));
    this.btnSelect = new MGAButton();
    this.Label1 = new Label();
    this.dgOptions = new UltraGrid();
    this.ds = new dsSelectQuoteOption();
    ((ISupportInitialize) this.btnSelect).BeginInit();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSelect).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnSelect).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSelect).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSelect).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSelect).Location = new Point(622, 189);
    ((Control) this.btnSelect).Name = "btnSelect";
    ((Control) this.btnSelect).Size = new Size(40, 40);
    ((Control) this.btnSelect).TabIndex = 1;
    this.btnSelect.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(7, 7);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(287, 23);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Please select the option you would like to work with:";
    ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Company/Line";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 415;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn2.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 78;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn3.Format = "d";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 80 /*0x50*/;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance9;
    ultraGridColumn4.Header.VisiblePosition = 2;
    ultraGridColumn4.Width = 76;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 186;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgOptions).Location = new Point(11, 35);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(651, 147);
    ((Control) this.dgOptions).TabIndex = 4;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsSelectQuoteOption";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AcceptButton = (IButtonControl) this.btnSelect;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnSelect;
    this.ClientSize = new Size(673, 241);
    this.Controls.Add((Control) this.dgOptions);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSelect);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectQuoteOption);
    this.Text = "Select Quote Option";
    ((ISupportInitialize) this.btnSelect).EndInit();
    ((ISupportInitialize) this.dgOptions).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmSelectQuoteOption()
  {
    this.Load += new EventHandler(this.frmSelectQuoteDetail_Load);
    this.InitializeComponent();
  }

  public frmSelectQuoteOption(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmSelectQuoteDetail_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    ((ControlBase) this.btnSelect).Appearance.Image = (object) ImageCache.Instance.Forward;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "Options"
    }, this.GetSelectOptionStoredProcedure(), new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
  }

  public Guid QuoteOptionGuid
  {
    get => (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells[nameof (QuoteOptionGuid)].Value;
  }

  public bool ItemSelected => this._itemSelected;

  private void frmSelectQuoteDetail_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.dgOptions).ActiveRow = (UltraGridRow) null;
    this.dgOptions.Selected.Rows.Clear();
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    this._itemSelected = ((UltraGridBase) this.dgOptions).ActiveRow != null;
    this.Close();
  }

  protected virtual string GetSelectOptionStoredProcedure() => "dbo.spSelectQuoteOption";
}
