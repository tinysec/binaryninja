using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUser** BNGetUsers(BNFileMetadata* file, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetUsers"
        )]
		internal static extern IntPtr BNGetUsers(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}