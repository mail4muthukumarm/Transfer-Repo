// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Supplemental_Vehicle_Info.FormSupplementalVehicleInfo
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Underwriting.Supplemental_Vehicle_Info;

[SecureResource("{6DDF758F-CB88-48DD-B9A3-88D0BBD3CC04}", "Mark Supplemental Vehicles Deleted", "Controls the ability to mark supplemental vehicles deleted.", "Policies")]
public class FormSupplementalVehicleInfo : Form
{
  private Guid _quoteGuid;
  private BindingManagerBase _bmb;
  private Quote _Quote;
  private bool _isEndorsement;
  private bool _saveVehicleInfoOnEndorsement;
  protected string _LoadSupplementalVehicleInfoProcName = "LoadSupplementalVehicleInfo";
  public const string MarkSupplementalVehiclesDeleted = "{6DDF758F-CB88-48DD-B9A3-88D0BBD3CC04}";
  private IContainer components;
  private dsSuppVehInfo ds;
  private SqlConnection cnSQL;
  private SqlDataAdapter da;
  private SqlCommand SqlDeleteCommand6;
  private SqlCommand SqlInsertCommand6;
  private SqlCommand SqlSelectCommand13;
  private SqlCommand SqlUpdateCommand6;
  protected UltraGrid ugVehicles;
  protected MGASystems.Tools.DBSaveUI.DBSaveUI dbSave;
  protected MGAComboBox cboLimits;
  protected MGAComboBox mgaComboBox1;
  protected MGATextBox txtClassType;
  protected MGACheckBox chkTRIA;
  protected Label label1;
  protected Label label2;
  protected Label label3;
  protected Label label4;
  protected Label label5;
  protected MGATextBox mgaTextBox1;
  protected MGAComboBox mgaComboBox2;
  protected Label label6;
  protected MGACheckBox mgaCheckBox1;
  protected Label label7;
  protected MGATextBox mgaTextBox2;
  protected MGATextBox mgaTextBox3;
  protected MGATextBox mgaTextBox4;
  protected Label label8;
  protected MGATab tabSVInfo;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  protected UltraTabPageControl tabSupplementalVehicleInfo;
  protected LinkLabel lnkMarkDeleted;
  protected LinkLabel lnkUndeleteCurrentVehicle;
  protected LinkLabel lnkCopyVehicles;

  protected BindingManagerBase bmb => this._bmb;

  protected dsSuppVehInfo BaseDataset => this.ds;

  public FormSupplementalVehicleInfo(Guid quoteGuid)
  {
    this.InitializeComponent();
    if (this.DesignMode)
      return;
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._quoteGuid = quoteGuid;
    this._Quote = new Quote(quoteGuid);
    this._isEndorsement = this._Quote.IsEndorsement;
  }

  public FormSupplementalVehicleInfo() => this.InitializeComponent();

