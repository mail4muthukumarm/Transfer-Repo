// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormSecurityGroupProperties
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinTabControl;
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
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

[SecureResource("{68A07014-7444-4ccd-AE9B-32C45AB9AA01}", "Modify Group Name.", "Controls the ability of the user to modify the group's name.", "Security Administration")]
[SecureResource("{CA03D9AA-8385-4b32-A7C7-FF4D78869188}", "Modify Group Description.", "Controls the ability of the user to modify the group's description.", "Security Administration")]
[SecureResource("{2FBA8DEB-75DA-464e-923D-BC33FA9C0E02}", "Add/Delete members from the group.", "Controls the ability of the user to modify what users belong to the given group", "Security Administration")]
public class FormSecurityGroupProperties : Form
{
  internal const string SecurityIDModifyGroupDescription = "{CA03D9AA-8385-4b32-A7C7-FF4D78869188}";
  internal const string SecurityIDAddDeleteGroupMembership = "{2FBA8DEB-75DA-464e-923D-BC33FA9C0E02}";
  internal const string SecurityIDAddDeleteGroupName = "{68A07014-7444-4ccd-AE9B-32C45AB9AA01}";
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private Panel Panel1;
  private MGATextBox txtDescription;
  private UltraTabControl UltraTabControl1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private PictureBox PictureBox1;
  private Label Label3;
  private SqlDataAdapter daUserGroups;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlDataAdapter daUsers;
  private SqlCommand SqlSelectCommand2;
  private SqlConnection cnSQL;
  private SqlDataAdapter daGroups;
  private SqlCommand SqlSelectCommand3;
  private dsSecurityGroupProperties DsSecurityGroupProperties;
  private ImageList smImgs;
  private MGATextBox txtGroupName;
  private bool _userGroupsFilled;
  private bool _usersFilled;
  private Guid _groupGuid;
  private bool _changesApplied;
  private Guid _adminGroupGuid;

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  private virtual MGAButton btnRemove
  {
    get => this._btnRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemove_Click);
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

