using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Component : AbstractSafeHandle<Component>
	{
	    internal Component(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	 
	    internal static Component? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Component(
			    NativeMethods.BNNewComponentReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Component MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Component(
			    NativeMethods.BNNewComponentReference(handle) ,
			    true
		    );
	    }
	    
	    internal static Component? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Component(handle, true);
	    }
	    
	    internal static Component MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Component(handle, true);
	    }
	    
	    internal static Component? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new Component(handle, false);
	    }
	    
	    internal static Component MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new Component(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeComponent(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}