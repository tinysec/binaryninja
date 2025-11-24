using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class CallingConvention : AbstractSafeHandle<CallingConvention>
	{
	    internal CallingConvention(IntPtr handle , bool owner)
		    : base(handle , owner)
	    {
	       
	    }

	    internal static BinaryNinja.CallingConvention? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BinaryNinja.CallingConvention(
			    NativeMethods.BNNewCallingConventionReference(handle) ,
			    true
		    );
	    }
	   
	    internal static BinaryNinja.CallingConvention MustNewFromHandle(IntPtr handle)
	    {
		    return new BinaryNinja.CallingConvention(
			    NativeMethods.BNNewCallingConventionReference(handle) ,
			    true
		    );
	    }
	    
	    
	    internal static BinaryNinja.CallingConvention? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BinaryNinja.CallingConvention(handle, true);
	    }
	    
	    internal static BinaryNinja.CallingConvention MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BinaryNinja.CallingConvention(handle, true);
	    }
	    
	    internal static BinaryNinja.CallingConvention? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BinaryNinja.CallingConvention(handle, false);
	    }
	    
	    internal static BinaryNinja.CallingConvention MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BinaryNinja.CallingConvention(handle, false);
	    }
	
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeCallingConvention(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}