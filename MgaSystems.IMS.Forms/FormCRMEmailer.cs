// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormCRMEmailer
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormCRMEmailer : FormBase
{
  private IContainer components;
  private int _currentStep;
  private CRMEmail_States _crmStates;
  private CRMEmail_LinesOfBusiness _crmLinesOfBusiness;
  private CRMEMail_RecipientList _crmEmailRecipients;
  private CRMEmail_EmailBody _crmEmailBody;
  private string _sqlLocationString;
  private string _sqlLOBString;
  private DataTable _dtEmailRecipients;
  private string _eSubject;
  private bool _hasEmailSystemSettings;
  private string _mailServerAddress;
  private string _exchangeServerDomain;
  private Guid _userGuid;
  private static CRMEmail_SelectionStatus _crmSelectionStatus;
  private bool _emailSendComplete;
  private int _producerCount;
  public const string CanOpenCRMEmailForm = "{7CE6C129-F66C-4864-A860-DE3E9D7C1632}";
  private static string _displaySelectedStates;
  private static string _displaySelectedLOB;
  private static int _producerType;

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
    Appearance appearance4 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    this.panelBottom = new Panel();
    this.Label3 = new Label();
    this.lnkViewEmailSettings = new LinkLabel();
    this.lnkTestEmail = new LinkLabel();
    this.buttonSend = new MGAButton();
    this.buttonBack = new MGAButton();
    this.buttonNext = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.panelTop = new Panel();
    this.GroupBox2 = new GroupBox();
    this.cboProducerType = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.lblMailServer = new Label();
    this.Label2 = new Label();
    this.lblEmailSystemStatus = new Label();
    this.opMailSystemType = new UltraOptionSet();
    this.picWaitIndicator = new PictureBox();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.panelContent = new Panel();
    this.DsCRMSelectionCriteria1 = new dsCRMSelectionCriteria();
    this.BackgroundWorker1 = new BackgroundWorker();
    this.panelBottom.SuspendLayout();
    ((ISupportInitialize) this.buttonSend).BeginInit();
    ((ISupportInitialize) this.buttonBack).BeginInit();
    ((ISupportInitialize) this.buttonNext).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panelTop.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.opMailSystemType).BeginInit();
    ((ISupportInitialize) this.picWaitIndicator).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.DsCRMSelectionCriteria1.BeginInit();
    this.SuspendLayout();
    this.panelBottom.BackColor = Color.LightSteelBlue;
    this.panelBottom.Controls.Add((Control) this.Label3);
    this.panelBottom.Controls.Add((Control) this.lnkViewEmailSettings);
    this.panelBottom.Controls.Add((Control) this.lnkTestEmail);
    this.panelBottom.Controls.Add((Control) this.buttonSend);
    this.panelBottom.Controls.Add((Control) this.buttonBack);
    this.panelBottom.Controls.Add((Control) this.buttonNext);
    this.panelBottom.Controls.Add((Control) this.buttonCancel);
    this.panelBottom.Dock = DockStyle.Bottom;
    this.panelBottom.Location = new Point(0, 512 /*0x0200*/);
    this.panelBottom.Name = "panelBottom";
    this.panelBottom.Size = new Size(792, 54);
    this.panelBottom.TabIndex = 0;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(168, 19);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(11, 13);
    this.Label3.TabIndex = 8;
    this.Label3.Text = "/";
    this.lnkViewEmailSettings.AutoSize = true;
    this.lnkViewEmailSettings.Location = new Point(185, 19);
    this.lnkViewEmailSettings.Name = "lnkViewEmailSettings";
    this.lnkViewEmailSettings.Size = new Size(97, 13);
    this.lnkViewEmailSettings.TabIndex = 7;
    this.lnkViewEmailSettings.TabStop = true;
    this.lnkViewEmailSettings.Text = "View email settings";
    this.lnkTestEmail.AutoSize = true;
    this.lnkTestEmail.Location = new Point(12, 19);
    this.lnkTestEmail.Name = "lnkTestEmail";
    this.lnkTestEmail.Size = new Size(150, 13);
    this.lnkTestEmail.TabIndex = 6;
    this.lnkTestEmail.TabStop = true;
    this.lnkTestEmail.Text = "Click here to send a test email";
    ((Control) this.buttonSend).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSend).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonSend).Enabled = false;
    ((Control) this.buttonSend).Location = new Point(622, 19);
    ((Control) this.buttonSend).Name = "buttonSend";
    ((Control) this.buttonSend).Size = new Size(75, 23);
    ((Control) this.buttonSend).TabIndex = 3;
    ((ControlBase) this.buttonSend).Text = "Send";
    ((UltraControlBase) this.buttonSend).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonSend.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonBack).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonBack).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonBack).Enabled = false;
    ((Control) this.buttonBack).Location = new Point(455, 19);
    ((Control) this.buttonBack).Name = "buttonBack";
    ((Control) this.buttonBack).Size = new Size(75, 23);
    ((Control) this.buttonBack).TabIndex = 2;
    ((ControlBase) this.buttonBack).Text = "<< Back";
    ((UltraControlBase) this.buttonBack).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonBack.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonNext).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonNext).Location = new Point(536, 19);
    ((Control) this.buttonNext).Name = "buttonNext";
    ((Control) this.buttonNext).Size = new Size(75, 23);
    ((Control) this.buttonNext).TabIndex = 1;
    ((ControlBase) this.buttonNext).Text = "Next >>";
    ((UltraControlBase) this.buttonNext).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCancel).Location = new Point(703, 19);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(75, 23);
    ((Control) this.buttonCancel).TabIndex = 0;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.GroupBox2);
    this.panelTop.Controls.Add((Control) this.GroupBox1);
    this.panelTop.Controls.Add((Control) this.picWaitIndicator);
    this.panelTop.Controls.Add((Control) this.PictureBox1);
    this.panelTop.Controls.Add((Control) this.Label1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(792, 63 /*0x3F*/);
    this.panelTop.TabIndex = 1;
    this.GroupBox2.Controls.Add((Control) this.cboProducerType);
    this.GroupBox2.ForeColor = Color.SteelBlue;
    this.GroupBox2.Location = new Point(524, 5);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(200, 52);
    this.GroupBox2.TabIndex = 4;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Producer Type Selection";
    this.cboProducerType.FormattingEnabled = true;
    this.cboProducerType.Location = new Point(6, 20);
    this.cboProducerType.Name = "cboProducerType";
    this.cboProducerType.Size = new Size(185, 21);
    this.cboProducerType.TabIndex = 0;
    this.GroupBox1.Controls.Add((Control) this.lblMailServer);
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.lblEmailSystemStatus);
    this.GroupBox1.Controls.Add((Control) this.opMailSystemType);
    this.GroupBox1.ForeColor = Color.SteelBlue;
    this.GroupBox1.Location = new Point(302, 5);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(216, 52);
    this.GroupBox1.TabIndex = 3;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Email System Settings";
    this.lblMailServer.AutoSize = true;
    this.lblMailServer.Location = new Point(99, 33);
    this.lblMailServer.Name = "lblMailServer";
    this.lblMailServer.Size = new Size(11, 13);
    this.lblMailServer.TabIndex = 3;
    this.lblMailServer.Text = ".";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(9, 33);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(94, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Mail Server Name:";
    this.lblEmailSystemStatus.AutoSize = true;
    this.lblEmailSystemStatus.Location = new Point(6, 29);
    this.lblEmailSystemStatus.Name = "lblEmailSystemStatus";
    this.lblEmailSystemStatus.Size = new Size(11, 13);
    this.lblEmailSystemStatus.TabIndex = 1;
    this.lblEmailSystemStatus.Text = ".";
    this.opMailSystemType.BorderStyle = (UIElementBorderStyle) 1;
    valueListItem1.DataValue = (object) "Default Item";
    valueListItem1.DisplayText = "SMTP";
    valueListItem2.DataValue = (object) "ValueListItem1";
    valueListItem2.DisplayText = "Exchange Server";
    this.opMailSystemType.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.opMailSystemType).Location = new Point(9, 13);
    ((Control) this.opMailSystemType).Name = "opMailSystemType";
    ((Control) this.opMailSystemType).Size = new Size(158, 17);
    ((Control) this.opMailSystemType).TabIndex = 0;
    ((UltraControlBase) this.opMailSystemType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.opMailSystemType).UseOsThemes = (DefaultableBoolean) 2;
    this.picWaitIndicator.Location = new Point(730, 14);
    this.picWaitIndicator.Name = "picWaitIndicator";
    this.picWaitIndicator.Size = new Size(41, 43);
    this.picWaitIndicator.TabIndex = 2;
    this.picWaitIndicator.TabStop = false;
    this.PictureBox1.Image = (Image) MGASystems.IMS.Forms.My.Resources.Resources.email3;
    this.PictureBox1.Location = new Point(12, 12);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 20f);
    this.Label1.ForeColor = Color.SteelBlue;
    this.Label1.Location = new Point(66, 14);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(230, 33);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "CRM Email Wizard";
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(0, 63 /*0x3F*/);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(792, 449);
    this.panelContent.TabIndex = 2;
    this.DsCRMSelectionCriteria1.DataSetName = "dsCRMSelectionCriteria";
    this.DsCRMSelectionCriteria1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(792, 566);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panelBottom);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormCRMEmailer);
    this.Text = "CRM Emailer";
    this.panelBottom.ResumeLayout(false);
    this.panelBottom.PerformLayout();
    ((ISupportInitialize) this.buttonSend).EndInit();
    ((ISupportInitialize) this.buttonBack).EndInit();
    ((ISupportInitialize) this.buttonNext).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.opMailSystemType).EndInit();
    ((ISupportInitialize) this.picWaitIndicator).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.DsCRMSelectionCriteria1.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("panelBottom")]
  internal virtual Panel panelBottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelTop")]
  internal virtual Panel panelTop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonBack
  {
    get => this._buttonBack;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonBack_Click);
      MGAButton buttonBack1 = this._buttonBack;
      if (buttonBack1 != null)
        ((Control) buttonBack1).Click -= eventHandler;
      this._buttonBack = value;
      MGAButton buttonBack2 = this._buttonBack;
      if (buttonBack2 == null)
        return;
      ((Control) buttonBack2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonNext
  {
    get => this._buttonNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonNext_Click);
      MGAButton buttonNext1 = this._buttonNext;
      if (buttonNext1 != null)
        ((Control) buttonNext1).Click -= eventHandler;
      this._buttonNext = value;
      MGAButton buttonNext2 = this._buttonNext;
      if (buttonNext2 == null)
        return;
      ((Control) buttonNext2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonSend
  {
    get => this._buttonSend;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSend_Click);
      MGAButton buttonSend1 = this._buttonSend;
      if (buttonSend1 != null)
        ((Control) buttonSend1).Click -= eventHandler;
      this._buttonSend = value;
      MGAButton buttonSend2 = this._buttonSend;
      if (buttonSend2 == null)
        return;
      ((Control) buttonSend2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelContent")]
  internal virtual Panel panelContent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsCRMSelectionCriteria1")]
  internal virtual dsCRMSelectionCriteria DsCRMSelectionCriteria1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("picWaitIndicator")]
  internal virtual PictureBox picWaitIndicator { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraOptionSet opMailSystemType
  {
    get => this._opMailSystemType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.opMailSystemType_ValueChanged);
      UltraOptionSet opMailSystemType1 = this._opMailSystemType;
      if (opMailSystemType1 != null)
        opMailSystemType1.ValueChanged -= eventHandler;
      this._opMailSystemType = value;
      UltraOptionSet opMailSystemType2 = this._opMailSystemType;
      if (opMailSystemType2 == null)
        return;
      opMailSystemType2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblEmailSystemStatus")]
  internal virtual Label lblEmailSystemStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMailServer")]
  internal virtual Label lblMailServer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ComboBox cboProducerType
  {
    get => this._cboProducerType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboProducerType_SelectedValueChanged);
      ComboBox cboProducerType1 = this._cboProducerType;
      if (cboProducerType1 != null)
        cboProducerType1.SelectedValueChanged -= eventHandler;
      this._cboProducerType = value;
      ComboBox cboProducerType2 = this._cboProducerType;
      if (cboProducerType2 == null)
        return;
      cboProducerType2.SelectedValueChanged += eventHandler;
    }
  }

  internal virtual LinkLabel lnkTestEmail
  {
    get => this._lnkTestEmail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkTestEmail_LinkClicked);
      LinkLabel lnkTestEmail1 = this._lnkTestEmail;
      if (lnkTestEmail1 != null)
        lnkTestEmail1.LinkClicked -= clickedEventHandler;
      this._lnkTestEmail = value;
      LinkLabel lnkTestEmail2 = this._lnkTestEmail;
      if (lnkTestEmail2 == null)
        return;
      lnkTestEmail2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkViewEmailSettings
  {
    get => this._lnkViewEmailSettings;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkViewEmailSettings_LinkClicked);
      LinkLabel viewEmailSettings1 = this._lnkViewEmailSettings;
      if (viewEmailSettings1 != null)
        viewEmailSettings1.LinkClicked -= clickedEventHandler;
      this._lnkViewEmailSettings = value;
      LinkLabel viewEmailSettings2 = this._lnkViewEmailSettings;
      if (viewEmailSettings2 == null)
        return;
      viewEmailSettings2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BackgroundWorker1")]
  internal virtual BackgroundWorker BackgroundWorker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCRMEmailer()
  {
    this.Activated += new EventHandler(this.FormCRMEmailer_Activated);
    this.FormClosing += new FormClosingEventHandler(this.FormCRMEmailer_FormClosing);
    this.Load += new EventHandler(this.FormCRMEmailer_Load);
    this._currentStep = 1;
    this._crmEmailBody = new CRMEmail_EmailBody();
    this.InitializeComponent();
    this._userGuid = CurrentUser.Instance.UserGUID;
  }

  public FormCRMEmailer(string sender)
  {
    this.Activated += new EventHandler(this.FormCRMEmailer_Activated);
    this.FormClosing += new FormClosingEventHandler(this.FormCRMEmailer_FormClosing);
    this.Load += new EventHandler(this.FormCRMEmailer_Load);
    this._currentStep = 1;
    this._crmEmailBody = new CRMEmail_EmailBody();
    this.InitializeComponent();
    this._userGuid = CurrentUser.Instance.UserGUID;
    new FormCRMEmailer().LoadEmailBody(sender);
  }

  public FormCRMEmailer(RowsCollection gridRows)
  {
    this.Activated += new EventHandler(this.FormCRMEmailer_Activated);
    this.FormClosing += new FormClosingEventHandler(this.FormCRMEmailer_FormClosing);
    this.Load += new EventHandler(this.FormCRMEmailer_Load);
    this._currentStep = 1;
    this._crmEmailBody = new CRMEmail_EmailBody();
    this.InitializeComponent();
    this._userGuid = CurrentUser.Instance.UserGUID;
    this._currentStep = 4;
  }

  public static string displaySelectedStates
  {
    get => FormCRMEmailer._displaySelectedStates;
    set
    {
      FormCRMEmailer._displaySelectedStates = value;
      FormCRMEmailer._crmSelectionStatus.lblStateStatus.Text = FormCRMEmailer._displaySelectedStates;
    }
  }

  public static string displaySelectedLOB
  {
    get => FormCRMEmailer._displaySelectedLOB;
    set
    {
      FormCRMEmailer._displaySelectedLOB = value;
      FormCRMEmailer._crmSelectionStatus.lblLOBStatus.Text = FormCRMEmailer._displaySelectedLOB;
    }
  }

  public static int ProducerType
  {
    get => FormCRMEmailer._producerType;
    set => FormCRMEmailer._producerType = value;
  }

  private void GetCRMCriteria()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.DsCRMSelectionCriteria1, new string[2]
    {
      "States",
      "LinesOfBusiness"
    }, "GetCRMEmailTables");
  }

  private void FormCRMEmailer_Activated(object sender, EventArgs e)
  {
    this._mailServerAddress = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ExchangeServerDomain, MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
    {
      (object) "@UserID",
      (object) CurrentUser.Instance.UserID
    })["MailServerAddress"] as string;
    if (!Information.IsNothing((object) this._mailServerAddress))
      return;
    int num = (int) MessageBox.Show("A mail server must be configured \r\nto allow you to send emails\r\nPlease consult your System Administrator", "Mail Server Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private void FormCRMEmailer_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.DisposeUserForms();
  }

  private void FormCRMEmailer_Load(object sender, EventArgs e)
  {
    this._crmEmailBody.GetCurrentUserEmailCredentials();
    this.GetCRMCriteria();
    this.opMailSystemType.CheckedIndex = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._crmEmailBody.MailSystemType, "Exchange", false) != 0 ? 0 : 1;
    this._mailServerAddress = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ExchangeServerDomain, MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
    {
      (object) "@UserID",
      (object) CurrentUser.Instance.UserID
    })["MailServerAddress"] as string;
    this.cboProducerType.DataSource = (object) null;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "Select ProducerTypeID,Description From lstProducerTypes");
    dataTable.Rows.Add((object) 0, (object) "Select All");
    dataTable.Rows.Add(new object[2]
    {
      null,
      (object) string.Empty
    });
    dataTable.DefaultView.Sort = "ProducerTypeID";
    ComboBox cboProducerType = this.cboProducerType;
    cboProducerType.DisplayMember = "Description";
    cboProducerType.ValueMember = "ProducerTypeID";
    cboProducerType.DataSource = (object) dataTable;
    this.LoadStep();
  }

  private void LoadStep()
  {
    switch (this._currentStep)
    {
      case 1:
        this.LoadEmailBody();
        ((Control) this.buttonNext).Enabled = true;
        ((Control) this.buttonBack).Enabled = false;
        ((Control) this.buttonSend).Enabled = false;
        break;
      case 2:
        ((Control) this.buttonBack).Enabled = true;
        ((Control) this.buttonNext).Enabled = true;
        ((Control) this.buttonSend).Enabled = false;
        this.LoadStates();
        break;
      case 3:
        ((Control) this.buttonBack).Enabled = true;
        ((Control) this.buttonNext).Enabled = true;
        this._dtEmailRecipients = (DataTable) null;
        this._sqlLocationString = this._crmStates.GetDynamicLocationSQL();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._sqlLocationString, (string) null, false) == 0)
        {
          this.DisplayError("Please Select at Least 1 State");
          break;
        }
        this.LoadLinesOfBusiness();
        break;
      case 4:
        ((Control) this.buttonNext).Enabled = false;
        ((Control) this.buttonSend).Enabled = true;
        if (string.IsNullOrEmpty(this.cboProducerType.SelectedValue.ToString()))
        {
          this.DisplayError("Please Select a Producer Type");
          this.cboProducerType.Focus();
          break;
        }
        FormCRMEmailer._producerType = Conversions.ToInteger(this.cboProducerType.SelectedValue.ToString());
        this._sqlLOBString = this._crmLinesOfBusiness.GetDynamicLineOfBusinessList();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._sqlLOBString, (string) null, false) == 0)
        {
          this.DisplayError("Please Select at Least 1 Line Of Business");
          break;
        }
        this._dtEmailRecipients = this.DoCRMQuery();
        if (this._dtEmailRecipients.Rows.Count > 0)
        {
          this.LoadEmailRecipientsList(this._dtEmailRecipients);
          break;
        }
        this.DisplayError("Your Selection Did Not Return Any Records,\r\nPlease Adjust Your Selections and Try Again.");
        break;
    }
  }

  private void LoadStates()
  {
    if (this._crmStates == null)
      this._crmStates = new CRMEmail_States(this.DsCRMSelectionCriteria1.States);
    if (FormCRMEmailer._crmSelectionStatus == null)
      FormCRMEmailer._crmSelectionStatus = new CRMEmail_SelectionStatus(FormCRMEmailer._displaySelectedStates, FormCRMEmailer._displaySelectedLOB);
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) this._crmStates);
    this.panelContent.Controls.Add((Control) FormCRMEmailer._crmSelectionStatus);
    this._crmStates.Dock = DockStyle.Fill;
    FormCRMEmailer._crmSelectionStatus.Dock = DockStyle.Right;
  }

  private void LoadLinesOfBusiness()
  {
    if (this._crmLinesOfBusiness == null)
      this._crmLinesOfBusiness = new CRMEmail_LinesOfBusiness(this.DsCRMSelectionCriteria1.LinesOfBusiness);
    if (FormCRMEmailer._crmSelectionStatus == null)
      FormCRMEmailer._crmSelectionStatus = new CRMEmail_SelectionStatus(FormCRMEmailer._displaySelectedStates, FormCRMEmailer._displaySelectedLOB);
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) this._crmLinesOfBusiness);
    this.panelContent.Controls.Add((Control) FormCRMEmailer._crmSelectionStatus);
    this._crmLinesOfBusiness.Dock = DockStyle.Fill;
    FormCRMEmailer._crmSelectionStatus.Dock = DockStyle.Right;
  }

  private void LoadEmailRecipientsList(DataTable Producers)
  {
    if (this._crmEmailRecipients == null)
      this._crmEmailRecipients = new CRMEMail_RecipientList(this._dtEmailRecipients);
    else
      ((UltraGridBase) this._crmEmailRecipients.grdEmailAddresses).DataSource = (object) Producers;
    if (FormCRMEmailer._crmSelectionStatus == null)
      FormCRMEmailer._crmSelectionStatus = new CRMEmail_SelectionStatus(FormCRMEmailer._displaySelectedStates, FormCRMEmailer._displaySelectedLOB);
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) this._crmEmailRecipients);
    this._crmEmailRecipients.Dock = DockStyle.Fill;
    int count = Producers.Rows.Count;
    this._crmEmailRecipients.lblProducerCount.Text = Conversions.ToString(this._producerCount) + " Producers Were Found That Meet Your Selection Criteria.";
  }

  private void LoadEmailBody()
  {
    if (this._crmEmailBody == null)
      this._crmEmailBody = new CRMEmail_EmailBody();
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) this._crmEmailBody);
    this._crmEmailBody.Dock = DockStyle.Fill;
  }

  public void LoadEmailBody(string sender)
  {
    if (this._crmEmailBody == null)
      this._crmEmailBody = new CRMEmail_EmailBody(sender);
    this.panelContent.Controls.Clear();
    this.panelContent.Controls.Add((Control) this._crmEmailBody);
    this._crmEmailBody.Dock = DockStyle.Fill;
  }

  private DataTable DoCRMQuery()
  {
    FormCRMEmailer._producerType = Conversions.ToInteger(this.cboProducerType.SelectedValue.ToString());
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetCRMEmailQueryResults", new object[6]
    {
      (object) "@SQLLocationString",
      (object) this._sqlLocationString,
      (object) "@SQLLOBString",
      (object) this._sqlLOBString,
      (object) "@ProducerType",
      (object) FormCRMEmailer._producerType
    });
    this._producerCount = dataTable.Rows.Count;
    return dataTable;
  }

  public void DisplayError(string ErrMessage)
  {
    int num = (int) MessageBox.Show(ErrMessage, "CRM Emailer Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, (MessageBoxOptions) 0);
    --this._currentStep;
  }

  private void DisposeUserForms()
  {
    if (this._crmLinesOfBusiness != null)
    {
      this._crmLinesOfBusiness.Dispose();
      this._crmLinesOfBusiness = (CRMEmail_LinesOfBusiness) null;
    }
    if (this._crmEmailRecipients != null)
    {
      this._crmEmailRecipients.Dispose();
      this._crmEmailRecipients = (CRMEMail_RecipientList) null;
    }
    if (this._crmEmailBody != null)
    {
      this._crmEmailBody.Dispose();
      this._crmEmailBody = (CRMEmail_EmailBody) null;
    }
    if (FormCRMEmailer._crmSelectionStatus == null)
      return;
    FormCRMEmailer._crmSelectionStatus.Dispose();
    FormCRMEmailer._crmSelectionStatus = (CRMEmail_SelectionStatus) null;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DisposeUserForms();
    this.Close();
  }

  private void buttonSend_Click(object sender, EventArgs e)
  {
    try
    {
      if (((UltraGridBase) this._crmEmailRecipients.grdEmailAddresses).DataSource == null)
        this._crmEmailRecipients = new CRMEMail_RecipientList(this.DoCRMQuery());
      this._crmEmailBody.SendEmails(this._crmEmailRecipients);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void buttonNext_Click(object sender, EventArgs e)
  {
    ++this._currentStep;
    if (this._currentStep > 4)
      this._currentStep = 4;
    this.LoadStep();
  }

  private void buttonBack_Click(object sender, EventArgs e)
  {
    --this._currentStep;
    if (this._currentStep < 1)
      this._currentStep = 1;
    this.LoadStep();
  }

  private void opMailSystemType_ValueChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.opMailSystemType.CheckedIndex == 0)
        this._crmEmailBody.MailSystemType = "SMTP";
      else
        this._crmEmailBody.MailSystemType = "Exchange";
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void cboProducerType_SelectedValueChanged(object sender, EventArgs e)
  {
    try
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboProducerType.SelectedValue)))
      {
        FormCRMEmailer._producerType = Conversions.ToInteger(this.cboProducerType.SelectedValue);
        if (this._crmEmailRecipients != null)
          return;
        this._crmEmailRecipients = new CRMEMail_RecipientList(this.DoCRMQuery());
      }
      else
        FormCRMEmailer._producerType = 0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void lnkTestEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._crmEmailBody.SendEmails(new CRMEMail_RecipientList((DataTable) null));
  }

  private void lnkViewEmailSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowForm(typeof (frmEmailInfo), (object) this._userGuid);
  }

  private delegate void SendGroupEmailsDelegate(CRMEMail_RecipientList _crmEmailRecipients);
}
