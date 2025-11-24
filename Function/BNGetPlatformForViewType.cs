using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform* BNGetPlatformForViewType(BNBinaryViewType* type, uint32_t id, BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformForViewType"
        )]
		internal static extern IntPtr BNGetPlatformForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// uint32_t id
		    uint id  , 
			
			// BNArchitecture* arch
		    IntPtr arch  
		);
	}
}