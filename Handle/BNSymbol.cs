using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Symbol : AbstractSafeHandle<Symbol>
	{
	    internal Symbol(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static Symbol? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Symbol(
			    NativeMethods.BNNewSymbolReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Symbol MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Symbol(
			    NativeMethods.BNNewSymbolReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Symbol? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Symbol(handle, true);
	    }
	    
	    internal static Symbol MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Symbol(handle, true);
	    }
	    
	    internal static Symbol? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Symbol(handle, false);
	    }
	    
	    internal static Symbol MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Symbol(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeSymbol(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public override string ToString()
	    {
		    return this.FullName;
	    }

	    public SymbolType Type
	    {
		    get
		    {
			    return NativeMethods.BNGetSymbolType(handle);
		    }
	    }

	    public SymbolBinding Binding
	    {
		    get
		    {
			    return NativeMethods.BNGetSymbolBinding(handle);
		    }
	    }

	    public string ShortName
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetSymbolShortName(this.handle)
			    );
		    }
	    }
	    
	    public string FullName
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetSymbolFullName(this.handle)
			    );
		    }
	    }
	    
	    public string RawName
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNGetSymbolRawName(this.handle)
			    );
		    }
	    }
	    
	    public byte[] RawBytes
	    {
		    get
		    {
			    IntPtr arrayPointer = NativeMethods.BNGetSymbolRawBytes(
				    this.handle ,
				    out ulong arrayLength
				);


			    return UnsafeUtils.TakeNumberArray<byte>(
				    arrayPointer ,
				    arrayLength,
				    NativeMethods.BNFreeSymbolRawBytes
			    );
		    }
	    }
	    
	    public ulong Address
	    {
		    get
		    {
			    return NativeMethods.BNGetSymbolAddress(this.handle);
		    }
	    }
	    
	    public ulong Ordinal
	    {
		    get
		    {
			    return NativeMethods.BNGetSymbolOrdinal(this.handle);
		    }
	    }

	    public bool AutoDefined
	    {
		    get
		    {
			    return NativeMethods.BNIsSymbolAutoDefined(this.handle);
		    }
	    }
	}
	
	
}