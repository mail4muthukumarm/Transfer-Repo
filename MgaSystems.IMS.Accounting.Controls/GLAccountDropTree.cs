// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.GLAccountDropTree
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

[DesignerGenerated]
public class GLAccountDropTree : UserControl
{
  private IContainer components;
  private GLAccountDropTree.Assets _showAR;
  private GLAccountDropTree.Liabilities _showAP;
  private bool _showExpense;
  private bool _showEquity;
  private bool _showIncome;
  private bool _ShowSystemDefinedAccounts;
  private int _dropDownWidth;
  private int _dropDownHeight;

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraTreeColumnSet ultraTreeColumnSet1 = new UltraTreeColumnSet();
    UltraTreeNodeColumn ultraTreeNodeColumn1 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn2 = new UltraTreeNodeColumn();
    Appearance appearance3 = new Appearance();
    UltraTreeNodeColumn ultraTreeNodeColumn3 = new UltraTreeNodeColumn();
    UltraTreeColumnSet ultraTreeColumnSet2 = new UltraTreeColumnSet();
    UltraTreeNodeColumn ultraTreeNodeColumn4 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn5 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn6 = new UltraTreeNodeColumn();
    Appearance appearance4 = new Appearance();
    UltraTreeNodeColumn ultraTreeNodeColumn7 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn8 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn9 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn10 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn11 = new UltraTreeNodeColumn();
    UltraTreeColumnSet ultraTreeColumnSet3 = new UltraTreeColumnSet();
    UltraTreeNodeColumn ultraTreeNodeColumn12 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn13 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn14 = new UltraTreeNodeColumn();
    Appearance appearance5 = new Appearance();
    UltraTreeNodeColumn ultraTreeNodeColumn15 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn16 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn17 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn18 = new UltraTreeNodeColumn();
    UltraTreeNodeColumn ultraTreeNodeColumn19 = new UltraTreeNodeColumn();
    Override @override = new Override();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GLAccountDropTree));
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.TreeView = new UltraTree();
    this.GLAccountImages = new ImageList(this.components);
    this.TreeContainer = new UltraPopupControlContainer(this.components);
    this.buttonDropDown = new UltraDropDownButton();
    this.txtDisplay = new MGATextBox();
    this.buttonDropDown_Hidden = new UltraDropDownButton();
    this.DsGLAccounts2 = new dsGLAccounts();
    ((ISupportInitialize) this.TreeView).BeginInit();
    ((ISupportInitialize) this.txtDisplay).BeginInit();
    this.DsGLAccounts2.BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.TreeView.Appearance = (AppearanceBase) appearance1;
    this.TreeView.ColumnSettings.AllowCellEdit = (AllowCellEdit) 1;
    this.TreeView.ColumnSettings.AllowCellSizing = (LayoutSizing) 1;
    this.TreeView.ColumnSettings.AllowCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    this.TreeView.ColumnSettings.AllowColMoving = (GridBagLayoutAllowMoving) 1;
    this.TreeView.ColumnSettings.AllowLabelSizing = (LayoutSizing) 1;
    this.TreeView.ColumnSettings.AllowLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    this.TreeView.ColumnSettings.AutoFitColumns = (AutoFitColumns) 1;
    appearance2.BorderColor = Color.White;
    this.TreeView.ColumnSettings.CellAppearance = (AppearanceBase) appearance2;
    ultraTreeNodeColumn1.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn1).Key = "GLCompanyClassID";
    ultraTreeNodeColumn1.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn1.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn1.Visible = false;
    appearance3.Image = (object) 2;
    ultraTreeNodeColumn2.CellAppearance = (AppearanceBase) appearance3;
    ultraTreeNodeColumn2.DataType = typeof (string);
    ((KeyedSubObjectBase) ultraTreeNodeColumn2).Key = "ClassFullName";
    ultraTreeNodeColumn2.LayoutInfo.PreferredCellSize = new Size(114, 19);
    ultraTreeNodeColumn2.LayoutInfo.PreferredLabelSize = new Size(114, 23);
    ultraTreeNodeColumn2.LayoutInfo.SpanX = 4;
    ultraTreeNodeColumn2.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn3.DataType = typeof (IBindingList);
    ultraTreeNodeColumn3.IsChaptered = true;
    ((KeyedSubObjectBase) ultraTreeNodeColumn3).Key = "AccountClassifications_GLAccounts";
    ultraTreeNodeColumn3.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn3.LayoutInfo.SpanY = 2;
    ultraTreeColumnSet1.Columns.Add(ultraTreeNodeColumn1);
    ultraTreeColumnSet1.Columns.Add(ultraTreeNodeColumn2);
    ultraTreeColumnSet1.Columns.Add(ultraTreeNodeColumn3);
    ultraTreeColumnSet1.IsAutoGenerated = true;
    ((KeyedSubObjectBase) ultraTreeColumnSet1).Key = "AccountClassifications";
    ultraTreeNodeColumn4.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn4).Key = "GLCompanyClassID";
    ultraTreeNodeColumn4.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn4.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn4.Visible = false;
    ultraTreeNodeColumn5.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn5).Key = "GLAcctID";
    ultraTreeNodeColumn5.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn5.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn5.Visible = false;
    appearance4.Image = (object) 1;
    ultraTreeNodeColumn6.CellAppearance = (AppearanceBase) appearance4;
    ultraTreeNodeColumn6.DataType = typeof (string);
    ((KeyedSubObjectBase) ultraTreeNodeColumn6).Key = "FullName";
    ultraTreeNodeColumn6.LayoutInfo.PreferredCellSize = new Size(206, 19);
    ultraTreeNodeColumn6.LayoutInfo.PreferredLabelSize = new Size(206, 23);
    ultraTreeNodeColumn6.LayoutInfo.SpanX = 4;
    ultraTreeNodeColumn6.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn7.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn7).Key = "RollUpTo";
    ultraTreeNodeColumn7.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn7.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn7.Visible = false;
    ultraTreeNodeColumn8.DataType = typeof (bool);
    ((KeyedSubObjectBase) ultraTreeNodeColumn8).Key = "ControlAcct";
    ultraTreeNodeColumn8.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn8.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn8.Visible = false;
    ultraTreeNodeColumn9.DataType = typeof (bool);
    ((KeyedSubObjectBase) ultraTreeNodeColumn9).Key = "SystemDefined";
    ultraTreeNodeColumn9.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn9.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn9.Visible = false;
    ultraTreeNodeColumn10.DataType = typeof (string);
    ((KeyedSubObjectBase) ultraTreeNodeColumn10).Key = "ShortName";
    ultraTreeNodeColumn10.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn10.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn10.Visible = false;
    ultraTreeNodeColumn11.DataType = typeof (IBindingList);
    ultraTreeNodeColumn11.IsChaptered = true;
    ((KeyedSubObjectBase) ultraTreeNodeColumn11).Key = "GLAccounts_GLAccounts";
    ultraTreeNodeColumn11.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn11.LayoutInfo.SpanY = 2;
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn4);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn5);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn6);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn7);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn8);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn9);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn10);
    ultraTreeColumnSet2.Columns.Add(ultraTreeNodeColumn11);
    ultraTreeColumnSet2.IsAutoGenerated = true;
    ((KeyedSubObjectBase) ultraTreeColumnSet2).Key = "AccountClassifications_GLAccounts";
    ultraTreeNodeColumn12.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn12).Key = "GLCompanyClassID";
    ultraTreeNodeColumn12.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn12.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn12.Visible = false;
    ultraTreeNodeColumn13.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn13).Key = "GLAcctID";
    ultraTreeNodeColumn13.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn13.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn13.Visible = false;
    appearance5.Image = (object) 0;
    ultraTreeNodeColumn14.CellAppearance = (AppearanceBase) appearance5;
    ultraTreeNodeColumn14.DataType = typeof (string);
    ((KeyedSubObjectBase) ultraTreeNodeColumn14).Key = "FullName";
    ultraTreeNodeColumn14.LayoutInfo.PreferredCellSize = new Size(203, 19);
    ultraTreeNodeColumn14.LayoutInfo.PreferredLabelSize = new Size(203, 23);
    ultraTreeNodeColumn14.LayoutInfo.SpanX = 4;
    ultraTreeNodeColumn14.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn15.DataType = typeof (int);
    ((KeyedSubObjectBase) ultraTreeNodeColumn15).Key = "RollUpTo";
    ultraTreeNodeColumn15.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn15.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn15.Visible = false;
    ultraTreeNodeColumn16.DataType = typeof (bool);
    ((KeyedSubObjectBase) ultraTreeNodeColumn16).Key = "ControlAcct";
    ultraTreeNodeColumn16.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn16.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn16.Visible = false;
    ultraTreeNodeColumn17.DataType = typeof (bool);
    ((KeyedSubObjectBase) ultraTreeNodeColumn17).Key = "SystemDefined";
    ultraTreeNodeColumn17.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn17.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn17.Visible = false;
    ultraTreeNodeColumn18.DataType = typeof (string);
    ((KeyedSubObjectBase) ultraTreeNodeColumn18).Key = "ShortName";
    ultraTreeNodeColumn18.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn18.LayoutInfo.SpanY = 2;
    ultraTreeNodeColumn18.Visible = false;
    ultraTreeNodeColumn19.DataType = typeof (IBindingList);
    ultraTreeNodeColumn19.IsChaptered = true;
    ((KeyedSubObjectBase) ultraTreeNodeColumn19).Key = "GLAccounts_GLAccounts";
    ultraTreeNodeColumn19.LayoutInfo.SpanX = 2;
    ultraTreeNodeColumn19.LayoutInfo.SpanY = 2;
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn12);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn13);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn14);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn15);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn16);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn17);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn18);
    ultraTreeColumnSet3.Columns.Add(ultraTreeNodeColumn19);
    ultraTreeColumnSet3.IsAutoGenerated = true;
    ((KeyedSubObjectBase) ultraTreeColumnSet3).Key = "GLAccounts_GLAccounts";
    this.TreeView.ColumnSettings.ColumnSets.Add(ultraTreeColumnSet1);
    this.TreeView.ColumnSettings.ColumnSets.Add(ultraTreeColumnSet2);
    this.TreeView.ColumnSettings.ColumnSets.Add(ultraTreeColumnSet3);
    this.TreeView.ColumnSettings.LabelPosition = (NodeLayoutLabelPosition) 1;
    this.TreeView.ColumnSettings.ShowSortIndicators = (DefaultableBoolean) 2;
    this.TreeView.DataMember = "AccountClassifications";
    this.TreeView.DataSource = (object) this.DsGLAccounts2;
    this.TreeView.ExpansionIndicatorColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.TreeView).Font = new Font("Tahoma", 8.25f);
    this.TreeView.FullRowSelect = true;
    this.TreeView.ImageList = this.GLAccountImages;
    this.TreeView.Indent = 15;
    ((Control) this.TreeView).Location = new Point(3, 20);
    ((Control) this.TreeView).Name = "TreeView";
    this.TreeView.NodeConnectorColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    @override.CellClickAction = (CellClickAction) 4;
    @override.NodeStyle = (NodeStyle) 4;
    @override.SelectionType = (SelectType) 1;
    @override.ShowColumns = (DefaultableBoolean) 1;
    @override.ShowExpansionIndicator = (ShowExpansionIndicator) 3;
    this.TreeView.Override = @override;
    ((Control) this.TreeView).Size = new Size(421, 350);
    ((Control) this.TreeView).TabIndex = 0;
    ((UltraControlBase) this.TreeView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TreeView).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.TreeView).Visible = false;
    this.GLAccountImages.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("GLAccountImages.ImageStream");
    this.GLAccountImages.TransparentColor = Color.Transparent;
    this.GLAccountImages.Images.SetKeyName(0, "");
    this.GLAccountImages.Images.SetKeyName(1, "");
    this.GLAccountImages.Images.SetKeyName(2, "");
    this.TreeContainer.PopupControl = (Control) this.TreeView;
    appearance6.BackColor = Color.White;
    appearance6.BackColor2 = Color.FromArgb(165, 185, 235);
    appearance6.BackGradientAlignment = (GradientAlignment) 1;
    appearance6.BackGradientStyle = (GradientStyle) 10;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.buttonDropDown).Appearance = (AppearanceBase) appearance6;
    ((UltraButtonBase) this.buttonDropDown).ButtonStyle = (UIElementButtonStyle) 16 /*0x10*/;
    ((Control) this.buttonDropDown).Location = new Point(186, 0);
    ((Control) this.buttonDropDown).Name = "buttonDropDown";
    ((Control) this.buttonDropDown).Size = new Size(21, 19);
    this.buttonDropDown.Style = (SplitButtonDisplayStyle) 1;
    ((Control) this.buttonDropDown).TabIndex = 1;
    ((UltraControlBase) this.buttonDropDown).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDisplay).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtDisplay).BackColor = Color.White;
    ((Control) this.txtDisplay).Location = new Point(0, 0);
    this.txtDisplay.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDisplay).Name = "txtDisplay";
    ((EditorButtonControlBase) this.txtDisplay).ReadOnly = true;
    ((Control) this.txtDisplay).Size = new Size(186, 19);
    ((Control) this.txtDisplay).TabIndex = 2;
    ((UltraControlBase) this.txtDisplay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDisplay).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.White;
    ((ControlBase) this.buttonDropDown_Hidden).Appearance = (AppearanceBase) appearance8;
    ((UltraButtonBase) this.buttonDropDown_Hidden).ButtonStyle = (UIElementButtonStyle) 3;
    ((Control) this.buttonDropDown_Hidden).Location = new Point(3, 4);
    ((Control) this.buttonDropDown_Hidden).Name = "buttonDropDown_Hidden";
    this.buttonDropDown_Hidden.PopupItemKey = "TreeView";
    this.buttonDropDown_Hidden.PopupItemProvider = (IPopupItemProvider) this.TreeContainer;
    ((Control) this.buttonDropDown_Hidden).Size = new Size(16 /*0x10*/, 10);
    this.buttonDropDown_Hidden.Style = (SplitButtonDisplayStyle) 1;
    ((Control) this.buttonDropDown_Hidden).TabIndex = 3;
    ((UltraControlBase) this.buttonDropDown_Hidden).UseOsThemes = (DefaultableBoolean) 2;
    this.DsGLAccounts2.DataSetName = "dsGLAccounts";
    this.DsGLAccounts2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.TreeView);
    this.Controls.Add((Control) this.buttonDropDown_Hidden);
    this.Controls.Add((Control) this.txtDisplay);
    this.Controls.Add((Control) this.buttonDropDown);
    this.Name = nameof (GLAccountDropTree);
    this.Size = new Size(207, 19);
    ((ISupportInitialize) this.TreeView).EndInit();
    ((ISupportInitialize) this.txtDisplay).EndInit();
    this.DsGLAccounts2.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual UltraTree TreeView
  {
    get => this._TreeView;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.TreeView_AfterSelect);
      KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TreeView_KeyPress);
      UltraTree treeView1 = this._TreeView;
      if (treeView1 != null)
      {
        treeView1.AfterSelect -= selectEventHandler;
        ((Control) treeView1).KeyPress -= pressEventHandler;
      }
      this._TreeView = value;
      UltraTree treeView2 = this._TreeView;
      if (treeView2 == null)
        return;
      treeView2.AfterSelect += selectEventHandler;
      ((Control) treeView2).KeyPress += pressEventHandler;
    }
  }

  [field: AccessedThroughProperty("TreeContainer")]
  protected virtual UltraPopupControlContainer TreeContainer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDisplay")]
  internal virtual MGATextBox txtDisplay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GLAccountImages")]
  protected virtual ImageList GLAccountImages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraDropDownButton buttonDropDown
  {
    get => this._buttonDropDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.buttonDropDown_DroppingDown);
      EventHandler eventHandler = new EventHandler(this.buttonDropDown_ClosedUp);
      UltraDropDownButton buttonDropDown1 = this._buttonDropDown;
      if (buttonDropDown1 != null)
      {
        buttonDropDown1.DroppingDown -= cancelEventHandler;
        buttonDropDown1.ClosedUp -= eventHandler;
      }
      this._buttonDropDown = value;
      UltraDropDownButton buttonDropDown2 = this._buttonDropDown;
      if (buttonDropDown2 == null)
        return;
      buttonDropDown2.DroppingDown += cancelEventHandler;
      buttonDropDown2.ClosedUp += eventHandler;
    }
  }

  [field: AccessedThroughProperty("buttonDropDown_Hidden")]
  private virtual UltraDropDownButton buttonDropDown_Hidden { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGLAccounts2")]
  internal virtual dsGLAccounts DsGLAccounts2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public GLAccountDropTree()
  {
    this._showAR = GLAccountDropTree.Assets.None;
    this._showAP = GLAccountDropTree.Liabilities.None;
    this.InitializeComponent();
  }

  [Browsable(true)]
  [DefaultValue(200)]
  [Description("Set the drop down width of the control.")]
  public virtual int DropDownWidth
  {
    get => this._dropDownWidth;
    set => this._dropDownWidth = value;
  }

  [Browsable(true)]
  [DefaultValue(200)]
  [Description("Set the drop down height of the control.")]
  public virtual int DropDownHeight
  {
    get => this._dropDownHeight;
    set => this._dropDownHeight = value;
  }

  [Browsable(true)]
  [DefaultValue(typeof (GLAccountDropTree.Assets), "None")]
  [Description("Gets/Sets whether the drop tree will show accounts payable accounts")]
  public virtual GLAccountDropTree.Assets ShowAssetAccounts
  {
    get => this._showAR;
    set => this._showAR = value;
  }

  [Browsable(true)]
  [DefaultValue(typeof (GLAccountDropTree.Liabilities), "None")]
  [Description("Gets/Sets whether the drop tree will show accounts receivable accounts")]
  public virtual GLAccountDropTree.Liabilities ShowLiabilityAccounts
  {
    get => this._showAP;
    set => this._showAP = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show expense accounts")]
  public virtual bool ShowExpenseAccounts
  {
    get => this._showExpense;
    set => this._showExpense = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show equity accounts")]
  public virtual bool ShowEquityAccounts
  {
    get => this._showEquity;
    set => this._showEquity = value;
  }

  [Browsable(true)]
  [DefaultValue(false)]
  [Description("Gets/Sets whether the drop tree will show income accounts")]
  public virtual bool ShowIncomeAccounts
  {
    get => this._showIncome;
    set => this._showIncome = value;
  }

  [Browsable(true)]
  [Description("This will determine whether system defined accounts are shown to the user.")]
  [DefaultValue(false)]
  public virtual bool ShowSystemDefinedAccounts
  {
    get => this._ShowSystemDefinedAccounts;
    set => this._ShowSystemDefinedAccounts = value;
  }

  [Browsable(false)]
  [DefaultValue("")]
  private string GLAccountFullName
  {
    get
    {
      return this.TreeView.ActiveNode == null || bool.Parse(this.TreeView.ActiveNode.Cells["ControlAcct"].Value.ToString()) ? "" : this.TreeView.ActiveNode.Cells["FullName"].Value.ToString();
    }
  }

  [Browsable(false)]
  [DefaultValue("")]
  public string GLAccountShortName
  {
    get
    {
      return this.TreeView.ActiveNode == null || bool.Parse(this.TreeView.ActiveNode.Cells["ControlAcct"].Value.ToString()) ? "" : this.TreeView.ActiveNode.Cells["ShortName"].Value.ToString();
    }
  }

  [Browsable(false)]
  [DefaultValue("")]
  public int GLAccountID
  {
    get
    {
      return ((DisposableObjectCollectionBase) this.TreeView.SelectedNodes).Count == 0 || this.TreeView.ActiveNode == null || bool.Parse(this.TreeView.ActiveNode.Cells["ControlAcct"].Value.ToString()) ? -1 : int.Parse(this.TreeView.ActiveNode.Cells["GlAcctId"].Value.ToString());
    }
  }

  public void LoadGLAccounts(int glCompanyID)
  {
    Database.Instance.QuerySP.PerformTableQuery("spFin_GetGLAccountClassifications", (DataTable) this.DsGLAccounts2.AccountClassifications, (object) "@glcompanyid", (object) glCompanyID, (object) "@showIncome", (object) this.ShowIncomeAccounts, (object) "@showExpenses", (object) this.ShowExpenseAccounts, (object) "@showEquity", (object) this.ShowEquityAccounts, (object) "@showLiability", Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.All, (object) "A", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.AP, (object) "P", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.SR, (object) "U", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.XF, (object) "X", (object) "N"))))))), (object) "@showAsset", Interaction.IIf(this.ShowAssetAccounts == GLAccountDropTree.Assets.All, (object) "A", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowAssetAccounts == GLAccountDropTree.Assets.AR, (object) "R", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowAssetAccounts == GLAccountDropTree.Assets.Cash, (object) "C", (object) "N"))))));
    Database.Instance.QuerySP.PerformTableQuery("spFin_GetGLAccounts", (DataTable) this.DsGLAccounts2.GLAccounts, (object) "@glcompanyid", (object) glCompanyID, (object) "@showSystem", (object) this.ShowSystemDefinedAccounts, (object) "@showIncome", (object) this.ShowIncomeAccounts, (object) "@showExpenses", (object) this.ShowExpenseAccounts, (object) "@showEquity", (object) this.ShowEquityAccounts, (object) "@showLiability", Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.All, (object) "A", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.AP, (object) "P", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.SR, (object) "U", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowLiabilityAccounts == GLAccountDropTree.Liabilities.XF, (object) "X", (object) "N"))))))), (object) "@showAsset", Interaction.IIf(this.ShowAssetAccounts == GLAccountDropTree.Assets.All, (object) "A", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowAssetAccounts == GLAccountDropTree.Assets.AR, (object) "R", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.ShowAssetAccounts == GLAccountDropTree.Assets.Cash, (object) "C", (object) "N"))))));
  }

  private void buttonDropDown_DroppingDown(object sender, CancelEventArgs e)
  {
    ((Control) this.txtDisplay).SendToBack();
    this.buttonDropDown_Hidden.DropDown();
  }

  private void buttonDropDown_ClosedUp(object sender, EventArgs e)
  {
    ((Control) this.txtDisplay).BringToFront();
  }

  private void TreeView_AfterSelect(object sender, SelectEventArgs e)
  {
    if (this.TreeView.ActiveNode == null || this.TreeView.ActiveNode.HasNodes)
      return;
    ((TextEditorControlBase) this.txtDisplay).Text = this.TreeView.ActiveNode.Cells["FullName"].Value.ToString();
    ((Control) this.txtDisplay).BringToFront();
    this.buttonDropDown.CloseUp();
    this.buttonDropDown_Hidden.CloseUp();
    this.OnGLAccountSelected(int.Parse(this.TreeView.ActiveNode.Cells["GLAcctId"].Value.ToString()), this.TreeView.ActiveNode.Cells["FullName"].Value.ToString(), this.TreeView.ActiveNode.Cells["ShortName"].Value.ToString());
  }

  public event GLAccountDropTree.GLAccountSelectedEventHandler GLAccountSelected;

  protected void OnGLAccountSelected(int glAccountId, string fullName, string shortName)
  {
    // ISSUE: reference to a compiler-generated field
    GLAccountDropTree.GLAccountSelectedEventHandler accountSelectedEvent = this.GLAccountSelectedEvent;
    if (accountSelectedEvent == null)
      return;
    accountSelectedEvent((object) this, new GLAccountSelectedEventArgs(glAccountId, fullName, shortName));
  }

  private void textTypeAhead_ValueChanged(object sender, EventArgs e)
  {
  }

  private void TreeView_KeyPress(object sender, KeyPressEventArgs e)
  {
  }

  [Flags]
  public enum Assets
  {
    None = 0,
    AR = 2,
    Cash = 4,
    All = Cash | AR, // 0x00000006
  }

  [Flags]
  public enum Liabilities
  {
    None = 0,
    AP = 2,
    SR = 4,
    XF = 8,
    All = XF | SR | AP, // 0x0000000E
  }

  public delegate void GLAccountSelectedEventHandler(object sender, GLAccountSelectedEventArgs e);
}
