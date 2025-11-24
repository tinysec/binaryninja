using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetStructureBuilderAlignment(BNStructureBuilder* s, uint64_t align)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetStructureBuilderAlignment"
        )]
		internal static extern void BNSetStructureBuilderAlignment(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// uint64_t align
		    ulong align  
		);
	}
}