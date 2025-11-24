using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class BaseAddressDetection : AbstractSafeHandle<BaseAddressDetection>
	{
	    internal BaseAddressDetection(IntPtr handle , bool owner)
		    : base(handle , owner)
	    {
	        
	    }

	   
	    internal static BaseAddressDetection? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BaseAddressDetection(handle, true);
	    }
	    
	    internal static BaseAddressDetection MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BaseAddressDetection(handle, true);
	    }
	    
	    internal static BaseAddressDetection? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new BaseAddressDetection(handle, false);
	    }
	    
	    internal static BaseAddressDetection MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new BaseAddressDetection(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeBaseAddressDetection(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}