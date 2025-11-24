using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNScriptingProviderInputReadyState BNGetScriptingInstanceInputReadyState(BNScriptingInstance* instance)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetScriptingInstanceInputReadyState"
        )]
		internal static extern ScriptingProviderInputReadyState BNGetScriptingInstanceInputReadyState(
			
			// BNScriptingInstance* instance
		    IntPtr instance  
			
		);
	}
}