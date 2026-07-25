// Decompiled with JetBrains decompiler
// Type: System.Runtime.CompilerServices.RefSafetyRulesAttribute
// Assembly: MGATestHarnessLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05440D76-BA31-4A52-B3E9-C79D046B509D
// Assembly location: D:\augusta\fortegra\IMS Project\MGATestHarnessLibrary.dll

using Microsoft.CodeAnalysis;
using System.Runtime.InteropServices;

#nullable disable
namespace System.Runtime.CompilerServices;

[CompilerGenerated]
[Embedded]
[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
internal sealed class RefSafetyRulesAttribute : Attribute
{
  public readonly int Version;

  public RefSafetyRulesAttribute([In] int obj0) => this.Version = obj0;
}
