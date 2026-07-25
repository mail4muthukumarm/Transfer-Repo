// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Controllers.UserTaggingManagerCommands
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.ValueConverters;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Excel.Data.UserTagging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

#nullable disable
namespace MGASystems.IMS.Excel.Controllers;

public static class UserTaggingManagerCommands
{
  public static RelayCommand<object[]> AddDataStore { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<UserTaggingManager, ICollectionView>(arguments);
    UserTaggingManager parent = (UserTaggingManager) arguments[0];
    ICollectionView collectionView = (ICollectionView) arguments[1];
    string uniqueName1 = Utility.GetUniqueName("DataStore", ((IEnumerable<TagDataStore>) parent.DataStores).Select<TagDataStore, string>((System.Func<TagDataStore, string>) (item => item.Name)));
    string uniqueName2 = Utility.GetUniqueName("DS", ((IEnumerable<TagDataStore>) parent.DataStores).Select<TagDataStore, string>((System.Func<TagDataStore, string>) (item => item.TagPrefix)));
    string uniqueName3 = Utility.GetUniqueName("userDefinedStoredProc", ((IEnumerable<TagDataStore>) parent.DataStores).Select<TagDataStore, string>((System.Func<TagDataStore, string>) (item => item.StoredProcedure)));
    TagDataStore tagDataStore1 = TagDataStore.Create(parent, uniqueName1, uniqueName3, uniqueName2, false, new int?());
    ((Collection<TagDataStore>) parent.DataStores).Add(tagDataStore1);
    TagDataStore tagDataStore2 = tagDataStore1;
    collectionView.MoveCurrentTo((object) tagDataStore2);
  }));

  public static RelayCommand<object[]> AddUserTag { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<TagDataStore, ICollectionView>(arguments);
    TagDataStore tagDataStore = (TagDataStore) arguments[0];
    ((ICollectionView) arguments[1]).MoveCurrentTo((object) UserTaggingManagerCommands.AddTag(tagDataStore, "UserTag", "Field"));
  }), (Predicate<object[]>) (arguments =>
  {
    if (arguments == null)
      return false;
    MultiValueConverter.VerifyArguments<TagDataStore, ICollectionView>(arguments);
    return arguments[0] is TagDataStore;
  }));

  private static UserTag AddTag(
    TagDataStore tagDataStore,
    string proposedName,
    string proposedField)
  {
    string uniqueName1 = Utility.GetUniqueName(proposedName, ((IEnumerable<UserTag>) tagDataStore.UserTags).Select<UserTag, string>((System.Func<UserTag, string>) (item => item.Name)));
    string uniqueName2 = Utility.GetUniqueName(proposedField, ((IEnumerable<UserTag>) tagDataStore.UserTags).Select<UserTag, string>((System.Func<UserTag, string>) (item => item.Field)));
    UserTag userTag = UserTag.Create(tagDataStore, uniqueName1, uniqueName2);
    ((Collection<UserTag>) tagDataStore.UserTags).Add(userTag);
    return userTag;
  }

  public static RelayCommand<object[]> SynchronizeTags { get; } = new RelayCommand<object[]>((Action<object[]>) (arguments =>
  {
    MultiValueConverter.VerifyArguments<TagDataStore, ICollectionView>(arguments);
    TagDataStore tagDataStore = (TagDataStore) arguments[0];
    ICollectionView collectionView = (ICollectionView) arguments[1];
    string messageBoxText = "Procedure must have only one input paramater, and it must be called @QuoteGuid (uniqueidentifier)";
    try
    {
      Dictionary<string, DbParameter> source = DefaultDatabase.DiscoverParameters(tagDataStore.StoredProcedure);
      if (source != null)
      {
        if (source.Count == 2)
        {
          if (source.Where<KeyValuePair<string, DbParameter>>((System.Func<KeyValuePair<string, DbParameter>, bool>) (item => item.Value.Direction == ParameterDirection.Input && item.Key.ToUpperInvariant() == "@QUOTEGUID")).Count<KeyValuePair<string, DbParameter>>() == 1)
          {
            DataTable dataTable = DefaultDatabase.FetchStoredProcedureSchemaTable(tagDataStore.StoredProcedure);
            if (dataTable != null)
            {
              HashSet<string> stringSet = new HashSet<string>(((IEnumerable<UserTag>) tagDataStore.UserTags).Select<UserTag, string>((System.Func<UserTag, string>) (item => item.Field)));
              IEnumerator enumerator = dataTable.Rows.GetEnumerator();
              try
              {
                while (enumerator.MoveNext())
                {
                  string str = (string) ((DataRow) enumerator.Current)["ColumnName"];
                  if (!stringSet.Contains(str) && !str.StartsWith("_"))
                  {
                    stringSet.Add(str);
                    UserTaggingManagerCommands.AddTag(tagDataStore, str, str);
                  }
                }
                return;
              }
              finally
              {
                if (enumerator is IDisposable disposable2)
                  disposable2.Dispose();
              }
            }
          }
        }
      }
    }
    catch (SqlException ex)
    {
      messageBoxText = ex.Message;
      ErrorHandler.SilentHandleError((Exception) ex);
    }
    catch (InvalidOperationException ex)
    {
      messageBoxText = ex.Message;
      ErrorHandler.SilentHandleError((Exception) ex);
    }
    int num = (int) MessageBox.Show(messageBoxText, "Unable to sync", MessageBoxButton.OK, MessageBoxImage.Hand);
  }), (Predicate<object[]>) (arguments =>
  {
    if (arguments == null)
      return false;
    MultiValueConverter.VerifyArguments<TagDataStore, ICollectionView>(arguments);
    return arguments[0] is TagDataStore tagDataStore4 && !string.IsNullOrEmpty(tagDataStore4.StoredProcedure);
  }));
}
