// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmAssociatedEntities
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
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
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmAssociatedEntities : Form
{
  private IContainer components;
  private Guid[] _documentGuids;
  private bool _saved;
  private int _emailAssociatedFolderID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnOK
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

  [field: AccessedThroughProperty("SqlDataAdapter1")]
  internal virtual SqlDataAdapter SqlDataAdapter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaStatusLook1")]
  internal virtual MGAStatusLook MgaStatusLook1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSelectFolder
  {
    get => this._lnkSelectFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectFolder_LinkClicked);
      LinkLabel lnkSelectFolder1 = this._lnkSelectFolder;
      if (lnkSelectFolder1 != null)
        lnkSelectFolder1.LinkClicked -= clickedEventHandler;
      this._lnkSelectFolder = value;
      LinkLabel lnkSelectFolder2 = this._lnkSelectFolder;
      if (lnkSelectFolder2 == null)
        return;
      lnkSelectFolder2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chklstEntities")]
  internal virtual MGACheckedListBox chklstEntities { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance = new Appearance();
    this.SqlSelectCommand1 = new SqlCommand();
    this.btnOK = new MGAButton();
    this.SqlDataAdapter1 = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.Label1 = new Label();
    this.chklstEntities = new MGACheckedListBox();
    this.MgaStatusLook1 = new MGAStatusLook(this.components);
    this.lnkSelectFolder = new LinkLabel();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.chklstEntities).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance;
    ((ControlBase) this.btnOK).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnOK).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnOK).Location = new Point(250, 232);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(40, 40);
    ((Control) this.btnOK).TabIndex = 8;
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
    this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand1;
    this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
    this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
    this.Label1.Location = new Point(2, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(230, 16 /*0x10*/);
    this.Label1.TabIndex = 6;
    this.Label1.Text = "Contacts associated with this item. (optional)";
    this.chklstEntities.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.chklstEntities.CheckOnClick = true;
    this.chklstEntities.ForeColor = Color.Black;
    this.chklstEntities.Location = new Point(2, 24);
    this.chklstEntities.MGAStyle = MGAStyles.Blue;
    this.chklstEntities.Name = "chklstEntities";
    this.chklstEntities.Size = new Size(288, 184);
    this.chklstEntities.TabIndex = 5;
    this.lnkSelectFolder.AutoSize = true;
    this.lnkSelectFolder.Location = new Point(-1, 251);
    this.lnkSelectFolder.Name = "lnkSelectFolder";
    this.lnkSelectFolder.Size = new Size(69, 13);
    this.lnkSelectFolder.TabIndex = 9;
    this.lnkSelectFolder.TabStop = true;
    this.lnkSelectFolder.Text = "Select Folder";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(292, 273);
    this.Controls.Add((Control) this.lnkSelectFolder);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.chklstEntities);
    this.Controls.Add((Control) this.btnOK);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAssociatedEntities);
    this.Text = "Select Recipients";
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.chklstEntities).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public int EmailAssociatedFolderID => this._emailAssociatedFolderID;

  public bool HasAssociatedEntites => this.chklstEntities.Items.Count > 0;

  public bool HasSelectedEntities => this.chklstEntities.SelectedItems.Count > 0;

  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public List<string> SelectedEmails => this.SelectedEntitiesToEmailArray();

  public bool Saved => this._saved;

  public frmAssociatedEntities(Guid documentGuid)
  {
    this.Load += new EventHandler(this.frmAssociatedEntities_Load);
    this._emailAssociatedFolderID = -1;
    this.InitializeComponent();
    this._documentGuids = new Guid[1]{ documentGuid };
    this.GetEntities();
  }

  public frmAssociatedEntities(Guid[] documentGuids)
  {
    this.Load += new EventHandler(this.frmAssociatedEntities_Load);
    this._emailAssociatedFolderID = -1;
    this.InitializeComponent();
    this._documentGuids = documentGuids;
    this.GetEntities();
  }

  private List<string> SelectedEntitiesToEmailArray()
  {
    List<string> emailArray = new List<string>();
    try
    {
      foreach (AssociatedEntity checkedItem in this.chklstEntities.CheckedItems)
        emailArray.Add(checkedItem.EmailAddress);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return emailArray;
  }

  private static string FormatGuidArrayForSQL(Guid[] documentGuids)
  {
    StringBuilder stringBuilder = new StringBuilder();
    Guid[] guidArray = documentGuids;
    int index = 0;
    while (index < guidArray.Length)
    {
      Guid guid = guidArray[index];
      stringBuilder.Append($"'{guid}',");
      checked { ++index; }
    }
    string str = stringBuilder.ToString();
    return str.Length <= 0 ? "''" : str.Remove(str.Length - 1, 1);
  }

  private void GetEntities()
  {
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery($"SELECT AssociatedEntityGuid, AssociatedEntityType, ControlGuid FROM tblDocumentAssociations (NOLOCK) WHERE (DocumentStoreGuid in ({frmAssociatedEntities.FormatGuidArrayForSQL(this._documentGuids)})) and  (not AssociatedEntityGuid is null) and (not AssociatedEntityType is null)");
    List<AssociatedEntity> associatedEntityList = new List<AssociatedEntity>();
    if (dataTable.Rows.Count <= 0)
      return;
    List<string> stringList = new List<string>();
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        try
        {
          foreach (DataRow row2 in Database.Instance.QuerySP.PerformTableQuery("DocumentSystem_GetEntityContacts", (object) "@ControlGuid", (object) Utility.IsNull<Guid>(RuntimeHelpers.GetObjectValue(row1["ControlGuid"]), Guid.Empty), (object) "@EntityGuid", (object) (Guid) row1["AssociatedEntityGuid"], (object) "@AssociatedEntityType", (object) Conversions.ToString(row1["AssociatedEntityType"])).Rows)
          {
            AssociatedEntity associatedEntity = new AssociatedEntity(row2["ContactEmail"].ToString(), row2["ContactTypeName"].ToString(), row2["ContactName"].ToString());
            string str = associatedEntity.EmailAddress + associatedEntity.ContactType + associatedEntity.ContactName;
            if (!stringList.Contains(str) && associatedEntity.EmailAddress.Trim().Length > 0)
            {
              stringList.Add(str);
              associatedEntityList.Add(associatedEntity);
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
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      List<AssociatedEntity> source1 = associatedEntityList;
      System.Func<AssociatedEntity, string> keySelector1;
      // ISSUE: reference to a compiler-generated field
      if (frmAssociatedEntities._Closure\u0024__.\u0024I60\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector1 = frmAssociatedEntities._Closure\u0024__.\u0024I60\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmAssociatedEntities._Closure\u0024__.\u0024I60\u002D0 = keySelector1 = (System.Func<AssociatedEntity, string>) ([SpecialName] (entity) => entity.ContactName);
      }
      IOrderedEnumerable<AssociatedEntity> source2 = source1.OrderBy<AssociatedEntity, string>(keySelector1);
      System.Func<AssociatedEntity, string> keySelector2;
      // ISSUE: reference to a compiler-generated field
      if (frmAssociatedEntities._Closure\u0024__.\u0024I60\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector2 = frmAssociatedEntities._Closure\u0024__.\u0024I60\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmAssociatedEntities._Closure\u0024__.\u0024I60\u002D1 = keySelector2 = (System.Func<AssociatedEntity, string>) ([SpecialName] (entity) => entity.ContactType);
      }
      foreach (object obj in (IEnumerable<AssociatedEntity>) source2.OrderBy<AssociatedEntity, string>(keySelector2))
        this.chklstEntities.Items.Add(obj);
    }
    finally
    {
      IEnumerator<AssociatedEntity> enumerator;
      enumerator?.Dispose();
    }
  }

  private void frmAssociatedEntities_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnOK).Appearance.Image = (object) ImageCache.Instance.Save;
    this.lnkSelectFolder.Visible = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AssociatedEntities.Email.ShowFolders");
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    this._saved = true;
    this.Close();
  }

  private void lnkSelectFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._emailAssociatedFolderID = -1;
    using (frmFetchDoc form = (frmFetchDoc) ObjectFactory.Instance.CreateForm(typeof (frmFetchDoc), new object[1]))
    {
      form.HideControl = true;
      int num = (int) form.ShowDialog();
      if (!form.HasFolderId)
        return;
      this._emailAssociatedFolderID = form.FolderId;
    }
  }
}
