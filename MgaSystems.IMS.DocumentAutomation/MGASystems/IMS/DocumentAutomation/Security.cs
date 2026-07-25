// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.Security
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Common;
using MGASystems.IMS.Security;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[SecureResource("{7A6E173D-3AD4-4B0B-ADB4-E83BEC764816}", "New Template", "Controls the ability to create a new document template.", "Document System")]
[SecureResource("{A42CEC5B-66B7-49C5-A500-93431F9F78DE}", "Edit Template", "Controls the ability to edit a document template.", "Document System")]
[SecureResource("{F0A66C09-FFBA-44D7-8345-4FEC6CC58260}", "Delete Template", "Controls the ability to delete a document template.", "Document System")]
[SecureResource("{C2BC7499-8E99-4633-9C20-7EE4E4BC2B35}", "Replace Template", "Controls the ability to replace a document template.", "Document System")]
public sealed class Security
{
  public const string newTemplate = "{7A6E173D-3AD4-4B0B-ADB4-E83BEC764816}";
  public const string editTemplate = "{A42CEC5B-66B7-49C5-A500-93431F9F78DE}";
  public const string deleteTemplate = "{F0A66C09-FFBA-44D7-8345-4FEC6CC58260}";
  public const string replaceTemplate = "{C2BC7499-8E99-4633-9C20-7EE4E4BC2B35}";

  private Security()
  {
  }

  public static bool CanCreateNewTemplate()
  {
    return MGASystems.IMS.DocumentAutomation.Security.Assert("{7A6E173D-3AD4-4B0B-ADB4-E83BEC764816}");
  }

  public static bool CanEditTemplate() => MGASystems.IMS.DocumentAutomation.Security.Assert("{A42CEC5B-66B7-49C5-A500-93431F9F78DE}");

  public static bool CanDeleteTempalte()
  {
    return MGASystems.IMS.DocumentAutomation.Security.Assert("{F0A66C09-FFBA-44D7-8345-4FEC6CC58260}");
  }

  public static bool CanReplaceTemplate()
  {
    return MGASystems.IMS.DocumentAutomation.Security.Assert("{C2BC7499-8E99-4633-9C20-7EE4E4BC2B35}");
  }

  private static bool Assert(string resource)
  {
    return SecurityManager.Instance.AssertPermission(resource);
  }
}
