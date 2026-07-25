// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyRaters
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{DC60B27B-78EC-4c89-9750-FAC8B385565A}", "Access Company Raters Screen", "Controls access to the Company Raters screen.", "Companies")]
public sealed class frmCompanyRaters : Form
{
  private IContainer components;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cnSQL;
  private dsCompanyRaters ds;
  private Label CompanyLineStateLabel1;
  public const string OpenForm = "{DC60B27B-78EC-4c89-9750-FAC8B385565A}";
  private Guid _companyLineGuid;
  private bool _Loading;
  private readonly DbConnection _cn;

  private virtual MGAButton btnSelectAll
  {
    get => this._btnSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectAll_Click);
      MGAButton btnSelectAll1 = this._btnSelectAll;
      if (btnSelectAll1 != null)
        ((Control) btnSelectAll1).Click -= eventHandler;
      this._btnSelectAll = value;
      MGAButton btnSelectAll2 = this._btnSelectAll;
      if (btnSelectAll2 == null)
        return;
      ((Control) btnSelectAll2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("daCompanyRaters")]
  private virtual SqlDataAdapter daCompanyRaters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckedListBox lstRaters
  {
    get => this._lstRaters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstRaters_ItemCheck);
      MGACheckedListBox lstRaters1 = this._lstRaters;
      if (lstRaters1 != null)
        lstRaters1.ItemCheck -= checkEventHandler;
      this._lstRaters = value;
      MGACheckedListBox lstRaters2 = this._lstRaters;
      if (lstRaters2 == null)
        return;
      lstRaters2.ItemCheck += checkEventHandler;
    }
  }

  private virtual MGAButton btnDeSelectAll
  {
    get => this._btnDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDeSelectAll_Click);
      MGAButton btnDeSelectAll1 = this._btnDeSelectAll;
      if (btnDeSelectAll1 != null)
        ((Control) btnDeSelectAll1).Click -= eventHandler;
      this._btnDeSelectAll = value;
      MGAButton btnDeSelectAll2 = this._btnDeSelectAll;
      if (btnDeSelectAll2 == null)
        return;
      ((Control) btnDeSelectAll2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.btnDeSelectAll = new MGAButton();
    this.btnSelectAll = new MGAButton();
    this.lstRaters = new MGACheckedListBox();
    this.ds = new dsCompanyRaters();
    this.daCompanyRaters = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.CompanyLineStateLabel1 = new Label();
    ((ISupportInitialize) this.btnDeSelectAll).BeginInit();
    ((ISupportInitialize) this.btnSelectAll).BeginInit();
    ((ISupportInitialize) this.lstRaters).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnDeSelectAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.btnDeSelectAll).Location = new Point(135, 259);
    ((Control) this.btnDeSelectAll).Name = "btnDeSelectAll";
    ((Control) this.btnDeSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnDeSelectAll).TabIndex = 11;
    ((ControlBase) this.btnDeSelectAll).Text = "De-select All";
    this.btnDeSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSelectAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.btnSelectAll).Location = new Point(44, 259);
    ((Control) this.btnSelectAll).Name = "btnSelectAll";
    ((Control) this.btnSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnSelectAll).TabIndex = 10;
    ((ControlBase) this.btnSelectAll).Text = "Select All";
    this.btnSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    this.lstRaters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstRaters.CheckOnClick = true;
    this.lstRaters.DataSource = (object) this.ds.lstRatingTypes;
    this.lstRaters.DisplayMember = "RatingType";
    this.lstRaters.Location = new Point(7, 35);
    this.lstRaters.Name = "lstRaters";
    this.lstRaters.Size = new Size(245, 210);
    this.lstRaters.TabIndex = 9;
    this.lstRaters.ValueMember = "RatingTypeID";
    this.ds.DataSetName = "dsCompanyRaters";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daCompanyRaters.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanyRaters.InsertCommand = this.SqlInsertCommand1;
    this.daCompanyRaters.SelectCommand = this.SqlSelectCommand1;
    this.daCompanyRaters.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyRaters", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("RatingTypeID", "RatingTypeID")
      })
    });
    this.daCompanyRaters.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblCompanyRaters WHERE (CompanyLineGuid = @Original_companyLineGuid) AND (RatingTypeID = @Original_RatingTypeID)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_RatingTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RatingTypeID", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;user id=mgasystems;data source=\"10.0.0.3\";persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblCompanyRaters(CompanyLineGuid, RatingTypeID) VALUES (@CompanyLineGuid, @RatingTypeID)";
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@RatingTypeID", SqlDbType.Int, 4, "RatingTypeID")
    });
    this.SqlSelectCommand1.CommandText = "SELECT CompanyLineGuid, RatingTypeID FROM tblCompanyRaters WHERE CompanyLineGuid=@CompanyLineGuid";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    this.SqlUpdateCommand1.CommandText = "UPDATE tblCompanyRaters SET CompanyLineGuid = @CompanyLineGuid, RatingTypeID = @RatingTypeID WHERE (CompanyLineGuid = @Original_companyLineGuid) AND (RatingTypeID = @Original_RatingTypeID)";
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@RatingTypeID", SqlDbType.Int, 4, "RatingTypeID"),
      new SqlParameter("@Original_companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_RatingTypeID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RatingTypeID", DataRowVersion.Original, (object) null)
    });
    this.CompanyLineStateLabel1.Location = new Point(14, 7);
    this.CompanyLineStateLabel1.Name = "CompanyLineStateLabel1";
    this.CompanyLineStateLabel1.Size = new Size(238, 23);
    this.CompanyLineStateLabel1.TabIndex = 12;
    this.CompanyLineStateLabel1.Text = "(company line state)";
    this.CompanyLineStateLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(258, 288);
    this.Controls.Add((Control) this.CompanyLineStateLabel1);
    this.Controls.Add((Control) this.btnDeSelectAll);
    this.Controls.Add((Control) this.btnSelectAll);
    this.Controls.Add((Control) this.lstRaters);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmCompanyRaters);
    this.Text = "Company Raters";
    ((ISupportInitialize) this.btnDeSelectAll).EndInit();
    ((ISupportInitialize) this.btnSelectAll).EndInit();
    ((ISupportInitialize) this.lstRaters).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyRaters(Guid CompanyLineGuid)
  {
    this.Load += new EventHandler(this.frmCompanyRaters_Load);
    this.Closing += new CancelEventHandler(this.frmCompanyRaters_Closing);
    this.Paint += new PaintEventHandler(this.frmCompanyRaters_Paint);
    this.InitializeComponent();
    this._companyLineGuid = CompanyLineGuid;
    this._cn = (DbConnection) DefaultDatabase.CreateConnection();
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

  private void frmCompanyRaters_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daCompanyRaters, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.CompanyLineStateLabel1.Text = new CompanyLine(this._companyLineGuid).CompanyLineState;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstRatingTypes"
    }, CommandType.Text, "SELECT RatingTypeID, RatingType FROM lstRatingTypes ORDER BY RatingType");
    this.daCompanyRaters.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyRaters, (DataTable) this.ds.tblCompanyRaters);
    RaterManagerBase.RefreshAvailableRatersList();
  }

  private void frmCompanyRaters_Closing(object sender, CancelEventArgs e)
  {
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanyRaters, (DataTable) this.ds.tblCompanyRaters);
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (!ex2.Message.Contains("Violation of PRIMARY KEY constraint 'PK_tblCompanyRaters'"))
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
  }

  private void btnDeSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.lstRaters.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (this.lstRaters.CheckedIndices.Contains(index))
        this.lstRaters.SetItemChecked(index, false);
    }
  }

  private void lstRaters_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    if (e.CurrentValue == e.NewValue)
      return;
    int ratingTypeId = ((dsCompanyRaters.lstRatingTypesRow) ((DataRowView) this.lstRaters.Items[e.Index]).Row).RatingTypeID;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsCompanyRaters.tblCompanyRatersRow row = this.ds.tblCompanyRaters.NewtblCompanyRatersRow();
      row.RatingTypeID = ratingTypeId;
      row.CompanyLineGuid = this._companyLineGuid;
      this.ds.tblCompanyRaters.AddtblCompanyRatersRow(row);
    }
    else
      this.ds.tblCompanyRaters.Select("RatingTypeID=" + ratingTypeId.ToString())[0].Delete();
    Cursor.Current = MgaCursors.Default;
  }

  private void FillListBox()
  {
    this.lstRaters.ItemCheck -= new ItemCheckEventHandler(this.lstRaters_ItemCheck);
    try
    {
      foreach (dsCompanyRaters.tblCompanyRatersRow tblCompanyRater in (TypedTableBase<dsCompanyRaters.tblCompanyRatersRow>) this.ds.tblCompanyRaters)
      {
        int num = this.lstRaters.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (tblCompanyRater.RatingTypeID.Equals(((dsCompanyRaters.lstRatingTypesRow) ((DataRowView) this.lstRaters.Items[index]).Row).RatingTypeID))
            this.lstRaters.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator<dsCompanyRaters.tblCompanyRatersRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstRaters.ItemCheck += new ItemCheckEventHandler(this.lstRaters_ItemCheck);
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.lstRaters.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!this.lstRaters.CheckedIndices.Contains(index))
        this.lstRaters.SetItemChecked(index, true);
    }
  }

  private void frmCompanyRaters_Paint(object sender, PaintEventArgs e)
  {
    if (this._Loading)
      return;
    this._Loading = true;
    this.FillListBox();
  }
}
