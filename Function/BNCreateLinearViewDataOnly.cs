using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNCreateLinearViewDataOnly(BNBinaryView* view, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLinearViewDataOnly"
        )]
		internal static extern IntPtr BNCreateLinearViewDataOnly(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}