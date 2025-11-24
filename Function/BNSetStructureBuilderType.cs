using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetStructureBuilderType(BNStructureBuilder* s, BNStructureVariant type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetStructureBuilderType"
        )]
		internal static extern void BNSetStructureBuilderType(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// BNStructureVariant type
		    StructureVariant type  
		);
	}
}