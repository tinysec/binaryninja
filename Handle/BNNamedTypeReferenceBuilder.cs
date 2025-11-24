using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class NamedTypeReferenceBuilder :  AbstractSafeHandle<NamedTypeReferenceBuilder>
	{
	    internal NamedTypeReferenceBuilder(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }

	    internal static NamedTypeReferenceBuilder? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new NamedTypeReferenceBuilder(handle, true);
	    }
	    
	    internal static NamedTypeReferenceBuilder MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new NamedTypeReferenceBuilder(handle, true);
	    }
	    
	    internal static NamedTypeReferenceBuilder? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new NamedTypeReferenceBuilder(handle, false);
	    }
	    
	    internal static NamedTypeReferenceBuilder MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new NamedTypeReferenceBuilder(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeNamedTypeReferenceBuilder(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}