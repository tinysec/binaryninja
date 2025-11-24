using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterScriptingInstanceOutputListener(BNScriptingInstance* instance, BNScriptingOutputListener* callbacks)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterScriptingInstanceOutputListener"
        )]
		internal static extern void BNRegisterScriptingInstanceOutputListener(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// BNScriptingOutputListener* callbacks
		    IntPtr callbacks  
			
		);
	}
}