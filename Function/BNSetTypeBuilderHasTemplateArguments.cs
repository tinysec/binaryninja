using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderHasTemplateArguments(BNTypeBuilder* type, bool hasTemplateArguments)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetTypeBuilderHasTemplateArguments"
        )]
		internal static extern void BNSetTypeBuilderHasTemplateArguments(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// bool hasTemplateArguments
		    bool hasTemplateArguments  
			
		);
	}
}