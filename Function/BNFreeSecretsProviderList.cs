using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSecretsProviderList(BNSecretsProvider** providers)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeSecretsProviderList"
        )]
		internal static extern void BNFreeSecretsProviderList(
			
			// BNSecretsProvider** providers
		    IntPtr providers  
			
		);
	}
}