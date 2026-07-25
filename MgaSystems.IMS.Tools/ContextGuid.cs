// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ContextGuid
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Text;

#nullable disable
namespace MGASystems.Tools;

public class ContextGuid
{
  private Guid _guid;
  private GuidContext _context;

  public ContextGuid(Guid guid, GuidContext context)
  {
    this._guid = guid;
    this._context = context;
  }

  public ContextGuid(string serialized)
  {
    string[] strArray = serialized != null ? serialized.Split("%".ToCharArray()) : throw new ArgumentNullException(nameof (serialized));
    this._context = (GuidContext) Enum.Parse(typeof (GuidContext), strArray[0]);
    this._guid = new Guid(strArray[1]);
  }

  public Guid Guid => this._guid;

  public GuidContext Context => this._context;

  public override string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder(this._context.ToString());
    stringBuilder.Append("%");
    stringBuilder.Append(this._guid.ToString());
    return stringBuilder.ToString();
  }

  public new bool Equals(object obj)
  {
    ContextGuid contextGuid = (ContextGuid) obj;
    return contextGuid != null && contextGuid.Context == this._context && contextGuid.Guid.Equals(this._guid);
  }

  public new static bool Equals(object objA, object objB)
  {
    ContextGuid contextGuid1 = (ContextGuid) objA;
    ContextGuid contextGuid2 = (ContextGuid) objB;
    return contextGuid1 != null && contextGuid2 != null && contextGuid1.Context == contextGuid2.Context && contextGuid1.Guid.Equals(contextGuid2.Guid);
  }
}
