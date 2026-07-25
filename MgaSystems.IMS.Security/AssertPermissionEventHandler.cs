// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.AssertPermissionEventHandler
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.Security;

[SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")]
public delegate void AssertPermissionEventHandler(object sender, AssertPermissionEventArgs e);
