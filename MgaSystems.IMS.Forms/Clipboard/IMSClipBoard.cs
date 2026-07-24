// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Clipboard.IMSClipBoard
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Forms.Clipboard;

public sealed class IMSClipBoard
{
  private static IMSClipBoard _iMSClipBoard;
  private Hashtable _objectHash;

  public Guid Add(
    IMSClipBoard.ObjectStorage.CutCopyAction action,
    object from,
    string type,
    object value)
  {
    Guid key = Guid.NewGuid();
    this._objectHash.Add((object) key, (object) new IMSClipBoard.ObjectStorage(action, RuntimeHelpers.GetObjectValue(from), type, RuntimeHelpers.GetObjectValue(value)));
    return key;
  }

  private IMSClipBoard.ObjectStorage GetItemFromGUID(Guid id)
  {
    return (IMSClipBoard.ObjectStorage) RuntimeHelpers.GetObjectValue(this._objectHash[(object) id]);
  }

  private IMSClipBoard.ObjectStorage Remove(Guid id)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this._objectHash[(object) id]);
    this._objectHash.Remove((object) id);
    return (IMSClipBoard.ObjectStorage) objectValue;
  }

  public bool ContainsItemsOfType(string type) => this.QueryIdsOfType(type).Length > 0;

  public bool ContainsItemsFrom(object from)
  {
    bool flag;
    foreach (object obj in this._objectHash)
    {
      if (((IMSClipBoard.ObjectStorage) (obj != null ? (DictionaryEntry) obj : new DictionaryEntry()).Value).From == from)
      {
        flag = true;
        goto label_5;
      }
    }
    flag = false;
label_5:
    return flag;
  }

  private Guid[] QueryIdsOfType(string type)
  {
    ArrayList arrayList = new ArrayList();
    foreach (object obj in this._objectHash)
    {
      DictionaryEntry dictionaryEntry = obj != null ? (DictionaryEntry) obj : new DictionaryEntry();
      if (Operators.CompareString(((IMSClipBoard.ObjectStorage) dictionaryEntry.Value).ItemType, type, false) == 0)
        arrayList.Add(RuntimeHelpers.GetObjectValue(dictionaryEntry.Key));
    }
    return (Guid[]) arrayList.ToArray(typeof (Guid));
  }

  public IMSClipBoard.ObjectStorage[] QueryObjectsOfType(string type)
  {
    Guid[] guidArray1 = this.QueryIdsOfType(type);
    ArrayList arrayList = new ArrayList();
    Guid[] guidArray2 = guidArray1;
    int index = 0;
    while (index < guidArray2.Length)
    {
      Guid id = guidArray2[index];
      arrayList.Add((object) this.GetItemFromGUID(id));
      checked { ++index; }
    }
    return (IMSClipBoard.ObjectStorage[]) arrayList.ToArray(typeof (IMSClipBoard.ObjectStorage));
  }

  public IMSClipBoard.ObjectStorage[] RemoveObjectsOfType(string type)
  {
    Guid[] guidArray1 = this.QueryIdsOfType(type);
    ArrayList arrayList = new ArrayList();
    Guid[] guidArray2 = guidArray1;
    int index = 0;
    while (index < guidArray2.Length)
    {
      Guid id = guidArray2[index];
      arrayList.Add((object) this.Remove(id));
      checked { ++index; }
    }
    return (IMSClipBoard.ObjectStorage[]) arrayList.ToArray(typeof (IMSClipBoard.ObjectStorage));
  }

  private IMSClipBoard()
  {
    this._objectHash = new Hashtable();
    MDIControls.Instance.MDIParent.Closing += new CancelEventHandler(this.MDIParent_Closing);
  }

  public static IMSClipBoard Instance
  {
    get
    {
      if (IMSClipBoard._iMSClipBoard == null)
        IMSClipBoard._iMSClipBoard = new IMSClipBoard();
      return IMSClipBoard._iMSClipBoard;
    }
  }

  private void MDIParent_Closing(object sender, CancelEventArgs e)
  {
    MDIControls.Instance.MDIParent.Closing -= new CancelEventHandler(this.MDIParent_Closing);
    this._objectHash.Clear();
  }

  public class ObjectStorage
  {
    private object _from;
    private string _type;
    private object _val;
    private IMSClipBoard.ObjectStorage.CutCopyAction _action;

    public ObjectStorage(
      IMSClipBoard.ObjectStorage.CutCopyAction action,
      object from,
      string objectType,
      object objectValue)
    {
      this._from = RuntimeHelpers.GetObjectValue(from);
      this._type = objectType;
      this._val = RuntimeHelpers.GetObjectValue(objectValue);
      this._action = action;
    }

    public override string ToString() => "Not Implemented";

    public string ItemType => this._type;

    public object From => this._from;

    public IMSClipBoard.ObjectStorage.CutCopyAction Action => this._action;

    public object ItemValue => this._val;

    public enum CutCopyAction
    {
      Cut,
      Copy,
    }
  }
}
