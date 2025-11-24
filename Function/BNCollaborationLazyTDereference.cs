using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void* BNCollaborationLazyTDereference(BNCollaborationLazyT* lazyT)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationLazyTDereference"
        )]
		internal static extern IntPtr BNCollaborationLazyTDereference(
			
			// BNCollaborationLazyT* lazyT
		    IntPtr lazyT  
		);
	}
}