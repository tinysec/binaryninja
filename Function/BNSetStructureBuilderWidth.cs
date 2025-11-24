using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetStructureBuilderWidth(BNStructureBuilder* s, uint64_t width)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetStructureBuilderWidth"
        )]
		internal static extern void BNSetStructureBuilderWidth(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// uint64_t width
		    ulong width  
		);
	}
}