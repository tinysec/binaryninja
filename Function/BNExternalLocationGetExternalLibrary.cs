using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNExternalLibrary* BNExternalLocationGetExternalLibrary(BNExternalLocation* loc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNExternalLocationGetExternalLibrary"
        )]
		internal static extern IntPtr BNExternalLocationGetExternalLibrary(
			
			// BNExternalLocation* loc
		    IntPtr loc  
			
		);
	}
}