  private virtual MGAButton btnAdd
  {
    get => this._btnAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
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

  private virtual ListView lvMembers
  {
    get => this._lvMembers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lvMembers_SelectedIndexChanged);
      ListView lvMembers1 = this._lvMembers;
      if (lvMembers1 != null)
        lvMembers1.SelectedIndexChanged -= eventHandler;
      this._lvMembers = value;
      ListView lvMembers2 = this._lvMembers;
      if (lvMembers2 == null)
        return;
      lvMembers2.SelectedIndexChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSecurityGroupProperties));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraTab ultraTab = new UltraTab();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.txtGroupName = new MGATextBox();
    this.Label3 = new Label();
    this.PictureBox1 = new PictureBox();
    this.Panel1 = new Panel();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.lvMembers = new ListView();
    this.smImgs = new ImageList(this.components);
    this.txtDescription = new MGATextBox();
    this.Label1 = new Label();
    this.btnAdd = new MGAButton();
    this.btnRemove = new MGAButton();
    this.Label2 = new Label();
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.daUserGroups = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daGroups = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.DsSecurityGroupProperties = new dsSecurityGroupProperties();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtGroupName).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.btnRemove).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.DsSecurityGroupProperties.BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtGroupName);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.PictureBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Panel1);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 22);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(374, 361);
    ((Control) this.txtGroupName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtGroupName).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtGroupName).BackColor = Color.White;
    ((Control) this.txtGroupName).Location = new Point(80 /*0x50*/, 16 /*0x10*/);
    ((TextEditorControlBase) this.txtGroupName).MaxLength = 50;
    this.txtGroupName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtGroupName).Name = "txtGroupName";
    ((Control) this.txtGroupName).Size = new Size(282, 20);
    ((Control) this.txtGroupName).TabIndex = 15;
    ((UltraControlBase) this.txtGroupName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGroupName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.BorderStyle = BorderStyle.FixedSingle;
    this.Label3.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(346, 1);
    this.Label3.TabIndex = 14;
    this.PictureBox1.BackColor = Color.Transparent;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(16 /*0x10*/, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(40, 40);
    this.PictureBox1.TabIndex = 13;
    this.PictureBox1.TabStop = false;
    this.Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.MgaGroupBox1);
    this.Panel1.Controls.Add((Control) this.txtDescription);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.btnAdd);
    this.Panel1.Controls.Add((Control) this.btnRemove);
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Location = new Point(8, 64 /*0x40*/);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(354, 289);
    this.Panel1.TabIndex = 12;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lvMembers);
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ForegroundAlpha = (Alpha) 2;
    appearance3.ImageAlpha = (Alpha) 2;
    appearance3.ImageBackground = (Image) componentResourceManager.GetObject("Appearance3.ImageBackground");
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Location = new Point(68, 40);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(282, 200);
    ((Control) this.MgaGroupBox1).TabIndex = 10;
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.lvMembers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lvMembers.BorderStyle = BorderStyle.None;
    this.lvMembers.LargeImageList = this.smImgs;
    this.lvMembers.Location = new Point(4, 3);
    this.lvMembers.Name = "lvMembers";
    this.lvMembers.Size = new Size(273, 192 /*0xC0*/);
    this.lvMembers.SmallImageList = this.smImgs;
    this.lvMembers.Sorting = System.Windows.Forms.SortOrder.Ascending;
    this.lvMembers.TabIndex = 9;
    this.lvMembers.UseCompatibleStateImageBehavior = false;
    this.lvMembers.View = View.List;
    this.smImgs.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("smImgs.ImageStream");
    this.smImgs.TransparentColor = Color.Magenta;
    this.smImgs.Images.SetKeyName(0, "");
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).Location = new Point(68, 8);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 150;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(282, 20);
    ((Control) this.txtDescription).TabIndex = 0;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 40);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(50, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Members";
    ((Control) this.btnAdd).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnAdd).Location = new Point(8, 257);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnAdd).TabIndex = 3;
    ((ControlBase) this.btnAdd).Text = "Add";
    this.btnAdd.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRemove).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnRemove).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnRemove).Location = new Point(96 /*0x60*/, 257);
    ((Control) this.btnRemove).Name = "btnRemove";
    ((Control) this.btnRemove).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnRemove).TabIndex = 4;
    ((ControlBase) this.btnRemove).Text = "Remove...";
    this.btnRemove.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(60, 13);
    this.Label2.TabIndex = 7;
    this.Label2.Text = "Description";
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnOK).Location = new Point(224 /*0xE0*/, 400);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOK).TabIndex = 1;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnCancel).Location = new Point(309, 400);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 2;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraTabControlBase) this.UltraTabControl1).BackColorInternal = Color.WhiteSmoke;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Location = new Point(8, 8);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(376, 384);
    ((Control) this.UltraTabControl1).TabIndex = 13;
    ultraTab.TabPage = this.UltraTabPageControl1;
    ultraTab.Text = "General";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab
    });
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(374, 361);
    this.daUserGroups.DeleteCommand = this.SqlDeleteCommand1;
    this.daUserGroups.InsertCommand = this.SqlInsertCommand1;
    this.daUserGroups.SelectCommand = this.SqlSelectCommand1;
    this.daUserGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSecurityUserGroups", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("GroupGuid", "GroupGuid")
      })
    });
    this.daUserGroups.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblSecurityUserGroups WHERE (GroupGuid = @Original_GroupGuid) AND (UserGuid = @Original_UserGuid)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGuid", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblSecurityUserGroups(UserGuid, GroupGuid) VALUES (@UserGuid, @GroupGUID); SELECT UserGuid, GroupGuid FROM tblSecurityUserGroups WHERE (GroupGuid = @GroupGuid) AND (UserGuid = @UserGuid)";
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"),
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid")
    });
    this.SqlSelectCommand1.CommandText = "SELECT UserGuid, GroupGuid FROM tblSecurityUserGroups WHERE (GroupGuid = @GroupGUID)";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGuid"),
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid"),
      new SqlParameter("@Original_GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "GroupGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UserGuid", DataRowVersion.Original, (object) null)
    });
    this.daUsers.SelectCommand = this.SqlSelectCommand2;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGuid", "UserGuid"),
        new DataColumnMapping("Expr1", "Expr1")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT UserGuid, LastName + ', ' + FirstName AS FullName FROM tblUsers";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.daGroups.SelectCommand = this.SqlSelectCommand3;
    this.daGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSecurityGroups", new DataColumnMapping[3]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("GroupGuid", "GroupGuid"),
        new DataColumnMapping("Description", "Description")
      })
    });
    this.SqlSelectCommand3.CommandText = "SELECT Name, GroupGuid, Description FROM tblSecurityGroups WHERE (GroupGuid = @GroupGuid)";
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@GroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "GroupGuid")
    });
    this.DsSecurityGroupProperties.DataSetName = "dsSecurityGroupProperties";
    this.DsSecurityGroupProperties.Locale = new CultureInfo("en-US");
    this.DsSecurityGroupProperties.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(392, 430);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (FormSecurityGroupProperties);
    this.Text = "Group Properties";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtGroupName).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.btnRemove).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.DsSecurityGroupProperties.EndInit();
    this.ResumeLayout(false);
  }

  public FormSecurityGroupProperties(Guid groupGuid)
  {
    this.Load += new EventHandler(this.FormSecurityGroupProperties_Load);
    this.Closing += new CancelEventHandler(this.FormSecurityGroupProperties_Closing);
    this._adminGroupGuid = Guid.Empty;
    this.InitializeComponent();
    this._groupGuid = groupGuid;
  }

  private void FormSecurityGroupProperties_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = Database.Instance.ConnectionString;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this._adminGroupGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT GroupGuid FROM dbo.tblSecurityGroups WHERE Name = @GroupName", new object[2]
    {
      (object) "@GroupName",
      (object) "Administrators"
    });
    this.daGroups.SelectCommand.Parameters["@GroupGuid"].Value = (object) this._groupGuid;
    this.daUserGroups.SelectCommand.Parameters["@GroupGuid"].Value = (object) this._groupGuid;
    DatabaseQueryMultithreadedDataAdapter multithreadedDataAdapter = Database.Instance.QueryMultithreadedDataAdapter;
    multithreadedDataAdapter.PerformTableQuery((Control) this, "daGroups", this.daGroups, new TableQueryMultithreadEventHandler(this.initialTableFills_tableLoaded), (DataTable) this.DsSecurityGroupProperties.tblSecurityGroups);
    multithreadedDataAdapter.PerformTableQuery((Control) this, "daUserGroups", this.daUserGroups, new TableQueryMultithreadEventHandler(this.initialTableFills_tableLoaded), (DataTable) this.DsSecurityGroupProperties.tblSecurityUserGroups);
    multithreadedDataAdapter.PerformTableQuery((Control) this, "daUsers", this.daUsers, new TableQueryMultithreadEventHandler(this.initialTableFills_tableLoaded), (DataTable) this.DsSecurityGroupProperties.tblUsers);
    if (!SecurityManager.Instance.AssertPermission("{2FBA8DEB-75DA-464e-923D-BC33FA9C0E02}"))
    {
      ((Control) this.btnRemove).Visible = false;
      ((Control) this.btnAdd).Visible = false;
    }
    if (!SecurityManager.Instance.AssertPermission("{CA03D9AA-8385-4b32-A7C7-FF4D78869188}"))
      ((EditorButtonControlBase) this.txtDescription).ReadOnly = true;
    if (SecurityManager.Instance.AssertPermission("{68A07014-7444-4ccd-AE9B-32C45AB9AA01}"))
      return;
    ((EditorButtonControlBase) this.txtGroupName).ReadOnly = true;
  }

  private void initialTableFills_tableLoaded(object sender, TableQueryMultithreadEventArgs e)
  {
    string Left = e.Key.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "daGroups", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "daUserGroups", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "daUsers", false) != 0)
          return;
        this._usersFilled = true;
        this.InitializeMembersList();
      }
      else
      {
        this._userGroupsFilled = true;
        this.InitializeMembersList();
      }
    }
    else
    {
      ((TextEditorControlBase) this.txtGroupName).Text = Conversions.ToString(e.Table.Rows[0]["Name"]);
      ((TextEditorControlBase) this.txtDescription).Text = Conversions.ToString(e.Table.Rows[0]["Description"]);
    }
  }

  private void InitializeMembersList()
  {
    if (this._userGroupsFilled && this._usersFilled)
    {
      this.lvMembers.Items.Clear();
      try
      {
        foreach (dsSecurityGroupProperties.tblSecurityUserGroupsRow securityUserGroup in (TypedTableBase<dsSecurityGroupProperties.tblSecurityUserGroupsRow>) this.DsSecurityGroupProperties.tblSecurityUserGroups)
          this.lvMembers.Items.Add((ListViewItem) new FormSecurityGroupProperties.UserListViewItem(this.DsSecurityGroupProperties.tblUsers.FindByUserGuid(securityUserGroup.UserGuid)));
      }
      finally
      {
        IEnumerator<dsSecurityGroupProperties.tblSecurityUserGroupsRow> enumerator;
        enumerator?.Dispose();
      }
    }
    ((Control) this.btnRemove).Enabled = this.EnableRemove;
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this.GroupHasChanges)
      this.ApplyChanges();
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void FormSecurityGroupProperties_Closing(object sender, CancelEventArgs e)
  {
    if (this.GroupHasChanges)
    {
      switch (MessageBox.Show(SR.GetString("SECURITY_GROUP_PROPERTIES_SAVE_CHANGES"), SR.GetString("SECURITY_GROUP_PROPERTIES_SAVE_CHANGES_CAPTION"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          if (!this.ApplyChanges())
          {
            e.Cancel = true;
            break;
          }
          break;
      }
    }
    if (e.Cancel || this.GroupHasChanges)
      return;
    this.DialogResult = DialogResult.OK;
  }

  private bool EnableRemove => this.lvMembers.SelectedItems.Count > 0;

  private void lvMembers_SelectedIndexChanged(object sender, EventArgs e)
  {
    ((Control) this.btnRemove).Enabled = this.EnableRemove;
  }

  private void btnRemove_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show(SR.GetString("SECURITY_GROUP_PROPERTIES"), SR.GetString("SECURITY_GROUP_PROPERTIES_CAPTION"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    if (this._groupGuid.Equals(this._adminGroupGuid) && this.lvMembers.Items.Count <= 1)
    {
      int num = (int) MessageBox.Show(SR.GetString("SECURITY_GROUP_ONE_ADMIN"), SR.GetString("SECURITY_GROUP_ONE_ADMIN_CAPTION"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      FormSecurityGroupProperties.UserListViewItem userListViewItem = (FormSecurityGroupProperties.UserListViewItem) null;
      try
      {
        foreach (FormSecurityGroupProperties.UserListViewItem selectedItem in this.lvMembers.SelectedItems)
        {
          this.lvMembers.Items.Remove((ListViewItem) selectedItem);
          userListViewItem = selectedItem;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (!this._groupGuid.Equals(this._adminGroupGuid) || this.lvMembers.Items.Count != 0)
        return;
      this.lvMembers.Items.Add((ListViewItem) userListViewItem);
    }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (FormSecurityGroupProperties.UserListViewItem userListViewItem in this.lvMembers.Items)
        guidList.Add(userListViewItem.UserGuid);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    FormSecurityUserChooser securityUserChooser = new FormSecurityUserChooser(guidList.ToArray());
    try
    {
      if (securityUserChooser.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      try
      {
        foreach (Guid UserGuid in securityUserChooser.UsersPicked)
          this.lvMembers.Items.Add((ListViewItem) new FormSecurityGroupProperties.UserListViewItem(this.DsSecurityGroupProperties.tblUsers.FindByUserGuid(UserGuid)));
      }
      finally
      {
        List<Guid>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      securityUserChooser.Dispose();
    }
  }

  internal void ExternalAddUser(Guid userGuid)
  {
    this.lvMembers.Items.Add((ListViewItem) new FormSecurityGroupProperties.UserListViewItem(this.DsSecurityGroupProperties.tblUsers.FindByUserGuid(userGuid)));
  }

  private bool MemberListChanged
  {
    get
    {
      bool memberListChanged;
      if (this._changesApplied)
        memberListChanged = false;
      else if (this.DsSecurityGroupProperties.tblSecurityUserGroups.Count != this.lvMembers.Items.Count)
      {
        memberListChanged = true;
      }
      else
      {
        try
        {
          foreach (FormSecurityGroupProperties.UserListViewItem userListViewItem in this.lvMembers.Items)
          {
            if (this.DsSecurityGroupProperties.tblSecurityUserGroups.FindByUserGuidGroupGuid(userListViewItem.UserGuid, this._groupGuid) == null)
            {
              memberListChanged = true;
              goto label_12;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        memberListChanged = false;
      }
label_12:
      return memberListChanged;
    }
  }

  private bool DescriptionHasChanges
  {
    get
    {
      return this.DsSecurityGroupProperties.tblSecurityGroups.Rows.Count != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDescription).Text, ((dsSecurityGroupProperties.tblSecurityGroupsRow) this.DsSecurityGroupProperties.tblSecurityGroups.Rows[0]).Description, false) != 0;
    }
  }

  private bool GroupNameHasChanges
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtGroupName).Text, ((dsSecurityGroupProperties.tblSecurityGroupsRow) this.DsSecurityGroupProperties.tblSecurityGroups.Rows[0]).Name, false) != 0;
    }
  }

  private bool GroupHasChanges
  {
    get
    {
      return !this._changesApplied && (this.DescriptionHasChanges || this.MemberListChanged || this.GroupNameHasChanges);
    }
  }

  private bool UserIsAMember(Guid userGuid)
  {
    bool flag;
    try
    {
      foreach (FormSecurityGroupProperties.UserListViewItem userListViewItem in this.lvMembers.Items)
      {
        if (userListViewItem.UserGuid.Equals(userGuid))
        {
          flag = true;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_8:
    return flag;
  }

  private bool ApplyChanges()
  {
    return Conversions.ToBoolean(Database.Instance.PerformQuerySet(new Database.QuerySetEventHandler(this.ApplyChanges_QuerySet)));
  }

  private object ApplyChanges_QuerySet(object sender, QuerySetHandlerEventArgs e)
  {
    object obj;
    try
    {
      if (this.GroupNameHasChanges)
        e.Database.QueryText.PerformNonQuery("UPDATE tblSecurityGroups SET Name = @Name WHERE GroupGuid = @GroupGuid", (object) "@GroupGuid", (object) this._groupGuid, (object) "@Name", (object) ((TextEditorControlBase) this.txtGroupName).Text);
      if (this.DescriptionHasChanges)
        e.Database.QueryText.PerformNonQuery("UPDATE tblSecurityGroups SET Description = @Description WHERE GroupGuid = @GroupGuid", (object) "@GroupGuid", (object) this._groupGuid, (object) "@Description", (object) ((TextEditorControlBase) this.txtDescription).Text);
      if (this.MemberListChanged)
      {
        try
        {
          foreach (dsSecurityGroupProperties.tblSecurityUserGroupsRow securityUserGroup in (TypedTableBase<dsSecurityGroupProperties.tblSecurityUserGroupsRow>) this.DsSecurityGroupProperties.tblSecurityUserGroups)
          {
            if (!this.UserIsAMember(securityUserGroup.UserGuid))
              e.Database.QueryText.PerformNonQuery("DELETE FROM tblSecurityUserGroups WHERE GroupGuid = @GroupGuid AND UserGuid = @UserGuid", (object) "@GroupGuid", (object) this._groupGuid, (object) "@UserGuid", (object) securityUserGroup.UserGuid);
          }
        }
        finally
        {
          IEnumerator<dsSecurityGroupProperties.tblSecurityUserGroupsRow> enumerator;
          enumerator?.Dispose();
        }
        try
        {
          foreach (FormSecurityGroupProperties.UserListViewItem userListViewItem in this.lvMembers.Items)
          {
            if (this.DsSecurityGroupProperties.tblSecurityUserGroups.FindByUserGuidGroupGuid(userListViewItem.UserGuid, this._groupGuid) == null)
              e.Database.QueryText.PerformNonQuery("INSERT INTO tblSecurityUserGroups (UserGuid, GroupGuid) VALUES (@UserGuid, @GroupGuid)", (object) "@UserGuid", (object) userListViewItem.UserGuid, (object) "@GroupGuid", (object) this._groupGuid);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      this._changesApplied = true;
      obj = (object) true;
    }
    catch (DatabaseException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show(ex.Message);
      obj = (object) false;
      ProjectData.ClearProjectError();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show(ex.Message);
      obj = (object) false;
      ProjectData.ClearProjectError();
    }
    return obj;
  }

  private enum ImageIndexes
  {
    User,
  }

  private sealed class UserListViewItem : ListViewItem
  {
    private Guid _userGuid;

    public UserListViewItem(dsSecurityGroupProperties.tblUsersRow row)
      : base(row.FullName)
    {
      this.ImageIndex = 0;
      this._userGuid = row.UserGuid;
    }

    public Guid UserGuid => this._userGuid;
  }
}
