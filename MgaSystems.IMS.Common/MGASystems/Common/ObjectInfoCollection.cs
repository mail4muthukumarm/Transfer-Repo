// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ObjectInfoCollection
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

#nullable disable
namespace MGASystems.Common;

[Serializable]
internal sealed class ObjectInfoCollection : List<ObjectInfo>
{
  private string _version;
  private string _assemblyName;

  public ObjectInfoCollection()
  {
  }

  public ObjectInfoCollection(string version, string assemblyName)
  {
    this._assemblyName = assemblyName;
    this._version = version;
  }

  public static void SaveToBinaryFile(string fileName, ObjectInfoCollection collection)
  {
    FileStream serializationStream = new FileStream(fileName, FileMode.Create);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    try
    {
      binaryFormatter.Serialize((Stream) serializationStream, (object) collection);
    }
    finally
    {
      serializationStream.Close();
    }
  }

  public static ObjectInfoCollection LoadFromBinaryFile(string fileName)
  {
    ObjectInfoCollection objectInfoCollection1 = (ObjectInfoCollection) null;
    ObjectInfoCollection objectInfoCollection2;
    if (File.Exists(fileName))
    {
      FileStream serializationStream = new FileStream(fileName, FileMode.Open);
      try
      {
        objectInfoCollection1 = (ObjectInfoCollection) new BinaryFormatter().Deserialize((Stream) serializationStream);
      }
      finally
      {
        serializationStream.Close();
      }
      objectInfoCollection2 = objectInfoCollection1;
    }
    else
      objectInfoCollection2 = (ObjectInfoCollection) null;
    return objectInfoCollection2;
  }

  public string Version => this._version;

  public string AssemblyName => this._assemblyName;

  public int Add(string objectName, string baseClass, string assemblyName)
  {
    ObjectInfo objectInfo = new ObjectInfo(objectName, baseClass, assemblyName);
    if (this.Contains(objectInfo))
      throw new ObjectFactoryException(SR.GetString("OF_OverrideOnce", (object) baseClass, (object) assemblyName));
    this.Add(objectInfo);
    int num;
    return num;
  }

  public new ObjectInfo this[int index] => base[index];

  internal ObjectInfo GetItemFromType(Type baseType)
  {
    string fullName = baseType.FullName;
    ObjectInfo itemFromType;
    try
    {
      foreach (ObjectInfo objectInfo in (List<ObjectInfo>) this)
      {
        if (Operators.CompareString(objectInfo.BaseClass, fullName, false) == 0)
        {
          itemFromType = objectInfo;
          goto label_7;
        }
      }
    }
    finally
    {
      List<ObjectInfo>.Enumerator enumerator;
      enumerator.Dispose();
    }
    itemFromType = (ObjectInfo) null;
label_7:
    return itemFromType;
  }
}
