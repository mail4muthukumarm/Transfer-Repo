// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines.Blocking.FormProducerLineBlocking
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers.Lines.Blocking;

[DesignerGenerated]
public class FormProducerLineBlocking : Form
{
  private IContainer components;
  private dsProducerLinesBlocking ds;
  private UltraDropDown dropdownProducers;
  private UltraDropDown dropdownLineGuid;
  private UltraDropDown dropdownStateID;
  private UltraDropDown dropdownProducerLocations;
  private UltraDropDown dropdownPolicyTypeID;
  private MGASimpleComboBox comboProducers;
  private MGASimpleComboBox comboProducerLocations;
  private MGASimpleComboBox MGASimpleComboBox2;
  private MGASimpleComboBox MGASimpleComboBox4;
  private MGASimpleComboBox comboPolicyTypes;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlDataAdapter da;
  private SqlConnection cn;
  private Guid _producerGuid;
  private Guid _producerLocationGuid;
  private List<string> _logList;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormProducerLineBlocking));
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstPolicyTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("lstPolicyTypes_tblProducerLineBlocking");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstPolicyTypes_tblProducerLineBlocking", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("tblProducerLocations_tblProducerLineBlocking");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblProducerLocations_tblProducerLineBlocking", 0);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("lstStates_tblProducerLineBlocking");
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstStates_tblProducerLineBlocking", 0);
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("lstLines_tblProducerLineBlocking");
    UltraGridBand ultraGridBand8 = new UltraGridBand("lstLines_tblProducerLineBlocking", 0);
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ProducerGUID", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ProducerName");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("tblProducers_tblProducerLineBlocking");
    UltraGridBand ultraGridBand10 = new UltraGridBand("tblProducers_tblProducerLineBlocking", 0);
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    UltraGridBand ultraGridBand11 = new UltraGridBand("tblProducerLineBlocking", -1);
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("ProducerGuid", -1, (object) "dropdownProducers");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("ProducerLocationGuid", -1, (object) "dropdownProducerLocations");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("LineGuid", -1, (object) "dropdownLineGuid");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("StateID", -1, (object) "dropdownStateID");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("PolicyTypeID", -1, (object) "dropdownPolicyTypeID");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("CompanyLocationGuid", -1, (object) "dropdownCompanies");
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    UltraGridBand ultraGridBand12 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("tblCompanyLocations_tblProducerLineBlocking");
    UltraGridBand ultraGridBand13 = new UltraGridBand("tblCompanyLocations_tblProducerLineBlocking", 0);
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("BlockID");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    this.groupCombos = new UltraGroupBox();
    this.comboCompanyLocations = new MGASimpleComboBox();
    this.ds = new dsProducerLinesBlocking();
    this.datetimeEffective = new MGADateTimePicker();
    this.MGASimpleComboBox4 = new MGASimpleComboBox();
    this.comboPolicyTypes = new MGASimpleComboBox();
    this.MGASimpleComboBox2 = new MGASimpleComboBox();
    this.comboProducerLocations = new MGASimpleComboBox();
    this.comboProducers = new MGASimpleComboBox();
    this.DbSaveUI1 = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.da = new SqlDataAdapter();
    this.err = new ErrorProvider(this.components);
    this.dropdownPolicyTypeID = new UltraDropDown();
    this.dropdownProducerLocations = new UltraDropDown();
    this.dropdownStateID = new UltraDropDown();
    this.dropdownLineGuid = new UltraDropDown();
    this.dropdownProducers = new UltraDropDown();
    this.gridBlocked = new UltraGrid();
    this.dropdownCompanies = new UltraDropDown();
    this.lnkProducerBlockingByBulk = new LinkLabel();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    ((ISupportInitialize) this.groupCombos).BeginInit();
    ((Control) this.groupCombos).SuspendLayout();
    ((ISupportInitialize) this.comboCompanyLocations).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.datetimeEffective).BeginInit();
    ((ISupportInitialize) this.MGASimpleComboBox4).BeginInit();
    ((ISupportInitialize) this.comboPolicyTypes).BeginInit();
    ((ISupportInitialize) this.MGASimpleComboBox2).BeginInit();
    ((ISupportInitialize) this.comboProducerLocations).BeginInit();
    ((ISupportInitialize) this.comboProducers).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dropdownPolicyTypeID).BeginInit();
    ((ISupportInitialize) this.dropdownProducerLocations).BeginInit();
    ((ISupportInitialize) this.dropdownStateID).BeginInit();
    ((ISupportInitialize) this.dropdownLineGuid).BeginInit();
    ((ISupportInitialize) this.dropdownProducers).BeginInit();
    ((ISupportInitialize) this.gridBlocked).BeginInit();
    ((ISupportInitialize) this.dropdownCompanies).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(83, 99);
    label1.Name = "Label3";
    label1.Size = new Size(26, 13);
    label1.TabIndex = 4;
    label1.Text = "Line";
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(16 /*0x10*/, 46);
    label2.Name = "Label2";
    label2.Size = new Size(93, 13);
    label2.TabIndex = 3;
    label2.Text = "Producer Location";
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(59, 17);
    label3.Name = "Label1";
    label3.Size = new Size(50, 13);
    label3.TabIndex = 1;
    label3.Text = "Producer";
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(48 /*0x30*/, 128 /*0x80*/);
    label4.Name = "Label4";
    label4.Size = new Size(61, 13);
    label4.TabIndex = 6;
    label4.Text = "Policy Type";
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(76, 157);
    label5.Name = "Label5";
    label5.Size = new Size(33, 13);
    label5.TabIndex = 8;
    label5.Text = "State";
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(59, 184);
    label6.Name = "Label6";
    label6.Size = new Size(50, 13);
    label6.TabIndex = 11;
    label6.Text = "Effective";
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(14, 72);
    label7.Name = "Label7";
    label7.Size = new Size(95, 13);
    label7.TabIndex = 12;
    label7.Text = "Company Location";
    ((Control) this.groupCombos).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.groupCombos).Controls.Add((Control) this.comboCompanyLocations);
    ((Control) this.groupCombos).Controls.Add((Control) label7);
    ((Control) this.groupCombos).Controls.Add((Control) label6);
    ((Control) this.groupCombos).Controls.Add((Control) this.datetimeEffective);
    ((Control) this.groupCombos).Controls.Add((Control) this.MGASimpleComboBox4);
    ((Control) this.groupCombos).Controls.Add((Control) label5);
    ((Control) this.groupCombos).Controls.Add((Control) this.comboPolicyTypes);
    ((Control) this.groupCombos).Controls.Add((Control) label4);
    ((Control) this.groupCombos).Controls.Add((Control) this.MGASimpleComboBox2);
    ((Control) this.groupCombos).Controls.Add((Control) label1);
    ((Control) this.groupCombos).Controls.Add((Control) label2);
    ((Control) this.groupCombos).Controls.Add((Control) this.comboProducerLocations);
    ((Control) this.groupCombos).Controls.Add((Control) label3);
    ((Control) this.groupCombos).Controls.Add((Control) this.comboProducers);
    ((Control) this.groupCombos).Enabled = false;
    ((Control) this.groupCombos).Location = new Point(12, 350);
    ((Control) this.groupCombos).Name = "groupCombos";
    ((Control) this.groupCombos).Size = new Size(553, 239);
    ((Control) this.groupCombos).TabIndex = 6;
    this.groupCombos.ViewStyle = (GroupBoxViewStyle) 3;
    this.comboCompanyLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboCompanyLocations).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.CompanyLocationGuid", true));
    ((UltraGridBase) this.comboCompanyLocations).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.comboCompanyLocations).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboCompanyLocations).DisplayMember = "LocationName";
    this.comboCompanyLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyLocations).Location = new Point(115, 68);
    this.comboCompanyLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanyLocations).Name = "comboCompanyLocations";
    ((Control) this.comboCompanyLocations).Size = new Size(408, 21);
    ((Control) this.comboCompanyLocations).TabIndex = 13;
    ((UltraControlBase) this.comboCompanyLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCompanyLocations).ValueMember = "CompanyLocationGUID";
    this.ds.DataSetName = "dsProducerLinesBlocking";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.datetimeEffective.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.datetimeEffective.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.datetimeEffective).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.Effective", true));
    ((Control) this.datetimeEffective).Location = new Point(115, 180);
    this.datetimeEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.datetimeEffective).Name = "datetimeEffective";
    ((Control) this.datetimeEffective).Size = new Size(103, 20);
    ((Control) this.datetimeEffective).TabIndex = 10;
    ((UltraControlBase) this.datetimeEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.datetimeEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.MGASimpleComboBox4.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MGASimpleComboBox4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.StateID", true));
    ((UltraGridBase) this.MGASimpleComboBox4).DataMember = "lstStates";
    ((UltraGridBase) this.MGASimpleComboBox4).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.MGASimpleComboBox4).DisplayMember = "State";
    this.MGASimpleComboBox4.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MGASimpleComboBox4).Location = new Point(115, 153);
    this.MGASimpleComboBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MGASimpleComboBox4).Name = "MGASimpleComboBox4";
    ((Control) this.MGASimpleComboBox4).Size = new Size(408, 21);
    ((Control) this.MGASimpleComboBox4).TabIndex = 9;
    ((UltraControlBase) this.MGASimpleComboBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MGASimpleComboBox4).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MGASimpleComboBox4).ValueMember = "StateID";
    this.comboPolicyTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboPolicyTypes).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.PolicyTypeID", true));
    ((UltraGridBase) this.comboPolicyTypes).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.comboPolicyTypes).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboPolicyTypes).DisplayMember = "Description";
    this.comboPolicyTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPolicyTypes).Location = new Point(115, 124);
    this.comboPolicyTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPolicyTypes).Name = "comboPolicyTypes";
    ((Control) this.comboPolicyTypes).Size = new Size(408, 21);
    ((Control) this.comboPolicyTypes).TabIndex = 7;
    ((UltraControlBase) this.comboPolicyTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPolicyTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPolicyTypes).ValueMember = "PolicyTypeID";
    this.MGASimpleComboBox2.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MGASimpleComboBox2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.LineGuid", true));
    ((UltraGridBase) this.MGASimpleComboBox2).DataMember = "lstLines";
    ((UltraGridBase) this.MGASimpleComboBox2).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.MGASimpleComboBox2).DisplayMember = "LineName";
    this.MGASimpleComboBox2.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MGASimpleComboBox2).Location = new Point(115, 95);
    this.MGASimpleComboBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MGASimpleComboBox2).Name = "MGASimpleComboBox2";
    ((Control) this.MGASimpleComboBox2).Size = new Size(408, 21);
    ((Control) this.MGASimpleComboBox2).TabIndex = 5;
    ((UltraControlBase) this.MGASimpleComboBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MGASimpleComboBox2).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MGASimpleComboBox2).ValueMember = "LineGUID";
    this.comboProducerLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboProducerLocations).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.ProducerLocationGuid", true));
    ((UltraGridBase) this.comboProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.comboProducerLocations).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboProducerLocations).DisplayMember = "Name";
    this.comboProducerLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboProducerLocations).Location = new Point(115, 42);
    this.comboProducerLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboProducerLocations).Name = "comboProducerLocations";
    ((Control) this.comboProducerLocations).Size = new Size(408, 21);
    ((Control) this.comboProducerLocations).TabIndex = 2;
    ((UltraControlBase) this.comboProducerLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboProducerLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboProducerLocations).ValueMember = "ProducerLocationGUID";
    this.comboProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboProducers).DataBindings.Add(new Binding("Value", (object) this.ds, "tblProducerLineBlocking.ProducerGuid", true));
    ((UltraGridBase) this.comboProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.comboProducers).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboProducers).DisplayMember = "ProducerName";
    this.comboProducers.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboProducers).Location = new Point(115, 13);
    this.comboProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboProducers).Name = "comboProducers";
    ((Control) this.comboProducers).Size = new Size(408, 21);
    ((Control) this.comboProducers).TabIndex = 0;
    ((UltraControlBase) this.comboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboProducers).ValueMember = "ProducerGUID";
    this.DbSaveUI1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.DbSaveUI1.AutoQueryRowCountOnLoad = false;
    this.DbSaveUI1.EditStyle = EditStyle.ShowEditButton;
    this.DbSaveUI1.FreezeEvents = false;
    this.DbSaveUI1.Location = new Point(799, 539);
    this.DbSaveUI1.Name = "DbSaveUI1";
    this.DbSaveUI1.Size = new Size(112 /*0x70*/, 40);
    this.DbSaveUI1.TabIndex = 10;
    this.SqlSelectCommand1.CommandText = "SELECT     tblProducerLineBlocking.*\r\nFROM         tblProducerLineBlocking";
    this.SqlSelectCommand1.Connection = this.cn;
    this.cn.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 0, "ProducerGuid"),
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.TinyInt, 0, "PolicyTypeID"),
      new SqlParameter("@Effective", SqlDbType.SmallDateTime, 0, "Effective")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[22]
    {
      new SqlParameter("@ProducerGuid", SqlDbType.UniqueIdentifier, 0, "ProducerGuid"),
      new SqlParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, "ProducerLocationGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.TinyInt, 0, "PolicyTypeID"),
      new SqlParameter("@Effective", SqlDbType.SmallDateTime, 0, "Effective"),
      new SqlParameter("@Original_BlockID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BlockID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerLocationGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerLocationGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_CompanyLocationGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_LineGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_LineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_StateID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_PolicyTypeID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PolicyTypeID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_PolicyTypeID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Effective", SqlDbType.SmallDateTime, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Effective", DataRowVersion.Original, (object) null),
      new SqlParameter("@BlockID", SqlDbType.Int, 4, "BlockID")
    });
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[14]
    {
      new SqlParameter("@Original_BlockID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BlockID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ProducerLocationGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ProducerLocationGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ProducerLocationGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_CompanyLocationGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_LineGuid", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_LineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_StateID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_PolicyTypeID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "PolicyTypeID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_PolicyTypeID", SqlDbType.TinyInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyTypeID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_Effective", SqlDbType.SmallDateTime, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Effective", DataRowVersion.Original, (object) null)
    });
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblProducerLineBlocking", new DataColumnMapping[8]
      {
        new DataColumnMapping("BlockID", "BlockID"),
        new DataColumnMapping("ProducerGuid", "ProducerGuid"),
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("Effective", "Effective")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.dropdownPolicyTypeID).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.dropdownPolicyTypeID).DataSource = (object) this.ds;
    appearance3.BackColor = SystemColors.Window;
    appearance3.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance4.BackColor = SystemColors.ActiveBorder;
    appearance4.BackColor2 = SystemColors.ControlDark;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance4;
    appearance5.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance5;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = SystemColors.ControlLightLight;
    appearance6.BackColor2 = SystemColors.Control;
    appearance6.BackGradientStyle = (GradientStyle) 3;
    appearance6.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.MaxRowScrollRegions = 1;
    appearance7.BackColor = SystemColors.Window;
    appearance7.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = SystemColors.Highlight;
    appearance8.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance9.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.Silver;
    appearance10.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.CellPadding = 0;
    appearance11.BackColor = SystemColors.Control;
    appearance11.BackColor2 = SystemColors.ControlDark;
    appearance11.BackGradientAlignment = (GradientAlignment) 1;
    appearance11.BackGradientStyle = (GradientStyle) 3;
    appearance11.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownPolicyTypeID).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownPolicyTypeID).DisplayMember = "Description";
    ((Control) this.dropdownPolicyTypeID).Location = new Point(211, 156);
    ((Control) this.dropdownPolicyTypeID).Name = "dropdownPolicyTypeID";
    ((Control) this.dropdownPolicyTypeID).Size = new Size(174, 32 /*0x20*/);
    ((Control) this.dropdownPolicyTypeID).TabIndex = 5;
    ((Control) this.dropdownPolicyTypeID).Text = "UltraDropDown3";
    ((UltraDropDownBase) this.dropdownPolicyTypeID).ValueMember = "PolicyTypeID";
    ((Control) this.dropdownPolicyTypeID).Visible = false;
    ((UltraGridBase) this.dropdownProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.dropdownProducerLocations).DataSource = (object) this.ds;
    appearance15.BackColor = SystemColors.Window;
    appearance15.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 1;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.Header.VisiblePosition = 3;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.Header.VisiblePosition = 4;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.Header.VisiblePosition = 5;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.Header.VisiblePosition = 6;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.Header.VisiblePosition = 7;
    ultraGridBand4.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance16.BackColor = SystemColors.ActiveBorder;
    appearance16.BackColor2 = SystemColors.ControlDark;
    appearance16.BackGradientStyle = (GradientStyle) 2;
    appearance16.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance16;
    appearance17.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance17;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance18.BackColor = SystemColors.ControlLightLight;
    appearance18.BackColor2 = SystemColors.Control;
    appearance18.BackGradientStyle = (GradientStyle) 3;
    appearance18.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.MaxRowScrollRegions = 1;
    appearance19.BackColor = SystemColors.Window;
    appearance19.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = SystemColors.Highlight;
    appearance20.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance21.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance21;
    appearance22.BorderColor = Color.Silver;
    appearance22.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.CellPadding = 0;
    appearance23.BackColor = SystemColors.Control;
    appearance23.BackColor2 = SystemColors.ControlDark;
    appearance23.BackGradientAlignment = (GradientAlignment) 1;
    appearance23.BackGradientStyle = (GradientStyle) 3;
    appearance23.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance25.BackColor = SystemColors.Window;
    appearance25.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance26.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownProducerLocations).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownProducerLocations).DisplayMember = "Name";
    ((Control) this.dropdownProducerLocations).Location = new Point(31 /*0x1F*/, 156);
    ((Control) this.dropdownProducerLocations).Name = "dropdownProducerLocations";
    ((Control) this.dropdownProducerLocations).Size = new Size(174, 32 /*0x20*/);
    ((Control) this.dropdownProducerLocations).TabIndex = 4;
    ((Control) this.dropdownProducerLocations).Text = "UltraDropDown4";
    ((UltraDropDownBase) this.dropdownProducerLocations).ValueMember = "ProducerLocationGUID";
    ((Control) this.dropdownProducerLocations).Visible = false;
    ((UltraGridBase) this.dropdownStateID).DataMember = "lstStates";
    ((UltraGridBase) this.dropdownStateID).DataSource = (object) this.ds;
    appearance27.BackColor = SystemColors.Window;
    appearance27.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Appearance = (AppearanceBase) appearance27;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.Header.VisiblePosition = 1;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.Header.VisiblePosition = 2;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25
    });
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.Header.VisiblePosition = 1;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.Header.VisiblePosition = 2;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.Header.VisiblePosition = 3;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn30.Header.VisiblePosition = 4;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn31.Header.VisiblePosition = 5;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn32.Header.VisiblePosition = 6;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn33.Header.VisiblePosition = 7;
    ultraGridBand6.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33
    });
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance28.BackColor = SystemColors.ActiveBorder;
    appearance28.BackColor2 = SystemColors.ControlDark;
    appearance28.BackGradientStyle = (GradientStyle) 2;
    appearance28.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance28;
    appearance29.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance29;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance30.BackColor = SystemColors.ControlLightLight;
    appearance30.BackColor2 = SystemColors.Control;
    appearance30.BackGradientStyle = (GradientStyle) 3;
    appearance30.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.MaxRowScrollRegions = 1;
    appearance31.BackColor = SystemColors.Window;
    appearance31.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance31;
    appearance32.BackColor = SystemColors.Highlight;
    appearance32.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance33.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance33;
    appearance34.BorderColor = Color.Silver;
    appearance34.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CellPadding = 0;
    appearance35.BackColor = SystemColors.Control;
    appearance35.BackColor2 = SystemColors.ControlDark;
    appearance35.BackGradientAlignment = (GradientAlignment) 1;
    appearance35.BackGradientStyle = (GradientStyle) 3;
    appearance35.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance37.BackColor = SystemColors.Window;
    appearance37.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance38.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownStateID).DisplayMember = "State";
    ((Control) this.dropdownStateID).Location = new Point(391, 118);
    ((Control) this.dropdownStateID).Name = "dropdownStateID";
    ((Control) this.dropdownStateID).Size = new Size(174, 32 /*0x20*/);
    ((Control) this.dropdownStateID).TabIndex = 3;
    ((Control) this.dropdownStateID).Text = "UltraDropDown3";
    ((UltraDropDownBase) this.dropdownStateID).ValueMember = "StateID";
    ((Control) this.dropdownStateID).Visible = false;
    ((UltraGridBase) this.dropdownLineGuid).DataMember = "lstLines";
    ((UltraGridBase) this.dropdownLineGuid).DataSource = (object) this.ds;
    appearance39.BackColor = SystemColors.Window;
    appearance39.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Appearance = (AppearanceBase) appearance39;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn34.Header.VisiblePosition = 0;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn35.Header.VisiblePosition = 1;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn36.Header.VisiblePosition = 2;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36
    });
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn37.Header.VisiblePosition = 0;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn38.Header.VisiblePosition = 1;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn39.Header.VisiblePosition = 2;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn40.Header.VisiblePosition = 3;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn41.Header.VisiblePosition = 4;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn42.Header.VisiblePosition = 5;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn43.Header.VisiblePosition = 6;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn44.Header.VisiblePosition = 7;
    ultraGridBand8.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44
    });
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance40.BackColor = SystemColors.ActiveBorder;
    appearance40.BackColor2 = SystemColors.ControlDark;
    appearance40.BackGradientStyle = (GradientStyle) 2;
    appearance40.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance40;
    appearance41.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance41;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance42.BackColor = SystemColors.ControlLightLight;
    appearance42.BackColor2 = SystemColors.Control;
    appearance42.BackGradientStyle = (GradientStyle) 3;
    appearance42.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.MaxRowScrollRegions = 1;
    appearance43.BackColor = SystemColors.Window;
    appearance43.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance43;
    appearance44.BackColor = SystemColors.Highlight;
    appearance44.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance45.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance45;
    appearance46.BorderColor = Color.Silver;
    appearance46.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CellPadding = 0;
    appearance47.BackColor = SystemColors.Control;
    appearance47.BackColor2 = SystemColors.ControlDark;
    appearance47.BackGradientAlignment = (GradientAlignment) 1;
    appearance47.BackGradientStyle = (GradientStyle) 3;
    appearance47.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance49.BackColor = SystemColors.Window;
    appearance49.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance50.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownLineGuid).DisplayMember = "LineName";
    ((Control) this.dropdownLineGuid).Location = new Point(211, 118);
    ((Control) this.dropdownLineGuid).Name = "dropdownLineGuid";
    ((Control) this.dropdownLineGuid).Size = new Size(174, 32 /*0x20*/);
    ((Control) this.dropdownLineGuid).TabIndex = 2;
    ((Control) this.dropdownLineGuid).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.dropdownLineGuid).ValueMember = "LineGUID";
    ((Control) this.dropdownLineGuid).Visible = false;
    ((UltraGridBase) this.dropdownProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.dropdownProducers).DataSource = (object) this.ds;
    appearance51.BackColor = SystemColors.Window;
    appearance51.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Appearance = (AppearanceBase) appearance51;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn45.Header.VisiblePosition = 0;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn46.Header.VisiblePosition = 1;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn47.Header.VisiblePosition = 2;
    ultraGridBand9.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn48.Header.VisiblePosition = 0;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn49.Header.VisiblePosition = 1;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn50.Header.VisiblePosition = 2;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn51.Header.VisiblePosition = 3;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn52.Header.VisiblePosition = 4;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn53.Header.VisiblePosition = 5;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn54.Header.VisiblePosition = 6;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn55.Header.VisiblePosition = 7;
    ultraGridBand10.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55
    });
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand10);
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance52.BackColor = SystemColors.ActiveBorder;
    appearance52.BackColor2 = SystemColors.ControlDark;
    appearance52.BackGradientStyle = (GradientStyle) 2;
    appearance52.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownProducers).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance52;
    appearance53.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance53;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownProducers).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance54.BackColor = SystemColors.ControlLightLight;
    appearance54.BackColor2 = SystemColors.Control;
    appearance54.BackGradientStyle = (GradientStyle) 3;
    appearance54.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.MaxRowScrollRegions = 1;
    appearance55.BackColor = SystemColors.Window;
    appearance55.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance55;
    appearance56.BackColor = SystemColors.Highlight;
    appearance56.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance57.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance57;
    appearance58.BorderColor = Color.Silver;
    appearance58.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.CellPadding = 0;
    appearance59.BackColor = SystemColors.Control;
    appearance59.BackColor2 = SystemColors.ControlDark;
    appearance59.BackGradientAlignment = (GradientAlignment) 1;
    appearance59.BackGradientStyle = (GradientStyle) 3;
    appearance59.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance59;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance61.BackColor = SystemColors.Window;
    appearance61.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance62.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownProducers).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownProducers).DisplayMember = "ProducerName";
    ((Control) this.dropdownProducers).Location = new Point(31 /*0x1F*/, 118);
    ((Control) this.dropdownProducers).Name = "dropdownProducers";
    ((Control) this.dropdownProducers).Size = new Size(174, 32 /*0x20*/);
    ((Control) this.dropdownProducers).TabIndex = 1;
    ((Control) this.dropdownProducers).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.dropdownProducers).ValueMember = "ProducerGUID";
    ((Control) this.dropdownProducers).Visible = false;
    ((Control) this.gridBlocked).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridBlocked).DataSource = (object) this.ds;
    appearance63.BackColor = Color.White;
    appearance63.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Appearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn56.Header.VisiblePosition = 0;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 38;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn57.Header).Caption = "Producer";
    ultraGridColumn57.Header.VisiblePosition = 1;
    ultraGridColumn57.Width = 139;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn58.Header).Caption = "Producer Location";
    ultraGridColumn58.Header.VisiblePosition = 2;
    ultraGridColumn58.Width = 149;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn59.Header).Caption = "Line";
    ultraGridColumn59.Header.VisiblePosition = 4;
    ultraGridColumn59.Width = 168;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn60.Header).Caption = "State";
    ultraGridColumn60.Header.VisiblePosition = 5;
    ultraGridColumn60.Width = 81;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn61.Format = "d";
    ultraGridColumn61.Header.VisiblePosition = 7;
    ultraGridColumn61.Width = 68;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn62.Header).Caption = "Policy Type";
    ultraGridColumn62.Header.VisiblePosition = 6;
    ultraGridColumn62.Width = 67;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn63.Header).Caption = "Company";
    ultraGridColumn63.Header.VisiblePosition = 3;
    ultraGridColumn63.Style = (ColumnStyle) 6;
    ultraGridColumn63.Width = 225;
    ultraGridBand11.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63
    });
    ((UltraGridBase) this.gridBlocked).DisplayLayout.BandsSerializer.Add((object) ultraGridBand11);
    ((UltraGridBase) this.gridBlocked).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance64.BackColor = Color.LightSteelBlue;
    appearance64.FontData.SizeInPoints = 10f;
    appearance64.ForeColor = Color.Black;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance64;
    appearance65.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance65.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance65.ForeColor = Color.Black;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance66.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance66;
    appearance67.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance67;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance68.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance68;
    appearance69.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance69;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance70.BackColor = Color.Transparent;
    appearance70.ForeColor = Color.Black;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance70;
    appearance71.BackColor = Color.WhiteSmoke;
    appearance71.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance71;
    appearance72.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance72;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraGridBase) this.gridBlocked).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridBlocked).Location = new Point(12, 12);
    ((Control) this.gridBlocked).Name = "gridBlocked";
    ((Control) this.gridBlocked).Size = new Size(899, 320);
    ((Control) this.gridBlocked).TabIndex = 0;
    ((Control) this.gridBlocked).Text = "Current Blocked Setups";
    ((UltraControlBase) this.gridBlocked).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridBlocked).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dropdownCompanies).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.dropdownCompanies).DataSource = (object) this.ds;
    appearance73.BackColor = SystemColors.Window;
    appearance73.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance73;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn64.Header.VisiblePosition = 0;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn65.Header.VisiblePosition = 1;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn66.Header.VisiblePosition = 2;
    ultraGridBand12.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66
    });
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn67.Header.VisiblePosition = 0;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn68.Header.VisiblePosition = 1;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn69.Header.VisiblePosition = 2;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn70.Header.VisiblePosition = 3;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn71.Header.VisiblePosition = 4;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn72.Header.VisiblePosition = 5;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn73.Header.VisiblePosition = 6;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn74.Header.VisiblePosition = 7;
    ultraGridBand13.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74
    });
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand12);
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand13);
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance74.BackColor = SystemColors.ActiveBorder;
    appearance74.BackColor2 = SystemColors.ControlDark;
    appearance74.BackGradientStyle = (GradientStyle) 2;
    appearance74.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance74;
    appearance75.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance75;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance76.BackColor = SystemColors.ControlLightLight;
    appearance76.BackColor2 = SystemColors.Control;
    appearance76.BackGradientStyle = (GradientStyle) 3;
    appearance76.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance76;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.MaxRowScrollRegions = 1;
    appearance77.BackColor = SystemColors.Window;
    appearance77.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance77;
    appearance78.BackColor = SystemColors.Highlight;
    appearance78.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance78;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance79.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance79;
    appearance80.BorderColor = Color.Silver;
    appearance80.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance80;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CellPadding = 0;
    appearance81.BackColor = SystemColors.Control;
    appearance81.BackColor2 = SystemColors.ControlDark;
    appearance81.BackGradientAlignment = (GradientAlignment) 1;
    appearance81.BackGradientStyle = (GradientStyle) 3;
    appearance81.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance81;
    ((AppearanceBase) appearance82).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance83.BackColor = SystemColors.Window;
    appearance83.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance83;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance84.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownCompanies).DisplayMember = "LocationName";
    ((Control) this.dropdownCompanies).Location = new Point(391, 156);
    ((Control) this.dropdownCompanies).Name = "dropdownCompanies";
    ((Control) this.dropdownCompanies).Size = new Size(174, 32 /*0x20*/);
    ((Control) this.dropdownCompanies).TabIndex = 11;
    ((UltraDropDownBase) this.dropdownCompanies).ValueMember = "CompanyLocationGUID";
    ((Control) this.dropdownCompanies).Visible = false;
    this.lnkProducerBlockingByBulk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkProducerBlockingByBulk.AutoSize = true;
    this.lnkProducerBlockingByBulk.Location = new Point(571, 357);
    this.lnkProducerBlockingByBulk.Name = "lnkProducerBlockingByBulk";
    this.lnkProducerBlockingByBulk.Size = new Size(128 /*0x80*/, 13);
    this.lnkProducerBlockingByBulk.TabIndex = 12;
    this.lnkProducerBlockingByBulk.TabStop = true;
    this.lnkProducerBlockingByBulk.Text = "Producer Blocking by Bulk";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(923, 591);
    this.Controls.Add((Control) this.lnkProducerBlockingByBulk);
    this.Controls.Add((Control) this.dropdownCompanies);
    this.Controls.Add((Control) this.DbSaveUI1);
    this.Controls.Add((Control) this.groupCombos);
    this.Controls.Add((Control) this.dropdownPolicyTypeID);
    this.Controls.Add((Control) this.dropdownProducerLocations);
    this.Controls.Add((Control) this.dropdownStateID);
    this.Controls.Add((Control) this.dropdownLineGuid);
    this.Controls.Add((Control) this.dropdownProducers);
    this.Controls.Add((Control) this.gridBlocked);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormProducerLineBlocking);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Producer/Line - Blocking";
    ((ISupportInitialize) this.groupCombos).EndInit();
    ((Control) this.groupCombos).ResumeLayout(false);
    ((Control) this.groupCombos).PerformLayout();
    ((ISupportInitialize) this.comboCompanyLocations).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.datetimeEffective).EndInit();
    ((ISupportInitialize) this.MGASimpleComboBox4).EndInit();
    ((ISupportInitialize) this.comboPolicyTypes).EndInit();
    ((ISupportInitialize) this.MGASimpleComboBox2).EndInit();
    ((ISupportInitialize) this.comboProducerLocations).EndInit();
    ((ISupportInitialize) this.comboProducers).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dropdownPolicyTypeID).EndInit();
    ((ISupportInitialize) this.dropdownProducerLocations).EndInit();
    ((ISupportInitialize) this.dropdownStateID).EndInit();
    ((ISupportInitialize) this.dropdownLineGuid).EndInit();
    ((ISupportInitialize) this.dropdownProducers).EndInit();
    ((ISupportInitialize) this.gridBlocked).EndInit();
    ((ISupportInitialize) this.dropdownCompanies).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual UltraGrid gridBlocked
  {
    get => this._gridBlocked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridBlocked_AfterRowActivate);
      UltraGrid gridBlocked1 = this._gridBlocked;
      if (gridBlocked1 != null)
        gridBlocked1.AfterRowActivate -= eventHandler;
      this._gridBlocked = value;
      UltraGrid gridBlocked2 = this._gridBlocked;
      if (gridBlocked2 == null)
        return;
      gridBlocked2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI DbSaveUI1
  {
    get => this._DbSaveUI1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.DbSaveUI1_ClickedNew);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSaveUI1_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSaveUI1_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSaveUI1_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.DbSaveUI1_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_1 = this._DbSaveUI1;
      if (dbSaveUi1_1 != null)
      {
        dbSaveUi1_1.ClickedNew -= eventHandler1;
        dbSaveUi1_1.ClickingCancel -= cancelEventHandler1;
        dbSaveUi1_1.ClickingDelete -= cancelEventHandler2;
        dbSaveUi1_1.ClickingSave -= cancelEventHandler3;
        dbSaveUi1_1.UIStateChanged -= eventHandler2;
      }
      this._DbSaveUI1 = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSaveUi1_2 = this._DbSaveUI1;
      if (dbSaveUi1_2 == null)
        return;
      dbSaveUi1_2.ClickedNew += eventHandler1;
      dbSaveUi1_2.ClickingCancel += cancelEventHandler1;
      dbSaveUi1_2.ClickingDelete += cancelEventHandler2;
      dbSaveUi1_2.ClickingSave += cancelEventHandler3;
      dbSaveUi1_2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("datetimeEffective")]
  internal virtual MGADateTimePicker datetimeEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCompanyLocations")]
  private virtual MGASimpleComboBox comboCompanyLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dropdownCompanies")]
  private virtual UltraDropDown dropdownCompanies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkProducerBlockingByBulk
  {
    get => this._lnkProducerBlockingByBulk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkProducerBlockingByBulk_LinkClicked);
      LinkLabel producerBlockingByBulk1 = this._lnkProducerBlockingByBulk;
      if (producerBlockingByBulk1 != null)
        producerBlockingByBulk1.LinkClicked -= clickedEventHandler;
      this._lnkProducerBlockingByBulk = value;
      LinkLabel producerBlockingByBulk2 = this._lnkProducerBlockingByBulk;
      if (producerBlockingByBulk2 == null)
        return;
      producerBlockingByBulk2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("groupCombos")]
  protected virtual UltraGroupBox groupCombos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProducerLineBlocking()
  {
    this.Load += new EventHandler(this.FormProducerLineBlocking_Load);
    this._producerGuid = Guid.Empty;
    this._producerLocationGuid = Guid.Empty;
    this._logList = new List<string>();
    this.InitializeComponent();
  }

  public FormProducerLineBlocking(Guid producerGuid, Guid producerLocationGuid)
  {
    this.Load += new EventHandler(this.FormProducerLineBlocking_Load);
    this._producerGuid = Guid.Empty;
    this._producerLocationGuid = Guid.Empty;
    this._logList = new List<string>();
    this.InitializeComponent();
    this._producerGuid = producerGuid;
    this._producerLocationGuid = producerLocationGuid;
  }

  protected BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblProducerLineBlocking.TableName];
  }

  private void FormProducerLineBlocking_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    this.FillData();
    this.ConfigureSaveControl();
  }

  private void FillData()
  {
    try
    {
      try
      {
        foreach (DataTable table in (InternalDataCollectionBase) this.ds.Tables)
          table.BeginLoadData();
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
      object obj1 = (object) null;
      object obj2 = (object) null;
      if (!this._producerGuid.Equals(Guid.Empty))
        obj1 = (object) this._producerGuid;
      if (!this._producerLocationGuid.Equals(Guid.Empty))
        obj2 = (object) this._producerLocationGuid;
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[7]
      {
        this.ds.tblProducers.TableName,
        this.ds.tblProducerLocations.TableName,
        this.ds.lstLines.TableName,
        this.ds.lstStates.TableName,
        this.ds.lstPolicyTypes.TableName,
        this.ds.tblCompanyLocations.TableName,
        this.ds.tblProducerLineBlocking.TableName
      }, "dbo.GetProducerLineBlockingData", new object[4]
      {
        (object) "@ProducerGuid",
        obj1,
        (object) "@ProducerLocationGuid",
        obj2
      });
      try
      {
        foreach (DataTable table in (InternalDataCollectionBase) this.ds.Tables)
          table.EndLoadData();
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void DbSaveUI1_ClickedNew(object sender, EventArgs e)
  {
    dsProducerLinesBlocking.tblProducerLineBlockingRow row = this.ds.tblProducerLineBlocking.NewtblProducerLineBlockingRow();
    row.Effective = DateTime.Now;
    this.ds.tblProducerLineBlocking.AddtblProducerLineBlockingRow(row);
    this.bmb.Position = this.ds.tblProducerLineBlocking.Count - 1;
    this.ClickNewOnClient();
  }

  private void DbSaveUI1_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblProducerLineBlocking.RejectChanges();
    this.CancelOnClient();
  }

  private void DbSaveUI1_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this setup?", "Delete Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int blockId = this.ds.tblProducerLineBlocking[this.bmb.Position].BlockID;
    this.CreateLog(true);
    this.ds.tblProducerLineBlocking[this.bmb.Position].Delete();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblProducerLineBlocking);
    this.LogChanges();
    this.DeleteOnClient(blockId);
    this.ConfigureSaveControl();
  }

  protected virtual bool IsValidForm()
  {
    this.err.SetError((Control) this.comboProducers, string.Empty);
    bool flag;
    if (this.comboProducers.Value != null && this.comboProducerLocations.Value != null)
    {
      this.err.SetError((Control) this.comboProducers, "Only one item can be selected between producer and producer location.");
      flag = false;
    }
    else
    {
      try
      {
        foreach (Control control in ((Control) this.groupCombos).Controls)
        {
          if (control is MGASimpleComboBox mgaSimpleComboBox && mgaSimpleComboBox.Value != null)
          {
            flag = true;
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
      if (string.IsNullOrEmpty(this.err.GetError((Control) this.comboProducers)))
      {
        int num = (int) MessageBox.Show("Please select at least one blocking criteria.", "No Criteria Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      flag = false;
    }
label_12:
    return flag;
  }

  private void DbSaveUI1_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.IsValidForm())
    {
      int position = this.bmb.Position;
      this.CreateLog(false);
      this.bmb.EndCurrentEdit();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblProducerLineBlocking);
      this.LogChanges();
      this.SaveOnClient(this.ds.tblProducerLineBlocking[position].BlockID);
    }
    else
      e.Cancel = true;
  }

  private void DbSaveUI1_UIStateChanged(object sender, EventArgs e)
  {
    bool flag = this.DbSaveUI1.UIState == UIState.Editing;
    ((Control) this.gridBlocked).Enabled = !flag;
    try
    {
      foreach (Control control in ((Control) this.groupCombos).Controls)
      {
        if (control != this.DbSaveUI1)
          control.Enabled = flag;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.groupCombos).Enabled = true;
    if (flag)
      return;
    this.ConfigureSaveControl();
  }

  private void ConfigureSaveControl()
  {
    if (this.ds.tblProducerLineBlocking.Count > 0)
      this.DbSaveUI1.UIState = UIState.HasRecordsNotEditing;
    else
      this.DbSaveUI1.UIState = UIState.NoRecordsNotEditing;
  }

  private void lnkProducerBlockingByBulk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (FormProducerLineBulkBlocking)))
      ;
  }

  protected virtual void SaveOnClient(int BlockID)
  {
  }

  protected virtual void CancelOnClient()
  {
  }

  protected virtual void DeleteOnClient(int BlockID)
  {
  }

  protected virtual void ClickNewOnClient()
  {
  }

  protected virtual void ActiveRowOnClient(int BlockID)
  {
  }

  private void gridBlocked_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridBlocked).ActiveRow == null)
      return;
    int BlockID = (int) ((UltraGridBase) this.gridBlocked).ActiveRow.Cells["BlockID"].Value;
    Database.MoveTo((object) BlockID, this.ds.tblProducerLineBlocking.BlockIDColumn.ColumnName, (DataTable) this.ds.tblProducerLineBlocking, this.bmb);
    this.ActiveRowOnClient(BlockID);
  }

  private void CreateLog(bool isDeleting)
  {
    this._logList.Clear();
    if (this.bmb.Position != -1 && (this.ds.tblProducerLineBlocking[this.bmb.Position].RowState == DataRowState.Added || isDeleting))
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      string str3 = string.Empty;
      string str4 = string.Empty;
      string str5 = string.Empty;
      string str6 = string.Empty;
      string str7 = string.Empty;
      if (!string.IsNullOrEmpty(this.comboProducers.Text))
        str1 = $"Producer - {this.comboProducers.Text}";
      if (!string.IsNullOrEmpty(this.comboProducerLocations.Text))
        str2 = $"Producer Loc - {this.comboProducerLocations.Text}";
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.datetimeEffective.Value)))
        str3 = $"Effective - {Convert.ToDateTime(RuntimeHelpers.GetObjectValue(this.datetimeEffective.Value)).ToShortDateString()}";
      if (!string.IsNullOrEmpty(this.MGASimpleComboBox4.Text))
        str4 = $"State - {this.MGASimpleComboBox4.Text}";
      if (!string.IsNullOrEmpty(this.comboCompanyLocations.Text))
        str5 = $"Company - {this.comboCompanyLocations.Text}";
      if (!string.IsNullOrEmpty(this.MGASimpleComboBox2.Text))
        str6 = $"Line - {this.MGASimpleComboBox2.Text}";
      if (!string.IsNullOrEmpty(this.comboPolicyTypes.Text))
        str7 = $"Policy Type - {this.comboPolicyTypes.Text}";
      this._logList.Add($"{Interaction.IIf(this.ds.tblProducerLineBlocking[this.bmb.Position].RowState == DataRowState.Added, (object) "Added", (object) "Deleted").ToString()} Producer Lines Blocking - {str3} {str1} {str2} {str4} {str5} {str6} {str7}");
    }
    else
    {
      Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
      Dictionary<string, string> dictionary2 = dictionary1;
      dictionary2.Add("ProducerGuid", "Producer");
      dictionary2.Add("ProducerLocationGuid", "Producer Location");
      dictionary2.Add("CompanyLocationGuid", "Company Location");
      dictionary2.Add("LineGuid", "Line");
      dictionary2.Add("StateID", "State");
      dictionary2.Add("PolicyTypeID", "Policy Type");
      dictionary2.Add("Effective", "Effective");
      dsProducerLinesBlocking.tblProducerLineBlockingRow producerLineBlockingRow = this.ds.tblProducerLineBlocking[this.bmb.Position];
      string empty = string.Empty;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.datetimeEffective.Value)))
        empty = this.datetimeEffective.Value.ToString();
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblProducerLineBlocking.Columns)
        {
          if (dictionary1.ContainsKey(column.ColumnName))
          {
            string str8 = "<null>";
            string str9 = "<null>";
            if (producerLineBlockingRow[column] != DBNull.Value)
              str8 = producerLineBlockingRow[column].ToString();
            if (producerLineBlockingRow[column, DataRowVersion.Original] != DBNull.Value)
              str9 = producerLineBlockingRow[column, DataRowVersion.Original].ToString();
            Guid result1;
            int result2;
            if (!str8.Equals("<null>"))
            {
              if (Guid.TryParse(str8, out result1))
                str8 = this.GetEntityValue(column.ColumnName, (object) str8);
              if (int.TryParse(str8, out result2))
                str8 = this.GetEntityValue(column.ColumnName, (object) str8);
            }
            if (!str9.Equals("<null>"))
            {
              if (Guid.TryParse(str9, out result1))
                str9 = this.GetEntityValue(column.ColumnName, (object) str9);
              if (int.TryParse(str9, out result2))
                str9 = this.GetEntityValue(column.ColumnName, (object) str9);
            }
            if (!str8.Equals(str9))
            {
              string columnName = column.ColumnName;
              if (dictionary1.ContainsKey(column.ColumnName))
                columnName = dictionary1[column.ColumnName];
              this._logList.Add($"Producer Lines Blocking {empty} - Change {columnName} from {str9} to {str8}");
            }
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

  private string GetEntityValue(string columnName, object value)
  {
    string Left = columnName;
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "ProducerGuid", false) == 0 ? this.ds.tblProducers.FindByProducerGUID(new Guid(value.ToString())).ProducerName : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "ProducerLocationGuid", false) == 0 ? this.ds.tblProducerLocations.FindByProducerLocationGUID(new Guid(value.ToString())).Name : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CompanyLocationGuid", false) == 0 ? this.ds.tblCompanyLocations.FindByCompanyLocationGUID(new Guid(value.ToString())).LocationName : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "LineGuid", false) == 0 ? this.ds.lstLines.FindByLineGUID(new Guid(value.ToString())).LineName : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "PolicyTypeID", false) == 0 ? this.ds.lstPolicyTypes.FindByPolicyTypeID(Convert.ToInt32(RuntimeHelpers.GetObjectValue(value))).Description : string.Empty))));
  }

  private void LogChanges()
  {
    Guid identifier = Guid.Empty;
    if (!this._producerGuid.Equals(Guid.Empty))
      identifier = this._producerGuid;
    if (!this._producerLocationGuid.Equals(Guid.Empty))
      identifier = this._producerLocationGuid;
    try
    {
      foreach (string log in this._logList)
      {
        if (identifier.Equals(Guid.Empty))
          CurrentUser.Instance.LogAction(log);
        else
          CurrentUser.Instance.LogAction(log, identifier);
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this._logList.Clear();
  }
}
