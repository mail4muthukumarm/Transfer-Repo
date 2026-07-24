// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormInsuredViewingRights
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
public class FormInsuredViewingRights : Form
{
  private IContainer components;
  private bool _painted;
  private Guid _userGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUserInsuredViewingRights", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InsuredGuid");
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
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblInsureds", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InsuredGUID");
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
    this.txtSearch = new TextBox();
    this.btnSearch = new MGAButton();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeselectAll = new LinkLabel();
    this.btnGo = new MGAButton();
    this.ugAvail = new UltraGrid();
    this.ds = new dsViewInsuredViewingRights();
    this.ugSearch = new UltraGrid();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugSearch).BeginInit();
    this.SuspendLayout();
    this.txtSearch.Location = new Point(12, 17);
    this.txtSearch.Name = "txtSearch";
    this.txtSearch.Size = new Size(296, 20);
    this.txtSearch.TabIndex = 3;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(328, 12);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 6;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 533);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 7;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.Location = new Point(89, 533);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(68, 13);
    this.lnkDeselectAll.TabIndex = 8;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "De-Select All";
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
    ((Control) this.btnGo).Location = new Point(328, 511 /*0x01FF*/);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 9;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataMember = "tblUserInsuredViewingRights";
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 123;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 242;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 61;
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
    ((Control) this.ugAvail).Location = new Point(432, 6);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(305, 545);
    ((Control) this.ugAvail).TabIndex = 10;
    ((Control) this.ugAvail).Text = "Accessible Insureds";
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsViewInsuredViewingRights";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraControlBase) this.ugSearch).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugSearch).DataMember = "tblInsureds";
    ((UltraGridBase) this.ugSearch).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 251;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 341;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Add Access";
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 71;
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
    ((Control) this.ugSearch).Location = new Point(12, 58);
    ((Control) this.ugSearch).Name = "ugSearch";
    ((Control) this.ugSearch).Size = new Size(414, 447);
    ((Control) this.ugSearch).TabIndex = 2;
    ((Control) this.ugSearch).Text = "Insured Search Results";
    ((UltraControlBase) this.ugSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(739, 554);
    this.Controls.Add((Control) this.ugAvail);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.lnkDeselectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.ugSearch);
    this.Name = nameof (FormInsuredViewingRights);
    this.Text = "Insured Viewing Rights";
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugSearch).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugSearch")]
  private virtual UltraGrid ugSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtSearch
  {
    get => this._txtSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      TextBox txtSearch1 = this._txtSearch;
      if (txtSearch1 != null)
        txtSearch1.KeyDown -= keyEventHandler;
      this._txtSearch = value;
      TextBox txtSearch2 = this._txtSearch;
      if (txtSearch2 == null)
        return;
      txtSearch2.KeyDown += keyEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsViewInsuredViewingRights ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public FormInsuredViewingRights(Guid userGuid)
  {
    this.Load += new EventHandler(this.FormInsuredViewingRights_Load);
    this.InitializeComponent();
    this._userGuid = userGuid;
  }

  private void FormInsuredViewingRights_Load(object sender, EventArgs e)
  {
    this.SetUserInsuredData();
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(this._userGuid);
    ((Control) this.ugAvail).Text = $"[{user.LastName}, {user.FirstName}]  -  {((Control) this.ugAvail).Text}";
  }

  private void SetUserInsuredData()
  {
    try
    {
      this.ugAvail.CellChange -= new CellEventHandler(this.ugAvail_CellChange);
      this.ds.tblUserInsuredViewingRights.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblUserInsuredViewingRights"
      }, CommandType.Text, "SELECT IR.InsuredGuid, I.Name, 1 AS Remove FROM tblUserInsuredViewingRights AS IR INNER JOIN tblInsureds AS I WITH (NOLOCK) ON IR.InsuredGuid = I.InsuredGUID WHERE IR.UserGuid = @UG ORDER BY I.Name", new object[2]
      {
        (object) "@UG",
        (object) this._userGuid
      });
    }
    finally
    {
      this.ugAvail.CellChange += new CellEventHandler(this.ugAvail_CellChange);
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
        Guid guid = (Guid) row.Cells["InsuredGuid"].Value;
        string str = (string) row.Cells["Name"].Value;
        DefaultDatabase.ExecuteNonQuery("SaveViewUserInsuredData", new object[4]
        {
          (object) "@InsuredGuid",
          (object) guid,
          (object) "@UserGuid",
          (object) this._userGuid
        });
        CurrentUser.Instance.LogAction("Users Menu - Added insured viewing rights for " + str, this._userGuid);
        flag = true;
      }
    }
    if (!flag)
      return;
    this.SetUserInsuredData();
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    this.ds.tblInsureds.Clear();
    if (this.txtSearch.Text.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("Please enter a search criterion", "No Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblInsureds"
      }, "GetUserInsuredViewSearchData", new object[4]
      {
        (object) "@UserGuid",
        (object) this._userGuid,
        (object) "@searchText",
        (object) this.txtSearch.Text
      });
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
      Guid InsuredGuid = (Guid) e.Cell.Row.Cells["InsuredGuid"].Value;
      string str = (string) e.Cell.Row.Cells["Name"].Value;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserInsuredViewingRights WHERE InsuredGuid=@IG AND UserGuid= @uGuid", new object[4]
      {
        (object) "@IG",
        (object) InsuredGuid,
        (object) "@uGuid",
        (object) this._userGuid
      });
      CurrentUser.Instance.LogAction("Users Menu - Removed insured viewing rights for " + str, this._userGuid);
      this.ds.tblUserInsuredViewingRights.RemovetblUserInsuredViewingRightsRow(this.ds.tblUserInsuredViewingRights.FindByInsuredGuid(InsuredGuid));
      ((UltraGridBase) this.ugAvail).UpdateData();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSearch_Click((object) null, (EventArgs) null);
  }
}
