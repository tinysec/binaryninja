using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNGetLanguageRepresentationILFunction(BNLanguageRepresentationFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLanguageRepresentationILFunction"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationILFunction(
			
			// BNLanguageRepresentationFunction* func
		    IntPtr func  
		);
	}
}