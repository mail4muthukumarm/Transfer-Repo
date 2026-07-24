// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.SearchCriteria
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class SearchCriteria
{
  private Guid searchGuid;
  private string searchPayeeName;
  private Utility.PayablesSearchType pSearchType;
  private Utility.ReceivablesSearchType rSearchType;
  private int searchInteger;
  private string searchString;
  private DateTime searchDate;
  private bool showZeros;
  private Guid entityGuid;

  public SearchCriteria()
  {
  }

  public SearchCriteria(
    Utility.PayablesSearchType searchType,
    Guid searchForGuid,
    string payeeName,
    int searchForInteger,
    string searchForString,
    DateTime searchDate,
    Guid entityGuid)
  {
    this.pSearchType = searchType;
    this.searchGuid = searchForGuid;
    this.searchPayeeName = payeeName;
    this.searchInteger = searchForInteger;
    this.searchString = searchForString;
    this.searchDate = searchDate;
    this.entityGuid = entityGuid;
  }

  public SearchCriteria(
    Utility.ReceivablesSearchType searchType,
    Guid searchForGuid,
    int searchForInteger,
    string searchForString,
    Guid entityGuid)
  {
    this.rSearchType = searchType;
    this.searchGuid = searchForGuid;
    this.searchInteger = searchForInteger;
    this.searchString = searchForString;
    this.entityGuid = entityGuid;
  }

  public Utility.PayablesSearchType PayableSearchType
  {
    get => this.pSearchType;
    set => this.pSearchType = value;
  }

  public Utility.ReceivablesSearchType ReceivableSearchType
  {
    get => this.rSearchType;
    set => this.rSearchType = value;
  }

  public Guid SearchForGuid
  {
    get => this.searchGuid;
    set => this.searchGuid = value;
  }

  public string PayeeName
  {
    get => this.searchPayeeName;
    set => this.searchPayeeName = value;
  }

  public int SearchForInteger
  {
    get => this.searchInteger;
    set => this.searchInteger = value;
  }

  public string SearchForString
  {
    get => this.searchString;
    set => this.searchString = value;
  }

  public DateTime SearchForDate
  {
    get => this.searchDate;
    set => this.searchDate = value;
  }

  public bool ShowZeros
  {
    get => this.showZeros;
    set => this.showZeros = value;
  }

  public Guid EntityGuid
  {
    get => this.entityGuid;
    set => this.entityGuid = value;
  }
}
