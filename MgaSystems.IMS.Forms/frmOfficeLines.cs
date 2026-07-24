// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmOfficeLines
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[SecureResource("{3BC16F12-B221-45cf-ABC2-D2C0016324D2}", "Access Office Lines Screen", "Controls access to the Office Lines screen.", "Offices")]
public sealed class frmOfficeLines : Form
{
  private IContainer components;
  private Label lblLocationName;
  private SqlDataAdapter daSelectedLines;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private readonly Guid _officeGUID;
  internal const string OpenForm = "{3BC16F12-B221-45cf-ABC2-D2C0016324D2}";

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

  private virtual MGACheckedListBox lstLines
  {
    get => this._lstLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstLines_ItemCheck);
      MGACheckedListBox lstLines1 = this._lstLines;
      if (lstLines1 != null)
        lstLines1.ItemCheck -= checkEventHandler;
      this._lstLines = value;
      MGACheckedListBox lstLines2 = this._lstLines;
      if (lstLines2 == null)
        return;
      lstLines2.ItemCheck += checkEventHandler;
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
  private virtual dsCompanyLineList ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraProgressBar1")]
  internal virtual UltraProgressBar UltraProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmOfficeLines));
    Appearance appearance3 = new Appearance();
    this.lblLocationName = new Label();
    this.btnDSelectAll = new MGAButton();
    this.btnSelectAll = new MGAButton();
    this.lstLines = new MGACheckedListBox();
    this.daSelectedLines = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.btnSave = new MGAButton();
    this.ds = new dsCompanyLineList();
    this.UltraProgressBar1 = new UltraProgressBar();
    ((ISupportInitialize) this.btnDSelectAll).BeginInit();
    ((ISupportInitialize) this.btnSelectAll).BeginInit();
    ((ISupportInitialize) this.lstLines).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lblLocationName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblLocationName.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblLocationName.Location = new Point(8, 8);
    this.lblLocationName.Name = "lblLocationName";
    this.lblLocationName.Size = new Size(256 /*0x0100*/, 32 /*0x20*/);
    this.lblLocationName.TabIndex = 0;
    this.lblLocationName.Text = "(Location)";
    this.lblLocationName.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.btnDSelectAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDSelectAll).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnDSelectAll).Enabled = false;
    ((Control) this.btnDSelectAll).Location = new Point(96 /*0x60*/, 304);
    ((Control) this.btnDSelectAll).Name = "btnDSelectAll";
    ((Control) this.btnDSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnDSelectAll).TabIndex = 10;
    ((ControlBase) this.btnDSelectAll).Text = "De-select All";
    this.btnDSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSelectAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelectAll).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnSelectAll).Enabled = false;
    ((Control) this.btnSelectAll).Location = new Point(8, 304);
    ((Control) this.btnSelectAll).Name = "btnSelectAll";
    ((Control) this.btnSelectAll).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnSelectAll).TabIndex = 9;
    ((ControlBase) this.btnSelectAll).Text = "Select All";
    this.btnSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    this.lstLines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstLines.CheckOnClick = true;
    this.lstLines.Location = new Point(8, 48 /*0x30*/);
    this.lstLines.Name = "lstLines";
    this.lstLines.Size = new Size(256 /*0x0100*/, 212);
    this.lstLines.TabIndex = 11;
    this.daSelectedLines.DeleteCommand = this.SqlDeleteCommand1;
    this.daSelectedLines.InsertCommand = this.SqlInsertCommand1;
    this.daSelectedLines.SelectCommand = this.SqlSelectCommand2;
    this.daSelectedLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblOfficeLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeGuid", "OfficeGuid"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid")
      })
    });
    this.daSelectedLines.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblOfficeLines WHERE (CompanyLineGuid = @Original_CompanyLineGuid) AND (OfficeGuid = @Original_OfficeGuid)";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeGuid", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGuid"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    this.SqlSelectCommand2.CommandText = "SELECT OfficeGuid, CompanyLineGuid FROM tblOfficeLines WHERE OfficeGuid = @OfficeGuid";
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGuid"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "OfficeGuid", DataRowVersion.Original, (object) null)
    });
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSave).Enabled = false;
    ((Control) this.btnSave).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(224 /*0xE0*/, 304);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 12;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineList";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraProgressBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraProgressBar1).Location = new Point(8, 280);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(256 /*0x0100*/, 16 /*0x10*/);
    ((Control) this.UltraProgressBar1).TabIndex = 13;
    this.UltraProgressBar1.Text = "[Formatted]";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(272, 349);
    this.Controls.Add((Control) this.UltraProgressBar1);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lstLines);
    this.Controls.Add((Control) this.btnDSelectAll);
    this.Controls.Add((Control) this.btnSelectAll);
    this.Controls.Add((Control) this.lblLocationName);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmOfficeLines);
    this.Text = "Assign Company Lines";
    ((ISupportInitialize) this.btnDSelectAll).EndInit();
    ((ISupportInitialize) this.btnSelectAll).EndInit();
    ((ISupportInitialize) this.lstLines).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmOfficeLines(Guid officeGUID)
  {
    this.Load += new EventHandler(this.frmAssignLines_Load);
    this.Closing += new CancelEventHandler(this.frmAssignLines_Closing);
    this.InitializeComponent();
    this._officeGUID = officeGUID;
    this.lstLines.Enabled = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void frmAssignLines_Load(object sender, EventArgs e)
  {
    SqlDataAdapter daSelectedLines = this.daSelectedLines;
    if (daSelectedLines.SelectCommand == null)
      daSelectedLines.SelectCommand = new SqlCommand();
    if (daSelectedLines.UpdateCommand == null)
      daSelectedLines.UpdateCommand = new SqlCommand();
    if (daSelectedLines.InsertCommand == null)
      daSelectedLines.InsertCommand = new SqlCommand();
    if (daSelectedLines.DeleteCommand == null)
      daSelectedLines.DeleteCommand = new SqlCommand();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.daSelectedLines, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    this.UltraProgressBar1.Maximum = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblCompanyLines");
    this.lstLines.BeginUpdate();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
    this.lblLocationName.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Location FROM tblClientOffices WITH (NOLOCK) WHERE OfficeGUID= @OG", new object[2]
    {
      (object) "@OG",
      (object) this._officeGUID
    });
  }

  private void ThreadedFill(object state)
  {
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (s, nodeReader) =>
    {
      while (nodeReader.Reader.Read())
        MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmOfficeLines.AddLineHandler(this.AddLine), nodeReader.Reader[0], nodeReader.Reader[1]);
    }), CommandType.Text, "SELECT CompanyLineGUID, dbo.GetCompanyLineState(CompanyLineGUID) AS LineName FROM tblCompanyLines ORDER BY dbo.GetCompanyLineState(CompanyLineGUID)");
    this.daSelectedLines.SelectCommand.Parameters["@OfficeGuid"].Value = (object) this._officeGUID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daSelectedLines, (DataTable) this.ds.tblOfficeLines);
    MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.LoadComplete));
  }

  private void AddLine(Guid companyLineGuid, string companyLineState)
  {
    this.ds.lstLines.AddlstLinesRow(companyLineState, companyLineGuid);
    UltraProgressBar ultraProgressBar1;
    int num = (ultraProgressBar1 = this.UltraProgressBar1).Value + 1;
    ultraProgressBar1.Value = num;
    ((UltraControlBase) this.UltraProgressBar1).Refresh();
  }

  private void FillCompanyLines()
  {
    this.lstLines.ItemCheck -= new ItemCheckEventHandler(this.lstLines_ItemCheck);
    try
    {
      foreach (dsCompanyLineList.tblOfficeLinesRow tblOfficeLine in (TypedTableBase<dsCompanyLineList.tblOfficeLinesRow>) this.ds.tblOfficeLines)
      {
        int index = 0;
        try
        {
          foreach (dsCompanyLineList.lstLinesRow lstLine in (TypedTableBase<dsCompanyLineList.lstLinesRow>) this.ds.lstLines)
          {
            if (tblOfficeLine.CompanyLineGuid.Equals(lstLine.CompanyLineGuid))
              this.lstLines.SetItemChecked(index, true);
            ++index;
          }
        }
        finally
        {
          IEnumerator<dsCompanyLineList.lstLinesRow> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<dsCompanyLineList.tblOfficeLinesRow> enumerator;
      enumerator?.Dispose();
    }
    this.lstLines.ItemCheck += new ItemCheckEventHandler(this.lstLines_ItemCheck);
  }

  private void LoadComplete()
  {
    MGACheckedListBox lstLines = this.lstLines;
    lstLines.DataSource = (object) this.ds.lstLines;
    lstLines.DisplayMember = "LineName";
    lstLines.ValueMember = "CompanyLineGuid";
    this.lstLines.EndUpdate();
    this.FillCompanyLines();
    this.lstLines.Enabled = true;
    this.UltraProgressBar1.Value = 0;
    try
    {
      foreach (Control control in this.Controls)
        control.Enabled = true;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void frmAssignLines_Closing(object sender, CancelEventArgs e)
  {
    if (!this.ds.HasChanges() || MessageBox.Show("Unsaved changes have been detected, would you like to save?", "Would you like to save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.SaveLines();
  }

  private void btnDSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.ds.lstLines.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (this.lstLines.GetItemChecked(index))
        this.lstLines.SetItemChecked(index, false);
    }
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = this.ds.lstLines.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!this.lstLines.GetItemChecked(index))
        this.lstLines.SetItemChecked(index, true);
    }
  }

  private void lstLines_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (e.CurrentValue == e.NewValue)
      return;
    Guid CompanyLineGuid = (Guid) ((DataRowView) this.lstLines.Items[e.Index])["CompanyLineGuid"];
    if (e.CurrentValue == CheckState.Unchecked)
      this.ds.tblOfficeLines.AddtblOfficeLinesRow(this._officeGUID, CompanyLineGuid);
    else
      this.ds.tblOfficeLines.FindByCompanyLineGuid(CompanyLineGuid).Delete();
    Cursor.Current = Cursors.Default;
  }

  private bool SaveLines()
  {
    Cursor.Current = Cursors.WaitCursor;
    MDIControls.Instance.StatusBarText = "Saving office lines...";
    bool flag;
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSelectedLines, (DataTable) this.ds.tblOfficeLines);
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.SaveLines())
      return;
    this.Close();
  }

  private delegate void AddLineHandler(Guid companyLineGuid, string companyLineState);
}
