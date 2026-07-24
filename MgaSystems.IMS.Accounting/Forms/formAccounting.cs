// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Forms.formAccounting
// Assembly: MgaSystems.IMS.Accounting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 118B765D-C703-4927-A662-CA3DF0A8B869
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.Common;
using MGASystems.Common.Controls.Forms;
using MGASystems.Common.HotKeyManagement;
using MGASystems.IMS.Accounting.Attributes;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Forms;

[SecureHotkeyResource("{CBA17A23-3E62-4ce5-8F73-FCC445D2825A}", "Accounting System Hot Key", "Determines if the user can access the accounting system from the hot key bar.", "Accounting")]
[HotKeyInfo("Integrated Accounting", "Accounting", "Click here to launch the accounting management system.", Keys.F5, "MGASystems.Tools.Accounting.PNG")]
[DocumentFolderFilter("Accounting")]
public class formAccounting : AccountingNoteDocumentSupport, IRecreatableEntity
{
  private IContainer components;
  private UltraExplorerBar AccountingExplorer;
  private Panel panelContent;
  private UltraExplorerBar ContentExplorer;
  private Panel formAccounting_Fill_Panel;
  private EllipsePanel panelBrowserContainer;
  private MGAWebView webBrowser1;
  public const string HOTKEY_SECURITYID = "{CBA17A23-3E62-4ce5-8F73-FCC445D2825A}";
  private ArrayList _acctLibraries;

