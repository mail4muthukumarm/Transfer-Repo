// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.FormSecurityManagementNewGroup
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
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
namespace MGASystems.IMS.Security;

public class FormSecurityManagementNewGroup : Form
{
  private IContainer components;
  private MGATextBox txtGroupName;
  private Label Label1;
  private ErrorProvider ErrorProvider1;
  private Label Label2;
  private MGATextBox txtDescription;

  public FormSecurityManagementNewGroup()
  {
    this.Load += new EventHandler(this.FormSecurityManagementNewGroup_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnClose
  {
    get => this._btnClose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClose_Click);
      MGAButton btnClose1 = this._btnClose;
      if (btnClose1 != null)
        ((Control) btnClose1).Click -= eventHandler;
      this._btnClose = value;
      MGAButton btnClose2 = this._btnClose;
      if (btnClose2 == null)
        return;
      ((Control) btnClose2).Click += eventHandler;
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

  [field: AccessedThroughProperty("cboCopyPermissionsFrom")]
  internal virtual MGASimpleComboBox cboCopyPermissionsFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.txtGroupName = new MGATextBox();
    this.Label1 = new Label();
    this.btnClose = new MGAButton();
    this.btnAdd = new MGAButton();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.txtDescription = new MGATextBox();
    this.Label2 = new Label();
    this.cboCopyPermissionsFrom = new MGASimpleComboBox();
    this.Label3 = new Label();
    ((ISupportInitialize) this.txtGroupName).BeginInit();
    ((ISupportInitialize) this.btnClose).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.cboCopyPermissionsFrom).BeginInit();
    this.SuspendLayout();
    ((Control) this.txtGroupName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtGroupName).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtGroupName).BackColor = Color.White;
    ((Control) this.txtGroupName).Location = new Point(8, 24);
    ((TextEditorControlBase) this.txtGroupName).MaxLength = 50;
    ((Control) this.txtGroupName).Name = "txtGroupName";
    ((Control) this.txtGroupName).Size = new Size(344, 20);
    ((Control) this.txtGroupName).TabIndex = 0;
    ((TextEditorControlBase) this.txtGroupName).Text = "New Group";
    ((UltraControlBase) this.txtGroupName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtGroupName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(66, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Group Name";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnClose).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnClose).Location = new Point(280, 256 /*0x0100*/);
    ((Control) this.btnClose).Name = "btnClose";
    ((Control) this.btnClose).Size = new Size(72, 24);
    ((Control) this.btnClose).TabIndex = 3;
    ((ControlBase) this.btnClose).Text = "Close";
    this.btnClose.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnAdd).Location = new Point(192 /*0xC0*/, 256 /*0x0100*/);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(72, 24);
    ((Control) this.btnAdd).TabIndex = 2;
    ((ControlBase) this.btnAdd).Text = "Add";
    this.btnAdd.UseOSThemes = (DefaultableBoolean) 2;
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).Location = new Point(8, 64 /*0x40*/);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 150;
    this.txtDescription.Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(344, 144 /*0x90*/);
    ((Control) this.txtDescription).TabIndex = 1;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 48 /*0x30*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(60, 13);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Description";
    this.cboCopyPermissionsFrom.CharacterCasing = CharacterCasing.Normal;
    this.cboCopyPermissionsFrom.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCopyPermissionsFrom).Location = new Point(8, 224 /*0xE0*/);
    ((Control) this.cboCopyPermissionsFrom).Name = "cboCopyPermissionsFrom";
    ((Control) this.cboCopyPermissionsFrom).Size = new Size(344, 21);
    ((Control) this.cboCopyPermissionsFrom).TabIndex = 6;
    ((UltraControlBase) this.cboCopyPermissionsFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCopyPermissionsFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 208 /*0xD0*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(166, 13);
    this.Label3.TabIndex = 7;
    this.Label3.Text = "Copy Permissions From (optional)";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(370, 288);
    this.Controls.Add((Control) this.txtGroupName);
    this.Controls.Add((Control) this.txtDescription);
    this.Controls.Add((Control) this.cboCopyPermissionsFrom);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.btnClose);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormSecurityManagementNewGroup);
    this.ShowInTaskbar = false;
    this.Text = "New Security Group";
    ((ISupportInitialize) this.txtGroupName).EndInit();
    ((ISupportInitialize) this.btnClose).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.cboCopyPermissionsFrom).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtGroupName).Text, string.Empty, false) != 0)
      this.DialogResult = DialogResult.OK;
    else
      this.ErrorProvider1.SetError((Control) this.txtGroupName, "You must enter a valid group name.");
  }

  private void btnClose_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Abort;

  public string GroupName => ((TextEditorControlBase) this.txtGroupName).Text;

  public string GroupDescription => ((TextEditorControlBase) this.txtDescription).Text;

  public bool ShouldCopyGroupPermissions
  {
    get => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboCopyPermissionsFrom.Text, string.Empty, false) != 0;
  }

  public Guid CopyGroupPermissionGuid
  {
    get
    {
      object obj = this.cboCopyPermissionsFrom.Value;
      return obj == null ? new Guid() : (Guid) obj;
    }
  }

  private void FormSecurityManagementNewGroup_Load(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT [Name], GroupGUID FROM tblSecurityGroups UNION SELECT @EmptyName, @EmptyGuid", new object[4]
    {
      (object) "@EmptyName",
      (object) "",
      (object) "@EmptyGuid",
      (object) Guid.Empty
    });
    ((UltraDropDownBase) this.cboCopyPermissionsFrom).ValueMember = "GroupGUID";
    ((UltraDropDownBase) this.cboCopyPermissionsFrom).DisplayMember = "Name";
    ((UltraGridBase) this.cboCopyPermissionsFrom).DataSource = (object) dataTable;
    this.AcceptButton = (IButtonControl) this.btnAdd;
    this.CancelButton = (IButtonControl) this.btnClose;
    ((TextEditorControlBase) this.txtGroupName).SelectAll();
  }
}
