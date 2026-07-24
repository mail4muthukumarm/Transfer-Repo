// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.SendHandler
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.Common.Email;

public class SendHandler
{
  private readonly Func<UserEmail, MessageObject, bool> _sendMethod;
  private readonly Func<UserEmail, MessageObject, Task<bool>> _sendMethodAsync;

  public SendHandler(
    Func<UserEmail, MessageObject, bool> send,
    Func<UserEmail, MessageObject, Task<bool>> sendAsync)
  {
    this._sendMethod = send != null || sendAsync != null ? send : throw new AggregateException(new Exception[2]
    {
      (Exception) new ArgumentNullException(nameof (send)),
      (Exception) new ArgumentNullException(nameof (sendAsync))
    });
    this._sendMethodAsync = sendAsync;
  }

  public bool Send(UserEmail user, MessageObject message)
  {
    Func<UserEmail, MessageObject, bool> sendMethod = this._sendMethod;
    bool? nullable;
    if (sendMethod == null)
    {
      Func<UserEmail, MessageObject, Task<bool>> sendMethodAsync = this._sendMethodAsync;
      nullable = sendMethodAsync != null ? new bool?(sendMethodAsync(user, message).GetAwaiter().GetResult()) : new bool?();
    }
    else
      nullable = new bool?(sendMethod(user, message));
    return nullable.GetValueOrDefault();
  }

  public async Task<bool> SendAsync(UserEmail user, MessageObject message)
  {
    SendHandler sendHandler = this;
    UserEmail userEmail = user;
    MessageObject messageObject = message;
    Func<UserEmail, MessageObject, Task<bool>> sendMethodAsync = this._sendMethodAsync;
    return await ((sendMethodAsync != null ? sendMethodAsync(userEmail, messageObject) : (Task<bool>) null) ?? Task.Run<bool>((Func<bool>) ([SpecialName] () =>
    {
      Func<UserEmail, MessageObject, bool> sendMethod = sendHandler._sendMethod;
      return sendMethod != null && sendMethod(userEmail, messageObject);
    })));
  }
}
