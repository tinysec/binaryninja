using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNBinaryViewGetTypeArchives(BNBinaryView* view, const char*** ids, const char*** paths)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewGetTypeArchives"
        )]
		internal static extern ulong BNBinaryViewGetTypeArchives(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// char** ids
			out IntPtr ids  , 
			
			// char** paths
		    out IntPtr paths  
		);
	}
}