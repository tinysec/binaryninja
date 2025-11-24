using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public class FlowGraphLayoutRequest : AbstractSafeHandle<FlowGraphLayoutRequest>
	{
	    internal FlowGraphLayoutRequest(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeFlowGraphLayoutRequest(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public bool Complete
	    {
		    get
		    {
			    return NativeMethods.BNIsFlowGraphLayoutRequestComplete(this.handle);
		    }
	    }

	    public void Abort()
	    {
		    NativeMethods.BNAbortFlowGraphLayoutRequest(handle);
	    }
	}
}