// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyLineGenericWording
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

public class frmCompanyLineGenericWording : Form
{
  private IContainer components;
  private int _companyLineID;
  private int _quoteWordingID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGrid1")]
  internal virtual UltraGrid UltraGrid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGenericWord")]
  internal virtual DbDataAdapter daGenericWord { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLineGenericQuoteWording ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  internal virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  internal virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  internal virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl5")]
  internal virtual UltraTabPageControl UltraTabPageControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabControl1")]
  internal virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComments")]
  internal virtual RichTextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExcluding")]
  internal virtual RichTextBox txtExcluding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtValuation")]
  internal virtual RichTextBox txtValuation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPerilsCoverage")]
  internal virtual RichTextBox txtPerilsCoverage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  internal virtual DbConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("txtCovering")]
  internal virtual RichTextBox txtCovering { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  internal virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox2")]
  internal virtual UltraGroupBox UltraGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox3")]
  internal virtual UltraGroupBox UltraGroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox4")]
  internal virtual UltraGroupBox UltraGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox5")]
  internal virtual UltraGroupBox UltraGroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  internal virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbInsertCommand1")]
  internal virtual DbCommand DbInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbUpdateCommand1")]
  internal virtual DbCommand DbUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbDeleteCommand1")]
  internal virtual DbCommand DbDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    UltraTab ultraTab5 = new UltraTab();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyLineGenericWording));
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtPerilsCoverage = new RichTextBox();
    this.ds = new dsCompanyLineGenericQuoteWording();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.UltraGroupBox2 = new UltraGroupBox();
    this.txtCovering = new RichTextBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.UltraGroupBox3 = new UltraGroupBox();
    this.txtValuation = new RichTextBox();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.UltraGroupBox4 = new UltraGroupBox();
    this.txtExcluding = new RichTextBox();
    this.btnSave = new MGAButton();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.UltraGroupBox5 = new UltraGroupBox();
    this.txtComments = new RichTextBox();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.UltraGrid1 = new UltraGrid();
    this.daGenericWord = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    this.ds.BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox2).BeginInit();
    ((Control) this.UltraGroupBox2).SuspendLayout();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox3).BeginInit();
    ((Control) this.UltraGroupBox3).SuspendLayout();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox4).BeginInit();
    ((Control) this.UltraGroupBox4).SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox5).BeginInit();
    ((Control) this.UltraGroupBox5).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(510, 309);
    ((Control) this.UltraGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.UltraGroupBox1.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtPerilsCoverage);
    ((Control) this.UltraGroupBox1).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(490, 243);
    ((Control) this.UltraGroupBox1).TabIndex = 3;
    this.UltraGroupBox1.Text = "Perils / Coverage";
    this.txtPerilsCoverage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtPerilsCoverage.BackColor = Color.White;
    this.txtPerilsCoverage.BorderStyle = BorderStyle.None;
    this.txtPerilsCoverage.DataBindings.Add(new Binding("Rtf", (object) this.ds, "tblCompanyLineGenericQuoteWording.Perils", true));
    this.txtPerilsCoverage.ForeColor = Color.Black;
    this.txtPerilsCoverage.Location = new Point(5, 17);
    this.txtPerilsCoverage.Name = "txtPerilsCoverage";
    this.txtPerilsCoverage.Size = new Size(480, 216);
    this.txtPerilsCoverage.TabIndex = 2;
    this.txtPerilsCoverage.Text = "";
    this.ds.DataSetName = "dsCompanyLineGenericQuoteWording";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraGroupBox2);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(510, 309);
    ((Control) this.UltraGroupBox2).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.UltraGroupBox2.Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance4;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.txtCovering);
    ((Control) this.UltraGroupBox2).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(490, 243);
    ((Control) this.UltraGroupBox2).TabIndex = 4;
    this.UltraGroupBox2.Text = "Covering";
    this.txtCovering.BackColor = Color.White;
    this.txtCovering.BorderStyle = BorderStyle.None;
    this.txtCovering.DataBindings.Add(new Binding("Rtf", (object) this.ds, "tblCompanyLineGenericQuoteWording.Covering", true));
    this.txtCovering.ForeColor = Color.Black;
    this.txtCovering.Location = new Point(5, 15);
    this.txtCovering.Name = "txtCovering";
    this.txtCovering.Size = new Size(480, 220);
    this.txtCovering.TabIndex = 1;
    this.txtCovering.Text = "";
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.UltraGroupBox3);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(510, 309);
    ((Control) this.UltraGroupBox3).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.UltraGroupBox3.Appearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance6;
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.txtValuation);
    ((Control) this.UltraGroupBox3).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox3).Name = "UltraGroupBox3";
    ((Control) this.UltraGroupBox3).Size = new Size(490, 243);
    ((Control) this.UltraGroupBox3).TabIndex = 5;
    this.UltraGroupBox3.Text = "Valuation";
    this.txtValuation.BackColor = Color.White;
    this.txtValuation.BorderStyle = BorderStyle.None;
    this.txtValuation.DataBindings.Add(new Binding("Rtf", (object) this.ds, "tblCompanyLineGenericQuoteWording.Valuation", true));
    this.txtValuation.ForeColor = Color.Black;
    this.txtValuation.Location = new Point(5, 15);
    this.txtValuation.Name = "txtValuation";
    this.txtValuation.Size = new Size(480, 225);
    this.txtValuation.TabIndex = 1;
    this.txtValuation.Text = "";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.UltraGroupBox4);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(510, 309);
    ((Control) this.UltraGroupBox4).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance7.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.UltraGroupBox4.Appearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance8;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtExcluding);
    ((Control) this.UltraGroupBox4).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(490, 243);
    ((Control) this.UltraGroupBox4).TabIndex = 6;
    this.UltraGroupBox4.Text = "Excluding";
    this.txtExcluding.BackColor = Color.White;
    this.txtExcluding.BorderStyle = BorderStyle.None;
    this.txtExcluding.DataBindings.Add(new Binding("Rtf", (object) this.ds, "tblCompanyLineGenericQuoteWording.Excluding", true));
    this.txtExcluding.ForeColor = Color.Black;
    this.txtExcluding.Location = new Point(5, 15);
    this.txtExcluding.Name = "txtExcluding";
    this.txtExcluding.Size = new Size(480, 225);
    this.txtExcluding.TabIndex = 1;
    this.txtExcluding.Text = "";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnSave).Location = new Point(461, 263);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 1;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.UltraGroupBox5);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(510, 309);
    ((Control) this.UltraGroupBox5).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    this.UltraGroupBox5.Appearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox5.ContentAreaAppearance = (AppearanceBase) appearance11;
    ((Control) this.UltraGroupBox5).Controls.Add((Control) this.txtComments);
    ((Control) this.UltraGroupBox5).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox5).Name = "UltraGroupBox5";
    ((Control) this.UltraGroupBox5).Size = new Size(490, 243);
    ((Control) this.UltraGroupBox5).TabIndex = 7;
    this.UltraGroupBox5.Text = "Comments";
    this.txtComments.BackColor = Color.White;
    this.txtComments.BorderStyle = BorderStyle.None;
    this.txtComments.DataBindings.Add(new Binding("Rtf", (object) this.ds, "tblCompanyLineGenericQuoteWording.Comments", true));
    this.txtComments.ForeColor = Color.Black;
    this.txtComments.Location = new Point(10, 15);
    this.txtComments.Name = "txtComments";
    this.txtComments.Size = new Size(475, 225);
    this.txtComments.TabIndex = 0;
    this.txtComments.Text = "";
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraTabControlBase) this.UltraTabControl1).BackColorInternal = Color.White;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyLineGenericQuoteWording.Excluding", true));
    ((Control) this.UltraTabControl1).Location = new Point(8, 8);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.btnSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(512 /*0x0200*/, 336);
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = " Perils/Coverage   ";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "    Covering       ";
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "    Valuation";
    ultraTab4.TabPage = this.UltraTabPageControl4;
    ultraTab4.Text = "     Excluding";
    ultraTab5.TabPage = this.UltraTabPageControl5;
    ultraTab5.Text = "    Comments";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[5]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5
    });
    ((UltraControlBase) this.UltraTabControl1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraTabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(510, 309);
    ((Control) this.UltraGrid1).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(600, 80 /*0x50*/);
    ((Control) this.UltraGrid1).TabIndex = 1;
    ((Control) this.UltraGrid1).Text = "UltraGrid1";
    this.daGenericWord.DeleteCommand = this.DbDeleteCommand1;
    this.daGenericWord.InsertCommand = this.DbInsertCommand1;
    this.daGenericWord.SelectCommand = this.DbSelectCommand1;
    this.daGenericWord.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineGenericQuoteWording", new DataColumnMapping[7]
      {
        new DataColumnMapping("Perils", "Perils"),
        new DataColumnMapping("QuoteWordingID", "QuoteWordingID"),
        new DataColumnMapping("Covering", "Covering"),
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("Valuation", "Valuation"),
        new DataColumnMapping("Comments", "Comments"),
        new DataColumnMapping("Excluding", "Excluding")
      })
    });
    this.daGenericWord.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblCompanyLineGenericQuoteWording WHERE (QuoteWordingID = @Original_QuoteWordingID)";
    this.DbDeleteCommand1.Connection = this.cnSQL;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteWordingID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteWordingID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cnSQL;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@Perils", SqlDbType.VarChar, 2000, "Perils"),
      DefaultDatabase.CreateParameter("@Covering", SqlDbType.VarChar, 2000, "Covering"),
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@Valuation", SqlDbType.VarChar, 2000, "Valuation"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.VarChar, 2000, "Comments"),
      DefaultDatabase.CreateParameter("@Excluding", SqlDbType.VarChar, 2000, "Excluding")
    });
    this.DbSelectCommand1.CommandText = "SELECT Perils, QuoteWordingID, Covering, CompanyLineID, Valuation, Comments, Excluding FROM tblCompanyLineGenericQuoteWording WHERE (CompanyLineID = @CompanyLineID)";
    this.DbSelectCommand1.Connection = this.cnSQL;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cnSQL;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[8]
    {
      DefaultDatabase.CreateParameter("@Perils", SqlDbType.VarChar, 2000, "Perils"),
      DefaultDatabase.CreateParameter("@Covering", SqlDbType.VarChar, 2000, "Covering"),
      DefaultDatabase.CreateParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      DefaultDatabase.CreateParameter("@Valuation", SqlDbType.VarChar, 2000, "Valuation"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.VarChar, 2000, "Comments"),
      DefaultDatabase.CreateParameter("@Excluding", SqlDbType.VarChar, 2000, "Excluding"),
      DefaultDatabase.CreateParameter("@Original_QuoteWordingID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteWordingID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@QuoteWordingID", SqlDbType.Int, 4, "QuoteWordingID")
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(528, 350);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCompanyLineGenericWording);
    this.Text = "Generic Quote - Default Wording";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    this.ds.EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox2).EndInit();
    ((Control) this.UltraGroupBox2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox3).EndInit();
    ((Control) this.UltraGroupBox3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox4).EndInit();
    ((Control) this.UltraGroupBox4).ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox5).EndInit();
    ((Control) this.UltraGroupBox5).ResumeLayout(false);
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyLineGenericWording(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyLineGenericWording_Load);
    this.InitializeComponent();
    this._companyLineID = companyLineID;
  }

  private void frmCompanyLineGenericWording_Load(object sender, EventArgs e)
  {
    this.Text = $"{this.Text} - {Conversions.ToString(this._companyLineID)}";
    this.daGenericWord.SelectCommand.Parameters["@CompanyLineID"].Value = (object) this._companyLineID;
    this.ds.tblCompanyLineGenericQuoteWording.Clear();
    DefaultDatabase.DataAdapterFill(this.daGenericWord, (DataTable) this.ds.tblCompanyLineGenericQuoteWording);
    if (this.ds.tblCompanyLineGenericQuoteWording.Rows.Count == 0)
    {
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow row = this.ds.tblCompanyLineGenericQuoteWording.NewtblCompanyLineGenericQuoteWordingRow();
      row.CompanyLineID = this._companyLineID;
      this.ds.tblCompanyLineGenericQuoteWording.AddtblCompanyLineGenericQuoteWordingRow(row);
    }
    else
    {
      if (this.ds.tblCompanyLineGenericQuoteWording.Rows.Count > 1)
        throw new Exception("Too many Generic Wording exist for this CompanyLine");
      this._quoteWordingID = Conversions.ToInteger(this.ds.tblCompanyLineGenericQuoteWording.Rows[0]["QuoteWordingID"]);
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.BindingContext[(object) this.ds, this.ds.tblCompanyLineGenericQuoteWording.TableName].EndCurrentEdit();
    bool flag = true;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((RichTextBox) ((Control) tab.TabPage).Controls[0].Controls[0]).Text, string.Empty, false) != 0)
      {
        flag = false;
        break;
      }
    }
    if (!flag)
      DefaultDatabase.DataAdapterUpdate(this.daGenericWord, (DataTable) this.ds.tblCompanyLineGenericQuoteWording);
    else if (this.ds.tblCompanyLineGenericQuoteWording[0].RowState != DataRowState.Added)
    {
      this.ds.tblCompanyLineGenericQuoteWording[0].Delete();
      DefaultDatabase.DataAdapterUpdate(this.daGenericWord, (DataTable) this.ds.tblCompanyLineGenericQuoteWording);
    }
    this.Close();
  }
}
