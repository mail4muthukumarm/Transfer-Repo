// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentStorage.MetadataProviders.SqlMetadataProvider
// Assembly: MGASystems.IMS.DocumentStorage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0E86514C-B750-47B0-BAB9-55A2036DEE75
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.DocumentStorage.dll

using MGASystems.Data;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentStorage.MetadataProviders;

public class SqlMetadataProvider : IMetadataProvider
{
  private const string DocumentStoreGuidCol = "DocumentStoreGUID";
  private const string DescriptionCol = "Description";
  private const string FileAssociationCol = "FileAssociation";
  private const string DateAddedCol = "DateAdded";
  private const string FileNameCol = "FileName";
  private const string UserGuidOriginatorCol = "UserGUIDOriginator";
  private const string TypeGuidCol = "TypeGUID";
  private const string CompressionLevelCol = "CompressionLevel";
  private const string CompressedCol = "Compressed";
  private const string OriginalFileSizeCol = "OriginalFileSize";
  private const string DocumentThumbnailCol = "DocumentThumbnail";
  private const string FolderIdCol = "FolderID";
  private const string CopyAssociationsForwardOnRenewalCol = "CopyAssociationsForwardOnRenewal";
  private const string CopyAssociationForwardOnlyOnceCol = "CopyAssociationForwardOnlyOnce";
  private const string MetaXmlCol = "MetaXML";
  private const string ActualFileSizeCol = "ActualFileSize";
  private const string DocumentStoreIdCol = "DocumentStoreId";
  private const string DeletedCol = "Deleted";
  private const string CreatedDateCol = "CreatedDate";
  private const string ModifiedDateCol = "ModifiedDate";
  private const string DocumentLocationsCol = "DocumentLocation";
  private const string MetadataStoredProc = "DocumentSystem_GetDocumentMetadata";
  private const string DocumentSystem_UpdateDocumentLocationsQL = "UPDATE [tblDocumentStore] SET [DocumentLocation] |= @DocumentLocation WHERE DocumentStoreGUID = @DocumentStoreGuid";

  public void AddDocumentLocation(Guid documentStoreGuid, DocumentLocation documentLocation)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE [tblDocumentStore] SET [DocumentLocation] |= @DocumentLocation WHERE DocumentStoreGUID = @DocumentStoreGuid", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid,
      (object) "@DocumentLocation",
      (object) documentLocation
    });
  }

  public Metadata GetMetadata(Guid documentStoreGuid)
  {
    return SqlMetadataProvider.ReadRow(DefaultDatabase.ExecuteDataRow("DocumentSystem_GetDocumentMetadata", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid
    }));
  }

  internal static Metadata ReadRow(DataRow row)
  {
    DataColumnCollection columns = row.Table.Columns;
    if (!columns.Contains("DocumentStoreGUID"))
      throw new ArgumentException("row does not contain required column 'DocumentStoreGUID'");
    Metadata metadata = new Metadata((Guid) row["DocumentStoreGUID"]);
    if (columns.Contains("Description") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["Description"])))
      metadata.Description = (string) row["Description"];
    if (columns.Contains("FileAssociation"))
      metadata.FileAssociation = (string) row["FileAssociation"];
    if (columns.Contains("DateAdded"))
      metadata.DateAdded = (DateTime) row["DateAdded"];
    if (columns.Contains("FileName"))
      metadata.FileName = (string) row["FileName"];
    if (columns.Contains("UserGUIDOriginator"))
      metadata.UserGuidOriginator = (Guid) row["UserGUIDOriginator"];
    if (columns.Contains("TypeGUID") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["TypeGUID"])))
      metadata.TypeGuid = (Guid) row["TypeGUID"];
    if (columns.Contains("CompressionLevel") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["CompressionLevel"])))
      metadata.CompressionLevel = (int) row["CompressionLevel"];
    if (columns.Contains("Compressed"))
      metadata.Compressed = (bool) row["Compressed"];
    if (columns.Contains("OriginalFileSize") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["OriginalFileSize"])))
      metadata.OriginalFileSize = (int) row["OriginalFileSize"];
    if (columns.Contains("DocumentThumbnail") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["DocumentThumbnail"])))
      metadata.DocumentThumbnail = (byte[]) row["DocumentThumbnail"];
    if (columns.Contains("FolderID") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["FolderID"])))
      metadata.FolderId = (int) row["FolderID"];
    if (columns.Contains("CopyAssociationsForwardOnRenewal"))
      metadata.CopyAssociationsForwardOnRenewal = (bool) row["CopyAssociationsForwardOnRenewal"];
    if (columns.Contains("CopyAssociationForwardOnlyOnce"))
      metadata.CopyAssociationForwardOnlyOnce = (bool) row["CopyAssociationForwardOnlyOnce"];
    if (columns.Contains("MetaXML") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["MetaXML"])))
      metadata.MetaXml = (string) row["MetaXML"];
    if (columns.Contains("ActualFileSize"))
      metadata.ActualFileSize = (long) row["ActualFileSize"];
    if (columns.Contains("DocumentStoreId"))
      metadata.DocumentStoreId = (int) row["DocumentStoreId"];
    if (columns.Contains("Deleted") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["Deleted"])))
      metadata.Deleted = (bool) row["Deleted"];
    if (columns.Contains("CreatedDate") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["CreatedDate"])))
      metadata.CreatedDate = (DateTime) row["CreatedDate"];
    if (columns.Contains("ModifiedDate") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["ModifiedDate"])))
      metadata.ModifiedDate = (DateTime) row["ModifiedDate"];
    if (columns.Contains("DocumentLocation") && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(row["DocumentLocation"])))
      metadata.DocumentLocation = (DocumentLocation) row["DocumentLocation"];
    return metadata;
  }
}
