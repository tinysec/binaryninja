using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLanguageRepresentationFunction* BNCreateLanguageRepresentationFunction(BNLanguageRepresentationFunctionType* type, BNArchitecture* arch, BNFunction* func, BNHighLevelILFunction* highLevelIL)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLanguageRepresentationFunction"
        )]
		internal static extern IntPtr BNCreateLanguageRepresentationFunction(
			
			// BNLanguageRepresentationFunctionType* type
		    IntPtr type  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNHighLevelILFunction* highLevelIL
		    IntPtr highLevelIL  
		);
	}
}