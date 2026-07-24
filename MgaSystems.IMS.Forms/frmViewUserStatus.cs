// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmViewUserStatus
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[SecureResource("{696B0409-970F-4993-8EB3-F5AD051BD0F4}", "Can View User Status", "Controls whether or not a user can 'View User Status' menu item.", "Users")]
public class frmViewUserStatus : Form
{
  private IContainer components;
  public const string CanViewUserStatus = "{696B0409-970F-4993-8EB3-F5AD051BD0F4}";

  public frmViewUserStatus()
  {
    this.Load += new EventHandler(this.frmViewUserStatus_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ugViewUserStatus")]
  internal virtual UltraGrid ugViewUserStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsViewUserStatus ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ViewUserStatus", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Name_LastFirst");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LoggedIn");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LastLogin");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Status");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.ugViewUserStatus = new UltraGrid();
    this.ds = new dsViewUserStatus();
    ((ISupportInitialize) this.ugViewUserStatus).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugViewUserStatus).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugViewUserStatus).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugViewUserStatus).DataSource = (object) this.ds.ViewUserStatus;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "User's Name";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 298;
    ultraGridColumn2.Format = "";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Logged In";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 70;
    ultraGridColumn3.Format = "MM/dd/yyyy hh:mm:ss";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Last Login";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 198;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugViewUserStatus).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((Control) this.ugViewUserStatus).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugViewUserStatus).Location = new Point(0, 0);
    ((Control) this.ugViewUserStatus).Name = "ugViewUserStatus";
    ((Control) this.ugViewUserStatus).Size = new Size(696, 456);
    ((Control) this.ugViewUserStatus).TabIndex = 1;
    ((UltraControlBase) this.ugViewUserStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugViewUserStatus).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsViewUserStatus";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(696, 446);
    this.Controls.Add((Control) this.ugViewUserStatus);
    this.Name = nameof (frmViewUserStatus);
    this.Text = "View User Status";
    ((ISupportInitialize) this.ugViewUserStatus).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private void frmViewUserStatus_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "ViewUserStatus"
    }, CommandType.Text, "SELECT tblUsers.Name_LastFirst, tblUsers.LoggedIn, tblUsers.LastLogin, lstStatus.Status FROM tblUsers (NOLOCK) INNER JOIN lstStatus ON dbo.tblUsers.StatusID = dbo.lstStatus.StatusID  ORDER BY tblUsers.Name_LastFirst");
  }
}
