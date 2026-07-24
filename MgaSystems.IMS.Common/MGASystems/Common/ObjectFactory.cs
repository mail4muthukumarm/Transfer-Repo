// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ObjectFactory
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common;

[LogCategory("MGASystems.Common.ObjectFactory.ObjectFactory", "MGASystems.Common.ObjectFactory.ObjectFactory")]
public sealed class ObjectFactory : IDisposable
{
  internal const string LogKey = "MGASystems.Common.ObjectFactory.ObjectFactory";
  private bool _treatTypesAsStrings;
  private ArrayList _autoInstantiatedObjects;
  private List<string> _IMSVisibleAssemblyNames;
  private static ObjectFactory _objFactory;
  private Hashtable _assemblyTable;
  private Dictionary<string, string> _baseObjectTable;
  private ObjectInfoCollection _objectOverrideList;
  private Dictionary<string, Type[]> _cachedInterfaceTypes;
  private Dictionary<string, Type[]> _cachedAttributedTypes;
  private bool _enableCaching;
  private Dictionary<string, Assembly> _resolvedAssembles;
  private object _syncObj;
  private Icon _stdWindowsIcon;

  static ObjectFactory() => ObjectFactory.CacheInWebApplication = false;

  public event ObjectFactory.ObjectConstructedEventHandler ObjectConstructed;

  public event ObjectFactory.AssemblyLoadedEventHandler AssemblyLoaded;

  public event ObjectFactory.LoadingNamedAssemblyEventHandler LoadingNamedAssembly;

  public event EventHandler<ObjectInfoEventArgs> PreviewObjectConstructed;

  private bool ShouldLog
  {
    get => MGASystems.IMS.Logging.Log.GetDestination("MGASystems.Common.ObjectFactory.ObjectFactory") != 0;
  }

  private void WriteLog(string logMessage, object context)
  {
    if (MGASystems.IMS.Logging.Log.GetDestination("MGASystems.Common.ObjectFactory.ObjectFactory") == LogDestination.Disabled)
      return;
    if (context == null)
    {
      MGASystems.IMS.Logging.Log.Write(logMessage, "MGASystems.Common.ObjectFactory.ObjectFactory");
    }
    else
    {
      string str1 = context.ToString();
      string str2;
      try
      {
        using (StringWriter stringWriter = new StringWriter())
        {
          new XmlSerializer(context.GetType()).Serialize((TextWriter) stringWriter, RuntimeHelpers.GetObjectValue(context));
          str2 = stringWriter.ToString();
        }
        if (string.IsNullOrEmpty(str2))
          str2 = str1;
      }
      catch (SerializationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        str2 = str1;
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str2 = "Could Not Serialize Context into XML";
        ProjectData.ClearProjectError();
      }
      MGASystems.IMS.Logging.Log.Write(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}, Context: {1}", (object) logMessage, (object) str2), "MGASystems.Common.ObjectFactory.ObjectFactory");
    }
  }

  public bool TreatTypesAsStrings
  {
    get => this._treatTypesAsStrings;
    set => this._treatTypesAsStrings = value;
  }

  public static T QueryInterface<T>(object item) where T : class
  {
    T obj1;
    switch (item)
    {
      case T obj2:
        obj1 = obj2;
        break;
      case ISubObjectInterface subObjectInterface:
        obj1 = subObjectInterface.QueryInterface<T>();
        break;
      default:
        obj1 = default (T);
        break;
    }
    return obj1;
  }

  private ObjectFactory()
  {
    this._autoInstantiatedObjects = new ArrayList();
    this._IMSVisibleAssemblyNames = new List<string>();
    this._assemblyTable = new Hashtable();
    this._baseObjectTable = new Dictionary<string, string>();
    this._objectOverrideList = new ObjectInfoCollection();
    this._cachedInterfaceTypes = new Dictionary<string, Type[]>();
    this._cachedAttributedTypes = new Dictionary<string, Type[]>();
    this._resolvedAssembles = new Dictionary<string, Assembly>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
    this._syncObj = RuntimeHelpers.GetObjectValue(new object());
  }

  public void Dispose()
  {
    try
    {
      foreach (IDisposable disposable in this._autoInstantiatedObjects.OfType<IDisposable>())
        disposable.Dispose();
    }
    finally
    {
      IEnumerator<IDisposable> enumerator;
      enumerator?.Dispose();
    }
    if (this._stdWindowsIcon != null)
      this._stdWindowsIcon.Dispose();
    this._autoInstantiatedObjects.Clear();
  }

  public string[] VisibleAssemblyNames() => this._IMSVisibleAssemblyNames.ToArray();

  public string[] GetOverridesList()
  {
    ObjectInfoCollection objectOverrideList = this._objectOverrideList;
    Func<ObjectInfo, string> selector;
    // ISSUE: reference to a compiler-generated field
    if (ObjectFactory._Closure\u0024__.\u0024I41\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = ObjectFactory._Closure\u0024__.\u0024I41\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ObjectFactory._Closure\u0024__.\u0024I41\u002D0 = selector = (Func<ObjectInfo, string>) ([SpecialName] (oi) => string.Format("Base: {0}, Object: {1}, Assembly: {2}", (object) oi.BaseClass, (object) oi.ObjectName, (object) oi.AssemblyName, (object) "\r\n"));
    }
    return objectOverrideList.Select<ObjectInfo, string>(selector).ToArray<string>();
  }

  public List<ObjectInfo> GetObjectOverrideList() => this._objectOverrideList.ToList<ObjectInfo>();

  public void Initialize() => this.Initialize(false);

  public void Initialize(bool enableCaching)
  {
    this.LoadCustomizationDLLs();
    this.CreateAutoInstantiateItems();
  }

