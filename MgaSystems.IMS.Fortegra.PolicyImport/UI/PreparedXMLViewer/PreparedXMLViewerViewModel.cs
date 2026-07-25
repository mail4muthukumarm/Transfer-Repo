// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.UI.PreparedXMLViewer.PreparedXMLViewerViewModel
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Mga.Wpf.Ims.DialogService;
using MGASystems.Data.Binding;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport.UI.PreparedXMLViewer;

public abstract class PreparedXMLViewerViewModel : BindingObject
{
  private readonly IWinMsgBoxService msgBoxSvc;

  [NotificationProperty]
  public virtual string ImportXMLAsString { get; set; }

  internal static PreparedXMLViewerViewModel Create(
    IWinMsgBoxService msgBoxService,
    string importXMLAsString)
  {
    return NotifyProxyTypeManager.Allocate<PreparedXMLViewerViewModel>(new object[2]
    {
      (object) msgBoxService,
      (object) importXMLAsString
    });
  }

  public PreparedXMLViewerViewModel(IWinMsgBoxService msgBoxService, string importXMLAsString)
  {
    this.msgBoxSvc = msgBoxService;
    this.ImportXMLAsString = importXMLAsString;
  }
}
