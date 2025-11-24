using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDatabaseReloadConnection(BNDatabase* database)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDatabaseReloadConnection"
        )]
		internal static extern void BNDatabaseReloadConnection(
			
			// BNDatabase* database
		    IntPtr database  
		);
	}
}