using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetStructureBuilderAlignment(BNStructureBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStructureBuilderAlignment"
        )]
		internal static extern ulong BNGetStructureBuilderAlignment(
			
			// BNStructureBuilder* s
		    IntPtr s  
		);
	}
}