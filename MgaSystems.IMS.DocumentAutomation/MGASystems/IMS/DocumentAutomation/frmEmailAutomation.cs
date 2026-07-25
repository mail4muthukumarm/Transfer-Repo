// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmEmailAutomation
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class frmEmailAutomation : Form
{
  private IContainer components;
  private Guid _companyLineGuid;
  private Guid _automationEventGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEventName")]
  internal virtual Label lblEventName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSave
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

  internal virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("listSendTo")]
  internal virtual CheckedListBox listSendTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBody")]
  internal virtual MGATextBox txtBody { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsEmailAutomation ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  internal virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  internal virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmailAutomation));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.Label1 = new Label();
    this.lblEventName = new Label();
    this.Label3 = new Label();
    this.PictureBox1 = new PictureBox();
    this.listSendTo = new CheckedListBox();
    this.txtBody = new MGATextBox();
    this.Label4 = new Label();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ds = new dsEmailAutomation();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.txtBody).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 11f);
    this.Label1.Location = new Point(135, 25);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(195, 18);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Automated Emails Setup for:";
    this.lblEventName.AutoSize = true;
    this.lblEventName.Font = new Font("Tahoma", 12f);
    this.lblEventName.Location = new Point(135, 55);
    this.lblEventName.Name = "lblEventName";
    this.lblEventName.Size = new Size(231, 19);
    this.lblEventName.TabIndex = 1;
    this.lblEventName.Text = "[system event name goes here]";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(35, 105);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(205, 13);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Who should this document be emailed to?";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(10, 10);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(125, 90);
    this.PictureBox1.TabIndex = 4;
    this.PictureBox1.TabStop = false;
    this.listSendTo.BackColor = Color.White;
    this.listSendTo.BorderStyle = BorderStyle.None;
    this.listSendTo.CheckOnClick = true;
    this.listSendTo.ForeColor = Color.Black;
    this.listSendTo.Items.AddRange(new object[4]
    {
      (object) "Producer Contact",
      (object) "Insured Contact",
      (object) "Company Contact",
      (object) "Producer CSR"
    });
    this.listSendTo.Location = new Point(50, 125);
    this.listSendTo.Name = "listSendTo";
    this.listSendTo.Size = new Size(120, 64 /*0x40*/);
    this.listSendTo.TabIndex = 5;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBody).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtBody).BackColor = Color.White;
    ((Control) this.txtBody).Location = new Point(50, 234);
    this.txtBody.Multiline = true;
    ((Control) this.txtBody).Name = "txtBody";
    ((Control) this.txtBody).Size = new Size(370, 140);
    ((Control) this.txtBody).TabIndex = 6;
    ((UltraControlBase) this.txtBody).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBody).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(35, 203);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(138, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "What should the body say?";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(330, 394);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 8;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(380, 394);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 9;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentEmailAutomation", new DataColumnMapping[7]
      {
        new DataColumnMapping("ProducerContact", "ProducerContact"),
        new DataColumnMapping("InsuredContact", "InsuredContact"),
        new DataColumnMapping("CompanyContact", "CompanyContact"),
        new DataColumnMapping("Body", "Body"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("AutomationEventGuid", "AutomationEventGuid"),
        new DataColumnMapping("ProducerCSR", "ProducerCSR")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblDocumentEmailAutomation] WHERE (([CompanyLineGuid] = @Original_CompanyLineGuid) AND ([AutomationEventGuid] = @Original_AutomationEventGuid))";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AutomationEventGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutomationEventGuid", DataRowVersion.Original, (object) null)
    });
    this.cn.ConnectionString = "Data Source=mgasystems;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@ProducerContact", SqlDbType.Bit, 0, "ProducerContact"),
      new SqlParameter("@InsuredContact", SqlDbType.Bit, 0, "InsuredContact"),
      new SqlParameter("@CompanyContact", SqlDbType.Bit, 0, "CompanyContact"),
      new SqlParameter("@Body", SqlDbType.VarChar, 0, "Body"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLineGuid"),
      new SqlParameter("@AutomationEventGuid", SqlDbType.UniqueIdentifier, 0, "AutomationEventGuid"),
      new SqlParameter("@ProducerCSR", SqlDbType.Bit, 0, "ProducerCSR")
    });
    this.SqlSelectCommand1.CommandText = componentResourceManager.GetString("SqlSelectCommand1.CommandText");
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@AutomationEventGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationEventGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@ProducerContact", SqlDbType.Bit, 0, "ProducerContact"),
      new SqlParameter("@InsuredContact", SqlDbType.Bit, 0, "InsuredContact"),
      new SqlParameter("@CompanyContact", SqlDbType.Bit, 0, "CompanyContact"),
      new SqlParameter("@Body", SqlDbType.VarChar, 0, "Body"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLineGuid"),
      new SqlParameter("@AutomationEventGuid", SqlDbType.UniqueIdentifier, 0, "AutomationEventGuid"),
      new SqlParameter("@ProducerCSR", SqlDbType.Bit, 0, "ProducerCSR"),
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_AutomationEventGuid", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AutomationEventGuid", DataRowVersion.Original, (object) null)
    });
    this.ds.DataSetName = "dsEmailAutomation";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(434, 446);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.lblEventName);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtBody);
    this.Controls.Add((Control) this.listSendTo);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEmailAutomation);
    this.Text = "Email Automation";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.txtBody).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmEmailAutomation(Guid companyLineGuid, Guid automationEventGuid)
  {
    this.Load += new EventHandler(this.frmEmailAutomation_Load);
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
    this._automationEventGuid = automationEventGuid;
    this.lblEventName.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ADE.EventName FROM tblCompanyAutomationDocuments CAD INNER JOIN lstAutomationDocumentEvents ADE ON CAD.AutomationEventGuid = ADE.EventGuid WHERE CAD.CompanyLineGuid=@CompanyLineGuid AND CAD.AutomationEventGuid=@AutomationEventGuid", new object[4]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid,
      (object) "@AutomationEventGuid",
      (object) this._automationEventGuid
    });
    this.cn.ConnectionString = DefaultDatabase.ConnectionString;
  }

  private void frmEmailAutomation_Load(object sender, EventArgs e)
  {
    this.da.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
    this.da.SelectCommand.Parameters["@AutomationEventGuid"].Value = (object) this._automationEventGuid;
    this.da.Fill((DataTable) this.ds.tblDocumentEmailAutomation);
    if (this.ds.tblDocumentEmailAutomation.Count != 1)
      return;
    dsEmailAutomation.tblDocumentEmailAutomationRow emailAutomationRow = this.ds.tblDocumentEmailAutomation[0];
    if (emailAutomationRow.ProducerContact)
      this.listSendTo.SetItemChecked(0, true);
    if (emailAutomationRow.InsuredContact)
      this.listSendTo.SetItemChecked(1, true);
    if (emailAutomationRow.CompanyContact)
      this.listSendTo.SetItemChecked(2, true);
    ((TextEditorControlBase) this.txtBody).Text = emailAutomationRow.Body;
    if (emailAutomationRow.ProducerCSR)
      this.listSendTo.SetItemChecked(3, true);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    int num1 = this.ds.tblDocumentEmailAutomation.Count == 0 ? 1 : 0;
    if (num1 != 0 && this.listSendTo.CheckedItems.Count > 0)
    {
      dsEmailAutomation.tblDocumentEmailAutomationRow row = this.ds.tblDocumentEmailAutomation.NewtblDocumentEmailAutomationRow();
      row.CompanyLineGuid = this._companyLineGuid;
      row.AutomationEventGuid = this._automationEventGuid;
      this.ds.tblDocumentEmailAutomation.AddtblDocumentEmailAutomationRow(row);
    }
    if (num1 == 0 && this.listSendTo.CheckedItems.Count == 0)
    {
      this.ds.tblDocumentEmailAutomation[0].Delete();
    }
    else
    {
      dsEmailAutomation.tblDocumentEmailAutomationRow emailAutomationRow = this.ds.tblDocumentEmailAutomation[0];
      emailAutomationRow.ProducerContact = this.listSendTo.GetItemChecked(0);
      emailAutomationRow.InsuredContact = this.listSendTo.GetItemChecked(1);
      emailAutomationRow.CompanyContact = this.listSendTo.GetItemChecked(2);
      emailAutomationRow.Body = ((TextEditorControlBase) this.txtBody).Text;
      emailAutomationRow.ProducerCSR = this.listSendTo.GetItemChecked(3);
    }
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblDocumentEmailAutomation);
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.Message.Contains("PK_tblDocumentEmailAutomation"))
      {
        int num2 = (int) MessageBox.Show("An email automation record already exists for this company/line and automation event.", "Record Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
