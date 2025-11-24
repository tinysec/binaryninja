using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNGetTypeArchiveIncomingRecursiveTypeReferences(BNTypeArchive* archive, const char* id, const char* snapshot, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeArchiveIncomingRecursiveTypeReferences"
        )]
		internal static extern IntPtr BNGetTypeArchiveIncomingRecursiveTypeReferences(
			
			// BNTypeArchive* archive
		    IntPtr archive  , 
			
			// const char* id
		    string id  , 
			
			// const char* snapshot
		    string snapshot  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}