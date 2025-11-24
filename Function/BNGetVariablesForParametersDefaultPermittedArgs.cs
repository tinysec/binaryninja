using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable* BNGetVariablesForParametersDefaultPermittedArgs(BNCallingConvention* cc, BNFunctionParameter* @params, uint64_t paramCount, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetVariablesForParametersDefaultPermittedArgs"
        )]
		internal static extern IntPtr BNGetVariablesForParametersDefaultPermittedArgs(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNFunctionParameter* _params
		    IntPtr _params  , 
			
			// uint64_t paramCount
		    ulong paramCount  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}