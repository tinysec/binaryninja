using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNCreateLinearViewHighLevelILSSAForm(BNBinaryView* view, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLinearViewHighLevelILSSAForm"
        )]
		internal static extern IntPtr BNCreateLinearViewHighLevelILSSAForm(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}