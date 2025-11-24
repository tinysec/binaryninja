using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNExternalLocationHasTargetAddress(BNExternalLocation* loc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNExternalLocationHasTargetAddress"
        )]
		internal static extern bool BNExternalLocationHasTargetAddress(
			
			// BNExternalLocation* loc
		    IntPtr loc  
			
		);
	}
}