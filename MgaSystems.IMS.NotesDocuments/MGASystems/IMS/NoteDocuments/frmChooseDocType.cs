// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmChooseDocType
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
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
namespace MGASystems.IMS.NoteDocuments;

[DesignerGenerated]
public class frmChooseDocType : Form
{
  private IContainer components;
  private Guid _typeGuid;

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.cboDocumentType = new MGASimpleComboBox();
    this.Label7 = new Label();
    this.btnOK = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnClearFilter = new MGAButton();
    ((ISupportInitialize) this.cboDocumentType).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnClearFilter).BeginInit();
    this.SuspendLayout();
    this.cboDocumentType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocumentType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDocumentType).Location = new Point(99, 10);
    this.cboDocumentType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDocumentType).Name = "cboDocumentType";
    ((Control) this.cboDocumentType).Size = new Size(254, 20);
    ((Control) this.cboDocumentType).TabIndex = 39;
    ((UltraControlBase) this.cboDocumentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDocumentType).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(7, 12);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(86, 13);
    this.Label7.TabIndex = 38;
    this.Label7.Text = "Document Type:";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnOK).DialogResult = DialogResult.OK;
    ((Control) this.btnOK).Location = new Point(174, 45);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOK).TabIndex = 40;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(273, 45);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancel).TabIndex = 41;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClearFilter).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnClearFilter).DialogResult = DialogResult.OK;
    ((Control) this.btnClearFilter).Location = new Point(10, 45);
    ((Control) this.btnClearFilter).Name = "btnClearFilter";
    ((Control) this.btnClearFilter).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnClearFilter).TabIndex = 42;
    ((ControlBase) this.btnClearFilter).Text = "Clear Filter";
    this.btnClearFilter.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(367, 87);
    this.Controls.Add((Control) this.btnClearFilter);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.cboDocumentType);
    this.Controls.Add((Control) this.Label7);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmChooseDocType);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = "Document Type";
    ((ISupportInitialize) this.cboDocumentType).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnClearFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnOK")]
  private virtual MGAButton btnOK { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCancel")]
  private virtual MGAButton btnCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDocumentType")]
  public virtual MGASimpleComboBox cboDocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnClearFilter
  {
    get => this._btnClearFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClearFilter_Click);
      MGAButton btnClearFilter1 = this._btnClearFilter;
      if (btnClearFilter1 != null)
        ((Control) btnClearFilter1).Click -= eventHandler;
      this._btnClearFilter = value;
      MGAButton btnClearFilter2 = this._btnClearFilter;
      if (btnClearFilter2 == null)
        return;
      ((Control) btnClearFilter2).Click += eventHandler;
    }
  }

  public frmChooseDocType(Guid typeGuid)
  {
    this.Load += new EventHandler(this.frmChooseDocType_Load);
    this.InitializeComponent();
    this._typeGuid = typeGuid;
  }

  public static frmChooseDocType Create(Guid typeGuid)
  {
    return (frmChooseDocType) ObjectFactory.Instance.CreateForm(typeof (frmChooseDocType), new object[1]
    {
      (object) typeGuid
    });
  }

  private void frmChooseDocType_Load(object sender, EventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TypeGUID, TypeName FROM tblDocumentTypes");
    DataRow row = dataTable.NewRow();
    row[0] = (object) Guid.Empty;
    row[1] = (object) "";
    dataTable.Rows.InsertAt(row, 0);
    ((UltraGridBase) this.cboDocumentType).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.cboDocumentType).DisplayMember = "TypeName";
    ((UltraDropDownBase) this.cboDocumentType).ValueMember = "TypeGuid";
    this.cboDocumentType.Value = (object) this._typeGuid;
  }

  private void btnClearFilter_Click(object sender, EventArgs e)
  {
    this.cboDocumentType.Value = (object) Guid.Empty;
    this.DialogResult = DialogResult.OK;
  }
}
