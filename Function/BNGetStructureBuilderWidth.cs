using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetStructureBuilderWidth(BNStructureBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStructureBuilderWidth"
        )]
		internal static extern ulong BNGetStructureBuilderWidth(
			
			// BNStructureBuilder* s
		    IntPtr s  
		);
	}
}