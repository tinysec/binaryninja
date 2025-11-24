using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAnalysisHold(BNBinaryView* view, bool enable)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetAnalysisHold"
        )]
		internal static extern void BNSetAnalysisHold(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// bool enable
		    bool enable  
		);
	}
}