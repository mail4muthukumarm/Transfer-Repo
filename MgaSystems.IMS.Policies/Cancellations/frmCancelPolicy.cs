// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Cancellations.frmCancelPolicy
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data;
using MGASystems.IMS.Policies.Endorsements;
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
namespace MGASystems.IMS.Policies.Cancellations;

public class frmCancelPolicy : Form
{
  private IContainer components;
  private MGAButton btnCancel;
  private Label Label1;
  private MGASimpleComboBox cboReasons;
  protected EndorsementInfo endInfo;
  private MGAGroupBox MgaGroupBox1;
  private bool _saved;
  protected Guid _quoteGuid;
  protected DataTable _reasonsDt;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEndtRequestDate")]
  protected virtual MGADateTimePicker dtEndtRequestDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCancelPolicy));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.Label1 = new Label();
    this.cboReasons = new MGASimpleComboBox();
    this.err = new ErrorProvider(this.components);
    this.MgaGroupBox1 = new MGAGroupBox();
    this.dtEndtRequestDate = new MGADateTimePicker();
    this.Label2 = new Label();
    this.endInfo = new EndorsementInfo();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboReasons).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.dtEndtRequestDate).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(304, 200);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 7;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(256 /*0x0100*/, 200);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 6;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.FromArgb(239, 247, 253);
    this.Label1.Location = new Point(24, 144 /*0x90*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(108, 13);
    this.Label1.TabIndex = 8;
    this.Label1.Text = "Cancellation Reason:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboReasons).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboReasons).CharacterCasing = CharacterCasing.Normal;
    ((UltraCombo) this.cboReasons).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboReasons).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboReasons).Location = new Point(144 /*0x90*/, 144 /*0x90*/);
    this.cboReasons.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboReasons).Name = "cboReasons";
    ((Control) this.cboReasons).Size = new Size(200, 21);
    ((Control) this.cboReasons).TabIndex = 9;
    ((UltraControlBase) this.cboReasons).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReasons).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtEndtRequestDate);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnCancel);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboReasons);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.endInfo);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnSave);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    appearance4.AlphaLevel = (short) 230;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.White;
    appearance4.ForegroundAlpha = (Alpha) 2;
    appearance4.ImageAlpha = (Alpha) 2;
    appearance4.ImageBackground = (Image) componentResourceManager.GetObject("Appearance6.ImageBackground");
    appearance4.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    ((UltraGroupBox) this.MgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 7);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(376, 245);
    ((Control) this.MgaGroupBox1).TabIndex = 10;
    ((UltraGroupBox) this.MgaGroupBox1).Text = "Cancellation Information";
    ((UltraGroupBox) this.MgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEndtRequestDate).Appearance = (AppearanceBase) appearance5;
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
    ((UltraDateTimeEditor) this.dtEndtRequestDate).ButtonAppearance = (AppearanceBase) appearance6;
    ((UltraDateTimeEditor) this.dtEndtRequestDate).FormatString = "D";
    ((Control) this.dtEndtRequestDate).Location = new Point(144 /*0x90*/, 174);
    this.dtEndtRequestDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEndtRequestDate).Name = "dtEndtRequestDate";
    ((Control) this.dtEndtRequestDate).Size = new Size(200, 20);
    ((Control) this.dtEndtRequestDate).TabIndex = 10;
    ((UltraControlBase) this.dtEndtRequestDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEndtRequestDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtEndtRequestDate).Value = (object) null;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.FromArgb(239, 247, 253);
    this.Label2.Location = new Point(26, 178);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(106, 13);
    this.Label2.TabIndex = 11;
    this.Label2.Text = "Endt. Request Date:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.endInfo.BackColor = Color.FromArgb(239, 247, 253);
    this.endInfo.Comment = "";
    this.endInfo.CommentLabelText = "Comment:";
    this.endInfo.EffectiveDate = new DateTime(2008, 1, 15, 0, 0, 0, 0);
    this.endInfo.EndorsementCalcType = (EndorsementCalcTypes) 1;
    this.endInfo.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.endInfo.Location = new Point(8, 24);
    this.endInfo.Name = "endInfo";
    this.endInfo.Size = new Size(352, 112 /*0x70*/);
    this.endInfo.TabIndex = 0;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(392, 264);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCancelPolicy);
    this.Text = "Cancel Policy";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboReasons).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.dtEndtRequestDate).EndInit();
    this.ResumeLayout(false);
  }

  [Obsolete("The constructor that takes a quoteGuid should be used.")]
  public frmCancelPolicy()
  {
    this.Load += new EventHandler(this.frmCancelPolicy_Load);
    this.InitializeComponent();
  }

  public frmCancelPolicy(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmCancelPolicy_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this.endInfo.CalculationTypeVisibility(quoteGuid);
  }

  public EndorsementCalcTypes EndorsementCalcType => this.endInfo.EndorsementCalcType;

  public bool Saved => this._saved;

  public DateTime EndorsementEffective => this.endInfo.EffectiveDate;

  public string EndorsementComment => this.endInfo.Comment;

  public int ReasonID => Conversions.ToInteger(((UltraCombo) this.cboReasons).Value);

  public DateTime EndtRequestDate
  {
    get
    {
      return ((UltraDateTimeEditor) this.dtEndtRequestDate).Value == null || ((UltraDateTimeEditor) this.dtEndtRequestDate).Value == DBNull.Value ? DateTime.MinValue : (DateTime) ((UltraDateTimeEditor) this.dtEndtRequestDate).Value;
    }
  }

  private void frmCancelPolicy_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this.GetCancellationReasons();
    this.PopulateReasons();
    ((UltraDropDownBase) this.cboReasons).SelectedRow = (UltraGridRow) null;
    this.AfterFormLoad();
  }

  protected virtual void GetCancellationReasons()
  {
    this._reasonsDt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "Select  ID, Reason FROM lstQuoteStatusReasons WHERE QuoteStatusID = 7 And ISNULL(Inactive,0) = 0 And LineGuid In (Select top 1 LineGUID from tblQuotes where QuoteGUID=@QuoteGUID) ORDER BY Reason", new object[2]
    {
      (object) "@QuoteGUID",
      (object) this._quoteGuid
    });
    if (this._reasonsDt.Rows.Count != 0)
      return;
    this._reasonsDt = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ID, Reason FROM lstQuoteStatusReasons WHERE QuoteStatusID=7 AND ISNULL(Inactive,0) = 0 and  LineGuid is null ORDER BY Reason", new object[2]
    {
      (object) "@QuoteGUID",
      (object) this._quoteGuid
    });
  }

  private void PopulateReasons()
  {
    MGASimpleComboBox cboReasons = this.cboReasons;
    ((UltraGridBase) cboReasons).DataSource = (object) this._reasonsDt;
    ((UltraDropDownBase) cboReasons).DisplayMember = "Reason";
    ((UltraDropDownBase) cboReasons).ValueMember = "ID";
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((UltraCombo) this.cboReasons).Text))
    {
      this.err.SetError((Control) this.cboReasons, "Please select a reason for this cancellation.");
      flag = false;
    }
    if (flag)
    {
      ValidateEndorsementReason objectEx = (ValidateEndorsementReason) ObjectFactory.Instance.CreateObjectEX(typeof (ValidateEndorsementReason), new object[0]);
      int integer = Conversions.ToInteger(((UltraCombo) this.cboReasons).Value);
      int controlNo = new Quote(this._quoteGuid).ControlNo;
      int reasonID = integer;
      flag = objectEx.ValidateReason(controlNo, reasonID);
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidForm())
      return;
    this._saved = true;
    this.Close();
  }

  protected virtual void AfterFormLoad()
  {
  }
}
