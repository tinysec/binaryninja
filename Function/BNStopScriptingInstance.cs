using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNStopScriptingInstance(BNScriptingInstance* instance)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNStopScriptingInstance"
        )]
		internal static extern void BNStopScriptingInstance(
			
			// BNScriptingInstance* instance
		    IntPtr instance  
			
		);
	}
}