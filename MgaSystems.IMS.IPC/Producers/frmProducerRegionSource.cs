// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerRegionSource
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[SecureResource("{b2d2b500-c0aa-47b5-ab9d-398a90a7cdf1}", "Access Producer Region Source Screen", "Controls access to the Producer Region Source screen.", "Producers")]
public class frmProducerRegionSource : Form
{
  public const string OpenForm = "{b2d2b500-c0aa-47b5-ab9d-398a90a7cdf1}";

  public frmProducerRegionSource()
  {
    this.Load += new EventHandler(this.frmProducerRegionSource_Load);
    this.InitializeComponent();
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstProducerLocationRegions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("id");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerRegion");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmProducerRegionSource));
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.ugSource = new UltraGrid();
    this.DsRegionSource1 = new dsRegionSource();
    this.SqlConnection1 = new SqlConnection();
    this.SqlDataAdapter1 = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.SqlCommand1 = new SqlCommand();
    ((ISupportInitialize) this.ugSource).BeginInit();
    this.DsRegionSource1.BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugSource).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugSource).DataMember = "lstProducerLocationRegions";
    ((UltraGridBase) this.ugSource).DataSource = (object) this.DsRegionSource1;
    appearance1.BackColor = Color.LightGray;
    appearance1.FontData.BoldAsString = "True";
    appearance1.FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BorderColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSource).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugSource).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Add Source";
    ultraGridColumn1.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "ID";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.LockedWidth = true;
    ultraGridColumn1.Width = 44;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 558;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSource).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugSource).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((Control) this.ugSource).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugSource).Location = new Point(2, 2);
    ((Control) this.ugSource).Name = "ugSource";
    ((Control) this.ugSource).Size = new Size(623, 407);
    ((Control) this.ugSource).TabIndex = 377;
    ((Control) this.ugSource).Text = "Available Producer Regions";
    ((UltraControlBase) this.ugSource).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSource).UseOsThemes = (DefaultableBoolean) 2;
    this.DsRegionSource1.DataSetName = "dsRegionSource";
    this.DsRegionSource1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.SqlConnection1.ConnectionString = "Data Source=10.0.1.35\\PASTEST,1525;Initial Catalog=QEO_Test;User ID=QeoTest";
    this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
    this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
    this.SqlDataAdapter1.InsertCommand = this.SqlCommand1;
    this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
    this.SqlDataAdapter1.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstProducerLocationRegions", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("ProducerRegion", "ProducerRegion")
      })
    });
    this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [lstProducerLocationRegions] WHERE (([ID] = @Original_ID) AND ([ProducerRegion] = @Original_ProducerRegion))";
    this.SqlDeleteCommand1.Connection = this.SqlConnection1;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ID", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerRegion", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerRegion", DataRowVersion.Original, (object) null)
    });
    this.SqlSelectCommand1.CommandText = "SELECT        ID, ProducerRegion\r\nFROM            lstProducerLocationRegions\r\nWHERE        (ID = @ID)";
    this.SqlSelectCommand1.Connection = this.SqlConnection1;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ID", DataRowVersion.Current, (object) null)
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.SqlConnection1;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@ProducerRegion", SqlDbType.VarChar, 0, "ProducerRegion"),
      new SqlParameter("@Original_ID", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerRegion", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerRegion", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "ID", DataRowVersion.Current, (object) null)
    });
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.ImageHAlign = (HAlign) 2;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance11;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(585, 428);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 379;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance12.ImageHAlign = (HAlign) 2;
    appearance12.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance12;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(526, 428);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 378;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.SqlCommand1.CommandText = "INSERT INTO [lstProducerLocationRegions] ([ProducerRegion]) VALUES (@ProducerRegion);\r\nSELECT ID, ProducerRegion FROM lstProducerLocationRegions WHERE (ID = SCOPE_IDENTITY())";
    this.SqlCommand1.Connection = this.SqlConnection1;
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerRegion", SqlDbType.VarChar, 0, "ProducerRegion")
    });
    this.ClientSize = new Size(637, 502);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugSource);
    this.Name = nameof (frmProducerRegionSource);
    ((ISupportInitialize) this.ugSource).EndInit();
    this.DsRegionSource1.EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
  }

  protected virtual UltraGrid ugSource
  {
    get => this._ugSource;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeRowsDeletedEventHandler deletedEventHandler = new BeforeRowsDeletedEventHandler(this.ugSource_BeforeRowsDeleted);
      UltraGrid ugSource1 = this._ugSource;
      if (ugSource1 != null)
        ugSource1.BeforeRowsDeleted -= deletedEventHandler;
      this._ugSource = value;
      UltraGrid ugSource2 = this._ugSource;
      if (ugSource2 == null)
        return;
      ugSource2.BeforeRowsDeleted += deletedEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsRegionSource1")]
  internal virtual dsRegionSource DsRegionSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void frmProducerRegionSource_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    this.SqlConnection1.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.DsRegionSource1, new string[1]
    {
      "lstProducerLocationRegions"
    }, "spGetProducerRegions");
    this.DsRegionSource1.EnforceConstraints = false;
  }

  [field: AccessedThroughProperty("SqlConnection1")]
  internal virtual SqlConnection SqlConnection1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDataAdapter1")]
  internal virtual SqlDataAdapter SqlDataAdapter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void MgaButton2_Click(object sender, EventArgs e)
  {
  }

  private void MgaButton1_Click(object sender, EventArgs e) => this.DsRegionSource1.RejectChanges();

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

  private void btnSave_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugSource).Rows)
    {
      if (row.Cells["ProducerRegion"].Value == null || row.Cells["ProducerRegion"].Value == DBNull.Value)
      {
        int num = (int) MessageBox.Show("'region' column cannot be empty", "Empty Region Column", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (row.Cells["ProducerRegion"].Value.ToString().Replace(" ", "").Length == 0)
      {
        int num = (int) MessageBox.Show("'Region' column cannot be blank entries", "Blank Region Column", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.SqlDataAdapter1, (DataTable) this.DsRegionSource1.lstProducerLocationRegions);
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.DsRegionSource1.RejectChanges();

  [field: AccessedThroughProperty("SqlCommand1")]
  internal virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void ugSource_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
    if (((UltraGridBase) this.ugSource).ActiveRow == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(producerlocationregion) from tblProducerLocations where producerlocationregion = @producerlocationregion", new object[2]
    {
      (object) "@producerlocationregion",
      (object) Conversions.ToInteger(((UltraGridBase) this.ugSource).ActiveRow.Cells["ID"].Value)
    }));
    if (objectValue == DBNull.Value || objectValue == null)
      return;
    if (Conversions.ToInteger(objectValue) != 0)
    {
      int num = (int) MessageBox.Show("You can't delete this region because there are producers linked to this region", "Can't delete region", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ((CancelEventArgs) e).Cancel = true;
    }
    else
      e.DisplayPromptMsg = true;
  }
}
