using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class DebugInfoParser : AbstractSafeHandle
	{
	    internal DebugInfoParser(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static DebugInfoParser? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DebugInfoParser(
			    NativeMethods.BNNewDebugInfoParserReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DebugInfoParser MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DebugInfoParser(
			    NativeMethods.BNNewDebugInfoParserReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DebugInfoParser? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DebugInfoParser(handle, true);
	    }
	    
	    internal static DebugInfoParser MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DebugInfoParser(handle, true);
	    }
	    
	    internal static DebugInfoParser? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DebugInfoParser(handle, false);
	    }
	    
	    internal static DebugInfoParser MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DebugInfoParser(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeDebugInfoParserReference(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}