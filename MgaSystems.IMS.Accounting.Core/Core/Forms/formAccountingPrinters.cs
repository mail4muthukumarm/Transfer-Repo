// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formAccountingPrinters
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formAccountingPrinters : AccountingNoteDocumentSupport
{
  internal PrintDialog PrintDialog1;
  internal PrintDocument PrintDocument1;
  internal UltraExplorerBar UltraExplorerBar1;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  internal UltraButton btnChangeCheckPrinter;
  internal Label Label1;
  internal Label Label6;
  internal Label lblCheckPrinter;
  internal Label Label4;
  internal Label lblCheckPrinterTray;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl2;
  internal UltraButton btnChangeDetailPrinter;
  internal Label Label3;
  internal Label Label9;
  internal Label Label2;
  internal Label lblCheckDetailPrinterTray;
  internal Label lblDetailsPrinter;
  private UltraGrid gridPrinterSettings;
  private UltraLabel ultraLabel1;
  private UltraGroupBox ultraGroupBox1;
  private MGATextBox textPrinterFriendlyName;
  private MGATextBox textCheckDetailSettings;
  private UltraLabel ultraLabel5;
  private MGATextBox textCheckDetailName;
  private UltraLabel ultraLabel4;
  private MGATextBox textCheckPrinterSettings;
  private UltraLabel ultraLabel3;
  private MGATextBox textCheckPrinterName;
  private UltraLabel ultraLabel2;
  internal UltraButton buttonSave;
  internal UltraButton buttonCancel;
  internal UltraButton buttonDelete;
  private System.ComponentModel.Container components;
  private int? _currentPrinterId;

  public formAccountingPrinters()
  {
    this.InitializeComponent();
    this.LoadCheckPrinterSettings();
    this.FormatGrid();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formAccountingPrinters));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
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
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.Label1 = new Label();
    this.Label6 = new Label();
    this.lblCheckPrinter = new Label();
    this.Label4 = new Label();
    this.lblCheckPrinterTray = new Label();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.Label3 = new Label();
    this.Label9 = new Label();
    this.Label2 = new Label();
    this.lblCheckDetailPrinterTray = new Label();
    this.lblDetailsPrinter = new Label();
    this.btnChangeCheckPrinter = new UltraButton();
    this.btnChangeDetailPrinter = new UltraButton();
    this.PrintDialog1 = new PrintDialog();
    this.PrintDocument1 = new PrintDocument();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.gridPrinterSettings = new UltraGrid();
    this.ultraLabel1 = new UltraLabel();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.buttonDelete = new UltraButton();
    this.buttonSave = new UltraButton();
    this.buttonCancel = new UltraButton();
    this.textCheckDetailSettings = new MGATextBox();
    this.ultraLabel5 = new UltraLabel();
    this.textCheckDetailName = new MGATextBox();
    this.ultraLabel4 = new UltraLabel();
    this.textCheckPrinterSettings = new MGATextBox();
    this.ultraLabel3 = new UltraLabel();
    this.textCheckPrinterName = new MGATextBox();
    this.ultraLabel2 = new UltraLabel();
    this.textPrinterFriendlyName = new MGATextBox();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    ((ISupportInitialize) this.gridPrinterSettings).BeginInit();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.textCheckDetailSettings).BeginInit();
    ((ISupportInitialize) this.textCheckDetailName).BeginInit();
    ((ISupportInitialize) this.textCheckPrinterSettings).BeginInit();
    ((ISupportInitialize) this.textCheckPrinterName).BeginInit();
    ((ISupportInitialize) this.textPrinterFriendlyName).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblCheckPrinter);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblCheckPrinterTray);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(22, 41);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(395, 171);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(384, 48 /*0x30*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please specify the printer that will be used to print checks. If you are not sure of which printer to use, please contact your system administrator.";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(8, 96 /*0x60*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(143, 14);
    this.Label6.TabIndex = 8;
    this.Label6.Text = "Printer Tray Selection:";
    this.lblCheckPrinter.BackColor = Color.Transparent;
    this.lblCheckPrinter.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheckPrinter.Location = new Point(8, 64 /*0x40*/);
    this.lblCheckPrinter.Name = "lblCheckPrinter";
    this.lblCheckPrinter.Size = new Size(384, 23);
    this.lblCheckPrinter.TabIndex = 5;
    this.lblCheckPrinter.Text = "None Selected";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(8, 48 /*0x30*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(164, 14);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "Current Printer Selection:";
    this.lblCheckPrinterTray.BackColor = Color.Transparent;
    this.lblCheckPrinterTray.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheckPrinterTray.Location = new Point(8, 112 /*0x70*/);
    this.lblCheckPrinterTray.Name = "lblCheckPrinterTray";
    this.lblCheckPrinterTray.Size = new Size(384, 23);
    this.lblCheckPrinterTray.TabIndex = 9;
    this.lblCheckPrinterTray.Text = "None Selected";
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label3);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label2);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.lblCheckDetailPrinterTray);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.lblDetailsPrinter);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(22, 266);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(395, 200);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(8, 8);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(384, 64 /*0x40*/);
    this.Label3.TabIndex = 1;
    this.Label3.Text = componentResourceManager.GetString("Label3.Text");
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(8, 128 /*0x80*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(143, 14);
    this.Label9.TabIndex = 10;
    this.Label9.Text = "Printer Tray Selection:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 80 /*0x50*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(164, 14);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Current Printer Selection:";
    this.lblCheckDetailPrinterTray.BackColor = Color.Transparent;
    this.lblCheckDetailPrinterTray.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheckDetailPrinterTray.Location = new Point(8, 144 /*0x90*/);
    this.lblCheckDetailPrinterTray.Name = "lblCheckDetailPrinterTray";
    this.lblCheckDetailPrinterTray.Size = new Size(384, 23);
    this.lblCheckDetailPrinterTray.TabIndex = 11;
    this.lblCheckDetailPrinterTray.Text = "None Selected";
    this.lblDetailsPrinter.BackColor = Color.Transparent;
    this.lblDetailsPrinter.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDetailsPrinter.Location = new Point(8, 96 /*0x60*/);
    this.lblDetailsPrinter.Name = "lblDetailsPrinter";
    this.lblDetailsPrinter.Size = new Size(384, 23);
    this.lblDetailsPrinter.TabIndex = 4;
    this.lblDetailsPrinter.Text = "None Selected";
    ((AppearanceBase) appearance1).Image = (object) Resources.AccountingPrinters;
    ((ControlBase) this.btnChangeCheckPrinter).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnChangeCheckPrinter).Location = new Point(301, 133);
    ((Control) this.btnChangeCheckPrinter).Name = "btnChangeCheckPrinter";
    ((Control) this.btnChangeCheckPrinter).Size = new Size(120, 26);
    ((Control) this.btnChangeCheckPrinter).TabIndex = 7;
    ((Control) this.btnChangeCheckPrinter).Text = "Select Printer..";
    ((Control) this.btnChangeCheckPrinter).Click += new EventHandler(this.LoadPrinterSelection);
    ((AppearanceBase) appearance2).Image = (object) Resources.AccountingPrinters;
    ((ControlBase) this.btnChangeDetailPrinter).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnChangeDetailPrinter).Location = new Point(301, 218);
    ((Control) this.btnChangeDetailPrinter).Name = "btnChangeDetailPrinter";
    ((Control) this.btnChangeDetailPrinter).Size = new Size(120, 26);
    ((Control) this.btnChangeDetailPrinter).TabIndex = 12;
    ((Control) this.btnChangeDetailPrinter).Text = "Select Printer..";
    ((Control) this.btnChangeDetailPrinter).Click += new EventHandler(this.LoadPrinterSelection);
    this.PrintDialog1.Document = this.PrintDocument1;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BackColor2 = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance3;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 173;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Check Printer Settings";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 202;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Check Detail Printer Settings";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
    });
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance5).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.White;
    ((AppearanceBase) appearance5).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance5).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance5).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance5).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).ImageBackground = (Image) componentResourceManager.GetObject("appearance32.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance6;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSpacing = 10;
    ((Control) this.UltraExplorerBar1).Location = new Point(271, 333);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(432, 486);
    ((Control) this.UltraExplorerBar1).TabIndex = 4;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    ((SpecialBoxBase) ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.AddNewBox).Prompt = " ";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance8).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((Control) this.gridPrinterSettings).Location = new Point(1, 1);
    ((Control) this.gridPrinterSettings).Name = "gridPrinterSettings";
    ((Control) this.gridPrinterSettings).Size = new Size(550, 295);
    ((Control) this.gridPrinterSettings).TabIndex = 5;
    ((UltraControlBase) this.gridPrinterSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPrinterSettings).UseOsThemes = (DefaultableBoolean) 2;
    this.gridPrinterSettings.DoubleClickRow += new DoubleClickRowEventHandler(this.gridPrinterSettings_DoubleClickRow);
    ((AppearanceBase) appearance15).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance15;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(6, 36);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(113, 15);
    ((Control) this.ultraLabel1).TabIndex = 13;
    ((Control) this.ultraLabel1).Text = "Printer Friendly Name:";
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.buttonDelete);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textCheckDetailSettings);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel5);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textCheckDetailName);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel4);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textCheckPrinterSettings);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel3);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textCheckPrinterName);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel2);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.textPrinterFriendlyName);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.ultraLabel1);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.btnChangeDetailPrinter);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.btnChangeCheckPrinter);
    ((Control) this.ultraGroupBox1).Location = new Point(557, 1);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(432, 296);
    ((Control) this.ultraGroupBox1).TabIndex = 14;
    ((Control) this.ultraGroupBox1).Text = "Printer Setting Options";
    this.ultraGroupBox1.ViewStyle = (GroupBoxViewStyle) 3;
    ((AppearanceBase) appearance16).Image = (object) Resources.delete;
    ((ControlBase) this.buttonDelete).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonDelete).Location = new Point(11, 262);
    ((Control) this.buttonDelete).Name = "buttonDelete";
    ((Control) this.buttonDelete).Size = new Size(120, 24);
    ((Control) this.buttonDelete).TabIndex = 25;
    ((Control) this.buttonDelete).Text = "Delete Settings";
    ((Control) this.buttonDelete).Click += new EventHandler(this.buttonDelete_Click);
    ((AppearanceBase) appearance17).Image = componentResourceManager.GetObject("appearance44.Image");
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance17;
    ((Control) this.buttonSave).Location = new Point(175, 264);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(120, 24);
    ((Control) this.buttonSave).TabIndex = 24;
    ((Control) this.buttonSave).Text = "Save Settings";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance18).Image = (object) Resources.action_refresh_blue;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance18;
    ((Control) this.buttonCancel).Location = new Point(301, 264);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(120, 24);
    ((Control) this.buttonCancel).TabIndex = 23;
    ((Control) this.buttonCancel).Text = "Cancel/Clear";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckDetailSettings).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textCheckDetailSettings).BackColor = Color.White;
    ((Control) this.textCheckDetailSettings).Location = new Point(122, 192 /*0xC0*/);
    this.textCheckDetailSettings.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckDetailSettings).Name = "textCheckDetailSettings";
    ((EditorButtonControlBase) this.textCheckDetailSettings).ReadOnly = true;
    ((Control) this.textCheckDetailSettings).Size = new Size(299, 20);
    ((Control) this.textCheckDetailSettings).TabIndex = 22;
    ((UltraControlBase) this.textCheckDetailSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckDetailSettings).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance20;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(6, 192 /*0xC0*/);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(110, 15);
    ((Control) this.ultraLabel5).TabIndex = 21;
    ((Control) this.ultraLabel5).Text = "Check Detail Settings:";
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckDetailName).Appearance = (AppearanceBase) appearance21;
    ((Control) this.textCheckDetailName).BackColor = Color.White;
    ((Control) this.textCheckDetailName).Location = new Point(122, 166);
    this.textCheckDetailName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckDetailName).Name = "textCheckDetailName";
    ((EditorButtonControlBase) this.textCheckDetailName).ReadOnly = true;
    ((Control) this.textCheckDetailName).Size = new Size(299, 20);
    ((Control) this.textCheckDetailName).TabIndex = 20;
    ((UltraControlBase) this.textCheckDetailName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckDetailName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance22;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(6, 166);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(100, 15);
    ((Control) this.ultraLabel4).TabIndex = 19;
    ((Control) this.ultraLabel4).Text = "Check Detail Name:";
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckPrinterSettings).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textCheckPrinterSettings).BackColor = Color.White;
    ((Control) this.textCheckPrinterSettings).Location = new Point(122, 107);
    this.textCheckPrinterSettings.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckPrinterSettings).Name = "textCheckPrinterSettings";
    ((EditorButtonControlBase) this.textCheckPrinterSettings).ReadOnly = true;
    ((Control) this.textCheckPrinterSettings).Size = new Size(299, 20);
    ((Control) this.textCheckPrinterSettings).TabIndex = 18;
    ((UltraControlBase) this.textCheckPrinterSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckPrinterSettings).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance24).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance24;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(6, 102);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(115, 15);
    ((Control) this.ultraLabel3).TabIndex = 17;
    ((Control) this.ultraLabel3).Text = "Check Printer Settings:";
    ((AppearanceBase) appearance25).BackColor = Color.White;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckPrinterName).Appearance = (AppearanceBase) appearance25;
    ((Control) this.textCheckPrinterName).BackColor = Color.White;
    ((Control) this.textCheckPrinterName).Location = new Point(122, 81);
    this.textCheckPrinterName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckPrinterName).Name = "textCheckPrinterName";
    ((EditorButtonControlBase) this.textCheckPrinterName).ReadOnly = true;
    ((Control) this.textCheckPrinterName).Size = new Size(299, 20);
    ((Control) this.textCheckPrinterName).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textCheckPrinterName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckPrinterName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance26;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(6, 81);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(104, 15);
    ((Control) this.ultraLabel2).TabIndex = 15;
    ((Control) this.ultraLabel2).Text = "Check Printer Name:";
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrinterFriendlyName).Appearance = (AppearanceBase) appearance27;
    ((Control) this.textPrinterFriendlyName).BackColor = Color.White;
    ((Control) this.textPrinterFriendlyName).Location = new Point(122, 36);
    this.textPrinterFriendlyName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrinterFriendlyName).Name = "textPrinterFriendlyName";
    ((Control) this.textPrinterFriendlyName).Size = new Size(299, 20);
    ((Control) this.textPrinterFriendlyName).TabIndex = 14;
    ((UltraControlBase) this.textPrinterFriendlyName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPrinterFriendlyName).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(993, 299);
    this.Controls.Add((Control) this.ultraGroupBox1);
    this.Controls.Add((Control) this.gridPrinterSettings);
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formAccountingPrinters);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Accounting Printers";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).PerformLayout();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl2).PerformLayout();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    ((ISupportInitialize) this.gridPrinterSettings).EndInit();
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.textCheckDetailSettings).EndInit();
    ((ISupportInitialize) this.textCheckDetailName).EndInit();
    ((ISupportInitialize) this.textCheckPrinterSettings).EndInit();
    ((ISupportInitialize) this.textCheckPrinterName).EndInit();
    ((ISupportInitialize) this.textPrinterFriendlyName).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadPrinterSelection(object sender, EventArgs e)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    if (this.PrintDialog1.ShowDialog() != DialogResult.OK)
      return;
    string printerName = this.PrintDialog1.Document.PrinterSettings.PrinterName;
    string sourceName = this.PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSource.SourceName;
    if (sender == this.btnChangeCheckPrinter)
    {
      ((Control) this.textCheckPrinterName).Text = printerName;
      ((Control) this.textCheckPrinterSettings).Text = sourceName;
    }
    else
    {
      ((Control) this.textCheckDetailName).Text = printerName;
      ((Control) this.textCheckDetailSettings).Text = sourceName;
    }
  }

  private void SavePrinterSettings(
    formAccountingPrinters.CheckPrinterType ct,
    string PrinterName,
    string PaperSource)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_SavePrinterSettings", new object[6]
    {
      (object) "@printerType",
      (object) ct,
      (object) "@printerName",
      (object) PrinterName,
      (object) "@paperSource",
      (object) PaperSource
    });
  }

  private void LoadCurrentPrinterSettings()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("Select * from tblfin_accountingprintersettings", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
          switch (sqlDataReader["settingKey"].ToString())
          {
            case "CPN":
              this.lblCheckPrinter.Text = sqlDataReader["SettingValue"].ToString();
              continue;
            case "CPS":
              this.lblCheckPrinterTray.Text = sqlDataReader["SettingValue"].ToString();
              continue;
            case "CDPN":
              this.lblDetailsPrinter.Text = sqlDataReader["SettingValue"].ToString();
              continue;
            case "CDPS":
              this.lblCheckDetailPrinterTray.Text = sqlDataReader["SettingValue"].ToString();
              continue;
            default:
              continue;
          }
        }
      }
    }
  }

  private void LoadCheckPrinterSettings()
  {
    this.Cursor = MgaCursors.WaitCursor;
    dsCheckPrinterSettings checkPrinterSettings = new dsCheckPrinterSettings();
    DefaultDatabase.LoadDataSet((DataSet) checkPrinterSettings, new string[1]
    {
      "PrinterSettings"
    }, "spFin_GetCheckPrinterSettings");
    ((UltraGridBase) this.gridPrinterSettings).DataSource = (object) checkPrinterSettings.PrinterSettings;
    this.Cursor = MgaCursors.Default;
  }

  private void FormatGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridPrinterSettings).DisplayLayout.Bands[0];
    band.Columns[0].Hidden = true;
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) band.Columns[1].Header).Caption = "Printer";
    ((HeaderBase) band.Columns[2].Header).Caption = "Check Printer";
    ((HeaderBase) band.Columns[3].Header).Caption = "Check Settings";
    ((HeaderBase) band.Columns[4].Header).Caption = "Detail Printer";
    ((HeaderBase) band.Columns[5].Header).Caption = "Detail Settings";
  }

  private void gridPrinterSettings_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (((SparseCollectionBase) this.gridPrinterSettings.Selected.Rows).Count == 0)
      return;
    UltraGridRow row = this.gridPrinterSettings.Selected.Rows[0];
    this._currentPrinterId = new int?((int) row.Cells["PrinterId"].Value);
    ((Control) this.textPrinterFriendlyName).Text = row.Cells["PrinterFriendlyName"].Value.ToString();
    ((Control) this.textCheckPrinterName).Text = row.Cells["CheckPrinterName"].Value.ToString();
    ((Control) this.textCheckPrinterSettings).Text = row.Cells["CheckPrinterSettings"].Value.ToString();
    ((Control) this.textCheckDetailName).Text = row.Cells["CheckDetailName"].Value.ToString();
    ((Control) this.textCheckDetailSettings).Text = row.Cells["CheckDetailSettings"].Value.ToString();
  }

  private void ClearScreen()
  {
    this._currentPrinterId = new int?();
    ((Control) this.textPrinterFriendlyName).Text = string.Empty;
    ((Control) this.textCheckPrinterName).Text = string.Empty;
    ((Control) this.textCheckPrinterSettings).Text = string.Empty;
    ((Control) this.textCheckDetailName).Text = string.Empty;
    ((Control) this.textCheckDetailSettings).Text = string.Empty;
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.ClearScreen();

  private void buttonSave_Click(object sender, EventArgs e)
  {
    this.Save();
    this.ClearScreen();
    this.LoadCheckPrinterSettings();
  }

  private void Save()
  {
    if (!this._currentPrinterId.HasValue)
    {
      DefaultDatabase.ExecuteNonQuery("spFin_AddCheckPrinterSetting", new object[10]
      {
        (object) "@PrinterFriendlyName",
        (object) ((Control) this.textPrinterFriendlyName).Text,
        (object) "@CPN",
        (object) ((Control) this.textCheckPrinterName).Text,
        (object) "@CPS",
        (object) ((Control) this.textCheckPrinterSettings).Text,
        (object) "@CDPN",
        (object) ((Control) this.textCheckDetailName).Text,
        (object) "@CDPS",
        (object) ((Control) this.textCheckDetailSettings).Text
      });
      CurrentUser.Instance.LogAction($"Added accounting printer {((Control) this.textCheckPrinterName).Text}", "Accounting Logs");
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery("spFin_EditCheckPrinterSetting", new object[12]
      {
        (object) "@PrinterId",
        (object) this._currentPrinterId.Value,
        (object) "@PrinterFriendlyName",
        (object) ((Control) this.textPrinterFriendlyName).Text,
        (object) "@CPN",
        (object) ((Control) this.textCheckPrinterName).Text,
        (object) "@CPS",
        (object) ((Control) this.textCheckPrinterSettings).Text,
        (object) "@CDPN",
        (object) ((Control) this.textCheckDetailName).Text,
        (object) "@CDPS",
        (object) ((Control) this.textCheckDetailSettings).Text
      });
      CurrentUser.Instance.LogAction($"Edited accounting printer {((Control) this.textCheckPrinterName).Text}", "Accounting Logs");
    }
  }

  private void buttonDelete_Click(object sender, EventArgs e)
  {
    if (!this._currentPrinterId.HasValue)
      return;
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteCheckPrinterSetting", new object[2]
    {
      (object) "@PrinterId",
      (object) this._currentPrinterId.Value
    });
    CurrentUser.Instance.LogAction($"Deleted accounting printer {((Control) this.textCheckPrinterName).Text}", "Accounting Logs");
    this.LoadCheckPrinterSettings();
  }

  private enum CheckPrinterType
  {
    Check,
    CheckDetail,
  }
}
