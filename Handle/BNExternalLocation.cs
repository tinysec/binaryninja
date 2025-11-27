using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class ExternalLocation : AbstractSafeHandle
	{
	    internal ExternalLocation(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static ExternalLocation? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new ExternalLocation(
			    NativeMethods.BNNewExternalLocationReference(handle) ,
			    true
		    );
	    }
	    
	    internal static ExternalLocation MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new ExternalLocation(
			    NativeMethods.BNNewExternalLocationReference(handle) ,
			    true
		    );
	    }
	    
	    internal static ExternalLocation? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new ExternalLocation(handle, true);
	    }
	    
	    internal static ExternalLocation MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new ExternalLocation(handle, true);
	    }
	    
	    internal static ExternalLocation? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new ExternalLocation(handle, false);
	    }
	    
	    internal static ExternalLocation MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new ExternalLocation(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeExternalLocation(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}