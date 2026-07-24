// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.formFinancedReceivables
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

public class formFinancedReceivables : AccountingNoteDocumentSupport
{
  private EllipsePanel ellipsePanel1;
  private Label label1;
  private PictureBox pictureBox1;
  private UltraGrid gridFinancedReceivables;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private System.ComponentModel.Container components;
  private FinancedReturnCollection _financedReceivables;

  public formFinancedReceivables(ref FinancedReturnCollection financedReceivables)
  {
    this.InitializeComponent();
    this._financedReceivables = financedReceivables;
    this.BindGrid();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formFinancedReceivables));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.ellipsePanel1 = new EllipsePanel();
    this.buttonSave = new MGAButton();
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.gridFinancedReceivables = new UltraGrid();
    this.buttonCancel = new MGAButton();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.gridFinancedReceivables).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.buttonSave);
    this.ellipsePanel1.Controls.Add((Control) this.label1);
    this.ellipsePanel1.Controls.Add((Control) this.pictureBox1);
    this.ellipsePanel1.Controls.Add((Control) this.gridFinancedReceivables);
    this.ellipsePanel1.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(576, 360);
    this.ellipsePanel1.TabIndex = 2;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonSave).Location = new Point(304, 328);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonSave).TabIndex = 3;
    ((Control) this.buttonSave).Text = "Continue &Processing";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.label1.Location = new Point(80 /*0x50*/, 16 /*0x10*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(480, 32 /*0x20*/);
    this.label1.TabIndex = 2;
    this.label1.Text = "The system determined that some of the return premium policies selected are financed. Please select the policies that you would like the system to create checks for the finance company.";
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(8, 8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance9).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridFinancedReceivables).Location = new Point(8, 72);
    ((Control) this.gridFinancedReceivables).Name = "gridFinancedReceivables";
    ((Control) this.gridFinancedReceivables).Size = new Size(560, 248);
    ((Control) this.gridFinancedReceivables).TabIndex = 0;
    ((UltraControlBase) this.gridFinancedReceivables).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridFinancedReceivables).UseOsThemes = (DefaultableBoolean) 2;
    this.gridFinancedReceivables.AfterCellUpdate += new CellEventHandler(this.gridFinancedReceivables_AfterCellUpdate);
    this.gridFinancedReceivables.InitializeLayout += new InitializeLayoutEventHandler(this.gridFinancedReceivables_InitializeLayout);
    this.gridFinancedReceivables.CellChange += new CellEventHandler(this.gridFinancedReceivables_CellChange);
    this.gridFinancedReceivables.ClickCell += new ClickCellEventHandler(this.gridFinancedReceivables_ClickCell);
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance11;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(440, 328);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonCancel).TabIndex = 4;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(582, 369);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximumSize = new Size(598, 408);
    this.MinimumSize = new Size(598, 408);
    this.Name = nameof (formFinancedReceivables);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Financed Receivables";
    this.ellipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.gridFinancedReceivables).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void BindGrid()
  {
    ((UltraGridBase) this.gridFinancedReceivables).DataSource = (object) this._financedReceivables;
    this.CreateGridSummaries();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridFinancedReceivables_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (!(((UltraGridBase) this.gridFinancedReceivables).DataSource is FinancedReturnCollection))
      return;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[0].Columns["financecompanyguid"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[0].Columns["glcompanyid"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[0].Columns["checkdate"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[0].Columns["financecompanyname"].Header).Caption = "Finance Company";
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[0].Columns["financecompanyname"].CellActivation = (Activation) 3;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[0].Columns["financecompanyname"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["invoicenumber"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["chargecode"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["companylineguid"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["glaccountid"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["controlNumber"].Hidden = true;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["entityGuid"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["amount"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["amount"].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["amount"].Format = "c";
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["amount"].CellActivation = (Activation) 3;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["selected"].Header).VisiblePosition = 0;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["selected"].Header).Caption = "Select";
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["selected"].CellActivation = (Activation) 0;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["policyNumber"].Header).VisiblePosition = 1;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["policyNumber"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["policyNumber"].Header).Caption = "Policy Number";
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["policyNumber"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["policyNumber"].CellAppearance.TextHAlign = (HAlign) 1;
  }

  private void CreateGridSummaries()
  {
    ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Summaries.Add("AmountSum", (SummaryType) 1, ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Columns["Amount"], (SummaryPosition) 3);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridFinancedReceivables).DisplayLayout.Bands[1].Summaries)
    {
      summary.DisplayFormat = "{0:c}";
      summary.Appearance.TextHAlign = (HAlign) 3;
    }
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void gridFinancedReceivables_CellChange(object sender, CellEventArgs e)
  {
    e.Cell.Row.Update();
  }

  private void gridFinancedReceivables_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "Selected"))
      return;
    this._financedReceivables.UpdateRelatedItems(int.Parse(e.Cell.Row.Cells["controlNumber"].Value.ToString()), bool.Parse(e.Cell.Value.ToString()));
  }

  private void gridFinancedReceivables_ClickCell(object sender, ClickCellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "Selected"))
      return;
    ((UltraGridBase) this.gridFinancedReceivables).UpdateData();
  }
}
