// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.Import.FormPolicyFormsImportUtility
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties.Import;

[DesignerGenerated]
public class FormPolicyFormsImportUtility : Form
{
  private IContainer components;

  public FormPolicyFormsImportUtility() => this.InitializeComponent();

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormPolicyFormsImportUtility));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.buttonChooseFile = new MGAButton();
    this.activity = new Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator();
    this.buttonImport = new MGAButton();
    this.labelFileToImport = new Label();
    Label label = new Label();
    PictureBox pictureBox = new PictureBox();
    ((ISupportInitialize) pictureBox).BeginInit();
    ((ISupportInitialize) this.buttonChooseFile).BeginInit();
    ((ISupportInitialize) this.buttonImport).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 20.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.ForeColor = Color.SteelBlue;
    label.Location = new Point(132, 12);
    label.Name = "Label1";
    label.Size = new Size(329, 33);
    label.TabIndex = 2;
    label.Text = "Policy Forms Import Utility";
    pictureBox.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    pictureBox.Location = new Point(12, 12);
    pictureBox.Name = "PictureBox1";
    pictureBox.Size = new Size(114, 120);
    pictureBox.TabIndex = 3;
    pictureBox.TabStop = false;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonChooseFile).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonChooseFile).Location = new Point(135, 74);
    ((Control) this.buttonChooseFile).Name = "buttonChooseFile";
    ((Control) this.buttonChooseFile).Size = new Size(154, 33);
    ((Control) this.buttonChooseFile).TabIndex = 8;
    ((ControlBase) this.buttonChooseFile).Text = "Choose import file ...";
    this.buttonChooseFile.UseOSThemes = (DefaultableBoolean) 2;
    this.activity.CausesValidation = true;
    ((Control) this.activity).Location = new Point(12, 149);
    ((Control) this.activity).Name = "activity";
    ((Control) this.activity).Size = new Size(460, 14);
    this.activity.TabIndex = 9;
    this.activity.TabStop = true;
    appearance2.BackColor = Color.White;
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonImport).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonImport).Enabled = false;
    ((Control) this.buttonImport).Location = new Point(295, 74);
    ((Control) this.buttonImport).Name = "buttonImport";
    ((Control) this.buttonImport).Size = new Size(154, 33);
    ((Control) this.buttonImport).TabIndex = 10;
    ((ControlBase) this.buttonImport).Text = "Begin Import";
    this.buttonImport.UseOSThemes = (DefaultableBoolean) 2;
    this.labelFileToImport.Location = new Point(138, 118);
    this.labelFileToImport.Name = "labelFileToImport";
    this.labelFileToImport.Size = new Size(311, 13);
    this.labelFileToImport.TabIndex = 11;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(484, 175);
    this.Controls.Add((Control) this.labelFileToImport);
    this.Controls.Add((Control) this.buttonImport);
    this.Controls.Add((Control) this.activity);
    this.Controls.Add((Control) this.buttonChooseFile);
    this.Controls.Add((Control) pictureBox);
    this.Controls.Add((Control) label);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (FormPolicyFormsImportUtility);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Policy Forms Import Utility";
    ((ISupportInitialize) pictureBox).EndInit();
    ((ISupportInitialize) this.buttonChooseFile).EndInit();
    ((ISupportInitialize) this.buttonImport).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual MGAButton buttonChooseFile
  {
    get => this._buttonChooseFile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonChooseFile_Click);
      MGAButton buttonChooseFile1 = this._buttonChooseFile;
      if (buttonChooseFile1 != null)
        ((Control) buttonChooseFile1).Click -= eventHandler;
      this._buttonChooseFile = value;
      MGAButton buttonChooseFile2 = this._buttonChooseFile;
      if (buttonChooseFile2 == null)
        return;
      ((Control) buttonChooseFile2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("activity")]
  private virtual Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator activity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton buttonImport
  {
    get => this._buttonImport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonImport_Click);
      MGAButton buttonImport1 = this._buttonImport;
      if (buttonImport1 != null)
        ((Control) buttonImport1).Click -= eventHandler;
      this._buttonImport = value;
      MGAButton buttonImport2 = this._buttonImport;
      if (buttonImport2 == null)
        return;
      ((Control) buttonImport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelFileToImport")]
  private virtual Label labelFileToImport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void buttonChooseFile_Click(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.DefaultExt = "xml";
      openFileDialog.FileName = "IMS_PolicyFormsExport.xml";
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      openFileDialog.Filter = "XML file (*.xml)|*.xml";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.labelFileToImport.Text = openFileDialog.FileName;
      ((Control) this.buttonImport).Enabled = true;
    }
  }

  private void buttonImport_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this.activity.Start();
    DataSet dataSet = new DataSet();
    try
    {
      int num = (int) dataSet.ReadXml(this.labelFileToImport.Text);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("The IMS was unable to import this file.\n\nPlease verify this is a valid IMS policy forms export file.", "Unable to Import File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.activity.Stop();
      this.activity.ResetAnimation();
      this.Cursor = Cursors.Default;
      ProjectData.ClearProjectError();
      return;
    }
    Debugger.Break();
  }
}
