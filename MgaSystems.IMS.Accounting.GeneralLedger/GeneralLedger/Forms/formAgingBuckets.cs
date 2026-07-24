// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formAgingBuckets
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{30C38296-8098-4a12-9768-5AD6C183CD87}", "Aging Configuration Rights", "Determines whether or not a user is allowed to change the aging bucket configuration.", "Accounting")]
public class formAgingBuckets : Form
{
  internal UltraExplorerBar UltraExplorerBar1;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl1;
  internal MGATextBox txtARPeriod1To;
  internal MGATextBox txtARPeriod3To;
  internal MGATextBox txtARPeriod3From;
  internal MGATextBox txtARPeriod4From;
  internal Label Label3;
  internal Label Label9;
  internal Label Label4;
  internal Label Label10;
  internal Label Label6;
  internal MGATextBox txtARPeriod4To;
  internal MGATextBox txtARPeriod2To;
  internal Label Label5;
  internal MGATextBox txtARPeriod2From;
  internal Label Label7;
  internal Label Label8;
  internal MGATextBox txtARPeriod1From;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl2;
  internal Label Label12;
  internal Label Label17;
  internal Label Label18;
  internal MGATextBox txtAPPeriod1From;
  internal MGATextBox txtAPPeriod4To;
  internal Label Label14;
  internal MGATextBox txtAPPeriod2To;
  internal MGATextBox txtAPPeriod2From;
  internal MGATextBox txtAPPeriod4From;
  internal Label Label15;
  internal Label Label16;
  internal MGATextBox txtAPPeriod3To;
  internal Label Label11;
  internal Label Label13;
  internal MGATextBox txtAPPeriod1To;
  internal MGATextBox txtAPPeriod3From;
  internal UltraExplorerBarContainerControl UltraExplorerBarContainerControl3;
  internal MGAButton btnSave;
  internal MGAButton btnCancel;
  private System.ComponentModel.Container components;

