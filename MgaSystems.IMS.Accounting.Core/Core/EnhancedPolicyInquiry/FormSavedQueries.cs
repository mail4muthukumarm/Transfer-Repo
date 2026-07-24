// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry.FormSavedQueries
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinListView;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry;

public class FormSavedQueries : FormBase
{
  private IContainer components;
  private UltraListView ultraListView1;
  private Panel panel1;
  private MGATextBox textQueryName;
  private Label label1;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;

  public int GLCompanyId { get; private set; }

  public string InsuredAddress { get; private set; }

  public string InsuredCity { get; private set; }

  public string InsuredState { get; private set; }

  public string InsuredZip { get; private set; }

  public Guid EntityGuid { get; private set; }

  public string EntityName { get; private set; }

  public string PolicyNumber { get; private set; }

  public DateTime? EffectiveDateFrom { get; private set; }

  public DateTime? EffectiveDateTo { get; private set; }

  public DateTime? ExpirationDateFrom { get; private set; }

  public DateTime? ExpirationDateTo { get; private set; }

  public DateTime? InvoiceDueDateFrom { get; private set; }

  public DateTime? InvoiceDueDateTo { get; private set; }

  public Guid LineGuid { get; private set; }

  public int? InvoiceNumber { get; private set; }

  public int? ControlNumber { get; private set; }

  public int? PolicyStatusId { get; private set; }

  public FormSavedQueries()
  {
    this.InitializeComponent();
    ((Control) this.buttonSave).Text = "Load";
  }

  public FormSavedQueries(
    int glCompanyId,
    string insuredAddress,
    string insuredCity,
    string insuredState,
    string insuredZip,
    Guid entityGuid,
    string entityName,
    string policyNumber,
    DateTime? effectiveDateFrom,
    DateTime? effectiveDateTo,
    DateTime? expirationDateFrom,
    DateTime? expirationDateTo,
    DateTime? invoiceDueDateFrom,
    DateTime? invoiceDueDateTo,
    Guid lineGuid,
    int? invoiceNumber,
    int? controlNumber,
    int? policyStatusId)
  {
    this.InitializeComponent();
    this.GLCompanyId = glCompanyId;
    this.InsuredAddress = insuredAddress;
    this.InsuredCity = insuredCity;
    this.InsuredState = insuredState;
    this.InsuredZip = insuredZip;
    this.EntityGuid = entityGuid;
    this.EntityName = entityName;
    this.PolicyNumber = policyNumber;
    this.EffectiveDateFrom = effectiveDateFrom;
    this.EffectiveDateTo = effectiveDateTo;
    this.ExpirationDateFrom = expirationDateFrom;
    this.ExpirationDateTo = expirationDateTo;
    this.InvoiceDueDateFrom = invoiceDueDateFrom;
    this.InvoiceDueDateTo = invoiceDueDateTo;
    this.LineGuid = lineGuid;
    this.ControlNumber = controlNumber;
    this.InvoiceNumber = invoiceNumber;
    this.PolicyStatusId = policyStatusId;
    ((Control) this.buttonSave).Text = "Save";
  }

