// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmPrinterSettings
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmPrinterSettings : Form
{
  private IContainer components;

  public frmPrinterSettings()
  {
    this.Load += new EventHandler(this.frmPrinterSettings_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PrintDocument1")]
  internal virtual PrintDocument PrintDocument1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PrintDialog1")]
  internal virtual PrintDialog PrintDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheckPrinter")]
  internal virtual Label lblCheckPrinter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDetailsPrinter")]
  internal virtual Label lblDetailsPrinter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton btnChangeCheckPrinter
  {
    get => this._btnChangeCheckPrinter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LoadPrinterSelection);
      UltraButton changeCheckPrinter1 = this._btnChangeCheckPrinter;
      if (changeCheckPrinter1 != null)
        ((Control) changeCheckPrinter1).Click -= eventHandler;
      this._btnChangeCheckPrinter = value;
      UltraButton changeCheckPrinter2 = this._btnChangeCheckPrinter;
      if (changeCheckPrinter2 == null)
        return;
      ((Control) changeCheckPrinter2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton btnChangeDetailPrinter
  {
    get => this._btnChangeDetailPrinter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LoadPrinterSelection);
      UltraButton changeDetailPrinter1 = this._btnChangeDetailPrinter;
      if (changeDetailPrinter1 != null)
        ((Control) changeDetailPrinter1).Click -= eventHandler;
      this._btnChangeDetailPrinter = value;
      UltraButton changeDetailPrinter2 = this._btnChangeDetailPrinter;
      if (changeDetailPrinter2 == null)
        return;
      ((Control) changeDetailPrinter2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCheckPrinterTray")]
  internal virtual Label lblCheckPrinterTray { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheckDetailPrinterTray")]
  internal virtual Label lblCheckDetailPrinterTray { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBar1")]
  internal virtual UltraExplorerBar UltraExplorerBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl1")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl2")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmPrinterSettings));
    Appearance appearance4 = new Appearance();
    this.PrintDocument1 = new PrintDocument();
    this.PrintDialog1 = new PrintDialog();
    this.btnChangeCheckPrinter = new UltraButton();
    this.lblCheckPrinter = new Label();
    this.Label4 = new Label();
    this.Label1 = new Label();
    this.lblDetailsPrinter = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.lblCheckPrinterTray = new Label();
    this.Label6 = new Label();
    this.btnChangeDetailPrinter = new UltraButton();
    this.lblCheckDetailPrinterTray = new Label();
    this.Label9 = new Label();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    this.SuspendLayout();
    this.PrintDialog1.Document = this.PrintDocument1;
    ((Control) this.btnChangeCheckPrinter).Location = new Point(272, 144 /*0x90*/);
    ((Control) this.btnChangeCheckPrinter).Name = "btnChangeCheckPrinter";
    ((Control) this.btnChangeCheckPrinter).Size = new Size(120, 24);
    ((Control) this.btnChangeCheckPrinter).TabIndex = 7;
    ((ControlBase) this.btnChangeCheckPrinter).Text = "Change Printer..";
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
    this.Label4.Size = new Size(164, 18);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "Current Printer Selection:";
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(384, 48 /*0x30*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please specify the printer that will be used to print checks. If you are not sure of which printer to use, please contact your system administrator.";
    this.lblDetailsPrinter.BackColor = Color.Transparent;
    this.lblDetailsPrinter.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDetailsPrinter.Location = new Point(8, 96 /*0x60*/);
    this.lblDetailsPrinter.Name = "lblDetailsPrinter";
    this.lblDetailsPrinter.Size = new Size(384, 23);
    this.lblDetailsPrinter.TabIndex = 4;
    this.lblDetailsPrinter.Text = "None Selected";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 80 /*0x50*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(164, 18);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Current Printer Selection:";
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(8, 8);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(384, 64 /*0x40*/);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "In the event that a check pays more items that can fit on the check detail portion of your check paper, please specify the printer that will be used to print checks. If you are not sure of which printer to use, please contact your system administrator.";
    this.lblCheckPrinterTray.BackColor = Color.Transparent;
    this.lblCheckPrinterTray.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheckPrinterTray.Location = new Point(8, 112 /*0x70*/);
    this.lblCheckPrinterTray.Name = "lblCheckPrinterTray";
    this.lblCheckPrinterTray.Size = new Size(384, 23);
    this.lblCheckPrinterTray.TabIndex = 9;
    this.lblCheckPrinterTray.Text = "None Selected";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(8, 96 /*0x60*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(144 /*0x90*/, 18);
    this.Label6.TabIndex = 8;
    this.Label6.Text = "Printer Tray Selection:";
    ((Control) this.btnChangeDetailPrinter).Location = new Point(264, 176 /*0xB0*/);
    ((Control) this.btnChangeDetailPrinter).Name = "btnChangeDetailPrinter";
    ((Control) this.btnChangeDetailPrinter).Size = new Size(120, 24);
    ((Control) this.btnChangeDetailPrinter).TabIndex = 12;
    ((ControlBase) this.btnChangeDetailPrinter).Text = "Change Printer..";
    this.lblCheckDetailPrinterTray.BackColor = Color.Transparent;
    this.lblCheckDetailPrinterTray.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheckDetailPrinterTray.Location = new Point(8, 144 /*0x90*/);
    this.lblCheckDetailPrinterTray.Name = "lblCheckDetailPrinterTray";
    this.lblCheckDetailPrinterTray.Size = new Size(384, 23);
    this.lblCheckDetailPrinterTray.TabIndex = 11;
    this.lblCheckDetailPrinterTray.Text = "None Selected";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(8, 128 /*0x80*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(144 /*0x90*/, 18);
    this.Label9.TabIndex = 10;
    this.Label9.Text = "Printer Tray Selection:";
    appearance1.BackColor = Color.White;
    appearance1.BackColor2 = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance1;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
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
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    appearance3.AlphaLevel = (short) 38;
    appearance3.BackColor = Color.FromArgb(166, 202, 238);
    appearance3.BackColor2 = Color.FromArgb(166, 202, 238);
    appearance3.BackColorAlpha = (Alpha) 2;
    appearance3.BorderColor = Color.White;
    appearance3.FontData.Name = "Tahoma";
    appearance3.FontData.SizeInPoints = 8f;
    appearance3.ForeColor = Color.DarkBlue;
    appearance3.ForegroundAlpha = (Alpha) 2;
    appearance3.ImageBackground = (Image) resourceManager.GetObject("Appearance3.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance3;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance4;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSpacing = 10;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(434, 488);
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraExplorerBar1).TabIndex = 3;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnChangeCheckPrinter);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblCheckPrinter);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblCheckPrinterTray);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(22, 43);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(397, 171);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.btnChangeDetailPrinter);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label3);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label2);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.lblCheckDetailPrinterTray);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.lblDetailsPrinter);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(22, 270);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(397, 200);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(434, 488);
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPrinterSettings);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Check Printer Settings";
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadPrinterSelection(object sender, EventArgs e)
  {
    if (this.PrintDialog1.ShowDialog() != DialogResult.OK)
      return;
    string printerName = this.PrintDialog1.Document.PrinterSettings.PrinterName;
    string sourceName = this.PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSource.SourceName;
    if (sender == this.btnChangeCheckPrinter)
    {
      this.SavePrinterSettings(frmPrinterSettings.CheckPrinterType.Check, printerName, sourceName);
      this.lblCheckPrinter.Text = printerName;
      this.lblCheckPrinterTray.Text = sourceName;
    }
    else
    {
      this.SavePrinterSettings(frmPrinterSettings.CheckPrinterType.CheckDetail, printerName, sourceName);
      this.lblDetailsPrinter.Text = printerName;
      this.lblCheckDetailPrinterTray.Text = sourceName;
    }
  }

  private void frmPrinterSettings_Load(object sender, EventArgs e)
  {
    this.LoadCurrentPrinterSettings();
  }

  private void SavePrinterSettings(
    frmPrinterSettings.CheckPrinterType ct,
    string PrinterName,
    string PaperSource)
  {
    Database.Instance.QuerySP.PerformNonQuery("spFin_SavePrinterSettings", (object) "@printerType", (object) (int) ct, (object) "@printerName", (object) PrinterName, (object) "@paperSource", (object) PaperSource);
  }

  private void LoadCurrentPrinterSettings()
  {
    SqlCommand sqlCommand1 = new SqlCommand("Select * from tblfin_accountingprintersettings", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.Text;
      sqlCommand2.Connection.Open();
      sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
      {
        string Left = sqlDataReader["SettingKey"].ToString();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CPN", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CPS", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CDPN", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "CDPS", false) == 0)
                this.lblCheckDetailPrinterTray.Text = sqlDataReader["SettingValue"].ToString();
            }
            else
              this.lblDetailsPrinter.Text = sqlDataReader["SettingValue"].ToString();
          }
          else
            this.lblCheckPrinterTray.Text = sqlDataReader["SettingValue"].ToString();
        }
        else
          this.lblCheckPrinter.Text = sqlDataReader["SettingValue"].ToString();
      }
    }
    finally
    {
      if (sqlDataReader != null)
      {
        if (!sqlDataReader.IsClosed)
          sqlDataReader.Close();
      }
      if (sqlCommand1 != null && sqlCommand1.Connection != null)
      {
        sqlCommand1.Connection.Close();
        sqlCommand1.Connection.Dispose();
        sqlCommand1.Connection = (SqlConnection) null;
        sqlCommand1.Dispose();
      }
    }
  }

  private enum CheckPrinterType
  {
    Check,
    CheckDetail,
  }
}
