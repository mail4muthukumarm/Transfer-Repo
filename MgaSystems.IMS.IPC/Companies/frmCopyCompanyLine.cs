// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCopyCompanyLine
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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

public class frmCopyCompanyLine : Form
{
  private IContainer components;
  private UltraLabel lblCLS;
  private MGACheckedListBox lstStates;
  private Label Label1;
  private DbConnection cnSQL;
  private UltraProgressBar UltraProgressBar1;
  private string _displayMember;
  private string _valueMember;
  private Guid _companyLineGuid;
  private string _sourceStateID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstLines")]
  internal virtual MGACheckedListBox lstLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyCompanyLine ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  internal virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  internal virtual DbDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSelectStates
  {
    get => this._lnkSelectStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectStates_LinkClicked);
      LinkLabel lnkSelectStates1 = this._lnkSelectStates;
      if (lnkSelectStates1 != null)
        lnkSelectStates1.LinkClicked -= clickedEventHandler;
      this._lnkSelectStates = value;
      LinkLabel lnkSelectStates2 = this._lnkSelectStates;
      if (lnkSelectStates2 == null)
        return;
      lnkSelectStates2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeselectStates
  {
    get => this._lnkDeselectStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectStates_LinkClicked);
      LinkLabel lnkDeselectStates1 = this._lnkDeselectStates;
      if (lnkDeselectStates1 != null)
        lnkDeselectStates1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectStates = value;
      LinkLabel lnkDeselectStates2 = this._lnkDeselectStates;
      if (lnkDeselectStates2 == null)
        return;
      lnkDeselectStates2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeselectAllLines
  {
    get => this._lnkDeselectAllLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectAllLines_LinkClicked);
      LinkLabel deselectAllLines1 = this._lnkDeselectAllLines;
      if (deselectAllLines1 != null)
        deselectAllLines1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectAllLines = value;
      LinkLabel deselectAllLines2 = this._lnkDeselectAllLines;
      if (deselectAllLines2 == null)
        return;
      deselectAllLines2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectUSStatesOnly
  {
    get => this._lnkSelectUSStatesOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectUSStatesOnly_LinkClicked);
      LinkLabel selectUsStatesOnly1 = this._lnkSelectUSStatesOnly;
      if (selectUsStatesOnly1 != null)
        selectUsStatesOnly1.LinkClicked -= clickedEventHandler;
      this._lnkSelectUSStatesOnly = value;
      LinkLabel selectUsStatesOnly2 = this._lnkSelectUSStatesOnly;
      if (selectUsStatesOnly2 == null)
        return;
      selectUsStatesOnly2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAllLines
  {
    get => this._lnkSelectAllLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllLines_LinkClicked);
      LinkLabel lnkSelectAllLines1 = this._lnkSelectAllLines;
      if (lnkSelectAllLines1 != null)
        lnkSelectAllLines1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllLines = value;
      LinkLabel lnkSelectAllLines2 = this._lnkSelectAllLines;
      if (lnkSelectAllLines2 == null)
        return;
      lnkSelectAllLines2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.lblCLS = new UltraLabel();
    this.lstStates = new MGACheckedListBox();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.Label1 = new Label();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.UltraProgressBar1 = new UltraProgressBar();
    this.Label2 = new Label();
    this.lstLines = new MGACheckedListBox();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.lnkSelectStates = new LinkLabel();
    this.lnkDeselectStates = new LinkLabel();
    this.lnkDeselectAllLines = new LinkLabel();
    this.lnkSelectAllLines = new LinkLabel();
    this.lnkSelectUSStatesOnly = new LinkLabel();
    this.ds = new dsCopyCompanyLine();
    ((ISupportInitialize) this.lstStates).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.lstLines).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.lblCLS).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.Gray;
    appearance1.FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance1).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblCLS).Appearance = (AppearanceBase) appearance1;
    this.lblCLS.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblCLS).Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblCLS).Location = new Point(10, 7);
    ((Control) this.lblCLS).Name = "lblCLS";
    ((Control) this.lblCLS).Size = new Size(427, 35);
    ((Control) this.lblCLS).TabIndex = 0;
    ((ControlBase) this.lblCLS).Text = "Company Line Goes Here";
    ((ControlBase) this.lblCLS).WrapText = false;
    this.lstStates.CheckOnClick = true;
    this.lstStates.Location = new Point(10, 77);
    this.lstStates.Name = "lstStates";
    this.lstStates.Size = new Size(427, 100);
    this.lstStates.TabIndex = 1;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(346, 429);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 2;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(395, 429);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 3;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(10, 49);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(378, 23);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Please select the states you would like to copy this company/line setup to:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.UltraProgressBar1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.Gray;
    this.UltraProgressBar1.Appearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.MidnightBlue;
    this.UltraProgressBar1.FillAppearance = (AppearanceBase) appearance5;
    ((Control) this.UltraProgressBar1).Location = new Point(10, 401);
    ((Control) this.UltraProgressBar1).Name = "UltraProgressBar1";
    ((Control) this.UltraProgressBar1).Size = new Size(427, 14);
    this.UltraProgressBar1.Style = (ProgressBarStyle) 2;
    ((Control) this.UltraProgressBar1).TabIndex = 7;
    this.UltraProgressBar1.Text = "[Formatted]";
    ((UltraControlBase) this.UltraProgressBar1).UseFlatMode = (DefaultableBoolean) 1;
    this.UltraProgressBar1.Value = 75;
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label2.Location = new Point(10, 224 /*0xE0*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(382, 23);
    this.Label2.TabIndex = 9;
    this.Label2.Text = "Please select the lines you would like to copy this company/line setup to:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.lstLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstLines.CheckOnClick = true;
    this.lstLines.Location = new Point(10, 252);
    this.lstLines.Name = "lstLines";
    this.lstLines.Size = new Size(427, 100);
    this.lstLines.TabIndex = 8;
    this.da.SelectCommand = this.DbSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table1", "lstLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName")
      })
    });
    this.DbSelectCommand1.CommandText = "[spGetCopyCompanyLineData]";
    this.DbSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.lnkSelectStates.AutoSize = true;
    this.lnkSelectStates.Location = new Point(10, 203);
    this.lnkSelectStates.Name = "lnkSelectStates";
    this.lnkSelectStates.Size = new Size(84, 13);
    this.lnkSelectStates.TabIndex = 10;
    this.lnkSelectStates.TabStop = true;
    this.lnkSelectStates.Text = "Select All States";
    this.lnkDeselectStates.AutoSize = true;
    this.lnkDeselectStates.Location = new Point(312, 203);
    this.lnkDeselectStates.Name = "lnkDeselectStates";
    this.lnkDeselectStates.Size = new Size(100, 13);
    this.lnkDeselectStates.TabIndex = 11;
    this.lnkDeselectStates.TabStop = true;
    this.lnkDeselectStates.Text = "De-select All States";
    this.lnkDeselectAllLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAllLines.AutoSize = true;
    this.lnkDeselectAllLines.Location = new Point(105, 378);
    this.lnkDeselectAllLines.Name = "lnkDeselectAllLines";
    this.lnkDeselectAllLines.Size = new Size(93, 13);
    this.lnkDeselectAllLines.TabIndex = 13;
    this.lnkDeselectAllLines.TabStop = true;
    this.lnkDeselectAllLines.Text = "De-select All Lines";
    this.lnkSelectAllLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllLines.AutoSize = true;
    this.lnkSelectAllLines.Location = new Point(10, 378);
    this.lnkSelectAllLines.Name = "lnkSelectAllLines";
    this.lnkSelectAllLines.Size = new Size(77, 13);
    this.lnkSelectAllLines.TabIndex = 12;
    this.lnkSelectAllLines.TabStop = true;
    this.lnkSelectAllLines.Text = "Select All Lines";
    this.lnkSelectUSStatesOnly.AutoSize = true;
    this.lnkSelectUSStatesOnly.Location = new Point(172, 203);
    this.lnkSelectUSStatesOnly.Name = "lnkSelectUSStatesOnly";
    this.lnkSelectUSStatesOnly.Size = new Size(103, 13);
    this.lnkSelectUSStatesOnly.TabIndex = 14;
    this.lnkSelectUSStatesOnly.TabStop = true;
    this.lnkSelectUSStatesOnly.Text = "Select All  US States";
    this.ds.DataSetName = "dsCopyCompanyLine";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(447, 479);
    this.Controls.Add((Control) this.lnkSelectUSStatesOnly);
    this.Controls.Add((Control) this.lnkDeselectAllLines);
    this.Controls.Add((Control) this.lnkSelectAllLines);
    this.Controls.Add((Control) this.lnkDeselectStates);
    this.Controls.Add((Control) this.lnkSelectStates);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lstLines);
    this.Controls.Add((Control) this.UltraProgressBar1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lstStates);
    this.Controls.Add((Control) this.lblCLS);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCopyCompanyLine);
    this.Text = "Copy Company/Line Setup";
    ((ISupportInitialize) this.lstStates).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.lstLines).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [Browsable(true)]
  protected string DisplayMember
  {
    get => this._displayMember;
    set => this._displayMember = value;
  }

  [Browsable(true)]
  protected string ValueMember
  {
    get => this._valueMember;
    set => this._valueMember = value;
  }

  public frmCopyCompanyLine(Guid CompanyLineGuid)
  {
    this.Load += new EventHandler(this.frmCopyCompanyLine_Load);
    this._displayMember = "State";
    this._valueMember = "StateID";
    this.InitializeComponent();
    this._companyLineGuid = CompanyLineGuid;
  }

  private void frmCopyCompanyLine_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this.UltraProgressBar1.Value = 0;
    ((ControlBase) this.lblCLS).Text = new CompanyLine(this._companyLineGuid).CompanyLineState;
    this.da.SelectCommand.Parameters["@companyLineGuid"].Value = (object) this._companyLineGuid;
    DefaultDatabase.DataAdapterFill(this.da, (DataSet) this.ds);
    MGACheckedListBox lstStates = this.lstStates;
    lstStates.DataSource = (object) this.ds.lstStates;
    lstStates.DisplayMember = "State";
    lstStates.ValueMember = "StateID";
    MGACheckedListBox lstLines = this.lstLines;
    lstLines.DataSource = (object) this.ds.lstLines;
    lstLines.DisplayMember = "LineName";
    lstLines.ValueMember = "LineGuid";
    DataRow row1 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT LineGuid, StateID FROM tblCompanyLines WHERE CompanyLineGuid = @CompanyLineGuid", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid
    });
    Guid guid = row1.Field<Guid>("LineGuid");
    this._sourceStateID = row1.Field<string>("StateID");
    dsCopyCompanyLine.lstLinesRow byLineGuid = this.ds.lstLines.FindByLineGuid(guid);
    int index1 = 0;
    if (byLineGuid != null)
    {
      try
      {
        foreach (dsCopyCompanyLine.lstLinesRow row2 in this.ds.lstLines.Rows)
        {
          if (!row2.LineGuid.Equals(guid))
            ++index1;
          else
            break;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.lstLines.SetItemChecked(index1, byLineGuid != null);
    if (!SystemSettings.KeyExists("OmittedCopyCompanyLineStates"))
      return;
    string[] strArray = SystemSettings.GetStringSetting("OmittedCopyCompanyLineStates").Split(",".ToCharArray());
    int index2 = 0;
    while (index2 < strArray.Length)
    {
      string StateID = strArray[index2];
      if (!string.IsNullOrEmpty(StateID))
        this.ds.lstStates.FindByStateID(StateID)?.Delete();
      checked { ++index2; }
    }
  }

  private void checkAllItems(bool check, MGACheckedListBox lst)
  {
    int num = lst.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      lst.SetItemChecked(index, check);
  }

  private void checkAllUsStates(bool check, MGACheckedListBox lst)
  {
    int num = lst.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      dsCopyCompanyLine.lstStatesRow byStateId = this.ds.lstStates.FindByStateID(((DataRowView) this.lstStates.Items[index])[this._valueMember].ToString().ToString());
      if (byStateId != null && byStateId.IsUsState)
        lst.SetItemChecked(index, check);
    }
  }

  private void lnkSelectStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.checkAllItems(true, this.lstStates);
  }

  private void lnkSelectUSStatesOnly_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.checkAllUsStates(true, this.lstStates);
  }

  private void lnkDeselectStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.checkAllItems(false, this.lstStates);
  }

  private void lnkSelectAllLines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.checkAllItems(true, this.lstLines);
  }

  private void lnkDeselectAllLines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.checkAllItems(false, this.lstLines);
  }

  private object CopyTransaction(string stateID, Guid lineGuid)
  {
    DbCommand command = DefaultDatabase.CreateCommand("dbo.spCopyCompanyLine", this.cnSQL);
    DbTransaction trans = (DbTransaction) null;
    DbCommand dbCommand = command;
    dbCommand.CommandTimeout = 300;
    dbCommand.CommandType = CommandType.StoredProcedure;
    DbParameterCollectionExtensions.AddWithValue(dbCommand.Parameters, "@originalCompanyLineGuid", (object) this._companyLineGuid);
    DbParameterCollectionExtensions.AddWithValue(dbCommand.Parameters, "@stateID", (object) stateID);
    DbParameterCollectionExtensions.AddWithValue(dbCommand.Parameters, "@lineGuid", (object) lineGuid);
    try
    {
      this.cnSQL.Open();
      trans = this.cnSQL.BeginTransaction();
      command.Transaction = trans;
      Guid guid = (Guid) command.ExecuteScalar();
      if (!guid.Equals(Guid.Empty))
      {
        this.CopyOverClientData(trans, this._companyLineGuid, stateID, lineGuid, guid);
        CurrentUser.Instance.LogAction("Line information copied from: " + this._sourceStateID, guid);
      }
      trans.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      trans?.Rollback();
      throw;
    }
    finally
    {
      this.cnSQL.Close();
      command.Dispose();
    }
    return (object) null;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      this.UltraProgressBar1.Maximum = this.lstStates.CheckedItems.Count * this.lstLines.CheckedItems.Count;
      this.UltraProgressBar1.Value = 0;
      try
      {
        foreach (DataRowView checkedItem1 in this.lstStates.CheckedItems)
        {
          string stateID = (string) checkedItem1["StateID"];
          try
          {
            foreach (DataRowView checkedItem2 in this.lstLines.CheckedItems)
            {
              Guid lineGuid = (Guid) checkedItem2["LineGuid"];
              this.CopyTransaction(stateID, lineGuid);
              UltraProgressBar ultraProgressBar1;
              int num = (ultraProgressBar1 = this.UltraProgressBar1).Value + 1;
              ultraProgressBar1.Value = num;
              ((UltraControlBase) this.UltraProgressBar1).Refresh();
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    this.Close();
  }

  protected virtual void CopyOverClientData(
    DbTransaction trans,
    Guid companyLineGuid,
    string stateID,
    Guid lineGuid,
    Guid newCompanyLineGuid)
  {
    if (!(trans is SqlTransaction))
      return;
    this.CopyOverClientData(trans as SqlTransaction, companyLineGuid, stateID, lineGuid, newCompanyLineGuid);
  }

  protected virtual void CopyOverClientData(
    SqlTransaction trans,
    Guid companyLineGuid,
    string stateID,
    Guid lineGuid,
    Guid newCompanyLineGuid)
  {
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
