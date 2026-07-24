// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Controls.UC_BankAccounts
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Controls;

public class UC_BankAccounts : UserControl
{
  private IContainer components;
  private MGASimpleComboBox comboBankAccounts;
  private Label label1;

  [Browsable(false)]
  public int SelectedBankGLAccountId
  {
    get
    {
      int selectedBankGlAccountId = -1;
      if (((UltraDropDownBase) this.comboBankAccounts).SelectedRow != null)
        selectedBankGlAccountId = (int) ((UltraDropDownBase) this.comboBankAccounts).SelectedRow.Cells["GLACCTID"].Value;
      return selectedBankGlAccountId;
    }
  }

  [Browsable(true)]
  public int ComboBoxWidth
  {
    set => ((Control) this.comboBankAccounts).Width = value;
    get => ((Control) this.comboBankAccounts).Width;
  }

  public UC_BankAccounts() => this.InitializeComponent();

  public void LoadBankAccounts(int glCompanyId)
  {
    ((UltraGridBase) this.comboBankAccounts).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetBankAccounts", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    });
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "glacctid";
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "bankname";
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.comboBankAccounts = new MGASimpleComboBox();
    this.label1 = new Label();
    ((ISupportInitialize) this.comboBankAccounts).BeginInit();
    this.SuspendLayout();
    ((Control) this.comboBankAccounts).Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.comboBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    this.comboBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccounts).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboBankAccounts).Location = new Point(6, 17);
    this.comboBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccounts).Name = "comboBankAccounts";
    ((Control) this.comboBankAccounts).Size = new Size(284, 21);
    ((Control) this.comboBankAccounts).TabIndex = 3;
    ((UltraControlBase) this.comboBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccounts).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f);
    this.label1.Location = new Point(3, 2);
    this.label1.Name = "label1";
    this.label1.Size = new Size(76, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Bank Account:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.comboBankAccounts);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (UC_BankAccounts);
    this.Size = new Size(293, 48 /*0x30*/);
    ((ISupportInitialize) this.comboBankAccounts).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
