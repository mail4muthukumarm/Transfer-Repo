// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormChangeUnderwriter
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
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
public class FormChangeUnderwriter : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private Quote _quote;
  private dsQuoteEdit _ds;
  private bool _underwriterChanged;
  private string _newQuoteUnderwriter;
  private Guid _oldSubmissionUnderwriterGuid;
  private string _currentUnderwriterName;
  private Guid _oldQuoteUnderwriterGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstSIC_Codes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SIC_Description");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SIC_Family_Description");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("lstSIC_CodestblQuotes");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstSIC_CodestblQuotes", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ControlGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UnderwriterUserGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("QuotingLocationGuid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("IssuingLocationGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ProducerContactGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("SubmissionGroupGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("TermsOfPayment");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("TACSRUserGuid");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EndorsementEffective");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("EndorsementComment");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("FinanceCompanyGuid");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Retailer");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("RetailerGuid");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("MinimumEarnedPercentage");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("CostCenterID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("InspectionCompanyID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("QuickQuote");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("PreviousPremium");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("TargetPremium");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ExpiringPolicyNumber");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("RiskDescription");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("UnderwritingAssistantGuid");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("SecProducerContactGuid");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("EarnedPremiumTypeID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Auditable");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("NAICSCode");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("tblQuotestblQuoteDetails");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuotestblQuoteDetails", 1);
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("CompanyContactGuid");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("IntermediaryContactGuid");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("CompanyCommission");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ProducerCommission");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Participation");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("TermsOfPayment");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("UsingAdditiveCommission");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("CompanyLine");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("ProgramID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance5 = new Appearance();
    this.cboUnderwriter = new MGAComboBox();
    this.Label1 = new Label();
    this.btnChange = new MGAButton();
    this.lblCurrentUnderwriter = new Label();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.btnChange).BeginInit();
    this.SuspendLayout();
    ((UltraCombo) this.cboUnderwriter).BorderStyle = (UIElementBorderStyle) 4;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboUnderwriter.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboUnderwriter.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 171;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 106;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 204;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 81;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn15.Header.VisiblePosition = 10;
    ultraGridColumn16.Header.VisiblePosition = 11;
    ultraGridColumn17.Header.VisiblePosition = 12;
    ultraGridColumn18.Header.VisiblePosition = 13;
    ultraGridColumn19.Header.VisiblePosition = 14;
    ultraGridColumn20.Header.VisiblePosition = 15;
    ultraGridColumn21.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn22.Header.VisiblePosition = 17;
    ultraGridColumn23.Header.VisiblePosition = 18;
    ultraGridColumn24.Header.VisiblePosition = 19;
    ultraGridColumn25.Header.VisiblePosition = 20;
    ultraGridColumn26.Header.VisiblePosition = 21;
    ultraGridColumn27.Header.VisiblePosition = 22;
    ultraGridColumn28.Header.VisiblePosition = 23;
    ultraGridColumn29.Header.VisiblePosition = 24;
    ultraGridColumn30.Header.VisiblePosition = 25;
    ultraGridColumn31.Header.VisiblePosition = 26;
    ultraGridColumn32.Header.VisiblePosition = 27;
    ultraGridColumn33.Header.VisiblePosition = 28;
    ultraGridColumn34.Header.VisiblePosition = 29;
    ultraGridColumn35.Header.VisiblePosition = 30;
    ultraGridColumn36.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn37.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn38.Header.VisiblePosition = 33;
    ultraGridColumn39.Header.VisiblePosition = 34;
    ultraGridColumn40.Header.VisiblePosition = 35;
    ultraGridColumn41.Header.VisiblePosition = 36;
    ultraGridColumn42.Header.VisiblePosition = 37;
    ultraGridColumn43.Header.VisiblePosition = 38;
    ultraGridColumn44.Header.VisiblePosition = 39;
    ultraGridBand2.Columns.AddRange(new object[40]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
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
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44
    });
    ultraGridColumn45.Header.VisiblePosition = 0;
    ultraGridColumn46.Header.VisiblePosition = 1;
    ultraGridColumn47.Header.VisiblePosition = 2;
    ultraGridColumn48.Header.VisiblePosition = 3;
    ultraGridColumn49.Header.VisiblePosition = 4;
    ultraGridColumn50.Header.VisiblePosition = 5;
    ultraGridColumn51.Header.VisiblePosition = 6;
    ultraGridColumn52.Header.VisiblePosition = 7;
    ultraGridColumn53.Header.VisiblePosition = 8;
    ultraGridColumn54.Header.VisiblePosition = 9;
    ultraGridColumn55.Header.VisiblePosition = 10;
    ultraGridBand3.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55
    });
    this.cboUnderwriter.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboUnderwriter.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboUnderwriter.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboUnderwriter.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboUnderwriter.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboUnderwriter.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance2.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboUnderwriter.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance2;
    appearance3.BorderColor = Color.White;
    this.cboUnderwriter.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance3;
    this.cboUnderwriter.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance4.ForeColor = Color.Black;
    this.cboUnderwriter.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance4;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboUnderwriter.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboUnderwriter).DisplayMember = "SIC_Description";
    ((UltraCombo) this.cboUnderwriter).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriter).DropDownWidth = 500;
    ((Control) this.cboUnderwriter).Location = new Point(138, 57);
    ((MGASimpleComboBox) this.cboUnderwriter).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(277, 20);
    ((Control) this.cboUnderwriter).TabIndex = 7;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriter).ValueMember = "SIC_Code";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(17, 61);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(115, 13);
    this.Label1.TabIndex = 8;
    this.Label1.Text = "Available Underwriters:";
    ((Control) this.btnChange).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnChange).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnChange).Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnChange).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnChange).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnChange).Location = new Point(138, 139);
    ((Control) this.btnChange).Name = "btnChange";
    ((ControlBase) this.btnChange).Padding = new Size(5, 0);
    ((Control) this.btnChange).Size = new Size(113, 36);
    ((Control) this.btnChange).TabIndex = 9;
    ((ControlBase) this.btnChange).Text = "Change";
    this.btnChange.UseOSThemes = (DefaultableBoolean) 2;
    this.lblCurrentUnderwriter.AutoSize = true;
    this.lblCurrentUnderwriter.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCurrentUnderwriter.Location = new Point(17, 19);
    this.lblCurrentUnderwriter.Name = "lblCurrentUnderwriter";
    this.lblCurrentUnderwriter.Size = new Size(123, 13);
    this.lblCurrentUnderwriter.TabIndex = 10;
    this.lblCurrentUnderwriter.Text = "Current Underwriters";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(427, 187);
    this.Controls.Add((Control) this.lblCurrentUnderwriter);
    this.Controls.Add((Control) this.btnChange);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboUnderwriter);
    this.Name = nameof (FormChangeUnderwriter);
    this.Text = "Change Underwriter";
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.btnChange).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("cboUnderwriter")]
  protected virtual MGAComboBox cboUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnChange
  {
    get => this._btnChange;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnChange_Click);
      MGAButton btnChange1 = this._btnChange;
      if (btnChange1 != null)
        ((Control) btnChange1).Click -= eventHandler;
      this._btnChange = value;
      MGAButton btnChange2 = this._btnChange;
      if (btnChange2 == null)
        return;
      ((Control) btnChange2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrentUnderwriter")]
  protected virtual Label lblCurrentUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public bool UnderwriterChanged => this._underwriterChanged;

  public string NewUnderwriter => this._newQuoteUnderwriter;

  public bool CanChangeSubmissionUnderwriter
  {
    get
    {
      bool submissionUnderwriter;
      if (this._oldSubmissionUnderwriterGuid.Equals(Guid.Empty))
        submissionUnderwriter = false;
      else if (((UltraCombo) this.cboUnderwriter).Value == null)
        submissionUnderwriter = false;
      else if (this._oldSubmissionUnderwriterGuid.Equals(new Guid(((UltraCombo) this.cboUnderwriter).Value.ToString())))
        submissionUnderwriter = false;
      else
        submissionUnderwriter = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT( DISTINCT Q.ControlNo) FROM dbo.tblQuotes Q  WITH (NOLOCK) INNER JOIN   dbo.tblSubmissionGroup S WITH (NOLOCK) ON Q.SubmissionGroupGuid = S.SubmissionGroupGUID WHERE  Q.QuoteGUID <> @QG AND S.SubmissionGroupGUID = @SG", new object[4]
        {
          (object) "@QG",
          (object) this._quoteGuid,
          (object) "@SG",
          (object) this._quote.SubmissionGroupGuid
        }) == 0;
      return submissionUnderwriter;
    }
  }

  public FormChangeUnderwriter(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormChangeUnderwriter_Load);
    this._ds = new dsQuoteEdit();
    this._underwriterChanged = false;
    this._newQuoteUnderwriter = string.Empty;
    this._oldSubmissionUnderwriterGuid = Guid.Empty;
    this._currentUnderwriterName = string.Empty;
    this._oldQuoteUnderwriterGuid = Guid.Empty;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._quote = new Quote(quoteGuid);
    ((UltraGridBase) this.cboUnderwriter).DataSource = (object) this._ds;
    ((UltraGridBase) this.cboUnderwriter).DataMember = "tblUsers";
    ((UltraDropDownBase) this.cboUnderwriter).DisplayMember = "FullName";
    ((UltraDropDownBase) this.cboUnderwriter).ValueMember = "UserGuid";
    this.cboUnderwriter.DisplayLayout.Bands[0].Columns["UserGuid"].Hidden = true;
  }

  private void FormChangeUnderwriter_Load(object sender, EventArgs e)
  {
    this._currentUnderwriterName = $"{this._quote.Underwriter.LastName}, {this._quote.Underwriter.FirstName}";
    this.lblCurrentUnderwriter.Text = $"Current Underwriter : [{this._currentUnderwriterName}]";
    ((ControlBase) this.btnChange).Appearance.Image = (object) ImageCache.Instance.NoteUser;
    this._oldQuoteUnderwriterGuid = this._quote.UnderwriterUserGuid.Value;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT UnderwriterUserGuid FROM dbo.tblSubmissionGroup WITH (NOLOCK) WHERE SubmissionGroupGUID = @SG", new object[2]
    {
      (object) "@SG",
      (object) this._quote.SubmissionGroupGuid
    }));
    if (objectValue != null && objectValue != DBNull.Value)
      this._oldSubmissionUnderwriterGuid = new Guid(objectValue.ToString());
    bool flag = SecurityManager.Instance.AssertPermission("{0FA0118C-D65D-49da-8330-220B26A5B652}");
    Guid issuingLocationGuid = this._quote.IssuingLocationGuid;
    Guid lineGuid = this._quote.LineGuid;
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this._ds, new string[1]
      {
        this._ds.tblUsers.TableName
      }, "dbo.QuoteEditData_GetUnderwriters", new object[8]
      {
        (object) "@lineGuid",
        (object) lineGuid,
        (object) "@quoteGuid",
        (object) this._quoteGuid,
        (object) "@selectAllOffices",
        (object) flag,
        (object) "@issuingOffice",
        (object) issuingLocationGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("Catch Error.\n" + ex.Message, "Invalid - Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      throw;
    }
    this.AfterFormControlsLoaded();
  }

  protected virtual void AfterFormControlsLoaded()
  {
  }

  protected virtual bool ValidateUnderwriter()
  {
    bool flag;
    if (string.IsNullOrEmpty(((UltraCombo) this.cboUnderwriter).Text))
    {
      int num = (int) MessageBox.Show("Please select a valid underwriter to continue.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this._quote.UnderwriterUserGuid.Equals((object) new Guid(((UltraCombo) this.cboUnderwriter).Value.ToString())))
    {
      int num = (int) MessageBox.Show("An attempt is made to copy the current underwriter onto itself.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this._quote.IsBound)
    {
      int num = (int) MessageBox.Show("Cannot change underwriter on a bound policy.", "Invalid - Bound Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnChange_Click(object sender, EventArgs e)
  {
    if (!this.ValidateUnderwriter())
      return;
    if (6 != (int) MessageBox.Show($"You are about to change the underwriter.\n\nFrom: {this._currentUnderwriterName}\nTo: {((UltraCombo) this.cboUnderwriter).Text}\n\nContinue?", "Change Underwriter?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    this._underwriterChanged = false;
    this._newQuoteUnderwriter = string.Empty;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("spChangeQuoteUnderwriter", new object[4]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid,
        (object) "@NewUnderwriterGuid",
        ((UltraCombo) this.cboUnderwriter).Value
      });
      CurrentUser.Instance.LogAction($"Modify Quote: Changed Underwriter from {this._currentUnderwriterName} to {((UltraCombo) this.cboUnderwriter).Text}", this._quoteGuid);
      this.SaveOnClient(this._oldQuoteUnderwriterGuid, (Guid) ((UltraCombo) this.cboUnderwriter).Value, this._oldSubmissionUnderwriterGuid);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this._underwriterChanged = false;
      this._newQuoteUnderwriter = string.Empty;
      throw;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this._underwriterChanged = true;
    this._newQuoteUnderwriter = ((UltraCombo) this.cboUnderwriter).Text;
    this.Close();
  }

  protected virtual void SaveOnClient(
    Guid oldUnderwriterGuid,
    Guid newUnderwriterGuid,
    Guid oldSubmissionUnderwriterGuid)
  {
  }
}
