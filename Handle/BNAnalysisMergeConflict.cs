using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class AnalysisMergeConflict : AbstractSafeHandle<AnalysisMergeConflict>
	{
	    internal AnalysisMergeConflict(IntPtr handle , bool owner)
		    : base(handle , owner)
	    {
	       
	    }
	    
	    internal static AnalysisMergeConflict? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisMergeConflict(
			    NativeMethods.BNNewAnalysisMergeConflictReference(handle) ,
			    true
		    );
	    }
	    
	    internal static AnalysisMergeConflict MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisMergeConflict(
			    NativeMethods.BNNewAnalysisMergeConflictReference(handle) ,
			    true
		    );
	    }
	    
	    internal static AnalysisMergeConflict? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisMergeConflict(handle, true);
	    }
	    
	    internal static AnalysisMergeConflict MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisMergeConflict(handle, true);
	    }
	    
	    internal static AnalysisMergeConflict? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new AnalysisMergeConflict(handle, false);
	    }
	    
	    internal static AnalysisMergeConflict MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new AnalysisMergeConflict(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeAnalysisMergeConflict(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}