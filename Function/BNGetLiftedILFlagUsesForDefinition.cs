using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetLiftedILFlagUsesForDefinition(BNFunction* func, uint64_t i, uint32_t flag, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLiftedILFlagUsesForDefinition"
        )]
		internal static extern IntPtr BNGetLiftedILFlagUsesForDefinition(
			
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