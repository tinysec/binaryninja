using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public class Type: AbstractSafeHandle
	{
	    internal Type(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static BinaryNinja.Type? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BinaryNinja.Type(
			    NativeMethods.BNNewTypeReference(handle) ,
			    true
		    );
	    }
	    
	    internal static BinaryNinja.Type MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BinaryNinja.Type(
			    NativeMethods.BNNewTypeReference(handle) ,
			    true
		    );
	    }
	    
	    internal static BinaryNinja.Type? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BinaryNinja.Type(handle, true);
	    }
	    
	    internal static BinaryNinja.Type MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BinaryNinja.Type(handle, true);
	    }
	    
	    internal static BinaryNinja.Type? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BinaryNinja.Type(handle, false);
	    }
	    
	    internal static BinaryNinja.Type MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BinaryNinja.Type(handle, false);
	    }
	
	    
	    public static string GetNameTypeString( NameType classFunctionType )
	    {
		    return Core.GetNameTypeString(classFunctionType);
	    }
	    
	    public static string GenerateAutoTypeId(string source  , QualifiedName name)
	    {
		    return Core.GenerateAutoTypeId(source , name);
	    }
	    
	    public static string GenerateAutoDemangledTypeId( QualifiedName name)
	    {
		    return Core.GenerateAutoDemangledTypeId( name);
	    }
	    
	    public static string GetAutoDemangledTypeIdSource()
	    {
		    return Core.GetAutoDemangledTypeIdSource();
	    }
	    
	    public static string GetAutoDebugTypeIdSource()
	    {
		    return Core.GetAutoDebugTypeIdSource();
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeType(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        return true;
	    }

	    public override string ToString()
	    {
		    return this.GetString();
	    }
	    
	    public NamedTypeReference GetNamedTypeReference()
	    {
		    return NamedTypeReference.MustTakeHandle(
			    NativeMethods.BNGetTypeNamedTypeReference(this.handle)
			);
	    }
	    
	    public NameType GetNameType()
	    {
		    return NativeMethods.BNTypeGetNameType(this.handle);
	    }
	    
	    public bool ShouldDisplayReturnType()
	    {
		    return NativeMethods.BNTypeShouldDisplayReturnType(this.handle);
	    }
	    
	    public QualifiedName Name
	    {
		    get
		    {
			    return QualifiedName.TakeNative(
				    NativeMethods.BNTypeGetTypeName(this.handle)
				);
		    }
	    }
	    
	    public QualifiedName GetName()
	    {
		    return QualifiedName.TakeNative(
			    NativeMethods.BNTypeGetTypeName(this.handle)
		    );
	    }
	    
	    public string AlternateName
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetTypeAlternateName(this.handle)
			    );
		    }
	    }

	    public TypeWithConfidence WithConfidence(byte confidence )
	    {
		    return new TypeWithConfidence(
			    BinaryNinja.Type.MustNewFromHandle(this.DangerousGetHandle())
			    , confidence
			);
	    }
	    
	    /// <summary>
	    /// seems just size i bytes
	    /// </summary>
	    public ulong Width
	    {
		    get
		    {
			    return NativeMethods.BNGetTypeWidth(this.handle);
		    }
	    }
	    
	    public ulong Alignment
	    {
		    get
		    {
			    return NativeMethods.BNGetTypeAlignment(this.handle);
		    }
	    }
	    
	    public ulong Offset
	    {
		    get
		    {
			    return NativeMethods.BNGetTypeOffset(this.handle);
		    }
	    }

	    public string GetString(
		    Platform? platform = null,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
		)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetTypeString(
				    this.handle ,
				    null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
				    escaping
			    )
		    );
	    }
	    
	    public string GetStringBeforeName(
		    Platform? platform = null,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
	    )
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetTypeStringBeforeName(
				    this.handle ,
				    null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
				    escaping
			    )
		    );
	    }
	    
	    public string GetStringAfterName(
		    Platform? platform = null,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
	    )
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetTypeStringAfterName(
				    this.handle ,
				    null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
				    escaping
			    )
		    );
	    }

	    public InstructionTextToken[] GetTokens(
		    byte baseConfidence = Core.MaxConfidence,
		    Platform? platform = null,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
		)
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetTypeTokens(
			    this.handle ,
			    null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
			    baseConfidence ,
			    escaping ,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNInstructionTextToken , InstructionTextToken>(
			    arrayPointer ,
			    arrayLength ,
			    InstructionTextToken.FromNative ,
			    NativeMethods.BNFreeInstructionText
		    );
	    }
	    
	    public InstructionTextToken[] GetTokensBeforeName(
		    byte baseConfidence = Core.MaxConfidence,
		    Platform? platform = null,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetTypeTokensBeforeName(
			    this.handle ,
			    null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
			    baseConfidence ,
			    escaping ,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNInstructionTextToken , InstructionTextToken>(
			    arrayPointer ,
			    arrayLength ,
			    InstructionTextToken.FromNative ,
			    NativeMethods.BNFreeInstructionText
		    );
	    }
	    
	    public InstructionTextToken[] GetTokensAfterName(
		    byte baseConfidence = Core.MaxConfidence,
		    Platform? platform = null,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetTypeTokensAfterName(
			    this.handle ,
			    null == platform ? IntPtr.Zero : platform.DangerousGetHandle() ,
			    baseConfidence ,
			    escaping ,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNInstructionTextToken , InstructionTextToken>(
			    arrayPointer ,
			    arrayLength ,
			    InstructionTextToken.FromNative ,
			    NativeMethods.BNFreeInstructionText
		    );
	    }
	    
	    public TypeDefinitionLine[] GetLines(
		    TypeContainer types,
		    string name,
		    int paddingCols,
		    bool collapsed,
		    TokenEscapingType escaping = TokenEscapingType.NoTokenEscapingType
	    )
	    {
		    IntPtr arrayPointer = NativeMethods.BNGetTypeLines(
			    this.handle ,
			    types.DangerousGetHandle(),
			    name,
			    paddingCols,
			    collapsed,
			    escaping ,
			    out ulong arrayLength
		    );

		    return UnsafeUtils.TakeStructArrayEx<BNTypeDefinitionLine , TypeDefinitionLine>(
			    arrayPointer ,
			    arrayLength ,
			    TypeDefinitionLine.FromNative ,
			    NativeMethods.BNFreeTypeDefinitionLineList
		    );
	    }
	    
	    public BoolWithConfidence IsConst
	    {
		    get
		    {
			    return BoolWithConfidence.FromNative(

				    NativeMethods.BNIsTypeConst(this.handle)
			    );
		    }
	    }
	    
	    public BoolWithConfidence IsVolatile
	    {
		    get
		    {
			    return BoolWithConfidence.FromNative(

				    NativeMethods.BNIsTypeVolatile(this.handle)
			    );
		    }
	    }
	    
	    public bool IsSystemCall
	    {
		    get
		    {
			    return NativeMethods.BNTypeIsSystemCall(this.handle);
		    }
	    }
	    
	    public uint GetSystemCallNumber()
	    {
		    return NativeMethods.BNTypeGetSystemCallNumber(this.handle);
	    }
	}
	
}