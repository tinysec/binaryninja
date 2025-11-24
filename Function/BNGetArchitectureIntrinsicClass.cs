using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNIntrinsicClass BNGetArchitectureIntrinsicClass(BNArchitecture* arch, uint32_t intrinsic)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureIntrinsicClass"
        )]
		internal static extern IntrinsicClass BNGetArchitectureIntrinsicClass(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t intrinsic
			IntrinsicIndex intrinsic  
		);
	}
}