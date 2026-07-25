// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormProducerContactLogging
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormProducerContactLogging : Form
{
  private IContainer components;
  private Guid _producerLocationGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name_LastFirst");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("tblUsers_tblProducerContactLog");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUsers_tblProducerContactLog", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerContactGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ActionDate");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerContacts", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerContactGUID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Name");
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblProducerContactLog", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerContactGuid", -1, (object) "ddContacts");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("UserID", -1, (object) "ddUsers");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ActionDate");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ddUsers = new UltraDropDown();
    this.ds = new dsContactLogging();
    this.ddContacts = new UltraDropDown();
    this.ugLocations = new UltraGrid();
    ((ISupportInitialize) this.ddUsers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddContacts).BeginInit();
    ((ISupportInitialize) this.ugLocations).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.ddUsers).DataMember = "tblUsers";
    ((UltraGridBase) this.ddUsers).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "User ";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Width = 253;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ddUsers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddUsers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddUsers).DisplayMember = "Name_LastFirst";
    ((UltraDropDownBase) this.ddUsers).DropDownWidth = 200;
    ((Control) this.ddUsers).Location = new Point(467, 104);
    ((Control) this.ddUsers).Name = "ddUsers";
    ((Control) this.ddUsers).Size = new Size(156, 79);
    ((Control) this.ddUsers).TabIndex = 310;
    ((UltraDropDownBase) this.ddUsers).ValueMember = "UserID";
    ((Control) this.ddUsers).Visible = false;
    this.ds.DataSetName = "dsContactLogging";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddContacts).DataMember = "tblProducerContacts";
    ((UltraGridBase) this.ddContacts).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 220;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.ddContacts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddContacts).DisplayMember = "Name";
    ((UltraDropDownBase) this.ddContacts).DropDownWidth = 200;
    ((Control) this.ddContacts).Location = new Point(190, 139);
    ((Control) this.ddContacts).Name = "ddContacts";
    ((Control) this.ddContacts).Size = new Size(125, 79);
    ((Control) this.ddContacts).TabIndex = 309;
    ((UltraDropDownBase) this.ddContacts).ValueMember = "ProducerContactGUID";
    ((Control) this.ddContacts).Visible = false;
    ((Control) this.ugLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugLocations).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLocations).DataMember = "tblProducerContactLog";
    ((UltraGridBase) this.ugLocations).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Contact Name";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 165;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Width = 329;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 205;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Width = 89;
    ultraGridBand4.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ugLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Scrollbars = (Scrollbars) 2;
    ((Control) this.ugLocations).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLocations).Location = new Point(14, 12);
    ((Control) this.ugLocations).Name = "ugLocations";
    ((Control) this.ugLocations).Size = new Size(807, 441);
    ((Control) this.ugLocations).TabIndex = 308;
    ((UltraControlBase) this.ugLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(833, 487);
    this.Controls.Add((Control) this.ddUsers);
    this.Controls.Add((Control) this.ddContacts);
    this.Controls.Add((Control) this.ugLocations);
    this.Name = nameof (FormProducerContactLogging);
    this.Text = "Producer Contact Logging";
    ((ISupportInitialize) this.ddUsers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddContacts).EndInit();
    ((ISupportInitialize) this.ugLocations).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugLocations")]
  private virtual UltraGrid ugLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsContactLogging ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddContacts")]
  private virtual UltraDropDown ddContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddUsers")]
  private virtual UltraDropDown ddUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProducerContactLogging(Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.FormProducerContactLogging_Load);
    this.InitializeComponent();
    this._producerLocationGuid = producerLocationGuid;
  }

  private void FormProducerContactLogging_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "tblUsers",
      "tblProducerContacts",
      "tblProducerContactLog"
    }, "GetProducerLoggingData", new object[2]
    {
      (object) "@ProducerLocationGuid",
      (object) this._producerLocationGuid
    });
  }
}
