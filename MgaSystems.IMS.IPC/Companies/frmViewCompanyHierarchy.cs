// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmViewCompanyHierarchy
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
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
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{6CE1A8D9-1130-4ed9-B01A-E9D9057A8110}", "Access Company Hierarchy Screen", "Controls access to Company Hierarchy screen.", "Companies")]
public sealed class frmViewCompanyHierarchy : Form, ISupportDocumentSystem, ISupportNoteSystem
{
  private IContainer components;
  private dsViewCompanyHierarchy ds;
  private SqlConnection cn;
  private ContextMenu cm;
  private TreeNode lastGroupNodeClicked;
  public const string canOpenCompHierarchyForm = "{6CE1A8D9-1130-4ed9-B01A-E9D9057A8110}";

  public frmViewCompanyHierarchy()
  {
    this.Load += new EventHandler(this.frmViewCompanyHierarchy_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual TreeView tvCompanies
  {
    get => this._tvCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.tvCompanies_AfterSelect);
      TreeView tvCompanies1 = this._tvCompanies;
      if (tvCompanies1 != null)
        tvCompanies1.AfterSelect -= viewEventHandler;
      this._tvCompanies = value;
      TreeView tvCompanies2 = this._tvCompanies;
      if (tvCompanies2 == null)
        return;
      tvCompanies2.AfterSelect += viewEventHandler;
    }
  }

  private virtual MenuItem mnuGroups
  {
    get => this._mnuGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuGroups_Click);
      MenuItem mnuGroups1 = this._mnuGroups;
      if (mnuGroups1 != null)
        mnuGroups1.Click -= eventHandler;
      this._mnuGroups = value;
      MenuItem mnuGroups2 = this._mnuGroups;
      if (mnuGroups2 == null)
        return;
      mnuGroups2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.cn = new SqlConnection();
    this.ds = new dsViewCompanyHierarchy();
    this.tvCompanies = new TreeView();
    this.cm = new ContextMenu();
    this.mnuGroups = new MenuItem();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;user id=psarnowski;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.ds.DataSetName = "dsViewCompanyHierarchy";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tvCompanies.BorderStyle = BorderStyle.None;
    this.tvCompanies.ContextMenu = this.cm;
    this.tvCompanies.Dock = DockStyle.Fill;
    this.tvCompanies.Location = new Point(0, 0);
    this.tvCompanies.Name = "tvCompanies";
    this.tvCompanies.Size = new Size(480, 430);
    this.tvCompanies.TabIndex = 0;
    this.cm.MenuItems.AddRange(new MenuItem[1]
    {
      this.mnuGroups
    });
    this.mnuGroups.Index = 0;
    this.mnuGroups.Text = "Modify Company Groups";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(480, 430);
    this.Controls.Add((Control) this.tvCompanies);
    this.Name = nameof (frmViewCompanyHierarchy);
    this.Text = "Company Hierarchy";
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private void frmViewCompanyHierarchy_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("dbo.spGetCompanyHierarchyFormData", this.cn);
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      DataTableMappingCollection tableMappings = sqlDataAdapter.TableMappings;
      tableMappings.Clear();
      tableMappings.Add("Table", this.ds.tblCompanyGroups.TableName);
      tableMappings.Add("Table1", this.ds.tblCompanies.TableName);
      tableMappings.Add("Table2", this.ds.tblCompanyLocations.TableName);
      DefaultDatabase.DataAdapterFill((DbDataAdapter) sqlDataAdapter, (DataSet) this.ds);
    }
    finally
    {
      sqlDataAdapter.Dispose();
    }
    this.FillTree();
  }

  private void FillTree()
  {
    try
    {
      foreach (dsViewCompanyHierarchy.tblCompanyGroupsRow tblCompanyGroup in (TypedTableBase<dsViewCompanyHierarchy.tblCompanyGroupsRow>) this.ds.tblCompanyGroups)
        this.tvCompanies.Nodes.Add(new TreeNode(tblCompanyGroup.CompanyGroupName)
        {
          Tag = (object) tblCompanyGroup.CompanyGroupGuid
        });
    }
    finally
    {
      IEnumerator<dsViewCompanyHierarchy.tblCompanyGroupsRow> enumerator;
      enumerator?.Dispose();
    }
    this.tvCompanies.Nodes.Add("Ungrouped");
    try
    {
      foreach (dsViewCompanyHierarchy.tblCompaniesRow tblCompany in (TypedTableBase<dsViewCompanyHierarchy.tblCompaniesRow>) this.ds.tblCompanies)
      {
        if (tblCompany.IsCompanyGroupGuidNull())
        {
          try
          {
            foreach (TreeNode node in this.tvCompanies.Nodes)
            {
              if (node.Tag == null)
                node.Nodes.Add(new TreeNode(tblCompany.CompanyName)
                {
                  Tag = (object) tblCompany.CompanyGuid
                });
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        else
        {
          try
          {
            foreach (TreeNode node in this.tvCompanies.Nodes)
            {
              if (node.Tag != null && node.Tag.Equals((object) tblCompany.CompanyGroupGuid))
              {
                TreeNode treeNode = new TreeNode(tblCompany.CompanyName);
                treeNode.Tag = (object) tblCompany.CompanyGuid;
                node.Nodes.Add(treeNode);
                this.AddLocations(treeNode, tblCompany.GettblCompanyLocationsRows());
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
      }
    }
    finally
    {
      IEnumerator<dsViewCompanyHierarchy.tblCompaniesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void AddLocations(
    TreeNode tnCompany,
    dsViewCompanyHierarchy.tblCompanyLocationsRow[] drLocations)
  {
    dsViewCompanyHierarchy.tblCompanyLocationsRow[] companyLocationsRowArray = drLocations;
    int index = 0;
    while (index < companyLocationsRowArray.Length)
    {
      dsViewCompanyHierarchy.tblCompanyLocationsRow companyLocationsRow = companyLocationsRowArray[index];
      tnCompany.Nodes.Add(new TreeNode(companyLocationsRow.Name)
      {
        Tag = (object) companyLocationsRow.CompanyLocationGuid
      });
      checked { ++index; }
    }
  }

  private void mnuGroups_Click(object sender, EventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmCompanyGroups)))
      ;
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  event ISupportNoteSystem.EntityInfoChangedEventHandler ISupportNoteSystem.ISupportNoteSystem_EntityInfoChanged;

  public bool AllowAddNewDocument => this.lastGroupNodeClicked != null;

  string IRecreatableEntity.EntityName => "Company Group Hierarchy";

  Guid IRecreatableEntity.EntityGuid => (Guid) this.lastGroupNodeClicked.Tag;

  string IRecreatableEntity.FriendlyEntityName => this.lastGroupNodeClicked.Text;

  public bool CanCreateNewNote => this.lastGroupNodeClicked != null;

  string IRecreatableEntity.RecreateTypeName => this.GetType().FullName;

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.HasControlGUID => false;

  Guid IRecreatableEntity.ControlGUID => throw new NotImplementedException();

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid) => false;

  private void tvCompanies_AfterSelect(object sender, TreeViewEventArgs e)
  {
    this.lastGroupNodeClicked = e.Node.Tag == null || e.Node.Level != 0 ? (TreeNode) null : e.Node;
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler infoChangedEvent1 = this.EntityInfoChangedEvent;
    if (infoChangedEvent1 != null)
      infoChangedEvent1((object) this, EventArgs.Empty);
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChangedEvent2 = this.ISupportNoteSystem_EntityInfoChangedEvent;
    if (infoChangedEvent2 == null)
      return;
    infoChangedEvent2((object) this, EventArgs.Empty);
  }
}
