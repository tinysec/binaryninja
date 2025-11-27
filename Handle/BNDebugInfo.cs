using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class DebugInfo : AbstractSafeHandle
	{
	    internal DebugInfo(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static DebugInfo? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DebugInfo(
			    NativeMethods.BNNewDebugInfoReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DebugInfo MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DebugInfo(
			    NativeMethods.BNNewDebugInfoReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DebugInfo? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DebugInfo(handle, true);
	    }
	    
	    internal static DebugInfo MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DebugInfo(handle, true);
	    }
	    
	    internal static DebugInfo? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DebugInfo(handle, false);
	    }
	    
	    internal static DebugInfo MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DebugInfo(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeDebugInfoReference(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}