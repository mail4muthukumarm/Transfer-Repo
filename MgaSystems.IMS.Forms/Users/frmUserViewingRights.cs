// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Users.frmUserViewingRights
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Users;

[TestForm]
public class frmUserViewingRights : Form
{
  private IContainer components;
  private readonly int _userID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("gbUsers")]
  internal virtual UltraGroupBox gbUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("treeImages")]
  internal virtual ImageList treeImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsUserViewingRights ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("treeUsers")]
  internal virtual UltraTree treeUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Override @override = new Override();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUserViewingRights));
    this.gbUsers = new UltraGroupBox();
    this.treeUsers = new UltraTree();
    this.treeImages = new ImageList(this.components);
    this.Label1 = new Label();
    this.ds = new dsUserViewingRights();
    ((ISupportInitialize) this.gbUsers).BeginInit();
    ((Control) this.gbUsers).SuspendLayout();
    ((ISupportInitialize) this.treeUsers).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.gbUsers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gbUsers.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.gbUsers).Controls.Add((Control) this.treeUsers);
    appearance2.ForeColor = Color.Navy;
    this.gbUsers.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.gbUsers).Location = new Point(11, 45);
    ((Control) this.gbUsers).Name = "gbUsers";
    ((Control) this.gbUsers).Size = new Size(355, 425);
    ((Control) this.gbUsers).TabIndex = 5;
    this.gbUsers.Text = "Users";
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.treeUsers.Appearance = (AppearanceBase) appearance3;
    this.treeUsers.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.treeUsers).Dock = DockStyle.Fill;
    ((Control) this.treeUsers).Location = new Point(3, 17);
    ((Control) this.treeUsers).Name = "treeUsers";
    @override.NodeStyle = (NodeStyle) 1;
    this.treeUsers.Override = @override;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.treeUsers.ScrollBarLook = scrollBarLook;
    ((Control) this.treeUsers).Size = new Size(349, 405);
    ((Control) this.treeUsers).TabIndex = 0;
    ((UltraControlBase) this.treeUsers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.treeUsers).UseOsThemes = (DefaultableBoolean) 2;
    this.treeImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("treeImages.ImageStream");
    this.treeImages.TransparentColor = Color.Transparent;
    this.treeImages.Images.SetKeyName(0, "");
    this.treeImages.Images.SetKeyName(1, "");
    this.Label1.Location = new Point(10, 15);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(355, 30);
    this.Label1.TabIndex = 6;
    this.Label1.Text = "Please select the users and/or offices that {0} is authorized to view.";
    this.ds.DataSetName = "dsViewingRights";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(377, 481);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.gbUsers);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmUserViewingRights);
    this.Text = "User Viewing Rights";
    ((ISupportInitialize) this.gbUsers).EndInit();
    ((Control) this.gbUsers).ResumeLayout(false);
    ((ISupportInitialize) this.treeUsers).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmUserViewingRights()
    : this(4)
  {
  }

  public frmUserViewingRights(int userID)
  {
    this.Load += new EventHandler(this.frmUserViewingRights_Load);
    this.InitializeComponent();
    this._userID = userID;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUserViewingRights"
    }, CommandType.Text, "SELECT RightsID, UserID, ViewUserID FROM tblUserViewingRights WHERE (UserID = @UserID)", new object[2]
    {
      (object) "@UserID",
      (object) userID
    });
  }

  private void frmUserViewingRights_Load(object sender, EventArgs e)
  {
    this.FillUsersTree();
    this.Label1.Text = string.Format(this.Label1.Text, (object) $"{this.ds.viewUsersByOffice.Select("UserID=" + this._userID.ToString())[0]["FirstName"].ToString()} {this.ds.viewUsersByOffice.Select("UserID=" + this._userID.ToString())[0]["LastName"].ToString()}");
    this.treeUsers.AfterCheck += new AfterNodeChangedEventHandler(this.treeUsers_AfterCheck);
  }

  private void FillUsersTree()
  {
    this.treeUsers.Nodes.Clear();
    this.ds.viewUsersByOffice.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "viewUsersByOffice"
    }, CommandType.Text, "SELECT UserID, FirstName, LastName, Location, OfficeID FROM viewUsersByOffice WHERE UserID IS NOT NULL ORDER BY Location, LastName");
    string Right = string.Empty;
    UltraTreeNode ultraTreeNode1 = (UltraTreeNode) null;
    try
    {
      foreach (dsUserViewingRights.viewUsersByOfficeRow row in this.ds.viewUsersByOffice.Rows)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Location, Right, false) != 0)
        {
          ultraTreeNode1 = new UltraTreeNode(row.Location);
          ultraTreeNode1.LeftImages.Add((object) this.treeImages.Images[0]);
          this.treeUsers.Nodes.Add(ultraTreeNode1);
          ((SubObjectBase) ultraTreeNode1).Tag = (object) row.OfficeID;
        }
        UltraTreeNode ultraTreeNode2 = new UltraTreeNode($"{row.LastName}, {row.FirstName}");
        ultraTreeNode2.LeftImages.Add((object) this.treeImages.Images[1]);
        ((SubObjectBase) ultraTreeNode2).Tag = (object) row.UserID;
        ultraTreeNode2.Key = Guid.NewGuid().ToString();
        ultraTreeNode1.Nodes.Add(ultraTreeNode2);
        if (this.ds.tblUserViewingRights.Select("ViewUserID=" + row.UserID.ToString()).Length >= 1)
          ultraTreeNode2.CheckedState = CheckState.Checked;
        Right = row.Location;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    foreach (UltraTreeNode node1 in this.treeUsers.Nodes)
    {
      if (node1.Level == 0)
      {
        bool flag = true;
        foreach (UltraTreeNode node2 in node1.Nodes)
        {
          if (node2.CheckedState != CheckState.Checked)
          {
            flag = false;
            break;
          }
        }
        if (flag)
          node1.CheckedState = CheckState.Checked;
      }
    }
    this.treeUsers.ExpandAll();
  }

  private void treeUsers_AfterCheck(object sender, NodeEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    if (e.TreeNode.Level == 0)
    {
      foreach (UltraTreeNode node in e.TreeNode.Nodes)
      {
        node.CheckedState = e.TreeNode.CheckedState;
        this.SendNode(node);
      }
    }
    else
      this.SendNode(e.TreeNode);
    this.Cursor = Cursors.Default;
  }

  private void SendNode(UltraTreeNode node)
  {
    if (node.CheckedState == CheckState.Checked)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN EXISTS(SELECT * FROM tblUserViewingRights WHERE UserID=@UserID AND ViewUserID=@ViewUserID) THEN 1 ELSE 0 END", new object[4]
      {
        (object) "@UserID",
        (object) this._userID,
        (object) "@ViewUserID",
        ((SubObjectBase) node).Tag
      }));
      if ((Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? 0 : (objectValue.ToString().Equals("1") ? 1 : 0)) != 0)
        return;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblUserViewingRights(UserID, ViewUserID)VALUES(@UserID, @ViewUserID)", new object[4]
      {
        (object) "@UserID",
        (object) this._userID,
        (object) "@ViewUserID",
        ((SubObjectBase) node).Tag
      });
      CurrentUser.Instance.LogAction("Users Menu - Added rights to view userid: " + Conversions.ToString(((SubObjectBase) node).Tag), this._userID, Conversions.ToString(((SubObjectBase) node).Tag));
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserViewingRights WHERE UserID=@UserID AND ViewUserID=@ViewUserID", new object[4]
      {
        (object) "@UserID",
        (object) this._userID,
        (object) "@ViewUserID",
        ((SubObjectBase) node).Tag
      });
      CurrentUser.Instance.LogAction("Users Menu - Removed rights to view userid: " + Conversions.ToString(((SubObjectBase) node).Tag), this._userID, Conversions.ToString(((SubObjectBase) node).Tag));
    }
  }
}
