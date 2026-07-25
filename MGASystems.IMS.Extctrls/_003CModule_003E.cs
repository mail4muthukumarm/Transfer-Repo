// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: MGASystems.IMS.ExtendedControls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 933BCBB6-80B3-406B-A226-C528DBCF94BC
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.ExtendedControls.dll

using \u003CCppImplementationDetails\u003E;
using \u003CCrtImplementationDetails\u003E;
using MGASystems.IMS.ExtendedControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
internal class \u003CModule\u003E
{
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0x7d798523\u002E__xc_mp_z;
  [FixedAddressValueType]
  internal static int \u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FUninitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0x7d798523\u002E__xi_vt_a;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FInitializedPerAppDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static bool \u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FIsDefaultDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0x7d798523\u002E__xc_ma_a;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FInitializedNative\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static int \u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FInitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0x7d798523\u002E__xc_ma_z;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FInitializedVtables\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0x7d798523\u002E__xi_vt_z;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static unsafe delegate*<void> \u003FA0x7d798523\u002E\u003FInitializedPerProcess\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static bool \u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static bool \u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static bool \u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static int \u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA;
  internal static uint \u003FProcessAttach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static uint \u003FThreadAttach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static TriBool.State \u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A;
  internal static uint \u003FProcessDetach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static uint \u003FThreadDetach\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static uint \u003FProcessVerifier\u0040NativeDll\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400IB;
  internal static TriBool.State \u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A;
  internal static bool \u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0x7d798523\u002E__xc_mp_a;
  public static unsafe int** __unep\u0040\u003FDoNothing\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z;
  public static unsafe int** __unep\u0040\u003F_UninitializeDefaultDomain\u0040LanguageSupport\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z;
  [FixedAddressValueType]
  internal static uint __exit_list_size_app_domain;
  [FixedAddressValueType]
  internal static Handle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E \u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A;
  internal static unsafe delegate*<void> \u003FA0x49040904\u002E\u003F_lock\u0024initializer\u0024\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0P6MXXZA;
  [FixedAddressValueType]
  internal static unsafe delegate*<void>* __onexitbegin_app_domain;
  internal static uint \u003FA0x49040904\u002E__exit_list_size;
  internal static unsafe delegate*<void>* \u003FA0x49040904\u002E__onexitend;
  internal static unsafe delegate*<void>* \u003FA0x49040904\u002E__onexitbegin;
  [FixedAddressValueType]
  internal static unsafe delegate*<void>* __onexitend_app_domain;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0BE\u0040\u0024\u0024CB_W \u003F\u003F_C\u0040_1CI\u0040CEGIFMP\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAG\u003F\u0024AAr\u003F\u0024AAo\u003F\u0024AAu\u003F\u0024AAp\u003F\u0024AAD\u003F\u0024AAe\u003F\u0024AAs\u003F\u0024AAc\u003F\u0024AAr\u003F\u0024AAi\u003F\u0024AAp\u003F\u0024AAt\u003F\u0024AAo\u003F\u0024AAr\u003F\u0024AA\u003F\u0024AA\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0N\u0040\u0024\u0024CB_W \u003F\u003F_C\u0040_1BK\u0040BPLEJIIK\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAC\u003F\u0024AAo\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAe\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAs\u003F\u0024AA\u003F\u0024AA\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0L\u0040\u0024\u0024CB_W \u003F\u003F_C\u0040_1BG\u0040BCOIGAE\u0040\u003F\u0024AAM\u003F\u0024AAA\u003F\u0024AAP\u003F\u0024AAI\u003F\u0024AA\u003F5\u003F\u0024AAe\u003F\u0024AAr\u003F\u0024AAr\u003F\u0024AAo\u003F\u0024AAr\u003F\u0024AA\u003F\u0024AA\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0CA\u0040\u0024\u0024CB_W \u003F\u003F_C\u0040_1EA\u0040FPHBKJHF\u0040\u003F\u0024AAU\u003F\u0024AAn\u003F\u0024AAa\u003F\u0024AAb\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AA\u003F5\u003F\u0024AAt\u003F\u0024AAo\u003F\u0024AA\u003F5\u003F\u0024AAr\u003F\u0024AAe\u003F\u0024AAt\u003F\u0024AAr\u003F\u0024AAi\u003F\u0024AAe\u003F\u0024AAv\u003F\u0024AAe\u003F\u0024AA\u003F5\u003F\u0024AAm\u003F\u0024AAe\u003F\u0024AAs\u003F\u0024AAs\u003F\u0024AAa\u003F\u0024AAg\u003F\u0024AAe\u003F\u0024AA\u003F5\u003F\u0024AAb\u003F\u0024AAo\u003F\u0024AAd\u003F\u0024AAy\u003F\u0024AA\u003F\u0024AA\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_12 \u003F\u003F_R2DropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3DropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7DropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040IUnknown\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3IDropTarget\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3IUnknown\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_49 \u003F\u003F_R0\u003FAVDropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4DropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u00406B\u0040;
  internal static int __\u0040\u0040_PchSym_\u004000\u0040UgvznLhbhgvnLhvierxvhUyfrowhUrnhLvcgvimzoLxlnklmvmghUntzhbhgvnhOrnhOvcgvmwvwxlmgilohUhlfixvhUntzhbhgvnhOrnhOvcgvmwvwxlmgilohUivovzhvUhgwzucOlyq\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2IUnknown\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040IDropTarget\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_18 \u003F\u003F_R0\u003FAUIDropTarget\u0040\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040DropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u00408;
  internal static _GUID CLSID_MailMessage;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_15 \u003F\u003F_R0\u003FAUIUnknown\u0040\u0040\u00408;
  internal static int \u003FblockSize\u0040\u003F1\u003F\u003FStreamToFile\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040CMP\u0024AAVFileInfo\u0040IO\u0040System\u0040\u0040PAUIStream\u0040\u0040P\u0024AAVString\u00408\u0040\u0040Z\u00404HB;
  internal static _GUID IID_IMessage;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2IDropTarget\u0040\u00408;
  static unsafe int** __unep\u0040\u003FMAPIFreeBuffer\u0040\u0040\u0024\u0024J14YGKPAX\u0040Z;
  static unsafe int** __unep\u0040\u003FMAPIAllocateMore\u0040\u0040\u0024\u0024J212YGJKPAXPAPAX\u0040Z;
  static unsafe int** __unep\u0040\u003FMAPIAllocateBuffer\u0040\u0040\u0024\u0024J18YGJKPAPAX\u0040Z;
  public static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AXXZ __xc_z;
  public static volatile uint __native_vcclrit_reason;
  public static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AXXZ __xc_a;
  public static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AHXZ __xi_a;
  public static volatile __enative_startup_state __native_startup_state;
  public static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AHXZ __xi_z;
  public static unsafe void* __native_startup_lock;
  public static volatile uint __native_dllmain_reason;
  public static \u0024ArrayType\u0024\u0024\u0024BY01Q6AXXZ \u003F\u003F_7type_info\u0040\u00406B\u0040;
  public static _GUID IID_IDropTarget;
  public static _GUID IID_IUnknown;

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInDllMain()
  {
    return \u003CModule\u003E.__native_dllmain_reason != uint.MaxValue;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInProcessAttach()
  {
    return \u003CModule\u003E.__native_dllmain_reason == 1U;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInProcessDetach()
  {
    return \u003CModule\u003E.__native_dllmain_reason == 0U;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsInVcclrit()
  {
    return \u003CModule\u003E.__native_vcclrit_reason != uint.MaxValue;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsSafeForManagedCode()
  {
    return (\u003CModule\u003E.__native_dllmain_reason != uint.MaxValue ? 1 : 0) == 0 || (\u003CModule\u003E.__native_vcclrit_reason != uint.MaxValue ? 1 : 0) != 0 || \u003CModule\u003E.__native_dllmain_reason != 1U && \u003CModule\u003E.__native_dllmain_reason != 0U;
  }

  internal static unsafe int \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EDoNothing(
    void* cookie)
  {
    GC.KeepAlive((object) int.MaxValue);
    return 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasPerProcess()
  {
    if (\u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A != (TriBool.State) 2)
      return \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A == (TriBool.State) -1;
    void** voidPtr = (void**) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xc_mp_a;
    if (ref \u003CModule\u003E.\u003FA0x7d798523\u002E__xc_mp_a < ref \u003CModule\u003E.\u003FA0x7d798523\u002E__xc_mp_z)
    {
      while (*(int*) voidPtr == 0)
      {
        voidPtr += 4;
        if ((IntPtr) voidPtr >= ref \u003CModule\u003E.\u003FA0x7d798523\u002E__xc_mp_z)
          goto label_5;
      }
      \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) -1;
      return true;
    }
label_5:
    \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) 0;
    return false;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasNative()
  {
    if (\u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A != (TriBool.State) 2)
      return \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A == (TriBool.State) -1;
    void** voidPtr1 = (void**) &\u003CModule\u003E.__xi_a;
    if (ref \u003CModule\u003E.__xi_a < ref \u003CModule\u003E.__xi_z)
    {
      while (*(int*) voidPtr1 == 0)
      {
        voidPtr1 += 4;
        if ((IntPtr) voidPtr1 >= ref \u003CModule\u003E.__xi_z)
          goto label_5;
      }
      \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) -1;
      return true;
    }
label_5:
    void** voidPtr2 = (void**) &\u003CModule\u003E.__xc_a;
    if (ref \u003CModule\u003E.__xc_a < ref \u003CModule\u003E.__xc_z)
    {
      while (*(int*) voidPtr2 == 0)
      {
        voidPtr2 += 4;
        if ((IntPtr) voidPtr2 >= ref \u003CModule\u003E.__xc_z)
          goto label_9;
      }
      \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) -1;
      return true;
    }
label_9:
    \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4State\u0040TriBool\u00402\u0040A = (TriBool.State) 0;
    return false;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsInitialization()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasPerProcess() && !\u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA || \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasNative() && !\u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA && \u003CModule\u003E.__native_startup_state == (__enative_startup_state) 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsUninitialization()
  {
    return \u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  }

  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EInitialize()
  {
    // ISSUE: cast to a function pointer type
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain((delegate* unmanaged[Stdcall]<void*, int>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FDoNothing\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z, (void*) 0);
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = false;
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0x7d798523\u002E\u003F\u003F__E\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during vtable initialization.\n");
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initterm_m((delegate*<void*>*) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xi_vt_a, (delegate*<void*>*) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xi_vt_z);
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
  }

  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeDefaultAppDomain(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EInitialize();
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeNative(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during native initialization.\n");
    \u003CModule\u003E.__security_init_cookie();
    \u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ENativeDll\u002EIsSafeForManagedCode())
      \u003CModule\u003E._amsg_exit(33);
    switch (\u003CModule\u003E.__native_startup_state)
    {
      case (__enative_startup_state) 0:
        \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
        \u003CModule\u003E.__native_startup_state = (__enative_startup_state) 1;
        if (\u003CModule\u003E._initterm_e((delegate* unmanaged[Cdecl]<int>*) &\u003CModule\u003E.__xi_a, (delegate* unmanaged[Cdecl]<int>*) &\u003CModule\u003E.__xi_z) != 0)
          \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0));
        \u003CModule\u003E._initterm((delegate* unmanaged[Cdecl]<void>*) &\u003CModule\u003E.__xc_a, (delegate* unmanaged[Cdecl]<void>*) &\u003CModule\u003E.__xc_z);
        \u003CModule\u003E.__native_startup_state = (__enative_startup_state) 2;
        \u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
        \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
        break;
      case (__enative_startup_state) 1:
        \u003CModule\u003E._amsg_exit(33);
        break;
    }
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerProcess(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during process initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initatexit_m();
    \u003CModule\u003E._initterm_m((delegate*<void*>*) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xc_mp_a, (delegate*<void*>*) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xc_mp_z);
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during appdomain initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initatexit_app_domain();
    \u003CModule\u003E._initterm_m((delegate*<void*>*) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xc_ma_a, (delegate*<void*>*) &\u003CModule\u003E.\u003FA0x7d798523\u002E__xc_ma_z);
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during registration for the unload events.\n");
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(new EventHandler(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload));
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
    if (\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
      \u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoDllLanguageSupportValidation();
    void* fiberPtrId = \u003CModule\u003E._getFiberPtrId();
    int num1 = 0;
    int num2 = 0;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      while (num2 == 0)
      {
        try
        {
        }
        finally
        {
          IntPtr comparand = (IntPtr) 0;
          IntPtr num3 = (IntPtr) fiberPtrId;
          // ISSUE: cast to a reference type
          void* voidPtr = (void*) Interlocked.CompareExchange((IntPtr&) ref \u003CModule\u003E.__native_startup_lock, num3, comparand);
          if ((IntPtr) voidPtr == IntPtr.Zero)
            num2 = 1;
          else if (voidPtr == fiberPtrId)
          {
            num1 = 1;
            num2 = 1;
          }
        }
        if (num2 == 0)
          \u003CModule\u003E.Sleep(1000U);
      }
      if (!\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
      {
        if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsInitialization())
          \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeDefaultAppDomain(obj0);
      }
    }
    finally
    {
      if (num1 == 0)
      {
        IntPtr num4 = (IntPtr) 0;
        // ISSUE: cast to a reference type
        Interlocked.Exchange((IntPtr&) ref \u003CModule\u003E.__native_startup_lock, num4);
      }
    }
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables(obj0);
    if (\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeNative(obj0);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerProcess(obj0);
    }
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain(obj0);
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 1;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer(obj0);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain()
  {
    \u003CModule\u003E._app_exit_callback();
  }

  internal static unsafe int \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_UninitializeDefaultDomain(
    void* cookie)
  {
    \u003CModule\u003E._exit_callback();
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    if (\u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA)
    {
      \u003CModule\u003E._cexit();
      \u003CModule\u003E.__native_startup_state = (__enative_startup_state) 0;
      \u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    }
    \u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    return 0;
  }

  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain()
  {
    if (!\u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA)
      return;
    if (AppDomain.CurrentDomain.IsDefaultAppDomain())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_UninitializeDefaultDomain((void*) 0);
    }
    else
    {
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain((delegate* unmanaged[Stdcall]<void*, int>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003F_UninitializeDefaultDomain\u0040LanguageSupport\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z, (void*) 0);
    }
  }

  [PrePrepareMethod]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload(
    object source,
    EventArgs arguments)
  {
    if (\u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA == 0 || Interlocked.Exchange(ref \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA, 1) != 0)
      return;
    int num = Interlocked.Decrement(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA) == 0 ? 1 : 0;
    \u003CModule\u003E._app_exit_callback();
    if ((byte) num == (byte) 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain();
  }

  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(
    [In] LanguageSupport* obj0,
    Exception innerException)
  {
    try
    {
      bool flag = Interlocked.Decrement(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA) == 0;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain();
      if (!flag)
        return;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain();
    }
    catch (Exception ex)
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, ex);
    }
    catch
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, (Exception) null);
    }
  }

  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize(
    [In] LanguageSupport* obj0)
  {
    bool flag = false;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load.\n");
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
      }
      finally
      {
        Interlocked.Increment(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA);
        flag = true;
      }
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize(obj0);
    }
    catch (Exception ex)
    {
      if (flag)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, ex);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), ex);
    }
    catch
    {
      if (flag)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, (Exception) null);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), (Exception) null);
    }
  }

  [DebuggerStepThrough]
  static unsafe \u003CModule\u003E()
  {
    LanguageSupport languageSupport;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D(&languageSupport);
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize(&languageSupport);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((delegate*<void*, void>) __methodptr(\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D), (void*) &languageSupport);
    }
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) &languageSupport);
  }

  internal static unsafe LanguageSupport* \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
    return obj0;
  }

  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D(
    [In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
  }

  [DebuggerStepThrough]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D(
    [In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) null);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  [DebuggerStepThrough]
  internal static unsafe void gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D(
    [In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    ((GCHandle) new IntPtr((void*) *(int*) obj0)).Free();
    *(int*) obj0 = 0;
  }

  [DebuggerStepThrough]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D(
    [In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0,
    string t)
  {
    ((GCHandle) new IntPtr((void*) *(int*) obj0)).Target = (object) t;
    return obj0;
  }

  internal static unsafe string gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040(
    [In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    return (string) ((GCHandle) new IntPtr((void*) *(int*) obj0)).Target;
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EInitialize()
  {
    object obj = new object();
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A = 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002ESet(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A, obj);
  }

  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EGet(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A) != null;
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EEnter()
  {
    Monitor.Enter(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EGet(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A));
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EExit()
  {
    Monitor.Exit(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EGet(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A));
  }

  internal static unsafe void \u003FA0x49040904\u002E\u003F\u003F__E\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A\u0040\u0040YMXXZ()
  {
    // ISSUE: method pointer
    // ISSUE: cast to a function pointer type
    \u003CModule\u003E._atexit_m_appdomain((delegate*<void>) __methodptr(\u003FA0x49040904\u002E\u003F\u003F__F\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A\u0040\u0040YMXXZ));
  }

  internal static unsafe void \u003FA0x49040904\u002E\u003F\u003F__F\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002E\u007Bdtor\u007D(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A);
  }

  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003FA0x49040904\u002E__global_lock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      Monitor.Enter(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EGet(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A));
      flag = true;
    }
    return flag;
  }

  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003FA0x49040904\u002E__global_unlock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      Monitor.Exit(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EGet(&\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0V\u003F\u0024Handle\u0040P\u0024AAVObject\u0040System\u0040\u0040\u00402\u0040A));
      flag = true;
    }
    return flag;
  }

  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0x49040904\u002E__alloc_global_lock()
  {
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EInitialize();
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized();
  }

  internal static unsafe int _atexit_helper(
    delegate*<void> func,
    uint* __pexit_list_size,
    delegate*<void>** __ponexitend,
    delegate*<void>** __ponexitbegin)
  {
    // ISSUE: cast to a function pointer type
    delegate*<void> local1 = (delegate*<void>) 0;
    if (func == null)
      return -1;
    int num1;
    if (\u003CModule\u003E.\u003FA0x49040904\u002E__global_lock())
    {
      try
      {
        if (*__pexit_list_size - 1U < (uint) (*(int*) __ponexitend - *(int*) __ponexitbegin >>> 2))
        {
          try
          {
            uint num2 = *__pexit_list_size * 4U;
            uint num3 = num2 >= 2048U /*0x0800*/ ? 2048U /*0x0800*/ : num2;
            IntPtr cb = new IntPtr((int) num2 + (int) num3);
            IntPtr num4 = Marshal.ReAllocHGlobal(new IntPtr((void*) *(int*) __ponexitbegin), cb);
            delegate*<void>** local2 = __ponexitend;
            IntPtr num5 = *(int*) local2 + ((IntPtr) num4.ToPointer() - *(int*) __ponexitbegin);
            *(int*) local2 = (int) num5;
            *(int*) __ponexitbegin = (int) num4.ToPointer();
            uint num6 = *__pexit_list_size;
            uint num7 = 512U /*0x0200*/ >= num6 ? num6 : 512U /*0x0200*/;
            *__pexit_list_size = num6 + num7;
          }
          catch (OutOfMemoryException ex)
          {
            IntPtr cb = new IntPtr((int) *__pexit_list_size * 4 + 8);
            IntPtr num8 = Marshal.ReAllocHGlobal(new IntPtr((void*) *(int*) __ponexitbegin), cb);
            delegate*<void>** local3 = __ponexitend;
            IntPtr num9 = *(int*) local3 + ((IntPtr) num8.ToPointer() - *(int*) __ponexitbegin);
            *(int*) local3 = (int) num9;
            *(int*) __ponexitbegin = (int) num8.ToPointer();
            uint* numPtr = __pexit_list_size;
            int num10 = (int) *numPtr + 4;
            *numPtr = (uint) num10;
          }
        }
        *(int*) *(int*) __ponexitend = (int) func;
        delegate*<void>** local4 = __ponexitend;
        int num11 = *(int*) local4 + 4;
        *(int*) local4 = num11;
        local1 = func;
      }
      catch (OutOfMemoryException ex)
      {
      }
      finally
      {
        \u003CModule\u003E.\u003FA0x49040904\u002E__global_unlock();
      }
      if (local1 != null)
      {
        num1 = 0;
        goto label_12;
      }
    }
    num1 = -1;
label_12:
    return num1;
  }

  internal static unsafe void _exit_callback()
  {
    if ((IntPtr) \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin == new IntPtr(-1) || (IntPtr) \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin == IntPtr.Zero || (IntPtr) \u003CModule\u003E.\u003FA0x49040904\u002E__onexitend == IntPtr.Zero)
      return;
    \u003CModule\u003E.\u003FA0x49040904\u002E__onexitend -= 4;
    if (\u003CModule\u003E.\u003FA0x49040904\u002E__onexitend >= \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin)
    {
      do
      {
        if (*(int*) \u003CModule\u003E.\u003FA0x49040904\u002E__onexitend != 0)
        {
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((delegate*<void>) *(int*) \u003CModule\u003E.\u003FA0x49040904\u002E__onexitend)();
        }
        \u003CModule\u003E.\u003FA0x49040904\u002E__onexitend -= 4;
      }
      while (\u003CModule\u003E.\u003FA0x49040904\u002E__onexitend >= \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin);
    }
    Marshal.FreeHGlobal(new IntPtr((void*) \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin));
  }

  [DebuggerStepThrough]
  internal static unsafe int _initatexit_m()
  {
    if (!\u003CModule\u003E.\u003FA0x49040904\u002E__alloc_global_lock())
      return 0;
    \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin = (delegate*<void>*) Marshal.AllocHGlobal(128 /*0x80*/).ToPointer();
    \u003CModule\u003E.\u003FA0x49040904\u002E__onexitend = \u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin;
    \u003CModule\u003E.\u003FA0x49040904\u002E__exit_list_size = 32U /*0x20*/;
    return 1;
  }

  internal static unsafe delegate*<int> _onexit_m(delegate*<int> _Function)
  {
    // ISSUE: cast to a function pointer type
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_m((delegate*<void>) _Function) != -1 ? _Function : (delegate*<int>) 0;
  }

  internal static unsafe int _atexit_m(delegate*<void> func)
  {
    return \u003CModule\u003E._atexit_helper(func, &\u003CModule\u003E.\u003FA0x49040904\u002E__exit_list_size, &\u003CModule\u003E.\u003FA0x49040904\u002E__onexitend, &\u003CModule\u003E.\u003FA0x49040904\u002E__onexitbegin);
  }

  [DebuggerStepThrough]
  internal static unsafe int _initatexit_app_domain()
  {
    if (\u003CModule\u003E.\u003FA0x49040904\u002E__alloc_global_lock())
    {
      \u003CModule\u003E.__onexitbegin_app_domain = (delegate*<void>*) Marshal.AllocHGlobal(128 /*0x80*/).ToPointer();
      \u003CModule\u003E.__onexitend_app_domain = \u003CModule\u003E.__onexitbegin_app_domain;
      \u003CModule\u003E.__exit_list_size_app_domain = 32U /*0x20*/;
    }
    return 1;
  }

  internal static unsafe void _app_exit_callback()
  {
    if ((IntPtr) \u003CModule\u003E.__onexitbegin_app_domain == new IntPtr(-1) || (IntPtr) \u003CModule\u003E.__onexitbegin_app_domain == IntPtr.Zero)
      return;
    if ((IntPtr) \u003CModule\u003E.__onexitend_app_domain == IntPtr.Zero)
      return;
    try
    {
      while (true)
      {
        do
        {
          \u003CModule\u003E.__onexitend_app_domain -= 4;
          if (\u003CModule\u003E.__onexitend_app_domain < \u003CModule\u003E.__onexitbegin_app_domain)
            goto label_8;
        }
        while (*(int*) \u003CModule\u003E.__onexitend_app_domain == 0);
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((delegate*<void>) *(int*) \u003CModule\u003E.__onexitend_app_domain)();
      }
label_8:;
    }
    finally
    {
      Marshal.FreeHGlobal(new IntPtr((void*) \u003CModule\u003E.__onexitbegin_app_domain));
    }
  }

  internal static unsafe delegate*<int> _onexit_m_appdomain(delegate*<int> _Function)
  {
    // ISSUE: cast to a function pointer type
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_m_appdomain((delegate*<void>) _Function) != -1 ? _Function : (delegate*<int>) 0;
  }

  [DebuggerStepThrough]
  internal static unsafe int _atexit_m_appdomain(delegate*<void> func)
  {
    return \u003CModule\u003E._atexit_helper(func, &\u003CModule\u003E.__exit_list_size_app_domain, &\u003CModule\u003E.__onexitend_app_domain, &\u003CModule\u003E.__onexitbegin_app_domain);
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EConstruct(
    [In] Handle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E* obj0,
    object value)
  {
    *(int*) obj0 = 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002ESet(obj0, value);
  }

  [DebuggerStepThrough]
  internal static unsafe object \u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002EGet(
    [In] Handle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E* obj0)
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002E_handle(obj0);
    return valueType != null ? ((GCHandle) valueType).Target : (object) null;
  }

  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002E\u007Bdtor\u007D(
    [In] Handle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E* obj0)
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002E_handle(obj0);
    if (valueType == null)
      return;
    ((GCHandle) valueType).Free();
    *(int*) obj0 = 0;
  }

  [DebuggerStepThrough]
  internal static unsafe ValueType \u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002E_handle(
    [In] Handle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E* obj0)
  {
    uint num = (uint) *(int*) obj0;
    return num != 0U ? (ValueType) GCHandle.FromIntPtr(new IntPtr((void*) num)) : (ValueType) null;
  }

  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002ESet(
    [In] Handle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E* obj0,
    object value)
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EHandle\u003CSystem\u003A\u003AObject\u0020\u005E\u003E\u002E_handle(obj0);
    if (valueType == null)
    {
      IntPtr intPtr = GCHandle.ToIntPtr(GCHandle.Alloc(value));
      *(int*) obj0 = (int) intPtr.ToPointer();
    }
    else
      ((GCHandle) valueType).Target = value;
  }

  [DebuggerStepThrough]
  internal static unsafe int _initterm_e(
    delegate* unmanaged[Cdecl]<int>* pfbegin,
    delegate* unmanaged[Cdecl]<int>* pfend)
  {
    int num1 = 0;
    if (pfbegin < pfend)
    {
      while (num1 == 0)
      {
        uint num2 = (uint) *(int*) pfbegin;
        if (num2 != 0U)
        {
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          num1 = __calli((delegate* unmanaged[Cdecl]<int>) (int) num2)();
        }
        pfbegin += 4;
        if (pfbegin >= pfend)
          break;
      }
    }
    return num1;
  }

  [DebuggerStepThrough]
  internal static unsafe void _initterm(
    delegate* unmanaged[Cdecl]<void>* pfbegin,
    delegate* unmanaged[Cdecl]<void>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint num = (uint) *(int*) pfbegin;
      if (num != 0U)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((delegate* unmanaged[Cdecl]<void>) (int) num)();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [DebuggerStepThrough]
  internal static ModuleHandle \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle()
  {
    return typeof (ThisModule).Module.ModuleHandle;
  }

  [DebuggerStepThrough]
  internal static unsafe void _initterm_m(delegate*<void*>* pfbegin, delegate*<void*>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint methodToken = (uint) *(int*) pfbegin;
      if (methodToken != 0U)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E((delegate*<void*>) (int) methodToken))();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [DebuggerStepThrough]
  internal static unsafe delegate*<void*> \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E(
    delegate*<void*> methodToken)
  {
    // ISSUE: cast to a function pointer type
    return (delegate*<void*>) (IntPtr) \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle().ResolveMethodHandle((int) methodToken).GetFunctionPointer().ToPointer();
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void ___CxxCallUnwindDtor(delegate*<void*, void> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void ___CxxCallUnwindDelDtor(delegate*<void*, void> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void ___CxxCallUnwindVecDtor(
    delegate*<void*, uint, int, delegate*<void*, void>, void> pVecDtor,
    void* ptr,
    uint size,
    int count,
    delegate*<void*, void> pDtor)
  {
    try
    {
      void* voidPtr = ptr;
      int num1 = (int) size;
      int num2 = count;
      delegate*<void*, void> local = pDtor;
      // ISSUE: function pointer call
      __calli(pVecDtor)(voidPtr, (uint) num1, num2, local);
    }
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002EDragEnter(
    [In] DropHelper* obj0,
    IDataObject* pDataObj,
    uint grfKeyState,
    _POINTL pt,
    uint* pdwEffect)
  {
    ((ICustomDropTargetHandler) ((GCHandle) new IntPtr((void*) *(int*) ((IntPtr) obj0 + 8))).Target).OnDragEnter(pDataObj, grfKeyState, pt, pdwEffect);
    return 0;
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002EDragOver(
    [In] DropHelper* obj0,
    uint grfKeyState,
    _POINTL pt,
    uint* pdwEffect)
  {
    ((ICustomDropTargetHandler) ((GCHandle) new IntPtr((void*) *(int*) ((IntPtr) obj0 + 8))).Target).OnDragOver(grfKeyState, pt, pdwEffect);
    return 0;
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002EDrop(
    [In] DropHelper* obj0,
    IDataObject* pDataObj,
    uint grfKeyState,
    _POINTL pt,
    uint* pdwEffect)
  {
    ((ICustomDropTargetHandler) ((GCHandle) new IntPtr((void*) *(int*) ((IntPtr) obj0 + 8))).Target).OnDrop(pDataObj, grfKeyState, pt, pdwEffect);
    return 0;
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002EDragLeave(
    [In] DropHelper* obj0)
  {
    ((ICustomDropTargetHandler) ((GCHandle) new IntPtr((void*) *(int*) ((IntPtr) obj0 + 8))).Target).OnDragLeave();
    return 0;
  }

  internal static unsafe ICustomDropTargetHandler gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E\u002E\u002D\u003E(
    [In] gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* obj0)
  {
    return (ICustomDropTargetHandler) ((GCHandle) new IntPtr((void*) *(int*) obj0)).Target;
  }

  internal static unsafe int IsEqualGUID(_GUID* rguid1, _GUID* rguid2)
  {
    uint num1 = 16 /*0x10*/;
    _GUID* guidPtr = rguid2;
    sbyte num2 = *(sbyte*) rguid1;
    sbyte num3 = *(sbyte*) rguid2;
    int num4;
    if ((int) num2 >= (int) num3)
    {
      int num5 = (int) ((IntPtr) rguid1 - (IntPtr) rguid2);
      while ((int) num2 <= (int) num3)
      {
        if (num1 != 1U)
        {
          --num1;
          ++guidPtr;
          num2 = *(sbyte*) (num5 + (IntPtr) guidPtr);
          num3 = *(sbyte*) guidPtr;
          if ((int) num2 < (int) num3)
            break;
        }
        else
        {
          num4 = 1;
          goto label_7;
        }
      }
    }
    num4 = 0;
label_7:
    return num4;
  }

  internal static unsafe int \u003D\u003D(_GUID* guidOne, _GUID* guidOther)
  {
    return \u003CModule\u003E.IsEqualGUID(guidOne, guidOther);
  }

  internal static unsafe int MessageBox(HWND__* hWnd, char* lpText, char* lpCaption, uint uType)
  {
    return \u003CModule\u003E.MessageBoxW(hWnd, lpText, lpCaption, uType);
  }

  internal static unsafe int StringCbCopyW(char* pszDest, uint cbDest, char* pszSrc)
  {
    uint cchDest = cbDest >> 1;
    return cchDest > (uint) int.MaxValue ? -2147024809 : \u003CModule\u003E.StringCopyWorkerW(pszDest, cchDest, pszSrc);
  }

  internal static unsafe int StringCopyWorkerW(char* pszDest, uint cchDest, char* pszSrc)
  {
    int num1 = 0;
    if (cchDest == 0U)
    {
      num1 = -2147024809;
    }
    else
    {
      do
      {
        ushort num2 = (ushort) *pszSrc;
        if (num2 != (ushort) 0)
        {
          *pszDest = (char) num2;
          ++pszDest;
          ++pszSrc;
          --cchDest;
        }
        else
          goto label_4;
      }
      while (cchDest != 0U);
      goto label_5;
label_4:
      if (cchDest != 0U)
        goto label_6;
label_5:
      --pszDest;
      num1 = -2147024774;
label_6:
      *pszDest = char.MinValue;
    }
    return num1;
  }

  internal static unsafe object MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetData(
    string format,
    int index,
    IDataObject* pDataObject,
    uint tymed,
    uint aspect)
  {
    DataFormats.Format format1 = DataFormats.GetFormat(format);
    tagFORMATETC tagFormatetc;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ref tagFormatetc = (short) format1.Id;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 12) = index;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 16 /*0x10*/) = (int) tymed;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc + 8) = (int) aspect;
    switch (format)
    {
      case "Outlook.Attachment":
      case "Outlook.Attachments":
        return (object) \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookAttachmentsFromData(pDataObject);
      case "Outlook.Message.AttachmentCount":
      case "Outlook.Messages.AttachmentCount":
        return (object) \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookMessageAttachmentCountFromData(pDataObject);
      case "Outlook.Message":
      case "Outlook.Messages":
        return (object) \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookMessagesFromData(pDataObject, false);
      case "Outlook.Message.ExcludeAttachments":
      case "Outlook.Messages.ExcludeAttachments":
        return (object) \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookMessagesFromData(pDataObject, true);
      default:
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &tagFormatetc + 16 /*0x10*/) == 1)
        {
          IDataObject* idataObjectPtr = pDataObject;
          ref tagFORMATETC local1 = ref tagFormatetc;
          tagSTGMEDIUM tagStgmedium;
          ref tagSTGMEDIUM local2 = ref tagStgmedium;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObject + 12))((IntPtr) idataObjectPtr, (tagFORMATETC*) ref local1, (tagSTGMEDIUM*) ref local2) >= 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            object dataFromHglobal = \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetDataFromHGlobal(format, (void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
            \u003CModule\u003E.ReleaseStgMedium(&tagStgmedium);
            return dataFromHglobal;
          }
        }
        return (object) null;
    }
  }

  internal static unsafe object MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetData(
    string format,
    IDataObject* pDataObject)
  {
    return \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetData(format, -1, pDataObject, 1U, 1U);
  }

  internal static unsafe object MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetDataFromHGlobal(
    string format,
    void* hGlobal)
  {
    if (format == DataFormats.Text || format == DataFormats.Rtf || format == DataFormats.Html || format == DataFormats.UnicodeText || format == "System.String" || format == DataFormats.OemText)
      return (object) \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EStringFromHGlobal(hGlobal);
    return format == DataFormats.FileDrop ? (object) \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EFileListFromHGlobal(hGlobal) : \u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EObjectFromHGlobal(hGlobal);
  }

  internal static unsafe int[] MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookMessageAttachmentCountFromData(
    IDataObject* pDataObject)
  {
    List<int> intList = new List<int>();
    if (\u003CModule\u003E.MAPIInitialize((void*) 0) >= 0)
    {
      IMessage* imessagePtr1 = (IMessage*) 0;
      uint num1 = 0;
      uint num2 = \u003CModule\u003E.RegisterClipboardFormatW((char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1CI\u0040CEGIFMP\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAG\u003F\u0024AAr\u003F\u0024AAo\u003F\u0024AAu\u003F\u0024AAp\u003F\u0024AAD\u003F\u0024AAe\u003F\u0024AAs\u003F\u0024AAc\u003F\u0024AAr\u003F\u0024AAi\u003F\u0024AAp\u003F\u0024AAt\u003F\u0024AAo\u003F\u0024AAr\u003F\u0024AA\u003F\u0024AA\u0040);
      \u003CModule\u003E.IsClipboardFormatAvailable(num2);
      tagFORMATETC tagFormatetc1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(short&) ref tagFormatetc1 = (short) (ushort) num2;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 4) = 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 8) = 1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 12) = -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 16 /*0x10*/) = -1;
      tagSTGMEDIUM tagStgmedium;
      if (num2 != 0U)
      {
        IDataObject* idataObjectPtr1 = pDataObject;
        ref tagFORMATETC local1 = ref tagFormatetc1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObject + 20))((IntPtr) idataObjectPtr1, (tagFORMATETC*) ref local1) >= 0)
        {
          IDataObject* idataObjectPtr2 = pDataObject;
          ref tagFORMATETC local2 = ref tagFormatetc1;
          ref tagSTGMEDIUM local3 = ref tagStgmedium;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObject + 12))((IntPtr) idataObjectPtr2, (tagFORMATETC*) ref local2, (tagSTGMEDIUM*) ref local3) >= 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            num1 = (uint) *(int*) \u003CModule\u003E.GlobalLock((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            \u003CModule\u003E.GlobalUnlock((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
          }
        }
      }
      uint num3 = \u003CModule\u003E.RegisterClipboardFormatW((char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1BK\u0040BPLEJIIK\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAC\u003F\u0024AAo\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAe\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAs\u003F\u0024AA\u003F\u0024AA\u0040);
      uint num4 = 0;
      if (0U < num1)
      {
        int bufferJ14YgkpaxZ = (int) \u003CModule\u003E.__unep\u0040\u003FMAPIFreeBuffer\u0040\u0040\u0024\u0024J14YGKPAX\u0040Z;
        int j212YgjkpaxpapaxZ = (int) \u003CModule\u003E.__unep\u0040\u003FMAPIAllocateMore\u0040\u0040\u0024\u0024J212YGJKPAXPAPAX\u0040Z;
        int bufferJ18YgjkpapaxZ = (int) \u003CModule\u003E.__unep\u0040\u003FMAPIAllocateBuffer\u0040\u0040\u0024\u0024J18YGJKPAPAX\u0040Z;
        do
        {
          if (num3 != 0U)
          {
            tagFORMATETC tagFormatetc2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(short&) ref tagFormatetc2 = (short) (ushort) num3;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 4) = 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 8) = 1;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 12) = (int) num4;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 16 /*0x10*/) = 12;
            IDataObject* idataObjectPtr3 = pDataObject;
            ref tagFORMATETC local4 = ref tagFormatetc2;
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObject + 20))((IntPtr) idataObjectPtr3, (tagFORMATETC*) ref local4) >= 0)
            {
              IDataObject* idataObjectPtr4 = pDataObject;
              ref tagFORMATETC local5 = ref tagFormatetc2;
              ref tagSTGMEDIUM local6 = ref tagStgmedium;
              // ISSUE: cast to a function pointer type
              // ISSUE: function pointer call
              int num5 = __calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObject + 12))((IntPtr) idataObjectPtr4, (tagFORMATETC*) ref local5, (tagSTGMEDIUM*) ref local6);
            }
          }
          // ISSUE: cast to a function pointer type
          // ISSUE: cast to a function pointer type
          // ISSUE: cast to a function pointer type
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a function pointer type
          if (\u003CModule\u003E.OpenIMsgOnIStg((_MSGSESS*) 0, (delegate* unmanaged[Stdcall]<uint, void**, int>) bufferJ18YgjkpapaxZ, (delegate* unmanaged[Stdcall]<uint, void*, void**, int>) j212YgjkpaxpapaxZ, (delegate* unmanaged[Stdcall]<void*, uint>) bufferJ14YgkpaxZ, \u003CModule\u003E.MAPIGetDefaultMalloc(), (void*) 0, (IStorage*) ^(int&) ((IntPtr) &tagStgmedium + 4), (delegate* unmanaged[Stdcall]<uint, IMessage*, void>) 0, 0U, 0U, &imessagePtr1) >= 0)
          {
            uint num6 = 0;
            _SPropValue* spropValuePtr1 = (_SPropValue*) 0;
            MGASystems.IMS.ExtendedControls.\u003FOutlookMessageAttachmentCountFromData\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FSMP\u002401AJPAUIDataObject\u0040\u0040\u0040Z.__l21._SPropTagArray_body spropTagArrayBody;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ref spropTagArrayBody = 2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &spropTagArrayBody + 4) = 3604511;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &spropTagArrayBody + 8) = 268435487 /*0x1000001F*/;
            IMessage* imessagePtr2 = imessagePtr1;
            ref MGASystems.IMS.ExtendedControls.\u003FOutlookMessageAttachmentCountFromData\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FSMP\u002401AJPAUIDataObject\u0040\u0040\u0040Z.__l21._SPropTagArray_body local7 = ref spropTagArrayBody;
            ref uint local8 = ref num6;
            ref _SPropValue* local9 = ref spropValuePtr1;
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            if (__calli((delegate* unmanaged[Stdcall]<IntPtr, _SPropTagArray*, uint, uint*, _SPropValue**, int>) *(int*) (*(int*) imessagePtr1 + 20))((IntPtr) imessagePtr2, (_SPropTagArray*) ref local7, 0U, (uint*) ref local8, (_SPropValue**) ref local9) >= 0)
            {
              _SPropValue* spropValuePtr2 = (_SPropValue*) 0;
              int num7 = \u003CModule\u003E.HrGetOneProp((IMAPIProp*) imessagePtr1, 236650507U, &spropValuePtr2) < 0 ? 0 : (int) *(ushort*) ((IntPtr) spropValuePtr2 + 8);
              intList.Add(num7);
            }
            int num8 = (int) \u003CModule\u003E.MAPIFreeBuffer((void*) spropValuePtr1);
            \u003CModule\u003E.ReleaseStgMedium(&tagStgmedium);
          }
          ++num4;
        }
        while (num4 < num1);
      }
      \u003CModule\u003E.MAPIUninitialize();
    }
    return intList.ToArray();
  }

  internal static unsafe FileInfo[] MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookMessagesFromData(
    IDataObject* pDataObject,
    [MarshalAs(UnmanagedType.U1)] bool excludeAttachments)
  {
    string fileName = (string) null;
    List<FileInfo> fileInfoList = new List<FileInfo>();
    if (\u003CModule\u003E.MAPIInitialize((void*) 0) >= 0)
    {
      IMessage* pMessage = (IMessage*) 0;
      uint num1 = 0;
      uint num2 = \u003CModule\u003E.RegisterClipboardFormatW((char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1CI\u0040CEGIFMP\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAG\u003F\u0024AAr\u003F\u0024AAo\u003F\u0024AAu\u003F\u0024AAp\u003F\u0024AAD\u003F\u0024AAe\u003F\u0024AAs\u003F\u0024AAc\u003F\u0024AAr\u003F\u0024AAi\u003F\u0024AAp\u003F\u0024AAt\u003F\u0024AAo\u003F\u0024AAr\u003F\u0024AA\u003F\u0024AA\u0040);
      \u003CModule\u003E.IsClipboardFormatAvailable(num2);
      tagFORMATETC tagFormatetc1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(short&) ref tagFormatetc1 = (short) (ushort) num2;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 4) = 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 8) = 1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 12) = -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &tagFormatetc1 + 16 /*0x10*/) = -1;
      tagSTGMEDIUM tagStgmedium;
      if (num2 != 0U)
      {
        IDataObject* idataObjectPtr1 = pDataObject;
        ref tagFORMATETC local1 = ref tagFormatetc1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObject + 20))((IntPtr) idataObjectPtr1, (tagFORMATETC*) ref local1) >= 0)
        {
          IDataObject* idataObjectPtr2 = pDataObject;
          ref tagFORMATETC local2 = ref tagFormatetc1;
          ref tagSTGMEDIUM local3 = ref tagStgmedium;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObject + 12))((IntPtr) idataObjectPtr2, (tagFORMATETC*) ref local2, (tagSTGMEDIUM*) ref local3) >= 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            num1 = (uint) *(int*) \u003CModule\u003E.GlobalLock((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            \u003CModule\u003E.GlobalUnlock((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
          }
        }
      }
      uint num3 = \u003CModule\u003E.RegisterClipboardFormatW((char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1BK\u0040BPLEJIIK\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAC\u003F\u0024AAo\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAe\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAs\u003F\u0024AA\u003F\u0024AA\u0040);
      uint num4 = 0;
      if (0U < num1)
      {
        int bufferJ14YgkpaxZ = (int) \u003CModule\u003E.__unep\u0040\u003FMAPIFreeBuffer\u0040\u0040\u0024\u0024J14YGKPAX\u0040Z;
        int j212YgjkpaxpapaxZ = (int) \u003CModule\u003E.__unep\u0040\u003FMAPIAllocateMore\u0040\u0040\u0024\u0024J212YGJKPAXPAPAX\u0040Z;
        int bufferJ18YgjkpapaxZ = (int) \u003CModule\u003E.__unep\u0040\u003FMAPIAllocateBuffer\u0040\u0040\u0024\u0024J18YGJKPAPAX\u0040Z;
        do
        {
          if (num3 != 0U)
          {
            tagFORMATETC tagFormatetc2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(short&) ref tagFormatetc2 = (short) (ushort) num3;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 4) = 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 8) = 1;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 12) = (int) num4;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 16 /*0x10*/) = 12;
            IDataObject* idataObjectPtr3 = pDataObject;
            ref tagFORMATETC local4 = ref tagFormatetc2;
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObject + 20))((IntPtr) idataObjectPtr3, (tagFORMATETC*) ref local4) >= 0)
            {
              IDataObject* idataObjectPtr4 = pDataObject;
              ref tagFORMATETC local5 = ref tagFormatetc2;
              ref tagSTGMEDIUM local6 = ref tagStgmedium;
              // ISSUE: cast to a function pointer type
              // ISSUE: function pointer call
              int num5 = __calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObject + 12))((IntPtr) idataObjectPtr4, (tagFORMATETC*) ref local5, (tagSTGMEDIUM*) ref local6);
            }
          }
          // ISSUE: cast to a function pointer type
          // ISSUE: cast to a function pointer type
          // ISSUE: cast to a function pointer type
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a function pointer type
          if (\u003CModule\u003E.OpenIMsgOnIStg((_MSGSESS*) 0, (delegate* unmanaged[Stdcall]<uint, void**, int>) bufferJ18YgjkpapaxZ, (delegate* unmanaged[Stdcall]<uint, void*, void**, int>) j212YgjkpaxpapaxZ, (delegate* unmanaged[Stdcall]<void*, uint>) bufferJ14YgkpaxZ, \u003CModule\u003E.MAPIGetDefaultMalloc(), (void*) 0, (IStorage*) ^(int&) ((IntPtr) &tagStgmedium + 4), (delegate* unmanaged[Stdcall]<uint, IMessage*, void>) 0, 0U, 0U, &pMessage) >= 0)
          {
            uint num6 = 0;
            _SPropValue* spropValuePtr = (_SPropValue*) 0;
            MGASystems.IMS.ExtendedControls.\u003FOutlookMessagesFromData\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FSMP\u002401AP\u0024AAVFileInfo\u0040IO\u0040System\u0040\u0040PAUIDataObject\u0040\u0040_N\u0040Z.__l21._SPropTagArray_body spropTagArrayBody;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ref spropTagArrayBody = 2;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &spropTagArrayBody + 4) = 3604511;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &spropTagArrayBody + 8) = 268435487 /*0x1000001F*/;
            IMessage* imessagePtr = pMessage;
            ref MGASystems.IMS.ExtendedControls.\u003FOutlookMessagesFromData\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FSMP\u002401AP\u0024AAVFileInfo\u0040IO\u0040System\u0040\u0040PAUIDataObject\u0040\u0040_N\u0040Z.__l21._SPropTagArray_body local7 = ref spropTagArrayBody;
            ref uint local8 = ref num6;
            ref _SPropValue* local9 = ref spropValuePtr;
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            if (__calli((delegate* unmanaged[Stdcall]<IntPtr, _SPropTagArray*, uint, uint*, _SPropValue**, int>) *(int*) (*(int*) pMessage + 20))((IntPtr) imessagePtr, (_SPropTagArray*) ref local7, 0U, (uint*) ref local8, (_SPropValue**) ref local9) >= 0)
            {
              if (\u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002ESaveToMSG(pMessage, ref fileName, excludeAttachments) >= 0)
                fileInfoList.Add(new FileInfo(fileName));
              else
                fileName = "Error";
            }
            else
              \u003CModule\u003E.MessageBoxW((HWND__*) 0, (char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1EA\u0040FPHBKJHF\u0040\u003F\u0024AAU\u003F\u0024AAn\u003F\u0024AAa\u003F\u0024AAb\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AA\u003F5\u003F\u0024AAt\u003F\u0024AAo\u003F\u0024AA\u003F5\u003F\u0024AAr\u003F\u0024AAe\u003F\u0024AAt\u003F\u0024AAr\u003F\u0024AAi\u003F\u0024AAe\u003F\u0024AAv\u003F\u0024AAe\u003F\u0024AA\u003F5\u003F\u0024AAm\u003F\u0024AAe\u003F\u0024AAs\u003F\u0024AAs\u003F\u0024AAa\u003F\u0024AAg\u003F\u0024AAe\u003F\u0024AA\u003F5\u003F\u0024AAb\u003F\u0024AAo\u003F\u0024AAd\u003F\u0024AAy\u003F\u0024AA\u003F\u0024AA\u0040, (char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1BG\u0040BCOIGAE\u0040\u003F\u0024AAM\u003F\u0024AAA\u003F\u0024AAP\u003F\u0024AAI\u003F\u0024AA\u003F5\u003F\u0024AAe\u003F\u0024AAr\u003F\u0024AAr\u003F\u0024AAo\u003F\u0024AAr\u003F\u0024AA\u003F\u0024AA\u0040, 16U /*0x10*/);
            int num7 = (int) \u003CModule\u003E.MAPIFreeBuffer((void*) spropValuePtr);
            \u003CModule\u003E.ReleaseStgMedium(&tagStgmedium);
          }
          ++num4;
        }
        while (num4 < num1);
      }
      \u003CModule\u003E.MAPIUninitialize();
    }
    return fileInfoList.ToArray();
  }

  internal static unsafe FileInfo[] MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EOutlookAttachmentsFromData(
    IDataObject* pDataObj)
  {
    List<FileInfo> fileInfoList = new List<FileInfo>();
    ushort num1 = (ushort) \u003CModule\u003E.RegisterClipboardFormatW((char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1CI\u0040CEGIFMP\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAG\u003F\u0024AAr\u003F\u0024AAo\u003F\u0024AAu\u003F\u0024AAp\u003F\u0024AAD\u003F\u0024AAe\u003F\u0024AAs\u003F\u0024AAc\u003F\u0024AAr\u003F\u0024AAi\u003F\u0024AAp\u003F\u0024AAt\u003F\u0024AAo\u003F\u0024AAr\u003F\u0024AA\u003F\u0024AA\u0040);
    ushort num2 = (ushort) \u003CModule\u003E.RegisterClipboardFormatW((char*) &\u003CModule\u003E.\u003F\u003F_C\u0040_1BK\u0040BPLEJIIK\u0040\u003F\u0024AAF\u003F\u0024AAi\u003F\u0024AAl\u003F\u0024AAe\u003F\u0024AAC\u003F\u0024AAo\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAe\u003F\u0024AAn\u003F\u0024AAt\u003F\u0024AAs\u003F\u0024AA\u003F\u0024AA\u0040);
    tagFORMATETC tagFormatetc1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ref tagFormatetc1 = (short) num1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 8) = 1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 12) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc1 + 16 /*0x10*/) = 1;
    tagFORMATETC tagFormatetc2;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ref tagFormatetc2 = (short) num2;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc2 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc2 + 8) = 1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc2 + 12) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &tagFormatetc2 + 16 /*0x10*/) = 4;
    IDataObject* idataObjectPtr1 = pDataObj;
    ref tagFORMATETC local1 = ref tagFormatetc1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObj + 20))((IntPtr) idataObjectPtr1, (tagFORMATETC*) ref local1) == 0)
    {
      IDataObject* idataObjectPtr2 = pDataObj;
      ref tagFORMATETC local2 = ref tagFormatetc2;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, int>) *(int*) (*(int*) pDataObj + 20))((IntPtr) idataObjectPtr2, (tagFORMATETC*) ref local2) == 0)
      {
        tagSTGMEDIUM tagStgmedium;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref tagStgmedium = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &tagStgmedium + 4) = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &tagStgmedium + 8) = 0;
        IDataObject* idataObjectPtr3 = pDataObj;
        ref tagFORMATETC local3 = ref tagFormatetc1;
        ref tagSTGMEDIUM local4 = ref tagStgmedium;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        int num3 = __calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObj + 12))((IntPtr) idataObjectPtr3, (tagFORMATETC*) ref local3, (tagSTGMEDIUM*) ref local4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        _FILEGROUPDESCRIPTORA* filegroupdescriptoraPtr1 = (_FILEGROUPDESCRIPTORA*) \u003CModule\u003E.GlobalLock((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
        uint num4 = 0;
        if (0U < (uint) *(int*) filegroupdescriptoraPtr1)
        {
          _FILEGROUPDESCRIPTORA* filegroupdescriptoraPtr2 = (_FILEGROUPDESCRIPTORA*) ((IntPtr) filegroupdescriptoraPtr1 + 4);
          do
          {
            _FILEDESCRIPTORA filedescriptora;
            // ISSUE: cpblk instruction
            __memcpy(ref filedescriptora, (IntPtr) filegroupdescriptoraPtr2, 332);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            ^(int&) ((IntPtr) &tagFormatetc2 + 12) = (int) num4;
            IDataObject* idataObjectPtr4 = pDataObj;
            ref tagFORMATETC local5 = ref tagFormatetc2;
            ref tagSTGMEDIUM local6 = ref tagStgmedium;
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            if (__calli((delegate* unmanaged[Stdcall]<IntPtr, tagFORMATETC*, tagSTGMEDIUM*, int>) *(int*) (*(int*) pDataObj + 12))((IntPtr) idataObjectPtr4, (tagFORMATETC*) ref local5, (tagSTGMEDIUM*) ref local6) == 0)
            {
              StringBuilder stringBuilder1 = new StringBuilder();
              StringBuilder stringBuilder2 = new StringBuilder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
              stringBuilder2.Append("\\");
              stringBuilder1.Append(stringBuilder2.ToString());
              stringBuilder1.Append(new string((sbyte*) ((IntPtr) &filedescriptora + 72)));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              fileInfoList.Add(\u003CModule\u003E.MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EStreamToFile((IStream*) ^(int&) ((IntPtr) &tagStgmedium + 4), stringBuilder1.ToString()));
            }
            ++num4;
            filegroupdescriptoraPtr2 += 332;
          }
          while (num4 < (uint) *(int*) filegroupdescriptoraPtr1);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.GlobalUnlock((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.GlobalFree((void*) ^(int&) ((IntPtr) &tagStgmedium + 4));
      }
    }
    return fileInfoList.ToArray();
  }

  internal static unsafe FileInfo MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EStreamToFile(
    IStream* stream,
    string file_name)
  {
    FileStream fileStream1 = new FileStream(file_name, FileMode.Create);
    FileStream fileStream2;
    FileInfo file;
    // ISSUE: fault handler
    try
    {
      fileStream2 = fileStream1;
      uint num1 = 0;
      int num2;
      do
      {
        IStream* istreamPtr = stream;
        \u0024ArrayType\u0024\u0024\u0024BY0EAA\u0040E arrayTypeBy0EaaE;
        ref \u0024ArrayType\u0024\u0024\u0024BY0EAA\u0040E local1 = ref arrayTypeBy0EaaE;
        ref uint local2 = ref num1;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        num2 = __calli((delegate* unmanaged[Stdcall]<IntPtr, void*, uint, uint*, int>) *(int*) (*(int*) stream + 12))((IntPtr) istreamPtr, (void*) ref local1, 1024U /*0x0400*/, (uint*) ref local2);
        if (num1 != 0U)
        {
          uint num3 = 0;
          if (0U < num1)
          {
            do
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              byte num4 = ^(byte&) ((int) num3 + (IntPtr) &arrayTypeBy0EaaE);
              fileStream2.WriteByte(num4);
              ++num3;
            }
            while (num3 < num1);
          }
        }
      }
      while (0 == num2 && num1 == 1024U /*0x0400*/);
      fileStream2.Close();
      file = new FileInfo(file_name);
    }
    __fault
    {
      fileStream2.Dispose();
    }
    fileStream2.Dispose();
    return file;
  }

  internal static string MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002Eget_ActiveSaveDirectory()
  {
    StringBuilder stringBuilder = new StringBuilder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
    stringBuilder.Append("\\");
    return stringBuilder.ToString();
  }

  internal static unsafe string MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EStringFromHGlobal(
    void* hGlobal)
  {
    void* voidPtr = \u003CModule\u003E.GlobalLock(hGlobal);
    uint length = \u003CModule\u003E.GlobalSize(hGlobal);
    string str = (string) null;
    if ((IntPtr) voidPtr != IntPtr.Zero)
    {
      try
      {
        byte[] numArray = new byte[(int) length];
        Marshal.Copy(new IntPtr(voidPtr), numArray, 0, (int) length);
        str = new ASCIIEncoding().GetString(numArray);
      }
      finally
      {
        \u003CModule\u003E.GlobalUnlock(voidPtr);
      }
    }
    return str;
  }

  internal static unsafe string[] MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EFileListFromHGlobal(
    void* hGlobal)
  {
    List<string> stringList = new List<string>();
    void* voidPtr = \u003CModule\u003E.GlobalLock(hGlobal);
    int num1 = (int) \u003CModule\u003E.GlobalSize(hGlobal);
    if ((IntPtr) voidPtr != IntPtr.Zero)
    {
      try
      {
        uint num2 = \u003CModule\u003E.DragQueryFileW((HDROP__*) voidPtr, uint.MaxValue, (char*) 0, 0U);
        for (uint index = 0; index < num2; ++index)
        {
          \u0024ArrayType\u0024\u0024\u0024BY0BAF\u0040_W arrayTypeBy0BafW;
          // ISSUE: initblk instruction
          __memset(ref arrayTypeBy0BafW, 0, 261);
          int num3 = (int) \u003CModule\u003E.DragQueryFileW((HDROP__*) voidPtr, index, (char*) &arrayTypeBy0BafW, 261U);
          stringList.Add(new string((char*) &arrayTypeBy0BafW));
        }
      }
      finally
      {
        \u003CModule\u003E.GlobalUnlock(voidPtr);
      }
    }
    return stringList.ToArray();
  }

  internal static unsafe object MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EObjectFromHGlobal(
    void* hGlobal)
  {
    void* voidPtr = \u003CModule\u003E.GlobalLock(hGlobal);
    uint length = \u003CModule\u003E.GlobalSize(hGlobal);
    object obj = (object) null;
    if ((IntPtr) voidPtr != IntPtr.Zero)
    {
      try
      {
        byte[] numArray = new byte[(int) length];
        Marshal.Copy(new IntPtr(voidPtr), numArray, 0, (int) length);
        MemoryStream serializationStream = new MemoryStream(numArray, 16 /*0x10*/, (int) length - 16 /*0x10*/);
        obj = new BinaryFormatter()
        {
          AssemblyFormat = FormatterAssemblyStyle.Full
        }.Deserialize((Stream) serializationStream);
        serializationStream.Close();
      }
      finally
      {
        \u003CModule\u003E.GlobalUnlock(voidPtr);
      }
    }
    return obj;
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002EGetAttachmentCount(
    IMessage* pMessage)
  {
    _SPropValue* spropValuePtr = (_SPropValue*) 0;
    return \u003CModule\u003E.HrGetOneProp((IMAPIProp*) pMessage, 236650507U, &spropValuePtr) >= 0 ? (int) *(ushort*) ((IntPtr) spropValuePtr + 8) : 0;
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EOleDataConverter\u002ESaveToMSG(
    IMessage* pMessage,
    ref string fileName,
    [MarshalAs(UnmanagedType.U1)] bool excludeAttachments)
  {
    _SPropValue* spropValuePtr = (_SPropValue*) 0;
    IStorage* istoragePtr1 = (IStorage*) 0;
    _MSGSESS* msgsessPtr = (_MSGSESS*) 0;
    IMessage* imessagePtr1 = (IMessage*) 0;
    \u0024ArrayType\u0024\u0024\u0024BY0BAE\u0040_W arrayTypeBy0BaeW1;
    int tempPathW = (int) \u003CModule\u003E.GetTempPathW(260U, (char*) &arrayTypeBy0BaeW1);
    string str1 = Regex.Replace(Regex.Replace(\u003CModule\u003E.HrGetOneProp((IMAPIProp*) pMessage, 3604511U, &spropValuePtr) < 0 ? (\u003CModule\u003E.HrGetOneProp((IMAPIProp*) pMessage, 3604510U, &spropValuePtr) < 0 ? "Could not determine subject of email." : new string((sbyte*) *(int*) ((IntPtr) spropValuePtr + 8))) : new string((char*) *(int*) ((IntPtr) spropValuePtr + 8)), "[\\\\/:*?\"<>|.]", " "), "\\s+", " ").Trim();
    StringBuilder stringBuilder1 = new StringBuilder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
    stringBuilder1.Append("\\");
    string str2 = stringBuilder1.ToString();
    StringBuilder stringBuilder2 = new StringBuilder(str2);
    stringBuilder2.Append(str1);
    stringBuilder2.Append(".msg");
    string str3 = stringBuilder2.ToString();
    fileName = str3;
    if (str3.Length >= 260)
    {
      int num = (260 - str2.Length) / 2;
      int length = str2.Length + num;
      string str4 = fileName.Substring(0, length);
      fileName = str4;
      fileName = str4 + ".msg";
    }
    char* hglobalUni = (char*) (void*) Marshal.StringToHGlobalUni(fileName);
    char* chPtr1 = hglobalUni;
    uint maxValue = (uint) int.MaxValue;
    \u0024ArrayType\u0024\u0024\u0024BY0BAE\u0040_W arrayTypeBy0BaeW2;
    char* chPtr2 = (char*) &arrayTypeBy0BaeW2;
    do
    {
      ushort num = (ushort) *chPtr1;
      if (num != (ushort) 0)
      {
        *chPtr2 = (char) num;
        ++chPtr2;
        ++chPtr1;
        --maxValue;
      }
      else
        goto label_5;
    }
    while (maxValue != 0U);
    goto label_6;
label_5:
    if (maxValue != 0U)
      goto label_7;
label_6:
    --chPtr2;
label_7:
    *chPtr2 = char.MinValue;
    Marshal.FreeHGlobal((IntPtr) (void*) hglobalUni);
    IMalloc* defaultMalloc = \u003CModule\u003E.MAPIGetDefaultMalloc();
    \u003CModule\u003E.StgCreateDocfile((char*) &arrayTypeBy0BaeW2, 69634U, 0U, &istoragePtr1);
    \u003CModule\u003E.OpenIMsgSession(defaultMalloc, 0U, &msgsessPtr);
    // ISSUE: cast to a function pointer type
    // ISSUE: cast to a function pointer type
    // ISSUE: cast to a function pointer type
    // ISSUE: cast to a function pointer type
    \u003CModule\u003E.OpenIMsgOnIStg(msgsessPtr, (delegate* unmanaged[Stdcall]<uint, void**, int>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FMAPIAllocateBuffer\u0040\u0040\u0024\u0024J18YGJKPAPAX\u0040Z, (delegate* unmanaged[Stdcall]<uint, void*, void**, int>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FMAPIAllocateMore\u0040\u0040\u0024\u0024J212YGJKPAXPAPAX\u0040Z, (delegate* unmanaged[Stdcall]<void*, uint>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FMAPIFreeBuffer\u0040\u0040\u0024\u0024J14YGKPAX\u0040Z, defaultMalloc, (void*) 0, istoragePtr1, (delegate* unmanaged[Stdcall]<uint, IMessage*, void>) 0, 0U, 0U, &imessagePtr1);
    \u003CModule\u003E.WriteClassStg(istoragePtr1, &\u003CModule\u003E.CLSID_MailMessage);
    if (excludeAttachments)
    {
      MGASystems.IMS.ExtendedControls.\u003FSaveToMSG\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FCMJPAUIMessage\u0040\u0040A\u0024CAP\u0024AAVString\u0040System\u0040\u0040_N\u0040Z.__l17._SPropTagArray_excludeTags arrayExcludeTags;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref arrayExcludeTags = 7;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 4) = 267649027;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 8) = 268894211 /*0x10070003*/;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 12) = 268828675 /*0x10060003*/;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 16 /*0x10*/) = 268959775;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 20) = 269484035 /*0x10100003*/;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 24) = 269549571;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 28) = 236126221;
      IMessage* imessagePtr2 = pMessage;
      ref MGASystems.IMS.ExtendedControls.\u003FSaveToMSG\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FCMJPAUIMessage\u0040\u0040A\u0024CAP\u0024AAVString\u0040System\u0040\u0040_N\u0040Z.__l17._SPropTagArray_excludeTags local1 = ref arrayExcludeTags;
      ref _GUID local2 = ref \u003CModule\u003E.IID_IMessage;
      IMessage* imessagePtr3 = imessagePtr1;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num = __calli((delegate* unmanaged[Stdcall]<IntPtr, uint, _GUID*, _SPropTagArray*, uint, IMAPIProgress*, _GUID*, void*, uint, _SPropProblemArray**, int>) *(int*) (*(int*) pMessage + 40))((IntPtr) imessagePtr2, 0U, (_GUID*) 0, (_SPropTagArray*) ref local1, 0U, (IMAPIProgress*) 0, (_GUID*) ref local2, (void*) imessagePtr3, 0U, (_SPropProblemArray**) 0);
    }
    else
    {
      MGASystems.IMS.ExtendedControls.\u003FSaveToMSG\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FCMJPAUIMessage\u0040\u0040A\u0024CAP\u0024AAVString\u0040System\u0040\u0040_N\u0040Z.__l20._SPropTagArray_excludeTags arrayExcludeTags;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref arrayExcludeTags = 6;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 4) = 267649027;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 8) = 268894211 /*0x10070003*/;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 12) = 268828675 /*0x10060003*/;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 16 /*0x10*/) = 268959775;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 20) = 269484035 /*0x10100003*/;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &arrayExcludeTags + 24) = 269549571;
      IMessage* imessagePtr4 = pMessage;
      ref MGASystems.IMS.ExtendedControls.\u003FSaveToMSG\u0040OleDataConverter\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u0040\u0024\u0024FCMJPAUIMessage\u0040\u0040A\u0024CAP\u0024AAVString\u0040System\u0040\u0040_N\u0040Z.__l20._SPropTagArray_excludeTags local3 = ref arrayExcludeTags;
      ref _GUID local4 = ref \u003CModule\u003E.IID_IMessage;
      IMessage* imessagePtr5 = imessagePtr1;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num = __calli((delegate* unmanaged[Stdcall]<IntPtr, uint, _GUID*, _SPropTagArray*, uint, IMAPIProgress*, _GUID*, void*, uint, _SPropProblemArray**, int>) *(int*) (*(int*) pMessage + 40))((IntPtr) imessagePtr4, 0U, (_GUID*) 0, (_SPropTagArray*) ref local3, 0U, (IMAPIProgress*) 0, (_GUID*) ref local4, (void*) imessagePtr5, 0U, (_SPropProblemArray**) 0);
    }
    IMessage* imessagePtr6 = imessagePtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num1 = __calli((delegate* unmanaged[Stdcall]<IntPtr, uint, int>) *(int*) (*(int*) imessagePtr1 + 16 /*0x10*/))((IntPtr) imessagePtr6, 2U);
    IStorage* istoragePtr2 = istoragePtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int msg = __calli((delegate* unmanaged[Stdcall]<IntPtr, uint, int>) *(int*) (*(int*) istoragePtr1 + 36))((IntPtr) istoragePtr2, 0U);
    int num2 = (int) \u003CModule\u003E.MAPIFreeBuffer((void*) 0);
    IStorage* istoragePtr3 = istoragePtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num3 = (int) __calli((delegate* unmanaged[Stdcall]<IntPtr, uint>) *(int*) (*(int*) istoragePtr3 + 8))((IntPtr) istoragePtr3);
    IMessage* imessagePtr7 = imessagePtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num4 = (int) __calli((delegate* unmanaged[Stdcall]<IntPtr, uint>) *(int*) (*(int*) imessagePtr7 + 8))((IntPtr) imessagePtr7);
    \u003CModule\u003E.CloseIMsgSession(msgsessPtr);
    return msg;
  }

  internal static unsafe DropHelper* MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002E\u007Bctor\u007D(
    [In] DropHelper* obj0,
    ICustomDropTargetHandler pICustomDropTargetHandler)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7DropHelper\u0040ExtendedControls\u0040IMS\u0040MGASystems\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    DropHelper* dropHelperPtr = (DropHelper*) ((IntPtr) obj0 + 8);
    *(int*) dropHelperPtr = (int) ((IntPtr) GCHandle.Alloc((object) null)).ToPointer();
    // ISSUE: fault handler
    try
    {
      ((GCHandle) new IntPtr((void*) *(int*) dropHelperPtr)).Target = (object) pICustomDropTargetHandler;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((delegate*<void*, void>) __methodptr(gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 8));
    }
    return obj0;
  }

  internal static unsafe int MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002EQueryInterface(
    [In] DropHelper* obj0,
    _GUID* riid,
    void** ppvObject)
  {
    if (\u003CModule\u003E.IsEqualGUID(riid, &\u003CModule\u003E.IID_IDropTarget) != 0)
    {
      *(int*) ppvObject = (int) obj0;
      *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) obj0 + 4) + 1;
      return 0;
    }
    if (\u003CModule\u003E.IsEqualGUID(riid, &\u003CModule\u003E.IID_IUnknown) == 0)
      return -2147467259 /*0x80004005*/;
    *(int*) ppvObject = (int) obj0;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) obj0 + 4) + 1;
    return 0;
  }

  internal static unsafe uint MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002EAddRef(
    [In] DropHelper* obj0)
  {
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) obj0 + 4) + 1;
    return (uint) *(int*) ((IntPtr) obj0 + 4);
  }

  internal static unsafe uint MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002ERelease(
    [In] DropHelper* obj0)
  {
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) obj0 + 4) - 1;
    return (uint) *(int*) ((IntPtr) obj0 + 4);
  }

  internal static unsafe IDropTarget* IDropTarget\u002E\u007Bctor\u007D([In] IDropTarget* obj0)
  {
    return obj0;
  }

  internal static unsafe IUnknown* IUnknown\u002E\u007Bctor\u007D([In] IUnknown* obj0) => obj0;

  internal static unsafe void* MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002E__delDtor(
    [In] DropHelper* obj0,
    uint _param1)
  {
    gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* dropTargetHandlerPtr = (gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E*) ((IntPtr) obj0 + 8);
    ((GCHandle) new IntPtr((void*) *(int*) dropTargetHandlerPtr)).Free();
    *(int*) dropTargetHandlerPtr = 0;
    if (((int) _param1 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0);
    return (void*) obj0;
  }

  internal static unsafe void MGASystems\u002EIMS\u002EExtendedControls\u002EDropHelper\u002E\u007Bdtor\u007D(
    [In] DropHelper* obj0)
  {
    gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* dropTargetHandlerPtr = (gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E*) ((IntPtr) obj0 + 8);
    ((GCHandle) new IntPtr((void*) *(int*) dropTargetHandlerPtr)).Free();
    *(int*) dropTargetHandlerPtr = 0;
  }

  [DebuggerStepThrough]
  internal static unsafe gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E\u002E\u007Bctor\u007D(
    [In] gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* obj0)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) null);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  [DebuggerStepThrough]
  internal static unsafe void gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E\u002E\u007Bdtor\u007D(
    [In] gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* obj0)
  {
    ((GCHandle) new IntPtr((void*) *(int*) obj0)).Free();
    *(int*) obj0 = 0;
  }

  [DebuggerStepThrough]
  internal static unsafe gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E\u002E\u003D(
    [In] gcroot\u003CMGASystems\u003A\u003AIMS\u003A\u003AExtendedControls\u003A\u003AICustomDropTargetHandler\u0020\u005E\u003E* obj0,
    ICustomDropTargetHandler t)
  {
    ((GCHandle) new IntPtr((void*) *(int*) obj0)).Target = (object) t;
    return obj0;
  }

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void* _getFiberPtrId();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void _amsg_exit([In] int obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  public static extern void __security_init_cookie();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void Sleep([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(
    [In] string obj0,
    [In] Exception obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(
    [In] string obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void \u003CCrtImplementationDetails\u003E\u002EDoDllLanguageSupportValidation();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void \u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(
    [In] Exception obj0,
    [In] Exception obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void \u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(
    [In] EventHandler obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void \u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain(
    [In] delegate* unmanaged[Stdcall]<void*, int> obj0,
    [In] void* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void _cexit();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int __FrameUnwindFilter([In] _EXCEPTION_POINTERS* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int OpenIMsgSession([In] IMalloc* obj0, [In] uint obj1, [In] _MSGSESS** obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void* @new([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern int __CxxQueryExceptionSize();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int __CxxDetectRethrow([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int RegisterDragDrop([In] HWND__* obj0, [In] IDropTarget* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe uint DragQueryFileW([In] HDROP__* obj0, [In] uint obj1, [In] char* obj2, [In] uint obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern int IsClipboardFormatAvailable([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int MAPIAllocateMore([In] uint obj0, [In] void* obj1, [In] void** obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void* GlobalFree([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void __CxxUnregisterExceptionObject([In] void* obj0, [In] int obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void delete([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void MAPIUninitialize();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int HrGetOneProp([In] IMAPIProp* obj0, [In] uint obj1, [In] _SPropValue** obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe uint GetTempPathW([In] uint obj0, [In] char* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int GlobalUnlock([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void ReleaseStgMedium([In] tagSTGMEDIUM* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int __CxxExceptionFilter(
    [In] void* obj0,
    [In] void* obj1,
    [In] int obj2,
    [In] void* obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void CloseIMsgSession([In] _MSGSESS* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int WriteClassStg([In] IStorage* obj0, [In] _GUID* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int StgCreateDocfile(
    [In] char* obj0,
    [In] uint obj1,
    [In] uint obj2,
    [In] IStorage** obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern void OleUninitialize();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int MAPIAllocateBuffer([In] uint obj0, [In] void** obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int OleInitialize([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int __CxxRegisterExceptionObject([In] void* obj0, [In] void* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe uint MAPIFreeBuffer([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe IMalloc* MAPIGetDefaultMalloc();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int MAPIInitialize([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe void* GlobalLock([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe uint GlobalSize([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int MessageBoxW([In] HWND__* obj0, [In] char* obj1, [In] char* obj2, [In] uint obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe uint RegisterClipboardFormatW([In] char* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int memcmp([In] void* obj0, [In] void* obj1, [In] uint obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int RevokeDragDrop([In] HWND__* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  public static extern unsafe int OpenIMsgOnIStg(
    [In] _MSGSESS* obj0,
    [In] delegate* unmanaged[Stdcall]<uint, void**, int> obj1,
    [In] delegate* unmanaged[Stdcall]<uint, void*, void**, int> obj2,
    [In] delegate* unmanaged[Stdcall]<void*, uint> obj3,
    [In] IMalloc* obj4,
    [In] void* obj5,
    [In] IStorage* obj6,
    [In] delegate* unmanaged[Stdcall]<uint, IMessage*, void> obj7,
    [In] uint obj8,
    [In] uint obj9,
    [In] IMessage** obj10);
}
