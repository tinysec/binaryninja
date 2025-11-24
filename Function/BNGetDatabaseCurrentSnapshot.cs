using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSnapshot* BNGetDatabaseCurrentSnapshot(BNDatabase* database)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDatabaseCurrentSnapshot"
        )]
		internal static extern IntPtr BNGetDatabaseCurrentSnapshot(
			
			// BNDatabase* database
		    IntPtr database  
			
		);
	}
}