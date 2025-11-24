using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class RelocationHandler : AbstractSafeHandle<RelocationHandler>
	{
	    internal RelocationHandler(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static RelocationHandler? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new RelocationHandler(
			    NativeMethods.BNNewRelocationHandlerReference(handle) ,
			    true
		    );
	    }
	    
	    internal static RelocationHandler MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new RelocationHandler(
			    NativeMethods.BNNewRelocationHandlerReference(handle) ,
			    true
		    );
	    }
	    
	    internal static RelocationHandler? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new RelocationHandler(handle, true);
	    }
	    
	    internal static RelocationHandler MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new RelocationHandler(handle, true);
	    }
	    
	    internal static RelocationHandler? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new RelocationHandler(handle, false);
	    }
	    
	    internal static RelocationHandler MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new RelocationHandler(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeRelocationHandler(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}