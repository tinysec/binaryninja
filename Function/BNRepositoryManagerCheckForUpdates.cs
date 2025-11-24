using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNRepositoryManagerCheckForUpdates(BNRepositoryManager* r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryManagerCheckForUpdates"
        )]
		internal static extern bool BNRepositoryManagerCheckForUpdates(
			
			// BNRepositoryManager* r
		    IntPtr r  
			
		);
	}
}