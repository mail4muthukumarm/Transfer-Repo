// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormChangeSubmissionContact
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormChangeSubmissionContact : Form
{
  private IContainer components;
  private dsNewSubmissionGroup _dsSource;
  private Guid _currProducerLocationGuid;
  private int _currContactID;
  private bool _clickedSave;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormChangeSubmissionContact));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtContacts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactStatusID", -1, (object) "ddStatus");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Selected");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStatus", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Status");
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.ug = new UltraGrid();
    this.dsContact = new dsNewSubmissionGroup();
    this.lblCurrContact = new Label();
    this.lblContact = new Label();
    this.ddStatus = new UltraDropDown();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.dsContact.BeginInit();
    ((ISupportInitialize) this.ddStatus).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(513, 345);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 11;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(562, 345);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(42, 42);
    ((Control) this.btnCancel).TabIndex = 12;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "dtContacts";
    ((UltraGridBase) this.ug).DataSource = (object) this.dsContact;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 375;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 167;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 135;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(12, 54);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(595, 258);
    ((Control) this.ug).TabIndex = 61;
    ((Control) this.ug).Text = "Available Submission Contacts";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.dsContact.DataSetName = "dsNewSubmissionGroup";
    this.dsContact.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblCurrContact.AutoSize = true;
    this.lblCurrContact.Location = new Point(12, 18);
    this.lblCurrContact.Name = "lblCurrContact";
    this.lblCurrContact.Size = new Size(90, 13);
    this.lblCurrContact.TabIndex = 62;
    this.lblCurrContact.Text = "Current Contact - ";
    this.lblContact.AutoSize = true;
    this.lblContact.Location = new Point(108, 18);
    this.lblContact.Name = "lblContact";
    this.lblContact.Size = new Size(33, 13);
    this.lblContact.TabIndex = 63 /*0x3F*/;
    this.lblContact.Text = "None";
    ((UltraGridBase) this.ddStatus).DataMember = "lstStatus";
    ((UltraGridBase) this.ddStatus).DataSource = (object) this.dsContact;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddStatus).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddStatus).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddStatus).DisplayMember = "Status";
    ((UltraDropDownBase) this.ddStatus).DropDownWidth = 300;
    ((Control) this.ddStatus).Location = new Point(208 /*0xD0*/, 171);
    ((Control) this.ddStatus).Name = "ddStatus";
    ((Control) this.ddStatus).Size = new Size(203, 57);
    ((Control) this.ddStatus).TabIndex = 203;
    ((UltraDropDownBase) this.ddStatus).ValueMember = "StatusID";
    ((Control) this.ddStatus).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(619, 399);
    this.Controls.Add((Control) this.ddStatus);
    this.Controls.Add((Control) this.lblContact);
    this.Controls.Add((Control) this.lblCurrContact);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnCancel);
    this.Name = nameof (FormChangeSubmissionContact);
    this.Text = "Change Submission Group Contact";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.dsContact.EndInit();
    ((ISupportInitialize) this.ddStatus).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAButton btnSave
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

  protected virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("ug")]
  protected virtual UltraGrid ug { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsContact")]
  internal virtual dsNewSubmissionGroup dsContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrContact")]
  internal virtual Label lblCurrContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblContact")]
  internal virtual Label lblContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddStatus")]
  protected virtual UltraDropDown ddStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public int ContactID
  {
    get
    {
      int contactId;
      foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
      {
        if (row.Cells["Selected"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Selected"].Value))
        {
          contactId = Conversions.ToInteger(row.Cells["ProducerContactID"].Value);
          goto label_5;
        }
      }
      contactId = int.MinValue;
label_5:
      return contactId;
    }
  }

  public bool ClickedSave => this._clickedSave;

  public FormChangeSubmissionContact(
    dsNewSubmissionGroup dsSource,
    Guid currProducerLocationGuid,
    int currContactID)
  {
    this.Load += new EventHandler(this.FormChangeSubmissionContact_Load);
    this._clickedSave = false;
    this.InitializeComponent();
    this._dsSource = dsSource;
    this._currProducerLocationGuid = currProducerLocationGuid;
    this._currContactID = currContactID;
  }

  private void FormChangeSubmissionContact_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsContact, new string[1]
    {
      "lstStatus"
    }, CommandType.Text, "select StatusID, Status from lstStatus order by status");
    try
    {
      foreach (dsNewSubmissionGroup.tblProducerLocationsRow row in this._dsSource.tblProducerLocations.Rows)
      {
        if (row.ProducerLocationGUID.Equals(this._currProducerLocationGuid) && row.ProducerContactID != this._currContactID)
          this.dsContact.dtContacts.AdddtContactsRow(row.ProducerContact, row.ProducerContactID, row.StatusID, false);
        if (row.ProducerContactID == this._currContactID)
          this.lblContact.Text = row.ProducerContact;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ProcessRows();
  }

  private void ProcessRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
    {
      if (Conversions.ToInteger(row.Cells["ContactStatusID"].Value) != 1)
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        ultraGridRow.Appearance.ForeColor = Color.Red;
        ultraGridRow.Activation = (Activation) 3;
      }
    }
  }

  private bool IsValid()
  {
    int num1 = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
    {
      if (row.Cells["Selected"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Selected"].Value))
        ++num1;
    }
    bool flag;
    if (num1 > 1)
    {
      int num2 = (int) MessageBox.Show("Only one contact can be selected.", "Select Only One Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._clickedSave = false;
    if (!this.IsValid())
      return;
    this._clickedSave = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._clickedSave = false;
    this.Close();
  }
}
