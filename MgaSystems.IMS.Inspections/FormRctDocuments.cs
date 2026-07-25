// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormRctDocuments
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerGenerated]
public class FormRctDocuments : Form
{
  private IContainer components;
  private Quote _quote;
  private string _UserName;
  private string _Password;
  private string _Url;
  private int _controlNo;
  private RctInspections _rctClass;
  private List<string> _selectedFiles;
  private List<string> _fileAttachments;

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
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRctDocuments));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Survey");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Account");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FileName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DocumentStoreGuid");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.Label1 = new Label();
    this.panelSearch = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    this.btnSave = new MGAButton();
    this.dg = new UltraGrid();
    this.ds = new dsDocs();
    this.Label2 = new Label();
    Label label = new Label();
    ((ISupportInitialize) this.panelSearch).BeginInit();
    ((Control) this.panelSearch).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(103, 16 /*0x10*/);
    label.Name = "Label27";
    label.Size = new Size(224 /*0xE0*/, 19);
    label.TabIndex = 1;
    label.Text = "Uploading files ... Please Wait.";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(217, 21);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(176 /*0xB0*/, 15);
    this.Label1.TabIndex = 37;
    this.Label1.Text = "Select files to send to RCT";
    this.panelSearch.BackColorInternal = Color.White;
    appearance1.BorderColor = Color.Gray;
    this.panelSearch.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.panelSearch).Controls.Add((Control) this.spinner);
    ((Control) this.panelSearch).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelSearch).Controls.Add((Control) label);
    ((Control) this.panelSearch).ForeColor = Color.Black;
    ((Control) this.panelSearch).Location = new Point(113, 140);
    ((Control) this.panelSearch).Name = "panelSearch";
    ((Control) this.panelSearch).Size = new Size(501, 148);
    ((Control) this.panelSearch).TabIndex = 117;
    ((Control) this.panelSearch).Visible = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(177, 98);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(60, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(6, 45);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(489, 40);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Gathering files to upload ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(694, 619);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(70, 34);
    ((Control) this.btnSave).TabIndex = 118;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dg).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dg).DataMember = "dt";
    ((UltraGridBase) this.dg).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 86;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(12, 57);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(752, 414);
    ((Control) this.dg).TabIndex = 119;
    this.ds.DataSetName = "dsDocs";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(9, 525);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(184, 15);
    this.Label2.TabIndex = 120;
    this.Label2.Text = "Select \"Survey\" or \"Account\"";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(776, 665);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.panelSearch);
    this.Controls.Add((Control) this.dg);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Name = nameof (FormRctDocuments);
    this.Text = nameof (FormRctDocuments);
    ((ISupportInitialize) this.panelSearch).EndInit();
    ((Control) this.panelSearch).ResumeLayout(false);
    ((Control) this.panelSearch).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSearch")]
  private virtual UltraGroupBox panelSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("dg")]
  protected virtual UltraGrid dg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDocs ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormRctDocuments(Quote q, string un, string pw, string url, RctInspections rctClass)
  {
    this.Load += new EventHandler(this.FormRctDocuments_Load);
    this._UserName = string.Empty;
    this._Password = string.Empty;
    this._Url = string.Empty;
    this._selectedFiles = new List<string>();
    this._fileAttachments = new List<string>();
    this.InitializeComponent();
    this._quote = q;
    this._UserName = un;
    this._Password = pw;
    this._Url = url;
    this._controlNo = this._quote.ControlNo;
    this._rctClass = rctClass;
  }

  public List<string> FilesAttached => this._fileAttachments;

  private void FormRctDocuments_Load(object sender, EventArgs e)
  {
    List<string> stringList = new List<string>();
    stringList.Add("pdf");
    stringList.Add("docx");
    stringList.Add("doc");
    stringList.Add("xlsx");
    stringList.Add("xls");
    stringList.Add("dwg");
    List<DocListItem> docListItemList = new List<DocListItem>();
    List<DocListItem> docItemList = AdditionalDoc.GetDocItemList(this._quote.ControlGuid);
    try
    {
      foreach (DocListItem docListItem in docItemList)
      {
        string[] strArray = docListItem.AttachmentFileName.Split(".".ToCharArray());
        if (strArray.Length > 1 && stringList.Contains(strArray[strArray.Length - 1]))
          this.ds.dt.AdddtRow(false, false, docListItem.AttachmentFileName, docListItem.DocumentStoreGuid);
      }
    }
    finally
    {
      List<DocListItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    string empty1 = string.Empty;
    int num1 = 2;
    try
    {
      ((Control) this.panelSearch).Visible = true;
      try
      {
        foreach (dsDocs.dtRow row in this.ds.dt.Rows)
        {
          if ((!row.IsAccountNull() || !row.IsSurveyNull()) && (row.IsAccountNull() || row.Account || row.IsSurveyNull() || row.Survey))
          {
            string file = DocumentManager.SaveDocumentToFile(row.DocumentStoreGuid);
            this.RefreshPanel("Uploading " + file);
            bool flag = false;
            if (!row.IsAccountNull())
              flag = row.Account;
            string mgaTempPath = MGATempFolder.MGATempPath;
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            string str1 = (!flag ? this._rctClass.GetInspectionUniqueIdentifier : this._rctClass.GetClientUniqueIdentifier).Replace(":", string.Empty).Replace("/", string.Empty).Replace(" ", string.Empty).Replace("%", string.Empty);
            string[] strArray = file.Split("\\\\".ToCharArray());
            string str2 = strArray[strArray.Length - 1];
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            int index1 = 0;
            while (index1 < invalidFileNameChars.Length)
            {
              char ch = invalidFileNameChars[index1];
              str2 = str2.Replace(Conversions.ToString(ch), string.Empty);
              checked { ++index1; }
            }
            string str3 = $"{mgaTempPath}{str1}_{str2}";
            if (File.Exists(str3))
              File.Delete(str3);
            File.Move(file, str3);
            this._fileAttachments.Add(str3);
            int num2 = num1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.RefreshPanel("Please wait. Uploading " + str3);
              Thread.Sleep(1000);
              this.RefreshPanel("Please wait. Uploading " + str3);
            }
            this.RefreshPanel("Please wait. Uploading " + str3);
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception innerException = ex;
      ErrorHandler.SilentHandleError(new Exception($"Failed to upload file to \"{this._Url}\"", innerException));
      int num3 = (int) MessageBox.Show("Could not transfer file at this moment because of the following reasons:\n\n" + innerException.Message, "Could Not Complete Transfer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ProjectData.ClearProjectError();
    }
    finally
    {
      ((Control) this.panelSearch).Visible = false;
    }
    this.Close();
  }

  private void RefreshPanel(string searchText)
  {
    this.labelSearchText.Text = searchText;
    ((UltraControlBase) this.panelSearch).Refresh();
  }
}
