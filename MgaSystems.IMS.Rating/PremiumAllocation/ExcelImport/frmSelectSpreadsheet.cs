// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport.frmSelectSpreadsheet
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Tools;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.PremiumAllocation.ExcelImport;

public sealed class frmSelectSpreadsheet : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  private System.Windows.Forms.Label Label1;
  private UltraLabel lblFileName;
  private Quote _quote;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSelectFile
  {
    get => this._btnSelectFile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectFile_Click);
      MGAButton btnSelectFile1 = this._btnSelectFile;
      if (btnSelectFile1 != null)
        ((Control) btnSelectFile1).Click -= eventHandler;
      this._btnSelectFile = value;
      MGAButton btnSelectFile2 = this._btnSelectFile;
      if (btnSelectFile2 == null)
        return;
      ((Control) btnSelectFile2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkPlacePremiumInStateOfIssuance")]
  private virtual MGACheckBox chkPlacePremiumInStateOfIssuance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectSpreadsheet));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.btnNext = new MGAButton();
    this.lblFileName = new UltraLabel();
    this.btnSelectFile = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.chkPlacePremiumInStateOfIssuance = new MGACheckBox();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnSelectFile).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.chkPlacePremiumInStateOfIssuance).BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new System.Drawing.Point(16 /*0x10*/, 23);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Location = new System.Drawing.Point(88, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(397, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please select the Excel spreadsheet you would like to import allocation data from:";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    appearance1.ImageHAlign = (HAlign) 3;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnNext).ImageSize = new Size(15, 11);
    ((Control) this.btnNext).Location = new System.Drawing.Point(400, 80 /*0x50*/);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnNext).TabIndex = 4;
    ((ControlBase) this.btnNext).Text = "Next";
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblFileName).Appearance = (AppearanceBase) appearance2;
    this.lblFileName.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblFileName).Location = new System.Drawing.Point(88, 40);
    ((Control) this.lblFileName).Name = "lblFileName";
    ((Control) this.lblFileName).Size = new Size(392, 24);
    ((Control) this.lblFileName).TabIndex = 5;
    ((ControlBase) this.lblFileName).WrapText = false;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    ((ControlBase) this.btnSelectFile).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnSelectFile).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSelectFile).Location = new System.Drawing.Point(488, 40);
    ((Control) this.btnSelectFile).Name = "btnSelectFile";
    ((Control) this.btnSelectFile).Size = new Size(24, 24);
    ((Control) this.btnSelectFile).TabIndex = 6;
    this.btnSelectFile.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPlacePremiumInStateOfIssuance).Location = new System.Drawing.Point(88, 80 /*0x50*/);
    ((Control) this.chkPlacePremiumInStateOfIssuance).Name = "chkPlacePremiumInStateOfIssuance";
    ((Control) this.chkPlacePremiumInStateOfIssuance).Size = new Size(259, 25);
    ((Control) this.chkPlacePremiumInStateOfIssuance).TabIndex = 27;
    ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).Text = "Place all Premium in Policy State of Issuance.";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(522, 112 /*0x70*/);
    this.Controls.Add((Control) this.chkPlacePremiumInStateOfIssuance);
    this.Controls.Add((Control) this.btnSelectFile);
    this.Controls.Add((Control) this.lblFileName);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new System.Drawing.Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSelectSpreadsheet);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select an Excel Spreadsheet";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnSelectFile).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.chkPlacePremiumInStateOfIssuance).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal bool PlacePremInStateOfIssuance
  {
    get => ((UltraToggleEditorBase) this.chkPlacePremiumInStateOfIssuance).Checked;
  }

  public frmSelectSpreadsheet(Quote quote)
  {
    this.InitializeComponent();
    this._quote = quote;
  }

  private void btnSelectFile_Click(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    try
    {
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      openFileDialog.Filter = "Microsoft Excel files (*.xl; *.xls; *.xlt; )|*.xl; *.xls; *.xlt|All files (*.*)|*.*";
      openFileDialog.CheckFileExists = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      ((ControlBase) this.lblFileName).Text = openFileDialog.FileName;
    }
    finally
    {
      openFileDialog.Dispose();
    }
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    if (Operators.CompareString(((ControlBase) this.lblFileName).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.lblFileName, "Please select a spreadsheet to load.");
    }
    else
    {
      this.err.SetError((Control) this.lblFileName, string.Empty);
      this.Close();
      frmSelectSpreadsheet.ProcessExcelSpreadSheet(((ControlBase) this.lblFileName).Text, this._quote, this.PlacePremInStateOfIssuance);
    }
  }

  public static void ProcessExcelSpreadSheet(
    string fileName,
    Quote quote,
    bool PlacePremInIssuanceState)
  {
    ApplicationClass o = new ApplicationClass();
    Workbook workbook = (Workbook) null;
    Worksheet worksheet = (Worksheet) null;
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      o.Visible = false;
      workbook = o.Workbooks.Open(fileName, (object) 0, (object) true, (object) 5, (object) string.Empty, (object) string.Empty, (object) true, (object) XlPlatform.xlWindows, (object) "\\t", (object) false, (object) false, (object) 0, (object) true, (object) 1, (object) 0);
      if (workbook.Worksheets.Count == 0)
      {
        int num1 = (int) MessageBox.Show("The selected workbook contains no worksheets.", "No Worksheets", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if (workbook.Worksheets.Count == 1)
        {
          try
          {
            worksheet = (Worksheet) workbook.Worksheets[(object) 0];
          }
          catch (COMException ex1)
          {
            ProjectData.SetProjectError((Exception) ex1);
            try
            {
              worksheet = (Worksheet) workbook.Worksheets[(object) 1];
            }
            catch (COMException ex2)
            {
              ProjectData.SetProjectError((Exception) ex2);
              int num2 = (int) MessageBox.Show("The system was unable to open this Excel file.\n\nIf the file contains complex objects such as pivot tables, please either remove these objects or copy the data into a new spreadsheet before importing.", "Unable to Import Spreadsheet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              ProjectData.ClearProjectError();
              return;
            }
            ProjectData.ClearProjectError();
          }
        }
        else
        {
          frmSelectWorksheet frmSelectWorksheet = new frmSelectWorksheet(workbook);
          try
          {
            frmSelectWorksheet.ShowInTaskbar = true;
            int num3 = (int) frmSelectWorksheet.ShowDialog();
            if (frmSelectWorksheet.SelectedWorksheet == null)
              return;
            if (frmSelectWorksheet.SelectedWorksheet.Length <= 0)
              return;
            IEnumerator enumerator;
            try
            {
              enumerator = (IEnumerator) workbook.Worksheets.GetEnumerator();
              while (enumerator.MoveNext())
              {
                Worksheet current = (Worksheet) enumerator.Current;
                if (Operators.CompareString(current.Name, frmSelectWorksheet.SelectedWorksheet, false) == 0)
                  worksheet = current;
              }
            }
            finally
            {
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          finally
          {
            frmSelectWorksheet.Dispose();
          }
        }
        frmMapFields frmMapFields = new frmMapFields(fileName, worksheet, quote, PlacePremInIssuanceState);
        try
        {
          frmMapFields.ShowInTaskbar = true;
          int num4 = (int) frmMapFields.ShowDialog();
        }
        finally
        {
          frmMapFields.Dispose();
        }
      }
    }
    finally
    {
      try
      {
        o.Workbooks.Close();
        o.Quit();
        Marshal.ReleaseComObject((object) workbook);
        Marshal.ReleaseComObject((object) o);
      }
      catch (COMException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("The IMS was unable to close the Excel workbook:\n\n" + ex.Message, "Unable to Close Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      Cursor.Current = MgaCursors.Default;
      GC.Collect();
    }
  }
}
