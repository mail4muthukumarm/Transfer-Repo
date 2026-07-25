// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCancellationRequirements
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCancellationRequirements : Form
{
  private IContainer components;
  private readonly int _companyLineID;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLineCancellationRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CancellationRequirementID", -1, (object) "ddCancellationReq");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstCancellationRequirements", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CancellationRequirementID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CancellationRequirement");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("lstCancellationRequirements_tblCompanyLineCancellationRequirements");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstCancellationRequirements_tblCompanyLineCancellationRequirements", 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CancellationRequirementID");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCancellationRequirements));
    this.ug = new UltraGrid();
    this.ds = new dsCancellationRequirement();
    this.ddCancellationReq = new UltraDropDown();
    this.daCompanyCancellationRequirements = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddCancellationReq).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.ug).DataMember = "tblCompanyLineCancellationRequirements";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ultraGridBand1.AddButtonCaption = "New Cancellation Requirement";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Cancellation Requirement";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 544;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.WhiteSmoke;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance5;
    ((Control) this.ug).Dock = DockStyle.Fill;
    ((Control) this.ug).Location = new Point(0, 0);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(569, 346);
    ((Control) this.ug).TabIndex = 1;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCancellationRequirement";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddCancellationReq).DataMember = "lstCancellationRequirements";
    ((UltraGridBase) this.ddCancellationReq).DataSource = (object) this.ds;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.Gray;
    ((UltraGridBase) this.ddCancellationReq).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ddCancellationReq).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ddCancellationReq).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddCancellationReq).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddCancellationReq).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddCancellationReq).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddCancellationReq).DisplayMember = "CancellationRequirement";
    ((UltraDropDownBase) this.ddCancellationReq).DropDownWidth = 499;
    ((Control) this.ddCancellationReq).Location = new Point(12, 83);
    ((Control) this.ddCancellationReq).Name = "ddCancellationReq";
    ((Control) this.ddCancellationReq).Size = new Size(545, 112 /*0x70*/);
    ((Control) this.ddCancellationReq).TabIndex = 2;
    ((UltraControlBase) this.ddCancellationReq).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddCancellationReq).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddCancellationReq).ValueMember = "CancellationRequirementID";
    ((Control) this.ddCancellationReq).Visible = false;
    this.daCompanyCancellationRequirements.DeleteCommand = this.DbDeleteCommand1;
    this.daCompanyCancellationRequirements.InsertCommand = this.DbInsertCommand1;
    this.daCompanyCancellationRequirements.SelectCommand = this.DbSelectCommand1;
    this.daCompanyCancellationRequirements.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineCancellationRequirements", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("CancellationRequirementID", "CancellationRequirementID")
      })
    });
    this.daCompanyCancellationRequirements.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblCompanyLineCancellationRequirements] WHERE (([CompanyLineID] = @Original_CompanyLineID) AND ([CancellationRequirementID] = @Original_CancellationRequirementID))";
    this.DbDeleteCommand1.Connection = this.cn;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CancellationRequirementID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CancellationRequirementID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cn;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 0, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@CancellationRequirementID", SqlDbType.Int, 0, "CancellationRequirementID")
    });
    this.DbSelectCommand1.CommandText = "SELECT        CompanyLineID, CancellationRequirementID\r\nFROM            dbo.tblCompanyLineCancellationRequirements\r\nWHERE        (CompanyLineID = @companyLineID)";
    this.DbSelectCommand1.Connection = this.cn;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@companyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cn;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 0, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@CancellationRequirementID", SqlDbType.Int, 0, "CancellationRequirementID"),
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_CancellationRequirementID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CancellationRequirementID", DataRowVersion.Original, (object) null)
    });
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(569, 346);
    this.Controls.Add((Control) this.ddCancellationReq);
    this.Controls.Add((Control) this.ug);
    this.Name = nameof (FormCancellationRequirements);
    this.Text = "Company / Line Cancellation Requirements";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddCancellationReq).EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ug_AfterRowInsert);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ug_BeforeRowUpdate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
      {
        ug1.AfterRowInsert -= rowEventHandler;
        ug1.BeforeRowUpdate -= cancelableRowEventHandler;
      }
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowInsert += rowEventHandler;
      ug2.BeforeRowUpdate += cancelableRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddCancellationReq")]
  private virtual UltraDropDown ddCancellationReq { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCancellationRequirement ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daCompanyCancellationRequirements")]
  private virtual DbDataAdapter daCompanyCancellationRequirements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbDeleteCommand1")]
  private virtual DbCommand DbDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual DbConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbInsertCommand1")]
  private virtual DbCommand DbInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  private virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbUpdateCommand1")]
  private virtual DbCommand DbUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCancellationRequirements(int companyLineID)
  {
    this.Load += new EventHandler(this.FormCancellationRequirements_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormCancellationRequirements_FormClosing);
    this.InitializeComponent();
    this._companyLineID = companyLineID;
  }

  private void FormCancellationRequirements_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstCancellationRequirements"
    }, CommandType.Text, "SELECT CancellationRequirementID, CancellationRequirement FROM lstCancellationRequirements ORDER BY CancellationRequirement");
    this.daCompanyCancellationRequirements.SelectCommand.Parameters["@companyLineID"].Value = (object) this._companyLineID;
    DefaultDatabase.DataAdapterFill(this.daCompanyCancellationRequirements, (DataTable) this.ds.tblCompanyLineCancellationRequirements);
  }

  private void ug_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyLineID"].Value = (object) this._companyLineID;
  }

  private void ug_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["CancellationRequirementID"].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void FormCancellationRequirements_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.ug.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ug).ActiveRow != null)
      ((UltraGridBase) this.ug).ActiveRow.Update();
    ((UltraGridBase) this.ug).UpdateData();
    DefaultDatabase.DataAdapterUpdate(this.daCompanyCancellationRequirements, (DataTable) this.ds.tblCompanyLineCancellationRequirements);
  }
}
