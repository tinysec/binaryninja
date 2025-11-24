using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot* BNGetDatabaseSnapshot(BNDatabase* database, int64_t id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDatabaseSnapshot"
        )]
		internal static extern IntPtr BNGetDatabaseSnapshot(
			
			// BNDatabase* database
		    IntPtr database  , 
			
			// int64_t id
		    long id  
			
		);
	}
}