// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormProducersInhouseProducers
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormProducersInhouseProducers : Form
{
  private IContainer components;
  private readonly Guid _producerLocationGUID;

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblProducerInhouse", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationGuid", -1, (object) "ddProducerLocations");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerGuid", -1, (object) "ddProducers");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InhouseProducerGuid", -1, (object) "ddInhouse");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Name");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Name");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerName");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormProducersInhouseProducers));
    this.btnSave = new MGAButton();
    this.ugInhouseProducer = new UltraGrid();
    this.ds = new dsAssProdInhouse();
    this.ddInhouse = new UltraDropDown();
    this.ddProducerLocations = new UltraDropDown();
    this.ddProducers = new UltraDropDown();
    this.daInhouseProducer = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.lnkAdd = new LinkLabel();
    this.lnkCancel = new LinkLabel();
    this.lnkUndoLocation = new LinkLabel();
    this.lnkUndoProducer = new LinkLabel();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ugInhouseProducer).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddInhouse).BeginInit();
    ((ISupportInitialize) this.ddProducerLocations).BeginInit();
    ((ISupportInitialize) this.ddProducers).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(864, 371);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 25;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugInhouseProducer).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugInhouseProducer).DataMember = "tblProducerInhouse";
    ((UltraGridBase) this.ugInhouseProducer).DataSource = (object) this.ds;
    appearance2.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.WhiteSmoke;
    appearance3.BorderColor = Color.WhiteSmoke;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Add ... Producer / Underwriters";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 94;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Producer Location";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 357;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Producer";
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 316;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "In-house Producer";
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 198;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Navy;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.MaxSelectedRows = 10;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugInhouseProducer).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugInhouseProducer).Location = new Point(12, 12);
    ((Control) this.ugInhouseProducer).Name = "ugInhouseProducer";
    ((Control) this.ugInhouseProducer).Size = new Size(892, 331);
    ((Control) this.ugInhouseProducer).TabIndex = 27;
    ((Control) this.ugInhouseProducer).Text = "In-house Producer / Location Assignment";
    ((UltraControlBase) this.ugInhouseProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugInhouseProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAssProdInhouse";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddInhouse).DataMember = "tblUsers";
    ((UltraGridBase) this.ddInhouse).DataSource = (object) this.ds;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Name";
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 289;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddInhouse).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddInhouse).DisplayMember = "Name";
    ((Control) this.ddInhouse).Location = new Point(110, 144 /*0x90*/);
    ((Control) this.ddInhouse).Name = "ddInhouse";
    ((Control) this.ddInhouse).Size = new Size(288, 72);
    ((Control) this.ddInhouse).TabIndex = 30;
    ((UltraDropDownBase) this.ddInhouse).ValueMember = "UserGUID";
    ((Control) this.ddInhouse).Visible = false;
    ((UltraGridBase) this.ddProducerLocations).DataSource = (object) this.ds.tblProducerLocations;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 368;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddProducerLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddProducerLocations).DisplayMember = "Name";
    ((Control) this.ddProducerLocations).Location = new Point(478, 136);
    ((Control) this.ddProducerLocations).Name = "ddProducerLocations";
    ((Control) this.ddProducerLocations).Size = new Size(328, 80 /*0x50*/);
    ((Control) this.ddProducerLocations).TabIndex = 29;
    ((UltraDropDownBase) this.ddProducerLocations).ValueMember = "ProducerLocationGUID";
    ((Control) this.ddProducerLocations).Visible = false;
    ((UltraGridBase) this.ddProducers).DataSource = (object) this.ds.tblProducers;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 350;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Width = 400;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddProducers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddProducers).DisplayMember = "ProducerName";
    ((Control) this.ddProducers).Location = new Point(325, 222);
    ((Control) this.ddProducers).Name = "ddProducers";
    ((Control) this.ddProducers).Size = new Size(312, 63 /*0x3F*/);
    ((Control) this.ddProducers).TabIndex = 28;
    ((UltraDropDownBase) this.ddProducers).ValueMember = "ProducerGUID";
    ((Control) this.ddProducers).Visible = false;
    this.daInhouseProducer.DeleteCommand = this.SqlDeleteCommand2;
    this.daInhouseProducer.InsertCommand = this.SqlInsertCommand2;
    this.daInhouseProducer.SelectCommand = this.SqlSelectCommand2;
    this.daInhouseProducer.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerInhouse", new DataColumnMapping[4]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("ProducerGuid", "ProducerGuid"),
        new DataColumnMapping("InhouseProducerGuid", "InhouseProducerGuid")
      })
    });
    this.daInhouseProducer.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblProducerInhouse] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGuid"),
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 0, "ProducerGuid"),
      new SqlParameter("@InhouseProducerGuid", SqlDbType.UniqueIdentifier, 0, "InhouseProducerGuid")
    });
    this.SqlSelectCommand2.CommandText = "SELECT        ID, ProducerLocationGuid, ProducerGuid, InhouseProducerGuid\r\nFROM            dbo.tblProducerInhouse";
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGuid"),
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 0, "ProducerGuid"),
      new SqlParameter("@InhouseProducerGuid", SqlDbType.UniqueIdentifier, 0, "InhouseProducerGuid"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.lnkAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAdd.AutoSize = true;
    this.lnkAdd.Location = new Point(12, 356);
    this.lnkAdd.Name = "lnkAdd";
    this.lnkAdd.Size = new Size(64 /*0x40*/, 13);
    this.lnkAdd.TabIndex = 31 /*0x1F*/;
    this.lnkAdd.TabStop = true;
    this.lnkAdd.Text = "Add Record";
    this.lnkCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCancel.AutoSize = true;
    this.lnkCancel.Location = new Point(12, 398);
    this.lnkCancel.Name = "lnkCancel";
    this.lnkCancel.Size = new Size(71, 13);
    this.lnkCancel.TabIndex = 32 /*0x20*/;
    this.lnkCancel.TabStop = true;
    this.lnkCancel.Text = "Undo Record";
    this.lnkUndoLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkUndoLocation.AutoSize = true;
    this.lnkUndoLocation.Location = new Point(486, 398);
    this.lnkUndoLocation.Name = "lnkUndoLocation";
    this.lnkUndoLocation.Size = new Size(114, 13);
    this.lnkUndoLocation.TabIndex = 33;
    this.lnkUndoLocation.TabStop = true;
    this.lnkUndoLocation.Text = "Undo Current Location";
    this.lnkUndoProducer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkUndoProducer.AutoSize = true;
    this.lnkUndoProducer.Location = new Point(630, 398);
    this.lnkUndoProducer.Name = "lnkUndoProducer";
    this.lnkUndoProducer.Size = new Size(116, 13);
    this.lnkUndoProducer.TabIndex = 34;
    this.lnkUndoProducer.TabStop = true;
    this.lnkUndoProducer.Text = "Undo Current Producer";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(916, 423);
    this.Controls.Add((Control) this.lnkUndoProducer);
    this.Controls.Add((Control) this.lnkUndoLocation);
    this.Controls.Add((Control) this.lnkCancel);
    this.Controls.Add((Control) this.lnkAdd);
    this.Controls.Add((Control) this.ddInhouse);
    this.Controls.Add((Control) this.ddProducerLocations);
    this.Controls.Add((Control) this.ddProducers);
    this.Controls.Add((Control) this.ugInhouseProducer);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (FormProducersInhouseProducers);
    this.Text = "Assign Producers / Locations to In-house Producers";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ugInhouseProducer).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddInhouse).EndInit();
    ((ISupportInitialize) this.ddProducerLocations).EndInit();
    ((ISupportInitialize) this.ddProducers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("ugInhouseProducer")]
  internal virtual UltraGrid ugInhouseProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAssProdInhouse ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddInhouse")]
  internal virtual UltraDropDown ddInhouse { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddProducerLocations")]
  internal virtual UltraDropDown ddProducerLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddProducers")]
  internal virtual UltraDropDown ddProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daInhouseProducer")]
  internal virtual SqlDataAdapter daInhouseProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand2")]
  internal virtual SqlCommand SqlDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand2")]
  internal virtual SqlCommand SqlInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand2")]
  internal virtual SqlCommand SqlUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAdd
  {
    get => this._lnkAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAdd_LinkClicked);
      LinkLabel lnkAdd1 = this._lnkAdd;
      if (lnkAdd1 != null)
        lnkAdd1.LinkClicked -= clickedEventHandler;
      this._lnkAdd = value;
      LinkLabel lnkAdd2 = this._lnkAdd;
      if (lnkAdd2 == null)
        return;
      lnkAdd2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkCancel
  {
    get => this._lnkCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
      LinkLabel lnkCancel1 = this._lnkCancel;
      if (lnkCancel1 != null)
        lnkCancel1.LinkClicked -= clickedEventHandler;
      this._lnkCancel = value;
      LinkLabel lnkCancel2 = this._lnkCancel;
      if (lnkCancel2 == null)
        return;
      lnkCancel2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkUndoLocation
  {
    get => this._lnkUndoLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUndoLocation_LinkClicked);
      LinkLabel lnkUndoLocation1 = this._lnkUndoLocation;
      if (lnkUndoLocation1 != null)
        lnkUndoLocation1.LinkClicked -= clickedEventHandler;
      this._lnkUndoLocation = value;
      LinkLabel lnkUndoLocation2 = this._lnkUndoLocation;
      if (lnkUndoLocation2 == null)
        return;
      lnkUndoLocation2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkUndoProducer
  {
    get => this._lnkUndoProducer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkUndoProducer_LinkClicked);
      LinkLabel lnkUndoProducer1 = this._lnkUndoProducer;
      if (lnkUndoProducer1 != null)
        lnkUndoProducer1.LinkClicked -= clickedEventHandler;
      this._lnkUndoProducer = value;
      LinkLabel lnkUndoProducer2 = this._lnkUndoProducer;
      if (lnkUndoProducer2 == null)
        return;
      lnkUndoProducer2.LinkClicked += clickedEventHandler;
    }
  }

  public FormProducersInhouseProducers()
  {
    this.Load += new EventHandler(this.FormProducersInhouseProducers_Load);
    this._producerLocationGUID = Guid.Empty;
    this.InitializeComponent();
  }

  public FormProducersInhouseProducers(Guid producerLocationGUID)
    : this()
  {
    this.InitializeComponent();
    this._producerLocationGUID = producerLocationGUID;
  }

  private bool ValidForm()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugInhouseProducer).Rows)
    {
      if (row.Cells["ProducerLocationGuid"].Text.Equals(string.Empty) && row.Cells["ProducerGuid"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Cannot have row(s) with both Producer Location and Producer empty", "Empty Producer / Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        break;
      }
      if (!row.Cells["ProducerLocationGuid"].Text.Equals(string.Empty) && !row.Cells["ProducerGuid"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Cannot assign an in-house producer to both a producer and a producer location.", "Invalid Producer/Producer Location Selection ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        break;
      }
      if (row.Cells["InhouseProducerGuid"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("An in-house producer must be assigned to either a Location or Producer", "Empty In-house Producer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
        break;
      }
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidForm())
      return;
    SqlConnection connection = DefaultDatabase.CreateConnection();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.daInhouseProducer.DeleteCommand.Connection = connection;
      this.daInhouseProducer.InsertCommand.Connection = connection;
      this.daInhouseProducer.UpdateCommand.Connection = connection;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daInhouseProducer, (DataTable) this.ds.tblProducerInhouse);
    }
    finally
    {
      if (connection != null)
      {
        connection.Close();
        connection.Dispose();
      }
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  private void FormProducersInhouseProducers_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUsers"
    }, "spGetInhouseProducerUsers", new object[2]
    {
      (object) "@automationCode",
      (object) "INHPR"
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducers"
    }, CommandType.Text, "SELECT ProducerGuid, ProducerName FROM tblProducers WITH (NOLOCK) WHERE LEN(ProducerName) > 0 ORDER BY ProducerName");
    string str = "Select ID, ProducerLocationGuid, ProducerGuid, InhouseProducerGuid FROM dbo.tblProducerInhouse WITH (NOLOCK)";
    if (this._producerLocationGUID.Equals(Guid.Empty))
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerLocations"
      }, CommandType.Text, "SELECT ProducerLocationGUID, Name FROM tblProducerLocations WITH (NOLOCK) ORDER BY Name");
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerInhouse"
      }, CommandType.Text, str);
    }
    else
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerLocations"
      }, CommandType.Text, "SELECT ProducerLocationGUID, Name FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGUID = @prodLocGUID", new object[2]
      {
        (object) "@prodLocGUID",
        (object) this._producerLocationGUID
      });
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerInhouse"
      }, CommandType.Text, str + " WHERE ProducerLocationGUID = @PLG", new object[2]
      {
        (object) "@PLG",
        (object) this._producerLocationGUID
      });
    }
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
  }

  private void lnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.ugInhouseProducer).DisplayLayout.Bands[0].AddNew();
    ((UltraGridBase) this.ugInhouseProducer).UpdateData();
  }

  private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.tblProducerInhouse.RejectChanges();
    ((UltraGridBase) this.ugInhouseProducer).UpdateData();
  }

  private void lnkUndoLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.UndoGridColumn("ProducerLocationGuid");
  }

  private void lnkUndoProducer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.UndoGridColumn("ProducerGuid");
  }

  private void UndoGridColumn(string columnName)
  {
    if (((UltraGridBase) this.ugInhouseProducer).ActiveRow == null)
      return;
    ((UltraGridBase) this.ugInhouseProducer).ActiveRow.Cells[columnName].Value = (object) DBNull.Value;
    ((UltraGridBase) this.ugInhouseProducer).UpdateData();
  }
}
