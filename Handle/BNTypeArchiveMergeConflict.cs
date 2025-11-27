using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class TypeArchiveMergeConflict : AbstractSafeHandle
	{
	    internal TypeArchiveMergeConflict(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }
	    
	    internal static TypeArchiveMergeConflict? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TypeArchiveMergeConflict(
			    NativeMethods.BNNewTypeArchiveMergeConflictReference(handle) ,
			    true
		    );
	    }
	    
	    internal static TypeArchiveMergeConflict MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TypeArchiveMergeConflict(
			    NativeMethods.BNNewTypeArchiveMergeConflictReference(handle) ,
			    true
		    );
	    }
	    
	    internal static TypeArchiveMergeConflict? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TypeArchiveMergeConflict(handle, true);
	    }
	    
	    internal static TypeArchiveMergeConflict MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TypeArchiveMergeConflict(handle, true);
	    }
	    
	    internal static TypeArchiveMergeConflict? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new TypeArchiveMergeConflict(handle, false);
	    }
	    
	    internal static TypeArchiveMergeConflict MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new TypeArchiveMergeConflict(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeTypeArchiveMergeConflict(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}