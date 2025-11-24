using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterPlatformForViewType(BNBinaryViewType* type, uint32_t id, BNArchitecture* arch, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterPlatformForViewType"
        )]
		internal static extern void BNRegisterPlatformForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// uint32_t id
		    uint id  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}