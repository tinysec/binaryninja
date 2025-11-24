using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepository* BNRepositoryGetRepositoryByPath(BNRepositoryManager* r, const char* repoPath)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRepositoryGetRepositoryByPath"
        )]
		internal static extern IntPtr BNRepositoryGetRepositoryByPath(
			
			// BNRepositoryManager* r
		    IntPtr r  , 
			
			// const char* repoPath
		    string repoPath  
			
		);
	}
}