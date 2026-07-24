// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmLineView
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class frmLineView : Form
{
  private IContainer components;
  private Guid _LineGuid;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmLineView));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblUsersLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AllowClearance");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AllowUnderwriting");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AllowView");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Name_FirstLast");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.daUsersLines = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.spGetLineViewData = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ugLineView = new UltraGrid();
    this.Ds = new DsLineView();
    this.lnkCheckAllView = new LinkLabel();
    this.lnkAllClearance = new LinkLabel();
    this.lnkAllowAllUnderwriting = new LinkLabel();
    this.lnkUnCheckAllView = new LinkLabel();
    this.lnkUnCheckAllClearance = new LinkLabel();
    this.lnkUnCheckAllowAllUnderwriting = new LinkLabel();
    ((ISupportInitialize) this.ugLineView).BeginInit();
    this.Ds.BeginInit();
    this.SuspendLayout();
    this.daUsersLines.DeleteCommand = this.SqlDeleteCommand1;
    this.daUsersLines.InsertCommand = this.SqlInsertCommand1;
    this.daUsersLines.SelectCommand = this.spGetLineViewData;
    this.daUsersLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsersLines", new DataColumnMapping[5]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("AllowClearance", "AllowClearance"),
        new DataColumnMapping("AllowUnderwriting", "AllowUnderwriting"),
        new DataColumnMapping("AllowView", "AllowView")
      })
    });
    this.daUsersLines.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_UserGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@AllowClearance", SqlDbType.Bit, 1, "AllowClearance"),
      new SqlParameter("@AllowUnderwriting", SqlDbType.Bit, 1, "AllowUnderwriting"),
      new SqlParameter("@AllowView", SqlDbType.Bit, 1, "AllowView"),
      new SqlParameter("@RestrictBind", SqlDbType.Bit, 1, "RestrictBind"),
      new SqlParameter("@RestrictIssuance", SqlDbType.Bit, 1, "RestrictIssuance")
    });
    this.spGetLineViewData.CommandText = "spGetLineViewData";
    this.spGetLineViewData.CommandType = CommandType.StoredProcedure;
    this.spGetLineViewData.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGUID"),
      new SqlParameter("@AllowClearance", SqlDbType.Bit, 1, "AllowClearance"),
      new SqlParameter("@AllowUnderwriting", SqlDbType.Bit, 1, "AllowUnderwriting"),
      new SqlParameter("@AllowView", SqlDbType.Bit, 1, "AllowView"),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.ugLineView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugLineView).DataSource = (object) this.Ds;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ugLineView).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ugLineView).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ugLineView).DisplayLayout.AddNewBox).Prompt = " ";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLineView).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugLineView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 137;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 146;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Width = 17;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 142;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Name";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
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
    ((UltraGridBase) this.ugLineView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLineView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLineView).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLineView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((Control) this.ugLineView).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLineView).Location = new Point(0, 0);
    ((Control) this.ugLineView).Name = "ugLineView";
    ((Control) this.ugLineView).Size = new Size(409, 219);
    ((Control) this.ugLineView).TabIndex = 1;
    ((UltraControlBase) this.ugLineView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLineView).UseOsThemes = (DefaultableBoolean) 2;
    this.Ds.DataSetName = "Ds";
    this.Ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkCheckAllView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCheckAllView.AutoSize = true;
    this.lnkCheckAllView.Location = new Point(12, 237);
    this.lnkCheckAllView.Name = "lnkCheckAllView";
    this.lnkCheckAllView.Size = new Size(87, 13);
    this.lnkCheckAllView.TabIndex = 30;
    this.lnkCheckAllView.TabStop = true;
    this.lnkCheckAllView.Text = "Check all - 'View'";
    this.lnkAllClearance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAllClearance.AutoSize = true;
    this.lnkAllClearance.Location = new Point(12, 266);
    this.lnkAllClearance.Name = "lnkAllClearance";
    this.lnkAllClearance.Size = new Size(143, 13);
    this.lnkAllClearance.TabIndex = 29;
    this.lnkAllClearance.TabStop = true;
    this.lnkAllClearance.Text = "Check all  - 'Allow Clearance'";
    this.lnkAllowAllUnderwriting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAllowAllUnderwriting.AutoSize = true;
    this.lnkAllowAllUnderwriting.Location = new Point(12, 295);
    this.lnkAllowAllUnderwriting.Name = "lnkAllowAllUnderwriting";
    this.lnkAllowAllUnderwriting.Size = new Size(151, 13);
    this.lnkAllowAllUnderwriting.TabIndex = 28;
    this.lnkAllowAllUnderwriting.TabStop = true;
    this.lnkAllowAllUnderwriting.Text = "Check all - 'Allow Underwriting'";
    this.lnkUnCheckAllView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUnCheckAllView.AutoSize = true;
    this.lnkUnCheckAllView.Location = new Point(195, 237);
    this.lnkUnCheckAllView.Name = "lnkUnCheckAllView";
    this.lnkUnCheckAllView.Size = new Size(100, 13);
    this.lnkUnCheckAllView.TabIndex = 33;
    this.lnkUnCheckAllView.TabStop = true;
    this.lnkUnCheckAllView.Text = "Uncheck all - 'View'";
    this.lnkUnCheckAllClearance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUnCheckAllClearance.AutoSize = true;
    this.lnkUnCheckAllClearance.Location = new Point(195, 266);
    this.lnkUnCheckAllClearance.Name = "lnkUnCheckAllClearance";
    this.lnkUnCheckAllClearance.Size = new Size(156, 13);
    this.lnkUnCheckAllClearance.TabIndex = 32 /*0x20*/;
    this.lnkUnCheckAllClearance.TabStop = true;
    this.lnkUnCheckAllClearance.Text = "Uncheck all  - 'Allow Clearance'";
    this.lnkUnCheckAllowAllUnderwriting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUnCheckAllowAllUnderwriting.AutoSize = true;
    this.lnkUnCheckAllowAllUnderwriting.Location = new Point(195, 295);
    this.lnkUnCheckAllowAllUnderwriting.Name = "lnkUnCheckAllowAllUnderwriting";
    this.lnkUnCheckAllowAllUnderwriting.Size = new Size(164, 13);
    this.lnkUnCheckAllowAllUnderwriting.TabIndex = 31 /*0x1F*/;
    this.lnkUnCheckAllowAllUnderwriting.TabStop = true;
    this.lnkUnCheckAllowAllUnderwriting.Text = "Uncheck all - 'Allow Underwriting'";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(410, 317);
    this.Controls.Add((Control) this.lnkUnCheckAllView);
    this.Controls.Add((Control) this.lnkUnCheckAllClearance);
    this.Controls.Add((Control) this.lnkUnCheckAllowAllUnderwriting);
    this.Controls.Add((Control) this.lnkCheckAllView);
    this.Controls.Add((Control) this.lnkAllClearance);
    this.Controls.Add((Control) this.lnkAllowAllUnderwriting);
    this.Controls.Add((Control) this.ugLineView);
    this.Name = nameof (frmLineView);
    this.Text = "Line View";
    ((ISupportInitialize) this.ugLineView).EndInit();
    this.Ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual UltraGrid ugLineView
  {
    get => this._ugLineView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugLineView_AfterRowUpdate);
      UltraGrid ugLineView1 = this._ugLineView;
      if (ugLineView1 != null)
        ugLineView1.AfterRowUpdate -= rowEventHandler;
      this._ugLineView = value;
      UltraGrid ugLineView2 = this._ugLineView;
      if (ugLineView2 == null)
        return;
      ugLineView2.AfterRowUpdate += rowEventHandler;
    }
  }

  [field: AccessedThroughProperty("Ds")]
  internal virtual DsLineView Ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daUsersLines")]
  private virtual SqlDataAdapter daUsersLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  private virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  private virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spGetLineViewData")]
  private virtual SqlCommand spGetLineViewData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  private virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkCheckAllView
  {
    get => this._lnkCheckAllView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCheckAllView_LinkClicked);
      LinkLabel lnkCheckAllView1 = this._lnkCheckAllView;
      if (lnkCheckAllView1 != null)
        lnkCheckAllView1.LinkClicked -= clickedEventHandler;
      this._lnkCheckAllView = value;
      LinkLabel lnkCheckAllView2 = this._lnkCheckAllView;
      if (lnkCheckAllView2 == null)
        return;
      lnkCheckAllView2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkAllClearance
  {
    get => this._lnkAllClearance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAllClearance_LinkClicked);
      LinkLabel lnkAllClearance1 = this._lnkAllClearance;
      if (lnkAllClearance1 != null)
        lnkAllClearance1.LinkClicked -= clickedEventHandler;
      this._lnkAllClearance = value;
      LinkLabel lnkAllClearance2 = this._lnkAllClearance;
      if (lnkAllClearance2 == null)
        return;
      lnkAllClearance2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkAllowAllUnderwriting
  {
    get => this._lnkAllowAllUnderwriting;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAllowAllUnderwriting_LinkClicked);
      LinkLabel allowAllUnderwriting1 = this._lnkAllowAllUnderwriting;
      if (allowAllUnderwriting1 != null)
        allowAllUnderwriting1.LinkClicked -= clickedEventHandler;
      this._lnkAllowAllUnderwriting = value;
      LinkLabel allowAllUnderwriting2 = this._lnkAllowAllUnderwriting;
      if (allowAllUnderwriting2 == null)
        return;
      allowAllUnderwriting2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkUnCheckAllView
  {
    get => this._lnkUnCheckAllView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUnCheckAllView_LinkClicked);
      LinkLabel lnkUnCheckAllView1 = this._lnkUnCheckAllView;
      if (lnkUnCheckAllView1 != null)
        lnkUnCheckAllView1.LinkClicked -= clickedEventHandler;
      this._lnkUnCheckAllView = value;
      LinkLabel lnkUnCheckAllView2 = this._lnkUnCheckAllView;
      if (lnkUnCheckAllView2 == null)
        return;
      lnkUnCheckAllView2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkUnCheckAllClearance
  {
    get => this._lnkUnCheckAllClearance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUnCheckAllClearance_LinkClicked);
      LinkLabel checkAllClearance1 = this._lnkUnCheckAllClearance;
      if (checkAllClearance1 != null)
        checkAllClearance1.LinkClicked -= clickedEventHandler;
      this._lnkUnCheckAllClearance = value;
      LinkLabel checkAllClearance2 = this._lnkUnCheckAllClearance;
      if (checkAllClearance2 == null)
        return;
      checkAllClearance2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkUnCheckAllowAllUnderwriting
  {
    get => this._lnkUnCheckAllowAllUnderwriting;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUnCheckAllowAllUnderwriting_LinkClicked);
      LinkLabel allowAllUnderwriting1 = this._lnkUnCheckAllowAllUnderwriting;
      if (allowAllUnderwriting1 != null)
        allowAllUnderwriting1.LinkClicked -= clickedEventHandler;
      this._lnkUnCheckAllowAllUnderwriting = value;
      LinkLabel allowAllUnderwriting2 = this._lnkUnCheckAllowAllUnderwriting;
      if (allowAllUnderwriting2 == null)
        return;
      allowAllUnderwriting2.LinkClicked += clickedEventHandler;
    }
  }

  public frmLineView(Guid LineGuid, string LineName)
  {
    this.FormClosing += new FormClosingEventHandler(this.frmLineView_FormClosing);
    this.Load += new EventHandler(this.frmLineView_Load);
    this.InitializeComponent();
    this._LineGuid = LineGuid;
    this.Text = "View - Line : " + LineName;
  }

  private void frmLineView_FormClosing(object sender, FormClosingEventArgs e)
  {
    ((UltraControlBase) this.ugLineView).Update();
    this.Savedata(((UltraGridBase) this.ugLineView).ActiveRow);
  }

  private void frmLineView_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daUsersLines, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.PullLineInfo();
  }

  private void lnkAllClearance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check all 'Allow Clearance'?", "Check All Allow Clearance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowClearance", true);
  }

  private void lnkAllowAllUnderwriting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check 'Allow Underwriting' for all Users?", "Check Allow Underwriting For All Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowUnderwriting", true);
  }

  private void lnkCheckAllView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check 'View' for all Users?", "Check 'View' For All Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowView", true);
  }

  private void lnkUnCheckAllClearance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to uncheck all 'Allow Clearance'?", "Uncheck All Allow Clearance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowClearance", false);
  }

  private void lnkUnCheckAllowAllUnderwriting_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to uncheck 'Allow Underwriting' for all Users?", "Uncheck Allow Underwriting For All Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowUnderwriting", false);
  }

  private void lnkUnCheckAllView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to uncheck 'View' for all Users?", "Uncheck 'View' For All Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowView", false);
  }

  private void MarkColumnChecked(string columnName, bool booleanValue)
  {
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      RowEnumerator enumerator = ((UltraGridBase) this.ugLineView).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        current.Cells[columnName].Value = (object) booleanValue;
        this.Savedata(current);
      }
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void PullLineInfo()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.Ds.tblUsersLines, "dbo.spGetLineViewData", new object[2]
    {
      (object) "@LineGuid",
      (object) this._LineGuid
    });
  }

  private void Savedata(UltraGridRow row)
  {
    object obj = row.Cells["UserGUID"].Value;
    DefaultDatabase.ExecuteNonQuery("dbo.spSaveLineViewData", new object[10]
    {
      (object) "@LineGuid",
      (object) this._LineGuid,
      (object) "@UserGUID",
      (object) (obj != null ? (Guid) obj : new Guid()),
      (object) "@AllowClearance",
      (object) Conversions.ToBoolean(row.Cells["AllowClearance"].Value),
      (object) "@AllowUnderwriting",
      (object) Conversions.ToBoolean(row.Cells["AllowUnderwriting"].Value),
      (object) "@AllowView",
      (object) Conversions.ToBoolean(row.Cells["AllowView"].Value)
    });
  }

  private void ugLineView_AfterRowUpdate(object sender, RowEventArgs e)
  {
    this.Savedata(((UltraGridBase) this.ugLineView).ActiveRow);
  }
}
