using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetLiftedILFlagDefinitionsForUse(BNFunction* func, uint64_t i, uint32_t flag, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLiftedILFlagDefinitionsForUse"
        )]
		internal static extern IntPtr BNGetLiftedILFlagDefinitionsForUse(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t i
		    ulong i  , 
			
			// uint32_t flag
		    uint flag  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}