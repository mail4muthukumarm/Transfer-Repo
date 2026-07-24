// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Entities.frmNewEditEntityGroup
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Entities;

public class frmNewEditEntityGroup : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private MGATextBox txtGroupName;
  private MGATextBox txtDescription;
  private SqlDataAdapter da;
  private ErrorProvider err;
  private dsNewEditEntityGroup ds;
  private Label Label3;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private MGASimpleComboBox cboOffices;
  private bool _saved;
  private int _groupID;
  private bool _costCenterOnly;
  private int _defaultOfficeLocationID;

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

  [field: AccessedThroughProperty("chkInactive")]
  private virtual MGACheckBox chkInactive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkCostCenter
  {
    get => this._chkCostCenter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCostCenter_CheckStateChanged);
      MGACheckBox chkCostCenter1 = this._chkCostCenter;
      if (chkCostCenter1 != null)
        ((UltraToggleEditorBase) chkCostCenter1).CheckStateChanged -= eventHandler;
      this._chkCostCenter = value;
      MGACheckBox chkCostCenter2 = this._chkCostCenter;
      if (chkCostCenter2 == null)
        return;
      ((UltraToggleEditorBase) chkCostCenter2).CheckStateChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNewEditEntityGroup));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.ds = new dsNewEditEntityGroup();
    this.btnSave = new MGAButton();
    this.txtGroupName = new MGATextBox();
    this.txtDescription = new MGATextBox();
    this.btnCancel = new MGAButton();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.Label3 = new Label();
    this.chkCostCenter = new MGACheckBox();
    this.cboOffices = new MGASimpleComboBox();
    this.chkInactive = new MGACheckBox();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.txtGroupName).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.chkCostCenter).BeginInit();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    ((ISupportInitialize) this.chkInactive).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(9, 36);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(70, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Group Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(9, 60);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Description:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.ds.DataSetName = "dsNewEditEntityGroup";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(344, 138);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 6;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtGroupName).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtGroupName).BackColor = Color.White;
    ((Control) this.txtGroupName).DataBindings.Add(new Binding("Text", (object) this.ds, "tblEntityGroups.GroupName", true));
    ((Control) this.txtGroupName).Location = new Point(88, 32 /*0x20*/);
    ((TextEditorControlBase) this.txtGroupName).MaxLength = 35;
    this.txtGroupName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtGroupName).Name = "txtGroupName";
    ((Control) this.txtGroupName).Size = new Size(296, 20);
    ((Control) this.txtGroupName).TabIndex = 1;
    ((UltraControlBase) this.txtGroupName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGroupName).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "tblEntityGroups.GroupDescription", true));
    ((Control) this.txtDescription).Location = new Point(88, 56);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 2000;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(296, 20);
    ((Control) this.txtDescription).TabIndex = 2;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(296, 138);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 5;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblEntityGroups", new DataColumnMapping[8]
      {
        new DataColumnMapping("GroupId", "GroupId"),
        new DataColumnMapping("GroupName", "GroupName"),
        new DataColumnMapping("GroupDescription", "GroupDescription"),
        new DataColumnMapping("IsCostCenter", "IsCostCenter"),
        new DataColumnMapping("SystemDefined", "SystemDefined"),
        new DataColumnMapping("GLCompanyID", "GLCompanyID"),
        new DataColumnMapping("GroupGuid", "GroupGuid"),
        new DataColumnMapping("Inactive", "Inactive")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblEntityGroups] WHERE (([GroupId] = @Original_GroupId))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_GroupId", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupId", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = "INSERT INTO dbo.tblEntityGroups (GroupName, GroupDescription, IsCostCenter, SystemDefined, GLCompanyID, GroupGuid, Inactive) VALUES (@GroupName,@GroupDescription,@IsCostCenter,@SystemDefined,@GLCompanyID,@GroupGuid,@Inactive); SELECT GroupId, GroupName, GroupDescription, IsCostCenter, SystemDefined, GLCompanyID, GroupGuid, Inactive FROM dbo.tblEntityGroups WHERE (GroupId = SCOPE_IDENTITY())";
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@GroupName", SqlDbType.VarChar, 35, "GroupName"),
      new SqlParameter("@GroupDescription", SqlDbType.VarChar, 2000, "GroupDescription"),
      new SqlParameter("@IsCostCenter", SqlDbType.Bit, 1, "IsCostCenter"),
      new SqlParameter("@SystemDefined", SqlDbType.Bit, 1, "SystemDefined"),
      new SqlParameter("@GLCompanyID", SqlDbType.Int, 4, "GLCompanyID"),
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"),
      new SqlParameter("@Inactive", SqlDbType.Bit, 1, "Inactive")
    });
    this.SqlSelectCommand1.CommandText = "SELECT GroupId, GroupName, GroupDescription, IsCostCenter, SystemDefined, GLCompanyID, GroupGuid, Inactive FROM dbo.tblEntityGroups WHERE (GroupId = COALESCE (@GroupID, GroupId))";
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@GroupID", SqlDbType.Int, 4, "GroupId")
    });
    this.SqlUpdateCommand1.CommandText = "Update dbo.tblEntityGroups SET GroupName = @GroupName, GroupDescription = @GroupDescription, IsCostCenter = @IsCostCenter, SystemDefined = @SystemDefined,  GLCompanyID = @GLCompanyID, GroupGuid = @GroupGuid, Inactive = @Inactive WHERE(GroupID = @Original_GroupId); Select GroupID, GroupName, GroupDescription, IsCostCenter, SystemDefined, GLCompanyID, GroupGuid, Inactive FROM dbo.tblEntityGroups WHERE (GroupId = @GroupId)";
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@GroupName", SqlDbType.VarChar, 35, "GroupName"),
      new SqlParameter("@GroupDescription", SqlDbType.VarChar, 2000, "GroupDescription"),
      new SqlParameter("@IsCostCenter", SqlDbType.Bit, 1, "IsCostCenter"),
      new SqlParameter("@SystemDefined", SqlDbType.Bit, 1, "SystemDefined"),
      new SqlParameter("@GLCompanyID", SqlDbType.Int, 4, "GLCompanyID"),
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"),
      new SqlParameter("@Inactive", SqlDbType.Bit, 1, "Inactive"),
      new SqlParameter("@Original_GroupId", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupId", DataRowVersion.Original, (object) null),
      new SqlParameter("@GroupId", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupId", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(9, 84);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(40, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Office:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCostCenter).Appearance = (AppearanceBase) appearance5;
    ((Control) this.chkCostCenter).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEntityGroups.IsCostCenter", true));
    ((UltraToggleEditorBase) this.chkCostCenter).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCostCenter).Location = new Point(88, 8);
    ((Control) this.chkCostCenter).Name = "chkCostCenter";
    ((Control) this.chkCostCenter).Size = new Size(120, 20);
    ((Control) this.chkCostCenter).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkCostCenter).Text = "Cost Center";
    this.cboOffices.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOffices).DataBindings.Add(new Binding("Value", (object) this.ds, "tblEntityGroups.GLCompanyID", true));
    ((UltraGridBase) this.cboOffices).DataSource = (object) this.ds.tblClientOffices;
    ((UltraDropDownBase) this.cboOffices).DisplayMember = "Location";
    this.cboOffices.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffices).Location = new Point(88, 80 /*0x50*/);
    this.cboOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(296, 21);
    ((Control) this.cboOffices).TabIndex = 3;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOffices).ValueMember = "OfficeID";
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInactive).Appearance = (AppearanceBase) appearance6;
    ((Control) this.chkInactive).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblEntityGroups.Inactive", true));
    ((UltraToggleEditorBase) this.chkInactive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInactive).Location = new Point(88, 105);
    ((Control) this.chkInactive).Name = "chkInactive";
    ((Control) this.chkInactive).Size = new Size(73, 20);
    ((Control) this.chkInactive).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkInactive).Text = "Inactive";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(402, 190);
    this.Controls.Add((Control) this.chkInactive);
    this.Controls.Add((Control) this.cboOffices);
    this.Controls.Add((Control) this.chkCostCenter);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtDescription);
    this.Controls.Add((Control) this.txtGroupName);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmNewEditEntityGroup);
    this.Text = "Add / Edit Entity";
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.txtGroupName).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.chkCostCenter).EndInit();
    ((ISupportInitialize) this.cboOffices).EndInit();
    ((ISupportInitialize) this.chkInactive).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmNewEditEntityGroup()
  {
    this.Load += new EventHandler(this.frmNewEditEntityGroup_Load);
    this._groupID = -1;
    this._defaultOfficeLocationID = -1;
    this.InitializeComponent();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.da, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblClientOffices"
    }, CommandType.Text, "SELECT OfficeID, Location, dbo.HasChartOfAccounts(OfficeID) AS HasChartOfAccounts FROM tblClientOffices ORDER BY Location");
  }

  public frmNewEditEntityGroup(int groupID)
    : this()
  {
    this._groupID = groupID;
    this.da.SelectCommand.Parameters["@GroupID"].Value = (object) groupID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblEntityGroups);
  }

  public bool CostCenterOnly
  {
    get => this._costCenterOnly;
    set
    {
      this._costCenterOnly = value;
      if (value && !CurrentUser.Instance.IsAccountingPackageActive)
        throw new InvalidOperationException("Can't limit to cost centers - accounting package not available.");
    }
  }

  public int DefaultOfficeLocationID
  {
    get => this._defaultOfficeLocationID;
    set => this._defaultOfficeLocationID = value;
  }

  public bool Saved => this._saved;

  public bool IsCostCenter => this.ds.tblEntityGroups[0].IsCostCenter;

  public int GroupID => this.ds.tblEntityGroups[0].GroupId;

  public string GroupName => this.ds.tblEntityGroups[0].GroupName;

  public string GroupDescription => this.ds.tblEntityGroups[0].GroupDescription;

  private bool IsNewGroup => this._groupID == -1;

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblEntityGroups.TableName];
  }

  private void frmNewEditEntityGroup_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    if (this.IsNewGroup)
    {
      dsNewEditEntityGroup.tblEntityGroupsRow row = this.ds.tblEntityGroups.NewtblEntityGroupsRow();
      row.GroupGuid = Guid.NewGuid();
      row.SystemDefined = false;
      if (!CurrentUser.Instance.IsAccountingPackageActive)
      {
        row.IsCostCenter = false;
        ((Control) this.chkCostCenter).Enabled = false;
      }
      else if (this.CostCenterOnly)
      {
        row.IsCostCenter = true;
        ((Control) this.chkCostCenter).Enabled = false;
        if (this.DefaultOfficeLocationID != -1 && this.ds.tblClientOffices.FindByOfficeID(this.DefaultOfficeLocationID) != null)
          row.GLCompanyID = this.DefaultOfficeLocationID;
      }
      this.ds.tblEntityGroups.AddtblEntityGroupsRow(row);
      if (this.ds.tblClientOffices.Count != 1)
        return;
      this.ds.tblEntityGroups[0].GLCompanyID = this.ds.tblClientOffices[0].OfficeID;
    }
    else
      this.bmb.Position = 0;
  }

  private bool IsValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboOffices, string.Empty);
    this.err.SetError((Control) this.txtDescription, string.Empty);
    this.err.SetError((Control) this.txtGroupName, string.Empty);
    if (((TextEditorControlBase) this.txtGroupName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtGroupName, "Please enter a group name.");
      flag = false;
    }
    if (((TextEditorControlBase) this.txtDescription).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtDescription, "Please enter a description.");
      flag = false;
    }
    if (this.cboOffices.Text.Length == 0)
    {
      this.err.SetError((Control) this.cboOffices, "Please select an office.");
      flag = false;
    }
    return flag;
  }

  private void chkCostCenter_CheckStateChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkCostCenter).Checked)
      this.ds.tblClientOffices.DefaultView.RowFilter = "HasChartOfAccounts = 1";
    else
      this.ds.tblClientOffices.DefaultView.RowFilter = string.Empty;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidForm())
      return;
    this.bmb.EndCurrentEdit();
    try
    {
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblEntityGroups);
      this._saved = true;
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
