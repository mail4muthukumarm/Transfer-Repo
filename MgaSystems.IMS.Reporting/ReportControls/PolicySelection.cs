// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.PolicySelection
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class PolicySelection : BaseReportControl
{
  private IContainer components;
  private PolicySelection.PolicyTypes _PolicyType;
  private DataTable _dtPolicies;
  private PolicySelection.EntityTypes _EntityType;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual MGASimpleComboBox cmbEntity
  {
    get => this._cmbEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbEntity_ValueChanged);
      MGASimpleComboBox cmbEntity1 = this._cmbEntity;
      if (cmbEntity1 != null)
        cmbEntity1.ValueChanged -= eventHandler;
      this._cmbEntity = value;
      MGASimpleComboBox cmbEntity2 = this._cmbEntity;
      if (cmbEntity2 == null)
        return;
      cmbEntity2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cmbPolicies")]
  internal virtual MGAComboBox cmbPolicies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Band 0", -1);
    Appearance appearance2 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.cmbEntity = new MGASimpleComboBox();
    this.cmbPolicies = new MGAComboBox();
    ((ISupportInitialize) this.cmbEntity).BeginInit();
    ((ISupportInitialize) this.cmbPolicies).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, -1);
    this.lblDescription.Size = new Size(88, 57);
    ((Control) this.cmbEntity).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cmbEntity.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbEntity).Location = new Point(88, 6);
    ((Control) this.cmbEntity).Name = "cmbEntity";
    ((Control) this.cmbEntity).Size = new Size(300, 20);
    ((Control) this.cmbEntity).TabIndex = 1;
    ((UltraControlBase) this.cmbEntity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbEntity).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cmbPolicies).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.LightGray;
    this.cmbPolicies.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cmbPolicies.DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand.HeaderVisible = true;
    this.cmbPolicies.DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    this.cmbPolicies.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbPolicies.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cmbPolicies.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.ForeColor = Color.Black;
    this.cmbPolicies.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.WhiteSmoke;
    appearance3.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.WhiteSmoke;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance4;
    this.cmbPolicies.DisplayLayout.ScrollBarLook = scrollBarLook;
    this.cmbPolicies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbPolicies).Location = new Point(88, 30);
    ((Control) this.cmbPolicies).Name = "cmbPolicies";
    ((Control) this.cmbPolicies).Size = new Size(300, 20);
    ((Control) this.cmbPolicies).TabIndex = 2;
    ((UltraControlBase) this.cmbPolicies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbPolicies).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.cmbPolicies);
    this.Controls.Add((Control) this.cmbEntity);
    this.Name = nameof (PolicySelection);
    this.Size = new Size(392, 56);
    this.Controls.SetChildIndex((Control) this.cmbEntity, 0);
    this.Controls.SetChildIndex((Control) this.cmbPolicies, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.cmbEntity).EndInit();
    ((ISupportInitialize) this.cmbPolicies).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual void FillInsureds()
  {
    ((UltraDropDownBase) this.cmbEntity).DisplayMember = "Name";
    ((UltraDropDownBase) this.cmbEntity).ValueMember = "InsuredGUID";
    ((UltraGridBase) this.cmbEntity).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Name, InsuredGuid FROM tblInsureds ORDER BY Name");
  }

  protected virtual void FillBoundPolicies()
  {
    if (this._EntityType != PolicySelection.EntityTypes.Insured)
      return;
    this._dtPolicies = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Q.QuoteGuid, Q.PolicyNumber, dbo.GetEffectiveDate(Q.QuoteGUID) AS EffectiveDate, Q.ExpirationDate FROM tblSubmissionGroup SG INNER JOIN tblQuotes Q ON SG.SubmissionGroupGUID = Q.SubmissionGroupGuid INNER JOIN lstQuoteStatus QS ON Q.QuoteStatusID = QS.QuoteStatusID WHERE (SG.InsuredGuid = @InsuredGuid) AND (QS.Bound = 1) AND (dbo.IsEndorsement(Q.QuoteGuid) = 0) ORDER BY PolicyNumber", new object[2]
    {
      (object) "@InsuredGuid",
      this.cmbEntity.Value
    });
  }

  private void BindCombo()
  {
    ((UltraGridBase) this.cmbPolicies).DataSource = (object) this._dtPolicies;
    if (this._dtPolicies.Rows.Count > 0)
    {
      this.cmbPolicies.SelectedIndex = 0;
      ((Control) this.cmbPolicies).Enabled = true;
    }
    else
      ((Control) this.cmbPolicies).Enabled = false;
  }

  public PolicySelection()
  {
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  public PolicySelection(
    string LabelText,
    PolicySelection.EntityTypes EntityType,
    PolicySelection.PolicyTypes PolicyType)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._PolicyType = PolicyType;
    this._EntityType = EntityType;
    if (EntityType == PolicySelection.EntityTypes.Insured)
      this.FillInsureds();
    this.cmbEntity.SelectedIndex = 0;
    ((UltraDropDownBase) this.cmbPolicies).ValueMember = "QuoteGuid";
    ((UltraDropDownBase) this.cmbPolicies).DisplayMember = "PolicyNumber";
    ((UltraGridBase) this.cmbPolicies).DataSource = (object) this._dtPolicies;
    this.cmbPolicies.DisplayLayout.Bands[0].Columns["QuoteGuid"].Hidden = true;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => this.cmbPolicies.Value;
    set
    {
      Guid guid = (Guid) value;
      this.cmbEntity.Value = (object) DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1  tblSubmissionGroup.InsuredGuid FROM tblSubmissionGroup INNER JOIN tblQuotes ON tblSubmissionGroup.SubmissionGroupGUID = tblQuotes.SubmissionGroupGuid WHERE (tblQuotes.QuoteGUID = @QuoteGUID)", new object[2]
      {
        (object) "@QuoteGUID",
        (object) guid
      });
      this.cmbPolicies.Value = (object) guid;
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      return this.Value == null || this.Value.Equals((object) Guid.Empty) ? "Select a Policy" : string.Empty;
    }
  }

  public override void Compress()
  {
    ((Control) this.cmbEntity).Top = 0;
    ((Control) this.cmbPolicies).Top = ((Control) this.cmbEntity).Height;
    this.lblDescription.Height = ((Control) this.cmbPolicies).Height + ((Control) this.cmbEntity).Height;
    this.lblDescription.Top = 0;
    this.Height = this.lblDescription.Height;
  }

  private void cmbEntity_ValueChanged(object sender, EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (this._PolicyType == PolicySelection.PolicyTypes.Bound)
      this.FillBoundPolicies();
    this.BindCombo();
    Cursor.Current = Cursors.Default;
  }

  public enum PolicyTypes
  {
    Bound,
  }

  public enum EntityTypes
  {
    Insured,
  }
}
