// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.DocumentProviders.IDocumentWriter
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.DocumentProviders;

public interface IDocumentWriter
{
  DocumentLocation PutDocumentBinary(
    Guid documentStoreGuid,
    byte[] documentBytes,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null);

  Task<DocumentLocation> PutDocumentBinaryAsync(
    Guid documentStoreGuid,
    byte[] documentBytes,
    CancellationToken token = default (CancellationToken),
    Action<int> callback = null);
}
