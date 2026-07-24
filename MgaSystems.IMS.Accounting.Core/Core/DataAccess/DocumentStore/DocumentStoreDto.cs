// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.DocumentStore.DocumentStoreDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.DocumentStore;

public class DocumentStoreDto : DtoBase<Guid>
{
  public override Guid UniqueIdentifier => this.DocumentStoreGUID;

  [TableFieldMapping("DocumentStoreGUID")]
  public Guid DocumentStoreGUID { get; set; }

  [TableFieldMapping("Description")]
  public string Description { get; set; }

  [TableFieldMapping("FileAssociation")]
  public string FileAssociation { get; set; }

  [TableFieldMapping("DateAdded")]
  public DateTime DateAdded { get; set; }

  [TableFieldMapping("FileName")]
  public string FileName { get; set; }

  [TableFieldMapping("UserGUIDOriginator")]
  public Guid UserGUIDOriginator { get; set; }

  [TableFieldMapping("TypeGUID")]
  public Guid TypeGUID { get; set; }

  [TableFieldMapping("CompressionLevel")]
  public int CompressionLevel { get; set; }

  [TableFieldMapping("Compressed")]
  public bool Compressed { get; set; }

  [TableFieldMapping("OriginalFileSize")]
  public int OriginalFileSize { get; set; }

  [TableFieldMapping("FolderID")]
  public int FolderID { get; set; }

  [TableFieldMapping("CopyAssociationsForwardOnRenewal")]
  public bool CopyAssociationsForwardOnRenewal { get; set; }

  [TableFieldMapping("MetaXML")]
  public string MetaXML { get; set; }

  [TableFieldMapping("ActualFileSize")]
  public int ActualFileSize { get; set; }

  [TableFieldMapping("DocumentStoreId")]
  public int DocumentStoreID { get; set; }

  [TableFieldMapping("Deleted")]
  public bool Deleted { get; set; }

  [TableFieldMapping("CreatedDate")]
  public DateTime CreatedDate { get; set; }

  [TableFieldMapping("ModifiedDate")]
  public DateTime ModifiedDate { get; set; }

  [TableFieldMapping("CreationDate")]
  public DateTime CreationDate { get; set; }

  [TableFieldMapping("LastEditDate")]
  public DateTime LastEditDate { get; set; }

  [TableFieldMapping("DocumentLocation")]
  public int DocumentLocation { get; set; }

  [TableFieldMapping("CopyAssociationForwardOnlyOnce")]
  public bool CopyAssociationForwardOnlyOnce { get; set; }
}