  private void FormSupplementalVehicleInfo_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (SystemSettings.KeyExists("SaveVehicleInfoOnEndorsement") && SystemSettings.GetBoolSetting("SaveVehicleInfoOnEndorsement"))
      this._saveVehicleInfoOnEndorsement = true;
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
      {
        "lstTransactionTypes",
        "lstRegistrantType",
        "lstPolicyTypes",
        "tblSupplementalVehicleInfo"
      }, this._LoadSupplementalVehicleInfoProcName, new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
      this._bmb = this.BindingContext[(object) this.ds, this.ds.tblSupplementalVehicleInfo.TableName];
    }
    catch (ConstraintException ex)
    {
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
    }
    this._bmb.Position = this.ds.tblSupplementalVehicleInfo.Count - 1;
    this.EnableControls(false);
    this.SetSaveState();
    this.LoadClient();
    this.ShowDeletedRecords();
  }

  private void EnableControls(bool enable)
  {
    foreach (Control control in (ArrangedElementCollection) ((Control) this.tabSupplementalVehicleInfo).Controls)
    {
      if (control is MGAComboBox)
        control.Enabled = enable;
      if (control is MGATextBox)
        control.Enabled = enable;
      if (control is MGACheckBox)
        control.Enabled = enable;
    }
    ((Control) this.ugVehicles).Enabled = !enable;
    this.EnableClientControls(enable);
  }

  protected virtual void EnableClientControls(bool enable)
  {
  }

  private void SetSaveState()
  {
    if (this.ds.tblSupplementalVehicleInfo.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  protected virtual bool ValidFormData() => true;

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidFormData())
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblSupplementalVehicleInfo);
      this.SaveOnClient(this.ds.tblSupplementalVehicleInfo[this._bmb.Position].ID, e);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugVehicles).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("Continue with the deletion?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      int int32 = Convert.ToInt32(((UltraGridBase) this.ugVehicles).ActiveRow.Cells["ID"].Value);
      if (this._isEndorsement && this._saveVehicleInfoOnEndorsement)
      {
        this.MarkVehicleDeleted(int32);
      }
      else
      {
        this.DeleteOnClient(int32, e);
        this.ds.tblSupplementalVehicleInfo.FindByID(int32).Delete();
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblSupplementalVehicleInfo);
        this.SetSaveState();
      }
    }
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    dsSuppVehInfo.tblSupplementalVehicleInfoRow row = this.ds.tblSupplementalVehicleInfo.NewtblSupplementalVehicleInfoRow();
    row.QuoteGuid = this._quoteGuid;
    row.TowingLabor = false;
    row.Guest = false;
    this.ds.tblSupplementalVehicleInfo.AddtblSupplementalVehicleInfoRow(row);
    this._bmb.Position = this.ds.tblSupplementalVehicleInfo.Count - 1;
    this.EnableControls(true);
    this.ClickedNewOnClient(e);
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.EnableControls(true);
    this.ClickedEditOnClient();
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblSupplementalVehicleInfo.RejectChanges();
    this.EnableControls(false);
    this.SetSaveState();
    this.ClickedCancelOnClient(e);
  }

  private void ugVehicles_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugVehicles).ActiveRow == null)
      return;
    Database.MoveTo(((UltraGridBase) this.ugVehicles).ActiveRow.Cells["ID"].Value, "ID", (DataTable) this.ds.tblSupplementalVehicleInfo, this._bmb);
    this.AfterRowActivateOnClient(Convert.ToInt32(((UltraGridBase) this.ugVehicles).ActiveRow.Cells["ID"].Value));
  }

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    this.EnableControls(false);
    this.SetSaveState();
  }

  protected virtual void LoadClient()
  {
  }

  protected virtual void AfterRowActivateOnClient(int ID)
  {
  }

  protected virtual void DeleteOnClient(int ID, CancelEventArgs e)
  {
  }

  protected virtual void SaveOnClient(int ID, CancelEventArgs e)
  {
  }

  protected virtual void ClickedNewOnClient(EventArgs e)
  {
  }

  protected virtual void ClickedCancelOnClient(EventArgs e)
  {
  }

  protected virtual void ClickedEditOnClient()
  {
  }

  private void ShowDeletedRecords()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugVehicles).Rows)
    {
      ((AppearanceBase) row.Appearance).FontData.Strikeout = (DefaultableBoolean) 2;
      ((AppearanceBase) row.Appearance).ForeColor = Color.Black;
      if (row.Cells["Deleted"].Value != null && row.Cells["Deleted"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Deleted"].Value))
      {
        ((AppearanceBase) row.Appearance).FontData.Strikeout = (DefaultableBoolean) 1;
        ((AppearanceBase) row.Appearance).ForeColor = Color.Red;
      }
    }
  }

  private void lnkMarkDeleted_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugVehicles).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("Please select a row in the grid.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!SecurityManager.Instance.AssertPermission("{6DDF758F-CB88-48DD-B9A3-88D0BBD3CC04}"))
    {
      int num2 = (int) MessageBox.Show("You do not have the required security to mark vehicles deleted.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("You are about to mark a vehicle deleted.\n \nContinue and mark the current vehicle deleted?", "Mark Vehicle Deleted?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      this.MarkVehicleDeleted(Convert.ToInt32(((UltraGridBase) this.ugVehicles).ActiveRow.Cells["ID"].Value));
    }
  }

  private void MarkVehicleDeleted(int tmpID)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblSupplementalVehicleInfo SET Deleted = 1 WHERE QuoteGuid = @QG AND ID = @ID", new object[4]
    {
      (object) "@ID",
      (object) tmpID,
      (object) "@QG",
      (object) this._quoteGuid
    });
    this.ds.tblSupplementalVehicleInfo.FindByID(tmpID).Deleted = true;
    this.ShowDeletedRecords();
    this.SetSaveState();
  }

  private void lnkUndeleteCurrentVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugVehicles).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("You are about to un-delete a vehicle.\n \nContinue and un-delete the current vehicle?", "Un-Delete Vehicle?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      int int32 = Convert.ToInt32(((UltraGridBase) this.ugVehicles).ActiveRow.Cells["ID"].Value);
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblSupplementalVehicleInfo SET Deleted = 0 WHERE QuoteGuid = @QG AND ID = @ID", new object[4]
      {
        (object) "@ID",
        (object) int32,
        (object) "@QG",
        (object) this._quoteGuid
      });
      this.ds.tblSupplementalVehicleInfo.FindByID(int32).Deleted = false;
      this.ShowDeletedRecords();
      this.SetSaveState();
    }
  }

  private void lnkCopyVehicles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormCopyVehicles formCopyVehicles = new FormCopyVehicles(this._quoteGuid))
    {
      int num = (int) formCopyVehicles.ShowDialog();
    }
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstPolicyTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
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
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstTransactionTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TransactionType");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstRegistrantType", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RegistrantType");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance49 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSupplementalVehicleInfo));
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraTab ultraTab = new UltraTab();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblSupplementalVehicleInfo", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TransactionID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("VIN");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Make");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Model");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("RegistrantID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("TowingLabor");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("RenalReimbursement");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Guest");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Deleted");
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    this.tabSupplementalVehicleInfo = new UltraTabPageControl();
    this.lnkCopyVehicles = new LinkLabel();
    this.lnkUndeleteCurrentVehicle = new LinkLabel();
    this.lnkMarkDeleted = new LinkLabel();
    this.mgaComboBox1 = new MGAComboBox();
    this.ds = new dsSuppVehInfo();
    this.mgaTextBox4 = new MGATextBox();
    this.cboLimits = new MGAComboBox();
    this.label8 = new Label();
    this.txtClassType = new MGATextBox();
    this.mgaTextBox3 = new MGATextBox();
    this.chkTRIA = new MGACheckBox();
    this.mgaTextBox2 = new MGATextBox();
    this.label1 = new Label();
    this.label7 = new Label();
    this.label2 = new Label();
    this.mgaCheckBox1 = new MGACheckBox();
    this.label3 = new Label();
    this.label6 = new Label();
    this.label4 = new Label();
    this.mgaComboBox2 = new MGAComboBox();
    this.label5 = new Label();
    this.mgaTextBox1 = new MGATextBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.cnSQL = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand6 = new SqlCommand();
    this.SqlInsertCommand6 = new SqlCommand();
    this.SqlSelectCommand13 = new SqlCommand();
    this.SqlUpdateCommand6 = new SqlCommand();
    this.tabSVInfo = new MGATab();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ugVehicles = new UltraGrid();
    ((Control) this.tabSupplementalVehicleInfo).SuspendLayout();
    ((ISupportInitialize) this.mgaComboBox1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.mgaTextBox4).BeginInit();
    ((ISupportInitialize) this.cboLimits).BeginInit();
    ((ISupportInitialize) this.txtClassType).BeginInit();
    ((ISupportInitialize) this.mgaTextBox3).BeginInit();
    ((ISupportInitialize) this.chkTRIA).BeginInit();
    ((ISupportInitialize) this.mgaTextBox2).BeginInit();
    ((ISupportInitialize) this.mgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.mgaComboBox2).BeginInit();
    ((ISupportInitialize) this.mgaTextBox1).BeginInit();
    ((ISupportInitialize) this.tabSVInfo).BeginInit();
    ((Control) this.tabSVInfo).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.ugVehicles).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.lnkCopyVehicles);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.lnkUndeleteCurrentVehicle);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.lnkMarkDeleted);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaComboBox1);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaTextBox4);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.cboLimits);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label8);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.txtClassType);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaTextBox3);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.chkTRIA);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaTextBox2);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label1);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label7);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label2);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaCheckBox1);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label3);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label6);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label4);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaComboBox2);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.label5);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.mgaTextBox1);
    ((Control) this.tabSupplementalVehicleInfo).Controls.Add((Control) this.dbSave);
    ((Control) this.tabSupplementalVehicleInfo).Location = new Point(1, 30);
    ((Control) this.tabSupplementalVehicleInfo).Name = "tabSupplementalVehicleInfo";
    ((Control) this.tabSupplementalVehicleInfo).Size = new Size(784, 209);
    this.lnkCopyVehicles.AutoSize = true;
    this.lnkCopyVehicles.BackColor = Color.Transparent;
    this.lnkCopyVehicles.Location = new Point(455, 133);
    this.lnkCopyVehicles.Name = "lnkCopyVehicles";
    this.lnkCopyVehicles.Size = new Size(137, 13);
    this.lnkCopyVehicles.TabIndex = 87;
    this.lnkCopyVehicles.TabStop = true;
    this.lnkCopyVehicles.Text = "Copy Vehicles to Control #s";
    this.lnkCopyVehicles.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkCopyVehicles_LinkClicked);
    this.lnkUndeleteCurrentVehicle.AutoSize = true;
    this.lnkUndeleteCurrentVehicle.BackColor = Color.Transparent;
    this.lnkUndeleteCurrentVehicle.Location = new Point(455, 159);
    this.lnkUndeleteCurrentVehicle.Name = "lnkUndeleteCurrentVehicle";
    this.lnkUndeleteCurrentVehicle.Size = new Size(130, 13);
    this.lnkUndeleteCurrentVehicle.TabIndex = 86;
    this.lnkUndeleteCurrentVehicle.TabStop = true;
    this.lnkUndeleteCurrentVehicle.Text = "Un-Delete Current Vehicle";
    this.lnkUndeleteCurrentVehicle.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkUndeleteCurrentVehicle_LinkClicked);
    this.lnkMarkDeleted.AutoSize = true;
    this.lnkMarkDeleted.BackColor = Color.Transparent;
    this.lnkMarkDeleted.Location = new Point(455, 185);
    this.lnkMarkDeleted.Name = "lnkMarkDeleted";
    this.lnkMarkDeleted.Size = new Size(146, 13);
    this.lnkMarkDeleted.TabIndex = 85;
    this.lnkMarkDeleted.TabStop = true;
    this.lnkMarkDeleted.Text = "Mark Current Vehicle Deleted";
    this.lnkMarkDeleted.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkMarkDeleted_LinkClicked);
    ((Control) this.mgaComboBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.mgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.mgaComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSupplementalVehicleInfo.PolicyTypeID", true));
    ((UltraGridBase) this.mgaComboBox1).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.mgaComboBox1).DataSource = (object) this.ds;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb(78, 122, 171);
    this.mgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.mgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 82;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 431;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.mgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.mgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.mgaComboBox1.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance2).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.mgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).ForeColor = SystemColors.GrayText;
    this.mgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) this.mgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance4).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance4).ForeColor = SystemColors.GrayText;
    this.mgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    this.mgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.mgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance5).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance5).ForeColor = SystemColors.ControlText;
    this.mgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance6).ForeColor = SystemColors.HighlightText;
    this.mgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.mgaComboBox1.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance7).BackColor = SystemColors.Window;
    this.mgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    ((AppearanceBase) appearance8).TextTrimming = (TextTrimming) 3;
    this.mgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    this.mgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.mgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance9).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance9).BorderColor = SystemColors.Window;
    this.mgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    this.mgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    this.mgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.mgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.mgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance12).BorderColor = Color.White;
    this.mgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.mgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.mgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    this.mgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = SystemColors.ControlLight;
    this.mgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.mgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.mgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.mgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.mgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.mgaComboBox1).DisplayMember = "Description";
    this.mgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.mgaComboBox1).DropDownWidth = 450;
    ((Control) this.mgaComboBox1).Location = new Point(110, 41);
    this.mgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaComboBox1).Name = "mgaComboBox1";
    ((Control) this.mgaComboBox1).Size = new Size(210, 20);
    ((Control) this.mgaComboBox1).TabIndex = 1;
    ((UltraControlBase) this.mgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.mgaComboBox1).ValueMember = "PolicyTypeID";
    this.ds.DataSetName = "dsSuppVehInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.mgaTextBox4).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox4).Appearance = (AppearanceBase) appearance15;
    ((Control) this.mgaTextBox4).BackColor = Color.White;
    ((Control) this.mgaTextBox4).DataBindings.Add(new Binding("Text", (object) this.ds, "tblSupplementalVehicleInfo.Model", true));
    ((Control) this.mgaTextBox4).Location = new Point(458, 7);
    ((TextEditorControlBase) this.mgaTextBox4).MaxLength = 50;
    this.mgaTextBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaTextBox4).Name = "mgaTextBox4";
    ((Control) this.mgaTextBox4).Size = new Size(229, 19);
    ((Control) this.mgaTextBox4).TabIndex = 6;
    ((UltraControlBase) this.mgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboLimits).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboLimits.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLimits).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSupplementalVehicleInfo.TransactionID", true));
    ((UltraGridBase) this.cboLimits).DataMember = "lstTransactionTypes";
    ((UltraGridBase) this.cboLimits).DataSource = (object) this.ds;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboLimits.DisplayLayout.Appearance = (AppearanceBase) appearance16;
    this.cboLimits.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 1;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 49;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Width = 431;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboLimits.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboLimits.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLimits.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance17).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboLimits.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).ForeColor = SystemColors.GrayText;
    this.cboLimits.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance18;
    ((SpecialBoxBase) this.cboLimits.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance19).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance19).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance19).ForeColor = SystemColors.GrayText;
    this.cboLimits.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance19;
    this.cboLimits.DisplayLayout.MaxColScrollRegions = 1;
    this.cboLimits.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance20).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance20).ForeColor = SystemColors.ControlText;
    this.cboLimits.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance21).ForeColor = SystemColors.HighlightText;
    this.cboLimits.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    this.cboLimits.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboLimits.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance22).BackColor = SystemColors.Window;
    this.cboLimits.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BorderColor = Color.Silver;
    ((AppearanceBase) appearance23).TextTrimming = (TextTrimming) 3;
    this.cboLimits.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance23;
    this.cboLimits.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboLimits.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance24).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance24).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance24).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance24).BorderColor = SystemColors.Window;
    this.cboLimits.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    this.cboLimits.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance25;
    this.cboLimits.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboLimits.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboLimits.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance27).BorderColor = Color.White;
    this.cboLimits.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance27;
    this.cboLimits.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboLimits.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance28).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    this.cboLimits.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = SystemColors.ControlLight;
    this.cboLimits.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance29;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboLimits.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboLimits.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboLimits.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboLimits.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboLimits).DisplayMember = "TransactionType";
    this.cboLimits.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLimits).DropDownWidth = 450;
    ((Control) this.cboLimits).Location = new Point(110, 6);
    this.cboLimits.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLimits).Name = "cboLimits";
    ((Control) this.cboLimits).Size = new Size(210, 20);
    ((Control) this.cboLimits).TabIndex = 0;
    ((UltraControlBase) this.cboLimits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLimits).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLimits).ValueMember = "ID";
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(336, 10);
    this.label8.Name = "label8";
    this.label8.Size = new Size(39, 13);
    this.label8.TabIndex = 84;
    this.label8.Text = "Model:";
    ((Control) this.txtClassType).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtClassType).Appearance = (AppearanceBase) appearance30;
    ((Control) this.txtClassType).BackColor = Color.White;
    ((Control) this.txtClassType).DataBindings.Add(new Binding("Text", (object) this.ds, "tblSupplementalVehicleInfo.VIN", true));
    ((Control) this.txtClassType).Location = new Point(110, 111);
    ((TextEditorControlBase) this.txtClassType).MaxLength = 50;
    this.txtClassType.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtClassType).Name = "txtClassType";
    ((Control) this.txtClassType).Size = new Size(210, 19);
    ((Control) this.txtClassType).TabIndex = 3;
    ((UltraControlBase) this.txtClassType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClassType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaTextBox3).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance31).BackColor = Color.White;
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox3).Appearance = (AppearanceBase) appearance31;
    ((Control) this.mgaTextBox3).BackColor = Color.White;
    ((Control) this.mgaTextBox3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSupplementalVehicleInfo.RenalReimbursement", true));
    ((Control) this.mgaTextBox3).Location = new Point(458, 39);
    ((TextEditorControlBase) this.mgaTextBox3).MaxLength = 50;
    this.mgaTextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaTextBox3).Name = "mgaTextBox3";
    ((Control) this.mgaTextBox3).Size = new Size(229, 19);
    ((Control) this.mgaTextBox3).TabIndex = 7;
    ((UltraControlBase) this.mgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkTRIA).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance32).BackColor = Color.Transparent;
    ((AppearanceBase) appearance32).BorderColor = Color.Gray;
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkTRIA).Appearance = (AppearanceBase) appearance32;
    ((Control) this.chkTRIA).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTRIA).BackColorInternal = Color.Transparent;
    ((Control) this.chkTRIA).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblSupplementalVehicleInfo.TowingLabor", true));
    ((Control) this.chkTRIA).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.chkTRIA).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkTRIA).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkTRIA).Location = new Point(458, 71);
    ((Control) this.chkTRIA).Name = "chkTRIA";
    ((Control) this.chkTRIA).Size = new Size(102, 18);
    ((Control) this.chkTRIA).TabIndex = 8;
    ((Control) this.chkTRIA).Text = "Towing / Labor";
    ((UltraControlBase) this.chkTRIA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTRIA).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaTextBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance33).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox2).Appearance = (AppearanceBase) appearance33;
    ((Control) this.mgaTextBox2).BackColor = Color.White;
    ((Control) this.mgaTextBox2).DataBindings.Add(new Binding("Text", (object) this.ds, "tblSupplementalVehicleInfo.Year", true));
    ((Control) this.mgaTextBox2).Location = new Point(110, 145);
    ((TextEditorControlBase) this.mgaTextBox2).MaxLength = 15;
    this.mgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaTextBox2).Name = "mgaTextBox2";
    ((Control) this.mgaTextBox2).Size = new Size(137, 19);
    ((Control) this.mgaTextBox2).TabIndex = 4;
    ((UltraControlBase) this.mgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(10, 10);
    this.label1.Name = "label1";
    this.label1.Size = new Size(93, 13);
    this.label1.TabIndex = 72;
    this.label1.Text = "Transaction Type:";
    this.label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Location = new Point(336, 42);
    this.label7.Name = "label7";
    this.label7.Size = new Size(114, 13);
    this.label7.TabIndex = 82;
    this.label7.Text = "Renal Reimbursement:";
    this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(10, 45);
    this.label2.Name = "label2";
    this.label2.Size = new Size(65, 13);
    this.label2.TabIndex = 73;
    this.label2.Text = "Policy Type:";
    ((Control) this.mgaCheckBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance34).BackColor = Color.Transparent;
    ((AppearanceBase) appearance34).BorderColor = Color.Gray;
    ((AppearanceBase) appearance34).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.mgaCheckBox1).Appearance = (AppearanceBase) appearance34;
    ((Control) this.mgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.mgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.mgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblSupplementalVehicleInfo.Guest", true));
    ((Control) this.mgaCheckBox1).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.mgaCheckBox1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.mgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.mgaCheckBox1).Location = new Point(458, 103);
    ((Control) this.mgaCheckBox1).Name = "mgaCheckBox1";
    ((Control) this.mgaCheckBox1).Size = new Size(74, 18);
    ((Control) this.mgaCheckBox1).TabIndex = 9;
    ((Control) this.mgaCheckBox1).Text = "Guest";
    ((UltraControlBase) this.mgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(10, 114);
    this.label3.Name = "label3";
    this.label3.Size = new Size(28, 13);
    this.label3.TabIndex = 74;
    this.label3.Text = "VIN:";
    this.label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(10, 80 /*0x50*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(85, 13);
    this.label6.TabIndex = 80 /*0x50*/;
    this.label6.Text = "Registrant Type:";
    this.label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(10, 148);
    this.label4.Name = "label4";
    this.label4.Size = new Size(32 /*0x20*/, 13);
    this.label4.TabIndex = 75;
    this.label4.Text = "Year:";
    ((Control) this.mgaComboBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.mgaComboBox2.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.mgaComboBox2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSupplementalVehicleInfo.RegistrantID", true));
    ((UltraGridBase) this.mgaComboBox2).DataMember = "lstRegistrantType";
    ((UltraGridBase) this.mgaComboBox2).DataSource = (object) this.ds;
    ((AppearanceBase) appearance35).BackColor = Color.White;
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb(78, 122, 171);
    this.mgaComboBox2.DisplayLayout.Appearance = (AppearanceBase) appearance35;
    this.mgaComboBox2.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 53;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Width = 431;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.mgaComboBox2.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.mgaComboBox2.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.mgaComboBox2.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance36).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance36).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance36).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.mgaComboBox2.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).ForeColor = SystemColors.GrayText;
    this.mgaComboBox2.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance37;
    ((SpecialBoxBase) this.mgaComboBox2.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance38).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance38).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance38).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance38).ForeColor = SystemColors.GrayText;
    this.mgaComboBox2.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance38;
    this.mgaComboBox2.DisplayLayout.MaxColScrollRegions = 1;
    this.mgaComboBox2.DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance39).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance39).ForeColor = SystemColors.ControlText;
    this.mgaComboBox2.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance40).ForeColor = SystemColors.HighlightText;
    this.mgaComboBox2.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance40;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.mgaComboBox2.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance41).BackColor = SystemColors.Window;
    this.mgaComboBox2.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance41;
    ((AppearanceBase) appearance42).BorderColor = Color.Silver;
    ((AppearanceBase) appearance42).TextTrimming = (TextTrimming) 3;
    this.mgaComboBox2.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance42;
    this.mgaComboBox2.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.mgaComboBox2.DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance43).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance43).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance43).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance43).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance43).BorderColor = SystemColors.Window;
    this.mgaComboBox2.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Left";
    this.mgaComboBox2.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance44;
    this.mgaComboBox2.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.mgaComboBox2.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance45).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.mgaComboBox2.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance46).BorderColor = Color.White;
    this.mgaComboBox2.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance46;
    this.mgaComboBox2.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.mgaComboBox2.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance47).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance47).ForeColor = Color.Black;
    this.mgaComboBox2.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BackColor = SystemColors.ControlLight;
    this.mgaComboBox2.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance48;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.mgaComboBox2.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.mgaComboBox2.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.mgaComboBox2.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.mgaComboBox2.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.mgaComboBox2).DisplayMember = "RegistrantType";
    this.mgaComboBox2.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.mgaComboBox2).DropDownWidth = 450;
    ((Control) this.mgaComboBox2).Location = new Point(110, 76);
    this.mgaComboBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaComboBox2).Name = "mgaComboBox2";
    ((Control) this.mgaComboBox2).Size = new Size(210, 20);
    ((Control) this.mgaComboBox2).TabIndex = 2;
    ((UltraControlBase) this.mgaComboBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaComboBox2).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.mgaComboBox2).ValueMember = "ID";
    this.label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(10, 182);
    this.label5.Name = "label5";
    this.label5.Size = new Size(37, 13);
    this.label5.TabIndex = 76;
    this.label5.Text = "Make:";
    ((Control) this.mgaTextBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance49).BackColor = Color.White;
    ((AppearanceBase) appearance49).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox1).Appearance = (AppearanceBase) appearance49;
    ((Control) this.mgaTextBox1).BackColor = Color.White;
    ((Control) this.mgaTextBox1).DataBindings.Add(new Binding("Text", (object) this.ds, "tblSupplementalVehicleInfo.Make", true));
    ((Control) this.mgaTextBox1).Location = new Point(110, 179);
    ((TextEditorControlBase) this.mgaTextBox1).MaxLength = 50;
    this.mgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaTextBox1).Name = "mgaTextBox1";
    ((Control) this.mgaTextBox1).Size = new Size(210, 19);
    ((Control) this.mgaTextBox1).TabIndex = 5;
    ((UltraControlBase) this.mgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(657, 156);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 10;
    this.dbSave.ClickedNew += new EventHandler(this.dbSave_ClickedNew);
    this.dbSave.ClickingSave += new CancelEventHandler(this.dbSave_ClickingSave);
    this.dbSave.ClickedSave += new EventHandler(this.dbSave_ClickedSave);
    this.dbSave.ClickingDelete += new CancelEventHandler(this.dbSave_ClickingDelete);
    this.dbSave.ClickedCancel += new EventHandler(this.dbSave_ClickedCancel);
    this.dbSave.ClickingEdit += new CancelEventHandler(this.dbSave_ClickingEdit);
    this.cnSQL.ConnectionString = "Data Source=COLOSQL2;Initial Catalog=WKFC_IMS;Persist Security Info=True;User ID=erichards";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand6;
    this.da.InsertCommand = this.SqlInsertCommand6;
    this.da.SelectCommand = this.SqlSelectCommand13;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSupplementalVehicleInfo", new DataColumnMapping[12]
      {
        new DataColumnMapping("TransactionID", "TransactionID"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("VIN", "VIN"),
        new DataColumnMapping("Year", "Year"),
        new DataColumnMapping("Make", "Make"),
        new DataColumnMapping("Model", "Model"),
        new DataColumnMapping("RegistrantID", "RegistrantID"),
        new DataColumnMapping("TowingLabor", "TowingLabor"),
        new DataColumnMapping("RenalReimbursement", "RenalReimbursement"),
        new DataColumnMapping("Guest", "Guest"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("ID", "ID")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand6;
    this.SqlDeleteCommand6.CommandText = "DELETE FROM [dbo].[tblSupplementalVehicleInfo] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand6.Connection = this.cnSQL;
    this.SqlDeleteCommand6.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand6.CommandText = componentResourceManager.GetString("SqlInsertCommand6.CommandText");
    this.SqlInsertCommand6.Connection = this.cnSQL;
    this.SqlInsertCommand6.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@TransactionID", SqlDbType.Char, 0, "TransactionID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.Int, 0, "PolicyTypeID"),
      new SqlParameter("@VIN", SqlDbType.VarChar, 0, "VIN"),
      new SqlParameter("@Year", SqlDbType.VarChar, 0, "Year"),
      new SqlParameter("@Make", SqlDbType.VarChar, 0, "Make"),
      new SqlParameter("@Model", SqlDbType.VarChar, 0, "Model"),
      new SqlParameter("@RegistrantID", SqlDbType.Int, 0, "RegistrantID"),
      new SqlParameter("@TowingLabor", SqlDbType.Bit, 0, "TowingLabor"),
      new SqlParameter("@RenalReimbursement", SqlDbType.VarChar, 0, "RenalReimbursement"),
      new SqlParameter("@Guest", SqlDbType.Bit, 0, "Guest"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid")
    });
    this.SqlSelectCommand13.CommandText = componentResourceManager.GetString("SqlSelectCommand13.CommandText");
    this.SqlSelectCommand13.Connection = this.cnSQL;
    this.SqlSelectCommand13.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand6.CommandText = componentResourceManager.GetString("SqlUpdateCommand6.CommandText");
    this.SqlUpdateCommand6.Connection = this.cnSQL;
    this.SqlUpdateCommand6.Parameters.AddRange(new SqlParameter[13]
    {
      new SqlParameter("@TransactionID", SqlDbType.Char, 0, "TransactionID"),
      new SqlParameter("@PolicyTypeID", SqlDbType.Int, 0, "PolicyTypeID"),
      new SqlParameter("@VIN", SqlDbType.VarChar, 0, "VIN"),
      new SqlParameter("@Year", SqlDbType.VarChar, 0, "Year"),
      new SqlParameter("@Make", SqlDbType.VarChar, 0, "Make"),
      new SqlParameter("@Model", SqlDbType.VarChar, 0, "Model"),
      new SqlParameter("@RegistrantID", SqlDbType.Int, 0, "RegistrantID"),
      new SqlParameter("@TowingLabor", SqlDbType.Bit, 0, "TowingLabor"),
      new SqlParameter("@RenalReimbursement", SqlDbType.VarChar, 0, "RenalReimbursement"),
      new SqlParameter("@Guest", SqlDbType.Bit, 0, "Guest"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    ((Control) this.tabSVInfo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance50).BackColor = Color.Transparent;
    ((UltraTabControlBase) this.tabSVInfo).Appearance = (AppearanceBase) appearance50;
    ((Control) this.tabSVInfo).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.tabSVInfo).Controls.Add((Control) this.tabSupplementalVehicleInfo);
    ((Control) this.tabSVInfo).Location = new Point(12, (int) byte.MaxValue);
    ((Control) this.tabSVInfo).Name = "tabSVInfo";
    ((AppearanceBase) appearance51).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance51).BorderColor = Color.Gray;
    ((UltraTabControlBase) this.tabSVInfo).SelectedTabAppearance = (AppearanceBase) appearance51;
    ((UltraTabControlBase) this.tabSVInfo).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.tabSVInfo).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.tabSVInfo).Size = new Size(786, 240 /*0xF0*/);
    ((UltraTabControlBase) this.tabSVInfo).Style = (UltraTabControlStyle) 13;
    ((Control) this.tabSVInfo).TabIndex = 0;
    ((UltraTabControlBase) this.tabSVInfo).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.tabSVInfo).TabPadding = new Size(10, 5);
    ((AppearanceBase) appearance52).BackColor = Color.White;
    ultraTab.ActiveAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).Image = componentResourceManager.GetObject("appearance53.Image");
    ultraTab.Appearance = (AppearanceBase) appearance53;
    ((KeyedSubObjectBase) ultraTab).Key = "tabSupplementalVehicleInfo";
    ultraTab.TabPage = this.tabSupplementalVehicleInfo;
    ultraTab.Text = "Supplemental Vehicle Information";
    ((UltraTabControlBase) this.tabSVInfo).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab
    });
    ((UltraControlBase) this.tabSVInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.tabSVInfo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.tabSVInfo).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(784, 209);
    ((Control) this.ugVehicles).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugVehicles).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugVehicles).DataMember = "tblSupplementalVehicleInfo";
    ((UltraGridBase) this.ugVehicles).DataSource = (object) this.ds;
    ((AppearanceBase) appearance54).BackColor = Color.White;
    ((AppearanceBase) appearance54).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Appearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 55;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 89;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 2;
    ultraGridColumn9.Width = 134;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 3;
    ultraGridColumn10.Width = 97;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 4;
    ultraGridColumn11.Width = 169;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 5;
    ultraGridColumn12.Width = 170;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 6;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 52;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Towing Labor";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 7;
    ultraGridColumn14.Width = 84;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Renal Reimbursement";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 8;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 136;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 9;
    ultraGridColumn16.Width = 59;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 10;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 174;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 11;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 52;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 12;
    ultraGridColumn19.Width = 71;
    ultraGridBand4.Columns.AddRange(new object[13]
    {
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
      (object) ultraGridColumn19
    });
    ((UltraGridBase) this.ugVehicles).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance55).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance55).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance55).ForeColor = Color.Black;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance56).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance56).ForeColor = Color.Black;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance57).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance57;
    ((AppearanceBase) appearance58).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance59).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance59;
    ((AppearanceBase) appearance60).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance61).BackColor = Color.Transparent;
    ((AppearanceBase) appearance61).ForeColor = Color.Black;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance62).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.ugVehicles).Enabled = false;
    ((Control) this.ugVehicles).Location = new Point(12, 12);
    ((Control) this.ugVehicles).Name = "ugVehicles";
    ((Control) this.ugVehicles).Size = new Size(786, 237);
    ((Control) this.ugVehicles).TabIndex = 0;
    ((Control) this.ugVehicles).Text = "Vehicle Information";
    ((UltraControlBase) this.ugVehicles).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugVehicles).UseOsThemes = (DefaultableBoolean) 2;
    this.ugVehicles.AfterRowActivate += new EventHandler(this.ugVehicles_AfterRowActivate);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(810, 507);
    this.Controls.Add((Control) this.tabSVInfo);
    this.Controls.Add((Control) this.ugVehicles);
    this.Name = nameof (FormSupplementalVehicleInfo);
    this.Text = " ";
    this.Load += new EventHandler(this.FormSupplementalVehicleInfo_Load);
    ((Control) this.tabSupplementalVehicleInfo).ResumeLayout(false);
    ((Control) this.tabSupplementalVehicleInfo).PerformLayout();
    ((ISupportInitialize) this.mgaComboBox1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.mgaTextBox4).EndInit();
    ((ISupportInitialize) this.cboLimits).EndInit();
    ((ISupportInitialize) this.txtClassType).EndInit();
    ((ISupportInitialize) this.mgaTextBox3).EndInit();
    ((ISupportInitialize) this.chkTRIA).EndInit();
    ((ISupportInitialize) this.mgaTextBox2).EndInit();
    ((ISupportInitialize) this.mgaCheckBox1).EndInit();
    ((ISupportInitialize) this.mgaComboBox2).EndInit();
    ((ISupportInitialize) this.mgaTextBox1).EndInit();
    ((ISupportInitialize) this.tabSVInfo).EndInit();
    ((Control) this.tabSVInfo).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.ugVehicles).EndInit();
    this.ResumeLayout(false);
  }
}
