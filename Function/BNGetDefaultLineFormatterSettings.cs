using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLineFormatterSettings* BNGetDefaultLineFormatterSettings(BNDisassemblySettings* settings, BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDefaultLineFormatterSettings"
        )]
		internal static extern IntPtr BNGetDefaultLineFormatterSettings(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// BNHighLevelILFunction* func
		    IntPtr func  
			
		);
	}
}