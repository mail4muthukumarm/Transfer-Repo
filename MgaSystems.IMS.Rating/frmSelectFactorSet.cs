// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmSelectFactorSet
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.InfragisticsExtensions.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class frmSelectFactorSet : Form
{
  private IContainer components;
  private Label Label1;
  private UltraGrid dg;
  private dsSelectFactorset ds;
  private readonly int _raterID;
  private readonly Guid _companyLineGuid;
  private Guid _selectedFactorSetGuid;
  private Guid _quoteGuid;

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblFactorSets", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FactorSetGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Title");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Memo");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Select");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.Label1 = new Label();
    this.dg = new UltraGrid();
    this.ds = new dsSelectFactorset();
    ((ISupportInitialize) this.dg).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(360, 24);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "The following factor sets are available for this company and rater type:";
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dg).Cursor = Cursors.Default;
    ((UltraGridBase) this.dg).DataSource = (object) this.ds.tblFactorSets;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 219;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.Format = "d";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Effective";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 138;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 149;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 149;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 146;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(584, 168);
    ((Control) this.dg).TabIndex = 1;
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsSelectFactorset";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(600, 206);
    this.Controls.Add((Control) this.dg);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectFactorSet);
    this.Text = "Rating Factor Set Selection";
    ((ISupportInitialize) this.dg).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private virtual HyperlinkEditor _hlk
  {
    get => this.__hlk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this._hlk_HyperLinkOpening);
      HyperlinkEditor hlk1 = this.__hlk;
      if (hlk1 != null)
        hlk1.HyperLinkOpening -= cancelEventHandler;
      this.__hlk = value;
      HyperlinkEditor hlk2 = this.__hlk;
      if (hlk2 == null)
        return;
      hlk2.HyperLinkOpening += cancelEventHandler;
    }
  }

  public Guid FactorSetGuid => this._selectedFactorSetGuid;

  public Guid QuoteGuid
  {
    get => this._quoteGuid;
    set => this._quoteGuid = value;
  }

  public frmSelectFactorSet(int raterID)
    : this(raterID, Guid.Empty)
  {
  }

  public frmSelectFactorSet(int raterID, Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmSelectFactorSet_Load);
    this._hlk = new HyperlinkEditor();
    this.InitializeComponent();
    ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["Select"].Editor = (EmbeddableEditorBase) this._hlk;
    this._raterID = raterID;
    this._companyLineGuid = companyLineGuid;
  }

  private void frmSelectFactorSet_Load(object sender, EventArgs e)
  {
    if (this._companyLineGuid == Guid.Empty)
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblFactorSets"
      }, CommandType.Text, "SELECT f.FactorSetGUID, f.EffectiveDate, f.Title, f.RaterID, f.Memo FROM tblFactorSets f where f.Hidden = 0 and RaterId = @RaterID", new object[4]
      {
        (object) "@RaterID",
        (object) this._raterID,
        (object) "@CompanyLineGuid",
        (object) this._companyLineGuid
      });
    else
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblFactorSets"
      }, "dbo.GetCompanyFactorSets", new object[4]
      {
        (object) "@RaterID",
        (object) this._raterID,
        (object) "@CompanyLineGuid",
        (object) this._companyLineGuid
      });
    if (SystemSettings.KeyExists("ShowFactorSetEffectiveDates") && SystemSettings.GetBoolSetting("ShowFactorSetEffectiveDates") && this.ds.tblFactorSets.Columns.Contains("EffectiveDate"))
    {
      if (this.ds.tblFactorSets.Columns.Contains("Title"))
      {
        try
        {
          foreach (DataRow tblFactorSet in (TypedTableBase<dsSelectFactorset.tblFactorSetsRow>) this.ds.tblFactorSets)
          {
            if (tblFactorSet["EffectiveDate"] != null && tblFactorSet["Title"] != null)
              tblFactorSet["Title"] = (object) $"{tblFactorSet["Title"].ToString()} ({((DateTime) tblFactorSet["EffectiveDate"]).ToString("M/d/yy")})";
          }
        }
        finally
        {
          IEnumerator<dsSelectFactorset.tblFactorSetsRow> enumerator;
          enumerator?.Dispose();
        }
        ((UltraGridBase) this.dg).DisplayLayout.Bands[0].Columns["EffectiveDate"].SortIndicator = (SortIndicator) 2;
      }
    }
    this.OnFormLoad(this.ds);
  }

  protected virtual void OnFormLoad(dsSelectFactorset ds)
  {
  }

  private void _hlk_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    this._selectedFactorSetGuid = (Guid) ((UltraGridBase) this.dg).ActiveRow.Cells["FactorSetGuid"].Value;
    e.Cancel = true;
    this.Close();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      ((DisposableObject) this._hlk).Dispose();
      if (this.components != null)
        this.components.Dispose();
    }
    base.Dispose(disposing);
  }
}
