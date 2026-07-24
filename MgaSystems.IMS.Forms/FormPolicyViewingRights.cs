// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormPolicyViewingRights
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
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
public class FormPolicyViewingRights : Form
{
  private IContainer components;
  protected readonly Guid _userGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUserPolicyViewingRights", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Remove");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PolicyNumber", -1, (object) null, 0, (SortIndicator) 2, false);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblPolicies", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AddAccess");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PolicyNumber");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    this.ugAvail = new UltraGrid();
    this.ds = new dsPolicyViewingRights();
    this.ugSearch = new UltraGrid();
    this.btnGo = new MGAButton();
    this.lnkDeselectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnSearch = new MGAButton();
    this.txtSearch = new TextBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugSearch).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataMember = "tblUserPolicyViewingRights";
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 70;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 226;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 57;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 112 /*0x70*/;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugAvail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugAvail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugAvail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAvail).Location = new Point(501, 3);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(467, 588);
    ((Control) this.ugAvail).TabIndex = 11;
    ((Control) this.ugAvail).Text = "Accessible Insured Policy Control #s";
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPolicyViewingRights";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraControlBase) this.ugSearch).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugSearch).DataMember = "tblPolicies";
    ((UltraGridBase) this.ugSearch).DataSource = (object) this.ds;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Width = 78;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 222;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Add Access";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn7.Width = 62;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 125;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ugSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugSearch).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugSearch).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugSearch).Location = new Point(6, 58);
    ((Control) this.ugSearch).Name = "ugSearch";
    ((Control) this.ugSearch).Size = new Size(489, 469);
    ((Control) this.ugSearch).TabIndex = 12;
    ((Control) this.ugSearch).Text = "Policy Insured / Control # Search Results";
    ((UltraControlBase) this.ugSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance17.BackColor = Color.FromArgb(248, 248, 248);
    appearance17.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.DarkGray;
    appearance17.ImageHAlign = (HAlign) 2;
    appearance17.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance17;
    ((UltraButtonBase) this.btnGo).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(392, 541);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 15;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.Location = new Point(98, 568);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(68, 13);
    this.lnkDeselectAll.TabIndex = 14;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(21, 568);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 13;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    appearance18.BackColor = Color.Gainsboro;
    appearance18.BackColor2 = Color.White;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = Color.Gray;
    appearance18.ImageHAlign = (HAlign) 2;
    appearance18.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance18;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(392, 12);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 17;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.txtSearch.Location = new Point(81, 21);
    this.txtSearch.Name = "txtSearch";
    this.txtSearch.Size = new Size(296, 20);
    this.txtSearch.TabIndex = 16 /*0x10*/;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(3, 25);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(69, 13);
    this.Label1.TabIndex = 18;
    this.Label1.Text = "Insured Text:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(980, 590);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.lnkDeselectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.ugSearch);
    this.Controls.Add((Control) this.ugAvail);
    this.Name = nameof (FormPolicyViewingRights);
    this.Text = "Policy Viewing Rights";
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugSearch).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugAvail
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
  protected virtual UltraGrid ugSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsPolicyViewingRights ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormPolicyViewingRights()
  {
    this.Load += new EventHandler(this.FormPolicyViewingRights_Load);
    this.InitializeComponent();
  }

  public FormPolicyViewingRights(Guid userGuid)
  {
    this.Load += new EventHandler(this.FormPolicyViewingRights_Load);
    this.InitializeComponent();
    this._userGuid = userGuid;
  }

  private void FormPolicyViewingRights_Load(object sender, EventArgs e)
  {
    this.SetUserInsuredData();
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(this._userGuid);
    ((Control) this.ugAvail).Text = $"[{user.LastName}, {user.FirstName}]  -  {((Control) this.ugAvail).Text}";
  }

  protected virtual void SetUserInsuredData()
  {
    try
    {
      this.ugAvail.CellChange -= new CellEventHandler(this.ugAvail_CellChange);
      this.ds.tblUserPolicyViewingRights.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblUserPolicyViewingRights"
      }, CommandType.Text, "SELECT DISTINCT IR.ControlNo , Q.InsuredPolicyName AS Name, 1 AS Remove, Q.PolicyNumber FROM tblUserPolicyViewingRights AS IR WITH (NOLOCK) INNER JOIN tblQuotes AS Q WITH (NOLOCK) ON IR.ControlNo  = Q.ControlNo  INNER JOIN dbo.tblMaxQuoteIDs MQ WITH (NOLOCK) ON Q.QuoteID  = MQ.MaxQuoteID WHERE IR.UserGuid = @UG ORDER BY IR.ControlNo, Q.InsuredPolicyName", new object[2]
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
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      bool flag = false;
      RowEnumerator enumerator = ((UltraGridBase) this.ugSearch).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if ((bool) current.Cells["AddAccess"].Value)
        {
          int num = (int) current.Cells["ControlNo"].Value;
          DefaultDatabase.ExecuteNonQuery(MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("SavePolicyViewingRightsProc", "SavePolicyViewingRightsData"), new object[4]
          {
            (object) "@ControlNo",
            (object) num,
            (object) "@UserGuid",
            (object) this._userGuid
          });
          CurrentUser.Instance.LogAction("Users Menu - Added viewing rights for control # " + Conversions.ToString(num), this._userGuid);
          flag = true;
        }
      }
      if (!flag)
        return;
      this.SetUserInsuredData();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    this.ds.tblPolicies.Clear();
    if (this.txtSearch.Text.Replace(" ", string.Empty).Length == 0)
    {
      int num = (int) MessageBox.Show("Please enter a search criterion", "No Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "tblPolicies"
        }, MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("GetUserPolicyViewingRightsProc", "GetUserPolicyViewingRightsData"), new object[4]
        {
          (object) "@UserGuid",
          (object) this._userGuid,
          (object) "@searchText",
          (object) this.txtSearch.Text
        });
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  protected virtual void ugAvail_CellChange(object sender, CellEventArgs e)
  {
    if (e.Cell == null || e.Cell.Row == null || e.Cell.Value == null || !e.Cell.Column.Key.Equals("Remove"))
      return;
    if (!(bool) e.Cell.Value)
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      int ControlNo = (int) e.Cell.Row.Cells["ControlNo"].Value;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserPolicyViewingRights WHERE ControlNo=@CN AND UserGuid= @uGuid", new object[4]
      {
        (object) "@CN",
        (object) ControlNo,
        (object) "@uGuid",
        (object) this._userGuid
      });
      CurrentUser.Instance.LogAction("Users Menu - Removed viewing rights for control # " + Conversions.ToString(ControlNo), this._userGuid);
      this.ds.tblUserPolicyViewingRights.RemovetblUserPolicyViewingRightsRow(this.ds.tblUserPolicyViewingRights.FindByControlNo(ControlNo));
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