  public formAccounting()
  {
    this.InitializeComponent();
    this.LoadAccountingLibraries();
    this.LoadLibraryMenus();
    this.SetGroupOrder();
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
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formAccounting));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.AccountingExplorer = new UltraExplorerBar();
    this.panelContent = new Panel();
    this.panelBrowserContainer = new EllipsePanel();
    this.ContentExplorer = new UltraExplorerBar();
    this.formAccounting_Fill_Panel = new Panel();
    this.webBrowser1 = new MGAWebView();
    ((ISupportInitialize) this.AccountingExplorer).BeginInit();
    this.panelContent.SuspendLayout();
    this.panelBrowserContainer.SuspendLayout();
    ((ISupportInitialize) this.ContentExplorer).BeginInit();
    this.formAccounting_Fill_Panel.SuspendLayout();
    this.SuspendLayout();
    this.AccountingExplorer.AnimationEnabled = false;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.AccountingExplorer.Appearance = (AppearanceBase) appearance1;
    this.AccountingExplorer.ColumnSpacing = 0;
    ((Control) this.AccountingExplorer).Dock = DockStyle.Left;
    explorerBarGroup1.Key = "TOOLS";
    explorerBarGroup1.Settings.AllowDrag = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).AllowEdit = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.AllowItemDrop = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.AllowItemUncheck = (DefaultableBoolean) 2;
    explorerBarGroup1.Text = "Accounting Tools";
    explorerBarGroup2.Key = "ADMIN";
    explorerBarGroup2.Text = "Administrative Options";
    this.AccountingExplorer.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
    });
    this.AccountingExplorer.GroupSettings.AllowDrag = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) this.AccountingExplorer.GroupSettings).AllowEdit = (DefaultableBoolean) 2;
    this.AccountingExplorer.GroupSettings.AllowItemDrop = (DefaultableBoolean) 2;
    this.AccountingExplorer.GroupSettings.AllowItemUncheck = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.WhiteSmoke;
    this.AccountingExplorer.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageBackground = (Image) componentResourceManager.GetObject("appearance3.ImageBackground");
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    this.AccountingExplorer.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance3;
    this.AccountingExplorer.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.AccountingExplorer.GroupSettings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) this.AccountingExplorer.GroupSettings).ShowInkButton = (ShowInkButton) 3;
    ((UltraExplorerBarSettingsBase) this.AccountingExplorer.GroupSettings).ShowToolTips = (DefaultableBoolean) 1;
    this.AccountingExplorer.GroupSettings.Style = (GroupStyle) 2;
    this.AccountingExplorer.GroupSpacing = 5;
    this.AccountingExplorer.ImageSizeLarge = new Size(24, 24);
    this.AccountingExplorer.ItemSettings.AllowDragCopy = (ItemDragStyle) 1;
    this.AccountingExplorer.ItemSettings.AllowDragMove = (ItemDragStyle) 1;
    ((UltraExplorerBarSettingsBase) this.AccountingExplorer.ItemSettings).AllowEdit = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    ((AppearanceBase) appearance4).BackColor2 = Color.Transparent;
    this.AccountingExplorer.ItemSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    this.AccountingExplorer.ItemSettings.HotTrackBorderStyle = (UIElementBorderStyle) 1;
    ((UltraExplorerBarSettingsBase) this.AccountingExplorer.ItemSettings).HotTracking = (DefaultableBoolean) 2;
    this.AccountingExplorer.ItemSettings.HotTrackStyle = (ItemHotTrackStyle) 4;
    ((Control) this.AccountingExplorer).Location = new Point(0, 0);
    this.AccountingExplorer.Margins.Bottom = 4;
    this.AccountingExplorer.Margins.Left = 4;
    this.AccountingExplorer.Margins.Right = 4;
    this.AccountingExplorer.Margins.Top = 4;
    ((Control) this.AccountingExplorer).Name = "AccountingExplorer";
    this.AccountingExplorer.NavigationAllowGroupReorder = false;
    this.AccountingExplorer.ShowDefaultContextMenu = false;
    ((Control) this.AccountingExplorer).Size = new Size(299, 576);
    ((Control) this.AccountingExplorer).TabIndex = 1;
    ((UltraControlBase) this.AccountingExplorer).UseFlatMode = (DefaultableBoolean) 2;
    ((UltraControlBase) this.AccountingExplorer).UseOsThemes = (DefaultableBoolean) 2;
    this.AccountingExplorer.ViewStyle = (UltraExplorerBarViewStyle) 6;
    this.AccountingExplorer.GroupCollapsing += new GroupCollapsingEventHandler(this.AccountingExplorer_GroupCollapsing);
    this.AccountingExplorer.ItemClick += new ItemClickEventHandler(this.AccountingExplorer_ItemClick);
    this.panelContent.Controls.Add((Control) this.panelBrowserContainer);
    this.panelContent.Controls.Add((Control) this.AccountingExplorer);
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(0, 0);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(868, 576);
    this.panelContent.TabIndex = 2;
    this.panelBrowserContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelBrowserContainer.BorderColor = Color.LightSteelBlue;
    this.panelBrowserContainer.BorderWidth = 2;
    this.panelBrowserContainer.Controls.Add((Control) this.webBrowser1);
    this.panelBrowserContainer.Location = new Point(305, 12);
    this.panelBrowserContainer.Name = "panelBrowserContainer";
    this.panelBrowserContainer.Size = new Size(560, 552);
    this.panelBrowserContainer.TabIndex = 3;
    this.ContentExplorer.AnimationEnabled = false;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ContentExplorer.Appearance = (AppearanceBase) appearance5;
    this.ContentExplorer.ColumnSpacing = 0;
    ((AppearanceBase) appearance6).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance6).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance6).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).ImageBackground = (Image) componentResourceManager.GetObject("appearance6.ImageBackground");
    ((AppearanceBase) appearance6).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance6).TextVAlignAsString = "Middle";
    this.ContentExplorer.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ContentExplorer.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance7;
    this.ContentExplorer.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.ContentExplorer.GroupSettings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) this.ContentExplorer.GroupSettings).ShowInkButton = (ShowInkButton) 3;
    ((UltraExplorerBarSettingsBase) this.ContentExplorer.GroupSettings).ShowToolTips = (DefaultableBoolean) 1;
    this.ContentExplorer.GroupSettings.Style = (GroupStyle) 2;
    this.ContentExplorer.GroupSpacing = 5;
    this.ContentExplorer.ImageSizeLarge = new Size(24, 24);
    ((AppearanceBase) appearance8).BackColor = Color.White;
    this.ContentExplorer.ItemSettings.AppearancesLarge.Appearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    this.ContentExplorer.ItemSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ((Control) this.ContentExplorer).Location = new Point(117, 159);
    this.ContentExplorer.Margins.Bottom = 4;
    this.ContentExplorer.Margins.Left = 4;
    this.ContentExplorer.Margins.Right = 4;
    this.ContentExplorer.Margins.Top = 4;
    ((Control) this.ContentExplorer).Name = "ContentExplorer";
    this.ContentExplorer.NavigationAllowGroupReorder = false;
    ((Control) this.ContentExplorer).Size = new Size(332, 328);
    ((Control) this.ContentExplorer).TabIndex = 2;
    ((UltraControlBase) this.ContentExplorer).UseFlatMode = (DefaultableBoolean) 1;
    this.ContentExplorer.UseLargeGroupHeaderImages = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ContentExplorer).UseOsThemes = (DefaultableBoolean) 2;
    this.ContentExplorer.ViewStyle = (UltraExplorerBarViewStyle) 1;
    this.formAccounting_Fill_Panel.Controls.Add((Control) this.panelContent);
    this.formAccounting_Fill_Panel.Cursor = Cursors.Default;
    this.formAccounting_Fill_Panel.Dock = DockStyle.Fill;
    this.formAccounting_Fill_Panel.Location = new Point(0, 0);
    this.formAccounting_Fill_Panel.Name = "formAccounting_Fill_Panel";
    this.formAccounting_Fill_Panel.Size = new Size(868, 576);
    this.formAccounting_Fill_Panel.TabIndex = 0;
    this.webBrowser1.Location = new Point(12, 13);
    this.webBrowser1.MinimumSize = new Size(20, 20);
    this.webBrowser1.Name = "webBrowser1";
    this.webBrowser1.Size = new Size(545, 539);
    this.webBrowser1.TabIndex = 3;
    this.webBrowser1.BrowserInitialized += new EventHandler(this.GetContentPage);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(868, 576);
    this.Controls.Add((Control) this.formAccounting_Fill_Panel);
    this.Controls.Add((Control) this.ContentExplorer);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formAccounting);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Integrated Accounting";
    this.WindowState = FormWindowState.Maximized;
    this.Load += new EventHandler(this.formAccounting_Load);
    ((ISupportInitialize) this.AccountingExplorer).EndInit();
    this.panelContent.ResumeLayout(false);
    this.panelBrowserContainer.ResumeLayout(false);
    ((ISupportInitialize) this.ContentExplorer).EndInit();
    this.formAccounting_Fill_Panel.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadAccountingLibraries()
  {
    foreach (Assembly assembly in ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).Where<Assembly>((Func<Assembly, bool>) (asm => ((IEnumerable<object>) asm.GetCustomAttributes(typeof (AccountingLibrary), false)).Any<object>())))
    {
      if (this._acctLibraries == null)
        this._acctLibraries = new ArrayList();
      this._acctLibraries.Add((object) assembly);
    }
  }

  private void LoadLibraryMenus()
  {
    if (this._acctLibraries == null || this._acctLibraries.Count == 0)
      return;
    for (int index1 = 0; index1 < this._acctLibraries.Count; ++index1)
    {
      if ((object) (this._acctLibraries[index1] as Assembly) != null)
      {
        foreach (Type type1 in (this._acctLibraries[index1] as Assembly).GetTypes())
        {
          if (type1.GetInterface("IAccountingExplorerProvider", true) != (Type) null)
          {
            if (AccountingProviderManager.CreateType(type1) is IAccountingExplorerProvider type2)
            {
              UltraExplorerBarGroup explorerBarGroup = type2.BuildExplorerMenu();
              if (explorerBarGroup != null)
                this.AccountingExplorer.Groups.Insert(type2.ExplorerMenuIndex, explorerBarGroup);
            }
            UltraExplorerBarItem[] ultraExplorerBarItemArray1 = type2.ProvideTools();
            if (ultraExplorerBarItemArray1 != null)
            {
              for (int index2 = 0; index2 < ultraExplorerBarItemArray1.Length; ++index2)
              {
                ultraExplorerBarItemArray1[index2].Settings.HotTrackStyle = (ItemHotTrackStyle) 4;
                this.AccountingExplorer.Groups["TOOLS"].Items.Add(ultraExplorerBarItemArray1[index2]);
              }
            }
            UltraExplorerBarItem[] ultraExplorerBarItemArray2 = type2.ProvideAdministrativeOptions();
            if (ultraExplorerBarItemArray2 != null)
            {
              for (int index3 = 0; index3 < ultraExplorerBarItemArray2.Length; ++index3)
                this.AccountingExplorer.Groups["ADMIN"].Items.Add(ultraExplorerBarItemArray2[index3]);
            }
          }
          else if (type1.GetInterface("IAccountingExplorerControlProvider", true) != (Type) null && AccountingProviderManager.CreateType(type1) is IAccountingExplorerControlProvider type3)
          {
            UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
            explorerBarGroup.Settings.Style = (GroupStyle) 6;
            this.ContentExplorer.Groups.Add(explorerBarGroup);
            explorerBarGroup.Text = type3.GroupHeaderText;
            explorerBarGroup.ColumnsSpanned = type3.GroupColumnSpan;
            Control explorerControl = type3.GetExplorerControl();
            explorerBarGroup.Settings.ContainerHeight = explorerControl.Height;
            explorerBarGroup.Settings.ItemAreaInnerMargins.Bottom = 4;
            explorerBarGroup.Settings.ItemAreaInnerMargins.Left = 4;
            explorerBarGroup.Settings.ItemAreaInnerMargins.Right = 4;
            explorerBarGroup.Settings.ItemAreaInnerMargins.Top = 4;
            explorerControl.Dock = DockStyle.Fill;
            ((Control) explorerBarGroup.Container).Controls.Add(explorerControl);
          }
        }
      }
    }
  }

  private void SetGroupOrder()
  {
    UltraExplorerBarGroup group1 = this.AccountingExplorer.Groups["TOOLS"];
    UltraExplorerBarGroup group2 = this.AccountingExplorer.Groups["ADMIN"];
    this.AccountingExplorer.Groups.Remove(group1);
    this.AccountingExplorer.Groups.Remove(group2);
    this.AccountingExplorer.Groups.Add(group1);
    this.AccountingExplorer.Groups.Add(group2);
  }

  private void AccountingExplorer_ItemClick(object sender, ItemEventArgs e)
  {
    if (((SubObjectBase) e.Item).Tag == null)
      return;
    if (((SubObjectBase) e.Item).Tag is IAccountingExplorerProviderExtensions)
      this.LoadAccountingForm((((SubObjectBase) e.Item).Tag as IAccountingExplorerProviderExtensions).FormType, (((SubObjectBase) e.Item).Tag as IAccountingExplorerProviderExtensions).ShowFormModal, (((SubObjectBase) e.Item).Tag as IAccountingExplorerProviderExtensions).SecurityGuid);
    else if ((((SubObjectBase) e.Item).Tag as object[]).Length < 3 || (((SubObjectBase) e.Item).Tag as object[])[2] == null || string.IsNullOrEmpty((((SubObjectBase) e.Item).Tag as object[])[2].ToString()))
      this.LoadAccountingForm((((SubObjectBase) e.Item).Tag as object[])[0] as Type, bool.Parse((((SubObjectBase) e.Item).Tag as object[])[1].ToString()), string.Empty);
    else
      this.LoadAccountingForm((((SubObjectBase) e.Item).Tag as object[])[0] as Type, bool.Parse((((SubObjectBase) e.Item).Tag as object[])[1].ToString()), (((SubObjectBase) e.Item).Tag as object[])[2].ToString());
  }

  private void LoadAccountingForm(Type _type, bool showAsDialog, string securityGuid)
  {
    if (this._acctLibraries == null || this._acctLibraries.Count == 0)
      return;
    if (!securityGuid.Equals(string.Empty) && !SecurityManager.Instance.AssertPermission(securityGuid))
    {
      using (formAccessDenied formAccessDenied = new formAccessDenied())
      {
        int num = (int) formAccessDenied.ShowDialog();
      }
    }
    else
    {
      if (_type.ToString() == "MGASystems.IMS.Accounting.Core.Forms.formTransactionBuilder" && MGASystems.Common.SystemSettings.KeyExists("SingleInstanceTransactionBuilder") && MGASystems.Common.SystemSettings.GetBoolSetting("SingleInstanceTransactionBuilder"))
      {
        foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
        {
          if (mdiChild.GetType() == _type || mdiChild.GetType().IsSubclassOf(_type))
          {
            mdiChild.BringToFront();
            return;
          }
        }
      }
      if (_type.ToString() == "MGASystems.IMS.Accounting.Core.Forms.FormDirectBillPayablesUtility" || _type.ToString() == "MGASystems.IMS.Accounting.Core.Forms.formDirectBillPayables")
      {
        foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
        {
          if (mdiChild.GetType() == _type || mdiChild.GetType().IsSubclassOf(_type))
          {
            mdiChild.BringToFront();
            return;
          }
        }
      }
      for (int index = 0; index < this._acctLibraries.Count; ++index)
      {
        if ((object) (this._acctLibraries[index] as Assembly) != null)
        {
          foreach (Type type in (this._acctLibraries[index] as Assembly).GetTypes())
          {
            if (type == _type)
            {
              if (type.IsSubclassOf(typeof (Form)))
              {
                Form form = ObjectFactory.Instance.CreateForm(type);
                if (showAsDialog)
                {
                  int num = (int) form.ShowDialog();
                  form.Dispose();
                  break;
                }
                form.MdiParent = MDIControls.Instance.MDIParent;
                form.Show();
                break;
              }
              break;
            }
          }
        }
      }
    }
  }

  private void AccountingExplorer_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void formAccounting_Load(object sender, EventArgs e)
  {
    this.webBrowser1.Location = new Point(4, 4);
    this.webBrowser1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
  }

  private void GetContentPage(object sender, EventArgs e)
  {
    using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.URLFile.URLText.txt"))
    {
      using (StreamReader streamReader = new StreamReader(manifestResourceStream))
        this.webBrowser1.NavigateToString(streamReader.ReadToEnd());
    }
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  Guid IRecreatableEntity.EntityGuid => new Guid("{F21DF59D-87D7-479e-8F59-6E9B4D776EE4}");

  string IRecreatableEntity.EntityName => "Accounting";

  string IRecreatableEntity.FriendlyEntityName => "Accounting";

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid) => false;

  string IRecreatableEntity.RecreateTypeName => this.GetType().ToString();
}
