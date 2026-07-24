// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.InsCipher.Administration.Commands.MappingCommands
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using MgaSystems.IMS.Policies.InsCipher.Administration.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Data;
using System.Xml;

#nullable disable
namespace MgaSystems.IMS.Policies.InsCipher.Administration.Commands;

public static class MappingCommands
{
  public static RelayCommand<MappingDataManager> AddLineMapping
  {
    get
    {
      return new RelayCommand<MappingDataManager>((Action<MappingDataManager>) (dataManager =>
      {
        LineImportCode lineImportCode = LineImportCode.Create(dataManager);
        ((Collection<LineImportCode>) dataManager.ImportLines).Add(lineImportCode);
        CollectionViewSource.GetDefaultView((object) dataManager.ImportLines).MoveCurrentTo((object) lineImportCode);
      }), (Predicate<MappingDataManager>) (dataManager => dataManager != null && dataManager.XmlInputData.Document != null && ((Collection<LineImportCode>) dataManager.ImportLines).Count < dataManager.XmlInputData.Document.SelectNodes("InsCipherData/Lines/Line/@LineGUID").Count));
    }
  }

  public static RelayCommand<MappingDataManager> AddAllLines
  {
    get
    {
      return new RelayCommand<MappingDataManager>((Action<MappingDataManager>) (dataManager =>
      {
        HashSet<Guid> existingLines = new HashSet<Guid>(((IEnumerable<LineImportCode>) dataManager.ImportLines).Select<LineImportCode, Guid>((Func<LineImportCode, Guid>) (il => il.LineGUID)));
        existingLines.Remove(Guid.Empty);
        List<Guid> list = dataManager.XmlInputData.Document.SelectNodes("InsCipherData/Lines/Line").OfType<XmlNode>().Where<XmlNode>((Func<XmlNode, bool>) (x => x.Attributes["LineGUID"] != null)).Select<XmlNode, Guid>((Func<XmlNode, Guid>) (x => Guid.Parse(x.Attributes["LineGUID"].Value))).ToList<Guid>();
        foreach (LineImportCode lineImportCode in list.Where<Guid>((Func<Guid, bool>) (lg => !existingLines.Contains(lg))).Take<Guid>(list.Count - ((Collection<LineImportCode>) dataManager.ImportLines).Count).Select<Guid, LineImportCode>((Func<Guid, LineImportCode>) (lg => LineImportCode.Create(dataManager, lg))))
          ((Collection<LineImportCode>) dataManager.ImportLines).Add(lineImportCode);
        CollectionViewSource.GetDefaultView((object) dataManager.ImportLines).MoveCurrentTo((object) ((IEnumerable<LineImportCode>) dataManager.ImportLines).Last<LineImportCode>());
      }), (Predicate<MappingDataManager>) (dataManager => dataManager != null && dataManager.XmlInputData.Document != null && ((Collection<LineImportCode>) dataManager.ImportLines).Count < dataManager.XmlInputData.Document.SelectNodes("InsCipherData/Lines/Line/@LineGUID").Count));
    }
  }

  public static RelayCommand<IList> DeleteLineMappings
  {
    get
    {
      return new RelayCommand<IList>((Action<IList>) (collection =>
      {
        IEnumerable<LineImportCode> source = collection.OfType<LineImportCode>();
        if (source == null)
          return;
        foreach (LineImportCode lineImportCode in source.ToList<LineImportCode>())
          ((Collection<LineImportCode>) lineImportCode.Parent.ImportLines).Remove(lineImportCode);
      }), (Predicate<IList>) (collection => collection != null && collection.Count > 0));
    }
  }
}
