using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTransformContextSetTransformParameters(BNTransformContext* context, BNTransformParameter* @params, uint64_t paramCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTransformContextSetTransformParameters"
        )]
		internal static extern void BNTransformContextSetTransformParameters(
			
			// BNTransformContext* context
		    IntPtr context  , 
			
			// BNTransformParameter* _params
			BNTransformParameter[] _params  , 
			
			// uint64_t paramCount
		    ulong paramCount  
		);
	}
}