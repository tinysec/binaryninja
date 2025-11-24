using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureBuilder* BNCreateStructureBuilderFromStructure(BNStructure* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateStructureBuilderFromStructure"
        )]
		internal static extern IntPtr BNCreateStructureBuilderFromStructure(
			
			// BNStructure* s
		    IntPtr s  
		);
	}
}