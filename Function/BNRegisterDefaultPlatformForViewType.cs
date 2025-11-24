using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterDefaultPlatformForViewType(BNBinaryViewType* type, BNArchitecture* arch, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterDefaultPlatformForViewType"
        )]
		internal static extern void BNRegisterDefaultPlatformForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNPlatform* platform
		    IntPtr platform  
		);
	}
}