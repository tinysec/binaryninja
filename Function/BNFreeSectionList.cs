using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSectionList(BNSection** sections, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeSectionList"
        )]
		internal static extern void BNFreeSectionList(
			
			// BNSection** sections
		    IntPtr sections  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}