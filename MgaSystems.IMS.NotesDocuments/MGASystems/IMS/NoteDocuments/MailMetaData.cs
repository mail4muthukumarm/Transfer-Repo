// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.MailMetaData
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
[Serializable]
public struct MailMetaData
{
  private DateTime _sent;
  private DateTime _received;
  private string _sentString;
  private string _receivedString;
  private string _subject;
  private string _body;

  public string SentString
  {
    get => this._sentString;
    set => this._sentString = value;
  }

  public string ReceivedString
  {
    get => this._receivedString;
    set => this._receivedString = value;
  }

  public string Subject
  {
    get => this._subject;
    set => this._subject = value;
  }

  public string Body
  {
    get => this._body;
    set => this._body = value;
  }

  public DateTime Sent
  {
    get => this._sent;
    set => this._sent = value;
  }

  public DateTime Received
  {
    get => this._received;
    set => this._received = value;
  }

  public string ToXml()
  {
    XmlDocument xmlDocument = new XmlDocument();
    XmlElement element = xmlDocument.CreateElement("MailInfo");
    xmlDocument.AppendChild((XmlNode) element);
    XmlAttribute attribute1 = xmlDocument.CreateAttribute("Sent");
    attribute1.Value = this.SentString;
    element.Attributes.Append(attribute1);
    XmlAttribute attribute2 = xmlDocument.CreateAttribute("Received");
    attribute2.Value = this.ReceivedString;
    element.Attributes.Append(attribute2);
    if (!string.IsNullOrEmpty(this._body))
    {
      XmlAttribute attribute3 = xmlDocument.CreateAttribute("Body");
      attribute3.Value = this.Body;
      element.Attributes.Append(attribute3);
    }
    if (!string.IsNullOrEmpty(this._subject))
    {
      XmlAttribute attribute4 = xmlDocument.CreateAttribute("Subject");
      attribute4.Value = this.Subject;
      element.Attributes.Append(attribute4);
    }
    return xmlDocument.OuterXml;
  }
}
