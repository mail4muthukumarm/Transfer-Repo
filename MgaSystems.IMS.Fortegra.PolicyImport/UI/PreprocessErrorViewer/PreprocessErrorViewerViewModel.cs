// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PreprocessErrorViewer.PreprocessErrorViewerViewModel
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data.Binding;
using MgaSystems.Ims.Fortegra.PolicyImport.Data;
using MgaSystems.Ims.Fortegra.PolicyImport.Model;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI.PreprocessErrorViewer;

public abstract class PreprocessErrorViewerViewModel : BindingObject
{
  [NotificationProperty]
  public virtual PolicyImportDataManager PolicyImportDataManager { get; set; }

  [NotificationProperty]
  public virtual BulkObservableCollection<ImportPreprocessErrorItem> PreprocessErrorList { get; set; } = new BulkObservableCollection<ImportPreprocessErrorItem>();

  internal static PreprocessErrorViewerViewModel Create(PolicyImportDataManager pidm)
  {
    return NotifyProxyTypeManager.Allocate<PreprocessErrorViewerViewModel>(new object[1]
    {
      (object) pidm
    });
  }

  public PreprocessErrorViewerViewModel(PolicyImportDataManager pidm)
  {
    this.PolicyImportDataManager = pidm;
    this.PreprocessErrorList.AddRange((IEnumerable<ImportPreprocessErrorItem>) pidm.ImportLogPreprocessErrorList);
  }
}
