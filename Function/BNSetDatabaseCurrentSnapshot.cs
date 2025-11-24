using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDatabaseCurrentSnapshot(BNDatabase* database, int64_t id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDatabaseCurrentSnapshot"
        )]
		internal static extern void BNSetDatabaseCurrentSnapshot(
			
			// BNDatabase* database
		    IntPtr database  , 
			
			// int64_t id
		    long id  
			
		);
	}
}