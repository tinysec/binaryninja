using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLlvmServicesAssembleFree(const char* outBytes, const char* err)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNLlvmServicesAssembleFree"
        )]
		internal static extern void BNLlvmServicesAssembleFree(
			
			// const char* outBytes
		    string outBytes  , 
			
			// const char* err
		    string err  
			
		);
	}
}