using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class AnalysisCompletionEvent : AbstractSafeHandle
	{
	    internal AnalysisCompletionEvent(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static AnalysisCompletionEvent? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisCompletionEvent(
			    NativeMethods.BNNewAnalysisCompletionEventReference(handle) ,
			    true
		    );
	    }
	    
	    internal static AnalysisCompletionEvent MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisCompletionEvent(
			    NativeMethods.BNNewAnalysisCompletionEventReference(handle) ,
			    true
		    );
	    }
	    
	    internal static AnalysisCompletionEvent? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisCompletionEvent(handle, true);
	    }
	    
	    internal static AnalysisCompletionEvent MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisCompletionEvent(handle, true);
	    }
	    
	    internal static AnalysisCompletionEvent? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisCompletionEvent(handle, false);
	    }
	    
	    internal static AnalysisCompletionEvent MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisCompletionEvent(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeAnalysisCompletionEvent(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}