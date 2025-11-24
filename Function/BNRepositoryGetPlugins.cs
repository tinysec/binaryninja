using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepoPlugin** BNRepositoryGetPlugins(BNRepository* r, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryGetPlugins"
        )]
		internal static extern IntPtr BNRepositoryGetPlugins(
			
			// BNRepository* r
		    IntPtr r  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}