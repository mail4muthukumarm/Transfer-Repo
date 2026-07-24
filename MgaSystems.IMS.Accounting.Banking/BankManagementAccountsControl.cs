// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankManagementAccountsControl
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[DesignerGenerated]
public class BankManagementAccountsControl : UserControl
{
  private IContainer components;
  private int _glCompanyId;
  private int _selectedBankGLAccountId;
  private int _selectedAccountIndex;

  public BankManagementAccountsControl()
  {
    this.Load += new EventHandler(this.BankManagementAccountsControl_Load);
    this._selectedAccountIndex = -1;
    this.InitializeComponent();
  }

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
    this.components = (IContainer) new System.ComponentModel.Container();
    this.panelBankAccounts = new Panel();
    this.UltraFlowLayoutManager1 = new UltraFlowLayoutManager(this.components);
    ((ISupportInitialize) this.UltraFlowLayoutManager1).BeginInit();
    this.SuspendLayout();
    this.panelBankAccounts.Dock = DockStyle.Fill;
    this.panelBankAccounts.Location = new Point(0, 0);
    this.panelBankAccounts.Name = "panelBankAccounts";
    this.panelBankAccounts.Size = new Size(443, 153);
    this.panelBankAccounts.TabIndex = 0;
    ((ControlLayoutManagerBase) this.UltraFlowLayoutManager1).ContainerControl = (Control) this.panelBankAccounts;
    this.UltraFlowLayoutManager1.HorizontalAlignment = (DefaultableFlowLayoutAlignment) 1;
    this.UltraFlowLayoutManager1.WrapItems = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(220, 230, 250);
    this.Controls.Add((Control) this.panelBankAccounts);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (BankManagementAccountsControl);
    this.Size = new Size(443, 153);
    ((ISupportInitialize) this.UltraFlowLayoutManager1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("panelBankAccounts")]
  internal virtual Panel panelBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraFlowLayoutManager1")]
  internal virtual UltraFlowLayoutManager UltraFlowLayoutManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [Browsable(true)]
  public event BankManagementAccountsControl.SelectedAccountChangedEventHandler SelectedAccountChanged;

  public int GLAccountId => this._glCompanyId;

  public int SelectedBankGLAccountId => this._selectedBankGLAccountId;

  public void LoadBankAccounts(int glCompanyId)
  {
    this._glCompanyId = glCompanyId;
    this.panelBankAccounts.Controls.Clear();
    int index = 0;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetBankAccounts_Viewer", new object[2]
    {
      (object) "@glcompanyid",
      (object) this._glCompanyId
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        BankManagementAccount managementAccount = new BankManagementAccount(Conversions.ToInteger(row["GLACCTID"]), row["BankName"].ToString(), row["BankAccountNumber"].ToString(), row["GLAccountName"].ToString(), row["GLAccountShortName"].ToString(), index);
        managementAccount.DisplayBankInformation();
        managementAccount.ControlSelected += new BankManagementAccount.ControlSelectedEventHandler(this.BankAccountSelected);
        this.panelBankAccounts.Controls.Add((Control) managementAccount);
        ++index;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.panelBankAccounts.AutoScroll = true;
    this.UltraFlowLayoutManager1.Orientation = Orientation.Horizontal;
    this.UnselectCurrentAccount();
    if (this.panelBankAccounts.Controls.Count == 0)
      return;
    ((BankManagementAccount) this.panelBankAccounts.Controls[0]).Selected = true;
  }

  private void UnselectCurrentAccount()
  {
    if (this._selectedAccountIndex == -1 || this.panelBankAccounts.Controls.Count == 0)
      return;
    if (this.panelBankAccounts.Controls.Count >= this._selectedAccountIndex)
      this._selectedAccountIndex = 0;
    ((BankManagementAccount) this.panelBankAccounts.Controls[this._selectedAccountIndex]).Selected = false;
  }

  private void BankManagementAccountsControl_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.panelBankAccounts.AutoScroll = true;
    this.panelBankAccounts.VerticalScroll.Visible = false;
  }

  private void BankAccountSelected(ref BankManagementAccount sender)
  {
    this.UnselectCurrentAccount();
    this._selectedAccountIndex = sender.Index;
    this._selectedBankGLAccountId = sender.GLAccountId;
    // ISSUE: reference to a compiler-generated field
    BankManagementAccountsControl.SelectedAccountChangedEventHandler accountChangedEvent = this.SelectedAccountChangedEvent;
    if (accountChangedEvent == null)
      return;
    accountChangedEvent();
  }

  public delegate void SelectedAccountChangedEventHandler();
}
