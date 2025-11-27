using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class CollaborationLazyT :  AbstractSafeHandle
	{
	    public CollaborationLazyT(IntPtr handle)
			:base(handle, false)
	    {
		    
	    }
	    
	}
}