using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetScriptingInstanceCurrentBasicBlock(BNScriptingInstance* instance, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetScriptingInstanceCurrentBasicBlock"
        )]
		internal static extern void BNSetScriptingInstanceCurrentBasicBlock(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// BNBasicBlock* block
		    IntPtr block  
			
		);
	}
}