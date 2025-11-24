using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNNameAndType* BNGetArchitectureIntrinsicInputs(BNArchitecture* arch, uint32_t intrinsic, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureIntrinsicInputs"
        )]
		internal static extern IntPtr BNGetArchitectureIntrinsicInputs(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t intrinsic
			IntrinsicIndex intrinsic  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}