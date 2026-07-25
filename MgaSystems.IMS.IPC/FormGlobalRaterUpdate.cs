// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormGlobalRaterUpdate
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
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
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormGlobalRaterUpdate : Form
{
  private IContainer components;
  private int _CompanyLineID;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UpdateRater");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLineGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLine");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtRaters", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RatingTypeID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("RatingType");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SelectRater");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    this.ugCompanyLines = new UltraGrid();
    this.ds = new dsGlobalRaterUpdate();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.lblCompanyLine = new Label();
    this.ugRaters = new UltraGrid();
    this.txtCompanyLine = new TextBox();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.ugCompanyLines).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugRaters).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugCompanyLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugCompanyLines).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugCompanyLines).DataMember = "tblCompanyLines";
    ((UltraGridBase) this.ugCompanyLines).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Select";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 44;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.MaxRowScrollRegions = 40;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.ugCompanyLines).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugCompanyLines).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugCompanyLines).Location = new Point(12, 41);
    ((Control) this.ugCompanyLines).Name = "ugCompanyLines";
    ((Control) this.ugCompanyLines).Size = new Size(607, 554);
    ((Control) this.ugCompanyLines).TabIndex = 14;
    ((Control) this.ugCompanyLines).Text = "Available Company / Line";
    ((UltraControlBase) this.ugCompanyLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCompanyLines).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsGlobalRaterUpdate";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 608);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(129, 13);
    this.lnkSelectAll.TabIndex = 15;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Company / Line";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(12, 640);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(146, 13);
    this.lnkDeSelectAll.TabIndex = 16 /*0x10*/;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All Company / Line";
    this.lblCompanyLine.AutoSize = true;
    this.lblCompanyLine.Location = new Point(12, 14);
    this.lblCompanyLine.Name = "lblCompanyLine";
    this.lblCompanyLine.Size = new Size(85, 13);
    this.lblCompanyLine.TabIndex = 17;
    this.lblCompanyLine.Text = "Company / Line:";
    ((Control) this.ugRaters).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraControlBase) this.ugRaters).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugRaters).DataMember = "dtRaters";
    ((UltraGridBase) this.ugRaters).DataSource = (object) this.ds;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRaters).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugRaters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Rating Type";
    ultraGridColumn5.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Select";
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ugRaters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugRaters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRaters).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugRaters).DisplayLayout.MaxRowScrollRegions = 40;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugRaters).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugRaters).DisplayLayout.Scrollbars = (Scrollbars) 1;
    ((UltraGridBase) this.ugRaters).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugRaters).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugRaters).Location = new Point(625, 41);
    ((Control) this.ugRaters).Name = "ugRaters";
    ((Control) this.ugRaters).Size = new Size(223, 554);
    ((Control) this.ugRaters).TabIndex = 18;
    ((Control) this.ugRaters).Text = "Available Raters";
    ((UltraControlBase) this.ugRaters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRaters).UseOsThemes = (DefaultableBoolean) 2;
    this.txtCompanyLine.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCompanyLine.Location = new Point(112 /*0x70*/, 10);
    this.txtCompanyLine.Name = "txtCompanyLine";
    this.txtCompanyLine.Size = new Size(626, 20);
    this.txtCompanyLine.TabIndex = 19;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance17.BackColor = Color.Gainsboro;
    appearance17.BackColor2 = Color.White;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.Gray;
    appearance17.ImageHAlign = (HAlign) 2;
    appearance17.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance17;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(391, 614);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(48 /*0x30*/, 40);
    ((Control) this.btnSave).TabIndex = 72;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(860, 662);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtCompanyLine);
    this.Controls.Add((Control) this.ugRaters);
    this.Controls.Add((Control) this.lblCompanyLine);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.ugCompanyLines);
    this.Name = nameof (FormGlobalRaterUpdate);
    this.Text = "Global Rater Update";
    ((ISupportInitialize) this.ugCompanyLines).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugRaters).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugCompanyLines")]
  private virtual UltraGrid ugCompanyLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsGlobalRaterUpdate ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCompanyLine")]
  internal virtual Label lblCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugRaters")]
  private virtual UltraGrid ugRaters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompanyLine")]
  internal virtual TextBox txtCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
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

  public FormGlobalRaterUpdate()
  {
    this.Load += new EventHandler(this.FormGlobalRaterUpdate_Load);
    this.InitializeComponent();
  }

  public FormGlobalRaterUpdate(int CompanyLineID)
  {
    this.Load += new EventHandler(this.FormGlobalRaterUpdate_Load);
    this.InitializeComponent();
    this._CompanyLineID = CompanyLineID;
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetUpdateRaterOnGrid(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetUpdateRaterOnGrid(false);
  }

  private void SetUpdateRaterOnGrid(bool updateRaterValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugCompanyLines).Rows)
      row.Cells["UpdateRater"].Value = (object) updateRaterValue;
  }

  private void FormGlobalRaterUpdate_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    CompanyLine companyLine = new CompanyLine(this._CompanyLineID);
    this.txtCompanyLine.Text = companyLine.CompanyLineState;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblCompanyLines"
    }, CommandType.Text, "SELECT CompanyLineGUID, CompanyLine FROM tblCompanyLines WITH (NOLOCK) WHERE LineGUID = @LG AND CompanyLocationGUID = @CLG AND StateID <> @StateID ORDER BY CompanyLine", new object[6]
    {
      (object) "@LG",
      (object) companyLine.LineGuid,
      (object) "@CLG",
      (object) companyLine.CompanyLocationGuid,
      (object) "@StateID",
      (object) companyLine.StateID
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtRaters"
    }, CommandType.Text, "SELECT DISTINCT C.RatingTypeID, R.RatingType FROM tblCompanyRaters C WITH (NOLOCK) INNER JOIN lstRatingTypes AS R ON C.RatingTypeID = R.RatingTypeID WHERE C.CompanyLineGuid = @CLG ORDER BY R.RatingType", new object[2]
    {
      (object) "@CLG",
      (object) companyLine.CompanyLineGuid
    });
    if (this.ds.dtRaters.Count == 1)
    {
      ((UltraGridBase) this.ugRaters).Rows[0].Cells["SelectRater"].Value = (object) true;
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.ugRaters).Rows)
        row.Cells["SelectRater"].Value = (object) false;
    }
    this.SetUpdateRaterOnGrid(true);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    string str = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugCompanyLines).Rows)
    {
      if (row.Cells["UpdateRater"].Value != DBNull.Value && (bool) row.Cells["UpdateRater"].Value)
        str = $"{str}{row.Cells["CompanyLineGUID"].Value.ToString()},";
    }
    if (str.Equals(string.Empty))
    {
      int num1 = (int) MessageBox.Show("No company / line has been selected.", "No Company / Line Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      List<int> intList = new List<int>();
      foreach (UltraGridRow row in ((UltraGridBase) this.ugRaters).Rows)
      {
        if (row.Cells["SelectRater"].Value != DBNull.Value && (bool) row.Cells["SelectRater"].Value)
          intList.Add(Conversions.ToInteger(row.Cells["RatingTypeID"].Value));
      }
      if (intList.Count == 0)
      {
        int num2 = (int) MessageBox.Show("No rater has been selected.", "No Rater Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
          foreach (int RatingTypeID in intList)
          {
            int integer = Conversions.ToInteger(DefaultDatabase.ExecuteScalar("UpateCompanyLineRater", new object[4]
            {
              (object) "@CompanyLineStr",
              (object) str,
              (object) "@RatingTypeID",
              (object) RatingTypeID
            }));
            stringBuilder.AppendLine($"{integer.ToString()} company / line updated by the {this.ds.dtRaters.FindByRatingTypeID(RatingTypeID).RatingType} rater.");
          }
        }
        finally
        {
          List<int>.Enumerator enumerator;
          enumerator.Dispose();
        }
        int num3 = (int) MessageBox.Show(stringBuilder.ToString(), "Company / Line Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }
}
