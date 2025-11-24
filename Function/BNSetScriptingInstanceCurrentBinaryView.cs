using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetScriptingInstanceCurrentBinaryView(BNScriptingInstance* instance, BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetScriptingInstanceCurrentBinaryView"
        )]
		internal static extern void BNSetScriptingInstanceCurrentBinaryView(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// BNBinaryView* view
		    IntPtr view  
			
		);
	}
}