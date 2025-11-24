using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetFlagsWrittenByLiftedILInstruction(BNFunction* func, uint64_t i, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFlagsWrittenByLiftedILInstruction"
        )]
		internal static extern IntPtr BNGetFlagsWrittenByLiftedILInstruction(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t i
		    ulong i  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}