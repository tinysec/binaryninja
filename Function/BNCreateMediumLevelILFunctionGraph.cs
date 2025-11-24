using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraph* BNCreateMediumLevelILFunctionGraph(BNMediumLevelILFunction* func, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMediumLevelILFunctionGraph"
        )]
		internal static extern IntPtr BNCreateMediumLevelILFunctionGraph(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}