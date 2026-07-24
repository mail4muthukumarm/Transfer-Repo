// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.MultipleExtendedTreeViewDropDown
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinToolTip;
using Infragistics.Win.UltraWinTree;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class MultipleExtendedTreeViewDropDown : ExtendedTreeViewDropDown
{
  private IContainer components;
  private formGLAccountSelection formGLSelection;
  private ArrayList LstSelectedAccounts;
  private int GlCompanyID;
  private bool DoAddAccountToTree;
  private ExtendedTreeViewDropDown.Assets _showAR;
  private ExtendedTreeViewDropDown.Liabilities _showAP;
  private bool _showExpense;

  protected override void Dispose(bool disposing)
  {
    if (this.formGLSelection != null)
      this.formGLSelection.Dispose();
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGAButton btnSelect
  {
    get => this._btnSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      MGAButton btnSelect1 = this._btnSelect;
      if (btnSelect1 != null)
        ((Control) btnSelect1).Click -= eventHandler;
      this._btnSelect = value;
      MGAButton btnSelect2 = this._btnSelect;
      if (btnSelect2 == null)
        return;
      ((Control) btnSelect2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonClear
  {
    get => this._buttonClear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonClear_Click);
      MGAButton buttonClear1 = this._buttonClear;
      if (buttonClear1 != null)
        ((Control) buttonClear1).Click -= eventHandler;
      this._buttonClear = value;
      MGAButton buttonClear2 = this._buttonClear;
      if (buttonClear2 == null)
        return;
      ((Control) buttonClear2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraToolTipManager1")]
  internal virtual UltraToolTipManager UltraToolTipManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraTreeColumnSet ultraTreeColumnSet1 = new UltraTreeColumnSet();
    ResourceManager resourceManager = new ResourceManager(typeof (MultipleExtendedTreeViewDropDown));
    UltraTreeColumnSet ultraTreeColumnSet2 = new UltraTreeColumnSet();
    Appearance appearance1 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo1 = new UltraToolTipInfo("Click here to specify mutilple GL Accounts.", (ToolTipImage) 3, "Mutilple GL Account Selection", (DefaultableBoolean) 0);
    Appearance appearance2 = new Appearance();
    UltraToolTipInfo ultraToolTipInfo2 = new UltraToolTipInfo("Click here to clear the selected GL account(s).", (ToolTipImage) 0, "Clear Selected GL Account(s)", (DefaultableBoolean) 0);
    this.btnSelect = new MGAButton();
    this.buttonClear = new MGAButton();
    this.UltraToolTipManager1 = new UltraToolTipManager(this.components);
    ((ISupportInitialize) this.TreeView).BeginInit();
    ((ISupportInitialize) this.Display).BeginInit();
    ((ISupportInitialize) this.DropTree).BeginInit();
    ((ISupportInitialize) this.btnSelect).BeginInit();
    ((ISupportInitialize) this.buttonClear).BeginInit();
    this.SuspendLayout();
    this.TreeView.ColumnSettings.RootColumnSet = ultraTreeColumnSet1;
    ((Control) this.TreeView).Name = "TreeView";
    ((Control) this.Display).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.Display).Name = "Display";
    ((Control) this.Display).Size = new Size(183, 18);
    this.TreeContainer.PopupControl = (Control) this.DropTree;
    this.GLAccountImages.ImageStream = (ImageListStreamer) resourceManager.GetObject("GLAccountImages.ImageStream");
    ((Control) this.DropDownButton).Anchor = AnchorStyles.Top | AnchorStyles.Left;
    ((Control) this.DropDownButton).Name = "DropDownButton";
    ((Control) this.DropDownButton).Size = new Size(205, 20);
    this.DropTree.ColumnSettings.RootColumnSet = ultraTreeColumnSet2;
    ((Control) this.DropTree).Name = "DropTree";
    ((Control) this.DropTree).Visible = false;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelect).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSelect).Location = new Point(205, 0);
    ((Control) this.btnSelect).Name = "btnSelect";
    ((Control) this.btnSelect).Size = new Size(27, 20);
    ((Control) this.btnSelect).TabIndex = 7;
    ultraToolTipInfo1.ToolTipImage = (ToolTipImage) 3;
    ultraToolTipInfo1.ToolTipText = "Click here to specify mutilple GL Accounts.";
    ultraToolTipInfo1.ToolTipTitle = "Mutilple GL Account Selection";
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.btnSelect, ultraToolTipInfo1);
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClear).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonClear).Location = new Point(232, 0);
    ((Control) this.buttonClear).Name = "buttonClear";
    ((Control) this.buttonClear).Size = new Size(27, 20);
    ((Control) this.buttonClear).TabIndex = 8;
    ultraToolTipInfo2.ToolTipText = "Click here to clear the selected GL account(s).";
    ultraToolTipInfo2.ToolTipTitle = "Clear Selected GL Account(s)";
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.buttonClear, ultraToolTipInfo2);
    this.Controls.Add((Control) this.buttonClear);
    this.Controls.Add((Control) this.btnSelect);
    this.Name = nameof (MultipleExtendedTreeViewDropDown);
    this.Size = new Size(260, 20);
    this.Controls.SetChildIndex((Control) this.btnSelect, 0);
    this.Controls.SetChildIndex((Control) this.TreeView, 0);
    this.Controls.SetChildIndex((Control) this.DropDownButton, 0);
    this.Controls.SetChildIndex((Control) this.Display, 0);
    this.Controls.SetChildIndex((Control) this.buttonClear, 0);
    ((ISupportInitialize) this.TreeView).EndInit();
    ((ISupportInitialize) this.Display).EndInit();
    ((ISupportInitialize) this.DropTree).EndInit();
    ((ISupportInitialize) this.btnSelect).EndInit();
    ((ISupportInitialize) this.buttonClear).EndInit();
    this.ResumeLayout(false);
  }

  public MultipleExtendedTreeViewDropDown()
  {
    this.AfterSelect += new ExtendedTreeViewDropDown.AfterSelectDelegate(this.ExtendedTreeView_AfterSelect);
    this.DoAddAccountToTree = false;
    this._showAR = ExtendedTreeViewDropDown.Assets.None;
    this._showAP = ExtendedTreeViewDropDown.Liabilities.None;
    this.InitializeComponent();
    this.GlCompanyID = -1;
  }

  public ArrayList SelectedGLAccounts => this.LstSelectedAccounts;

  public string SelectedGLAccountsAsString
  {
    get
    {
      string empty;
      if (this.LstSelectedAccounts == null || this.LstSelectedAccounts.Count == 0)
      {
        empty = string.Empty;
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        int num = this.LstSelectedAccounts.Count - 1;
        int index;
        for (index = 0; index <= num; ++index)
        {
          if (index != this.LstSelectedAccounts.Count - 1)
            stringBuilder.Append(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(this.LstSelectedAccounts[index], (object) ","));
        }
        stringBuilder.Append(RuntimeHelpers.GetObjectValue(this.LstSelectedAccounts[index - 1]));
        empty = stringBuilder.ToString();
      }
      return empty;
    }
    set
    {
      string[] strArray1 = Strings.Split(value, ",");
      if (this.LstSelectedAccounts == null)
        this.LstSelectedAccounts = new ArrayList();
      string[] strArray2 = strArray1;
      int index = 0;
      while (index < strArray2.Length)
      {
        string s = strArray2[index];
        if (!s.Equals(string.Empty))
        {
          int num = int.Parse(s);
          if (!this.LstSelectedAccounts.Contains((object) num))
            this.LstSelectedAccounts.Add((object) num);
        }
        checked { ++index; }
      }
      if (this.LstSelectedAccounts.Count == 1)
        ((TextEditorControlBase) this.Display).Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 fullname from tblfin_glaccounts where glacctid = @acctid", new object[2]
        {
          (object) "@acctid",
          this.LstSelectedAccounts[0]
        })));
      if (this.LstSelectedAccounts.Count <= 1)
        return;
      ((TextEditorControlBase) this.Display).Text = "Multiple...";
    }
  }

  public new void LoadGLAccounts(int Glcompany)
  {
    this.GlCompanyID = Glcompany;
    base.LoadGLAccounts(Glcompany);
  }

  private void ExtendedTreeView_AfterSelect(object sender, ExtendedDropTree_EventArgs e)
  {
    this.LstSelectedAccounts = new ArrayList();
    this.LstSelectedAccounts.Add((object) e.SelectedValue);
    ((TextEditorControlBase) this.Display).Text = e.SelectedText;
    this.DoAddAccountToTree = true;
    this.formGLSelection = (formGLAccountSelection) null;
  }

  [Browsable(true)]
  [DefaultValue(typeof (ExtendedTreeViewDropDown.Assets), "None")]
  [Description("Gets/Sets whether the drop tree will show accounts payable accounts")]
  public override ExtendedTreeViewDropDown.Assets ShowAssetAccounts
  {
    get => base.ShowAssetAccounts;
    set => base.ShowAssetAccounts = value;
  }

  [Browsable(true)]
  [DefaultValue(typeof (ExtendedTreeViewDropDown.Liabilities), "None")]
  [Description("Gets/Sets whether the drop tree will show accounts receivable accounts")]
  public override ExtendedTreeViewDropDown.Liabilities ShowLiabilityAccounts
  {
    get => base.ShowLiabilityAccounts;
    set => base.ShowLiabilityAccounts = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show expense accounts")]
  public override bool ShowExpenseAccounts
  {
    get => base.ShowExpenseAccounts;
    set => base.ShowExpenseAccounts = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show equity accounts")]
  public override bool ShowEquityAccounts
  {
    get => base.ShowEquityAccounts;
    set => base.ShowEquityAccounts = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show income accounts")]
  public override bool ShowIncomeAccounts
  {
    get => base.ShowIncomeAccounts;
    set => base.ShowIncomeAccounts = value;
  }

  [Browsable(true)]
  [Description("This will determine whether system defined accounts are shown to the user.")]
  [DefaultValue(false)]
  public override bool ShowSystemDefinedAccounts
  {
    get => base.ShowSystemDefinedAccounts;
    set => base.ShowSystemDefinedAccounts = value;
  }

  [Browsable(true)]
  [DefaultValue(200)]
  [Description("Set the drop down width of the control")]
  public override int DropDownWidth
  {
    get => base.DropDownWidth;
    set => base.DropDownWidth = value;
  }

  [Browsable(true)]
  [DefaultValue(200)]
  [Description("Set the drop down height of the control")]
  public override int DropDownHeight
  {
    get => base.DropDownHeight;
    set => base.DropDownHeight = value;
  }

  private void buttonClear_Click(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.Display).Text = string.Empty;
    if (this.LstSelectedAccounts != null)
      this.LstSelectedAccounts.Clear();
    if (this.formGLSelection != null)
    {
      this.Cursor = Cursors.WaitCursor;
      this.formGLSelection.ResetTreesToOrginalState();
      this.Cursor = Cursors.Default;
    }
    this.DoAddAccountToTree = false;
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    if (this.formGLSelection == null)
    {
      if (this.DoAddAccountToTree)
      {
        this.formGLSelection = new formGLAccountSelection(this.DropTree, this.GlCompanyID, int.Parse(this.LstSelectedAccounts[0].ToString()));
        this.DoAddAccountToTree = false;
      }
      else
        this.formGLSelection = new formGLAccountSelection(this.DropTree, this.GlCompanyID);
    }
    if (this.LstSelectedAccounts != null && this.LstSelectedAccounts.Count > 0)
      this.formGLSelection.PreSelectAccounts(this.LstSelectedAccounts);
    int num = (int) this.formGLSelection.ShowDialog();
    if (this.formGLSelection.DialogResult != DialogResult.OK)
      return;
    this.LstSelectedAccounts = this.formGLSelection.SelectedGLAccounts;
    if (this.LstSelectedAccounts.Count == 0)
      return;
    if (this.LstSelectedAccounts.Count == 1)
      ((TextEditorControlBase) this.Display).Text = this.formGLSelection.GLAccountName;
    else
      ((TextEditorControlBase) this.Display).Text = "Multiple...";
  }
}
