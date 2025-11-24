using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNGetDatabaseGlobalKeys(BNDatabase* database, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDatabaseGlobalKeys"
        )]
		internal static extern IntPtr BNGetDatabaseGlobalKeys(
			
			// BNDatabase* database
		    IntPtr database  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}