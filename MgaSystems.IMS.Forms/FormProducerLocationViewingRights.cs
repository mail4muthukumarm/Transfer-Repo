// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormProducerLocationViewingRights
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
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
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormProducerLocationViewingRights : Form
{
  private IContainer components;
  private bool _painted;
  private readonly Guid _userGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUserProducerLocationViewingRights", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Remove");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AddAccess");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.btnSearch = new MGAButton();
    this.txtSearch = new TextBox();
    this.btnGo = new MGAButton();
    this.lnkDeselectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.ugAvail = new UltraGrid();
    this.ds = new dsViewProducerLocationViewingRights();
    this.ugSearch = new UltraGrid();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugSearch).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(328, 7);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 8;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.txtSearch.Location = new Point(12, 12);
    this.txtSearch.MaxLength = 150;
    this.txtSearch.Name = "txtSearch";
    this.txtSearch.Size = new Size(296, 20);
    this.txtSearch.TabIndex = 7;
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnGo).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(322, 537);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 15;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.Location = new Point(83, 559);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(68, 13);
    this.lnkDeselectAll.TabIndex = 14;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(6, 559);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 13;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataMember = "tblUserProducerLocationViewingRights";
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 243;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 353;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 51;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugAvail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugAvail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugAvail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAvail).Location = new Point(546, 5);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(406, 572);
    ((Control) this.ugAvail).TabIndex = 12;
    ((Control) this.ugAvail).Text = "Accessible Locations";
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsViewProducerLocationViewingRights";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraControlBase) this.ugSearch).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugSearch).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.ugSearch).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 311;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 463;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Add Access";
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 68;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ugSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.LightSteelBlue;
    appearance12.FontData.SizeInPoints = 10f;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.Transparent;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugSearch).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugSearch).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugSearch).Location = new Point(7, 57);
    ((Control) this.ugSearch).Name = "ugSearch";
    ((Control) this.ugSearch).Size = new Size(533, 474);
    ((Control) this.ugSearch).TabIndex = 11;
    ((Control) this.ugSearch).Text = "Producer Locations Search Results";
    ((UltraControlBase) this.ugSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(959, 581);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.lnkDeselectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.ugAvail);
    this.Controls.Add((Control) this.ugSearch);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.txtSearch);
    this.Name = nameof (FormProducerLocationViewingRights);
    this.Text = "Producer Location Viewing Rights";
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugSearch).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

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

  [field: AccessedThroughProperty("txtSearch")]
  internal virtual TextBox txtSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugAvail
  {
    get => this._ugAvail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugAvail_CellChange);
      UltraGrid ugAvail1 = this._ugAvail;
      if (ugAvail1 != null)
        ugAvail1.CellChange -= cellEventHandler;
      this._ugAvail = value;
      UltraGrid ugAvail2 = this._ugAvail;
      if (ugAvail2 == null)
        return;
      ugAvail2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ugSearch")]
  private virtual UltraGrid ugSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
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

  internal virtual LinkLabel lnkDeselectAll
  {
    get => this._lnkDeselectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectAll_LinkClicked);
      LinkLabel lnkDeselectAll1 = this._lnkDeselectAll;
      if (lnkDeselectAll1 != null)
        lnkDeselectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectAll = value;
      LinkLabel lnkDeselectAll2 = this._lnkDeselectAll;
      if (lnkDeselectAll2 == null)
        return;
      lnkDeselectAll2.LinkClicked += clickedEventHandler;
    }
  }

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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsViewProducerLocationViewingRights ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProducerLocationViewingRights(Guid userGuid)
  {
    this.Load += new EventHandler(this.FormProducerLocationViewingRights_Load);
    this.InitializeComponent();
    this._userGuid = userGuid;
  }

  private void FormProducerLocationViewingRights_Load(object sender, EventArgs e)
  {
    this.SetUserProducerLocationData();
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(this._userGuid);
    ((Control) this.ugAvail).Text = $"[{user.LastName}, {user.FirstName}]  -  {((Control) this.ugAvail).Text}";
  }

  private void SetUserProducerLocationData()
  {
    try
    {
      this.ugAvail.CellChange -= new CellEventHandler(this.ugAvail_CellChange);
      this.ds.tblUserProducerLocationViewingRights.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblUserProducerLocationViewingRights"
      }, "GetUserProducerViewingData", new object[2]
      {
        (object) "@UserGuid",
        (object) this._userGuid
      });
    }
    finally
    {
      this.ugAvail.CellChange += new CellEventHandler(this.ugAvail_CellChange);
    }
  }

  private void ugAvail_CellChange(object sender, CellEventArgs e)
  {
    if (e.Cell == null || e.Cell.Row == null || e.Cell.Value == null || !e.Cell.Column.Key.Equals("Remove"))
      return;
    if (!(bool) e.Cell.Value)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      Guid ProducerLocationGUID = (Guid) e.Cell.Row.Cells["ProducerLocationGUID"].Value;
      string str = (string) e.Cell.Row.Cells["Name"].Value;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserProducerLocationViewingRights WHERE ProducerLocationGUID=@PLG AND UserGuid= @uGuid", new object[4]
      {
        (object) "@PLG",
        (object) ProducerLocationGUID,
        (object) "@uGuid",
        (object) this._userGuid
      });
      CurrentUser.Instance.LogAction("Users Menu - Removed vieiwng rights for producer location " + str, this._userGuid);
      this.ds.tblUserProducerLocationViewingRights.RemovetblUserProducerLocationViewingRightsRow(this.ds.tblUserProducerLocationViewingRights.FindByProducerLocationGUID(ProducerLocationGUID));
      ((UltraGridBase) this.ugAvail).UpdateData();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetBlockViewColumn(true);
  }

  private void lnkDeselectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetBlockViewColumn(false);
  }

  private void SetBlockViewColumn(bool SetValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugSearch).Rows)
      row.Cells["AddAccess"].Value = (object) SetValue;
  }

  private void btnGo_Click(object sender, EventArgs e)
  {
    bool flag = false;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugSearch).Rows)
    {
      if ((bool) row.Cells["AddAccess"].Value)
      {
        Guid guid = (Guid) row.Cells["ProducerLocationGUID"].Value;
        string str = (string) row.Cells["Name"].Value;
        DefaultDatabase.ExecuteNonQuery("SaveViewUserProducerLocationData", new object[4]
        {
          (object) "@ProducerLocationGUID",
          (object) guid,
          (object) "@UserGuid",
          (object) this._userGuid
        });
        CurrentUser.Instance.LogAction("Users Menu - Added vieiwng rights for producer location " + str, this._userGuid);
        flag = true;
      }
    }
    if (!flag)
      return;
    this.SetUserProducerLocationData();
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    this.ds.tblProducerLocations.Clear();
    if (this.txtSearch.Text.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("Please enter a search criterion", "No Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerLocations"
      }, "GetUserProducerLocationViewSearchData", new object[4]
      {
        (object) "@UserGuid",
        (object) this._userGuid,
        (object) "@searchText",
        (object) this.txtSearch.Text
      });
  }
}
