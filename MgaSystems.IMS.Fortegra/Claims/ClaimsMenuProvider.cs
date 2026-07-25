// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Claims.ClaimsMenuProvider
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinExplorerBar;
using MGASystems.IMS.Claims;
using MgaSystems.Ims.Fortegra.Overrides.Claims;
using MgaSystems.Ims.Fortegra.Properties;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Claims;

public class ClaimsMenuProvider : IClaimsExplorerProvider
{
  public UltraExplorerBarGroup BuildExplorerMenu()
  {
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup("FORTEGRA");
    explorerBarGroup.Text = "Fortegra Claim Options";
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem("CLIM");
    ultraExplorerBarItem1.Text = "Claims Import";
    ((SubObjectBase) ultraExplorerBarItem1).Tag = (object) new ClaimsProviderExtensions(typeof (Fortegra_FormTPAClaimsImport), false, "{CE6B2331-B1E6-440C-AE1B-2B5BFC3E37B6}");
    ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance.Image = (object) Resources.arrow_in;
    explorerBarGroup.Items.Add(ultraExplorerBarItem1);
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem("CLTPA");
    ultraExplorerBarItem2.Text = "Claims TPA Management";
    ((SubObjectBase) ultraExplorerBarItem2).Tag = (object) new ClaimsProviderExtensions(typeof (Fortegra_FormTPAManagement), false, "{09E07D3A-9425-413E-A593-D63D0DAC426F}");
    ultraExplorerBarItem2.Settings.AppearancesSmall.Appearance.Image = (object) Resources.folder_edit;
    explorerBarGroup.Items.Add(ultraExplorerBarItem2);
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem("CCR");
    ultraExplorerBarItem3.Text = "Claims Close Reasons";
    ((SubObjectBase) ultraExplorerBarItem3).Tag = (object) new ClaimsProviderExtensions(typeof (Fortegra_FormClaimCloseReason), false, "0BE7E7AB-3829-4BD9-97A1-45EBF05FDC3B");
    ultraExplorerBarItem3.Settings.AppearancesSmall.Appearance.Image = (object) Resources.note_edit;
    explorerBarGroup.Items.Add(ultraExplorerBarItem3);
    return explorerBarGroup;
  }
}
