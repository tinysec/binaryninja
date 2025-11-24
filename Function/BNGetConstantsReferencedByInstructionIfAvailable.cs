using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNConstantReference* BNGetConstantsReferencedByInstructionIfAvailable(BNFunction* func, BNArchitecture* arch, uint64_t addr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetConstantsReferencedByInstructionIfAvailable"
        )]
		internal static extern IntPtr BNGetConstantsReferencedByInstructionIfAvailable(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}