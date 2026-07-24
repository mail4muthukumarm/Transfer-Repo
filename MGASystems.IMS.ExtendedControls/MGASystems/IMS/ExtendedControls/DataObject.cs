// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.ExtendedControls.DataObject
// Assembly: MGASystems.IMS.ExtendedControls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 933BCBB6-80B3-406B-A226-C528DBCF94BC
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.ExtendedControls.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.ExtendedControls;

public sealed class DataObject(IDataObject* pDataObject) : System.Windows.Forms.IDataObject
{
  private unsafe IDataObject* m_pDataObject = pDataObject;

  public unsafe string[] GetFormats([MarshalAs(UnmanagedType.U1)] bool autoConvert)
  {
    List<string> stringList = new List<string>();
    IDataObject* pDataObject = this.m_pDataObject;
    IDataObject* idataObjectPtr = pDataObject;
    IEnumFORMATETC* ienumFormatetcPtr1;
    ref IEnumFORMATETC* local1 = ref ienumFormatetcPtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num1 = __calli((delegate* unmanaged[Stdcall]<IntPtr, uint, IEnumFORMATETC**, int>) *(int*) (*(int*) pDataObject + 32 /*0x20*/))((IntPtr) idataObjectPtr, 1U, (IEnumFORMATETC**) ref local1);
    uint num2;
    do
    {
      IEnumFORMATETC* ienumFormatetcPtr2 = ienumFormatetcPtr1;
      tagFORMATETC tagFormatetc;
      ref tagFORMATETC local2 = ref tagFormatetc;
      ref uint local3 = ref num2;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num3 = __calli((delegate* unmanaged[Stdcall]<IntPtr, uint, tagFORMATETC*, uint*, int>) *(int*) (*(int*) ienumFormatetcPtr1 + 12))((IntPtr) ienumFormatetcPtr2, 1U, (tagFORMATETC*) ref local2, (uint*) ref local3);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      DataFormats.Format format = DataFormats.GetFormat((int) ^(ushort&) ref tagFormatetc);
      if (!stringList.Contains(format.Name))
        stringList.Add(format.Name);
    }
    while (num2 != 0U);
    if (stringList.Contains("RenPrivateMessages") && stringList.Contains("RenPrivateSourceFolder") && stringList.Contains("FileGroupDescriptor") && stringList.Contains("FileContents") && stringList.Contains("Object Descriptor") && stringList.Contains("Text"))
      stringList.Add("Outlook.Message");
    else if (stringList.Contains("FileGroupDescriptor") && stringList.Contains("FileContents") && stringList.Contains("Text") && stringList.Contains("UnicodeText"))
      stringList.Add("Outlook.Attachment");
    return stringList.ToArray();
  }

  public string[] GetFormats() => this.GetFormats(true);

  public void SetData(string format, [MarshalAs(UnmanagedType.U1)] bool autoConvert, object data)
  {
    throw new NotSupportedException("The advanced drop target does not support setting data");
  }

  public void SetData(string format, object data)
  {
    throw new NotSupportedException("The advanced drop target does not support setting data");
  }

  public void SetData(System.Type format, object data)
  {
    throw new NotSupportedException("The advanced drop target does not support setting data");
  }

