// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DatabaseQueryMultithreadedDataAdapter
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class DatabaseQueryMultithreadedDataAdapter
{
  private Dictionary<string, Queue> _runningQueryQueues;

  public DatabaseQueryMultithreadedDataAdapter()
  {
    this._runningQueryQueues = new Dictionary<string, Queue>();
  }

  private Queue GetTableQueue(DataTable table)
  {
    Queue tableQueue;
    if (this._runningQueryQueues.ContainsKey(table.TableName))
    {
      tableQueue = this._runningQueryQueues[table.TableName];
    }
    else
    {
      Queue queue = new Queue();
      this._runningQueryQueues.Add(table.TableName, queue);
      tableQueue = queue;
    }
    return tableQueue;
  }

  public void PerformTableQuery(
    Control uiContext,
    string key,
    SqlDataAdapter da,
    TableQueryMultithreadEventHandler completedHandler,
    DataTable tableToFill)
  {
    this.InternalPerformTableQuery(uiContext, key, da, completedHandler, tableToFill);
  }

  private void InternalPerformTableQuery(
    Control uiContext,
    string key,
    SqlDataAdapter da,
    TableQueryMultithreadEventHandler completedHandler,
    DataTable tableToFill)
  {
    DataAdapterQueryThread adapterQueryThread = new DataAdapterQueryThread(this, uiContext, da, (object) key, tableToFill, completedHandler);
    Queue tableQueue = this.GetTableQueue(tableToFill);
    if (tableQueue.Count == 0)
    {
      tableQueue.Enqueue((object) adapterQueryThread);
      adapterQueryThread.StartThread();
    }
    else
    {
      tableQueue.Enqueue((object) adapterQueryThread);
      ((QueryThread) tableQueue.Peek()).Abort();
    }
  }

  internal void OnTableFillComplete(DataTable table)
  {
    Queue tableQueue = this.GetTableQueue(table);
    tableQueue.Dequeue();
    if (tableQueue.Count <= 0)
      return;
    ((QueryThread) tableQueue.Peek()).StartThread();
  }
}
