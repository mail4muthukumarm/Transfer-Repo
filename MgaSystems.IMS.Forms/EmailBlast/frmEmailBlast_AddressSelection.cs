// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.EmailBlast.frmEmailBlast_AddressSelection
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.EmailBlast;

public class frmEmailBlast_AddressSelection : Form
{
  private IContainer components;
  private readonly ArrayList _SelectedEmails;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstAddresses")]
  internal virtual MGAListBox lstAddresses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstSendTo")]
  internal virtual MGAListBox lstSendTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("btnCancel")]
  internal virtual MGAButton btnCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnAdd
  {
    get => this._btnAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      MGAButton btnAdd1 = this._btnAdd;
      if (btnAdd1 != null)
        ((Control) btnAdd1).Click -= eventHandler;
      this._btnAdd = value;
      MGAButton btnAdd2 = this._btnAdd;
      if (btnAdd2 == null)
        return;
      ((Control) btnAdd2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnRemove
  {
    get => this._btnRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemove_Click);
      MGAButton btnRemove1 = this._btnRemove;
      if (btnRemove1 != null)
        ((Control) btnRemove1).Click -= eventHandler;
      this._btnRemove = value;
      MGAButton btnRemove2 = this._btnRemove;
      if (btnRemove2 == null)
        return;
      ((Control) btnRemove2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.lstAddresses = new MGAListBox();
    this.lstSendTo = new MGAListBox();
    this.btnAdd = new MGAButton();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnRemove = new MGAButton();
    ((ISupportInitialize) this.lstAddresses).BeginInit();
    ((ISupportInitialize) this.lstSendTo).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnRemove).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(152, 16 /*0x10*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Select name  from list:";
    this.Label2.Location = new Point(232, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Message Recipients";
    this.lstAddresses.Location = new Point(8, 32 /*0x20*/);
    this.lstAddresses.Name = "lstAddresses";
    this.lstAddresses.Size = new Size(152, 158);
    this.lstAddresses.TabIndex = 4;
    this.lstSendTo.Location = new Point(224 /*0xE0*/, 32 /*0x20*/);
    this.lstSendTo.Name = "lstSendTo";
    this.lstSendTo.Size = new Size(152, 158);
    this.lstSendTo.TabIndex = 5;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnAdd).Location = new Point(168, 88);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(48 /*0x30*/, 20);
    ((Control) this.btnAdd).TabIndex = 6;
    ((ControlBase) this.btnAdd).Text = "->";
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOk).Location = new Point(224 /*0xE0*/, 200);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(72, 24);
    ((Control) this.btnOk).TabIndex = 7;
    ((ControlBase) this.btnOk).Text = "OK";
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(304, 200);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(72, 24);
    ((Control) this.btnCancel).TabIndex = 8;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnRemove).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnRemove).Location = new Point(168, 112 /*0x70*/);
    ((Control) this.btnRemove).Name = "btnRemove";
    ((Control) this.btnRemove).Size = new Size(48 /*0x30*/, 20);
    ((Control) this.btnRemove).TabIndex = 9;
    ((ControlBase) this.btnRemove).Text = "<-";
    this.AcceptButton = (IButtonControl) this.btnOk;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(386, 231);
    this.Controls.Add((Control) this.btnRemove);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.lstSendTo);
    this.Controls.Add((Control) this.lstAddresses);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEmailBlast_AddressSelection);
    this.ShowInTaskbar = false;
    this.Text = "Select Names";
    ((ISupportInitialize) this.lstAddresses).EndInit();
    ((ISupportInitialize) this.lstSendTo).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnRemove).EndInit();
    this.ResumeLayout(false);
  }

  public ArrayList SendList => this._SelectedEmails;

  public frmEmailBlast_AddressSelection()
  {
    this.Load += new EventHandler(this.frmEmailBlast_AddressSelection_Load);
    this.InitializeComponent();
  }

  public frmEmailBlast_AddressSelection(ArrayList SelectedEmails)
  {
    this.Load += new EventHandler(this.frmEmailBlast_AddressSelection_Load);
    this.InitializeComponent();
    this._SelectedEmails = SelectedEmails;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (this.lstAddresses.SelectedItems.Count != 1)
      return;
    this._SelectedEmails.Add((object) new EmailAddress(((DataRowView) this.lstAddresses.SelectedItem)[0].ToString(), this.lstAddresses.SelectedValue.ToString()));
    this.RefreshSendToEmails();
  }

  private void btnRemove_Click(object sender, EventArgs e)
  {
    if (this.lstSendTo.SelectedItems.Count != 1)
      return;
    this._SelectedEmails.RemoveAt(this.lstSendTo.SelectedIndex);
    this.RefreshSendToEmails();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void frmEmailBlast_AddressSelection_Load(object sender, EventArgs e)
  {
    this.lstAddresses.DisplayMember = "Name";
    this.lstAddresses.ValueMember = "Email";
    this.lstAddresses.DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "select ISNULL(Fname + @S, @ES) + ISNULL(LName, @ES) AS Name, Email from tblProducerContacts where not (Email is null) UNION select Name, Email from tblProducerLocations where not (Email is null) order by name asc", new object[4]
    {
      (object) "@ES",
      (object) "",
      (object) "@S",
      (object) " "
    });
    this.RefreshSendToEmails();
  }

  private void RefreshSendToEmails()
  {
    this.lstSendTo.DataSource = (object) null;
    this.lstSendTo.DataSource = (object) this._SelectedEmails;
  }
}
