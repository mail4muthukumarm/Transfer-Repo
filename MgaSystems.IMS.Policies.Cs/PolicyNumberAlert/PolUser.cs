// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberAlert.PolUser
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.PolicyNumberAlert;

public class PolUser : INotifyPropertyChanged
{
  private bool _SendNote;

  public event PropertyChangedEventHandler PropertyChanged;

  public bool FinishedLoading { get; set; }

  private void OnPropertyChanged(string propertyName)
  {
    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    if (propertyChanged != null)
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    if (!propertyName.Equals("SendNote") || !this.FinishedLoading)
      return;
    if (!this.SendNote)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyNumberNotesUsers WHERE UserGuid = @UserGuid AND RuleID = @RuleID", new object[4]
      {
        (object) "@UserGuid",
        (object) this.UserGuid,
        (object) "@RuleID",
        (object) this.RuleID
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblPolicyNumberNotesUsers(RuleID,UserGuid) SELECT @RuleID, @UserGuid", new object[4]
      {
        (object) "@RuleID",
        (object) this.RuleID,
        (object) "@UserGuid",
        (object) this.UserGuid
      });
  }

  public Guid UserGuid { get; set; }

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public int RuleID { get; set; }

  public bool SendNote
  {
    get => this._SendNote;
    set
    {
      this._SendNote = value;
      this.OnPropertyChanged(nameof (SendNote));
    }
  }
}
