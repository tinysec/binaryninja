using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraph* BNGetUnresolvedStackAdjustmentGraph(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetUnresolvedStackAdjustmentGraph"
        )]
		internal static extern IntPtr BNGetUnresolvedStackAdjustmentGraph(
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}