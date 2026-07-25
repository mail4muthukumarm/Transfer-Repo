// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Commission_Check_Tool.FormCommissionCheck
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Underwriting.Commission_Check_Tool;

[SecureResource("{21CB0CD5-8A59-48fe-8E28-7AA9DB84E968}", "Can View Commissions Check", "Controls the ability to view commissions check menu.", "Commissions")]
public class FormCommissionCheck : Form
{
  public const string ViewCommissionsCheck = "{21CB0CD5-8A59-48fe-8E28-7AA9DB84E968}";
  private IContainer components;
  internal MGAComboBox cboOfficeLocation;
  internal MGAComboBox cboCompanyline;
  private UltraGroupBox grpCommissionsResult;
  private MGATextBox txtProducerCommission;
  private dsCommissionCheck ds;
  private ErrorProvider err;
  private MGAButton btnSearchCommissions;
  private MGADateTimePicker dtDate;
  private CheckBox chkRenewal;
  private MGATextBox txtCarrierTermsOfPayment;
  private MGATextBox txtProducerTermsOfPayment;
  private MGATextBox txtCarrierCommission;
  private SqlConnection cnSQL;
  internal MGAComboBox cboProgramCode;
  internal MGAComboBox cboPolicyType;
  private MGAButton btnSearch;
  private MGATextBox txtProducerLocation;

  public FormCommissionCheck()
  {
    this.InitializeComponent();
    this.cnSQL.ConnectionString = DefaultDatabase.ConnectionString;
  }

