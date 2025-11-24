using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetParameterValueAtInstruction(BNFunction* func, BNArchitecture* arch, uint64_t addr, BNType* functionType, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetParameterValueAtInstruction"
        )]
		internal static extern BNRegisterValue BNGetParameterValueAtInstruction(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNType* functionType
		    IntPtr functionType  , 
			
			// uint64_t i
		    ulong i  
		);
	}
}