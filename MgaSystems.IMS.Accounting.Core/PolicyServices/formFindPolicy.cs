// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.PolicyServices.formFindPolicy
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.PolicyServices;

public class formFindPolicy : FormBase
{
  internal SqlCommand SqlSelectCommand1;
  internal SqlConnection FormDataConnection;
  internal Label Label3;
  internal SqlDataAdapter daGetOfficeLocations;
  protected RadioButton optInsuredName;
  internal SqlDataAdapter SqlDataAdapter1;
  internal SqlCommand SqlDeleteCommand1;
  internal SqlCommand SqlInsertCommand1;
  internal SqlCommand SqlSelectCommand2;
  internal SqlCommand SqlUpdateCommand1;
  internal Label Label1;
  internal Label Label2;
  internal ToolTip ToolTip1;
  protected MGAButton btnSearch;
  protected MGAButton btnCancel;
  protected MGAButton btnOK;
  protected RadioButton optControlNumber;
  protected RadioButton optInvoiceNumber;
  protected RadioButton optPolicyNumber;
  internal ImageList ImageList1;
  protected UltraGrid gridPolicies;
  protected MGATextBox txtSearchFor;
  protected dsFindPolicy dsFindPolicy1;
  private dsOfficeLocations dsOfficeLocations1;
  protected EllipsePanel ellipsePanel1;
  protected MGASimpleComboBox cmbOfficeLocation;
  private IContainer components;
  private int quoteControlNumber;
  private int glCompanyId;
  private formFindPolicy.SearchByEnum SearchBy;

  public formFindPolicy()
  {
    this.InitializeComponent();
    if (this.DesignMode)
      return;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.FillOfficeLocationCombo();
    this.SearchBy = formFindPolicy.SearchByEnum.PolicyNumber;
  }

  internal int QuoteControlNumber => this.quoteControlNumber;

