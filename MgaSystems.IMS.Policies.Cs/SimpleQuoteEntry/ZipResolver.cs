// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.ZipResolver
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.AddressResolver;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry;

public class ZipResolver
{
  public string City { get; set; }

  public string State { get; set; }

  public string County { get; set; }

  public string ZipCode { get; set; }

  public bool IsInternational { get; set; }

  public bool IsUnknownZipCode { get; set; }

  public void ResolveZipCode(string zipCode)
  {
    this.ZipCode = zipCode;
    Address[] addressArray = (Address[]) null;
    if (string.IsNullOrEmpty(zipCode))
      return;
    if (zipCode.Length != 5)
      return;
    try
    {
      addressArray = new AddressChecker().ZipToLocality(zipCode);
    }
    catch
    {
    }
    if (addressArray == null)
      return;
    if (addressArray.Length == 1)
    {
      this.City = addressArray[0].City;
      this.State = addressArray[0].StateAbbriv;
      this.County = addressArray[0].County;
    }
    else if (addressArray.Length > 1)
    {
      using (frmMultiLocaleZip frmMultiLocaleZip = new frmMultiLocaleZip())
      {
        frmMultiLocaleZip.ZipCode = this.ZipCode;
        frmMultiLocaleZip.LocalesList = addressArray;
        int num = (int) ((Form) frmMultiLocaleZip).ShowDialog();
        if (frmMultiLocaleZip.SelectedLocale == null)
          return;
        this.ZipCode = frmMultiLocaleZip.SelectedLocale.Zip;
        this.City = frmMultiLocaleZip.SelectedLocale.City;
        this.County = frmMultiLocaleZip.SelectedLocale.County;
        this.State = frmMultiLocaleZip.SelectedLocale.StateAbbriv;
      }
    }
    else
    {
      this.IsUnknownZipCode = true;
      this.City = "";
      this.County = "";
      this.State = "";
    }
  }
}
