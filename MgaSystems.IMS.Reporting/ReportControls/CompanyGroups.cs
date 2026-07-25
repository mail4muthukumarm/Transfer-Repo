// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CompanyGroups
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class CompanyGroups : BaseReportControl
{
  private IContainer components;
  private DataTable _dtCompanies;
  private DataTable _dtCompanyLocations;
  private bool _showAll;
  private bool _ShowIntermediaries;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("CompanyLocations")]
  protected virtual MGASimpleComboBox CompanyLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox Companies
  {
    get => this._Companies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Companies_ValueChanged);
      MGASimpleComboBox companies1 = this._Companies;
      if (companies1 != null)
        companies1.ValueChanged -= eventHandler;
      this._Companies = value;
      MGASimpleComboBox companies2 = this._Companies;
      if (companies2 == null)
        return;
      companies2.ValueChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.CompanyLocations = new MGASimpleComboBox();
    this.Companies = new MGASimpleComboBox();
    ((ISupportInitialize) this.CompanyLocations).BeginInit();
    ((ISupportInitialize) this.Companies).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, 8);
    this.lblDescription.Size = new Size(88, 40);
    ((Control) this.CompanyLocations).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.CompanyLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.CompanyLocations).Location = new Point(88, 30);
    ((Control) this.CompanyLocations).Name = "CompanyLocations";
    ((Control) this.CompanyLocations).Size = new Size(300, 20);
    ((Control) this.CompanyLocations).TabIndex = 1;
    ((UltraControlBase) this.CompanyLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CompanyLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.Companies).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Companies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.Companies).Location = new Point(88, 6);
    ((Control) this.Companies).Name = "Companies";
    ((Control) this.Companies).Size = new Size(300, 20);
    ((Control) this.Companies).TabIndex = 2;
    ((UltraControlBase) this.Companies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Companies).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.Companies);
    this.Controls.Add((Control) this.CompanyLocations);
    this.Name = nameof (CompanyGroups);
    this.Size = new Size(392, 56);
    this.Controls.SetChildIndex((Control) this.CompanyLocations, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.Companies, 0);
    ((ISupportInitialize) this.CompanyLocations).EndInit();
    ((ISupportInitialize) this.Companies).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public CompanyGroups()
  {
    this._dtCompanyLocations = new DataTable();
    this._ShowIntermediaries = false;
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  public CompanyGroups(string labelText, bool ShowAllOption)
  {
    this._dtCompanyLocations = new DataTable();
    this._ShowIntermediaries = false;
    this.InitializeComponent();
    this._showAll = ShowAllOption;
    this.Description = labelText;
    this._dtCompanyLocations.Columns.Add("EntityGuid", typeof (Guid));
    this._dtCompanyLocations.Columns.Add("Name", typeof (string));
    this._dtCompanyLocations.Columns.Add("CompanyLocationGuid", typeof (Guid));
    this._dtCompanies = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyName, CompanyGuid As EntityGuid FROM tblCompanies ORDER BY CompanyName");
    if (ShowAllOption)
    {
      DataRow row = this._dtCompanies.NewRow();
      row.ItemArray = new object[2]
      {
        (object) "All Companies",
        (object) Guid.Empty
      };
      this._dtCompanies.Rows.InsertAt(row, 0);
      this._dtCompanyLocations.Rows.Add((object) Guid.Empty, (object) "All Locations", (object) Guid.Empty);
      ((Control) this.CompanyLocations).Enabled = false;
    }
    ((UltraDropDownBase) this.Companies).DisplayMember = "CompanyName";
    ((UltraDropDownBase) this.Companies).ValueMember = "EntityGUID";
    ((UltraGridBase) this.Companies).DataSource = (object) this._dtCompanies;
    this.Companies.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public CompanyGroups(string labelText, bool ShowAllOption, bool ShowIntermediaries)
  {
    this._dtCompanyLocations = new DataTable();
    this._ShowIntermediaries = false;
    this.InitializeComponent();
    this._showAll = ShowAllOption;
    this._ShowIntermediaries = ShowIntermediaries;
    this.Description = labelText;
    this._dtCompanyLocations.Columns.Add("EntityGuid", typeof (Guid));
    this._dtCompanyLocations.Columns.Add("Name", typeof (string));
    this._dtCompanyLocations.Columns.Add("CompanyLocationGuid", typeof (Guid));
    this._dtCompanies = !this._ShowIntermediaries ? DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyName As Name, CompanyGuid As EntityGuid, 0 As CoOrInt FROM tblCompanies ORDER BY CompanyName") : DefaultDatabase.ExecuteDataTable(CommandType.Text, "(SELECT CompanyName As Name, CompanyGuid As EntityGuid, 0 As CoOrInt FROM tblCompanies) UNION (SELECT IntermediaryName As Name, IntermediaryGuid As EntityGuid, 1 As CoOrInt FROM tblIntermediaries) ORDER BY [Name]");
    if (ShowAllOption)
    {
      DataRow row = this._dtCompanies.NewRow();
      row.ItemArray = new object[3]
      {
        (object) "All Entities",
        (object) Guid.Empty,
        (object) 0
      };
      this._dtCompanies.Rows.InsertAt(row, 0);
      this._dtCompanyLocations.Rows.Add((object) Guid.Empty, (object) "All Locations", (object) Guid.Empty);
      ((Control) this.CompanyLocations).Enabled = false;
    }
    ((UltraDropDownBase) this.Companies).DisplayMember = "Name";
    ((UltraDropDownBase) this.Companies).ValueMember = "EntityGUID";
    ((UltraGridBase) this.Companies).DataSource = (object) this._dtCompanies;
    this.Companies.SelectedIndex = 0;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get
    {
      object obj;
      if (((Control) this.CompanyLocations).Enabled)
        obj = (object) new Guid[2]
        {
          (Guid) this.Companies.Value,
          (Guid) this.CompanyLocations.Value
        };
      else
        obj = (object) new Guid[2]
        {
          (Guid) this.Companies.Value,
          Guid.Empty
        };
      return obj;
    }
    set
    {
      object[] objArray = (object[]) value;
      if (objArray.Length > 1)
      {
        this.Companies.Value = (object) (Guid) objArray[0];
        this.CompanyLocations.Value = (object) (Guid) objArray[1];
      }
      else
        this.Companies.Value = (object) (Guid) objArray[0];
    }
  }

  public override void Compress()
  {
    ((Control) this.Companies).Top = 0;
    ((Control) this.CompanyLocations).Top = ((Control) this.Companies).Height;
    this.lblDescription.Height = ((Control) this.Companies).Height * 2;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.Companies).Height * 2;
  }

  private void Companies_ValueChanged(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    Guid guid = (Guid) this.Companies.Value;
    if (guid.Equals(Guid.Empty))
    {
      ((Control) this.CompanyLocations).Enabled = false;
    }
    else
    {
      if (this._dtCompanyLocations.Select($"EntityGuid='{guid}'").Length == 0)
        this._dtCompanyLocations = DefaultDatabase.ExecuteDataTable(CommandType.Text, !this._ShowIntermediaries ? "select CompanyGuid As EntityGuid, Name, CompanyLocationGuid from tblCompanyLocations where tblCompanyLocations.companyguid=@entityGuid order by Name" : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._dtCompanies.Rows[this.Companies.SelectedIndex]["CoOrInt"].ToString(), "1", false) != 0 ? "select CompanyGuid As EntityGuid, Name, CompanyLocationGuid from tblCompanyLocations where tblCompanyLocations.companyguid=@entityGuid order by Name" : "select IntermediaryGuid As EntityGuid, Name, CompanyLocationGuid from tblCompanyLocations where tblCompanyLocations.intermediaryGuid=@entityGuid order by Name"), new object[2]
        {
          (object) "@entityGuid",
          (object) guid
        });
      DataView dataView = !this._showAll ? new DataView(this._dtCompanyLocations, $"EntityGuid='{guid}'", "Name", DataViewRowState.CurrentRows) : new DataView(this._dtCompanyLocations, $"EntityGuid='{guid}' OR EntityGuid='{Guid.Empty}'", "Name", DataViewRowState.CurrentRows);
      if (dataView.Count > 0)
      {
        ((Control) this.CompanyLocations).Enabled = true;
        ((UltraDropDownBase) this.CompanyLocations).DisplayMember = "Name";
        ((UltraDropDownBase) this.CompanyLocations).ValueMember = "CompanyLocationGuid";
        ((UltraGridBase) this.CompanyLocations).DataSource = (object) dataView;
        this.CompanyLocations.SelectedIndex = 0;
      }
    }
    Cursor.Current = Cursors.Default;
  }
}
