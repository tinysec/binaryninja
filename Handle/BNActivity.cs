using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Activity : AbstractSafeHandle<Activity>
	{
	    internal Activity(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static Activity? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Activity(
			    NativeMethods.BNNewActivityReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Activity MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Activity(
			    NativeMethods.BNNewActivityReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Activity? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Activity(handle, true);
	    }
	    
	    internal static Activity MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Activity(handle, true);
	    }
	    
	    internal static Activity? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Activity(handle, false);
	    }
	    
	    internal static Activity MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Activity(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeActivity(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public string Name
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNActivityGetName(this.handle)
			    );
		    }
	    }
	}
}