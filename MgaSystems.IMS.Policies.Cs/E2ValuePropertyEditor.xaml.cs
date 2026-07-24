// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.PropertyEditor
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.Interop;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.Policies.E2Value.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Markup;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value;

public partial class PropertyEditor : MgaMdiChild, IComponentConnector
{
  private readonly EstimateProperty property;
  private bool _contentLoaded;

  public PropertyEditor.EditableFields editableFields { get; }

  public RelayCommand<PropertyEditor.EditableFields> SaveCommand
  {
    get
    {
      return new RelayCommand<PropertyEditor.EditableFields>(new Action<PropertyEditor.EditableFields>(this.Save), (Predicate<PropertyEditor.EditableFields>) (ef => ef != null && !ef.HasErrors));
    }
  }

  public PropertyEditor(EstimateProperty property)
  {
    this.property = property;
    this.editableFields = new PropertyEditor.EditableFields()
    {
      address1 = property.address1,
      address2 = property.address2,
      city = property.city,
      zipcode = property.zipcode,
      state = property.state,
      total_square_footage = property.total_square_footage,
      coverage_a = property.coverage_a,
      construction_quality = property.construction_quality,
      construction_type = property.construction_type,
      exterior = property.exterior,
      roof_covering = property.roof_covering,
      BusinessEntityName = property.BusinessEntityName
    };
    this.InitializeComponent();
    ((FrameworkElement) this).DataContext = (object) this;
  }

  private void Save(PropertyEditor.EditableFields editableFields)
  {
    this.property.address1 = editableFields.address1;
    this.property.address2 = editableFields.address2;
    this.property.city = editableFields.city;
    this.property.zipcode = editableFields.zipcode;
    this.property.state = editableFields.state;
    this.property.total_square_footage = editableFields.total_square_footage;
    this.property.coverage_a = editableFields.coverage_a;
    this.property.construction_quality = editableFields.construction_quality;
    this.property.construction_type = editableFields.construction_type;
    this.property.exterior = editableFields.exterior;
    this.property.roof_covering = editableFields.roof_covering;
    this.property.BusinessEntityName = editableFields.BusinessEntityName;
    this.Close();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/MgaSystems.IMS.Policies.Cs;component/e2value/propertyeditor.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target) => this._contentLoaded = true;

  public class EditableFields : BindingObject, IDataErrorInfo
  {
    public Dictionary<string, string> Errors = new Dictionary<string, string>();

    public string address1 { get; set; }

    public string address2 { get; set; }

    public string city { get; set; }

    [RegularExpression("\\d{5}")]
    [NotificationProperty]
    public virtual string zipcode { get; set; }

    public MgaSystems.IMS.Policies.E2Value.Data.State? state { get; set; }

    [RegularExpression("\\d*")]
    [NotificationProperty]
    public virtual string total_square_footage { get; set; }

    public Decimal coverage_a { get; set; }

    public ConstructionQuality construction_quality { get; set; }

    public ConstructionType construction_type { get; set; }

    public Exterior exterior { get; set; }

    public RoofCovering roof_covering { get; set; }

    public string BusinessEntityName { get; set; }

    [NotificationProperty]
    public bool HasErrors
    {
      get
      {
        return this.Errors.Any<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (kvp => !string.IsNullOrEmpty(kvp.Value)));
      }
    }

    string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

    string IDataErrorInfo.this[string memberName]
    {
      get
      {
        this.Errors[memberName] = DataErrorInfoSupport.GetError((object) this, memberName);
        this.OnPropertyChanged("HasErrors");
        return this.Errors[memberName];
      }
    }
  }
}
