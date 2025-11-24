using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNWriteDatabaseAnalysisCache(BNDatabase* database, BNKeyValueStore* val)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWriteDatabaseAnalysisCache"
        )]
		internal static extern bool BNWriteDatabaseAnalysisCache(
			
			// BNDatabase* database
		    IntPtr database  , 
			
			// BNKeyValueStore* val
		    IntPtr val  
			
		);
	}
}