// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormProducerUnderwriterAdvanceSearch
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormProducerUnderwriterAdvanceSearch : Form
{
  private IContainer components;
  private bool _hasSearched;
  private UltraGrid _ugUnderwriterProducer;

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
    this.cboProducerLocation = new MGASimpleComboBox();
    this.cboProducer = new MGASimpleComboBox();
    this.cboUnderwriter = new MGASimpleComboBox();
    this.UltraLabel3 = new UltraLabel();
    this.UltraLabel2 = new UltraLabel();
    this.UltraLabel1 = new UltraLabel();
    this.btnSearch = new MGAButton();
    this.ds = new dsPU();
    ((ISupportInitialize) this.cboProducerLocation).BeginInit();
    ((ISupportInitialize) this.cboProducer).BeginInit();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.cboProducerLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProducerLocation).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.cboProducerLocation).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProducerLocation).DisplayMember = "Name";
    this.cboProducerLocation.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerLocation).DropDownWidth = 550;
    ((Control) this.cboProducerLocation).Location = new Point(429, 31 /*0x1F*/);
    this.cboProducerLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerLocation).Name = "cboProducerLocation";
    ((Control) this.cboProducerLocation).Size = new Size(198, 20);
    ((Control) this.cboProducerLocation).TabIndex = 50;
    ((UltraControlBase) this.cboProducerLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerLocation).ValueMember = "ProducerLocationGUID";
    this.cboProducer.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProducer).DataMember = "tblProducers";
    ((UltraGridBase) this.cboProducer).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProducer).DisplayMember = "ProducerName";
    this.cboProducer.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducer).DropDownWidth = 350;
    ((Control) this.cboProducer).Location = new Point(225, 31 /*0x1F*/);
    this.cboProducer.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducer).Name = "cboProducer";
    ((Control) this.cboProducer).Size = new Size(198, 20);
    ((Control) this.cboProducer).TabIndex = 51;
    ((UltraControlBase) this.cboProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducer).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducer).ValueMember = "ProducerGUID";
    this.cboUnderwriter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUnderwriter).DataMember = "tblUsers";
    ((UltraGridBase) this.cboUnderwriter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboUnderwriter).DisplayMember = "Name_LastFirst";
    this.cboUnderwriter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriter).DropDownWidth = 300;
    ((Control) this.cboUnderwriter).Location = new Point(21, 31 /*0x1F*/);
    this.cboUnderwriter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(198, 20);
    ((Control) this.cboUnderwriter).TabIndex = 52;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriter).ValueMember = "UserGUID";
    appearance1.BackColor = Color.Transparent;
    ((ControlBase) this.UltraLabel3).Appearance = (AppearanceBase) appearance1;
    ((Control) this.UltraLabel3).Location = new Point(429, 13);
    ((Control) this.UltraLabel3).Name = "UltraLabel3";
    ((Control) this.UltraLabel3).Size = new Size(165, 12);
    ((Control) this.UltraLabel3).TabIndex = 49;
    ((ControlBase) this.UltraLabel3).Text = "Producer location";
    appearance2.BackColor = Color.Transparent;
    ((ControlBase) this.UltraLabel2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.UltraLabel2).Location = new Point(225, 13);
    ((Control) this.UltraLabel2).Name = "UltraLabel2";
    ((Control) this.UltraLabel2).Size = new Size(165, 12);
    ((Control) this.UltraLabel2).TabIndex = 48 /*0x30*/;
    ((ControlBase) this.UltraLabel2).Text = "Producer";
    appearance3.BackColor = Color.Transparent;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance3;
    ((Control) this.UltraLabel1).Location = new Point(21, 12);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(165, 14);
    ((Control) this.UltraLabel1).TabIndex = 47;
    ((ControlBase) this.UltraLabel1).Text = "Underwriter";
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnSearch).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(296, 73);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 53;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPU";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(650, 125);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.cboProducerLocation);
    this.Controls.Add((Control) this.cboProducer);
    this.Controls.Add((Control) this.cboUnderwriter);
    this.Controls.Add((Control) this.UltraLabel3);
    this.Controls.Add((Control) this.UltraLabel2);
    this.Controls.Add((Control) this.UltraLabel1);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (FormProducerUnderwriterAdvanceSearch);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Producer / Underwriter Advanced Search";
    ((ISupportInitialize) this.cboProducerLocation).EndInit();
    ((ISupportInitialize) this.cboProducer).EndInit();
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("cboProducerLocation")]
  protected virtual MGASimpleComboBox cboProducerLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducer")]
  protected virtual MGASimpleComboBox cboProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUnderwriter")]
  protected virtual MGASimpleComboBox cboUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel3")]
  internal virtual UltraLabel UltraLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel2")]
  internal virtual UltraLabel UltraLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  internal virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsPU ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public bool HasSearched => this._hasSearched;

  public dsPU ChildDataset => this.ds;

  public FormProducerUnderwriterAdvanceSearch(dsPU dsParent, UltraGrid ugUnderwriterProducer)
  {
    this.Load += new EventHandler(this.FormProducerUnderwriterAdvanceSearch_Load);
    this._hasSearched = false;
    this.InitializeComponent();
    this._ugUnderwriterProducer = ugUnderwriterProducer;
    try
    {
      foreach (dsPU.tblUsersRow tblUser in (TypedTableBase<dsPU.tblUsersRow>) dsParent.tblUsers)
        this.ds.tblUsers.AddtblUsersRow(tblUser.UserGUID, tblUser.Name_LastFirst);
    }
    finally
    {
      IEnumerator<dsPU.tblUsersRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (dsPU.tblProducersRow tblProducer in (TypedTableBase<dsPU.tblProducersRow>) dsParent.tblProducers)
        this.ds.tblProducers.AddtblProducersRow(tblProducer.ProducerGUID, tblProducer.ProducerName);
    }
    finally
    {
      IEnumerator<dsPU.tblProducersRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (dsPU.tblProducerLocationsRow producerLocation in (TypedTableBase<dsPU.tblProducerLocationsRow>) dsParent.tblProducerLocations)
        this.ds.tblProducerLocations.AddtblProducerLocationsRow(producerLocation.ProducerLocationGUID, producerLocation.Name);
    }
    finally
    {
      IEnumerator<dsPU.tblProducerLocationsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void FormProducerUnderwriterAdvanceSearch_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
  }

  private void BtnSearch_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this._hasSearched = false;
      string[] strArray = new string[1]
      {
        "tblProducerUnderwriters"
      };
      object objectValue1 = (object) DBNull.Value;
      object objectValue2 = (object) DBNull.Value;
      object objectValue3 = (object) DBNull.Value;
      Guid guid;
      if (this.cboUnderwriter.Value != null && this.cboUnderwriter.Value != DBNull.Value)
      {
        guid = (Guid) this.cboUnderwriter.Value;
        if (!guid.Equals(Guid.Empty))
          objectValue1 = RuntimeHelpers.GetObjectValue(this.cboUnderwriter.Value);
      }
      if (this.cboProducer.Value != null && this.cboProducer.Value != DBNull.Value)
      {
        guid = (Guid) this.cboProducer.Value;
        if (!guid.Equals(Guid.Empty))
          objectValue2 = RuntimeHelpers.GetObjectValue(this.cboProducer.Value);
      }
      if (this.cboProducerLocation.Value != null && this.cboProducerLocation.Value != DBNull.Value)
      {
        guid = (Guid) this.cboProducerLocation.Value;
        if (!guid.Equals(Guid.Empty))
          objectValue3 = RuntimeHelpers.GetObjectValue(this.cboProducerLocation.Value);
      }
      try
      {
        this.ds.tblProducerUnderwriters.Clear();
        DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "GetUnderWriterProducerLocAssignmentAdvanced", new object[6]
        {
          (object) "@UnderwriterGUID",
          objectValue1,
          (object) "@ProducerLocationGUID",
          objectValue3,
          (object) "@ProducerGUID",
          objectValue2
        });
        ((UltraGridBase) this._ugUnderwriterProducer).DataSource = (object) this.ds.Tables["tblProducerUnderwriters"];
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
        ProjectData.ClearProjectError();
      }
      this._hasSearched = true;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }
}