  private void CreateAutoInstantiateItems()
  {
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new AutoInstantiateAttribute());
    int index = 0;
    while (index < typeArray.Length)
    {
      Type baseType = typeArray[index];
      string objectName = ObjectFactory.Instance.ResolveObjectToCreate(baseType).ObjectName;
      if (!dictionary.ContainsKey(objectName))
      {
        dictionary.Add(objectName, objectName);
        object obj = RuntimeHelpers.GetObjectValue(ObjectFactory.CreateObjectPrivateCtor(baseType));
        if (obj != null && obj is IAutoInstantiate autoInstantiate)
        {
          autoInstantiate.PerformFunction();
          if (autoInstantiate.ShouldImmediatelyDestroy)
          {
            if (obj is IDisposable disposable)
              disposable.Dispose();
            obj = (object) null;
          }
        }
        if (obj != null)
          this._autoInstantiatedObjects.Add(RuntimeHelpers.GetObjectValue(obj));
      }
      checked { ++index; }
    }
  }

  private Dictionary<string, Assembly> ResolvedAssemblies => this._resolvedAssembles;

  private Assembly ObjectFactory_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
  {
    // ISSUE: variable of a compiler-generated type
    ObjectFactory._Closure\u0024__49\u002D0 closure490_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    ObjectFactory._Closure\u0024__49\u002D0 closure490_2 = new ObjectFactory._Closure\u0024__49\u002D0(closure490_1);
    // ISSUE: reference to a compiler-generated field
    closure490_2.\u0024VB\u0024Local_args = args;
    // ISSUE: reference to a compiler-generated field
    AssemblyName assemblyName = new AssemblyName(closure490_2.\u0024VB\u0024Local_args.Name);
    Assembly assembly1;
    // ISSUE: reference to a compiler-generated field
    if (this.ResolvedAssemblies.ContainsKey(closure490_2.\u0024VB\u0024Local_args.Name))
    {
      // ISSUE: reference to a compiler-generated field
      assembly1 = this.ResolvedAssemblies[closure490_2.\u0024VB\u0024Local_args.Name];
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      Assembly assembly2 = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies()).FirstOrDefault<Assembly>(new Func<Assembly, bool>(closure490_2._Lambda\u0024__0));
      if ((object) assembly2 != null)
      {
        assembly1 = assembly2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Assembly assembly3 = this.GetAssembly(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, assemblyName.Name + ".dll"), closure490_2.\u0024VB\u0024Local_args.Name);
        if ((object) assembly3 == null)
        {
          if (this.AdditionalReferencePaths != null)
          {
            try
            {
              foreach (string additionalReferencePath in this.AdditionalReferencePaths)
              {
                // ISSUE: reference to a compiler-generated field
                assembly3 = this.GetAssembly(Path.Combine(additionalReferencePath, assemblyName.Name + ".dll"), closure490_2.\u0024VB\u0024Local_args.Name);
                if ((object) assembly3 != null)
                  break;
              }
            }
            finally
            {
              List<string>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
        if ((object) assembly3 != null)
          this.ResolvedAssemblies[assembly3.FullName] = assembly3;
        assembly1 = assembly3;
      }
    }
    return assembly1;
  }

  private Assembly GetAssembly(string dependentAssemblyFilename, string name)
  {
    Assembly assembly;
    if (File.Exists(dependentAssemblyFilename))
    {
      assembly = Assembly.ReflectionOnlyLoadFrom(dependentAssemblyFilename);
    }
    else
    {
      if (this.AdditionalReferencePaths != null)
      {
        try
        {
          foreach (string additionalReferencePath in this.AdditionalReferencePaths)
          {
            dependentAssemblyFilename = Path.Combine(additionalReferencePath, Path.GetFileName(dependentAssemblyFilename));
            if (File.Exists(dependentAssemblyFilename))
            {
              assembly = Assembly.ReflectionOnlyLoadFrom(dependentAssemblyFilename);
              goto label_9;
            }
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      assembly = Assembly.ReflectionOnlyLoad(name);
    }
label_9:
    return assembly;
  }

  public List<string> AdditionalReferencePaths { get; set; }

  public void DebugLoadBaseAssemblies(BaseAssemblyKey key)
  {
    string[] strArray1;
    if (key == BaseAssemblyKey.Accounting)
    {
      strArray1 = new string[14]
      {
        "MgaSystems.IMS.Accounting.Banking.dll",
        "MgaSystems.IMS.Accounting.Controls.dll",
        "MgaSystems.IMS.Accounting.Core.dll",
        "MgaSystems.IMS.Accounting.Datasets.dll",
        "MgaSystems.IMS.Accounting.dll",
        "MgaSystems.IMS.Accounting.GeneralLedger.dll",
        "MgaSystems.IMS.Accounting.OperatingExpenses.dll",
        "MGASystems.IMS.Accounting.Reporting.dll",
        "MgaSystems.IMS.Accounting.Reports.dll",
        "MgaSystems.IMS.Accounting.Services.dll",
        "MgaSystems.IMS.Accounting.Shared.dll",
        "MgaSystems.IMS.Accounting.Utilities.dll",
        "MgaSystems.IMS.BusinessObjects.dll",
        "MgaSystems.IMS.Accounting.Operating.dll"
      };
    }
    else
    {
      if (key != BaseAssemblyKey.BaseIMS)
        throw new InvalidOperationException(nameof (key));
      strArray1 = new string[29]
      {
        "MgaSystems.AddressResolver.dll",
        "MGASystems.Data.dll",
        "MGASystems.IMS.AdHocReportManager.dll",
        "MgaSystems.IMS.BusinessObjects.dll",
        "MgaSystems.IMS.CancellationNotices.dll",
        "MgaSystems.IMS.Common.dll",
        "MgaSystems.IMS.Common.Cs.dll",
        "MgaSystems.IMS.DocumentAutomation.dll",
        "MgaSystems.IMS.DocumentAutomation.Cs.dll",
        "MgaSystems.IMS.Editors.dll",
        "MgaSystems.IMS.ErrorHandling.dll",
        "MgaSystems.IMS.Excel.dll",
        "MGASystems.IMS.ExtendedControls.dll",
        "MgaSystems.IMS.Forms.dll",
        "MgaSystems.IMS.Forms.Cs.dll",
        "MgaSystems.IMS.Inspections.dll",
        "MgaSystems.IMS.IPC.dll",
        "MGASystems.IMS.Logging.dll",
        "MgaSystems.IMS.NotesDocuments.dll",
        "MgaSystems.IMS.Policies.dll",
        "MgaSystems.IMS.Policies.Cs.dll",
        "MgaSystems.IMS.Rating.dll",
        "MgaSystems.IMS.Rating.Property.dll",
        "Mga.Wpf.Ims.dll",
        "Mga.Wpf.Ims.Notes.dll",
        "MgaSystems.IMS.Reporting.dll",
        "MgaSystems.IMS.Security.dll",
        "MgaSystems.IMS.Tools.dll",
        "MGASystems.IMS.Underwriting.dll"
      };
    }
    string[] strArray2 = strArray1;
    int index = 0;
    while (index < strArray2.Length)
    {
      string str = $"{Application.StartupPath}\\{strArray2[index]}";
      if (File.Exists(str))
        this.LoadAssembly(str);
      checked { ++index; }
    }
  }

  private void LoadAssembly(string file)
  {
    if (file.Contains("DSOFramer") || file.Contains("ActiveReports") || file.Contains("GrapeCity") || file.Contains("Infragistics") || file.StartsWith("Microsoft") || file.StartsWith("Interop"))
      return;
    if (file.Contains("Aspose"))
      return;
    try
    {
      FileInfo fileInfo1 = new FileInfo(file);
      Assembly assembly;
      try
      {
        try
        {
          AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += new ResolveEventHandler(this.ObjectFactory_ReflectionOnlyAssemblyResolve);
          IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(Assembly.ReflectionOnlyLoadFrom(file));
          Func<CustomAttributeData, bool> predicate;
          // ISSUE: reference to a compiler-generated field
          if (ObjectFactory._Closure\u0024__.\u0024I56\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate = ObjectFactory._Closure\u0024__.\u0024I56\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            ObjectFactory._Closure\u0024__.\u0024I56\u002D0 = predicate = (Func<CustomAttributeData, bool>) ([SpecialName] (attributeData) => Operators.CompareString(attributeData.Constructor.DeclaringType.AssemblyQualifiedName, typeof (ImsVisibleAttribute).AssemblyQualifiedName, false) == 0);
          }
          if (!customAttributes.Any<CustomAttributeData>(predicate))
            return;
          assembly = HttpContext.Current != null ? Assembly.LoadFrom(file) : Assembly.LoadFile(file);
        }
        finally
        {
          AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= new ResolveEventHandler(this.ObjectFactory_ReflectionOnlyAssemblyResolve);
        }
      }
      catch (BadImageFormatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      catch (FileLoadException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      Attribute[] customAttributes1;
      try
      {
        customAttributes1 = Attribute.GetCustomAttributes(assembly);
      }
      catch (TypeLoadException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      catch (FileNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      bool flag = false;
      Attribute[] attributeArray = customAttributes1;
      int index1 = 0;
      while (index1 < attributeArray.Length)
      {
        if (attributeArray[index1] is ImsVisibleAttribute)
        {
          flag = true;
          break;
        }
        checked { ++index1; }
      }
      if (!flag)
        assembly = (Assembly) null;
      if ((object) assembly == null)
        return;
      FileInfo fileInfo2 = new FileInfo(file);
      string empty1 = string.Empty;
      string name = fileInfo2.Name;
      string str = FileVersionInfo.GetVersionInfo(file).FileVersion.ToString();
      this._IMSVisibleAssemblyNames.Add(SR.GetString("OF_VersionInfo", (object) name.Substring(0, name.LastIndexOf(".")), (object) str));
      // ISSUE: reference to a compiler-generated field
      ObjectFactory.LoadingNamedAssemblyEventHandler namedAssemblyEvent = this.LoadingNamedAssemblyEvent;
      if (namedAssemblyEvent != null)
        namedAssemblyEvent((object) this, new LoadingNamedAssemblyEventArgs(fileInfo2.Name, "DLL"));
      string empty2 = string.Empty;
      string empty3 = string.Empty;
      try
      {
        empty2 = SR.GetString("OF_BaseCache", (object) Application.UserAppDataPath, (object) fileInfo2.Name);
        empty3 = SR.GetString("OF_OverrideCache", (object) Application.UserAppDataPath, (object) fileInfo2.Name);
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this._enableCaching = false;
        ProjectData.ClearProjectError();
      }
      ObjectInfoCollection collection1 = new ObjectInfoCollection(fileInfo1.LastWriteTime.ToString((IFormatProvider) CultureInfo.CurrentCulture), assembly.FullName);
      ObjectInfoCollection collection2 = new ObjectInfoCollection(fileInfo1.LastWriteTime.ToString((IFormatProvider) CultureInfo.CurrentCulture), assembly.FullName);
      // ISSUE: reference to a compiler-generated field
      ObjectFactory.AssemblyLoadedEventHandler assemblyLoadedEvent = this.AssemblyLoadedEvent;
      if (assemblyLoadedEvent != null)
        assemblyLoadedEvent((object) this, new AssemblyLoadEventArgs(assembly));
      OverrideAttribute overrideAttribute = new OverrideAttribute("Test");
      Type[] types = assembly.GetTypes();
      int index2 = 0;
      while (index2 < types.Length)
      {
        Type componentType = types[index2];
        AttributeCollection attributes = TypeDescriptor.GetAttributes(componentType);
        if (attributes.Matches((Attribute) overrideAttribute))
        {
          if (!this._assemblyTable.Contains((object) assembly.FullName))
            this._assemblyTable.Add((object) assembly.FullName, (object) assembly);
          overrideAttribute = (OverrideAttribute) attributes[typeof (OverrideAttribute)];
          this._objectOverrideList.Add(componentType.FullName, overrideAttribute.TypeNameToOverride, assembly.FullName);
          collection2.Add(componentType.FullName, overrideAttribute.TypeNameToOverride, assembly.FullName);
          if (!this._baseObjectTable.ContainsKey(componentType.FullName))
          {
            this._baseObjectTable.Add(componentType.FullName, assembly.FullName);
            collection1.Add(componentType.FullName, "EMPTY", assembly.FullName);
          }
        }
        else
        {
          if (!this._assemblyTable.Contains((object) assembly.FullName))
            this._assemblyTable.Add((object) assembly.FullName, (object) assembly);
          if (!this._baseObjectTable.ContainsKey(componentType.FullName))
          {
            this._baseObjectTable.Add(componentType.FullName, assembly.FullName);
            collection1.Add(componentType.FullName, "EMPTY", assembly.FullName);
          }
        }
        checked { ++index2; }
      }
      if (!this._enableCaching)
        return;
      ObjectInfoCollection.SaveToBinaryFile(empty2, collection1);
      ObjectInfoCollection.SaveToBinaryFile(empty3, collection2);
    }
    catch (TypeLoadException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      TypeLoadException innerException = ex;
      throw new ObjectFactoryException(SR.GetString("OF_UnableLoadType", (object) innerException.TypeName), (Exception) innerException);
    }
    catch (ReflectionTypeLoadException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ReflectionTypeLoadException innerException = ex;
      Exception[] loaderExceptions = innerException.LoaderExceptions;
      int index = 0;
      while (index < loaderExceptions.Length)
      {
        Exception source = loaderExceptions[index];
        switch (source)
        {
          case FileNotFoundException notFoundException:
            throw new ObjectFactoryDependencyMissingException($"{file} attempted to load {notFoundException.FileName} but it was not found.", (Exception) innerException);
          case FileLoadException fileLoadException:
            throw new ObjectFactoryDependencyMissingException($"{file} was unable to load to load {fileLoadException.FileName}", (Exception) innerException);
          default:
            ExceptionDispatchInfo.Capture(source).Throw();
            checked { ++index; }
            continue;
        }
      }
      List<string> stringList = DependencyResolver.ResolveMissingDependencies(file);
      if (stringList.Count > 0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
          foreach (string str in stringList)
          {
            stringBuilder.Append(str);
            stringBuilder.Append("\r\n");
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        throw new ObjectFactoryDependencyMissingException(stringBuilder.ToString(), (Exception) innerException);
      }
      throw new ObjectFactoryException(SR.GetString("OF_LoadError", (object) innerException.Types[0].FullName), (Exception) innerException);
    }
    catch (FileLoadException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      FileLoadException fileLoadException = ex;
      throw new ObjectFactoryDependencyMissingException($"Object Factory is loading: {file}\n\n{fileLoadException.ToString()}");
    }
  }

  private void LoadBaseCache(ObjectInfoCollection baseCollection, string file)
  {
    if (!this._assemblyTable.Contains((object) baseCollection.AssemblyName))
      this._assemblyTable.Add((object) baseCollection.AssemblyName, (object) file);
    try
    {
      foreach (ObjectInfo objectInfo in (List<ObjectInfo>) baseCollection)
        this._baseObjectTable.Add(objectInfo.ObjectName, baseCollection.AssemblyName);
    }
    finally
    {
      List<ObjectInfo>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void LoadOverrideCache(ObjectInfoCollection objectInfoCollection)
  {
    this._objectOverrideList.AddRange((IEnumerable<ObjectInfo>) objectInfoCollection);
  }

  public void LoadCustomizationFile(string file)
  {
    if (file == null)
      throw new ArgumentNullException(nameof (file));
    if (string.Compare(Path.GetExtension(file), ".dll", true, CultureInfo.CurrentCulture) != 0)
      return;
    try
    {
      FileInfo fileInfo1 = new FileInfo(file);
      string str1 = file.Replace(Path.GetExtension(file), ".IMScache");
      string str2 = file.Replace(Path.GetExtension(file), ".IMScache.ov");
      if (this._enableCaching && File.Exists(str1))
      {
        ObjectInfoCollection objectInfoCollection = (ObjectInfoCollection) null;
        ObjectInfoCollection baseCollection = ObjectInfoCollection.LoadFromBinaryFile(str1);
        if (File.Exists(str2))
        {
          FileInfo fileInfo2 = new FileInfo(file);
          // ISSUE: reference to a compiler-generated field
          ObjectFactory.LoadingNamedAssemblyEventHandler namedAssemblyEvent = this.LoadingNamedAssemblyEvent;
          if (namedAssemblyEvent != null)
            namedAssemblyEvent((object) this, new LoadingNamedAssemblyEventArgs(fileInfo2.Name, "local cache"));
          objectInfoCollection = ObjectInfoCollection.LoadFromBinaryFile(str2);
        }
        if (Operators.CompareString(baseCollection.Version, fileInfo1.LastWriteTime.ToString((IFormatProvider) CultureInfo.CurrentCulture), false) == 0)
        {
          this.LoadBaseCache(baseCollection, file);
          this.LoadOverrideCache(objectInfoCollection);
        }
        else
          this.LoadAssembly(file);
      }
      else
        this.LoadAssembly(file);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ex.Data.Add((object) "File", (object) file);
      throw;
    }
  }

  public void LoadCustomizationDLLs() => this.LoadCustomizationDLLs(Application.StartupPath);

  public void LoadCustomizationDLLs(string rootPath)
  {
    if (Directory.Exists(rootPath))
    {
      string[] files = Directory.GetFiles(rootPath);
      int index = 0;
      while (index < files.Length)
      {
        string file = files[index];
        if (Operators.CompareString(file.ToUpper(), "MGA.WPF.IMS.DLL", false) == 0 && !DotnetEnvironment.IsNetFx35Sp1Installed())
          throw new ObjectFactoryDependencyMissingException("The IMS could not find PresentationFramework, Version=3.0.0.0");
        this.LoadCustomizationFile(file);
        checked { ++index; }
      }
    }
    this.ResolveObjectListHierarchy();
  }

  public static Attribute GetAttributeFromType(Type type, Attribute searchAttribute)
  {
    if (searchAttribute == null)
      throw new ArgumentNullException(nameof (searchAttribute));
    AttributeCollection attributes = TypeDescriptor.GetAttributes(type);
    return !attributes.Matches(searchAttribute) ? (Attribute) null : attributes[searchAttribute.GetType()];
  }

  public Type[] QueryTypesWithAttribute(Attribute attribute)
  {
    lock ((object) this._cachedAttributedTypes)
    {
      if (this._cachedAttributedTypes.ContainsKey(attribute.ToString()))
        return this._cachedAttributedTypes[attribute.ToString()];
      List<Type> typeList = new List<Type>();
      Hashtable hashtable = (Hashtable) this._assemblyTable.Clone();
      try
      {
        foreach (object key in (IEnumerable) hashtable.Keys)
        {
          Type[] types = this.GetAssembly(Conversions.ToString(key)).GetTypes();
          int index = 0;
          while (index < types.Length)
          {
            Type componentType = types[index];
            AttributeCollection attributes = TypeDescriptor.GetAttributes(componentType);
            try
            {
              foreach (Attribute attribute1 in attributes)
              {
                if (attribute1.Match((object) attribute))
                {
                  typeList.Add(componentType);
                  break;
                }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            checked { ++index; }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      Type[] array = typeList.ToArray();
      this._cachedAttributedTypes.Add(attribute.ToString(), array);
      return array;
    }
  }

  public Type[] GetResolvedTypes(Type[] types)
  {
    List<Type> typeList = new List<Type>();
    Type[] typeArray = types;
    int index = 0;
    while (index < typeArray.Length)
    {
      Type baseType = typeArray[index];
      if (this._objectOverrideList.GetItemFromType(baseType) == null)
        typeList.Add(baseType);
      checked { ++index; }
    }
    return typeList.ToArray();
  }

  public Type[] QueryTypesWithInterface(Type interfaceType)
  {
    Type[] typeArray = (Type[]) null;
    if (!this._cachedInterfaceTypes.TryGetValue(interfaceType.ToString(), out typeArray))
    {
      List<Type> typeList = new List<Type>();
      Hashtable hashtable = (Hashtable) this._assemblyTable.Clone();
      try
      {
        foreach (object key in (IEnumerable) hashtable.Keys)
        {
          Type[] types = this.GetAssembly(Conversions.ToString(key)).GetTypes();
          int index = 0;
          while (index < types.Length)
          {
            Type derivedType = types[index];
            if (derivedType.IsClass && ObjectFactory.TypeSupports(derivedType, interfaceType))
              typeList.Add(derivedType);
            checked { ++index; }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      object syncObj = this._syncObj;
      ObjectFlowControl.CheckForSyncLockOnValueType(syncObj);
      bool lockTaken = false;
      try
      {
        Monitor.Enter(syncObj, ref lockTaken);
        if (!this._cachedInterfaceTypes.TryGetValue(interfaceType.ToString(), out typeArray))
        {
          typeArray = typeList.ToArray();
          this._cachedInterfaceTypes.Add(interfaceType.ToString(), typeArray);
        }
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(syncObj);
      }
    }
    return typeArray;
  }

  public void ResolveObjectListHierarchy() => this.ResolveObjectListInternal();

  private void ResolveObjectListInternal()
  {
    bool flag = true;
    int num = 0;
    while (flag & num < 5)
    {
      flag = false;
      ++num;
      try
      {
        foreach (ObjectInfo objectOverride in (List<ObjectInfo>) this._objectOverrideList)
          flag = ObjectFactory.ResolveObjectChain(objectOverride, this._objectOverrideList) | flag;
      }
      finally
      {
        List<ObjectInfo>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
  }

  private static bool ResolveObjectChain(ObjectInfo obj, ObjectInfoCollection objectList)
  {
    bool flag = false;
    int num = objectList.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      ObjectInfo objectInfo = objectList[index];
      if (Operators.CompareString(objectInfo.ObjectName, obj.BaseClass, false) == 0)
      {
        objectInfo.ObjectName = obj.ObjectName;
        objectInfo.AssemblyName = obj.AssemblyName;
        flag = true;
      }
    }
    return flag;
  }

  public static ObjectFactory Instance
  {
    get
    {
      ObjectFactory objFactory;
      if (HttpContext.Current == null)
      {
        if (ObjectFactory._objFactory == null)
          ObjectFactory._objFactory = new ObjectFactory();
        objFactory = ObjectFactory._objFactory;
      }
      else if (ObjectFactory.CacheInWebApplication)
      {
        if (HttpContext.Current.Application[nameof (ObjectFactory)] == null)
        {
          ObjectFactory._objFactory = new ObjectFactory();
          HttpContext.Current.Application.Add(nameof (ObjectFactory), (object) ObjectFactory._objFactory);
        }
        objFactory = (ObjectFactory) HttpContext.Current.Application[nameof (ObjectFactory)];
      }
      else
      {
        if (!HttpContext.Current.Items.Contains((object) nameof (ObjectFactory)))
        {
          ObjectFactory._objFactory = new ObjectFactory();
          HttpContext.Current.Items.Add((object) nameof (ObjectFactory), (object) ObjectFactory._objFactory);
        }
        objFactory = (ObjectFactory) HttpContext.Current.Items[(object) nameof (ObjectFactory)];
      }
      return objFactory;
    }
  }

  public Form CreateFormEX(Type baseFormType, params object[] args)
  {
    return this.CreateForm(baseFormType, args);
  }

  public Form CreateForm(Type baseFormType, object[] args)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.CreateObject(baseFormType, args));
    Form form;
    if (objectValue != null)
    {
      try
      {
        form = (Form) objectValue;
      }
      catch (InvalidCastException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        form = (Form) null;
        ProjectData.ClearProjectError();
      }
    }
    else
      form = (Form) null;
    return form;
  }

  public Form CreateForm(Type baseFormType)
  {
    object[] args = (object[]) null;
    return this.CreateForm(baseFormType, args);
  }

  public Form CreateFormEX(Type baseFormType, Type mustSupport, params object[] args)
  {
    return this.CreateForm(baseFormType, mustSupport, args);
  }

  public Form CreateForm(Type baseFormType, Type mustSupport, object[] args)
  {
    Type[] mustSupport1 = new Type[2]
    {
      typeof (Form),
      mustSupport
    };
    return (Form) RuntimeHelpers.GetObjectValue(this.CreateObject(baseFormType, mustSupport1, args));
  }

  public Form CreateForm(Type baseFormType, Type mustSupport)
  {
    Type[] mustSupport1 = new Type[2]
    {
      typeof (Form),
      mustSupport
    };
    return (Form) RuntimeHelpers.GetObjectValue(this.CreateObject(baseFormType, mustSupport1));
  }

  public Form CreateFormEX(Type baseFormType, Type[] mustSupport, params object[] args)
  {
    return this.CreateForm(baseFormType, mustSupport, args);
  }

  public Form CreateForm(Type baseFormType, Type[] mustSupport, object[] args)
  {
    Type[] mustSupport1 = mustSupport != null ? new Type[mustSupport.GetUpperBound(0) + 1 + 1] : throw new ArgumentNullException(nameof (mustSupport));
    mustSupport1[0] = typeof (Form);
    int upperBound = mustSupport1.GetUpperBound(0);
    for (int index = 1; index <= upperBound; ++index)
      mustSupport1[index] = mustSupport[index - 1];
    return (Form) RuntimeHelpers.GetObjectValue(this.CreateObject(baseFormType, mustSupport1, args));
  }

  public Form CreateForm(Type baseFormType, Type[] mustSupport)
  {
    Type[] mustSupport1 = mustSupport != null ? new Type[mustSupport.GetUpperBound(0) + 1 + 1] : throw new ArgumentNullException(nameof (mustSupport));
    mustSupport1[0] = typeof (Form);
    int upperBound = mustSupport1.GetUpperBound(0);
    for (int index = 1; index <= upperBound; ++index)
      mustSupport1[index] = mustSupport[index - 1];
    return (Form) RuntimeHelpers.GetObjectValue(this.CreateObject(baseFormType, mustSupport1));
  }

  private static bool TypeSupports(Type derivedType, Type baseType)
  {
    return baseType.IsClass && derivedType.IsClass && (derivedType.IsSubclassOf(baseType) || derivedType.Equals(baseType)) || baseType.IsInterface && (object) derivedType.GetInterface(baseType.FullName) != null;
  }

  [Obsolete("Use CreateObjectAs instead")]
  public object CreateObject(Type baseType)
  {
    object[] args = (object[]) null;
    return this.CreateObject(baseType, args);
  }

  [Obsolete("Use CreateObjectAs instead")]
  public object CreateObject(Type baseType, Type mustSupport)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.CreateObject(baseType));
    return ObjectFactory.TypeSupports(objectValue.GetType(), mustSupport) ? objectValue : throw new ObjectFactoryException(SR.GetString("OF_BaseNotImpl", (object) mustSupport.FullName));
  }

  [Obsolete("Use CreateObjectAs instead")]
  public object CreateObject(Type baseType, Type mustSupport, object[] args)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.CreateObject(baseType, args));
    return ObjectFactory.TypeSupports(objectValue.GetType(), mustSupport) ? objectValue : throw new ObjectFactoryException(SR.GetString("OF_BaseNotImpl", (object) mustSupport.FullName));
  }

  public object CreateObjectEX(Type baseType, Type mustSupport, params object[] args)
  {
    return this.CreateObject(baseType, mustSupport, args);
  }

  public T CreateObjectAs<T>(Type mustSupport, params object[] args) where T : class
  {
    return (T) this.CreateObjectEX(typeof (T), mustSupport, args);
  }

  public TBase CreateObjectTypeAs<TBase>(Type objectType, params object[] args)
  {
    return (TBase) this.CreateObjectEX(objectType, typeof (TBase), args);
  }

  [Obsolete("Use CreateObjectAs instead")]
  public object CreateObject(Type baseType, Type[] mustSupport)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.CreateObject(baseType));
    Type[] typeArray = mustSupport;
    int index = 0;
    while (index < typeArray.Length)
    {
      Type baseType1 = typeArray[index];
      if (!ObjectFactory.TypeSupports(objectValue.GetType(), baseType1))
        throw new ObjectFactoryException(SR.GetString("OF_BaseNotImpl", (object) baseType1.FullName));
      checked { ++index; }
    }
    return objectValue;
  }

  [Obsolete("Use CreateObjectAs instead")]
  public object CreateObject(Type baseType, Type[] mustSupport, object[] args)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.CreateObject(baseType, args));
    Type[] typeArray = mustSupport;
    int index = 0;
    while (index < typeArray.Length)
    {
      Type baseType1 = typeArray[index];
      if (!ObjectFactory.TypeSupports(objectValue.GetType(), baseType1))
        throw new ObjectFactoryException(SR.GetString("OF_BaseNotImpl", (object) baseType1.FullName));
      checked { ++index; }
    }
    return objectValue;
  }

  public object CreateObjectEX(Type baseType, Type[] mustSupport, params object[] args)
  {
    return this.CreateObject(baseType, mustSupport, args);
  }

  public T CreateObjectAs<T>(Type[] mustSupport, params object[] args) where T : class
  {
    return (T) this.CreateObjectEX(typeof (T), mustSupport, args);
  }

  [Obsolete("Use CreateObjectAs instead")]
  public object CreateObject(Type baseType, object[] args)
  {
    return this.InternalCreateObject(baseType, args);
  }

  public object CreateObjectEX(Type baseType, params object[] args)
  {
    return this.CreateObject(baseType, args);
  }

  public T CreateObjectAs<T>(params object[] args) where T : class
  {
    return (T) this.CreateObjectEX(typeof (T), args);
  }

  private static object CreateObjectPrivateCtor(Type baseType)
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString(ObjectFactory.Instance.ResolveObjectToCreate(baseType).ObjectName);
    Binder binder = (Binder) null;
    ConstructorInfo[] constructors = typeFromString.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
    if (constructors == null)
      throw new ObjectFactoryException(SR.GetString("OF_PrivCtorOnly"));
    return constructors.Length == 1 ? RuntimeHelpers.GetObjectValue(constructors[0].Invoke(BindingFlags.CreateInstance, binder, (object[]) null, (CultureInfo) null)) : throw new ObjectFactoryException(SR.GetString("OF_PrivCtorOnly"));
  }

  private ObjectInfo ResolveObjectToCreate(Type baseType)
  {
    ObjectInfo itemFromType = this._objectOverrideList.GetItemFromType(baseType);
    ObjectInfo create;
    if (itemFromType == null)
    {
      Assembly assembly = this._baseObjectTable.ContainsKey(baseType.ToString()) ? this.GetAssembly(this._baseObjectTable[baseType.ToString()]) : throw new ObjectFactoryException(SR.GetString("OF_ObjResolveFail"));
      create = new ObjectInfo(baseType.ToString(), baseType.ToString(), assembly.FullName);
    }
    else
      create = itemFromType;
    return create;
  }

  private object InternalCreateObject(Type baseType, object[] args)
  {
    if (this.ShouldLog)
      this.WriteLog($"InternalCreateObject, BaseTypeRequested: {baseType.ToString()}", (object) null);
    if (this.TreatTypesAsStrings)
      baseType = this.CreateTypeFromString(baseType.Name);
    ObjectInfo itemFromType = this._objectOverrideList.GetItemFromType(baseType);
    object obj = (object) null;
    Binder binder = (Binder) null;
    if (itemFromType == null)
    {
      if (this._baseObjectTable.ContainsKey(baseType.ToString()))
      {
        Assembly assembly = this.GetAssembly(this._baseObjectTable[baseType.ToString()]);
        try
        {
          obj = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(baseType.ToString(), true, BindingFlags.CreateInstance, binder, args, Application.CurrentCulture, (object[]) null));
        }
        catch (MissingMethodException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          obj = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(baseType, BindingFlags.CreateInstance, binder, args, CultureInfo.CurrentCulture));
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      Assembly assembly = this.GetAssembly(itemFromType.AssemblyName);
      obj = args == null ? RuntimeHelpers.GetObjectValue(assembly.CreateInstance(itemFromType.ObjectName)) : RuntimeHelpers.GetObjectValue(assembly.CreateInstance(itemFromType.ObjectName, true, BindingFlags.CreateInstance, binder, args, Application.CurrentCulture, (object[]) null));
    }
    if (obj != null)
    {
      ObjectInfoEventArgs e = new ObjectInfoEventArgs(RuntimeHelpers.GetObjectValue(obj));
      // ISSUE: reference to a compiler-generated field
      EventHandler<ObjectInfoEventArgs> constructedEvent1 = this.PreviewObjectConstructedEvent;
      if (constructedEvent1 != null)
        constructedEvent1((object) this, e);
      object objectValue = RuntimeHelpers.GetObjectValue(e.ConstructedObject);
      if (objectValue is Form form)
      {
        form.AutoScaleMode = AutoScaleMode.None;
        if (form.Icon == this.StdWindowsIcon)
          form.Icon = MGASystems.Common.My.Resources.Resources.Logo;
      }
      if (objectValue is ILoadAutomatically loadAutomatically)
        loadAutomatically.PerformLoad();
      // ISSUE: reference to a compiler-generated field
      ObjectFactory.ObjectConstructedEventHandler constructedEvent2 = this.ObjectConstructedEvent;
      if (constructedEvent2 != null)
        constructedEvent2(RuntimeHelpers.GetObjectValue(objectValue), EventArgs.Empty);
      if (this.ShouldLog)
        this.WriteLog($"InternalCreateObject, TypeReturned: {objectValue.GetType().ToString()}", (object) null);
      return objectValue;
    }
    if (itemFromType == null)
    {
      if (this._baseObjectTable.ContainsKey(baseType.ToString()))
        throw new ObjectFactoryException($"Type {baseType.ToString()} was not found in the base object table.");
      throw new ObjectFactoryException("Could not load non-overriden type " + baseType.ToString());
    }
    string str = this._baseObjectTable[baseType.ToString()];
    throw new ObjectFactoryException($"Could not load overridden type {baseType.ToString()} from {str}");
  }

  private Icon StdWindowsIcon
  {
    get
    {
      if (this._stdWindowsIcon == null)
      {
        using (Form form = new Form())
          this._stdWindowsIcon = form.Icon;
      }
      return this._stdWindowsIcon;
    }
  }

  public Type CreateTypeFromString(string typeName)
  {
    typeName = typeName.Trim();
    Type type;
    try
    {
      foreach (ObjectInfo objectOverride in (List<ObjectInfo>) this._objectOverrideList)
      {
        if (Operators.CompareString(objectOverride.BaseClass, typeName, false) == 0 || Operators.CompareString(objectOverride.ObjectName, typeName, false) == 0)
        {
          type = this.GetAssembly(objectOverride.AssemblyName).GetType(objectOverride.ObjectName);
          goto label_9;
        }
      }
    }
    finally
    {
      List<ObjectInfo>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (this._baseObjectTable.ContainsKey(typeName))
    {
      type = this.GetAssembly(this._baseObjectTable[typeName]).GetType(typeName);
    }
    else
    {
      typeName = ObjectFactory.ToggleIMSCasing(typeName);
      type = !this._baseObjectTable.ContainsKey(typeName) ? (Type) null : this.GetAssembly(this._baseObjectTable[typeName]).GetType(typeName);
    }
label_9:
    return type;
  }

  private static string ToggleIMSCasing(string typeName)
  {
    return typeName.IndexOf(".IMS.") == -1 ? (typeName.IndexOf(".Ims.") == -1 ? (Operators.CompareString(typeName, "frmPolicyDetail", false) != 0 ? (Operators.CompareString(typeName, "frmQuoteEdit", false) != 0 ? typeName : "MGASystems.IMS.Forms.frmQuoteEdit") : "MGASystems.IMS.Forms.frmPolicyDetail") : typeName.Replace(".Ims.", ".IMS.")) : typeName.Replace(".IMS.", ".Ims.");
  }

  public Type GetDerivedType(Type baseType)
  {
    ObjectInfo itemFromType = this._objectOverrideList.GetItemFromType(baseType);
    return itemFromType == null ? (Type) null : this.GetAssembly(itemFromType.AssemblyName).GetType(itemFromType.ObjectName);
  }

  private Assembly GetAssembly(string assemblyKey)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this._assemblyTable[(object) assemblyKey]);
    Assembly assembly1 = objectValue as Assembly;
    Assembly assembly2;
    if ((object) assembly1 != null)
      assembly2 = assembly1;
    else if (objectValue is string path)
    {
      Assembly assembly3 = Assembly.LoadFile(path);
      this._assemblyTable[(object) assemblyKey] = (object) assembly3;
      assembly2 = assembly3;
    }
    else
      assembly2 = (Assembly) null;
    return assembly2;
  }

  public static bool CacheInWebApplication { get; set; }

  public static void SaveObjectFactoryToApplication()
  {
    if (HttpContext.Current.Application[nameof (ObjectFactory)] == null)
      HttpContext.Current.Application.Add(nameof (ObjectFactory), (object) ObjectFactory.Instance);
    else
      HttpContext.Current.Application[nameof (ObjectFactory)] = (object) ObjectFactory.Instance;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public static void ClearRegistration() => ObjectFactory._objFactory = (ObjectFactory) null;

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool RegisterOverrideType(Type baseType, Type overrideType, bool addIfNew)
  {
    bool flag;
    try
    {
      flag = Operators.CompareString(this.GetExistingRegistration(baseType, overrideType).ObjectName, overrideType.FullName, false) == 0;
      goto label_6;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (addIfNew)
        this.RegisterNewOverride(baseType, overrideType);
      else
        ErrorHandler.SilentHandleError(ex2);
      ProjectData.ClearProjectError();
    }
    flag = false;
label_6:
    return flag;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool RegisterOverrideType(Type baseType, Type overrideType)
  {
    return this.RegisterOverrideType(baseType, overrideType, false);
  }

  private ObjectInfo GetExistingRegistration(Type baseType, Type overrideType)
  {
    ObjectInfo create = this.ResolveObjectToCreate(baseType);
    create.ObjectName = overrideType.FullName;
    create.AssemblyName = overrideType.Assembly.FullName;
    return create;
  }

  private void RegisterNewOverride(Type baseType, Type overrideType)
  {
    this._objectOverrideList.Add(baseType.FullName, overrideType.FullName, overrideType.Assembly.FullName);
    if (this._assemblyTable.Contains((object) overrideType.Assembly.FullName))
      return;
    this._assemblyTable.Add((object) overrideType.Assembly.FullName, (object) overrideType.Assembly);
  }

  public delegate void ObjectConstructedEventHandler(object sender, EventArgs e);

  public delegate void AssemblyLoadedEventHandler(object sender, AssemblyLoadEventArgs e);

  public delegate void LoadingNamedAssemblyEventHandler(
    object sender,
    LoadingNamedAssemblyEventArgs e);
}
