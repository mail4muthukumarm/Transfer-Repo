// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmChangeQuoteStatus
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmChangeQuoteStatus : Form
{
  private IContainer components;
  protected Label Label1;
  protected Label Label2;
  protected MGASimpleComboBox cboReason;
  protected dsChangeQuoteStatus ds;
  protected ErrorProvider err;
  protected Label Label3;
  protected MGATextBox txtComments;
  protected UltraLabel lblNewStatus;
  private readonly Guid _quoteGuid;
  private bool _statusChanged;
  protected int _quoteStatusID;
  protected bool _reasonRequired;
  protected readonly Quote _quote;
  private bool _isNonRenewedStatus;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpMailingDate")]
  protected virtual MGADateTimePicker dtpMailingDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkPopulatewithPrevCom
  {
    get => this._lnkPopulatewithPrevCom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPopulatewithPrevCom_LinkClicked);
      LinkLabel populatewithPrevCom1 = this._lnkPopulatewithPrevCom;
      if (populatewithPrevCom1 != null)
        populatewithPrevCom1.LinkClicked -= clickedEventHandler;
      this._lnkPopulatewithPrevCom = value;
      LinkLabel populatewithPrevCom2 = this._lnkPopulatewithPrevCom;
      if (populatewithPrevCom2 == null)
        return;
      populatewithPrevCom2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("tmpToolTip")]
  private virtual ToolTip tmpToolTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.ds = new dsChangeQuoteStatus();
    this.cboReason = new MGASimpleComboBox();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.Label3 = new Label();
    this.txtComments = new MGATextBox();
    this.lblNewStatus = new UltraLabel();
    this.Label4 = new Label();
    this.dtpMailingDate = new MGADateTimePicker();
    this.lnkPopulatewithPrevCom = new LinkLabel();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboReason).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.dtpMailingDate).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(7, 11);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(66, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "New Status:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(7, 39);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(47, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Reason:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.ds.DataSetName = "dsChangeQuoteStatus";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraCombo) this.cboReason).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboReason).DataSource = (object) this.ds.lstQuoteStatusReasons;
    ((UltraDropDownBase) this.cboReason).DisplayMember = "Reason";
    ((UltraCombo) this.cboReason).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboReason).DropDownWidth = 300;
    ((Control) this.cboReason).Location = new Point(84, 35);
    this.cboReason.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboReason).Name = "cboReason";
    ((Control) this.cboReason).Size = new Size(217, 21);
    ((Control) this.cboReason).TabIndex = 1;
    ((UltraControlBase) this.cboReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReason).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboReason).ValueMember = "ID";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(315, 146);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(364, 146);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 5;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(7, 97);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(61, 13);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Comments:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Location = new Point(84, 97);
    ((TextEditorControlBase) this.txtComments).MaxLength = 300;
    this.txtComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtComments).Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(217, 91);
    ((Control) this.txtComments).TabIndex = 3;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((AppearanceBase) appearance4).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblNewStatus).Appearance = (AppearanceBase) appearance4;
    this.lblNewStatus.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblNewStatus).Location = new Point(84, 7);
    ((Control) this.lblNewStatus).Name = "lblNewStatus";
    ((Control) this.lblNewStatus).Size = new Size(217, 20);
    ((Control) this.lblNewStatus).TabIndex = 0;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(7, 69);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(69, 13);
    this.Label4.TabIndex = 12;
    this.Label4.Text = "Mailing Date:";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpMailingDate).Appearance = (AppearanceBase) appearance5;
    appearance6.AlphaLevel = (short) 14;
    appearance6.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance6.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance6.BackColorAlpha = (Alpha) 2;
    appearance6.BackGradientAlignment = (GradientAlignment) 4;
    appearance6.BackGradientStyle = (GradientStyle) 5;
    appearance6.BorderAlpha = (Alpha) 1;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    appearance6.ForeColor = Color.FromArgb(49, 85, 153);
    appearance6.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpMailingDate).ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtpMailingDate).Location = new Point(84, 65);
    this.dtpMailingDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpMailingDate).Name = "dtpMailingDate";
    ((Control) this.dtpMailingDate).Size = new Size(89, 20);
    ((Control) this.dtpMailingDate).TabIndex = 2;
    ((UltraControlBase) this.dtpMailingDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpMailingDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpMailingDate).Value = (object) null;
    this.lnkPopulatewithPrevCom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPopulatewithPrevCom.Location = new Point(7, 110);
    this.lnkPopulatewithPrevCom.Name = "lnkPopulatewithPrevCom";
    this.lnkPopulatewithPrevCom.Size = new Size(71, 53);
    this.lnkPopulatewithPrevCom.TabIndex = 18;
    this.lnkPopulatewithPrevCom.TabStop = true;
    this.lnkPopulatewithPrevCom.Text = "Populate with Previous Comment";
    this.lnkPopulatewithPrevCom.TextAlign = ContentAlignment.MiddleLeft;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(414, 197);
    this.Controls.Add((Control) this.lnkPopulatewithPrevCom);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.dtpMailingDate);
    this.Controls.Add((Control) this.lblNewStatus);
    this.Controls.Add((Control) this.txtComments);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.cboReason);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmChangeQuoteStatus);
    this.ShowInTaskbar = false;
    this.Text = "Change Quote Status";
    this.ds.EndInit();
    ((ISupportInitialize) this.cboReason).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.dtpMailingDate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public bool StatusChanged => this._statusChanged;

  public int QuoteStatusID
  {
    get => this._quoteStatusID;
    protected set => this._quoteStatusID = value;
  }

  public Guid LineGuid => this._quote.LineGuid;

  protected bool ReasonRequired
  {
    get => this._reasonRequired;
    set => this._reasonRequired = value;
  }

  protected Quote Quote => this._quote;

  public frmChangeQuoteStatus(Guid quoteGuid, int quoteStatusID)
  {
    this.Load += new EventHandler(this.frmChangeQuoteStatus_Load);
    this._quoteGuid = Guid.Empty;
    this._reasonRequired = true;
    this._isNonRenewedStatus = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._quoteStatusID = quoteStatusID;
    this._quote = new Quote(quoteGuid);
  }

  public frmChangeQuoteStatus(Guid quoteGuid)
    : this(quoteGuid, 0)
  {
  }

  public frmChangeQuoteStatus()
  {
    this.Load += new EventHandler(this.frmChangeQuoteStatus_Load);
    this._quoteGuid = Guid.Empty;
    this._reasonRequired = true;
    this._isNonRenewedStatus = false;
    this.InitializeComponent();
  }

  private void frmChangeQuoteStatus_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this.cboReason.DisplayLayout.Bands[0].Override.TipStyleCell = (TipStyle) 1;
    this._isNonRenewedStatus = this.QuoteStatusID == 17;
    ((Control) this.dtpMailingDate).Enabled = this._isNonRenewedStatus;
    if (this._isNonRenewedStatus)
      ((UltraDateTimeEditor) this.dtpMailingDate).Value = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT NonRenewedMailingDate FROM dbo.tblQuotes2 WHERE QuoteID = @QID", new object[2]
      {
        (object) "@QID",
        (object) this._quote.QuoteID
      }));
    ((ControlBase) this.lblNewStatus).Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM lstQuoteStatus WHERE QuoteStatusID=@ID", new object[2]
    {
      (object) "@ID",
      (object) this._quoteStatusID
    });
    this.ShowReasons();
    this.lnkPopulatewithPrevCom.Visible = SystemSettings.GetSetting<bool>("Policy.Show.PreviousQuoteStatusReasonLink", false);
    this.FormLoadOnClient();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      if (!this.ValidForm())
        return;
      this._quote.QuoteStatus.ToString();
      if (((Control) this.cboReason).Enabled && ((UltraCombo) this.cboReason).Value != null && !string.IsNullOrEmpty(((TextEditorControlBase) this.txtComments).Text))
        this._quote.ChangeStatus(this._quoteStatusID, Conversions.ToInteger(((UltraCombo) this.cboReason).Value), ((TextEditorControlBase) this.txtComments).Text);
      else if (((Control) this.cboReason).Enabled && ((UltraCombo) this.cboReason).Value != null)
        this._quote.ChangeStatus(this._quoteStatusID, Conversions.ToInteger(((UltraCombo) this.cboReason).Value));
      else if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtComments).Text))
        this._quote.ChangeStatus(this._quoteStatusID, ((TextEditorControlBase) this.txtComments).Text);
      else
        this._quote.ChangeStatus(this._quoteStatusID);
      this._statusChanged = true;
      if (this._isNonRenewedStatus)
        DefaultDatabase.ExecuteNonQuery("dbo.spSaveNonRenewedStatusInfo", new object[4]
        {
          (object) "@QuoteID",
          (object) this._quote.QuoteID,
          (object) "@NonRenewedMailingDate",
          ((UltraDateTimeEditor) this.dtpMailingDate).Value
        });
      if (this._quoteStatusID == 4)
        Messaging.SendBroadcastMessage(BroadcastMessages.PolicyDeclined, (object) this._quoteGuid);
      else if (this._quoteStatusID == 17)
        Messaging.SendBroadcastMessage(BroadcastMessages.NonRenewed, (object) this._quoteGuid);
      if (((UltraCombo) this.cboReason).Text.Length > 0)
        CurrentUser.Instance.LogAction("Reason for quote status change: " + ((UltraCombo) this.cboReason).Text, this._quoteGuid);
      this.SaveOnclient();
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show(ex.Message, "Invalid Quote Status Change", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void LoadReasons()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstQuoteStatusReasons, "dbo.GetQuoteStatusReasonsByLine", new object[6]
    {
      (object) "@quoteStatusID",
      (object) this._quoteStatusID,
      (object) "@LineGuid",
      (object) this._quote.LineGuid,
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
  }

  protected virtual void ShowReasons()
  {
    this.LoadReasons();
    this._reasonRequired = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT ReasonRequired FROM lstQuoteStatus WHERE QuoteStatusID = @QS", new object[2]
    {
      (object) "@QS",
      (object) this._quoteStatusID
    });
    ((Control) this.cboReason).Enabled = this.ds.lstQuoteStatusReasons.Count > 0;
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboReason, string.Empty);
    if (this._reasonRequired && ((Control) this.cboReason).Enabled && ((UltraCombo) this.cboReason).Value == null)
    {
      this.err.SetError((Control) this.cboReason, "Please select a reason for this status change.");
      flag = false;
    }
    return flag;
  }

  protected virtual void FormLoadOnClient()
  {
  }

  protected virtual void SaveOnclient()
  {
  }

  private void lnkPopulatewithPrevCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("GetPreviousQuotestatusReasonComment", new object[2]
    {
      (object) "@ControlNo",
      (object) this._quote.ControlNo
    });
    if (Information.IsNothing((object) dataRow) || string.IsNullOrEmpty(dataRow.Field<string>("NewQuoteStatusComment")))
      return;
    ((TextEditorControlBase) this.txtComments).Text = dataRow.Field<string>("NewQuoteStatusComment");
  }
}
