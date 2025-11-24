using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNGetStackAdjustmentForVariables(BNCallingConvention* cc, BNVariable* paramVars, BNType** paramTypes, uint64_t paramCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetStackAdjustmentForVariables"
        )]
		internal static extern long BNGetStackAdjustmentForVariables(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNVariable* paramVars
		    IntPtr paramVars  , 
			
			// BNType** paramTypes
		    IntPtr paramTypes  , 
			
			// uint64_t paramCount
		    ulong paramCount  
			
		);
	}
}