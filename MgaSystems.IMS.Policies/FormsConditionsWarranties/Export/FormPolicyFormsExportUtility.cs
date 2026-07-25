// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.Export.FormPolicyFormsExportUtility
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraActivityIndicator;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties.Export;

[DesignerGenerated]
public class FormPolicyFormsExportUtility : Form
{
  private IContainer components;

  public FormPolicyFormsExportUtility()
  {
    this.Load += new EventHandler(this.FormPolicyFormsExportUtility_Load);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormPolicyFormsExportUtility));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label2 = new Label();
    this.labelPolicyForms = new Label();
    this.labelTemplateDocuments = new Label();
    this.labelCompanyLineSetups = new Label();
    this.buttonExport = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.labelRaterForms = new Label();
    this.labelLastExportDate = new Label();
    this.activity = new Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator();
    PictureBox pictureBox = new PictureBox();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    ((ISupportInitialize) pictureBox).BeginInit();
    ((ISupportInitialize) this.buttonExport).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    pictureBox.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    pictureBox.Location = new Point(12, 12);
    pictureBox.Name = "PictureBox1";
    pictureBox.Size = new Size(114, 120);
    pictureBox.TabIndex = 0;
    pictureBox.TabStop = false;
    label1.AutoSize = true;
    label1.Font = new Font("Tahoma", 20.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label1.ForeColor = Color.SteelBlue;
    label1.Location = new Point(140, 9);
    label1.Name = "Label1";
    label1.Size = new Size(324, 33);
    label1.TabIndex = 1;
    label1.Text = "Policy Forms Export Utility";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(275, 89);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(89, 16 /*0x10*/);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Policy Forms:";
    this.labelPolicyForms.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelPolicyForms.ForeColor = Color.Red;
    this.labelPolicyForms.Location = new Point(392, 89);
    this.labelPolicyForms.Name = "labelPolicyForms";
    this.labelPolicyForms.Size = new Size(65, 17);
    this.labelPolicyForms.TabIndex = 3;
    this.labelPolicyForms.Text = "0";
    this.labelPolicyForms.TextAlign = ContentAlignment.MiddleRight;
    this.labelTemplateDocuments.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelTemplateDocuments.ForeColor = Color.Red;
    this.labelTemplateDocuments.Location = new Point(392, 115);
    this.labelTemplateDocuments.Name = "labelTemplateDocuments";
    this.labelTemplateDocuments.Size = new Size(65, 17);
    this.labelTemplateDocuments.TabIndex = 5;
    this.labelTemplateDocuments.Text = "0";
    this.labelTemplateDocuments.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label2.Location = new Point(224 /*0xE0*/, 115);
    label2.Name = "Label4";
    label2.Size = new Size(140, 16 /*0x10*/);
    label2.TabIndex = 4;
    label2.Text = "Template Documents:";
    label3.AutoSize = true;
    label3.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label3.Location = new Point(146, 56);
    label3.Name = "Label5";
    label3.Size = new Size(196, 19);
    label3.TabIndex = 6;
    label3.Text = "Items available for export:";
    this.labelCompanyLineSetups.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCompanyLineSetups.ForeColor = Color.Red;
    this.labelCompanyLineSetups.Location = new Point(392, 141);
    this.labelCompanyLineSetups.Name = "labelCompanyLineSetups";
    this.labelCompanyLineSetups.Size = new Size(65, 17);
    this.labelCompanyLineSetups.TabIndex = 8;
    this.labelCompanyLineSetups.Text = "0";
    this.labelCompanyLineSetups.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label4.Location = new Point(187, 141);
    label4.Name = "Label7";
    label4.Size = new Size(177, 16 /*0x10*/);
    label4.TabIndex = 7;
    label4.Text = "Company/Line Form Setups:";
    appearance1.BackColor = Color.White;
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonExport).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonExport).Location = new Point(225, 212);
    ((Control) this.buttonExport).Name = "buttonExport";
    ((Control) this.buttonExport).Size = new Size(115, 33);
    ((Control) this.buttonExport).TabIndex = 9;
    ((ControlBase) this.buttonExport).Text = "Begin Export";
    this.buttonExport.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(359, 212);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(115, 33);
    ((Control) this.buttonCancel).TabIndex = 10;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.labelRaterForms.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelRaterForms.ForeColor = Color.Red;
    this.labelRaterForms.Location = new Point(391, 167);
    this.labelRaterForms.Name = "labelRaterForms";
    this.labelRaterForms.Size = new Size(66, 17);
    this.labelRaterForms.TabIndex = 12;
    this.labelRaterForms.Text = "0";
    this.labelRaterForms.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.Font = new Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label5.Location = new Point(171, 167);
    label5.Name = "Label6";
    label5.Size = new Size(193, 16 /*0x10*/);
    label5.TabIndex = 11;
    label5.Text = "Rater Conditional Form Setups:";
    label6.AutoSize = true;
    label6.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label6.Location = new Point(8, 222);
    label6.Name = "Label8";
    label6.Size = new Size(102, 13);
    label6.TabIndex = 13;
    label6.Text = "Date of last export:";
    label6.TextAlign = ContentAlignment.MiddleLeft;
    this.labelLastExportDate.AutoSize = true;
    this.labelLastExportDate.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelLastExportDate.Location = new Point(111, 222);
    this.labelLastExportDate.Name = "labelLastExportDate";
    this.labelLastExportDate.Size = new Size(51, 13);
    this.labelLastExportDate.TabIndex = 14;
    this.labelLastExportDate.Text = "00/00/00";
    this.labelLastExportDate.TextAlign = ContentAlignment.MiddleLeft;
    this.activity.AnimationSpeed = 25;
    this.activity.CausesValidation = true;
    ((Control) this.activity).Location = new Point(12, (int) byte.MaxValue);
    ((Control) this.activity).Name = "UltraActivityIndicator1";
    ((Control) this.activity).Size = new Size(465, 15);
    this.activity.TabIndex = 15;
    this.activity.TabStop = true;
    ((UltraControlBase) this.activity).UseOsThemes = (DefaultableBoolean) 1;
    this.activity.ViewStyle = (ActivityIndicatorViewStyle) 2;
    this.AcceptButton = (IButtonControl) this.buttonExport;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(488, 276);
    this.Controls.Add((Control) this.activity);
    this.Controls.Add((Control) this.labelLastExportDate);
    this.Controls.Add((Control) label6);
    this.Controls.Add((Control) this.labelRaterForms);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonExport);
    this.Controls.Add((Control) this.labelCompanyLineSetups);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.labelTemplateDocuments);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.labelPolicyForms);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) pictureBox);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (FormPolicyFormsExportUtility);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Policy Forms Export Utility";
    ((ISupportInitialize) pictureBox).EndInit();
    ((ISupportInitialize) this.buttonExport).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelPolicyForms")]
  private virtual Label labelPolicyForms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelTemplateDocuments")]
  private virtual Label labelTemplateDocuments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelCompanyLineSetups")]
  private virtual Label labelCompanyLineSetups { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton buttonExport
  {
    get => this._buttonExport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonExport_Click);
      MGAButton buttonExport1 = this._buttonExport;
      if (buttonExport1 != null)
        ((Control) buttonExport1).Click -= eventHandler;
      this._buttonExport = value;
      MGAButton buttonExport2 = this._buttonExport;
      if (buttonExport2 == null)
        return;
      ((Control) buttonExport2).Click += eventHandler;
    }
  }

  private virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelRaterForms")]
  private virtual Label labelRaterForms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelLastExportDate")]
  private virtual Label labelLastExportDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("activity")]
  private virtual Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator activity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void FormPolicyFormsExportUtility_Load(object sender, EventArgs e)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.LoadCountsThread));
  }

  private object GetLastExportDate()
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SettingValueDateTime FROM tblSystemSettings WHERE Setting = @setting", new object[2]
    {
      (object) "@setting",
      (object) "LastPolicyFormExportDate"
    });
  }

  private void LoadCountsThread(object stateInfo)
  {
    this.Invoke((Delegate) new FormPolicyFormsExportUtility.ShowLastExportDateHandler(this.ShowLastExportDate), this.GetLastExportDate());
    this.Invoke((Delegate) new FormPolicyFormsExportUtility.CountsLoaded(this.CountLoadComplete), (object) DefaultDatabase.ExecuteDataTable("dbo.GetNonExportedPolicyFormCount", new object[2]
    {
      (object) "@countOnly",
      (object) true
    }));
  }

  private void ShowLastExportDate(object lastExport)
  {
    if (lastExport != null)
      this.labelLastExportDate.Text = ((DateTime) lastExport).ToShortDateString();
    else
      this.labelLastExportDate.Text = "No Previous Export";
  }

  private void CountLoadComplete(DataTable dt)
  {
    int integer1 = Conversions.ToInteger(dt.Rows[0][0]);
    int integer2 = Conversions.ToInteger(dt.Rows[1][0]);
    int integer3 = Conversions.ToInteger(dt.Rows[2][0]);
    int integer4 = Conversions.ToInteger(dt.Rows[3][0]);
    this.labelPolicyForms.Text = Strings.FormatNumber((object) integer1, 0);
    this.labelTemplateDocuments.Text = Strings.FormatNumber((object) integer2, 0);
    this.labelCompanyLineSetups.Text = Strings.FormatNumber((object) integer3, 0);
    this.labelRaterForms.Text = Strings.FormatNumber((object) integer4, 0);
    if (integer1 > 0)
      this.labelPolicyForms.ForeColor = Color.Black;
    if (integer2 > 0)
      this.labelTemplateDocuments.ForeColor = Color.Black;
    if (integer3 > 0)
      this.labelCompanyLineSetups.ForeColor = Color.Black;
    if (integer4 > 0)
      this.labelRaterForms.ForeColor = Color.Black;
    if (integer1 != 0 || integer2 != 0 || integer3 != 0 || integer4 != 0)
      return;
    ((Control) this.buttonExport).Enabled = false;
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void buttonExport_Click(object sender, EventArgs e)
  {
    string fileName;
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      saveFileDialog.DefaultExt = "xml";
      saveFileDialog.FileName = "IMS_PolicyFormsExport.xml";
      saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      saveFileDialog.Filter = "XML file (*.xml)|*.xml";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      fileName = saveFileDialog.FileName;
    }
    ((Control) this.buttonExport).Enabled = false;
    ((Control) this.buttonCancel).Enabled = false;
    this.Cursor = Cursors.WaitCursor;
    this.activity.Start();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.LoadDataThread), (object) fileName);
  }

  private void LoadDataThread(object stateInfo)
  {
    this.Invoke((Delegate) new FormPolicyFormsExportUtility.DataLoaded(this.DataLoadComplete), (object) DefaultDatabase.ExecuteDataSet("dbo.GetNonExportedPolicyFormCount", new object[2]
    {
      (object) "@countOnly",
      (object) false
    }), (object) (string) stateInfo);
  }

  private void DataLoadComplete(DataSet ds, string exportFileLocation)
  {
    ds.WriteXml(exportFileLocation);
    this.UpdateLastExportDate();
    this.activity.Stop();
    this.activity.ResetAnimation();
    this.Cursor = Cursors.Default;
    int num = (int) MessageBox.Show("The policy forms have been succesfully exported to the following file:\n\n" + exportFileLocation, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void UpdateLastExportDate()
  {
    if (this.GetLastExportDate() == null)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblSystemSettings(Setting,SettingValueDateTime)VALUES(@setting,GETDATE())", new object[2]
      {
        (object) "@setting",
        (object) "LastPolicyFormExportDate"
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblSystemSettings SET SettingValueDateTime = GETDATE() WHERE Setting = @setting", new object[2]
      {
        (object) "@setting",
        (object) "LastPolicyFormExportDate"
      });
  }

  private delegate void CountsLoaded(DataTable dt);

  private delegate void DataLoaded(DataSet ds, string exportFileLocation);

  private delegate void ShowLastExportDateHandler(object lastExport);
}
