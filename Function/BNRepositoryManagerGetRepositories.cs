using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepository** BNRepositoryManagerGetRepositories(BNRepositoryManager* r, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryManagerGetRepositories"
        )]
		internal static extern IntPtr BNRepositoryManagerGetRepositories(
			
			// BNRepositoryManager* r
		    IntPtr r  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}