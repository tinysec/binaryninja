using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlagRole BNGetArchitectureFlagRole(BNArchitecture* arch, uint32_t flag, uint32_t semClass)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagRole"
        )]
		internal static extern FlagRole BNGetArchitectureFlagRole(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t flag
		    uint flag  , 
			
			// uint32_t semClass
		    uint semClass  
		);
	}
}