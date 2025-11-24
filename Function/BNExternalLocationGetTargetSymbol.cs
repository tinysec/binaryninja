using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNExternalLocationGetTargetSymbol(BNExternalLocation* loc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNExternalLocationGetTargetSymbol"
        )]
		internal static extern IntPtr BNExternalLocationGetTargetSymbol(
			
			// BNExternalLocation* loc
		    IntPtr loc  
			
		);
	}
}