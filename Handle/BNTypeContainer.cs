using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class TypeContainer : AbstractSafeHandle<TypeContainer>
	{
		public TypeContainer() 
			: this( NativeMethods.BNGetEmptyTypeContainer() , true)
		{
			
		}
		
	    internal TypeContainer(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
			
	    }
	    
	    internal static TypeContainer MustDuplicateFromHandle(IntPtr handle)
	    {
		    return new TypeContainer(
			    NativeMethods.BNDuplicateTypeContainer(handle) ,
			    true
		    );
	    }

	    
	    internal static TypeContainer? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TypeContainer(handle, true);
	    }
	    
	    internal static TypeContainer MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TypeContainer(handle, true);
	    }
	    
	    internal static TypeContainer? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TypeContainer(handle, false);
	    }
	    
	    internal static TypeContainer MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TypeContainer(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeTypeContainer(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public string Id
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(NativeMethods.BNTypeContainerGetId(this.handle));
		    }
	    }
	    
	    public string Name
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(NativeMethods.BNTypeContainerGetName(this.handle));
		    }
	    }
	    
	    public TypeContainerType Type
	    {
		    get
		    {
			    return NativeMethods.BNTypeContainerGetType(this.handle);
		    }
	    }
	    
	    public bool Mutable
	    {
		    get
		    {
			    return NativeMethods.BNTypeContainerIsMutable(this.handle);
		    }
	    }
	    
	    public Platform Platform
	    {
		    get
		    {
			    IntPtr raw = NativeMethods.BNTypeContainerGetPlatform(this.handle);

			    if (IntPtr.Zero == raw)
			    {
				    throw new Exception("Unable to get platform");
			    }

			    return new Platform(raw , true);
		    }
	    }

	    public QualifiedNameAndId[] AddTypes(
		    QualifiedNameAndType[] types,
		    ProgressDelegate? progress = null
		)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    QualifiedName[] typeNames = QualifiedNameAndType.PickNames(types);
			    
			    bool ok = NativeMethods.BNTypeContainerAddTypes(
				    this.handle,
				    allocator.ConvertToNativeArrayEx<BNQualifiedName,QualifiedName>(typeNames),
				    allocator.AllocHandleArray<BinaryNinja.Type>(QualifiedNameAndType.PickTypes(types)) ,
				    (ulong)typeNames.Length,
				    null == progress ? IntPtr.Zero :
					    Marshal.GetFunctionPointerForDelegate<NativeDelegates.BNProgressFunction>(
					    UnsafeUtils.WrapProgressDelegate(progress)
					),
				    IntPtr.Zero, 
				    out IntPtr resultNamesPointer,
				    out IntPtr resultIdsPointer,
				    out ulong resultCount  
			    );
			    
			    List<QualifiedNameAndId> results = new List<QualifiedNameAndId>();

			    if (ok)
			    {
				    QualifiedName[] resultNames = UnsafeUtils.TakeStructArrayEx<BNQualifiedName , QualifiedName>(
					    resultNamesPointer ,
					    resultCount ,
					    QualifiedName.FromNative ,
					    NativeMethods.BNFreeTypeNameList
				    );

				    string[] resultIds = UnsafeUtils.TakeAnsiStringArray(
					    resultIdsPointer ,
					    resultCount,
					    NativeMethods.BNFreeStringList
				    );

				    for (ulong i = 0; i < resultCount; i++)
				    {
					    results.Add( new QualifiedNameAndId(
						    resultNames[i],
						    resultIds[i]
						));
				    }
			    }

			    return results.ToArray();
		    }
	    }

	    public bool RenameType(string typeId , QualifiedName newName)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return NativeMethods.BNTypeContainerRenameType(
				    this.handle, 
				    typeId, 
				    newName.ToNativeEx(allocator) 
				);
		    }
	    }
	    
	    public bool DeleteType(string typeId)
	    {
		    return NativeMethods.BNTypeContainerDeleteType(this.handle, typeId );
	    }
	    
	    public string GetTypeId(QualifiedName typeName)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeId(
				    this.handle, 
				    typeName.ToNativeEx(allocator) , 
				    out IntPtr typeIdPointer
				);

			    if (!ok)
			    {
				    return String.Empty;
			    }
			    
			    return UnsafeUtils.TakeAnsiString(typeIdPointer);
		    }
	    }
	    
	    public QualifiedName? GetTypeName(string typeId)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeName(
				    this.handle, 
				    typeId , 
				    out BNQualifiedName rawTypeName
			    );

			    if (!ok)
			    {
				    return null;
			    }
			    
			    return QualifiedName.FromNative(rawTypeName);
		    }
	    }
	    
	    public BinaryNinja.Type? GetTypeById(string typeId)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeById(
				    this.handle, 
				    typeId , 
				    out IntPtr rawType
			    );

			    if (!ok)
			    {
				    return null;
			    }
			    
			    return new BinaryNinja.Type(rawType , true);
		    }
	    }
	    
	    // QualifiedNameTypeAndId
	    public QualifiedNameTypeAndId[] GetTypes()
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypes(
				    this.handle,
				    out IntPtr typeIdsPointer,
				    out IntPtr typeNamesPointer,
				    out IntPtr typesPointer, 
				    out ulong typeCount  
			    );
	    
			    List<QualifiedNameTypeAndId> results = new List<QualifiedNameTypeAndId>();

			    if (ok)
			    {
				    QualifiedName[] typeNames = UnsafeUtils.TakeStructArrayEx<BNQualifiedName , QualifiedName>(
					    typeNamesPointer ,
					    typeCount ,
					    QualifiedName.FromNative ,
					    NativeMethods.BNFreeTypeNameList
				    );

				    string[] typeIds = UnsafeUtils.TakeAnsiStringArray(
					    typeIdsPointer ,
					    typeCount,
					    NativeMethods.BNFreeStringList
				    );
			    
				    BinaryNinja.Type[] types = UnsafeUtils.TakeHandleArrayEx<BinaryNinja.Type>(
					    typeNamesPointer ,
					    typeCount ,
					    BinaryNinja.Type.MustNewFromHandle,
					    NativeMethods.BNFreeTypeList
				    );

				    for (ulong i = 0; i < typeCount; i++)
				    {
					    results.Add( new QualifiedNameTypeAndId(
						    typeNames[i],
						    BinaryNinja.Type.MustNewFromHandle(types[i].DangerousGetHandle()),
						    typeIds[i]
						));
				    }
			    }
			    
			    return results.ToArray();
		    }
	    }


	    public BinaryNinja.Type? GetTypeByName(QualifiedName typeName)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeByName(
				    this.handle,  
				    typeName.ToNativeEx(allocator),
				    out IntPtr pointer
				);

			    if (!ok)
			    {
				    return null;
			    }
			    
			    return BinaryNinja.Type.TakeHandle(pointer);
		    }
	    }

	    public string[] TypeIds
	    {
		    get
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeIds(
				    this.handle,
				    out IntPtr typeIdsPointer,
				    out ulong typeCount
				);

			    if (!ok)
			    {
				    return Array.Empty<string>();
			    }

			    return UnsafeUtils.TakeAnsiStringArray(
				    typeIdsPointer ,
				    typeCount,
				    NativeMethods.BNFreeStringList
				    );
		    }
	    }
	    
	    public QualifiedName[] TypeNames
	    {
		    get
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeNames(
				    this.handle,
				    out IntPtr typeNamesPointer,
				    out ulong typeCount
			    );

			    if (!ok)
			    {
				    return Array.Empty<QualifiedName>();
			    }

			    return UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
				    typeNamesPointer , 
				    typeCount,
				    QualifiedName.FromNative,
				    NativeMethods.BNFreeTypeNameList
				);
		    }
	    }
	    
	    public QualifiedNameAndId[] TypeNameAndIds
	    {
		    get
		    {
			    bool ok = NativeMethods.BNTypeContainerGetTypeNamesAndIds(
				    this.handle,
				    out IntPtr typeIdsPointer,
				    out IntPtr typeNamesPointer,
				    out ulong typeCount
			    );

			    List<QualifiedNameAndId> results = new List<QualifiedNameAndId>();
			    
			    if (ok)
			    {
				    QualifiedName[] typeNames;

				    string[] typeIds;
				    
				    typeIds = UnsafeUtils.TakeAnsiStringArray(
					    typeIdsPointer , 
					    typeCount,
					    NativeMethods.BNFreeStringList
					    );
		    
				    typeNames = UnsafeUtils.TakeStructArrayEx<BNQualifiedName,QualifiedName>(
					    typeNamesPointer , 
					    typeCount,
					    QualifiedName.FromNative,
					    NativeMethods.BNFreeTypeNameList
				    );

				    for (ulong i = 0; i < typeCount; i++)
				    {
					    results.Add( new QualifiedNameAndId(
						    typeNames[i],
						    typeIds[i]
						));
				    }
			    }
				
			    return results.ToArray();
		    }
	    }

	    public QualifiedNameAndType? ParseTypeString(
		    string source ,
		    bool importDepencencies,
		    out TypeParserError[] errors
		)
	    {
		    bool ok =  NativeMethods.BNTypeContainerParseTypeString(
			    this.handle,
			    source,
			    importDepencencies,
			    out BNQualifiedNameAndType rawNameAndType,
			    out IntPtr errorsPointer,
			    out ulong errorCount
			);

		    if (ok)
		    {
			    errors = Array.Empty<TypeParserError>();
			    
			    return QualifiedNameAndType.FromNative(rawNameAndType);
		    }
		    else
		    {
			    errors = UnsafeUtils.TakeStructArrayEx<BNTypeParserError , TypeParserError>(
				    errorsPointer ,
				    errorCount ,
				    TypeParserError.FromNative ,
				    NativeMethods.BNFreeTypeParserErrors
			    );
			    
			    return null;
		    }
	    }
	    
	}
}