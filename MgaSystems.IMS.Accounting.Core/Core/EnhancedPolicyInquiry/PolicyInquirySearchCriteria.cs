// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry.PolicyInquirySearchCriteria
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry;

public class PolicyInquirySearchCriteria : UserControl
{
  private IContainer components;
  protected Label label1;
  protected MGASimpleComboBox comboGLCompanyId;
  protected Label label3;
  protected MGATextBox textPolicyNumbers;
  protected MGADateTimePicker dateTimeEffectiveFrom;
  protected Label label4;
  protected MGADateTimePicker dateTimeEffectiveTo;
  protected Label label5;
  protected Label label6;
  protected MGADateTimePicker dateTimeInvoiceDueDateTo;
  protected Label label7;
  protected MGADateTimePicker dateTimeInvoiceDueDateFrom;
  protected MGATextBox textControlNumber;
  protected Label label9;
  protected MGASimpleComboBox comboLOB;
  protected Label label8;
  protected MGASimpleComboBox comboPolicystatus;
  protected Label label10;
  protected Label label11;
  protected MGATextBox textInvoiceNumber;
  protected MGAButton buttonExecuteSearch;
  protected MGATextBox textInsuredAddress;
  protected Label label12;
  protected Label label13;
  protected MGATextBox textInsuredZip;
  protected Label label14;
  protected MGATextBox textInsuredCity;
  protected MGASimpleComboBox comboStates;
  protected Label label15;
  protected ActiveEntitySearch activeEntitySearch1;
  protected Label label2;
  protected Label label16;
  protected MGADateTimePicker dateTimeExpirationTo;
  protected Label label17;
  protected MGADateTimePicker dateTimeExpirationFrom;

  public PolicyInquirySearchCriteria() => this.InitializeComponent();

  public int GLCompanyId
  {
    get
    {
      return ((UltraDropDownBase) this.comboGLCompanyId).SelectedRow != null ? (int) this.comboGLCompanyId.Value : -1;
    }
    set => this.comboGLCompanyId.Value = (object) value;
  }

  public string InsuredAddress
  {
    get => ((Control) this.textInsuredAddress).Text;
    set => ((Control) this.textInsuredAddress).Text = value;
  }

  public string InsuredCity
  {
    get => ((Control) this.textInsuredCity).Text;
    set => ((Control) this.textInsuredCity).Text = value;
  }

  public string InsuredState
  {
    get
    {
      return ((UltraDropDownBase) this.comboStates).SelectedRow == null ? string.Empty : this.comboStates.Value.ToString();
    }
    set => this.comboStates.Value = (object) value;
  }

  public string InsuredZip
  {
    get => ((Control) this.textInsuredZip).Text;
    set => ((Control) this.textInsuredZip).Text = value;
  }

  public Guid EntityGuid
  {
    get
    {
      return !this.activeEntitySearch1.EntitySelected ? Guid.Empty : this.activeEntitySearch1.EntityGuid;
    }
  }

  public string EntityType
  {
    get
    {
      return !this.activeEntitySearch1.EntitySelected ? string.Empty : this.activeEntitySearch1.EntityType;
    }
  }

  public string EntityName
  {
    get
    {
      return !this.activeEntitySearch1.EntitySelected ? string.Empty : this.activeEntitySearch1.EntityName;
    }
  }

  public string PolicyNumber
  {
    get => ((Control) this.textPolicyNumbers).Text;
    set => ((Control) this.textPolicyNumbers).Text = value;
  }

  public DateTime? EffectiveDateFrom
  {
    get
    {
      return this.dateTimeEffectiveFrom.Value == null ? new DateTime?() : new DateTime?(this.dateTimeEffectiveFrom.DateTime);
    }
    set => this.dateTimeEffectiveFrom.Value = (object) value;
  }

  public DateTime? EffectiveDateTo
  {
    get
    {
      return this.dateTimeEffectiveTo.Value == null ? new DateTime?() : new DateTime?(this.dateTimeEffectiveTo.DateTime);
    }
    set => this.dateTimeEffectiveTo.Value = (object) value;
  }

