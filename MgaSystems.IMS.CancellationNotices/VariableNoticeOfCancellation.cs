// Decompiled with JetBrains decompiler
// Type: CancellationNotices.VariableNoticeOfCancellation
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using System;

#nullable disable
namespace CancellationNotices;

[AttributeUsage(AttributeTargets.Class)]
public class VariableNoticeOfCancellation : Attribute
{
  private string _nocDescription;
  private string _nocName;

  public VariableNoticeOfCancellation(string nocName, string nocDesciption)
  {
    this._nocName = nocName;
    this._nocDescription = nocDesciption;
  }

  public string NocDescription => this._nocDescription;

  public string NocName => this._nocName;

  public override bool Match(object obj) => obj is VariableNoticeOfCancellation;
}
