// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics.FormActionDurationDto
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics;

public class FormActionDurationDto : DtoBase<int>
{
  public override int UniqueIdentifier => this.Id;

  [TableFieldMapping("Id")]
  public int Id { get; set; }

  [TableFieldMapping("FormName")]
  public string FormName { get; set; }

  [TableFieldMapping("ActionName")]
  public string ActionName { get; set; }

  [TableFieldMapping("TimeMs")]
  public int TimeMs { get; set; }

  [TableFieldMapping("IsDebug")]
  public bool IsDebug { get; set; }

  [TableFieldMapping("EnteredDate")]
  public DateTime EnteredDate { get; set; }

  [TableFieldMapping("UserGuid")]
  public Guid UserGuid { get; set; }
}
