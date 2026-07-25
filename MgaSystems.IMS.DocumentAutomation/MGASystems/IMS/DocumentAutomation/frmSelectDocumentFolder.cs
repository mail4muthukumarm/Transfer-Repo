// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmSelectDocumentFolder
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTree;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class frmSelectDocumentFolder : Form
{
  private IContainer components;
  private UltraTree UltraTree1;
  private Label Label1;
  private dsDocumentAutomation.tblDocumentFoldersDataTable _dtFolders;
  private bool _folderSelected;

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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Override @override = new Override();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectDocumentFolder));
    Appearance appearance3 = new Appearance();
    this.UltraTree1 = new UltraTree();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.Label1 = new Label();
    ((ISupportInitialize) this.UltraTree1).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTree1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.Gray;
    this.UltraTree1.Appearance = (AppearanceBase) appearance1;
    this.UltraTree1.HideSelection = false;
    ((Control) this.UltraTree1).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.UltraTree1).Name = "UltraTree1";
    this.UltraTree1.NodeConnectorStyle = (NodeConnectorStyle) 4;
    @override.NodeSpacingAfter = 2;
    @override.NodeSpacingBefore = 2;
    @override.SelectionType = (SelectType) 1;
    @override.ShowExpansionIndicator = (ShowExpansionIndicator) 2;
    this.UltraTree1.Override = @override;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.UltraTree1.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraTree1).Size = new Size(376, 344);
    ((Control) this.UltraTree1).TabIndex = 0;
    ((UltraControlBase) this.UltraTree1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraTree1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(296, 384);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 1;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(344, 384);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 2;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(351, 13);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Please select the folder you would like these documents to be placed in:";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(392, 437);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.UltraTree1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (frmSelectDocumentFolder);
    this.Text = "Select Document Folder";
    ((ISupportInitialize) this.UltraTree1).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmSelectDocumentFolder(
    dsDocumentAutomation.tblDocumentFoldersDataTable dtFolders)
  {
    this.Load += new EventHandler(this.frmSelectDocumentFolder_Load);
    if (dtFolders == null)
      throw new ArgumentNullException(nameof (dtFolders));
    this.InitializeComponent();
    this._dtFolders = dtFolders.Count != 0 ? dtFolders : throw new InvalidOperationException("dtFolders must contain all the system folders");
  }

  public frmSelectDocumentFolder(
    dsDocumentAutomation.tblDocumentFoldersDataTable dtFolders,
    string labelText)
  {
    this.Load += new EventHandler(this.frmSelectDocumentFolder_Load);
    if (dtFolders == null)
      throw new ArgumentNullException(nameof (dtFolders));
    this.InitializeComponent();
    this.Label1.Text = labelText;
    this._dtFolders = dtFolders.Count != 0 ? dtFolders : throw new InvalidOperationException("dtFolders must contain all the system folders");
  }

  public bool FolderSelected
  {
    get
    {
      return this._folderSelected && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.UltraTree1.SelectedNodes[0].Key, "-1", false) != 0;
    }
  }

  public int FolderID => Conversions.ToInteger(this.UltraTree1.SelectedNodes[0].Key);

  public string FolderName => this.UltraTree1.SelectedNodes[0].Text;

  private void frmSelectDocumentFolder_Load(object sender, EventArgs e)
  {
    this.UltraTree1.Nodes.Add("-1", "none");
    DataRow[] dataRowArray = this._dtFolders.Select("ParentFolderID IS NULL");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsDocumentAutomation.tblDocumentFoldersRow documentFoldersRow = (dsDocumentAutomation.tblDocumentFoldersRow) dataRowArray[index];
      this.UltraTree1.GetNodeByKey("-1").Nodes.Add(documentFoldersRow.FolderID.ToString(), documentFoldersRow.FolderName).LeftImages.Add((object) ImageCache.Instance.Folder);
      this.AddChildNodes(documentFoldersRow.FolderID);
      checked { ++index; }
    }
    this.UltraTree1.ExpandAll();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.UltraTree1.SelectedNodes).Count > 0)
      this._folderSelected = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void AddChildNodes(int folderID)
  {
    DataRow[] dataRowArray = this._dtFolders.Select("ParentFolderID=" + folderID.ToString());
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsDocumentAutomation.tblDocumentFoldersRow documentFoldersRow = (dsDocumentAutomation.tblDocumentFoldersRow) dataRowArray[index];
      this.UltraTree1.GetNodeByKey(folderID.ToString()).Nodes.Add(documentFoldersRow.FolderID.ToString(), documentFoldersRow.FolderName).LeftImages.Add((object) ImageCache.Instance.Folder);
      this.AddChildNodes(documentFoldersRow.FolderID);
      checked { ++index; }
    }
  }
}
