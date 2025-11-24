using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureBuilder* BNDuplicateStructureBuilder(BNStructureBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNDuplicateStructureBuilder"
        )]
		internal static extern IntPtr BNDuplicateStructureBuilder(
			
			// BNStructureBuilder* s
		    IntPtr s  
			
		);
	}
}