using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class FirmwareNinjaRelationship : AbstractSafeHandle<FirmwareNinjaRelationship>
	{
	    internal FirmwareNinjaRelationship(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }
	    
	    internal static FirmwareNinjaRelationship? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinjaRelationship(
			    NativeMethods.BNNewFirmwareNinjaRelationshipReference(handle) ,
			    true
		    );
	    }
	    
	    internal static FirmwareNinjaRelationship MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinjaRelationship(
			    NativeMethods.BNNewFirmwareNinjaRelationshipReference(handle) ,
			    true
		    );
	    }
	    
	    internal static FirmwareNinjaRelationship? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinjaRelationship(handle, true);
	    }
	    
	    internal static FirmwareNinjaRelationship MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinjaRelationship(handle, true);
	    }
	    
	    internal static FirmwareNinjaRelationship? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinjaRelationship(handle, false);
	    }
	    
	    internal static FirmwareNinjaRelationship MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinjaRelationship(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFirmwareNinjaRelationship(handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}