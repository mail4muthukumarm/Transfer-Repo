// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormInspectionLogging
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormInspectionLogging : Form
{
  private IContainer components;
  private readonly int _LocationID;
  private readonly int _ControlNo;
  private readonly int _adminInspID;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtLogging", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ActionDate");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ugLogging = new UltraGrid();
    this.ds = new dsAdminInspReq();
    this.txtAction = new TextBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.ugLogging).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugLogging).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugLogging).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLogging).DataMember = "dtLogging";
    ((UltraGridBase) this.ugLogging).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLogging).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugLogging).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "User";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 188;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 454;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Date";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 55;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugLogging).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLogging).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLogging).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugLogging).DisplayLayout.MaxRowScrollRegions = 40;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLogging).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugLogging).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.ugLogging).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugLogging).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLogging).Location = new Point(12, 12);
    ((Control) this.ugLogging).Name = "ugLogging";
    ((Control) this.ugLogging).Size = new Size(752, 323);
    ((Control) this.ugLogging).TabIndex = 14;
    ((Control) this.ugLogging).Text = "Log";
    ((UltraControlBase) this.ugLogging).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLogging).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminInspReq";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.txtAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.txtAction.Location = new Point(58, 352);
    this.txtAction.MaxLength = 150;
    this.txtAction.Multiline = true;
    this.txtAction.Name = "txtAction";
    this.txtAction.Size = new Size(390, 116);
    this.txtAction.TabIndex = 15;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(9, 355);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(40, 13);
    this.Label1.TabIndex = 16 /*0x10*/;
    this.Label1.Text = "Action:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(776, 482);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtAction);
    this.Controls.Add((Control) this.ugLogging);
    this.Name = nameof (FormInspectionLogging);
    this.Text = "Inspection Logging";
    ((ISupportInitialize) this.ugLogging).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraGrid ugLogging
  {
    get => this._ugLogging;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugLogging_AfterRowActivate);
      UltraGrid ugLogging1 = this._ugLogging;
      if (ugLogging1 != null)
        ugLogging1.AfterRowActivate -= eventHandler;
      this._ugLogging = value;
      UltraGrid ugLogging2 = this._ugLogging;
      if (ugLogging2 == null)
        return;
      ugLogging2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAdminInspReq ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAction")]
  internal virtual TextBox txtAction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormInspectionLogging(int locationID, int controlNo)
  {
    this.Load += new EventHandler(this.FormInspectionLogging_Load);
    this.InitializeComponent();
    this._LocationID = locationID;
    this._ControlNo = controlNo;
    this.Text = "Admin Inspection Logging Info for control # " + controlNo.ToString();
  }

  public FormInspectionLogging(int locationID, int controlNo, int adminInspID)
  {
    this.Load += new EventHandler(this.FormInspectionLogging_Load);
    this.InitializeComponent();
    this._LocationID = locationID;
    this._ControlNo = controlNo;
    this._adminInspID = adminInspID;
    this.Text = "Admin Inspection Logging Info for control # " + controlNo.ToString();
  }

  private void FormInspectionLogging_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtLogging"
    }, "GetInspectionLoggingInfo", new object[6]
    {
      (object) "@LocationID",
      (object) this._LocationID,
      (object) "@ControlNo",
      (object) this._ControlNo,
      (object) "@AdminInspID",
      (object) this._adminInspID
    });
  }

  private void ugLogging_AfterRowActivate(object sender, EventArgs e)
  {
    this.txtAction.Text = string.Empty;
    if (((UltraGridBase) this.ugLogging).ActiveRow == null || ((UltraGridBase) this.ugLogging).ActiveRow.Cells["Action"].Value == DBNull.Value)
      return;
    this.txtAction.Text = ((UltraGridBase) this.ugLogging).ActiveRow.Cells["Action"].Value.ToString();
  }
}
