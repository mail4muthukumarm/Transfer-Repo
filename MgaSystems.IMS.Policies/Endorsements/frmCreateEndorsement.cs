// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Endorsements.frmCreateEndorsement
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Common.NativeWindowMethods.SafeAPICalls;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Endorsements;

[SecureResource("{301545A8-B433-4bb6-8CF6-F51C72C2209B}", "Update ReInStatement Endorsement EFfective Date", "Allows the user to update the endorsement effective date on reinstatements.", "Policies")]
public class frmCreateEndorsement : Form
{
  private IContainer components;
  private Label Label1;
  private DbDataAdapter daReasons;
  private DbConnection cnDb;
  private dsCreateEndorsement ds;
  private ErrorProvider err;
  private DbCommand DbSelectCommand1;
  private Guid _quoteGuid;
  private bool _saved;
  private QuoteStatus _newQuoteStatus;
  private bool _isEdit;
  private DateTime _effectiveDate;
  private bool _creatingAudit;
  private bool _creatingInstallmentEndorsement;
  internal const string CanUpdateReInstatementEndorseEffDate = "{301545A8-B433-4bb6-8CF6-F51C72C2209B}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("endInfo")]
  protected virtual EndorsementInfo endInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboEndorsementReasons")]
  protected virtual MGASimpleComboBox cboEndorsementReasons { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  protected virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCreateEndorsement));
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.endInfo = new EndorsementInfo();
    this.cboEndorsementReasons = new MGASimpleComboBox();
    this.ds = new dsCreateEndorsement();
    this.Label1 = new Label();
    this.daReasons = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.cnDb = DefaultDatabase.CreateDbConnection();
    this.err = new ErrorProvider(this.components);
    this.MgaGroupBox1 = new MGAGroupBox();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.cboEndorsementReasons).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(266, 175);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(315, 175);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 5;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.endInfo.BackColor = Color.FromArgb(239, 247, 253);
    this.endInfo.Comment = "";
    this.endInfo.CommentLabelText = "Comment:";
    this.endInfo.EffectiveDate = new DateTime(2019, 3, 7, 0, 0, 0, 0);
    this.endInfo.EndorsementCalcType = (EndorsementCalcTypes) 1;
    this.endInfo.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.endInfo.Location = new Point(14, 28);
    this.endInfo.Name = "endInfo";
    this.endInfo.Size = new Size(352, 112 /*0x70*/);
    this.endInfo.TabIndex = 6;
    ((UltraCombo) this.cboEndorsementReasons).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboEndorsementReasons).DataSource = (object) this.ds.lstQuoteStatusReasons;
    ((UltraDropDownBase) this.cboEndorsementReasons).DisplayMember = "Reason";
    ((UltraCombo) this.cboEndorsementReasons).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboEndorsementReasons).Location = new Point(147, 140);
    this.cboEndorsementReasons.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboEndorsementReasons).Name = "cboEndorsementReasons";
    ((Control) this.cboEndorsementReasons).Size = new Size(206, 21);
    ((Control) this.cboEndorsementReasons).TabIndex = 7;
    ((UltraControlBase) this.cboEndorsementReasons).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEndorsementReasons).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboEndorsementReasons).ValueMember = "ID";
    this.ds.DataSetName = "dsCreateEndorsement";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.FromArgb(239, 247, 253);
    this.Label1.Location = new Point(28, 142);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(113, 13);
    this.Label1.TabIndex = 8;
    this.Label1.Text = "Endorsement Reason:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.daReasons.SelectCommand = this.DbSelectCommand1;
    this.daReasons.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstQuoteStatusReasons", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Reason", "Reason")
      })
    });
    this.DbSelectCommand1.CommandText = "SELECT ID, Reason FROM lstQuoteStatusReasons WHERE (LineGuid = @LineGuid OR LineGuid IS NULL) AND (QuoteStatusID = @NewQuoteStatusID) ORDER BY Reason";
    this.DbSelectCommand1.Connection = this.cnDb;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      DefaultDatabase.CreateParameter("@NewQuoteStatusID", SqlDbType.TinyInt, 1, "QuoteStatusID")
    });
    this.cnDb = DefaultDatabase.CreateDbConnection();
    this.err.ContainerControl = (ContainerControl) this;
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.endInfo);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboEndorsementReasons);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnCancel);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnSave);
    appearance4.AlphaLevel = (short) 230;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.White;
    appearance4.ForegroundAlpha = (Alpha) 2;
    appearance4.ImageAlpha = (Alpha) 2;
    appearance4.ImageBackground = (Image) componentResourceManager.GetObject("Appearance4.ImageBackground");
    appearance4.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    ((UltraGroupBox) this.MgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaGroupBox1).Location = new Point(7, 9);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(378, 231);
    ((Control) this.MgaGroupBox1).TabIndex = 9;
    ((UltraGroupBox) this.MgaGroupBox1).Text = "Endorsement Information";
    ((UltraGroupBox) this.MgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(393, 248);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCreateEndorsement);
    this.Text = "Create / Edit Endorsement";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.cboEndorsementReasons).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    this.ResumeLayout(false);
  }

  public bool IsEdit
  {
    get => this._isEdit;
    set => this._isEdit = value;
  }

  public EndorsementCalcTypes EndorsementCalcType => this.endInfo.EndorsementCalcType;

  public bool ReasonSelected
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboEndorsementReasons).Text, string.Empty, false) != 0;
    }
  }

  public bool Saved => this._saved;

  public DateTime EndorsementEffective
  {
    get => this.endInfo.EffectiveDate;
    set => this.endInfo.EffectiveDate = value;
  }

  public string EndorsementComment => this.endInfo.Comment;

  public bool HasReason => ((Control) this.cboEndorsementReasons).Enabled;

  public int EndorsementReasonID => (int) ((UltraCombo) this.cboEndorsementReasons).Value;

  public bool CreatingAudit
  {
    get => this._creatingAudit;
    set => this._creatingAudit = value;
  }

  public bool CreatingInstallmentEndorsement
  {
    get => this._creatingInstallmentEndorsement;
    set => this._creatingInstallmentEndorsement = value;
  }

  public frmCreateEndorsement()
  {
    this.Load += new EventHandler(this.frmCreateEndorsement_Load);
    this.InitializeComponent();
  }

  public frmCreateEndorsement(Guid quoteGuid, QuoteStatus newQuoteStatus)
  {
    this.Load += new EventHandler(this.frmCreateEndorsement_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._newQuoteStatus = newQuoteStatus;
    this.endInfo.CalculationTypeVisibility(quoteGuid);
  }

  private void frmCreateEndorsement_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this.cnDb = DefaultDatabase.CreateDbConnection();
    Quote q = new Quote(this._quoteGuid);
    bool flag = SystemSettings.KeyExists("NullEndorsementEffectiveDate") && SystemSettings.GetBoolSetting("NullEndorsementEffectiveDate");
    this.ds.lstQuoteStatusReasons.AddlstQuoteStatusReasonsRow(string.Empty);
    DbDataAdapter daReasons = this.daReasons;
    daReasons.SelectCommand.Parameters["@LineGuid"].Value = (object) q.LineGuid;
    daReasons.SelectCommand.Parameters["@NewQuoteStatusID"].Value = (object) (int) this._newQuoteStatus;
    DefaultDatabase.DataAdapterFill(this.daReasons, (DataTable) this.ds.lstQuoteStatusReasons);
    if (this.CreatingAudit && (!SystemSettings.KeyExists("OpenEndorsementAuditReasons") || !SystemSettings.GetBoolSetting("OpenEndorsementAuditReasons")))
    {
      ((UltraCombo) this.cboEndorsementReasons).SelectedText = "Audits";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboEndorsementReasons).Text, "Audits", false) == 0)
        ((Control) this.cboEndorsementReasons).Enabled = false;
    }
    if (this.IsEdit)
    {
      EndorsementInfo endInfo = this.endInfo;
      endInfo.EffectiveDate = this.GetEndorsementEffectiveDate(q);
      endInfo.Comment = q.EndorsementComment;
      endInfo.EndorsementCalcType = q.EndorsementCalculationType;
      if (q.HasQuoteStatusReason)
        ((UltraCombo) this.cboEndorsementReasons).Value = (object) q.QuoteStatusReasonID;
    }
    else
    {
      if (this._newQuoteStatus == 8)
        this.endInfo.EffectiveDate = this.GetEndorsementEffectiveDate(q);
      else if (flag)
        this.endInfo.ClearEffectiveDate();
      else
        this.endInfo.EffectiveDate = q.EffectiveDate;
      this.endInfo.EndorsementCalcType = (EndorsementCalcTypes) 3;
      if (this.ReasonRequired() && this.ds.lstQuoteStatusReasons.Rows.Count == 2)
        ((UltraCombo) this.cboEndorsementReasons).Value = (object) this.ds.lstQuoteStatusReasons[1].ID;
    }
    if (this._newQuoteStatus == 8)
    {
      ((UltraCombo) this.cboEndorsementReasons).Value = (object) 31 /*0x1F*/;
      ((Control) this.cboEndorsementReasons).Enabled = false;
    }
    this._effectiveDate = this.endInfo.EffectiveDate;
    this.SetupCreatingAudit();
    this.OnFormLoad();
  }

  protected virtual DateTime GetEndorsementEffectiveDate(Quote q) => q.EndorsementEffective;

  protected virtual void OnFormLoad()
  {
  }

  [Obsolete("Use System.Data.Common arguments instead of System.Data.SqlClient arguments", false)]
  protected virtual void ClientSave(SqlTransaction t)
  {
  }

  protected virtual void ClientSave(DbTransaction t)
  {
    if (!(t is SqlTransaction))
      return;
    this.ClientSave(t as SqlTransaction);
  }

  private bool ReasonRequired()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ReasonRequired FROM lstQuoteStatus WHERE QuoteStatusID=@QSID", new object[2]
    {
      (object) "@QSID",
      (object) (int) this._newQuoteStatus
    }));
    return objectValue != null && objectValue != DBNull.Value && Conversions.ToBoolean(objectValue);
  }

  private bool AreDatesEqual(DateTime date1, DateTime date2)
  {
    bool flag = true;
    if (date1.Year != date2.Year || date1.Month != date2.Month || date1.Day != date2.Day)
      flag = false;
    return flag;
  }

  protected virtual bool ValidateForm()
  {
    bool flag = true;
    Quote quote = new Quote(this._quoteGuid);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboEndorsementReasons).Text, string.Empty, false) == 0 && this.ReasonRequired())
    {
      this.err.SetError((Control) this.cboEndorsementReasons, "Please select a reason.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboEndorsementReasons, string.Empty);
    if (this._newQuoteStatus == 8 && !this.AreDatesEqual(this._effectiveDate, this.endInfo.EffectiveDate) && !SecurityManager.Instance.AssertPermission("{301545A8-B433-4bb6-8CF6-F51C72C2209B}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to change the Endorsement Effective date.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    if (flag && DateTime.Compare(this.endInfo.EffectiveDate, DateTime.MinValue) == 0)
    {
      int num = (int) MessageBox.Show("You must select a valid effective date.", "Missing Effective Date", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag = false;
    }
    if (flag && !quote.ValidEndorsementEffectiveDate(this.EndorsementEffective))
    {
      flag = false;
      DateTime effectiveDate;
      DateTime expirationDate;
      if (quote.IsOriginalQuoteRecord)
      {
        effectiveDate = quote.EffectiveDate;
        expirationDate = quote.ExpirationDate;
      }
      else
      {
        effectiveDate = quote.PreviousQuote.EffectiveDate;
        expirationDate = quote.PreviousQuote.ExpirationDate;
      }
      int num = (int) MessageBox.Show($"The effective date of the endorsement is invalid.\n\nThe endorsement must fall on or between {effectiveDate.ToShortDateString()} to {expirationDate.ToShortDateString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    if (flag)
    {
      ValidateEndorsementReason objectEx = (ValidateEndorsementReason) ObjectFactory.Instance.CreateObjectEX(typeof (ValidateEndorsementReason), new object[0]);
      int integer = Conversions.ToInteger(((UltraCombo) this.cboEndorsementReasons).Value);
      int controlNo = quote.ControlNo;
      int reasonID = integer;
      flag = objectEx.ValidateReason(controlNo, reasonID);
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    if (SystemSettings.GetSetting<bool>("NetRate.CheckIfOpenWhenEndorse", false))
    {
      Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
      System.Func<Form, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (frmCreateEndorsement._Closure\u0024__.\u0024I71\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = frmCreateEndorsement._Closure\u0024__.\u0024I71\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmCreateEndorsement._Closure\u0024__.\u0024I71\u002D0 = predicate = (System.Func<Form, bool>) ([SpecialName] (x) => x.Text.Equals("NetRate Rater"));
      }
      if (((IEnumerable<Form>) mdiChildren).Any<Form>(predicate) | !IntPtr.Zero.Equals(RuntimeHelpers.GetObjectValue(this.GetNetRateWindowHandle())))
      {
        int num = (int) MessageBox.Show($"Netrate is currently open. {Environment.NewLine}{Environment.NewLine} Close Netrate to create an endorsement.", "Data Modified", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    this._saved = true;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (executeTransactionSender, executeTransactionArgs) =>
    {
      DbTransaction transaction = executeTransactionArgs.Transaction;
      try
      {
        this.ClientSave(transaction);
        transaction.Commit();
      }
      catch (DBConcurrencyException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        transaction?.Rollback();
        this.cnDb.Close();
        int num = (int) MessageBox.Show("Another user has modified this quote while you were working with it.\n\nPlease re-open this form and make your edits again.", "Data Modified", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        transaction?.Rollback();
        this.Close();
        throw;
      }
      finally
      {
        this.cnDb.Close();
        transaction?.Dispose();
      }
    }));
    this.Close();
  }

  private object GetNetRateWindowHandle()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmCreateEndorsement._Closure\u0024__72\u002D0 closure720 = new frmCreateEndorsement._Closure\u0024__72\u002D0();
    int windowEx = SafeAPI.FindWindowEx(0, 0, "TfrmCLPackageUI", (string) null);
    // ISSUE: reference to a compiler-generated field
    closure720.\u0024VB\u0024Local_found = false;
    if (windowEx != 0)
    {
      // ISSUE: method pointer
      SafeAPI.EnumerateChildWindowsOfClass(new IntPtr(windowEx), "TPanel", new SafeAPI.EnumerateChildWindowsOfClassHandler((object) closure720, __methodptr(_Lambda\u0024__R1)));
    }
    // ISSUE: reference to a compiler-generated field
    return !closure720.\u0024VB\u0024Local_found ? (object) IntPtr.Zero : (object) new IntPtr(windowEx);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void SetupCreatingAudit()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ID FROM lstQuoteStatusReasons WITH (NOLOCK) WHERE AutomationID = @AID", new object[2]
    {
      (object) "@AID",
      (object) "AUDIT"
    }));
    int num = int.MinValue;
    if (objectValue != null && objectValue != DBNull.Value)
    {
      dsCreateEndorsement.lstQuoteStatusReasonsRow byId = this.ds.lstQuoteStatusReasons.FindByID(Conversions.ToInteger(objectValue));
      if (byId != null)
        num = byId.ID;
    }
    if (!this.IsEdit && this.CreatingAudit && num != int.MinValue)
    {
      ((UltraCombo) this.cboEndorsementReasons).Value = (object) num;
      ((Control) this.cboEndorsementReasons).Enabled = false;
    }
    else
    {
      if (!this.IsEdit || num == int.MinValue || Conversions.ToInteger(((UltraCombo) this.cboEndorsementReasons).Value) != num)
        return;
      ((Control) this.cboEndorsementReasons).Enabled = false;
    }
  }
}
