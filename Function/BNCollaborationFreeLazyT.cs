using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCollaborationFreeLazyT(BNCollaborationLazyT* lazyT)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationFreeLazyT"
        )]
		internal static extern void BNCollaborationFreeLazyT(
			
			// BNCollaborationLazyT* lazyT
		    IntPtr lazyT  
		);
	}
}