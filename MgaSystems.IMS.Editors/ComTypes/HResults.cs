// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.HResults
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

internal static class HResults
{
  internal const int S_OK = 0;
  internal const int E_FAIL = -2147467259 /*0x80004005*/;

  internal static bool Succeeded(int hr) => hr >= 0;

  internal static bool Failed(int hr) => hr < 0;
}
