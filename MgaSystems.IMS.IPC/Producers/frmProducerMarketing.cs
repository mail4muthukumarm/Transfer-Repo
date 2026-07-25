// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducerMarketing
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

public sealed class frmProducerMarketing : Form
{
  private IContainer components;
  private dsProducerMarketing ds;
  private SqlDataAdapter daMarketing;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private Label lblProducer;
  private readonly Guid _producerGuid;
  private bool _loading;
  private readonly SqlConnection _cn;

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

  [field: AccessedThroughProperty("btnDeSelectAll")]
  private virtual MGAButton btnDeSelectAll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckedListBox lstCompanies
  {
    get => this._lstCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstCompanies_ItemCheck);
      MGACheckedListBox lstCompanies1 = this._lstCompanies;
      if (lstCompanies1 != null)
        lstCompanies1.ItemCheck -= checkEventHandler;
      this._lstCompanies = value;
      MGACheckedListBox lstCompanies2 = this._lstCompanies;
      if (lstCompanies2 == null)
        return;
      lstCompanies2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.btnSelectAll = new MGAButton();
    this.lstCompanies = new MGACheckedListBox();
    this.ds = new dsProducerMarketing();
    this.lblProducer = new Label();
    this.btnDeSelectAll = new MGAButton();
    this.daMarketing = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    ((ISupportInitialize) this.btnSelectAll).BeginInit();
    ((ISupportInitialize) this.lstCompanies).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnDeSelectAll).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelectAll).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSelectAll).Location = new Point(44, 259);
    ((Control) this.btnSelectAll).Name = "btnSelectAll";
    ((Control) this.btnSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnSelectAll).TabIndex = 14;
    ((ControlBase) this.btnSelectAll).Text = "Select All";
    this.btnSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    this.lstCompanies.BackColor = Color.White;
    this.lstCompanies.CheckOnClick = true;
    this.lstCompanies.DataSource = (object) this.ds.tblCompanies;
    this.lstCompanies.DisplayMember = "CompanyName";
    this.lstCompanies.ForeColor = Color.Black;
    this.lstCompanies.Location = new Point(7, 35);
    this.lstCompanies.Name = "lstCompanies";
    this.lstCompanies.Size = new Size(245, 196);
    this.lstCompanies.TabIndex = 13;
    this.lstCompanies.ValueMember = "CompanyGuid";
    this.ds.DataSetName = "dsProducerMarketing";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblProducer.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblProducer.Location = new Point(14, 7);
    this.lblProducer.Name = "lblProducer";
    this.lblProducer.Size = new Size(238, 23);
    this.lblProducer.TabIndex = 16 /*0x10*/;
    this.lblProducer.Text = "(producer)";
    this.lblProducer.TextAlign = ContentAlignment.MiddleCenter;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDeSelectAll).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnDeSelectAll).Location = new Point(135, 259);
    ((Control) this.btnDeSelectAll).Name = "btnDeSelectAll";
    ((Control) this.btnDeSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnDeSelectAll).TabIndex = 15;
    ((ControlBase) this.btnDeSelectAll).Text = "De-select All";
    this.btnDeSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    this.daMarketing.DeleteCommand = this.SqlDeleteCommand1;
    this.daMarketing.InsertCommand = this.SqlInsertCommand1;
    this.daMarketing.SelectCommand = this.SqlSelectCommand2;
    this.daMarketing.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerMarketing", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerGuid", "ProducerGuid"),
        new DataColumnMapping("CompanyGuid", "CompanyGuid")
      })
    });
    this.daMarketing.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblProducerMarketing WHERE (CompanyGuid = @Original_CompanyGuid) AND (ProducerGuid = @Original_ProducerGuid)";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGuid", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblProducerMarketing(ProducerGuid, CompanyGuid) VALUES (@ProducerGuid, @CompanyGuid)";
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGuid"),
      new SqlParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGuid")
    });
    this.SqlSelectCommand2.CommandText = "SELECT ProducerGuid, CompanyGuid FROM tblProducerMarketing WHERE (ProducerGuid = @ProducerGuid)";
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGuid")
    });
    this.SqlUpdateCommand1.CommandText = "UPDATE tblProducerMarketing SET ProducerGuid = @ProducerGuid, CompanyGuid = @CompanyGuid WHERE (CompanyGuid = @Original_CompanyGuid) AND (ProducerGuid = @Original_ProducerGuid)";
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerGuid"),
      new SqlParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGuid"),
      new SqlParameter("@Original_CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGuid", DataRowVersion.Original, (object) null)
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(258, 288);
    this.Controls.Add((Control) this.lblProducer);
    this.Controls.Add((Control) this.btnDeSelectAll);
    this.Controls.Add((Control) this.btnSelectAll);
    this.Controls.Add((Control) this.lstCompanies);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmProducerMarketing);
    this.Text = "Producer Marketing";
    ((ISupportInitialize) this.btnSelectAll).EndInit();
    ((ISupportInitialize) this.lstCompanies).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnDeSelectAll).EndInit();
    this.ResumeLayout(false);
  }

  public frmProducerMarketing(Guid ProducerGuid)
  {
    this.Load += new EventHandler(this.frmProducerMarketing_Load);
    this.Closing += new CancelEventHandler(this.frmProducerMarketing_Closing);
    this.Paint += new PaintEventHandler(this.frmProducerMarketing_Paint);
    this.InitializeComponent();
    this._producerGuid = ProducerGuid;
    this._cn = DefaultDatabase.CreateConnection();
  }

  private void frmProducerMarketing_Load(object sender, EventArgs e)
  {
    SqlDataAdapter daMarketing = this.daMarketing;
    daMarketing.SelectCommand.Connection = this._cn;
    daMarketing.InsertCommand.Connection = this._cn;
    daMarketing.DeleteCommand.Connection = this._cn;
    daMarketing.UpdateCommand.Connection = this._cn;
    this.lblProducer.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ProducerName FROM tblProducers WHERE ProducerGuid=@ProducerGuid", new object[2]
    {
      (object) "@ProducerGuid",
      (object) this._producerGuid
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblCompanies"
    }, CommandType.Text, "SELECT CompanyGUID, CompanyName FROM tblCompanies ORDER BY CompanyName");
    this.daMarketing.SelectCommand.Parameters["@ProducerGuid"].Value = (object) this._producerGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daMarketing, (DataTable) this.ds.tblProducerMarketing);
  }

  private void frmProducerMarketing_Closing(object sender, CancelEventArgs e)
  {
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daMarketing, (DataTable) this.ds.tblProducerMarketing);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      if (MessageBox.Show("An error occured when trying to save this information.\n\nWould you like to close the form anyway?", "Close Form?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
        e.Cancel = true;
      ProjectData.ClearProjectError();
    }
  }

  private void lstCompanies_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    if (e.CurrentValue == e.NewValue)
      return;
    Guid companyGuid = ((dsProducerMarketing.tblCompaniesRow) ((DataRowView) this.lstCompanies.Items[e.Index]).Row).CompanyGUID;
    if (e.CurrentValue == CheckState.Unchecked)
    {
      dsProducerMarketing.tblProducerMarketingRow row = this.ds.tblProducerMarketing.NewtblProducerMarketingRow();
      row.CompanyGuid = companyGuid;
      row.ProducerGuid = this._producerGuid;
      this.ds.tblProducerMarketing.AddtblProducerMarketingRow(row);
    }
    else
      this.ds.tblProducerMarketing.FindByProducerGuidCompanyGuid(this._producerGuid, companyGuid).Delete();
    Cursor.Current = MgaCursors.Default;
  }

  private void FillListBox()
  {
    this.lstCompanies.ItemCheck -= new ItemCheckEventHandler(this.lstCompanies_ItemCheck);
    try
    {
      foreach (dsProducerMarketing.tblProducerMarketingRow producerMarketingRow in (TypedTableBase<dsProducerMarketing.tblProducerMarketingRow>) this.ds.tblProducerMarketing)
      {
        int num = this.lstCompanies.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (producerMarketingRow.CompanyGuid.Equals(((dsProducerMarketing.tblCompaniesRow) ((DataRowView) this.lstCompanies.Items[index]).Row).CompanyGUID))
            this.lstCompanies.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator<dsProducerMarketing.tblProducerMarketingRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstCompanies.ItemCheck += new ItemCheckEventHandler(this.lstCompanies_ItemCheck);
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.lstCompanies.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!this.lstCompanies.CheckedIndices.Contains(index))
        this.lstCompanies.SetItemChecked(index, true);
    }
  }

  private void frmProducerMarketing_Paint(object sender, PaintEventArgs e)
  {
    if (this._loading)
      return;
    this._loading = true;
    this.FillListBox();
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
