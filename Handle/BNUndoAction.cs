using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class UndoAction : AbstractSafeHandle<UndoAction>
	{
	    internal UndoAction(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static UndoAction? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new UndoAction(
			    NativeMethods.BNNewUndoActionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static UndoAction MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new UndoAction(
			    NativeMethods.BNNewUndoActionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static UndoAction? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new UndoAction(handle, true);
	    }
	    
	    internal static UndoAction MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new UndoAction(handle, true);
	    }
	    
	    internal static UndoAction? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new UndoAction(handle, false);
	    }
	    
	    internal static UndoAction MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new UndoAction(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeUndoAction(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public string Summary
	    {
		    get
		    {
			    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNUndoActionGetSummaryText(this.handle)
			    );
		    }
	    }
	}
}