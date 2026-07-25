// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAComboBoxDesigner
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGAComboBoxDesigner : ControlDesigner
{
  private DesignerVerbCollection _verbs;

  public override void OnSetComponentDefaults()
  {
    this.InitializeNewComponent((IDictionary) null);
    mgaStatusLook = (MGAStatusLook) null;
    IDesignerHost service = (IDesignerHost) this.Component.Site.GetService(typeof (IDesignerHost));
    if (service == null)
      return;
    try
    {
      foreach (object component in (ReadOnlyCollectionBase) service.Container.Components)
      {
        if (RuntimeHelpers.GetObjectValue(component) is MGAStatusLook mgaStatusLook)
          break;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (mgaStatusLook == null)
      mgaStatusLook = (MGAStatusLook) service.CreateComponent(typeof (MGAStatusLook));
    this.MGACombobox.MGAStatusLook = mgaStatusLook;
  }

  [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
  public override DesignerVerbCollection Verbs
  {
    get
    {
      if (this._verbs == null)
      {
        this._verbs = new DesignerVerbCollection();
        this._verbs.Add(new DesignerVerb("Add MGAStatusLook to the designer", new EventHandler(this.AddMGAStatusLook)));
      }
      return this._verbs;
    }
  }

  private void AddMGAStatusLook(object sender, EventArgs e)
  {
    if (this.MGACombobox.MGAStatusLook == null)
    {
      this.MGACombobox.MGAStatusLook = (MGAStatusLook) ((IDesignerHost) this.Component.Site.GetService(typeof (IDesignerHost))).CreateComponent(typeof (MGAStatusLook));
    }
    else
    {
      int num = (int) MessageBox.Show("A MGAStatusLook has already been added for this control", "Cannot add MGAStatusLook", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private MGAStatusComboBox MGACombobox => (MGAStatusComboBox) this.Control;
}
