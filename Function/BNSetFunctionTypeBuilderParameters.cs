using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionTypeBuilderParameters(BNTypeBuilder* type, BNFunctionParameter* @params, uint64_t paramCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetFunctionTypeBuilderParameters"
        )]
		internal static extern void BNSetFunctionTypeBuilderParameters(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNFunctionParameter* _params
			BNFunctionParameter[] _params  , 
			
			// uint64_t paramCount
		    ulong paramCount  
		);
	}
}