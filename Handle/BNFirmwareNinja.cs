using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class FirmwareNinja : AbstractSafeHandle<FirmwareNinja>
	{
	    public FirmwareNinja(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }
	    
	    internal static FirmwareNinja? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinja(handle, true);
	    }
	    
	    internal static FirmwareNinja MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinja(handle, true);
	    }
	    
	    internal static FirmwareNinja? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinja(handle, false);
	    }
	    
	    internal static FirmwareNinja MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinja(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFirmwareNinja(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}