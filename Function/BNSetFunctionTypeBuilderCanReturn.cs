using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionTypeBuilderCanReturn(BNTypeBuilder* type, BNBoolWithConfidence* canReturn)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFunctionTypeBuilderCanReturn"
        )]
		internal static extern void BNSetFunctionTypeBuilderCanReturn(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNBoolWithConfidence* canReturn
		    in BNBoolWithConfidence canReturn  
		);
	}
}