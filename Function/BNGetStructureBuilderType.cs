using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureVariant BNGetStructureBuilderType(BNStructureBuilder* s)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStructureBuilderType"
        )]
		internal static extern StructureVariant BNGetStructureBuilderType(
			
			// BNStructureBuilder* s
		    IntPtr s  
		);
	}
}