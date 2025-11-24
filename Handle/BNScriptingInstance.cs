using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class ScriptingInstance : AbstractSafeHandle<ScriptingInstance>
	{
	    public ScriptingInstance(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static ScriptingInstance? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new ScriptingInstance(
			    NativeMethods.BNNewScriptingInstanceReference(handle) ,
			    true
		    );
	    }
	    
	    internal static ScriptingInstance MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new ScriptingInstance(
			    NativeMethods.BNNewScriptingInstanceReference(handle) ,
			    true
		    );
	    }
	    
	    internal static ScriptingInstance? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new ScriptingInstance(handle, true);
	    }
	    
	    internal static ScriptingInstance MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new ScriptingInstance(handle, true);
	    }
	    
	    internal static ScriptingInstance? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new ScriptingInstance(handle, false);
	    }
	    
	    internal static ScriptingInstance MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new ScriptingInstance(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeScriptingInstance(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	}
}