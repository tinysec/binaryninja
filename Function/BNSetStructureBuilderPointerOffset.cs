using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetStructureBuilderPointerOffset(BNStructureBuilder* s, int64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetStructureBuilderPointerOffset"
        )]
		internal static extern void BNSetStructureBuilderPointerOffset(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// int64_t offset
		    long offset  
		);
	}
}