// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.GraphModel.IMessageAttachmentsCollectionPage
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Newtonsoft.Json;

#nullable disable
namespace MGASystems.Common.Email.GraphModel;

[JsonConverter(typeof (InterfaceConverter<MessageAttachmentsCollectionPage>))]
public interface IMessageAttachmentsCollectionPage : ICollectionPage<Attachment>
{
}
