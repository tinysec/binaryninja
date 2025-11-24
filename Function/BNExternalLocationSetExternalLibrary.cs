using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNExternalLocationSetExternalLibrary(BNExternalLocation* loc, BNExternalLibrary* library)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNExternalLocationSetExternalLibrary"
        )]
		internal static extern void BNExternalLocationSetExternalLibrary(
			
			// BNExternalLocation* loc
		    IntPtr loc  , 
			
			// BNExternalLibrary* library
		    IntPtr library  
			
		);
	}
}