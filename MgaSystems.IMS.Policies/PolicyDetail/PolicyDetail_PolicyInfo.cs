// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.PolicyDetail_PolicyInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[SecureResource("{96AE58F5-2FB1-4f13-AA6C-1C4B77624EBB}", "Allows for Navigation to Insured from Policy Detail Screen", "Allows the user to open an Insured from the link on Policy Detail Screen.", "Users")]
[SecureResource("{E3666975-017A-4922-9065-B0AE45835E15}", "Allows for Opening of Office Locations Screen", "Allows the user to open Office Locations.", "Users")]
[SecureResource("{4544aebc-7f2f-4223-8cba-16ce8d77292c}", "Allows for Navigation to Producers screen from Policy Detail Screen via Producer / Contact hyperlink", "Allows the user to view / click the hyperlink for Producer / Contact link on Policy Detail Screen.", "Users")]
public class PolicyDetail_PolicyInfo : UserControl
{
  private IContainer components;
  protected Label lblBillingType;
  protected Label Label17;
  protected Label lblPolicyNumber;
  protected Label Label10;
  protected Label Label8;
  protected Label lblAffidavitNumbers;
  protected Label lblAffidavitLabel;
  private UltraToolTipManager tip;
  private Guid _quoteGuid;
  private Quote _quote;
  private bool _validateOfacClears;
  private bool _recheckInvalidOfac;
  private bool _recheckInvalidAIOfac;
  public const string canOpenOfficeLocations = "{E3666975-017A-4922-9065-B0AE45835E15}";
  public const string canOpenInsuredFromPolicyDetailScreen = "{96AE58F5-2FB1-4f13-AA6C-1C4B77624EBB}";
  public const string canOpenProducerLocationsFromPolicyDetailScreen = "{4544aebc-7f2f-4223-8cba-16ce8d77292c}";
  private Font _underlinedFont;
  private UltraToolTipInfo _info;
  private string _insuredAddress;

  public PolicyDetail_PolicyInfo()
  {
    this._validateOfacClears = false;
    this._recheckInvalidOfac = false;
    this._recheckInvalidAIOfac = false;
    this._underlinedFont = new Font(this.Font, System.Drawing.FontStyle.Underline);
    this._info = new UltraToolTipInfo();
    this._insuredAddress = string.Empty;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      try
      {
        if (this.components != null)
          this.components.Dispose();
        if (this._underlinedFont != null)
          this._underlinedFont.Dispose();
        ((DisposableObject) this._info).Dispose();
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblStatus")]
  protected virtual Label lblStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPolicyType")]
  protected virtual Label lblPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblControlNo")]
  protected virtual Label lblControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraLabel lblUnderwriter
  {
    get => this._lblUnderwriter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.label_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.label_MouseLeave);
      EventHandler eventHandler3 = new EventHandler(this.lblUnderwriter_Click);
      UltraLabel lblUnderwriter1 = this._lblUnderwriter;
      if (lblUnderwriter1 != null)
      {
        ((Control) lblUnderwriter1).MouseEnter -= eventHandler1;
        ((Control) lblUnderwriter1).MouseLeave -= eventHandler2;
        ((Control) lblUnderwriter1).Click -= eventHandler3;
      }
      this._lblUnderwriter = value;
      UltraLabel lblUnderwriter2 = this._lblUnderwriter;
      if (lblUnderwriter2 == null)
        return;
      ((Control) lblUnderwriter2).MouseEnter += eventHandler1;
      ((Control) lblUnderwriter2).MouseLeave += eventHandler2;
      ((Control) lblUnderwriter2).Click += eventHandler3;
    }
  }

