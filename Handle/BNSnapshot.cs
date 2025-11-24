using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Snapshot : AbstractSafeHandle<Snapshot>
	{
	    internal Snapshot(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	       
	    }

	    internal static Snapshot? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Snapshot(
			    NativeMethods.BNNewSnapshotReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Snapshot MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Snapshot(
			    NativeMethods.BNNewSnapshotReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Snapshot? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Snapshot(handle, true);
	    }
	    
	    internal static Snapshot MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Snapshot(handle, true);
	    }
	    
	    internal static Snapshot? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Snapshot(handle, false);
	    }
	    
	    internal static Snapshot MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Snapshot(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeSnapshot(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}