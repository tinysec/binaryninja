using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepoPlugin* BNNewPluginReference(BNRepoPlugin* r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewPluginReference"
        )]
		internal static extern IntPtr BNNewPluginReference(
			
			// BNRepoPlugin* r
		    IntPtr r  
			
		);
	}
}