// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.GenericExposuresAsOf
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures.CoverageTypes;
using MGASystems.BusinessObjects.GenericExposures.ExposureTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures;

public abstract class GenericExposuresAsOf : INotifyPropertyChanged
{
  private BindingList<IGenericExposure> _genericExposures;

  public event PropertyChangedEventHandler PropertyChanged;

  public BindingList<IGenericExposure> GenericExposures
  {
    get
    {
      this._genericExposures.AllowEdit = false;
      return this._genericExposures;
    }
  }

  protected void AddExposure(IGenericExposure exposure)
  {
    if (this._genericExposures == null)
      this._genericExposures = new BindingList<IGenericExposure>();
    if (this._genericExposures.Contains(exposure))
      throw new InvalidOperationException($"Item already exists in the collection. ExposureID: {exposure.ExposureID}; Description: {exposure.Description}");
    this._genericExposures.Add(exposure);
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
    if (propertyChangedEvent == null)
      return;
    propertyChangedEvent((object) this, new PropertyChangedEventArgs("GenericExposures"));
  }

  public abstract int GetExposureControlNo(int ExposureID);

  public string QueryExposureData(int exposureID, ExposureTypeElement exposureTypeElement)
  {
    string str = "";
    IGenericExposure genericExposure1 = (IGenericExposure) null;
    try
    {
      foreach (IGenericExposure genericExposure2 in (Collection<IGenericExposure>) this.GenericExposures)
      {
        if (genericExposure2.ExposureID == exposureID)
        {
          genericExposure1 = genericExposure2;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<IGenericExposure> enumerator;
      enumerator?.Dispose();
    }
    if (genericExposure1 != null)
    {
      try
      {
        foreach (ExposureElement exposureElement in (Collection<ExposureElement>) genericExposure1.ExposureElements)
        {
          if (exposureElement.ElementType == exposureTypeElement)
            str = exposureElement.Description;
        }
      }
      finally
      {
        IEnumerator<ExposureElement> enumerator;
        enumerator?.Dispose();
      }
    }
    return str;
  }

  public string QueryCoverageData(
    int exposureID,
    CoverageType coverageType,
    CoverageTypeElement coverageTypeElement)
  {
    string str = "";
    IGenericExposure genericExposure1 = (IGenericExposure) null;
    try
    {
      foreach (IGenericExposure genericExposure2 in (Collection<IGenericExposure>) this.GenericExposures)
      {
        if (genericExposure2.ExposureID == exposureID)
        {
          genericExposure1 = genericExposure2;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<IGenericExposure> enumerator;
      enumerator?.Dispose();
    }
    if (genericExposure1 != null)
    {
      IGenericCoverage genericCoverage = (IGenericCoverage) null;
      try
      {
        foreach (IGenericCoverage exposureCoverage in (Collection<IGenericCoverage>) genericExposure1.ExposureCoverages)
        {
          if (exposureCoverage.CoverageType == coverageType)
            genericCoverage = exposureCoverage;
        }
      }
      finally
      {
        IEnumerator<IGenericCoverage> enumerator;
        enumerator?.Dispose();
      }
      if (genericCoverage != null)
      {
        try
        {
          foreach (CoverageElement coverageElement in (Collection<CoverageElement>) genericCoverage.CoverageElements)
          {
            if (coverageElement.ElementType == coverageTypeElement)
              str = coverageElement.Description;
          }
        }
        finally
        {
          IEnumerator<CoverageElement> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    return str;
  }

  public List<CoverageType> GetCoverageList()
  {
    List<int> exposureIDs = new List<int>();
    try
    {
      foreach (IGenericExposure genericExposure in (Collection<IGenericExposure>) this.GenericExposures)
        exposureIDs.Add(genericExposure.ExposureID);
    }
    finally
    {
      IEnumerator<IGenericExposure> enumerator;
      enumerator?.Dispose();
    }
    return this.GetCoverageList(exposureIDs);
  }

  public List<CoverageType> GetCoverageList(int exposureID)
  {
    return this.GetCoverageList(new List<int>()
    {
      exposureID
    });
  }

  public List<CoverageType> GetCoverageList(List<int> exposureIDs)
  {
    List<CoverageType> coverageList = new List<CoverageType>();
    try
    {
      foreach (IGenericExposure genericExposure in (Collection<IGenericExposure>) this.GenericExposures)
      {
        if (exposureIDs.Contains(genericExposure.ExposureID))
        {
          try
          {
            foreach (IGenericCoverage exposureCoverage in (Collection<IGenericCoverage>) genericExposure.ExposureCoverages)
            {
              if (!coverageList.Contains(exposureCoverage.CoverageType))
                coverageList.Add(exposureCoverage.CoverageType);
            }
          }
          finally
          {
            IEnumerator<IGenericCoverage> enumerator;
            enumerator?.Dispose();
          }
        }
      }
    }
    finally
    {
      IEnumerator<IGenericExposure> enumerator;
      enumerator?.Dispose();
    }
    return coverageList;
  }

  public bool CoverageExists(CoverageType coverage) => this.GetCoverageList().Contains(coverage);

  public bool CoverageExists(CoverageType coverage, int exposureID)
  {
    return this.GetCoverageList(exposureID).Contains(coverage);
  }

  public bool CoverageExists(CoverageType coverage, List<int> exposureIDs)
  {
    return this.GetCoverageList(exposureIDs).Contains(coverage);
  }
}
