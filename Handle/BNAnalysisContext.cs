using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class AnalysisContext : AbstractSafeHandle
	{
	    internal AnalysisContext(IntPtr handle , bool owner)
		    : base(handle , owner)
	    {
	        
	    }

	    
	    internal static AnalysisContext? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisContext(
			    NativeMethods.BNNewAnalysisContextReference(handle) ,
			    true
		    );
	    }
	    
	    internal static AnalysisContext MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisContext(
			    NativeMethods.BNNewAnalysisContextReference(handle) ,
			    true
		    );
	    }
	    
	    internal static AnalysisContext? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisContext(handle, true);
	    }
	    
	    internal static AnalysisContext MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisContext(handle, true);
	    }
	    
	    internal static AnalysisContext? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisContext(handle, false);
	    }
	    
	    internal static AnalysisContext MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisContext(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeAnalysisContext(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}