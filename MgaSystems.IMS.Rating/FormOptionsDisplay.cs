// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormOptionsDisplay
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormOptionsDisplay : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private bool _choseOption;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtOptions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteOptionID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Bound");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Quote");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Premium");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Fees");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Selected");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.btnContinue = new MGAButton();
    this.ug = new UltraGrid();
    this.ds = new copyLocatons();
    ((ISupportInitialize) this.btnContinue).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnContinue).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 3;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Left";
    ((ControlBase) this.btnContinue).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnContinue).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnContinue).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnContinue).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnContinue).Location = new Point(537, 417);
    ((Control) this.btnContinue).Name = "btnContinue";
    ((ControlBase) this.btnContinue).Padding = new Size(5, 0);
    ((Control) this.btnContinue).Size = new Size(104, 40);
    ((Control) this.btnContinue).TabIndex = 9;
    ((Control) this.btnContinue).Tag = (object) "";
    ((ControlBase) this.btnContinue).Text = "Select";
    this.btnContinue.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "dtOptions";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 126;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 305;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 5;
    ultraGridColumn3.Width = 46;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 6;
    ultraGridColumn4.Width = 44;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn5.Format = "c";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 79;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn6.Format = "c";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Width = 79;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 55;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.MidnightBlue;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ug).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ug).Location = new Point(12, 12);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(629, 381);
    ((Control) this.ug).TabIndex = 10;
    ((Control) this.ug).Text = "Available Options(s)";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "copyLocatons";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(653, 469);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.btnContinue);
    this.Name = nameof (FormOptionsDisplay);
    this.Text = "Options Display";
    ((ISupportInitialize) this.btnContinue).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private virtual MGAButton btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      MGAButton btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        ((Control) btnContinue1).Click -= eventHandler;
      this._btnContinue = value;
      MGAButton btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      ((Control) btnContinue2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ug")]
  private virtual UltraGrid ug { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual copyLocatons ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public int QuoteOption
  {
    get
    {
      int quoteOption;
      if (!this._choseOption)
      {
        quoteOption = int.MinValue;
      }
      else
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
        {
          if (row.Cells["Selected"].Value != null && row.Cells["Selected"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Selected"].Value))
          {
            quoteOption = Conversions.ToInteger(row.Cells["QuoteOptionID"].Value);
            goto label_7;
          }
        }
        quoteOption = int.MinValue;
      }
label_7:
      return quoteOption;
    }
  }

  public FormOptionsDisplay(int controlNo)
  {
    this.Load += new EventHandler(this.FormOptionsDisplay_Load);
    this._choseOption = false;
    this.InitializeComponent();
    this._quoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT top 1 QuoteGuid FROM tblQuotes with (nolock) where ControlNo= @CN ORDER BY QuoteID DESC", new object[2]
    {
      (object) "@CN",
      (object) controlNo
    });
  }

  private void FormOptionsDisplay_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnContinue).Appearance.Image = (object) ImageCache.Instance.Forward;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtOptions"
    }, CommandType.Text, "SELECT \r\n\t\t\tQuoteOptionID,\r\n\t\t\t(select LocationName from tblCompanyLocations C with (nolock) where C.CompanyLocationCode = O.CompanyLocationID) as Company ,\r\n\t\t\tPremium, \r\n\t\t\tTotalFees as Fees, \r\n\t\t\tBound,\t\t\r\n\t\t\tQuote\t\r\n\t        from tblQuoteOptions O with (nolock)\r\n\t        where QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
  }

  private void btnContinue_Click(object sender, EventArgs e)
  {
    this._choseOption = false;
    int num1 = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
    {
      if (row.Cells["Selected"].Value != null && row.Cells["Selected"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Selected"].Value))
        ++num1;
    }
    if (num1 > 1)
    {
      int num2 = (int) MessageBox.Show("Cannot select more than one option.", "Option Selection Invalid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this._choseOption = true;
      this.Close();
    }
  }
}
