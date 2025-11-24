using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNKeyValueStore* BNReadDatabaseAnalysisCache(BNDatabase* database)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNReadDatabaseAnalysisCache"
        )]
		internal static extern IntPtr BNReadDatabaseAnalysisCache(
			
			// BNDatabase* database
		    IntPtr database  
			
		);
	}
}