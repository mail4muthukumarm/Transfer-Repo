// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Cancellations.Notices.frmNOC
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Cancellations.Notices;

public sealed class frmNOC : Form
{
  private readonly Guid _quoteGuid;
  private frmNOC_BindingManagement _bindings;
  private IContainer components;
  private Label Label2;
  private MGASimpleComboBox cboNoticeType;
  private Label Label1;
  private dsNOC DsNOC;
  private ErrorProvider ErrorProvider1;
  private Label Label3;
  private Label Label4;
  private MGADateTimePicker dtMailingDate;
  private MGADateTimePicker dtCancellationDate;
  private MGAGroupBox MgaGroupBox1;

  [field: AccessedThroughProperty("lblComment")]
  private virtual Label lblComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNOCReasonComment")]
  private virtual MGATextBox txtNOCReasonComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmNOC(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmNOC_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this.InitializeData();
  }

  public frmNOC()
  {
    this.Load += new EventHandler(this.frmNOC_Load);
    this.InitializeComponent();
    this.InitializeData();
  }

  private void InitializeData()
  {
    this._bindings = new frmNOC_BindingManagement((DataSet) this.DsNOC, this.BindingContext);
    this._bindings.BindingMngrlstPolicyCancellationNoticeTypes.SuspendBinding();
    this._bindings.BindingMngrlstQuoteStatusReasons.SuspendBinding();
    DefaultDatabase.LoadDataSet((DataSet) this.DsNOC, new string[1]
    {
      "lstPolicyCancellationNoticeTypes"
    }, CommandType.Text, "SELECT NoticeTypeID, NoticeDescription FROM dbo.lstPolicyCancellationNoticeTypes ORDER BY NoticeDescription");
    if (!SystemSettings.KeyExists("AllowUnderwritingNonPayCancel") && !SystemSettings.GetBoolSetting("AllowUnderwritingNonPayCancel"))
      DefaultDatabase.LoadDataSet((DataSet) this.DsNOC, new string[1]
      {
        "lstQuoteStatusReasons"
      }, CommandType.Text, "SELECT ID, Reason FROM dbo.lstQuoteStatusReasons WHERE (QuoteStatusID = 6) AND (Inactive = 0) AND (AutomationID IS NULL OR AutomationID = @ID) ORDER BY Reason", new object[2]
      {
        (object) "@ID",
        (object) "NPAYUN"
      });
    else
      DefaultDatabase.LoadDataSet((DataSet) this.DsNOC, new string[1]
      {
        "lstQuoteStatusReasons"
      }, CommandType.Text, "SELECT ID, Reason FROM dbo.lstQuoteStatusReasons WHERE (QuoteStatusID = 6) AND (Inactive = 0) AND (AutomationID IS NULL) ORDER BY Reason");
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnIssue
  {
    get => this._btnIssue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnIssue_Click);
      MGAButton btnIssue1 = this._btnIssue;
      if (btnIssue1 != null)
        ((Control) btnIssue1).Click -= eventHandler;
      this._btnIssue = value;
      MGAButton btnIssue2 = this._btnIssue;
      if (btnIssue2 == null)
        return;
      ((Control) btnIssue2).Click += eventHandler;
    }
  }

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

  private virtual MGASimpleComboBox cboReason
  {
    get => this._cboReason;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboReason_ValueChanged);
      MGASimpleComboBox cboReason1 = this._cboReason;
      if (cboReason1 != null)
        ((UltraCombo) cboReason1).ValueChanged -= eventHandler;
      this._cboReason = value;
      MGASimpleComboBox cboReason2 = this._cboReason;
      if (cboReason2 == null)
        return;
      ((UltraCombo) cboReason2).ValueChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNOC));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.btnIssue = new MGAButton();
    this.btnCancel = new MGAButton();
    this.cboReason = new MGASimpleComboBox();
    this.DsNOC = new dsNOC();
    this.Label2 = new Label();
    this.cboNoticeType = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.dtMailingDate = new MGADateTimePicker();
    this.dtCancellationDate = new MGADateTimePicker();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.txtNOCReasonComment = new MGATextBox();
    this.lblComment = new Label();
    ((ISupportInitialize) this.btnIssue).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.cboReason).BeginInit();
    this.DsNOC.BeginInit();
    ((ISupportInitialize) this.cboNoticeType).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.dtMailingDate).BeginInit();
    ((ISupportInitialize) this.dtCancellationDate).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtNOCReasonComment).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnIssue).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.btnIssue).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnIssue).Location = new Point(114, 206);
    ((Control) this.btnIssue).Name = "btnIssue";
    ((Control) this.btnIssue).Size = new Size(91, 25);
    ((Control) this.btnIssue).TabIndex = 5;
    ((ControlBase) this.btnIssue).Text = "Issue";
    this.btnIssue.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(211, 206);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(91, 25);
    ((Control) this.btnCancel).TabIndex = 4;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.cboReason).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.cboReason).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboReason).DataSource = (object) this.DsNOC.lstQuoteStatusReasons;
    ((UltraDropDownBase) this.cboReason).DisplayMember = "Reason";
    ((UltraCombo) this.cboReason).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboReason).Location = new Point(129, 61);
    this.cboReason.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboReason).Name = "cboReason";
    ((Control) this.cboReason).Size = new Size(246, 21);
    ((Control) this.cboReason).TabIndex = 3;
    ((UltraControlBase) this.cboReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReason).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboReason).ValueMember = "ID";
    this.DsNOC.DataSetName = "DsNOC";
    this.DsNOC.Locale = new CultureInfo("en-US");
    this.DsNOC.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(17, 65);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(43, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Reason";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboNoticeType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.cboNoticeType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboNoticeType).DataSource = (object) this.DsNOC.lstPolicyCancellationNoticeTypes;
    ((UltraDropDownBase) this.cboNoticeType).DisplayMember = "NoticeDescription";
    ((UltraCombo) this.cboNoticeType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNoticeType).Location = new Point(129, 27);
    this.cboNoticeType.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboNoticeType).Name = "cboNoticeType";
    ((Control) this.cboNoticeType).Size = new Size(246, 21);
    ((Control) this.cboNoticeType).TabIndex = 1;
    ((UltraControlBase) this.cboNoticeType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNoticeType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboNoticeType).ValueMember = "NoticeTypeID";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(17, 31 /*0x1F*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Notice Type";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtMailingDate).Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtMailingDate).ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtMailingDate).Location = new Point(129, 149);
    this.dtMailingDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtMailingDate).Name = "dtMailingDate";
    ((Control) this.dtMailingDate).Size = new Size(88, 20);
    ((Control) this.dtMailingDate).TabIndex = 6;
    ((UltraControlBase) this.dtMailingDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtMailingDate).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtCancellationDate).Appearance = (AppearanceBase) appearance5;
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
    ((UltraDateTimeEditor) this.dtCancellationDate).ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtCancellationDate).Location = new Point(129, 175);
    this.dtCancellationDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtCancellationDate).Name = "dtCancellationDate";
    ((Control) this.dtCancellationDate).Size = new Size(88, 20);
    ((Control) this.dtCancellationDate).TabIndex = 7;
    ((UltraControlBase) this.dtCancellationDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtCancellationDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(18, 153);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(65, 13);
    this.Label3.TabIndex = 8;
    this.Label3.Text = "Mailing Date";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(18, 179);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(91, 13);
    this.Label4.TabIndex = 9;
    this.Label4.Text = "Cancellation Date";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    appearance7.BackColor = Color.FromArgb(239, 247, 253);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance7;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtNOCReasonComment);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblComment);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnIssue);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboReason);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboNoticeType);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnCancel);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtMailingDate);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtCancellationDate);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label4);
    appearance8.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance8;
    ((Control) this.MgaGroupBox1).Location = new Point(9, 10);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(416, 254);
    ((Control) this.MgaGroupBox1).TabIndex = 10;
    ((UltraGroupBox) this.MgaGroupBox1).Text = "NOC Information";
    ((UltraGroupBox) this.MgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 3;
    ((UltraTextEditor) this.txtNOCReasonComment).AcceptsReturn = true;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNOCReasonComment).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtNOCReasonComment).BackColor = Color.White;
    ((Control) this.txtNOCReasonComment).Location = new Point(129, 90);
    ((TextEditorControlBase) this.txtNOCReasonComment).MaxLength = 2000;
    this.txtNOCReasonComment.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtNOCReasonComment).Multiline = true;
    ((Control) this.txtNOCReasonComment).Name = "txtNOCReasonComment";
    ((UltraTextEditor) this.txtNOCReasonComment).Scrollbars = ScrollBars.Vertical;
    ((Control) this.txtNOCReasonComment).Size = new Size(246, 52);
    ((Control) this.txtNOCReasonComment).TabIndex = 12;
    ((UltraControlBase) this.txtNOCReasonComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNOCReasonComment).UseOsThemes = (DefaultableBoolean) 2;
    this.lblComment.AutoSize = true;
    this.lblComment.BackColor = Color.Transparent;
    this.lblComment.Location = new Point(18, 92);
    this.lblComment.Name = "lblComment";
    this.lblComment.Size = new Size(56, 13);
    this.lblComment.TabIndex = 11;
    this.lblComment.Text = "Comment:";
    this.lblComment.TextAlign = ContentAlignment.MiddleRight;
    this.AcceptButton = (IButtonControl) this.btnIssue;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(434, 276);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNOC);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Notice Of Cancellation";
    ((ISupportInitialize) this.btnIssue).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.cboReason).EndInit();
    this.DsNOC.EndInit();
    ((ISupportInitialize) this.cboNoticeType).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.dtMailingDate).EndInit();
    ((ISupportInitialize) this.dtCancellationDate).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtNOCReasonComment).EndInit();
    this.ResumeLayout(false);
  }

  private void frmNOC_Load(object sender, EventArgs e)
  {
    this._bindings.BindingMngrlstPolicyCancellationNoticeTypes.ResumeBinding();
    this._bindings.BindingMngrlstQuoteStatusReasons.ResumeBinding();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnIssue_Click(object sender, EventArgs e)
  {
    if (!this.IsFormValid)
      return;
    this.IssueNoticeOfCancellation();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void IssueNoticeOfCancellation()
  {
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        this.NOC_Transaction(RuntimeHelpers.GetObjectValue(obj), args);
        args.Transaction.Commit();
      }));
      CurrentUser.Instance.LogAction($"Issued NOC for {((UltraCombo) this.cboReason).Text}. Cancellation date {RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtCancellationDate).Value)}.", this._quoteGuid);
      Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
      int index = 0;
      while (index < mdiChildren.Length)
      {
        if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.Quote.QuoteGuid.Equals(this._quoteGuid))
          frmPolicyDetail.RefreshPolicyData();
        checked { ++index; }
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      if (sqlException.Message.Contains("No rows in @cancTbl"))
      {
        int num = (int) MessageBox.Show("An error occured while trying to issue the Notice of Cancellation.\n\nIf this problem persists, please contact technical support.", "Cancellation Notice Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError((Exception) sqlException);
      ProjectData.ClearProjectError();
    }
  }

  private object NOC_Transaction(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_PostNOCToAccounting", new object[6]
    {
      (object) "@CancellationDate",
      ((UltraDateTimeEditor) this.dtCancellationDate).Value,
      (object) "@MailingDate",
      ((UltraDateTimeEditor) this.dtMailingDate).Value,
      (object) "@QuoteGUID",
      (object) this._quoteGuid
    });
    DefaultDatabase.ExecuteNonQuery("spUpdateQuoteStatus_NOC", new object[10]
    {
      (object) "@QuoteGUID",
      (object) this._quoteGuid,
      (object) "@QuoteStatusReasonID",
      ((UltraCombo) this.cboReason).Value,
      (object) "@QuoteStatusID",
      (object) 6,
      (object) "@NOCTypeID",
      ((UltraCombo) this.cboNoticeType).Value,
      (object) "@StatusReasonComment",
      (object) ((TextEditorControlBase) this.txtNOCReasonComment).Text
    });
    return (object) null;
  }

  public bool IsFormValid
  {
    get
    {
      bool isFormValid = true;
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtCancellationDate).Value)))
      {
        isFormValid = false;
        this.ErrorProvider1.SetError((Control) this.dtCancellationDate, "Please select a cancellation date");
      }
      else
        this.ErrorProvider1.SetError((Control) this.dtCancellationDate, string.Empty);
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtMailingDate).Value)))
      {
        isFormValid = false;
        this.ErrorProvider1.SetError((Control) this.dtMailingDate, "Please select a mailing date");
      }
      else
        this.ErrorProvider1.SetError((Control) this.dtMailingDate, string.Empty);
      if (((UltraCombo) this.cboNoticeType).Value == null)
      {
        isFormValid = false;
        this.ErrorProvider1.SetError((Control) this.cboNoticeType, "Please select a notice type");
      }
      else
        this.ErrorProvider1.SetError((Control) this.cboNoticeType, string.Empty);
      if (((UltraCombo) this.cboReason).Value == null)
      {
        isFormValid = false;
        this.ErrorProvider1.SetError((Control) this.cboReason, "Please select a reason");
      }
      else
        this.ErrorProvider1.SetError((Control) this.cboReason, string.Empty);
      return isFormValid;
    }
  }

  private bool EnableNOCStatusComment(bool EnableNOC_CommentFields)
  {
    if (!EnableNOC_CommentFields)
      ((TextEditorControlBase) this.txtNOCReasonComment).Text = string.Empty;
    ((Control) this.txtNOCReasonComment).Enabled = EnableNOC_CommentFields;
    this.lblComment.Enabled = EnableNOC_CommentFields;
    bool flag;
    return flag;
  }

  private void cboReason_ValueChanged(object sender, EventArgs e)
  {
  }
}
