// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.FormFilterSelection
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinListView;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[DesignerGenerated]
public class FormFilterSelection : Form
{
  private IContainer components;
  private ActiveEntitySearch _ctrl;

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
    UltraListViewItem ultraListViewItem1 = new UltraListViewItem((object) "Company", (UltraListViewSubItem[]) null, (object) null);
    UltraListViewItem ultraListViewItem2 = new UltraListViewItem((object) "Producer/Agent", (UltraListViewSubItem[]) null, (object) null);
    UltraListViewItem ultraListViewItem3 = new UltraListViewItem((object) "Insured", (UltraListViewSubItem[]) null, (object) null);
    UltraListViewItem ultraListViewItem4 = new UltraListViewItem((object) "Third Party Payee", (UltraListViewSubItem[]) null, (object) null);
    UltraListViewItem ultraListViewItem5 = new UltraListViewItem((object) "User", (UltraListViewSubItem[]) null, (object) null);
    UltraListViewItem ultraListViewItem6 = new UltraListViewItem((object) "Inspection Company", (UltraListViewSubItem[]) null, (object) null);
    UltraListViewItem ultraListViewItem7 = new UltraListViewItem((object) "Expense Payee", (UltraListViewSubItem[]) null, (object) null);
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormFilterSelection));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.listViewFilters = new UltraListView();
    this.ImageList1 = new ImageList(this.components);
    this.buttonOk = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.listViewFilters).BeginInit();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = SystemColors.InactiveCaption;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    this.listViewFilters.Appearance = (AppearanceBase) appearance1;
    this.listViewFilters.BorderStyle = (UIElementBorderStyle) 1;
    ultraListViewItem1.Key = "C";
    ultraListViewItem2.Key = "P";
    ultraListViewItem3.Key = "I";
    ultraListViewItem4.Key = "TPP";
    ultraListViewItem5.Key = "U";
    ultraListViewItem6.Key = "INS";
    ultraListViewItem7.Key = "EX";
    this.listViewFilters.Items.AddRange(new UltraListViewItem[7]
    {
      ultraListViewItem1,
      ultraListViewItem2,
      ultraListViewItem3,
      ultraListViewItem4,
      ultraListViewItem5,
      ultraListViewItem6,
      ultraListViewItem7
    });
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    this.listViewFilters.ItemSettings.ActiveAppearance = (AppearanceBase) appearance2;
    this.listViewFilters.ItemSettings.DefaultImage = (Image) componentResourceManager.GetObject("listViewFilters.ItemSettings.DefaultImage");
    ((Control) this.listViewFilters).Location = new Point(3, 5);
    ((Control) this.listViewFilters).Name = "listViewFilters";
    ((Control) this.listViewFilters).Size = new Size(168, 149);
    ((Control) this.listViewFilters).TabIndex = 3;
    ((Control) this.listViewFilters).Text = "UltraListView1";
    this.listViewFilters.View = (UltraListViewStyle) 2;
    ((UltraListViewListSettingsBase) this.listViewFilters.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    ((UltraListViewSettingsBase) this.listViewFilters.ViewSettingsList).ImageList = this.ImageList1;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "user_orange.png");
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonOk).Location = new Point(131, 141);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(40, 30);
    ((Control) this.buttonOk).TabIndex = 2;
    this.buttonOk.UseOSThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCancel).Location = new Point(86, 141);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(40, 30);
    ((Control) this.buttonCancel).TabIndex = 1;
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    this.ClientSize = new Size(172, 175);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonOk);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.listViewFilters);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximumSize = new Size(178, 199);
    this.MinimumSize = new Size(178, 199);
    this.Name = nameof (FormFilterSelection);
    this.Text = "Filter Selection";
    ((ISupportInitialize) this.listViewFilters).EndInit();
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonOk
  {
    get => this._buttonOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonOk_Click);
      MGAButton buttonOk1 = this._buttonOk;
      if (buttonOk1 != null)
        ((Control) buttonOk1).Click -= eventHandler;
      this._buttonOk = value;
      MGAButton buttonOk2 = this._buttonOk;
      if (buttonOk2 == null)
        return;
      ((Control) buttonOk2).Click += eventHandler;
    }
  }

  internal virtual UltraListView listViewFilters
  {
    get => this._listViewFilters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckStateChangedEventHandler changedEventHandler = new ItemCheckStateChangedEventHandler(this.listViewFilters_ItemCheckStateChanged);
      UltraListView listViewFilters1 = this._listViewFilters;
      if (listViewFilters1 != null)
        listViewFilters1.ItemCheckStateChanged -= changedEventHandler;
      this._listViewFilters = value;
      UltraListView listViewFilters2 = this._listViewFilters;
      if (listViewFilters2 == null)
        return;
      listViewFilters2.ItemCheckStateChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private FormFilterSelection() => this.InitializeComponent();

  public FormFilterSelection(ActiveEntitySearch ctrl)
  {
    this.InitializeComponent();
    this._ctrl = ctrl;
    this.DisplayCurrentFilter();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonOk_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void DisplayCurrentFilter()
  {
    if (this._ctrl.EntityTypeFilter == ActiveEntitySearch.EntityTypesFilter.All)
      return;
    if (this._ctrl.EntityTypeFilter == (ActiveEntitySearch.EntityTypesFilter.Company | this._ctrl.EntityTypeFilter))
      this.listViewFilters.Items["C"].CheckState = CheckState.Checked;
    if (this._ctrl.EntityTypeFilter == (ActiveEntitySearch.EntityTypesFilter.Producer | this._ctrl.EntityTypeFilter))
      this.listViewFilters.Items["P"].CheckState = CheckState.Checked;
    if (this._ctrl.EntityTypeFilter == (ActiveEntitySearch.EntityTypesFilter.ThirdPartyPayee | this._ctrl.EntityTypeFilter))
      this.listViewFilters.Items["TPP"].CheckState = CheckState.Checked;
    if (this._ctrl.EntityTypeFilter == (ActiveEntitySearch.EntityTypesFilter.Insured | this._ctrl.EntityTypeFilter))
      this.listViewFilters.Items["I"].CheckState = CheckState.Checked;
    if (this._ctrl.EntityTypeFilter == (ActiveEntitySearch.EntityTypesFilter.User | this._ctrl.EntityTypeFilter))
      this.listViewFilters.Items["U"].CheckState = CheckState.Checked;
    if (this._ctrl.EntityTypeFilter == (ActiveEntitySearch.EntityTypesFilter.InspectionCompany | this._ctrl.EntityTypeFilter))
      this.listViewFilters.Items["INS"].CheckState = CheckState.Checked;
    if (this._ctrl.EntityTypeFilter != (ActiveEntitySearch.EntityTypesFilter.ExpensePayee | this._ctrl.EntityTypeFilter))
      return;
    this.listViewFilters.Items["EX"].CheckState = CheckState.Checked;
  }

  private void listViewFilters_ItemCheckStateChanged(
    object sender,
    ItemCheckStateChangedEventArgs e)
  {
    ((ItemEventArgs) e).Item.Activate();
  }
}
