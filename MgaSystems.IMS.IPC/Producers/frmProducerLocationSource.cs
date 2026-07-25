// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerLocationSource
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
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

[SecureResource("{e6af3085-a58f-47dc-aa44-48411e01fe3b}", "Access Producer Location Source Screen", "Controls access to the Producer Location Source screen.", "Producers")]
public class frmProducerLocationSource : Form
{
  private IContainer components;
  public const string OpenForm = "{e6af3085-a58f-47dc-aa44-48411e01fe3b}";

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstProducerLocationSource", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("id");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("source");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.dsLocationSource = new dsLocationSource();
    this.ugSource = new UltraGrid();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlConnection1 = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlDataAdapter1 = new SqlDataAdapter();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.dsLocationSource.BeginInit();
    ((ISupportInitialize) this.ugSource).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(565, 487);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 373;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(506, 487);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 372;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.dsLocationSource.DataSetName = "dsLocationSource";
    this.dsLocationSource.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugSource).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugSource).DataMember = "lstProducerLocationSource";
    ((UltraGridBase) this.ugSource).DataSource = (object) this.dsLocationSource;
    appearance3.BackColor = Color.LightGray;
    appearance3.FontData.BoldAsString = "True";
    appearance3.FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance3;
    appearance4.BorderColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance4;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSource).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugSource).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Add Source";
    ultraGridColumn1.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "ID";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.LockedWidth = true;
    ultraGridColumn1.Width = 116;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Source";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 456;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSource).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugSource).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((Control) this.ugSource).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugSource).Location = new Point(12, 12);
    ((Control) this.ugSource).Name = "ugSource";
    ((Control) this.ugSource).Size = new Size(593, 457);
    ((Control) this.ugSource).TabIndex = 374;
    ((Control) this.ugSource).Text = "Available Producer Sources";
    ((UltraControlBase) this.ugSource).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSource).UseOsThemes = (DefaultableBoolean) 2;
    this.SqlSelectCommand1.CommandText = "SELECT        ID, Source\r\nFROM            lstProducerLocationSource\r\nWHERE        (ID = @ID)";
    this.SqlSelectCommand1.Connection = this.SqlConnection1;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ID", SqlDbType.TinyInt, 1, "ID")
    });
    this.SqlConnection1.ConnectionString = "Data Source=10.0.0.40;Initial Catalog=WKFC_IMS;User ID=wkfc_ims";
    this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = "INSERT INTO [lstProducerLocationSource] ([Source]) VALUES (@Source);\r\nSELECT ID, Source FROM lstProducerLocationSource WHERE (ID = SCOPE_IDENTITY())";
    this.SqlInsertCommand1.Connection = this.SqlConnection1;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Source", SqlDbType.VarChar, 0, "Source")
    });
    this.SqlUpdateCommand1.CommandText = "UPDATE [lstProducerLocationSource] SET [Source] = @Source WHERE (([ID] = @Original_ID) AND ([Source] = @Original_Source));\r\nSELECT ID, Source FROM lstProducerLocationSource WHERE (ID = @ID)";
    this.SqlUpdateCommand1.Connection = this.SqlConnection1;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@Source", SqlDbType.VarChar, 0, "Source"),
      new SqlParameter("@Original_ID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Source", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Source", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.TinyInt, 1, "ID")
    });
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [lstProducerLocationSource] WHERE (([ID] = @Original_ID) AND ([Source] = @Original_Source))";
    this.SqlDeleteCommand1.Connection = this.SqlConnection1;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_ID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Source", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Source", DataRowVersion.Original, (object) null)
    });
    this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
    this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand1;
    this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
    this.SqlDataAdapter1.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstProducerLocationSource", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Source", "Source")
      })
    });
    this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
    this.ClientSize = new Size(617, 539);
    this.Controls.Add((Control) this.ugSource);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (frmProducerLocationSource);
    this.Text = "Producer Source ";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.dsLocationSource.EndInit();
    ((ISupportInitialize) this.ugSource).EndInit();
    this.ResumeLayout(false);
  }

  protected virtual UltraGrid ugSource
  {
    get => this._ugSource;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ugSource_InitializeLayout);
      UltraGrid ugSource1 = this._ugSource;
      if (ugSource1 != null)
        ugSource1.InitializeLayout -= layoutEventHandler;
      this._ugSource = value;
      UltraGrid ugSource2 = this._ugSource;
      if (ugSource2 == null)
        return;
      ugSource2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("dsLocationSource")]
  private virtual dsLocationSource dsLocationSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlConnection1")]
  internal virtual SqlConnection SqlConnection1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDataAdapter1")]
  internal virtual SqlDataAdapter SqlDataAdapter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public frmProducerLocationSource()
  {
    this.Load += new EventHandler(this.frmProducerLocationSource_Load);
    this.InitializeComponent();
  }

  private void frmProducerLocationSource_Load(object sender, EventArgs e)
  {
    this.SqlConnection1.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    DefaultDatabase.LoadDataSet((DataSet) this.dsLocationSource, new string[1]
    {
      "lstProducerLocationSource"
    }, "spGetProducerSourceLocations");
    this.dsLocationSource.EnforceConstraints = false;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugSource).Rows)
    {
      if (row.Cells["source"].Value == null || row.Cells["source"].Value == DBNull.Value)
      {
        int num = (int) MessageBox.Show("'Source' column cannot be empty", "Empty Source Column", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (row.Cells["source"].Value.ToString().Replace(" ", "").Length == 0)
      {
        int num = (int) MessageBox.Show("'Source' column cannot be blank entries", "Blank Source Column", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.SqlDataAdapter1, (DataTable) this.dsLocationSource.lstProducerLocationSource);
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.dsLocationSource.RejectChanges();

  private void ugSource_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Bands[0].Columns["source"].Nullable = (Nullable) 4;
  }
}
