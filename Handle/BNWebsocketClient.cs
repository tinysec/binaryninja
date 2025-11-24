using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class WebsocketClient : AbstractSafeHandle<WebsocketClient>
	{
	    internal WebsocketClient(IntPtr handle , bool owner)
		    : base(handle , owner)
	    {
	        
	    }

	    internal static WebsocketClient? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new WebsocketClient(
			    NativeMethods.BNNewWebsocketClientReference(handle) ,
			    true
		    );
	    }
	    
	    internal static WebsocketClient MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new WebsocketClient(
			    NativeMethods.BNNewWebsocketClientReference(handle) ,
			    true
		    );
	    }
	    
	    internal static WebsocketClient? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new WebsocketClient(handle, true);
	    }
	    
	    internal static WebsocketClient MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new WebsocketClient(handle, true);
	    }
	    
	    internal static WebsocketClient? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new WebsocketClient(handle, false);
	    }
	    
	    internal static WebsocketClient MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new WebsocketClient(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeWebsocketClient(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}