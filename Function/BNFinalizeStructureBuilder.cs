using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructure* BNFinalizeStructureBuilder(BNStructureBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFinalizeStructureBuilder"
        )]
		internal static extern IntPtr BNFinalizeStructureBuilder(
			
			// BNStructureBuilder* s
		    IntPtr s  
		);
	}
}