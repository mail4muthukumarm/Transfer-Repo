// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormChangeProducerContact
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormChangeProducerContact : Form
{
  private IContainer components;
  private Guid _producerLocationGuid;
  private Guid _producerContactGuid;
  private int _producerContactID;

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
    this.Label1 = new Label();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.cboContacts = new MGASimpleComboBox();
    this.ds = new dsChooseProducerContact();
    this.Label2 = new Label();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboContacts).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(432, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "The selected producer contact will replace the closed contact on quotes and submissions.";
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
    ((Control) this.btnCancel).Location = new Point(423, 68);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 9;
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
    ((Control) this.btnSave).Location = new Point(375, 68);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 8;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cboContacts.BorderStyle = (UIElementBorderStyle) 4;
    this.cboContacts.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboContacts).DataMember = "ProducerContacts";
    ((UltraGridBase) this.cboContacts).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboContacts).DisplayMember = "ContactName";
    this.cboContacts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboContacts).Location = new Point(111, 36);
    this.cboContacts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboContacts).Name = "cboContacts";
    ((Control) this.cboContacts).Size = new Size(335, 20);
    ((Control) this.cboContacts).TabIndex = 10;
    ((UltraControlBase) this.cboContacts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboContacts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboContacts).ValueMember = "ProducerContactID";
    this.ds.DataSetName = "dsChooseProducerContact";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(12, 40);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(93, 13);
    this.Label2.TabIndex = 11;
    this.Label2.Text = "Producer Contact:";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(467, 120);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cboContacts);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormChangeProducerContact);
    this.Text = "Change Producer Contact";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboContacts).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("cboContacts")]
  private virtual MGASimpleComboBox cboContacts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsChooseProducerContact ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormChangeProducerContact(Guid producerLocationGuid, Guid producerContactGuid)
  {
    this.Load += new EventHandler(this.FormChangeProducerContact_Load);
    this.InitializeComponent();
    this._producerLocationGuid = producerLocationGuid;
    this._producerContactGuid = producerContactGuid;
  }

  private void FormChangeProducerContact_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "ProducerContacts"
    }, CommandType.Text, "SELECT ProducerContactID, ProducerContactGUID, LName + @c +  FName AS ContactName FROM tblProducerContacts WITH (NOLOCK) WHERE ProducerLocationGUID= @PLG AND ProducerContactGUID <> @PC AND StatusID =1 ", new object[6]
    {
      (object) "@PLG",
      (object) this._producerLocationGuid,
      (object) "@PC",
      (object) this._producerContactGuid,
      (object) "@c",
      (object) ", "
    });
    if (this.ds.ProducerContacts.Count != 1)
      return;
    this.cboContacts.Value = (object) this.ds.ProducerContacts[0].ProducerContactID;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(this.cboContacts.Text))
    {
      this.err.SetError((Control) this.cboContacts, "Please choose a contact");
    }
    else
    {
      this.err.SetError((Control) this.cboContacts, string.Empty);
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteGUID, QuoteID FROM tblQuotes WITH (NOLOCK) WHERE (ProducerContactGuid = @oldContactGuid) AND (QuoteID = (SELECT MaxQuoteID FROM tblMaxQuoteIDs AS MQI WHERE (ControlNo = dbo.tblQuotes.ControlNo)))", new object[2]
      {
        (object) "@oldContactGuid",
        (object) this._producerContactGuid
      });
      this._producerContactID = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ProducerContactID, ProducerContactGUID, LName + @C +  FName AS ContactName FROM tblProducerContacts WITH (NOLOCK) WHERE ProducerContactGUID = @PC ", new object[4]
      {
        (object) "@PC",
        (object) this._producerContactGuid,
        (object) "@C",
        (object) ", "
      });
      dsChooseProducerContact.ProducerContactsRow producerContactId = this.ds.ProducerContacts.FindByProducerContactID(Conversions.ToInteger(this.cboContacts.Value));
      DefaultDatabase.ExecuteNonQuery("dbo.UpdateProducerContacts", new object[8]
      {
        (object) "@oldContactGuid",
        (object) this._producerContactGuid,
        (object) "@newContactGuid",
        (object) producerContactId.ProducerContactGUID,
        (object) "@oldContactID",
        (object) this._producerContactID,
        (object) "@newContactID",
        (object) producerContactId.ProducerContactID
      });
      string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LName + @spc + FName AS PName FROM tblProducerContacts WHERE ProducerContactGUID = @PC", new object[4]
      {
        (object) "@PC",
        (object) this._producerContactGuid,
        (object) "@spc",
        (object) ", "
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          Quote quote = new Quote(Conversions.ToInteger(row[1]));
          CurrentUser.Instance.LogAction($"Change producer contact on control# {quote.ControlNo.ToString()} from {str} to {this.cboContacts.Text}", quote.QuoteGuid);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      List<Guid> quoteGuidList = new List<Guid>();
      Messaging.SendBroadcastMessage(BroadcastMessages.ProducerContactChanged, (object) new ProducerContactChangedContext(this._producerContactGuid, producerContactId.ProducerContactGUID, quoteGuidList));
      this.Close();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
