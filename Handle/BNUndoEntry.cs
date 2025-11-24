using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class UndoEntry : AbstractSafeHandle<UndoEntry>
	{
	    internal UndoEntry(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }

	    internal static UndoEntry? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new UndoEntry(
			    NativeMethods.BNNewUndoEntryReference(handle) ,
			    true
		    );
	    }
	    
	    internal static UndoEntry MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new UndoEntry(
			    NativeMethods.BNNewUndoEntryReference(handle) ,
			    true
		    );
	    }
	    
	    internal static UndoEntry? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new UndoEntry(handle, true);
	    }
	    
	    internal static UndoEntry MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new UndoEntry(handle, true);
	    }
	    
	    internal static UndoEntry? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new UndoEntry(handle, false);
	    }
	    
	    internal static UndoEntry MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new UndoEntry(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeUndoEntry(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}