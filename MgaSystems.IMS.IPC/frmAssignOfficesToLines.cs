// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmAssignOfficesToLines
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[SecureResource("{27F8D768-D1BD-4CA2-A6A9-0B0479BFE7CC}", "Assign Offices to Lines", "Controls the ability to assign office to a specific company/line setup.", "Company")]
public sealed class frmAssignOfficesToLines : Form
{
  private IContainer components;
  private DbConnection cnSQL;
  private DbDataAdapter daOfficeLines;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private dsOfficesAndLines ds;
  private Label Label1;
  private readonly Guid _companyLineGuid;
  private bool _loading;
  public const string AssignOfficesToLines = "{27F8D768-D1BD-4CA2-A6A9-0B0479BFE7CC}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnDSelectAll
  {
    get => this._btnDSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDSelectAll_Click);
      MGAButton btnDselectAll1 = this._btnDSelectAll;
      if (btnDselectAll1 != null)
        ((Control) btnDselectAll1).Click -= eventHandler;
      this._btnDSelectAll = value;
      MGAButton btnDselectAll2 = this._btnDSelectAll;
      if (btnDselectAll2 == null)
        return;
      ((Control) btnDselectAll2).Click += eventHandler;
    }
  }

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

  [field: AccessedThroughProperty("lblLineName")]
  private virtual Label lblLineName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckedListBox lstOffices
  {
    get => this._lstOffices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstOffices_ItemCheck);
      MGACheckedListBox lstOffices1 = this._lstOffices;
      if (lstOffices1 != null)
        lstOffices1.ItemCheck -= checkEventHandler;
      this._lstOffices = value;
      MGACheckedListBox lstOffices2 = this._lstOffices;
      if (lstOffices2 == null)
        return;
      lstOffices2.ItemCheck += checkEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAssignOfficesToLines));
    this.lblLineName = new Label();
    this.btnDSelectAll = new MGAButton();
    this.btnSelectAll = new MGAButton();
    this.lstOffices = new MGACheckedListBox();
    this.btnSave = new MGAButton();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.daOfficeLines = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.ds = new dsOfficesAndLines();
    this.Label1 = new Label();
    ((ISupportInitialize) this.btnDSelectAll).BeginInit();
    ((ISupportInitialize) this.btnSelectAll).BeginInit();
    ((ISupportInitialize) this.lstOffices).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lblLineName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblLineName.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblLineName.Location = new Point(8, 8);
    this.lblLineName.Name = "lblLineName";
    this.lblLineName.Size = new Size(256 /*0x0100*/, 32 /*0x20*/);
    this.lblLineName.TabIndex = 0;
    this.lblLineName.Text = "(Line Name)";
    this.lblLineName.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.btnDSelectAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.btnDSelectAll).Location = new Point(96 /*0x60*/, 304);
    ((Control) this.btnDSelectAll).Name = "btnDSelectAll";
    ((Control) this.btnDSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnDSelectAll).TabIndex = 10;
    ((ControlBase) this.btnDSelectAll).Text = "De-select All";
    this.btnDSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSelectAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.btnSelectAll).Location = new Point(8, 304);
    ((Control) this.btnSelectAll).Name = "btnSelectAll";
    ((Control) this.btnSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnSelectAll).TabIndex = 9;
    ((ControlBase) this.btnSelectAll).Text = "Select All";
    this.btnSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    this.lstOffices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstOffices.CheckOnClick = true;
    this.lstOffices.Location = new Point(8, 80 /*0x50*/);
    this.lstOffices.Name = "lstOffices";
    this.lstOffices.Size = new Size(256 /*0x0100*/, 210);
    this.lstOffices.TabIndex = 11;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnSave).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(224 /*0xE0*/, 304);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 12;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.daOfficeLines.DeleteCommand = this.DbDeleteCommand1;
    this.daOfficeLines.InsertCommand = this.DbInsertCommand1;
    this.daOfficeLines.SelectCommand = this.DbSelectCommand1;
    this.daOfficeLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblOfficeLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("OfficeGuid", "OfficeGuid")
      })
    });
    this.daOfficeLines.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblOfficeLines WHERE (CompanyLineGuid = @Original_companyLineGuid) AND (OfficeGuid = @Original_OfficeGuid)";
    this.DbDeleteCommand1.Connection = this.cnSQL;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeGuid", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnSQL;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGuid")
    });
    this.DbSelectCommand1.CommandText = "SELECT CompanyLineGuid, OfficeGuid FROM tblOfficeLines WHERE (CompanyLineGuid = @CompanyLineGuid)";
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGuid"),
      DefaultDatabase.CreateParameter("@Original_companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeGuid", DataRowVersion.Original, (object) null)
    });
    this.ds.DataSetName = "dsOfficesAndLines";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.Font = new Font("Tahoma", 7.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 48 /*0x30*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(256 /*0x0100*/, 32 /*0x20*/);
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Note: Only offices marked as billing offices will be shown in this list.";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(272, 349);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lstOffices);
    this.Controls.Add((Control) this.btnDSelectAll);
    this.Controls.Add((Control) this.btnSelectAll);
    this.Controls.Add((Control) this.lblLineName);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAssignOfficesToLines);
    this.Text = "Assign Offices";
    ((ISupportInitialize) this.btnDSelectAll).EndInit();
    ((ISupportInitialize) this.btnSelectAll).EndInit();
    ((ISupportInitialize) this.lstOffices).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmAssignOfficesToLines(Guid CompanyLineGuid)
  {
    this.Load += new EventHandler(this.frmAssignOfficesToLines_Load);
    this.Closing += new CancelEventHandler(this.frmAssignOfficesToLines_Closing);
    this.Paint += new PaintEventHandler(this.frmAssignOfficesToLines_Paint);
    this.InitializeComponent();
    this._companyLineGuid = CompanyLineGuid;
  }

  private void CheckOffSelectedCompanies()
  {
    this.lstOffices.ItemCheck -= new ItemCheckEventHandler(this.lstOffices_ItemCheck);
    try
    {
      foreach (dsOfficesAndLines.tblOfficeLinesRow tblOfficeLine in (TypedTableBase<dsOfficesAndLines.tblOfficeLinesRow>) this.ds.tblOfficeLines)
      {
        int index = 0;
        try
        {
          foreach (dsOfficesAndLines.tblClientOfficesRow tblClientOffice in (TypedTableBase<dsOfficesAndLines.tblClientOfficesRow>) this.ds.tblClientOffices)
          {
            if (tblClientOffice.OfficeGUID.Equals(tblOfficeLine.OfficeGuid))
              this.lstOffices.SetItemChecked(index, true);
            ++index;
          }
        }
        finally
        {
          IEnumerator<dsOfficesAndLines.tblClientOfficesRow> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<dsOfficesAndLines.tblOfficeLinesRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstOffices.ItemCheck += new ItemCheckEventHandler(this.lstOffices_ItemCheck);
  }

  private void Save()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    MDIControls.Instance.StatusBarText = "Saving Line Data...";
    try
    {
      DefaultDatabase.DataAdapterUpdate(this.daOfficeLines, (DataTable) this.ds.tblOfficeLines);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private void frmAssignOfficesToLines_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    MGACheckedListBox lstOffices = this.lstOffices;
    lstOffices.DataSource = (object) this.ds.tblClientOffices;
    lstOffices.DisplayMember = "Location";
    lstOffices.ValueMember = "OfficeGUID";
    this.lblLineName.Text = new CompanyLine(this._companyLineGuid).LineName;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblClientOffices"
    }, CommandType.Text, "SELECT OfficeGUID, Location FROM tblClientOffices WHERE (StatusID = 1) AND (AccountingOffice = 1) ORDER BY Location");
    this.daOfficeLines.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
    DefaultDatabase.DataAdapterFill(this.daOfficeLines, (DataTable) this.ds.tblOfficeLines);
  }

  private void lstOffices_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    if (e.CurrentValue == e.NewValue)
      return;
    Guid OfficeGuid = (Guid) ((DataRowView) this.lstOffices.Items[e.Index])["OfficeGuid"];
    if (e.CurrentValue == CheckState.Unchecked)
      this.ds.tblOfficeLines.AddtblOfficeLinesRow(OfficeGuid, this._companyLineGuid);
    else
      this.ds.tblOfficeLines.FindByOfficeGuidCompanyLineGuid(OfficeGuid, this._companyLineGuid).Delete();
    Cursor.Current = MgaCursors.Default;
  }

  private void btnDSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.ds.tblClientOffices.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (this.lstOffices.GetItemChecked(index))
        this.lstOffices.SetItemChecked(index, false);
    }
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.ds.tblClientOffices.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!this.lstOffices.GetItemChecked(index))
        this.lstOffices.SetItemChecked(index, true);
    }
  }

  private void frmAssignOfficesToLines_Closing(object sender, CancelEventArgs e)
  {
    if (!this.ds.HasChanges() || MessageBox.Show("Unsaved changes have been detected, would you like to save?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.Save();
  }

  private void frmAssignOfficesToLines_Paint(object sender, PaintEventArgs e)
  {
    if (this._loading)
      return;
    this._loading = true;
    this.CheckOffSelectedCompanies();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.Save();
    this.Close();
  }
}
