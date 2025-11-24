using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable* BNGetParameterOrderingForVariables(BNCallingConvention* cc, BNVariable* paramVars, BNType** paramTypes, uint64_t paramCount, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetParameterOrderingForVariables"
        )]
		internal static extern IntPtr BNGetParameterOrderingForVariables(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNVariable* paramVars
		    IntPtr paramVars  , 
			
			// BNType** paramTypes
		    IntPtr paramTypes  , 
			
			// uint64_t paramCount
		    ulong paramCount  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}