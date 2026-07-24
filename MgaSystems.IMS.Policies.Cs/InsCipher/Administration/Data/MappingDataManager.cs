// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.InsCipher.Administration.Data.MappingDataManager
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using Mga.Wpf.Ims.ExtensionMethods;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.Validation;
using System.Collections.Generic;
using System.Data;
using System.Windows.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.InsCipher.Administration.Data;

public abstract class MappingDataManager : DataManager<MappingDataManager>
{
  protected override bool IsDesigning => Information.IsDesignMode;

  protected override object FetchData()
  {
    return (object) DefaultDatabase.ExecuteDataRow("dbo.InsCipher_GetLineImportCodesData");
  }

  protected override void BuildData(object dataResult)
  {
    if (dataResult is DataRow row1)
    {
      this.XmlInputData.XPath = "InsCipherData";
      XmlDataProviderExtensions.LoadXml(this.XmlInputData, row1.Field<string>(0));
    }
    this.ImportLines.AddRange((IEnumerable<LineImportCode>) DefaultDatabase.ExecuteMappedObjectSelectMultiple<LineImportCode>((System.Func<DataRow, LineImportCode>) (row => LineImportCode.Create(this))));
  }

  public XmlDataProvider XmlInputData { get; set; }

  [TrackChanges]
  [DisallowDuplicateValues("LineGUID")]
  public BulkObservableCollection<LineImportCode> ImportLines { get; private set; }

  public MappingDataManager(bool trackChanges)
    : base(trackChanges)
  {
    this.ImportLines = new BulkObservableCollection<LineImportCode>();
    this.XmlInputData = new XmlDataProvider();
  }
}
