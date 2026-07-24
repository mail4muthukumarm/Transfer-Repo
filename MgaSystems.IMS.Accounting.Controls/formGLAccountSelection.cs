// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.formGLAccountSelection
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class formGLAccountSelection : Form
{
  private IContainer components;
  private int GLCompanyID;
  private SqlCommand cmd;
  private ArrayList glAccounts;
  private string glName;
  private bool DoCopyTreesBeforeEdit;
  private ArrayList tempTreeGlAcctNodes;
  private ArrayList tempSelectedGlAcctNodes;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("label3")]
  internal virtual Label label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GLAccountImages")]
  internal virtual ImageList GLAccountImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnAdd
  {
    get => this._btnAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnAdd_Click);
      MGAButton btnAdd1 = this._btnAdd;
      if (btnAdd1 != null)
        ((Control) btnAdd1).Click -= eventHandler;
      this._btnAdd = value;
      MGAButton btnAdd2 = this._btnAdd;
      if (btnAdd2 == null)
        return;
      ((Control) btnAdd2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnRemove
  {
    get => this._btnRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnRemove_Click);
      MGAButton btnRemove1 = this._btnRemove;
      if (btnRemove1 != null)
        ((Control) btnRemove1).Click -= eventHandler;
      this._btnRemove = value;
      MGAButton btnRemove2 = this._btnRemove;
      if (btnRemove2 == null)
        return;
      ((Control) btnRemove2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("treeGlAcct")]
  internal virtual MGATreeView treeGlAcct { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("treeSelectedGlAcct")]
  internal virtual MGATreeView treeSelectedGlAcct { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      MGAButton btnOk1 = this._btnOk;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOk = value;
      MGAButton btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
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
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formGLAccountSelection));
    this.treeGlAcct = new MGATreeView();
    this.btnAdd = new MGAButton();
    this.btnRemove = new MGAButton();
    this.treeSelectedGlAcct = new MGATreeView();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.Panel2 = new Panel();
    this.Label5 = new Label();
    this.Label1 = new Label();
    this.label3 = new Label();
    this.PictureBox1 = new PictureBox();
    this.GLAccountImages = new ImageList(this.components);
    this.Panel1 = new Panel();
    this.Label2 = new Label();
    this.Label4 = new Label();
    ((ISupportInitialize) this.treeGlAcct).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.btnRemove).BeginInit();
    ((ISupportInitialize) this.treeSelectedGlAcct).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel1.SuspendLayout();
    this.SuspendLayout();
    appearance1.BorderColor = Color.LightGray;
    this.treeGlAcct.Appearance = (AppearanceBase) appearance1;
    this.treeGlAcct.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.treeGlAcct).Location = new Point(6, 88);
    ((Control) this.treeGlAcct).Name = "treeGlAcct";
    this.treeGlAcct.ShowLines = false;
    ((Control) this.treeGlAcct).Size = new Size(280, 328);
    ((Control) this.treeGlAcct).TabIndex = 0;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnAdd).Font = new Font("Tahoma", 8f);
    ((Control) this.btnAdd).Location = new Point(296, 208 /*0xD0*/);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(72, 24);
    ((Control) this.btnAdd).TabIndex = 1;
    ((ControlBase) this.btnAdd).Text = "Add >";
    this.btnAdd.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRemove).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnRemove).Font = new Font("Tahoma", 8f);
    ((Control) this.btnRemove).Location = new Point(296, 240 /*0xF0*/);
    ((Control) this.btnRemove).Name = "btnRemove";
    ((Control) this.btnRemove).Size = new Size(72, 24);
    ((Control) this.btnRemove).TabIndex = 2;
    ((ControlBase) this.btnRemove).Text = "< Remove ";
    this.btnRemove.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.treeSelectedGlAcct).AccessibleRole = AccessibleRole.None;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.LightGray;
    this.treeSelectedGlAcct.Appearance = (AppearanceBase) appearance4;
    this.treeSelectedGlAcct.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.treeSelectedGlAcct).Location = new Point(380, 88);
    ((Control) this.treeSelectedGlAcct).Name = "treeSelectedGlAcct";
    this.treeSelectedGlAcct.ShowLines = false;
    ((Control) this.treeSelectedGlAcct).Size = new Size(288, 328);
    ((Control) this.treeSelectedGlAcct).TabIndex = 3;
    ((Control) this.btnOk).Anchor = AnchorStyles.None;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance5;
    ((UltraButtonBase) this.btnOk).DialogResult = DialogResult.OK;
    ((Control) this.btnOk).Location = new Point(480, 12);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(88, 24);
    ((Control) this.btnOk).TabIndex = 3;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.None;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance6;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(576, 12);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 2;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel2.BackColor = Color.White;
    this.Panel2.Controls.Add((Control) this.Label5);
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Controls.Add((Control) this.label3);
    this.Panel2.Controls.Add((Control) this.PictureBox1);
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(674, 68);
    this.Panel2.TabIndex = 5;
    this.Label5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(80 /*0x50*/, 4);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(115, 16 /*0x10*/);
    this.Label5.TabIndex = 83;
    this.Label5.Text = "Select Accounts";
    this.Label1.Font = new Font("Tahoma", 8f);
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(80 /*0x50*/, 18);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(584, 40);
    this.Label1.TabIndex = 82;
    this.Label1.Text = componentResourceManager.GetString("Label1.Text");
    this.label3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label3.Dock = DockStyle.Bottom;
    this.label3.ForeColor = Color.Gray;
    this.label3.Location = new Point(0, 67);
    this.label3.Name = "label3";
    this.label3.Size = new Size(674, 1);
    this.label3.TabIndex = 81;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(72, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 85;
    this.PictureBox1.TabStop = false;
    this.GLAccountImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("GLAccountImages.ImageStream");
    this.GLAccountImages.TransparentColor = Color.Transparent;
    this.GLAccountImages.Images.SetKeyName(0, "");
    this.GLAccountImages.Images.SetKeyName(1, "");
    this.GLAccountImages.Images.SetKeyName(2, "");
    this.Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.btnOk);
    this.Panel1.Controls.Add((Control) this.btnCancel);
    this.Panel1.Location = new Point(0, 424);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(674, 48 /*0x30*/);
    this.Panel1.TabIndex = 6;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(0, 72);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(136, 16 /*0x10*/);
    this.Label2.TabIndex = 83;
    this.Label2.Text = "Available Accounts";
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(384, 72);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(136, 16 /*0x10*/);
    this.Label4.TabIndex = 84;
    this.Label4.Text = "Selected Accounts";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(674, 472);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.treeSelectedGlAcct);
    this.Controls.Add((Control) this.btnRemove);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.treeGlAcct);
    this.Controls.Add((Control) this.Panel2);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formGLAccountSelection);
    this.ShowInTaskbar = false;
    this.Text = "Select Accounts";
    ((ISupportInitialize) this.treeGlAcct).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.btnRemove).EndInit();
    ((ISupportInitialize) this.treeSelectedGlAcct).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private formGLAccountSelection()
  {
    this.Load += new EventHandler(this.GLAccountSelection_Load);
    this.cmd = new SqlCommand();
    this.DoCopyTreesBeforeEdit = true;
    this.InitializeComponent();
  }

  public formGLAccountSelection(UltraTree treeView, int companyId)
  {
    this.Load += new EventHandler(this.GLAccountSelection_Load);
    this.cmd = new SqlCommand();
    this.DoCopyTreesBeforeEdit = true;
    this.InitializeComponent();
    this.GLCompanyID = companyId;
    int num = treeView.Nodes.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      ((SubObjectBase) treeView.Nodes[index]).Tag = (object) index;
      this.AddTreeStructureToTree((GLTreeNode) treeView.Nodes[index], (GLTreeNode) null, (UltraTree) this.treeGlAcct);
    }
  }

  public formGLAccountSelection(UltraTree treeView, int companyID, int glAccount)
  {
    this.Load += new EventHandler(this.GLAccountSelection_Load);
    this.cmd = new SqlCommand();
    this.DoCopyTreesBeforeEdit = true;
    this.InitializeComponent();
    this.GLCompanyID = companyID;
    int num = treeView.Nodes.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      ((SubObjectBase) treeView.Nodes[index]).Tag = (object) index;
      this.AddTreeStructureToTree((GLTreeNode) treeView.Nodes[index], (GLTreeNode) null, (UltraTree) this.treeGlAcct);
    }
    this.NodeExistsInNodesCollection(this.treeGlAcct.Nodes, Conversions.ToString(glAccount)).Selected = true;
    this.AddSelectedAccounts((UltraTree) this.treeGlAcct, (UltraTree) this.treeSelectedGlAcct);
  }

  private void GLAccountSelection_Load(object sender, EventArgs e)
  {
    this.DoCopyTreesBeforeEdit = true;
    if (this.treeGlAcct == null)
      return;
    this.treeGlAcct.BeforeExpand += new BeforeNodeChangedEventHandler(this.BeforeTreeNodeExpand);
    this.treeSelectedGlAcct.BeforeExpand += new BeforeNodeChangedEventHandler(this.BeforeTreeNodeExpand);
  }

  private void CloneTreeNodes()
  {
    this.tempSelectedGlAcctNodes = new ArrayList();
    this.tempTreeGlAcctNodes = new ArrayList();
    if (this.treeGlAcct != null && this.treeGlAcct.Nodes.Count != 0)
    {
      foreach (UltraTreeNode node in this.treeGlAcct.Nodes)
      {
        if (node.HasNodes && (!Versioned.IsNumeric((object) node.Key) || int.Parse(node.Key) < 0))
          ((GLTreeNode) node).CloneChildren = true;
        this.tempTreeGlAcctNodes.Add(RuntimeHelpers.GetObjectValue(node.Clone()));
      }
    }
    if (this.treeSelectedGlAcct == null || this.treeSelectedGlAcct.Nodes.Count == 0)
      return;
    foreach (UltraTreeNode node in this.treeSelectedGlAcct.Nodes)
    {
      if (node.HasNodes && (!Versioned.IsNumeric((object) node.Key) || int.Parse(node.Key) < 0))
        ((GLTreeNode) node).CloneChildren = true;
      this.tempSelectedGlAcctNodes.Add(RuntimeHelpers.GetObjectValue(node.Clone()));
    }
  }

  private void LoadChildAccounts(GLTreeNode GLNode, int GLAcctID)
  {
    this.cmd = new SqlCommand("spFin_getChildAccounts", new SqlConnection(CurrentUser.Instance.ConnectionString));
    this.cmd.CommandType = CommandType.StoredProcedure;
    try
    {
      this.cmd.Parameters.Clear();
      this.cmd.Parameters.AddWithValue("@searchtype", (object) 1);
      this.cmd.Parameters.AddWithValue("@classtype", (object) DBNull.Value);
      this.cmd.Parameters.AddWithValue("@glacctid", (object) GLAcctID);
      this.cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GLCompanyID);
      this.cmd.Parameters.AddWithValue("@showsystem", (object) -1);
      this.cmd.Connection.Open();
      SqlDataReader sqlDataReader = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        GLTreeNode glTreeNode = new GLTreeNode(Conversions.ToBoolean(sqlDataReader["controlacct"]));
        if (glTreeNode.IsControlNode)
        {
          glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[1]);
          glTreeNode.Expanded = false;
          glTreeNode.Nodes.Add("-1" + sqlDataReader["glacctid"].ToString(), "");
        }
        else
          glTreeNode.LeftImages.Add((object) this.GLAccountImages.Images[2]);
        glTreeNode.Key = sqlDataReader["glacctid"].ToString();
        glTreeNode.GLAccountShortName = sqlDataReader["shortname"].ToString();
        glTreeNode.GLAccountFullName = sqlDataReader["fullname"].ToString();
        glTreeNode.GLAccountID = Conversions.ToInteger(sqlDataReader["glacctid"]);
        GLNode.Nodes.Add((UltraTreeNode) glTreeNode);
      }
      sqlDataReader.Close();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the receivable accounts in to the drop down tree.\r\n\r\n" + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("An error has occurred while trying to load the receivable accounts in to the drop down tree.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (this.cmd.Connection.State != ConnectionState.Closed)
        this.cmd.Connection.Close();
      this.cmd.Connection.Dispose();
      this.cmd.Connection = (SqlConnection) null;
      this.cmd.Dispose();
      this.cmd = (SqlCommand) null;
    }
  }

  private void AddTreeStructureToTree(
    GLTreeNode sourceNode,
    GLTreeNode destinationNode,
    UltraTree DestinationTree)
  {
    if (destinationNode == null)
    {
      sourceNode.CloneChildren = true;
      DestinationTree.Nodes.Add(RuntimeHelpers.GetObjectValue(sourceNode.Clone()));
    }
    else
    {
      GLTreeNode destinationNode1 = (GLTreeNode) null;
      GLTreeNode sourceNode1 = (GLTreeNode) null;
      int num = sourceNode.Nodes.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (!Versioned.IsNumeric((object) sourceNode.Nodes[index].Key) || int.Parse(sourceNode.Nodes[index].Key) >= 0)
        {
          sourceNode1 = (GLTreeNode) sourceNode.Nodes[index];
          sourceNode1.CloneChildren = sourceNode.CloneChildren;
          destinationNode1 = this.NodeExistsInNodesCollection(destinationNode.Nodes, sourceNode1.Key);
        }
        if (destinationNode1 == null)
        {
          if (sourceNode1 != null && sourceNode1.HasNodes)
          {
            sourceNode1.CloneChildren = false;
            GLTreeNode destinationNode2 = (GLTreeNode) sourceNode1.Clone();
            destinationNode.Nodes.Add((UltraTreeNode) destinationNode2);
            this.AddTreeStructureToTree(sourceNode1, destinationNode2, DestinationTree);
          }
          else
            destinationNode.Nodes.Add(RuntimeHelpers.GetObjectValue(sourceNode.Nodes[index].Clone()));
        }
        else if (sourceNode1.HasNodes)
        {
          this.AddTreeStructureToTree(sourceNode1, destinationNode1, DestinationTree);
        }
        else
        {
          sourceNode1.CloneChildren = false;
          destinationNode1.Nodes.Add(RuntimeHelpers.GetObjectValue(sourceNode1.Clone()));
          break;
        }
      }
    }
  }

  private void AddSelectedAccounts(UltraTree SourceTree, UltraTree DestinationTree)
  {
    if (SourceTree.SelectedNodes == null | ((DisposableObjectCollectionBase) SourceTree.SelectedNodes).Count <= 0)
      return;
    if (SourceTree.SelectedNodes[0].IsRootLevelNode)
    {
      this.AddRootLevelNode(SourceTree.SelectedNodes[0], DestinationTree);
      SourceTree.SelectedNodes[0].Remove();
    }
    else
    {
      GLTreeNode sourceNode = this.BuildTreeStructure(true, (GLTreeNode) SourceTree.SelectedNodes[0]);
      UltraTreeNode destinationNode = (UltraTreeNode) this.NodeExistsInNodesCollection(DestinationTree.Nodes, sourceNode.Key);
      this.AddTreeStructureToTree(sourceNode, (GLTreeNode) destinationNode, DestinationTree);
      if (SourceTree.SelectedNodes[0].Parent.Nodes.Count == 1)
        this.RemoveNodeAndAncestors((GLTreeNode) SourceTree.SelectedNodes[0]);
      else
        SourceTree.SelectedNodes[0].Remove();
    }
  }

  private void AddRootLevelNode(UltraTreeNode selectedNode, UltraTree DestinationTree)
  {
    GLTreeNode destinationNode = this.NodeExistsInNodesCollection(DestinationTree.Nodes, selectedNode.Key);
    this.AddTreeStructureToTree((GLTreeNode) selectedNode, destinationNode, DestinationTree);
  }

  private void RemoveNodeAndAncestors(GLTreeNode node)
  {
    if (node == null)
      return;
    GLTreeNode parent = (GLTreeNode) node.Parent;
    if (parent == null)
    {
      node.Remove();
    }
    else
    {
      if (parent == null || parent.Nodes.Count != 1 && parent.Nodes.Count != 0)
        return;
      node.Remove();
      this.RemoveNodeAndAncestors(parent);
    }
  }

  private GLTreeNode BuildTreeStructure(bool IsFirstCall, GLTreeNode currentNode)
  {
    GLTreeNode glTreeNode1;
    if (currentNode.IsRootLevelNode)
    {
      currentNode.CloneChildren = false;
      glTreeNode1 = (GLTreeNode) currentNode.Clone();
    }
    else if (currentNode.HasNodes)
    {
      GLTreeNode glTreeNode2;
      GLTreeNode node;
      if (!IsFirstCall)
      {
        currentNode.CloneChildren = false;
        glTreeNode2 = (GLTreeNode) currentNode.Clone();
        glTreeNode2.Nodes.Clear();
        node = this.BuildTreeStructure(false, (GLTreeNode) currentNode.Parent);
      }
      else
      {
        currentNode.CloneChildren = true;
        glTreeNode2 = (GLTreeNode) currentNode.Clone();
        node = this.BuildTreeStructure(false, (GLTreeNode) currentNode.Parent);
      }
      if (node.HasNodes)
        this.FindTheOuterMostParentNode(node).Nodes.Add((UltraTreeNode) glTreeNode2);
      else
        node.Nodes.Add((UltraTreeNode) glTreeNode2);
      glTreeNode1 = node;
    }
    else
    {
      GLTreeNode node = this.BuildTreeStructure(false, (GLTreeNode) currentNode.Parent);
      currentNode.CloneChildren = false;
      if (node.HasNodes)
        this.FindTheOuterMostParentNode(node).Nodes.Add(RuntimeHelpers.GetObjectValue(currentNode.Clone()));
      else
        node.Nodes.Add(RuntimeHelpers.GetObjectValue(currentNode.Clone()));
      glTreeNode1 = node;
    }
    return glTreeNode1;
  }

  private UltraTreeNode FindTheOuterMostParentNode(GLTreeNode node)
  {
    int num = node.Nodes.Count - 1;
    UltraTreeNode outerMostParentNode;
    for (int index = 0; index <= num; ++index)
    {
      if (index == node.Nodes.Count - 1)
      {
        outerMostParentNode = !node.Nodes[index].HasNodes ? node.Nodes[index] : this.FindTheOuterMostParentNode((GLTreeNode) node.Nodes[index]);
        goto label_6;
      }
    }
    outerMostParentNode = (UltraTreeNode) null;
label_6:
    return outerMostParentNode;
  }

  private GLTreeNode NodeExistsInNodesCollection(TreeNodesCollection nodeCollection, string key)
  {
    GLTreeNode glTreeNode;
    foreach (UltraTreeNode node in nodeCollection)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(node.Key, key, false) == 0)
      {
        glTreeNode = (GLTreeNode) node;
        goto label_8;
      }
      if (node.HasNodes)
      {
        UltraTreeNode ultraTreeNode = (UltraTreeNode) this.NodeExistsInNodesCollection(node.Nodes, key);
        if (ultraTreeNode != null)
        {
          glTreeNode = (GLTreeNode) ultraTreeNode;
          goto label_8;
        }
      }
    }
    glTreeNode = (GLTreeNode) null;
