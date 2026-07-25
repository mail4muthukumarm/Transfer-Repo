// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormDuplicateProducerContact
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormDuplicateProducerContact : Form
{
  private IContainer components;
  private readonly Guid _producerContactGuid;
  private readonly Guid _producerLocationGuid;
  private readonly string _cName;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label2 = new Label();
    this.cboProducerLocations = new MGASimpleComboBox();
    this.ds = new dsDuplicateProducerContacat();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.cboProducerLocations).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(12, 17);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(136, 13);
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Choose Producer Location:";
    this.cboProducerLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.cboProducerLocations).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboProducerLocations).DisplayMember = "ProducerLocationName";
    this.cboProducerLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerLocations).Location = new Point(154, 17);
    this.cboProducerLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerLocations).Name = "cboProducerLocations";
    ((Control) this.cboProducerLocations).Size = new Size(424, 20);
    ((Control) this.cboProducerLocations).TabIndex = 14;
    ((UltraControlBase) this.cboProducerLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerLocations).ValueMember = "ProducerLocationGUID";
    this.ds.DataSetName = "dsDuplicateProducerContacat";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(538, 56);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 13;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(490, 56);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 12;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(590, 108);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cboProducerLocations);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormDuplicateProducerContact);
    this.Text = "Duplicating Producer Contact";
    ((ISupportInitialize) this.cboProducerLocations).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerLocations")]
  private virtual MGASimpleComboBox cboProducerLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDuplicateProducerContacat ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormDuplicateProducerContact(
    Guid producerLocationGuid,
    Guid producerContactGuid,
    string contactName)
  {
    this.Load += new EventHandler(this.FormDuplicateProducerContact_Load);
    this.InitializeComponent();
    this._producerLocationGuid = producerLocationGuid;
    this._producerContactGuid = producerContactGuid;
    this._cName = contactName;
    this.Text = $"{this.Text} [{contactName}]";
  }

  private void FormDuplicateProducerContact_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerLocations"
    }, CommandType.Text, "SELECT ProducerLocationGUID,  + Name + @d + Address1 + @c + City + ISNULL(@c + State, @e) AS ProducerLocationName FROM tblProducerLocations WITH (NOLOCK) WHERE ProducerLocationGUID <> @PLG ORDER BY Name", new object[8]
    {
      (object) "@PLG",
      (object) this._producerLocationGuid,
      (object) "@d",
      (object) " - ",
      (object) "@c",
      (object) ", ",
      (object) "@e",
      (object) ""
    });
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private bool IsValidForm()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(this.cboProducerLocations.Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboProducerLocations, "Please select a value.");
    }
    else
      this.err.SetError((Control) this.cboProducerLocations, string.Empty);
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidForm() || MessageBox.Show($"Continue to duplicate contact - {this._cName} ?", "Continue Duplicate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    Guid guid1 = Guid.NewGuid();
    Guid guid2 = (Guid) this.cboProducerLocations.Value;
    try
    {
      DefaultDatabase.ExecuteNonQuery("dbo.DuplicateProducerContact", new object[6]
      {
        (object) "@ProducerLocationGuid",
        (object) guid2,
        (object) "@existingContactGuid",
        (object) this._producerContactGuid,
        (object) "@newContactGuid",
        (object) guid1
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }
}
