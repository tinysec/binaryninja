using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNScriptingInstance* BNCreateScriptingProviderInstance(BNScriptingProvider* provider)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateScriptingProviderInstance"
        )]
		internal static extern IntPtr BNCreateScriptingProviderInstance(
			
			// BNScriptingProvider* provider
		    IntPtr provider  
		);
	}
}