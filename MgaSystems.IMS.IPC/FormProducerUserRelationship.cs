// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormProducerUserRelationship
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormProducerUserRelationship : Form
{
  private IContainer components;
  private readonly Guid _producerGuid;
  private readonly Guid _producerLocationGuid;
  private bool _isLoading;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormProducerUserRelationship));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstProducerUserRelationship", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Relationship");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("NameUser");
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerUserRelationship", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("UserGuid", -1, (object) "ddUsers");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OnProducerLocationLevel");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("RelationShipID", -1, (object) "ddRelationships");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.da = new SqlDataAdapter();
    this.sqlCommand3 = new SqlCommand();
    this.sqlCommand6 = new SqlCommand();
    this.sqlCommand7 = new SqlCommand();
    this.sqlCommand8 = new SqlCommand();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.ddRelationships = new UltraDropDown();
    this.ds = new dsProducerUserRelationship();
    this.ddUsers = new UltraDropDown();
    this.ugRelationships = new UltraGrid();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ddRelationships).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddUsers).BeginInit();
    ((ISupportInitialize) this.ugRelationships).BeginInit();
    this.SuspendLayout();
    this.da.DeleteCommand = this.sqlCommand3;
    this.da.InsertCommand = this.sqlCommand6;
    this.da.SelectCommand = this.sqlCommand7;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerUserRelationship", new DataColumnMapping[6]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("ProducerGuid", "ProducerGuid"),
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("OnProducerLocationLevel", "OnProducerLocationLevel"),
        new DataColumnMapping("RelationShipID", "RelationShipID")
      })
    });
    this.da.UpdateCommand = this.sqlCommand8;
    this.sqlCommand3.CommandText = "DELETE FROM [tblProducerUserRelationship] WHERE (([ID] = @Original_ID))";
    this.sqlCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.sqlCommand6.CommandText = componentResourceManager.GetString("sqlCommand6.CommandText");
    this.sqlCommand6.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 0, "UserGuid"),
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 0, "ProducerGuid"),
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGuid"),
      new SqlParameter("@OnProducerLocationLevel", SqlDbType.Bit, 0, "OnProducerLocationLevel"),
      new SqlParameter("@RelationShipID", SqlDbType.TinyInt, 0, "RelationShipID")
    });
    this.sqlCommand7.CommandText = componentResourceManager.GetString("sqlCommand7.CommandText");
    this.sqlCommand7.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGuid"),
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGuid")
    });
    this.sqlCommand8.CommandText = componentResourceManager.GetString("sqlCommand8.CommandText");
    this.sqlCommand8.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 0, "UserGuid"),
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 0, "ProducerGuid"),
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGuid"),
      new SqlParameter("@OnProducerLocationLevel", SqlDbType.Bit, 0, "OnProducerLocationLevel"),
      new SqlParameter("@RelationShipID", SqlDbType.TinyInt, 0, "RelationShipID"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(424, 226);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 371;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(357, 226);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 370;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddRelationships).DataMember = "lstProducerUserRelationship";
    ((UltraGridBase) this.ddRelationships).DataSource = (object) this.ds;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 200;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddRelationships).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddRelationships).DisplayMember = "Relationship";
    ((Control) this.ddRelationships).Location = new Point(180, 83);
    ((Control) this.ddRelationships).Name = "ddRelationships";
    ((Control) this.ddRelationships).Size = new Size(85, 63 /*0x3F*/);
    ((Control) this.ddRelationships).TabIndex = 376;
    ((UltraDropDownBase) this.ddRelationships).ValueMember = "ID";
    ((Control) this.ddRelationships).Visible = false;
    this.ds.DataSetName = "dsProducerUserRelationship";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddUsers).DataMember = "tblUsers";
    ((UltraGridBase) this.ddUsers).DataSource = (object) this.ds;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "";
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 130;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddUsers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddUsers).DisplayMember = "NameUser";
    ((Control) this.ddUsers).Location = new Point(31 /*0x1F*/, 83);
    ((Control) this.ddUsers).Name = "ddUsers";
    ((Control) this.ddUsers).Size = new Size(85, 63 /*0x3F*/);
    ((Control) this.ddUsers).TabIndex = 373;
    ((UltraDropDownBase) this.ddUsers).ValueMember = "UserGUID";
    ((Control) this.ddUsers).Visible = false;
    ((Control) this.ugRelationships).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugRelationships).DataMember = "tblProducerUserRelationship";
    ((UltraGridBase) this.ugRelationships).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.ugRelationships).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugRelationships).DisplayLayout.AddNewBox).Prompt = " Add ...";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand3.AddButtonCaption = "Relationship";
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "User";
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 130;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Producer Location";
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 252;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Producer";
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 129;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Save On Location";
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Width = 124;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Relationship";
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 100;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ugRelationships).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugRelationships).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugRelationships).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugRelationships).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugRelationships).Location = new Point(12, 12);
    ((Control) this.ugRelationships).Name = "ugRelationships";
    ((Control) this.ugRelationships).Size = new Size(452, 208 /*0xD0*/);
    ((Control) this.ugRelationships).TabIndex = 372;
    ((UltraControlBase) this.ugRelationships).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRelationships).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(476, 271);
    this.Controls.Add((Control) this.ddRelationships);
    this.Controls.Add((Control) this.ddUsers);
    this.Controls.Add((Control) this.ugRelationships);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (FormProducerUserRelationship);
    this.Text = "Producer User Relationship";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ddRelationships).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddUsers).EndInit();
    ((ISupportInitialize) this.ugRelationships).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand3")]
  private virtual SqlCommand sqlCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand6")]
  private virtual SqlCommand sqlCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand7")]
  private virtual SqlCommand sqlCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("sqlCommand8")]
  private virtual SqlCommand sqlCommand8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProducerUserRelationship ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugRelationships
  {
    get => this._ugRelationships;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugRelationships_AfterCellUpdate);
      BeforeCellUpdateEventHandler updateEventHandler = new BeforeCellUpdateEventHandler(this.ugRelationships_BeforeCellUpdate);
      UltraGrid ugRelationships1 = this._ugRelationships;
      if (ugRelationships1 != null)
      {
        ugRelationships1.AfterCellUpdate -= cellEventHandler;
        ugRelationships1.BeforeCellUpdate -= updateEventHandler;
      }
      this._ugRelationships = value;
      UltraGrid ugRelationships2 = this._ugRelationships;
      if (ugRelationships2 == null)
        return;
      ugRelationships2.AfterCellUpdate += cellEventHandler;
      ugRelationships2.BeforeCellUpdate += updateEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddUsers")]
  private virtual UltraDropDown ddUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddRelationships")]
  private virtual UltraDropDown ddRelationships { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProducerUserRelationship(Guid producerLocationGuid, Guid producerGuid)
  {
    this.Load += new EventHandler(this.FormProducerUserRelationship_Load);
    this._isLoading = true;
    this.InitializeComponent();
    this._producerGuid = producerGuid;
    this._producerLocationGuid = producerLocationGuid;
  }

  private void FormProducerUserRelationship_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUsers"
    }, CommandType.Text, "SELECT UserGUID, Name_LastFirst AS NameUser FROM tblUsers WITH (NOLOCK) ORDER BY NameUser");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstProducerUserRelationship"
    }, CommandType.Text, "SELECT ID, RelationShip FROM lstProducerUserRelationship ORDER BY Relationship");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerUserRelationship"
    }, CommandType.Text, "SELECT ID, UserGuid, ProducerGuid, ProducerLocationGuid, OnProducerLocationLevel, RelationShipID FROM tblProducerUserRelationship WHERE (ProducerGuid = @PG) OR (ProducerLocationGuid = @PLG)", new object[4]
    {
      (object) "@PG",
      (object) this._producerGuid,
      (object) "@PLG",
      (object) this._producerLocationGuid
    });
    this._isLoading = false;
  }

  private bool ValidateForm()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRelationships).Rows)
    {
      if (row.Cells["UserGuid"].Value == DBNull.Value)
      {
        int num = (int) MessageBox.Show("User cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        break;
      }
      if (row.Cells["RelationShipID"].Value == DBNull.Value)
      {
        int num = (int) MessageBox.Show("Relationship cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        break;
      }
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.Cursor = MgaCursors.WaitCursor;
    Utility.SetDataAdapterConnections((DbDataAdapter) this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblProducerUserRelationship);
    this.Cursor = MgaCursors.Default;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.ds.tblProducerUserRelationship.RejectChanges();
  }

  private void ugRelationships_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (this._isLoading || e.Cell.Row == null || e.Cell.Row.Cells["OnProducerLocationLevel"].Value == DBNull.Value)
      return;
    if (Conversions.ToBoolean(e.Cell.Row.Cells["OnProducerLocationLevel"].Value))
    {
      e.Cell.Row.Cells["ProducerLocationGuid"].Value = (object) this._producerLocationGuid;
      e.Cell.Row.Cells["ProducerGuid"].Value = (object) DBNull.Value;
    }
    else
    {
      e.Cell.Row.Cells["ProducerLocationGuid"].Value = (object) DBNull.Value;
      e.Cell.Row.Cells["ProducerGuid"].Value = (object) this._producerGuid;
    }
    ((UltraGridBase) this.ugRelationships).UpdateData();
  }

  private void ugRelationships_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "OnProducerLocationLevel", false);
  }
}
