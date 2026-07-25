// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.Metadata
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using System;

#nullable disable
namespace MGASystems.IMS.DocumentStorage;

public class Metadata
{
  public long ActualFileSize;
  public bool Compressed;
  public int CompressionLevel;
  public bool CopyAssociationsForwardOnRenewal;
  public bool CopyAssociationForwardOnlyOnce;
  public DateTime CreatedDate;
  public DateTime DateAdded;
  public bool Deleted;
  public string Description;
  public DocumentLocation DocumentLocation;
  public readonly Guid DocumentStoreGuid;
  public int DocumentStoreId;
  public byte[] DocumentThumbnail;
  public string FileAssociation;
  public string FileName;
  public int FolderId;
  public string MetaXml;
  public DateTime ModifiedDate;
  public int OriginalFileSize;
  public Guid TypeGuid;
  public Guid UserGuidOriginator;

  public Metadata(Guid documentStoreGuid) => this.DocumentStoreGuid = documentStoreGuid;
}
