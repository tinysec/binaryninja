using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnregisterScriptingInstanceOutputListener(BNScriptingInstance* instance, BNScriptingOutputListener* callbacks)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnregisterScriptingInstanceOutputListener"
        )]
		internal static extern void BNUnregisterScriptingInstanceOutputListener(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// BNScriptingOutputListener* callbacks
		    IntPtr callbacks  
			
		);
	}
}