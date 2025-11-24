using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNCreateLinearViewSingleFunctionMappedMediumLevelILSSAForm(BNFunction* func, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLinearViewSingleFunctionMappedMediumLevelILSSAForm"
        )]
		internal static extern IntPtr BNCreateLinearViewSingleFunctionMappedMediumLevelILSSAForm(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}