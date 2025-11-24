using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class RepositoryManager : AbstractSafeHandle<RepositoryManager>
	{
	    internal RepositoryManager(IntPtr handle , bool owner)
		    : base(handle , owner)
	    {
	        
	    }

	    internal static RepositoryManager? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new RepositoryManager(
			    NativeMethods.BNNewRepositoryManagerReference(handle) ,
			    true
		    );
	    }
	    
	    internal static RepositoryManager MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new RepositoryManager(
			    NativeMethods.BNNewRepositoryManagerReference(handle) ,
			    true
		    );
	    }
	    
	    internal static RepositoryManager? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new RepositoryManager(handle, true);
	    }
	    
	    internal static RepositoryManager MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new RepositoryManager(handle, true);
	    }
	    
	    internal static RepositoryManager? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new RepositoryManager(handle, false);
	    }
	    
	    internal static RepositoryManager MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new RepositoryManager(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeRepositoryManager(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}