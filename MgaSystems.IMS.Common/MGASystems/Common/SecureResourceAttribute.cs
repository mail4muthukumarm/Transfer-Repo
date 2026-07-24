// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SecureResourceAttribute
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.Common;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class SecureResourceAttribute : Attribute
{
  private Guid _uniqueIdentifier;
  private string _name;
  private string _description;
  private string _securityGroup;

  public SecureResourceAttribute(
    string uniqueIdentifier,
    string name,
    string description,
    string securityGroup)
  {
    if (description == null)
      throw new ArgumentNullException(nameof (description));
    if (name == null)
      throw new ArgumentNullException(nameof (name));
    this._uniqueIdentifier = new Guid(uniqueIdentifier);
    this._name = name;
    this._description = description;
    this._securityGroup = securityGroup;
    if (name.Length > 200)
      throw new SecurityException(SR.GetString("SRA_NAME_TOO_LONG", (object) name));
    if (description.Length > 200)
      throw new SecurityException(SR.GetString("SRA_DESC_TOO_LONG", (object) name));
  }

  public SecureResourceAttribute(string uniqueIdentifier, string name, string description)
    : this(uniqueIdentifier, name, description, string.Empty)
  {
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public SecureResourceAttribute()
  {
  }

  public Guid UniqueIdentifier => this._uniqueIdentifier;

  public string Name => this._name;

  public string Description => this._description;

  public string SecurityGroup => this._securityGroup;

  public override bool Match(object obj) => obj is SecureResourceAttribute;
}
