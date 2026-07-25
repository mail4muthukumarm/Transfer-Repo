// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyConstructionTypes
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{76423BDA-8CC8-4a48-BB91-43C968F3B6C8}", "Company Construction Types", "Controls the ability to assign construction types to a specific company/line setup.", "Company")]
public sealed class frmCompanyConstructionTypes : Form
{
  private IContainer components;
  private DbDataAdapter daCompanyConstruction;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private UltraDropDown ddConstructionTypes;
  private dsCompanyConstructionTypes ds;
  public const string LaunchFormSecurityID = "{76423BDA-8CC8-4a48-BB91-43C968F3B6C8}";
  private readonly int _companyLineID;
  private readonly DbConnection _cn;

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ug_BeforeRowUpdate);
      RowEventHandler rowEventHandler = new RowEventHandler(this.ug_AfterRowInsert);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
      {
        ug1.BeforeRowUpdate -= cancelableRowEventHandler;
        ug1.AfterRowInsert -= rowEventHandler;
      }
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.BeforeRowUpdate += cancelableRowEventHandler;
      ug2.AfterRowInsert += rowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyConstructionTypes));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLineConstructionTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ConstructionTypeID", -1, (object) "ddConstructionTypes");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLineID");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstConstructionTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ConstructionTypeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("lstConstructionTypestblCompanyLineConstructionTypes");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstConstructionTypestblCompanyLineConstructionTypes", 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ConstructionTypeID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLineID");
    this.daCompanyConstruction = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.ug = new UltraGrid();
    this.ds = new dsCompanyConstructionTypes();
    this.ddConstructionTypes = new UltraDropDown();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddConstructionTypes).BeginInit();
    this.SuspendLayout();
    this.daCompanyConstruction.DeleteCommand = this.DbDeleteCommand1;
    this.daCompanyConstruction.InsertCommand = this.DbInsertCommand1;
    this.daCompanyConstruction.SelectCommand = this.DbSelectCommand1;
    this.daCompanyConstruction.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineConstructionTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("ConstructionTypeID", "ConstructionTypeID"),
        new DataColumnMapping("CompanyLineID", "CompanyLineID")
      })
    });
    this.daCompanyConstruction.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblCompanyLineConstructionTypes WHERE (CompanyLineID = @Original_CompanyLineID) AND (ConstructionTypeID = @Original_ConstructionTypeID)";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ConstructionTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConstructionTypeID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@ConstructionTypeID", SqlDbType.TinyInt, 1, "ConstructionTypeID"),
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.DbSelectCommand1.CommandText = "SELECT ConstructionTypeID, CompanyLineID FROM tblCompanyLineConstructionTypes WHERE (CompanyLineID = @CompanyLineID)";
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@ConstructionTypeID", SqlDbType.TinyInt, 1, "ConstructionTypeID"),
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@Original_CompanyLineID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ConstructionTypeID", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConstructionTypeID", DataRowVersion.Original, (object) null)
    });
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblCompanyLineConstructionTypes;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Click here to add a new construction setup...";
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Construction Type";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Style = (ColumnStyle) 6;
    ultraGridColumn1.Width = 451;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company / Line";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 98;
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
    ((Control) this.ug).Size = new Size(472, 270);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyConstructionTypes";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddConstructionTypes).DataSource = (object) this.ds.lstConstructionTypes;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 262;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddConstructionTypes).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddConstructionTypes).DisplayMember = "Type";
    ((Control) this.ddConstructionTypes).Location = new Point(80 /*0x50*/, 168);
    ((Control) this.ddConstructionTypes).Name = "ddConstructionTypes";
    ((Control) this.ddConstructionTypes).Size = new Size(264, 40);
    ((Control) this.ddConstructionTypes).TabIndex = 1;
    ((UltraDropDownBase) this.ddConstructionTypes).ValueMember = "ConstructionTypeID";
    ((Control) this.ddConstructionTypes).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(472, 270);
    this.Controls.Add((Control) this.ddConstructionTypes);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmCompanyConstructionTypes);
    this.Text = "Construction Types by Company Line";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddConstructionTypes).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyConstructionTypes(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyConstructionTypes_Load);
    this.Closing += new CancelEventHandler(this.frmCompanyConstructionTypes_Closing);
    if (!SecurityManager.Instance.AssertPermission("{76423BDA-8CC8-4a48-BB91-43C968F3B6C8}"))
      throw new InvalidPermissionException();
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._cn = DefaultDatabase.CreateDbConnection();
  }

  private void frmCompanyConstructionTypes_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstConstructionTypes"
    }, CommandType.Text, "SELECT ConstructionTypeID, Type FROM lstConstructionTypes ORDER BY Type");
    DbDataAdapter companyConstruction = this.daCompanyConstruction;
    companyConstruction.SelectCommand.Connection = this._cn;
    companyConstruction.InsertCommand.Connection = this._cn;
    companyConstruction.DeleteCommand.Connection = this._cn;
    companyConstruction.UpdateCommand.Connection = this._cn;
    this.daCompanyConstruction.SelectCommand.Parameters["@companyLineID"].Value = (object) this._companyLineID;
    DefaultDatabase.DataAdapterFill(this.daCompanyConstruction, (DataTable) this.ds.tblCompanyLineConstructionTypes);
  }

  private void frmCompanyConstructionTypes_Closing(object sender, CancelEventArgs e)
  {
    this.ug.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ug).ActiveRow != null)
      ((UltraGridBase) this.ug).ActiveRow.Update();
    ((UltraGridBase) this.ug).UpdateData();
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate(this.daCompanyConstruction, (DataTable) this.ds.tblCompanyLineConstructionTypes);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      if (MessageBox.Show("An error has occured.\n\nWould you like to close the form anyway?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
        e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void ug_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells[0].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ug_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyLineID"].Value = (object) this._companyLineID;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }
}
