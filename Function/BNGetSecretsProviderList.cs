using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSecretsProvider** BNGetSecretsProviderList(uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSecretsProviderList"
        )]
		internal static extern IntPtr BNGetSecretsProviderList(
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}