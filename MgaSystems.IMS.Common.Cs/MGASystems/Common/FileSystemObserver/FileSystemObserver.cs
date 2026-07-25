// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileSystemObserver.FileSystemObserver
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

#nullable disable
namespace MGASystems.Common.FileSystemObserver;

public class FileSystemObserver : IFileSystemObserver
{
  private readonly FileSystemWatcher _fileSystemWatcher = new FileSystemWatcher();
  private readonly Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> _pendingEvents = new Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>();
  private readonly Timer _timer;
  private bool _timerStarted;
  private static List<string> _existingPaths = new List<string>();
  private bool useOriginalFSW;

  public event FileSystemEvent ChangedEvent;

  public event FileSystemEvent CreatedEvent;

  public event FileSystemEvent DeletedEvent;

  public event FileSystemRenameEvent RenamedEvent;

  public void Start() => this._fileSystemWatcher.EnableRaisingEvents = true;

  public void Stop()
  {
    if (this._fileSystemWatcher != null)
      this._fileSystemWatcher.Dispose();
    this._fileSystemWatcher.EnableRaisingEvents = false;
  }

  public FileSystemObserver(string observablePath, bool includeSubDirectories)
  {
    if (!SystemSettings.KeyExists("DocRevisions.UseOriginalFSW"))
      SystemSettings.SetBoolSetting("DocRevisions.UseOriginalFSW", false);
    this.useOriginalFSW = SystemSettings.GetBoolSetting("DocRevisions.UseOriginalFSW");
    this._fileSystemWatcher.Path = observablePath;
    this._fileSystemWatcher.IncludeSubdirectories = includeSubDirectories;
    if (this.useOriginalFSW)
    {
      this._fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
      this._fileSystemWatcher.Changed += new FileSystemEventHandler(this._fileSystemWatcher_Changed);
      this._fileSystemWatcher.Renamed += new RenamedEventHandler(this._fileSystemWatcher_Renamed);
    }
    else
    {
      MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths = Directory.EnumerateFileSystemEntries(observablePath, "*", SearchOption.AllDirectories).ToList<string>();
      this._fileSystemWatcher.Created += new FileSystemEventHandler(this.OnCreate);
      this._fileSystemWatcher.Changed += new FileSystemEventHandler(this.OnChange);
      this._fileSystemWatcher.Deleted += new FileSystemEventHandler(this.OnDelete);
      this._fileSystemWatcher.Renamed += new RenamedEventHandler(this.OnRename);
      this._fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
      this._timer = new Timer(new TimerCallback(this.OnTimeout), (object) null, -1, -1);
    }
  }

  private bool IsHidden(string path)
  {
    try
    {
      return File.Exists(path) && (File.GetAttributes(path) & FileAttributes.Hidden) == FileAttributes.Hidden;
    }
    catch
    {
      return true;
    }
  }

  private bool IsTempFile(string path)
  {
    if (path == "")
      return false;
    if (this.IsHidden(path))
      return true;
    FileInfo fileInfo = new FileInfo(path);
    return fileInfo.Extension == ".tmp" || fileInfo.Name.StartsWith("~") || fileInfo.Name.EndsWith("~") || string.IsNullOrEmpty(fileInfo.Extension);
  }

  private bool PathExists(string path) => File.Exists(path) || Directory.Exists(path);

  private bool CheckIfWeWantToFireThisEvent(string path1, string path2 = "")
  {
    return this.useOriginalFSW || !this.IsTempFile(path1) && !this.IsTempFile(path2);
  }

