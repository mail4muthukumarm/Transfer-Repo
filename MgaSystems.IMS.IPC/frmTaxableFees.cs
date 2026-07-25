// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmTaxableFees
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class frmTaxableFees : Form
{
  private IContainer components;
  private readonly string _stateID;
  private readonly int _companyFeeID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lstStates")]
  internal virtual CheckedListBox lstStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelect
  {
    get => this._lnkDeSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelect_LinkClicked);
      LinkLabel lnkDeSelect1 = this._lnkDeSelect;
      if (lnkDeSelect1 != null)
        lnkDeSelect1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelect = value;
      LinkLabel lnkDeSelect2 = this._lnkDeSelect;
      if (lnkDeSelect2 == null)
        return;
      lnkDeSelect2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.lstStates = new CheckedListBox();
    this.lnkSelectAll = new LinkLabel();
    this.btnSave = new MGAButton();
    this.lnkDeSelect = new LinkLabel();
    this.Label1 = new Label();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    this.lstStates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstStates.BorderStyle = BorderStyle.None;
    this.lstStates.ForeColor = Color.Black;
    this.lstStates.Location = new Point(11, 32 /*0x20*/);
    this.lstStates.Name = "lstStates";
    this.lstStates.Size = new Size(309, 320);
    this.lstStates.TabIndex = 0;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.Location = new Point(8, 376);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(100, 23);
    this.lnkSelectAll.TabIndex = 1;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All States";
    this.lnkSelectAll.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnSave).Location = new Point(224 /*0xE0*/, 392);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnSave).TabIndex = 2;
    ((ControlBase) this.btnSave).Text = "&Save && Close";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkDeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelect.Location = new Point(8, 400);
    this.lnkDeSelect.Name = "lnkDeSelect";
    this.lnkDeSelect.Size = new Size(100, 23);
    this.lnkDeSelect.TabIndex = 3;
    this.lnkDeSelect.TabStop = true;
    this.lnkDeSelect.Text = "De-select All States";
    this.lnkDeSelect.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(235, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Please select which states this fee is taxable in:";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(328, 430);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkDeSelect);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lstStates);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmTaxableFees);
    this.Text = "Taxable Fees Administration";
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmTaxableFees(int companyFeeID, string stateID)
    : this(companyFeeID)
  {
    this._stateID = stateID;
  }

  public frmTaxableFees(int companyFeeID)
  {
    this.Load += new EventHandler(this.frmTaxableFees_Load);
    this._stateID = string.Empty;
    this.InitializeComponent();
    this._companyFeeID = companyFeeID;
  }

  private void frmTaxableFees_Load(object sender, EventArgs e)
  {
    DataTable dataTable1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._stateID, string.Empty, false) != 0)
      dataTable1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, State FROM lstStates WHERE StateID = @StateID ORDER By State", new object[2]
      {
        (object) "@StateID",
        (object) this._stateID
      });
    else
      dataTable1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, State FROM lstStates ORDER By State");
    CheckedListBox lstStates = this.lstStates;
    lstStates.DataSource = (object) dataTable1;
    lstStates.DisplayMember = "State";
    lstStates.ValueMember = "StateID";
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyFeeID, StateID FROM tblTaxableFees WHERE CompanyFeeID=@CFID", new object[2]
    {
      (object) "@CFID",
      (object) this._companyFeeID
    });
    try
    {
      foreach (DataRow row in dataTable2.Rows)
      {
        int num = this.lstStates.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((DataRowView) this.lstStates.Items[index]).Row["StateID"].ToString(), row["StateID"].ToString(), false) == 0)
            this.lstStates.SetItemChecked(index, true);
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

  private void btnSave_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblTaxableFees WHERE CompanyFeeID=@CFID", new object[2]
      {
        (object) "@CFID",
        (object) this._companyFeeID
      });
      if (this.lstStates.CheckedItems.Count > 0)
      {
        string str = "INSERT INTO tblTaxableFees(CompanyFeeID, StateID) SELECT @CompanyFeeID, @StateID";
        int num = this.lstStates.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (this.lstStates.GetItemChecked(index))
          {
            DataRow row = ((DataRowView) this.lstStates.Items[index]).Row;
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, str, new object[4]
            {
              (object) "@CompanyFeeID",
              (object) this._companyFeeID,
              (object) "@StateID",
              row["StateID"]
            });
          }
        }
      }
      args.Transaction.Commit();
    }));
    this.Close();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = this.lstStates.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstStates.SetItemChecked(index, true);
  }

  private void lnkDeSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = this.lstStates.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstStates.SetItemChecked(index, false);
  }
}
