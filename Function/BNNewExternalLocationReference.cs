using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNExternalLocation* BNNewExternalLocationReference(BNExternalLocation* loc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewExternalLocationReference"
        )]
		internal static extern IntPtr BNNewExternalLocationReference(
			
			// BNExternalLocation* loc
		    IntPtr loc  
			
		);
	}
}