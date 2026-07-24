// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentFolderAssociations
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmDocumentFolderAssociations : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private DbConnection cnSQL;
  private DbDataAdapter daTypeAssociations;
  private dsDocumentFolderTypes DsDocumentFolderTypes;
  private bool _formLoaded;
  private bool _folderTypesLoaded;
  private bool _loadingCheckBoxes;

  public frmDocumentFolderAssociations()
  {
    this.Load += new EventHandler(this.frmDocumentFolderAssociations_Load);
    this.Closing += new CancelEventHandler(this.frmDocumentFolderAssociations_Closing);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraTree folderTree
  {
    get => this._folderTree;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.folderTree_Click);
      UltraTree folderTree1 = this._folderTree;
      if (folderTree1 != null)
        ((Control) folderTree1).Click -= eventHandler;
      this._folderTree = value;
      UltraTree folderTree2 = this._folderTree;
      if (folderTree2 == null)
        return;
      ((Control) folderTree2).Click += eventHandler;
    }
  }

  private virtual MGACheckedListBox lstEntityTypes
  {
    get => this._lstEntityTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstEntityTypes_ItemCheck);
      MGACheckedListBox lstEntityTypes1 = this._lstEntityTypes;
      if (lstEntityTypes1 != null)
        lstEntityTypes1.ItemCheck -= checkEventHandler;
      this._lstEntityTypes = value;
      MGACheckedListBox lstEntityTypes2 = this._lstEntityTypes;
      if (lstEntityTypes2 == null)
        return;
      lstEntityTypes2.ItemCheck += checkEventHandler;
    }
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
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

  internal virtual ContextMenuStrip treeContext
  {
    get => this._treeContext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.treeContext_Opening);
      ContextMenuStrip treeContext1 = this._treeContext;
      if (treeContext1 != null)
        treeContext1.Opening -= cancelEventHandler;
      this._treeContext = value;
      ContextMenuStrip treeContext2 = this._treeContext;
      if (treeContext2 == null)
        return;
      treeContext2.Opening += cancelEventHandler;
    }
  }

  internal virtual ToolStripMenuItem CopyFilterToAllSubFoldersToolStripMenuItem
  {
    get => this._CopyFilterToAllSubFoldersToolStripMenuItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CopyFilterToAllSubFoldersToolStripMenuItem_Click);
      ToolStripMenuItem toolStripMenuItem1 = this._CopyFilterToAllSubFoldersToolStripMenuItem;
      if (toolStripMenuItem1 != null)
        toolStripMenuItem1.Click -= eventHandler;
      this._CopyFilterToAllSubFoldersToolStripMenuItem = value;
      ToolStripMenuItem toolStripMenuItem2 = this._CopyFilterToAllSubFoldersToolStripMenuItem;
      if (toolStripMenuItem2 == null)
        return;
      toolStripMenuItem2.Click += eventHandler;
    }
  }

  private virtual MGAButton btnClear
  {
    get => this._btnClear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClear_Click);
      MGAButton btnClear1 = this._btnClear;
      if (btnClear1 != null)
        ((Control) btnClear1).Click -= eventHandler;
      this._btnClear = value;
      MGAButton btnClear2 = this._btnClear;
      if (btnClear2 == null)
        return;
      ((Control) btnClear2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentFolderAssociations));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.Label1 = new Label();
    this.folderTree = new UltraTree();
    this.lstEntityTypes = new MGACheckedListBox();
    this.Label2 = new Label();
    this.daTypeAssociations = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.DsDocumentFolderTypes = new dsDocumentFolderTypes();
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnClear = new MGAButton();
    this.treeContext = new ContextMenuStrip(this.components);
    this.CopyFilterToAllSubFoldersToolStripMenuItem = new ToolStripMenuItem();
    ((ISupportInitialize) this.folderTree).BeginInit();
    ((ISupportInitialize) this.lstEntityTypes).BeginInit();
    this.DsDocumentFolderTypes.BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnClear).BeginInit();
    this.treeContext.SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(69, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Folder Types";
    ((Control) this.folderTree).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    this.folderTree.Appearance = (AppearanceBase) appearance1;
    ((Control) this.folderTree).ContextMenuStrip = this.treeContext;
    ((Control) this.folderTree).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.folderTree).Name = "folderTree";
    ((Control) this.folderTree).Size = new Size(200, 296);
    ((Control) this.folderTree).TabIndex = 2;
    ((UltraControlBase) this.folderTree).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.folderTree).UseOsThemes = (DefaultableBoolean) 2;
    this.lstEntityTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstEntityTypes.BackColor = Color.White;
    this.lstEntityTypes.CheckOnClick = true;
    this.lstEntityTypes.ForeColor = Color.Black;
    this.lstEntityTypes.IntegralHeight = false;
    this.lstEntityTypes.Location = new Point(224 /*0xE0*/, 32 /*0x20*/);
    this.lstEntityTypes.MGAStyle = MGAStyles.Blue;
    this.lstEntityTypes.Name = "lstEntityTypes";
    this.lstEntityTypes.Size = new Size(240 /*0xF0*/, 296);
    this.lstEntityTypes.TabIndex = 3;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(224 /*0xE0*/, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(89, 13);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Filterable Entities";
    this.daTypeAssociations.DeleteCommand = this.DbDeleteCommand1;
    this.daTypeAssociations.InsertCommand = this.DbInsertCommand1;
    this.daTypeAssociations.SelectCommand = this.DbSelectCommand1;
    this.daTypeAssociations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentFolderTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("AssociatedEntityType", "AssociatedEntityType"),
        new DataColumnMapping("FolderID", "FolderID")
      })
    });
    this.daTypeAssociations.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM dbo.tblDocumentFolderTypes WHERE (AssociatedEntityType = @Original_AssociatedEntityType) AND (FolderID = @Original_FolderID)";
    this.DbDeleteCommand1.Connection = this.cnSQL;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_AssociatedEntityType", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AssociatedEntityType", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_FolderID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FolderID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnSQL;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@AssociatedEntityType", SqlDbType.VarChar, 250, "AssociatedEntityType"),
      DefaultDatabase.CreateParameter("@FolderID", SqlDbType.Int, 4, "FolderID")
    });
    this.DbSelectCommand1.CommandText = "SELECT AssociatedEntityType, FolderID FROM dbo.tblDocumentFolderTypes";
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@AssociatedEntityType", SqlDbType.VarChar, 250, "AssociatedEntityType"),
      DefaultDatabase.CreateParameter("@FolderID", SqlDbType.Int, 4, "FolderID"),
      DefaultDatabase.CreateParameter("@Original_AssociatedEntityType", SqlDbType.VarChar, 250, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AssociatedEntityType", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_FolderID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FolderID", DataRowVersion.Original, (object) null)
    });
    this.DsDocumentFolderTypes.DataSetName = "dsDocumentFolderTypes";
    this.DsDocumentFolderTypes.Locale = new CultureInfo("en-US");
    this.DsDocumentFolderTypes.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOK).Location = new Point(312, 352);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(72, 24);
    ((Control) this.btnOK).TabIndex = 5;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(392, 352);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(72, 24);
    ((Control) this.btnCancel).TabIndex = 6;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnClear).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClear).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnClear).Location = new Point(8, 352);
    ((Control) this.btnClear).Name = "btnClear";
    ((Control) this.btnClear).Size = new Size(88, 24);
    ((Control) this.btnClear).TabIndex = 7;
    ((ControlBase) this.btnClear).Text = "Clear All Filters";
    this.btnClear.UseOSThemes = (DefaultableBoolean) 2;
    this.treeContext.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.CopyFilterToAllSubFoldersToolStripMenuItem
    });
    this.treeContext.Name = "treeContext";
    this.treeContext.Size = new Size(224 /*0xE0*/, 48 /*0x30*/);
    this.CopyFilterToAllSubFoldersToolStripMenuItem.Name = "CopyFilterToAllSubFoldersToolStripMenuItem";
    this.CopyFilterToAllSubFoldersToolStripMenuItem.Size = new Size(223, 22);
    this.CopyFilterToAllSubFoldersToolStripMenuItem.Text = "Copy Filter to All Sub Folders";
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(472, 382);
    this.Controls.Add((Control) this.btnClear);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lstEntityTypes);
    this.Controls.Add((Control) this.folderTree);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmDocumentFolderAssociations);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Document Folder Associations";
    ((ISupportInitialize) this.folderTree).EndInit();
    ((ISupportInitialize) this.lstEntityTypes).EndInit();
    this.DsDocumentFolderTypes.EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnClear).EndInit();
    this.treeContext.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmDocumentFolderAssociations_Load(object sender, EventArgs e)
  {
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.FolderTypes_QueryCompleted), (Control) this, (object) "FolderTypes_QueryCompleted", "SELECT FolderID, FolderName, ParentFolderID FROM dbo.tblDocumentFolders ORDER BY FolderName");
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new DocumentFolderFilterAttribute());
    int index = 0;
    while (index < typeArray.Length)
    {
      Type t = typeArray[index];
      if (t.IsSubclassOf(typeof (Control)))
      {
        object[] customAttributes = t.GetCustomAttributes(typeof (DocumentFolderFilterAttribute), false);
        if (customAttributes.Length == 1)
          this.lstEntityTypes.Items.Add((object) new frmDocumentFolderAssociations.DocumentTypeListItem(((DocumentFolderFilterAttribute) customAttributes[0]).Name, t));
      }
      checked { ++index; }
    }
    this._formLoaded = true;
    this.LoadAssociations();
  }

  private void FolderTypes_QueryCompleted(object sender, TableQueryMultithreadEventArgs e)
  {
    try
    {
      foreach (DataRow row in e.Table.Rows)
        this.folderTree.Nodes.Add((UltraTreeNode) new frmDocumentFolderAssociations.FolderNode(row));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    for (int index = this.folderTree.Nodes.Count - 1; index >= 0; index += -1)
    {
      frmDocumentFolderAssociations.FolderNode node = (frmDocumentFolderAssociations.FolderNode) this.folderTree.Nodes[index];
      if (node.ParentFolderID != null)
      {
        UltraTreeNode nodeByKey = this.folderTree.GetNodeByKey(node.ParentFolderID);
        node.Reposition(nodeByKey.Nodes);
      }
    }
    this._folderTypesLoaded = true;
    this.LoadAssociations();
  }

  private void ClearFoldersWithFilters(TreeNodesCollection nodes)
  {
    foreach (frmDocumentFolderAssociations.FolderNode node in nodes)
    {
      node.Override.NodeAppearance.Reset();
      this.ClearFoldersWithFilters(node.Nodes);
    }
  }

  private void MarkFoldersWithFilters(TreeNodesCollection nodes)
  {
    foreach (frmDocumentFolderAssociations.FolderNode node in nodes)
    {
      DataRow[] dataRowArray = this.DsDocumentFolderTypes.tblDocumentFolderTypes.Select($"FolderID = {node.FolderID}");
      if (dataRowArray != null && dataRowArray.Length > 0)
      {
        node.Override.NodeAppearance.FontData.Bold = (DefaultableBoolean) 1;
        for (UltraTreeNode parent = node.Parent; parent != null; parent = parent.Parent)
          parent.Override.NodeAppearance.FontData.Bold = (DefaultableBoolean) 1;
      }
      this.MarkFoldersWithFilters(node.Nodes);
    }
  }

  private void LoadAssociations()
  {
    if (!this._folderTypesLoaded || !this._formLoaded)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.AssociationLoadThreadProc));
  }

  private void AssociationLoadThreadProc(object state)
  {
    DefaultDatabase.DataAdapterFill(this.daTypeAssociations, (DataTable) this.DsDocumentFolderTypes.tblDocumentFolderTypes);
    this.BeginInvoke((Delegate) new EventHandler(this.ThreadCompleted));
  }

  private void ThreadCompleted(object sender, EventArgs e) => this.UpdateTypeSelections();

  private void UpdateTypeSelections()
  {
    this._loadingCheckBoxes = true;
    this.lstEntityTypes.BeginUpdate();
    if (this.folderTree.Nodes.Count > 0)
    {
      if (((DisposableObjectCollectionBase) this.folderTree.SelectedNodes).Count == 0)
        this.folderTree.Nodes[0].Selected = true;
      DataRow[] dataRowArray1 = this.DsDocumentFolderTypes.tblDocumentFolderTypes.Select($"FolderID = {((frmDocumentFolderAssociations.FolderNode) this.folderTree.SelectedNodes[0]).FolderID}");
      if (this.lstEntityTypes.CheckedItems.Count > 0)
      {
        try
        {
          foreach (object checkedIndex in this.lstEntityTypes.CheckedIndices)
            this.lstEntityTypes.SetItemChecked(Conversions.ToInteger(checkedIndex), false);
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      DataRow[] dataRowArray2 = dataRowArray1;
      int index1 = 0;
      while (index1 < dataRowArray2.Length)
      {
        dsDocumentFolderTypes.tblDocumentFolderTypesRow documentFolderTypesRow = (dsDocumentFolderTypes.tblDocumentFolderTypesRow) dataRowArray2[index1];
        if (documentFolderTypesRow.RowState != DataRowState.Deleted)
        {
          int num = this.lstEntityTypes.Items.Count - 1;
          for (int index2 = 0; index2 <= num; ++index2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((frmDocumentFolderAssociations.DocumentTypeListItem) this.lstEntityTypes.Items[index2]).TypeName, documentFolderTypesRow.AssociatedEntityType, false) == 0)
              this.lstEntityTypes.SetItemChecked(index2, true);
          }
        }
        checked { ++index1; }
      }
    }
    this.lstEntityTypes.EndUpdate();
    ((UltraControlBase) this.folderTree).BeginUpdate();
    this.ClearFoldersWithFilters(this.folderTree.Nodes);
    this.MarkFoldersWithFilters(this.folderTree.Nodes);
    ((UltraControlBase) this.folderTree).EndUpdate();
    this._loadingCheckBoxes = false;
  }

  private void lstEntityTypes_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.folderTree.SelectedNodes).Count == 0 || this._loadingCheckBoxes)
      return;
    int integer = Conversions.ToInteger(((frmDocumentFolderAssociations.FolderNode) this.folderTree.SelectedNodes[0]).FolderID);
    string typeName = ((frmDocumentFolderAssociations.DocumentTypeListItem) this.lstEntityTypes.Items[e.Index]).TypeName;
    if (e.NewValue == CheckState.Checked)
    {
      if (this.DsDocumentFolderTypes.tblDocumentFolderTypes.FindByAssociatedEntityTypeFolderID(typeName, integer) != null)
        return;
      this.DsDocumentFolderTypes.tblDocumentFolderTypes.AddtblDocumentFolderTypesRow(typeName, integer);
    }
    else
    {
      DataRow entityTypeFolderId = (DataRow) this.DsDocumentFolderTypes.tblDocumentFolderTypes.FindByAssociatedEntityTypeFolderID(typeName, integer);
      if (entityTypeFolderId == null || entityTypeFolderId.RowState == DataRowState.Deleted)
        return;
      entityTypeFolderId.Delete();
    }
  }

  private void folderTree_Click(object sender, EventArgs e) => this.UpdateTypeSelections();

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this.DsDocumentFolderTypes.HasChanges())
      this.daTypeAssociations.Update((DataTable) this.DsDocumentFolderTypes.tblDocumentFolderTypes);
    this.Close();
  }

  private void btnClear_Click(object sender, EventArgs e)
  {
    try
    {
      foreach (dsDocumentFolderTypes.tblDocumentFolderTypesRow documentFolderType in (TypedTableBase<dsDocumentFolderTypes.tblDocumentFolderTypesRow>) this.DsDocumentFolderTypes.tblDocumentFolderTypes)
      {
        if (documentFolderType.RowState != DataRowState.Deleted)
          documentFolderType.Delete();
      }
    }
    finally
    {
      IEnumerator<dsDocumentFolderTypes.tblDocumentFolderTypesRow> enumerator;
      enumerator?.Dispose();
    }
    this.UpdateTypeSelections();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    if (this.DsDocumentFolderTypes.HasChanges())
    {
      if (MessageBox.Show("Changes to the filters detected, are you sure you want to cancel and lose changes?", "Changes detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.Close();
    }
    else
      this.Close();
  }

  private void frmDocumentFolderAssociations_Closing(object sender, CancelEventArgs e)
  {
    if (!this.DsDocumentFolderTypes.HasChanges() || MessageBox.Show("Changes to the filters detected, are you sure you want to exit and lose changes?", "Changes detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      return;
    e.Cancel = true;
  }

  private void treeContext_Opening(object sender, CancelEventArgs e)
  {
    if (this.folderTree.ActiveNode != null)
      return;
    e.Cancel = true;
  }

  private void CopyFilterToAllSubFoldersToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (this.folderTree.ActiveNode == null || MessageBox.Show($"Are you sure you want to copy the folder permissions for {this.folderTree.ActiveNode.Text} to all of it's sub folders?", "Copy Folder Permissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    List<string> types = new List<string>();
    try
    {
      foreach (frmDocumentFolderAssociations.DocumentTypeListItem checkedItem in this.lstEntityTypes.CheckedItems)
        types.Add(checkedItem.TypeName);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.UpdateSubNodes(this.folderTree.ActiveNode.Nodes, types);
  }

  private void UpdateSubNodes(TreeNodesCollection nodes, List<string> types)
  {
    if (nodes == null || nodes.Count == 0 || types == null || types.Count == 0)
      return;
    foreach (frmDocumentFolderAssociations.FolderNode node in nodes)
    {
      int integer = Conversions.ToInteger(node.FolderID);
      DataRow[] dataRowArray = this.DsDocumentFolderTypes.tblDocumentFolderTypes.Select($"FolderID = {node.FolderID}");
      int index = 0;
      while (index < dataRowArray.Length)
      {
        dataRowArray[index].Delete();
        checked { ++index; }
      }
      try
      {
        foreach (string type in types)
        {
          if (this.DsDocumentFolderTypes.tblDocumentFolderTypes.FindByAssociatedEntityTypeFolderID(type, integer) == null)
            this.DsDocumentFolderTypes.tblDocumentFolderTypes.AddtblDocumentFolderTypesRow(type, integer);
        }
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.UpdateSubNodes(node.Nodes, types);
    }
  }

  private class DocumentTypeListItem
  {
    private string _name;
    private string _typeName;

    public DocumentTypeListItem(string name, Type t)
    {
      this._name = name;
      this._typeName = t.FullName;
    }

    public string TypeName => this._typeName;

    public override string ToString() => this._name;
  }

  [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly")]
  [SuppressMessage("Microsoft.Usage", "CA2229:ImplementSerializationConstructors")]
  [Serializable]
  internal sealed class FolderNode : UltraTreeNode
  {
    private string _parentKey;

    public FolderNode(DataRow row)
      : base(Conversions.ToString(row[0]), Conversions.ToString(row[1]))
    {
      if (!row.IsNull(2))
        this._parentKey = Conversions.ToString(row[2]);
      this.LeftImages.Add((object) ImageCache.Instance.Folder);
    }

    public string ParentFolderID => this._parentKey;

    public string FolderID => this.Key;
  }
}
