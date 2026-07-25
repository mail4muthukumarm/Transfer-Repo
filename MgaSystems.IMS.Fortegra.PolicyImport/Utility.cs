// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.Utility
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using System;
using System.Collections.Generic;
using System.Xml.Linq;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport;

internal static class Utility
{
  internal static XElement ImportLogIDsToXML(List<int> importLogIDs)
  {
    XElement returnValue = new XElement((XName) "ImportLogIDs");
    importLogIDs.ForEach((Action<int>) (x => returnValue.Add((object) new XElement((XName) "ImportLogID", (object) x))));
    return returnValue;
  }

  internal static XElement ImportLogIDsToXML(int importLogIDs)
  {
    return Utility.ImportLogIDsToXML(new List<int>()
    {
      importLogIDs
    });
  }
}
