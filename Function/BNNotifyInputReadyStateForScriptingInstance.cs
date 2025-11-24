using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNNotifyInputReadyStateForScriptingInstance(BNScriptingInstance* instance, BNScriptingProviderInputReadyState state)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNotifyInputReadyStateForScriptingInstance"
        )]
		internal static extern void BNNotifyInputReadyStateForScriptingInstance(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// BNScriptingProviderInputReadyState state
		    ScriptingProviderInputReadyState state  
			
		);
	}
}