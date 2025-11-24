using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class StringRef : AbstractSafeHandle<StringRef>
	{
	    internal StringRef(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static StringRef? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new StringRef(handle, true);
	    }
	    
	    internal static StringRef MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new StringRef(handle, true);
	    }
	    
	    internal static StringRef? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new StringRef(handle, false);
	    }
	    
	    internal static StringRef MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new StringRef(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeStringRef(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}