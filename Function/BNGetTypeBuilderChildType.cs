using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeWithConfidence BNGetTypeBuilderChildType(BNTypeBuilder* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeBuilderChildType"
        )]
		internal static extern BNTypeWithConfidence BNGetTypeBuilderChildType(
			
			// BNTypeBuilder* type
		    IntPtr type  
		);
	}
}