  private void LoadQueries()
  {
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable("spFin_GetExtendedPolicySearchSavedQueries").Rows)
      this.ultraListView1.Items.Add(row["RowId"].ToString(), row["QueryName"]);
  }

  private void FormSavedQueries_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadQueries();
  }

  protected virtual void SaveQuery()
  {
    DefaultDatabase.ExecuteNonQuery("spFin_SaveExtendedPolicySearchQuery", new object[38]
    {
      (object) "@QueryName",
      (object) ((Control) this.textQueryName).Text,
      (object) "@GlCompanyId",
      (object) this.GLCompanyId,
      (object) "@EntityGuid",
      (object) (this.EntityGuid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) this.EntityGuid),
      (object) "@EntityName",
      (object) this.EntityName,
      (object) "@LineGuid",
      (object) (this.LineGuid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) this.LineGuid),
      (object) "@PolicyNumber",
      (object) this.PolicyNumber,
      (object) "@InvoiceNumber",
      (object) this.InvoiceNumber,
      (object) "@ControlNumber",
      (object) this.ControlNumber,
      (object) "@PolicyStatusId",
      (object) this.PolicyStatusId,
      (object) "@EffectiveDateFrom",
      (object) this.EffectiveDateFrom,
      (object) "@EffectiveDateTo",
      (object) this.EffectiveDateTo,
      (object) "@ExpirationDateFrom",
      (object) this.ExpirationDateFrom,
      (object) "@ExpirationDateTo",
      (object) this.ExpirationDateTo,
      (object) "@InvoiceDateFrom",
      (object) this.InvoiceDueDateFrom,
      (object) "@InvoiceDateTo",
      (object) this.InvoiceDueDateTo,
      (object) "@InsuredAddress",
      (object) this.InsuredAddress,
      (object) "@InsuredCity",
      (object) this.InsuredCity,
      (object) "@InsuredState",
      (object) this.InsuredState,
      (object) "@InsuredZip",
      (object) this.InsuredZip
    });
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (((Control) this.buttonSave).Text == "Save")
    {
      if (!string.IsNullOrEmpty(((Control) this.textQueryName).Text))
      {
        try
        {
          this.SaveQuery();
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
      else
      {
        int num = (int) MessageBox.Show("You must specify a query name to continue.", "Required field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    else
      this.LoadQuery();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void ultraListView1_DoubleClick(object sender, EventArgs e) => this.LoadQuery();

  protected virtual void LoadQuery()
  {
    if (((DisposableObjectCollectionBase) this.ultraListView1.SelectedItems).Count == 0)
    {
      int num1 = (int) MessageBox.Show("You must select a saved query to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow("spFin_GetExtendedPolicySearchQuery", new object[2]
      {
        (object) "@RowId",
        (object) ((KeyedSubObjectBase) ((UltraListViewStateSpecificItemsCollectionBase) this.ultraListView1.SelectedItems)[0]).Key
      });
      if (dataRow == null)
      {
        int num2 = (int) MessageBox.Show("The specified query could not be found.", "Saved Query Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.GLCompanyId = int.Parse(dataRow["GLCompanyId"].ToString());
        if (dataRow["InsuredAddress"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["InsuredAddress"].ToString()))
          this.InsuredAddress = dataRow["InsuredAddress"].ToString();
        if (dataRow["InsuredCity"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["InsuredCity"].ToString()))
          this.InsuredCity = dataRow["InsuredCity"].ToString();
        if (dataRow["InsuredState"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["InsuredState"].ToString()))
          this.InsuredState = dataRow["InsuredState"].ToString();
        if (dataRow["InsuredZip"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["InsuredZip"].ToString()))
          this.InsuredZip = dataRow["InsuredZip"].ToString();
        if (dataRow["EntityGuid"] != DBNull.Value)
          this.EntityGuid = new Guid(dataRow["EntityGuid"].ToString());
        if (dataRow["EntityName"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["EntityName"].ToString()))
          this.EntityName = dataRow["EntityName"].ToString();
        if (dataRow["PolicyNumber"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["PolicyNumber"].ToString()))
          this.PolicyNumber = dataRow["PolicyNumber"].ToString();
        if (dataRow["EffectiveFrom"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["EffectiveFrom"].ToString()))
          this.EffectiveDateFrom = (DateTime?) dataRow["EffectiveFrom"];
        if (dataRow["EffectiveTo"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["EffectiveTo"].ToString()))
          this.EffectiveDateTo = (DateTime?) dataRow["EffectiveTo"];
        if (dataRow["ExpirationFrom"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["ExpirationFrom"].ToString()))
          this.ExpirationDateFrom = (DateTime?) dataRow["ExpirationFrom"];
        if (dataRow["ExpirationTo"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["ExpirationTo"].ToString()))
          this.ExpirationDateTo = (DateTime?) dataRow["ExpirationTo"];
        if (dataRow["InvoiceDateFrom"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["InvoiceDateFrom"].ToString()))
          this.InvoiceDueDateFrom = (DateTime?) dataRow["InvoiceDateFrom"];
        if (dataRow["InvoiceDateTo"] != DBNull.Value && !string.IsNullOrEmpty(dataRow["InvoiceDateTo"].ToString()))
          this.InvoiceDueDateTo = (DateTime?) dataRow["InvoiceDateTo"];
        if (dataRow["LineGuid"] != DBNull.Value)
          this.LineGuid = new Guid(dataRow["LineGuid"].ToString());
        if (dataRow["ControlNumber"] != DBNull.Value)
          this.ControlNumber = (int?) dataRow["ControlNumber"];
        if (dataRow["InvoiceNumber"] != DBNull.Value)
          this.InvoiceNumber = (int?) dataRow["InvoiceNumber"];
        if (dataRow["PolicyStatusId"] != DBNull.Value)
          this.PolicyStatusId = (int?) dataRow["PolicyStatusId"];
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
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
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSavedQueries));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.ultraListView1 = new UltraListView();
    this.panel1 = new Panel();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.textQueryName = new MGATextBox();
    this.label1 = new Label();
    ((ISupportInitialize) this.ultraListView1).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.textQueryName).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraListView1).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance4.Image");
    this.ultraListView1.ItemSettings.Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraListView1).Location = new Point(0, 0);
    ((Control) this.ultraListView1).Name = "ultraListView1";
    ((Control) this.ultraListView1).Size = new Size(603, 383);
    ((Control) this.ultraListView1).TabIndex = 0;
    ((Control) this.ultraListView1).Text = "ultraListView1";
    this.ultraListView1.View = (UltraListViewStyle) 2;
    ((Control) this.ultraListView1).DoubleClick += new EventHandler(this.ultraListView1_DoubleClick);
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.buttonCancel);
    this.panel1.Controls.Add((Control) this.buttonSave);
    this.panel1.Controls.Add((Control) this.textQueryName);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 383);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(603, 36);
    this.panel1.TabIndex = 1;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(523, 3);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 29);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSave).Location = new Point(437, 3);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(80 /*0x50*/, 29);
    ((Control) this.buttonSave).TabIndex = 2;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textQueryName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textQueryName).BackColor = Color.White;
    ((Control) this.textQueryName).Location = new Point(81, 7);
    this.textQueryName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textQueryName).Name = "textQueryName";
    ((Control) this.textQueryName).Size = new Size(350, 20);
    ((Control) this.textQueryName).TabIndex = 1;
    ((UltraControlBase) this.textQueryName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textQueryName).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(4, 7);
    this.label1.Name = "label1";
    this.label1.Size = new Size(71, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Query Name:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(603, 419);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraListView1);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormSavedQueries);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Saved Queries";
    this.Load += new EventHandler(this.FormSavedQueries_Load);
    ((ISupportInitialize) this.ultraListView1).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.textQueryName).EndInit();
    this.ResumeLayout(false);
  }
}