  public formAgingBuckets()
  {
    this.InitializeComponent();
    this.DisplayAgingPeriods();
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
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formAgingBuckets));
    Appearance appearance21 = new Appearance();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.txtARPeriod1From = new MGATextBox();
    this.txtARPeriod1To = new MGATextBox();
    this.txtARPeriod3To = new MGATextBox();
    this.txtARPeriod3From = new MGATextBox();
    this.txtARPeriod4From = new MGATextBox();
    this.Label3 = new Label();
    this.Label9 = new Label();
    this.Label4 = new Label();
    this.Label10 = new Label();
    this.Label6 = new Label();
    this.txtARPeriod4To = new MGATextBox();
    this.txtARPeriod2To = new MGATextBox();
    this.Label5 = new Label();
    this.txtARPeriod2From = new MGATextBox();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.Label12 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.txtAPPeriod1From = new MGATextBox();
    this.txtAPPeriod4To = new MGATextBox();
    this.Label14 = new Label();
    this.txtAPPeriod2To = new MGATextBox();
    this.txtAPPeriod2From = new MGATextBox();
    this.txtAPPeriod4From = new MGATextBox();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.txtAPPeriod3To = new MGATextBox();
    this.Label11 = new Label();
    this.Label13 = new Label();
    this.txtAPPeriod1To = new MGATextBox();
    this.txtAPPeriod3From = new MGATextBox();
    this.UltraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.txtARPeriod1From).BeginInit();
    ((ISupportInitialize) this.txtARPeriod1To).BeginInit();
    ((ISupportInitialize) this.txtARPeriod3To).BeginInit();
    ((ISupportInitialize) this.txtARPeriod3From).BeginInit();
    ((ISupportInitialize) this.txtARPeriod4From).BeginInit();
    ((ISupportInitialize) this.txtARPeriod4To).BeginInit();
    ((ISupportInitialize) this.txtARPeriod2To).BeginInit();
    ((ISupportInitialize) this.txtARPeriod2From).BeginInit();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.txtAPPeriod1From).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod4To).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod2To).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod2From).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod4From).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod3To).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod1To).BeginInit();
    ((ISupportInitialize) this.txtAPPeriod3From).BeginInit();
    ((Control) this.UltraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod1From);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod1To);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod3To);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod3From);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod4From);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod4To);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod2To);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtARPeriod2From);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(14, 38);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(204, 99);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod1From).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtARPeriod1From).BackColor = Color.Yellow;
    ((Control) this.txtARPeriod1From).Location = new Point(72, 5);
    this.txtARPeriod1From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod1From).Name = "txtARPeriod1From";
    ((EditorButtonControlBase) this.txtARPeriod1From).ReadOnly = true;
    ((Control) this.txtARPeriod1From).Size = new Size(56, 20);
    ((Control) this.txtARPeriod1From).TabIndex = 2;
    ((Control) this.txtARPeriod1From).TabStop = false;
    ((Control) this.txtARPeriod1From).Text = "0";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod1To).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtARPeriod1To).Location = new Point(136, 5);
    this.txtARPeriod1To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod1To).Name = "txtARPeriod1To";
    ((Control) this.txtARPeriod1To).Size = new Size(56, 20);
    ((Control) this.txtARPeriod1To).TabIndex = 3;
    ((Control) this.txtARPeriod1To).Text = "30";
    ((Control) this.txtARPeriod1To).Leave += new EventHandler(this.ToFieldsLeave);
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod3To).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtARPeriod3To).Location = new Point(136, 53);
    this.txtARPeriod3To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod3To).Name = "txtARPeriod3To";
    ((Control) this.txtARPeriod3To).Size = new Size(56, 20);
    ((Control) this.txtARPeriod3To).TabIndex = 9;
    ((Control) this.txtARPeriod3To).Text = "91";
    ((Control) this.txtARPeriod3To).Leave += new EventHandler(this.ToFieldsLeave);
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod3From).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtARPeriod3From).Location = new Point(72, 53);
    this.txtARPeriod3From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod3From).Name = "txtARPeriod3From";
    ((Control) this.txtARPeriod3From).Size = new Size(56, 20);
    ((Control) this.txtARPeriod3From).TabIndex = 8;
    ((Control) this.txtARPeriod3From).TabStop = false;
    ((Control) this.txtARPeriod3From).Text = "61";
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod4From).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtARPeriod4From).Location = new Point(72, 77);
    this.txtARPeriod4From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod4From).Name = "txtARPeriod4From";
    ((Control) this.txtARPeriod4From).Size = new Size(56, 20);
    ((Control) this.txtARPeriod4From).TabIndex = 11;
    ((Control) this.txtARPeriod4From).TabStop = false;
    ((Control) this.txtARPeriod4From).Text = "91";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(8, 8);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Period 1:";
    this.Label9.BackColor = Color.Black;
    this.Label9.Location = new Point(0, 96 /*0x60*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(136, 1);
    this.Label9.TabIndex = 30;
    this.Label9.Text = "Label9";
    this.Label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label4.Location = new Point(0, 24);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(136, 1);
    this.Label4.TabIndex = 27;
    this.Label4.Text = "Label4";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(8, 80 /*0x50*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label10.TabIndex = 10;
    this.Label10.Text = "Period 4:";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(8, 32 /*0x20*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label6.TabIndex = 4;
    this.Label6.Text = "Period 2:";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod4To).Appearance = (AppearanceBase) appearance6;
    ((Control) this.txtARPeriod4To).BackColor = Color.DarkSeaGreen;
    ((Control) this.txtARPeriod4To).Location = new Point(136, 77);
    this.txtARPeriod4To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod4To).Name = "txtARPeriod4To";
    ((EditorButtonControlBase) this.txtARPeriod4To).ReadOnly = true;
    ((Control) this.txtARPeriod4To).Size = new Size(56, 20);
    ((Control) this.txtARPeriod4To).TabIndex = 12;
    ((Control) this.txtARPeriod4To).TabStop = false;
    ((Control) this.txtARPeriod4To).Text = "OVER";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod2To).Appearance = (AppearanceBase) appearance7;
    ((Control) this.txtARPeriod2To).Location = new Point(136, 29);
    this.txtARPeriod2To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod2To).Name = "txtARPeriod2To";
    ((Control) this.txtARPeriod2To).Size = new Size(56, 20);
    ((Control) this.txtARPeriod2To).TabIndex = 6;
    ((Control) this.txtARPeriod2To).Text = "60";
    ((Control) this.txtARPeriod2To).Leave += new EventHandler(this.ToFieldsLeave);
    this.Label5.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label5.Location = new Point(0, 48 /*0x30*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(136, 1);
    this.Label5.TabIndex = 28;
    this.Label5.Text = "Label5";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtARPeriod2From).Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtARPeriod2From).Location = new Point(72, 29);
    this.txtARPeriod2From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtARPeriod2From).Name = "txtARPeriod2From";
    ((Control) this.txtARPeriod2From).Size = new Size(56, 20);
    ((Control) this.txtARPeriod2From).TabIndex = 5;
    ((Control) this.txtARPeriod2From).TabStop = false;
    ((Control) this.txtARPeriod2From).Text = "31";
    this.Label7.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label7.Location = new Point(0, 72);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(136, 1);
    this.Label7.TabIndex = 29;
    this.Label7.Text = "Label7";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(8, 56);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label8.TabIndex = 7;
    this.Label8.Text = "Period 3:";
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label12);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label17);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label18);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod1From);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod4To);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label14);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod2To);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod2From);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod4From);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label15);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label16);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod3To);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label11);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label13);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod1To);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.txtAPPeriod3From);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(14, 183);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(204, 104);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(8, 8);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(44, 16 /*0x10*/);
    this.Label12.TabIndex = 14;
    this.Label12.Text = "Period 1";
    this.Label17.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label17.Location = new Point(0, 96 /*0x60*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(136, 1);
    this.Label17.TabIndex = 34;
    this.Label17.Text = "Label17";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(8, 80 /*0x50*/);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label18.TabIndex = 23;
    this.Label18.Text = "Period 4:";
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod1From).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtAPPeriod1From).BackColor = Color.Yellow;
    ((Control) this.txtAPPeriod1From).Location = new Point(72, 5);
    this.txtAPPeriod1From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod1From).Name = "txtAPPeriod1From";
    ((EditorButtonControlBase) this.txtAPPeriod1From).ReadOnly = true;
    ((Control) this.txtAPPeriod1From).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod1From).TabIndex = 15;
    ((Control) this.txtAPPeriod1From).TabStop = false;
    ((Control) this.txtAPPeriod1From).Text = "0";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod4To).Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtAPPeriod4To).BackColor = Color.DarkSeaGreen;
    ((Control) this.txtAPPeriod4To).Location = new Point(136, 77);
    this.txtAPPeriod4To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod4To).Name = "txtAPPeriod4To";
    ((EditorButtonControlBase) this.txtAPPeriod4To).ReadOnly = true;
    ((Control) this.txtAPPeriod4To).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod4To).TabIndex = 25;
    ((Control) this.txtAPPeriod4To).TabStop = false;
    ((Control) this.txtAPPeriod4To).Text = "OVER";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(8, 32 /*0x20*/);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label14.TabIndex = 17;
    this.Label14.Text = "Period 2:";
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod2To).Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtAPPeriod2To).Location = new Point(136, 29);
    this.txtAPPeriod2To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod2To).Name = "txtAPPeriod2To";
    ((Control) this.txtAPPeriod2To).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod2To).TabIndex = 19;
    ((Control) this.txtAPPeriod2To).Text = "60";
    ((Control) this.txtAPPeriod2To).Leave += new EventHandler(this.ToFieldsLeave);
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod2From).Appearance = (AppearanceBase) appearance12;
    ((Control) this.txtAPPeriod2From).Location = new Point(72, 29);
    this.txtAPPeriod2From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod2From).Name = "txtAPPeriod2From";
    ((Control) this.txtAPPeriod2From).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod2From).TabIndex = 18;
    ((Control) this.txtAPPeriod2From).TabStop = false;
    ((Control) this.txtAPPeriod2From).Text = "31";
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod4From).Appearance = (AppearanceBase) appearance13;
    ((Control) this.txtAPPeriod4From).Location = new Point(72, 77);
    this.txtAPPeriod4From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod4From).Name = "txtAPPeriod4From";
    ((Control) this.txtAPPeriod4From).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod4From).TabIndex = 24;
    ((Control) this.txtAPPeriod4From).TabStop = false;
    ((Control) this.txtAPPeriod4From).Text = "91";
    this.Label15.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label15.Location = new Point(0, 72);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(136, 1);
    this.Label15.TabIndex = 33;
    this.Label15.Text = "Label15";
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(8, 56);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label16.TabIndex = 20;
    this.Label16.Text = "Period 3:";
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod3To).Appearance = (AppearanceBase) appearance14;
    ((Control) this.txtAPPeriod3To).Location = new Point(136, 53);
    this.txtAPPeriod3To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod3To).Name = "txtAPPeriod3To";
    ((Control) this.txtAPPeriod3To).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod3To).TabIndex = 22;
    ((Control) this.txtAPPeriod3To).Text = "91";
    ((Control) this.txtAPPeriod3To).Leave += new EventHandler(this.ToFieldsLeave);
    this.Label11.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label11.Location = new Point(0, 24);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(136, 1);
    this.Label11.TabIndex = 31 /*0x1F*/;
    this.Label11.Text = "Label11";
    this.Label13.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label13.Location = new Point(0, 48 /*0x30*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(136, 1);
    this.Label13.TabIndex = 32 /*0x20*/;
    this.Label13.Text = "Label13";
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod1To).Appearance = (AppearanceBase) appearance15;
    ((Control) this.txtAPPeriod1To).Location = new Point(136, 5);
    this.txtAPPeriod1To.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod1To).Name = "txtAPPeriod1To";
    ((Control) this.txtAPPeriod1To).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod1To).TabIndex = 16 /*0x10*/;
    ((Control) this.txtAPPeriod1To).Text = "30";
    ((Control) this.txtAPPeriod1To).Leave += new EventHandler(this.ToFieldsLeave);
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAPPeriod3From).Appearance = (AppearanceBase) appearance16;
    ((Control) this.txtAPPeriod3From).Location = new Point(72, 53);
    this.txtAPPeriod3From.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAPPeriod3From).Name = "txtAPPeriod3From";
    ((Control) this.txtAPPeriod3From).Size = new Size(56, 20);
    ((Control) this.txtAPPeriod3From).TabIndex = 21;
    ((Control) this.txtAPPeriod3From).TabStop = false;
    ((Control) this.txtAPPeriod3From).Text = "61";
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.btnCancel);
    ((Control) this.UltraExplorerBarContainerControl3).Location = new Point(14, 308);
    ((Control) this.UltraExplorerBarContainerControl3).Name = "UltraExplorerBarContainerControl3";
    ((Control) this.UltraExplorerBarContainerControl3).Size = new Size(204, 37);
    ((Control) this.UltraExplorerBarContainerControl3).TabIndex = 2;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance17).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance17).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance17;
    ((Control) this.btnSave).Location = new Point(8, 8);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(88, 24);
    ((Control) this.btnSave).TabIndex = 26;
    ((Control) this.btnSave).Text = "Save";
    ((Control) this.btnSave).Click += new EventHandler(this.btnSave_Click);
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance18).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance18).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance18;
    ((Control) this.btnCancel).Location = new Point(112 /*0x70*/, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 35;
    ((Control) this.btnCancel).Text = "Cancel";
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl3);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 101;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Accounts Receivable";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 106;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Accounts Payable";
    explorerBarGroup3.Container = this.UltraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 39;
    explorerBarGroup3.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Save";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance20).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance20).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance20).BorderColor = Color.White;
    ((AppearanceBase) appearance20).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance20).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance20).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance20).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance20).ImageBackground = (Image) resourceManager.GetObject("appearance20.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance21;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.UltraExplorerBar1.GroupSpacing = 10;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(232, 358);
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraExplorerBar1).TabIndex = 37;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(232, 358);
    this.ControlBox = false;
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formAgingBuckets);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Aging Buckets";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.txtARPeriod1From).EndInit();
    ((ISupportInitialize) this.txtARPeriod1To).EndInit();
    ((ISupportInitialize) this.txtARPeriod3To).EndInit();
    ((ISupportInitialize) this.txtARPeriod3From).EndInit();
    ((ISupportInitialize) this.txtARPeriod4From).EndInit();
    ((ISupportInitialize) this.txtARPeriod4To).EndInit();
    ((ISupportInitialize) this.txtARPeriod2To).EndInit();
    ((ISupportInitialize) this.txtARPeriod2From).EndInit();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.txtAPPeriod1From).EndInit();
    ((ISupportInitialize) this.txtAPPeriod4To).EndInit();
    ((ISupportInitialize) this.txtAPPeriod2To).EndInit();
    ((ISupportInitialize) this.txtAPPeriod2From).EndInit();
    ((ISupportInitialize) this.txtAPPeriod4From).EndInit();
    ((ISupportInitialize) this.txtAPPeriod3To).EndInit();
    ((ISupportInitialize) this.txtAPPeriod1To).EndInit();
    ((ISupportInitialize) this.txtAPPeriod3From).EndInit();
    ((Control) this.UltraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void ToFieldsLeave(object sender, EventArgs e)
  {
    if (this.ActiveControl == this.btnCancel || !(sender is MGATextBox))
      return;
    if (!Methods.IsNumericValue((object) ((Control) (sender as MGATextBox)).Text))
    {
      int num = (int) MessageBox.Show("Aging buckets must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ((TextEditorControlBase) (sender as MGATextBox)).Focus();
      SendKeys.Send("{HOME} + {END}");
    }
    else if (int.Parse(((Control) (sender as MGATextBox)).Text) < 0)
    {
      int num = (int) MessageBox.Show("Aging buckets must be greater than zero!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ((TextEditorControlBase) (sender as MGATextBox)).Focus();
      SendKeys.Send("{HOME} + {END}");
    }
    else
    {
      int num1 = int.Parse(((Control) (sender as MGATextBox)).Text);
      switch (((Control) (sender as MGATextBox)).Name)
      {
        case "txtAPPeriod1To":
          ((Control) this.txtAPPeriod2From).Text = (int.Parse(((Control) (sender as MGATextBox)).Text) + 1).ToString();
          break;
        case "txtAPPeriod2To":
          if (num1 < int.Parse(((Control) this.txtAPPeriod2From).Text))
          {
            int num2 = (int) MessageBox.Show("The 'To' period can not be less than the 'From' period!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ((TextEditorControlBase) (sender as MGATextBox)).Focus();
            SendKeys.Send("{Home} + {End}");
            break;
          }
          ((Control) this.txtAPPeriod3From).Text = (int.Parse(((Control) (sender as MGATextBox)).Text) + 1).ToString();
          break;
        case "txtAPPeriod3To":
          if (num1 < int.Parse(((Control) this.txtAPPeriod3From).Text))
          {
            int num3 = (int) MessageBox.Show("The 'To' period can not be less than the 'From' period!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ((TextEditorControlBase) (sender as MGATextBox)).Focus();
            SendKeys.Send("{Home} + {End}");
            break;
          }
          ((Control) this.txtAPPeriod4From).Text = (int.Parse(((Control) (sender as MGATextBox)).Text) + 1).ToString();
          break;
        case "txtARPeriod1To":
          ((Control) this.txtARPeriod2From).Text = (int.Parse(((Control) (sender as MGATextBox)).Text) + 1).ToString();
          break;
        case "txtARPeriod2To":
          if (num1 < int.Parse(((Control) this.txtARPeriod2From).Text))
          {
            int num4 = (int) MessageBox.Show("The 'To' period can not be less than the 'From' period!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ((TextEditorControlBase) (sender as MGATextBox)).Focus();
            SendKeys.Send("{Home} + {End}");
            break;
          }
          ((Control) this.txtARPeriod3From).Text = (int.Parse(((Control) (sender as MGATextBox)).Text) + 1).ToString();
          break;
        case "txtARPeriod3To":
          if (num1 < int.Parse(((Control) this.txtARPeriod3From).Text))
          {
            int num5 = (int) MessageBox.Show("The 'To' period can not be less than the 'From' period!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ((TextEditorControlBase) (sender as MGATextBox)).Focus();
            SendKeys.Send("{Home} + {End}");
            break;
          }
          ((Control) this.txtARPeriod4From).Text = (int.Parse(((Control) (sender as MGATextBox)).Text) + 1).ToString();
          break;
      }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void SaveAgingBuckets()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_InsertAgingBuckets", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@ar1from", (object) ((Control) this.txtARPeriod1From).Text);
        sqlCommand.Parameters.AddWithValue("@ar1to", (object) ((Control) this.txtARPeriod1To).Text);
        sqlCommand.Parameters.AddWithValue("@ar2from", (object) ((Control) this.txtARPeriod2From).Text);
        sqlCommand.Parameters.AddWithValue("@ar2to", (object) ((Control) this.txtARPeriod2To).Text);
        sqlCommand.Parameters.AddWithValue("@ar3from", (object) ((Control) this.txtARPeriod3From).Text);
        sqlCommand.Parameters.AddWithValue("@ar3to", (object) ((Control) this.txtARPeriod3To).Text);
        sqlCommand.Parameters.AddWithValue("@ar4from", (object) ((Control) this.txtARPeriod4From).Text);
        sqlCommand.Parameters.AddWithValue("@ar4to", (object) ((Control) this.txtARPeriod4To).Text);
        sqlCommand.Parameters.AddWithValue("@ap1from", (object) ((Control) this.txtAPPeriod1From).Text);
        sqlCommand.Parameters.AddWithValue("@ap1to", (object) ((Control) this.txtAPPeriod1To).Text);
        sqlCommand.Parameters.AddWithValue("@ap2from", (object) ((Control) this.txtAPPeriod2From).Text);
        sqlCommand.Parameters.AddWithValue("@ap2to", (object) ((Control) this.txtAPPeriod2To).Text);
        sqlCommand.Parameters.AddWithValue("@ap3from", (object) ((Control) this.txtAPPeriod3From).Text);
        sqlCommand.Parameters.AddWithValue("@ap3to", (object) ((Control) this.txtAPPeriod3To).Text);
        sqlCommand.Parameters.AddWithValue("@ap4from", (object) ((Control) this.txtAPPeriod4From).Text);
        sqlCommand.Parameters.AddWithValue("@ap4to", (object) ((Control) this.txtAPPeriod4To).Text);
        sqlCommand.Connection.Open();
        sqlCommand.ExecuteNonQuery();
        CurrentUser.Instance.LogAction("Edited and saved aging buckets", "Accounting Logs");
      }
    }
    this.Close();
  }

  private bool VerifyForm()
  {
    if (int.Parse(((Control) this.txtAPPeriod2From).Text) <= int.Parse(((Control) this.txtAPPeriod2To).Text) && int.Parse(((Control) this.txtAPPeriod3From).Text) <= int.Parse(((Control) this.txtAPPeriod3To).Text) && int.Parse(((Control) this.txtARPeriod2From).Text) <= int.Parse(((Control) this.txtARPeriod2To).Text) && int.Parse(((Control) this.txtARPeriod3From).Text) <= int.Parse(((Control) this.txtARPeriod3To).Text))
      return true;
    int num = (int) MessageBox.Show("The 'To' period can not be less than the 'From' period!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void DisplayAgingPeriods()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_GetAgingBuckets", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        if (!sqlDataReader.Read())
          return;
        ((Control) this.txtAPPeriod1To).Text = sqlDataReader["AP_Bucket1To"].ToString();
        ((Control) this.txtAPPeriod2From).Text = sqlDataReader["AP_Bucket2From"].ToString();
        ((Control) this.txtAPPeriod2To).Text = sqlDataReader["AP_Bucket2To"].ToString();
        ((Control) this.txtAPPeriod3From).Text = sqlDataReader["AP_Bucket3From"].ToString();
        ((Control) this.txtAPPeriod3To).Text = sqlDataReader["AP_Bucket3To"].ToString();
        ((Control) this.txtAPPeriod4From).Text = sqlDataReader["AP_Bucket4From"].ToString();
        ((Control) this.txtARPeriod1To).Text = sqlDataReader["AR_Bucket1To"].ToString();
        ((Control) this.txtARPeriod2From).Text = sqlDataReader["AR_Bucket2From"].ToString();
        ((Control) this.txtARPeriod2To).Text = sqlDataReader["AR_Bucket2To"].ToString();
        ((Control) this.txtARPeriod3From).Text = sqlDataReader["AR_Bucket3From"].ToString();
        ((Control) this.txtARPeriod3To).Text = sqlDataReader["AR_Bucket3To"].ToString();
        ((Control) this.txtARPeriod4From).Text = sqlDataReader["AR_Bucket4From"].ToString();
      }
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.SaveAgingBuckets();
  }
}
