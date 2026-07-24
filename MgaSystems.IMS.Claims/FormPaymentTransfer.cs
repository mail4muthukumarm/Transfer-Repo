// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormPaymentTransfer
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.NoteDocuments;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormPaymentTransfer : FormBase, ISupportDocumentSystem, IRecreatableEntity
{
  private int _bankAccount;
  private bool _hasBeenActive;
  private IContainer components;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Bottom;
  private BindingSource dsPaymentTransferBindingSource;
  private dsGetBankAccountsDropDown dsGetBankAccountsDropDown1;
  protected dsPaymentTransfer dsPaymentTransfer;
  protected UltraGrid gridPayments;
  protected Panel FormBackground_Fill_Panel;
  public UltraToolbarsManager ultraToolbarsManager1;

  public FormPaymentTransfer() => this.InitializeComponent();

  public int BankAccount
  {
    get => this._bankAccount;
    private set => this._bankAccount = value;
  }

  protected virtual void LoadPayments()
  {
    this.Cursor = MgaCursors.WaitCursor;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += new DoWorkEventHandler(this.LoadPaymentsDoWork);
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.LoadPaymentsRunWorkerCompleted);
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected virtual void LoadPaymentsDoWork(object sender, DoWorkEventArgs e)
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsPaymentTransfer.Payments, "spClaims_GetPaymentTransfer");
  }

  protected virtual void LoadPaymentsRunWorkerCompleted(
    object sender,
    RunWorkerCompletedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPayments).Rows)
      row.Cells["CREATECHECK"].Value = (object) true;
    this.Cursor = MgaCursors.Default;
  }

  public virtual void Transfer(string paymentProcedureName)
  {
    this.Transfer(paymentProcedureName, new object[0]);
  }

  public virtual void Transfer(string paymentProcedureName, params object[] args)
  {
    this.Cursor = MgaCursors.WaitCursor;
    if (string.IsNullOrEmpty(paymentProcedureName))
      paymentProcedureName = "spClaims_TransferPayment";
    int length = args.Length;
    try
    {
      if (((UltraGridBase) this.gridPayments).Rows.GetFilteredInNonGroupByRows().Length == 0)
        return;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridPayments).Rows.GetFilteredInNonGroupByRows();
        for (int index = 0; index < inNonGroupByRows.Length; ++index)
        {
          if ((bool) inNonGroupByRows[index].Cells["SELECT"].Value)
          {
            if ((Decimal) inNonGroupByRows[index].Cells["ResPayAmount"].Value > 0M)
            {
              if ((bool) inNonGroupByRows[index].Cells["CREATECHECK"].Value)
              {
                if (args.Length != 0)
                {
                  object[] objArray1 = new object[6]
                  {
                    (object) "@ResPayId",
                    (object) (int) inNonGroupByRows[index].Cells["ResPayId"].Value,
                    (object) "@UserGuid",
                    (object) CurrentUser.Instance.UserGUID,
                    (object) "@BankGL",
                    (object) this._bankAccount
                  };
                  object[] objArray2 = new object[objArray1.Length + args.Length];
                  objArray1.CopyTo((Array) objArray2, 0);
                  args.CopyTo((Array) objArray2, 6);
                  DefaultDatabase.ExecuteNonQuery(paymentProcedureName, objArray2);
                }
                else
                  DefaultDatabase.ExecuteNonQuery(paymentProcedureName, new object[6]
                  {
                    (object) "@ResPayId",
                    (object) (int) inNonGroupByRows[index].Cells["ResPayId"].Value,
                    (object) "@UserGuid",
                    (object) CurrentUser.Instance.UserGUID,
                    (object) "@BankGL",
                    (object) this._bankAccount
                  });
              }
              else if (args.Length != 0)
              {
                object[] objArray3 = new object[8]
                {
                  (object) "@ResPayId",
                  (object) (int) inNonGroupByRows[index].Cells["ResPayId"].Value,
                  (object) "@UserGuid",
                  (object) CurrentUser.Instance.UserGUID,
                  (object) "@BankGL",
                  (object) this._bankAccount,
                  (object) "@CreateCheck",
                  (object) 0
                };
                object[] objArray4 = new object[objArray3.Length + args.Length];
                objArray3.CopyTo((Array) objArray4, 0);
                args.CopyTo((Array) objArray4, 8);
                DefaultDatabase.ExecuteNonQuery(paymentProcedureName, objArray4);
              }
              else
                DefaultDatabase.ExecuteNonQuery(paymentProcedureName, new object[8]
                {
                  (object) "@ResPayId",
                  (object) (int) inNonGroupByRows[index].Cells["ResPayId"].Value,
                  (object) "@UserGuid",
                  (object) CurrentUser.Instance.UserGUID,
                  (object) "@BankGL",
                  (object) this._bankAccount,
                  (object) "@CreateCheck",
                  (object) 0
                });
            }
            else if (args.Length != 0)
            {
              object[] objArray5 = new object[6]
              {
                (object) "@ResPayId",
                (object) (int) inNonGroupByRows[index].Cells["ResPayId"].Value,
                (object) "@UserGuid",
                (object) CurrentUser.Instance.UserGUID,
                (object) "@BankGL",
                (object) this._bankAccount
              };
              object[] objArray6 = new object[objArray5.Length + args.Length];
              objArray5.CopyTo((Array) objArray6, 0);
              args.CopyTo((Array) objArray6, 6);
              DefaultDatabase.ExecuteNonQuery("spClaims_TransferRecoveryPayment", objArray6);
            }
            else
              DefaultDatabase.ExecuteNonQuery("spClaims_TransferRecoveryPayment", new object[6]
              {
                (object) "@ResPayId",
                (object) (int) inNonGroupByRows[index].Cells["ResPayId"].Value,
                (object) "@UserGuid",
                (object) CurrentUser.Instance.UserGUID,
                (object) "@BankGL",
                (object) this._bankAccount
              });
          }
        }
        e.Transaction.Commit();
      }));
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void GetBankAccounts()
  {
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable("spFin_GetBankAccounts", new object[2]
    {
      (object) "@GLCOMPANYID",
      (object) Utility.GetSetting("GLCO")
    }).Rows)
      (((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["BANKACCOUNTS"] as ComboBoxTool).ValueList.ValueListItems.Add(new ValueListItem(row["GlAcctId"])
      {
        DisplayText = row["BANKNAME"].ToString()
      });
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "TRANSFER":
        UltraToolbar toolbar = this.ultraToolbarsManager1.Toolbars[0];
        if (((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["BANKACCOUNTS"].SharedProps.Visible && (((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["BANKACCOUNTS"] as ComboBoxTool).Value == null)
        {
          int num = (int) MessageBox.Show(Resources.PAYMENTTRANSFER_BANKACCOUNTERROR, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        if (((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["BANKACCOUNTS"].SharedProps.Visible && (((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["BANKACCOUNTS"] as ComboBoxTool).Value != null)
          this._bankAccount = (int) (((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["BANKACCOUNTS"] as ComboBoxTool).Value;
        ((UltraGridBase) this.gridPayments).UpdateData();
        this.Transfer(string.Empty);
        this.DialogResult = DialogResult.OK;
        this.Close();
        break;
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
      case "Select All":
        this.ToggleCheckAll(true);
        break;
      case "De-Select All":
        this.ToggleCheckAll(false);
        break;
      case "CREATECHECKALL":
        this.ToggleCreateCheckAll(true);
        break;
      case "NOCREATECHECK":
        this.ToggleCreateCheckAll(false);
        break;
    }
  }

  protected virtual void ToggleCheckAll(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridPayments).Rows.GetFilteredInNonGroupByRows();
      if (inNonGroupByRows.Length == 0)
        return;
      for (int index = 0; index < inNonGroupByRows.Length; ++index)
      {
        inNonGroupByRows[index].Cells["SELECT"].Value = (object) value;
        inNonGroupByRows[index].Update();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void ToggleCreateCheckAll(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridPayments).Rows.GetFilteredInNonGroupByRows();
      if (inNonGroupByRows.Length == 0)
        return;
      for (int index = 0; index < inNonGroupByRows.Length; ++index)
      {
        inNonGroupByRows[index].Cells["CREATECHECK"].Value = (object) value;
        inNonGroupByRows[index].Update();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void FormPaymentTransfer_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Cursor = MgaCursors.Default;
    this.LoadPayments();
    this.GetBankAccounts();
    if (this.EntityInfoChanged == null)
      return;
    this.EntityInfoChanged((object) this, new EventArgs());
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  bool ISupportDocumentSystem.AllowAddNewDocument => true;

  event ISupportDocumentSystem.EntityInfoChangedEventHandler ISupportDocumentSystem.EntityInfoChanged
  {
    add => this.EntityInfoChanged += value;
    remove => this.EntityInfoChanged -= value;
  }

  bool IRecreatableEntity.CanReCreateEntity => false;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      return ((UltraGridBase) this.gridPayments).ActiveRow == null || !((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPayments).ActiveRow.Cells).Exists("ClaimantGuid") || ((UltraGridBase) this.gridPayments).ActiveRow.Cells["ClaimantGuid"].Value == DBNull.Value ? Guid.Empty : new Guid(((UltraGridBase) this.gridPayments).ActiveRow.Cells["ClaimantGuid"].Value.ToString());
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return ((UltraGridBase) this.gridPayments).ActiveRow == null ? string.Empty : ((UltraGridBase) this.gridPayments).ActiveRow.Cells["ClaimNumber"].Value.ToString();
    }
  }

  string IRecreatableEntity.FriendlyEntityName
  {
    get
    {
      return ((UltraGridBase) this.gridPayments).ActiveRow == null ? string.Empty : ((UltraGridBase) this.gridPayments).ActiveRow.Cells["ClaimNumber"].Value.ToString();
    }
  }

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid) => false;

  string IRecreatableEntity.RecreateTypeName => string.Empty;

  private void gridPayments_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (this.EntityInfoChanged == null)
      return;
    this.EntityInfoChanged((object) this, new EventArgs());
  }

  protected virtual void gridPayments_ClickCellButton(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "ClaimNumber"))
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      FormClaims form = ObjectFactory.Instance.CreateForm(typeof (FormClaims), new object[1]
      {
        (object) (Claim) ObjectFactory.Instance.CreateObject(typeof (Claim), new object[1]
        {
          (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select claimid from tblClaims_Reservepayments where respayid = @respayid", new object[2]
          {
            (object) "@respayid",
            e.Cell.Row.Cells["respayid"].Value
          })
        })
      }) as FormClaims;
      form.MdiParent = MDIControls.Instance.MDIParent;
      form.Show();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void FormPaymentTransfer_Activated(object sender, EventArgs e)
  {
  }

  private void gridPayments_CellChange(object sender, CellEventArgs e)
  {
    ((UltraGridBase) this.gridPayments).UpdateData();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Payments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPayId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Payee Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClaimNumber");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ResPayTypeDescription");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPayAmount");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("SELECT", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CREATECHECK", 1);
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("TRANSFER");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("Select All");
    ButtonTool buttonTool4 = new ButtonTool("De-Select All");
    ComboBoxTool comboBoxTool1 = new ComboBoxTool("BANKACCOUNTS");
    ButtonTool buttonTool5 = new ButtonTool("CREATECHECKALL");
    ButtonTool buttonTool6 = new ButtonTool("NOCREATECHECK");
    ButtonTool buttonTool7 = new ButtonTool("TRANSFER");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("CANCEL");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("Select All");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("De-Select All");
    Appearance appearance18 = new Appearance();
    ComboBoxTool comboBoxTool2 = new ComboBoxTool("BANKACCOUNTS");
    ValueList valueList1 = new ValueList(0);
    ComboBoxTool comboBoxTool3 = new ComboBoxTool("ComboBoxTool1");
    ValueList valueList2 = new ValueList(0);
    ButtonTool buttonTool11 = new ButtonTool("CREATECHECKALL");
    Appearance appearance19 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormPaymentTransfer));
    ButtonTool buttonTool12 = new ButtonTool("NOCREATECHECK");
    Appearance appearance20 = new Appearance();
    this.FormBackground_Fill_Panel = new Panel();
    this.gridPayments = new UltraGrid();
    this.dsPaymentTransferBindingSource = new BindingSource(this.components);
    this.dsPaymentTransfer = new dsPaymentTransfer();
    this._FormBackground_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormBackground_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dsGetBankAccountsDropDown1 = new dsGetBankAccountsDropDown();
    this.FormBackground_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.gridPayments).BeginInit();
    ((ISupportInitialize) this.dsPaymentTransferBindingSource).BeginInit();
    this.dsPaymentTransfer.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.dsGetBankAccountsDropDown1.BeginInit();
    this.SuspendLayout();
    this.FormBackground_Fill_Panel.BackColor = Color.Transparent;
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.gridPayments);
    this.FormBackground_Fill_Panel.Cursor = Cursors.Default;
    this.FormBackground_Fill_Panel.Dock = DockStyle.Fill;
    this.FormBackground_Fill_Panel.Location = new Point(0, 47);
    this.FormBackground_Fill_Panel.Name = "FormBackground_Fill_Panel";
    this.FormBackground_Fill_Panel.Size = new Size(1036, 540);
    this.FormBackground_Fill_Panel.TabIndex = 0;
    ((UltraGridBase) this.gridPayments).DataMember = "Payments";
    ((UltraGridBase) this.gridPayments).DataSource = (object) this.dsPaymentTransferBindingSource;
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPayments).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 47;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 65;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 92;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 124;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).Image = (object) Resources.information;
    ultraGridColumn5.CellButtonAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Style = (ColumnStyle) 2;
    ultraGridColumn5.Width = 106;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Width = 107;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Payment Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 7;
    ultraGridColumn7.Width = 156;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 8;
    ultraGridColumn8.Width = 168;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 9;
    ultraGridColumn9.Width = 115;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 199;
    ultraGridColumn11.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.DataType = typeof (bool);
    ultraGridColumn11.DefaultCellValue = (object) true;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 0;
    ultraGridColumn11.Style = (ColumnStyle) 3;
    ultraGridColumn11.Width = 17;
    ultraGridColumn12.DataType = typeof (bool);
    ultraGridColumn12.DefaultCellValue = (object) true;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Create Check?";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 11;
    ultraGridColumn12.Style = (ColumnStyle) 3;
    ultraGridColumn12.Width = 84;
    ultraGridBand.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.gridPayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance13).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridPayments).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridPayments).Dock = DockStyle.Fill;
    ((Control) this.gridPayments).Location = new Point(0, 0);
    ((Control) this.gridPayments).Name = "gridPayments";
    ((Control) this.gridPayments).Size = new Size(1036, 540);
    ((Control) this.gridPayments).TabIndex = 1;
    this.gridPayments.UpdateMode = (UpdateMode) 4;
    ((UltraControlBase) this.gridPayments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPayments).UseOsThemes = (DefaultableBoolean) 2;
    this.gridPayments.CellChange += new CellEventHandler(this.gridPayments_CellChange);
    this.gridPayments.ClickCellButton += new CellEventHandler(this.gridPayments_ClickCellButton);
    this.gridPayments.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridPayments_AfterSelectChange);
    this.dsPaymentTransferBindingSource.DataSource = (object) this.dsPaymentTransfer;
    this.dsPaymentTransferBindingSource.Position = 0;
    this.dsPaymentTransfer.DataSetName = "dsPaymentTransfer";
    this.dsPaymentTransfer.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormBackground_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Location = new Point(0, 47);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Name = "_FormBackground_Toolbars_Dock_Area_Left";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Size = new Size(0, 540);
    this._FormBackground_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) comboBoxTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) comboBoxTool1,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance15).Image = (object) Resources.Transfer;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Transfer";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance16).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance17).Image = (object) Resources.SelectAll;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Select All";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance18).Image = (object) Resources.DeSelectAll;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "De-Select All";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    comboBoxTool2.AutoComplete = true;
    ((ToolPropsBase) ((ToolBase) comboBoxTool2).SharedPropsInternal).Caption = "Bank Account";
    ((ToolPropsBase) ((ToolBase) comboBoxTool2).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) comboBoxTool2).SharedPropsInternal).Width = 300;
    valueList1.DisplayStyle = (ValueListDisplayStyle) 3;
    valueList1.DropDownListMinWidth = 350;
    valueList1.DropDownListWidth = 500;
    comboBoxTool2.ValueList = valueList1;
    ((ToolPropsBase) ((ToolBase) comboBoxTool3).SharedPropsInternal).Caption = "ComboBoxTool1";
    comboBoxTool3.ValueList = valueList2;
    ((AppearanceBase) appearance19).Image = componentResourceManager.GetObject("appearance19.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Create Check (ALL)";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance20).Image = componentResourceManager.GetObject("appearance20.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Create Check (None)";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) comboBoxTool2,
      (ToolBase) comboBoxTool3,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormBackground_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Location = new Point(1036, 47);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Name = "_FormBackground_Toolbars_Dock_Area_Right";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Size = new Size(0, 540);
    this._FormBackground_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormBackground_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Name = "_FormBackground_Toolbars_Dock_Area_Top";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Size = new Size(1036, 47);
    this._FormBackground_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormBackground_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Location = new Point(0, 587);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Name = "_FormBackground_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Size = new Size(1036, 0);
    this._FormBackground_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.dsGetBankAccountsDropDown1.DataSetName = "dsGetBankAccountsDropDown";
    this.dsGetBankAccountsDropDown1.Locale = new CultureInfo("en-US");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1036, 587);
    this.Controls.Add((Control) this.FormBackground_Fill_Panel);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormPaymentTransfer);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims Payment Transfer";
    this.Activated += new EventHandler(this.FormPaymentTransfer_Activated);
    this.Load += new EventHandler(this.FormPaymentTransfer_Load);
    this.FormBackground_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.gridPayments).EndInit();
    ((ISupportInitialize) this.dsPaymentTransferBindingSource).EndInit();
    this.dsPaymentTransfer.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.dsGetBankAccountsDropDown1.EndInit();
    this.ResumeLayout(false);
  }
}
