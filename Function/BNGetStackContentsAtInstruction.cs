using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetStackContentsAtInstruction(BNFunction* func, BNArchitecture* arch, uint64_t addr, int64_t offset, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStackContentsAtInstruction"
        )]
		internal static extern BNRegisterValue BNGetStackContentsAtInstruction(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// int64_t offset
		    long offset  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}