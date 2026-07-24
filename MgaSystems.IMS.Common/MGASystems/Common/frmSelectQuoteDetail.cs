// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.frmSelectQuoteDetail
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class frmSelectQuoteDetail : Form
{
  private Label Label1;
  private readonly Guid _quoteGuid;
  private bool _ItemSelected;

  private virtual MGAListBox lstPolicyDetails
  {
    get => this._lstPolicyDetails;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstPolicyDetails_DoubleClick);
      MGAListBox lstPolicyDetails1 = this._lstPolicyDetails;
      if (lstPolicyDetails1 != null)
        lstPolicyDetails1.DoubleClick -= eventHandler;
      this._lstPolicyDetails = value;
      MGAListBox lstPolicyDetails2 = this._lstPolicyDetails;
      if (lstPolicyDetails2 == null)
        return;
      lstPolicyDetails2.DoubleClick += eventHandler;
    }
  }

  private virtual MGAButton btnSelect
  {
    get => this._btnSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      MGAButton btnSelect1 = this._btnSelect;
      if (btnSelect1 != null)
        ((Control) btnSelect1).Click -= eventHandler;
      this._btnSelect = value;
      MGAButton btnSelect2 = this._btnSelect;
      if (btnSelect2 == null)
        return;
      ((Control) btnSelect2).Click += eventHandler;
    }
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.btnSelect = new MGAButton();
    this.lstPolicyDetails = new MGAListBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.btnSelect).BeginInit();
    ((ISupportInitialize) this.lstPolicyDetails).BeginInit();
    this.SuspendLayout();
    appearance.BackColor = Color.Gainsboro;
    appearance.BackColor2 = Color.White;
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.Gray;
    appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSelect).Appearance = (AppearanceBase) appearance;
    ((UltraButtonBase) this.btnSelect).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSelect).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSelect).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSelect).Location = new Point(610, 242);
    ((Control) this.btnSelect).Name = "btnSelect";
    ((Control) this.btnSelect).Size = new Size(40, 40);
    ((Control) this.btnSelect).TabIndex = 1;
    this.btnSelect.UseOSThemes = (DefaultableBoolean) 2;
    this.lstPolicyDetails.BackColor = Color.White;
    this.lstPolicyDetails.ForeColor = Color.Black;
    this.lstPolicyDetails.Location = new Point(12, 35);
    this.lstPolicyDetails.Name = "lstPolicyDetails";
    this.lstPolicyDetails.Size = new Size(638, 197);
    this.lstPolicyDetails.TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(277, 13);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Please select the policy item you would like to work with:";
    this.AcceptButton = (IButtonControl) this.btnSelect;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.CancelButton = (IButtonControl) this.btnSelect;
    this.ClientSize = new Size(662, 294);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lstPolicyDetails);
    this.Controls.Add((Control) this.btnSelect);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectQuoteDetail);
    this.Text = "Select Policy Detail Item";
    ((ISupportInitialize) this.btnSelect).EndInit();
    ((ISupportInitialize) this.lstPolicyDetails).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmSelectQuoteDetail(Guid QuoteGuid)
  {
    this.Load += new EventHandler(this.frmSelectQuoteDetail_Load);
    this.InitializeComponent();
    this._quoteGuid = QuoteGuid;
  }

  public Guid CompanyLineGuid => (Guid) this.lstPolicyDetails.SelectedValue;

  public bool ItemSelected => this._ItemSelected;

  private void frmSelectQuoteDetail_Load(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT dbo.GetCompanyLineState(CompanyLineGUID) AS CompanyLine, CompanyLineGUID FROM tblQuoteDetails WHERE (QuoteGUID = @QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    ((ControlBase) this.btnSelect).Appearance.Image = (object) ImageCache.Instance.Forward;
    MGAListBox lstPolicyDetails = this.lstPolicyDetails;
    lstPolicyDetails.DisplayMember = "CompanyLine";
    lstPolicyDetails.ValueMember = "CompanyLineGuid";
    lstPolicyDetails.DataSource = (object) dataTable;
    this.lstPolicyDetails.SelectedItem = (object) null;
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyDetails.SelectedIndex < 0)
      return;
    this._ItemSelected = this.lstPolicyDetails.SelectedItem != null;
    this.Close();
  }

  private void lstPolicyDetails_DoubleClick(object sender, EventArgs e)
  {
    this._ItemSelected = this.lstPolicyDetails.SelectedItem != null;
    this.Close();
  }
}
