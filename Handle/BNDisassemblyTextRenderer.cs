using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class DisassemblyTextRenderer : AbstractSafeHandle
	{
	    internal DisassemblyTextRenderer(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static DisassemblyTextRenderer? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DisassemblyTextRenderer(
			    NativeMethods.BNNewDisassemblyTextRendererReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DisassemblyTextRenderer MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DisassemblyTextRenderer(
			    NativeMethods.BNNewDisassemblyTextRendererReference(handle) ,
			    true
		    );
	    }
	    
	    internal static DisassemblyTextRenderer? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DisassemblyTextRenderer(handle, true);
	    }
	    
	    internal static DisassemblyTextRenderer MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DisassemblyTextRenderer(handle, true);
	    }
	    
	    internal static DisassemblyTextRenderer? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new DisassemblyTextRenderer(handle, false);
	    }
	    
	    internal static DisassemblyTextRenderer MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new DisassemblyTextRenderer(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeDisassemblyTextRenderer(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}