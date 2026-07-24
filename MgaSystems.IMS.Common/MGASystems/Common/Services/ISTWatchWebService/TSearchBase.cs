// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Services.ISTWatchWebService.TSearchBase
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.Services.ISTWatchWebService;

[XmlInclude(typeof (WsIstWatch))]
[GeneratedCode("System.Xml", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.intelligentsearch.com/HostedWebServices/")]
[Serializable]
public class TSearchBase
{
  private string nameField;
  private string idField;
  private string streetField;
  private string cityField;
  private string stateField;
  private string countryField;
  private string dupIDField;
  private string phoneField;
  private string dateEnteredField;
  private string memoField;
  private string bALKANSField;
  private string bPIPAField;
  private string cUBAField;
  private string dPLField;
  private string fRYMField;
  private string fTOField;
  private string iRANField;
  private string iRAQField;
  private string lIBYAField;
  private string nKOREAField;
  private string sDGTField;
  private string sDNTField;
  private string sDNTKField;
  private string sDTField;
  private string sUDANField;
  private string tALIBANField;
  private string uNITAField;
  private string sDNTypeField;
  private string programField;
  private string titleField;
  private string callSignField;
  private string vessTypeField;
  private string tonnageField;
  private string gRTField;
  private string vessFlagField;
  private string vessOwnerField;
  private string addNumField;
  private string addRemarksField;
  private string postalCodeField;
  private string effectiveDateField;
  private string expirationDateField;
  private string standardOrderField;
  private string nameSearchKeyField;
  private string scoreField;
  private string returnCodesField;
  private string errorDescField;
  private string searchesLeftField;

  public string Name
  {
    get => this.nameField;
    set => this.nameField = value;
  }

  public string ID
  {
    get => this.idField;
    set => this.idField = value;
  }

  public string Street
  {
    get => this.streetField;
    set => this.streetField = value;
  }

  public string City
  {
    get => this.cityField;
    set => this.cityField = value;
  }

  public string State
  {
    get => this.stateField;
    set => this.stateField = value;
  }

  public string Country
  {
    get => this.countryField;
    set => this.countryField = value;
  }

  public string DupID
  {
    get => this.dupIDField;
    set => this.dupIDField = value;
  }

  public string Phone
  {
    get => this.phoneField;
    set => this.phoneField = value;
  }

  public string DateEntered
  {
    get => this.dateEnteredField;
    set => this.dateEnteredField = value;
  }

  public string Memo
  {
    get => this.memoField;
    set => this.memoField = value;
  }

  public string BALKANS
  {
    get => this.bALKANSField;
    set => this.bALKANSField = value;
  }

  public string BPIPA
  {
    get => this.bPIPAField;
    set => this.bPIPAField = value;
  }

  public string CUBA
  {
    get => this.cUBAField;
    set => this.cUBAField = value;
  }

  public string DPL
  {
    get => this.dPLField;
    set => this.dPLField = value;
  }

  public string FRYM
  {
    get => this.fRYMField;
    set => this.fRYMField = value;
  }

  public string FTO
  {
    get => this.fTOField;
    set => this.fTOField = value;
  }

  public string IRAN
  {
    get => this.iRANField;
    set => this.iRANField = value;
  }

  public string IRAQ
  {
    get => this.iRAQField;
    set => this.iRAQField = value;
  }

  public string LIBYA
  {
    get => this.lIBYAField;
    set => this.lIBYAField = value;
  }

  public string NKOREA
  {
    get => this.nKOREAField;
    set => this.nKOREAField = value;
  }

  public string SDGT
  {
    get => this.sDGTField;
    set => this.sDGTField = value;
  }

  public string SDNT
  {
    get => this.sDNTField;
    set => this.sDNTField = value;
  }

  public string SDNTK
  {
    get => this.sDNTKField;
    set => this.sDNTKField = value;
  }

  public string SDT
  {
    get => this.sDTField;
    set => this.sDTField = value;
  }

  public string SUDAN
  {
    get => this.sUDANField;
    set => this.sUDANField = value;
  }

  public string TALIBAN
  {
    get => this.tALIBANField;
    set => this.tALIBANField = value;
  }

  public string UNITA
  {
    get => this.uNITAField;
    set => this.uNITAField = value;
  }

  public string SDNType
  {
    get => this.sDNTypeField;
    set => this.sDNTypeField = value;
  }

  public string Program
  {
    get => this.programField;
    set => this.programField = value;
  }

  public string Title
  {
    get => this.titleField;
    set => this.titleField = value;
  }

  public string CallSign
  {
    get => this.callSignField;
    set => this.callSignField = value;
  }

  public string VessType
  {
    get => this.vessTypeField;
    set => this.vessTypeField = value;
  }

  public string Tonnage
  {
    get => this.tonnageField;
    set => this.tonnageField = value;
  }

  public string GRT
  {
    get => this.gRTField;
    set => this.gRTField = value;
  }

  public string VessFlag
  {
    get => this.vessFlagField;
    set => this.vessFlagField = value;
  }

  public string VessOwner
  {
    get => this.vessOwnerField;
    set => this.vessOwnerField = value;
  }

  public string AddNum
  {
    get => this.addNumField;
    set => this.addNumField = value;
  }

  public string AddRemarks
  {
    get => this.addRemarksField;
    set => this.addRemarksField = value;
  }

  public string PostalCode
  {
    get => this.postalCodeField;
    set => this.postalCodeField = value;
  }

  public string EffectiveDate
  {
    get => this.effectiveDateField;
    set => this.effectiveDateField = value;
  }

  public string ExpirationDate
  {
    get => this.expirationDateField;
    set => this.expirationDateField = value;
  }

  public string StandardOrder
  {
    get => this.standardOrderField;
    set => this.standardOrderField = value;
  }

  public string NameSearchKey
  {
    get => this.nameSearchKeyField;
    set => this.nameSearchKeyField = value;
  }

  public string Score
  {
    get => this.scoreField;
    set => this.scoreField = value;
  }

  public string ReturnCodes
  {
    get => this.returnCodesField;
    set => this.returnCodesField = value;
  }

  public string ErrorDesc
  {
    get => this.errorDescField;
    set => this.errorDescField = value;
  }

  public string SearchesLeft
  {
    get => this.searchesLeftField;
    set => this.searchesLeftField = value;
  }
}