  public DateTime? ExpirationDateFrom
  {
    get
    {
      return this.dateTimeExpirationFrom.Value == null ? new DateTime?() : new DateTime?(this.dateTimeExpirationFrom.DateTime);
    }
    set => this.dateTimeExpirationFrom.Value = (object) value;
  }

  public DateTime? ExpirationDateTo
  {
    get
    {
      return this.dateTimeExpirationTo.Value == null ? new DateTime?() : new DateTime?(this.dateTimeExpirationTo.DateTime);
    }
    set => this.dateTimeExpirationTo.Value = (object) value;
  }

  public DateTime? InvoiceDueDateFrom
  {
    get
    {
      return this.dateTimeInvoiceDueDateFrom.Value == null ? new DateTime?() : new DateTime?(this.dateTimeInvoiceDueDateFrom.DateTime);
    }
    set => this.dateTimeInvoiceDueDateFrom.Value = (object) value;
  }

  public DateTime? InvoiceDueDateTo
  {
    get
    {
      return this.dateTimeInvoiceDueDateTo.Value == null ? new DateTime?() : new DateTime?(this.dateTimeInvoiceDueDateTo.DateTime);
    }
    set => this.dateTimeInvoiceDueDateTo.Value = (object) value;
  }

  public Guid LineGuid
  {
    get
    {
      return ((UltraDropDownBase) this.comboLOB).SelectedRow == null ? Guid.Empty : new Guid(this.comboLOB.Value.ToString());
    }
    set => this.comboLOB.Value = (object) value;
  }

  public int? InvoiceNumber
  {
    get
    {
      return string.IsNullOrEmpty(((Control) this.textInvoiceNumber).Text) ? new int?() : new int?(int.Parse(((Control) this.textInvoiceNumber).Text));
    }
    set
    {
      ((Control) this.textInvoiceNumber).Text = value.HasValue ? value.Value.ToString() : string.Empty;
    }
  }

  public int? ControlNumber
  {
    get
    {
      return string.IsNullOrEmpty(((Control) this.textControlNumber).Text) ? new int?() : new int?(int.Parse(((Control) this.textControlNumber).Text));
    }
    set
    {
      ((Control) this.textControlNumber).Text = value.HasValue ? value.Value.ToString() : string.Empty;
    }
  }

  public int? PolicyStatusId
  {
    get
    {
      return ((UltraDropDownBase) this.comboPolicystatus).SelectedRow == null ? new int?() : new int?(int.Parse(this.comboPolicystatus.Value.ToString()));
    }
    set => this.comboPolicystatus.Value = (object) value;
  }

  [Browsable(true)]
  public event EventHandler SearchButtonClicked;

