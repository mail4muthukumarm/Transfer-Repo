// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AffidavitNumbering.frmAdminAffidavitNumbers
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.AffidavitNumbering;

[SecureResource("{3FEEBEF1-FC30-4554-8A23-6E9EB84B20D5}", "Can View / Access Affidavit Numbers Menu", "Controls whether or not a user can view / access Affidavit Numbers menu item.", "Quotes")]
public sealed class frmAdminAffidavitNumbers : Form
{
  private IContainer components;
  private ToolTip ToolTip1;
  private MGANumericEditor udStart;
  private MGANumericEditor udEnd;
  private MGATextBox txtPrefix;
  private MGANumericEditor udMinDigits;
  private MGATextBox txtCustomSuffix;
  private RadioButton rbCustomSuffix;
  private RadioButton rbUseYearSuffix;
  private MGACheckBox chkDash;
  private ErrorProvider err;
  private Panel Panel1;
  private Panel Panel2;
  private RadioButton rbTwoDigit;
  private RadioButton rbFourDigit;
  private MGADateTimePicker dtRenumberDate;
  private UltraLabel lblSample;
  private DbDataAdapter da;
  private dsAdminAffidavitNumbers ds;
  private RadioButton rbEffective;
  private RadioButton rbBilling;
  private MGAGroupBox MgaGroupBox1;
  private Panel panelAutomationTypes;
  private MGACheckBox chkRequiredForBinding;
  private RequiredFieldValidator RequiredFieldValidator1;
  private RequiredFieldValidator RequiredFieldValidator2;
  private RequiredFieldValidator RequiredFieldValidator3;
  private MGACheckBox chkExportable;
  private MGACheckBox chkTaxExempt;
  private MGACheckBox chkBound;
  private MGAComboBox cboQuotingOffice;
  private Label Label7;
  private string _stateID;
  private bool _clickingNew;
  private Guid _quotingOfficeGuid;
  private bool _formLoading;
  public const string CanViewAdminAffidavitNumbers = "{3FEEBEF1-FC30-4554-8A23-6E9EB84B20D5}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGACheckBox chkResetNumbering
  {
    get => this._chkResetNumbering;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkResetNumbering_CheckedChanged);
      MGACheckBox chkResetNumbering1 = this._chkResetNumbering;
      if (chkResetNumbering1 != null)
        ((UltraToggleEditorBase) chkResetNumbering1).CheckedChanged -= eventHandler;
      this._chkResetNumbering = value;
      MGACheckBox chkResetNumbering2 = this._chkResetNumbering;
      if (chkResetNumbering2 == null)
        return;
      ((UltraToggleEditorBase) chkResetNumbering2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("rbAutomated")]
  private virtual RadioButton rbAutomated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual RadioButton rbManual
  {
    get => this._rbManual;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbManual_CheckedChanged);
      RadioButton rbManual1 = this._rbManual;
      if (rbManual1 != null)
        rbManual1.CheckedChanged -= eventHandler;
      this._rbManual = value;
      RadioButton rbManual2 = this._rbManual;
      if (rbManual2 == null)
        return;
      rbManual2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged1);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingCancel -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingEdit -= cancelEventHandler3;
        dbSave1.ClickingNew -= cancelEventHandler4;
        dbSave1.ClickingSave -= cancelEventHandler5;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingCancel += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingEdit += cancelEventHandler3;
      dbSave2.ClickingNew += cancelEventHandler4;
      dbSave2.ClickingSave += cancelEventHandler5;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddQuotingOffice")]
  private virtual UltraDropDown ddQuotingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UltraGrid1_AfterRowActivate);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
        ultraGrid1_1.AfterRowActivate -= eventHandler;
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkSwapSuffixAndAffNum")]
  private virtual MGACheckBox chkSwapSuffixAndAffNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvQuotingOffice")]
  private virtual DataView dvQuotingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdminAffidavitNumbers));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OfficeGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("State");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("OfficeGUID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("State");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblAdminAffidavitNumbers", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StartNum");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("EndNum");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("MinDigits");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Prefix");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("SeparateSuffixWithDash");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CustomSuffix");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("TwoDigitYear");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("FourDigitYear");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("BasedOn");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ResetEachYear");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ResetOn");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ManualEntry");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("RequiredForBinding");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Exportable");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("TaxExempt");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ShareNos");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("QuotingOfficeGUID", -1, (object) "ddQuotingOffice");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("SwapSuffixAndAffNum");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.udStart = new MGANumericEditor();
    this.udEnd = new MGANumericEditor();
    this.txtPrefix = new MGATextBox();
    this.txtCustomSuffix = new MGATextBox();
    this.rbCustomSuffix = new RadioButton();
    this.rbUseYearSuffix = new RadioButton();
    this.rbTwoDigit = new RadioButton();
    this.chkDash = new MGACheckBox();
    this.rbFourDigit = new RadioButton();
    this.chkResetNumbering = new MGACheckBox();
    this.lblSample = new UltraLabel();
    this.udMinDigits = new MGANumericEditor();
    this.rbEffective = new RadioButton();
    this.rbBilling = new RadioButton();
    this.dtRenumberDate = new MGADateTimePicker();
    this.ToolTip1 = new ToolTip(this.components);
    this.chkTaxExempt = new MGACheckBox();
    this.chkExportable = new MGACheckBox();
    this.err = new ErrorProvider(this.components);
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.chkSwapSuffixAndAffNum = new MGACheckBox();
    this.Label7 = new Label();
    this.cboQuotingOffice = new MGAComboBox();
    this.ds = new dsAdminAffidavitNumbers();
    this.chkBound = new MGACheckBox();
    this.chkRequiredForBinding = new MGACheckBox();
    this.panelAutomationTypes = new Panel();
    this.rbManual = new RadioButton();
    this.rbAutomated = new RadioButton();
    this.RequiredFieldValidator1 = new RequiredFieldValidator(this.components);
    this.RequiredFieldValidator2 = new RequiredFieldValidator(this.components);
    this.RequiredFieldValidator3 = new RequiredFieldValidator(this.components);
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.ddQuotingOffice = new UltraDropDown();
    this.UltraGrid1 = new UltraGrid();
    this.dvQuotingOffice = new DataView();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    DbCommand command1 = DefaultDatabase.CreateCommand();
    DbCommand command2 = DefaultDatabase.CreateCommand();
    DbCommand command3 = DefaultDatabase.CreateCommand();
    DbCommand command4 = DefaultDatabase.CreateCommand();
    Label label7 = new Label();
    ((ISupportInitialize) this.udStart).BeginInit();
    ((ISupportInitialize) this.udEnd).BeginInit();
    ((ISupportInitialize) this.txtPrefix).BeginInit();
    ((ISupportInitialize) this.txtCustomSuffix).BeginInit();
    ((ISupportInitialize) this.chkDash).BeginInit();
    ((ISupportInitialize) this.chkResetNumbering).BeginInit();
    ((ISupportInitialize) this.udMinDigits).BeginInit();
    ((ISupportInitialize) this.dtRenumberDate).BeginInit();
    ((ISupportInitialize) this.chkTaxExempt).BeginInit();
    ((ISupportInitialize) this.chkExportable).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.chkSwapSuffixAndAffNum).BeginInit();
    ((ISupportInitialize) this.cboQuotingOffice).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.chkBound).BeginInit();
    ((ISupportInitialize) this.chkRequiredForBinding).BeginInit();
    this.panelAutomationTypes.SuspendLayout();
    ((ISupportInitialize) this.RequiredFieldValidator1).BeginInit();
    ((ISupportInitialize) this.RequiredFieldValidator2).BeginInit();
    ((ISupportInitialize) this.RequiredFieldValidator3).BeginInit();
    ((ISupportInitialize) this.ddQuotingOffice).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.dvQuotingOffice.BeginInit();
    this.SuspendLayout();
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(230, 45);
    label1.Name = "Label2";
    label1.Size = new Size(40, 23);
    label1.TabIndex = 3;
    label1.Text = "Start:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(352, 45);
    label2.Name = "Label3";
    label2.Size = new Size(40, 23);
    label2.TabIndex = 5;
    label2.Text = "End:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(24, 160 /*0xA0*/);
    label3.Name = "Label4";
    label3.Size = new Size(40, 23);
    label3.TabIndex = 9;
    label3.Text = "Suffix:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(24, 132);
    label4.Name = "Label5";
    label4.Size = new Size(40, 23);
    label4.TabIndex = 7;
    label4.Text = "Prefix:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(144 /*0x90*/, 355);
    label5.Name = "Label1";
    label5.Size = new Size(45, 13);
    label5.TabIndex = 23;
    label5.Text = "Sample:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(8, 107);
    label6.Name = "Label8";
    label6.Size = new Size(55, 13);
    label6.TabIndex = 26;
    label6.Text = "Min digits:";
    label6.TextAlign = ContentAlignment.MiddleRight;
    command1.CommandText = "DELETE FROM dbo.tblAdminAffidavitNumbers\r\nWHERE     (StateID = @Original_StateID) AND (QuotingOfficeGUID = @Original_QuotingOfficeGUID)";
    command1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.Char, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_QuotingOfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuotingOfficeGUID", DataRowVersion.Original, (object) null)
    });
    command2.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    command2.Parameters.AddRange((Array) new DbParameter[19]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@StartNum", SqlDbType.Int, 4, "StartNum"),
      DefaultDatabase.CreateParameter("@EndNum", SqlDbType.Int, 4, "EndNum"),
      DefaultDatabase.CreateParameter("@MinDigits", SqlDbType.TinyInt, 1, "MinDigits"),
      DefaultDatabase.CreateParameter("@Prefix", SqlDbType.VarChar, 10, "Prefix"),
      DefaultDatabase.CreateParameter("@SeparateSuffixWithDash", SqlDbType.Bit, 1, "SeparateSuffixWithDash"),
      DefaultDatabase.CreateParameter("@CustomSuffix", SqlDbType.VarChar, 10, "CustomSuffix"),
      DefaultDatabase.CreateParameter("@TwoDigitYear", SqlDbType.Bit, 1, "TwoDigitYear"),
      DefaultDatabase.CreateParameter("@FourDigitYear", SqlDbType.Bit, 1, "FourDigitYear"),
      DefaultDatabase.CreateParameter("@BasedOn", SqlDbType.Char, 1, "BasedOn"),
      DefaultDatabase.CreateParameter("@ResetEachYear", SqlDbType.Bit, 1, "ResetEachYear"),
      DefaultDatabase.CreateParameter("@ResetOn", SqlDbType.DateTime, 8, "ResetOn"),
      DefaultDatabase.CreateParameter("@ManualEntry", SqlDbType.Bit, 1, "ManualEntry"),
      DefaultDatabase.CreateParameter("@RequiredForBinding", SqlDbType.Bit, 1, "RequiredForBinding"),
      DefaultDatabase.CreateParameter("@Exportable", SqlDbType.Bit, 1, "Exportable"),
      DefaultDatabase.CreateParameter("@TaxExempt", SqlDbType.Bit, 1, "TaxExempt"),
      DefaultDatabase.CreateParameter("@ShareNos", SqlDbType.Bit, 1, "ShareNos"),
      DefaultDatabase.CreateParameter("@QuotingOfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuotingOfficeGUID"),
      DefaultDatabase.CreateParameter("@SwapSuffixAndAffNum", SqlDbType.Bit, 1, "SwapSuffixAndAffNum")
    });
    command3.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    command3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID")
    });
    command4.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    command4.Parameters.AddRange((Array) new DbParameter[20]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@StartNum", SqlDbType.Int, 4, "StartNum"),
      DefaultDatabase.CreateParameter("@EndNum", SqlDbType.Int, 4, "EndNum"),
      DefaultDatabase.CreateParameter("@MinDigits", SqlDbType.TinyInt, 1, "MinDigits"),
      DefaultDatabase.CreateParameter("@Prefix", SqlDbType.VarChar, 10, "Prefix"),
      DefaultDatabase.CreateParameter("@SeparateSuffixWithDash", SqlDbType.Bit, 1, "SeparateSuffixWithDash"),
      DefaultDatabase.CreateParameter("@CustomSuffix", SqlDbType.VarChar, 10, "CustomSuffix"),
      DefaultDatabase.CreateParameter("@TwoDigitYear", SqlDbType.Bit, 1, "TwoDigitYear"),
      DefaultDatabase.CreateParameter("@FourDigitYear", SqlDbType.Bit, 1, "FourDigitYear"),
      DefaultDatabase.CreateParameter("@BasedOn", SqlDbType.Char, 1, "BasedOn"),
      DefaultDatabase.CreateParameter("@ResetEachYear", SqlDbType.Bit, 1, "ResetEachYear"),
      DefaultDatabase.CreateParameter("@ResetOn", SqlDbType.DateTime, 8, "ResetOn"),
      DefaultDatabase.CreateParameter("@ManualEntry", SqlDbType.Bit, 1, "ManualEntry"),
      DefaultDatabase.CreateParameter("@RequiredForBinding", SqlDbType.Bit, 1, "RequiredForBinding"),
      DefaultDatabase.CreateParameter("@Exportable", SqlDbType.Bit, 1, "Exportable"),
      DefaultDatabase.CreateParameter("@TaxExempt", SqlDbType.Bit, 1, "TaxExempt"),
      DefaultDatabase.CreateParameter("@ShareNos", SqlDbType.Bit, 1, "ShareNos"),
      DefaultDatabase.CreateParameter("@QuotingOfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuotingOfficeGUID"),
      DefaultDatabase.CreateParameter("@SwapSuffixAndAffNum", SqlDbType.Bit, 1, "SwapSuffixAndAffNum"),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.Char, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null)
    });
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(110, 324);
    label7.Name = "Label6";
    label7.Size = new Size(81, 13);
    label7.TabIndex = 39;
    label7.Text = "Quoting Office:";
    label7.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.LightYellow;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udStart).Appearance = (AppearanceBase) appearance1;
    ((Control) this.udStart).Location = new Point(280, 46);
    ((UltraNumericEditor) this.udStart).MaskInput = "nnnnn";
    ((UltraNumericEditor) this.udStart).MaxValue = (object) 99999;
    this.udStart.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.udStart).MinValue = (object) 0;
    ((Control) this.udStart).Name = "udStart";
    ((UltraNumericEditor) this.udStart).Nullable = true;
    ((Control) this.udStart).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.udStart).TabIndex = 2;
    ((UltraControlBase) this.udStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udStart).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.LightYellow;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udEnd).Appearance = (AppearanceBase) appearance2;
    ((Control) this.udEnd).Location = new Point(400, 46);
    ((UltraNumericEditor) this.udEnd).MaskInput = "nnnnn";
    ((UltraNumericEditor) this.udEnd).MaxValue = (object) 99999;
    this.udEnd.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.udEnd).MinValue = (object) 0;
    ((Control) this.udEnd).Name = "udEnd";
    ((UltraNumericEditor) this.udEnd).Nullable = true;
    ((Control) this.udEnd).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.udEnd).TabIndex = 4;
    ((UltraControlBase) this.udEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udEnd).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.udEnd).Value = (object) new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPrefix).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtPrefix).BackColor = Color.White;
    ((Control) this.txtPrefix).Location = new Point(72, 133);
    ((TextEditorControlBase) this.txtPrefix).MaxLength = 10;
    this.txtPrefix.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPrefix).Name = "txtPrefix";
    ((Control) this.txtPrefix).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.txtPrefix).TabIndex = 10;
    ((UltraControlBase) this.txtPrefix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPrefix).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCustomSuffix).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtCustomSuffix).BackColor = Color.White;
    ((Control) this.txtCustomSuffix).Location = new Point(120, 32 /*0x20*/);
    ((TextEditorControlBase) this.txtCustomSuffix).MaxLength = 10;
    this.txtCustomSuffix.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtCustomSuffix).Name = "txtCustomSuffix";
    ((Control) this.txtCustomSuffix).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.txtCustomSuffix).TabIndex = 11;
    ((UltraControlBase) this.txtCustomSuffix).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCustomSuffix).UseOsThemes = (DefaultableBoolean) 2;
    this.rbCustomSuffix.Checked = true;
    this.rbCustomSuffix.Location = new Point(8, 32 /*0x20*/);
    this.rbCustomSuffix.Name = "rbCustomSuffix";
    this.rbCustomSuffix.Size = new Size(104, 23);
    this.rbCustomSuffix.TabIndex = 12;
    this.rbCustomSuffix.TabStop = true;
    this.rbCustomSuffix.Text = "Custom suffix";
    this.rbUseYearSuffix.Location = new Point(8, 60);
    this.rbUseYearSuffix.Name = "rbUseYearSuffix";
    this.rbUseYearSuffix.Size = new Size(168, 20);
    this.rbUseYearSuffix.TabIndex = 13;
    this.rbUseYearSuffix.Text = "Use affidavit year for suffix";
    this.rbTwoDigit.Checked = true;
    this.rbTwoDigit.Location = new Point(8, 6);
    this.rbTwoDigit.Name = "rbTwoDigit";
    this.rbTwoDigit.Size = new Size(96 /*0x60*/, 24);
    this.rbTwoDigit.TabIndex = 15;
    this.rbTwoDigit.TabStop = true;
    this.rbTwoDigit.Text = "Two digit year";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDash).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkDash).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDash).Location = new Point(8, 8);
    this.chkDash.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkDash).Name = "chkDash";
    ((Control) this.chkDash).Size = new Size(136, 24);
    ((Control) this.chkDash).TabIndex = 16 /*0x10*/;
    ((UltraToggleEditorBase) this.chkDash).Text = "Separate with a dash";
    ((UltraControlBase) this.chkDash).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDash).UseOsThemes = (DefaultableBoolean) 2;
    this.rbFourDigit.Location = new Point(112 /*0x70*/, 6);
    this.rbFourDigit.Name = "rbFourDigit";
    this.rbFourDigit.Size = new Size(97, 24);
    this.rbFourDigit.TabIndex = 17;
    this.rbFourDigit.Text = "Four digit year";
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkResetNumbering).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkResetNumbering).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkResetNumbering).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkResetNumbering).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkResetNumbering).Location = new Point(80 /*0x50*/, 256 /*0x0100*/);
    this.chkResetNumbering.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkResetNumbering).Name = "chkResetNumbering";
    ((Control) this.chkResetNumbering).Size = new Size(184, 24);
    ((Control) this.chkResetNumbering).TabIndex = 18;
    ((UltraToggleEditorBase) this.chkResetNumbering).Text = "Reset numbering each year on";
    ((UltraControlBase) this.chkResetNumbering).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkResetNumbering).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblSample).Appearance = (AppearanceBase) appearance7;
    this.lblSample.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblSample).Location = new Point(192 /*0xC0*/, 349);
    ((Control) this.lblSample).Name = "lblSample";
    ((Control) this.lblSample).Size = new Size(136, 24);
    ((Control) this.lblSample).TabIndex = 24;
    ((ControlBase) this.lblSample).Text = "12345-12345";
    appearance8.BackColor = Color.LightYellow;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.udMinDigits).Appearance = (AppearanceBase) appearance8;
    ((Control) this.udMinDigits).Location = new Point(72, 105);
    ((UltraNumericEditor) this.udMinDigits).MaskInput = "nnnnn";
    ((UltraNumericEditor) this.udMinDigits).MaxValue = (object) new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.udMinDigits.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.udMinDigits).MinValue = (object) 1;
    ((Control) this.udMinDigits).Name = "udMinDigits";
    ((UltraNumericEditor) this.udMinDigits).Nullable = true;
    ((Control) this.udMinDigits).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.udMinDigits).TabIndex = 25;
    ((UltraControlBase) this.udMinDigits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.udMinDigits).UseOsThemes = (DefaultableBoolean) 2;
    this.rbEffective.BackColor = Color.Transparent;
    this.rbEffective.Checked = true;
    this.rbEffective.Location = new Point(264, 283);
    this.rbEffective.Name = "rbEffective";
    this.rbEffective.Size = new Size(96 /*0x60*/, 30);
    this.rbEffective.TabIndex = 28;
    this.rbEffective.TabStop = true;
    this.rbEffective.Text = "Effective date";
    this.rbEffective.UseVisualStyleBackColor = false;
    this.rbBilling.BackColor = Color.Transparent;
    this.rbBilling.Location = new Point(368, 283);
    this.rbBilling.Name = "rbBilling";
    this.rbBilling.Size = new Size(96 /*0x60*/, 30);
    this.rbBilling.TabIndex = 29;
    this.rbBilling.Text = "Billing date";
    this.rbBilling.UseVisualStyleBackColor = false;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtRenumberDate).Appearance = (AppearanceBase) appearance9;
    appearance10.AlphaLevel = (short) 14;
    appearance10.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance10.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance10.BackColorAlpha = (Alpha) 2;
    appearance10.BackGradientAlignment = (GradientAlignment) 4;
    appearance10.BackGradientStyle = (GradientStyle) 5;
    appearance10.BorderAlpha = (Alpha) 1;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    appearance10.ForeColor = Color.FromArgb(49, 85, 153);
    appearance10.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtRenumberDate).ButtonAppearance = (AppearanceBase) appearance10;
    ((UltraDateTimeEditor) this.dtRenumberDate).DateTime = new DateTime(2004, 1, 1, 15, 50, 0, 0);
    ((Control) this.dtRenumberDate).Enabled = false;
    ((Control) this.dtRenumberDate).Location = new Point(264, 258);
    this.dtRenumberDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtRenumberDate).Name = "dtRenumberDate";
    ((Control) this.dtRenumberDate).Size = new Size(116, 20);
    ((Control) this.dtRenumberDate).TabIndex = 20;
    this.ToolTip1.SetToolTip((Control) this.dtRenumberDate, "Please select the day and the month that the affidavit numbering resets.  The year is ignored.");
    ((UltraControlBase) this.dtRenumberDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtRenumberDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtRenumberDate).Value = (object) new DateTime(2004, 1, 1, 15, 50, 0, 0);
    appearance11.BorderColor = Color.Gray;
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkTaxExempt).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkTaxExempt).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTaxExempt).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTaxExempt).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkTaxExempt).Location = new Point(240 /*0xF0*/, 119);
    ((Control) this.chkTaxExempt).Name = "chkTaxExempt";
    ((Control) this.chkTaxExempt).Size = new Size(120, 21);
    ((Control) this.chkTaxExempt).TabIndex = 36;
    ((UltraToggleEditorBase) this.chkTaxExempt).Text = "Tax Exempt Prompt";
    this.ToolTip1.SetToolTip((Control) this.chkTaxExempt, "Ask the user whether the risk is tax exempt when number is assigned");
    ((UltraControlBase) this.chkTaxExempt).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTaxExempt).UseOsThemes = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.Gray;
    appearance12.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExportable).Appearance = (AppearanceBase) appearance12;
    ((UltraToggleEditorBase) this.chkExportable).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExportable).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExportable).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkExportable).Location = new Point(240 /*0xF0*/, 99);
    ((Control) this.chkExportable).Name = "chkExportable";
    ((Control) this.chkExportable).Size = new Size(144 /*0x90*/, 14);
    ((Control) this.chkExportable).TabIndex = 35;
    ((UltraToggleEditorBase) this.chkExportable).Text = "Exportable Prompt";
    this.ToolTip1.SetToolTip((Control) this.chkExportable, "Ask the user whether the risk is exportable when number is assigned");
    ((UltraControlBase) this.chkExportable).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExportable).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.rbCustomSuffix);
    this.Panel1.Controls.Add((Control) this.rbUseYearSuffix);
    this.Panel1.Controls.Add((Control) this.txtCustomSuffix);
    this.Panel1.Controls.Add((Control) this.chkDash);
    this.Panel1.Location = new Point(72, 160 /*0xA0*/);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(192 /*0xC0*/, 88);
    this.Panel1.TabIndex = 30;
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.rbTwoDigit);
    this.Panel2.Controls.Add((Control) this.rbFourDigit);
    this.Panel2.Location = new Point(270, 213);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(212, 35);
    this.Panel2.TabIndex = 31 /*0x1F*/;
    this.da.DeleteCommand = command1;
    this.da.InsertCommand = command2;
    this.da.SelectCommand = command3;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblAdminAffidavitNumbers", new DataColumnMapping[18]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("StartNum", "StartNum"),
        new DataColumnMapping("EndNum", "EndNum"),
        new DataColumnMapping("MinDigits", "MinDigits"),
        new DataColumnMapping("Prefix", "Prefix"),
        new DataColumnMapping("SeparateSuffixWithDash", "SeparateSuffixWithDash"),
        new DataColumnMapping("CustomSuffix", "CustomSuffix"),
        new DataColumnMapping("TwoDigitYear", "TwoDigitYear"),
        new DataColumnMapping("FourDigitYear", "FourDigitYear"),
        new DataColumnMapping("BasedOn", "BasedOn"),
        new DataColumnMapping("ResetEachYear", "ResetEachYear"),
        new DataColumnMapping("ResetOn", "ResetOn"),
        new DataColumnMapping("ManualEntry", "ManualEntry"),
        new DataColumnMapping("RequiredForBinding", "RequiredForBinding"),
        new DataColumnMapping("Exportable", "Exportable"),
        new DataColumnMapping("TaxExempt", "TaxExempt"),
        new DataColumnMapping("ShareNos", "ShareNos"),
        new DataColumnMapping("QuotingOfficeGUID", "QuotingOfficeGUID")
      })
    });
    this.da.UpdateCommand = command4;
    appearance13.BackColor = Color.FromArgb(239, 247, 253);
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance13;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkSwapSuffixAndAffNum);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label7);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboQuotingOffice);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkBound);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkTaxExempt);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkExportable);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkRequiredForBinding);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.panelAutomationTypes);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtRenumberDate);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkResetNumbering);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label5);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblSample);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.udMinDigits);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.rbEffective);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.rbBilling);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.udStart);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Panel1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Panel2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.udEnd);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) label4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtPrefix);
    appearance14.AlphaLevel = (short) 230;
    appearance14.FontData.SizeInPoints = 10f;
    appearance14.ForeColor = Color.White;
    appearance14.ForegroundAlpha = (Alpha) 2;
    appearance14.ImageAlpha = (Alpha) 2;
    appearance14.ImageBackground = (Image) componentResourceManager.GetObject("Appearance32.ImageBackground");
    appearance14.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    ((UltraGroupBox) this.MgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance14;
    ((Control) this.MgaGroupBox1).Location = new Point(4, 186);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(509, 393);
    ((Control) this.MgaGroupBox1).TabIndex = 35;
    ((UltraGroupBox) this.MgaGroupBox1).Text = "Affidavit Automation Configuration";
    ((UltraGroupBox) this.MgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    appearance15.BorderColor = Color.Gray;
    appearance15.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkSwapSuffixAndAffNum).Location = new Point(240 /*0xF0*/, 79);
    ((Control) this.chkSwapSuffixAndAffNum).Name = "chkSwapSuffixAndAffNum";
    ((Control) this.chkSwapSuffixAndAffNum).Size = new Size(162, 14);
    ((Control) this.chkSwapSuffixAndAffNum).TabIndex = 41;
    ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).Text = "Swap Suffix And Affidavit #";
    ((UltraControlBase) this.chkSwapSuffixAndAffNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkSwapSuffixAndAffNum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(129, 292);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(124, 13);
    this.Label7.TabIndex = 40;
    this.Label7.Text = "Affidavit year based on:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboQuotingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboQuotingOffice).CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboQuotingOffice).DataMember = "tblClientOffices";
    ((UltraGridBase) this.cboQuotingOffice).DataSource = (object) this.ds;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboQuotingOffice.DisplayLayout.Appearance = (AppearanceBase) appearance16;
    this.cboQuotingOffice.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 178;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 148;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.MaxLength = 25;
    ultraGridColumn3.Width = 85;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.MaxLength = 25;
    ultraGridColumn4.Width = 119;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 119;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    this.cboQuotingOffice.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboQuotingOffice.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboQuotingOffice.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboQuotingOffice.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance17.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance17.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboQuotingOffice.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance17;
    appearance18.BorderColor = Color.White;
    this.cboQuotingOffice.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    this.cboQuotingOffice.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance19.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance19.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance19.ForeColor = Color.Black;
    this.cboQuotingOffice.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboQuotingOffice.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboQuotingOffice).DisplayMember = "Location";
    ((UltraCombo) this.cboQuotingOffice).DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    ((UltraCombo) this.cboQuotingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboQuotingOffice).DropDownWidth = 490;
    ((Control) this.cboQuotingOffice).Location = new Point(193, 320);
    ((MGASimpleComboBox) this.cboQuotingOffice).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboQuotingOffice).Name = "cboQuotingOffice";
    ((Control) this.cboQuotingOffice).Size = new Size(272, 21);
    ((Control) this.cboQuotingOffice).TabIndex = 38;
    ((UltraControlBase) this.cboQuotingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboQuotingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboQuotingOffice).ValueMember = "OfficeGUID";
    this.ds.DataSetName = "dsAdminAffidavitNumbers";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance20.BorderColor = Color.Gray;
    appearance20.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkBound).Appearance = (AppearanceBase) appearance20;
    ((UltraToggleEditorBase) this.chkBound).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBound).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkBound).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkBound).Location = new Point(240 /*0xF0*/, 138);
    ((Control) this.chkBound).Name = "chkBound";
    ((Control) this.chkBound).Size = new Size(224 /*0xE0*/, 22);
    ((Control) this.chkBound).TabIndex = 37;
    ((UltraToggleEditorBase) this.chkBound).Text = "Share Number For All Risk in Submission";
    ((UltraControlBase) this.chkBound).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkBound).UseOsThemes = (DefaultableBoolean) 2;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance21.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRequiredForBinding).Appearance = (AppearanceBase) appearance21;
    ((UltraToggleEditorBase) this.chkRequiredForBinding).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRequiredForBinding).BackColorInternal = Color.Transparent;
    ((Control) this.chkRequiredForBinding).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblAdminAffidavitNumbers.RequiredForBinding", true));
    ((UltraToggleEditorBase) this.chkRequiredForBinding).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRequiredForBinding).Location = new Point(11, 77);
    this.chkRequiredForBinding.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkRequiredForBinding).Name = "chkRequiredForBinding";
    ((Control) this.chkRequiredForBinding).Size = new Size(143, 24);
    ((Control) this.chkRequiredForBinding).TabIndex = 34;
    ((Control) this.chkRequiredForBinding).Tag = (object) "KeepEnabled";
    ((UltraToggleEditorBase) this.chkRequiredForBinding).Text = "Required For Binding";
    ((UltraControlBase) this.chkRequiredForBinding).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRequiredForBinding).UseOsThemes = (DefaultableBoolean) 2;
    this.panelAutomationTypes.BackColor = Color.Transparent;
    this.panelAutomationTypes.Controls.Add((Control) this.rbManual);
    this.panelAutomationTypes.Controls.Add((Control) this.rbAutomated);
    this.panelAutomationTypes.Location = new Point(11, 36);
    this.panelAutomationTypes.Name = "panelAutomationTypes";
    this.panelAutomationTypes.Size = new Size(213, 35);
    this.panelAutomationTypes.TabIndex = 33;
    this.panelAutomationTypes.Tag = (object) "KeepEnabled";
    this.rbManual.Location = new Point(101, 8);
    this.rbManual.Name = "rbManual";
    this.rbManual.Size = new Size(104, 24);
    this.rbManual.TabIndex = 17;
    this.rbManual.Text = "Manual";
    this.rbAutomated.Checked = true;
    this.rbAutomated.Location = new Point(8, 8);
    this.rbAutomated.Name = "rbAutomated";
    this.rbAutomated.Size = new Size(96 /*0x60*/, 24);
    this.rbAutomated.TabIndex = 15;
    this.rbAutomated.TabStop = true;
    this.rbAutomated.Text = "Automated";
    ((ValidatorBase) this.RequiredFieldValidator1).ControlToValidate = (Control) this.udStart;
    ((ValidatorBase) this.RequiredFieldValidator1).Enabled = true;
    ((ValidatorBase) this.RequiredFieldValidator1).FieldToValidate = "Value";
    ((ValidatorBase) this.RequiredFieldValidator2).ControlToValidate = (Control) this.udEnd;
    ((ValidatorBase) this.RequiredFieldValidator2).Enabled = true;
    ((ValidatorBase) this.RequiredFieldValidator2).FieldToValidate = "Value";
    ((ValidatorBase) this.RequiredFieldValidator3).ControlToValidate = (Control) this.udMinDigits;
    ((ValidatorBase) this.RequiredFieldValidator3).Enabled = true;
    ((ValidatorBase) this.RequiredFieldValidator3).FieldToValidate = "Value";
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(401, 585);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 36;
    this.dbSave.UIState = (UIState) 1;
    ((UltraGridBase) this.ddQuotingOffice).DataSource = (object) this.ds.tblClientOffices;
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Appearance = (AppearanceBase) appearance22;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddQuotingOffice).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddQuotingOffice).DisplayMember = "Location";
    ((Control) this.ddQuotingOffice).Location = new Point(217, 65);
    ((Control) this.ddQuotingOffice).Name = "ddQuotingOffice";
    ((Control) this.ddQuotingOffice).Size = new Size(167, 66);
    ((Control) this.ddQuotingOffice).TabIndex = 38;
    ((UltraDropDownBase) this.ddQuotingOffice).ValueMember = "OfficeGUID";
    ((Control) this.ddQuotingOffice).Visible = false;
    ((UltraGridBase) this.UltraGrid1).DataMember = "tblAdminAffidavitNumbers";
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds;
    appearance23.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance23;
    appearance24.BackColor = Color.WhiteSmoke;
    appearance24.BorderColor = Color.WhiteSmoke;
    appearance24.FontData.UnderlineAsString = "True";
    appearance24.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance24;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.AddButtonCaption = "Click here to add a new warranty";
    ((HeaderBase) ultraGridColumn11.Header).Caption = "State";
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Width = 53;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Start Number";
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 132;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "End Number";
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn13.Width = 89;
    ultraGridColumn14.Header.VisiblePosition = 3;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 10;
    ultraGridColumn15.Header.VisiblePosition = 4;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 29;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 40;
    ultraGridColumn17.Header.VisiblePosition = 6;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 29;
    ultraGridColumn18.Header.VisiblePosition = 7;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 24;
    ultraGridColumn19.Header.VisiblePosition = 8;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 25;
    ultraGridColumn20.Header.VisiblePosition = 9;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 29;
    ultraGridColumn21.Header.VisiblePosition = 10;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 26;
    ultraGridColumn22.Header.VisiblePosition = 11;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 26;
    ultraGridColumn23.Header.VisiblePosition = 12;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 23;
    ultraGridColumn24.Header.VisiblePosition = 13;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 33;
    ultraGridColumn25.Header.VisiblePosition = 14;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 60;
    ultraGridColumn26.Header.VisiblePosition = 15;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 57;
    ultraGridColumn27.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 47;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Quoting Office";
    ultraGridColumn28.Header.VisiblePosition = 17;
    ultraGridColumn28.Width = 214;
    ultraGridColumn29.Header.VisiblePosition = 18;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 101;
    ultraGridBand3.Columns.AddRange(new object[19]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance26.BackColor = Color.LightSteelBlue;
    appearance26.FontData.SizeInPoints = 10f;
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance28.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance30.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    appearance31.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance32.BackColor = Color.Transparent;
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance32;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.UltraGrid1).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGrid1).Location = new Point(4, 8);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(509, 168);
    ((Control) this.UltraGrid1).TabIndex = 37;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.dvQuotingOffice.Table = (DataTable) this.ds.tblClientOffices;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(518, 637);
    this.Controls.Add((Control) this.ddQuotingOffice);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAdminAffidavitNumbers);
    this.Text = "Affidavit Number Administration";
    ((ISupportInitialize) this.udStart).EndInit();
    ((ISupportInitialize) this.udEnd).EndInit();
    ((ISupportInitialize) this.txtPrefix).EndInit();
    ((ISupportInitialize) this.txtCustomSuffix).EndInit();
    ((ISupportInitialize) this.chkDash).EndInit();
    ((ISupportInitialize) this.chkResetNumbering).EndInit();
    ((ISupportInitialize) this.udMinDigits).EndInit();
    ((ISupportInitialize) this.dtRenumberDate).EndInit();
    ((ISupportInitialize) this.chkTaxExempt).EndInit();
    ((ISupportInitialize) this.chkExportable).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.chkSwapSuffixAndAffNum).EndInit();
    ((ISupportInitialize) this.cboQuotingOffice).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.chkBound).EndInit();
    ((ISupportInitialize) this.chkRequiredForBinding).EndInit();
    this.panelAutomationTypes.ResumeLayout(false);
    ((ISupportInitialize) this.RequiredFieldValidator1).EndInit();
    ((ISupportInitialize) this.RequiredFieldValidator2).EndInit();
    ((ISupportInitialize) this.RequiredFieldValidator3).EndInit();
    ((ISupportInitialize) this.ddQuotingOffice).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.dvQuotingOffice.EndInit();
    this.ResumeLayout(false);
  }

  private bool IsValid
  {
    get
    {
      this.err.SetError((Control) this.rbTwoDigit, string.Empty);
      this.err.SetError((Control) this.udStart, string.Empty);
      this.err.SetError((Control) this.cboQuotingOffice, string.Empty);
      this.err.SetError((Control) this.txtCustomSuffix, string.Empty);
      bool flag = ((ValidatorBase) this.RequiredFieldValidator1).IsAllValidatorsValid;
      if (this.rbUseYearSuffix.Checked && !this.rbTwoDigit.Checked && !this.rbFourDigit.Checked)
      {
        this.err.SetError((Control) this.rbTwoDigit, "Please select either a two or four digit year.");
        flag = false;
      }
      else
        this.err.SetError((Control) this.rbTwoDigit, string.Empty);
      bool isValid;
      if (((UltraNumericEditor) this.udEnd).Value == DBNull.Value)
      {
        this.err.SetError((Control) this.udEnd, "Required field");
        isValid = false;
      }
      else
      {
        this.err.SetError((Control) this.udEnd, string.Empty);
        if (((UltraNumericEditor) this.udStart).Value == DBNull.Value)
        {
          this.err.SetError((Control) this.udStart, "Required field");
          isValid = false;
        }
        else
        {
          this.err.SetError((Control) this.udStart, string.Empty);
          if (((UltraNumericEditor) this.udMinDigits).Value == DBNull.Value)
          {
            this.err.SetError((Control) this.udMinDigits, "Required field");
            isValid = false;
          }
          else
          {
            this.err.SetError((Control) this.udMinDigits, string.Empty);
            if (((ValidatorBase) this.RequiredFieldValidator1).IsAllValidatorsValid)
            {
              if (Conversions.ToInteger(((UltraNumericEditor) this.udStart).Value) > Conversions.ToInteger(((UltraNumericEditor) this.udEnd).Value))
              {
                this.err.SetError((Control) this.udStart, "Starting value must be less than the ending value.");
                flag = false;
              }
              else
                this.err.SetError((Control) this.udStart, string.Empty);
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboQuotingOffice).Text, string.Empty, false) == 0)
            {
              this.err.SetError((Control) this.cboQuotingOffice, "Required field");
              flag = false;
            }
            else
            {
              this.err.SetError((Control) this.cboQuotingOffice, string.Empty);
              if (this._clickingNew)
              {
                if (this.ds.tblAdminAffidavitNumbers.Select($"StateID= '{this._stateID}' AND QuotingOfficeGUID = '{((Guid) ((UltraCombo) this.cboQuotingOffice).Value).ToString()}'").Length > 0)
                {
                  this.err.SetError((Control) this.cboQuotingOffice, "Value already exists");
                  flag = false;
                }
              }
            }
            isValid = flag;
          }
        }
      }
      return isValid;
    }
  }

  public frmAdminAffidavitNumbers(string stateID)
  {
    this.Load += new EventHandler(this.frmAdminAffidavitNumbers_Load);
    this._quotingOfficeGuid = Guid.Empty;
    this.InitializeComponent();
    this._stateID = stateID;
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
  }

  private void frmAdminAffidavitNumbers_Load(object sender, EventArgs e)
  {
    this.ShowSample();
    this.HookupHandlers(this.Controls);
    this.GetData();
    this.EnableDisableItems();
    ((Control) this.MgaGroupBox1).Enabled = false;
    this.dbSave.UIState = this.ds.tblAdminAffidavitNumbers.Rows.Count <= 0 ? (UIState) 0 : (UIState) 1;
    this._formLoading = true;
  }

  private void rbManual_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
      {
        if (control.Tag == null)
          control.Enabled = this.rbAutomated.Checked;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void GetData()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblClientOffices"
    }, CommandType.Text, "SELECT OfficeGUID, Location, Address1, City, State FROM tblClientOffices (NOLOCK) ORDER BY Location");
    this.da.SelectCommand.Parameters["@StateID"].Value = (object) this._stateID;
    DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.tblAdminAffidavitNumbers);
  }

  private void HookupHandlers(Control.ControlCollection ctlCol)
  {
    try
    {
      foreach (Control control in ctlCol)
      {
        MGATextBox mgaTextBox = control as MGATextBox;
        if (control.HasChildren)
          this.HookupHandlers(control.Controls);
        else if (mgaTextBox != null)
        {
          ((Control) mgaTextBox).TextChanged += new EventHandler(this.ValuesChanged);
        }
        else
        {
          switch (control)
          {
            case RadioButton radioButton:
              radioButton.CheckedChanged += new EventHandler(this.ValuesChanged);
              continue;
            case MGACheckBox mgaCheckBox:
              ((UltraToggleEditorBase) mgaCheckBox).CheckedChanged += new EventHandler(this.ValuesChanged);
              continue;
            case MGADateTimePicker mgaDateTimePicker:
              ((UltraDateTimeEditor) mgaDateTimePicker).ValueChanged += new EventHandler(this.ValuesChanged);
              continue;
            case MGANumericEditor mgaNumericEditor:
              ((UltraNumericEditorBase) mgaNumericEditor).ValueChanged += new EventHandler(this.ValuesChanged);
              continue;
            default:
              continue;
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void EnableDisableItems()
  {
    ((Control) this.txtCustomSuffix).Enabled = this.rbCustomSuffix.Checked && this.rbAutomated.Checked;
    this.rbTwoDigit.Visible = this.rbUseYearSuffix.Checked && this.rbAutomated.Checked;
    this.rbFourDigit.Visible = this.rbUseYearSuffix.Checked && this.rbAutomated.Checked;
    ((Control) this.dtRenumberDate).Enabled = ((UltraToggleEditorBase) this.chkResetNumbering).Checked && this.rbAutomated.Checked;
  }

  private void ValuesChanged(object sender, EventArgs e)
  {
    this.EnableDisableItems();
    this.ShowSample();
  }

  private void ShowSample()
  {
    Numbering.AffidavitYearSuffixType suffixType;
    if (this.rbCustomSuffix.Checked)
      suffixType = Numbering.AffidavitYearSuffixType.CustomSuffix;
    else if (this.rbTwoDigit.Checked)
      suffixType = Numbering.AffidavitYearSuffixType.TwoDigitYear;
    else if (this.rbFourDigit.Checked)
      suffixType = Numbering.AffidavitYearSuffixType.FourDigitYear;
    if (((UltraWinEditorMaskedControlBase) this.udStart).Text.Length == 0 || ((UltraNumericEditor) this.udStart).Value == DBNull.Value)
    {
      this.err.SetError((Control) this.udStart, "Start cannot be blank.");
    }
    else
    {
      this.err.SetError((Control) this.udStart, string.Empty);
      if (((UltraWinEditorMaskedControlBase) this.udMinDigits).Text.Length == 0 || ((UltraNumericEditor) this.udMinDigits).Value == DBNull.Value)
      {
        this.err.SetError((Control) this.udMinDigits, "Minimum Digits cannot be blank");
      }
      else
      {
        this.err.SetError((Control) this.udMinDigits, string.Empty);
        ((ControlBase) this.lblSample).Text = Numbering.CreateAffidavitNumber(Conversions.ToInteger(((UltraNumericEditor) this.udStart).Value), Conversions.ToInteger(((UltraNumericEditor) this.udMinDigits).Value), ((TextEditorControlBase) this.txtPrefix).Text, suffixType, ((TextEditorControlBase) this.txtCustomSuffix).Text, ((UltraToggleEditorBase) this.chkDash).Checked, DateAndTime.Now.Year, ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).Checked);
      }
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.EnableDisableItems();

  private void PlaceFormValuesIntoDatarow(
    dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow dr)
  {
    dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow affidavitNumbersRow = dr;
    affidavitNumbersRow.StartNum = Conversions.ToInteger(((UltraNumericEditor) this.udStart).Value);
    affidavitNumbersRow.EndNum = Conversions.ToInteger(((UltraNumericEditor) this.udEnd).Value);
    affidavitNumbersRow.MinDigits = Conversions.ToInteger(((UltraNumericEditor) this.udMinDigits).Value);
    affidavitNumbersRow.ManualEntry = this.rbManual.Checked;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPrefix).Text, string.Empty, false) != 0)
      affidavitNumbersRow.Prefix = ((TextEditorControlBase) this.txtPrefix).Text;
    else
      affidavitNumbersRow.SetPrefixNull();
    if (this.rbCustomSuffix.Checked)
    {
      affidavitNumbersRow.CustomSuffix = ((TextEditorControlBase) this.txtCustomSuffix).Text;
      affidavitNumbersRow.SetTwoDigitYearNull();
      affidavitNumbersRow.SetFourDigitYearNull();
    }
    else
    {
      affidavitNumbersRow.SetCustomSuffixNull();
      if (this.rbTwoDigit.Checked)
      {
        affidavitNumbersRow.SetFourDigitYearNull();
        affidavitNumbersRow.TwoDigitYear = true;
      }
      else
      {
        affidavitNumbersRow.SetTwoDigitYearNull();
        affidavitNumbersRow.FourDigitYear = true;
      }
      affidavitNumbersRow.BasedOn = !this.rbEffective.Checked ? "B" : "E";
    }
    affidavitNumbersRow.ResetEachYear = ((UltraToggleEditorBase) this.chkResetNumbering).Checked;
    if (((UltraDateTimeEditor) this.dtRenumberDate).Value != null)
      affidavitNumbersRow.ResetOn = ((UltraDateTimeEditor) this.dtRenumberDate).DateTime;
    else
      affidavitNumbersRow.SetResetOnNull();
    affidavitNumbersRow.Exportable = ((UltraToggleEditorBase) this.chkExportable).Checked;
    affidavitNumbersRow.ShareNos = ((UltraToggleEditorBase) this.chkBound).Checked;
    affidavitNumbersRow.TaxExempt = ((UltraToggleEditorBase) this.chkTaxExempt).Checked;
    affidavitNumbersRow.StateID = this._stateID;
    affidavitNumbersRow.SwapSuffixAndAffNum = ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).Checked;
    affidavitNumbersRow.SeparateSuffixWithDash = ((UltraToggleEditorBase) this.chkDash).Checked;
    affidavitNumbersRow.QuotingOfficeGUID = (Guid) ((UltraCombo) this.cboQuotingOffice).Value;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblAdminAffidavitNumbers.RejectChanges();
    this._clickingNew = false;
    this.UltraGrid1_AfterRowActivate((object) null, (EventArgs) null);
    ((Control) this.MgaGroupBox1).Enabled = false;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.UltraGrid1).ActiveRow == null || MessageBox.Show("Do you wish to continue with the deletion of the current record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this._quotingOfficeGuid = (Guid) ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["QuotingOfficeGuid"].Value;
    this.ds.tblAdminAffidavitNumbers.RemovetblAdminAffidavitNumbersRow((dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.ds.tblAdminAffidavitNumbers.Select($"QuotingOfficeGuid= '{this._quotingOfficeGuid.ToString()}'")[0]);
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblAdminAffidavitNumbers WHERE (StateID = @stateID) AND (QuotingOfficeGUID = @qGuid)", new object[4]
      {
        (object) "@StateID",
        (object) this._stateID,
        (object) "@qGuid",
        (object) this._quotingOfficeGuid
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    ((UltraControlBase) this.UltraGrid1).Update();
    if (((UltraGridBase) this.UltraGrid1).Rows.Count <= 0)
      return;
    ((UltraGridBase) this.UltraGrid1).ActiveRow = ((UltraGridBase) this.UltraGrid1).Rows[0];
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this._clickingNew = false;
    ((Control) this.MgaGroupBox1).Enabled = true;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    ((UltraNumericEditor) this.udStart).Value = (object) 0;
    ((UltraNumericEditor) this.udEnd).Value = (object) 0;
    ((UltraNumericEditor) this.udMinDigits).Value = (object) 1;
    this.rbManual.Checked = false;
    ((TextEditorControlBase) this.txtCustomSuffix).Text = string.Empty;
    this.rbCustomSuffix.Checked = false;
    this.rbFourDigit.Checked = false;
    this.rbBilling.Checked = false;
    ((UltraDateTimeEditor) this.dtRenumberDate).Value = (object) DateAndTime.Now;
    ((UltraToggleEditorBase) this.chkExportable).Checked = false;
    ((UltraToggleEditorBase) this.chkBound).Checked = false;
    ((UltraToggleEditorBase) this.chkTaxExempt).Checked = false;
    ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).Checked = false;
    ((TextEditorControlBase) this.txtPrefix).Text = string.Empty;
    ((UltraCombo) this.cboQuotingOffice).Value = (object) null;
    this._clickingNew = true;
    ((Control) this.MgaGroupBox1).Enabled = true;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValid)
    {
      e.Cancel = true;
    }
    else
    {
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow dr = !this._clickingNew ? (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.ds.tblAdminAffidavitNumbers.Select($"QuotingOfficeGuid= '{this._quotingOfficeGuid.ToString()}'")[0] : this.ds.tblAdminAffidavitNumbers.NewtblAdminAffidavitNumbersRow();
      this.PlaceFormValuesIntoDatarow(dr);
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        this.UpdateAffidavitNumbers(this._clickingNew, dr);
      }
      finally
      {
        this._clickingNew = false;
        ((Control) this.MgaGroupBox1).Enabled = false;
        this.Cursor = MgaCursors.Default;
      }
      this.ds.tblAdminAffidavitNumbers.Clear();
      this.da.SelectCommand.Parameters["@StateID"].Value = (object) this._stateID;
      DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.tblAdminAffidavitNumbers);
      ((UltraControlBase) this.UltraGrid1).Update();
      ((UltraGridBase) this.UltraGrid1).Rows.Refresh((RefreshRow) 2);
      ((UltraGridBase) this.UltraGrid1).ActiveRow = ((UltraGridBase) this.UltraGrid1).Rows[((UltraGridBase) this.UltraGrid1).Rows.Count - 1];
    }
  }

  private void dbSave_UIStateChanged1(object sender, EventArgs e)
  {
    if (!this._formLoading)
      return;
    if (this.ds.tblAdminAffidavitNumbers.Rows.Count > 0 && this.dbSave.UIState != 2)
      this.dbSave.UIState = (UIState) 1;
    else if (this.dbSave.UIState != 2)
      this.dbSave.UIState = (UIState) 0;
    this._formLoading = false;
  }

  private void UpdateAffidavitNumbers(
    bool newRecord,
    dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow dr)
  {
    string str = string.Empty;
    string FalsePart1 = string.Empty;
    bool Expression1 = false;
    DateTime FalsePart2 = DateTime.MinValue;
    bool FalsePart3 = false;
    bool FalsePart4 = false;
    bool Expression2 = dr.IsFourDigitYearNull();
    bool Expression3 = dr.IsTwoDigitYearNull();
    if (!dr.IsPrefixNull())
      str = dr.Prefix;
    if (!dr.IsCustomSuffixNull())
      FalsePart1 = dr.CustomSuffix;
    if (!dr.IsTwoDigitYearNull())
      FalsePart3 = dr.TwoDigitYear;
    if (!Expression2)
      FalsePart4 = dr.FourDigitYear;
    if (dr.IsResetOnNull())
      Expression1 = true;
    else
      FalsePart2 = dr.ResetOn;
    dr.BasedOn = !this.rbBilling.Checked ? "E" : "B";
    DefaultDatabase.ExecuteNonQuery("dbo.spUpdateAdminAffidavitNumbers", new object[40]
    {
      (object) "@Updating",
      (object) !newRecord,
      (object) "@StateID",
      (object) dr.StateID,
      (object) "@StartNum",
      (object) dr.StartNum,
      (object) "@EndNum",
      (object) dr.EndNum,
      (object) "@MinDigits",
      (object) dr.MinDigits,
      (object) "@Prefix",
      Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, string.Empty, false) == 0, (object) null, (object) str),
      (object) "@SeparateSuffixWithDash",
      (object) dr.SeparateSuffixWithDash,
      (object) "@CustomSuffix",
      Interaction.IIf(!this.rbCustomSuffix.Checked, (object) null, (object) FalsePart1),
      (object) "@TwoDigitYear",
      Interaction.IIf(Expression3, (object) null, (object) FalsePart3),
      (object) "@FourDigitYear",
      Interaction.IIf(Expression2, (object) null, (object) FalsePart4),
      (object) "@BasedOn",
      (object) dr.BasedOn,
      (object) "@ResetEachYear",
      (object) dr.ResetEachYear,
      (object) "@ManualEntry",
      (object) dr.ManualEntry,
      (object) "@RequiredForBinding",
      (object) dr.RequiredForBinding,
      (object) "@Exportable",
      (object) dr.Exportable,
      (object) "@TaxExempt",
      (object) dr.TaxExempt,
      (object) "@ShareNos",
      (object) dr.ShareNos,
      (object) "@SwapSuffixAndAffNum",
      (object) dr.SwapSuffixAndAffNum,
      (object) "@QuotingOfficeGUID",
      (object) dr.QuotingOfficeGUID,
      (object) "@ResetOn",
      Interaction.IIf(Expression1, (object) null, (object) FalsePart2)
    });
  }

  private void UltraGrid1_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.UltraGrid1).ActiveRow != null)
    {
      this._quotingOfficeGuid = (Guid) ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["QuotingOfficeGuid"].Value;
      this._stateID = (string) ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["StateID"].Value;
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow affidavitNumbersRow = (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.ds.tblAdminAffidavitNumbers.Select($"QuotingOfficeGuid= '{this._quotingOfficeGuid.ToString()}' AND StateID = '{this._stateID}'")[0];
      ((UltraNumericEditor) this.udStart).Value = (object) affidavitNumbersRow.StartNum;
      ((UltraNumericEditor) this.udEnd).Value = (object) affidavitNumbersRow.EndNum;
      ((UltraNumericEditor) this.udMinDigits).Value = (object) affidavitNumbersRow.MinDigits;
      this.rbManual.Checked = affidavitNumbersRow.ManualEntry;
      if (!affidavitNumbersRow.IsPrefixNull())
        ((TextEditorControlBase) this.txtPrefix).Text = affidavitNumbersRow.Prefix;
      else
        ((TextEditorControlBase) this.txtPrefix).Text = string.Empty;
      if (!affidavitNumbersRow.IsCustomSuffixNull())
      {
        this.rbCustomSuffix.Checked = true;
        this.rbUseYearSuffix.Checked = false;
        ((TextEditorControlBase) this.txtCustomSuffix).Text = affidavitNumbersRow.CustomSuffix;
      }
      else
      {
        ((TextEditorControlBase) this.txtCustomSuffix).Text = string.Empty;
        this.rbCustomSuffix.Checked = false;
        this.rbUseYearSuffix.Checked = true;
        if (!affidavitNumbersRow.IsTwoDigitYearNull())
          this.rbTwoDigit.Checked = affidavitNumbersRow.TwoDigitYear;
        if (!affidavitNumbersRow.IsFourDigitYearNull())
          this.rbFourDigit.Checked = affidavitNumbersRow.FourDigitYear;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(affidavitNumbersRow.BasedOn, "E", false) == 0)
        this.rbEffective.Checked = true;
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(affidavitNumbersRow.BasedOn, "B", false) == 0)
        this.rbBilling.Checked = true;
      if (!affidavitNumbersRow.IsResetOnNull())
        ((UltraDateTimeEditor) this.dtRenumberDate).Value = (object) affidavitNumbersRow.ResetOn;
      if (!affidavitNumbersRow.IsExportableNull())
        ((UltraToggleEditorBase) this.chkExportable).Checked = affidavitNumbersRow.Exportable;
      else
        ((UltraToggleEditorBase) this.chkExportable).Checked = false;
      ((UltraToggleEditorBase) this.chkSwapSuffixAndAffNum).Checked = affidavitNumbersRow.SwapSuffixAndAffNum;
      if (!affidavitNumbersRow.IsShareNosNull())
        ((UltraToggleEditorBase) this.chkBound).Checked = affidavitNumbersRow.ShareNos;
      else
        ((UltraToggleEditorBase) this.chkBound).Checked = false;
      if (!affidavitNumbersRow.IsTaxExemptNull())
        ((UltraToggleEditorBase) this.chkTaxExempt).Checked = affidavitNumbersRow.TaxExempt;
      else
        ((UltraToggleEditorBase) this.chkTaxExempt).Checked = false;
      ((UltraToggleEditorBase) this.chkDash).Checked = affidavitNumbersRow.SeparateSuffixWithDash;
      ((UltraToggleEditorBase) this.chkResetNumbering).Checked = affidavitNumbersRow.ResetEachYear;
      ((UltraCombo) this.cboQuotingOffice).Value = (object) affidavitNumbersRow.QuotingOfficeGUID;
    }
    else
      this._quotingOfficeGuid = Guid.Empty;
  }

  private void chkResetNumbering_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkResetNumbering).Checked)
      return;
    ((UltraDateTimeEditor) this.dtRenumberDate).Value = (object) null;
  }
}
