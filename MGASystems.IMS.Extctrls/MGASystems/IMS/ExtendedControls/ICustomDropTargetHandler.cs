// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.ExtendedControls.ICustomDropTargetHandler
// Assembly: MGASystems.IMS.ExtendedControls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 933BCBB6-80B3-406B-A226-C528DBCF94BC
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.ExtendedControls.dll

#nullable disable
namespace MGASystems.IMS.ExtendedControls;

public interface ICustomDropTargetHandler
{
  unsafe void OnDragEnter(IDataObject* pDataObj, uint grfKeyState, _POINTL pt, uint* pdwEffect);

  unsafe void OnDragOver(uint grfKeyState, _POINTL pt, uint* pdwEffect);

  void OnDragLeave();

  unsafe void OnDrop(IDataObject* pDataObject, uint grfKeyState, _POINTL pt, uint* pdwEffect);
}