  protected void OnSearchButtonClicked()
  {
    if (this.SearchButtonClicked == null)
      return;
    this.SearchButtonClicked((object) this, new EventArgs());
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboGLCompanyId).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboGLCompanyId).ValueMember = "ID";
    ((UltraDropDownBase) this.comboGLCompanyId).DisplayMember = "Office Location";
    this.comboGLCompanyId.Value = (object) CurrentUser.Instance.OfficeID;
  }

  private void LoadLines()
  {
    ((UltraGridBase) this.comboLOB).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetLines");
    ((UltraDropDownBase) this.comboLOB).DisplayMember = "LineName";
    ((UltraDropDownBase) this.comboLOB).ValueMember = "LineGuid";
  }

  private void LoadQuoteStatuses()
  {
    ((UltraGridBase) this.comboPolicystatus).DataSource = (object) DefaultDatabase.ExecuteDataTable("GetQuoteStatuses");
    ((UltraDropDownBase) this.comboPolicystatus).DisplayMember = "Description";
    ((UltraDropDownBase) this.comboPolicystatus).ValueMember = "QuoteStatusId";
  }

  private void LoadStates()
  {
    ((UltraGridBase) this.comboStates).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetUSStates");
    ((UltraDropDownBase) this.comboStates).DisplayMember = "State";
    ((UltraDropDownBase) this.comboStates).ValueMember = "StateId";
  }

  private void PolicyInquirySearchCriteria_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.InitializeSearchControl();
  }

  private void InitializeSearchControl()
  {
    this.dateTimeEffectiveFrom.Value = (object) null;
    this.dateTimeEffectiveTo.Value = (object) null;
    this.dateTimeExpirationFrom.Value = (object) null;
    this.dateTimeExpirationTo.Value = (object) null;
    this.dateTimeInvoiceDueDateFrom.Value = (object) null;
    this.dateTimeInvoiceDueDateTo.Value = (object) null;
    this.LoadOfficeLocations();
    this.LoadLines();
    this.LoadQuoteStatuses();
    this.LoadStates();
  }

  private void buttonExecuteSearch_Click(object sender, EventArgs e)
  {
    this.OnSearchButtonClicked();
  }

  public virtual void Clear()
  {
    this.InitializeSearchControl();
    this.activeEntitySearch1.Clear();
    ((Control) this.textPolicyNumbers).Text = string.Empty;
    ((Control) this.textInsuredAddress).Text = string.Empty;
    ((Control) this.textInsuredCity).Text = string.Empty;
    ((Control) this.textInsuredZip).Text = string.Empty;
    ((Control) this.textInvoiceNumber).Text = string.Empty;
    this.dateTimeEffectiveFrom.Value = (object) null;
    this.dateTimeEffectiveTo.Value = (object) null;
    this.dateTimeExpirationFrom.Value = (object) null;
    this.dateTimeExpirationTo.Value = (object) null;
    this.dateTimeInvoiceDueDateFrom.Value = (object) null;
    this.dateTimeInvoiceDueDateTo.Value = (object) null;
  }

  public void SetSelectedEntity(Guid entityGuid, string entityName)
  {
    this.activeEntitySearch1.SetSelectedEntity(entityGuid, entityName);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PolicyInquirySearchCriteria));
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
    this.label1 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label9 = new Label();
    this.label8 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.label14 = new Label();
    this.label15 = new Label();
    this.label2 = new Label();
    this.label16 = new Label();
    this.label17 = new Label();
    this.dateTimeExpirationTo = new MGADateTimePicker();
    this.dateTimeExpirationFrom = new MGADateTimePicker();
    this.comboGLCompanyId = new MGASimpleComboBox();
    this.comboStates = new MGASimpleComboBox();
    this.textInsuredCity = new MGATextBox();
    this.textInsuredZip = new MGATextBox();
    this.textInsuredAddress = new MGATextBox();
    this.textInvoiceNumber = new MGATextBox();
    this.comboPolicystatus = new MGASimpleComboBox();
    this.comboLOB = new MGASimpleComboBox();
    this.buttonExecuteSearch = new MGAButton();
    this.textControlNumber = new MGATextBox();
    this.dateTimeInvoiceDueDateTo = new MGADateTimePicker();
    this.dateTimeInvoiceDueDateFrom = new MGADateTimePicker();
    this.dateTimeEffectiveTo = new MGADateTimePicker();
    this.dateTimeEffectiveFrom = new MGADateTimePicker();
    this.textPolicyNumbers = new MGATextBox();
    this.activeEntitySearch1 = new ActiveEntitySearch();
    ((ISupportInitialize) this.dateTimeExpirationTo).BeginInit();
    ((ISupportInitialize) this.dateTimeExpirationFrom).BeginInit();
    ((ISupportInitialize) this.comboGLCompanyId).BeginInit();
    ((ISupportInitialize) this.comboStates).BeginInit();
    ((ISupportInitialize) this.textInsuredCity).BeginInit();
    ((ISupportInitialize) this.textInsuredZip).BeginInit();
    ((ISupportInitialize) this.textInsuredAddress).BeginInit();
    ((ISupportInitialize) this.textInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.comboPolicystatus).BeginInit();
    ((ISupportInitialize) this.comboLOB).BeginInit();
    ((ISupportInitialize) this.buttonExecuteSearch).BeginInit();
    ((ISupportInitialize) this.textControlNumber).BeginInit();
    ((ISupportInitialize) this.dateTimeInvoiceDueDateTo).BeginInit();
    ((ISupportInitialize) this.dateTimeInvoiceDueDateFrom).BeginInit();
    ((ISupportInitialize) this.dateTimeEffectiveTo).BeginInit();
    ((ISupportInitialize) this.dateTimeEffectiveFrom).BeginInit();
    ((ISupportInitialize) this.textPolicyNumbers).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Location = new Point(3, 5);
    this.label1.Name = "label1";
    this.label1.Size = new Size(71, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "GL Company:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 48 /*0x30*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(78, 13);
    this.label3.TabIndex = 4;
    this.label3.Text = "Policy Number:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(344, 49);
    this.label4.Name = "label4";
    this.label4.Size = new Size(80 /*0x50*/, 13);
    this.label4.TabIndex = 14;
    this.label4.Text = "Effective Date:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(530, 53);
    this.label5.Name = "label5";
    this.label5.Size = new Size(17, 13);
    this.label5.TabIndex = 16 /*0x10*/;
    this.label5.Text = "to";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(530, 95);
    this.label6.Name = "label6";
    this.label6.Size = new Size(17, 13);
    this.label6.TabIndex = 24;
    this.label6.Text = "to";
    this.label7.AutoSize = true;
    this.label7.Location = new Point(344, 92);
    this.label7.Name = "label7";
    this.label7.Size = new Size(94, 13);
    this.label7.TabIndex = 22;
    this.label7.Text = "Invoice Due Date:";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(3, 94);
    this.label9.Name = "label9";
    this.label9.Size = new Size(57, 13);
    this.label9.TabIndex = 8;
    this.label9.Text = "Control #:";
    this.label8.AutoSize = true;
    this.label8.Location = new Point(344, 3);
    this.label8.Name = "label8";
    this.label8.Size = new Size(30, 13);
    this.label8.TabIndex = 10;
    this.label8.Text = "Line:";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(344, 27);
    this.label10.Name = "label10";
    this.label10.Size = new Size(72, 13);
    this.label10.TabIndex = 12;
    this.label10.Text = "Policy Status:";
    this.label11.AutoSize = true;
    this.label11.Location = new Point(3, 70);
    this.label11.Name = "label11";
    this.label11.Size = new Size(57, 13);
    this.label11.TabIndex = 6;
    this.label11.Text = "Invoice #:";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(649, 5);
    this.label12.Name = "label12";
    this.label12.Size = new Size(90, 13);
    this.label12.TabIndex = 26;
    this.label12.Text = "Insured Address:";
    this.label13.AutoSize = true;
    this.label13.Location = new Point(649, 70);
    this.label13.Name = "label13";
    this.label13.Size = new Size(65, 13);
    this.label13.TabIndex = 32 /*0x20*/;
    this.label13.Text = "Insured Zip:";
    this.label14.AutoSize = true;
    this.label14.Location = new Point(649, 27);
    this.label14.Name = "label14";
    this.label14.Size = new Size(70, 13);
    this.label14.TabIndex = 28;
    this.label14.Text = "Insured City:";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(649, 48 /*0x30*/);
    this.label15.Name = "label15";
    this.label15.Size = new Size(77, 13);
    this.label15.TabIndex = 30;
    this.label15.Text = "Insured State:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 27);
    this.label2.Name = "label2";
    this.label2.Size = new Size(39, 13);
    this.label2.TabIndex = 2;
    this.label2.Text = "Entity:";
    this.label16.AutoSize = true;
    this.label16.Location = new Point(530, 74);
    this.label16.Name = "label16";
    this.label16.Size = new Size(17, 13);
    this.label16.TabIndex = 20;
    this.label16.Text = "to";
    this.label17.AutoSize = true;
    this.label17.Location = new Point(344, 70);
    this.label17.Name = "label17";
    this.label17.Size = new Size(85, 13);
    this.label17.TabIndex = 18;
    this.label17.Text = "Expiration Date:";
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeExpirationTo.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dateTimeExpirationTo.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateTimeExpirationTo).Location = new Point(547, 72);
    this.dateTimeExpirationTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeExpirationTo).Name = "dateTimeExpirationTo";
    ((Control) this.dateTimeExpirationTo).Size = new Size(85, 20);
    ((Control) this.dateTimeExpirationTo).TabIndex = 21;
    ((UltraControlBase) this.dateTimeExpirationTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeExpirationTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeExpirationTo.Value = (object) null;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeExpirationFrom.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.dateTimeExpirationFrom.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateTimeExpirationFrom).Location = new Point(441, 71);
    this.dateTimeExpirationFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeExpirationFrom).Name = "dateTimeExpirationFrom";
    ((Control) this.dateTimeExpirationFrom).Size = new Size(85, 20);
    ((Control) this.dateTimeExpirationFrom).TabIndex = 19;
    ((UltraControlBase) this.dateTimeExpirationFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeExpirationFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeExpirationFrom.Value = (object) null;
    this.comboGLCompanyId.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompanyId.CharacterCasing = CharacterCasing.Normal;
    this.comboGLCompanyId.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompanyId).Location = new Point(97, 4);
    this.comboGLCompanyId.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompanyId).Name = "comboGLCompanyId";
    ((Control) this.comboGLCompanyId).Size = new Size(221, 21);
    ((Control) this.comboGLCompanyId).TabIndex = 1;
    ((UltraControlBase) this.comboGLCompanyId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompanyId).UseOsThemes = (DefaultableBoolean) 2;
    this.comboStates.BorderStyle = (UIElementBorderStyle) 4;
    this.comboStates.CharacterCasing = CharacterCasing.Normal;
    this.comboStates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboStates).Location = new Point(745, 48 /*0x30*/);
    this.comboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboStates).Name = "comboStates";
    ((Control) this.comboStates).Size = new Size(164, 21);
    ((Control) this.comboStates).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.comboStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboStates).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInsuredCity).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textInsuredCity).BackColor = Color.White;
    ((Control) this.textInsuredCity).Location = new Point(745, 27);
    this.textInsuredCity.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInsuredCity).Name = "textInsuredCity";
    ((Control) this.textInsuredCity).Size = new Size(202, 20);
    ((Control) this.textInsuredCity).TabIndex = 29;
    ((UltraControlBase) this.textInsuredCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInsuredCity).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInsuredZip).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textInsuredZip).BackColor = Color.White;
    ((Control) this.textInsuredZip).Location = new Point(745, 70);
    this.textInsuredZip.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInsuredZip).Name = "textInsuredZip";
    ((Control) this.textInsuredZip).Size = new Size(60, 20);
    ((Control) this.textInsuredZip).TabIndex = 33;
    ((UltraControlBase) this.textInsuredZip).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInsuredZip).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInsuredAddress).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textInsuredAddress).BackColor = Color.White;
    ((Control) this.textInsuredAddress).Location = new Point(745, 5);
    this.textInsuredAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInsuredAddress).Name = "textInsuredAddress";
    ((Control) this.textInsuredAddress).Size = new Size(202, 20);
    ((Control) this.textInsuredAddress).TabIndex = 27;
    ((UltraControlBase) this.textInsuredAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInsuredAddress).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInvoiceNumber).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textInvoiceNumber).BackColor = Color.White;
    ((Control) this.textInvoiceNumber).Location = new Point(97, 72);
    this.textInvoiceNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInvoiceNumber).Name = "textInvoiceNumber";
    ((Control) this.textInvoiceNumber).Size = new Size(76, 20);
    ((Control) this.textInvoiceNumber).TabIndex = 7;
    ((UltraControlBase) this.textInvoiceNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInvoiceNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.comboPolicystatus.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPolicystatus.CharacterCasing = CharacterCasing.Normal;
    this.comboPolicystatus.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPolicystatus).Location = new Point(441, 27);
    this.comboPolicystatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPolicystatus).Name = "comboPolicystatus";
    ((Control) this.comboPolicystatus).Size = new Size(191, 21);
    ((Control) this.comboPolicystatus).TabIndex = 13;
    ((UltraControlBase) this.comboPolicystatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPolicystatus).UseOsThemes = (DefaultableBoolean) 2;
    this.comboLOB.BorderStyle = (UIElementBorderStyle) 4;
    this.comboLOB.CharacterCasing = CharacterCasing.Normal;
    this.comboLOB.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboLOB).Location = new Point(441, 3);
    this.comboLOB.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboLOB).Name = "comboLOB";
    ((Control) this.comboLOB).Size = new Size(191, 21);
    ((Control) this.comboLOB).TabIndex = 11;
    ((UltraControlBase) this.comboLOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboLOB).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance9).Image = componentResourceManager.GetObject("appearance15.Image");
    ((AppearanceBase) appearance9).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance9).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonExecuteSearch).Appearance = (AppearanceBase) appearance9;
    ((Control) this.buttonExecuteSearch).Location = new Point(863, 82);
    ((Control) this.buttonExecuteSearch).Name = "buttonExecuteSearch";
    ((Control) this.buttonExecuteSearch).Size = new Size(84, 25);
    ((Control) this.buttonExecuteSearch).TabIndex = 34;
    ((Control) this.buttonExecuteSearch).Text = "Search";
    ((UltraControlBase) this.buttonExecuteSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonExecuteSearch).Click += new EventHandler(this.buttonExecuteSearch_Click);
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textControlNumber).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textControlNumber).BackColor = Color.White;
    ((Control) this.textControlNumber).Location = new Point(97, 94);
    this.textControlNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textControlNumber).Name = "textControlNumber";
    ((Control) this.textControlNumber).Size = new Size(76, 20);
    ((Control) this.textControlNumber).TabIndex = 9;
    ((UltraControlBase) this.textControlNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textControlNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeInvoiceDueDateTo.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance12).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance12).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance12).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance12).ForegroundAlpha = (Alpha) 2;
    this.dateTimeInvoiceDueDateTo.ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dateTimeInvoiceDueDateTo).Location = new Point(547, 93);
    this.dateTimeInvoiceDueDateTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeInvoiceDueDateTo).Name = "dateTimeInvoiceDueDateTo";
    ((Control) this.dateTimeInvoiceDueDateTo).Size = new Size(85, 20);
    ((Control) this.dateTimeInvoiceDueDateTo).TabIndex = 25;
    ((UltraControlBase) this.dateTimeInvoiceDueDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeInvoiceDueDateTo).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeInvoiceDueDateFrom.Appearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance14).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance14).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance14).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance14).ForegroundAlpha = (Alpha) 2;
    this.dateTimeInvoiceDueDateFrom.ButtonAppearance = (AppearanceBase) appearance14;
    ((Control) this.dateTimeInvoiceDueDateFrom).Location = new Point(441, 92);
    this.dateTimeInvoiceDueDateFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeInvoiceDueDateFrom).Name = "dateTimeInvoiceDueDateFrom";
    ((Control) this.dateTimeInvoiceDueDateFrom).Size = new Size(85, 20);
    ((Control) this.dateTimeInvoiceDueDateFrom).TabIndex = 23;
    ((UltraControlBase) this.dateTimeInvoiceDueDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeInvoiceDueDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeEffectiveTo.Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance16).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance16).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance16).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance16).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance16).ForegroundAlpha = (Alpha) 2;
    this.dateTimeEffectiveTo.ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dateTimeEffectiveTo).Location = new Point(547, 51);
    this.dateTimeEffectiveTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeEffectiveTo).Name = "dateTimeEffectiveTo";
    ((Control) this.dateTimeEffectiveTo).Size = new Size(85, 20);
    ((Control) this.dateTimeEffectiveTo).TabIndex = 17;
    ((UltraControlBase) this.dateTimeEffectiveTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeEffectiveTo).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeEffectiveFrom.Appearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance18).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance18).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance18).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance18).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance18).ForegroundAlpha = (Alpha) 2;
    this.dateTimeEffectiveFrom.ButtonAppearance = (AppearanceBase) appearance18;
    ((Control) this.dateTimeEffectiveFrom).Location = new Point(441, 50);
    this.dateTimeEffectiveFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeEffectiveFrom).Name = "dateTimeEffectiveFrom";
    ((Control) this.dateTimeEffectiveFrom).Size = new Size(85, 20);
    ((Control) this.dateTimeEffectiveFrom).TabIndex = 15;
    ((UltraControlBase) this.dateTimeEffectiveFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeEffectiveFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPolicyNumbers).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textPolicyNumbers).BackColor = Color.White;
    ((Control) this.textPolicyNumbers).Location = new Point(97, 51);
    this.textPolicyNumbers.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPolicyNumbers).Name = "textPolicyNumbers";
    ((Control) this.textPolicyNumbers).Size = new Size(221, 20);
    ((Control) this.textPolicyNumbers).TabIndex = 5;
    ((UltraControlBase) this.textPolicyNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPolicyNumbers).UseOsThemes = (DefaultableBoolean) 2;
    this.activeEntitySearch1.BackColor = Color.Transparent;
    this.activeEntitySearch1.Location = new Point(97, 28);
    this.activeEntitySearch1.Name = "activeEntitySearch1";
    this.activeEntitySearch1.Size = new Size(223, 20);
    this.activeEntitySearch1.TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.label16);
    this.Controls.Add((Control) this.dateTimeExpirationTo);
    this.Controls.Add((Control) this.label17);
    this.Controls.Add((Control) this.dateTimeExpirationFrom);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.comboGLCompanyId);
    this.Controls.Add((Control) this.comboStates);
    this.Controls.Add((Control) this.label15);
    this.Controls.Add((Control) this.label14);
    this.Controls.Add((Control) this.textInsuredCity);
    this.Controls.Add((Control) this.label13);
    this.Controls.Add((Control) this.textInsuredZip);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.textInsuredAddress);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.textInvoiceNumber);
    this.Controls.Add((Control) this.comboPolicystatus);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.comboLOB);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.buttonExecuteSearch);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.textControlNumber);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.dateTimeInvoiceDueDateTo);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.dateTimeInvoiceDueDateFrom);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.dateTimeEffectiveTo);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.dateTimeEffectiveFrom);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.textPolicyNumbers);
    this.Controls.Add((Control) this.activeEntitySearch1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (PolicyInquirySearchCriteria);
    this.Size = new Size(951, 122);
    this.Load += new EventHandler(this.PolicyInquirySearchCriteria_Load);
    ((ISupportInitialize) this.dateTimeExpirationTo).EndInit();
    ((ISupportInitialize) this.dateTimeExpirationFrom).EndInit();
    ((ISupportInitialize) this.comboGLCompanyId).EndInit();
    ((ISupportInitialize) this.comboStates).EndInit();
    ((ISupportInitialize) this.textInsuredCity).EndInit();
    ((ISupportInitialize) this.textInsuredZip).EndInit();
    ((ISupportInitialize) this.textInsuredAddress).EndInit();
    ((ISupportInitialize) this.textInvoiceNumber).EndInit();
    ((ISupportInitialize) this.comboPolicystatus).EndInit();
    ((ISupportInitialize) this.comboLOB).EndInit();
    ((ISupportInitialize) this.buttonExecuteSearch).EndInit();
    ((ISupportInitialize) this.textControlNumber).EndInit();
    ((ISupportInitialize) this.dateTimeInvoiceDueDateTo).EndInit();
    ((ISupportInitialize) this.dateTimeInvoiceDueDateFrom).EndInit();
    ((ISupportInitialize) this.dateTimeEffectiveTo).EndInit();
    ((ISupportInitialize) this.dateTimeEffectiveFrom).EndInit();
    ((ISupportInitialize) this.textPolicyNumbers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