  public void SetData(object data)
  {
    throw new NotSupportedException("The advanced drop target does not support setting data");
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool GetDataPresent(string format, [MarshalAs(UnmanagedType.U1)] bool autoConvert)
  {
    if (format == (string) null)
      throw new ArgumentNullException("format can not be null");
    switch (format)
    {
      case "Outlook.Message":
      case "Outlook.Messages":
        if (this.SupportsFormat("RenPrivateMessages", 4U) && this.SupportsFormat("RenPrivateSourceFolder", 4U) && this.SupportsFormat("FileGroupDescriptor", 1U) && this.SupportsFormat("FileContents", 12U) && this.SupportsFormat("Object Descriptor", 1U) && this.SupportsFormat("Text", 1U))
          return true;
        break;
      case "Outlook.Attachment":
      case "Outlook.Attachments":
        if (this.SupportsFormat("FileGroupDescriptor", 1U) && this.SupportsFormat("FileContents", 12U) && this.SupportsFormat("Text", 1U) && this.SupportsFormat("UnicodeText", 1U))
          return true;
        break;
      default:
        if (this.SupportsFormat(format, 1U))
          return true;
        if (autoConvert)
        {
          MethodInfo method = typeof (System.Windows.Forms.DataObject).GetMethod("GetMappedFormats", BindingFlags.Static | BindingFlags.NonPublic, (Binder) null, new System.Type[1]
          {
            typeof (string)
          }, (ParameterModifier[]) null);
          System.Windows.Forms.DataObject dataObject1 = new System.Windows.Forms.DataObject();
          object[] objArray = new object[1]
          {
            (object) format
          };
          System.Windows.Forms.DataObject dataObject2 = dataObject1;
          object[] parameters = objArray;
          if (method.Invoke((object) dataObject2, parameters) != null)
            return true;
          break;
        }
        break;
    }
    return false;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  public bool GetDataPresent(string format) => this.GetDataPresent(format, true);

  [return: MarshalAs(UnmanagedType.U1)]
  public bool GetDataPresent(System.Type format)
  {
    return format != null ? this.GetDataPresent(format.FullName) : throw new ArgumentNullException("format can not be null");
  }

  private static unsafe tagFORMATETC FomatFromString(string format)
  {
    DataFormats.Format format1 = DataFormats.GetFormat(format);
    tagFORMATETC tagFormatetc;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ref tagFormatetc = (short) format1.Id;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 12) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 16 /*0x10*/) = 1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 8) = 1;
    return tagFormatetc;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  private bool SupportsFormat(string format) => this.SupportsFormat(format, 1U);

  [return: MarshalAs(UnmanagedType.U1)]
  private unsafe bool SupportsFormat(string format, uint tymed)
  {
    DataFormats.Format format1 = DataFormats.GetFormat(format);
    tagFORMATETC tagFormatetc1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ref tagFormatetc1 = (short) format1.Id;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 12) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 16 /*0x10*/) = 1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 8) = 1;
    tagFORMATETC tagFormatetc2 = tagFormatetc1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc2 + 16 /*0x10*/) = (int) tymed;
    IDataObject* pDataObject = this.m_pDataObject;
    IDataObject* idataObjectPtr = pDataObject;
    ref tagFORMATETC local = ref tagFormatetc2;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObject + 20))((IntPtr) idataObjectPtr, (tagFORMATETC*) ref local) < 0)
      return false;
    string[] formats = this.GetFormats(true);
    int index = 0;
    if (0 < formats.Length)
    {
      while (!formats[index].Equals(format))
      {
        ++index;
        if (index >= formats.Length)
          goto label_5;
      }
      return true;
    }
label_5:
    return false;
  }

  public unsafe object GetData(string format, [MarshalAs(UnmanagedType.U1)] bool autoConvert)
  {
    if (!this.GetDataPresent(format, autoConvert))
      return (object) null;
    IDataObject* pDataObject = this.m_pDataObject;
    object data = \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetData(format, -1, pDataObject, 1U, 1U);
    if (data == null && autoConvert)
    {
      MethodInfo method = typeof (System.Windows.Forms.DataObject).GetMethod("GetMappedFormats", BindingFlags.Static | BindingFlags.NonPublic, (Binder) null, new System.Type[1]
      {
        typeof (string)
      }, (ParameterModifier[]) null);
      System.Windows.Forms.DataObject dataObject1 = new System.Windows.Forms.DataObject();
      object[] objArray = new object[1]{ (object) format };
      System.Windows.Forms.DataObject dataObject2 = dataObject1;
      object[] parameters = objArray;
      object obj = method.Invoke((object) dataObject2, parameters);
      if (obj == null)
        return (object) null;
      string[] strArray = (string[]) obj;
      int index = 0;
      if (0 < strArray.Length)
      {
        do
        {
          data = \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetData(strArray[index], -1, this.m_pDataObject, 1U, 1U);
          if (data == null)
            ++index;
          else
            goto label_6;
        }
        while (index < strArray.Length);
        goto label_8;
label_6:
        return data;
      }
    }
label_8:
    return data;
  }

  public object GetData(string format) => this.GetData(format, true);

  public object GetData(System.Type format) => this.GetData(format.FullName);
}