  private Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType> FindReadyEvents(
    Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> events)
  {
    Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType> readyEvents = new Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType>();
    DateTime now = DateTime.Now;
    foreach (IGrouping<string, KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>> source in events.GroupBy<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>, string>((Func<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>, string>) (x => x.Key.FullPath)))
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      foreach (KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> keyValuePair in (IEnumerable<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>) source)
      {
        switch (keyValuePair.Key.EventType)
        {
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType:
            flag3 = true;
            continue;
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.CreatedEventType:
            flag2 = true;
            continue;
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.DeletedEventType:
            flag1 = true;
            continue;
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.RenamedEventType:
            flag4 = true;
            continue;
          default:
            continue;
        }
      }
      if (flag1 & flag2)
      {
        readyEvents[source.First<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>().Key] = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType;
        lock (this._pendingEvents)
        {
          foreach (KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> keyValuePair in (IEnumerable<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>) source)
            this._pendingEvents.Remove(keyValuePair.Key);
        }
      }
      else if (flag2)
      {
        KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> keyValuePair = source.Where<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>((Func<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>, bool>) (x => x.Key.EventType == MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.CreatedEventType)).FirstOrDefault<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>();
        if (now.Subtract(keyValuePair.Value.Timestamp).TotalMilliseconds >= 75.0)
          readyEvents[keyValuePair.Key] = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.CreatedEventType;
      }
      else if (flag3)
      {
        KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> keyValuePair = source.Where<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>((Func<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>, bool>) (x => x.Key.EventType == MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType)).FirstOrDefault<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>();
        if (now.Subtract(keyValuePair.Value.Timestamp).TotalMilliseconds >= 75.0)
          readyEvents[keyValuePair.Key] = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType;
      }
      else if (flag1)
      {
        KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> keyValuePair = source.Where<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>((Func<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>, bool>) (x => x.Key.EventType == MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.DeletedEventType)).FirstOrDefault<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>();
        if (now.Subtract(keyValuePair.Value.Timestamp).TotalMilliseconds >= 75.0)
          readyEvents[keyValuePair.Key] = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.DeletedEventType;
      }
      else if (flag4)
      {
        KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue> keyValuePair = source.Where<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>((Func<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>, bool>) (x => x.Key.EventType == MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.RenamedEventType)).FirstOrDefault<KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue>>();
        if (now.Subtract(keyValuePair.Value.Timestamp).TotalMilliseconds >= 75.0)
          readyEvents[keyValuePair.Key] = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.RenamedEventType;
      }
    }
    return readyEvents;
  }

  private void FireChangedEvent(MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey key)
  {
    FileSystemEvent changedEvent = this.ChangedEvent;
    if (changedEvent == null)
      return;
    this.PathExists(key.FullPath);
    this.CheckIfWeWantToFireThisEvent(key.FullPath);
    if (!this.PathExists(key.FullPath) || !this.CheckIfWeWantToFireThisEvent(key.FullPath))
      return;
    changedEvent(key.FullPath);
  }

  private void FireDeletedEvent(MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey key)
  {
    FileSystemEvent deletedEvent = this.DeletedEvent;
    if (deletedEvent == null || this.PathExists(key.FullPath) || !this.CheckIfWeWantToFireThisEvent(key.FullPath))
      return;
    MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Remove(key.FullPath);
    deletedEvent(key.FullPath);
  }

  private void FireCreatedEvent(MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey key)
  {
    FileSystemEvent createdEvent = this.CreatedEvent;
    if (createdEvent == null || !this.PathExists(key.FullPath) || !this.CheckIfWeWantToFireThisEvent(key.FullPath) || MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Contains(key.FullPath))
      return;
    MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Add(key.FullPath);
    createdEvent(key.FullPath);
  }

  private void FireRenamedEvent(MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey key)
  {
    FileSystemRenameEvent renamedEvent = this.RenamedEvent;
    if (renamedEvent == null || MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Contains(key.FullPath) || !this.CheckIfWeWantToFireThisEvent(key.FullPath))
      return;
    MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Remove(key.OldFullPath);
    MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Add(key.FullPath);
    renamedEvent(key.OldFullPath, key.OldName, key.FullPath, key.Name);
  }

  private void _fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
  {
    this.FireRenamedEvent(new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey()
    {
      FullPath = e.FullPath,
      Name = e.Name,
      OldFullPath = e.OldFullPath,
      OldName = e.OldName,
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType
    });
  }

  private void _fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
  {
    this.FireChangedEvent(new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey()
    {
      FullPath = e.FullPath,
      Name = e.Name,
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType
    });
  }

  private void OnTimeout(object state)
  {
    Dictionary<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType> readyEvents;
    lock (this._pendingEvents)
    {
      readyEvents = this.FindReadyEvents(this._pendingEvents);
      foreach (KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType> keyValuePair in readyEvents)
        this._pendingEvents.Remove(keyValuePair.Key);
      if (this._pendingEvents.Count == 0)
      {
        this._timer.Change(-1, -1);
        this._timerStarted = false;
      }
    }
    try
    {
      List<string> list1 = Directory.EnumerateFileSystemEntries(this._fileSystemWatcher.Path, "*", SearchOption.AllDirectories).ToList<string>();
      List<string> list2 = list1.Except<string>((IEnumerable<string>) MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths).ToList<string>();
      List<string> list3 = MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Except<string>((IEnumerable<string>) list1).ToList<string>();
      MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey key;
      foreach (KeyValuePair<MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey, MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType> keyValuePair in readyEvents)
      {
        switch (keyValuePair.Value)
        {
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType:
            this.FireChangedEvent(keyValuePair.Key);
            continue;
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.CreatedEventType:
            List<string> stringList1 = list2;
            key = keyValuePair.Key;
            string fullPath1 = key.FullPath;
            if (stringList1.Contains(fullPath1))
            {
              List<string> stringList2 = list2;
              key = keyValuePair.Key;
              string fullPath2 = key.FullPath;
              stringList2.Remove(fullPath2);
              this.FireCreatedEvent(keyValuePair.Key);
              continue;
            }
            continue;
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.DeletedEventType:
            List<string> stringList3 = list3;
            key = keyValuePair.Key;
            string fullPath3 = key.FullPath;
            if (stringList3.Contains(fullPath3))
            {
              List<string> stringList4 = list3;
              key = keyValuePair.Key;
              string fullPath4 = key.FullPath;
              stringList4.Remove(fullPath4);
              this.FireDeletedEvent(keyValuePair.Key);
              continue;
            }
            continue;
          case MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.RenamedEventType:
            List<string> stringList5 = list3;
            key = keyValuePair.Key;
            string oldFullPath1 = key.OldFullPath;
            if (stringList5.Contains(oldFullPath1))
            {
              List<string> stringList6 = list3;
              key = keyValuePair.Key;
              string oldFullPath2 = key.OldFullPath;
              stringList6.Remove(oldFullPath2);
              this.FireRenamedEvent(keyValuePair.Key);
              continue;
            }
            continue;
          default:
            continue;
        }
      }
      MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths = list1;
    }
    catch (DirectoryNotFoundException ex)
    {
    }
  }

  private void OnFileSystemObserverEvent(
    MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey key,
    MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue value)
  {
    lock (this._pendingEvents)
    {
      this._pendingEvents[key] = value;
      if (this._timerStarted)
        return;
      this._timer.Change(100, 100);
      this._timerStarted = true;
    }
  }

  private void OnChange(object sender, FileSystemEventArgs e)
  {
    if (!File.Exists(e.FullPath) && !Directory.Exists(e.FullPath) || !MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Contains(e.FullPath) || this.IsTempFile(e.FullPath))
      return;
    this.OnFileSystemObserverEvent(new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey()
    {
      Name = Path.GetFileName(e.Name),
      FullPath = e.FullPath,
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType
    }, new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue()
    {
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.ChangedEventType,
      Timestamp = DateTime.Now
    });
  }

  private void OnDelete(object sender, FileSystemEventArgs e)
  {
    if (!MGASystems.Common.FileSystemObserver.FileSystemObserver._existingPaths.Contains(e.FullPath))
      return;
    this.OnFileSystemObserverEvent(new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey()
    {
      Name = Path.GetFileName(e.Name),
      FullPath = e.FullPath,
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.DeletedEventType
    }, new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue()
    {
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.DeletedEventType,
      Timestamp = DateTime.Now
    });
  }

  private void OnCreate(object sender, FileSystemEventArgs e)
  {
    if (!File.Exists(e.FullPath) && !Directory.Exists(e.FullPath))
      return;
    this.OnFileSystemObserverEvent(new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey()
    {
      Name = Path.GetFileName(e.Name),
      FullPath = e.FullPath,
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.CreatedEventType
    }, new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue()
    {
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.CreatedEventType,
      Timestamp = DateTime.Now
    });
  }

  private void OnRename(object sender, RenamedEventArgs e)
  {
    this.OnFileSystemObserverEvent(new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverKey()
    {
      OldFullPath = e.OldFullPath,
      OldName = Path.GetFileName(e.OldName),
      FullPath = e.FullPath,
      Name = string.IsNullOrEmpty(e.Name) ? Path.GetFileName(e.OldName) : Path.GetFileName(e.Name),
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.RenamedEventType
    }, new MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverValue()
    {
      EventType = MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType.RenamedEventType,
      Timestamp = DateTime.Now
    });
  }

  private enum FileSystemObserverEventType
  {
    ChangedEventType,
    CreatedEventType,
    DeletedEventType,
    RenamedEventType,
    MovedEventType,
  }

  private struct FileSystemObserverKey
  {
    public string OldFullPath { get; set; }

    public string OldName { get; set; }

    public string FullPath { get; set; }

    public string Name { get; set; }

    public MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType EventType { get; set; }
  }

  private struct FileSystemObserverValue
  {
    public DateTime Timestamp { get; set; }

    public MGASystems.Common.FileSystemObserver.FileSystemObserver.FileSystemObserverEventType EventType { get; set; }
  }
}
