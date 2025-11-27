using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class MainThreadAction : AbstractSafeHandle
	{
	    internal MainThreadAction(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }

	    internal static MainThreadAction? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new MainThreadAction(
			    NativeMethods.BNNewMainThreadActionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static MainThreadAction MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new MainThreadAction(
			    NativeMethods.BNNewMainThreadActionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static MainThreadAction? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new MainThreadAction(handle, true);
	    }
	    
	    internal static MainThreadAction MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new MainThreadAction(handle, true);
	    }
	    
	    internal static MainThreadAction? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new MainThreadAction(handle, false);
	    }
	    
	    internal static MainThreadAction MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new MainThreadAction(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeMainThreadAction(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}