// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmUserLines
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
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Users;

public sealed class frmUserLines : Form
{
  private IContainer components;
  private UltraLabel lblName;
  private SqlDataAdapter daLines;
  private SqlConnection cnSQL;
  private SqlDataAdapter daUsersLines;
  private SqlCommand SqlSelectCommand1;
  private dsUserLines DsUserLines;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private Guid _userGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ugUserLines
  {
    get => this._ugUserLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler1 = new RowEventHandler(this.ugUserLines_AfterRowInsert);
      RowEventHandler rowEventHandler2 = new RowEventHandler(this.ugUserLines_AfterRowUpdate);
      UltraGrid ugUserLines1 = this._ugUserLines;
      if (ugUserLines1 != null)
      {
        ugUserLines1.AfterRowInsert -= rowEventHandler1;
        ugUserLines1.AfterRowUpdate -= rowEventHandler2;
      }
      this._ugUserLines = value;
      UltraGrid ugUserLines2 = this._ugUserLines;
      if (ugUserLines2 == null)
        return;
      ugUserLines2.AfterRowInsert += rowEventHandler1;
      ugUserLines2.AfterRowUpdate += rowEventHandler2;
    }
  }

  private virtual UltraDropDown ddLines
  {
    get => this._ddLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddLines_BeforeDropDown);
      UltraDropDown ddLines1 = this._ddLines;
      if (ddLines1 != null)
        ddLines1.BeforeDropDown -= cancelEventHandler;
      this._ddLines = value;
      UltraDropDown ddLines2 = this._ddLines;
      if (ddLines2 == null)
        return;
      ddLines2.BeforeDropDown += cancelEventHandler;
    }
  }

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

  protected virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkAddUserToAllLine
  {
    get => this._lnkAddUserToAllLine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddUserToAllLine_LinkClicked);
      LinkLabel addUserToAllLine1 = this._lnkAddUserToAllLine;
      if (addUserToAllLine1 != null)
        addUserToAllLine1.LinkClicked -= clickedEventHandler;
      this._lnkAddUserToAllLine = value;
      LinkLabel addUserToAllLine2 = this._lnkAddUserToAllLine;
      if (addUserToAllLine2 == null)
        return;
      addUserToAllLine2.LinkClicked += clickedEventHandler;
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

  internal virtual LinkLabel lnkUncheckAllBind
  {
    get => this._lnkUncheckAllBind;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUncheckAllBind_LinkClicked);
      LinkLabel lnkUncheckAllBind1 = this._lnkUncheckAllBind;
      if (lnkUncheckAllBind1 != null)
        lnkUncheckAllBind1.LinkClicked -= clickedEventHandler;
      this._lnkUncheckAllBind = value;
      LinkLabel lnkUncheckAllBind2 = this._lnkUncheckAllBind;
      if (lnkUncheckAllBind2 == null)
        return;
      lnkUncheckAllBind2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkCheckAllBind
  {
    get => this._lnkCheckAllBind;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCheckAllBind_LinkClicked);
      LinkLabel lnkCheckAllBind1 = this._lnkCheckAllBind;
      if (lnkCheckAllBind1 != null)
        lnkCheckAllBind1.LinkClicked -= clickedEventHandler;
      this._lnkCheckAllBind = value;
      LinkLabel lnkCheckAllBind2 = this._lnkCheckAllBind;
      if (lnkCheckAllBind2 == null)
        return;
      lnkCheckAllBind2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkUncheckAllIssuance
  {
    get => this._lnkUncheckAllIssuance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkUncheckAllIssuance_LinkClicked);
      LinkLabel uncheckAllIssuance1 = this._lnkUncheckAllIssuance;
      if (uncheckAllIssuance1 != null)
        uncheckAllIssuance1.LinkClicked -= clickedEventHandler;
      this._lnkUncheckAllIssuance = value;
      LinkLabel uncheckAllIssuance2 = this._lnkUncheckAllIssuance;
      if (uncheckAllIssuance2 == null)
        return;
      uncheckAllIssuance2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkCheckAllIssuance
  {
    get => this._lnkCheckAllIssuance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkCheckAllIssuance_LinkClicked);
      LinkLabel checkAllIssuance1 = this._lnkCheckAllIssuance;
      if (checkAllIssuance1 != null)
        checkAllIssuance1.LinkClicked -= clickedEventHandler;
      this._lnkCheckAllIssuance = value;
      LinkLabel checkAllIssuance2 = this._lnkCheckAllIssuance;
      if (checkAllIssuance2 == null)
        return;
      checkAllIssuance2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUserLines));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUsersLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineGUID", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AllowClearance");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AllowUnderwriting");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AllowView");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RestrictBind");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("RestrictIssuance");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Inactive");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("lstLinestblUsersLines");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstLinestblUsersLines", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("AllowClearance");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AllowUnderwriting");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AllowView");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("RestrictBind");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("RestrictIssuance");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this.DsUserLines = new dsUserLines();
    this.lblName = new UltraLabel();
    this.daLines = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.daUsersLines = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ugUserLines = new UltraGrid();
    this.ddLines = new UltraDropDown();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.lnkAddUserToAllLine = new LinkLabel();
    this.lnkAllowAllUnderwriting = new LinkLabel();
    this.lnkAllClearance = new LinkLabel();
    this.lnkCheckAllView = new LinkLabel();
    this.lnkUnCheckAllView = new LinkLabel();
    this.lnkUnCheckAllClearance = new LinkLabel();
    this.lnkUnCheckAllowAllUnderwriting = new LinkLabel();
    this.lnkUncheckAllBind = new LinkLabel();
    this.lnkCheckAllBind = new LinkLabel();
    this.lnkUncheckAllIssuance = new LinkLabel();
    this.lnkCheckAllIssuance = new LinkLabel();
    this.DsUserLines.BeginInit();
    ((ISupportInitialize) this.ugUserLines).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.DsUserLines.DataSetName = "dsUserLines";
    this.DsUserLines.Locale = new CultureInfo("en-US");
    this.DsUserLines.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.lblName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance1).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblName).Appearance = (AppearanceBase) appearance1;
    this.lblName.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblName).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblName).Location = new Point(7, 7);
    ((Control) this.lblName).Name = "lblName";
    ((Control) this.lblName).Size = new Size(684, 21);
    ((Control) this.lblName).TabIndex = 1;
    ((ControlBase) this.lblName).Text = "(user name here)";
    this.daLines.SelectCommand = this.SqlSelectCommand1;
    this.daLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("LineName", "LineName")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT     LineGUID, LineName\r\nFROM         dbo.lstLines\r\nORDER BY LineName";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.cnSQL.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daUsersLines.DeleteCommand = this.SqlDeleteCommand1;
    this.daUsersLines.InsertCommand = this.SqlInsertCommand1;
    this.daUsersLines.SelectCommand = this.SqlSelectCommand2;
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
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblUsersLines] WHERE (([UserGUID] = @Original_UserGUID) AND ([LineGUID] = @Original_LineGUID))";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_UserGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 0, "UserGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 0, "LineGUID"),
      new SqlParameter("@AllowClearance", SqlDbType.Bit, 0, "AllowClearance"),
      new SqlParameter("@AllowUnderwriting", SqlDbType.Bit, 0, "AllowUnderwriting"),
      new SqlParameter("@AllowView", SqlDbType.Bit, 0, "AllowView"),
      new SqlParameter("@RestrictBind", SqlDbType.Bit, 0, "RestrictBind"),
      new SqlParameter("@RestrictIssuance", SqlDbType.Bit, 0, "RestrictIssuance")
    });
    this.SqlSelectCommand2.CommandText = componentResourceManager.GetString("SqlSelectCommand2.CommandText");
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 0, "UserGUID"),
      new SqlParameter("@LineGUID", SqlDbType.UniqueIdentifier, 0, "LineGUID"),
      new SqlParameter("@AllowClearance", SqlDbType.Bit, 0, "AllowClearance"),
      new SqlParameter("@AllowUnderwriting", SqlDbType.Bit, 0, "AllowUnderwriting"),
      new SqlParameter("@AllowView", SqlDbType.Bit, 0, "AllowView"),
      new SqlParameter("@RestrictBind", SqlDbType.Bit, 0, "RestrictBind"),
      new SqlParameter("@Original_UserGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_LineGUID", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGUID", DataRowVersion.Original, (object) null),
      new SqlParameter("@RestrictIssuance", SqlDbType.Bit, 0, "RestrictIssuance")
    });
    ((Control) this.ugUserLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugUserLines).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugUserLines).DataMember = "tblUsersLines";
    ((UltraGridBase) this.ugUserLines).DataSource = (object) this.DsUserLines;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((SpecialBoxBase) ((UltraGridBase) this.ugUserLines).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BorderColor = Color.WhiteSmoke;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ugUserLines).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugUserLines).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugUserLines).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Click here to add a new line of business ...";
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 242;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 252;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Allow Clearance";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 98;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Allow Underwriting";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 104;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "View";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 52;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Restrict Bind";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 76;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Restrict Issuance";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 100;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ugUserLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugUserLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.MaxSelectedRows = 5;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugUserLines).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugUserLines).Location = new Point(7, 34);
    ((Control) this.ugUserLines).Name = "ugUserLines";
    ((Control) this.ugUserLines).Size = new Size(684, 348);
    ((Control) this.ugUserLines).TabIndex = 2;
    ((UltraControlBase) this.ugUserLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugUserLines).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ddLines).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.DsUserLines;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 133;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 350;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 1;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 2;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 6;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((UltraDropDownBase) this.ddLines).DropDownWidth = 400;
    ((Control) this.ddLines).Location = new Point(365, 292);
    ((UltraDropDownBase) this.ddLines).MaxDropDownItems = 15;
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(182, 76);
    ((Control) this.ddLines).TabIndex = 21;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance12.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance12;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(599, 472);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 22;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance13.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance13;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(647, 472);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(42, 42);
    ((Control) this.btnCancel).TabIndex = 23;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkAddUserToAllLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAddUserToAllLine.AutoSize = true;
    this.lnkAddUserToAllLine.Location = new Point(348, 391);
    this.lnkAddUserToAllLine.Name = "lnkAddUserToAllLine";
    this.lnkAddUserToAllLine.Size = new Size(138, 13);
    this.lnkAddUserToAllLine.TabIndex = 24;
    this.lnkAddUserToAllLine.TabStop = true;
    this.lnkAddUserToAllLine.Text = "Add current user to all lines";
    this.lnkAllowAllUnderwriting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAllowAllUnderwriting.AutoSize = true;
    this.lnkAllowAllUnderwriting.Location = new Point(4, 449);
    this.lnkAllowAllUnderwriting.Name = "lnkAllowAllUnderwriting";
    this.lnkAllowAllUnderwriting.Size = new Size(152, 13);
    this.lnkAllowAllUnderwriting.TabIndex = 25;
    this.lnkAllowAllUnderwriting.TabStop = true;
    this.lnkAllowAllUnderwriting.Text = "Check all - 'Allow Underwriting'";
    this.lnkAllClearance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAllClearance.AutoSize = true;
    this.lnkAllClearance.Location = new Point(4, 420);
    this.lnkAllClearance.Name = "lnkAllClearance";
    this.lnkAllClearance.Size = new Size(142, 13);
    this.lnkAllClearance.TabIndex = 26;
    this.lnkAllClearance.TabStop = true;
    this.lnkAllClearance.Text = "Check all  - 'Allow Clearance'";
    this.lnkCheckAllView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCheckAllView.AutoSize = true;
    this.lnkCheckAllView.Location = new Point(4, 391);
    this.lnkCheckAllView.Name = "lnkCheckAllView";
    this.lnkCheckAllView.Size = new Size(85, 13);
    this.lnkCheckAllView.TabIndex = 27;
    this.lnkCheckAllView.TabStop = true;
    this.lnkCheckAllView.Text = "Check all - 'View'";
    this.lnkUnCheckAllView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUnCheckAllView.AutoSize = true;
    this.lnkUnCheckAllView.Location = new Point(185, 391);
    this.lnkUnCheckAllView.Name = "lnkUnCheckAllView";
    this.lnkUnCheckAllView.Size = new Size(96 /*0x60*/, 13);
    this.lnkUnCheckAllView.TabIndex = 30;
    this.lnkUnCheckAllView.TabStop = true;
    this.lnkUnCheckAllView.Text = "Uncheck all - 'View'";
    this.lnkUnCheckAllClearance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUnCheckAllClearance.AutoSize = true;
    this.lnkUnCheckAllClearance.Location = new Point(185, 420);
    this.lnkUnCheckAllClearance.Name = "lnkUnCheckAllClearance";
    this.lnkUnCheckAllClearance.Size = new Size(153, 13);
    this.lnkUnCheckAllClearance.TabIndex = 29;
    this.lnkUnCheckAllClearance.TabStop = true;
    this.lnkUnCheckAllClearance.Text = "Uncheck all  - 'Allow Clearance'";
    this.lnkUnCheckAllowAllUnderwriting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUnCheckAllowAllUnderwriting.AutoSize = true;
    this.lnkUnCheckAllowAllUnderwriting.Location = new Point(185, 449);
    this.lnkUnCheckAllowAllUnderwriting.Name = "lnkUnCheckAllowAllUnderwriting";
    this.lnkUnCheckAllowAllUnderwriting.Size = new Size(163, 13);
    this.lnkUnCheckAllowAllUnderwriting.TabIndex = 28;
    this.lnkUnCheckAllowAllUnderwriting.TabStop = true;
    this.lnkUnCheckAllowAllUnderwriting.Text = "Uncheck all - 'Allow Underwriting'";
    this.lnkUncheckAllBind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUncheckAllBind.AutoSize = true;
    this.lnkUncheckAllBind.Location = new Point(185, 478);
    this.lnkUncheckAllBind.Name = "lnkUncheckAllBind";
    this.lnkUncheckAllBind.Size = new Size(134, 13);
    this.lnkUncheckAllBind.TabIndex = 32 /*0x20*/;
    this.lnkUncheckAllBind.TabStop = true;
    this.lnkUncheckAllBind.Text = "Uncheck all - 'Restrict Bind'";
    this.lnkCheckAllBind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCheckAllBind.AutoSize = true;
    this.lnkCheckAllBind.Location = new Point(4, 478);
    this.lnkCheckAllBind.Name = "lnkCheckAllBind";
    this.lnkCheckAllBind.Size = new Size(123, 13);
    this.lnkCheckAllBind.TabIndex = 31 /*0x1F*/;
    this.lnkCheckAllBind.TabStop = true;
    this.lnkCheckAllBind.Text = "Check all - 'Restrict Bind'";
    this.lnkUncheckAllIssuance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkUncheckAllIssuance.AutoSize = true;
    this.lnkUncheckAllIssuance.Location = new Point(185, 501);
    this.lnkUncheckAllIssuance.Name = "lnkUncheckAllIssuance";
    this.lnkUncheckAllIssuance.Size = new Size(157, 13);
    this.lnkUncheckAllIssuance.TabIndex = 34;
    this.lnkUncheckAllIssuance.TabStop = true;
    this.lnkUncheckAllIssuance.Text = "Uncheck all - 'Restrict Issuance'";
    this.lnkCheckAllIssuance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCheckAllIssuance.AutoSize = true;
    this.lnkCheckAllIssuance.Location = new Point(4, 501);
    this.lnkCheckAllIssuance.Name = "lnkCheckAllIssuance";
    this.lnkCheckAllIssuance.Size = new Size(146, 13);
    this.lnkCheckAllIssuance.TabIndex = 33;
    this.lnkCheckAllIssuance.TabStop = true;
    this.lnkCheckAllIssuance.Text = "Check all - 'Restrict Issuance'";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(697, 524);
    this.Controls.Add((Control) this.lnkUncheckAllIssuance);
    this.Controls.Add((Control) this.lnkCheckAllIssuance);
    this.Controls.Add((Control) this.lnkUncheckAllBind);
    this.Controls.Add((Control) this.lnkCheckAllBind);
    this.Controls.Add((Control) this.lnkUnCheckAllView);
    this.Controls.Add((Control) this.lnkUnCheckAllClearance);
    this.Controls.Add((Control) this.lnkUnCheckAllowAllUnderwriting);
    this.Controls.Add((Control) this.lnkCheckAllView);
    this.Controls.Add((Control) this.lnkAllClearance);
    this.Controls.Add((Control) this.lnkAllowAllUnderwriting);
    this.Controls.Add((Control) this.lnkAddUserToAllLine);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ugUserLines);
    this.Controls.Add((Control) this.lblName);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.Name = nameof (frmUserLines);
    this.Text = "User Lines Management";
    this.DsUserLines.EndInit();
    ((ISupportInitialize) this.ugUserLines).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmUserLines(Guid userGuid, string name)
  {
    this.Load += new EventHandler(this.frmUserLines_Load);
    this.Closing += new CancelEventHandler(this.frmUserLines_Closing);
    this.InitializeComponent();
    this._userGuid = userGuid;
    ((ControlBase) this.lblName).Text = name;
  }

  private void frmUserLines_Load(object sender, EventArgs e)
  {
    DbConnection connection = (DbConnection) DefaultDatabase.CreateConnection();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daLines, connection, (DbTransaction) null);
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daUsersLines, connection, (DbTransaction) null);
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((UltraGridBase) this.ugUserLines).DisplayLayout.Bands[0].Columns["LineGUID"].SortIndicator = (SortIndicator) 1;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLines, (DataTable) this.DsUserLines.lstLines);
    this.daUsersLines.SelectCommand.Parameters["@UserGuid"].Value = (object) this._userGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daUsersLines, (DataTable) this.DsUserLines.tblUsersLines);
  }

  private void frmUserLines_Closing(object sender, CancelEventArgs e)
  {
    if (this.SaveChanges())
      return;
    e.Cancel = true;
  }

  private bool SaveChanges()
  {
    bool flag = true;
    if (this.DsUserLines.HasChanges())
    {
      try
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daUsersLines, (DataTable) this.DsUserLines.tblUsersLines);
        CurrentUser.Instance.LogAction("Users Menu - Modified rights for line of business ", this._userGuid);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("An error occured while trying to save.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        flag = false;
        ProjectData.ClearProjectError();
      }
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.SaveChanges())
      return;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DsUserLines.RejectChanges();
    ((UltraGridBase) this.ugUserLines).UpdateData();
  }

  private void ugUserLines_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["UserGUID"].Value = (object) this._userGuid;
    CurrentUser.Instance.LogAction("Users Menu - Attempting to add rights for line of business. ", this._userGuid);
  }

  private void ddLines_BeforeDropDown(object sender, CancelEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ddLines).Rows)
    {
      row.Hidden = false;
      if (this.DsUserLines.tblUsersLines.FindByUserGUIDLineGUID(this._userGuid, (Guid) row.Cells["LineGUID"].Value) != null)
        row.Hidden = true;
    }
  }

  private void lnkAllClearance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check all 'Allow Clearance'?", "Check All Allow Clearance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowClearance", true);
  }

  private void lnkAllowAllUnderwriting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check 'Allow Underwriting' for all lines?", "Check Allow Underwriting For All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowUnderwriting", true);
  }

  private void MarkColumnChecked(string columnName, bool booleanValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugUserLines).Rows)
      row.Cells[columnName].Value = (object) booleanValue;
    ((UltraGridBase) this.ugUserLines).UpdateData();
  }

  private void lnkAddUserToAllLine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to add the current user to all lines?", "Add Current User to All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    foreach (UltraGridRow row1 in ((UltraGridBase) this.ddLines).Rows)
    {
      if (this.DsUserLines.tblUsersLines.FindByUserGUIDLineGUID(this._userGuid, (Guid) row1.Cells["LineGUID"].Value) == null)
      {
        dsUserLines.tblUsersLinesRow row2 = this.DsUserLines.tblUsersLines.NewtblUsersLinesRow();
        row2.UserGUID = this._userGuid;
        row2.LineGUID = (Guid) row1.Cells["LineGUID"].Value;
        this.DsUserLines.tblUsersLines.AddtblUsersLinesRow(row2);
      }
    }
  }

  private void lnkCheckAllView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check 'View' for all lines?", "Check 'View' For All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowView", true);
  }

  private void ugUserLines_AfterRowUpdate(object sender, RowEventArgs e)
  {
    Guid guid = (Guid) e.Row.Cells["lineGUID"].Value;
    string context = this.DsUserLines.lstLines.Rows.Find((object) guid)["LineName"].ToString();
    CurrentUser.Instance.LogAction("Users Menu - Modified user access rights for line of business: " + context, guid, context);
  }

  private void lnkUnCheckAllView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to uncheck 'View' for all lines?", "Uncheck 'View' For All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowView", false);
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
    if (MessageBox.Show("Do you wish to uncheck 'Allow Underwriting' for all lines?", "Uncheck Allow Underwriting For All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("AllowUnderwriting", false);
  }

  private void lnkCheckAllBind_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check 'Restrict Bind' for all lines?", "Check Restrict Bind For All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("RestrictBind", true);
  }

  private void lnkUncheckAllBind_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to uncheck all 'Restrict Bind'?", "Uncheck All Restrict Bind", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("RestrictBind", false);
  }

  private void LnkCheckAllIssuance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to check 'Restrict Issuance' for all lines?", "Check Restrict Issuance For All Lines", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("RestrictIssuance", true);
  }

  private void LnkUncheckAllIssuance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Do you wish to uncheck all 'Restrict Issuance'?", "Uncheck All Restrict Issuance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.MarkColumnChecked("RestrictIssuance", false);
  }
}
