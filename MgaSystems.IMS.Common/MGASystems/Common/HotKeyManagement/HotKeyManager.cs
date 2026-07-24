// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.HotKeyManagement.HotKeyManager
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.HotKeyManagement;

[Preference("Toolbars.HotKeys.Visible", true)]
public sealed class HotKeyManager : IDisposable, IMenuConsumer, IComparer<HotKeyInfoAttribute>
{
  public const string PREFERENCE_SHOWHOTKEYS = "Toolbars.HotKeys.Visible";
  private Dictionary<Keys, Type> _hotKeyList;
  private Dictionary<string, HotKeyInfoAttribute> _hotKeyInfoHash;
  private const string _keyPrefix = "HK_";
  private Form _mdiForm;
  private static HotKeyManager _hotKeyManager;
  private KeysConverter _keyConverter;
  private UltraToolbarsManager _menu;
  private ISecurityManager _securityManager;

  public static event CancelEventHandler LoadingHotKeyInfoType;

  public static HotKeyManager GetInstance(Form mdiParent, ISecurityManager securityManager)
  {
    if (HotKeyManager._hotKeyManager == null)
    {
      HotKeyManager._hotKeyManager = (HotKeyManager) ObjectFactory.Instance.CreateObject(typeof (HotKeyManager), new object[1]
      {
        (object) mdiParent
      });
      HotKeyManager._hotKeyManager._securityManager = securityManager;
    }
    return HotKeyManager._hotKeyManager;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public HotKeyManager(Form mdiform)
  {
    this._hotKeyList = new Dictionary<Keys, Type>();
    this._hotKeyInfoHash = new Dictionary<string, HotKeyInfoAttribute>();
    this._keyConverter = new KeysConverter();
    this._mdiForm = mdiform;
    this._mdiForm.KeyUp += new KeyEventHandler(this.mdiForm_KeyUp);
  }

  private void ResetHotKeyInfoList()
  {
    this._hotKeyInfoHash.Clear();
    this._hotKeyInfoHash = (Dictionary<string, HotKeyInfoAttribute>) null;
  }

  private Dictionary<string, HotKeyInfoAttribute> HotKeyInfoList
  {
    get
    {
      if (this._hotKeyInfoHash == null)
      {
        if (this._hotKeyList != null)
          this._hotKeyList.Clear();
        this._hotKeyInfoHash = new Dictionary<string, HotKeyInfoAttribute>();
        HotKeyInfoAttribute searchAttribute1 = new HotKeyInfoAttribute();
        SecureHotkeyResourceAttribute searchAttribute2 = new SecureHotkeyResourceAttribute();
        Type[] resolvedTypes = ObjectFactory.Instance.GetResolvedTypes(ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) searchAttribute1));
        int index = 0;
        while (index < resolvedTypes.Length)
        {
          Type type = resolvedTypes[index];
          CancelEventArgs e = new CancelEventArgs();
          CancelEventHandler keyInfoTypeEvent = HotKeyManager.LoadingHotKeyInfoTypeEvent;
          if (keyInfoTypeEvent != null)
            keyInfoTypeEvent((object) type, e);
          if (!e.Cancel)
          {
            Attribute attributeFromType1 = ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute1);
            if (attributeFromType1 != null)
            {
              searchAttribute1 = (HotKeyInfoAttribute) attributeFromType1;
              Attribute attributeFromType2 = ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute2);
              if (attributeFromType2 == null)
              {
                if (!this._hotKeyList.ContainsKey(searchAttribute1.HotKey))
                {
                  this._hotKeyList.Add(searchAttribute1.HotKey, type);
                  this._hotKeyInfoHash.Add(searchAttribute1.Key, searchAttribute1);
                }
              }
              else if (this._securityManager.AssertPermission(((SecureResourceAttribute) attributeFromType2).UniqueIdentifier, 0) && !this._hotKeyList.ContainsKey(searchAttribute1.HotKey))
              {
                this._hotKeyList.Add(searchAttribute1.HotKey, type);
                this._hotKeyInfoHash.Add(searchAttribute1.Key, searchAttribute1);
              }
            }
          }
          checked { ++index; }
        }
      }
      return this._hotKeyInfoHash;
    }
  }

  public void Dispose()
  {
    this._mdiForm.KeyUp -= new KeyEventHandler(this.mdiForm_KeyUp);
    this._mdiForm.Dispose();
  }

  private void mdiForm_KeyUp(object sender, KeyEventArgs e)
  {
    if (!this._hotKeyList.ContainsKey(e.KeyData))
      return;
    this.PressHotKeys(e.KeyData);
  }

  public void PressHotKeys(Keys keys)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(this._hotKeyList[keys]));
    IHotKeyDisplayItem hotKeyDisplayItem = ObjectFactory.QueryInterface<IHotKeyDisplayItem>(RuntimeHelpers.GetObjectValue(objectValue));
    if (objectValue is Form form)
    {
      if (hotKeyDisplayItem != null)
      {
        hotKeyDisplayItem.ShowItem();
      }
      else
      {
        form.MdiParent = this._mdiForm;
        form.Show();
      }
    }
    else
    {
      if (hotKeyDisplayItem == null)
        throw new InvalidOperationException("If the typeof the HotKey item is not a form, you must implement the HotKeyDisplayItem attribute to tell the framework how to display you");
      hotKeyDisplayItem.ShowItem();
    }
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key.Replace("HK_", string.Empty);
    if (!this.HotKeyInfoList.ContainsKey(key))
      return;
    this.PressHotKeys(this.HotKeyInfoList[key].HotKey);
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void ResetHotKeys()
  {
    this.ResetHotKeyInfoList();
    if (!((KeyedSubObjectsCollectionBase) this._menu.Toolbars).Exists("QuickLaunch"))
    {
      UltraToolbar ultraToolbar = this._menu.Toolbars.AddToolbar("QuickLaunch");
      ultraToolbar.DockedPosition = (DockedPosition) 1;
      ultraToolbar.Text = "Quick Launch";
      List<HotKeyInfoAttribute> keyInfoAttributeList = new List<HotKeyInfoAttribute>();
      try
      {
        foreach (KeyValuePair<string, HotKeyInfoAttribute> hotKeyInfo in this.HotKeyInfoList)
          keyInfoAttributeList.Add(hotKeyInfo.Value);
      }
      finally
      {
        Dictionary<string, HotKeyInfoAttribute>.Enumerator enumerator;
        enumerator.Dispose();
      }
      keyInfoAttributeList.Sort((IComparer<HotKeyInfoAttribute>) this);
      int num = keyInfoAttributeList.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        HotKeyInfoAttribute keyInfoAttribute = keyInfoAttributeList[index];
        string str = "HK_" + keyInfoAttribute.Key;
        ButtonTool buttonTool1 = new ButtonTool(str);
        ButtonTool buttonTool2 = buttonTool1;
        ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).Caption = $"{keyInfoAttribute.Text} [{keyInfoAttribute.KeyText}]";
        ((ToolBase) buttonTool2).SharedProps.ToolTipText = keyInfoAttribute.ToolTip;
        ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
        ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).AppearancesLarge.Appearance.Image = (object) keyInfoAttribute.Image;
        ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).AppearancesSmall.Appearance.Image = (object) keyInfoAttribute.Image;
        this._menu.Tools.Add((ToolBase) buttonTool1);
        ((UltraToolbarBase) this._menu.Toolbars["QuickLaunch"]).Tools.AddTool(str);
      }
    }
    else
    {
      UltraToolbar toolbar = this._menu.Toolbars["QuickLaunch"];
      for (int index = ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools).Count - 1; index >= 0; index += -1)
        this._menu.Tools.Remove(((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)[index]);
      ((UltraToolbarBase) toolbar).Tools.Clear();
      List<HotKeyInfoAttribute> keyInfoAttributeList = new List<HotKeyInfoAttribute>();
      try
      {
        foreach (KeyValuePair<string, HotKeyInfoAttribute> hotKeyInfo in this.HotKeyInfoList)
          keyInfoAttributeList.Add(hotKeyInfo.Value);
      }
      finally
      {
        Dictionary<string, HotKeyInfoAttribute>.Enumerator enumerator;
        enumerator.Dispose();
      }
      int num = keyInfoAttributeList.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        HotKeyInfoAttribute keyInfoAttribute = keyInfoAttributeList[index];
        string str = "HK_" + keyInfoAttribute.Key;
        ButtonTool buttonTool3 = new ButtonTool(str);
        ButtonTool buttonTool4 = buttonTool3;
        ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = $"{keyInfoAttribute.Text} [{keyInfoAttribute.KeyText}]";
        ((ToolBase) buttonTool4).SharedProps.ToolTipText = keyInfoAttribute.ToolTip;
        ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
        ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesLarge.Appearance.Image = (object) keyInfoAttribute.Image;
        ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance.Image = (object) keyInfoAttribute.Image;
        this._menu.Tools.Add((ToolBase) buttonTool3);
        ((UltraToolbarBase) toolbar).Tools.AddTool(str);
      }
    }
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu) => this._menu = menu;

  public int Compare(HotKeyInfoAttribute x, HotKeyInfoAttribute y)
  {
    int num;
    if (x.HotKey.ToString().StartsWith("F") && y.HotKey.ToString().StartsWith("F"))
    {
      int integer1 = Conversions.ToInteger(x.KeyText.Replace("F", string.Empty));
      int integer2 = Conversions.ToInteger(y.KeyText.Replace("F", string.Empty));
      num = integer1 != integer2 ? (integer1 <= integer2 ? -1 : 1) : 0;
    }
    else
      num = !x.KeyText.StartsWith("Ctrl") ? (!y.KeyText.StartsWith("Ctrl") ? this._keyConverter.Compare((object) x.HotKey, (object) y.HotKey) : -1) : 1;
    return num;
  }
}
