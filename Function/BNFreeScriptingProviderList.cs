using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeScriptingProviderList(BNScriptingProvider** providers)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeScriptingProviderList"
        )]
		internal static extern void BNFreeScriptingProviderList(
			
			// BNScriptingProvider** providers
		    IntPtr providers  
			
		);
	}
}