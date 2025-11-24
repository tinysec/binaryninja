using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetArchitectureIntrinsicName(BNArchitecture* arch, uint32_t intrinsic)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureIntrinsicName"
        )]
		internal static extern IntPtr BNGetArchitectureIntrinsicName(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t intrinsic
			IntrinsicIndex intrinsic  
		);
	}
}