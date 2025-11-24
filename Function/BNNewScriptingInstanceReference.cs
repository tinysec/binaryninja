using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNScriptingInstance* BNNewScriptingInstanceReference(BNScriptingInstance* instance)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewScriptingInstanceReference"
        )]
		internal static extern IntPtr BNNewScriptingInstanceReference(
			
			// BNScriptingInstance* instance
		    IntPtr instance  
			
		);
	}
}