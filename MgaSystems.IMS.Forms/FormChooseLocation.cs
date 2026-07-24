// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormChooseLocation
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormChooseLocation : FormBase
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private readonly Guid _lineGuid;
  private readonly bool _usingNetRate;
  private bool _select;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ZipCode");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ugLocations = new UltraGrid();
    this.ds = new dsChooseLoc();
    this.btnSelect = new Button();
    ((ISupportInitialize) this.ugLocations).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugLocations).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLocations).DataMember = "dtLocations";
    ((UltraGridBase) this.ugLocations).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Location ID";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Width = 236;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 232;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 120;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 204;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 112 /*0x70*/;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
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
    ((UltraGridBase) this.ugLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.MaxRowScrollRegions = 40;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugLocations).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLocations).Location = new Point(12, 12);
    ((Control) this.ugLocations).Name = "ugLocations";
    ((Control) this.ugLocations).Size = new Size(1042, 387);
    ((Control) this.ugLocations).TabIndex = 14;
    ((Control) this.ugLocations).Text = "Available Locations";
    ((UltraControlBase) this.ugLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsChooseLoc";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnSelect.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSelect.Location = new Point(979, 441);
    this.btnSelect.Name = "btnSelect";
    this.btnSelect.Size = new Size(75, 23);
    this.btnSelect.TabIndex = 15;
    this.btnSelect.Text = "Select";
    this.btnSelect.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1066, 476);
    this.Controls.Add((Control) this.btnSelect);
    this.Controls.Add((Control) this.ugLocations);
    this.Name = nameof (FormChooseLocation);
    this.Text = "Choose Location";
    ((ISupportInitialize) this.ugLocations).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugLocations")]
  protected virtual UltraGrid ugLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnSelect
  {
    get => this._btnSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      Button btnSelect1 = this._btnSelect;
      if (btnSelect1 != null)
        btnSelect1.Click -= eventHandler;
      this._btnSelect = value;
      Button btnSelect2 = this._btnSelect;
      if (btnSelect2 == null)
        return;
      btnSelect2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsChooseLoc ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormChooseLocation(Guid quoteGuid, Guid lineguid, bool usingNetRate)
  {
    this.Load += new EventHandler(this.FormChooseLocation_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._lineGuid = lineguid;
    this._usingNetRate = usingNetRate;
  }

  public bool MakeSelection => this._select;

  public int LocationID
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (LocationID)].Value)) ? -1 : Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (LocationID)].Value);
    }
  }

  public string Loc
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells["Location"].Value)) ? string.Empty : Conversions.ToString(((UltraGridBase) this.ugLocations).ActiveRow.Cells["Location"].Value);
    }
  }

  public string Address
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (Address)].Value)) ? string.Empty : Conversions.ToString(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (Address)].Value);
    }
  }

  public string Address2
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (Address2)].Value)) ? string.Empty : Conversions.ToString(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (Address2)].Value);
    }
  }

  public string City
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (City)].Value)) ? string.Empty : Conversions.ToString(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (City)].Value);
    }
  }

  public string State
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (State)].Value)) ? string.Empty : Conversions.ToString(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (State)].Value);
    }
  }

  public string ZipCode
  {
    get
    {
      return ((UltraGridBase) this.ugLocations).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (ZipCode)].Value)) ? string.Empty : Conversions.ToString(((UltraGridBase) this.ugLocations).ActiveRow.Cells[nameof (ZipCode)].Value);
    }
  }

  private void FormChooseLocation_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtLocations"
    }, "ShowAdminRequestLocations", new object[6]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid,
      (object) "@LineGuid",
      (object) this._lineGuid,
      (object) "@UsingNetRate",
      (object) this._usingNetRate
    });
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    this._select = true;
    this.Close();
  }
}
