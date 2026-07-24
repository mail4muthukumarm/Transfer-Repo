// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.LocationSettingsView
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.NoteDocuments;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

[Override(typeof (ILocationSettingsView))]
public class LocationSettingsView : 
  MvcViewBase<ILocationSettingsModel, ILocationSettingsController>,
  ILocationSettingsView,
  IMvcView,
  IModelObserver
{
  private const string VIEWINGRIGHTS_SETTING = "CLAIMS_ENFORCEVIEWING_RIGHTS";
  private IContainer components;
  protected MGASimpleComboBox comboQuotingOffice;
  private UltraLabel ultraLabel1;
  protected MGASimpleComboBox comboClaimsOffice;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel3;
  protected MGACheckBox checkEnforceViewingRights;
  protected ExtendedTreeViewDropDown extendedTreeGLOffset;

  public LocationSettingsView()
  {
    this.InitializeComponent();
    this.ClearScreen();
    this.comboQuotingOffice.SelectedIndex = 0;
  }

  private void LocationSettingsView_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadOfficeLocations();
    this.LoadGLOffsetAccounts();
    this.GetViewingRightsSetting();
  }

  private void comboQuotingOffice_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() =>
    {
      EnumerableRowCollection<DataRow> source = ((DataTable) ((UltraGridBase) this.comboQuotingOffice).DataSource).AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (quotingOffices =>
      {
        int? nullable3 = quotingOffices.Field<int?>("ID");
        int? nullable4 = (int?) ((UltraCombo) this.comboQuotingOffice).Value;
        return nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() & nullable3.HasValue == nullable4.HasValue;
      }));
      if (source.Count<DataRow>() > 0)
      {
        Guid guid = source.First<DataRow>().Field<Guid>("OfficeGuid");
        this.SetQuotingOfficeGuid(guid);
        this.Model.SetNewId(guid);
      }
      this.SetQuotingOfficeId(Utility.IsNull<int>(((UltraCombo) this.comboQuotingOffice).Value, 0), ((Control) this.comboQuotingOffice).Text);
    }));
  }

  private void comboClaimsOffice_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() =>
    {
      this.SetClaimsOfficeId(Utility.IsNull<int>(((UltraCombo) this.comboClaimsOffice).Value, 0), ((Control) this.comboClaimsOffice).Text);
      this.extendedTreeGLOffset.SetSelectedNodeByKey(string.Empty);
      this.extendedTreeGLOffset.ResetText();
      this.LoadGLOffsetAccounts();
    }));
  }

  private void extendedTreeGLOffset_AfterSelect(object sender, ExtendedDropTree_EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.SetGLAcctId(Utility.IsNull<int>((object) this.extendedTreeGLOffset.GLAccountID, 0), e.Node.Text)));
  }

  private void checkEnforceViewingRights_CheckedValueChanged(object sender, EventArgs e)
  {
    SystemSettings.SetBoolSetting("CLAIMS_ENFORCEVIEWING_RIGHTS", ((UltraToggleEditorBase) this.checkEnforceViewingRights).Checked);
  }

  private void LoadOfficeLocations()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spClaims_GetOfficeLocations");
    ((UltraGridBase) this.comboQuotingOffice).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboQuotingOffice).ValueMember = "ID";
    ((UltraDropDownBase) this.comboQuotingOffice).DisplayMember = "Office Location";
    ((UltraGridBase) this.comboClaimsOffice).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboClaimsOffice).ValueMember = "ID";
    ((UltraDropDownBase) this.comboClaimsOffice).DisplayMember = "Office Location";
  }

  private void LoadGLOffsetAccounts()
  {
    if (((UltraCombo) this.comboClaimsOffice).Value == null)
      return;
    this.extendedTreeGLOffset.DropDownWidth = 300;
    this.extendedTreeGLOffset.DropDownHeight = 300;
    this.extendedTreeGLOffset.LoadGLAccounts((int) ((UltraCombo) this.comboClaimsOffice).Value);
    this.extendedTreeGLOffset.Enabled = true;
  }

  private void GetViewingRightsSetting()
  {
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).Checked = SystemSettings.GetSetting<bool>("CLAIMS_ENFORCEVIEWING_RIGHTS");
  }

  public void ClearScreen()
  {
    foreach (Control control in this.Controls.OfType<MGATextBox>())
      control.Text = string.Empty;
    foreach (UltraToggleEditorBase toggleEditorBase in this.Controls.OfType<MGACheckBox>())
      toggleEditorBase.Checked = false;
    foreach (Control control in this.Controls.OfType<MGAMaskedEdit>())
      control.Text = string.Empty;
    foreach (UltraDropDownBase ultraDropDownBase in this.Controls.OfType<MGASimpleComboBox>())
      ultraDropDownBase.SelectedRow = (UltraGridRow) null;
    this.extendedTreeGLOffset.Enabled = false;
    this.extendedTreeGLOffset.SetSelectedNodeByKey(string.Empty);
    this.extendedTreeGLOffset.ResetText();
  }

  public void SetQuotingOfficeGuid(Guid id) => this.Controller.RequestSetQuotingOfficeGuid(id);

  public void SetQuotingOfficeId(int id, string text)
  {
    this.Controller.RequestSetQuotingOfficeId(id, text);
  }

  public void SetClaimsOfficeId(int id, string text)
  {
    this.Controller.RequestSetClaimsOfficeId(id, text);
  }

  public void SetGLAcctId(int id, string text) => this.Controller.RequestSetGLAcctId(id, text);

  protected override void ChildUpdateFromModel(ILocationSettingsModel model)
  {
    ((UltraCombo) this.comboQuotingOffice).Value = (object) model.QuotingOfficeId;
    ((UltraCombo) this.comboClaimsOffice).Value = (object) model.ClaimsOfficeId;
    this.LoadGLOffsetAccounts();
    this.extendedTreeGLOffset.SetSelectedNodeByKey(model.GLAcctId.ToString());
  }

  protected override void ChildUnWireUp() => this.ClearScreen();

  protected override void ChildSetFocus() => ((UltraCombo) this.comboQuotingOffice).Focus();

  public override void Update(object model)
  {
    if (!(model is ILocationSettingsModel model1))
      return;
    this.Update(model1);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.comboQuotingOffice = new MGASimpleComboBox();
    this.ultraLabel1 = new UltraLabel();
    this.comboClaimsOffice = new MGASimpleComboBox();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.checkEnforceViewingRights = new MGACheckBox();
    this.extendedTreeGLOffset = new ExtendedTreeViewDropDown();
    ((ISupportInitialize) this.comboQuotingOffice).BeginInit();
    ((ISupportInitialize) this.comboClaimsOffice).BeginInit();
    ((ISupportInitialize) this.checkEnforceViewingRights).BeginInit();
    this.SuspendLayout();
    ((UltraCombo) this.comboQuotingOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboQuotingOffice).DisplayMember = "Office Location";
    ((UltraCombo) this.comboQuotingOffice).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboQuotingOffice).Location = new Point(129, 14);
    this.comboQuotingOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboQuotingOffice).Name = "comboQuotingOffice";
    ((Control) this.comboQuotingOffice).Size = new Size(245, 20);
    ((Control) this.comboQuotingOffice).TabIndex = 3;
    ((UltraControlBase) this.comboQuotingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboQuotingOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboQuotingOffice).ValueMember = "ID";
    ((UltraCombo) this.comboQuotingOffice).ValueChanged += new EventHandler(this.comboQuotingOffice_ValueChanged);
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(6, 17);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(93, 14);
    ((Control) this.ultraLabel1).TabIndex = 2;
    ((Control) this.ultraLabel1).Text = "Quoting Location:";
    ((UltraCombo) this.comboClaimsOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboClaimsOffice).DisplayMember = "Office Location";
    ((UltraCombo) this.comboClaimsOffice).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimsOffice).Location = new Point(129, 41);
    this.comboClaimsOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboClaimsOffice).Name = "comboClaimsOffice";
    ((Control) this.comboClaimsOffice).Size = new Size(245, 20);
    ((Control) this.comboClaimsOffice).TabIndex = 5;
    ((UltraControlBase) this.comboClaimsOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimsOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboClaimsOffice).ValueMember = "ID";
    ((UltraCombo) this.comboClaimsOffice).ValueChanged += new EventHandler(this.comboClaimsOffice_ValueChanged);
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(6, 43);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(88, 14);
    ((Control) this.ultraLabel2).TabIndex = 4;
    ((Control) this.ultraLabel2).Text = "Claims Location:";
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel3).Location = new Point(6, 69);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(100, 23);
    ((Control) this.ultraLabel3).TabIndex = 6;
    ((Control) this.ultraLabel3).Text = "GL Offset Account:";
    ((AppearanceBase) appearance4).BorderColor = Color.Gray;
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).Appearance = (AppearanceBase) appearance4;
    ((Control) this.checkEnforceViewingRights).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkEnforceViewingRights).Location = new Point(129, 95);
    ((Control) this.checkEnforceViewingRights).Name = "checkEnforceViewingRights";
    ((Control) this.checkEnforceViewingRights).Size = new Size(245, 20);
    ((Control) this.checkEnforceViewingRights).TabIndex = 8;
    ((Control) this.checkEnforceViewingRights).Text = "Enforce User Viewing Rights (All Accounts)";
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).CheckedValueChanged += new EventHandler(this.checkEnforceViewingRights_CheckedValueChanged);
    this.extendedTreeGLOffset.DropDownHeight = 0;
    this.extendedTreeGLOffset.DropDownWidth = 0;
    this.extendedTreeGLOffset.Font = new Font("Tahoma", 8f);
    this.extendedTreeGLOffset.Location = new Point(129, 68);
    this.extendedTreeGLOffset.Name = "extendedTreeGLOffset";
    this.extendedTreeGLOffset.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.extendedTreeGLOffset.ShowEquityAccounts = true;
    this.extendedTreeGLOffset.ShowExpenseAccounts = true;
    this.extendedTreeGLOffset.ShowIncomeAccounts = true;
    this.extendedTreeGLOffset.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.extendedTreeGLOffset.ShowSystemDefinedAccounts = true;
    this.extendedTreeGLOffset.Size = new Size(245, 20);
    this.extendedTreeGLOffset.TabIndex = 9;
    this.extendedTreeGLOffset.UseCheckedStateSelectionOverride = false;
    this.extendedTreeGLOffset.AfterSelect += new ExtendedTreeViewDropDown.AfterSelectDelegate(this.extendedTreeGLOffset_AfterSelect);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.extendedTreeGLOffset);
    this.Controls.Add((Control) this.checkEnforceViewingRights);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.comboClaimsOffice);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.comboQuotingOffice);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Name = nameof (LocationSettingsView);
    this.Size = new Size(406, 396);
    this.Load += new EventHandler(this.LocationSettingsView_Load);
    ((ISupportInitialize) this.comboQuotingOffice).EndInit();
    ((ISupportInitialize) this.comboClaimsOffice).EndInit();
    ((ISupportInitialize) this.checkEnforceViewingRights).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
