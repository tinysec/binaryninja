using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetScriptingInstanceCurrentFunction(BNScriptingInstance* instance, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetScriptingInstanceCurrentFunction"
        )]
		internal static extern void BNSetScriptingInstanceCurrentFunction(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}