using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextLine* BNGetLanguageRepresentationFunctionTypeFunctionTypeTokens(BNLanguageRepresentationFunctionType* type, BNFunction* func, BNDisassemblySettings* settings, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLanguageRepresentationFunctionTypeFunctionTypeTokens"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionTypeFunctionTypeTokens(
			
			// BNLanguageRepresentationFunctionType* type
		    IntPtr type  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}