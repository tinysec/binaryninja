using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class FirmwareNinjaReferenceNode : AbstractSafeHandle<FirmwareNinjaReferenceNode>
	{
	    internal FirmwareNinjaReferenceNode(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }
	    
	    internal static FirmwareNinjaReferenceNode? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinjaReferenceNode(
			    NativeMethods.BNNewFirmwareNinjaReferenceNodeReference(handle) ,
			    true
		    );
	    }
	    
	    internal static FirmwareNinjaReferenceNode MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinjaReferenceNode(
			    NativeMethods.BNNewFirmwareNinjaReferenceNodeReference(handle) ,
			    true
		    );
	    }
	    
	    internal static FirmwareNinjaReferenceNode? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinjaReferenceNode(handle, true);
	    }
	    
	    internal static FirmwareNinjaReferenceNode MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinjaReferenceNode(handle, true);
	    }
	    
	    internal static FirmwareNinjaReferenceNode? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new FirmwareNinjaReferenceNode(handle, false);
	    }
	    
	    internal static FirmwareNinjaReferenceNode MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new FirmwareNinjaReferenceNode(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFirmwareNinjaReferenceNode(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}