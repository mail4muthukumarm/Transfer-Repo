// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formScheduleExpense
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formScheduleExpense : AccountingNoteDocumentSupport
{
  private Panel panel3;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private MGACheckBox chkReOccurring;
  private NumericUpDown numericOccursEvery;
  private MGASimpleComboBox comboScheduleType;
  private Label label4;
  private Label labelOccursEvery;
  private MGATextBox textboxNumberOfOccurrences;
  private Label labelNumberOfOccurrences;
  private MGACheckBox chkSunday;
  internal MGACheckBox chkWednesday;
  internal MGACheckBox chkFriday;
  internal MGACheckBox chkTuesday;
  internal MGACheckBox chkMonday;
  internal MGACheckBox chkSaturday;
  internal MGACheckBox chkThursday;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
  private MGACheckBox checkNoLimit;
  private UltraExplorerBarContainerControl containerBiMonthlySettings;
  private NumericUpDown numericBiMonthly1;
  private NumericUpDown numericBiMonthly2;
  private Label label1;
  private Label label2;
  private Label label5;
  private MGADateTimePicker dateTimeStart;
  private RadioButton radioAccrued;
  private RadioButton radioPrePaid;
  private System.ComponentModel.Container components;
  private PurchaseOrderExpense poObject;
  private ExpenseSchedule schedule;

  public formScheduleExpense(PurchaseOrderExpense PoObject)
  {
    this.InitializeComponent();
    this.LoadScheduleTypes();
    this.poObject = PoObject;
    this.schedule = new ExpenseSchedule(PoObject);
  }

  public formScheduleExpense(ExpenseSchedule Schedule)
  {
    this.InitializeComponent();
    this.LoadScheduleTypes();
    this.schedule = Schedule;
    this.DisplayScheduleObject();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem = new UltraExplorerBarItem();
    UltraExplorerBarGroup explorerBarGroup4 = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formScheduleExpense));
    Appearance appearance4 = new Appearance();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.dateTimeStart = new MGADateTimePicker();
    this.label5 = new Label();
    this.checkNoLimit = new MGACheckBox();
    this.numericOccursEvery = new NumericUpDown();
    this.comboScheduleType = new MGASimpleComboBox();
    this.label4 = new Label();
    this.labelOccursEvery = new Label();
    this.textboxNumberOfOccurrences = new MGATextBox();
    this.labelNumberOfOccurrences = new Label();
    this.chkReOccurring = new MGACheckBox();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.chkWednesday = new MGACheckBox();
    this.chkFriday = new MGACheckBox();
    this.chkTuesday = new MGACheckBox();
    this.chkMonday = new MGACheckBox();
    this.chkSaturday = new MGACheckBox();
    this.chkThursday = new MGACheckBox();
    this.chkSunday = new MGACheckBox();
    this.containerBiMonthlySettings = new UltraExplorerBarContainerControl();
    this.label2 = new Label();
    this.label1 = new Label();
    this.numericBiMonthly2 = new NumericUpDown();
    this.numericBiMonthly1 = new NumericUpDown();
    this.ultraExplorerBarContainerControl4 = new UltraExplorerBarContainerControl();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.panel3 = new Panel();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.radioAccrued = new RadioButton();
    this.radioPrePaid = new RadioButton();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.dateTimeStart).BeginInit();
    ((ISupportInitialize) this.checkNoLimit).BeginInit();
    this.numericOccursEvery.BeginInit();
    ((ISupportInitialize) this.comboScheduleType).BeginInit();
    ((ISupportInitialize) this.textboxNumberOfOccurrences).BeginInit();
    ((ISupportInitialize) this.chkReOccurring).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.chkWednesday).BeginInit();
    ((ISupportInitialize) this.chkFriday).BeginInit();
    ((ISupportInitialize) this.chkTuesday).BeginInit();
    ((ISupportInitialize) this.chkMonday).BeginInit();
    ((ISupportInitialize) this.chkSaturday).BeginInit();
    ((ISupportInitialize) this.chkThursday).BeginInit();
    ((ISupportInitialize) this.chkSunday).BeginInit();
    ((Control) this.containerBiMonthlySettings).SuspendLayout();
    this.numericBiMonthly2.BeginInit();
    this.numericBiMonthly1.BeginInit();
    ((Control) this.ultraExplorerBarContainerControl4).SuspendLayout();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.radioPrePaid);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.radioAccrued);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.dateTimeStart);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.label5);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.checkNoLimit);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.numericOccursEvery);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.comboScheduleType);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.label4);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.labelOccursEvery);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.textboxNumberOfOccurrences);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.labelNumberOfOccurrences);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.chkReOccurring);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(22, 43);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(381, 147);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 2;
    this.dateTimeStart.FormatString = "D";
    ((Control) this.dateTimeStart).Location = new Point(112 /*0x70*/, 24);
    this.dateTimeStart.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeStart).Name = "dateTimeStart";
    ((Control) this.dateTimeStart).Size = new Size(200, 20);
    ((Control) this.dateTimeStart).TabIndex = 9;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(8, 24);
    this.label5.Name = "label5";
    this.label5.Size = new Size(59, 17);
    this.label5.TabIndex = 8;
    this.label5.Text = "Start Date:";
    ((Control) this.checkNoLimit).BackColor = Color.Transparent;
    ((Control) this.checkNoLimit).Enabled = false;
    ((Control) this.checkNoLimit).Location = new Point(168, 48 /*0x30*/);
    ((Control) this.checkNoLimit).Name = "checkNoLimit";
    ((Control) this.checkNoLimit).Size = new Size(216, 16 /*0x10*/);
    ((Control) this.checkNoLimit).TabIndex = 3;
    ((Control) this.checkNoLimit).Text = "No Limit (Maximum 5 years)";
    ((UltraToggleEditorBase) this.checkNoLimit).CheckedChanged += new EventHandler(this.checkNoLimit_CheckedChanged);
    this.numericOccursEvery.BorderStyle = BorderStyle.FixedSingle;
    this.numericOccursEvery.Enabled = false;
    this.numericOccursEvery.Location = new Point(112 /*0x70*/, 96 /*0x60*/);
    this.numericOccursEvery.Maximum = new Decimal(new int[4]
    {
      31 /*0x1F*/,
      0,
      0,
      0
    });
    this.numericOccursEvery.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericOccursEvery.Name = "numericOccursEvery";
    this.numericOccursEvery.Size = new Size(40, 21);
    this.numericOccursEvery.TabIndex = 7;
    this.numericOccursEvery.TextAlign = HorizontalAlignment.Center;
    this.numericOccursEvery.Value = new Decimal(new int[4]
    {
      31 /*0x1F*/,
      0,
      0,
      0
    });
    this.comboScheduleType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboScheduleType.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboScheduleType).DisplayMember = "";
    this.comboScheduleType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboScheduleType).Enabled = false;
    ((Control) this.comboScheduleType).Location = new Point(112 /*0x70*/, 72);
    this.comboScheduleType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboScheduleType).Name = "comboScheduleType";
    ((Control) this.comboScheduleType).Size = new Size(264, 20);
    ((Control) this.comboScheduleType).TabIndex = 5;
    ((UltraDropDownBase) this.comboScheduleType).ValueMember = "";
    this.comboScheduleType.RowSelected += new RowSelectedEventHandler(this.comboScheduleType_RowSelected);
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(8, 72);
    this.label4.Name = "label4";
    this.label4.Size = new Size(81, 17);
    this.label4.TabIndex = 4;
    this.label4.Text = "Schedule Type:";
    this.labelOccursEvery.AutoSize = true;
    this.labelOccursEvery.BackColor = Color.Transparent;
    this.labelOccursEvery.Location = new Point(8, 96 /*0x60*/);
    this.labelOccursEvery.Name = "labelOccursEvery";
    this.labelOccursEvery.Size = new Size(73, 17);
    this.labelOccursEvery.TabIndex = 6;
    this.labelOccursEvery.Text = "Occurs Every:";
    ((Control) this.textboxNumberOfOccurrences).Enabled = false;
    ((Control) this.textboxNumberOfOccurrences).Location = new Point(112 /*0x70*/, 48 /*0x30*/);
    this.textboxNumberOfOccurrences.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxNumberOfOccurrences).Name = "textboxNumberOfOccurrences";
    ((Control) this.textboxNumberOfOccurrences).Size = new Size(48 /*0x30*/, 20);
    ((Control) this.textboxNumberOfOccurrences).TabIndex = 2;
    this.labelNumberOfOccurrences.AutoSize = true;
    this.labelNumberOfOccurrences.BackColor = Color.Transparent;
    this.labelNumberOfOccurrences.Location = new Point(8, 48 /*0x30*/);
    this.labelNumberOfOccurrences.Name = "labelNumberOfOccurrences";
    this.labelNumberOfOccurrences.Size = new Size(97, 17);
    this.labelNumberOfOccurrences.TabIndex = 1;
    this.labelNumberOfOccurrences.Text = "# Of Occurrences:";
    ((Control) this.chkReOccurring).BackColor = Color.Transparent;
    ((Control) this.chkReOccurring).Location = new Point(8, 0);
    ((Control) this.chkReOccurring).Name = "chkReOccurring";
    ((Control) this.chkReOccurring).Size = new Size(152, 16 /*0x10*/);
    ((Control) this.chkReOccurring).TabIndex = 0;
    ((Control) this.chkReOccurring).Text = "Re-Occurring Expense";
    ((UltraToggleEditorBase) this.chkReOccurring).CheckedChanged += new EventHandler(this.chkReOccurring_CheckedChanged);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkWednesday);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkFriday);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkTuesday);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkMonday);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkSaturday);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkThursday);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.chkSunday);
    ((Control) this.ultraExplorerBarContainerControl3).Enabled = false;
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(22, 246);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(381, 40);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 4;
    ((Control) this.chkWednesday).BackColor = Color.Transparent;
    ((Control) this.chkWednesday).Location = new Point(296, 0);
    ((Control) this.chkWednesday).Name = "chkWednesday";
    ((Control) this.chkWednesday).Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    ((Control) this.chkWednesday).TabIndex = 3;
    ((Control) this.chkWednesday).Text = "Wednesday";
    ((Control) this.chkFriday).BackColor = Color.Transparent;
    ((Control) this.chkFriday).Location = new Point(160 /*0xA0*/, 24);
    ((Control) this.chkFriday).Name = "chkFriday";
    ((Control) this.chkFriday).Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    ((Control) this.chkFriday).TabIndex = 5;
    ((Control) this.chkFriday).Text = "Friday";
    ((Control) this.chkTuesday).BackColor = Color.Transparent;
    ((Control) this.chkTuesday).Location = new Point(192 /*0xC0*/, 0);
    ((Control) this.chkTuesday).Name = "chkTuesday";
    ((Control) this.chkTuesday).Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    ((Control) this.chkTuesday).TabIndex = 2;
    ((Control) this.chkTuesday).Text = "Tuesday";
    ((Control) this.chkMonday).BackColor = Color.Transparent;
    ((Control) this.chkMonday).Location = new Point(96 /*0x60*/, 0);
    ((Control) this.chkMonday).Name = "chkMonday";
    ((Control) this.chkMonday).Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    ((Control) this.chkMonday).TabIndex = 1;
    ((Control) this.chkMonday).Text = "Monday";
    ((Control) this.chkSaturday).BackColor = Color.Transparent;
    ((Control) this.chkSaturday).Location = new Point(256 /*0x0100*/, 24);
    ((Control) this.chkSaturday).Name = "chkSaturday";
    ((Control) this.chkSaturday).Size = new Size(72, 16 /*0x10*/);
    ((Control) this.chkSaturday).TabIndex = 6;
    ((Control) this.chkSaturday).Text = "Saturday";
    ((Control) this.chkThursday).BackColor = Color.Transparent;
    ((Control) this.chkThursday).Location = new Point(56, 24);
    ((Control) this.chkThursday).Name = "chkThursday";
    ((Control) this.chkThursday).Size = new Size(72, 16 /*0x10*/);
    ((Control) this.chkThursday).TabIndex = 4;
    ((Control) this.chkThursday).Text = "Thursday";
    ((Control) this.chkSunday).BackColor = Color.Transparent;
    ((Control) this.chkSunday).Location = new Point(0, 0);
    ((Control) this.chkSunday).Name = "chkSunday";
    ((Control) this.chkSunday).Size = new Size(72, 16 /*0x10*/);
    ((Control) this.chkSunday).TabIndex = 0;
    ((Control) this.chkSunday).Text = "Sunday";
    ((Control) this.containerBiMonthlySettings).Controls.Add((Control) this.label2);
    ((Control) this.containerBiMonthlySettings).Controls.Add((Control) this.label1);
    ((Control) this.containerBiMonthlySettings).Controls.Add((Control) this.numericBiMonthly2);
    ((Control) this.containerBiMonthlySettings).Controls.Add((Control) this.numericBiMonthly1);
    ((Control) this.containerBiMonthlySettings).Enabled = false;
    ((Control) this.containerBiMonthlySettings).Location = new Point(22, 342);
    ((Control) this.containerBiMonthlySettings).Name = "containerBiMonthlySettings";
    ((Control) this.containerBiMonthlySettings).Size = new Size(381, 24);
    ((Control) this.containerBiMonthlySettings).TabIndex = 1;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(216, 2);
    this.label2.Name = "label2";
    this.label2.TabIndex = 1;
    this.label2.Text = "Second Occurence:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 2);
    this.label1.Name = "label1";
    this.label1.Size = new Size(85, 17);
    this.label1.TabIndex = 14;
    this.label1.Text = "First Occurence:";
    this.numericBiMonthly2.BorderStyle = BorderStyle.FixedSingle;
    this.numericBiMonthly2.Location = new Point(320, 0);
    this.numericBiMonthly2.Maximum = new Decimal(new int[4]
    {
      31 /*0x1F*/,
      0,
      0,
      0
    });
    this.numericBiMonthly2.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericBiMonthly2.Name = "numericBiMonthly2";
    this.numericBiMonthly2.Size = new Size(40, 21);
    this.numericBiMonthly2.TabIndex = 2;
    this.numericBiMonthly2.TextAlign = HorizontalAlignment.Center;
    this.numericBiMonthly2.Value = new Decimal(new int[4]
    {
      15,
      0,
      0,
      0
    });
    this.numericBiMonthly1.BorderStyle = BorderStyle.FixedSingle;
    this.numericBiMonthly1.Location = new Point(96 /*0x60*/, 0);
    this.numericBiMonthly1.Maximum = new Decimal(new int[4]
    {
      31 /*0x1F*/,
      0,
      0,
      0
    });
    this.numericBiMonthly1.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericBiMonthly1.Name = "numericBiMonthly1";
    this.numericBiMonthly1.Size = new Size(40, 21);
    this.numericBiMonthly1.TabIndex = 0;
    this.numericBiMonthly1.TextAlign = HorizontalAlignment.Center;
    this.numericBiMonthly1.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    ((Control) this.ultraExplorerBarContainerControl4).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraExplorerBarContainerControl4).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl4).Location = new Point(22, 397);
    ((Control) this.ultraExplorerBarContainerControl4).Name = "ultraExplorerBarContainerControl4";
    ((Control) this.ultraExplorerBarContainerControl4).Size = new Size(381, 24);
    ((Control) this.ultraExplorerBarContainerControl4).TabIndex = 2;
    ((Control) this.buttonSave).Location = new Point(192 /*0xC0*/, 0);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(88, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "Save Schedule";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((Control) this.buttonCancel).Location = new Point(288, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.panel3.Controls.Add((Control) this.ultraExplorerBar1);
    this.panel3.Dock = DockStyle.Fill;
    this.panel3.Location = new Point(0, 0);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(418, 440);
    this.panel3.TabIndex = 1;
    this.ultraExplorerBar1.AnimationEnabled = false;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl4);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.containerBiMonthlySettings);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup1.Settings.ContainerHeight = 149;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Re-Occuring Expense";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup2.Enabled = false;
    explorerBarGroup2.Key = "DailySchedule";
    explorerBarGroup2.Settings.ContainerHeight = 42;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Daily Schedule";
    explorerBarGroup3.Container = this.containerBiMonthlySettings;
    explorerBarGroup3.Items.AddRange(new UltraExplorerBarItem[1]
    {
      ultraExplorerBarItem
    });
    explorerBarGroup3.Settings.ContainerHeight = 26;
    explorerBarGroup3.Settings.NavigationAllowHide = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Bi-Monthly Settings";
    explorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
    explorerBarGroup4.Settings.ContainerHeight = 26;
    explorerBarGroup4.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup4.Settings.Style = (GroupStyle) 6;
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[4]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3,
      explorerBarGroup4
    });
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.White;
    ((AppearanceBase) appearance3).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance3).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageBackground = (Image) resourceManager.GetObject("appearance3.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance4;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.GroupSettings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(418, 440);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 0;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.radioAccrued.BackColor = Color.Transparent;
    this.radioAccrued.Checked = true;
    this.radioAccrued.FlatStyle = FlatStyle.Flat;
    this.radioAccrued.Location = new Point(112 /*0x70*/, 128 /*0x80*/);
    this.radioAccrued.Name = "radioAccrued";
    this.radioAccrued.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.radioAccrued.TabIndex = 10;
    this.radioAccrued.TabStop = true;
    this.radioAccrued.Text = "Accrued Expenses";
    this.radioPrePaid.BackColor = Color.Transparent;
    this.radioPrePaid.FlatStyle = FlatStyle.Flat;
    this.radioPrePaid.Location = new Point(232, 128 /*0x80*/);
    this.radioPrePaid.Name = "radioPrePaid";
    this.radioPrePaid.Size = new Size(120, 16 /*0x10*/);
    this.radioPrePaid.TabIndex = 11;
    this.radioPrePaid.Text = "Pre-Paid Expenses";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(418, 440);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panel3);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formScheduleExpense);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Schedule Expense";
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeStart).EndInit();
    ((ISupportInitialize) this.checkNoLimit).EndInit();
    this.numericOccursEvery.EndInit();
    ((ISupportInitialize) this.comboScheduleType).EndInit();
    ((ISupportInitialize) this.textboxNumberOfOccurrences).EndInit();
    ((ISupportInitialize) this.chkReOccurring).EndInit();
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.chkWednesday).EndInit();
    ((ISupportInitialize) this.chkFriday).EndInit();
    ((ISupportInitialize) this.chkTuesday).EndInit();
    ((ISupportInitialize) this.chkMonday).EndInit();
    ((ISupportInitialize) this.chkSaturday).EndInit();
    ((ISupportInitialize) this.chkThursday).EndInit();
    ((ISupportInitialize) this.chkSunday).EndInit();
    ((Control) this.containerBiMonthlySettings).ResumeLayout(false);
    this.numericBiMonthly2.EndInit();
    this.numericBiMonthly1.EndInit();
    ((Control) this.ultraExplorerBarContainerControl4).ResumeLayout(false);
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public ExpenseSchedule Schedule => this.schedule;

  private void LoadScheduleTypes()
  {
    ((UltraGridBase) this.comboScheduleType).DataSource = (object) new DataTable()
    {
      Columns = {
        new DataColumn("ScheduleTypes", typeof (string))
      },
      Rows = {
        new object[1]{ (object) "Daily" },
        new object[1]{ (object) "Weekly" },
        new object[1]{ (object) "Every Two Weeks" },
        new object[1]{ (object) "Monthly" },
        new object[1]{ (object) "Bi-Monthly" },
        new object[1]{ (object) "Every Two Months" },
        new object[1]{ (object) "Quarterly" },
        new object[1]{ (object) "Semi-Annually" },
        new object[1]{ (object) "Annually" }
      }
    };
    ((UltraDropDownBase) this.comboScheduleType).DisplayMember = "ScheduleTypes";
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void DisplayScheduleObject()
  {
    if (this.schedule == null)
      return;
    this.comboScheduleType.Value = (object) this.schedule.ScheduleType;
  }

  private void SetScheduleObject()
  {
    this.schedule = new ExpenseSchedule(this.poObject);
    this.schedule.DueDate = this.dateTimeStart.DateTime;
    this.schedule.StartDate = this.dateTimeStart.DateTime;
    this.schedule.ScheduleJournalType = !this.radioAccrued.Checked ? Utilities.ExpenseScheduleJournalType.Prepaid : Utilities.ExpenseScheduleJournalType.Accrued;
    if (!((UltraToggleEditorBase) this.chkReOccurring).Checked)
    {
      this.schedule.ScheduleType = Utilities.SchedulingType.None;
    }
    else
    {
      this.Schedule.ScheduleType = (Utilities.SchedulingType) ((UltraDropDownBase) this.comboScheduleType).SelectedRow.Index;
      this.Schedule.NumberOfOccurences = !((UltraToggleEditorBase) this.checkNoLimit).Checked ? int.Parse(((Control) this.textboxNumberOfOccurrences).Text) : 100000;
      if (this.numericOccursEvery.Enabled)
        this.Schedule.OccursEvery = Convert.ToInt32(this.numericOccursEvery.Value);
      if (this.Schedule.ScheduleType == Utilities.SchedulingType.BiMonthly)
      {
        this.Schedule.BiMonthlyFirstOccurrence = (int) this.numericBiMonthly1.Value;
        this.Schedule.BiMonthlySecondOccurrence = (int) this.numericBiMonthly2.Value;
      }
      this.Schedule.OccurenceDays = this.BuildOccurrenceDays();
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void comboScheduleType_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    ((Control) this.ultraExplorerBarContainerControl3).Enabled = e.Row.Index == 0 || e.Row.Index == 1 || e.Row.Index == 2;
    this.labelOccursEvery.Enabled = e.Row.Index == 3 || e.Row.Index == 5 || e.Row.Index == 6 || e.Row.Index == 7;
    this.numericOccursEvery.Enabled = e.Row.Index == 3 || e.Row.Index == 5 || e.Row.Index == 6 || e.Row.Index == 7;
    ((Control) this.containerBiMonthlySettings).Enabled = e.Row.Index == 4;
  }

  private void chkReOccurring_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.checkNoLimit).Enabled = ((UltraToggleEditorBase) this.chkReOccurring).Checked;
    ((Control) this.textboxNumberOfOccurrences).Enabled = ((UltraToggleEditorBase) this.chkReOccurring).Checked;
    ((Control) this.comboScheduleType).Enabled = ((UltraToggleEditorBase) this.chkReOccurring).Checked;
    this.numericOccursEvery.Enabled = ((UltraToggleEditorBase) this.chkReOccurring).Checked;
  }

  private Utilities.OccurenceDays BuildOccurrenceDays()
  {
    Utilities.OccurenceDays occurenceDays = Utilities.OccurenceDays.None;
    if (((UltraToggleEditorBase) this.chkSunday).Checked && ((UltraToggleEditorBase) this.chkMonday).Checked && ((UltraToggleEditorBase) this.chkTuesday).Checked && ((UltraToggleEditorBase) this.chkWednesday).Checked && ((UltraToggleEditorBase) this.chkThursday).Checked && ((UltraToggleEditorBase) this.chkFriday).Checked && ((UltraToggleEditorBase) this.chkSaturday).Checked)
      return Utilities.OccurenceDays.All;
    if (((UltraToggleEditorBase) this.chkSunday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Sunday;
    if (((UltraToggleEditorBase) this.chkMonday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Monday;
    if (((UltraToggleEditorBase) this.chkTuesday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Tuesday;
    if (((UltraToggleEditorBase) this.chkWednesday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Wednesday;
    if (((UltraToggleEditorBase) this.chkThursday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Thursday;
    if (((UltraToggleEditorBase) this.chkFriday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Friday;
    if (((UltraToggleEditorBase) this.chkSaturday).Checked)
      occurenceDays |= Utilities.OccurenceDays.Saturday;
    return occurenceDays;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.SetScheduleObject();
  }

  private bool ValidateForm()
  {
    if (((UltraToggleEditorBase) this.chkReOccurring).Checked && !((UltraToggleEditorBase) this.checkNoLimit).Checked && (((Control) this.textboxNumberOfOccurrences).Text.Equals(string.Empty) || ((Control) this.textboxNumberOfOccurrences).Text.Length == 0 || !Information.IsNumeric((object) ((Control) this.textboxNumberOfOccurrences).Text)))
    {
      int num = (int) MessageBox.Show("Number of occurrence must be a valid number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboScheduleType).SelectedRow == null && ((UltraToggleEditorBase) this.chkReOccurring).Checked)
    {
      int num = (int) MessageBox.Show("You must select a scheduling type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((((UltraDropDownBase) this.comboScheduleType).SelectedRow.Index == 1 || ((UltraDropDownBase) this.comboScheduleType).SelectedRow.Index == 2) && !((UltraToggleEditorBase) this.chkMonday).Checked && !((UltraToggleEditorBase) this.chkTuesday).Checked && !((UltraToggleEditorBase) this.chkWednesday).Checked && !((UltraToggleEditorBase) this.chkThursday).Checked && !((UltraToggleEditorBase) this.chkFriday).Checked && !((UltraToggleEditorBase) this.chkSaturday).Checked && !((UltraToggleEditorBase) this.chkSunday).Checked)
    {
      int num1 = (int) MessageBox.Show("You must select a day on which the expense should occur.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    if (((UltraDropDownBase) this.comboScheduleType).SelectedRow.Index == 3 && this.numericOccursEvery.Value > 28M && MessageBox.Show($"The system will set the occurrences for the end of the month for the months that have less than {this.numericOccursEvery.Value.ToString()} days. Do you wish to continue?", "Auto-Set Occurrences?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return false;
    if (((UltraDropDownBase) this.comboScheduleType).SelectedRow.Index == 4)
    {
      if (this.numericBiMonthly1.Value == this.numericBiMonthly2.Value)
      {
        int num2 = (int) MessageBox.Show("Bi-monthly settings can not occur on the same day!", "Invalid Bi-Monthly Settings!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (this.numericBiMonthly1.Value > this.numericBiMonthly2.Value)
      {
        int num3 = (int) MessageBox.Show("The second bi-monthly occurrence can not occur before the first occurrence!", "Invalid Bi-Monthly Settings!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if ((this.numericBiMonthly1.Value > 28M || this.numericBiMonthly2.Value > 28M) && MessageBox.Show("The system will select the last day of the month for those months that do not have more than 28 days. Do you wish to continue?!", "Invalid Bi-Monthly Settings!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return false;
    }
    return true;
  }

  private void checkNoLimit_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.textboxNumberOfOccurrences).Enabled = !((UltraToggleEditorBase) this.checkNoLimit).Checked;
  }
}
