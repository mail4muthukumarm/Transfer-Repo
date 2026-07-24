// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.FolderManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[StandardModule]
public sealed class FolderManager
{
  private static List<FolderInfo> GetFolderPath(int folderID)
  {
    List<FolderInfo> folderInfoList = new List<FolderInfo>();
    List<FolderInfo> folderPath;
    return folderPath;
  }

  public static List<FolderInfo> GetFolders(int? parentFolderID = null, string entityFilter = "")
  {
    return FolderManager.GetSecureDocumentFolders(parentFolderID.HasValue ? parentFolderID.GetValueOrDefault() : -1, entityFilter ?? string.Empty);
  }

  private static List<FolderInfo> GetSecureDocumentFolders(int parentFolderID, string entityFilter)
  {
    List<FolderInfo> secureDocumentFolders;
    if (string.IsNullOrWhiteSpace(entityFilter))
    {
      EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("DocumentSystem_GetSecureDocumentFolders", new object[4]
      {
        (object) "@userID",
        (object) CurrentUser.Instance.UserID,
        (object) "@parentFolderId",
        (object) parentFolderID
      }).AsEnumerable();
      System.Func<DataRow, FolderInfo> selector;
      // ISSUE: reference to a compiler-generated field
      if (FolderManager._Closure\u0024__.\u0024I2\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = FolderManager._Closure\u0024__.\u0024I2\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        FolderManager._Closure\u0024__.\u0024I2\u002D0 = selector = (System.Func<DataRow, FolderInfo>) ([SpecialName] (row) => new FolderInfo(row.Field<int>("FolderID"), row.Field<int?>("ParentFolderID"), row.Field<string>("FolderName"), row.Field<bool>("IsDeletable"), row.Field<Guid>("SecureResourceGUID"), row.Field<int>("ChildCount")));
      }
      secureDocumentFolders = new List<FolderInfo>((IEnumerable<FolderInfo>) source.Select<DataRow, FolderInfo>(selector));
    }
    else
    {
      EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("DocumentSystem_GetSecureFilteredDocumentFolders", new object[6]
      {
        (object) "@entityTypeFilter",
        (object) entityFilter,
        (object) "@userID",
        (object) CurrentUser.Instance.UserID,
        (object) "@parentFolderId",
        (object) parentFolderID
      }).AsEnumerable();
      System.Func<DataRow, FolderInfo> selector;
      // ISSUE: reference to a compiler-generated field
      if (FolderManager._Closure\u0024__.\u0024I2\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = FolderManager._Closure\u0024__.\u0024I2\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        FolderManager._Closure\u0024__.\u0024I2\u002D1 = selector = (System.Func<DataRow, FolderInfo>) ([SpecialName] (row) => new FolderInfo(row.Field<int>("FolderID"), row.Field<int?>("ParentFolderID"), row.Field<string>("FolderName"), row.Field<bool>("IsDeletable"), row.Field<Guid>("SecureResourceGUID"), row.Field<int>("ChildCount")));
      }
      secureDocumentFolders = new List<FolderInfo>((IEnumerable<FolderInfo>) source.Select<DataRow, FolderInfo>(selector));
    }
    return secureDocumentFolders;
  }

  private static void ValidateNameLength(string folderName)
  {
    if (folderName.Length >= (int) byte.MaxValue)
      throw new ArgumentOutOfRangeException(nameof (folderName));
  }

  public static int CreateFolder(string folderName, bool isDeletable = true)
  {
    return FolderManager.CreateFolder(folderName, -99, isDeletable);
  }

  public static void ResetCache()
  {
  }

  public static int CreateFolder(string folderName, int parentFolderID, bool isDeletable = true)
  {
    FolderManager.ValidateNameLength(folderName);
    int folder;
    if (parentFolderID == -99)
      folder = (int) DefaultDatabase.ExecuteScalar("DocumentSystem_CreateFolder", new object[6]
      {
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@folderName",
        (object) folderName,
        (object) "@isDeletable",
        (object) isDeletable
      });
    else
      folder = (int) DefaultDatabase.ExecuteScalar("DocumentSystem_CreateFolder", new object[8]
      {
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@folderName",
        (object) folderName,
        (object) "@parentFolderID",
        (object) parentFolderID,
        (object) "@isDeletable",
        (object) isDeletable
      });
    return folder;
  }

  public static bool DeleteFolder(int folderId)
  {
    return DefaultDatabase.ExecuteNonQuery("DocumentSystem_DeleteFolder", new object[2]
    {
      (object) "@folderId",
      (object) folderId
    }) > 0;
  }

  public static void RenameFolder(int folderId, string folderName)
  {
    FolderManager.ValidateNameLength(folderName);
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_RenameFolder", new object[4]
    {
      (object) "@folderId",
      (object) folderId,
      (object) "@folderName",
      (object) folderName
    });
    FolderManager.ResetCache();
  }

  public static void MoveFolder(int folderId, int parentFolderId)
  {
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_MoveFolder", new object[4]
    {
      (object) "@folderId",
      (object) folderId,
      (object) "@ParentFolderID",
      (object) parentFolderId
    });
    FolderManager.ResetCache();
  }

  public static void MoveFolderToRoot(int folderId)
  {
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_MoveFolder", new object[2]
    {
      (object) "@folderId",
      (object) folderId
    });
    FolderManager.ResetCache();
  }

  public static bool IsFolderDeletable(int folderId)
  {
    return Utility.IsNull<bool>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("DocumentSystem_IsFolderDeletable", new object[2]
    {
      (object) "@folderId",
      (object) folderId
    })), false);
  }

  public static int GetDocumentCountUnderFolder(int folderID)
  {
    return Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("DocumentSystem_GetFolderDocumentCount", new object[2]
    {
      (object) "@folderId",
      (object) folderID
    })), 0);
  }

  public static bool FolderHasDocuments(int folderId)
  {
    return FolderManager.GetDocumentCountUnderFolder(folderId) > 0;
  }

  public static bool FolderExists(int folderId) => FolderManager.FetchFolderInfo(folderId) != null;

  private static DataRow FetchFolderInfo(int folderId)
  {
    return DefaultDatabase.ExecuteDataRow("DocumentSystem_FetchFolderInfo", new object[2]
    {
      (object) "@folderId",
      (object) folderId
    });
  }
}
