// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DiaryCompletionStatusChangedEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

#nullable disable
namespace MGASystems.Common;

public class DiaryCompletionStatusChangedEventArgs : EventArgs
{
  private Guid _diaryEntryGuid;
  private List<DiaryRecipientChange> _diaryRecipientChanges;

  public DiaryCompletionStatusChangedEventArgs(
    Guid diaryEntryGuid,
    XmlDocument diaryRecipientChangeSetXml)
  {
    this._diaryRecipientChanges = new List<DiaryRecipientChange>();
    this._diaryEntryGuid = diaryEntryGuid;
    if (diaryRecipientChangeSetXml.ChildNodes.Count != 1)
      return;
    try
    {
      foreach (XmlNode xmlNode in diaryRecipientChangeSetXml.ChildNodes[0])
        this._diaryRecipientChanges.Add(new DiaryRecipientChange(new Guid(xmlNode.Attributes["UserGuid"].Value), DateTime.Parse(xmlNode.Attributes["CompletedDate"].Value), (bool) Interaction.IIf(Operators.CompareString(xmlNode.Attributes["Completed"].Value, "1", false) == 0, (object) true, (object) false)));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public Guid DiaryEntryGuid => this._diaryEntryGuid;

  public ReadOnlyCollection<DiaryRecipientChange> DiaryRecipientChanges
  {
    get
    {
      return new ReadOnlyCollection<DiaryRecipientChange>((IList<DiaryRecipientChange>) this._diaryRecipientChanges);
    }
  }
}
