using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeScriptingInstance(BNScriptingInstance* instance)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeScriptingInstance"
        )]
		internal static extern void BNFreeScriptingInstance(
			
			// BNScriptingInstance* instance
		    IntPtr instance  
			
		);
	}
}