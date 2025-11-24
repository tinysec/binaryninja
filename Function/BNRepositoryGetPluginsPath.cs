using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNRepositoryGetPluginsPath(BNRepository* r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryGetPluginsPath"
        )]
		internal static extern IntPtr BNRepositoryGetPluginsPath(
			
			// BNRepository* r
		    IntPtr r  
			
		);
	}
}