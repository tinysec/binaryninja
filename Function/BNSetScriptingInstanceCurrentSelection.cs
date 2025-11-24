using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetScriptingInstanceCurrentSelection(BNScriptingInstance* instance, uint64_t begin, uint64_t end)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetScriptingInstanceCurrentSelection"
        )]
		internal static extern void BNSetScriptingInstanceCurrentSelection(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// uint64_t begin
		    ulong begin  , 
			
			// uint64_t end
		    ulong end  
			
		);
	}
}