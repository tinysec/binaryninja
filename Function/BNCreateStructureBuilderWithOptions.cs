using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureBuilder* BNCreateStructureBuilderWithOptions(BNStructureVariant type, bool packed)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateStructureBuilderWithOptions"
        )]
		internal static extern IntPtr BNCreateStructureBuilderWithOptions(
			
			// BNStructureVariant type
		    StructureVariant type  , 
			
			// bool packed
		    bool packed  
		);
	}
}