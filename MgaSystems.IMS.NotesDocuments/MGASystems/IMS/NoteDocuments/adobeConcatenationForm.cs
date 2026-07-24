// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.adobeConcatenationForm
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class adobeConcatenationForm : MGABaseForm
{
  private IContainer components;
  private TabDocumentPanel.FileNode[] _fileNodes;
  private string _newFilename;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGAListBox lstDocs
  {
    get => this._lstDocs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstDocs_SelectedIndexChanged);
      MGAListBox lstDocs1 = this._lstDocs;
      if (lstDocs1 != null)
        lstDocs1.SelectedIndexChanged -= eventHandler;
      this._lstDocs = value;
      MGAListBox lstDocs2 = this._lstDocs;
      if (lstDocs2 == null)
        return;
      lstDocs2.SelectedIndexChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtFilename")]
  internal virtual MGATextBox txtFilename { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RequiredFieldValidator1")]
  internal virtual RequiredFieldValidator RequiredFieldValidator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnUp
  {
    get => this._btnUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUp_Click);
      MGAButton btnUp1 = this._btnUp;
      if (btnUp1 != null)
        ((Control) btnUp1).Click -= eventHandler;
      this._btnUp = value;
      MGAButton btnUp2 = this._btnUp;
      if (btnUp2 == null)
        return;
      ((Control) btnUp2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnDown
  {
    get => this._btnDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDown_Click);
      MGAButton btnDown1 = this._btnDown;
      if (btnDown1 != null)
        ((Control) btnDown1).Click -= eventHandler;
      this._btnDown = value;
      MGAButton btnDown2 = this._btnDown;
      if (btnDown2 == null)
        return;
      ((Control) btnDown2).Click += eventHandler;
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

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      MGAButton btnOk1 = this._btnOk;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOk = value;
      MGAButton btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (adobeConcatenationForm));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.lstDocs = new MGAListBox();
    this.txtFilename = new MGATextBox();
    this.Label1 = new Label();
    this.RequiredFieldValidator1 = new RequiredFieldValidator(this.components);
    this.btnUp = new MGAButton();
    this.btnDown = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnOk = new MGAButton();
    this.Label2 = new Label();
    ((ISupportInitialize) this.lstDocs).BeginInit();
    ((ISupportInitialize) this.txtFilename).BeginInit();
    ((ISupportInitialize) this.RequiredFieldValidator1).BeginInit();
    ((ISupportInitialize) this.btnUp).BeginInit();
    ((ISupportInitialize) this.btnDown).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    this.SuspendLayout();
    this.lstDocs.IntegralHeight = false;
    this.lstDocs.Location = new Point(8, 38);
    this.lstDocs.MGAStyle = MGAStyles.Blue;
    this.lstDocs.Name = "lstDocs";
    this.lstDocs.Size = new Size(256 /*0x0100*/, 218);
    this.lstDocs.TabIndex = 1;
    appearance1.BackColor = Color.LightYellow;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFilename).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtFilename).BackColor = Color.LightYellow;
    ((Control) this.txtFilename).Location = new Point(84, 264);
    this.txtFilename.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFilename).Name = "txtFilename";
    ((Control) this.txtFilename).Size = new Size(180, 20);
    ((Control) this.txtFilename).TabIndex = 6;
    ((UltraControlBase) this.txtFilename).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFilename).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(5, 267);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(75, 13);
    this.Label1.TabIndex = 7;
    this.Label1.Text = "New filename:";
    this.RequiredFieldValidator1.ControlToValidate = (Control) this.txtFilename;
    this.RequiredFieldValidator1.Enabled = true;
    this.RequiredFieldValidator1.ErrorMessage = "You must choose a filename";
    this.RequiredFieldValidator1.FieldToValidate = "Text";
    this.RequiredFieldValidator1.InvalidBackcolor = Color.White;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUp).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnUp).Location = new Point(272, 88);
    ((Control) this.btnUp).Name = "btnUp";
    ((Control) this.btnUp).Size = new Size(87, 24);
    ((Control) this.btnUp).TabIndex = 8;
    ((ControlBase) this.btnUp).Text = "Move Up";
    this.btnUp.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance13.Image"));
    appearance3.ImageHAlign = (HAlign) 1;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDown).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnDown).Location = new Point(272, 120);
    ((Control) this.btnDown).Name = "btnDown";
    ((Control) this.btnDown).Size = new Size(87, 24);
    ((Control) this.btnDown).TabIndex = 9;
    ((ControlBase) this.btnDown).Text = "Move Down";
    this.btnDown.UseOSThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnCancel).Location = new Point(128 /*0x80*/, 296);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnCancel).TabIndex = 10;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnOk).Location = new Point(200, 296);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(64 /*0x40*/, 24);
    ((Control) this.btnOk).TabIndex = 11;
    ((ControlBase) this.btnOk).Text = "Ok";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 8.25f);
    this.Label2.Location = new Point(8, 13);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(186, 13);
    this.Label2.TabIndex = 12;
    this.Label2.Text = "How would you like to order the files?";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(371, 328);
    this.Color1 = Color.FromArgb(198, 212, 230);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnDown);
    this.Controls.Add((Control) this.btnUp);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtFilename);
    this.Controls.Add((Control) this.lstDocs);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (adobeConcatenationForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "File Ordering";
    ((ISupportInitialize) this.lstDocs).EndInit();
    ((ISupportInitialize) this.txtFilename).EndInit();
    ((ISupportInitialize) this.RequiredFieldValidator1).EndInit();
    ((ISupportInitialize) this.btnUp).EndInit();
    ((ISupportInitialize) this.btnDown).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal adobeConcatenationForm(TabDocumentPanel.FileNode[] fileNodes)
  {
    this.Load += new EventHandler(this.adobeConcatenationForm_Load);
    this.Closing += new CancelEventHandler(this.adobeConcatenationForm_Closing);
    this.InitializeComponent();
    this._fileNodes = fileNodes;
  }

  private void adobeConcatenationForm_Load(object sender, EventArgs e)
  {
    this.lstDocs.Items.Clear();
    TabDocumentPanel.FileNode[] fileNodes = this._fileNodes;
    int index = 0;
    while (index < fileNodes.Length)
    {
      this.lstDocs.Items.Add((object) fileNodes[index]);
      checked { ++index; }
    }
    if (this.lstDocs.Items.Count <= 0)
      return;
    this.lstDocs.SelectedIndex = 0;
  }

  internal TabDocumentPanel.FileNode[] GetFileNodesToDownload()
  {
    List<TabDocumentPanel.FileNode> fileNodeList = new List<TabDocumentPanel.FileNode>();
    try
    {
      foreach (TabDocumentPanel.FileNode fileNode in this.lstDocs.Items)
        fileNodeList.Add(fileNode);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return fileNodeList.ToArray();
  }

  public string NewFileName => this._newFilename;

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.RequiredFieldValidator1.Validate();
    if (!this.RequiredFieldValidator1.IsValid)
      return;
    this._newFilename = ((TextEditorControlBase) this.txtFilename).Text;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnUp_Click(object sender, EventArgs e)
  {
    if (this.lstDocs.SelectedItem == null)
      return;
    int selectedIndex = this.lstDocs.SelectedIndex;
    object objectValue = RuntimeHelpers.GetObjectValue(this.lstDocs.Items[selectedIndex]);
    this.lstDocs.Items.Remove(RuntimeHelpers.GetObjectValue(objectValue));
    int index = selectedIndex - 1;
    this.lstDocs.Items.Insert(index, RuntimeHelpers.GetObjectValue(objectValue));
    this.lstDocs.SelectedIndex = index;
  }

  private void btnDown_Click(object sender, EventArgs e)
  {
    if (this.lstDocs.SelectedItem == null)
      return;
    int selectedIndex = this.lstDocs.SelectedIndex;
    object objectValue = RuntimeHelpers.GetObjectValue(this.lstDocs.Items[selectedIndex]);
    this.lstDocs.Items.Remove(RuntimeHelpers.GetObjectValue(objectValue));
    int index = selectedIndex + 1;
    this.lstDocs.Items.Insert(index, RuntimeHelpers.GetObjectValue(objectValue));
    this.lstDocs.SelectedIndex = index;
  }

  private void lstDocs_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.lstDocs.Items.Count > 0)
    {
      ((Control) this.btnUp).Enabled = this.lstDocs.SelectedIndex != 0;
      ((Control) this.btnDown).Enabled = this.lstDocs.SelectedIndex < this.lstDocs.Items.Count - 1;
    }
    else
    {
      ((Control) this.btnDown).Enabled = false;
      ((Control) this.btnUp).Enabled = false;
    }
  }

  private void adobeConcatenationForm_Closing(object sender, CancelEventArgs e)
  {
  }
}
