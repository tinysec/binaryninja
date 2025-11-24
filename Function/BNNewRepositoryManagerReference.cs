using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepositoryManager* BNNewRepositoryManagerReference(BNRepositoryManager* r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewRepositoryManagerReference"
        )]
		internal static extern IntPtr BNNewRepositoryManagerReference(
			
			// BNRepositoryManager* r
		    IntPtr r  
			
		);
	}
}