// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormChangeQuoteStatusReason
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormChangeQuoteStatusReason : FormBase
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private int _currentQuoteStatusID;
  private readonly Quote _quote;

  [DebuggerNonUserCode]
  protected virtual void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(disposing));
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.lblCurrentQuoteStatus = new Label();
    this.lblCurrentQuoteStatusReason = new Label();
    this.Label3 = new Label();
    this.cboReason = new MGASimpleComboBox();
    this.ds = new dsChangeQuoteStatusReasons();
    this.txtComments = new MGATextBox();
    this.lblcomments = new Label();
    this.toolTipReason = new ToolTip(this.components);
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.cboReason).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((Control) this).SuspendLayout();
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(44, 84);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(105, 13);
    this.Label2.TabIndex = 11;
    this.Label2.Text = "Select New Reason:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(72, 26);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(77, 13);
    this.Label1.TabIndex = 10;
    this.Label1.Text = "Current Status:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(426, 174);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 15;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(377, 174);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 14;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.lblCurrentQuoteStatus.AutoSize = true;
    this.lblCurrentQuoteStatus.BackColor = Color.Transparent;
    this.lblCurrentQuoteStatus.Location = new Point(155, 26);
    this.lblCurrentQuoteStatus.Name = "lblCurrentQuoteStatus";
    this.lblCurrentQuoteStatus.Size = new Size(106, 13);
    this.lblCurrentQuoteStatus.TabIndex = 16 /*0x10*/;
    this.lblCurrentQuoteStatus.Text = "Current Quote Status";
    this.lblCurrentQuoteStatusReason.AutoSize = true;
    this.lblCurrentQuoteStatusReason.BackColor = Color.Transparent;
    this.lblCurrentQuoteStatusReason.Location = new Point(155, 55);
    this.lblCurrentQuoteStatusReason.Name = "lblCurrentQuoteStatusReason";
    this.lblCurrentQuoteStatusReason.Size = new Size(106, 13);
    this.lblCurrentQuoteStatusReason.TabIndex = 18;
    this.lblCurrentQuoteStatusReason.Text = "Current Quote Status";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(32 /*0x20*/, 55);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(117, 13);
    this.Label3.TabIndex = 19;
    this.Label3.Text = "Current Status Reason:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboReason).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboReason).DataMember = "lstQuoteStatusReasons";
    ((UltraGridBase) this.cboReason).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboReason).DisplayMember = "Reason";
    ((UltraCombo) this.cboReason).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboReason).DropDownWidth = 450;
    ((Control) this.cboReason).Location = new Point(158, 80 /*0x50*/);
    this.cboReason.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboReason).Name = "cboReason";
    ((Control) this.cboReason).Size = new Size(301, 20);
    ((Control) this.cboReason).TabIndex = 12;
    ((UltraControlBase) this.cboReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReason).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboReason).ValueMember = "ID";
    this.ds.DataSetName = "dsChangeQuoteStatusReasons";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Location = new Point(158, 106);
    ((TextEditorControlBase) this.txtComments).MaxLength = 200;
    this.txtComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtComments).Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(217, 91);
    ((Control) this.txtComments).TabIndex = 20;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.lblcomments.AutoSize = true;
    this.lblcomments.BackColor = Color.Transparent;
    this.lblcomments.Location = new Point(47, 108);
    this.lblcomments.Name = "lblcomments";
    this.lblcomments.Size = new Size(59, 13);
    this.lblcomments.TabIndex = 21;
    this.lblcomments.Text = "Comments:";
    this.lblcomments.TextAlign = ContentAlignment.MiddleRight;
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).BackColor = Color.White;
    ((Form) this).ClientSize = new Size(478, 226);
    ((Control) this).Controls.Add((Control) this.lblcomments);
    ((Control) this).Controls.Add((Control) this.txtComments);
    ((Control) this).Controls.Add((Control) this.Label3);
    ((Control) this).Controls.Add((Control) this.lblCurrentQuoteStatusReason);
    ((Control) this).Controls.Add((Control) this.lblCurrentQuoteStatus);
    ((Control) this).Controls.Add((Control) this.btnCancel);
    ((Control) this).Controls.Add((Control) this.btnSave);
    ((Control) this).Controls.Add((Control) this.Label2);
    ((Control) this).Controls.Add((Control) this.Label1);
    ((Control) this).Controls.Add((Control) this.cboReason);
    ((Control) this).Name = nameof (FormChangeQuoteStatusReason);
    ((Form) this).Text = "Change Quote Status Reason";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.cboReason).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((Control) this).ResumeLayout(false);
    ((Control) this).PerformLayout();
  }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboReason")]
  private virtual MGASimpleComboBox cboReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrentQuoteStatus")]
  internal virtual Label lblCurrentQuoteStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrentQuoteStatusReason")]
  internal virtual Label lblCurrentQuoteStatusReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsChangeQuoteStatusReasons ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblcomments")]
  private virtual Label lblcomments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComments")]
  protected virtual MGATextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("toolTipReason")]
  internal virtual ToolTip toolTipReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormChangeQuoteStatusReason(Guid quoteGuid)
  {
    ((Form) this).Load += new EventHandler(this.FormChangeQuoteStatusReason_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>(new object[1]
    {
      (object) this._quoteGuid
    });
  }

  private void FormChangeQuoteStatusReason_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this._currentQuoteStatusID = (int) this._quote.QuoteStatus;
    this.cboReason.DisplayLayout.Bands[0].Override.TipStyleCell = (TipStyle) 1;
    this.lblCurrentQuoteStatus.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM lstQuoteStatus WHERE QuoteStatusID=@ID", new object[2]
    {
      (object) "@ID",
      (object) this._currentQuoteStatusID
    });
    this.DataLoad();
    if (this._quote.HasQuoteStatusReason)
    {
      this.lblCurrentQuoteStatusReason.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Reason FROM lstQuoteStatusReasons WHERE ID=@ID", new object[2]
      {
        (object) "@ID",
        (object) this._quote.QuoteStatusReasonID
      });
      dsChangeQuoteStatusReasons.lstQuoteStatusReasonsRow byId = this.ds.lstQuoteStatusReasons.FindByID(this._quote.QuoteStatusReasonID.Value);
      if (byId == null)
        return;
      this.ds.lstQuoteStatusReasons.RemovelstQuoteStatusReasonsRow(byId);
    }
    else
      this.lblCurrentQuoteStatusReason.Text = "None";
  }

  protected virtual void DataLoad()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstQuoteStatusReasons"
    }, CommandType.Text, "SELECT ID, Reason FROM lstQuoteStatusReasons WHERE (QuoteStatusID = @quoteStatusID) AND ((LineGuid = @LineGuid) OR (LineGuid IS NULL)) ORDER BY Reason", new object[4]
    {
      (object) "@quoteStatusID",
      (object) this._currentQuoteStatusID,
      (object) "@LineGuid",
      (object) this._quote.LineGuid
    });
  }

  protected DataSet GetDataSet() => (DataSet) this.ds;

  protected Guid GetLineGuid() => this._quote.LineGuid;

  protected int GetCurrentQuoteStatusId() => this._currentQuoteStatusID;

  private void btnSave_Click(object sender, EventArgs e)
  {
    bool flag = true;
    if (((UltraGridBase) this.cboReason).Rows.Count > 0 && ((UltraCombo) this.cboReason).Text.Length == 0)
    {
      this.err.SetError((Control) this.cboReason, "Please select a reason");
      flag = false;
    }
    if (!flag)
      return;
    DefaultDatabase.ExecuteNonQuery("spChangeQuoteStatusReason", new object[6]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@QuoteStatusReasonID",
      ((UltraCombo) this.cboReason).Value,
      (object) "@comment",
      (object) ((TextEditorControlBase) this.txtComments).Text
    });
    CurrentUser.Instance.LogAction($"{$"Control #{this._quote.ControlNo.ToString()}. Change Quote Status Reason from '{this.lblCurrentQuoteStatusReason.Text}"}' to '{((UltraCombo) this.cboReason).Text}'", this._quote.QuoteGuid);
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.Quote.QuoteGuid.Equals(this._quote.QuoteGuid))
        frmPolicyDetail.RefreshPolicyData();
      checked { ++index; }
    }
    ((Form) this).Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => ((Form) this).Close();
}
