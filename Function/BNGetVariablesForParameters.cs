using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable* BNGetVariablesForParameters(BNCallingConvention* cc, BNFunctionParameter* @params, uint64_t paramCount, uint32_t* permittedArgs, uint64_t permittedArgCount, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetVariablesForParameters"
        )]
		internal static extern IntPtr BNGetVariablesForParameters(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNFunctionParameter* _params
		    IntPtr _params  , 
			
			// uint64_t paramCount
		    ulong paramCount  , 
			
			// uint32_t* permittedArgs
		    IntPtr permittedArgs  , 
			
			// uint64_t permittedArgCount
		    ulong permittedArgCount  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}