label_8:
    return glTreeNode;
  }

  public void PreSelectAccounts(ArrayList l)
  {
    try
    {
      foreach (object obj in l)
      {
        int integer = Conversions.ToInteger(obj);
        if (!Information.IsNothing((object) this.NodeExistsInNodesCollection(this.treeGlAcct.Nodes, Conversions.ToString(integer))))
        {
          this.NodeExistsInNodesCollection(this.treeGlAcct.Nodes, Conversions.ToString(integer)).Selected = true;
          this.AddSelectedAccounts((UltraTree) this.treeGlAcct, (UltraTree) this.treeSelectedGlAcct);
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

  private void BeforeTreeNodeExpand(object sender, CancelableNodeEventArgs e)
  {
    this.NodeExpandHandler(e.TreeNode);
  }

  private void NodeExpandHandler(UltraTreeNode node)
  {
    if (node == null || node.HasNodes && (!Versioned.IsNumeric((object) node.Nodes[0].Key) || int.Parse(node.Nodes[0].Key) >= 0) || !((GLTreeNode) node).IsControlNode || ((GLTreeNode) node).GLAccountID == 0)
      return;
    this.Cursor = Cursors.WaitCursor;
    node.Nodes.Clear();
    this.LoadChildAccounts((GLTreeNode) node, ((GLTreeNode) node).GLAccountID);
    this.Cursor = Cursors.Default;
  }

  public void ReorderNodes(UltraTree tree)
  {
    int[] array = new int[5];
    UltraTreeNode[] ultraTreeNodeArray = new UltraTreeNode[5];
    short index1 = 0;
    do
    {
      ultraTreeNodeArray[(int) index1] = (UltraTreeNode) null;
      array[(int) index1] = -1;
      ++index1;
    }
    while (index1 <= (short) 4);
    short num1 = (short) (tree.Nodes.Count - 1);
    for (short index2 = 0; (int) index2 <= (int) num1; ++index2)
      array[(int) index2] = int.Parse(((SubObjectBase) tree.Nodes[(int) index2]).Tag.ToString());
    Array.Sort<int>(array);
    short index3 = 0;
    do
    {
      if (array[(int) index3] != -1)
        ultraTreeNodeArray[(int) index3] = this.GivenTagGetNode(tree, array[(int) index3]);
      ++index3;
    }
    while (index3 <= (short) 4);
    tree.Nodes.Clear();
    int num2 = (int) index3 - 1;
    for (int index4 = 0; index4 <= num2; ++index4)
    {
      if (ultraTreeNodeArray[index4] != null)
        tree.Nodes.Add(ultraTreeNodeArray[index4]);
    }
  }

  private UltraTreeNode GivenTagGetNode(UltraTree tree, int orderId)
  {
    UltraTreeNode node1;
    foreach (UltraTreeNode node2 in tree.Nodes)
    {
      if (int.Parse(((SubObjectBase) node2).Tag.ToString()) == orderId)
      {
        node1 = node2;
        goto label_5;
      }
    }
    node1 = (UltraTreeNode) null;
label_5:
    return node1;
  }

  public ArrayList SelectedGLAccounts
  {
    get
    {
      this.glAccounts = new ArrayList();
      foreach (GLTreeNode node in this.treeSelectedGlAcct.Nodes)
      {
        if (node.HasNodes)
        {
          this.NodeExpandHandler((UltraTreeNode) node);
          this.getselectedGLAccounts(node.Nodes);
        }
        else
        {
          this.glName = node.Text;
          this.glAccounts.Add((object) node.GLAccountID);
        }
      }
      return this.glAccounts;
    }
  }

  private void getselectedGLAccounts(TreeNodesCollection nodes)
  {
    foreach (UltraTreeNode node in nodes)
    {
      if (node.HasNodes)
      {
        this.NodeExpandHandler(node);
        this.getselectedGLAccounts(node.Nodes);
      }
      else
      {
        this.glName = node.Text;
        this.glAccounts.Add((object) ((GLTreeNode) node).GLAccountID);
      }
    }
  }

  public string GLAccountName
  {
    get
    {
      return this.glAccounts.Count != 1 ? (this.glAccounts.Count <= 1 ? string.Empty : "Multiple........") : this.glName;
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Hide();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    if (this.treeGlAcct != null && this.tempTreeGlAcctNodes != null)
    {
      this.treeGlAcct.Nodes.Clear();
      int num = this.tempTreeGlAcctNodes.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.treeGlAcct.Nodes.Add(RuntimeHelpers.GetObjectValue(this.tempTreeGlAcctNodes[index]));
    }
    if (this.treeSelectedGlAcct != null && this.tempSelectedGlAcctNodes != null)
    {
      this.treeSelectedGlAcct.Nodes.Clear();
      int num = this.tempSelectedGlAcctNodes.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.treeSelectedGlAcct.Nodes.Add(RuntimeHelpers.GetObjectValue(this.tempSelectedGlAcctNodes[index]));
    }
    this.DialogResult = DialogResult.Cancel;
    this.Hide();
  }

  private void BtnRemove_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this.AddRemoveHandler((UltraTree) this.treeSelectedGlAcct, (UltraTree) this.treeGlAcct);
    this.Cursor = Cursors.Default;
  }

  private void BtnAdd_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this.AddRemoveHandler((UltraTree) this.treeGlAcct, (UltraTree) this.treeSelectedGlAcct);
    this.Cursor = Cursors.Default;
  }

  private void AddRemoveHandler(UltraTree SourceTree, UltraTree DestinationTree)
  {
    if (this.DoCopyTreesBeforeEdit)
    {
      this.DoCopyTreesBeforeEdit = false;
      this.CloneTreeNodes();
    }
    this.AddSelectedAccounts(SourceTree, DestinationTree);
    if (DestinationTree.Nodes.Count <= 1)
      return;
    this.ReorderNodes(DestinationTree);
  }

  public void ResetTreesToOrginalState()
  {
    if (this.treeSelectedGlAcct == null | this.treeSelectedGlAcct.Nodes.Count > 0)
    {
      int num = this.treeSelectedGlAcct.Nodes.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        this.treeSelectedGlAcct.Nodes[0].Selected = true;
        this.AddSelectedAccounts((UltraTree) this.treeSelectedGlAcct, (UltraTree) this.treeGlAcct);
      }
    }
    this.ReorderNodes((UltraTree) this.treeGlAcct);
  }
}
