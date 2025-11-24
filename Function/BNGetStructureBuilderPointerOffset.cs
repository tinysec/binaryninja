using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNGetStructureBuilderPointerOffset(BNStructureBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStructureBuilderPointerOffset"
        )]
		internal static extern long BNGetStructureBuilderPointerOffset(
			
			// BNStructureBuilder* s
		    IntPtr s  
		);
	}
}