  private void FormCommissionCheck_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
    {
      "tblClientOffices",
      "tblCompanyLines",
      "tblCompanyProgramCodes",
      "lstPolicyTypes"
    }, "dbo.GetCommissionCheckData");
    this.dtDate.Value = (object) DateTime.Now;
  }

  private bool ValidDataOnForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboCompanyline, string.Empty);
    this.err.SetError((Control) this.txtProducerLocation, string.Empty);
    this.err.SetError((Control) this.dtDate, string.Empty);
    this.err.SetError((Control) this.cboPolicyType, string.Empty);
    if (string.IsNullOrEmpty(((Control) this.cboCompanyline).Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboCompanyline, "Please select a value.");
    }
    if (((Control) this.txtProducerLocation).Tag == null)
    {
      flag = false;
      this.err.SetError((Control) this.txtProducerLocation, "Please search for a value.");
    }
    if (this.dtDate.Value == null || this.dtDate.Value == DBNull.Value)
    {
      flag = false;
      this.err.SetError((Control) this.dtDate, "Please enter a value.");
    }
    if (string.IsNullOrEmpty(((Control) this.cboPolicyType).Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboPolicyType, "Please select a value.");
    }
    return flag;
  }

  private void ClearData()
  {
    foreach (Control control in (ArrangedElementCollection) ((Control) this.grpCommissionsResult).Controls)
    {
      if (control is MGATextBox mgaTextBox)
        ((Control) mgaTextBox).Text = string.Empty;
    }
  }

  private void btnSearchCommissions_Click(object sender, EventArgs e)
  {
    this.ClearData();
    if (!this.ValidDataOnForm())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      object programID = (object) null;
      Guid empty = Guid.Empty;
      if (this.cboProgramCode.Value != null && this.cboProgramCode.Value != DBNull.Value)
        programID = this.cboProgramCode.Value;
      if (this.cboOfficeLocation.Value != null && this.cboOfficeLocation.Value != DBNull.Value)
        empty = (Guid) this.cboOfficeLocation.Value;
      Decimal commission = new ProducerLocation((Guid) ((Control) this.txtProducerLocation).Tag).GetCommission((Guid) this.cboCompanyline.Value, this.chkRenewal.Checked, (DateTime) this.dtDate.Value, (SqlTransaction) null, (object) (int) this.cboPolicyType.Value, programID, empty);
      ((Control) this.txtProducerCommission).Text = commission.ToString("p");
      ((Control) this.txtCarrierCommission).Text = new CompanyLine((Guid) this.cboCompanyline.Value).GetCommission(this.chkRenewal.Checked, (Guid) ((Control) this.txtProducerLocation).Tag, commission, (DateTime) this.dtDate.Value, (int) this.cboPolicyType.Value, (SqlTransaction) null, Guid.Empty, programID, empty).ToString("p");
      object obj = DefaultDatabase.ExecuteScalar("CarrierTermsOfPayments", new object[4]
      {
        (object) "@CompanyLineGUID",
        (object) (Guid) this.cboCompanyline.Value,
        (object) "@date",
        (object) (DateTime) this.dtDate.Value
      });
      if (obj != null && obj != DBNull.Value)
        ((Control) this.txtCarrierTermsOfPayment).Text = obj.ToString();
      ProducerLine producerLine1 = new ProducerLine((Guid) ((Control) this.txtProducerLocation).Tag, (Guid) this.cboCompanyline.Value, (DateTime) this.dtDate.Value);
      if (this.cboOfficeLocation.Value != null && this.cboOfficeLocation.Value != DBNull.Value)
      {
        ProducerLine producerLine2 = new ProducerLine((Guid) ((Control) this.txtProducerLocation).Tag, (Guid) this.cboCompanyline.Value, (DateTime) this.dtDate.Value, (Guid) this.cboOfficeLocation.Value);
      }
      if (!producerLine1.Exists)
        return;
      if (producerLine1.HasDaysDue)
      {
        ((Control) this.txtProducerTermsOfPayment).Text = producerLine1.DaysDue.ToString();
      }
      else
      {
        if (!producerLine1.HasDaysDueEndorsement)
          return;
        ((Control) this.txtProducerTermsOfPayment).Text = producerLine1.DaysDueEndorsement.ToString();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    ((Control) this.txtProducerLocation).Text = string.Empty;
    ((Control) this.txtProducerLocation).Tag = (object) null;
    Guid empty = Guid.Empty;
    using (frmSelection frmSelection = new frmSelection(frmSelection.SelectionTypes.Producer, true))
    {
      int num = (int) frmSelection.ShowDialog();
      if (frmSelection.SelectedGuid.Equals(Guid.Empty))
        return;
      ((Control) this.txtProducerLocation).Tag = (object) frmSelection.SelectedGuid;
      ProducerLocation producerLocation = new ProducerLocation(frmSelection.SelectedGuid);
      string address1 = producerLocation.Address1;
      string city = producerLocation.City;
      string state = producerLocation.State;
      string zip = producerLocation.Zip;
      if (!string.IsNullOrEmpty(city))
        city += ", ";
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(producerLocation.LocationName);
      if (!string.IsNullOrEmpty(address1))
        stringBuilder.AppendLine(address1);
      stringBuilder.AppendLine($"{city}{state} {zip}");
      ((Control) this.txtProducerLocation).Text = stringBuilder.ToString();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCommissionCheck));
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstPolicyTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
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
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance24 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyProgramCodes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProgCode");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
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
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance38 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyLines", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLineGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLine");
    Appearance appearance39 = new Appearance();
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
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance52 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("OfficeGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Location");
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
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    this.grpCommissionsResult = new UltraGroupBox();
    this.txtCarrierTermsOfPayment = new MGATextBox();
    this.txtProducerTermsOfPayment = new MGATextBox();
    this.txtCarrierCommission = new MGATextBox();
    this.txtProducerCommission = new MGATextBox();
    this.err = new ErrorProvider(this.components);
    this.btnSearchCommissions = new MGAButton();
    this.dtDate = new MGADateTimePicker();
    this.chkRenewal = new CheckBox();
    this.cnSQL = new SqlConnection();
    this.cboPolicyType = new MGAComboBox();
    this.ds = new dsCommissionCheck();
    this.cboProgramCode = new MGAComboBox();
    this.cboCompanyline = new MGAComboBox();
    this.cboOfficeLocation = new MGAComboBox();
    this.btnSearch = new MGAButton();
    this.txtProducerLocation = new MGATextBox();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    Label label8 = new Label();
    Label label9 = new Label();
    Label label10 = new Label();
    Label label11 = new Label();
    Label label12 = new Label();
    ((ISupportInitialize) this.grpCommissionsResult).BeginInit();
    ((Control) this.grpCommissionsResult).SuspendLayout();
    ((ISupportInitialize) this.txtCarrierTermsOfPayment).BeginInit();
    ((ISupportInitialize) this.txtProducerTermsOfPayment).BeginInit();
    ((ISupportInitialize) this.txtCarrierCommission).BeginInit();
    ((ISupportInitialize) this.txtProducerCommission).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnSearchCommissions).BeginInit();
    ((ISupportInitialize) this.dtDate).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboProgramCode).BeginInit();
    ((ISupportInitialize) this.cboCompanyline).BeginInit();
    ((ISupportInitialize) this.cboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.txtProducerLocation).BeginInit();
    this.SuspendLayout();
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(49, 27);
    label1.Name = "lblPolicyClass";
    label1.Size = new Size(116, 23);
    label1.TabIndex = 42;
    label1.Text = "Producer Commission:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.Location = new Point(62, 20);
    label2.Name = "label1";
    label2.Size = new Size(97, 13);
    label2.TabIndex = 57;
    label2.Text = "Producer Location:";
    label3.AutoSize = true;
    label3.Location = new Point(9, 114);
    label3.Name = "label2";
    label3.Size = new Size(151, 13);
    label3.TabIndex = 59;
    label3.Text = "Client Quoting Office Location:";
    label4.AutoSize = true;
    label4.Location = new Point(81, 152);
    label4.Name = "label4";
    label4.Size = new Size(79, 13);
    label4.TabIndex = 63 /*0x3F*/;
    label4.Text = "Company/Line:";
    label5.AutoSize = true;
    label5.Location = new Point(108, 253);
    label5.Name = "label7";
    label5.Size = new Size(52, 13);
    label5.TabIndex = 67;
    label5.Text = "Effective:";
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(55, 89);
    label6.Name = "label8";
    label6.Size = new Size(110, 23);
    label6.TabIndex = 73;
    label6.Text = "Carrier Commission:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(21, 120);
    label7.Name = "label5";
    label7.Size = new Size(144 /*0x90*/, 23);
    label7.TabIndex = 74;
    label7.Text = "Carrier Terms of Payment:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(13, 58);
    label8.Name = "label6";
    label8.Size = new Size(152, 23);
    label8.TabIndex = 75;
    label8.Text = "Producer Terms of Payment:";
    label8.TextAlign = ContentAlignment.MiddleRight;
    label9.AutoSize = true;
    label9.Location = new Point(244, 63 /*0x3F*/);
    label9.Name = "label3";
    label9.Size = new Size(32 /*0x20*/, 13);
    label9.TabIndex = 69;
    label9.Text = "days.";
    label10.AutoSize = true;
    label10.Location = new Point(244, 125);
    label10.Name = "label9";
    label10.Size = new Size(32 /*0x20*/, 13);
    label10.TabIndex = 76;
    label10.Text = "days.";
    label11.AutoSize = true;
    label11.Location = new Point(83, 187);
    label11.Name = "label10";
    label11.Size = new Size(77, 13);
    label11.TabIndex = 71;
    label11.Text = "Program Code:";
    label12.AutoSize = true;
    label12.Location = new Point(94, 219);
    label12.Name = "label11";
    label12.Size = new Size(65, 13);
    label12.TabIndex = 73;
    label12.Text = "Policy Type:";
    this.grpCommissionsResult.BackColorInternal = Color.Transparent;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpCommissionsResult.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpCommissionsResult).Controls.Add((Control) label10);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) label9);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) label8);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) label7);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) label6);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) this.txtCarrierTermsOfPayment);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) this.txtProducerTermsOfPayment);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) this.txtCarrierCommission);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) this.txtProducerCommission);
    ((Control) this.grpCommissionsResult).Controls.Add((Control) label1);
    ((AppearanceBase) appearance2).ForeColor = Color.Navy;
    this.grpCommissionsResult.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpCommissionsResult).Location = new Point(178, 307);
    ((Control) this.grpCommissionsResult).Name = "grpCommissionsResult";
    ((Control) this.grpCommissionsResult).Size = new Size(288, 155);
    ((Control) this.grpCommissionsResult).TabIndex = 7;
    ((Control) this.grpCommissionsResult).Text = "Commissions and Terms of Payments";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCarrierTermsOfPayment).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtCarrierTermsOfPayment).BackColor = Color.White;
    ((Control) this.txtCarrierTermsOfPayment).Location = new Point(171, 122);
    this.txtCarrierTermsOfPayment.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCarrierTermsOfPayment).Name = "txtCarrierTermsOfPayment";
    ((Control) this.txtCarrierTermsOfPayment).Size = new Size(56, 19);
    ((Control) this.txtCarrierTermsOfPayment).TabIndex = 72;
    ((UltraControlBase) this.txtCarrierTermsOfPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCarrierTermsOfPayment).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerTermsOfPayment).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtProducerTermsOfPayment).BackColor = Color.White;
    ((Control) this.txtProducerTermsOfPayment).Location = new Point(171, 60);
    this.txtProducerTermsOfPayment.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtProducerTermsOfPayment).Name = "txtProducerTermsOfPayment";
    ((Control) this.txtProducerTermsOfPayment).Size = new Size(56, 19);
    ((Control) this.txtProducerTermsOfPayment).TabIndex = 71;
    ((UltraControlBase) this.txtProducerTermsOfPayment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerTermsOfPayment).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCarrierCommission).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtCarrierCommission).BackColor = Color.White;
    ((Control) this.txtCarrierCommission).Location = new Point(171, 91);
    this.txtCarrierCommission.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCarrierCommission).Name = "txtCarrierCommission";
    ((Control) this.txtCarrierCommission).Size = new Size(56, 19);
    ((Control) this.txtCarrierCommission).TabIndex = 67;
    ((UltraControlBase) this.txtCarrierCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCarrierCommission).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerCommission).Appearance = (AppearanceBase) appearance6;
    ((Control) this.txtProducerCommission).BackColor = Color.White;
    ((Control) this.txtProducerCommission).Location = new Point(171, 29);
    this.txtProducerCommission.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtProducerCommission).Name = "txtProducerCommission";
    ((Control) this.txtProducerCommission).Size = new Size(56, 19);
    ((Control) this.txtProducerCommission).TabIndex = 41;
    ((UltraControlBase) this.txtProducerCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerCommission).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.btnSearchCommissions).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance7).Image = componentResourceManager.GetObject("appearance39.Image");
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 3;
    ((AppearanceBase) appearance7).ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((ControlBase) this.btnSearchCommissions).Appearance = (AppearanceBase) appearance7;
    ((ControlBase) this.btnSearchCommissions).ImageSize = new Size(24, 24);
    ((Control) this.btnSearchCommissions).Location = new Point(531, 431);
    ((Control) this.btnSearchCommissions).Name = "btnSearchCommissions";
    ((Control) this.btnSearchCommissions).RightToLeft = RightToLeft.No;
    ((Control) this.btnSearchCommissions).Size = new Size(154, 31 /*0x1F*/);
    ((Control) this.btnSearchCommissions).TabIndex = 8;
    ((Control) this.btnSearchCommissions).Text = "Check Commissions";
    ((UltraControlBase) this.btnSearchCommissions).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearchCommissions).Click += new EventHandler(this.btnSearchCommissions_Click);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDate.Appearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance9).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance9).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance9).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance9).ForegroundAlpha = (Alpha) 2;
    this.dtDate.ButtonAppearance = (AppearanceBase) appearance9;
    this.dtDate.DateTime = new DateTime(2008, 10, 27, 0, 0, 0, 0);
    ((Control) this.dtDate).Location = new Point(178, 250);
    this.dtDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDate).Name = "dtDate";
    ((Control) this.dtDate).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.dtDate).TabIndex = 5;
    ((UltraControlBase) this.dtDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDate.Value = (object) new DateTime(2008, 10, 27, 0, 0, 0, 0);
    this.chkRenewal.AutoSize = true;
    this.chkRenewal.Location = new Point(178, 284);
    this.chkRenewal.Name = "chkRenewal";
    this.chkRenewal.Size = new Size(68, 17);
    this.chkRenewal.TabIndex = 6;
    this.chkRenewal.Text = "Renewal";
    this.chkRenewal.UseVisualStyleBackColor = true;
    this.cnSQL.ConnectionString = "Data Source=COLOSQL2;Initial Catalog=WKFC_IMS;Persist Security Info=True;User ID=erichards";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.cboPolicyType.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.ds;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboPolicyType.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.cboPolicyType.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 259;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 272;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboPolicyType.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboPolicyType.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboPolicyType.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance11).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboPolicyType.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).ForeColor = SystemColors.GrayText;
    this.cboPolicyType.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance12;
    ((SpecialBoxBase) this.cboPolicyType.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance13).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance13).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance13).ForeColor = SystemColors.GrayText;
    this.cboPolicyType.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance13;
    this.cboPolicyType.DisplayLayout.MaxColScrollRegions = 1;
    this.cboPolicyType.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance14).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance14).ForeColor = SystemColors.ControlText;
    this.cboPolicyType.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance15).ForeColor = SystemColors.HighlightText;
    this.cboPolicyType.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboPolicyType.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance16).BackColor = SystemColors.Window;
    this.cboPolicyType.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BorderColor = Color.Silver;
    ((AppearanceBase) appearance17).TextTrimming = (TextTrimming) 3;
    this.cboPolicyType.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    this.cboPolicyType.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboPolicyType.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance18).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance18).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance18).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance18).BorderColor = SystemColors.Window;
    this.cboPolicyType.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    this.cboPolicyType.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    this.cboPolicyType.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboPolicyType.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboPolicyType.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance21).BorderColor = Color.White;
    this.cboPolicyType.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    this.cboPolicyType.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboPolicyType.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    this.cboPolicyType.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = SystemColors.ControlLight;
    this.cboPolicyType.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance23;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboPolicyType.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.cboPolicyType.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboPolicyType.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboPolicyType.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    this.cboPolicyType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboPolicyType).DropDownWidth = 550;
    ((Control) this.cboPolicyType).Location = new Point(178, 215);
    this.cboPolicyType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(507, 20);
    ((Control) this.cboPolicyType).TabIndex = 4;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    this.ds.DataSetName = "dsCommissionCheck";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboProgramCode.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProgramCode).DataMember = "tblCompanyProgramCodes";
    ((UltraGridBase) this.cboProgramCode).DataSource = (object) this.ds;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProgramCode.DisplayLayout.Appearance = (AppearanceBase) appearance24;
    this.cboProgramCode.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 239;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Width = 531;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboProgramCode.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboProgramCode.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProgramCode.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance25).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance25).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboProgramCode.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).ForeColor = SystemColors.GrayText;
    this.cboProgramCode.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance26;
    ((SpecialBoxBase) this.cboProgramCode.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance27).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance27).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance27).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance27).ForeColor = SystemColors.GrayText;
    this.cboProgramCode.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance27;
    this.cboProgramCode.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProgramCode.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance28).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance28).ForeColor = SystemColors.ControlText;
    this.cboProgramCode.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance29).ForeColor = SystemColors.HighlightText;
    this.cboProgramCode.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance29;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance30).BackColor = SystemColors.Window;
    this.cboProgramCode.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BorderColor = Color.Silver;
    ((AppearanceBase) appearance31).TextTrimming = (TextTrimming) 3;
    this.cboProgramCode.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance31;
    this.cboProgramCode.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProgramCode.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance32).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance32).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance32).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance32).BorderColor = SystemColors.Window;
    this.cboProgramCode.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    this.cboProgramCode.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance33;
    this.cboProgramCode.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProgramCode.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProgramCode.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance35).BorderColor = Color.White;
    this.cboProgramCode.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    this.cboProgramCode.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProgramCode.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance36).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance36).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    this.cboProgramCode.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).BackColor = SystemColors.ControlLight;
    this.cboProgramCode.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance37;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProgramCode.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboProgramCode.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProgramCode.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProgramCode.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProgramCode).DisplayMember = "ProgCode";
    this.cboProgramCode.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProgramCode).DropDownWidth = 550;
    ((Control) this.cboProgramCode).Location = new Point(178, 180);
    this.cboProgramCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProgramCode).Name = "cboProgramCode";
    ((Control) this.cboProgramCode).Size = new Size(507, 20);
    ((Control) this.cboProgramCode).TabIndex = 3;
    ((UltraControlBase) this.cboProgramCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProgramCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProgramCode).ValueMember = "ProgramID";
    this.cboCompanyline.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCompanyline).DataMember = "tblCompanyLines";
    ((UltraGridBase) this.cboCompanyline).DataSource = (object) this.ds;
    ((AppearanceBase) appearance38).BackColor = Color.White;
    ((AppearanceBase) appearance38).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboCompanyline.DisplayLayout.Appearance = (AppearanceBase) appearance38;
    this.cboCompanyline.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 381;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 531;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboCompanyline.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboCompanyline.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanyline.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance39).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance39).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance39).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance39).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboCompanyline.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).ForeColor = SystemColors.GrayText;
    this.cboCompanyline.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance40;
    ((SpecialBoxBase) this.cboCompanyline.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance41).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance41).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance41).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance41).ForeColor = SystemColors.GrayText;
    this.cboCompanyline.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance41;
    this.cboCompanyline.DisplayLayout.MaxColScrollRegions = 1;
    this.cboCompanyline.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance42).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance42).ForeColor = SystemColors.ControlText;
    this.cboCompanyline.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance43).ForeColor = SystemColors.HighlightText;
    this.cboCompanyline.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance43;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboCompanyline.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance44).BackColor = SystemColors.Window;
    this.cboCompanyline.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BorderColor = Color.Silver;
    ((AppearanceBase) appearance45).TextTrimming = (TextTrimming) 3;
    this.cboCompanyline.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance45;
    this.cboCompanyline.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboCompanyline.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance46).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance46).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance46).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance46).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance46).BorderColor = SystemColors.Window;
    this.cboCompanyline.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance46;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Left";
    this.cboCompanyline.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance47;
    this.cboCompanyline.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboCompanyline.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance48).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCompanyline.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance49).BorderColor = Color.White;
    this.cboCompanyline.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance49;
    this.cboCompanyline.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboCompanyline.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance50).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance50).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance50).ForeColor = Color.Black;
    this.cboCompanyline.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = SystemColors.ControlLight;
    this.cboCompanyline.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance51;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboCompanyline.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.cboCompanyline.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboCompanyline.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboCompanyline.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboCompanyline).DisplayMember = "CompanyLine";
    this.cboCompanyline.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyline).DropDownWidth = 750;
    ((Control) this.cboCompanyline).Location = new Point(178, 145);
    this.cboCompanyline.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyline).Name = "cboCompanyline";
    ((Control) this.cboCompanyline).Size = new Size(507, 20);
    ((Control) this.cboCompanyline).TabIndex = 2;
    ((UltraControlBase) this.cboCompanyline).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyline).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyline).ValueMember = "CompanyLineGUID";
    this.cboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboOfficeLocation).DataMember = "tblClientOffices";
    ((UltraGridBase) this.cboOfficeLocation).DataSource = (object) this.ds;
    ((AppearanceBase) appearance52).BackColor = Color.White;
    ((AppearanceBase) appearance52).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboOfficeLocation.DisplayLayout.Appearance = (AppearanceBase) appearance52;
    this.cboOfficeLocation.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 194;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Width = 481;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    this.cboOfficeLocation.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.cboOfficeLocation.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOfficeLocation.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance53).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance53).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance53).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance53).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboOfficeLocation.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).ForeColor = SystemColors.GrayText;
    this.cboOfficeLocation.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance54;
    ((SpecialBoxBase) this.cboOfficeLocation.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance55).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance55).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance55).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance55).ForeColor = SystemColors.GrayText;
    this.cboOfficeLocation.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance55;
    this.cboOfficeLocation.DisplayLayout.MaxColScrollRegions = 1;
    this.cboOfficeLocation.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance56).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance56).ForeColor = SystemColors.ControlText;
    this.cboOfficeLocation.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance56;
    ((AppearanceBase) appearance57).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance57).ForeColor = SystemColors.HighlightText;
    this.cboOfficeLocation.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance57;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboOfficeLocation.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance58).BackColor = SystemColors.Window;
    this.cboOfficeLocation.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance58;
    ((AppearanceBase) appearance59).BorderColor = Color.Silver;
    ((AppearanceBase) appearance59).TextTrimming = (TextTrimming) 3;
    this.cboOfficeLocation.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance59;
    this.cboOfficeLocation.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboOfficeLocation.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance60).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance60).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance60).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance60).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance60).BorderColor = SystemColors.Window;
    this.cboOfficeLocation.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Left";
    this.cboOfficeLocation.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance61;
    this.cboOfficeLocation.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboOfficeLocation.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance62).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance62).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboOfficeLocation.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance63).BorderColor = Color.White;
    this.cboOfficeLocation.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance63;
    this.cboOfficeLocation.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboOfficeLocation.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance64).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance64).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance64).ForeColor = Color.Black;
    this.cboOfficeLocation.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BackColor = SystemColors.ControlLight;
    this.cboOfficeLocation.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance65;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboOfficeLocation.DisplayLayout.ScrollBarLook = scrollBarLook4;
    this.cboOfficeLocation.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboOfficeLocation.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboOfficeLocation.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboOfficeLocation).DisplayMember = "Location";
    this.cboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOfficeLocation).DropDownWidth = 500;
    ((Control) this.cboOfficeLocation).Location = new Point(178, 110);
    this.cboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOfficeLocation).Name = "cboOfficeLocation";
    ((Control) this.cboOfficeLocation).Size = new Size(507, 20);
    ((Control) this.cboOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.cboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOfficeLocation).ValueMember = "OfficeGUID";
    ((AppearanceBase) appearance66).ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance66;
    ((Control) this.btnSearch).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(645, 15);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((ControlBase) this.btnSearch).Padding = new Size(5, 0);
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 211;
    ((UltraControlBase) this.btnSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Click += new EventHandler(this.btnSearch_Click);
    ((AppearanceBase) appearance67).BackColor = Color.White;
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance67).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducerLocation).Appearance = (AppearanceBase) appearance67;
    ((Control) this.txtProducerLocation).BackColor = Color.White;
    ((Control) this.txtProducerLocation).Location = new Point(178, 12);
    this.txtProducerLocation.MGAStyle = MGAStyles.Blue;
    this.txtProducerLocation.Multiline = true;
    ((Control) this.txtProducerLocation).Name = "txtProducerLocation";
    ((EditorButtonControlBase) this.txtProducerLocation).ReadOnly = true;
    ((Control) this.txtProducerLocation).Size = new Size(438, 92);
    ((Control) this.txtProducerLocation).TabIndex = 212;
    ((UltraControlBase) this.txtProducerLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducerLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(708, 470);
    this.Controls.Add((Control) this.txtProducerLocation);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) label12);
    this.Controls.Add((Control) this.cboPolicyType);
    this.Controls.Add((Control) label11);
    this.Controls.Add((Control) this.cboProgramCode);
    this.Controls.Add((Control) this.chkRenewal);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) this.dtDate);
    this.Controls.Add((Control) this.btnSearchCommissions);
    this.Controls.Add((Control) this.grpCommissionsResult);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) this.cboCompanyline);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.cboOfficeLocation);
    this.Controls.Add((Control) label2);
    this.Name = nameof (FormCommissionCheck);
    this.Text = "Commissions Check";
    this.Load += new EventHandler(this.FormCommissionCheck_Load);
    ((ISupportInitialize) this.grpCommissionsResult).EndInit();
    ((Control) this.grpCommissionsResult).ResumeLayout(false);
    ((Control) this.grpCommissionsResult).PerformLayout();
    ((ISupportInitialize) this.txtCarrierTermsOfPayment).EndInit();
    ((ISupportInitialize) this.txtProducerTermsOfPayment).EndInit();
    ((ISupportInitialize) this.txtCarrierCommission).EndInit();
    ((ISupportInitialize) this.txtProducerCommission).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnSearchCommissions).EndInit();
    ((ISupportInitialize) this.dtDate).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboProgramCode).EndInit();
    ((ISupportInitialize) this.cboCompanyline).EndInit();
    ((ISupportInitialize) this.cboOfficeLocation).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.txtProducerLocation).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
