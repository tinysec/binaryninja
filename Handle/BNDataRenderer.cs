using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class DataRenderer :  AbstractSafeHandle<DataRenderer>
	{
	    public DataRenderer(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static DataRenderer? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DataRenderer(
			    NativeMethods.BNNewDataRendererReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DataRenderer MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DataRenderer(
			    NativeMethods.BNNewDataRendererReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DataRenderer? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DataRenderer(handle, true);
	    }
	    
	    internal static DataRenderer MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DataRenderer(handle, true);
	    }
	    
	    internal static DataRenderer? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DataRenderer(handle, false);
	    }
	    
	    internal static DataRenderer MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DataRenderer(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeDataRenderer(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}