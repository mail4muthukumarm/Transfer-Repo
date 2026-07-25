// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCompanyStrength
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
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
public class FormCompanyStrength : Form
{
  private IContainer components;

  public FormCompanyStrength()
  {
    this.Load += new EventHandler(this.FormCompanyStrength_Load);
    this.InitializeComponent();
  }

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
    UltraGridBand ultraGridBand = new UltraGridBand("lstFSR", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FSRID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("FSR");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.ug = new UltraGrid();
    this.ds = new dsCompanyStrength();
    this.btnSave = new MGAButton();
    this.cnSQL = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Strengths";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 179;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company Strength";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 242;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 1;
    ultraGridBand.Override.SelectTypeCell = (SelectType) 2;
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ug).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ug).Location = new Point(-3, 1);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(261, 372);
    ((Control) this.ug).TabIndex = 1;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyStrength";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(208 /*0xD0*/, 379);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 6;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cnSQL.ConnectionString = "Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand2;
    this.da.InsertCommand = this.SqlInsertCommand2;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstFSR", new DataColumnMapping[2]
      {
        new DataColumnMapping("FSRID", "FSRID"),
        new DataColumnMapping("FSR", "FSR")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[lstFSR] WHERE (([FSRID] = @Original_FSRID))";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_FSRID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FSRID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = "INSERT INTO [dbo].[lstFSR] ([FSR]) VALUES (@FSR);\r\nSELECT FSRID, FSR FROM dbo.lstFSR WHERE (FSRID = SCOPE_IDENTITY())";
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@FSR", SqlDbType.VarChar, 0, "FSR")
    });
    this.SqlSelectCommand1.CommandText = "SELECT     FSRID, FSR\r\nFROM         dbo.lstFSR";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand2.CommandText = "UPDATE [dbo].[lstFSR] SET [FSR] = @FSR WHERE (([FSRID] = @Original_FSRID));\r\nSELECT FSRID, FSR FROM dbo.lstFSR WHERE (FSRID = @FSRID)";
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@FSR", SqlDbType.VarChar, 0, "FSR"),
      new SqlParameter("@Original_FSRID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FSRID", DataRowVersion.Original, (object) null),
      new SqlParameter("@FSRID", SqlDbType.Int, 4, "FSRID")
    });
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(260, 429);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ug);
    this.Name = nameof (FormCompanyStrength);
    this.Text = "Company Strength";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ug")]
  private virtual UltraGrid ug { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyStrength ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand2")]
  internal virtual SqlCommand SqlDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand2")]
  internal virtual SqlCommand SqlInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand2")]
  internal virtual SqlCommand SqlUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void FormCompanyStrength_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstFSR"
    }, CommandType.Text, "SELECT FSRID, FSR FROM lstFSR ORDER BY FSRID");
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    using (SqlConnection connection = DefaultDatabase.CreateConnection())
    {
      this.da.InsertCommand.Connection = connection;
      this.da.UpdateCommand.Connection = connection;
      this.da.DeleteCommand.Connection = connection;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.lstFSR);
    }
    this.Close();
  }
}
