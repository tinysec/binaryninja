using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class DownloadInstance : AbstractSafeHandle<DownloadInstance>
	{
	    internal DownloadInstance(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static DownloadInstance? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DownloadInstance(
			    NativeMethods.BNNewDownloadInstanceReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DownloadInstance MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DownloadInstance(
			    NativeMethods.BNNewDownloadInstanceReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DownloadInstance? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DownloadInstance(handle, true);
	    }
	    
	    internal static DownloadInstance MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DownloadInstance(handle, true);
	    }
	    
	    internal static DownloadInstance? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DownloadInstance(handle, false);
	    }
	    
	    internal static DownloadInstance MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DownloadInstance(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeDownloadInstance(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}