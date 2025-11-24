using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCancelScriptInput(BNScriptingInstance* instance)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCancelScriptInput"
        )]
		internal static extern void BNCancelScriptInput(
			
			// BNScriptingInstance* instance
		    IntPtr instance
		);
	}
}