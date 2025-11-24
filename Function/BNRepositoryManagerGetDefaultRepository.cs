using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepository* BNRepositoryManagerGetDefaultRepository(BNRepositoryManager* r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryManagerGetDefaultRepository"
        )]
		internal static extern IntPtr BNRepositoryManagerGetDefaultRepository(
			
			// BNRepositoryManager* r
		    IntPtr r  
			
		);
	}
}