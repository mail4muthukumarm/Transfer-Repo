// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Tools.NonUI.FileTransfer.TransferResults
// Assembly: MgaSystems.Ims.Tools.NonUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3C7A706E-5725-406E-877A-EB3C164B7042
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.Ims.Tools.NonUI.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MgaSystems.Ims.Tools.NonUI.FileTransfer;

public class TransferResults
{
  public Dictionary<string, TransferOperation> Operations { get; }

  public string OperationType { get; }

  public bool HasErrors
  {
    get
    {
      return this.Operations.Any<KeyValuePair<string, TransferOperation>>((Func<KeyValuePair<string, TransferOperation>, bool>) (x => x.Value.OperationStatus != TransferStatus.Success));
    }
  }

  public ICollection<TransferOperation> Results
  {
    get => (ICollection<TransferOperation>) this.Operations.Values;
  }

  public TransferResults(List<string> paths, [CallerMemberName] string callingMethod = "TransferResults")
  {
    this.Operations = paths.ToDictionary<string, string, TransferOperation>((Func<string, string>) (p => p), (Func<string, TransferOperation>) (p => new TransferOperation(p)));
    this.OperationType = callingMethod;
  }
}