  protected virtual UltraLabel lblProducerContact
  {
    get => this._lblProducerContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.label_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.label_MouseLeave);
      EventHandler eventHandler3 = new EventHandler(this.lblProducerContact_Click);
      UltraLabel lblProducerContact1 = this._lblProducerContact;
      if (lblProducerContact1 != null)
      {
        ((Control) lblProducerContact1).MouseEnter -= eventHandler1;
        ((Control) lblProducerContact1).MouseLeave -= eventHandler2;
        ((Control) lblProducerContact1).Click -= eventHandler3;
      }
      this._lblProducerContact = value;
      UltraLabel lblProducerContact2 = this._lblProducerContact;
      if (lblProducerContact2 == null)
        return;
      ((Control) lblProducerContact2).MouseEnter += eventHandler1;
      ((Control) lblProducerContact2).MouseLeave += eventHandler2;
      ((Control) lblProducerContact2).Click += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPolicyPeriod")]
  protected virtual Label lblPolicyPeriod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraLabel lblCLS
  {
    get => this._lblCLS;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.label_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.label_MouseLeave);
      EventHandler eventHandler3 = new EventHandler(this.lblCLS_Click);
      UltraLabel lblCls1 = this._lblCLS;
      if (lblCls1 != null)
      {
        ((Control) lblCls1).MouseEnter -= eventHandler1;
        ((Control) lblCls1).MouseLeave -= eventHandler2;
        ((Control) lblCls1).Click -= eventHandler3;
      }
      this._lblCLS = value;
      UltraLabel lblCls2 = this._lblCLS;
      if (lblCls2 == null)
        return;
      ((Control) lblCls2).MouseEnter += eventHandler1;
      ((Control) lblCls2).MouseLeave += eventHandler2;
      ((Control) lblCls2).Click += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraLabel lblInsured
  {
    get => this._lblInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.label_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.label_MouseLeave);
      EventHandler eventHandler3 = new EventHandler(this.lblInsured_Click);
      EventHandler eventHandler4 = new EventHandler(this.lblInsured_MouseHover);
      UltraLabel lblInsured1 = this._lblInsured;
      if (lblInsured1 != null)
      {
        ((Control) lblInsured1).MouseEnter -= eventHandler1;
        ((Control) lblInsured1).MouseLeave -= eventHandler2;
        ((Control) lblInsured1).Click -= eventHandler3;
        ((Control) lblInsured1).MouseHover -= eventHandler4;
      }
      this._lblInsured = value;
      UltraLabel lblInsured2 = this._lblInsured;
      if (lblInsured2 == null)
        return;
      ((Control) lblInsured2).MouseEnter += eventHandler1;
      ((Control) lblInsured2).MouseLeave += eventHandler2;
      ((Control) lblInsured2).Click += eventHandler3;
      ((Control) lblInsured2).MouseHover += eventHandler4;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraLabel lblQuotingLocation
  {
    get => this._lblQuotingLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.label_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.label_MouseLeave);
      EventHandler eventHandler3 = new EventHandler(this.Location_Click);
      UltraLabel lblQuotingLocation1 = this._lblQuotingLocation;
      if (lblQuotingLocation1 != null)
      {
        ((Control) lblQuotingLocation1).MouseEnter -= eventHandler1;
        ((Control) lblQuotingLocation1).MouseLeave -= eventHandler2;
        ((Control) lblQuotingLocation1).Click -= eventHandler3;
      }
      this._lblQuotingLocation = value;
      UltraLabel lblQuotingLocation2 = this._lblQuotingLocation;
      if (lblQuotingLocation2 == null)
        return;
      ((Control) lblQuotingLocation2).MouseEnter += eventHandler1;
      ((Control) lblQuotingLocation2).MouseLeave += eventHandler2;
      ((Control) lblQuotingLocation2).Click += eventHandler3;
    }
  }

  protected virtual UltraLabel lblIssuingLocation
  {
    get => this._lblIssuingLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.label_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.label_MouseLeave);
      EventHandler eventHandler3 = new EventHandler(this.Location_Click);
      UltraLabel lblIssuingLocation1 = this._lblIssuingLocation;
      if (lblIssuingLocation1 != null)
      {
        ((Control) lblIssuingLocation1).MouseEnter -= eventHandler1;
        ((Control) lblIssuingLocation1).MouseLeave -= eventHandler2;
        ((Control) lblIssuingLocation1).Click -= eventHandler3;
      }
      this._lblIssuingLocation = value;
      UltraLabel lblIssuingLocation2 = this._lblIssuingLocation;
      if (lblIssuingLocation2 == null)
        return;
      ((Control) lblIssuingLocation2).MouseEnter += eventHandler1;
      ((Control) lblIssuingLocation2).MouseLeave += eventHandler2;
      ((Control) lblIssuingLocation2).Click += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual Label lblEndorsementReason
  {
    get => this._lblEndorsementReason;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LblEndorsementReason_MouseHover);
      Label endorsementReason1 = this._lblEndorsementReason;
      if (endorsementReason1 != null)
        endorsementReason1.MouseHover -= eventHandler;
      this._lblEndorsementReason = value;
      Label endorsementReason2 = this._lblEndorsementReason;
      if (endorsementReason2 == null)
        return;
      endorsementReason2.MouseHover += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    this.lblBillingType = new Label();
    this.Label17 = new Label();
    this.lblStatus = new Label();
    this.Label15 = new Label();
    this.lblPolicyType = new Label();
    this.Label13 = new Label();
    this.lblQuotingLocation = new UltraLabel();
    this.Label10 = new Label();
    this.lblIssuingLocation = new UltraLabel();
    this.Label8 = new Label();
    this.lblControlNo = new Label();
    this.lblUnderwriter = new UltraLabel();
    this.Label6 = new Label();
    this.lblProducerContact = new UltraLabel();
    this.Label2 = new Label();
    this.lblPolicyPeriod = new Label();
    this.Label5 = new Label();
    this.lblCLS = new UltraLabel();
    this.Label4 = new Label();
    this.lblPolicyNumber = new Label();
    this.Label3 = new Label();
    this.lblInsured = new UltraLabel();
    this.Label1 = new Label();
    this.Label7 = new Label();
    this.lblEndorsementReason = new Label();
    this.Label11 = new Label();
    this.lblAffidavitNumbers = new Label();
    this.lblAffidavitLabel = new Label();
    this.tip = new UltraToolTipManager(this.components);
    this.SuspendLayout();
    this.lblBillingType.BackColor = Color.FromArgb(239, 247, 253);
    this.lblBillingType.ForeColor = Color.Black;
    this.lblBillingType.Location = new Point(504, 72);
    this.lblBillingType.Name = "lblBillingType";
    this.lblBillingType.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblBillingType.TabIndex = 46;
    this.lblBillingType.TextAlign = ContentAlignment.MiddleLeft;
    this.lblBillingType.UseMnemonic = false;
    this.Label17.BackColor = Color.FromArgb(239, 247, 253);
    this.Label17.ForeColor = Color.Black;
    this.Label17.Location = new Point(416, 72);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label17.TabIndex = 45;
    this.Label17.Text = "Billing Type:";
    this.Label17.TextAlign = ContentAlignment.MiddleLeft;
    this.lblStatus.BackColor = Color.FromArgb(239, 247, 253);
    this.lblStatus.ForeColor = Color.Black;
    this.lblStatus.Location = new Point(504, 40);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblStatus.TabIndex = 44;
    this.lblStatus.TextAlign = ContentAlignment.MiddleLeft;
    this.lblStatus.UseMnemonic = false;
    this.Label15.BackColor = Color.FromArgb(239, 247, 253);
    this.Label15.ForeColor = Color.Black;
    this.Label15.Location = new Point(416, 40);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label15.TabIndex = 43;
    this.Label15.Text = "Status:";
    this.Label15.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyType.BackColor = Color.FromArgb(239, 247, 253);
    this.lblPolicyType.ForeColor = Color.Black;
    this.lblPolicyType.Location = new Point(504, 24);
    this.lblPolicyType.Name = "lblPolicyType";
    this.lblPolicyType.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblPolicyType.TabIndex = 42;
    this.lblPolicyType.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyType.UseMnemonic = false;
    this.Label13.BackColor = Color.FromArgb(239, 247, 253);
    this.Label13.ForeColor = Color.Black;
    this.Label13.Location = new Point(416, 24);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label13.TabIndex = 41;
    this.Label13.Text = "Policy Type:";
    this.Label13.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance1).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblQuotingLocation).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.lblQuotingLocation).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.lblQuotingLocation).ForeColor = Color.Black;
    ((Control) this.lblQuotingLocation).Location = new Point(144 /*0x90*/, 104);
    ((Control) this.lblQuotingLocation).Name = "lblQuotingLocation";
    ((Control) this.lblQuotingLocation).Size = new Size(272, 16 /*0x10*/);
    ((Control) this.lblQuotingLocation).TabIndex = 40;
    ((ControlBase) this.lblQuotingLocation).UseMnemonic = false;
    ((ControlBase) this.lblQuotingLocation).WrapText = false;
    this.Label10.BackColor = Color.FromArgb(239, 247, 253);
    this.Label10.ForeColor = Color.Black;
    this.Label10.Location = new Point(8, 104);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.Label10.TabIndex = 39;
    this.Label10.Text = "Quoting Location:";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblIssuingLocation).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.lblIssuingLocation).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.lblIssuingLocation).ForeColor = Color.Black;
    ((Control) this.lblIssuingLocation).Location = new Point(144 /*0x90*/, 88);
    ((Control) this.lblIssuingLocation).Name = "lblIssuingLocation";
    ((Control) this.lblIssuingLocation).Size = new Size(272, 16 /*0x10*/);
    ((Control) this.lblIssuingLocation).TabIndex = 38;
    ((ControlBase) this.lblIssuingLocation).UseMnemonic = false;
    ((ControlBase) this.lblIssuingLocation).WrapText = false;
    this.Label8.BackColor = Color.FromArgb(239, 247, 253);
    this.Label8.ForeColor = Color.Black;
    this.Label8.Location = new Point(8, 88);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.Label8.TabIndex = 37;
    this.Label8.Text = "Issuing Location:";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    this.lblControlNo.BackColor = Color.FromArgb(239, 247, 253);
    this.lblControlNo.ForeColor = Color.Black;
    this.lblControlNo.Location = new Point(504, 8);
    this.lblControlNo.Name = "lblControlNo";
    this.lblControlNo.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblControlNo.TabIndex = 36;
    this.lblControlNo.TextAlign = ContentAlignment.MiddleLeft;
    this.lblControlNo.UseMnemonic = false;
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblUnderwriter).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.lblUnderwriter).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.lblUnderwriter).ForeColor = Color.Black;
    ((Control) this.lblUnderwriter).Location = new Point(144 /*0x90*/, 72);
    ((Control) this.lblUnderwriter).Name = "lblUnderwriter";
    ((Control) this.lblUnderwriter).Size = new Size(272, 16 /*0x10*/);
    ((Control) this.lblUnderwriter).TabIndex = 35;
    ((ControlBase) this.lblUnderwriter).UseMnemonic = false;
    ((ControlBase) this.lblUnderwriter).WrapText = false;
    this.Label6.BackColor = Color.FromArgb(239, 247, 253);
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(8, 72);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.Label6.TabIndex = 33;
    this.Label6.Text = "Underwriter:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance4).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblProducerContact).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.lblProducerContact).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.lblProducerContact).ForeColor = Color.Black;
    ((Control) this.lblProducerContact).Location = new Point(144 /*0x90*/, 56);
    ((Control) this.lblProducerContact).Name = "lblProducerContact";
    ((Control) this.lblProducerContact).Size = new Size(272, 16 /*0x10*/);
    ((Control) this.lblProducerContact).TabIndex = 32 /*0x20*/;
    ((ControlBase) this.lblProducerContact).UseMnemonic = false;
    ((ControlBase) this.lblProducerContact).WrapText = false;
    this.Label2.BackColor = Color.FromArgb(239, 247, 253);
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(8, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.Label2.TabIndex = 31 /*0x1F*/;
    this.Label2.Text = "Producer / Contact:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyPeriod.BackColor = Color.FromArgb(239, 247, 253);
    this.lblPolicyPeriod.ForeColor = Color.Black;
    this.lblPolicyPeriod.Location = new Point(504, 88);
    this.lblPolicyPeriod.Name = "lblPolicyPeriod";
    this.lblPolicyPeriod.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblPolicyPeriod.TabIndex = 30;
    this.lblPolicyPeriod.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyPeriod.UseMnemonic = false;
    this.Label5.BackColor = Color.FromArgb(239, 247, 253);
    this.Label5.ForeColor = Color.Black;
    this.Label5.Location = new Point(416, 88);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label5.TabIndex = 29;
    this.Label5.Text = "Policy Period:";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance5).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblCLS).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.lblCLS).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.lblCLS).ForeColor = Color.Black;
    ((Control) this.lblCLS).Location = new Point(144 /*0x90*/, 40);
    ((Control) this.lblCLS).Name = "lblCLS";
    ((Control) this.lblCLS).Size = new Size(272, 16 /*0x10*/);
    ((Control) this.lblCLS).TabIndex = 28;
    ((ControlBase) this.lblCLS).UseMnemonic = false;
    ((ControlBase) this.lblCLS).WrapText = false;
    this.Label4.BackColor = Color.FromArgb(239, 247, 253);
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(8, 40);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.Label4.TabIndex = 27;
    this.Label4.Text = "Company/Line/State:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyNumber.BackColor = Color.FromArgb(239, 247, 253);
    this.lblPolicyNumber.ForeColor = Color.Black;
    this.lblPolicyNumber.Location = new Point(144 /*0x90*/, 24);
    this.lblPolicyNumber.Name = "lblPolicyNumber";
    this.lblPolicyNumber.Size = new Size(272, 16 /*0x10*/);
    this.lblPolicyNumber.TabIndex = 26;
    this.lblPolicyNumber.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyNumber.UseMnemonic = false;
    this.Label3.BackColor = Color.FromArgb(239, 247, 253);
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(8, 24);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(100, 16 /*0x10*/);
    this.Label3.TabIndex = 25;
    this.Label3.Text = "Policy #:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance6).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblInsured).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.lblInsured).BackColorInternal = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.lblInsured).ForeColor = Color.Black;
    ((Control) this.lblInsured).Location = new Point(144 /*0x90*/, 8);
    ((Control) this.lblInsured).Name = "lblInsured";
    ((Control) this.lblInsured).Size = new Size(272, 16 /*0x10*/);
    ((Control) this.lblInsured).TabIndex = 24;
    ((ControlBase) this.lblInsured).UseMnemonic = false;
    ((ControlBase) this.lblInsured).WrapText = false;
    this.Label1.BackColor = Color.FromArgb(239, 247, 253);
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(100, 16 /*0x10*/);
    this.Label1.TabIndex = 23;
    this.Label1.Text = "Insured:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label7.BackColor = Color.FromArgb(239, 247, 253);
    this.Label7.ForeColor = Color.Black;
    this.Label7.Location = new Point(416, 8);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label7.TabIndex = 34;
    this.Label7.Text = "Control #:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    this.lblEndorsementReason.BackColor = Color.FromArgb(239, 247, 253);
    this.lblEndorsementReason.ForeColor = Color.Black;
    this.lblEndorsementReason.Location = new Point(504, 56);
    this.lblEndorsementReason.Name = "lblEndorsementReason";
    this.lblEndorsementReason.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblEndorsementReason.TabIndex = 48 /*0x30*/;
    this.lblEndorsementReason.TextAlign = ContentAlignment.MiddleLeft;
    this.lblEndorsementReason.UseMnemonic = false;
    this.Label11.BackColor = Color.FromArgb(239, 247, 253);
    this.Label11.ForeColor = Color.Black;
    this.Label11.Location = new Point(416, 56);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label11.TabIndex = 47;
    this.Label11.Text = "End. Reason:";
    this.Label11.TextAlign = ContentAlignment.MiddleLeft;
    this.lblAffidavitNumbers.BackColor = Color.FromArgb(239, 247, 253);
    this.lblAffidavitNumbers.ForeColor = Color.Black;
    this.lblAffidavitNumbers.Location = new Point(504, 104);
    this.lblAffidavitNumbers.Name = "lblAffidavitNumbers";
    this.lblAffidavitNumbers.Size = new Size(208 /*0xD0*/, 16 /*0x10*/);
    this.lblAffidavitNumbers.TabIndex = 50;
    this.lblAffidavitNumbers.TextAlign = ContentAlignment.MiddleLeft;
    this.lblAffidavitNumbers.UseMnemonic = false;
    this.lblAffidavitLabel.BackColor = Color.FromArgb(239, 247, 253);
    this.lblAffidavitLabel.ForeColor = Color.Black;
    this.lblAffidavitLabel.Location = new Point(416, 104);
    this.lblAffidavitLabel.Name = "lblAffidavitLabel";
    this.lblAffidavitLabel.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lblAffidavitLabel.TabIndex = 49;
    this.lblAffidavitLabel.Text = "Affidavit #s:";
    this.lblAffidavitLabel.TextAlign = ContentAlignment.MiddleLeft;
    this.tip.ContainingControl = (Control) this;
    this.BackColor = Color.FromArgb(239, 247, 253);
    this.Controls.Add((Control) this.lblAffidavitNumbers);
    this.Controls.Add((Control) this.lblAffidavitLabel);
    this.Controls.Add((Control) this.lblEndorsementReason);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.lblBillingType);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.lblPolicyType);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.lblQuotingLocation);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.lblIssuingLocation);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.lblControlNo);
    this.Controls.Add((Control) this.lblUnderwriter);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.lblProducerContact);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lblPolicyPeriod);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.lblCLS);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblPolicyNumber);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.lblInsured);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Label7);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (PolicyDetail_PolicyInfo);
    this.Size = new Size(720, 128 /*0x80*/);
    this.ResumeLayout(false);
  }

  public PolicyDetail_PolicyInfo(Guid quoteGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
  }

  protected Guid QuoteGuid => this._quoteGuid;

  protected Quote Quote
  {
    get
    {
      if (this._quote == null)
      {
        frmPolicyDetail policyDetailForm = this.PolicyDetailForm;
        this._quote = (policyDetailForm != null ? (Quote) policyDetailForm.Quote : (Quote) null) ?? Quote.CreateNew(this.QuoteGuid);
      }
      return this._quote;
    }
  }

  public frmPolicyDetail PolicyDetailForm => this.ParentForm as frmPolicyDetail;

  internal void ThreadedLoad()
  {
    Thread.Sleep(250);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.spPolicyDetail", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT AffidavitNumber FROM dbo.tblQuoteAffidavitNumbers WITH(NOLOCK) WHERE QuoteID=@QuoteID", new object[2]
    {
      (object) "@QuoteID",
      (object) this.Quote.QuoteID
    });
    string str = string.Empty;
    try
    {
      foreach (DataRow row in dataTable.Rows)
        str = $"{str}{row[0].ToString()}, ";
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (str.Length > 0)
      str = str.Substring(0, str.Length - 2);
    if (this.IsDisposed || this.Disposing)
      return;
    if (!this.IsHandleCreated)
      return;
    try
    {
      this.Invoke((Delegate) new PolicyDetail_PolicyInfo.PolicyDetailDataRetrievedHandler(this.PolicyDetailDataRetrieved), (object) dataRow, (object) str);
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void PolicyDetailDataRetrieved(DataRow dr, string affidavitNumbers)
  {
    try
    {
      ((ControlBase) this.lblInsured).Text = (string) dr["Insured"];
      ((ControlBase) this.lblCLS).Text = (string) dr["CLS"];
      this.lblPolicyNumber.Text = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(dr["PolicyNumber"]), string.Empty);
      Label lblPolicyPeriod = this.lblPolicyPeriod;
      DateTime dateTime = (DateTime) dr["EffectiveDate"];
      string shortDateString1 = dateTime.ToShortDateString();
      dateTime = (DateTime) dr["ExpirationDate"];
      string shortDateString2 = dateTime.ToShortDateString();
      string str = $"{shortDateString1} to {shortDateString2}";
      lblPolicyPeriod.Text = str;
      this.lblControlNo.Text = ((int) dr["ControlNo"]).ToString();
      ((ControlBase) this.lblProducerContact).Text = $"{(string) dr["Producer"]} / {(string) dr["ProducerContact"]}";
      ((ControlBase) this.lblUnderwriter).Text = (string) dr["Underwriter"];
      this.lblBillingType.Text = (string) dr["BillingType"];
      ((ControlBase) this.lblIssuingLocation).Text = (string) dr["IssuingLocation"];
      ((ControlBase) this.lblQuotingLocation).Text = (string) dr["QuotingLocation"];
      this.lblPolicyType.Text = (string) dr["PolicyType"];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Field<string>("PolicyType"), "Renewal", false) == 0 || this.OtherClientRenewalPolicyType(dr))
      {
        this.lblPolicyType.Font = new Font(this.lblPolicyType.Font, System.Drawing.FontStyle.Underline);
        this.lblPolicyType.Cursor = Cursors.Hand;
        this.lblPolicyType.ForeColor = Color.Blue;
        this.lblPolicyType.Click += new EventHandler(this.lblPolicyType_PolicyTypeClick);
      }
      this.lblStatus.Text = (string) dr["Status"];
      this.lblEndorsementReason.Text = (string) dr["Reason"];
      this.lblEndorsementReason.ForeColor = Color.FromArgb(Conversions.ToInteger(dr["ReasonColor"]));
      this.lblAffidavitNumbers.Text = affidavitNumbers;
      ((Control) this.lblInsured).Tag = RuntimeHelpers.GetObjectValue(dr["InsuredGuid"]);
      ((Control) this.lblUnderwriter).Tag = RuntimeHelpers.GetObjectValue(dr["UnderwriterGuid"]);
      ((Control) this.lblIssuingLocation).Tag = RuntimeHelpers.GetObjectValue(dr["IssuingLocationGuid"]);
      ((Control) this.lblQuotingLocation).Tag = RuntimeHelpers.GetObjectValue(dr["QuotingLocationGuid"]);
      ((Control) this.lblCLS).Tag = RuntimeHelpers.GetObjectValue(dr["CompanyLineGuid"]);
      ((Control) this.lblProducerContact).Tag = RuntimeHelpers.GetObjectValue(dr["ProducerLocationGuid"]);
      this.lblControlNo.Tag = RuntimeHelpers.GetObjectValue(dr["ControlNo"]);
      ((Control) this.lblCLS).Enabled = SecurityManager.Instance.AssertPermission("{A43461BA-305B-4911-8AE3-145BCBD9B9F8}");
      ((Control) this.lblIssuingLocation).Enabled = SecurityManager.Instance.AssertPermission("{E3666975-017A-4922-9065-B0AE45835E15}");
      ((Control) this.lblQuotingLocation).Enabled = SecurityManager.Instance.AssertPermission("{E3666975-017A-4922-9065-B0AE45835E15}");
      ((Control) this.lblProducerContact).Enabled = SecurityManager.Instance.AssertPermission("{4544aebc-7f2f-4223-8cba-16ce8d77292c}");
      if (!this.PolicyDetailForm.ValidateCompliance(displayMessage: false))
      {
        ((ControlBase) this.lblInsured).ForeColor = Color.Red;
        ((ControlBase) this.lblInsured).Appearance.ForeColor = Color.Red;
        this.Label1.ForeColor = Color.Red;
      }
      this.LoadComplete();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void lblPolicyType_PolicyTypeClick(object sender, EventArgs e)
  {
    int? nullable = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT RenewalOfControlNum FROM dbo.tblQuotes WHERE QuoteGUID=@QuoteGUID", new object[2]
    {
      (object) "@QuoteGUID",
      (object) this._quoteGuid
    });
    if (nullable.HasValue)
    {
      Form formEx;
      if (this.Quote.IsQuickQuote)
        formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmQuoteEdit), new object[2]
        {
          (object) this.Quote.QuoteGuid,
          (object) this.Quote.SubmissionGroupGuid
        });
      else
        formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyDetail), new object[1]
        {
          (object) nullable.Value
        });
      formEx.StartPosition = FormStartPosition.CenterScreen;
      formEx.MdiParent = MDIControls.Instance.MDIParent;
      formEx.Show();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Expiring Control Number is Invalid", MsgBoxStyle.Critical, (object) "Invalid Expiring Control Number.");
    }
  }

  protected virtual void LoadComplete()
  {
  }

  protected virtual bool OtherClientRenewalPolicyType(DataRow dr) => false;

  private void label_MouseEnter(object sender, EventArgs e)
  {
    this.MouseEnterLabel((UltraLabel) sender);
  }

  private void label_MouseLeave(object sender, EventArgs e)
  {
    this.MouseLeaveLabel((UltraLabel) sender);
  }

  private void MouseEnterLabel(UltraLabel label)
  {
    ((UltraControlBase) label).Cursor = MgaCursors.Hand;
    ((ControlBase) label).ForeColor = Color.Blue;
    ((Control) label).Font = this._underlinedFont;
  }

  private void MouseLeaveLabel(UltraLabel label)
  {
    ((ControlBase) label).ForeColor = this.ForeColor;
    ((Control) label).Font = this.Font;
    this.tip.HideToolTip();
  }

  private void lblInsured_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{96AE58F5-2FB1-4f13-AA6C-1C4B77624EBB}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to open this Insured.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((Control) this.lblInsured).Tag == null)
        return;
      FormSettings.ShowForm(typeof (frmInsureds), new object[1]
      {
        (object) (Guid) ((Control) this.lblInsured).Tag
      });
    }
  }

  private void lblUnderwriter_Click(object sender, EventArgs e)
  {
    if (((Control) this.lblUnderwriter).Tag == null)
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.LaunchUsersScreen, (object) (Guid) ((Control) this.lblUnderwriter).Tag);
  }

  private void Location_Click(object sender, EventArgs e)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(((Control) sender).Tag);
    if (objectValue == null)
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.LaunchOfficeScreen, (object) (Guid) objectValue);
  }

  private void lblCLS_Click(object sender, EventArgs e)
  {
    if (((Control) this.lblCLS).Tag == null)
      return;
    Guid tag = (Guid) ((Control) this.lblCLS).Tag;
    frmCompanyLines formEx = (frmCompanyLines) ObjectFactory.Instance.CreateFormEX(typeof (frmCompanyLines), new object[0]);
    ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
    formEx.CompanyLineGuidFilter = tag;
    ((Control) formEx).Show();
  }

  private void lblProducerContact_Click(object sender, EventArgs e)
  {
    if (((Control) this.lblProducerContact).Tag == null)
      return;
    Guid tag = (Guid) ((Control) this.lblProducerContact).Tag;
    FormSettings.ShowForm(typeof (frmProducers), new object[2]
    {
      (object) new ProducerLocation(tag).ProducerGuid,
      (object) tag
    });
  }

  private void lblInsured_MouseHover(object sender, EventArgs e)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetInsuredInfoThread));
  }

  private void GetInsuredInfoThread(object state)
  {
    try
    {
      if (((Control) this.lblInsured).Tag == null)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._insuredAddress, string.Empty, false) == 0)
      {
        DataRow row = DefaultDatabase.ExecuteDataRow("GetInsuredAddressPolicyDetailHoverLink", new object[4]
        {
          (object) "@controlno",
          this.lblControlNo.Tag,
          (object) "@InsuredGuid",
          ((Control) this.lblInsured).Tag
        });
        if (row == null || row.IsNull("Address1"))
          return;
        StringBuilder stringBuilder = new StringBuilder($"{row.Field<string>("Address1")}" + $", {row.Field<string>("Address2")}".TrimStart(',', ' ') + $"{"\n"}{row.Field<string>("City")}, {row.Field<string>("State")}, {row.Field<string>("ZipCode")} {"\n"}{row.Field<string>("InsuredCounty")} County");
        if (!string.IsNullOrEmpty(row.Field<string>("ZipPlus")))
          stringBuilder.Append($"-{row.Field<string>("ZipPlus")}");
        if (!string.IsNullOrEmpty(row.Field<string>("Phone")))
          stringBuilder.Append($"{"\n"}Phone: {row.Field<string>("Phone")}");
        if (!string.IsNullOrEmpty(row.Field<string>("Fax")))
          stringBuilder.Append($"{"\n"}Fax: {row.Field<string>("Fax")}");
        this._insuredAddress = stringBuilder.ToString();
      }
      this.ShowTip((Control) this.lblInsured, ((ControlBase) this.lblInsured).Text, this._insuredAddress);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ShowTip(Control parent, string title, string text)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new Action<Control, string, string>(this.ShowTip), (object) parent, (object) title, (object) text);
    }
    else
    {
      UltraToolTipInfo info = this._info;
      info.ToolTipText = text;
      info.ToolTipTitle = title;
      info.ToolTipImage = (ToolTipImage) 3;
      this.tip.SetUltraToolTip(parent, this._info);
      this.tip.ShowToolTip(parent);
    }
  }

  private void ShowTip(Control parent, string text)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new Action<Control, string>(this.ShowTip), (object) parent, (object) text);
    }
    else
    {
      this._info.ToolTipText = text;
      this.tip.SetUltraToolTip(parent, this._info);
      this.tip.ShowToolTip(parent);
    }
  }

  private void LblEndorsementReason_MouseHover(object sender, EventArgs e)
  {
    this.ShowTip((Control) this.lblEndorsementReason, this.lblEndorsementReason.Text);
  }

  private delegate void PolicyDetailDataRetrievedHandler(DataRow dr, string affidavitNumbers);
}
