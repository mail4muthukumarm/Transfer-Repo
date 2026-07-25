// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Insureds.frmInsuredSoundexMatches
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Insureds;

public sealed class frmInsuredSoundexMatches : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private bool _saved;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnSave
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

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  internal virtual UltraGrid ugDuplicateInsureds
  {
    get => this._ugDuplicateInsureds;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoubleClickRowEventHandler clickRowEventHandler = new DoubleClickRowEventHandler(this.ugDuplicateInsureds_DoubleClickRow);
      UltraGrid duplicateInsureds1 = this._ugDuplicateInsureds;
      if (duplicateInsureds1 != null)
        duplicateInsureds1.DoubleClickRow -= clickRowEventHandler;
      this._ugDuplicateInsureds = value;
      UltraGrid duplicateInsureds2 = this._ugDuplicateInsureds;
      if (duplicateInsureds2 == null)
        return;
      duplicateInsureds2.DoubleClickRow += clickRowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.ugDuplicateInsureds = new UltraGrid();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.ugDuplicateInsureds).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(320, 40);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "The following insureds were found in the system that are close matches to the insured you are adding.  Double click a record to open that record.";
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label2.Location = new Point(8, 365);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(224 /*0xE0*/, 15);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Do you want to save this insured anyway?";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(394, 355);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(346, 355);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 5;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugDuplicateInsureds).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.ColumnSizingArea = (ColumnSizingArea) 3;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Override.SelectTypeRow = (SelectType) 3;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugDuplicateInsureds).Location = new Point(11, 64 /*0x40*/);
    ((Control) this.ugDuplicateInsureds).Name = "ugDuplicateInsureds";
    ((Control) this.ugDuplicateInsureds).Size = new Size(421, 275);
    ((Control) this.ugDuplicateInsureds).TabIndex = 6;
    ((Control) this.ugDuplicateInsureds).Tag = (object) "keepEnabled";
    ((UltraControlBase) this.ugDuplicateInsureds).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDuplicateInsureds).UseOsThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(444, 403);
    this.Controls.Add((Control) this.ugDuplicateInsureds);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmInsuredSoundexMatches);
    this.ShowInTaskbar = false;
    this.Text = "Insured Name Matches";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.ugDuplicateInsureds).EndInit();
    this.ResumeLayout(false);
  }

  public bool Saved => this._saved;

  public frmInsuredSoundexMatches(DataTable dtNameMatches)
  {
    this.Load += new EventHandler(this.frmInsuredSoundexMatches_Load);
    this.InitializeComponent();
    ((UltraGridBase) this.ugDuplicateInsureds).DataSource = (object) dtNameMatches;
    ((UltraGridBase) this.ugDuplicateInsureds).DisplayLayout.Bands[0].Columns[0].Hidden = true;
  }

  private void frmInsuredSoundexMatches_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._saved = true;
    this.Close();
  }

  private void ugDuplicateInsureds_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (e.Row == null || MessageBox.Show("Would you like to open this insured and abandon your current new insured?", "Abandon New Insured?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form = mdiChildren[index];
      if (form is frmInsureds)
        form.Close();
      checked { ++index; }
    }
    new frmInsureds((Guid) e.Row.Cells["InsuredGUID"].Value).Show();
  }
}
