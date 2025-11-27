using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Platform :  AbstractSafeHandle
	{
		public Platform(Architecture arch , string name)
			:this( NativeMethods.BNCreatePlatform(arch.DangerousGetHandle() , name) , true)
		{
			
		}
		
	    internal Platform(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }

	    internal static Platform? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Platform(
			    NativeMethods.BNNewPlatformReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Platform MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Platform(
			    NativeMethods.BNNewPlatformReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Platform? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Platform(handle, true);
	    }
	    
	    internal static Platform MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Platform(handle, true);
	    }
	    
	    internal static Platform? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Platform(handle, false);
	    }
	    
	    internal static Platform MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Platform(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreePlatform(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
		
	    public static Platform[] GetAllPlatforms()
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetPlatformList(out ulong arrayLength);

		    return UnsafeUtils.TakeHandleArrayEx<Platform>(
			    arrayPointer ,
			    arrayLength ,
			    Platform.MustNewFromHandle,
			    NativeMethods.BNFreePlatformList
		    );
	    }

	    public static string[] GetAllPlatformNames()
	    {
		    List<string> items = new List<string>();

		    Platform[] platforms = Platform.GetAllPlatforms();

		    foreach (Platform platform in platforms)
		    {
			    if (!items.Contains(platform.Name))
			    {
				    items.Add(platform.Name);
			    }
		    }
		    
		    return items.ToArray();
	    }
		
	    public static Platform? ChoosePlatform(string prompt = "Choose" , string title = "Choose a platform")
	    {
		    string[] names = Platform.GetAllPlatformNames();
		    
		    int? index = Core.GetLargeChoiceInput(
			    prompt ,
			    title ,
			    names
		    );

		    if (null == index)
		    {
			    return null;
		    }
		    
		    return Platform.FromName(names[(int)index]);
	    }
	    
	    public static Platform? FromName(string name)
	    {
		    return Platform.TakeHandle(
			    NativeMethods.BNGetPlatformByName(name)
		    );
	    }
	    
	    public static Platform[] GetPlatformsByOS(string os)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetPlatformListByOS(
			    os,
			    out ulong arrayLength
			);

		    return UnsafeUtils.TakeHandleArrayEx<Platform>(
			    arrayPointer ,
			    arrayLength ,
			    Platform.MustNewFromHandle,
			    NativeMethods.BNFreePlatformList
		    );
	    }

	    public static string[] GetOSList()
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetPlatformOSList(out ulong arrayLength);

		    return UnsafeUtils.TakeAnsiStringArray(
			    arrayPointer ,
			    arrayLength,
			    NativeMethods.BNFreePlatformOSList
		    );
	    }

	    public void RegisterPlatform(string os)
	    {
		    NativeMethods.BNRegisterPlatform(os , this.handle);
	    }

	    public string Name
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetPlatformName(this.handle)
			    );
		    }
	    }
	    
	    public Architecture Architecture
	    {
		    get
		    {
			    return Architecture.MustFromHandle(
				    NativeMethods.BNGetPlatformArchitecture(this.handle)
			    );
		    }
	    }
	    
	    public BinaryNinja.CallingConvention DefaultCallingConvention
	    {
		    get
		    {
			    return BinaryNinja.CallingConvention.MustTakeHandle(
				    NativeMethods.BNGetPlatformDefaultCallingConvention(this.handle)
			    );
		    }
	    }
	    
	    public BinaryNinja.CallingConvention CdeclCallingConvention
	    {
		    get
		    {
			    return BinaryNinja.CallingConvention.MustTakeHandle(
				    NativeMethods.BNGetPlatformCdeclCallingConvention(this.handle)
			    );
		    }
	    }
	    
	    public BinaryNinja.CallingConvention StdcallCallingConvention
	    {
		    get
		    {
			    return BinaryNinja.CallingConvention.MustTakeHandle(
				    NativeMethods.BNGetPlatformStdcallCallingConvention(this.handle)
			    );
		    }
	    }

	    public BinaryNinja.CallingConvention FastcallCallingConvention
	    {
		    get
		    {
			    return BinaryNinja.CallingConvention.MustTakeHandle(
				    NativeMethods.BNGetPlatformFastcallCallingConvention(this.handle)
			    );
		    }
	    }
	    
	    public BinaryNinja.CallingConvention SystemCallConvention
	    {
		    get
		    {
			    return BinaryNinja.CallingConvention.MustTakeHandle(
				    NativeMethods.BNGetPlatformSystemCallConvention(this.handle)
			    );
		    }
	    }
	    
	    
	    public BinaryNinja.CallingConvention[] CallingConventions()
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetPlatformCallingConventions(
			    this.handle,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeHandleArrayEx<CallingConvention>(
			    arrayPointer ,
			    arrayLength ,
			    BinaryNinja.CallingConvention.MustNewFromHandle,
			    NativeMethods.BNFreeCallingConventionList
		    );
	    }
	    
	    public void RegisterCallingConvention(BinaryNinja.CallingConvention callConvention)
	    {
			NativeMethods.BNRegisterPlatformCallingConvention(
				this.handle, 
				callConvention.DangerousGetHandle()
			);
	    }
	    
	    public void RegisterDefaultCallingConvention(BinaryNinja.CallingConvention callConvention)
	    {
		    NativeMethods.BNRegisterPlatformDefaultCallingConvention(
			    this.handle, 
			    callConvention.DangerousGetHandle()
		    );
	    }
	    
	    public void RegisterCdeclCallingConvention(BinaryNinja.CallingConvention callConvention)
	    {
		    NativeMethods.BNRegisterPlatformCdeclCallingConvention(
			    this.handle, 
			    callConvention.DangerousGetHandle()
		    );
	    }
	    
	    public void RegisterStdcallCallingConvention(BinaryNinja.CallingConvention callConvention)
	    {
		    NativeMethods.BNRegisterPlatformStdcallCallingConvention(
			    this.handle, 
			    callConvention.DangerousGetHandle()
		    );
	    }
	    
	    public void RegisterFastcallCallingConvention(BinaryNinja.CallingConvention callConvention)
	    {
		    NativeMethods.BNRegisterPlatformFastcallCallingConvention(
			    this.handle, 
			    callConvention.DangerousGetHandle()
		    );
	    }
	    
	    public void SetSystemCallConvention(BinaryNinja.CallingConvention callConvention)
	    {
		    NativeMethods.BNSetPlatformSystemCallConvention(
			    this.handle, 
			    callConvention.DangerousGetHandle()
		    );
	    }

	    public uint[] GlobalRegisters
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetPlatformGlobalRegisters(
				    this.handle,
				    out ulong arrayLength
				);
			    
			    return UnsafeUtils.TakeNumberArray<uint>(
				    arrayPointer , 
				    arrayLength,
				    NativeMethods.BNFreeRegisterList
				);
		    }
	    }

	    public ulong AddressSize
	    {
		    get
		    {
			    return NativeMethods.BNGetPlatformAddressSize(this.handle);
		    }
	    }

	    public Platform? GetRelatedPlatform(Architecture arch)
	    {
		    return Platform.TakeHandle(
			    NativeMethods.BNGetRelatedPlatform(
				    this.handle, 
				    arch.DangerousGetHandle()
				)
		    );
	    }
	    
	    public void AddRelatedPlatform(Architecture arch , Platform platform)
	    {
		    NativeMethods.BNAddRelatedPlatform(
			    this.handle ,
			    arch.DangerousGetHandle() ,
			    platform.DangerousGetHandle()
		    );
	    }

	    public Platform[] RelatedPlatforms
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetRelatedPlatforms(
				    this.handle ,
				    out ulong arrayLength
			    );

			    return UnsafeUtils.TakeHandleArrayEx<Platform>(
				    arrayPointer ,
				    arrayLength ,
				    Platform.MustNewFromHandle ,
				    NativeMethods.BNFreePlatformList
			    );
		    }
	    }
	    
	    public Platform? GetAssociatedPlatformByAddress(ref ulong address)
	    {
		    return Platform.TakeHandle(
			    NativeMethods.BNGetAssociatedPlatformByAddress(
				    this.handle, 
				    ref address
			    )
		    );
	    }


	    public TypeContainer TypeContainer
	    {
		    get
		    {
			    return TypeContainer.MustTakeHandle(
					NativeMethods.BNGetPlatformTypeContainer(this.handle)
			    );
		    }
	    }
	    
	    public QualifiedNameAndType[] Types
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetPlatformTypes(
				    this.handle,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeStructArrayEx<BNQualifiedNameAndType , QualifiedNameAndType>(
				    arrayPointer ,
				    arrayLength ,
				    QualifiedNameAndType.FromNative ,
				    NativeMethods.BNFreeTypeAndNameList
			    );
		    }
	    }
	    
	    public QualifiedNameAndType[] Variables
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetPlatformVariables(
				    this.handle,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeStructArrayEx<BNQualifiedNameAndType , QualifiedNameAndType>(
				    arrayPointer ,
				    arrayLength ,
				    QualifiedNameAndType.FromNative ,
				    NativeMethods.BNFreeTypeAndNameList
			    );
		    }
	    }
	    
	    public QualifiedNameAndType[] Functions
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetPlatformFunctions(
				    this.handle,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeStructArrayEx<BNQualifiedNameAndType , QualifiedNameAndType>(
				    arrayPointer ,
				    arrayLength ,
				    QualifiedNameAndType.FromNative ,
				    NativeMethods.BNFreeTypeAndNameList
			    );
		    }
	    }
	    
	    public SystemCallInfo[] SystemCalls
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetPlatformSystemCalls(
				    this.handle,
				    out ulong arrayLength
			    );
			    
			    return UnsafeUtils.TakeStructArrayEx<BNSystemCallInfo , SystemCallInfo>(
				    arrayPointer ,
				    arrayLength ,
				    SystemCallInfo.FromNative ,
				    NativeMethods.BNFreeSystemCallList
			    );
		    }
	    }

	    public BinaryNinja.Type? GetTypeByName(QualifiedName name)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return BinaryNinja.Type.TakeHandle(
				    NativeMethods.BNGetPlatformTypeByName(
					    this.handle ,
					    name.ToNativeEx(allocator)
					) 
			    );
		    }
	    }
	    
	    public BinaryNinja.Type? GetVariableByName(QualifiedName name)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return BinaryNinja.Type.TakeHandle(
				    NativeMethods.BNGetPlatformVariableByName(
					    this.handle ,
					    name.ToNativeEx(allocator)
				    ) 
			    );
		    }
	    }
	    
	    public BinaryNinja.Type? GetFunctionByName(QualifiedName name , bool exactMatch =false )
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return BinaryNinja.Type.TakeHandle(
				    NativeMethods.BNGetPlatformFunctionByName(
					    this.handle ,
					    name.ToNativeEx(allocator),
					    exactMatch
				    ) 
			    );
		    }
	    }

	    public string GetSystemCallName(uint number)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetPlatformSystemCallName(this.handle , number)
		    );
	    }
	    
	    public BinaryNinja.Type? GetSystemCallType(uint number)
	    {
		    return BinaryNinja.Type.TakeHandle(
			    NativeMethods.BNGetPlatformSystemCallType(this.handle , number)
		    );
	    }

	    public TypeLibrary[] TypeLibraries
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetPlatformTypeLibraries(
				    this.handle,
				    out ulong arrayLength
				);

			    return UnsafeUtils.TakeHandleArrayEx<TypeLibrary>(
					arrayPointer,
					arrayLength,
					TypeLibrary.MustNewFromHandle,
					NativeMethods.BNFreeTypeLibraryList
			    );
		    }
	    }
	}
	
}