// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.formViewNonPayableFees
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.IMS.Accounting.Services;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class formViewNonPayableFees : AccountingNoteDocumentSupport
{
  private System.ComponentModel.Container components;
  private UltraGrid gridNonPayableFees;
  private NonPayableFeeCollection feesCollection;

  private formViewNonPayableFees() => this.InitializeComponent();

  public formViewNonPayableFees(ref NonPayableFeeCollection feesCollection)
  {
    this.InitializeComponent();
    this.feesCollection = feesCollection;
    ((UltraGridBase) this.gridNonPayableFees).DataSource = (object) this.feesCollection;
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
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.gridNonPayableFees = new UltraGrid();
    ((ISupportInitialize) this.gridNonPayableFees).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridNonPayableFees).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridNonPayableFees).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridNonPayableFees).Location = new Point(0, 0);
    ((Control) this.gridNonPayableFees).Name = "gridNonPayableFees";
    ((Control) this.gridNonPayableFees).Size = new Size(576, 266);
    ((UltraControlBase) this.gridNonPayableFees).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridNonPayableFees).TabIndex = 0;
    this.gridNonPayableFees.UpdateMode = (UpdateMode) 2;
    this.gridNonPayableFees.InitializeLayout += new InitializeLayoutEventHandler(this.gridNonPayableFees_InitializeLayout);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(576, 266);
    this.Controls.Add((Control) this.gridNonPayableFees);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formViewNonPayableFees);
    this.Text = "Non Payable Fees";
    this.Closing += new CancelEventHandler(this.formViewNonPayableFees_Closing);
    ((ISupportInitialize) this.gridNonPayableFees).EndInit();
    this.ResumeLayout(false);
  }

  private void gridNonPayableFees_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["companylineguid"].Hidden = true;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["chargecode"].Hidden = true;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["invoicenumber"].Hidden = true;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["quotecontrolnumber"].Hidden = true;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["amount"].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["amount"].Format = "c";
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["amount"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["isSelected"].Header).Appearance.TextHAlign = (HAlign) 2;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["isSelected"].Header).VisiblePosition = 0;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["PolicyNumber"].Header).VisiblePosition = 1;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["OfficeInvoiceNumber"].Header).VisiblePosition = 2;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["InsuredName"].Header).VisiblePosition = 3;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["Amount"].Header).VisiblePosition = 4;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["isSelected"].CellActivation = (Activation) 0;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["PolicyNumber"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["OfficeInvoiceNumber"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["InsuredName"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["Amount"].CellActivation = (Activation) 3;
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["isSelected"].Header).Caption = "Select";
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["PolicyNumber"].Header).Caption = "Policy #";
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["InsuredName"].Header).Caption = "Insured";
    ((HeaderBase) ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns["OfficeInvoiceNumber"].Header).Caption = "Invoice #";
  }

  private void formViewNonPayableFees_Closing(object sender, CancelEventArgs e)
  {
    ((UltraGridBase) this.gridNonPayableFees).UpdateData();
  }
}
