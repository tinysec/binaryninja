using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetAnalysisTypeByRef(BNBinaryView* view, BNNamedTypeReference* @ref)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAnalysisTypeByRef"
        )]
		internal static extern IntPtr BNGetAnalysisTypeByRef(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNNamedTypeReference* _ref
		    IntPtr _ref  
			
		);
	}
}