  internal int GLCompanyID => this.glCompanyId;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formFindPolicy));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("FindPolicy", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Producer");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ControlNumber");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.Label3 = new Label();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.optInsuredName = new RadioButton();
    this.SqlDataAdapter1 = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.ToolTip1 = new ToolTip(this.components);
    this.btnSearch = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.optControlNumber = new RadioButton();
    this.optInvoiceNumber = new RadioButton();
    this.optPolicyNumber = new RadioButton();
    this.ImageList1 = new ImageList(this.components);
    this.txtSearchFor = new MGATextBox();
    this.ellipsePanel1 = new EllipsePanel();
    this.cmbOfficeLocation = new MGASimpleComboBox();
    this.gridPolicies = new UltraGrid();
    this.dsFindPolicy1 = new dsFindPolicy();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.txtSearchFor).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.cmbOfficeLocation).BeginInit();
    ((ISupportInitialize) this.gridPolicies).BeginInit();
    this.dsFindPolicy1.BeginInit();
    this.dsOfficeLocations1.BeginInit();
    this.SuspendLayout();
    this.SqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.FromArgb(239, 247, 253);
    this.Label3.Location = new Point(16 /*0x10*/, 72);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(63 /*0x3F*/, 13);
    this.Label3.TabIndex = 20;
    this.Label3.Text = "Search For:";
    this.daGetOfficeLocations.SelectCommand = this.SqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.optInsuredName.BackColor = Color.FromArgb(239, 247, 253);
    this.optInsuredName.FlatStyle = FlatStyle.Flat;
    this.optInsuredName.Location = new Point(440, 48 /*0x30*/);
    this.optInsuredName.Name = "optInsuredName";
    this.optInsuredName.Size = new Size(104, 16 /*0x10*/);
    this.optInsuredName.TabIndex = 19;
    this.optInsuredName.Tag = (object) "4";
    this.optInsuredName.Text = "Insured &Name";
    this.optInsuredName.UseVisualStyleBackColor = false;
    this.optInsuredName.CheckedChanged += new EventHandler(this.OptionsChanged);
    this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
    this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand1;
    this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand2;
    this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.FromArgb(239, 247, 253);
    this.Label1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(83, 13);
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Office Location:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.FromArgb(239, 247, 253);
    this.Label2.Location = new Point(16 /*0x10*/, 40);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(59, 13);
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Search By:";
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance1.Image");
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(789, 50);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 22;
    this.ToolTip1.SetToolTip((Control) this.btnSearch, "Click here to search for policies that match your selection criteria.");
    ((UltraControlBase) this.btnSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Click += new EventHandler(this.btnSearch_Click);
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(733, 353);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.btnCancel).TabIndex = 25;
    ((Control) this.btnCancel).Text = "Cancel";
    this.ToolTip1.SetToolTip((Control) this.btnCancel, "Click here to cancel your search.");
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnOK).Location = new Point(613, 353);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(112 /*0x70*/, 23);
    ((Control) this.btnOK).TabIndex = 24;
    ((Control) this.btnOK).Text = "Show Policy";
    this.ToolTip1.SetToolTip((Control) this.btnOK, "Click here to show the selected policy.");
    ((UltraControlBase) this.btnOK).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Click += new EventHandler(this.btnOK_Click);
    this.optControlNumber.BackColor = Color.FromArgb(239, 247, 253);
    this.optControlNumber.FlatStyle = FlatStyle.Flat;
    this.optControlNumber.Location = new Point(328, 48 /*0x30*/);
    this.optControlNumber.Name = "optControlNumber";
    this.optControlNumber.Size = new Size(104, 16 /*0x10*/);
    this.optControlNumber.TabIndex = 18;
    this.optControlNumber.Tag = (object) "3";
    this.optControlNumber.Text = "&Control Number";
    this.optControlNumber.UseVisualStyleBackColor = false;
    this.optControlNumber.CheckedChanged += new EventHandler(this.OptionsChanged);
    this.optInvoiceNumber.BackColor = Color.FromArgb(239, 247, 253);
    this.optInvoiceNumber.FlatStyle = FlatStyle.Flat;
    this.optInvoiceNumber.Location = new Point(216, 48 /*0x30*/);
    this.optInvoiceNumber.Name = "optInvoiceNumber";
    this.optInvoiceNumber.Size = new Size(104, 16 /*0x10*/);
    this.optInvoiceNumber.TabIndex = 17;
    this.optInvoiceNumber.Tag = (object) "2";
    this.optInvoiceNumber.Text = "&Invoice Number";
    this.optInvoiceNumber.UseVisualStyleBackColor = false;
    this.optInvoiceNumber.CheckedChanged += new EventHandler(this.OptionsChanged);
    this.optPolicyNumber.BackColor = Color.FromArgb(239, 247, 253);
    this.optPolicyNumber.Checked = true;
    this.optPolicyNumber.FlatStyle = FlatStyle.Flat;
    this.optPolicyNumber.Location = new Point(112 /*0x70*/, 48 /*0x30*/);
    this.optPolicyNumber.Name = "optPolicyNumber";
    this.optPolicyNumber.Size = new Size(104, 16 /*0x10*/);
    this.optPolicyNumber.TabIndex = 16 /*0x10*/;
    this.optPolicyNumber.TabStop = true;
    this.optPolicyNumber.Tag = (object) "1";
    this.optPolicyNumber.Text = "&Policy Number";
    this.optPolicyNumber.UseVisualStyleBackColor = false;
    this.optPolicyNumber.CheckedChanged += new EventHandler(this.OptionsChanged);
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSearchFor).Appearance = (AppearanceBase) appearance4;
    ((Control) this.txtSearchFor).BackColor = Color.White;
    ((Control) this.txtSearchFor).Location = new Point(112 /*0x70*/, 72);
    this.txtSearchFor.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSearchFor).Name = "txtSearchFor";
    ((Control) this.txtSearchFor).Size = new Size(679, 20);
    ((Control) this.txtSearchFor).TabIndex = 21;
    ((UltraControlBase) this.txtSearchFor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSearchFor).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtSearchFor).KeyDown += new KeyEventHandler(this.txtSearchFor_KeyDown);
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.btnCancel);
    this.ellipsePanel1.Controls.Add((Control) this.btnOK);
    this.ellipsePanel1.Controls.Add((Control) this.cmbOfficeLocation);
    this.ellipsePanel1.Controls.Add((Control) this.btnSearch);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(838, 388);
    this.ellipsePanel1.TabIndex = 26;
    this.cmbOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocation).Location = new Point(104, 8);
    this.cmbOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocation).Name = "cmbOfficeLocation";
    ((Control) this.cmbOfficeLocation).Size = new Size(408, 21);
    ((Control) this.cmbOfficeLocation).TabIndex = 0;
    ((UltraControlBase) this.cmbOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridPolicies).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridPolicies).DataMember = "FindPolicy";
    ((UltraGridBase) this.gridPolicies).DataSource = (object) this.dsFindPolicy1;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 144 /*0x90*/;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 136;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Effective Date";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 140;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Expiration Date";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 139;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 140;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 120;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.gridPolicies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPolicies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridPolicies).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridPolicies).Location = new Point(16 /*0x10*/, 104);
    ((Control) this.gridPolicies).Name = "gridPolicies";
    ((Control) this.gridPolicies).Size = new Size(821, 251);
    ((Control) this.gridPolicies).TabIndex = 23;
    ((UltraControlBase) this.gridPolicies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPolicies).UseOsThemes = (DefaultableBoolean) 2;
    this.gridPolicies.DoubleClickRow += new DoubleClickRowEventHandler(this.gridPolicies_DoubleClickRow);
    this.dsFindPolicy1.DataSetName = "dsFindPolicy";
    this.dsFindPolicy1.Locale = new CultureInfo("en-US");
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(856, 403);
    this.Controls.Add((Control) this.optControlNumber);
    this.Controls.Add((Control) this.optInvoiceNumber);
    this.Controls.Add((Control) this.optPolicyNumber);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.gridPolicies);
    this.Controls.Add((Control) this.txtSearchFor);
    this.Controls.Add((Control) this.optInsuredName);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formFindPolicy);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Find Policy";
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.txtSearchFor).EndInit();
    this.ellipsePanel1.ResumeLayout(false);
    this.ellipsePanel1.PerformLayout();
    ((ISupportInitialize) this.cmbOfficeLocation).EndInit();
    ((ISupportInitialize) this.gridPolicies).EndInit();
    this.dsFindPolicy1.EndInit();
    this.dsOfficeLocations1.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual void FillOfficeLocationCombo()
  {
    ((UltraGridBase) this.cmbOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset(true);
    ((UltraDropDownBase) this.cmbOfficeLocation).ValueMember = "ID";
    ((UltraDropDownBase) this.cmbOfficeLocation).DisplayMember = "Office Location";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.cmbOfficeLocation).Rows).Count == 0)
      return;
    ((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow = ((UltraGridBase) this.cmbOfficeLocation).Rows[0];
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    if (((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.glCompanyId = int.Parse(((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow.Cells["ID"].Value.ToString());
      if (this.SearchBy == formFindPolicy.SearchByEnum.None)
      {
        int num2 = (int) MessageBox.Show("You must select a field to search by to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (this.SearchBy == formFindPolicy.SearchByEnum.PolicyNumber && string.IsNullOrEmpty(((Control) this.txtSearchFor).Text))
      {
        int num3 = (int) MessageBox.Show("You must enter a policy to search for.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.FindPolicy((int) this.SearchBy, ((Control) this.txtSearchFor).Text, int.Parse(((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow.Cells["ID"].Value.ToString()));
        this.AcceptButton = (IButtonControl) this.btnOK;
        ((Control) this.btnOK).Focus();
      }
    }
  }

  protected bool ValidateForm()
  {
    if (!this.optControlNumber.Checked && !this.optInvoiceNumber.Checked || Utility.IsNumericValue((object) ((Control) this.txtSearchFor).Text))
      return true;
    int num = (int) MessageBox.Show("You have selected a search criteria that requires that you search by a numeric value only.", "Invalid Search Criteria!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual void FindPolicy(int SearchBy, string SearchFor, int GLCompanyID)
  {
    if (!this.ValidateForm())
      return;
    this.Cursor = Cursors.WaitCursor;
    try
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_FindPolicy", new SqlConnection(CurrentUser.Instance.ConnectionString)))
      {
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.Parameters.AddWithValue("@glCompanyId", (object) GLCompanyID);
        selectCommand.Parameters.AddWithValue("@searchType", (object) SearchBy);
        selectCommand.Parameters.AddWithValue("@searchValue", (object) SearchFor);
        this.dsFindPolicy1.FindPolicy.Clear();
        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
        sqlDataAdapter.Fill((DataTable) this.dsFindPolicy1.FindPolicy);
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void CommitSelection()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPolicies).Rows)
    {
      if (((GridItemBase) row).Selected)
      {
        this.quoteControlNumber = int.Parse(row.Cells["ControlNumber"].Value.ToString());
        this.DialogResult = DialogResult.OK;
        this.Close();
        break;
      }
    }
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridPolicies).Rows).Count == 0)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPolicies).Rows)
    {
      if (((GridItemBase) row).Selected)
      {
        this.quoteControlNumber = int.Parse(row.Cells["ControlNumber"].Value.ToString());
        this.DialogResult = DialogResult.OK;
        this.Close();
        return;
      }
    }
    this.quoteControlNumber = int.Parse(((UltraGridBase) this.gridPolicies).Rows[0].Cells["ControlNumber"].Value.ToString());
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void OptionsChanged(object sender, EventArgs e)
  {
    if (this.optPolicyNumber.Checked)
    {
      this.optControlNumber.Checked = false;
      this.optInsuredName.Checked = false;
      this.optInvoiceNumber.Checked = false;
      this.SearchBy = formFindPolicy.SearchByEnum.PolicyNumber;
      ((TextEditorControlBase) this.txtSearchFor).Focus();
    }
    else if (this.optInvoiceNumber.Checked)
    {
      this.optControlNumber.Checked = false;
      this.optInsuredName.Checked = false;
      this.optPolicyNumber.Checked = false;
      this.SearchBy = formFindPolicy.SearchByEnum.InvoiceNumber;
      ((TextEditorControlBase) this.txtSearchFor).Focus();
    }
    else if (this.optControlNumber.Checked)
    {
      this.optPolicyNumber.Checked = false;
      this.optInsuredName.Checked = false;
      this.optInvoiceNumber.Checked = false;
      this.SearchBy = formFindPolicy.SearchByEnum.ControlNumber;
      ((TextEditorControlBase) this.txtSearchFor).Focus();
    }
    else
    {
      if (!this.optInsuredName.Checked)
        return;
      this.optControlNumber.Checked = false;
      this.optPolicyNumber.Checked = false;
      this.optInvoiceNumber.Checked = false;
      this.SearchBy = formFindPolicy.SearchByEnum.InsuredName;
      ((TextEditorControlBase) this.txtSearchFor).Focus();
    }
  }

  private void txtSearchFor_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.glCompanyId = int.Parse(((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow.Cells["ID"].Value.ToString());
      if (this.SearchBy == formFindPolicy.SearchByEnum.None)
      {
        int num2 = (int) MessageBox.Show("You must select a field to search by to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.FindPolicy((int) this.SearchBy, ((Control) this.txtSearchFor).Text, int.Parse(((UltraDropDownBase) this.cmbOfficeLocation).SelectedRow.Cells["ID"].Value.ToString()));
        this.AcceptButton = (IButtonControl) this.btnOK;
        ((Control) this.btnOK).Focus();
      }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridPolicies_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridPolicies).Rows).Count == 0 || ((SparseCollectionBase) this.gridPolicies.Selected.Rows).Count == 0 || this.gridPolicies.Selected.Rows[0] == null)
      return;
    this.quoteControlNumber = int.Parse(this.gridPolicies.Selected.Rows[0].Cells["ControlNumber"].Value.ToString());
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private enum SearchByEnum
  {
    None,
    PolicyNumber,
    InvoiceNumber,
    ControlNumber,
    InsuredName,
  }
}
